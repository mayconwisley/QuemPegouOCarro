using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados;
using System.Data;

namespace Comandos.Exclusao
{
    public class ExcluirCadMotorista
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool ExcluirMotorista(int ID_Motorista)
        {
            conexaoBancoDados = new DB();
            SQL = "DELETE FROM tblMotorista " +
                  "WHERE ID = @ID";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@ID", ID_Motorista);

                conexaoBancoDados.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
