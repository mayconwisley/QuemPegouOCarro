using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Cadastros
{
    public class CadMotorista
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNH { get; set; }
        public DateTime VencimentoCNH { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
    }
}
