using BancoDados;
using System;
using System.Data;
namespace Comandos.Exclusao
{
    public class ExcluirCadVencCarro
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool ExcluirVencCarro(int ID_VencCarro)
        {
            conexaoBancoDados = new DB();
            SQL = "DELETE FROM tblVencimentoCarro " +
                  "WHERE ID = @ID";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@ID", ID_VencCarro);
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
