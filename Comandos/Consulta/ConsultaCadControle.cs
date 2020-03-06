using BancoDados;
using Classes.Cadastros;
using Classes.Listas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comandos.Consulta
{
    public class ConsultaCadControle
    {
        DB conexaoBancoDados;
        CadControleLista cadControleLista;
        CadControle cadConstrole;
        string SQL = string.Empty;

        public CadControleLista ListaCadControle()
        {
            conexaoBancoDados = new DB();
            cadControleLista = new CadControleLista();

            SQL = "SELECT tblControle.ID, tblControle.DataHoraSaida, tblControle.DataHoraChegada, tblControle.Descricao, tblCarro.Marca, tblMotorista.Nome " +
                  "FROM tblControle " +
                  "INNER JOIN tblCarro ON tblControle.ID_Carro = tblCarro.ID " +
                  "INNER JOIN tblMotorista ON tblControle.ID_Motorista = tblMotorista.ID " +
                  "ORDER BY tblControle.DataHoraSaida DESC ";
            try
            {
                conexaoBancoDados.LimparParametros();
                DataTable dataTable = conexaoBancoDados.ExcutarConsulta(CommandType.Text, SQL);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    cadConstrole = new CadControle();
                    cadConstrole.ID = int.Parse(dataRow["ID"].ToString());
                    cadConstrole.Saida = DateTime.Parse(dataRow["DataHoraSaida"].ToString());

                    if (dataRow["DataHoraChegada"].ToString() != string.Empty)
                    {
                        cadConstrole.Chegada = DateTime.Parse(dataRow["DataHoraChegada"].ToString());
                    }

                    //cadConstrole.Chegada = DateTime.Parse(dataRow["DataHoraChegada"].ToString());

                    cadConstrole.Descricao = dataRow["Descricao"].ToString();
                    cadConstrole.ID_Carro = new CadCarro();
                    cadConstrole.ID_Carro.Marca = dataRow["Marca"].ToString();
                    cadConstrole.ID_Motorista = new CadMotorista();
                    cadConstrole.ID_Motorista.Nome = dataRow["Nome"].ToString();

                    cadControleLista.Add(cadConstrole);
                }
                return cadControleLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
