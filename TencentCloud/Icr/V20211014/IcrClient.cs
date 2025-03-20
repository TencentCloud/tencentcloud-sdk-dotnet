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

namespace TencentCloud.Icr.V20211014
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Icr.V20211014.Models;

   public class IcrClient : AbstractClient{

       private const string endpoint = "icr.tencentcloudapi.com";
       private const string version = "2021-10-14";
       private const string sdkVersion = "SDK_NET_3.0.1204";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IcrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取成员列表接口
        /// </summary>
        /// <param name="req"><see cref="GetIndustryV1HomeMembersRequest"/></param>
        /// <returns><see cref="GetIndustryV1HomeMembersResponse"/></returns>
        public Task<GetIndustryV1HomeMembersResponse> GetIndustryV1HomeMembers(GetIndustryV1HomeMembersRequest req)
        {
            return InternalRequestAsync<GetIndustryV1HomeMembersResponse>(req, "GetIndustryV1HomeMembers");
        }

        /// <summary>
        /// 获取成员列表接口
        /// </summary>
        /// <param name="req"><see cref="GetIndustryV1HomeMembersRequest"/></param>
        /// <returns><see cref="GetIndustryV1HomeMembersResponse"/></returns>
        public GetIndustryV1HomeMembersResponse GetIndustryV1HomeMembersSync(GetIndustryV1HomeMembersRequest req)
        {
            return InternalRequestAsync<GetIndustryV1HomeMembersResponse>(req, "GetIndustryV1HomeMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
