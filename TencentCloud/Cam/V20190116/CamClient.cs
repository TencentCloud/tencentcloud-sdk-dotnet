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

namespace TencentCloud.Cam.V20190116
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cam.V20190116.Models;

   public class CamClient : AbstractClient{

       private const string endpoint = "cam.tencentcloudapi.com";
       private const string version = "2019-01-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加子用户
        /// </summary>
        /// <param name="req"><see cref="AddUserRequest"/></param>
        /// <returns><see cref="AddUserResponse"/></returns>
        public async Task<AddUserResponse> AddUser(AddUserRequest req)
        {
             JsonResponseModel<AddUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加子用户
        /// </summary>
        /// <param name="req"><see cref="AddUserRequest"/></param>
        /// <returns><see cref="AddUserResponse"/></returns>
        public AddUserResponse AddUserSync(AddUserRequest req)
        {
             JsonResponseModel<AddUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户加入到用户组
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public async Task<AddUserToGroupResponse> AddUserToGroup(AddUserToGroupRequest req)
        {
             JsonResponseModel<AddUserToGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUserToGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserToGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户加入到用户组
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public AddUserToGroupResponse AddUserToGroupSync(AddUserToGroupRequest req)
        {
             JsonResponseModel<AddUserToGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUserToGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserToGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachGroupPolicy）可用于绑定策略到用户组。
        /// </summary>
        /// <param name="req"><see cref="AttachGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachGroupPolicyResponse"/></returns>
        public async Task<AttachGroupPolicyResponse> AttachGroupPolicy(AttachGroupPolicyRequest req)
        {
             JsonResponseModel<AttachGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachGroupPolicy）可用于绑定策略到用户组。
        /// </summary>
        /// <param name="req"><see cref="AttachGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachGroupPolicyResponse"/></returns>
        public AttachGroupPolicyResponse AttachGroupPolicySync(AttachGroupPolicyRequest req)
        {
             JsonResponseModel<AttachGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachRolePolicy）用于绑定策略到角色。
        /// </summary>
        /// <param name="req"><see cref="AttachRolePolicyRequest"/></param>
        /// <returns><see cref="AttachRolePolicyResponse"/></returns>
        public async Task<AttachRolePolicyResponse> AttachRolePolicy(AttachRolePolicyRequest req)
        {
             JsonResponseModel<AttachRolePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachRolePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachRolePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachRolePolicy）用于绑定策略到角色。
        /// </summary>
        /// <param name="req"><see cref="AttachRolePolicyRequest"/></param>
        /// <returns><see cref="AttachRolePolicyResponse"/></returns>
        public AttachRolePolicyResponse AttachRolePolicySync(AttachRolePolicyRequest req)
        {
             JsonResponseModel<AttachRolePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachRolePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachRolePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachUserPolicy）可用于绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public async Task<AttachUserPolicyResponse> AttachUserPolicy(AttachUserPolicyRequest req)
        {
             JsonResponseModel<AttachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachUserPolicy）可用于绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public AttachUserPolicyResponse AttachUserPolicySync(AttachUserPolicyRequest req)
        {
             JsonResponseModel<AttachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证自定义多因子Token
        /// </summary>
        /// <param name="req"><see cref="ConsumeCustomMFATokenRequest"/></param>
        /// <returns><see cref="ConsumeCustomMFATokenResponse"/></returns>
        public async Task<ConsumeCustomMFATokenResponse> ConsumeCustomMFAToken(ConsumeCustomMFATokenRequest req)
        {
             JsonResponseModel<ConsumeCustomMFATokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ConsumeCustomMFAToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConsumeCustomMFATokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证自定义多因子Token
        /// </summary>
        /// <param name="req"><see cref="ConsumeCustomMFATokenRequest"/></param>
        /// <returns><see cref="ConsumeCustomMFATokenResponse"/></returns>
        public ConsumeCustomMFATokenResponse ConsumeCustomMFATokenSync(ConsumeCustomMFATokenRequest req)
        {
             JsonResponseModel<ConsumeCustomMFATokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ConsumeCustomMFAToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConsumeCustomMFATokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public async Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePolicy）可用于创建策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public async Task<CreatePolicyResponse> CreatePolicy(CreatePolicyRequest req)
        {
             JsonResponseModel<CreatePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePolicy）可用于创建策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public CreatePolicyResponse CreatePolicySync(CreatePolicyRequest req)
        {
             JsonResponseModel<CreatePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreatePolicyVersion）用于新增策略版本，用户创建了一个策略版本之后可以方便的通过变更策略版本的方式来变更策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyVersionRequest"/></param>
        /// <returns><see cref="CreatePolicyVersionResponse"/></returns>
        public async Task<CreatePolicyVersionResponse> CreatePolicyVersion(CreatePolicyVersionRequest req)
        {
             JsonResponseModel<CreatePolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreatePolicyVersion）用于新增策略版本，用户创建了一个策略版本之后可以方便的通过变更策略版本的方式来变更策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyVersionRequest"/></param>
        /// <returns><see cref="CreatePolicyVersionResponse"/></returns>
        public CreatePolicyVersionResponse CreatePolicyVersionSync(CreatePolicyVersionRequest req)
        {
             JsonResponseModel<CreatePolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateRole）用于创建角色。
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public async Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateRole）用于创建角色。
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="CreateSAMLProviderRequest"/></param>
        /// <returns><see cref="CreateSAMLProviderResponse"/></returns>
        public async Task<CreateSAMLProviderResponse> CreateSAMLProvider(CreateSAMLProviderRequest req)
        {
             JsonResponseModel<CreateSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="CreateSAMLProviderRequest"/></param>
        /// <returns><see cref="CreateSAMLProviderResponse"/></returns>
        public CreateSAMLProviderResponse CreateSAMLProviderSync(CreateSAMLProviderRequest req)
        {
             JsonResponseModel<CreateSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务相关角色
        /// </summary>
        /// <param name="req"><see cref="CreateServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="CreateServiceLinkedRoleResponse"/></returns>
        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRole(CreateServiceLinkedRoleRequest req)
        {
             JsonResponseModel<CreateServiceLinkedRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceLinkedRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceLinkedRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务相关角色
        /// </summary>
        /// <param name="req"><see cref="CreateServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="CreateServiceLinkedRoleResponse"/></returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleSync(CreateServiceLinkedRoleRequest req)
        {
             JsonResponseModel<CreateServiceLinkedRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceLinkedRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceLinkedRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="CreateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="CreateUserSAMLConfigResponse"/></returns>
        public async Task<CreateUserSAMLConfigResponse> CreateUserSAMLConfig(CreateUserSAMLConfigRequest req)
        {
             JsonResponseModel<CreateUserSAMLConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserSAMLConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserSAMLConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="CreateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="CreateUserSAMLConfigResponse"/></returns>
        public CreateUserSAMLConfigResponse CreateUserSAMLConfigSync(CreateUserSAMLConfigRequest req)
        {
             JsonResponseModel<CreateUserSAMLConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserSAMLConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserSAMLConfigResponse>>(strResp);
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
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
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
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeletePolicy）可用于删除策略。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public async Task<DeletePolicyResponse> DeletePolicy(DeletePolicyRequest req)
        {
             JsonResponseModel<DeletePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeletePolicy）可用于删除策略。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public DeletePolicyResponse DeletePolicySync(DeletePolicyRequest req)
        {
             JsonResponseModel<DeletePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeletePolicyVersion）可用于删除一个策略的策略版本。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyVersionRequest"/></param>
        /// <returns><see cref="DeletePolicyVersionResponse"/></returns>
        public async Task<DeletePolicyVersionResponse> DeletePolicyVersion(DeletePolicyVersionRequest req)
        {
             JsonResponseModel<DeletePolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeletePolicyVersion）可用于删除一个策略的策略版本。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyVersionRequest"/></param>
        /// <returns><see cref="DeletePolicyVersionResponse"/></returns>
        public DeletePolicyVersionResponse DeletePolicyVersionSync(DeletePolicyVersionRequest req)
        {
             JsonResponseModel<DeletePolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteRole）用于删除指定角色。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public async Task<DeleteRoleResponse> DeleteRole(DeleteRoleRequest req)
        {
             JsonResponseModel<DeleteRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteRole）用于删除指定角色。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public DeleteRoleResponse DeleteRoleSync(DeleteRoleRequest req)
        {
             JsonResponseModel<DeleteRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除角色权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteRolePermissionsBoundaryResponse"/></returns>
        public async Task<DeleteRolePermissionsBoundaryResponse> DeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest req)
        {
             JsonResponseModel<DeleteRolePermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRolePermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRolePermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除角色权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteRolePermissionsBoundaryResponse"/></returns>
        public DeleteRolePermissionsBoundaryResponse DeleteRolePermissionsBoundarySync(DeleteRolePermissionsBoundaryRequest req)
        {
             JsonResponseModel<DeleteRolePermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRolePermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRolePermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="DeleteSAMLProviderRequest"/></param>
        /// <returns><see cref="DeleteSAMLProviderResponse"/></returns>
        public async Task<DeleteSAMLProviderResponse> DeleteSAMLProvider(DeleteSAMLProviderRequest req)
        {
             JsonResponseModel<DeleteSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="DeleteSAMLProviderRequest"/></param>
        /// <returns><see cref="DeleteSAMLProviderResponse"/></returns>
        public DeleteSAMLProviderResponse DeleteSAMLProviderSync(DeleteSAMLProviderRequest req)
        {
             JsonResponseModel<DeleteSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务相关角色
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="DeleteServiceLinkedRoleResponse"/></returns>
        public async Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest req)
        {
             JsonResponseModel<DeleteServiceLinkedRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceLinkedRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceLinkedRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务相关角色
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="DeleteServiceLinkedRoleResponse"/></returns>
        public DeleteServiceLinkedRoleResponse DeleteServiceLinkedRoleSync(DeleteServiceLinkedRoleRequest req)
        {
             JsonResponseModel<DeleteServiceLinkedRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceLinkedRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceLinkedRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除子用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public async Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除子用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteUserPermissionsBoundaryResponse"/></returns>
        public async Task<DeleteUserPermissionsBoundaryResponse> DeleteUserPermissionsBoundary(DeleteUserPermissionsBoundaryRequest req)
        {
             JsonResponseModel<DeleteUserPermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserPermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserPermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteUserPermissionsBoundaryResponse"/></returns>
        public DeleteUserPermissionsBoundaryResponse DeleteUserPermissionsBoundarySync(DeleteUserPermissionsBoundaryRequest req)
        {
             JsonResponseModel<DeleteUserPermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserPermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserPermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRoleList）用于获取账号下的角色列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public async Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
             JsonResponseModel<DescribeRoleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRoleList）用于获取账号下的角色列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
             JsonResponseModel<DescribeRoleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagResponse"/></returns>
        public async Task<DescribeSafeAuthFlagResponse> DescribeSafeAuthFlag(DescribeSafeAuthFlagRequest req)
        {
             JsonResponseModel<DescribeSafeAuthFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSafeAuthFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeAuthFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagResponse"/></returns>
        public DescribeSafeAuthFlagResponse DescribeSafeAuthFlagSync(DescribeSafeAuthFlagRequest req)
        {
             JsonResponseModel<DescribeSafeAuthFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSafeAuthFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeAuthFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagCollRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagCollResponse"/></returns>
        public async Task<DescribeSafeAuthFlagCollResponse> DescribeSafeAuthFlagColl(DescribeSafeAuthFlagCollRequest req)
        {
             JsonResponseModel<DescribeSafeAuthFlagCollResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSafeAuthFlagColl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeAuthFlagCollResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagCollRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagCollResponse"/></returns>
        public DescribeSafeAuthFlagCollResponse DescribeSafeAuthFlagCollSync(DescribeSafeAuthFlagCollRequest req)
        {
             JsonResponseModel<DescribeSafeAuthFlagCollResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSafeAuthFlagColl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeAuthFlagCollResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全设置(国际站)
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagIntlRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagIntlResponse"/></returns>
        public async Task<DescribeSafeAuthFlagIntlResponse> DescribeSafeAuthFlagIntl(DescribeSafeAuthFlagIntlRequest req)
        {
             JsonResponseModel<DescribeSafeAuthFlagIntlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSafeAuthFlagIntl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeAuthFlagIntlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全设置(国际站)
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagIntlRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagIntlResponse"/></returns>
        public DescribeSafeAuthFlagIntlResponse DescribeSafeAuthFlagIntlSync(DescribeSafeAuthFlagIntlRequest req)
        {
             JsonResponseModel<DescribeSafeAuthFlagIntlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSafeAuthFlagIntl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeAuthFlagIntlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过子用户UIN列表查询子用户
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountsRequest"/></param>
        /// <returns><see cref="DescribeSubAccountsResponse"/></returns>
        public async Task<DescribeSubAccountsResponse> DescribeSubAccounts(DescribeSubAccountsRequest req)
        {
             JsonResponseModel<DescribeSubAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过子用户UIN列表查询子用户
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountsRequest"/></param>
        /// <returns><see cref="DescribeSubAccountsResponse"/></returns>
        public DescribeSubAccountsResponse DescribeSubAccountsSync(DescribeSubAccountsRequest req)
        {
             JsonResponseModel<DescribeSubAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSAMLConfigRequest"/></param>
        /// <returns><see cref="DescribeUserSAMLConfigResponse"/></returns>
        public async Task<DescribeUserSAMLConfigResponse> DescribeUserSAMLConfig(DescribeUserSAMLConfigRequest req)
        {
             JsonResponseModel<DescribeUserSAMLConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserSAMLConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserSAMLConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSAMLConfigRequest"/></param>
        /// <returns><see cref="DescribeUserSAMLConfigResponse"/></returns>
        public DescribeUserSAMLConfigResponse DescribeUserSAMLConfigSync(DescribeUserSAMLConfigRequest req)
        {
             JsonResponseModel<DescribeUserSAMLConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserSAMLConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserSAMLConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachGroupPolicy）可用于解除绑定到用户组的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachGroupPolicyResponse"/></returns>
        public async Task<DetachGroupPolicyResponse> DetachGroupPolicy(DetachGroupPolicyRequest req)
        {
             JsonResponseModel<DetachGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachGroupPolicy）可用于解除绑定到用户组的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachGroupPolicyResponse"/></returns>
        public DetachGroupPolicyResponse DetachGroupPolicySync(DetachGroupPolicyRequest req)
        {
             JsonResponseModel<DetachGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachRolePolicy）用于解除绑定角色的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachRolePolicyRequest"/></param>
        /// <returns><see cref="DetachRolePolicyResponse"/></returns>
        public async Task<DetachRolePolicyResponse> DetachRolePolicy(DetachRolePolicyRequest req)
        {
             JsonResponseModel<DetachRolePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachRolePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachRolePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachRolePolicy）用于解除绑定角色的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachRolePolicyRequest"/></param>
        /// <returns><see cref="DetachRolePolicyResponse"/></returns>
        public DetachRolePolicyResponse DetachRolePolicySync(DetachRolePolicyRequest req)
        {
             JsonResponseModel<DetachRolePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachRolePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachRolePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachUserPolicy）可用于解除绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public async Task<DetachUserPolicyResponse> DetachUserPolicy(DetachUserPolicyRequest req)
        {
             JsonResponseModel<DetachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachUserPolicy）可用于解除绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public DetachUserPolicyResponse DetachUserPolicySync(DetachUserPolicyRequest req)
        {
             JsonResponseModel<DetachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账户摘要 
        /// </summary>
        /// <param name="req"><see cref="GetAccountSummaryRequest"/></param>
        /// <returns><see cref="GetAccountSummaryResponse"/></returns>
        public async Task<GetAccountSummaryResponse> GetAccountSummary(GetAccountSummaryRequest req)
        {
             JsonResponseModel<GetAccountSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAccountSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAccountSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账户摘要 
        /// </summary>
        /// <param name="req"><see cref="GetAccountSummaryRequest"/></param>
        /// <returns><see cref="GetAccountSummaryResponse"/></returns>
        public GetAccountSummaryResponse GetAccountSummarySync(GetAccountSummaryRequest req)
        {
             JsonResponseModel<GetAccountSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAccountSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAccountSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义多因子Token关联信息
        /// </summary>
        /// <param name="req"><see cref="GetCustomMFATokenInfoRequest"/></param>
        /// <returns><see cref="GetCustomMFATokenInfoResponse"/></returns>
        public async Task<GetCustomMFATokenInfoResponse> GetCustomMFATokenInfo(GetCustomMFATokenInfoRequest req)
        {
             JsonResponseModel<GetCustomMFATokenInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCustomMFATokenInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCustomMFATokenInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义多因子Token关联信息
        /// </summary>
        /// <param name="req"><see cref="GetCustomMFATokenInfoRequest"/></param>
        /// <returns><see cref="GetCustomMFATokenInfoResponse"/></returns>
        public GetCustomMFATokenInfoResponse GetCustomMFATokenInfoSync(GetCustomMFATokenInfoRequest req)
        {
             JsonResponseModel<GetCustomMFATokenInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCustomMFATokenInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCustomMFATokenInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组详情
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public async Task<GetGroupResponse> GetGroup(GetGroupRequest req)
        {
             JsonResponseModel<GetGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组详情
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public GetGroupResponse GetGroupSync(GetGroupRequest req)
        {
             JsonResponseModel<GetGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetPolicy）可用于查询查看策略详情。
        /// </summary>
        /// <param name="req"><see cref="GetPolicyRequest"/></param>
        /// <returns><see cref="GetPolicyResponse"/></returns>
        public async Task<GetPolicyResponse> GetPolicy(GetPolicyRequest req)
        {
             JsonResponseModel<GetPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetPolicy）可用于查询查看策略详情。
        /// </summary>
        /// <param name="req"><see cref="GetPolicyRequest"/></param>
        /// <returns><see cref="GetPolicyResponse"/></returns>
        public GetPolicyResponse GetPolicySync(GetPolicyRequest req)
        {
             JsonResponseModel<GetPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（GetPolicyVersion）用于查询策略版本详情
        /// </summary>
        /// <param name="req"><see cref="GetPolicyVersionRequest"/></param>
        /// <returns><see cref="GetPolicyVersionResponse"/></returns>
        public async Task<GetPolicyVersionResponse> GetPolicyVersion(GetPolicyVersionRequest req)
        {
             JsonResponseModel<GetPolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（GetPolicyVersion）用于查询策略版本详情
        /// </summary>
        /// <param name="req"><see cref="GetPolicyVersionRequest"/></param>
        /// <returns><see cref="GetPolicyVersionResponse"/></returns>
        public GetPolicyVersionResponse GetPolicyVersionSync(GetPolicyVersionRequest req)
        {
             JsonResponseModel<GetPolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetRole）用于获取指定角色的详细信息。
        /// </summary>
        /// <param name="req"><see cref="GetRoleRequest"/></param>
        /// <returns><see cref="GetRoleResponse"/></returns>
        public async Task<GetRoleResponse> GetRole(GetRoleRequest req)
        {
             JsonResponseModel<GetRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetRole）用于获取指定角色的详细信息。
        /// </summary>
        /// <param name="req"><see cref="GetRoleRequest"/></param>
        /// <returns><see cref="GetRoleResponse"/></returns>
        public GetRoleResponse GetRoleSync(GetRoleRequest req)
        {
             JsonResponseModel<GetRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取角色权限边界
        /// </summary>
        /// <param name="req"><see cref="GetRolePermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetRolePermissionBoundaryResponse"/></returns>
        public async Task<GetRolePermissionBoundaryResponse> GetRolePermissionBoundary(GetRolePermissionBoundaryRequest req)
        {
             JsonResponseModel<GetRolePermissionBoundaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRolePermissionBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRolePermissionBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取角色权限边界
        /// </summary>
        /// <param name="req"><see cref="GetRolePermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetRolePermissionBoundaryResponse"/></returns>
        public GetRolePermissionBoundaryResponse GetRolePermissionBoundarySync(GetRolePermissionBoundaryRequest req)
        {
             JsonResponseModel<GetRolePermissionBoundaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRolePermissionBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRolePermissionBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SAML身份提供商详情
        /// </summary>
        /// <param name="req"><see cref="GetSAMLProviderRequest"/></param>
        /// <returns><see cref="GetSAMLProviderResponse"/></returns>
        public async Task<GetSAMLProviderResponse> GetSAMLProvider(GetSAMLProviderRequest req)
        {
             JsonResponseModel<GetSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SAML身份提供商详情
        /// </summary>
        /// <param name="req"><see cref="GetSAMLProviderRequest"/></param>
        /// <returns><see cref="GetSAMLProviderResponse"/></returns>
        public GetSAMLProviderResponse GetSAMLProviderSync(GetSAMLProviderRequest req)
        {
             JsonResponseModel<GetSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取密钥最近使用情况
        /// </summary>
        /// <param name="req"><see cref="GetSecurityLastUsedRequest"/></param>
        /// <returns><see cref="GetSecurityLastUsedResponse"/></returns>
        public async Task<GetSecurityLastUsedResponse> GetSecurityLastUsed(GetSecurityLastUsedRequest req)
        {
             JsonResponseModel<GetSecurityLastUsedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSecurityLastUsed");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSecurityLastUsedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取密钥最近使用情况
        /// </summary>
        /// <param name="req"><see cref="GetSecurityLastUsedRequest"/></param>
        /// <returns><see cref="GetSecurityLastUsedResponse"/></returns>
        public GetSecurityLastUsedResponse GetSecurityLastUsedSync(GetSecurityLastUsedRequest req)
        {
             JsonResponseModel<GetSecurityLastUsedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSecurityLastUsed");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSecurityLastUsedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据删除TaskId获取服务相关角色删除状态
        /// </summary>
        /// <param name="req"><see cref="GetServiceLinkedRoleDeletionStatusRequest"/></param>
        /// <returns><see cref="GetServiceLinkedRoleDeletionStatusResponse"/></returns>
        public async Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest req)
        {
             JsonResponseModel<GetServiceLinkedRoleDeletionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetServiceLinkedRoleDeletionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceLinkedRoleDeletionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据删除TaskId获取服务相关角色删除状态
        /// </summary>
        /// <param name="req"><see cref="GetServiceLinkedRoleDeletionStatusRequest"/></param>
        /// <returns><see cref="GetServiceLinkedRoleDeletionStatusResponse"/></returns>
        public GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatusSync(GetServiceLinkedRoleDeletionStatusRequest req)
        {
             JsonResponseModel<GetServiceLinkedRoleDeletionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetServiceLinkedRoleDeletionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceLinkedRoleDeletionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询子用户
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public async Task<GetUserResponse> GetUser(GetUserRequest req)
        {
             JsonResponseModel<GetUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询子用户
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public GetUserResponse GetUserSync(GetUserRequest req)
        {
             JsonResponseModel<GetUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户权限边界
        /// </summary>
        /// <param name="req"><see cref="GetUserPermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetUserPermissionBoundaryResponse"/></returns>
        public async Task<GetUserPermissionBoundaryResponse> GetUserPermissionBoundary(GetUserPermissionBoundaryRequest req)
        {
             JsonResponseModel<GetUserPermissionBoundaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUserPermissionBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserPermissionBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户权限边界
        /// </summary>
        /// <param name="req"><see cref="GetUserPermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetUserPermissionBoundaryResponse"/></returns>
        public GetUserPermissionBoundaryResponse GetUserPermissionBoundarySync(GetUserPermissionBoundaryRequest req)
        {
             JsonResponseModel<GetUserPermissionBoundaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUserPermissionBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserPermissionBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出指定CAM用户的访问密钥
        /// </summary>
        /// <param name="req"><see cref="ListAccessKeysRequest"/></param>
        /// <returns><see cref="ListAccessKeysResponse"/></returns>
        public async Task<ListAccessKeysResponse> ListAccessKeys(ListAccessKeysRequest req)
        {
             JsonResponseModel<ListAccessKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAccessKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAccessKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出指定CAM用户的访问密钥
        /// </summary>
        /// <param name="req"><see cref="ListAccessKeysRequest"/></param>
        /// <returns><see cref="ListAccessKeysResponse"/></returns>
        public ListAccessKeysResponse ListAccessKeysSync(ListAccessKeysRequest req)
        {
             JsonResponseModel<ListAccessKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAccessKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAccessKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListAttachedGroupPolicies）可用于查询用户组关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedGroupPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedGroupPoliciesResponse"/></returns>
        public async Task<ListAttachedGroupPoliciesResponse> ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest req)
        {
             JsonResponseModel<ListAttachedGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAttachedGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAttachedGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListAttachedGroupPolicies）可用于查询用户组关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedGroupPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedGroupPoliciesResponse"/></returns>
        public ListAttachedGroupPoliciesResponse ListAttachedGroupPoliciesSync(ListAttachedGroupPoliciesRequest req)
        {
             JsonResponseModel<ListAttachedGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAttachedGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAttachedGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListAttachedRolePolicies）用于获取角色绑定的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedRolePoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedRolePoliciesResponse"/></returns>
        public async Task<ListAttachedRolePoliciesResponse> ListAttachedRolePolicies(ListAttachedRolePoliciesRequest req)
        {
             JsonResponseModel<ListAttachedRolePoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAttachedRolePolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAttachedRolePoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListAttachedRolePolicies）用于获取角色绑定的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedRolePoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedRolePoliciesResponse"/></returns>
        public ListAttachedRolePoliciesResponse ListAttachedRolePoliciesSync(ListAttachedRolePoliciesRequest req)
        {
             JsonResponseModel<ListAttachedRolePoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAttachedRolePolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAttachedRolePoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListAttachedUserPolicies）可用于查询子账号关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserPoliciesResponse"/></returns>
        public async Task<ListAttachedUserPoliciesResponse> ListAttachedUserPolicies(ListAttachedUserPoliciesRequest req)
        {
             JsonResponseModel<ListAttachedUserPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAttachedUserPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAttachedUserPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListAttachedUserPolicies）可用于查询子账号关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserPoliciesResponse"/></returns>
        public ListAttachedUserPoliciesResponse ListAttachedUserPoliciesSync(ListAttachedUserPoliciesRequest req)
        {
             JsonResponseModel<ListAttachedUserPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAttachedUserPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAttachedUserPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取协作者列表
        /// </summary>
        /// <param name="req"><see cref="ListCollaboratorsRequest"/></param>
        /// <returns><see cref="ListCollaboratorsResponse"/></returns>
        public async Task<ListCollaboratorsResponse> ListCollaborators(ListCollaboratorsRequest req)
        {
             JsonResponseModel<ListCollaboratorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListCollaborators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCollaboratorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取协作者列表
        /// </summary>
        /// <param name="req"><see cref="ListCollaboratorsRequest"/></param>
        /// <returns><see cref="ListCollaboratorsResponse"/></returns>
        public ListCollaboratorsResponse ListCollaboratorsSync(ListCollaboratorsRequest req)
        {
             JsonResponseModel<ListCollaboratorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListCollaborators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListCollaboratorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListEntitiesForPolicy）可用于查询策略关联的实体列表。
        /// </summary>
        /// <param name="req"><see cref="ListEntitiesForPolicyRequest"/></param>
        /// <returns><see cref="ListEntitiesForPolicyResponse"/></returns>
        public async Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicy(ListEntitiesForPolicyRequest req)
        {
             JsonResponseModel<ListEntitiesForPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEntitiesForPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEntitiesForPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListEntitiesForPolicy）可用于查询策略关联的实体列表。
        /// </summary>
        /// <param name="req"><see cref="ListEntitiesForPolicyRequest"/></param>
        /// <returns><see cref="ListEntitiesForPolicyResponse"/></returns>
        public ListEntitiesForPolicyResponse ListEntitiesForPolicySync(ListEntitiesForPolicyRequest req)
        {
             JsonResponseModel<ListEntitiesForPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEntitiesForPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEntitiesForPolicyResponse>>(strResp);
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
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public async Task<ListGroupsResponse> ListGroups(ListGroupsRequest req)
        {
             JsonResponseModel<ListGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGroupsResponse>>(strResp);
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
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public ListGroupsResponse ListGroupsSync(ListGroupsRequest req)
        {
             JsonResponseModel<ListGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出用户关联的用户组
        /// </summary>
        /// <param name="req"><see cref="ListGroupsForUserRequest"/></param>
        /// <returns><see cref="ListGroupsForUserResponse"/></returns>
        public async Task<ListGroupsForUserResponse> ListGroupsForUser(ListGroupsForUserRequest req)
        {
             JsonResponseModel<ListGroupsForUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListGroupsForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGroupsForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出用户关联的用户组
        /// </summary>
        /// <param name="req"><see cref="ListGroupsForUserRequest"/></param>
        /// <returns><see cref="ListGroupsForUserResponse"/></returns>
        public ListGroupsForUserResponse ListGroupsForUserSync(ListGroupsForUserRequest req)
        {
             JsonResponseModel<ListGroupsForUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListGroupsForUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGroupsForUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListPolicies）可用于查询策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public async Task<ListPoliciesResponse> ListPolicies(ListPoliciesRequest req)
        {
             JsonResponseModel<ListPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListPolicies）可用于查询策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public ListPoliciesResponse ListPoliciesSync(ListPoliciesRequest req)
        {
             JsonResponseModel<ListPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有已授权服务
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesGrantingServiceAccessRequest"/></param>
        /// <returns><see cref="ListPoliciesGrantingServiceAccessResponse"/></returns>
        public async Task<ListPoliciesGrantingServiceAccessResponse> ListPoliciesGrantingServiceAccess(ListPoliciesGrantingServiceAccessRequest req)
        {
             JsonResponseModel<ListPoliciesGrantingServiceAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListPoliciesGrantingServiceAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPoliciesGrantingServiceAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有已授权服务
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesGrantingServiceAccessRequest"/></param>
        /// <returns><see cref="ListPoliciesGrantingServiceAccessResponse"/></returns>
        public ListPoliciesGrantingServiceAccessResponse ListPoliciesGrantingServiceAccessSync(ListPoliciesGrantingServiceAccessRequest req)
        {
             JsonResponseModel<ListPoliciesGrantingServiceAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListPoliciesGrantingServiceAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPoliciesGrantingServiceAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（ListPolicyVersions）用于获取策略版本列表
        /// </summary>
        /// <param name="req"><see cref="ListPolicyVersionsRequest"/></param>
        /// <returns><see cref="ListPolicyVersionsResponse"/></returns>
        public async Task<ListPolicyVersionsResponse> ListPolicyVersions(ListPolicyVersionsRequest req)
        {
             JsonResponseModel<ListPolicyVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListPolicyVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPolicyVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（ListPolicyVersions）用于获取策略版本列表
        /// </summary>
        /// <param name="req"><see cref="ListPolicyVersionsRequest"/></param>
        /// <returns><see cref="ListPolicyVersionsResponse"/></returns>
        public ListPolicyVersionsResponse ListPolicyVersionsSync(ListPolicyVersionsRequest req)
        {
             JsonResponseModel<ListPolicyVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListPolicyVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPolicyVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SAML身份提供商列表
        /// </summary>
        /// <param name="req"><see cref="ListSAMLProvidersRequest"/></param>
        /// <returns><see cref="ListSAMLProvidersResponse"/></returns>
        public async Task<ListSAMLProvidersResponse> ListSAMLProviders(ListSAMLProvidersRequest req)
        {
             JsonResponseModel<ListSAMLProvidersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSAMLProviders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSAMLProvidersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SAML身份提供商列表
        /// </summary>
        /// <param name="req"><see cref="ListSAMLProvidersRequest"/></param>
        /// <returns><see cref="ListSAMLProvidersResponse"/></returns>
        public ListSAMLProvidersResponse ListSAMLProvidersSync(ListSAMLProvidersRequest req)
        {
             JsonResponseModel<ListSAMLProvidersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSAMLProviders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSAMLProvidersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取子用户
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public async Task<ListUsersResponse> ListUsers(ListUsersRequest req)
        {
             JsonResponseModel<ListUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取子用户
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public ListUsersResponse ListUsersSync(ListUsersRequest req)
        {
             JsonResponseModel<ListUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组关联的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersForGroupRequest"/></param>
        /// <returns><see cref="ListUsersForGroupResponse"/></returns>
        public async Task<ListUsersForGroupResponse> ListUsersForGroup(ListUsersForGroupRequest req)
        {
             JsonResponseModel<ListUsersForGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUsersForGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersForGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组关联的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersForGroupRequest"/></param>
        /// <returns><see cref="ListUsersForGroupResponse"/></returns>
        public ListUsersForGroupResponse ListUsersForGroupSync(ListUsersForGroupRequest req)
        {
             JsonResponseModel<ListUsersForGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUsersForGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersForGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业微信子用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWeChatWorkSubAccountsRequest"/></param>
        /// <returns><see cref="ListWeChatWorkSubAccountsResponse"/></returns>
        public async Task<ListWeChatWorkSubAccountsResponse> ListWeChatWorkSubAccounts(ListWeChatWorkSubAccountsRequest req)
        {
             JsonResponseModel<ListWeChatWorkSubAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListWeChatWorkSubAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListWeChatWorkSubAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业微信子用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWeChatWorkSubAccountsRequest"/></param>
        /// <returns><see cref="ListWeChatWorkSubAccountsResponse"/></returns>
        public ListWeChatWorkSubAccountsResponse ListWeChatWorkSubAccountsSync(ListWeChatWorkSubAccountsRequest req)
        {
             JsonResponseModel<ListWeChatWorkSubAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListWeChatWorkSubAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListWeChatWorkSubAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置角色权限边界
        /// </summary>
        /// <param name="req"><see cref="PutRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutRolePermissionsBoundaryResponse"/></returns>
        public async Task<PutRolePermissionsBoundaryResponse> PutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest req)
        {
             JsonResponseModel<PutRolePermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutRolePermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutRolePermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置角色权限边界
        /// </summary>
        /// <param name="req"><see cref="PutRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutRolePermissionsBoundaryResponse"/></returns>
        public PutRolePermissionsBoundaryResponse PutRolePermissionsBoundarySync(PutRolePermissionsBoundaryRequest req)
        {
             JsonResponseModel<PutRolePermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutRolePermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutRolePermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置用户权限边界
        /// </summary>
        /// <param name="req"><see cref="PutUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutUserPermissionsBoundaryResponse"/></returns>
        public async Task<PutUserPermissionsBoundaryResponse> PutUserPermissionsBoundary(PutUserPermissionsBoundaryRequest req)
        {
             JsonResponseModel<PutUserPermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutUserPermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutUserPermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置用户权限边界
        /// </summary>
        /// <param name="req"><see cref="PutUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutUserPermissionsBoundaryResponse"/></returns>
        public PutUserPermissionsBoundaryResponse PutUserPermissionsBoundarySync(PutUserPermissionsBoundaryRequest req)
        {
             JsonResponseModel<PutUserPermissionsBoundaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutUserPermissionsBoundary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutUserPermissionsBoundaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从用户组删除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroup(RemoveUserFromGroupRequest req)
        {
             JsonResponseModel<RemoveUserFromGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveUserFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从用户组删除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroupSync(RemoveUserFromGroupRequest req)
        {
             JsonResponseModel<RemoveUserFromGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveUserFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetDefaultPolicyVersion）可用于设置生效的策略版本。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultPolicyVersionRequest"/></param>
        /// <returns><see cref="SetDefaultPolicyVersionResponse"/></returns>
        public async Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest req)
        {
             JsonResponseModel<SetDefaultPolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetDefaultPolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDefaultPolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetDefaultPolicyVersion）可用于设置生效的策略版本。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultPolicyVersionRequest"/></param>
        /// <returns><see cref="SetDefaultPolicyVersionResponse"/></returns>
        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersionSync(SetDefaultPolicyVersionRequest req)
        {
             JsonResponseModel<SetDefaultPolicyVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetDefaultPolicyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDefaultPolicyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置子用户的登录保护和敏感操作校验方式
        /// </summary>
        /// <param name="req"><see cref="SetMfaFlagRequest"/></param>
        /// <returns><see cref="SetMfaFlagResponse"/></returns>
        public async Task<SetMfaFlagResponse> SetMfaFlag(SetMfaFlagRequest req)
        {
             JsonResponseModel<SetMfaFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetMfaFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetMfaFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置子用户的登录保护和敏感操作校验方式
        /// </summary>
        /// <param name="req"><see cref="SetMfaFlagRequest"/></param>
        /// <returns><see cref="SetMfaFlagResponse"/></returns>
        public SetMfaFlagResponse SetMfaFlagSync(SetMfaFlagRequest req)
        {
             JsonResponseModel<SetMfaFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetMfaFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetMfaFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateAssumeRolePolicy）用于修改角色信任策略的策略文档。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssumeRolePolicyRequest"/></param>
        /// <returns><see cref="UpdateAssumeRolePolicyResponse"/></returns>
        public async Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest req)
        {
             JsonResponseModel<UpdateAssumeRolePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAssumeRolePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAssumeRolePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateAssumeRolePolicy）用于修改角色信任策略的策略文档。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssumeRolePolicyRequest"/></param>
        /// <returns><see cref="UpdateAssumeRolePolicyResponse"/></returns>
        public UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicySync(UpdateAssumeRolePolicyRequest req)
        {
             JsonResponseModel<UpdateAssumeRolePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAssumeRolePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAssumeRolePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public async Task<UpdateGroupResponse> UpdateGroup(UpdateGroupRequest req)
        {
             JsonResponseModel<UpdateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public UpdateGroupResponse UpdateGroupSync(UpdateGroupRequest req)
        {
             JsonResponseModel<UpdateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdatePolicy ）可用于更新策略。
        /// 如果已存在策略版本，本接口会直接更新策略的默认版本，不会创建新版本，如果不存在任何策略版本，则直接创建一个默认版本。
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public async Task<UpdatePolicyResponse> UpdatePolicy(UpdatePolicyRequest req)
        {
             JsonResponseModel<UpdatePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdatePolicy ）可用于更新策略。
        /// 如果已存在策略版本，本接口会直接更新策略的默认版本，不会创建新版本，如果不存在任何策略版本，则直接创建一个默认版本。
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public UpdatePolicyResponse UpdatePolicySync(UpdatePolicyRequest req)
        {
             JsonResponseModel<UpdatePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateRoleConsoleLogin）用于修改角色是否可登录。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConsoleLoginRequest"/></param>
        /// <returns><see cref="UpdateRoleConsoleLoginResponse"/></returns>
        public async Task<UpdateRoleConsoleLoginResponse> UpdateRoleConsoleLogin(UpdateRoleConsoleLoginRequest req)
        {
             JsonResponseModel<UpdateRoleConsoleLoginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRoleConsoleLogin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRoleConsoleLoginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateRoleConsoleLogin）用于修改角色是否可登录。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConsoleLoginRequest"/></param>
        /// <returns><see cref="UpdateRoleConsoleLoginResponse"/></returns>
        public UpdateRoleConsoleLoginResponse UpdateRoleConsoleLoginSync(UpdateRoleConsoleLoginRequest req)
        {
             JsonResponseModel<UpdateRoleConsoleLoginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRoleConsoleLogin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRoleConsoleLoginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateRoleDescription）用于修改角色的描述信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleDescriptionRequest"/></param>
        /// <returns><see cref="UpdateRoleDescriptionResponse"/></returns>
        public async Task<UpdateRoleDescriptionResponse> UpdateRoleDescription(UpdateRoleDescriptionRequest req)
        {
             JsonResponseModel<UpdateRoleDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRoleDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRoleDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateRoleDescription）用于修改角色的描述信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleDescriptionRequest"/></param>
        /// <returns><see cref="UpdateRoleDescriptionResponse"/></returns>
        public UpdateRoleDescriptionResponse UpdateRoleDescriptionSync(UpdateRoleDescriptionRequest req)
        {
             JsonResponseModel<UpdateRoleDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRoleDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRoleDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新SAML身份提供商信息
        /// </summary>
        /// <param name="req"><see cref="UpdateSAMLProviderRequest"/></param>
        /// <returns><see cref="UpdateSAMLProviderResponse"/></returns>
        public async Task<UpdateSAMLProviderResponse> UpdateSAMLProvider(UpdateSAMLProviderRequest req)
        {
             JsonResponseModel<UpdateSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新SAML身份提供商信息
        /// </summary>
        /// <param name="req"><see cref="UpdateSAMLProviderRequest"/></param>
        /// <returns><see cref="UpdateSAMLProviderResponse"/></returns>
        public UpdateSAMLProviderResponse UpdateSAMLProviderSync(UpdateSAMLProviderRequest req)
        {
             JsonResponseModel<UpdateSAMLProviderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateSAMLProvider");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSAMLProviderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新子用户
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public async Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
             JsonResponseModel<UpdateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新子用户
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
             JsonResponseModel<UpdateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="UpdateUserSAMLConfigResponse"/></returns>
        public async Task<UpdateUserSAMLConfigResponse> UpdateUserSAMLConfig(UpdateUserSAMLConfigRequest req)
        {
             JsonResponseModel<UpdateUserSAMLConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateUserSAMLConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserSAMLConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="UpdateUserSAMLConfigResponse"/></returns>
        public UpdateUserSAMLConfigResponse UpdateUserSAMLConfigSync(UpdateUserSAMLConfigRequest req)
        {
             JsonResponseModel<UpdateUserSAMLConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateUserSAMLConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserSAMLConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
