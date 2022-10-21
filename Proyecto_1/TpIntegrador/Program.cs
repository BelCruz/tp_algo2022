/*
 * Creado por SharpDevelop.
 * Usuario: maria
 * Fecha: 19/10/2022
 * Hora: 15:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TpIntegrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Abogado a1= new Abogado("carlos",125456,"familia",9);
			//Expediente e1 = new Expediente(1,"diego","nuevo",Abogado.NombreApellido,"1997/6/4");
			
			a1.imprimir();
			//e1.imprimir();
			Console.ReadKey(true);
		}
	}
}