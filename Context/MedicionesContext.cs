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

        public DbSet<Mediciones> Mediciones { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Mediciones>().HasData(
        //        new Mediciones() { Id = 1, Maquina = "Torno Siemens 1", Medicion = 140.5, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 2, Maquina = "Torno Siemens 1", Medicion = 140.3, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 3, Maquina = "Torno Siemens 1", Medicion = 140.1, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 4, Maquina = "Torno Siemens 1", Medicion = 140.3, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 5, Maquina = "Torno Siemens 1", Medicion = 139.6, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 6, Maquina = "Torno Siemens 1", Medicion = 140.2, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 7, Maquina = "Torno Siemens 1", Medicion = 140.1, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 8, Maquina = "Torno Siemens 1", Medicion = 139.8, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 9, Maquina = "Torno Siemens 1", Medicion = 139.9, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 10, Maquina = "Torno Siemens 1", Medicion = 140.1, Descripcion = "Descripcion" },
        //        new Mediciones() { Id = 11, Maquina = "Torno Siemens 1", Medicion = 140.4, Descripcion = "Descripcion" }
        //    );
        //}
    }
}
