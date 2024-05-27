using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entieties.Configs;

public class StudentGroupEfConfig : IEntityTypeConfiguration<StudentGroup>
{
    public void Configure(EntityTypeBuilder<StudentGroup> builder)
    {
        builder
            .HasKey(x => new { x.IdGroup, x.IdStudent })
            .HasName("StudemtGroup_pk");

        builder
            .Property(x => x.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder
            .HasOne(x => x.Student)
            .WithMany(x => x.StudentGroups)
            .HasForeignKey(x => x.IdStudent)
            .HasConstraintName("StudentGroup_Student")
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(x => x.Group)
            .WithMany(x => x.StudentGroups)
            .HasForeignKey(x => x.IdGroup)
            .HasConstraintName("StudentGroup_Group")
            .OnDelete(DeleteBehavior.Restrict);

        builder.ToTable("Student_Group");


    }
}