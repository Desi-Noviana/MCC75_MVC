using System.ComponentModel.DataAnnotations;

namespace MCC75_MVC.ViewModels;

public class EmployeeVM
{
    [MaxLength(6), MinLength(6, ErrorMessage = "Input must be 6 digits, ex: 098123")]
    [Required(ErrorMessage = "Input must be 6 digits, ex: 098123")]
    public string NIK { get; set; }
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }
    public DateTime Birthdate { get; set; }
    [Required(ErrorMessage = "Select Your Gender")]
    public GenderEnum Gender { get; set; }
    [Display(Name = "Hiring Date")]
    public DateTime HiringDate { get; set; } = DateTime.Now;
    [EmailAddress]
    public string Email { get; set; }
    [Display(Name = "Phone Number")]
    [Phone]
    public string? PhoneNumber { get; set; }


}

