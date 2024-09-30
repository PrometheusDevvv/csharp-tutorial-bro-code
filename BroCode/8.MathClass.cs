
namespace BroCode
{
    internal class MathClass
    {
        public MathClass()
        {
            double x = 3.14;
            double y = 5;

            double squared = Math.Pow(x, 2);        
            double squareRoot = Math.Sqrt(squared);  
            double absoluteValue = Math.Abs(x);      
            double rounded = Math.Round(x);          
            double ceilingValue = Math.Ceiling(x);   
            double floorValue = Math.Floor(x);       
            double maxValue = Math.Max(x, y);      
            double minValue = Math.Min(x, y);        

            // Output a summary of all the results
            Console.WriteLine($"Squared: {squared}");
            Console.WriteLine($"Square Root: {squareRoot}");
            Console.WriteLine($"Absolute Value: {absoluteValue}");
            Console.WriteLine($"Rounded: {rounded}");
            Console.WriteLine($"Ceiling Value: {ceilingValue}");
            Console.WriteLine($"Floor Value: {floorValue}");
            Console.WriteLine($"Max Value: {maxValue}");
            Console.WriteLine($"Min Value: {minValue}");

            Console.ReadKey(); // Wait for user input before closing
        }
    }
}
