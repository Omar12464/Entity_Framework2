//using Entity_FrameWork2.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Entity_FrameWork_1.Configurations
//{
//    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
//    {
//        public void Configure(EntityTypeBuilder<Department> E)
//        {
//            E.ToTable("Deapartment", "dbo");
//            E.HasKey(d => d.Id);
//            E.Property(d => d.Id).UseIdentityColumn(10, 10);
//            E.Property(d => d.Name).IsRequired().HasColumnName("DeptName");
//            E.Property(d => d.DateOfCreation).HasComputedColumnSql("GETDATE()");
//        }
//    }
//}
