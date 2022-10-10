using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OngAdocoes2._0.Model;
using OngAdocoes2._0.Repository;

namespace OngAdocoes2._0.Service
{
    internal class AdocaoService
    {
        private readonly IAdocaoRepository _adocaoRepository;
        public AdocaoService()
        {
            _adocaoRepository = new AdocaoRepository();
        }
        public bool Exist(int numeroRegistro)
        {
            return _adocaoRepository.Exist(numeroRegistro);
        }
        public Adocao CadastroAdocao()
        {
            return _adocaoRepository.CadastroAdocao();
        }
        public void Insert(Adocao adocao)
        {
            _adocaoRepository.Insert(adocao);
        }
        public void UpdateAdotante(string cpf, int numeroRegistro)
        {
            _adocaoRepository.UpdateAdotante(cpf, numeroRegistro);
        }
        public void UpdateAdotado(int chip, int numeroRegistro)
        {
            _adocaoRepository.UpdateAdotado(chip, numeroRegistro);
        }
        public List<Adocao> SelectAll()
        {
            return _adocaoRepository.SelectAll();
        }

    }
}
