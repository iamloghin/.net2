using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using StudiuDeCaz.Models;

namespace StudiuDeCaz
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelSelfRefrences : DbContext
    {
        public ModelSelfRefrences()
            : base("Data Source=(localdb)\\ProjectsV13;Initial Catalog=STUDIU;Integrated Security=True")
        {
        }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        
        public virtual DbSet<SelfReference> SelfReferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);
        }
    }
}