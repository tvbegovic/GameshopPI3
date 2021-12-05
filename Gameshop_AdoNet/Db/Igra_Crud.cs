using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Gameshop_AdoNet.Db
{
	public class Igra_Crud
	{
		public List<Game> GetAll()
		{
			var rezultat = new List<Game>();
			
			return rezultat;
		}

		public Game GetById(int id)
		{
			Game rezultat = null;
			
			return rezultat;
			
		}

		public int Insert(Game igra)
		{
			
		}

		public int Update(Game igra)
		{
			
		}

		public void Delete(int id)
		{
			
		}
	}
	
}
