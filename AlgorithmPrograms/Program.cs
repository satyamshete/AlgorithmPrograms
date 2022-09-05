﻿namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Programs");
            Console.WriteLine("Press 1 for Insertion Sort");
            Console.WriteLine("Press 2 for Bubble Sort");
            int input = int.Parse(Console.ReadLine());
            switch (input) 
            {
                case 1:
                    InsertionSort insertionSort = new InsertionSort("Dhoni", "Sehwag", "Virat", "Kartik", "Bhuvi", "Yuzi");
                    break;
                case 2:
                    BubbleSort bubbleSort = new BubbleSort("Dhoni", "Sehwag", "Virat", "Kartik", "Bhuvi", "Yuzi");
                    break;
                default:
                    Console.WriteLine("Make proper Selection");
                    break ;
            }



        }
    }
}