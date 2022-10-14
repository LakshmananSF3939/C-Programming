using System;

namespace MovieTicketBooking
{
    public class MovieDetails
    {
        /// <summary>
        /// Represent as List of movie id
        /// </summary>
        private static int s_movieID=500;
        /// <summary>
        /// Represent as String format id
        /// </summary>
        /// <value></value>
        public string MoviesID { get; set; }
        /// <summary>
        ///Represnt as Movie names
        /// </summary>
        /// <value></value>
        public string MovieName { get; set; }
        /// <summary>
        ///Represent as Different languges
        /// </summary>
        /// <value></value>
        public string Language { get; set; }
        /// <summary>
        /// Represent as Movies constructor
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="language"></param>

        public MovieDetails(string movieName,string language)
        {
            s_movieID++;
            MoviesID="MID"+s_movieID;
            MovieName=movieName;
            Language=language;
        }
        /// <summary>
        /// Represent as file handling constructor
        /// </summary>
        /// <param name="data"></param>
        public MovieDetails(string data)
        {
            string[] values=data.Split(',');
            s_movieID=int.Parse(values[0].Remove(0,3));
            MoviesID=values[0];
            MovieName=values[1];
            Language=values[2];
        }
    }
}
