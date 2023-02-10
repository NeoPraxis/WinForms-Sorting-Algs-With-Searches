/* ********************************************************************
 * Projct:      Sorting Algorithms
 * File:        Selection Sort class
 * Language:    C#
 * 
 * Desription:  This class implements a Selection Sort
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.4   GPW 12/05/2022 - initial writing
 *                      - copied code form Insertion Sort
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms {
    internal class SelectionSort {
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
        /// The method uses a Selection Sort to sort an array of data
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data) {
            Sort(data, data.GetLowerBound(0), data.GetUpperBound(0));
        }

        /// <summary>
        /// This method uses a Selection Sort to sort a portion of an
        /// array of data defined by the lower and upper index inclusive
        /// </summary>
        /// <param name="data"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        public static void Sort(int[] data, int lower, int upper) {
            int maxValueIndex;      // index of the maximum unsorted value

            // make one pass for each item in the array
            for (int pass = lower; pass <= upper; pass++) {
                // assume the first value is the largest
                maxValueIndex = lower;
                // find any larger values
                for(int index = lower; index <= upper - (pass - lower); index++) {
                    // check the value
                    if (data[index].CompareTo(data[maxValueIndex]) > 0) {
                        maxValueIndex = index;
                    }
                }
                
                // done with this pass, swap the max into proper position
                Swap(data, maxValueIndex, upper - (pass - lower));
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
