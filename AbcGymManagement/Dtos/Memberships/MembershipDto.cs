using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Memberships
{
    public class MembershipDto
    {
        public Guid Id { get; set; }

        public string MemberId { get; set; }
        public Guid PackageId { get; set; }
        public bool IsActive { get; set; }

    }
}

