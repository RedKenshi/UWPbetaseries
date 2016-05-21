using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTP.Model.Datas;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace AppTP.Model.Collector
{
    class Search
    {
        private static IList<Result> resultSet;

        public static IList<Result> get(String type, IList<String> keywords, int nbpp, int order)
        {
            launchRequest(type, keywords, nbpp, order);
            return resultSet;
        }

        private static void launchRequest(String type, IList<String> keywords, int nbpp, int order)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(URL.getURL(type, keywords, nbpp, order));
            httpWebRequest.Method = "GET";
            httpWebRequest.BeginGetResponse(receiveRequest, httpWebRequest);
        }

        private static void receiveRequest(IAsyncResult result)
        {
            HttpWebRequest request = (HttpWebRequest)result.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result);

            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                string json = streamReader.ReadToEnd();
                dynamic askedxxxxxD = JsonConvert.DeserializeObject(json);
                string innerJson = JsonConvert.SerializeObject(askedxxxxxD.show, Formatting.Indented);
                Result askedxxxxx = JsonConvert.DeserializeObject<Result>(innerJson);

                //resultSet =
            }
        }
    }
}
