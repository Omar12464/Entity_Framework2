using Entity_Framework2.Inheritance;
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
                S.HasMany(s => s.studentcourse).WithOne(s => s.Student);
            });

            modelBuilder.Entity<Topic>(T =>
            {
                T.HasKey(t => t.Top_Id);
                T.Property(t => t.Name).IsRequired();
            });
            modelBuilder.Entity<Course>(C =>
            {
                C.HasKey(c => c.Id);
                C.HasMany(c=>c.coursestudent).WithOne(c => c.Course);
                C.HasMany(c=>c.CourseInstructor).WithOne(c => c.course);
            });
            //modelBuilder.Entity<Course>().HasOne(c => c.topics).WithMany(c => c.courses).HasForeignKey(c => c.TopicId);
            modelBuilder.Entity<Instructor>(I =>
            {
                I.HasKey(i => i.Id);
                I.Property(i => i.Name).IsRequired().HasMaxLength(80).HasAnnotation("MinLegth", 20);
                I.Property(i => i.Bonus).HasColumnType("money");
                I.HasMany(i=>i.InstructorCourse).WithOne(i=>i.Instructor);
            });
            modelBuilder.Entity<StudCourse>(SC =>
            {
                SC.HasKey(sc => new {sc.StudId,sc.crsId});

            });
            modelBuilder.Entity<Course_Inst>(CI =>
            {
                CI.HasKey(ci => new { ci.CrsId, ci.InstId });
            });

            modelBuilder.Entity<Department>(E =>
            {
                E.ToTable("Deapartment", "dbo");
                E.HasKey(d => d.Id);
                E.Property(d => d.Id).UseIdentityColumn(10, 10);
                E.Property(d => d.Name).IsRequired().HasColumnName("DeptName");
                E.Property(d => d.DateOfCreation).HasComputedColumnSql("GETDATE()");
                E.HasOne(d => d.Manager).WithOne(d => d.ManagedDepartment).HasForeignKey<Department>(d=>d.ManagerId);
                E.HasMany(d => d.Instructors).WithOne(I => I.Department).HasForeignKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<FullTime>().Property(F => F.Salary).HasColumnType("decimal(18,3)");
            modelBuilder.Entity<Parttime>().Property(P => P.HourRate).HasColumnType("decimal(18,3)");
            modelBuilder.Entity<FullTime>().HasBaseType<InstructorContainer>(); modelBuilder.Entity<Parttime>().HasBaseType<InstructorContainer>();


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
        public DbSet<FullTime> FullTime { get; set; }
        public DbSet<Parttime> PartTime { get; set; }

        #endregion

    }
}
