using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    internal class Hospede
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        #endregion

        #region Construtores
        public Hospede()
        {

        }

        public Hospede(int id, string nome, string cPF, string email, DateTime dtNascimento, string telefone, string endereco)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Email = email;
            DtNascimento = dtNascimento;
            Telefone = telefone;
            Endereco = endereco;
        }
        #endregion

        #region Metodos


        #endregion
    }
}
