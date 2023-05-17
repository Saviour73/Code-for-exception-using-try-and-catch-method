using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter the first number");

            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the second number");

            int secondnumber = int.Parse(Console.ReadLine());

            var result = firstnumber / secondnumber;

            Console.WriteLine($"The result is {firstnumber / secondnumber}");


            try
            {
                Console.WriteLine("please enter the first number");

                int Firstnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter the second number");

                int Secondnumber = int.Parse(Console.ReadLine());

                var Result = Firstnumber / Secondnumber;

                Console.WriteLine($"The result is {Firstnumber / Secondnumber}");


            }
            catch (FormatException ex)
            {
                Console.WriteLine($"something bad happened:{ex.GetType().Name}");

                Console.WriteLine($"something bad happened:{ex.Message}");

                Console.WriteLine($" somthing bad happened:{ex.StackTrace}");
                throw;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"somthing bad happened:{ex.GetType().Name}");

                Console.WriteLine($"somthing bad happened:{ex.Message}");

                Console.WriteLine($"somthing bad happened:{ex.StackTrace}");
                throw;

            }
            catch (Exception ex)
            {

                Console.WriteLine($"something bad happened:{ex.GetType()}");

                Console.WriteLine($"something bad happened:{ex.Message}");

                Console.WriteLine($"something bad happened:{ex.StackTrace}");
                throw;

            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }


        }
    }
}
            
        
