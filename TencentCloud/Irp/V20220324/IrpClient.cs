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

namespace TencentCloud.Irp.V20220324
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Irp.V20220324.Models;

   public class IrpClient : AbstractClient{

       private const string endpoint = "irp.tencentcloudapi.com";
       private const string version = "2022-03-24";
       private const string sdkVersion = "SDK_NET_3.0.1207";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IrpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IrpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取推荐结果
        /// </summary>
        /// <param name="req"><see cref="RecommendContentRequest"/></param>
        /// <returns><see cref="RecommendContentResponse"/></returns>
        public Task<RecommendContentResponse> RecommendContent(RecommendContentRequest req)
        {
            return InternalRequestAsync<RecommendContentResponse>(req, "RecommendContent");
        }

        /// <summary>
        /// 获取推荐结果
        /// </summary>
        /// <param name="req"><see cref="RecommendContentRequest"/></param>
        /// <returns><see cref="RecommendContentResponse"/></returns>
        public RecommendContentResponse RecommendContentSync(RecommendContentRequest req)
        {
            return InternalRequestAsync<RecommendContentResponse>(req, "RecommendContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报行为
        /// </summary>
        /// <param name="req"><see cref="ReportActionRequest"/></param>
        /// <returns><see cref="ReportActionResponse"/></returns>
        public Task<ReportActionResponse> ReportAction(ReportActionRequest req)
        {
            return InternalRequestAsync<ReportActionResponse>(req, "ReportAction");
        }

        /// <summary>
        /// 上报行为
        /// </summary>
        /// <param name="req"><see cref="ReportActionRequest"/></param>
        /// <returns><see cref="ReportActionResponse"/></returns>
        public ReportActionResponse ReportActionSync(ReportActionRequest req)
        {
            return InternalRequestAsync<ReportActionResponse>(req, "ReportAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报物料
        /// </summary>
        /// <param name="req"><see cref="ReportMaterialRequest"/></param>
        /// <returns><see cref="ReportMaterialResponse"/></returns>
        public Task<ReportMaterialResponse> ReportMaterial(ReportMaterialRequest req)
        {
            return InternalRequestAsync<ReportMaterialResponse>(req, "ReportMaterial");
        }

        /// <summary>
        /// 上报物料
        /// </summary>
        /// <param name="req"><see cref="ReportMaterialRequest"/></param>
        /// <returns><see cref="ReportMaterialResponse"/></returns>
        public ReportMaterialResponse ReportMaterialSync(ReportMaterialRequest req)
        {
            return InternalRequestAsync<ReportMaterialResponse>(req, "ReportMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报用户画像
        /// </summary>
        /// <param name="req"><see cref="ReportPortraitRequest"/></param>
        /// <returns><see cref="ReportPortraitResponse"/></returns>
        public Task<ReportPortraitResponse> ReportPortrait(ReportPortraitRequest req)
        {
            return InternalRequestAsync<ReportPortraitResponse>(req, "ReportPortrait");
        }

        /// <summary>
        /// 上报用户画像
        /// </summary>
        /// <param name="req"><see cref="ReportPortraitRequest"/></param>
        /// <returns><see cref="ReportPortraitResponse"/></returns>
        public ReportPortraitResponse ReportPortraitSync(ReportPortraitRequest req)
        {
            return InternalRequestAsync<ReportPortraitResponse>(req, "ReportPortrait")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
