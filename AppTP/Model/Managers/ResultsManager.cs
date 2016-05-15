using AppTP.Model.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Managers
{
    class ResultsManager
    {
        private static List<Result> _results = new List<Result>();

        static ResultsManager()
        {
            _results.Add(new Result(1, "Result1", "Antoine"));
            _results.Add(new Result(2, "Result2", "Géraldine"));
            _results.Add(new Result(3, "Result3", "Virginie"));
            _results.Add(new Result(4, "Result4", "Laure"));
        }
        public IEnumerable<Result> GetAllResults()
        {
            return _results;
        }
    }
}
