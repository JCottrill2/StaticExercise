namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(99);
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine();

            var fahrenheit = TempConverter.CelsiusToFahrenheit(37);
            Console.WriteLine($"fahrenheit {fahrenheit}");
            Console.WriteLine();
        }
    }
}