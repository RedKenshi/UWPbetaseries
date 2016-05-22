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
    public class GetFilm
    {
        private static Film askedFilm;

        public static Film get(int id) {
            launchRequest(id);
            return askedFilm;
        }

        private static void launchRequest(int id){ 
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(URL.getURL(id, "film"));
            httpWebRequest.Method = "GET";
            httpWebRequest.BeginGetResponse(receiveRequest, httpWebRequest);
        }

        private static void receiveRequest(IAsyncResult result){
            HttpWebRequest request = (HttpWebRequest) result.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result);
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream())){
                string json = streamReader.ReadToEnd();
                dynamic askedFilmD = JsonConvert.DeserializeObject(json);
                string innerJson = JsonConvert.SerializeObject(askedFilmD.movie, Formatting.Indented);
                System.Diagnostics.Debug.WriteLine("innerJson : " + innerJson);
                askedFilm = JsonConvert.DeserializeObject<Film>(innerJson);
            }
        }
    }
}
