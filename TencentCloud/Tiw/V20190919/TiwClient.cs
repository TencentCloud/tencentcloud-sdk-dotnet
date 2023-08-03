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

namespace TencentCloud.Tiw.V20190919
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tiw.V20190919.Models;

   public class TiwClient : AbstractClient{

       private const string endpoint = "tiw.tencentcloudapi.com";
       private const string version = "2019-09-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TiwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请互动白板试用，默认15天
        /// </summary>
        /// <param name="req"><see cref="ApplyTiwTrialRequest"/></param>
        /// <returns><see cref="ApplyTiwTrialResponse"/></returns>
        public async Task<ApplyTiwTrialResponse> ApplyTiwTrial(ApplyTiwTrialRequest req)
        {
             JsonResponseModel<ApplyTiwTrialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyTiwTrial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyTiwTrialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请互动白板试用，默认15天
        /// </summary>
        /// <param name="req"><see cref="ApplyTiwTrialRequest"/></param>
        /// <returns><see cref="ApplyTiwTrialResponse"/></returns>
        public ApplyTiwTrialResponse ApplyTiwTrialSync(ApplyTiwTrialRequest req)
        {
             JsonResponseModel<ApplyTiwTrialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyTiwTrial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyTiwTrialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建白板应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public async Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建白板应用
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
             JsonResponseModel<CreateApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建课后录制任务
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineRecordRequest"/></param>
        /// <returns><see cref="CreateOfflineRecordResponse"/></returns>
        public async Task<CreateOfflineRecordResponse> CreateOfflineRecord(CreateOfflineRecordRequest req)
        {
             JsonResponseModel<CreateOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建课后录制任务
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineRecordRequest"/></param>
        /// <returns><see cref="CreateOfflineRecordResponse"/></returns>
        public CreateOfflineRecordResponse CreateOfflineRecordSync(CreateOfflineRecordRequest req)
        {
             JsonResponseModel<CreateOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测PPT文件，识别PPT中包含的动态转码任务（Transcode）不支持的元素
        /// </summary>
        /// <param name="req"><see cref="CreatePPTCheckTaskRequest"/></param>
        /// <returns><see cref="CreatePPTCheckTaskResponse"/></returns>
        public async Task<CreatePPTCheckTaskResponse> CreatePPTCheckTask(CreatePPTCheckTaskRequest req)
        {
             JsonResponseModel<CreatePPTCheckTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePPTCheckTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePPTCheckTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测PPT文件，识别PPT中包含的动态转码任务（Transcode）不支持的元素
        /// </summary>
        /// <param name="req"><see cref="CreatePPTCheckTaskRequest"/></param>
        /// <returns><see cref="CreatePPTCheckTaskResponse"/></returns>
        public CreatePPTCheckTaskResponse CreatePPTCheckTaskSync(CreatePPTCheckTaskRequest req)
        {
             JsonResponseModel<CreatePPTCheckTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePPTCheckTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePPTCheckTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建白板板书生成任务, 在任务结束后，如果提供了回调地址，将通过回调地址通知板书生成结果
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public async Task<CreateSnapshotTaskResponse> CreateSnapshotTask(CreateSnapshotTaskRequest req)
        {
             JsonResponseModel<CreateSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建白板板书生成任务, 在任务结束后，如果提供了回调地址，将通过回调地址通知板书生成结果
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotTaskRequest"/></param>
        /// <returns><see cref="CreateSnapshotTaskResponse"/></returns>
        public CreateSnapshotTaskResponse CreateSnapshotTaskSync(CreateSnapshotTaskRequest req)
        {
             JsonResponseModel<CreateSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个文档转码任务
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public async Task<CreateTranscodeResponse> CreateTranscode(CreateTranscodeRequest req)
        {
             JsonResponseModel<CreateTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个文档转码任务
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeRequest"/></param>
        /// <returns><see cref="CreateTranscodeResponse"/></returns>
        public CreateTranscodeResponse CreateTranscodeSync(CreateTranscodeRequest req)
        {
             JsonResponseModel<CreateTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建视频生成任务
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public async Task<CreateVideoGenerationTaskResponse> CreateVideoGenerationTask(CreateVideoGenerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建视频生成任务
        /// </summary>
        /// <param name="req"><see cref="CreateVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoGenerationTaskResponse"/></returns>
        public CreateVideoGenerationTaskResponse CreateVideoGenerationTaskSync(CreateVideoGenerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过服务角色调用其他云产品API接口获取信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeAPIServiceResponse"/></returns>
        public async Task<DescribeAPIServiceResponse> DescribeAPIService(DescribeAPIServiceRequest req)
        {
             JsonResponseModel<DescribeAPIServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAPIService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过服务角色调用其他云产品API接口获取信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeAPIServiceResponse"/></returns>
        public DescribeAPIServiceResponse DescribeAPIServiceSync(DescribeAPIServiceRequest req)
        {
             JsonResponseModel<DescribeAPIServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAPIService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAPIServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfosRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfosResponse"/></returns>
        public async Task<DescribeApplicationInfosResponse> DescribeApplicationInfos(DescribeApplicationInfosRequest req)
        {
             JsonResponseModel<DescribeApplicationInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfosRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfosResponse"/></returns>
        public DescribeApplicationInfosResponse DescribeApplicationInfosSync(DescribeApplicationInfosRequest req)
        {
             JsonResponseModel<DescribeApplicationInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板各个子产品用量
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationUsageRequest"/></param>
        /// <returns><see cref="DescribeApplicationUsageResponse"/></returns>
        public async Task<DescribeApplicationUsageResponse> DescribeApplicationUsage(DescribeApplicationUsageRequest req)
        {
             JsonResponseModel<DescribeApplicationUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板各个子产品用量
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationUsageRequest"/></param>
        /// <returns><see cref="DescribeApplicationUsageResponse"/></returns>
        public DescribeApplicationUsageResponse DescribeApplicationUsageSync(DescribeApplicationUsageRequest req)
        {
             JsonResponseModel<DescribeApplicationUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户端白板日志
        /// </summary>
        /// <param name="req"><see cref="DescribeBoardSDKLogRequest"/></param>
        /// <returns><see cref="DescribeBoardSDKLogResponse"/></returns>
        public async Task<DescribeBoardSDKLogResponse> DescribeBoardSDKLog(DescribeBoardSDKLogRequest req)
        {
             JsonResponseModel<DescribeBoardSDKLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBoardSDKLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBoardSDKLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户端白板日志
        /// </summary>
        /// <param name="req"><see cref="DescribeBoardSDKLogRequest"/></param>
        /// <returns><see cref="DescribeBoardSDKLogResponse"/></returns>
        public DescribeBoardSDKLogResponse DescribeBoardSDKLogSync(DescribeBoardSDKLogRequest req)
        {
             JsonResponseModel<DescribeBoardSDKLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBoardSDKLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBoardSDKLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可用于创建白板应用的IM应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeIMApplicationsResponse"/></returns>
        public async Task<DescribeIMApplicationsResponse> DescribeIMApplications(DescribeIMApplicationsRequest req)
        {
             JsonResponseModel<DescribeIMApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIMApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIMApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可用于创建白板应用的IM应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeIMApplicationsResponse"/></returns>
        public DescribeIMApplicationsResponse DescribeIMApplicationsSync(DescribeIMApplicationsRequest req)
        {
             JsonResponseModel<DescribeIMApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIMApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIMApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询课后录制任务的进度与录制结果等相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordResponse"/></returns>
        public async Task<DescribeOfflineRecordResponse> DescribeOfflineRecord(DescribeOfflineRecordRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询课后录制任务的进度与录制结果等相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordResponse"/></returns>
        public DescribeOfflineRecordResponse DescribeOfflineRecordSync(DescribeOfflineRecordRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询课后录制回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordCallbackResponse"/></returns>
        public async Task<DescribeOfflineRecordCallbackResponse> DescribeOfflineRecordCallback(DescribeOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询课后录制回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOfflineRecordCallbackResponse"/></returns>
        public DescribeOfflineRecordCallbackResponse DescribeOfflineRecordCallbackSync(DescribeOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录制任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public async Task<DescribeOnlineRecordResponse> DescribeOnlineRecord(DescribeOnlineRecordRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录制任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordResponse"/></returns>
        public DescribeOnlineRecordResponse DescribeOnlineRecordSync(DescribeOnlineRecordRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时录制回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public async Task<DescribeOnlineRecordCallbackResponse> DescribeOnlineRecordCallback(DescribeOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实时录制回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="DescribeOnlineRecordCallbackResponse"/></returns>
        public DescribeOnlineRecordCallbackResponse DescribeOnlineRecordCallbackSync(DescribeOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<DescribeOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询PPT检测任务的执行进度或结果
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckRequest"/></param>
        /// <returns><see cref="DescribePPTCheckResponse"/></returns>
        public async Task<DescribePPTCheckResponse> DescribePPTCheck(DescribePPTCheckRequest req)
        {
             JsonResponseModel<DescribePPTCheckResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePPTCheck");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePPTCheckResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询PPT检测任务的执行进度或结果
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckRequest"/></param>
        /// <returns><see cref="DescribePPTCheckResponse"/></returns>
        public DescribePPTCheckResponse DescribePPTCheckSync(DescribePPTCheckRequest req)
        {
             JsonResponseModel<DescribePPTCheckResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePPTCheck");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePPTCheckResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询PPT检测任务回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckCallbackRequest"/></param>
        /// <returns><see cref="DescribePPTCheckCallbackResponse"/></returns>
        public async Task<DescribePPTCheckCallbackResponse> DescribePPTCheckCallback(DescribePPTCheckCallbackRequest req)
        {
             JsonResponseModel<DescribePPTCheckCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePPTCheckCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePPTCheckCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询PPT检测任务回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribePPTCheckCallbackRequest"/></param>
        /// <returns><see cref="DescribePPTCheckCallbackResponse"/></returns>
        public DescribePPTCheckCallbackResponse DescribePPTCheckCallbackSync(DescribePPTCheckCallbackRequest req)
        {
             JsonResponseModel<DescribePPTCheckCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePPTCheckCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePPTCheckCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户后付费用量
        /// </summary>
        /// <param name="req"><see cref="DescribePostpaidUsageRequest"/></param>
        /// <returns><see cref="DescribePostpaidUsageResponse"/></returns>
        public async Task<DescribePostpaidUsageResponse> DescribePostpaidUsage(DescribePostpaidUsageRequest req)
        {
             JsonResponseModel<DescribePostpaidUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePostpaidUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpaidUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户后付费用量
        /// </summary>
        /// <param name="req"><see cref="DescribePostpaidUsageRequest"/></param>
        /// <returns><see cref="DescribePostpaidUsageResponse"/></returns>
        public DescribePostpaidUsageResponse DescribePostpaidUsageSync(DescribePostpaidUsageRequest req)
        {
             JsonResponseModel<DescribePostpaidUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePostpaidUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostpaidUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板质量数据
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityMetricsRequest"/></param>
        /// <returns><see cref="DescribeQualityMetricsResponse"/></returns>
        public async Task<DescribeQualityMetricsResponse> DescribeQualityMetrics(DescribeQualityMetricsRequest req)
        {
             JsonResponseModel<DescribeQualityMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQualityMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板质量数据
        /// </summary>
        /// <param name="req"><see cref="DescribeQualityMetricsRequest"/></param>
        /// <returns><see cref="DescribeQualityMetricsResponse"/></returns>
        public DescribeQualityMetricsResponse DescribeQualityMetricsSync(DescribeQualityMetricsRequest req)
        {
             JsonResponseModel<DescribeQualityMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQualityMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQualityMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据房间号搜索实时录制任务
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSearchRequest"/></param>
        /// <returns><see cref="DescribeRecordSearchResponse"/></returns>
        public async Task<DescribeRecordSearchResponse> DescribeRecordSearch(DescribeRecordSearchRequest req)
        {
             JsonResponseModel<DescribeRecordSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据房间号搜索实时录制任务
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSearchRequest"/></param>
        /// <returns><see cref="DescribeRecordSearchResponse"/></returns>
        public DescribeRecordSearchResponse DescribeRecordSearchSync(DescribeRecordSearchRequest req)
        {
             JsonResponseModel<DescribeRecordSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板房间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomListRequest"/></param>
        /// <returns><see cref="DescribeRoomListResponse"/></returns>
        public async Task<DescribeRoomListResponse> DescribeRoomList(DescribeRoomListRequest req)
        {
             JsonResponseModel<DescribeRoomListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板房间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomListRequest"/></param>
        /// <returns><see cref="DescribeRoomListResponse"/></returns>
        public DescribeRoomListResponse DescribeRoomListSync(DescribeRoomListRequest req)
        {
             JsonResponseModel<DescribeRoomListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定的任务类型，获取当前正在执行中的任务列表。只能查询最近3天内创建的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunningTasksRequest"/></param>
        /// <returns><see cref="DescribeRunningTasksResponse"/></returns>
        public async Task<DescribeRunningTasksResponse> DescribeRunningTasks(DescribeRunningTasksRequest req)
        {
             JsonResponseModel<DescribeRunningTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRunningTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunningTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定的任务类型，获取当前正在执行中的任务列表。只能查询最近3天内创建的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunningTasksRequest"/></param>
        /// <returns><see cref="DescribeRunningTasksResponse"/></returns>
        public DescribeRunningTasksResponse DescribeRunningTasksSync(DescribeRunningTasksRequest req)
        {
             JsonResponseModel<DescribeRunningTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRunningTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunningTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定白板板书生成任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public async Task<DescribeSnapshotTaskResponse> DescribeSnapshotTask(DescribeSnapshotTaskRequest req)
        {
             JsonResponseModel<DescribeSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定白板板书生成任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotTaskRequest"/></param>
        /// <returns><see cref="DescribeSnapshotTaskResponse"/></returns>
        public DescribeSnapshotTaskResponse DescribeSnapshotTaskSync(DescribeSnapshotTaskRequest req)
        {
             JsonResponseModel<DescribeSnapshotTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板天维度计费用量。
        /// 1. 单次查询统计区间最多不能超过31天。
        /// 2. 由于统计延迟等原因，暂时不支持查询当天数据，建议在次日上午7点以后再来查询前一天的用量，例如在10月27日上午7点后，再来查询到10月26日整天的用量
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWDailyUsageResponse"/></returns>
        public async Task<DescribeTIWDailyUsageResponse> DescribeTIWDailyUsage(DescribeTIWDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTIWDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板天维度计费用量。
        /// 1. 单次查询统计区间最多不能超过31天。
        /// 2. 由于统计延迟等原因，暂时不支持查询当天数据，建议在次日上午7点以后再来查询前一天的用量，例如在10月27日上午7点后，再来查询到10月26日整天的用量
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWDailyUsageResponse"/></returns>
        public DescribeTIWDailyUsageResponse DescribeTIWDailyUsageSync(DescribeTIWDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTIWDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板房间维度每天计费用量。
        /// 1. 单次查询统计区间最多不能超过31天。
        /// 2. 由于统计延迟等原因，暂时不支持查询当天数据，建议在次日上午7点以后再来查询前一天的用量，例如在10月27日上午7点后，再来查询到10月26日整天的用量
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWRoomDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWRoomDailyUsageResponse"/></returns>
        public async Task<DescribeTIWRoomDailyUsageResponse> DescribeTIWRoomDailyUsage(DescribeTIWRoomDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWRoomDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTIWRoomDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWRoomDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板房间维度每天计费用量。
        /// 1. 单次查询统计区间最多不能超过31天。
        /// 2. 由于统计延迟等原因，暂时不支持查询当天数据，建议在次日上午7点以后再来查询前一天的用量，例如在10月27日上午7点后，再来查询到10月26日整天的用量
        /// </summary>
        /// <param name="req"><see cref="DescribeTIWRoomDailyUsageRequest"/></param>
        /// <returns><see cref="DescribeTIWRoomDailyUsageResponse"/></returns>
        public DescribeTIWRoomDailyUsageResponse DescribeTIWRoomDailyUsageSync(DescribeTIWRoomDailyUsageRequest req)
        {
             JsonResponseModel<DescribeTIWRoomDailyUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTIWRoomDailyUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTIWRoomDailyUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码任务的执行进度与转码结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public async Task<DescribeTranscodeResponse> DescribeTranscode(DescribeTranscodeRequest req)
        {
             JsonResponseModel<DescribeTranscodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码任务的执行进度与转码结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeRequest"/></param>
        /// <returns><see cref="DescribeTranscodeResponse"/></returns>
        public DescribeTranscodeResponse DescribeTranscodeSync(DescribeTranscodeRequest req)
        {
             JsonResponseModel<DescribeTranscodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过文档URL查询转码任务，返回最近一次的转码任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeByUrlRequest"/></param>
        /// <returns><see cref="DescribeTranscodeByUrlResponse"/></returns>
        public async Task<DescribeTranscodeByUrlResponse> DescribeTranscodeByUrl(DescribeTranscodeByUrlRequest req)
        {
             JsonResponseModel<DescribeTranscodeByUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeByUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeByUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过文档URL查询转码任务，返回最近一次的转码任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeByUrlRequest"/></param>
        /// <returns><see cref="DescribeTranscodeByUrlResponse"/></returns>
        public DescribeTranscodeByUrlResponse DescribeTranscodeByUrlSync(DescribeTranscodeByUrlRequest req)
        {
             JsonResponseModel<DescribeTranscodeByUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeByUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeByUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public async Task<DescribeTranscodeCallbackResponse> DescribeTranscodeCallback(DescribeTranscodeCallbackRequest req)
        {
             JsonResponseModel<DescribeTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeCallbackRequest"/></param>
        /// <returns><see cref="DescribeTranscodeCallbackResponse"/></returns>
        public DescribeTranscodeCallbackResponse DescribeTranscodeCallbackSync(DescribeTranscodeCallbackRequest req)
        {
             JsonResponseModel<DescribeTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按文档名称搜索转码任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeSearchRequest"/></param>
        /// <returns><see cref="DescribeTranscodeSearchResponse"/></returns>
        public async Task<DescribeTranscodeSearchResponse> DescribeTranscodeSearch(DescribeTranscodeSearchRequest req)
        {
             JsonResponseModel<DescribeTranscodeSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按文档名称搜索转码任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeSearchRequest"/></param>
        /// <returns><see cref="DescribeTranscodeSearchResponse"/></returns>
        public DescribeTranscodeSearchResponse DescribeTranscodeSearchSync(DescribeTranscodeSearchRequest req)
        {
             JsonResponseModel<DescribeTranscodeSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间段内子产品的用量汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryResponse"/></returns>
        public async Task<DescribeUsageSummaryResponse> DescribeUsageSummary(DescribeUsageSummaryRequest req)
        {
             JsonResponseModel<DescribeUsageSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间段内子产品的用量汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryResponse"/></returns>
        public DescribeUsageSummaryResponse DescribeUsageSummarySync(DescribeUsageSummaryRequest req)
        {
             JsonResponseModel<DescribeUsageSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public async Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
             JsonResponseModel<DescribeUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
             JsonResponseModel<DescribeUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesResponse"/></returns>
        public async Task<DescribeUserResourcesResponse> DescribeUserResources(DescribeUserResourcesRequest req)
        {
             JsonResponseModel<DescribeUserResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesResponse"/></returns>
        public DescribeUserResourcesResponse DescribeUserResourcesSync(DescribeUserResourcesRequest req)
        {
             JsonResponseModel<DescribeUserResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板用户详情，包括是否开通了互动白板，当前互动白板服务有效期等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserStatusRequest"/></param>
        /// <returns><see cref="DescribeUserStatusResponse"/></returns>
        public async Task<DescribeUserStatusResponse> DescribeUserStatus(DescribeUserStatusRequest req)
        {
             JsonResponseModel<DescribeUserStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询互动白板用户详情，包括是否开通了互动白板，当前互动白板服务有效期等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserStatusRequest"/></param>
        /// <returns><see cref="DescribeUserStatusResponse"/></returns>
        public DescribeUserStatusResponse DescribeUserStatusSync(DescribeUserStatusRequest req)
        {
             JsonResponseModel<DescribeUserStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录制视频生成任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public async Task<DescribeVideoGenerationTaskResponse> DescribeVideoGenerationTask(DescribeVideoGenerationTaskRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录制视频生成任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskResponse"/></returns>
        public DescribeVideoGenerationTaskResponse DescribeVideoGenerationTaskSync(DescribeVideoGenerationTaskRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoGenerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public async Task<DescribeVideoGenerationTaskCallbackResponse> DescribeVideoGenerationTaskCallback(DescribeVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="DescribeVideoGenerationTaskCallbackResponse"/></returns>
        public DescribeVideoGenerationTaskCallbackResponse DescribeVideoGenerationTaskCallbackSync(DescribeVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningCallbackRequest"/></param>
        /// <returns><see cref="DescribeWarningCallbackResponse"/></returns>
        public async Task<DescribeWarningCallbackResponse> DescribeWarningCallback(DescribeWarningCallbackRequest req)
        {
             JsonResponseModel<DescribeWarningCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWarningCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningCallbackRequest"/></param>
        /// <returns><see cref="DescribeWarningCallbackResponse"/></returns>
        public DescribeWarningCallbackResponse DescribeWarningCallbackSync(DescribeWarningCallbackRequest req)
        {
             JsonResponseModel<DescribeWarningCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWarningCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板应用任务相关的配置，包括存储桶、回调等
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardApplicationConfigResponse"/></returns>
        public async Task<DescribeWhiteboardApplicationConfigResponse> DescribeWhiteboardApplicationConfig(DescribeWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板应用任务相关的配置，包括存储桶、回调等
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardApplicationConfigResponse"/></returns>
        public DescribeWhiteboardApplicationConfigResponse DescribeWhiteboardApplicationConfigSync(DescribeWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码，实时录制存储桶的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardBucketConfigResponse"/></returns>
        public async Task<DescribeWhiteboardBucketConfigResponse> DescribeWhiteboardBucketConfig(DescribeWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文档转码，实时录制存储桶的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardBucketConfigResponse"/></returns>
        public DescribeWhiteboardBucketConfigResponse DescribeWhiteboardBucketConfigSync(DescribeWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<DescribeWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推流任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public async Task<DescribeWhiteboardPushResponse> DescribeWhiteboardPush(DescribeWhiteboardPushRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推流任务状态与结果
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushResponse"/></returns>
        public DescribeWhiteboardPushResponse DescribeWhiteboardPushSync(DescribeWhiteboardPushRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板推流回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public async Task<DescribeWhiteboardPushCallbackResponse> DescribeWhiteboardPushCallback(DescribeWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白板推流回调地址
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushCallbackResponse"/></returns>
        public DescribeWhiteboardPushCallbackResponse DescribeWhiteboardPushCallbackSync(DescribeWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据房间号搜索白板推流任务
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushSearchRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushSearchResponse"/></returns>
        public async Task<DescribeWhiteboardPushSearchResponse> DescribeWhiteboardPushSearch(DescribeWhiteboardPushSearchRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhiteboardPushSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据房间号搜索白板推流任务
        /// </summary>
        /// <param name="req"><see cref="DescribeWhiteboardPushSearchRequest"/></param>
        /// <returns><see cref="DescribeWhiteboardPushSearchResponse"/></returns>
        public DescribeWhiteboardPushSearchResponse DescribeWhiteboardPushSearchSync(DescribeWhiteboardPushSearchRequest req)
        {
             JsonResponseModel<DescribeWhiteboardPushSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhiteboardPushSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhiteboardPushSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改白板应用
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public async Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
             JsonResponseModel<ModifyApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改白板应用
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
             JsonResponseModel<ModifyApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置白板月功能费自动续费
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public async Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置白板月功能费自动续费
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改白板应用任务相关的配置，包括存储桶、回调等
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardApplicationConfigResponse"/></returns>
        public async Task<ModifyWhiteboardApplicationConfigResponse> ModifyWhiteboardApplicationConfig(ModifyWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改白板应用任务相关的配置，包括存储桶、回调等
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardApplicationConfigResponse"/></returns>
        public ModifyWhiteboardApplicationConfigResponse ModifyWhiteboardApplicationConfigSync(ModifyWhiteboardApplicationConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardApplicationConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWhiteboardApplicationConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardApplicationConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文档转码，实时录制存储桶的配置
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardBucketConfigResponse"/></returns>
        public async Task<ModifyWhiteboardBucketConfigResponse> ModifyWhiteboardBucketConfig(ModifyWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文档转码，实时录制存储桶的配置
        /// </summary>
        /// <param name="req"><see cref="ModifyWhiteboardBucketConfigRequest"/></param>
        /// <returns><see cref="ModifyWhiteboardBucketConfigResponse"/></returns>
        public ModifyWhiteboardBucketConfigResponse ModifyWhiteboardBucketConfigSync(ModifyWhiteboardBucketConfigRequest req)
        {
             JsonResponseModel<ModifyWhiteboardBucketConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWhiteboardBucketConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWhiteboardBucketConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停实时录制
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public async Task<PauseOnlineRecordResponse> PauseOnlineRecord(PauseOnlineRecordRequest req)
        {
             JsonResponseModel<PauseOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PauseOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暂停实时录制
        /// </summary>
        /// <param name="req"><see cref="PauseOnlineRecordRequest"/></param>
        /// <returns><see cref="PauseOnlineRecordResponse"/></returns>
        public PauseOnlineRecordResponse PauseOnlineRecordSync(PauseOnlineRecordRequest req)
        {
             JsonResponseModel<PauseOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PauseOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PauseOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复实时录制
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public async Task<ResumeOnlineRecordResponse> ResumeOnlineRecord(ResumeOnlineRecordRequest req)
        {
             JsonResponseModel<ResumeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复实时录制
        /// </summary>
        /// <param name="req"><see cref="ResumeOnlineRecordRequest"/></param>
        /// <returns><see cref="ResumeOnlineRecordResponse"/></returns>
        public ResumeOnlineRecordResponse ResumeOnlineRecordSync(ResumeOnlineRecordRequest req)
        {
             JsonResponseModel<ResumeOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置课后录制回调地址
        /// </summary>
        /// <param name="req"><see cref="SetOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOfflineRecordCallbackResponse"/></returns>
        public async Task<SetOfflineRecordCallbackResponse> SetOfflineRecordCallback(SetOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置课后录制回调地址
        /// </summary>
        /// <param name="req"><see cref="SetOfflineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOfflineRecordCallbackResponse"/></returns>
        public SetOfflineRecordCallbackResponse SetOfflineRecordCallbackSync(SetOfflineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOfflineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOfflineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOfflineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实时录制回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40258
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public async Task<SetOnlineRecordCallbackResponse> SetOnlineRecordCallback(SetOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实时录制回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40258
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackResponse"/></returns>
        public SetOnlineRecordCallbackResponse SetOnlineRecordCallbackSync(SetOnlineRecordCallbackRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOnlineRecordCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实时录制回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public async Task<SetOnlineRecordCallbackKeyResponse> SetOnlineRecordCallbackKey(SetOnlineRecordCallbackKeyRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOnlineRecordCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置实时录制回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetOnlineRecordCallbackKeyRequest"/></param>
        /// <returns><see cref="SetOnlineRecordCallbackKeyResponse"/></returns>
        public SetOnlineRecordCallbackKeyResponse SetOnlineRecordCallbackKeySync(SetOnlineRecordCallbackKeyRequest req)
        {
             JsonResponseModel<SetOnlineRecordCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOnlineRecordCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOnlineRecordCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置PPT检测任务回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260#c9cbe05f-fe1a-4410-b4dc-40cc301c7b81
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackResponse"/></returns>
        public async Task<SetPPTCheckCallbackResponse> SetPPTCheckCallback(SetPPTCheckCallbackRequest req)
        {
             JsonResponseModel<SetPPTCheckCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetPPTCheckCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPPTCheckCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置PPT检测任务回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260#c9cbe05f-fe1a-4410-b4dc-40cc301c7b81
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackResponse"/></returns>
        public SetPPTCheckCallbackResponse SetPPTCheckCallbackSync(SetPPTCheckCallbackRequest req)
        {
             JsonResponseModel<SetPPTCheckCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetPPTCheckCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPPTCheckCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置PPT检测任务回调密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackKeyRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackKeyResponse"/></returns>
        public async Task<SetPPTCheckCallbackKeyResponse> SetPPTCheckCallbackKey(SetPPTCheckCallbackKeyRequest req)
        {
             JsonResponseModel<SetPPTCheckCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetPPTCheckCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPPTCheckCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置PPT检测任务回调密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetPPTCheckCallbackKeyRequest"/></param>
        /// <returns><see cref="SetPPTCheckCallbackKeyResponse"/></returns>
        public SetPPTCheckCallbackKeyResponse SetPPTCheckCallbackKeySync(SetPPTCheckCallbackKeyRequest req)
        {
             JsonResponseModel<SetPPTCheckCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetPPTCheckCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPPTCheckCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文档转码回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public async Task<SetTranscodeCallbackResponse> SetTranscodeCallback(SetTranscodeCallbackRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文档转码回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40260
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackResponse"/></returns>
        public SetTranscodeCallbackResponse SetTranscodeCallbackSync(SetTranscodeCallbackRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTranscodeCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文档转码回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public async Task<SetTranscodeCallbackKeyResponse> SetTranscodeCallbackKey(SetTranscodeCallbackKeyRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTranscodeCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文档转码回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetTranscodeCallbackKeyRequest"/></param>
        /// <returns><see cref="SetTranscodeCallbackKeyResponse"/></returns>
        public SetTranscodeCallbackKeyResponse SetTranscodeCallbackKeySync(SetTranscodeCallbackKeyRequest req)
        {
             JsonResponseModel<SetTranscodeCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTranscodeCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTranscodeCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public async Task<SetVideoGenerationTaskCallbackResponse> SetVideoGenerationTaskCallback(SetVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置录制视频生成回调地址
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackResponse"/></returns>
        public SetVideoGenerationTaskCallbackResponse SetVideoGenerationTaskCallbackSync(SetVideoGenerationTaskCallbackRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetVideoGenerationTaskCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置视频生成回调鉴权密钥
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public async Task<SetVideoGenerationTaskCallbackKeyResponse> SetVideoGenerationTaskCallbackKey(SetVideoGenerationTaskCallbackKeyRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetVideoGenerationTaskCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置视频生成回调鉴权密钥
        /// </summary>
        /// <param name="req"><see cref="SetVideoGenerationTaskCallbackKeyRequest"/></param>
        /// <returns><see cref="SetVideoGenerationTaskCallbackKeyResponse"/></returns>
        public SetVideoGenerationTaskCallbackKeyResponse SetVideoGenerationTaskCallbackKeySync(SetVideoGenerationTaskCallbackKeyRequest req)
        {
             JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetVideoGenerationTaskCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVideoGenerationTaskCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="SetWarningCallbackRequest"/></param>
        /// <returns><see cref="SetWarningCallbackResponse"/></returns>
        public async Task<SetWarningCallbackResponse> SetWarningCallback(SetWarningCallbackRequest req)
        {
             JsonResponseModel<SetWarningCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetWarningCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWarningCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置告警回调地址。此功能需要申请白名单使用。
        /// </summary>
        /// <param name="req"><see cref="SetWarningCallbackRequest"/></param>
        /// <returns><see cref="SetWarningCallbackResponse"/></returns>
        public SetWarningCallbackResponse SetWarningCallbackSync(SetWarningCallbackRequest req)
        {
             JsonResponseModel<SetWarningCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetWarningCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWarningCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置白板推流回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public async Task<SetWhiteboardPushCallbackResponse> SetWhiteboardPushCallback(SetWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置白板推流回调地址，回调数据格式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackResponse"/></returns>
        public SetWhiteboardPushCallbackResponse SetWhiteboardPushCallbackSync(SetWhiteboardPushCallbackRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetWhiteboardPushCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置白板推流回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public async Task<SetWhiteboardPushCallbackKeyResponse> SetWhiteboardPushCallbackKey(SetWhiteboardPushCallbackKeyRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetWhiteboardPushCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置白板推流回调鉴权密钥，回调鉴权方式请参考文档：https://cloud.tencent.com/document/product/1137/40257
        /// </summary>
        /// <param name="req"><see cref="SetWhiteboardPushCallbackKeyRequest"/></param>
        /// <returns><see cref="SetWhiteboardPushCallbackKeyResponse"/></returns>
        public SetWhiteboardPushCallbackKeyResponse SetWhiteboardPushCallbackKeySync(SetWhiteboardPushCallbackKeyRequest req)
        {
             JsonResponseModel<SetWhiteboardPushCallbackKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetWhiteboardPushCallbackKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWhiteboardPushCallbackKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起一个实时录制任务
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public async Task<StartOnlineRecordResponse> StartOnlineRecord(StartOnlineRecordRequest req)
        {
             JsonResponseModel<StartOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起一个实时录制任务
        /// </summary>
        /// <param name="req"><see cref="StartOnlineRecordRequest"/></param>
        /// <returns><see cref="StartOnlineRecordResponse"/></returns>
        public StartOnlineRecordResponse StartOnlineRecordSync(StartOnlineRecordRequest req)
        {
             JsonResponseModel<StartOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起一个白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public async Task<StartWhiteboardPushResponse> StartWhiteboardPush(StartWhiteboardPushRequest req)
        {
             JsonResponseModel<StartWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起一个白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StartWhiteboardPushRequest"/></param>
        /// <returns><see cref="StartWhiteboardPushResponse"/></returns>
        public StartWhiteboardPushResponse StartWhiteboardPushSync(StartWhiteboardPushRequest req)
        {
             JsonResponseModel<StartWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止实时录制
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public async Task<StopOnlineRecordResponse> StopOnlineRecord(StopOnlineRecordRequest req)
        {
             JsonResponseModel<StopOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止实时录制
        /// </summary>
        /// <param name="req"><see cref="StopOnlineRecordRequest"/></param>
        /// <returns><see cref="StopOnlineRecordResponse"/></returns>
        public StopOnlineRecordResponse StopOnlineRecordSync(StopOnlineRecordRequest req)
        {
             JsonResponseModel<StopOnlineRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopOnlineRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopOnlineRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public async Task<StopWhiteboardPushResponse> StopWhiteboardPush(StopWhiteboardPushRequest req)
        {
             JsonResponseModel<StopWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止白板推流任务
        /// </summary>
        /// <param name="req"><see cref="StopWhiteboardPushRequest"/></param>
        /// <returns><see cref="StopWhiteboardPushResponse"/></returns>
        public StopWhiteboardPushResponse StopWhiteboardPushSync(StopWhiteboardPushRequest req)
        {
             JsonResponseModel<StopWhiteboardPushResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopWhiteboardPush");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopWhiteboardPushResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
