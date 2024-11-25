namespace VetAssistant.Data.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public abstract class BaseDeletableModel<TKey> : IAuditInfo, IDeletableEntity
{
    [Key]
    [Comment("Identifier")]
    public Guid Id { get; set; }

    [Comment("Date of creation")]
    public DateTime CreatedOn { get; set; }

    [Comment("Last date of modification")]
    public DateTime? ModifiedOn { get; set; }

    [Comment("Deleted status")]
    public bool IsDeleted { get; set; }

    [Comment("Date of deleting")]
    public DateTime? DeletedOn { get; set; }
}

