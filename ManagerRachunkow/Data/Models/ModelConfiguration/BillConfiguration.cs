using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerRachunkow.Data.Models.ModelConfiguration;

public class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> entity)
    {
        entity.HasKey(e=>e.Id);
        entity.Property(e=>e.Name).IsRequired();
        entity.HasOne<ApplicationUser>(a => a.User).WithMany(b => b.Bills).HasForeignKey(b => b.UserId);

    }
}
