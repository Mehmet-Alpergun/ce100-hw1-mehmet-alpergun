using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************
 * Copyleft (L) 2022 CENG - All Rights Not Reserved
 * You may use, distribute and modify this code.
 **************************/

/**
 * @file ce100-hw1-algo-lib-cs
 * @author Mehmet ALPERGUN
 * @date 14 March 2022
 *
 * @brief <b> HW-1 Functions </b>
 *
 * HW-1 Sample Lib Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */

namespace ce100_hw1_algo_lib_cs
{
    /**
       *
       *	  @name InsSort (ınssort)
       *
       *	  @brief Insertion Sort
       *
       *	  Insertion Sort
       *	  
       *	  @param  [in] mass [\b int[,]] 
       *
       **/
    public class Class1
    {
        

        public static int[] InsSort(int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                int cur = mas[i];
                int l = i;
                while (l > 0 && cur < mas[l - 1])
                {
                    mas[l] = mas[l - 1];
                    l--;
                }
                mas[l] = cur;
            }
            return mas;
        }
        /**
      *
      *	  @name  SelectionSortArray (selectionsortarray)
      *
      *	  @brief Selection Sort Array
      *
      *	  Selection Sort Array
      *
      *	  @param  [in] NumArr [\b int[,]] 
      *	   
      *	  
      **/

        public static int[] SelectionSortArray(int[] NmArry)
        {
           
            var arrayLength = NmArry.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int k = i + 1; k < arrayLength; k++)
                {
                    if (NmArry[k] < NmArry[smallestVal])
                    {
                        smallestVal = k;
                    }
                }
                var tempVar = NmArry[smallestVal];
                NmArry[smallestVal] = NmArry[i];
                NmArry[i] = tempVar;
            }
            return NmArry;
        }
        /**
       *
       *	  @name  Naivepower (naivepower)
       *
       *	  @brief Naive Power
       *
       *	  Naive Power
       *
       *	  @param  [in] p [\b int]  
       *	   
       *	  @param  [in] t [\b int]  
       *	  
       **/
        public static long Naivepower(int p, uint t)
        {

            // initialize result by 1
            int pwr = 1;

            // multiply `x` exactly `n` times
            for (int i = 0; i < t; i++)
            {
                pwr = pwr * p;
            }

            return pwr;
        }
        /**
       *
       *	  @name  RecursivePower (recursivepower)
       *
       *	  @brief Recursive Power
       *
       *	  Recursive Power
       *
       *	  @param  [in] baseValue [\b int]  
       *	  
       *	  @param  [in] exponentvalue [\b int]  
       *	  
       **/

        public static double RecursivePower(int baseValue, int exponentvalue)
        {
            if (exponentvalue == 0)
            {
                return 1;
            }
            if (exponentvalue == 1)
            {
                return baseValue;
            }
            return baseValue * RecursivePower(baseValue, exponentvalue - 1);
        }

        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        public static void merge(int[] arr, int c, int g, int d)
        {
            // Find sizes of two
            // subarrays to be merged
            int p1 = g - c + 1;
            int p2 = d - g;

            // Create temp arrays
            int[] L = new int[p1];
            int[] R = new int[p2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < p1; ++i)
                L[i] = arr[c + i];
            for (j = 0; j < p2; ++j)
                R[j] = arr[g + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int s = c;
            while (i < p1 && j < p2)
            {
                if (L[i] <= R[j])
                {
                    arr[s] = L[i];
                    i++;
                }
                else
                {
                    arr[s] = R[j];
                    j++;
                }
                s++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < p1)
            {
                arr[s] = L[i];
                i++;
                s++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < p2)
            {
                arr[s] = R[j];
                j++;
                s++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()

        /**
        *
        *	  @name  mergeSort (mergesort)
        *
        *	  @brief Merge Sort
        *
        *	  Merge Sort
        *	  
        *	  @param  [in] array [\b int[,]] 
        *	  
        **/

        public static int[] mergeSort(int[] array)
        {
            int[] lft;
            int[] rght;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            lft = new int[midPoint];

            //if array has an even number of elements,
            //the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                rght = new int[midPoint];
            //if array has an odd number of elements,
            //the right array will have one more element than left
            else
                rght = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                lft[i] = array[i];
            //populate right array
            int x = 0;
            //We start our index from the midpoint, as we
            //have already populated the left array from 0 to midpont
            for (int i = midPoint; i < array.Length; i++)
            {
                rght[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            lft = mergeSort(lft);
            //Recursively sort the right array
            rght = mergeSort(rght);
            //Merge our two sorted arrays
            result = merge(lft, rght);
            return result;
        }
        /**
       *
       *	  @name  merge (merge)
       *
       *	  @brief Merge
       *
       *	  Merge
       *	  
       *	  @param  [in] left [\b int[,]]
       *	  
       *	  @param  [in] right [\b int[,]] 
       *	  
       **/


        public static int[] merge(int[] left, int[] right)
        //This method will be responsible for combining our two sorted arrays
        //into one giant array
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array,
                    //add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    // else the item in the right array wll be
                    // added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                //if only the left array still has elements,
                //add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                //if only the right array still has elements,
                //add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

        // Returns index of x if it is present in arr[],
        // else return -1
        /**
      *
      *	  @name  IterativebinarySearch (ıterativebinarysearch)
      *
      *	  @brief Iterative Binary Search
      *
      *	  Iterative Binary Search
      *	  
      *	  @param  [in] arr [\b int[,]]
      *	  
      *	  @param  [in] z [\b int]  
      *	  
      *	  
      **/
        public static int IterativebinarySearch(int[] ar, int z)
        {
            int t = 0, r = ar.Length - 1;
            while (t <= r)
            {
                int m = t + (r - t) / 2;

                // Check if x is present at mid
                if (ar[m] == z)
                    return m;

                // If x greater, ignore left half
                if (ar[m] < z)
                    t = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            // if we reach here, then element was
            // not present
            return -1;
        }

        // Returns index of x if it is present in
        // arr[l..r], else return -1

        /**
      *
      *	  @name  BinarySearchRecursive (binarysearchrecursive)
      *
      *	  @brief Binary Search Recursive
      *
      *	  Binary Search Recursive
      *	  
      *	  @param  [in] arr [\b int[,]]
      *	  
      *	  @param  [in] S [\b int]  
      *	  
      *	  @param  [in] H [\b int]  
      *	  
      *	  @param  [in] keynumber [\b int]  
      *	  
      **/
        public static int BinarySearchRecursive(int[] arr, int l, int h, int kynm)
        {
            int mid = l + (h - l) / 2;

            // find the mid-value in the search space and
            // compares it with the target

            // Base condition (target value is found)
            if (kynm == arr[mid])
            {
                return mid;
            }

            // discard all elements in the right search space,
            // including the middle element
            else if (kynm < arr[mid])
            {
                return BinarySearchRecursive(arr, l, mid - 1, kynm);
            }

            // discard all elements in the left search space,
            // including the middle element
            else
            {
                return BinarySearchRecursive(arr, mid + 1, h, kynm);
            }
        }

    }
}