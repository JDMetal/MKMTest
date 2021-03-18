using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatagridBDD_test.API_CLASES
{
    class OAuthHeader
    {
        //Acces App Token
        protected String appToken = "ReplaceThis"; //your mkm appToken
        //Access App Secret
        protected String appSecret = "ReplaceThis";//your mkm appSecret
        //Access Token
        protected String accessToken = "ReplaceThis";//your mkm AccesToken
        //Access Token Secret
        protected String accessSecret = "ReplaceThis";//your mkm AccesSecret
        //OAuth Signature method
        protected String signatureMethod = "HMAC-SHA1";
        //OAuth version
        protected String version = "1.0";
        //Diccionari amb els headers
        protected IDictionary<String, String> headerParams;

        public OAuthHeader()
        {
            String nonce = "53eb1f44909d6";
            String timestamp = "1407917892";
            //Inicialització de les variables del header
            this.headerParams = new Dictionary<String, String>();
            this.headerParams.Add("oauth_consumer_key", this.appToken);
            this.headerParams.Add("oauth_token", this.accessToken);
            this.headerParams.Add("oauth_nonce", nonce);
            this.headerParams.Add("oauth_timestamp", timestamp);
            this.headerParams.Add("oauth_signature_method", this.signatureMethod);
            this.headerParams.Add("oauth_version", this.version);
        }

        //autentificacó a través del header
        public String getAuthorizationHeader(String method, String url)
        {
            //realm parameter al header
            this.headerParams.Add("realm", url);

            String baseString = method.ToUpper()
                              + "&"
                              + Uri.EscapeDataString(url)
                              + "&";

            //filtrar paràmetres del header
            SortedDictionary<String, String> encodedParams = new SortedDictionary<String, String>();
            foreach (KeyValuePair<String, String> parameter in this.headerParams)
            {
                if (false == parameter.Key.Equals("realm"))
                {
                    encodedParams.Add(Uri.EscapeDataString(parameter.Key), Uri.EscapeDataString(parameter.Value));
                }
            }

            //Creació del paramStrings sumant la key i el value
            List<String> paramStrings = new List<String>();
            foreach (KeyValuePair<String, String> parameter in encodedParams)
            {
                paramStrings.Add(parameter.Key + "=" + parameter.Value);
            }
            String paramString = Uri.EscapeDataString(String.Join<String>("&", paramStrings));
            baseString += paramString;

            //OAuth signature
            String signatureKey = Uri.EscapeDataString(this.appSecret) + "&" + Uri.EscapeDataString(this.accessSecret);
            HMAC hasher = HMACSHA1.Create();
            hasher.Key = Encoding.UTF8.GetBytes(signatureKey);
            Byte[] rawSignature = hasher.ComputeHash(Encoding.UTF8.GetBytes(baseString));
            String oAuthSignature = Convert.ToBase64String(rawSignature);

            //Afegir la signatura al header
            this.headerParams.Add("oauth_signature", oAuthSignature);

            //Crear l'string del header
            List<String> headerParamStrings = new List<String>();
            foreach (KeyValuePair<String, String> parameter in this.headerParams)
            {
                headerParamStrings.Add(parameter.Key + "=\"" + parameter.Value + "\"");
            }
            String authHeader = "OAuth " + String.Join<String>(", ", headerParamStrings);

            return authHeader;
        }
    }
}
