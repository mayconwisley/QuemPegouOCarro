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
    public class InserirCadVencMotorista
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool CadastrarVencMotorista(CadVencMototista cadVencMotorista)
        {
            conexaoBancoDados = new DB();
            SQL = "INSERT INTO tblVencimentoMotorista (DataVencimento, ID_Motorista, Status)" +
                  "VALUES(@DataVencimento, @ID_Motorista, @Status)";

            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@DataVencimento", cadVencMotorista.Vencimento);
                conexaoBancoDados.AdicionarParametros("@ID_Motorista", cadVencMotorista.ID_Motorista.ID);
                conexaoBancoDados.AdicionarParametros("@Status", cadVencMotorista.Status);

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
