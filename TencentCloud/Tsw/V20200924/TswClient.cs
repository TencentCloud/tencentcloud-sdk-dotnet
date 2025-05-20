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

namespace TencentCloud.Tsw.V20200924
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tsw.V20200924.Models;

   public class TswClient : AbstractClient{

       private const string endpoint = "tsw.tencentcloudapi.com";
       private const string version = "2020-09-24";
       private const string sdkVersion = "SDK_NET_3.0.1244";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TswClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TswClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取服务接入信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentShellRequest"/></param>
        /// <returns><see cref="DescribeAgentShellResponse"/></returns>
        public Task<DescribeAgentShellResponse> DescribeAgentShell(DescribeAgentShellRequest req)
        {
            return InternalRequestAsync<DescribeAgentShellResponse>(req, "DescribeAgentShell");
        }

        /// <summary>
        /// 获取服务接入信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentShellRequest"/></param>
        /// <returns><see cref="DescribeAgentShellResponse"/></returns>
        public DescribeAgentShellResponse DescribeAgentShellSync(DescribeAgentShellRequest req)
        {
            return InternalRequestAsync<DescribeAgentShellResponse>(req, "DescribeAgentShell")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
