using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OngAdocoes2._0.DataBase;
using OngAdocoes2._0.Model;
using OngAdocoes2._0.Service;

namespace OngAdocoes2._0.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            do
            {
                ConexaoBD conexaoBD = new ConexaoBD();
                Console.Clear();
                CabecalhoONG();
                Console.WriteLine("Bem vindo ao sistema de Adoções da nossa ONG");
                Console.WriteLine("O que deseja realizar: \n[0]Sair\n[1]Registrar \n[2]Atualizar \n[3]Consultar");
                int opcao = int.Parse(Console.ReadLine());
                while (opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida informada, por favor digite novemente!");
                    opcao = int.Parse(Console.ReadLine());
                }
                switch (opcao)
                {
                    case 0:
                        Console.Clear();
                        CabecalhoONG();
                        Console.WriteLine("Obrigado pela visita!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    case 1:
                        bool volta = false;
                        do
                        {
                            Console.Clear();
                            CabecalhoONG();
                            Console.WriteLine("O que voce deseja Registrar: \n[0]Voltar \n[1]Pessoa (cliente) \n[2]Animal \n[3]Adoção ");
                            int op1 = int.Parse(Console.ReadLine());
                            while (op1 < 0 || op1 > 3)
                            {
                                Console.WriteLine("Valor inválido informado, tente novamente: ");
                                op1 = int.Parse(Console.ReadLine());
                            }
                            switch (op1)
                            {
                                case 0:
                                    volta = true;
                                    break;
                                case 1:
                                    #region inserir pessoa             
                                    Console.Clear();
                                    CabecalhoONG();
                                    var pessoa = new PessoaService().CadastroPessoa();
                                    new PessoaService().Insert(pessoa);
                                    Console.WriteLine("### Pessoa inseria com sucesso! ####");
                                    PressioneParaProsseguir();
                                    #endregion   
                                    break;
                                case 2:
                                    #region Inserir Animal
                                    Console.Clear();
                                    CabecalhoONG();
                                    Animal animal = new AnimalService().CadastroAnimal();
                                    new AnimalService().Insert(animal);
                                    Console.WriteLine("### Cadastro efetuado com Sucesso! ###");
                                    PressioneParaProsseguir();
                                    #endregion                                  
                                    break;
                                case 3:
                                    #region Inserir Registro Adoçao
                                    Console.Clear();
                                    CabecalhoONG();
                                    var adocao = new AdocaoService().CadastroAdocao();
                                    if (adocao != null)
                                    {
                                        new AdocaoService().Insert(adocao);
                                    }
                                    #endregion
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida informada");
                                    break;
                            }
                        } while (!volta);
                        break;
                    case 2:
                        bool volta2 = false;
                        do
                        {
                            Console.Clear();
                            CabecalhoONG();
                            Console.WriteLine("O que voce deseja Atualizar: \n[0]Voltar\n[1]Pessoa (cliente) \n[2]Animal \n[3]Adocoes ");
                            int op2 = int.Parse(Console.ReadLine());
                            while (op2 < 0 || op2 > 3)
                            {
                                Console.WriteLine("Valor inválido informado, tente novamente: ");
                                op2 = int.Parse(Console.ReadLine());
                            }
                            switch (op2)
                            {
                                case 0:
                                    volta2 = true;
                                    break;
                                case 1:
                                    #region Atualiza Cliente
                                    Console.Clear();
                                    CabecalhoONG();
                                    Console.WriteLine("Informe o CPF que do cliente que deseja alterar: ");
                                    string Cpf = Console.ReadLine();
                                    if (new PessoaService().Exists(Cpf) == true)
                                    {
                                        Console.WriteLine("O que você deseja alterar do Cliente: \n[1]Nome \n[2]Sexo \n[3]Telefone \n[4]Endereco ");
                                        int opc = int.Parse(Console.ReadLine());
                                        while (opc < 1 || opc > 4)
                                        {
                                            Console.WriteLine("Opção inválida, informe novamente: ");
                                            opc = int.Parse(Console.ReadLine());
                                        }
                                        switch (opc)
                                        {
                                            case 1: //ok
                                                #region Atualiza Nome
                                                Console.WriteLine("Informe o novo nome: ");
                                                string nome = Console.ReadLine();
                                                new PessoaService().UpdateNome(nome, Cpf);
                                                Console.WriteLine("### Atualização efetuada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            case 2: //ok
                                                #region Atualiza Sexo
                                                Console.Write("Insira seu Sexo (M ou F): ");
                                                string sexo = Console.ReadLine().ToUpper();
                                                while (sexo != "M" && sexo != "F")
                                                {
                                                    Console.Write("Valor incorreto informado, informe novamente: ");
                                                    sexo = Console.ReadLine().ToUpper();
                                                }
                                                new PessoaService().UpdateSexo(sexo, Cpf);
                                                Console.WriteLine("### Atualização efetuada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            case 3: //ok
                                                #region Atualiza Telefone
                                                Console.WriteLine("Informe o novo numero de Telefone: ");
                                                string telefone = Console.ReadLine();
                                                new PessoaService().UpdateTelefone(telefone, Cpf);
                                                Console.WriteLine("### Atualização efetuada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            case 4: //ok
                                                #region atualiza estado
                                                Console.Write("Insira seu novo Logradouro: ");
                                                string logradouro = Console.ReadLine();
                                                Console.Write("Insira seu novo bairro: ");
                                                string bairro = Console.ReadLine();
                                                Console.Write("Insira sua novo cidade: ");
                                                string cidade = Console.ReadLine();
                                                Console.Write("Insira a nova sigla do estado em que reside: ");
                                                string siglaEstado = Console.ReadLine();
                                                Console.Write("Insira o nvo numero da casa: ");
                                                string numero = Console.ReadLine();
                                                new PessoaService().UpdateEndereco(logradouro, bairro, cidade, siglaEstado, numero, Cpf);
                                                Console.WriteLine("### Atualização efetuada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            default:
                                                Console.WriteLine("Erro de swicht!!");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Esse cpf é inválido ou nao esta cadastrado em nosso banco!!");
                                        Console.WriteLine("Verifique isso e tente novamente depois!");
                                        PressioneParaProsseguir();
                                    }
                                    #endregion
                                    break;
                                case 2:
                                    #region Atualiza Animal 
                                    Console.Clear();
                                    CabecalhoONG();
                                    Console.WriteLine("Informe o CHIP que do animal que deseja alterar o registro: ");
                                    int chip = int.Parse(Console.ReadLine());
                                    if (new AnimalService().Exists(chip) == false)
                                    {
                                        Console.WriteLine("Chip não encontrado em nosso banco de dados ou inválido!");
                                        PressioneParaProsseguir();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O que você deseja alterar do Animal: \n[1]Familia \n[2]Raca \n[3]Sexo \n[4]Nome");
                                        int opcAnimal = int.Parse(Console.ReadLine());
                                        while (opcAnimal < 1 || opcAnimal > 4)
                                        {
                                            Console.WriteLine("Opção inválida, informe novamente: ");
                                            opcAnimal = int.Parse(Console.ReadLine());
                                        }
                                        switch (opcAnimal)
                                        {
                                            case 1:
                                                #region Atualiza Familia Animal
                                                Console.WriteLine("Informe a nova familia do animal: ");
                                                string familia = Console.ReadLine();
                                                new AnimalService().UpdateFamilia(familia, chip);
                                                Console.WriteLine("### Atualização realizada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            case 2:
                                                #region Atualiza Raca Animal 
                                                Console.WriteLine("Informe a nova raça do animal: ");
                                                string raca = Console.ReadLine();
                                                new AnimalService().UpdateRaca(raca, chip);
                                                Console.WriteLine("### Atualização realizada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            case 3:
                                                #region Atualiza Sexo Animal 
                                                Console.Write("Insira o novo Sexo (M ou F): ");
                                                string sexo = Console.ReadLine().ToUpper();
                                                while (sexo != "M" && sexo != "F")
                                                {
                                                    Console.Write("Valor incorreto informado, informe novamente: ");
                                                    sexo = Console.ReadLine().ToUpper();
                                                }
                                                new AnimalService().UpdateSexo(sexo, chip);
                                                Console.WriteLine("### Atualização realizada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            case 4:
                                                #region Atualiza Nome Animal
                                                Console.WriteLine("Informe o novo nome do animal: ");
                                                string nome = Console.ReadLine();
                                                new AnimalService().UpdateNome(nome, chip);
                                                Console.WriteLine("### Atualização realizada com sucesso! ###");
                                                PressioneParaProsseguir();
                                                #endregion
                                                break;
                                            default:
                                                Console.WriteLine("Erro de swicht!!");
                                                break;
                                        }
                                    }
                                    #endregion
                                    break;
                                case 3:
                                    #region Atualiza Registro Adocao
                                    Console.Clear();
                                    CabecalhoONG();
                                    Console.WriteLine("Informe o numero de Registro que deseja alterar: ");
                                    int numRegistro = int.Parse(Console.ReadLine());
                                    if (new AdocaoService().Exist(numRegistro) == true)
                                    {
                                        Console.WriteLine("O que deseja alterar do registro de adocoes: \n[1]Adotante (Pessoa) \n[2]Adotado (Animal)");
                                        int op = int.Parse(Console.ReadLine());
                                        while (op < 1 || op > 2)
                                        {
                                            Console.WriteLine("Opção inválida, informe novamente: ");
                                            op = int.Parse(Console.ReadLine());
                                        }
                                        switch (op)
                                        {
                                            case 1:
                                                Console.WriteLine("Insira o CPF do novo Adotante: ");
                                                string novocpf = Console.ReadLine();
                                                if (new PessoaService().Exists(novocpf) == false)
                                                {
                                                    Console.WriteLine("Cpf nao cadastrado em nosso banco de dados, cadastre-o antes lá no meno de registro -> clientes!");
                                                    PressioneParaProsseguir();
                                                }
                                                else
                                                {
                                                    new AdocaoService().UpdateAdotante(novocpf, numRegistro);
                                                    Console.WriteLine("### Registro Atualizado com sucesso! ###");
                                                    PressioneParaProsseguir();
                                                }
                                                break;
                                            case 2:
                                                Console.WriteLine("Insira o CHIP do novo Adotado: ");
                                                int novochip = int.Parse(Console.ReadLine());
                                                if (new AnimalService().Exists(novochip) == false)
                                                {
                                                    Console.WriteLine("CHIP nao cadastrado em nosso banco de dados, cadastre-o antes lá no meno de registro -> Animais!");
                                                    PressioneParaProsseguir();
                                                }
                                                else
                                                {
                                                    new AdocaoService().UpdateAdotado(novochip, numRegistro);
                                                    Console.WriteLine("### Registro Atualizado com sucesso! ###");
                                                    PressioneParaProsseguir();
                                                }                                              
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Registro de adocao nao cadastrado em nosso banco de dados!!");
                                        Program.PressioneParaProsseguir();
                                    }
                                    #endregion
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida informada");
                                    break;
                            }
                        } while (!volta2);
                        break;
                    case 3:
                        bool volta3 = false;
                        do
                        {
                            Console.Clear();
                            CabecalhoONG();
                            Console.WriteLine("O que voce deseja Consultar: \n[0]Voltar\n[1]Pessoa (cliente) \n[2]Animal \n[3]Adocoes ");
                            int op3 = int.Parse(Console.ReadLine());
                            while (op3 < 0 || op3 > 3)
                            {
                                Console.WriteLine("Valor inválido informado, tente novamente: ");
                                op3 = int.Parse(Console.ReadLine());
                            }
                            switch (op3)
                            {
                                case 0:
                                    volta3 = true;
                                    break;
                                case 1:
                                    #region Select geral Tabela Pessoas
                                    Console.Clear();
                                    CabecalhoONG();
                                    Console.WriteLine("Buscando registros...");
                                    Thread.Sleep(1000);
                                    if (new PessoaService().SelectAll().Count == 0)
                                    {
                                        Console.WriteLine("Não possuem pessoas cadastradas em nosso sistema até o momento!!");
                                        PressioneParaProsseguir();
                                    }
                                    else
                                    {
                                        new PessoaService().SelectAll().ForEach(x => Console.WriteLine(x));
                                        Console.WriteLine("");
                                        PressioneParaProsseguir();
                                    }
                                    #endregion
                                    break;
                                case 2:
                                    #region Select Tabela Animal
                                    Console.Clear();
                                    CabecalhoONG();
                                    Console.WriteLine("Buscando registros...");
                                    Thread.Sleep(1000);
                                    new AnimalService().SelecAll().ForEach(x => Console.WriteLine(x));
                                    Console.WriteLine("");
                                    PressioneParaProsseguir();
                                    #endregion
                                    break;
                                case 3:
                                    #region Select Tabela RegistroAdocao
                                    Console.Clear();
                                    CabecalhoONG();
                                    Console.WriteLine("Buscando registros...");
                                    Thread.Sleep(1000);
                                    new AdocaoService().SelectAll().ForEach(x => Console.WriteLine(x));
                                    Console.WriteLine("");
                                    PressioneParaProsseguir();
                                    #endregion
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida informada");
                                    break;
                            }
                        } while (!volta3);
                        break;
                    default:
                        Console.WriteLine("Opção inválida informada");
                        break;
                }
            } while (true);
        }
        public static void PressioneParaProsseguir()
        {
            Console.WriteLine("Pressione enter para prosseguir...");
            Console.ReadKey();
        }
        public static void CabecalhoONG()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                  ONG - Paraíso dos Animais");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
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
    }
}

