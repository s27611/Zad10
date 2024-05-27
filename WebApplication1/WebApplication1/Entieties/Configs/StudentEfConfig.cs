using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entieties.Configs;

public class StudentEfConfig : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder
            .HasKey(x => x.Id)
            .HasName("Student_pk");
        
        builder
            .Property(x => x.Id)
            .ValueGeneratedNever();
        
        builder.Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(30);
        
        builder.Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(e => e.IndexNumber)
            .IsRequired()
            .HasMaxLength(15);
        
        builder.ToTable(nameof(Student));
        
        Student[] students =
        {
            new Student { Id = 1,FirstName = "Jan",LastName = "Kowalski", IndexNumber = 123},
            

        };

        builder.HasData(students);
    }
}