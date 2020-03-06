using BancoDados;
using System;
using System.Data;

namespace Comandos.Consulta
{
    public class ConsultaIDCarro
    {
        DB conexaoBancoDados;
        string SQL = string.Empty;
        public int IDCarro(string MarcaModelo)
        {
            conexaoBancoDados = new DB();
            SQL = "SELECT ID FROM tblCarro WHERE Marca = @Marca";

            try
            {
                conexaoBancoDados.LimparParametros();
                conexaoBancoDados.AdicionarParametros("@Marca", MarcaModelo);
                int ID_Carro = int.Parse(conexaoBancoDados.Executar(CommandType.Text, SQL).ToString());

                return ID_Carro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
