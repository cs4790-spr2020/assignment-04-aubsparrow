using BlabberApp.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlabberApp.DataStore
{
    public class BlabMap
    {
        public BlabMap(EntityTypeBuilder<Blab> entityBuilder)
        {
            entityBuilder.HasKey(t => t.UserID);
            entityBuilder.Property(t => t.DTTM).IsRequired();
            entityBuilder.Property(t => t.Message);
        }
    }
}