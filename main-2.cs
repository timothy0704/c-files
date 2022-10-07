using System;

class Program {
  public static void Main (string[] args) {
    int radius; // declaration
    double area;
    const double pi=3.14;

    radius=5; // inttalzation
    area = pi*radius*radius;

    int radius =8;
    double area1;
    area1 = pi*radius*radius;

    Console.WriteLine ("area is"+ area);
    Console.WriteLine ("area is"+ area1);
  }
}