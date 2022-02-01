using System;
namespace DynamicPoly
{
    public class Interest
    {
        public virtual double MyBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
    }
    public class SimpleInterest : Interest
    {
        public override double MyBank(double amount, double rate)
        {
            return amount + (amount * rate) + 2500;
        }
    }
    public class ExpressInterest : Interest
    {
        public override double MyBank(double amount, double rate)
        {
            return amount + (amount * rate) + 5000;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Interest obj = new Interest();
            double final = obj.MyBank(50000, 0.25);
            Console.WriteLine("Normal interest " + final);

            obj = new SimpleInterest();
            final = obj.MyBank(50000, 0.5);
            Console.WriteLine("Simple interest " + final);

            obj = new ExpressInterest();
            final = obj.MyBank(50000, 0.8);
            Console.WriteLine("Express interest " + final);

        }
    }
}