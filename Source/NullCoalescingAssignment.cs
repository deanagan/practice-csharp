// This is a sample of coalescing assignment operator in C#8

using System;
using System.Collections.Generic;

namespace lib
{
    public class NullCoalescingAssignment
    {

        public int TotalNumbers(int? baseNumber, int numberToAdd)
        {
            return (baseNumber ??= 0) + numberToAdd;
        }

        public List<int> AddNumberToList(List<int> numbers, int number)
        {
            (numbers ??= new List<int>()).Add(number);
            return numbers;
        }
    }
}
