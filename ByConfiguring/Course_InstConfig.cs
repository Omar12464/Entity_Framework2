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
    internal class Course_InstConfig : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> CI)
        {


            CI.HasNoKey();
            CI.Property(ci => ci.Evaluate).IsRequired();

        }
    }
}
