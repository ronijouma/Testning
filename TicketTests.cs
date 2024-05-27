using NUnit.Framework;
using Biljettshoppen;
using System;

namespace Biljettshoppen_Test
{
    [TestFixture]
    public class TicketTests
    {
        [Test]
        public void Ticket_Constructor_SetsPropertiesCorrectly()
        {
            var eventName = "Concert";
            var eventDate = new DateTime(2024, 6, 1);
            var seat = "A1";
            var price = 100.00m;

            var ticket = new Ticket(eventName, eventDate, seat, price);

            Assert.That(ticket.EventName, Is.EqualTo(eventName));
            Assert.That(ticket.EventDate, Is.EqualTo(eventDate));
            Assert.That(ticket.Seat, Is.EqualTo(seat));
            Assert.That(ticket.Price, Is.EqualTo(price));
        }
    }
}
