using System;

namespace 异常处理ExceptionHalding
{
    public class Calculator
    {
        public int Devide(int numerator, int denomenator)
        {
            return numerator / denomenator;
        }
        //Exception > SystemException > ArithmeticException > DivideByZeroException

        public double Devide(double numerator, double denomenator)
        {
            return numerator / denomenator;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result1 = calculator.Devide(5.0, 0.0);
            if (result1 == double.PositiveInfinity)
            {
                Console.WriteLine("result1 == double.NaN");
            }
            //Console.WriteLine(result1);

            //var result2 = calculator.Devide(2, 0);
            //Console.WriteLine(result2);
            
            //try
            //{
            //    var calculator = new Calculator();
            //    var result1 = calculator.Devide(5.0, 0.0);
            //    var result2 = calculator.Devide(2, 0);
            //    Console.WriteLine(result1);
            //    Console.WriteLine(result2);

            //}
            //catch (DivideByZeroException) { Console.WriteLine("分母不能为零"); }
            //catch (ArithmeticException) { Console.WriteLine("算数出错"); }
            //catch (SystemException) { Console.WriteLine("系统出错"); }
            //catch (Exception ex) { Console.WriteLine("有情况"); }
            //finally { Console.WriteLine("无论如何都会运行"); }
            //Console.ReadKey();
        }
    }
}
