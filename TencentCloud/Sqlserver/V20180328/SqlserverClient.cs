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
        /// CreateAccount接口的同步版本，本接口（CreateAccount）用于创建实例账号
        /// </summary>
        /// <param name="req">参考<see cref="CreateAccountRequest"/></param>
        /// <returns>参考<see cref="CreateAccountResponse"/>实例</returns>
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
        /// CreateBackup接口的同步版本，本接口(CreateBackup)用于创建备份。
        /// </summary>
        /// <param name="req">参考<see cref="CreateBackupRequest"/></param>
        /// <returns>参考<see cref="CreateBackupResponse"/>实例</returns>
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
        /// CreateDB接口的同步版本，本接口（CreateDB）用于创建数据库。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBRequest"/></param>
        /// <returns>参考<see cref="CreateDBResponse"/>实例</returns>
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
        /// CreateDBInstances接口的同步版本，本接口（CreateDBInstances）用于创建实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBInstancesRequest"/></param>
        /// <returns>参考<see cref="CreateDBInstancesResponse"/>实例</returns>
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
        /// CreateMigration接口的同步版本，本接口（CreateMigration）作用是创建一个迁移任务
        /// </summary>
        /// <param name="req">参考<see cref="CreateMigrationRequest"/></param>
        /// <returns>参考<see cref="CreateMigrationResponse"/>实例</returns>
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
        /// DeleteAccount接口的同步版本，本接口（DeleteAccount）用于删除实例账号。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAccountRequest"/></param>
        /// <returns>参考<see cref="DeleteAccountResponse"/>实例</returns>
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
        /// DeleteDB接口的同步版本，本接口(DeleteDB)用于删除数据库。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDBRequest"/></param>
        /// <returns>参考<see cref="DeleteDBResponse"/>实例</returns>
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
        /// DeleteMigration接口的同步版本，本接口（DeleteMigration）用于删除迁移任务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMigrationRequest"/></param>
        /// <returns>参考<see cref="DeleteMigrationResponse"/>实例</returns>
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
        /// DescribeAccounts接口的同步版本，本接口（DescribeAccounts）用于拉取实例账户列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountsResponse"/>实例</returns>
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
        /// DescribeBackups接口的同步版本，本接口(DescribeBackups)用于查询备份列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupsRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupsResponse"/>实例</returns>
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
        /// DescribeDBInstances接口的同步版本，本接口(DescribeDBInstances)用于查询实例列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstancesResponse"/>实例</returns>
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
        /// DescribeDBs接口的同步版本，本接口（DescribeDBs）用于查询数据库列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBsResponse"/>实例</returns>
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
        /// DescribeFlowStatus接口的同步版本，本接口(DescribeFlowStatus)用于查询流程状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFlowStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeFlowStatusResponse"/>实例</returns>
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
        /// DescribeMigrationDetail接口的同步版本，本接口（DescribeMigrationDetail）用于查询迁移任务的详细情况
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeMigrationDetailResponse"/>实例</returns>
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
        /// DescribeMigrations接口的同步版本，本接口（DescribeMigrations）根据输入的限定条件，查询符合条件的迁移任务列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMigrationsRequest"/></param>
        /// <returns>参考<see cref="DescribeMigrationsResponse"/>实例</returns>
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
        /// DescribeOrders接口的同步版本，本接口（DescribeOrders）用于查询订单信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOrdersRequest"/></param>
        /// <returns>参考<see cref="DescribeOrdersResponse"/>实例</returns>
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
        /// DescribeProductConfig接口的同步版本，本接口 (DescribeProductConfig) 用于查询售卖规格配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProductConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeProductConfigResponse"/>实例</returns>
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
        /// DescribeRegions接口的同步版本，本接口 (DescribeRegions) 用于查询售卖地域信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeRegionsResponse"/>实例</returns>
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
        /// DescribeRollbackTime接口的同步版本，本接口（DescribeRollbackTime）用于查询实例可回档时间范围
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns>参考<see cref="DescribeRollbackTimeResponse"/>实例</returns>
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
        /// DescribeSlowlogs接口的同步版本，本接口（DescribeSlowlogs）用于获取慢查询日志文件信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSlowlogsRequest"/></param>
        /// <returns>参考<see cref="DescribeSlowlogsResponse"/>实例</returns>
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
        /// DescribeZones接口的同步版本，本接口 (DescribeZones) 用于查询当前可售卖的可用区信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZonesRequest"/></param>
        /// <returns>参考<see cref="DescribeZonesResponse"/>实例</returns>
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
        /// InquiryPriceCreateDBInstances接口的同步版本，本接口（InquiryPriceCreateDBInstances）用于查询申请实例价格。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceCreateDBInstancesResponse"/>实例</returns>
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
        /// InquiryPriceRenewDBInstance接口的同步版本，本接口（InquiryPriceRenewDBInstance）用于查询续费实例的价格。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceRenewDBInstanceResponse"/>实例</returns>
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
        /// InquiryPriceUpgradeDBInstance接口的同步版本，本接口（InquiryPriceUpgradeDBInstance）用于查询升级实例的价格。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceUpgradeDBInstanceResponse"/>实例</returns>
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
        /// ModifyAccountPrivilege接口的同步版本，本接口（ModifyAccountPrivilege）用于修改实例账户权限。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns>参考<see cref="ModifyAccountPrivilegeResponse"/>实例</returns>
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
        /// ModifyAccountRemark接口的同步版本，本接口（ModifyAccountRemark）用于修改账户备注。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns>参考<see cref="ModifyAccountRemarkResponse"/>实例</returns>
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
        /// ModifyDBInstanceName接口的同步版本，本接口（ModifyDBInstanceName）用于修改实例名字。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceNameResponse"/>实例</returns>
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
        /// ModifyDBInstanceProject接口的同步版本，本接口（ModifyDBInstanceProject）用于修改数据库实例所属项目。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceProjectResponse"/>实例</returns>
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
        /// ModifyDBInstanceRenewFlag接口的同步版本，本接口（ModifyDBInstanceRenewFlag）用于修改实例续费标记
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceRenewFlagResponse"/>实例</returns>
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
        /// ModifyDBName接口的同步版本，本接口（ModifyDBName）用于更新数据库名。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBNameRequest"/></param>
        /// <returns>参考<see cref="ModifyDBNameResponse"/>实例</returns>
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
        /// ModifyDBRemark接口的同步版本，本接口（ModifyDBRemark）用于修改数据库备注。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBRemarkRequest"/></param>
        /// <returns>参考<see cref="ModifyDBRemarkResponse"/>实例</returns>
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
        /// ModifyMigration接口的同步版本，本接口（ModifyMigration）可以修改已有的迁移任务信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMigrationRequest"/></param>
        /// <returns>参考<see cref="ModifyMigrationResponse"/>实例</returns>
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
        /// RenewDBInstance接口的同步版本，本接口（RenewDBInstance）用于续费实例。
        /// </summary>
        /// <param name="req">参考<see cref="RenewDBInstanceRequest"/></param>
        /// <returns>参考<see cref="RenewDBInstanceResponse"/>实例</returns>
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
        /// ResetAccountPassword接口的同步版本，本接口（ResetAccountPassword）用于重置实例的账户密码。
        /// </summary>
        /// <param name="req">参考<see cref="ResetAccountPasswordRequest"/></param>
        /// <returns>参考<see cref="ResetAccountPasswordResponse"/>实例</returns>
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
        /// RestartDBInstance接口的同步版本，本接口（RestartDBInstance）用于重启数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="RestartDBInstanceRequest"/></param>
        /// <returns>参考<see cref="RestartDBInstanceResponse"/>实例</returns>
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
        /// RestoreInstance接口的同步版本，本接口（RestoreInstance）用于根据备份文件恢复实例。
        /// </summary>
        /// <param name="req">参考<see cref="RestoreInstanceRequest"/></param>
        /// <returns>参考<see cref="RestoreInstanceResponse"/>实例</returns>
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
        /// RollbackInstance接口的同步版本，本接口（RollbackInstance）用于回档实例
        /// </summary>
        /// <param name="req">参考<see cref="RollbackInstanceRequest"/></param>
        /// <returns>参考<see cref="RollbackInstanceResponse"/>实例</returns>
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
        /// RunMigration接口的同步版本，本接口（RunMigration）用于启动迁移任务，开始迁移
        /// </summary>
        /// <param name="req">参考<see cref="RunMigrationRequest"/></param>
        /// <returns>参考<see cref="RunMigrationResponse"/>实例</returns>
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
        /// TerminateDBInstance接口的同步版本，本接口(TerminateDBInstance)用于主动销毁按量计费实例。
        /// </summary>
        /// <param name="req">参考<see cref="TerminateDBInstanceRequest"/></param>
        /// <returns>参考<see cref="TerminateDBInstanceResponse"/>实例</returns>
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
        /// UpgradeDBInstance接口的同步版本，本接口（UpgradeDBInstance）用于升级实例
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns>参考<see cref="UpgradeDBInstanceResponse"/>实例</returns>
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
