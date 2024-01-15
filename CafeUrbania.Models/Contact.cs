using System.ComponentModel.DataAnnotations;

namespace CafeUrbania.Models;

public class Contact
{
    [Required]
    public string Name { get; set; }

    public string Phone { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Message { get; set; }

    public DateTime SubmittedTime { get; set; }
}
