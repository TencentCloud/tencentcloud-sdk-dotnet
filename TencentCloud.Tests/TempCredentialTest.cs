using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloud.Tests
{
    [TestClass]
    public class TempCredentialTest
    {
        [TestMethod]
        public void EmptyToken()
        {
            var reqMethods = new string[] { "GET", "POST" };
            var signMethods = new string[]
                { ClientProfile.SIGN_SHA1, ClientProfile.SIGN_SHA256, ClientProfile.SIGN_TC3SHA256 };
            var tokens = new string[] { "", null };

            var combinations =
                from reqMethod in reqMethods
                from signMethod in signMethods
                from token in tokens
                select new { reqMethod, signMethod, token };


            foreach (var c in combinations)
            {
                var cred = new Credential
                {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                    SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY"),
                    Token = c.token,
                };

                var cpf = new ClientProfile(c.signMethod)
                {
                    HttpProfile =
                    {
                        ReqMethod = c.reqMethod
                    }
                };

                var client = new CvmClient(cred, "ap-guangzhou", cpf);
                client.DescribeInstancesSync(new DescribeInstancesRequest());
            }
        }
    }
}