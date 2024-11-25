namespace VetAssistant.Data.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(VetAssistantDbContext dbContext, IServiceProvider serviceProvider);
    }
}
