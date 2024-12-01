using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Web.ViewModels
{
    public class CountryViewModel
    {
        [Key]
        [Comment("Country Id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Comment("Country Name")]
        public string Name { get; set; } = string.Empty;
    }
}
