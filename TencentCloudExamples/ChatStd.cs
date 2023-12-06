using System;
using Newtonsoft.Json;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Hunyuan.V20230901;
using TencentCloud.Hunyuan.V20230901.Models;

namespace TencentCloudExamples
{
    class ChatStd
    {
        static void MainOfChatStd(string[] args)
        {
            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            var cpf = new ClientProfile();

            var client = new HunyuanClient(cred, "ap-guangzhou", cpf);
            var req = new ChatStdRequest
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

            var resp = client.ChatStdSync(req);
            foreach (var e in resp)
            {
                Console.WriteLine(e.Data);
            }
        }
    }
}