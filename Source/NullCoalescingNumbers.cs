// This is a sample of coalescing assignment operator in C#8

using System;
using System.Collections.Generic;

namespace lib
{
    public class NullCoalescingNumbers
    {

        public int TotalNumbers(int? baseNumber, int numberToAdd)
        {
            return (baseNumber ??= 0) + numberToAdd;
        }
    }
}
