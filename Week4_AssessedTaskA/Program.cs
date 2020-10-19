using System;
using System.Collections;
using Webinar4A;

namespace Week4_AssessedTaskA
{
    class Program //<T> where T : IComparable //: Comparer<Book>
    {
        static void Main(string[] args)
        {
            /* int n = 50;  //1
             int r = 20; //1
             int dummy = 0;  //1

             Console.WriteLine("Creating a nested loop");    //1

             for (int i = 0; i < n; i++) //n+1
             {
                 Console.WriteLine("Inside the first loop"); //n

                 dummy++;    //n

                 for (int j = 0; j < n; j++) //n*(n+1)
                 {

                     r = r + dummy;  //n*n
                     Console.WriteLine("Inside the second loop " + r);   //n*n
                 }
             }
             //1 + 1 + 1 + 1 + n + 1 + n + n + n * ( n + 1 ) + n * n + n * n
             //= 5 + 4n + 3n^2 remove constant
             //= 4n + 3n^2 // remove numbers
             //= n + n^2 //remove smaller
             //= n^2
             // Big(O) = O(n^2)
             // end of part 1
            */
            //part 2  


            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns",
                "ZZ"};
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284",
                "9483294", "9823943" };

            Book[] library = new Book[10];


            // fill an array of books
            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);

            }
            // call SelectSortGen to sort the array library (choose to sort the books by using either title, author or isbn)
            //display sorted array so you can check that the sorting method works also for an array of Book
            GenSelectionSort(library);
            Console.WriteLine("Sorted array of books by ISBN : ");
            foreach (Book book in library)
            {
                Console.WriteLine(book);
            }

            // create an array of int
            // call SelectSortGen to sort the array of int
            ////display sorted array so you can check that the sorting method works also for an array of int
            int[] numbers = { 1, 2, 5, 4, 9, 65, 45, 556, 484, 45 };
            GenSelectionSort(numbers);
            Console.WriteLine("Sorted array of integers : ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // create an array of string
            // call SelectSortGen to sort the array of string 
            ////display sorted array so you can check that the sorting method works also for an array of string
            string[] words = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            GenSelectionSort(words);
            Console.WriteLine("Sorted array of words : ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();

        }

        static void GenSelectionSort<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[smallest]) < 0)
                    {
                        smallest = j;

                    }
                }
                swap(ref a[i], ref a[smallest]);

            }
        }

        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


    }
}
