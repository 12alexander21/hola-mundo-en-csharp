/**
 * Muestra por pantalla la frase "Hola Mundo!"
 *
 * @author 12alexander21
 */
using System;

namespace HolaMundo
{
	class Program
	{
		static void Main(String[] args)
		{	
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Hola Mundo!");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Aquí estamos haciendo pruebas con Git.");
			Console.ResetColor();
		}
	}
}
