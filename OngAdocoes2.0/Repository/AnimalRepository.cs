using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OngAdocoes2._0.Model;
using OngAdocoes2._0.View;
using Org.BouncyCastle.Asn1;

namespace OngAdocoes2._0.Repository
{
    internal class AnimalRepository : IAnimalRepository
    {
        private readonly string conn;
        public AnimalRepository()
        {
            conn = "Data Source=DESKTOP-IHETIF5; Initial Catalog=ONG_Adocoes; User Id=sa; Password=12345;";
        }
        public Animal CadastroAnimal()
        {
            int chip = Program.NumeroRandom();
            Console.WriteLine("informe a classificação de familia deste animal (Gato, Cachorro, Peixe...): ");
            string familia = Console.ReadLine();
            while (familia == "\n")
            {
                Console.WriteLine("Valor inválido inserido, informe novamente:");
                familia = Console.ReadLine();
            }
            Console.WriteLine("Informe a raça do animal: ");
            string raca = Console.ReadLine();
            Console.WriteLine("Informe o sexo do animal (M ou F):");
            string sexo = Console.ReadLine().ToUpper();
            while (sexo != "M" && sexo != "F")
            {
                Console.WriteLine("Opção inválida, informe novamente o valor: ");
                sexo = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Deseja informar o nome do animal: \n[1]Sim \n[2]Não");
            int opc = int.Parse(Console.ReadLine());
            while (opc != 1 && opc != 2)
            {
                Console.WriteLine("Opção inválida, informe novamente o valor: ");
                opc = int.Parse(Console.ReadLine());
            }
            if (opc == 1)
            {
                Console.WriteLine("Informe o Nome do animal: ");
                string nome = Console.ReadLine();
                Animal animal = new Animal(chip, familia, raca, sexo, nome);
                Console.WriteLine("Dados obtidos para inserção em banco: ");
                Console.WriteLine(animal.ToString());
                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadKey();
                return animal;
            }
            else
            {
                Animal animal = new Animal(chip, familia, raca, sexo);
                Console.WriteLine("Dados obtidos para inserção em banco: ");
                Console.WriteLine(animal.ToString());
                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadKey();
                return animal;
            }
        }
        public bool Exists(int chip)
        {
            bool existe = false;
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                var result = db.ExecuteScalar(Animal.EXIST, new { chip = chip });
                if (result != null)
                {
                    existe = true;
                    return existe;
                }
            }
            return existe;
        }
        public void Delete(int chip)
        {
            throw new NotImplementedException();
        }
        public void Insert(Animal animal)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Animal.INSERT, animal);
            }
        }
        public List<Animal> SelecAll()
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                var animais = db.Query<Animal>(Animal.SELECT);
                return (List<Animal>)animais;
            }
        }
        public void UpdateFamilia(string familia, int chip)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Animal.UPDATEFAMILIA, new { familia = familia, chip = chip });
            }
        }
        public void UpdateNome(string nome, int chip)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Animal.UPDATENOME, new { nome = nome, chip = chip });
            }
        }
        public void UpdateRaca(string raca, int chip)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Animal.UPDATERACA, new { raca = raca, chip = chip });
            }
        }
        public void UpdateSexo(string sexo, int chip)
        {
            using (var db = new SqlConnection(conn))
            {
                db.Open();
                db.Execute(Animal.UPDATESEXO, new { sexo = sexo, chip = chip });
            }
        }
    }
}
