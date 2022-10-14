using System;
public delegate void EventManager();
namespace Event 
{
     
    public class Events
    {
        private string _eventName;
        public static event EventManager eventLink=null;
        static int i;
        public  Events(string eventName)
        {
            _eventName=eventName;
        }
       public static void HandleEvent() 
       {
        i=0;
        System.Console.WriteLine("User Registration ");
        System.Console.WriteLine("Starting the following events ");
        eventLink();
       }
       public void ShowEvent()
       {
        ++i;
        System.Console.WriteLine("Event Number:"+i+" is "+_eventName+" Started");
       }
    }
}
