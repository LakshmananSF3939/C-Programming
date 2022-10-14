using System;

namespace PartialAbstraction;
public enum Department{Default,EEE,ECE,CSE}
public enum Gender{Male,Female}
    public partial class StudentDetails
    {
       
    
    
        private static int s_studentID=1000;
        public string StudentID {get;set;}
        public Department Department { get; set; }
        public string Year { get; set; }
       
        
            
        
        
        
    }

    

