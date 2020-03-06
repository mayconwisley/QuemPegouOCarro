using BancoDados;
using Classes.Cadastros;
using System;
using System.Data;

namespace Comandos.Cadastro
{
    public class InserirCadConstrole
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool CadastrarCadControleSaida(CadControle cadControle)
        {
            conexaoBancoDados = new DB();
            SQL = "INSERT INTO tblControle (DataHoraSaida, Descricao, ID_Carro, ID_Motorista) " +
                  "VALUES(@DataHoraSaida, @Descricao, @ID_Carro, @ID_Motorista)";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@DataHoraSaida", cadControle.Saida);
                conexaoBancoDados.AdicionarParametros("@Descricao", cadControle.Descricao);
                conexaoBancoDados.AdicionarParametros("@ID_Carro", cadControle.ID_Carro.ID);
                conexaoBancoDados.AdicionarParametros("@ID_Motorista", cadControle.ID_Motorista.ID);
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
