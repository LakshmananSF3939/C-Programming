using System;

namespace MovieTicketBooking
{
    public class TheatreDetails
    {
      /// <summary>
      /// Represent as Creating theatre ID
      /// </summary>
      private static int s_theatreID=300;
      /// <summary>
      /// Represent as String format theatre id
      /// </summary>
      /// <value></value>
      public string TheatreID { get; set; }  
      /// <summary>
      /// Represent as Theatre name
      /// </summary>
      /// <value></value>
      public string TheatreName { get; set; }
      /// <summary>
      /// Represent as Theatre location
      /// </summary>
      /// <value></value>
      public string Location { get; set; }
      /// <summary>
      /// Theatre detail constructor
      /// </summary>
      /// <param name="theatreName"></param>
      /// <param name="location"></param>
      public TheatreDetails(string theatreName,string location)
      {
        s_theatreID++;
        TheatreID="TID"+s_theatreID;
        TheatreName=theatreName;
        Location=location;
      }
      /// <summary>
      /// File manupulation constructor
      /// </summary>
      /// <param name="data"></param>
      public TheatreDetails(string data)
      {
        string[] values=data.Split(',');
        s_theatreID=int.Parse(values[0].Remove(0,3));
        TheatreID=values[0];
        TheatreName=values[1];
        Location=values[2];
      }
    }
}
