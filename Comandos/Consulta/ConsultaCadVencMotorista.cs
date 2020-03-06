using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Listas;
using Classes.Cadastros;
using BancoDados;
using System.Data;

namespace Comandos.Consulta
{
    public class ConsultaCadVencMotorista
    {

        DB conexaoBancoDados;
        CadVencMototista cadVencMotorista;
        CadVencMotoristaLista cadVencMotoristaLista;

        string SQL = string.Empty;

        public CadVencMotoristaLista ListaVencMotorista()
        {
            conexaoBancoDados = new DB();
            cadVencMotoristaLista = new CadVencMotoristaLista();

            SQL = "SELECT tblVencimentoMotorista.ID, tblVencimentoMotorista.DataVencimento, tblVencimentoMotorista.Status, tblMotorista.Nome " +
                  "FROM tblVencimentoMotorista " +
                  "INNER JOIN tblMotorista ON tblVencimentoMotorista.ID_Motorista = tblMotorista.ID " +
                  "ORDER BY tblVencimentoMotorista.DataVencimento ASC";

            try
            {
                conexaoBancoDados.LimparParametros();
                DataTable dataTable = conexaoBancoDados.ExcutarConsulta(CommandType.Text, SQL);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    cadVencMotorista = new CadVencMototista();

                    cadVencMotorista.ID = int.Parse(dataRow["ID"].ToString());
                    cadVencMotorista.ID_Motorista = new CadMotorista();
                    cadVencMotorista.ID_Motorista.Nome = dataRow["Nome"].ToString();
                    cadVencMotorista.Status = dataRow["Status"].ToString();
                    cadVencMotorista.Vencimento = DateTime.Parse(dataRow["DataVencimento"].ToString());
                    cadVencMotoristaLista.Add(cadVencMotorista);
                }

                return cadVencMotoristaLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }









        }


    }
}
