namespace Palindromenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }

        static bool IsPalindrome(int num)
        {
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10; 
                reversedNum = reversedNum * 10 + digit;
                num /= 10; 
            }

            return originalNum == reversedNum;
        }
    }
}
