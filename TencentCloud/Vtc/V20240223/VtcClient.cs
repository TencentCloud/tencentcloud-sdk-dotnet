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

namespace TencentCloud.Vtc.V20240223
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vtc.V20240223.Models;

   public class VtcClient : AbstractClient{

       private const string endpoint = "vtc.tencentcloudapi.com";
       private const string version = "2024-02-23";
       private const string sdkVersion = "SDK_NET_3.0.1020";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VtcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VtcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 确认视频翻译结果
        /// </summary>
        /// <param name="req"><see cref="ConfirmVideoTranslateJobRequest"/></param>
        /// <returns><see cref="ConfirmVideoTranslateJobResponse"/></returns>
        public Task<ConfirmVideoTranslateJobResponse> ConfirmVideoTranslateJob(ConfirmVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<ConfirmVideoTranslateJobResponse>(req, "ConfirmVideoTranslateJob");
        }

        /// <summary>
        /// 确认视频翻译结果
        /// </summary>
        /// <param name="req"><see cref="ConfirmVideoTranslateJobRequest"/></param>
        /// <returns><see cref="ConfirmVideoTranslateJobResponse"/></returns>
        public ConfirmVideoTranslateJobResponse ConfirmVideoTranslateJobSync(ConfirmVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<ConfirmVideoTranslateJobResponse>(req, "ConfirmVideoTranslateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询视频翻译任务
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoTranslateJobRequest"/></param>
        /// <returns><see cref="DescribeVideoTranslateJobResponse"/></returns>
        public Task<DescribeVideoTranslateJobResponse> DescribeVideoTranslateJob(DescribeVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoTranslateJobResponse>(req, "DescribeVideoTranslateJob");
        }

        /// <summary>
        /// 查询视频翻译任务
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoTranslateJobRequest"/></param>
        /// <returns><see cref="DescribeVideoTranslateJobResponse"/></returns>
        public DescribeVideoTranslateJobResponse DescribeVideoTranslateJobSync(DescribeVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoTranslateJobResponse>(req, "DescribeVideoTranslateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交视频转译任务
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoTranslateJobRequest"/></param>
        /// <returns><see cref="SubmitVideoTranslateJobResponse"/></returns>
        public Task<SubmitVideoTranslateJobResponse> SubmitVideoTranslateJob(SubmitVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoTranslateJobResponse>(req, "SubmitVideoTranslateJob");
        }

        /// <summary>
        /// 提交视频转译任务
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoTranslateJobRequest"/></param>
        /// <returns><see cref="SubmitVideoTranslateJobResponse"/></returns>
        public SubmitVideoTranslateJobResponse SubmitVideoTranslateJobSync(SubmitVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoTranslateJobResponse>(req, "SubmitVideoTranslateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
