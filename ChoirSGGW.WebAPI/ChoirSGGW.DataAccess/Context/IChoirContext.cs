using ChoirSGGW.Entities.Models;
using ChoirSGGW.Entities.Models.Types;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace ChoirSGGW.DataAccess.Context
{
    public interface IChoirContext : IDisposable
    {
        DbSet<ClotheTypes> ClotheType { get; set; }
        DbSet<Concert> Concerts { get; set; }
        DbSet<Photo> Photos { get; set; }
        DbSet<Repertoire> Repertoire { get; set; }
        DbSet<Sample> Sample { get; set; }
        DbSet<SongNote> SongNote { get; set; }
        DbSet<SongsTypes> SongsTypes { get; set; }
        DbSet<Topicality> Topicality { get; set; }
        DbSet<TopicalityType> TopicalityType { get; set; }
        DbSet<UserTypes> UserTypes { get; set; }

        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        DbEntityEntry Entry(object entity);
    }
}
