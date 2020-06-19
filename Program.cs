using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsBasic
{
    class Program
    {
        public static int addition(int X, int Y)
        {

            return X + Y;
        }

        public static int multiply(int X, int Y)
        {
            return X * Y;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter Name and then age");
            String name1 = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter pet name");
            var petname = Console.ReadLine();
            Console.Write("Enter what dog says");
            var petsay = Console.ReadLine();
            Console.WriteLine($"My name is {name1} and I am {age} yrs old");
            Console.WriteLine($"I have a pet dog named {petname} . She's good pup");
            Console.WriteLine($"And She calls Human : {petsay}");
            Console.WriteLine($"{petname} is the best ");
            Console.WriteLine(" Now lets do some Maths. Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            var sum1 = addition(num1, num2);
            var product1 = multiply(num1, num2);
            Console.WriteLine($"Sum is : {sum1} and Product is {product1} ");


        }
    }
}
