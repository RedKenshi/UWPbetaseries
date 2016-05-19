using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTP.Model.API;

namespace AppTP.Model
{
    public abstract class URL
    {
        private static String _baseRoute = "http://api.betaseries.com/";
        
        public static String getURL(int id, String type) {

            String requestURL;
            String bodyRoute = "erreur";

            switch (type) {
                case "serie":
                    bodyRoute = "shows/display";
                    break;
                case "film":
                    bodyRoute = "movies/movie";
                    break;
            }
            return requestURL = _baseRoute + bodyRoute + "?id=" + id + " & key=" + SessionAPI.getKey();
        }
    }
}
