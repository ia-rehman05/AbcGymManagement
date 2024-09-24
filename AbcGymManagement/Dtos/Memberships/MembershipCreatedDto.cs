using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.Dtos.Memberships
{
    public class MembershipCreatedDto
    {
        public string MemberId { get; set; }
        public Guid? PackageId { get; set; }
        public bool IsActive { get; set; }
    }
}
