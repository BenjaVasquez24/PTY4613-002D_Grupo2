﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessSA.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProcessSAEntities : DbContext
    {
        public ProcessSAEntities()
            : base("name=ProcessSAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<FLUJO> FLUJO { get; set; }
        public DbSet<JERARQUIA> JERARQUIA { get; set; }
        public DbSet<ROL> ROL { get; set; }
        public DbSet<TAREA> TAREA { get; set; }
        public DbSet<TAREAS_TIPO> TAREAS_TIPO { get; set; }
        public DbSet<UNIDAD> UNIDAD { get; set; }
        public DbSet<USUARIOS> USUARIOS { get; set; }
    }
}
