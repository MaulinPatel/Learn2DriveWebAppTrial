namespace Car_Rental.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<instructor> instructors { get; set; }
        public virtual DbSet<my_lesson> my_lesson { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<appointment>()
                .Property(e => e.inst_name)
                .IsUnicode(false);

            modelBuilder.Entity<appointment>()
                .Property(e => e.inst_availibility)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.inst_name)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.inst_charge)
                .HasPrecision(4, 2);

            modelBuilder.Entity<instructor>()
                .Property(e => e.inst_speciality)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.inst_car)
                .IsUnicode(false);

            modelBuilder.Entity<instructor>()
                .Property(e => e.inst_gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<my_lesson>()
                .Property(e => e.user_name)
                .IsUnicode(false);
        }
    }
}
