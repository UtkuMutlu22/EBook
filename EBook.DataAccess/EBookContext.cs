
using EBook.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess
{
    public class EBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-IDCILMAT;Database=EBook;Integrated Security=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Constulant> Constulants { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
