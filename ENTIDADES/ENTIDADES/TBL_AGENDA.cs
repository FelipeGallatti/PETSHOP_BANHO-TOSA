using System;
using System.Data.Linq.Mapping;
using System.Threading;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_AGENDA")] // Especifica o nome da tabela no banco de dados
    public class TBL_AGENDA
    {
        [Column(Name = "ID_AGENDA", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int ID_AGENDA { get; set; }

        [Column(Name = "DONO")]
        public string DONO { get; set; }

        [Column(Name = "TELEFONE")]
        public string TELEFONE { get; set; }

        [Column(Name = "SERVICO")]
        public string SERVICO { get; set; }

        [Column(Name = "PET")]
        public string PET { get; set; }

        [Column(Name = "DETALHES")]
        public string DETALHES { get; set; }

        [Column(Name = "DATA")]
        public DateTime DATA { get; set; }

        [Column(Name = "HORA")]
        public string HORA { get; set; }

        [Column(Name = "VALOR")]
        public decimal VALOR { get; set; }

        [Column(Name = "FALTOU")]
        public bool FALTOU { get; set; }

        [Column(Name = "RACA")]
        public int RACA{ get; set; }

        [Column(Name = "BANHO_REALIZADO")]
        public bool BANHO_REALIZADO { get; set; }

        
    }
}

