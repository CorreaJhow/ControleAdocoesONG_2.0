using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySqlX.XDevAPI.Common;
using OngAdocoes2._0.DataBase;
using OngAdocoes2._0.Model;

namespace OngAdocoes2._0.Repository
{
    internal class PessoaRepository : IPessoaRepository
    {
        private readonly string conn;
        public PessoaRepository()
        {
            conn = "Data Source=DESKTOP-IHETIF5; Initial Catalog=ONG_Adocoes; User Id=sa; Password=12345;";
        }
        public Pessoa CadastroPessoa()
        {
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Insira seu CPF (XXX.XXX.XXX-XX): ");
            string cpf = Console.ReadLine();
            Console.Write("Insira seu Sexo (M ou F): ");
            string sexo = Console.ReadLine().ToUpper();
            while (sexo != "M" && sexo != "F")
            {
                Console.Write("Valor incorreto informado, informe novamente: ");
                sexo = Console.ReadLine().ToUpper();
            }
            Console.Write("Insira sua data de nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Insira seu telefone ((xx) xxxxx-xxxx): ");
            string telefone = Console.ReadLine();
            Console.Write("Insira seu Logradouro: ");
            string logradouro = Console.ReadLine();
            Console.Write("Insira seu bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Insira sua cidade: ");
            string cidade = Console.ReadLine();
            Console.Write("Insira a sigla do estado em que reside: ");
            string siglaEstado = Console.ReadLine();
            Console.Write("Insira o numero da casa: ");
            string numero = Console.ReadLine();

            Pessoa novaPessoa = new Pessoa(nome, cpf, sexo, dataNascimento, telefone, logradouro, bairro, cidade, siglaEstado, numero);
            Console.WriteLine("Dados Obtidos: ");
            Console.WriteLine("---------------");
            Console.WriteLine(novaPessoa.ToString());
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            return novaPessoa;
        }//ok
        public void Delete(string cpf)
        {
            throw new NotImplementedException();
        }

        //public bool Exists(string cpf)
        //{
        //    bool existe = false;
        //    using (var db = new sqlconnection(conn))
        //    {
        //        db.open();
        //        var result = db.executescalar(pessoa.exists, new { cpf = cpf }); criar exist
        //        if (result != null)
        //        {
        //            existe = true;
        //            return existe;
        //        }
        //    }
        //    return existe;
        //}

        public bool Insert(Pessoa pessoa)
        {
            bool result = false;
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Pessoa.INSERT, pessoa);
                result = true;
            }
            return result;
        } 

        public void SelectAll(string cpf)
        {
            throw new NotImplementedException();
        }

        public void SelectOne(string cpf)
        {
            throw new NotImplementedException();
        }

        public void UpdateDataNascimento(DateTime DataNascimento, string cpf)
        {
            throw new NotImplementedException();
        }

        public void UpdateEndereco(string logradouro, string bairro, string cidade, string siglaEstado, string numero)
        {
            throw new NotImplementedException();
        }

        public void UpdateNome(string nome, string cpf)
        {
            throw new NotImplementedException();
        }

        public void UpdateTelefone(string telefone, string cpf)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
