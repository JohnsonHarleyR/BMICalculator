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
                string unit;
                double height;
                double weight;
                double bMI;

                string input;
                bool isValid = false;

                // first ask if they want to enter metric or standard
                // keep looping until they give a valid answer
                while (!isValid)
                { }

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

            }


        }

        // methods

        // convert inches to centimeters

        // convert pounds to kg

        // calculate their bmi

        // calculate what health range their bmi is in

        
    }
}
