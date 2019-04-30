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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public CamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public CamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加子用户
        /// </summary>
        /// <param name="req">参考<see cref="AddUserRequest"/></param>
        /// <returns>参考<see cref="AddUserResponse"/>实例</returns>
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
        /// 用户加入到用户组
        /// </summary>
        /// <param name="req">参考<see cref="AddUserToGroupRequest"/></param>
        /// <returns>参考<see cref="AddUserToGroupResponse"/>实例</returns>
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
        /// 本接口（AttachGroupPolicy）可用于绑定策略到用户组。
        /// </summary>
        /// <param name="req">参考<see cref="AttachGroupPolicyRequest"/></param>
        /// <returns>参考<see cref="AttachGroupPolicyResponse"/>实例</returns>
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
        /// 本接口（AttachUserPolicy）可用于绑定到用户的策略。
        /// </summary>
        /// <param name="req">参考<see cref="AttachUserPolicyRequest"/></param>
        /// <returns>参考<see cref="AttachUserPolicyResponse"/>实例</returns>
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
        /// 创建用户组
        /// </summary>
        /// <param name="req">参考<see cref="CreateGroupRequest"/></param>
        /// <returns>参考<see cref="CreateGroupResponse"/>实例</returns>
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
        /// 本接口（CreatePolicy）可用于创建策略。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePolicyRequest"/></param>
        /// <returns>参考<see cref="CreatePolicyResponse"/>实例</returns>
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
        /// 创建SAML身份提供商
        /// </summary>
        /// <param name="req">参考<see cref="CreateSAMLProviderRequest"/></param>
        /// <returns>参考<see cref="CreateSAMLProviderResponse"/>实例</returns>
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
        /// 删除用户组
        /// </summary>
        /// <param name="req">参考<see cref="DeleteGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteGroupResponse"/>实例</returns>
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
        /// 本接口（DeletePolicy）可用于删除策略。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePolicyRequest"/></param>
        /// <returns>参考<see cref="DeletePolicyResponse"/>实例</returns>
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
        /// 删除SAML身份提供商
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSAMLProviderRequest"/></param>
        /// <returns>参考<see cref="DeleteSAMLProviderResponse"/>实例</returns>
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
        /// 删除子用户
        /// </summary>
        /// <param name="req">参考<see cref="DeleteUserRequest"/></param>
        /// <returns>参考<see cref="DeleteUserResponse"/>实例</returns>
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
        /// 本接口（DetachGroupPolicy）可用于解除绑定到用户组的策略。
        /// </summary>
        /// <param name="req">参考<see cref="DetachGroupPolicyRequest"/></param>
        /// <returns>参考<see cref="DetachGroupPolicyResponse"/>实例</returns>
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
        /// 本接口（DetachUserPolicy）可用于解除绑定到用户的策略。
        /// </summary>
        /// <param name="req">参考<see cref="DetachUserPolicyRequest"/></param>
        /// <returns>参考<see cref="DetachUserPolicyResponse"/>实例</returns>
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
        /// 查询用户组详情
        /// </summary>
        /// <param name="req">参考<see cref="GetGroupRequest"/></param>
        /// <returns>参考<see cref="GetGroupResponse"/>实例</returns>
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
        /// 本接口（GetPolicy）可用于查询查看策略详情。
        /// </summary>
        /// <param name="req">参考<see cref="GetPolicyRequest"/></param>
        /// <returns>参考<see cref="GetPolicyResponse"/>实例</returns>
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
        /// 查询SAML身份提供商详情
        /// </summary>
        /// <param name="req">参考<see cref="GetSAMLProviderRequest"/></param>
        /// <returns>参考<see cref="GetSAMLProviderResponse"/>实例</returns>
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
        /// 查询子用户
        /// </summary>
        /// <param name="req">参考<see cref="GetUserRequest"/></param>
        /// <returns>参考<see cref="GetUserResponse"/>实例</returns>
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
        /// 本接口（ListAttachedGroupPolicies）可用于查询用户组关联的策略列表。
        /// </summary>
        /// <param name="req">参考<see cref="ListAttachedGroupPoliciesRequest"/></param>
        /// <returns>参考<see cref="ListAttachedGroupPoliciesResponse"/>实例</returns>
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
        /// 本接口（ListAttachedUserPolicies）可用于查询子账号关联的策略列表。
        /// </summary>
        /// <param name="req">参考<see cref="ListAttachedUserPoliciesRequest"/></param>
        /// <returns>参考<see cref="ListAttachedUserPoliciesResponse"/>实例</returns>
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
        /// 本接口（ListEntitiesForPolicy）可用于查询策略关联的实体列表。
        /// </summary>
        /// <param name="req">参考<see cref="ListEntitiesForPolicyRequest"/></param>
        /// <returns>参考<see cref="ListEntitiesForPolicyResponse"/>实例</returns>
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
        /// 查询用户组列表
        /// </summary>
        /// <param name="req">参考<see cref="ListGroupsRequest"/></param>
        /// <returns>参考<see cref="ListGroupsResponse"/>实例</returns>
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
        /// 列出用户关联的用户组
        /// </summary>
        /// <param name="req">参考<see cref="ListGroupsForUserRequest"/></param>
        /// <returns>参考<see cref="ListGroupsForUserResponse"/>实例</returns>
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
        /// 本接口（ListPolicies）可用于查询策略列表
        /// </summary>
        /// <param name="req">参考<see cref="ListPoliciesRequest"/></param>
        /// <returns>参考<see cref="ListPoliciesResponse"/>实例</returns>
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
        /// 查询SAML身份提供商列表
        /// </summary>
        /// <param name="req">参考<see cref="ListSAMLProvidersRequest"/></param>
        /// <returns>参考<see cref="ListSAMLProvidersResponse"/>实例</returns>
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
        /// 拉取子用户
        /// </summary>
        /// <param name="req">参考<see cref="ListUsersRequest"/></param>
        /// <returns>参考<see cref="ListUsersResponse"/>实例</returns>
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
        /// 查询用户组关联的用户列表
        /// </summary>
        /// <param name="req">参考<see cref="ListUsersForGroupRequest"/></param>
        /// <returns>参考<see cref="ListUsersForGroupResponse"/>实例</returns>
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
        /// 从用户组删除用户
        /// </summary>
        /// <param name="req">参考<see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns>参考<see cref="RemoveUserFromGroupResponse"/>实例</returns>
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
        /// 更新用户组
        /// </summary>
        /// <param name="req">参考<see cref="UpdateGroupRequest"/></param>
        /// <returns>参考<see cref="UpdateGroupResponse"/>实例</returns>
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
        /// 本接口（UpdatePolicy ）可用于更新策略。
        /// </summary>
        /// <param name="req">参考<see cref="UpdatePolicyRequest"/></param>
        /// <returns>参考<see cref="UpdatePolicyResponse"/>实例</returns>
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
        /// 更新SAML身份提供商信息
        /// </summary>
        /// <param name="req">参考<see cref="UpdateSAMLProviderRequest"/></param>
        /// <returns>参考<see cref="UpdateSAMLProviderResponse"/>实例</returns>
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
        /// 更新子用户
        /// </summary>
        /// <param name="req">参考<see cref="UpdateUserRequest"/></param>
        /// <returns>参考<see cref="UpdateUserResponse"/>实例</returns>
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

    }
}
