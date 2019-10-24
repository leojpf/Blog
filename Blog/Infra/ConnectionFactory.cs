using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Infra
{
    public class ConnectionFactory
    {
        public static IDbConnection CriaConexaoAberta(string conexaoAberta) 
        {
            var cnx = new SqlConnection(conexaoAberta);
            cnx.Open();
            return cnx;
        }
    }
}
