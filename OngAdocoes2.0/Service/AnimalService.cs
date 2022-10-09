using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OngAdocoes2._0.Model;
using OngAdocoes2._0.Repository;

namespace OngAdocoes2._0.Service
{
    internal class AnimalService
    {
        private IAnimalRepository _animalRepository;
        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }
        public Animal CadastroAnimal()
        {
            return _animalRepository.CadastroAnimal();
        }
        public void Insert(Animal animal)
        {
            _animalRepository.Insert(animal);
        }
        public bool Exists(int chip)
        {
            return _animalRepository.Exists(chip);
        }
        public void UpdateFamilia(string familia, int chip)
        {
            _animalRepository.UpdateFamilia(familia, chip);
        }
        public void UpdateRaca(string raca, int chip)
        {
            _animalRepository.UpdateRaca(raca, chip);
        }
        public void UpdateSexo(string sexo, int chip)
        {
            _animalRepository.UpdateSexo(sexo, chip);
        }
        public void UpdateNome(string nome, int chip)
        {
            _animalRepository.UpdateNome(nome, chip);
        }
        public List<Animal> SelecAll()
        {
            return _animalRepository.SelecAll();
        }
    }
}
