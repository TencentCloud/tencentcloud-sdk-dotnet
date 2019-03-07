using System;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloudExamples
{
    class DescribeInstances
    {
        static void Main(string[] args)
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
                clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
                // 非必要步骤
                // 实例化一个客户端配置对象，可以指定超时时间等配置
                HttpProfile httpProfile = new HttpProfile();
                // SDK默认使用POST方法。
                // 如果你一定要使用GET方法，可以在这里设置。GET方法无法处理一些较大的请求。
                httpProfile.ReqMethod = "GET";
                // SDK有默认的超时时间，非必要请不要进行调整。
                // 如有需要请在代码中查阅以获取最新的默认值。
                httpProfile.Timeout = 10; // 请求连接超时时间，单位为秒(默认60秒)
                // SDK会自动指定域名。通常是不需要特地指定域名的，但是如果你访问的是金融区的服务，
                // 则必须手动指定域名，例如云服务器的上海金融区域名： cvm.ap-shanghai-fsi.tencentcloudapi.com
                httpProfile.Endpoint = "cvm.tencentcloudapi.com";
                // 代理服务器，当你的环境下有代理服务器时设定
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

                clientProfile.HttpProfile = httpProfile;

                // 实例化要请求产品(以cvm为例)的client对象
                // 第二个参数是地域信息，可以直接填写字符串ap-guangzhou，或者引用预设的常量，clientProfile是可选的
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // 实例化一个请求对象，根据调用的接口和实际情况，可以进一步设置请求参数
                // 你可以直接查询SDK源码确定DescribeInstancesRequest有哪些属性可以设置，
                // 属性可能是基本类型，也可能引用了另一个数据结构。
                // 推荐使用IDE进行开发，可以方便的跳转查阅各个接口和数据结构的文档说明。
                DescribeInstancesRequest req = new DescribeInstancesRequest();
              
                // 基本类型的设置。
                // 此接口允许设置返回的实例数量。此处指定为只返回一个。
                // SDK采用的是指针风格指定参数，即使对于基本类型你也需要用指针来对参数赋值。
                // SDK提供对基本类型的指针引用封装函数
                req.Limit = 1;
                // 数组类型的设置。
                // 此接口允许指定实例 ID 进行过滤，但是由于和接下来要演示的 Filter 参数冲突，先注释掉。
                // req.InstanceIds = new string[] { "ins-r8hr2upy" };

                // 复杂对象的设置。
                // 在这个接口中，Filters是数组，数组的元素是复杂对象Filter，Filter的成员Values是string数组。
                // 填充请求参数,这里request对象的成员变量即对应接口的入参
                // 你可以通过官网接口文档或跳转到request对象的定义处查看请求参数的定义
                Filter zoneFilter = new Filter(); // 创建Filter对象, 以zone的维度来查询cvm实例
                zoneFilter.Name = "zone";
                zoneFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
                Filter nameFilter = new Filter();
                nameFilter.Name = "instance-name";
                nameFilter.Values = new string[] { "中文测试" };
                req.Filters = new Filter[] { zoneFilter, nameFilter }; // Filters 是成员为Filter对象的列表

                //// 这里还支持以标准json格式的string来赋值请求参数的方式。下面的代码跟上面的参数赋值是等效的
                //string strParams = "{\"Filters\":[{\"Name\":\"zone\",\"Values\":[\"ap-guangzhou-1\",\"ap-guangzhou-2\"]}]}";
                //req = DescribeInstancesRequest.FromJsonString<DescribeInstancesRequest>(strParams);

                // 通过client对象调用DescribeInstances方法发起请求。注意请求方法名与请求对象是对应的
                // 返回的resp是一个DescribeInstancesResponse类的实例，与请求对象对应
                DescribeInstancesResponse resp = client.DescribeInstances(req).
                    ConfigureAwait(false).GetAwaiter().GetResult();

                // 输出json格式的字符串回包
                Console.WriteLine(AbstractModel.ToJsonString(resp));

                // 也可以取出单个值。
                // 你可以通过官网接口文档或跳转到response对象的定义处查看返回字段的定义
                Console.WriteLine(resp.TotalCount);
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }
    }
}
