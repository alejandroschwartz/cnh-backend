using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCNH.Models
{
    public class Pieza
    {
        [Key]
        public int PiezaId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PiezaNombre { get; set; }

        public double PiezaMedida { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string PiezaDescripcion { get; set; }

        public ICollection<Mediciones> Mediciones { get; set; } 
    }
}
