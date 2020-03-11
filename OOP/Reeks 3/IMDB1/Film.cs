using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB1
{
    public enum Genre
    {
        Surreal,
        Action,
        Adventure,
        Comedy,
        Crime,
        Drama,
        Fantasy,
        Historical,
        HistoricalFiction,
        Horror,
        MagicalRealism,
        Mystery,
        ParanoidFiction,
        Philosophical,
        Political,
        Romance,
        Saga,
        Satire,
        ScienceFiction,
        Social,
        Speculative,
        Thriller,
        Urban,
        Western,
        Animated,
        LiveActionScripted,
        LiveActionUnscripted,
        Other
    }
    class Film
    {
        private List<float> Ratings = new List<float>();
        private List<Actor> Actors = new List<Actor>();
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Film(string title, string producer, string director, Genre genre, DateTime releaseDate)
        {
            Title = title;
            Producer = producer;
            Director = director;
            Genre = genre;
            ReleaseDate = releaseDate;
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
            string film = $"Film: {Title} \n\tProduced by: {Producer}\n\tDirector: {Director}\n\tGenre: {Genre}\n\tRelease date: {ReleaseDate.ToLongDateString()}";
            if (Ratings != null)
            {
                film += $"\n\tRating: {AverageList()} / 5";
            }
            if (Actors != null)
            {
                foreach (Actor acteur in Actors)
                {
                    film += $"\n{acteur}";
                }
            }
            return film.ToString();
        }
    }
}
