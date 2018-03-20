using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp
{
    public static class LargestNumberFromIntegerInput
    {
        /// <summary>
        /// Suppose if the value is 2354, output should be 5432
        /// If the input is 09582, output should be 9852...
        /// </summary>
        /// <param name="number">Any integer number</param>
        /// <returns></returns>
        public static int GetLargest(int number)
        {
            int largestNum = 0;
            int tmpNum = number;
            int remainder = 0;
            List<int> numList = new List<int>();

            //Get each digit from the number and add it to a list
            while (tmpNum != 0)
            {
                remainder = tmpNum % 10;
                tmpNum = tmpNum / 10;
                numList.Add(remainder);
            }

            // Get the list item count
            int listCount = numList.Count;

            // Sort the list
            var nList = numList.OrderBy(x => x);

            // Iterate through the list and add them to an integer variable
            for (int index = 0; index < listCount; index++)
            {
                largestNum += (int)(Math.Pow(10, index)) * nList.ElementAt(index);
            }

            return largestNum;
        }
    }
}
