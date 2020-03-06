using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados;
using System.Data;

namespace Comandos.Exclusao
{
    public class ExcluirCadControle
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;

        public bool ExcluirControle(int ID_Controle)
        {
            conexaoBancoDados = new DB();
            SQL = "DELETE FROM tblControle WHERE ID = @ID";
            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@ID", ID_Controle);
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
