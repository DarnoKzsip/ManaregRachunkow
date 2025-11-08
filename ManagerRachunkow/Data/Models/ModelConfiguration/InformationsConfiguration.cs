using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerRachunkow.Data.Models.ModelConfiguration
{
    public class InformationsConfiguration: IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Content).IsRequired();
            entity.HasOne<ApplicationUser>(a=>a.User).WithMany(b=>b.Informations).HasForeignKey(b=>b.UserId);
        }
    }
}
