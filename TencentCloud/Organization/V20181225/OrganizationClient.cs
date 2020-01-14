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

namespace TencentCloud.Organization.V20181225
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Organization.V20181225.Models;

   public class OrganizationClient : AbstractClient{

       private const string endpoint = "organization.tencentcloudapi.com";
       private const string version = "2018-12-25";

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
        /// 接受加入企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="AcceptOrganizationInvitationRequest"/></param>
        /// <returns><see cref="AcceptOrganizationInvitationResponse"/></returns>
        public async Task<AcceptOrganizationInvitationResponse> AcceptOrganizationInvitation(AcceptOrganizationInvitationRequest req)
        {
             JsonResponseModel<AcceptOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AcceptOrganizationInvitation接口的同步版本，接受加入企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="AcceptOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="AcceptOrganizationInvitationResponse"/>实例</returns>
        public AcceptOrganizationInvitationResponse AcceptOrganizationInvitationSync(AcceptOrganizationInvitationRequest req)
        {
             JsonResponseModel<AcceptOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcceptOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加企业组织单元
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
        /// AddOrganizationNode接口的同步版本，添加企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="AddOrganizationNodeRequest"/></param>
        /// <returns>参考<see cref="AddOrganizationNodeResponse"/>实例</returns>
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
        /// 取消企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationInvitationRequest"/></param>
        /// <returns><see cref="CancelOrganizationInvitationResponse"/></returns>
        public async Task<CancelOrganizationInvitationResponse> CancelOrganizationInvitation(CancelOrganizationInvitationRequest req)
        {
             JsonResponseModel<CancelOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CancelOrganizationInvitation接口的同步版本，取消企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="CancelOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="CancelOrganizationInvitationResponse"/>实例</returns>
        public CancelOrganizationInvitationResponse CancelOrganizationInvitationSync(CancelOrganizationInvitationRequest req)
        {
             JsonResponseModel<CancelOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建企业组织
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationRequest"/></param>
        /// <returns><see cref="CreateOrganizationResponse"/></returns>
        public async Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest req)
        {
             JsonResponseModel<CreateOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateOrganization接口的同步版本，创建企业组织
        /// </summary>
        /// <param name="req">参考<see cref="CreateOrganizationRequest"/></param>
        /// <returns>参考<see cref="CreateOrganizationResponse"/>实例</returns>
        public CreateOrganizationResponse CreateOrganizationSync(CreateOrganizationRequest req)
        {
             JsonResponseModel<CreateOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除企业组织
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public async Task<DeleteOrganizationResponse> DeleteOrganization(DeleteOrganizationRequest req)
        {
             JsonResponseModel<DeleteOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteOrganization接口的同步版本，删除企业组织
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationResponse"/>实例</returns>
        public DeleteOrganizationResponse DeleteOrganizationSync(DeleteOrganizationRequest req)
        {
             JsonResponseModel<DeleteOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除企业组织成员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMemberFromNodeRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMemberFromNodeResponse"/></returns>
        public async Task<DeleteOrganizationMemberFromNodeResponse> DeleteOrganizationMemberFromNode(DeleteOrganizationMemberFromNodeRequest req)
        {
             JsonResponseModel<DeleteOrganizationMemberFromNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganizationMemberFromNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationMemberFromNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteOrganizationMemberFromNode接口的同步版本，删除企业组织成员
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationMemberFromNodeRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationMemberFromNodeResponse"/>实例</returns>
        public DeleteOrganizationMemberFromNodeResponse DeleteOrganizationMemberFromNodeSync(DeleteOrganizationMemberFromNodeRequest req)
        {
             JsonResponseModel<DeleteOrganizationMemberFromNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOrganizationMemberFromNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationMemberFromNodeResponse>>(strResp);
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
        /// DeleteOrganizationMembers接口的同步版本，批量删除企业组织成员
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationMembersResponse"/>实例</returns>
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
        /// 批量删除企业组织单元
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
        /// DeleteOrganizationNodes接口的同步版本，批量删除企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns>参考<see cref="DeleteOrganizationNodesResponse"/>实例</returns>
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
        /// 拒绝企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="DenyOrganizationInvitationRequest"/></param>
        /// <returns><see cref="DenyOrganizationInvitationResponse"/></returns>
        public async Task<DenyOrganizationInvitationResponse> DenyOrganizationInvitation(DenyOrganizationInvitationRequest req)
        {
             JsonResponseModel<DenyOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DenyOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DenyOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DenyOrganizationInvitation接口的同步版本，拒绝企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="DenyOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="DenyOrganizationInvitationResponse"/>实例</returns>
        public DenyOrganizationInvitationResponse DenyOrganizationInvitationSync(DenyOrganizationInvitationRequest req)
        {
             JsonResponseModel<DenyOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DenyOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DenyOrganizationInvitationResponse>>(strResp);
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
        /// <param name="req"><see cref="GetOrganizationRequest"/></param>
        /// <returns><see cref="GetOrganizationResponse"/></returns>
        public async Task<GetOrganizationResponse> GetOrganization(GetOrganizationRequest req)
        {
             JsonResponseModel<GetOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetOrganization接口的同步版本，获取企业组织信息
        /// </summary>
        /// <param name="req">参考<see cref="GetOrganizationRequest"/></param>
        /// <returns>参考<see cref="GetOrganizationResponse"/>实例</returns>
        public GetOrganizationResponse GetOrganizationSync(GetOrganizationRequest req)
        {
             JsonResponseModel<GetOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织成员
        /// </summary>
        /// <param name="req"><see cref="GetOrganizationMemberRequest"/></param>
        /// <returns><see cref="GetOrganizationMemberResponse"/></returns>
        public async Task<GetOrganizationMemberResponse> GetOrganizationMember(GetOrganizationMemberRequest req)
        {
             JsonResponseModel<GetOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetOrganizationMember接口的同步版本，获取企业组织成员
        /// </summary>
        /// <param name="req">参考<see cref="GetOrganizationMemberRequest"/></param>
        /// <returns>参考<see cref="GetOrganizationMemberResponse"/>实例</returns>
        public GetOrganizationMemberResponse GetOrganizationMemberSync(GetOrganizationMemberRequest req)
        {
             JsonResponseModel<GetOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取邀请信息列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationInvitationsRequest"/></param>
        /// <returns><see cref="ListOrganizationInvitationsResponse"/></returns>
        public async Task<ListOrganizationInvitationsResponse> ListOrganizationInvitations(ListOrganizationInvitationsRequest req)
        {
             JsonResponseModel<ListOrganizationInvitationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationInvitations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationInvitationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListOrganizationInvitations接口的同步版本，获取邀请信息列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationInvitationsRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationInvitationsResponse"/>实例</returns>
        public ListOrganizationInvitationsResponse ListOrganizationInvitationsSync(ListOrganizationInvitationsRequest req)
        {
             JsonResponseModel<ListOrganizationInvitationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListOrganizationInvitations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationInvitationsResponse>>(strResp);
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
        /// <param name="req"><see cref="ListOrganizationMembersRequest"/></param>
        /// <returns><see cref="ListOrganizationMembersResponse"/></returns>
        public async Task<ListOrganizationMembersResponse> ListOrganizationMembers(ListOrganizationMembersRequest req)
        {
             JsonResponseModel<ListOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListOrganizationMembers接口的同步版本，获取企业组织成员列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationMembersRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationMembersResponse"/>实例</returns>
        public ListOrganizationMembersResponse ListOrganizationMembersSync(ListOrganizationMembersRequest req)
        {
             JsonResponseModel<ListOrganizationMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListOrganizationMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织单元成员列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="ListOrganizationNodeMembersResponse"/></returns>
        public async Task<ListOrganizationNodeMembersResponse> ListOrganizationNodeMembers(ListOrganizationNodeMembersRequest req)
        {
             JsonResponseModel<ListOrganizationNodeMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationNodeMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationNodeMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListOrganizationNodeMembers接口的同步版本，获取企业组织单元成员列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationNodeMembersRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationNodeMembersResponse"/>实例</returns>
        public ListOrganizationNodeMembersResponse ListOrganizationNodeMembersSync(ListOrganizationNodeMembersRequest req)
        {
             JsonResponseModel<ListOrganizationNodeMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListOrganizationNodeMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationNodeMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企业组织单元列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationNodesRequest"/></param>
        /// <returns><see cref="ListOrganizationNodesResponse"/></returns>
        public async Task<ListOrganizationNodesResponse> ListOrganizationNodes(ListOrganizationNodesRequest req)
        {
             JsonResponseModel<ListOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListOrganizationNodes接口的同步版本，获取企业组织单元列表
        /// </summary>
        /// <param name="req">参考<see cref="ListOrganizationNodesRequest"/></param>
        /// <returns>参考<see cref="ListOrganizationNodesResponse"/>实例</returns>
        public ListOrganizationNodesResponse ListOrganizationNodesSync(ListOrganizationNodesRequest req)
        {
             JsonResponseModel<ListOrganizationNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListOrganizationNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动成员到指定企业组织单元
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationMembersToNodeRequest"/></param>
        /// <returns><see cref="MoveOrganizationMembersToNodeResponse"/></returns>
        public async Task<MoveOrganizationMembersToNodeResponse> MoveOrganizationMembersToNode(MoveOrganizationMembersToNodeRequest req)
        {
             JsonResponseModel<MoveOrganizationMembersToNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MoveOrganizationMembersToNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveOrganizationMembersToNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// MoveOrganizationMembersToNode接口的同步版本，移动成员到指定企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="MoveOrganizationMembersToNodeRequest"/></param>
        /// <returns>参考<see cref="MoveOrganizationMembersToNodeResponse"/>实例</returns>
        public MoveOrganizationMembersToNodeResponse MoveOrganizationMembersToNodeSync(MoveOrganizationMembersToNodeRequest req)
        {
             JsonResponseModel<MoveOrganizationMembersToNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MoveOrganizationMembersToNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveOrganizationMembersToNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 退出企业组织
        /// </summary>
        /// <param name="req"><see cref="QuitOrganizationRequest"/></param>
        /// <returns><see cref="QuitOrganizationResponse"/></returns>
        public async Task<QuitOrganizationResponse> QuitOrganization(QuitOrganizationRequest req)
        {
             JsonResponseModel<QuitOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QuitOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuitOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// QuitOrganization接口的同步版本，退出企业组织
        /// </summary>
        /// <param name="req">参考<see cref="QuitOrganizationRequest"/></param>
        /// <returns>参考<see cref="QuitOrganizationResponse"/>实例</returns>
        public QuitOrganizationResponse QuitOrganizationSync(QuitOrganizationRequest req)
        {
             JsonResponseModel<QuitOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QuitOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuitOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="SendOrganizationInvitationRequest"/></param>
        /// <returns><see cref="SendOrganizationInvitationResponse"/></returns>
        public async Task<SendOrganizationInvitationResponse> SendOrganizationInvitation(SendOrganizationInvitationRequest req)
        {
             JsonResponseModel<SendOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SendOrganizationInvitation接口的同步版本，发送企业组织邀请
        /// </summary>
        /// <param name="req">参考<see cref="SendOrganizationInvitationRequest"/></param>
        /// <returns>参考<see cref="SendOrganizationInvitationResponse"/>实例</returns>
        public SendOrganizationInvitationResponse SendOrganizationInvitationSync(SendOrganizationInvitationRequest req)
        {
             JsonResponseModel<SendOrganizationInvitationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendOrganizationInvitation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendOrganizationInvitationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新企业成员信息
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberResponse"/></returns>
        public async Task<UpdateOrganizationMemberResponse> UpdateOrganizationMember(UpdateOrganizationMemberRequest req)
        {
             JsonResponseModel<UpdateOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateOrganizationMember接口的同步版本，更新企业成员信息
        /// </summary>
        /// <param name="req">参考<see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns>参考<see cref="UpdateOrganizationMemberResponse"/>实例</returns>
        public UpdateOrganizationMemberResponse UpdateOrganizationMemberSync(UpdateOrganizationMemberRequest req)
        {
             JsonResponseModel<UpdateOrganizationMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateOrganizationMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新企业组织单元
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
        /// UpdateOrganizationNode接口的同步版本，更新企业组织单元
        /// </summary>
        /// <param name="req">参考<see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns>参考<see cref="UpdateOrganizationNodeResponse"/>实例</returns>
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
