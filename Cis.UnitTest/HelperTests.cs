using CisWindowsFormsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cis.UnitTest
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void SpellTest()
        {
            int nbr = -100;

            var res = SpellNumber.Spell(nbr);

        }
    }
}
