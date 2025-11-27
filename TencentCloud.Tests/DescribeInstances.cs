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

using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloud.Tests
{
    [TestClass]
    public sealed class DescribeInstances
    {
        [TestMethod]
        public void TestDescribeInstances()
        {
            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            ClientProfile clientProfile = new ClientProfile();
            clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
            HttpProfile httpProfile = new HttpProfile();
            httpProfile.ReqMethod = "GET";
            httpProfile.Timeout = 10;
            httpProfile.Endpoint = "cvm.tencentcloudapi.com";
            httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

            clientProfile.HttpProfile = httpProfile;

            CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

            DescribeInstancesRequest req = new DescribeInstancesRequest();

            req.Limit = 1;
            Filter zoneFilter = new Filter();
            zoneFilter.Name = "zone";
            zoneFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
            Filter nameFilter = new Filter();
            nameFilter.Name = "instance-name";
            nameFilter.Values = new string[] { "中文测试" };
            req.Filters = new Filter[] { zoneFilter, nameFilter };

            DescribeInstancesResponse resp = client.DescribeInstances(req).ConfigureAwait(false).GetAwaiter()
                .GetResult();

            Console.WriteLine(AbstractModel.ToJsonString(resp));

            Console.WriteLine(resp.TotalCount);
        }

        [TestMethod]
        public void TestDescribeInstancesSync()
        {
            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            ClientProfile clientProfile = new ClientProfile();
            clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
            HttpProfile httpProfile = new HttpProfile();
            httpProfile.ReqMethod = "GET";
            httpProfile.Timeout = 10;
            httpProfile.Endpoint = "cvm.tencentcloudapi.com";
            httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

            clientProfile.HttpProfile = httpProfile;

            CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

            DescribeInstancesRequest req = new DescribeInstancesRequest();

            req.Limit = 1;
            Filter zoneFilter = new Filter();
            zoneFilter.Name = "zone";
            zoneFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
            Filter nameFilter = new Filter();
            nameFilter.Name = "instance-name";
            nameFilter.Values = new string[] { "中文测试" };
            req.Filters = new Filter[] { zoneFilter, nameFilter };

            DescribeInstancesResponse resp = client.DescribeInstancesSync(req);

            Console.WriteLine(AbstractModel.ToJsonString(resp));

            Console.WriteLine(resp.TotalCount);
        }
    }
}