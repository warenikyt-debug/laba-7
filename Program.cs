using System;
using System.Text;

public class PROGRAM
{
    public static int[] BUBLE(int[] numbers)
    {
        int temp;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        return numbers;
    }

    public static bool PALINDROME(string str)
    {
        if (str == null) return false;
        
        int left = 0;
        int right = str.Length - 1;
        
        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(str[left])) left++;
            while (left < right && !char.IsLetterOrDigit(str[right])) right--;
            
            if (char.ToLowerInvariant(str[left]) != char.ToLowerInvariant(str[right])) 
                return false;
            
            left++;
            right--;
        }
        return true;
    }

    public static long FACTORIAL(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static long Fibonacci(int position)
    {
        if (position < 0)
            throw new ArgumentException("Позиция должна быть неотрицательной");

        if (position == 0) return 0;
        if (position == 1) return 1;

        long prev = 0;
        long current = 1;

        for (int i = 2; i <= position; i++)
        {
            long next = prev + current;
            prev = current;
            current = next;
        }
        return current;
    }

    public static bool FINDSTR(string str, string find)
    {
        return str.Contains(find);
    }

    public static bool SIMPLE(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;
        
        for (int i = 3; i <= ((int)Math.Sqrt(number)); i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    public static int REVERSE(int x)
    {
        int reversed = 0;
        int original = x;

        while (original != 0)
        {
            int digit = original % 10;
            
            if (reversed > int.MaxValue / 10 || 
                (reversed == int.MaxValue / 10 && digit > 7))
                return 0;
            if (reversed < int.MinValue / 10 || 
                (reversed == int.MinValue / 10 && digit < -8))
                return 0;
                
            reversed = reversed * 10 + digit;
            original /= 10;
        }
        return reversed;
    }

    public static string ROMAN(int num)
    {
        if (num <= 0 || num > 3999) 
            return string.Empty;
            
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        
        var result = new StringBuilder();

        for (int i = 0; i < values.Length && num > 0; i++)
        {
            while (num >= values[i])
            {
                num -= values[i];
                result.Append(romans[i]);
            }
        }
        return result.ToString();
    }

    // Метод Main для демонстрации работы
    public static void Main()
    {
        Console.WriteLine("=== ДЕМОНСТРАЦИЯ РАБОТЫ ФУНКЦИЙ ===");
        Console.WriteLine($"Факториал 5: {FACTORIAL(5)}");
        Console.WriteLine($"Число Фибоначчи на позиции 6: {Fibonacci(6)}");
        Console.WriteLine($"Является ли 17 простым: {SIMPLE(17)}");
        Console.WriteLine($"Римское представление 1987: {ROMAN(1987)}");
        Console.WriteLine($"Реверс числа 12345: {REVERSE(12345)}");
        Console.WriteLine($"Палиндром 'А роза упала на лапу Азора': {PALINDROME("А роза упала на лапу Азора")}");
        
        int[] array = {5, 2, 8, 1, 9};
        BUBLE(array);
        Console.WriteLine($"Сортировка массива [5,2,8,1,9]: [{string.Join(", ", array)}]");
    }
}
