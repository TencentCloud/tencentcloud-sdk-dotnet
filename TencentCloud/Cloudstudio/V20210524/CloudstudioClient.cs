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

namespace TencentCloud.Cloudstudio.V20210524
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudstudio.V20210524.Models;

   public class CloudstudioClient : AbstractClient{

       private const string endpoint = "cloudstudio.tencentcloudapi.com";
       private const string version = "2021-05-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudstudioClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudstudioClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加自定义模板
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizeTemplatesRequest"/></param>
        /// <returns><see cref="CreateCustomizeTemplatesResponse"/></returns>
        public async Task<CreateCustomizeTemplatesResponse> CreateCustomizeTemplates(CreateCustomizeTemplatesRequest req)
        {
             JsonResponseModel<CreateCustomizeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomizeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomizeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加自定义模板
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizeTemplatesRequest"/></param>
        /// <returns><see cref="CreateCustomizeTemplatesResponse"/></returns>
        public CreateCustomizeTemplatesResponse CreateCustomizeTemplatesSync(CreateCustomizeTemplatesRequest req)
        {
             JsonResponseModel<CreateCustomizeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomizeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomizeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云服务器方式创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceByAgentRequest"/></param>
        /// <returns><see cref="CreateWorkspaceByAgentResponse"/></returns>
        public async Task<CreateWorkspaceByAgentResponse> CreateWorkspaceByAgent(CreateWorkspaceByAgentRequest req)
        {
             JsonResponseModel<CreateWorkspaceByAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkspaceByAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceByAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云服务器方式创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceByAgentRequest"/></param>
        /// <returns><see cref="CreateWorkspaceByAgentResponse"/></returns>
        public CreateWorkspaceByAgentResponse CreateWorkspaceByAgentSync(CreateWorkspaceByAgentRequest req)
        {
             JsonResponseModel<CreateWorkspaceByAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkspaceByAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceByAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 快速开始, 基于模板创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceByTemplateRequest"/></param>
        /// <returns><see cref="CreateWorkspaceByTemplateResponse"/></returns>
        public async Task<CreateWorkspaceByTemplateResponse> CreateWorkspaceByTemplate(CreateWorkspaceByTemplateRequest req)
        {
             JsonResponseModel<CreateWorkspaceByTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkspaceByTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceByTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 快速开始, 基于模板创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceByTemplateRequest"/></param>
        /// <returns><see cref="CreateWorkspaceByTemplateResponse"/></returns>
        public CreateWorkspaceByTemplateResponse CreateWorkspaceByTemplateSync(CreateWorkspaceByTemplateRequest req)
        {
             JsonResponseModel<CreateWorkspaceByTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkspaceByTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceByTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据模板创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceByVersionControlRequest"/></param>
        /// <returns><see cref="CreateWorkspaceByVersionControlResponse"/></returns>
        public async Task<CreateWorkspaceByVersionControlResponse> CreateWorkspaceByVersionControl(CreateWorkspaceByVersionControlRequest req)
        {
             JsonResponseModel<CreateWorkspaceByVersionControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkspaceByVersionControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceByVersionControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据模板创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceByVersionControlRequest"/></param>
        /// <returns><see cref="CreateWorkspaceByVersionControlResponse"/></returns>
        public CreateWorkspaceByVersionControlResponse CreateWorkspaceByVersionControlSync(CreateWorkspaceByVersionControlRequest req)
        {
             JsonResponseModel<CreateWorkspaceByVersionControlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkspaceByVersionControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceByVersionControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为工作空间创建临时访问凭证，重复调用会创建新的 Token，旧的 Token 将会自动失效
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceTemporaryTokenRequest"/></param>
        /// <returns><see cref="CreateWorkspaceTemporaryTokenResponse"/></returns>
        public async Task<CreateWorkspaceTemporaryTokenResponse> CreateWorkspaceTemporaryToken(CreateWorkspaceTemporaryTokenRequest req)
        {
             JsonResponseModel<CreateWorkspaceTemporaryTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkspaceTemporaryToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceTemporaryTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为工作空间创建临时访问凭证，重复调用会创建新的 Token，旧的 Token 将会自动失效
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceTemporaryTokenRequest"/></param>
        /// <returns><see cref="CreateWorkspaceTemporaryTokenResponse"/></returns>
        public CreateWorkspaceTemporaryTokenResponse CreateWorkspaceTemporaryTokenSync(CreateWorkspaceTemporaryTokenRequest req)
        {
             JsonResponseModel<CreateWorkspaceTemporaryTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkspaceTemporaryToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceTemporaryTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义模板
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizeTemplatesByIdRequest"/></param>
        /// <returns><see cref="DeleteCustomizeTemplatesByIdResponse"/></returns>
        public async Task<DeleteCustomizeTemplatesByIdResponse> DeleteCustomizeTemplatesById(DeleteCustomizeTemplatesByIdRequest req)
        {
             JsonResponseModel<DeleteCustomizeTemplatesByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomizeTemplatesById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomizeTemplatesByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义模板
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizeTemplatesByIdRequest"/></param>
        /// <returns><see cref="DeleteCustomizeTemplatesByIdResponse"/></returns>
        public DeleteCustomizeTemplatesByIdResponse DeleteCustomizeTemplatesByIdSync(DeleteCustomizeTemplatesByIdRequest req)
        {
             JsonResponseModel<DeleteCustomizeTemplatesByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomizeTemplatesById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomizeTemplatesByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeCustomizeTemplatesResponse"/></returns>
        public async Task<DescribeCustomizeTemplatesResponse> DescribeCustomizeTemplates(DescribeCustomizeTemplatesRequest req)
        {
             JsonResponseModel<DescribeCustomizeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomizeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeCustomizeTemplatesResponse"/></returns>
        public DescribeCustomizeTemplatesResponse DescribeCustomizeTemplatesSync(DescribeCustomizeTemplatesRequest req)
        {
             JsonResponseModel<DescribeCustomizeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomizeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取特定模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizeTemplatesByIdRequest"/></param>
        /// <returns><see cref="DescribeCustomizeTemplatesByIdResponse"/></returns>
        public async Task<DescribeCustomizeTemplatesByIdResponse> DescribeCustomizeTemplatesById(DescribeCustomizeTemplatesByIdRequest req)
        {
             JsonResponseModel<DescribeCustomizeTemplatesByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomizeTemplatesById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizeTemplatesByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取特定模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizeTemplatesByIdRequest"/></param>
        /// <returns><see cref="DescribeCustomizeTemplatesByIdResponse"/></returns>
        public DescribeCustomizeTemplatesByIdResponse DescribeCustomizeTemplatesByIdSync(DescribeCustomizeTemplatesByIdRequest req)
        {
             JsonResponseModel<DescribeCustomizeTemplatesByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomizeTemplatesById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizeTemplatesByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取创建模板的预置参数
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizeTemplatesPresetsRequest"/></param>
        /// <returns><see cref="DescribeCustomizeTemplatesPresetsResponse"/></returns>
        public async Task<DescribeCustomizeTemplatesPresetsResponse> DescribeCustomizeTemplatesPresets(DescribeCustomizeTemplatesPresetsRequest req)
        {
             JsonResponseModel<DescribeCustomizeTemplatesPresetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomizeTemplatesPresets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizeTemplatesPresetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取创建模板的预置参数
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizeTemplatesPresetsRequest"/></param>
        /// <returns><see cref="DescribeCustomizeTemplatesPresetsResponse"/></returns>
        public DescribeCustomizeTemplatesPresetsResponse DescribeCustomizeTemplatesPresetsSync(DescribeCustomizeTemplatesPresetsRequest req)
        {
             JsonResponseModel<DescribeCustomizeTemplatesPresetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomizeTemplatesPresets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizeTemplatesPresetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 环境列表接口返回信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceEnvListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceEnvListResponse"/></returns>
        public async Task<DescribeWorkspaceEnvListResponse> DescribeWorkspaceEnvList(DescribeWorkspaceEnvListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceEnvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceEnvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceEnvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 环境列表接口返回信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceEnvListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceEnvListResponse"/></returns>
        public DescribeWorkspaceEnvListResponse DescribeWorkspaceEnvListSync(DescribeWorkspaceEnvListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceEnvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceEnvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceEnvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查工作空间是否存在
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceNameExistRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceNameExistResponse"/></returns>
        public async Task<DescribeWorkspaceNameExistResponse> DescribeWorkspaceNameExist(DescribeWorkspaceNameExistRequest req)
        {
             JsonResponseModel<DescribeWorkspaceNameExistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceNameExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceNameExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查工作空间是否存在
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceNameExistRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceNameExistResponse"/></returns>
        public DescribeWorkspaceNameExistResponse DescribeWorkspaceNameExistSync(DescribeWorkspaceNameExistRequest req)
        {
             JsonResponseModel<DescribeWorkspaceNameExistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceNameExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceNameExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取工作空间元信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceStatusRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceStatusResponse"/></returns>
        public async Task<DescribeWorkspaceStatusResponse> DescribeWorkspaceStatus(DescribeWorkspaceStatusRequest req)
        {
             JsonResponseModel<DescribeWorkspaceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取工作空间元信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceStatusRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceStatusResponse"/></returns>
        public DescribeWorkspaceStatusResponse DescribeWorkspaceStatusSync(DescribeWorkspaceStatusRequest req)
        {
             JsonResponseModel<DescribeWorkspaceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceStatusListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceStatusListResponse"/></returns>
        public async Task<DescribeWorkspaceStatusListResponse> DescribeWorkspaceStatusList(DescribeWorkspaceStatusListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceStatusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceStatusListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceStatusListResponse"/></returns>
        public DescribeWorkspaceStatusListResponse DescribeWorkspaceStatusListSync(DescribeWorkspaceStatusListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceStatusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模板默认代码仓库
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizeTemplateVersionControlRequest"/></param>
        /// <returns><see cref="ModifyCustomizeTemplateVersionControlResponse"/></returns>
        public async Task<ModifyCustomizeTemplateVersionControlResponse> ModifyCustomizeTemplateVersionControl(ModifyCustomizeTemplateVersionControlRequest req)
        {
             JsonResponseModel<ModifyCustomizeTemplateVersionControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomizeTemplateVersionControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizeTemplateVersionControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模板默认代码仓库
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizeTemplateVersionControlRequest"/></param>
        /// <returns><see cref="ModifyCustomizeTemplateVersionControlResponse"/></returns>
        public ModifyCustomizeTemplateVersionControlResponse ModifyCustomizeTemplateVersionControlSync(ModifyCustomizeTemplateVersionControlRequest req)
        {
             JsonResponseModel<ModifyCustomizeTemplateVersionControlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomizeTemplateVersionControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizeTemplateVersionControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全量修改自定义模板，不忽略空
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizeTemplatesFullByIdRequest"/></param>
        /// <returns><see cref="ModifyCustomizeTemplatesFullByIdResponse"/></returns>
        public async Task<ModifyCustomizeTemplatesFullByIdResponse> ModifyCustomizeTemplatesFullById(ModifyCustomizeTemplatesFullByIdRequest req)
        {
             JsonResponseModel<ModifyCustomizeTemplatesFullByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomizeTemplatesFullById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizeTemplatesFullByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全量修改自定义模板，不忽略空
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizeTemplatesFullByIdRequest"/></param>
        /// <returns><see cref="ModifyCustomizeTemplatesFullByIdResponse"/></returns>
        public ModifyCustomizeTemplatesFullByIdResponse ModifyCustomizeTemplatesFullByIdSync(ModifyCustomizeTemplatesFullByIdRequest req)
        {
             JsonResponseModel<ModifyCustomizeTemplatesFullByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomizeTemplatesFullById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizeTemplatesFullByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全量修改自定义模板，忽略空
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizeTemplatesPartByIdRequest"/></param>
        /// <returns><see cref="ModifyCustomizeTemplatesPartByIdResponse"/></returns>
        public async Task<ModifyCustomizeTemplatesPartByIdResponse> ModifyCustomizeTemplatesPartById(ModifyCustomizeTemplatesPartByIdRequest req)
        {
             JsonResponseModel<ModifyCustomizeTemplatesPartByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomizeTemplatesPartById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizeTemplatesPartByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全量修改自定义模板，忽略空
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizeTemplatesPartByIdRequest"/></param>
        /// <returns><see cref="ModifyCustomizeTemplatesPartByIdResponse"/></returns>
        public ModifyCustomizeTemplatesPartByIdResponse ModifyCustomizeTemplatesPartByIdSync(ModifyCustomizeTemplatesPartByIdRequest req)
        {
             JsonResponseModel<ModifyCustomizeTemplatesPartByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomizeTemplatesPartById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizeTemplatesPartByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作空间的名称和描述
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceAttributesRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceAttributesResponse"/></returns>
        public async Task<ModifyWorkspaceAttributesResponse> ModifyWorkspaceAttributes(ModifyWorkspaceAttributesRequest req)
        {
             JsonResponseModel<ModifyWorkspaceAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWorkspaceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkspaceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作空间的名称和描述
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceAttributesRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceAttributesResponse"/></returns>
        public ModifyWorkspaceAttributesResponse ModifyWorkspaceAttributesSync(ModifyWorkspaceAttributesRequest req)
        {
             JsonResponseModel<ModifyWorkspaceAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWorkspaceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkspaceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复工作空间
        /// </summary>
        /// <param name="req"><see cref="RecoverWorkspaceRequest"/></param>
        /// <returns><see cref="RecoverWorkspaceResponse"/></returns>
        public async Task<RecoverWorkspaceResponse> RecoverWorkspace(RecoverWorkspaceRequest req)
        {
             JsonResponseModel<RecoverWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复工作空间
        /// </summary>
        /// <param name="req"><see cref="RecoverWorkspaceRequest"/></param>
        /// <returns><see cref="RecoverWorkspaceResponse"/></returns>
        public RecoverWorkspaceResponse RecoverWorkspaceSync(RecoverWorkspaceRequest req)
        {
             JsonResponseModel<RecoverWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceResponse"/></returns>
        public async Task<RemoveWorkspaceResponse> RemoveWorkspace(RemoveWorkspaceRequest req)
        {
             JsonResponseModel<RemoveWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceResponse"/></returns>
        public RemoveWorkspaceResponse RemoveWorkspaceSync(RemoveWorkspaceRequest req)
        {
             JsonResponseModel<RemoveWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行空间
        /// </summary>
        /// <param name="req"><see cref="RunWorkspaceRequest"/></param>
        /// <returns><see cref="RunWorkspaceResponse"/></returns>
        public async Task<RunWorkspaceResponse> RunWorkspace(RunWorkspaceRequest req)
        {
             JsonResponseModel<RunWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行空间
        /// </summary>
        /// <param name="req"><see cref="RunWorkspaceRequest"/></param>
        /// <returns><see cref="RunWorkspaceResponse"/></returns>
        public RunWorkspaceResponse RunWorkspaceSync(RunWorkspaceRequest req)
        {
             JsonResponseModel<RunWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止运行空间
        /// </summary>
        /// <param name="req"><see cref="StopWorkspaceRequest"/></param>
        /// <returns><see cref="StopWorkspaceResponse"/></returns>
        public async Task<StopWorkspaceResponse> StopWorkspace(StopWorkspaceRequest req)
        {
             JsonResponseModel<StopWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止运行空间
        /// </summary>
        /// <param name="req"><see cref="StopWorkspaceRequest"/></param>
        /// <returns><see cref="StopWorkspaceResponse"/></returns>
        public StopWorkspaceResponse StopWorkspaceSync(StopWorkspaceRequest req)
        {
             JsonResponseModel<StopWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
