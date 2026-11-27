using System;

namespace MundoAnimal.Estructura
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class EntidadVeterinariaAttribute : Attribute
	{
		public string Descripcion { get; }

		public EntidadVeterinariaAttribute(string descripcion)
		{
			Descripcion = descripcion;
		}
	}
}