using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamilaRivasEjercicio1
{
    class Program
    {
		static void Main(string[] args)
		{
			double Perimetro, Superficie, Hipotenusa;
			double CatetoA, CatetoB;
			Console.Write("Ingrese la Primer  medida del Triangulo:");
			CatetoA = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ingrese la segunda  medida del Triangulo:");
			CatetoB = Convert.ToDouble(Console.ReadLine());

			Superficie = (CatetoA * CatetoB) / 2;
			Hipotenusa = Math.Sqrt( Math.Pow ( CatetoA ,2) + Math.Pow( CatetoB , 2));
			Perimetro = CatetoA + CatetoB + Hipotenusa;

			Console.WriteLine($"El perimetro es:{Perimetro}");
			Console.WriteLine($"La superficie es:{Superficie}");

			Console.ReadLine();

		}
    }
}
