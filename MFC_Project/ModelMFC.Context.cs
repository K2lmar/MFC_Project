﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFC_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MFC_ProjectEntities : DbContext
    {
        public MFC_ProjectEntities()
            : base("name=MFC_ProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AvailableServicesSet> AvailableServicesSet { get; set; }
        public virtual DbSet<ClientsSet> ClientsSet { get; set; }
        public virtual DbSet<ConsultationsSet> ConsultationsSet { get; set; }
        public virtual DbSet<EmployeesSet> EmployeesSet { get; set; }
        public virtual DbSet<ReportsSet> ReportsSet { get; set; }
        public virtual DbSet<ServicesSet> ServicesSet { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
