using AppTP.Model.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Managers
{
    class SeriesManager
    {
        private static List<Serie> _series = new List<Serie>();

        static SeriesManager()
        {
            /*_series.Add(new Serie(1, "Serie1", "Antoine"));
            _series.Add(new Serie(2, "Serie2", "Géraldine"));
            _series.Add(new Serie(3, "Serie3", "Virginie"));
            _series.Add(new Serie(4, "Serie4", "Laure"));*/
        }
        public IEnumerable<Serie> GetAllSeries()
        {
            return _series;
        }
    }
}
