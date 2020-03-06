using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Cadastros;
using Classes.Listas;
using BancoDados;
using System.Data;

namespace Comandos.Consulta
{
    public class ConsultaMotorista
    {

        DB conexaoBancoDados;
        CadMotoristaLista cadMotoristaLista;
        CadMotorista cadMotorista;
        string SQL = string.Empty;
        public CadMotoristaLista ListaCadMotorista()
        {
            conexaoBancoDados = new DB();
            cadMotoristaLista = new CadMotoristaLista();

            SQL = "SELECT ID, Nome, NumCNH, VencimentoCNH, CPF, RG " +
                  "FROM tblMotorista " +
                  "ORDER BY Nome ASC ";
            try
            {
                conexaoBancoDados.LimparParametros();
                DataTable dataTable = conexaoBancoDados.ExcutarConsulta(CommandType.Text, SQL);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    cadMotorista = new CadMotorista();

                    cadMotorista.ID = int.Parse(dataRow["ID"].ToString());
                    cadMotorista.Nome = dataRow["Nome"].ToString();
                    cadMotorista.CNH = dataRow["NumCNH"].ToString();
                    cadMotorista.VencimentoCNH = DateTime.Parse(dataRow["VencimentoCNH"].ToString());
                    cadMotorista.CPF = dataRow["CPF"].ToString();
                    cadMotorista.RG = dataRow["RG"].ToString();

                    cadMotoristaLista.Add(cadMotorista);
                }
                return cadMotoristaLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
