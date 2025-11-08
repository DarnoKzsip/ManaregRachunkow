using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerRachunkow.Data.Models.ModelConfiguration;

public class ApplicationUserConfiguration: IEntityTypeConfiguration<ApplicationUser> 
{
    public void Configure(EntityTypeBuilder<ApplicationUser> entity)
    {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.UserName).IsRequired();
        entity.Property(e => e.Email).IsRequired();
        entity.Property(e => e.PasswordHash).IsRequired();
        entity.Property(e => e.IdPaid).IsRequired();
    }
}
