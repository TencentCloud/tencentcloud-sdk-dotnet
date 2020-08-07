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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SqlserverClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CompleteExpansion）在实例发起扩容后，实例状态处于“升级待切换”时，可立即完成实例升级切换操作，无需等待可维护时间窗。本接口需要在实例低峰时调用，在完全切换成功前，存在部分库不可访问的风险。
        /// </summary>
        /// <param name="req"><see cref="CompleteExpansionRequest"/></param>
        /// <returns><see cref="CompleteExpansionResponse"/></returns>
        public async Task<CompleteExpansionResponse> CompleteExpansion(CompleteExpansionRequest req)
        {
             JsonResponseModel<CompleteExpansionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompleteExpansion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteExpansionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CompleteExpansion）在实例发起扩容后，实例状态处于“升级待切换”时，可立即完成实例升级切换操作，无需等待可维护时间窗。本接口需要在实例低峰时调用，在完全切换成功前，存在部分库不可访问的风险。
        /// </summary>
        /// <param name="req"><see cref="CompleteExpansionRequest"/></param>
        /// <returns><see cref="CompleteExpansionResponse"/></returns>
        public CompleteExpansionResponse CompleteExpansionSync(CompleteExpansionRequest req)
        {
             JsonResponseModel<CompleteExpansionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompleteExpansion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteExpansionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建实例账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建实例账号
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateBackup)用于创建备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateBackup)用于创建备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateBasicDBInstances）用于创建SQL server基础版实例。
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBasicDBInstancesResponse"/></returns>
        public async Task<CreateBasicDBInstancesResponse> CreateBasicDBInstances(CreateBasicDBInstancesRequest req)
        {
             JsonResponseModel<CreateBasicDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBasicDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBasicDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateBasicDBInstances）用于创建SQL server基础版实例。
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDBInstancesRequest"/></param>
        /// <returns><see cref="CreateBasicDBInstancesResponse"/></returns>
        public CreateBasicDBInstancesResponse CreateBasicDBInstancesSync(CreateBasicDBInstancesRequest req)
        {
             JsonResponseModel<CreateBasicDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBasicDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBasicDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDB）用于创建数据库。
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public async Task<CreateDBResponse> CreateDB(CreateDBRequest req)
        {
             JsonResponseModel<CreateDBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDB）用于创建数据库。
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public CreateDBResponse CreateDBSync(CreateDBRequest req)
        {
             JsonResponseModel<CreateDBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public async Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateMigration）作用是创建一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public async Task<CreateMigrationResponse> CreateMigration(CreateMigrationRequest req)
        {
             JsonResponseModel<CreateMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateMigration）作用是创建一个迁移任务
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public CreateMigrationResponse CreateMigrationSync(CreateMigrationRequest req)
        {
             JsonResponseModel<CreateMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePublishSubscribe）用于创建两个数据库之间的发布订阅关系。作为订阅者，不能再充当发布者，作为发布者可以有多个订阅者实例。
        /// </summary>
        /// <param name="req"><see cref="CreatePublishSubscribeRequest"/></param>
        /// <returns><see cref="CreatePublishSubscribeResponse"/></returns>
        public async Task<CreatePublishSubscribeResponse> CreatePublishSubscribe(CreatePublishSubscribeRequest req)
        {
             JsonResponseModel<CreatePublishSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePublishSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePublishSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePublishSubscribe）用于创建两个数据库之间的发布订阅关系。作为订阅者，不能再充当发布者，作为发布者可以有多个订阅者实例。
        /// </summary>
        /// <param name="req"><see cref="CreatePublishSubscribeRequest"/></param>
        /// <returns><see cref="CreatePublishSubscribeResponse"/></returns>
        public CreatePublishSubscribeResponse CreatePublishSubscribeSync(CreatePublishSubscribeRequest req)
        {
             JsonResponseModel<CreatePublishSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePublishSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePublishSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateReadOnlyDBInstances）用于添加只读副本实例。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstancesResponse"/></returns>
        public async Task<CreateReadOnlyDBInstancesResponse> CreateReadOnlyDBInstances(CreateReadOnlyDBInstancesRequest req)
        {
             JsonResponseModel<CreateReadOnlyDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReadOnlyDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateReadOnlyDBInstances）用于添加只读副本实例。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstancesRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstancesResponse"/></returns>
        public CreateReadOnlyDBInstancesResponse CreateReadOnlyDBInstancesSync(CreateReadOnlyDBInstancesRequest req)
        {
             JsonResponseModel<CreateReadOnlyDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReadOnlyDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除实例账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public async Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
             JsonResponseModel<DeleteAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除实例账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
             JsonResponseModel<DeleteAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteDB)用于删除数据库。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public async Task<DeleteDBResponse> DeleteDB(DeleteDBRequest req)
        {
             JsonResponseModel<DeleteDBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteDB)用于删除数据库。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public DeleteDBResponse DeleteDBSync(DeleteDBRequest req)
        {
             JsonResponseModel<DeleteDBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDBInstance）用于释放回收站中的SQL server实例。释放后的实例将保存一段时间后物理销毁。其发布订阅将自动解除，其ro副本将自动释放。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceResponse"/></returns>
        public async Task<DeleteDBInstanceResponse> DeleteDBInstance(DeleteDBInstanceRequest req)
        {
             JsonResponseModel<DeleteDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDBInstance）用于释放回收站中的SQL server实例。释放后的实例将保存一段时间后物理销毁。其发布订阅将自动解除，其ro副本将自动释放。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceResponse"/></returns>
        public DeleteDBInstanceResponse DeleteDBInstanceSync(DeleteDBInstanceRequest req)
        {
             JsonResponseModel<DeleteDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMigration）用于删除迁移任务
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public async Task<DeleteMigrationResponse> DeleteMigration(DeleteMigrationRequest req)
        {
             JsonResponseModel<DeleteMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMigration）用于删除迁移任务
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public DeleteMigrationResponse DeleteMigrationSync(DeleteMigrationRequest req)
        {
             JsonResponseModel<DeleteMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeletePublishSubscribe）用于删除两个数据库间的发布订阅关系。
        /// </summary>
        /// <param name="req"><see cref="DeletePublishSubscribeRequest"/></param>
        /// <returns><see cref="DeletePublishSubscribeResponse"/></returns>
        public async Task<DeletePublishSubscribeResponse> DeletePublishSubscribe(DeletePublishSubscribeRequest req)
        {
             JsonResponseModel<DeletePublishSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePublishSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePublishSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeletePublishSubscribe）用于删除两个数据库间的发布订阅关系。
        /// </summary>
        /// <param name="req"><see cref="DeletePublishSubscribeRequest"/></param>
        /// <returns><see cref="DeletePublishSubscribeResponse"/></returns>
        public DeletePublishSubscribeResponse DeletePublishSubscribeSync(DeletePublishSubscribeRequest req)
        {
             JsonResponseModel<DeletePublishSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePublishSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePublishSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于拉取实例账户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于拉取实例账户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackupByFlowId)用于通过备份创建流程的ID查询创建的备份详情，流程ID可从接口CreateBackup中获得。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeBackupByFlowIdResponse"/></returns>
        public async Task<DescribeBackupByFlowIdResponse> DescribeBackupByFlowId(DescribeBackupByFlowIdRequest req)
        {
             JsonResponseModel<DescribeBackupByFlowIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupByFlowId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupByFlowIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackupByFlowId)用于通过备份创建流程的ID查询创建的备份详情，流程ID可从接口CreateBackup中获得。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeBackupByFlowIdResponse"/></returns>
        public DescribeBackupByFlowIdResponse DescribeBackupByFlowIdSync(DescribeBackupByFlowIdRequest req)
        {
             JsonResponseModel<DescribeBackupByFlowIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupByFlowId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupByFlowIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackups)用于查询备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public async Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest req)
        {
             JsonResponseModel<DescribeBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackups)用于查询备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public DescribeBackupsResponse DescribeBackupsSync(DescribeBackupsRequest req)
        {
             JsonResponseModel<DescribeBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeCrossRegionZone)根据主实例查询备机的容灾地域和可用区。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionZoneResponse"/></returns>
        public async Task<DescribeCrossRegionZoneResponse> DescribeCrossRegionZone(DescribeCrossRegionZoneRequest req)
        {
             JsonResponseModel<DescribeCrossRegionZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCrossRegionZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossRegionZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeCrossRegionZone)根据主实例查询备机的容灾地域和可用区。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossRegionZoneRequest"/></param>
        /// <returns><see cref="DescribeCrossRegionZoneResponse"/></returns>
        public DescribeCrossRegionZoneResponse DescribeCrossRegionZoneSync(DescribeCrossRegionZoneRequest req)
        {
             JsonResponseModel<DescribeCrossRegionZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCrossRegionZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossRegionZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public async Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBs）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public async Task<DescribeDBsResponse> DescribeDBs(DescribeDBsRequest req)
        {
             JsonResponseModel<DescribeDBsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBs）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public DescribeDBsResponse DescribeDBsSync(DescribeDBsRequest req)
        {
             JsonResponseModel<DescribeDBsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeFlowStatus)用于查询流程状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public async Task<DescribeFlowStatusResponse> DescribeFlowStatus(DescribeFlowStatusRequest req)
        {
             JsonResponseModel<DescribeFlowStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeFlowStatus)用于查询流程状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public DescribeFlowStatusResponse DescribeFlowStatusSync(DescribeFlowStatusRequest req)
        {
             JsonResponseModel<DescribeFlowStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMaintenanceSpan）根据实例ID查询该实例的可维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceSpanRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceSpanResponse"/></returns>
        public async Task<DescribeMaintenanceSpanResponse> DescribeMaintenanceSpan(DescribeMaintenanceSpanRequest req)
        {
             JsonResponseModel<DescribeMaintenanceSpanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaintenanceSpan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintenanceSpanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMaintenanceSpan）根据实例ID查询该实例的可维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceSpanRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceSpanResponse"/></returns>
        public DescribeMaintenanceSpanResponse DescribeMaintenanceSpanSync(DescribeMaintenanceSpanRequest req)
        {
             JsonResponseModel<DescribeMaintenanceSpanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMaintenanceSpan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaintenanceSpanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMigrationDetail）用于查询迁移任务的详细情况
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public async Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMigrationDetail）用于查询迁移任务的详细情况
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMigrations）根据输入的限定条件，查询符合条件的迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public async Task<DescribeMigrationsResponse> DescribeMigrations(DescribeMigrationsRequest req)
        {
             JsonResponseModel<DescribeMigrationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMigrations）根据输入的限定条件，查询符合条件的迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public DescribeMigrationsResponse DescribeMigrationsSync(DescribeMigrationsRequest req)
        {
             JsonResponseModel<DescribeMigrationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public async Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProductConfig) 用于查询售卖规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public async Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProductConfig) 用于查询售卖规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePublishSubscribe）用于查询发布订阅关系列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePublishSubscribeRequest"/></param>
        /// <returns><see cref="DescribePublishSubscribeResponse"/></returns>
        public async Task<DescribePublishSubscribeResponse> DescribePublishSubscribe(DescribePublishSubscribeRequest req)
        {
             JsonResponseModel<DescribePublishSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublishSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublishSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePublishSubscribe）用于查询发布订阅关系列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePublishSubscribeRequest"/></param>
        /// <returns><see cref="DescribePublishSubscribeResponse"/></returns>
        public DescribePublishSubscribeResponse DescribePublishSubscribeSync(DescribePublishSubscribeRequest req)
        {
             JsonResponseModel<DescribePublishSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublishSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublishSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupByReadOnlyInstance）用于通过只读副本实例ID查询其所在的只读组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupByReadOnlyInstanceRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupByReadOnlyInstanceResponse"/></returns>
        public async Task<DescribeReadOnlyGroupByReadOnlyInstanceResponse> DescribeReadOnlyGroupByReadOnlyInstance(DescribeReadOnlyGroupByReadOnlyInstanceRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupByReadOnlyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReadOnlyGroupByReadOnlyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupByReadOnlyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupByReadOnlyInstance）用于通过只读副本实例ID查询其所在的只读组。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupByReadOnlyInstanceRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupByReadOnlyInstanceResponse"/></returns>
        public DescribeReadOnlyGroupByReadOnlyInstanceResponse DescribeReadOnlyGroupByReadOnlyInstanceSync(DescribeReadOnlyGroupByReadOnlyInstanceRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupByReadOnlyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReadOnlyGroupByReadOnlyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupByReadOnlyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupDetails）用于查询只读组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupDetailsResponse"/></returns>
        public async Task<DescribeReadOnlyGroupDetailsResponse> DescribeReadOnlyGroupDetails(DescribeReadOnlyGroupDetailsRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReadOnlyGroupDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupDetails）用于查询只读组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupDetailsResponse"/></returns>
        public DescribeReadOnlyGroupDetailsResponse DescribeReadOnlyGroupDetailsSync(DescribeReadOnlyGroupDetailsRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReadOnlyGroupDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupList）用于查询只读组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupListRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupListResponse"/></returns>
        public async Task<DescribeReadOnlyGroupListResponse> DescribeReadOnlyGroupList(DescribeReadOnlyGroupListRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReadOnlyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeReadOnlyGroupList）用于查询只读组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupListRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupListResponse"/></returns>
        public DescribeReadOnlyGroupListResponse DescribeReadOnlyGroupListSync(DescribeReadOnlyGroupListRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReadOnlyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeRegions) 用于查询售卖地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeRegions) 用于查询售卖地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRollbackTime）用于查询实例可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public async Task<DescribeRollbackTimeResponse> DescribeRollbackTime(DescribeRollbackTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRollbackTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRollbackTime）用于查询实例可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public DescribeRollbackTimeResponse DescribeRollbackTimeSync(DescribeRollbackTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRollbackTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowlogs）用于获取慢查询日志文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public async Task<DescribeSlowlogsResponse> DescribeSlowlogs(DescribeSlowlogsRequest req)
        {
             JsonResponseModel<DescribeSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowlogs）用于获取慢查询日志文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public DescribeSlowlogsResponse DescribeSlowlogsSync(DescribeSlowlogsRequest req)
        {
             JsonResponseModel<DescribeSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询当前可售卖的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询当前可售卖的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateDBInstances）用于查询申请实例价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public async Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateDBInstances）用于查询申请实例价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询续费实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public async Task<InquiryPriceRenewDBInstanceResponse> InquiryPriceRenewDBInstance(InquiryPriceRenewDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询续费实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public InquiryPriceRenewDBInstanceResponse InquiryPriceRenewDBInstanceSync(InquiryPriceRenewDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询升级实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public async Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询升级实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountPrivilege）用于修改实例账户权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public async Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilege(ModifyAccountPrivilegeRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountPrivilege）用于修改实例账户权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public ModifyAccountPrivilegeResponse ModifyAccountPrivilegeSync(ModifyAccountPrivilegeRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改账户备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public async Task<ModifyAccountRemarkResponse> ModifyAccountRemark(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改账户备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public ModifyAccountRemarkResponse ModifyAccountRemarkSync(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyBackupName)用于修改备份名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public async Task<ModifyBackupNameResponse> ModifyBackupName(ModifyBackupNameRequest req)
        {
             JsonResponseModel<ModifyBackupNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyBackupName)用于修改备份名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupNameRequest"/></param>
        /// <returns><see cref="ModifyBackupNameResponse"/></returns>
        public ModifyBackupNameResponse ModifyBackupNameSync(ModifyBackupNameRequest req)
        {
             JsonResponseModel<ModifyBackupNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupStrategy）用于修改备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public async Task<ModifyBackupStrategyResponse> ModifyBackupStrategy(ModifyBackupStrategyRequest req)
        {
             JsonResponseModel<ModifyBackupStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupStrategy）用于修改备份策略
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public ModifyBackupStrategyResponse ModifyBackupStrategySync(ModifyBackupStrategyRequest req)
        {
             JsonResponseModel<ModifyBackupStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public async Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceProject）用于修改数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public async Task<ModifyDBInstanceProjectResponse> ModifyDBInstanceProject(ModifyDBInstanceProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstanceProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceProject）用于修改数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public ModifyDBInstanceProjectResponse ModifyDBInstanceProjectSync(ModifyDBInstanceProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstanceProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceRenewFlag）用于修改实例续费标记
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceRenewFlagResponse"/></returns>
        public async Task<ModifyDBInstanceRenewFlagResponse> ModifyDBInstanceRenewFlag(ModifyDBInstanceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDBInstanceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceRenewFlag）用于修改实例续费标记
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceRenewFlagResponse"/></returns>
        public ModifyDBInstanceRenewFlagResponse ModifyDBInstanceRenewFlagSync(ModifyDBInstanceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDBInstanceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBName）用于更新数据库名。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public async Task<ModifyDBNameResponse> ModifyDBName(ModifyDBNameRequest req)
        {
             JsonResponseModel<ModifyDBNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBName）用于更新数据库名。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public ModifyDBNameResponse ModifyDBNameSync(ModifyDBNameRequest req)
        {
             JsonResponseModel<ModifyDBNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBRemark）用于修改数据库备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public async Task<ModifyDBRemarkResponse> ModifyDBRemark(ModifyDBRemarkRequest req)
        {
             JsonResponseModel<ModifyDBRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBRemark）用于修改数据库备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public ModifyDBRemarkResponse ModifyDBRemarkSync(ModifyDBRemarkRequest req)
        {
             JsonResponseModel<ModifyDBRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceSpan）用于修改实例的可维护时间窗
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceSpanRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceSpanResponse"/></returns>
        public async Task<ModifyMaintenanceSpanResponse> ModifyMaintenanceSpan(ModifyMaintenanceSpanRequest req)
        {
             JsonResponseModel<ModifyMaintenanceSpanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMaintenanceSpan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintenanceSpanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceSpan）用于修改实例的可维护时间窗
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceSpanRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceSpanResponse"/></returns>
        public ModifyMaintenanceSpanResponse ModifyMaintenanceSpanSync(ModifyMaintenanceSpanRequest req)
        {
             JsonResponseModel<ModifyMaintenanceSpanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMaintenanceSpan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaintenanceSpanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyMigration）可以修改已有的迁移任务信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public async Task<ModifyMigrationResponse> ModifyMigration(ModifyMigrationRequest req)
        {
             JsonResponseModel<ModifyMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyMigration）可以修改已有的迁移任务信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public ModifyMigrationResponse ModifyMigrationSync(ModifyMigrationRequest req)
        {
             JsonResponseModel<ModifyMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyPublishSubscribeName）修改发布订阅的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeNameRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeNameResponse"/></returns>
        public async Task<ModifyPublishSubscribeNameResponse> ModifyPublishSubscribeName(ModifyPublishSubscribeNameRequest req)
        {
             JsonResponseModel<ModifyPublishSubscribeNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPublishSubscribeName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPublishSubscribeNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyPublishSubscribeName）修改发布订阅的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyPublishSubscribeNameRequest"/></param>
        /// <returns><see cref="ModifyPublishSubscribeNameResponse"/></returns>
        public ModifyPublishSubscribeNameResponse ModifyPublishSubscribeNameSync(ModifyPublishSubscribeNameRequest req)
        {
             JsonResponseModel<ModifyPublishSubscribeNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPublishSubscribeName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPublishSubscribeNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyReadOnlyGroupDetails）用于修改只读组详情。
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupDetailsResponse"/></returns>
        public async Task<ModifyReadOnlyGroupDetailsResponse> ModifyReadOnlyGroupDetails(ModifyReadOnlyGroupDetailsRequest req)
        {
             JsonResponseModel<ModifyReadOnlyGroupDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyReadOnlyGroupDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReadOnlyGroupDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyReadOnlyGroupDetails）用于修改只读组详情。
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupDetailsRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupDetailsResponse"/></returns>
        public ModifyReadOnlyGroupDetailsResponse ModifyReadOnlyGroupDetailsSync(ModifyReadOnlyGroupDetailsRequest req)
        {
             JsonResponseModel<ModifyReadOnlyGroupDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyReadOnlyGroupDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReadOnlyGroupDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RemoveBackups）可以删除用户手动创建的备份文件。待删除的备份策略可以是实例备份，也可以是多库备份。
        /// </summary>
        /// <param name="req"><see cref="RemoveBackupsRequest"/></param>
        /// <returns><see cref="RemoveBackupsResponse"/></returns>
        public async Task<RemoveBackupsResponse> RemoveBackups(RemoveBackupsRequest req)
        {
             JsonResponseModel<RemoveBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RemoveBackups）可以删除用户手动创建的备份文件。待删除的备份策略可以是实例备份，也可以是多库备份。
        /// </summary>
        /// <param name="req"><see cref="RemoveBackupsRequest"/></param>
        /// <returns><see cref="RemoveBackupsResponse"/></returns>
        public RemoveBackupsResponse RemoveBackupsSync(RemoveBackupsRequest req)
        {
             JsonResponseModel<RemoveBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewDBInstance）用于续费实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public async Task<RenewDBInstanceResponse> RenewDBInstance(RenewDBInstanceRequest req)
        {
             JsonResponseModel<RenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewDBInstance）用于续费实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public RenewDBInstanceResponse RenewDBInstanceSync(RenewDBInstanceRequest req)
        {
             JsonResponseModel<RenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewPostpaidDBInstance）用于将通过接口TerminateDBInstance手动隔离的按量计费实例从回收站中恢复。
        /// </summary>
        /// <param name="req"><see cref="RenewPostpaidDBInstanceRequest"/></param>
        /// <returns><see cref="RenewPostpaidDBInstanceResponse"/></returns>
        public async Task<RenewPostpaidDBInstanceResponse> RenewPostpaidDBInstance(RenewPostpaidDBInstanceRequest req)
        {
             JsonResponseModel<RenewPostpaidDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewPostpaidDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewPostpaidDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewPostpaidDBInstance）用于将通过接口TerminateDBInstance手动隔离的按量计费实例从回收站中恢复。
        /// </summary>
        /// <param name="req"><see cref="RenewPostpaidDBInstanceRequest"/></param>
        /// <returns><see cref="RenewPostpaidDBInstanceResponse"/></returns>
        public RenewPostpaidDBInstanceResponse RenewPostpaidDBInstanceSync(RenewPostpaidDBInstanceRequest req)
        {
             JsonResponseModel<RenewPostpaidDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewPostpaidDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewPostpaidDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置实例的账户密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置实例的账户密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public async Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RestoreInstance）用于根据备份文件恢复实例。
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public async Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RestoreInstance）用于根据备份文件恢复实例。
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RollbackInstance）用于回档实例
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public async Task<RollbackInstanceResponse> RollbackInstance(RollbackInstanceRequest req)
        {
             JsonResponseModel<RollbackInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RollbackInstance）用于回档实例
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public RollbackInstanceResponse RollbackInstanceSync(RollbackInstanceRequest req)
        {
             JsonResponseModel<RollbackInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunMigration）用于启动迁移任务，开始迁移
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public async Task<RunMigrationResponse> RunMigration(RunMigrationRequest req)
        {
             JsonResponseModel<RunMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RunMigration）用于启动迁移任务，开始迁移
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public RunMigrationResponse RunMigrationSync(RunMigrationRequest req)
        {
             JsonResponseModel<RunMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(TerminateDBInstance)用于主动销毁按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public async Task<TerminateDBInstanceResponse> TerminateDBInstance(TerminateDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(TerminateDBInstance)用于主动销毁按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public TerminateDBInstanceResponse TerminateDBInstanceSync(TerminateDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDBInstance）用于升级实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public async Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDBInstance）用于升级实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
