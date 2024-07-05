using System;
using Newtonsoft.Json;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Hunyuan.V20230901;
using TencentCloud.Hunyuan.V20230901.Models;

namespace TencentCloudExamples
{
    class ChatCompletions
    {
        static void MainOfChatCompletions(string[] args)
        {
            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            var cpf = new ClientProfile();

            var client = new HunyuanClient(cred, "ap-guangzhou", cpf);
            var req = new ChatCompletionsRequest
            {
                Messages = new[]
                {
                    new Message
                    {
                        Role = "user",
                        Content = "你好，可以讲个笑话吗",
                    }
                }
            };

            // hunyuan ChatCompletions/ChatPro 同时支持 stream 和非 stream 的情况
            req.Stream = true;

            var resp = client.ChatCompletionsSync(req);
            if (req.Stream.HasValue && req.Stream.Value)
            {
                // stream 示例
                foreach (var e in resp)
                    Console.WriteLine(e.Data);
            }
            else
            {
                // 非 stream 示例
                // 通过 Stream=false 参数来指定非 stream 协议, 一次性拿到结果
                Console.WriteLine(JsonConvert.SerializeObject(resp));
            }
        }
    }
}
