using System.Data.SqlTypes;
namespace Ulises_mvc.Datos
{ 
	public class Conexion
	{
		private string cadenaSQL = string.Empty;

		public Conexion()
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

			cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;

		}

		public string getCadenaSQL()
		{
			return cadenaSQL;
		}
	}
}  

