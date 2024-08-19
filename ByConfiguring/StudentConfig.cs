using Entity_Framework2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Configurations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(s => s.Id);
            S.Property(s => s.Id).UseIdentityColumn(20, 20);
            S.Property(s => s.Fname).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            S.Property(s => s.LName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            S.Property(s => s.Address).IsRequired().HasDefaultValue("Cairo");
        }
    }
}
