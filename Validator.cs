using System;
using System.Collections.Generic;
using System.Text;

namespace BMICalculator
{
    class Validator
    {
        // methods to check validity

        // did they enter a valid number for feet and inches for height?

        // did they enter a valid number for kg?

        // did they enter a valid Ibs number in the range?

        // did they enter a valid kg number in the range?

        // did they enter valid metric or standard text?
        public bool IsValidMetricStandard(string input)
        {
            //if (input.Contains("m") || input.Contains("s")) // making it less picky for the user
            if (input.Equals("metric", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("standard", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // did they enter a valid yes or no?
        public bool IsValidYesNo(string input)
        {
            if (input.Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
