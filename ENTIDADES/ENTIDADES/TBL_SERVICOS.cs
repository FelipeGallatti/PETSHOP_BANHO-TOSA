using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_SERVICOS")] // Especifica o nome da tabela no banco de dados
    public class TBL_SERVICOS
    {

        [Column(Name = "ID_SERVICO", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_SERVICO { get; set; }

        [Column(Name = "NOME_SERVICO")]
        public string NOME_SERVICO { get; set; }

    }
}
