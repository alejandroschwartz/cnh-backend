using ApiCNH.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCNH.Context
{
    public class MedicionesContext: DbContext
    {
        public MedicionesContext(DbContextOptions<MedicionesContext> options): base(options)
        {

        }

        public DbSet<Pieza> Piezas { get; set; }
        public DbSet<Mediciones> Mediciones { get; set; }

        // Para PRECARGAR o SEMBRAR la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Para la TABLA PIEZAS
            modelBuilder.Entity<Pieza>().HasData(
                new Pieza { PiezaId = 1, PiezaNombre = "Freno disco 140mm", PiezaMedida = 140, PiezaDescripcion = "Freno descripcion 140mm" },
                new Pieza { PiezaId = 2, PiezaNombre = "Freno disco 150mm", PiezaMedida = 150, PiezaDescripcion = "Freno descripcion 150mm" },
                new Pieza { PiezaId = 3, PiezaNombre = "Freno disco 160mm", PiezaMedida = 160, PiezaDescripcion = "Freno descripcion 160mm" },
                new Pieza { PiezaId = 4, PiezaNombre = "Freno disco 170mm", PiezaMedida = 170, PiezaDescripcion = "Freno descripcion 170mm" }
            );

            // Para la TABLA MEDICIONES
            modelBuilder.Entity<Mediciones>().HasData(
                new Mediciones() { MedicionId = 1, PiezaId = 1, Medicion = 140.5, MedicionDescripcion = "Descripcion 1" },
                new Mediciones() { MedicionId = 2, PiezaId = 1, Medicion = 140.3, MedicionDescripcion = "Descripcion 2" },
                new Mediciones() { MedicionId = 3, PiezaId = 1, Medicion = 140.1, MedicionDescripcion = "Descripcion 3" },
                new Mediciones() { MedicionId = 4, PiezaId = 1, Medicion = 140.3, MedicionDescripcion = "Descripcion 4" },
                new Mediciones() { MedicionId = 5, PiezaId = 1, Medicion = 139.6, MedicionDescripcion = "Descripcion 5" },
                new Mediciones() { MedicionId = 6, PiezaId = 1, Medicion = 140.2, MedicionDescripcion = "Descripcion 6" },
                new Mediciones() { MedicionId = 7, PiezaId = 1, Medicion = 140.1, MedicionDescripcion = "Descripcion 7" },
                new Mediciones() { MedicionId = 8, PiezaId = 1, Medicion = 139.8, MedicionDescripcion = "Descripcion 8" },
                new Mediciones() { MedicionId = 9, PiezaId = 1, Medicion = 139.9, MedicionDescripcion = "Descripcion 9" },
                new Mediciones() { MedicionId = 10, PiezaId = 1, Medicion = 140.1, MedicionDescripcion = "Descripcion 10" },

                new Mediciones() { MedicionId = 11, PiezaId = 2, Medicion = 150.4, MedicionDescripcion = "Descripcion 11" },
                new Mediciones() { MedicionId = 12, PiezaId = 2, Medicion = 150.5, MedicionDescripcion = "Descripcion 12" },
                new Mediciones() { MedicionId = 13, PiezaId = 2, Medicion = 150.3, MedicionDescripcion = "Descripcion 13" },
                new Mediciones() { MedicionId = 14, PiezaId = 2, Medicion = 150.1, MedicionDescripcion = "Descripcion 14" },
                new Mediciones() { MedicionId = 15, PiezaId = 2, Medicion = 150.3, MedicionDescripcion = "Descripcion 15" },
                new Mediciones() { MedicionId = 16, PiezaId = 2, Medicion = 149.6, MedicionDescripcion = "Descripcion 16" },
                new Mediciones() { MedicionId = 17, PiezaId = 2, Medicion = 150.2, MedicionDescripcion = "Descripcion 17" },
                new Mediciones() { MedicionId = 18, PiezaId = 2, Medicion = 150.1, MedicionDescripcion = "Descripcion 18" },
                new Mediciones() { MedicionId = 19, PiezaId = 2, Medicion = 149.8, MedicionDescripcion = "Descripcion 19" },
                new Mediciones() { MedicionId = 20, PiezaId = 2, Medicion = 149.9, MedicionDescripcion = "Descripcion 20" },

                new Mediciones() { MedicionId = 21, PiezaId = 3, Medicion = 160.1, MedicionDescripcion = "Descripcion 21" },
                new Mediciones() { MedicionId = 22, PiezaId = 3, Medicion = 160.4, MedicionDescripcion = "Descripcion 22" },
                new Mediciones() { MedicionId = 23, PiezaId = 3, Medicion = 160.5, MedicionDescripcion = "Descripcion 23" },
                new Mediciones() { MedicionId = 24, PiezaId = 3, Medicion = 160.3, MedicionDescripcion = "Descripcion 24" },
                new Mediciones() { MedicionId = 25, PiezaId = 3, Medicion = 160.1, MedicionDescripcion = "Descripcion 25" },
                new Mediciones() { MedicionId = 26, PiezaId = 3, Medicion = 160.3, MedicionDescripcion = "Descripcion 26" },
                new Mediciones() { MedicionId = 27, PiezaId = 3, Medicion = 159.6, MedicionDescripcion = "Descripcion 27" },
                new Mediciones() { MedicionId = 28, PiezaId = 3, Medicion = 160.2, MedicionDescripcion = "Descripcion 28" },
                new Mediciones() { MedicionId = 29, PiezaId = 3, Medicion = 160.1, MedicionDescripcion = "Descripcion 29" },
                new Mediciones() { MedicionId = 30, PiezaId = 3, Medicion = 159.8, MedicionDescripcion = "Descripcion 30" },

                new Mediciones() { MedicionId = 31, PiezaId = 4, Medicion = 170.1, MedicionDescripcion = "Descripcion 31" },
                new Mediciones() { MedicionId = 32, PiezaId = 4, Medicion = 170.4, MedicionDescripcion = "Descripcion 32" },
                new Mediciones() { MedicionId = 33, PiezaId = 4, Medicion = 170.5, MedicionDescripcion = "Descripcion 33" },
                new Mediciones() { MedicionId = 34, PiezaId = 4, Medicion = 170.3, MedicionDescripcion = "Descripcion 34" },
                new Mediciones() { MedicionId = 35, PiezaId = 4, Medicion = 170.1, MedicionDescripcion = "Descripcion 35" },
                new Mediciones() { MedicionId = 36, PiezaId = 4, Medicion = 170.3, MedicionDescripcion = "Descripcion 36" },
                new Mediciones() { MedicionId = 37, PiezaId = 4, Medicion = 169.6, MedicionDescripcion = "Descripcion 37" },
                new Mediciones() { MedicionId = 38, PiezaId = 4, Medicion = 170.2, MedicionDescripcion = "Descripcion 38" },
                new Mediciones() { MedicionId = 39, PiezaId = 4, Medicion = 170.1, MedicionDescripcion = "Descripcion 39" },
                new Mediciones() { MedicionId = 40, PiezaId = 4, Medicion = 169.8, MedicionDescripcion = "Descripcion 40" }
            );
        }
    }
}
