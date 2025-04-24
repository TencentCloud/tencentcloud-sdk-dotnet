/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

using System;
using Cls;
using Google.Protobuf;
using TencentCloud.Cls.V20201016;
using TencentCloud.Cls.V20201016.Models;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloudExamples
{
    public class UploadLog
    {
        public static void Run(string[] args)
        {
            // 这里需要使用客户实际的topicId，不能输入topicname
            // 详情参考: https://cloud.tencent.com/document/product/614/59470
            string topicId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            // 需要根据客户的实际地域自行填写
            string region = "xx";

            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            ClientProfile clientProfile = new ClientProfile();
            HttpProfile httpProfile = new HttpProfile();
            // UploadLog 必须使用 POST 请求方法
            httpProfile.ReqMethod = "POST";
            clientProfile.HttpProfile = httpProfile;

            ClsClient client = new ClsClient(cred, region, clientProfile);

            UploadLogRequest req = new UploadLogRequest();

            req.TopicId = topicId;
            // 通过 OctetBody 来设置二进制数据
            req.OctetBody = BuildLogBody();

            UploadLogResponse resp = client.UploadLog(req).Result;

            // 输出json格式的字符串回包
            Console.WriteLine(AbstractModel.ToJsonString(resp));
        }


        static byte[] BuildLogBody()
        {
            Log log = new Log();
            log.Time = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();

            Log.Types.Content content = new Log.Types.Content();
            content.Key = "log-key";
            content.Value = "log-value";
            log.Contents.Add(content);

            LogGroup group = new LogGroup();

            LogGroupList list = new LogGroupList();
            list.LogGroupList_.Add(group);

            return list.ToByteArray();
        }
    }
}