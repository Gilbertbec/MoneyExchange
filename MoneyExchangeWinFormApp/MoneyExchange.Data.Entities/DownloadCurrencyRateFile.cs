namespace MoneyExchange.Data.Entities
{
    using System;
    using System.IO;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using System.Net;

    public class DownloadCurrencyRateFile
    {
        public static void HttpDownloadFile(string url, string path, bool overwrite, Action<string, long, long> callback = null)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string fileName = response.Headers["Content-Disposition"];
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = response.ResponseUri.Segments[response.ResponseUri.Segments.Length - 1];
            }
            else
            {
                fileName = fileName.Remove(0, fileName.IndexOf("filename=") + 9);
            }

            using (Stream responseStream = response.GetResponseStream())
            {
                long totalLength = response.ContentLength;
                using (Stream stream = new FileStream(Path.Combine(path, fileName), overwrite ? FileMode.Create : FileMode.CreateNew))
                {
                    byte[] bArr = new byte[1024];
                    int size;
                    while ((size = responseStream.Read(bArr, 0, bArr.Length)) > 0)
                    {
                        stream.Write(bArr, 0, size);
                        callback?.Invoke(fileName, totalLength, stream.Length);
                    }
                }
            }
        }
    }
}
