using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Datas
{
    public class Result
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }

        public Result(Serie aSerie)
        {
            Id = aSerie.id;
            Name = aSerie.title;
            Type = "serie";
        }

        public Result(Film aFilm)
        {
            Id = aFilm.id;
            Name = aFilm.title;
            Type = "film";
        }
    }
}
