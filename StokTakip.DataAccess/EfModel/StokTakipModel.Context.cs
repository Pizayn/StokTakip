﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip.DataAccess.EfModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StokTakipContext : DbContext
    {
        public StokTakipContext()
            : base("name=StokTakipContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Atik> Atik { get; set; }
        public virtual DbSet<Bolum> Bolum { get; set; }
        public virtual DbSet<Kisi> Kisi { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<Yonetici> Yonetici { get; set; }
        public virtual DbSet<Zimmet> Zimmet { get; set; }
    }
}