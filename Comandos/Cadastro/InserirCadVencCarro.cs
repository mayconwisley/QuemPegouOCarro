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
    public class InserirCadVencCarro
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool CadastrarVencCarro(CadVencCarro cadVencCarro)
        {
            conexaoBancoDados = new DB();
            SQL = "INSERT INTO tblVencimentoCarro (DataVencimento, ID_Carro, Status)" +
                  "VALUES(@DataVencimento, @ID_Carro, @Status)";

            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@DataVencimento", cadVencCarro.Vencimento);
                conexaoBancoDados.AdicionarParametros("@ID_Carro", cadVencCarro.ID_Carro.ID);
                conexaoBancoDados.AdicionarParametros("@Status", cadVencCarro.Status);

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
