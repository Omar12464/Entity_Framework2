using Entity_Framework2.Models;
using Entity_FrameWork2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework2.Context
{
    internal class ITIdbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-6FHT0HLA ; Database = ITIC42 ; Trusted_Connection = True ; Encrypt=False ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region By Configuring
            //modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            //modelBuilder.ApplyConfiguration(new CourseConfig());
            //modelBuilder.ApplyConfiguration(new Course_InstConfig());
            //modelBuilder.ApplyConfiguration(new StudentConfig());
            //modelBuilder.ApplyConfiguration(new InstructorConfig());
            //modelBuilder.ApplyConfiguration(new StudCrsConfig());
            //modelBuilder.ApplyConfiguration(new TopicConfig()); 
            #endregion

            #region Fluent APIs
            modelBuilder.Entity<Student>(S =>
            {
                S.HasKey(s => s.Id);
                S.Property(s => s.Id).UseIdentityColumn(20, 20);
                S.Property(s => s.Fname).IsRequired().HasMaxLength(100).HasColumnType("varchar");
                S.Property(s => s.LName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
                S.Property(s => s.Address).IsRequired().HasDefaultValue("Cairo");
            });

            modelBuilder.Entity<Topic>(T =>
            {
                T.HasKey(t => t.Id);
                T.Property(t => t.Name).IsRequired();
            });
            modelBuilder.Entity<Course>(C =>
            {
                C.HasKey(c => c.Id);
            });
            modelBuilder.Entity<Instructor>(I =>
            {
                I.HasKey(i => i.Id);
                I.Property(i => i.Name).IsRequired().HasMaxLength(80).HasAnnotation("MinLegth", 20);
                I.Property(i => i.Bonus).HasColumnType("money");
            });
            modelBuilder.Entity<StudCourse>(SC =>
            {
                SC.HasNoKey();
                SC.Property(sc => sc.Grade).IsRequired();

            });
            modelBuilder.Entity<Course_Inst>(CI =>
            {
                CI.HasNoKey();
                CI.Property(ci => ci.Evaluate).IsRequired();
            });

            modelBuilder.Entity<Department>(E =>
            {
                E.ToTable("Deapartment", "dbo");
                E.HasKey(d => d.Id);
                E.Property(d => d.Id).UseIdentityColumn(10, 10);
                E.Property(d => d.Name).IsRequired().HasColumnName("DeptName");
                E.Property(d => d.DateOfCreation).HasComputedColumnSql("GETDATE()");
            });


            #endregion

        }


        #region By Convention&
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<StudCourse> StudCourse { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        #endregion

    }
}
