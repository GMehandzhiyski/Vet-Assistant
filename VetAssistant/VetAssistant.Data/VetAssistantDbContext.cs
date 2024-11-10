namespace VetAssistant.Data
{
    using Microsoft.EntityFrameworkCore;
    public class VetAssistantDbContext : DbContext
    {

        public VetAssistantDbContext()
        {

        }

        public VetAssistantDbContext(DbContextOptions options)
            : base(options)
        {

        }


    }
}
