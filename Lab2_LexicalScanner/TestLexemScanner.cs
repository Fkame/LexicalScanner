using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
namespace Lab2_LexicalScanner
{
    [TestClass]
    public class TestLexemScanner
    {
       
        [TestMethod]
        public void Test_IsEnLetter()
        {
            LexemScanner scanner = new LexemScanner(String.Empty);

            char[] data = { 'a', 'z', 'B', 'Z', 'A', '6', ',', 'ы', ' ' };
            bool[] trueRez = { true, true, true, true, true, false, false, false, false };

            for (int i = 0; i < data.Length; i++)
            {
                bool rez = scanner.IsEnLetter(data[i]);
                Assert.AreEqual(trueRez[i], rez);
            }
        }

        [TestMethod]
        public void Test_IsNumber()
        {
            LexemScanner scanner = new LexemScanner(String.Empty);

            char[] data = { 'a', 'z', 'B', 'Z', 'A', '6', ',', 'ы', ' ' };
            bool[] trueRez = { false, false, false, false, false, true, false, false, false };

            for (int i = 0; i < data.Length; i++)
            {
                bool rez = scanner.IsNumber(data[i]);
                Assert.AreEqual(trueRez[i], rez);
            }
        }

        [TestMethod]
        public void Test_IsKeyWord()
        {
            LexemScanner scanner = new LexemScanner(String.Empty);

            string[] inputData = { "for", "fori", "fo", "For", "fordo", "do", " do", " do " };
            bool[] trueRez = { true, false, false, false, false, true, false, false };

            for (int i = 0; i < inputData.Length; i++)
            {
                bool rez = scanner.IsKeyWord(new StringBuilder(inputData[i]));
                Assert.AreEqual(trueRez[i], rez);
            }
        }

        [TestMethod]
        public void Test_TryIdentificator()
        {
            string[] testValues = { "for", ";", "b5", " b5", "_isc1", "____", "_i_;", "123455;", "_123", "b_5" };
            (bool isSuccess, string value)[] trez = { (true, "for"), (false, null), (true, "b5"), (false, null), (true, "_isc1"), (false, null), (true, "_i_"), (false, null), (false, null), (true, "b_5") };

            for (int i = 0; i < testValues.Length; i++)
            {
                int index = 0;
                var rez = new LexemScanner(testValues[i]).TryIdentificator(ref index);

                Assert.AreEqual(trez[i].isSuccess, rez.isSuccess);
                Assert.AreEqual(trez[i].value, rez.value != null ? rez.value.ToString() : null);
            }         
        }

        [TestMethod]
        public void Test_TryStringConstant()
        {
            string[] testValues = { "\"abc", "\"abcd\"", "abcde\"", "\"1 2 3 4 5 \"" };
            (bool isSuccess, string value)[] trez = { (false, null), (true, "abcd"), (false, null), (true, "1 2 3 4 5 ") };

            for (int i = 0; i < testValues.Length; i++)
            {
                int index = 0;
                var rez = new LexemScanner(testValues[i]).TryStringConstant(ref index);

                Assert.AreEqual(trez[i].isSuccess, rez.isSuccess);
                Assert.AreEqual(trez[i].value, rez.value != null ? rez.value.ToString() : null);
            }
        }

        [TestMethod]
        public void Test_TryNumberconstant()
        {
            string[] testValues = { "\"1234", "\"12345\"", "12345\"", "1 2 3 4 5", "12345" };
            (bool isSuccess, string value)[] trez = { (false, null), (false, null), (true, "12345"), (true, "1"), (true, "12345"), };

            for (int i = 0; i < testValues.Length; i++)
            {
                int index = 0;
                var rez = new LexemScanner(testValues[i]).TryNumberconstant(ref index);

                Assert.AreEqual(trez[i].isSuccess, rez.isSuccess);
                Assert.AreEqual(trez[i].value, rez.value != null ? rez.value.ToString() : null);
            }
        }
    }
}
