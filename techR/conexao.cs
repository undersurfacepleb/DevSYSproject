using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.OleDb;


namespace techR
{
    class conexao
    {
        string conectaUS = (@"Provider = System.Data.SqlClient; Data Source = DESKTOP-4H3A8DB\SQLEXPRESS; Initial Catalog = databaseDEV-ETEP; Integrated Security = true;");
        public SqlConnection conec = null;

        public void OpenCon()
        {
            //tratamento de erros
            try
            {
                conec = new SqlConnection(conectaUS);
                conec.Open();
            }
            catch (Exception erro)
            {

                throw erro;
            }


        }

        public void CloseCon()
        {
            try
            {
                conec = new SqlConnection(conectaUS);
                conec.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        
        
        
        
        }
    }
}
