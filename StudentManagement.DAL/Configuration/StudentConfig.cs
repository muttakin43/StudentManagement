using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAL.Configuration
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public object IsActive { get; private set; }

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(e => e.StudentId);
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.RollNumber)
                .IsRequired()
                .HasDefaultValue(0);
            builder.HasIndex(e => e.RollNumber)
                .IsUnique();
            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(e => e.Email)
                .IsUnique();
           builder.Property(e => e.IsActive)
                .HasDefaultValue(true);


        }
    }
}
