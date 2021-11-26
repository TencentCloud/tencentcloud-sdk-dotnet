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
        /// 向一个团队中添加团队成员，并且指定成员的角色。
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
        /// 向一个团队中添加团队成员，并且指定成员的角色。
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
        /// 复制一个项目，包括项目素材及轨道数据。目前仅普通剪辑及模板制作项目可复制，其它类型的项目不支持复制。
        /// </summary>
        /// <param name="req"><see cref="CopyProjectRequest"/></param>
        /// <returns><see cref="CopyProjectResponse"/></returns>
        public async Task<CopyProjectResponse> CopyProject(CopyProjectRequest req)
        {
             JsonResponseModel<CopyProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制一个项目，包括项目素材及轨道数据。目前仅普通剪辑及模板制作项目可复制，其它类型的项目不支持复制。
        /// </summary>
        /// <param name="req"><see cref="CopyProjectRequest"/></param>
        /// <returns><see cref="CopyProjectResponse"/></returns>
        public CopyProjectResponse CopyProjectSync(CopyProjectRequest req)
        {
             JsonResponseModel<CopyProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类，用于管理素材。分类层数不能超过20。
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
        /// 新增分类，用于管理素材。分类层数不能超过20。
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
        ///  创建媒体链接或分类路径链接，将源资源信息链接到目标。
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
        ///  创建媒体链接或分类路径链接，将源资源信息链接到目标。
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
        /// 创建云剪项目，目前支持的项目类型有：
        /// <li>视频剪辑项目：用于普通视频剪辑；</li>
        /// <li>直播剪辑项目：用于直播流剪辑；</li>
        /// <li>导播台项目：用于云导播台；</li>
        /// <li>视频拆条：用于视频拆条；</li>
        /// <li>录制回放项目：用于直播录制回放；</li>
        /// <li>云转推项目：用于直播云转推。</li>
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
        /// 创建云剪项目，目前支持的项目类型有：
        /// <li>视频剪辑项目：用于普通视频剪辑；</li>
        /// <li>直播剪辑项目：用于直播流剪辑；</li>
        /// <li>导播台项目：用于云导播台；</li>
        /// <li>视频拆条：用于视频拆条；</li>
        /// <li>录制回放项目：用于直播录制回放；</li>
        /// <li>云转推项目：用于直播云转推。</li>
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
        /// 指定导出的参数，创建一个视频编码配置
        /// </summary>
        /// <param name="req"><see cref="CreateVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="CreateVideoEncodingPresetResponse"/></returns>
        public async Task<CreateVideoEncodingPresetResponse> CreateVideoEncodingPreset(CreateVideoEncodingPresetRequest req)
        {
             JsonResponseModel<CreateVideoEncodingPresetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVideoEncodingPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoEncodingPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定导出的参数，创建一个视频编码配置
        /// </summary>
        /// <param name="req"><see cref="CreateVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="CreateVideoEncodingPresetResponse"/></returns>
        public CreateVideoEncodingPresetResponse CreateVideoEncodingPresetSync(CreateVideoEncodingPresetRequest req)
        {
             JsonResponseModel<CreateVideoEncodingPresetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVideoEncodingPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoEncodingPresetResponse>>(strResp);
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
        /// 根据媒体 Id 删除媒体。
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
        /// 根据媒体 Id 删除媒体。
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
        /// 删除项目。
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
        /// 删除项目。
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
        /// 删除一个团队。要删除团队，必须满足以下条件：
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
        /// 删除一个团队。要删除团队，必须满足以下条件：
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
        /// 将团队成员从团队中删除。
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
        /// 将团队成员从团队中删除。
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
        /// 删除指定 ID 的视频编码配置
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="DeleteVideoEncodingPresetResponse"/></returns>
        public async Task<DeleteVideoEncodingPresetResponse> DeleteVideoEncodingPreset(DeleteVideoEncodingPresetRequest req)
        {
             JsonResponseModel<DeleteVideoEncodingPresetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVideoEncodingPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVideoEncodingPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定 ID 的视频编码配置
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="DeleteVideoEncodingPresetResponse"/></returns>
        public DeleteVideoEncodingPresetResponse DeleteVideoEncodingPresetSync(DeleteVideoEncodingPresetRequest req)
        {
             JsonResponseModel<DeleteVideoEncodingPresetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVideoEncodingPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVideoEncodingPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台中所有的已注册账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台中所有的已注册账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
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
        /// 获取用户所加入的团队列表
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
        /// 获取用户所加入的团队列表
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
        /// 根据媒体 Id 批量获取媒体详情。
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
        /// 根据媒体 Id 批量获取媒体详情。
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
        /// <li>支持获取所创建的所有平台列表信息；</li>
        /// <li>支持获取指定的平台列表信息。</li>
        /// 
        /// 关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePlatformsRequest"/></param>
        /// <returns><see cref="DescribePlatformsResponse"/></returns>
        public async Task<DescribePlatformsResponse> DescribePlatforms(DescribePlatformsRequest req)
        {
             JsonResponseModel<DescribePlatformsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlatforms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlatformsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <li>支持获取所创建的所有平台列表信息；</li>
        /// <li>支持获取指定的平台列表信息。</li>
        /// 
        /// 关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DescribePlatformsRequest"/></param>
        /// <returns><see cref="DescribePlatformsResponse"/></returns>
        public DescribePlatformsResponse DescribePlatformsSync(DescribePlatformsRequest req)
        {
             JsonResponseModel<DescribePlatformsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlatforms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlatformsResponse>>(strResp);
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
        /// 查询资源被授权的情况。
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
        /// 查询资源被授权的情况。
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
        /// 获取共享空间。当个人或团队A对个人或团队B授权某资源以后，个人或团队B的共享空间就会增加个人或团队A。
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
        /// 获取共享空间。当个人或团队A对个人或团队B授权某资源以后，个人或团队B的共享空间就会增加个人或团队A。
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
        /// 获取指定团队的成员信息。支持获取指定成员的信息，同时也支持分页拉取指定团队的所有成员信息。
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
        /// 获取指定团队的成员信息。支持获取指定成员的信息，同时也支持分页拉取指定团队的所有成员信息。
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
        /// 获取指定团队的信息，拉取团队信息列表。
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
        /// 获取指定团队的信息，拉取团队信息列表。
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
        /// 查询视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoEncodingPresetsRequest"/></param>
        /// <returns><see cref="DescribeVideoEncodingPresetsResponse"/></returns>
        public async Task<DescribeVideoEncodingPresetsResponse> DescribeVideoEncodingPresets(DescribeVideoEncodingPresetsRequest req)
        {
             JsonResponseModel<DescribeVideoEncodingPresetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoEncodingPresets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoEncodingPresetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoEncodingPresetsRequest"/></param>
        /// <returns><see cref="DescribeVideoEncodingPresetsResponse"/></returns>
        public DescribeVideoEncodingPresetsResponse DescribeVideoEncodingPresetsSync(DescribeVideoEncodingPresetsRequest req)
        {
             JsonResponseModel<DescribeVideoEncodingPresetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoEncodingPresets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoEncodingPresetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用 [视频合成协议](https://cloud.tencent.com/document/product/1156/51225) 合成视频，支持导出视频到 CME 云媒资或者云点播媒资。
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
        /// 使用 [视频合成协议](https://cloud.tencent.com/document/product/1156/51225) 合成视频，支持导出视频到 CME 云媒资或者云点播媒资。
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
        /// 使用视频剪辑模板直接导出视频。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByTemplateRequest"/></param>
        /// <returns><see cref="ExportVideoByTemplateResponse"/></returns>
        public async Task<ExportVideoByTemplateResponse> ExportVideoByTemplate(ExportVideoByTemplateRequest req)
        {
             JsonResponseModel<ExportVideoByTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVideoByTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoByTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用视频剪辑模板直接导出视频。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByTemplateRequest"/></param>
        /// <returns><see cref="ExportVideoByTemplateResponse"/></returns>
        public ExportVideoByTemplateResponse ExportVideoByTemplateSync(ExportVideoByTemplateRequest req)
        {
             JsonResponseModel<ExportVideoByTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVideoByTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoByTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用视频智能拆条数据导出视频，将指定的视频拆条片段导出为一个视频(内测中，请勿使用)。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByVideoSegmentationDataRequest"/></param>
        /// <returns><see cref="ExportVideoByVideoSegmentationDataResponse"/></returns>
        public async Task<ExportVideoByVideoSegmentationDataResponse> ExportVideoByVideoSegmentationData(ExportVideoByVideoSegmentationDataRequest req)
        {
             JsonResponseModel<ExportVideoByVideoSegmentationDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVideoByVideoSegmentationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoByVideoSegmentationDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用视频智能拆条数据导出视频，将指定的视频拆条片段导出为一个视频(内测中，请勿使用)。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByVideoSegmentationDataRequest"/></param>
        /// <returns><see cref="ExportVideoByVideoSegmentationDataResponse"/></returns>
        public ExportVideoByVideoSegmentationDataResponse ExportVideoByVideoSegmentationDataSync(ExportVideoByVideoSegmentationDataRequest req)
        {
             JsonResponseModel<ExportVideoByVideoSegmentationDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVideoByVideoSegmentationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVideoByVideoSegmentationDataResponse>>(strResp);
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
        /// 平铺分类路径下及其子分类下的所有媒体基础信息，返回当前分类及子分类中的所有媒体的基础信息。
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
        /// 平铺分类路径下及其子分类下的所有媒体基础信息，返回当前分类及子分类中的所有媒体的基础信息。
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
        /// <li>发起视频智能拆条任务，支持智能生成和平精英集锦、王者荣耀集锦、足球集锦、篮球集锦 、人物集锦、新闻拆条等任务。</li>
        /// <li>和平精英集锦和王者荣耀集锦根据击杀场景进行拆条，足球集锦和篮球集锦根据进球场景进行拆条，人物集锦根据人物人脸特征进行拆条，新闻拆条根据导播进行拆条。</li>
        /// <li>【本接口内测中，暂不建议使用】</li>
        /// </summary>
        /// <param name="req"><see cref="GenerateVideoSegmentationSchemeByAiRequest"/></param>
        /// <returns><see cref="GenerateVideoSegmentationSchemeByAiResponse"/></returns>
        public async Task<GenerateVideoSegmentationSchemeByAiResponse> GenerateVideoSegmentationSchemeByAi(GenerateVideoSegmentationSchemeByAiRequest req)
        {
             JsonResponseModel<GenerateVideoSegmentationSchemeByAiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateVideoSegmentationSchemeByAi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateVideoSegmentationSchemeByAiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <li>发起视频智能拆条任务，支持智能生成和平精英集锦、王者荣耀集锦、足球集锦、篮球集锦 、人物集锦、新闻拆条等任务。</li>
        /// <li>和平精英集锦和王者荣耀集锦根据击杀场景进行拆条，足球集锦和篮球集锦根据进球场景进行拆条，人物集锦根据人物人脸特征进行拆条，新闻拆条根据导播进行拆条。</li>
        /// <li>【本接口内测中，暂不建议使用】</li>
        /// </summary>
        /// <param name="req"><see cref="GenerateVideoSegmentationSchemeByAiRequest"/></param>
        /// <returns><see cref="GenerateVideoSegmentationSchemeByAiResponse"/></returns>
        public GenerateVideoSegmentationSchemeByAiResponse GenerateVideoSegmentationSchemeByAiSync(GenerateVideoSegmentationSchemeByAiRequest req)
        {
             JsonResponseModel<GenerateVideoSegmentationSchemeByAiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateVideoSegmentationSchemeByAi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateVideoSegmentationSchemeByAiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源归属者对个人或团队授予目标资源的相应权限。
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
        /// 资源归属者对个人或团队授予目标资源的相应权限。
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
        /// 对云转推项目进行操作。
        /// ### 操作类型<a id="Operation"></a>
        /// - `AddInput`（添加输入源），包括：
        /// 	- 添加直播拉流输入源，参见 [示例1](#.E7.A4.BA.E4.BE.8B1-.E6.B7.BB.E5.8A.A0.E7.9B.B4.E6.92.AD.E6.8B.89.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// 	- 添加直播推流输入源，参见 [示例2](#.E7.A4.BA.E4.BE.8B2-.E6.B7.BB.E5.8A.A0.E7.9B.B4.E6.92.AD.E6.8E.A8.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// 	- 添加点播拉流输入源，参见 [示例3](#.E7.A4.BA.E4.BE.8B3-.E6.B7.BB.E5.8A.A0.E7.82.B9.E6.92.AD.E6.8B.89.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90.E4.B8.94.E5.BE.AA.E7.8E.AF.E6.92.AD.E6.94.BE)、[示例4](#.E7.A4.BA.E4.BE.8B4-.E6.B7.BB.E5.8A.A0.E7.82.B9.E6.92.AD.E6.8B.89.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90.E4.B8.94.E5.8D.95.E6.AC.A1.E6.92.AD.E6.94.BE)；
        /// - `DeleteInput`（删除输入源），参见 [示例5](#.E7.A4.BA.E4.BE.8B5-.E5.88.A0.E9.99.A4.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `ModifyInput`（修改输入源），参见 [示例6](#.E7.A4.BA.E4.BE.8B6-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `AddOutput`（ 添加输出源），参见 [示例7](#.E7.A4.BA.E4.BE.8B7-.E6.B7.BB.E5.8A.A0.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `DeleteOutput`（删除输出源），参见 [示例8](#.E7.A4.BA.E4.BE.8B8-.E5.88.A0.E9.99.A4.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `ModifyOutput`（修改输出源），参见 [示例9](#.E7.A4.BA.E4.BE.8B9-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `Start`（开启转推），参见 [示例10](#.E7.A4.BA.E4.BE.8B10-.E5.BC.80.E5.90.AF.E4.BA.91.E8.BD.AC.E6.8E.A8)；
        /// - `Stop`（停止转推），参见 [示例11](#.E7.A4.BA.E4.BE.8B11-.E5.81.9C.E6.AD.A2.E4.BA.91.E8.BD.AC.E6.8E.A8)；
        /// - `SwitchInput`（切换输入源），参见 [示例12](#.E7.A4.BA.E4.BE.8B12-.E5.88.87.E6.8D.A2.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `ModifyCurrentStopTime`（修改当前计划结束时间），参见 [示例13](#.E7.A4.BA.E4.BE.8B13-.E4.BF.AE.E6.94.B9.E8.BD.AC.E6.8E.A8.E7.BB.93.E6.9D.9F.E6.97.B6.E9.97.B4)。
        /// </summary>
        /// <param name="req"><see cref="HandleStreamConnectProjectRequest"/></param>
        /// <returns><see cref="HandleStreamConnectProjectResponse"/></returns>
        public async Task<HandleStreamConnectProjectResponse> HandleStreamConnectProject(HandleStreamConnectProjectRequest req)
        {
             JsonResponseModel<HandleStreamConnectProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HandleStreamConnectProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HandleStreamConnectProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对云转推项目进行操作。
        /// ### 操作类型<a id="Operation"></a>
        /// - `AddInput`（添加输入源），包括：
        /// 	- 添加直播拉流输入源，参见 [示例1](#.E7.A4.BA.E4.BE.8B1-.E6.B7.BB.E5.8A.A0.E7.9B.B4.E6.92.AD.E6.8B.89.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// 	- 添加直播推流输入源，参见 [示例2](#.E7.A4.BA.E4.BE.8B2-.E6.B7.BB.E5.8A.A0.E7.9B.B4.E6.92.AD.E6.8E.A8.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// 	- 添加点播拉流输入源，参见 [示例3](#.E7.A4.BA.E4.BE.8B3-.E6.B7.BB.E5.8A.A0.E7.82.B9.E6.92.AD.E6.8B.89.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90.E4.B8.94.E5.BE.AA.E7.8E.AF.E6.92.AD.E6.94.BE)、[示例4](#.E7.A4.BA.E4.BE.8B4-.E6.B7.BB.E5.8A.A0.E7.82.B9.E6.92.AD.E6.8B.89.E6.B5.81.E8.BE.93.E5.85.A5.E6.BA.90.E4.B8.94.E5.8D.95.E6.AC.A1.E6.92.AD.E6.94.BE)；
        /// - `DeleteInput`（删除输入源），参见 [示例5](#.E7.A4.BA.E4.BE.8B5-.E5.88.A0.E9.99.A4.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `ModifyInput`（修改输入源），参见 [示例6](#.E7.A4.BA.E4.BE.8B6-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `AddOutput`（ 添加输出源），参见 [示例7](#.E7.A4.BA.E4.BE.8B7-.E6.B7.BB.E5.8A.A0.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `DeleteOutput`（删除输出源），参见 [示例8](#.E7.A4.BA.E4.BE.8B8-.E5.88.A0.E9.99.A4.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `ModifyOutput`（修改输出源），参见 [示例9](#.E7.A4.BA.E4.BE.8B9-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `Start`（开启转推），参见 [示例10](#.E7.A4.BA.E4.BE.8B10-.E5.BC.80.E5.90.AF.E4.BA.91.E8.BD.AC.E6.8E.A8)；
        /// - `Stop`（停止转推），参见 [示例11](#.E7.A4.BA.E4.BE.8B11-.E5.81.9C.E6.AD.A2.E4.BA.91.E8.BD.AC.E6.8E.A8)；
        /// - `SwitchInput`（切换输入源），参见 [示例12](#.E7.A4.BA.E4.BE.8B12-.E5.88.87.E6.8D.A2.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `ModifyCurrentStopTime`（修改当前计划结束时间），参见 [示例13](#.E7.A4.BA.E4.BE.8B13-.E4.BF.AE.E6.94.B9.E8.BD.AC.E6.8E.A8.E7.BB.93.E6.9D.9F.E6.97.B6.E9.97.B4)。
        /// </summary>
        /// <param name="req"><see cref="HandleStreamConnectProjectRequest"/></param>
        /// <returns><see cref="HandleStreamConnectProjectResponse"/></returns>
        public HandleStreamConnectProjectResponse HandleStreamConnectProjectSync(HandleStreamConnectProjectRequest req)
        {
             JsonResponseModel<HandleStreamConnectProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HandleStreamConnectProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HandleStreamConnectProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将云点播媒资文件导入到云剪媒体资源库。支持导入媒体归属团队或者个人。
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
        /// 将云点播媒资文件导入到云剪媒体资源库。支持导入媒体归属团队或者个人。
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
        /// 将云点播中的媒资或者用户自有媒资文件添加到项目中与项目关联，供后续视频编辑使用。目前仅视频编辑项目和智能视频拆条项目有效。
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
        /// 将云点播中的媒资或者用户自有媒资文件添加到项目中与项目关联，供后续视频编辑使用。目前仅视频编辑项目和智能视频拆条项目有效。
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
        ///  浏览当前分类路径下的资源，包括媒体文件和子分类，返回媒资基础信息和分类信息。
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
        ///  浏览当前分类路径下的资源，包括媒体文件和子分类，返回媒资基础信息和分类信息。
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
        /// 修改媒体信息，支持修改媒体名称、分类路径、标签等信息。
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
        /// 修改媒体信息，支持修改媒体名称、分类路径、标签等信息。
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
        /// 修改项目信息。
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
        /// 修改项目信息。
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
        /// 修改视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="ModifyVideoEncodingPresetResponse"/></returns>
        public async Task<ModifyVideoEncodingPresetResponse> ModifyVideoEncodingPreset(ModifyVideoEncodingPresetRequest req)
        {
             JsonResponseModel<ModifyVideoEncodingPresetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVideoEncodingPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVideoEncodingPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="ModifyVideoEncodingPresetResponse"/></returns>
        public ModifyVideoEncodingPresetResponse ModifyVideoEncodingPresetSync(ModifyVideoEncodingPresetRequest req)
        {
             JsonResponseModel<ModifyVideoEncodingPresetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVideoEncodingPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVideoEncodingPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动某一个分类到另外一个分类下，也可用于分类重命名。
        /// 如果 SourceClassPath = /素材/视频/NBA，DestinationClassPath = /素材/视频/篮球
        /// <li>当 DestinationClassPath 不存在时候，操作结果为重命名 ClassPath；</li>
        /// <li>当 DestinationClassPath 存在时候，操作结果为产生新目录 /素材/视频/篮球/NBA</li>
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
        /// 如果 SourceClassPath = /素材/视频/NBA，DestinationClassPath = /素材/视频/篮球
        /// <li>当 DestinationClassPath 不存在时候，操作结果为重命名 ClassPath；</li>
        /// <li>当 DestinationClassPath 存在时候，操作结果为产生新目录 /素材/视频/篮球/NBA</li>
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
        /// 移动资源，支持跨个人或团队移动媒体以及分类。如果填写了Operator，则需要校验用户对媒体和分类资源的访问以及写权限。
        /// <li>当原始资源为媒体时，该接口效果为将该媒体移动到目标分类下面；</li>
        /// <li>当原始资源为分类时，该接口效果为将原始分类移动到目标分类或者是重命名。</li>
        ///  如果 SourceResource.Resource.Id = /素材/视频/NBA，DestinationResource.Resource.Id= /素材/视频/篮球 
        /// <li>当 DestinationResource.Resource.Id 不存在时候且原始资源与目标资源归属相同，操作结果为重命名原始分类；</li>
        /// <li>当 DestinationResource.Resource.Id 存在时候，操作结果为产生新目录 /素材/视频/篮球/NBA</li>
        /// </summary>
        /// <param name="req"><see cref="MoveResourceRequest"/></param>
        /// <returns><see cref="MoveResourceResponse"/></returns>
        public async Task<MoveResourceResponse> MoveResource(MoveResourceRequest req)
        {
             JsonResponseModel<MoveResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MoveResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动资源，支持跨个人或团队移动媒体以及分类。如果填写了Operator，则需要校验用户对媒体和分类资源的访问以及写权限。
        /// <li>当原始资源为媒体时，该接口效果为将该媒体移动到目标分类下面；</li>
        /// <li>当原始资源为分类时，该接口效果为将原始分类移动到目标分类或者是重命名。</li>
        ///  如果 SourceResource.Resource.Id = /素材/视频/NBA，DestinationResource.Resource.Id= /素材/视频/篮球 
        /// <li>当 DestinationResource.Resource.Id 不存在时候且原始资源与目标资源归属相同，操作结果为重命名原始分类；</li>
        /// <li>当 DestinationResource.Resource.Id 存在时候，操作结果为产生新目录 /素材/视频/篮球/NBA</li>
        /// </summary>
        /// <param name="req"><see cref="MoveResourceRequest"/></param>
        /// <returns><see cref="MoveResourceResponse"/></returns>
        public MoveResourceResponse MoveResourceSync(MoveResourceRequest req)
        {
             JsonResponseModel<MoveResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MoveResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MoveResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口接受制作云回调给客户的事件内容，将其转化为对应的 EventContent 结构，请不要实际调用该接口，只需要将接收到的事件内容直接使用 JSON 解析到 EventContent  即可使用。
        /// </summary>
        /// <param name="req"><see cref="ParseEventRequest"/></param>
        /// <returns><see cref="ParseEventResponse"/></returns>
        public async Task<ParseEventResponse> ParseEvent(ParseEventRequest req)
        {
             JsonResponseModel<ParseEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口接受制作云回调给客户的事件内容，将其转化为对应的 EventContent 结构，请不要实际调用该接口，只需要将接收到的事件内容直接使用 JSON 解析到 EventContent  即可使用。
        /// </summary>
        /// <param name="req"><see cref="ParseEventRequest"/></param>
        /// <returns><see cref="ParseEventResponse"/></returns>
        public ParseEventResponse ParseEventSync(ParseEventRequest req)
        {
             JsonResponseModel<ParseEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ParseEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  资源所属实体对目标实体撤销目标资源的相应权限，若原本没有相应权限则不产生变更。
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
        ///  资源所属实体对目标实体撤销目标资源的相应权限，若原本没有相应权限则不产生变更。
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
        /// 根据检索条件搜索媒体，返回媒体的基本信息。
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
        /// 根据检索条件搜索媒体，返回媒体的基本信息。
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
