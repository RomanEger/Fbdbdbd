﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class user4_upEntities : DbContext
    {
        public user4_upEntities()
            : base("name=user4_upEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cartridzhi> Cartridzhi { get; set; }
        public virtual DbSet<Printer> Printer { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }
    }
}
