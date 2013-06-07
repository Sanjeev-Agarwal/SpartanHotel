using System.Collections.Generic;
using System.Data.Entity;
using DomainModel.Search.Context;
using DomainModel.Search.Model;
using Runtime.DataContract;
using System.Linq;
using System;

namespace Runtime
{
    public class DbAccess : DbContext
    {
        public static IList<RoomAvailability> GetRooms(Criteria criteria)
        {
            using (var context = new DomainModel.Search.Context.SearchModelContext())
            {
                var queryResult = context.RoomAvailabilities.Where(x => x.City.Equals(criteria.City, StringComparison.InvariantCultureIgnoreCase) && x.Date >= criteria.FromDate.Date && x.Date <= criteria.ToDate.Date && x.NoofAvailableRooms > 0);
                if (queryResult.Min(x => x.NoofAvailableRooms) > 0)
                {
                    return queryResult.ToList();
                }
                else
                {
                    return new List<RoomAvailability>();
                }
            };
        }

        public static RoomAvailability GetReservationDetails(DateTime selectedDate)
        {

            return null;
        }

        public static void Bookreservation(BookingDetails bookingDetail)
        {
            using (var context = new DomainModel.Reservation.Context.ReservationModelContext())
            {

                // add the guest details
                DomainModel.Reservation.Model.Guest guest = new DomainModel.Reservation.Model.Guest();
                guest.FirstName = bookingDetail.GuestDetails.FirstName;
                guest.LastName = bookingDetail.GuestDetails.LastName;
                guest.Id = bookingDetail.GuestDetails.CustRefNo;
                guest.Email = bookingDetail.GuestDetails.Email;

                context.Guests.Add(guest);


                // add reservation details
                DateTime selectedDate = bookingDetail.BookingCriteria.FromDate;
                while (selectedDate <= bookingDetail.BookingCriteria.ToDate)
                {

                    DomainModel.Reservation.Model.Reservation reservation = new DomainModel.Reservation.Model.Reservation();
                    reservation.CreatedDate = DateTime.Now;
                    reservation.Id = bookingDetail.BookingRefNumber;
                    reservation.NoOfRooms = bookingDetail.BookingCriteria.NoOfRooms;
                    reservation.Room.Id = bookingDetail.RoomId;
                    reservation.Date = selectedDate;
                    reservation.Status.Id = (short)Status.UnConfirmed;

                    context.Reservations.Add(reservation);

                    selectedDate = selectedDate.AddDays(1);
                }

                context.SaveChanges();
                

            }
        }

    }
}
