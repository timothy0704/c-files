using System;

class Program {
  public static void Main (string[] args) {

int userInput;

    Console.WriteLine ("press any key to continue...");
    Console.ReadKey();
    Console.WriteLine();
    
    Console.WriteLine ("Input using Read() - ");
    userInput = Console.Read();
    Console.WriteLine("Ascii Value = {0}", userInput);
  }
}