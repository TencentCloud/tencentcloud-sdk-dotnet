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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 申请延长Token可用时间接口-强鉴权
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public async Task<ApplyEmbedIntervalResponse> ApplyEmbedInterval(ApplyEmbedIntervalRequest req)
        {
             JsonResponseModel<ApplyEmbedIntervalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyEmbedInterval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyEmbedIntervalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请延长Token可用时间接口-强鉴权
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public ApplyEmbedIntervalResponse ApplyEmbedIntervalSync(ApplyEmbedIntervalRequest req)
        {
             JsonResponseModel<ApplyEmbedIntervalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyEmbedInterval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyEmbedIntervalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceRequest"/></param>
        /// <returns><see cref="CreateDatasourceResponse"/></returns>
        public async Task<CreateDatasourceResponse> CreateDatasource(CreateDatasourceRequest req)
        {
             JsonResponseModel<CreateDatasourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceRequest"/></param>
        /// <returns><see cref="CreateDatasourceResponse"/></returns>
        public CreateDatasourceResponse CreateDatasourceSync(CreateDatasourceRequest req)
        {
             JsonResponseModel<CreateDatasourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云数据库
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceCloudRequest"/></param>
        /// <returns><see cref="CreateDatasourceCloudResponse"/></returns>
        public async Task<CreateDatasourceCloudResponse> CreateDatasourceCloud(CreateDatasourceCloudRequest req)
        {
             JsonResponseModel<CreateDatasourceCloudResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDatasourceCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasourceCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云数据库
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceCloudRequest"/></param>
        /// <returns><see cref="CreateDatasourceCloudResponse"/></returns>
        public CreateDatasourceCloudResponse CreateDatasourceCloudSync(CreateDatasourceCloudRequest req)
        {
             JsonResponseModel<CreateDatasourceCloudResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDatasourceCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatasourceCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建嵌出报表-强鉴权
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public async Task<CreateEmbedTokenResponse> CreateEmbedToken(CreateEmbedTokenRequest req)
        {
             JsonResponseModel<CreateEmbedTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmbedToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmbedTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建嵌出报表-强鉴权
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public CreateEmbedTokenResponse CreateEmbedTokenSync(CreateEmbedTokenRequest req)
        {
             JsonResponseModel<CreateEmbedTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmbedToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmbedTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建项目
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
        /// 创建项目
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
        /// 创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public async Task<CreateUserRoleResponse> CreateUserRole(CreateUserRoleRequest req)
        {
             JsonResponseModel<CreateUserRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public CreateUserRoleResponse CreateUserRoleSync(CreateUserRoleRequest req)
        {
             JsonResponseModel<CreateUserRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目内-创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleProjectRequest"/></param>
        /// <returns><see cref="CreateUserRoleProjectResponse"/></returns>
        public async Task<CreateUserRoleProjectResponse> CreateUserRoleProject(CreateUserRoleProjectRequest req)
        {
             JsonResponseModel<CreateUserRoleProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserRoleProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserRoleProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目内-创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleProjectRequest"/></param>
        /// <returns><see cref="CreateUserRoleProjectResponse"/></returns>
        public CreateUserRoleProjectResponse CreateUserRoleProjectSync(CreateUserRoleProjectRequest req)
        {
             JsonResponseModel<CreateUserRoleProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserRoleProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserRoleProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasourceRequest"/></param>
        /// <returns><see cref="DeleteDatasourceResponse"/></returns>
        public async Task<DeleteDatasourceResponse> DeleteDatasource(DeleteDatasourceRequest req)
        {
             JsonResponseModel<DeleteDatasourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据源
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasourceRequest"/></param>
        /// <returns><see cref="DeleteDatasourceResponse"/></returns>
        public DeleteDatasourceResponse DeleteDatasourceSync(DeleteDatasourceRequest req)
        {
             JsonResponseModel<DeleteDatasourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除项目
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
        /// 删除项目
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
        /// 删除用户角色，会删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleRequest"/></param>
        /// <returns><see cref="DeleteUserRoleResponse"/></returns>
        public async Task<DeleteUserRoleResponse> DeleteUserRole(DeleteUserRoleRequest req)
        {
             JsonResponseModel<DeleteUserRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户角色，会删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleRequest"/></param>
        /// <returns><see cref="DeleteUserRoleResponse"/></returns>
        public DeleteUserRoleResponse DeleteUserRoleSync(DeleteUserRoleRequest req)
        {
             JsonResponseModel<DeleteUserRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目内-删除用户角色
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleProjectRequest"/></param>
        /// <returns><see cref="DeleteUserRoleProjectResponse"/></returns>
        public async Task<DeleteUserRoleProjectResponse> DeleteUserRoleProject(DeleteUserRoleProjectRequest req)
        {
             JsonResponseModel<DeleteUserRoleProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserRoleProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserRoleProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目内-删除用户角色
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleProjectRequest"/></param>
        /// <returns><see cref="DeleteUserRoleProjectResponse"/></returns>
        public DeleteUserRoleProjectResponse DeleteUserRoleProjectSync(DeleteUserRoleProjectRequest req)
        {
             JsonResponseModel<DeleteUserRoleProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserRoleProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserRoleProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceListRequest"/></param>
        /// <returns><see cref="DescribeDatasourceListResponse"/></returns>
        public async Task<DescribeDatasourceListResponse> DescribeDatasourceList(DescribeDatasourceListRequest req)
        {
             JsonResponseModel<DescribeDatasourceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceListRequest"/></param>
        /// <returns><see cref="DescribeDatasourceListResponse"/></returns>
        public DescribeDatasourceListResponse DescribeDatasourceListSync(DescribeDatasourceListRequest req)
        {
             JsonResponseModel<DescribeDatasourceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public async Task<DescribeProjectInfoResponse> DescribeProjectInfo(DescribeProjectInfoRequest req)
        {
             JsonResponseModel<DescribeProjectInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public DescribeProjectInfoResponse DescribeProjectInfoSync(DescribeProjectInfoRequest req)
        {
             JsonResponseModel<DescribeProjectInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public async Task<DescribeProjectListResponse> DescribeProjectList(DescribeProjectListRequest req)
        {
             JsonResponseModel<DescribeProjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public DescribeProjectListResponse DescribeProjectListSync(DescribeProjectListRequest req)
        {
             JsonResponseModel<DescribeProjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目内-用户接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUserProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserProjectListResponse"/></returns>
        public async Task<DescribeUserProjectListResponse> DescribeUserProjectList(DescribeUserProjectListRequest req)
        {
             JsonResponseModel<DescribeUserProjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目内-用户接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUserProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserProjectListResponse"/></returns>
        public DescribeUserProjectListResponse DescribeUserProjectListSync(DescribeUserProjectListRequest req)
        {
             JsonResponseModel<DescribeUserProjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleListResponse"/></returns>
        public async Task<DescribeUserRoleListResponse> DescribeUserRoleList(DescribeUserRoleListRequest req)
        {
             JsonResponseModel<DescribeUserRoleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserRoleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserRoleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleListResponse"/></returns>
        public DescribeUserRoleListResponse DescribeUserRoleListSync(DescribeUserRoleListRequest req)
        {
             JsonResponseModel<DescribeUserRoleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserRoleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserRoleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceRequest"/></param>
        /// <returns><see cref="ModifyDatasourceResponse"/></returns>
        public async Task<ModifyDatasourceResponse> ModifyDatasource(ModifyDatasourceRequest req)
        {
             JsonResponseModel<ModifyDatasourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新数据源
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceRequest"/></param>
        /// <returns><see cref="ModifyDatasourceResponse"/></returns>
        public ModifyDatasourceResponse ModifyDatasourceSync(ModifyDatasourceRequest req)
        {
             JsonResponseModel<ModifyDatasourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDatasource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatasourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新云数据库
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceCloudRequest"/></param>
        /// <returns><see cref="ModifyDatasourceCloudResponse"/></returns>
        public async Task<ModifyDatasourceCloudResponse> ModifyDatasourceCloud(ModifyDatasourceCloudRequest req)
        {
             JsonResponseModel<ModifyDatasourceCloudResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDatasourceCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatasourceCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新云数据库
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceCloudRequest"/></param>
        /// <returns><see cref="ModifyDatasourceCloudResponse"/></returns>
        public ModifyDatasourceCloudResponse ModifyDatasourceCloudSync(ModifyDatasourceCloudRequest req)
        {
             JsonResponseModel<ModifyDatasourceCloudResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDatasourceCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatasourceCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改项目信息
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
        /// 修改项目信息
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
        /// 修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleRequest"/></param>
        /// <returns><see cref="ModifyUserRoleResponse"/></returns>
        public async Task<ModifyUserRoleResponse> ModifyUserRole(ModifyUserRoleRequest req)
        {
             JsonResponseModel<ModifyUserRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleRequest"/></param>
        /// <returns><see cref="ModifyUserRoleResponse"/></returns>
        public ModifyUserRoleResponse ModifyUserRoleSync(ModifyUserRoleRequest req)
        {
             JsonResponseModel<ModifyUserRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目-修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleProjectRequest"/></param>
        /// <returns><see cref="ModifyUserRoleProjectResponse"/></returns>
        public async Task<ModifyUserRoleProjectResponse> ModifyUserRoleProject(ModifyUserRoleProjectRequest req)
        {
             JsonResponseModel<ModifyUserRoleProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserRoleProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserRoleProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 项目-修改用户角色信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleProjectRequest"/></param>
        /// <returns><see cref="ModifyUserRoleProjectResponse"/></returns>
        public ModifyUserRoleProjectResponse ModifyUserRoleProjectSync(ModifyUserRoleProjectRequest req)
        {
             JsonResponseModel<ModifyUserRoleProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserRoleProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserRoleProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
