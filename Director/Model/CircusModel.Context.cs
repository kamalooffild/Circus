﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Director.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class circusKAMALOV326Entities : DbContext
    {
        public circusKAMALOV326Entities()
            : base("name=circusKAMALOV326Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Cell> Cell { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Performance> Performance { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Props> Props { get; set; }
        public virtual DbSet<PropsEmployee> PropsEmployee { get; set; }
        public virtual DbSet<SaleTicket> SaleTicket { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TimeTablePerformance> TimeTablePerformance { get; set; }
        public virtual DbSet<TypeAnimal> TypeAnimal { get; set; }
        public virtual DbSet<TypeProps> TypeProps { get; set; }
    }
}
