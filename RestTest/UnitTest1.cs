using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestCore;
namespace RestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fibo6_isCorrect()
        {
            Assert.AreEqual(2, Core.Fibonacci(3));
        }

        [TestMethod]
        public void FiboMinus10_isCorrect() {
            Assert.AreEqual(-1, Core.Fibonacci(-10));
        }

        [TestMethod]
        public void Fibo1000_isCorrect() {
            Assert.AreEqual(-1, Core.Fibonacci(1000));
        }
        
        [TestMethod]
        public void Json_isNotNull() {
            string xml = @"<?xml version='1.0' standalone='no'?>
                             <root>
                            <person id='1'>
                            <name>Alan</name>
                            <url>http://www.google.com</url>
                            </person>
                            <person id='2'>
                            <name>Louis</name>
                            <url>http://www.yahoo.com</url>
                            </person>
                            </root>";
            Assert.IsNotNull(Core.XmlToJson(xml));
        }
    }
}
