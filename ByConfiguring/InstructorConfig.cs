using Entity_FrameWork2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_1.Configurations
{
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(i => i.Id);
            I.Property(i => i.Name).IsRequired().HasMaxLength(80).HasAnnotation("MinLegth", 20);
            I.Property(i => i.Bonus).HasColumnType("money");
            I.Property(i => i.Salary).HasColumnType("int");

        }
    }
}
