using System;

namespace CSharpTrain // Same namespace as your exercise classes
{
    public class Program // Or you can rename it to ExerciseRunner if you prefer
    {
        public static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an exercise to run:");
                Console.WriteLine("1. Reverse String");
                Console.WriteLine("2. Palindrome Check");
                Console.WriteLine("3. Exit"); // Option to exit the program
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunStringReverseExercise();
                        break;
                    case "2":
                        RunPalindromeExercise();
                        break;
                    case "3":
                        running = false; // Set running to false to exit the loop
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }

                if (running) // Only pause if not exiting
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static void RunStringReverseExercise()
        {
            Console.WriteLine("\n--- String Reversal Exercise ---");
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();

            Console.WriteLine("\nUsing Manual Reverse Method:");
            string reversedManual = StringReverse.ReverseStringManual(input);
            Console.WriteLine($"Original: \"{input}\", Reversed: \"{reversedManual}\"");

            Console.WriteLine("\nUsing Built-in Reverse Method:");
            string reversedBuiltIn = StringReverse.ReverseStringBuiltIn(input);
            Console.WriteLine($"Original: \"{input}\", Reversed: \"{reversedBuiltIn}\"");
        }

        static void RunPalindromeExercise()
        {
            Console.WriteLine("\n--- Palindrome Check Exercise ---");
            Console.WriteLine("Enter a string to check for palindrome:");
            string input = Console.ReadLine();
            bool isPalindrome = Palindrome.IsPalindrome(input);
            Console.WriteLine($"\"{input}\" is a palindrome: {isPalindrome}");
        }
    }
}
