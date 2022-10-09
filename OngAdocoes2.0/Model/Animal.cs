using System;
using System.Linq;


namespace OngAdocoes2._0.Model
{
    internal class Animal
    {
        #region Strings conexao
        public readonly static string EXIST = "select CHIP from Animal where CHIP = @chip;";
        public readonly static string INSERT = "INSERT INTO Animal (CHIP, Familia, Raca, Sexo, Nome) values (@chip, @familia, @raca, @sexo, @nome);";
        public readonly static string SELECT = "Select CHIP, Familia, Raca, Sexo, Nome from Animal;";
        public readonly static string DELETE = "Delete from Animal where CHIP = @chip;";
        public readonly static string UPDATEFAMILIA = "update Animal set Familia = @familia where CHIP = @chip";
        public readonly static string UPDATERACA = "update Animal set Raca = @raca where CHIP = @chip;";
        public readonly static string UPDATESEXO = "update Animal set Sexo = @sexo where CHIP = @chip";
        public readonly static string UPDATENOME = "update Animal set Nome = @nome where CHIP = @chip;";
        #endregion

        #region Propriedades
        public int Chip { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }
        #endregion
        public Animal()
        {

        }
        public Animal(int chip, string familia, string raca, string sexo, string nome)
        {
            Chip = chip;
            Familia = familia;
            Raca = raca;
            Sexo = sexo;
            Nome = nome;
        }
        public Animal(int chip, string familia, string raca, string sexo)
        {
            Chip = chip;
            Familia = familia;
            Raca = raca;
            Sexo = sexo;
            Nome = "SemNome";
        }       
        public override string ToString()
        {
            return "\nNumero Identificação (CHIP): " + Chip +
                "\nNome do animal: " + Nome +" | Familia: " + Familia +
                "\nRaca: " + Raca +" | Sexo: " + Sexo;
        }
    }
}
