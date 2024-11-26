using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taklif_1
{
    public class Class1 : StudentProperty
    {
        string Cs = "Data Source=.;Initial Catalog=testschool;Integrated Security=True";
        public void InsertAdo()
        {
                SqlConnection conn = new SqlConnection(Cs);
                conn.Open();
                string query = "INSERT INTO [dbo].[Student_Ef] ([Name],[LastName],[CodeMeli]) VALUES (@Name,@LastName,@CodeMeli)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@CodeMeli", CodeMeli);
                cmd.ExecuteNonQuery();
                conn.Close();
        }
        public void deleteAdo()
        {
            SqlConnection conn = new SqlConnection(Cs);
            conn.Open();
            string query = "DELETE FROM [dbo].[Student_Ef] WHERE CodeMeli=@CodeMeli";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CodeMeli", CodeMeli);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateAdo()
        {
            SqlConnection conn = new SqlConnection(Cs);
            conn.Open();
            string query = "UPDATE [dbo].[Student_Ef] SET [Name] = @Name,[LastName] = @LastName WHERE CodeMeli=@CodeMeli";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@CodeMeli", CodeMeli);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable SelectAdo()
        {
            SqlConnection con = new SqlConnection(Cs);
            con.Open();
            string query = "SELECT [Name] ,[LastName],[CodeMeli] FROM [dbo].[Student_Ef]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
