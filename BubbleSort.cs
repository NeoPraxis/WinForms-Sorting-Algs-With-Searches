/* ********************************************************************
 * Projct:      Sorting Algorithms
 * File:        Bubble Sort class
 * Language:    C#
 * 
 * Desription:  This class implements a Bubble Sort
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.2   GPW 11/18/2022 - initial writing
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms {
    internal class BubbleSort {
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
        /// This method will sort an array of integers using 
        /// a Bubble Sort
        /// </summary>
        /// <param name="data"></param>
        public static void Sort(int[] data) {
            // make n-1 passes through the data
            for (int pass = 0; pass < data.GetUpperBound(0); pass++) {
                // for each pass examine adjacent elements
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++) {
                    // out of order check
                    if (data[index] > data[index+1]) {
                        Swap(data, index, index+1);
                    }
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
