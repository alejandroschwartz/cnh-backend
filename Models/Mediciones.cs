using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiCNH.Models
{
    public class Mediciones
    {
        [Key]
        public long MedicionId { get; set; }

        public double Medicion { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string MedicionDescripcion { get; set; }


        public int PiezaId { get; set; }
        [JsonIgnore]
        public Pieza Pieza { get; set; }
    }
}
