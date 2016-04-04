using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Berthiaume_Multiple; // Multiple class namespace for testings for multiples

namespace BerthiaumeKyle_Exercise1
{
    // Description: This test program prints out numbers 1-100. If the numbers are
    // multiples of 2, 7, or both the output to the console will be changed to
    // "Cross", "Shield", and "CrossShield" respectively. Checking for mulptiles
    // is accomplished using methods from the Multiple class.
    class TestProgram
    {
        static void Main(string[] args)
        {
            // Create Multiple object to test for multiples
            Multiple integer = new Multiple();

            // Print out numbers 1-100 if the number is a 
            // multiple of 2 print "Cross." If the number is
            // a multiple of 7 print "Shield."
            for(int i=1; i<101; i++)
            {
                // set integer property Number to i
                integer.Number = i;
                // if integer is a multiple of 2 and 7 print "CrossShield"
                if (integer.isMultipleOfTwo() && integer.isMultipleOfSeven())
                    Console.WriteLine("CrossShield");
                // if integer is a multiple of 7 print "Shield"
                else if (integer.isMultipleOfSeven())
                    Console.WriteLine("Shield");
                // if integer is a multiple of 2 print "Cross"
                else if (integer.isMultipleOfTwo())
                    Console.WriteLine("Cross");

                // if integer is neither a multiple of 2 or 7 print integer
                else
                    Console.WriteLine(integer.ToString());
            }
        }
    }
}
