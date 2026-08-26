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

namespace TencentCloud.Bdrc.V20260330
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bdrc.V20260330.Models;

   public class BdrcClient : AbstractClient{

       private const string endpoint = "bdrc.tencentcloudapi.com";
       private const string version = "2026-03-30";
       private const string sdkVersion = "SDK_NET_3.0.1496";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BdrcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BdrcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 回滚备份组
        /// </summary>
        /// <param name="req"><see cref="ApplyBackupGroupRequest"/></param>
        /// <returns><see cref="ApplyBackupGroupResponse"/></returns>
        public Task<ApplyBackupGroupResponse> ApplyBackupGroup(ApplyBackupGroupRequest req)
        {
            return InternalRequestAsync<ApplyBackupGroupResponse>(req, "ApplyBackupGroup");
        }

        /// <summary>
        /// 回滚备份组
        /// </summary>
        /// <param name="req"><see cref="ApplyBackupGroupRequest"/></param>
        /// <returns><see cref="ApplyBackupGroupResponse"/></returns>
        public ApplyBackupGroupResponse ApplyBackupGroupSync(ApplyBackupGroupRequest req)
        {
            return InternalRequestAsync<ApplyBackupGroupResponse>(req, "ApplyBackupGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将实例绑定到备份策略上
        /// </summary>
        /// <param name="req"><see cref="BindAutoBackupPolicyRequest"/></param>
        /// <returns><see cref="BindAutoBackupPolicyResponse"/></returns>
        public Task<BindAutoBackupPolicyResponse> BindAutoBackupPolicy(BindAutoBackupPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoBackupPolicyResponse>(req, "BindAutoBackupPolicy");
        }

        /// <summary>
        /// 将实例绑定到备份策略上
        /// </summary>
        /// <param name="req"><see cref="BindAutoBackupPolicyRequest"/></param>
        /// <returns><see cref="BindAutoBackupPolicyResponse"/></returns>
        public BindAutoBackupPolicyResponse BindAutoBackupPolicySync(BindAutoBackupPolicyRequest req)
        {
            return InternalRequestAsync<BindAutoBackupPolicyResponse>(req, "BindAutoBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoBackupPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoBackupPolicyResponse"/></returns>
        public Task<CreateAutoBackupPolicyResponse> CreateAutoBackupPolicy(CreateAutoBackupPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoBackupPolicyResponse>(req, "CreateAutoBackupPolicy");
        }

        /// <summary>
        /// 创建备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoBackupPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoBackupPolicyResponse"/></returns>
        public CreateAutoBackupPolicyResponse CreateAutoBackupPolicySync(CreateAutoBackupPolicyRequest req)
        {
            return InternalRequestAsync<CreateAutoBackupPolicyResponse>(req, "CreateAutoBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建备份组
        /// </summary>
        /// <param name="req"><see cref="CreateBackupGroupRequest"/></param>
        /// <returns><see cref="CreateBackupGroupResponse"/></returns>
        public Task<CreateBackupGroupResponse> CreateBackupGroup(CreateBackupGroupRequest req)
        {
            return InternalRequestAsync<CreateBackupGroupResponse>(req, "CreateBackupGroup");
        }

        /// <summary>
        /// 创建备份组
        /// </summary>
        /// <param name="req"><see cref="CreateBackupGroupRequest"/></param>
        /// <returns><see cref="CreateBackupGroupResponse"/></returns>
        public CreateBackupGroupResponse CreateBackupGroupSync(CreateBackupGroupRequest req)
        {
            return InternalRequestAsync<CreateBackupGroupResponse>(req, "CreateBackupGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建备份库
        /// </summary>
        /// <param name="req"><see cref="CreateBackupVaultRequest"/></param>
        /// <returns><see cref="CreateBackupVaultResponse"/></returns>
        public Task<CreateBackupVaultResponse> CreateBackupVault(CreateBackupVaultRequest req)
        {
            return InternalRequestAsync<CreateBackupVaultResponse>(req, "CreateBackupVault");
        }

        /// <summary>
        /// 创建备份库
        /// </summary>
        /// <param name="req"><see cref="CreateBackupVaultRequest"/></param>
        /// <returns><see cref="CreateBackupVaultResponse"/></returns>
        public CreateBackupVaultResponse CreateBackupVaultSync(CreateBackupVaultRequest req)
        {
            return InternalRequestAsync<CreateBackupVaultResponse>(req, "CreateBackupVault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建容灾保护组
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoveryProtectGroupRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoveryProtectGroupResponse"/></returns>
        public Task<CreateDisasterRecoveryProtectGroupResponse> CreateDisasterRecoveryProtectGroup(CreateDisasterRecoveryProtectGroupRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoveryProtectGroupResponse>(req, "CreateDisasterRecoveryProtectGroup");
        }

        /// <summary>
        /// 本接口用于创建容灾保护组
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoveryProtectGroupRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoveryProtectGroupResponse"/></returns>
        public CreateDisasterRecoveryProtectGroupResponse CreateDisasterRecoveryProtectGroupSync(CreateDisasterRecoveryProtectGroupRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoveryProtectGroupResponse>(req, "CreateDisasterRecoveryProtectGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建容灾站点对
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoverySitePairRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoverySitePairResponse"/></returns>
        public Task<CreateDisasterRecoverySitePairResponse> CreateDisasterRecoverySitePair(CreateDisasterRecoverySitePairRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoverySitePairResponse>(req, "CreateDisasterRecoverySitePair");
        }

        /// <summary>
        /// 创建容灾站点对
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoverySitePairRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoverySitePairResponse"/></returns>
        public CreateDisasterRecoverySitePairResponse CreateDisasterRecoverySitePairSync(CreateDisasterRecoverySitePairRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoverySitePairResponse>(req, "CreateDisasterRecoverySitePair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建容灾站点VPC网络映射
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoveryVpcMappingRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoveryVpcMappingResponse"/></returns>
        public Task<CreateDisasterRecoveryVpcMappingResponse> CreateDisasterRecoveryVpcMapping(CreateDisasterRecoveryVpcMappingRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoveryVpcMappingResponse>(req, "CreateDisasterRecoveryVpcMapping");
        }

        /// <summary>
        /// 本接口用于创建容灾站点VPC网络映射
        /// </summary>
        /// <param name="req"><see cref="CreateDisasterRecoveryVpcMappingRequest"/></param>
        /// <returns><see cref="CreateDisasterRecoveryVpcMappingResponse"/></returns>
        public CreateDisasterRecoveryVpcMappingResponse CreateDisasterRecoveryVpcMappingSync(CreateDisasterRecoveryVpcMappingRequest req)
        {
            return InternalRequestAsync<CreateDisasterRecoveryVpcMappingResponse>(req, "CreateDisasterRecoveryVpcMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建文件备份点
        /// </summary>
        /// <param name="req"><see cref="CreateFileBackupRequest"/></param>
        /// <returns><see cref="CreateFileBackupResponse"/></returns>
        public Task<CreateFileBackupResponse> CreateFileBackup(CreateFileBackupRequest req)
        {
            return InternalRequestAsync<CreateFileBackupResponse>(req, "CreateFileBackup");
        }

        /// <summary>
        /// 本接口用于创建文件备份点
        /// </summary>
        /// <param name="req"><see cref="CreateFileBackupRequest"/></param>
        /// <returns><see cref="CreateFileBackupResponse"/></returns>
        public CreateFileBackupResponse CreateFileBackupSync(CreateFileBackupRequest req)
        {
            return InternalRequestAsync<CreateFileBackupResponse>(req, "CreateFileBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建备份计划
        /// </summary>
        /// <param name="req"><see cref="CreateFileBackupPlanRequest"/></param>
        /// <returns><see cref="CreateFileBackupPlanResponse"/></returns>
        public Task<CreateFileBackupPlanResponse> CreateFileBackupPlan(CreateFileBackupPlanRequest req)
        {
            return InternalRequestAsync<CreateFileBackupPlanResponse>(req, "CreateFileBackupPlan");
        }

        /// <summary>
        /// 本接口用于创建备份计划
        /// </summary>
        /// <param name="req"><see cref="CreateFileBackupPlanRequest"/></param>
        /// <returns><see cref="CreateFileBackupPlanResponse"/></returns>
        public CreateFileBackupPlanResponse CreateFileBackupPlanSync(CreateFileBackupPlanRequest req)
        {
            return InternalRequestAsync<CreateFileBackupPlanResponse>(req, "CreateFileBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建恢复任务
        /// </summary>
        /// <param name="req"><see cref="CreateFileRestoreTaskRequest"/></param>
        /// <returns><see cref="CreateFileRestoreTaskResponse"/></returns>
        public Task<CreateFileRestoreTaskResponse> CreateFileRestoreTask(CreateFileRestoreTaskRequest req)
        {
            return InternalRequestAsync<CreateFileRestoreTaskResponse>(req, "CreateFileRestoreTask");
        }

        /// <summary>
        /// 创建恢复任务
        /// </summary>
        /// <param name="req"><see cref="CreateFileRestoreTaskRequest"/></param>
        /// <returns><see cref="CreateFileRestoreTaskResponse"/></returns>
        public CreateFileRestoreTaskResponse CreateFileRestoreTaskSync(CreateFileRestoreTaskRequest req)
        {
            return InternalRequestAsync<CreateFileRestoreTaskResponse>(req, "CreateFileRestoreTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建CVM复制对
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCopyPairRequest"/></param>
        /// <returns><see cref="CreateInstanceCopyPairResponse"/></returns>
        public Task<CreateInstanceCopyPairResponse> CreateInstanceCopyPair(CreateInstanceCopyPairRequest req)
        {
            return InternalRequestAsync<CreateInstanceCopyPairResponse>(req, "CreateInstanceCopyPair");
        }

        /// <summary>
        /// 本接口用于创建CVM复制对
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceCopyPairRequest"/></param>
        /// <returns><see cref="CreateInstanceCopyPairResponse"/></returns>
        public CreateInstanceCopyPairResponse CreateInstanceCopyPairSync(CreateInstanceCopyPairRequest req)
        {
            return InternalRequestAsync<CreateInstanceCopyPairResponse>(req, "CreateInstanceCopyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建cvm演练
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceDrillPairsRequest"/></param>
        /// <returns><see cref="CreateInstanceDrillPairsResponse"/></returns>
        public Task<CreateInstanceDrillPairsResponse> CreateInstanceDrillPairs(CreateInstanceDrillPairsRequest req)
        {
            return InternalRequestAsync<CreateInstanceDrillPairsResponse>(req, "CreateInstanceDrillPairs");
        }

        /// <summary>
        /// 创建cvm演练
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceDrillPairsRequest"/></param>
        /// <returns><see cref="CreateInstanceDrillPairsResponse"/></returns>
        public CreateInstanceDrillPairsResponse CreateInstanceDrillPairsSync(CreateInstanceDrillPairsRequest req)
        {
            return InternalRequestAsync<CreateInstanceDrillPairsResponse>(req, "CreateInstanceDrillPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于为站点对新增安全组映射，生产端实例绑定的安全组为源端，需要为每个生产端实例绑定的安全组建立映射，在创建复制对时，会自动以映射后的目标安全组作为容灾端实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupMappingRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupMappingResponse"/></returns>
        public Task<CreateSecurityGroupMappingResponse> CreateSecurityGroupMapping(CreateSecurityGroupMappingRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupMappingResponse>(req, "CreateSecurityGroupMapping");
        }

        /// <summary>
        /// 本接口用于为站点对新增安全组映射，生产端实例绑定的安全组为源端，需要为每个生产端实例绑定的安全组建立映射，在创建复制对时，会自动以映射后的目标安全组作为容灾端实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupMappingRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupMappingResponse"/></returns>
        public CreateSecurityGroupMappingResponse CreateSecurityGroupMappingSync(CreateSecurityGroupMappingRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupMappingResponse>(req, "CreateSecurityGroupMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoBackupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteAutoBackupPoliciesResponse"/></returns>
        public Task<DeleteAutoBackupPoliciesResponse> DeleteAutoBackupPolicies(DeleteAutoBackupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteAutoBackupPoliciesResponse>(req, "DeleteAutoBackupPolicies");
        }

        /// <summary>
        /// 删除备份策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoBackupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteAutoBackupPoliciesResponse"/></returns>
        public DeleteAutoBackupPoliciesResponse DeleteAutoBackupPoliciesSync(DeleteAutoBackupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteAutoBackupPoliciesResponse>(req, "DeleteAutoBackupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份组
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupGroupsRequest"/></param>
        /// <returns><see cref="DeleteBackupGroupsResponse"/></returns>
        public Task<DeleteBackupGroupsResponse> DeleteBackupGroups(DeleteBackupGroupsRequest req)
        {
            return InternalRequestAsync<DeleteBackupGroupsResponse>(req, "DeleteBackupGroups");
        }

        /// <summary>
        /// 删除备份组
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupGroupsRequest"/></param>
        /// <returns><see cref="DeleteBackupGroupsResponse"/></returns>
        public DeleteBackupGroupsResponse DeleteBackupGroupsSync(DeleteBackupGroupsRequest req)
        {
            return InternalRequestAsync<DeleteBackupGroupsResponse>(req, "DeleteBackupGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份库
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupVaultsRequest"/></param>
        /// <returns><see cref="DeleteBackupVaultsResponse"/></returns>
        public Task<DeleteBackupVaultsResponse> DeleteBackupVaults(DeleteBackupVaultsRequest req)
        {
            return InternalRequestAsync<DeleteBackupVaultsResponse>(req, "DeleteBackupVaults");
        }

        /// <summary>
        /// 删除备份库
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupVaultsRequest"/></param>
        /// <returns><see cref="DeleteBackupVaultsResponse"/></returns>
        public DeleteBackupVaultsResponse DeleteBackupVaultsSync(DeleteBackupVaultsRequest req)
        {
            return InternalRequestAsync<DeleteBackupVaultsResponse>(req, "DeleteBackupVaults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除容灾复制对
        /// </summary>
        /// <param name="req"><see cref="DeleteCopyPairsRequest"/></param>
        /// <returns><see cref="DeleteCopyPairsResponse"/></returns>
        public Task<DeleteCopyPairsResponse> DeleteCopyPairs(DeleteCopyPairsRequest req)
        {
            return InternalRequestAsync<DeleteCopyPairsResponse>(req, "DeleteCopyPairs");
        }

        /// <summary>
        /// 本接口用于删除容灾复制对
        /// </summary>
        /// <param name="req"><see cref="DeleteCopyPairsRequest"/></param>
        /// <returns><see cref="DeleteCopyPairsResponse"/></returns>
        public DeleteCopyPairsResponse DeleteCopyPairsSync(DeleteCopyPairsRequest req)
        {
            return InternalRequestAsync<DeleteCopyPairsResponse>(req, "DeleteCopyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除容灾保护组
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoveryProtectGroupsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoveryProtectGroupsResponse"/></returns>
        public Task<DeleteDisasterRecoveryProtectGroupsResponse> DeleteDisasterRecoveryProtectGroups(DeleteDisasterRecoveryProtectGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoveryProtectGroupsResponse>(req, "DeleteDisasterRecoveryProtectGroups");
        }

        /// <summary>
        /// 本接口用于删除容灾保护组
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoveryProtectGroupsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoveryProtectGroupsResponse"/></returns>
        public DeleteDisasterRecoveryProtectGroupsResponse DeleteDisasterRecoveryProtectGroupsSync(DeleteDisasterRecoveryProtectGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoveryProtectGroupsResponse>(req, "DeleteDisasterRecoveryProtectGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除容灾站点对
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoverySitePairsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoverySitePairsResponse"/></returns>
        public Task<DeleteDisasterRecoverySitePairsResponse> DeleteDisasterRecoverySitePairs(DeleteDisasterRecoverySitePairsRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoverySitePairsResponse>(req, "DeleteDisasterRecoverySitePairs");
        }

        /// <summary>
        /// 删除容灾站点对
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoverySitePairsRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoverySitePairsResponse"/></returns>
        public DeleteDisasterRecoverySitePairsResponse DeleteDisasterRecoverySitePairsSync(DeleteDisasterRecoverySitePairsRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoverySitePairsResponse>(req, "DeleteDisasterRecoverySitePairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除容灾站点对vpc映射信息
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoveryVpcMappingRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoveryVpcMappingResponse"/></returns>
        public Task<DeleteDisasterRecoveryVpcMappingResponse> DeleteDisasterRecoveryVpcMapping(DeleteDisasterRecoveryVpcMappingRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoveryVpcMappingResponse>(req, "DeleteDisasterRecoveryVpcMapping");
        }

        /// <summary>
        /// 本接口用于删除容灾站点对vpc映射信息
        /// </summary>
        /// <param name="req"><see cref="DeleteDisasterRecoveryVpcMappingRequest"/></param>
        /// <returns><see cref="DeleteDisasterRecoveryVpcMappingResponse"/></returns>
        public DeleteDisasterRecoveryVpcMappingResponse DeleteDisasterRecoveryVpcMappingSync(DeleteDisasterRecoveryVpcMappingRequest req)
        {
            return InternalRequestAsync<DeleteDisasterRecoveryVpcMappingResponse>(req, "DeleteDisasterRecoveryVpcMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除演练对/演练组
        /// </summary>
        /// <param name="req"><see cref="DeleteDrillPairsRequest"/></param>
        /// <returns><see cref="DeleteDrillPairsResponse"/></returns>
        public Task<DeleteDrillPairsResponse> DeleteDrillPairs(DeleteDrillPairsRequest req)
        {
            return InternalRequestAsync<DeleteDrillPairsResponse>(req, "DeleteDrillPairs");
        }

        /// <summary>
        /// 删除演练对/演练组
        /// </summary>
        /// <param name="req"><see cref="DeleteDrillPairsRequest"/></param>
        /// <returns><see cref="DeleteDrillPairsResponse"/></returns>
        public DeleteDrillPairsResponse DeleteDrillPairsSync(DeleteDrillPairsRequest req)
        {
            return InternalRequestAsync<DeleteDrillPairsResponse>(req, "DeleteDrillPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份计划
        /// </summary>
        /// <param name="req"><see cref="DeleteFileBackupPlansRequest"/></param>
        /// <returns><see cref="DeleteFileBackupPlansResponse"/></returns>
        public Task<DeleteFileBackupPlansResponse> DeleteFileBackupPlans(DeleteFileBackupPlansRequest req)
        {
            return InternalRequestAsync<DeleteFileBackupPlansResponse>(req, "DeleteFileBackupPlans");
        }

        /// <summary>
        /// 删除备份计划
        /// </summary>
        /// <param name="req"><see cref="DeleteFileBackupPlansRequest"/></param>
        /// <returns><see cref="DeleteFileBackupPlansResponse"/></returns>
        public DeleteFileBackupPlansResponse DeleteFileBackupPlansSync(DeleteFileBackupPlansRequest req)
        {
            return InternalRequestAsync<DeleteFileBackupPlansResponse>(req, "DeleteFileBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文件备份点
        /// </summary>
        /// <param name="req"><see cref="DeleteFileBackupsRequest"/></param>
        /// <returns><see cref="DeleteFileBackupsResponse"/></returns>
        public Task<DeleteFileBackupsResponse> DeleteFileBackups(DeleteFileBackupsRequest req)
        {
            return InternalRequestAsync<DeleteFileBackupsResponse>(req, "DeleteFileBackups");
        }

        /// <summary>
        /// 删除文件备份点
        /// </summary>
        /// <param name="req"><see cref="DeleteFileBackupsRequest"/></param>
        /// <returns><see cref="DeleteFileBackupsResponse"/></returns>
        public DeleteFileBackupsResponse DeleteFileBackupsSync(DeleteFileBackupsRequest req)
        {
            return InternalRequestAsync<DeleteFileBackupsResponse>(req, "DeleteFileBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除站点对已添加的安全组映射
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupMappingRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupMappingResponse"/></returns>
        public Task<DeleteSecurityGroupMappingResponse> DeleteSecurityGroupMapping(DeleteSecurityGroupMappingRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupMappingResponse>(req, "DeleteSecurityGroupMapping");
        }

        /// <summary>
        /// 本接口用于删除站点对已添加的安全组映射
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupMappingRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupMappingResponse"/></returns>
        public DeleteSecurityGroupMappingResponse DeleteSecurityGroupMappingSync(DeleteSecurityGroupMappingRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupMappingResponse>(req, "DeleteSecurityGroupMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询定期备份策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupPoliciesResponse"/></returns>
        public Task<DescribeAutoBackupPoliciesResponse> DescribeAutoBackupPolicies(DescribeAutoBackupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupPoliciesResponse>(req, "DescribeAutoBackupPolicies");
        }

        /// <summary>
        /// 查询定期备份策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupPoliciesResponse"/></returns>
        public DescribeAutoBackupPoliciesResponse DescribeAutoBackupPoliciesSync(DescribeAutoBackupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupPoliciesResponse>(req, "DescribeAutoBackupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份组恢复任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupGroupRollbackTasksRequest"/></param>
        /// <returns><see cref="DescribeBackupGroupRollbackTasksResponse"/></returns>
        public Task<DescribeBackupGroupRollbackTasksResponse> DescribeBackupGroupRollbackTasks(DescribeBackupGroupRollbackTasksRequest req)
        {
            return InternalRequestAsync<DescribeBackupGroupRollbackTasksResponse>(req, "DescribeBackupGroupRollbackTasks");
        }

        /// <summary>
        /// 查询备份组恢复任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupGroupRollbackTasksRequest"/></param>
        /// <returns><see cref="DescribeBackupGroupRollbackTasksResponse"/></returns>
        public DescribeBackupGroupRollbackTasksResponse DescribeBackupGroupRollbackTasksSync(DescribeBackupGroupRollbackTasksRequest req)
        {
            return InternalRequestAsync<DescribeBackupGroupRollbackTasksResponse>(req, "DescribeBackupGroupRollbackTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupGroupsRequest"/></param>
        /// <returns><see cref="DescribeBackupGroupsResponse"/></returns>
        public Task<DescribeBackupGroupsResponse> DescribeBackupGroups(DescribeBackupGroupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupGroupsResponse>(req, "DescribeBackupGroups");
        }

        /// <summary>
        /// 查询备份组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupGroupsRequest"/></param>
        /// <returns><see cref="DescribeBackupGroupsResponse"/></returns>
        public DescribeBackupGroupsResponse DescribeBackupGroupsSync(DescribeBackupGroupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupGroupsResponse>(req, "DescribeBackupGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupGroupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeBackupGroupsDeniedActionsResponse"/></returns>
        public Task<DescribeBackupGroupsDeniedActionsResponse> DescribeBackupGroupsDeniedActions(DescribeBackupGroupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeBackupGroupsDeniedActionsResponse>(req, "DescribeBackupGroupsDeniedActions");
        }

        /// <summary>
        /// 查询操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupGroupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeBackupGroupsDeniedActionsResponse"/></returns>
        public DescribeBackupGroupsDeniedActionsResponse DescribeBackupGroupsDeniedActionsSync(DescribeBackupGroupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeBackupGroupsDeniedActionsResponse>(req, "DescribeBackupGroupsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来浏览已有受保护实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupInstancesRequest"/></param>
        /// <returns><see cref="DescribeBackupInstancesResponse"/></returns>
        public Task<DescribeBackupInstancesResponse> DescribeBackupInstances(DescribeBackupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBackupInstancesResponse>(req, "DescribeBackupInstances");
        }

        /// <summary>
        /// 本接口用来浏览已有受保护实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupInstancesRequest"/></param>
        /// <returns><see cref="DescribeBackupInstancesResponse"/></returns>
        public DescribeBackupInstancesResponse DescribeBackupInstancesSync(DescribeBackupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeBackupInstancesResponse>(req, "DescribeBackupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewGeneralRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewGeneralResponse"/></returns>
        public Task<DescribeBackupOverviewGeneralResponse> DescribeBackupOverviewGeneral(DescribeBackupOverviewGeneralRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewGeneralResponse>(req, "DescribeBackupOverviewGeneral");
        }

        /// <summary>
        /// 查询备份概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewGeneralRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewGeneralResponse"/></returns>
        public DescribeBackupOverviewGeneralResponse DescribeBackupOverviewGeneralSync(DescribeBackupOverviewGeneralRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewGeneralResponse>(req, "DescribeBackupOverviewGeneral")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询整机备份计划
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public Task<DescribeBackupPlansResponse> DescribeBackupPlans(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans");
        }

        /// <summary>
        /// 查询整机备份计划
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public DescribeBackupPlansResponse DescribeBackupPlansSync(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupVaultsRequest"/></param>
        /// <returns><see cref="DescribeBackupVaultsResponse"/></returns>
        public Task<DescribeBackupVaultsResponse> DescribeBackupVaults(DescribeBackupVaultsRequest req)
        {
            return InternalRequestAsync<DescribeBackupVaultsResponse>(req, "DescribeBackupVaults");
        }

        /// <summary>
        /// 查询备份库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupVaultsRequest"/></param>
        /// <returns><see cref="DescribeBackupVaultsResponse"/></returns>
        public DescribeBackupVaultsResponse DescribeBackupVaultsSync(DescribeBackupVaultsRequest req)
        {
            return InternalRequestAsync<DescribeBackupVaultsResponse>(req, "DescribeBackupVaults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份库操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupVaultsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeBackupVaultsDeniedActionsResponse"/></returns>
        public Task<DescribeBackupVaultsDeniedActionsResponse> DescribeBackupVaultsDeniedActions(DescribeBackupVaultsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeBackupVaultsDeniedActionsResponse>(req, "DescribeBackupVaultsDeniedActions");
        }

        /// <summary>
        /// 查询备份库操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupVaultsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeBackupVaultsDeniedActionsResponse"/></returns>
        public DescribeBackupVaultsDeniedActionsResponse DescribeBackupVaultsDeniedActionsSync(DescribeBackupVaultsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeBackupVaultsDeniedActionsResponse>(req, "DescribeBackupVaultsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询共同备份点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonBackupPointsRequest"/></param>
        /// <returns><see cref="DescribeCommonBackupPointsResponse"/></returns>
        public Task<DescribeCommonBackupPointsResponse> DescribeCommonBackupPoints(DescribeCommonBackupPointsRequest req)
        {
            return InternalRequestAsync<DescribeCommonBackupPointsResponse>(req, "DescribeCommonBackupPoints");
        }

        /// <summary>
        /// 查询共同备份点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonBackupPointsRequest"/></param>
        /// <returns><see cref="DescribeCommonBackupPointsResponse"/></returns>
        public DescribeCommonBackupPointsResponse DescribeCommonBackupPointsSync(DescribeCommonBackupPointsRequest req)
        {
            return InternalRequestAsync<DescribeCommonBackupPointsResponse>(req, "DescribeCommonBackupPoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询容灾复制对
        /// </summary>
        /// <param name="req"><see cref="DescribeCopyPairsRequest"/></param>
        /// <returns><see cref="DescribeCopyPairsResponse"/></returns>
        public Task<DescribeCopyPairsResponse> DescribeCopyPairs(DescribeCopyPairsRequest req)
        {
            return InternalRequestAsync<DescribeCopyPairsResponse>(req, "DescribeCopyPairs");
        }

        /// <summary>
        /// 本接口用来查询容灾复制对
        /// </summary>
        /// <param name="req"><see cref="DescribeCopyPairsRequest"/></param>
        /// <returns><see cref="DescribeCopyPairsResponse"/></returns>
        public DescribeCopyPairsResponse DescribeCopyPairsSync(DescribeCopyPairsRequest req)
        {
            return InternalRequestAsync<DescribeCopyPairsResponse>(req, "DescribeCopyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询复制对掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeCopyPairsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeCopyPairsDeniedActionsResponse"/></returns>
        public Task<DescribeCopyPairsDeniedActionsResponse> DescribeCopyPairsDeniedActions(DescribeCopyPairsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeCopyPairsDeniedActionsResponse>(req, "DescribeCopyPairsDeniedActions");
        }

        /// <summary>
        /// 查询复制对掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeCopyPairsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeCopyPairsDeniedActionsResponse"/></returns>
        public DescribeCopyPairsDeniedActionsResponse DescribeCopyPairsDeniedActionsSync(DescribeCopyPairsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeCopyPairsDeniedActionsResponse>(req, "DescribeCopyPairsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询容灾复制对
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoveryDrillGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoveryDrillGroupsResponse"/></returns>
        public Task<DescribeDisasterRecoveryDrillGroupsResponse> DescribeDisasterRecoveryDrillGroups(DescribeDisasterRecoveryDrillGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoveryDrillGroupsResponse>(req, "DescribeDisasterRecoveryDrillGroups");
        }

        /// <summary>
        /// 本接口用来查询容灾复制对
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoveryDrillGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoveryDrillGroupsResponse"/></returns>
        public DescribeDisasterRecoveryDrillGroupsResponse DescribeDisasterRecoveryDrillGroupsSync(DescribeDisasterRecoveryDrillGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoveryDrillGroupsResponse>(req, "DescribeDisasterRecoveryDrillGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容灾资源概览
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoveryOverviewRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoveryOverviewResponse"/></returns>
        public Task<DescribeDisasterRecoveryOverviewResponse> DescribeDisasterRecoveryOverview(DescribeDisasterRecoveryOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoveryOverviewResponse>(req, "DescribeDisasterRecoveryOverview");
        }

        /// <summary>
        /// 查询容灾资源概览
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoveryOverviewRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoveryOverviewResponse"/></returns>
        public DescribeDisasterRecoveryOverviewResponse DescribeDisasterRecoveryOverviewSync(DescribeDisasterRecoveryOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoveryOverviewResponse>(req, "DescribeDisasterRecoveryOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询容灾保护组
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoveryProtectGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoveryProtectGroupsResponse"/></returns>
        public Task<DescribeDisasterRecoveryProtectGroupsResponse> DescribeDisasterRecoveryProtectGroups(DescribeDisasterRecoveryProtectGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoveryProtectGroupsResponse>(req, "DescribeDisasterRecoveryProtectGroups");
        }

        /// <summary>
        /// 本接口用来查询容灾保护组
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoveryProtectGroupsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoveryProtectGroupsResponse"/></returns>
        public DescribeDisasterRecoveryProtectGroupsResponse DescribeDisasterRecoveryProtectGroupsSync(DescribeDisasterRecoveryProtectGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoveryProtectGroupsResponse>(req, "DescribeDisasterRecoveryProtectGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询容灾站点对
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverySitePairsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverySitePairsResponse"/></returns>
        public Task<DescribeDisasterRecoverySitePairsResponse> DescribeDisasterRecoverySitePairs(DescribeDisasterRecoverySitePairsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverySitePairsResponse>(req, "DescribeDisasterRecoverySitePairs");
        }

        /// <summary>
        /// 本接口用来查询容灾站点对
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverySitePairsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverySitePairsResponse"/></returns>
        public DescribeDisasterRecoverySitePairsResponse DescribeDisasterRecoverySitePairsSync(DescribeDisasterRecoverySitePairsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverySitePairsResponse>(req, "DescribeDisasterRecoverySitePairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定容灾站点对当前不允许执行的操作列表（操作掩码）。前端在展示容灾策略操作菜单时，可基于该接口返回结果灰化或屏蔽相应入口，并向用户提示原因（错误码 + 错误信息）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverySitePairsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverySitePairsDeniedActionsResponse"/></returns>
        public Task<DescribeDisasterRecoverySitePairsDeniedActionsResponse> DescribeDisasterRecoverySitePairsDeniedActions(DescribeDisasterRecoverySitePairsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverySitePairsDeniedActionsResponse>(req, "DescribeDisasterRecoverySitePairsDeniedActions");
        }

        /// <summary>
        /// 查询指定容灾站点对当前不允许执行的操作列表（操作掩码）。前端在展示容灾策略操作菜单时，可基于该接口返回结果灰化或屏蔽相应入口，并向用户提示原因（错误码 + 错误信息）。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverySitePairsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverySitePairsDeniedActionsResponse"/></returns>
        public DescribeDisasterRecoverySitePairsDeniedActionsResponse DescribeDisasterRecoverySitePairsDeniedActionsSync(DescribeDisasterRecoverySitePairsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverySitePairsDeniedActionsResponse>(req, "DescribeDisasterRecoverySitePairsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前地域支持容灾的生产地域配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverySupportRegionRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverySupportRegionResponse"/></returns>
        public Task<DescribeDisasterRecoverySupportRegionResponse> DescribeDisasterRecoverySupportRegion(DescribeDisasterRecoverySupportRegionRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverySupportRegionResponse>(req, "DescribeDisasterRecoverySupportRegion");
        }

        /// <summary>
        /// 查询当前地域支持容灾的生产地域配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDisasterRecoverySupportRegionRequest"/></param>
        /// <returns><see cref="DescribeDisasterRecoverySupportRegionResponse"/></returns>
        public DescribeDisasterRecoverySupportRegionResponse DescribeDisasterRecoverySupportRegionSync(DescribeDisasterRecoverySupportRegionRequest req)
        {
            return InternalRequestAsync<DescribeDisasterRecoverySupportRegionResponse>(req, "DescribeDisasterRecoverySupportRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询容灾云硬盘的详情，如系统盘的镜像格式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks");
        }

        /// <summary>
        /// 本接口用来查询容灾云硬盘的详情，如系统盘的镜像格式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public DescribeDisksResponse DescribeDisksSync(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询演练对列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrillPairsRequest"/></param>
        /// <returns><see cref="DescribeDrillPairsResponse"/></returns>
        public Task<DescribeDrillPairsResponse> DescribeDrillPairs(DescribeDrillPairsRequest req)
        {
            return InternalRequestAsync<DescribeDrillPairsResponse>(req, "DescribeDrillPairs");
        }

        /// <summary>
        /// 查询演练对列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDrillPairsRequest"/></param>
        /// <returns><see cref="DescribeDrillPairsResponse"/></returns>
        public DescribeDrillPairsResponse DescribeDrillPairsSync(DescribeDrillPairsRequest req)
        {
            return InternalRequestAsync<DescribeDrillPairsResponse>(req, "DescribeDrillPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询演练操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeDrillPairsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDrillPairsDeniedActionsResponse"/></returns>
        public Task<DescribeDrillPairsDeniedActionsResponse> DescribeDrillPairsDeniedActions(DescribeDrillPairsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDrillPairsDeniedActionsResponse>(req, "DescribeDrillPairsDeniedActions");
        }

        /// <summary>
        /// 查询演练操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeDrillPairsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeDrillPairsDeniedActionsResponse"/></returns>
        public DescribeDrillPairsDeniedActionsResponse DescribeDrillPairsDeniedActionsSync(DescribeDrillPairsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeDrillPairsDeniedActionsResponse>(req, "DescribeDrillPairsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来浏览已有备份目录/文件内容
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupObjectsRequest"/></param>
        /// <returns><see cref="DescribeFileBackupObjectsResponse"/></returns>
        public Task<DescribeFileBackupObjectsResponse> DescribeFileBackupObjects(DescribeFileBackupObjectsRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupObjectsResponse>(req, "DescribeFileBackupObjects");
        }

        /// <summary>
        /// 本接口用来浏览已有备份目录/文件内容
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupObjectsRequest"/></param>
        /// <returns><see cref="DescribeFileBackupObjectsResponse"/></returns>
        public DescribeFileBackupObjectsResponse DescribeFileBackupObjectsSync(DescribeFileBackupObjectsRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupObjectsResponse>(req, "DescribeFileBackupObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来浏览已有备份计划内容
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeFileBackupPlansResponse"/></returns>
        public Task<DescribeFileBackupPlansResponse> DescribeFileBackupPlans(DescribeFileBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupPlansResponse>(req, "DescribeFileBackupPlans");
        }

        /// <summary>
        /// 本接口用来浏览已有备份计划内容
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeFileBackupPlansResponse"/></returns>
        public DescribeFileBackupPlansResponse DescribeFileBackupPlansSync(DescribeFileBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupPlansResponse>(req, "DescribeFileBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来浏览已有备份点详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupsRequest"/></param>
        /// <returns><see cref="DescribeFileBackupsResponse"/></returns>
        public Task<DescribeFileBackupsResponse> DescribeFileBackups(DescribeFileBackupsRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupsResponse>(req, "DescribeFileBackups");
        }

        /// <summary>
        /// 本接口用来浏览已有备份点详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupsRequest"/></param>
        /// <returns><see cref="DescribeFileBackupsResponse"/></returns>
        public DescribeFileBackupsResponse DescribeFileBackupsSync(DescribeFileBackupsRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupsResponse>(req, "DescribeFileBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询备份操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeFileBackupsDeniedActionsResponse"/></returns>
        public Task<DescribeFileBackupsDeniedActionsResponse> DescribeFileBackupsDeniedActions(DescribeFileBackupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupsDeniedActionsResponse>(req, "DescribeFileBackupsDeniedActions");
        }

        /// <summary>
        /// 本接口用来查询备份操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeFileBackupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeFileBackupsDeniedActionsResponse"/></returns>
        public DescribeFileBackupsDeniedActionsResponse DescribeFileBackupsDeniedActionsSync(DescribeFileBackupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeFileBackupsDeniedActionsResponse>(req, "DescribeFileBackupsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份恢复任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileRestoreTasksRequest"/></param>
        /// <returns><see cref="DescribeFileRestoreTasksResponse"/></returns>
        public Task<DescribeFileRestoreTasksResponse> DescribeFileRestoreTasks(DescribeFileRestoreTasksRequest req)
        {
            return InternalRequestAsync<DescribeFileRestoreTasksResponse>(req, "DescribeFileRestoreTasks");
        }

        /// <summary>
        /// 查询备份恢复任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileRestoreTasksRequest"/></param>
        /// <returns><see cref="DescribeFileRestoreTasksResponse"/></returns>
        public DescribeFileRestoreTasksResponse DescribeFileRestoreTasksSync(DescribeFileRestoreTasksRequest req)
        {
            return InternalRequestAsync<DescribeFileRestoreTasksResponse>(req, "DescribeFileRestoreTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于Agent查询相关Agent任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs");
        }

        /// <summary>
        /// 本接口用于Agent查询相关Agent任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePriceCreateCopyPairs）用于查询创建容灾复制对的价格。支持批量询价，入参为每个复制对的盘容量数组，返回与入参一一对应的后付费每小时价格。
        /// </summary>
        /// <param name="req"><see cref="DescribePriceCreateCopyPairsRequest"/></param>
        /// <returns><see cref="DescribePriceCreateCopyPairsResponse"/></returns>
        public Task<DescribePriceCreateCopyPairsResponse> DescribePriceCreateCopyPairs(DescribePriceCreateCopyPairsRequest req)
        {
            return InternalRequestAsync<DescribePriceCreateCopyPairsResponse>(req, "DescribePriceCreateCopyPairs");
        }

        /// <summary>
        /// 本接口（DescribePriceCreateCopyPairs）用于查询创建容灾复制对的价格。支持批量询价，入参为每个复制对的盘容量数组，返回与入参一一对应的后付费每小时价格。
        /// </summary>
        /// <param name="req"><see cref="DescribePriceCreateCopyPairsRequest"/></param>
        /// <returns><see cref="DescribePriceCreateCopyPairsResponse"/></returns>
        public DescribePriceCreateCopyPairsResponse DescribePriceCreateCopyPairsSync(DescribePriceCreateCopyPairsRequest req)
        {
            return InternalRequestAsync<DescribePriceCreateCopyPairsResponse>(req, "DescribePriceCreateCopyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询保护组操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectGroupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeProtectGroupsDeniedActionsResponse"/></returns>
        public Task<DescribeProtectGroupsDeniedActionsResponse> DescribeProtectGroupsDeniedActions(DescribeProtectGroupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeProtectGroupsDeniedActionsResponse>(req, "DescribeProtectGroupsDeniedActions");
        }

        /// <summary>
        /// 查询保护组操作掩码
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectGroupsDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeProtectGroupsDeniedActionsResponse"/></returns>
        public DescribeProtectGroupsDeniedActionsResponse DescribeProtectGroupsDeniedActionsSync(DescribeProtectGroupsDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeProtectGroupsDeniedActionsResponse>(req, "DescribeProtectGroupsDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来浏览已有受保护实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedInstancesRequest"/></param>
        /// <returns><see cref="DescribeProtectedInstancesResponse"/></returns>
        public Task<DescribeProtectedInstancesResponse> DescribeProtectedInstances(DescribeProtectedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeProtectedInstancesResponse>(req, "DescribeProtectedInstances");
        }

        /// <summary>
        /// 本接口用来浏览已有受保护实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectedInstancesRequest"/></param>
        /// <returns><see cref="DescribeProtectedInstancesResponse"/></returns>
        public DescribeProtectedInstancesResponse DescribeProtectedInstancesSync(DescribeProtectedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeProtectedInstancesResponse>(req, "DescribeProtectedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询安全组映射列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupMappingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupMappingsResponse"/></returns>
        public Task<DescribeSecurityGroupMappingsResponse> DescribeSecurityGroupMappings(DescribeSecurityGroupMappingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupMappingsResponse>(req, "DescribeSecurityGroupMappings");
        }

        /// <summary>
        /// 本接口用于查询安全组映射列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupMappingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupMappingsResponse"/></returns>
        public DescribeSecurityGroupMappingsResponse DescribeSecurityGroupMappingsSync(DescribeSecurityGroupMappingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupMappingsResponse>(req, "DescribeSecurityGroupMappings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来查询站点对的vpc映射信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcMappingsRequest"/></param>
        /// <returns><see cref="DescribeVpcMappingsResponse"/></returns>
        public Task<DescribeVpcMappingsResponse> DescribeVpcMappings(DescribeVpcMappingsRequest req)
        {
            return InternalRequestAsync<DescribeVpcMappingsResponse>(req, "DescribeVpcMappings");
        }

        /// <summary>
        /// 本接口用来查询站点对的vpc映射信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcMappingsRequest"/></param>
        /// <returns><see cref="DescribeVpcMappingsResponse"/></returns>
        public DescribeVpcMappingsResponse DescribeVpcMappingsSync(DescribeVpcMappingsRequest req)
        {
            return InternalRequestAsync<DescribeVpcMappingsResponse>(req, "DescribeVpcMappings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完成切换
        /// </summary>
        /// <param name="req"><see cref="FinishFailoverCopyPairsRequest"/></param>
        /// <returns><see cref="FinishFailoverCopyPairsResponse"/></returns>
        public Task<FinishFailoverCopyPairsResponse> FinishFailoverCopyPairs(FinishFailoverCopyPairsRequest req)
        {
            return InternalRequestAsync<FinishFailoverCopyPairsResponse>(req, "FinishFailoverCopyPairs");
        }

        /// <summary>
        /// 完成切换
        /// </summary>
        /// <param name="req"><see cref="FinishFailoverCopyPairsRequest"/></param>
        /// <returns><see cref="FinishFailoverCopyPairsResponse"/></returns>
        public FinishFailoverCopyPairsResponse FinishFailoverCopyPairsSync(FinishFailoverCopyPairsRequest req)
        {
            return InternalRequestAsync<FinishFailoverCopyPairsResponse>(req, "FinishFailoverCopyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupPolicyAttributeRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupPolicyAttributeResponse"/></returns>
        public Task<ModifyAutoBackupPolicyAttributeResponse> ModifyAutoBackupPolicyAttribute(ModifyAutoBackupPolicyAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupPolicyAttributeResponse>(req, "ModifyAutoBackupPolicyAttribute");
        }

        /// <summary>
        /// 修改备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupPolicyAttributeRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupPolicyAttributeResponse"/></returns>
        public ModifyAutoBackupPolicyAttributeResponse ModifyAutoBackupPolicyAttributeSync(ModifyAutoBackupPolicyAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupPolicyAttributeResponse>(req, "ModifyAutoBackupPolicyAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份组
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupAttributeRequest"/></param>
        /// <returns><see cref="ModifyBackupAttributeResponse"/></returns>
        public Task<ModifyBackupAttributeResponse> ModifyBackupAttribute(ModifyBackupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBackupAttributeResponse>(req, "ModifyBackupAttribute");
        }

        /// <summary>
        /// 删除备份组
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupAttributeRequest"/></param>
        /// <returns><see cref="ModifyBackupAttributeResponse"/></returns>
        public ModifyBackupAttributeResponse ModifyBackupAttributeSync(ModifyBackupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBackupAttributeResponse>(req, "ModifyBackupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改备份库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupVaultAttributeRequest"/></param>
        /// <returns><see cref="ModifyBackupVaultAttributeResponse"/></returns>
        public Task<ModifyBackupVaultAttributeResponse> ModifyBackupVaultAttribute(ModifyBackupVaultAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBackupVaultAttributeResponse>(req, "ModifyBackupVaultAttribute");
        }

        /// <summary>
        /// 修改备份库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupVaultAttributeRequest"/></param>
        /// <returns><see cref="ModifyBackupVaultAttributeResponse"/></returns>
        public ModifyBackupVaultAttributeResponse ModifyBackupVaultAttributeSync(ModifyBackupVaultAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBackupVaultAttributeResponse>(req, "ModifyBackupVaultAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容灾复制对
        /// </summary>
        /// <param name="req"><see cref="ModifyCopyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyCopyPairAttributeResponse"/></returns>
        public Task<ModifyCopyPairAttributeResponse> ModifyCopyPairAttribute(ModifyCopyPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCopyPairAttributeResponse>(req, "ModifyCopyPairAttribute");
        }

        /// <summary>
        /// 修改容灾复制对
        /// </summary>
        /// <param name="req"><see cref="ModifyCopyPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyCopyPairAttributeResponse"/></returns>
        public ModifyCopyPairAttributeResponse ModifyCopyPairAttributeSync(ModifyCopyPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCopyPairAttributeResponse>(req, "ModifyCopyPairAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改演练组
        /// </summary>
        /// <param name="req"><see cref="ModifyDrillGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyDrillGroupAttributeResponse"/></returns>
        public Task<ModifyDrillGroupAttributeResponse> ModifyDrillGroupAttribute(ModifyDrillGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDrillGroupAttributeResponse>(req, "ModifyDrillGroupAttribute");
        }

        /// <summary>
        /// 修改演练组
        /// </summary>
        /// <param name="req"><see cref="ModifyDrillGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyDrillGroupAttributeResponse"/></returns>
        public ModifyDrillGroupAttributeResponse ModifyDrillGroupAttributeSync(ModifyDrillGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDrillGroupAttributeResponse>(req, "ModifyDrillGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改演练
        /// </summary>
        /// <param name="req"><see cref="ModifyDrillPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyDrillPairAttributeResponse"/></returns>
        public Task<ModifyDrillPairAttributeResponse> ModifyDrillPairAttribute(ModifyDrillPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDrillPairAttributeResponse>(req, "ModifyDrillPairAttribute");
        }

        /// <summary>
        /// 修改演练
        /// </summary>
        /// <param name="req"><see cref="ModifyDrillPairAttributeRequest"/></param>
        /// <returns><see cref="ModifyDrillPairAttributeResponse"/></returns>
        public ModifyDrillPairAttributeResponse ModifyDrillPairAttributeSync(ModifyDrillPairAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDrillPairAttributeResponse>(req, "ModifyDrillPairAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改文件备份信息
        /// </summary>
        /// <param name="req"><see cref="ModifyFileBackupAttributeRequest"/></param>
        /// <returns><see cref="ModifyFileBackupAttributeResponse"/></returns>
        public Task<ModifyFileBackupAttributeResponse> ModifyFileBackupAttribute(ModifyFileBackupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyFileBackupAttributeResponse>(req, "ModifyFileBackupAttribute");
        }

        /// <summary>
        /// 修改文件备份信息
        /// </summary>
        /// <param name="req"><see cref="ModifyFileBackupAttributeRequest"/></param>
        /// <returns><see cref="ModifyFileBackupAttributeResponse"/></returns>
        public ModifyFileBackupAttributeResponse ModifyFileBackupAttributeSync(ModifyFileBackupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyFileBackupAttributeResponse>(req, "ModifyFileBackupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改已有的备份计划配置
        /// </summary>
        /// <param name="req"><see cref="ModifyFileBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyFileBackupPlanResponse"/></returns>
        public Task<ModifyFileBackupPlanResponse> ModifyFileBackupPlan(ModifyFileBackupPlanRequest req)
        {
            return InternalRequestAsync<ModifyFileBackupPlanResponse>(req, "ModifyFileBackupPlan");
        }

        /// <summary>
        /// 本接口用于修改已有的备份计划配置
        /// </summary>
        /// <param name="req"><see cref="ModifyFileBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyFileBackupPlanResponse"/></returns>
        public ModifyFileBackupPlanResponse ModifyFileBackupPlanSync(ModifyFileBackupPlanRequest req)
        {
            return InternalRequestAsync<ModifyFileBackupPlanResponse>(req, "ModifyFileBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容灾保护组
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProtectGroupAttributeResponse"/></returns>
        public Task<ModifyProtectGroupAttributeResponse> ModifyProtectGroupAttribute(ModifyProtectGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProtectGroupAttributeResponse>(req, "ModifyProtectGroupAttribute");
        }

        /// <summary>
        /// 修改容灾保护组
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProtectGroupAttributeResponse"/></returns>
        public ModifyProtectGroupAttributeResponse ModifyProtectGroupAttributeSync(ModifyProtectGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProtectGroupAttributeResponse>(req, "ModifyProtectGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容灾站点对
        /// </summary>
        /// <param name="req"><see cref="ModifySitePairAttributeRequest"/></param>
        /// <returns><see cref="ModifySitePairAttributeResponse"/></returns>
        public Task<ModifySitePairAttributeResponse> ModifySitePairAttribute(ModifySitePairAttributeRequest req)
        {
            return InternalRequestAsync<ModifySitePairAttributeResponse>(req, "ModifySitePairAttribute");
        }

        /// <summary>
        /// 修改容灾站点对
        /// </summary>
        /// <param name="req"><see cref="ModifySitePairAttributeRequest"/></param>
        /// <returns><see cref="ModifySitePairAttributeResponse"/></returns>
        public ModifySitePairAttributeResponse ModifySitePairAttributeSync(ModifySitePairAttributeRequest req)
        {
            return InternalRequestAsync<ModifySitePairAttributeResponse>(req, "ModifySitePairAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于上报Agent指标信息
        /// </summary>
        /// <param name="req"><see cref="ReportAgentMetricsRequest"/></param>
        /// <returns><see cref="ReportAgentMetricsResponse"/></returns>
        public Task<ReportAgentMetricsResponse> ReportAgentMetrics(ReportAgentMetricsRequest req)
        {
            return InternalRequestAsync<ReportAgentMetricsResponse>(req, "ReportAgentMetrics");
        }

        /// <summary>
        /// 本接口用于上报Agent指标信息
        /// </summary>
        /// <param name="req"><see cref="ReportAgentMetricsRequest"/></param>
        /// <returns><see cref="ReportAgentMetricsResponse"/></returns>
        public ReportAgentMetricsResponse ReportAgentMetricsSync(ReportAgentMetricsRequest req)
        {
            return InternalRequestAsync<ReportAgentMetricsResponse>(req, "ReportAgentMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于Agent心跳上报
        /// </summary>
        /// <param name="req"><see cref="ReportGatewayHeartbeatRequest"/></param>
        /// <returns><see cref="ReportGatewayHeartbeatResponse"/></returns>
        public Task<ReportGatewayHeartbeatResponse> ReportGatewayHeartbeat(ReportGatewayHeartbeatRequest req)
        {
            return InternalRequestAsync<ReportGatewayHeartbeatResponse>(req, "ReportGatewayHeartbeat");
        }

        /// <summary>
        /// 本接口用于Agent心跳上报
        /// </summary>
        /// <param name="req"><see cref="ReportGatewayHeartbeatRequest"/></param>
        /// <returns><see cref="ReportGatewayHeartbeatResponse"/></returns>
        public ReportGatewayHeartbeatResponse ReportGatewayHeartbeatSync(ReportGatewayHeartbeatRequest req)
        {
            return InternalRequestAsync<ReportGatewayHeartbeatResponse>(req, "ReportGatewayHeartbeat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于上报Agent任务信息
        /// </summary>
        /// <param name="req"><see cref="ReportJobProgressRequest"/></param>
        /// <returns><see cref="ReportJobProgressResponse"/></returns>
        public Task<ReportJobProgressResponse> ReportJobProgress(ReportJobProgressRequest req)
        {
            return InternalRequestAsync<ReportJobProgressResponse>(req, "ReportJobProgress");
        }

        /// <summary>
        /// 本接口用于上报Agent任务信息
        /// </summary>
        /// <param name="req"><see cref="ReportJobProgressRequest"/></param>
        /// <returns><see cref="ReportJobProgressResponse"/></returns>
        public ReportJobProgressResponse ReportJobProgressSync(ReportJobProgressRequest req)
        {
            return InternalRequestAsync<ReportJobProgressResponse>(req, "ReportJobProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动复制对
        /// </summary>
        /// <param name="req"><see cref="RunCopyPairTasksRequest"/></param>
        /// <returns><see cref="RunCopyPairTasksResponse"/></returns>
        public Task<RunCopyPairTasksResponse> RunCopyPairTasks(RunCopyPairTasksRequest req)
        {
            return InternalRequestAsync<RunCopyPairTasksResponse>(req, "RunCopyPairTasks");
        }

        /// <summary>
        /// 启动复制对
        /// </summary>
        /// <param name="req"><see cref="RunCopyPairTasksRequest"/></param>
        /// <returns><see cref="RunCopyPairTasksResponse"/></returns>
        public RunCopyPairTasksResponse RunCopyPairTasksSync(RunCopyPairTasksRequest req)
        {
            return InternalRequestAsync<RunCopyPairTasksResponse>(req, "RunCopyPairTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 故障切换
        /// </summary>
        /// <param name="req"><see cref="RunFailoverCopyPairsRequest"/></param>
        /// <returns><see cref="RunFailoverCopyPairsResponse"/></returns>
        public Task<RunFailoverCopyPairsResponse> RunFailoverCopyPairs(RunFailoverCopyPairsRequest req)
        {
            return InternalRequestAsync<RunFailoverCopyPairsResponse>(req, "RunFailoverCopyPairs");
        }

        /// <summary>
        /// 故障切换
        /// </summary>
        /// <param name="req"><see cref="RunFailoverCopyPairsRequest"/></param>
        /// <returns><see cref="RunFailoverCopyPairsResponse"/></returns>
        public RunFailoverCopyPairsResponse RunFailoverCopyPairsSync(RunFailoverCopyPairsRequest req)
        {
            return InternalRequestAsync<RunFailoverCopyPairsResponse>(req, "RunFailoverCopyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 备份组新建云服务器
        /// </summary>
        /// <param name="req"><see cref="RunInstancesWithBackupGroupRequest"/></param>
        /// <returns><see cref="RunInstancesWithBackupGroupResponse"/></returns>
        public Task<RunInstancesWithBackupGroupResponse> RunInstancesWithBackupGroup(RunInstancesWithBackupGroupRequest req)
        {
            return InternalRequestAsync<RunInstancesWithBackupGroupResponse>(req, "RunInstancesWithBackupGroup");
        }

        /// <summary>
        /// 备份组新建云服务器
        /// </summary>
        /// <param name="req"><see cref="RunInstancesWithBackupGroupRequest"/></param>
        /// <returns><see cref="RunInstancesWithBackupGroupResponse"/></returns>
        public RunInstancesWithBackupGroupResponse RunInstancesWithBackupGroupSync(RunInstancesWithBackupGroupRequest req)
        {
            return InternalRequestAsync<RunInstancesWithBackupGroupResponse>(req, "RunInstancesWithBackupGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止复制对
        /// </summary>
        /// <param name="req"><see cref="StopCopyPairTasksRequest"/></param>
        /// <returns><see cref="StopCopyPairTasksResponse"/></returns>
        public Task<StopCopyPairTasksResponse> StopCopyPairTasks(StopCopyPairTasksRequest req)
        {
            return InternalRequestAsync<StopCopyPairTasksResponse>(req, "StopCopyPairTasks");
        }

        /// <summary>
        /// 停止复制对
        /// </summary>
        /// <param name="req"><see cref="StopCopyPairTasksRequest"/></param>
        /// <returns><see cref="StopCopyPairTasksResponse"/></returns>
        public StopCopyPairTasksResponse StopCopyPairTasksSync(StopCopyPairTasksRequest req)
        {
            return InternalRequestAsync<StopCopyPairTasksResponse>(req, "StopCopyPairTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将实例从备份策略上解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoBackupPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoBackupPolicyResponse"/></returns>
        public Task<UnbindAutoBackupPolicyResponse> UnbindAutoBackupPolicy(UnbindAutoBackupPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoBackupPolicyResponse>(req, "UnbindAutoBackupPolicy");
        }

        /// <summary>
        /// 将实例从备份策略上解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoBackupPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoBackupPolicyResponse"/></returns>
        public UnbindAutoBackupPolicyResponse UnbindAutoBackupPolicySync(UnbindAutoBackupPolicyRequest req)
        {
            return InternalRequestAsync<UnbindAutoBackupPolicyResponse>(req, "UnbindAutoBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
