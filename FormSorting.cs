/* ********************************************************************
 * Projct:      Sorting Algoriths
 * File:        Sorting Algorithms Demo
 * Language:    C#
 * 
 * Desription:  This program will demonstrate multiple sorting 
 *              algorithms
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   GPW 11/16/2022 - initial writing
 * 0.2   GPW 11/18/2022 - added inline Bubble Sort
 * 0.3   GPW 12/02/2022 - added Insertion Sort
 * *******************************************************************/
using System;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class FormSorting : Form
    {
        #region enum
        #endregion enum

        #region data
        private int[] valueArray = { 57, 63, 40, 13, 74, 99, 21, 8 };
        #endregion data

        #region properties
        #endregion properties

        #region constructor
        public FormSorting()
        {
            InitializeComponent();
        }
        #endregion constructor

        #region events
        private void buttonBinarySearch_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // read value from textbox, with no error trapping BAD!!
            int keyvalue = Convert.ToInt32(textBoxSearch.Text);
            // search for the value entered
            try
            {
                //int index = BinarySearch.Search(valueArray, keyvalue);
                int index = BinarySearch.Search(valueArray, keyvalue, 12, 5);

                // display results to the form
                if (index == SequentialSearch.NOT_FOUND)
                {
                    listBoxAfterSort.Items.Add("not found");
                }
                else
                {
                    listBoxAfterSort.Items.Add(String.Format("[{0}] = {1}", index, keyvalue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// When the user clicks this button, sort the data using the Bubble
        /// Sort class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleSortClass_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data
            BubbleSort.Sort(valueArray);

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);

        }

        /// <summary>
        /// When the user click this button, sort the data using the Bubble
        /// Sort Generic class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleSortGeneric_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data
            BubbleSortGeneric.Sort(valueArray);

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);

        }

        /// <summary>
        /// Whent he user clicks this button, sort the data using a Bubble Sort
        /// Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleSortFunction_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data
            BubbleSortFunction(valueArray);

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);
        }

        /// <summary>
        /// When the user clicks this button, sort the data using an inline 
        /// Bubble Sort.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleInline_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data
            int temp;       // temp storage for the swap
            // make n-1 passes through the array data
            for (int pass = 0; pass < valueArray.GetUpperBound(0); pass++)
            {
                // for each pass compare adjacent values starting from the left
                for (int index = 0; index < valueArray.GetUpperBound(0) - pass; index++)
                {
                    // bubble the largest remaining item to the top (right) of the array
                    if (valueArray[index] > valueArray[index + 1])
                    {
                        // wrong order, swap them
                        temp = valueArray[index];
                        valueArray[index] = valueArray[index + 1];
                        valueArray[index + 1] = temp;
                    }
                }
            }

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);
        }

        private void buttonInsertionSort_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data
            InsertionSort.Sort(valueArray);

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);
        }
        private void buttonMergeSort_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);
            listBoxBeforeSort.Items.Add(MergeSort.IsSorted(valueArray));

            // sort the data
            MergeSort.Sort(valueArray);

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);
            listBoxAfterSort.Items.Add(MergeSort.IsSorted(valueArray));
        }

        private void buttonQuickSort_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);
            listBoxBeforeSort.Items.Add(MergeSort.IsSorted(valueArray));

            // sort the data
            QuickSort.Sort(valueArray);

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);
            listBoxAfterSort.Items.Add(MergeSort.IsSorted(valueArray));
        }

        private void buttonQuickSortDateTime_Click(object sender, EventArgs e)
        {
            DateTime start;

            // prep the data
            valueArray = RandomData(10000000, int.MaxValue);

            // display the unsorted data
            //DisplayData(valueArray, listBoxBeforeSort);
            listBoxBeforeSort.Items.Add(MergeSort.IsSorted(valueArray));

            start = DateTime.Now;
            // sort the data
            QuickSort.Sort(valueArray);
            TimeSpan elapsed = DateTime.Now - start;

            // display the sorted data
            listBoxAfterSort.Items.Add(MergeSort.IsSorted(valueArray));
            listBoxAfterSort.Items.Add(elapsed);
            //DisplayData(valueArray, listBoxAfterSort, false);
        }

        private void buttonQuicksortStopwatch_Click(object sender, EventArgs e)
        {
            // prep the data
            valueArray = RandomData(100000000, int.MaxValue);

            // display the unsorted data
            // DisplayData(valueArray, listBoxBeforeSort);
            listBoxBeforeSort.Items.Add(MergeSort.IsSorted(valueArray));

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            // sort the data
            QuickSort.Sort(valueArray);
            sw.Stop();

            // display the sorted data
            listBoxAfterSort.Items.Add(MergeSort.IsSorted(valueArray));
            listBoxAfterSort.Items.Add(sw.Elapsed);
            // DisplayData(valueArray, listBoxAfterSort, false);
        }

        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // sort the data
            SelectionSort.Sort(valueArray);

            // display the sorted data
            DisplayData(valueArray, listBoxAfterSort);
        }

        private void buttonSequentialSearch_Click(object sender, EventArgs e)
        {
            // display the unsorted data
            DisplayData(valueArray, listBoxBeforeSort);

            // read value from textbox, with no error trapping BAD!!
            int keyvalue = Convert.ToInt32(textBoxSearch.Text);
            // search for the value entered
            int index = SequentialSearch.Search(valueArray, keyvalue);
            // display results to the form
            if (index == SequentialSearch.NOT_FOUND)
            {
                listBoxAfterSort.Items.Add("not found");
            }
            else
            {
                listBoxAfterSort.Items.Add(String.Format("[{0}] = {1}", index, keyvalue));
            }

        }
        #endregion events

        #region methods
        /// <summary>
        /// The routine will sort data using a Bubble Sort
        /// </summary>
        /// <param name="data"></param>
        public void BubbleSortFunction(int[] data)
        {
            // make n-1 passes through the array data
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                // for each pass compare adjacent values starting from the left
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++)
                {
                    // bubble the largest remaining item to the top (right) of the array
                    if (data[index] > data[index + 1])
                    {
                        // wrong order, swap them
                        Swap(data, index, index + 1);
                    }
                }
            }
        }

        /// <summary>
        /// This routine will display the array of data in the listbox
        /// </summary>
        /// <param name="data"></param>
        /// <param name="theListBox"></param>
        private void DisplayData(int[] data, ListBox theListBox, bool clearListbox = true)
        {
            if (clearListbox)
            {
                theListBox.Items.Clear();
            }

            theListBox.Items.Add("[index] = value");
            for (int index = 0; index <= data.GetUpperBound(0); index++)
            {
                // display each item in the array in the listbox
                theListBox.Items.Add(String.Format("[{0}] = {1}", index, data[index]));
            }
        }

        /// <summary>
        /// Creates an array and fills it with data
        /// </summary>
        /// <param name="nofValue"></param>
        /// <returns></returns>
        public int[] RandomData(int nofValue, int maxValue)
        {
            valueArray = new int[nofValue];
            Random rng = new Random();

            for (int index = 0; index <= valueArray.GetUpperBound(0); index++)
            {
                valueArray[index] = rng.Next(maxValue);
            }

            return valueArray;
        }

        /// <summary>
        /// This method will swap the two items designated by the first and second index
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        private void Swap(int[] data, int firstIndex, int secondIndex)
        {
            int temp;

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }
        #endregion methods

    }
}
