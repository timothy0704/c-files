using System;

class Program {
  public static void Main (string[] args) {

    int i = 1;
    int sum = 0;
    for(i=1; i<=10; i++)
    {
      sum = sum+i;
    }
        Console.WriteLine("sum of the 10 number is {0}", sum);
  }
}
