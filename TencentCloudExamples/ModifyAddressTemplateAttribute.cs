using System;
using System.Collections.Generic;
using System.Text;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Vpc.V20170312;
using TencentCloud.Vpc.V20170312.Models;

namespace TencentCloudExamples
{
    class ModifyAddressTemplateAttribute
    {
        static void Main1(string[] args)
        {
            try
            {
                Credential cred = new Credential
                {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                    SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
                };
                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                // 代理服务器，当你的环境下有代理服务器时设定
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");
                clientProfile.HttpProfile = httpProfile;
                VpcClient client = new VpcClient(cred, "ap-guangzhou", clientProfile);

                ModifyAddressTemplateAttributeRequest req = new ModifyAddressTemplateAttributeRequest();
                req.Addresses = new string[] { "eip-hxlqja90" };
                req.AddressTemplateId = "ipm-mdunqeb6";
                req.AddressTemplateName = "TestName";
                ModifyAddressTemplateAttributeResponse resp = client.ModifyAddressTemplateAttribute(req).
                    ConfigureAwait(false).GetAwaiter().GetResult();
                Console.WriteLine(AbstractModel.ToJsonString(resp));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }
    }
}
