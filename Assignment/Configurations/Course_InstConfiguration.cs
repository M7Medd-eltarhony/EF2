using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configurations
{
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(C => new
            {
                C.inst_ID,
                C.Course_ID
            });
            builder.Property(C => C.evaluate)
                .IsRequired(true)
                .HasColumnName("Evaluation_Score")
                .HasMaxLength(100);
        }
    }
}
