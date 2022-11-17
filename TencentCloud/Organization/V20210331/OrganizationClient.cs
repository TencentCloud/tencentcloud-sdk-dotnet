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
        /// 添加企业组织节点
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public async Task<AddOrganizationNodeResponse> AddOrganizationNode(AddOrganizationNodeRequest req)
        {
             JsonResponseModel<AddOrganizationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddOrganizationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddOrganizationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加企业组织节点
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public AddOrganizationNodeResponse AddOrganizationNodeSync(AddOrganizationNodeRequest req)
        {
             JsonResponseModel<AddOrganizationNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddOrganizationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddOrganizationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定组织成员和组织管理员子账号的授权关系
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public async Task<BindOrganizationMemberAuthAccountResponse> BindOrganizationMemberAuthAccount(BindOrganizationMemberAuthAccountRequest req)
        {
             JsonResponseModel<BindOrganizationMemberAuthAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindOrganizationMemberAuthAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindOrganizationMemberAuthAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定组织成员和组织管理员子账号的授权关系
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public BindOrganizationMemberAuthAccountResponse BindOrganizationMemberAuthAccountSync(BindOrganizationMemberAuthAccountRequest req)
        {
             JsonResponseModel<BindOrganizationMemberAuthAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindOrganizationMemberAuthAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindOrganizationMemberAuthAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消组织成员和子账号的授权绑定关系
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public async Task<CancelOrganizationMemberAuthAccountResponse> CancelOrganizationMemberAuthAccount(CancelOrganizationMemberAuthAccountRequest req)
        {
             JsonResponseModel<CancelOrganizationMemberAuthAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelOrganizationMemberAuthAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelOrganizationMemberAuthAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消组织成员和子账号的授权绑定关系
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public CancelOrganizationMemberAuthAccountResponse CancelOrganizationMemberAuthAccountSync(CancelOrganizationMemberAuthAccountRequest req)
        {
             JsonResponseModel<CancelOrganizationMemberAuthAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelOrganizationMemberAuthAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelOrganizationMemberAuthAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建组织成员
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public async Task<CreateOrganizationMemberResponse> CreateOrganizationMember(CreateOrganizationMemberRequest req)
        {
             JsonResponseModel<CreateOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建组织成员
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public CreateOrganizationMemberResponse CreateOrganizationMemberSync(CreateOrganizationMemberRequest req)
        {
             JsonResponseModel<CreateOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建组织成员访问授权策略
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public async Task<CreateOrganizationMemberPolicyResponse> CreateOrganizationMemberPolicy(CreateOrganizationMemberPolicyRequest req)
        {
             JsonResponseModel<CreateOrganizationMemberPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrganizationMemberPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationMemberPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建组织成员访问授权策略
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public CreateOrganizationMemberPolicyResponse CreateOrganizationMemberPolicySync(CreateOrganizationMemberPolicyRequest req)
        {
             JsonResponseModel<CreateOrganizationMemberPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrganizationMemberPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationMemberPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除企业组织成员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public async Task<DeleteOrganizationMembersResponse> DeleteOrganizationMembers(DeleteOrganizationMembersRequest req)
        {
             JsonResponseModel<DeleteOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除企业组织成员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public DeleteOrganizationMembersResponse DeleteOrganizationMembersSync(DeleteOrganizationMembersRequest req)
        {
             JsonResponseModel<DeleteOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除企业组织节点
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public async Task<DeleteOrganizationNodesResponse> DeleteOrganizationNodes(DeleteOrganizationNodesRequest req)
        {
             JsonResponseModel<DeleteOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除企业组织节点
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public DeleteOrganizationNodesResponse DeleteOrganizationNodesSync(DeleteOrganizationNodesRequest req)
        {
             JsonResponseModel<DeleteOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public async Task<DescribeOrganizationResponse> DescribeOrganization(DescribeOrganizationRequest req)
        {
             JsonResponseModel<DescribeOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public DescribeOrganizationResponse DescribeOrganizationSync(DescribeOrganizationRequest req)
        {
             JsonResponseModel<DescribeOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取可创建组织成员的认证主体关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationAuthNodeRequest"/></param>
        /// <returns><see cref="DescribeOrganizationAuthNodeResponse"/></returns>
        public async Task<DescribeOrganizationAuthNodeResponse> DescribeOrganizationAuthNode(DescribeOrganizationAuthNodeRequest req)
        {
             JsonResponseModel<DescribeOrganizationAuthNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationAuthNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationAuthNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取可创建组织成员的认证主体关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationAuthNodeRequest"/></param>
        /// <returns><see cref="DescribeOrganizationAuthNodeResponse"/></returns>
        public DescribeOrganizationAuthNodeResponse DescribeOrganizationAuthNodeSync(DescribeOrganizationAuthNodeRequest req)
        {
             JsonResponseModel<DescribeOrganizationAuthNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationAuthNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationAuthNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员被绑定的子账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public async Task<DescribeOrganizationMemberAuthAccountsResponse> DescribeOrganizationMemberAuthAccounts(DescribeOrganizationMemberAuthAccountsRequest req)
        {
             JsonResponseModel<DescribeOrganizationMemberAuthAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationMemberAuthAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMemberAuthAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员被绑定的子账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public DescribeOrganizationMemberAuthAccountsResponse DescribeOrganizationMemberAuthAccountsSync(DescribeOrganizationMemberAuthAccountsRequest req)
        {
             JsonResponseModel<DescribeOrganizationMemberAuthAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationMemberAuthAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMemberAuthAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员可被管理的身份列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public async Task<DescribeOrganizationMemberAuthIdentitiesResponse> DescribeOrganizationMemberAuthIdentities(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
             JsonResponseModel<DescribeOrganizationMemberAuthIdentitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationMemberAuthIdentities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMemberAuthIdentitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员可被管理的身份列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public DescribeOrganizationMemberAuthIdentitiesResponse DescribeOrganizationMemberAuthIdentitiesSync(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
             JsonResponseModel<DescribeOrganizationMemberAuthIdentitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationMemberAuthIdentities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMemberAuthIdentitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员的授权策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public async Task<DescribeOrganizationMemberPoliciesResponse> DescribeOrganizationMemberPolicies(DescribeOrganizationMemberPoliciesRequest req)
        {
             JsonResponseModel<DescribeOrganizationMemberPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationMemberPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMemberPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员的授权策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public DescribeOrganizationMemberPoliciesResponse DescribeOrganizationMemberPoliciesSync(DescribeOrganizationMemberPoliciesRequest req)
        {
             JsonResponseModel<DescribeOrganizationMemberPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationMemberPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMemberPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public async Task<DescribeOrganizationMembersResponse> DescribeOrganizationMembers(DescribeOrganizationMembersRequest req)
        {
             JsonResponseModel<DescribeOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public DescribeOrganizationMembersResponse DescribeOrganizationMembersSync(DescribeOrganizationMembersRequest req)
        {
             JsonResponseModel<DescribeOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public async Task<DescribeOrganizationNodesResponse> DescribeOrganizationNodes(DescribeOrganizationNodesRequest req)
        {
             JsonResponseModel<DescribeOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public DescribeOrganizationNodesResponse DescribeOrganizationNodesSync(DescribeOrganizationNodesRequest req)
        {
             JsonResponseModel<DescribeOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员访问身份列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public async Task<ListOrganizationIdentityResponse> ListOrganizationIdentity(ListOrganizationIdentityRequest req)
        {
             JsonResponseModel<ListOrganizationIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组织成员访问身份列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public ListOrganizationIdentityResponse ListOrganizationIdentitySync(ListOrganizationIdentityRequest req)
        {
             JsonResponseModel<ListOrganizationIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListOrganizationIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动成员到指定企业组织节点
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public async Task<MoveOrganizationNodeMembersResponse> MoveOrganizationNodeMembers(MoveOrganizationNodeMembersRequest req)
        {
             JsonResponseModel<MoveOrganizationNodeMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MoveOrganizationNodeMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveOrganizationNodeMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动成员到指定企业组织节点
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public MoveOrganizationNodeMembersResponse MoveOrganizationNodeMembersSync(MoveOrganizationNodeMembersRequest req)
        {
             JsonResponseModel<MoveOrganizationNodeMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MoveOrganizationNodeMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveOrganizationNodeMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新企业组织节点
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public async Task<UpdateOrganizationNodeResponse> UpdateOrganizationNode(UpdateOrganizationNodeRequest req)
        {
             JsonResponseModel<UpdateOrganizationNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOrganizationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新企业组织节点
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public UpdateOrganizationNodeResponse UpdateOrganizationNodeSync(UpdateOrganizationNodeRequest req)
        {
             JsonResponseModel<UpdateOrganizationNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateOrganizationNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
