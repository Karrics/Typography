using Microsoft.VisualStudio.TestTools.UnitTesting;
using Typography;

namespace TypographyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSpace()
        {
            string str = Form1.Text_Rule1("слово , запятая .");
            Assert.AreEqual(str, "слово, запятая.");
        }

        [TestMethod]
        public void CheckDash()
        {
            string str = Form1.Text_Rule1("тире-тире");
            Assert.AreEqual(str, "тире - тире");
        }

        [TestMethod]
        public void CheckQuotation_marks()
        {
            string str = Form1.Text_Rule1("“ фразаa ”");
            Assert.AreEqual(str, " “фразаa”");
        }

        [TestMethod]
        public void CheckBracket()
        {
            string str = Form1.Text_Rule1("( фраза )");
            Assert.AreEqual(str, " (фраза)");
        }

        [TestMethod]
        public void CheckOneSpace()
        {
            string str = Form1.Text_Rule2("апельсин   фрукт");
            Assert.AreEqual(str, "апельсин фрукт");
        }

        [TestMethod]
        public void CheckPlus_Minus()
        {
            string str = Form1.Text_Rule9("+-");
            string str2 = Form1.Text_Rule9("-+");
            Assert.AreEqual(str, "±");
            Assert.AreEqual(str2, "±");
        }

        [TestMethod]
        public void CheckDegree()
        {
            string str = Form1.Text_Rule12("x^2");
            string str2 = Form1.Text_Rule12("x^3");
            Assert.AreEqual(str, "x²");
            Assert.AreEqual(str2, "x³");
        }

        [TestMethod]
        public void CheckEllipsis()
        {
            string str = Form1.Text_Rule13("...");
            Assert.AreEqual(str, "…");
        }

        [TestMethod]
        public void CheckMyRull1()
        {
            string str = Form1.My_Rule1("unittest");
            Assert.AreEqual(str, "UnItTeSt");
        }

        [TestMethod]
        public void CheckMyRull2()
        {
            string str = Form1.My_Rule2("unittest");
            Assert.AreEqual(str, "unitest");
        }
    }
}
