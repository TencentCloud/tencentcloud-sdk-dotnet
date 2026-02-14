/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloud.Tests
{
    [TestClass]
    public sealed class CommonClient
    {
        [TestMethod]
        public async Task TestJsonStrRequest()
        {
            var client = CreateClient();

            var limit = 1;
            var filterName = "zone";
            var filterValue = "ap-guangzhou-1";
            var reqJson = $@"
    {{
        ""Limit"": {limit},
        ""Filters"": [
            {{
                ""Name"": ""{filterName}"",
                ""Values"":[""{filterValue}""]
            }}
        ]
    }}
";
            var rep = await client.CallAsync(new CommonRequest(reqJson), "DescribeInstances");
            Console.WriteLine(rep);
        }

        static async Task TestDictionaryRequest(TencentCloud.Common.CommonClient client)
        {
            var reqDict = new Dictionary<string, object>
            {
                { "Limit", 1 },
                {
                    "Filters", new List<object>
                    {
                        new Dictionary<string, object>
                        {
                            { "Name", "zone" },
                            { "Values", new List<string> { "ap-guangzhou-1" } }
                        }
                    }
                }
            };
            var rep = await client.CallAsync(new CommonRequest(reqDict), "DescribeInstances");
            Console.WriteLine(rep);
        }


        class DescribeInstancesReq
        {
            internal class Filter
            {
                public string Name;
                public string[] Values;
            }

            public string[] InstanceIds;
            public Filter[] Filters;
            public int Offset;
            public int Limit;
        }

        [TestMethod]
        public async Task TestCustomRequest()
        {
            var client = CreateClient();
            var req = new CommonRequest(
                new DescribeInstancesReq
                {
                    Filters = new[]
                    {
                        new DescribeInstancesReq.Filter
                        {
                            Name = "zone",
                            Values = new[] { "ap-guangzhou-1" }
                        }
                    },
                    Limit = 5,
                    Offset = 0,
                }
            );

            var rep = await client.CallAsync(req, "DescribeInstances");
            Console.WriteLine(rep);
        }

        class DescribeInstancesRep
        {
            public string RequestId;
            public int TotalCount;
            public JArray ZoneSet;
        }

        [TestMethod]
        public async Task TestCustomResponse()
        {
            var client = CreateClient();
            var req = new CommonRequest("{}");
            var rep = await client.CallAsync<DescribeInstancesRep>(req, "DescribeZones");
            Console.WriteLine(JsonConvert.SerializeObject(rep));
        }

        private TencentCloud.Common.CommonClient CreateClient()
        {
            // 必要步骤：
            // 实例化一个认证对象，入参需要传入腾讯云账户密钥对secretId，secretKey。
            // 这里采用的是从环境变量读取的方式，需要在环境变量中先设置这两个值。
            // 你也可以直接在代码中写死密钥对，但是小心不要将代码复制、上传或者分享给他人，
            // 以免泄露密钥对危及你的财产安全。
            var cred = new Credential
            {
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
            return new TencentCloud.Common.CommonClient(
                "cvm", "2017-03-12", cred, "ap-guangzhou", clientProfile);
        }

        [JsonConverter(typeof(Converter))]
        public class CustomSSEResponse : AbstractSSEModel
        {
            public string Response;

            private class Converter : JsonConverter
            {
                public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
                {
                    serializer.Serialize(writer, value);
                }

                public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                    JsonSerializer serializer)
                {
                    var resp = new CustomSSEResponse();
                    var jObject = JObject.Load(reader);
                    resp.Response = jObject.ToString();
                    return resp;
                }

                public override bool CanConvert(Type objectType)
                {
                    return objectType == typeof(CustomSSEResponse);
                }
            }
        }

        [TestMethod]
        public void TestSSEStream()
        {
            var mod = "hunyuan";
            var ver = "2023-09-01";
            var act = "ChatCompletions";
            var region = "";
            var endpoint = "hunyuan.tencentcloudapi.com";

            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY"),
            };

            var hpf = new HttpProfile
            {
                ReqMethod = "POST",
                Endpoint = endpoint,
            };
            var cpf = new ClientProfile(ClientProfile.SIGN_TC3SHA256, hpf);

            var client = new TencentCloud.Common.CommonClient(mod, ver, cred, region, cpf);
            var param = new Dictionary<string, object>
            {
                { "Model", "hunyuan-standard" },
                {
                    "Messages",
                    new object[] { new Dictionary<string, string> { { "Role", "user" }, { "Content", "hi" } } }
                },
                { "Stream", true },
            };

            var req = new CommonRequest(param);
            var resp = client.CallAsync<CustomSSEResponse>(req, act).Result;
            Assert.IsTrue(resp.IsStream);
            foreach (var e in resp)
                Console.WriteLine(e.Data);
        }

        [TestMethod]
        public void TestSSENonStream()
        {
            var mod = "hunyuan";
            var ver = "2023-09-01";
            var act = "ChatCompletions";
            var region = "";
            var endpoint = "hunyuan.tencentcloudapi.com";

            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY"),
            };

            var hpf = new HttpProfile
            {
                ReqMethod = "POST",
                Endpoint = endpoint,
            };
            var cpf = new ClientProfile(ClientProfile.SIGN_TC3SHA256, hpf);

            var client = new TencentCloud.Common.CommonClient(mod, ver, cred, region, cpf);
            var param = new Dictionary<string, object>
            {
                { "Model", "hunyuan-standard" },
                {
                    "Messages",
                    new object[] { new Dictionary<string, string> { { "Role", "user" }, { "Content", "hi" } } }
                },
                { "Stream", false },
            };

            var req = new CommonRequest(param);
            var resp = client.CallAsync<CustomSSEResponse>(req, act).Result;
            Assert.IsFalse(resp.IsStream);
            Console.WriteLine(resp.Response);
        }
    }
}