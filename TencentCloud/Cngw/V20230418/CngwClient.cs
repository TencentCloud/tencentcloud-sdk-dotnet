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
       private const string sdkVersion = "SDK_NET_3.0.1528";

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
        /// 【消费者批量自动分配 API Key｜修改：内部并发/配额逻辑，字段不变】ResourceType=Consumer 时与批量预留共用实例写锁，单消费者绑定配额使用当前锁定读。仍按原 SecretKeyId、ResourceIds 绑定；消费者目标最多一个，单密钥不能同时绑定多个消费者，成功仍返回 Result=true。此入口不新增 OperationDenied.BatchKeyPending；该错误属于下述四个变更入口的保护逻辑。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="BindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="BindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<BindCloudNativeAPIGatewaySecretKeyResponse> BindCloudNativeAPIGatewaySecretKey(BindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<BindCloudNativeAPIGatewaySecretKeyResponse>(req, "BindCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 添加密钥与资源的引用关系接口
        /// 【消费者批量自动分配 API Key｜修改：内部并发/配额逻辑，字段不变】ResourceType=Consumer 时与批量预留共用实例写锁，单消费者绑定配额使用当前锁定读。仍按原 SecretKeyId、ResourceIds 绑定；消费者目标最多一个，单密钥不能同时绑定多个消费者，成功仍返回 Result=true。此入口不新增 OperationDenied.BatchKeyPending；该错误属于下述四个变更入口的保护逻辑。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="BindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="BindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public BindCloudNativeAPIGatewaySecretKeyResponse BindCloudNativeAPIGatewaySecretKeySync(BindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<BindCloudNativeAPIGatewaySecretKeyResponse>(req, "BindCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="CheckCloudNativeAPIGatewayMCPRouteMatchRequest"/></param>
        /// <returns><see cref="CheckCloudNativeAPIGatewayMCPRouteMatchResponse"/></returns>
        public Task<CheckCloudNativeAPIGatewayMCPRouteMatchResponse> CheckCloudNativeAPIGatewayMCPRouteMatch(CheckCloudNativeAPIGatewayMCPRouteMatchRequest req)
        {
            return InternalRequestAsync<CheckCloudNativeAPIGatewayMCPRouteMatchResponse>(req, "CheckCloudNativeAPIGatewayMCPRouteMatch");
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="CheckCloudNativeAPIGatewayMCPRouteMatchRequest"/></param>
        /// <returns><see cref="CheckCloudNativeAPIGatewayMCPRouteMatchResponse"/></returns>
        public CheckCloudNativeAPIGatewayMCPRouteMatchResponse CheckCloudNativeAPIGatewayMCPRouteMatchSync(CheckCloudNativeAPIGatewayMCPRouteMatchRequest req)
        {
            return InternalRequestAsync<CheckCloudNativeAPIGatewayMCPRouteMatchResponse>(req, "CheckCloudNativeAPIGatewayMCPRouteMatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="CheckCloudNativeAPIGatewayMCPToolVersionExistRequest"/></param>
        /// <returns><see cref="CheckCloudNativeAPIGatewayMCPToolVersionExistResponse"/></returns>
        public Task<CheckCloudNativeAPIGatewayMCPToolVersionExistResponse> CheckCloudNativeAPIGatewayMCPToolVersionExist(CheckCloudNativeAPIGatewayMCPToolVersionExistRequest req)
        {
            return InternalRequestAsync<CheckCloudNativeAPIGatewayMCPToolVersionExistResponse>(req, "CheckCloudNativeAPIGatewayMCPToolVersionExist");
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="CheckCloudNativeAPIGatewayMCPToolVersionExistRequest"/></param>
        /// <returns><see cref="CheckCloudNativeAPIGatewayMCPToolVersionExistResponse"/></returns>
        public CheckCloudNativeAPIGatewayMCPToolVersionExistResponse CheckCloudNativeAPIGatewayMCPToolVersionExistSync(CheckCloudNativeAPIGatewayMCPToolVersionExistRequest req)
        {
            return InternalRequestAsync<CheckCloudNativeAPIGatewayMCPToolVersionExistResponse>(req, "CheckCloudNativeAPIGatewayMCPToolVersionExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="CompareCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="CompareCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public Task<CompareCloudNativeAPIGatewayMCPToolVersionResponse> CompareCloudNativeAPIGatewayMCPToolVersion(CompareCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<CompareCloudNativeAPIGatewayMCPToolVersionResponse>(req, "CompareCloudNativeAPIGatewayMCPToolVersion");
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="CompareCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="CompareCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public CompareCloudNativeAPIGatewayMCPToolVersionResponse CompareCloudNativeAPIGatewayMCPToolVersionSync(CompareCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<CompareCloudNativeAPIGatewayMCPToolVersionResponse>(req, "CompareCloudNativeAPIGatewayMCPToolVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayAIServiceSourceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayAIServiceSourceResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayAIServiceSourceResponse> CreateCloudNativeAPIGatewayAIServiceSource(CreateCloudNativeAPIGatewayAIServiceSourceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayAIServiceSourceResponse>(req, "CreateCloudNativeAPIGatewayAIServiceSource");
        }

        /// <summary>
        /// 创建云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayAIServiceSourceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayAIServiceSourceResponse"/></returns>
        public CreateCloudNativeAPIGatewayAIServiceSourceResponse CreateCloudNativeAPIGatewayAIServiceSourceSync(CreateCloudNativeAPIGatewayAIServiceSourceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayAIServiceSourceResponse>(req, "CreateCloudNativeAPIGatewayAIServiceSource")
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
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayMCPRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayMCPRouteResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayMCPRouteResponse> CreateCloudNativeAPIGatewayMCPRoute(CreateCloudNativeAPIGatewayMCPRouteRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayMCPRouteResponse>(req, "CreateCloudNativeAPIGatewayMCPRoute");
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayMCPRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayMCPRouteResponse"/></returns>
        public CreateCloudNativeAPIGatewayMCPRouteResponse CreateCloudNativeAPIGatewayMCPRouteSync(CreateCloudNativeAPIGatewayMCPRouteRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayMCPRouteResponse>(req, "CreateCloudNativeAPIGatewayMCPRoute")
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
        /// 【消费者批量自动分配 API Key｜修改：内部并发/配额逻辑，字段不变】消费者密钥单条创建在事务中使用与批量预留相同的实例写锁，配额检查使用当前锁定读，避免单条与批量并发绕过配额。仍是单条创建；原 GenerateType、请求字段、既有配额错误语义及 Result.Success/ID 不变，不增加 ConsumerIds/ClientToken。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewaySecretKeyResponse> CreateCloudNativeAPIGatewaySecretKey(CreateCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewaySecretKeyResponse>(req, "CreateCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 创建消费者密钥。
        /// 【消费者批量自动分配 API Key｜修改：内部并发/配额逻辑，字段不变】消费者密钥单条创建在事务中使用与批量预留相同的实例写锁，配额检查使用当前锁定读，避免单条与批量并发绕过配额。仍是单条创建；原 GenerateType、请求字段、既有配额错误语义及 Result.Success/ID 不变，不增加 ConsumerIds/ClientToken。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public CreateCloudNativeAPIGatewaySecretKeyResponse CreateCloudNativeAPIGatewaySecretKeySync(CreateCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewaySecretKeyResponse>(req, "CreateCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayAIServiceSourceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayAIServiceSourceResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayAIServiceSourceResponse> DeleteCloudNativeAPIGatewayAIServiceSource(DeleteCloudNativeAPIGatewayAIServiceSourceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayAIServiceSourceResponse>(req, "DeleteCloudNativeAPIGatewayAIServiceSource");
        }

        /// <summary>
        /// 删除云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayAIServiceSourceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayAIServiceSourceResponse"/></returns>
        public DeleteCloudNativeAPIGatewayAIServiceSourceResponse DeleteCloudNativeAPIGatewayAIServiceSourceSync(DeleteCloudNativeAPIGatewayAIServiceSourceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayAIServiceSourceResponse>(req, "DeleteCloudNativeAPIGatewayAIServiceSource")
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
        /// 
        /// 同步组仅在 soft_deleted 状态且全部依赖已清理后允许手动硬删除；ConsumerGroupId 使用组织 UUID。存在配额规则时须先删除规则，单纯停用不能解除依赖。硬删除时重新校验，依赖变化可能导致删除失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayConsumerGroupResponse> DeleteCloudNativeAPIGatewayConsumerGroup(DeleteCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayConsumerGroupResponse>(req, "DeleteCloudNativeAPIGatewayConsumerGroup");
        }

        /// <summary>
        /// 删除AI网关消费者组
        /// 
        /// 同步组仅在 soft_deleted 状态且全部依赖已清理后允许手动硬删除；ConsumerGroupId 使用组织 UUID。存在配额规则时须先删除规则，单纯停用不能解除依赖。硬删除时重新校验，依赖变化可能导致删除失败。
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
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPRouteResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayMCPRouteResponse> DeleteCloudNativeAPIGatewayMCPRoute(DeleteCloudNativeAPIGatewayMCPRouteRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPRouteResponse>(req, "DeleteCloudNativeAPIGatewayMCPRoute");
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPRouteResponse"/></returns>
        public DeleteCloudNativeAPIGatewayMCPRouteResponse DeleteCloudNativeAPIGatewayMCPRouteSync(DeleteCloudNativeAPIGatewayMCPRouteRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPRouteResponse>(req, "DeleteCloudNativeAPIGatewayMCPRoute")
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
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayMCPToolVersionResponse> DeleteCloudNativeAPIGatewayMCPToolVersion(DeleteCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPToolVersionResponse>(req, "DeleteCloudNativeAPIGatewayMCPToolVersion");
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public DeleteCloudNativeAPIGatewayMCPToolVersionResponse DeleteCloudNativeAPIGatewayMCPToolVersionSync(DeleteCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayMCPToolVersionResponse>(req, "DeleteCloudNativeAPIGatewayMCPToolVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除消费者密钥（被绑定时需先解绑）。
        /// 【消费者批量自动分配 API Key｜修改：新增未完成批次保护，字段不变】目标密钥属于批次且对应项处于 Pending/Running/Reconciling 时，删除返回 OperationDenied.BatchKeyPending。完成后仍执行原绑定/依赖删除检查；原 GatewayId/SecretKeyId 不变，成功不新增业务 Result。删除已生成密钥不改写批次历史成功，后续批次明文读取返回逐项 ResourceNotFound.SecretKey。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewaySecretKeyResponse> DeleteCloudNativeAPIGatewaySecretKey(DeleteCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewaySecretKeyResponse>(req, "DeleteCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 删除消费者密钥（被绑定时需先解绑）。
        /// 【消费者批量自动分配 API Key｜修改：新增未完成批次保护，字段不变】目标密钥属于批次且对应项处于 Pending/Running/Reconciling 时，删除返回 OperationDenied.BatchKeyPending。完成后仍执行原绑定/依赖删除检查；原 GatewayId/SecretKeyId 不变，成功不新增业务 Result。删除已生成密钥不改写批次历史成功，后续批次明文读取返回逐项 ResourceNotFound.SecretKey。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public DeleteCloudNativeAPIGatewaySecretKeyResponse DeleteCloudNativeAPIGatewaySecretKeySync(DeleteCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewaySecretKeyResponse>(req, "DeleteCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关服务和路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCNGWServicesWithRoutesRequest"/></param>
        /// <returns><see cref="DescribeCNGWServicesWithRoutesResponse"/></returns>
        public Task<DescribeCNGWServicesWithRoutesResponse> DescribeCNGWServicesWithRoutes(DescribeCNGWServicesWithRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCNGWServicesWithRoutesResponse>(req, "DescribeCNGWServicesWithRoutes");
        }

        /// <summary>
        /// 查询云原生网关服务和路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCNGWServicesWithRoutesRequest"/></param>
        /// <returns><see cref="DescribeCNGWServicesWithRoutesResponse"/></returns>
        public DescribeCNGWServicesWithRoutesResponse DescribeCNGWServicesWithRoutesSync(DescribeCNGWServicesWithRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCNGWServicesWithRoutesResponse>(req, "DescribeCNGWServicesWithRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI网关配额
        /// 
        /// 支持 ConsumerGroup 配额，返回 ConsumerGroupPath、ConsumerGroupActive 及实际用量；失效组的规则仍可查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayAIQuotaRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayAIQuotaResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayAIQuotaResponse> DescribeCloudNativeAPIGatewayAIQuota(DescribeCloudNativeAPIGatewayAIQuotaRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayAIQuotaResponse>(req, "DescribeCloudNativeAPIGatewayAIQuota");
        }

        /// <summary>
        /// 查询AI网关配额
        /// 
        /// 支持 ConsumerGroup 配额，返回 ConsumerGroupPath、ConsumerGroupActive 及实际用量；失效组的规则仍可查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayAIQuotaRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayAIQuotaResponse"/></returns>
        public DescribeCloudNativeAPIGatewayAIQuotaResponse DescribeCloudNativeAPIGatewayAIQuotaSync(DescribeCloudNativeAPIGatewayAIQuotaRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayAIQuotaResponse>(req, "DescribeCloudNativeAPIGatewayAIQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI配额配置列表
        /// 
        /// 支持按 ConsumerGroup 查询组自身配额，默认仍只查询 Consumer；返回组路径、有效状态及实际用量。上下级关联配额请使用 DescribeAIGWConsumerGroupAIQuotaList。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayAIQuotaListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayAIQuotaListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayAIQuotaListResponse> DescribeCloudNativeAPIGatewayAIQuotaList(DescribeCloudNativeAPIGatewayAIQuotaListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayAIQuotaListResponse>(req, "DescribeCloudNativeAPIGatewayAIQuotaList");
        }

        /// <summary>
        /// 查询AI配额配置列表
        /// 
        /// 支持按 ConsumerGroup 查询组自身配额，默认仍只查询 Consumer；返回组路径、有效状态及实际用量。上下级关联配额请使用 DescribeAIGWConsumerGroupAIQuotaList。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayAIQuotaListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayAIQuotaListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayAIQuotaListResponse DescribeCloudNativeAPIGatewayAIQuotaListSync(DescribeCloudNativeAPIGatewayAIQuotaListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayAIQuotaListResponse>(req, "DescribeCloudNativeAPIGatewayAIQuotaList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayAIServiceSourceListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayAIServiceSourceListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayAIServiceSourceListResponse> DescribeCloudNativeAPIGatewayAIServiceSourceList(DescribeCloudNativeAPIGatewayAIServiceSourceListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayAIServiceSourceListResponse>(req, "DescribeCloudNativeAPIGatewayAIServiceSourceList");
        }

        /// <summary>
        /// 查询云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayAIServiceSourceListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayAIServiceSourceListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayAIServiceSourceListResponse DescribeCloudNativeAPIGatewayAIServiceSourceListSync(DescribeCloudNativeAPIGatewayAIServiceSourceListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayAIServiceSourceListResponse>(req, "DescribeCloudNativeAPIGatewayAIServiceSourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生消费者详情
        /// 
        /// 组织架构扩展：保留原消费者详情与完整字段，ConsumerGroups 补齐对应组织成员关系；同步成员保持目录归属隔离。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConsumerRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConsumerResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayConsumerResponse> DescribeCloudNativeAPIGatewayConsumer(DescribeCloudNativeAPIGatewayConsumerRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConsumerResponse>(req, "DescribeCloudNativeAPIGatewayConsumer");
        }

        /// <summary>
        /// 查询云原生消费者详情
        /// 
        /// 组织架构扩展：保留原消费者详情与完整字段，ConsumerGroups 补齐对应组织成员关系；同步成员保持目录归属隔离。
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
        /// 
        /// 组织架构扩展：ConsumerGroupId 同时支持原 cg-* 和组织部门 UUID；保留状态、数量、时间和描述逻辑。原普通组状态为 Enable/Disable，目录部门状态为 active/disabled/soft_deleted。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConsumerGroupResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayConsumerGroupResponse> DescribeCloudNativeAPIGatewayConsumerGroup(DescribeCloudNativeAPIGatewayConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConsumerGroupResponse>(req, "DescribeCloudNativeAPIGatewayConsumerGroup");
        }

        /// <summary>
        /// 查询消费者组详情。
        /// 
        /// 组织架构扩展：ConsumerGroupId 同时支持原 cg-* 和组织部门 UUID；保留状态、数量、时间和描述逻辑。原普通组状态为 Enable/Disable，目录部门状态为 active/disabled/soft_deleted。
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
        /// 查询指定网关实例下的所有 LLM 模型 API 列表。支持按名称关键词模糊搜索、按过滤器筛选，以及分页查询。用于绑定场景时，可通过 ConsumerGroupId 和 UseToBind 参数筛选可绑定的模型 API。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMModelAPIsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMModelAPIsResponse> DescribeCloudNativeAPIGatewayLLMModelAPIs(DescribeCloudNativeAPIGatewayLLMModelAPIsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMModelAPIsResponse>(req, "DescribeCloudNativeAPIGatewayLLMModelAPIs");
        }

        /// <summary>
        /// 查询指定网关实例下的所有 LLM 模型 API 列表。支持按名称关键词模糊搜索、按过滤器筛选，以及分页查询。用于绑定场景时，可通过 ConsumerGroupId 和 UseToBind 参数筛选可绑定的模型 API。
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
        /// 查询 AI 网关 Token 用量列表。网关版本不低于 3.9.8 且 Dimension=ConsumerGroup 时，未指定节点筛选则列出 Kong CP 当前目录的全部真实节点，包含同步、自定义、禁用及保留中的软删节点，排除合成展示节点。按当前名称、节点 UUID 升序，先分页节点再查询历史指标；无调用节点仍返回，Token 与请求数补零。节点指标包含历史下属，同一请求可计入多个组行，不能逐行相加作为网关总量。 网关版本不低于 3.9.8 时，所有支持维度的消费者组筛选统一为 ConsumerGroupId / ConsumerGroupName，均按历史归属查询；旧 OrganizationNodeId / OrganizationNodeName 筛选不再接受。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse> DescribeCloudNativeAPIGatewayLLMTokenUsageList(DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageList");
        }

        /// <summary>
        /// 查询 AI 网关 Token 用量列表。网关版本不低于 3.9.8 且 Dimension=ConsumerGroup 时，未指定节点筛选则列出 Kong CP 当前目录的全部真实节点，包含同步、自定义、禁用及保留中的软删节点，排除合成展示节点。按当前名称、节点 UUID 升序，先分页节点再查询历史指标；无调用节点仍返回，Token 与请求数补零。节点指标包含历史下属，同一请求可计入多个组行，不能逐行相加作为网关总量。 网关版本不低于 3.9.8 时，所有支持维度的消费者组筛选统一为 ConsumerGroupId / ConsumerGroupName，均按历史归属查询；旧 OrganizationNodeId / OrganizationNodeName 筛选不再接受。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse DescribeCloudNativeAPIGatewayLLMTokenUsageListSync(DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageListResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 AI 网关 Token 用量汇总。网关版本不低于 3.9.8 且 Dimension=ConsumerGroup 时，按历史归属对日志并集去重统计；无节点筛选则查询全部成功归属且祖先集合非空的日志，不依赖当前组织目录候选。返回一份汇总，TopConsumers 为空数组。 网关版本不低于 3.9.8 时，所有支持维度的消费者组筛选统一为 ConsumerGroupId / ConsumerGroupName，均按历史归属查询；旧 OrganizationNodeId / OrganizationNodeName 筛选不再接受。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse> DescribeCloudNativeAPIGatewayLLMTokenUsageStatistics(DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageStatistics");
        }

        /// <summary>
        /// 查询 AI 网关 Token 用量汇总。网关版本不低于 3.9.8 且 Dimension=ConsumerGroup 时，按历史归属对日志并集去重统计；无节点筛选则查询全部成功归属且祖先集合非空的日志，不依赖当前组织目录候选。返回一份汇总，TopConsumers 为空数组。 网关版本不低于 3.9.8 时，所有支持维度的消费者组筛选统一为 ConsumerGroupId / ConsumerGroupName，均按历史归属查询；旧 OrganizationNodeId / OrganizationNodeName 筛选不再接受。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsSync(DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayLLMTokenUsageStatisticsResponse>(req, "DescribeCloudNativeAPIGatewayLLMTokenUsageStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPRouteListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPRouteListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPRouteListResponse> DescribeCloudNativeAPIGatewayMCPRouteList(DescribeCloudNativeAPIGatewayMCPRouteListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPRouteListResponse>(req, "DescribeCloudNativeAPIGatewayMCPRouteList");
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPRouteListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPRouteListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPRouteListResponse DescribeCloudNativeAPIGatewayMCPRouteListSync(DescribeCloudNativeAPIGatewayMCPRouteListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPRouteListResponse>(req, "DescribeCloudNativeAPIGatewayMCPRouteList")
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
        /// 查询批量导入MCP Tools的任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolImportTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolImportTaskResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPToolImportTaskResponse> DescribeCloudNativeAPIGatewayMCPToolImportTask(DescribeCloudNativeAPIGatewayMCPToolImportTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolImportTaskResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolImportTask");
        }

        /// <summary>
        /// 查询批量导入MCP Tools的任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolImportTaskRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolImportTaskResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPToolImportTaskResponse DescribeCloudNativeAPIGatewayMCPToolImportTaskSync(DescribeCloudNativeAPIGatewayMCPToolImportTaskRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolImportTaskResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolImportTask")
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
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPToolVersionResponse> DescribeCloudNativeAPIGatewayMCPToolVersion(DescribeCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolVersionResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolVersion");
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPToolVersionResponse DescribeCloudNativeAPIGatewayMCPToolVersionSync(DescribeCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolVersionResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPToolVersionListResponse> DescribeCloudNativeAPIGatewayMCPToolVersionList(DescribeCloudNativeAPIGatewayMCPToolVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolVersionListResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolVersionList");
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolVersionListResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPToolVersionListResponse DescribeCloudNativeAPIGatewayMCPToolVersionListSync(DescribeCloudNativeAPIGatewayMCPToolVersionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolVersionListResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从OpenAPI文件中解析出可导入的MCP tools
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolsFromFileRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolsFromFileResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayMCPToolsFromFileResponse> DescribeCloudNativeAPIGatewayMCPToolsFromFile(DescribeCloudNativeAPIGatewayMCPToolsFromFileRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolsFromFileResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolsFromFile");
        }

        /// <summary>
        /// 从OpenAPI文件中解析出可导入的MCP tools
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayMCPToolsFromFileRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayMCPToolsFromFileResponse"/></returns>
        public DescribeCloudNativeAPIGatewayMCPToolsFromFileResponse DescribeCloudNativeAPIGatewayMCPToolsFromFileSync(DescribeCloudNativeAPIGatewayMCPToolsFromFileRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayMCPToolsFromFileResponse>(req, "DescribeCloudNativeAPIGatewayMCPToolsFromFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询密钥详情（SecretValue 字段会被掩码）。
        /// 普通版批量新建密钥的生成来源扩展：新页面按需 IncludeCreationInfo=true，省略/false 保持原响应字段。原 GenerateType 不新增 Batch；批量记录仍为 System。协议：https://iwiki.woa.com/p/4042678235。
        /// 【消费者批量自动分配 API Key｜修改：可选参数及可选出参】增加可选 IncludeCreationInfo（默认 false）。仅 true 且 ResourceType=Consumer 时在原 Result 增加 CredentialGenerateType、CreationSource、BatchId 三个非必返字段；省略/false 保持旧响应。原字段、SecretValue 脱敏和单条详情结构不变。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewaySecretKeyResponse> DescribeCloudNativeAPIGatewaySecretKey(DescribeCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyResponse>(req, "DescribeCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 查询密钥详情（SecretValue 字段会被掩码）。
        /// 普通版批量新建密钥的生成来源扩展：新页面按需 IncludeCreationInfo=true，省略/false 保持原响应字段。原 GenerateType 不新增 Batch；批量记录仍为 System。协议：https://iwiki.woa.com/p/4042678235。
        /// 【消费者批量自动分配 API Key｜修改：可选参数及可选出参】增加可选 IncludeCreationInfo（默认 false）。仅 true 且 ResourceType=Consumer 时在原 Result 增加 CredentialGenerateType、CreationSource、BatchId 三个非必返字段；省略/false 保持旧响应。原字段、SecretValue 脱敏和单条详情结构不变。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public DescribeCloudNativeAPIGatewaySecretKeyResponse DescribeCloudNativeAPIGatewaySecretKeySync(DescribeCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyResponse>(req, "DescribeCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询密钥列表。
        /// 普通版批量新建密钥的生成来源扩展：新页面按需 IncludeCreationInfo=true，省略/false 保持原响应字段。原 GenerateType 不新增 Batch；批量记录仍为 System。协议：https://iwiki.woa.com/p/4042678235。
        /// 【消费者批量自动分配 API Key｜修改：可选参数、可选出参及筛选】增加可选 IncludeCreationInfo（默认 false）。仅 true 且 ResourceType=Consumer 时在原 Result.SecretKeys[] 增加 CredentialGenerateType、CreationSource、BatchId 三个非必返字段；Result.TotalCount/SecretKeys 结构不变。Filters 新增 CredentialGenerateType、CreationSource，先过滤后计数分页，与是否返回来源字段独立；保留原 GenerateType 枚举和原分页上限。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyListResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewaySecretKeyListResponse> DescribeCloudNativeAPIGatewaySecretKeyList(DescribeCloudNativeAPIGatewaySecretKeyListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyListResponse>(req, "DescribeCloudNativeAPIGatewaySecretKeyList");
        }

        /// <summary>
        /// 查询密钥列表。
        /// 普通版批量新建密钥的生成来源扩展：新页面按需 IncludeCreationInfo=true，省略/false 保持原响应字段。原 GenerateType 不新增 Batch；批量记录仍为 System。协议：https://iwiki.woa.com/p/4042678235。
        /// 【消费者批量自动分配 API Key｜修改：可选参数、可选出参及筛选】增加可选 IncludeCreationInfo（默认 false）。仅 true 且 ResourceType=Consumer 时在原 Result.SecretKeys[] 增加 CredentialGenerateType、CreationSource、BatchId 三个非必返字段；Result.TotalCount/SecretKeys 结构不变。Filters 新增 CredentialGenerateType、CreationSource，先过滤后计数分页，与是否返回来源字段独立；保留原 GenerateType 枚举和原分页上限。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaySecretKeyListRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaySecretKeyListResponse"/></returns>
        public DescribeCloudNativeAPIGatewaySecretKeyListResponse DescribeCloudNativeAPIGatewaySecretKeyListSync(DescribeCloudNativeAPIGatewaySecretKeyListRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaySecretKeyListResponse>(req, "DescribeCloudNativeAPIGatewaySecretKeyList")
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
        /// 修改云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayAIServiceSourceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayAIServiceSourceResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayAIServiceSourceResponse> ModifyCloudNativeAPIGatewayAIServiceSource(ModifyCloudNativeAPIGatewayAIServiceSourceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayAIServiceSourceResponse>(req, "ModifyCloudNativeAPIGatewayAIServiceSource");
        }

        /// <summary>
        /// 修改云原生网关AI服务来源
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayAIServiceSourceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayAIServiceSourceResponse"/></returns>
        public ModifyCloudNativeAPIGatewayAIServiceSourceResponse ModifyCloudNativeAPIGatewayAIServiceSourceSync(ModifyCloudNativeAPIGatewayAIServiceSourceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayAIServiceSourceResponse>(req, "ModifyCloudNativeAPIGatewayAIServiceSource")
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
        /// 更新指定网关实例内的 LLM 模型服务，可调整该服务向上游请求压缩响应的协商方式。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayLLMModelServiceResponse> ModifyCloudNativeAPIGatewayLLMModelService(ModifyCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayLLMModelServiceResponse>(req, "ModifyCloudNativeAPIGatewayLLMModelService");
        }

        /// <summary>
        /// 更新指定网关实例内的 LLM 模型服务，可调整该服务向上游请求压缩响应的协商方式。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayLLMModelServiceResponse"/></returns>
        public ModifyCloudNativeAPIGatewayLLMModelServiceResponse ModifyCloudNativeAPIGatewayLLMModelServiceSync(ModifyCloudNativeAPIGatewayLLMModelServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayLLMModelServiceResponse>(req, "ModifyCloudNativeAPIGatewayLLMModelService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPRouteResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPRouteResponse> ModifyCloudNativeAPIGatewayMCPRoute(ModifyCloudNativeAPIGatewayMCPRouteRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPRouteResponse>(req, "ModifyCloudNativeAPIGatewayMCPRoute");
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPRouteResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPRouteResponse ModifyCloudNativeAPIGatewayMCPRouteSync(ModifyCloudNativeAPIGatewayMCPRouteRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPRouteResponse>(req, "ModifyCloudNativeAPIGatewayMCPRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPRouteStatusRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPRouteStatusResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayMCPRouteStatusResponse> ModifyCloudNativeAPIGatewayMCPRouteStatus(ModifyCloudNativeAPIGatewayMCPRouteStatusRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPRouteStatusResponse>(req, "ModifyCloudNativeAPIGatewayMCPRouteStatus");
        }

        /// <summary>
        /// 上传插件前置操作，获取COS相关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayMCPRouteStatusRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayMCPRouteStatusResponse"/></returns>
        public ModifyCloudNativeAPIGatewayMCPRouteStatusResponse ModifyCloudNativeAPIGatewayMCPRouteStatusSync(ModifyCloudNativeAPIGatewayMCPRouteStatusRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayMCPRouteStatusResponse>(req, "ModifyCloudNativeAPIGatewayMCPRouteStatus")
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
        /// 【消费者批量自动分配 API Key｜修改：新增未完成批次保护，字段不变】目标密钥属于批次且对应项处于 Pending/Running/Reconciling 时，编辑返回 OperationDenied.BatchKeyPending，提示等待批次完成。其他情况继续原编辑校验和行为；原 GatewayId/SecretKeyId/Name/Description 不变，成功不新增业务 Result。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewaySecretKeyResponse> ModifyCloudNativeAPIGatewaySecretKey(ModifyCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewaySecretKeyResponse>(req, "ModifyCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 修改AI网关密钥
        /// 【消费者批量自动分配 API Key｜修改：新增未完成批次保护，字段不变】目标密钥属于批次且对应项处于 Pending/Running/Reconciling 时，编辑返回 OperationDenied.BatchKeyPending，提示等待批次完成。其他情况继续原编辑校验和行为；原 GatewayId/SecretKeyId/Name/Description 不变，成功不新增业务 Result。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
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
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="RollbackCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="RollbackCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public Task<RollbackCloudNativeAPIGatewayMCPToolVersionResponse> RollbackCloudNativeAPIGatewayMCPToolVersion(RollbackCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<RollbackCloudNativeAPIGatewayMCPToolVersionResponse>(req, "RollbackCloudNativeAPIGatewayMCPToolVersion");
        }

        /// <summary>
        /// 修改云原生智能网关MCP Tool
        /// </summary>
        /// <param name="req"><see cref="RollbackCloudNativeAPIGatewayMCPToolVersionRequest"/></param>
        /// <returns><see cref="RollbackCloudNativeAPIGatewayMCPToolVersionResponse"/></returns>
        public RollbackCloudNativeAPIGatewayMCPToolVersionResponse RollbackCloudNativeAPIGatewayMCPToolVersionSync(RollbackCloudNativeAPIGatewayMCPToolVersionRequest req)
        {
            return InternalRequestAsync<RollbackCloudNativeAPIGatewayMCPToolVersionResponse>(req, "RollbackCloudNativeAPIGatewayMCPToolVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑密钥
        /// 【消费者批量自动分配 API Key｜修改：新增未完成批次保护，字段不变】目标密钥属于批次且对应项处于 Pending/Running/Reconciling 时，解绑返回 OperationDenied.BatchKeyPending。完成后继续原解绑；原 GatewayId/SecretKeyId/ResourceType/ResourceIds 不变，成功不新增业务 Result。解绑不改写批次历史成功，后续批次明文读取返回逐项 OperationDenied.BindingChanged。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="UnbindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public Task<UnbindCloudNativeAPIGatewaySecretKeyResponse> UnbindCloudNativeAPIGatewaySecretKey(UnbindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<UnbindCloudNativeAPIGatewaySecretKeyResponse>(req, "UnbindCloudNativeAPIGatewaySecretKey");
        }

        /// <summary>
        /// 解绑密钥
        /// 【消费者批量自动分配 API Key｜修改：新增未完成批次保护，字段不变】目标密钥属于批次且对应项处于 Pending/Running/Reconciling 时，解绑返回 OperationDenied.BatchKeyPending。完成后继续原解绑；原 GatewayId/SecretKeyId/ResourceType/ResourceIds 不变，成功不新增业务 Result。解绑不改写批次历史成功，后续批次明文读取返回逐项 OperationDenied.BindingChanged。 完整接口清单与逐项说明：https://iwiki.woa.com/p/4042678235（第 2、2.4 节）。
        /// </summary>
        /// <param name="req"><see cref="UnbindCloudNativeAPIGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="UnbindCloudNativeAPIGatewaySecretKeyResponse"/></returns>
        public UnbindCloudNativeAPIGatewaySecretKeyResponse UnbindCloudNativeAPIGatewaySecretKeySync(UnbindCloudNativeAPIGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<UnbindCloudNativeAPIGatewaySecretKeyResponse>(req, "UnbindCloudNativeAPIGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量导入从OpenAPI文件中解析的MCP Tools
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewayMCPToolsRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewayMCPToolsResponse"/></returns>
        public Task<UpdateCloudNativeAPIGatewayMCPToolsResponse> UpdateCloudNativeAPIGatewayMCPTools(UpdateCloudNativeAPIGatewayMCPToolsRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewayMCPToolsResponse>(req, "UpdateCloudNativeAPIGatewayMCPTools");
        }

        /// <summary>
        /// 批量导入从OpenAPI文件中解析的MCP Tools
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewayMCPToolsRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewayMCPToolsResponse"/></returns>
        public UpdateCloudNativeAPIGatewayMCPToolsResponse UpdateCloudNativeAPIGatewayMCPToolsSync(UpdateCloudNativeAPIGatewayMCPToolsRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewayMCPToolsResponse>(req, "UpdateCloudNativeAPIGatewayMCPTools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
