using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Com.Grooveip.Sdk.Utils;

namespace UnitTests
{
    [TestClass]
    public class HashGeneratorTests
    {
        [TestMethod]
        public void createSHA256_createsSHA256HashOfAString_returnsHashedString()
        {
            string secretKey = "myapiscret";
            int clientId = 1;
            string areaCode = "732";
            string requestId = "c4h5dadb-8241-4765-8fed-845d35bbfe54";

            string input = string.Format("{0}{1}{2}{3}", clientId, areaCode, requestId, secretKey);

            string hash = HashGenerator.CreateSHA256(input);

            Assert.AreEqual("d74db3e6c9d5ed6760fd70e7c853a796eab89d3b3a37677bb2ee59bde2f8519f", hash);

        }
    }
}
