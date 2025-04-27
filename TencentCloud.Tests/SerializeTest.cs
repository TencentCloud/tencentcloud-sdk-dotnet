using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;
using TencentCloud.Sms.V20210111;
using TencentCloud.Sms.V20210111.Models;

namespace TencentCloud.Tests
{
    [TestClass]
    public class SerializeTest
    {
        public class CustomContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName)
            {
                return propertyName.ToLower();
            }
        }

        [TestMethod]
        public void TestSerializeUnaffectedByDefaultSettings()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CustomContractResolver(),
            };

            var req = new SendSmsRequest();
            req.PhoneNumberSet = new[] { "test-number" };
            req.SmsSdkAppId = "test-app-id";
            req.TemplateId = "test-template-id";
            req.ExtendCode = null;

            var s = AbstractModel.ToJsonString(req);

            Assert.IsTrue(s.Contains("PhoneNumberSet"));
            Assert.IsTrue(s.Contains("SmsSdkAppId"));
            Assert.IsTrue(s.Contains("TemplateId"));
            Assert.IsFalse(s.Contains("ExtendCode"));

            Assert.IsFalse(s.Contains("phonenumberset"));
            Assert.IsFalse(s.Contains("smssdkappid"));
            Assert.IsFalse(s.Contains("templateid"));
            Assert.IsFalse(s.Contains("extendcode"));
        }
        
        [TestMethod]
        public void TestCommonSerializeUnaffectedByDefaultSettings()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CustomContractResolver(),
            };

            var req = new CommonRequest("{\"FieldA\": 0,\"FieldB\": null}");
            var s = req.Serialize();

            Assert.IsTrue(s.Contains("FieldA"));
            Assert.IsFalse(s.Contains("fielda"));
            
            Assert.IsTrue(s.Contains("FieldB"));
            Assert.IsFalse(s.Contains("fielda"));
        }

        [TestMethod]
        public void TestApiSerializeUnaffectedByDefaultSettings()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CustomContractResolver(),
            };

            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY"),
            };

            var clientProfile = new ClientProfile();

            var client = new SmsClient(cred, "ap-guangzhou", clientProfile);

            var req = new SendSmsRequest();
            req.PhoneNumberSet = new[] { "test-number" };
            req.SmsSdkAppId = "test-app-id";
            req.TemplateId = "test-template-id";

            try
            {
                client.SendSmsSync(req);
            }
            catch (TencentCloudSDKException e)
            {
                if (e.ErrorCode != "UnauthorizedOperation.SmsSdkAppIdVerifyFail")
                {
                    // unexpected error
                    throw;
                }
            }
        }

        [TestMethod]
        public void TestDeserializeUnaffectedByDefaultSettings()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error,
            };

            var val = AbstractModel.FromJsonString<DescribeRegionsResponse>(
                "{" +
                "   \"RegionSet\":[{}, {}]," +
                "   \"UnknownField\":0" +
                "}"
            );
            Assert.IsTrue(val.RegionSet != null);
            Assert.IsTrue(val.RegionSet.Length == 2);
            Assert.IsTrue(val.TotalCount == null);
        }

        [TestMethod]
        public void TestApiDeserializeUnaffectedByDefaultSettings()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CustomContractResolver(),
            };

            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY"),
            };

            var clientProfile = new ClientProfile();
            var client = new CvmClient(cred, "ap-guangzhou", clientProfile);

            var resp = client.DescribeRegionsSync(new DescribeRegionsRequest());
            Console.WriteLine(AbstractModel.ToJsonString(resp));
            Assert.IsTrue(resp.RegionSet != null);
            Assert.IsTrue(resp.TotalCount != null);
        }

        [TestMethod]
        public void TestSerializeIgnoreNull()
        {
            var req = new SendSmsRequest();
            req.PhoneNumberSet = new[] { "test-number" };
            req.ExtendCode = null;

            var s = AbstractModel.ToJsonString(req);

            Assert.IsTrue(s.Contains("PhoneNumberSet"));
            Assert.IsFalse(s.Contains("ExtendCode"));
        }
    }
}