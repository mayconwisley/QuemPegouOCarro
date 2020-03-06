using BancoDados;
using Classes.Cadastros;
using System;
using System.Data;

namespace Comandos.Atualizacao
{
    public class AtualizarCadControle
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool AtualizarControle(CadControle cadControle)
        {
            conexaoBancoDados = new DB();
            SQL = "UPDATE tblControle SET DataHoraChegada = @DataHoraChegada " +
                  "WHERE ID = @ID";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@DataHoraChegada", cadControle.Chegada);
                conexaoBancoDados.AdicionarParametros("@ID", cadControle.ID);
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
