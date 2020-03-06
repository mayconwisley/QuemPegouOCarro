using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Listas;
using Classes.Cadastros;
using BancoDados;
using System.Data;

namespace Comandos.Consulta
{
    public class ConsultaCadVencCarro
    {

        DB conexaoBancoDados;
        CadVencCarro cadVencimentoCarro;
        CadVencCarroLista cadVencCarroLista;
        string SQL = string.Empty;

        public CadVencCarroLista ListaVencCarro()
        {
            conexaoBancoDados = new DB();
            cadVencCarroLista = new CadVencCarroLista();
            SQL = "SELECT tblVencimentoCarro.ID, tblVencimentoCarro.DataVencimento, tblVencimentoCarro.Status, tblCarro.Marca " +
                  "FROM tblVencimentoCarro " +
                  "INNER JOIN tblCarro ON tblVencimentoCarro.ID_Carro = tblCarro.ID " +
                  "ORDER BY tblVencimentoCarro.DataVencimento ASC";

            try
            {
                conexaoBancoDados.LimparParametros();
                DataTable dataTable = conexaoBancoDados.ExcutarConsulta(CommandType.Text, SQL);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    cadVencimentoCarro = new CadVencCarro();
                    
                    cadVencimentoCarro.ID = int.Parse(dataRow["ID"].ToString());
                    cadVencimentoCarro.ID_Carro = new CadCarro();
                    cadVencimentoCarro.ID_Carro.Marca = dataRow["Marca"].ToString();
                    cadVencimentoCarro.Status = dataRow["Status"].ToString();
                    cadVencimentoCarro.Vencimento = DateTime.Parse(dataRow["DataVencimento"].ToString());

                    cadVencCarroLista.Add(cadVencimentoCarro);
                }

                return cadVencCarroLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }









        }


    }
}
