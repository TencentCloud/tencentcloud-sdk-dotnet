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
