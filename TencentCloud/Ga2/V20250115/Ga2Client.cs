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

namespace TencentCloud.Ga2.V20250115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ga2.V20250115.Models;

   public class Ga2Client : AbstractClient{

       private const string endpoint = "ga2.tencentcloudapi.com";
       private const string version = "2025-01-15";
       private const string sdkVersion = "SDK_NET_3.0.1390";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public Ga2Client(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public Ga2Client(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询跨境账单
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderSettlementRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderSettlementResponse"/></returns>
        public Task<DescribeCrossBorderSettlementResponse> DescribeCrossBorderSettlement(DescribeCrossBorderSettlementRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderSettlementResponse>(req, "DescribeCrossBorderSettlement");
        }

        /// <summary>
        /// 查询跨境账单
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderSettlementRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderSettlementResponse"/></returns>
        public DescribeCrossBorderSettlementResponse DescribeCrossBorderSettlementSync(DescribeCrossBorderSettlementRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderSettlementResponse>(req, "DescribeCrossBorderSettlement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
