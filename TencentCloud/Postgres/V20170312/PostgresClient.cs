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

namespace TencentCloud.Postgres.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Postgres.V20170312.Models;

   public class PostgresClient : AbstractClient{

       private const string endpoint = "postgres.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.985";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PostgresClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PostgresClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（AddDBInstanceToReadOnlyGroup）用于添加只读实例到只读组
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public Task<AddDBInstanceToReadOnlyGroupResponse> AddDBInstanceToReadOnlyGroup(AddDBInstanceToReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<AddDBInstanceToReadOnlyGroupResponse>(req, "AddDBInstanceToReadOnlyGroup");
        }

        /// <summary>
        /// 本接口（AddDBInstanceToReadOnlyGroup）用于添加只读实例到只读组
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public AddDBInstanceToReadOnlyGroupResponse AddDBInstanceToReadOnlyGroupSync(AddDBInstanceToReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<AddDBInstanceToReadOnlyGroupResponse>(req, "AddDBInstanceToReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于克隆实例，支持指定备份集、指定时间点进行克隆。
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public Task<CloneDBInstanceResponse> CloneDBInstance(CloneDBInstanceRequest req)
        {
            return InternalRequestAsync<CloneDBInstanceResponse>(req, "CloneDBInstance");
        }

        /// <summary>
        /// 用于克隆实例，支持指定备份集、指定时间点进行克隆。
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public CloneDBInstanceResponse CloneDBInstanceSync(CloneDBInstanceRequest req)
        {
            return InternalRequestAsync<CloneDBInstanceResponse>(req, "CloneDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloseDBExtranetAccess）用于关闭实例公网地址。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess");
        }

        /// <summary>
        /// 本接口（CloseDBExtranetAccess）用于关闭实例公网地址。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloseServerlessDBExtranetAccess）用于关闭serverlessDB实例公网地址
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public Task<CloseServerlessDBExtranetAccessResponse> CloseServerlessDBExtranetAccess(CloseServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseServerlessDBExtranetAccessResponse>(req, "CloseServerlessDBExtranetAccess");
        }

        /// <summary>
        /// 本接口（CloseServerlessDBExtranetAccess）用于关闭serverlessDB实例公网地址
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public CloseServerlessDBExtranetAccessResponse CloseServerlessDBExtranetAccessSync(CloseServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseServerlessDBExtranetAccessResponse>(req, "CloseServerlessDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateBaseBackup）用于创建实例的数据备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public Task<CreateBaseBackupResponse> CreateBaseBackup(CreateBaseBackupRequest req)
        {
            return InternalRequestAsync<CreateBaseBackupResponse>(req, "CreateBaseBackup");
        }

        /// <summary>
        /// 本接口（CreateBaseBackup）用于创建实例的数据备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public CreateBaseBackupResponse CreateBaseBackupSync(CreateBaseBackupRequest req)
        {
            return InternalRequestAsync<CreateBaseBackupResponse>(req, "CreateBaseBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDBInstanceNetworkAccess）用于创建实例网络。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public Task<CreateDBInstanceNetworkAccessResponse> CreateDBInstanceNetworkAccess(CreateDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceNetworkAccessResponse>(req, "CreateDBInstanceNetworkAccess");
        }

        /// <summary>
        /// 本接口（CreateDBInstanceNetworkAccess）用于创建实例网络。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public CreateDBInstanceNetworkAccessResponse CreateDBInstanceNetworkAccessSync(CreateDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceNetworkAccessResponse>(req, "CreateDBInstanceNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建一个或者多个PostgreSQL实例,仅发货实例不会进行初始化。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances");
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建一个或者多个PostgreSQL实例,仅发货实例不会进行初始化。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateInstances) 用于创建一个或者多个PostgreSQL实例，通过此接口创建的实例无需进行初始化，可直接使用。
        /// <li>实例创建成功后将自动开机启动，实例状态变为“运行中”。
        /// <li>预付费实例的购买会预先扣除本次实例购买所需金额，按小时后付费实例购买会预先冻结本次实例购买一小时内所需金额，在调用本接口前请确保账户余额充足。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// 本接口 (CreateInstances) 用于创建一个或者多个PostgreSQL实例，通过此接口创建的实例无需进行初始化，可直接使用。
        /// <li>实例创建成功后将自动开机启动，实例状态变为“运行中”。
        /// <li>预付费实例的购买会预先扣除本次实例购买所需金额，按小时后付费实例购买会预先冻结本次实例购买一小时内所需金额，在调用本接口前请确保账户余额充足。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateParameterTemplate) 用于创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public Task<CreateParameterTemplateResponse> CreateParameterTemplate(CreateParameterTemplateRequest req)
        {
            return InternalRequestAsync<CreateParameterTemplateResponse>(req, "CreateParameterTemplate");
        }

        /// <summary>
        /// 本接口 (CreateParameterTemplate) 用于创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public CreateParameterTemplateResponse CreateParameterTemplateSync(CreateParameterTemplateRequest req)
        {
            return InternalRequestAsync<CreateParameterTemplateResponse>(req, "CreateParameterTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateReadOnlyDBInstance)用于创建只读实例
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstance(CreateReadOnlyDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstanceResponse>(req, "CreateReadOnlyDBInstance");
        }

        /// <summary>
        /// 本接口(CreateReadOnlyDBInstance)用于创建只读实例
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstanceSync(CreateReadOnlyDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstanceResponse>(req, "CreateReadOnlyDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroup）用于创建只读组
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public Task<CreateReadOnlyGroupResponse> CreateReadOnlyGroup(CreateReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupResponse>(req, "CreateReadOnlyGroup");
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroup）用于创建只读组
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public CreateReadOnlyGroupResponse CreateReadOnlyGroupSync(CreateReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupResponse>(req, "CreateReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroupNetworkAccess）用于创建RO组的网络。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public Task<CreateReadOnlyGroupNetworkAccessResponse> CreateReadOnlyGroupNetworkAccess(CreateReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupNetworkAccessResponse>(req, "CreateReadOnlyGroupNetworkAccess");
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroupNetworkAccess）用于创建RO组的网络。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public CreateReadOnlyGroupNetworkAccessResponse CreateReadOnlyGroupNetworkAccessSync(CreateReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyGroupNetworkAccessResponse>(req, "CreateReadOnlyGroupNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateServerlessDBInstance) 用于创建一个ServerlessDB实例，创建成功返回实例ID。
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public Task<CreateServerlessDBInstanceResponse> CreateServerlessDBInstance(CreateServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateServerlessDBInstanceResponse>(req, "CreateServerlessDBInstance");
        }

        /// <summary>
        /// 本接口 (CreateServerlessDBInstance) 用于创建一个ServerlessDB实例，创建成功返回实例ID。
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public CreateServerlessDBInstanceResponse CreateServerlessDBInstanceSync(CreateServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateServerlessDBInstanceResponse>(req, "CreateServerlessDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteBaseBackup）用于删除实例指定数据备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public Task<DeleteBaseBackupResponse> DeleteBaseBackup(DeleteBaseBackupRequest req)
        {
            return InternalRequestAsync<DeleteBaseBackupResponse>(req, "DeleteBaseBackup");
        }

        /// <summary>
        /// 本接口（DeleteBaseBackup）用于删除实例指定数据备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public DeleteBaseBackupResponse DeleteBaseBackupSync(DeleteBaseBackupRequest req)
        {
            return InternalRequestAsync<DeleteBaseBackupResponse>(req, "DeleteBaseBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可对实例进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public Task<DeleteDBInstanceNetworkAccessResponse> DeleteDBInstanceNetworkAccess(DeleteDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceNetworkAccessResponse>(req, "DeleteDBInstanceNetworkAccess");
        }

        /// <summary>
        /// 可对实例进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public DeleteDBInstanceNetworkAccessResponse DeleteDBInstanceNetworkAccessSync(DeleteDBInstanceNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceNetworkAccessResponse>(req, "DeleteDBInstanceNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteLogBackup）用于删除实例指定日志备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public Task<DeleteLogBackupResponse> DeleteLogBackup(DeleteLogBackupRequest req)
        {
            return InternalRequestAsync<DeleteLogBackupResponse>(req, "DeleteLogBackup");
        }

        /// <summary>
        /// 本接口（DeleteLogBackup）用于删除实例指定日志备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public DeleteLogBackupResponse DeleteLogBackupSync(DeleteLogBackupRequest req)
        {
            return InternalRequestAsync<DeleteLogBackupResponse>(req, "DeleteLogBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteParameterTemplate）主要用于删除某个参数模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public Task<DeleteParameterTemplateResponse> DeleteParameterTemplate(DeleteParameterTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParameterTemplateResponse>(req, "DeleteParameterTemplate");
        }

        /// <summary>
        /// 本接口（DeleteParameterTemplate）主要用于删除某个参数模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public DeleteParameterTemplateResponse DeleteParameterTemplateSync(DeleteParameterTemplateRequest req)
        {
            return InternalRequestAsync<DeleteParameterTemplateResponse>(req, "DeleteParameterTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteReadOnlyGroup)用于删除指定的只读组
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public Task<DeleteReadOnlyGroupResponse> DeleteReadOnlyGroup(DeleteReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupResponse>(req, "DeleteReadOnlyGroup");
        }

        /// <summary>
        /// 本接口(DeleteReadOnlyGroup)用于删除指定的只读组
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public DeleteReadOnlyGroupResponse DeleteReadOnlyGroupSync(DeleteReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupResponse>(req, "DeleteReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可对RO组进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public Task<DeleteReadOnlyGroupNetworkAccessResponse> DeleteReadOnlyGroupNetworkAccess(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupNetworkAccessResponse>(req, "DeleteReadOnlyGroupNetworkAccess");
        }

        /// <summary>
        /// 可对RO组进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public DeleteReadOnlyGroupNetworkAccessResponse DeleteReadOnlyGroupNetworkAccessSync(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
            return InternalRequestAsync<DeleteReadOnlyGroupNetworkAccessResponse>(req, "DeleteReadOnlyGroupNetworkAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteServerlessDBInstance) 用于删除一个ServerlessDB实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public Task<DeleteServerlessDBInstanceResponse> DeleteServerlessDBInstance(DeleteServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteServerlessDBInstanceResponse>(req, "DeleteServerlessDBInstance");
        }

        /// <summary>
        /// 本接口 (DeleteServerlessDBInstance) 用于删除一个ServerlessDB实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public DeleteServerlessDBInstanceResponse DeleteServerlessDBInstanceSync(DeleteServerlessDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteServerlessDBInstanceResponse>(req, "DeleteServerlessDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于查询实例的数据库账号列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于查询实例的数据库账号列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAvailableRecoveryTime）用于查询实例可恢复的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTime(DescribeAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeAvailableRecoveryTimeResponse>(req, "DescribeAvailableRecoveryTime");
        }

        /// <summary>
        /// 本接口（DescribeAvailableRecoveryTime）用于查询实例可恢复的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTimeSync(DescribeAvailableRecoveryTimeRequest req)
        {
            return InternalRequestAsync<DescribeAvailableRecoveryTimeResponse>(req, "DescribeAvailableRecoveryTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadRestriction）用于查询备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction");
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadRestriction）用于查询备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadRestrictionResponse>(req, "DescribeBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeBackupDownloadURL) 用于查询指定备份集的下载地址，可包括全量备份集、增量日志备份集。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public Task<DescribeBackupDownloadURLResponse> DescribeBackupDownloadURL(DescribeBackupDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadURLResponse>(req, "DescribeBackupDownloadURL");
        }

        /// <summary>
        /// 本接口 (DescribeBackupDownloadURL) 用于查询指定备份集的下载地址，可包括全量备份集、增量日志备份集。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public DescribeBackupDownloadURLResponse DescribeBackupDownloadURLSync(DescribeBackupDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadURLResponse>(req, "DescribeBackupDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupOverview）用于查询用户的备份概览信息。返回用户当前备份个数、备份占用容量、免费容量、收费容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public Task<DescribeBackupOverviewResponse> DescribeBackupOverview(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview");
        }

        /// <summary>
        /// 本接口（DescribeBackupOverview）用于查询用户的备份概览信息。返回用户当前备份个数、备份占用容量、免费容量、收费容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public DescribeBackupOverviewResponse DescribeBackupOverviewSync(DescribeBackupOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBackupOverviewResponse>(req, "DescribeBackupOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeBackupPlans) 用于实例所有的备份计划查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public Task<DescribeBackupPlansResponse> DescribeBackupPlans(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans");
        }

        /// <summary>
        /// 本接口 (DescribeBackupPlans) 用于实例所有的备份计划查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public DescribeBackupPlansResponse DescribeBackupPlansSync(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupSummaries)用于查询实例备份的统计信息，返回以实例为维度的备份个数、占用容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public Task<DescribeBackupSummariesResponse> DescribeBackupSummaries(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries");
        }

        /// <summary>
        /// 本接口(DescribeBackupSummaries)用于查询实例备份的统计信息，返回以实例为维度的备份个数、占用容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public DescribeBackupSummariesResponse DescribeBackupSummariesSync(DescribeBackupSummariesRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummariesResponse>(req, "DescribeBackupSummaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBaseBackups）用于查询数据备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public Task<DescribeBaseBackupsResponse> DescribeBaseBackups(DescribeBaseBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBaseBackupsResponse>(req, "DescribeBaseBackups");
        }

        /// <summary>
        /// 本接口（DescribeBaseBackups）用于查询数据备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public DescribeBaseBackupsResponse DescribeBaseBackupsSync(DescribeBaseBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBaseBackupsResponse>(req, "DescribeBaseBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClasses）用于查询实例售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public Task<DescribeClassesResponse> DescribeClasses(DescribeClassesRequest req)
        {
            return InternalRequestAsync<DescribeClassesResponse>(req, "DescribeClasses");
        }

        /// <summary>
        /// 本接口（DescribeClasses）用于查询实例售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public DescribeClassesResponse DescribeClassesSync(DescribeClassesRequest req)
        {
            return InternalRequestAsync<DescribeClassesResponse>(req, "DescribeClasses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCloneDBInstanceSpec）用于查询克隆实例可选择的最小规格，包括SpecCode和磁盘。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public Task<DescribeCloneDBInstanceSpecResponse> DescribeCloneDBInstanceSpec(DescribeCloneDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<DescribeCloneDBInstanceSpecResponse>(req, "DescribeCloneDBInstanceSpec");
        }

        /// <summary>
        /// 本接口（DescribeCloneDBInstanceSpec）用于查询克隆实例可选择的最小规格，包括SpecCode和磁盘。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public DescribeCloneDBInstanceSpecResponse DescribeCloneDBInstanceSpecSync(DescribeCloneDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<DescribeCloneDBInstanceSpecResponse>(req, "DescribeCloneDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBBackups）用于查询实例备份列表。本接口已废弃，推荐使用接口[DescribeBaseBackups](https://cloud.tencent.com/document/api/409/89022)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public Task<DescribeDBBackupsResponse> DescribeDBBackups(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups");
        }

        /// <summary>
        /// 本接口（DescribeDBBackups）用于查询实例备份列表。本接口已废弃，推荐使用接口[DescribeBaseBackups](https://cloud.tencent.com/document/api/409/89022)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public DescribeDBBackupsResponse DescribeDBBackupsSync(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBErrlogs）用于查询错误日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public Task<DescribeDBErrlogsResponse> DescribeDBErrlogs(DescribeDBErrlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBErrlogsResponse>(req, "DescribeDBErrlogs");
        }

        /// <summary>
        /// 本接口（DescribeDBErrlogs）用于查询错误日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public DescribeDBErrlogsResponse DescribeDBErrlogsSync(DescribeDBErrlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBErrlogsResponse>(req, "DescribeDBErrlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeDBInstanceAttribute) 用于查询某个实例的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceAttributeResponse>(req, "DescribeDBInstanceAttribute");
        }

        /// <summary>
        /// 本接口 (DescribeDBInstanceAttribute) 用于查询某个实例的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeSync(DescribeDBInstanceAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceAttributeResponse>(req, "DescribeDBInstanceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceHAConfig）用于查询实例HA配置信息。其中HA配置信息包括：
        /// <li>允许备节点切换为主节点的条件配置
        /// <li>半同步实例使用同步复制或异步复制的条件配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceHAConfigResponse"/></returns>
        public Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfig(DescribeDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceHAConfigResponse>(req, "DescribeDBInstanceHAConfig");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceHAConfig）用于查询实例HA配置信息。其中HA配置信息包括：
        /// <li>允许备节点切换为主节点的条件配置
        /// <li>半同步实例使用同步复制或异步复制的条件配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceHAConfigResponse"/></returns>
        public DescribeDBInstanceHAConfigResponse DescribeDBInstanceHAConfigSync(DescribeDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceHAConfigResponse>(req, "DescribeDBInstanceHAConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceAttribute）用于查询实例的参数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public Task<DescribeDBInstanceParametersResponse> DescribeDBInstanceParameters(DescribeDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParametersResponse>(req, "DescribeDBInstanceParameters");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceAttribute）用于查询实例的参数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public DescribeDBInstanceParametersResponse DescribeDBInstanceParametersSync(DescribeDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParametersResponse>(req, "DescribeDBInstanceParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceSecurityGroups）用于查询实例安全组。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public Task<DescribeDBInstanceSecurityGroupsResponse> DescribeDBInstanceSecurityGroups(DescribeDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceSecurityGroupsResponse>(req, "DescribeDBInstanceSecurityGroups");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceSecurityGroups）用于查询实例安全组。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public DescribeDBInstanceSecurityGroupsResponse DescribeDBInstanceSecurityGroupsSync(DescribeDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceSecurityGroupsResponse>(req, "DescribeDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeDBInstances) 用于查询一个或多个实例的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// 本接口 (DescribeDBInstances) 用于查询一个或多个实例的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBSlowlogs）用于获取慢查询日志。本接口已于2021.09.01日废弃，后续此接口将不再返回任何数据，推荐使用接口[DescribeSlowQueryList](https://cloud.tencent.com/document/api/409/60540)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public Task<DescribeDBSlowlogsResponse> DescribeDBSlowlogs(DescribeDBSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowlogsResponse>(req, "DescribeDBSlowlogs");
        }

        /// <summary>
        /// 本接口（DescribeDBSlowlogs）用于获取慢查询日志。本接口已于2021.09.01日废弃，后续此接口将不再返回任何数据，推荐使用接口[DescribeSlowQueryList](https://cloud.tencent.com/document/api/409/60540)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public DescribeDBSlowlogsResponse DescribeDBSlowlogsSync(DescribeDBSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowlogsResponse>(req, "DescribeDBSlowlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBVersions）用于查询支持的数据库版本。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public Task<DescribeDBVersionsResponse> DescribeDBVersions(DescribeDBVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDBVersionsResponse>(req, "DescribeDBVersions");
        }

        /// <summary>
        /// 本接口（DescribeDBVersions）用于查询支持的数据库版本。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public DescribeDBVersionsResponse DescribeDBVersionsSync(DescribeDBVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDBVersionsResponse>(req, "DescribeDBVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBXlogs）用于获取实例Xlog列表。本接口已废弃，推荐使用接口[DescribeLogBackups](https://cloud.tencent.com/document/api/409/89021)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public Task<DescribeDBXlogsResponse> DescribeDBXlogs(DescribeDBXlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBXlogsResponse>(req, "DescribeDBXlogs");
        }

        /// <summary>
        /// 本接口（DescribeDBXlogs）用于获取实例Xlog列表。本接口已废弃，推荐使用接口[DescribeLogBackups](https://cloud.tencent.com/document/api/409/89021)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public DescribeDBXlogsResponse DescribeDBXlogsSync(DescribeDBXlogsRequest req)
        {
            return InternalRequestAsync<DescribeDBXlogsResponse>(req, "DescribeDBXlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口（DescribeDatabases）用来查询实例的数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// 接口（DescribeDatabases）用来查询实例的数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDefaultParameters）主要用于查询某个数据库版本和引擎支持的所有参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public Task<DescribeDefaultParametersResponse> DescribeDefaultParameters(DescribeDefaultParametersRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParametersResponse>(req, "DescribeDefaultParameters");
        }

        /// <summary>
        /// 本接口（DescribeDefaultParameters）主要用于查询某个数据库版本和引擎支持的所有参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public DescribeDefaultParametersResponse DescribeDefaultParametersSync(DescribeDefaultParametersRequest req)
        {
            return InternalRequestAsync<DescribeDefaultParametersResponse>(req, "DescribeDefaultParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 （DescribeEncryptionKeys） 用于查询实例的密钥信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public Task<DescribeEncryptionKeysResponse> DescribeEncryptionKeys(DescribeEncryptionKeysRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionKeysResponse>(req, "DescribeEncryptionKeys");
        }

        /// <summary>
        /// 本接口 （DescribeEncryptionKeys） 用于查询实例的密钥信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public DescribeEncryptionKeysResponse DescribeEncryptionKeysSync(DescribeEncryptionKeysRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionKeysResponse>(req, "DescribeEncryptionKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeLogBackups）用于查询日志备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public Task<DescribeLogBackupsResponse> DescribeLogBackups(DescribeLogBackupsRequest req)
        {
            return InternalRequestAsync<DescribeLogBackupsResponse>(req, "DescribeLogBackups");
        }

        /// <summary>
        /// 本接口（DescribeLogBackups）用于查询日志备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public DescribeLogBackupsResponse DescribeLogBackupsSync(DescribeLogBackupsRequest req)
        {
            return InternalRequestAsync<DescribeLogBackupsResponse>(req, "DescribeLogBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeParameterTemplateAttributes）用于查询某个参数模板的具体内容，包括基本信息和参数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public Task<DescribeParameterTemplateAttributesResponse> DescribeParameterTemplateAttributes(DescribeParameterTemplateAttributesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplateAttributesResponse>(req, "DescribeParameterTemplateAttributes");
        }

        /// <summary>
        /// 本接口（DescribeParameterTemplateAttributes）用于查询某个参数模板的具体内容，包括基本信息和参数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public DescribeParameterTemplateAttributesResponse DescribeParameterTemplateAttributesSync(DescribeParameterTemplateAttributesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplateAttributesResponse>(req, "DescribeParameterTemplateAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeParameterTemplates) 用于查询参数模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public Task<DescribeParameterTemplatesResponse> DescribeParameterTemplates(DescribeParameterTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplatesResponse>(req, "DescribeParameterTemplates");
        }

        /// <summary>
        /// 本接口 (DescribeParameterTemplates) 用于查询参数模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public DescribeParameterTemplatesResponse DescribeParameterTemplatesSync(DescribeParameterTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeParameterTemplatesResponse>(req, "DescribeParameterTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeParamsEvent）用于查询参数修改事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public Task<DescribeParamsEventResponse> DescribeParamsEvent(DescribeParamsEventRequest req)
        {
            return InternalRequestAsync<DescribeParamsEventResponse>(req, "DescribeParamsEvent");
        }

        /// <summary>
        /// 本接口（DescribeParamsEvent）用于查询参数修改事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public DescribeParamsEventResponse DescribeParamsEventSync(DescribeParamsEventRequest req)
        {
            return InternalRequestAsync<DescribeParamsEventResponse>(req, "DescribeParamsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProductConfig）用于查询售卖规格配置。本接口已废弃，推荐使用新接口[DescribeClasses](https://cloud.tencent.com/document/api/409/89019)。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig");
        }

        /// <summary>
        /// 本接口（DescribeProductConfig）用于查询售卖规格配置。本接口已废弃，推荐使用新接口[DescribeClasses](https://cloud.tencent.com/document/api/409/89019)。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroups）用于查询只读组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public Task<DescribeReadOnlyGroupsResponse> DescribeReadOnlyGroups(DescribeReadOnlyGroupsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupsResponse>(req, "DescribeReadOnlyGroups");
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroups）用于查询只读组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public DescribeReadOnlyGroupsResponse DescribeReadOnlyGroupsSync(DescribeReadOnlyGroupsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupsResponse>(req, "DescribeReadOnlyGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeRegions) 用于查询售卖地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 本接口 (DescribeRegions) 用于查询售卖地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询一个或多个serverlessDB实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public Task<DescribeServerlessDBInstancesResponse> DescribeServerlessDBInstances(DescribeServerlessDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeServerlessDBInstancesResponse>(req, "DescribeServerlessDBInstances");
        }

        /// <summary>
        /// 用于查询一个或多个serverlessDB实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public DescribeServerlessDBInstancesResponse DescribeServerlessDBInstancesSync(DescribeServerlessDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeServerlessDBInstancesResponse>(req, "DescribeServerlessDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryAnalysis）用于统计指定时间范围内的所有慢查询，根据SQL语句抽象参数后，进行聚合分析，并返回同类SQL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public Task<DescribeSlowQueryAnalysisResponse> DescribeSlowQueryAnalysis(DescribeSlowQueryAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryAnalysisResponse>(req, "DescribeSlowQueryAnalysis");
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryAnalysis）用于统计指定时间范围内的所有慢查询，根据SQL语句抽象参数后，进行聚合分析，并返回同类SQL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public DescribeSlowQueryAnalysisResponse DescribeSlowQueryAnalysisSync(DescribeSlowQueryAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryAnalysisResponse>(req, "DescribeSlowQueryAnalysis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryList）用于查询指定时间范围内的所有慢查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public Task<DescribeSlowQueryListResponse> DescribeSlowQueryList(DescribeSlowQueryListRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryListResponse>(req, "DescribeSlowQueryList");
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryList）用于查询指定时间范围内的所有慢查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public DescribeSlowQueryListResponse DescribeSlowQueryListSync(DescribeSlowQueryListRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryListResponse>(req, "DescribeSlowQueryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询支持的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询支持的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DestroyDBInstance) 用于彻底销毁指定DBInstanceId对应的实例，销毁后实例数据将彻底删除，无法找回，调用前请仔细确认要操作的实例。只能销毁隔离中的实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public Task<DestroyDBInstanceResponse> DestroyDBInstance(DestroyDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDBInstanceResponse>(req, "DestroyDBInstance");
        }

        /// <summary>
        /// 本接口 (DestroyDBInstance) 用于彻底销毁指定DBInstanceId对应的实例，销毁后实例数据将彻底删除，无法找回，调用前请仔细确认要操作的实例。只能销毁隔离中的实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public DestroyDBInstanceResponse DestroyDBInstanceSync(DestroyDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDBInstanceResponse>(req, "DestroyDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisIsolateDBInstances）用于解隔离实例
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public Task<DisIsolateDBInstancesResponse> DisIsolateDBInstances(DisIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<DisIsolateDBInstancesResponse>(req, "DisIsolateDBInstances");
        }

        /// <summary>
        /// 本接口（DisIsolateDBInstances）用于解隔离实例
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public DisIsolateDBInstancesResponse DisIsolateDBInstancesSync(DisIsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<DisIsolateDBInstancesResponse>(req, "DisIsolateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InitDBInstances）用于初始化云数据库PostgreSQL实例。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDBInstancesResponse>(req, "InitDBInstances");
        }

        /// <summary>
        /// 本接口（InitDBInstances）用于初始化云数据库PostgreSQL实例。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public InitDBInstancesResponse InitDBInstancesSync(InitDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDBInstancesResponse>(req, "InitDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (InquiryPriceCreateDBInstances) 用于查询购买实例的价格信息。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances");
        }

        /// <summary>
        /// 本接口 (InquiryPriceCreateDBInstances) 用于查询购买实例的价格信息。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询续费实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public Task<InquiryPriceRenewDBInstanceResponse> InquiryPriceRenewDBInstance(InquiryPriceRenewDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewDBInstanceResponse>(req, "InquiryPriceRenewDBInstance");
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询续费实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public InquiryPriceRenewDBInstanceResponse InquiryPriceRenewDBInstanceSync(InquiryPriceRenewDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewDBInstanceResponse>(req, "InquiryPriceRenewDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询升级实例的价格。只支持按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance");
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询升级实例的价格。只支持按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（IsolateDBInstances）用于隔离实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public Task<IsolateDBInstancesResponse> IsolateDBInstances(IsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<IsolateDBInstancesResponse>(req, "IsolateDBInstances");
        }

        /// <summary>
        /// 本接口（IsolateDBInstances）用于隔离实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public IsolateDBInstancesResponse IsolateDBInstancesSync(IsolateDBInstancesRequest req)
        {
            return InternalRequestAsync<IsolateDBInstancesResponse>(req, "IsolateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改账号备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public Task<ModifyAccountRemarkResponse> ModifyAccountRemark(ModifyAccountRemarkRequest req)
        {
            return InternalRequestAsync<ModifyAccountRemarkResponse>(req, "ModifyAccountRemark");
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改账号备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public ModifyAccountRemarkResponse ModifyAccountRemarkSync(ModifyAccountRemarkRequest req)
        {
            return InternalRequestAsync<ModifyAccountRemarkResponse>(req, "ModifyAccountRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction");
        }

        /// <summary>
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
            return InternalRequestAsync<ModifyBackupDownloadRestrictionResponse>(req, "ModifyBackupDownloadRestriction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyBackupPlan) 用于实例备份计划的修改，默认是在每天的凌晨开始全量备份，备份保留时长是7天。可以根据此接口指定时间进行实例的备份。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public Task<ModifyBackupPlanResponse> ModifyBackupPlan(ModifyBackupPlanRequest req)
        {
            return InternalRequestAsync<ModifyBackupPlanResponse>(req, "ModifyBackupPlan");
        }

        /// <summary>
        /// 本接口 (ModifyBackupPlan) 用于实例备份计划的修改，默认是在每天的凌晨开始全量备份，备份保留时长是7天。可以根据此接口指定时间进行实例的备份。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public ModifyBackupPlanResponse ModifyBackupPlanSync(ModifyBackupPlanRequest req)
        {
            return InternalRequestAsync<ModifyBackupPlanResponse>(req, "ModifyBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyBaseBackupExpireTime）用于修改实例指定数据备份的过期时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public Task<ModifyBaseBackupExpireTimeResponse> ModifyBaseBackupExpireTime(ModifyBaseBackupExpireTimeRequest req)
        {
            return InternalRequestAsync<ModifyBaseBackupExpireTimeResponse>(req, "ModifyBaseBackupExpireTime");
        }

        /// <summary>
        /// 本接口（ModifyBaseBackupExpireTime）用于修改实例指定数据备份的过期时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public ModifyBaseBackupExpireTimeResponse ModifyBaseBackupExpireTimeSync(ModifyBaseBackupExpireTimeRequest req)
        {
            return InternalRequestAsync<ModifyBaseBackupExpireTimeResponse>(req, "ModifyBaseBackupExpireTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持实例的计费类型转换（目前仅支持按量计费转包年包月）
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public Task<ModifyDBInstanceChargeTypeResponse> ModifyDBInstanceChargeType(ModifyDBInstanceChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceChargeTypeResponse>(req, "ModifyDBInstanceChargeType");
        }

        /// <summary>
        /// 支持实例的计费类型转换（目前仅支持按量计费转包年包月）
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public ModifyDBInstanceChargeTypeResponse ModifyDBInstanceChargeTypeSync(ModifyDBInstanceChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceChargeTypeResponse>(req, "ModifyDBInstanceChargeType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceDeployment）用于修改节点可用区部署方式，仅支持主实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public Task<ModifyDBInstanceDeploymentResponse> ModifyDBInstanceDeployment(ModifyDBInstanceDeploymentRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceDeploymentResponse>(req, "ModifyDBInstanceDeployment");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceDeployment）用于修改节点可用区部署方式，仅支持主实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public ModifyDBInstanceDeploymentResponse ModifyDBInstanceDeploymentSync(ModifyDBInstanceDeploymentRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceDeploymentResponse>(req, "ModifyDBInstanceDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceHAConfig）用于修改实例HA配置信息。其中HA配置信息包括：
        /// <li>允许备节点切换为主节点的条件配置
        /// <li>半同步实例使用同步复制或异步复制的条件配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceHAConfigResponse"/></returns>
        public Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfig(ModifyDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceHAConfigResponse>(req, "ModifyDBInstanceHAConfig");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceHAConfig）用于修改实例HA配置信息。其中HA配置信息包括：
        /// <li>允许备节点切换为主节点的条件配置
        /// <li>半同步实例使用同步复制或异步复制的条件配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceHAConfigResponse"/></returns>
        public ModifyDBInstanceHAConfigResponse ModifyDBInstanceHAConfigSync(ModifyDBInstanceHAConfigRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceHAConfigResponse>(req, "ModifyDBInstanceHAConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改postgresql实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改postgresql实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyDBInstanceParameters) 用于修改实例参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public Task<ModifyDBInstanceParametersResponse> ModifyDBInstanceParameters(ModifyDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceParametersResponse>(req, "ModifyDBInstanceParameters");
        }

        /// <summary>
        /// 本接口 (ModifyDBInstanceParameters) 用于修改实例参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public ModifyDBInstanceParametersResponse ModifyDBInstanceParametersSync(ModifyDBInstanceParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceParametersResponse>(req, "ModifyDBInstanceParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceReadOnlyGroup）用于修改实例所属的只读组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public Task<ModifyDBInstanceReadOnlyGroupResponse> ModifyDBInstanceReadOnlyGroup(ModifyDBInstanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceReadOnlyGroupResponse>(req, "ModifyDBInstanceReadOnlyGroup");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceReadOnlyGroup）用于修改实例所属的只读组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public ModifyDBInstanceReadOnlyGroupResponse ModifyDBInstanceReadOnlyGroupSync(ModifyDBInstanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceReadOnlyGroupResponse>(req, "ModifyDBInstanceReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改实例安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改实例安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSpec）用于修改实例规格，包括内存、磁盘。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSpec）用于修改实例规格，包括内存、磁盘。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecSync(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstancesProject）用于修改实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject");
        }

        /// <summary>
        /// 本接口（ModifyDBInstancesProject）用于修改实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyParameterTemplate）主要用于修改参数模板名称，描述等配置，也可用于管理参数模板中的参数列表。
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public Task<ModifyParameterTemplateResponse> ModifyParameterTemplate(ModifyParameterTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParameterTemplateResponse>(req, "ModifyParameterTemplate");
        }

        /// <summary>
        /// 本接口（ModifyParameterTemplate）主要用于修改参数模板名称，描述等配置，也可用于管理参数模板中的参数列表。
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public ModifyParameterTemplateResponse ModifyParameterTemplateSync(ModifyParameterTemplateRequest req)
        {
            return InternalRequestAsync<ModifyParameterTemplateResponse>(req, "ModifyParameterTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyReadOnlyGroupConfig)用于更新只读组配置信息
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public Task<ModifyReadOnlyGroupConfigResponse> ModifyReadOnlyGroupConfig(ModifyReadOnlyGroupConfigRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupConfigResponse>(req, "ModifyReadOnlyGroupConfig");
        }

        /// <summary>
        /// 本接口(ModifyReadOnlyGroupConfig)用于更新只读组配置信息
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public ModifyReadOnlyGroupConfigResponse ModifyReadOnlyGroupConfigSync(ModifyReadOnlyGroupConfigRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupConfigResponse>(req, "ModifyReadOnlyGroupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当升级完成后，对处于等待切换状态下的实例，强制实例立即切换。
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public Task<ModifySwitchTimePeriodResponse> ModifySwitchTimePeriod(ModifySwitchTimePeriodRequest req)
        {
            return InternalRequestAsync<ModifySwitchTimePeriodResponse>(req, "ModifySwitchTimePeriod");
        }

        /// <summary>
        /// 当升级完成后，对处于等待切换状态下的实例，强制实例立即切换。
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public ModifySwitchTimePeriodResponse ModifySwitchTimePeriodSync(ModifySwitchTimePeriodRequest req)
        {
            return InternalRequestAsync<ModifySwitchTimePeriodResponse>(req, "ModifySwitchTimePeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通实例公网地址。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public Task<OpenDBExtranetAccessResponse> OpenDBExtranetAccess(OpenDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenDBExtranetAccessResponse>(req, "OpenDBExtranetAccess");
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通实例公网地址。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public OpenDBExtranetAccessResponse OpenDBExtranetAccessSync(OpenDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenDBExtranetAccessResponse>(req, "OpenDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（OpenServerlessDBExtranetAccess）用于开通serverlessDB实例公网地址。
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public Task<OpenServerlessDBExtranetAccessResponse> OpenServerlessDBExtranetAccess(OpenServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenServerlessDBExtranetAccessResponse>(req, "OpenServerlessDBExtranetAccess");
        }

        /// <summary>
        /// 本接口（OpenServerlessDBExtranetAccess）用于开通serverlessDB实例公网地址。
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public OpenServerlessDBExtranetAccessResponse OpenServerlessDBExtranetAccessSync(OpenServerlessDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<OpenServerlessDBExtranetAccessResponse>(req, "OpenServerlessDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(RebalanceReadOnlyGroup)用于重新均衡 RO 组内实例的负载。注意，RO 组内 RO 实例会有一次数据库连接瞬断，请确保应用程序能重连数据库，谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public Task<RebalanceReadOnlyGroupResponse> RebalanceReadOnlyGroup(RebalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RebalanceReadOnlyGroupResponse>(req, "RebalanceReadOnlyGroup");
        }

        /// <summary>
        /// 本接口(RebalanceReadOnlyGroup)用于重新均衡 RO 组内实例的负载。注意，RO 组内 RO 实例会有一次数据库连接瞬断，请确保应用程序能重连数据库，谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public RebalanceReadOnlyGroupResponse RebalanceReadOnlyGroupSync(RebalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RebalanceReadOnlyGroupResponse>(req, "RebalanceReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RemoveDBInstanceFromReadOnlyGroup）用户将只读实例从只读组中移除
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public Task<RemoveDBInstanceFromReadOnlyGroupResponse> RemoveDBInstanceFromReadOnlyGroup(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RemoveDBInstanceFromReadOnlyGroupResponse>(req, "RemoveDBInstanceFromReadOnlyGroup");
        }

        /// <summary>
        /// 本接口（RemoveDBInstanceFromReadOnlyGroup）用户将只读实例从只读组中移除
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public RemoveDBInstanceFromReadOnlyGroupResponse RemoveDBInstanceFromReadOnlyGroupSync(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RemoveDBInstanceFromReadOnlyGroupResponse>(req, "RemoveDBInstanceFromReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RenewInstance）用于续费实例。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance");
        }

        /// <summary>
        /// 本接口（RenewInstance）用于续费实例。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置实例的账户密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置实例的账户密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance");
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetAutoRenewFlag）用于设置自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public Task<SetAutoRenewFlagResponse> SetAutoRenewFlag(SetAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<SetAutoRenewFlagResponse>(req, "SetAutoRenewFlag");
        }

        /// <summary>
        /// 本接口（SetAutoRenewFlag）用于设置自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public SetAutoRenewFlagResponse SetAutoRenewFlagSync(SetAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<SetAutoRenewFlagResponse>(req, "SetAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SwitchDBInstancePrimary）用于切换实例主备关系。
        /// <li>通过主动发起切换，可以验证业务能否正确处理实例主备切换的场景
        /// <li>通过使用强制切换，可以在备节点延迟不满足切换条件时，强制发起主从切换
        /// <li>只有主实例可以执行该操作
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public Task<SwitchDBInstancePrimaryResponse> SwitchDBInstancePrimary(SwitchDBInstancePrimaryRequest req)
        {
            return InternalRequestAsync<SwitchDBInstancePrimaryResponse>(req, "SwitchDBInstancePrimary");
        }

        /// <summary>
        /// 本接口（SwitchDBInstancePrimary）用于切换实例主备关系。
        /// <li>通过主动发起切换，可以验证业务能否正确处理实例主备切换的场景
        /// <li>通过使用强制切换，可以在备节点延迟不满足切换条件时，强制发起主从切换
        /// <li>只有主实例可以执行该操作
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public SwitchDBInstancePrimaryResponse SwitchDBInstancePrimarySync(SwitchDBInstancePrimaryRequest req)
        {
            return InternalRequestAsync<SwitchDBInstancePrimaryResponse>(req, "SwitchDBInstancePrimary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeDBInstance）用于升级实例配置。本接口已废弃，推荐使用接口[ModifyDBInstanceSpec](https://cloud.tencent.com/document/api/409/63689)替代。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance");
        }

        /// <summary>
        /// 本接口（UpgradeDBInstance）用于升级实例配置。本接口已废弃，推荐使用接口[ModifyDBInstanceSpec](https://cloud.tencent.com/document/api/409/63689)替代。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeDBInstanceKernelVersion）用于升级实例的内核版本号。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion");
        }

        /// <summary>
        /// 本接口（UpgradeDBInstanceKernelVersion）用于升级实例的内核版本号。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionSync(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeDBInstanceMajorVersion）用于升级实例内核大版本，例如从PostgreSQL 12升级到PostgreSQL 15。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceMajorVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceMajorVersionResponse"/></returns>
        public Task<UpgradeDBInstanceMajorVersionResponse> UpgradeDBInstanceMajorVersion(UpgradeDBInstanceMajorVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceMajorVersionResponse>(req, "UpgradeDBInstanceMajorVersion");
        }

        /// <summary>
        /// 本接口（UpgradeDBInstanceMajorVersion）用于升级实例内核大版本，例如从PostgreSQL 12升级到PostgreSQL 15。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceMajorVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceMajorVersionResponse"/></returns>
        public UpgradeDBInstanceMajorVersionResponse UpgradeDBInstanceMajorVersionSync(UpgradeDBInstanceMajorVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceMajorVersionResponse>(req, "UpgradeDBInstanceMajorVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
