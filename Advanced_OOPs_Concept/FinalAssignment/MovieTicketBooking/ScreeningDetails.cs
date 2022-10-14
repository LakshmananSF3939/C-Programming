using System;

namespace MovieTicketBooking
{
    public class ScreeningDetails
    {
        /// <summary>
        /// Represent as Creating movie id
        /// </summary>
        /// <value></value>
        public string MoviesID { get; set; }
        /// <summary>
        /// Represent as String format theatre id
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }
        /// <summary>
        /// Represent as Available seat in theatre
        /// </summary>
        /// <value></value>
        public int NoOfSeatsAvailable { get; set; }
        /// <summary>
        ///Represent as One ticket price
        /// </summary>
        /// <value></value>
        public double TicketPrice { get; set; }
        /// <summary>
        /// multiple movies and theatre in a contructer to pass and store in a property
        /// </summary>
        /// <param name="movieID"></param>
        /// <param name="theatreID"></param>
        /// <param name="counts"></param>
        /// <param name="price"></param>

        public ScreeningDetails(string movieID,string theatreID,int counts,double price)
        {
            MoviesID=movieID;
            TheatreID=theatreID;
            NoOfSeatsAvailable=counts;
            TicketPrice=price;
        }
        /// <summary>
        /// File manupulation constructor
        /// </summary>
        /// <param name="data"></param>
        public ScreeningDetails(string data)
        {
            string[] values=data.Split(',');
            MoviesID=values[0];
            TheatreID=values[1];
            NoOfSeatsAvailable=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }
    }
}
