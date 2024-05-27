using NUnit.Framework;
using Biljettshoppen;

namespace Biljettshoppen_Test
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void Customer_Constructor_SetsPropertiesCorrectly()
        {
            var customer = new Customer("Roni Jouma", "h21ronjo@du.se", "1234567890");

            Assert.That(customer.Name, Is.EqualTo("Roni Jouma"));
            Assert.That(customer.Email, Is.EqualTo("h21ronjo@du.se"));
            Assert.That(customer.Phonenumber, Is.EqualTo("1234567890"));
        }
    }
}
