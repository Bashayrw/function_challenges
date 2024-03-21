using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;

namespace FunctionChallenges
{
    class Program
    {

        public static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            //Console.WriteLine("Challenge 1: String and Number Processor");
            string result = StringNumberProcessor("Hello", 100, 200, "World", "hi", 200, 300, 400);
            Console.WriteLine(result);


            GuessingGame();
            Console.WriteLine("\nChallenge 3: Guessing Game");
        }

        public static string StringNumberProcessor(params object[] args)
        {
            int totalNumberValue = 0;
            string concatenatedString = "";
            foreach (var item in args)
            {
                if (item.GetType() == typeof(int))
                {
                    totalNumberValue += Convert.ToInt32(item); // 0 + 100 + 200
                }
                if (item.GetType() == typeof(string))
                {
                    concatenatedString += item.ToString() + " "; // " " + "Hello" 
                }
            }
            // when finish for loop, return the final result of concatenated string and total value
            return $"{concatenatedString}; {totalNumberValue}";
        }


        // concatenatedString = " " 
        // totalValue = 0;

        // foreach (var item in args)
        // {

        // way to check the type of the item 
        // if (item.GetType() == typeof(int)) {    // check item is int : totalValue += item }
        // if (item.GetType() == typeof(string)) {     // check item is string concatenatedString += item }
        // }



        // Challenge 2: Object Swapper
        // Console.WriteLine("\nChallenge 2: Object Swapper");
        // int num1 = 25, num2 = 30;
        // int num3 = 10, num4 = 30;
        // string str1 = "HelloWorld", str2 = "Programming";
        // string str3 = "Hi", str4 = "Programming";
        // void SwapObjects(){
        //     num1 =num1 ^ num2;
        //     num2= num2 ^ num1;

        // };

        // SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
        // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

        // SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
        // SwapObjects(str3, str4); // Error: Length must be more than 5

        // SwapObjects(true, false); // Error: Upsupported data type
        // SwapObjects(ref num1, str1); // Error: Objects must be of same types

        // Console.WriteLine($"Numbers: {num1}, {num2}");
        // Console.WriteLine($"Strings: {str1}, {str2}");

        // Challenge 3: Guessing Game
        static void GuessingGame()
        {
            Random random = new Random();
            int num = random.Next(1, 10);

            Console.WriteLine("Enter a number");
            string guessed = Console.ReadLine();
            int.TryParse(guessed, out int guess);
            while (guess != num)
            {
                if (guessed.ToLower() == "quit")
                {
                    System.Console.WriteLine("BYEE");
                    break;
                }
                Console.WriteLine("wrong guess ):");
                Console.WriteLine("Enter a number");
                guessed = Console.ReadLine();
                int.TryParse(guessed, out guess);
                if (guess == num)
                {
                    System.Console.WriteLine("you got it! you're luckyyy");
                    break;
                }
            }
        }

        // Uncomment to test the GuessingGame method
        // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

        // Challenge 4: Simple Word Reversal
        // Console.WriteLine("\nChallenge 4: Simple Word Reversal");
        // string sentence = "This is the original sentence!";
        // string reversed = ReverseWords(sentence);
        // Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
    }

}



