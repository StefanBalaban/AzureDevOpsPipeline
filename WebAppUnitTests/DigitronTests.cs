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
        private Digitron _digitron;

        [SetUp]
        public void Setup()
        {
            _digitron = new Digitron();
        }
        [Test]
        public void Saberi_PozvanSaDvaDva_VratiCetiri()
        {
            var cetiri = _digitron.Saberi(2, 2);

            Assert.That(cetiri, Is.EqualTo(4));
        }
        [Test]
        public void Oduzmi_PozvanSaDvaTri_VratiMinus()
        {
            var minusJedan = _digitron.Oduzmi(2, 3);

            Assert.That(minusJedan, Is.EqualTo(-1));
        }
       
    }
}
