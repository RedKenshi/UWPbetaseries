using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using AppTP.Model.Datas;
using AppTP.Model.Managers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using AppTP.Model.Datas;
using AppTP;
using AppTP.ViewModel;

namespace AppTP.ViewModel
{
    public class ListFilmsViewModel : ViewModelBase
    {
        private ObservableCollection<Model.Datas.Movie> _films;
        public ObservableCollection<Model.Datas.Movie> Films
        {
            get { return _films; }
            set
            {
                _films = value;
                RaisePropertyChanged();
            }
        }

        private Model.Datas.Movie _selectedFilm;
        

        public Model.Datas.Movie SelectedFilm
        {
            get { return _selectedFilm; }
            set
            {
                _selectedFilm = value;
                RaisePropertyChanged();
            }
        }
        public async void Load()
        {
            var request = HttpWebRequest.CreateHttp("http://api.betaseries.com/movies/movie?key=a2f65fa317ad&id=1");

            var response = await request.GetResponseAsync();

            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    var responseAsString = sr.ReadToEnd();

                    var resultObject = JsonConvert.DeserializeObject<MovieResponse>(responseAsString);

                    Films.Add(resultObject.Movie);
                }
            }

        }
        public ListFilmsViewModel()
        {
            var dbFilms = new MoviesManager().GetAllFilms();
            Films = new ObservableCollection<Model.Datas.Movie>(dbFilms);


        }


    }
}
