using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystem.Models
{
    public class Route
    {
        [Key]
        public int RouteNumber { get; set; }
        [Required]
        public string VehicleNumber { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string Stop1 { get; set; }
        [Required]
        public string Stop2 { get; set; }
        [Required]
        public string Stop3 { get; set; }
    }
}
