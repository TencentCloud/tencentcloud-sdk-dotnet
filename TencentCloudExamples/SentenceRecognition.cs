using System;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Aai.V20180522;
using TencentCloud.Aai.V20180522.Models;
using System.IO;
using System.Collections.Generic;

namespace TencentCloudExamples
{
    class SentenceRecognition
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
                Credential cred = new Credential {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                    SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
                };               

                // 实例化一个client选项，可选的，没有特殊需求可以跳过
                ClientProfile clientProfile = new ClientProfile();
                // 指定签名算法(默认为HmacSHA256)
                clientProfile.SignMethod = ClientProfile.SIGN_SHA1;
                // 非必要步骤
                // 实例化一个客户端配置对象，可以指定超时时间等配置
                HttpProfile httpProfile = new HttpProfile();
                // SDK默认使用POST方法。
                // 如果你一定要使用GET方法，可以在这里设置。GET方法无法处理一些较大的请求。
                httpProfile.ReqMethod = "POST";
                // SDK有默认的超时时间，非必要请不要进行调整。
                // 如有需要请在代码中查阅以获取最新的默认值。
                httpProfile.Timeout = 10; // 请求连接超时时间，单位为秒(默认60秒)
                // SDK会自动指定域名。通常是不需要特地指定域名的，但是如果你访问的是金融区的服务，
                // 则必须手动指定域名，例如云服务器的上海金融区域名： aai.ap-shanghai-fsi.tencentcloudapi.com
                httpProfile.Endpoint = ("aai.tencentcloudapi.com");
                // 代理服务器，当你的环境下有代理服务器时设定
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

                clientProfile.HttpProfile = httpProfile;

                // 实例化要请求产品(以cvm为例)的client对象
                // 第二个参数是地域信息，可以直接填写字符串ap-guangzhou，或者引用预设的常量，clientProfile是可选的
                AaiClient client = new AaiClient(cred, "ap-guangzhou", clientProfile);

                // 实例化一个请求对象，根据调用的接口和实际情况，可以进一步设置请求参数
                // 你可以直接查询SDK源码确定DescribeInstancesRequest有哪些属性可以设置，
                // 属性可能是基本类型，也可能引用了另一个数据结构。
                // 推荐使用IDE进行开发，可以方便的跳转查阅各个接口和数据结构的文档说明。
                SentenceRecognitionRequest req = new SentenceRecognitionRequest();
                string path = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "test.mp3";
                FileStream fs = new FileStream(path, FileMode.Open);
                byte[] raw = new byte[fs.Length];
                fs.Read(raw, 0, raw.Length);
                string base64data = Convert.ToBase64String(raw);
                fs.Close();
                // 基本类型的设置。
                req.ProjectId = 0;
                req.SubServiceType = 2;
                req.EngSerViceType = "16k";
                req.SourceType = 1;
                req.VoiceFormat = "mp3";
                req.UsrAudioKey = "5c79510a12da-whatever";
                req.Data = base64data;
                req.DataLen = base64data.Length;
                // 数组类型的设置。

                // 复杂对象的设置。


                //// 这里还支持以标准json格式的string来赋值请求参数的方式。下面的代码跟上面的参数赋值是等效的
                //string strParams = "{\"Filters\":[{\"Name\":\"zone\",\"Values\":[\"ap-guangzhou-1\",\"ap-guangzhou-2\"]}]}";
                //req = DescribeInstancesRequest.FromJsonString<DescribeInstancesRequest>(strParams);

                // 通过client对象调用DescribeInstances方法发起请求。注意请求方法名与请求对象是对应的
                // 返回的resp是一个DescribeInstancesResponse类的实例，与请求对象对应
                SentenceRecognitionResponse resp = client.SentenceRecognition(req).
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
