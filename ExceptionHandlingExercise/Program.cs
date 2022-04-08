using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr --done
            // Create a list called numbers that will hold integers      --done
            // Create an string variable with an empty string initializer - name it str  --done

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            var arr = new char[] { '1', '2', '3', '4', '5', '6','a','b','c'};
            var numbers = new List<int>();
            string str = "";


            //TODO START HERE:

            // Make a foreach loop to iterate through your character array  --done

            foreach (char c in arr)
            {
                try
                {
                    str = c.ToString();             //changing array into a string
                    int foo = int.Parse(str);       //parsing the string for integers
                    numbers.Add(foo);               //adding integers to numbers list           
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{c}'"); 
                                                //character will be the name of each item in your collection
                }
            }

            Console.WriteLine("Here are the items in the numbers list: ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Now create a try catch       --done

            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()  --done
            // Now, using int.Parse, parse your string variable and store in an int variable  --done
            // Then add each int to your list  --done

            // catch your Exception:
            // in the scope of your catch you can use the following,        --done

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
        }
    }
}
