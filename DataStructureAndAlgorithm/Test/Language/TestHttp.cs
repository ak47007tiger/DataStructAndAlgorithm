using System;
using System.IO;
using System.Net;

namespace Test
{
    public class TestHttp
    {
        public void Test()
        {
            HttpWebRequest req =
            (HttpWebRequest)HttpWebRequest.Create("https://blog.csdn.net/ak47007tiger");
            req.Method = "GET";
            using (WebResponse wr = req.GetResponse())
            {
                StreamReader sr = new StreamReader(wr.GetResponseStream());
                string v = sr.ReadToEnd();
                File.WriteAllText("d:/response.txt", v);
                Console.WriteLine(v);
            }
        }
    }
}