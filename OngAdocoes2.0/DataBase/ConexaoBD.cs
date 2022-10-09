using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using OngAdocoes2._0.Model;

namespace OngAdocoes2._0.DataBase
{
    internal class ConexaoBD : IConexaoBD
    {
        private readonly string _conexao;
        public ConexaoBD()
        {
            _conexao = "Data Source=DESKTOP-IHETIF5; Initial Catalog=ONG_Adocoes; User Id=sa; Password=12345;";
        }
    }
}
