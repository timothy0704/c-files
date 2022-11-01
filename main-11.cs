using System;

class Program {
  public static void Main (string[] args) {
    
    int result1;
    int a = 5, b = 6, c = 4;
    result1 = c <= a%c;
                  //5 * 6 - 4
                  //4 * 6 -5
                  //24
      Console.WriteLine("result is {0}", result1);
    
    bool result2;
    result2 = b>=c+a;
    Console.WriteLine("a and c {0} {1}", a, c);
    //6>=5 +4
    Console.WriteLine(a++ - b / - c++);
    Console.WriteLine(a++ + ++b * c);
    Console.WriteLine(c <= a%c);


    
    Console.WriteLine(result2);
  }
}

// for the a++ - b / - c++, the result was 6. 
// for  the a++ + ++b * c, the result was 33