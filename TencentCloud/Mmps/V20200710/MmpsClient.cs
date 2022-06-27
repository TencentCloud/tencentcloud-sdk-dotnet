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

namespace TencentCloud.Mmps.V20200710
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mmps.V20200710.Models;

   public class MmpsClient : AbstractClient{

       private const string endpoint = "mmps.tencentcloudapi.com";
       private const string version = "2020-07-10";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MmpsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MmpsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建小程序隐私合规诊断任务
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
        /// 创建小程序隐私合规诊断任务
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
        /// 小程序隐私合规诊断重试任务
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
        /// 小程序隐私合规诊断重试任务
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
        /// 创建小程序翼扬安全的基础或深度诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskResponse"/></returns>
        public async Task<CreateFlySecMiniAppScanTaskResponse> CreateFlySecMiniAppScanTask(CreateFlySecMiniAppScanTaskRequest req)
        {
             JsonResponseModel<CreateFlySecMiniAppScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlySecMiniAppScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlySecMiniAppScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建小程序翼扬安全的基础或深度诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskResponse"/></returns>
        public CreateFlySecMiniAppScanTaskResponse CreateFlySecMiniAppScanTaskSync(CreateFlySecMiniAppScanTaskRequest req)
        {
             JsonResponseModel<CreateFlySecMiniAppScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlySecMiniAppScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlySecMiniAppScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新提交基础诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskRepeatResponse"/></returns>
        public async Task<CreateFlySecMiniAppScanTaskRepeatResponse> CreateFlySecMiniAppScanTaskRepeat(CreateFlySecMiniAppScanTaskRepeatRequest req)
        {
             JsonResponseModel<CreateFlySecMiniAppScanTaskRepeatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlySecMiniAppScanTaskRepeat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlySecMiniAppScanTaskRepeatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新提交基础诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskRepeatResponse"/></returns>
        public CreateFlySecMiniAppScanTaskRepeatResponse CreateFlySecMiniAppScanTaskRepeatSync(CreateFlySecMiniAppScanTaskRepeatRequest req)
        {
             JsonResponseModel<CreateFlySecMiniAppScanTaskRepeatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlySecMiniAppScanTaskRepeat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlySecMiniAppScanTaskRepeatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询翼扬安全基础诊断资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDiagnosisResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeBasicDiagnosisResourceUsageInfoResponse"/></returns>
        public async Task<DescribeBasicDiagnosisResourceUsageInfoResponse> DescribeBasicDiagnosisResourceUsageInfo(DescribeBasicDiagnosisResourceUsageInfoRequest req)
        {
             JsonResponseModel<DescribeBasicDiagnosisResourceUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicDiagnosisResourceUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDiagnosisResourceUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询翼扬安全基础诊断资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDiagnosisResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeBasicDiagnosisResourceUsageInfoResponse"/></returns>
        public DescribeBasicDiagnosisResourceUsageInfoResponse DescribeBasicDiagnosisResourceUsageInfoSync(DescribeBasicDiagnosisResourceUsageInfoRequest req)
        {
             JsonResponseModel<DescribeBasicDiagnosisResourceUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicDiagnosisResourceUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDiagnosisResourceUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取翼扬诊断任务报告链接地址
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppReportUrlRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppReportUrlResponse"/></returns>
        public async Task<DescribeFlySecMiniAppReportUrlResponse> DescribeFlySecMiniAppReportUrl(DescribeFlySecMiniAppReportUrlRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppReportUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlySecMiniAppReportUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppReportUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取翼扬诊断任务报告链接地址
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppReportUrlRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppReportUrlResponse"/></returns>
        public DescribeFlySecMiniAppReportUrlResponse DescribeFlySecMiniAppReportUrlSync(DescribeFlySecMiniAppReportUrlRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppReportUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlySecMiniAppReportUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppReportUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定小程序版本的翼扬诊断安全得分
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanReportListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanReportListResponse"/></returns>
        public async Task<DescribeFlySecMiniAppScanReportListResponse> DescribeFlySecMiniAppScanReportList(DescribeFlySecMiniAppScanReportListRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanReportListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlySecMiniAppScanReportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanReportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定小程序版本的翼扬诊断安全得分
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanReportListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanReportListResponse"/></returns>
        public DescribeFlySecMiniAppScanReportListResponse DescribeFlySecMiniAppScanReportListSync(DescribeFlySecMiniAppScanReportListRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanReportListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlySecMiniAppScanReportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanReportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取翼扬安全诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskListResponse"/></returns>
        public async Task<DescribeFlySecMiniAppScanTaskListResponse> DescribeFlySecMiniAppScanTaskList(DescribeFlySecMiniAppScanTaskListRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlySecMiniAppScanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取翼扬安全诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskListResponse"/></returns>
        public DescribeFlySecMiniAppScanTaskListResponse DescribeFlySecMiniAppScanTaskListSync(DescribeFlySecMiniAppScanTaskListRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlySecMiniAppScanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户提交的基础诊断任务参数信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskParamRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskParamResponse"/></returns>
        public async Task<DescribeFlySecMiniAppScanTaskParamResponse> DescribeFlySecMiniAppScanTaskParam(DescribeFlySecMiniAppScanTaskParamRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanTaskParamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlySecMiniAppScanTaskParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanTaskParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户提交的基础诊断任务参数信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskParamRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskParamResponse"/></returns>
        public DescribeFlySecMiniAppScanTaskParamResponse DescribeFlySecMiniAppScanTaskParamSync(DescribeFlySecMiniAppScanTaskParamRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanTaskParamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlySecMiniAppScanTaskParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanTaskParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询翼扬安全诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskStatusResponse"/></returns>
        public async Task<DescribeFlySecMiniAppScanTaskStatusResponse> DescribeFlySecMiniAppScanTaskStatus(DescribeFlySecMiniAppScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlySecMiniAppScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询翼扬安全诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskStatusResponse"/></returns>
        public DescribeFlySecMiniAppScanTaskStatusResponse DescribeFlySecMiniAppScanTaskStatusSync(DescribeFlySecMiniAppScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeFlySecMiniAppScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlySecMiniAppScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlySecMiniAppScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询翼扬安全资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageInfoResponse"/></returns>
        public async Task<DescribeResourceUsageInfoResponse> DescribeResourceUsageInfo(DescribeResourceUsageInfoRequest req)
        {
             JsonResponseModel<DescribeResourceUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询翼扬安全资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageInfoResponse"/></returns>
        public DescribeResourceUsageInfoResponse DescribeResourceUsageInfoSync(DescribeResourceUsageInfoRequest req)
        {
             JsonResponseModel<DescribeResourceUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取小程序隐私合规诊断任务列表
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
        /// 获取小程序隐私合规诊断任务列表
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
        /// 获取小程序合规诊断任务报告url
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
        /// 获取小程序合规诊断任务报告url
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
        /// 查询小程序隐私合规诊断任务状态
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
        /// 查询小程序隐私合规诊断任务状态
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
