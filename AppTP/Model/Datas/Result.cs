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

        public Result(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
