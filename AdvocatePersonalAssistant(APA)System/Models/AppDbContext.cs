using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvocatePersonalAssistantSystem.Models;

namespace AdvocatePersonalAssistantSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<CaseProfile> CaseProfiles { get; set; }

        public DbSet<AdvocatePersonalAssistantSystem.Models.Registration> Registration { get; set; }

        public DbSet<AdvocatePersonalAssistantSystem.Models.Login> Login { get; set; }

        public DbSet<AdvocatePersonalAssistantSystem.Models.CyberLaw> CyberLaw { get; set; }

        public DbSet<AdvocatePersonalAssistantSystem.Models.Message> Message { get; set; }

        public DbSet<AdvocatePersonalAssistantSystem.Models.Reminder1> Reminder1 { get; set; }
        //public DbSet<PropertyInfo> PropertyInfos { get; set; }
    }
}
