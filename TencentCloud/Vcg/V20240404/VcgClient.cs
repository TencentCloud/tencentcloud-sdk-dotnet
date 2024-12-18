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

namespace TencentCloud.Vcg.V20240404
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vcg.V20240404.Models;

   public class VcgClient : AbstractClient{

       private const string endpoint = "vcg.tencentcloudapi.com";
       private const string version = "2024-04-04";
       private const string sdkVersion = "SDK_NET_3.0.1144";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VcgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VcgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于查询视频风格化任务。视频风格化支持将输入视频生成特定风格的视频。生成后的视频画面风格多样、流畅自然，能够满足社交娱乐、互动营销、视频素材制作等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoStylizationJobRequest"/></param>
        /// <returns><see cref="DescribeVideoStylizationJobResponse"/></returns>
        public Task<DescribeVideoStylizationJobResponse> DescribeVideoStylizationJob(DescribeVideoStylizationJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoStylizationJobResponse>(req, "DescribeVideoStylizationJob");
        }

        /// <summary>
        /// 用于查询视频风格化任务。视频风格化支持将输入视频生成特定风格的视频。生成后的视频画面风格多样、流畅自然，能够满足社交娱乐、互动营销、视频素材制作等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoStylizationJobRequest"/></param>
        /// <returns><see cref="DescribeVideoStylizationJobResponse"/></returns>
        public DescribeVideoStylizationJobResponse DescribeVideoStylizationJobSync(DescribeVideoStylizationJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoStylizationJobResponse>(req, "DescribeVideoStylizationJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于提交视频风格化任务。支持将输入视频生成特定风格的视频。生成后的视频画面风格多样、流畅自然，能够满足社交娱乐、互动营销、视频素材制作等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoStylizationJobRequest"/></param>
        /// <returns><see cref="SubmitVideoStylizationJobResponse"/></returns>
        public Task<SubmitVideoStylizationJobResponse> SubmitVideoStylizationJob(SubmitVideoStylizationJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoStylizationJobResponse>(req, "SubmitVideoStylizationJob");
        }

        /// <summary>
        /// 用于提交视频风格化任务。支持将输入视频生成特定风格的视频。生成后的视频画面风格多样、流畅自然，能够满足社交娱乐、互动营销、视频素材制作等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoStylizationJobRequest"/></param>
        /// <returns><see cref="SubmitVideoStylizationJobResponse"/></returns>
        public SubmitVideoStylizationJobResponse SubmitVideoStylizationJobSync(SubmitVideoStylizationJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoStylizationJobResponse>(req, "SubmitVideoStylizationJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
