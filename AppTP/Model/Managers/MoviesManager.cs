using AppTP.Model.Datas;
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
        private static List<Datas.Movie> _films = new List<Datas.Movie>();
        private ObservableCollection<Datas.Movie> Films;

        public MoviesManager()
        {
           

     
        }



        public IEnumerable<Datas.Movie> GetAllFilms()
        {
            
            return _films;
        }

    }
}
