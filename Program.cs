using System;
using System.Globalization;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CodeLearning CodeLearning = new CodeLearning();
            CodeLearning.ListIntroduction();

            // Exercise Exercise = new Exercise();
            // Exercise.MathQuestion();            
        }
    }

    public class CodeLearning
    {
        public void NumericDataTypes() {
            int age = 23;
            long bigNumber = 90000000L;
            double negative = -55.2D;
            float flooat = 5.0001F;

            Console.WriteLine(age);
            Console.WriteLine(bigNumber);
            Console.WriteLine(negative);
            Console.WriteLine(flooat);
        }

        public void TextBasedDataTypes() {
            string name = "Aba";
            char letter = 'a';

            System.Console.Write("Your name is ");
            System.Console.Write(name);
            System.Console.WriteLine();
            System.Console.WriteLine(letter);
        }

        public void ConvertStringToNumber() {
            string strAge = "23";
            int intAge = Convert.ToInt32(strAge);
            System.Console.WriteLine(intAge);

            string strBigNumber = "90000000";
            long longBigNumber = Convert.ToInt64(strBigNumber);
            System.Console.WriteLine(longBigNumber);
        }

        public void Operators() {
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

        public void ConsoleInputOutput() {
            System.Console.Write("Enter your name: ");
            string newName = Console.ReadLine();

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

        public void StringFormat() {
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

        public void StringVerbatim() {
            string NormalString = "C:\\Users\\Lorem\\Ipsum\\Dolor\nNew Line Test\tTab Test";
            string VerbatimString = @"C:\Users\Lorem\Ipsum\Dolor Sit Amet";

            System.Console.WriteLine(NormalString);
            System.Console.WriteLine(VerbatimString);
        }

        public void StringComparation() {
            System.Console.WriteLine("Enter your name:");
            string name = System.Console.ReadLine();
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

        public void ArrayIntroduction() {
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

        public void ArraySearch() {
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

        public void ListIntroduction() {
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
    }

    public class Exercise
    {
        public void MathQuestion() {
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
    }
}