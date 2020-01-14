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
        /// CreateProject接口的同步版本，创建云剪的编辑项目，支持创建视频剪辑及直播剪辑两大类项目。
        /// </summary>
        /// <param name="req">参考<see cref="CreateProjectRequest"/></param>
        /// <returns>参考<see cref="CreateProjectResponse"/>实例</returns>
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
        /// DeleteLoginStatus接口的同步版本，删除用户登录态，使用户登出云剪平台。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLoginStatusRequest"/></param>
        /// <returns>参考<see cref="DeleteLoginStatusResponse"/>实例</returns>
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
        /// DeleteProject接口的同步版本，删除云剪编辑项目。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteProjectRequest"/></param>
        /// <returns>参考<see cref="DeleteProjectResponse"/>实例</returns>
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
        /// DescribeLoginStatus接口的同步版本，查询指定用户的登录态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLoginStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeLoginStatusResponse"/>实例</returns>
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
        /// DescribeProjects接口的同步版本，支持根据多种条件过滤出项目列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProjectsRequest"/></param>
        /// <returns>参考<see cref="DescribeProjectsResponse"/>实例</returns>
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
        /// DescribeTaskDetail接口的同步版本，获取任务详情信息，包含下面几个部分：
        /// <li>任务基础信息：包括任务状态、错误信息、创建时间等；</li>
        /// <li>导出项目输出信息：包括输出的素材 Id 等。</li>
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskDetailResponse"/>实例</returns>
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
        /// 支持各种条件筛选，返回对应的任务基础信息列表。
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
        /// DescribeTasks接口的同步版本，支持各种条件筛选，返回对应的任务基础信息列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeTasksResponse"/>实例</returns>
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
        /// ExportVideoEditProject接口的同步版本，导出视频编辑项目，支持指定输出的模板。
        /// </summary>
        /// <param name="req">参考<see cref="ExportVideoEditProjectRequest"/></param>
        /// <returns>参考<see cref="ExportVideoEditProjectResponse"/>实例</returns>
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
        /// 将云点播中的媒资添加到素材库中，提供给后续的视频编辑。
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
        /// ImportMediaToProject接口的同步版本，将云点播中的媒资添加到素材库中，提供给后续的视频编辑。
        /// </summary>
        /// <param name="req">参考<see cref="ImportMediaToProjectRequest"/></param>
        /// <returns>参考<see cref="ImportMediaToProjectResponse"/>实例</returns>
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
        /// ModifyProject接口的同步版本，修改云剪编辑项目的信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyProjectResponse"/>实例</returns>
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

    }
}
