using BancoDados;
using Classes.Cadastros;
using System;
using System.Data;

namespace Comandos.Cadastro
{
    public class InserirCarro
    {
        string SQL = string.Empty;
        DB Conexao;
        public bool CadastrarCarro(CadCarro cadCarro)
        {
            Conexao = new DB();
            SQL = "INSERT INTO tblCarro (Placa, Marca, Chassi,Renavam) " +
                  "VALUES(@Placa, @Marca, @Chassi, @Renavam)";
            try
            {
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Placa", cadCarro.Placa);
                Conexao.AdicionarParametros("@Marca", cadCarro.Marca);
                Conexao.AdicionarParametros("@Chassi", cadCarro.Chassi);
                Conexao.AdicionarParametros("@Renavam", cadCarro.Renavam);

                Conexao.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
