using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Cadastros
{
    public class CadVencCarro
    {
        public int ID { get; set; }
        public DateTime Vencimento { get; set; }
        public string Status { get; set; }
        public CadCarro ID_Carro { get; set; }
    }
}
