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

namespace TencentCloud.Dasb.V20191018
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dasb.V20191018.Models;

   public class DasbClient : AbstractClient{

       private const string endpoint = "dasb.tencentcloudapi.com";
       private const string version = "2019-10-18";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DasbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DasbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加资产组成员
        /// </summary>
        /// <param name="req"><see cref="AddDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="AddDeviceGroupMembersResponse"/></returns>
        public async Task<AddDeviceGroupMembersResponse> AddDeviceGroupMembers(AddDeviceGroupMembersRequest req)
        {
             JsonResponseModel<AddDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加资产组成员
        /// </summary>
        /// <param name="req"><see cref="AddDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="AddDeviceGroupMembersResponse"/></returns>
        public AddDeviceGroupMembersResponse AddDeviceGroupMembersSync(AddDeviceGroupMembersRequest req)
        {
             JsonResponseModel<AddDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户组成员
        /// </summary>
        /// <param name="req"><see cref="AddUserGroupMembersRequest"/></param>
        /// <returns><see cref="AddUserGroupMembersResponse"/></returns>
        public async Task<AddUserGroupMembersResponse> AddUserGroupMembers(AddUserGroupMembersRequest req)
        {
             JsonResponseModel<AddUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户组成员
        /// </summary>
        /// <param name="req"><see cref="AddUserGroupMembersRequest"/></param>
        /// <returns><see cref="AddUserGroupMembersResponse"/></returns>
        public AddUserGroupMembersResponse AddUserGroupMembersSync(AddUserGroupMembersRequest req)
        {
             JsonResponseModel<AddUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定主机账号密码
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPasswordResponse"/></returns>
        public async Task<BindDeviceAccountPasswordResponse> BindDeviceAccountPassword(BindDeviceAccountPasswordRequest req)
        {
             JsonResponseModel<BindDeviceAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDeviceAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定主机账号密码
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPasswordResponse"/></returns>
        public BindDeviceAccountPasswordResponse BindDeviceAccountPasswordSync(BindDeviceAccountPasswordRequest req)
        {
             JsonResponseModel<BindDeviceAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDeviceAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定主机账号私钥
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPrivateKeyResponse"/></returns>
        public async Task<BindDeviceAccountPrivateKeyResponse> BindDeviceAccountPrivateKey(BindDeviceAccountPrivateKeyRequest req)
        {
             JsonResponseModel<BindDeviceAccountPrivateKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDeviceAccountPrivateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceAccountPrivateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定主机账号私钥
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPrivateKeyResponse"/></returns>
        public BindDeviceAccountPrivateKeyResponse BindDeviceAccountPrivateKeySync(BindDeviceAccountPrivateKeyRequest req)
        {
             JsonResponseModel<BindDeviceAccountPrivateKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDeviceAccountPrivateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceAccountPrivateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产绑定的堡垒机服务
        /// </summary>
        /// <param name="req"><see cref="BindDeviceResourceRequest"/></param>
        /// <returns><see cref="BindDeviceResourceResponse"/></returns>
        public async Task<BindDeviceResourceResponse> BindDeviceResource(BindDeviceResourceRequest req)
        {
             JsonResponseModel<BindDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产绑定的堡垒机服务
        /// </summary>
        /// <param name="req"><see cref="BindDeviceResourceRequest"/></param>
        /// <returns><see cref="BindDeviceResourceResponse"/></returns>
        public BindDeviceResourceResponse BindDeviceResourceSync(BindDeviceResourceRequest req)
        {
             JsonResponseModel<BindDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建访问权限
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public async Task<CreateAclResponse> CreateAcl(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建访问权限
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public CreateAclResponse CreateAclSync(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建手工资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncJobRequest"/></param>
        /// <returns><see cref="CreateAssetSyncJobResponse"/></returns>
        public async Task<CreateAssetSyncJobResponse> CreateAssetSyncJob(CreateAssetSyncJobRequest req)
        {
             JsonResponseModel<CreateAssetSyncJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建手工资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncJobRequest"/></param>
        /// <returns><see cref="CreateAssetSyncJobResponse"/></returns>
        public CreateAssetSyncJobResponse CreateAssetSyncJobSync(CreateAssetSyncJobRequest req)
        {
             JsonResponseModel<CreateAssetSyncJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetSyncJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetSyncJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建高危命令模板
        /// </summary>
        /// <param name="req"><see cref="CreateCmdTemplateRequest"/></param>
        /// <returns><see cref="CreateCmdTemplateResponse"/></returns>
        public async Task<CreateCmdTemplateResponse> CreateCmdTemplate(CreateCmdTemplateRequest req)
        {
             JsonResponseModel<CreateCmdTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCmdTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmdTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建高危命令模板
        /// </summary>
        /// <param name="req"><see cref="CreateCmdTemplateRequest"/></param>
        /// <returns><see cref="CreateCmdTemplateResponse"/></returns>
        public CreateCmdTemplateResponse CreateCmdTemplateSync(CreateCmdTemplateRequest req)
        {
             JsonResponseModel<CreateCmdTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCmdTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmdTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建主机账号
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceAccountRequest"/></param>
        /// <returns><see cref="CreateDeviceAccountResponse"/></returns>
        public async Task<CreateDeviceAccountResponse> CreateDeviceAccount(CreateDeviceAccountRequest req)
        {
             JsonResponseModel<CreateDeviceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDeviceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建主机账号
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceAccountRequest"/></param>
        /// <returns><see cref="CreateDeviceAccountResponse"/></returns>
        public CreateDeviceAccountResponse CreateDeviceAccountSync(CreateDeviceAccountRequest req)
        {
             JsonResponseModel<CreateDeviceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDeviceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建资产组
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public async Task<CreateDeviceGroupResponse> CreateDeviceGroup(CreateDeviceGroupRequest req)
        {
             JsonResponseModel<CreateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建资产组
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public CreateDeviceGroupResponse CreateDeviceGroupSync(CreateDeviceGroupRequest req)
        {
             JsonResponseModel<CreateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建堡垒机实例
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public async Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建堡垒机实例
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
             JsonResponseModel<CreateResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public async Task<CreateUserGroupResponse> CreateUserGroup(CreateUserGroupRequest req)
        {
             JsonResponseModel<CreateUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public CreateUserGroupResponse CreateUserGroupSync(CreateUserGroupRequest req)
        {
             JsonResponseModel<CreateUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问权限
        /// </summary>
        /// <param name="req"><see cref="DeleteAclsRequest"/></param>
        /// <returns><see cref="DeleteAclsResponse"/></returns>
        public async Task<DeleteAclsResponse> DeleteAcls(DeleteAclsRequest req)
        {
             JsonResponseModel<DeleteAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问权限
        /// </summary>
        /// <param name="req"><see cref="DeleteAclsRequest"/></param>
        /// <returns><see cref="DeleteAclsResponse"/></returns>
        public DeleteAclsResponse DeleteAclsSync(DeleteAclsRequest req)
        {
             JsonResponseModel<DeleteAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除高危命令模板
        /// </summary>
        /// <param name="req"><see cref="DeleteCmdTemplatesRequest"/></param>
        /// <returns><see cref="DeleteCmdTemplatesResponse"/></returns>
        public async Task<DeleteCmdTemplatesResponse> DeleteCmdTemplates(DeleteCmdTemplatesRequest req)
        {
             JsonResponseModel<DeleteCmdTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCmdTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmdTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除高危命令模板
        /// </summary>
        /// <param name="req"><see cref="DeleteCmdTemplatesRequest"/></param>
        /// <returns><see cref="DeleteCmdTemplatesResponse"/></returns>
        public DeleteCmdTemplatesResponse DeleteCmdTemplatesSync(DeleteCmdTemplatesRequest req)
        {
             JsonResponseModel<DeleteCmdTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCmdTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmdTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceAccountsRequest"/></param>
        /// <returns><see cref="DeleteDeviceAccountsResponse"/></returns>
        public async Task<DeleteDeviceAccountsResponse> DeleteDeviceAccounts(DeleteDeviceAccountsRequest req)
        {
             JsonResponseModel<DeleteDeviceAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeviceAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceAccountsRequest"/></param>
        /// <returns><see cref="DeleteDeviceAccountsResponse"/></returns>
        public DeleteDeviceAccountsResponse DeleteDeviceAccountsSync(DeleteDeviceAccountsRequest req)
        {
             JsonResponseModel<DeleteDeviceAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeviceAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupMembersResponse"/></returns>
        public async Task<DeleteDeviceGroupMembersResponse> DeleteDeviceGroupMembers(DeleteDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupMembersResponse"/></returns>
        public DeleteDeviceGroupMembersResponse DeleteDeviceGroupMembersSync(DeleteDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupsResponse"/></returns>
        public async Task<DeleteDeviceGroupsResponse> DeleteDeviceGroups(DeleteDeviceGroupsRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupsResponse"/></returns>
        public DeleteDeviceGroupsResponse DeleteDeviceGroupsSync(DeleteDeviceGroupsRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主机
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public async Task<DeleteDevicesResponse> DeleteDevices(DeleteDevicesRequest req)
        {
             JsonResponseModel<DeleteDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主机
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public DeleteDevicesResponse DeleteDevicesSync(DeleteDevicesRequest req)
        {
             JsonResponseModel<DeleteDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteUserGroupMembersResponse"/></returns>
        public async Task<DeleteUserGroupMembersResponse> DeleteUserGroupMembers(DeleteUserGroupMembersRequest req)
        {
             JsonResponseModel<DeleteUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteUserGroupMembersResponse"/></returns>
        public DeleteUserGroupMembersResponse DeleteUserGroupMembersSync(DeleteUserGroupMembersRequest req)
        {
             JsonResponseModel<DeleteUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public async Task<DeleteUserGroupsResponse> DeleteUserGroups(DeleteUserGroupsRequest req)
        {
             JsonResponseModel<DeleteUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public DeleteUserGroupsResponse DeleteUserGroupsSync(DeleteUserGroupsRequest req)
        {
             JsonResponseModel<DeleteUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public async Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通服务，初始化资源，只针对新购资源
        /// </summary>
        /// <param name="req"><see cref="DeployResourceRequest"/></param>
        /// <returns><see cref="DeployResourceResponse"/></returns>
        public async Task<DeployResourceResponse> DeployResource(DeployResourceRequest req)
        {
             JsonResponseModel<DeployResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeployResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通服务，初始化资源，只针对新购资源
        /// </summary>
        /// <param name="req"><see cref="DeployResourceRequest"/></param>
        /// <returns><see cref="DeployResourceResponse"/></returns>
        public DeployResourceResponse DeployResourceSync(DeployResourceRequest req)
        {
             JsonResponseModel<DeployResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeployResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeployResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclsRequest"/></param>
        /// <returns><see cref="DescribeAclsResponse"/></returns>
        public async Task<DescribeAclsResponse> DescribeAcls(DescribeAclsRequest req)
        {
             JsonResponseModel<DescribeAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclsRequest"/></param>
        /// <returns><see cref="DescribeAclsResponse"/></returns>
        public DescribeAclsResponse DescribeAclsSync(DescribeAclsRequest req)
        {
             JsonResponseModel<DescribeAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncStatusResponse"/></returns>
        public async Task<DescribeAssetSyncStatusResponse> DescribeAssetSyncStatus(DescribeAssetSyncStatusRequest req)
        {
             JsonResponseModel<DescribeAssetSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncStatusResponse"/></returns>
        public DescribeAssetSyncStatusResponse DescribeAssetSyncStatusSync(DescribeAssetSyncStatusRequest req)
        {
             JsonResponseModel<DescribeAssetSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询命令模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCmdTemplatesRequest"/></param>
        /// <returns><see cref="DescribeCmdTemplatesResponse"/></returns>
        public async Task<DescribeCmdTemplatesResponse> DescribeCmdTemplates(DescribeCmdTemplatesRequest req)
        {
             JsonResponseModel<DescribeCmdTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmdTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmdTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询命令模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCmdTemplatesRequest"/></param>
        /// <returns><see cref="DescribeCmdTemplatesResponse"/></returns>
        public DescribeCmdTemplatesResponse DescribeCmdTemplatesSync(DescribeCmdTemplatesRequest req)
        {
             JsonResponseModel<DescribeCmdTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmdTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmdTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDasbImageIdsRequest"/></param>
        /// <returns><see cref="DescribeDasbImageIdsResponse"/></returns>
        public async Task<DescribeDasbImageIdsResponse> DescribeDasbImageIds(DescribeDasbImageIdsRequest req)
        {
             JsonResponseModel<DescribeDasbImageIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDasbImageIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDasbImageIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDasbImageIdsRequest"/></param>
        /// <returns><see cref="DescribeDasbImageIdsResponse"/></returns>
        public DescribeDasbImageIdsResponse DescribeDasbImageIdsSync(DescribeDasbImageIdsRequest req)
        {
             JsonResponseModel<DescribeDasbImageIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDasbImageIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDasbImageIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceAccountsRequest"/></param>
        /// <returns><see cref="DescribeDeviceAccountsResponse"/></returns>
        public async Task<DescribeDeviceAccountsResponse> DescribeDeviceAccounts(DescribeDeviceAccountsRequest req)
        {
             JsonResponseModel<DescribeDeviceAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceAccountsRequest"/></param>
        /// <returns><see cref="DescribeDeviceAccountsResponse"/></returns>
        public DescribeDeviceAccountsResponse DescribeDeviceAccountsSync(DescribeDeviceAccountsRequest req)
        {
             JsonResponseModel<DescribeDeviceAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupMembersResponse"/></returns>
        public async Task<DescribeDeviceGroupMembersResponse> DescribeDeviceGroupMembers(DescribeDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupMembersResponse"/></returns>
        public DescribeDeviceGroupMembersResponse DescribeDeviceGroupMembersSync(DescribeDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupsResponse"/></returns>
        public async Task<DescribeDeviceGroupsResponse> DescribeDeviceGroups(DescribeDeviceGroupsRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupsResponse"/></returns>
        public DescribeDeviceGroupsResponse DescribeDeviceGroupsSync(DescribeDeviceGroupsRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询登录日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginEventRequest"/></param>
        /// <returns><see cref="DescribeLoginEventResponse"/></returns>
        public async Task<DescribeLoginEventResponse> DescribeLoginEvent(DescribeLoginEventRequest req)
        {
             JsonResponseModel<DescribeLoginEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoginEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询登录日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginEventRequest"/></param>
        /// <returns><see cref="DescribeLoginEventResponse"/></returns>
        public DescribeLoginEventResponse DescribeLoginEventSync(DescribeLoginEventRequest req)
        {
             JsonResponseModel<DescribeLoginEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoginEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeOperationEventRequest"/></param>
        /// <returns><see cref="DescribeOperationEventResponse"/></returns>
        public async Task<DescribeOperationEventResponse> DescribeOperationEvent(DescribeOperationEventRequest req)
        {
             JsonResponseModel<DescribeOperationEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOperationEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOperationEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeOperationEventRequest"/></param>
        /// <returns><see cref="DescribeOperationEventResponse"/></returns>
        public DescribeOperationEventResponse DescribeOperationEventSync(DescribeOperationEventRequest req)
        {
             JsonResponseModel<DescribeOperationEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOperationEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOperationEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户购买的堡垒机服务信息，包括资源ID、授权点数、VPC、过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public async Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户购买的堡垒机服务信息，包括资源ID、授权点数、VPC、过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeUserGroupMembersResponse"/></returns>
        public async Task<DescribeUserGroupMembersResponse> DescribeUserGroupMembers(DescribeUserGroupMembersRequest req)
        {
             JsonResponseModel<DescribeUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeUserGroupMembersResponse"/></returns>
        public DescribeUserGroupMembersResponse DescribeUserGroupMembersSync(DescribeUserGroupMembersRequest req)
        {
             JsonResponseModel<DescribeUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupsRequest"/></param>
        /// <returns><see cref="DescribeUserGroupsResponse"/></returns>
        public async Task<DescribeUserGroupsResponse> DescribeUserGroups(DescribeUserGroupsRequest req)
        {
             JsonResponseModel<DescribeUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupsRequest"/></param>
        /// <returns><see cref="DescribeUserGroupsResponse"/></returns>
        public DescribeUserGroupsResponse DescribeUserGroupsSync(DescribeUserGroupsRequest req)
        {
             JsonResponseModel<DescribeUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public async Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入外部资产信息
        /// </summary>
        /// <param name="req"><see cref="ImportExternalDeviceRequest"/></param>
        /// <returns><see cref="ImportExternalDeviceResponse"/></returns>
        public async Task<ImportExternalDeviceResponse> ImportExternalDevice(ImportExternalDeviceRequest req)
        {
             JsonResponseModel<ImportExternalDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportExternalDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportExternalDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入外部资产信息
        /// </summary>
        /// <param name="req"><see cref="ImportExternalDeviceRequest"/></param>
        /// <returns><see cref="ImportExternalDeviceResponse"/></returns>
        public ImportExternalDeviceResponse ImportExternalDeviceSync(ImportExternalDeviceRequest req)
        {
             JsonResponseModel<ImportExternalDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportExternalDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportExternalDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改访问权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRequest"/></param>
        /// <returns><see cref="ModifyAclResponse"/></returns>
        public async Task<ModifyAclResponse> ModifyAcl(ModifyAclRequest req)
        {
             JsonResponseModel<ModifyAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改访问权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRequest"/></param>
        /// <returns><see cref="ModifyAclResponse"/></returns>
        public ModifyAclResponse ModifyAclSync(ModifyAclRequest req)
        {
             JsonResponseModel<ModifyAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改高危命令模板
        /// </summary>
        /// <param name="req"><see cref="ModifyCmdTemplateRequest"/></param>
        /// <returns><see cref="ModifyCmdTemplateResponse"/></returns>
        public async Task<ModifyCmdTemplateResponse> ModifyCmdTemplate(ModifyCmdTemplateRequest req)
        {
             JsonResponseModel<ModifyCmdTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCmdTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmdTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改高危命令模板
        /// </summary>
        /// <param name="req"><see cref="ModifyCmdTemplateRequest"/></param>
        /// <returns><see cref="ModifyCmdTemplateResponse"/></returns>
        public ModifyCmdTemplateResponse ModifyCmdTemplateSync(ModifyCmdTemplateRequest req)
        {
             JsonResponseModel<ModifyCmdTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCmdTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmdTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public async Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
             JsonResponseModel<ModifyDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
             JsonResponseModel<ModifyDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产组
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceGroupRequest"/></param>
        /// <returns><see cref="ModifyDeviceGroupResponse"/></returns>
        public async Task<ModifyDeviceGroupResponse> ModifyDeviceGroup(ModifyDeviceGroupRequest req)
        {
             JsonResponseModel<ModifyDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产组
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceGroupRequest"/></param>
        /// <returns><see cref="ModifyDeviceGroupResponse"/></returns>
        public ModifyDeviceGroupResponse ModifyDeviceGroupSync(ModifyDeviceGroupRequest req)
        {
             JsonResponseModel<ModifyDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源变配
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public async Task<ModifyResourceResponse> ModifyResource(ModifyResourceRequest req)
        {
             JsonResponseModel<ModifyResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源变配
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public ModifyResourceResponse ModifyResourceSync(ModifyResourceRequest req)
        {
             JsonResponseModel<ModifyResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public async Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清除设备账号绑定密码
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPasswordResponse"/></returns>
        public async Task<ResetDeviceAccountPasswordResponse> ResetDeviceAccountPassword(ResetDeviceAccountPasswordRequest req)
        {
             JsonResponseModel<ResetDeviceAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDeviceAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清除设备账号绑定密码
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPasswordResponse"/></returns>
        public ResetDeviceAccountPasswordResponse ResetDeviceAccountPasswordSync(ResetDeviceAccountPasswordRequest req)
        {
             JsonResponseModel<ResetDeviceAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetDeviceAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清除设备账号绑定的密钥
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPrivateKeyResponse"/></returns>
        public async Task<ResetDeviceAccountPrivateKeyResponse> ResetDeviceAccountPrivateKey(ResetDeviceAccountPrivateKeyRequest req)
        {
             JsonResponseModel<ResetDeviceAccountPrivateKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDeviceAccountPrivateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceAccountPrivateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清除设备账号绑定的密钥
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPrivateKeyResponse"/></returns>
        public ResetDeviceAccountPrivateKeyResponse ResetDeviceAccountPrivateKeySync(ResetDeviceAccountPrivateKeyRequest req)
        {
             JsonResponseModel<ResetDeviceAccountPrivateKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetDeviceAccountPrivateKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceAccountPrivateKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置用户
        /// </summary>
        /// <param name="req"><see cref="ResetUserRequest"/></param>
        /// <returns><see cref="ResetUserResponse"/></returns>
        public async Task<ResetUserResponse> ResetUser(ResetUserRequest req)
        {
             JsonResponseModel<ResetUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置用户
        /// </summary>
        /// <param name="req"><see cref="ResetUserRequest"/></param>
        /// <returns><see cref="ResetUserResponse"/></returns>
        public ResetUserResponse ResetUserSync(ResetUserRequest req)
        {
             JsonResponseModel<ResetUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索审计日志
        /// </summary>
        /// <param name="req"><see cref="SearchAuditLogRequest"/></param>
        /// <returns><see cref="SearchAuditLogResponse"/></returns>
        public async Task<SearchAuditLogResponse> SearchAuditLog(SearchAuditLogRequest req)
        {
             JsonResponseModel<SearchAuditLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchAuditLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchAuditLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索审计日志
        /// </summary>
        /// <param name="req"><see cref="SearchAuditLogRequest"/></param>
        /// <returns><see cref="SearchAuditLogResponse"/></returns>
        public SearchAuditLogResponse SearchAuditLogSync(SearchAuditLogRequest req)
        {
             JsonResponseModel<SearchAuditLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchAuditLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchAuditLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 命令执行检索
        /// </summary>
        /// <param name="req"><see cref="SearchCommandRequest"/></param>
        /// <returns><see cref="SearchCommandResponse"/></returns>
        public async Task<SearchCommandResponse> SearchCommand(SearchCommandRequest req)
        {
             JsonResponseModel<SearchCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 命令执行检索
        /// </summary>
        /// <param name="req"><see cref="SearchCommandRequest"/></param>
        /// <returns><see cref="SearchCommandResponse"/></returns>
        public SearchCommandResponse SearchCommandSync(SearchCommandRequest req)
        {
             JsonResponseModel<SearchCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据会话Id搜索Command
        /// </summary>
        /// <param name="req"><see cref="SearchCommandBySidRequest"/></param>
        /// <returns><see cref="SearchCommandBySidResponse"/></returns>
        public async Task<SearchCommandBySidResponse> SearchCommandBySid(SearchCommandBySidRequest req)
        {
             JsonResponseModel<SearchCommandBySidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchCommandBySid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchCommandBySidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据会话Id搜索Command
        /// </summary>
        /// <param name="req"><see cref="SearchCommandBySidRequest"/></param>
        /// <returns><see cref="SearchCommandBySidResponse"/></returns>
        public SearchCommandBySidResponse SearchCommandBySidSync(SearchCommandBySidRequest req)
        {
             JsonResponseModel<SearchCommandBySidResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchCommandBySid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchCommandBySidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件传输检索
        /// </summary>
        /// <param name="req"><see cref="SearchFileRequest"/></param>
        /// <returns><see cref="SearchFileResponse"/></returns>
        public async Task<SearchFileResponse> SearchFile(SearchFileRequest req)
        {
             JsonResponseModel<SearchFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件传输检索
        /// </summary>
        /// <param name="req"><see cref="SearchFileRequest"/></param>
        /// <returns><see cref="SearchFileResponse"/></returns>
        public SearchFileResponse SearchFileSync(SearchFileRequest req)
        {
             JsonResponseModel<SearchFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索文件传输会话下文件操作列表
        /// </summary>
        /// <param name="req"><see cref="SearchFileBySidRequest"/></param>
        /// <returns><see cref="SearchFileBySidResponse"/></returns>
        public async Task<SearchFileBySidResponse> SearchFileBySid(SearchFileBySidRequest req)
        {
             JsonResponseModel<SearchFileBySidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFileBySid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFileBySidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索文件传输会话下文件操作列表
        /// </summary>
        /// <param name="req"><see cref="SearchFileBySidRequest"/></param>
        /// <returns><see cref="SearchFileBySidResponse"/></returns>
        public SearchFileBySidResponse SearchFileBySidSync(SearchFileBySidRequest req)
        {
             JsonResponseModel<SearchFileBySidResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFileBySid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFileBySidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索会话
        /// </summary>
        /// <param name="req"><see cref="SearchSessionRequest"/></param>
        /// <returns><see cref="SearchSessionResponse"/></returns>
        public async Task<SearchSessionResponse> SearchSession(SearchSessionRequest req)
        {
             JsonResponseModel<SearchSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索会话
        /// </summary>
        /// <param name="req"><see cref="SearchSessionRequest"/></param>
        /// <returns><see cref="SearchSessionResponse"/></returns>
        public SearchSessionResponse SearchSessionSync(SearchSessionRequest req)
        {
             JsonResponseModel<SearchSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 命令检索
        /// </summary>
        /// <param name="req"><see cref="SearchSessionCommandRequest"/></param>
        /// <returns><see cref="SearchSessionCommandResponse"/></returns>
        public async Task<SearchSessionCommandResponse> SearchSessionCommand(SearchSessionCommandRequest req)
        {
             JsonResponseModel<SearchSessionCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchSessionCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchSessionCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 命令检索
        /// </summary>
        /// <param name="req"><see cref="SearchSessionCommandRequest"/></param>
        /// <returns><see cref="SearchSessionCommandResponse"/></returns>
        public SearchSessionCommandResponse SearchSessionCommandSync(SearchSessionCommandRequest req)
        {
             JsonResponseModel<SearchSessionCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchSessionCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchSessionCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
