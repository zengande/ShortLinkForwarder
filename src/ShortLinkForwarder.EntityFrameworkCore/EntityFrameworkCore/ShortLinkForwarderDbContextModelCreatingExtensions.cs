using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShortLinkForwarder.Links;
using Volo.Abp;
using Volo.Abp.Users;

namespace ShortLinkForwarder.EntityFrameworkCore
{
    public static class ShortLinkForwarderDbContextModelCreatingExtensions
    {
        public static void ConfigureShortLinkForwarder(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ShortLinkForwarderConsts.DbTablePrefix + "YourEntities", ShortLinkForwarderConsts.DbSchema);

            //    //...
            //});

            builder.Entity<Link>(link =>
            {
                link.ToTable(ShortLinkForwarderConsts.DbTablePrefix + "Links", ShortLinkForwarderConsts.DbSchema);
                link.HasKey(x => x.Id);
                link.Property(x => x.OriginUrl)
                    .HasMaxLength(256)
                    .IsRequired(true);
                link.Property(x => x.Token)
                    .HasMaxLength(32)
                    .IsRequired(true);
                link.Property(x => x.Enabled)
                    .HasDefaultValue(true)
                    .IsRequired(true);
                link.Property(x => x.UpdateTimeUtc)
                    .IsRequired(true);
                link.Property(x => x.ExpirationTimeUtc)
                    .IsRequired(true);
                link.Property(x => x.Remarks);

                link.Ignore(x => x.ExtraProperties);
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser : class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}