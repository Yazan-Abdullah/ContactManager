using System.ComponentModel.DataAnnotations;

public class Contact
{
    public int Id { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [StringLength(50, ErrorMessage = "First name must not exceed 50 characters")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    [StringLength(50, ErrorMessage = "Last name must not exceed 50 characters")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email address is not valid")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    public string? PhoneNumber { get; set; }
}

