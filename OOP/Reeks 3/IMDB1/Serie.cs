using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB1
{
    class Serie
    {
        private List<float> Ratings = new List<float>();
        private List<Actor> Actors = new List<Actor>();
        public string Title { get; set; }
        public int Seasons { get; set; }

        public Serie(string title, int seasons)
        {
            Title = title;
            Seasons = seasons;
        }
        public bool AddRating(int rating)
        {
            if (rating > 0 && rating < 6)
            {
                Ratings.Add(rating);
                AverageList();
                return true;
            }
            return false;
        }
        private string AverageList()
        {
            if (Ratings.Count > 0 && Ratings.Count < 3)
            {
                return Ratings.Average().ToString("0.00");
            }
            else if (Ratings.Count > 2)
            {
                float average = 0;
                float count = 0;
                Ratings.Sort();
                int lowestNumber = Ratings.LastIndexOf(Ratings.First());
                int highestNumber = Ratings.IndexOf(Ratings.Last());
                for (int i = lowestNumber + 1; i < highestNumber; i++)
                {
                    average += Ratings[i];
                    count++;
                }
                return (average/count).ToString("0.00");
            }
            return null;
        }
        public bool AddActor(Actor actor)
        {
            if (actor != null)
            {
                Actors.Add(actor);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string serie = $"Title: {Title}\n\tSeasons: {Seasons}";
            if (Ratings != null)
            {
                serie += $"\n\tRating: {AverageList()} / 5";
            }
            if (Actors != null)
            {
                serie += $"\n{Actors}";
            }
            return serie.ToString();
        }
    }
}
