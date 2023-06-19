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

namespace TencentCloud.Cloudstudio.V20230508
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudstudio.V20230508.Models;

   public class CloudstudioClient : AbstractClient{

       private const string endpoint = "cloudstudio.tencentcloudapi.com";
       private const string version = "2023-05-08";

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
        /// 创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspace(CreateWorkspaceRequest req)
        {
             JsonResponseModel<CreateWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public CreateWorkspaceResponse CreateWorkspaceSync(CreateWorkspaceRequest req)
        {
             JsonResponseModel<CreateWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceResponse>>(strResp);
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
        /// <param name="req"><see cref="CreateWorkspaceTokenRequest"/></param>
        /// <returns><see cref="CreateWorkspaceTokenResponse"/></returns>
        public async Task<CreateWorkspaceTokenResponse> CreateWorkspaceToken(CreateWorkspaceTokenRequest req)
        {
             JsonResponseModel<CreateWorkspaceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkspaceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceTokenResponse>>(strResp);
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
        /// <param name="req"><see cref="CreateWorkspaceTokenRequest"/></param>
        /// <returns><see cref="CreateWorkspaceTokenResponse"/></returns>
        public CreateWorkspaceTokenResponse CreateWorkspaceTokenSync(CreateWorkspaceTokenRequest req)
        {
             JsonResponseModel<CreateWorkspaceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkspaceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkspaceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public async Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public async Task<DescribeWorkspacesResponse> DescribeWorkspaces(DescribeWorkspacesRequest req)
        {
             JsonResponseModel<DescribeWorkspacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspacesResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public DescribeWorkspacesResponse DescribeWorkspacesSync(DescribeWorkspacesRequest req)
        {
             JsonResponseModel<DescribeWorkspacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作空间
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceResponse"/></returns>
        public async Task<ModifyWorkspaceResponse> ModifyWorkspace(ModifyWorkspaceRequest req)
        {
             JsonResponseModel<ModifyWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkspaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作空间
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceResponse"/></returns>
        public ModifyWorkspaceResponse ModifyWorkspaceSync(ModifyWorkspaceRequest req)
        {
             JsonResponseModel<ModifyWorkspaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWorkspace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkspaceResponse>>(strResp);
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
