using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class UserReservation
    {
        public string UserID { get; set; }

        public MyUser MyUser { get; set; }

        public int ReservationID { get; set; }

        public Reservation Reservation { get; set; }
    }

}
