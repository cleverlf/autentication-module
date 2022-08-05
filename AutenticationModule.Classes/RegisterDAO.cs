using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticationModule.Classes
{
    public class RegisterDAO
    {
        public string Insert(string name, string surname, string login, string password, int id_nivel)
        {
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO register(name,surname,login,password,id_nivel)" +
                "Values(@name,@surname,@login,@password,@id_nivel)";
            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@surname", surname));
            command.Parameters.Add(new SqlParameter("@login", login));
            command.Parameters.Add(new SqlParameter("@password", password));
            command.Parameters.Add(new SqlParameter("@id_nivel", id_nivel));
            command.ExecuteNonQuery();

            Connection.sqlConnection.Close();

            return "Successfully inserted";

        }


        public string Update(string id, string name, string surname, string login, string password, int id_nivel)
        {
            Connection.sqlConnection.Open();
            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = ( "update register set name = @name," +
                "surname = @surname," +
                "login = @login," +
                "password = @password," +
                "id_nivel = @id_nivel" +
                "where id = @id" );
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@surname", surname));
            command.Parameters.Add(new SqlParameter("@login", login));
            command.Parameters.Add(new SqlParameter("@password", password));
            command.Parameters.Add(new SqlParameter("@id_nivel", id_nivel));
            command.ExecuteNonQuery();

            Connection.sqlConnection.Close();

            return "Successfully updated";
        }
        //public DataTable Select()
        //{
        //    Connection.sqlConnection.Open();

        //    SqlCommand command = Connection.sqlConnection.CreateCommand();
        //    command.CommandType = System.Data.CommandType.Text;
        //    command.CommandText = "Select * from nivel order by id;";
        //    DataTable table = new DataTable();
        //    SqlDataReader reader = command.ExecuteReader();
        //    table.Load(reader);

        //    Connection.sqlConnection.Close();

        //    return table;
        //}
        //public DataTable Select(string nome)
        //{
        //    Connection.sqlConnection.Open();

        //    SqlCommand command = Connection.sqlConnection.CreateCommand();
        //    command.CommandType = System.Data.CommandType.Text;
        //    command.CommandText = "Select * from nivel where nome = @nome;";
        //    command.Parameters.AddWithValue("@nome", nome);
        //    DataTable table = new DataTable();
        //    SqlDataReader reader = command.ExecuteReader();
        //    table.Load(reader);


        //    Connection.sqlConnection.Close();

        //    return table;
        //}

        public string Delete(string id)
        {
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Delete register where id = @id;";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Connection.sqlConnection.Close();

            return "Successfully deleted";
        }
    }
}
