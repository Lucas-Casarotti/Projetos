using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PontosTuristicos
    {
        public int ID_PT { get; set; }
        public string Nome_PT { get; set; }
        public string Desc_PT { get; set; }
        public string Endereco_PT { get; set; }
        public string Cidade_PT { get; set; }
        //FK
        public int ID_Estado { get; set; }

    }
}
