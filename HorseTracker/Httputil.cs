using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HorseTracker
{
    class Httputil
    {
        public string Post(string func, string postData)
        {
            string res;
            string url = "http://aaacomputerrepairs.net/rest/api?rquest=";
            url += func;
            WebRequest request = WebRequest.Create(url);
            request.Method ="POST";
            request.ContentType = "application/x-www-form-urlencoded";
            

            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.WriteLine(postData);
                writer.Close();
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                res = reader.ReadToEnd();
                //System.Console.WriteLine("POST Result:");
                //System.Console.WriteLine(res);
            }

            char[] trash = { '{', '}', '\"' };

            return res.Trim(trash).Replace("\"", string.Empty);
        }

        public string Get(string func)
        {
            string res;
            string url = "http://aaacomputerrepairs.net/rest/api?rquest=";
            url += func;
            WebClient webClient = new WebClient();

            using (StreamReader reader = new StreamReader(webClient.OpenRead(url)))
            {
                res = reader.ReadToEnd();
                return res;
            }
        }

        public string Get(string func, string postData)
        {
            string res;
            string url = "http://aaacomputerrepairs.net/rest/api?rquest=";
            url += func;
            url += postData;
            WebClient webClient = new WebClient();

            using (StreamReader reader = new StreamReader(webClient.OpenRead(url)))
            {
                res = reader.ReadToEnd();
                return res;
            }
        }


    }      
}
