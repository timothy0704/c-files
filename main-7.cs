using System;

class Program {
  public static void Main (string[] args) {

    char num = 'a';
    
    switch(num)
    {
      case '3': Console.WriteLine ("value 1 is");
        break;
      case 'a': Console.WriteLine ("value 2 is");
        break;
      default:
       Console.WriteLine ("other than 1 and 2");
        break;
    }

  }
}