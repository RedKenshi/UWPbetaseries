using AppTP.Model.Datas;
using AppTP.Model.Managers;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.ViewModel
{
    public class ListSeriesViewModel : ViewModelBase
    {
        private ObservableCollection<Serie> _series;
        public ObservableCollection<Serie> Series
        {
            get { return _series; }
            set
            {
                _series = value;
                RaisePropertyChanged();
            }
        }

        private Serie _selectedSerie;
        public Serie SelectedSerie
        {
            get { return _selectedSerie; }
            set
            {
                _selectedSerie = value;
                RaisePropertyChanged();
            }
        }
        public ListSeriesViewModel()
        {
            var dbSeries = new SeriesManager().GetAllSeries();
            Series = new ObservableCollection<Serie>(dbSeries);
        }
    }
}
