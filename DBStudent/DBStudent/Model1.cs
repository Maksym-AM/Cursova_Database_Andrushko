using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DBStudent
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Issues_of_books> Issues_of_books { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_grade> Student_grade { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.title)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.author)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.genre)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Issues_of_books)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discipline>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Discipline>()
                .HasMany(e => e.Student_grade)
                .WithOptional(e => e.Discipline)
                .HasForeignKey(e => e.dsscipline_ID);

            modelBuilder.Entity<Group>()
                .Property(e => e.group_name)
                .IsFixedLength();

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Disciplines)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.surname)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.Place_of_birth)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.adress)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.sex)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.scholarship)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Issues_of_books)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Student_grade)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.surname)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.scientist_degree)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Disciplines)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
        }
    }
}
