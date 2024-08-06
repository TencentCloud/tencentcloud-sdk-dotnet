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

namespace TencentCloud.Cdwdoris.V20211228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwdoris.V20211228.Models;

   public class CdwdorisClient : AbstractClient{

       private const string endpoint = "cdwdoris.tencentcloudapi.com";
       private const string version = "2021-12-28";
       private const string sdkVersion = "SDK_NET_3.0.1063";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwdorisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwdorisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 取消对应的备份实例任务
        /// </summary>
        /// <param name="req"><see cref="CancelBackupJobRequest"/></param>
        /// <returns><see cref="CancelBackupJobResponse"/></returns>
        public Task<CancelBackupJobResponse> CancelBackupJob(CancelBackupJobRequest req)
        {
            return InternalRequestAsync<CancelBackupJobResponse>(req, "CancelBackupJob");
        }

        /// <summary>
        /// 取消对应的备份实例任务
        /// </summary>
        /// <param name="req"><see cref="CancelBackupJobRequest"/></param>
        /// <returns><see cref="CancelBackupJobResponse"/></returns>
        public CancelBackupJobResponse CancelBackupJobSync(CancelBackupJobRequest req)
        {
            return InternalRequestAsync<CancelBackupJobResponse>(req, "CancelBackupJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建或者修改备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public Task<CreateBackUpScheduleResponse> CreateBackUpSchedule(CreateBackUpScheduleRequest req)
        {
            return InternalRequestAsync<CreateBackUpScheduleResponse>(req, "CreateBackUpSchedule");
        }

        /// <summary>
        /// 创建或者修改备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public CreateBackUpScheduleResponse CreateBackUpScheduleSync(CreateBackUpScheduleRequest req)
        {
            return InternalRequestAsync<CreateBackUpScheduleResponse>(req, "CreateBackUpSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过API创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public Task<CreateInstanceNewResponse> CreateInstanceNew(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew");
        }

        /// <summary>
        /// 通过API创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public CreateInstanceNewResponse CreateInstanceNewSync(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资源组
        /// </summary>
        /// <param name="req"><see cref="CreateWorkloadGroupRequest"/></param>
        /// <returns><see cref="CreateWorkloadGroupResponse"/></returns>
        public Task<CreateWorkloadGroupResponse> CreateWorkloadGroup(CreateWorkloadGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkloadGroupResponse>(req, "CreateWorkloadGroup");
        }

        /// <summary>
        /// 创建资源组
        /// </summary>
        /// <param name="req"><see cref="CreateWorkloadGroupRequest"/></param>
        /// <returns><see cref="CreateWorkloadGroupResponse"/></returns>
        public CreateWorkloadGroupResponse CreateWorkloadGroupSync(CreateWorkloadGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkloadGroupResponse>(req, "CreateWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份数据
        /// </summary>
        /// <param name="req"><see cref="DeleteBackUpDataRequest"/></param>
        /// <returns><see cref="DeleteBackUpDataResponse"/></returns>
        public Task<DeleteBackUpDataResponse> DeleteBackUpData(DeleteBackUpDataRequest req)
        {
            return InternalRequestAsync<DeleteBackUpDataResponse>(req, "DeleteBackUpData");
        }

        /// <summary>
        /// 删除备份数据
        /// </summary>
        /// <param name="req"><see cref="DeleteBackUpDataRequest"/></param>
        /// <returns><see cref="DeleteBackUpDataResponse"/></returns>
        public DeleteBackUpDataResponse DeleteBackUpDataSync(DeleteBackUpDataRequest req)
        {
            return InternalRequestAsync<DeleteBackUpDataResponse>(req, "DeleteBackUpData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资源组
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkloadGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkloadGroupResponse"/></returns>
        public Task<DeleteWorkloadGroupResponse> DeleteWorkloadGroup(DeleteWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkloadGroupResponse>(req, "DeleteWorkloadGroup");
        }

        /// <summary>
        /// 删除资源组
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkloadGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkloadGroupResponse"/></returns>
        public DeleteWorkloadGroupResponse DeleteWorkloadGroupSync(DeleteWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkloadGroupResponse>(req, "DeleteWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群列表页上显示地域信息及各个地域的集群总数
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaRegionRequest"/></param>
        /// <returns><see cref="DescribeAreaRegionResponse"/></returns>
        public Task<DescribeAreaRegionResponse> DescribeAreaRegion(DescribeAreaRegionRequest req)
        {
            return InternalRequestAsync<DescribeAreaRegionResponse>(req, "DescribeAreaRegion");
        }

        /// <summary>
        /// 集群列表页上显示地域信息及各个地域的集群总数
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaRegionRequest"/></param>
        /// <returns><see cref="DescribeAreaRegionResponse"/></returns>
        public DescribeAreaRegionResponse DescribeAreaRegionSync(DescribeAreaRegionRequest req)
        {
            return InternalRequestAsync<DescribeAreaRegionResponse>(req, "DescribeAreaRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobResponse"/></returns>
        public Task<DescribeBackUpJobResponse> DescribeBackUpJob(DescribeBackUpJobRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobResponse>(req, "DescribeBackUpJob");
        }

        /// <summary>
        /// 查询备份实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobResponse"/></returns>
        public DescribeBackUpJobResponse DescribeBackUpJobSync(DescribeBackUpJobRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobResponse>(req, "DescribeBackUpJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobDetailResponse"/></returns>
        public Task<DescribeBackUpJobDetailResponse> DescribeBackUpJobDetail(DescribeBackUpJobDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobDetailResponse>(req, "DescribeBackUpJobDetail");
        }

        /// <summary>
        /// 查询备份任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobDetailResponse"/></returns>
        public DescribeBackUpJobDetailResponse DescribeBackUpJobDetailSync(DescribeBackUpJobDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobDetailResponse>(req, "DescribeBackUpJobDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取备份、迁移的调度任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpSchedulesRequest"/></param>
        /// <returns><see cref="DescribeBackUpSchedulesResponse"/></returns>
        public Task<DescribeBackUpSchedulesResponse> DescribeBackUpSchedules(DescribeBackUpSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpSchedulesResponse>(req, "DescribeBackUpSchedules");
        }

        /// <summary>
        /// 获取备份、迁移的调度任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpSchedulesRequest"/></param>
        /// <returns><see cref="DescribeBackUpSchedulesResponse"/></returns>
        public DescribeBackUpSchedulesResponse DescribeBackUpSchedulesSync(DescribeBackUpSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpSchedulesResponse>(req, "DescribeBackUpSchedules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取可备份表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTablesRequest"/></param>
        /// <returns><see cref="DescribeBackUpTablesResponse"/></returns>
        public Task<DescribeBackUpTablesResponse> DescribeBackUpTables(DescribeBackUpTablesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTablesResponse>(req, "DescribeBackUpTables");
        }

        /// <summary>
        /// 获取可备份表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTablesRequest"/></param>
        /// <returns><see cref="DescribeBackUpTablesResponse"/></returns>
        public DescribeBackUpTablesResponse DescribeBackUpTablesSync(DescribeBackUpTablesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTablesResponse>(req, "DescribeBackUpTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份任务进度详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpTaskDetailResponse"/></returns>
        public Task<DescribeBackUpTaskDetailResponse> DescribeBackUpTaskDetail(DescribeBackUpTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTaskDetailResponse>(req, "DescribeBackUpTaskDetail");
        }

        /// <summary>
        /// 查询备份任务进度详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpTaskDetailResponse"/></returns>
        public DescribeBackUpTaskDetailResponse DescribeBackUpTaskDetailSync(DescribeBackUpTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTaskDetailResponse>(req, "DescribeBackUpTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群的最新的几个配置文件（config.xml、metrika.xml、user.xml）的内容，显示给用户
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public Task<DescribeClusterConfigsResponse> DescribeClusterConfigs(DescribeClusterConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsResponse>(req, "DescribeClusterConfigs");
        }

        /// <summary>
        /// 获取集群的最新的几个配置文件（config.xml、metrika.xml、user.xml）的内容，显示给用户
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public DescribeClusterConfigsResponse DescribeClusterConfigsSync(DescribeClusterConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsResponse>(req, "DescribeClusterConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群配置文件修改历史
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsHistoryResponse"/></returns>
        public Task<DescribeClusterConfigsHistoryResponse> DescribeClusterConfigsHistory(DescribeClusterConfigsHistoryRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsHistoryResponse>(req, "DescribeClusterConfigsHistory");
        }

        /// <summary>
        /// 获取集群配置文件修改历史
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsHistoryResponse"/></returns>
        public DescribeClusterConfigsHistoryResponse DescribeClusterConfigsHistorySync(DescribeClusterConfigsHistoryRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsHistoryResponse>(req, "DescribeClusterConfigsHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载数据库审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditDownloadRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditDownloadResponse"/></returns>
        public Task<DescribeDatabaseAuditDownloadResponse> DescribeDatabaseAuditDownload(DescribeDatabaseAuditDownloadRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditDownloadResponse>(req, "DescribeDatabaseAuditDownload");
        }

        /// <summary>
        /// 下载数据库审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditDownloadRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditDownloadResponse"/></returns>
        public DescribeDatabaseAuditDownloadResponse DescribeDatabaseAuditDownloadSync(DescribeDatabaseAuditDownloadRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditDownloadResponse>(req, "DescribeDatabaseAuditDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据库审计记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditRecordsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditRecordsResponse"/></returns>
        public Task<DescribeDatabaseAuditRecordsResponse> DescribeDatabaseAuditRecords(DescribeDatabaseAuditRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditRecordsResponse>(req, "DescribeDatabaseAuditRecords");
        }

        /// <summary>
        /// 获取数据库审计记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditRecordsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditRecordsResponse"/></returns>
        public DescribeDatabaseAuditRecordsResponse DescribeDatabaseAuditRecordsSync(DescribeDatabaseAuditRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditRecordsResponse>(req, "DescribeDatabaseAuditRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据库审计数据库、用户等
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditResourceRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditResourceResponse"/></returns>
        public Task<DescribeDatabaseAuditResourceResponse> DescribeDatabaseAuditResource(DescribeDatabaseAuditResourceRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditResourceResponse>(req, "DescribeDatabaseAuditResource");
        }

        /// <summary>
        /// 数据库审计数据库、用户等
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditResourceRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditResourceResponse"/></returns>
        public DescribeDatabaseAuditResourceResponse DescribeDatabaseAuditResourceSync(DescribeDatabaseAuditResourceRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditResourceResponse>(req, "DescribeDatabaseAuditResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询sql工作区历史运行记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDmsSqlHistoryRequest"/></param>
        /// <returns><see cref="DescribeDmsSqlHistoryResponse"/></returns>
        public Task<DescribeDmsSqlHistoryResponse> DescribeDmsSqlHistory(DescribeDmsSqlHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDmsSqlHistoryResponse>(req, "DescribeDmsSqlHistory");
        }

        /// <summary>
        /// 查询sql工作区历史运行记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDmsSqlHistoryRequest"/></param>
        /// <returns><see cref="DescribeDmsSqlHistoryResponse"/></returns>
        public DescribeDmsSqlHistoryResponse DescribeDmsSqlHistorySync(DescribeDmsSqlHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDmsSqlHistoryResponse>(req, "DescribeDmsSqlHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示监控指标文件
        /// </summary>
        /// <param name="req"><see cref="DescribeDorisMetricFilesRequest"/></param>
        /// <returns><see cref="DescribeDorisMetricFilesResponse"/></returns>
        public Task<DescribeDorisMetricFilesResponse> DescribeDorisMetricFiles(DescribeDorisMetricFilesRequest req)
        {
            return InternalRequestAsync<DescribeDorisMetricFilesResponse>(req, "DescribeDorisMetricFiles");
        }

        /// <summary>
        /// 展示监控指标文件
        /// </summary>
        /// <param name="req"><see cref="DescribeDorisMetricFilesRequest"/></param>
        /// <returns><see cref="DescribeDorisMetricFilesResponse"/></returns>
        public DescribeDorisMetricFilesResponse DescribeDorisMetricFilesSync(DescribeDorisMetricFilesRequest req)
        {
            return InternalRequestAsync<DescribeDorisMetricFilesResponse>(req, "DescribeDorisMetricFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取联合身份临时访问凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeFederationTokenRequest"/></param>
        /// <returns><see cref="DescribeFederationTokenResponse"/></returns>
        public Task<DescribeFederationTokenResponse> DescribeFederationToken(DescribeFederationTokenRequest req)
        {
            return InternalRequestAsync<DescribeFederationTokenResponse>(req, "DescribeFederationToken");
        }

        /// <summary>
        /// 获取联合身份临时访问凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeFederationTokenRequest"/></param>
        /// <returns><see cref="DescribeFederationTokenResponse"/></returns>
        public DescribeFederationTokenResponse DescribeFederationTokenSync(DescribeFederationTokenRequest req)
        {
            return InternalRequestAsync<DescribeFederationTokenResponse>(req, "DescribeFederationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询前端内容
        /// </summary>
        /// <param name="req"><see cref="DescribeFrontEndRequest"/></param>
        /// <returns><see cref="DescribeFrontEndResponse"/></returns>
        public Task<DescribeFrontEndResponse> DescribeFrontEnd(DescribeFrontEndRequest req)
        {
            return InternalRequestAsync<DescribeFrontEndResponse>(req, "DescribeFrontEnd");
        }

        /// <summary>
        /// 查询前端内容
        /// </summary>
        /// <param name="req"><see cref="DescribeFrontEndRequest"/></param>
        /// <returns><see cref="DescribeFrontEndResponse"/></returns>
        public DescribeFrontEndResponse DescribeFrontEndSync(DescribeFrontEndRequest req)
        {
            return InternalRequestAsync<DescribeFrontEndResponse>(req, "DescribeFrontEnd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成计费相关接口的GoodsDetail结构
        /// </summary>
        /// <param name="req"><see cref="DescribeGoodsDetailRequest"/></param>
        /// <returns><see cref="DescribeGoodsDetailResponse"/></returns>
        public Task<DescribeGoodsDetailResponse> DescribeGoodsDetail(DescribeGoodsDetailRequest req)
        {
            return InternalRequestAsync<DescribeGoodsDetailResponse>(req, "DescribeGoodsDetail");
        }

        /// <summary>
        /// 生成计费相关接口的GoodsDetail结构
        /// </summary>
        /// <param name="req"><see cref="DescribeGoodsDetailRequest"/></param>
        /// <returns><see cref="DescribeGoodsDetailResponse"/></returns>
        public DescribeGoodsDetailResponse DescribeGoodsDetailSync(DescribeGoodsDetailRequest req)
        {
            return InternalRequestAsync<DescribeGoodsDetailResponse>(req, "DescribeGoodsDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据集群ID查询某个集群的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// 根据集群ID查询某个集群的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群节点信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public Task<DescribeInstanceNodesResponse> DescribeInstanceNodes(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes");
        }

        /// <summary>
        /// 获取集群节点信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public DescribeInstanceNodesResponse DescribeInstanceNodesSync(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取BE/FE节点角色
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesInfoResponse"/></returns>
        public Task<DescribeInstanceNodesInfoResponse> DescribeInstanceNodesInfo(DescribeInstanceNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesInfoResponse>(req, "DescribeInstanceNodesInfo");
        }

        /// <summary>
        /// 获取BE/FE节点角色
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesInfoResponse"/></returns>
        public DescribeInstanceNodesInfoResponse DescribeInstanceNodesInfoSync(DescribeInstanceNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesInfoResponse>(req, "DescribeInstanceNodesInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群节点角色
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRoleRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesRoleResponse"/></returns>
        public Task<DescribeInstanceNodesRoleResponse> DescribeInstanceNodesRole(DescribeInstanceNodesRoleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesRoleResponse>(req, "DescribeInstanceNodesRole");
        }

        /// <summary>
        /// 获取集群节点角色
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRoleRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesRoleResponse"/></returns>
        public DescribeInstanceNodesRoleResponse DescribeInstanceNodesRoleSync(DescribeInstanceNodesRoleRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesRoleResponse>(req, "DescribeInstanceNodesRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在集群详情页面，拉取该集群的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations");
        }

        /// <summary>
        /// 在集群详情页面，拉取该集群的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群详情页中显示集群状态、流程进度等
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public Task<DescribeInstanceStateResponse> DescribeInstanceState(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState");
        }

        /// <summary>
        /// 集群详情页中显示集群状态、流程进度等
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public DescribeInstanceStateResponse DescribeInstanceStateSync(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群已使用子网信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUsedSubnetsRequest"/></param>
        /// <returns><see cref="DescribeInstanceUsedSubnetsResponse"/></returns>
        public Task<DescribeInstanceUsedSubnetsResponse> DescribeInstanceUsedSubnets(DescribeInstanceUsedSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUsedSubnetsResponse>(req, "DescribeInstanceUsedSubnets");
        }

        /// <summary>
        /// 获取集群已使用子网信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceUsedSubnetsRequest"/></param>
        /// <returns><see cref="DescribeInstanceUsedSubnetsResponse"/></returns>
        public DescribeInstanceUsedSubnetsResponse DescribeInstanceUsedSubnetsSync(DescribeInstanceUsedSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceUsedSubnetsResponse>(req, "DescribeInstanceUsedSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群健康检查
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesHealthStateRequest"/></param>
        /// <returns><see cref="DescribeInstancesHealthStateResponse"/></returns>
        public Task<DescribeInstancesHealthStateResponse> DescribeInstancesHealthState(DescribeInstancesHealthStateRequest req)
        {
            return InternalRequestAsync<DescribeInstancesHealthStateResponse>(req, "DescribeInstancesHealthState");
        }

        /// <summary>
        /// 集群健康检查
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesHealthStateRequest"/></param>
        /// <returns><see cref="DescribeInstancesHealthStateResponse"/></returns>
        public DescribeInstancesHealthStateResponse DescribeInstancesHealthStateSync(DescribeInstancesHealthStateRequest req)
        {
            return InternalRequestAsync<DescribeInstancesHealthStateResponse>(req, "DescribeInstancesHealthState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买页获取地域及可用区列表、内核版本、网络规则等
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeRegionZoneResponse"/></returns>
        public Task<DescribeRegionZoneResponse> DescribeRegionZone(DescribeRegionZoneRequest req)
        {
            return InternalRequestAsync<DescribeRegionZoneResponse>(req, "DescribeRegionZone");
        }

        /// <summary>
        /// 购买页获取地域及可用区列表、内核版本、网络规则等
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeRegionZoneResponse"/></returns>
        public DescribeRegionZoneResponse DescribeRegionZoneSync(DescribeRegionZoneRequest req)
        {
            return InternalRequestAsync<DescribeRegionZoneResponse>(req, "DescribeRegionZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查内核版本是否支持新的备份恢复语法
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicaVersionRequest"/></param>
        /// <returns><see cref="DescribeReplicaVersionResponse"/></returns>
        public Task<DescribeReplicaVersionResponse> DescribeReplicaVersion(DescribeReplicaVersionRequest req)
        {
            return InternalRequestAsync<DescribeReplicaVersionResponse>(req, "DescribeReplicaVersion");
        }

        /// <summary>
        /// 检查内核版本是否支持新的备份恢复语法
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicaVersionRequest"/></param>
        /// <returns><see cref="DescribeReplicaVersionResponse"/></returns>
        public DescribeReplicaVersionResponse DescribeReplicaVersionSync(DescribeReplicaVersionRequest req)
        {
            return InternalRequestAsync<DescribeReplicaVersionResponse>(req, "DescribeReplicaVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询恢复任务进度详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskDetailResponse"/></returns>
        public Task<DescribeRestoreTaskDetailResponse> DescribeRestoreTaskDetail(DescribeRestoreTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskDetailResponse>(req, "DescribeRestoreTaskDetail");
        }

        /// <summary>
        /// 查询恢复任务进度详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskDetailResponse"/></returns>
        public DescribeRestoreTaskDetailResponse DescribeRestoreTaskDetailSync(DescribeRestoreTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskDetailResponse>(req, "DescribeRestoreTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取慢查询列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsResponse"/></returns>
        public Task<DescribeSlowQueryRecordsResponse> DescribeSlowQueryRecords(DescribeSlowQueryRecordsRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsResponse>(req, "DescribeSlowQueryRecords");
        }

        /// <summary>
        /// 获取慢查询列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsResponse"/></returns>
        public DescribeSlowQueryRecordsResponse DescribeSlowQueryRecordsSync(DescribeSlowQueryRecordsRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsResponse>(req, "DescribeSlowQueryRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载慢查询文件
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsDownloadRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsDownloadResponse"/></returns>
        public Task<DescribeSlowQueryRecordsDownloadResponse> DescribeSlowQueryRecordsDownload(DescribeSlowQueryRecordsDownloadRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsDownloadResponse>(req, "DescribeSlowQueryRecordsDownload");
        }

        /// <summary>
        /// 下载慢查询文件
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsDownloadRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsDownloadResponse"/></returns>
        public DescribeSlowQueryRecordsDownloadResponse DescribeSlowQueryRecordsDownloadSync(DescribeSlowQueryRecordsDownloadRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsDownloadResponse>(req, "DescribeSlowQueryRecordsDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买页拉取集群的数据节点和zookeeper节点的规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public Task<DescribeSpecResponse> DescribeSpec(DescribeSpecRequest req)
        {
            return InternalRequestAsync<DescribeSpecResponse>(req, "DescribeSpec");
        }

        /// <summary>
        /// 购买页拉取集群的数据节点和zookeeper节点的规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public DescribeSpecResponse DescribeSpecSync(DescribeSpecRequest req)
        {
            return InternalRequestAsync<DescribeSpecResponse>(req, "DescribeSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对驱动sql命令查询ck集群接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlApisRequest"/></param>
        /// <returns><see cref="DescribeSqlApisResponse"/></returns>
        public Task<DescribeSqlApisResponse> DescribeSqlApis(DescribeSqlApisRequest req)
        {
            return InternalRequestAsync<DescribeSqlApisResponse>(req, "DescribeSqlApis");
        }

        /// <summary>
        /// 针对驱动sql命令查询ck集群接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlApisRequest"/></param>
        /// <returns><see cref="DescribeSqlApisResponse"/></returns>
        public DescribeSqlApisResponse DescribeSqlApisSync(DescribeSqlApisRequest req)
        {
            return InternalRequestAsync<DescribeSqlApisResponse>(req, "DescribeSqlApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前集群各用户绑定的资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeUserBindWorkloadGroupResponse"/></returns>
        public Task<DescribeUserBindWorkloadGroupResponse> DescribeUserBindWorkloadGroup(DescribeUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeUserBindWorkloadGroupResponse>(req, "DescribeUserBindWorkloadGroup");
        }

        /// <summary>
        /// 获取当前集群各用户绑定的资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeUserBindWorkloadGroupResponse"/></returns>
        public DescribeUserBindWorkloadGroupResponse DescribeUserBindWorkloadGroupSync(DescribeUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeUserBindWorkloadGroupResponse>(req, "DescribeUserBindWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeWorkloadGroupResponse"/></returns>
        public Task<DescribeWorkloadGroupResponse> DescribeWorkloadGroup(DescribeWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeWorkloadGroupResponse>(req, "DescribeWorkloadGroup");
        }

        /// <summary>
        /// 获取资源组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkloadGroupRequest"/></param>
        /// <returns><see cref="DescribeWorkloadGroupResponse"/></returns>
        public DescribeWorkloadGroupResponse DescribeWorkloadGroupSync(DescribeWorkloadGroupRequest req)
        {
            return InternalRequestAsync<DescribeWorkloadGroupResponse>(req, "DescribeWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public Task<DestroyInstanceResponse> DestroyInstance(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance");
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public DestroyInstanceResponse DestroyInstanceSync(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 给已存在集群，配置日志服务
        /// </summary>
        /// <param name="req"><see cref="FitClsLogRequest"/></param>
        /// <returns><see cref="FitClsLogResponse"/></returns>
        public Task<FitClsLogResponse> FitClsLog(FitClsLogRequest req)
        {
            return InternalRequestAsync<FitClsLogResponse>(req, "FitClsLog");
        }

        /// <summary>
        /// 给已存在集群，配置日志服务
        /// </summary>
        /// <param name="req"><see cref="FitClsLogRequest"/></param>
        /// <returns><see cref="FitClsLogResponse"/></returns>
        public FitClsLogResponse FitClsLogSync(FitClsLogRequest req)
        {
            return InternalRequestAsync<FitClsLogResponse>(req, "FitClsLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// KV模式修改配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public Task<ModifyInstanceKeyValConfigsResponse> ModifyInstanceKeyValConfigs(ModifyInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceKeyValConfigsResponse>(req, "ModifyInstanceKeyValConfigs");
        }

        /// <summary>
        /// KV模式修改配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public ModifyInstanceKeyValConfigsResponse ModifyInstanceKeyValConfigsSync(ModifyInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceKeyValConfigsResponse>(req, "ModifyInstanceKeyValConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改节点状态
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyNodeStatusResponse"/></returns>
        public Task<ModifyNodeStatusResponse> ModifyNodeStatus(ModifyNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyNodeStatusResponse>(req, "ModifyNodeStatus");
        }

        /// <summary>
        /// 修改节点状态
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyNodeStatusResponse"/></returns>
        public ModifyNodeStatusResponse ModifyNodeStatusSync(ModifyNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyNodeStatusResponse>(req, "ModifyNodeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更改安全组
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupsResponse"/></returns>
        public Task<ModifySecurityGroupsResponse> ModifySecurityGroups(ModifySecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupsResponse>(req, "ModifySecurityGroups");
        }

        /// <summary>
        /// 更改安全组
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupsResponse"/></returns>
        public ModifySecurityGroupsResponse ModifySecurityGroupsSync(ModifySecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupsResponse>(req, "ModifySecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户绑定的资源组
        /// </summary>
        /// <param name="req"><see cref="ModifyUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyUserBindWorkloadGroupResponse"/></returns>
        public Task<ModifyUserBindWorkloadGroupResponse> ModifyUserBindWorkloadGroup(ModifyUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserBindWorkloadGroupResponse>(req, "ModifyUserBindWorkloadGroup");
        }

        /// <summary>
        /// 修改用户绑定的资源组
        /// </summary>
        /// <param name="req"><see cref="ModifyUserBindWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyUserBindWorkloadGroupResponse"/></returns>
        public ModifyUserBindWorkloadGroupResponse ModifyUserBindWorkloadGroupSync(ModifyUserBindWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserBindWorkloadGroupResponse>(req, "ModifyUserBindWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户权限,支持catalog，全部db，部分db表三种权限设置类别
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesV3Request"/></param>
        /// <returns><see cref="ModifyUserPrivilegesV3Response"/></returns>
        public Task<ModifyUserPrivilegesV3Response> ModifyUserPrivilegesV3(ModifyUserPrivilegesV3Request req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesV3Response>(req, "ModifyUserPrivilegesV3");
        }

        /// <summary>
        /// 修改用户权限,支持catalog，全部db，部分db表三种权限设置类别
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesV3Request"/></param>
        /// <returns><see cref="ModifyUserPrivilegesV3Response"/></returns>
        public ModifyUserPrivilegesV3Response ModifyUserPrivilegesV3Sync(ModifyUserPrivilegesV3Request req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesV3Response>(req, "ModifyUserPrivilegesV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改资源组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupResponse"/></returns>
        public Task<ModifyWorkloadGroupResponse> ModifyWorkloadGroup(ModifyWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupResponse>(req, "ModifyWorkloadGroup");
        }

        /// <summary>
        /// 修改资源组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupResponse"/></returns>
        public ModifyWorkloadGroupResponse ModifyWorkloadGroupSync(ModifyWorkloadGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupResponse>(req, "ModifyWorkloadGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或关闭资源组
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupStatusResponse"/></returns>
        public Task<ModifyWorkloadGroupStatusResponse> ModifyWorkloadGroupStatus(ModifyWorkloadGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupStatusResponse>(req, "ModifyWorkloadGroupStatus");
        }

        /// <summary>
        /// 开启或关闭资源组
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkloadGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyWorkloadGroupStatusResponse"/></returns>
        public ModifyWorkloadGroupStatusResponse ModifyWorkloadGroupStatusSync(ModifyWorkloadGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyWorkloadGroupStatusResponse>(req, "ModifyWorkloadGroupStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或者关闭策略
        /// </summary>
        /// <param name="req"><see cref="OpenBackUpRequest"/></param>
        /// <returns><see cref="OpenBackUpResponse"/></returns>
        public Task<OpenBackUpResponse> OpenBackUp(OpenBackUpRequest req)
        {
            return InternalRequestAsync<OpenBackUpResponse>(req, "OpenBackUp");
        }

        /// <summary>
        /// 开启或者关闭策略
        /// </summary>
        /// <param name="req"><see cref="OpenBackUpRequest"/></param>
        /// <returns><see cref="OpenBackUpResponse"/></returns>
        public OpenBackUpResponse OpenBackUpSync(OpenBackUpRequest req)
        {
            return InternalRequestAsync<OpenBackUpResponse>(req, "OpenBackUp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 备份恢复
        /// </summary>
        /// <param name="req"><see cref="RecoverBackUpJobRequest"/></param>
        /// <returns><see cref="RecoverBackUpJobResponse"/></returns>
        public Task<RecoverBackUpJobResponse> RecoverBackUpJob(RecoverBackUpJobRequest req)
        {
            return InternalRequestAsync<RecoverBackUpJobResponse>(req, "RecoverBackUpJob");
        }

        /// <summary>
        /// 备份恢复
        /// </summary>
        /// <param name="req"><see cref="RecoverBackUpJobRequest"/></param>
        /// <returns><see cref="RecoverBackUpJobResponse"/></returns>
        public RecoverBackUpJobResponse RecoverBackUpJobSync(RecoverBackUpJobRequest req)
        {
            return InternalRequestAsync<RecoverBackUpJobResponse>(req, "RecoverBackUpJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群缩容
        /// </summary>
        /// <param name="req"><see cref="ReduceInstanceRequest"/></param>
        /// <returns><see cref="ReduceInstanceResponse"/></returns>
        public Task<ReduceInstanceResponse> ReduceInstance(ReduceInstanceRequest req)
        {
            return InternalRequestAsync<ReduceInstanceResponse>(req, "ReduceInstance");
        }

        /// <summary>
        /// 集群缩容
        /// </summary>
        /// <param name="req"><see cref="ReduceInstanceRequest"/></param>
        /// <returns><see cref="ReduceInstanceResponse"/></returns>
        public ReduceInstanceResponse ReduceInstanceSync(ReduceInstanceRequest req)
        {
            return InternalRequestAsync<ReduceInstanceResponse>(req, "ReduceInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容云盘
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk");
        }

        /// <summary>
        /// 扩容云盘
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启集群让配置文件生效
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForConfigsRequest"/></param>
        /// <returns><see cref="RestartClusterForConfigsResponse"/></returns>
        public Task<RestartClusterForConfigsResponse> RestartClusterForConfigs(RestartClusterForConfigsRequest req)
        {
            return InternalRequestAsync<RestartClusterForConfigsResponse>(req, "RestartClusterForConfigs");
        }

        /// <summary>
        /// 重启集群让配置文件生效
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForConfigsRequest"/></param>
        /// <returns><see cref="RestartClusterForConfigsResponse"/></returns>
        public RestartClusterForConfigsResponse RestartClusterForConfigsSync(RestartClusterForConfigsRequest req)
        {
            return InternalRequestAsync<RestartClusterForConfigsResponse>(req, "RestartClusterForConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群滚动重启
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForNodeRequest"/></param>
        /// <returns><see cref="RestartClusterForNodeResponse"/></returns>
        public Task<RestartClusterForNodeResponse> RestartClusterForNode(RestartClusterForNodeRequest req)
        {
            return InternalRequestAsync<RestartClusterForNodeResponse>(req, "RestartClusterForNode");
        }

        /// <summary>
        /// 集群滚动重启
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForNodeRequest"/></param>
        /// <returns><see cref="RestartClusterForNodeResponse"/></returns>
        public RestartClusterForNodeResponse RestartClusterForNodeSync(RestartClusterForNodeRequest req)
        {
            return InternalRequestAsync<RestartClusterForNodeResponse>(req, "RestartClusterForNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 水平扩容节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// 水平扩容节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 计算资源垂直变配
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public Task<ScaleUpInstanceResponse> ScaleUpInstance(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance");
        }

        /// <summary>
        /// 计算资源垂直变配
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public ScaleUpInstanceResponse ScaleUpInstanceSync(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
