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
       private const string sdkVersion = "SDK_NET_3.0.1031";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 向一个团队中添加团队成员，并且指定成员的角色。
        /// </summary>
        /// <param name="req"><see cref="AddTeamMemberRequest"/></param>
        /// <returns><see cref="AddTeamMemberResponse"/></returns>
        public Task<AddTeamMemberResponse> AddTeamMember(AddTeamMemberRequest req)
        {
            return InternalRequestAsync<AddTeamMemberResponse>(req, "AddTeamMember");
        }

        /// <summary>
        /// 向一个团队中添加团队成员，并且指定成员的角色。
        /// </summary>
        /// <param name="req"><see cref="AddTeamMemberRequest"/></param>
        /// <returns><see cref="AddTeamMemberResponse"/></returns>
        public AddTeamMemberResponse AddTeamMemberSync(AddTeamMemberRequest req)
        {
            return InternalRequestAsync<AddTeamMemberResponse>(req, "AddTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制一个项目，包括项目素材及轨道数据。目前仅普通剪辑及模板制作项目可复制，其它类型的项目不支持复制。
        /// </summary>
        /// <param name="req"><see cref="CopyProjectRequest"/></param>
        /// <returns><see cref="CopyProjectResponse"/></returns>
        public Task<CopyProjectResponse> CopyProject(CopyProjectRequest req)
        {
            return InternalRequestAsync<CopyProjectResponse>(req, "CopyProject");
        }

        /// <summary>
        /// 复制一个项目，包括项目素材及轨道数据。目前仅普通剪辑及模板制作项目可复制，其它类型的项目不支持复制。
        /// </summary>
        /// <param name="req"><see cref="CopyProjectRequest"/></param>
        /// <returns><see cref="CopyProjectResponse"/></returns>
        public CopyProjectResponse CopyProjectSync(CopyProjectRequest req)
        {
            return InternalRequestAsync<CopyProjectResponse>(req, "CopyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增分类，用于管理素材。分类层数不能超过20。
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public Task<CreateClassResponse> CreateClass(CreateClassRequest req)
        {
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass");
        }

        /// <summary>
        /// 新增分类，用于管理素材。分类层数不能超过20。
        /// </summary>
        /// <param name="req"><see cref="CreateClassRequest"/></param>
        /// <returns><see cref="CreateClassResponse"/></returns>
        public CreateClassResponse CreateClassSync(CreateClassRequest req)
        {
            return InternalRequestAsync<CreateClassResponse>(req, "CreateClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建媒体链接或分类路径链接，将资源信息链接到目标。
        /// </summary>
        /// <param name="req"><see cref="CreateLinkRequest"/></param>
        /// <returns><see cref="CreateLinkResponse"/></returns>
        public Task<CreateLinkResponse> CreateLink(CreateLinkRequest req)
        {
            return InternalRequestAsync<CreateLinkResponse>(req, "CreateLink");
        }

        /// <summary>
        /// 创建媒体链接或分类路径链接，将资源信息链接到目标。
        /// </summary>
        /// <param name="req"><see cref="CreateLinkRequest"/></param>
        /// <returns><see cref="CreateLinkResponse"/></returns>
        public CreateLinkResponse CreateLinkSync(CreateLinkRequest req)
        {
            return InternalRequestAsync<CreateLinkResponse>(req, "CreateLink")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建多媒体创作引擎项目，目前支持的项目类型有：
        /// <li>视频剪辑项目：用于普通视频剪辑；</li>
        /// <li>直播剪辑项目：用于直播流剪辑；</li>
        /// <li>导播台项目：用于云导播台；</li>
        /// <li>视频拆条：用于视频拆条；</li>
        /// <li>录制回放项目：用于直播录制回放；</li>
        /// <li>云转推项目：用于直播云转推<font color=red>（废弃，可使用媒体转推项目替代）</font>；</li>
        /// <li>媒体转推项目：用于媒体文件转直播输出。</li>
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 创建多媒体创作引擎项目，目前支持的项目类型有：
        /// <li>视频剪辑项目：用于普通视频剪辑；</li>
        /// <li>直播剪辑项目：用于直播流剪辑；</li>
        /// <li>导播台项目：用于云导播台；</li>
        /// <li>视频拆条：用于视频拆条；</li>
        /// <li>录制回放项目：用于直播录制回放；</li>
        /// <li>云转推项目：用于直播云转推<font color=red>（废弃，可使用媒体转推项目替代）</font>；</li>
        /// <li>媒体转推项目：用于媒体文件转直播输出。</li>
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个团队。
        /// </summary>
        /// <param name="req"><see cref="CreateTeamRequest"/></param>
        /// <returns><see cref="CreateTeamResponse"/></returns>
        public Task<CreateTeamResponse> CreateTeam(CreateTeamRequest req)
        {
            return InternalRequestAsync<CreateTeamResponse>(req, "CreateTeam");
        }

        /// <summary>
        /// 创建一个团队。
        /// </summary>
        /// <param name="req"><see cref="CreateTeamRequest"/></param>
        /// <returns><see cref="CreateTeamResponse"/></returns>
        public CreateTeamResponse CreateTeamSync(CreateTeamRequest req)
        {
            return InternalRequestAsync<CreateTeamResponse>(req, "CreateTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 指定导出的参数，创建一个视频编码配置
        /// </summary>
        /// <param name="req"><see cref="CreateVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="CreateVideoEncodingPresetResponse"/></returns>
        public Task<CreateVideoEncodingPresetResponse> CreateVideoEncodingPreset(CreateVideoEncodingPresetRequest req)
        {
            return InternalRequestAsync<CreateVideoEncodingPresetResponse>(req, "CreateVideoEncodingPreset");
        }

        /// <summary>
        /// 指定导出的参数，创建一个视频编码配置
        /// </summary>
        /// <param name="req"><see cref="CreateVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="CreateVideoEncodingPresetResponse"/></returns>
        public CreateVideoEncodingPresetResponse CreateVideoEncodingPresetSync(CreateVideoEncodingPresetRequest req)
        {
            return InternalRequestAsync<CreateVideoEncodingPresetResponse>(req, "CreateVideoEncodingPreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除分类信息，删除时检验下述限制：
        /// <li>分类路径必须存在；</li>
        /// <li>分类下没有绑定素材。</li>
        /// </summary>
        /// <param name="req"><see cref="DeleteClassRequest"/></param>
        /// <returns><see cref="DeleteClassResponse"/></returns>
        public Task<DeleteClassResponse> DeleteClass(DeleteClassRequest req)
        {
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass");
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
            return InternalRequestAsync<DeleteClassResponse>(req, "DeleteClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户登录态，使用户登出多媒体创作引擎平台。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginStatusRequest"/></param>
        /// <returns><see cref="DeleteLoginStatusResponse"/></returns>
        public Task<DeleteLoginStatusResponse> DeleteLoginStatus(DeleteLoginStatusRequest req)
        {
            return InternalRequestAsync<DeleteLoginStatusResponse>(req, "DeleteLoginStatus");
        }

        /// <summary>
        /// 删除用户登录态，使用户登出多媒体创作引擎平台。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginStatusRequest"/></param>
        /// <returns><see cref="DeleteLoginStatusResponse"/></returns>
        public DeleteLoginStatusResponse DeleteLoginStatusSync(DeleteLoginStatusRequest req)
        {
            return InternalRequestAsync<DeleteLoginStatusResponse>(req, "DeleteLoginStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据媒体 Id 删除媒体。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaterialRequest"/></param>
        /// <returns><see cref="DeleteMaterialResponse"/></returns>
        public Task<DeleteMaterialResponse> DeleteMaterial(DeleteMaterialRequest req)
        {
            return InternalRequestAsync<DeleteMaterialResponse>(req, "DeleteMaterial");
        }

        /// <summary>
        /// 根据媒体 Id 删除媒体。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaterialRequest"/></param>
        /// <returns><see cref="DeleteMaterialResponse"/></returns>
        public DeleteMaterialResponse DeleteMaterialSync(DeleteMaterialRequest req)
        {
            return InternalRequestAsync<DeleteMaterialResponse>(req, "DeleteMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目。处于推流状态的云转推和点播转直播项目不允许删除，若强行调用删除项目接口会返回失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 删除项目。处于推流状态的云转推和点播转直播项目不允许删除，若强行调用删除项目接口会返回失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一个团队。要删除团队，必须满足以下条件：
        /// <li>要删除的团队必须没有归属的素材；</li>
        /// <li>要删除的团队必须没有归属的分类。</li>
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamRequest"/></param>
        /// <returns><see cref="DeleteTeamResponse"/></returns>
        public Task<DeleteTeamResponse> DeleteTeam(DeleteTeamRequest req)
        {
            return InternalRequestAsync<DeleteTeamResponse>(req, "DeleteTeam");
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
            return InternalRequestAsync<DeleteTeamResponse>(req, "DeleteTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将团队成员从团队中删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMembersRequest"/></param>
        /// <returns><see cref="DeleteTeamMembersResponse"/></returns>
        public Task<DeleteTeamMembersResponse> DeleteTeamMembers(DeleteTeamMembersRequest req)
        {
            return InternalRequestAsync<DeleteTeamMembersResponse>(req, "DeleteTeamMembers");
        }

        /// <summary>
        /// 将团队成员从团队中删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMembersRequest"/></param>
        /// <returns><see cref="DeleteTeamMembersResponse"/></returns>
        public DeleteTeamMembersResponse DeleteTeamMembersSync(DeleteTeamMembersRequest req)
        {
            return InternalRequestAsync<DeleteTeamMembersResponse>(req, "DeleteTeamMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定 ID 的视频编码配置
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="DeleteVideoEncodingPresetResponse"/></returns>
        public Task<DeleteVideoEncodingPresetResponse> DeleteVideoEncodingPreset(DeleteVideoEncodingPresetRequest req)
        {
            return InternalRequestAsync<DeleteVideoEncodingPresetResponse>(req, "DeleteVideoEncodingPreset");
        }

        /// <summary>
        /// 删除指定 ID 的视频编码配置
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="DeleteVideoEncodingPresetResponse"/></returns>
        public DeleteVideoEncodingPresetResponse DeleteVideoEncodingPresetSync(DeleteVideoEncodingPresetRequest req)
        {
            return InternalRequestAsync<DeleteVideoEncodingPresetResponse>(req, "DeleteVideoEncodingPreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取平台中所有的已注册账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 获取平台中所有的已注册账号。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定归属者下所有的分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassRequest"/></param>
        /// <returns><see cref="DescribeClassResponse"/></returns>
        public Task<DescribeClassResponse> DescribeClass(DescribeClassRequest req)
        {
            return InternalRequestAsync<DescribeClassResponse>(req, "DescribeClass");
        }

        /// <summary>
        /// 获取指定归属者下所有的分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassRequest"/></param>
        /// <returns><see cref="DescribeClassResponse"/></returns>
        public DescribeClassResponse DescribeClassSync(DescribeClassRequest req)
        {
            return InternalRequestAsync<DescribeClassResponse>(req, "DescribeClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户所加入的团队列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJoinTeamsRequest"/></param>
        /// <returns><see cref="DescribeJoinTeamsResponse"/></returns>
        public Task<DescribeJoinTeamsResponse> DescribeJoinTeams(DescribeJoinTeamsRequest req)
        {
            return InternalRequestAsync<DescribeJoinTeamsResponse>(req, "DescribeJoinTeams");
        }

        /// <summary>
        /// 获取用户所加入的团队列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJoinTeamsRequest"/></param>
        /// <returns><see cref="DescribeJoinTeamsResponse"/></returns>
        public DescribeJoinTeamsResponse DescribeJoinTeamsSync(DescribeJoinTeamsRequest req)
        {
            return InternalRequestAsync<DescribeJoinTeamsResponse>(req, "DescribeJoinTeams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定用户的登录态。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginStatusRequest"/></param>
        /// <returns><see cref="DescribeLoginStatusResponse"/></returns>
        public Task<DescribeLoginStatusResponse> DescribeLoginStatus(DescribeLoginStatusRequest req)
        {
            return InternalRequestAsync<DescribeLoginStatusResponse>(req, "DescribeLoginStatus");
        }

        /// <summary>
        /// 查询指定用户的登录态。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginStatusRequest"/></param>
        /// <returns><see cref="DescribeLoginStatusResponse"/></returns>
        public DescribeLoginStatusResponse DescribeLoginStatusSync(DescribeLoginStatusRequest req)
        {
            return InternalRequestAsync<DescribeLoginStatusResponse>(req, "DescribeLoginStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据媒体 Id 批量获取媒体详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaterialsRequest"/></param>
        /// <returns><see cref="DescribeMaterialsResponse"/></returns>
        public Task<DescribeMaterialsResponse> DescribeMaterials(DescribeMaterialsRequest req)
        {
            return InternalRequestAsync<DescribeMaterialsResponse>(req, "DescribeMaterials");
        }

        /// <summary>
        /// 根据媒体 Id 批量获取媒体详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaterialsRequest"/></param>
        /// <returns><see cref="DescribeMaterialsResponse"/></returns>
        public DescribeMaterialsResponse DescribeMaterialsSync(DescribeMaterialsRequest req)
        {
            return InternalRequestAsync<DescribeMaterialsResponse>(req, "DescribeMaterials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribePlatformsResponse> DescribePlatforms(DescribePlatformsRequest req)
        {
            return InternalRequestAsync<DescribePlatformsResponse>(req, "DescribePlatforms");
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
            return InternalRequestAsync<DescribePlatformsResponse>(req, "DescribePlatforms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持根据多种条件过滤出项目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 支持根据多种条件过滤出项目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源被授权的情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeResourceAuthorizationResponse"/></returns>
        public Task<DescribeResourceAuthorizationResponse> DescribeResourceAuthorization(DescribeResourceAuthorizationRequest req)
        {
            return InternalRequestAsync<DescribeResourceAuthorizationResponse>(req, "DescribeResourceAuthorization");
        }

        /// <summary>
        /// 查询资源被授权的情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeResourceAuthorizationResponse"/></returns>
        public DescribeResourceAuthorizationResponse DescribeResourceAuthorizationSync(DescribeResourceAuthorizationRequest req)
        {
            return InternalRequestAsync<DescribeResourceAuthorizationResponse>(req, "DescribeResourceAuthorization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取共享空间。当个人或团队A对个人或团队B授权某资源以后，个人或团队B的共享空间就会增加个人或团队A。
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedSpaceRequest"/></param>
        /// <returns><see cref="DescribeSharedSpaceResponse"/></returns>
        public Task<DescribeSharedSpaceResponse> DescribeSharedSpace(DescribeSharedSpaceRequest req)
        {
            return InternalRequestAsync<DescribeSharedSpaceResponse>(req, "DescribeSharedSpace");
        }

        /// <summary>
        /// 获取共享空间。当个人或团队A对个人或团队B授权某资源以后，个人或团队B的共享空间就会增加个人或团队A。
        /// </summary>
        /// <param name="req"><see cref="DescribeSharedSpaceRequest"/></param>
        /// <returns><see cref="DescribeSharedSpaceResponse"/></returns>
        public DescribeSharedSpaceResponse DescribeSharedSpaceSync(DescribeSharedSpaceRequest req)
        {
            return InternalRequestAsync<DescribeSharedSpaceResponse>(req, "DescribeSharedSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务详情信息，包含下面几个部分：
        /// <li>任务基础信息：包括任务状态、错误信息、创建时间等；</li>
        /// <li>导出项目输出信息：包括输出的素材 Id 等。</li>
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
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
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务列表，支持条件筛选，返回对应的任务基础信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// 获取任务列表，支持条件筛选，返回对应的任务基础信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定团队的成员信息。支持获取指定成员的信息，同时也支持分页拉取指定团队的所有成员信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMembersRequest"/></param>
        /// <returns><see cref="DescribeTeamMembersResponse"/></returns>
        public Task<DescribeTeamMembersResponse> DescribeTeamMembers(DescribeTeamMembersRequest req)
        {
            return InternalRequestAsync<DescribeTeamMembersResponse>(req, "DescribeTeamMembers");
        }

        /// <summary>
        /// 获取指定团队的成员信息。支持获取指定成员的信息，同时也支持分页拉取指定团队的所有成员信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMembersRequest"/></param>
        /// <returns><see cref="DescribeTeamMembersResponse"/></returns>
        public DescribeTeamMembersResponse DescribeTeamMembersSync(DescribeTeamMembersRequest req)
        {
            return InternalRequestAsync<DescribeTeamMembersResponse>(req, "DescribeTeamMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定团队的信息，拉取团队信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamsRequest"/></param>
        /// <returns><see cref="DescribeTeamsResponse"/></returns>
        public Task<DescribeTeamsResponse> DescribeTeams(DescribeTeamsRequest req)
        {
            return InternalRequestAsync<DescribeTeamsResponse>(req, "DescribeTeams");
        }

        /// <summary>
        /// 获取指定团队的信息，拉取团队信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamsRequest"/></param>
        /// <returns><see cref="DescribeTeamsResponse"/></returns>
        public DescribeTeamsResponse DescribeTeamsSync(DescribeTeamsRequest req)
        {
            return InternalRequestAsync<DescribeTeamsResponse>(req, "DescribeTeams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoEncodingPresetsRequest"/></param>
        /// <returns><see cref="DescribeVideoEncodingPresetsResponse"/></returns>
        public Task<DescribeVideoEncodingPresetsResponse> DescribeVideoEncodingPresets(DescribeVideoEncodingPresetsRequest req)
        {
            return InternalRequestAsync<DescribeVideoEncodingPresetsResponse>(req, "DescribeVideoEncodingPresets");
        }

        /// <summary>
        /// 查询视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoEncodingPresetsRequest"/></param>
        /// <returns><see cref="DescribeVideoEncodingPresetsResponse"/></returns>
        public DescribeVideoEncodingPresetsResponse DescribeVideoEncodingPresetsSync(DescribeVideoEncodingPresetsRequest req)
        {
            return InternalRequestAsync<DescribeVideoEncodingPresetsResponse>(req, "DescribeVideoEncodingPresets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用 [视频合成协议](https://cloud.tencent.com/document/product/1156/51225) 合成视频，支持导出视频到 CME 云媒资或者云点播媒资。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByEditorTrackDataRequest"/></param>
        /// <returns><see cref="ExportVideoByEditorTrackDataResponse"/></returns>
        public Task<ExportVideoByEditorTrackDataResponse> ExportVideoByEditorTrackData(ExportVideoByEditorTrackDataRequest req)
        {
            return InternalRequestAsync<ExportVideoByEditorTrackDataResponse>(req, "ExportVideoByEditorTrackData");
        }

        /// <summary>
        /// 使用 [视频合成协议](https://cloud.tencent.com/document/product/1156/51225) 合成视频，支持导出视频到 CME 云媒资或者云点播媒资。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByEditorTrackDataRequest"/></param>
        /// <returns><see cref="ExportVideoByEditorTrackDataResponse"/></returns>
        public ExportVideoByEditorTrackDataResponse ExportVideoByEditorTrackDataSync(ExportVideoByEditorTrackDataRequest req)
        {
            return InternalRequestAsync<ExportVideoByEditorTrackDataResponse>(req, "ExportVideoByEditorTrackData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用视频剪辑模板直接导出视频。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByTemplateRequest"/></param>
        /// <returns><see cref="ExportVideoByTemplateResponse"/></returns>
        public Task<ExportVideoByTemplateResponse> ExportVideoByTemplate(ExportVideoByTemplateRequest req)
        {
            return InternalRequestAsync<ExportVideoByTemplateResponse>(req, "ExportVideoByTemplate");
        }

        /// <summary>
        /// 使用视频剪辑模板直接导出视频。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByTemplateRequest"/></param>
        /// <returns><see cref="ExportVideoByTemplateResponse"/></returns>
        public ExportVideoByTemplateResponse ExportVideoByTemplateSync(ExportVideoByTemplateRequest req)
        {
            return InternalRequestAsync<ExportVideoByTemplateResponse>(req, "ExportVideoByTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用视频智能拆条数据导出视频，将指定的视频拆条片段导出为一个视频(内测中，请勿使用)。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByVideoSegmentationDataRequest"/></param>
        /// <returns><see cref="ExportVideoByVideoSegmentationDataResponse"/></returns>
        public Task<ExportVideoByVideoSegmentationDataResponse> ExportVideoByVideoSegmentationData(ExportVideoByVideoSegmentationDataRequest req)
        {
            return InternalRequestAsync<ExportVideoByVideoSegmentationDataResponse>(req, "ExportVideoByVideoSegmentationData");
        }

        /// <summary>
        /// 使用视频智能拆条数据导出视频，将指定的视频拆条片段导出为一个视频(内测中，请勿使用)。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoByVideoSegmentationDataRequest"/></param>
        /// <returns><see cref="ExportVideoByVideoSegmentationDataResponse"/></returns>
        public ExportVideoByVideoSegmentationDataResponse ExportVideoByVideoSegmentationDataSync(ExportVideoByVideoSegmentationDataRequest req)
        {
            return InternalRequestAsync<ExportVideoByVideoSegmentationDataResponse>(req, "ExportVideoByVideoSegmentationData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出视频编辑项目，支持指定输出的模板。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoEditProjectRequest"/></param>
        /// <returns><see cref="ExportVideoEditProjectResponse"/></returns>
        public Task<ExportVideoEditProjectResponse> ExportVideoEditProject(ExportVideoEditProjectRequest req)
        {
            return InternalRequestAsync<ExportVideoEditProjectResponse>(req, "ExportVideoEditProject");
        }

        /// <summary>
        /// 导出视频编辑项目，支持指定输出的模板。
        /// </summary>
        /// <param name="req"><see cref="ExportVideoEditProjectRequest"/></param>
        /// <returns><see cref="ExportVideoEditProjectResponse"/></returns>
        public ExportVideoEditProjectResponse ExportVideoEditProjectSync(ExportVideoEditProjectRequest req)
        {
            return InternalRequestAsync<ExportVideoEditProjectResponse>(req, "ExportVideoEditProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 平铺分类路径下及其子分类下的所有媒体基础信息，返回当前分类及子分类中的所有媒体的基础信息。
        /// </summary>
        /// <param name="req"><see cref="FlattenListMediaRequest"/></param>
        /// <returns><see cref="FlattenListMediaResponse"/></returns>
        public Task<FlattenListMediaResponse> FlattenListMedia(FlattenListMediaRequest req)
        {
            return InternalRequestAsync<FlattenListMediaResponse>(req, "FlattenListMedia");
        }

        /// <summary>
        /// 平铺分类路径下及其子分类下的所有媒体基础信息，返回当前分类及子分类中的所有媒体的基础信息。
        /// </summary>
        /// <param name="req"><see cref="FlattenListMediaRequest"/></param>
        /// <returns><see cref="FlattenListMediaResponse"/></returns>
        public FlattenListMediaResponse FlattenListMediaSync(FlattenListMediaRequest req)
        {
            return InternalRequestAsync<FlattenListMediaResponse>(req, "FlattenListMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <li>发起视频智能拆条任务，支持智能生成和平精英集锦、王者荣耀集锦、足球集锦、篮球集锦 、人物集锦、新闻拆条等任务。</li>
        /// <li>和平精英集锦和王者荣耀集锦根据击杀场景进行拆条，足球集锦和篮球集锦根据进球场景进行拆条，人物集锦根据人物人脸特征进行拆条，新闻拆条根据导播进行拆条。</li>
        /// <li>【本接口内测中，暂不建议使用】</li>
        /// </summary>
        /// <param name="req"><see cref="GenerateVideoSegmentationSchemeByAiRequest"/></param>
        /// <returns><see cref="GenerateVideoSegmentationSchemeByAiResponse"/></returns>
        public Task<GenerateVideoSegmentationSchemeByAiResponse> GenerateVideoSegmentationSchemeByAi(GenerateVideoSegmentationSchemeByAiRequest req)
        {
            return InternalRequestAsync<GenerateVideoSegmentationSchemeByAiResponse>(req, "GenerateVideoSegmentationSchemeByAi");
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
            return InternalRequestAsync<GenerateVideoSegmentationSchemeByAiResponse>(req, "GenerateVideoSegmentationSchemeByAi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源归属者对个人或团队授予目标资源的相应权限。
        /// </summary>
        /// <param name="req"><see cref="GrantResourceAuthorizationRequest"/></param>
        /// <returns><see cref="GrantResourceAuthorizationResponse"/></returns>
        public Task<GrantResourceAuthorizationResponse> GrantResourceAuthorization(GrantResourceAuthorizationRequest req)
        {
            return InternalRequestAsync<GrantResourceAuthorizationResponse>(req, "GrantResourceAuthorization");
        }

        /// <summary>
        /// 资源归属者对个人或团队授予目标资源的相应权限。
        /// </summary>
        /// <param name="req"><see cref="GrantResourceAuthorizationRequest"/></param>
        /// <returns><see cref="GrantResourceAuthorizationResponse"/></returns>
        public GrantResourceAuthorizationResponse GrantResourceAuthorizationSync(GrantResourceAuthorizationRequest req)
        {
            return InternalRequestAsync<GrantResourceAuthorizationResponse>(req, "GrantResourceAuthorization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对媒体转推项目进行操作。
        /// ### 操作类型<a id="Operation"></a>
        /// - `AddSource`（添加输入源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B9-.E6.B7.BB.E5.8A.A0.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `DeleteSource`（删除输入源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B6-.E5.88.A0.E9.99.A4.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `SwitchSource`（切换当前播放的输入源），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B5-.E5.88.87.E6.8D.A2.E5.BD.93.E5.89.8D.E6.92.AD.E6.94.BE.E7.9A.84.E8.BE.93.E5.85.A5.E6.BA.90)
        /// - `AddDestination`（ 添加输出源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B8-.E5.90.AF.E5.8A.A8.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `DeleteDestination`（删除输出源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B7-.E5.88.A0.E9.99.A4.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `EnableDestination`（启动输出源），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B8-.E5.90.AF.E5.8A.A8.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `DisableDestination`（停止输出源），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B4-.E5.81.9C.E6.AD.A2.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `ModifyDestination`（修改输出源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B2-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `Start`（启动媒体转推），项目状态为 Idle 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B12-.E5.90.AF.E5.8A.A8.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8)。发起 Start 请求成功后，媒体转推项目开始启动，30秒内还需要再进行一次 Confirm操作进行确认；
        /// - `Confirm`（确认媒体转推项目启动），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B14-.E7.A1.AE.E8.AE.A4.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8.E9.A1.B9.E7.9B.AE.E5.90.AF.E5.8A.A8)；
        /// - `Stop`（停止媒体转推），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B11-.E5.81.9C.E6.AD.A2.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8)；
        /// - `ModifyOutputMediaSetting`（修改媒体输出配置），项目状态为 Idle 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B3-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.87.BA.E7.9A.84.E5.AA.92.E4.BD.93.E9.85.8D.E7.BD.AE)；
        /// - `ModifyPlaySetting`（修改播放结束时间），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B1-.E4.BF.AE.E6.94.B9.E7.BB.93.E6.9D.9F.E6.97.B6.E9.97.B4);
        /// - `DescribePlayInfo`（查询播放信息），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B13-.E6.9F.A5.E8.AF.A2.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8.E9.A1.B9.E7.9B.AE.E7.9A.84.E6.92.AD.E6.94.BE.E4.BF.A1.E6.81.AF)。
        /// </summary>
        /// <param name="req"><see cref="HandleMediaCastProjectRequest"/></param>
        /// <returns><see cref="HandleMediaCastProjectResponse"/></returns>
        public Task<HandleMediaCastProjectResponse> HandleMediaCastProject(HandleMediaCastProjectRequest req)
        {
            return InternalRequestAsync<HandleMediaCastProjectResponse>(req, "HandleMediaCastProject");
        }

        /// <summary>
        /// 对媒体转推项目进行操作。
        /// ### 操作类型<a id="Operation"></a>
        /// - `AddSource`（添加输入源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B9-.E6.B7.BB.E5.8A.A0.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `DeleteSource`（删除输入源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B6-.E5.88.A0.E9.99.A4.E8.BE.93.E5.85.A5.E6.BA.90)；
        /// - `SwitchSource`（切换当前播放的输入源），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B5-.E5.88.87.E6.8D.A2.E5.BD.93.E5.89.8D.E6.92.AD.E6.94.BE.E7.9A.84.E8.BE.93.E5.85.A5.E6.BA.90)
        /// - `AddDestination`（ 添加输出源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B8-.E5.90.AF.E5.8A.A8.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `DeleteDestination`（删除输出源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B7-.E5.88.A0.E9.99.A4.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `EnableDestination`（启动输出源），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B8-.E5.90.AF.E5.8A.A8.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `DisableDestination`（停止输出源），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B4-.E5.81.9C.E6.AD.A2.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `ModifyDestination`（修改输出源），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B2-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.87.BA.E6.BA.90)；
        /// - `Start`（启动媒体转推），项目状态为 Idle 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B12-.E5.90.AF.E5.8A.A8.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8)。发起 Start 请求成功后，媒体转推项目开始启动，30秒内还需要再进行一次 Confirm操作进行确认；
        /// - `Confirm`（确认媒体转推项目启动），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B14-.E7.A1.AE.E8.AE.A4.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8.E9.A1.B9.E7.9B.AE.E5.90.AF.E5.8A.A8)；
        /// - `Stop`（停止媒体转推），项目状态为 Working 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B11-.E5.81.9C.E6.AD.A2.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8)；
        /// - `ModifyOutputMediaSetting`（修改媒体输出配置），项目状态为 Idle 时可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B3-.E4.BF.AE.E6.94.B9.E8.BE.93.E5.87.BA.E7.9A.84.E5.AA.92.E4.BD.93.E9.85.8D.E7.BD.AE)；
        /// - `ModifyPlaySetting`（修改播放结束时间），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B1-.E4.BF.AE.E6.94.B9.E7.BB.93.E6.9D.9F.E6.97.B6.E9.97.B4);
        /// - `DescribePlayInfo`（查询播放信息），项目状态为 Idle、Working 时均可以操作。参见 [示例](#.E7.A4.BA.E4.BE.8B13-.E6.9F.A5.E8.AF.A2.E5.AA.92.E4.BD.93.E8.BD.AC.E6.8E.A8.E9.A1.B9.E7.9B.AE.E7.9A.84.E6.92.AD.E6.94.BE.E4.BF.A1.E6.81.AF)。
        /// </summary>
        /// <param name="req"><see cref="HandleMediaCastProjectRequest"/></param>
        /// <returns><see cref="HandleMediaCastProjectResponse"/></returns>
        public HandleMediaCastProjectResponse HandleMediaCastProjectSync(HandleMediaCastProjectRequest req)
        {
            return InternalRequestAsync<HandleMediaCastProjectResponse>(req, "HandleMediaCastProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <font color=red>本接口废弃，可创建媒体转推项目替代，操作媒体转推项目可使用 <b>[HandleMediaCastProject 接口](/document/product/1156/87841) </b>实现。</font>
        /// 
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
        /// - `ModifyCurrentStopTime`（修改当前计划结束时间），参见 [示例13](#.E7.A4.BA.E4.BE.8B13-.E4.BF.AE.E6.94.B9.E8.BD.AC.E6.8E.A8.E7.BB.93.E6.9D.9F.E6.97.B6.E9.97.B4);
        /// - `DescribeInputPlayInfo`（查询播放进度），参见 [示例14](#.E7.A4.BA.E4.BE.8B14-.E6.9F.A5.E8.AF.A2.E7.82.B9.E6.92.AD.E8.BE.93.E5.85.A5.E6.BA.90.E6.92.AD.E6.94.BE.E8.BF.9B.E5.BA.A6)。
        /// </summary>
        /// <param name="req"><see cref="HandleStreamConnectProjectRequest"/></param>
        /// <returns><see cref="HandleStreamConnectProjectResponse"/></returns>
        public Task<HandleStreamConnectProjectResponse> HandleStreamConnectProject(HandleStreamConnectProjectRequest req)
        {
            return InternalRequestAsync<HandleStreamConnectProjectResponse>(req, "HandleStreamConnectProject");
        }

        /// <summary>
        /// <font color=red>本接口废弃，可创建媒体转推项目替代，操作媒体转推项目可使用 <b>[HandleMediaCastProject 接口](/document/product/1156/87841) </b>实现。</font>
        /// 
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
        /// - `ModifyCurrentStopTime`（修改当前计划结束时间），参见 [示例13](#.E7.A4.BA.E4.BE.8B13-.E4.BF.AE.E6.94.B9.E8.BD.AC.E6.8E.A8.E7.BB.93.E6.9D.9F.E6.97.B6.E9.97.B4);
        /// - `DescribeInputPlayInfo`（查询播放进度），参见 [示例14](#.E7.A4.BA.E4.BE.8B14-.E6.9F.A5.E8.AF.A2.E7.82.B9.E6.92.AD.E8.BE.93.E5.85.A5.E6.BA.90.E6.92.AD.E6.94.BE.E8.BF.9B.E5.BA.A6)。
        /// </summary>
        /// <param name="req"><see cref="HandleStreamConnectProjectRequest"/></param>
        /// <returns><see cref="HandleStreamConnectProjectResponse"/></returns>
        public HandleStreamConnectProjectResponse HandleStreamConnectProjectSync(HandleStreamConnectProjectRequest req)
        {
            return InternalRequestAsync<HandleStreamConnectProjectResponse>(req, "HandleStreamConnectProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将云点播媒资文件导入到多媒体创作引擎媒体资源库。支持导入媒体归属团队或者个人。
        /// </summary>
        /// <param name="req"><see cref="ImportMaterialRequest"/></param>
        /// <returns><see cref="ImportMaterialResponse"/></returns>
        public Task<ImportMaterialResponse> ImportMaterial(ImportMaterialRequest req)
        {
            return InternalRequestAsync<ImportMaterialResponse>(req, "ImportMaterial");
        }

        /// <summary>
        /// 将云点播媒资文件导入到多媒体创作引擎媒体资源库。支持导入媒体归属团队或者个人。
        /// </summary>
        /// <param name="req"><see cref="ImportMaterialRequest"/></param>
        /// <returns><see cref="ImportMaterialResponse"/></returns>
        public ImportMaterialResponse ImportMaterialSync(ImportMaterialRequest req)
        {
            return InternalRequestAsync<ImportMaterialResponse>(req, "ImportMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将云点播中的媒资或者用户自有媒资文件添加到项目中与项目关联，供后续视频编辑使用。目前仅视频编辑项目和智能视频拆条项目有效。
        /// </summary>
        /// <param name="req"><see cref="ImportMediaToProjectRequest"/></param>
        /// <returns><see cref="ImportMediaToProjectResponse"/></returns>
        public Task<ImportMediaToProjectResponse> ImportMediaToProject(ImportMediaToProjectRequest req)
        {
            return InternalRequestAsync<ImportMediaToProjectResponse>(req, "ImportMediaToProject");
        }

        /// <summary>
        /// 将云点播中的媒资或者用户自有媒资文件添加到项目中与项目关联，供后续视频编辑使用。目前仅视频编辑项目和智能视频拆条项目有效。
        /// </summary>
        /// <param name="req"><see cref="ImportMediaToProjectRequest"/></param>
        /// <returns><see cref="ImportMediaToProjectResponse"/></returns>
        public ImportMediaToProjectResponse ImportMediaToProjectSync(ImportMediaToProjectRequest req)
        {
            return InternalRequestAsync<ImportMediaToProjectResponse>(req, "ImportMediaToProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 浏览当前分类路径下的资源，包括媒体文件和子分类，返回媒资基础信息和分类信息。
        /// </summary>
        /// <param name="req"><see cref="ListMediaRequest"/></param>
        /// <returns><see cref="ListMediaResponse"/></returns>
        public Task<ListMediaResponse> ListMedia(ListMediaRequest req)
        {
            return InternalRequestAsync<ListMediaResponse>(req, "ListMedia");
        }

        /// <summary>
        /// 浏览当前分类路径下的资源，包括媒体文件和子分类，返回媒资基础信息和分类信息。
        /// </summary>
        /// <param name="req"><see cref="ListMediaRequest"/></param>
        /// <returns><see cref="ListMediaResponse"/></returns>
        public ListMediaResponse ListMediaSync(ListMediaRequest req)
        {
            return InternalRequestAsync<ListMediaResponse>(req, "ListMedia")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改媒体信息，支持修改媒体名称、分类路径、标签等信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaterialRequest"/></param>
        /// <returns><see cref="ModifyMaterialResponse"/></returns>
        public Task<ModifyMaterialResponse> ModifyMaterial(ModifyMaterialRequest req)
        {
            return InternalRequestAsync<ModifyMaterialResponse>(req, "ModifyMaterial");
        }

        /// <summary>
        /// 修改媒体信息，支持修改媒体名称、分类路径、标签等信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaterialRequest"/></param>
        /// <returns><see cref="ModifyMaterialResponse"/></returns>
        public ModifyMaterialResponse ModifyMaterialSync(ModifyMaterialRequest req)
        {
            return InternalRequestAsync<ModifyMaterialResponse>(req, "ModifyMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 修改项目信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改团队信息，目前支持修改的操作有：
        /// <li>修改团队名称。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public Task<ModifyTeamResponse> ModifyTeam(ModifyTeamRequest req)
        {
            return InternalRequestAsync<ModifyTeamResponse>(req, "ModifyTeam");
        }

        /// <summary>
        /// 修改团队信息，目前支持修改的操作有：
        /// <li>修改团队名称。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public ModifyTeamResponse ModifyTeamSync(ModifyTeamRequest req)
        {
            return InternalRequestAsync<ModifyTeamResponse>(req, "ModifyTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改团队成员信息，包括成员备注、角色等。
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public Task<ModifyTeamMemberResponse> ModifyTeamMember(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember");
        }

        /// <summary>
        /// 修改团队成员信息，包括成员备注、角色等。
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public ModifyTeamMemberResponse ModifyTeamMemberSync(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="ModifyVideoEncodingPresetResponse"/></returns>
        public Task<ModifyVideoEncodingPresetResponse> ModifyVideoEncodingPreset(ModifyVideoEncodingPresetRequest req)
        {
            return InternalRequestAsync<ModifyVideoEncodingPresetResponse>(req, "ModifyVideoEncodingPreset");
        }

        /// <summary>
        /// 修改视频编码配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoEncodingPresetRequest"/></param>
        /// <returns><see cref="ModifyVideoEncodingPresetResponse"/></returns>
        public ModifyVideoEncodingPresetResponse ModifyVideoEncodingPresetSync(ModifyVideoEncodingPresetRequest req)
        {
            return InternalRequestAsync<ModifyVideoEncodingPresetResponse>(req, "ModifyVideoEncodingPreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移动某一个分类到另外一个分类下，也可用于分类重命名。
        /// 如果 SourceClassPath = /素材/视频/NBA，DestinationClassPath = /素材/视频/篮球
        /// <li>当 DestinationClassPath 不存在时候，操作结果为重命名 ClassPath；</li>
        /// <li>当 DestinationClassPath 存在时候，操作结果为产生新目录 /素材/视频/篮球/NBA</li>
        /// </summary>
        /// <param name="req"><see cref="MoveClassRequest"/></param>
        /// <returns><see cref="MoveClassResponse"/></returns>
        public Task<MoveClassResponse> MoveClass(MoveClassRequest req)
        {
            return InternalRequestAsync<MoveClassResponse>(req, "MoveClass");
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
            return InternalRequestAsync<MoveClassResponse>(req, "MoveClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<MoveResourceResponse> MoveResource(MoveResourceRequest req)
        {
            return InternalRequestAsync<MoveResourceResponse>(req, "MoveResource");
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
            return InternalRequestAsync<MoveResourceResponse>(req, "MoveResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口接受多媒体创作引擎回调给业务的事件内容，将其转化为对应的 EventContent 结构。请不要实际调用该接口，只需要将接收到的事件内容直接使用 JSON 解析到 EventContent  结构即可使用。
        /// </summary>
        /// <param name="req"><see cref="ParseEventRequest"/></param>
        /// <returns><see cref="ParseEventResponse"/></returns>
        public Task<ParseEventResponse> ParseEvent(ParseEventRequest req)
        {
            return InternalRequestAsync<ParseEventResponse>(req, "ParseEvent");
        }

        /// <summary>
        /// 该接口接受多媒体创作引擎回调给业务的事件内容，将其转化为对应的 EventContent 结构。请不要实际调用该接口，只需要将接收到的事件内容直接使用 JSON 解析到 EventContent  结构即可使用。
        /// </summary>
        /// <param name="req"><see cref="ParseEventRequest"/></param>
        /// <returns><see cref="ParseEventResponse"/></returns>
        public ParseEventResponse ParseEventSync(ParseEventRequest req)
        {
            return InternalRequestAsync<ParseEventResponse>(req, "ParseEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  资源所属实体对目标实体撤销目标资源的相应权限，若原本没有相应权限则不产生变更。
        /// </summary>
        /// <param name="req"><see cref="RevokeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="RevokeResourceAuthorizationResponse"/></returns>
        public Task<RevokeResourceAuthorizationResponse> RevokeResourceAuthorization(RevokeResourceAuthorizationRequest req)
        {
            return InternalRequestAsync<RevokeResourceAuthorizationResponse>(req, "RevokeResourceAuthorization");
        }

        /// <summary>
        ///  资源所属实体对目标实体撤销目标资源的相应权限，若原本没有相应权限则不产生变更。
        /// </summary>
        /// <param name="req"><see cref="RevokeResourceAuthorizationRequest"/></param>
        /// <returns><see cref="RevokeResourceAuthorizationResponse"/></returns>
        public RevokeResourceAuthorizationResponse RevokeResourceAuthorizationSync(RevokeResourceAuthorizationRequest req)
        {
            return InternalRequestAsync<RevokeResourceAuthorizationResponse>(req, "RevokeResourceAuthorization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据检索条件搜索媒体，返回媒体的基本信息。
        /// </summary>
        /// <param name="req"><see cref="SearchMaterialRequest"/></param>
        /// <returns><see cref="SearchMaterialResponse"/></returns>
        public Task<SearchMaterialResponse> SearchMaterial(SearchMaterialRequest req)
        {
            return InternalRequestAsync<SearchMaterialResponse>(req, "SearchMaterial");
        }

        /// <summary>
        /// 根据检索条件搜索媒体，返回媒体的基本信息。
        /// </summary>
        /// <param name="req"><see cref="SearchMaterialRequest"/></param>
        /// <returns><see cref="SearchMaterialResponse"/></returns>
        public SearchMaterialResponse SearchMaterialSync(SearchMaterialRequest req)
        {
            return InternalRequestAsync<SearchMaterialResponse>(req, "SearchMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
