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
       private const string sdkVersion = "SDK_NET_3.0.955";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MmpsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建小程序隐私合规诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskResponse"/></returns>
        public Task<CreateAppScanTaskResponse> CreateAppScanTask(CreateAppScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskResponse>(req, "CreateAppScanTask");
        }

        /// <summary>
        /// 创建小程序隐私合规诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskResponse"/></returns>
        public CreateAppScanTaskResponse CreateAppScanTaskSync(CreateAppScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskResponse>(req, "CreateAppScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 小程序隐私合规诊断重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskRepeatResponse"/></returns>
        public Task<CreateAppScanTaskRepeatResponse> CreateAppScanTaskRepeat(CreateAppScanTaskRepeatRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskRepeatResponse>(req, "CreateAppScanTaskRepeat");
        }

        /// <summary>
        /// 小程序隐私合规诊断重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskRepeatResponse"/></returns>
        public CreateAppScanTaskRepeatResponse CreateAppScanTaskRepeatSync(CreateAppScanTaskRepeatRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskRepeatResponse>(req, "CreateAppScanTaskRepeat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建小程序安全深度诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppProfessionalScanTaskRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppProfessionalScanTaskResponse"/></returns>
        public Task<CreateFlySecMiniAppProfessionalScanTaskResponse> CreateFlySecMiniAppProfessionalScanTask(CreateFlySecMiniAppProfessionalScanTaskRequest req)
        {
            return InternalRequestAsync<CreateFlySecMiniAppProfessionalScanTaskResponse>(req, "CreateFlySecMiniAppProfessionalScanTask");
        }

        /// <summary>
        /// 创建小程序安全深度诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppProfessionalScanTaskRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppProfessionalScanTaskResponse"/></returns>
        public CreateFlySecMiniAppProfessionalScanTaskResponse CreateFlySecMiniAppProfessionalScanTaskSync(CreateFlySecMiniAppProfessionalScanTaskRequest req)
        {
            return InternalRequestAsync<CreateFlySecMiniAppProfessionalScanTaskResponse>(req, "CreateFlySecMiniAppProfessionalScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建小程序翼扬安全的基础或深度诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskResponse"/></returns>
        public Task<CreateFlySecMiniAppScanTaskResponse> CreateFlySecMiniAppScanTask(CreateFlySecMiniAppScanTaskRequest req)
        {
            return InternalRequestAsync<CreateFlySecMiniAppScanTaskResponse>(req, "CreateFlySecMiniAppScanTask");
        }

        /// <summary>
        /// 创建小程序翼扬安全的基础或深度诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskResponse"/></returns>
        public CreateFlySecMiniAppScanTaskResponse CreateFlySecMiniAppScanTaskSync(CreateFlySecMiniAppScanTaskRequest req)
        {
            return InternalRequestAsync<CreateFlySecMiniAppScanTaskResponse>(req, "CreateFlySecMiniAppScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新提交基础诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskRepeatResponse"/></returns>
        public Task<CreateFlySecMiniAppScanTaskRepeatResponse> CreateFlySecMiniAppScanTaskRepeat(CreateFlySecMiniAppScanTaskRepeatRequest req)
        {
            return InternalRequestAsync<CreateFlySecMiniAppScanTaskRepeatResponse>(req, "CreateFlySecMiniAppScanTaskRepeat");
        }

        /// <summary>
        /// 重新提交基础诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateFlySecMiniAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateFlySecMiniAppScanTaskRepeatResponse"/></returns>
        public CreateFlySecMiniAppScanTaskRepeatResponse CreateFlySecMiniAppScanTaskRepeatSync(CreateFlySecMiniAppScanTaskRepeatRequest req)
        {
            return InternalRequestAsync<CreateFlySecMiniAppScanTaskRepeatResponse>(req, "CreateFlySecMiniAppScanTaskRepeat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询翼扬安全基础诊断资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDiagnosisResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeBasicDiagnosisResourceUsageInfoResponse"/></returns>
        public Task<DescribeBasicDiagnosisResourceUsageInfoResponse> DescribeBasicDiagnosisResourceUsageInfo(DescribeBasicDiagnosisResourceUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeBasicDiagnosisResourceUsageInfoResponse>(req, "DescribeBasicDiagnosisResourceUsageInfo");
        }

        /// <summary>
        /// 查询翼扬安全基础诊断资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDiagnosisResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeBasicDiagnosisResourceUsageInfoResponse"/></returns>
        public DescribeBasicDiagnosisResourceUsageInfoResponse DescribeBasicDiagnosisResourceUsageInfoSync(DescribeBasicDiagnosisResourceUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeBasicDiagnosisResourceUsageInfoResponse>(req, "DescribeBasicDiagnosisResourceUsageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取翼扬诊断任务报告链接地址
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppReportUrlRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppReportUrlResponse"/></returns>
        public Task<DescribeFlySecMiniAppReportUrlResponse> DescribeFlySecMiniAppReportUrl(DescribeFlySecMiniAppReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppReportUrlResponse>(req, "DescribeFlySecMiniAppReportUrl");
        }

        /// <summary>
        /// 获取翼扬诊断任务报告链接地址
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppReportUrlRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppReportUrlResponse"/></returns>
        public DescribeFlySecMiniAppReportUrlResponse DescribeFlySecMiniAppReportUrlSync(DescribeFlySecMiniAppReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppReportUrlResponse>(req, "DescribeFlySecMiniAppReportUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定小程序版本的翼扬诊断安全得分
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanReportListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanReportListResponse"/></returns>
        public Task<DescribeFlySecMiniAppScanReportListResponse> DescribeFlySecMiniAppScanReportList(DescribeFlySecMiniAppScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanReportListResponse>(req, "DescribeFlySecMiniAppScanReportList");
        }

        /// <summary>
        /// 查询指定小程序版本的翼扬诊断安全得分
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanReportListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanReportListResponse"/></returns>
        public DescribeFlySecMiniAppScanReportListResponse DescribeFlySecMiniAppScanReportListSync(DescribeFlySecMiniAppScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanReportListResponse>(req, "DescribeFlySecMiniAppScanReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取翼扬安全诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskListResponse"/></returns>
        public Task<DescribeFlySecMiniAppScanTaskListResponse> DescribeFlySecMiniAppScanTaskList(DescribeFlySecMiniAppScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanTaskListResponse>(req, "DescribeFlySecMiniAppScanTaskList");
        }

        /// <summary>
        /// 获取翼扬安全诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskListResponse"/></returns>
        public DescribeFlySecMiniAppScanTaskListResponse DescribeFlySecMiniAppScanTaskListSync(DescribeFlySecMiniAppScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanTaskListResponse>(req, "DescribeFlySecMiniAppScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户提交的基础诊断任务参数信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskParamRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskParamResponse"/></returns>
        public Task<DescribeFlySecMiniAppScanTaskParamResponse> DescribeFlySecMiniAppScanTaskParam(DescribeFlySecMiniAppScanTaskParamRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanTaskParamResponse>(req, "DescribeFlySecMiniAppScanTaskParam");
        }

        /// <summary>
        /// 获取用户提交的基础诊断任务参数信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskParamRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskParamResponse"/></returns>
        public DescribeFlySecMiniAppScanTaskParamResponse DescribeFlySecMiniAppScanTaskParamSync(DescribeFlySecMiniAppScanTaskParamRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanTaskParamResponse>(req, "DescribeFlySecMiniAppScanTaskParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询翼扬安全诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskStatusResponse"/></returns>
        public Task<DescribeFlySecMiniAppScanTaskStatusResponse> DescribeFlySecMiniAppScanTaskStatus(DescribeFlySecMiniAppScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanTaskStatusResponse>(req, "DescribeFlySecMiniAppScanTaskStatus");
        }

        /// <summary>
        /// 查询翼扬安全诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlySecMiniAppScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeFlySecMiniAppScanTaskStatusResponse"/></returns>
        public DescribeFlySecMiniAppScanTaskStatusResponse DescribeFlySecMiniAppScanTaskStatusSync(DescribeFlySecMiniAppScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeFlySecMiniAppScanTaskStatusResponse>(req, "DescribeFlySecMiniAppScanTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询翼扬安全资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageInfoResponse"/></returns>
        public Task<DescribeResourceUsageInfoResponse> DescribeResourceUsageInfo(DescribeResourceUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageInfoResponse>(req, "DescribeResourceUsageInfo");
        }

        /// <summary>
        /// 查询翼扬安全资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageInfoResponse"/></returns>
        public DescribeResourceUsageInfoResponse DescribeResourceUsageInfoSync(DescribeResourceUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageInfoResponse>(req, "DescribeResourceUsageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取小程序隐私合规诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public Task<DescribeScanTaskListResponse> DescribeScanTaskList(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList");
        }

        /// <summary>
        /// 获取小程序隐私合规诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public DescribeScanTaskListResponse DescribeScanTaskListSync(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取小程序合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeScanTaskReportUrlResponse"/></returns>
        public Task<DescribeScanTaskReportUrlResponse> DescribeScanTaskReportUrl(DescribeScanTaskReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskReportUrlResponse>(req, "DescribeScanTaskReportUrl");
        }

        /// <summary>
        /// 获取小程序合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeScanTaskReportUrlResponse"/></returns>
        public DescribeScanTaskReportUrlResponse DescribeScanTaskReportUrlSync(DescribeScanTaskReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskReportUrlResponse>(req, "DescribeScanTaskReportUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询小程序隐私合规诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public Task<DescribeScanTaskStatusResponse> DescribeScanTaskStatus(DescribeScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskStatusResponse>(req, "DescribeScanTaskStatus");
        }

        /// <summary>
        /// 查询小程序隐私合规诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public DescribeScanTaskStatusResponse DescribeScanTaskStatusSync(DescribeScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskStatusResponse>(req, "DescribeScanTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
