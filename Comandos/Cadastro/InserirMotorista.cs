using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados;
using Classes.Cadastros;
using System.Data;

namespace Comandos.Cadastro
{
    public class InserirMotorista
    {
        private DB conexaoBancoDados;
        private string SQL = string.Empty;


        public bool CadastrarMotorista(CadMotorista cadMotorista)
        {
            conexaoBancoDados = new DB();
            SQL = "INSERT INTO tblMotorista (Nome, NumCNH, VencimentoCNH, CPF, RG) " +
                  "VALUES(@Nome, @NumCNH, @VencimentoCNH, @CPF, @RG) ";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@Nome", cadMotorista.Nome);
                conexaoBancoDados.AdicionarParametros("@NumCNH", cadMotorista.CNH);
                conexaoBancoDados.AdicionarParametros("@VencimentoCNH", cadMotorista.VencimentoCNH);
                conexaoBancoDados.AdicionarParametros("@CPF", cadMotorista.CPF);
                conexaoBancoDados.AdicionarParametros("@RG", cadMotorista.RG);

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
