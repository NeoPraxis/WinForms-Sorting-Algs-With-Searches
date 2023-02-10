/* ********************************************************************
 * Projct:      Sorting Algorithms
 * File:        Insertion Sort class
 * Language:    C#
 * 
 * Desription:  This class implements an Insertion Sort
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.3   GPW 12/02/2022 - initial writing
 *                      - borrowed Swap from BubbleSort
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms {
    internal class InsertionSort {
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
        /// The method uses an Insertion Sort to sort an array of data
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data) {
            int lower;      // lower index of array portion to sort
            int upper;      // upper index of array portion to sort
            int key;        // value we are tyring to insert into the sorted array
            int searchIndex;// index we are comparing to the key value

            // initialize the boundries
            lower = data.GetLowerBound(0);
            upper = data.GetUpperBound(0);

            // make one pass for each item in the array bounds
            for (int keyIndex = lower; keyIndex <= upper; keyIndex++) {
                // save off the key value -> value you want to put into the
                // correct psotion in the sorted array [the key]
                key = data[keyIndex];
                // start looking one position to the right of the key
                // and work left, becuase we swap larger values
                searchIndex = keyIndex - 1;
                while ((searchIndex >= lower) && (data[searchIndex].CompareTo(key) > 0)) {
                    Swap(data, searchIndex, searchIndex+1);
                    searchIndex--;
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
