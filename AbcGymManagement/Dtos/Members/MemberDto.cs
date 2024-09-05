using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Member
{
    public class MemberDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Guid TrainerId { get; set; }

        //// You can include related entities' identifiers if needed
        //public ICollection<Guid> WorkoutIds { get; set; }
        //public ICollection<Guid> PaymentIds { get; set; }
        //public ICollection<Guid> MembershipIds { get; set; }
        //public ICollection<Guid> MeasurementIds { get; set; }
        //public ICollection<Guid> DietIds { get; set; }
        //public ICollection<Guid> AttendanceIds { get; set; }

        //    // Optional: If you need the name or some basic details of related entities
        //    public string TrainerName { get; set; }
        //    public IEnumerable<string> MembershipSchemeNames { get; set; }
    }

}
