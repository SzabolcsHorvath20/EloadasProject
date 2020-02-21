using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject01.EloadasTest
{
    [TestFixture]
    class EloadasokTest
    {
        Eloadas test;
        [SetUp]
        public void SetUp()
        {
            test = new Eloadas(4, 2);
        }
        [TestCase]
        public void FoglalasSikeres()
        {
            Assert.IsTrue(test.Lefoglal());
        }
        [TestCase]
        public void FoglalasSikeres2()
        {
            test.Lefoglal();
            Assert.AreEqual(4*2-1, test.GetSzabadHelyek());
        }
        [TestCase]
        public void HibasParameter()
        {
            Assert.Throws<ArgumentException>(() => { new Eloadas(0, 0); });
        }

    }
}
