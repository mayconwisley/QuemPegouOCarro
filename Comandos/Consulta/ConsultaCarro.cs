using BancoDados;
using Classes.Cadastros;
using Classes.Listas;
using System;
using System.Data;

namespace Comandos.Consulta
{
    public class ConsultaCarro
    {
        DB conexaoBancoDados;
        CadCarroLista cadCarroLista;
        CadCarro cadCarro;
        string SQL = string.Empty;

        public CadCarroLista ListaCadCarro()
        {
            conexaoBancoDados = new DB();
            cadCarroLista = new CadCarroLista();

            SQL = "SELECT ID, Placa, Marca, Chassi,Renavam " +
                  "FROM tblCarro " +
                  "ORDER BY Placa ASC";
            try
            {
                conexaoBancoDados.LimparParametros();
                DataTable dataTable = conexaoBancoDados.ExcutarConsulta(CommandType.Text, SQL);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    cadCarro = new CadCarro();
                    cadCarro.ID = int.Parse(dataRow["ID"].ToString());
                    cadCarro.Placa = dataRow["Placa"].ToString();
                    cadCarro.Marca = dataRow["Marca"].ToString();
                    cadCarro.Chassi = dataRow["Chassi"].ToString();
                    cadCarro.Renavam = dataRow["Renavam"].ToString();
                    cadCarroLista.Add(cadCarro);
                }
                return cadCarroLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
