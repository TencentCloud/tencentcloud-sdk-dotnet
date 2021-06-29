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

namespace TencentCloud.Eiam.V20210420
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eiam.V20210420.Models;

   public class EiamClient : AbstractClient{

       private const string endpoint = "eiam.tencentcloudapi.com";
       private const string version = "2021-04-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EiamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EiamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 加入用户到用户组
        /// </summary>
        /// <param name="req"><see cref="AddUserToUserGroupRequest"/></param>
        /// <returns><see cref="AddUserToUserGroupResponse"/></returns>
        public async Task<AddUserToUserGroupResponse> AddUserToUserGroup(AddUserToUserGroupRequest req)
        {
             JsonResponseModel<AddUserToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUserToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 加入用户到用户组
        /// </summary>
        /// <param name="req"><see cref="AddUserToUserGroupRequest"/></param>
        /// <returns><see cref="AddUserToUserGroupResponse"/></returns>
        public AddUserToUserGroupResponse AddUserToUserGroupSync(AddUserToUserGroupRequest req)
        {
             JsonResponseModel<AddUserToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUserToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建一个机构节点
        /// </summary>
        /// <param name="req"><see cref="CreateOrgNodeRequest"/></param>
        /// <returns><see cref="CreateOrgNodeResponse"/></returns>
        public async Task<CreateOrgNodeResponse> CreateOrgNode(CreateOrgNodeRequest req)
        {
             JsonResponseModel<CreateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建一个机构节点
        /// </summary>
        /// <param name="req"><see cref="CreateOrgNodeRequest"/></param>
        /// <returns><see cref="CreateOrgNodeResponse"/></returns>
        public CreateOrgNodeResponse CreateOrgNodeSync(CreateOrgNodeRequest req)
        {
             JsonResponseModel<CreateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建一个用户
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
        /// 新建一个用户
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
        /// 获取JWT公钥信息
        /// </summary>
        /// <param name="req"><see cref="DecribePublicKeyRequest"/></param>
        /// <returns><see cref="DecribePublicKeyResponse"/></returns>
        public async Task<DecribePublicKeyResponse> DecribePublicKey(DecribePublicKeyRequest req)
        {
             JsonResponseModel<DecribePublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DecribePublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DecribePublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取JWT公钥信息
        /// </summary>
        /// <param name="req"><see cref="DecribePublicKeyRequest"/></param>
        /// <returns><see cref="DecribePublicKeyResponse"/></returns>
        public DecribePublicKeyResponse DecribePublicKeySync(DecribePublicKeyRequest req)
        {
             JsonResponseModel<DecribePublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DecribePublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DecribePublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个机构节点
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgNodeRequest"/></param>
        /// <returns><see cref="DeleteOrgNodeResponse"/></returns>
        public async Task<DeleteOrgNodeResponse> DeleteOrgNode(DeleteOrgNodeRequest req)
        {
             JsonResponseModel<DeleteOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个机构节点
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgNodeRequest"/></param>
        /// <returns><see cref="DeleteOrgNodeResponse"/></returns>
        public DeleteOrgNodeResponse DeleteOrgNodeSync(DeleteOrgNodeRequest req)
        {
             JsonResponseModel<DeleteOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户名或用户 id 删除用户。
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
        /// 通过用户名或用户 id 删除用户。
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
        /// 删除一个用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupRequest"/></param>
        /// <returns><see cref="DeleteUserGroupResponse"/></returns>
        public async Task<DeleteUserGroupResponse> DeleteUserGroup(DeleteUserGroupRequest req)
        {
             JsonResponseModel<DeleteUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupRequest"/></param>
        /// <returns><see cref="DeleteUserGroupResponse"/></returns>
        public DeleteUserGroupResponse DeleteUserGroupSync(DeleteUserGroupRequest req)
        {
             JsonResponseModel<DeleteUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一个应用的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public async Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
             JsonResponseModel<DescribeApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一个应用的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public DescribeApplicationResponse DescribeApplicationSync(DescribeApplicationRequest req)
        {
             JsonResponseModel<DescribeApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据机构节点ID读取机构节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrgNodeRequest"/></param>
        /// <returns><see cref="DescribeOrgNodeResponse"/></returns>
        public async Task<DescribeOrgNodeResponse> DescribeOrgNode(DescribeOrgNodeRequest req)
        {
             JsonResponseModel<DescribeOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据机构节点ID读取机构节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOrgNodeRequest"/></param>
        /// <returns><see cref="DescribeOrgNodeResponse"/></returns>
        public DescribeOrgNodeResponse DescribeOrgNodeSync(DescribeOrgNodeRequest req)
        {
             JsonResponseModel<DescribeOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupRequest"/></param>
        /// <returns><see cref="DescribeUserGroupResponse"/></returns>
        public async Task<DescribeUserGroupResponse> DescribeUserGroup(DescribeUserGroupRequest req)
        {
             JsonResponseModel<DescribeUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupRequest"/></param>
        /// <returns><see cref="DescribeUserGroupResponse"/></returns>
        public DescribeUserGroupResponse DescribeUserGroupSync(DescribeUserGroupRequest req)
        {
             JsonResponseModel<DescribeUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户名或用户 id 搜索用户
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public async Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户名或用户 id 搜索用户
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过机构节点ID获得被授权访问的应用列表。
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToOrgNodeRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToOrgNodeResponse"/></returns>
        public async Task<ListAuthorizedApplicationsToOrgNodeResponse> ListAuthorizedApplicationsToOrgNode(ListAuthorizedApplicationsToOrgNodeRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAuthorizedApplicationsToOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过机构节点ID获得被授权访问的应用列表。
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToOrgNodeRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToOrgNodeResponse"/></returns>
        public ListAuthorizedApplicationsToOrgNodeResponse ListAuthorizedApplicationsToOrgNodeSync(ListAuthorizedApplicationsToOrgNodeRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAuthorizedApplicationsToOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户ID获得被授权访问的应用列表。
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserResponse"/></returns>
        public async Task<ListAuthorizedApplicationsToUserResponse> ListAuthorizedApplicationsToUser(ListAuthorizedApplicationsToUserRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAuthorizedApplicationsToUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户ID获得被授权访问的应用列表。
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserResponse"/></returns>
        public ListAuthorizedApplicationsToUserResponse ListAuthorizedApplicationsToUserSync(ListAuthorizedApplicationsToUserRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAuthorizedApplicationsToUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户组ID获得被授权访问的应用列表。
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserGroupRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserGroupResponse"/></returns>
        public async Task<ListAuthorizedApplicationsToUserGroupResponse> ListAuthorizedApplicationsToUserGroup(ListAuthorizedApplicationsToUserGroupRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAuthorizedApplicationsToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户组ID获得被授权访问的应用列表。
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserGroupRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserGroupResponse"/></returns>
        public ListAuthorizedApplicationsToUserGroupResponse ListAuthorizedApplicationsToUserGroupSync(ListAuthorizedApplicationsToUserGroupRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAuthorizedApplicationsToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户所在的用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsOfUserRequest"/></param>
        /// <returns><see cref="ListUserGroupsOfUserResponse"/></returns>
        public async Task<ListUserGroupsOfUserResponse> ListUserGroupsOfUser(ListUserGroupsOfUserRequest req)
        {
             JsonResponseModel<ListUserGroupsOfUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUserGroupsOfUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserGroupsOfUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户所在的用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsOfUserRequest"/></param>
        /// <returns><see cref="ListUserGroupsOfUserResponse"/></returns>
        public ListUserGroupsOfUserResponse ListUserGroupsOfUserSync(ListUserGroupsOfUserRequest req)
        {
             JsonResponseModel<ListUserGroupsOfUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUserGroupsOfUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserGroupsOfUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据机构节点ID读取节点下用户
        /// </summary>
        /// <param name="req"><see cref="ListUsersInOrgNodeRequest"/></param>
        /// <returns><see cref="ListUsersInOrgNodeResponse"/></returns>
        public async Task<ListUsersInOrgNodeResponse> ListUsersInOrgNode(ListUsersInOrgNodeRequest req)
        {
             JsonResponseModel<ListUsersInOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUsersInOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据机构节点ID读取节点下用户
        /// </summary>
        /// <param name="req"><see cref="ListUsersInOrgNodeRequest"/></param>
        /// <returns><see cref="ListUsersInOrgNodeResponse"/></returns>
        public ListUsersInOrgNodeResponse ListUsersInOrgNodeSync(ListUsersInOrgNodeRequest req)
        {
             JsonResponseModel<ListUsersInOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUsersInOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户组中的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersInUserGroupRequest"/></param>
        /// <returns><see cref="ListUsersInUserGroupResponse"/></returns>
        public async Task<ListUsersInUserGroupResponse> ListUsersInUserGroup(ListUsersInUserGroupRequest req)
        {
             JsonResponseModel<ListUsersInUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUsersInUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户组中的用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUsersInUserGroupRequest"/></param>
        /// <returns><see cref="ListUsersInUserGroupResponse"/></returns>
        public ListUsersInUserGroupResponse ListUsersInUserGroupSync(ListUsersInUserGroupRequest req)
        {
             JsonResponseModel<ListUsersInUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUsersInUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户名或用户 id 冻结用户
        /// </summary>
        /// <param name="req"><see cref="ModifyUserInfoRequest"/></param>
        /// <returns><see cref="ModifyUserInfoResponse"/></returns>
        public async Task<ModifyUserInfoResponse> ModifyUserInfo(ModifyUserInfoRequest req)
        {
             JsonResponseModel<ModifyUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过用户名或用户 id 冻结用户
        /// </summary>
        /// <param name="req"><see cref="ModifyUserInfoRequest"/></param>
        /// <returns><see cref="ModifyUserInfoResponse"/></returns>
        public ModifyUserInfoResponse ModifyUserInfoSync(ModifyUserInfoRequest req)
        {
             JsonResponseModel<ModifyUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从用户组中移除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromUserGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromUserGroupResponse"/></returns>
        public async Task<RemoveUserFromUserGroupResponse> RemoveUserFromUserGroup(RemoveUserFromUserGroupRequest req)
        {
             JsonResponseModel<RemoveUserFromUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveUserFromUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserFromUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从用户组中移除用户
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromUserGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromUserGroupResponse"/></returns>
        public RemoveUserFromUserGroupResponse RemoveUserFromUserGroupSync(RemoveUserFromUserGroupRequest req)
        {
             JsonResponseModel<RemoveUserFromUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveUserFromUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserFromUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建一个机构节点，
        /// </summary>
        /// <param name="req"><see cref="UpdateOrgNodeRequest"/></param>
        /// <returns><see cref="UpdateOrgNodeResponse"/></returns>
        public async Task<UpdateOrgNodeResponse> UpdateOrgNode(UpdateOrgNodeRequest req)
        {
             JsonResponseModel<UpdateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建一个机构节点，
        /// </summary>
        /// <param name="req"><see cref="UpdateOrgNodeRequest"/></param>
        /// <returns><see cref="UpdateOrgNodeResponse"/></returns>
        public UpdateOrgNodeResponse UpdateOrgNodeSync(UpdateOrgNodeRequest req)
        {
             JsonResponseModel<UpdateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
