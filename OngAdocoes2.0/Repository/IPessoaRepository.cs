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
        public List<Pessoa> SelectAll();
        public void UpdateNome(string nome,string cpf);
        public void UpdateTelefone(string telefone,string cpf);
        public void UpdateEndereco(string logradouro, string bairro, string cidade, string siglaEstado, string numero, string cpf);
        public Pessoa CadastroPessoa();
        public void UpdateSexo(string sexo, string cpf);
    }
}
