using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Members
{
    public class MemberCreatedDto

    {
        #region Member Parameters

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        public string? PhoneNumber { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is requireds.")]
        public string Gender { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        public string? ProfileImage { get; set; }

        public bool IsActive { get; set; }
        public string? TrainerId { get; set; } // Trainer's ID
        public Guid? MembershipId { get; set; } // Membership's ID

        #endregion
    }

}
