using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.ENT_APOIO
{
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
}
