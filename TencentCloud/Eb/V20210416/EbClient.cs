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

namespace TencentCloud.Eb.V20210416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eb.V20210416.Models;

   public class EbClient : AbstractClient{

       private const string endpoint = "eb.tencentcloudapi.com";
       private const string version = "2021-04-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 检验规则
        /// </summary>
        /// <param name="req"><see cref="CheckRuleRequest"/></param>
        /// <returns><see cref="CheckRuleResponse"/></returns>
        public async Task<CheckRuleResponse> CheckRule(CheckRuleRequest req)
        {
             JsonResponseModel<CheckRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检验规则
        /// </summary>
        /// <param name="req"><see cref="CheckRuleRequest"/></param>
        /// <returns><see cref="CheckRuleResponse"/></returns>
        public CheckRuleResponse CheckRuleSync(CheckRuleRequest req)
        {
             JsonResponseModel<CheckRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在ETL配置页面, 测试规则和数据.
        /// </summary>
        /// <param name="req"><see cref="CheckTransformationRequest"/></param>
        /// <returns><see cref="CheckTransformationResponse"/></returns>
        public async Task<CheckTransformationResponse> CheckTransformation(CheckTransformationRequest req)
        {
             JsonResponseModel<CheckTransformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在ETL配置页面, 测试规则和数据.
        /// </summary>
        /// <param name="req"><see cref="CheckTransformationRequest"/></param>
        /// <returns><see cref="CheckTransformationResponse"/></returns>
        public CheckTransformationResponse CheckTransformationSync(CheckTransformationRequest req)
        {
             JsonResponseModel<CheckTransformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建事件连接器
        /// </summary>
        /// <param name="req"><see cref="CreateConnectionRequest"/></param>
        /// <returns><see cref="CreateConnectionResponse"/></returns>
        public async Task<CreateConnectionResponse> CreateConnection(CreateConnectionRequest req)
        {
             JsonResponseModel<CreateConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建事件连接器
        /// </summary>
        /// <param name="req"><see cref="CreateConnectionRequest"/></param>
        /// <returns><see cref="CreateConnectionResponse"/></returns>
        public CreateConnectionResponse CreateConnectionSync(CreateConnectionRequest req)
        {
             JsonResponseModel<CreateConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建事件集
        /// </summary>
        /// <param name="req"><see cref="CreateEventBusRequest"/></param>
        /// <returns><see cref="CreateEventBusResponse"/></returns>
        public async Task<CreateEventBusResponse> CreateEventBus(CreateEventBusRequest req)
        {
             JsonResponseModel<CreateEventBusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建事件集
        /// </summary>
        /// <param name="req"><see cref="CreateEventBusRequest"/></param>
        /// <returns><see cref="CreateEventBusResponse"/></returns>
        public CreateEventBusResponse CreateEventBusSync(CreateEventBusRequest req)
        {
             JsonResponseModel<CreateEventBusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建事件规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建事件规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建事件目标
        /// </summary>
        /// <param name="req"><see cref="CreateTargetRequest"/></param>
        /// <returns><see cref="CreateTargetResponse"/></returns>
        public async Task<CreateTargetResponse> CreateTarget(CreateTargetRequest req)
        {
             JsonResponseModel<CreateTargetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建事件目标
        /// </summary>
        /// <param name="req"><see cref="CreateTargetRequest"/></param>
        /// <returns><see cref="CreateTargetResponse"/></returns>
        public CreateTargetResponse CreateTargetSync(CreateTargetRequest req)
        {
             JsonResponseModel<CreateTargetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建转换器
        /// </summary>
        /// <param name="req"><see cref="CreateTransformationRequest"/></param>
        /// <returns><see cref="CreateTransformationResponse"/></returns>
        public async Task<CreateTransformationResponse> CreateTransformation(CreateTransformationRequest req)
        {
             JsonResponseModel<CreateTransformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建转换器
        /// </summary>
        /// <param name="req"><see cref="CreateTransformationRequest"/></param>
        /// <returns><see cref="CreateTransformationResponse"/></returns>
        public CreateTransformationResponse CreateTransformationSync(CreateTransformationRequest req)
        {
             JsonResponseModel<CreateTransformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件连接器
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectionRequest"/></param>
        /// <returns><see cref="DeleteConnectionResponse"/></returns>
        public async Task<DeleteConnectionResponse> DeleteConnection(DeleteConnectionRequest req)
        {
             JsonResponseModel<DeleteConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件连接器
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectionRequest"/></param>
        /// <returns><see cref="DeleteConnectionResponse"/></returns>
        public DeleteConnectionResponse DeleteConnectionSync(DeleteConnectionRequest req)
        {
             JsonResponseModel<DeleteConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件集
        /// </summary>
        /// <param name="req"><see cref="DeleteEventBusRequest"/></param>
        /// <returns><see cref="DeleteEventBusResponse"/></returns>
        public async Task<DeleteEventBusResponse> DeleteEventBus(DeleteEventBusRequest req)
        {
             JsonResponseModel<DeleteEventBusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件集
        /// </summary>
        /// <param name="req"><see cref="DeleteEventBusRequest"/></param>
        /// <returns><see cref="DeleteEventBusResponse"/></returns>
        public DeleteEventBusResponse DeleteEventBusSync(DeleteEventBusRequest req)
        {
             JsonResponseModel<DeleteEventBusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件目标
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetRequest"/></param>
        /// <returns><see cref="DeleteTargetResponse"/></returns>
        public async Task<DeleteTargetResponse> DeleteTarget(DeleteTargetRequest req)
        {
             JsonResponseModel<DeleteTargetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除事件目标
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetRequest"/></param>
        /// <returns><see cref="DeleteTargetResponse"/></returns>
        public DeleteTargetResponse DeleteTargetSync(DeleteTargetRequest req)
        {
             JsonResponseModel<DeleteTargetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除转换器
        /// </summary>
        /// <param name="req"><see cref="DeleteTransformationRequest"/></param>
        /// <returns><see cref="DeleteTransformationResponse"/></returns>
        public async Task<DeleteTransformationResponse> DeleteTransformation(DeleteTransformationRequest req)
        {
             JsonResponseModel<DeleteTransformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除转换器
        /// </summary>
        /// <param name="req"><see cref="DeleteTransformationRequest"/></param>
        /// <returns><see cref="DeleteTransformationResponse"/></returns>
        public DeleteTransformationResponse DeleteTransformationSync(DeleteTransformationRequest req)
        {
             JsonResponseModel<DeleteTransformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询日志索引维度值
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTagValueRequest"/></param>
        /// <returns><see cref="DescribeLogTagValueResponse"/></returns>
        public async Task<DescribeLogTagValueResponse> DescribeLogTagValue(DescribeLogTagValueRequest req)
        {
             JsonResponseModel<DescribeLogTagValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询日志索引维度值
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTagValueRequest"/></param>
        /// <returns><see cref="DescribeLogTagValueResponse"/></returns>
        public DescribeLogTagValueResponse DescribeLogTagValueSync(DescribeLogTagValueRequest req)
        {
             JsonResponseModel<DescribeLogTagValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件集详情
        /// </summary>
        /// <param name="req"><see cref="GetEventBusRequest"/></param>
        /// <returns><see cref="GetEventBusResponse"/></returns>
        public async Task<GetEventBusResponse> GetEventBus(GetEventBusRequest req)
        {
             JsonResponseModel<GetEventBusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件集详情
        /// </summary>
        /// <param name="req"><see cref="GetEventBusRequest"/></param>
        /// <returns><see cref="GetEventBusResponse"/></returns>
        public GetEventBusResponse GetEventBusSync(GetEventBusRequest req)
        {
             JsonResponseModel<GetEventBusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品事件模板
        /// </summary>
        /// <param name="req"><see cref="GetPlatformEventTemplateRequest"/></param>
        /// <returns><see cref="GetPlatformEventTemplateResponse"/></returns>
        public async Task<GetPlatformEventTemplateResponse> GetPlatformEventTemplate(GetPlatformEventTemplateRequest req)
        {
             JsonResponseModel<GetPlatformEventTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPlatformEventTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPlatformEventTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品事件模板
        /// </summary>
        /// <param name="req"><see cref="GetPlatformEventTemplateRequest"/></param>
        /// <returns><see cref="GetPlatformEventTemplateResponse"/></returns>
        public GetPlatformEventTemplateResponse GetPlatformEventTemplateSync(GetPlatformEventTemplateRequest req)
        {
             JsonResponseModel<GetPlatformEventTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPlatformEventTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPlatformEventTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件规则详情
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public async Task<GetRuleResponse> GetRule(GetRuleRequest req)
        {
             JsonResponseModel<GetRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件规则详情
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public GetRuleResponse GetRuleSync(GetRuleRequest req)
        {
             JsonResponseModel<GetRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取转换器详情
        /// </summary>
        /// <param name="req"><see cref="GetTransformationRequest"/></param>
        /// <returns><see cref="GetTransformationResponse"/></returns>
        public async Task<GetTransformationResponse> GetTransformation(GetTransformationRequest req)
        {
             JsonResponseModel<GetTransformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取转换器详情
        /// </summary>
        /// <param name="req"><see cref="GetTransformationRequest"/></param>
        /// <returns><see cref="GetTransformationResponse"/></returns>
        public GetTransformationResponse GetTransformationSync(GetTransformationRequest req)
        {
             JsonResponseModel<GetTransformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListConnectionsRequest"/></param>
        /// <returns><see cref="ListConnectionsResponse"/></returns>
        public async Task<ListConnectionsResponse> ListConnections(ListConnectionsRequest req)
        {
             JsonResponseModel<ListConnectionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListConnectionsRequest"/></param>
        /// <returns><see cref="ListConnectionsResponse"/></returns>
        public ListConnectionsResponse ListConnectionsSync(ListConnectionsRequest req)
        {
             JsonResponseModel<ListConnectionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件集列表
        /// </summary>
        /// <param name="req"><see cref="ListEventBusesRequest"/></param>
        /// <returns><see cref="ListEventBusesResponse"/></returns>
        public async Task<ListEventBusesResponse> ListEventBuses(ListEventBusesRequest req)
        {
             JsonResponseModel<ListEventBusesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEventBuses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEventBusesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件集列表
        /// </summary>
        /// <param name="req"><see cref="ListEventBusesRequest"/></param>
        /// <returns><see cref="ListEventBusesResponse"/></returns>
        public ListEventBusesResponse ListEventBusesSync(ListEventBusesRequest req)
        {
             JsonResponseModel<ListEventBusesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEventBuses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEventBusesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品事件名称
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventNamesRequest"/></param>
        /// <returns><see cref="ListPlatformEventNamesResponse"/></returns>
        public async Task<ListPlatformEventNamesResponse> ListPlatformEventNames(ListPlatformEventNamesRequest req)
        {
             JsonResponseModel<ListPlatformEventNamesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListPlatformEventNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPlatformEventNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品事件名称
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventNamesRequest"/></param>
        /// <returns><see cref="ListPlatformEventNamesResponse"/></returns>
        public ListPlatformEventNamesResponse ListPlatformEventNamesSync(ListPlatformEventNamesRequest req)
        {
             JsonResponseModel<ListPlatformEventNamesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListPlatformEventNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPlatformEventNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品事件匹配规则
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventPatternsRequest"/></param>
        /// <returns><see cref="ListPlatformEventPatternsResponse"/></returns>
        public async Task<ListPlatformEventPatternsResponse> ListPlatformEventPatterns(ListPlatformEventPatternsRequest req)
        {
             JsonResponseModel<ListPlatformEventPatternsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListPlatformEventPatterns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPlatformEventPatternsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品事件匹配规则
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventPatternsRequest"/></param>
        /// <returns><see cref="ListPlatformEventPatternsResponse"/></returns>
        public ListPlatformEventPatternsResponse ListPlatformEventPatternsSync(ListPlatformEventPatternsRequest req)
        {
             JsonResponseModel<ListPlatformEventPatternsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListPlatformEventPatterns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPlatformEventPatternsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品列表
        /// </summary>
        /// <param name="req"><see cref="ListPlatformProductsRequest"/></param>
        /// <returns><see cref="ListPlatformProductsResponse"/></returns>
        public async Task<ListPlatformProductsResponse> ListPlatformProducts(ListPlatformProductsRequest req)
        {
             JsonResponseModel<ListPlatformProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListPlatformProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPlatformProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台产品列表
        /// </summary>
        /// <param name="req"><see cref="ListPlatformProductsRequest"/></param>
        /// <returns><see cref="ListPlatformProductsResponse"/></returns>
        public ListPlatformProductsResponse ListPlatformProductsSync(ListPlatformProductsRequest req)
        {
             JsonResponseModel<ListPlatformProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListPlatformProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListPlatformProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件规则列表
        /// </summary>
        /// <param name="req"><see cref="ListRulesRequest"/></param>
        /// <returns><see cref="ListRulesResponse"/></returns>
        public async Task<ListRulesResponse> ListRules(ListRulesRequest req)
        {
             JsonResponseModel<ListRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件规则列表
        /// </summary>
        /// <param name="req"><see cref="ListRulesRequest"/></param>
        /// <returns><see cref="ListRulesResponse"/></returns>
        public ListRulesResponse ListRulesSync(ListRulesRequest req)
        {
             JsonResponseModel<ListRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件目标列表
        /// </summary>
        /// <param name="req"><see cref="ListTargetsRequest"/></param>
        /// <returns><see cref="ListTargetsResponse"/></returns>
        public async Task<ListTargetsResponse> ListTargets(ListTargetsRequest req)
        {
             JsonResponseModel<ListTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件目标列表
        /// </summary>
        /// <param name="req"><see cref="ListTargetsRequest"/></param>
        /// <returns><see cref="ListTargetsResponse"/></returns>
        public ListTargetsResponse ListTargetsSync(ListTargetsRequest req)
        {
             JsonResponseModel<ListTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// （已废弃）用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PublishEventRequest"/></param>
        /// <returns><see cref="PublishEventResponse"/></returns>
        public async Task<PublishEventResponse> PublishEvent(PublishEventRequest req)
        {
             JsonResponseModel<PublishEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// （已废弃）用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PublishEventRequest"/></param>
        /// <returns><see cref="PublishEventResponse"/></returns>
        public PublishEventResponse PublishEventSync(PublishEventRequest req)
        {
             JsonResponseModel<PublishEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PutEventsRequest"/></param>
        /// <returns><see cref="PutEventsResponse"/></returns>
        public async Task<PutEventsResponse> PutEvents(PutEventsRequest req)
        {
             JsonResponseModel<PutEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PutEventsRequest"/></param>
        /// <returns><see cref="PutEventsResponse"/></returns>
        public PutEventsResponse PutEventsSync(PutEventsRequest req)
        {
             JsonResponseModel<PutEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志检索
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public async Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志检索
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件连接器
        /// </summary>
        /// <param name="req"><see cref="UpdateConnectionRequest"/></param>
        /// <returns><see cref="UpdateConnectionResponse"/></returns>
        public async Task<UpdateConnectionResponse> UpdateConnection(UpdateConnectionRequest req)
        {
             JsonResponseModel<UpdateConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件连接器
        /// </summary>
        /// <param name="req"><see cref="UpdateConnectionRequest"/></param>
        /// <returns><see cref="UpdateConnectionResponse"/></returns>
        public UpdateConnectionResponse UpdateConnectionSync(UpdateConnectionRequest req)
        {
             JsonResponseModel<UpdateConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件集
        /// </summary>
        /// <param name="req"><see cref="UpdateEventBusRequest"/></param>
        /// <returns><see cref="UpdateEventBusResponse"/></returns>
        public async Task<UpdateEventBusResponse> UpdateEventBus(UpdateEventBusRequest req)
        {
             JsonResponseModel<UpdateEventBusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件集
        /// </summary>
        /// <param name="req"><see cref="UpdateEventBusRequest"/></param>
        /// <returns><see cref="UpdateEventBusResponse"/></returns>
        public UpdateEventBusResponse UpdateEventBusSync(UpdateEventBusRequest req)
        {
             JsonResponseModel<UpdateEventBusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEventBus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEventBusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public async Task<UpdateRuleResponse> UpdateRule(UpdateRuleRequest req)
        {
             JsonResponseModel<UpdateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public UpdateRuleResponse UpdateRuleSync(UpdateRuleRequest req)
        {
             JsonResponseModel<UpdateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件目标
        /// </summary>
        /// <param name="req"><see cref="UpdateTargetRequest"/></param>
        /// <returns><see cref="UpdateTargetResponse"/></returns>
        public async Task<UpdateTargetResponse> UpdateTarget(UpdateTargetRequest req)
        {
             JsonResponseModel<UpdateTargetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新事件目标
        /// </summary>
        /// <param name="req"><see cref="UpdateTargetRequest"/></param>
        /// <returns><see cref="UpdateTargetResponse"/></returns>
        public UpdateTargetResponse UpdateTargetSync(UpdateTargetRequest req)
        {
             JsonResponseModel<UpdateTargetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新转换器
        /// </summary>
        /// <param name="req"><see cref="UpdateTransformationRequest"/></param>
        /// <returns><see cref="UpdateTransformationResponse"/></returns>
        public async Task<UpdateTransformationResponse> UpdateTransformation(UpdateTransformationRequest req)
        {
             JsonResponseModel<UpdateTransformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于更新转换器
        /// </summary>
        /// <param name="req"><see cref="UpdateTransformationRequest"/></param>
        /// <returns><see cref="UpdateTransformationResponse"/></returns>
        public UpdateTransformationResponse UpdateTransformationSync(UpdateTransformationRequest req)
        {
             JsonResponseModel<UpdateTransformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateTransformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTransformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
