/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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
using TencentCloud.Cls.V20201016;
using TencentCloud.Cls.V20201016.Models;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloudExamples
{
    public class ClsChatCompletions
    {
        public static void Run(string[] args)
        {
            Credential cred = new Credential
            {
                SecretId = System.Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = System.Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            var cpf = new ClientProfile();
            // 流式接口可能耗时较长，因此将请求超时时间设置为 300 秒
            cpf.HttpProfile.Timeout = 300;
            // 通过 SSE 流式调用此接口时，请务必设置请求域名（Endpoint）为 cls.ai.tencentcloudapi.com
            cpf.HttpProfile.Endpoint = "cls.ai.tencentcloudapi.com";

            var client = new ClsClient(cred, "ap-guangzhou", cpf);

            // 2. 构造公共请求参数
            var reqParams = new ChatCompletionsRequest
            {
                // 指定要使用的功能，例如 "text2sql"
                Model = "text2sql",
                // 设置对话消息，角色为 "user"，内容为用户的提问
                Messages = new[]
                {
                    new Message
                    {
                        Role = "user",
                        Content = "状态码200, 统计日志条数",
                    }
                },
                // 设置元数据，传递日志主题地域和日志主题 ID
                Metadata = new[]
                {
                    new MetadataItem
                    {
                        Key = "topic_region",
                        Value = "ap-guangzhou"
                    },
                    new MetadataItem
                    {
                        Key = "topic_id",
                        Value = "xxxxxxxx-xxxx"
                    }
                }
            };

            // 3. 流式调用
            // CLS ChatCompletions 同时支持流式和非流式两种模式。
            // 将 Stream 参数设置为 true，表示以流式方式获取响应。
            reqParams.Stream = true;
            try
            {
                using (var resp = client.ChatCompletionsSync(reqParams))
                {
                    foreach (var e in resp)
                    {
                        // 跳过心跳等 data 为空的事件（如服务端每隔一段时间发送的 :heartbeat 注释）
                        if (string.IsNullOrEmpty(e.Data)) continue;
                        // 服务端通过 event: error 返回应用层错误
                        if (e.Event?.Trim() == "error")
                        {
                            var err = JsonConvert.DeserializeObject<dynamic>(e.Data);
                            System.Console.Error.WriteLine("\n[流式] error: " + err?.Response?.Error);
                            break;
                        }

                        var data = JsonConvert.DeserializeObject<ChatCompletionsResponse>(e.Data);
                        if (data?.Choices == null) continue;

                        foreach (var choice in data.Choices)
                        {
                            // 实时输出思考过程（ReasoningContent）
                            if (!string.IsNullOrEmpty(choice.Delta?.ReasoningContent))
                            {
                                System.Console.Write(choice.Delta.ReasoningContent);
                            }
                            // 实时输出回复内容（Content）
                            if (!string.IsNullOrEmpty(choice.Delta?.Content))
                            {
                                System.Console.Write(choice.Delta.Content);
                            }
                        }
                    }
                    System.Console.WriteLine();
                }
            }
            catch (System.Exception e)
            {
                System.Console.Error.WriteLine("[流式] error " + e.Message);
            }
            System.Console.WriteLine("[流式] 完成，开始非流式调用...");

            // 4. 非流式调用
            // 通过 Stream=false 参数来指定非 stream 协议，一次性拿到结果。
            reqParams.Stream = false;
            try
            {
                using (var resp = client.ChatCompletionsSync(reqParams))
                {
                    if (!string.IsNullOrEmpty(resp.Choices[0].Message?.ReasoningContent))
                    {
                        System.Console.WriteLine("思考过程：" + resp.Choices[0].Message.ReasoningContent);
                    }
                    System.Console.WriteLine("[非流式] 回复内容：\n" + resp.Choices[0].Message?.Content);
                }
            }
            catch (System.Exception e)
            {
                System.Console.Error.WriteLine("[非流式] error " + e.Message);
            }
        }
    }
}
