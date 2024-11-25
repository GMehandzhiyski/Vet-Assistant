using Microsoft.EntityFrameworkCore;

namespace VetAssistant.Data.Models;

public interface IDeletableEntity
{
    [Comment("State of delete")]
    bool IsDeleted { get; set; }

    [Comment("Date of Delete")]
    DateTime? DeletedOn { get; set; }
}

