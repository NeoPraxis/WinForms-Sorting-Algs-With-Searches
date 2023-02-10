/* ********************************************************************
 * Project:     Sorting Algorithms
 * File:        Quick Sort class
 * Language:    C#
 * 
 * Desription:  This class implements a Quick Sort
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.3   GPW 02/01/2022 - initial writing
 *                      - borrowed Swap from Insertion Sort
 * *******************************************************************/
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms {
    internal class QuickSort {
        #region enum
        #endregion enum

        #region data
        #endregion data

        #region properties
        #endregion properties

        #region constructor
        #endregion constructor

        #region methods
        /// <summary>
        /// Partition an array, start are the start index
        /// and ending at the end index inclusive.  Smaller
        /// elements are moved to the left of the pivot, and 
        /// larger elements are moved to the right of a pivot.
        /// This routine returns the index of the pivot value.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>The index of the pivot value</returns>
        private static int Partition(int[] data, int start, int end) {
            // pick a pivot value
            int pivotValue = data[start];
            // temp index values
            int left = start;
            int right = end;

            // continue until the two index cross
            while (left < right) {
                // search from left to right until we find a value
                // larger than the pivot
                while ((data[left].CompareTo(pivotValue) <= 0) 
                    && (left < right)) {
                    left++;
                }

                // search from right to left until we find a value
                // smaller than the pivot
                while (data[right].CompareTo(pivotValue) > 0) {
                    right--;
                }
                
                // if index have not crossed, swap values
                if (left < right) {
                    Swap(data, left, right);
                }
            }

            // out of data
            // swap and return right, pivot position
            Swap(data, start, right);
            return right;
        }

        /// <summary>
        /// This method uses quicksort to sort an array of data
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data) {
            Sort(data, 0, data.GetUpperBound(0));
        }

        /// <summary>
        /// This method uses quicksort to sort a subarray of data
        /// starting a the left index and ending at the right
        /// index inclusive.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Sort(int[] data, int left, int right) {
            // make sure there are at least two elements
            if (left < right) {

                // partition the data, so that smaller elements
                // are to the left of a pivot and larger elements
                // are to the right of a pivot value
                int pivot = Partition(data, left, right);
                //System.Console.WriteLine(
                //    String.Format("left = {0} right = {1} pivot = [{2}] = {3}",
                //    left, right, pivot, data[pivot]));

                // sort the left side
                if (left < pivot - 1) {
                    Sort(data, left, pivot - 1);
                } 

                // sort the right side
                if (pivot + 1 < right) {
                    Sort(data, pivot + 1, right);
                }
            }
        }

        /// <summary>
        /// This routine will swap the two array elements specified by
        /// first and second index.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        private static void Swap(int[] data, int firstIndex, int secondIndex) {
            int temp;

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }
        #endregion methods
    }
}
