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
                double bmi = 0;

                string input = "";
                bool isValid = false;

                // first ask if they want to enter metric or standard
                // keep looping until they give a valid answer
                Console.WriteLine();
                Console.WriteLine("Use metric or standard measurements?");
                while (!isValid)
                {
                    Console.WriteLine("(Please enter 'metric' or 'standard')");
                    unit = Console.ReadLine();
                    if (validator.IsValidMetricStandard(unit)) { isValid = true; }
                }

                // set isValid back to false for the next time it's needed
                isValid = false;

                // if it's metric, go through this
                if (unit == "metric")
                {
                    // get their height in centimeters
                    // use another loop to validate that they entered a valid number in acceptable range
                    Console.WriteLine();
                    Console.WriteLine("What is your height in centimeters?");
                    while (!isValid)
                    {
                        Console.WriteLine("(Please enter a valid number of centimeters - no unit)");
                        input = Console.ReadLine();
                        if (validator.IsValidHeightCm(input))
                        { 
                            isValid = true; // set valid to true
                            height = Convert.ToDouble(input); // it's safe to convert now, so store in height
                        }
                    }

                    // set isValid back to false for the next time it's needed
                    isValid = false;

                    // get their weight in kg
                    // use another loop to validate that they entered a valid number in acceptable range
                    Console.WriteLine();
                    Console.WriteLine("What is your weight in kilograms?");
                    while (!isValid)
                    {
                        Console.WriteLine("(Please enter a valid number of kilograms - no unit)");
                        input = Console.ReadLine();
                        if (validator.IsValidWeightKg(input))
                        {
                            isValid = true; // set valid to true
                            weight = Convert.ToDouble(input); // it's safe to convert now, so store in height
                        }
                    }

                    // set isValid back to false for the next time it's needed
                    isValid = false;

                }
                // else if it's standard, go through this
                else
                {
                    // get their height in feet
                    // use another loop to validate that they entered a valid number in acceptable range
                    Console.WriteLine();
                    Console.WriteLine("What is your height in feet? (Inches will come next.)");
                    while (!isValid)
                    {
                        Console.WriteLine("(Please enter a valid number of feet - no unit)");
                        input = Console.ReadLine();
                        if (validator.IsValidHeightFeet(input))
                        {
                            isValid = true; // set valid to true
                            height = Convert.ToDouble(input); // it's safe to convert now, so store in height
                            // multiply the height by 12 to convert to inches
                            height *= 12;
                        }
                    }

                    // set isValid back to false for the next time it's needed
                    isValid = false;

                    // get the rest of the inches in their height
                    // use another loop to validate that they entered a valid number in acceptable range
                    Console.WriteLine();
                    Console.WriteLine("How many inches?");
                    while (!isValid)
                    {
                        Console.WriteLine("(Please enter a valid number of inches - no unit)");
                        input = Console.ReadLine();
                        if (validator.IsValidHeightInches(input))
                        {
                            isValid = true; // set valid to true
                            height += Convert.ToDouble(input); // it's safe to convert now, so store in height
                                                               // by adding it
                        }
                    }
                    //Console.WriteLine($"{height} inches"); // test

                    // set isValid back to false for the next time it's needed
                    isValid = false;

                    // get their weight in pounds
                    // use another loop to validate that they entered a valid number in acceptable range
                    Console.WriteLine();
                    Console.WriteLine("What is your weight in pounds?");
                    while (!isValid)
                    {
                        Console.WriteLine("(Please enter a valid number of pounds - no unit)");
                        input = Console.ReadLine();
                        if (validator.IsValidWeightIbs(input))
                        {
                            isValid = true; // set valid to true
                            weight = Convert.ToDouble(input); // it's safe to convert now, so store in height
                        }
                    }

                    // set isValid back to false for the next time it's needed
                    isValid = false;

                    // convert height to metric
                    height = ConvertInches(height);

                    // convert weight to metric
                    weight = ConvertPounds(weight);

                    //Console.WriteLine($"Height: {height} Weight: {weight}"); // test
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
        public static double ConvertInches(double number) // 1 inch = 2.54 cm
        {
            return number * 2.54;
        }

        // convert pounds to kg
        public static double ConvertPounds(double number) // divide by about 2.205
        {
            return number / 2.205;
        }

        // calculate their bmi - bmi = m / h^2
        public static double CalculateBmi(double height, double weight)
        {
            double temp = Math.Pow(height, 2);
            return weight / temp;
        }

        // calculate what health range their bmi is in


    }
}
