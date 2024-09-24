using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.Dtos.Measurements
{
    public class UpdateMeasurementDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "MemberId length can't be more than 50.")]
        public string MemberId { get; set; }

        [Range(0, 10, ErrorMessage = "Feet must be between 0 and 10.")]
        public int Feet { get; set; }

        [Range(0, 11, ErrorMessage = "Inches must be between 0 and 11.")]
        public int Inches { get; set; }

        [Range(0.0, 500.0, ErrorMessage = "Weight must be between 0 and 500 kg.")]
        public float Weight { get; set; }

        [Range(0.0, 100.0, ErrorMessage = "BodyFatPercentage must be between 0 and 100%.")]
        public float BodyFatPercentage { get; set; }

        [Range(0.0, 100.0, ErrorMessage = "MuscleMass must be between 0 and 100%.")]
        public float MuscleMass { get; set; }
    }
}
