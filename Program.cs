using System;

namespace Calculater

{
    class Program
    {

        static void Main(string[] args)
        {
            bool runtime = false;
            while (!runtime)

            {
                Console.WriteLine(" this would be a perfect coding ");
                Console.WriteLine("enter number: ");

                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter function :");

                string calcFunction = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" Enter Second Number :");

                double num2 = Convert.ToDouble(Console.ReadLine());


                switch (calcFunction)
                {

                    case "+":

                        Console.WriteLine(" the answer was : {0}" , num + num2);

                        break;

                    case "-":

                        Console.WriteLine(" the answer was :{0}", num - num2);

                        break;

                    case "/":

                        while (num2 == num) ;

                        {
                            Console.WriteLine("plizz enter a null numer ...");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine(" the answer was:{0}", num / num2); 

                        break;

                    case "*":

                        Console.WriteLine(" the answer was: {0}", num * num2);

                        break;

                    default:

                        Console.WriteLine("Error");

                        break;


                }

                Console.WriteLine(" plizz press 'w and Enter' to quit the calculater. otherwise whatever ");
                if (Console.ReadLine() == "W") runtime = true; 
                 
            
            }
            return; 

        }

    }
}
