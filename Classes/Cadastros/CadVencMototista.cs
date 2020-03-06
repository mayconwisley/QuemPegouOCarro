using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Cadastros
{
    public class CadVencMototista
    {
        public int ID { get; set; }
        public DateTime Vencimento { get; set; }
        public string Status { get; set; }
        public CadMotorista ID_Motorista { get; set; }
    }
}
