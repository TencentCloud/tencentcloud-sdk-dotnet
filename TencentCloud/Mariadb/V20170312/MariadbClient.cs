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

namespace TencentCloud.Mariadb.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mariadb.V20170312.Models;

   public class MariadbClient : AbstractClient{

       private const string endpoint = "mariadb.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MariadbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MariadbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 解隔离MariaDB按量计费实例
        /// </summary>
        /// <param name="req"><see cref="ActivateHourDBInstanceRequest"/></param>
        /// <returns><see cref="ActivateHourDBInstanceResponse"/></returns>
        public async Task<ActivateHourDBInstanceResponse> ActivateHourDBInstance(ActivateHourDBInstanceRequest req)
        {
             JsonResponseModel<ActivateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ActivateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActivateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解隔离MariaDB按量计费实例
        /// </summary>
        /// <param name="req"><see cref="ActivateHourDBInstanceRequest"/></param>
        /// <returns><see cref="ActivateHourDBInstanceResponse"/></returns>
        public ActivateHourDBInstanceResponse ActivateHourDBInstanceSync(ActivateHourDBInstanceRequest req)
        {
             JsonResponseModel<ActivateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ActivateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActivateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定云资源。
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
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定云资源。
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
        /// 取消DCN同步
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public async Task<CancelDcnJobResponse> CancelDcnJob(CancelDcnJobRequest req)
        {
             JsonResponseModel<CancelDcnJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelDcnJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelDcnJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消DCN同步
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public CancelDcnJobResponse CancelDcnJobSync(CancelDcnJobRequest req)
        {
             JsonResponseModel<CancelDcnJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelDcnJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelDcnJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloneAccount）用于克隆实例账户。
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public async Task<CloneAccountResponse> CloneAccount(CloneAccountRequest req)
        {
             JsonResponseModel<CloneAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloneAccount）用于克隆实例账户。
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public CloneAccountResponse CloneAccountSync(CloneAccountRequest req)
        {
             JsonResponseModel<CloneAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CloseDBExtranetAccess)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问，查询实例列表接口将不返回对应实例的外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public async Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CloseDBExtranetAccess)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问，查询实例列表接口将不返回对应实例的外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CopyAccountPrivileges）用于复制云数据库账号的权限。
        /// 注意：相同用户名，不同Host是不同的账号，Readonly属性相同的账号之间才能复制权限。
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public async Task<CopyAccountPrivilegesResponse> CopyAccountPrivileges(CopyAccountPrivilegesRequest req)
        {
             JsonResponseModel<CopyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CopyAccountPrivileges）用于复制云数据库账号的权限。
        /// 注意：相同用户名，不同Host是不同的账号，Readonly属性相同的账号之间才能复制权限。
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public CopyAccountPrivilegesResponse CopyAccountPrivilegesSync(CopyAccountPrivilegesRequest req)
        {
             JsonResponseModel<CopyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAccount）用于创建云数据库账号。一个实例可以创建多个不同的账号，相同的用户名+不同的host是不同的账号。
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
        /// 本接口（CreateAccount）用于创建云数据库账号。一个实例可以创建多个不同的账号，相同的用户名+不同的host是不同的账号。
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
        /// 本接口（CreateDBInstance）用于创建包年包月的MariaDB云数据库实例，可通过传入实例规格、数据库版本号、购买时长和数量等信息创建云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public async Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
             JsonResponseModel<CreateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstance）用于创建包年包月的MariaDB云数据库实例，可通过传入实例规格、数据库版本号、购买时长和数量等信息创建云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
             JsonResponseModel<CreateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Mariadb独享集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterDBInstanceResponse"/></returns>
        public async Task<CreateDedicatedClusterDBInstanceResponse> CreateDedicatedClusterDBInstance(CreateDedicatedClusterDBInstanceRequest req)
        {
             JsonResponseModel<CreateDedicatedClusterDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDedicatedClusterDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDedicatedClusterDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Mariadb独享集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterDBInstanceResponse"/></returns>
        public CreateDedicatedClusterDBInstanceResponse CreateDedicatedClusterDBInstanceSync(CreateDedicatedClusterDBInstanceRequest req)
        {
             JsonResponseModel<CreateDedicatedClusterDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDedicatedClusterDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDedicatedClusterDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建MariaDB按量计费实例
        /// </summary>
        /// <param name="req"><see cref="CreateHourDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDBInstanceResponse"/></returns>
        public async Task<CreateHourDBInstanceResponse> CreateHourDBInstance(CreateHourDBInstanceRequest req)
        {
             JsonResponseModel<CreateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建MariaDB按量计费实例
        /// </summary>
        /// <param name="req"><see cref="CreateHourDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDBInstanceResponse"/></returns>
        public CreateHourDBInstanceResponse CreateHourDBInstanceSync(CreateHourDBInstanceRequest req)
        {
             JsonResponseModel<CreateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTmpInstances）用于创建临时实例。
        /// </summary>
        /// <param name="req"><see cref="CreateTmpInstancesRequest"/></param>
        /// <returns><see cref="CreateTmpInstancesResponse"/></returns>
        public async Task<CreateTmpInstancesResponse> CreateTmpInstances(CreateTmpInstancesRequest req)
        {
             JsonResponseModel<CreateTmpInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTmpInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTmpInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTmpInstances）用于创建临时实例。
        /// </summary>
        /// <param name="req"><see cref="CreateTmpInstancesRequest"/></param>
        /// <returns><see cref="CreateTmpInstancesResponse"/></returns>
        public CreateTmpInstancesResponse CreateTmpInstancesSync(CreateTmpInstancesRequest req)
        {
             JsonResponseModel<CreateTmpInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTmpInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTmpInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAccount）用于删除云数据库账号。用户名+host唯一确定一个账号。
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
        /// 本接口（DeleteAccount）用于删除云数据库账号。用户名+host唯一确定一个账号。
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
        /// 本接口（DescribeAccountPrivileges）用于查询云数据库账号权限。
        /// 注意：注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public async Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
             JsonResponseModel<DescribeAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccountPrivileges）用于查询云数据库账号权限。
        /// 注意：注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
             JsonResponseModel<DescribeAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于查询指定云数据库实例的账号列表。
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
        /// 本接口（DescribeAccounts）用于查询指定云数据库实例的账号列表。
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
        /// 本接口(DescribeBackupFiles)用于查看备份文件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public async Task<DescribeBackupFilesResponse> DescribeBackupFiles(DescribeBackupFilesRequest req)
        {
             JsonResponseModel<DescribeBackupFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackupFiles)用于查看备份文件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public DescribeBackupFilesResponse DescribeBackupFilesSync(DescribeBackupFilesRequest req)
        {
             JsonResponseModel<DescribeBackupFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupTime）用于获取云数据库的备份时间。后台系统将根据此配置定期进行实例备份。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupTimeRequest"/></param>
        /// <returns><see cref="DescribeBackupTimeResponse"/></returns>
        public async Task<DescribeBackupTimeResponse> DescribeBackupTime(DescribeBackupTimeRequest req)
        {
             JsonResponseModel<DescribeBackupTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupTime）用于获取云数据库的备份时间。后台系统将根据此配置定期进行实例备份。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupTimeRequest"/></param>
        /// <returns><see cref="DescribeBackupTimeResponse"/></returns>
        public DescribeBackupTimeResponse DescribeBackupTimeSync(DescribeBackupTimeRequest req)
        {
             JsonResponseModel<DescribeBackupTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBEncryptAttributes)用于查询实例数据加密状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="DescribeDBEncryptAttributesResponse"/></returns>
        public async Task<DescribeDBEncryptAttributesResponse> DescribeDBEncryptAttributes(DescribeDBEncryptAttributesRequest req)
        {
             JsonResponseModel<DescribeDBEncryptAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBEncryptAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBEncryptAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBEncryptAttributes)用于查询实例数据加密状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="DescribeDBEncryptAttributesResponse"/></returns>
        public DescribeDBEncryptAttributesResponse DescribeDBEncryptAttributesSync(DescribeDBEncryptAttributesRequest req)
        {
             JsonResponseModel<DescribeDBEncryptAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBEncryptAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBEncryptAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceDetail)用于查询指定实例的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public async Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetail(DescribeDBInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeDBInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceDetail)用于查询指定实例的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetailSync(DescribeDBInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeDBInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceSpecs)用于查询可创建的云数据库可售卖的规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSpecsResponse"/></returns>
        public async Task<DescribeDBInstanceSpecsResponse> DescribeDBInstanceSpecs(DescribeDBInstanceSpecsRequest req)
        {
             JsonResponseModel<DescribeDBInstanceSpecsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceSpecs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceSpecsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceSpecs)用于查询可创建的云数据库可售卖的规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSpecsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSpecsResponse"/></returns>
        public DescribeDBInstanceSpecsResponse DescribeDBInstanceSpecsSync(DescribeDBInstanceSpecsRequest req)
        {
             JsonResponseModel<DescribeDBInstanceSpecsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceSpecs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceSpecsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBInstances）用于查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回20条实例记录，单次请求最多支持返回100条实例记录。
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
        /// 本接口（DescribeDBInstances）用于查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回20条实例记录，单次请求最多支持返回100条实例记录。
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
        /// 本接口(DescribeDBLogFiles)用于获取数据库的各种日志列表，包括冷备、binlog、errlog和slowlog。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public async Task<DescribeDBLogFilesResponse> DescribeDBLogFiles(DescribeDBLogFilesRequest req)
        {
             JsonResponseModel<DescribeDBLogFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBLogFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBLogFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBLogFiles)用于获取数据库的各种日志列表，包括冷备、binlog、errlog和slowlog。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public DescribeDBLogFilesResponse DescribeDBLogFilesSync(DescribeDBLogFilesRequest req)
        {
             JsonResponseModel<DescribeDBLogFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBLogFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBLogFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBParameters)用于获取数据库的当前参数设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public async Task<DescribeDBParametersResponse> DescribeDBParameters(DescribeDBParametersRequest req)
        {
             JsonResponseModel<DescribeDBParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBParameters)用于获取数据库的当前参数设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public DescribeDBParametersResponse DescribeDBParametersSync(DescribeDBParametersRequest req)
        {
             JsonResponseModel<DescribeDBParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBSecurityGroups）用于查询实例安全组信息
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
        /// 本接口（DescribeDBSecurityGroups）用于查询实例安全组信息
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
        /// 本接口(DescribeDBSlowLogs)用于查询慢查询日志列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public async Task<DescribeDBSlowLogsResponse> DescribeDBSlowLogs(DescribeDBSlowLogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBSlowLogs)用于查询慢查询日志列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public DescribeDBSlowLogsResponse DescribeDBSlowLogsSync(DescribeDBSlowLogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBTmpInstances）用于获取实例回档生成的临时实例
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public async Task<DescribeDBTmpInstancesResponse> DescribeDBTmpInstances(DescribeDBTmpInstancesRequest req)
        {
             JsonResponseModel<DescribeDBTmpInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBTmpInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBTmpInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBTmpInstances）用于获取实例回档生成的临时实例
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public DescribeDBTmpInstancesResponse DescribeDBTmpInstancesSync(DescribeDBTmpInstancesRequest req)
        {
             JsonResponseModel<DescribeDBTmpInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBTmpInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBTmpInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabaseObjects）用于查询云数据库实例的数据库中的对象列表，包含表、存储过程、视图和函数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public async Task<DescribeDatabaseObjectsResponse> DescribeDatabaseObjects(DescribeDatabaseObjectsRequest req)
        {
             JsonResponseModel<DescribeDatabaseObjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabaseObjects）用于查询云数据库实例的数据库中的对象列表，包含表、存储过程、视图和函数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public DescribeDatabaseObjectsResponse DescribeDatabaseObjectsSync(DescribeDatabaseObjectsRequest req)
        {
             JsonResponseModel<DescribeDatabaseObjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabaseObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabaseTable）用于查询云数据库实例的表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public async Task<DescribeDatabaseTableResponse> DescribeDatabaseTable(DescribeDatabaseTableRequest req)
        {
             JsonResponseModel<DescribeDatabaseTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabaseTable）用于查询云数据库实例的表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public DescribeDatabaseTableResponse DescribeDatabaseTableSync(DescribeDatabaseTableRequest req)
        {
             JsonResponseModel<DescribeDatabaseTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabaseTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询云数据库实例的数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public async Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询云数据库实例的数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例灾备详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public async Task<DescribeDcnDetailResponse> DescribeDcnDetail(DescribeDcnDetailRequest req)
        {
             JsonResponseModel<DescribeDcnDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDcnDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDcnDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例灾备详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public DescribeDcnDetailResponse DescribeDcnDetailSync(DescribeDcnDetailRequest req)
        {
             JsonResponseModel<DescribeDcnDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDcnDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDcnDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeFileDownloadUrl)用于获取数据库指定备份或日志文件的下载连接。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public async Task<DescribeFileDownloadUrlResponse> DescribeFileDownloadUrl(DescribeFileDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeFileDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeFileDownloadUrl)用于获取数据库指定备份或日志文件的下载连接。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public DescribeFileDownloadUrlResponse DescribeFileDownloadUrlSync(DescribeFileDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeFileDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询流程状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public async Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
             JsonResponseModel<DescribeFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlow）用于查询流程状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
             JsonResponseModel<DescribeFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）用于获取数据库实例主备节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public async Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）用于获取数据库实例主备节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeLogFileRetentionPeriod)用于查看数据库备份日志的备份天数的设置情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="DescribeLogFileRetentionPeriodResponse"/></returns>
        public async Task<DescribeLogFileRetentionPeriodResponse> DescribeLogFileRetentionPeriod(DescribeLogFileRetentionPeriodRequest req)
        {
             JsonResponseModel<DescribeLogFileRetentionPeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogFileRetentionPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogFileRetentionPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeLogFileRetentionPeriod)用于查看数据库备份日志的备份天数的设置情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="DescribeLogFileRetentionPeriodResponse"/></returns>
        public DescribeLogFileRetentionPeriodResponse DescribeLogFileRetentionPeriodSync(DescribeLogFileRetentionPeriodRequest req)
        {
             JsonResponseModel<DescribeLogFileRetentionPeriodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogFileRetentionPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogFileRetentionPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询云数据库订单信息。传入订单ID来查询订单关联的云数据库实例，和对应的任务流程ID。
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
        /// 本接口（DescribeOrders）用于查询云数据库订单信息。传入订单ID来查询订单关联的云数据库实例，和对应的任务流程ID。
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
        /// 本接口（DescribePrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRequest"/></param>
        /// <returns><see cref="DescribePriceResponse"/></returns>
        public async Task<DescribePriceResponse> DescribePrice(DescribePriceRequest req)
        {
             JsonResponseModel<DescribePriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRequest"/></param>
        /// <returns><see cref="DescribePriceResponse"/></returns>
        public DescribePriceResponse DescribePriceSync(DescribePriceRequest req)
        {
             JsonResponseModel<DescribePriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProjectSecurityGroups）用于查询项目安全组信息
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
        /// 本接口（DescribeProjectSecurityGroups）用于查询项目安全组信息
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
        /// 本接口（DescribeRenewalPrice）用于在续费云数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeRenewalPriceRequest"/></param>
        /// <returns><see cref="DescribeRenewalPriceResponse"/></returns>
        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPrice(DescribeRenewalPriceRequest req)
        {
             JsonResponseModel<DescribeRenewalPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRenewalPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRenewalPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRenewalPrice）用于在续费云数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeRenewalPriceRequest"/></param>
        /// <returns><see cref="DescribeRenewalPriceResponse"/></returns>
        public DescribeRenewalPriceResponse DescribeRenewalPriceSync(DescribeRenewalPriceRequest req)
        {
             JsonResponseModel<DescribeRenewalPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRenewalPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRenewalPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeSaleInfo)用于查询云数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleInfoResponse"/></returns>
        public async Task<DescribeSaleInfoResponse> DescribeSaleInfo(DescribeSaleInfoRequest req)
        {
             JsonResponseModel<DescribeSaleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeSaleInfo)用于查询云数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleInfoResponse"/></returns>
        public DescribeSaleInfoResponse DescribeSaleInfoSync(DescribeSaleInfoRequest req)
        {
             JsonResponseModel<DescribeSaleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUpgradePrice）用于在扩容云数据库实例时，查询变配的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradePriceRequest"/></param>
        /// <returns><see cref="DescribeUpgradePriceResponse"/></returns>
        public async Task<DescribeUpgradePriceResponse> DescribeUpgradePrice(DescribeUpgradePriceRequest req)
        {
             JsonResponseModel<DescribeUpgradePriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUpgradePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUpgradePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUpgradePrice）用于在扩容云数据库实例时，查询变配的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradePriceRequest"/></param>
        /// <returns><see cref="DescribeUpgradePriceResponse"/></returns>
        public DescribeUpgradePriceResponse DescribeUpgradePriceSync(DescribeUpgradePriceRequest req)
        {
             JsonResponseModel<DescribeUpgradePriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUpgradePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUpgradePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DestroyDBInstance)用于销毁已隔离的包年包月实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public async Task<DestroyDBInstanceResponse> DestroyDBInstance(DestroyDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DestroyDBInstance)用于销毁已隔离的包年包月实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public DestroyDBInstanceResponse DestroyDBInstanceSync(DestroyDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyHourDBInstance）用于销毁MariaDB按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDBInstanceResponse"/></returns>
        public async Task<DestroyHourDBInstanceResponse> DestroyHourDBInstance(DestroyHourDBInstanceRequest req)
        {
             JsonResponseModel<DestroyHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyHourDBInstance）用于销毁MariaDB按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDBInstanceResponse"/></returns>
        public DestroyHourDBInstanceResponse DestroyHourDBInstanceSync(DestroyHourDBInstanceRequest req)
        {
             JsonResponseModel<DestroyHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyHourDBInstanceResponse>>(strResp);
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
        /// 相当于在mysqld中执行flush logs，完成切分的binlog将展示在实例控制台binlog列表里。
        /// </summary>
        /// <param name="req"><see cref="FlushBinlogRequest"/></param>
        /// <returns><see cref="FlushBinlogResponse"/></returns>
        public async Task<FlushBinlogResponse> FlushBinlog(FlushBinlogRequest req)
        {
             JsonResponseModel<FlushBinlogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FlushBinlog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlushBinlogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 相当于在mysqld中执行flush logs，完成切分的binlog将展示在实例控制台binlog列表里。
        /// </summary>
        /// <param name="req"><see cref="FlushBinlogRequest"/></param>
        /// <returns><see cref="FlushBinlogResponse"/></returns>
        public FlushBinlogResponse FlushBinlogSync(FlushBinlogRequest req)
        {
             JsonResponseModel<FlushBinlogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FlushBinlog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlushBinlogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GrantAccountPrivileges）用于给云数据库账号赋权。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public async Task<GrantAccountPrivilegesResponse> GrantAccountPrivileges(GrantAccountPrivilegesRequest req)
        {
             JsonResponseModel<GrantAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GrantAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GrantAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GrantAccountPrivileges）用于给云数据库账号赋权。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public GrantAccountPrivilegesResponse GrantAccountPrivilegesSync(GrantAccountPrivilegesRequest req)
        {
             JsonResponseModel<GrantAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GrantAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GrantAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(InitDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public async Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(InitDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public InitDBInstancesResponse InitDBInstancesSync(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(IsolateDBInstance)用于隔离云数据库MariaDB实例（包年包月），隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public async Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(IsolateDBInstance)用于隔离云数据库MariaDB实例（包年包月），隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（IsolateDedicatedDBInstance）用于隔离独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDedicatedDBInstanceResponse"/></returns>
        public async Task<IsolateDedicatedDBInstanceResponse> IsolateDedicatedDBInstance(IsolateDedicatedDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDedicatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateDedicatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDedicatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（IsolateDedicatedDBInstance）用于隔离独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="IsolateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDedicatedDBInstanceResponse"/></returns>
        public IsolateDedicatedDBInstanceResponse IsolateDedicatedDBInstanceSync(IsolateDedicatedDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDedicatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateDedicatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDedicatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离MariaDB按量计费实例
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDBInstanceResponse"/></returns>
        public async Task<IsolateHourDBInstanceResponse> IsolateHourDBInstance(IsolateHourDBInstanceRequest req)
        {
             JsonResponseModel<IsolateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离MariaDB按量计费实例
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDBInstanceResponse"/></returns>
        public IsolateHourDBInstanceResponse IsolateHourDBInstanceSync(IsolateHourDBInstanceRequest req)
        {
             JsonResponseModel<IsolateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（KillSession）用于杀死指定会话。
        /// </summary>
        /// <param name="req"><see cref="KillSessionRequest"/></param>
        /// <returns><see cref="KillSessionResponse"/></returns>
        public async Task<KillSessionResponse> KillSession(KillSessionRequest req)
        {
             JsonResponseModel<KillSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KillSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（KillSession）用于杀死指定会话。
        /// </summary>
        /// <param name="req"><see cref="KillSessionRequest"/></param>
        /// <returns><see cref="KillSessionResponse"/></returns>
        public KillSessionResponse KillSessionSync(KillSessionRequest req)
        {
             JsonResponseModel<KillSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KillSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountDescription）用于修改云数据库账号备注。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountDescription）用于修改云数据库账号备注。
        /// 注意：相同用户名，不同Host是不同的账号。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupTime）用于设置云数据库实例的备份时间。后台系统将根据此配置定期进行实例备份。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupTimeRequest"/></param>
        /// <returns><see cref="ModifyBackupTimeResponse"/></returns>
        public async Task<ModifyBackupTimeResponse> ModifyBackupTime(ModifyBackupTimeRequest req)
        {
             JsonResponseModel<ModifyBackupTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupTime）用于设置云数据库实例的备份时间。后台系统将根据此配置定期进行实例备份。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupTimeRequest"/></param>
        /// <returns><see cref="ModifyBackupTimeResponse"/></returns>
        public ModifyBackupTimeResponse ModifyBackupTimeSync(ModifyBackupTimeRequest req)
        {
             JsonResponseModel<ModifyBackupTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBEncryptAttributes)用于修改实例数据加密。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public async Task<ModifyDBEncryptAttributesResponse> ModifyDBEncryptAttributes(ModifyDBEncryptAttributesRequest req)
        {
             JsonResponseModel<ModifyDBEncryptAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBEncryptAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBEncryptAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBEncryptAttributes)用于修改实例数据加密。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public ModifyDBEncryptAttributesResponse ModifyDBEncryptAttributesSync(ModifyDBEncryptAttributesRequest req)
        {
             JsonResponseModel<ModifyDBEncryptAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBEncryptAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBEncryptAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改云数据库实例的名称。
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
        /// 本接口（ModifyDBInstanceName）用于修改云数据库实例的名称。
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
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改云数据库安全组
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
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改云数据库安全组
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
        /// 本接口（ModifyDBInstancesProject）用于修改云数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public async Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstancesProject）用于修改云数据库实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBParameters)用于修改数据库参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public async Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
             JsonResponseModel<ModifyDBParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBParameters)用于修改数据库参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public ModifyDBParametersResponse ModifyDBParametersSync(ModifyDBParametersRequest req)
        {
             JsonResponseModel<ModifyDBParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBSyncMode）用于修改云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public async Task<ModifyDBSyncModeResponse> ModifyDBSyncMode(ModifyDBSyncModeRequest req)
        {
             JsonResponseModel<ModifyDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBSyncModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBSyncMode）用于修改云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public ModifyDBSyncModeResponse ModifyDBSyncModeSync(ModifyDBSyncModeRequest req)
        {
             JsonResponseModel<ModifyDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBSyncModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceNetwork）用于修改实例所属网络
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public async Task<ModifyInstanceNetworkResponse> ModifyInstanceNetwork(ModifyInstanceNetworkRequest req)
        {
             JsonResponseModel<ModifyInstanceNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceNetwork）用于修改实例所属网络
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public ModifyInstanceNetworkResponse ModifyInstanceNetworkSync(ModifyInstanceNetworkRequest req)
        {
             JsonResponseModel<ModifyInstanceNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceVip）用于修改实例VIP
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVipRequest"/></param>
        /// <returns><see cref="ModifyInstanceVipResponse"/></returns>
        public async Task<ModifyInstanceVipResponse> ModifyInstanceVip(ModifyInstanceVipRequest req)
        {
             JsonResponseModel<ModifyInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceVip）用于修改实例VIP
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVipRequest"/></param>
        /// <returns><see cref="ModifyInstanceVipResponse"/></returns>
        public ModifyInstanceVipResponse ModifyInstanceVipSync(ModifyInstanceVipRequest req)
        {
             JsonResponseModel<ModifyInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceVport）用于修改实例VPORT
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVportRequest"/></param>
        /// <returns><see cref="ModifyInstanceVportResponse"/></returns>
        public async Task<ModifyInstanceVportResponse> ModifyInstanceVport(ModifyInstanceVportRequest req)
        {
             JsonResponseModel<ModifyInstanceVportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyInstanceVport）用于修改实例VPORT
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVportRequest"/></param>
        /// <returns><see cref="ModifyInstanceVportResponse"/></returns>
        public ModifyInstanceVportResponse ModifyInstanceVportSync(ModifyInstanceVportRequest req)
        {
             JsonResponseModel<ModifyInstanceVportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyLogFileRetentionPeriod)用于修改数据库备份日志保存天数。
        /// </summary>
        /// <param name="req"><see cref="ModifyLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="ModifyLogFileRetentionPeriodResponse"/></returns>
        public async Task<ModifyLogFileRetentionPeriodResponse> ModifyLogFileRetentionPeriod(ModifyLogFileRetentionPeriodRequest req)
        {
             JsonResponseModel<ModifyLogFileRetentionPeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogFileRetentionPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogFileRetentionPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyLogFileRetentionPeriod)用于修改数据库备份日志保存天数。
        /// </summary>
        /// <param name="req"><see cref="ModifyLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="ModifyLogFileRetentionPeriodResponse"/></returns>
        public ModifyLogFileRetentionPeriodResponse ModifyLogFileRetentionPeriodSync(ModifyLogFileRetentionPeriodRequest req)
        {
             JsonResponseModel<ModifyLogFileRetentionPeriodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogFileRetentionPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogFileRetentionPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifyRealServerAccessStrategyResponse> ModifyRealServerAccessStrategy(ModifyRealServerAccessStrategyRequest req)
        {
             JsonResponseModel<ModifyRealServerAccessStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRealServerAccessStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRealServerAccessStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyRealServerAccessStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRealServerAccessStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRealServerAccessStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifySyncTaskAttribute) 用于修改同步任务的属性（目前只支持修改任务名称）
        /// </summary>
        /// <param name="req"><see cref="ModifySyncTaskAttributeRequest"/></param>
        /// <returns><see cref="ModifySyncTaskAttributeResponse"/></returns>
        public async Task<ModifySyncTaskAttributeResponse> ModifySyncTaskAttribute(ModifySyncTaskAttributeRequest req)
        {
             JsonResponseModel<ModifySyncTaskAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySyncTaskAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncTaskAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifySyncTaskAttribute) 用于修改同步任务的属性（目前只支持修改任务名称）
        /// </summary>
        /// <param name="req"><see cref="ModifySyncTaskAttributeRequest"/></param>
        /// <returns><see cref="ModifySyncTaskAttributeResponse"/></returns>
        public ModifySyncTaskAttributeResponse ModifySyncTaskAttributeSync(ModifySyncTaskAttributeRequest req)
        {
             JsonResponseModel<ModifySyncTaskAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySyncTaskAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncTaskAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通云数据库实例的外网访问。开通外网访问后，您可通过外网域名和端口访问实例，可使用查询实例列表接口获取外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public async Task<OpenDBExtranetAccessResponse> OpenDBExtranetAccess(OpenDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通云数据库实例的外网访问。开通外网访问后，您可通过外网域名和端口访问实例，可使用查询实例列表接口获取外网域名和端口信息。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public OpenDBExtranetAccessResponse OpenDBExtranetAccessSync(OpenDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewDBInstance）用于续费云数据库实例。
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
        /// 本接口（RenewDBInstance）用于续费云数据库实例。
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
        /// 本接口（ResetAccountPassword）用于重置云数据库账号的密码。
        /// 注意：相同用户名，不同Host是不同的账号。
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
        /// 本接口（ResetAccountPassword）用于重置云数据库账号的密码。
        /// 注意：相同用户名，不同Host是不同的账号。
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
        /// 本接口（RestartDBInstances）用于重启数据库实例
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public async Task<RestartDBInstancesResponse> RestartDBInstances(RestartDBInstancesRequest req)
        {
             JsonResponseModel<RestartDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RestartDBInstances）用于重启数据库实例
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public RestartDBInstancesResponse RestartDBInstancesSync(RestartDBInstancesRequest req)
        {
             JsonResponseModel<RestartDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SwitchDBInstanceHA）用于发起实例主备切换。
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceHARequest"/></param>
        /// <returns><see cref="SwitchDBInstanceHAResponse"/></returns>
        public async Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHA(SwitchDBInstanceHARequest req)
        {
             JsonResponseModel<SwitchDBInstanceHAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDBInstanceHA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDBInstanceHAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SwitchDBInstanceHA）用于发起实例主备切换。
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceHARequest"/></param>
        /// <returns><see cref="SwitchDBInstanceHAResponse"/></returns>
        public SwitchDBInstanceHAResponse SwitchDBInstanceHASync(SwitchDBInstanceHARequest req)
        {
             JsonResponseModel<SwitchDBInstanceHAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDBInstanceHA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDBInstanceHAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（TerminateDedicatedDBInstance）用于销毁已隔离的独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public async Task<TerminateDedicatedDBInstanceResponse> TerminateDedicatedDBInstance(TerminateDedicatedDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDedicatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateDedicatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDedicatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（TerminateDedicatedDBInstance）用于销毁已隔离的独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public TerminateDedicatedDBInstanceResponse TerminateDedicatedDBInstanceSync(TerminateDedicatedDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDedicatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateDedicatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDedicatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpgradeDBInstance)用于扩容云数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
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
        /// 本接口(UpgradeDBInstance)用于扩容云数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
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

        /// <summary>
        /// 本接口(UpgradeDedicatedDBInstance)用于扩容独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDBInstanceResponse"/></returns>
        public async Task<UpgradeDedicatedDBInstanceResponse> UpgradeDedicatedDBInstance(UpgradeDedicatedDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDedicatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDedicatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDedicatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpgradeDedicatedDBInstance)用于扩容独享云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDBInstanceResponse"/></returns>
        public UpgradeDedicatedDBInstanceResponse UpgradeDedicatedDBInstanceSync(UpgradeDedicatedDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDedicatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDedicatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDedicatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
