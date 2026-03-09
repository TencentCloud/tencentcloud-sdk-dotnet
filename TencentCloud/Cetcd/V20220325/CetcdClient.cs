/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cetcd.V20220325
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cetcd.V20220325.Models;

   public class CetcdClient : AbstractClient{

       private const string endpoint = "cetcd.tencentcloudapi.com";
       private const string version = "2022-03-25";
       private const string sdkVersion = "SDK_NET_3.0.1381";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CetcdClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CetcdClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建etcd实例
        /// </summary>
        /// <param name="req"><see cref="CreateEtcdInstanceRequest"/></param>
        /// <returns><see cref="CreateEtcdInstanceResponse"/></returns>
        public Task<CreateEtcdInstanceResponse> CreateEtcdInstance(CreateEtcdInstanceRequest req)
        {
            return InternalRequestAsync<CreateEtcdInstanceResponse>(req, "CreateEtcdInstance");
        }

        /// <summary>
        /// 创建etcd实例
        /// </summary>
        /// <param name="req"><see cref="CreateEtcdInstanceRequest"/></param>
        /// <returns><see cref="CreateEtcdInstanceResponse"/></returns>
        public CreateEtcdInstanceResponse CreateEtcdInstanceSync(CreateEtcdInstanceRequest req)
        {
            return InternalRequestAsync<CreateEtcdInstanceResponse>(req, "CreateEtcdInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建etcd快照
        /// </summary>
        /// <param name="req"><see cref="CreateEtcdSnapshotRequest"/></param>
        /// <returns><see cref="CreateEtcdSnapshotResponse"/></returns>
        public Task<CreateEtcdSnapshotResponse> CreateEtcdSnapshot(CreateEtcdSnapshotRequest req)
        {
            return InternalRequestAsync<CreateEtcdSnapshotResponse>(req, "CreateEtcdSnapshot");
        }

        /// <summary>
        /// 创建etcd快照
        /// </summary>
        /// <param name="req"><see cref="CreateEtcdSnapshotRequest"/></param>
        /// <returns><see cref="CreateEtcdSnapshotResponse"/></returns>
        public CreateEtcdSnapshotResponse CreateEtcdSnapshotSync(CreateEtcdSnapshotRequest req)
        {
            return InternalRequestAsync<CreateEtcdSnapshotResponse>(req, "CreateEtcdSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建etcd快照策略
        /// </summary>
        /// <param name="req"><see cref="CreateEtcdSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateEtcdSnapshotPolicyResponse"/></returns>
        public Task<CreateEtcdSnapshotPolicyResponse> CreateEtcdSnapshotPolicy(CreateEtcdSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateEtcdSnapshotPolicyResponse>(req, "CreateEtcdSnapshotPolicy");
        }

        /// <summary>
        /// 创建etcd快照策略
        /// </summary>
        /// <param name="req"><see cref="CreateEtcdSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateEtcdSnapshotPolicyResponse"/></returns>
        public CreateEtcdSnapshotPolicyResponse CreateEtcdSnapshotPolicySync(CreateEtcdSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<CreateEtcdSnapshotPolicyResponse>(req, "CreateEtcdSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看etcd可用版本
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdAvailableVersionsRequest"/></param>
        /// <returns><see cref="DescribeEtcdAvailableVersionsResponse"/></returns>
        public Task<DescribeEtcdAvailableVersionsResponse> DescribeEtcdAvailableVersions(DescribeEtcdAvailableVersionsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdAvailableVersionsResponse>(req, "DescribeEtcdAvailableVersions");
        }

        /// <summary>
        /// 查看etcd可用版本
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdAvailableVersionsRequest"/></param>
        /// <returns><see cref="DescribeEtcdAvailableVersionsResponse"/></returns>
        public DescribeEtcdAvailableVersionsResponse DescribeEtcdAvailableVersionsSync(DescribeEtcdAvailableVersionsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdAvailableVersionsResponse>(req, "DescribeEtcdAvailableVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看etcd集群创建进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdCreatingProgressRequest"/></param>
        /// <returns><see cref="DescribeEtcdCreatingProgressResponse"/></returns>
        public Task<DescribeEtcdCreatingProgressResponse> DescribeEtcdCreatingProgress(DescribeEtcdCreatingProgressRequest req)
        {
            return InternalRequestAsync<DescribeEtcdCreatingProgressResponse>(req, "DescribeEtcdCreatingProgress");
        }

        /// <summary>
        /// 查看etcd集群创建进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdCreatingProgressRequest"/></param>
        /// <returns><see cref="DescribeEtcdCreatingProgressResponse"/></returns>
        public DescribeEtcdCreatingProgressResponse DescribeEtcdCreatingProgressSync(DescribeEtcdCreatingProgressRequest req)
        {
            return InternalRequestAsync<DescribeEtcdCreatingProgressResponse>(req, "DescribeEtcdCreatingProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询etcd访问凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdCredentialsRequest"/></param>
        /// <returns><see cref="DescribeEtcdCredentialsResponse"/></returns>
        public Task<DescribeEtcdCredentialsResponse> DescribeEtcdCredentials(DescribeEtcdCredentialsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdCredentialsResponse>(req, "DescribeEtcdCredentials");
        }

        /// <summary>
        /// 查询etcd访问凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdCredentialsRequest"/></param>
        /// <returns><see cref="DescribeEtcdCredentialsResponse"/></returns>
        public DescribeEtcdCredentialsResponse DescribeEtcdCredentialsSync(DescribeEtcdCredentialsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdCredentialsResponse>(req, "DescribeEtcdCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询etcd实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdInstancesRequest"/></param>
        /// <returns><see cref="DescribeEtcdInstancesResponse"/></returns>
        public Task<DescribeEtcdInstancesResponse> DescribeEtcdInstances(DescribeEtcdInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEtcdInstancesResponse>(req, "DescribeEtcdInstances");
        }

        /// <summary>
        /// 查询etcd实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdInstancesRequest"/></param>
        /// <returns><see cref="DescribeEtcdInstancesResponse"/></returns>
        public DescribeEtcdInstancesResponse DescribeEtcdInstancesSync(DescribeEtcdInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEtcdInstancesResponse>(req, "DescribeEtcdInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看etcd集群配额
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdQuotaRequest"/></param>
        /// <returns><see cref="DescribeEtcdQuotaResponse"/></returns>
        public Task<DescribeEtcdQuotaResponse> DescribeEtcdQuota(DescribeEtcdQuotaRequest req)
        {
            return InternalRequestAsync<DescribeEtcdQuotaResponse>(req, "DescribeEtcdQuota");
        }

        /// <summary>
        /// 查看etcd集群配额
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdQuotaRequest"/></param>
        /// <returns><see cref="DescribeEtcdQuotaResponse"/></returns>
        public DescribeEtcdQuotaResponse DescribeEtcdQuotaSync(DescribeEtcdQuotaRequest req)
        {
            return InternalRequestAsync<DescribeEtcdQuotaResponse>(req, "DescribeEtcdQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看etcd支持地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdRegionsRequest"/></param>
        /// <returns><see cref="DescribeEtcdRegionsResponse"/></returns>
        public Task<DescribeEtcdRegionsResponse> DescribeEtcdRegions(DescribeEtcdRegionsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdRegionsResponse>(req, "DescribeEtcdRegions");
        }

        /// <summary>
        /// 查看etcd支持地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdRegionsRequest"/></param>
        /// <returns><see cref="DescribeEtcdRegionsResponse"/></returns>
        public DescribeEtcdRegionsResponse DescribeEtcdRegionsSync(DescribeEtcdRegionsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdRegionsResponse>(req, "DescribeEtcdRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看etcd快照策略
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeEtcdSnapshotPoliciesResponse"/></returns>
        public Task<DescribeEtcdSnapshotPoliciesResponse> DescribeEtcdSnapshotPolicies(DescribeEtcdSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeEtcdSnapshotPoliciesResponse>(req, "DescribeEtcdSnapshotPolicies");
        }

        /// <summary>
        /// 查看etcd快照策略
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeEtcdSnapshotPoliciesResponse"/></returns>
        public DescribeEtcdSnapshotPoliciesResponse DescribeEtcdSnapshotPoliciesSync(DescribeEtcdSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeEtcdSnapshotPoliciesResponse>(req, "DescribeEtcdSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看etcd快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeEtcdSnapshotsResponse"/></returns>
        public Task<DescribeEtcdSnapshotsResponse> DescribeEtcdSnapshots(DescribeEtcdSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdSnapshotsResponse>(req, "DescribeEtcdSnapshots");
        }

        /// <summary>
        /// 查看etcd快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeEtcdSnapshotsResponse"/></returns>
        public DescribeEtcdSnapshotsResponse DescribeEtcdSnapshotsSync(DescribeEtcdSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeEtcdSnapshotsResponse>(req, "DescribeEtcdSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看etcd相关tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdTasksRequest"/></param>
        /// <returns><see cref="DescribeEtcdTasksResponse"/></returns>
        public Task<DescribeEtcdTasksResponse> DescribeEtcdTasks(DescribeEtcdTasksRequest req)
        {
            return InternalRequestAsync<DescribeEtcdTasksResponse>(req, "DescribeEtcdTasks");
        }

        /// <summary>
        /// 查看etcd相关tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeEtcdTasksRequest"/></param>
        /// <returns><see cref="DescribeEtcdTasksResponse"/></returns>
        public DescribeEtcdTasksResponse DescribeEtcdTasksSync(DescribeEtcdTasksRequest req)
        {
            return InternalRequestAsync<DescribeEtcdTasksResponse>(req, "DescribeEtcdTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取etcd集群的gRPC方法列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRPCMethodListRequest"/></param>
        /// <returns><see cref="DescribeRPCMethodListResponse"/></returns>
        public Task<DescribeRPCMethodListResponse> DescribeRPCMethodList(DescribeRPCMethodListRequest req)
        {
            return InternalRequestAsync<DescribeRPCMethodListResponse>(req, "DescribeRPCMethodList");
        }

        /// <summary>
        /// 获取etcd集群的gRPC方法列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRPCMethodListRequest"/></param>
        /// <returns><see cref="DescribeRPCMethodListResponse"/></returns>
        public DescribeRPCMethodListResponse DescribeRPCMethodListSync(DescribeRPCMethodListRequest req)
        {
            return InternalRequestAsync<DescribeRPCMethodListResponse>(req, "DescribeRPCMethodList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭etcd实例删除保护
        /// </summary>
        /// <param name="req"><see cref="DisableEtcdInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableEtcdInstanceDeletionProtectionResponse"/></returns>
        public Task<DisableEtcdInstanceDeletionProtectionResponse> DisableEtcdInstanceDeletionProtection(DisableEtcdInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<DisableEtcdInstanceDeletionProtectionResponse>(req, "DisableEtcdInstanceDeletionProtection");
        }

        /// <summary>
        /// 关闭etcd实例删除保护
        /// </summary>
        /// <param name="req"><see cref="DisableEtcdInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableEtcdInstanceDeletionProtectionResponse"/></returns>
        public DisableEtcdInstanceDeletionProtectionResponse DisableEtcdInstanceDeletionProtectionSync(DisableEtcdInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<DisableEtcdInstanceDeletionProtectionResponse>(req, "DisableEtcdInstanceDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用etcd实例删除保护
        /// </summary>
        /// <param name="req"><see cref="EnableEtcdInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableEtcdInstanceDeletionProtectionResponse"/></returns>
        public Task<EnableEtcdInstanceDeletionProtectionResponse> EnableEtcdInstanceDeletionProtection(EnableEtcdInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<EnableEtcdInstanceDeletionProtectionResponse>(req, "EnableEtcdInstanceDeletionProtection");
        }

        /// <summary>
        /// 启用etcd实例删除保护
        /// </summary>
        /// <param name="req"><see cref="EnableEtcdInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableEtcdInstanceDeletionProtectionResponse"/></returns>
        public EnableEtcdInstanceDeletionProtectionResponse EnableEtcdInstanceDeletionProtectionSync(EnableEtcdInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<EnableEtcdInstanceDeletionProtectionResponse>(req, "EnableEtcdInstanceDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改etcd实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyEtcdAttributeRequest"/></param>
        /// <returns><see cref="ModifyEtcdAttributeResponse"/></returns>
        public Task<ModifyEtcdAttributeResponse> ModifyEtcdAttribute(ModifyEtcdAttributeRequest req)
        {
            return InternalRequestAsync<ModifyEtcdAttributeResponse>(req, "ModifyEtcdAttribute");
        }

        /// <summary>
        /// 修改etcd实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyEtcdAttributeRequest"/></param>
        /// <returns><see cref="ModifyEtcdAttributeResponse"/></returns>
        public ModifyEtcdAttributeResponse ModifyEtcdAttributeSync(ModifyEtcdAttributeRequest req)
        {
            return InternalRequestAsync<ModifyEtcdAttributeResponse>(req, "ModifyEtcdAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改etcd实例配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEtcdConfigurationRequest"/></param>
        /// <returns><see cref="ModifyEtcdConfigurationResponse"/></returns>
        public Task<ModifyEtcdConfigurationResponse> ModifyEtcdConfiguration(ModifyEtcdConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyEtcdConfigurationResponse>(req, "ModifyEtcdConfiguration");
        }

        /// <summary>
        /// 修改etcd实例配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEtcdConfigurationRequest"/></param>
        /// <returns><see cref="ModifyEtcdConfigurationResponse"/></returns>
        public ModifyEtcdConfigurationResponse ModifyEtcdConfigurationSync(ModifyEtcdConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyEtcdConfigurationResponse>(req, "ModifyEtcdConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改etcd快照策略
        /// </summary>
        /// <param name="req"><see cref="ModifyEtcdSnapshotPolicyRequest"/></param>
        /// <returns><see cref="ModifyEtcdSnapshotPolicyResponse"/></returns>
        public Task<ModifyEtcdSnapshotPolicyResponse> ModifyEtcdSnapshotPolicy(ModifyEtcdSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<ModifyEtcdSnapshotPolicyResponse>(req, "ModifyEtcdSnapshotPolicy");
        }

        /// <summary>
        /// 修改etcd快照策略
        /// </summary>
        /// <param name="req"><see cref="ModifyEtcdSnapshotPolicyRequest"/></param>
        /// <returns><see cref="ModifyEtcdSnapshotPolicyResponse"/></returns>
        public ModifyEtcdSnapshotPolicyResponse ModifyEtcdSnapshotPolicySync(ModifyEtcdSnapshotPolicyRequest req)
        {
            return InternalRequestAsync<ModifyEtcdSnapshotPolicyResponse>(req, "ModifyEtcdSnapshotPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容etcd实例
        /// </summary>
        /// <param name="req"><see cref="ResizeEtcdInstanceRequest"/></param>
        /// <returns><see cref="ResizeEtcdInstanceResponse"/></returns>
        public Task<ResizeEtcdInstanceResponse> ResizeEtcdInstance(ResizeEtcdInstanceRequest req)
        {
            return InternalRequestAsync<ResizeEtcdInstanceResponse>(req, "ResizeEtcdInstance");
        }

        /// <summary>
        /// 扩容etcd实例
        /// </summary>
        /// <param name="req"><see cref="ResizeEtcdInstanceRequest"/></param>
        /// <returns><see cref="ResizeEtcdInstanceResponse"/></returns>
        public ResizeEtcdInstanceResponse ResizeEtcdInstanceSync(ResizeEtcdInstanceRequest req)
        {
            return InternalRequestAsync<ResizeEtcdInstanceResponse>(req, "ResizeEtcdInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级etcd实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeEtcdInstanceRequest"/></param>
        /// <returns><see cref="UpgradeEtcdInstanceResponse"/></returns>
        public Task<UpgradeEtcdInstanceResponse> UpgradeEtcdInstance(UpgradeEtcdInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeEtcdInstanceResponse>(req, "UpgradeEtcdInstance");
        }

        /// <summary>
        /// 升级etcd实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeEtcdInstanceRequest"/></param>
        /// <returns><see cref="UpgradeEtcdInstanceResponse"/></returns>
        public UpgradeEtcdInstanceResponse UpgradeEtcdInstanceSync(UpgradeEtcdInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeEtcdInstanceResponse>(req, "UpgradeEtcdInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
