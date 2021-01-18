using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            Validator validator = new Validator();


            // title text
            Console.WriteLine("BMI Calculator");

            // A loop that continues until user types 'no' when asked to continue
            while (true) // keep going unless the loop is broken 
            {
                // variables
                string unit = "";
                double height = 0;
                double weight = 0;
                double bMI = 0;

                string input = "";
                bool isValid = false;

                // first ask if they want to enter metric or standard
                // keep looping until they give a valid answer
                Console.WriteLine();
                Console.WriteLine("Would you like to enter metric or standard measurements?");
                while (!isValid)
                {
                    Console.WriteLine("(Please enter 'metric' or 'standard')");
                    unit = Console.ReadLine();
                    if (validator.IsValidMetricStandard(unit)) { isValid = true; }
                }

                // set isValid back to false for the next time it's needed
                isValid = false;

                // if it's metric, go through this
                if (input == "metric")
                {
                    // get their height in centimeters
                    // use another loop to validate that they entered a valid number in acceptable range

                    // get their weight in kg
                    // use another loop to validate that they entered a valid number in acceptable range

                }
                // else if it's standard, go through this
                else
                {
                    // get their height in feet
                    // use another loop to validate that they entered a valid number in acceptable range

                    // multiply the feet by 12 to add to their height

                    // get the rest of the inches in their height
                    // use another loop to validate that they entered a valid number in acceptable range

                    // add the final inches to their height

                    // get their weight in pounds
                    // use another loop to validate that they entered a valid number in acceptable range

                    // convert height to metric

                    // convert weight to metric
                }

                // calculate the BMI

                // calculate if the range is healthy

                // display the results

                // set isValid to false
                isValid = false;

                // ask if they want to calculate again
                Console.WriteLine();
                Console.WriteLine("Would you like to calculate another BMI?");
                while (!isValid)
                {
                    Console.WriteLine("(Please enter 'yes' or 'no')");
                    input = Console.ReadLine();
                    if (validator.IsValidYesNo(input)) { isValid = true; }
                }

                // if the answer was 'no', break the loop - ignore case
                if (input.Equals("no", StringComparison.OrdinalIgnoreCase)) { break; }

            }


        }

        // methods

        // convert inches to centimeters

        // convert pounds to kg

        // calculate their bmi

        // calculate what health range their bmi is in

        
    }
}
