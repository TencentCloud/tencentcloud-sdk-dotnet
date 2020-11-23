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
