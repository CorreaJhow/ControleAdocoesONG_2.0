using System;
using System.Xml;

namespace OngAdocoes2._0.Model
{
    public class Pessoa
    {
        #region Strings da classe
        public readonly static string EXIST = "select Nome, CPF from Pessoa where CPF = @cpf";
        public readonly static string SELECT = "Select Nome, CPF, Sexo, DataNascimento, Telefone, Logradouro, Bairro, Cidade, SiglaEstado, Numero from Pessoa";
        public readonly static string DELETE = "Delete from Pessoa where CPF = @cpf";
        public readonly static string INSERT = "INSERT INTO PESSOA (Nome, CPF, Sexo, DataNascimento, Telefone, Logradouro, Bairro, Cidade, SiglaEstado, Numero) " +
                                               "values (@nome, @cpf, @sexo, @dataNascimento, @telefone, @logradouro, @bairro, @cidade, @siglaEstado, @Numero);";
        public readonly static string UPDATENOME = "update Pessoa Set Nome = @nome where cpf = @cpf;";
        public readonly static string UPDATECPF = "update Pessoa Set CPF = @cpf where cpf = @cpf;";
        public readonly static string UPDATEDATANASCIMENTO = "update Pessoa Set Datanascimento = @datanascimento where cpf = @cpf;";
        public readonly static string UPDATETELEFONE = "update Pessoa Set Telefone = @telefone where cpf = @cpf;";
        public readonly static string UPDATESEXO = "update Pessoa Set Sexo = @sexo where cpf = @cpf;";
        public readonly static string UPDATEENDERECO = "update Pessoa Set Logradouro = @logradouro, Bairro = @bairro, Cidade = @cidade, SiglaEstado = @siglaestado, " +
                                                       "numero = @numero where cpf = @cpf;";
        #endregion

        #region Propriedades
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string SiglaEstado { get; set; }
        public string Numero { get; set; }
        #endregion
        public Pessoa()
        {

        }
        public Pessoa(string nome, string cPF, string sexo, DateTime dataNascimento, string telefone, string rua, string bairro, string cidade, string siglaEstado, string numero)
        {
            Nome = nome;
            CPF = cPF;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Logradouro = rua;
            Bairro = bairro;
            Cidade = cidade;
            SiglaEstado = siglaEstado;
            Numero = numero;
        }
        public override string ToString()
        {
            return
                "\nNome: " + Nome +" | Sexo: " + Sexo +" | Telefone: " + Telefone +
                "\nData de Nascimento: " + DataNascimento.ToShortDateString() +" | CPF: " + CPF +
                "\nCidade: " + Cidade +" | Estado: " + SiglaEstado +
                "\nBairro: " + Bairro +" | Numero: " + Numero;
        }
    }
}

