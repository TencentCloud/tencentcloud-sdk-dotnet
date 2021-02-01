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

namespace TencentCloud.Cr.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cr.V20180321.Models;

   public class CrClient : AbstractClient{

       private const string endpoint = "cr.tencentcloudapi.com";
       private const string version = "2018-03-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 提交黑名单后，黑名单中有效期内的号码将停止拨打，适用于到期/逾期提醒、回访场景。
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListRequest"/></param>
        /// <returns><see cref="ApplyBlackListResponse"/></returns>
        public async Task<ApplyBlackListResponse> ApplyBlackList(ApplyBlackListRequest req)
        {
             JsonResponseModel<ApplyBlackListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyBlackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyBlackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交黑名单后，黑名单中有效期内的号码将停止拨打，适用于到期/逾期提醒、回访场景。
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListRequest"/></param>
        /// <returns><see cref="ApplyBlackListResponse"/></returns>
        public ApplyBlackListResponse ApplyBlackListSync(ApplyBlackListRequest req)
        {
             JsonResponseModel<ApplyBlackListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyBlackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyBlackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交机器人黑名单申请
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListDataRequest"/></param>
        /// <returns><see cref="ApplyBlackListDataResponse"/></returns>
        public async Task<ApplyBlackListDataResponse> ApplyBlackListData(ApplyBlackListDataRequest req)
        {
             JsonResponseModel<ApplyBlackListDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyBlackListData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyBlackListDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交机器人黑名单申请
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListDataRequest"/></param>
        /// <returns><see cref="ApplyBlackListDataResponse"/></returns>
        public ApplyBlackListDataResponse ApplyBlackListDataSync(ApplyBlackListDataRequest req)
        {
             JsonResponseModel<ApplyBlackListDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyBlackListData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyBlackListDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交信审外呼申请，返回当次请求日期。
        /// </summary>
        /// <param name="req"><see cref="ApplyCreditAuditRequest"/></param>
        /// <returns><see cref="ApplyCreditAuditResponse"/></returns>
        public async Task<ApplyCreditAuditResponse> ApplyCreditAudit(ApplyCreditAuditRequest req)
        {
             JsonResponseModel<ApplyCreditAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyCreditAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyCreditAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交信审外呼申请，返回当次请求日期。
        /// </summary>
        /// <param name="req"><see cref="ApplyCreditAuditRequest"/></param>
        /// <returns><see cref="ApplyCreditAuditResponse"/></returns>
        public ApplyCreditAuditResponse ApplyCreditAuditSync(ApplyCreditAuditRequest req)
        {
             JsonResponseModel<ApplyCreditAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyCreditAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyCreditAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新机器人任务作业状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotCallStatusRequest"/></param>
        /// <returns><see cref="ChangeBotCallStatusResponse"/></returns>
        public async Task<ChangeBotCallStatusResponse> ChangeBotCallStatus(ChangeBotCallStatusRequest req)
        {
             JsonResponseModel<ChangeBotCallStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeBotCallStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeBotCallStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新机器人任务作业状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotCallStatusRequest"/></param>
        /// <returns><see cref="ChangeBotCallStatusResponse"/></returns>
        public ChangeBotCallStatusResponse ChangeBotCallStatusSync(ChangeBotCallStatusRequest req)
        {
             JsonResponseModel<ChangeBotCallStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeBotCallStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeBotCallStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新机器人任务状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotTaskStatusRequest"/></param>
        /// <returns><see cref="ChangeBotTaskStatusResponse"/></returns>
        public async Task<ChangeBotTaskStatusResponse> ChangeBotTaskStatus(ChangeBotTaskStatusRequest req)
        {
             JsonResponseModel<ChangeBotTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeBotTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeBotTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新机器人任务状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotTaskStatusRequest"/></param>
        /// <returns><see cref="ChangeBotTaskStatusResponse"/></returns>
        public ChangeBotTaskStatusResponse ChangeBotTaskStatusSync(ChangeBotTaskStatusRequest req)
        {
             JsonResponseModel<ChangeBotTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeBotTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeBotTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机器人任务
        /// </summary>
        /// <param name="req"><see cref="CreateBotTaskRequest"/></param>
        /// <returns><see cref="CreateBotTaskResponse"/></returns>
        public async Task<CreateBotTaskResponse> CreateBotTask(CreateBotTaskRequest req)
        {
             JsonResponseModel<CreateBotTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机器人任务
        /// </summary>
        /// <param name="req"><see cref="CreateBotTaskRequest"/></param>
        /// <returns><see cref="CreateBotTaskResponse"/></returns>
        public CreateBotTaskResponse CreateBotTaskSync(CreateBotTaskRequest req)
        {
             JsonResponseModel<CreateBotTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机器人对话流
        /// </summary>
        /// <param name="req"><see cref="DescribeBotFlowRequest"/></param>
        /// <returns><see cref="DescribeBotFlowResponse"/></returns>
        public async Task<DescribeBotFlowResponse> DescribeBotFlow(DescribeBotFlowRequest req)
        {
             JsonResponseModel<DescribeBotFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机器人对话流
        /// </summary>
        /// <param name="req"><see cref="DescribeBotFlowRequest"/></param>
        /// <returns><see cref="DescribeBotFlowResponse"/></returns>
        public DescribeBotFlowResponse DescribeBotFlowSync(DescribeBotFlowRequest req)
        {
             JsonResponseModel<DescribeBotFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据信审任务ID和请求日期，获取相关信审结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeCreditResultRequest"/></param>
        /// <returns><see cref="DescribeCreditResultResponse"/></returns>
        public async Task<DescribeCreditResultResponse> DescribeCreditResult(DescribeCreditResultRequest req)
        {
             JsonResponseModel<DescribeCreditResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCreditResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCreditResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据信审任务ID和请求日期，获取相关信审结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeCreditResultRequest"/></param>
        /// <returns><see cref="DescribeCreditResultResponse"/></returns>
        public DescribeCreditResultResponse DescribeCreditResultSync(DescribeCreditResultRequest req)
        {
             JsonResponseModel<DescribeCreditResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCreditResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCreditResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机器人文件模板
        /// </summary>
        /// <param name="req"><see cref="DescribeFileModelRequest"/></param>
        /// <returns><see cref="DescribeFileModelResponse"/></returns>
        public async Task<DescribeFileModelResponse> DescribeFileModel(DescribeFileModelRequest req)
        {
             JsonResponseModel<DescribeFileModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机器人文件模板
        /// </summary>
        /// <param name="req"><see cref="DescribeFileModelRequest"/></param>
        /// <returns><see cref="DescribeFileModelResponse"/></returns>
        public DescribeFileModelResponse DescribeFileModelSync(DescribeFileModelRequest req)
        {
             JsonResponseModel<DescribeFileModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取指定案件的录音地址，次日早上8:00后可查询前日录音。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRecordsResponse"/></returns>
        public async Task<DescribeRecordsResponse> DescribeRecords(DescribeRecordsRequest req)
        {
             JsonResponseModel<DescribeRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取指定案件的录音地址，次日早上8:00后可查询前日录音。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRecordsResponse"/></returns>
        public DescribeRecordsResponse DescribeRecordsSync(DescribeRecordsRequest req)
        {
             JsonResponseModel<DescribeRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据上传文件接口的输出参数DataResId，获取相关上传结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public async Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据上传文件接口的输出参数DataResId，获取相关上传结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载任务录音与文本，第二天12点后可使用此接口获取对应的录音与文本
        /// </summary>
        /// <param name="req"><see cref="DownloadBotRecordRequest"/></param>
        /// <returns><see cref="DownloadBotRecordResponse"/></returns>
        public async Task<DownloadBotRecordResponse> DownloadBotRecord(DownloadBotRecordRequest req)
        {
             JsonResponseModel<DownloadBotRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadBotRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadBotRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载任务录音与文本，第二天12点后可使用此接口获取对应的录音与文本
        /// </summary>
        /// <param name="req"><see cref="DownloadBotRecordRequest"/></param>
        /// <returns><see cref="DownloadBotRecordResponse"/></returns>
        public DownloadBotRecordResponse DownloadBotRecordSync(DownloadBotRecordRequest req)
        {
             JsonResponseModel<DownloadBotRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadBotRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadBotRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取指定案件的对话文本内容，次日早上8:00后可查询前日对话文本内容。
        /// </summary>
        /// <param name="req"><see cref="DownloadDialogueTextRequest"/></param>
        /// <returns><see cref="DownloadDialogueTextResponse"/></returns>
        public async Task<DownloadDialogueTextResponse> DownloadDialogueText(DownloadDialogueTextRequest req)
        {
             JsonResponseModel<DownloadDialogueTextResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadDialogueText");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadDialogueTextResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取指定案件的对话文本内容，次日早上8:00后可查询前日对话文本内容。
        /// </summary>
        /// <param name="req"><see cref="DownloadDialogueTextRequest"/></param>
        /// <returns><see cref="DownloadDialogueTextResponse"/></returns>
        public DownloadDialogueTextResponse DownloadDialogueTextSync(DownloadDialogueTextRequest req)
        {
             JsonResponseModel<DownloadDialogueTextResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadDialogueText");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadDialogueTextResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p>用于获取录音下载链接清单，次日早上8:00后可查询前日录音清单。</p>
        /// <p>注意：录音清单中的录音下载链接仅次日20:00之前有效，请及时下载。</p>
        /// </summary>
        /// <param name="req"><see cref="DownloadRecordListRequest"/></param>
        /// <returns><see cref="DownloadRecordListResponse"/></returns>
        public async Task<DownloadRecordListResponse> DownloadRecordList(DownloadRecordListRequest req)
        {
             JsonResponseModel<DownloadRecordListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p>用于获取录音下载链接清单，次日早上8:00后可查询前日录音清单。</p>
        /// <p>注意：录音清单中的录音下载链接仅次日20:00之前有效，请及时下载。</p>
        /// </summary>
        /// <param name="req"><see cref="DownloadRecordListRequest"/></param>
        /// <returns><see cref="DownloadRecordListResponse"/></returns>
        public DownloadRecordListResponse DownloadRecordListSync(DownloadRecordListRequest req)
        {
             JsonResponseModel<DownloadRecordListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于下载结果报表。当日23:00后，可获取当日到期/逾期提醒结果，次日00:30后，可获取昨日回访结果。
        /// </summary>
        /// <param name="req"><see cref="DownloadReportRequest"/></param>
        /// <returns><see cref="DownloadReportResponse"/></returns>
        public async Task<DownloadReportResponse> DownloadReport(DownloadReportRequest req)
        {
             JsonResponseModel<DownloadReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于下载结果报表。当日23:00后，可获取当日到期/逾期提醒结果，次日00:30后，可获取昨日回访结果。
        /// </summary>
        /// <param name="req"><see cref="DownloadReportRequest"/></param>
        /// <returns><see cref="DownloadReportResponse"/></returns>
        public DownloadReportResponse DownloadReportSync(DownloadReportRequest req)
        {
             JsonResponseModel<DownloadReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出机器人数据
        /// </summary>
        /// <param name="req"><see cref="ExportBotDataRequest"/></param>
        /// <returns><see cref="ExportBotDataResponse"/></returns>
        public async Task<ExportBotDataResponse> ExportBotData(ExportBotDataRequest req)
        {
             JsonResponseModel<ExportBotDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出机器人数据
        /// </summary>
        /// <param name="req"><see cref="ExportBotDataRequest"/></param>
        /// <returns><see cref="ExportBotDataResponse"/></returns>
        public ExportBotDataResponse ExportBotDataSync(ExportBotDataRequest req)
        {
             JsonResponseModel<ExportBotDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机器人任务状态列表
        /// </summary>
        /// <param name="req"><see cref="QueryBotListRequest"/></param>
        /// <returns><see cref="QueryBotListResponse"/></returns>
        public async Task<QueryBotListResponse> QueryBotList(QueryBotListRequest req)
        {
             JsonResponseModel<QueryBotListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBotList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBotListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机器人任务状态列表
        /// </summary>
        /// <param name="req"><see cref="QueryBotListRequest"/></param>
        /// <returns><see cref="QueryBotListResponse"/></returns>
        public QueryBotListResponse QueryBotListSync(QueryBotListRequest req)
        {
             JsonResponseModel<QueryBotListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBotList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBotListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 机器人任务查询
        /// </summary>
        /// <param name="req"><see cref="QueryCallListRequest"/></param>
        /// <returns><see cref="QueryCallListResponse"/></returns>
        public async Task<QueryCallListResponse> QueryCallList(QueryCallListRequest req)
        {
             JsonResponseModel<QueryCallListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCallList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 机器人任务查询
        /// </summary>
        /// <param name="req"><see cref="QueryCallListRequest"/></param>
        /// <returns><see cref="QueryCallListResponse"/></returns>
        public QueryCallListResponse QueryCallListSync(QueryCallListRequest req)
        {
             JsonResponseModel<QueryCallListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCallList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时数据查询
        /// </summary>
        /// <param name="req"><see cref="QueryInstantDataRequest"/></param>
        /// <returns><see cref="QueryInstantDataResponse"/></returns>
        public async Task<QueryInstantDataResponse> QueryInstantData(QueryInstantDataRequest req)
        {
             JsonResponseModel<QueryInstantDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryInstantData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryInstantDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时数据查询
        /// </summary>
        /// <param name="req"><see cref="QueryInstantDataRequest"/></param>
        /// <returns><see cref="QueryInstantDataResponse"/></returns>
        public QueryInstantDataResponse QueryInstantDataSync(QueryInstantDataRequest req)
        {
             JsonResponseModel<QueryInstantDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryInstantData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryInstantDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品列表
        /// </summary>
        /// <param name="req"><see cref="QueryProductsRequest"/></param>
        /// <returns><see cref="QueryProductsResponse"/></returns>
        public async Task<QueryProductsResponse> QueryProducts(QueryProductsRequest req)
        {
             JsonResponseModel<QueryProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品列表
        /// </summary>
        /// <param name="req"><see cref="QueryProductsRequest"/></param>
        /// <returns><see cref="QueryProductsResponse"/></returns>
        public QueryProductsResponse QueryProductsSync(QueryProductsRequest req)
        {
             JsonResponseModel<QueryProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录音列表
        /// </summary>
        /// <param name="req"><see cref="QueryRecordListRequest"/></param>
        /// <returns><see cref="QueryRecordListResponse"/></returns>
        public async Task<QueryRecordListResponse> QueryRecordList(QueryRecordListRequest req)
        {
             JsonResponseModel<QueryRecordListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询录音列表
        /// </summary>
        /// <param name="req"><see cref="QueryRecordListRequest"/></param>
        /// <returns><see cref="QueryRecordListResponse"/></returns>
        public QueryRecordListResponse QueryRecordListSync(QueryRecordListRequest req)
        {
             JsonResponseModel<QueryRecordListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryRecordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryRecordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新机器人任务
        /// </summary>
        /// <param name="req"><see cref="UpdateBotTaskRequest"/></param>
        /// <returns><see cref="UpdateBotTaskResponse"/></returns>
        public async Task<UpdateBotTaskResponse> UpdateBotTask(UpdateBotTaskRequest req)
        {
             JsonResponseModel<UpdateBotTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateBotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新机器人任务
        /// </summary>
        /// <param name="req"><see cref="UpdateBotTaskRequest"/></param>
        /// <returns><see cref="UpdateBotTaskResponse"/></returns>
        public UpdateBotTaskResponse UpdateBotTaskSync(UpdateBotTaskRequest req)
        {
             JsonResponseModel<UpdateBotTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateBotTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBotTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传机器人任务数据
        /// </summary>
        /// <param name="req"><see cref="UploadBotDataRequest"/></param>
        /// <returns><see cref="UploadBotDataResponse"/></returns>
        public async Task<UploadBotDataResponse> UploadBotData(UploadBotDataRequest req)
        {
             JsonResponseModel<UploadBotDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传机器人任务数据
        /// </summary>
        /// <param name="req"><see cref="UploadBotDataRequest"/></param>
        /// <returns><see cref="UploadBotDataResponse"/></returns>
        public UploadBotDataResponse UploadBotDataSync(UploadBotDataRequest req)
        {
             JsonResponseModel<UploadBotDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadBotData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadBotDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传机器人文件
        /// </summary>
        /// <param name="req"><see cref="UploadBotFileRequest"/></param>
        /// <returns><see cref="UploadBotFileResponse"/></returns>
        public async Task<UploadBotFileResponse> UploadBotFile(UploadBotFileRequest req)
        {
             JsonResponseModel<UploadBotFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadBotFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadBotFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传机器人文件
        /// </summary>
        /// <param name="req"><see cref="UploadBotFileRequest"/></param>
        /// <returns><see cref="UploadBotFileResponse"/></returns>
        public UploadBotFileResponse UploadBotFileSync(UploadBotFileRequest req)
        {
             JsonResponseModel<UploadBotFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadBotFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadBotFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传文件，接口返回数据任务ID，支持xlsx、xls、csv、zip格式。
        /// </summary>
        /// <param name="req"><see cref="UploadDataFileRequest"/></param>
        /// <returns><see cref="UploadDataFileResponse"/></returns>
        public async Task<UploadDataFileResponse> UploadDataFile(UploadDataFileRequest req)
        {
             JsonResponseModel<UploadDataFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadDataFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadDataFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传文件，接口返回数据任务ID，支持xlsx、xls、csv、zip格式。
        /// </summary>
        /// <param name="req"><see cref="UploadDataFileRequest"/></param>
        /// <returns><see cref="UploadDataFileResponse"/></returns>
        public UploadDataFileResponse UploadDataFileSync(UploadDataFileRequest req)
        {
             JsonResponseModel<UploadDataFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadDataFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadDataFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传Json格式数据，接口返回数据任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadDataJsonRequest"/></param>
        /// <returns><see cref="UploadDataJsonResponse"/></returns>
        public async Task<UploadDataJsonResponse> UploadDataJson(UploadDataJsonRequest req)
        {
             JsonResponseModel<UploadDataJsonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadDataJson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadDataJsonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传Json格式数据，接口返回数据任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadDataJsonRequest"/></param>
        /// <returns><see cref="UploadDataJsonResponse"/></returns>
        public UploadDataJsonResponse UploadDataJsonSync(UploadDataJsonRequest req)
        {
             JsonResponseModel<UploadDataJsonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadDataJson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadDataJsonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户通过调用该接口上传需催收文档，格式需为excel格式。接口返回任务ID。
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public async Task<UploadFileResponse> UploadFile(UploadFileRequest req)
        {
             JsonResponseModel<UploadFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 客户通过调用该接口上传需催收文档，格式需为excel格式。接口返回任务ID。
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public UploadFileResponse UploadFileSync(UploadFileRequest req)
        {
             JsonResponseModel<UploadFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
