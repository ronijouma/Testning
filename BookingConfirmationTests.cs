using NUnit.Framework;
using Biljettshoppen;
using System;

namespace Biljettshoppen_Test
{
    [TestFixture]
    public class BookingConfirmationTests
    {
        [Test]
        public void BookingConfirmation_SendsEmail_WhenTicketIsNotNull()
        {
            var ticket = new Ticket("Concert", DateTime.Now, "A1", 100m);
            var bookingConfirmation = new BookingConfirmation(ticket);

            Assert.IsNotNull(bookingConfirmation.Ticket);
        }

        [Test]
        public void BookingConfirmation_DoesNotSendEmail_WhenTicketIsNull()
        {
            var bookingConfirmation = new BookingConfirmation(null);

            Assert.IsNull(bookingConfirmation.Ticket);
        }
    }
}
