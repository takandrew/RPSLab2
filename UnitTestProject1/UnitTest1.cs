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
            testString = beaufort.Encode(testString, key);
            Assert.AreEqual(testString, resultString);
        }
        [TestMethod]
        public void TestBeaufortRus()
        {
            Beaufort beaufort = new Beaufort();
            string testString = "Тестовая строка";
            string key = "ключ";
            string resultString = "Шжмеьйюш ължьбю";
            testString = beaufort.Encode(testString, key);
            Assert.AreEqual(testString, resultString);
        }
        [TestMethod]
        public void TestBeaufortAll()
        {
            Beaufort beaufort = new Beaufort();
            string testString = "Hello! Тест!";
            string key = "ключ";
            string resultString = "Eiunx! Еёъл!";
            testString = beaufort.Encode(testString, key);
            Assert.AreEqual(testString, resultString);
        }
        [TestMethod]
        public void TestROT13Eng()
        {
            ROT13 rot13 = new ROT13();
            string testString = "Hello world!";
            string key = null;
            string resultString = "Uryyb jbeyq!";
            testString = rot13.Encode(testString, key);
            Assert.AreEqual(testString, resultString);
        }
        [TestMethod]
        public void TestROT13Rus()
        {
            ROT13 rot13 = new ROT13();
            string testString = "Тестовая строка";
            string key = null;
            string resultString = "Ясюяыомл юяэычм";
            testString = rot13.Encode(testString, key);
            Assert.AreEqual(testString, resultString);
        }
        [TestMethod]
        public void TestROT13All()
        {
            ROT13 rot13 = new ROT13();
            string testString = "Hello! Тест!";
            string key = null;
            string resultString = "Uryyb! Ясюя!";
            testString = rot13.Encode(testString, key);
            Assert.AreEqual(testString, resultString);
        }
    }
}
