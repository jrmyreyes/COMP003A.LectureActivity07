/*
 * Author: Ron Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Lecture activity for week 7
 * 
 */

namespace COMP003A.LectureActivity07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Arrays");
            // array1 declaration and setting values
            int[] array1 = new int[5];
            array1[0] = 5;
            array1[1] = 10;
            array1[2] = 15;
            array1[3] = 20;
            array1[4] = 25;

            Console.WriteLine($"Length of array1: {array1.Length}\n");

            // array2 declaration with values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("array2 Traversal");
            ArrayTraversal(array2);

            // integer array traversal
            int[] grades = new int[] { 100, 85, 92, 78, 89 };
            Console.WriteLine($"\ngrades Average: {GetAverage(grades)}");

            // string array traversal
            Console.WriteLine("\nstring Traversal");
            string message = "hello";
            Arraytraversal(message);



            SectionSeparator("Lists");
            List<char> alphabet = new List<char>();
            alphabet.Add('A');
            alphabet.Add('B');
            alphabet.Add('C');
            alphabet.Add('D');
            alphabet.Add('E');

            Console.WriteLine($"Count of alphabet: {alphabet.Count}");

            Console.WriteLine($"alphabet[0]: {alphabet[0]}");
            Console.WriteLine($"alphabet[2]: {alphabet[2]}");
            Console.WriteLine($"alphabet[4]: {alphabet[4]}");

            alphabet.Remove('C'); // removes a specific value somewhere inside the collection

            Console.WriteLine("\nContents of alphabet after removing 'C':");
            ListTraversal(alphabet);
        }
        /// <summary>
        /// Section separator method
        /// </summary>
        /// <param name="section">String input for section name</param>
        static void SectionSeparator(string section)
            {
                Console.WriteLine("".PadRight(50, '*') +  $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
            }

        /// <summary>
        /// Array Traversal
        /// </summary>
        /// <param name="array"> Integer array to traverse</param>
        static void ArrayTraversal(int[] array)
        {
           for  (int i = 0; i < array.Length; i++)
           {
              Console.WriteLine($"Array at index {i}: {array[i]}");
           }
        }

         /// <summary>
         /// Array Traversal
         /// </summary>
         /// <param name="array">String input</param>
         static void Arraytraversal(string array)
         {
             for  (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine($"Array at index {i}: {array[i]}");
             }
         }

         /// <summary>
         /// Average grade calculator
         /// </summary>
         /// <param name="array">Integer array input</param>
         /// <returns>average</returns>
         static double GetAverage(int[] array)
         {
             int runningTotal = 0;

             foreach (int item in array)
             {
                    runningTotal += item;
             }

             return runningTotal / array.Length;
         }

         /// <summary>
         /// List traversal using a  foreach loop
         /// </summary>
         /// <param name="=list">Character list input</param>
         static void ListTraversal(List<char> list)
         {
             foreach (var item in list)
             {
                    Console.WriteLine(item);
             }
         }
        
    }
}