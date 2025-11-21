using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void BUBLE_Tests()
        {
            // Test 1: Normal array
            int[] arr1 = { 5, 2, 8, 1, 9 };
            int[] expected1 = { 1, 2, 5, 8, 9 };
            PROGRAM.BUBLE(arr1);
            Assert.That(arr1, Is.EqualTo(expected1));

            // Test 2: Empty array
            int[] arr2 = { };
            int[] expected2 = { };
            PROGRAM.BUBLE(arr2);
            Assert.That(arr2, Is.EqualTo(expected2));

            // Test 3: Single element
            int[] arr3 = { 42 };
            int[] expected3 = { 42 };
            PROGRAM.BUBLE(arr3);
            Assert.That(arr3, Is.EqualTo(expected3));

            // Test 4: Array with duplicates
            int[] arr4 = { 3, 3, 1, 3 };
            int[] expected4 = { 1, 3, 3, 3 };
            PROGRAM.BUBLE(arr4);
            Assert.That(arr4, Is.EqualTo(expected4));
        }

        [Test]
        public void PALINDROME_Tests()
        {
            // Test 1: Valid palindrome
            Assert.IsTrue(PROGRAM.PALINDROME("A man a plan a canal Panama"));
            
            // Test 2: Not palindrome
            Assert.IsFalse(PROGRAM.PALINDROME("hello"));
            
            // Test 3: Empty string
            Assert.IsTrue(PROGRAM.PALINDROME(""));
            
            // Test 4: Null string
            Assert.IsFalse(PROGRAM.PALINDROME(null));
        }

        [Test]
        public void FACTORIAL_Tests()
        {
            // Test 1: Normal case
            Assert.That(PROGRAM.FACTORIAL(5), Is.EqualTo(120));
            
            // Test 2: Zero case
            Assert.That(PROGRAM.FACTORIAL(0), Is.EqualTo(1));
            
            // Test 3: One case
            Assert.That(PROGRAM.FACTORIAL(1), Is.EqualTo(1));
            
            // Test 4: Larger number
            Assert.That(PROGRAM.FACTORIAL(7), Is.EqualTo(5040));
        }

        [Test]
        public void Fibonacci_Tests()
        {
            // Test 1: First position
            Assert.That(PROGRAM.Fibonacci(0), Is.EqualTo(0));
            
            // Test 2: Second position
            Assert.That(PROGRAM.Fibonacci(1), Is.EqualTo(1));
            
            // Test 3: Normal case
            Assert.That(PROGRAM.Fibonacci(6), Is.EqualTo(8));
            
            // Test 4: Exception case
            Assert.Throws<ArgumentException>(() => PROGRAM.Fibonacci(-1));
        }

        [Test]
        public void FINDSTR_Tests()
        {
            // Test 1: Substring exists
            Assert.IsTrue(PROGRAM.FINDSTR("hello world", "world"));
            
            // Test 2: Substring doesn't exist
            Assert.IsFalse(PROGRAM.FINDSTR("hello world", "test"));
            
            // Test 3: Empty substring
            Assert.IsTrue(PROGRAM.FINDSTR("hello", ""));
            
            // Test 4: Case sensitive
            Assert.IsFalse(PROGRAM.FINDSTR("Hello", "hello"));
        }

        [Test]
        public void SIMPLE_Tests()
        {
            // Test 1: Prime number
            Assert.IsTrue(PROGRAM.SIMPLE(17));
            
            // Test 2: Not prime number
            Assert.IsFalse(PROGRAM.SIMPLE(15));
            
            // Test 3: Edge case - 2
            Assert.IsTrue(PROGRAM.SIMPLE(2));
            
            // Test 4: Edge case - 1
            Assert.IsFalse(PROGRAM.SIMPLE(1));
        }

        [Test]
        public void REVERSE_Tests()
        {
            // Test 1: Normal number
            Assert.That(PROGRAM.REVERSE(123), Is.EqualTo(321));
            
            // Test 2: Negative number
            Assert.That(PROGRAM.REVERSE(-456), Is.EqualTo(-654));
            
            // Test 3: Number with trailing zero
            Assert.That(PROGRAM.REVERSE(120), Is.EqualTo(21));
            
            // Test 4: Overflow case
            Assert.That(PROGRAM.REVERSE(2147483647), Is.EqualTo(0));
        }

        [Test]
        public void ROMAN_Tests()
        {
            // Test 1: Normal conversion
            Assert.That(PROGRAM.ROMAN(1987), Is.EqualTo("MCMLXXXVII"));
            
            // Test 2: Lower bound
            Assert.That(PROGRAM.ROMAN(1), Is.EqualTo("I"));
            
            // Test 3: Upper bound
            Assert.That(PROGRAM.ROMAN(3999), Is.EqualTo("MMMCMXCIX"));
            
            // Test 4: Out of range
            Assert.That(PROGRAM.ROMAN(0), Is.EqualTo(""));
        }
    }
}
