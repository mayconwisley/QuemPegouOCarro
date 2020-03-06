using BancoDados;
using System;
using System.Data;

namespace Comandos.Exclusao
{
    public class ExcluirCadCarro
    {
        private DB conexaoBancoDados;
        private string SQL = string.Empty;

        public bool ExcluirCarro(int ID_Carro)
        {
            conexaoBancoDados = new DB();
            SQL = "DELETE FROM tblCarro " +
                  "WHERE ID = @ID";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@ID", ID_Carro);
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
