
using EBook.Entities.Abstract;
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
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-IDCILMAT;Database=VirtualCourse;Integrated Security=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Context> Contexts { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Cosulants> Consulants { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Remak> Remaks { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<StudentQuestion> StudentQuestions { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Audio> Audios { get; set; }
        public DbSet<Picture> Pictures { get; set; }

    }
}
