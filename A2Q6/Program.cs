using System;
using System.Linq;
namespace A2Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            //deciding length of the array by asking user to input how long it should be
            Console.WriteLine("How many values do you want to add?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];

            int i;

            for (i = 0; i < n; i++)
            {
                //for displaying, asking for number to be entered
                Console.Write("element - {0} : ", i);
                //storing in array
                myArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            //sum of the numbers

            Console.WriteLine("\nThe sum of the array is: " + myArray.Sum());

            double sum = myArray.Sum();

            //average of the numbers             
            double avg =  (double) sum / n;
            Console.WriteLine("\nThe average of the array is: " + avg);


            //now finding the negatives and positives of the entered values:
            int posNums = 0;
            int negNums = 0;

            for (int j = 0; j < n; j++)
            {
                if (myArray[j] > 0)
                {
                    posNums++;
                }
                else
                {
                    negNums++;
                }
            }

            //printing the number of Positives And Negatives
            Console.WriteLine("\nThere are " + posNums + " positive numbers in your list.\n");
            Console.WriteLine("There are " + negNums + " negative numbers in your list.\n");

        }
    }
}