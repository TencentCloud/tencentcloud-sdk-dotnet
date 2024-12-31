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

namespace TencentCloud.Vclm.V20240523
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vclm.V20240523.Models;

   public class VclmClient : AbstractClient{

       private const string endpoint = "vclm.tencentcloudapi.com";
       private const string version = "2024-05-23";
       private const string sdkVersion = "SDK_NET_3.0.1155";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VclmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VclmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 检查图片跳舞输入图
        /// </summary>
        /// <param name="req"><see cref="CheckAnimateImageJobRequest"/></param>
        /// <returns><see cref="CheckAnimateImageJobResponse"/></returns>
        public Task<CheckAnimateImageJobResponse> CheckAnimateImageJob(CheckAnimateImageJobRequest req)
        {
            return InternalRequestAsync<CheckAnimateImageJobResponse>(req, "CheckAnimateImageJob");
        }

        /// <summary>
        /// 检查图片跳舞输入图
        /// </summary>
        /// <param name="req"><see cref="CheckAnimateImageJobRequest"/></param>
        /// <returns><see cref="CheckAnimateImageJobResponse"/></returns>
        public CheckAnimateImageJobResponse CheckAnimateImageJobSync(CheckAnimateImageJobRequest req)
        {
            return InternalRequestAsync<CheckAnimateImageJobResponse>(req, "CheckAnimateImageJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 确认视频转译结果
        /// </summary>
        /// <param name="req"><see cref="ConfirmVideoTranslateJobRequest"/></param>
        /// <returns><see cref="ConfirmVideoTranslateJobResponse"/></returns>
        public Task<ConfirmVideoTranslateJobResponse> ConfirmVideoTranslateJob(ConfirmVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<ConfirmVideoTranslateJobResponse>(req, "ConfirmVideoTranslateJob");
        }

        /// <summary>
        /// 确认视频转译结果
        /// </summary>
        /// <param name="req"><see cref="ConfirmVideoTranslateJobRequest"/></param>
        /// <returns><see cref="ConfirmVideoTranslateJobResponse"/></returns>
        public ConfirmVideoTranslateJobResponse ConfirmVideoTranslateJobSync(ConfirmVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<ConfirmVideoTranslateJobResponse>(req, "ConfirmVideoTranslateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询图片跳舞任务。图片跳舞能力支持舞蹈动作结合图片生成跳舞视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAnimateJobRequest"/></param>
        /// <returns><see cref="DescribeImageAnimateJobResponse"/></returns>
        public Task<DescribeImageAnimateJobResponse> DescribeImageAnimateJob(DescribeImageAnimateJobRequest req)
        {
            return InternalRequestAsync<DescribeImageAnimateJobResponse>(req, "DescribeImageAnimateJob");
        }

        /// <summary>
        /// 用于查询图片跳舞任务。图片跳舞能力支持舞蹈动作结合图片生成跳舞视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAnimateJobRequest"/></param>
        /// <returns><see cref="DescribeImageAnimateJobResponse"/></returns>
        public DescribeImageAnimateJobResponse DescribeImageAnimateJobSync(DescribeImageAnimateJobRequest req)
        {
            return InternalRequestAsync<DescribeImageAnimateJobResponse>(req, "DescribeImageAnimateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询图片唱演任务。
        /// 支持提交音频和图片生成唱演视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="DescribePortraitSingJobRequest"/></param>
        /// <returns><see cref="DescribePortraitSingJobResponse"/></returns>
        public Task<DescribePortraitSingJobResponse> DescribePortraitSingJob(DescribePortraitSingJobRequest req)
        {
            return InternalRequestAsync<DescribePortraitSingJobResponse>(req, "DescribePortraitSingJob");
        }

        /// <summary>
        /// 用于查询图片唱演任务。
        /// 支持提交音频和图片生成唱演视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="DescribePortraitSingJobRequest"/></param>
        /// <returns><see cref="DescribePortraitSingJobResponse"/></returns>
        public DescribePortraitSingJobResponse DescribePortraitSingJobSync(DescribePortraitSingJobRequest req)
        {
            return InternalRequestAsync<DescribePortraitSingJobResponse>(req, "DescribePortraitSingJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// 查询视频转译任务
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoTranslateJobRequest"/></param>
        /// <returns><see cref="DescribeVideoTranslateJobResponse"/></returns>
        public Task<DescribeVideoTranslateJobResponse> DescribeVideoTranslateJob(DescribeVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoTranslateJobResponse>(req, "DescribeVideoTranslateJob");
        }

        /// <summary>
        /// 查询视频转译任务
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoTranslateJobRequest"/></param>
        /// <returns><see cref="DescribeVideoTranslateJobResponse"/></returns>
        public DescribeVideoTranslateJobResponse DescribeVideoTranslateJobSync(DescribeVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoTranslateJobResponse>(req, "DescribeVideoTranslateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于提交图片跳舞任务。图片跳舞能力支持舞蹈动作结合图片生成跳舞视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitImageAnimateJobRequest"/></param>
        /// <returns><see cref="SubmitImageAnimateJobResponse"/></returns>
        public Task<SubmitImageAnimateJobResponse> SubmitImageAnimateJob(SubmitImageAnimateJobRequest req)
        {
            return InternalRequestAsync<SubmitImageAnimateJobResponse>(req, "SubmitImageAnimateJob");
        }

        /// <summary>
        /// 用于提交图片跳舞任务。图片跳舞能力支持舞蹈动作结合图片生成跳舞视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitImageAnimateJobRequest"/></param>
        /// <returns><see cref="SubmitImageAnimateJobResponse"/></returns>
        public SubmitImageAnimateJobResponse SubmitImageAnimateJobSync(SubmitImageAnimateJobRequest req)
        {
            return InternalRequestAsync<SubmitImageAnimateJobResponse>(req, "SubmitImageAnimateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于提交图片唱演任务。
        /// 支持提交音频和图片生成唱演视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitPortraitSingJobRequest"/></param>
        /// <returns><see cref="SubmitPortraitSingJobResponse"/></returns>
        public Task<SubmitPortraitSingJobResponse> SubmitPortraitSingJob(SubmitPortraitSingJobRequest req)
        {
            return InternalRequestAsync<SubmitPortraitSingJobResponse>(req, "SubmitPortraitSingJob");
        }

        /// <summary>
        /// 用于提交图片唱演任务。
        /// 支持提交音频和图片生成唱演视频，满足社交娱乐、互动营销等场景的需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitPortraitSingJobRequest"/></param>
        /// <returns><see cref="SubmitPortraitSingJobResponse"/></returns>
        public SubmitPortraitSingJobResponse SubmitPortraitSingJobSync(SubmitPortraitSingJobRequest req)
        {
            return InternalRequestAsync<SubmitPortraitSingJobResponse>(req, "SubmitPortraitSingJob")
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

        /// <summary>
        /// ### 支持音色种别列表。
        /// 每个音色都支持：英语（美国）、阿拉伯语、德语、西班牙语、法语、印尼语、意大利语、日语、韩语、马来语、葡萄牙语、俄语、泰语、土耳其语、越南语。
        /// 
        /// | 音色名称    | 性别 | 音色ID |
        /// | ----------- | ---- | ------ |
        /// | Seraphina   | 女   | 701002 |
        /// | Ada         | 女   | 701003 |
        /// | Emma        | 女   | 701007 |
        /// | Brian       | 男   | 701008 |
        /// | Amanda      | 女   | 701013 |
        /// | Brandon     | 男   | 701014 |
        /// | Christopher | 男   | 701015 |
        /// | Davis       | 男   | 701017 |
        /// | Derek       | 男   | 701018 |
        /// | Dustin      | 男   | 701019 |
        /// | Evelyn      | 女   | 701020 |
        /// | Lewis       | 男   | 701021 |
        /// | Lola        | 女   | 701022 |
        /// | Samuel      | 男   | 701026 |
        /// | Steffan     | 男   | 701028 |
        /// | Arabella    | 女   | 701029 |
        /// | Isidora     | 女   | 701030 |
        /// | Tristan     | 男   | 701031 |
        /// | Vivienne    | 女   | 701034 |
        /// | Lucien      | 男   | 701035 |
        /// | Alessio     | 男   | 701036 |
        /// | Giuseppe    | 男   | 701037 |
        /// | Isabella    | 女   | 701038 |
        /// | Marcello    | 男   | 701039 |
        /// | Masaru      | 男   | 701040 |
        /// | Macerio     | 男   | 701042 |
        /// | Thalita     | 女   | 701043 |
        /// | 晓晓         | 女   | 701045 |
        /// | 晓宇         | 女   | 701046 |
        /// | 云逸         | 男   | 701047 |
        /// | Yunfan       | 男   | 701048 |
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoTranslateJobRequest"/></param>
        /// <returns><see cref="SubmitVideoTranslateJobResponse"/></returns>
        public Task<SubmitVideoTranslateJobResponse> SubmitVideoTranslateJob(SubmitVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoTranslateJobResponse>(req, "SubmitVideoTranslateJob");
        }

        /// <summary>
        /// ### 支持音色种别列表。
        /// 每个音色都支持：英语（美国）、阿拉伯语、德语、西班牙语、法语、印尼语、意大利语、日语、韩语、马来语、葡萄牙语、俄语、泰语、土耳其语、越南语。
        /// 
        /// | 音色名称    | 性别 | 音色ID |
        /// | ----------- | ---- | ------ |
        /// | Seraphina   | 女   | 701002 |
        /// | Ada         | 女   | 701003 |
        /// | Emma        | 女   | 701007 |
        /// | Brian       | 男   | 701008 |
        /// | Amanda      | 女   | 701013 |
        /// | Brandon     | 男   | 701014 |
        /// | Christopher | 男   | 701015 |
        /// | Davis       | 男   | 701017 |
        /// | Derek       | 男   | 701018 |
        /// | Dustin      | 男   | 701019 |
        /// | Evelyn      | 女   | 701020 |
        /// | Lewis       | 男   | 701021 |
        /// | Lola        | 女   | 701022 |
        /// | Samuel      | 男   | 701026 |
        /// | Steffan     | 男   | 701028 |
        /// | Arabella    | 女   | 701029 |
        /// | Isidora     | 女   | 701030 |
        /// | Tristan     | 男   | 701031 |
        /// | Vivienne    | 女   | 701034 |
        /// | Lucien      | 男   | 701035 |
        /// | Alessio     | 男   | 701036 |
        /// | Giuseppe    | 男   | 701037 |
        /// | Isabella    | 女   | 701038 |
        /// | Marcello    | 男   | 701039 |
        /// | Masaru      | 男   | 701040 |
        /// | Macerio     | 男   | 701042 |
        /// | Thalita     | 女   | 701043 |
        /// | 晓晓         | 女   | 701045 |
        /// | 晓宇         | 女   | 701046 |
        /// | 云逸         | 男   | 701047 |
        /// | Yunfan       | 男   | 701048 |
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
