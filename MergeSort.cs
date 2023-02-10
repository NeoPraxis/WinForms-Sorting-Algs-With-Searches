/* ********************************************************************
 * Projct:      Sorting Algorithms
 * File:        Merge Sort Class
 * Language:    C#
 * 
 * Desription:  This file implements a merge sort on a passed array.
 *              
 * College:     Husson University
 * Course:      IT 326
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   GPW 01/25/2023 - initial writing
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Sorting_Algorithms {
    internal class MergeSort {
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
        /// This routine will traverse the array to determine if it is sorted.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True - if array is sorted
        ///         False - if array is not sorted</returns>
        public static bool IsSorted(int[] data) {
            bool arrayIsSorted = true;
            int index = data.GetLowerBound(0);

            // check each element to see if in sorted order
            while ((index < data.GetUpperBound(0)) && (arrayIsSorted)) {
                if (data[index].CompareTo(data[index+1]) > 0) {
                    arrayIsSorted = false;
                } else {
                    index++;
                }
            }

            // return the result
            return arrayIsSorted;
        }

        /// <summary>
        /// This method will merge the two subsections of the arrya defined 
        /// by left through middle, and middle+1 through right.  It is 
        /// assumed that the two subsections are already sorted.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="middle"></param>
        /// <param name="right"></param>
        private static void Merge(int[] data, int left, int middle, int right) {
            // create temp storage
            int[] temp = new int[right - left + 1];

            // create temp working index
            int leftIndex = left;       // left is the leftmost item in left subarray
            int rightIndex = middle + 1;// right is the leftmost item in right subarray
            int tempIndex = 0;          // index is the first item in temp array

            // traverse both arrays (left -> middle, middle+1 -> right)
            // so long as they both have unsort data remaining
            while ((leftIndex <= middle) && (rightIndex <= right)) {
                if (data[leftIndex].CompareTo(data[rightIndex]) <= 0) {
                    // left value is smaller, store in temp array
                    temp[tempIndex] = data[leftIndex];
                    leftIndex++;
                    tempIndex++;
                    // temp[tempIndex++] = data[leftIndex++];
                } else {
                    // right value is smaller, store in temp array
                    temp[tempIndex] = data[rightIndex];
                    rightIndex++;
                    tempIndex++;
                }
            }

            // process any remaining in the left subarray
            while (leftIndex <= middle) {
                temp[tempIndex] = data[leftIndex];
                leftIndex++;
                tempIndex++;
            }

            // process any remaining in the right subarray
            while (rightIndex <= right) {
                temp[tempIndex] = data[rightIndex];
                rightIndex++;
                tempIndex++;
            }

            // two subarrays have been merge
            // traverse the temp array and store the back
            // in the original array
            int mainIndex = left;
            for (tempIndex = temp.GetLowerBound(0); 
                tempIndex <= temp.GetUpperBound(0); tempIndex++) {
                data[mainIndex] = temp[tempIndex];
                mainIndex++;
            }
        }

        /// <summary>
        /// Use merge sort to sort an array.
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data) {
            Sort(data, data.GetLowerBound(0), data.GetUpperBound(0));
        }

        /// <summary>
        /// Use merge sort to sort a portion of the array, bounded by the
        /// lower and upper array index specified (inclusive).
        /// </summary>
        /// <param name="data"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        public static void Sort(int[] data, int lower, int upper) {
            Split(data, lower, upper);
        }

        /// <summary>
        /// This method splits an array, if the size is greater than one
        /// into a left and right component and recursive calls itself.
        /// When size is one, it will call a merge routine.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private  static void Split(int[] data, int left, int right) {
            // make sure there are at least two elements
            // we are done splitting if only one element
            if (left < right) {
                // calculate the middle
                int middle = (left + right)/2;

                // sort the left side
                Split(data, left, middle);
                // sort the right side
                Split(data, middle + 1, right);

                // merge the two halves back together
                Merge(data, left, middle, right);
            }
        }
        #endregion methods
     }
}
