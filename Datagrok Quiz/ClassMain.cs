using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Datagrok_Quiz.BinarySum;

namespace Datagrok_Quiz
{
    class ClassMain
    {

        public static void Main(string[] args)
        {
            #region task 1

            Node root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.left = newNode(4);
            root.left.right = newNode(5);
            root.right.left = newNode(6);
            root.right.right = newNode(7);
            root.right.left.right = newNode(8);

            double sum = Sum(root);
            Console.WriteLine("Sum of all the elements is: " + sum);

            #endregion

            #region task 2

            #endregion

            #region task 3

            Palindrom p = new Palindrom();
            //Console.WriteLine(p.isPalindromable("civic"));
            //Console.WriteLine(p.isPalindromable("ivicc"));
            //Console.WriteLine(p.isPalindromable("civil"));
            //Console.WriteLine(p.isPalindromable("livci"));

            #endregion

            #region task 4

            #endregion

            #region task 5


            Duplicate d = new Duplicate();

            //Console.WriteLine(d.findDuplicate(new int[] { 1, 2, 2, 3 }));
            //Console.WriteLine(d.findDuplicate(new int[] { 1, 2, 3, 3 }));
            //Console.WriteLine(d.findDuplicate(new int[] { 2, 1, 4, 3, 5, 4 }));

            #endregion

            #region task 6

            Intersection i = new Intersection();

            int[] arr1 = { 1, 2, 4, 5, 6 };
            int[] arr2 = { 2, 3, 5, 7 };

            //i.intersectionCount(arr1, arr2);

            #endregion

            #region task 7
            
            rleEncoder r = new rleEncoder();

            string str = "ATTTGC";
            string expected = "A1T3G1C1";

            //if (expected == r.rle(str))
            //{
            //    Console.WriteLine(str + " => " + r.rle(str));
            //}

            #endregion

            #region task 8

            SearchInsertPosition s = new SearchInsertPosition();
            int[] arr = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(s.findIndex(arr, 7));

            #endregion

            #region task 9
            
            //max(double[] values): It has a time and space complexity of O(n)
            //sort(double[] values):Complexity of Quick sort (average) is O(nlogn); Complexity of insertion and selection sort (average) is O(n**2);

            #endregion

            #region task 10

            //Yes, it`s possible, but if you have 1.000.000.000 × 0
            //Compression is mathematical, and a mathematical principle called “Shannon’s Law”
            //If you have real data it`s impossible

            #endregion
        }

    }

}
