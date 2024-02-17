using BirthdayList.Models;
using Microsoft.EntityFrameworkCore;

namespace BirthdayList.DatabaseContext
{
    /// <summary>
    ///Класс представляет собой контекст базы данных для работы с записями о днях рождения различных типов.
    /// </summary>
    public class BirthdayContext : DbContext
    {
        public DbSet<Birthday> birthdays { get; set; }
        public DbSet<FriendBirthday> friends { get; set; }
        public DbSet<EmployeeBirthday> employees { get; set; }
        public DbSet<AcquaintanceBirthday> acquaintances { get; set; }
        public BirthdayContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BirthdayList;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FriendBirthday>().HasData(
                new FriendBirthday { Id = 1, Name = "Alex", DateBirth = new DateTime(2000, 1, 1) },
                new FriendBirthday { Id = 2, Name = "Ivan", DateBirth = new DateTime(1978, 9, 7) },
                new FriendBirthday { Id = 3, Name = "Roma", DateBirth = new DateTime(2015, 10, 18) },
                new FriendBirthday { Id = 4, Name = "Yana", DateBirth = new DateTime(2001, 1, 11) }
                );

            modelBuilder.Entity<EmployeeBirthday>().HasData(
                new EmployeeBirthday { Id = 5, Name = "Anton", DateBirth = new DateTime(1980, 2, 19) },
                new EmployeeBirthday { Id = 6, Name = "Oleg", DateBirth = new DateTime(2005, 2, 2) }
                );

            modelBuilder.Entity<AcquaintanceBirthday>().HasData(
               new AcquaintanceBirthday { Id = 7, Name = "Dima", DateBirth = new DateTime(2008, 5, 8) },
               new AcquaintanceBirthday { Id = 8, Name = "Lena", DateBirth = new DateTime(1980, 2, 25) },
               new AcquaintanceBirthday { Id = 9, Name = "Nastya", DateBirth = new DateTime(1998, 12, 31) }
               );
        }
    }
}
