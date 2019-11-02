using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RepairSystem.Models
{
    public class CarRegistration
    {
        [Required(ErrorMessage = "Please enter your License Plate.")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "Please enter your Name.")]
        public string Owner { get; set; }

        [Required(ErrorMessage = "Please enter your Address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the Make of the Car.")]
        public int Make { get; set; }

        [Required(ErrorMessage = "Please enter the Model.")]
        public string Model { get; set; }

        public bool Feature4Door { get; set; }
        public bool FeatureEthanol { get; set; }
        public bool Feature4WD { get; set; }
        public DateTime RegistrationDateAndTime { get; set; } = DateTime.Now;
    }
}
