﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalifornianHealthMonolithic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CHEntities : DbContext
    {
        public CHEntities()
            : base("name=CHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Consultant> Consultants { get; set; }
        public virtual DbSet<ConsultantCalendar> ConsultantCalendars { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
    }
}
