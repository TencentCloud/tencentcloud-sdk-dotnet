using TencentCloud.Cbs.V20170312;
using TencentCloud.Cbs.V20170312.Models;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;
using TencentCloud.Faceid.V20180301;
using TencentCloud.Faceid.V20180301.Models;
using TencentCloud.Iai.V20200303.Models;
using TencentCloud.Iai.V20200303;
using TencentCloud.Scf.V20180416;
using TencentCloud.Scf.V20180416.Models;
using Environment = System.Environment;
using Filter = TencentCloud.Cbs.V20170312.Models.Filter;

namespace TencentCloud.Tests
{
    [TestClass]
    public class DataTypeTest
    {
        [TestMethod]
        public void TestIntType()
        {
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };
            var cpf = new ClientProfile();
            var client = new CvmClient(cred, "ap-guangzhou", cpf);

            var req = new DescribeInstancesRequest
            {
                Limit = -1
            };

            try
            {
                client.DescribeInstancesSync(req);
                Assert.Fail("unexpected success");
            }
            catch (TencentCloudSDKException e)
            {
                Assert.IsTrue(e.ErrorCode.Contains("InvalidParameterValue"));
            }
        }

        [TestMethod]
        public void TestUintAndStringAndNestType()
        {
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };
            var cpf = new ClientProfile();
            var client = new CbsClient(cred, "ap-guangzhou", cpf);
            var req = new DescribeSnapshotsRequest
            {
                Filters = new[]
                {
                    new Filter
                    {
                        Name = "snapshot-name",
                        Values = new[] { "" },
                    },
                    new Filter
                    {
                        Name = "snapshot-id",
                        Values = new[] { "" },
                    },
                },
            };
            try
            {
                client.DescribeSnapshotsSync(req);
                Assert.Fail("unexpected success");
            }
            catch (TencentCloudSDKException e)
            {
                Assert.IsTrue(e.ErrorCode.Contains("InvalidParameter"));
            }
        }

        [TestMethod]
        public void TestBoolAndDatetimeIsoType()
        {
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };
            var cpf = new ClientProfile();
            var client = new CbsClient(cred, "ap-guangzhou", cpf);
            var req = new ModifySnapshotAttributeRequest
            {
                SnapshotId = "",
                SnapshotName = "",
                IsPermanent = false,
                Deadline = "2021-05-22T09:00:00Z",
            };
            try
            {
                client.ModifySnapshotAttributeSync(req);
                Assert.Fail("unexpected success");
            }
            catch (TencentCloudSDKException e)
            {
                Assert.IsTrue(e.ErrorCode.Contains("InvalidParameter"));
            }
        }

        [TestMethod]
        public void TestDatetimeType()
        {
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };
            var cpf = new ClientProfile();
            var client = new ScfClient(cred, "ap-guangzhou", cpf);
            var req = new GetFunctionLogsRequest
            {
                StartTime = "2021-05-21 11:00:00",
                EndTime = "2021-05-21 11:00:00",
            };
            client.GetFunctionLogsSync(req);
        }

        [TestMethod]
        public void TestFloatType()
        {
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };
            var cpf = new ClientProfile();
            var client = new IaiClient(cred, "ap-guangzhou", cpf);
            var req = new SearchFacesRequest
            {
                GroupIds = new[] { "test" },
                Url = "https://www.test.com",
                FaceMatchThreshold = 0.2f,
            };
            try
            {
                client.SearchFacesSync(req);
                Assert.Fail("unexpected success");
            }
            catch (TencentCloudSDKException e)
            {
                Assert.IsTrue(e.ErrorCode.Contains("InvalidParameter"));
            }
        }

        [TestMethod]
        public void TestComplexType()
        {
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };
            var cpf = new ClientProfile();
            var client = new FaceidClient(cred, "ap-guangzhou", cpf);
            var req = new MobileStatusRequest
            {
                Mobile = "null",
                Encryption = new Encryption
                {
                    CiphertextBlob = "null",
                    EncryptList = new[] { "null", "null" },
                    Iv = "null",
                },
            };
            try
            {
                client.MobileStatusSync(req);
                Assert.Fail("unexpected success");
            }
            catch (TencentCloudSDKException e)
            {
                Assert.IsTrue(e.ErrorCode.Contains("UnauthorizedOperation.Nonactivated"));
            }
        }
    }
}