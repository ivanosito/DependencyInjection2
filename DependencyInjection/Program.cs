using System;

namespace DependencyInjection
{
	// El inyector
	class MainClass
	{
		public static void Main(string[] args)
		{
			IAlimento alimento = null;

			alimento = new Pizza("Lechuga");
			//alimento = new Hamburguesa() { Tipo = "Cuarto Doble con Queso" };

			// Inyectamos la dependencia a tavés del constructor
			var persona = new Persona(alimento);

			// Persona usa 
			persona.Comer();

            // Stop
            Console.ReadKey();
		}
	}
}
