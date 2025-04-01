using System;

namespace CSharpTrain // Same namespace as StringReverse and Program
{
    public class Palindrome
    {
        public static bool IsPalindrome(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return true; // Empty string is often considered a palindrome
            }

            // 1. Normalize the string: remove spaces, punctuation, and convert to lowercase
            string normalizedString = "";
            foreach (char c in inputString)
            {
                if (char.IsLetterOrDigit(c)) // Keep only letters and digits
                {
                    normalizedString += char.ToLower(c); // Convert to lowercase
                }
            }

            // 2. Reverse the normalized string
            char[] charArray = normalizedString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            // 3. Compare the normalized string to its reversed version
            return normalizedString == reversedString;
        }
    }
}
