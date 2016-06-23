using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseApplication
{
    class DBManager
    {        
        public DataTable ResultTable
        {
            get
            {
                return tab;
            }
        }
        public string TextQuery 
        { 
            get
            { 
                return _textQuery; 
            } 
        }
        public string StatusQuery { get; private set; }

        private string _textQuery;
        private DataTable tab;
        private SqlConnection conn;
        private SqlDataAdapter da;
        private SqlDataReader reader;
        private SqlCommand cmd;
        private SqlCommandBuilder cmdBuilder;

        public DBManager()
        {
            _textQuery = "";
            conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=Shipping; Integrated Security=true;");
            cmd = new SqlCommand(_textQuery, conn);
        }

        public DataTable GetTableDB(string textNameTable)
        {
            _textQuery = "select * from " + textNameTable;
            ApplyQuery();

            return tab;
        }

        public void DeleteRows(string textNameTable, string nameFirstColomn, int valueCell)
        {
            _textQuery = "DELETE FROM " + textNameTable + " WHERE " + nameFirstColomn + "=" + valueCell;
            ApplyQuery();
        }

        public void DataBaseUpdate(DataTable dataTable, string nameTable)
        {
            try
            {
                conn.Open();
                da = new SqlDataAdapter("select * from " + nameTable, conn);
                cmdBuilder = new SqlCommandBuilder(da);
                da.Update(dataTable);
                conn.Close();
            }
            catch (Exception ex)
            {
                StatusQuery = ex.Message;
            }
        }

        public string ExecuteQuery(string textQuery)
        {
            this._textQuery = textQuery;
            ApplyQuery();
            return StatusQuery;
        }

        private void ApplyQuery()
        {
            tab = new DataTable();
            conn.Open();
            cmd.CommandText = _textQuery;
            try
            {                
                reader = cmd.ExecuteReader();
                tab.Load(reader);
                
                StatusQuery = "Выполненно успешно!!!";
            }
            catch (Exception ex)
            {
                StatusQuery = ex.Message;
            }
            conn.Close();
        }
    }
}