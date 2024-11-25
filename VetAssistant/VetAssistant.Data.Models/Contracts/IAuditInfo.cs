using Microsoft.EntityFrameworkCore;

namespace VetAssistant.Data.Models;

public interface IAuditInfo
{
    [Comment("Date of create")]
    DateTime CreatedOn { get; set; }

    [Comment("Date of modification")]
    DateTime? ModifiedOn { get; set; }
}
