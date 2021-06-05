using System;
namespace DataStructure.DesignPattern.factory
{
    public class BasicCalculationFactory
    {
        public BasicCalculationFactory()
        {
        }


        public ICalculate getCalculation(string opt)
        {
            ICalculate obj = null;
            switch (opt)
            {
                case "add":
                    obj = new Add();
                    break;
                case "subtract":
                    obj =  new Subtract();
                    break;
                case "divide":
                    obj = new Divide();
                    break;
                default:
                    return null ;
            }

            return obj;
        }
    }


    public interface ICalculate
    {
        public void calculate(double x, double y);
    }


    public class Add : ICalculate
    {
        public void calculate(double x, double y)
        {
            Console.WriteLine("After adding you get {0}", x + y);
        }
    }


    public class Subtract : ICalculate
    {
        public void calculate(double x, double y)
        {
            Console.WriteLine("After substracting you get {1}", x - y);
        }
    }

    public class Divide : ICalculate
    {
        public void calculate(double x, double y)
        {
            Console.WriteLine("After dividing you get {0}", x / y);
        }
    }
}
