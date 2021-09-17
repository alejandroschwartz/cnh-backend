using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCNH.Models
{
    public class Mediciones
    {
        [Key]
        public long Id { get; set; }

        public string Maquina { get; set; }

        public double Medicion { get; set; }

        public string Descripcion { get; set; }


        public Mediciones()
        {

        }

        public Mediciones(int id, string maquina, double medicion, string descripcion = "")
        {
            Id = id;
            Maquina = maquina;
            Medicion = medicion;
            Descripcion = descripcion;
        }
    }
}
