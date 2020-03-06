using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados;
using Classes.Cadastros;
using System.Data;

namespace Comandos.Atualizacao
{
    public class AtualizarCadMotorista
    {
        DB conexaBancoDados;
        string SQL = string.Empty;
        public bool AtualizarMotorista(CadMotorista cadMotorista)
        {
            conexaBancoDados = new DB();
            SQL = "UPDATE tblMotorista SET Nome = @Nome, NumCNH = @NumCNH, VencimentoCNH = @VencimentoCNH, CPF = @CPF, RG = @RG " +
                  "WHERE ID = @ID";
            try
            {
                conexaBancoDados.LimparParametros();
                conexaBancoDados.AdicionarParametros("@Nome", cadMotorista.Nome);
                conexaBancoDados.AdicionarParametros("@NumCNH", cadMotorista.CNH);
                conexaBancoDados.AdicionarParametros("@VencimentoCNH", cadMotorista.VencimentoCNH);
                conexaBancoDados.AdicionarParametros("@CPF", cadMotorista.CPF);
                conexaBancoDados.AdicionarParametros("@RG", cadMotorista.RG);
                conexaBancoDados.AdicionarParametros("@ID", cadMotorista.ID);

                conexaBancoDados.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
