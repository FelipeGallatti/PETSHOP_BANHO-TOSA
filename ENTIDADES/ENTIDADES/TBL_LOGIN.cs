using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_LOGIN")] // Especifica o nome da tabela no banco de dados
    public class TBL_LOGIN
    {

        [Column(Name = "ID_USUARIO", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_USUARIO { get; set; }

        [Column(Name = "USUARIO")]
        public string USUARIO { get; set; }

        [Column(Name = "SENHA")]
        public string SENHA { get; set; }

        [Column(Name = "NOME_USUARIO")]
        public string NOME_USUARIO { get; set; }

        [Column(Name = "STATUS")]
        public int STATUS { get; set; }

        [Column(Name = "PERMISSAO")]
        public int PERMISSAO { get; set; }

    }
}
