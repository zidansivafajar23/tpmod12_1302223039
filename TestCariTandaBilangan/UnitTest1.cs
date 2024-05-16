using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCariTandaBilangan

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CariTandaBilanganNegatif()
        {
            int input = -5;
            string excepted = "Negatif";

            string actual = TandaBilangan.CariTandaBilangan(input);

            Assert.AreEqual(excepted, actual);
        }
    }
}