using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Serialization;

namespace TestReport1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static dynamic GetDataReport(string strParamterValue, string strRptCaptionName)
        {
            string RptCaptionName = HttpUtility.UrlEncode(Encrypt(strRptCaptionName));
            string RptName = HttpUtility.UrlEncode(Encrypt("Report3"));
            string varspName = HttpUtility.UrlEncode(Encrypt("_RptGetCalcEmpMonthDues"));
            string varDataSet = HttpUtility.UrlEncode(Encrypt("DataSet1"));
            string varapara = HttpUtility.UrlEncode(Encrypt("@Company_Id,@Branch_Id,@Emp_Serial_No,@Emp_Code,@Project_Id,@Admin_Id,@Dept_Id,@HireItemId,@SenderEmp_Serial_No"));
            string varaparaValue = HttpUtility.UrlEncode(Encrypt(strParamterValue));
            var url = string.Format("../MainViewer.aspx?RptName={0}&spName={1}&varDataSet={2}&varapara={3}&varaparaValue={4}&varRptCaptionName={5}", RptName, varspName, varDataSet, varapara, varaparaValue, RptCaptionName);
            //  Page.ClientScript.RegisterStartupScript(this.GetType(), "open", "window.open('" + url + "','','fullscreen=yes');", true);
            return url;
        }


        private static string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }
}