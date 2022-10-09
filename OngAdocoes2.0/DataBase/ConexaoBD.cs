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
        private string _conexao;
        public ConexaoBD()
        {
            _conexao = "Data Source=DESKTOP-IHETIF5; Initial Catalog=ONG_Adocoes; User Id=sa; Password=12345;";
        }
        //fazer metodos de insert, update(um pra cada classe - variar a string), delete, select       
        
        public bool SelectPessoa()
        {
            bool result = false;
            using (var db = new SqlConnection(_conexao))
            {
                db.Open();
                db.Execute(Pessoa.SELECT);
                result = true;
            }
            return result;
        }
        public bool DeletePessoa(Pessoa pessoa)
        {
            bool result = false;
            using (var db = new SqlConnection(_conexao))
            {
                db.Open();
                db.Execute(Pessoa.DELETE, pessoa);
                result = true;
            }
            return result;
        }
        //update pessoa
        //insert animal
        //select animal 
        //delete animal
        //update animal
        //insert Adocao
        //select Adocao
        //Delete Adocao
        //Update Adocao 
    }
}
