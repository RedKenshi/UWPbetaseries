using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.Datas
{
    public class Serie
    {
        public int id { get; set; }
        public String thetvdb_id { get; set; }
        public String imdb_id { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public String seasons { get; set; }
        public IList<Dictionary<String,int>> seasons_details { get; set; }
        public String episodes { get; set; }
        public String followers { get; set; }
        public String similars { get; set; }
        public String characters { get; set; }
        public String creation { get; set; }
        public IList<string> genres { get; set; }
        public String length { get; set; }
        public String network { get; set; }
        public String rating { get; set; }
        public String status { get; set; }
        public String language { get; set; }
        public Dictionary<string, string> notes { get; set; }
        public Dictionary<string, string> images { get; set; }
        public IList<string> aliases { get; set; }

        public Serie(){

        }

        public void print()
        {
            System.Diagnostics.Debug.WriteLine("ID : " + id + ", titre : " + title + ", thetvdb_id : " + thetvdb_id + ", imdb_id : " + imdb_id);
            System.Diagnostics.Debug.WriteLine("description : " + description);
            System.Diagnostics.Debug.WriteLine("seasons : " + seasons);
            foreach (Dictionary<String,int> season_details in seasons_details)
            {
                System.Diagnostics.Debug.WriteLine("Saison : " + season_details["number"] + " => " + season_details["episodes"] + " épisodes");
            }
            System.Diagnostics.Debug.WriteLine("episodes : " + episodes + ", followers : " + followers + ", similars : " + similars + ", characters : " + characters + ", creation : " + creation);
            foreach (String genre in genres)
            {
                System.Diagnostics.Debug.WriteLine("Genres : " + genre);
            }
            System.Diagnostics.Debug.WriteLine("length : " + length + ", network : " + network + ", rating : " + rating + ", status : " + status + ", language : " + language);

            foreach (KeyValuePair<string, string> note in notes)
            {
                System.Diagnostics.Debug.WriteLine(note.Key + " : " + note.Value);
            }
            foreach (KeyValuePair<string, string> image in images)
            {
                System.Diagnostics.Debug.WriteLine(image.Key + " : " + image.Value);
            }
            foreach (String alias in aliases)
            {
                System.Diagnostics.Debug.WriteLine("Alias : " + alias);
            }
        }
    }
}