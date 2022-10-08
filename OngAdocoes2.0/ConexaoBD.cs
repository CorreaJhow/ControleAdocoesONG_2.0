using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OngAdocoes2._0
{
    internal class ConexaoBD : IConexaoBD
    {
        private string _conexao;

        public ConexaoBD()
        {
            _conexao = "Data Source=localhost; Initial Catalog=ONG_Adocoes; User Id=sa; Password=12345;";
        }


        
    }
}
