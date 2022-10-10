
namespace OngAdocoes2._0.Model
{
    internal class Adocao
    {
        #region Strings conexão
        public readonly static string EXIST = "select NumeroRegistro from RegistroAdocao where NumeroRegistro = @numeroRegistro";
        public readonly static string INSERT = "insert into RegistroAdocao (NumeroRegistro, Adotante, Adotado) values (@numeroRegistro, @adotante, @adotado);";
        public readonly static string SELECTALL = "select * from RegistroAdocao;";
        public readonly static string DELETE = "delete from RegistroAdocao where NumeroRegistro = @numeroregistro";
        public readonly static string UPDATEADOTANTE = "update RegistroAdocao set Adotante = @adotante from RegistroAdocao where NumeroRegistro = @numeroregistro";
        public readonly static string UPDATEADOTADO = "update RegistroAdocao set Adotado = @adotado from RegistroAdocao where NumeroRegistro = @numeroregistro";
        #endregion
        public int Adotado { get; set; }
        public string Adotante { get; set; }
        public int NumeroRegistro { get; set; }
        public Adocao()
        {

        }
        public Adocao(int adotado, string adotante, int numeroRegistro)
        {
            Adotado = adotado;
            Adotante = adotante;
            NumeroRegistro = numeroRegistro;
        }
        public override string ToString()
        {
            return "Numero de Registro: " + NumeroRegistro +
                "\nCPF do Adotante: " + Adotante + " | CHIP do animal adotado: " + Adotado;
        }
    }
}
