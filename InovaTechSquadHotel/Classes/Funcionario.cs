using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaTechSquadHotel.Classes
{
    internal class Funcionario
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public bool Ativo { get; set; }



        #endregion

        #region Construtores

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, string cPF, string email, string senha, string cargo, bool ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Email = email;
            Senha = senha;
            Cargo = cargo;
            Ativo = ativo;
        }

        #endregion

        #region Métodos

        public void RealizarLogin()
        {

        }
        #endregion
    }
}
