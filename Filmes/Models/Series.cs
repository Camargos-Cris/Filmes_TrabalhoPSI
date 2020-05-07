using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime Data_lancamento { get; set; }
        public int Quantidade_temp { get; set; }
        public string Genero { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Avaliacao { get; set; }
        public string Autor { get; set; }
        public string Classificacao { get; set; }
        public string Descricao { get; set; }
        public decimal Num_votos { get; set; }
        [Range(0, 5.00)]
        public decimal Nota { get; set; }
    }
}
