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


        [Required(ErrorMessage = "please enter vehicle capacity")]
        public int Capacity { get; set; }


        [Required(ErrorMessage = "please enter Available Seats")]
        public int AvailableSeats { get; set; }
       

        [Required(ErrorMessage = "please select yes/no")]
        public string Operable { get; set; }



        [Required(ErrorMessage = "please select yes/no")]
        public String IsAc { get; set; }


        [Required(ErrorMessage = "please enter Route Number")]
        public int RouteNumber { get; set; }


       // [Required(ErrorMessage = "please enter Arrival Time")]
        public DateTime MorningShiftArrivalTime { get; set; }


        //[Required(ErrorMessage = "please enter Depatute Number")]
        public DateTime MorningShiftDepatureTime { get; set; }

        //[Required(ErrorMessage = "please enter Arrival Time")]
        public DateTime EveningShiftArrivalTime { get; set; }


      //  [Required(ErrorMessage = "please enter Depatute Number")]
        public DateTime EveningShiftDepatureTime { get; set; }
    }
}
