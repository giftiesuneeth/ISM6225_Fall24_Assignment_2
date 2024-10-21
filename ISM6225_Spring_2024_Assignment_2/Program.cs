using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                int n = nums.Length;
        bool[] present = new bool[n + 1];
        IList<int> missingNumbers = new List<int>();

        foreach (int num in nums)
        {
            if (num <= n)
            {
                present[num] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (!present[i])
            {
                missingNumbers.Add(i);
            }
        }

        return missingNumbers;
    }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
        List<int> evenList = new List<int>();
        List<int> oddList = new List<int>();

        // Separate the even and odd numbers.
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                evenList.Add(num);
            }
            else
            {
                oddList.Add(num);
            }
        }

        // Combine the even numbers followed by the odd numbers.
        evenList.AddRange(oddList);

        return evenList.ToArray();
    }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            numIndices[nums[i]] = i;
        }

        return new int[0]; // Write your code here
                 // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                Array.Sort(nums);
            int n = nums.Length;
        
            int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
            int product2 = nums[0] * nums[1] * nums[n - 1];
        
            return Math.Max(product1, product2);// Write your code here
                 // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                if (decimalNumber == 0)
        {
            return "0";
        }

        string binary = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binary = remainder + binary;
            decimalNumber /= 2;
        }// Write your code here
                return binary;  // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left];// Write your code here
                 // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if (x < 0)
                return false;

                int original = x;
                int reversed = 0;

            while (x > 0)
            {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }

            return original == reversed;// Write your code here
                 // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                 if (n <= 0)
            return 0;
            if (n == 1)
            return 1;

            int a = 0, b = 1;

            for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

            return b;
             // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
