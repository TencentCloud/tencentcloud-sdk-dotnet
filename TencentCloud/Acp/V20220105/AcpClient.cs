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
       private const string sdkVersion = "SDK_NET_3.0.963";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AcpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建应用合规隐私诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskResponse"/></returns>
        public Task<CreateAppScanTaskResponse> CreateAppScanTask(CreateAppScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskResponse>(req, "CreateAppScanTask");
        }

        /// <summary>
        /// 创建应用合规隐私诊断任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskResponse"/></returns>
        public CreateAppScanTaskResponse CreateAppScanTaskSync(CreateAppScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskResponse>(req, "CreateAppScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// App应用合规隐私诊断重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskRepeatResponse"/></returns>
        public Task<CreateAppScanTaskRepeatResponse> CreateAppScanTaskRepeat(CreateAppScanTaskRepeatRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskRepeatResponse>(req, "CreateAppScanTaskRepeat");
        }

        /// <summary>
        /// App应用合规隐私诊断重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAppScanTaskRepeatRequest"/></param>
        /// <returns><see cref="CreateAppScanTaskRepeatResponse"/></returns>
        public CreateAppScanTaskRepeatResponse CreateAppScanTaskRepeatSync(CreateAppScanTaskRepeatRequest req)
        {
            return InternalRequestAsync<CreateAppScanTaskRepeatResponse>(req, "CreateAppScanTaskRepeat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取子渠道的App合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeChannelTaskReportUrlResponse"/></returns>
        public Task<DescribeChannelTaskReportUrlResponse> DescribeChannelTaskReportUrl(DescribeChannelTaskReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeChannelTaskReportUrlResponse>(req, "DescribeChannelTaskReportUrl");
        }

        /// <summary>
        /// 获取子渠道的App合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeChannelTaskReportUrlResponse"/></returns>
        public DescribeChannelTaskReportUrlResponse DescribeChannelTaskReportUrlSync(DescribeChannelTaskReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeChannelTaskReportUrlResponse>(req, "DescribeChannelTaskReportUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用合规文件上传凭证，用于上传诊断文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTicketRequest"/></param>
        /// <returns><see cref="DescribeFileTicketResponse"/></returns>
        public Task<DescribeFileTicketResponse> DescribeFileTicket(DescribeFileTicketRequest req)
        {
            return InternalRequestAsync<DescribeFileTicketResponse>(req, "DescribeFileTicket");
        }

        /// <summary>
        /// 获取应用合规文件上传凭证，用于上传诊断文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTicketRequest"/></param>
        /// <returns><see cref="DescribeFileTicketResponse"/></returns>
        public DescribeFileTicketResponse DescribeFileTicketSync(DescribeFileTicketRequest req)
        {
            return InternalRequestAsync<DescribeFileTicketResponse>(req, "DescribeFileTicket")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用合规平台用户资源的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageInfoResponse"/></returns>
        public Task<DescribeResourceUsageInfoResponse> DescribeResourceUsageInfo(DescribeResourceUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageInfoResponse>(req, "DescribeResourceUsageInfo");
        }

        /// <summary>
        /// 查询应用合规平台用户资源的使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageInfoResponse"/></returns>
        public DescribeResourceUsageInfoResponse DescribeResourceUsageInfoSync(DescribeResourceUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageInfoResponse>(req, "DescribeResourceUsageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取App隐私合规诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public Task<DescribeScanTaskListResponse> DescribeScanTaskList(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList");
        }

        /// <summary>
        /// 获取App隐私合规诊断任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public DescribeScanTaskListResponse DescribeScanTaskListSync(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取App合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeScanTaskReportUrlResponse"/></returns>
        public Task<DescribeScanTaskReportUrlResponse> DescribeScanTaskReportUrl(DescribeScanTaskReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskReportUrlResponse>(req, "DescribeScanTaskReportUrl");
        }

        /// <summary>
        /// 获取App合规诊断任务报告url
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskReportUrlRequest"/></param>
        /// <returns><see cref="DescribeScanTaskReportUrlResponse"/></returns>
        public DescribeScanTaskReportUrlResponse DescribeScanTaskReportUrlSync(DescribeScanTaskReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskReportUrlResponse>(req, "DescribeScanTaskReportUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询App隐私合规诊断任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public Task<DescribeScanTaskStatusResponse> DescribeScanTaskStatus(DescribeScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskStatusResponse>(req, "DescribeScanTaskStatus");
        }

        /// <summary>
        /// 查询App隐私合规诊断任务状态
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
