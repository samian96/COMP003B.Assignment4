using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class EventForms
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]

        public string FullName { get; set; }

    }
}
