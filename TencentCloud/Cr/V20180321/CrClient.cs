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
        /// 提交黑名单申请。
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
        /// 查询录音，返回录音列表。
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
        /// 客户调用该接口查看任务执行状态。输入任务ID，输出任务执行状态或者结果
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
        /// 客户调用该接口下载指定日期的催收报告
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
        /// 客户通过调用该接口上传需催收文档或还款文档，接口返回任务ID。
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
