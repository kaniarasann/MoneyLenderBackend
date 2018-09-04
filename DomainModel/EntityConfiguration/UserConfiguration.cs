using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MoneyLenderBackend.DomainModel.EntityConfiguration {
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        public void Configure (EntityTypeBuilder<User> builder) {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id).HasMaxLength (20).IsRequired();
            builder.Property(x=>x.Address).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.ContactNo).HasMaxLength(20).IsRequired();
            builder.Property(x=>x.DOB).IsRequired();
            builder.Property(x=>x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.Firstname).HasMaxLength(20).IsRequired();
            builder.Property(x=>x.Lastname).HasMaxLength(20).IsRequired();
            builder.HasOne<Login>(x=>x.Login).WithOne(x=>x.User).HasForeignKey<Login>(x=>x.UserId);
        }
    }
}