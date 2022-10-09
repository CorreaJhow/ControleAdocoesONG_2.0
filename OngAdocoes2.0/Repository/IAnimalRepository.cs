using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OngAdocoes2._0.Model;

namespace OngAdocoes2._0.Repository
{
    internal interface IAnimalRepository
    {
        public Animal CadastroAnimal();
        public void Insert(Animal animal);
        public void Delete(int chip);
        public void UpdateNome(string nome, int chip);
        public void UpdateRaca(string raca, int chip);
        public void UpdateSexo(string sexo, int chip); 
        public void UpdateFamilia(string familia, int chip);
        public List<Animal> SelecAll();
        public bool Exists(int chip);
    }
}
