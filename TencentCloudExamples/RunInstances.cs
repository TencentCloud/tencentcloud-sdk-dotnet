using System;
using System.Collections.Generic;
using System.Text;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloudExamples
{
    class RunInstances
    {
        // 该示例要运行成功，需要修改一些网络和安全组的设置。
        // 请慎重运行该示例，因为创建成功后会产生扣费。
        static void Main1(string[] args)
        {
            try
            {
                // 必要步骤：
                // 实例化一个认证对象，入参需要传入腾讯云账户密钥对secretId，secretKey。
                // 这里采用的是从环境变量读取的方式，需要在环境变量中先设置这两个值。
                // 你也可以直接在代码中写死密钥对，但是小心不要将代码复制、上传或者分享给他人，
                // 以免泄露密钥对危及你的财产安全。
                Credential cred = new Credential
                {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                    SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
                };

                // 实例化一个client选项，可选的，没有特殊需求可以跳过
                ClientProfile clientProfile = new ClientProfile();
                // 非必要步骤
                // 实例化一个客户端配置对象，可以指定超时时间等配置
                HttpProfile httpProfile = new HttpProfile();
                // 代理服务器，当你的环境下有代理服务器时设定
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

                clientProfile.HttpProfile = httpProfile;

                // 实例化要请求产品(以cvm为例)的client对象
                // 第二个参数是地域信息，可以直接填写字符串ap-guangzhou，或者引用预设的常量，clientProfile是可选的
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // 实例化一个请求对象，根据调用的接口和实际情况，可以进一步设置请求参数
                // 你可以直接查询SDK源码确定DescribeZonesRequest有哪些属性可以设置，
                // 属性可能是基本类型，也可能引用了另一个数据结构。
                // 推荐使用IDE进行开发，可以方便的跳转查阅各个接口和数据结构的文档说明。
                RunInstancesRequest req = new RunInstancesRequest();

                Placement placement = new Placement();
                placement.Zone = "ap-guangzhou-3";
                req.Placement = placement;

                req.ImageId = "img-8toqc6s3";
                req.InstanceChargeType = "POSTPAID_BY_HOUR";
                req.InstanceName = "DOTNET_SDK_TEST";
                req.InstanceType = "S2.SMALL1";

                InternetAccessible ia = new InternetAccessible();
                ia.InternetChargeType = "BANDWIDTH_POSTPAID_BY_HOUR";
                ia.InternetMaxBandwidthOut = 10;
                ia.PublicIpAssigned = true;
                req.InternetAccessible = ia;

                LoginSettings ls = new LoginSettings();
                ls.Password = "passw0rdExample";
                req.LoginSettings = ls;

                req.SecurityGroupIds = new string[] { "sg-icy671l9" };

                SystemDisk sd = new SystemDisk();
                sd.DiskSize = 50;
                sd.DiskType = "CLOUD_BASIC";
                req.SystemDisk = sd;

                VirtualPrivateCloud vpc = new VirtualPrivateCloud();
                vpc.VpcId = "vpc-8ek64x3d"; 
                vpc.SubnetId = "subnet-b1wk8b10";
                req.VirtualPrivateCloud = vpc;

                // 通过client对象调用DescribeInstances方法发起请求。注意请求方法名与请求对象是对应的
                // 返回的resp是一个DescribeInstancesResponse类的实例，与请求对象对应
                RunInstancesResponse resp = client.RunInstances(req).
                    ConfigureAwait(false).GetAwaiter().GetResult();

                // 输出json格式的字符串回包
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
