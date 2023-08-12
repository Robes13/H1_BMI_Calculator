using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating infite loop
            // For this program I decided to go with double.
            while(true)
            {
                // Asking user to write their height in meters and giving an example
                Console.WriteLine("Please enter your height in meters (1.80):");
                double height = Double.Parse(Console.ReadLine());
                // Asking user to write their weight in kg
                Console.WriteLine("Please enter your weight in kg (60):");
                double weight = Double.Parse(Console.ReadLine());
                // calculating bmi and rounding to two decimals.
                double bmi_calculated = Math.Round((weight / (height * height)), 2);
                // Finding the correct bmi match and writing result.
                if (bmi_calculated > 16 && bmi_calculated < 18.5)
                    Console.WriteLine("Your bmi number is " + bmi_calculated +", which means your body weight is in deficit");
                else if (bmi_calculated > 18.5 && bmi_calculated < 24)
                    Console.WriteLine("Your bmi number is " + bmi_calculated + ", which means your body weight is in the norm");
                else if (bmi_calculated > 24 && bmi_calculated < 30)
                    Console.WriteLine("Your bmi number is " + bmi_calculated + ", which means your body is over weight");
                else if (bmi_calculated > 30 && bmi_calculated < 35)
                    Console.WriteLine("Your bmi number is " + bmi_calculated + ", which means your body weight is in first degreee obesity");
                else if (bmi_calculated > 35 && bmi_calculated < 40)
                    Console.WriteLine("Your bmi number is " + bmi_calculated + ", which means your body weight is in second degreee obesity");
                else if (bmi_calculated > 40)
                    Console.WriteLine("Your bmi number is " + bmi_calculated + ", which means your body weight is in third degreee obesity");
                // Waiting for user to press a key, that way they can keep entering a new weight and height.
                Console.WriteLine("Press any key to enter new values.");
                Console.ReadKey(true);
            }
        }
    }
}
