namespace ModelLayer.Migrations
{
    using ModelLayer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelLayer.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ModelLayer.ModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var cities = new List<City>();
            cities.Add(new City { Name = "Pluto" });
            cities.Add(new City { Name = "Mars" });
            cities.Add(new City { Name = "Venus" });
            cities.Add(new City { Name = "Mercury" });
            cities.ForEach(c => context.Cities.Add(c));

            var levels = new List<Level>();
            levels.Add(new Level { Name = "2D" });
            levels.Add(new Level { Name = "3D" });
            levels.Add(new Level { Name = "4DX" });
            levels.Add(new Level { Name = "Velvet" });
            levels.ForEach(l => context.Levels.Add(l));

            var movies = new List<Movie>();
            movies.Add(new Movie { Title = "Jackass Presents: Bad Grandpa", WeekendRevenure = 32.1, GrossRevenue = 32.1, Recommended = false, Released = new DateTime(2017, 4, 18) });
            movies.Add(new Movie { Title = "Gravity", WeekendRevenure = 20.1, GrossRevenue = 200.0, Recommended = true, Released = new DateTime(2017, 3, 18) });
            movies.Add(new Movie { Title = "Captain Phillips", WeekendRevenure = 11.6, GrossRevenue = 69.9, Recommended = true, Released = new DateTime(2017, 2, 18) });
            movies.Add(new Movie { Title = "The Counselor", WeekendRevenure = 7.84, GrossRevenue = 7.84, Recommended = false, Released = new DateTime(2017, 1, 18) });
            movies.Add(new Movie { Title = "Cloudy with a Chance of Meatballs 1", WeekendRevenure = 6.28, GrossRevenue = 6.28, Recommended = false, Released = new DateTime(2017, 5, 18) });
            movies.Add(new Movie { Title = "Cloudy with a Chance of Meatballs 2", WeekendRevenure = 7.28, GrossRevenue = 7.28, Recommended = true, Released = new DateTime(2018, 5, 18) });
            movies.Add(new Movie { Title = "Cloudy with a Chance of Meatballs 3", WeekendRevenure = 8.28, GrossRevenue = 8.28, Recommended = true, Released = new DateTime(2019, 5, 18) });
            movies.ForEach(m => context.Movies.Add(m));

            var theaters = new List<Theater>();
            theaters.Add(new Theater { Name = "Theater 1", Capacity = 50, City = cities[0], Level = levels[0] });
            theaters.Add(new Theater { Name = "Theater 2", Capacity = 50, City = cities[1], Level = levels[1] });
            theaters.Add(new Theater { Name = "Theater 3", Capacity = 40, City = cities[2], Level = levels[2] });
            theaters.Add(new Theater { Name = "Theater 4", Capacity = 30, City = cities[3], Level = levels[3] });
            theaters.ForEach(t => context.Theaters.Add(t));

            var tickets = new List<Ticket>();
            tickets.Add(new Ticket { Name = "Tinky-Winky", Email = "tinky-winky@gmail.com", Payment = 1, Movie = movies[0], Theater = theaters[0] });
            tickets.Add(new Ticket { Name = "Dipsy", Email = "dipsy@gmail.com", Payment = 1, Movie = movies[1], Theater = theaters[1] });
            tickets.Add(new Ticket { Name = "Laa-Laa", Email = "laa-laa@gmail.com", Payment = 2, Movie = movies[2], Theater = theaters[2] });
            tickets.Add(new Ticket { Name = "Po", Email = "po@gmail.com", Payment = 3, Movie = movies[3], Theater = theaters[3] });
            tickets.ForEach(t => context.Tickets.Add(t));

            var users = new List<User>();
            users.Add(new User { Email = "admin@geekseat.com", Password = "asd123" });
            users.ForEach(u => context.Users.Add(u));

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
