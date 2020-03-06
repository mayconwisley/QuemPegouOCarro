using System;
using System.Data;
using System.Data.SQLite;
namespace BancoDados
{
    public class DB
    {
        private string conexao = @"Data Source=|DataDirectory|BancoDados\QuemPegouOCarro.db";
        SQLiteCommand cmd;
        SQLiteParameterCollection sQLiteParameterCollection = new SQLiteCommand().Parameters;
        SQLiteConnection conn;


        private bool Conectar()
        {
            conn = new SQLiteConnection(conexao);
            try
            {
                conn.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException(ex.Message);
            }
        }
        private bool Desconectar()
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                    return true;
                }
                else
                {
                    conn.Dispose();
                    return false;
                }
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }

        }

        public void LimparParametros()
        {
            sQLiteParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametros, object valorParamentro)
        {
            sQLiteParameterCollection.Add(new SQLiteParameter(nomeParametros, valorParamentro));
        }

        //Inserir,Atualizar,Excluir
        public object Executar(CommandType commandType, string SQL)
        {
            if (Conectar())
            {
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandType = commandType;
                    cmd.CommandText = SQL;
                    cmd.CommandTimeout = 7200;

                    foreach (SQLiteParameter sQLiteParameter in sQLiteParameterCollection)
                    {
                        cmd.Parameters.Add(new SQLiteParameter(sQLiteParameter.ParameterName, sQLiteParameter.Value));
                    }
                    return cmd.ExecuteScalar();

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
            }
            else
            {
                return false;
            }
        }
        public DataTable ExcutarConsulta(CommandType commandType, string nomeProcedureOuSQL)
        {
            if (Conectar())
            {
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandType = commandType;
                    cmd.CommandText = nomeProcedureOuSQL;
                    cmd.CommandTimeout = 7200;

                    foreach (SQLiteParameter sQLiteParameter in sQLiteParameterCollection)
                    {
                        cmd.Parameters.Add(new SQLiteParameter(sQLiteParameter.ParameterName, sQLiteParameter.Value));
                    }

                    SQLiteDataAdapter oleDbDataAdapter = new SQLiteDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);

                    return dataTable;

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
            }
            else
            {
                return null;
            }
        }

    }
}
