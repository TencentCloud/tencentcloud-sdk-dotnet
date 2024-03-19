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

namespace TencentCloud.Redis.V20180412
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Redis.V20180412.Models;

   public class RedisClient : AbstractClient{

       private const string endpoint = "redis.tencentcloudapi.com";
       private const string version = "2018-04-12";
       private const string sdkVersion = "SDK_NET_3.0.968";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RedisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RedisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加复制组成员
        /// </summary>
        /// <param name="req"><see cref="AddReplicationInstanceRequest"/></param>
        /// <returns><see cref="AddReplicationInstanceResponse"/></returns>
        public Task<AddReplicationInstanceResponse> AddReplicationInstance(AddReplicationInstanceRequest req)
        {
            return InternalRequestAsync<AddReplicationInstanceResponse>(req, "AddReplicationInstance");
        }

        /// <summary>
        /// 添加复制组成员
        /// </summary>
        /// <param name="req"><see cref="AddReplicationInstanceRequest"/></param>
        /// <returns><see cref="AddReplicationInstanceResponse"/></returns>
        public AddReplicationInstanceResponse AddReplicationInstanceSync(AddReplicationInstanceRequest req)
        {
            return InternalRequestAsync<AddReplicationInstanceResponse>(req, "AddReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通外网
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public Task<AllocateWanAddressResponse> AllocateWanAddress(AllocateWanAddressRequest req)
        {
            return InternalRequestAsync<AllocateWanAddressResponse>(req, "AllocateWanAddress");
        }

        /// <summary>
        /// 开通外网
        /// </summary>
        /// <param name="req"><see cref="AllocateWanAddressRequest"/></param>
        /// <returns><see cref="AllocateWanAddressResponse"/></returns>
        public AllocateWanAddressResponse AllocateWanAddressSync(AllocateWanAddressRequest req)
        {
            return InternalRequestAsync<AllocateWanAddressResponse>(req, "AllocateWanAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用参数模板到实例
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public Task<ApplyParamsTemplateResponse> ApplyParamsTemplate(ApplyParamsTemplateRequest req)
        {
            return InternalRequestAsync<ApplyParamsTemplateResponse>(req, "ApplyParamsTemplate");
        }

        /// <summary>
        /// 应用参数模板到实例
        /// </summary>
        /// <param name="req"><see cref="ApplyParamsTemplateRequest"/></param>
        /// <returns><see cref="ApplyParamsTemplateResponse"/></returns>
        public ApplyParamsTemplateResponse ApplyParamsTemplateSync(ApplyParamsTemplateRequest req)
        {
            return InternalRequestAsync<ApplyParamsTemplateResponse>(req, "ApplyParamsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定多个指定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定多个指定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制组实例更换角色
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public Task<ChangeInstanceRoleResponse> ChangeInstanceRole(ChangeInstanceRoleRequest req)
        {
            return InternalRequestAsync<ChangeInstanceRoleResponse>(req, "ChangeInstanceRole");
        }

        /// <summary>
        /// 复制组实例更换角色
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceRoleRequest"/></param>
        /// <returns><see cref="ChangeInstanceRoleResponse"/></returns>
        public ChangeInstanceRoleResponse ChangeInstanceRoleSync(ChangeInstanceRoleRequest req)
        {
            return InternalRequestAsync<ChangeInstanceRoleResponse>(req, "ChangeInstanceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（ChangeMasterInstance）用于将复制组内只读实例设置为主实例。
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public Task<ChangeMasterInstanceResponse> ChangeMasterInstance(ChangeMasterInstanceRequest req)
        {
            return InternalRequestAsync<ChangeMasterInstanceResponse>(req, "ChangeMasterInstance");
        }

        /// <summary>
        /// 该接口（ChangeMasterInstance）用于将复制组内只读实例设置为主实例。
        /// </summary>
        /// <param name="req"><see cref="ChangeMasterInstanceRequest"/></param>
        /// <returns><see cref="ChangeMasterInstanceResponse"/></returns>
        public ChangeMasterInstanceResponse ChangeMasterInstanceSync(ChangeMasterInstanceRequest req)
        {
            return InternalRequestAsync<ChangeMasterInstanceResponse>(req, "ChangeMasterInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ChangeReplicaToMaster）适用于实例副本组提主或副本提主。
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public Task<ChangeReplicaToMasterResponse> ChangeReplicaToMaster(ChangeReplicaToMasterRequest req)
        {
            return InternalRequestAsync<ChangeReplicaToMasterResponse>(req, "ChangeReplicaToMaster");
        }

        /// <summary>
        /// 本接口（ChangeReplicaToMaster）适用于实例副本组提主或副本提主。
        /// </summary>
        /// <param name="req"><see cref="ChangeReplicaToMasterRequest"/></param>
        /// <returns><see cref="ChangeReplicaToMasterResponse"/></returns>
        public ChangeReplicaToMasterResponse ChangeReplicaToMasterSync(ChangeReplicaToMasterRequest req)
        {
            return InternalRequestAsync<ChangeReplicaToMasterResponse>(req, "ChangeReplicaToMaster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回收站实例立即下线
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public Task<CleanUpInstanceResponse> CleanUpInstance(CleanUpInstanceRequest req)
        {
            return InternalRequestAsync<CleanUpInstanceResponse>(req, "CleanUpInstance");
        }

        /// <summary>
        /// 回收站实例立即下线
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public CleanUpInstanceResponse CleanUpInstanceSync(CleanUpInstanceRequest req)
        {
            return InternalRequestAsync<CleanUpInstanceResponse>(req, "CleanUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 清空Redis实例的实例数据。
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public Task<ClearInstanceResponse> ClearInstance(ClearInstanceRequest req)
        {
            return InternalRequestAsync<ClearInstanceResponse>(req, "ClearInstance");
        }

        /// <summary>
        /// 清空Redis实例的实例数据。
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public ClearInstanceResponse ClearInstanceSync(ClearInstanceRequest req)
        {
            return InternalRequestAsync<ClearInstanceResponse>(req, "ClearInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloneInstances）用于基于当前实例的备份文件克隆一个完整的新实例。
        /// </summary>
        /// <param name="req"><see cref="CloneInstancesRequest"/></param>
        /// <returns><see cref="CloneInstancesResponse"/></returns>
        public Task<CloneInstancesResponse> CloneInstances(CloneInstancesRequest req)
        {
            return InternalRequestAsync<CloneInstancesResponse>(req, "CloneInstances");
        }

        /// <summary>
        /// 本接口（CloneInstances）用于基于当前实例的备份文件克隆一个完整的新实例。
        /// </summary>
        /// <param name="req"><see cref="CloneInstancesRequest"/></param>
        /// <returns><see cref="CloneInstancesResponse"/></returns>
        public CloneInstancesResponse CloneInstancesSync(CloneInstancesRequest req)
        {
            return InternalRequestAsync<CloneInstancesResponse>(req, "CloneInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭SSL
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public Task<CloseSSLResponse> CloseSSL(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL");
        }

        /// <summary>
        /// 关闭SSL
        /// </summary>
        /// <param name="req"><see cref="CloseSSLRequest"/></param>
        /// <returns><see cref="CloseSSLResponse"/></returns>
        public CloseSSLResponse CloseSSLSync(CloseSSLRequest req)
        {
            return InternalRequestAsync<CloseSSLResponse>(req, "CloseSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateInstanceAccount）用于自定义访问实例的账号。
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public Task<CreateInstanceAccountResponse> CreateInstanceAccount(CreateInstanceAccountRequest req)
        {
            return InternalRequestAsync<CreateInstanceAccountResponse>(req, "CreateInstanceAccount");
        }

        /// <summary>
        /// 该接口（CreateInstanceAccount）用于自定义访问实例的账号。
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public CreateInstanceAccountResponse CreateInstanceAccountSync(CreateInstanceAccountRequest req)
        {
            return InternalRequestAsync<CreateInstanceAccountResponse>(req, "CreateInstanceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateInstances）用于创建 Redis 实例。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// 本接口（CreateInstances）用于创建 Redis 实例。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate");
        }

        /// <summary>
        /// 创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
            return InternalRequestAsync<CreateParamTemplateResponse>(req, "CreateParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateReplicationGroup）用于创建复制组。
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationGroupRequest"/></param>
        /// <returns><see cref="CreateReplicationGroupResponse"/></returns>
        public Task<CreateReplicationGroupResponse> CreateReplicationGroup(CreateReplicationGroupRequest req)
        {
            return InternalRequestAsync<CreateReplicationGroupResponse>(req, "CreateReplicationGroup");
        }

        /// <summary>
        /// 该接口（CreateReplicationGroup）用于创建复制组。
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationGroupRequest"/></param>
        /// <returns><see cref="CreateReplicationGroupResponse"/></returns>
        public CreateReplicationGroupResponse CreateReplicationGroupSync(CreateReplicationGroupRequest req)
        {
            return InternalRequestAsync<CreateReplicationGroupResponse>(req, "CreateReplicationGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例子账号
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public Task<DeleteInstanceAccountResponse> DeleteInstanceAccount(DeleteInstanceAccountRequest req)
        {
            return InternalRequestAsync<DeleteInstanceAccountResponse>(req, "DeleteInstanceAccount");
        }

        /// <summary>
        /// 删除实例子账号
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public DeleteInstanceAccountResponse DeleteInstanceAccountSync(DeleteInstanceAccountRequest req)
        {
            return InternalRequestAsync<DeleteInstanceAccountResponse>(req, "DeleteInstanceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除参数模板
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate");
        }

        /// <summary>
        /// 删除参数模板
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParamTemplateResponse>(req, "DeleteParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移除复制组成员 注：接口下线中，请使用 RemoveReplicationInstance
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public Task<DeleteReplicationInstanceResponse> DeleteReplicationInstance(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance");
        }

        /// <summary>
        /// 移除复制组成员 注：接口下线中，请使用 RemoveReplicationInstance
        /// </summary>
        /// <param name="req"><see cref="DeleteReplicationInstanceRequest"/></param>
        /// <returns><see cref="DeleteReplicationInstanceResponse"/></returns>
        public DeleteReplicationInstanceResponse DeleteReplicationInstanceSync(DeleteReplicationInstanceRequest req)
        {
            return InternalRequestAsync<DeleteReplicationInstanceResponse>(req, "DeleteReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAutoBackupConfig）用于获取自动备份配置规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public Task<DescribeAutoBackupConfigResponse> DescribeAutoBackupConfig(DescribeAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupConfigResponse>(req, "DescribeAutoBackupConfig");
        }

        /// <summary>
        /// 本接口（DescribeAutoBackupConfig）用于获取自动备份配置规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public DescribeAutoBackupConfigResponse DescribeAutoBackupConfigSync(DescribeAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupConfigResponse>(req, "DescribeAutoBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadRestriction）用于查询当前地域数据库备份文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction");
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadRestriction）用于查询当前地域数据库备份文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupUrl）用于查询备份 Rdb 文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public Task<DescribeBackupUrlResponse> DescribeBackupUrl(DescribeBackupUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupUrlResponse>(req, "DescribeBackupUrl");
        }

        /// <summary>
        /// 本接口（DescribeBackupUrl）用于查询备份 Rdb 文件的下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public DescribeBackupUrlResponse DescribeBackupUrlSync(DescribeBackupUrlRequest req)
        {
            return InternalRequestAsync<DescribeBackupUrlResponse>(req, "DescribeBackupUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBandwidthRange）用于查询实例带宽信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthRangeRequest"/></param>
        /// <returns><see cref="DescribeBandwidthRangeResponse"/></returns>
        public Task<DescribeBandwidthRangeResponse> DescribeBandwidthRange(DescribeBandwidthRangeRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthRangeResponse>(req, "DescribeBandwidthRange");
        }

        /// <summary>
        /// 本接口（DescribeBandwidthRange）用于查询实例带宽信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthRangeRequest"/></param>
        /// <returns><see cref="DescribeBandwidthRangeResponse"/></returns>
        public DescribeBandwidthRangeResponse DescribeBandwidthRangeSync(DescribeBandwidthRangeRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthRangeResponse>(req, "DescribeBandwidthRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Redis实例列表信息。该接口已废弃。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public Task<DescribeCommonDBInstancesResponse> DescribeCommonDBInstances(DescribeCommonDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCommonDBInstancesResponse>(req, "DescribeCommonDBInstances");
        }

        /// <summary>
        /// 查询Redis实例列表信息。该接口已废弃。
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeCommonDBInstancesResponse"/></returns>
        public DescribeCommonDBInstancesResponse DescribeCommonDBInstancesSync(DescribeCommonDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCommonDBInstancesResponse>(req, "DescribeCommonDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBSecurityGroups）用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// 本接口（DescribeDBSecurityGroups）用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceAccount）用于查看实例子账号信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public Task<DescribeInstanceAccountResponse> DescribeInstanceAccount(DescribeInstanceAccountRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAccountResponse>(req, "DescribeInstanceAccount");
        }

        /// <summary>
        /// 本接口（DescribeInstanceAccount）用于查看实例子账号信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public DescribeInstanceAccountResponse DescribeInstanceAccountSync(DescribeInstanceAccountRequest req)
        {
            return InternalRequestAsync<DescribeInstanceAccountResponse>(req, "DescribeInstanceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceBackups）用于查询实例备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public Task<DescribeInstanceBackupsResponse> DescribeInstanceBackups(DescribeInstanceBackupsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBackupsResponse>(req, "DescribeInstanceBackups");
        }

        /// <summary>
        /// 本接口（DescribeInstanceBackups）用于查询实例备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public DescribeInstanceBackupsResponse DescribeInstanceBackupsSync(DescribeInstanceBackupsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBackupsResponse>(req, "DescribeInstanceBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例DTS信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public Task<DescribeInstanceDTSInfoResponse> DescribeInstanceDTSInfo(DescribeInstanceDTSInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDTSInfoResponse>(req, "DescribeInstanceDTSInfo");
        }

        /// <summary>
        /// 查询实例DTS信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public DescribeInstanceDTSInfoResponse DescribeInstanceDTSInfoSync(DescribeInstanceDTSInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDTSInfoResponse>(req, "DescribeInstanceDTSInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceDealDetail）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public Task<DescribeInstanceDealDetailResponse> DescribeInstanceDealDetail(DescribeInstanceDealDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDealDetailResponse>(req, "DescribeInstanceDealDetail");
        }

        /// <summary>
        /// 本接口（DescribeInstanceDealDetail）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public DescribeInstanceDealDetailResponse DescribeInstanceDealDetailSync(DescribeInstanceDealDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDealDetailResponse>(req, "DescribeInstanceDealDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见[查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public Task<DescribeInstanceMonitorBigKeyResponse> DescribeInstanceMonitorBigKey(DescribeInstanceMonitorBigKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyResponse>(req, "DescribeInstanceMonitorBigKey");
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见[查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public DescribeInstanceMonitorBigKeyResponse DescribeInstanceMonitorBigKeySync(DescribeInstanceMonitorBigKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyResponse>(req, "DescribeInstanceMonitorBigKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public Task<DescribeInstanceMonitorBigKeySizeDistResponse> DescribeInstanceMonitorBigKeySizeDist(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeySizeDistResponse>(req, "DescribeInstanceMonitorBigKeySizeDist");
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeySizeDistResponse DescribeInstanceMonitorBigKeySizeDistSync(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeySizeDistResponse>(req, "DescribeInstanceMonitorBigKeySizeDist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public Task<DescribeInstanceMonitorBigKeyTypeDistResponse> DescribeInstanceMonitorBigKeyTypeDist(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyTypeDistResponse>(req, "DescribeInstanceMonitorBigKeyTypeDist");
        }

        /// <summary>
        /// 腾讯云数据库 Redis 已经于2022年10月31日下线查询实例大 Key 接口。具体公告，请参见 [查询实例大 Key 接口下线公告](https://cloud.tencent.com/document/product/239/81005)。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeyTypeDistResponse DescribeInstanceMonitorBigKeyTypeDistSync(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorBigKeyTypeDistResponse>(req, "DescribeInstanceMonitorBigKeyTypeDist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例热Key
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public Task<DescribeInstanceMonitorHotKeyResponse> DescribeInstanceMonitorHotKey(DescribeInstanceMonitorHotKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorHotKeyResponse>(req, "DescribeInstanceMonitorHotKey");
        }

        /// <summary>
        /// 查询实例热Key
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public DescribeInstanceMonitorHotKeyResponse DescribeInstanceMonitorHotKeySync(DescribeInstanceMonitorHotKeyRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorHotKeyResponse>(req, "DescribeInstanceMonitorHotKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口已下线，请使用数据库智能管家 DBbrain 接口 [DescribeProxyProcessStatistics] (https://cloud.tencent.com/document/product/1130/84544) 获取实例访问来源。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public Task<DescribeInstanceMonitorSIPResponse> DescribeInstanceMonitorSIP(DescribeInstanceMonitorSIPRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorSIPResponse>(req, "DescribeInstanceMonitorSIP");
        }

        /// <summary>
        /// 该接口已下线，请使用数据库智能管家 DBbrain 接口 [DescribeProxyProcessStatistics] (https://cloud.tencent.com/document/product/1130/84544) 获取实例访问来源。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public DescribeInstanceMonitorSIPResponse DescribeInstanceMonitorSIPSync(DescribeInstanceMonitorSIPRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorSIPResponse>(req, "DescribeInstanceMonitorSIP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例访问的耗时分布
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public Task<DescribeInstanceMonitorTookDistResponse> DescribeInstanceMonitorTookDist(DescribeInstanceMonitorTookDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTookDistResponse>(req, "DescribeInstanceMonitorTookDist");
        }

        /// <summary>
        /// 查询实例访问的耗时分布
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public DescribeInstanceMonitorTookDistResponse DescribeInstanceMonitorTookDistSync(DescribeInstanceMonitorTookDistRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTookDistResponse>(req, "DescribeInstanceMonitorTookDist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例访问命令
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public Task<DescribeInstanceMonitorTopNCmdResponse> DescribeInstanceMonitorTopNCmd(DescribeInstanceMonitorTopNCmdRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdResponse>(req, "DescribeInstanceMonitorTopNCmd");
        }

        /// <summary>
        /// 查询实例访问命令
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdResponse DescribeInstanceMonitorTopNCmdSync(DescribeInstanceMonitorTopNCmdRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdResponse>(req, "DescribeInstanceMonitorTopNCmd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例CPU耗时
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public Task<DescribeInstanceMonitorTopNCmdTookResponse> DescribeInstanceMonitorTopNCmdTook(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdTookResponse>(req, "DescribeInstanceMonitorTopNCmdTook");
        }

        /// <summary>
        /// 查询实例CPU耗时
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdTookResponse DescribeInstanceMonitorTopNCmdTookSync(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorTopNCmdTookResponse>(req, "DescribeInstanceMonitorTopNCmdTook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）用于查询实例节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo");
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）用于查询实例节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询参数修改历史列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords");
        }

        /// <summary>
        /// 查询参数修改历史列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询实例参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询实例参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceSecurityGroup）用于查询实例安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public Task<DescribeInstanceSecurityGroupResponse> DescribeInstanceSecurityGroup(DescribeInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSecurityGroupResponse>(req, "DescribeInstanceSecurityGroup");
        }

        /// <summary>
        /// 本接口（DescribeInstanceSecurityGroup）用于查询实例安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public DescribeInstanceSecurityGroupResponse DescribeInstanceSecurityGroupSync(DescribeInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSecurityGroupResponse>(req, "DescribeInstanceSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceShards）用于获取集群架构实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public Task<DescribeInstanceShardsResponse> DescribeInstanceShards(DescribeInstanceShardsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceShardsResponse>(req, "DescribeInstanceShards");
        }

        /// <summary>
        /// 本接口（DescribeInstanceShards）用于获取集群架构实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public DescribeInstanceShardsResponse DescribeInstanceShardsSync(DescribeInstanceShardsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceShardsResponse>(req, "DescribeInstanceShards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceSupportFeature）用于查询实例支持的功能特性。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSupportFeatureRequest"/></param>
        /// <returns><see cref="DescribeInstanceSupportFeatureResponse"/></returns>
        public Task<DescribeInstanceSupportFeatureResponse> DescribeInstanceSupportFeature(DescribeInstanceSupportFeatureRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSupportFeatureResponse>(req, "DescribeInstanceSupportFeature");
        }

        /// <summary>
        /// 本接口（DescribeInstanceSupportFeature）用于查询实例支持的功能特性。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSupportFeatureRequest"/></param>
        /// <returns><see cref="DescribeInstanceSupportFeatureResponse"/></returns>
        public DescribeInstanceSupportFeatureResponse DescribeInstanceSupportFeatureSync(DescribeInstanceSupportFeatureRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSupportFeatureResponse>(req, "DescribeInstanceSupportFeature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceZoneInfo）用于查询 Redis 节点详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public Task<DescribeInstanceZoneInfoResponse> DescribeInstanceZoneInfo(DescribeInstanceZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceZoneInfoResponse>(req, "DescribeInstanceZoneInfo");
        }

        /// <summary>
        /// 本接口（DescribeInstanceZoneInfo）用于查询 Redis 节点详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceZoneInfoResponse"/></returns>
        public DescribeInstanceZoneInfoResponse DescribeInstanceZoneInfoSync(DescribeInstanceZoneInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceZoneInfoResponse>(req, "DescribeInstanceZoneInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstances）用于查询Redis实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 本接口（DescribeInstances）用于查询Redis实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例维护时间窗，在实例需要进行版本升级或者架构升级的时候，会在维护时间窗时间内进行切换
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public Task<DescribeMaintenanceWindowResponse> DescribeMaintenanceWindow(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow");
        }

        /// <summary>
        /// 查询实例维护时间窗，在实例需要进行版本升级或者架构升级的时候，会在维护时间窗时间内进行切换
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public DescribeMaintenanceWindowResponse DescribeMaintenanceWindowSync(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeParamTemplateInfo）用于查询参数模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo");
        }

        /// <summary>
        /// 本接口（DescribeParamTemplateInfo）用于查询参数模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplateInfoResponse>(req, "DescribeParamTemplateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询参数模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates");
        }

        /// <summary>
        /// 查询参数模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParamTemplatesResponse>(req, "DescribeParamTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProductInfo）用于查询全地域 Redis 的售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public Task<DescribeProductInfoResponse> DescribeProductInfo(DescribeProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeProductInfoResponse>(req, "DescribeProductInfo");
        }

        /// <summary>
        /// 本接口（DescribeProductInfo）用于查询全地域 Redis 的售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public DescribeProductInfoResponse DescribeProductInfoSync(DescribeProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeProductInfoResponse>(req, "DescribeProductInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public Task<DescribeProjectSecurityGroupResponse> DescribeProjectSecurityGroup(DescribeProjectSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupResponse>(req, "DescribeProjectSecurityGroup");
        }

        /// <summary>
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public DescribeProjectSecurityGroupResponse DescribeProjectSecurityGroupSync(DescribeProjectSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupResponse>(req, "DescribeProjectSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxySlowLog）用于查询代理慢查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public Task<DescribeProxySlowLogResponse> DescribeProxySlowLog(DescribeProxySlowLogRequest req)
        {
            return InternalRequestAsync<DescribeProxySlowLogResponse>(req, "DescribeProxySlowLog");
        }

        /// <summary>
        /// 本接口（DescribeProxySlowLog）用于查询代理慢查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public DescribeProxySlowLogResponse DescribeProxySlowLogSync(DescribeProxySlowLogRequest req)
        {
            return InternalRequestAsync<DescribeProxySlowLogResponse>(req, "DescribeProxySlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeReplicationGroup）用于查询复制组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public Task<DescribeReplicationGroupResponse> DescribeReplicationGroup(DescribeReplicationGroupRequest req)
        {
            return InternalRequestAsync<DescribeReplicationGroupResponse>(req, "DescribeReplicationGroup");
        }

        /// <summary>
        /// 本接口（DescribeReplicationGroup）用于查询复制组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationGroupRequest"/></param>
        /// <returns><see cref="DescribeReplicationGroupResponse"/></returns>
        public DescribeReplicationGroupResponse DescribeReplicationGroupSync(DescribeReplicationGroupRequest req)
        {
            return InternalRequestAsync<DescribeReplicationGroupResponse>(req, "DescribeReplicationGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSSLStatus）用于查询实例 SSL 认证相关信息，包括开启状态、配置状态、证书地址等。
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public Task<DescribeSSLStatusResponse> DescribeSSLStatus(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus");
        }

        /// <summary>
        /// 本接口（DescribeSSLStatus）用于查询实例 SSL 认证相关信息，包括开启状态、配置状态、证书地址等。
        /// </summary>
        /// <param name="req"><see cref="DescribeSSLStatusRequest"/></param>
        /// <returns><see cref="DescribeSSLStatusResponse"/></returns>
        public DescribeSSLStatusResponse DescribeSSLStatusSync(DescribeSSLStatusRequest req)
        {
            return InternalRequestAsync<DescribeSSLStatusResponse>(req, "DescribeSSLStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSlowLog）查询实例慢查询记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogResponse>(req, "DescribeSlowLog");
        }

        /// <summary>
        /// 本接口（DescribeSlowLog）查询实例慢查询记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public DescribeSlowLogResponse DescribeSlowLogSync(DescribeSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogResponse>(req, "DescribeSlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTaskInfo）用于获取指定任务的执行情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo");
        }

        /// <summary>
        /// 本接口（DescribeTaskInfo）用于获取指定任务的执行情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTaskList）用于查询指定实例的任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList");
        }

        /// <summary>
        /// 本接口（DescribeTaskList）用于查询指定实例的任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Tendis慢查询
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public Task<DescribeTendisSlowLogResponse> DescribeTendisSlowLog(DescribeTendisSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeTendisSlowLogResponse>(req, "DescribeTendisSlowLog");
        }

        /// <summary>
        /// 查询Tendis慢查询
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public DescribeTendisSlowLogResponse DescribeTendisSlowLogSync(DescribeTendisSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeTendisSlowLogResponse>(req, "DescribeTendisSlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按量计费实例销毁
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public Task<DestroyPostpaidInstanceResponse> DestroyPostpaidInstance(DestroyPostpaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPostpaidInstanceResponse>(req, "DestroyPostpaidInstance");
        }

        /// <summary>
        /// 按量计费实例销毁
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public DestroyPostpaidInstanceResponse DestroyPostpaidInstanceSync(DestroyPostpaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPostpaidInstanceResponse>(req, "DestroyPostpaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 包年包月实例退还
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public Task<DestroyPrepaidInstanceResponse> DestroyPrepaidInstance(DestroyPrepaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrepaidInstanceResponse>(req, "DestroyPrepaidInstance");
        }

        /// <summary>
        /// 包年包月实例退还
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public DestroyPrepaidInstanceResponse DestroyPrepaidInstanceSync(DestroyPrepaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrepaidInstanceResponse>(req, "DestroyPrepaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用读写分离
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public Task<DisableReplicaReadonlyResponse> DisableReplicaReadonly(DisableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<DisableReplicaReadonlyResponse>(req, "DisableReplicaReadonly");
        }

        /// <summary>
        /// 禁用读写分离
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public DisableReplicaReadonlyResponse DisableReplicaReadonlySync(DisableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<DisableReplicaReadonlyResponse>(req, "DisableReplicaReadonly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用读写分离
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public Task<EnableReplicaReadonlyResponse> EnableReplicaReadonly(EnableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<EnableReplicaReadonlyResponse>(req, "EnableReplicaReadonly");
        }

        /// <summary>
        /// 启用读写分离
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public EnableReplicaReadonlyResponse EnableReplicaReadonlySync(EnableReplicaReadonlyRequest req)
        {
            return InternalRequestAsync<EnableReplicaReadonlyResponse>(req, "EnableReplicaReadonly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询新购实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance");
        }

        /// <summary>
        /// 查询新购实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例续费价格（包年包月）
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance");
        }

        /// <summary>
        /// 查询实例续费价格（包年包月）
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public InquiryPriceRenewInstanceResponse InquiryPriceRenewInstanceSync(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例扩容价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public Task<InquiryPriceUpgradeInstanceResponse> InquiryPriceUpgradeInstance(InquiryPriceUpgradeInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeInstanceResponse>(req, "InquiryPriceUpgradeInstance");
        }

        /// <summary>
        /// 查询实例扩容价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstanceResponse"/></returns>
        public InquiryPriceUpgradeInstanceResponse InquiryPriceUpgradeInstanceSync(InquiryPriceUpgradeInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeInstanceResponse>(req, "InquiryPriceUpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（KillMasterGroup）模拟故障。
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public Task<KillMasterGroupResponse> KillMasterGroup(KillMasterGroupRequest req)
        {
            return InternalRequestAsync<KillMasterGroupResponse>(req, "KillMasterGroup");
        }

        /// <summary>
        /// 本接口（KillMasterGroup）模拟故障。
        /// </summary>
        /// <param name="req"><see cref="KillMasterGroupRequest"/></param>
        /// <returns><see cref="KillMasterGroupResponse"/></returns>
        public KillMasterGroupResponse KillMasterGroupSync(KillMasterGroupRequest req)
        {
            return InternalRequestAsync<KillMasterGroupResponse>(req, "KillMasterGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ManualBackupInstance）用于手动备份Redis实例。
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public Task<ManualBackupInstanceResponse> ManualBackupInstance(ManualBackupInstanceRequest req)
        {
            return InternalRequestAsync<ManualBackupInstanceResponse>(req, "ManualBackupInstance");
        }

        /// <summary>
        /// 本接口（ManualBackupInstance）用于手动备份Redis实例。
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public ManualBackupInstanceResponse ManualBackupInstanceSync(ManualBackupInstanceRequest req)
        {
            return InternalRequestAsync<ManualBackupInstanceResponse>(req, "ManualBackupInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModfiyInstancePassword）用于修改实例访问密码。
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public Task<ModfiyInstancePasswordResponse> ModfiyInstancePassword(ModfiyInstancePasswordRequest req)
        {
            return InternalRequestAsync<ModfiyInstancePasswordResponse>(req, "ModfiyInstancePassword");
        }

        /// <summary>
        /// 本接口（ModfiyInstancePassword）用于修改实例访问密码。
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public ModfiyInstancePasswordResponse ModfiyInstancePasswordSync(ModfiyInstancePasswordRequest req)
        {
            return InternalRequestAsync<ModfiyInstancePasswordResponse>(req, "ModfiyInstancePassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAutoBackupConfig）用于设置自动备份的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public Task<ModifyAutoBackupConfigResponse> ModifyAutoBackupConfig(ModifyAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupConfigResponse>(req, "ModifyAutoBackupConfig");
        }

        /// <summary>
        /// 本接口（ModifyAutoBackupConfig）用于设置自动备份的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public ModifyAutoBackupConfigResponse ModifyAutoBackupConfigSync(ModifyAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupConfigResponse>(req, "ModifyAutoBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载的网络信息与地址。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction");
        }

        /// <summary>
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载的网络信息与地址。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例的连接配置，包括带宽和最大连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public Task<ModifyConnectionConfigResponse> ModifyConnectionConfig(ModifyConnectionConfigRequest req)
        {
            return InternalRequestAsync<ModifyConnectionConfigResponse>(req, "ModifyConnectionConfig");
        }

        /// <summary>
        /// 修改实例的连接配置，包括带宽和最大连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public ModifyConnectionConfigResponse ModifyConnectionConfigSync(ModifyConnectionConfigRequest req)
        {
            return InternalRequestAsync<ModifyConnectionConfigResponse>(req, "ModifyConnectionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例相关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 修改实例相关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例子账号
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public Task<ModifyInstanceAccountResponse> ModifyInstanceAccount(ModifyInstanceAccountRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAccountResponse>(req, "ModifyInstanceAccount");
        }

        /// <summary>
        /// 修改实例子账号
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public ModifyInstanceAccountResponse ModifyInstanceAccountSync(ModifyInstanceAccountRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAccountResponse>(req, "ModifyInstanceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceAvailabilityZones）用于变更实例可用区
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAvailabilityZonesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAvailabilityZonesResponse"/></returns>
        public Task<ModifyInstanceAvailabilityZonesResponse> ModifyInstanceAvailabilityZones(ModifyInstanceAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAvailabilityZonesResponse>(req, "ModifyInstanceAvailabilityZones");
        }

        /// <summary>
        /// 本接口（ModifyInstanceAvailabilityZones）用于变更实例可用区
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAvailabilityZonesRequest"/></param>
        /// <returns><see cref="ModifyInstanceAvailabilityZonesResponse"/></returns>
        public ModifyInstanceAvailabilityZonesResponse ModifyInstanceAvailabilityZonesSync(ModifyInstanceAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAvailabilityZonesResponse>(req, "ModifyInstanceAvailabilityZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyInstanceParams)用于修改Redis实例的参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams");
        }

        /// <summary>
        /// 本接口(ModifyInstanceParams)用于修改Redis实例的参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置实例输入模式
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public Task<ModifyInstanceReadOnlyResponse> ModifyInstanceReadOnly(ModifyInstanceReadOnlyRequest req)
        {
            return InternalRequestAsync<ModifyInstanceReadOnlyResponse>(req, "ModifyInstanceReadOnly");
        }

        /// <summary>
        /// 设置实例输入模式
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceReadOnlyRequest"/></param>
        /// <returns><see cref="ModifyInstanceReadOnlyResponse"/></returns>
        public ModifyInstanceReadOnlyResponse ModifyInstanceReadOnlySync(ModifyInstanceReadOnlyRequest req)
        {
            return InternalRequestAsync<ModifyInstanceReadOnlyResponse>(req, "ModifyInstanceReadOnly")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例维护时间窗时间，需要进行版本升级或者架构升级的实例，会在维护时间窗内进行时间切换。注意：已经发起版本升级或者架构升级的实例，无法修改维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public Task<ModifyMaintenanceWindowResponse> ModifyMaintenanceWindow(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow");
        }

        /// <summary>
        /// 修改实例维护时间窗时间，需要进行版本升级或者架构升级的实例，会在维护时间窗内进行时间切换。注意：已经发起版本升级或者架构升级的实例，无法修改维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public ModifyMaintenanceWindowResponse ModifyMaintenanceWindowSync(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNetworkConfig）用于修改实例网络配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public Task<ModifyNetworkConfigResponse> ModifyNetworkConfig(ModifyNetworkConfigRequest req)
        {
            return InternalRequestAsync<ModifyNetworkConfigResponse>(req, "ModifyNetworkConfig");
        }

        /// <summary>
        /// 本接口（ModifyNetworkConfig）用于修改实例网络配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public ModifyNetworkConfigResponse ModifyNetworkConfigSync(ModifyNetworkConfigRequest req)
        {
            return InternalRequestAsync<ModifyNetworkConfigResponse>(req, "ModifyNetworkConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改参数模板
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate");
        }

        /// <summary>
        /// 修改参数模板
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParamTemplateResponse>(req, "ModifyParamTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启SSL
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public Task<OpenSSLResponse> OpenSSL(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL");
        }

        /// <summary>
        /// 开启SSL
        /// </summary>
        /// <param name="req"><see cref="OpenSSLRequest"/></param>
        /// <returns><see cref="OpenSSLResponse"/></returns>
        public OpenSSLResponse OpenSSLSync(OpenSSLRequest req)
        {
            return InternalRequestAsync<OpenSSLResponse>(req, "OpenSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭外网
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public Task<ReleaseWanAddressResponse> ReleaseWanAddress(ReleaseWanAddressRequest req)
        {
            return InternalRequestAsync<ReleaseWanAddressResponse>(req, "ReleaseWanAddress");
        }

        /// <summary>
        /// 关闭外网
        /// </summary>
        /// <param name="req"><see cref="ReleaseWanAddressRequest"/></param>
        /// <returns><see cref="ReleaseWanAddressResponse"/></returns>
        public ReleaseWanAddressResponse ReleaseWanAddressSync(ReleaseWanAddressRequest req)
        {
            return InternalRequestAsync<ReleaseWanAddressResponse>(req, "ReleaseWanAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移除复制组成员
        /// </summary>
        /// <param name="req"><see cref="RemoveReplicationInstanceRequest"/></param>
        /// <returns><see cref="RemoveReplicationInstanceResponse"/></returns>
        public Task<RemoveReplicationInstanceResponse> RemoveReplicationInstance(RemoveReplicationInstanceRequest req)
        {
            return InternalRequestAsync<RemoveReplicationInstanceResponse>(req, "RemoveReplicationInstance");
        }

        /// <summary>
        /// 移除复制组成员
        /// </summary>
        /// <param name="req"><see cref="RemoveReplicationInstanceRequest"/></param>
        /// <returns><see cref="RemoveReplicationInstanceResponse"/></returns>
        public RemoveReplicationInstanceResponse RemoveReplicationInstanceSync(RemoveReplicationInstanceRequest req)
        {
            return InternalRequestAsync<RemoveReplicationInstanceResponse>(req, "RemoveReplicationInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RenewInstance）可用于为实例续费。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance");
        }

        /// <summary>
        /// 本接口（RenewInstance）可用于为实例续费。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword");
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复 CRS 实例
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance");
        }

        /// <summary>
        /// 恢复 CRS 实例
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public Task<StartupInstanceResponse> StartupInstance(StartupInstanceRequest req)
        {
            return InternalRequestAsync<StartupInstanceResponse>(req, "StartupInstance");
        }

        /// <summary>
        /// 实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public StartupInstanceResponse StartupInstanceSync(StartupInstanceRequest req)
        {
            return InternalRequestAsync<StartupInstanceResponse>(req, "StartupInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SwitchAccessNewInstance）针对处于时间窗口中待切换操作的实例，用户可主动发起该操作。
        /// </summary>
        /// <param name="req"><see cref="SwitchAccessNewInstanceRequest"/></param>
        /// <returns><see cref="SwitchAccessNewInstanceResponse"/></returns>
        public Task<SwitchAccessNewInstanceResponse> SwitchAccessNewInstance(SwitchAccessNewInstanceRequest req)
        {
            return InternalRequestAsync<SwitchAccessNewInstanceResponse>(req, "SwitchAccessNewInstance");
        }

        /// <summary>
        /// 本接口（SwitchAccessNewInstance）针对处于时间窗口中待切换操作的实例，用户可主动发起该操作。
        /// </summary>
        /// <param name="req"><see cref="SwitchAccessNewInstanceRequest"/></param>
        /// <returns><see cref="SwitchAccessNewInstanceResponse"/></returns>
        public SwitchAccessNewInstanceResponse SwitchAccessNewInstanceSync(SwitchAccessNewInstanceRequest req)
        {
            return InternalRequestAsync<SwitchAccessNewInstanceResponse>(req, "SwitchAccessNewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在通过DTS支持跨可用区灾备的场景中，通过该接口交换实例VIP完成实例灾备切换。交换VIP后目标实例可写，源和目标实例VIP互换，同时源与目标实例间DTS同步任务断开
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public Task<SwitchInstanceVipResponse> SwitchInstanceVip(SwitchInstanceVipRequest req)
        {
            return InternalRequestAsync<SwitchInstanceVipResponse>(req, "SwitchInstanceVip");
        }

        /// <summary>
        /// 在通过DTS支持跨可用区灾备的场景中，通过该接口交换实例VIP完成实例灾备切换。交换VIP后目标实例可写，源和目标实例VIP互换，同时源与目标实例间DTS同步任务断开
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public SwitchInstanceVipResponse SwitchInstanceVipSync(SwitchInstanceVipRequest req)
        {
            return InternalRequestAsync<SwitchInstanceVipResponse>(req, "SwitchInstanceVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Proxy模拟故障接口
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public Task<SwitchProxyResponse> SwitchProxy(SwitchProxyRequest req)
        {
            return InternalRequestAsync<SwitchProxyResponse>(req, "SwitchProxy");
        }

        /// <summary>
        /// Proxy模拟故障接口
        /// </summary>
        /// <param name="req"><see cref="SwitchProxyRequest"/></param>
        /// <returns><see cref="SwitchProxyResponse"/></returns>
        public SwitchProxyResponse SwitchProxySync(SwitchProxyRequest req)
        {
            return InternalRequestAsync<SwitchProxyResponse>(req, "SwitchProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 变更实例配置
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// 变更实例配置
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将当前实例升级到更高版本，或者将当前标准架构升级至集群架构。
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersion(UpgradeInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceVersionResponse>(req, "UpgradeInstanceVersion");
        }

        /// <summary>
        /// 将当前实例升级到更高版本，或者将当前标准架构升级至集群架构。
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeInstanceVersionResponse"/></returns>
        public UpgradeInstanceVersionResponse UpgradeInstanceVersionSync(UpgradeInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceVersionResponse>(req, "UpgradeInstanceVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例proxy版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public Task<UpgradeProxyVersionResponse> UpgradeProxyVersion(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion");
        }

        /// <summary>
        /// 实例proxy版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeProxyVersionResponse"/></returns>
        public UpgradeProxyVersionResponse UpgradeProxyVersionSync(UpgradeProxyVersionRequest req)
        {
            return InternalRequestAsync<UpgradeProxyVersionResponse>(req, "UpgradeProxyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例小版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public Task<UpgradeSmallVersionResponse> UpgradeSmallVersion(UpgradeSmallVersionRequest req)
        {
            return InternalRequestAsync<UpgradeSmallVersionResponse>(req, "UpgradeSmallVersion");
        }

        /// <summary>
        /// 实例小版本升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeSmallVersionRequest"/></param>
        /// <returns><see cref="UpgradeSmallVersionResponse"/></returns>
        public UpgradeSmallVersionResponse UpgradeSmallVersionSync(UpgradeSmallVersionRequest req)
        {
            return InternalRequestAsync<UpgradeSmallVersionResponse>(req, "UpgradeSmallVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级实例支持多AZ
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public Task<UpgradeVersionToMultiAvailabilityZonesResponse> UpgradeVersionToMultiAvailabilityZones(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<UpgradeVersionToMultiAvailabilityZonesResponse>(req, "UpgradeVersionToMultiAvailabilityZones");
        }

        /// <summary>
        /// 升级实例支持多AZ
        /// </summary>
        /// <param name="req"><see cref="UpgradeVersionToMultiAvailabilityZonesRequest"/></param>
        /// <returns><see cref="UpgradeVersionToMultiAvailabilityZonesResponse"/></returns>
        public UpgradeVersionToMultiAvailabilityZonesResponse UpgradeVersionToMultiAvailabilityZonesSync(UpgradeVersionToMultiAvailabilityZonesRequest req)
        {
            return InternalRequestAsync<UpgradeVersionToMultiAvailabilityZonesResponse>(req, "UpgradeVersionToMultiAvailabilityZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
