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
       private const string sdkVersion = "SDK_NET_3.0.1001";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提交黑名单后，黑名单中有效期内的号码将停止拨打，适用于到期/逾期提醒、回访场景。
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListRequest"/></param>
        /// <returns><see cref="ApplyBlackListResponse"/></returns>
        public Task<ApplyBlackListResponse> ApplyBlackList(ApplyBlackListRequest req)
        {
            return InternalRequestAsync<ApplyBlackListResponse>(req, "ApplyBlackList");
        }

        /// <summary>
        /// 提交黑名单后，黑名单中有效期内的号码将停止拨打，适用于到期/逾期提醒、回访场景。
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListRequest"/></param>
        /// <returns><see cref="ApplyBlackListResponse"/></returns>
        public ApplyBlackListResponse ApplyBlackListSync(ApplyBlackListRequest req)
        {
            return InternalRequestAsync<ApplyBlackListResponse>(req, "ApplyBlackList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交机器人黑名单申请
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListDataRequest"/></param>
        /// <returns><see cref="ApplyBlackListDataResponse"/></returns>
        public Task<ApplyBlackListDataResponse> ApplyBlackListData(ApplyBlackListDataRequest req)
        {
            return InternalRequestAsync<ApplyBlackListDataResponse>(req, "ApplyBlackListData");
        }

        /// <summary>
        /// 提交机器人黑名单申请
        /// </summary>
        /// <param name="req"><see cref="ApplyBlackListDataRequest"/></param>
        /// <returns><see cref="ApplyBlackListDataResponse"/></returns>
        public ApplyBlackListDataResponse ApplyBlackListDataSync(ApplyBlackListDataRequest req)
        {
            return InternalRequestAsync<ApplyBlackListDataResponse>(req, "ApplyBlackListData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交信审外呼申请，返回当次请求日期。
        /// </summary>
        /// <param name="req"><see cref="ApplyCreditAuditRequest"/></param>
        /// <returns><see cref="ApplyCreditAuditResponse"/></returns>
        public Task<ApplyCreditAuditResponse> ApplyCreditAudit(ApplyCreditAuditRequest req)
        {
            return InternalRequestAsync<ApplyCreditAuditResponse>(req, "ApplyCreditAudit");
        }

        /// <summary>
        /// 提交信审外呼申请，返回当次请求日期。
        /// </summary>
        /// <param name="req"><see cref="ApplyCreditAuditRequest"/></param>
        /// <returns><see cref="ApplyCreditAuditResponse"/></returns>
        public ApplyCreditAuditResponse ApplyCreditAuditSync(ApplyCreditAuditRequest req)
        {
            return InternalRequestAsync<ApplyCreditAuditResponse>(req, "ApplyCreditAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新机器人任务作业状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotCallStatusRequest"/></param>
        /// <returns><see cref="ChangeBotCallStatusResponse"/></returns>
        public Task<ChangeBotCallStatusResponse> ChangeBotCallStatus(ChangeBotCallStatusRequest req)
        {
            return InternalRequestAsync<ChangeBotCallStatusResponse>(req, "ChangeBotCallStatus");
        }

        /// <summary>
        /// 更新机器人任务作业状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotCallStatusRequest"/></param>
        /// <returns><see cref="ChangeBotCallStatusResponse"/></returns>
        public ChangeBotCallStatusResponse ChangeBotCallStatusSync(ChangeBotCallStatusRequest req)
        {
            return InternalRequestAsync<ChangeBotCallStatusResponse>(req, "ChangeBotCallStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新机器人任务状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotTaskStatusRequest"/></param>
        /// <returns><see cref="ChangeBotTaskStatusResponse"/></returns>
        public Task<ChangeBotTaskStatusResponse> ChangeBotTaskStatus(ChangeBotTaskStatusRequest req)
        {
            return InternalRequestAsync<ChangeBotTaskStatusResponse>(req, "ChangeBotTaskStatus");
        }

        /// <summary>
        /// 更新机器人任务状态
        /// </summary>
        /// <param name="req"><see cref="ChangeBotTaskStatusRequest"/></param>
        /// <returns><see cref="ChangeBotTaskStatusResponse"/></returns>
        public ChangeBotTaskStatusResponse ChangeBotTaskStatusSync(ChangeBotTaskStatusRequest req)
        {
            return InternalRequestAsync<ChangeBotTaskStatusResponse>(req, "ChangeBotTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建机器人任务
        /// </summary>
        /// <param name="req"><see cref="CreateBotTaskRequest"/></param>
        /// <returns><see cref="CreateBotTaskResponse"/></returns>
        public Task<CreateBotTaskResponse> CreateBotTask(CreateBotTaskRequest req)
        {
            return InternalRequestAsync<CreateBotTaskResponse>(req, "CreateBotTask");
        }

        /// <summary>
        /// 创建机器人任务
        /// </summary>
        /// <param name="req"><see cref="CreateBotTaskRequest"/></param>
        /// <returns><see cref="CreateBotTaskResponse"/></returns>
        public CreateBotTaskResponse CreateBotTaskSync(CreateBotTaskRequest req)
        {
            return InternalRequestAsync<CreateBotTaskResponse>(req, "CreateBotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询机器人对话流
        /// </summary>
        /// <param name="req"><see cref="DescribeBotFlowRequest"/></param>
        /// <returns><see cref="DescribeBotFlowResponse"/></returns>
        public Task<DescribeBotFlowResponse> DescribeBotFlow(DescribeBotFlowRequest req)
        {
            return InternalRequestAsync<DescribeBotFlowResponse>(req, "DescribeBotFlow");
        }

        /// <summary>
        /// 查询机器人对话流
        /// </summary>
        /// <param name="req"><see cref="DescribeBotFlowRequest"/></param>
        /// <returns><see cref="DescribeBotFlowResponse"/></returns>
        public DescribeBotFlowResponse DescribeBotFlowSync(DescribeBotFlowRequest req)
        {
            return InternalRequestAsync<DescribeBotFlowResponse>(req, "DescribeBotFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据信审任务ID和请求日期，获取相关信审结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeCreditResultRequest"/></param>
        /// <returns><see cref="DescribeCreditResultResponse"/></returns>
        public Task<DescribeCreditResultResponse> DescribeCreditResult(DescribeCreditResultRequest req)
        {
            return InternalRequestAsync<DescribeCreditResultResponse>(req, "DescribeCreditResult");
        }

        /// <summary>
        /// 根据信审任务ID和请求日期，获取相关信审结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeCreditResultRequest"/></param>
        /// <returns><see cref="DescribeCreditResultResponse"/></returns>
        public DescribeCreditResultResponse DescribeCreditResultSync(DescribeCreditResultRequest req)
        {
            return InternalRequestAsync<DescribeCreditResultResponse>(req, "DescribeCreditResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询机器人文件模板
        /// </summary>
        /// <param name="req"><see cref="DescribeFileModelRequest"/></param>
        /// <returns><see cref="DescribeFileModelResponse"/></returns>
        public Task<DescribeFileModelResponse> DescribeFileModel(DescribeFileModelRequest req)
        {
            return InternalRequestAsync<DescribeFileModelResponse>(req, "DescribeFileModel");
        }

        /// <summary>
        /// 查询机器人文件模板
        /// </summary>
        /// <param name="req"><see cref="DescribeFileModelRequest"/></param>
        /// <returns><see cref="DescribeFileModelResponse"/></returns>
        public DescribeFileModelResponse DescribeFileModelSync(DescribeFileModelRequest req)
        {
            return InternalRequestAsync<DescribeFileModelResponse>(req, "DescribeFileModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取指定案件的录音地址，次日早上8:00后可查询前日录音。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRecordsResponse"/></returns>
        public Task<DescribeRecordsResponse> DescribeRecords(DescribeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeRecordsResponse>(req, "DescribeRecords");
        }

        /// <summary>
        /// 用于获取指定案件的录音地址，次日早上8:00后可查询前日录音。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordsRequest"/></param>
        /// <returns><see cref="DescribeRecordsResponse"/></returns>
        public DescribeRecordsResponse DescribeRecordsSync(DescribeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeRecordsResponse>(req, "DescribeRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据上传文件接口的输出参数DataResId，获取相关上传结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 根据上传文件接口的输出参数DataResId，获取相关上传结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载任务录音与文本，第二天12点后可使用此接口获取对应的录音与文本
        /// </summary>
        /// <param name="req"><see cref="DownloadBotRecordRequest"/></param>
        /// <returns><see cref="DownloadBotRecordResponse"/></returns>
        public Task<DownloadBotRecordResponse> DownloadBotRecord(DownloadBotRecordRequest req)
        {
            return InternalRequestAsync<DownloadBotRecordResponse>(req, "DownloadBotRecord");
        }

        /// <summary>
        /// 下载任务录音与文本，第二天12点后可使用此接口获取对应的录音与文本
        /// </summary>
        /// <param name="req"><see cref="DownloadBotRecordRequest"/></param>
        /// <returns><see cref="DownloadBotRecordResponse"/></returns>
        public DownloadBotRecordResponse DownloadBotRecordSync(DownloadBotRecordRequest req)
        {
            return InternalRequestAsync<DownloadBotRecordResponse>(req, "DownloadBotRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取指定案件的对话文本内容，次日早上8:00后可查询前日对话文本内容。
        /// </summary>
        /// <param name="req"><see cref="DownloadDialogueTextRequest"/></param>
        /// <returns><see cref="DownloadDialogueTextResponse"/></returns>
        public Task<DownloadDialogueTextResponse> DownloadDialogueText(DownloadDialogueTextRequest req)
        {
            return InternalRequestAsync<DownloadDialogueTextResponse>(req, "DownloadDialogueText");
        }

        /// <summary>
        /// 用于获取指定案件的对话文本内容，次日早上8:00后可查询前日对话文本内容。
        /// </summary>
        /// <param name="req"><see cref="DownloadDialogueTextRequest"/></param>
        /// <returns><see cref="DownloadDialogueTextResponse"/></returns>
        public DownloadDialogueTextResponse DownloadDialogueTextSync(DownloadDialogueTextRequest req)
        {
            return InternalRequestAsync<DownloadDialogueTextResponse>(req, "DownloadDialogueText")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>用于获取录音下载链接清单，次日早上8:00后可查询前日录音清单。</p>
        /// <p>注意：录音清单中的录音下载链接仅次日20:00之前有效，请及时下载。</p>
        /// </summary>
        /// <param name="req"><see cref="DownloadRecordListRequest"/></param>
        /// <returns><see cref="DownloadRecordListResponse"/></returns>
        public Task<DownloadRecordListResponse> DownloadRecordList(DownloadRecordListRequest req)
        {
            return InternalRequestAsync<DownloadRecordListResponse>(req, "DownloadRecordList");
        }

        /// <summary>
        /// <p>用于获取录音下载链接清单，次日早上8:00后可查询前日录音清单。</p>
        /// <p>注意：录音清单中的录音下载链接仅次日20:00之前有效，请及时下载。</p>
        /// </summary>
        /// <param name="req"><see cref="DownloadRecordListRequest"/></param>
        /// <returns><see cref="DownloadRecordListResponse"/></returns>
        public DownloadRecordListResponse DownloadRecordListSync(DownloadRecordListRequest req)
        {
            return InternalRequestAsync<DownloadRecordListResponse>(req, "DownloadRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于下载结果报表。当日23:00后，可获取当日到期/逾期提醒结果，次日00:30后，可获取昨日回访结果。
        /// </summary>
        /// <param name="req"><see cref="DownloadReportRequest"/></param>
        /// <returns><see cref="DownloadReportResponse"/></returns>
        public Task<DownloadReportResponse> DownloadReport(DownloadReportRequest req)
        {
            return InternalRequestAsync<DownloadReportResponse>(req, "DownloadReport");
        }

        /// <summary>
        /// 用于下载结果报表。当日23:00后，可获取当日到期/逾期提醒结果，次日00:30后，可获取昨日回访结果。
        /// </summary>
        /// <param name="req"><see cref="DownloadReportRequest"/></param>
        /// <returns><see cref="DownloadReportResponse"/></returns>
        public DownloadReportResponse DownloadReportSync(DownloadReportRequest req)
        {
            return InternalRequestAsync<DownloadReportResponse>(req, "DownloadReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出机器人数据
        /// </summary>
        /// <param name="req"><see cref="ExportBotDataRequest"/></param>
        /// <returns><see cref="ExportBotDataResponse"/></returns>
        public Task<ExportBotDataResponse> ExportBotData(ExportBotDataRequest req)
        {
            return InternalRequestAsync<ExportBotDataResponse>(req, "ExportBotData");
        }

        /// <summary>
        /// 导出机器人数据
        /// </summary>
        /// <param name="req"><see cref="ExportBotDataRequest"/></param>
        /// <returns><see cref="ExportBotDataResponse"/></returns>
        public ExportBotDataResponse ExportBotDataSync(ExportBotDataRequest req)
        {
            return InternalRequestAsync<ExportBotDataResponse>(req, "ExportBotData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看黑名单数据列表
        /// </summary>
        /// <param name="req"><see cref="QueryBlackListDataRequest"/></param>
        /// <returns><see cref="QueryBlackListDataResponse"/></returns>
        public Task<QueryBlackListDataResponse> QueryBlackListData(QueryBlackListDataRequest req)
        {
            return InternalRequestAsync<QueryBlackListDataResponse>(req, "QueryBlackListData");
        }

        /// <summary>
        /// 查看黑名单数据列表
        /// </summary>
        /// <param name="req"><see cref="QueryBlackListDataRequest"/></param>
        /// <returns><see cref="QueryBlackListDataResponse"/></returns>
        public QueryBlackListDataResponse QueryBlackListDataSync(QueryBlackListDataRequest req)
        {
            return InternalRequestAsync<QueryBlackListDataResponse>(req, "QueryBlackListData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询机器人任务状态列表
        /// </summary>
        /// <param name="req"><see cref="QueryBotListRequest"/></param>
        /// <returns><see cref="QueryBotListResponse"/></returns>
        public Task<QueryBotListResponse> QueryBotList(QueryBotListRequest req)
        {
            return InternalRequestAsync<QueryBotListResponse>(req, "QueryBotList");
        }

        /// <summary>
        /// 查询机器人任务状态列表
        /// </summary>
        /// <param name="req"><see cref="QueryBotListRequest"/></param>
        /// <returns><see cref="QueryBotListResponse"/></returns>
        public QueryBotListResponse QueryBotListSync(QueryBotListRequest req)
        {
            return InternalRequestAsync<QueryBotListResponse>(req, "QueryBotList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 机器人任务查询
        /// </summary>
        /// <param name="req"><see cref="QueryCallListRequest"/></param>
        /// <returns><see cref="QueryCallListResponse"/></returns>
        public Task<QueryCallListResponse> QueryCallList(QueryCallListRequest req)
        {
            return InternalRequestAsync<QueryCallListResponse>(req, "QueryCallList");
        }

        /// <summary>
        /// 机器人任务查询
        /// </summary>
        /// <param name="req"><see cref="QueryCallListRequest"/></param>
        /// <returns><see cref="QueryCallListResponse"/></returns>
        public QueryCallListResponse QueryCallListSync(QueryCallListRequest req)
        {
            return InternalRequestAsync<QueryCallListResponse>(req, "QueryCallList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实时数据查询
        /// </summary>
        /// <param name="req"><see cref="QueryInstantDataRequest"/></param>
        /// <returns><see cref="QueryInstantDataResponse"/></returns>
        public Task<QueryInstantDataResponse> QueryInstantData(QueryInstantDataRequest req)
        {
            return InternalRequestAsync<QueryInstantDataResponse>(req, "QueryInstantData");
        }

        /// <summary>
        /// 实时数据查询
        /// </summary>
        /// <param name="req"><see cref="QueryInstantDataRequest"/></param>
        /// <returns><see cref="QueryInstantDataResponse"/></returns>
        public QueryInstantDataResponse QueryInstantDataSync(QueryInstantDataRequest req)
        {
            return InternalRequestAsync<QueryInstantDataResponse>(req, "QueryInstantData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询产品列表
        /// </summary>
        /// <param name="req"><see cref="QueryProductsRequest"/></param>
        /// <returns><see cref="QueryProductsResponse"/></returns>
        public Task<QueryProductsResponse> QueryProducts(QueryProductsRequest req)
        {
            return InternalRequestAsync<QueryProductsResponse>(req, "QueryProducts");
        }

        /// <summary>
        /// 查询产品列表
        /// </summary>
        /// <param name="req"><see cref="QueryProductsRequest"/></param>
        /// <returns><see cref="QueryProductsResponse"/></returns>
        public QueryProductsResponse QueryProductsSync(QueryProductsRequest req)
        {
            return InternalRequestAsync<QueryProductsResponse>(req, "QueryProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询录音列表
        /// </summary>
        /// <param name="req"><see cref="QueryRecordListRequest"/></param>
        /// <returns><see cref="QueryRecordListResponse"/></returns>
        public Task<QueryRecordListResponse> QueryRecordList(QueryRecordListRequest req)
        {
            return InternalRequestAsync<QueryRecordListResponse>(req, "QueryRecordList");
        }

        /// <summary>
        /// 查询录音列表
        /// </summary>
        /// <param name="req"><see cref="QueryRecordListRequest"/></param>
        /// <returns><see cref="QueryRecordListResponse"/></returns>
        public QueryRecordListResponse QueryRecordListSync(QueryRecordListRequest req)
        {
            return InternalRequestAsync<QueryRecordListResponse>(req, "QueryRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新机器人任务
        /// </summary>
        /// <param name="req"><see cref="UpdateBotTaskRequest"/></param>
        /// <returns><see cref="UpdateBotTaskResponse"/></returns>
        public Task<UpdateBotTaskResponse> UpdateBotTask(UpdateBotTaskRequest req)
        {
            return InternalRequestAsync<UpdateBotTaskResponse>(req, "UpdateBotTask");
        }

        /// <summary>
        /// 更新机器人任务
        /// </summary>
        /// <param name="req"><see cref="UpdateBotTaskRequest"/></param>
        /// <returns><see cref="UpdateBotTaskResponse"/></returns>
        public UpdateBotTaskResponse UpdateBotTaskSync(UpdateBotTaskRequest req)
        {
            return InternalRequestAsync<UpdateBotTaskResponse>(req, "UpdateBotTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传机器人任务数据
        /// </summary>
        /// <param name="req"><see cref="UploadBotDataRequest"/></param>
        /// <returns><see cref="UploadBotDataResponse"/></returns>
        public Task<UploadBotDataResponse> UploadBotData(UploadBotDataRequest req)
        {
            return InternalRequestAsync<UploadBotDataResponse>(req, "UploadBotData");
        }

        /// <summary>
        /// 上传机器人任务数据
        /// </summary>
        /// <param name="req"><see cref="UploadBotDataRequest"/></param>
        /// <returns><see cref="UploadBotDataResponse"/></returns>
        public UploadBotDataResponse UploadBotDataSync(UploadBotDataRequest req)
        {
            return InternalRequestAsync<UploadBotDataResponse>(req, "UploadBotData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传机器人文件
        /// </summary>
        /// <param name="req"><see cref="UploadBotFileRequest"/></param>
        /// <returns><see cref="UploadBotFileResponse"/></returns>
        public Task<UploadBotFileResponse> UploadBotFile(UploadBotFileRequest req)
        {
            return InternalRequestAsync<UploadBotFileResponse>(req, "UploadBotFile");
        }

        /// <summary>
        /// 上传机器人文件
        /// </summary>
        /// <param name="req"><see cref="UploadBotFileRequest"/></param>
        /// <returns><see cref="UploadBotFileResponse"/></returns>
        public UploadBotFileResponse UploadBotFileSync(UploadBotFileRequest req)
        {
            return InternalRequestAsync<UploadBotFileResponse>(req, "UploadBotFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传文件，接口返回数据任务ID，支持xlsx、xls、csv、zip格式。
        /// </summary>
        /// <param name="req"><see cref="UploadDataFileRequest"/></param>
        /// <returns><see cref="UploadDataFileResponse"/></returns>
        public Task<UploadDataFileResponse> UploadDataFile(UploadDataFileRequest req)
        {
            return InternalRequestAsync<UploadDataFileResponse>(req, "UploadDataFile");
        }

        /// <summary>
        /// 上传文件，接口返回数据任务ID，支持xlsx、xls、csv、zip格式。
        /// </summary>
        /// <param name="req"><see cref="UploadDataFileRequest"/></param>
        /// <returns><see cref="UploadDataFileResponse"/></returns>
        public UploadDataFileResponse UploadDataFileSync(UploadDataFileRequest req)
        {
            return InternalRequestAsync<UploadDataFileResponse>(req, "UploadDataFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传Json格式数据，接口返回数据任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadDataJsonRequest"/></param>
        /// <returns><see cref="UploadDataJsonResponse"/></returns>
        public Task<UploadDataJsonResponse> UploadDataJson(UploadDataJsonRequest req)
        {
            return InternalRequestAsync<UploadDataJsonResponse>(req, "UploadDataJson");
        }

        /// <summary>
        /// 上传Json格式数据，接口返回数据任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadDataJsonRequest"/></param>
        /// <returns><see cref="UploadDataJsonResponse"/></returns>
        public UploadDataJsonResponse UploadDataJsonSync(UploadDataJsonRequest req)
        {
            return InternalRequestAsync<UploadDataJsonResponse>(req, "UploadDataJson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 客户通过调用该接口上传需催收文档，格式需为excel格式。接口返回任务ID。
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public Task<UploadFileResponse> UploadFile(UploadFileRequest req)
        {
            return InternalRequestAsync<UploadFileResponse>(req, "UploadFile");
        }

        /// <summary>
        /// 客户通过调用该接口上传需催收文档，格式需为excel格式。接口返回任务ID。
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public UploadFileResponse UploadFileSync(UploadFileRequest req)
        {
            return InternalRequestAsync<UploadFileResponse>(req, "UploadFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
