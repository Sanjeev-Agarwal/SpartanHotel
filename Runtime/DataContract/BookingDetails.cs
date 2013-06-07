using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime.DataContract
{
    public class BookingDetails
    {
        public Guid BookingRefNumber;

        public GuestDetails GuestDetails;

        public Criteria BookingCriteria;

        public short RoomId;

        public Status Status = Status.UnConfirmed;
    }

    public class GuestDetails
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNo;
        public Guid CustRefNo;
    }

    public enum Status
    {
        UnConfirmed = 1,
        Pending = 2,
        Confirm = 3,
        Cancel = 4
    }
}
