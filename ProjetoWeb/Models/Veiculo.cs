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
        int _id;

        [Display(Name = "Numero da Placa")]
        [Column("NumeroPlaca")]
        string _numeroPlaca;

        [Display(Name = "Modelo")]
        [Column("Modelo")]
        string _modelo;

        [Display(Name = "Ano")]
        [Column("Ano")]
        int _ano;

        [Display(Name = "Valor")]
        [Column("Valor")]
        float _valor;

        [Display(Name = "Cliente")]
        int _clienteId;
        public Cliente Cliente { get; set; }

        public string Modelo { get => _modelo; set => _modelo = value; }
        public string NumeroPlaca { get => _numeroPlaca; set => _numeroPlaca = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public float Valor { get => _valor; set => _valor = value; }
        public int Id { get => _id; set => _id = value; }
        public int ClienteId { get => _clienteId; set => _clienteId = value; }
    }
}
