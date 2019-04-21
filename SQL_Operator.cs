using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Finance_Management
{
    class SQL_Operator
    {
        private static string connetionString = "Provider=MSDAORA;Data Source=orcl;User Id=scott;Password=password;";
        private static OleDbConnection connection = new OleDbConnection(connetionString);
        private static OleDbDataAdapter adapter;

        public bool Insert(string sqlQuery)
        {
            connection.Open();
            adapter = new OleDbDataAdapter("select * from student_info", connection);
            adapter.InsertCommand = new OleDbCommand(sqlQuery, connection);
            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public int Delete(string sqlQuery)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            try
            {
                return command.ExecuteNonQuery(); ;
            }
            catch (OleDbException)
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int Search(string sqlQuery)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            try
            {
                return command.ExecuteNonQuery(); ;
            }
            catch (OleDbException)
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public void Display(string sqlQuery, DataGridView dataGridView)
        {
            connection.Open();
            adapter = new OleDbDataAdapter(sqlQuery, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            connection.Close();
        }

        public bool Update(string sqlQuery)
        {
            connection.Open();
            adapter = new OleDbDataAdapter("select * from student_info", connection);
            adapter.UpdateCommand = new OleDbCommand(sqlQuery, connection);
            try
            {
                adapter.UpdateCommand.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}