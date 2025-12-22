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
       private const string sdkVersion = "SDK_NET_3.0.1365";

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
        /// 通过JobId提交请求，获取人像驱动任务的结果信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeHumanActorJobRequest"/></param>
        /// <returns><see cref="DescribeHumanActorJobResponse"/></returns>
        public Task<DescribeHumanActorJobResponse> DescribeHumanActorJob(DescribeHumanActorJobRequest req)
        {
            return InternalRequestAsync<DescribeHumanActorJobResponse>(req, "DescribeHumanActorJob");
        }

        /// <summary>
        /// 通过JobId提交请求，获取人像驱动任务的结果信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeHumanActorJobRequest"/></param>
        /// <returns><see cref="DescribeHumanActorJobResponse"/></returns>
        public DescribeHumanActorJobResponse DescribeHumanActorJobSync(DescribeHumanActorJobRequest req)
        {
            return InternalRequestAsync<DescribeHumanActorJobResponse>(req, "DescribeHumanActorJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询混元生视频任务
        /// </summary>
        /// <param name="req"><see cref="DescribeHunyuanToVideoJobRequest"/></param>
        /// <returns><see cref="DescribeHunyuanToVideoJobResponse"/></returns>
        public Task<DescribeHunyuanToVideoJobResponse> DescribeHunyuanToVideoJob(DescribeHunyuanToVideoJobRequest req)
        {
            return InternalRequestAsync<DescribeHunyuanToVideoJobResponse>(req, "DescribeHunyuanToVideoJob");
        }

        /// <summary>
        /// 查询混元生视频任务
        /// </summary>
        /// <param name="req"><see cref="DescribeHunyuanToVideoJobRequest"/></param>
        /// <returns><see cref="DescribeHunyuanToVideoJobResponse"/></returns>
        public DescribeHunyuanToVideoJobResponse DescribeHunyuanToVideoJobSync(DescribeHunyuanToVideoJobRequest req)
        {
            return InternalRequestAsync<DescribeHunyuanToVideoJobResponse>(req, "DescribeHunyuanToVideoJob")
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
        /// 查询图生视频通用能力任务接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageToVideoGeneralJobRequest"/></param>
        /// <returns><see cref="DescribeImageToVideoGeneralJobResponse"/></returns>
        public Task<DescribeImageToVideoGeneralJobResponse> DescribeImageToVideoGeneralJob(DescribeImageToVideoGeneralJobRequest req)
        {
            return InternalRequestAsync<DescribeImageToVideoGeneralJobResponse>(req, "DescribeImageToVideoGeneralJob");
        }

        /// <summary>
        /// 查询图生视频通用能力任务接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageToVideoGeneralJobRequest"/></param>
        /// <returns><see cref="DescribeImageToVideoGeneralJobResponse"/></returns>
        public DescribeImageToVideoGeneralJobResponse DescribeImageToVideoGeneralJobSync(DescribeImageToVideoGeneralJobRequest req)
        {
            return InternalRequestAsync<DescribeImageToVideoGeneralJobResponse>(req, "DescribeImageToVideoGeneralJob")
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
        /// 用于查询视频特效任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateToVideoJobRequest"/></param>
        /// <returns><see cref="DescribeTemplateToVideoJobResponse"/></returns>
        public Task<DescribeTemplateToVideoJobResponse> DescribeTemplateToVideoJob(DescribeTemplateToVideoJobRequest req)
        {
            return InternalRequestAsync<DescribeTemplateToVideoJobResponse>(req, "DescribeTemplateToVideoJob");
        }

        /// <summary>
        /// 用于查询视频特效任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateToVideoJobRequest"/></param>
        /// <returns><see cref="DescribeTemplateToVideoJobResponse"/></returns>
        public DescribeTemplateToVideoJobResponse DescribeTemplateToVideoJobSync(DescribeTemplateToVideoJobRequest req)
        {
            return InternalRequestAsync<DescribeTemplateToVideoJobResponse>(req, "DescribeTemplateToVideoJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于提交视频编辑任务，支持上传视频、文本及图片素材开展编辑操作，涵盖风格迁移、元素替换、内容增减等核心能力。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoEditJobRequest"/></param>
        /// <returns><see cref="DescribeVideoEditJobResponse"/></returns>
        public Task<DescribeVideoEditJobResponse> DescribeVideoEditJob(DescribeVideoEditJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoEditJobResponse>(req, "DescribeVideoEditJob");
        }

        /// <summary>
        /// 用于提交视频编辑任务，支持上传视频、文本及图片素材开展编辑操作，涵盖风格迁移、元素替换、内容增减等核心能力。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoEditJobRequest"/></param>
        /// <returns><see cref="DescribeVideoEditJobResponse"/></returns>
        public DescribeVideoEditJobResponse DescribeVideoEditJobSync(DescribeVideoEditJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoEditJobResponse>(req, "DescribeVideoEditJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询视频人脸融合任务
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="DescribeVideoFaceFusionJobResponse"/></returns>
        public Task<DescribeVideoFaceFusionJobResponse> DescribeVideoFaceFusionJob(DescribeVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoFaceFusionJobResponse>(req, "DescribeVideoFaceFusionJob");
        }

        /// <summary>
        /// 查询视频人脸融合任务
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="DescribeVideoFaceFusionJobResponse"/></returns>
        public DescribeVideoFaceFusionJobResponse DescribeVideoFaceFusionJobSync(DescribeVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoFaceFusionJobResponse>(req, "DescribeVideoFaceFusionJob")
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
        /// 通过JobId提交请求，获取视频配音频任务的结果信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoVoiceJobRequest"/></param>
        /// <returns><see cref="DescribeVideoVoiceJobResponse"/></returns>
        public Task<DescribeVideoVoiceJobResponse> DescribeVideoVoiceJob(DescribeVideoVoiceJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoVoiceJobResponse>(req, "DescribeVideoVoiceJob");
        }

        /// <summary>
        /// 通过JobId提交请求，获取视频配音频任务的结果信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoVoiceJobRequest"/></param>
        /// <returns><see cref="DescribeVideoVoiceJobResponse"/></returns>
        public DescribeVideoVoiceJobResponse DescribeVideoVoiceJobSync(DescribeVideoVoiceJobRequest req)
        {
            return InternalRequestAsync<DescribeVideoVoiceJobResponse>(req, "DescribeVideoVoiceJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于提交人像驱动任务
        /// 支持提交音频和图文来生成对应视频，满足动态交互、内容生产等场景需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitHumanActorJobRequest"/></param>
        /// <returns><see cref="SubmitHumanActorJobResponse"/></returns>
        public Task<SubmitHumanActorJobResponse> SubmitHumanActorJob(SubmitHumanActorJobRequest req)
        {
            return InternalRequestAsync<SubmitHumanActorJobResponse>(req, "SubmitHumanActorJob");
        }

        /// <summary>
        /// 用于提交人像驱动任务
        /// 支持提交音频和图文来生成对应视频，满足动态交互、内容生产等场景需求。
        /// </summary>
        /// <param name="req"><see cref="SubmitHumanActorJobRequest"/></param>
        /// <returns><see cref="SubmitHumanActorJobResponse"/></returns>
        public SubmitHumanActorJobResponse SubmitHumanActorJobSync(SubmitHumanActorJobRequest req)
        {
            return InternalRequestAsync<SubmitHumanActorJobResponse>(req, "SubmitHumanActorJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ●混元生视频接口，基于混元大模型，根据输入的文本或图片智能生成视频。
        /// 
        /// ●默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanToVideoJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanToVideoJobResponse"/></returns>
        public Task<SubmitHunyuanToVideoJobResponse> SubmitHunyuanToVideoJob(SubmitHunyuanToVideoJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanToVideoJobResponse>(req, "SubmitHunyuanToVideoJob");
        }

        /// <summary>
        /// ●混元生视频接口，基于混元大模型，根据输入的文本或图片智能生成视频。
        /// 
        /// ●默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanToVideoJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanToVideoJobResponse"/></returns>
        public SubmitHunyuanToVideoJobResponse SubmitHunyuanToVideoJobSync(SubmitHunyuanToVideoJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanToVideoJobResponse>(req, "SubmitHunyuanToVideoJob")
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
        /// 图生视频通用能力接口
        /// </summary>
        /// <param name="req"><see cref="SubmitImageToVideoGeneralJobRequest"/></param>
        /// <returns><see cref="SubmitImageToVideoGeneralJobResponse"/></returns>
        public Task<SubmitImageToVideoGeneralJobResponse> SubmitImageToVideoGeneralJob(SubmitImageToVideoGeneralJobRequest req)
        {
            return InternalRequestAsync<SubmitImageToVideoGeneralJobResponse>(req, "SubmitImageToVideoGeneralJob");
        }

        /// <summary>
        /// 图生视频通用能力接口
        /// </summary>
        /// <param name="req"><see cref="SubmitImageToVideoGeneralJobRequest"/></param>
        /// <returns><see cref="SubmitImageToVideoGeneralJobResponse"/></returns>
        public SubmitImageToVideoGeneralJobResponse SubmitImageToVideoGeneralJobSync(SubmitImageToVideoGeneralJobRequest req)
        {
            return InternalRequestAsync<SubmitImageToVideoGeneralJobResponse>(req, "SubmitImageToVideoGeneralJob")
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
        /// 提交视频特效任务接口
        /// </summary>
        /// <param name="req"><see cref="SubmitTemplateToVideoJobRequest"/></param>
        /// <returns><see cref="SubmitTemplateToVideoJobResponse"/></returns>
        public Task<SubmitTemplateToVideoJobResponse> SubmitTemplateToVideoJob(SubmitTemplateToVideoJobRequest req)
        {
            return InternalRequestAsync<SubmitTemplateToVideoJobResponse>(req, "SubmitTemplateToVideoJob");
        }

        /// <summary>
        /// 提交视频特效任务接口
        /// </summary>
        /// <param name="req"><see cref="SubmitTemplateToVideoJobRequest"/></param>
        /// <returns><see cref="SubmitTemplateToVideoJobResponse"/></returns>
        public SubmitTemplateToVideoJobResponse SubmitTemplateToVideoJobSync(SubmitTemplateToVideoJobRequest req)
        {
            return InternalRequestAsync<SubmitTemplateToVideoJobResponse>(req, "SubmitTemplateToVideoJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于提交视频编辑任务，支持上传视频、文本及图片素材开展编辑操作，涵盖风格迁移、元素替换、内容增减等核心能力。
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoEditJobRequest"/></param>
        /// <returns><see cref="SubmitVideoEditJobResponse"/></returns>
        public Task<SubmitVideoEditJobResponse> SubmitVideoEditJob(SubmitVideoEditJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoEditJobResponse>(req, "SubmitVideoEditJob");
        }

        /// <summary>
        /// 用于提交视频编辑任务，支持上传视频、文本及图片素材开展编辑操作，涵盖风格迁移、元素替换、内容增减等核心能力。
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoEditJobRequest"/></param>
        /// <returns><see cref="SubmitVideoEditJobResponse"/></returns>
        public SubmitVideoEditJobResponse SubmitVideoEditJobSync(SubmitVideoEditJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoEditJobResponse>(req, "SubmitVideoEditJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交视频人脸融合任务
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="SubmitVideoFaceFusionJobResponse"/></returns>
        public Task<SubmitVideoFaceFusionJobResponse> SubmitVideoFaceFusionJob(SubmitVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoFaceFusionJobResponse>(req, "SubmitVideoFaceFusionJob");
        }

        /// <summary>
        /// 提交视频人脸融合任务
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="SubmitVideoFaceFusionJobResponse"/></returns>
        public SubmitVideoFaceFusionJobResponse SubmitVideoFaceFusionJobSync(SubmitVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoFaceFusionJobResponse>(req, "SubmitVideoFaceFusionJob")
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
        /// 提交视频配音效任务，输入视频后提交请求，会返回一个JobId，用于查询视频配音效的处理进度。
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoVoiceJobRequest"/></param>
        /// <returns><see cref="SubmitVideoVoiceJobResponse"/></returns>
        public Task<SubmitVideoVoiceJobResponse> SubmitVideoVoiceJob(SubmitVideoVoiceJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoVoiceJobResponse>(req, "SubmitVideoVoiceJob");
        }

        /// <summary>
        /// 提交视频配音效任务，输入视频后提交请求，会返回一个JobId，用于查询视频配音效的处理进度。
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoVoiceJobRequest"/></param>
        /// <returns><see cref="SubmitVideoVoiceJobResponse"/></returns>
        public SubmitVideoVoiceJobResponse SubmitVideoVoiceJobSync(SubmitVideoVoiceJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoVoiceJobResponse>(req, "SubmitVideoVoiceJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
