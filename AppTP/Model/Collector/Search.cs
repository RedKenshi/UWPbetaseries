using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTP.Model.Datas;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppTP.Model.Collector
{
    class Search
    {
        private static IList<Result> resultsSet;
        private static IList<Serie> resultsSerie;
        private static IList<Film> resultsFilm;

        public static IList<Result> get(String[] keywords, int nbpp, String order){
           
            //launchRequest("serie",keywords, 8, "popularity");
            launchRequest("film", keywords, 8, "popularity");

            return resultsSet;
        }

        private static void launchRequest(String type, String[] keywords, int nbpp, String order){
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(URL.getURL(type, keywords, nbpp, order));
            httpWebRequest.Method = "GET";
            switch (type) {
                case "serie":
                    httpWebRequest.BeginGetResponse(receiveSerieRequest, httpWebRequest);
                    break;
                case "film":
                    httpWebRequest.BeginGetResponse(receiveFilmRequest, httpWebRequest);
                    break;
            }
        }

        private static void receiveSerieRequest(IAsyncResult result)
        {
            HttpWebRequest request = (HttpWebRequest)result.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result);
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream())){
                string json = streamReader.ReadToEnd();
                dynamic serieResultsD = JsonConvert.DeserializeObject(json);
                foreach (dynamic serieResult in serieResultsD.shows)
                {
                    string innerJson = JsonConvert.SerializeObject(serieResult, Formatting.Indented);
                    Serie aSerie = JsonConvert.DeserializeObject<Serie>(innerJson);
                    aSerie.print();
                    resultsSerie.Add(aSerie);
                    Result aResult = new Result(aSerie);
                    resultsSet.Add(new Result(aSerie));
                    aResult.print();
                }
            }
        }

        private static void receiveFilmRequest(IAsyncResult result){
            HttpWebRequest request = (HttpWebRequest)result.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result);
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream())){
                string json = streamReader.ReadToEnd();
                dynamic filmResultsD = JsonConvert.DeserializeObject(json);
                foreach (dynamic filmResult in filmResultsD.movies) {
                    string innerJson = JsonConvert.SerializeObject(filmResult, Formatting.Indented);
                    Film aFilm = JsonConvert.DeserializeObject<Film>(innerJson);
                    aFilm.print();
                    resultsFilm.Add(aFilm);
                    Result aResult = new Result(aFilm);
                    resultsSet.Add(new Result(aFilm));
                    aResult.print();
                }
            }
        }
    }
}
