using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.Dtos.Memberships
{
    public class MembershipResponseDto
    {
        public Guid Id { get; set; }
        public string MemberId { get; set; }
        public Guid? PackageId { get; set; }
        public bool IsActive { get; set; }
    }
}
