/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Apis.V20240801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apis.V20240801.Models;

   public class ApisClient : AbstractClient{

       private const string endpoint = "apis.tencentcloudapi.com";
       private const string version = "2024-08-01";
       private const string sdkVersion = "SDK_NET_3.0.1412";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建app
        /// </summary>
        /// <param name="req"><see cref="CreateAgentAppRequest"/></param>
        /// <returns><see cref="CreateAgentAppResponse"/></returns>
        public Task<CreateAgentAppResponse> CreateAgentApp(CreateAgentAppRequest req)
        {
            return InternalRequestAsync<CreateAgentAppResponse>(req, "CreateAgentApp");
        }

        /// <summary>
        /// 创建app
        /// </summary>
        /// <param name="req"><see cref="CreateAgentAppRequest"/></param>
        /// <returns><see cref="CreateAgentAppResponse"/></returns>
        public CreateAgentAppResponse CreateAgentAppSync(CreateAgentAppRequest req)
        {
            return InternalRequestAsync<CreateAgentAppResponse>(req, "CreateAgentApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建app的mcp server关联
        /// </summary>
        /// <param name="req"><see cref="CreateAgentAppMcpServersRequest"/></param>
        /// <returns><see cref="CreateAgentAppMcpServersResponse"/></returns>
        public Task<CreateAgentAppMcpServersResponse> CreateAgentAppMcpServers(CreateAgentAppMcpServersRequest req)
        {
            return InternalRequestAsync<CreateAgentAppMcpServersResponse>(req, "CreateAgentAppMcpServers");
        }

        /// <summary>
        /// 创建app的mcp server关联
        /// </summary>
        /// <param name="req"><see cref="CreateAgentAppMcpServersRequest"/></param>
        /// <returns><see cref="CreateAgentAppMcpServersResponse"/></returns>
        public CreateAgentAppMcpServersResponse CreateAgentAppMcpServersSync(CreateAgentAppMcpServersRequest req)
        {
            return InternalRequestAsync<CreateAgentAppMcpServersResponse>(req, "CreateAgentAppMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建app的model service关联
        /// </summary>
        /// <param name="req"><see cref="CreateAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="CreateAgentAppModelServicesResponse"/></returns>
        public Task<CreateAgentAppModelServicesResponse> CreateAgentAppModelServices(CreateAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<CreateAgentAppModelServicesResponse>(req, "CreateAgentAppModelServices");
        }

        /// <summary>
        /// 创建app的model service关联
        /// </summary>
        /// <param name="req"><see cref="CreateAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="CreateAgentAppModelServicesResponse"/></returns>
        public CreateAgentAppModelServicesResponse CreateAgentAppModelServicesSync(CreateAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<CreateAgentAppModelServicesResponse>(req, "CreateAgentAppModelServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Credential
        /// </summary>
        /// <param name="req"><see cref="CreateAgentCredentialRequest"/></param>
        /// <returns><see cref="CreateAgentCredentialResponse"/></returns>
        public Task<CreateAgentCredentialResponse> CreateAgentCredential(CreateAgentCredentialRequest req)
        {
            return InternalRequestAsync<CreateAgentCredentialResponse>(req, "CreateAgentCredential");
        }

        /// <summary>
        /// 创建Credential
        /// </summary>
        /// <param name="req"><see cref="CreateAgentCredentialRequest"/></param>
        /// <returns><see cref="CreateAgentCredentialResponse"/></returns>
        public CreateAgentCredentialResponse CreateAgentCredentialSync(CreateAgentCredentialRequest req)
        {
            return InternalRequestAsync<CreateAgentCredentialResponse>(req, "CreateAgentCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建mcp server
        /// </summary>
        /// <param name="req"><see cref="CreateMcpServerRequest"/></param>
        /// <returns><see cref="CreateMcpServerResponse"/></returns>
        public Task<CreateMcpServerResponse> CreateMcpServer(CreateMcpServerRequest req)
        {
            return InternalRequestAsync<CreateMcpServerResponse>(req, "CreateMcpServer");
        }

        /// <summary>
        /// 创建mcp server
        /// </summary>
        /// <param name="req"><see cref="CreateMcpServerRequest"/></param>
        /// <returns><see cref="CreateMcpServerResponse"/></returns>
        public CreateMcpServerResponse CreateMcpServerSync(CreateMcpServerRequest req)
        {
            return InternalRequestAsync<CreateMcpServerResponse>(req, "CreateMcpServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建模型
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public Task<CreateModelResponse> CreateModel(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel");
        }

        /// <summary>
        /// 创建模型
        /// </summary>
        /// <param name="req"><see cref="CreateModelRequest"/></param>
        /// <returns><see cref="CreateModelResponse"/></returns>
        public CreateModelResponse CreateModelSync(CreateModelRequest req)
        {
            return InternalRequestAsync<CreateModelResponse>(req, "CreateModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建模型服务
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceRequest"/></param>
        /// <returns><see cref="CreateModelServiceResponse"/></returns>
        public Task<CreateModelServiceResponse> CreateModelService(CreateModelServiceRequest req)
        {
            return InternalRequestAsync<CreateModelServiceResponse>(req, "CreateModelService");
        }

        /// <summary>
        /// 创建模型服务
        /// </summary>
        /// <param name="req"><see cref="CreateModelServiceRequest"/></param>
        /// <returns><see cref="CreateModelServiceResponse"/></returns>
        public CreateModelServiceResponse CreateModelServiceSync(CreateModelServiceRequest req)
        {
            return InternalRequestAsync<CreateModelServiceResponse>(req, "CreateModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除app
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentAppRequest"/></param>
        /// <returns><see cref="DeleteAgentAppResponse"/></returns>
        public Task<DeleteAgentAppResponse> DeleteAgentApp(DeleteAgentAppRequest req)
        {
            return InternalRequestAsync<DeleteAgentAppResponse>(req, "DeleteAgentApp");
        }

        /// <summary>
        /// 删除app
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentAppRequest"/></param>
        /// <returns><see cref="DeleteAgentAppResponse"/></returns>
        public DeleteAgentAppResponse DeleteAgentAppSync(DeleteAgentAppRequest req)
        {
            return InternalRequestAsync<DeleteAgentAppResponse>(req, "DeleteAgentApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除app的mcp server
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentAppMcpServersRequest"/></param>
        /// <returns><see cref="DeleteAgentAppMcpServersResponse"/></returns>
        public Task<DeleteAgentAppMcpServersResponse> DeleteAgentAppMcpServers(DeleteAgentAppMcpServersRequest req)
        {
            return InternalRequestAsync<DeleteAgentAppMcpServersResponse>(req, "DeleteAgentAppMcpServers");
        }

        /// <summary>
        /// 删除app的mcp server
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentAppMcpServersRequest"/></param>
        /// <returns><see cref="DeleteAgentAppMcpServersResponse"/></returns>
        public DeleteAgentAppMcpServersResponse DeleteAgentAppMcpServersSync(DeleteAgentAppMcpServersRequest req)
        {
            return InternalRequestAsync<DeleteAgentAppMcpServersResponse>(req, "DeleteAgentAppMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除app的model service关联
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="DeleteAgentAppModelServicesResponse"/></returns>
        public Task<DeleteAgentAppModelServicesResponse> DeleteAgentAppModelServices(DeleteAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<DeleteAgentAppModelServicesResponse>(req, "DeleteAgentAppModelServices");
        }

        /// <summary>
        /// 删除app的model service关联
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="DeleteAgentAppModelServicesResponse"/></returns>
        public DeleteAgentAppModelServicesResponse DeleteAgentAppModelServicesSync(DeleteAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<DeleteAgentAppModelServicesResponse>(req, "DeleteAgentAppModelServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Credential
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentCredentialRequest"/></param>
        /// <returns><see cref="DeleteAgentCredentialResponse"/></returns>
        public Task<DeleteAgentCredentialResponse> DeleteAgentCredential(DeleteAgentCredentialRequest req)
        {
            return InternalRequestAsync<DeleteAgentCredentialResponse>(req, "DeleteAgentCredential");
        }

        /// <summary>
        /// 删除Credential
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentCredentialRequest"/></param>
        /// <returns><see cref="DeleteAgentCredentialResponse"/></returns>
        public DeleteAgentCredentialResponse DeleteAgentCredentialSync(DeleteAgentCredentialRequest req)
        {
            return InternalRequestAsync<DeleteAgentCredentialResponse>(req, "DeleteAgentCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除mcp server
        /// </summary>
        /// <param name="req"><see cref="DeleteMcpServerRequest"/></param>
        /// <returns><see cref="DeleteMcpServerResponse"/></returns>
        public Task<DeleteMcpServerResponse> DeleteMcpServer(DeleteMcpServerRequest req)
        {
            return InternalRequestAsync<DeleteMcpServerResponse>(req, "DeleteMcpServer");
        }

        /// <summary>
        /// 删除mcp server
        /// </summary>
        /// <param name="req"><see cref="DeleteMcpServerRequest"/></param>
        /// <returns><see cref="DeleteMcpServerResponse"/></returns>
        public DeleteMcpServerResponse DeleteMcpServerSync(DeleteMcpServerRequest req)
        {
            return InternalRequestAsync<DeleteMcpServerResponse>(req, "DeleteMcpServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public Task<DeleteModelResponse> DeleteModel(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel");
        }

        /// <summary>
        /// 删除模型
        /// </summary>
        /// <param name="req"><see cref="DeleteModelRequest"/></param>
        /// <returns><see cref="DeleteModelResponse"/></returns>
        public DeleteModelResponse DeleteModelSync(DeleteModelRequest req)
        {
            return InternalRequestAsync<DeleteModelResponse>(req, "DeleteModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceRequest"/></param>
        /// <returns><see cref="DeleteModelServiceResponse"/></returns>
        public Task<DeleteModelServiceResponse> DeleteModelService(DeleteModelServiceRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceResponse>(req, "DeleteModelService");
        }

        /// <summary>
        /// 删除模型服务
        /// </summary>
        /// <param name="req"><see cref="DeleteModelServiceRequest"/></param>
        /// <returns><see cref="DeleteModelServiceResponse"/></returns>
        public DeleteModelServiceResponse DeleteModelServiceSync(DeleteModelServiceRequest req)
        {
            return InternalRequestAsync<DeleteModelServiceResponse>(req, "DeleteModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询app详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppRequest"/></param>
        /// <returns><see cref="DescribeAgentAppResponse"/></returns>
        public Task<DescribeAgentAppResponse> DescribeAgentApp(DescribeAgentAppRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppResponse>(req, "DescribeAgentApp");
        }

        /// <summary>
        /// 查询app详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppRequest"/></param>
        /// <returns><see cref="DescribeAgentAppResponse"/></returns>
        public DescribeAgentAppResponse DescribeAgentAppSync(DescribeAgentAppRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppResponse>(req, "DescribeAgentApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询app mcpServer关联列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppMcpServersRequest"/></param>
        /// <returns><see cref="DescribeAgentAppMcpServersResponse"/></returns>
        public Task<DescribeAgentAppMcpServersResponse> DescribeAgentAppMcpServers(DescribeAgentAppMcpServersRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppMcpServersResponse>(req, "DescribeAgentAppMcpServers");
        }

        /// <summary>
        /// 查询app mcpServer关联列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppMcpServersRequest"/></param>
        /// <returns><see cref="DescribeAgentAppMcpServersResponse"/></returns>
        public DescribeAgentAppMcpServersResponse DescribeAgentAppMcpServersSync(DescribeAgentAppMcpServersRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppMcpServersResponse>(req, "DescribeAgentAppMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询app modelService关联列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="DescribeAgentAppModelServicesResponse"/></returns>
        public Task<DescribeAgentAppModelServicesResponse> DescribeAgentAppModelServices(DescribeAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppModelServicesResponse>(req, "DescribeAgentAppModelServices");
        }

        /// <summary>
        /// 查询app modelService关联列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="DescribeAgentAppModelServicesResponse"/></returns>
        public DescribeAgentAppModelServicesResponse DescribeAgentAppModelServicesSync(DescribeAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppModelServicesResponse>(req, "DescribeAgentAppModelServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询app列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppsRequest"/></param>
        /// <returns><see cref="DescribeAgentAppsResponse"/></returns>
        public Task<DescribeAgentAppsResponse> DescribeAgentApps(DescribeAgentAppsRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppsResponse>(req, "DescribeAgentApps");
        }

        /// <summary>
        /// 查询app列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentAppsRequest"/></param>
        /// <returns><see cref="DescribeAgentAppsResponse"/></returns>
        public DescribeAgentAppsResponse DescribeAgentAppsSync(DescribeAgentAppsRequest req)
        {
            return InternalRequestAsync<DescribeAgentAppsResponse>(req, "DescribeAgentApps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Credential详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCredentialRequest"/></param>
        /// <returns><see cref="DescribeAgentCredentialResponse"/></returns>
        public Task<DescribeAgentCredentialResponse> DescribeAgentCredential(DescribeAgentCredentialRequest req)
        {
            return InternalRequestAsync<DescribeAgentCredentialResponse>(req, "DescribeAgentCredential");
        }

        /// <summary>
        /// 查询Credential详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCredentialRequest"/></param>
        /// <returns><see cref="DescribeAgentCredentialResponse"/></returns>
        public DescribeAgentCredentialResponse DescribeAgentCredentialSync(DescribeAgentCredentialRequest req)
        {
            return InternalRequestAsync<DescribeAgentCredentialResponse>(req, "DescribeAgentCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Credential列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCredentialsRequest"/></param>
        /// <returns><see cref="DescribeAgentCredentialsResponse"/></returns>
        public Task<DescribeAgentCredentialsResponse> DescribeAgentCredentials(DescribeAgentCredentialsRequest req)
        {
            return InternalRequestAsync<DescribeAgentCredentialsResponse>(req, "DescribeAgentCredentials");
        }

        /// <summary>
        /// 查询Credential列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCredentialsRequest"/></param>
        /// <returns><see cref="DescribeAgentCredentialsResponse"/></returns>
        public DescribeAgentCredentialsResponse DescribeAgentCredentialsSync(DescribeAgentCredentialsRequest req)
        {
            return InternalRequestAsync<DescribeAgentCredentialsResponse>(req, "DescribeAgentCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询mcp server详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServerRequest"/></param>
        /// <returns><see cref="DescribeMcpServerResponse"/></returns>
        public Task<DescribeMcpServerResponse> DescribeMcpServer(DescribeMcpServerRequest req)
        {
            return InternalRequestAsync<DescribeMcpServerResponse>(req, "DescribeMcpServer");
        }

        /// <summary>
        /// 查询mcp server详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServerRequest"/></param>
        /// <returns><see cref="DescribeMcpServerResponse"/></returns>
        public DescribeMcpServerResponse DescribeMcpServerSync(DescribeMcpServerRequest req)
        {
            return InternalRequestAsync<DescribeMcpServerResponse>(req, "DescribeMcpServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询mcp server列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServersRequest"/></param>
        /// <returns><see cref="DescribeMcpServersResponse"/></returns>
        public Task<DescribeMcpServersResponse> DescribeMcpServers(DescribeMcpServersRequest req)
        {
            return InternalRequestAsync<DescribeMcpServersResponse>(req, "DescribeMcpServers");
        }

        /// <summary>
        /// 查询mcp server列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMcpServersRequest"/></param>
        /// <returns><see cref="DescribeMcpServersResponse"/></returns>
        public DescribeMcpServersResponse DescribeMcpServersSync(DescribeMcpServersRequest req)
        {
            return InternalRequestAsync<DescribeMcpServersResponse>(req, "DescribeMcpServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelRequest"/></param>
        /// <returns><see cref="DescribeModelResponse"/></returns>
        public Task<DescribeModelResponse> DescribeModel(DescribeModelRequest req)
        {
            return InternalRequestAsync<DescribeModelResponse>(req, "DescribeModel");
        }

        /// <summary>
        /// 查询模型详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelRequest"/></param>
        /// <returns><see cref="DescribeModelResponse"/></returns>
        public DescribeModelResponse DescribeModelSync(DescribeModelRequest req)
        {
            return InternalRequestAsync<DescribeModelResponse>(req, "DescribeModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceRequest"/></param>
        /// <returns><see cref="DescribeModelServiceResponse"/></returns>
        public Task<DescribeModelServiceResponse> DescribeModelService(DescribeModelServiceRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceResponse>(req, "DescribeModelService");
        }

        /// <summary>
        /// 查询模型服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServiceRequest"/></param>
        /// <returns><see cref="DescribeModelServiceResponse"/></returns>
        public DescribeModelServiceResponse DescribeModelServiceSync(DescribeModelServiceRequest req)
        {
            return InternalRequestAsync<DescribeModelServiceResponse>(req, "DescribeModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServicesRequest"/></param>
        /// <returns><see cref="DescribeModelServicesResponse"/></returns>
        public Task<DescribeModelServicesResponse> DescribeModelServices(DescribeModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeModelServicesResponse>(req, "DescribeModelServices");
        }

        /// <summary>
        /// 查询模型服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelServicesRequest"/></param>
        /// <returns><see cref="DescribeModelServicesResponse"/></returns>
        public DescribeModelServicesResponse DescribeModelServicesSync(DescribeModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeModelServicesResponse>(req, "DescribeModelServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelsRequest"/></param>
        /// <returns><see cref="DescribeModelsResponse"/></returns>
        public Task<DescribeModelsResponse> DescribeModels(DescribeModelsRequest req)
        {
            return InternalRequestAsync<DescribeModelsResponse>(req, "DescribeModels");
        }

        /// <summary>
        /// 查询模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelsRequest"/></param>
        /// <returns><see cref="DescribeModelsResponse"/></returns>
        public DescribeModelsResponse DescribeModelsSync(DescribeModelsRequest req)
        {
            return InternalRequestAsync<DescribeModelsResponse>(req, "DescribeModels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改app
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentAppRequest"/></param>
        /// <returns><see cref="ModifyAgentAppResponse"/></returns>
        public Task<ModifyAgentAppResponse> ModifyAgentApp(ModifyAgentAppRequest req)
        {
            return InternalRequestAsync<ModifyAgentAppResponse>(req, "ModifyAgentApp");
        }

        /// <summary>
        /// 修改app
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentAppRequest"/></param>
        /// <returns><see cref="ModifyAgentAppResponse"/></returns>
        public ModifyAgentAppResponse ModifyAgentAppSync(ModifyAgentAppRequest req)
        {
            return InternalRequestAsync<ModifyAgentAppResponse>(req, "ModifyAgentApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑app的model service关联
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="ModifyAgentAppModelServicesResponse"/></returns>
        public Task<ModifyAgentAppModelServicesResponse> ModifyAgentAppModelServices(ModifyAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<ModifyAgentAppModelServicesResponse>(req, "ModifyAgentAppModelServices");
        }

        /// <summary>
        /// 编辑app的model service关联
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentAppModelServicesRequest"/></param>
        /// <returns><see cref="ModifyAgentAppModelServicesResponse"/></returns>
        public ModifyAgentAppModelServicesResponse ModifyAgentAppModelServicesSync(ModifyAgentAppModelServicesRequest req)
        {
            return InternalRequestAsync<ModifyAgentAppModelServicesResponse>(req, "ModifyAgentAppModelServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Credential
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentCredentialRequest"/></param>
        /// <returns><see cref="ModifyAgentCredentialResponse"/></returns>
        public Task<ModifyAgentCredentialResponse> ModifyAgentCredential(ModifyAgentCredentialRequest req)
        {
            return InternalRequestAsync<ModifyAgentCredentialResponse>(req, "ModifyAgentCredential");
        }

        /// <summary>
        /// 修改Credential
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentCredentialRequest"/></param>
        /// <returns><see cref="ModifyAgentCredentialResponse"/></returns>
        public ModifyAgentCredentialResponse ModifyAgentCredentialSync(ModifyAgentCredentialRequest req)
        {
            return InternalRequestAsync<ModifyAgentCredentialResponse>(req, "ModifyAgentCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改mcp server
        /// </summary>
        /// <param name="req"><see cref="ModifyMcpServerRequest"/></param>
        /// <returns><see cref="ModifyMcpServerResponse"/></returns>
        public Task<ModifyMcpServerResponse> ModifyMcpServer(ModifyMcpServerRequest req)
        {
            return InternalRequestAsync<ModifyMcpServerResponse>(req, "ModifyMcpServer");
        }

        /// <summary>
        /// 修改mcp server
        /// </summary>
        /// <param name="req"><see cref="ModifyMcpServerRequest"/></param>
        /// <returns><see cref="ModifyMcpServerResponse"/></returns>
        public ModifyMcpServerResponse ModifyMcpServerSync(ModifyMcpServerRequest req)
        {
            return InternalRequestAsync<ModifyMcpServerResponse>(req, "ModifyMcpServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模型
        /// </summary>
        /// <param name="req"><see cref="ModifyModelRequest"/></param>
        /// <returns><see cref="ModifyModelResponse"/></returns>
        public Task<ModifyModelResponse> ModifyModel(ModifyModelRequest req)
        {
            return InternalRequestAsync<ModifyModelResponse>(req, "ModifyModel");
        }

        /// <summary>
        /// 修改模型
        /// </summary>
        /// <param name="req"><see cref="ModifyModelRequest"/></param>
        /// <returns><see cref="ModifyModelResponse"/></returns>
        public ModifyModelResponse ModifyModelSync(ModifyModelRequest req)
        {
            return InternalRequestAsync<ModifyModelResponse>(req, "ModifyModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模型服务
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceRequest"/></param>
        /// <returns><see cref="ModifyModelServiceResponse"/></returns>
        public Task<ModifyModelServiceResponse> ModifyModelService(ModifyModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceResponse>(req, "ModifyModelService");
        }

        /// <summary>
        /// 修改模型服务
        /// </summary>
        /// <param name="req"><see cref="ModifyModelServiceRequest"/></param>
        /// <returns><see cref="ModifyModelServiceResponse"/></returns>
        public ModifyModelServiceResponse ModifyModelServiceSync(ModifyModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyModelServiceResponse>(req, "ModifyModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
