﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MilkyApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MilkyAppDataBaseEntities : DbContext
    {
        public MilkyAppDataBaseEntities()
            : base("name=MilkyAppDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<biljeske> biljeske { get; set; }
        public virtual DbSet<dobavlja> dobavlja { get; set; }
        public virtual DbSet<dobavljaci> dobavljaci { get; set; }
        public virtual DbSet<korisnici> korisnici { get; set; }
        public virtual DbSet<kupci> kupci { get; set; }
        public virtual DbSet<mjerne_jedinice> mjerne_jedinice { get; set; }
        public virtual DbSet<narudzbe> narudzbe { get; set; }
        public virtual DbSet<proizvodi> proizvodi { get; set; }
        public virtual DbSet<proizvodi_na_narudzbi> proizvodi_na_narudzbi { get; set; }
        public virtual DbSet<racuni> racuni { get; set; }
        public virtual DbSet<sirovine> sirovine { get; set; }
        public virtual DbSet<zadaci> zadaci { get; set; }
    }
}
