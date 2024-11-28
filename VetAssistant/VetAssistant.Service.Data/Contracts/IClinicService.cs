using VetAssistant.Web.ViewModels.Clinic;

namespace VetAssistant.Service.Data.Contracts
{
    public interface IClinicService
    {
        //Task<IEnumerable<Clinic>> IndexGetAllOrderedByLocationAsync();

        Task AddClinicAsync(AddClinicFormModel model);

        Task<ClinicDetailsViewModel?> GetClinicDetailsByIdAsync(Guid id);

        Task<EditClinicFormModel?> GetClinicForEditByIdAsync(Guid id);

        Task<bool> EditClinicAsync(EditClinicFormModel model);

        Task<DeleteClinicViewModel?> GetClinicForDeleteByIdAsync(Guid id);

        Task<bool> SoftDeleteClinicAsync(Guid id);
    }
}
