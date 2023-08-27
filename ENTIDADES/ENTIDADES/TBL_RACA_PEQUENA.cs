using System;
using System.Data.Linq.Mapping;
using System.Threading;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_RACA_PEQUENA")] // Especifica o nome da tabela no banco de dados
    public class TBL_RACA_PEQUENA
    {
        [Column(Name = "ID_RACA", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_RACA { get; set; }

        [Column(Name = "NOME")]
        public string NOME { get; set; }

        [Column(Name = "PORTE")]
        public string PORTE { get; set; }

    }
}

