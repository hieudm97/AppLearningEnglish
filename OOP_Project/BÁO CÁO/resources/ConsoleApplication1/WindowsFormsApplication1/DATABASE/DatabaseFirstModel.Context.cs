﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.DATABASE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OOP_PROJECTEntities : DbContext
    {
        public OOP_PROJECTEntities()
            : base("name=OOP_PROJECTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Baihoc> Baihocs { get; set; }
        public virtual DbSet<Baitap> Baitaps { get; set; }
        public virtual DbSet<Cauhoi> Cauhois { get; set; }
        public virtual DbSet<Cautraloi> Cautralois { get; set; }
        public virtual DbSet<Chitietbaihoc> Chitietbaihocs { get; set; }
        public virtual DbSet<Chitietbaitap> Chitietbaitaps { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<Nhac> Nhacs { get; set; }
        public virtual DbSet<Noidung> Noidungs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tmp> Tmps { get; set; }
        public virtual DbSet<TMP2> TMP2 { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
    }
}
