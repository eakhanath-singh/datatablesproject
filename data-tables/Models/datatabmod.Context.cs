﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace data_tables.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class miniprojectsEntities : DbContext
    {
        public miniprojectsEntities()
            : base("name=miniprojectsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<sale> sales { get; set; }
        public virtual DbSet<product> products { get; set; }
    }
}
