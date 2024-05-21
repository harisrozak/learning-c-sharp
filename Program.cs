using System;
using System.Globalization;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercise Exercise = new Exercise();
            Exercise.MathQuestion();            
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
            int newAge = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Your name is " + newName + " and your age is " + newAge);

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