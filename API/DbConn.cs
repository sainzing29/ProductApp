//using Bicoders.Hotel.CommonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI
{
    public class DbConnection
    {
        public static string ConnectionString;

        public string GetConnection()
        {
            string conn = "";
            conn = GetConnectionStringFromXml();
            ConnectionString = conn;
            return conn;
        }

      //  EncryptDEcrypt ENCR = new EncryptDEcrypt();
        public string GetConnectionStringFromXml()
        {
          //  string ReportPath = AppDomain.CurrentDomain.BaseDirectory + "App_Data";
            // string ReportPath = System.Web.HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data");
           // DataTable CN_TABLE = new DataTable();
            string CCNNSTR = "";
           // if (System.IO.File.Exists(ReportPath + "\\DATACONN.XML"))
           // {
              //  CN_TABLE.ReadXml(ReportPath + "\\DATACONN.XML");
              //  CN_TABLE.TableName = "CONN";
             //   if (CN_TABLE.Rows.Count > 0)
             //   {

                 //   byte LoginType = 1;


                    //string ServerName = ENCR.psDecrypt(CN_TABLE.Rows[0]["IPADDRESS"].ToString());
                    //string UserId = ENCR.psDecrypt(CN_TABLE.Rows[0]["UID"].ToString());
                    //string Password = ENCR.psDecrypt(CN_TABLE.Rows[0]["PWD"].ToString());
                    //byte LoginType = (byte)CN_TABLE.Rows[0]["SECTYPE"];
                    //string DatabaseName = CN_TABLE.Rows[0]["DATABASE"].ToString();
                 //   if (LoginType == 0)
                 //   {                
                       // CCNNSTR = "Data Source =" + ServerName + "; Initial Catalog = " + DatabaseName + "; Persist Security Info = True; User ID = " + UserId + "; password = " + Password;                     
                 //   }
                   // else
                   // {


                        CCNNSTR = "data source=.\\sqlexpress;initial catalog=DbProduct; integrated security=true";
                  //  }

               // }
           // }
            return CCNNSTR;
        }

    }
}
