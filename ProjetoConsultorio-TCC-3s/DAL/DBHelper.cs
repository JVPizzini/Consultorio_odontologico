using ProjetoTCC2020.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoTCC2020.DAL
{
    class DBHelper
    {
        public String StringConexao { get; }
        public SqlConnection Conexao { get; }
        //transaction
        public DBHelper()
        {
            // Mudar string de conexão se mudar de banco
            StringConexao = @"Data Source=DESKTOP-9IUVQQE\SQLEXPRESS;Initial Catalog=Consultorio;Integrated Security=True"; // PIZZINI
            //StringConexao = @"Data Source=DESKTOP-64EMUFN\SQLEXPRESS;Initial Catalog=Clinica;Integrated Security=True"; // LUCAS
            Conexao = new SqlConnection(StringConexao);
        }
        public DBHelper(String stringConexao)
        {
            StringConexao = stringConexao;
            Conexao = new SqlConnection(StringConexao);
        }
        public RetornoBanco ExecuteProcWhitMsg(string procName, params SqlParameter[] parameters)
        {
            try
            {
                Open();
                SqlCommand command = Conexao.CreateCommand();
                command.CommandText = procName;
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlParameter msgRetorno = command.Parameters.Add("@MsgRetorno", SqlDbType.NVarChar, 2000);
                msgRetorno.Direction = ParameterDirection.Output;

                SqlParameter isOk = command.Parameters.Add("@IsOk", SqlDbType.Bit);
                isOk.Direction = ParameterDirection.Output;

                ExecuteNonQuery(command);
                return new RetornoBanco
                {
                    MsgRetorno = msgRetorno.Value.ToString(),
                    IsOk = Convert.ToBoolean(isOk.Value)
                };
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Close();
            }
        }
        public DataSet RetornarDataSet(string strQuery)
        {

            try
            {
                Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conexao;
                cmd.ExecuteNonQuery();
                /*  Declarado um dataadapter e um dataset
                    passar o comando para o da (SqlDataAdapter) e
                    carregar o dataset com resultado da busca */
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Close();
            }
        }
        public DataTable RetornarDataTable(string query, params SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                Open();
                SqlCommand command = Conexao.CreateCommand();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                dataTable.Load(command.ExecuteReader());

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Close();
            }

            return dataTable;
        }
        public DataTable RetornarDataTableProc(string ProcName, params SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                Open();
                SqlCommand command = Conexao.CreateCommand();
                command.CommandText = ProcName;
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                dataTable.Load(command.ExecuteReader());

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Close();
            }

            return dataTable;
        }
        public SqlDataReader RetornarDataReader(string query, params SqlParameter[] parameters)
        {
            try
            {
                Open();
                SqlCommand command = Conexao.CreateCommand();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataReader registro = command.ExecuteReader();
                return registro;
            }
            catch (Exception)
            {

                throw;
            }

        }
        //public SqlDataReader RetornarDataReaderProc(string ProcName, params SqlParameter[] parameters)
        //{
        //    try
        //    {
        //        this.Open();
        //        SqlCommand command = this.Conexao.CreateCommand();
        //        command.CommandText = ProcName;
        //        command.CommandType = CommandType.StoredProcedure;
        //        if (parameters != null)
        //            command.Parameters.AddRange(parameters);
        //        SqlDataReader registro = command.ExecuteReader();
        //        return registro;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        this.Close();
        //    }
        //}
        public Usuario VerificarLogin(string procName, params SqlParameter[] parameters)
        {

            Usuario user = new Usuario();

            try
            {
                Open();
                SqlCommand command = Conexao.CreateCommand();
                command.CommandText = procName;
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlParameter paramLoginOk = command.Parameters.Add("@LoginOK", SqlDbType.NVarChar, 4000);
                paramLoginOk.Direction = ParameterDirection.Output;

                SqlParameter paramCod = command.Parameters.Add("@CodFunc", SqlDbType.Int);
                paramCod.Direction = ParameterDirection.Output;

                SqlParameter paramName = command.Parameters.Add("@NomeFunc", SqlDbType.NVarChar, 2000);
                paramName.Direction = ParameterDirection.Output;

                SqlDataReader registro = command.ExecuteReader();
                int contadorLinhas = 0;
                while (registro.Read())
                {
                    contadorLinhas++;
                }
                registro.Close();
                if (paramLoginOk.Value.Equals("OK"))
                {
                    user.isOK = true;
                    user.codUsuario = int.Parse(paramCod.Value.ToString());
                    user.nomeUsuario = paramName.Value.ToString();
                }
                user.MsgRetorno = paramLoginOk.Value.ToString();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Close();
            }
        }
        //public int RetornarIdNumerico(string strQuery)
        //{

        //    try
        //    {
        //        this.Conexao.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = strQuery.ToString();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = this.Conexao;
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        int codigo;
        //        if (dr.Read())
        //            codigo = Convert.ToInt16(dr[0]) + 1;
        //        else
        //            codigo = 1;
        //        return codigo;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        this.Conexao.Close();
        //    }
        //}
        public void ExecuteNonQuery(SqlCommand command)
        {
            command.ExecuteNonQuery();
        }
        //public void ExecuteNonQuery(SqlCommand command, bool openConnection)
        //{
        //    if (openConnection)
        //    {
        //        this.Open();
        //    }
        //    this.ExecuteNonQuery(command);
        //    if (openConnection)
        //    {
        //        this.Close();
        //    }
        //}
        public void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            Exception erro = null;
            try
            {
                Open();
                SqlCommand command = Conexao.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                ExecuteNonQuery(command);
                Close();
            }
            catch (Exception ex)
            {
                erro = ex;
            }
            finally
            {
                Close();
            }

            if (erro != null)
            {
                throw erro;
            }
        }
        public void ExecuteNonQueryProc(string procName, params SqlParameter[] parameters)
        {
            Exception erro = null;
            try
            {
                Open();
                SqlCommand command = Conexao.CreateCommand();
                command.CommandText = procName;
                command.Parameters.AddRange(parameters);
                command.CommandType = CommandType.StoredProcedure;
                ExecuteNonQuery(command);
                Close();
            }
            catch (SqlException SQLex)
            {
                throw SQLex;
            }
            catch (Exception ex)
            {
                erro = ex;
            }
            finally
            {
                Close();
            }

            if (erro != null)
            {
                throw erro;
            }
        }
        public void Open()
        {
            Conexao.Open();
        }
        public void Close()
        {
            if (Conexao.State == ConnectionState.Open)
            {
                Conexao.Close();
            }
        }
    }
}
