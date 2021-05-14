using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLab2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBeaufortEng()
        {
            Beaufort beaufort = new Beaufort();
            string testString = "Hello World";
            string key = "key";
            string resultString = "Danzq Oqhzb";
            string testedString = beaufort.Encode(testString, key);
            Assert.AreEqual(testedString, resultString);
            string decodeTest = beaufort.Decode(resultString, key);
            Assert.AreEqual(testString, decodeTest);
        }
        [TestMethod]
        public void TestBeaufortRus()
        {
            Beaufort beaufort = new Beaufort();
            string testString = "Тестовая строка";
            string key = "ключ";
            string resultString = "Шжмеьйюш ължьбю";
            string testedString = beaufort.Encode(testString, key);
            Assert.AreEqual(testedString, resultString);
            string decodeTest = beaufort.Decode(resultString, key);
            Assert.AreEqual(testString, decodeTest);
        }
        [TestMethod]
        public void TestBeaufortAll()
        {
            Beaufort beaufort = new Beaufort();
            string testString = "Hello! Тест!";
            string key = "ключ";
            string resultString = "Eiunx! Еёъл!";
            string testedString = beaufort.Encode(testString, key);
            Assert.AreEqual(testedString, resultString);
            string decodeTest = beaufort.Decode(resultString, key);
            Assert.AreEqual(testString, decodeTest);
        }
        [TestMethod]
        public void TestROT13Eng()
        {
            ROT13 rot13 = new ROT13();
            string testString = "Hello world!";
            string key = null;
            string resultString = "Uryyb jbeyq!";
            string testedString = rot13.Encode(testString, key);
            Assert.AreEqual(testedString, resultString);
            string decodeTest = rot13.Decode(resultString, key);
            Assert.AreEqual(testString, decodeTest);
        }
        [TestMethod]
        public void TestROT13Rus()
        {
            ROT13 rot13 = new ROT13();
            string testString = "Тестовая строка";
            string key = null;
            string resultString = "Ясюяыомл юяэычм";
            string testedString = rot13.Encode(testString, key);
            Assert.AreEqual(testedString, resultString);
            string decodeTest = rot13.Decode(resultString, key);
            Assert.AreEqual(testString, decodeTest);
        }
        [TestMethod]
        public void TestROT13All()
        {
            ROT13 rot13 = new ROT13();
            string testString = "Hello! Тест!";
            string key = null;
            string resultString = "Uryyb! Ясюя!";
            string testedString = rot13.Encode(testString, key);
            Assert.AreEqual(testedString, resultString);
            string decodeTest = rot13.Decode(resultString, key);
            Assert.AreEqual(testString, decodeTest);
        }
    }
}
