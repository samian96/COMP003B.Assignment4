using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    // Model for the Form page of the application
    public class OrderForm
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]

        public string FullName { get; set; }

        [Required]
        [EmailAddress]

        public string Email { get; set; }

        [Required]
        [Range(1,20)]

        public int Quantity { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]

        public string Product { get; set; }


        [StringLength(100)]

        public string? AdditionalNote { get; set; }

    }
}
