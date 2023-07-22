using System;
namespace BasciCSharpAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Hello World ! ****");
            BasicCSharp bs = new BasicCSharp();
            bs.PrintDetails();
            bs.BasicArithmetic();
            bs.EvenorOdd();
            bs.Loop();
            bs.Array();
            bs.Calculatefactorial();
            bs.Conversion();
        }
    }
}
