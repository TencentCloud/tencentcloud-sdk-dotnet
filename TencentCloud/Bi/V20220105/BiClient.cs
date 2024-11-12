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

namespace TencentCloud.Bi.V20220105
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bi.V20220105.Models;

   public class BiClient : AbstractClient{

       private const string endpoint = "bi.tencentcloudapi.com";
       private const string version = "2022-01-05";
       private const string sdkVersion = "SDK_NET_3.0.1122";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 申请延长Token可用时间接口-强鉴权
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public Task<ApplyEmbedIntervalResponse> ApplyEmbedInterval(ApplyEmbedIntervalRequest req)
        {
            return InternalRequestAsync<ApplyEmbedIntervalResponse>(req, "ApplyEmbedInterval");
        }

        /// <summary>
        /// 申请延长Token可用时间接口-强鉴权
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public ApplyEmbedIntervalResponse ApplyEmbedIntervalSync(ApplyEmbedIntervalRequest req)
        {
            return InternalRequestAsync<ApplyEmbedIntervalResponse>(req, "ApplyEmbedInterval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceRequest"/></param>
        /// <returns><see cref="CreateDatasourceResponse"/></returns>
        public Task<CreateDatasourceResponse> CreateDatasource(CreateDatasourceRequest req)
        {
            return InternalRequestAsync<CreateDatasourceResponse>(req, "CreateDatasource");
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceRequest"/></param>
        /// <returns><see cref="CreateDatasourceResponse"/></returns>
        public CreateDatasourceResponse CreateDatasourceSync(CreateDatasourceRequest req)
        {
            return InternalRequestAsync<CreateDatasourceResponse>(req, "CreateDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云数据库
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceCloudRequest"/></param>
        /// <returns><see cref="CreateDatasourceCloudResponse"/></returns>
        public Task<CreateDatasourceCloudResponse> CreateDatasourceCloud(CreateDatasourceCloudRequest req)
        {
            return InternalRequestAsync<CreateDatasourceCloudResponse>(req, "CreateDatasourceCloud");
        }

        /// <summary>
        /// 创建云数据库
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceCloudRequest"/></param>
        /// <returns><see cref="CreateDatasourceCloudResponse"/></returns>
        public CreateDatasourceCloudResponse CreateDatasourceCloudSync(CreateDatasourceCloudRequest req)
        {
            return InternalRequestAsync<CreateDatasourceCloudResponse>(req, "CreateDatasourceCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建嵌出报表-强鉴权
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public Task<CreateEmbedTokenResponse> CreateEmbedToken(CreateEmbedTokenRequest req)
        {
            return InternalRequestAsync<CreateEmbedTokenResponse>(req, "CreateEmbedToken");
        }

        /// <summary>
        /// 创建嵌出报表-强鉴权
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public CreateEmbedTokenResponse CreateEmbedTokenSync(CreateEmbedTokenRequest req)
        {
            return InternalRequestAsync<CreateEmbedTokenResponse>(req, "CreateEmbedToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public Task<CreateUserRoleResponse> CreateUserRole(CreateUserRoleRequest req)
        {
            return InternalRequestAsync<CreateUserRoleResponse>(req, "CreateUserRole");
        }

        /// <summary>
        /// 创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public CreateUserRoleResponse CreateUserRoleSync(CreateUserRoleRequest req)
        {
            return InternalRequestAsync<CreateUserRoleResponse>(req, "CreateUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目内-创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleProjectRequest"/></param>
        /// <returns><see cref="CreateUserRoleProjectResponse"/></returns>
        public Task<CreateUserRoleProjectResponse> CreateUserRoleProject(CreateUserRoleProjectRequest req)
        {
            return InternalRequestAsync<CreateUserRoleProjectResponse>(req, "CreateUserRoleProject");
        }

        /// <summary>
        /// 项目内-创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleProjectRequest"/></param>
        /// <returns><see cref="CreateUserRoleProjectResponse"/></returns>
        public CreateUserRoleProjectResponse CreateUserRoleProjectSync(CreateUserRoleProjectRequest req)
        {
            return InternalRequestAsync<CreateUserRoleProjectResponse>(req, "CreateUserRoleProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasourceRequest"/></param>
        /// <returns><see cref="DeleteDatasourceResponse"/></returns>
        public Task<DeleteDatasourceResponse> DeleteDatasource(DeleteDatasourceRequest req)
        {
            return InternalRequestAsync<DeleteDatasourceResponse>(req, "DeleteDatasource");
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasourceRequest"/></param>
        /// <returns><see cref="DeleteDatasourceResponse"/></returns>
        public DeleteDatasourceResponse DeleteDatasourceSync(DeleteDatasourceRequest req)
        {
            return InternalRequestAsync<DeleteDatasourceResponse>(req, "DeleteDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户角色，会删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleRequest"/></param>
        /// <returns><see cref="DeleteUserRoleResponse"/></returns>
        public Task<DeleteUserRoleResponse> DeleteUserRole(DeleteUserRoleRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleResponse>(req, "DeleteUserRole");
        }

        /// <summary>
        /// 删除用户角色，会删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleRequest"/></param>
        /// <returns><see cref="DeleteUserRoleResponse"/></returns>
        public DeleteUserRoleResponse DeleteUserRoleSync(DeleteUserRoleRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleResponse>(req, "DeleteUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目内-删除用户角色
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleProjectRequest"/></param>
        /// <returns><see cref="DeleteUserRoleProjectResponse"/></returns>
        public Task<DeleteUserRoleProjectResponse> DeleteUserRoleProject(DeleteUserRoleProjectRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleProjectResponse>(req, "DeleteUserRoleProject");
        }

        /// <summary>
        /// 项目内-删除用户角色
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleProjectRequest"/></param>
        /// <returns><see cref="DeleteUserRoleProjectResponse"/></returns>
        public DeleteUserRoleProjectResponse DeleteUserRoleProjectSync(DeleteUserRoleProjectRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleProjectResponse>(req, "DeleteUserRoleProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceListRequest"/></param>
        /// <returns><see cref="DescribeDatasourceListResponse"/></returns>
        public Task<DescribeDatasourceListResponse> DescribeDatasourceList(DescribeDatasourceListRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceListResponse>(req, "DescribeDatasourceList");
        }

        /// <summary>
        /// 查询数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceListRequest"/></param>
        /// <returns><see cref="DescribeDatasourceListResponse"/></returns>
        public DescribeDatasourceListResponse DescribeDatasourceListSync(DescribeDatasourceListRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceListResponse>(req, "DescribeDatasourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public Task<DescribeProjectInfoResponse> DescribeProjectInfo(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo");
        }

        /// <summary>
        /// 项目详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public DescribeProjectInfoResponse DescribeProjectInfoSync(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public Task<DescribeProjectListResponse> DescribeProjectList(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList");
        }

        /// <summary>
        /// 项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public DescribeProjectListResponse DescribeProjectListSync(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目内-用户接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUserProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserProjectListResponse"/></returns>
        public Task<DescribeUserProjectListResponse> DescribeUserProjectList(DescribeUserProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserProjectListResponse>(req, "DescribeUserProjectList");
        }

        /// <summary>
        /// 项目内-用户接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUserProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserProjectListResponse"/></returns>
        public DescribeUserProjectListResponse DescribeUserProjectListSync(DescribeUserProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserProjectListResponse>(req, "DescribeUserProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleListResponse"/></returns>
        public Task<DescribeUserRoleListResponse> DescribeUserRoleList(DescribeUserRoleListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleListResponse>(req, "DescribeUserRoleList");
        }

        /// <summary>
        /// 用户角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleListResponse"/></returns>
        public DescribeUserRoleListResponse DescribeUserRoleListSync(DescribeUserRoleListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleListResponse>(req, "DescribeUserRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目内-用户角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleProjectListResponse"/></returns>
        public Task<DescribeUserRoleProjectListResponse> DescribeUserRoleProjectList(DescribeUserRoleProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleProjectListResponse>(req, "DescribeUserRoleProjectList");
        }

        /// <summary>
        /// 项目内-用户角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleProjectListResponse"/></returns>
        public DescribeUserRoleProjectListResponse DescribeUserRoleProjectListSync(DescribeUserRoleProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleProjectListResponse>(req, "DescribeUserRoleProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceRequest"/></param>
        /// <returns><see cref="ModifyDatasourceResponse"/></returns>
        public Task<ModifyDatasourceResponse> ModifyDatasource(ModifyDatasourceRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceResponse>(req, "ModifyDatasource");
        }

        /// <summary>
        /// 更新数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceRequest"/></param>
        /// <returns><see cref="ModifyDatasourceResponse"/></returns>
        public ModifyDatasourceResponse ModifyDatasourceSync(ModifyDatasourceRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceResponse>(req, "ModifyDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新云数据库
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceCloudRequest"/></param>
        /// <returns><see cref="ModifyDatasourceCloudResponse"/></returns>
        public Task<ModifyDatasourceCloudResponse> ModifyDatasourceCloud(ModifyDatasourceCloudRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceCloudResponse>(req, "ModifyDatasourceCloud");
        }

        /// <summary>
        /// 更新云数据库
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceCloudRequest"/></param>
        /// <returns><see cref="ModifyDatasourceCloudResponse"/></returns>
        public ModifyDatasourceCloudResponse ModifyDatasourceCloudSync(ModifyDatasourceCloudRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceCloudResponse>(req, "ModifyDatasourceCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 修改项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleRequest"/></param>
        /// <returns><see cref="ModifyUserRoleResponse"/></returns>
        public Task<ModifyUserRoleResponse> ModifyUserRole(ModifyUserRoleRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleResponse>(req, "ModifyUserRole");
        }

        /// <summary>
        /// 修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleRequest"/></param>
        /// <returns><see cref="ModifyUserRoleResponse"/></returns>
        public ModifyUserRoleResponse ModifyUserRoleSync(ModifyUserRoleRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleResponse>(req, "ModifyUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 项目-修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleProjectRequest"/></param>
        /// <returns><see cref="ModifyUserRoleProjectResponse"/></returns>
        public Task<ModifyUserRoleProjectResponse> ModifyUserRoleProject(ModifyUserRoleProjectRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleProjectResponse>(req, "ModifyUserRoleProject");
        }

        /// <summary>
        /// 项目-修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleProjectRequest"/></param>
        /// <returns><see cref="ModifyUserRoleProjectResponse"/></returns>
        public ModifyUserRoleProjectResponse ModifyUserRoleProjectSync(ModifyUserRoleProjectRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleProjectResponse>(req, "ModifyUserRoleProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
