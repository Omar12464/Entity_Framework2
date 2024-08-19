using Entity_FrameWork2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork2.Configurations
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(c => c.Id);
            C.Property(c => c.Name).IsRequired().HasColumnType("varchar").HasAnnotation("MinLength", 20);
            C.Property(c => c.Duration).IsRequired();

        }
    }
}
