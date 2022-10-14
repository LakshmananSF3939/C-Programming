using System;
namespace Question5 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Teams:");
            string team=Console.ReadLine();
            switch(team)
            {
                case "India":
                {
                    System.Console.WriteLine("1.Virat\n2.Hardik\n3.Rohit");
                    break;
                }
                case "Pakistan":
                {
                    System.Console.WriteLine("1.Babar\n2.Riswan\n3.Afridi");
                    break;
                }
                case "Bangladesh":
                {
                    System.Console.WriteLine("1.Tamim\n2.Mahamadulah\n3.Shahib");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid team");
                    break;
                }
            }

        }
    }
}
