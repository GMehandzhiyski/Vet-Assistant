using Microsoft.EntityFrameworkCore;
using VetAssistant.Data;
using VetAssistant.Service.Data.Contracts;
using VetAssistant.Web.ViewModels;

namespace VetAssistant.Service.Data
{
    public class BaseService : IBaseService
    {
        protected readonly VetAssistantDbContext context;

        public BaseService(VetAssistantDbContext context)
        {
            this.context = context;
        }

        public async Task<ICollection<CountryViewModel>> GetCountryAsync()
        {
            return await context.Countries
                .Select(country => new CountryViewModel()
                {
                    Id = country.Id,
                    Name = country.Name,
                })
                .OrderBy(country => country.Name)
                .ToListAsync();
        }

        public async Task<bool> IsCountryValid(Guid countryId)
        {
            return await context.Countries
                .AllAsync(c => c.Id == countryId);
        }

        public bool IsGuidValid(string? id, ref Guid parseGuid)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            bool isGuidValid = Guid.TryParse(id, out parseGuid);
            if (!isGuidValid)
            {
                return false;
            }

            return true;
        }
    }
}
