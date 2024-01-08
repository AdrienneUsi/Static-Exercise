using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double f)
		{
			return (f - 32) / 1.8;
		}
		public static double CelsiusToFahrenheit(double c)

		{
			return (c * 1.8) + 32;
		}
	}
}

