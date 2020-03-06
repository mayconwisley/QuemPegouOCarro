using BancoDados;
using Classes.Cadastros;
using System;
using System.Data;

namespace Comandos.Atualizacao
{
    public class AtualizarCadCarro
    {
        private DB conexaoBancoDados;
        private string SQL = string.Empty;

        public bool AtualizarCarro(CadCarro cadCarro)
        {
            conexaoBancoDados = new DB();
            SQL = "UPDATE tblCarro SET  Placa = @Placa, Marca = @Marca, Chassi = @Chassi, Renavam =  @Renavam " +
                  "WHERE ID = @ID";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@Placa", cadCarro.Placa);
                conexaoBancoDados.AdicionarParametros("@Marca", cadCarro.Marca);
                conexaoBancoDados.AdicionarParametros("@Chassi", cadCarro.Chassi);
                conexaoBancoDados.AdicionarParametros("@Renavam", cadCarro.Renavam);
                conexaoBancoDados.AdicionarParametros("@ID", cadCarro.ID);
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
