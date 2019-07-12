using NationalCodeValidation.Validations;

namespace NationalCodeValidation.Models
{
    public class CustomerModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NationalCodeValidator(ErrorMessage ="کد ملی خراب است.")]
        public string NationalCode { get; set; }
    }
}
