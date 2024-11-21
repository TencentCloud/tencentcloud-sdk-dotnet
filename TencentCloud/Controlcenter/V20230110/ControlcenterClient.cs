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

namespace TencentCloud.Controlcenter.V20230110
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Controlcenter.V20230110.Models;

   public class ControlcenterClient : AbstractClient{

       private const string endpoint = "controlcenter.tencentcloudapi.com";
       private const string version = "2023-01-10";
       private const string sdkVersion = "SDK_NET_3.0.1126";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ControlcenterClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ControlcenterClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 批量对存量账号应用基线
        /// </summary>
        /// <param name="req"><see cref="BatchApplyAccountBaselinesRequest"/></param>
        /// <returns><see cref="BatchApplyAccountBaselinesResponse"/></returns>
        public Task<BatchApplyAccountBaselinesResponse> BatchApplyAccountBaselines(BatchApplyAccountBaselinesRequest req)
        {
            return InternalRequestAsync<BatchApplyAccountBaselinesResponse>(req, "BatchApplyAccountBaselines");
        }

        /// <summary>
        /// 批量对存量账号应用基线
        /// </summary>
        /// <param name="req"><see cref="BatchApplyAccountBaselinesRequest"/></param>
        /// <returns><see cref="BatchApplyAccountBaselinesResponse"/></returns>
        public BatchApplyAccountBaselinesResponse BatchApplyAccountBaselinesSync(BatchApplyAccountBaselinesRequest req)
        {
            return InternalRequestAsync<BatchApplyAccountBaselinesResponse>(req, "BatchApplyAccountBaselines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
