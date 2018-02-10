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
            string requestId = "c4h5dadb-8241-4765-8fed-845d35bbfe54/hash/293b945730fd13064bcee146989eec92272788a555369947b609a29d5bfd7avv";

            string input = string.Format("{0}{1}{2}{3}", clientId, areaCode, requestId, secretKey);

            Assert.AreEqual("5b7252c27e483d6c92b1565f7386c3d1ec0dcf9f0d444a8760520a673c839528", HashGenerator.CreateSHA256(input));

        }
    }
}
