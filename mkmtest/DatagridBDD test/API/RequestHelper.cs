using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;

namespace DatagridBDD_test.API_CLASES
{
    public class RequestHelper
    {
        public static Object MKMgetAccount()
        {
            try
            {
                String method = "GET";
                String url = "https://api.cardmarket.com/ws/v2.0/output.json/account";

                HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
                OAuthHeader header = new OAuthHeader();
                request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
                request.Method = method;

                using (var resposta = (HttpWebResponse)request.GetResponse())
                {

                    using (var reader = new StreamReader(resposta.GetResponseStream()))
                    {
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        var objText = reader.ReadToEnd();
                        AccountClass.Root account = (AccountClass.Root)js.Deserialize(objText, typeof(AccountClass.Root));
                        return account;
                    }
                }
            }
            catch
            {
                Console.WriteLine("No s'ha pogut obtenir l'usuari");
                return null;
            }
        }

        public static Object MKMgetStock()
        {
            try
            {
                String method = "GET";
                String url = "https://api.cardmarket.com/ws/v2.0/output.json/stock";

                HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
                OAuthHeader header = new OAuthHeader();
                request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
                request.Method = method;

                using (var resposta = (HttpWebResponse)request.GetResponse())
                {

                    using (var reader = new StreamReader(resposta.GetResponseStream()))
                    {
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        var objText = reader.ReadToEnd();
                        StockClass.Root Stock = (StockClass.Root)js.Deserialize(objText, typeof(StockClass.Root));
                        return Stock;
                    }
                }
            }
            catch
            {
                Console.WriteLine("No s'han pogut obtenir els productes en venta");
                return null;
            }
        }

        public static String MKMGetMessages()
        {
            try
            {
                String method = "GET";
                String url = "https://api.cardmarket.com/ws/v2.0/output.json/account/messages";

                HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
                OAuthHeader header = new OAuthHeader();
                request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
                request.Method = method;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                using (var resposta = (HttpWebResponse)request.GetResponse())
                {

                    using (var reader = new StreamReader(resposta.GetResponseStream()))
                    {
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        var objText = reader.ReadToEnd();
                        StockClass.Root Messages = (StockClass.Root)js.Deserialize(objText, typeof(StockClass.Root));
                        return null;
                    }
                }
            }
            catch
            {
                Console.WriteLine("No s'han pogut obtenir els missatges");
                return null;
            }
        }
    }
}
