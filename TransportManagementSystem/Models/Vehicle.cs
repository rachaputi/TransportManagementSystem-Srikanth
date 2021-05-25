using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementSystem.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleNumber { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int AvailableSeats { get; set; }
        [Required]
        public string Operable { get; set; }
        [Required]
        public String IsAc { get; set; }
        [Required]
        public int RouteNumber { get; set; }
        [Required]
        public DateTime ArrivalTime { get; set; }
        [Required]
        public DateTime DepatureTime { get; set; }
    }
}
