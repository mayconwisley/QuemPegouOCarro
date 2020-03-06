using BancoDados;
using System;
using System.Data;

namespace Comandos.Consulta
{
    public class ConsultaIDMotorista
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;
        public int IDMotorista(string Nome)
        {
            conexaoBancoDados = new DB();
            SQL = "SELECT ID FROM tblMotorista WHERE Nome = @Nome";

            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@Nome", Nome);
                int ID_Motorista = int.Parse(conexaoBancoDados.Executar(CommandType.Text, SQL).ToString());

                return ID_Motorista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
