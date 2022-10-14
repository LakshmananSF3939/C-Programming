using System;

namespace MovieTicketBooking
{
    public class PersonalDetails
    {
        /// <summary>
        /// Represent as User name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Represent as User age
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// Represent as User mobile Number
        /// </summary>
        /// <value></value>
        public long MobileNumber { get; set; }
        /// <summary>
        /// Represent as Default Contructor
        /// </summary>
        public PersonalDetails()
        {
            
        }
        /// <summary>
        /// Personal details are passing through a contsructor variable
        /// </summary>
        /// <param name="name">Register Name</param>
        /// <param name="age">Age</param>
        /// <param name="number">Mobile Number</param>
        public PersonalDetails(string name,int age,long number)
        {
            Name=name;
            Age=age;
            MobileNumber=number;
        }
    }
}
