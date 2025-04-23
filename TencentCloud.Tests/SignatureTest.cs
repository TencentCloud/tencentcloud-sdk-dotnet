using System.Text;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloud.Tests
{
    [TestClass]
    public class SignHelperTests
    {
        private const string SignKey = "testSignKey";
        private const string Secret = "testSecret";
        private const string PlainText = "testPlainText";
        private const string RequestMethod = "GET";
        private const string RequestHost = "cvm.tencentcloudapi.com";
        private const string RequestPath = "/";

        [TestMethod]
        public void Sign_SHA256_ReturnsCorrectSignature()
        {
            string expectedSignature = Convert.ToBase64String(
                new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(SignKey)).ComputeHash(
                    Encoding.UTF8.GetBytes(Secret)));
            string actualSignature = SignHelper.Sign(SignKey, Secret, ClientProfile.SIGN_SHA256);
            Assert.AreEqual(expectedSignature, actualSignature);
        }

        [TestMethod]
        public void Sign_SHA1_ReturnsCorrectSignature()
        {
            string expectedSignature = Convert.ToBase64String(
                new System.Security.Cryptography.HMACSHA1(Encoding.UTF8.GetBytes(SignKey)).ComputeHash(
                    Encoding.UTF8.GetBytes(Secret)));
            string actualSignature = SignHelper.Sign(SignKey, Secret, ClientProfile.SIGN_SHA1);
            Assert.AreEqual(expectedSignature, actualSignature);
        }

        [TestMethod]
        public void Sign_UnsupportedMethod_ReturnsEmptyString()
        {
            string actualSignature = SignHelper.Sign(SignKey, Secret, "UnsupportedMethod");
            Assert.AreEqual(string.Empty, actualSignature);
        }

        [TestMethod]
        public void SHA256Hex_WithString_ReturnsCorrectHexHash()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(PlainText);
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] expectedHashBytes = sha256.ComputeHash(bytes);
                string expectedHashString =
                    BitConverter.ToString(expectedHashBytes).Replace("-", "").ToLowerInvariant();
                string actualHashString = SignHelper.SHA256Hex(PlainText);
                Assert.AreEqual(expectedHashString, actualHashString);
            }
        }

        [TestMethod]
        public void SHA256Hex_WithBytes_ReturnsCorrectHexHash()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(PlainText);
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] expectedHashBytes = sha256.ComputeHash(bytes);
                string expectedHashString =
                    BitConverter.ToString(expectedHashBytes).Replace("-", "").ToLowerInvariant();
                string actualHashString = SignHelper.SHA256Hex(bytes);
                Assert.AreEqual(expectedHashString, actualHashString);
            }
        }

        [TestMethod]
        public void HmacSHA256_ReturnsCorrectHash()
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(SignKey);
            byte[] msgBytes = Encoding.UTF8.GetBytes(Secret);
            using (var hmacSha256 = new System.Security.Cryptography.HMACSHA256(keyBytes))
            {
                byte[] expectedHash = hmacSha256.ComputeHash(msgBytes);
                byte[] actualHash = SignHelper.HmacSHA256(keyBytes, msgBytes);
                CollectionAssert.AreEqual(expectedHash, actualHash);
            }
        }

        [TestMethod]
        public void MakeSignPlainText_ReturnsCorrectPlainText()
        {
            var requestParams = new SortedDictionary<string, string>
            {
                { "param2", "value2" },
                { "param1", "value1" }
            };
            string expected = $"{RequestMethod}{RequestHost}{RequestPath}?param1=value1&param2=value2";
            string actual = SignHelper.MakeSignPlainText(requestParams, RequestMethod, RequestHost, RequestPath);
            Assert.AreEqual(expected, actual);
        }
    }
}