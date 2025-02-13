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
       private const string sdkVersion = "SDK_NET_3.0.1180";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建子用户
        /// </summary>
        /// <param name="req"><see cref="AddUserRequest"/></param>
        /// <returns><see cref="AddUserResponse"/></returns>
        public Task<AddUserResponse> AddUser(AddUserRequest req)
        {
            return InternalRequestAsync<AddUserResponse>(req, "AddUser");
        }

        /// <summary>
        /// 创建子用户
        /// </summary>
        /// <param name="req"><see cref="AddUserRequest"/></param>
        /// <returns><see cref="AddUserResponse"/></returns>
        public AddUserResponse AddUserSync(AddUserRequest req)
        {
            return InternalRequestAsync<AddUserResponse>(req, "AddUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户加入到用户组
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public Task<AddUserToGroupResponse> AddUserToGroup(AddUserToGroupRequest req)
        {
            return InternalRequestAsync<AddUserToGroupResponse>(req, "AddUserToGroup");
        }

        /// <summary>
        /// 用户加入到用户组
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public AddUserToGroupResponse AddUserToGroupSync(AddUserToGroupRequest req)
        {
            return InternalRequestAsync<AddUserToGroupResponse>(req, "AddUserToGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachGroupPolicy）可用于绑定策略到用户组。
        /// </summary>
        /// <param name="req"><see cref="AttachGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachGroupPolicyResponse"/></returns>
        public Task<AttachGroupPolicyResponse> AttachGroupPolicy(AttachGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachGroupPolicyResponse>(req, "AttachGroupPolicy");
        }

        /// <summary>
        /// 本接口（AttachGroupPolicy）可用于绑定策略到用户组。
        /// </summary>
        /// <param name="req"><see cref="AttachGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachGroupPolicyResponse"/></returns>
        public AttachGroupPolicyResponse AttachGroupPolicySync(AttachGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachGroupPolicyResponse>(req, "AttachGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachRolePolicy）用于绑定策略到角色。
        /// </summary>
        /// <param name="req"><see cref="AttachRolePolicyRequest"/></param>
        /// <returns><see cref="AttachRolePolicyResponse"/></returns>
        public Task<AttachRolePolicyResponse> AttachRolePolicy(AttachRolePolicyRequest req)
        {
            return InternalRequestAsync<AttachRolePolicyResponse>(req, "AttachRolePolicy");
        }

        /// <summary>
        /// 本接口（AttachRolePolicy）用于绑定策略到角色。
        /// </summary>
        /// <param name="req"><see cref="AttachRolePolicyRequest"/></param>
        /// <returns><see cref="AttachRolePolicyResponse"/></returns>
        public AttachRolePolicyResponse AttachRolePolicySync(AttachRolePolicyRequest req)
        {
            return InternalRequestAsync<AttachRolePolicyResponse>(req, "AttachRolePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachUserPolicy）可用于绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public Task<AttachUserPolicyResponse> AttachUserPolicy(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy");
        }

        /// <summary>
        /// 本接口（AttachUserPolicy）可用于绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public AttachUserPolicyResponse AttachUserPolicySync(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据流认证Token
        /// </summary>
        /// <param name="req"><see cref="BuildDataFlowAuthTokenRequest"/></param>
        /// <returns><see cref="BuildDataFlowAuthTokenResponse"/></returns>
        public Task<BuildDataFlowAuthTokenResponse> BuildDataFlowAuthToken(BuildDataFlowAuthTokenRequest req)
        {
            return InternalRequestAsync<BuildDataFlowAuthTokenResponse>(req, "BuildDataFlowAuthToken");
        }

        /// <summary>
        /// 获取数据流认证Token
        /// </summary>
        /// <param name="req"><see cref="BuildDataFlowAuthTokenRequest"/></param>
        /// <returns><see cref="BuildDataFlowAuthTokenResponse"/></returns>
        public BuildDataFlowAuthTokenResponse BuildDataFlowAuthTokenSync(BuildDataFlowAuthTokenRequest req)
        {
            return InternalRequestAsync<BuildDataFlowAuthTokenResponse>(req, "BuildDataFlowAuthToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证自定义多因子Token
        /// </summary>
        /// <param name="req"><see cref="ConsumeCustomMFATokenRequest"/></param>
        /// <returns><see cref="ConsumeCustomMFATokenResponse"/></returns>
        public Task<ConsumeCustomMFATokenResponse> ConsumeCustomMFAToken(ConsumeCustomMFATokenRequest req)
        {
            return InternalRequestAsync<ConsumeCustomMFATokenResponse>(req, "ConsumeCustomMFAToken");
        }

        /// <summary>
        /// 验证自定义多因子Token
        /// </summary>
        /// <param name="req"><see cref="ConsumeCustomMFATokenRequest"/></param>
        /// <returns><see cref="ConsumeCustomMFATokenResponse"/></returns>
        public ConsumeCustomMFATokenResponse ConsumeCustomMFATokenSync(ConsumeCustomMFATokenRequest req)
        {
            return InternalRequestAsync<ConsumeCustomMFATokenResponse>(req, "ConsumeCustomMFAToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为CAM用户创建访问密钥
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyRequest"/></param>
        /// <returns><see cref="CreateAccessKeyResponse"/></returns>
        public Task<CreateAccessKeyResponse> CreateAccessKey(CreateAccessKeyRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyResponse>(req, "CreateAccessKey");
        }

        /// <summary>
        /// 为CAM用户创建访问密钥
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyRequest"/></param>
        /// <returns><see cref="CreateAccessKeyResponse"/></returns>
        public CreateAccessKeyResponse CreateAccessKeySync(CreateAccessKeyRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyResponse>(req, "CreateAccessKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup");
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建消息接收人接口：仅允许已完成实名认证的用户访问消息接收人接口，并对每个用户限制每天最多请求10次。
        /// </summary>
        /// <param name="req"><see cref="CreateMessageReceiverRequest"/></param>
        /// <returns><see cref="CreateMessageReceiverResponse"/></returns>
        public Task<CreateMessageReceiverResponse> CreateMessageReceiver(CreateMessageReceiverRequest req)
        {
            return InternalRequestAsync<CreateMessageReceiverResponse>(req, "CreateMessageReceiver");
        }

        /// <summary>
        /// 创建消息接收人接口：仅允许已完成实名认证的用户访问消息接收人接口，并对每个用户限制每天最多请求10次。
        /// </summary>
        /// <param name="req"><see cref="CreateMessageReceiverRequest"/></param>
        /// <returns><see cref="CreateMessageReceiverResponse"/></returns>
        public CreateMessageReceiverResponse CreateMessageReceiverSync(CreateMessageReceiverRequest req)
        {
            return InternalRequestAsync<CreateMessageReceiverResponse>(req, "CreateMessageReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建角色OIDC配置
        /// </summary>
        /// <param name="req"><see cref="CreateOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateOIDCConfigResponse"/></returns>
        public Task<CreateOIDCConfigResponse> CreateOIDCConfig(CreateOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateOIDCConfigResponse>(req, "CreateOIDCConfig");
        }

        /// <summary>
        /// 创建角色OIDC配置
        /// </summary>
        /// <param name="req"><see cref="CreateOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateOIDCConfigResponse"/></returns>
        public CreateOIDCConfigResponse CreateOIDCConfigSync(CreateOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateOIDCConfigResponse>(req, "CreateOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreatePolicy）可用于创建策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public Task<CreatePolicyResponse> CreatePolicy(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy");
        }

        /// <summary>
        /// 本接口（CreatePolicy）可用于创建策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public CreatePolicyResponse CreatePolicySync(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreatePolicyVersion）用于新增策略版本，用户创建了一个策略版本之后可以方便的通过变更策略版本的方式来变更策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyVersionRequest"/></param>
        /// <returns><see cref="CreatePolicyVersionResponse"/></returns>
        public Task<CreatePolicyVersionResponse> CreatePolicyVersion(CreatePolicyVersionRequest req)
        {
            return InternalRequestAsync<CreatePolicyVersionResponse>(req, "CreatePolicyVersion");
        }

        /// <summary>
        /// 该接口（CreatePolicyVersion）用于新增策略版本，用户创建了一个策略版本之后可以方便的通过变更策略版本的方式来变更策略。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyVersionRequest"/></param>
        /// <returns><see cref="CreatePolicyVersionResponse"/></returns>
        public CreatePolicyVersionResponse CreatePolicyVersionSync(CreatePolicyVersionRequest req)
        {
            return InternalRequestAsync<CreatePolicyVersionResponse>(req, "CreatePolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateRole）用于创建角色。
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole");
        }

        /// <summary>
        /// 本接口（CreateRole）用于创建角色。
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="CreateSAMLProviderRequest"/></param>
        /// <returns><see cref="CreateSAMLProviderResponse"/></returns>
        public Task<CreateSAMLProviderResponse> CreateSAMLProvider(CreateSAMLProviderRequest req)
        {
            return InternalRequestAsync<CreateSAMLProviderResponse>(req, "CreateSAMLProvider");
        }

        /// <summary>
        /// 创建SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="CreateSAMLProviderRequest"/></param>
        /// <returns><see cref="CreateSAMLProviderResponse"/></returns>
        public CreateSAMLProviderResponse CreateSAMLProviderSync(CreateSAMLProviderRequest req)
        {
            return InternalRequestAsync<CreateSAMLProviderResponse>(req, "CreateSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建服务相关角色
        /// </summary>
        /// <param name="req"><see cref="CreateServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="CreateServiceLinkedRoleResponse"/></returns>
        public Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRole(CreateServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<CreateServiceLinkedRoleResponse>(req, "CreateServiceLinkedRole");
        }

        /// <summary>
        /// 创建服务相关角色
        /// </summary>
        /// <param name="req"><see cref="CreateServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="CreateServiceLinkedRoleResponse"/></returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleSync(CreateServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<CreateServiceLinkedRoleResponse>(req, "CreateServiceLinkedRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户OIDC配置。只能创建一个用户OIDC身份提供商，并且创建用户OIDC配置之后会自动关闭用户SAML SSO身份提供商。
        /// </summary>
        /// <param name="req"><see cref="CreateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateUserOIDCConfigResponse"/></returns>
        public Task<CreateUserOIDCConfigResponse> CreateUserOIDCConfig(CreateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateUserOIDCConfigResponse>(req, "CreateUserOIDCConfig");
        }

        /// <summary>
        /// 创建用户OIDC配置。只能创建一个用户OIDC身份提供商，并且创建用户OIDC配置之后会自动关闭用户SAML SSO身份提供商。
        /// </summary>
        /// <param name="req"><see cref="CreateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateUserOIDCConfigResponse"/></returns>
        public CreateUserOIDCConfigResponse CreateUserOIDCConfigSync(CreateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateUserOIDCConfigResponse>(req, "CreateUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="CreateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="CreateUserSAMLConfigResponse"/></returns>
        public Task<CreateUserSAMLConfigResponse> CreateUserSAMLConfig(CreateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<CreateUserSAMLConfigResponse>(req, "CreateUserSAMLConfig");
        }

        /// <summary>
        /// 创建用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="CreateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="CreateUserSAMLConfigResponse"/></returns>
        public CreateUserSAMLConfigResponse CreateUserSAMLConfigSync(CreateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<CreateUserSAMLConfigResponse>(req, "CreateUserSAMLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为CAM用户删除访问密钥。
        /// 此接口属于高风险操作，删除密钥后不可恢复，腾讯云将永久拒绝此密钥的所有请求，请谨慎使用。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessKeyRequest"/></param>
        /// <returns><see cref="DeleteAccessKeyResponse"/></returns>
        public Task<DeleteAccessKeyResponse> DeleteAccessKey(DeleteAccessKeyRequest req)
        {
            return InternalRequestAsync<DeleteAccessKeyResponse>(req, "DeleteAccessKey");
        }

        /// <summary>
        /// 为CAM用户删除访问密钥。
        /// 此接口属于高风险操作，删除密钥后不可恢复，腾讯云将永久拒绝此密钥的所有请求，请谨慎使用。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessKeyRequest"/></param>
        /// <returns><see cref="DeleteAccessKeyResponse"/></returns>
        public DeleteAccessKeyResponse DeleteAccessKeySync(DeleteAccessKeyRequest req)
        {
            return InternalRequestAsync<DeleteAccessKeyResponse>(req, "DeleteAccessKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除消息接收人
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageReceiverRequest"/></param>
        /// <returns><see cref="DeleteMessageReceiverResponse"/></returns>
        public Task<DeleteMessageReceiverResponse> DeleteMessageReceiver(DeleteMessageReceiverRequest req)
        {
            return InternalRequestAsync<DeleteMessageReceiverResponse>(req, "DeleteMessageReceiver");
        }

        /// <summary>
        /// 删除消息接收人
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageReceiverRequest"/></param>
        /// <returns><see cref="DeleteMessageReceiverResponse"/></returns>
        public DeleteMessageReceiverResponse DeleteMessageReceiverSync(DeleteMessageReceiverRequest req)
        {
            return InternalRequestAsync<DeleteMessageReceiverResponse>(req, "DeleteMessageReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除OIDC身份提供商
        /// </summary>
        /// <param name="req"><see cref="DeleteOIDCConfigRequest"/></param>
        /// <returns><see cref="DeleteOIDCConfigResponse"/></returns>
        public Task<DeleteOIDCConfigResponse> DeleteOIDCConfig(DeleteOIDCConfigRequest req)
        {
            return InternalRequestAsync<DeleteOIDCConfigResponse>(req, "DeleteOIDCConfig");
        }

        /// <summary>
        /// 删除OIDC身份提供商
        /// </summary>
        /// <param name="req"><see cref="DeleteOIDCConfigRequest"/></param>
        /// <returns><see cref="DeleteOIDCConfigResponse"/></returns>
        public DeleteOIDCConfigResponse DeleteOIDCConfigSync(DeleteOIDCConfigRequest req)
        {
            return InternalRequestAsync<DeleteOIDCConfigResponse>(req, "DeleteOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeletePolicy）可用于删除策略。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public Task<DeletePolicyResponse> DeletePolicy(DeletePolicyRequest req)
        {
            return InternalRequestAsync<DeletePolicyResponse>(req, "DeletePolicy");
        }

        /// <summary>
        /// 本接口（DeletePolicy）可用于删除策略。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public DeletePolicyResponse DeletePolicySync(DeletePolicyRequest req)
        {
            return InternalRequestAsync<DeletePolicyResponse>(req, "DeletePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeletePolicyVersion）可用于删除一个策略的策略版本。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyVersionRequest"/></param>
        /// <returns><see cref="DeletePolicyVersionResponse"/></returns>
        public Task<DeletePolicyVersionResponse> DeletePolicyVersion(DeletePolicyVersionRequest req)
        {
            return InternalRequestAsync<DeletePolicyVersionResponse>(req, "DeletePolicyVersion");
        }

        /// <summary>
        /// 本接口（DeletePolicyVersion）可用于删除一个策略的策略版本。
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyVersionRequest"/></param>
        /// <returns><see cref="DeletePolicyVersionResponse"/></returns>
        public DeletePolicyVersionResponse DeletePolicyVersionSync(DeletePolicyVersionRequest req)
        {
            return InternalRequestAsync<DeletePolicyVersionResponse>(req, "DeletePolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteRole）用于删除指定角色。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public Task<DeleteRoleResponse> DeleteRole(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole");
        }

        /// <summary>
        /// 本接口（DeleteRole）用于删除指定角色。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public DeleteRoleResponse DeleteRoleSync(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除角色权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteRolePermissionsBoundaryResponse"/></returns>
        public Task<DeleteRolePermissionsBoundaryResponse> DeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteRolePermissionsBoundaryResponse>(req, "DeleteRolePermissionsBoundary");
        }

        /// <summary>
        /// 删除角色权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteRolePermissionsBoundaryResponse"/></returns>
        public DeleteRolePermissionsBoundaryResponse DeleteRolePermissionsBoundarySync(DeleteRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteRolePermissionsBoundaryResponse>(req, "DeleteRolePermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="DeleteSAMLProviderRequest"/></param>
        /// <returns><see cref="DeleteSAMLProviderResponse"/></returns>
        public Task<DeleteSAMLProviderResponse> DeleteSAMLProvider(DeleteSAMLProviderRequest req)
        {
            return InternalRequestAsync<DeleteSAMLProviderResponse>(req, "DeleteSAMLProvider");
        }

        /// <summary>
        /// 删除SAML身份提供商
        /// </summary>
        /// <param name="req"><see cref="DeleteSAMLProviderRequest"/></param>
        /// <returns><see cref="DeleteSAMLProviderResponse"/></returns>
        public DeleteSAMLProviderResponse DeleteSAMLProviderSync(DeleteSAMLProviderRequest req)
        {
            return InternalRequestAsync<DeleteSAMLProviderResponse>(req, "DeleteSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除服务相关角色
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="DeleteServiceLinkedRoleResponse"/></returns>
        public Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<DeleteServiceLinkedRoleResponse>(req, "DeleteServiceLinkedRole");
        }

        /// <summary>
        /// 删除服务相关角色
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="DeleteServiceLinkedRoleResponse"/></returns>
        public DeleteServiceLinkedRoleResponse DeleteServiceLinkedRoleSync(DeleteServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<DeleteServiceLinkedRoleResponse>(req, "DeleteServiceLinkedRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除子用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// 删除子用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteUserPermissionsBoundaryResponse"/></returns>
        public Task<DeleteUserPermissionsBoundaryResponse> DeleteUserPermissionsBoundary(DeleteUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteUserPermissionsBoundaryResponse>(req, "DeleteUserPermissionsBoundary");
        }

        /// <summary>
        /// 删除用户权限边界
        /// </summary>
        /// <param name="req"><see cref="DeleteUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteUserPermissionsBoundaryResponse"/></returns>
        public DeleteUserPermissionsBoundaryResponse DeleteUserPermissionsBoundarySync(DeleteUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteUserPermissionsBoundaryResponse>(req, "DeleteUserPermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询角色OIDC配置
        /// </summary>
        /// <param name="req"><see cref="DescribeOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeOIDCConfigResponse"/></returns>
        public Task<DescribeOIDCConfigResponse> DescribeOIDCConfig(DescribeOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeOIDCConfigResponse>(req, "DescribeOIDCConfig");
        }

        /// <summary>
        /// 查询角色OIDC配置
        /// </summary>
        /// <param name="req"><see cref="DescribeOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeOIDCConfigResponse"/></returns>
        public DescribeOIDCConfigResponse DescribeOIDCConfigSync(DescribeOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeOIDCConfigResponse>(req, "DescribeOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRoleList）用于获取账号下的角色列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList");
        }

        /// <summary>
        /// 本接口（DescribeRoleList）用于获取账号下的角色列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagResponse"/></returns>
        public Task<DescribeSafeAuthFlagResponse> DescribeSafeAuthFlag(DescribeSafeAuthFlagRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagResponse>(req, "DescribeSafeAuthFlag");
        }

        /// <summary>
        /// 查询用户安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagResponse"/></returns>
        public DescribeSafeAuthFlagResponse DescribeSafeAuthFlagSync(DescribeSafeAuthFlagRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagResponse>(req, "DescribeSafeAuthFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取子账号安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagCollRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagCollResponse"/></returns>
        public Task<DescribeSafeAuthFlagCollResponse> DescribeSafeAuthFlagColl(DescribeSafeAuthFlagCollRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagCollResponse>(req, "DescribeSafeAuthFlagColl");
        }

        /// <summary>
        /// 获取子账号安全设置
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagCollRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagCollResponse"/></returns>
        public DescribeSafeAuthFlagCollResponse DescribeSafeAuthFlagCollSync(DescribeSafeAuthFlagCollRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagCollResponse>(req, "DescribeSafeAuthFlagColl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全设置(国际站)
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagIntlRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagIntlResponse"/></returns>
        public Task<DescribeSafeAuthFlagIntlResponse> DescribeSafeAuthFlagIntl(DescribeSafeAuthFlagIntlRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagIntlResponse>(req, "DescribeSafeAuthFlagIntl");
        }

        /// <summary>
        /// 查询安全设置(国际站)
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagIntlRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagIntlResponse"/></returns>
        public DescribeSafeAuthFlagIntlResponse DescribeSafeAuthFlagIntlSync(DescribeSafeAuthFlagIntlRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagIntlResponse>(req, "DescribeSafeAuthFlagIntl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过子用户UIN列表查询子用户
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountsRequest"/></param>
        /// <returns><see cref="DescribeSubAccountsResponse"/></returns>
        public Task<DescribeSubAccountsResponse> DescribeSubAccounts(DescribeSubAccountsRequest req)
        {
            return InternalRequestAsync<DescribeSubAccountsResponse>(req, "DescribeSubAccounts");
        }

        /// <summary>
        /// 通过子用户UIN列表查询子用户
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountsRequest"/></param>
        /// <returns><see cref="DescribeSubAccountsResponse"/></returns>
        public DescribeSubAccountsResponse DescribeSubAccountsSync(DescribeSubAccountsRequest req)
        {
            return InternalRequestAsync<DescribeSubAccountsResponse>(req, "DescribeSubAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeUserOIDCConfigResponse"/></returns>
        public Task<DescribeUserOIDCConfigResponse> DescribeUserOIDCConfig(DescribeUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserOIDCConfigResponse>(req, "DescribeUserOIDCConfig");
        }

        /// <summary>
        /// 查询用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeUserOIDCConfigResponse"/></returns>
        public DescribeUserOIDCConfigResponse DescribeUserOIDCConfigSync(DescribeUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserOIDCConfigResponse>(req, "DescribeUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSAMLConfigRequest"/></param>
        /// <returns><see cref="DescribeUserSAMLConfigResponse"/></returns>
        public Task<DescribeUserSAMLConfigResponse> DescribeUserSAMLConfig(DescribeUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserSAMLConfigResponse>(req, "DescribeUserSAMLConfig");
        }

        /// <summary>
        /// 查询用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSAMLConfigRequest"/></param>
        /// <returns><see cref="DescribeUserSAMLConfigResponse"/></returns>
        public DescribeUserSAMLConfigResponse DescribeUserSAMLConfigSync(DescribeUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserSAMLConfigResponse>(req, "DescribeUserSAMLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachGroupPolicy）可用于解除绑定到用户组的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachGroupPolicyResponse"/></returns>
        public Task<DetachGroupPolicyResponse> DetachGroupPolicy(DetachGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachGroupPolicyResponse>(req, "DetachGroupPolicy");
        }

        /// <summary>
        /// 本接口（DetachGroupPolicy）可用于解除绑定到用户组的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachGroupPolicyResponse"/></returns>
        public DetachGroupPolicyResponse DetachGroupPolicySync(DetachGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachGroupPolicyResponse>(req, "DetachGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachRolePolicy）用于解除绑定角色的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachRolePolicyRequest"/></param>
        /// <returns><see cref="DetachRolePolicyResponse"/></returns>
        public Task<DetachRolePolicyResponse> DetachRolePolicy(DetachRolePolicyRequest req)
        {
            return InternalRequestAsync<DetachRolePolicyResponse>(req, "DetachRolePolicy");
        }

        /// <summary>
        /// 本接口（DetachRolePolicy）用于解除绑定角色的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachRolePolicyRequest"/></param>
        /// <returns><see cref="DetachRolePolicyResponse"/></returns>
        public DetachRolePolicyResponse DetachRolePolicySync(DetachRolePolicyRequest req)
        {
            return InternalRequestAsync<DetachRolePolicyResponse>(req, "DetachRolePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachUserPolicy）可用于解除绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public Task<DetachUserPolicyResponse> DetachUserPolicy(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy");
        }

        /// <summary>
        /// 本接口（DetachUserPolicy）可用于解除绑定到用户的策略。
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public DetachUserPolicyResponse DetachUserPolicySync(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用用户SSO
        /// </summary>
        /// <param name="req"><see cref="DisableUserSSORequest"/></param>
        /// <returns><see cref="DisableUserSSOResponse"/></returns>
        public Task<DisableUserSSOResponse> DisableUserSSO(DisableUserSSORequest req)
        {
            return InternalRequestAsync<DisableUserSSOResponse>(req, "DisableUserSSO");
        }

        /// <summary>
        /// 禁用用户SSO
        /// </summary>
        /// <param name="req"><see cref="DisableUserSSORequest"/></param>
        /// <returns><see cref="DisableUserSSOResponse"/></returns>
        public DisableUserSSOResponse DisableUserSSOSync(DisableUserSSORequest req)
        {
            return InternalRequestAsync<DisableUserSSOResponse>(req, "DisableUserSSO")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账户摘要
        /// </summary>
        /// <param name="req"><see cref="GetAccountSummaryRequest"/></param>
        /// <returns><see cref="GetAccountSummaryResponse"/></returns>
        public Task<GetAccountSummaryResponse> GetAccountSummary(GetAccountSummaryRequest req)
        {
            return InternalRequestAsync<GetAccountSummaryResponse>(req, "GetAccountSummary");
        }

        /// <summary>
        /// 查询账户摘要
        /// </summary>
        /// <param name="req"><see cref="GetAccountSummaryRequest"/></param>
        /// <returns><see cref="GetAccountSummaryResponse"/></returns>
        public GetAccountSummaryResponse GetAccountSummarySync(GetAccountSummaryRequest req)
        {
            return InternalRequestAsync<GetAccountSummaryResponse>(req, "GetAccountSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取自定义多因子Token关联信息
        /// </summary>
        /// <param name="req"><see cref="GetCustomMFATokenInfoRequest"/></param>
        /// <returns><see cref="GetCustomMFATokenInfoResponse"/></returns>
        public Task<GetCustomMFATokenInfoResponse> GetCustomMFATokenInfo(GetCustomMFATokenInfoRequest req)
        {
            return InternalRequestAsync<GetCustomMFATokenInfoResponse>(req, "GetCustomMFATokenInfo");
        }

        /// <summary>
        /// 获取自定义多因子Token关联信息
        /// </summary>
        /// <param name="req"><see cref="GetCustomMFATokenInfoRequest"/></param>
        /// <returns><see cref="GetCustomMFATokenInfoResponse"/></returns>
        public GetCustomMFATokenInfoResponse GetCustomMFATokenInfoSync(GetCustomMFATokenInfoRequest req)
        {
            return InternalRequestAsync<GetCustomMFATokenInfoResponse>(req, "GetCustomMFATokenInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组详情
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public Task<GetGroupResponse> GetGroup(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup");
        }

        /// <summary>
        /// 查询用户组详情
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public GetGroupResponse GetGroupSync(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetPolicy）可用于查询查看策略详情。
        /// </summary>
        /// <param name="req"><see cref="GetPolicyRequest"/></param>
        /// <returns><see cref="GetPolicyResponse"/></returns>
        public Task<GetPolicyResponse> GetPolicy(GetPolicyRequest req)
        {
            return InternalRequestAsync<GetPolicyResponse>(req, "GetPolicy");
        }

        /// <summary>
        /// 本接口（GetPolicy）可用于查询查看策略详情。
        /// </summary>
        /// <param name="req"><see cref="GetPolicyRequest"/></param>
        /// <returns><see cref="GetPolicyResponse"/></returns>
        public GetPolicyResponse GetPolicySync(GetPolicyRequest req)
        {
            return InternalRequestAsync<GetPolicyResponse>(req, "GetPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（GetPolicyVersion）用于查询策略版本详情
        /// </summary>
        /// <param name="req"><see cref="GetPolicyVersionRequest"/></param>
        /// <returns><see cref="GetPolicyVersionResponse"/></returns>
        public Task<GetPolicyVersionResponse> GetPolicyVersion(GetPolicyVersionRequest req)
        {
            return InternalRequestAsync<GetPolicyVersionResponse>(req, "GetPolicyVersion");
        }

        /// <summary>
        /// 该接口（GetPolicyVersion）用于查询策略版本详情
        /// </summary>
        /// <param name="req"><see cref="GetPolicyVersionRequest"/></param>
        /// <returns><see cref="GetPolicyVersionResponse"/></returns>
        public GetPolicyVersionResponse GetPolicyVersionSync(GetPolicyVersionRequest req)
        {
            return InternalRequestAsync<GetPolicyVersionResponse>(req, "GetPolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetRole）用于获取指定角色的详细信息。
        /// </summary>
        /// <param name="req"><see cref="GetRoleRequest"/></param>
        /// <returns><see cref="GetRoleResponse"/></returns>
        public Task<GetRoleResponse> GetRole(GetRoleRequest req)
        {
            return InternalRequestAsync<GetRoleResponse>(req, "GetRole");
        }

        /// <summary>
        /// 本接口（GetRole）用于获取指定角色的详细信息。
        /// </summary>
        /// <param name="req"><see cref="GetRoleRequest"/></param>
        /// <returns><see cref="GetRoleResponse"/></returns>
        public GetRoleResponse GetRoleSync(GetRoleRequest req)
        {
            return InternalRequestAsync<GetRoleResponse>(req, "GetRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取角色权限边界
        /// </summary>
        /// <param name="req"><see cref="GetRolePermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetRolePermissionBoundaryResponse"/></returns>
        public Task<GetRolePermissionBoundaryResponse> GetRolePermissionBoundary(GetRolePermissionBoundaryRequest req)
        {
            return InternalRequestAsync<GetRolePermissionBoundaryResponse>(req, "GetRolePermissionBoundary");
        }

        /// <summary>
        /// 获取角色权限边界
        /// </summary>
        /// <param name="req"><see cref="GetRolePermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetRolePermissionBoundaryResponse"/></returns>
        public GetRolePermissionBoundaryResponse GetRolePermissionBoundarySync(GetRolePermissionBoundaryRequest req)
        {
            return InternalRequestAsync<GetRolePermissionBoundaryResponse>(req, "GetRolePermissionBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SAML身份提供商详情
        /// </summary>
        /// <param name="req"><see cref="GetSAMLProviderRequest"/></param>
        /// <returns><see cref="GetSAMLProviderResponse"/></returns>
        public Task<GetSAMLProviderResponse> GetSAMLProvider(GetSAMLProviderRequest req)
        {
            return InternalRequestAsync<GetSAMLProviderResponse>(req, "GetSAMLProvider");
        }

        /// <summary>
        /// 查询SAML身份提供商详情
        /// </summary>
        /// <param name="req"><see cref="GetSAMLProviderRequest"/></param>
        /// <returns><see cref="GetSAMLProviderResponse"/></returns>
        public GetSAMLProviderResponse GetSAMLProviderSync(GetSAMLProviderRequest req)
        {
            return InternalRequestAsync<GetSAMLProviderResponse>(req, "GetSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取密钥最近使用情况
        /// </summary>
        /// <param name="req"><see cref="GetSecurityLastUsedRequest"/></param>
        /// <returns><see cref="GetSecurityLastUsedResponse"/></returns>
        public Task<GetSecurityLastUsedResponse> GetSecurityLastUsed(GetSecurityLastUsedRequest req)
        {
            return InternalRequestAsync<GetSecurityLastUsedResponse>(req, "GetSecurityLastUsed");
        }

        /// <summary>
        /// 获取密钥最近使用情况
        /// </summary>
        /// <param name="req"><see cref="GetSecurityLastUsedRequest"/></param>
        /// <returns><see cref="GetSecurityLastUsedResponse"/></returns>
        public GetSecurityLastUsedResponse GetSecurityLastUsedSync(GetSecurityLastUsedRequest req)
        {
            return InternalRequestAsync<GetSecurityLastUsedResponse>(req, "GetSecurityLastUsed")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据删除TaskId获取服务相关角色删除状态
        /// </summary>
        /// <param name="req"><see cref="GetServiceLinkedRoleDeletionStatusRequest"/></param>
        /// <returns><see cref="GetServiceLinkedRoleDeletionStatusResponse"/></returns>
        public Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest req)
        {
            return InternalRequestAsync<GetServiceLinkedRoleDeletionStatusResponse>(req, "GetServiceLinkedRoleDeletionStatus");
        }

        /// <summary>
        /// 根据删除TaskId获取服务相关角色删除状态
        /// </summary>
        /// <param name="req"><see cref="GetServiceLinkedRoleDeletionStatusRequest"/></param>
        /// <returns><see cref="GetServiceLinkedRoleDeletionStatusResponse"/></returns>
        public GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatusSync(GetServiceLinkedRoleDeletionStatusRequest req)
        {
            return InternalRequestAsync<GetServiceLinkedRoleDeletionStatusResponse>(req, "GetServiceLinkedRoleDeletionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询子用户
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public Task<GetUserResponse> GetUser(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser");
        }

        /// <summary>
        /// 查询子用户
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public GetUserResponse GetUserSync(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户AppId
        /// </summary>
        /// <param name="req"><see cref="GetUserAppIdRequest"/></param>
        /// <returns><see cref="GetUserAppIdResponse"/></returns>
        public Task<GetUserAppIdResponse> GetUserAppId(GetUserAppIdRequest req)
        {
            return InternalRequestAsync<GetUserAppIdResponse>(req, "GetUserAppId");
        }

        /// <summary>
        /// 获取用户AppId
        /// </summary>
        /// <param name="req"><see cref="GetUserAppIdRequest"/></param>
        /// <returns><see cref="GetUserAppIdResponse"/></returns>
        public GetUserAppIdResponse GetUserAppIdSync(GetUserAppIdRequest req)
        {
            return InternalRequestAsync<GetUserAppIdResponse>(req, "GetUserAppId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户权限边界
        /// </summary>
        /// <param name="req"><see cref="GetUserPermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetUserPermissionBoundaryResponse"/></returns>
        public Task<GetUserPermissionBoundaryResponse> GetUserPermissionBoundary(GetUserPermissionBoundaryRequest req)
        {
            return InternalRequestAsync<GetUserPermissionBoundaryResponse>(req, "GetUserPermissionBoundary");
        }

        /// <summary>
        /// 获取用户权限边界
        /// </summary>
        /// <param name="req"><see cref="GetUserPermissionBoundaryRequest"/></param>
        /// <returns><see cref="GetUserPermissionBoundaryResponse"/></returns>
        public GetUserPermissionBoundaryResponse GetUserPermissionBoundarySync(GetUserPermissionBoundaryRequest req)
        {
            return InternalRequestAsync<GetUserPermissionBoundaryResponse>(req, "GetUserPermissionBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出指定CAM用户的访问密钥
        /// </summary>
        /// <param name="req"><see cref="ListAccessKeysRequest"/></param>
        /// <returns><see cref="ListAccessKeysResponse"/></returns>
        public Task<ListAccessKeysResponse> ListAccessKeys(ListAccessKeysRequest req)
        {
            return InternalRequestAsync<ListAccessKeysResponse>(req, "ListAccessKeys");
        }

        /// <summary>
        /// 列出指定CAM用户的访问密钥
        /// </summary>
        /// <param name="req"><see cref="ListAccessKeysRequest"/></param>
        /// <returns><see cref="ListAccessKeysResponse"/></returns>
        public ListAccessKeysResponse ListAccessKeysSync(ListAccessKeysRequest req)
        {
            return InternalRequestAsync<ListAccessKeysResponse>(req, "ListAccessKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListAttachedGroupPolicies）可用于查询用户组关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedGroupPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedGroupPoliciesResponse"/></returns>
        public Task<ListAttachedGroupPoliciesResponse> ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedGroupPoliciesResponse>(req, "ListAttachedGroupPolicies");
        }

        /// <summary>
        /// 本接口（ListAttachedGroupPolicies）可用于查询用户组关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedGroupPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedGroupPoliciesResponse"/></returns>
        public ListAttachedGroupPoliciesResponse ListAttachedGroupPoliciesSync(ListAttachedGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedGroupPoliciesResponse>(req, "ListAttachedGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListAttachedRolePolicies）用于获取角色绑定的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedRolePoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedRolePoliciesResponse"/></returns>
        public Task<ListAttachedRolePoliciesResponse> ListAttachedRolePolicies(ListAttachedRolePoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedRolePoliciesResponse>(req, "ListAttachedRolePolicies");
        }

        /// <summary>
        /// 本接口（ListAttachedRolePolicies）用于获取角色绑定的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedRolePoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedRolePoliciesResponse"/></returns>
        public ListAttachedRolePoliciesResponse ListAttachedRolePoliciesSync(ListAttachedRolePoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedRolePoliciesResponse>(req, "ListAttachedRolePolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出用户关联的策略（包括随组关联）
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserAllPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserAllPoliciesResponse"/></returns>
        public Task<ListAttachedUserAllPoliciesResponse> ListAttachedUserAllPolicies(ListAttachedUserAllPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserAllPoliciesResponse>(req, "ListAttachedUserAllPolicies");
        }

        /// <summary>
        /// 列出用户关联的策略（包括随组关联）
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserAllPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserAllPoliciesResponse"/></returns>
        public ListAttachedUserAllPoliciesResponse ListAttachedUserAllPoliciesSync(ListAttachedUserAllPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserAllPoliciesResponse>(req, "ListAttachedUserAllPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListAttachedUserPolicies）可用于查询子账号关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserPoliciesResponse"/></returns>
        public Task<ListAttachedUserPoliciesResponse> ListAttachedUserPolicies(ListAttachedUserPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserPoliciesResponse>(req, "ListAttachedUserPolicies");
        }

        /// <summary>
        /// 本接口（ListAttachedUserPolicies）可用于查询子账号关联的策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserPoliciesResponse"/></returns>
        public ListAttachedUserPoliciesResponse ListAttachedUserPoliciesSync(ListAttachedUserPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserPoliciesResponse>(req, "ListAttachedUserPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取协作者列表
        /// </summary>
        /// <param name="req"><see cref="ListCollaboratorsRequest"/></param>
        /// <returns><see cref="ListCollaboratorsResponse"/></returns>
        public Task<ListCollaboratorsResponse> ListCollaborators(ListCollaboratorsRequest req)
        {
            return InternalRequestAsync<ListCollaboratorsResponse>(req, "ListCollaborators");
        }

        /// <summary>
        /// 获取协作者列表
        /// </summary>
        /// <param name="req"><see cref="ListCollaboratorsRequest"/></param>
        /// <returns><see cref="ListCollaboratorsResponse"/></returns>
        public ListCollaboratorsResponse ListCollaboratorsSync(ListCollaboratorsRequest req)
        {
            return InternalRequestAsync<ListCollaboratorsResponse>(req, "ListCollaborators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListEntitiesForPolicy）可用于查询策略关联的实体列表。
        /// </summary>
        /// <param name="req"><see cref="ListEntitiesForPolicyRequest"/></param>
        /// <returns><see cref="ListEntitiesForPolicyResponse"/></returns>
        public Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicy(ListEntitiesForPolicyRequest req)
        {
            return InternalRequestAsync<ListEntitiesForPolicyResponse>(req, "ListEntitiesForPolicy");
        }

        /// <summary>
        /// 本接口（ListEntitiesForPolicy）可用于查询策略关联的实体列表。
        /// </summary>
        /// <param name="req"><see cref="ListEntitiesForPolicyRequest"/></param>
        /// <returns><see cref="ListEntitiesForPolicyResponse"/></returns>
        public ListEntitiesForPolicyResponse ListEntitiesForPolicySync(ListEntitiesForPolicyRequest req)
        {
            return InternalRequestAsync<ListEntitiesForPolicyResponse>(req, "ListEntitiesForPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public Task<ListGroupsResponse> ListGroups(ListGroupsRequest req)
        {
            return InternalRequestAsync<ListGroupsResponse>(req, "ListGroups");
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public ListGroupsResponse ListGroupsSync(ListGroupsRequest req)
        {
            return InternalRequestAsync<ListGroupsResponse>(req, "ListGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出用户关联的用户组
        /// </summary>
        /// <param name="req"><see cref="ListGroupsForUserRequest"/></param>
        /// <returns><see cref="ListGroupsForUserResponse"/></returns>
        public Task<ListGroupsForUserResponse> ListGroupsForUser(ListGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListGroupsForUserResponse>(req, "ListGroupsForUser");
        }

        /// <summary>
        /// 列出用户关联的用户组
        /// </summary>
        /// <param name="req"><see cref="ListGroupsForUserRequest"/></param>
        /// <returns><see cref="ListGroupsForUserResponse"/></returns>
        public ListGroupsForUserResponse ListGroupsForUserSync(ListGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListGroupsForUserResponse>(req, "ListGroupsForUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListPolicies）可用于查询策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public Task<ListPoliciesResponse> ListPolicies(ListPoliciesRequest req)
        {
            return InternalRequestAsync<ListPoliciesResponse>(req, "ListPolicies");
        }

        /// <summary>
        /// 本接口（ListPolicies）可用于查询策略列表。
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public ListPoliciesResponse ListPoliciesSync(ListPoliciesRequest req)
        {
            return InternalRequestAsync<ListPoliciesResponse>(req, "ListPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取所有已授权服务
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesGrantingServiceAccessRequest"/></param>
        /// <returns><see cref="ListPoliciesGrantingServiceAccessResponse"/></returns>
        public Task<ListPoliciesGrantingServiceAccessResponse> ListPoliciesGrantingServiceAccess(ListPoliciesGrantingServiceAccessRequest req)
        {
            return InternalRequestAsync<ListPoliciesGrantingServiceAccessResponse>(req, "ListPoliciesGrantingServiceAccess");
        }

        /// <summary>
        /// 获取所有已授权服务
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesGrantingServiceAccessRequest"/></param>
        /// <returns><see cref="ListPoliciesGrantingServiceAccessResponse"/></returns>
        public ListPoliciesGrantingServiceAccessResponse ListPoliciesGrantingServiceAccessSync(ListPoliciesGrantingServiceAccessRequest req)
        {
            return InternalRequestAsync<ListPoliciesGrantingServiceAccessResponse>(req, "ListPoliciesGrantingServiceAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（ListPolicyVersions）用于获取策略版本列表
        /// </summary>
        /// <param name="req"><see cref="ListPolicyVersionsRequest"/></param>
        /// <returns><see cref="ListPolicyVersionsResponse"/></returns>
        public Task<ListPolicyVersionsResponse> ListPolicyVersions(ListPolicyVersionsRequest req)
        {
            return InternalRequestAsync<ListPolicyVersionsResponse>(req, "ListPolicyVersions");
        }

        /// <summary>
        /// 该接口（ListPolicyVersions）用于获取策略版本列表
        /// </summary>
        /// <param name="req"><see cref="ListPolicyVersionsRequest"/></param>
        /// <returns><see cref="ListPolicyVersionsResponse"/></returns>
        public ListPolicyVersionsResponse ListPolicyVersionsSync(ListPolicyVersionsRequest req)
        {
            return InternalRequestAsync<ListPolicyVersionsResponse>(req, "ListPolicyVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取消息接收人列表
        /// </summary>
        /// <param name="req"><see cref="ListReceiverRequest"/></param>
        /// <returns><see cref="ListReceiverResponse"/></returns>
        public Task<ListReceiverResponse> ListReceiver(ListReceiverRequest req)
        {
            return InternalRequestAsync<ListReceiverResponse>(req, "ListReceiver");
        }

        /// <summary>
        /// 获取消息接收人列表
        /// </summary>
        /// <param name="req"><see cref="ListReceiverRequest"/></param>
        /// <returns><see cref="ListReceiverResponse"/></returns>
        public ListReceiverResponse ListReceiverSync(ListReceiverRequest req)
        {
            return InternalRequestAsync<ListReceiverResponse>(req, "ListReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SAML身份提供商列表
        /// </summary>
        /// <param name="req"><see cref="ListSAMLProvidersRequest"/></param>
        /// <returns><see cref="ListSAMLProvidersResponse"/></returns>
        public Task<ListSAMLProvidersResponse> ListSAMLProviders(ListSAMLProvidersRequest req)
        {
            return InternalRequestAsync<ListSAMLProvidersResponse>(req, "ListSAMLProviders");
        }

        /// <summary>
        /// 查询SAML身份提供商列表
        /// </summary>
        /// <param name="req"><see cref="ListSAMLProvidersRequest"/></param>
        /// <returns><see cref="ListSAMLProvidersResponse"/></returns>
        public ListSAMLProvidersResponse ListSAMLProvidersSync(ListSAMLProvidersRequest req)
        {
            return InternalRequestAsync<ListSAMLProvidersResponse>(req, "ListSAMLProviders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取子用户
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public Task<ListUsersResponse> ListUsers(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers");
        }

        /// <summary>
        /// 拉取子用户
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public ListUsersResponse ListUsersSync(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组关联的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersForGroupRequest"/></param>
        /// <returns><see cref="ListUsersForGroupResponse"/></returns>
        public Task<ListUsersForGroupResponse> ListUsersForGroup(ListUsersForGroupRequest req)
        {
            return InternalRequestAsync<ListUsersForGroupResponse>(req, "ListUsersForGroup");
        }

        /// <summary>
        /// 查询用户组关联的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersForGroupRequest"/></param>
        /// <returns><see cref="ListUsersForGroupResponse"/></returns>
        public ListUsersForGroupResponse ListUsersForGroupSync(ListUsersForGroupRequest req)
        {
            return InternalRequestAsync<ListUsersForGroupResponse>(req, "ListUsersForGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业微信子用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWeChatWorkSubAccountsRequest"/></param>
        /// <returns><see cref="ListWeChatWorkSubAccountsResponse"/></returns>
        public Task<ListWeChatWorkSubAccountsResponse> ListWeChatWorkSubAccounts(ListWeChatWorkSubAccountsRequest req)
        {
            return InternalRequestAsync<ListWeChatWorkSubAccountsResponse>(req, "ListWeChatWorkSubAccounts");
        }

        /// <summary>
        /// 获取企业微信子用户列表
        /// </summary>
        /// <param name="req"><see cref="ListWeChatWorkSubAccountsRequest"/></param>
        /// <returns><see cref="ListWeChatWorkSubAccountsResponse"/></returns>
        public ListWeChatWorkSubAccountsResponse ListWeChatWorkSubAccountsSync(ListWeChatWorkSubAccountsRequest req)
        {
            return InternalRequestAsync<ListWeChatWorkSubAccountsResponse>(req, "ListWeChatWorkSubAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置角色权限边界
        /// </summary>
        /// <param name="req"><see cref="PutRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutRolePermissionsBoundaryResponse"/></returns>
        public Task<PutRolePermissionsBoundaryResponse> PutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutRolePermissionsBoundaryResponse>(req, "PutRolePermissionsBoundary");
        }

        /// <summary>
        /// 设置角色权限边界
        /// </summary>
        /// <param name="req"><see cref="PutRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutRolePermissionsBoundaryResponse"/></returns>
        public PutRolePermissionsBoundaryResponse PutRolePermissionsBoundarySync(PutRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutRolePermissionsBoundaryResponse>(req, "PutRolePermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置用户权限边界
        /// </summary>
        /// <param name="req"><see cref="PutUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutUserPermissionsBoundaryResponse"/></returns>
        public Task<PutUserPermissionsBoundaryResponse> PutUserPermissionsBoundary(PutUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutUserPermissionsBoundaryResponse>(req, "PutUserPermissionsBoundary");
        }

        /// <summary>
        /// 设置用户权限边界
        /// </summary>
        /// <param name="req"><see cref="PutUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutUserPermissionsBoundaryResponse"/></returns>
        public PutUserPermissionsBoundaryResponse PutUserPermissionsBoundarySync(PutUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutUserPermissionsBoundaryResponse>(req, "PutUserPermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从用户组删除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public Task<RemoveUserFromGroupResponse> RemoveUserFromGroup(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup");
        }

        /// <summary>
        /// 从用户组删除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroupSync(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetDefaultPolicyVersion）可用于设置生效的策略版本。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultPolicyVersionRequest"/></param>
        /// <returns><see cref="SetDefaultPolicyVersionResponse"/></returns>
        public Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest req)
        {
            return InternalRequestAsync<SetDefaultPolicyVersionResponse>(req, "SetDefaultPolicyVersion");
        }

        /// <summary>
        /// 本接口（SetDefaultPolicyVersion）可用于设置生效的策略版本。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultPolicyVersionRequest"/></param>
        /// <returns><see cref="SetDefaultPolicyVersionResponse"/></returns>
        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersionSync(SetDefaultPolicyVersionRequest req)
        {
            return InternalRequestAsync<SetDefaultPolicyVersionResponse>(req, "SetDefaultPolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置子用户的登录保护和敏感操作校验方式
        /// </summary>
        /// <param name="req"><see cref="SetMfaFlagRequest"/></param>
        /// <returns><see cref="SetMfaFlagResponse"/></returns>
        public Task<SetMfaFlagResponse> SetMfaFlag(SetMfaFlagRequest req)
        {
            return InternalRequestAsync<SetMfaFlagResponse>(req, "SetMfaFlag");
        }

        /// <summary>
        /// 设置子用户的登录保护和敏感操作校验方式
        /// </summary>
        /// <param name="req"><see cref="SetMfaFlagRequest"/></param>
        /// <returns><see cref="SetMfaFlagResponse"/></returns>
        public SetMfaFlagResponse SetMfaFlagSync(SetMfaFlagRequest req)
        {
            return InternalRequestAsync<SetMfaFlagResponse>(req, "SetMfaFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 角色绑定标签
        /// </summary>
        /// <param name="req"><see cref="TagRoleRequest"/></param>
        /// <returns><see cref="TagRoleResponse"/></returns>
        public Task<TagRoleResponse> TagRole(TagRoleRequest req)
        {
            return InternalRequestAsync<TagRoleResponse>(req, "TagRole");
        }

        /// <summary>
        /// 角色绑定标签
        /// </summary>
        /// <param name="req"><see cref="TagRoleRequest"/></param>
        /// <returns><see cref="TagRoleResponse"/></returns>
        public TagRoleResponse TagRoleSync(TagRoleRequest req)
        {
            return InternalRequestAsync<TagRoleResponse>(req, "TagRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 角色解绑标签。
        /// </summary>
        /// <param name="req"><see cref="UntagRoleRequest"/></param>
        /// <returns><see cref="UntagRoleResponse"/></returns>
        public Task<UntagRoleResponse> UntagRole(UntagRoleRequest req)
        {
            return InternalRequestAsync<UntagRoleResponse>(req, "UntagRole");
        }

        /// <summary>
        /// 角色解绑标签。
        /// </summary>
        /// <param name="req"><see cref="UntagRoleRequest"/></param>
        /// <returns><see cref="UntagRoleResponse"/></returns>
        public UntagRoleResponse UntagRoleSync(UntagRoleRequest req)
        {
            return InternalRequestAsync<UntagRoleResponse>(req, "UntagRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为CAM用户更新访问密钥
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyResponse"/></returns>
        public Task<UpdateAccessKeyResponse> UpdateAccessKey(UpdateAccessKeyRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyResponse>(req, "UpdateAccessKey");
        }

        /// <summary>
        /// 为CAM用户更新访问密钥
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyResponse"/></returns>
        public UpdateAccessKeyResponse UpdateAccessKeySync(UpdateAccessKeyRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyResponse>(req, "UpdateAccessKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateAssumeRolePolicy）用于修改角色信任策略的策略文档。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssumeRolePolicyRequest"/></param>
        /// <returns><see cref="UpdateAssumeRolePolicyResponse"/></returns>
        public Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest req)
        {
            return InternalRequestAsync<UpdateAssumeRolePolicyResponse>(req, "UpdateAssumeRolePolicy");
        }

        /// <summary>
        /// 本接口（UpdateAssumeRolePolicy）用于修改角色信任策略的策略文档。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssumeRolePolicyRequest"/></param>
        /// <returns><see cref="UpdateAssumeRolePolicyResponse"/></returns>
        public UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicySync(UpdateAssumeRolePolicyRequest req)
        {
            return InternalRequestAsync<UpdateAssumeRolePolicyResponse>(req, "UpdateAssumeRolePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public Task<UpdateGroupResponse> UpdateGroup(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup");
        }

        /// <summary>
        /// 更新用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public UpdateGroupResponse UpdateGroupSync(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改角色OIDC配置
        /// </summary>
        /// <param name="req"><see cref="UpdateOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateOIDCConfigResponse"/></returns>
        public Task<UpdateOIDCConfigResponse> UpdateOIDCConfig(UpdateOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateOIDCConfigResponse>(req, "UpdateOIDCConfig");
        }

        /// <summary>
        /// 修改角色OIDC配置
        /// </summary>
        /// <param name="req"><see cref="UpdateOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateOIDCConfigResponse"/></returns>
        public UpdateOIDCConfigResponse UpdateOIDCConfigSync(UpdateOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateOIDCConfigResponse>(req, "UpdateOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdatePolicy ）可用于更新策略。
        /// 如果已存在策略版本，本接口会直接更新策略的默认版本，不会创建新版本，如果不存在任何策略版本，则直接创建一个默认版本。
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public Task<UpdatePolicyResponse> UpdatePolicy(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy");
        }

        /// <summary>
        /// 本接口（UpdatePolicy ）可用于更新策略。
        /// 如果已存在策略版本，本接口会直接更新策略的默认版本，不会创建新版本，如果不存在任何策略版本，则直接创建一个默认版本。
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public UpdatePolicyResponse UpdatePolicySync(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateRoleConsoleLogin）用于修改角色是否可登录。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConsoleLoginRequest"/></param>
        /// <returns><see cref="UpdateRoleConsoleLoginResponse"/></returns>
        public Task<UpdateRoleConsoleLoginResponse> UpdateRoleConsoleLogin(UpdateRoleConsoleLoginRequest req)
        {
            return InternalRequestAsync<UpdateRoleConsoleLoginResponse>(req, "UpdateRoleConsoleLogin");
        }

        /// <summary>
        /// 本接口（UpdateRoleConsoleLogin）用于修改角色是否可登录。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConsoleLoginRequest"/></param>
        /// <returns><see cref="UpdateRoleConsoleLoginResponse"/></returns>
        public UpdateRoleConsoleLoginResponse UpdateRoleConsoleLoginSync(UpdateRoleConsoleLoginRequest req)
        {
            return InternalRequestAsync<UpdateRoleConsoleLoginResponse>(req, "UpdateRoleConsoleLogin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateRoleDescription）用于修改角色的描述信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleDescriptionRequest"/></param>
        /// <returns><see cref="UpdateRoleDescriptionResponse"/></returns>
        public Task<UpdateRoleDescriptionResponse> UpdateRoleDescription(UpdateRoleDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateRoleDescriptionResponse>(req, "UpdateRoleDescription");
        }

        /// <summary>
        /// 本接口（UpdateRoleDescription）用于修改角色的描述信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleDescriptionRequest"/></param>
        /// <returns><see cref="UpdateRoleDescriptionResponse"/></returns>
        public UpdateRoleDescriptionResponse UpdateRoleDescriptionSync(UpdateRoleDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateRoleDescriptionResponse>(req, "UpdateRoleDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改角色会话时长 
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleSessionDurationRequest"/></param>
        /// <returns><see cref="UpdateRoleSessionDurationResponse"/></returns>
        public Task<UpdateRoleSessionDurationResponse> UpdateRoleSessionDuration(UpdateRoleSessionDurationRequest req)
        {
            return InternalRequestAsync<UpdateRoleSessionDurationResponse>(req, "UpdateRoleSessionDuration");
        }

        /// <summary>
        /// 修改角色会话时长 
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleSessionDurationRequest"/></param>
        /// <returns><see cref="UpdateRoleSessionDurationResponse"/></returns>
        public UpdateRoleSessionDurationResponse UpdateRoleSessionDurationSync(UpdateRoleSessionDurationRequest req)
        {
            return InternalRequestAsync<UpdateRoleSessionDurationResponse>(req, "UpdateRoleSessionDuration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新SAML身份提供商信息
        /// </summary>
        /// <param name="req"><see cref="UpdateSAMLProviderRequest"/></param>
        /// <returns><see cref="UpdateSAMLProviderResponse"/></returns>
        public Task<UpdateSAMLProviderResponse> UpdateSAMLProvider(UpdateSAMLProviderRequest req)
        {
            return InternalRequestAsync<UpdateSAMLProviderResponse>(req, "UpdateSAMLProvider");
        }

        /// <summary>
        /// 更新SAML身份提供商信息
        /// </summary>
        /// <param name="req"><see cref="UpdateSAMLProviderRequest"/></param>
        /// <returns><see cref="UpdateSAMLProviderResponse"/></returns>
        public UpdateSAMLProviderResponse UpdateSAMLProviderSync(UpdateSAMLProviderRequest req)
        {
            return InternalRequestAsync<UpdateSAMLProviderResponse>(req, "UpdateSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新子用户
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser");
        }

        /// <summary>
        /// 更新子用户
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateUserOIDCConfigResponse"/></returns>
        public Task<UpdateUserOIDCConfigResponse> UpdateUserOIDCConfig(UpdateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserOIDCConfigResponse>(req, "UpdateUserOIDCConfig");
        }

        /// <summary>
        /// 修改用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateUserOIDCConfigResponse"/></returns>
        public UpdateUserOIDCConfigResponse UpdateUserOIDCConfigSync(UpdateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserOIDCConfigResponse>(req, "UpdateUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="UpdateUserSAMLConfigResponse"/></returns>
        public Task<UpdateUserSAMLConfigResponse> UpdateUserSAMLConfig(UpdateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserSAMLConfigResponse>(req, "UpdateUserSAMLConfig");
        }

        /// <summary>
        /// 修改用户SAML配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="UpdateUserSAMLConfigResponse"/></returns>
        public UpdateUserSAMLConfigResponse UpdateUserSAMLConfigSync(UpdateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserSAMLConfigResponse>(req, "UpdateUserSAMLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
