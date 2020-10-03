using Microsoft.Reporting.WebForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestReport1
{
    public partial class MainViewer : System.Web.UI.Page
    {
        string strRptCaptionName;
        string ReportName;
        object datalist;
        string spName;
        string dataset;
        string strvarapara;
        string strvaraparaValue;
        string strUrl;
        string[] strvaraparaArry;
        string[] strvaraparaValueArry;
        Hashtable htParams = new Hashtable();
        //Hashtable htParams1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["varRptCaptionName"] != null) 
            {
                strRptCaptionName = Decrypt(HttpUtility.UrlDecode(Request.QueryString["varRptCaptionName"]));
                //strUrl = Decrypt(HttpUtility.UrlDecode(Request.QueryString["ImageUrl"]));

            }

            ReportName = Decrypt(HttpUtility.UrlDecode(Request.QueryString["RptName"]));
            spName = Decrypt(HttpUtility.UrlDecode(Request.QueryString["spName"]));
            dataset = Decrypt(HttpUtility.UrlDecode(Request.QueryString["varDataSet"]));
            strvarapara = Decrypt(HttpUtility.UrlDecode(Request.QueryString["varapara"]));
            strvaraparaValue = Decrypt(HttpUtility.UrlDecode(Request.QueryString["varaparaValue"]));


            strvaraparaArry = strvarapara.Split(',');
            strvaraparaValueArry = strvaraparaValue.Split(',');
            
            for (int i = 0; i < strvaraparaArry.Length; i++)
            {
                htParams.Add(strvaraparaArry[i], strvaraparaValueArry[i]);
            }
            //this.ReportViewer1.ShowPrintButton = true;
           // this.ReportViewer1.Reset();
            if (!IsPostBack)
            {
                populateData();
            }
        }

        private void populateData()
        {
            using (PharmaERPTestEntities dc = new PharmaERPTestEntities())
            {
                // var v = (from a in dc.f_RptGetAdministrationdata()
                //          select a);
                // ReportDataSource rdc = new ReportDataSource("AdministrationDataSet", v.ToList());



                ReportDataSource rdc = new ReportDataSource(dataset,
                ExecuteDataTable(
                        string.Format(ConfigurationManager.ConnectionStrings["PharmaERPTestEntities"].ConnectionString),//  PharmaERPRptConnectionString
                        spName,
                        CommandType.StoredProcedure,
                        htParams
                        ));

                //if (htParams.Count > 0)
                //{

                //}
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/" + ReportName + ".rdlc");
                ReportViewer1.LocalReport.EnableExternalImages = true;

                if (!String.IsNullOrEmpty(strRptCaptionName)) 
                {
                    ReportParameter s;
                    //  r = new ReportParameter("RptName", strRptCaptionName, true);
                    //  string imagePath = new Uri(Server.MapPath("~/assets/pages/img/login/" + strUrl + "")).AbsoluteUri; 

                    //string imagePath = new Uri(Server.MapPath("~/assets/pages/img/login/" + strUrl + "")).AbsoluteUri; 

                    //string imagePath = new Uri(Server.MapPath(""+strUrl+"")).AbsoluteUri;
                    //s = new ReportParameter("ImagePath", imagePath, true);
                    //ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { r, s });

                    //ReportViewer1.LocalReport.SetParameters(s);

                }

                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(rdc); 
                //ReportViewer1.LocalReport.EnableExternalImages = true;
                ReportViewer1.ShowPrintButton = true;
                ReportViewer1.LocalReport.Refresh();
            }
        }
        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static DataTable ExecuteDataTable(string connectionString, string cmdText, CommandType cmdType, Hashtable htParams)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;
            conn.Open();


            foreach (string strParam in htParams.Keys)
                cmd.Parameters.Add(new SqlParameter(strParam, htParams[strParam]));


            cmd.CommandTimeout = 6000;

            ad.SelectCommand = cmd;
            ad.Fill(dt);
            conn.Close();
            ad.Dispose();

            return dt;
        }

       




    }
    }