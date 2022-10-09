using System;
using System.Collections.Generic;
using OngAdocoes2._0.Model;
using OngAdocoes2._0.Repository;

namespace OngAdocoes2._0.Service
{
    public class PessoaService
    {
        private IPessoaRepository _pessoaRepository;
        public PessoaService()
        {
            _pessoaRepository = new PessoaRepository();
        }
        public Pessoa CadastroPessoa() 
        {
            return _pessoaRepository.CadastroPessoa();
        } 
        public bool Insert(Pessoa pessoa) 
        {
            return _pessoaRepository.Insert(pessoa);
        }
        public bool Exists(string cpf) 
        {
            return _pessoaRepository.Exists(cpf);
        }
        public void UpdateNome(string nome, string cpf) 
        {
            _pessoaRepository.UpdateNome(nome, cpf);
        }
        public void UpdateTelefone(string telefone, string cpf) 
        {
            _pessoaRepository.UpdateTelefone(telefone, cpf);    
        }
        public void UpdateSexo(string sexo, string cpf)
        {
            _pessoaRepository.UpdateSexo(sexo, cpf);
        }
        public void UpdateEndereco(string logradouro, string bairro, string cidade, string siglaEstado, string numero, string cpf)
        {
            _pessoaRepository.UpdateEndereco(logradouro, bairro, cidade, siglaEstado, numero, cpf);
        }
        public List<Pessoa> SelectAll()
        {
            return _pessoaRepository.SelectAll();   
        }
    }
}
