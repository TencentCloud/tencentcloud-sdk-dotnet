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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OrganizationClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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
        /// 批量删除企业组织成员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public Task<DeleteOrganizationMembersResponse> DeleteOrganizationMembers(DeleteOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersResponse>(req, "DeleteOrganizationMembers");
        }

        /// <summary>
        /// 批量删除企业组织成员
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

    }
}
