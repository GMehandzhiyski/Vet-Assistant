using VetAssistant.Web.ViewModels.Clinic;

namespace VetAssistant.Service.Data.Contracts
{
    public interface IClinicService : IBaseService
    {
        //Task<IEnumerable<Clinic>> IndexGetAllOrderedByLocationAsync();

        Task AddClinicAsync(AddClinicFormModel model);

        Task<ClinicDetailsViewModel?> GetClinicDetailsByIdAsync(Guid id);

        Task<AddClinicFormModel?> GetClinicForEditByIdAsync(Guid id);

        Task<bool> EditClinicAsync(AddClinicFormModel model);

        Task<DeleteClinicViewModel?> GetClinicForDeleteByIdAsync(Guid id);

        Task<bool> SoftDeleteClinicAsync(Guid id);
    }
}
