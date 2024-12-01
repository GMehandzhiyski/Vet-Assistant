using VetAssistant.Web.ViewModels;
namespace VetAssistant.Service.Data.Contracts
{
    public interface IBaseService
    {
        bool IsGuidValid(string? id, ref Guid parseGuid);

        Task<ICollection<CountryViewModel>> GetCountryAsync();
        Task<bool> IsCountryValid(Guid countryId);
    }
}
