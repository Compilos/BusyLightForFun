using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace BusyLightMain
{
    public class XmlService
    {
        public string GetXml(string serviceUrl)
        {


            //request.Accept = "application/xrds+xml";  
            
            string responseText;

            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential("carr@lb.dk", "Topper01");
                HttpWebRequest request = WebRequest.Create(serviceUrl) as HttpWebRequest;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                WebHeaderCollection header = response.Headers;

                var encoding = ASCIIEncoding.ASCII;
                
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    responseText = reader.ReadToEnd();
                }
            }


            return responseText;

        }

        //private string GetHttpResponse(string requestUrl)
        //{
        //    var str = string.Empty;
        //    var httpWebResponse = (HttpWebResponse)null;

        //    try
        //    {
        //        var httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUrl);

        //        if (headerParameters != null)
        //        {
        //            foreach (string key in headerParameters.Keys)
        //            {
        //                httpWebRequest.Headers.Add(key, headerParameters[key]);
        //            }
        //        }

        //        httpWebRequest.ContentType = "text/xml;charset=UTF-8";
        //        httpWebRequest.Method = "POST";

        //        var bytes = Encoding.ASCII.GetBytes(soapRequestDefinition);
        //        if (bytes.Length > 0)
        //        {
        //            using (var requestStream = httpWebRequest.GetRequestStream())
        //            {
        //                requestStream.Write(bytes, 0, bytes.Length);
        //            }
        //        }

        //        httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //        using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.Default))
        //        {
        //            str = reader.ReadToEnd().Trim();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        httpWebResponse?.Close();
        //    }
        //    return str;
        //}
    }
}
