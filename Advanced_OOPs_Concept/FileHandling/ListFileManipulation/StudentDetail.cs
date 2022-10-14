using System;

namespace ListFileManipulation
{
    public enum Gender{Default,Male,Female,TransGender}
    public class StudentDetail
    {
        public string Name{ get; set; }
        public string FatherName { get; set; }

        public Gender Gender { get; set; }
        public DateTime DOB{ get; set; }
        
    }
}
