using System;

namespace HACKS
{
  class Program
  {
    static void Main(string[] args)
   {
     console.Title = "MODX";
     Console,ForegroundColor = ConsoleColor.Green;
     Console.WindowHeight = 10;
    
    Console.WriteLine("A Moding Softwere For All Games");
    
    Console.ReadKey();
    
    Console.Writeline("What Game Would You Like To Mod");
    
    Console.ReadLine();
    
    Console.WriteLine("What Level Of Speed. (Goes From 1-1000)");
    
    string userName = Console.ReadLine();
    
    Console.WriteLine("Current Speed Set To" + userName);
   }
    
  }
}