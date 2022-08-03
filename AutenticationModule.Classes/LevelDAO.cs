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

            return "";

        }


        public string Update()
        {

            return "atualizar";
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

        public string Delete()
        {
            return "deletar";
        }
    }
}
