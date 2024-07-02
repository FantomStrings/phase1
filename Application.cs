using System.Text.RegularExpressions;

/*
 * Crude driver program in Main.
 */

namespace phase1;

class Application
{
    private static void Main(string[] args)
    {
        var introduction = @"#----------Area Calculator----------#
                               List of available operation codes:
                                        R = rectangle,
                                        T = triangle,
                                        E = ellipse.";
        if (introduction == null) throw new ArgumentNullException(nameof(introduction));
        Console.WriteLine(introduction);
        Console.WriteLine("Enter your operation command.");
        string? operation = Console.ReadLine()?.ToUpper();
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToDouble(Console.ReadLine());

        AreaCalculator calculator = new AreaCalculator(height, width, radius);

        if (operation == null || ! Regex.IsMatch(operation, "[R|T|E]") )
        {
            Console.WriteLine("That is not valid");
        }
        else
        {
            try
            {
                double result = calculator.Operation(operation);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("That is invalid.");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred trying to do the math.\n - Details: "
                                  + e.Message);
                
            }
        }
    }
}
