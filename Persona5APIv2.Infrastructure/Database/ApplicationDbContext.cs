using Microsoft.EntityFrameworkCore;
using Persona5APIv2.Core.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persona5APIv2.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public virtual DbSet<PersonaEntity> Personas { get; set; }
        public virtual DbSet<SkillsEntity> PersonaSkills { get; set; }
        public virtual DbSet<PersonaStatsEntity> PersonaStats { get; set; }
        public virtual DbSet<SkillCostEntity> SkillCosts { get; set; }
        public virtual DbSet<ElementsEntity> PersonaElements { get; set; }
    }
}
