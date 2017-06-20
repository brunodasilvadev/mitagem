using ConsumindoAPI.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ConsumindoAPI.EntityConfig
{
    public class ClubeConfig : EntityTypeConfiguration<Clube>
    {
        public ClubeConfig()
        {
            HasKey(c => c.id);

            ToTable("Clube");
        }
    }
}