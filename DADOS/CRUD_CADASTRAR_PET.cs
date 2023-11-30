using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADOS
{
    public class CRUD_CADASTRAR_PET
    {
        private string connectionString = @"Data Source=DESKTOP-ECFLCP7;Initial Catalog=HippeDog;Integrated Security=True";



		public void InserirPet(TBL_CADASTRAR_PET ent)
		{
			try
			{
				using (var DB = new conexao(connectionString))
				{
					DB.GetTable<TBL_CADASTRAR_PET>().InsertOnSubmit(ent);
					DB.SubmitChanges();
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message.ToString());
			}
		}

		

    }
}
