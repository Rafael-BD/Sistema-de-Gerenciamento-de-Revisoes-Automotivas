using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Display(Name = "ID")]
        [Column("ID")]
        private int _id;

        [Display(Name = "Numero da Placa")]
        [Column("NumeroPlaca")][Required]
        private string _numeroPlaca;

        [Display(Name = "Modelo")]
        [Column("Modelo")][Required]
        private string _modelo;

        [Display(Name = "Ano")]
        [Column("Ano")]
        private int _ano;

        [Display(Name = "Valor")]
        [Column("Valor")]
        private float _valor;

        [Display(Name = "Cliente")]
        private int _clienteId;
        private Cliente _cliente;

        public string Modelo { get => _modelo; set => _modelo = value; }
        public string NumeroPlaca { get => _numeroPlaca; set => _numeroPlaca = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public float Valor { get => _valor; set => _valor = value; }
        public int Id { get => _id; set => _id = value; }
        public int ClienteId { get => _clienteId; set => _clienteId = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
    }
}
