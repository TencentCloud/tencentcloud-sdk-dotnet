using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloud.Tests
{
    [TestClass]
    public class SignMethodTest
    {
        [TestMethod]
        public void TestCvmClient()
        {
            var signMethods = new[]
            {
                ClientProfile.SIGN_SHA1,
                ClientProfile.SIGN_SHA256,
                ClientProfile.SIGN_TC3SHA256,
            };
            var reqMethods = new[]
            {
                HttpProfile.REQ_GET,
                HttpProfile.REQ_POST,
            };

            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            foreach (var signMethod in signMethods)
            {
                foreach (var reqMethod in reqMethods)
                {
                    var cpf = new ClientProfile
                    {
                        SignMethod = signMethod,
                        HttpProfile = new HttpProfile { ReqMethod = reqMethod },
                    };
                    var client = new CvmClient(cred, "ap-guangzhou", cpf);

                    var req = new DescribeInstancesRequest();
                    Console.WriteLine(client.DescribeInstances(req).Result);
                    Console.WriteLine(client.DescribeInstancesSync(req));
                }
            }
        }

        [TestMethod]
        public void TestCommonClient()
        {
            var signMethods = new[]
            {
                ClientProfile.SIGN_SHA1,
                ClientProfile.SIGN_SHA256,
                ClientProfile.SIGN_TC3SHA256,
            };
            var reqMethods = new[]
            {
                HttpProfile.REQ_GET,
                HttpProfile.REQ_POST,
            };

            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            foreach (var signMethod in signMethods)
            {
                foreach (var reqMethod in reqMethods)
                {
                    var cpf = new ClientProfile
                    {
                        SignMethod = signMethod,
                        HttpProfile = new HttpProfile { ReqMethod = reqMethod },
                    };
                    var client = new TencentCloud.Common.CommonClient("cvm", "2017-03-12", cred, "ap-guangzhou", cpf);

                    Console.WriteLine(client.Call(new CommonRequest("{}"), "DescribeInstances"));
                    Console.WriteLine(client.CallAsync(new CommonRequest("{}"), "DescribeInstances").Result);
                }
            }
        }
    }
}