﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ePatient
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ePatientDBlocalEntities : DbContext
    {
        public ePatientDBlocalEntities()
            : base("name=ePatientDBlocalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Allergiens> Allergiens { get; set; }
        public virtual DbSet<Arzts> Arzts { get; set; }
        public virtual DbSet<Dokumentes> Dokumentes { get; set; }
        public virtual DbSet<Erkrankungens> Erkrankungens { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<Medikations> Medikations { get; set; }
        public virtual DbSet<Notfallaktions> Notfallaktions { get; set; }
        public virtual DbSet<Notfallkontakte> Notfallkontakte { get; set; }
        public virtual DbSet<Pat_Medi_Datas> Pat_Medi_Datas { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
    }
}
