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

namespace TencentCloud.Tdmysql.V20211122
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdmysql.V20211122.Models;

   public class TdmysqlClient : AbstractClient{

       private const string endpoint = "tdmysql.tencentcloudapi.com";
       private const string version = "2021-11-22";
       private const string sdkVersion = "SDK_NET_3.0.1376";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdmysqlClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdmysqlClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（CancelIsolateDBInstances）提供批量解除隔离实例功能
        /// </summary>
        /// <param name="req"><see cref="CancelIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="CancelIsolateDBInstancesResponse"/></returns>
        public Task<CancelIsolateDBInstancesResponse> CancelIsolateDBInstances(CancelIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<CancelIsolateDBInstancesResponse>(req, "CancelIsolateDBInstances");
        }

        /// <summary>
        /// 本接口（CancelIsolateDBInstances）提供批量解除隔离实例功能
        /// </summary>
        /// <param name="req"><see cref="CancelIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="CancelIsolateDBInstancesResponse"/></returns>
        public CancelIsolateDBInstancesResponse CancelIsolateDBInstancesSync(CancelIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<CancelIsolateDBInstancesResponse>(req, "CancelIsolateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例备份集
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public Task<CreateDBSBackupResponse> CreateDBSBackup(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup");
        }

        /// <summary>
        /// 创建实例备份集
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public CreateDBSBackupResponse CreateDBSBackupSync(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例备份集
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public Task<DeleteDBSBackupSetsResponse> DeleteDBSBackupSets(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets");
        }

        /// <summary>
        /// 删除实例备份集
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public DeleteDBSBackupSetsResponse DeleteDBSBackupSetsSync(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 已无地方调用
        /// 
        /// 本接口（DescribeBillingEnable）用于查询计费是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingEnableRequest"/></param>
        /// <returns><see cref="DescribeBillingEnableResponse"/></returns>
        public Task<DescribeBillingEnableResponse> DescribeBillingEnable(DescribeBillingEnableRequest req)
        {
            return InternalRequestAsync<DescribeBillingEnableResponse>(req, "DescribeBillingEnable");
        }

        /// <summary>
        /// 已无地方调用
        /// 
        /// 本接口（DescribeBillingEnable）用于查询计费是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingEnableRequest"/></param>
        /// <returns><see cref="DescribeBillingEnableResponse"/></returns>
        public DescribeBillingEnableResponse DescribeBillingEnableSync(DescribeBillingEnableRequest req)
        {
            return InternalRequestAsync<DescribeBillingEnableResponse>(req, "DescribeBillingEnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBParameters）用于获取实例的当前参数设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public Task<DescribeDBParametersResponse> DescribeDBParameters(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters");
        }

        /// <summary>
        /// 本接口（DescribeDBParameters）用于获取实例的当前参数设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public DescribeDBParametersResponse DescribeDBParametersSync(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可恢复时间查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public Task<DescribeDBSAvailableRecoveryTimeResponse> DescribeDBSAvailableRecoveryTime(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime");
        }

        /// <summary>
        /// 可恢复时间查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public DescribeDBSAvailableRecoveryTimeResponse DescribeDBSAvailableRecoveryTimeSync(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例克隆列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSCloneInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBSCloneInstancesResponse"/></returns>
        public Task<DescribeDBSCloneInstancesResponse> DescribeDBSCloneInstances(DescribeDBSCloneInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBSCloneInstancesResponse>(req, "DescribeDBSCloneInstances");
        }

        /// <summary>
        /// 查询实例克隆列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSCloneInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBSCloneInstancesResponse"/></returns>
        public DescribeDBSCloneInstancesResponse DescribeDBSCloneInstancesSync(DescribeDBSCloneInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBSCloneInstancesResponse>(req, "DescribeDBSCloneInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBSecurityGroups）用于查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// 本接口（DescribeDBSecurityGroups）用于查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDatabaseObjects）用于查询云数据库实例的数据库中的对象列表，包含表、存储过程、视图和函数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public Task<DescribeDatabaseObjectsResponse> DescribeDatabaseObjects(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects");
        }

        /// <summary>
        /// 本接口（DescribeDatabaseObjects）用于查询云数据库实例的数据库中的对象列表，包含表、存储过程、视图和函数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public DescribeDatabaseObjectsResponse DescribeDatabaseObjectsSync(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 冗余接口，无人调用
        /// 
        /// 本接口（DescribeDatabaseTable）用于查询云数据库实例的表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public Task<DescribeDatabaseTableResponse> DescribeDatabaseTable(DescribeDatabaseTableRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseTableResponse>(req, "DescribeDatabaseTable");
        }

        /// <summary>
        /// 冗余接口，无人调用
        /// 
        /// 本接口（DescribeDatabaseTable）用于查询云数据库实例的表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public DescribeDatabaseTableResponse DescribeDatabaseTableSync(DescribeDatabaseTableRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseTableResponse>(req, "DescribeDatabaseTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询异步任务流程状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow");
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询异步任务流程状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DestroyInstances）提供批量销毁实例功能
        /// </summary>
        /// <param name="req"><see cref="DestroyInstancesRequest"/></param>
        /// <returns><see cref="DestroyInstancesResponse"/></returns>
        public Task<DestroyInstancesResponse> DestroyInstances(DestroyInstancesRequest req)
        {
            return InternalRequestAsync<DestroyInstancesResponse>(req, "DestroyInstances");
        }

        /// <summary>
        /// 本接口（DestroyInstances）提供批量销毁实例功能
        /// </summary>
        /// <param name="req"><see cref="DestroyInstancesRequest"/></param>
        /// <returns><see cref="DestroyInstancesResponse"/></returns>
        public DestroyInstancesResponse DestroyInstancesSync(DestroyInstancesRequest req)
        {
            return InternalRequestAsync<DestroyInstancesResponse>(req, "DestroyInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（IsolateDBInstance）提供批量隔离实例功能
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// 本接口（IsolateDBInstance）提供批量隔离实例功能
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAutoRenewFlag）用于修改自动续费标志
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag");
        }

        /// <summary>
        /// 本接口（ModifyAutoRenewFlag）用于修改自动续费标志
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口功能已被 ModifyInstanceCdc 完全覆盖
        /// 
        /// 修改binlog状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogStatusRequest"/></param>
        /// <returns><see cref="ModifyBinlogStatusResponse"/></returns>
        public Task<ModifyBinlogStatusResponse> ModifyBinlogStatus(ModifyBinlogStatusRequest req)
        {
            return InternalRequestAsync<ModifyBinlogStatusResponse>(req, "ModifyBinlogStatus");
        }

        /// <summary>
        /// 接口功能已被 ModifyInstanceCdc 完全覆盖
        /// 
        /// 修改binlog状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBinlogStatusRequest"/></param>
        /// <returns><see cref="ModifyBinlogStatusResponse"/></returns>
        public ModifyBinlogStatusResponse ModifyBinlogStatusSync(ModifyBinlogStatusRequest req)
        {
            return InternalRequestAsync<ModifyBinlogStatusResponse>(req, "ModifyBinlogStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改云数据库安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改云数据库安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBParameters）用于修改实例参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters");
        }

        /// <summary>
        /// 本接口（ModifyDBParameters）用于修改实例参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public ModifyDBParametersResponse ModifyDBParametersSync(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public Task<ModifyDBSBackupPolicyResponse> ModifyDBSBackupPolicy(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy");
        }

        /// <summary>
        /// 修改实例备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public ModifyDBSBackupPolicyResponse ModifyDBSBackupPolicySync(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改备份集备注
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupSetCommentRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupSetCommentResponse"/></returns>
        public Task<ModifyDBSBackupSetCommentResponse> ModifyDBSBackupSetComment(ModifyDBSBackupSetCommentRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupSetCommentResponse>(req, "ModifyDBSBackupSetComment");
        }

        /// <summary>
        /// 修改备份集备注
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupSetCommentRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupSetCommentResponse"/></returns>
        public ModifyDBSBackupSetCommentResponse ModifyDBSBackupSetCommentSync(ModifyDBSBackupSetCommentRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupSetCommentResponse>(req, "ModifyDBSBackupSetComment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceName）提供修改实例名称功能
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName");
        }

        /// <summary>
        /// 本接口（ModifyInstanceName）提供修改实例名称功能
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
