using System;

class Program {
  public static void Main (string[] args) {

    /*int a; declartion
    int b; declartion
    a = 10; intialization
    b = 5; intialization*/

    //int a=10, b=5;
    //int exp = 3;

    int a, b;
    Console.WriteLine("Enter two numbers");
    a = Covert.Toint32Console.ReadLine());
    b = Covert.Toint32Console.ReadLine());
    
    Console.WriteLine("Enter the option");
    int exp =Covert.Toint32Console.ReadLine());
    
    switch(exp)
    
    case "+": Console.WriteLine("Addition {0}",(a+b));
        break;
        
      case "-": Console.WriteLine("Subtraction {0}",(a - b));
        break; 
        
      case "*": Console.WriteLine("Multiplication {0}",(a * b));
        break;
        
      case "/": Console.WriteLine("Division {0}",(a / b));
        break; 
        
      case "%": Console.WriteLine("Modulo is {0}"(a % b));
        break;
        
      default: Console.WriteLine("some other choices");
        break; 
    
    
    /* switch(exp)
    {
      case 1: Console.WriteLine((a + b));
        break;
        
      case 2: Console.WriteLine((a - b));
        break; 
        
      case 3: Console.WriteLine(a * b);
        break;
        
      case 4: Console.WriteLine(a / b);
        break; 
        
      case 5: Console.WriteLine((a % b));
        break;
        
      default: Console.WriteLine("some other choices");
        break; */

     }

  }
}