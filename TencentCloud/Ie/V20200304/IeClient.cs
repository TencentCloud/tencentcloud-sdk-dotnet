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

namespace TencentCloud.Ie.V20200304
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ie.V20200304.Models;

   public class IeClient : AbstractClient{

       private const string endpoint = "ie.tencentcloudapi.com";
       private const string version = "2020-03-04";
       private const string sdkVersion = "SDK_NET_3.0.973";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建编辑理解任务，可以同时选择视频标签识别、分类识别、智能拆条、智能集锦、智能封面和片头片尾识别中的一项或者多项能力。
        /// </summary>
        /// <param name="req"><see cref="CreateEditingTaskRequest"/></param>
        /// <returns><see cref="CreateEditingTaskResponse"/></returns>
        public Task<CreateEditingTaskResponse> CreateEditingTask(CreateEditingTaskRequest req)
        {
            return InternalRequestAsync<CreateEditingTaskResponse>(req, "CreateEditingTask");
        }

        /// <summary>
        /// 创建编辑理解任务，可以同时选择视频标签识别、分类识别、智能拆条、智能集锦、智能封面和片头片尾识别中的一项或者多项能力。
        /// </summary>
        /// <param name="req"><see cref="CreateEditingTaskRequest"/></param>
        /// <returns><see cref="CreateEditingTaskResponse"/></returns>
        public CreateEditingTaskResponse CreateEditingTaskSync(CreateEditingTaskRequest req)
        {
            return InternalRequestAsync<CreateEditingTaskResponse>(req, "CreateEditingTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建编辑处理任务，如媒体截取、媒体编辑、媒体拼接、媒体字幕。
        /// </summary>
        /// <param name="req"><see cref="CreateMediaProcessTaskRequest"/></param>
        /// <returns><see cref="CreateMediaProcessTaskResponse"/></returns>
        public Task<CreateMediaProcessTaskResponse> CreateMediaProcessTask(CreateMediaProcessTaskRequest req)
        {
            return InternalRequestAsync<CreateMediaProcessTaskResponse>(req, "CreateMediaProcessTask");
        }

        /// <summary>
        /// 用于创建编辑处理任务，如媒体截取、媒体编辑、媒体拼接、媒体字幕。
        /// </summary>
        /// <param name="req"><see cref="CreateMediaProcessTaskRequest"/></param>
        /// <returns><see cref="CreateMediaProcessTaskResponse"/></returns>
        public CreateMediaProcessTaskResponse CreateMediaProcessTaskSync(CreateMediaProcessTaskRequest req)
        {
            return InternalRequestAsync<CreateMediaProcessTaskResponse>(req, "CreateMediaProcessTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建画质重生任务，对视频进行转码、去噪、去划痕、去毛刺、超分、细节增强和色彩增强。
        /// </summary>
        /// <param name="req"><see cref="CreateMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="CreateMediaQualityRestorationTaskResponse"/></returns>
        public Task<CreateMediaQualityRestorationTaskResponse> CreateMediaQualityRestorationTask(CreateMediaQualityRestorationTaskRequest req)
        {
            return InternalRequestAsync<CreateMediaQualityRestorationTaskResponse>(req, "CreateMediaQualityRestorationTask");
        }

        /// <summary>
        /// 创建画质重生任务，对视频进行转码、去噪、去划痕、去毛刺、超分、细节增强和色彩增强。
        /// </summary>
        /// <param name="req"><see cref="CreateMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="CreateMediaQualityRestorationTaskResponse"/></returns>
        public CreateMediaQualityRestorationTaskResponse CreateMediaQualityRestorationTaskSync(CreateMediaQualityRestorationTaskRequest req)
        {
            return InternalRequestAsync<CreateMediaQualityRestorationTaskResponse>(req, "CreateMediaQualityRestorationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过接口可以智能检测视频画面中抖动重影、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等在内的多个场景，还可以自动检测视频无音频异常、无声音片段。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTaskRequest"/></param>
        /// <returns><see cref="CreateQualityControlTaskResponse"/></returns>
        public Task<CreateQualityControlTaskResponse> CreateQualityControlTask(CreateQualityControlTaskRequest req)
        {
            return InternalRequestAsync<CreateQualityControlTaskResponse>(req, "CreateQualityControlTask");
        }

        /// <summary>
        /// 通过接口可以智能检测视频画面中抖动重影、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等在内的多个场景，还可以自动检测视频无音频异常、无声音片段。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTaskRequest"/></param>
        /// <returns><see cref="CreateQualityControlTaskResponse"/></returns>
        public CreateQualityControlTaskResponse CreateQualityControlTaskSync(CreateQualityControlTaskRequest req)
        {
            return InternalRequestAsync<CreateQualityControlTaskResponse>(req, "CreateQualityControlTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取编辑理解任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeEditingTaskResultRequest"/></param>
        /// <returns><see cref="DescribeEditingTaskResultResponse"/></returns>
        public Task<DescribeEditingTaskResultResponse> DescribeEditingTaskResult(DescribeEditingTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeEditingTaskResultResponse>(req, "DescribeEditingTaskResult");
        }

        /// <summary>
        /// 获取编辑理解任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeEditingTaskResultRequest"/></param>
        /// <returns><see cref="DescribeEditingTaskResultResponse"/></returns>
        public DescribeEditingTaskResultResponse DescribeEditingTaskResultSync(DescribeEditingTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeEditingTaskResultResponse>(req, "DescribeEditingTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取编辑处理任务的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessTaskResultRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessTaskResultResponse"/></returns>
        public Task<DescribeMediaProcessTaskResultResponse> DescribeMediaProcessTaskResult(DescribeMediaProcessTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeMediaProcessTaskResultResponse>(req, "DescribeMediaProcessTaskResult");
        }

        /// <summary>
        /// 用于获取编辑处理任务的结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaProcessTaskResultRequest"/></param>
        /// <returns><see cref="DescribeMediaProcessTaskResultResponse"/></returns>
        public DescribeMediaProcessTaskResultResponse DescribeMediaProcessTaskResultSync(DescribeMediaProcessTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeMediaProcessTaskResultResponse>(req, "DescribeMediaProcessTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取画质重生任务结果，查看结束后的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaQualityRestorationTaskRusultRequest"/></param>
        /// <returns><see cref="DescribeMediaQualityRestorationTaskRusultResponse"/></returns>
        public Task<DescribeMediaQualityRestorationTaskRusultResponse> DescribeMediaQualityRestorationTaskRusult(DescribeMediaQualityRestorationTaskRusultRequest req)
        {
            return InternalRequestAsync<DescribeMediaQualityRestorationTaskRusultResponse>(req, "DescribeMediaQualityRestorationTaskRusult");
        }

        /// <summary>
        /// 获取画质重生任务结果，查看结束后的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaQualityRestorationTaskRusultRequest"/></param>
        /// <returns><see cref="DescribeMediaQualityRestorationTaskRusultResponse"/></returns>
        public DescribeMediaQualityRestorationTaskRusultResponse DescribeMediaQualityRestorationTaskRusultSync(DescribeMediaQualityRestorationTaskRusultRequest req)
        {
            return InternalRequestAsync<DescribeMediaQualityRestorationTaskRusultResponse>(req, "DescribeMediaQualityRestorationTaskRusult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取媒体质检任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTaskResultResponse"/></returns>
        public Task<DescribeQualityControlTaskResultResponse> DescribeQualityControlTaskResult(DescribeQualityControlTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeQualityControlTaskResultResponse>(req, "DescribeQualityControlTaskResult");
        }

        /// <summary>
        /// 获取媒体质检任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTaskResultResponse"/></returns>
        public DescribeQualityControlTaskResultResponse DescribeQualityControlTaskResultSync(DescribeQualityControlTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeQualityControlTaskResultResponse>(req, "DescribeQualityControlTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于停止正在进行中的编辑处理任务。
        /// </summary>
        /// <param name="req"><see cref="StopMediaProcessTaskRequest"/></param>
        /// <returns><see cref="StopMediaProcessTaskResponse"/></returns>
        public Task<StopMediaProcessTaskResponse> StopMediaProcessTask(StopMediaProcessTaskRequest req)
        {
            return InternalRequestAsync<StopMediaProcessTaskResponse>(req, "StopMediaProcessTask");
        }

        /// <summary>
        /// 用于停止正在进行中的编辑处理任务。
        /// </summary>
        /// <param name="req"><see cref="StopMediaProcessTaskRequest"/></param>
        /// <returns><see cref="StopMediaProcessTaskResponse"/></returns>
        public StopMediaProcessTaskResponse StopMediaProcessTaskSync(StopMediaProcessTaskRequest req)
        {
            return InternalRequestAsync<StopMediaProcessTaskResponse>(req, "StopMediaProcessTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除正在进行的画质重生任务
        /// </summary>
        /// <param name="req"><see cref="StopMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="StopMediaQualityRestorationTaskResponse"/></returns>
        public Task<StopMediaQualityRestorationTaskResponse> StopMediaQualityRestorationTask(StopMediaQualityRestorationTaskRequest req)
        {
            return InternalRequestAsync<StopMediaQualityRestorationTaskResponse>(req, "StopMediaQualityRestorationTask");
        }

        /// <summary>
        /// 删除正在进行的画质重生任务
        /// </summary>
        /// <param name="req"><see cref="StopMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="StopMediaQualityRestorationTaskResponse"/></returns>
        public StopMediaQualityRestorationTaskResponse StopMediaQualityRestorationTaskSync(StopMediaQualityRestorationTaskRequest req)
        {
            return InternalRequestAsync<StopMediaQualityRestorationTaskResponse>(req, "StopMediaQualityRestorationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
