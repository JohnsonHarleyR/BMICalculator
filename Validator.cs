using System;
using System.Collections.Generic;
using System.Text;

namespace BMICalculator
{
    class Validator
    {
        // methods to check validity

        // TODO possibly find a more appropriate ranges for height and weights, not just records - maybe

        // did they enter a valid number for feet? - shortest human 1 ft 10 in, tallest 8 ft, 11.1 in
        public bool IsValidHeightFeet(string input)
        {
            try // if it can be converted to a double, then check if it's in range
            {
                double number = Convert.ToDouble(input);
                if (number >= 1 && number < 9) // now see if the number is in range
                {
                    return true;
                }
                else // if it's not in range, it's not valid so return false
                {
                    return false;
                }
            }
            // otherwise, return false because it's not a number
            catch (Exception) // HACK it doesn't want to let me write "Exception ex"
            {
                return false;
            }
        }

        // did they enter a valid number for inches?
        public bool IsValidHeightInches(string input)
        {
            try // if it can be converted to a double, then check if it's in range
            {
                double number = Convert.ToDouble(input);
                if (number >= 0 && number < 12) // now see if the number is in range
                {
                    return true;
                }
                else // if it's not in range, it's not valid so return false
                {
                    return false;
                }
            }
            // otherwise, return false because it's not a number
            catch (Exception) // HACK it doesn't want to let me write "Exception ex"
            {
                return false;
            }
        }

        // did they enter a valid number for cm in range? - tallest man is 251 cm, shortest is 54.6 cm
        public bool IsValidHeightCm(string input)
        {
            try // if it can be converted to a double, then check if it's in range
            {
                double number = Convert.ToDouble(input);
                if (number > 50 && number < 260) // now see if the number is in range
                {
                    return true;
                }
                else // if it's not in range, it's not valid so return false
                { 
                    return false; 
                }
            }
            // otherwise, return false because it's not a number
            catch (Exception) // HACK it doesn't want to let me write "Exception ex"
            {
                return false;
            }
        }

        // did they enter a valid Ibs number in the range?
        public bool IsValidWeightIbs(string input) // lightest human (dwarf) was 2.1kg (4.7 ibs), heaviest 635 kg (1,400 ibs)
        {
            try // if it can be converted to a double, then check if it's in range
            {
                double number = Convert.ToDouble(input);
                if (number >= 4.5 && number < 1500) // now see if the number is in range
                {
                    return true;
                }
                else // if it's not in range, it's not valid so return false
                {
                    return false;
                }
            }
            // otherwise, return false because it's not a number
            catch (Exception) // HACK it doesn't want to let me write "Exception ex"
            {
                return false;
            }
        }

        // did they enter a valid kg number in the range?
        public bool IsValidWeightKg(string input) // lightest human (dwarf) was 2.1kg (4.7 ibs), heaviest 635 kg (1,400 ibs)
        {
            try // if it can be converted to a double, then check if it's in range
            {
                double number = Convert.ToDouble(input);
                if (number >= 2 && number < 640) // now see if the number is in range
                {
                    return true;
                }
                else // if it's not in range, it's not valid so return false
                {
                    return false;
                }
            }
            // otherwise, return false because it's not a number
            catch (Exception) // HACK it doesn't want to let me write "Exception ex"
            {
                return false;
            }
        }

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
