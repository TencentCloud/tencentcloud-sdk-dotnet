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
       private const string sdkVersion = "SDK_NET_3.0.1432";

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
        /// 本接口（CreateCloneInstance）提供创建克隆实例功能
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public Task<CreateCloneInstanceResponse> CreateCloneInstance(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance");
        }

        /// <summary>
        /// 本接口（CreateCloneInstance）提供创建克隆实例功能
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public CreateCloneInstanceResponse CreateCloneInstanceSync(CreateCloneInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloneInstanceResponse>(req, "CreateCloneInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDBInstances）提供批量创建实例功能
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances");
        }

        /// <summary>
        /// 本接口（CreateDBInstances）提供批量创建实例功能
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例手工备份  CreateDBSBackup
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public Task<CreateDBSBackupResponse> CreateDBSBackup(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup");
        }

        /// <summary>
        /// 创建实例手工备份  CreateDBSBackup
        /// </summary>
        /// <param name="req"><see cref="CreateDBSBackupRequest"/></param>
        /// <returns><see cref="CreateDBSBackupResponse"/></returns>
        public CreateDBSBackupResponse CreateDBSBackupSync(CreateDBSBackupRequest req)
        {
            return InternalRequestAsync<CreateDBSBackupResponse>(req, "CreateDBSBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例手工备份 DeleteDBSBackupSets
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public Task<DeleteDBSBackupSetsResponse> DeleteDBSBackupSets(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets");
        }

        /// <summary>
        /// 删除实例手工备份 DeleteDBSBackupSets
        /// </summary>
        /// <param name="req"><see cref="DeleteDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DeleteDBSBackupSetsResponse"/></returns>
        public DeleteDBSBackupSetsResponse DeleteDBSBackupSetsSync(DeleteDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DeleteDBSBackupSetsResponse>(req, "DeleteDBSBackupSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceDetail）提供查询实例详情功能
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetail(DescribeDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDetailResponse>(req, "DescribeDBInstanceDetail");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceDetail）提供查询实例详情功能
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetailSync(DescribeDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDetailResponse>(req, "DescribeDBInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstances）提供查询实例列表功能
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// 本接口（DescribeDBInstances）提供查询实例列表功能
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
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
        /// 查询实例归档日志列表 DescribeDBSArchiveLogs
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSArchiveLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSArchiveLogsResponse"/></returns>
        public Task<DescribeDBSArchiveLogsResponse> DescribeDBSArchiveLogs(DescribeDBSArchiveLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSArchiveLogsResponse>(req, "DescribeDBSArchiveLogs");
        }

        /// <summary>
        /// 查询实例归档日志列表 DescribeDBSArchiveLogs
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSArchiveLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSArchiveLogsResponse"/></returns>
        public DescribeDBSArchiveLogsResponse DescribeDBSArchiveLogsSync(DescribeDBSArchiveLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSArchiveLogsResponse>(req, "DescribeDBSArchiveLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取可恢复时间 DescribeDBSAvailableRecoveryTime
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public Task<DescribeDBSAvailableRecoveryTimeResponse> DescribeDBSAvailableRecoveryTime(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime");
        }

        /// <summary>
        /// 获取可恢复时间 DescribeDBSAvailableRecoveryTime
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeDBSAvailableRecoveryTimeResponse"/></returns>
        public DescribeDBSAvailableRecoveryTimeResponse DescribeDBSAvailableRecoveryTimeSync(DescribeDBSAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBSAvailableRecoveryTimeResponse>(req, "DescribeDBSAvailableRecoveryTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例备份策略 DescribeDBSBackupPolicy
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupPolicyResponse"/></returns>
        public Task<DescribeDBSBackupPolicyResponse> DescribeDBSBackupPolicy(DescribeDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupPolicyResponse>(req, "DescribeDBSBackupPolicy");
        }

        /// <summary>
        /// 查询实例备份策略 DescribeDBSBackupPolicy
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupPolicyResponse"/></returns>
        public DescribeDBSBackupPolicyResponse DescribeDBSBackupPolicySync(DescribeDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupPolicyResponse>(req, "DescribeDBSBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例备份集信息 DescribeDBSBackupSets
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupSetsResponse"/></returns>
        public Task<DescribeDBSBackupSetsResponse> DescribeDBSBackupSets(DescribeDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupSetsResponse>(req, "DescribeDBSBackupSets");
        }

        /// <summary>
        /// 查询实例备份集信息 DescribeDBSBackupSets
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupSetsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupSetsResponse"/></returns>
        public DescribeDBSBackupSetsResponse DescribeDBSBackupSetsSync(DescribeDBSBackupSetsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupSetsResponse>(req, "DescribeDBSBackupSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例备份空间概览 DescribeDBSBackupStatistics
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsResponse"/></returns>
        public Task<DescribeDBSBackupStatisticsResponse> DescribeDBSBackupStatistics(DescribeDBSBackupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsResponse>(req, "DescribeDBSBackupStatistics");
        }

        /// <summary>
        /// 查询实例备份空间概览 DescribeDBSBackupStatistics
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsResponse"/></returns>
        public DescribeDBSBackupStatisticsResponse DescribeDBSBackupStatisticsSync(DescribeDBSBackupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsResponse>(req, "DescribeDBSBackupStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份集统计详情 DescribeDBSBackupStatisticsDetail
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsDetailRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsDetailResponse"/></returns>
        public Task<DescribeDBSBackupStatisticsDetailResponse> DescribeDBSBackupStatisticsDetail(DescribeDBSBackupStatisticsDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsDetailResponse>(req, "DescribeDBSBackupStatisticsDetail");
        }

        /// <summary>
        /// 查询备份集统计详情 DescribeDBSBackupStatisticsDetail
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSBackupStatisticsDetailRequest"/></param>
        /// <returns><see cref="DescribeDBSBackupStatisticsDetailResponse"/></returns>
        public DescribeDBSBackupStatisticsDetailResponse DescribeDBSBackupStatisticsDetailSync(DescribeDBSBackupStatisticsDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBSBackupStatisticsDetailResponse>(req, "DescribeDBSBackupStatisticsDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例克隆列表 DescribeDBSCloneInstances
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSCloneInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBSCloneInstancesResponse"/></returns>
        public Task<DescribeDBSCloneInstancesResponse> DescribeDBSCloneInstances(DescribeDBSCloneInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBSCloneInstancesResponse>(req, "DescribeDBSCloneInstances");
        }

        /// <summary>
        /// 查询实例克隆列表 DescribeDBSCloneInstances
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
        /// 本接口（DescribeDatabases）用于查询云数据库实例的数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询云数据库实例的数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
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
        /// 本接口（DescribeSaleInfo）提供查询可用售卖地域功能
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleInfoResponse"/></returns>
        public Task<DescribeSaleInfoResponse> DescribeSaleInfo(DescribeSaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeSaleInfoResponse>(req, "DescribeSaleInfo");
        }

        /// <summary>
        /// 本接口（DescribeSaleInfo）提供查询可用售卖地域功能
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleInfoResponse"/></returns>
        public DescribeSaleInfoResponse DescribeSaleInfoSync(DescribeSaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeSaleInfoResponse>(req, "DescribeSaleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSpecs）提供查询售卖规格功能
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecsRequest"/></param>
        /// <returns><see cref="DescribeSpecsResponse"/></returns>
        public Task<DescribeSpecsResponse> DescribeSpecs(DescribeSpecsRequest req)
        {
            return InternalRequestAsync<DescribeSpecsResponse>(req, "DescribeSpecs");
        }

        /// <summary>
        /// 本接口（DescribeSpecs）提供查询售卖规格功能
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecsRequest"/></param>
        /// <returns><see cref="DescribeSpecsResponse"/></returns>
        public DescribeSpecsResponse DescribeSpecsSync(DescribeSpecsRequest req)
        {
            return InternalRequestAsync<DescribeSpecsResponse>(req, "DescribeSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUserPrivileges）提供查询用户的权限功能
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeUserPrivilegesResponse"/></returns>
        public Task<DescribeUserPrivilegesResponse> DescribeUserPrivileges(DescribeUserPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeUserPrivilegesResponse>(req, "DescribeUserPrivileges");
        }

        /// <summary>
        /// 本接口（DescribeUserPrivileges）提供查询用户的权限功能
        /// </summary>
        /// <param name="req"><see cref="DescribeUserPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeUserPrivilegesResponse"/></returns>
        public DescribeUserPrivilegesResponse DescribeUserPrivilegesSync(DescribeUserPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeUserPrivilegesResponse>(req, "DescribeUserPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUsers）提供查询用户列表功能
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers");
        }

        /// <summary>
        /// 本接口（DescribeUsers）提供查询用户列表功能
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers")
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
        /// 本接口（ExpandInstance）提供横向扩容实例功能
        /// </summary>
        /// <param name="req"><see cref="ExpandInstanceRequest"/></param>
        /// <returns><see cref="ExpandInstanceResponse"/></returns>
        public Task<ExpandInstanceResponse> ExpandInstance(ExpandInstanceRequest req)
        {
            return InternalRequestAsync<ExpandInstanceResponse>(req, "ExpandInstance");
        }

        /// <summary>
        /// 本接口（ExpandInstance）提供横向扩容实例功能
        /// </summary>
        /// <param name="req"><see cref="ExpandInstanceRequest"/></param>
        /// <returns><see cref="ExpandInstanceResponse"/></returns>
        public ExpandInstanceResponse ExpandInstanceSync(ExpandInstanceRequest req)
        {
            return InternalRequestAsync<ExpandInstanceResponse>(req, "ExpandInstance")
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
        /// 修改实例备份策略 ModifyDBSBackupPolicy
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public Task<ModifyDBSBackupPolicyResponse> ModifyDBSBackupPolicy(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy");
        }

        /// <summary>
        /// 修改实例备份策略 ModifyDBSBackupPolicy
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupPolicyRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupPolicyResponse"/></returns>
        public ModifyDBSBackupPolicyResponse ModifyDBSBackupPolicySync(ModifyDBSBackupPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupPolicyResponse>(req, "ModifyDBSBackupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例备份备注 ModifyDBSBackupSetComment
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSBackupSetCommentRequest"/></param>
        /// <returns><see cref="ModifyDBSBackupSetCommentResponse"/></returns>
        public Task<ModifyDBSBackupSetCommentResponse> ModifyDBSBackupSetComment(ModifyDBSBackupSetCommentRequest req)
        {
            return InternalRequestAsync<ModifyDBSBackupSetCommentResponse>(req, "ModifyDBSBackupSetComment");
        }

        /// <summary>
        /// 修改实例备份备注 ModifyDBSBackupSetComment
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

        /// <summary>
        /// 本接口(ModifyPrivileges)修改用户权限
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyUserPrivilegesResponse"/></returns>
        public Task<ModifyUserPrivilegesResponse> ModifyUserPrivileges(ModifyUserPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesResponse>(req, "ModifyUserPrivileges");
        }

        /// <summary>
        /// 本接口(ModifyPrivileges)修改用户权限
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyUserPrivilegesResponse"/></returns>
        public ModifyUserPrivilegesResponse ModifyUserPrivilegesSync(ModifyUserPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyUserPrivilegesResponse>(req, "ModifyUserPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RestartDBInstances）用于重启数据库实例
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public Task<RestartDBInstancesResponse> RestartDBInstances(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances");
        }

        /// <summary>
        /// 本接口（RestartDBInstances）用于重启数据库实例
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public RestartDBInstancesResponse RestartDBInstancesSync(RestartDBInstancesRequest req)
        {
            return InternalRequestAsync<RestartDBInstancesResponse>(req, "RestartDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeInstance）提供纵向扩容实例功能
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// 本接口（UpgradeInstance）提供纵向扩容实例功能
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
