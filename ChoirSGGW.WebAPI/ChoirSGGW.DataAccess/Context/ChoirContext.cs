using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Models;
using ChoirSGGW.Entities.Models.Types;
using System.Threading;
using ChoirSGGW.Entities.Models.BasicModels.Interfaces;

namespace ChoirSGGW.DataAccess.Context
{
    public class ChoirContext : DbContext, IChoirContext
    {
        public ChoirContext() : base("name=ChoirSGGW_DB_ConnectionString")
        {
            Database.SetInitializer<ChoirContext>(new CreateDatabaseIfNotExists<ChoirContext>());
        }

        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Repertoire> Repertoire { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<SongNote> SongNote { get; set; }
        public DbSet<Topicality> Topicality { get; set; }

        //Types
        public DbSet<ClotheTypes> ClotheType { get; set; }
        public DbSet<SongsTypes> SongsTypes { get; set; }
        public DbSet<TopicalityType> TopicalityType { get; set; }
        public DbSet<UserTypes> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IBasicModel
                    && (x.State == System.Data.Entity.EntityState.Added
                        || x.State == System.Data.Entity.EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IBasicModel entity = entry.Entity as IBasicModel;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    //entity.UpdatedBy = identityName; //////TO DO !!!!
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }
}
