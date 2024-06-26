﻿using System;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // CodeLearning NewCodeLearning = new CodeLearning();
            // NewCodeLearning.DictionaryIntroduction();
            
            // DrawTriangle NewTriangle = new DrawTriangle();
            // NewTriangle.Draw();

            // Exercise.ListLengthMultiplier();   
            Exercise.RunCustomTryParse();   
        }
    }

    public class CodeLearning
    {
        public void NumericDataTypes() 
        {
            int age = 23;
            long bigNumber = 90000000L;
            double negative = -55.2D;
            float flooat = 5.0001F;

            Console.WriteLine(age);
            Console.WriteLine(bigNumber);
            Console.WriteLine(negative);
            Console.WriteLine(flooat);
        }

        public void TextBasedDataTypes() 
        {
            string name = "Aba";
            char letter = 'a';

            System.Console.Write("Your name is ");
            System.Console.Write(name);
            System.Console.WriteLine();
            System.Console.WriteLine(letter);
        }

        public void ConvertStringToNumber() 
        {
            string strAge = "23";
            int intAge = Convert.ToInt32(strAge);
            System.Console.WriteLine(intAge);

            string strBigNumber = "90000000";
            long longBigNumber = Convert.ToInt64(strBigNumber);
            System.Console.WriteLine(longBigNumber);
        }

        public void Operators() 
        {
            bool isMale = true;
            string sex = isMale ? "Male" : "Female";
            System.Console.WriteLine(sex);

            int age = 23;

            System.Console.WriteLine(age++); // 23 (24 is not printed out)
            System.Console.WriteLine(++age); // 25 (25 + 1 but printed out at front)

            System.Console.WriteLine(age % 2);
            System.Console.WriteLine(age % 23);

            const int discount = 20;
            const double percentDiscount = discount / 100D;

            System.Console.WriteLine(300 * percentDiscount);
        }

        public void ConsoleInputOutput() 
        {
            System.Console.Write("Enter your name: ");
            string? newName = Console.ReadLine();

            System.Console.WriteLine();

            System.Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out int newAge);

            System.Console.WriteLine("Your name is " + newName + " and your age is " + newAge);
            System.Console.WriteLine($"Your name is {newName} and your age is {newAge}");
            System.Console.WriteLine(string.Format("Your name is {0} and your age is {1}", newName, newAge));
            System.Console.WriteLine(string.Concat("Your name is ", newName, " and your age is ", newAge));

            if (newAge == 18)
            {
                System.Console.WriteLine("You're 18");
            }
        }

        public void StringFormat() 
        {
            double longDecimal = 1000D / 12.44D;
            string simplifiedLongDecimal = string.Format("This is the simplified decimal: {0:0.00} OR {0:0.0}", longDecimal);
            
            System.Console.WriteLine(longDecimal); // 80.38585209003216
            System.Console.WriteLine(simplifiedLongDecimal); // This is the simplified decimal: 80.39 OR 80.4

            double money = -10D / 3D;

            System.Console.WriteLine(money); // -3.3333333333333335
            System.Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"))); // -£3.33
            System.Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // -$3.33
            System.Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))); // -Rp3,33
        }

        public void StringVerbatim() 
        {
            string NormalString = "C:\\Users\\Lorem\\Ipsum\\Dolor\nNew Line Test\tTab Test";
            string VerbatimString = @"C:\Users\Lorem\Ipsum\Dolor Sit Amet";

            System.Console.WriteLine(NormalString);
            System.Console.WriteLine(VerbatimString);
        }

        public void StringComparation() 
        {
            System.Console.WriteLine("Enter your name:");
            string? name = System.Console.ReadLine();
            string correctName = "Aba";

            if (string.IsNullOrEmpty(name)) {
                System.Console.WriteLine("Your name is empty");
            }
            else if(name.Equals(correctName)) {
                System.Console.WriteLine($"Your name is correct, it's {correctName}");
            }
            else {
                System.Console.WriteLine($"Your name is {name} instead of {correctName}");
            }
        }

        public void ArrayIntroduction() 
        {
            int[] numbers = new int[4] // Set the length of the array, in this case is 4
            {
                1, 2, 3, 4 // Set the array values
            };
            
            // Replace the original values
            numbers[0] = 16;
            numbers[3] = 128;
            numbers[1] = 32;
            numbers[2] = 64;

            // Sort the array values
            Array.Sort(numbers); // 16, 32, 64, 128

            // Reserve the array values
            Array.Reverse(numbers); // 128, 64, 32, 16

            System.Console.WriteLine("Iterate using For:");

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }

            System.Console.WriteLine("Iterate using Foreach:");

            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }

        public void ArraySearch() 
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
            };

            System.Console.WriteLine("Enter a fibonacci number to search:");
            bool isNumberToSearch = int.TryParse(Console.ReadLine(), out int numberToSearch);

            if (!isNumberToSearch) 
            {
                System.Console.WriteLine("Invalid number to search");
            }
            else 
            {
                int position = Array.IndexOf(numbers, numberToSearch);

                if (position < 0) 
                {
                    System.Console.WriteLine($"Number {numberToSearch} has not been found");
                }
                else
                {
                    System.Console.WriteLine($"Number {numberToSearch} has been found at position {position + 1}");
                }
            }
        }

        public void ListIntroduction() 
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 5
            };

            System.Console.WriteLine("This is the initial data we have:");

            foreach (int number in numbers)
            {
                System.Console.Write($"{number} ");
            }

            int countNumbersToAdd = 3;

            for (int i = 0; i < countNumbersToAdd; i++)
            {
                System.Console.WriteLine($"Add the {numbers.Count}th number:");
                bool isNewNumber = int.TryParse(Console.ReadLine(), out int newNumber);

                if (!isNewNumber) 
                {
                    System.Console.WriteLine("Invalid number. Skipped.");
                }
                else
                {
                    numbers.Add(newNumber);
                }
            }

            System.Console.WriteLine("This is ours numbers now:");

            foreach (int number in numbers)
            {
                System.Console.Write($"{number} ");
            }
        }

        public void DictionaryIntroduction() 
        {
            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                {"Math", "Aba"},
                {"Science", "Jacob"},
                {"English", "Mary"},
            };

            System.Console.WriteLine("This is the initial teachers data we have:");

            // List the initial teachers.
            foreach (var teacher in teachers)
            {
                System.Console.WriteLine($"The {teacher.Key} teacher is Mr/Miss {teacher.Value}");
            }

            int countTeachersToAdd = 2;

            // Add some additional teachers.
            for (int i = 0; i < countTeachersToAdd; i++)
            {
                System.Console.WriteLine($"Add the {teachers.Count}th teacher:");
                
                System.Console.WriteLine("Subjects:");
                string? subjects = Console.ReadLine();

                System.Console.WriteLine("Name:");
                string? name = Console.ReadLine();

                if (!string.IsNullOrEmpty(subjects) && !string.IsNullOrEmpty(name)) 
                {
                    teachers.Add(subjects, name);
                }

            }

            System.Console.WriteLine("This is our teachers now:");

            // List the updated teachers.
            foreach (var teacher in teachers)
            {
                System.Console.WriteLine($"The {teacher.Key} teacher is Mr/Miss {teacher.Value}");
            }

            System.Console.WriteLine("Get a teacher name for a specific subject:");
            string? selectedSubject = System.Console.ReadLine();

            // Get a teacher name for a specific subject.
            if (string.IsNullOrEmpty(selectedSubject)) 
            {
                System.Console.WriteLine("Invalid subject input");
            }
            else if (teachers.TryGetValue(selectedSubject, out string? selectedTeacherName)) 
            {
                System.Console.WriteLine($"The {selectedSubject} teacher is {selectedTeacherName}");
            }
            else 
            {
                System.Console.WriteLine($"There is no {selectedSubject} teacher in our database");
            }
        }
    }

    public class Exercise
    {
        public static void MathQuestion() 
        {
            System.Console.Write("Insert the first number: ");
            bool isNum1 = int.TryParse(System.Console.ReadLine(), out int Num1);

            System.Console.WriteLine();

            System.Console.Write("Insert the second number: ");
            bool isNum2 = int.TryParse(System.Console.ReadLine(), out int Num2);

            System.Console.WriteLine();

            if (!isNum1 || !isNum2) 
            {
                System.Console.WriteLine("Your input is not a number. Please try again with a valid input.");
            }
            else
            {
                System.Console.WriteLine(string.Format("Your answer for {0} X {1} ?", Num1, Num2));
                int.TryParse(System.Console.ReadLine(), out int Result);
                
                System.Console.WriteLine();

                int ActualResult = Num1 * Num2;

                if (ActualResult == Result)
                {
                    System.Console.WriteLine("You're 100% right. Well done!");    
                }
                else
                {
                    System.Console.WriteLine("Aww, it was close!, sorry!");
                }
            }            
        }

        public static void EvenOddLists() 
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            int numberLimit = 20;

            for (int i = 1; i <= numberLimit; i++)
            {
                if (i % 2 == 0) 
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
            }

            System.Console.WriteLine($"The even numbers form 1 to {numberLimit} are:");

            foreach (var number in evenNumbers)
            {
                System.Console.Write($"{number} ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine($"The odd numbers form 1 to {numberLimit} are:");

            foreach (var number in oddNumbers)
            {
                System.Console.Write($"{number} ");
            }
        }

        public static void ListLengthMultiplier() 
        {
            List<int> numbers = new List<int>();

            System.Console.WriteLine("This is a list multiplier app");

            System.Console.WriteLine("Enter a number:");
            int.TryParse(System.Console.ReadLine(), out int submittedNumber);

            System.Console.WriteLine("Enter the list length:");
            int.TryParse(System.Console.ReadLine(), out int submittedLength);

            if (submittedNumber < 1 || submittedLength < 1)
            {
                System.Console.WriteLine("Your number or length must be a valid number and bigger than 0");
            }
            else
            {
                for (int i = 1; i <= submittedLength; i++)
                {
                    int multiplied = submittedNumber * i;
                    numbers.Add(multiplied);
                }
            }

            System.Console.WriteLine($"The result is:");

            foreach (var number in numbers)
            {
                System.Console.Write($"{number} ");
            }
        }

        public static void RunCustomTryParse() {            
            bool success = false;

            while (!success)
            {
                System.Console.WriteLine("Enter a number:");            
                string? text = System.Console.ReadLine();
                bool isNumber = CustomTryParse(text, out int number, out string message);

                if (isNumber) 
                {
                    System.Console.WriteLine($"The int conversion of {number} is succeeded.");
                    success = true;
                }
                else
                {
                    System.Console.WriteLine($"Failed to convert: {message} Please try again.");
                }
            }

            System.Console.WriteLine("Goodbye!");
        }

        public static bool CustomTryParse(string? text, out int number, out string message)
        {
            message = "Succeeded";

            try
            {
                number = Convert.ToInt32(text);
                return true;
            }
            catch (System.Exception e)
            {
                number = 0;   
                message = e.Message;             
                return false;
            }
        }
    }

    public class DrawTriangle
    {
        public int width = 0;

        public void Draw() 
        {
            this.width = this.GetInputInt("Insert the triangle width that you are desired to:");

            if (this.width <= 1)
            {
                System.Console.WriteLine("The triangle width must be greater than 1");
                return;
            }

            bool isEven = this.width % 2 == 0;
            
            if (isEven)
            {
                this.DrawEvenTriangle();
            }
            else
            {
                this.DrawOddTriangle();
            }
        }

        private int GetInputInt(string message) 
        {
            System.Console.WriteLine(message);
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);
            return isNumber ? number : 0;
        }

        private void DrawEvenTriangle() 
        {
            for (int i = 1; i <= this.width; i++)
            {
                for (int j = 1; j <= i; j++)
                {                    
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        private void DrawOddTriangle() 
        {
            List<int> rows = new();

            // Determine the triangle rows.
            for (int i = 1; i <= this.width; i++)
            {
                if (i % 2 != 0) 
                {
                    rows.Add(i);
                }
            }

            // Determine the triangle height.
            int height = rows.Count;

            // Draw the triangle.
            for (int i = 0; i < height; i++)
            {
                int spaces = height - (i + 1);

                for (int j = 1; j <= spaces; j++)
                {
                    System.Console.Write(" ");
                }

                for (int j = 1; j <= rows[i]; j++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine();
            }
        }
    }
}