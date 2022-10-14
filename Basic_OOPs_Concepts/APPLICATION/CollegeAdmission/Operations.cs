using System;
using System.Collections;
namespace CollegeAdmission;

    public delegate void EventManager();
    public static class Operations
    {
        private static string _eventName;
        public static event EventManager eventlink=null;
        static int i;
        public static List<StudentDetails> studentList=new List<StudentDetails>();
        public static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();
        public static List<AdmissionDetails> admissionList=new List<AdmissionDetails>();
        static StudentDetails CurrentStudent=null;
        
        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFiles);
            eventlink+=new EventManager(Operations.MainMenu);
            eventlink+=new EventManager(Files.WriteOfFiles);
        } 
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }


        public static void MainMenu()
        {
            
        
            
            string choice="yes";
          do
          {
             System.Console.WriteLine("Select 1.Registration 2.Login 3.Check Departmentwise seat availability 4.Exit");
             int option=int.Parse(Console.ReadLine());
             switch(option)
             {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;

                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Check Departmentwise seat availability");
                    foreach(DepartmentDetails department in departmentList)
                    {
                        System.Console.WriteLine(department.DepartMentId+":"+department.DepartMentName+":"+department.NumberOFSeats);
                    }                    
                    
                    break;
                    
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                    
                }
             }
          }while(choice=="yes");
        }


public static void DefaultData()
{
    
    StudentDetails student1 = new StudentDetails("Ravichandran","Ettaparajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
    studentList.Add(student1);
    StudentDetails student2 = new StudentDetails("Baskarn","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
    studentList.Add(student2);
    DepartmentDetails eee=new DepartmentDetails("EEE",29);
    departmentList.Add(eee);
    DepartmentDetails cse=new DepartmentDetails("CSE",29);
    departmentList.Add(cse);
    DepartmentDetails mech=new DepartmentDetails("MECH",30);
    departmentList.Add(mech);
    DepartmentDetails department3=new DepartmentDetails("ECE",30);
    departmentList.Add(department3);
    AdmissionDetails admission1=new AdmissionDetails("SF3001","DID101",new DateTime(2022,05,11),AdmissionStatus.Admitted);
    admissionList.Add(admission1);
    AdmissionDetails admission2=new AdmissionDetails("SF3002","DID102",new DateTime(2022,05,12),AdmissionStatus.Admitted);
    admissionList.Add(admission2);
}
        public static void Registration()
        {
            System.Console.WriteLine("Enter your Name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your father Name:");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter date of birth:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter Physics Mark");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Chemistry Mark");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Maths Mark");
            int maths=int.Parse(Console.ReadLine());
            StudentDetails student3=new StudentDetails(name,fatherName,dob,gender,physics,chemistry,maths);
            studentList.Add(student3);
            System.Console.WriteLine("Your Registeration Id :"+student3.RegistrationId);
        }
        public static void Login()
        {
           System.Console.WriteLine("Enter Student Registration Id:");
           string registerId=Console.ReadLine();
           foreach(StudentDetails student in studentList)
           {
            if(student.RegistrationId==registerId)
            {
                System.Console.WriteLine("Login Success fully");
                CurrentStudent=student;
                SubMenu();
            }
            
           }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
            System.Console.WriteLine("Select 1.check Eligility 2.Show Details 3.Take Admission 4.Cancel Admission 5. Show Admission 6.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Check Eligibity");
                    bool eligibility=CurrentStudent.CheckEligibility(75.0);
                    if(eligibility)
                    {
                      System.Console.WriteLine("You are eligible");
                    }
                    else
                    {
                      System.Console.WriteLine("You are not eligible");
                    }
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Show Details");
                    CurrentStudent.ShowDetails();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Take Admission");
                    TakeAdmission(); 
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Cancel Admission");
                    CancelAdmission();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Show Admission Details");
                    ShowAdmissionDetails();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            
        }while(choice=="yes");
        }
        public static void TakeAdmission()
        {
            //show department details
            System.Console.WriteLine("Department Details:");
            foreach(DepartmentDetails department1 in departmentList )
            {
                System.Console.WriteLine(department1.DepartMentId+"\t"+department1.DepartMentName+"\t"+department1.NumberOFSeats);
            }
            //Ask user from choose department id
            System.Console.WriteLine("please choose department ID");
            string departmentID=Console.ReadLine();
            //check department id in the list
            foreach(DepartmentDetails department2 in departmentList) 
            {
                if(department2.DepartMentId==departmentID)
                {
                    if(department2.NumberOFSeats>=1)
                    {
                       bool eligible=CurrentStudent.CheckEligibility(75.0);
                       if(eligible)
                       {
                        System.Console.WriteLine("You are elible");
                        bool candidateAdmit=true;
                        foreach(AdmissionDetails admission in admissionList)
                        {
                            if(admission.StudentID==CurrentStudent.RegistrationId)
                            {
                                if(admission.AdmissionStatus==AdmissionStatus.Admitted)
                                {
                                    System.Console.WriteLine("You are already Admitted");
                                    candidateAdmit=false;
                                }
                            }
                        }
                        if(candidateAdmit)
                        {
                            foreach(DepartmentDetails deptseats in departmentList)
                            {
                                if(departmentID==deptseats.DepartMentId)
                                {
                                    deptseats.NumberOFSeats--;
                                    AdmissionDetails admission3=new AdmissionDetails(CurrentStudent.RegistrationId,departmentID,DateTime.Now,AdmissionStatus.Admitted);
                                    admissionList.Add(admission3);
                                    System.Console.WriteLine("You are Admitted!! Your Admission Id:"+admission3.AdmissionId);
                                } 
                                
                            }  
                        }
                       } 
                    }
                    else
                    {
                        System.Console.WriteLine("No seats are available");
                    }
                }
            }
        }
        public static void CancelAdmission()
        {
            foreach(AdmissionDetails cancelAdmission in admissionList)
            {
                if(cancelAdmission.StudentID==CurrentStudent.RegistrationId)
                {
                    
                    
                        foreach(DepartmentDetails cancel in departmentList)
                        {
                            if(cancelAdmission.AdmissionStatus==AdmissionStatus.Admitted && cancel.DepartMentId==cancelAdmission.DepartMentID)
                            {
                                cancelAdmission.AdmissionStatus=AdmissionStatus.Cancelled;
                                cancel.NumberOFSeats++;
                                
                                System.Console.WriteLine("Admission cancelled");
                            }

                        }
                    
                }
                
            }
        } 
        public static void ShowAdmissionDetails()
        {
            
            foreach(AdmissionDetails admission in admissionList)
            {
                if(CurrentStudent.RegistrationId==admission.StudentID)
                {
                System.Console.WriteLine("Student Id:"+admission.StudentID);
                System.Console.WriteLine("Department Id:"+admission.DepartMentID);
                System.Console.WriteLine("Admission Id:"+admission.AdmissionId);
                System.Console.WriteLine("Admission Date:"+admission.AdmissionDate);
                System.Console.WriteLine("Admission Status:"+admission.AdmissionStatus);
                }
               
            }
        }
    }


