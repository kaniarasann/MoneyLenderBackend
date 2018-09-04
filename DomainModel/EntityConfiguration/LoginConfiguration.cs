using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyLenderBackend.DomainModel.EntityConfiguration {
    public class LoginConfiguration : IEntityTypeConfiguration<Login> {
        public void Configure (EntityTypeBuilder<Login> builder) {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id).HasMaxLength (20);
            builder.Property (x => x.Username).HasMaxLength (20).IsRequired ();
            builder.Property (x => x.Password).HasMaxLength (20).IsRequired ();
            builder.Property (x => x.IsActive).HasDefaultValue (true).IsRequired ();
            builder.Property (x => x.InvalidAttempts).HasDefaultValue (0).IsRequired ();
        }
    }
}