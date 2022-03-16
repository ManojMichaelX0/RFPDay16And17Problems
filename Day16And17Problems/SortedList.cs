using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day16And17Problems
{
    internal class SortedListProgram
    {
        public void Sort()
        {
            string[] words = new string[5];
            Console.WriteLine("Enter Words in Array");
            words[0] =Console.ReadLine();
            words[1] = Console.ReadLine();
            words[2] = Console.ReadLine();
            words[3] = Console.ReadLine();
            words[4] = Console.ReadLine();
            Console.WriteLine("Before Sorting\n");
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " ");
            }
            Console.WriteLine("After Sorting\n");
            Array.Sort(words, StringComparer.InvariantCulture);
            Array.ForEach(words, x => Console.WriteLine(x));


        }
    }
}
