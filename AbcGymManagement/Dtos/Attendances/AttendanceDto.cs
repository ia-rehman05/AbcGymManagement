﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Service.Dtos.Attendances
{
    public class AttendanceDto
    {
        public Guid Id { get; set; }
        public string? MemberId { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Check-in time is required.")]
        public DateTime CheckInTime { get; set; } = DateTime.Now;
        public DateTime CheckOutTime { get; set; } = DateTime.Now.AddHours(8);
    }
}
