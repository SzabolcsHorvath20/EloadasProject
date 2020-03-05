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
            Assert.AreEqual(4 * 2 - 1, test.GetSzabadHelyek());
        }
        [TestCase]
        public void HibasParameter()
        {
            Assert.Throws<ArgumentException>(() => { new Eloadas(0, 0); });
        }
        [TestCase]
        public void HibasParameter2()
        {
            Assert.Throws<ArgumentException>(() => { test.Foglalt(-1, 15); });
        }
        [TestCase]
        public void GetSzabadhelyekSikeres()
        {
            int seged = test.GetSzabadHelyek();
            Assert.AreEqual(seged, 4*2);
        }
        [TestCase]
        public void GetSzabadhelyekSikeres2()
        {
            int seged = test.GetSzabadHelyek();
            test.Lefoglal();
            int seged2 = test.GetSzabadHelyek();
            Assert.AreEqual(seged-1, seged2);
        }
        [TestCase]
        public void GetSzabadhelyekSikeres3()
        {
            for (int i = 0; i < 24; i++)
            {
                test.Lefoglal();
            }
            Assert.AreEqual(test.GetSzabadHelyek(), 0);
        }
        [TestCase]
        public void Teli()
        {
            for (int i = 0; i < 2; i++)
            {
                test.Lefoglal();
            }
            Assert.IsFalse(test.Teli());
        }
        [TestCase]
        public void Teli2()
        {
            for (int i = 0; i < 24; i++)
            {
                test.Lefoglal();
            }
            Assert.IsTrue(test.Teli());
        }
        [TestCase]
        public void Foglalt()
        {
            test.Lefoglal();
            test.Lefoglal();
            Assert.IsTrue(test.Foglalt(1,1));
        }
        [TestCase]
        public void Foglalt2()
        {
            Assert.IsFalse(test.Foglalt(1, 2));
        }
        [TestCase]
        public void Foglalt3()
        {
            for (int i = 0; i < 24; i++)
            {
                test.Lefoglal();
            }
            if (test.Teli())
            {
                test.Foglalt(4,2);
            }
        }
    }
}
