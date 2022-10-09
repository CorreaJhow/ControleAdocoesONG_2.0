using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        } //ok
        public bool Insert(Pessoa pessoa)
        {
            return _pessoaRepository.Insert(pessoa);
        }



    }
}
