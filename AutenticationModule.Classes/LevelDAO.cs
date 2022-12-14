using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticationModule.Classes
{
    public class LevelDAO
    {
        public string Insert(string nome)
        {            
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Nivel(nome)Values(@Nome)";         
            command.Parameters.Add(new SqlParameter("@Nome", nome));
            command.ExecuteNonQuery();

            Connection.sqlConnection.Close();

            return "Successfully inserted";

        }


        public string Update(string id, string nome)
        {
            Connection.sqlConnection.Open();
            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = ( "update Nivel set Nome=@Nome where id=@ID" );
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Nome", nome);
            command.ExecuteNonQuery();

            Connection.sqlConnection.Close();

            return "Successfully updated";
        }
        public DataTable Select()
        {
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from nivel order by id;";
            DataTable table = new DataTable();
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);            

            Connection.sqlConnection.Close();

            return table;
        }
        public DataTable Select(string nome)
        {
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from nivel where nome = @nome;";
            command.Parameters.AddWithValue("@nome", nome);
            DataTable table = new DataTable();
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);
            

            Connection.sqlConnection.Close();

            return table;
        }
        public int SelectId(string name)
        {
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select id from nivel where nome = @name;";
            command.Parameters.AddWithValue("@name", name);
            
            int id = (int)command.ExecuteScalar();
            command.ExecuteNonQuery();

            Connection.sqlConnection.Close();

            return id;
        }

        public DataTable SelectLike(string like)
        {
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select nome from nivel where nome like '@like%';";
            command.Parameters.AddWithValue("@like", like);
            DataTable table = new DataTable();
            SqlDataReader reader = command.ExecuteReader();
            table.Load(reader);

            Connection.sqlConnection.Close();

            return table;
        }

        public string Delete(string id)
        {
            Connection.sqlConnection.Open();

            SqlCommand command = Connection.sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Delete nivel where id = @id;";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Connection.sqlConnection.Close();

            return "Successfully deleted";
        }
    }
}
