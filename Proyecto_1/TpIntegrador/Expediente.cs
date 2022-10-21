/*
 * Creado por SharpDevelop.
 * Usuario: maria
 * Fecha: 19/10/2022
 * Hora: 16:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TpIntegrador
{
	/// <summary>
	/// Description of Expediente.
	/// </summary>
	public class Expediente
	{
		//atributos
		int numero;
		string titular;
		string tipoTramite;
		string estado;
		Abogado abogado;
		DateTime fechaPresentacion;
		
		// constructor
		public Expediente(int numero, string titular, string tipoTramite, string estado, Abogado abogado, DateTime fechaPresentacion)
		{
			this.numero=numero;
			this.titular=titular;
			this.tipoTramite=tipoTramite;
			this.estado=estado;
			this.abogado=abogado;
			this.fechaPresentacion=fechaPresentacion;	
		}
		
		
		//propiedades
		
		public int Numero{
			set{numero=value;}
			get{return numero;}
		}
		public string Titular{
			set{titular=value;}
			get{return titular;}
		}
		
		public string TipoTramite{
			set{tipoTramite=value;}
			get{return tipoTramite;}
		}
		public string Estado{
			set{estado=value;}
			get{return estado;}
		}
		
		public Abogado Abogado{
			set{abogado=value;}
			get{return abogado;}
		}
		
		public DateTime FechaPresentacion{
			set{fechaPresentacion=value;}
			get{return fechaPresentacion;}
		}
		public void imprimir(){
			Console.WriteLine("Numero: "+numero+" // Titular:"+titular+" // Tipo: "+tipoTramite+" // Estado: "+estado+" // Abogado: "+abogado.NombreApellido+" // Fecha de presentacion: "+fechaPresentacion.ToString("dd/MM/yyyy"));
		}
		
	}
}
