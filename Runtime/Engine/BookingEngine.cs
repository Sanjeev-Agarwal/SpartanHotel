using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Search.Model;
using Runtime.DataContract;

namespace Runtime.Engine
{
    public class BookingEngine
    {
        public BookingEngine()
        {
        }

        public void StartBookingProcess(BookingDetails details)
        {
            if (details != null)
            {
                // check for availability 
                DateTime selectedDate = details.BookingCriteria.FromDate;
                bool proceedBooking = true;
                while (selectedDate <= details.BookingCriteria.ToDate)
                {
                    RoomAvailability availability = DbAccess.GetReservationDetails(selectedDate);
                    if (availability.NoofAvailableRooms == 0)
                    {
                        proceedBooking = false;
                        details.Status = Status.UnConfirmed;
                        break;
                    }
                    selectedDate = selectedDate.AddDays(1);
                }

                if (proceedBooking)
                {
                    details.Status = Status.Confirm;

                    // insert the booking into DB
                    DbAccess.Bookreservation(details);
                    
                }

            }
        }
    }
}
