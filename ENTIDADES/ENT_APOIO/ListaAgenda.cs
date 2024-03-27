using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTIDADES.ENT_APOIO
{
   

    public static class InfoUsuario
    {
        public static int _idUsuario;

        public static string _usuario;

        public static string _nome;

        public static int _status;

        public static int _permissao;
    }



    public class ListaAgenda
    {
        public int ID_AGENDA { get; set; }

        public string DONO { get; set; }

        public string PET { get; set; }

        public string RACA { get; set; }

        public DateTime DATA { get; set; }

        public string HORA { get; set; }

        public decimal VALOR { get; set; }

        public string SERVICO { get; set; }

        public bool PRESENCA { get; set; }
    }

    public class Pets
    {
        public int ID { get; set; }

        public string DONO { get; set; }

        public string ENDERECO { get; set; }

        public string TELEFONE { get; set; }

        public string PET { get; set; }

        public int RACA { get; set; }

        public string OBSERVACOES { get; set; }

        public byte[] FOTO { get; set; }

        public DateTime DATA_CADASTRO { get; set; }

    }
}
