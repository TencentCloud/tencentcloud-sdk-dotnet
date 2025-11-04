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

namespace TencentCloud.Bda.V20200324
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bda.V20200324.Models;

   public class BdaClient : AbstractClient{

       private const string endpoint = "bda.tencentcloudapi.com";
       private const string version = "2020-03-24";
       private const string sdkVersion = "SDK_NET_3.0.1339";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BdaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BdaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口为人像分割在线处理接口组中的提交任务接口，可以对提交的资源进行处理视频流/图片流识别视频作品中的人像区域，进行一键抠像、背景替换、人像虚化等后期处理。
        /// </summary>
        /// <param name="req"><see cref="CreateSegmentationTaskRequest"/></param>
        /// <returns><see cref="CreateSegmentationTaskResponse"/></returns>
        public Task<CreateSegmentationTaskResponse> CreateSegmentationTask(CreateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<CreateSegmentationTaskResponse>(req, "CreateSegmentationTask");
        }

        /// <summary>
        /// 本接口为人像分割在线处理接口组中的提交任务接口，可以对提交的资源进行处理视频流/图片流识别视频作品中的人像区域，进行一键抠像、背景替换、人像虚化等后期处理。
        /// </summary>
        /// <param name="req"><see cref="CreateSegmentationTaskRequest"/></param>
        /// <returns><see cref="CreateSegmentationTaskResponse"/></returns>
        public CreateSegmentationTaskResponse CreateSegmentationTaskSync(CreateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<CreateSegmentationTaskResponse>(req, "CreateSegmentationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可以查看单条任务的处理情况，包括处理状态，处理结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentationTaskRequest"/></param>
        /// <returns><see cref="DescribeSegmentationTaskResponse"/></returns>
        public Task<DescribeSegmentationTaskResponse> DescribeSegmentationTask(DescribeSegmentationTaskRequest req)
        {
            return InternalRequestAsync<DescribeSegmentationTaskResponse>(req, "DescribeSegmentationTask");
        }

        /// <summary>
        /// 可以查看单条任务的处理情况，包括处理状态，处理结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentationTaskRequest"/></param>
        /// <returns><see cref="DescribeSegmentationTaskResponse"/></returns>
        public DescribeSegmentationTaskResponse DescribeSegmentationTaskSync(DescribeSegmentationTaskRequest req)
        {
            return InternalRequestAsync<DescribeSegmentationTaskResponse>(req, "DescribeSegmentationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在前后景分割的基础上优化多分类分割，支持对头发、五官等的分割，既作为换发型、挂件等底层技术，也可用于抠人头、抠人脸等玩法
        /// </summary>
        /// <param name="req"><see cref="SegmentCustomizedPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentCustomizedPortraitPicResponse"/></returns>
        public Task<SegmentCustomizedPortraitPicResponse> SegmentCustomizedPortraitPic(SegmentCustomizedPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentCustomizedPortraitPicResponse>(req, "SegmentCustomizedPortraitPic");
        }

        /// <summary>
        /// 在前后景分割的基础上优化多分类分割，支持对头发、五官等的分割，既作为换发型、挂件等底层技术，也可用于抠人头、抠人脸等玩法
        /// </summary>
        /// <param name="req"><see cref="SegmentCustomizedPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentCustomizedPortraitPicResponse"/></returns>
        public SegmentCustomizedPortraitPicResponse SegmentCustomizedPortraitPicSync(SegmentCustomizedPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentCustomizedPortraitPicResponse>(req, "SegmentCustomizedPortraitPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即二分类人像分割，识别传入图片中人体的完整轮廓，进行抠像。
        /// </summary>
        /// <param name="req"><see cref="SegmentPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentPortraitPicResponse"/></returns>
        public Task<SegmentPortraitPicResponse> SegmentPortraitPic(SegmentPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentPortraitPicResponse>(req, "SegmentPortraitPic");
        }

        /// <summary>
        /// 即二分类人像分割，识别传入图片中人体的完整轮廓，进行抠像。
        /// </summary>
        /// <param name="req"><see cref="SegmentPortraitPicRequest"/></param>
        /// <returns><see cref="SegmentPortraitPicResponse"/></returns>
        public SegmentPortraitPicResponse SegmentPortraitPicSync(SegmentPortraitPicRequest req)
        {
            return InternalRequestAsync<SegmentPortraitPicResponse>(req, "SegmentPortraitPic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止指定视频人像分割处理任务
        /// </summary>
        /// <param name="req"><see cref="TerminateSegmentationTaskRequest"/></param>
        /// <returns><see cref="TerminateSegmentationTaskResponse"/></returns>
        public Task<TerminateSegmentationTaskResponse> TerminateSegmentationTask(TerminateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<TerminateSegmentationTaskResponse>(req, "TerminateSegmentationTask");
        }

        /// <summary>
        /// 终止指定视频人像分割处理任务
        /// </summary>
        /// <param name="req"><see cref="TerminateSegmentationTaskRequest"/></param>
        /// <returns><see cref="TerminateSegmentationTaskResponse"/></returns>
        public TerminateSegmentationTaskResponse TerminateSegmentationTaskSync(TerminateSegmentationTaskRequest req)
        {
            return InternalRequestAsync<TerminateSegmentationTaskResponse>(req, "TerminateSegmentationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
