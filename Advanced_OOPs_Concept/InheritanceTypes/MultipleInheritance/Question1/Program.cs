using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
       RegisterPerson register=new RegisterPerson("Lakshmanan",987654321,"abc@gmail",new DateTime(2000,08,09),DateTime.Now,"Ganesan","Selvi","Srinivasa nagar");
       register.ShowInfo(); 
    }
}

