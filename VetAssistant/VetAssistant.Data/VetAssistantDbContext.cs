namespace VetAssistant.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;
    using VetAssistant.Data.Models;

    public class VetAssistantDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {

        public VetAssistantDbContext()
        {

        }

        public VetAssistantDbContext(DbContextOptions<VetAssistantDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;

        public virtual DbSet<Clinic> Clinics { get; set; } = null!;

        public virtual DbSet<ClinicDoctor> ClinicDoctors { get; set; } = null!;

        public virtual DbSet<Country> Countries { get; set; } = null!;

        public virtual DbSet<Doctor> Doctors { get; set; } = null!;

        public virtual DbSet<DoctorBooking> DoctorBookings { get; set; } = null!;

        public virtual DbSet<DoctorIntervention> DoctorInterventions { get; set; } = null!;

        public virtual DbSet<DoctorPet> DoctorPets { get; set; } = null!;

        public virtual DbSet<Gender> Genders { get; set; } = null!;

        public virtual DbSet<Intervention> Interventions { get; set; } = null!;

        public virtual DbSet<Pet> Pets { get; set; } = null!;

        public virtual DbSet<PetBooking> PetBookings { get; set; } = null!;

        public virtual DbSet<PetIntervention> PetInterventions { get; set; } = null!;

        public virtual DbSet<TypeIntervention> TypeInspections { get; set; } = null!;

        public virtual DbSet<ApplicationUserBooking> ApplicationUserBookings { get; set; } = null!;

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

        public virtual DbSet<ApplicationUserPet> ApplicationUserPets { get; set; } = null!;

        public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //automatic add configuration
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
