using System;

namespace itla3edad
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Bienenido");
			Console.WriteLine("ingrese edad:");

			int edad = int.Parse(Console.ReadLine());

			if (edad < 0) {
				Console.WriteLine("numero negativo");
					
			} else if (edad <= 12) {
				Console.WriteLine("Etapa de infancia");
					
			} else if (edad <= 17) {
				Console.WriteLine("Etapa de adolecencia");
					
			} else if (edad <= 65) {
				Console.WriteLine("Etapa de adultez");
					
			} else if (edad > 65) {
				Console.WriteLine("Etapa de vejez");
			}
		}
	}
}
