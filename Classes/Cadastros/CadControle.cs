using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Cadastros
{
    public class CadControle
    {
        public int ID { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Chegada { get; set; }
        public string Descricao { get; set; }
        public CadCarro ID_Carro { get; set; }
        public CadMotorista ID_Motorista { get; set; }
    }
}
