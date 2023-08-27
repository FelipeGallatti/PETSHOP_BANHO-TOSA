using System;
using System.Data.Linq.Mapping;
using System.Threading;

namespace ENTIDADES
{
    [Table(Name = "dbo.TBL_FORNECEDORES")] // Especifica o nome da tabela no banco de dados
    public class TBL_FORNECEDORES
    {
        [Column(Name = "Id_Fornecedor", IsPrimaryKey = true, IsDbGenerated = true)] // Especifica a coluna como chave primária e gerada pelo banco de dados (identity column)
        public int Id_Fornecedor { get; set; }

        [Column(Name = "Nome")]
        public string Nome { get; set; }

        [Column(Name = "Email")]
        public string Email { get; set; }

        [Column(Name = "Endereco")]
        public string Endereco { get; set; }

        [Column(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column(Name = "TelefoneOpcional")]
        public string TelefoneOpcional { get; set; }

        [Column(Name = "Produto")]
        public string Produto { get; set; }       
    }
}

