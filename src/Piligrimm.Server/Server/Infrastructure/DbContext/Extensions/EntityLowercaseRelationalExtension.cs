using Microsoft.EntityFrameworkCore;

namespace Piligrimm.Server.Infrastructure.Extension
{
    public static class EntityLowercaseRelationalExtension
    {    
        public static void LowercaseRelationalPropertyNames(this ModelBuilder modelBuilder) 
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ToLowerInvariant());
                }
            }
        }
    }
}