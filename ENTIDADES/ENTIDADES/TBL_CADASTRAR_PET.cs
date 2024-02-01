using System;
using System.Data.Linq.Mapping;
using System.Threading;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_CADASTRAR_PET")] // Especifica o nome da tabela no banco de dados
    public class TBL_CADASTRAR_PET
    {
        [Column(Name = "ID", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID { get; set; }

        [Column(Name = "DONO")]
        public string DONO { get; set; }

        [Column(Name = "ENDERECO")]
        public string ENDERECO { get; set; }

        [Column(Name = "TELEFONE")]
        public string TELEFONE { get; set; }

        [Column(Name = "PET")]
        public string PET { get; set; }

        [Column(Name = "RACA")]
        public int RACA { get; set; }

        [Column(Name = "OBSERVACOES")]
        public string OBSERVACOES { get; set; }

        [Column(Name = "FOTO")]
        public byte[] FOTO { get; set; }

        [Column(Name = "DATA_CADASTRO")]
        public DateTime DATA_CADASTRO { get; set; }

    }
}

