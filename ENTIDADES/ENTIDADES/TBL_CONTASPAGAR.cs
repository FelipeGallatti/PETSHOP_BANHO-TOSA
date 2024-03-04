using System;
using System.Data.Linq.Mapping;
using System.Threading;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_CONTASPAGAR")] // Especifica o nome da tabela no banco de dados
    public class TBL_CONTASPAGAR
    {
        [Column(Name = "ID_CP", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_CP { get; set; }

        [Column(Name = "Descricao")]
        public string Descricao { get; set; }

        [Column(Name = "Categoria")]
        public string Categoria { get; set; }

        [Column(Name = "Data_Vencimento")]
        public DateTime Data_Vencimento { get; set; }

        [Column(Name = "Valor")]
        public decimal Valor { get; set; }


        [Column(Name = "Pagamento")]
        public bool Pagamento { get; set; }

    }
}

