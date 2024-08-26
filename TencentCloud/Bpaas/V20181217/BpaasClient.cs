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

namespace TencentCloud.Bpaas.V20181217
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bpaas.V20181217.Models;

   public class BpaasClient : AbstractClient{

       private const string endpoint = "bpaas.tencentcloudapi.com";
       private const string version = "2018-12-17";
       private const string sdkVersion = "SDK_NET_3.0.1077";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BpaasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BpaasClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查看审批详情
        /// </summary>
        /// <param name="req"><see cref="GetBpaasApproveDetailRequest"/></param>
        /// <returns><see cref="GetBpaasApproveDetailResponse"/></returns>
        public Task<GetBpaasApproveDetailResponse> GetBpaasApproveDetail(GetBpaasApproveDetailRequest req)
        {
            return InternalRequestAsync<GetBpaasApproveDetailResponse>(req, "GetBpaasApproveDetail");
        }

        /// <summary>
        /// 查看审批详情
        /// </summary>
        /// <param name="req"><see cref="GetBpaasApproveDetailRequest"/></param>
        /// <returns><see cref="GetBpaasApproveDetailResponse"/></returns>
        public GetBpaasApproveDetailResponse GetBpaasApproveDetailSync(GetBpaasApproveDetailRequest req)
        {
            return InternalRequestAsync<GetBpaasApproveDetailResponse>(req, "GetBpaasApproveDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 外部审批申请单
        /// </summary>
        /// <param name="req"><see cref="OutApproveBpaasApplicationRequest"/></param>
        /// <returns><see cref="OutApproveBpaasApplicationResponse"/></returns>
        public Task<OutApproveBpaasApplicationResponse> OutApproveBpaasApplication(OutApproveBpaasApplicationRequest req)
        {
            return InternalRequestAsync<OutApproveBpaasApplicationResponse>(req, "OutApproveBpaasApplication");
        }

        /// <summary>
        /// 外部审批申请单
        /// </summary>
        /// <param name="req"><see cref="OutApproveBpaasApplicationRequest"/></param>
        /// <returns><see cref="OutApproveBpaasApplicationResponse"/></returns>
        public OutApproveBpaasApplicationResponse OutApproveBpaasApplicationSync(OutApproveBpaasApplicationRequest req)
        {
            return InternalRequestAsync<OutApproveBpaasApplicationResponse>(req, "OutApproveBpaasApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
