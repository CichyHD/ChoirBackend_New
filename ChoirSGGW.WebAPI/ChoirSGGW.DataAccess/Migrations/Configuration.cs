namespace ChoirSGGW.DataAccess.Migrations
{
    using ChoirSGGW.Entities.Models.Types;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChoirSGGW.DataAccess.Context.ChoirContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "ChoirSGGW.DataAccess.Context.ChoirContext";
        }

        protected override void Seed(ChoirSGGW.DataAccess.Context.ChoirContext context)
        {
            context.ClotheType.AddOrUpdate(
                clothe => clothe.ClotheType,
                new ClotheTypes("Galowy"),
                new ClotheTypes("Dowolny"));

            context.SongsTypes.AddOrUpdate(
                songType => songType.SongType,
                new SongsTypes("Kolêda"),
                new SongsTypes("Pieœñ"));
        }
    }
}
