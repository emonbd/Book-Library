using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;



namespace ETV_Book_Library_C_Sherp
{
    
    public class clsDBConn
    {

        
        
        private SqlConnection _dbConn;
        public SqlCommand Cmd;
        private SqlDataAdapter _dbDA;
        private DataTable _dbDT;

        public clsDBConn()
        {
            _dbConn = new SqlConnection("Data Source=192.168.11.130;Initial Catalog=ETVBookLibraryT;User ID=sa;Password=db-password");
            _dbConn.Open();

        }

        public void SqlQuery(string queryText)
        {
            Cmd = new SqlCommand(queryText, _dbConn);

        }

        public DataTable QueryEx()
        {
            _dbDA = new SqlDataAdapter(Cmd);
            _dbDT = new DataTable();
            _dbDA.Fill(_dbDT);
            return _dbDT;

        }

        public void NonQueryEx()
        {

            Cmd.ExecuteNonQuery();


        }


     }
}
