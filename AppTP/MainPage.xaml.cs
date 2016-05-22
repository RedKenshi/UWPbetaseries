using AppTP.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AppTP.Model.Collector;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppTP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void ListSeries_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ListSeriesView));
            GetSerie.get(1);//pour tester
        }
        private void ListFilms_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ListFilmsView));
            GetFilm.get(1);//pour tester
        }
        private void ListResults_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ListResultsView));
            String[] keywords = new string[] {"you", "me"};
            Search.get(keywords, 8, "popularity");
        }
    }
}
