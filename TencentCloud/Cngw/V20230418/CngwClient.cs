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

namespace TencentCloud.Cngw.V20230418
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cngw.V20230418.Models;

   public class CngwClient : AbstractClient{

       private const string endpoint = "cngw.tencentcloudapi.com";
       private const string version = "2023-04-18";
       private const string sdkVersion = "SDK_NET_3.0.1463";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CngwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CngwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 为资源（模型 API / MCP Server）添加消费者组授权。
        /// </summary>
        /// <param name="req"><see cref="AddCloudNativeAPIGatewayConsumerGroupAuthRequest"/></param>
        /// <returns><see cref="AddCloudNativeAPIGatewayConsumerGroupAuthResponse"/></returns>
        public Task<AddCloudNativeAPIGatewayConsumerGroupAuthResponse> AddCloudNativeAPIGatewayConsumerGroupAuth(AddCloudNativeAPIGatewayConsumerGroupAuthRequest req)
        {
            return InternalRequestAsync<AddCloudNativeAPIGatewayConsumerGroupAuthResponse>(req, "AddCloudNativeAPIGatewayConsumerGroupAuth");
        }

        /// <summary>
        /// 为资源（模型 API / MCP Server）添加消费者组授权。
        /// </summary>
        /// <param name="req"><see cref="AddCloudNativeAPIGatewayConsumerGroupAuthRequest"/></param>
        /// <returns><see cref="AddCloudNativeAPIGatewayConsumerGroupAuthResponse"/></returns>
        public AddCloudNativeAPIGatewayConsumerGroupAuthResponse AddCloudNativeAPIGatewayConsumerGroupAuthSync(AddCloudNativeAPIGatewayConsumerGroupAuthRequest req)
        {
            return InternalRequestAsync<AddCloudNativeAPIGatewayConsumerGroupAuthResponse>(req, "AddCloudNativeAPIGatewayConsumerGroupAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将消费者添加到消费者组。
        /// </summary>
        /// <param name="req"><see cref="AddCloudNativeAPIGatewayConsumerInGroupRequest"/></param>
        /// <returns><see cref="AddCloudNativeAPIGatewayConsumerInGroupResponse"/></returns>
        public Task<AddCloudNativeAPIGatewayConsumerInGroupResponse> AddCloudNativeAPIGatewayConsumerInGroup(AddCloudNativeAPIGatewayConsumerInGroupRequest req)
        {
            return InternalRequestAsync<AddCloudNativeAPIGatewayConsumerInGroupResponse>(req, "AddCloudNativeAPIGatewayConsumerInGroup");
        }

        /// <summary>
        /// 将消费者添加到消费者组。
        /// </summary>
        /// <param name="req"><see cref="AddCloudNativeAPIGatewayConsumerInGroupRequest"/></param>
        /// <returns><see cref="AddCloudNativeAPIGatewayConsumerInGroupResponse"/></returns>
        public AddCloudNativeAPIGatewayConsumerInGroupResponse AddCloudNativeAPIGatewayConsumerInGroupSync(AddCloudNativeAPIGatewayConsumerInGroupRequest req)
        {
            return InternalRequestAsync<AddCloudNativeAPIGatewayConsumerInGroupResponse>(req, "AddCloudNativeAPIGatewayConsumerInGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加密钥与资源的引用关系接口
        /// </summary>
        /// <param name="req"><see cref="BindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="BindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<BindCloudNativeAPIGatewaySecretKeyResponse> BindCloudNativeAPIGatewaySecretKey(BindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<BindCloudNativeAPIGatewaySecretKeyResponse>(req, "BindCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 添加密钥与资源的引用关系接口
        /// </summary>
        /// <param name="req"><see cref="BindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="BindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public BindCloudNativeAPIGatewaySecretKeyResponse BindCloudNativeAPIGatewaySecretKeySync(BindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<BindCloudNativeAPIGatewaySecretKeyResponse>(req, "BindCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建AI网关消费者。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayConsumerResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayConsumerResponse> CreateCloudNativeAPIGatewayConsumer(CreateCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayConsumerResponse>(req, "CreateCloudNativeAPIGatewayConsumer");
        }

        /// <summary>
        /// 创建AI网关消费者。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayConsumerResponse"/></returns>
        public CreateCloudNativeAPIGatewayConsumerResponse CreateCloudNativeAPIGatewayConsumerSync(CreateCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayConsumerResponse>(req, "CreateCloudNativeAPIGatewayConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建AI 网关消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayConsumerGroupResponse> CreateCloudNativeAPIGatewayConsumerGroup(CreateCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayConsumerGroupResponse>(req, "CreateCloudNativeAPIGatewayConsumerGroup");
        }

        /// <summary>
        /// 创建AI 网关消费者组
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public CreateCloudNativeAPIGatewayConsumerGroupResponse CreateCloudNativeAPIGatewayConsumerGroupSync(CreateCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayConsumerGroupResponse>(req, "CreateCloudNativeAPIGatewayConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 LLM 模型 API。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayLLMModelAPIResponse> CreateCloudNativeAPIGatewayLLMModelAPI(CreateCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayLLMModelAPIResponse>(req, "CreateCloudNativeAPIGatewayLLMModelAPI");
        }

        /// <summary>
        /// 创建 LLM 模型 API。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public CreateCloudNativeAPIGatewayLLMModelAPIResponse CreateCloudNativeAPIGatewayLLMModelAPISync(CreateCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayLLMModelAPIResponse>(req, "CreateCloudNativeAPIGatewayLLMModelAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 LLM 模型服务。同一网关下 Name 唯一。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayLLMModelServiceResponse> CreateCloudNativeAPIGatewayLLMModelService(CreateCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayLLMModelServiceResponse>(req, "CreateCloudNativeAPIGatewayLLMModelService");
        }

        /// <summary>
        /// 创建 LLM 模型服务。同一网关下 Name 唯一。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public CreateCloudNativeAPIGatewayLLMModelServiceResponse CreateCloudNativeAPIGatewayLLMModelServiceSync(CreateCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayLLMModelServiceResponse>(req, "CreateCloudNativeAPIGatewayLLMModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建AI网关MCP Server
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayMCPServerResponse> CreateCloudNativeAPIGatewayMCPServer(CreateCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayMCPServerResponse>(req, "CreateCloudNativeAPIGatewayMCPServer");
        }

        /// <summary>
        /// 创建AI网关MCP Server
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public CreateCloudNativeAPIGatewayMCPServerResponse CreateCloudNativeAPIGatewayMCPServerSync(CreateCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayMCPServerResponse>(req, "CreateCloudNativeAPIGatewayMCPServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayMCPToolResponse> CreateCloudNativeAPIGatewayMCPTool(CreateCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayMCPToolResponse>(req, "CreateCloudNativeAPIGatewayMCPTool");
        }

        /// <summary>
        /// 创建AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public CreateCloudNativeAPIGatewayMCPToolResponse CreateCloudNativeAPIGatewayMCPToolSync(CreateCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayMCPToolResponse>(req, "CreateCloudNativeAPIGatewayMCPTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建消费者密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewaySecretKeyResponse> CreateCloudNativeAPIGatewaySecretKey(CreateCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewaySecretKeyResponse>(req, "CreateCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 创建消费者密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public CreateCloudNativeAPIGatewaySecretKeyResponse CreateCloudNativeAPIGatewaySecretKeySync(CreateCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewaySecretKeyResponse>(req, "CreateCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除AI 网关消费者（被绑定到消费者组/密钥时需先解绑）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayConsumerResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayConsumerResponse> DeleteCloudNativeAPIGatewayConsumer(DeleteCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayConsumerResponse>(req, "DeleteCloudNativeAPIGatewayConsumer");
        }

        /// <summary>
        /// 删除AI 网关消费者（被绑定到消费者组/密钥时需先解绑）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayConsumerResponse"/></returns>
        public DeleteCloudNativeAPIGatewayConsumerResponse DeleteCloudNativeAPIGatewayConsumerSync(DeleteCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayConsumerResponse>(req, "DeleteCloudNativeAPIGatewayConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除AI网关消费者组
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayConsumerGroupResponse> DeleteCloudNativeAPIGatewayConsumerGroup(DeleteCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayConsumerGroupResponse>(req, "DeleteCloudNativeAPIGatewayConsumerGroup");
        }

        /// <summary>
        /// 删除AI网关消费者组
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public DeleteCloudNativeAPIGatewayConsumerGroupResponse DeleteCloudNativeAPIGatewayConsumerGroupSync(DeleteCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayConsumerGroupResponse>(req, "DeleteCloudNativeAPIGatewayConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 LLM 模型 API。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayLLMModelAPIResponse> DeleteCloudNativeAPIGatewayLLMModelAPI(DeleteCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayLLMModelAPIResponse>(req, "DeleteCloudNativeAPIGatewayLLMModelAPI");
        }

        /// <summary>
        /// 删除 LLM 模型 API。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public DeleteCloudNativeAPIGatewayLLMModelAPIResponse DeleteCloudNativeAPIGatewayLLMModelAPISync(DeleteCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayLLMModelAPIResponse>(req, "DeleteCloudNativeAPIGatewayLLMModelAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 LLM 模型服务（被模型 API 绑定时需先解绑）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayLLMModelServiceResponse> DeleteCloudNativeAPIGatewayLLMModelService(DeleteCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayLLMModelServiceResponse>(req, "DeleteCloudNativeAPIGatewayLLMModelService");
        }

        /// <summary>
        /// 删除 LLM 模型服务（被模型 API 绑定时需先解绑）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public DeleteCloudNativeAPIGatewayLLMModelServiceResponse DeleteCloudNativeAPIGatewayLLMModelServiceSync(DeleteCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayLLMModelServiceResponse>(req, "DeleteCloudNativeAPIGatewayLLMModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除AI网关MCP服务
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayMCPServerResponse> DeleteCloudNativeAPIGatewayMCPServer(DeleteCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPServerResponse>(req, "DeleteCloudNativeAPIGatewayMCPServer");
        }

        /// <summary>
        /// 删除AI网关MCP服务
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public DeleteCloudNativeAPIGatewayMCPServerResponse DeleteCloudNativeAPIGatewayMCPServerSync(DeleteCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPServerResponse>(req, "DeleteCloudNativeAPIGatewayMCPServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayMCPToolResponse> DeleteCloudNativeAPIGatewayMCPTool(DeleteCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPToolResponse>(req, "DeleteCloudNativeAPIGatewayMCPTool");
        }

        /// <summary>
        /// 删除AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public DeleteCloudNativeAPIGatewayMCPToolResponse DeleteCloudNativeAPIGatewayMCPToolSync(DeleteCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPToolResponse>(req, "DeleteCloudNativeAPIGatewayMCPTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除消费者密钥（被绑定时需先解绑）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewaySecretKeyResponse> DeleteCloudNativeAPIGatewaySecretKey(DeleteCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewaySecretKeyResponse>(req, "DeleteCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 删除消费者密钥（被绑定时需先解绑）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public DeleteCloudNativeAPIGatewaySecretKeyResponse DeleteCloudNativeAPIGatewaySecretKeySync(DeleteCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewaySecretKeyResponse>(req, "DeleteCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生消费者详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConsumerResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayConsumerResponse> DescribeCloudNativeAPIGatewayConsumer(DescribeCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConsumerResponse>(req, "DescribeCloudNativeAPIGatewayConsumer");
        }

        /// <summary>
        /// 查询云原生消费者详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConsumerResponse"/></returns>
        public DescribeCloudNativeAPIGatewayConsumerResponse DescribeCloudNativeAPIGatewayConsumerSync(DescribeCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConsumerResponse>(req, "DescribeCloudNativeAPIGatewayConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消费者组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayConsumerGroupResponse> DescribeCloudNativeAPIGatewayConsumerGroup(DescribeCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConsumerGroupResponse>(req, "DescribeCloudNativeAPIGatewayConsumerGroup");
        }

        /// <summary>
        /// 查询消费者组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public DescribeCloudNativeAPIGatewayConsumerGroupResponse DescribeCloudNativeAPIGatewayConsumerGroupSync(DescribeCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConsumerGroupResponse>(req, "DescribeCloudNativeAPIGatewayConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个 LLM 模型 API 详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMModelAPIResponse> DescribeCloudNativeAPIGatewayLLMModelAPI(DescribeCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelAPIResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelAPI");
        }

        /// <summary>
        /// 查询单个 LLM 模型 API 详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMModelAPIResponse DescribeCloudNativeAPIGatewayLLMModelAPISync(DescribeCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelAPIResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 LLM 模型 API 列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMModelAPIsResponse> DescribeCloudNativeAPIGatewayLLMModelAPIs(DescribeCloudNativeAPIGatewayLLMModelAPIsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelAPIsResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelAPIs");
        }

        /// <summary>
        /// 查询 LLM 模型 API 列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMModelAPIsResponse DescribeCloudNativeAPIGatewayLLMModelAPIsSync(DescribeCloudNativeAPIGatewayLLMModelAPIsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelAPIsResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelAPIs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个 LLM 模型服务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMModelServiceResponse> DescribeCloudNativeAPIGatewayLLMModelService(DescribeCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelServiceResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelService");
        }

        /// <summary>
        /// 查询单个 LLM 模型服务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMModelServiceResponse DescribeCloudNativeAPIGatewayLLMModelServiceSync(DescribeCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelServiceResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 LLM 模型服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelServicesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMModelServicesResponse> DescribeCloudNativeAPIGatewayLLMModelServices(DescribeCloudNativeAPIGatewayLLMModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelServicesResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelServices");
        }

        /// <summary>
        /// 查询 LLM 模型服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelServicesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMModelServicesResponse DescribeCloudNativeAPIGatewayLLMModelServicesSync(DescribeCloudNativeAPIGatewayLLMModelServicesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelServicesResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 AI 网关Token 消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse> DescribeCloudNativeAPIGatewayLLMTokenUsageList(DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageList");
        }

        /// <summary>
        /// 查询 AI 网关Token 消耗统计
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse DescribeCloudNativeAPIGatewayLLMTokenUsageListSync(DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 AI 网关Token 消耗统计汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse> DescribeCloudNativeAPIGatewayLLMTokenUsageStatistics(DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageStatistics");
        }

        /// <summary>
        /// 查询 AI 网关Token 消耗统计汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsSync(DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI 网关MCP服务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPServerResponse> DescribeCloudNativeAPIGatewayMCPServer(DescribeCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerResponse>(req, "DescribeCloudNativeAPIGatewayMCPServer");
        }

        /// <summary>
        /// 查询AI 网关MCP服务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPServerResponse DescribeCloudNativeAPIGatewayMCPServerSync(DescribeCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerResponse>(req, "DescribeCloudNativeAPIGatewayMCPServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看 MCP Server ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerACLRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerACLResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPServerACLResponse> DescribeCloudNativeAPIGatewayMCPServerACL(DescribeCloudNativeAPIGatewayMCPServerACLRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerACLResponse>(req, "DescribeCloudNativeAPIGatewayMCPServerACL");
        }

        /// <summary>
        /// 查看 MCP Server ACL
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerACLRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerACLResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPServerACLResponse DescribeCloudNativeAPIGatewayMCPServerACLSync(DescribeCloudNativeAPIGatewayMCPServerACLRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerACLResponse>(req, "DescribeCloudNativeAPIGatewayMCPServerACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 MCP Server 的认证配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerAuthRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerAuthResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPServerAuthResponse> DescribeCloudNativeAPIGatewayMCPServerAuth(DescribeCloudNativeAPIGatewayMCPServerAuthRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerAuthResponse>(req, "DescribeCloudNativeAPIGatewayMCPServerAuth");
        }

        /// <summary>
        /// 查询 MCP Server 的认证配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerAuthRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerAuthResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPServerAuthResponse DescribeCloudNativeAPIGatewayMCPServerAuthSync(DescribeCloudNativeAPIGatewayMCPServerAuthRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerAuthResponse>(req, "DescribeCloudNativeAPIGatewayMCPServerAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI网关查询MCP服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPServerListResponse> DescribeCloudNativeAPIGatewayMCPServerList(DescribeCloudNativeAPIGatewayMCPServerListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerListResponse>(req, "DescribeCloudNativeAPIGatewayMCPServerList");
        }

        /// <summary>
        /// AI网关查询MCP服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPServerListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPServerListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPServerListResponse DescribeCloudNativeAPIGatewayMCPServerListSync(DescribeCloudNativeAPIGatewayMCPServerListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPServerListResponse>(req, "DescribeCloudNativeAPIGatewayMCPServerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPToolResponse> DescribeCloudNativeAPIGatewayMCPTool(DescribeCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolResponse>(req, "DescribeCloudNativeAPIGatewayMCPTool");
        }

        /// <summary>
        /// 查看AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPToolResponse DescribeCloudNativeAPIGatewayMCPToolSync(DescribeCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolResponse>(req, "DescribeCloudNativeAPIGatewayMCPTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关 MCP Server 下所有 Tool 的 ACL 状态一览（含 Server ACLType 回显）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolACLListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolACLListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPToolACLListResponse> DescribeCloudNativeAPIGatewayMCPToolACLList(DescribeCloudNativeAPIGatewayMCPToolACLListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolACLListResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolACLList");
        }

        /// <summary>
        /// 查询云原生网关 MCP Server 下所有 Tool 的 ACL 状态一览（含 Server ACLType 回显）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolACLListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolACLListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPToolACLListResponse DescribeCloudNativeAPIGatewayMCPToolACLListSync(DescribeCloudNativeAPIGatewayMCPToolACLListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolACLListResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolACLList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 AI 网关MCP Tool 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPToolListResponse> DescribeCloudNativeAPIGatewayMCPToolList(DescribeCloudNativeAPIGatewayMCPToolListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolListResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolList");
        }

        /// <summary>
        /// 查询 AI 网关MCP Tool 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPToolListResponse DescribeCloudNativeAPIGatewayMCPToolListSync(DescribeCloudNativeAPIGatewayMCPToolListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolListResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询密钥详情（SecretValue 字段会被掩码）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewaySecretKeyResponse> DescribeCloudNativeAPIGatewaySecretKey(DescribeCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyResponse>(req, "DescribeCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 查询密钥详情（SecretValue 字段会被掩码）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public DescribeCloudNativeAPIGatewaySecretKeyResponse DescribeCloudNativeAPIGatewaySecretKeySync(DescribeCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyResponse>(req, "DescribeCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询密钥明文值（KMS 类型密钥不可获取）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyValueRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyValueResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewaySecretKeyValueResponse> DescribeCloudNativeAPIGatewaySecretKeyValue(DescribeCloudNativeAPIGatewaySecretKeyValueRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyValueResponse>(req, "DescribeCloudNativeAPIGatewaySecretKeyValue");
        }

        /// <summary>
        /// 查询密钥明文值（KMS 类型密钥不可获取）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyValueRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyValueResponse"/></returns>
        public DescribeCloudNativeAPIGatewaySecretKeyValueResponse DescribeCloudNativeAPIGatewaySecretKeyValueSync(DescribeCloudNativeAPIGatewaySecretKeyValueRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyValueResponse>(req, "DescribeCloudNativeAPIGatewaySecretKeyValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改AI网关消费者
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayConsumerResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayConsumerResponse> ModifyCloudNativeAPIGatewayConsumer(ModifyCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayConsumerResponse>(req, "ModifyCloudNativeAPIGatewayConsumer");
        }

        /// <summary>
        /// 修改AI网关消费者
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayConsumerResponse"/></returns>
        public ModifyCloudNativeAPIGatewayConsumerResponse ModifyCloudNativeAPIGatewayConsumerSync(ModifyCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayConsumerResponse>(req, "ModifyCloudNativeAPIGatewayConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改消费者组。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayConsumerGroupResponse> ModifyCloudNativeAPIGatewayConsumerGroup(ModifyCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayConsumerGroupResponse>(req, "ModifyCloudNativeAPIGatewayConsumerGroup");
        }

        /// <summary>
        /// 修改消费者组。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public ModifyCloudNativeAPIGatewayConsumerGroupResponse ModifyCloudNativeAPIGatewayConsumerGroupSync(ModifyCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayConsumerGroupResponse>(req, "ModifyCloudNativeAPIGatewayConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 LLM 模型 API。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayLLMModelAPIResponse> ModifyCloudNativeAPIGatewayLLMModelAPI(ModifyCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayLLMModelAPIResponse>(req, "ModifyCloudNativeAPIGatewayLLMModelAPI");
        }

        /// <summary>
        /// 修改 LLM 模型 API。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayLLMModelAPIRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayLLMModelAPIResponse"/></returns>
        public ModifyCloudNativeAPIGatewayLLMModelAPIResponse ModifyCloudNativeAPIGatewayLLMModelAPISync(ModifyCloudNativeAPIGatewayLLMModelAPIRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayLLMModelAPIResponse>(req, "ModifyCloudNativeAPIGatewayLLMModelAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 LLM 模型服务。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayLLMModelServiceResponse> ModifyCloudNativeAPIGatewayLLMModelService(ModifyCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayLLMModelServiceResponse>(req, "ModifyCloudNativeAPIGatewayLLMModelService");
        }

        /// <summary>
        /// 修改 LLM 模型服务。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public ModifyCloudNativeAPIGatewayLLMModelServiceResponse ModifyCloudNativeAPIGatewayLLMModelServiceSync(ModifyCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayLLMModelServiceResponse>(req, "ModifyCloudNativeAPIGatewayLLMModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改MCP服务配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPServerResponse> ModifyCloudNativeAPIGatewayMCPServer(ModifyCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerResponse>(req, "ModifyCloudNativeAPIGatewayMCPServer");
        }

        /// <summary>
        /// 修改MCP服务配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPServerResponse ModifyCloudNativeAPIGatewayMCPServerSync(ModifyCloudNativeAPIGatewayMCPServerRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerResponse>(req, "ModifyCloudNativeAPIGatewayMCPServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 MCP Server ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerACLRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerACLResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPServerACLResponse> ModifyCloudNativeAPIGatewayMCPServerACL(ModifyCloudNativeAPIGatewayMCPServerACLRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerACLResponse>(req, "ModifyCloudNativeAPIGatewayMCPServerACL");
        }

        /// <summary>
        /// 修改 MCP Server ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerACLRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerACLResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPServerACLResponse ModifyCloudNativeAPIGatewayMCPServerACLSync(ModifyCloudNativeAPIGatewayMCPServerACLRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerACLResponse>(req, "ModifyCloudNativeAPIGatewayMCPServerACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 MCP Server 的认证配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerAuthRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerAuthResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPServerAuthResponse> ModifyCloudNativeAPIGatewayMCPServerAuth(ModifyCloudNativeAPIGatewayMCPServerAuthRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerAuthResponse>(req, "ModifyCloudNativeAPIGatewayMCPServerAuth");
        }

        /// <summary>
        /// 修改 MCP Server 的认证配置
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerAuthRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerAuthResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPServerAuthResponse ModifyCloudNativeAPIGatewayMCPServerAuthSync(ModifyCloudNativeAPIGatewayMCPServerAuthRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerAuthResponse>(req, "ModifyCloudNativeAPIGatewayMCPServerAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建AI 网关MCP Server
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerStatusRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerStatusResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPServerStatusResponse> ModifyCloudNativeAPIGatewayMCPServerStatus(ModifyCloudNativeAPIGatewayMCPServerStatusRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerStatusResponse>(req, "ModifyCloudNativeAPIGatewayMCPServerStatus");
        }

        /// <summary>
        /// 创建AI 网关MCP Server
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPServerStatusRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPServerStatusResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPServerStatusResponse ModifyCloudNativeAPIGatewayMCPServerStatusSync(ModifyCloudNativeAPIGatewayMCPServerStatusRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPServerStatusResponse>(req, "ModifyCloudNativeAPIGatewayMCPServerStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPToolResponse> ModifyCloudNativeAPIGatewayMCPTool(ModifyCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPToolResponse>(req, "ModifyCloudNativeAPIGatewayMCPTool");
        }

        /// <summary>
        /// 修改AI网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPToolRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPToolResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPToolResponse ModifyCloudNativeAPIGatewayMCPToolSync(ModifyCloudNativeAPIGatewayMCPToolRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPToolResponse>(req, "ModifyCloudNativeAPIGatewayMCPTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 MCP Server Tool ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPToolACLRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPToolACLResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPToolACLResponse> ModifyCloudNativeAPIGatewayMCPToolACL(ModifyCloudNativeAPIGatewayMCPToolACLRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPToolACLResponse>(req, "ModifyCloudNativeAPIGatewayMCPToolACL");
        }

        /// <summary>
        /// 修改 MCP Server Tool ACL
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPToolACLRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPToolACLResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPToolACLResponse ModifyCloudNativeAPIGatewayMCPToolACLSync(ModifyCloudNativeAPIGatewayMCPToolACLRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPToolACLResponse>(req, "ModifyCloudNativeAPIGatewayMCPToolACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AI网关修改MCP Tool上下线状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPToolStatusRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPToolStatusResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPToolStatusResponse> ModifyCloudNativeAPIGatewayMCPToolStatus(ModifyCloudNativeAPIGatewayMCPToolStatusRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPToolStatusResponse>(req, "ModifyCloudNativeAPIGatewayMCPToolStatus");
        }

        /// <summary>
        /// AI网关修改MCP Tool上下线状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPToolStatusRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPToolStatusResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPToolStatusResponse ModifyCloudNativeAPIGatewayMCPToolStatusSync(ModifyCloudNativeAPIGatewayMCPToolStatusRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPToolStatusResponse>(req, "ModifyCloudNativeAPIGatewayMCPToolStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改AI网关密钥
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewaySecretKeyResponse> ModifyCloudNativeAPIGatewaySecretKey(ModifyCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewaySecretKeyResponse>(req, "ModifyCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 修改AI网关密钥
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public ModifyCloudNativeAPIGatewaySecretKeyResponse ModifyCloudNativeAPIGatewaySecretKeySync(ModifyCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewaySecretKeyResponse>(req, "ModifyCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从资源（模型 API / MCP Server）移除消费者组授权。
        /// </summary>
        /// <param name="req"><see cref="RemoveCloudNativeAPIGatewayConsumerGroupAuthRequest"/></param>
        /// <returns><see cref="RemoveCloudNativeAPIGatewayConsumerGroupAuthResponse"/></returns>
        public Task<RemoveCloudNativeAPIGatewayConsumerGroupAuthResponse> RemoveCloudNativeAPIGatewayConsumerGroupAuth(RemoveCloudNativeAPIGatewayConsumerGroupAuthRequest req)
        {
            return InternalRequestAsync<RemoveCloudNativeAPIGatewayConsumerGroupAuthResponse>(req, "RemoveCloudNativeAPIGatewayConsumerGroupAuth");
        }

        /// <summary>
        /// 从资源（模型 API / MCP Server）移除消费者组授权。
        /// </summary>
        /// <param name="req"><see cref="RemoveCloudNativeAPIGatewayConsumerGroupAuthRequest"/></param>
        /// <returns><see cref="RemoveCloudNativeAPIGatewayConsumerGroupAuthResponse"/></returns>
        public RemoveCloudNativeAPIGatewayConsumerGroupAuthResponse RemoveCloudNativeAPIGatewayConsumerGroupAuthSync(RemoveCloudNativeAPIGatewayConsumerGroupAuthRequest req)
        {
            return InternalRequestAsync<RemoveCloudNativeAPIGatewayConsumerGroupAuthResponse>(req, "RemoveCloudNativeAPIGatewayConsumerGroupAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将消费者从消费者组移除。
        /// </summary>
        /// <param name="req"><see cref="RemoveCloudNativeAPIGatewayConsumerInGroupRequest"/></param>
        /// <returns><see cref="RemoveCloudNativeAPIGatewayConsumerInGroupResponse"/></returns>
        public Task<RemoveCloudNativeAPIGatewayConsumerInGroupResponse> RemoveCloudNativeAPIGatewayConsumerInGroup(RemoveCloudNativeAPIGatewayConsumerInGroupRequest req)
        {
            return InternalRequestAsync<RemoveCloudNativeAPIGatewayConsumerInGroupResponse>(req, "RemoveCloudNativeAPIGatewayConsumerInGroup");
        }

        /// <summary>
        /// 将消费者从消费者组移除。
        /// </summary>
        /// <param name="req"><see cref="RemoveCloudNativeAPIGatewayConsumerInGroupRequest"/></param>
        /// <returns><see cref="RemoveCloudNativeAPIGatewayConsumerInGroupResponse"/></returns>
        public RemoveCloudNativeAPIGatewayConsumerInGroupResponse RemoveCloudNativeAPIGatewayConsumerInGroupSync(RemoveCloudNativeAPIGatewayConsumerInGroupRequest req)
        {
            return InternalRequestAsync<RemoveCloudNativeAPIGatewayConsumerInGroupResponse>(req, "RemoveCloudNativeAPIGatewayConsumerInGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑密钥
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="UnbindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<UnbindCloudNativeAPIGatewaySecretKeyResponse> UnbindCloudNativeAPIGatewaySecretKey(UnbindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<UnbindCloudNativeAPIGatewaySecretKeyResponse>(req, "UnbindCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 解绑密钥
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="UnbindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public UnbindCloudNativeAPIGatewaySecretKeyResponse UnbindCloudNativeAPIGatewaySecretKeySync(UnbindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<UnbindCloudNativeAPIGatewaySecretKeyResponse>(req, "UnbindCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
