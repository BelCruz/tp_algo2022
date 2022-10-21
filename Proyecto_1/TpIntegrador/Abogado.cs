/*
 * Creado por SharpDevelop.
 * Usuario: maria
 * Fecha: 19/10/2022
 * Hora: 15:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TpIntegrador
{
	/// <summary>
	/// Description of Abogado.
	/// </summary>
	public class Abogado
		
	{ 	string nombreApellido;
		int dni;
		string especialidad;
		int cantidadExpedientes; //maximo 6
		
		public Abogado(string nombreApellido, int dni, string especialidad, int cantidadExpedientes)
		{
			this.nombreApellido=nombreApellido;
			this.dni=dni;
			this.especialidad=especialidad;
			this.cantidadExpedientes=cantidadExpedientes;
		}
		public string NombreApellido
			{
			set{nombreApellido=value;}
			get{return nombreApellido;}
		    }
		public int Dni
		    {
			set{dni=value;}
			get{return dni;}
		    }
		
		public string Especialidad
		    {
			set{especialidad=value;}
			get{return especialidad;}
		    }
		
		public int CantidadExpedientes
		    {
			set{cantidadExpedientes=value;}
			get{return cantidadExpedientes;}
		
		    }
		
		public void imprimir(){
			Console.WriteLine("Nombre: "+nombreApellido+" // DNI: "+dni+" // Especialidad: "+especialidad+" // Cantidad de expedientes: "+cantidadExpedientes);
		}
		
		
		
		
	}
}
