using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OngAdocoes2._0.Model;

namespace OngAdocoes2._0.Repository
{
    internal interface IAdocaoRepository
    {
        public Adocao CadastroAdocao();
        public bool Exist(int numeroRegistro);
        public void Insert(Adocao adocao);
        public List<Adocao> SelectAll();
        public void UpdateAdotante(string cpf, int numeroRegistro);
        public void UpdateAdotado(int chip, int numeroRegistro);
    }
}
