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

namespace TencentCloud.Acp.V20220105
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Acp.V20220105.Models;

   public class AcpClient : AbstractClient{

       private const string endpoint = "acp.tencentcloudapi.com";
       private const string version = "2022-01-05";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AcpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AcpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建应用合规隐私诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskResponse"/></returns>
        public async Task<CreateAppScanTaskResponse> CreateAppScanTask(CreateAppScanTaskRequest req)
        {
             JsonResponseModel<CreateAppScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAppScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用合规隐私诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskResponse"/></returns>
        public CreateAppScanTaskResponse CreateAppScanTaskSync(CreateAppScanTaskRequest req)
        {
             JsonResponseModel<CreateAppScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAppScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// App应用合规隐私诊断重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskRepeatResponse"/></returns>
        public async Task<CreateAppScanTaskRepeatResponse> CreateAppScanTaskRepeat(CreateAppScanTaskRepeatRequest req)
        {
             JsonResponseModel<CreateAppScanTaskRepeatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAppScanTaskRepeat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppScanTaskRepeatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// App应用合规隐私诊断重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskRepeatResponse"/></returns>
        public CreateAppScanTaskRepeatResponse CreateAppScanTaskRepeatSync(CreateAppScanTaskRepeatRequest req)
        {
             JsonResponseModel<CreateAppScanTaskRepeatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAppScanTaskRepeat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppScanTaskRepeatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用合规文件上传凭证，用于上传诊断文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTicketRequest"/></param>
        /// <returns><see cref="DescribeFileTicketResponse"/></returns>
        public async Task<DescribeFileTicketResponse> DescribeFileTicket(DescribeFileTicketRequest req)
        {
             JsonResponseModel<DescribeFileTicketResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileTicket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTicketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用合规文件上传凭证，用于上传诊断文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTicketRequest"/></param>
        /// <returns><see cref="DescribeFileTicketResponse"/></returns>
        public DescribeFileTicketResponse DescribeFileTicketSync(DescribeFileTicketRequest req)
        {
             JsonResponseModel<DescribeFileTicketResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileTicket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTicketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取App隐私合规诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public async Task<DescribeScanTaskListResponse> DescribeScanTaskList(DescribeScanTaskListRequest req)
        {
             JsonResponseModel<DescribeScanTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取App隐私合规诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public DescribeScanTaskListResponse DescribeScanTaskListSync(DescribeScanTaskListRequest req)
        {
             JsonResponseModel<DescribeScanTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取App合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeScanTaskReportUrlResponse"/></returns>
        public async Task<DescribeScanTaskReportUrlResponse> DescribeScanTaskReportUrl(DescribeScanTaskReportUrlRequest req)
        {
             JsonResponseModel<DescribeScanTaskReportUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanTaskReportUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskReportUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取App合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeScanTaskReportUrlResponse"/></returns>
        public DescribeScanTaskReportUrlResponse DescribeScanTaskReportUrlSync(DescribeScanTaskReportUrlRequest req)
        {
             JsonResponseModel<DescribeScanTaskReportUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanTaskReportUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskReportUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询App隐私合规诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public async Task<DescribeScanTaskStatusResponse> DescribeScanTaskStatus(DescribeScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询App隐私合规诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public DescribeScanTaskStatusResponse DescribeScanTaskStatusSync(DescribeScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
