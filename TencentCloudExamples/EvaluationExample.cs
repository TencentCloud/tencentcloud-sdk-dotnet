using System;
using System.Collections.Generic;
using System.Text;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Hcm.V20181106;
using TencentCloud.Hcm.V20181106.Models;

namespace TencentCloudExamples
{
    class DescribeZones
    {
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
                HcmClient client = new HcmClient(cred, "ap-guangzhou", clientProfile);

                // 实例化一个请求对象，根据调用的接口和实际情况，可以进一步设置请求参数
                // 你可以直接查询SDK源码确定DescribeZonesRequest有哪些属性可以设置，
                // 属性可能是基本类型，也可能引用了另一个数据结构。
                // 推荐使用IDE进行开发，可以方便的跳转查阅各个接口和数据结构的文档说明。
                EvaluationRequest req = new EvaluationRequest();
                req.SessionId = "123456";
                req.Image = "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";
                req.HcmAppId = "";
                req.Url = "";

                // 通过client对象调用DescribeInstances方法发起请求。注意请求方法名与请求对象是对应的
                // 返回的resp是一个DescribeInstancesResponse类的实例，与请求对象对应
                EvaluationResponse resp = client.Evaluation(req).
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
