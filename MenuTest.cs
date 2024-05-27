using NUnit.Framework;
using Biljettshoppen;
using System;
using System.IO;

namespace Biljettshoppen_Test
{
    [TestFixture]
    public class MenuTest
    {
        [Test]
        public void StartMenu_DisplayMenuOptions()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (StringReader sr = new StringReader("3"))
                {
                    Console.SetIn(sr);
                    Menu.StartMenu();
                }

                string expected = string.Join(Environment.NewLine, new string[]
                {
                    "Menu:",
                    "1. Köp Biljetter",
                    "2. Skapa ett Evenemang",
                    "3. Exit",
                    "Val: Exiting the program."
                });

                Assert.That(sw.ToString().Trim(), Is.EqualTo(expected));
            }
        }
    }
}
