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

namespace TencentCloud.Sqlserver.V20180328
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sqlserver.V20180328.Models;

   public class SqlserverClient : AbstractClient{

       private const string endpoint = "sqlserver.tencentcloudapi.com";
       private const string version = "2018-03-28";
       private const string sdkVersion = "SDK_NET_3.0.1097";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SqlserverClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SqlserverClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// 本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BalanceReadOnlyGroup）用于根据预定义的权重平衡每个只读实例的路由权重。预定义权重可根据接口DescribeReadOnlyGroupAutoWeight查询。
        /// </summary>
        /// <param name="req"><see cref="BalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="BalanceReadOnlyGroupResponse"/></returns>
        public Task<BalanceReadOnlyGroupResponse> BalanceReadOnlyGroup(BalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<BalanceReadOnlyGroupResponse>(req, "BalanceReadOnlyGroup");
        }

        /// <summary>
        /// 本接口（BalanceReadOnlyGroup）用于根据预定义的权重平衡每个只读实例的路由权重。预定义权重可根据接口DescribeReadOnlyGroupAutoWeight查询。
        /// </summary>
        /// <param name="req"><see cref="BalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="BalanceReadOnlyGroupResponse"/></returns>
        public BalanceReadOnlyGroupResponse BalanceReadOnlyGroupSync(BalanceReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<BalanceReadOnlyGroupResponse>(req, "BalanceReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloneDB）用于克隆数据库，只支持克隆到本实例，克隆时必须指定新库名称。
        /// </summary>
        /// <param name="req"><see cref="CloneDBRequest"/></param>
        /// <returns><see cref="CloneDBResponse"/></returns>
        public Task<CloneDBResponse> CloneDB(CloneDBRequest req)
        {
            return InternalRequestAsync<CloneDBResponse>(req, "CloneDB");
        }

        /// <summary>
        /// 本接口（CloneDB）用于克隆数据库，只支持克隆到本实例，克隆时必须指定新库名称。
        /// </summary>
        /// <param name="req"><see cref="CloneDBRequest"/></param>
        /// <returns><see cref="CloneDBResponse"/></returns>
        public CloneDBResponse CloneDBSync(CloneDBRequest req)
        {
            return InternalRequestAsync<CloneDBResponse>(req, "CloneDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloseInterCommunication）用于关闭实例互通。
        /// </summary>
        /// <param name="req"><see cref="CloseInterCommunicationRequest"/></param>
        /// <returns><see cref="CloseInterCommunicationResponse"/></returns>
        public Task<CloseInterCommunicationResponse> CloseInterCommunication(CloseInterCommunicationRequest req)
        {
            return InternalRequestAsync<CloseInterCommunicationResponse>(req, "CloseInterCommunication");
        }

        /// <summary>
        /// 本接口（CloseInterCommunication）用于关闭实例互通。
        /// </summary>
        /// <param name="req"><see cref="CloseInterCommunicationRequest"/></param>
        /// <returns><see cref="CloseInterCommunicationResponse"/></returns>
        public CloseInterCommunicationResponse CloseInterCommunicationSync(CloseInterCommunicationRequest req)
        {
            return InternalRequestAsync<CloseInterCommunicationResponse>(req, "CloseInterCommunication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CompleteExpansion）在实例发起扩容后，实例状态处于“升级待切换”时，可立即完成实例升级切换操作，无需等待可维护时间窗。本接口需要在实例低峰时调用，在完全切换成功前，存在部分库不可访问的风险。
        /// </summary>
        /// <param name="req"><see cref="CompleteExpansionRequest"/></param>
        /// <returns><see cref="CompleteExpansionResponse"/></returns>
        public Task<CompleteExpansionResponse> CompleteExpansion(CompleteExpansionRequest req)
        {
            return InternalRequestAsync<CompleteExpansionResponse>(req, "CompleteExpansion");
        }

        /// <summary>
        /// 本接口（CompleteExpansion）在实例发起扩容后，实例状态处于“升级待切换”时，可立即完成实例升级切换操作，无需等待可维护时间窗。本接口需要在实例低峰时调用，在完全切换成功前，存在部分库不可访问的风险。
        /// </summary>
        /// <param name="req"><see cref="CompleteExpansionRequest"/></param>
        /// <returns><see cref="CompleteExpansionResponse"/></returns>
        public CompleteExpansionResponse CompleteExpansionSync(CompleteExpansionRequest req)
        {
            return InternalRequestAsync<CompleteExpansionResponse>(req, "CompleteExpansion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CompleteMigration）作用是完成一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrationRequest"/></param>
        /// <returns><see cref="CompleteMigrationResponse"/></returns>
        public Task<CompleteMigrationResponse> CompleteMigration(CompleteMigrationRequest req)
        {
            return InternalRequestAsync<CompleteMigrationResponse>(req, "CompleteMigration");
        }

        /// <summary>
        /// 本接口（CompleteMigration）作用是完成一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrationRequest"/></param>
        /// <returns><see cref="CompleteMigrationResponse"/></returns>
        public CompleteMigrationResponse CompleteMigrationSync(CompleteMigrationRequest req)
        {
            return InternalRequestAsync<CompleteMigrationResponse>(req, "CompleteMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建实例账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建实例账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateBackup)用于创建备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// 本接口(CreateBackup)用于创建备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateBackupMigration）用于创建备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupMigrationRequest"/></param>
        /// <returns><see cref="CreateBackupMigrationResponse"/></returns>
        public Task<CreateBackupMigrationResponse> CreateBackupMigration(CreateBackupMigrationRequest req)
        {
            return InternalRequestAsync<CreateBackupMigrationResponse>(req, "CreateBackupMigration");
        }

        /// <summary>
        /// 本接口（CreateBackupMigration）用于创建备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupMigrationRequest"/></param>
        /// <returns><see cref="CreateBackupMigrationResponse"/></returns>
        public CreateBackupMigrationResponse CreateBackupMigrationSync(CreateBackupMigrationRequest req)
        {
            return InternalRequestAsync<CreateBackupMigrationResponse>(req, "CreateBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateBasicDBInstances）用于创建基础版实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBasicDBInstancesResponse"/></returns>
        public Task<CreateBasicDBInstancesResponse> CreateBasicDBInstances(CreateBasicDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBasicDBInstancesResponse>(req, "CreateBasicDBInstances");
        }

        /// <summary>
        /// 本接口（CreateBasicDBInstances）用于创建基础版实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBasicDBInstancesResponse"/></returns>
        public CreateBasicDBInstancesResponse CreateBasicDBInstancesSync(CreateBasicDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBasicDBInstancesResponse>(req, "CreateBasicDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateBusinessDBInstances）用于创建商业智能服务实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBusinessDBInstancesResponse"/></returns>
        public Task<CreateBusinessDBInstancesResponse> CreateBusinessDBInstances(CreateBusinessDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBusinessDBInstancesResponse>(req, "CreateBusinessDBInstances");
        }

        /// <summary>
        /// 本接口（CreateBusinessDBInstances）用于创建商业智能服务实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBusinessDBInstancesResponse"/></returns>
        public CreateBusinessDBInstancesResponse CreateBusinessDBInstancesSync(CreateBusinessDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateBusinessDBInstancesResponse>(req, "CreateBusinessDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateBusinessIntelligenceFile）用于添加商业智能服务文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="CreateBusinessIntelligenceFileResponse"/></returns>
        public Task<CreateBusinessIntelligenceFileResponse> CreateBusinessIntelligenceFile(CreateBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<CreateBusinessIntelligenceFileResponse>(req, "CreateBusinessIntelligenceFile");
        }

        /// <summary>
        /// 本接口（CreateBusinessIntelligenceFile）用于添加商业智能服务文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="CreateBusinessIntelligenceFileResponse"/></returns>
        public CreateBusinessIntelligenceFileResponse CreateBusinessIntelligenceFileSync(CreateBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<CreateBusinessIntelligenceFileResponse>(req, "CreateBusinessIntelligenceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCloudDBInstances）用于创建高可用实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudDBInstancesResponse"/></returns>
        public Task<CreateCloudDBInstancesResponse> CreateCloudDBInstances(CreateCloudDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudDBInstancesResponse>(req, "CreateCloudDBInstances");
        }

        /// <summary>
        /// 本接口（CreateCloudDBInstances）用于创建高可用实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudDBInstancesResponse"/></returns>
        public CreateCloudDBInstancesResponse CreateCloudDBInstancesSync(CreateCloudDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudDBInstancesResponse>(req, "CreateCloudDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCloudReadOnlyDBInstances）用于创建只读实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudReadOnlyDBInstancesResponse"/></returns>
        public Task<CreateCloudReadOnlyDBInstancesResponse> CreateCloudReadOnlyDBInstances(CreateCloudReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudReadOnlyDBInstancesResponse>(req, "CreateCloudReadOnlyDBInstances");
        }

        /// <summary>
        /// 本接口（CreateCloudReadOnlyDBInstances）用于创建只读实例 (云盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateCloudReadOnlyDBInstancesResponse"/></returns>
        public CreateCloudReadOnlyDBInstancesResponse CreateCloudReadOnlyDBInstancesSync(CreateCloudReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateCloudReadOnlyDBInstancesResponse>(req, "CreateCloudReadOnlyDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDB）用于创建数据库。
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public Task<CreateDBResponse> CreateDB(CreateDBRequest req)
        {
            return InternalRequestAsync<CreateDBResponse>(req, "CreateDB");
        }

        /// <summary>
        /// 本接口（CreateDB）用于创建数据库。
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public CreateDBResponse CreateDBSync(CreateDBRequest req)
        {
            return InternalRequestAsync<CreateDBResponse>(req, "CreateDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建高可用实例 (本地盘)
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances");
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建高可用实例 (本地盘)
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateDBInstancesResponse>(req, "CreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateIncrementalMigration）用于创建增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationResponse"/></returns>
        public Task<CreateIncrementalMigrationResponse> CreateIncrementalMigration(CreateIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationResponse>(req, "CreateIncrementalMigration");
        }

        /// <summary>
        /// 本接口（CreateIncrementalMigration）用于创建增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="CreateIncrementalMigrationRequest"/></param>
        /// <returns><see cref="CreateIncrementalMigrationResponse"/></returns>
        public CreateIncrementalMigrationResponse CreateIncrementalMigrationSync(CreateIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<CreateIncrementalMigrationResponse>(req, "CreateIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateMigration）作用是创建一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public Task<CreateMigrationResponse> CreateMigration(CreateMigrationRequest req)
        {
            return InternalRequestAsync<CreateMigrationResponse>(req, "CreateMigration");
        }

        /// <summary>
        /// 本接口（CreateMigration）作用是创建一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public CreateMigrationResponse CreateMigrationSync(CreateMigrationRequest req)
        {
            return InternalRequestAsync<CreateMigrationResponse>(req, "CreateMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreatePublishSubscribe）用于创建两个数据库之间的发布订阅关系。作为订阅者，不能再充当发布者，作为发布者可以有多个订阅者实例。
        /// </summary>
        /// <param name="req"><see cref="CreatePublishSubscribeRequest"/></param>
        /// <returns><see cref="CreatePublishSubscribeResponse"/></returns>
        public Task<CreatePublishSubscribeResponse> CreatePublishSubscribe(CreatePublishSubscribeRequest req)
        {
            return InternalRequestAsync<CreatePublishSubscribeResponse>(req, "CreatePublishSubscribe");
        }

        /// <summary>
        /// 本接口（CreatePublishSubscribe）用于创建两个数据库之间的发布订阅关系。作为订阅者，不能再充当发布者，作为发布者可以有多个订阅者实例。
        /// </summary>
        /// <param name="req"><see cref="CreatePublishSubscribeRequest"/></param>
        /// <returns><see cref="CreatePublishSubscribeResponse"/></returns>
        public CreatePublishSubscribeResponse CreatePublishSubscribeSync(CreatePublishSubscribeRequest req)
        {
            return InternalRequestAsync<CreatePublishSubscribeResponse>(req, "CreatePublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateReadOnlyDBInstances）用于创建只读实例 (本地盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstancesResponse"/></returns>
        public Task<CreateReadOnlyDBInstancesResponse> CreateReadOnlyDBInstances(CreateReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstancesResponse>(req, "CreateReadOnlyDBInstances");
        }

        /// <summary>
        /// 本接口（CreateReadOnlyDBInstances）用于创建只读实例 (本地盘)。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstancesResponse"/></returns>
        public CreateReadOnlyDBInstancesResponse CreateReadOnlyDBInstancesSync(CreateReadOnlyDBInstancesRequest req)
        {
            return InternalRequestAsync<CreateReadOnlyDBInstancesResponse>(req, "CreateReadOnlyDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CutXEvents)用于手动切割阻塞日志和死锁日志。
        /// </summary>
        /// <param name="req"><see cref="CutXEventsRequest"/></param>
        /// <returns><see cref="CutXEventsResponse"/></returns>
        public Task<CutXEventsResponse> CutXEvents(CutXEventsRequest req)
        {
            return InternalRequestAsync<CutXEventsResponse>(req, "CutXEvents");
        }

        /// <summary>
        /// 本接口(CutXEvents)用于手动切割阻塞日志和死锁日志。
        /// </summary>
        /// <param name="req"><see cref="CutXEventsRequest"/></param>
        /// <returns><see cref="CutXEventsResponse"/></returns>
        public CutXEventsResponse CutXEventsSync(CutXEventsRequest req)
        {
            return InternalRequestAsync<CutXEventsResponse>(req, "CutXEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除实例账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount");
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除实例账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteBackupMigration）用于删除备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupMigrationRequest"/></param>
        /// <returns><see cref="DeleteBackupMigrationResponse"/></returns>
        public Task<DeleteBackupMigrationResponse> DeleteBackupMigration(DeleteBackupMigrationRequest req)
        {
            return InternalRequestAsync<DeleteBackupMigrationResponse>(req, "DeleteBackupMigration");
        }

        /// <summary>
        /// 本接口（DeleteBackupMigration）用于删除备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupMigrationRequest"/></param>
        /// <returns><see cref="DeleteBackupMigrationResponse"/></returns>
        public DeleteBackupMigrationResponse DeleteBackupMigrationSync(DeleteBackupMigrationRequest req)
        {
            return InternalRequestAsync<DeleteBackupMigrationResponse>(req, "DeleteBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteBusinessIntelligenceFile）用于删除商业智能文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DeleteBusinessIntelligenceFileResponse"/></returns>
        public Task<DeleteBusinessIntelligenceFileResponse> DeleteBusinessIntelligenceFile(DeleteBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DeleteBusinessIntelligenceFileResponse>(req, "DeleteBusinessIntelligenceFile");
        }

        /// <summary>
        /// 本接口（DeleteBusinessIntelligenceFile）用于删除商业智能文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DeleteBusinessIntelligenceFileResponse"/></returns>
        public DeleteBusinessIntelligenceFileResponse DeleteBusinessIntelligenceFileSync(DeleteBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DeleteBusinessIntelligenceFileResponse>(req, "DeleteBusinessIntelligenceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteDB)用于删除数据库。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public Task<DeleteDBResponse> DeleteDB(DeleteDBRequest req)
        {
            return InternalRequestAsync<DeleteDBResponse>(req, "DeleteDB");
        }

        /// <summary>
        /// 本接口(DeleteDB)用于删除数据库。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public DeleteDBResponse DeleteDBSync(DeleteDBRequest req)
        {
            return InternalRequestAsync<DeleteDBResponse>(req, "DeleteDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDBInstance）用于释放回收站中的SQL server实例(立即下线)。释放后的实例将保存一段时间后物理销毁。其发布订阅将自动解除，其ro副本将自动释放。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceResponse"/></returns>
        public Task<DeleteDBInstanceResponse> DeleteDBInstance(DeleteDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceResponse>(req, "DeleteDBInstance");
        }

        /// <summary>
        /// 本接口（DeleteDBInstance）用于释放回收站中的SQL server实例(立即下线)。释放后的实例将保存一段时间后物理销毁。其发布订阅将自动解除，其ro副本将自动释放。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceResponse"/></returns>
        public DeleteDBInstanceResponse DeleteDBInstanceSync(DeleteDBInstanceRequest req)
        {
            return InternalRequestAsync<DeleteDBInstanceResponse>(req, "DeleteDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteIncrementalMigration）用于删除增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationResponse"/></returns>
        public Task<DeleteIncrementalMigrationResponse> DeleteIncrementalMigration(DeleteIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationResponse>(req, "DeleteIncrementalMigration");
        }

        /// <summary>
        /// 本接口（DeleteIncrementalMigration）用于删除增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DeleteIncrementalMigrationResponse"/></returns>
        public DeleteIncrementalMigrationResponse DeleteIncrementalMigrationSync(DeleteIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DeleteIncrementalMigrationResponse>(req, "DeleteIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteMigration）用于删除迁移任务
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public Task<DeleteMigrationResponse> DeleteMigration(DeleteMigrationRequest req)
        {
            return InternalRequestAsync<DeleteMigrationResponse>(req, "DeleteMigration");
        }

        /// <summary>
        /// 本接口（DeleteMigration）用于删除迁移任务
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public DeleteMigrationResponse DeleteMigrationSync(DeleteMigrationRequest req)
        {
            return InternalRequestAsync<DeleteMigrationResponse>(req, "DeleteMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeletePublishSubscribe）用于删除两个数据库间的发布订阅关系。
        /// </summary>
        /// <param name="req"><see cref="DeletePublishSubscribeRequest"/></param>
        /// <returns><see cref="DeletePublishSubscribeResponse"/></returns>
        public Task<DeletePublishSubscribeResponse> DeletePublishSubscribe(DeletePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DeletePublishSubscribeResponse>(req, "DeletePublishSubscribe");
        }

        /// <summary>
        /// 本接口（DeletePublishSubscribe）用于删除两个数据库间的发布订阅关系。
        /// </summary>
        /// <param name="req"><see cref="DeletePublishSubscribeRequest"/></param>
        /// <returns><see cref="DeletePublishSubscribeResponse"/></returns>
        public DeletePublishSubscribeResponse DeletePublishSubscribeSync(DeletePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DeletePublishSubscribeResponse>(req, "DeletePublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteRestoreTask)用于删除回档任务记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteRestoreTaskRequest"/></param>
        /// <returns><see cref="DeleteRestoreTaskResponse"/></returns>
        public Task<DeleteRestoreTaskResponse> DeleteRestoreTask(DeleteRestoreTaskRequest req)
        {
            return InternalRequestAsync<DeleteRestoreTaskResponse>(req, "DeleteRestoreTask");
        }

        /// <summary>
        /// 本接口(DeleteRestoreTask)用于删除回档任务记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteRestoreTaskRequest"/></param>
        /// <returns><see cref="DeleteRestoreTaskResponse"/></returns>
        public DeleteRestoreTaskResponse DeleteRestoreTaskSync(DeleteRestoreTaskRequest req)
        {
            return InternalRequestAsync<DeleteRestoreTaskResponse>(req, "DeleteRestoreTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAccountPrivilegeByDB)用于查询数据库关联的账号和权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegeByDBRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegeByDBResponse"/></returns>
        public Task<DescribeAccountPrivilegeByDBResponse> DescribeAccountPrivilegeByDB(DescribeAccountPrivilegeByDBRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegeByDBResponse>(req, "DescribeAccountPrivilegeByDB");
        }

        /// <summary>
        /// 本接口(DescribeAccountPrivilegeByDB)用于查询数据库关联的账号和权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegeByDBRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegeByDBResponse"/></returns>
        public DescribeAccountPrivilegeByDBResponse DescribeAccountPrivilegeByDBSync(DescribeAccountPrivilegeByDBRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegeByDBResponse>(req, "DescribeAccountPrivilegeByDB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于拉取实例账户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于拉取实例账户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupByFlowId)用于通过备份创建流程的ID查询创建的备份详情，流程ID可从接口CreateBackup中获得。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeBackupByFlowIdResponse"/></returns>
        public Task<DescribeBackupByFlowIdResponse> DescribeBackupByFlowId(DescribeBackupByFlowIdRequest req)
        {
            return InternalRequestAsync<DescribeBackupByFlowIdResponse>(req, "DescribeBackupByFlowId");
        }

        /// <summary>
        /// 本接口(DescribeBackupByFlowId)用于通过备份创建流程的ID查询创建的备份详情，流程ID可从接口CreateBackup中获得。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeBackupByFlowIdResponse"/></returns>
        public DescribeBackupByFlowIdResponse DescribeBackupByFlowIdSync(DescribeBackupByFlowIdRequest req)
        {
            return InternalRequestAsync<DescribeBackupByFlowIdResponse>(req, "DescribeBackupByFlowId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupCommand）用于查询以规范的格式创建备份的命令。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupCommandRequest"/></param>
        /// <returns><see cref="DescribeBackupCommandResponse"/></returns>
        public Task<DescribeBackupCommandResponse> DescribeBackupCommand(DescribeBackupCommandRequest req)
        {
            return InternalRequestAsync<DescribeBackupCommandResponse>(req, "DescribeBackupCommand");
        }

        /// <summary>
        /// 本接口（DescribeBackupCommand）用于查询以规范的格式创建备份的命令。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupCommandRequest"/></param>
        /// <returns><see cref="DescribeBackupCommandResponse"/></returns>
        public DescribeBackupCommandResponse DescribeBackupCommandSync(DescribeBackupCommandRequest req)
        {
            return InternalRequestAsync<DescribeBackupCommandResponse>(req, "DescribeBackupCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupFiles)用于查询单库备份明细
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public Task<DescribeBackupFilesResponse> DescribeBackupFiles(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles");
        }

        /// <summary>
        /// 本接口(DescribeBackupFiles)用于查询单库备份明细
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public DescribeBackupFilesResponse DescribeBackupFilesSync(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupMigration）用于创建增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMigrationRequest"/></param>
        /// <returns><see cref="DescribeBackupMigrationResponse"/></returns>
        public Task<DescribeBackupMigrationResponse> DescribeBackupMigration(DescribeBackupMigrationRequest req)
        {
            return InternalRequestAsync<DescribeBackupMigrationResponse>(req, "DescribeBackupMigration");
        }

        /// <summary>
        /// 本接口（DescribeBackupMigration）用于创建增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMigrationRequest"/></param>
        /// <returns><see cref="DescribeBackupMigrationResponse"/></returns>
        public DescribeBackupMigrationResponse DescribeBackupMigrationSync(DescribeBackupMigrationRequest req)
        {
            return InternalRequestAsync<DescribeBackupMigrationResponse>(req, "DescribeBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupMonitor)用于查询备份空间使用详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMonitorRequest"/></param>
        /// <returns><see cref="DescribeBackupMonitorResponse"/></returns>
        public Task<DescribeBackupMonitorResponse> DescribeBackupMonitor(DescribeBackupMonitorRequest req)
        {
            return InternalRequestAsync<DescribeBackupMonitorResponse>(req, "DescribeBackupMonitor");
        }

        /// <summary>
        /// 本接口(DescribeBackupMonitor)用于查询备份空间使用详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupMonitorRequest"/></param>
        /// <returns><see cref="DescribeBackupMonitorResponse"/></returns>
        public DescribeBackupMonitorResponse DescribeBackupMonitorSync(DescribeBackupMonitorRequest req)
        {
            return InternalRequestAsync<DescribeBackupMonitorResponse>(req, "DescribeBackupMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupStatistical)用于查询备份实时统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeBackupStatisticalResponse"/></returns>
        public Task<DescribeBackupStatisticalResponse> DescribeBackupStatistical(DescribeBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeBackupStatisticalResponse>(req, "DescribeBackupStatistical");
        }

        /// <summary>
        /// 本接口(DescribeBackupStatistical)用于查询备份实时统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeBackupStatisticalResponse"/></returns>
        public DescribeBackupStatisticalResponse DescribeBackupStatisticalSync(DescribeBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeBackupStatisticalResponse>(req, "DescribeBackupStatistical")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackupSummary)用于查询数据库备份概览信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummaryRequest"/></param>
        /// <returns><see cref="DescribeBackupSummaryResponse"/></returns>
        public Task<DescribeBackupSummaryResponse> DescribeBackupSummary(DescribeBackupSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummaryResponse>(req, "DescribeBackupSummary");
        }

        /// <summary>
        /// 本接口(DescribeBackupSummary)用于查询数据库备份概览信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummaryRequest"/></param>
        /// <returns><see cref="DescribeBackupSummaryResponse"/></returns>
        public DescribeBackupSummaryResponse DescribeBackupSummarySync(DescribeBackupSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBackupSummaryResponse>(req, "DescribeBackupSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupUploadSize）用于查询上传的备份文件大小。在备份上传类型是COS_UPLOAD(备份放在业务的对象存储上)时有效。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUploadSizeRequest"/></param>
        /// <returns><see cref="DescribeBackupUploadSizeResponse"/></returns>
        public Task<DescribeBackupUploadSizeResponse> DescribeBackupUploadSize(DescribeBackupUploadSizeRequest req)
        {
            return InternalRequestAsync<DescribeBackupUploadSizeResponse>(req, "DescribeBackupUploadSize");
        }

        /// <summary>
        /// 本接口（DescribeBackupUploadSize）用于查询上传的备份文件大小。在备份上传类型是COS_UPLOAD(备份放在业务的对象存储上)时有效。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUploadSizeRequest"/></param>
        /// <returns><see cref="DescribeBackupUploadSizeResponse"/></returns>
        public DescribeBackupUploadSizeResponse DescribeBackupUploadSizeSync(DescribeBackupUploadSizeRequest req)
        {
            return InternalRequestAsync<DescribeBackupUploadSizeResponse>(req, "DescribeBackupUploadSize")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeBackups)用于查询备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups");
        }

        /// <summary>
        /// 本接口(DescribeBackups)用于查询备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public DescribeBackupsResponse DescribeBackupsSync(DescribeBackupsRequest req)
        {
            return InternalRequestAsync<DescribeBackupsResponse>(req, "DescribeBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBusinessIntelligenceFile）用于查询商业智能服务需要的文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DescribeBusinessIntelligenceFileResponse"/></returns>
        public Task<DescribeBusinessIntelligenceFileResponse> DescribeBusinessIntelligenceFile(DescribeBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DescribeBusinessIntelligenceFileResponse>(req, "DescribeBusinessIntelligenceFile");
        }

        /// <summary>
        /// 本接口（DescribeBusinessIntelligenceFile）用于查询商业智能服务需要的文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeBusinessIntelligenceFileRequest"/></param>
        /// <returns><see cref="DescribeBusinessIntelligenceFileResponse"/></returns>
        public DescribeBusinessIntelligenceFileResponse DescribeBusinessIntelligenceFileSync(DescribeBusinessIntelligenceFileRequest req)
        {
            return InternalRequestAsync<DescribeBusinessIntelligenceFileResponse>(req, "DescribeBusinessIntelligenceFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCollationTimeZone)用于查询实例支持的字符集和时区。
        /// </summary>
        /// <param name="req"><see cref="DescribeCollationTimeZoneRequest"/></param>
        /// <returns><see cref="DescribeCollationTimeZoneResponse"/></returns>
        public Task<DescribeCollationTimeZoneResponse> DescribeCollationTimeZone(DescribeCollationTimeZoneRequest req)
        {
            return InternalRequestAsync<DescribeCollationTimeZoneResponse>(req, "DescribeCollationTimeZone");
        }

        /// <summary>
        /// 本接口(DescribeCollationTimeZone)用于查询实例支持的字符集和时区。
        /// </summary>
        /// <param name="req"><see cref="DescribeCollationTimeZoneRequest"/></param>
        /// <returns><see cref="DescribeCollationTimeZoneResponse"/></returns>
        public DescribeCollationTimeZoneResponse DescribeCollationTimeZoneSync(DescribeCollationTimeZoneRequest req)
        {
            return InternalRequestAsync<DescribeCollationTimeZoneResponse>(req, "DescribeCollationTimeZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCrossBackupStatistical)用于查询跨地域备份实时统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeCrossBackupStatisticalResponse"/></returns>
        public Task<DescribeCrossBackupStatisticalResponse> DescribeCrossBackupStatistical(DescribeCrossBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeCrossBackupStatisticalResponse>(req, "DescribeCrossBackupStatistical");
        }

        /// <summary>
        /// 本接口(DescribeCrossBackupStatistical)用于查询跨地域备份实时统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBackupStatisticalRequest"/></param>
        /// <returns><see cref="DescribeCrossBackupStatisticalResponse"/></returns>
        public DescribeCrossBackupStatisticalResponse DescribeCrossBackupStatisticalSync(DescribeCrossBackupStatisticalRequest req)
        {
            return InternalRequestAsync<DescribeCrossBackupStatisticalResponse>(req, "DescribeCrossBackupStatistical")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCrossRegionZone)根据主实例查询备机的容灾地域和可用区。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionZoneResponse"/></returns>
        public Task<DescribeCrossRegionZoneResponse> DescribeCrossRegionZone(DescribeCrossRegionZoneRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionZoneResponse>(req, "DescribeCrossRegionZone");
        }

        /// <summary>
        /// 本接口(DescribeCrossRegionZone)根据主实例查询备机的容灾地域和可用区。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionZoneResponse"/></returns>
        public DescribeCrossRegionZoneResponse DescribeCrossRegionZoneSync(DescribeCrossRegionZoneRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionZoneResponse>(req, "DescribeCrossRegionZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCrossRegions)用于查询跨地域备份的目标地域。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionsRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionsResponse"/></returns>
        public Task<DescribeCrossRegionsResponse> DescribeCrossRegions(DescribeCrossRegionsRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionsResponse>(req, "DescribeCrossRegions");
        }

        /// <summary>
        /// 本接口(DescribeCrossRegions)用于查询跨地域备份的目标地域。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionsRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionsResponse"/></returns>
        public DescribeCrossRegionsResponse DescribeCrossRegionsSync(DescribeCrossRegionsRequest req)
        {
            return InternalRequestAsync<DescribeCrossRegionsResponse>(req, "DescribeCrossRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBCharsets）用于查询实例支持的数据库字符集。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCharsetsRequest"/></param>
        /// <returns><see cref="DescribeDBCharsetsResponse"/></returns>
        public Task<DescribeDBCharsetsResponse> DescribeDBCharsets(DescribeDBCharsetsRequest req)
        {
            return InternalRequestAsync<DescribeDBCharsetsResponse>(req, "DescribeDBCharsets");
        }

        /// <summary>
        /// 本接口（DescribeDBCharsets）用于查询实例支持的数据库字符集。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCharsetsRequest"/></param>
        /// <returns><see cref="DescribeDBCharsetsResponse"/></returns>
        public DescribeDBCharsetsResponse DescribeDBCharsetsSync(DescribeDBCharsetsRequest req)
        {
            return InternalRequestAsync<DescribeDBCharsetsResponse>(req, "DescribeDBCharsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceInter）用于查询互通实例的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInterRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInterResponse"/></returns>
        public Task<DescribeDBInstanceInterResponse> DescribeDBInstanceInter(DescribeDBInstanceInterRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInterResponse>(req, "DescribeDBInstanceInter");
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceInter）用于查询互通实例的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInterRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInterResponse"/></returns>
        public DescribeDBInstanceInterResponse DescribeDBInstanceInterSync(DescribeDBInstanceInterRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceInterResponse>(req, "DescribeDBInstanceInter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBInstancesAttribute）用于查询实例附属属性
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesAttributeResponse"/></returns>
        public Task<DescribeDBInstancesAttributeResponse> DescribeDBInstancesAttribute(DescribeDBInstancesAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesAttributeResponse>(req, "DescribeDBInstancesAttribute");
        }

        /// <summary>
        /// 本接口（DescribeDBInstancesAttribute）用于查询实例附属属性
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesAttributeResponse"/></returns>
        public DescribeDBInstancesAttributeResponse DescribeDBInstancesAttributeSync(DescribeDBInstancesAttributeRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesAttributeResponse>(req, "DescribeDBInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBPrivilegeByAccount)用于查询账号关联的数据库和权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPrivilegeByAccountRequest"/></param>
        /// <returns><see cref="DescribeDBPrivilegeByAccountResponse"/></returns>
        public Task<DescribeDBPrivilegeByAccountResponse> DescribeDBPrivilegeByAccount(DescribeDBPrivilegeByAccountRequest req)
        {
            return InternalRequestAsync<DescribeDBPrivilegeByAccountResponse>(req, "DescribeDBPrivilegeByAccount");
        }

        /// <summary>
        /// 本接口(DescribeDBPrivilegeByAccount)用于查询账号关联的数据库和权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPrivilegeByAccountRequest"/></param>
        /// <returns><see cref="DescribeDBPrivilegeByAccountResponse"/></returns>
        public DescribeDBPrivilegeByAccountResponse DescribeDBPrivilegeByAccountSync(DescribeDBPrivilegeByAccountRequest req)
        {
            return InternalRequestAsync<DescribeDBPrivilegeByAccountResponse>(req, "DescribeDBPrivilegeByAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBRestoreTime）用于查询可回档的数据库
        /// </summary>
        /// <param name="req"><see cref="DescribeDBRestoreTimeRequest"/></param>
        /// <returns><see cref="DescribeDBRestoreTimeResponse"/></returns>
        public Task<DescribeDBRestoreTimeResponse> DescribeDBRestoreTime(DescribeDBRestoreTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBRestoreTimeResponse>(req, "DescribeDBRestoreTime");
        }

        /// <summary>
        /// 本接口（DescribeDBRestoreTime）用于查询可回档的数据库
        /// </summary>
        /// <param name="req"><see cref="DescribeDBRestoreTimeRequest"/></param>
        /// <returns><see cref="DescribeDBRestoreTimeResponse"/></returns>
        public DescribeDBRestoreTimeResponse DescribeDBRestoreTimeSync(DescribeDBRestoreTimeRequest req)
        {
            return InternalRequestAsync<DescribeDBRestoreTimeResponse>(req, "DescribeDBRestoreTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDBs）用于查询数据库列表。**已废弃，请使用接口DescribeDatabases**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public Task<DescribeDBsResponse> DescribeDBs(DescribeDBsRequest req)
        {
            return InternalRequestAsync<DescribeDBsResponse>(req, "DescribeDBs");
        }

        /// <summary>
        /// 本接口（DescribeDBs）用于查询数据库列表。**已废弃，请使用接口DescribeDatabases**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public DescribeDBsResponse DescribeDBsSync(DescribeDBsRequest req)
        {
            return InternalRequestAsync<DescribeDBsResponse>(req, "DescribeDBs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBsNormal)用于查询数据库配置信息，此接口不包含数据库的关联账号。**此接口已废弃，请使用DescribeDatabasesNormal。**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsNormalRequest"/></param>
        /// <returns><see cref="DescribeDBsNormalResponse"/></returns>
        public Task<DescribeDBsNormalResponse> DescribeDBsNormal(DescribeDBsNormalRequest req)
        {
            return InternalRequestAsync<DescribeDBsNormalResponse>(req, "DescribeDBsNormal");
        }

        /// <summary>
        /// 本接口(DescribeDBsNormal)用于查询数据库配置信息，此接口不包含数据库的关联账号。**此接口已废弃，请使用DescribeDatabasesNormal。**
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsNormalRequest"/></param>
        /// <returns><see cref="DescribeDBsNormalResponse"/></returns>
        public DescribeDBsNormalResponse DescribeDBsNormalSync(DescribeDBsNormalRequest req)
        {
            return InternalRequestAsync<DescribeDBsNormalResponse>(req, "DescribeDBsNormal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDatabaseNames）查询账户关联的数据库名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseNamesRequest"/></param>
        /// <returns><see cref="DescribeDatabaseNamesResponse"/></returns>
        public Task<DescribeDatabaseNamesResponse> DescribeDatabaseNames(DescribeDatabaseNamesRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseNamesResponse>(req, "DescribeDatabaseNames");
        }

        /// <summary>
        /// 本接口（DescribeDatabaseNames）查询账户关联的数据库名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseNamesRequest"/></param>
        /// <returns><see cref="DescribeDatabaseNamesResponse"/></returns>
        public DescribeDatabaseNamesResponse DescribeDatabaseNamesSync(DescribeDatabaseNamesRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseNamesResponse>(req, "DescribeDatabaseNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBsNormal)用于查询数据库配置信息，此接口不包含数据库的关联账号
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesNormalRequest"/></param>
        /// <returns><see cref="DescribeDatabasesNormalResponse"/></returns>
        public Task<DescribeDatabasesNormalResponse> DescribeDatabasesNormal(DescribeDatabasesNormalRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesNormalResponse>(req, "DescribeDatabasesNormal");
        }

        /// <summary>
        /// 本接口(DescribeDBsNormal)用于查询数据库配置信息，此接口不包含数据库的关联账号
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesNormalRequest"/></param>
        /// <returns><see cref="DescribeDatabasesNormalResponse"/></returns>
        public DescribeDatabasesNormalResponse DescribeDatabasesNormalSync(DescribeDatabasesNormalRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesNormalResponse>(req, "DescribeDatabasesNormal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeFlowStatus)用于查询流程状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public Task<DescribeFlowStatusResponse> DescribeFlowStatus(DescribeFlowStatusRequest req)
        {
            return InternalRequestAsync<DescribeFlowStatusResponse>(req, "DescribeFlowStatus");
        }

        /// <summary>
        /// 本接口(DescribeFlowStatus)用于查询流程状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public DescribeFlowStatusResponse DescribeFlowStatusSync(DescribeFlowStatusRequest req)
        {
            return InternalRequestAsync<DescribeFlowStatusResponse>(req, "DescribeFlowStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeHASwitchLog)用于手动主备切换。
        /// </summary>
        /// <param name="req"><see cref="DescribeHASwitchLogRequest"/></param>
        /// <returns><see cref="DescribeHASwitchLogResponse"/></returns>
        public Task<DescribeHASwitchLogResponse> DescribeHASwitchLog(DescribeHASwitchLogRequest req)
        {
            return InternalRequestAsync<DescribeHASwitchLogResponse>(req, "DescribeHASwitchLog");
        }

        /// <summary>
        /// 本接口(DescribeHASwitchLog)用于手动主备切换。
        /// </summary>
        /// <param name="req"><see cref="DescribeHASwitchLogRequest"/></param>
        /// <returns><see cref="DescribeHASwitchLogResponse"/></returns>
        public DescribeHASwitchLogResponse DescribeHASwitchLogSync(DescribeHASwitchLogRequest req)
        {
            return InternalRequestAsync<DescribeHASwitchLogResponse>(req, "DescribeHASwitchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIncrementalMigration）用于查询增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationResponse"/></returns>
        public Task<DescribeIncrementalMigrationResponse> DescribeIncrementalMigration(DescribeIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationResponse>(req, "DescribeIncrementalMigration");
        }

        /// <summary>
        /// 本接口（DescribeIncrementalMigration）用于查询增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementalMigrationRequest"/></param>
        /// <returns><see cref="DescribeIncrementalMigrationResponse"/></returns>
        public DescribeIncrementalMigrationResponse DescribeIncrementalMigrationSync(DescribeIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<DescribeIncrementalMigrationResponse>(req, "DescribeIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInquiryPriceParameter）用于查询实例询价计费参数。当前接口查询实例新购的计费参数。内部接口用于活动页售卖场景。
        /// </summary>
        /// <param name="req"><see cref="DescribeInquiryPriceParameterRequest"/></param>
        /// <returns><see cref="DescribeInquiryPriceParameterResponse"/></returns>
        public Task<DescribeInquiryPriceParameterResponse> DescribeInquiryPriceParameter(DescribeInquiryPriceParameterRequest req)
        {
            return InternalRequestAsync<DescribeInquiryPriceParameterResponse>(req, "DescribeInquiryPriceParameter");
        }

        /// <summary>
        /// 本接口（DescribeInquiryPriceParameter）用于查询实例询价计费参数。当前接口查询实例新购的计费参数。内部接口用于活动页售卖场景。
        /// </summary>
        /// <param name="req"><see cref="DescribeInquiryPriceParameterRequest"/></param>
        /// <returns><see cref="DescribeInquiryPriceParameterResponse"/></returns>
        public DescribeInquiryPriceParameterResponse DescribeInquiryPriceParameterSync(DescribeInquiryPriceParameterRequest req)
        {
            return InternalRequestAsync<DescribeInquiryPriceParameterResponse>(req, "DescribeInquiryPriceParameter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceByOrders）用于根据订单号查询资源ID
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByOrdersRequest"/></param>
        /// <returns><see cref="DescribeInstanceByOrdersResponse"/></returns>
        public Task<DescribeInstanceByOrdersResponse> DescribeInstanceByOrders(DescribeInstanceByOrdersRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByOrdersResponse>(req, "DescribeInstanceByOrders");
        }

        /// <summary>
        /// 本接口（DescribeInstanceByOrders）用于根据订单号查询资源ID
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceByOrdersRequest"/></param>
        /// <returns><see cref="DescribeInstanceByOrdersResponse"/></returns>
        public DescribeInstanceByOrdersResponse DescribeInstanceByOrdersSync(DescribeInstanceByOrdersRequest req)
        {
            return InternalRequestAsync<DescribeInstanceByOrdersResponse>(req, "DescribeInstanceByOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeInstanceParamRecords）用于查询实例参数修改历史。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords");
        }

        /// <summary>
        /// 该接口（DescribeInstanceParamRecords）用于查询实例参数修改历史。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// 该接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceTasks）用于查询实例相关的异步任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTasksRequest"/></param>
        /// <returns><see cref="DescribeInstanceTasksResponse"/></returns>
        public Task<DescribeInstanceTasksResponse> DescribeInstanceTasks(DescribeInstanceTasksRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTasksResponse>(req, "DescribeInstanceTasks");
        }

        /// <summary>
        /// 本接口（DescribeInstanceTasks）用于查询实例相关的异步任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTasksRequest"/></param>
        /// <returns><see cref="DescribeInstanceTasksResponse"/></returns>
        public DescribeInstanceTasksResponse DescribeInstanceTasksSync(DescribeInstanceTasksRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTasksResponse>(req, "DescribeInstanceTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceTradeParameter）用于查询实例的计费参数，当前接口默认返回创建实例时需要的计费参数。内部接口用于活动页售卖场景。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTradeParameterRequest"/></param>
        /// <returns><see cref="DescribeInstanceTradeParameterResponse"/></returns>
        public Task<DescribeInstanceTradeParameterResponse> DescribeInstanceTradeParameter(DescribeInstanceTradeParameterRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTradeParameterResponse>(req, "DescribeInstanceTradeParameter");
        }

        /// <summary>
        /// 本接口（DescribeInstanceTradeParameter）用于查询实例的计费参数，当前接口默认返回创建实例时需要的计费参数。内部接口用于活动页售卖场景。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTradeParameterRequest"/></param>
        /// <returns><see cref="DescribeInstanceTradeParameterResponse"/></returns>
        public DescribeInstanceTradeParameterResponse DescribeInstanceTradeParameterSync(DescribeInstanceTradeParameterRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTradeParameterResponse>(req, "DescribeInstanceTradeParameter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMaintenanceSpan）根据实例ID查询该实例的可维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceSpanRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceSpanResponse"/></returns>
        public Task<DescribeMaintenanceSpanResponse> DescribeMaintenanceSpan(DescribeMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceSpanResponse>(req, "DescribeMaintenanceSpan");
        }

        /// <summary>
        /// 本接口（DescribeMaintenanceSpan）根据实例ID查询该实例的可维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceSpanRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceSpanResponse"/></returns>
        public DescribeMaintenanceSpanResponse DescribeMaintenanceSpanSync(DescribeMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceSpanResponse>(req, "DescribeMaintenanceSpan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMigrationDatabases）的作用是查询待迁移数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDatabasesRequest"/></param>
        /// <returns><see cref="DescribeMigrationDatabasesResponse"/></returns>
        public Task<DescribeMigrationDatabasesResponse> DescribeMigrationDatabases(DescribeMigrationDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDatabasesResponse>(req, "DescribeMigrationDatabases");
        }

        /// <summary>
        /// 本接口（DescribeMigrationDatabases）的作用是查询待迁移数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDatabasesRequest"/></param>
        /// <returns><see cref="DescribeMigrationDatabasesResponse"/></returns>
        public DescribeMigrationDatabasesResponse DescribeMigrationDatabasesSync(DescribeMigrationDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDatabasesResponse>(req, "DescribeMigrationDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMigrationDetail）用于查询迁移任务的详细情况
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail");
        }

        /// <summary>
        /// 本接口（DescribeMigrationDetail）用于查询迁移任务的详细情况
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
            return InternalRequestAsync<DescribeMigrationDetailResponse>(req, "DescribeMigrationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMigrations）根据输入的限定条件，查询符合条件的迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public Task<DescribeMigrationsResponse> DescribeMigrations(DescribeMigrationsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationsResponse>(req, "DescribeMigrations");
        }

        /// <summary>
        /// 本接口（DescribeMigrations）根据输入的限定条件，查询符合条件的迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public DescribeMigrationsResponse DescribeMigrationsSync(DescribeMigrationsRequest req)
        {
            return InternalRequestAsync<DescribeMigrationsResponse>(req, "DescribeMigrations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeProductConfig) 用于查询售卖规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig");
        }

        /// <summary>
        /// 本接口 (DescribeProductConfig) 用于查询售卖规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
            return InternalRequestAsync<DescribeProductConfigResponse>(req, "DescribeProductConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeProductSpec) 用于查询全地域售卖规格配置（内部前端使用不公开）
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSpecRequest"/></param>
        /// <returns><see cref="DescribeProductSpecResponse"/></returns>
        public Task<DescribeProductSpecResponse> DescribeProductSpec(DescribeProductSpecRequest req)
        {
            return InternalRequestAsync<DescribeProductSpecResponse>(req, "DescribeProductSpec");
        }

        /// <summary>
        /// 本接口 (DescribeProductSpec) 用于查询全地域售卖规格配置（内部前端使用不公开）
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSpecRequest"/></param>
        /// <returns><see cref="DescribeProductSpecResponse"/></returns>
        public DescribeProductSpecResponse DescribeProductSpecSync(DescribeProductSpecRequest req)
        {
            return InternalRequestAsync<DescribeProductSpecResponse>(req, "DescribeProductSpec")
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
        /// 本接口（DescribePublishSubscribe）用于查询发布订阅关系列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePublishSubscribeRequest"/></param>
        /// <returns><see cref="DescribePublishSubscribeResponse"/></returns>
        public Task<DescribePublishSubscribeResponse> DescribePublishSubscribe(DescribePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DescribePublishSubscribeResponse>(req, "DescribePublishSubscribe");
        }

        /// <summary>
        /// 本接口（DescribePublishSubscribe）用于查询发布订阅关系列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePublishSubscribeRequest"/></param>
        /// <returns><see cref="DescribePublishSubscribeResponse"/></returns>
        public DescribePublishSubscribeResponse DescribePublishSubscribeSync(DescribePublishSubscribeRequest req)
        {
            return InternalRequestAsync<DescribePublishSubscribeResponse>(req, "DescribePublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupAutoWeight）用于查询只读组的自动权重分配结果，在接口BalanceReadOnlyGroup接口中按照自动权重分配结果进行路由权重分配。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupAutoWeightRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupAutoWeightResponse"/></returns>
        public Task<DescribeReadOnlyGroupAutoWeightResponse> DescribeReadOnlyGroupAutoWeight(DescribeReadOnlyGroupAutoWeightRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupAutoWeightResponse>(req, "DescribeReadOnlyGroupAutoWeight");
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupAutoWeight）用于查询只读组的自动权重分配结果，在接口BalanceReadOnlyGroup接口中按照自动权重分配结果进行路由权重分配。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupAutoWeightRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupAutoWeightResponse"/></returns>
        public DescribeReadOnlyGroupAutoWeightResponse DescribeReadOnlyGroupAutoWeightSync(DescribeReadOnlyGroupAutoWeightRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupAutoWeightResponse>(req, "DescribeReadOnlyGroupAutoWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupByReadOnlyInstance）用于通过只读副本实例ID查询其所在的只读组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupByReadOnlyInstanceRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupByReadOnlyInstanceResponse"/></returns>
        public Task<DescribeReadOnlyGroupByReadOnlyInstanceResponse> DescribeReadOnlyGroupByReadOnlyInstance(DescribeReadOnlyGroupByReadOnlyInstanceRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupByReadOnlyInstanceResponse>(req, "DescribeReadOnlyGroupByReadOnlyInstance");
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupByReadOnlyInstance）用于通过只读副本实例ID查询其所在的只读组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupByReadOnlyInstanceRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupByReadOnlyInstanceResponse"/></returns>
        public DescribeReadOnlyGroupByReadOnlyInstanceResponse DescribeReadOnlyGroupByReadOnlyInstanceSync(DescribeReadOnlyGroupByReadOnlyInstanceRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupByReadOnlyInstanceResponse>(req, "DescribeReadOnlyGroupByReadOnlyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupDetails）用于查询只读组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupDetailsResponse"/></returns>
        public Task<DescribeReadOnlyGroupDetailsResponse> DescribeReadOnlyGroupDetails(DescribeReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupDetailsResponse>(req, "DescribeReadOnlyGroupDetails");
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupDetails）用于查询只读组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupDetailsResponse"/></returns>
        public DescribeReadOnlyGroupDetailsResponse DescribeReadOnlyGroupDetailsSync(DescribeReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupDetailsResponse>(req, "DescribeReadOnlyGroupDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupList）用于查询只读组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupListRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupListResponse"/></returns>
        public Task<DescribeReadOnlyGroupListResponse> DescribeReadOnlyGroupList(DescribeReadOnlyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupListResponse>(req, "DescribeReadOnlyGroupList");
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupList）用于查询只读组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupListRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupListResponse"/></returns>
        public DescribeReadOnlyGroupListResponse DescribeReadOnlyGroupListSync(DescribeReadOnlyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeReadOnlyGroupListResponse>(req, "DescribeReadOnlyGroupList")
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
        /// 本接口（DescribeRegularBackupPlan）用于查询实例定期备份保留计划
        /// </summary>
        /// <param name="req"><see cref="DescribeRegularBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRegularBackupPlanResponse"/></returns>
        public Task<DescribeRegularBackupPlanResponse> DescribeRegularBackupPlan(DescribeRegularBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRegularBackupPlanResponse>(req, "DescribeRegularBackupPlan");
        }

        /// <summary>
        /// 本接口（DescribeRegularBackupPlan）用于查询实例定期备份保留计划
        /// </summary>
        /// <param name="req"><see cref="DescribeRegularBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRegularBackupPlanResponse"/></returns>
        public DescribeRegularBackupPlanResponse DescribeRegularBackupPlanSync(DescribeRegularBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRegularBackupPlanResponse>(req, "DescribeRegularBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRestoreTask）用于查询回档任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskResponse"/></returns>
        public Task<DescribeRestoreTaskResponse> DescribeRestoreTask(DescribeRestoreTaskRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskResponse>(req, "DescribeRestoreTask");
        }

        /// <summary>
        /// 本接口（DescribeRestoreTask）用于查询回档任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTaskRequest"/></param>
        /// <returns><see cref="DescribeRestoreTaskResponse"/></returns>
        public DescribeRestoreTaskResponse DescribeRestoreTaskSync(DescribeRestoreTaskRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTaskResponse>(req, "DescribeRestoreTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRestoreTimeRange)用于查询按照时间点可回档的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRestoreTimeRangeResponse"/></returns>
        public Task<DescribeRestoreTimeRangeResponse> DescribeRestoreTimeRange(DescribeRestoreTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTimeRangeResponse>(req, "DescribeRestoreTimeRange");
        }

        /// <summary>
        /// 本接口(DescribeRestoreTimeRange)用于查询按照时间点可回档的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeRestoreTimeRangeResponse"/></returns>
        public DescribeRestoreTimeRangeResponse DescribeRestoreTimeRangeSync(DescribeRestoreTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTimeRangeResponse>(req, "DescribeRestoreTimeRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRollbackTime）用于查询实例可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public Task<DescribeRollbackTimeResponse> DescribeRollbackTime(DescribeRollbackTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeResponse>(req, "DescribeRollbackTime");
        }

        /// <summary>
        /// 本接口（DescribeRollbackTime）用于查询实例可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public DescribeRollbackTimeResponse DescribeRollbackTimeSync(DescribeRollbackTimeRequest req)
        {
            return InternalRequestAsync<DescribeRollbackTimeResponse>(req, "DescribeRollbackTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSlowlogs）用于获取慢查询日志文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public Task<DescribeSlowlogsResponse> DescribeSlowlogs(DescribeSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowlogsResponse>(req, "DescribeSlowlogs");
        }

        /// <summary>
        /// 本接口（DescribeSlowlogs）用于获取慢查询日志文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public DescribeSlowlogsResponse DescribeSlowlogsSync(DescribeSlowlogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowlogsResponse>(req, "DescribeSlowlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSpecSellStatus）用于查询售卖规格状态信息，其中包括售卖状态，参考价格等(实际价格以询价接口为准)。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecSellStatusRequest"/></param>
        /// <returns><see cref="DescribeSpecSellStatusResponse"/></returns>
        public Task<DescribeSpecSellStatusResponse> DescribeSpecSellStatus(DescribeSpecSellStatusRequest req)
        {
            return InternalRequestAsync<DescribeSpecSellStatusResponse>(req, "DescribeSpecSellStatus");
        }

        /// <summary>
        /// 本接口（DescribeSpecSellStatus）用于查询售卖规格状态信息，其中包括售卖状态，参考价格等(实际价格以询价接口为准)。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecSellStatusRequest"/></param>
        /// <returns><see cref="DescribeSpecSellStatusResponse"/></returns>
        public DescribeSpecSellStatusResponse DescribeSpecSellStatusSync(DescribeSpecSellStatusRequest req)
        {
            return InternalRequestAsync<DescribeSpecSellStatusResponse>(req, "DescribeSpecSellStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUpgradeInstanceCheck）用于在实例变配前，预检查实例变配的影响情况等。
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradeInstanceCheckRequest"/></param>
        /// <returns><see cref="DescribeUpgradeInstanceCheckResponse"/></returns>
        public Task<DescribeUpgradeInstanceCheckResponse> DescribeUpgradeInstanceCheck(DescribeUpgradeInstanceCheckRequest req)
        {
            return InternalRequestAsync<DescribeUpgradeInstanceCheckResponse>(req, "DescribeUpgradeInstanceCheck");
        }

        /// <summary>
        /// 本接口（DescribeUpgradeInstanceCheck）用于在实例变配前，预检查实例变配的影响情况等。
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradeInstanceCheckRequest"/></param>
        /// <returns><see cref="DescribeUpgradeInstanceCheckResponse"/></returns>
        public DescribeUpgradeInstanceCheckResponse DescribeUpgradeInstanceCheckSync(DescribeUpgradeInstanceCheckRequest req)
        {
            return InternalRequestAsync<DescribeUpgradeInstanceCheckResponse>(req, "DescribeUpgradeInstanceCheck")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUploadBackupInfo）用于查询备份上传权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadBackupInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadBackupInfoResponse"/></returns>
        public Task<DescribeUploadBackupInfoResponse> DescribeUploadBackupInfo(DescribeUploadBackupInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadBackupInfoResponse>(req, "DescribeUploadBackupInfo");
        }

        /// <summary>
        /// 本接口（DescribeUploadBackupInfo）用于查询备份上传权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadBackupInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadBackupInfoResponse"/></returns>
        public DescribeUploadBackupInfoResponse DescribeUploadBackupInfoSync(DescribeUploadBackupInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadBackupInfoResponse>(req, "DescribeUploadBackupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUploadIncrementalInfo）用于查询增量备份上传权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadIncrementalInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadIncrementalInfoResponse"/></returns>
        public Task<DescribeUploadIncrementalInfoResponse> DescribeUploadIncrementalInfo(DescribeUploadIncrementalInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadIncrementalInfoResponse>(req, "DescribeUploadIncrementalInfo");
        }

        /// <summary>
        /// 本接口（DescribeUploadIncrementalInfo）用于查询增量备份上传权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadIncrementalInfoRequest"/></param>
        /// <returns><see cref="DescribeUploadIncrementalInfoResponse"/></returns>
        public DescribeUploadIncrementalInfoResponse DescribeUploadIncrementalInfoSync(DescribeUploadIncrementalInfoRequest req)
        {
            return InternalRequestAsync<DescribeUploadIncrementalInfoResponse>(req, "DescribeUploadIncrementalInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeXEvents）用于查询扩展事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeXEventsRequest"/></param>
        /// <returns><see cref="DescribeXEventsResponse"/></returns>
        public Task<DescribeXEventsResponse> DescribeXEvents(DescribeXEventsRequest req)
        {
            return InternalRequestAsync<DescribeXEventsResponse>(req, "DescribeXEvents");
        }

        /// <summary>
        /// 本接口（DescribeXEvents）用于查询扩展事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeXEventsRequest"/></param>
        /// <returns><see cref="DescribeXEventsResponse"/></returns>
        public DescribeXEventsResponse DescribeXEventsSync(DescribeXEventsRequest req)
        {
            return InternalRequestAsync<DescribeXEventsResponse>(req, "DescribeXEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询当前可售卖的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询当前可售卖的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
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
        /// 本接口（InquiryPriceCreateDBInstances）用于查询申请实例价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances");
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateDBInstances）用于查询申请实例价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateDBInstancesResponse>(req, "InquiryPriceCreateDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询包年包月实例的续费价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public Task<InquiryPriceRenewDBInstanceResponse> InquiryPriceRenewDBInstance(InquiryPriceRenewDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewDBInstanceResponse>(req, "InquiryPriceRenewDBInstance");
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询包年包月实例的续费价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public InquiryPriceRenewDBInstanceResponse InquiryPriceRenewDBInstanceSync(InquiryPriceRenewDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewDBInstanceResponse>(req, "InquiryPriceRenewDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询包年包月实例升级变配的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance");
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询包年包月实例升级变配的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpgradeDBInstanceResponse>(req, "InquiryPriceUpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAccountPrivilege）用于修改实例账户权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilege(ModifyAccountPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegeResponse>(req, "ModifyAccountPrivilege");
        }

        /// <summary>
        /// 本接口（ModifyAccountPrivilege）用于修改实例账户权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public ModifyAccountPrivilegeResponse ModifyAccountPrivilegeSync(ModifyAccountPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegeResponse>(req, "ModifyAccountPrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改账户备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public Task<ModifyAccountRemarkResponse> ModifyAccountRemark(ModifyAccountRemarkRequest req)
        {
            return InternalRequestAsync<ModifyAccountRemarkResponse>(req, "ModifyAccountRemark");
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改账户备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public ModifyAccountRemarkResponse ModifyAccountRemarkSync(ModifyAccountRemarkRequest req)
        {
            return InternalRequestAsync<ModifyAccountRemarkResponse>(req, "ModifyAccountRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyBackupMigration）用于修改备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupMigrationRequest"/></param>
        /// <returns><see cref="ModifyBackupMigrationResponse"/></returns>
        public Task<ModifyBackupMigrationResponse> ModifyBackupMigration(ModifyBackupMigrationRequest req)
        {
            return InternalRequestAsync<ModifyBackupMigrationResponse>(req, "ModifyBackupMigration");
        }

        /// <summary>
        /// 本接口（ModifyBackupMigration）用于修改备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupMigrationRequest"/></param>
        /// <returns><see cref="ModifyBackupMigrationResponse"/></returns>
        public ModifyBackupMigrationResponse ModifyBackupMigrationSync(ModifyBackupMigrationRequest req)
        {
            return InternalRequestAsync<ModifyBackupMigrationResponse>(req, "ModifyBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyBackupName)用于修改备份任务名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public Task<ModifyBackupNameResponse> ModifyBackupName(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName");
        }

        /// <summary>
        /// 本接口(ModifyBackupName)用于修改备份任务名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public ModifyBackupNameResponse ModifyBackupNameSync(ModifyBackupNameRequest req)
        {
            return InternalRequestAsync<ModifyBackupNameResponse>(req, "ModifyBackupName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyBackupStrategy）用于修改备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public Task<ModifyBackupStrategyResponse> ModifyBackupStrategy(ModifyBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyBackupStrategyResponse>(req, "ModifyBackupStrategy");
        }

        /// <summary>
        /// 本接口（ModifyBackupStrategy）用于修改备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public ModifyBackupStrategyResponse ModifyBackupStrategySync(ModifyBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyBackupStrategyResponse>(req, "ModifyBackupStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyCloseWanIp)用于关闭实例外网。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloseWanIpRequest"/></param>
        /// <returns><see cref="ModifyCloseWanIpResponse"/></returns>
        public Task<ModifyCloseWanIpResponse> ModifyCloseWanIp(ModifyCloseWanIpRequest req)
        {
            return InternalRequestAsync<ModifyCloseWanIpResponse>(req, "ModifyCloseWanIp");
        }

        /// <summary>
        /// 本接口(ModifyCloseWanIp)用于关闭实例外网。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloseWanIpRequest"/></param>
        /// <returns><see cref="ModifyCloseWanIpResponse"/></returns>
        public ModifyCloseWanIpResponse ModifyCloseWanIpSync(ModifyCloseWanIpRequest req)
        {
            return InternalRequestAsync<ModifyCloseWanIpResponse>(req, "ModifyCloseWanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyCrossBackupStrategy)用于开启、关闭地域备份策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyCrossBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyCrossBackupStrategyResponse"/></returns>
        public Task<ModifyCrossBackupStrategyResponse> ModifyCrossBackupStrategy(ModifyCrossBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyCrossBackupStrategyResponse>(req, "ModifyCrossBackupStrategy");
        }

        /// <summary>
        /// 本接口(ModifyCrossBackupStrategy)用于开启、关闭地域备份策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyCrossBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyCrossBackupStrategyResponse"/></returns>
        public ModifyCrossBackupStrategyResponse ModifyCrossBackupStrategySync(ModifyCrossBackupStrategyRequest req)
        {
            return InternalRequestAsync<ModifyCrossBackupStrategyResponse>(req, "ModifyCrossBackupStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBEncryptAttributes）用于开启、关闭数据库的TDE加密功能。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public Task<ModifyDBEncryptAttributesResponse> ModifyDBEncryptAttributes(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes");
        }

        /// <summary>
        /// 本接口（ModifyDBEncryptAttributes）用于开启、关闭数据库的TDE加密功能。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public ModifyDBEncryptAttributesResponse ModifyDBEncryptAttributesSync(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceNetwork）用于修改运行中实例的网络，仅支持从VPC网络到VPC网络的转换
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkResponse"/></returns>
        public Task<ModifyDBInstanceNetworkResponse> ModifyDBInstanceNetwork(ModifyDBInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkResponse>(req, "ModifyDBInstanceNetwork");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceNetwork）用于修改运行中实例的网络，仅支持从VPC网络到VPC网络的转换
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkResponse"/></returns>
        public ModifyDBInstanceNetworkResponse ModifyDBInstanceNetworkSync(ModifyDBInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNetworkResponse>(req, "ModifyDBInstanceNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceNote）用于修改实例备注信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNoteRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNoteResponse"/></returns>
        public Task<ModifyDBInstanceNoteResponse> ModifyDBInstanceNote(ModifyDBInstanceNoteRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNoteResponse>(req, "ModifyDBInstanceNote");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceNote）用于修改实例备注信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNoteRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNoteResponse"/></returns>
        public ModifyDBInstanceNoteResponse ModifyDBInstanceNoteSync(ModifyDBInstanceNoteRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNoteResponse>(req, "ModifyDBInstanceNote")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceProject）用于修改数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public Task<ModifyDBInstanceProjectResponse> ModifyDBInstanceProject(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceProject）用于修改数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public ModifyDBInstanceProjectResponse ModifyDBInstanceProjectSync(ModifyDBInstanceProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceProjectResponse>(req, "ModifyDBInstanceProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceRenewFlag）用于修改实例续费标记
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceRenewFlagResponse"/></returns>
        public Task<ModifyDBInstanceRenewFlagResponse> ModifyDBInstanceRenewFlag(ModifyDBInstanceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceRenewFlagResponse>(req, "ModifyDBInstanceRenewFlag");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceRenewFlag）用于修改实例续费标记
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceRenewFlagResponse"/></returns>
        public ModifyDBInstanceRenewFlagResponse ModifyDBInstanceRenewFlagSync(ModifyDBInstanceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceRenewFlagResponse>(req, "ModifyDBInstanceRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSSL）用于开启\关闭\更新SSL加密
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSSLRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSSLResponse"/></returns>
        public Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSL(ModifyDBInstanceSSLRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSSLResponse>(req, "ModifyDBInstanceSSL");
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSSL）用于开启\关闭\更新SSL加密
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSSLRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSSLResponse"/></returns>
        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSLSync(ModifyDBInstanceSSLRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSSLResponse>(req, "ModifyDBInstanceSSL")
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
        /// 本接口（ModifyDBName）用于更新数据库名。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public Task<ModifyDBNameResponse> ModifyDBName(ModifyDBNameRequest req)
        {
            return InternalRequestAsync<ModifyDBNameResponse>(req, "ModifyDBName");
        }

        /// <summary>
        /// 本接口（ModifyDBName）用于更新数据库名。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public ModifyDBNameResponse ModifyDBNameSync(ModifyDBNameRequest req)
        {
            return InternalRequestAsync<ModifyDBNameResponse>(req, "ModifyDBName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDBRemark）用于修改数据库备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public Task<ModifyDBRemarkResponse> ModifyDBRemark(ModifyDBRemarkRequest req)
        {
            return InternalRequestAsync<ModifyDBRemarkResponse>(req, "ModifyDBRemark");
        }

        /// <summary>
        /// 本接口（ModifyDBRemark）用于修改数据库备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public ModifyDBRemarkResponse ModifyDBRemarkSync(ModifyDBRemarkRequest req)
        {
            return InternalRequestAsync<ModifyDBRemarkResponse>(req, "ModifyDBRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDReadable）用于开通或者关闭备机只读
        /// </summary>
        /// <param name="req"><see cref="ModifyDReadableRequest"/></param>
        /// <returns><see cref="ModifyDReadableResponse"/></returns>
        public Task<ModifyDReadableResponse> ModifyDReadable(ModifyDReadableRequest req)
        {
            return InternalRequestAsync<ModifyDReadableResponse>(req, "ModifyDReadable");
        }

        /// <summary>
        /// 本接口（ModifyDReadable）用于开通或者关闭备机只读
        /// </summary>
        /// <param name="req"><see cref="ModifyDReadableRequest"/></param>
        /// <returns><see cref="ModifyDReadableResponse"/></returns>
        public ModifyDReadableResponse ModifyDReadableSync(ModifyDReadableRequest req)
        {
            return InternalRequestAsync<ModifyDReadableResponse>(req, "ModifyDReadable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDatabaseCDC)用于开启、关闭数据库数据变更捕获(CDC)
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCDCRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCDCResponse"/></returns>
        public Task<ModifyDatabaseCDCResponse> ModifyDatabaseCDC(ModifyDatabaseCDCRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCDCResponse>(req, "ModifyDatabaseCDC");
        }

        /// <summary>
        /// 本接口(ModifyDatabaseCDC)用于开启、关闭数据库数据变更捕获(CDC)
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCDCRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCDCResponse"/></returns>
        public ModifyDatabaseCDCResponse ModifyDatabaseCDCSync(ModifyDatabaseCDCRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCDCResponse>(req, "ModifyDatabaseCDC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDatabaseCT)用于启用、禁用数据库数据变更跟踪(CT)
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCTRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCTResponse"/></returns>
        public Task<ModifyDatabaseCTResponse> ModifyDatabaseCT(ModifyDatabaseCTRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCTResponse>(req, "ModifyDatabaseCT");
        }

        /// <summary>
        /// 本接口(ModifyDatabaseCT)用于启用、禁用数据库数据变更跟踪(CT)
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseCTRequest"/></param>
        /// <returns><see cref="ModifyDatabaseCTResponse"/></returns>
        public ModifyDatabaseCTResponse ModifyDatabaseCTSync(ModifyDatabaseCTRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseCTResponse>(req, "ModifyDatabaseCT")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDatabaseMdf)用于收缩数据库mdf(Shrink mdf)。**本接口已废弃，请使用接口ModifyDatabaseShrinkMDF**。
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseMdfRequest"/></param>
        /// <returns><see cref="ModifyDatabaseMdfResponse"/></returns>
        public Task<ModifyDatabaseMdfResponse> ModifyDatabaseMdf(ModifyDatabaseMdfRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseMdfResponse>(req, "ModifyDatabaseMdf");
        }

        /// <summary>
        /// 本接口(ModifyDatabaseMdf)用于收缩数据库mdf(Shrink mdf)。**本接口已废弃，请使用接口ModifyDatabaseShrinkMDF**。
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseMdfRequest"/></param>
        /// <returns><see cref="ModifyDatabaseMdfResponse"/></returns>
        public ModifyDatabaseMdfResponse ModifyDatabaseMdfSync(ModifyDatabaseMdfRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseMdfResponse>(req, "ModifyDatabaseMdf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDatabasePrivilege）用于修改实例数据库权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabasePrivilegeRequest"/></param>
        /// <returns><see cref="ModifyDatabasePrivilegeResponse"/></returns>
        public Task<ModifyDatabasePrivilegeResponse> ModifyDatabasePrivilege(ModifyDatabasePrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyDatabasePrivilegeResponse>(req, "ModifyDatabasePrivilege");
        }

        /// <summary>
        /// 本接口（ModifyDatabasePrivilege）用于修改实例数据库权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabasePrivilegeRequest"/></param>
        /// <returns><see cref="ModifyDatabasePrivilegeResponse"/></returns>
        public ModifyDatabasePrivilegeResponse ModifyDatabasePrivilegeSync(ModifyDatabasePrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyDatabasePrivilegeResponse>(req, "ModifyDatabasePrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDatabaseShrinkDMF)用于收缩数据库mdf(Shrink mdf)。
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseShrinkMDFRequest"/></param>
        /// <returns><see cref="ModifyDatabaseShrinkMDFResponse"/></returns>
        public Task<ModifyDatabaseShrinkMDFResponse> ModifyDatabaseShrinkMDF(ModifyDatabaseShrinkMDFRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseShrinkMDFResponse>(req, "ModifyDatabaseShrinkMDF");
        }

        /// <summary>
        /// 本接口(ModifyDatabaseShrinkDMF)用于收缩数据库mdf(Shrink mdf)。
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseShrinkMDFRequest"/></param>
        /// <returns><see cref="ModifyDatabaseShrinkMDFResponse"/></returns>
        public ModifyDatabaseShrinkMDFResponse ModifyDatabaseShrinkMDFSync(ModifyDatabaseShrinkMDFRequest req)
        {
            return InternalRequestAsync<ModifyDatabaseShrinkMDFResponse>(req, "ModifyDatabaseShrinkMDF")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyIncrementalMigration）用于修改增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationResponse"/></returns>
        public Task<ModifyIncrementalMigrationResponse> ModifyIncrementalMigration(ModifyIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationResponse>(req, "ModifyIncrementalMigration");
        }

        /// <summary>
        /// 本接口（ModifyIncrementalMigration）用于修改增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyIncrementalMigrationRequest"/></param>
        /// <returns><see cref="ModifyIncrementalMigrationResponse"/></returns>
        public ModifyIncrementalMigrationResponse ModifyIncrementalMigrationSync(ModifyIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<ModifyIncrementalMigrationResponse>(req, "ModifyIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceEncryptAttributes）用于开通实例的TDE加密功能。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceEncryptAttributesResponse"/></returns>
        public Task<ModifyInstanceEncryptAttributesResponse> ModifyInstanceEncryptAttributes(ModifyInstanceEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEncryptAttributesResponse>(req, "ModifyInstanceEncryptAttributes");
        }

        /// <summary>
        /// 本接口（ModifyInstanceEncryptAttributes）用于开通实例的TDE加密功能。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyInstanceEncryptAttributesResponse"/></returns>
        public ModifyInstanceEncryptAttributesResponse ModifyInstanceEncryptAttributesSync(ModifyInstanceEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyInstanceEncryptAttributesResponse>(req, "ModifyInstanceEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyInstanceParam)用于修改云数据库实例的参数。
        /// <b>注意</b>：如果修改的参数是需要<b>重启实例</b>的，那么实例将会按照WaitSwitch参数的设置(可能是立即执行也可能在可维护时间窗内自动执行)在执行参数修改时<b>重启实例</b>。
        /// 您可以通过DescribeInstanceParams接口查询修改参数时是否会重启实例，以免导致您的实例不符合预期重启。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam");
        }

        /// <summary>
        /// 本接口(ModifyInstanceParam)用于修改云数据库实例的参数。
        /// <b>注意</b>：如果修改的参数是需要<b>重启实例</b>的，那么实例将会按照WaitSwitch参数的设置(可能是立即执行也可能在可维护时间窗内自动执行)在执行参数修改时<b>重启实例</b>。
        /// 您可以通过DescribeInstanceParams接口查询修改参数时是否会重启实例，以免导致您的实例不符合预期重启。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamResponse>(req, "ModifyInstanceParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceSpan）用于修改实例的可维护时间窗
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceSpanRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceSpanResponse"/></returns>
        public Task<ModifyMaintenanceSpanResponse> ModifyMaintenanceSpan(ModifyMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceSpanResponse>(req, "ModifyMaintenanceSpan");
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceSpan）用于修改实例的可维护时间窗
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceSpanRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceSpanResponse"/></returns>
        public ModifyMaintenanceSpanResponse ModifyMaintenanceSpanSync(ModifyMaintenanceSpanRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceSpanResponse>(req, "ModifyMaintenanceSpan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyMigration）可以修改已有的迁移任务信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public Task<ModifyMigrationResponse> ModifyMigration(ModifyMigrationRequest req)
        {
            return InternalRequestAsync<ModifyMigrationResponse>(req, "ModifyMigration");
        }

        /// <summary>
        /// 本接口（ModifyMigration）可以修改已有的迁移任务信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public ModifyMigrationResponse ModifyMigrationSync(ModifyMigrationRequest req)
        {
            return InternalRequestAsync<ModifyMigrationResponse>(req, "ModifyMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyOpenWanIp)用于开通实例外网。
        /// </summary>
        /// <param name="req"><see cref="ModifyOpenWanIpRequest"/></param>
        /// <returns><see cref="ModifyOpenWanIpResponse"/></returns>
        public Task<ModifyOpenWanIpResponse> ModifyOpenWanIp(ModifyOpenWanIpRequest req)
        {
            return InternalRequestAsync<ModifyOpenWanIpResponse>(req, "ModifyOpenWanIp");
        }

        /// <summary>
        /// 本接口(ModifyOpenWanIp)用于开通实例外网。
        /// </summary>
        /// <param name="req"><see cref="ModifyOpenWanIpRequest"/></param>
        /// <returns><see cref="ModifyOpenWanIpResponse"/></returns>
        public ModifyOpenWanIpResponse ModifyOpenWanIpSync(ModifyOpenWanIpRequest req)
        {
            return InternalRequestAsync<ModifyOpenWanIpResponse>(req, "ModifyOpenWanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyPublishSubscribe）用于修改实例的发布订阅关系。
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeResponse"/></returns>
        public Task<ModifyPublishSubscribeResponse> ModifyPublishSubscribe(ModifyPublishSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeResponse>(req, "ModifyPublishSubscribe");
        }

        /// <summary>
        /// 本接口（ModifyPublishSubscribe）用于修改实例的发布订阅关系。
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeResponse"/></returns>
        public ModifyPublishSubscribeResponse ModifyPublishSubscribeSync(ModifyPublishSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeResponse>(req, "ModifyPublishSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyPublishSubscribeName）修改发布订阅的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeNameRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeNameResponse"/></returns>
        public Task<ModifyPublishSubscribeNameResponse> ModifyPublishSubscribeName(ModifyPublishSubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeNameResponse>(req, "ModifyPublishSubscribeName");
        }

        /// <summary>
        /// 本接口（ModifyPublishSubscribeName）修改发布订阅的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeNameRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeNameResponse"/></returns>
        public ModifyPublishSubscribeNameResponse ModifyPublishSubscribeNameSync(ModifyPublishSubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifyPublishSubscribeNameResponse>(req, "ModifyPublishSubscribeName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyReadOnlyGroupDetails）用于修改只读组详情。
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupDetailsResponse"/></returns>
        public Task<ModifyReadOnlyGroupDetailsResponse> ModifyReadOnlyGroupDetails(ModifyReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupDetailsResponse>(req, "ModifyReadOnlyGroupDetails");
        }

        /// <summary>
        /// 本接口（ModifyReadOnlyGroupDetails）用于修改只读组详情。
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupDetailsResponse"/></returns>
        public ModifyReadOnlyGroupDetailsResponse ModifyReadOnlyGroupDetailsSync(ModifyReadOnlyGroupDetailsRequest req)
        {
            return InternalRequestAsync<ModifyReadOnlyGroupDetailsResponse>(req, "ModifyReadOnlyGroupDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（OpenInterCommunication）用于打开实例的互通，实例互通可以实现商业智能服务相互联通。
        /// </summary>
        /// <param name="req"><see cref="OpenInterCommunicationRequest"/></param>
        /// <returns><see cref="OpenInterCommunicationResponse"/></returns>
        public Task<OpenInterCommunicationResponse> OpenInterCommunication(OpenInterCommunicationRequest req)
        {
            return InternalRequestAsync<OpenInterCommunicationResponse>(req, "OpenInterCommunication");
        }

        /// <summary>
        /// 本接口（OpenInterCommunication）用于打开实例的互通，实例互通可以实现商业智能服务相互联通。
        /// </summary>
        /// <param name="req"><see cref="OpenInterCommunicationRequest"/></param>
        /// <returns><see cref="OpenInterCommunicationResponse"/></returns>
        public OpenInterCommunicationResponse OpenInterCommunicationSync(OpenInterCommunicationRequest req)
        {
            return InternalRequestAsync<OpenInterCommunicationResponse>(req, "OpenInterCommunication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（QueryMigrationCheckProcess）的作用是查询迁移检查任务的进度，适用于迁移源的类型为TencentDB for SQLServer 的迁移方式
        /// </summary>
        /// <param name="req"><see cref="QueryMigrationCheckProcessRequest"/></param>
        /// <returns><see cref="QueryMigrationCheckProcessResponse"/></returns>
        public Task<QueryMigrationCheckProcessResponse> QueryMigrationCheckProcess(QueryMigrationCheckProcessRequest req)
        {
            return InternalRequestAsync<QueryMigrationCheckProcessResponse>(req, "QueryMigrationCheckProcess");
        }

        /// <summary>
        /// 本接口（QueryMigrationCheckProcess）的作用是查询迁移检查任务的进度，适用于迁移源的类型为TencentDB for SQLServer 的迁移方式
        /// </summary>
        /// <param name="req"><see cref="QueryMigrationCheckProcessRequest"/></param>
        /// <returns><see cref="QueryMigrationCheckProcessResponse"/></returns>
        public QueryMigrationCheckProcessResponse QueryMigrationCheckProcessSync(QueryMigrationCheckProcessRequest req)
        {
            return InternalRequestAsync<QueryMigrationCheckProcessResponse>(req, "QueryMigrationCheckProcess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RecycleDBInstance）用于主动回收已下线的SQLSERVER实例
        /// </summary>
        /// <param name="req"><see cref="RecycleDBInstanceRequest"/></param>
        /// <returns><see cref="RecycleDBInstanceResponse"/></returns>
        public Task<RecycleDBInstanceResponse> RecycleDBInstance(RecycleDBInstanceRequest req)
        {
            return InternalRequestAsync<RecycleDBInstanceResponse>(req, "RecycleDBInstance");
        }

        /// <summary>
        /// 本接口（RecycleDBInstance）用于主动回收已下线的SQLSERVER实例
        /// </summary>
        /// <param name="req"><see cref="RecycleDBInstanceRequest"/></param>
        /// <returns><see cref="RecycleDBInstanceResponse"/></returns>
        public RecycleDBInstanceResponse RecycleDBInstanceSync(RecycleDBInstanceRequest req)
        {
            return InternalRequestAsync<RecycleDBInstanceResponse>(req, "RecycleDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RecycleReadOnlyGroup）立即回收只读组的资源，只读组占用的vip等资源将立即释放且不可找回。
        /// </summary>
        /// <param name="req"><see cref="RecycleReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RecycleReadOnlyGroupResponse"/></returns>
        public Task<RecycleReadOnlyGroupResponse> RecycleReadOnlyGroup(RecycleReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RecycleReadOnlyGroupResponse>(req, "RecycleReadOnlyGroup");
        }

        /// <summary>
        /// 本接口（RecycleReadOnlyGroup）立即回收只读组的资源，只读组占用的vip等资源将立即释放且不可找回。
        /// </summary>
        /// <param name="req"><see cref="RecycleReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RecycleReadOnlyGroupResponse"/></returns>
        public RecycleReadOnlyGroupResponse RecycleReadOnlyGroupSync(RecycleReadOnlyGroupRequest req)
        {
            return InternalRequestAsync<RecycleReadOnlyGroupResponse>(req, "RecycleReadOnlyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RemoveBackups）可以删除用户手动创建的备份文件。待删除的备份策略可以是实例备份，也可以是多库备份。
        /// </summary>
        /// <param name="req"><see cref="RemoveBackupsRequest"/></param>
        /// <returns><see cref="RemoveBackupsResponse"/></returns>
        public Task<RemoveBackupsResponse> RemoveBackups(RemoveBackupsRequest req)
        {
            return InternalRequestAsync<RemoveBackupsResponse>(req, "RemoveBackups");
        }

        /// <summary>
        /// 本接口（RemoveBackups）可以删除用户手动创建的备份文件。待删除的备份策略可以是实例备份，也可以是多库备份。
        /// </summary>
        /// <param name="req"><see cref="RemoveBackupsRequest"/></param>
        /// <returns><see cref="RemoveBackupsResponse"/></returns>
        public RemoveBackupsResponse RemoveBackupsSync(RemoveBackupsRequest req)
        {
            return InternalRequestAsync<RemoveBackupsResponse>(req, "RemoveBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RenewDBInstance）用于续费实例。当被续费实例是按量计费实例时，则按量计费实例转为包年包月计费方式。
        /// 按量计费实例转包年包月询价可通过(InquiryPriceRenewDBInstance)接口获得。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public Task<RenewDBInstanceResponse> RenewDBInstance(RenewDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDBInstanceResponse>(req, "RenewDBInstance");
        }

        /// <summary>
        /// 本接口（RenewDBInstance）用于续费实例。当被续费实例是按量计费实例时，则按量计费实例转为包年包月计费方式。
        /// 按量计费实例转包年包月询价可通过(InquiryPriceRenewDBInstance)接口获得。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public RenewDBInstanceResponse RenewDBInstanceSync(RenewDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewDBInstanceResponse>(req, "RenewDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RenewPostpaidDBInstance）用于将通过接口TerminateDBInstance手动隔离的按量计费实例从回收站中恢复。
        /// </summary>
        /// <param name="req"><see cref="RenewPostpaidDBInstanceRequest"/></param>
        /// <returns><see cref="RenewPostpaidDBInstanceResponse"/></returns>
        public Task<RenewPostpaidDBInstanceResponse> RenewPostpaidDBInstance(RenewPostpaidDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewPostpaidDBInstanceResponse>(req, "RenewPostpaidDBInstance");
        }

        /// <summary>
        /// 本接口（RenewPostpaidDBInstance）用于将通过接口TerminateDBInstance手动隔离的按量计费实例从回收站中恢复。
        /// </summary>
        /// <param name="req"><see cref="RenewPostpaidDBInstanceRequest"/></param>
        /// <returns><see cref="RenewPostpaidDBInstanceResponse"/></returns>
        public RenewPostpaidDBInstanceResponse RenewPostpaidDBInstanceSync(RenewPostpaidDBInstanceRequest req)
        {
            return InternalRequestAsync<RenewPostpaidDBInstanceResponse>(req, "RenewPostpaidDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置实例的账号密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置实例的账号密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance");
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
            return InternalRequestAsync<RestartDBInstanceResponse>(req, "RestartDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RestoreInstance）用于按照备份集回档数据库。
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance");
        }

        /// <summary>
        /// 本接口（RestoreInstance）用于按照备份集回档数据库。
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
            return InternalRequestAsync<RestoreInstanceResponse>(req, "RestoreInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RollbackInstance）用于按照时间点回档实例
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public Task<RollbackInstanceResponse> RollbackInstance(RollbackInstanceRequest req)
        {
            return InternalRequestAsync<RollbackInstanceResponse>(req, "RollbackInstance");
        }

        /// <summary>
        /// 本接口（RollbackInstance）用于按照时间点回档实例
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public RollbackInstanceResponse RollbackInstanceSync(RollbackInstanceRequest req)
        {
            return InternalRequestAsync<RollbackInstanceResponse>(req, "RollbackInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RunMigration）用于启动迁移任务，开始迁移
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public Task<RunMigrationResponse> RunMigration(RunMigrationRequest req)
        {
            return InternalRequestAsync<RunMigrationResponse>(req, "RunMigration");
        }

        /// <summary>
        /// 本接口（RunMigration）用于启动迁移任务，开始迁移
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public RunMigrationResponse RunMigrationSync(RunMigrationRequest req)
        {
            return InternalRequestAsync<RunMigrationResponse>(req, "RunMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartBackupMigration）用于启动备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="StartBackupMigrationRequest"/></param>
        /// <returns><see cref="StartBackupMigrationResponse"/></returns>
        public Task<StartBackupMigrationResponse> StartBackupMigration(StartBackupMigrationRequest req)
        {
            return InternalRequestAsync<StartBackupMigrationResponse>(req, "StartBackupMigration");
        }

        /// <summary>
        /// 本接口（StartBackupMigration）用于启动备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="StartBackupMigrationRequest"/></param>
        /// <returns><see cref="StartBackupMigrationResponse"/></returns>
        public StartBackupMigrationResponse StartBackupMigrationSync(StartBackupMigrationRequest req)
        {
            return InternalRequestAsync<StartBackupMigrationResponse>(req, "StartBackupMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartIncrementalMigration）用于启动增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="StartIncrementalMigrationRequest"/></param>
        /// <returns><see cref="StartIncrementalMigrationResponse"/></returns>
        public Task<StartIncrementalMigrationResponse> StartIncrementalMigration(StartIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<StartIncrementalMigrationResponse>(req, "StartIncrementalMigration");
        }

        /// <summary>
        /// 本接口（StartIncrementalMigration）用于启动增量备份导入任务。
        /// </summary>
        /// <param name="req"><see cref="StartIncrementalMigrationRequest"/></param>
        /// <returns><see cref="StartIncrementalMigrationResponse"/></returns>
        public StartIncrementalMigrationResponse StartIncrementalMigrationSync(StartIncrementalMigrationRequest req)
        {
            return InternalRequestAsync<StartIncrementalMigrationResponse>(req, "StartIncrementalMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartInstanceXEvent）用于开启、关闭扩展事件。
        /// </summary>
        /// <param name="req"><see cref="StartInstanceXEventRequest"/></param>
        /// <returns><see cref="StartInstanceXEventResponse"/></returns>
        public Task<StartInstanceXEventResponse> StartInstanceXEvent(StartInstanceXEventRequest req)
        {
            return InternalRequestAsync<StartInstanceXEventResponse>(req, "StartInstanceXEvent");
        }

        /// <summary>
        /// 本接口（StartInstanceXEvent）用于开启、关闭扩展事件。
        /// </summary>
        /// <param name="req"><see cref="StartInstanceXEventRequest"/></param>
        /// <returns><see cref="StartInstanceXEventResponse"/></returns>
        public StartInstanceXEventResponse StartInstanceXEventSync(StartInstanceXEventRequest req)
        {
            return InternalRequestAsync<StartInstanceXEventResponse>(req, "StartInstanceXEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartMigrationCheck）的作用是启动一个迁移前的校验任务，适用于迁移源的类型为TencentDB for SQLServer 的迁移方式
        /// </summary>
        /// <param name="req"><see cref="StartMigrationCheckRequest"/></param>
        /// <returns><see cref="StartMigrationCheckResponse"/></returns>
        public Task<StartMigrationCheckResponse> StartMigrationCheck(StartMigrationCheckRequest req)
        {
            return InternalRequestAsync<StartMigrationCheckResponse>(req, "StartMigrationCheck");
        }

        /// <summary>
        /// 本接口（StartMigrationCheck）的作用是启动一个迁移前的校验任务，适用于迁移源的类型为TencentDB for SQLServer 的迁移方式
        /// </summary>
        /// <param name="req"><see cref="StartMigrationCheckRequest"/></param>
        /// <returns><see cref="StartMigrationCheckResponse"/></returns>
        public StartMigrationCheckResponse StartMigrationCheckSync(StartMigrationCheckRequest req)
        {
            return InternalRequestAsync<StartMigrationCheckResponse>(req, "StartMigrationCheck")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StopMigration）作用是中止一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="StopMigrationRequest"/></param>
        /// <returns><see cref="StopMigrationResponse"/></returns>
        public Task<StopMigrationResponse> StopMigration(StopMigrationRequest req)
        {
            return InternalRequestAsync<StopMigrationResponse>(req, "StopMigration");
        }

        /// <summary>
        /// 本接口（StopMigration）作用是中止一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="StopMigrationRequest"/></param>
        /// <returns><see cref="StopMigrationResponse"/></returns>
        public StopMigrationResponse StopMigrationSync(StopMigrationRequest req)
        {
            return InternalRequestAsync<StopMigrationResponse>(req, "StopMigration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SwitchCloudInstanceHA)用于手动主备切换。
        /// </summary>
        /// <param name="req"><see cref="SwitchCloudInstanceHARequest"/></param>
        /// <returns><see cref="SwitchCloudInstanceHAResponse"/></returns>
        public Task<SwitchCloudInstanceHAResponse> SwitchCloudInstanceHA(SwitchCloudInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchCloudInstanceHAResponse>(req, "SwitchCloudInstanceHA");
        }

        /// <summary>
        /// 本接口(SwitchCloudInstanceHA)用于手动主备切换。
        /// </summary>
        /// <param name="req"><see cref="SwitchCloudInstanceHARequest"/></param>
        /// <returns><see cref="SwitchCloudInstanceHAResponse"/></returns>
        public SwitchCloudInstanceHAResponse SwitchCloudInstanceHASync(SwitchCloudInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchCloudInstanceHAResponse>(req, "SwitchCloudInstanceHA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(TerminateDBInstance)用于主动隔离实例，使得实例进入回收站。
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public Task<TerminateDBInstanceResponse> TerminateDBInstance(TerminateDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDBInstanceResponse>(req, "TerminateDBInstance");
        }

        /// <summary>
        /// 本接口(TerminateDBInstance)用于主动隔离实例，使得实例进入回收站。
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public TerminateDBInstanceResponse TerminateDBInstanceSync(TerminateDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDBInstanceResponse>(req, "TerminateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeDBInstance）用于升级实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance");
        }

        /// <summary>
        /// 本接口（UpgradeDBInstance）用于升级实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDBInstanceResponse>(req, "UpgradeDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
