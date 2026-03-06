// See https://aka.ms/new-console-template for more information
using System;
class Program{

    const double TAX_RATE = 0.2;

    static double calculate_pay(double hours, double rate){
        if(hours < 0 || hours < 0){
            throw new Exception("Hours and Rate must be positive");
        }
        double gross = hours*rate;
        double tax = gross*TAX_RATE;
        double net = gross - tax;
        return net;
        
    }

    static void Main(string[] args){
        double hours = 0;
        double rate = 0;
        Console.WriteLine("Enter employee name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hours worked: ");
        try{
            hours = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
            {
                Console.WriteLine("Please only enter a number");
            }

        Console.WriteLine("Hourly rate: ");
        try{
            rate = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
            {
                Console.WriteLine("Please only enter a number");
            }

        double net_pay = calculate_pay(hours, rate);

        string msg = $"{name} earned ${net_pay} after tax";

        Console.WriteLine(msg);

    }
}




