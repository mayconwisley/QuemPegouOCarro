using BancoDados;
using System;
using System.Data;
namespace Comandos.Exclusao
{
    public class ExcluirCadVencMotorista
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool ExcluirVencMotorista(int ID_VencMotorista)
        {
            conexaoBancoDados = new DB();
            SQL = "DELETE FROM tblVencimentoMotorista " +
                  "WHERE ID = @ID";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@ID", ID_VencMotorista);
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
