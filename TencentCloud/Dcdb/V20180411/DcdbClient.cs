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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DcdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 解隔离DCDB后付费实例
        /// </summary>
        /// <param name="req"><see cref="ActiveHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="ActiveHourDCDBInstanceResponse"/></returns>
        public async Task<ActiveHourDCDBInstanceResponse> ActiveHourDCDBInstance(ActiveHourDCDBInstanceRequest req)
        {
             JsonResponseModel<ActiveHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ActiveHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActiveHourDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解隔离DCDB后付费实例
        /// </summary>
        /// <param name="req"><see cref="ActiveHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="ActiveHourDCDBInstanceResponse"/></returns>
        public ActiveHourDCDBInstanceResponse ActiveHourDCDBInstanceSync(ActiveHourDCDBInstanceRequest req)
        {
             JsonResponseModel<ActiveHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ActiveHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActiveHourDCDBInstanceResponse>>(strResp);
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
        /// 本接口（CreateDCDBInstance）用于创建包年包月的云数据库实例，可通过传入实例规格、数据库版本号、购买时长等信息创建云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDCDBInstanceResponse"/></returns>
        public async Task<CreateDCDBInstanceResponse> CreateDCDBInstance(CreateDCDBInstanceRequest req)
        {
             JsonResponseModel<CreateDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDCDBInstance）用于创建包年包月的云数据库实例，可通过传入实例规格、数据库版本号、购买时长等信息创建云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDCDBInstanceResponse"/></returns>
        public CreateDCDBInstanceResponse CreateDCDBInstanceSync(CreateDCDBInstanceRequest req)
        {
             JsonResponseModel<CreateDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建DCDB后付费实例
        /// </summary>
        /// <param name="req"><see cref="CreateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDCDBInstanceResponse"/></returns>
        public async Task<CreateHourDCDBInstanceResponse> CreateHourDCDBInstance(CreateHourDCDBInstanceRequest req)
        {
             JsonResponseModel<CreateHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHourDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建DCDB后付费实例
        /// </summary>
        /// <param name="req"><see cref="CreateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDCDBInstanceResponse"/></returns>
        public CreateHourDCDBInstanceResponse CreateHourDCDBInstanceSync(CreateHourDCDBInstanceRequest req)
        {
             JsonResponseModel<CreateHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHourDCDBInstanceResponse>>(strResp);
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
        /// 本接口（DescribeDBSyncMode）用于查询云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSyncModeRequest"/></param>
        /// <returns><see cref="DescribeDBSyncModeResponse"/></returns>
        public async Task<DescribeDBSyncModeResponse> DescribeDBSyncMode(DescribeDBSyncModeRequest req)
        {
             JsonResponseModel<DescribeDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSyncModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBSyncMode）用于查询云数据库实例的同步模式。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSyncModeRequest"/></param>
        /// <returns><see cref="DescribeDBSyncModeResponse"/></returns>
        public DescribeDBSyncModeResponse DescribeDBSyncModeSync(DescribeDBSyncModeRequest req)
        {
             JsonResponseModel<DescribeDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSyncModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBInstanceNodeInfo）用于获取实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceNodeInfoResponse"/></returns>
        public async Task<DescribeDCDBInstanceNodeInfoResponse> DescribeDCDBInstanceNodeInfo(DescribeDCDBInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeDCDBInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBInstanceNodeInfo）用于获取实例节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceNodeInfoResponse"/></returns>
        public DescribeDCDBInstanceNodeInfoResponse DescribeDCDBInstanceNodeInfoSync(DescribeDCDBInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeDCDBInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDCDBInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回10条实例记录，单次请求最多支持返回100条实例记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstancesResponse"/></returns>
        public async Task<DescribeDCDBInstancesResponse> DescribeDCDBInstances(DescribeDCDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDCDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云数据库实例列表，支持通过项目ID、实例ID、内网地址、实例名称等来筛选实例。
        /// 如果不指定任何筛选条件，则默认返回10条实例记录，单次请求最多支持返回100条实例记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstancesResponse"/></returns>
        public DescribeDCDBInstancesResponse DescribeDCDBInstancesSync(DescribeDCDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDCDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDCDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBPrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBPriceResponse"/></returns>
        public async Task<DescribeDCDBPriceResponse> DescribeDCDBPrice(DescribeDCDBPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBPrice）用于在购买实例前，查询实例的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBPriceResponse"/></returns>
        public DescribeDCDBPriceResponse DescribeDCDBPriceSync(DescribeDCDBPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDCDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBRenewalPrice）用于在续费分布式数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBRenewalPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBRenewalPriceResponse"/></returns>
        public async Task<DescribeDCDBRenewalPriceResponse> DescribeDCDBRenewalPrice(DescribeDCDBRenewalPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBRenewalPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBRenewalPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBRenewalPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBRenewalPrice）用于在续费分布式数据库实例时，查询续费的价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBRenewalPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBRenewalPriceResponse"/></returns>
        public DescribeDCDBRenewalPriceResponse DescribeDCDBRenewalPriceSync(DescribeDCDBRenewalPriceRequest req)
        {
             JsonResponseModel<DescribeDCDBRenewalPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDCDBRenewalPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBRenewalPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDCDBSaleInfo)用于查询分布式数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBSaleInfoResponse"/></returns>
        public async Task<DescribeDCDBSaleInfoResponse> DescribeDCDBSaleInfo(DescribeDCDBSaleInfoRequest req)
        {
             JsonResponseModel<DescribeDCDBSaleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBSaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBSaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDCDBSaleInfo)用于查询分布式数据库可售卖的地域和可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBSaleInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBSaleInfoResponse"/></returns>
        public DescribeDCDBSaleInfoResponse DescribeDCDBSaleInfoSync(DescribeDCDBSaleInfoRequest req)
        {
             JsonResponseModel<DescribeDCDBSaleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDCDBSaleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBSaleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBShards）用于查询云数据库实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBShardsRequest"/></param>
        /// <returns><see cref="DescribeDCDBShardsResponse"/></returns>
        public async Task<DescribeDCDBShardsResponse> DescribeDCDBShards(DescribeDCDBShardsRequest req)
        {
             JsonResponseModel<DescribeDCDBShardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBShards）用于查询云数据库实例的分片信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBShardsRequest"/></param>
        /// <returns><see cref="DescribeDCDBShardsResponse"/></returns>
        public DescribeDCDBShardsResponse DescribeDCDBShardsSync(DescribeDCDBShardsRequest req)
        {
             JsonResponseModel<DescribeDCDBShardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDCDBShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBUpgradePrice）用于查询变配分布式数据库实例价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBUpgradePriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBUpgradePriceResponse"/></returns>
        public async Task<DescribeDCDBUpgradePriceResponse> DescribeDCDBUpgradePrice(DescribeDCDBUpgradePriceRequest req)
        {
             JsonResponseModel<DescribeDCDBUpgradePriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDCDBUpgradePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBUpgradePriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDCDBUpgradePrice）用于查询变配分布式数据库实例价格。
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBUpgradePriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBUpgradePriceResponse"/></returns>
        public DescribeDCDBUpgradePriceResponse DescribeDCDBUpgradePriceSync(DescribeDCDBUpgradePriceRequest req)
        {
             JsonResponseModel<DescribeDCDBUpgradePriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDCDBUpgradePrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDCDBUpgradePriceResponse>>(strResp);
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
        /// 本接口（DescribeFlow）用于查询流程状态
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
        /// 本接口（DescribeFlow）用于查询流程状态
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
        /// 本接口（DescribeOrders）用于查询分布式数据库订单信息。传入订单ID来查询订单关联的分布式数据库实例，和对应的任务流程ID。
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
        /// 本接口（DescribeOrders）用于查询分布式数据库订单信息。传入订单ID来查询订单关联的分布式数据库实例，和对应的任务流程ID。
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
        /// 本接口（DescribeProjects）用于查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public async Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProjects）用于查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可创建的分布式数据库可售卖的分片规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeShardSpecRequest"/></param>
        /// <returns><see cref="DescribeShardSpecResponse"/></returns>
        public async Task<DescribeShardSpecResponse> DescribeShardSpec(DescribeShardSpecRequest req)
        {
             JsonResponseModel<DescribeShardSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShardSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShardSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可创建的分布式数据库可售卖的分片规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeShardSpecRequest"/></param>
        /// <returns><see cref="DescribeShardSpecResponse"/></returns>
        public DescribeShardSpecResponse DescribeShardSpecSync(DescribeShardSpecRequest req)
        {
             JsonResponseModel<DescribeShardSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShardSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShardSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSqlLogs）用于获取实例SQL日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlLogsRequest"/></param>
        /// <returns><see cref="DescribeSqlLogsResponse"/></returns>
        public async Task<DescribeSqlLogsResponse> DescribeSqlLogs(DescribeSqlLogsRequest req)
        {
             JsonResponseModel<DescribeSqlLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSqlLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSqlLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSqlLogs）用于获取实例SQL日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlLogsRequest"/></param>
        /// <returns><see cref="DescribeSqlLogsResponse"/></returns>
        public DescribeSqlLogsResponse DescribeSqlLogsSync(DescribeSqlLogsRequest req)
        {
             JsonResponseModel<DescribeSqlLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSqlLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSqlLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUserTasks）用于拉取用户任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTasksRequest"/></param>
        /// <returns><see cref="DescribeUserTasksResponse"/></returns>
        public async Task<DescribeUserTasksResponse> DescribeUserTasks(DescribeUserTasksRequest req)
        {
             JsonResponseModel<DescribeUserTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUserTasks）用于拉取用户任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTasksRequest"/></param>
        /// <returns><see cref="DescribeUserTasksResponse"/></returns>
        public DescribeUserTasksResponse DescribeUserTasksSync(DescribeUserTasksRequest req)
        {
             JsonResponseModel<DescribeUserTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DestroyDCDBInstance)用于销毁已隔离的包年包月实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDCDBInstanceResponse"/></returns>
        public async Task<DestroyDCDBInstanceResponse> DestroyDCDBInstance(DestroyDCDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DestroyDCDBInstance)用于销毁已隔离的包年包月实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDCDBInstanceResponse"/></returns>
        public DestroyDCDBInstanceResponse DestroyDCDBInstanceSync(DestroyDCDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyHourDCDBInstance）用于销毁按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDCDBInstanceResponse"/></returns>
        public async Task<DestroyHourDCDBInstanceResponse> DestroyHourDCDBInstance(DestroyHourDCDBInstanceRequest req)
        {
             JsonResponseModel<DestroyHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyHourDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyHourDCDBInstance）用于销毁按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDCDBInstanceResponse"/></returns>
        public DestroyHourDCDBInstanceResponse DestroyHourDCDBInstanceSync(DestroyHourDCDBInstanceRequest req)
        {
             JsonResponseModel<DestroyHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyHourDCDBInstanceResponse>>(strResp);
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
        /// 相当于在所有分片的mysqld中执行flush logs，完成切分的binlog将展示在各个分片控制台binlog列表里。
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
        /// 相当于在所有分片的mysqld中执行flush logs，完成切分的binlog将展示在各个分片控制台binlog列表里。
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
        /// 本接口(InitDCDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req"><see cref="InitDCDBInstancesRequest"/></param>
        /// <returns><see cref="InitDCDBInstancesResponse"/></returns>
        public async Task<InitDCDBInstancesResponse> InitDCDBInstances(InitDCDBInstancesRequest req)
        {
             JsonResponseModel<InitDCDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitDCDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDCDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(InitDCDBInstances)用于初始化云数据库实例，包括设置默认字符集、表名大小写敏感等。
        /// </summary>
        /// <param name="req"><see cref="InitDCDBInstancesRequest"/></param>
        /// <returns><see cref="InitDCDBInstancesResponse"/></returns>
        public InitDCDBInstancesResponse InitDCDBInstancesSync(InitDCDBInstancesRequest req)
        {
             JsonResponseModel<InitDCDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InitDCDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDCDBInstancesResponse>>(strResp);
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
        /// 隔离DCDB后付费实例
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDCDBInstanceResponse"/></returns>
        public async Task<IsolateHourDCDBInstanceResponse> IsolateHourDCDBInstance(IsolateHourDCDBInstanceRequest req)
        {
             JsonResponseModel<IsolateHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateHourDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离DCDB后付费实例
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDCDBInstanceResponse"/></returns>
        public IsolateHourDCDBInstanceResponse IsolateHourDCDBInstanceSync(IsolateHourDCDBInstanceRequest req)
        {
             JsonResponseModel<IsolateHourDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateHourDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateHourDCDBInstanceResponse>>(strResp);
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
        /// 本接口（ModifyDBInstanceName）用于修改实例名字
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
        /// 本接口（ModifyDBInstanceName）用于修改实例名字
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
        /// 本接口（ModifyInstanceNetwork）用于修改实例所属网络。
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
        /// 本接口（ModifyInstanceNetwork）用于修改实例所属网络。
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
        /// 本接口（ModifyInstanceVip）用于修改实例Vip
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
        /// 本接口（ModifyInstanceVip）用于修改实例Vip
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
        /// 本接口（RenewDCDBInstance）用于续费分布式数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDCDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDCDBInstanceResponse"/></returns>
        public async Task<RenewDCDBInstanceResponse> RenewDCDBInstance(RenewDCDBInstanceRequest req)
        {
             JsonResponseModel<RenewDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewDCDBInstance）用于续费分布式数据库实例。
        /// </summary>
        /// <param name="req"><see cref="RenewDCDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDCDBInstanceResponse"/></returns>
        public RenewDCDBInstanceResponse RenewDCDBInstanceSync(RenewDCDBInstanceRequest req)
        {
             JsonResponseModel<RenewDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDCDBInstanceResponse>>(strResp);
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
        /// 本接口(SwitchDBInstanceHA)用于实例主备切换。
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
        /// 本接口(SwitchDBInstanceHA)用于实例主备切换。
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
        /// 本接口（TerminateDedicatedDBInstance）用于销毁已隔离的独享分布式数据库实例。
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
        /// 本接口（TerminateDedicatedDBInstance）用于销毁已隔离的独享分布式数据库实例。
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
        /// 本接口（UpgradeDCDBInstance）用于升级分布式数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDCDBInstanceResponse"/></returns>
        public async Task<UpgradeDCDBInstanceResponse> UpgradeDCDBInstance(UpgradeDCDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDCDBInstance）用于升级分布式数据库实例。本接口完成下单和支付两个动作，如果发生支付失败的错误，调用用户账户相关接口中的支付订单接口（PayDeals）重新支付即可。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDCDBInstanceResponse"/></returns>
        public UpgradeDCDBInstanceResponse UpgradeDCDBInstanceSync(UpgradeDCDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDCDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDCDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDCDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
