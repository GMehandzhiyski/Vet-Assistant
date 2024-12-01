﻿using VetAssistant.Data;
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

            };

            await context.Clinics.AddAsync(newClinic);
            await context.SaveChangesAsync();



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
