namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Your temp in Fahrenheit is {TempConverter.CelsiusToFahrenheit(20)}");
            Console.WriteLine($"Your temp in Celsius is {TempConverter.FahrenheitToCelsius(20)}");
        }
    }
}
