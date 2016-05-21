using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Datas
{
    public class Film
    {
        public int id { get; set; }
        public String title { get; set; }
        public String original_title { get; set; }
        public String url { get; set; }
        public String poster { get; set; }
        public String backdrop { get; set; }
        public String production_year { get; set; }
        public String release_date { get; set; }
        public String director { get; set; }
        public String length { get; set; }
        public IList<string> genres { get; set; }
        public String synopsis { get; set; }
        public String language { get; set; }
        public Dictionary<string, string> notes { get; set; }
        public String followers { get; set; }
        public String similars { get; set; }
        public String characters { get; set; }

        public Film() {

        }

        public void print() {
            System.Diagnostics.Debug.WriteLine("ID : " + id + ", titre : " + title + ", titre original : " + original_title);
            System.Diagnostics.Debug.WriteLine("url : " + url);
            System.Diagnostics.Debug.WriteLine("Poster : " + poster + ", backdrop : " + backdrop);
            System.Diagnostics.Debug.WriteLine("production_year : " + production_year + ", release_date : " + release_date);
            System.Diagnostics.Debug.WriteLine("director : " + director + ", length : " + length + ", language : " + language);
            System.Diagnostics.Debug.WriteLine("synopsis : " + synopsis);
            System.Diagnostics.Debug.WriteLine("followers : " + followers + ", similars : " + similars + ", characters: " + characters);
            foreach (String genre in genres){
                System.Diagnostics.Debug.WriteLine("Genres : " + genre);
            }
            foreach (KeyValuePair < string, string> note in notes){
                System.Diagnostics.Debug.WriteLine(note.Key + " : " + note.Value);
            }
        }
    }
}

