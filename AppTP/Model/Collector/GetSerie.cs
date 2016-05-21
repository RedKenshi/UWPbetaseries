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
    public class GetSerie
    {
        private static Serie askedSerie;

        public static Serie get(int id){
            launchRequest(id);
            return askedSerie;
        }

        private static void launchRequest(int id){
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(URL.getURL(id, "serie"));
            httpWebRequest.Method = "GET";
            httpWebRequest.BeginGetResponse(receiveRequest, httpWebRequest);
        }

        private static void receiveRequest(IAsyncResult result){
            HttpWebRequest request = (HttpWebRequest)result.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result);

            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                string json = streamReader.ReadToEnd();
                dynamic askedSerieD = JsonConvert.DeserializeObject(json);
                string innerJson = JsonConvert.SerializeObject(askedSerieD.show, Formatting.Indented);
                askedSerie = JsonConvert.DeserializeObject<Serie>(innerJson);

                askedSerie.print();
            }
        }
    }
}


