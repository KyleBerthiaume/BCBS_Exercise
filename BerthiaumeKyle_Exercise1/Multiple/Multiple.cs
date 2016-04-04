using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berthiaume_Multiple
{
    // Description: Class Multiple is simply used to check if a Number is a
    // multiple of 2 or 7.

    public class Multiple : IMultiple
    {
        // Properties------------------------------------------
        public int Number { get; set; } // Represents int to be tested

        //Default Constructor
        public Multiple()
        {
            // Assign tempNum to Property: Number
            Number = 0;
        }

        // Constructor
        public Multiple(int tempNum)
        {
            // Assign tempNum to Property: Number
            Number = tempNum;
        }

        // Methods---------------------------------------------

        // isMultipleOfSeven Method
        // Description: returns true or false based on whether
        // or not Number is a multiple of 7
        public bool isMultipleOfSeven()
        {
            if (Number % 7 == 0)
                return true;
            else
                return false;
        }

        // isMultipleOfSeven Method
        // Description: returns true or false based on whether
        // or not Number is a multiple of 2
        public bool isMultipleOfTwo()
        {
            if (Number % 2 == 0)
                return true;
            else
                return false;
        }

        // ToString
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
