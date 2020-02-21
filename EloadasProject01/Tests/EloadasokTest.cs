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
        public Eloadas test = new Eloadas(4, 2);
        [TestCase]
        public void Test1()
        {
            Assert.IsTrue(test.Lefoglal());
        }

    }
}
