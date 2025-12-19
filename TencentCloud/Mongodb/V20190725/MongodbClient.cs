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

namespace TencentCloud.Mongodb.V20190725
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mongodb.V20190725.Models;

   public class MongodbClient : AbstractClient{

       private const string endpoint = "mongodb.tencentcloudapi.com";
       private const string version = "2019-07-25";
       private const string sdkVersion = "SDK_NET_3.0.1363";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MongodbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MongodbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(AssignProject)用于指定云数据库实例的所属项目。
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public Task<AssignProjectResponse> AssignProject(AssignProjectRequest req)
        {
            return InternalRequestAsync<AssignProjectResponse>(req, "AssignProject");
        }

        /// <summary>
        /// 本接口(AssignProject)用于指定云数据库实例的所属项目。
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public AssignProjectResponse AssignProjectSync(AssignProjectRequest req)
        {
            return InternalRequestAsync<AssignProjectResponse>(req, "AssignProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAccountUser）用于自定义实例访问账号。
        /// </summary>
        /// <param name="req"><see cref="CreateAccountUserRequest"/></param>
        /// <returns><see cref="CreateAccountUserResponse"/></returns>
        public Task<CreateAccountUserResponse> CreateAccountUser(CreateAccountUserRequest req)
        {
            return InternalRequestAsync<CreateAccountUserResponse>(req, "CreateAccountUser");
        }

        /// <summary>
        /// 本接口（CreateAccountUser）用于自定义实例访问账号。
        /// </summary>
        /// <param name="req"><see cref="CreateAccountUserRequest"/></param>
        /// <returns><see cref="CreateAccountUserResponse"/></returns>
        public CreateAccountUserResponse CreateAccountUserSync(CreateAccountUserRequest req)
        {
            return InternalRequestAsync<CreateAccountUserResponse>(req, "CreateAccountUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateAuditLogFile)用于创建云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public Task<CreateAuditLogFileResponse> CreateAuditLogFile(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile");
        }

        /// <summary>
        /// 本接口(CreateAuditLogFile)用于创建云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public CreateAuditLogFileResponse CreateAuditLogFileSync(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateBackupDBInstance）用于备份实例。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDBInstanceRequest"/></param>
        /// <returns><see cref="CreateBackupDBInstanceResponse"/></returns>
        public Task<CreateBackupDBInstanceResponse> CreateBackupDBInstance(CreateBackupDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateBackupDBInstanceResponse>(req, "CreateBackupDBInstance");
        }

        /// <summary>
        /// 本接口（CreateBackupDBInstance）用于备份实例。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDBInstanceRequest"/></param>
        /// <returns><see cref="CreateBackupDBInstanceResponse"/></returns>
        public CreateBackupDBInstanceResponse CreateBackupDBInstanceSync(CreateBackupDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateBackupDBInstanceResponse>(req, "CreateBackupDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来创建某个备份文件的下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateBackupDownloadTaskResponse"/></returns>
        public Task<CreateBackupDownloadTaskResponse> CreateBackupDownloadTask(CreateBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateBackupDownloadTaskResponse>(req, "CreateBackupDownloadTask");
        }

        /// <summary>
        /// 本接口用来创建某个备份文件的下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateBackupDownloadTaskResponse"/></returns>
        public CreateBackupDownloadTaskResponse CreateBackupDownloadTaskSync(CreateBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateBackupDownloadTaskResponse>(req, "CreateBackupDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDBInstance)用于创建包年包月的MongoDB云数据库实例。接口支持的售卖规格，可通过接口查询 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/35767) 获取。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance");
        }

        /// <summary>
        /// 本接口(CreateDBInstance)用于创建包年包月的MongoDB云数据库实例。接口支持的售卖规格，可通过接口查询 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/35767) 获取。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDBInstanceHour）用于创建按量计费的MongoDB云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public Task<CreateDBInstanceHourResponse> CreateDBInstanceHour(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour");
        }

        /// <summary>
        /// 本接口（CreateDBInstanceHour）用于创建按量计费的MongoDB云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public CreateDBInstanceHourResponse CreateDBInstanceHourSync(CreateDBInstanceHourRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceHourResponse>(req, "CreateDBInstanceHour")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDBInstanceParamTpl)用于创建云数据库MongoDB实例的参数模板
        /// **说明：CreateDBInstanceParamTpl API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="CreateDBInstanceParamTplResponse"/></returns>
        public Task<CreateDBInstanceParamTplResponse> CreateDBInstanceParamTpl(CreateDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceParamTplResponse>(req, "CreateDBInstanceParamTpl");
        }

        /// <summary>
        /// 本接口(CreateDBInstanceParamTpl)用于创建云数据库MongoDB实例的参数模板
        /// **说明：CreateDBInstanceParamTpl API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="CreateDBInstanceParamTplResponse"/></returns>
        public CreateDBInstanceParamTplResponse CreateDBInstanceParamTplSync(CreateDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceParamTplResponse>(req, "CreateDBInstanceParamTpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建日志下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateLogDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLogDownloadTaskResponse"/></returns>
        public Task<CreateLogDownloadTaskResponse> CreateLogDownloadTask(CreateLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLogDownloadTaskResponse>(req, "CreateLogDownloadTask");
        }

        /// <summary>
        /// 创建日志下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateLogDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateLogDownloadTaskResponse"/></returns>
        public CreateLogDownloadTaskResponse CreateLogDownloadTaskSync(CreateLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateLogDownloadTaskResponse>(req, "CreateLogDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAccountUser）用于删除实例的自定义账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountUserRequest"/></param>
        /// <returns><see cref="DeleteAccountUserResponse"/></returns>
        public Task<DeleteAccountUserResponse> DeleteAccountUser(DeleteAccountUserRequest req)
        {
            return InternalRequestAsync<DeleteAccountUserResponse>(req, "DeleteAccountUser");
        }

        /// <summary>
        /// 本接口（DeleteAccountUser）用于删除实例的自定义账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountUserRequest"/></param>
        /// <returns><see cref="DeleteAccountUserResponse"/></returns>
        public DeleteAccountUserResponse DeleteAccountUserSync(DeleteAccountUserRequest req)
        {
            return InternalRequestAsync<DeleteAccountUserResponse>(req, "DeleteAccountUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteAuditLogFile)用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public Task<DeleteAuditLogFileResponse> DeleteAuditLogFile(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile");
        }

        /// <summary>
        /// 本接口(DeleteAuditLogFile)用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public DeleteAuditLogFileResponse DeleteAuditLogFileSync(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除日志下载任务
        /// </summary>
        /// <param name="req"><see cref="DeleteLogDownloadTaskRequest"/></param>
        /// <returns><see cref="DeleteLogDownloadTaskResponse"/></returns>
        public Task<DeleteLogDownloadTaskResponse> DeleteLogDownloadTask(DeleteLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<DeleteLogDownloadTaskResponse>(req, "DeleteLogDownloadTask");
        }

        /// <summary>
        /// 删除日志下载任务
        /// </summary>
        /// <param name="req"><see cref="DeleteLogDownloadTaskRequest"/></param>
        /// <returns><see cref="DeleteLogDownloadTaskResponse"/></returns>
        public DeleteLogDownloadTaskResponse DeleteLogDownloadTaskSync(DeleteLogDownloadTaskRequest req)
        {
            return InternalRequestAsync<DeleteLogDownloadTaskResponse>(req, "DeleteLogDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccountUsers）用于获取当前实例的全部账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountUsersRequest"/></param>
        /// <returns><see cref="DescribeAccountUsersResponse"/></returns>
        public Task<DescribeAccountUsersResponse> DescribeAccountUsers(DescribeAccountUsersRequest req)
        {
            return InternalRequestAsync<DescribeAccountUsersResponse>(req, "DescribeAccountUsers");
        }

        /// <summary>
        /// 本接口（DescribeAccountUsers）用于获取当前实例的全部账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountUsersRequest"/></param>
        /// <returns><see cref="DescribeAccountUsersResponse"/></returns>
        public DescribeAccountUsersResponse DescribeAccountUsersSync(DescribeAccountUsersRequest req)
        {
            return InternalRequestAsync<DescribeAccountUsersResponse>(req, "DescribeAccountUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAsyncRequestInfo）用于查询异步任务状态接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// 本接口（DescribeAsyncRequestInfo）用于查询异步任务状态接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAuditInstanceList）用于查询开通或未开通数据库审计的实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// 本接口（DescribeAuditInstanceList）用于查询开通或未开通数据库审计的实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadTask）用于查询备份下载任务信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public Task<DescribeBackupDownloadTaskResponse> DescribeBackupDownloadTask(DescribeBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadTaskResponse>(req, "DescribeBackupDownloadTask");
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadTask）用于查询备份下载任务信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public DescribeBackupDownloadTaskResponse DescribeBackupDownloadTaskSync(DescribeBackupDownloadTaskRequest req)
        {
            return InternalRequestAsync<DescribeBackupDownloadTaskResponse>(req, "DescribeBackupDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupRules）用于获取实例自动备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRulesRequest"/></param>
        /// <returns><see cref="DescribeBackupRulesResponse"/></returns>
        public Task<DescribeBackupRulesResponse> DescribeBackupRules(DescribeBackupRulesRequest req)
        {
            return InternalRequestAsync<DescribeBackupRulesResponse>(req, "DescribeBackupRules");
        }

        /// <summary>
        /// 本接口（DescribeBackupRules）用于获取实例自动备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRulesRequest"/></param>
        /// <returns><see cref="DescribeBackupRulesResponse"/></returns>
        public DescribeBackupRulesResponse DescribeBackupRulesSync(DescribeBackupRulesRequest req)
        {
            return InternalRequestAsync<DescribeBackupRulesResponse>(req, "DescribeBackupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClientConnections）用于查询实例客户端连接信息，包括连接 IP 和连接数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public Task<DescribeClientConnectionsResponse> DescribeClientConnections(DescribeClientConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeClientConnectionsResponse>(req, "DescribeClientConnections");
        }

        /// <summary>
        /// 本接口（DescribeClientConnections）用于查询实例客户端连接信息，包括连接 IP 和连接数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public DescribeClientConnectionsResponse DescribeClientConnectionsSync(DescribeClientConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeClientConnectionsResponse>(req, "DescribeClientConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCurrentOp）用于查询云数据库实例的当前正在执行的操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentOpRequest"/></param>
        /// <returns><see cref="DescribeCurrentOpResponse"/></returns>
        public Task<DescribeCurrentOpResponse> DescribeCurrentOp(DescribeCurrentOpRequest req)
        {
            return InternalRequestAsync<DescribeCurrentOpResponse>(req, "DescribeCurrentOp");
        }

        /// <summary>
        /// 本接口（DescribeCurrentOp）用于查询云数据库实例的当前正在执行的操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentOpRequest"/></param>
        /// <returns><see cref="DescribeCurrentOpResponse"/></returns>
        public DescribeCurrentOpResponse DescribeCurrentOpSync(DescribeCurrentOpRequest req)
        {
            return InternalRequestAsync<DescribeCurrentOpResponse>(req, "DescribeCurrentOp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBBackups）用于查询实例备份列表，目前只支持查询7天内的备份记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public Task<DescribeDBBackupsResponse> DescribeDBBackups(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups");
        }

        /// <summary>
        /// 本接口（DescribeDBBackups）用于查询实例备份列表，目前只支持查询7天内的备份记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public DescribeDBBackupsResponse DescribeDBBackupsSync(DescribeDBBackupsRequest req)
        {
            return InternalRequestAsync<DescribeDBBackupsResponse>(req, "DescribeDBBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceDeal）用于获取MongoDB购买、续费及变配订单详细。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public Task<DescribeDBInstanceDealResponse> DescribeDBInstanceDeal(DescribeDBInstanceDealRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDealResponse>(req, "DescribeDBInstanceDeal");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceDeal）用于获取MongoDB购买、续费及变配订单详细。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public DescribeDBInstanceDealResponse DescribeDBInstanceDealSync(DescribeDBInstanceDealRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDealResponse>(req, "DescribeDBInstanceDeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceNamespace）用于查询数据库的表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNamespaceRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNamespaceResponse"/></returns>
        public Task<DescribeDBInstanceNamespaceResponse> DescribeDBInstanceNamespace(DescribeDBInstanceNamespaceRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNamespaceResponse>(req, "DescribeDBInstanceNamespace");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceNamespace）用于查询数据库的表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNamespaceRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNamespaceResponse"/></returns>
        public DescribeDBInstanceNamespaceResponse DescribeDBInstanceNamespaceSync(DescribeDBInstanceNamespaceRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNamespaceResponse>(req, "DescribeDBInstanceNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询节点的属性，包括节点所在可用区、节点名称、地址、角色、状态、主从延迟、优先级、投票权、标签等属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNodePropertyRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNodePropertyResponse"/></returns>
        public Task<DescribeDBInstanceNodePropertyResponse> DescribeDBInstanceNodeProperty(DescribeDBInstanceNodePropertyRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNodePropertyResponse>(req, "DescribeDBInstanceNodeProperty");
        }

        /// <summary>
        /// 本接口用于查询节点的属性，包括节点所在可用区、节点名称、地址、角色、状态、主从延迟、优先级、投票权、标签等属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceNodePropertyRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceNodePropertyResponse"/></returns>
        public DescribeDBInstanceNodePropertyResponse DescribeDBInstanceNodePropertySync(DescribeDBInstanceNodePropertyRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceNodePropertyResponse>(req, "DescribeDBInstanceNodeProperty")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceParamTpl )用于查询当前账号下所有MongoDB数据库参数模板
        /// **说明：DescribeDBInstanceParamTpl  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParamTplResponse"/></returns>
        public Task<DescribeDBInstanceParamTplResponse> DescribeDBInstanceParamTpl(DescribeDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParamTplResponse>(req, "DescribeDBInstanceParamTpl");
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceParamTpl )用于查询当前账号下所有MongoDB数据库参数模板
        /// **说明：DescribeDBInstanceParamTpl  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParamTplResponse"/></returns>
        public DescribeDBInstanceParamTplResponse DescribeDBInstanceParamTplSync(DescribeDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParamTplResponse>(req, "DescribeDBInstanceParamTpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceParamTplDetail )用于查询MongoDB云数据库实例的参数模板详情。
        /// **说明：DescribeDBInstanceParamTplDetail  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParamTplDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParamTplDetailResponse"/></returns>
        public Task<DescribeDBInstanceParamTplDetailResponse> DescribeDBInstanceParamTplDetail(DescribeDBInstanceParamTplDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParamTplDetailResponse>(req, "DescribeDBInstanceParamTplDetail");
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceParamTplDetail )用于查询MongoDB云数据库实例的参数模板详情。
        /// **说明：DescribeDBInstanceParamTplDetail  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParamTplDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParamTplDetailResponse"/></returns>
        public DescribeDBInstanceParamTplDetailResponse DescribeDBInstanceParamTplDetailSync(DescribeDBInstanceParamTplDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceParamTplDetailResponse>(req, "DescribeDBInstanceParamTplDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceURL）用于获取指定实例的 URI 形式的连接串访问地址示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceURLRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceURLResponse"/></returns>
        public Task<DescribeDBInstanceURLResponse> DescribeDBInstanceURL(DescribeDBInstanceURLRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceURLResponse>(req, "DescribeDBInstanceURL");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceURL）用于获取指定实例的 URI 形式的连接串访问地址示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceURLRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceURLResponse"/></returns>
        public DescribeDBInstanceURLResponse DescribeDBInstanceURLSync(DescribeDBInstanceURLRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceURLResponse>(req, "DescribeDBInstanceURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstances）用于查询云数据库实例列表，支持通过项目ID、实例ID、实例状态等过滤条件来筛选主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// 本接口（DescribeDBInstances）用于查询云数据库实例列表，支持通过项目ID、实例ID、实例状态等过滤条件来筛选主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDetailedSlowLogs）用于查询实例慢日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDetailedSlowLogsResponse"/></returns>
        public Task<DescribeDetailedSlowLogsResponse> DescribeDetailedSlowLogs(DescribeDetailedSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDetailedSlowLogsResponse>(req, "DescribeDetailedSlowLogs");
        }

        /// <summary>
        /// 本接口（DescribeDetailedSlowLogs）用于查询实例慢日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDetailedSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDetailedSlowLogsResponse"/></returns>
        public DescribeDetailedSlowLogsResponse DescribeDetailedSlowLogsSync(DescribeDetailedSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDetailedSlowLogsResponse>(req, "DescribeDetailedSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询当前实例可修改的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询当前实例可修改的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看实例SSL开启状态
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSSLRequest"/></param>
        /// <returns><see cref="DescribeInstanceSSLResponse"/></returns>
        public Task<DescribeInstanceSSLResponse> DescribeInstanceSSL(DescribeInstanceSSLRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSSLResponse>(req, "DescribeInstanceSSL");
        }

        /// <summary>
        /// 查看实例SSL开启状态
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSSLRequest"/></param>
        /// <returns><see cref="DescribeInstanceSSLResponse"/></returns>
        public DescribeInstanceSSLResponse DescribeInstanceSSLSync(DescribeInstanceSSLRequest req)
        {
            return InternalRequestAsync<DescribeInstanceSSLResponse>(req, "DescribeInstanceSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 日志下载任务查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDownloadTasksRequest"/></param>
        /// <returns><see cref="DescribeLogDownloadTasksResponse"/></returns>
        public Task<DescribeLogDownloadTasksResponse> DescribeLogDownloadTasks(DescribeLogDownloadTasksRequest req)
        {
            return InternalRequestAsync<DescribeLogDownloadTasksResponse>(req, "DescribeLogDownloadTasks");
        }

        /// <summary>
        /// 日志下载任务查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDownloadTasksRequest"/></param>
        /// <returns><see cref="DescribeLogDownloadTasksResponse"/></returns>
        public DescribeLogDownloadTasksResponse DescribeLogDownloadTasksSync(DescribeLogDownloadTasksRequest req)
        {
            return InternalRequestAsync<DescribeLogDownloadTasksResponse>(req, "DescribeLogDownloadTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeMongodbLogs）用于查询运行日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeMongodbLogsRequest"/></param>
        /// <returns><see cref="DescribeMongodbLogsResponse"/></returns>
        public Task<DescribeMongodbLogsResponse> DescribeMongodbLogs(DescribeMongodbLogsRequest req)
        {
            return InternalRequestAsync<DescribeMongodbLogsResponse>(req, "DescribeMongodbLogs");
        }

        /// <summary>
        /// 该接口（DescribeMongodbLogs）用于查询运行日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeMongodbLogsRequest"/></param>
        /// <returns><see cref="DescribeMongodbLogsResponse"/></returns>
        public DescribeMongodbLogsResponse DescribeMongodbLogsSync(DescribeMongodbLogsRequest req)
        {
            return InternalRequestAsync<DescribeMongodbLogsResponse>(req, "DescribeMongodbLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroup）用于查询实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupResponse"/></returns>
        public Task<DescribeSecurityGroupResponse> DescribeSecurityGroup(DescribeSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupResponse>(req, "DescribeSecurityGroup");
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroup）用于查询实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupResponse"/></returns>
        public DescribeSecurityGroupResponse DescribeSecurityGroupSync(DescribeSecurityGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupResponse>(req, "DescribeSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSlowLogPatterns）用于获取数据库实例慢日志的统计信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogPatternsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogPatternsResponse"/></returns>
        public Task<DescribeSlowLogPatternsResponse> DescribeSlowLogPatterns(DescribeSlowLogPatternsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogPatternsResponse>(req, "DescribeSlowLogPatterns");
        }

        /// <summary>
        /// 本接口（DescribeSlowLogPatterns）用于获取数据库实例慢日志的统计信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogPatternsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogPatternsResponse"/></returns>
        public DescribeSlowLogPatternsResponse DescribeSlowLogPatternsSync(DescribeSlowLogPatternsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogPatternsResponse>(req, "DescribeSlowLogPatterns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSlowLogs）用于获取云数据库慢日志信息。接口只支持查询最近7天内慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs");
        }

        /// <summary>
        /// 本接口（DescribeSlowLogs）用于获取云数据库慢日志信息。接口只支持查询最近7天内慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSpecInfo）用于查询实例的售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public Task<DescribeSpecInfoResponse> DescribeSpecInfo(DescribeSpecInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpecInfoResponse>(req, "DescribeSpecInfo");
        }

        /// <summary>
        /// 本接口（DescribeSpecInfo）用于查询实例的售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public DescribeSpecInfoResponse DescribeSpecInfoSync(DescribeSpecInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpecInfoResponse>(req, "DescribeSpecInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例透明加密的开启状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTransparentDataEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeTransparentDataEncryptionStatusResponse"/></returns>
        public Task<DescribeTransparentDataEncryptionStatusResponse> DescribeTransparentDataEncryptionStatus(DescribeTransparentDataEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeTransparentDataEncryptionStatusResponse>(req, "DescribeTransparentDataEncryptionStatus");
        }

        /// <summary>
        /// 获取实例透明加密的开启状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTransparentDataEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeTransparentDataEncryptionStatusResponse"/></returns>
        public DescribeTransparentDataEncryptionStatusResponse DescribeTransparentDataEncryptionStatusSync(DescribeTransparentDataEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeTransparentDataEncryptionStatusResponse>(req, "DescribeTransparentDataEncryptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DropDBInstanceParamTpl )用于删除云数据库MongoDB实例的参数模板
        /// **说明：DropDBInstanceParamTpl  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="DropDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="DropDBInstanceParamTplResponse"/></returns>
        public Task<DropDBInstanceParamTplResponse> DropDBInstanceParamTpl(DropDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<DropDBInstanceParamTplResponse>(req, "DropDBInstanceParamTpl");
        }

        /// <summary>
        /// 本接口(DropDBInstanceParamTpl )用于删除云数据库MongoDB实例的参数模板
        /// **说明：DropDBInstanceParamTpl  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="DropDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="DropDBInstanceParamTplResponse"/></returns>
        public DropDBInstanceParamTplResponse DropDBInstanceParamTplSync(DropDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<DropDBInstanceParamTplResponse>(req, "DropDBInstanceParamTpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableTransparentDataEncryption）用于开启云数据库 MongoDB 的透明加密能力。
        /// </summary>
        /// <param name="req"><see cref="EnableTransparentDataEncryptionRequest"/></param>
        /// <returns><see cref="EnableTransparentDataEncryptionResponse"/></returns>
        public Task<EnableTransparentDataEncryptionResponse> EnableTransparentDataEncryption(EnableTransparentDataEncryptionRequest req)
        {
            return InternalRequestAsync<EnableTransparentDataEncryptionResponse>(req, "EnableTransparentDataEncryption");
        }

        /// <summary>
        /// 本接口（EnableTransparentDataEncryption）用于开启云数据库 MongoDB 的透明加密能力。
        /// </summary>
        /// <param name="req"><see cref="EnableTransparentDataEncryptionRequest"/></param>
        /// <returns><see cref="EnableTransparentDataEncryptionResponse"/></returns>
        public EnableTransparentDataEncryptionResponse EnableTransparentDataEncryptionSync(EnableTransparentDataEncryptionRequest req)
        {
            return InternalRequestAsync<EnableTransparentDataEncryptionResponse>(req, "EnableTransparentDataEncryption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于发起按 Key 闪回任务，依据数据的闪回 Key（默认为 id）对数据进行极速回档，快速恢复业务。
        /// **说明：按 Key 闪回于2023年09月11日正式进行公测，在此期间，该接口仅对公测用户开放。**
        /// </summary>
        /// <param name="req"><see cref="FlashBackDBInstanceRequest"/></param>
        /// <returns><see cref="FlashBackDBInstanceResponse"/></returns>
        public Task<FlashBackDBInstanceResponse> FlashBackDBInstance(FlashBackDBInstanceRequest req)
        {
            return InternalRequestAsync<FlashBackDBInstanceResponse>(req, "FlashBackDBInstance");
        }

        /// <summary>
        /// 该接口用于发起按 Key 闪回任务，依据数据的闪回 Key（默认为 id）对数据进行极速回档，快速恢复业务。
        /// **说明：按 Key 闪回于2023年09月11日正式进行公测，在此期间，该接口仅对公测用户开放。**
        /// </summary>
        /// <param name="req"><see cref="FlashBackDBInstanceRequest"/></param>
        /// <returns><see cref="FlashBackDBInstanceResponse"/></returns>
        public FlashBackDBInstanceResponse FlashBackDBInstanceSync(FlashBackDBInstanceRequest req)
        {
            return InternalRequestAsync<FlashBackDBInstanceResponse>(req, "FlashBackDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在所有mongos上执行FlushRouterConfig命令
        /// </summary>
        /// <param name="req"><see cref="FlushInstanceRouterConfigRequest"/></param>
        /// <returns><see cref="FlushInstanceRouterConfigResponse"/></returns>
        public Task<FlushInstanceRouterConfigResponse> FlushInstanceRouterConfig(FlushInstanceRouterConfigRequest req)
        {
            return InternalRequestAsync<FlushInstanceRouterConfigResponse>(req, "FlushInstanceRouterConfig");
        }

        /// <summary>
        /// 在所有mongos上执行FlushRouterConfig命令
        /// </summary>
        /// <param name="req"><see cref="FlushInstanceRouterConfigRequest"/></param>
        /// <returns><see cref="FlushInstanceRouterConfigResponse"/></returns>
        public FlushInstanceRouterConfigResponse FlushInstanceRouterConfigSync(FlushInstanceRouterConfigRequest req)
        {
            return InternalRequestAsync<FlushInstanceRouterConfigResponse>(req, "FlushInstanceRouterConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquirePriceCreateDBInstances）用于创建数据库实例询价。本接口参数中必须传入region参数，否则无法通过校验。本接口仅允许针对购买限制范围内的实例配置进行询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDBInstancesResponse"/></returns>
        public Task<InquirePriceCreateDBInstancesResponse> InquirePriceCreateDBInstances(InquirePriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDBInstancesResponse>(req, "InquirePriceCreateDBInstances");
        }

        /// <summary>
        /// 本接口（InquirePriceCreateDBInstances）用于创建数据库实例询价。本接口参数中必须传入region参数，否则无法通过校验。本接口仅允许针对购买限制范围内的实例配置进行询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDBInstancesResponse"/></returns>
        public InquirePriceCreateDBInstancesResponse InquirePriceCreateDBInstancesSync(InquirePriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDBInstancesResponse>(req, "InquirePriceCreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (InquirePriceModifyDBInstanceSpec) 用于查询实例配置变更后的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDBInstanceSpecResponse"/></returns>
        public Task<InquirePriceModifyDBInstanceSpecResponse> InquirePriceModifyDBInstanceSpec(InquirePriceModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDBInstanceSpecResponse>(req, "InquirePriceModifyDBInstanceSpec");
        }

        /// <summary>
        /// 本接口 (InquirePriceModifyDBInstanceSpec) 用于查询实例配置变更后的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDBInstanceSpecResponse"/></returns>
        public InquirePriceModifyDBInstanceSpecResponse InquirePriceModifyDBInstanceSpecSync(InquirePriceModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyDBInstanceSpecResponse>(req, "InquirePriceModifyDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (InquiryPriceRenewDBInstances) 用于续费包年包月实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDBInstancesResponse"/></returns>
        public Task<InquirePriceRenewDBInstancesResponse> InquirePriceRenewDBInstances(InquirePriceRenewDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDBInstancesResponse>(req, "InquirePriceRenewDBInstances");
        }

        /// <summary>
        /// 本接口 (InquiryPriceRenewDBInstances) 用于续费包年包月实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDBInstancesResponse"/></returns>
        public InquirePriceRenewDBInstancesResponse InquirePriceRenewDBInstancesSync(InquirePriceRenewDBInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewDBInstancesResponse>(req, "InquirePriceRenewDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InstanceEnableSSL）用于设置实例SSL状态。
        /// </summary>
        /// <param name="req"><see cref="InstanceEnableSSLRequest"/></param>
        /// <returns><see cref="InstanceEnableSSLResponse"/></returns>
        public Task<InstanceEnableSSLResponse> InstanceEnableSSL(InstanceEnableSSLRequest req)
        {
            return InternalRequestAsync<InstanceEnableSSLResponse>(req, "InstanceEnableSSL");
        }

        /// <summary>
        /// 本接口（InstanceEnableSSL）用于设置实例SSL状态。
        /// </summary>
        /// <param name="req"><see cref="InstanceEnableSSLRequest"/></param>
        /// <returns><see cref="InstanceEnableSSLResponse"/></returns>
        public InstanceEnableSSLResponse InstanceEnableSSLSync(InstanceEnableSSLRequest req)
        {
            return InternalRequestAsync<InstanceEnableSSLResponse>(req, "InstanceEnableSSL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（IsolateDBInstance）用于隔离 MongoDB 云数据库按量计费实例。隔离后实例保留在回收站中，不能再写入数据。隔离一定时间后，实例会彻底删除，回收站保存时间请参考按量计费的服务条款。已删除的按量计费实例无法恢复，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// 本接口（IsolateDBInstance）用于隔离 MongoDB 云数据库按量计费实例。隔离后实例保留在回收站中，不能再写入数据。隔离一定时间后，实例会彻底删除，回收站保存时间请参考按量计费的服务条款。已删除的按量计费实例无法恢复，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（KillOps）用于终止 MongoDB 云数据库实例上执行的特定操作。
        /// </summary>
        /// <param name="req"><see cref="KillOpsRequest"/></param>
        /// <returns><see cref="KillOpsResponse"/></returns>
        public Task<KillOpsResponse> KillOps(KillOpsRequest req)
        {
            return InternalRequestAsync<KillOpsResponse>(req, "KillOps");
        }

        /// <summary>
        /// 本接口（KillOps）用于终止 MongoDB 云数据库实例上执行的特定操作。
        /// </summary>
        /// <param name="req"><see cref="KillOpsRequest"/></param>
        /// <returns><see cref="KillOpsResponse"/></returns>
        public KillOpsResponse KillOpsSync(KillOpsRequest req)
        {
            return InternalRequestAsync<KillOpsResponse>(req, "KillOps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyAuditService)用于修改云数据库审计策略的服务配置，包括审计日志保存时长等。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// 本接口(ModifyAuditService)用于修改云数据库审计策略的服务配置，包括审计日志保存时长等。
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceNetworkAddress）用于修改云数据库实例的网络信息，支持基础网络切换为私有网络、私有网络切换私有网络。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public Task<ModifyDBInstanceNetworkAddressResponse> ModifyDBInstanceNetworkAddress(ModifyDBInstanceNetworkAddressRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkAddressResponse>(req, "ModifyDBInstanceNetworkAddress");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceNetworkAddress）用于修改云数据库实例的网络信息，支持基础网络切换为私有网络、私有网络切换私有网络。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public ModifyDBInstanceNetworkAddressResponse ModifyDBInstanceNetworkAddressSync(ModifyDBInstanceNetworkAddressRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkAddressResponse>(req, "ModifyDBInstanceNetworkAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceParamTpl )用于修改MongoDB云数据库实例的参数模板。
        /// **说明：ModifyDBInstanceParamTpl  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParamTplResponse"/></returns>
        public Task<ModifyDBInstanceParamTplResponse> ModifyDBInstanceParamTpl(ModifyDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceParamTplResponse>(req, "ModifyDBInstanceParamTpl");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceParamTpl )用于修改MongoDB云数据库实例的参数模板。
        /// **说明：ModifyDBInstanceParamTpl  API正在公测中，在此期间，该接口仅对公测用户开放**
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParamTplRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParamTplResponse"/></returns>
        public ModifyDBInstanceParamTplResponse ModifyDBInstanceParamTplSync(ModifyDBInstanceParamTplRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceParamTplResponse>(req, "ModifyDBInstanceParamTpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroup）用于修改实例绑定的安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupResponse> ModifyDBInstanceSecurityGroup(ModifyDBInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupResponse>(req, "ModifyDBInstanceSecurityGroup");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroup）用于修改实例绑定的安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public ModifyDBInstanceSecurityGroupResponse ModifyDBInstanceSecurityGroupSync(ModifyDBInstanceSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupResponse>(req, "ModifyDBInstanceSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSpec）用于调整MongoDB云数据库实例配置。接口支持的售卖规格，可从查询云数据库的售卖规格（[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)）获取。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSpec）用于调整MongoDB云数据库实例配置。接口支持的售卖规格，可从查询云数据库的售卖规格（[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)）获取。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecSync(ModifyDBInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSpecResponse>(req, "ModifyDBInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceParams）用于修改mongoDB实例的参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams");
        }

        /// <summary>
        /// 本接口（ModifyInstanceParams）用于修改mongoDB实例的参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(OfflineIsolatedDBInstance)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态。
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineIsolatedDBInstanceResponse"/></returns>
        public Task<OfflineIsolatedDBInstanceResponse> OfflineIsolatedDBInstance(OfflineIsolatedDBInstanceRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedDBInstanceResponse>(req, "OfflineIsolatedDBInstance");
        }

        /// <summary>
        /// 本接口(OfflineIsolatedDBInstance)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态。
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineIsolatedDBInstanceResponse"/></returns>
        public OfflineIsolatedDBInstanceResponse OfflineIsolatedDBInstanceSync(OfflineIsolatedDBInstanceRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedDBInstanceResponse>(req, "OfflineIsolatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(OpenAuditService)用于开通云数据库实例的审计。
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// 本接口(OpenAuditService)用于开通云数据库实例的审计。
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(RenameInstance)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req"><see cref="RenameInstanceRequest"/></param>
        /// <returns><see cref="RenameInstanceResponse"/></returns>
        public Task<RenameInstanceResponse> RenameInstance(RenameInstanceRequest req)
        {
            return InternalRequestAsync<RenameInstanceResponse>(req, "RenameInstance");
        }

        /// <summary>
        /// 本接口(RenameInstance)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req"><see cref="RenameInstanceRequest"/></param>
        /// <returns><see cref="RenameInstanceResponse"/></returns>
        public RenameInstanceResponse RenameInstanceSync(RenameInstanceRequest req)
        {
            return InternalRequestAsync<RenameInstanceResponse>(req, "RenameInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(RenewDBInstance)用于续费云数据库实例，仅支持付费模式为包年包月的实例。按量计费实例不需要续费。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstancesRequest"/></param>
        /// <returns><see cref="RenewDBInstancesResponse"/></returns>
        public Task<RenewDBInstancesResponse> RenewDBInstances(RenewDBInstancesRequest req)
        {
            return InternalRequestAsync<RenewDBInstancesResponse>(req, "RenewDBInstances");
        }

        /// <summary>
        /// 本接口(RenewDBInstance)用于续费云数据库实例，仅支持付费模式为包年包月的实例。按量计费实例不需要续费。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstancesRequest"/></param>
        /// <returns><see cref="RenewDBInstancesResponse"/></returns>
        public RenewDBInstancesResponse RenewDBInstancesSync(RenewDBInstancesRequest req)
        {
            return InternalRequestAsync<RenewDBInstancesResponse>(req, "RenewDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetDBInstancePassword）用于重置实例访问密码。
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public Task<ResetDBInstancePasswordResponse> ResetDBInstancePassword(ResetDBInstancePasswordRequest req)
        {
            return InternalRequestAsync<ResetDBInstancePasswordResponse>(req, "ResetDBInstancePassword");
        }

        /// <summary>
        /// 本接口（ResetDBInstancePassword）用于重置实例访问密码。
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public ResetDBInstancePasswordResponse ResetDBInstancePasswordSync(ResetDBInstancePasswordRequest req)
        {
            return InternalRequestAsync<ResetDBInstancePasswordResponse>(req, "ResetDBInstancePassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RestartNodes）用于批量重启数据库节点。
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public Task<RestartNodesResponse> RestartNodes(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes");
        }

        /// <summary>
        /// 本接口（RestartNodes）用于批量重启数据库节点。
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public RestartNodesResponse RestartNodesSync(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetAccountUserPrivilege）用于设置实例的账号权限。
        /// </summary>
        /// <param name="req"><see cref="SetAccountUserPrivilegeRequest"/></param>
        /// <returns><see cref="SetAccountUserPrivilegeResponse"/></returns>
        public Task<SetAccountUserPrivilegeResponse> SetAccountUserPrivilege(SetAccountUserPrivilegeRequest req)
        {
            return InternalRequestAsync<SetAccountUserPrivilegeResponse>(req, "SetAccountUserPrivilege");
        }

        /// <summary>
        /// 本接口（SetAccountUserPrivilege）用于设置实例的账号权限。
        /// </summary>
        /// <param name="req"><see cref="SetAccountUserPrivilegeRequest"/></param>
        /// <returns><see cref="SetAccountUserPrivilegeResponse"/></returns>
        public SetAccountUserPrivilegeResponse SetAccountUserPrivilegeSync(SetAccountUserPrivilegeRequest req)
        {
            return InternalRequestAsync<SetAccountUserPrivilegeResponse>(req, "SetAccountUserPrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetBackupRules）用于设置 MongoDB 云数据库的自动备份规则。
        /// </summary>
        /// <param name="req"><see cref="SetBackupRulesRequest"/></param>
        /// <returns><see cref="SetBackupRulesResponse"/></returns>
        public Task<SetBackupRulesResponse> SetBackupRules(SetBackupRulesRequest req)
        {
            return InternalRequestAsync<SetBackupRulesResponse>(req, "SetBackupRules");
        }

        /// <summary>
        /// 本接口（SetBackupRules）用于设置 MongoDB 云数据库的自动备份规则。
        /// </summary>
        /// <param name="req"><see cref="SetBackupRulesRequest"/></param>
        /// <returns><see cref="SetBackupRulesResponse"/></returns>
        public SetBackupRulesResponse SetBackupRulesSync(SetBackupRulesRequest req)
        {
            return InternalRequestAsync<SetBackupRulesResponse>(req, "SetBackupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetDBInstanceDeletionProtection）用于设置实例销毁保护
        /// </summary>
        /// <param name="req"><see cref="SetDBInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="SetDBInstanceDeletionProtectionResponse"/></returns>
        public Task<SetDBInstanceDeletionProtectionResponse> SetDBInstanceDeletionProtection(SetDBInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<SetDBInstanceDeletionProtectionResponse>(req, "SetDBInstanceDeletionProtection");
        }

        /// <summary>
        /// 本接口（SetDBInstanceDeletionProtection）用于设置实例销毁保护
        /// </summary>
        /// <param name="req"><see cref="SetDBInstanceDeletionProtectionRequest"/></param>
        /// <returns><see cref="SetDBInstanceDeletionProtectionResponse"/></returns>
        public SetDBInstanceDeletionProtectionResponse SetDBInstanceDeletionProtectionSync(SetDBInstanceDeletionProtectionRequest req)
        {
            return InternalRequestAsync<SetDBInstanceDeletionProtectionResponse>(req, "SetDBInstanceDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetInstanceMaintenance ） 用于设置实例维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="SetInstanceMaintenanceRequest"/></param>
        /// <returns><see cref="SetInstanceMaintenanceResponse"/></returns>
        public Task<SetInstanceMaintenanceResponse> SetInstanceMaintenance(SetInstanceMaintenanceRequest req)
        {
            return InternalRequestAsync<SetInstanceMaintenanceResponse>(req, "SetInstanceMaintenance");
        }

        /// <summary>
        /// 本接口（SetInstanceMaintenance ） 用于设置实例维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="SetInstanceMaintenanceRequest"/></param>
        /// <returns><see cref="SetInstanceMaintenanceResponse"/></returns>
        public SetInstanceMaintenanceResponse SetInstanceMaintenanceSync(SetInstanceMaintenanceRequest req)
        {
            return InternalRequestAsync<SetInstanceMaintenanceResponse>(req, "SetInstanceMaintenance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TerminateDBInstances）用于退还包年包月计费实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstancesRequest"/></param>
        /// <returns><see cref="TerminateDBInstancesResponse"/></returns>
        public Task<TerminateDBInstancesResponse> TerminateDBInstances(TerminateDBInstancesRequest req)
        {
            return InternalRequestAsync<TerminateDBInstancesResponse>(req, "TerminateDBInstances");
        }

        /// <summary>
        /// 本接口（TerminateDBInstances）用于退还包年包月计费实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstancesRequest"/></param>
        /// <returns><see cref="TerminateDBInstancesResponse"/></returns>
        public TerminateDBInstancesResponse TerminateDBInstancesSync(TerminateDBInstancesRequest req)
        {
            return InternalRequestAsync<TerminateDBInstancesResponse>(req, "TerminateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpgradeDBInstanceKernelVersion)用于升级数据库实例内核版本。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion");
        }

        /// <summary>
        /// 本接口(UpgradeDBInstanceKernelVersion)用于升级数据库实例内核版本。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionSync(UpgradeDBInstanceKernelVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceKernelVersionResponse>(req, "UpgradeDBInstanceKernelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于跨版本升级数据库内核。当前仅支持3.6版本升级为4.0版本、4.0版本升级为4.2版本、4.2版本升级为4.4版本及4.4版本升级为5.0版本。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDbInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeDbInstanceVersionResponse"/></returns>
        public Task<UpgradeDbInstanceVersionResponse> UpgradeDbInstanceVersion(UpgradeDbInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDbInstanceVersionResponse>(req, "UpgradeDbInstanceVersion");
        }

        /// <summary>
        /// 本接口用于跨版本升级数据库内核。当前仅支持3.6版本升级为4.0版本、4.0版本升级为4.2版本、4.2版本升级为4.4版本及4.4版本升级为5.0版本。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDbInstanceVersionRequest"/></param>
        /// <returns><see cref="UpgradeDbInstanceVersionResponse"/></returns>
        public UpgradeDbInstanceVersionResponse UpgradeDbInstanceVersionSync(UpgradeDbInstanceVersionRequest req)
        {
            return InternalRequestAsync<UpgradeDbInstanceVersionResponse>(req, "UpgradeDbInstanceVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
