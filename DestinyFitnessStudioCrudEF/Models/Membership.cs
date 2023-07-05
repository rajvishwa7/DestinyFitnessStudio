using System.ComponentModel.DataAnnotations;

namespace DestinyFitnessStudioCrudEF.Models
{
    public class Membership
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [RegularExpression(@"^([0-9]){10}", ErrorMessage = "Invalid Mobile Number")]
        [Required(ErrorMessage = "Mobile Required")]
        public string Mobile { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        [Display(Name = "Landline No")]
        public string Phone { get; set; }
        [Range(18, 60, ErrorMessage = "Age must be between 18 to 60")]
        [Required(ErrorMessage = "Enter Your Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender Required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter Height in cm.. Required")]
        public string Height { get; set; }
        [Required(ErrorMessage = "Enter Weight in kg.. Required")]
        public string Weight { get; set; }
        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter Your Selected Program.. Required")]
        public string FitProgram { get; set; }
        [Required(ErrorMessage = "Enter Your Fees.. Required")]
        public float Fees { get; set; }

    }

}