using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Extentions
{

    public static class HttpWebRequestHelper
    {
        public static string GetWebContent(string url, string userAgent)
        {
            if (string.IsNullOrEmpty(url))
            {
                return string.Empty;
            }
            if (url.IndexOf("http") == -1)
            {
                url = "http://" + url;
            }

            Uri uri = new Uri(url);
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(uri);
            myReq.Timeout = 5000;
            myReq.UserAgent = userAgent;
            myReq.Accept = "*/*";
            myReq.KeepAlive = true;
            myReq.ContentType = "text/html;";
            myReq.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            HttpWebResponse result = (HttpWebResponse)myReq.GetResponse();
            try
            {
                var receviceStream = result.GetResponseStream();
                if (receviceStream != null)
                {
                    StreamReader readerOfStream = new StreamReader(receviceStream,
                        System.Text.Encoding.GetEncoding("utf-8"));
                    string strHtml = readerOfStream.ReadToEnd();
                    readerOfStream.Close();
                    receviceStream.Close();
                    result.Close();
                    return strHtml;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }
    }
}
