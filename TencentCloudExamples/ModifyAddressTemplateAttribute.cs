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

using System;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Vpc.V20170312;
using TencentCloud.Vpc.V20170312.Models;

namespace TencentCloudExamples
{
    public class ModifyAddressTemplateAttribute
    {
        public static void Run(string[] args)
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
                ModifyAddressTemplateAttributeResponse resp = client.ModifyAddressTemplateAttributeSync(req);
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
