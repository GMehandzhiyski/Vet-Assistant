using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;
using VetAssistant.Web.ViewModels.Clinic;

namespace VetAssistant.Service.Data
{
    public class ClinicService : BaseService, IClinicService
    {
        private readonly IRepository<Clinic, Guid> clinicRepository;

        public ClinicService(IRepository<Clinic, Guid> _clinicRepository)
        {
            clinicRepository = _clinicRepository;
        }

        public Task AddClinicAsync(AddClinicFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditClinicAsync(EditClinicFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ClinicDetailsViewModel?> GetClinicDetailsByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteClinicViewModel?> GetClinicForDeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<EditClinicFormModel?> GetClinicForEditByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteClinicAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
