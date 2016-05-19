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
    class FilmManager
    {
        private static List<Datas.Film> _films = new List<Datas.Film>();
        private ObservableCollection<Datas.Film> Films;

        public FilmManager()
        {
           

     
        }



        public IEnumerable<Datas.Film> GetAllFilms()
        {
            
            return _films;
        }

    }
}
