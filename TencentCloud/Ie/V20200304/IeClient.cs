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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 创建智能编辑任务，可以同时选择视频标签识别、分类识别、智能拆条、智能集锦、智能封面和片头片尾识别中的一项或者多项能力。
        /// </summary>
        /// <param name="req"><see cref="CreateEditingTaskRequest"/></param>
        /// <returns><see cref="CreateEditingTaskResponse"/></returns>
        public async Task<CreateEditingTaskResponse> CreateEditingTask(CreateEditingTaskRequest req)
        {
             JsonResponseModel<CreateEditingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEditingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEditingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建智能编辑任务，可以同时选择视频标签识别、分类识别、智能拆条、智能集锦、智能封面和片头片尾识别中的一项或者多项能力。
        /// </summary>
        /// <param name="req"><see cref="CreateEditingTaskRequest"/></param>
        /// <returns><see cref="CreateEditingTaskResponse"/></returns>
        public CreateEditingTaskResponse CreateEditingTaskSync(CreateEditingTaskRequest req)
        {
             JsonResponseModel<CreateEditingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEditingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEditingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建画质重生任务，对视频进行转码、去噪、去划痕、去毛刺、超分、细节增强和色彩增强。
        /// </summary>
        /// <param name="req"><see cref="CreateMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="CreateMediaQualityRestorationTaskResponse"/></returns>
        public async Task<CreateMediaQualityRestorationTaskResponse> CreateMediaQualityRestorationTask(CreateMediaQualityRestorationTaskRequest req)
        {
             JsonResponseModel<CreateMediaQualityRestorationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaQualityRestorationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaQualityRestorationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建画质重生任务，对视频进行转码、去噪、去划痕、去毛刺、超分、细节增强和色彩增强。
        /// </summary>
        /// <param name="req"><see cref="CreateMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="CreateMediaQualityRestorationTaskResponse"/></returns>
        public CreateMediaQualityRestorationTaskResponse CreateMediaQualityRestorationTaskSync(CreateMediaQualityRestorationTaskRequest req)
        {
             JsonResponseModel<CreateMediaQualityRestorationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaQualityRestorationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaQualityRestorationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过接口可以智能检测视频画面中抖动重影、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等在内的多个场景，还可以自动检测视频无音频异常、无声音片段。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTaskRequest"/></param>
        /// <returns><see cref="CreateQualityControlTaskResponse"/></returns>
        public async Task<CreateQualityControlTaskResponse> CreateQualityControlTask(CreateQualityControlTaskRequest req)
        {
             JsonResponseModel<CreateQualityControlTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateQualityControlTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQualityControlTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过接口可以智能检测视频画面中抖动重影、模糊、低光照、过曝光、黑边、白边、黑屏、白屏、花屏、噪点、马赛克、二维码等在内的多个场景，还可以自动检测视频无音频异常、无声音片段。
        /// </summary>
        /// <param name="req"><see cref="CreateQualityControlTaskRequest"/></param>
        /// <returns><see cref="CreateQualityControlTaskResponse"/></returns>
        public CreateQualityControlTaskResponse CreateQualityControlTaskSync(CreateQualityControlTaskRequest req)
        {
             JsonResponseModel<CreateQualityControlTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateQualityControlTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQualityControlTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取智能编辑任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeEditingTaskResultRequest"/></param>
        /// <returns><see cref="DescribeEditingTaskResultResponse"/></returns>
        public async Task<DescribeEditingTaskResultResponse> DescribeEditingTaskResult(DescribeEditingTaskResultRequest req)
        {
             JsonResponseModel<DescribeEditingTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEditingTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEditingTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取智能编辑任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeEditingTaskResultRequest"/></param>
        /// <returns><see cref="DescribeEditingTaskResultResponse"/></returns>
        public DescribeEditingTaskResultResponse DescribeEditingTaskResultSync(DescribeEditingTaskResultRequest req)
        {
             JsonResponseModel<DescribeEditingTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEditingTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEditingTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取画质重生任务结果，查看结束后的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaQualityRestorationTaskRusultRequest"/></param>
        /// <returns><see cref="DescribeMediaQualityRestorationTaskRusultResponse"/></returns>
        public async Task<DescribeMediaQualityRestorationTaskRusultResponse> DescribeMediaQualityRestorationTaskRusult(DescribeMediaQualityRestorationTaskRusultRequest req)
        {
             JsonResponseModel<DescribeMediaQualityRestorationTaskRusultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaQualityRestorationTaskRusult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaQualityRestorationTaskRusultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取画质重生任务结果，查看结束后的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaQualityRestorationTaskRusultRequest"/></param>
        /// <returns><see cref="DescribeMediaQualityRestorationTaskRusultResponse"/></returns>
        public DescribeMediaQualityRestorationTaskRusultResponse DescribeMediaQualityRestorationTaskRusultSync(DescribeMediaQualityRestorationTaskRusultRequest req)
        {
             JsonResponseModel<DescribeMediaQualityRestorationTaskRusultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaQualityRestorationTaskRusult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaQualityRestorationTaskRusultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取质检任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTaskResultResponse"/></returns>
        public async Task<DescribeQualityControlTaskResultResponse> DescribeQualityControlTaskResult(DescribeQualityControlTaskResultRequest req)
        {
             JsonResponseModel<DescribeQualityControlTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQualityControlTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityControlTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取质检任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityControlTaskResultRequest"/></param>
        /// <returns><see cref="DescribeQualityControlTaskResultResponse"/></returns>
        public DescribeQualityControlTaskResultResponse DescribeQualityControlTaskResultSync(DescribeQualityControlTaskResultRequest req)
        {
             JsonResponseModel<DescribeQualityControlTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQualityControlTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityControlTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除正在进行的画质重生任务
        /// </summary>
        /// <param name="req"><see cref="StopMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="StopMediaQualityRestorationTaskResponse"/></returns>
        public async Task<StopMediaQualityRestorationTaskResponse> StopMediaQualityRestorationTask(StopMediaQualityRestorationTaskRequest req)
        {
             JsonResponseModel<StopMediaQualityRestorationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMediaQualityRestorationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMediaQualityRestorationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除正在进行的画质重生任务
        /// </summary>
        /// <param name="req"><see cref="StopMediaQualityRestorationTaskRequest"/></param>
        /// <returns><see cref="StopMediaQualityRestorationTaskResponse"/></returns>
        public StopMediaQualityRestorationTaskResponse StopMediaQualityRestorationTaskSync(StopMediaQualityRestorationTaskRequest req)
        {
             JsonResponseModel<StopMediaQualityRestorationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMediaQualityRestorationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMediaQualityRestorationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
