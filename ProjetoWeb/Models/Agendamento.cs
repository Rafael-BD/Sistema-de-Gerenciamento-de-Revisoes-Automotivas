using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Models
{
    [Table("Agendamento")]
    public class Agendamento
    {
        [Display(Name = "ID")]
        [Column("ID")]
        int _id;

        [Display(Name = "Data")]
        [Column("Data")]
        DateTime _date;

        [Display(Name = "Veiculo")]
        int _veiculoId;
        Veiculo _veiculo;


        public int Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public int VeiculoId { get => _veiculoId; set => _veiculoId = value; }
        public Veiculo Veiculo { get => _veiculo; set => _veiculo = value; }
    }
}
