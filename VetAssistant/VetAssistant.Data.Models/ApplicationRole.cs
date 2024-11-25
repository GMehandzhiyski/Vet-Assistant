using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace VetAssistant.Data.Models
{
    public class ApplicationRole : IdentityRole<Guid>, IAuditInfo, IDeletableEntity
    {
        public ApplicationRole()
            : base()
        {

        }

        public ApplicationRole(string name)
            : base(name)
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        [Comment("Date of create")]
        public DateTime CreatedOn { get; set; }

        [Comment("Date of modification")]
        public DateTime? ModifiedOn { get; set; }

        [Comment("State of delete")]
        public bool IsDeleted { get; set; }

        [Comment("Date of Delete")]
        public DateTime? DeletedOn { get; set; }
    }
}
