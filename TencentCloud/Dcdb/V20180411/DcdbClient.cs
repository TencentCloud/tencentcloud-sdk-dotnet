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

namespace TencentCloud.Dcdb.V20180411
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dcdb.V20180411.Models;

   public class DcdbClient : AbstractClient{

       private const string endpoint = "dcdb.tencentcloudapi.com";
       private const string version = "2018-04-11";
       private const string sdkVersion = "SDK_NET_3.0.1002";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DcdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DcdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 解隔离TDSQL按量计费实例
        /// </summary>
        /// <param name="req"><see cref="ActiveHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="ActiveHourDCDBInstanceResponse"/></returns>
        public Task<ActiveHourDCDBInstanceResponse> ActiveHourDCDBInstance(ActiveHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<ActiveHourDCDBInstanceResponse>(req, "ActiveHourDCDBInstance");
        }

        /// <summary>
        /// 解隔离TDSQL按量计费实例
        /// </summary>
        /// <param name="req"><see cref="ActiveHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="ActiveHourDCDBInstanceResponse"/></returns>
        public ActiveHourDCDBInstanceResponse ActiveHourDCDBInstanceSync(ActiveHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<ActiveHourDCDBInstanceResponse>(req, "ActiveHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定云资源。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定云资源。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CancelDcnJob）用于取消DCN同步
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public Task<CancelDcnJobResponse> CancelDcnJob(CancelDcnJobRequest req)
        {
            return InternalRequestAsync<CancelDcnJobResponse>(req, "CancelDcnJob");
        }

        /// <summary>
        /// 本接口（CancelDcnJob）用于取消DCN同步
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public CancelDcnJobResponse CancelDcnJobSync(CancelDcnJobRequest req)
        {
            return InternalRequestAsync<CancelDcnJobResponse>(req, "CancelDcnJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloneAccount）用于克隆实例账户。
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public Task<CloneAccountResponse> CloneAccount(CloneAccountRequest req)
        {
            return InternalRequestAsync<CloneAccountResponse>(req, "CloneAccount");
        }

        /// <summary>
        /// 本接口（CloneAccount）用于克隆实例账户。
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public CloneAccountResponse CloneAccountSync(CloneAccountRequest req)
        {
            return InternalRequestAsync<CloneAccountResponse>(req, "CloneAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CloseDBExtranetAccess)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问，查询实例列表接口将不返回对应实例的外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess");
        }

        /// <summary>
        /// 本接口(CloseDBExtranetAccess)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问，查询实例列表接口将不返回对应实例的外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CopyAccountPrivileges）用于复制云数据库账号的权限。
        /// 注意：相同用户名，不同Host是不同的账号，Readonly属性相同的账号之间才能复制权限。
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public Task<CopyAccountPrivilegesResponse> CopyAccountPrivileges(CopyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<CopyAccountPrivilegesResponse>(req, "CopyAccountPrivileges");
        }

        /// <summary>
        /// 本接口（CopyAccountPrivileges）用于复制云数据库账号的权限。
        /// 注意：相同用户名，不同Host是不同的账号，Readonly属性相同的账号之间才能复制权限。
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public CopyAccountPrivilegesResponse CopyAccountPrivilegesSync(CopyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<CopyAccountPrivilegesResponse>(req, "CopyAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建云数据库账号。一个实例可以创建多个不同的账号，相同的用户名+不同的host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建云数据库账号。一个实例可以创建多个不同的账号，相同的用户名+不同的host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDCDBInstance）用于创建包年包月的TDSQL实例，可通过传入实例规格、数据库版本号、购买时长等信息创建云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDCDBInstanceResponse"/></returns>
        public Task<CreateDCDBInstanceResponse> CreateDCDBInstance(CreateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDCDBInstanceResponse>(req, "CreateDCDBInstance");
        }

        /// <summary>
        /// 本接口（CreateDCDBInstance）用于创建包年包月的TDSQL实例，可通过传入实例规格、数据库版本号、购买时长等信息创建云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDCDBInstanceResponse"/></returns>
        public CreateDCDBInstanceResponse CreateDCDBInstanceSync(CreateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDCDBInstanceResponse>(req, "CreateDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建TDSQL独享集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterDCDBInstanceResponse"/></returns>
        public Task<CreateDedicatedClusterDCDBInstanceResponse> CreateDedicatedClusterDCDBInstance(CreateDedicatedClusterDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterDCDBInstanceResponse>(req, "CreateDedicatedClusterDCDBInstance");
        }

        /// <summary>
        /// 创建TDSQL独享集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterDCDBInstanceResponse"/></returns>
        public CreateDedicatedClusterDCDBInstanceResponse CreateDedicatedClusterDCDBInstanceSync(CreateDedicatedClusterDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterDCDBInstanceResponse>(req, "CreateDedicatedClusterDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建TDSQL按量计费实例
        /// </summary>
        /// <param name="req"><see cref="CreateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDCDBInstanceResponse"/></returns>
        public Task<CreateHourDCDBInstanceResponse> CreateHourDCDBInstance(CreateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateHourDCDBInstanceResponse>(req, "CreateHourDCDBInstance");
        }

        /// <summary>
        /// 创建TDSQL按量计费实例
        /// </summary>
        /// <param name="req"><see cref="CreateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDCDBInstanceResponse"/></returns>
        public CreateHourDCDBInstanceResponse CreateHourDCDBInstanceSync(CreateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateHourDCDBInstanceResponse>(req, "CreateHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回档TDSQL实例
        /// </summary>
        /// <param name="req"><see cref="CreateTmpDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateTmpDCDBInstanceResponse"/></returns>
        public Task<CreateTmpDCDBInstanceResponse> CreateTmpDCDBInstance(CreateTmpDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateTmpDCDBInstanceResponse>(req, "CreateTmpDCDBInstance");
        }

        /// <summary>
        /// 回档TDSQL实例
        /// </summary>
        /// <param name="req"><see cref="CreateTmpDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateTmpDCDBInstanceResponse"/></returns>
        public CreateTmpDCDBInstanceResponse CreateTmpDCDBInstanceSync(CreateTmpDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateTmpDCDBInstanceResponse>(req, "CreateTmpDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除云数据库账号。用户名+host唯一确定一个账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount");
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除云数据库账号。用户名+host唯一确定一个账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccountPrivileges）用于查询云数据库账号权限。
        /// 注意：注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// 本接口（DescribeAccountPrivileges）用于查询云数据库账号权限。
        /// 注意：注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于查询指定云数据库实例的账号列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于查询指定云数据库实例的账号列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupFiles)用于查看备份文件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public Task<DescribeBackupFilesResponse> DescribeBackupFiles(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles");
        }

        /// <summary>
        /// 本接口(DescribeBackupFiles)用于查看备份文件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public DescribeBackupFilesResponse DescribeBackupFilesSync(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBEncryptAttributes)用于查询实例数据加密状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="DescribeDBEncryptAttributesResponse"/></returns>
        public Task<DescribeDBEncryptAttributesResponse> DescribeDBEncryptAttributes(DescribeDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<DescribeDBEncryptAttributesResponse>(req, "DescribeDBEncryptAttributes");
        }

        /// <summary>
        /// 本接口(DescribeDBEncryptAttributes)用于查询实例数据加密状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="DescribeDBEncryptAttributesResponse"/></returns>
        public DescribeDBEncryptAttributesResponse DescribeDBEncryptAttributesSync(DescribeDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<DescribeDBEncryptAttributesResponse>(req, "DescribeDBEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBLogFiles)用于获取数据库的各种日志列表，包括冷备、binlog、errlog和slowlog。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public Task<DescribeDBLogFilesResponse> DescribeDBLogFiles(DescribeDBLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeDBLogFilesResponse>(req, "DescribeDBLogFiles");
        }

        /// <summary>
        /// 本接口(DescribeDBLogFiles)用于获取数据库的各种日志列表，包括冷备、binlog、errlog和slowlog。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public DescribeDBLogFilesResponse DescribeDBLogFilesSync(DescribeDBLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeDBLogFilesResponse>(req, "DescribeDBLogFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBParameters)用于获取数据库的当前参数设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public Task<DescribeDBParametersResponse> DescribeDBParameters(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters");
        }

        /// <summary>
        /// 本接口(DescribeDBParameters)用于获取数据库的当前参数设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public DescribeDBParametersResponse DescribeDBParametersSync(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters")
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
        /// 本接口(DescribeDBSlowLogs)用于查询慢查询日志列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public Task<DescribeDBSlowLogsResponse> DescribeDBSlowLogs(DescribeDBSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowLogsResponse>(req, "DescribeDBSlowLogs");
        }

        /// <summary>
        /// 本接口(DescribeDBSlowLogs)用于查询慢查询日志列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public DescribeDBSlowLogsResponse DescribeDBSlowLogsSync(DescribeDBSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowLogsResponse>(req, "DescribeDBSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBSyncMode）用于查询云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSyncModeRequest"/></param>
        /// <returns><see cref="DescribeDBSyncModeResponse"/></returns>
        public Task<DescribeDBSyncModeResponse> DescribeDBSyncMode(DescribeDBSyncModeRequest req)
        {
            return InternalRequestAsync<DescribeDBSyncModeResponse>(req, "DescribeDBSyncMode");
        }

        /// <summary>
        /// 本接口（DescribeDBSyncMode）用于查询云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSyncModeRequest"/></param>
        /// <returns><see cref="DescribeDBSyncModeResponse"/></returns>
        public DescribeDBSyncModeResponse DescribeDBSyncModeSync(DescribeDBSyncModeRequest req)
        {
            return InternalRequestAsync<DescribeDBSyncModeResponse>(req, "DescribeDBSyncMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBTmpInstances）用于获取实例回档生成的临时实例
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public Task<DescribeDBTmpInstancesResponse> DescribeDBTmpInstances(DescribeDBTmpInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBTmpInstancesResponse>(req, "DescribeDBTmpInstances");
        }

        /// <summary>
        /// 本接口（DescribeDBTmpInstances）用于获取实例回档生成的临时实例
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public DescribeDBTmpInstancesResponse DescribeDBTmpInstancesSync(DescribeDBTmpInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBTmpInstancesResponse>(req, "DescribeDBTmpInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDCDBInstanceDetail）用于获取TDSQL实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceDetailResponse"/></returns>
        public Task<DescribeDCDBInstanceDetailResponse> DescribeDCDBInstanceDetail(DescribeDCDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceDetailResponse>(req, "DescribeDCDBInstanceDetail");
        }

        /// <summary>
        /// 本接口（DescribeDCDBInstanceDetail）用于获取TDSQL实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceDetailResponse"/></returns>
        public DescribeDCDBInstanceDetailResponse DescribeDCDBInstanceDetailSync(DescribeDCDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceDetailResponse>(req, "DescribeDCDBInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDCDBInstanceNodeInfo）用于获取实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceNodeInfoResponse"/></returns>
        public Task<DescribeDCDBInstanceNodeInfoResponse> DescribeDCDBInstanceNodeInfo(DescribeDCDBInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceNodeInfoResponse>(req, "DescribeDCDBInstanceNodeInfo");
        }

        /// <summary>
        /// 本接口（DescribeDCDBInstanceNodeInfo）用于获取实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceNodeInfoResponse"/></returns>
        public DescribeDCDBInstanceNodeInfoResponse DescribeDCDBInstanceNodeInfoSync(DescribeDCDBInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceNodeInfoResponse>(req, "DescribeDCDBInstanceNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回10条实例记录，单次请求最多支持返回100条实例记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstancesResponse"/></returns>
        public Task<DescribeDCDBInstancesResponse> DescribeDCDBInstances(DescribeDCDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstancesResponse>(req, "DescribeDCDBInstances");
        }

        /// <summary>
        /// 查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回10条实例记录，单次请求最多支持返回100条实例记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstancesResponse"/></returns>
        public DescribeDCDBInstancesResponse DescribeDCDBInstancesSync(DescribeDCDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstancesResponse>(req, "DescribeDCDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDCDBPrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBPriceResponse"/></returns>
        public Task<DescribeDCDBPriceResponse> DescribeDCDBPrice(DescribeDCDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBPriceResponse>(req, "DescribeDCDBPrice");
        }

        /// <summary>
        /// 本接口（DescribeDCDBPrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBPriceResponse"/></returns>
        public DescribeDCDBPriceResponse DescribeDCDBPriceSync(DescribeDCDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBPriceResponse>(req, "DescribeDCDBPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDCDBRenewalPrice）用于在续费分布式数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBRenewalPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBRenewalPriceResponse"/></returns>
        public Task<DescribeDCDBRenewalPriceResponse> DescribeDCDBRenewalPrice(DescribeDCDBRenewalPriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBRenewalPriceResponse>(req, "DescribeDCDBRenewalPrice");
        }

        /// <summary>
        /// 本接口（DescribeDCDBRenewalPrice）用于在续费分布式数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBRenewalPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBRenewalPriceResponse"/></returns>
        public DescribeDCDBRenewalPriceResponse DescribeDCDBRenewalPriceSync(DescribeDCDBRenewalPriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBRenewalPriceResponse>(req, "DescribeDCDBRenewalPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDCDBSaleInfo)用于查询分布式数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBSaleInfoResponse"/></returns>
        public Task<DescribeDCDBSaleInfoResponse> DescribeDCDBSaleInfo(DescribeDCDBSaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeDCDBSaleInfoResponse>(req, "DescribeDCDBSaleInfo");
        }

        /// <summary>
        /// 本接口(DescribeDCDBSaleInfo)用于查询分布式数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBSaleInfoResponse"/></returns>
        public DescribeDCDBSaleInfoResponse DescribeDCDBSaleInfoSync(DescribeDCDBSaleInfoRequest req)
        {
            return InternalRequestAsync<DescribeDCDBSaleInfoResponse>(req, "DescribeDCDBSaleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDCDBShards）用于查询云数据库实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBShardsRequest"/></param>
        /// <returns><see cref="DescribeDCDBShardsResponse"/></returns>
        public Task<DescribeDCDBShardsResponse> DescribeDCDBShards(DescribeDCDBShardsRequest req)
        {
            return InternalRequestAsync<DescribeDCDBShardsResponse>(req, "DescribeDCDBShards");
        }

        /// <summary>
        /// 本接口（DescribeDCDBShards）用于查询云数据库实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBShardsRequest"/></param>
        /// <returns><see cref="DescribeDCDBShardsResponse"/></returns>
        public DescribeDCDBShardsResponse DescribeDCDBShardsSync(DescribeDCDBShardsRequest req)
        {
            return InternalRequestAsync<DescribeDCDBShardsResponse>(req, "DescribeDCDBShards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDCDBUpgradePrice）用于查询变配分布式数据库实例价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBUpgradePriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBUpgradePriceResponse"/></returns>
        public Task<DescribeDCDBUpgradePriceResponse> DescribeDCDBUpgradePrice(DescribeDCDBUpgradePriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBUpgradePriceResponse>(req, "DescribeDCDBUpgradePrice");
        }

        /// <summary>
        /// 本接口（DescribeDCDBUpgradePrice）用于查询变配分布式数据库实例价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBUpgradePriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBUpgradePriceResponse"/></returns>
        public DescribeDCDBUpgradePriceResponse DescribeDCDBUpgradePriceSync(DescribeDCDBUpgradePriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBUpgradePriceResponse>(req, "DescribeDCDBUpgradePrice")
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
        /// 本接口（DescribeDatabaseTable）用于查询云数据库实例的表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public Task<DescribeDatabaseTableResponse> DescribeDatabaseTable(DescribeDatabaseTableRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseTableResponse>(req, "DescribeDatabaseTable");
        }

        /// <summary>
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
        /// 获取实例灾备详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public Task<DescribeDcnDetailResponse> DescribeDcnDetail(DescribeDcnDetailRequest req)
        {
            return InternalRequestAsync<DescribeDcnDetailResponse>(req, "DescribeDcnDetail");
        }

        /// <summary>
        /// 获取实例灾备详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public DescribeDcnDetailResponse DescribeDcnDetailSync(DescribeDcnDetailRequest req)
        {
            return InternalRequestAsync<DescribeDcnDetailResponse>(req, "DescribeDcnDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeFileDownloadUrl)用于获取数据库指定备份或日志文件的下载连接。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public Task<DescribeFileDownloadUrlResponse> DescribeFileDownloadUrl(DescribeFileDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeFileDownloadUrlResponse>(req, "DescribeFileDownloadUrl");
        }

        /// <summary>
        /// 本接口(DescribeFileDownloadUrl)用于获取数据库指定备份或日志文件的下载连接。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public DescribeFileDownloadUrlResponse DescribeFileDownloadUrlSync(DescribeFileDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeFileDownloadUrlResponse>(req, "DescribeFileDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询流程状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow");
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询流程状态
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeLogFileRetentionPeriod)用于查看数据库备份日志的备份天数的设置情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="DescribeLogFileRetentionPeriodResponse"/></returns>
        public Task<DescribeLogFileRetentionPeriodResponse> DescribeLogFileRetentionPeriod(DescribeLogFileRetentionPeriodRequest req)
        {
            return InternalRequestAsync<DescribeLogFileRetentionPeriodResponse>(req, "DescribeLogFileRetentionPeriod");
        }

        /// <summary>
        /// 本接口(DescribeLogFileRetentionPeriod)用于查看数据库备份日志的备份天数的设置情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="DescribeLogFileRetentionPeriodResponse"/></returns>
        public DescribeLogFileRetentionPeriodResponse DescribeLogFileRetentionPeriodSync(DescribeLogFileRetentionPeriodRequest req)
        {
            return InternalRequestAsync<DescribeLogFileRetentionPeriodResponse>(req, "DescribeLogFileRetentionPeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询分布式数据库订单信息。传入订单ID来查询订单关联的分布式数据库实例，和对应的任务流程ID。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询分布式数据库订单信息。传入订单ID来查询订单关联的分布式数据库实例，和对应的任务流程ID。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProjectSecurityGroups）用于查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// 本接口（DescribeProjectSecurityGroups）用于查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProjects）用于查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 本接口（DescribeProjects）用于查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可创建的分布式数据库可售卖的分片规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeShardSpecRequest"/></param>
        /// <returns><see cref="DescribeShardSpecResponse"/></returns>
        public Task<DescribeShardSpecResponse> DescribeShardSpec(DescribeShardSpecRequest req)
        {
            return InternalRequestAsync<DescribeShardSpecResponse>(req, "DescribeShardSpec");
        }

        /// <summary>
        /// 查询可创建的分布式数据库可售卖的分片规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeShardSpecRequest"/></param>
        /// <returns><see cref="DescribeShardSpecResponse"/></returns>
        public DescribeShardSpecResponse DescribeShardSpecSync(DescribeShardSpecRequest req)
        {
            return InternalRequestAsync<DescribeShardSpecResponse>(req, "DescribeShardSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUserTasks）用于拉取用户任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTasksRequest"/></param>
        /// <returns><see cref="DescribeUserTasksResponse"/></returns>
        public Task<DescribeUserTasksResponse> DescribeUserTasks(DescribeUserTasksRequest req)
        {
            return InternalRequestAsync<DescribeUserTasksResponse>(req, "DescribeUserTasks");
        }

        /// <summary>
        /// 本接口（DescribeUserTasks）用于拉取用户任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTasksRequest"/></param>
        /// <returns><see cref="DescribeUserTasksResponse"/></returns>
        public DescribeUserTasksResponse DescribeUserTasksSync(DescribeUserTasksRequest req)
        {
            return InternalRequestAsync<DescribeUserTasksResponse>(req, "DescribeUserTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DestroyDCDBInstance)用于销毁已隔离的TDSQL包年包月实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDCDBInstanceResponse"/></returns>
        public Task<DestroyDCDBInstanceResponse> DestroyDCDBInstance(DestroyDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDCDBInstanceResponse>(req, "DestroyDCDBInstance");
        }

        /// <summary>
        /// 本接口(DestroyDCDBInstance)用于销毁已隔离的TDSQL包年包月实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDCDBInstanceResponse"/></returns>
        public DestroyDCDBInstanceResponse DestroyDCDBInstanceSync(DestroyDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDCDBInstanceResponse>(req, "DestroyDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DestroyHourDCDBInstance）用于TDSQL销毁按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDCDBInstanceResponse"/></returns>
        public Task<DestroyHourDCDBInstanceResponse> DestroyHourDCDBInstance(DestroyHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyHourDCDBInstanceResponse>(req, "DestroyHourDCDBInstance");
        }

        /// <summary>
        /// 本接口（DestroyHourDCDBInstance）用于TDSQL销毁按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDCDBInstanceResponse"/></returns>
        public DestroyHourDCDBInstanceResponse DestroyHourDCDBInstanceSync(DestroyHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyHourDCDBInstanceResponse>(req, "DestroyHourDCDBInstance")
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
        /// 相当于在所有分片的mysqld中执行flush logs，完成切分的binlog将展示在各个分片控制台binlog列表里。
        /// </summary>
        /// <param name="req"><see cref="FlushBinlogRequest"/></param>
        /// <returns><see cref="FlushBinlogResponse"/></returns>
        public Task<FlushBinlogResponse> FlushBinlog(FlushBinlogRequest req)
        {
            return InternalRequestAsync<FlushBinlogResponse>(req, "FlushBinlog");
        }

        /// <summary>
        /// 相当于在所有分片的mysqld中执行flush logs，完成切分的binlog将展示在各个分片控制台binlog列表里。
        /// </summary>
        /// <param name="req"><see cref="FlushBinlogRequest"/></param>
        /// <returns><see cref="FlushBinlogResponse"/></returns>
        public FlushBinlogResponse FlushBinlogSync(FlushBinlogRequest req)
        {
            return InternalRequestAsync<FlushBinlogResponse>(req, "FlushBinlog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GrantAccountPrivileges）用于给云数据库账号赋权。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public Task<GrantAccountPrivilegesResponse> GrantAccountPrivileges(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges");
        }

        /// <summary>
        /// 本接口（GrantAccountPrivileges）用于给云数据库账号赋权。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public GrantAccountPrivilegesResponse GrantAccountPrivilegesSync(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(InitDCDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req"><see cref="InitDCDBInstancesRequest"/></param>
        /// <returns><see cref="InitDCDBInstancesResponse"/></returns>
        public Task<InitDCDBInstancesResponse> InitDCDBInstances(InitDCDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDCDBInstancesResponse>(req, "InitDCDBInstances");
        }

        /// <summary>
        /// 本接口(InitDCDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req"><see cref="InitDCDBInstancesRequest"/></param>
        /// <returns><see cref="InitDCDBInstancesResponse"/></returns>
        public InitDCDBInstancesResponse InitDCDBInstancesSync(InitDCDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDCDBInstancesResponse>(req, "InitDCDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(IsolateDCDBInstance)用于隔离分布式数据库TDSQL实例（包年包月），隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
        /// </summary>
        /// <param name="req"><see cref="IsolateDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDCDBInstanceResponse"/></returns>
        public Task<IsolateDCDBInstanceResponse> IsolateDCDBInstance(IsolateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDCDBInstanceResponse>(req, "IsolateDCDBInstance");
        }

        /// <summary>
        /// 本接口(IsolateDCDBInstance)用于隔离分布式数据库TDSQL实例（包年包月），隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
        /// </summary>
        /// <param name="req"><see cref="IsolateDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDCDBInstanceResponse"/></returns>
        public IsolateDCDBInstanceResponse IsolateDCDBInstanceSync(IsolateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDCDBInstanceResponse>(req, "IsolateDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（IsolateDedicatedDBInstance）用于隔离独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDedicatedDBInstanceResponse"/></returns>
        public Task<IsolateDedicatedDBInstanceResponse> IsolateDedicatedDBInstance(IsolateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDedicatedDBInstanceResponse>(req, "IsolateDedicatedDBInstance");
        }

        /// <summary>
        /// 本接口（IsolateDedicatedDBInstance）用于隔离独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDedicatedDBInstanceResponse"/></returns>
        public IsolateDedicatedDBInstanceResponse IsolateDedicatedDBInstanceSync(IsolateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDedicatedDBInstanceResponse>(req, "IsolateDedicatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 隔离TDSQL按量计费实例
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDCDBInstanceResponse"/></returns>
        public Task<IsolateHourDCDBInstanceResponse> IsolateHourDCDBInstance(IsolateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateHourDCDBInstanceResponse>(req, "IsolateHourDCDBInstance");
        }

        /// <summary>
        /// 隔离TDSQL按量计费实例
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDCDBInstanceResponse"/></returns>
        public IsolateHourDCDBInstanceResponse IsolateHourDCDBInstanceSync(IsolateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateHourDCDBInstanceResponse>(req, "IsolateHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（KillSession）用于杀死指定会话。
        /// </summary>
        /// <param name="req"><see cref="KillSessionRequest"/></param>
        /// <returns><see cref="KillSessionResponse"/></returns>
        public Task<KillSessionResponse> KillSession(KillSessionRequest req)
        {
            return InternalRequestAsync<KillSessionResponse>(req, "KillSession");
        }

        /// <summary>
        /// 本接口（KillSession）用于杀死指定会话。
        /// </summary>
        /// <param name="req"><see cref="KillSessionRequest"/></param>
        /// <returns><see cref="KillSessionResponse"/></returns>
        public KillSessionResponse KillSessionSync(KillSessionRequest req)
        {
            return InternalRequestAsync<KillSessionResponse>(req, "KillSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改账号的一些配置，比如 max_user_connections
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountConfigRequest"/></param>
        /// <returns><see cref="ModifyAccountConfigResponse"/></returns>
        public Task<ModifyAccountConfigResponse> ModifyAccountConfig(ModifyAccountConfigRequest req)
        {
            return InternalRequestAsync<ModifyAccountConfigResponse>(req, "ModifyAccountConfig");
        }

        /// <summary>
        /// 修改账号的一些配置，比如 max_user_connections
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountConfigRequest"/></param>
        /// <returns><see cref="ModifyAccountConfigResponse"/></returns>
        public ModifyAccountConfigResponse ModifyAccountConfigSync(ModifyAccountConfigRequest req)
        {
            return InternalRequestAsync<ModifyAccountConfigResponse>(req, "ModifyAccountConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAccountDescription）用于修改云数据库账号备注。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription");
        }

        /// <summary>
        /// 本接口（ModifyAccountDescription）用于修改云数据库账号备注。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAccountPrivileges)用于修改云数据库的账户的权限信息。
        /// 
        /// **注意**
        /// - 系统保留库："mysql"，只开放["SELECT"]权限
        /// - 只读账号授予读写权限会报错
        /// - 不传权限参数表示保留现有权限，如需清除，请在复杂类型Privileges字段传空数组
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// 本接口(ModifyAccountPrivileges)用于修改云数据库的账户的权限信息。
        /// 
        /// **注意**
        /// - 系统保留库："mysql"，只开放["SELECT"]权限
        /// - 只读账号授予读写权限会报错
        /// - 不传权限参数表示保留现有权限，如需清除，请在复杂类型Privileges字段传空数组
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBEncryptAttributes)用于修改实例数据加密。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public Task<ModifyDBEncryptAttributesResponse> ModifyDBEncryptAttributes(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes");
        }

        /// <summary>
        /// 本接口(ModifyDBEncryptAttributes)用于修改实例数据加密。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public ModifyDBEncryptAttributesResponse ModifyDBEncryptAttributesSync(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改实例名字
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改实例名字
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
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
        /// 本接口（ModifyDBInstancesProject）用于修改云数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject");
        }

        /// <summary>
        /// 本接口（ModifyDBInstancesProject）用于修改云数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBParameters)用于修改数据库参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters");
        }

        /// <summary>
        /// 本接口(ModifyDBParameters)用于修改数据库参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public ModifyDBParametersResponse ModifyDBParametersSync(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBSyncMode）用于修改云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public Task<ModifyDBSyncModeResponse> ModifyDBSyncMode(ModifyDBSyncModeRequest req)
        {
            return InternalRequestAsync<ModifyDBSyncModeResponse>(req, "ModifyDBSyncMode");
        }

        /// <summary>
        /// 本接口（ModifyDBSyncMode）用于修改云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public ModifyDBSyncModeResponse ModifyDBSyncModeSync(ModifyDBSyncModeRequest req)
        {
            return InternalRequestAsync<ModifyDBSyncModeResponse>(req, "ModifyDBSyncMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceNetwork）用于修改实例所属网络。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public Task<ModifyInstanceNetworkResponse> ModifyInstanceNetwork(ModifyInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNetworkResponse>(req, "ModifyInstanceNetwork");
        }

        /// <summary>
        /// 本接口（ModifyInstanceNetwork）用于修改实例所属网络。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public ModifyInstanceNetworkResponse ModifyInstanceNetworkSync(ModifyInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNetworkResponse>(req, "ModifyInstanceNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceVip）用于修改实例Vip
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVipRequest"/></param>
        /// <returns><see cref="ModifyInstanceVipResponse"/></returns>
        public Task<ModifyInstanceVipResponse> ModifyInstanceVip(ModifyInstanceVipRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVipResponse>(req, "ModifyInstanceVip");
        }

        /// <summary>
        /// 本接口（ModifyInstanceVip）用于修改实例Vip
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVipRequest"/></param>
        /// <returns><see cref="ModifyInstanceVipResponse"/></returns>
        public ModifyInstanceVipResponse ModifyInstanceVipSync(ModifyInstanceVipRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVipResponse>(req, "ModifyInstanceVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceVport）用于修改实例VPORT
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVportRequest"/></param>
        /// <returns><see cref="ModifyInstanceVportResponse"/></returns>
        public Task<ModifyInstanceVportResponse> ModifyInstanceVport(ModifyInstanceVportRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVportResponse>(req, "ModifyInstanceVport");
        }

        /// <summary>
        /// 本接口（ModifyInstanceVport）用于修改实例VPORT
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVportRequest"/></param>
        /// <returns><see cref="ModifyInstanceVportResponse"/></returns>
        public ModifyInstanceVportResponse ModifyInstanceVportSync(ModifyInstanceVportRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVportResponse>(req, "ModifyInstanceVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyRealServerAccessStrategy)用于修改云数据库的VPCGW到RS的访问策略。
        /// 
        /// **注意**
        /// - 修改策略后只对新建立的连接生效，老连接不受影响
        /// - 就近访问只针对实例是跨可用区部署有用，单可用区部署实例就近与否并无作用
        /// - DB每个Node对应一个proxy，如果开启就近访问，将会把连接集中到对应可用区的proxy上，可能造成热点问题，这种情况下如果是线上业务，请务必根据自己的业务请求量测试符合预期后再进行就近策略变更
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerAccessStrategyRequest"/></param>
        /// <returns><see cref="ModifyRealServerAccessStrategyResponse"/></returns>
        public Task<ModifyRealServerAccessStrategyResponse> ModifyRealServerAccessStrategy(ModifyRealServerAccessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyRealServerAccessStrategyResponse>(req, "ModifyRealServerAccessStrategy");
        }

        /// <summary>
        /// 本接口(ModifyRealServerAccessStrategy)用于修改云数据库的VPCGW到RS的访问策略。
        /// 
        /// **注意**
        /// - 修改策略后只对新建立的连接生效，老连接不受影响
        /// - 就近访问只针对实例是跨可用区部署有用，单可用区部署实例就近与否并无作用
        /// - DB每个Node对应一个proxy，如果开启就近访问，将会把连接集中到对应可用区的proxy上，可能造成热点问题，这种情况下如果是线上业务，请务必根据自己的业务请求量测试符合预期后再进行就近策略变更
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerAccessStrategyRequest"/></param>
        /// <returns><see cref="ModifyRealServerAccessStrategyResponse"/></returns>
        public ModifyRealServerAccessStrategyResponse ModifyRealServerAccessStrategySync(ModifyRealServerAccessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyRealServerAccessStrategyResponse>(req, "ModifyRealServerAccessStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通云数据库实例的外网访问。开通外网访问后，您可通过外网域名和端口访问实例，可使用查询实例列表接口获取外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public Task<OpenDBExtranetAccessResponse> OpenDBExtranetAccess(OpenDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenDBExtranetAccessResponse>(req, "OpenDBExtranetAccess");
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通云数据库实例的外网访问。开通外网访问后，您可通过外网域名和端口访问实例，可使用查询实例列表接口获取外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public OpenDBExtranetAccessResponse OpenDBExtranetAccessSync(OpenDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenDBExtranetAccessResponse>(req, "OpenDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RenewDCDBInstance）用于续费分布式数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDCDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDCDBInstanceResponse"/></returns>
        public Task<RenewDCDBInstanceResponse> RenewDCDBInstance(RenewDCDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDCDBInstanceResponse>(req, "RenewDCDBInstance");
        }

        /// <summary>
        /// 本接口（RenewDCDBInstance）用于续费分布式数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDCDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDCDBInstanceResponse"/></returns>
        public RenewDCDBInstanceResponse RenewDCDBInstanceSync(RenewDCDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDCDBInstanceResponse>(req, "RenewDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置云数据库账号的密码。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置云数据库账号的密码。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SwitchDBInstanceHA)用于实例主备切换。
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceHARequest"/></param>
        /// <returns><see cref="SwitchDBInstanceHAResponse"/></returns>
        public Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHA(SwitchDBInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceHAResponse>(req, "SwitchDBInstanceHA");
        }

        /// <summary>
        /// 本接口(SwitchDBInstanceHA)用于实例主备切换。
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceHARequest"/></param>
        /// <returns><see cref="SwitchDBInstanceHAResponse"/></returns>
        public SwitchDBInstanceHAResponse SwitchDBInstanceHASync(SwitchDBInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceHAResponse>(req, "SwitchDBInstanceHA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TerminateDedicatedDBInstance）用于销毁已隔离的独享分布式数据库实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public Task<TerminateDedicatedDBInstanceResponse> TerminateDedicatedDBInstance(TerminateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDedicatedDBInstanceResponse>(req, "TerminateDedicatedDBInstance");
        }

        /// <summary>
        /// 本接口（TerminateDedicatedDBInstance）用于销毁已隔离的独享分布式数据库实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public TerminateDedicatedDBInstanceResponse TerminateDedicatedDBInstanceSync(TerminateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDedicatedDBInstanceResponse>(req, "TerminateDedicatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeDCDBInstance）用于升级分布式数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDCDBInstanceResponse"/></returns>
        public Task<UpgradeDCDBInstanceResponse> UpgradeDCDBInstance(UpgradeDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDCDBInstanceResponse>(req, "UpgradeDCDBInstance");
        }

        /// <summary>
        /// 本接口（UpgradeDCDBInstance）用于升级分布式数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDCDBInstanceResponse"/></returns>
        public UpgradeDCDBInstanceResponse UpgradeDCDBInstanceSync(UpgradeDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDCDBInstanceResponse>(req, "UpgradeDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeDedicatedDCDBInstance）用于升级TDSQL独享集群实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDCDBInstanceResponse"/></returns>
        public Task<UpgradeDedicatedDCDBInstanceResponse> UpgradeDedicatedDCDBInstance(UpgradeDedicatedDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDedicatedDCDBInstanceResponse>(req, "UpgradeDedicatedDCDBInstance");
        }

        /// <summary>
        /// 本接口（UpgradeDedicatedDCDBInstance）用于升级TDSQL独享集群实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDCDBInstanceResponse"/></returns>
        public UpgradeDedicatedDCDBInstanceResponse UpgradeDedicatedDCDBInstanceSync(UpgradeDedicatedDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDedicatedDCDBInstanceResponse>(req, "UpgradeDedicatedDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeHourDCDBInstance）用于升级分布式数据库TDSQL按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="UpgradeHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeHourDCDBInstanceResponse"/></returns>
        public Task<UpgradeHourDCDBInstanceResponse> UpgradeHourDCDBInstance(UpgradeHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeHourDCDBInstanceResponse>(req, "UpgradeHourDCDBInstance");
        }

        /// <summary>
        /// 本接口（UpgradeHourDCDBInstance）用于升级分布式数据库TDSQL按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="UpgradeHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeHourDCDBInstanceResponse"/></returns>
        public UpgradeHourDCDBInstanceResponse UpgradeHourDCDBInstanceSync(UpgradeHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeHourDCDBInstanceResponse>(req, "UpgradeHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
