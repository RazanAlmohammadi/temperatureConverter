
class Program
{
    static string TempConvert(double temperature, string unit)
    {

        if (unit == "F" || unit == "f")
        {
            return "Converted: " + temperature + " " + unit + " = " + ((temperature - 32) * 5 / 9) + " C ";

        }
        else if (unit == "C" || unit == "c")
        {
            return "Converted: " + temperature + " " + unit + " = " + ((temperature * 1.8) + 32) + " F ";
        }
        else
        {

            return "Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.";
        }

    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");


            string input = Console.ReadLine();

            if (input == "Quit" || input == "quit")
            {
                Console.WriteLine($"Program terminated.");

                break;
            }

           
            if (!double.TryParse(input, out double temperature))
            {
                Console.WriteLine("Invalid temperature input. Please enter a numeric value.");
                continue; 
            }
            
            string unit = Console.ReadLine();
            Console.WriteLine(TempConvert(temperature, unit));

        }
    }
}