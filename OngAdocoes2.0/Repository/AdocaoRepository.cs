using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using OngAdocoes2._0.Model;
using OngAdocoes2._0.Service;
using OngAdocoes2._0.View;

namespace OngAdocoes2._0.Repository
{
    internal class AdocaoRepository : IAdocaoRepository
    {
        private readonly string conn;
        public AdocaoRepository()
        {
            conn = "Data Source=DESKTOP-IHETIF5; Initial Catalog=ONG_Adocoes; User Id=sa; Password=12345;";
        }
        public Adocao CadastroAdocao()
        {
            int numeroRegistro = Program.NumeroRandom();
            Console.WriteLine("Informe o CPF do adotante: ");
            string adotante = Console.ReadLine();
            if (new PessoaService().Exists(adotante) == true)
            {
                Console.WriteLine("Informe o Numero de registro (CHIP) do animal adotado: ");
                int adotado = int.Parse(Console.ReadLine());
                if (new AnimalService().Exists(adotado) == true)
                {
                    Adocao adocao = new Adocao(adotado, adotante, numeroRegistro);
                    Console.WriteLine("Registros obtidos com cadastro: ");
                    Console.WriteLine(adocao.ToString());
                    Program.PressioneParaProsseguir();
                    return adocao;
                }
                else
                {
                    Console.WriteLine("Não possuimos esse numero de chip cadastrado!!");
                    Program.PressioneParaProsseguir();
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Não possuimos esse registro adotante no Banco de dados!!");
                Program.PressioneParaProsseguir();
                return null;
            }
        }
        public bool Exist(int numeroRegistro)
        {
            bool existe = false;
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                var result = db.ExecuteScalar(Adocao.EXIST, new { numeroRegistro = numeroRegistro });
                if (result != null)
                {
                    existe = true;
                    return existe;
                }
            }
            return existe;
        }
        public void Insert(Adocao adocao)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Adocao.INSERT, adocao);
            }
        }
        public List<Adocao> SelectAll()
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                var adocao = db.Query<Adocao>(Adocao.SELECTALL);
                return (List<Adocao>)adocao;
            }
        }
        public void UpdateAdotado(int chip, int numeroRegistro)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Adocao.UPDATEADOTADO, new { adotado = chip, numeroRegistro = numeroRegistro });
            }
        }
        public void UpdateAdotante(string cpf, int numeroRegistro)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Adocao.UPDATEADOTANTE, new { adotante = cpf, numeroRegistro = numeroRegistro });
            }
        }
    }
}
