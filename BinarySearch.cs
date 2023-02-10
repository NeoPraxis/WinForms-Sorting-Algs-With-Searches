/* ********************************************************************
 * Projct:      Sorting Algorithms
 * File:        Binary Search class
 * Language:    C#
 * 
 * Desription:  This class implements a Binary Search
 *              
 * College:     Husson University
 * Course:      IT 326
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.4   GPW 02/08/2023 - initial writing
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms {
    internal class BinarySearch {
        #region enum
        #endregion enum

        #region data
        public const int NOT_FOUND = -1;
        #endregion data

        #region properties
        #endregion properties

        #region constructor
        #endregion constructor

        #region methods
        /// <summary>
        /// Search the entire array for the key value
        /// If found, return an array index where the key value was found
        /// If not found, return NOT_FOUND
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Search(int[] data, int key) {
            return Search(data, key, data.GetLowerBound(0), data.GetUpperBound(0));
        }

        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static int Search(int[] data, int key, int lower) {
            return Search(data, key, lower, data.GetUpperBound(0));
        }

        /// <summary>
        /// Search the array starting between lower index and upper index for the key value
        /// If found, return the first array index where the key value was found
        /// If not found, return NOT_FOUND

        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static int Search(int[] data, int key, int lower, int upper) {
            bool found = false;
            int middle = 0;

            // make sure low and high are valid (within the array bounds)
            if ((lower < data.GetLowerBound(0)) || (upper > data.GetUpperBound(0)) 
                || (lower > upper)) {
                throw new ArgumentException("invalid lower or upper index provided");
            }

            // loop until the key value is either found or not found
            while ((lower <= upper) && (!found)) {
                // compute the middle
                middle = lower + (upper - lower) / 2;
                // check the current value in the array
                if (data[middle] == key) {
                    // found it
                    found = true;
                } else { // didn't find it, yet
                    if (key < data[middle]) {
                        upper = middle - 1;
                    } else {
                        lower = middle + 1;
                    }
                }
            }

            // determine if we found it
            if (!found) {
                middle = NOT_FOUND;
            }

            return middle;
        }

        #endregion methods
    }
}
