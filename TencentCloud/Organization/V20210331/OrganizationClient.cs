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

namespace TencentCloud.Organization.V20210331
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Organization.V20210331.Models;

   public class OrganizationClient : AbstractClient{

       private const string endpoint = "organization.tencentcloudapi.com";
       private const string version = "2021-03-31";
       private const string sdkVersion = "SDK_NET_3.0.1212";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OrganizationClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OrganizationClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 接受加入共享单元邀请。
        /// </summary>
        /// <param name="req"><see cref="AcceptJoinShareUnitInvitationRequest"/></param>
        /// <returns><see cref="AcceptJoinShareUnitInvitationResponse"/></returns>
        public Task<AcceptJoinShareUnitInvitationResponse> AcceptJoinShareUnitInvitation(AcceptJoinShareUnitInvitationRequest req)
        {
            return InternalRequestAsync<AcceptJoinShareUnitInvitationResponse>(req, "AcceptJoinShareUnitInvitation");
        }

        /// <summary>
        /// 接受加入共享单元邀请。
        /// </summary>
        /// <param name="req"><see cref="AcceptJoinShareUnitInvitationRequest"/></param>
        /// <returns><see cref="AcceptJoinShareUnitInvitationResponse"/></returns>
        public AcceptJoinShareUnitInvitationResponse AcceptJoinShareUnitInvitationSync(AcceptJoinShareUnitInvitationRequest req)
        {
            return InternalRequestAsync<AcceptJoinShareUnitInvitationResponse>(req, "AcceptJoinShareUnitInvitation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加SAML签名证书
        /// </summary>
        /// <param name="req"><see cref="AddExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="AddExternalSAMLIdPCertificateResponse"/></returns>
        public Task<AddExternalSAMLIdPCertificateResponse> AddExternalSAMLIdPCertificate(AddExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<AddExternalSAMLIdPCertificateResponse>(req, "AddExternalSAMLIdPCertificate");
        }

        /// <summary>
        /// 添加SAML签名证书
        /// </summary>
        /// <param name="req"><see cref="AddExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="AddExternalSAMLIdPCertificateResponse"/></returns>
        public AddExternalSAMLIdPCertificateResponse AddExternalSAMLIdPCertificateSync(AddExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<AddExternalSAMLIdPCertificateResponse>(req, "AddExternalSAMLIdPCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加组织成员邮箱
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationMemberEmailRequest"/></param>
        /// <returns><see cref="AddOrganizationMemberEmailResponse"/></returns>
        public Task<AddOrganizationMemberEmailResponse> AddOrganizationMemberEmail(AddOrganizationMemberEmailRequest req)
        {
            return InternalRequestAsync<AddOrganizationMemberEmailResponse>(req, "AddOrganizationMemberEmail");
        }

        /// <summary>
        /// 添加组织成员邮箱
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationMemberEmailRequest"/></param>
        /// <returns><see cref="AddOrganizationMemberEmailResponse"/></returns>
        public AddOrganizationMemberEmailResponse AddOrganizationMemberEmailSync(AddOrganizationMemberEmailRequest req)
        {
            return InternalRequestAsync<AddOrganizationMemberEmailResponse>(req, "AddOrganizationMemberEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加企业组织节点
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public Task<AddOrganizationNodeResponse> AddOrganizationNode(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode");
        }

        /// <summary>
        /// 添加企业组织节点
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public AddOrganizationNodeResponse AddOrganizationNodeSync(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为权限配置添加策略
        /// </summary>
        /// <param name="req"><see cref="AddPermissionPolicyToRoleConfigurationRequest"/></param>
        /// <returns><see cref="AddPermissionPolicyToRoleConfigurationResponse"/></returns>
        public Task<AddPermissionPolicyToRoleConfigurationResponse> AddPermissionPolicyToRoleConfiguration(AddPermissionPolicyToRoleConfigurationRequest req)
        {
            return InternalRequestAsync<AddPermissionPolicyToRoleConfigurationResponse>(req, "AddPermissionPolicyToRoleConfiguration");
        }

        /// <summary>
        /// 为权限配置添加策略
        /// </summary>
        /// <param name="req"><see cref="AddPermissionPolicyToRoleConfigurationRequest"/></param>
        /// <returns><see cref="AddPermissionPolicyToRoleConfigurationResponse"/></returns>
        public AddPermissionPolicyToRoleConfigurationResponse AddPermissionPolicyToRoleConfigurationSync(AddPermissionPolicyToRoleConfigurationRequest req)
        {
            return InternalRequestAsync<AddPermissionPolicyToRoleConfigurationResponse>(req, "AddPermissionPolicyToRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建共享单元。
        /// </summary>
        /// <param name="req"><see cref="AddShareUnitRequest"/></param>
        /// <returns><see cref="AddShareUnitResponse"/></returns>
        public Task<AddShareUnitResponse> AddShareUnit(AddShareUnitRequest req)
        {
            return InternalRequestAsync<AddShareUnitResponse>(req, "AddShareUnit");
        }

        /// <summary>
        /// 创建共享单元。
        /// </summary>
        /// <param name="req"><see cref="AddShareUnitRequest"/></param>
        /// <returns><see cref="AddShareUnitResponse"/></returns>
        public AddShareUnitResponse AddShareUnitSync(AddShareUnitRequest req)
        {
            return InternalRequestAsync<AddShareUnitResponse>(req, "AddShareUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加共享单元成员
        /// </summary>
        /// <param name="req"><see cref="AddShareUnitMembersRequest"/></param>
        /// <returns><see cref="AddShareUnitMembersResponse"/></returns>
        public Task<AddShareUnitMembersResponse> AddShareUnitMembers(AddShareUnitMembersRequest req)
        {
            return InternalRequestAsync<AddShareUnitMembersResponse>(req, "AddShareUnitMembers");
        }

        /// <summary>
        /// 添加共享单元成员
        /// </summary>
        /// <param name="req"><see cref="AddShareUnitMembersRequest"/></param>
        /// <returns><see cref="AddShareUnitMembersResponse"/></returns>
        public AddShareUnitMembersResponse AddShareUnitMembersSync(AddShareUnitMembersRequest req)
        {
            return InternalRequestAsync<AddShareUnitMembersResponse>(req, "AddShareUnitMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加共享单元资源
        /// </summary>
        /// <param name="req"><see cref="AddShareUnitResourcesRequest"/></param>
        /// <returns><see cref="AddShareUnitResourcesResponse"/></returns>
        public Task<AddShareUnitResourcesResponse> AddShareUnitResources(AddShareUnitResourcesRequest req)
        {
            return InternalRequestAsync<AddShareUnitResourcesResponse>(req, "AddShareUnitResources");
        }

        /// <summary>
        /// 添加共享单元资源
        /// </summary>
        /// <param name="req"><see cref="AddShareUnitResourcesRequest"/></param>
        /// <returns><see cref="AddShareUnitResourcesResponse"/></returns>
        public AddShareUnitResourcesResponse AddShareUnitResourcesSync(AddShareUnitResourcesRequest req)
        {
            return InternalRequestAsync<AddShareUnitResourcesResponse>(req, "AddShareUnitResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为用户组添加用户
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public Task<AddUserToGroupResponse> AddUserToGroup(AddUserToGroupRequest req)
        {
            return InternalRequestAsync<AddUserToGroupResponse>(req, "AddUserToGroup");
        }

        /// <summary>
        /// 为用户组添加用户
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public AddUserToGroupResponse AddUserToGroupSync(AddUserToGroupRequest req)
        {
            return InternalRequestAsync<AddUserToGroupResponse>(req, "AddUserToGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定策略
        /// </summary>
        /// <param name="req"><see cref="AttachPolicyRequest"/></param>
        /// <returns><see cref="AttachPolicyResponse"/></returns>
        public Task<AttachPolicyResponse> AttachPolicy(AttachPolicyRequest req)
        {
            return InternalRequestAsync<AttachPolicyResponse>(req, "AttachPolicy");
        }

        /// <summary>
        /// 绑定策略
        /// </summary>
        /// <param name="req"><see cref="AttachPolicyRequest"/></param>
        /// <returns><see cref="AttachPolicyResponse"/></returns>
        public AttachPolicyResponse AttachPolicySync(AttachPolicyRequest req)
        {
            return InternalRequestAsync<AttachPolicyResponse>(req, "AttachPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定组织成员和组织管理员子账号的授权关系
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public Task<BindOrganizationMemberAuthAccountResponse> BindOrganizationMemberAuthAccount(BindOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationMemberAuthAccountResponse>(req, "BindOrganizationMemberAuthAccount");
        }

        /// <summary>
        /// 绑定组织成员和组织管理员子账号的授权关系
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public BindOrganizationMemberAuthAccountResponse BindOrganizationMemberAuthAccountSync(BindOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationMemberAuthAccountResponse>(req, "BindOrganizationMemberAuthAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定成员访问授权策略和组织管理员子账号
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationPolicySubAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationPolicySubAccountResponse"/></returns>
        public Task<BindOrganizationPolicySubAccountResponse> BindOrganizationPolicySubAccount(BindOrganizationPolicySubAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationPolicySubAccountResponse>(req, "BindOrganizationPolicySubAccount");
        }

        /// <summary>
        /// 绑定成员访问授权策略和组织管理员子账号
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationPolicySubAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationPolicySubAccountResponse"/></returns>
        public BindOrganizationPolicySubAccountResponse BindOrganizationPolicySubAccountSync(BindOrganizationPolicySubAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationPolicySubAccountResponse>(req, "BindOrganizationPolicySubAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消组织成员和组织管理员子账号的授权关系
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public Task<CancelOrganizationMemberAuthAccountResponse> CancelOrganizationMemberAuthAccount(CancelOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationMemberAuthAccountResponse>(req, "CancelOrganizationMemberAuthAccount");
        }

        /// <summary>
        /// 取消组织成员和组织管理员子账号的授权关系
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public CancelOrganizationMemberAuthAccountResponse CancelOrganizationMemberAuthAccountSync(CancelOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationMemberAuthAccountResponse>(req, "CancelOrganizationMemberAuthAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑成员访问授权策略和组织管理员子账号
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationPolicySubAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationPolicySubAccountResponse"/></returns>
        public Task<CancelOrganizationPolicySubAccountResponse> CancelOrganizationPolicySubAccount(CancelOrganizationPolicySubAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationPolicySubAccountResponse>(req, "CancelOrganizationPolicySubAccount");
        }

        /// <summary>
        /// 解绑成员访问授权策略和组织管理员子账号
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationPolicySubAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationPolicySubAccountResponse"/></returns>
        public CancelOrganizationPolicySubAccountResponse CancelOrganizationPolicySubAccountSync(CancelOrganizationPolicySubAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationPolicySubAccountResponse>(req, "CancelOrganizationPolicySubAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成员账号删除检查
        /// </summary>
        /// <param name="req"><see cref="CheckAccountDeleteRequest"/></param>
        /// <returns><see cref="CheckAccountDeleteResponse"/></returns>
        public Task<CheckAccountDeleteResponse> CheckAccountDelete(CheckAccountDeleteRequest req)
        {
            return InternalRequestAsync<CheckAccountDeleteResponse>(req, "CheckAccountDelete");
        }

        /// <summary>
        /// 成员账号删除检查
        /// </summary>
        /// <param name="req"><see cref="CheckAccountDeleteRequest"/></param>
        /// <returns><see cref="CheckAccountDeleteResponse"/></returns>
        public CheckAccountDeleteResponse CheckAccountDeleteSync(CheckAccountDeleteRequest req)
        {
            return InternalRequestAsync<CheckAccountDeleteResponse>(req, "CheckAccountDelete")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 清空SAML身份提供商配置信息
        /// </summary>
        /// <param name="req"><see cref="ClearExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="ClearExternalSAMLIdentityProviderResponse"/></returns>
        public Task<ClearExternalSAMLIdentityProviderResponse> ClearExternalSAMLIdentityProvider(ClearExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<ClearExternalSAMLIdentityProviderResponse>(req, "ClearExternalSAMLIdentityProvider");
        }

        /// <summary>
        /// 清空SAML身份提供商配置信息
        /// </summary>
        /// <param name="req"><see cref="ClearExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="ClearExternalSAMLIdentityProviderResponse"/></returns>
        public ClearExternalSAMLIdentityProviderResponse ClearExternalSAMLIdentityProviderSync(ClearExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<ClearExternalSAMLIdentityProviderResponse>(req, "ClearExternalSAMLIdentityProvider")
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
        /// 添加集团服务委派管理员
        /// </summary>
        /// <param name="req"><see cref="CreateOrgServiceAssignRequest"/></param>
        /// <returns><see cref="CreateOrgServiceAssignResponse"/></returns>
        public Task<CreateOrgServiceAssignResponse> CreateOrgServiceAssign(CreateOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<CreateOrgServiceAssignResponse>(req, "CreateOrgServiceAssign");
        }

        /// <summary>
        /// 添加集团服务委派管理员
        /// </summary>
        /// <param name="req"><see cref="CreateOrgServiceAssignRequest"/></param>
        /// <returns><see cref="CreateOrgServiceAssignResponse"/></returns>
        public CreateOrgServiceAssignResponse CreateOrgServiceAssignSync(CreateOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<CreateOrgServiceAssignResponse>(req, "CreateOrgServiceAssign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建企业组织
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationRequest"/></param>
        /// <returns><see cref="CreateOrganizationResponse"/></returns>
        public Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest req)
        {
            return InternalRequestAsync<CreateOrganizationResponse>(req, "CreateOrganization");
        }

        /// <summary>
        /// 创建企业组织
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationRequest"/></param>
        /// <returns><see cref="CreateOrganizationResponse"/></returns>
        public CreateOrganizationResponse CreateOrganizationSync(CreateOrganizationRequest req)
        {
            return InternalRequestAsync<CreateOrganizationResponse>(req, "CreateOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加组织身份
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationIdentityResponse"/></returns>
        public Task<CreateOrganizationIdentityResponse> CreateOrganizationIdentity(CreateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationIdentityResponse>(req, "CreateOrganizationIdentity");
        }

        /// <summary>
        /// 添加组织身份
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationIdentityResponse"/></returns>
        public CreateOrganizationIdentityResponse CreateOrganizationIdentitySync(CreateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationIdentityResponse>(req, "CreateOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建组织成员
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public Task<CreateOrganizationMemberResponse> CreateOrganizationMember(CreateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberResponse>(req, "CreateOrganizationMember");
        }

        /// <summary>
        /// 创建组织成员
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public CreateOrganizationMemberResponse CreateOrganizationMemberSync(CreateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberResponse>(req, "CreateOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加组织成员访问授权
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberAuthIdentityResponse"/></returns>
        public Task<CreateOrganizationMemberAuthIdentityResponse> CreateOrganizationMemberAuthIdentity(CreateOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberAuthIdentityResponse>(req, "CreateOrganizationMemberAuthIdentity");
        }

        /// <summary>
        /// 添加组织成员访问授权
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberAuthIdentityResponse"/></returns>
        public CreateOrganizationMemberAuthIdentityResponse CreateOrganizationMemberAuthIdentitySync(CreateOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberAuthIdentityResponse>(req, "CreateOrganizationMemberAuthIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建组织成员访问授权策略
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public Task<CreateOrganizationMemberPolicyResponse> CreateOrganizationMemberPolicy(CreateOrganizationMemberPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberPolicyResponse>(req, "CreateOrganizationMemberPolicy");
        }

        /// <summary>
        /// 创建组织成员访问授权策略
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public CreateOrganizationMemberPolicyResponse CreateOrganizationMemberPolicySync(CreateOrganizationMemberPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberPolicyResponse>(req, "CreateOrganizationMemberPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建组织成员访问策略
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMembersPolicyResponse"/></returns>
        public Task<CreateOrganizationMembersPolicyResponse> CreateOrganizationMembersPolicy(CreateOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMembersPolicyResponse>(req, "CreateOrganizationMembersPolicy");
        }

        /// <summary>
        /// 创建组织成员访问策略
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMembersPolicyResponse"/></returns>
        public CreateOrganizationMembersPolicyResponse CreateOrganizationMembersPolicySync(CreateOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMembersPolicyResponse>(req, "CreateOrganizationMembersPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个特殊类型的策略，您可以关联到企业组织Root节点、企业部门节点或者企业的成员账号。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public Task<CreatePolicyResponse> CreatePolicy(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy");
        }

        /// <summary>
        /// 创建一个特殊类型的策略，您可以关联到企业组织Root节点、企业部门节点或者企业的成员账号。
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public CreatePolicyResponse CreatePolicySync(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在成员账号上授权
        /// </summary>
        /// <param name="req"><see cref="CreateRoleAssignmentRequest"/></param>
        /// <returns><see cref="CreateRoleAssignmentResponse"/></returns>
        public Task<CreateRoleAssignmentResponse> CreateRoleAssignment(CreateRoleAssignmentRequest req)
        {
            return InternalRequestAsync<CreateRoleAssignmentResponse>(req, "CreateRoleAssignment");
        }

        /// <summary>
        /// 在成员账号上授权
        /// </summary>
        /// <param name="req"><see cref="CreateRoleAssignmentRequest"/></param>
        /// <returns><see cref="CreateRoleAssignmentResponse"/></returns>
        public CreateRoleAssignmentResponse CreateRoleAssignmentSync(CreateRoleAssignmentRequest req)
        {
            return InternalRequestAsync<CreateRoleAssignmentResponse>(req, "CreateRoleAssignment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建权限配置
        /// </summary>
        /// <param name="req"><see cref="CreateRoleConfigurationRequest"/></param>
        /// <returns><see cref="CreateRoleConfigurationResponse"/></returns>
        public Task<CreateRoleConfigurationResponse> CreateRoleConfiguration(CreateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<CreateRoleConfigurationResponse>(req, "CreateRoleConfiguration");
        }

        /// <summary>
        /// 创建权限配置
        /// </summary>
        /// <param name="req"><see cref="CreateRoleConfigurationRequest"/></param>
        /// <returns><see cref="CreateRoleConfigurationResponse"/></returns>
        public CreateRoleConfigurationResponse CreateRoleConfigurationSync(CreateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<CreateRoleConfigurationResponse>(req, "CreateRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建SCIM密钥
        /// </summary>
        /// <param name="req"><see cref="CreateSCIMCredentialRequest"/></param>
        /// <returns><see cref="CreateSCIMCredentialResponse"/></returns>
        public Task<CreateSCIMCredentialResponse> CreateSCIMCredential(CreateSCIMCredentialRequest req)
        {
            return InternalRequestAsync<CreateSCIMCredentialResponse>(req, "CreateSCIMCredential");
        }

        /// <summary>
        /// 创建SCIM密钥
        /// </summary>
        /// <param name="req"><see cref="CreateSCIMCredentialRequest"/></param>
        /// <returns><see cref="CreateSCIMCredentialResponse"/></returns>
        public CreateSCIMCredentialResponse CreateSCIMCredentialSync(CreateSCIMCredentialRequest req)
        {
            return InternalRequestAsync<CreateSCIMCredentialResponse>(req, "CreateSCIMCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建子用户同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="CreateUserSyncProvisioningResponse"/></returns>
        public Task<CreateUserSyncProvisioningResponse> CreateUserSyncProvisioning(CreateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<CreateUserSyncProvisioningResponse>(req, "CreateUserSyncProvisioning");
        }

        /// <summary>
        /// 创建子用户同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="CreateUserSyncProvisioningResponse"/></returns>
        public CreateUserSyncProvisioningResponse CreateUserSyncProvisioningSync(CreateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<CreateUserSyncProvisioningResponse>(req, "CreateUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除成员账号
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount");
        }

        /// <summary>
        /// 删除成员账号
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount")
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
        /// 删除集团服务委派管理员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgServiceAssignRequest"/></param>
        /// <returns><see cref="DeleteOrgServiceAssignResponse"/></returns>
        public Task<DeleteOrgServiceAssignResponse> DeleteOrgServiceAssign(DeleteOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<DeleteOrgServiceAssignResponse>(req, "DeleteOrgServiceAssign");
        }

        /// <summary>
        /// 删除集团服务委派管理员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgServiceAssignRequest"/></param>
        /// <returns><see cref="DeleteOrgServiceAssignResponse"/></returns>
        public DeleteOrgServiceAssignResponse DeleteOrgServiceAssignSync(DeleteOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<DeleteOrgServiceAssignResponse>(req, "DeleteOrgServiceAssign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除企业组织
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public Task<DeleteOrganizationResponse> DeleteOrganization(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization");
        }

        /// <summary>
        /// 删除企业组织
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public DeleteOrganizationResponse DeleteOrganizationSync(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除组织身份
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationIdentityResponse"/></returns>
        public Task<DeleteOrganizationIdentityResponse> DeleteOrganizationIdentity(DeleteOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationIdentityResponse>(req, "DeleteOrganizationIdentity");
        }

        /// <summary>
        /// 删除组织身份
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationIdentityResponse"/></returns>
        public DeleteOrganizationIdentityResponse DeleteOrganizationIdentitySync(DeleteOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationIdentityResponse>(req, "DeleteOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除组织成员访问授权
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMemberAuthIdentityResponse"/></returns>
        public Task<DeleteOrganizationMemberAuthIdentityResponse> DeleteOrganizationMemberAuthIdentity(DeleteOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMemberAuthIdentityResponse>(req, "DeleteOrganizationMemberAuthIdentity");
        }

        /// <summary>
        /// 删除组织成员访问授权
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMemberAuthIdentityResponse"/></returns>
        public DeleteOrganizationMemberAuthIdentityResponse DeleteOrganizationMemberAuthIdentitySync(DeleteOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMemberAuthIdentityResponse>(req, "DeleteOrganizationMemberAuthIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从组织中移除成员账号，不会删除账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public Task<DeleteOrganizationMembersResponse> DeleteOrganizationMembers(DeleteOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersResponse>(req, "DeleteOrganizationMembers");
        }

        /// <summary>
        /// 从组织中移除成员账号，不会删除账号。
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public DeleteOrganizationMembersResponse DeleteOrganizationMembersSync(DeleteOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersResponse>(req, "DeleteOrganizationMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除组织成员访问策略
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersPolicyResponse"/></returns>
        public Task<DeleteOrganizationMembersPolicyResponse> DeleteOrganizationMembersPolicy(DeleteOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersPolicyResponse>(req, "DeleteOrganizationMembersPolicy");
        }

        /// <summary>
        /// 删除组织成员访问策略
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersPolicyResponse"/></returns>
        public DeleteOrganizationMembersPolicyResponse DeleteOrganizationMembersPolicySync(DeleteOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersPolicyResponse>(req, "DeleteOrganizationMembersPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除企业组织节点
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public Task<DeleteOrganizationNodesResponse> DeleteOrganizationNodes(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes");
        }

        /// <summary>
        /// 批量删除企业组织节点
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public DeleteOrganizationNodesResponse DeleteOrganizationNodesSync(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public Task<DeletePolicyResponse> DeletePolicy(DeletePolicyRequest req)
        {
            return InternalRequestAsync<DeletePolicyResponse>(req, "DeletePolicy");
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public DeletePolicyResponse DeletePolicySync(DeletePolicyRequest req)
        {
            return InternalRequestAsync<DeletePolicyResponse>(req, "DeletePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移除成员账号上的授权
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleAssignmentRequest"/></param>
        /// <returns><see cref="DeleteRoleAssignmentResponse"/></returns>
        public Task<DeleteRoleAssignmentResponse> DeleteRoleAssignment(DeleteRoleAssignmentRequest req)
        {
            return InternalRequestAsync<DeleteRoleAssignmentResponse>(req, "DeleteRoleAssignment");
        }

        /// <summary>
        /// 移除成员账号上的授权
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleAssignmentRequest"/></param>
        /// <returns><see cref="DeleteRoleAssignmentResponse"/></returns>
        public DeleteRoleAssignmentResponse DeleteRoleAssignmentSync(DeleteRoleAssignmentRequest req)
        {
            return InternalRequestAsync<DeleteRoleAssignmentResponse>(req, "DeleteRoleAssignment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除权限配置信息
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleConfigurationRequest"/></param>
        /// <returns><see cref="DeleteRoleConfigurationResponse"/></returns>
        public Task<DeleteRoleConfigurationResponse> DeleteRoleConfiguration(DeleteRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteRoleConfigurationResponse>(req, "DeleteRoleConfiguration");
        }

        /// <summary>
        /// 删除权限配置信息
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleConfigurationRequest"/></param>
        /// <returns><see cref="DeleteRoleConfigurationResponse"/></returns>
        public DeleteRoleConfigurationResponse DeleteRoleConfigurationSync(DeleteRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteRoleConfigurationResponse>(req, "DeleteRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除SCIM密钥
        /// </summary>
        /// <param name="req"><see cref="DeleteSCIMCredentialRequest"/></param>
        /// <returns><see cref="DeleteSCIMCredentialResponse"/></returns>
        public Task<DeleteSCIMCredentialResponse> DeleteSCIMCredential(DeleteSCIMCredentialRequest req)
        {
            return InternalRequestAsync<DeleteSCIMCredentialResponse>(req, "DeleteSCIMCredential");
        }

        /// <summary>
        /// 删除SCIM密钥
        /// </summary>
        /// <param name="req"><see cref="DeleteSCIMCredentialRequest"/></param>
        /// <returns><see cref="DeleteSCIMCredentialResponse"/></returns>
        public DeleteSCIMCredentialResponse DeleteSCIMCredentialSync(DeleteSCIMCredentialRequest req)
        {
            return InternalRequestAsync<DeleteSCIMCredentialResponse>(req, "DeleteSCIMCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除共享单元。
        /// </summary>
        /// <param name="req"><see cref="DeleteShareUnitRequest"/></param>
        /// <returns><see cref="DeleteShareUnitResponse"/></returns>
        public Task<DeleteShareUnitResponse> DeleteShareUnit(DeleteShareUnitRequest req)
        {
            return InternalRequestAsync<DeleteShareUnitResponse>(req, "DeleteShareUnit");
        }

        /// <summary>
        /// 删除共享单元。
        /// </summary>
        /// <param name="req"><see cref="DeleteShareUnitRequest"/></param>
        /// <returns><see cref="DeleteShareUnitResponse"/></returns>
        public DeleteShareUnitResponse DeleteShareUnitSync(DeleteShareUnitRequest req)
        {
            return InternalRequestAsync<DeleteShareUnitResponse>(req, "DeleteShareUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除共享单元成员
        /// </summary>
        /// <param name="req"><see cref="DeleteShareUnitMembersRequest"/></param>
        /// <returns><see cref="DeleteShareUnitMembersResponse"/></returns>
        public Task<DeleteShareUnitMembersResponse> DeleteShareUnitMembers(DeleteShareUnitMembersRequest req)
        {
            return InternalRequestAsync<DeleteShareUnitMembersResponse>(req, "DeleteShareUnitMembers");
        }

        /// <summary>
        /// 删除共享单元成员
        /// </summary>
        /// <param name="req"><see cref="DeleteShareUnitMembersRequest"/></param>
        /// <returns><see cref="DeleteShareUnitMembersResponse"/></returns>
        public DeleteShareUnitMembersResponse DeleteShareUnitMembersSync(DeleteShareUnitMembersRequest req)
        {
            return InternalRequestAsync<DeleteShareUnitMembersResponse>(req, "DeleteShareUnitMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除共享单元资源
        /// </summary>
        /// <param name="req"><see cref="DeleteShareUnitResourcesRequest"/></param>
        /// <returns><see cref="DeleteShareUnitResourcesResponse"/></returns>
        public Task<DeleteShareUnitResourcesResponse> DeleteShareUnitResources(DeleteShareUnitResourcesRequest req)
        {
            return InternalRequestAsync<DeleteShareUnitResourcesResponse>(req, "DeleteShareUnitResources");
        }

        /// <summary>
        /// 删除共享单元资源
        /// </summary>
        /// <param name="req"><see cref="DeleteShareUnitResourcesRequest"/></param>
        /// <returns><see cref="DeleteShareUnitResourcesResponse"/></returns>
        public DeleteShareUnitResourcesResponse DeleteShareUnitResourcesSync(DeleteShareUnitResourcesRequest req)
        {
            return InternalRequestAsync<DeleteShareUnitResourcesResponse>(req, "DeleteShareUnitResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除子用户同步任务
        /// </summary>
        /// <param name="req"><see cref="DeleteUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="DeleteUserSyncProvisioningResponse"/></returns>
        public Task<DeleteUserSyncProvisioningResponse> DeleteUserSyncProvisioning(DeleteUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<DeleteUserSyncProvisioningResponse>(req, "DeleteUserSyncProvisioning");
        }

        /// <summary>
        /// 删除子用户同步任务
        /// </summary>
        /// <param name="req"><see cref="DeleteUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="DeleteUserSyncProvisioningResponse"/></returns>
        public DeleteUserSyncProvisioningResponse DeleteUserSyncProvisioningSync(DeleteUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<DeleteUserSyncProvisioningResponse>(req, "DeleteUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目标关联的有效策略
        /// </summary>
        /// <param name="req"><see cref="DescribeEffectivePolicyRequest"/></param>
        /// <returns><see cref="DescribeEffectivePolicyResponse"/></returns>
        public Task<DescribeEffectivePolicyResponse> DescribeEffectivePolicy(DescribeEffectivePolicyRequest req)
        {
            return InternalRequestAsync<DescribeEffectivePolicyResponse>(req, "DescribeEffectivePolicy");
        }

        /// <summary>
        /// 查询目标关联的有效策略
        /// </summary>
        /// <param name="req"><see cref="DescribeEffectivePolicyRequest"/></param>
        /// <returns><see cref="DescribeEffectivePolicyResponse"/></returns>
        public DescribeEffectivePolicyResponse DescribeEffectivePolicySync(DescribeEffectivePolicyRequest req)
        {
            return InternalRequestAsync<DescribeEffectivePolicyResponse>(req, "DescribeEffectivePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集团账号身份中心服务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentityCenterRequest"/></param>
        /// <returns><see cref="DescribeIdentityCenterResponse"/></returns>
        public Task<DescribeIdentityCenterResponse> DescribeIdentityCenter(DescribeIdentityCenterRequest req)
        {
            return InternalRequestAsync<DescribeIdentityCenterResponse>(req, "DescribeIdentityCenter");
        }

        /// <summary>
        /// 获取集团账号身份中心服务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentityCenterRequest"/></param>
        /// <returns><see cref="DescribeIdentityCenterResponse"/></returns>
        public DescribeIdentityCenterResponse DescribeIdentityCenterSync(DescribeIdentityCenterRequest req)
        {
            return InternalRequestAsync<DescribeIdentityCenterResponse>(req, "DescribeIdentityCenter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业组织信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public Task<DescribeOrganizationResponse> DescribeOrganization(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization");
        }

        /// <summary>
        /// 获取企业组织信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public DescribeOrganizationResponse DescribeOrganizationSync(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取已设置管理员的互信主体关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationAuthNodeRequest"/></param>
        /// <returns><see cref="DescribeOrganizationAuthNodeResponse"/></returns>
        public Task<DescribeOrganizationAuthNodeResponse> DescribeOrganizationAuthNode(DescribeOrganizationAuthNodeRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationAuthNodeResponse>(req, "DescribeOrganizationAuthNode");
        }

        /// <summary>
        /// 获取已设置管理员的互信主体关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationAuthNodeRequest"/></param>
        /// <returns><see cref="DescribeOrganizationAuthNodeResponse"/></returns>
        public DescribeOrganizationAuthNodeResponse DescribeOrganizationAuthNodeSync(DescribeOrganizationAuthNodeRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationAuthNodeResponse>(req, "DescribeOrganizationAuthNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以成员维度获取组织财务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationFinancialByMemberRequest"/></param>
        /// <returns><see cref="DescribeOrganizationFinancialByMemberResponse"/></returns>
        public Task<DescribeOrganizationFinancialByMemberResponse> DescribeOrganizationFinancialByMember(DescribeOrganizationFinancialByMemberRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationFinancialByMemberResponse>(req, "DescribeOrganizationFinancialByMember");
        }

        /// <summary>
        /// 以成员维度获取组织财务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationFinancialByMemberRequest"/></param>
        /// <returns><see cref="DescribeOrganizationFinancialByMemberResponse"/></returns>
        public DescribeOrganizationFinancialByMemberResponse DescribeOrganizationFinancialByMemberSync(DescribeOrganizationFinancialByMemberRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationFinancialByMemberResponse>(req, "DescribeOrganizationFinancialByMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以月维度获取组织财务信息趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationFinancialByMonthRequest"/></param>
        /// <returns><see cref="DescribeOrganizationFinancialByMonthResponse"/></returns>
        public Task<DescribeOrganizationFinancialByMonthResponse> DescribeOrganizationFinancialByMonth(DescribeOrganizationFinancialByMonthRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationFinancialByMonthResponse>(req, "DescribeOrganizationFinancialByMonth");
        }

        /// <summary>
        /// 以月维度获取组织财务信息趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationFinancialByMonthRequest"/></param>
        /// <returns><see cref="DescribeOrganizationFinancialByMonthResponse"/></returns>
        public DescribeOrganizationFinancialByMonthResponse DescribeOrganizationFinancialByMonthSync(DescribeOrganizationFinancialByMonthRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationFinancialByMonthResponse>(req, "DescribeOrganizationFinancialByMonth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以产品维度获取组织财务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationFinancialByProductRequest"/></param>
        /// <returns><see cref="DescribeOrganizationFinancialByProductResponse"/></returns>
        public Task<DescribeOrganizationFinancialByProductResponse> DescribeOrganizationFinancialByProduct(DescribeOrganizationFinancialByProductRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationFinancialByProductResponse>(req, "DescribeOrganizationFinancialByProduct");
        }

        /// <summary>
        /// 以产品维度获取组织财务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationFinancialByProductRequest"/></param>
        /// <returns><see cref="DescribeOrganizationFinancialByProductResponse"/></returns>
        public DescribeOrganizationFinancialByProductResponse DescribeOrganizationFinancialByProductSync(DescribeOrganizationFinancialByProductRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationFinancialByProductResponse>(req, "DescribeOrganizationFinancialByProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取组织成员被绑定授权关系的子账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public Task<DescribeOrganizationMemberAuthAccountsResponse> DescribeOrganizationMemberAuthAccounts(DescribeOrganizationMemberAuthAccountsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthAccountsResponse>(req, "DescribeOrganizationMemberAuthAccounts");
        }

        /// <summary>
        /// 获取组织成员被绑定授权关系的子账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public DescribeOrganizationMemberAuthAccountsResponse DescribeOrganizationMemberAuthAccountsSync(DescribeOrganizationMemberAuthAccountsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthAccountsResponse>(req, "DescribeOrganizationMemberAuthAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取组织成员访问授权列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public Task<DescribeOrganizationMemberAuthIdentitiesResponse> DescribeOrganizationMemberAuthIdentities(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthIdentitiesResponse>(req, "DescribeOrganizationMemberAuthIdentities");
        }

        /// <summary>
        /// 获取组织成员访问授权列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public DescribeOrganizationMemberAuthIdentitiesResponse DescribeOrganizationMemberAuthIdentitiesSync(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthIdentitiesResponse>(req, "DescribeOrganizationMemberAuthIdentities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询成员邮箱绑定详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberEmailBindRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberEmailBindResponse"/></returns>
        public Task<DescribeOrganizationMemberEmailBindResponse> DescribeOrganizationMemberEmailBind(DescribeOrganizationMemberEmailBindRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberEmailBindResponse>(req, "DescribeOrganizationMemberEmailBind");
        }

        /// <summary>
        /// 查询成员邮箱绑定详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberEmailBindRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberEmailBindResponse"/></returns>
        public DescribeOrganizationMemberEmailBindResponse DescribeOrganizationMemberEmailBindSync(DescribeOrganizationMemberEmailBindRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberEmailBindResponse>(req, "DescribeOrganizationMemberEmailBind")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取组织成员的授权策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public Task<DescribeOrganizationMemberPoliciesResponse> DescribeOrganizationMemberPolicies(DescribeOrganizationMemberPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberPoliciesResponse>(req, "DescribeOrganizationMemberPolicies");
        }

        /// <summary>
        /// 获取组织成员的授权策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public DescribeOrganizationMemberPoliciesResponse DescribeOrganizationMemberPoliciesSync(DescribeOrganizationMemberPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberPoliciesResponse>(req, "DescribeOrganizationMemberPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业组织成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public Task<DescribeOrganizationMembersResponse> DescribeOrganizationMembers(DescribeOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMembersResponse>(req, "DescribeOrganizationMembers");
        }

        /// <summary>
        /// 获取企业组织成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public DescribeOrganizationMembersResponse DescribeOrganizationMembersSync(DescribeOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMembersResponse>(req, "DescribeOrganizationMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取组织节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public Task<DescribeOrganizationNodesResponse> DescribeOrganizationNodes(DescribeOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationNodesResponse>(req, "DescribeOrganizationNodes");
        }

        /// <summary>
        /// 获取组织节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public DescribeOrganizationNodesResponse DescribeOrganizationNodesSync(DescribeOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationNodesResponse>(req, "DescribeOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePolicy）可用于查询查看策略详情。
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRequest"/></param>
        /// <returns><see cref="DescribePolicyResponse"/></returns>
        public Task<DescribePolicyResponse> DescribePolicy(DescribePolicyRequest req)
        {
            return InternalRequestAsync<DescribePolicyResponse>(req, "DescribePolicy");
        }

        /// <summary>
        /// 本接口（DescribePolicy）可用于查询查看策略详情。
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRequest"/></param>
        /// <returns><see cref="DescribePolicyResponse"/></returns>
        public DescribePolicyResponse DescribePolicySync(DescribePolicyRequest req)
        {
            return InternalRequestAsync<DescribePolicyResponse>(req, "DescribePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePolicyConfig）可用于查询企业组织策略配置
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConfigRequest"/></param>
        /// <returns><see cref="DescribePolicyConfigResponse"/></returns>
        public Task<DescribePolicyConfigResponse> DescribePolicyConfig(DescribePolicyConfigRequest req)
        {
            return InternalRequestAsync<DescribePolicyConfigResponse>(req, "DescribePolicyConfig");
        }

        /// <summary>
        /// 本接口（DescribePolicyConfig）可用于查询企业组织策略配置
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConfigRequest"/></param>
        /// <returns><see cref="DescribePolicyConfigResponse"/></returns>
        public DescribePolicyConfigResponse DescribePolicyConfigSync(DescribePolicyConfigRequest req)
        {
            return InternalRequestAsync<DescribePolicyConfigResponse>(req, "DescribePolicyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取可共享地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShareAreasRequest"/></param>
        /// <returns><see cref="DescribeShareAreasResponse"/></returns>
        public Task<DescribeShareAreasResponse> DescribeShareAreas(DescribeShareAreasRequest req)
        {
            return InternalRequestAsync<DescribeShareAreasResponse>(req, "DescribeShareAreas");
        }

        /// <summary>
        /// 获取可共享地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShareAreasRequest"/></param>
        /// <returns><see cref="DescribeShareAreasResponse"/></returns>
        public DescribeShareAreasResponse DescribeShareAreasSync(DescribeShareAreasRequest req)
        {
            return InternalRequestAsync<DescribeShareAreasResponse>(req, "DescribeShareAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取共享单元成员列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeShareUnitMembersRequest"/></param>
        /// <returns><see cref="DescribeShareUnitMembersResponse"/></returns>
        public Task<DescribeShareUnitMembersResponse> DescribeShareUnitMembers(DescribeShareUnitMembersRequest req)
        {
            return InternalRequestAsync<DescribeShareUnitMembersResponse>(req, "DescribeShareUnitMembers");
        }

        /// <summary>
        /// 获取共享单元成员列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeShareUnitMembersRequest"/></param>
        /// <returns><see cref="DescribeShareUnitMembersResponse"/></returns>
        public DescribeShareUnitMembersResponse DescribeShareUnitMembersSync(DescribeShareUnitMembersRequest req)
        {
            return InternalRequestAsync<DescribeShareUnitMembersResponse>(req, "DescribeShareUnitMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取共享单元资源列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeShareUnitResourcesRequest"/></param>
        /// <returns><see cref="DescribeShareUnitResourcesResponse"/></returns>
        public Task<DescribeShareUnitResourcesResponse> DescribeShareUnitResources(DescribeShareUnitResourcesRequest req)
        {
            return InternalRequestAsync<DescribeShareUnitResourcesResponse>(req, "DescribeShareUnitResources");
        }

        /// <summary>
        /// 获取共享单元资源列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeShareUnitResourcesRequest"/></param>
        /// <returns><see cref="DescribeShareUnitResourcesResponse"/></returns>
        public DescribeShareUnitResourcesResponse DescribeShareUnitResourcesSync(DescribeShareUnitResourcesRequest req)
        {
            return InternalRequestAsync<DescribeShareUnitResourcesResponse>(req, "DescribeShareUnitResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取共享单元列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeShareUnitsRequest"/></param>
        /// <returns><see cref="DescribeShareUnitsResponse"/></returns>
        public Task<DescribeShareUnitsResponse> DescribeShareUnits(DescribeShareUnitsRequest req)
        {
            return InternalRequestAsync<DescribeShareUnitsResponse>(req, "DescribeShareUnits");
        }

        /// <summary>
        /// 获取共享单元列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeShareUnitsRequest"/></param>
        /// <returns><see cref="DescribeShareUnitsResponse"/></returns>
        public DescribeShareUnitsResponse DescribeShareUnitsSync(DescribeShareUnitsRequest req)
        {
            return InternalRequestAsync<DescribeShareUnitsResponse>(req, "DescribeShareUnits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑策略
        /// </summary>
        /// <param name="req"><see cref="DetachPolicyRequest"/></param>
        /// <returns><see cref="DetachPolicyResponse"/></returns>
        public Task<DetachPolicyResponse> DetachPolicy(DetachPolicyRequest req)
        {
            return InternalRequestAsync<DetachPolicyResponse>(req, "DetachPolicy");
        }

        /// <summary>
        /// 解绑策略
        /// </summary>
        /// <param name="req"><see cref="DetachPolicyRequest"/></param>
        /// <returns><see cref="DetachPolicyResponse"/></returns>
        public DetachPolicyResponse DetachPolicySync(DetachPolicyRequest req)
        {
            return InternalRequestAsync<DetachPolicyResponse>(req, "DetachPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用策略类型
        /// </summary>
        /// <param name="req"><see cref="DisablePolicyTypeRequest"/></param>
        /// <returns><see cref="DisablePolicyTypeResponse"/></returns>
        public Task<DisablePolicyTypeResponse> DisablePolicyType(DisablePolicyTypeRequest req)
        {
            return InternalRequestAsync<DisablePolicyTypeResponse>(req, "DisablePolicyType");
        }

        /// <summary>
        /// 禁用策略类型
        /// </summary>
        /// <param name="req"><see cref="DisablePolicyTypeRequest"/></param>
        /// <returns><see cref="DisablePolicyTypeResponse"/></returns>
        public DisablePolicyTypeResponse DisablePolicyTypeSync(DisablePolicyTypeRequest req)
        {
            return InternalRequestAsync<DisablePolicyTypeResponse>(req, "DisablePolicyType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除权限配置在成员账号上的部署
        /// </summary>
        /// <param name="req"><see cref="DismantleRoleConfigurationRequest"/></param>
        /// <returns><see cref="DismantleRoleConfigurationResponse"/></returns>
        public Task<DismantleRoleConfigurationResponse> DismantleRoleConfiguration(DismantleRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DismantleRoleConfigurationResponse>(req, "DismantleRoleConfiguration");
        }

        /// <summary>
        /// 解除权限配置在成员账号上的部署
        /// </summary>
        /// <param name="req"><see cref="DismantleRoleConfigurationRequest"/></param>
        /// <returns><see cref="DismantleRoleConfigurationResponse"/></returns>
        public DismantleRoleConfigurationResponse DismantleRoleConfigurationSync(DismantleRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DismantleRoleConfigurationResponse>(req, "DismantleRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用策略类型
        /// </summary>
        /// <param name="req"><see cref="EnablePolicyTypeRequest"/></param>
        /// <returns><see cref="EnablePolicyTypeResponse"/></returns>
        public Task<EnablePolicyTypeResponse> EnablePolicyType(EnablePolicyTypeRequest req)
        {
            return InternalRequestAsync<EnablePolicyTypeResponse>(req, "EnablePolicyType");
        }

        /// <summary>
        /// 启用策略类型
        /// </summary>
        /// <param name="req"><see cref="EnablePolicyTypeRequest"/></param>
        /// <returns><see cref="EnablePolicyTypeResponse"/></returns>
        public EnablePolicyTypeResponse EnablePolicyTypeSync(EnablePolicyTypeRequest req)
        {
            return InternalRequestAsync<EnablePolicyTypeResponse>(req, "EnablePolicyType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SAML身份提供商配置信息
        /// </summary>
        /// <param name="req"><see cref="GetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="GetExternalSAMLIdentityProviderResponse"/></returns>
        public Task<GetExternalSAMLIdentityProviderResponse> GetExternalSAMLIdentityProvider(GetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<GetExternalSAMLIdentityProviderResponse>(req, "GetExternalSAMLIdentityProvider");
        }

        /// <summary>
        /// 查询SAML身份提供商配置信息
        /// </summary>
        /// <param name="req"><see cref="GetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="GetExternalSAMLIdentityProviderResponse"/></returns>
        public GetExternalSAMLIdentityProviderResponse GetExternalSAMLIdentityProviderSync(GetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<GetExternalSAMLIdentityProviderResponse>(req, "GetExternalSAMLIdentityProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组信息
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public Task<GetGroupResponse> GetGroup(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup");
        }

        /// <summary>
        /// 查询用户组信息
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public GetGroupResponse GetGroupSync(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户同步异步任务的状态
        /// </summary>
        /// <param name="req"><see cref="GetProvisioningTaskStatusRequest"/></param>
        /// <returns><see cref="GetProvisioningTaskStatusResponse"/></returns>
        public Task<GetProvisioningTaskStatusResponse> GetProvisioningTaskStatus(GetProvisioningTaskStatusRequest req)
        {
            return InternalRequestAsync<GetProvisioningTaskStatusResponse>(req, "GetProvisioningTaskStatus");
        }

        /// <summary>
        /// 查询用户同步异步任务的状态
        /// </summary>
        /// <param name="req"><see cref="GetProvisioningTaskStatusRequest"/></param>
        /// <returns><see cref="GetProvisioningTaskStatusResponse"/></returns>
        public GetProvisioningTaskStatusResponse GetProvisioningTaskStatusSync(GetProvisioningTaskStatusRequest req)
        {
            return InternalRequestAsync<GetProvisioningTaskStatusResponse>(req, "GetProvisioningTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询权限配置信息
        /// </summary>
        /// <param name="req"><see cref="GetRoleConfigurationRequest"/></param>
        /// <returns><see cref="GetRoleConfigurationResponse"/></returns>
        public Task<GetRoleConfigurationResponse> GetRoleConfiguration(GetRoleConfigurationRequest req)
        {
            return InternalRequestAsync<GetRoleConfigurationResponse>(req, "GetRoleConfiguration");
        }

        /// <summary>
        /// 查询权限配置信息
        /// </summary>
        /// <param name="req"><see cref="GetRoleConfigurationRequest"/></param>
        /// <returns><see cref="GetRoleConfigurationResponse"/></returns>
        public GetRoleConfigurationResponse GetRoleConfigurationSync(GetRoleConfigurationRequest req)
        {
            return InternalRequestAsync<GetRoleConfigurationResponse>(req, "GetRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取SCIM同步状态
        /// </summary>
        /// <param name="req"><see cref="GetSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="GetSCIMSynchronizationStatusResponse"/></returns>
        public Task<GetSCIMSynchronizationStatusResponse> GetSCIMSynchronizationStatus(GetSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<GetSCIMSynchronizationStatusResponse>(req, "GetSCIMSynchronizationStatus");
        }

        /// <summary>
        /// 获取SCIM同步状态
        /// </summary>
        /// <param name="req"><see cref="GetSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="GetSCIMSynchronizationStatusResponse"/></returns>
        public GetSCIMSynchronizationStatusResponse GetSCIMSynchronizationStatusSync(GetSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<GetSCIMSynchronizationStatusResponse>(req, "GetSCIMSynchronizationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询异步任务的状态
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public Task<GetTaskStatusResponse> GetTaskStatus(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus");
        }

        /// <summary>
        /// 查询异步任务的状态
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public GetTaskStatusResponse GetTaskStatusSync(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public Task<GetUserResponse> GetUser(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser");
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public GetUserResponse GetUserSync(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询CAM用户同步
        /// </summary>
        /// <param name="req"><see cref="GetUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="GetUserSyncProvisioningResponse"/></returns>
        public Task<GetUserSyncProvisioningResponse> GetUserSyncProvisioning(GetUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<GetUserSyncProvisioningResponse>(req, "GetUserSyncProvisioning");
        }

        /// <summary>
        /// 查询CAM用户同步
        /// </summary>
        /// <param name="req"><see cref="GetUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="GetUserSyncProvisioningResponse"/></returns>
        public GetUserSyncProvisioningResponse GetUserSyncProvisioningSync(GetUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<GetUserSyncProvisioningResponse>(req, "GetUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SAML服务提供商配置信息
        /// </summary>
        /// <param name="req"><see cref="GetZoneSAMLServiceProviderInfoRequest"/></param>
        /// <returns><see cref="GetZoneSAMLServiceProviderInfoResponse"/></returns>
        public Task<GetZoneSAMLServiceProviderInfoResponse> GetZoneSAMLServiceProviderInfo(GetZoneSAMLServiceProviderInfoRequest req)
        {
            return InternalRequestAsync<GetZoneSAMLServiceProviderInfoResponse>(req, "GetZoneSAMLServiceProviderInfo");
        }

        /// <summary>
        /// 查询SAML服务提供商配置信息
        /// </summary>
        /// <param name="req"><see cref="GetZoneSAMLServiceProviderInfoRequest"/></param>
        /// <returns><see cref="GetZoneSAMLServiceProviderInfoResponse"/></returns>
        public GetZoneSAMLServiceProviderInfoResponse GetZoneSAMLServiceProviderInfoSync(GetZoneSAMLServiceProviderInfoRequest req)
        {
            return InternalRequestAsync<GetZoneSAMLServiceProviderInfoResponse>(req, "GetZoneSAMLServiceProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询空间的统计信息
        /// </summary>
        /// <param name="req"><see cref="GetZoneStatisticsRequest"/></param>
        /// <returns><see cref="GetZoneStatisticsResponse"/></returns>
        public Task<GetZoneStatisticsResponse> GetZoneStatistics(GetZoneStatisticsRequest req)
        {
            return InternalRequestAsync<GetZoneStatisticsResponse>(req, "GetZoneStatistics");
        }

        /// <summary>
        /// 查询空间的统计信息
        /// </summary>
        /// <param name="req"><see cref="GetZoneStatisticsRequest"/></param>
        /// <returns><see cref="GetZoneStatisticsResponse"/></returns>
        public GetZoneStatisticsResponse GetZoneStatisticsSync(GetZoneStatisticsRequest req)
        {
            return InternalRequestAsync<GetZoneStatisticsResponse>(req, "GetZoneStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 邀请组织成员
        /// </summary>
        /// <param name="req"><see cref="InviteOrganizationMemberRequest"/></param>
        /// <returns><see cref="InviteOrganizationMemberResponse"/></returns>
        public Task<InviteOrganizationMemberResponse> InviteOrganizationMember(InviteOrganizationMemberRequest req)
        {
            return InternalRequestAsync<InviteOrganizationMemberResponse>(req, "InviteOrganizationMember");
        }

        /// <summary>
        /// 邀请组织成员
        /// </summary>
        /// <param name="req"><see cref="InviteOrganizationMemberRequest"/></param>
        /// <returns><see cref="InviteOrganizationMemberResponse"/></returns>
        public InviteOrganizationMemberResponse InviteOrganizationMemberSync(InviteOrganizationMemberRequest req)
        {
            return InternalRequestAsync<InviteOrganizationMemberResponse>(req, "InviteOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SAML签名证书列表
        /// </summary>
        /// <param name="req"><see cref="ListExternalSAMLIdPCertificatesRequest"/></param>
        /// <returns><see cref="ListExternalSAMLIdPCertificatesResponse"/></returns>
        public Task<ListExternalSAMLIdPCertificatesResponse> ListExternalSAMLIdPCertificates(ListExternalSAMLIdPCertificatesRequest req)
        {
            return InternalRequestAsync<ListExternalSAMLIdPCertificatesResponse>(req, "ListExternalSAMLIdPCertificates");
        }

        /// <summary>
        /// 查询SAML签名证书列表
        /// </summary>
        /// <param name="req"><see cref="ListExternalSAMLIdPCertificatesRequest"/></param>
        /// <returns><see cref="ListExternalSAMLIdPCertificatesResponse"/></returns>
        public ListExternalSAMLIdPCertificatesResponse ListExternalSAMLIdPCertificatesSync(ListExternalSAMLIdPCertificatesRequest req)
        {
            return InternalRequestAsync<ListExternalSAMLIdPCertificatesResponse>(req, "ListExternalSAMLIdPCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组中的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListGroupMembersRequest"/></param>
        /// <returns><see cref="ListGroupMembersResponse"/></returns>
        public Task<ListGroupMembersResponse> ListGroupMembers(ListGroupMembersRequest req)
        {
            return InternalRequestAsync<ListGroupMembersResponse>(req, "ListGroupMembers");
        }

        /// <summary>
        /// 查询用户组中的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListGroupMembersRequest"/></param>
        /// <returns><see cref="ListGroupMembersResponse"/></returns>
        public ListGroupMembersResponse ListGroupMembersSync(ListGroupMembersRequest req)
        {
            return InternalRequestAsync<ListGroupMembersResponse>(req, "ListGroupMembers")
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
        /// 查询用户加入的用户组
        /// </summary>
        /// <param name="req"><see cref="ListJoinedGroupsForUserRequest"/></param>
        /// <returns><see cref="ListJoinedGroupsForUserResponse"/></returns>
        public Task<ListJoinedGroupsForUserResponse> ListJoinedGroupsForUser(ListJoinedGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListJoinedGroupsForUserResponse>(req, "ListJoinedGroupsForUser");
        }

        /// <summary>
        /// 查询用户加入的用户组
        /// </summary>
        /// <param name="req"><see cref="ListJoinedGroupsForUserRequest"/></param>
        /// <returns><see cref="ListJoinedGroupsForUserResponse"/></returns>
        public ListJoinedGroupsForUserResponse ListJoinedGroupsForUserSync(ListJoinedGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListJoinedGroupsForUserResponse>(req, "ListJoinedGroupsForUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取成员标签检测不合规资源列表
        /// </summary>
        /// <param name="req"><see cref="ListNonCompliantResourceRequest"/></param>
        /// <returns><see cref="ListNonCompliantResourceResponse"/></returns>
        public Task<ListNonCompliantResourceResponse> ListNonCompliantResource(ListNonCompliantResourceRequest req)
        {
            return InternalRequestAsync<ListNonCompliantResourceResponse>(req, "ListNonCompliantResource");
        }

        /// <summary>
        /// 获取成员标签检测不合规资源列表
        /// </summary>
        /// <param name="req"><see cref="ListNonCompliantResourceRequest"/></param>
        /// <returns><see cref="ListNonCompliantResourceResponse"/></returns>
        public ListNonCompliantResourceResponse ListNonCompliantResourceSync(ListNonCompliantResourceRequest req)
        {
            return InternalRequestAsync<ListNonCompliantResourceResponse>(req, "ListNonCompliantResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集团服务委派管理员列表
        /// </summary>
        /// <param name="req"><see cref="ListOrgServiceAssignMemberRequest"/></param>
        /// <returns><see cref="ListOrgServiceAssignMemberResponse"/></returns>
        public Task<ListOrgServiceAssignMemberResponse> ListOrgServiceAssignMember(ListOrgServiceAssignMemberRequest req)
        {
            return InternalRequestAsync<ListOrgServiceAssignMemberResponse>(req, "ListOrgServiceAssignMember");
        }

        /// <summary>
        /// 获取集团服务委派管理员列表
        /// </summary>
        /// <param name="req"><see cref="ListOrgServiceAssignMemberRequest"/></param>
        /// <returns><see cref="ListOrgServiceAssignMemberResponse"/></returns>
        public ListOrgServiceAssignMemberResponse ListOrgServiceAssignMemberSync(ListOrgServiceAssignMemberRequest req)
        {
            return InternalRequestAsync<ListOrgServiceAssignMemberResponse>(req, "ListOrgServiceAssignMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取组织成员访问身份列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public Task<ListOrganizationIdentityResponse> ListOrganizationIdentity(ListOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<ListOrganizationIdentityResponse>(req, "ListOrganizationIdentity");
        }

        /// <summary>
        /// 获取组织成员访问身份列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public ListOrganizationIdentityResponse ListOrganizationIdentitySync(ListOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<ListOrganizationIdentityResponse>(req, "ListOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集团服务设置列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationServiceRequest"/></param>
        /// <returns><see cref="ListOrganizationServiceResponse"/></returns>
        public Task<ListOrganizationServiceResponse> ListOrganizationService(ListOrganizationServiceRequest req)
        {
            return InternalRequestAsync<ListOrganizationServiceResponse>(req, "ListOrganizationService");
        }

        /// <summary>
        /// 获取集团服务设置列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationServiceRequest"/></param>
        /// <returns><see cref="ListOrganizationServiceResponse"/></returns>
        public ListOrganizationServiceResponse ListOrganizationServiceSync(ListOrganizationServiceRequest req)
        {
            return InternalRequestAsync<ListOrganizationServiceResponse>(req, "ListOrganizationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取权限配置中的策略列表
        /// </summary>
        /// <param name="req"><see cref="ListPermissionPoliciesInRoleConfigurationRequest"/></param>
        /// <returns><see cref="ListPermissionPoliciesInRoleConfigurationResponse"/></returns>
        public Task<ListPermissionPoliciesInRoleConfigurationResponse> ListPermissionPoliciesInRoleConfiguration(ListPermissionPoliciesInRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ListPermissionPoliciesInRoleConfigurationResponse>(req, "ListPermissionPoliciesInRoleConfiguration");
        }

        /// <summary>
        /// 获取权限配置中的策略列表
        /// </summary>
        /// <param name="req"><see cref="ListPermissionPoliciesInRoleConfigurationRequest"/></param>
        /// <returns><see cref="ListPermissionPoliciesInRoleConfigurationResponse"/></returns>
        public ListPermissionPoliciesInRoleConfigurationResponse ListPermissionPoliciesInRoleConfigurationSync(ListPermissionPoliciesInRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ListPermissionPoliciesInRoleConfigurationResponse>(req, "ListPermissionPoliciesInRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListPolicies）可用于查询查看策略列表数据
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public Task<ListPoliciesResponse> ListPolicies(ListPoliciesRequest req)
        {
            return InternalRequestAsync<ListPoliciesResponse>(req, "ListPolicies");
        }

        /// <summary>
        /// 本接口（ListPolicies）可用于查询查看策略列表数据
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public ListPoliciesResponse ListPoliciesSync(ListPoliciesRequest req)
        {
            return InternalRequestAsync<ListPoliciesResponse>(req, "ListPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListPoliciesForTarget）查询目标关联的策略列表
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesForTargetRequest"/></param>
        /// <returns><see cref="ListPoliciesForTargetResponse"/></returns>
        public Task<ListPoliciesForTargetResponse> ListPoliciesForTarget(ListPoliciesForTargetRequest req)
        {
            return InternalRequestAsync<ListPoliciesForTargetResponse>(req, "ListPoliciesForTarget");
        }

        /// <summary>
        /// 本接口（ListPoliciesForTarget）查询目标关联的策略列表
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesForTargetRequest"/></param>
        /// <returns><see cref="ListPoliciesForTargetResponse"/></returns>
        public ListPoliciesForTargetResponse ListPoliciesForTargetSync(ListPoliciesForTargetRequest req)
        {
            return InternalRequestAsync<ListPoliciesForTargetResponse>(req, "ListPoliciesForTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询授权列表
        /// </summary>
        /// <param name="req"><see cref="ListRoleAssignmentsRequest"/></param>
        /// <returns><see cref="ListRoleAssignmentsResponse"/></returns>
        public Task<ListRoleAssignmentsResponse> ListRoleAssignments(ListRoleAssignmentsRequest req)
        {
            return InternalRequestAsync<ListRoleAssignmentsResponse>(req, "ListRoleAssignments");
        }

        /// <summary>
        /// 查询授权列表
        /// </summary>
        /// <param name="req"><see cref="ListRoleAssignmentsRequest"/></param>
        /// <returns><see cref="ListRoleAssignmentsResponse"/></returns>
        public ListRoleAssignmentsResponse ListRoleAssignmentsSync(ListRoleAssignmentsRequest req)
        {
            return InternalRequestAsync<ListRoleAssignmentsResponse>(req, "ListRoleAssignments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询权限配置部署列表
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationProvisioningsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationProvisioningsResponse"/></returns>
        public Task<ListRoleConfigurationProvisioningsResponse> ListRoleConfigurationProvisionings(ListRoleConfigurationProvisioningsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationProvisioningsResponse>(req, "ListRoleConfigurationProvisionings");
        }

        /// <summary>
        /// 查询权限配置部署列表
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationProvisioningsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationProvisioningsResponse"/></returns>
        public ListRoleConfigurationProvisioningsResponse ListRoleConfigurationProvisioningsSync(ListRoleConfigurationProvisioningsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationProvisioningsResponse>(req, "ListRoleConfigurationProvisionings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询权限配置列表
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationsResponse"/></returns>
        public Task<ListRoleConfigurationsResponse> ListRoleConfigurations(ListRoleConfigurationsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationsResponse>(req, "ListRoleConfigurations");
        }

        /// <summary>
        /// 查询权限配置列表
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationsResponse"/></returns>
        public ListRoleConfigurationsResponse ListRoleConfigurationsSync(ListRoleConfigurationsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationsResponse>(req, "ListRoleConfigurations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户SCIM密钥列表
        /// </summary>
        /// <param name="req"><see cref="ListSCIMCredentialsRequest"/></param>
        /// <returns><see cref="ListSCIMCredentialsResponse"/></returns>
        public Task<ListSCIMCredentialsResponse> ListSCIMCredentials(ListSCIMCredentialsRequest req)
        {
            return InternalRequestAsync<ListSCIMCredentialsResponse>(req, "ListSCIMCredentials");
        }

        /// <summary>
        /// 查询用户SCIM密钥列表
        /// </summary>
        /// <param name="req"><see cref="ListSCIMCredentialsRequest"/></param>
        /// <returns><see cref="ListSCIMCredentialsResponse"/></returns>
        public ListSCIMCredentialsResponse ListSCIMCredentialsSync(ListSCIMCredentialsRequest req)
        {
            return InternalRequestAsync<ListSCIMCredentialsResponse>(req, "ListSCIMCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListTargetsForPolicy）查询某个指定策略关联的目标列表
        /// </summary>
        /// <param name="req"><see cref="ListTargetsForPolicyRequest"/></param>
        /// <returns><see cref="ListTargetsForPolicyResponse"/></returns>
        public Task<ListTargetsForPolicyResponse> ListTargetsForPolicy(ListTargetsForPolicyRequest req)
        {
            return InternalRequestAsync<ListTargetsForPolicyResponse>(req, "ListTargetsForPolicy");
        }

        /// <summary>
        /// 本接口（ListTargetsForPolicy）查询某个指定策略关联的目标列表
        /// </summary>
        /// <param name="req"><see cref="ListTargetsForPolicyRequest"/></param>
        /// <returns><see cref="ListTargetsForPolicyResponse"/></returns>
        public ListTargetsForPolicyResponse ListTargetsForPolicySync(ListTargetsForPolicyRequest req)
        {
            return InternalRequestAsync<ListTargetsForPolicyResponse>(req, "ListTargetsForPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询异步任务列表
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public Task<ListTasksResponse> ListTasks(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks");
        }

        /// <summary>
        /// 查询异步任务列表
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public ListTasksResponse ListTasksSync(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询CAM用户同步列表
        /// </summary>
        /// <param name="req"><see cref="ListUserSyncProvisioningsRequest"/></param>
        /// <returns><see cref="ListUserSyncProvisioningsResponse"/></returns>
        public Task<ListUserSyncProvisioningsResponse> ListUserSyncProvisionings(ListUserSyncProvisioningsRequest req)
        {
            return InternalRequestAsync<ListUserSyncProvisioningsResponse>(req, "ListUserSyncProvisionings");
        }

        /// <summary>
        /// 查询CAM用户同步列表
        /// </summary>
        /// <param name="req"><see cref="ListUserSyncProvisioningsRequest"/></param>
        /// <returns><see cref="ListUserSyncProvisioningsResponse"/></returns>
        public ListUserSyncProvisioningsResponse ListUserSyncProvisioningsSync(ListUserSyncProvisioningsRequest req)
        {
            return InternalRequestAsync<ListUserSyncProvisioningsResponse>(req, "ListUserSyncProvisionings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public Task<ListUsersResponse> ListUsers(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers");
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public ListUsersResponse ListUsersSync(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移动成员到指定企业组织节点
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public Task<MoveOrganizationNodeMembersResponse> MoveOrganizationNodeMembers(MoveOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<MoveOrganizationNodeMembersResponse>(req, "MoveOrganizationNodeMembers");
        }

        /// <summary>
        /// 移动成员到指定企业组织节点
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public MoveOrganizationNodeMembersResponse MoveOrganizationNodeMembersSync(MoveOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<MoveOrganizationNodeMembersResponse>(req, "MoveOrganizationNodeMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通身份中心服务（CIC）
        /// </summary>
        /// <param name="req"><see cref="OpenIdentityCenterRequest"/></param>
        /// <returns><see cref="OpenIdentityCenterResponse"/></returns>
        public Task<OpenIdentityCenterResponse> OpenIdentityCenter(OpenIdentityCenterRequest req)
        {
            return InternalRequestAsync<OpenIdentityCenterResponse>(req, "OpenIdentityCenter");
        }

        /// <summary>
        /// 开通身份中心服务（CIC）
        /// </summary>
        /// <param name="req"><see cref="OpenIdentityCenterRequest"/></param>
        /// <returns><see cref="OpenIdentityCenterResponse"/></returns>
        public OpenIdentityCenterResponse OpenIdentityCenterSync(OpenIdentityCenterRequest req)
        {
            return InternalRequestAsync<OpenIdentityCenterResponse>(req, "OpenIdentityCenter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将权限配置部署到成员账号上
        /// </summary>
        /// <param name="req"><see cref="ProvisionRoleConfigurationRequest"/></param>
        /// <returns><see cref="ProvisionRoleConfigurationResponse"/></returns>
        public Task<ProvisionRoleConfigurationResponse> ProvisionRoleConfiguration(ProvisionRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ProvisionRoleConfigurationResponse>(req, "ProvisionRoleConfiguration");
        }

        /// <summary>
        /// 将权限配置部署到成员账号上
        /// </summary>
        /// <param name="req"><see cref="ProvisionRoleConfigurationRequest"/></param>
        /// <returns><see cref="ProvisionRoleConfigurationResponse"/></returns>
        public ProvisionRoleConfigurationResponse ProvisionRoleConfigurationSync(ProvisionRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ProvisionRoleConfigurationResponse>(req, "ProvisionRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 退出企业组织
        /// </summary>
        /// <param name="req"><see cref="QuitOrganizationRequest"/></param>
        /// <returns><see cref="QuitOrganizationResponse"/></returns>
        public Task<QuitOrganizationResponse> QuitOrganization(QuitOrganizationRequest req)
        {
            return InternalRequestAsync<QuitOrganizationResponse>(req, "QuitOrganization");
        }

        /// <summary>
        /// 退出企业组织
        /// </summary>
        /// <param name="req"><see cref="QuitOrganizationRequest"/></param>
        /// <returns><see cref="QuitOrganizationResponse"/></returns>
        public QuitOrganizationResponse QuitOrganizationSync(QuitOrganizationRequest req)
        {
            return InternalRequestAsync<QuitOrganizationResponse>(req, "QuitOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拒绝加入共享单元邀请。
        /// </summary>
        /// <param name="req"><see cref="RejectJoinShareUnitInvitationRequest"/></param>
        /// <returns><see cref="RejectJoinShareUnitInvitationResponse"/></returns>
        public Task<RejectJoinShareUnitInvitationResponse> RejectJoinShareUnitInvitation(RejectJoinShareUnitInvitationRequest req)
        {
            return InternalRequestAsync<RejectJoinShareUnitInvitationResponse>(req, "RejectJoinShareUnitInvitation");
        }

        /// <summary>
        /// 拒绝加入共享单元邀请。
        /// </summary>
        /// <param name="req"><see cref="RejectJoinShareUnitInvitationRequest"/></param>
        /// <returns><see cref="RejectJoinShareUnitInvitationResponse"/></returns>
        public RejectJoinShareUnitInvitationResponse RejectJoinShareUnitInvitationSync(RejectJoinShareUnitInvitationRequest req)
        {
            return InternalRequestAsync<RejectJoinShareUnitInvitationResponse>(req, "RejectJoinShareUnitInvitation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移除SAML签名证书
        /// </summary>
        /// <param name="req"><see cref="RemoveExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="RemoveExternalSAMLIdPCertificateResponse"/></returns>
        public Task<RemoveExternalSAMLIdPCertificateResponse> RemoveExternalSAMLIdPCertificate(RemoveExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<RemoveExternalSAMLIdPCertificateResponse>(req, "RemoveExternalSAMLIdPCertificate");
        }

        /// <summary>
        /// 移除SAML签名证书
        /// </summary>
        /// <param name="req"><see cref="RemoveExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="RemoveExternalSAMLIdPCertificateResponse"/></returns>
        public RemoveExternalSAMLIdPCertificateResponse RemoveExternalSAMLIdPCertificateSync(RemoveExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<RemoveExternalSAMLIdPCertificateResponse>(req, "RemoveExternalSAMLIdPCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为权限配置移除策略
        /// </summary>
        /// <param name="req"><see cref="RemovePermissionPolicyFromRoleConfigurationRequest"/></param>
        /// <returns><see cref="RemovePermissionPolicyFromRoleConfigurationResponse"/></returns>
        public Task<RemovePermissionPolicyFromRoleConfigurationResponse> RemovePermissionPolicyFromRoleConfiguration(RemovePermissionPolicyFromRoleConfigurationRequest req)
        {
            return InternalRequestAsync<RemovePermissionPolicyFromRoleConfigurationResponse>(req, "RemovePermissionPolicyFromRoleConfiguration");
        }

        /// <summary>
        /// 为权限配置移除策略
        /// </summary>
        /// <param name="req"><see cref="RemovePermissionPolicyFromRoleConfigurationRequest"/></param>
        /// <returns><see cref="RemovePermissionPolicyFromRoleConfigurationResponse"/></returns>
        public RemovePermissionPolicyFromRoleConfigurationResponse RemovePermissionPolicyFromRoleConfigurationSync(RemovePermissionPolicyFromRoleConfigurationRequest req)
        {
            return InternalRequestAsync<RemovePermissionPolicyFromRoleConfigurationResponse>(req, "RemovePermissionPolicyFromRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从用户组中移除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public Task<RemoveUserFromGroupResponse> RemoveUserFromGroup(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup");
        }

        /// <summary>
        /// 从用户组中移除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroupSync(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新发送成员绑定邮箱激活邮件
        /// </summary>
        /// <param name="req"><see cref="SendOrgMemberAccountBindEmailRequest"/></param>
        /// <returns><see cref="SendOrgMemberAccountBindEmailResponse"/></returns>
        public Task<SendOrgMemberAccountBindEmailResponse> SendOrgMemberAccountBindEmail(SendOrgMemberAccountBindEmailRequest req)
        {
            return InternalRequestAsync<SendOrgMemberAccountBindEmailResponse>(req, "SendOrgMemberAccountBindEmail");
        }

        /// <summary>
        /// 重新发送成员绑定邮箱激活邮件
        /// </summary>
        /// <param name="req"><see cref="SendOrgMemberAccountBindEmailRequest"/></param>
        /// <returns><see cref="SendOrgMemberAccountBindEmailResponse"/></returns>
        public SendOrgMemberAccountBindEmailResponse SendOrgMemberAccountBindEmailSync(SendOrgMemberAccountBindEmailRequest req)
        {
            return InternalRequestAsync<SendOrgMemberAccountBindEmailResponse>(req, "SendOrgMemberAccountBindEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置SAML身份提供商信息
        /// </summary>
        /// <param name="req"><see cref="SetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="SetExternalSAMLIdentityProviderResponse"/></returns>
        public Task<SetExternalSAMLIdentityProviderResponse> SetExternalSAMLIdentityProvider(SetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<SetExternalSAMLIdentityProviderResponse>(req, "SetExternalSAMLIdentityProvider");
        }

        /// <summary>
        /// 配置SAML身份提供商信息
        /// </summary>
        /// <param name="req"><see cref="SetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="SetExternalSAMLIdentityProviderResponse"/></returns>
        public SetExternalSAMLIdentityProviderResponse SetExternalSAMLIdentityProviderSync(SetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<SetExternalSAMLIdentityProviderResponse>(req, "SetExternalSAMLIdentityProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为权限配置修改自定义策略
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomPolicyForRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateCustomPolicyForRoleConfigurationResponse"/></returns>
        public Task<UpdateCustomPolicyForRoleConfigurationResponse> UpdateCustomPolicyForRoleConfiguration(UpdateCustomPolicyForRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateCustomPolicyForRoleConfigurationResponse>(req, "UpdateCustomPolicyForRoleConfiguration");
        }

        /// <summary>
        /// 为权限配置修改自定义策略
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomPolicyForRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateCustomPolicyForRoleConfigurationResponse"/></returns>
        public UpdateCustomPolicyForRoleConfigurationResponse UpdateCustomPolicyForRoleConfigurationSync(UpdateCustomPolicyForRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateCustomPolicyForRoleConfigurationResponse>(req, "UpdateCustomPolicyForRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户组信息
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public Task<UpdateGroupResponse> UpdateGroup(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup");
        }

        /// <summary>
        /// 修改用户组信息
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public UpdateGroupResponse UpdateGroupSync(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新组织身份
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="UpdateOrganizationIdentityResponse"/></returns>
        public Task<UpdateOrganizationIdentityResponse> UpdateOrganizationIdentity(UpdateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationIdentityResponse>(req, "UpdateOrganizationIdentity");
        }

        /// <summary>
        /// 更新组织身份
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="UpdateOrganizationIdentityResponse"/></returns>
        public UpdateOrganizationIdentityResponse UpdateOrganizationIdentitySync(UpdateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationIdentityResponse>(req, "UpdateOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新组织成员信息
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberResponse"/></returns>
        public Task<UpdateOrganizationMemberResponse> UpdateOrganizationMember(UpdateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberResponse>(req, "UpdateOrganizationMember");
        }

        /// <summary>
        /// 更新组织成员信息
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberResponse"/></returns>
        public UpdateOrganizationMemberResponse UpdateOrganizationMemberSync(UpdateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberResponse>(req, "UpdateOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改绑定成员邮箱
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberEmailBindRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberEmailBindResponse"/></returns>
        public Task<UpdateOrganizationMemberEmailBindResponse> UpdateOrganizationMemberEmailBind(UpdateOrganizationMemberEmailBindRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberEmailBindResponse>(req, "UpdateOrganizationMemberEmailBind");
        }

        /// <summary>
        /// 修改绑定成员邮箱
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberEmailBindRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberEmailBindResponse"/></returns>
        public UpdateOrganizationMemberEmailBindResponse UpdateOrganizationMemberEmailBindSync(UpdateOrganizationMemberEmailBindRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberEmailBindResponse>(req, "UpdateOrganizationMemberEmailBind")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改组织成员访问策略
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMembersPolicyResponse"/></returns>
        public Task<UpdateOrganizationMembersPolicyResponse> UpdateOrganizationMembersPolicy(UpdateOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMembersPolicyResponse>(req, "UpdateOrganizationMembersPolicy");
        }

        /// <summary>
        /// 修改组织成员访问策略
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMembersPolicyResponse"/></returns>
        public UpdateOrganizationMembersPolicyResponse UpdateOrganizationMembersPolicySync(UpdateOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMembersPolicyResponse>(req, "UpdateOrganizationMembersPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新企业组织节点
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public Task<UpdateOrganizationNodeResponse> UpdateOrganizationNode(UpdateOrganizationNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationNodeResponse>(req, "UpdateOrganizationNode");
        }

        /// <summary>
        /// 更新企业组织节点
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public UpdateOrganizationNodeResponse UpdateOrganizationNodeSync(UpdateOrganizationNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationNodeResponse>(req, "UpdateOrganizationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑策略
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public Task<UpdatePolicyResponse> UpdatePolicy(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy");
        }

        /// <summary>
        /// 编辑策略
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public UpdatePolicyResponse UpdatePolicySync(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改权限配置信息
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRoleConfigurationResponse"/></returns>
        public Task<UpdateRoleConfigurationResponse> UpdateRoleConfiguration(UpdateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateRoleConfigurationResponse>(req, "UpdateRoleConfiguration");
        }

        /// <summary>
        /// 修改权限配置信息
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRoleConfigurationResponse"/></returns>
        public UpdateRoleConfigurationResponse UpdateRoleConfigurationSync(UpdateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateRoleConfigurationResponse>(req, "UpdateRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用/禁用SCIM密钥
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMCredentialStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMCredentialStatusResponse"/></returns>
        public Task<UpdateSCIMCredentialStatusResponse> UpdateSCIMCredentialStatus(UpdateSCIMCredentialStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMCredentialStatusResponse>(req, "UpdateSCIMCredentialStatus");
        }

        /// <summary>
        /// 启用/禁用SCIM密钥
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMCredentialStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMCredentialStatusResponse"/></returns>
        public UpdateSCIMCredentialStatusResponse UpdateSCIMCredentialStatusSync(UpdateSCIMCredentialStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMCredentialStatusResponse>(req, "UpdateSCIMCredentialStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用/禁用用户SCIM同步
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMSynchronizationStatusResponse"/></returns>
        public Task<UpdateSCIMSynchronizationStatusResponse> UpdateSCIMSynchronizationStatus(UpdateSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMSynchronizationStatusResponse>(req, "UpdateSCIMSynchronizationStatus");
        }

        /// <summary>
        /// 启用/禁用用户SCIM同步
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMSynchronizationStatusResponse"/></returns>
        public UpdateSCIMSynchronizationStatusResponse UpdateSCIMSynchronizationStatusSync(UpdateSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMSynchronizationStatusResponse>(req, "UpdateSCIMSynchronizationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新共享单元。
        /// </summary>
        /// <param name="req"><see cref="UpdateShareUnitRequest"/></param>
        /// <returns><see cref="UpdateShareUnitResponse"/></returns>
        public Task<UpdateShareUnitResponse> UpdateShareUnit(UpdateShareUnitRequest req)
        {
            return InternalRequestAsync<UpdateShareUnitResponse>(req, "UpdateShareUnit");
        }

        /// <summary>
        /// 更新共享单元。
        /// </summary>
        /// <param name="req"><see cref="UpdateShareUnitRequest"/></param>
        /// <returns><see cref="UpdateShareUnitResponse"/></returns>
        public UpdateShareUnitResponse UpdateShareUnitSync(UpdateShareUnitRequest req)
        {
            return InternalRequestAsync<UpdateShareUnitResponse>(req, "UpdateShareUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser");
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public Task<UpdateUserStatusResponse> UpdateUserStatus(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus");
        }

        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public UpdateUserStatusResponse UpdateUserStatusSync(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建子用户同步任务
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="UpdateUserSyncProvisioningResponse"/></returns>
        public Task<UpdateUserSyncProvisioningResponse> UpdateUserSyncProvisioning(UpdateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<UpdateUserSyncProvisioningResponse>(req, "UpdateUserSyncProvisioning");
        }

        /// <summary>
        /// 创建子用户同步任务
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="UpdateUserSyncProvisioningResponse"/></returns>
        public UpdateUserSyncProvisioningResponse UpdateUserSyncProvisioningSync(UpdateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<UpdateUserSyncProvisioningResponse>(req, "UpdateUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户空间名
        /// </summary>
        /// <param name="req"><see cref="UpdateZoneRequest"/></param>
        /// <returns><see cref="UpdateZoneResponse"/></returns>
        public Task<UpdateZoneResponse> UpdateZone(UpdateZoneRequest req)
        {
            return InternalRequestAsync<UpdateZoneResponse>(req, "UpdateZone");
        }

        /// <summary>
        /// 更新用户空间名
        /// </summary>
        /// <param name="req"><see cref="UpdateZoneRequest"/></param>
        /// <returns><see cref="UpdateZoneResponse"/></returns>
        public UpdateZoneResponse UpdateZoneSync(UpdateZoneRequest req)
        {
            return InternalRequestAsync<UpdateZoneResponse>(req, "UpdateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
