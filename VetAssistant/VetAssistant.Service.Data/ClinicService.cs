using Microsoft.EntityFrameworkCore;
using VetAssistant.Data;
using VetAssistant.Data.Models;
using VetAssistant.Service.Data.Contracts;
using VetAssistant.Web.ViewModels.Clinic;

namespace VetAssistant.Service.Data
{
    public class ClinicService : BaseService, IClinicService
    {
        public ClinicService(VetAssistantDbContext context)
            : base(context)
        {

        }
        public async Task AddClinicAsync(AddClinicFormModel model)
        {
            Clinic newClinic = new Clinic()
            {
                CreatedOn = DateTime.Now,
                IsDeleted = false,
                Name = model.Name,
                Town = model.Town,
                Address = model.Address,
                CountryId = model.CountryId,
                Email = model.Email,
                WorkingTime = model.WorkingTime,
                PhoneNumber = model.PhoneNumber,

            };

            await context.Clinics.AddAsync(newClinic);
            await context.SaveChangesAsync();



        }

        public Task<AddClinicFormModel?> GetClinicForEditByIdAsync(Guid clinicId)
        {
            return context.Clinics
                .Where(c => c.IsDeleted == false)
                .Where(c => c.Id == clinicId)
                .Select(c => new AddClinicFormModel()
                {
                    Id = c.Id,
                    CreatedOn = DateTime.Now,
                    Name = c.Name,
                    Town = c.Town,
                    Address = c.Address,
                    CountryId = c.CountryId,
                    Email = c.Email,
                    WorkingTime = c.WorkingTime,
                    PhoneNumber = c.PhoneNumber,
                })
                .FirstOrDefaultAsync();
        }

        public Task<ClinicDetailsViewModel?> GetClinicDetailsByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteClinicViewModel?> GetClinicForDeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        public Task<bool> SoftDeleteClinicAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditClinicAsync(AddClinicFormModel model)
        {
            throw new NotImplementedException();
        }
    }
}
