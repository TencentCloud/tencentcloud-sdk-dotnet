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
       private const string sdkVersion = "SDK_NET_3.0.1118";

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
        /// ###### 支持音色种别列表
        /// | 音色名称                 | 性别 | 目标语言         | 音色ID |
        /// | ------------------------ | ---- | ---------------- | ------ |
        /// | Florian Multilingual     | 男 | 德语(德国)       | 701001 |
        /// | Seraphina                | 女  | 德语(德国)       | 701002 |
        /// | Ada Multilingual         | 女 | 英语(英国)       | 701003 |
        /// | Ollie Multilingual       | 男  | 英语(英国)       | 701004 |
        /// | Ava Multilingual         | 女 | 英语(美国)       | 701005 |
        /// | Andrew Multilingual      | 男  | 英语(美国)       | 701006 |
        /// | Emma Multilingual        | 女  | 英语(美国)       | 701007 |
        /// | Brian Multilingual       | 男  | 英语(美国)       | 701008 |
        /// | Jenny Multilingual       | 女  | 英语(美国)       | 701009 |
        /// | Ryan Multilingual        | 男  | 英语(美国)       | 701010 |
        /// | Adam Multilingual        | 男  | 英语(美国)       | 701011 |
        /// | AlloyTurbo Multilingual  | 男  | 英语(美国)       | 701012 |
        /// | Amanda Multilingual      | 女  | 英语(美国)       | 701013 |
        /// | Brandon Multilingual     | 男  | 英语(美国)       | 701014 |
        /// | Christopher Multilingual | 男  | 英语(美国)       | 701015 |
        /// | Cora Multilingual        | 女  | 英语(美国)       | 701016 |
        /// | Davis Multilingual       | 男  | 英语(美国)       | 701017 |
        /// | Derek Multilingual       | 男  | 英语(美国)       | 701018 |
        /// | Dustin Multilingual      | 男  | 英语(美国)       | 701019 |
        /// | Evelyn Multilingual      | 女  | 英语(美国)       | 701020 |
        /// | Lewis Multilingual       | 男  | 英语(美国)       | 701021 |
        /// | Lola Multilingual        | 女  | 英语(美国)       | 701022 |
        /// | Nancy Multilingual       | 女  | 英语(美国)       | 701023 |
        /// | NovaTurbo Multilingual   | 女   | 英语(美国)       | 701024 |
        /// | Phoebe Multilingual      | 女  | 英语(美国)       | 701025 |
        /// | Samuel Multilingual      | 男  | 英语(美国)       | 701026 |
        /// | Serena Multilingual      | 女  | 英语(美国)       | 701027 |
        /// | Steffan Multilingual     | 男  | 英语(美国)       | 701028 |
        /// | Arabella Multilingual    | 女  | 西班牙语(西班牙) | 701029 |
        /// | Isidora Multilingual     | 女  | 西班牙语(西班牙) | 701030 |
        /// | Tristan Multilingual     | 男  | 西班牙语(西班牙) | 701031 |
        /// | Ximena Multilingual      | 女  | 西班牙语(西班牙) | 701032 |
        /// | Remy Multilingual        | 男  | 法语(法国)       | 701033 |
        /// | Vivienne Multilingual    | 女  | 法语(法国)       | 701034 |
        /// | Lucien Multilingual      | 男  | 法语(法国)       | 701035 |
        /// | Alessio Multilingual     | 男  | 意大利语(意大利) | 701036 |
        /// | Giuseppe Multilingual    | 男  | 意大利语(意大利) | 701037 |
        /// | Isabella Multilingual    | 女  | 意大利语(意大利) | 701038 |
        /// | Marcello Multilingual    | 男  | 意大利语(意大利) | 701039 |
        /// | Masaru Multilingual      | 男  | 日语(日本)       | 701040 |
        /// | Hyunsu Multilingual      | 男  | 韩语(韩国)       | 701041 |
        /// | Macerio Multilingual     | 男  | 葡萄牙语(巴西)   | 701042 |
        /// | Thalita Multilingual     | 女  | 葡萄牙语(巴西)   | 701043 |
        /// | 晓辰 多语言              | 女  | 中文(普通话)     | 701044 |
        /// | 晓晓 多语言              | 女  | 中文(普通话)     | 701045 |
        /// | 晓宇 多语言              | 女  | 中文(普通话)     | 701046 |
        /// | 云逸 多语言              | 男 | 中文(普通话)     | 701047 |
        /// | Yunfan Multilingual      | 男  | 中文(普通话)     | 701048 |
        /// | Yunxiao Multilingual     | 男  | 中文(普通话)     | 701049 |
        /// | 晓晓 方言                | 女  | 中文(普通话)     | 701050 |
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoTranslateJobRequest"/></param>
        /// <returns><see cref="SubmitVideoTranslateJobResponse"/></returns>
        public Task<SubmitVideoTranslateJobResponse> SubmitVideoTranslateJob(SubmitVideoTranslateJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoTranslateJobResponse>(req, "SubmitVideoTranslateJob");
        }

        /// <summary>
        /// ###### 支持音色种别列表
        /// | 音色名称                 | 性别 | 目标语言         | 音色ID |
        /// | ------------------------ | ---- | ---------------- | ------ |
        /// | Florian Multilingual     | 男 | 德语(德国)       | 701001 |
        /// | Seraphina                | 女  | 德语(德国)       | 701002 |
        /// | Ada Multilingual         | 女 | 英语(英国)       | 701003 |
        /// | Ollie Multilingual       | 男  | 英语(英国)       | 701004 |
        /// | Ava Multilingual         | 女 | 英语(美国)       | 701005 |
        /// | Andrew Multilingual      | 男  | 英语(美国)       | 701006 |
        /// | Emma Multilingual        | 女  | 英语(美国)       | 701007 |
        /// | Brian Multilingual       | 男  | 英语(美国)       | 701008 |
        /// | Jenny Multilingual       | 女  | 英语(美国)       | 701009 |
        /// | Ryan Multilingual        | 男  | 英语(美国)       | 701010 |
        /// | Adam Multilingual        | 男  | 英语(美国)       | 701011 |
        /// | AlloyTurbo Multilingual  | 男  | 英语(美国)       | 701012 |
        /// | Amanda Multilingual      | 女  | 英语(美国)       | 701013 |
        /// | Brandon Multilingual     | 男  | 英语(美国)       | 701014 |
        /// | Christopher Multilingual | 男  | 英语(美国)       | 701015 |
        /// | Cora Multilingual        | 女  | 英语(美国)       | 701016 |
        /// | Davis Multilingual       | 男  | 英语(美国)       | 701017 |
        /// | Derek Multilingual       | 男  | 英语(美国)       | 701018 |
        /// | Dustin Multilingual      | 男  | 英语(美国)       | 701019 |
        /// | Evelyn Multilingual      | 女  | 英语(美国)       | 701020 |
        /// | Lewis Multilingual       | 男  | 英语(美国)       | 701021 |
        /// | Lola Multilingual        | 女  | 英语(美国)       | 701022 |
        /// | Nancy Multilingual       | 女  | 英语(美国)       | 701023 |
        /// | NovaTurbo Multilingual   | 女   | 英语(美国)       | 701024 |
        /// | Phoebe Multilingual      | 女  | 英语(美国)       | 701025 |
        /// | Samuel Multilingual      | 男  | 英语(美国)       | 701026 |
        /// | Serena Multilingual      | 女  | 英语(美国)       | 701027 |
        /// | Steffan Multilingual     | 男  | 英语(美国)       | 701028 |
        /// | Arabella Multilingual    | 女  | 西班牙语(西班牙) | 701029 |
        /// | Isidora Multilingual     | 女  | 西班牙语(西班牙) | 701030 |
        /// | Tristan Multilingual     | 男  | 西班牙语(西班牙) | 701031 |
        /// | Ximena Multilingual      | 女  | 西班牙语(西班牙) | 701032 |
        /// | Remy Multilingual        | 男  | 法语(法国)       | 701033 |
        /// | Vivienne Multilingual    | 女  | 法语(法国)       | 701034 |
        /// | Lucien Multilingual      | 男  | 法语(法国)       | 701035 |
        /// | Alessio Multilingual     | 男  | 意大利语(意大利) | 701036 |
        /// | Giuseppe Multilingual    | 男  | 意大利语(意大利) | 701037 |
        /// | Isabella Multilingual    | 女  | 意大利语(意大利) | 701038 |
        /// | Marcello Multilingual    | 男  | 意大利语(意大利) | 701039 |
        /// | Masaru Multilingual      | 男  | 日语(日本)       | 701040 |
        /// | Hyunsu Multilingual      | 男  | 韩语(韩国)       | 701041 |
        /// | Macerio Multilingual     | 男  | 葡萄牙语(巴西)   | 701042 |
        /// | Thalita Multilingual     | 女  | 葡萄牙语(巴西)   | 701043 |
        /// | 晓辰 多语言              | 女  | 中文(普通话)     | 701044 |
        /// | 晓晓 多语言              | 女  | 中文(普通话)     | 701045 |
        /// | 晓宇 多语言              | 女  | 中文(普通话)     | 701046 |
        /// | 云逸 多语言              | 男 | 中文(普通话)     | 701047 |
        /// | Yunfan Multilingual      | 男  | 中文(普通话)     | 701048 |
        /// | Yunxiao Multilingual     | 男  | 中文(普通话)     | 701049 |
        /// | 晓晓 方言                | 女  | 中文(普通话)     | 701050 |
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
