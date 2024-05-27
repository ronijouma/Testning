using NUnit.Framework;
using Biljettshoppen;
using System;
using System.Collections.Generic;
using System.IO;

namespace Biljettshoppen_Test
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void Reservation_CreatesCorrectly()
        {
            var customer = new Customer("Roni Jouma", "h21ronjo@du.se", "987654321");
            var tickets = new List<Ticket>
            {
                new Ticket("Concert", DateTime.Now, "A1", 100m)
            };
            var reservation = new Reservation(tickets, DateTime.Now, customer);

            Assert.That(reservation.Customer, Is.EqualTo(customer));
            Assert.That(reservation.Tickets, Is.EqualTo(tickets));
        }

        [Test]
        public void ReserveSeat_ReservesCorrectly()
        {
            var customer = new Customer("Roni Jouma", "h21ronjo@du.se", "987654321");
            var tickets = new List<Ticket>();
            var reservation = new Reservation(tickets, DateTime.Now, customer);
            bool[,] seatReservations = new bool[5, 5];

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                reservation.ReserveSeat(seatReservations, 1, 1);

                Assert.That(seatReservations[0, 0], Is.True);
            }
        }
    }
}
