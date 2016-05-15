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
    public class ListResultsViewModel : ViewModelBase
    {
        private ObservableCollection<Result> _results;
        public ObservableCollection<Result> Results
        {
            get { return _results; }
            set
            {
                _results = value;
                RaisePropertyChanged();
            }
        }

        private Result _selectedResult;
        public Result SelectedResult
        {
            get { return _selectedResult; }
            set
            {
                _selectedResult = value;
                RaisePropertyChanged();
            }
        }
        public ListResultsViewModel()
        {
            var dbResults = new ResultsManager().GetAllResults();
            Results = new ObservableCollection<Result>(dbResults);
        }
    }
}
