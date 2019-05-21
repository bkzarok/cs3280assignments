using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create variables
            string input;
            int secondNumber;
            int firstNumber;
            int sum;

            //Get the numbers
            Console.Write("Enter First Number: ");
            input = Console.ReadLine();
            firstNumber = Convert.ToInt32(input);

           
            Console.Write("Enter Second Number: ");

            input = Console.ReadLine();
            secondNumber = Convert.ToInt32(input); // will throw an exception if fails


            //Add the numbers
            sum = firstNumber + secondNumber;

            //Display the total
            Console.WriteLine($"\n{firstNumber} + {secondNumber} = {sum}" );

            //Subtract the numbers
            sum = firstNumber  - secondNumber;

            //Display the total
            Console.WriteLine($"{firstNumber} - {secondNumber} = {sum}");

            //Multiple the numbers
            sum = firstNumber * secondNumber;

            //Display the total
            Console.WriteLine($"{firstNumber} * {secondNumber} = {sum}");

            //Divide the numbers
            sum = firstNumber / secondNumber;

            //Display the total
            Console.WriteLine($"{firstNumber} / {secondNumber} = {sum}");

            //Add the numbers
            sum = firstNumber % secondNumber;

            //Display the total
            Console.WriteLine($"{firstNumber} % {secondNumber} = {sum}\n");

            if (firstNumber > secondNumber)
            {
                   Console.WriteLine($"{firstNumber} is not less than {secondNumber}" );
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }

            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{firstNumber} is not greater than {secondNumber}");
                Console.WriteLine($"{firstNumber} is less than {secondNumber}" );
            }
            if (firstNumber != secondNumber)
            {
                Console.WriteLine($"{firstNumber} does not equal {secondNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} equals {secondNumber}");
            }

            Console.WriteLine("Press any key to close console");
            Console.ReadKey();

        }
    }
}
