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

namespace TencentCloud.Cme.V20191029
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cme.V20191029.Models;

   public class CmeClient : AbstractClient{

       private const string endpoint = "cme.tencentcloudapi.com";
       private const string version = "2019-10-29";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CmeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 向一个团队中团队成员，并且指定成员的角色。
        /// </summary>
        /// <param name="req"><see cref="AddTeamMemberRequest"/></param>
        /// <returns><see cref="AddTeamMemberResponse"/></returns>
        public async Task<AddTeamMemberResponse> AddTeamMember(AddTeamMemberRequest req)
        {
             JsonResponseModel<AddTeamMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddTeamMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTeamMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 向一个团队中团队成员，并且指定成员的角色。
        /// </summary>
        /// <param name="req"><see cref="AddTeamMemberRequest"/></param>
        /// <returns><see cref="AddTeamMemberResponse"/></returns>
        public AddTeamMemberResponse AddTeamMemberSync(AddTeamMemberRequest req)
        {
             JsonResponseModel<AddTeamMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddTeamMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTeamMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类，用于管理素材。
        /// <li>分类层数不能超过10；</li>
        /// <li>子分类数不能超过10。</li>
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public async Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
             JsonResponseModel<CreateClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类，用于管理素材。
        /// <li>分类层数不能超过10；</li>
        /// <li>子分类数不能超过10。</li>
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public CreateClassResponse CreateClassSync(CreateClassRequest req)
        {
             JsonResponseModel<CreateClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  创建素材链接或分类路径链接，将源资源信息链接到目标。
        /// </summary>
        /// <param name="req"><see cref="CreateLinkRequest"/></param>
        /// <returns><see cref="CreateLinkResponse"/></returns>
        public async Task<CreateLinkResponse> CreateLink(CreateLinkRequest req)
        {
             JsonResponseModel<CreateLinkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLink");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLinkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  创建素材链接或分类路径链接，将源资源信息链接到目标。
        /// </summary>
        /// <param name="req"><see cref="CreateLinkRequest"/></param>
        /// <returns><see cref="CreateLinkResponse"/></returns>
        public CreateLinkResponse CreateLinkSync(CreateLinkRequest req)
        {
             JsonResponseModel<CreateLinkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLink");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLinkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云剪的编辑项目，支持创建视频剪辑及直播剪辑两大类项目。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public async Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云剪的编辑项目，支持创建视频剪辑及直播剪辑两大类项目。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个团队。
        /// </summary>
        /// <param name="req"><see cref="CreateTeamRequest"/></param>
        /// <returns><see cref="CreateTeamResponse"/></returns>
        public async Task<CreateTeamResponse> CreateTeam(CreateTeamRequest req)
        {
             JsonResponseModel<CreateTeamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTeam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTeamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个团队。
        /// </summary>
        /// <param name="req"><see cref="CreateTeamRequest"/></param>
        /// <returns><see cref="CreateTeamResponse"/></returns>
        public CreateTeamResponse CreateTeamSync(CreateTeamRequest req)
        {
             JsonResponseModel<CreateTeamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTeam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTeamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除分类信息，删除时检验下述限制：
        /// <li>分类路径必须存在；</li>
        /// <li>分类下没有绑定素材。</li>
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public async Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
             JsonResponseModel<DeleteClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除分类信息，删除时检验下述限制：
        /// <li>分类路径必须存在；</li>
        /// <li>分类下没有绑定素材。</li>
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public DeleteClassResponse DeleteClassSync(DeleteClassRequest req)
        {
             JsonResponseModel<DeleteClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户登录态，使用户登出云剪平台。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginStatusRequest"/></param>
        /// <returns><see cref="DeleteLoginStatusResponse"/></returns>
        public async Task<DeleteLoginStatusResponse> DeleteLoginStatus(DeleteLoginStatusRequest req)
        {
             JsonResponseModel<DeleteLoginStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoginStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoginStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户登录态，使用户登出云剪平台。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginStatusRequest"/></param>
        /// <returns><see cref="DeleteLoginStatusResponse"/></returns>
        public DeleteLoginStatusResponse DeleteLoginStatusSync(DeleteLoginStatusRequest req)
        {
             JsonResponseModel<DeleteLoginStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoginStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoginStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据素材 Id 删除素材。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaterialRequest"/></param>
        /// <returns><see cref="DeleteMaterialResponse"/></returns>
        public async Task<DeleteMaterialResponse> DeleteMaterial(DeleteMaterialRequest req)
        {
             JsonResponseModel<DeleteMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据素材 Id 删除素材。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaterialRequest"/></param>
        /// <returns><see cref="DeleteMaterialResponse"/></returns>
        public DeleteMaterialResponse DeleteMaterialSync(DeleteMaterialRequest req)
        {
             JsonResponseModel<DeleteMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云剪编辑项目。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public async Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云剪编辑项目。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个团队。
        /// <li>要删除的团队必须没有归属的素材；</li>
        /// <li>要删除的团队必须没有归属的分类。</li>
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamRequest"/></param>
        /// <returns><see cref="DeleteTeamResponse"/></returns>
        public async Task<DeleteTeamResponse> DeleteTeam(DeleteTeamRequest req)
        {
             JsonResponseModel<DeleteTeamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTeam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTeamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个团队。
        /// <li>要删除的团队必须没有归属的素材；</li>
        /// <li>要删除的团队必须没有归属的分类。</li>
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamRequest"/></param>
        /// <returns><see cref="DeleteTeamResponse"/></returns>
        public DeleteTeamResponse DeleteTeamSync(DeleteTeamRequest req)
        {
             JsonResponseModel<DeleteTeamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTeam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTeamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将团队成员从团队中删除，默认只有 Owner 及管理员才有此权限。
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMembersRequest"/></param>
        /// <returns><see cref="DeleteTeamMembersResponse"/></returns>
        public async Task<DeleteTeamMembersResponse> DeleteTeamMembers(DeleteTeamMembersRequest req)
        {
             JsonResponseModel<DeleteTeamMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTeamMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTeamMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将团队成员从团队中删除，默认只有 Owner 及管理员才有此权限。
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMembersRequest"/></param>
        /// <returns><see cref="DeleteTeamMembersResponse"/></returns>
        public DeleteTeamMembersResponse DeleteTeamMembersSync(DeleteTeamMembersRequest req)
        {
             JsonResponseModel<DeleteTeamMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTeamMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTeamMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定归属者下所有的分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassRequest"/></param>
        /// <returns><see cref="DescribeClassResponse"/></returns>
        public async Task<DescribeClassResponse> DescribeClass(DescribeClassRequest req)
        {
             JsonResponseModel<DescribeClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定归属者下所有的分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassRequest"/></param>
        /// <returns><see cref="DescribeClassResponse"/></returns>
        public DescribeClassResponse DescribeClassSync(DescribeClassRequest req)
        {
             JsonResponseModel<DescribeClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定的团队成员所加入的团队列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeJoinTeamsRequest"/></param>
        /// <returns><see cref="DescribeJoinTeamsResponse"/></returns>
        public async Task<DescribeJoinTeamsResponse> DescribeJoinTeams(DescribeJoinTeamsRequest req)
        {
             JsonResponseModel<DescribeJoinTeamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJoinTeams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJoinTeamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定的团队成员所加入的团队列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeJoinTeamsRequest"/></param>
        /// <returns><see cref="DescribeJoinTeamsResponse"/></returns>
        public DescribeJoinTeamsResponse DescribeJoinTeamsSync(DescribeJoinTeamsRequest req)
        {
             JsonResponseModel<DescribeJoinTeamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJoinTeams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJoinTeamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定用户的登录态。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginStatusRequest"/></param>
        /// <returns><see cref="DescribeLoginStatusResponse"/></returns>
        public async Task<DescribeLoginStatusResponse> DescribeLoginStatus(DescribeLoginStatusRequest req)
        {
             JsonResponseModel<DescribeLoginStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoginStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定用户的登录态。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginStatusRequest"/></param>
        /// <returns><see cref="DescribeLoginStatusResponse"/></returns>
        public DescribeLoginStatusResponse DescribeLoginStatusSync(DescribeLoginStatusRequest req)
        {
             JsonResponseModel<DescribeLoginStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoginStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据素材 Id 批量获取素材详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaterialsRequest"/></param>
        /// <returns><see cref="DescribeMaterialsResponse"/></returns>
        public async Task<DescribeMaterialsResponse> DescribeMaterials(DescribeMaterialsRequest req)
        {
             JsonResponseModel<DescribeMaterialsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaterials");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaterialsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据素材 Id 批量获取素材详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaterialsRequest"/></param>
        /// <returns><see cref="DescribeMaterialsResponse"/></returns>
        public DescribeMaterialsResponse DescribeMaterialsSync(DescribeMaterialsRequest req)
        {
             JsonResponseModel<DescribeMaterialsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMaterials");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaterialsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持根据多种条件过滤出项目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public async Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持根据多种条件过滤出项目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定资源的授权列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeResourceAuthorizationResponse"/></returns>
        public async Task<DescribeResourceAuthorizationResponse> DescribeResourceAuthorization(DescribeResourceAuthorizationRequest req)
        {
             JsonResponseModel<DescribeResourceAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定资源的授权列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeResourceAuthorizationResponse"/></returns>
        public DescribeResourceAuthorizationResponse DescribeResourceAuthorizationSync(DescribeResourceAuthorizationRequest req)
        {
             JsonResponseModel<DescribeResourceAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取共享空间。当实体A对实体B授权某资源以后，实体B的共享空间就会增加实体A。
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedSpaceRequest"/></param>
        /// <returns><see cref="DescribeSharedSpaceResponse"/></returns>
        public async Task<DescribeSharedSpaceResponse> DescribeSharedSpace(DescribeSharedSpaceRequest req)
        {
             JsonResponseModel<DescribeSharedSpaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSharedSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSharedSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取共享空间。当实体A对实体B授权某资源以后，实体B的共享空间就会增加实体A。
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedSpaceRequest"/></param>
        /// <returns><see cref="DescribeSharedSpaceResponse"/></returns>
        public DescribeSharedSpaceResponse DescribeSharedSpaceSync(DescribeSharedSpaceRequest req)
        {
             JsonResponseModel<DescribeSharedSpaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSharedSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSharedSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务详情信息，包含下面几个部分：
        /// <li>任务基础信息：包括任务状态、错误信息、创建时间等；</li>
        /// <li>导出项目输出信息：包括输出的素材 Id 等。</li>
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务详情信息，包含下面几个部分：
        /// <li>任务基础信息：包括任务状态、错误信息、创建时间等；</li>
        /// <li>导出项目输出信息：包括输出的素材 Id 等。</li>
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务列表，支持条件筛选，返回对应的任务基础信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务列表，支持条件筛选，返回对应的任务基础信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定成员 ID 的信息，同时支持拉取所有团队成员信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMembersRequest"/></param>
        /// <returns><see cref="DescribeTeamMembersResponse"/></returns>
        public async Task<DescribeTeamMembersResponse> DescribeTeamMembers(DescribeTeamMembersRequest req)
        {
             JsonResponseModel<DescribeTeamMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTeamMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTeamMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定成员 ID 的信息，同时支持拉取所有团队成员信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMembersRequest"/></param>
        /// <returns><see cref="DescribeTeamMembersResponse"/></returns>
        public DescribeTeamMembersResponse DescribeTeamMembersSync(DescribeTeamMembersRequest req)
        {
             JsonResponseModel<DescribeTeamMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTeamMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTeamMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定团队的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamsRequest"/></param>
        /// <returns><see cref="DescribeTeamsResponse"/></returns>
        public async Task<DescribeTeamsResponse> DescribeTeams(DescribeTeamsRequest req)
        {
             JsonResponseModel<DescribeTeamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTeams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTeamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定团队的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamsRequest"/></param>
        /// <returns><see cref="DescribeTeamsResponse"/></returns>
        public DescribeTeamsResponse DescribeTeamsSync(DescribeTeamsRequest req)
        {
             JsonResponseModel<DescribeTeamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTeams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTeamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用在线编辑轨道数据直接导出视频。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByEditorTrackDataRequest"/></param>
        /// <returns><see cref="ExportVideoByEditorTrackDataResponse"/></returns>
        public async Task<ExportVideoByEditorTrackDataResponse> ExportVideoByEditorTrackData(ExportVideoByEditorTrackDataRequest req)
        {
             JsonResponseModel<ExportVideoByEditorTrackDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVideoByEditorTrackData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoByEditorTrackDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用在线编辑轨道数据直接导出视频。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByEditorTrackDataRequest"/></param>
        /// <returns><see cref="ExportVideoByEditorTrackDataResponse"/></returns>
        public ExportVideoByEditorTrackDataResponse ExportVideoByEditorTrackDataSync(ExportVideoByEditorTrackDataRequest req)
        {
             JsonResponseModel<ExportVideoByEditorTrackDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVideoByEditorTrackData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoByEditorTrackDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出视频编辑项目，支持指定输出的模板。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoEditProjectRequest"/></param>
        /// <returns><see cref="ExportVideoEditProjectResponse"/></returns>
        public async Task<ExportVideoEditProjectResponse> ExportVideoEditProject(ExportVideoEditProjectRequest req)
        {
             JsonResponseModel<ExportVideoEditProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVideoEditProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoEditProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出视频编辑项目，支持指定输出的模板。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoEditProjectRequest"/></param>
        /// <returns><see cref="ExportVideoEditProjectResponse"/></returns>
        public ExportVideoEditProjectResponse ExportVideoEditProjectSync(ExportVideoEditProjectRequest req)
        {
             JsonResponseModel<ExportVideoEditProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVideoEditProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoEditProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 平铺分类路径下及其子分类下的所有素材。
        /// </summary>
        /// <param name="req"><see cref="FlattenListMediaRequest"/></param>
        /// <returns><see cref="FlattenListMediaResponse"/></returns>
        public async Task<FlattenListMediaResponse> FlattenListMedia(FlattenListMediaRequest req)
        {
             JsonResponseModel<FlattenListMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FlattenListMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlattenListMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 平铺分类路径下及其子分类下的所有素材。
        /// </summary>
        /// <param name="req"><see cref="FlattenListMediaRequest"/></param>
        /// <returns><see cref="FlattenListMediaResponse"/></returns>
        public FlattenListMediaResponse FlattenListMediaSync(FlattenListMediaRequest req)
        {
             JsonResponseModel<FlattenListMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FlattenListMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlattenListMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源所属实体对目标实体授予目标资源的相应权限。
        /// </summary>
        /// <param name="req"><see cref="GrantResourceAuthorizationRequest"/></param>
        /// <returns><see cref="GrantResourceAuthorizationResponse"/></returns>
        public async Task<GrantResourceAuthorizationResponse> GrantResourceAuthorization(GrantResourceAuthorizationRequest req)
        {
             JsonResponseModel<GrantResourceAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GrantResourceAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GrantResourceAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源所属实体对目标实体授予目标资源的相应权限。
        /// </summary>
        /// <param name="req"><see cref="GrantResourceAuthorizationRequest"/></param>
        /// <returns><see cref="GrantResourceAuthorizationResponse"/></returns>
        public GrantResourceAuthorizationResponse GrantResourceAuthorizationSync(GrantResourceAuthorizationRequest req)
        {
             JsonResponseModel<GrantResourceAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GrantResourceAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GrantResourceAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将云点播媒资文件导入到云剪素材库。
        /// </summary>
        /// <param name="req"><see cref="ImportMaterialRequest"/></param>
        /// <returns><see cref="ImportMaterialResponse"/></returns>
        public async Task<ImportMaterialResponse> ImportMaterial(ImportMaterialRequest req)
        {
             JsonResponseModel<ImportMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将云点播媒资文件导入到云剪素材库。
        /// </summary>
        /// <param name="req"><see cref="ImportMaterialRequest"/></param>
        /// <returns><see cref="ImportMaterialResponse"/></returns>
        public ImportMaterialResponse ImportMaterialSync(ImportMaterialRequest req)
        {
             JsonResponseModel<ImportMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将云点播中的媒资添加到素材库中，供后续视频编辑使用。
        /// </summary>
        /// <param name="req"><see cref="ImportMediaToProjectRequest"/></param>
        /// <returns><see cref="ImportMediaToProjectResponse"/></returns>
        public async Task<ImportMediaToProjectResponse> ImportMediaToProject(ImportMediaToProjectRequest req)
        {
             JsonResponseModel<ImportMediaToProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportMediaToProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMediaToProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将云点播中的媒资添加到素材库中，供后续视频编辑使用。
        /// </summary>
        /// <param name="req"><see cref="ImportMediaToProjectRequest"/></param>
        /// <returns><see cref="ImportMediaToProjectResponse"/></returns>
        public ImportMediaToProjectResponse ImportMediaToProjectSync(ImportMediaToProjectRequest req)
        {
             JsonResponseModel<ImportMediaToProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportMediaToProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportMediaToProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  浏览当前分类路径下的资源，包括素材和子分类。
        /// </summary>
        /// <param name="req"><see cref="ListMediaRequest"/></param>
        /// <returns><see cref="ListMediaResponse"/></returns>
        public async Task<ListMediaResponse> ListMedia(ListMediaRequest req)
        {
             JsonResponseModel<ListMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  浏览当前分类路径下的资源，包括素材和子分类。
        /// </summary>
        /// <param name="req"><see cref="ListMediaRequest"/></param>
        /// <returns><see cref="ListMediaResponse"/></returns>
        public ListMediaResponse ListMediaSync(ListMediaRequest req)
        {
             JsonResponseModel<ListMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改素材信息，支持修改素材名称、分类路径、标签等信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaterialRequest"/></param>
        /// <returns><see cref="ModifyMaterialResponse"/></returns>
        public async Task<ModifyMaterialResponse> ModifyMaterial(ModifyMaterialRequest req)
        {
             JsonResponseModel<ModifyMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改素材信息，支持修改素材名称、分类路径、标签等信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaterialRequest"/></param>
        /// <returns><see cref="ModifyMaterialResponse"/></returns>
        public ModifyMaterialResponse ModifyMaterialSync(ModifyMaterialRequest req)
        {
             JsonResponseModel<ModifyMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云剪编辑项目的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public async Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云剪编辑项目的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改团队信息，目前支持修改的操作有：
        /// <li>修改团队名称。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public async Task<ModifyTeamResponse> ModifyTeam(ModifyTeamRequest req)
        {
             JsonResponseModel<ModifyTeamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTeam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTeamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改团队信息，目前支持修改的操作有：
        /// <li>修改团队名称。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public ModifyTeamResponse ModifyTeamSync(ModifyTeamRequest req)
        {
             JsonResponseModel<ModifyTeamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTeam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTeamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改团队成员信息，包括成员备注、角色等。
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public async Task<ModifyTeamMemberResponse> ModifyTeamMember(ModifyTeamMemberRequest req)
        {
             JsonResponseModel<ModifyTeamMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTeamMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTeamMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改团队成员信息，包括成员备注、角色等。
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public ModifyTeamMemberResponse ModifyTeamMemberSync(ModifyTeamMemberRequest req)
        {
             JsonResponseModel<ModifyTeamMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTeamMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTeamMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动某一个分类到另外一个分类下，也可用于分类重命名。
        /// <li>如果 SourceClassPath = /素材/视频/NBA，DestinationClassPath = /素材/视频/篮球，当 DestinationClassPath 不存在时候，操作结果为重命名 ClassPath，如果 DestinationClassPath 存在时候，操作结果为产生新目录 /素材/视频/篮球/NBA。</li>
        /// </summary>
        /// <param name="req"><see cref="MoveClassRequest"/></param>
        /// <returns><see cref="MoveClassResponse"/></returns>
        public async Task<MoveClassResponse> MoveClass(MoveClassRequest req)
        {
             JsonResponseModel<MoveClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MoveClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动某一个分类到另外一个分类下，也可用于分类重命名。
        /// <li>如果 SourceClassPath = /素材/视频/NBA，DestinationClassPath = /素材/视频/篮球，当 DestinationClassPath 不存在时候，操作结果为重命名 ClassPath，如果 DestinationClassPath 存在时候，操作结果为产生新目录 /素材/视频/篮球/NBA。</li>
        /// </summary>
        /// <param name="req"><see cref="MoveClassRequest"/></param>
        /// <returns><see cref="MoveClassResponse"/></returns>
        public MoveClassResponse MoveClassSync(MoveClassRequest req)
        {
             JsonResponseModel<MoveClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MoveClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  资源所属实体对目标实体回收目标资源的相应权限，若原本没有相应权限则不产生变更。
        /// </summary>
        /// <param name="req"><see cref="RevokeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="RevokeResourceAuthorizationResponse"/></returns>
        public async Task<RevokeResourceAuthorizationResponse> RevokeResourceAuthorization(RevokeResourceAuthorizationRequest req)
        {
             JsonResponseModel<RevokeResourceAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevokeResourceAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeResourceAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  资源所属实体对目标实体回收目标资源的相应权限，若原本没有相应权限则不产生变更。
        /// </summary>
        /// <param name="req"><see cref="RevokeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="RevokeResourceAuthorizationResponse"/></returns>
        public RevokeResourceAuthorizationResponse RevokeResourceAuthorizationSync(RevokeResourceAuthorizationRequest req)
        {
             JsonResponseModel<RevokeResourceAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevokeResourceAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeResourceAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检索条件搜索素材，返回素材的基本信息。
        /// </summary>
        /// <param name="req"><see cref="SearchMaterialRequest"/></param>
        /// <returns><see cref="SearchMaterialResponse"/></returns>
        public async Task<SearchMaterialResponse> SearchMaterial(SearchMaterialRequest req)
        {
             JsonResponseModel<SearchMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检索条件搜索素材，返回素材的基本信息。
        /// </summary>
        /// <param name="req"><see cref="SearchMaterialRequest"/></param>
        /// <returns><see cref="SearchMaterialResponse"/></returns>
        public SearchMaterialResponse SearchMaterialSync(SearchMaterialRequest req)
        {
             JsonResponseModel<SearchMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
