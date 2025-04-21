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
       private const string sdkVersion = "SDK_NET_3.0.1224";

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
        /// 接受加入企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="AcceptOrganizationInvitationRequest"/></param>
        /// <returns><see cref="AcceptOrganizationInvitationResponse"/></returns>
        public Task<AcceptOrganizationInvitationResponse> AcceptOrganizationInvitation(AcceptOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<AcceptOrganizationInvitationResponse>(req, "AcceptOrganizationInvitation");
        }

        /// <summary>
        /// 接受加入企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="AcceptOrganizationInvitationRequest"/></param>
        /// <returns><see cref="AcceptOrganizationInvitationResponse"/></returns>
        public AcceptOrganizationInvitationResponse AcceptOrganizationInvitationSync(AcceptOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<AcceptOrganizationInvitationResponse>(req, "AcceptOrganizationInvitation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加企业组织单元
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public Task<AddOrganizationNodeResponse> AddOrganizationNode(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode");
        }

        /// <summary>
        /// 添加企业组织单元
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public AddOrganizationNodeResponse AddOrganizationNodeSync(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationInvitationRequest"/></param>
        /// <returns><see cref="CancelOrganizationInvitationResponse"/></returns>
        public Task<CancelOrganizationInvitationResponse> CancelOrganizationInvitation(CancelOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<CancelOrganizationInvitationResponse>(req, "CancelOrganizationInvitation");
        }

        /// <summary>
        /// 取消企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationInvitationRequest"/></param>
        /// <returns><see cref="CancelOrganizationInvitationResponse"/></returns>
        public CancelOrganizationInvitationResponse CancelOrganizationInvitationSync(CancelOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<CancelOrganizationInvitationResponse>(req, "CancelOrganizationInvitation")
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
        /// 删除企业组织成员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMemberFromNodeRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMemberFromNodeResponse"/></returns>
        public Task<DeleteOrganizationMemberFromNodeResponse> DeleteOrganizationMemberFromNode(DeleteOrganizationMemberFromNodeRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMemberFromNodeResponse>(req, "DeleteOrganizationMemberFromNode");
        }

        /// <summary>
        /// 删除企业组织成员
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMemberFromNodeRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMemberFromNodeResponse"/></returns>
        public DeleteOrganizationMemberFromNodeResponse DeleteOrganizationMemberFromNodeSync(DeleteOrganizationMemberFromNodeRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMemberFromNodeResponse>(req, "DeleteOrganizationMemberFromNode")
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
        /// 批量删除企业组织单元
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public Task<DeleteOrganizationNodesResponse> DeleteOrganizationNodes(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes");
        }

        /// <summary>
        /// 批量删除企业组织单元
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public DeleteOrganizationNodesResponse DeleteOrganizationNodesSync(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拒绝企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="DenyOrganizationInvitationRequest"/></param>
        /// <returns><see cref="DenyOrganizationInvitationResponse"/></returns>
        public Task<DenyOrganizationInvitationResponse> DenyOrganizationInvitation(DenyOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<DenyOrganizationInvitationResponse>(req, "DenyOrganizationInvitation");
        }

        /// <summary>
        /// 拒绝企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="DenyOrganizationInvitationRequest"/></param>
        /// <returns><see cref="DenyOrganizationInvitationResponse"/></returns>
        public DenyOrganizationInvitationResponse DenyOrganizationInvitationSync(DenyOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<DenyOrganizationInvitationResponse>(req, "DenyOrganizationInvitation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业组织信息
        /// </summary>
        /// <param name="req"><see cref="GetOrganizationRequest"/></param>
        /// <returns><see cref="GetOrganizationResponse"/></returns>
        public Task<GetOrganizationResponse> GetOrganization(GetOrganizationRequest req)
        {
            return InternalRequestAsync<GetOrganizationResponse>(req, "GetOrganization");
        }

        /// <summary>
        /// 获取企业组织信息
        /// </summary>
        /// <param name="req"><see cref="GetOrganizationRequest"/></param>
        /// <returns><see cref="GetOrganizationResponse"/></returns>
        public GetOrganizationResponse GetOrganizationSync(GetOrganizationRequest req)
        {
            return InternalRequestAsync<GetOrganizationResponse>(req, "GetOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业组织成员
        /// </summary>
        /// <param name="req"><see cref="GetOrganizationMemberRequest"/></param>
        /// <returns><see cref="GetOrganizationMemberResponse"/></returns>
        public Task<GetOrganizationMemberResponse> GetOrganizationMember(GetOrganizationMemberRequest req)
        {
            return InternalRequestAsync<GetOrganizationMemberResponse>(req, "GetOrganizationMember");
        }

        /// <summary>
        /// 获取企业组织成员
        /// </summary>
        /// <param name="req"><see cref="GetOrganizationMemberRequest"/></param>
        /// <returns><see cref="GetOrganizationMemberResponse"/></returns>
        public GetOrganizationMemberResponse GetOrganizationMemberSync(GetOrganizationMemberRequest req)
        {
            return InternalRequestAsync<GetOrganizationMemberResponse>(req, "GetOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取邀请信息列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationInvitationsRequest"/></param>
        /// <returns><see cref="ListOrganizationInvitationsResponse"/></returns>
        public Task<ListOrganizationInvitationsResponse> ListOrganizationInvitations(ListOrganizationInvitationsRequest req)
        {
            return InternalRequestAsync<ListOrganizationInvitationsResponse>(req, "ListOrganizationInvitations");
        }

        /// <summary>
        /// 获取邀请信息列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationInvitationsRequest"/></param>
        /// <returns><see cref="ListOrganizationInvitationsResponse"/></returns>
        public ListOrganizationInvitationsResponse ListOrganizationInvitationsSync(ListOrganizationInvitationsRequest req)
        {
            return InternalRequestAsync<ListOrganizationInvitationsResponse>(req, "ListOrganizationInvitations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业组织成员列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationMembersRequest"/></param>
        /// <returns><see cref="ListOrganizationMembersResponse"/></returns>
        public Task<ListOrganizationMembersResponse> ListOrganizationMembers(ListOrganizationMembersRequest req)
        {
            return InternalRequestAsync<ListOrganizationMembersResponse>(req, "ListOrganizationMembers");
        }

        /// <summary>
        /// 获取企业组织成员列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationMembersRequest"/></param>
        /// <returns><see cref="ListOrganizationMembersResponse"/></returns>
        public ListOrganizationMembersResponse ListOrganizationMembersSync(ListOrganizationMembersRequest req)
        {
            return InternalRequestAsync<ListOrganizationMembersResponse>(req, "ListOrganizationMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业组织单元成员列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="ListOrganizationNodeMembersResponse"/></returns>
        public Task<ListOrganizationNodeMembersResponse> ListOrganizationNodeMembers(ListOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<ListOrganizationNodeMembersResponse>(req, "ListOrganizationNodeMembers");
        }

        /// <summary>
        /// 获取企业组织单元成员列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="ListOrganizationNodeMembersResponse"/></returns>
        public ListOrganizationNodeMembersResponse ListOrganizationNodeMembersSync(ListOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<ListOrganizationNodeMembersResponse>(req, "ListOrganizationNodeMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业组织单元列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationNodesRequest"/></param>
        /// <returns><see cref="ListOrganizationNodesResponse"/></returns>
        public Task<ListOrganizationNodesResponse> ListOrganizationNodes(ListOrganizationNodesRequest req)
        {
            return InternalRequestAsync<ListOrganizationNodesResponse>(req, "ListOrganizationNodes");
        }

        /// <summary>
        /// 获取企业组织单元列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationNodesRequest"/></param>
        /// <returns><see cref="ListOrganizationNodesResponse"/></returns>
        public ListOrganizationNodesResponse ListOrganizationNodesSync(ListOrganizationNodesRequest req)
        {
            return InternalRequestAsync<ListOrganizationNodesResponse>(req, "ListOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移动成员到指定企业组织单元
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationMembersToNodeRequest"/></param>
        /// <returns><see cref="MoveOrganizationMembersToNodeResponse"/></returns>
        public Task<MoveOrganizationMembersToNodeResponse> MoveOrganizationMembersToNode(MoveOrganizationMembersToNodeRequest req)
        {
            return InternalRequestAsync<MoveOrganizationMembersToNodeResponse>(req, "MoveOrganizationMembersToNode");
        }

        /// <summary>
        /// 移动成员到指定企业组织单元
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationMembersToNodeRequest"/></param>
        /// <returns><see cref="MoveOrganizationMembersToNodeResponse"/></returns>
        public MoveOrganizationMembersToNodeResponse MoveOrganizationMembersToNodeSync(MoveOrganizationMembersToNodeRequest req)
        {
            return InternalRequestAsync<MoveOrganizationMembersToNodeResponse>(req, "MoveOrganizationMembersToNode")
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
        /// 发送企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="SendOrganizationInvitationRequest"/></param>
        /// <returns><see cref="SendOrganizationInvitationResponse"/></returns>
        public Task<SendOrganizationInvitationResponse> SendOrganizationInvitation(SendOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<SendOrganizationInvitationResponse>(req, "SendOrganizationInvitation");
        }

        /// <summary>
        /// 发送企业组织邀请
        /// </summary>
        /// <param name="req"><see cref="SendOrganizationInvitationRequest"/></param>
        /// <returns><see cref="SendOrganizationInvitationResponse"/></returns>
        public SendOrganizationInvitationResponse SendOrganizationInvitationSync(SendOrganizationInvitationRequest req)
        {
            return InternalRequestAsync<SendOrganizationInvitationResponse>(req, "SendOrganizationInvitation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新企业成员信息
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberResponse"/></returns>
        public Task<UpdateOrganizationMemberResponse> UpdateOrganizationMember(UpdateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberResponse>(req, "UpdateOrganizationMember");
        }

        /// <summary>
        /// 更新企业成员信息
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberResponse"/></returns>
        public UpdateOrganizationMemberResponse UpdateOrganizationMemberSync(UpdateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberResponse>(req, "UpdateOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新企业组织单元
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public Task<UpdateOrganizationNodeResponse> UpdateOrganizationNode(UpdateOrganizationNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationNodeResponse>(req, "UpdateOrganizationNode");
        }

        /// <summary>
        /// 更新企业组织单元
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
