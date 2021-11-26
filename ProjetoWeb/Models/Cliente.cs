using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Models
{
    [Table("Clientes")]
    public class Cliente
    {

        [Display(Name = "Id")]
        [Column("Id")]
        int _id;

        [Display(Name = "Nome")]
        [Column("Nome")]
        string _nome;

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        int _telefone;

        [Display(Name = "Endereco")]
        [Column("Endereco")]
        string _endereco;

        [Display(Name = "CPF")]
        [Column("CPF")]
        int _cpf;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Telefone { get => _telefone; set => _telefone = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public int Cpf { get => _cpf; set => _cpf = value; }
    }
}
