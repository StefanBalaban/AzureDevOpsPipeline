using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp;

namespace WebAppUnitTests
{
    [TestFixture]
    class DigitronTests
    {
        [Test]
        public void Saberi_PozvanSaDvaDva_VratiCetiri()
        {
            var digitron = new Digitron();

            var cetiri = digitron.Saberi(2, 2);

            Assert.That(cetiri, Is.EqualTo(4));
        }
    }
}
