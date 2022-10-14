using System;
namespace Interfaces;
class Program
{
    public static void Main(string[] args)
    {
      Draw draw=new Draw(15,10);
      draw.CalculateArea();
      draw.ShowDetails();
    }
}
