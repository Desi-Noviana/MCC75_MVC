using MCC75_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace MCC75_MVC.ViewModels;

public class RegisterVM
{
    [MaxLength(6), MinLength(6, ErrorMessage = "Input must be 6 digits, ex: 098123")]
    [Required(ErrorMessage = "Input must be 6 digits, ex: 098123")]
    public string NIK { get; set; }
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public GenderEnum Gender { get; set; }
    [Display(Name = "Hiring Date")]
    public DateTime HiringDate { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [Display(Name = "Phone Number")]
    [Phone]
    public string? PhoneNumber { get; set; }
    public string Major { get; set; }
    [MaxLength(2), MinLength(2, ErrorMessage = "ex: S1/D3")]
    [Required(ErrorMessage = "Cannot be empty ex: D3/S1")]
    public string Degree { get; set; }
    [Range(0, 4, ErrorMessage = "Input Must Be More Than {1} And Less Than {2}")]
    public float GPA { get; set; }
    [Display(Name = "University Name")]
    public string UniversityName { get; set; }
    [DataType(DataType.Password)]
    [StringLength(255, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    public string Password { get; set; }
    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

   
}

public enum GenderEnum
{
    Male,
    Female
}

