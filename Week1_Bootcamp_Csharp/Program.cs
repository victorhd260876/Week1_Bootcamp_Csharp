using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Bootcamp_Csharp;
internal class Menu
{
	private static void Main()
	{
		Console.WriteLine("***  DESARROLLO WEB FULL STACK C#  ***");
		Console.WriteLine("--------------------------------------");
		Console.WriteLine("   Ejercicio con operaciones básicas");
		Console.WriteLine("   ");

		Console.WriteLine("       Ingrese primer número :");
			double num1= Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("       Ingrese un segundo número :");
			double num2 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("       Ingrese operación a usar : (+ , - , * , / : ");
		char operacion = Console.ReadLine()[0];

		double resultado = 0;



			if (operacion == '+')
			{
				resultado = num1 + num2;
				Console.WriteLine("       El resultado de la suma es : " + resultado);
			}
			if (operacion == '-')
			{
				resultado = num1 - num2;
				Console.WriteLine("       El resultado de la resta es : " + resultado);
			}
			if (operacion == '*')
			{
				resultado = num1 * num2;
				Console.WriteLine("       El resultado de la multiplicación es : " + resultado);
			}
		else if (operacion == '/')
		{
			if (num1 > 0 & num2>0 )

			{
				resultado = num1 + num2;
				Console.WriteLine("       El resultado de la división es : " + resultado);
			}

			else
			{
				Console.WriteLine("       La división no es posible");
			}
		}
	}

}