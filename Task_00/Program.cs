using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HelloWorld
{
    public class Task_01
    {
        /*
        Task
        Your task is to find the similarity of given sorted arrays a and b, 
        which is defined as follows:

        you take the number of elements which are present in both arrays 
        and divide it by the number of elements which are present in at least one array.

        It also can be written as a formula similarity(A, B) = #(A ∩ B) / #(A ∪ B), 
        where #(C) is the number of elements in C, ∩ is intersection of arrays, 
        ∪ is union of arrays.

        This is known as Jaccard similarity.

        The result is guaranteed to fit any floating-point type without rounding.

        Example
        For a = [1, 2, 4, 6, 7] and b = [2, 3, 4, 7]:

        elements [2, 4, 7] are present in both arrays;
        elements [1, 2, 3, 4, 6, 7] are present in at least one of the arrays.
        So the similarity equals to 3 / 6 = 0.5.

        Tests:
        Similarity(new int[]{1, 2, 3},new int[]{1, 2, 3}); // 1
        Similarity(new int[]{1, 2, 3},new int[]{4, 5, 6}); // 0
        Similarity(new int[]{1, 2, 4, 6, 7},new int[]{2, 3, 4, 7}); // 0.5
        Similarity(new int[]{1, 2, 6, 8, 9},new int[]{0, 1, 4, 5, 6, 8, 9}); // 0.5
        Similarity(new int[]{1, 2, 3, 4, 7, 9},new int[]{1, 2, 3}); // 0.5
        Similarity(new int[]{0, 1, 3, 4, 5, 6, 9, 14, 15, 16, 17, 18, 19},
        new int[]{1, 4, 10, 12, 13, 14, 15, 16}) // 0.3125;
         */
        public static double Similarity(int[] a, int[] b)
        {
            int res1 = 0, res2 = 0;

            /*
            foreach (int el in a)
            {
                if (b.Contains(el))
                {
                    res1++;
                }

                res2 = a.Length + b.Length - res1;
            }

            Console.WriteLine($"res1 = {res1}");
            Console.WriteLine($"res2 = {res2}");
            */

            //Console.WriteLine(a.Intersect(b).ToArray().Length);
            Console.WriteLine(string.Join(", ", a.Intersect(b).ToArray()));
            Console.WriteLine(string.Join(", ", a.Union(b).ToArray()));

            return (double)a.Intersect(b).ToArray().Length / a.Union(b).ToArray().Length;
        }
    }
}