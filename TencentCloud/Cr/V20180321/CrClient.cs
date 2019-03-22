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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public CrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public CrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 加入黑名单的客户，将停止拨打。用于：
        /// 将客户进行黑名单的增加和移除，用于对某些客户阶段性停催。
        /// </summary>
        /// <param name="req">参考<see cref="ApplyBlackListRequest"/></param>
        /// <returns>参考<see cref="ApplyBlackListResponse"/>实例</returns>
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
        /// 提交信审外呼申请，返回当次请求日期。
        /// </summary>
        /// <param name="req">参考<see cref="ApplyCreditAuditRequest"/></param>
        /// <returns>参考<see cref="ApplyCreditAuditResponse"/>实例</returns>
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
        /// 根据信审任务ID和请求日期，获取相关信审结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCreditResultRequest"/></param>
        /// <returns>参考<see cref="DescribeCreditResultResponse"/>实例</returns>
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
        /// 用于获取指定案件的录音地址，次日早上8:00后可查询前日录音。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRecordsRequest"/></param>
        /// <returns>参考<see cref="DescribeRecordsResponse"/>实例</returns>
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
        /// 根据上传文件接口的输出参数DataResId，获取相关上传结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskStatusResponse"/>实例</returns>
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
        /// 用于下载当日催收和回访结果报表。当日23:00后，可获取当日催收结果，次日00:30后，可获取昨日回访结果。
        /// </summary>
        /// <param name="req">参考<see cref="DownloadReportRequest"/></param>
        /// <returns>参考<see cref="DownloadReportResponse"/>实例</returns>
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
        /// 该接口包含上传：
        /// 1、入催文件 — 用于每天入催文件的上传；
        /// 2、还款文件 — 实时上传当前已还款客户，用于还款客户的实时停催；
        /// 接口返回数据任务ID，支持xlsx、xls、csv、zip格式，文档大小不超过50MB。
        /// </summary>
        /// <param name="req">参考<see cref="UploadDataFileRequest"/></param>
        /// <returns>参考<see cref="UploadDataFileResponse"/>实例</returns>
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
        /// 客户通过调用该接口上传需催收文档，格式需为excel格式。接口返回任务ID。
        /// </summary>
        /// <param name="req">参考<see cref="UploadFileRequest"/></param>
        /// <returns>参考<see cref="UploadFileResponse"/>实例</returns>
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

    }
}
