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

namespace TencentCloud.Cim.V20190318
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cim.V20190318.Models;

   public class CimClient : AbstractClient{

       private const string endpoint = "cim.tencentcloudapi.com";
       private const string version = "2019-03-18";
       private const string sdkVersion = "SDK_NET_3.0.1048";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CimClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CimClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取云通信IM中腾讯云账号对应的SDKAppID
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppidRequest"/></param>
        /// <returns><see cref="DescribeSdkAppidResponse"/></returns>
        public Task<DescribeSdkAppidResponse> DescribeSdkAppid(DescribeSdkAppidRequest req)
        {
            return InternalRequestAsync<DescribeSdkAppidResponse>(req, "DescribeSdkAppid");
        }

        /// <summary>
        /// 获取云通信IM中腾讯云账号对应的SDKAppID
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppidRequest"/></param>
        /// <returns><see cref="DescribeSdkAppidResponse"/></returns>
        public DescribeSdkAppidResponse DescribeSdkAppidSync(DescribeSdkAppidRequest req)
        {
            return InternalRequestAsync<DescribeSdkAppidResponse>(req, "DescribeSdkAppid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
