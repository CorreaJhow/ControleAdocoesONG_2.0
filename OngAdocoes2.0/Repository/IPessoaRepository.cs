using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OngAdocoes2._0.Model;

namespace OngAdocoes2._0.Repository
{
    internal interface IPessoaRepository
    {
        public bool Exists(string cpf);
        public bool Insert(Pessoa pessoa);
        public void Delete(string cpf);
        public void SelectOne(string cpf);
        public void SelectAll(string cpf);
        public void UpdateNome(string nome,string cpf);
        public void UpdateTelefone(string telefone,string cpf);
        public void UpdateDataNascimento(DateTime DataNascimento,string cpf);
        public void UpdateEndereco(string logradouro, string bairro, string cidade, string siglaEstado, string numero);
        public Pessoa CadastroPessoa();
    }
}
