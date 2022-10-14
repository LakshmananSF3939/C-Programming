using System;

namespace OnlineMedicalStore
{
    public class UserDetails
    {
        private static int s_userID=1000;
        public string UserID { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }
        public UserDetails(string name,int age,string city,long mobile,double balance)
        {
            s_userID++;
            UserID="UID"+s_userID;
            UserName=name;
            Age=age;
            City=city;
            PhoneNumber=mobile;
            Balance=balance;
        }
        public UserDetails(string data)
        {
            string[] values=data.Split(',');
            s_userID=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            UserName=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            PhoneNumber=long.Parse(values[4]);
            Balance=double.Parse(values[5]);
        }
    }
}
