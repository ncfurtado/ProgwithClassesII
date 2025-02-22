using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox Inheritance World!");

        Fox fox = new Fox ("fox");
        Bird bird = new Bird("blackbird");
        fox.MakeSound();
        bird.MakeSound();
    }
}