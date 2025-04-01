using System;

namespace CSharpTrain // Make sure this namespace matches your project's default namespace
{
    public class StringReverse
    {
        public static string ReverseStringManual(string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) // Handle null or empty input more robustly
            {
                return inputString; // Or return null, or throw exception based on requirements
            }
            string reversedString = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }
            return reversedString;
        }

        public static string ReverseStringBuiltIn(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return inputString;
            }
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
