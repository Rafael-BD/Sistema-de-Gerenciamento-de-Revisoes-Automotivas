using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Models
{
    [Table("RevisoesDeCarro")]
    public class Cliente
    {

        [Display(Name = "Id")]
        [Column("Id")]
        int _id;
        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }


        [Display(Name = "Nome")]
        [Column("Nome")]
        string _nome;
        public string Nome
        {
            get { return _nome; }

            set { _nome = value; }
        }

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        int _telefone;
        public int Telefone
        {
            get { return _telefone; }

            set { _telefone = value; }
        }


        [Display(Name = "Endereco")]
        [Column("Endereco")]
        string _endereco;
        public string Endereco
        {
            get { return _endereco; }

            set { _endereco = value; }
        }

        [Display(Name = "CPF")]
        [Column("CPF")]
        int _cpf;
        public int CPF
        {
            get { return _cpf; }

            set { _cpf = value; }
        }
    }
}
