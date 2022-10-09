using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngAdocoes2._0.Model
{
    internal class Adocao
    {
        #region Strings conexão
        public readonly static string EXIST = "select NumeroRegistro from RegistroAdocoes where NumeroRegistro = @numeroRegistro";
        public readonly static string INSERT = "insert into RegistroAdocoes NumeroRegistro, Adotante, Adotado values (@numeroRegistro, @adotante, @adotado);";
        public readonly static string SELECTALL = "select NumeroRegistro, Adotante, Adotado from RegistroAdocoes;";
        public readonly static string DELETE = "delete from RegistroAdocoes where NumeroRegistro = @numeroregistro";
        public readonly static string UPDATEADOTANTE = "update set Adotante = @adotante from RegistroAdocoes where NumeroRegistro = @numeroregistro";
        public readonly static string DELETEADOTADO = "update set Adotado = @adotado from RegistroAdocoes where NumeroRegistro = @numeroregistro";
        #endregion
        public Animal Adotado { get; set; }
        public Pessoa Adotante { get; set; }
        public int NumeroRegistro { get; set; }

        public override string ToString()
        {
            return "Numero de Registro: " + NumeroRegistro +
                "\nAdotante: " + Adotante + " | Adotado: " + Adotado;
        }
    }
}
