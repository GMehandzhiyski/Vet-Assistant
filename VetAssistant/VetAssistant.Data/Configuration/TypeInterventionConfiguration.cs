using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class TypeInterventionConfiguration : IEntityTypeConfiguration<TypeIntervention>
    {
        public void Configure(EntityTypeBuilder<TypeIntervention> builder)
        {
            builder
                .HasData(GenerateTypeIntervention());
        }

        private IEnumerable<TypeIntervention> GenerateTypeIntervention()
        {
            IEnumerable<TypeIntervention> typeInterventions = new List<TypeIntervention>()
           {
             new TypeIntervention { Name = "Emergency" },
             new TypeIntervention { Name = "Diagnostic Interventions" },
             new TypeIntervention { Name = "Surgical Interventions" },
             new TypeIntervention { Name = "Therapeutic Interventions" },
             new TypeIntervention { Name = "Dental Interventions" },
             new TypeIntervention { Name = "Obstetric and Reproductive Interventions" },
             new TypeIntervention { Name = "Exotic and Specialized Interventions" },
             new TypeIntervention { Name = "Preventive Interventions" },
             new TypeIntervention { Name = "Oncological Interventions" },
             new TypeIntervention { Name = "Postoperative Care" }
           };

            return typeInterventions;
        }
    }
}
