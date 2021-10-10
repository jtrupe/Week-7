/// Homework 7 Project 1
///
/// @author: Julian Trupe
/// Date:  October 10, 2021
///
/// Problem Statement: Create a Counter class with increment, decrement, reset, toString, equals mmethods
//
/// Overall Plan:
/// 1) Create a class Counter with vcarious methods
/// 2) Create a console menu to test each of the methods

using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter testCount = new Counter();
            Console.WriteLine("We will test some methods");
            Console.WriteLine("(1) To increase the current count ");
            Console.WriteLine("(2) To decrease the current count ");
            Console.WriteLine("(3) To reset the count to 0 ");
            Console.WriteLine("(4) To return the current count ");
            Console.WriteLine("(5) To print the current count ");
            Console.WriteLine("(6) To convert count to string ");
            Console.WriteLine("(7) To Check if count equals a number you input ");
            Console.WriteLine("(8) To exit the program ");
            int menuSelection = int.Parse(Console.ReadLine());
            while(menuSelection != 8)
            {
                switch (menuSelection)
                {
                    case 1:
                        testCount.countUp();
                        menuSelection = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        testCount.countDown();
                        menuSelection = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        testCount.resetCount();
                        menuSelection = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        testCount.getCount();
                        menuSelection = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        testCount.printCount();
                        menuSelection = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        testCount.countToString();
                        menuSelection = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("What number do you want to check if count is equal? ");
                        int equalsInput = int.Parse(Console.ReadLine());
                        testCount.countEquals(equalsInput);
                        menuSelection = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        break;
                }
            }
        }
    }

    class Counter
    {
        int count = 0;
        public void countUp()
        {
            count += 1;
        }
        public void countDown()
        {
            count -= 1;
            if(count < 0)
            {
                count = 0;
            }
        }
        public void resetCount()
        {
            count = 0;
        }
        public int getCount()
        {
            return count;
        }
        public void printCount()
        {
            Console.WriteLine("The current count is: " + count);
        }
        public string countToString()
        {
            return count.ToString();
        }
        public bool countEquals(int x)
        {
            if(count == x)
            {
                Console.WriteLine("Yes! Count equals " + x);
                return true;
            }
            else
            {
                Console.WriteLine("No! Count equals " + count);
                return false;
            }
        }
    }
}
