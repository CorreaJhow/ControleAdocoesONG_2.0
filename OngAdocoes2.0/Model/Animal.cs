﻿using System;
using System.Linq;


namespace OngAdocoes2._0.Model
{
    internal class Animal
    {
        #region Strings conexao
        public readonly static string INSERT = "INSERT INTO Animal (CHIP, Familia, Raca, Sexo, Nome) values (@CHIP, @familia, @raca, @sexo, @nome);";
        public readonly static string SELECT = "Select CHIP, Familia, Raca, Sexo, Nome from Animal;";
        public readonly static string DELETE = "Delete from Animal where CHIP = @chip;";
        //gerar update variavel de acordo com o que mudar!
        #endregion

        #region Propriedades
        public int Chip { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }
        #endregion
        public Animal()
        {

        }
        public Animal(int chip, string familia, string raca, string sexo, string nome)
        {
            Chip = chip;
            Familia = familia;
            Raca = raca;
            Sexo = sexo;
            Nome = nome;
        }
        public Animal(int chip, string familia, string raca, string sexo)
        {
            Chip = chip;
            Familia = familia;
            Raca = raca;
            Sexo = sexo;
            Nome = "SemNome";
        }
        public Animal CadastroAnimal()
        {
            int chip = NumeroRandom();
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
                Console.WriteLine("Cadastro finalizado, animal cadastrado em nosso banco!");
                Console.WriteLine(animal.ToString());
                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadKey();
                return animal;
            }
            else
            {
                Animal animal = new Animal(chip, familia, raca, sexo);
                Console.WriteLine("Cadastro finalizado, animal cadastrado em nosso banco!");
                Console.WriteLine(animal.ToString());
                Console.WriteLine("Pressione enter para continuar...");
                Console.ReadKey();
                return animal;
            }
        }
        public static int NumeroRandom()
        {
            Random rand = new Random();
            int[] numero = new int[100];
            int aux = 0;
            for (int k = 0; k < numero.Length; k++)
            {
                int rnd = 0;
                do
                {
                    rnd = rand.Next(100, 999);
                } while (numero.Contains(rnd));
                numero[k] = rnd;
                aux = numero[k];
            }
            return aux;
        }
        public override string ToString()
        {
            return "\nNumero Identificação (CHIP): " + Chip +
                "\nNome do animal: " + Nome +
                "\nFamilia: " + Familia +
                "\nRaca: " + Raca +
                "\nSexo: " + Sexo;
        }
    }
}