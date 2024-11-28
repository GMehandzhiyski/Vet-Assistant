using VetAssistant.Web.ViewModels.Clinic;

namespace VetAssistant.Service.Data.Contracts
{
    public interface IClinicService
    {
        //Task<IEnumerable<Clinic>> IndexGetAllOrderedByLocationAsync();

        Task AddCinemaAsync(AddClinicFormModel model);

        Task<ClinicDetailsViewModel?> GetCinemaDetailsByIdAsync(Guid id);

        Task<EditClinicFormModel?> GetCinemaForEditByIdAsync(Guid id);

        //Task<bool> EditCinemaAsync(EditCinemaFormModel model);

        //Task<DeleteCinemaViewModel?> GetCinemaForDeleteByIdAsync(Guid id);

        //Task<bool> SoftDeleteCinemaAsync(Guid id);
    }
}
