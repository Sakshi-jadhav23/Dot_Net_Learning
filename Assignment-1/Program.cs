using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1. Hello World Program
            Console.WriteLine("Hello,	World!");

            //Q2. Basic User Input and Output
            Console.Write("Enter	your	name:	");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,	{name}!");


            //Q3. Basic Calculator
            /*         Console.Write("Enter	first	number:	");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter	second	number:	");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Sum:	{num1 + num2}");
                        Console.WriteLine($"Difference:	{num1 - num2}");
                        Console.WriteLine($"Product:	{num1 * num2}");
                        Console.WriteLine($"Quotient:	{num1 / num2}");*/

                        //Q4. temperature converter
                        Console.Write("Enter	temperature	in	Celsius:	");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"{celsius}°C	=	{fahrenheit}°F");
            


            //Q5. Number Guessing Game

            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int attempts = 0;

            while (true)
            {
                Console.Write("Guess	the	number	(1-100):	");
                int guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess == targetNumber)
                {
                    Console.WriteLine($"Correct!	You	took	{attempts}	attempts.");
                    break;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Too	low!");
                }
                else
                {
                    Console.WriteLine("Too	high!");
                }
            }

            // Q6.Simple Array   Operations

            Console.Write("How many numbers do you want to enter?	");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter	number	{i + 1}:	");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine($"Average: {numbers.Average()}");
            Console.WriteLine($"Maximum: {numbers.Max()}");
            Console.WriteLine($"Minimum: {numbers.Min()}");


            //Q7.word Counter

            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int wordCount = sentence.Split(new[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = sentence.Length;

            Console.WriteLine($"Word count:{wordCount}");
            Console.WriteLine($"Character count:{charCount}");


            //Q8.Simple File Operation
            Console.WriteLine("Enter text to save to file:");
            string content = Console.ReadLine();

            File.WriteAllText("output.txt", content);
            Console.WriteLine("Text saved to file!");

            Console.WriteLine("\nReading from file:");
            string readContent = File.ReadAllText("output.txt");
            Console.WriteLine(readContent);


            // Q9.To - Do List Manager
            List<string> todos = new List<string>();
            /*while (true)
            {
                Console.WriteLine("\n1. Add Todo");
                Console.WriteLine("2. View Todos");
                Console.WriteLine("3. Remove Todo");
                Console.WriteLine("4. Exit");

                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter todo: ");
                        todos.Add(Console.ReadLine());
                        break;
                    case "2":
                        for (int i = 0; i < todos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todos[i]}");
                        }
                        break;
                    case "3":
                        Console.Write("Enter index to remove: ");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (index >= 0 && index < todos.Count)
                        {
                            todos.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;
                    case "4":
                        return;
                }
            }
*/
            //   Q10.Simple Calculator with Methods
            while (true)
            {
                Console.WriteLine("\nCalculator Menu:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose operation: ");
                string choice = Console.ReadLine();

                if (choice == "5") break;

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {Add(num1, num2)}");
                        break;
                    case "2":
                        Console.WriteLine($"Result: {Subtract(num1, num2)}");
                        break;
                    case "3":
                        Console.WriteLine($"Result: {Multiply(num1, num2)}");
                        break;
                    case "4":
                        Console.WriteLine($"Result: {Divide(num1, num2)}");
                        break;
                }
            }

            // HOMEWORK QUESTIONs




            //Q1 Type Casting

            Console.Write("Enter Input String: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intValue))
                Console.WriteLine($"Integer: {intValue}");
            else
                Console.WriteLine("Not a valid Integer.");

            if (double.TryParse(input, out double doubleValue))
                Console.WriteLine($"Double: {doubleValue}");
            else
                Console.WriteLine("Not a valid Double.");

            if (bool.TryParse(input, out bool boolValue))
                Console.WriteLine($"Boolean: {boolValue}");
            else
                Console.WriteLine("Not a valid Boolean.");

            if (DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue))
                Console.WriteLine($"DateTime: {dateValue}");
            else
                Console.WriteLine("Not a valid DateTime (Expected format: yyyy-MM-dd).");

            //Q2 String Manipulation

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string newStr = string.Join("*", str.ToCharArray());

            char letter = 'l';
            int count = 0;
            string positions = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    count++;
                    positions += i + " ";
                }
            }

            Console.WriteLine("\nNew String: *" + newStr);
            Console.WriteLine($"\n'{letter}' appears {count} times at positions: {positions.Trim()}");




            //Q3.Append to File 


            Console.WriteLine("Enter text to append to file:");
            string content1 = Console.ReadLine();

            File.AppendAllText("TextFile1.txt", content1 + Environment.NewLine);

            Console.WriteLine("Text appended to file!");

            Console.WriteLine("\nReading from file:");
            string readContent1 = File.ReadAllText("TextFile1.txt");
            Console.WriteLine(readContent1);
        }

        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;







    }
}
