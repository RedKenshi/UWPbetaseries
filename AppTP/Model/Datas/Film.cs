using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Datas
{
    public class Movie
    {

        public int Id { get; set; }
        public int TVDBId { get; set; }
        public String IMDBId { get; set; }
        public String Title { get; set; }
        public string Description { get; set; }


        public Movie(int id, int tvdbid, String imdbid, String title, string description)
        {
            Id = id;
            Title = title;
        }

    }

}
