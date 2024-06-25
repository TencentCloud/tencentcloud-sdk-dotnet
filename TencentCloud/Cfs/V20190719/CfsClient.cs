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

namespace TencentCloud.Cfs.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfs.V20190719.Models;

   public class CfsClient : AbstractClient{

       private const string endpoint = "cfs.tencentcloudapi.com";
       private const string version = "2019-07-19";
       private const string sdkVersion = "SDK_NET_3.0.1034";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 文件系统绑定快照策略，可以同时绑定多个fs，一个fs 只能跟一个策略绑定
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public Task<BindAutoSnapshotPolicyResponse> BindAutoSnapshotPolicy(BindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoSnapshotPolicyResponse>(req, "BindAutoSnapshotPolicy");
        }

        /// <summary>
        /// 文件系统绑定快照策略，可以同时绑定多个fs，一个fs 只能跟一个策略绑定
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public BindAutoSnapshotPolicyResponse BindAutoSnapshotPolicySync(BindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoSnapshotPolicyResponse>(req, "BindAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建定期快照策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoSnapshotPolicyResponse>(req, "CreateAutoSnapshotPolicy");
        }

        /// <summary>
        /// 创建定期快照策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicySync(CreateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoSnapshotPolicyResponse>(req, "CreateAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于添加新文件系统
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public Task<CreateCfsFileSystemResponse> CreateCfsFileSystem(CreateCfsFileSystemRequest req)
        {
            return InternalRequestAsync<CreateCfsFileSystemResponse>(req, "CreateCfsFileSystem");
        }

        /// <summary>
        /// 用于添加新文件系统
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public CreateCfsFileSystemResponse CreateCfsFileSystemSync(CreateCfsFileSystemRequest req)
        {
            return InternalRequestAsync<CreateCfsFileSystemResponse>(req, "CreateCfsFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCfsPGroup）用于创建权限组
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public Task<CreateCfsPGroupResponse> CreateCfsPGroup(CreateCfsPGroupRequest req)
        {
            return InternalRequestAsync<CreateCfsPGroupResponse>(req, "CreateCfsPGroup");
        }

        /// <summary>
        /// 本接口（CreateCfsPGroup）用于创建权限组
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public CreateCfsPGroupResponse CreateCfsPGroupSync(CreateCfsPGroupRequest req)
        {
            return InternalRequestAsync<CreateCfsPGroupResponse>(req, "CreateCfsPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCfsRule）用于创建权限组规则。
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public Task<CreateCfsRuleResponse> CreateCfsRule(CreateCfsRuleRequest req)
        {
            return InternalRequestAsync<CreateCfsRuleResponse>(req, "CreateCfsRule");
        }

        /// <summary>
        /// 本接口（CreateCfsRule）用于创建权限组规则。
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public CreateCfsRuleResponse CreateCfsRuleSync(CreateCfsRuleRequest req)
        {
            return InternalRequestAsync<CreateCfsRuleResponse>(req, "CreateCfsRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建文件系统快照
        /// </summary>
        /// <param name="req"><see cref="CreateCfsSnapshotRequest"/></param>
        /// <returns><see cref="CreateCfsSnapshotResponse"/></returns>
        public Task<CreateCfsSnapshotResponse> CreateCfsSnapshot(CreateCfsSnapshotRequest req)
        {
            return InternalRequestAsync<CreateCfsSnapshotResponse>(req, "CreateCfsSnapshot");
        }

        /// <summary>
        /// 创建文件系统快照
        /// </summary>
        /// <param name="req"><see cref="CreateCfsSnapshotRequest"/></param>
        /// <returns><see cref="CreateCfsSnapshotResponse"/></returns>
        public CreateCfsSnapshotResponse CreateCfsSnapshotSync(CreateCfsSnapshotRequest req)
        {
            return InternalRequestAsync<CreateCfsSnapshotResponse>(req, "CreateCfsSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建迁移任务。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationTaskRequest"/></param>
        /// <returns><see cref="CreateMigrationTaskResponse"/></returns>
        public Task<CreateMigrationTaskResponse> CreateMigrationTask(CreateMigrationTaskRequest req)
        {
            return InternalRequestAsync<CreateMigrationTaskResponse>(req, "CreateMigrationTask");
        }

        /// <summary>
        /// 用于创建迁移任务。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationTaskRequest"/></param>
        /// <returns><see cref="CreateMigrationTaskResponse"/></returns>
        public CreateMigrationTaskResponse CreateMigrationTaskSync(CreateMigrationTaskRequest req)
        {
            return InternalRequestAsync<CreateMigrationTaskResponse>(req, "CreateMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除快照定期策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPolicyResponse"/></returns>
        public Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicy(DeleteAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAutoSnapshotPolicyResponse>(req, "DeleteAutoSnapshotPolicy");
        }

        /// <summary>
        /// 删除快照定期策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPolicyResponse"/></returns>
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicySync(DeleteAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAutoSnapshotPolicyResponse>(req, "DeleteAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除文件系统
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public Task<DeleteCfsFileSystemResponse> DeleteCfsFileSystem(DeleteCfsFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteCfsFileSystemResponse>(req, "DeleteCfsFileSystem");
        }

        /// <summary>
        /// 用于删除文件系统
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public DeleteCfsFileSystemResponse DeleteCfsFileSystemSync(DeleteCfsFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteCfsFileSystemResponse>(req, "DeleteCfsFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCfsPGroup）用于删除权限组。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public Task<DeleteCfsPGroupResponse> DeleteCfsPGroup(DeleteCfsPGroupRequest req)
        {
            return InternalRequestAsync<DeleteCfsPGroupResponse>(req, "DeleteCfsPGroup");
        }

        /// <summary>
        /// 本接口（DeleteCfsPGroup）用于删除权限组。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public DeleteCfsPGroupResponse DeleteCfsPGroupSync(DeleteCfsPGroupRequest req)
        {
            return InternalRequestAsync<DeleteCfsPGroupResponse>(req, "DeleteCfsPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCfsRule）用于删除权限组规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public Task<DeleteCfsRuleResponse> DeleteCfsRule(DeleteCfsRuleRequest req)
        {
            return InternalRequestAsync<DeleteCfsRuleResponse>(req, "DeleteCfsRule");
        }

        /// <summary>
        /// 本接口（DeleteCfsRule）用于删除权限组规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public DeleteCfsRuleResponse DeleteCfsRuleSync(DeleteCfsRuleRequest req)
        {
            return InternalRequestAsync<DeleteCfsRuleResponse>(req, "DeleteCfsRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文件系统快照
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsSnapshotRequest"/></param>
        /// <returns><see cref="DeleteCfsSnapshotResponse"/></returns>
        public Task<DeleteCfsSnapshotResponse> DeleteCfsSnapshot(DeleteCfsSnapshotRequest req)
        {
            return InternalRequestAsync<DeleteCfsSnapshotResponse>(req, "DeleteCfsSnapshot");
        }

        /// <summary>
        /// 删除文件系统快照
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsSnapshotRequest"/></param>
        /// <returns><see cref="DeleteCfsSnapshotResponse"/></returns>
        public DeleteCfsSnapshotResponse DeleteCfsSnapshotSync(DeleteCfsSnapshotRequest req)
        {
            return InternalRequestAsync<DeleteCfsSnapshotResponse>(req, "DeleteCfsSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除迁移任务。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationTaskRequest"/></param>
        /// <returns><see cref="DeleteMigrationTaskResponse"/></returns>
        public Task<DeleteMigrationTaskResponse> DeleteMigrationTask(DeleteMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteMigrationTaskResponse>(req, "DeleteMigrationTask");
        }

        /// <summary>
        /// 用于删除迁移任务。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationTaskRequest"/></param>
        /// <returns><see cref="DeleteMigrationTaskResponse"/></returns>
        public DeleteMigrationTaskResponse DeleteMigrationTaskSync(DeleteMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeleteMigrationTaskResponse>(req, "DeleteMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteMountTarget）用于删除挂载点
        /// 说明：2022年6月1日之后创建的CFS文件系统删除时无需单独调用删除挂载点操作，此API仅适用老版本的CFS实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteMountTargetRequest"/></param>
        /// <returns><see cref="DeleteMountTargetResponse"/></returns>
        public Task<DeleteMountTargetResponse> DeleteMountTarget(DeleteMountTargetRequest req)
        {
            return InternalRequestAsync<DeleteMountTargetResponse>(req, "DeleteMountTarget");
        }

        /// <summary>
        /// 本接口（DeleteMountTarget）用于删除挂载点
        /// 说明：2022年6月1日之后创建的CFS文件系统删除时无需单独调用删除挂载点操作，此API仅适用老版本的CFS实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteMountTargetRequest"/></param>
        /// <returns><see cref="DeleteMountTargetResponse"/></returns>
        public DeleteMountTargetResponse DeleteMountTargetSync(DeleteMountTargetRequest req)
        {
            return InternalRequestAsync<DeleteMountTargetResponse>(req, "DeleteMountTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 指定条件删除文件系统配额
        /// </summary>
        /// <param name="req"><see cref="DeleteUserQuotaRequest"/></param>
        /// <returns><see cref="DeleteUserQuotaResponse"/></returns>
        public Task<DeleteUserQuotaResponse> DeleteUserQuota(DeleteUserQuotaRequest req)
        {
            return InternalRequestAsync<DeleteUserQuotaResponse>(req, "DeleteUserQuota");
        }

        /// <summary>
        /// 指定条件删除文件系统配额
        /// </summary>
        /// <param name="req"><see cref="DeleteUserQuotaRequest"/></param>
        /// <returns><see cref="DeleteUserQuotaResponse"/></returns>
        public DeleteUserQuotaResponse DeleteUserQuotaSync(DeleteUserQuotaRequest req)
        {
            return InternalRequestAsync<DeleteUserQuotaResponse>(req, "DeleteUserQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件系统快照定期策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoSnapshotPoliciesResponse>(req, "DescribeAutoSnapshotPolicies");
        }

        /// <summary>
        /// 查询文件系统快照定期策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPoliciesSync(DescribeAutoSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoSnapshotPoliciesResponse>(req, "DescribeAutoSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAvailableZoneInfo）用于查询区域的可用情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public Task<DescribeAvailableZoneInfoResponse> DescribeAvailableZoneInfo(DescribeAvailableZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeAvailableZoneInfoResponse>(req, "DescribeAvailableZoneInfo");
        }

        /// <summary>
        /// 本接口（DescribeAvailableZoneInfo）用于查询区域的可用情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public DescribeAvailableZoneInfoResponse DescribeAvailableZoneInfoSync(DescribeAvailableZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeAvailableZoneInfoResponse>(req, "DescribeAvailableZoneInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取数据源桶列表。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeBucketListRequest"/></param>
        /// <returns><see cref="DescribeBucketListResponse"/></returns>
        public Task<DescribeBucketListResponse> DescribeBucketList(DescribeBucketListRequest req)
        {
            return InternalRequestAsync<DescribeBucketListResponse>(req, "DescribeBucketList");
        }

        /// <summary>
        /// 用于获取数据源桶列表。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeBucketListRequest"/></param>
        /// <returns><see cref="DescribeBucketListResponse"/></returns>
        public DescribeBucketListResponse DescribeBucketListSync(DescribeBucketListRequest req)
        {
            return InternalRequestAsync<DescribeBucketListResponse>(req, "DescribeBucketList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询挂载该文件系统的客户端。此功能需要客户端安装CFS监控插件。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public Task<DescribeCfsFileSystemClientsResponse> DescribeCfsFileSystemClients(DescribeCfsFileSystemClientsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemClientsResponse>(req, "DescribeCfsFileSystemClients");
        }

        /// <summary>
        /// 查询挂载该文件系统的客户端。此功能需要客户端安装CFS监控插件。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public DescribeCfsFileSystemClientsResponse DescribeCfsFileSystemClientsSync(DescribeCfsFileSystemClientsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemClientsResponse>(req, "DescribeCfsFileSystemClients")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCfsFileSystems）用于查询文件系统
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public Task<DescribeCfsFileSystemsResponse> DescribeCfsFileSystems(DescribeCfsFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemsResponse>(req, "DescribeCfsFileSystems");
        }

        /// <summary>
        /// 本接口（DescribeCfsFileSystems）用于查询文件系统
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public DescribeCfsFileSystemsResponse DescribeCfsFileSystemsSync(DescribeCfsFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeCfsFileSystemsResponse>(req, "DescribeCfsFileSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCfsPGroups）用于查询权限组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public Task<DescribeCfsPGroupsResponse> DescribeCfsPGroups(DescribeCfsPGroupsRequest req)
        {
            return InternalRequestAsync<DescribeCfsPGroupsResponse>(req, "DescribeCfsPGroups");
        }

        /// <summary>
        /// 本接口（DescribeCfsPGroups）用于查询权限组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public DescribeCfsPGroupsResponse DescribeCfsPGroupsSync(DescribeCfsPGroupsRequest req)
        {
            return InternalRequestAsync<DescribeCfsPGroupsResponse>(req, "DescribeCfsPGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCfsRules）用于查询权限组规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public Task<DescribeCfsRulesResponse> DescribeCfsRules(DescribeCfsRulesRequest req)
        {
            return InternalRequestAsync<DescribeCfsRulesResponse>(req, "DescribeCfsRules");
        }

        /// <summary>
        /// 本接口（DescribeCfsRules）用于查询权限组规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public DescribeCfsRulesResponse DescribeCfsRulesSync(DescribeCfsRulesRequest req)
        {
            return InternalRequestAsync<DescribeCfsRulesResponse>(req, "DescribeCfsRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCfsServiceStatus）用于查询用户使用CFS的服务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public Task<DescribeCfsServiceStatusResponse> DescribeCfsServiceStatus(DescribeCfsServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeCfsServiceStatusResponse>(req, "DescribeCfsServiceStatus");
        }

        /// <summary>
        /// 本接口（DescribeCfsServiceStatus）用于查询用户使用CFS的服务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public DescribeCfsServiceStatusResponse DescribeCfsServiceStatusSync(DescribeCfsServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeCfsServiceStatusResponse>(req, "DescribeCfsServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文件系统快照概览
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotOverviewRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotOverviewResponse"/></returns>
        public Task<DescribeCfsSnapshotOverviewResponse> DescribeCfsSnapshotOverview(DescribeCfsSnapshotOverviewRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotOverviewResponse>(req, "DescribeCfsSnapshotOverview");
        }

        /// <summary>
        /// 文件系统快照概览
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotOverviewRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotOverviewResponse"/></returns>
        public DescribeCfsSnapshotOverviewResponse DescribeCfsSnapshotOverviewSync(DescribeCfsSnapshotOverviewRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotOverviewResponse>(req, "DescribeCfsSnapshotOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件系统快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotsResponse"/></returns>
        public Task<DescribeCfsSnapshotsResponse> DescribeCfsSnapshots(DescribeCfsSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotsResponse>(req, "DescribeCfsSnapshots");
        }

        /// <summary>
        /// 查询文件系统快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotsResponse"/></returns>
        public DescribeCfsSnapshotsResponse DescribeCfsSnapshotsSync(DescribeCfsSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeCfsSnapshotsResponse>(req, "DescribeCfsSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取迁移任务列表。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTasksRequest"/></param>
        /// <returns><see cref="DescribeMigrationTasksResponse"/></returns>
        public Task<DescribeMigrationTasksResponse> DescribeMigrationTasks(DescribeMigrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTasksResponse>(req, "DescribeMigrationTasks");
        }

        /// <summary>
        /// 用于获取迁移任务列表。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTasksRequest"/></param>
        /// <returns><see cref="DescribeMigrationTasksResponse"/></returns>
        public DescribeMigrationTasksResponse DescribeMigrationTasksSync(DescribeMigrationTasksRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTasksResponse>(req, "DescribeMigrationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMountTargets）用于查询文件系统挂载点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public Task<DescribeMountTargetsResponse> DescribeMountTargets(DescribeMountTargetsRequest req)
        {
            return InternalRequestAsync<DescribeMountTargetsResponse>(req, "DescribeMountTargets");
        }

        /// <summary>
        /// 本接口（DescribeMountTargets）用于查询文件系统挂载点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public DescribeMountTargetsResponse DescribeMountTargetsSync(DescribeMountTargetsRequest req)
        {
            return InternalRequestAsync<DescribeMountTargetsResponse>(req, "DescribeMountTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询快照操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public Task<DescribeSnapshotOperationLogsResponse> DescribeSnapshotOperationLogs(DescribeSnapshotOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotOperationLogsResponse>(req, "DescribeSnapshotOperationLogs");
        }

        /// <summary>
        /// 查询快照操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public DescribeSnapshotOperationLogsResponse DescribeSnapshotOperationLogsSync(DescribeSnapshotOperationLogsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotOperationLogsResponse>(req, "DescribeSnapshotOperationLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件系统配额（仅部分Turbo实例能使用，若需要调用请提交工单与我们联系）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public Task<DescribeUserQuotaResponse> DescribeUserQuota(DescribeUserQuotaRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotaResponse>(req, "DescribeUserQuota");
        }

        /// <summary>
        /// 查询文件系统配额（仅部分Turbo实例能使用，若需要调用请提交工单与我们联系）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public DescribeUserQuotaResponse DescribeUserQuotaSync(DescribeUserQuotaRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotaResponse>(req, "DescribeUserQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用来设置文件系统扩容策略
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemAutoScaleUpRuleRequest"/></param>
        /// <returns><see cref="ModifyFileSystemAutoScaleUpRuleResponse"/></returns>
        public Task<ModifyFileSystemAutoScaleUpRuleResponse> ModifyFileSystemAutoScaleUpRule(ModifyFileSystemAutoScaleUpRuleRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemAutoScaleUpRuleResponse>(req, "ModifyFileSystemAutoScaleUpRule");
        }

        /// <summary>
        /// 用来设置文件系统扩容策略
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemAutoScaleUpRuleRequest"/></param>
        /// <returns><see cref="ModifyFileSystemAutoScaleUpRuleResponse"/></returns>
        public ModifyFileSystemAutoScaleUpRuleResponse ModifyFileSystemAutoScaleUpRuleSync(ModifyFileSystemAutoScaleUpRuleRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemAutoScaleUpRuleResponse>(req, "ModifyFileSystemAutoScaleUpRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于对turbo 文件系统扩容使用
        /// </summary>
        /// <param name="req"><see cref="ScaleUpFileSystemRequest"/></param>
        /// <returns><see cref="ScaleUpFileSystemResponse"/></returns>
        public Task<ScaleUpFileSystemResponse> ScaleUpFileSystem(ScaleUpFileSystemRequest req)
        {
            return InternalRequestAsync<ScaleUpFileSystemResponse>(req, "ScaleUpFileSystem");
        }

        /// <summary>
        /// 该接口用于对turbo 文件系统扩容使用
        /// </summary>
        /// <param name="req"><see cref="ScaleUpFileSystemRequest"/></param>
        /// <returns><see cref="ScaleUpFileSystemResponse"/></returns>
        public ScaleUpFileSystemResponse ScaleUpFileSystemSync(ScaleUpFileSystemRequest req)
        {
            return InternalRequestAsync<ScaleUpFileSystemResponse>(req, "ScaleUpFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置文件系统配额，提供UID/GID的配额设置的接口
        /// </summary>
        /// <param name="req"><see cref="SetUserQuotaRequest"/></param>
        /// <returns><see cref="SetUserQuotaResponse"/></returns>
        public Task<SetUserQuotaResponse> SetUserQuota(SetUserQuotaRequest req)
        {
            return InternalRequestAsync<SetUserQuotaResponse>(req, "SetUserQuota");
        }

        /// <summary>
        /// 设置文件系统配额，提供UID/GID的配额设置的接口
        /// </summary>
        /// <param name="req"><see cref="SetUserQuotaRequest"/></param>
        /// <returns><see cref="SetUserQuotaResponse"/></returns>
        public SetUserQuotaResponse SetUserQuotaSync(SetUserQuotaRequest req)
        {
            return InternalRequestAsync<SetUserQuotaResponse>(req, "SetUserQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SignUpCfsService）用于开通CFS服务。
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public Task<SignUpCfsServiceResponse> SignUpCfsService(SignUpCfsServiceRequest req)
        {
            return InternalRequestAsync<SignUpCfsServiceResponse>(req, "SignUpCfsService");
        }

        /// <summary>
        /// 本接口（SignUpCfsService）用于开通CFS服务。
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public SignUpCfsServiceResponse SignUpCfsServiceSync(SignUpCfsServiceRequest req)
        {
            return InternalRequestAsync<SignUpCfsServiceResponse>(req, "SignUpCfsService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于终止迁移任务。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="StopMigrationTaskRequest"/></param>
        /// <returns><see cref="StopMigrationTaskResponse"/></returns>
        public Task<StopMigrationTaskResponse> StopMigrationTask(StopMigrationTaskRequest req)
        {
            return InternalRequestAsync<StopMigrationTaskResponse>(req, "StopMigrationTask");
        }

        /// <summary>
        /// 用于终止迁移任务。
        /// 此接口需提交工单，开启白名单之后才能使用。
        /// </summary>
        /// <param name="req"><see cref="StopMigrationTaskRequest"/></param>
        /// <returns><see cref="StopMigrationTaskResponse"/></returns>
        public StopMigrationTaskResponse StopMigrationTaskSync(StopMigrationTaskRequest req)
        {
            return InternalRequestAsync<StopMigrationTaskResponse>(req, "StopMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除文件系统绑定的快照策略
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public Task<UnbindAutoSnapshotPolicyResponse> UnbindAutoSnapshotPolicy(UnbindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoSnapshotPolicyResponse>(req, "UnbindAutoSnapshotPolicy");
        }

        /// <summary>
        /// 解除文件系统绑定的快照策略
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public UnbindAutoSnapshotPolicyResponse UnbindAutoSnapshotPolicySync(UnbindAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoSnapshotPolicyResponse>(req, "UnbindAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新定期自动快照策略
        /// </summary>
        /// <param name="req"><see cref="UpdateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UpdateAutoSnapshotPolicyResponse"/></returns>
        public Task<UpdateAutoSnapshotPolicyResponse> UpdateAutoSnapshotPolicy(UpdateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UpdateAutoSnapshotPolicyResponse>(req, "UpdateAutoSnapshotPolicy");
        }

        /// <summary>
        /// 更新定期自动快照策略
        /// </summary>
        /// <param name="req"><see cref="UpdateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UpdateAutoSnapshotPolicyResponse"/></returns>
        public UpdateAutoSnapshotPolicyResponse UpdateAutoSnapshotPolicySync(UpdateAutoSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<UpdateAutoSnapshotPolicyResponse>(req, "UpdateAutoSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemName）用于更新文件系统名
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public Task<UpdateCfsFileSystemNameResponse> UpdateCfsFileSystemName(UpdateCfsFileSystemNameRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemNameResponse>(req, "UpdateCfsFileSystemName");
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemName）用于更新文件系统名
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public UpdateCfsFileSystemNameResponse UpdateCfsFileSystemNameSync(UpdateCfsFileSystemNameRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemNameResponse>(req, "UpdateCfsFileSystemName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemPGroup）用于更新文件系统所使用的权限组
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public Task<UpdateCfsFileSystemPGroupResponse> UpdateCfsFileSystemPGroup(UpdateCfsFileSystemPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemPGroupResponse>(req, "UpdateCfsFileSystemPGroup");
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemPGroup）用于更新文件系统所使用的权限组
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public UpdateCfsFileSystemPGroupResponse UpdateCfsFileSystemPGroupSync(UpdateCfsFileSystemPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemPGroupResponse>(req, "UpdateCfsFileSystemPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemSizeLimit）用于更新文件系统存储容量限制。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public Task<UpdateCfsFileSystemSizeLimitResponse> UpdateCfsFileSystemSizeLimit(UpdateCfsFileSystemSizeLimitRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemSizeLimitResponse>(req, "UpdateCfsFileSystemSizeLimit");
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemSizeLimit）用于更新文件系统存储容量限制。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public UpdateCfsFileSystemSizeLimitResponse UpdateCfsFileSystemSizeLimitSync(UpdateCfsFileSystemSizeLimitRequest req)
        {
            return InternalRequestAsync<UpdateCfsFileSystemSizeLimitResponse>(req, "UpdateCfsFileSystemSizeLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateCfsPGroup）更新权限组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public Task<UpdateCfsPGroupResponse> UpdateCfsPGroup(UpdateCfsPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsPGroupResponse>(req, "UpdateCfsPGroup");
        }

        /// <summary>
        /// 本接口（UpdateCfsPGroup）更新权限组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public UpdateCfsPGroupResponse UpdateCfsPGroupSync(UpdateCfsPGroupRequest req)
        {
            return InternalRequestAsync<UpdateCfsPGroupResponse>(req, "UpdateCfsPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateCfsRule）用于更新权限规则。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public Task<UpdateCfsRuleResponse> UpdateCfsRule(UpdateCfsRuleRequest req)
        {
            return InternalRequestAsync<UpdateCfsRuleResponse>(req, "UpdateCfsRule");
        }

        /// <summary>
        /// 本接口（UpdateCfsRule）用于更新权限规则。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public UpdateCfsRuleResponse UpdateCfsRuleSync(UpdateCfsRuleRequest req)
        {
            return InternalRequestAsync<UpdateCfsRuleResponse>(req, "UpdateCfsRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新文件系统快照名称及保留时长
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsSnapshotAttributeRequest"/></param>
        /// <returns><see cref="UpdateCfsSnapshotAttributeResponse"/></returns>
        public Task<UpdateCfsSnapshotAttributeResponse> UpdateCfsSnapshotAttribute(UpdateCfsSnapshotAttributeRequest req)
        {
            return InternalRequestAsync<UpdateCfsSnapshotAttributeResponse>(req, "UpdateCfsSnapshotAttribute");
        }

        /// <summary>
        /// 更新文件系统快照名称及保留时长
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsSnapshotAttributeRequest"/></param>
        /// <returns><see cref="UpdateCfsSnapshotAttributeResponse"/></returns>
        public UpdateCfsSnapshotAttributeResponse UpdateCfsSnapshotAttributeSync(UpdateCfsSnapshotAttributeRequest req)
        {
            return InternalRequestAsync<UpdateCfsSnapshotAttributeResponse>(req, "UpdateCfsSnapshotAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新文件系统吞吐
        /// 仅吞吐型支持此接口
        /// </summary>
        /// <param name="req"><see cref="UpdateFileSystemBandwidthLimitRequest"/></param>
        /// <returns><see cref="UpdateFileSystemBandwidthLimitResponse"/></returns>
        public Task<UpdateFileSystemBandwidthLimitResponse> UpdateFileSystemBandwidthLimit(UpdateFileSystemBandwidthLimitRequest req)
        {
            return InternalRequestAsync<UpdateFileSystemBandwidthLimitResponse>(req, "UpdateFileSystemBandwidthLimit");
        }

        /// <summary>
        /// 更新文件系统吞吐
        /// 仅吞吐型支持此接口
        /// </summary>
        /// <param name="req"><see cref="UpdateFileSystemBandwidthLimitRequest"/></param>
        /// <returns><see cref="UpdateFileSystemBandwidthLimitResponse"/></returns>
        public UpdateFileSystemBandwidthLimitResponse UpdateFileSystemBandwidthLimitSync(UpdateFileSystemBandwidthLimitRequest req)
        {
            return InternalRequestAsync<UpdateFileSystemBandwidthLimitResponse>(req, "UpdateFileSystemBandwidthLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
