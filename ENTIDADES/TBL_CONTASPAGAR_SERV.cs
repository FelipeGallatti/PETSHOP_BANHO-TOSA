using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_CONTASPAGAR_SERV")] // Especifica o nome da tabela no banco de dados
    public class TBL_CONTASPAGAR_SERV
    {

        [Column(Name = "ID_SERVICO", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_SERVICO { get; set; }

        [Column(Name = "CATEGORIA_SERVICO")]
        public string CATEGORIA_SERVICO { get; set; }

    }
}
