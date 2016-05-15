using AppTP.Model.API;
using AppTP.Model.Datas;
using AppTP.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Managers
{
    class MoviesManager
    {
        private static List<API.Movie> _films = new List<API.Movie>();
        private ObservableCollection<API.Movie> Films;

        public MoviesManager()
        {
           
            _films.Add(new API.Movie(2, 2, "Géraldine","titre1","description1"));
            _films.Add(new API.Movie(3, 3, "Virginie", "titre2", "description2"));
            _films.Add(new API.Movie(4, 4, "Laure", "titre3", "description3"));
     
        }



        public IEnumerable<API.Movie> GetAllFilms()
        {
            
            return _films;
        }

    }
}
