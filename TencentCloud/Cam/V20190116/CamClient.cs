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
        /// mfa校验
        /// </summary>
        /// <param name="req"><see cref="CheckRequest"/></param>
        /// <returns><see cref="CheckResponse"/></returns>
        public async Task<CheckResponse> Check(CheckRequest req)
        {
             JsonResponseModel<CheckResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Check");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// mfa校验
        /// </summary>
        /// <param name="req"><see cref="CheckRequest"/></param>
        /// <returns><see cref="CheckResponse"/></returns>
        public CheckResponse CheckSync(CheckRequest req)
        {
             JsonResponseModel<CheckResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Check");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验新手机新邮箱接口
        /// </summary>
        /// <param name="req"><see cref="CheckNewMfaCodeRequest"/></param>
        /// <returns><see cref="CheckNewMfaCodeResponse"/></returns>
        public async Task<CheckNewMfaCodeResponse> CheckNewMfaCode(CheckNewMfaCodeRequest req)
        {
             JsonResponseModel<CheckNewMfaCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckNewMfaCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNewMfaCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验新手机新邮箱接口
        /// </summary>
        /// <param name="req"><see cref="CheckNewMfaCodeRequest"/></param>
        /// <returns><see cref="CheckNewMfaCodeResponse"/></returns>
        public CheckNewMfaCodeResponse CheckNewMfaCodeSync(CheckNewMfaCodeRequest req)
        {
             JsonResponseModel<CheckNewMfaCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckNewMfaCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNewMfaCodeResponse>>(strResp);
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
        /// 查询mfa设备
        /// </summary>
        /// <param name="req"><see cref="DescribeMFADeviceCollRequest"/></param>
        /// <returns><see cref="DescribeMFADeviceCollResponse"/></returns>
        public async Task<DescribeMFADeviceCollResponse> DescribeMFADeviceColl(DescribeMFADeviceCollRequest req)
        {
             JsonResponseModel<DescribeMFADeviceCollResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMFADeviceColl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMFADeviceCollResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询mfa设备
        /// </summary>
        /// <param name="req"><see cref="DescribeMFADeviceCollRequest"/></param>
        /// <returns><see cref="DescribeMFADeviceCollResponse"/></returns>
        public DescribeMFADeviceCollResponse DescribeMFADeviceCollSync(DescribeMFADeviceCollRequest req)
        {
             JsonResponseModel<DescribeMFADeviceCollResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMFADeviceColl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMFADeviceCollResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信code状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMfaCodeStatusRequest"/></param>
        /// <returns><see cref="DescribeMfaCodeStatusResponse"/></returns>
        public async Task<DescribeMfaCodeStatusResponse> DescribeMfaCodeStatus(DescribeMfaCodeStatusRequest req)
        {
             JsonResponseModel<DescribeMfaCodeStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMfaCodeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMfaCodeStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信code状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMfaCodeStatusRequest"/></param>
        /// <returns><see cref="DescribeMfaCodeStatusResponse"/></returns>
        public DescribeMfaCodeStatusResponse DescribeMfaCodeStatusSync(DescribeMfaCodeStatusRequest req)
        {
             JsonResponseModel<DescribeMfaCodeStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMfaCodeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMfaCodeStatusResponse>>(strResp);
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
        /// 发起人脸核身
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
        public async Task<DetectAuthResponse> DetectAuth(DetectAuthRequest req)
        {
             JsonResponseModel<DetectAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起人脸核身
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
        public DetectAuthResponse DetectAuthSync(DetectAuthRequest req)
        {
             JsonResponseModel<DetectAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取并更新人脸核身校验状态实名传递参数比对
        /// </summary>
        /// <param name="req"><see cref="DetectMaskAuthRequest"/></param>
        /// <returns><see cref="DetectMaskAuthResponse"/></returns>
        public async Task<DetectMaskAuthResponse> DetectMaskAuth(DetectMaskAuthRequest req)
        {
             JsonResponseModel<DetectMaskAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectMaskAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectMaskAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取并更新人脸核身校验状态实名传递参数比对
        /// </summary>
        /// <param name="req"><see cref="DetectMaskAuthRequest"/></param>
        /// <returns><see cref="DetectMaskAuthResponse"/></returns>
        public DetectMaskAuthResponse DetectMaskAuthSync(DetectMaskAuthRequest req)
        {
             JsonResponseModel<DetectMaskAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectMaskAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectMaskAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取并且更新人联合身状态
        /// </summary>
        /// <param name="req"><see cref="DetectStateRequest"/></param>
        /// <returns><see cref="DetectStateResponse"/></returns>
        public async Task<DetectStateResponse> DetectState(DetectStateRequest req)
        {
             JsonResponseModel<DetectStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取并且更新人联合身状态
        /// </summary>
        /// <param name="req"><see cref="DetectStateRequest"/></param>
        /// <returns><see cref="DetectStateResponse"/></returns>
        public DetectStateResponse DetectStateSync(DetectStateRequest req)
        {
             JsonResponseModel<DetectStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectStateResponse>>(strResp);
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
        /// 本接口（ListPolicies）可用于查询策略列表
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
        /// 本接口（ListPolicies）可用于查询策略列表
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
        /// 设置用户的登录保护和敏感操作校验方式
        /// </summary>
        /// <param name="req"><see cref="SetFlagRequest"/></param>
        /// <returns><see cref="SetFlagResponse"/></returns>
        public async Task<SetFlagResponse> SetFlag(SetFlagRequest req)
        {
             JsonResponseModel<SetFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置用户的登录保护和敏感操作校验方式
        /// </summary>
        /// <param name="req"><see cref="SetFlagRequest"/></param>
        /// <returns><see cref="SetFlagResponse"/></returns>
        public SetFlagResponse SetFlagSync(SetFlagRequest req)
        {
             JsonResponseModel<SetFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetFlagResponse>>(strResp);
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

    }
}
