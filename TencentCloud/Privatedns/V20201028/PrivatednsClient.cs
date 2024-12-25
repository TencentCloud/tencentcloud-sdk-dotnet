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

namespace TencentCloud.Privatedns.V20201028
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Privatedns.V20201028.Models;

   public class PrivatednsClient : AbstractClient{

       private const string endpoint = "privatedns.tencentcloudapi.com";
       private const string version = "2020-10-28";
       private const string sdkVersion = "SDK_NET_3.0.1150";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PrivatednsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PrivatednsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 追加与私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="AddSpecifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="AddSpecifyPrivateZoneVpcResponse"/></returns>
        public Task<AddSpecifyPrivateZoneVpcResponse> AddSpecifyPrivateZoneVpc(AddSpecifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<AddSpecifyPrivateZoneVpcResponse>(req, "AddSpecifyPrivateZoneVpc");
        }

        /// <summary>
        /// 追加与私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="AddSpecifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="AddSpecifyPrivateZoneVpcResponse"/></returns>
        public AddSpecifyPrivateZoneVpcResponse AddSpecifyPrivateZoneVpcSync(AddSpecifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<AddSpecifyPrivateZoneVpcResponse>(req, "AddSpecifyPrivateZoneVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨账号关联VPC时绑定其他账号
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="CreatePrivateDNSAccountResponse"/></returns>
        public Task<CreatePrivateDNSAccountResponse> CreatePrivateDNSAccount(CreatePrivateDNSAccountRequest req)
        {
            return InternalRequestAsync<CreatePrivateDNSAccountResponse>(req, "CreatePrivateDNSAccount");
        }

        /// <summary>
        /// 跨账号关联VPC时绑定其他账号
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="CreatePrivateDNSAccountResponse"/></returns>
        public CreatePrivateDNSAccountResponse CreatePrivateDNSAccountSync(CreatePrivateDNSAccountRequest req)
        {
            return InternalRequestAsync<CreatePrivateDNSAccountResponse>(req, "CreatePrivateDNSAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建私有域
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public Task<CreatePrivateZoneResponse> CreatePrivateZone(CreatePrivateZoneRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneResponse>(req, "CreatePrivateZone");
        }

        /// <summary>
        /// 创建私有域
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneResponse"/></returns>
        public CreatePrivateZoneResponse CreatePrivateZoneSync(CreatePrivateZoneRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneResponse>(req, "CreatePrivateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public Task<CreatePrivateZoneRecordResponse> CreatePrivateZoneRecord(CreatePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneRecordResponse>(req, "CreatePrivateZoneRecord");
        }

        /// <summary>
        /// 添加私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="CreatePrivateZoneRecordResponse"/></returns>
        public CreatePrivateZoneRecordResponse CreatePrivateZoneRecordSync(CreatePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<CreatePrivateZoneRecordResponse>(req, "CreatePrivateZoneRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除私有域解析账号
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="DeletePrivateDNSAccountResponse"/></returns>
        public Task<DeletePrivateDNSAccountResponse> DeletePrivateDNSAccount(DeletePrivateDNSAccountRequest req)
        {
            return InternalRequestAsync<DeletePrivateDNSAccountResponse>(req, "DeletePrivateDNSAccount");
        }

        /// <summary>
        /// 删除私有域解析账号
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateDNSAccountRequest"/></param>
        /// <returns><see cref="DeletePrivateDNSAccountResponse"/></returns>
        public DeletePrivateDNSAccountResponse DeletePrivateDNSAccountSync(DeletePrivateDNSAccountRequest req)
        {
            return InternalRequestAsync<DeletePrivateDNSAccountResponse>(req, "DeletePrivateDNSAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除私有域并停止解析
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneResponse"/></returns>
        public Task<DeletePrivateZoneResponse> DeletePrivateZone(DeletePrivateZoneRequest req)
        {
            return InternalRequestAsync<DeletePrivateZoneResponse>(req, "DeletePrivateZone");
        }

        /// <summary>
        /// 删除私有域并停止解析
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneResponse"/></returns>
        public DeletePrivateZoneResponse DeletePrivateZoneSync(DeletePrivateZoneRequest req)
        {
            return InternalRequestAsync<DeletePrivateZoneResponse>(req, "DeletePrivateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneRecordResponse"/></returns>
        public Task<DeletePrivateZoneRecordResponse> DeletePrivateZoneRecord(DeletePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<DeletePrivateZoneRecordResponse>(req, "DeletePrivateZoneRecord");
        }

        /// <summary>
        /// 删除私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateZoneRecordRequest"/></param>
        /// <returns><see cref="DeletePrivateZoneRecordResponse"/></returns>
        public DeletePrivateZoneRecordResponse DeletePrivateZoneRecordSync(DeletePrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<DeletePrivateZoneRecordResponse>(req, "DeletePrivateZoneRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除与私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="DeleteSpecifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="DeleteSpecifyPrivateZoneVpcResponse"/></returns>
        public Task<DeleteSpecifyPrivateZoneVpcResponse> DeleteSpecifyPrivateZoneVpc(DeleteSpecifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<DeleteSpecifyPrivateZoneVpcResponse>(req, "DeleteSpecifyPrivateZoneVpc");
        }

        /// <summary>
        /// 删除与私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="DeleteSpecifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="DeleteSpecifyPrivateZoneVpcResponse"/></returns>
        public DeleteSpecifyPrivateZoneVpcResponse DeleteSpecifyPrivateZoneVpcSync(DeleteSpecifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<DeleteSpecifyPrivateZoneVpcResponse>(req, "DeleteSpecifyPrivateZoneVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取私有域解析账号的VPC列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountVpcListRequest"/></param>
        /// <returns><see cref="DescribeAccountVpcListResponse"/></returns>
        public Task<DescribeAccountVpcListResponse> DescribeAccountVpcList(DescribeAccountVpcListRequest req)
        {
            return InternalRequestAsync<DescribeAccountVpcListResponse>(req, "DescribeAccountVpcList");
        }

        /// <summary>
        /// 获取私有域解析账号的VPC列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountVpcListRequest"/></param>
        /// <returns><see cref="DescribeAccountVpcListResponse"/></returns>
        public DescribeAccountVpcListResponse DescribeAccountVpcListSync(DescribeAccountVpcListRequest req)
        {
            return InternalRequestAsync<DescribeAccountVpcListResponse>(req, "DescribeAccountVpcList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取操作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public Task<DescribeAuditLogResponse> DescribeAuditLog(DescribeAuditLogRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogResponse>(req, "DescribeAuditLog");
        }

        /// <summary>
        /// 获取操作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogRequest"/></param>
        /// <returns><see cref="DescribeAuditLogResponse"/></returns>
        public DescribeAuditLogResponse DescribeAuditLogSync(DescribeAuditLogRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogResponse>(req, "DescribeAuditLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取私有域解析概览
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public Task<DescribeDashboardResponse> DescribeDashboard(DescribeDashboardRequest req)
        {
            return InternalRequestAsync<DescribeDashboardResponse>(req, "DescribeDashboard");
        }

        /// <summary>
        /// 获取私有域解析概览
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardRequest"/></param>
        /// <returns><see cref="DescribeDashboardResponse"/></returns>
        public DescribeDashboardResponse DescribeDashboardSync(DescribeDashboardRequest req)
        {
            return InternalRequestAsync<DescribeDashboardResponse>(req, "DescribeDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取私有域解析账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateDNSAccountListRequest"/></param>
        /// <returns><see cref="DescribePrivateDNSAccountListResponse"/></returns>
        public Task<DescribePrivateDNSAccountListResponse> DescribePrivateDNSAccountList(DescribePrivateDNSAccountListRequest req)
        {
            return InternalRequestAsync<DescribePrivateDNSAccountListResponse>(req, "DescribePrivateDNSAccountList");
        }

        /// <summary>
        /// 获取私有域解析账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateDNSAccountListRequest"/></param>
        /// <returns><see cref="DescribePrivateDNSAccountListResponse"/></returns>
        public DescribePrivateDNSAccountListResponse DescribePrivateDNSAccountListSync(DescribePrivateDNSAccountListRequest req)
        {
            return InternalRequestAsync<DescribePrivateDNSAccountListResponse>(req, "DescribePrivateDNSAccountList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取私有域信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneResponse"/></returns>
        public Task<DescribePrivateZoneResponse> DescribePrivateZone(DescribePrivateZoneRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneResponse>(req, "DescribePrivateZone");
        }

        /// <summary>
        /// 获取私有域信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneResponse"/></returns>
        public DescribePrivateZoneResponse DescribePrivateZoneSync(DescribePrivateZoneRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneResponse>(req, "DescribePrivateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取私有域列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneListResponse"/></returns>
        public Task<DescribePrivateZoneListResponse> DescribePrivateZoneList(DescribePrivateZoneListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneListResponse>(req, "DescribePrivateZoneList");
        }

        /// <summary>
        /// 获取私有域列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneListResponse"/></returns>
        public DescribePrivateZoneListResponse DescribePrivateZoneListSync(DescribePrivateZoneListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneListResponse>(req, "DescribePrivateZoneList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取私有域记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRecordListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneRecordListResponse"/></returns>
        public Task<DescribePrivateZoneRecordListResponse> DescribePrivateZoneRecordList(DescribePrivateZoneRecordListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneRecordListResponse>(req, "DescribePrivateZoneRecordList");
        }

        /// <summary>
        /// 获取私有域记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneRecordListRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneRecordListResponse"/></returns>
        public DescribePrivateZoneRecordListResponse DescribePrivateZoneRecordListSync(DescribePrivateZoneRecordListRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneRecordListResponse>(req, "DescribePrivateZoneRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私有域解析开通状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public Task<DescribePrivateZoneServiceResponse> DescribePrivateZoneService(DescribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneServiceResponse>(req, "DescribePrivateZoneService");
        }

        /// <summary>
        /// 查询私有域解析开通状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="DescribePrivateZoneServiceResponse"/></returns>
        public DescribePrivateZoneServiceResponse DescribePrivateZoneServiceSync(DescribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<DescribePrivateZoneServiceResponse>(req, "DescribePrivateZoneService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询额度使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeQuotaUsageResponse"/></returns>
        public Task<DescribeQuotaUsageResponse> DescribeQuotaUsage(DescribeQuotaUsageRequest req)
        {
            return InternalRequestAsync<DescribeQuotaUsageResponse>(req, "DescribeQuotaUsage");
        }

        /// <summary>
        /// 查询额度使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaUsageRequest"/></param>
        /// <returns><see cref="DescribeQuotaUsageResponse"/></returns>
        public DescribeQuotaUsageResponse DescribeQuotaUsageSync(DescribeQuotaUsageRequest req)
        {
            return InternalRequestAsync<DescribeQuotaUsageResponse>(req, "DescribeQuotaUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取私有域解析请求量
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public Task<DescribeRequestDataResponse> DescribeRequestData(DescribeRequestDataRequest req)
        {
            return InternalRequestAsync<DescribeRequestDataResponse>(req, "DescribeRequestData");
        }

        /// <summary>
        /// 获取私有域解析请求量
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestDataRequest"/></param>
        /// <returns><see cref="DescribeRequestDataResponse"/></returns>
        public DescribeRequestDataResponse DescribeRequestDataSync(DescribeRequestDataRequest req)
        {
            return InternalRequestAsync<DescribeRequestDataResponse>(req, "DescribeRequestData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改私有域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public Task<ModifyPrivateZoneResponse> ModifyPrivateZone(ModifyPrivateZoneRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneResponse>(req, "ModifyPrivateZone");
        }

        /// <summary>
        /// 修改私有域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneResponse"/></returns>
        public ModifyPrivateZoneResponse ModifyPrivateZoneSync(ModifyPrivateZoneRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneResponse>(req, "ModifyPrivateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public Task<ModifyPrivateZoneRecordResponse> ModifyPrivateZoneRecord(ModifyPrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneRecordResponse>(req, "ModifyPrivateZoneRecord");
        }

        /// <summary>
        /// 修改私有域解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneRecordRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneRecordResponse"/></returns>
        public ModifyPrivateZoneRecordResponse ModifyPrivateZoneRecordSync(ModifyPrivateZoneRecordRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneRecordResponse>(req, "ModifyPrivateZoneRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public Task<ModifyPrivateZoneVpcResponse> ModifyPrivateZoneVpc(ModifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneVpcResponse>(req, "ModifyPrivateZoneVpc");
        }

        /// <summary>
        /// 修改私有域关联的VPC
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateZoneVpcRequest"/></param>
        /// <returns><see cref="ModifyPrivateZoneVpcResponse"/></returns>
        public ModifyPrivateZoneVpcResponse ModifyPrivateZoneVpcSync(ModifyPrivateZoneVpcRequest req)
        {
            return InternalRequestAsync<ModifyPrivateZoneVpcResponse>(req, "ModifyPrivateZoneVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改解析记录状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordsStatusResponse"/></returns>
        public Task<ModifyRecordsStatusResponse> ModifyRecordsStatus(ModifyRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRecordsStatusResponse>(req, "ModifyRecordsStatus");
        }

        /// <summary>
        /// 修改解析记录状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyRecordsStatusResponse"/></returns>
        public ModifyRecordsStatusResponse ModifyRecordsStatusSync(ModifyRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRecordsStatusResponse>(req, "ModifyRecordsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询异步绑定vpc操作状态
        /// </summary>
        /// <param name="req"><see cref="QueryAsyncBindVpcStatusRequest"/></param>
        /// <returns><see cref="QueryAsyncBindVpcStatusResponse"/></returns>
        public Task<QueryAsyncBindVpcStatusResponse> QueryAsyncBindVpcStatus(QueryAsyncBindVpcStatusRequest req)
        {
            return InternalRequestAsync<QueryAsyncBindVpcStatusResponse>(req, "QueryAsyncBindVpcStatus");
        }

        /// <summary>
        /// 查询异步绑定vpc操作状态
        /// </summary>
        /// <param name="req"><see cref="QueryAsyncBindVpcStatusRequest"/></param>
        /// <returns><see cref="QueryAsyncBindVpcStatusResponse"/></returns>
        public QueryAsyncBindVpcStatusResponse QueryAsyncBindVpcStatusSync(QueryAsyncBindVpcStatusRequest req)
        {
            return InternalRequestAsync<QueryAsyncBindVpcStatusResponse>(req, "QueryAsyncBindVpcStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通私有域解析
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public Task<SubscribePrivateZoneServiceResponse> SubscribePrivateZoneService(SubscribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<SubscribePrivateZoneServiceResponse>(req, "SubscribePrivateZoneService");
        }

        /// <summary>
        /// 开通私有域解析
        /// </summary>
        /// <param name="req"><see cref="SubscribePrivateZoneServiceRequest"/></param>
        /// <returns><see cref="SubscribePrivateZoneServiceResponse"/></returns>
        public SubscribePrivateZoneServiceResponse SubscribePrivateZoneServiceSync(SubscribePrivateZoneServiceRequest req)
        {
            return InternalRequestAsync<SubscribePrivateZoneServiceResponse>(req, "SubscribePrivateZoneService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
