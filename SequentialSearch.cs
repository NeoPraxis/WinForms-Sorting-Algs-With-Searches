/* ********************************************************************
 * Projct:      Sorting Algorithms
 * File:        Sequential Search class
 * Language:    C#
 * 
 * Desription:  This class implements a Sequential Search
 *              
 * College:     Husson University
 * Course:      IT 326
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.4   GPW 02/06/2023 - initial writing
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms {
    internal class SequentialSearch {
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
        /// If found, return the first array index where the key value was found
        /// If not found, return NOT_FOUND
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Search(int[] data, int key) {
            return Search(data, key, data.GetLowerBound(0), data.GetUpperBound(0));
        }

        /// <summary>
        /// Search the array starting at lower index for the key value
        /// If found, return the first array index where the key value was found
        /// If not found, return NOT_FOUND

        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static int Search(int[] data, int key, int lower) {
            return Search(data, key, lower, data.GetUpperBound(0));
        }

        /// <summary>
        /// Search the array between lower and upper index inclusive for the key value
        /// If found, return the first array index where the key value was found
        /// If not found, return NOT_FOUND
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int Search(int[] data, int key, int lower, int upper) {
            int index = lower;

            // loop through the array searching for the desired key
            while ((index <= upper) && (data[index].CompareTo(key) != 0)) {
                index ++;
            }

            // if we run out array, then return the not found value
            if (index > upper) {
                index = NOT_FOUND;
            }

            return index;
        }
        #endregion methods
     }
}
