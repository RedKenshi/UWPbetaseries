using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppTP.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ListFilmsViewModel>();
            SimpleIoc.Default.Register<ListSeriesViewModel>();
            SimpleIoc.Default.Register<ListResultsViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ListFilmsViewModel ListFilm
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ListFilmsViewModel>();
            }
        }
        public ListSeriesViewModel ListSerie
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ListSeriesViewModel>();
            }
        }
        public ListResultsViewModel ListResult
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ListResultsViewModel>();
            }
        }

    }
}
