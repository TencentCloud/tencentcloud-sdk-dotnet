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
       private const string sdkVersion = "SDK_NET_3.0.1174";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 检验规则
        /// </summary>
        /// <param name="req"><see cref="CheckRuleRequest"/></param>
        /// <returns><see cref="CheckRuleResponse"/></returns>
        public Task<CheckRuleResponse> CheckRule(CheckRuleRequest req)
        {
            return InternalRequestAsync<CheckRuleResponse>(req, "CheckRule");
        }

        /// <summary>
        /// 检验规则
        /// </summary>
        /// <param name="req"><see cref="CheckRuleRequest"/></param>
        /// <returns><see cref="CheckRuleResponse"/></returns>
        public CheckRuleResponse CheckRuleSync(CheckRuleRequest req)
        {
            return InternalRequestAsync<CheckRuleResponse>(req, "CheckRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在ETL配置页面, 测试规则和数据.
        /// </summary>
        /// <param name="req"><see cref="CheckTransformationRequest"/></param>
        /// <returns><see cref="CheckTransformationResponse"/></returns>
        public Task<CheckTransformationResponse> CheckTransformation(CheckTransformationRequest req)
        {
            return InternalRequestAsync<CheckTransformationResponse>(req, "CheckTransformation");
        }

        /// <summary>
        /// 用于在ETL配置页面, 测试规则和数据.
        /// </summary>
        /// <param name="req"><see cref="CheckTransformationRequest"/></param>
        /// <returns><see cref="CheckTransformationResponse"/></returns>
        public CheckTransformationResponse CheckTransformationSync(CheckTransformationRequest req)
        {
            return InternalRequestAsync<CheckTransformationResponse>(req, "CheckTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建事件连接器
        /// </summary>
        /// <param name="req"><see cref="CreateConnectionRequest"/></param>
        /// <returns><see cref="CreateConnectionResponse"/></returns>
        public Task<CreateConnectionResponse> CreateConnection(CreateConnectionRequest req)
        {
            return InternalRequestAsync<CreateConnectionResponse>(req, "CreateConnection");
        }

        /// <summary>
        /// 创建事件连接器
        /// </summary>
        /// <param name="req"><see cref="CreateConnectionRequest"/></param>
        /// <returns><see cref="CreateConnectionResponse"/></returns>
        public CreateConnectionResponse CreateConnectionSync(CreateConnectionRequest req)
        {
            return InternalRequestAsync<CreateConnectionResponse>(req, "CreateConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建事件集
        /// </summary>
        /// <param name="req"><see cref="CreateEventBusRequest"/></param>
        /// <returns><see cref="CreateEventBusResponse"/></returns>
        public Task<CreateEventBusResponse> CreateEventBus(CreateEventBusRequest req)
        {
            return InternalRequestAsync<CreateEventBusResponse>(req, "CreateEventBus");
        }

        /// <summary>
        /// 用于创建事件集
        /// </summary>
        /// <param name="req"><see cref="CreateEventBusRequest"/></param>
        /// <returns><see cref="CreateEventBusResponse"/></returns>
        public CreateEventBusResponse CreateEventBusSync(CreateEventBusRequest req)
        {
            return InternalRequestAsync<CreateEventBusResponse>(req, "CreateEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建事件规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// 创建事件规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建事件目标
        /// </summary>
        /// <param name="req"><see cref="CreateTargetRequest"/></param>
        /// <returns><see cref="CreateTargetResponse"/></returns>
        public Task<CreateTargetResponse> CreateTarget(CreateTargetRequest req)
        {
            return InternalRequestAsync<CreateTargetResponse>(req, "CreateTarget");
        }

        /// <summary>
        /// 创建事件目标
        /// </summary>
        /// <param name="req"><see cref="CreateTargetRequest"/></param>
        /// <returns><see cref="CreateTargetResponse"/></returns>
        public CreateTargetResponse CreateTargetSync(CreateTargetRequest req)
        {
            return InternalRequestAsync<CreateTargetResponse>(req, "CreateTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建转换器
        /// </summary>
        /// <param name="req"><see cref="CreateTransformationRequest"/></param>
        /// <returns><see cref="CreateTransformationResponse"/></returns>
        public Task<CreateTransformationResponse> CreateTransformation(CreateTransformationRequest req)
        {
            return InternalRequestAsync<CreateTransformationResponse>(req, "CreateTransformation");
        }

        /// <summary>
        /// 用于创建转换器
        /// </summary>
        /// <param name="req"><see cref="CreateTransformationRequest"/></param>
        /// <returns><see cref="CreateTransformationResponse"/></returns>
        public CreateTransformationResponse CreateTransformationSync(CreateTransformationRequest req)
        {
            return InternalRequestAsync<CreateTransformationResponse>(req, "CreateTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除事件连接器
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectionRequest"/></param>
        /// <returns><see cref="DeleteConnectionResponse"/></returns>
        public Task<DeleteConnectionResponse> DeleteConnection(DeleteConnectionRequest req)
        {
            return InternalRequestAsync<DeleteConnectionResponse>(req, "DeleteConnection");
        }

        /// <summary>
        /// 删除事件连接器
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectionRequest"/></param>
        /// <returns><see cref="DeleteConnectionResponse"/></returns>
        public DeleteConnectionResponse DeleteConnectionSync(DeleteConnectionRequest req)
        {
            return InternalRequestAsync<DeleteConnectionResponse>(req, "DeleteConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除事件集
        /// </summary>
        /// <param name="req"><see cref="DeleteEventBusRequest"/></param>
        /// <returns><see cref="DeleteEventBusResponse"/></returns>
        public Task<DeleteEventBusResponse> DeleteEventBus(DeleteEventBusRequest req)
        {
            return InternalRequestAsync<DeleteEventBusResponse>(req, "DeleteEventBus");
        }

        /// <summary>
        /// 删除事件集
        /// </summary>
        /// <param name="req"><see cref="DeleteEventBusRequest"/></param>
        /// <returns><see cref="DeleteEventBusResponse"/></returns>
        public DeleteEventBusResponse DeleteEventBusSync(DeleteEventBusRequest req)
        {
            return InternalRequestAsync<DeleteEventBusResponse>(req, "DeleteEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除事件规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// 删除事件规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除事件目标
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetRequest"/></param>
        /// <returns><see cref="DeleteTargetResponse"/></returns>
        public Task<DeleteTargetResponse> DeleteTarget(DeleteTargetRequest req)
        {
            return InternalRequestAsync<DeleteTargetResponse>(req, "DeleteTarget");
        }

        /// <summary>
        /// 删除事件目标
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetRequest"/></param>
        /// <returns><see cref="DeleteTargetResponse"/></returns>
        public DeleteTargetResponse DeleteTargetSync(DeleteTargetRequest req)
        {
            return InternalRequestAsync<DeleteTargetResponse>(req, "DeleteTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除转换器
        /// </summary>
        /// <param name="req"><see cref="DeleteTransformationRequest"/></param>
        /// <returns><see cref="DeleteTransformationResponse"/></returns>
        public Task<DeleteTransformationResponse> DeleteTransformation(DeleteTransformationRequest req)
        {
            return InternalRequestAsync<DeleteTransformationResponse>(req, "DeleteTransformation");
        }

        /// <summary>
        /// 用于删除转换器
        /// </summary>
        /// <param name="req"><see cref="DeleteTransformationRequest"/></param>
        /// <returns><see cref="DeleteTransformationResponse"/></returns>
        public DeleteTransformationResponse DeleteTransformationSync(DeleteTransformationRequest req)
        {
            return InternalRequestAsync<DeleteTransformationResponse>(req, "DeleteTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 前置条件：需开启事件存储；事件查询维度值
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTagValueRequest"/></param>
        /// <returns><see cref="DescribeLogTagValueResponse"/></returns>
        public Task<DescribeLogTagValueResponse> DescribeLogTagValue(DescribeLogTagValueRequest req)
        {
            return InternalRequestAsync<DescribeLogTagValueResponse>(req, "DescribeLogTagValue");
        }

        /// <summary>
        /// 前置条件：需开启事件存储；事件查询维度值
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTagValueRequest"/></param>
        /// <returns><see cref="DescribeLogTagValueResponse"/></returns>
        public DescribeLogTagValueResponse DescribeLogTagValueSync(DescribeLogTagValueRequest req)
        {
            return InternalRequestAsync<DescribeLogTagValueResponse>(req, "DescribeLogTagValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取事件集详情
        /// </summary>
        /// <param name="req"><see cref="GetEventBusRequest"/></param>
        /// <returns><see cref="GetEventBusResponse"/></returns>
        public Task<GetEventBusResponse> GetEventBus(GetEventBusRequest req)
        {
            return InternalRequestAsync<GetEventBusResponse>(req, "GetEventBus");
        }

        /// <summary>
        /// 获取事件集详情
        /// </summary>
        /// <param name="req"><see cref="GetEventBusRequest"/></param>
        /// <returns><see cref="GetEventBusResponse"/></returns>
        public GetEventBusResponse GetEventBusSync(GetEventBusRequest req)
        {
            return InternalRequestAsync<GetEventBusResponse>(req, "GetEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取平台产品事件模板
        /// </summary>
        /// <param name="req"><see cref="GetPlatformEventTemplateRequest"/></param>
        /// <returns><see cref="GetPlatformEventTemplateResponse"/></returns>
        public Task<GetPlatformEventTemplateResponse> GetPlatformEventTemplate(GetPlatformEventTemplateRequest req)
        {
            return InternalRequestAsync<GetPlatformEventTemplateResponse>(req, "GetPlatformEventTemplate");
        }

        /// <summary>
        /// 获取平台产品事件模板
        /// </summary>
        /// <param name="req"><see cref="GetPlatformEventTemplateRequest"/></param>
        /// <returns><see cref="GetPlatformEventTemplateResponse"/></returns>
        public GetPlatformEventTemplateResponse GetPlatformEventTemplateSync(GetPlatformEventTemplateRequest req)
        {
            return InternalRequestAsync<GetPlatformEventTemplateResponse>(req, "GetPlatformEventTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取事件规则详情
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public Task<GetRuleResponse> GetRule(GetRuleRequest req)
        {
            return InternalRequestAsync<GetRuleResponse>(req, "GetRule");
        }

        /// <summary>
        /// 获取事件规则详情
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public GetRuleResponse GetRuleSync(GetRuleRequest req)
        {
            return InternalRequestAsync<GetRuleResponse>(req, "GetRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取转换器详情
        /// </summary>
        /// <param name="req"><see cref="GetTransformationRequest"/></param>
        /// <returns><see cref="GetTransformationResponse"/></returns>
        public Task<GetTransformationResponse> GetTransformation(GetTransformationRequest req)
        {
            return InternalRequestAsync<GetTransformationResponse>(req, "GetTransformation");
        }

        /// <summary>
        /// 用于获取转换器详情
        /// </summary>
        /// <param name="req"><see cref="GetTransformationRequest"/></param>
        /// <returns><see cref="GetTransformationResponse"/></returns>
        public GetTransformationResponse GetTransformationSync(GetTransformationRequest req)
        {
            return InternalRequestAsync<GetTransformationResponse>(req, "GetTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取事件连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListConnectionsRequest"/></param>
        /// <returns><see cref="ListConnectionsResponse"/></returns>
        public Task<ListConnectionsResponse> ListConnections(ListConnectionsRequest req)
        {
            return InternalRequestAsync<ListConnectionsResponse>(req, "ListConnections");
        }

        /// <summary>
        /// 获取事件连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListConnectionsRequest"/></param>
        /// <returns><see cref="ListConnectionsResponse"/></returns>
        public ListConnectionsResponse ListConnectionsSync(ListConnectionsRequest req)
        {
            return InternalRequestAsync<ListConnectionsResponse>(req, "ListConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取事件集列表
        /// </summary>
        /// <param name="req"><see cref="ListEventBusesRequest"/></param>
        /// <returns><see cref="ListEventBusesResponse"/></returns>
        public Task<ListEventBusesResponse> ListEventBuses(ListEventBusesRequest req)
        {
            return InternalRequestAsync<ListEventBusesResponse>(req, "ListEventBuses");
        }

        /// <summary>
        /// 获取事件集列表
        /// </summary>
        /// <param name="req"><see cref="ListEventBusesRequest"/></param>
        /// <returns><see cref="ListEventBusesResponse"/></returns>
        public ListEventBusesResponse ListEventBusesSync(ListEventBusesRequest req)
        {
            return InternalRequestAsync<ListEventBusesResponse>(req, "ListEventBuses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取平台产品事件名称
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventNamesRequest"/></param>
        /// <returns><see cref="ListPlatformEventNamesResponse"/></returns>
        public Task<ListPlatformEventNamesResponse> ListPlatformEventNames(ListPlatformEventNamesRequest req)
        {
            return InternalRequestAsync<ListPlatformEventNamesResponse>(req, "ListPlatformEventNames");
        }

        /// <summary>
        /// 获取平台产品事件名称
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventNamesRequest"/></param>
        /// <returns><see cref="ListPlatformEventNamesResponse"/></returns>
        public ListPlatformEventNamesResponse ListPlatformEventNamesSync(ListPlatformEventNamesRequest req)
        {
            return InternalRequestAsync<ListPlatformEventNamesResponse>(req, "ListPlatformEventNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取平台产品事件匹配规则
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventPatternsRequest"/></param>
        /// <returns><see cref="ListPlatformEventPatternsResponse"/></returns>
        public Task<ListPlatformEventPatternsResponse> ListPlatformEventPatterns(ListPlatformEventPatternsRequest req)
        {
            return InternalRequestAsync<ListPlatformEventPatternsResponse>(req, "ListPlatformEventPatterns");
        }

        /// <summary>
        /// 获取平台产品事件匹配规则
        /// </summary>
        /// <param name="req"><see cref="ListPlatformEventPatternsRequest"/></param>
        /// <returns><see cref="ListPlatformEventPatternsResponse"/></returns>
        public ListPlatformEventPatternsResponse ListPlatformEventPatternsSync(ListPlatformEventPatternsRequest req)
        {
            return InternalRequestAsync<ListPlatformEventPatternsResponse>(req, "ListPlatformEventPatterns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取平台产品列表
        /// </summary>
        /// <param name="req"><see cref="ListPlatformProductsRequest"/></param>
        /// <returns><see cref="ListPlatformProductsResponse"/></returns>
        public Task<ListPlatformProductsResponse> ListPlatformProducts(ListPlatformProductsRequest req)
        {
            return InternalRequestAsync<ListPlatformProductsResponse>(req, "ListPlatformProducts");
        }

        /// <summary>
        /// 获取平台产品列表
        /// </summary>
        /// <param name="req"><see cref="ListPlatformProductsRequest"/></param>
        /// <returns><see cref="ListPlatformProductsResponse"/></returns>
        public ListPlatformProductsResponse ListPlatformProductsSync(ListPlatformProductsRequest req)
        {
            return InternalRequestAsync<ListPlatformProductsResponse>(req, "ListPlatformProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取事件规则列表
        /// </summary>
        /// <param name="req"><see cref="ListRulesRequest"/></param>
        /// <returns><see cref="ListRulesResponse"/></returns>
        public Task<ListRulesResponse> ListRules(ListRulesRequest req)
        {
            return InternalRequestAsync<ListRulesResponse>(req, "ListRules");
        }

        /// <summary>
        /// 获取事件规则列表
        /// </summary>
        /// <param name="req"><see cref="ListRulesRequest"/></param>
        /// <returns><see cref="ListRulesResponse"/></returns>
        public ListRulesResponse ListRulesSync(ListRulesRequest req)
        {
            return InternalRequestAsync<ListRulesResponse>(req, "ListRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取事件目标列表
        /// </summary>
        /// <param name="req"><see cref="ListTargetsRequest"/></param>
        /// <returns><see cref="ListTargetsResponse"/></returns>
        public Task<ListTargetsResponse> ListTargets(ListTargetsRequest req)
        {
            return InternalRequestAsync<ListTargetsResponse>(req, "ListTargets");
        }

        /// <summary>
        /// 获取事件目标列表
        /// </summary>
        /// <param name="req"><see cref="ListTargetsRequest"/></param>
        /// <returns><see cref="ListTargetsResponse"/></returns>
        public ListTargetsResponse ListTargetsSync(ListTargetsRequest req)
        {
            return InternalRequestAsync<ListTargetsResponse>(req, "ListTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// （已废弃）用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PublishEventRequest"/></param>
        /// <returns><see cref="PublishEventResponse"/></returns>
        public Task<PublishEventResponse> PublishEvent(PublishEventRequest req)
        {
            return InternalRequestAsync<PublishEventResponse>(req, "PublishEvent");
        }

        /// <summary>
        /// （已废弃）用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PublishEventRequest"/></param>
        /// <returns><see cref="PublishEventResponse"/></returns>
        public PublishEventResponse PublishEventSync(PublishEventRequest req)
        {
            return InternalRequestAsync<PublishEventResponse>(req, "PublishEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PutEventsRequest"/></param>
        /// <returns><see cref="PutEventsResponse"/></returns>
        public Task<PutEventsResponse> PutEvents(PutEventsRequest req)
        {
            return InternalRequestAsync<PutEventsResponse>(req, "PutEvents");
        }

        /// <summary>
        /// 用于Event事件投递
        /// </summary>
        /// <param name="req"><see cref="PutEventsRequest"/></param>
        /// <returns><see cref="PutEventsResponse"/></returns>
        public PutEventsResponse PutEventsSync(PutEventsRequest req)
        {
            return InternalRequestAsync<PutEventsResponse>(req, "PutEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 前置条件：开启事件存储；查询历史推送事件
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog");
        }

        /// <summary>
        /// 前置条件：开启事件存储；查询历史推送事件
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新事件连接器
        /// </summary>
        /// <param name="req"><see cref="UpdateConnectionRequest"/></param>
        /// <returns><see cref="UpdateConnectionResponse"/></returns>
        public Task<UpdateConnectionResponse> UpdateConnection(UpdateConnectionRequest req)
        {
            return InternalRequestAsync<UpdateConnectionResponse>(req, "UpdateConnection");
        }

        /// <summary>
        /// 更新事件连接器
        /// </summary>
        /// <param name="req"><see cref="UpdateConnectionRequest"/></param>
        /// <returns><see cref="UpdateConnectionResponse"/></returns>
        public UpdateConnectionResponse UpdateConnectionSync(UpdateConnectionRequest req)
        {
            return InternalRequestAsync<UpdateConnectionResponse>(req, "UpdateConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新事件集
        /// </summary>
        /// <param name="req"><see cref="UpdateEventBusRequest"/></param>
        /// <returns><see cref="UpdateEventBusResponse"/></returns>
        public Task<UpdateEventBusResponse> UpdateEventBus(UpdateEventBusRequest req)
        {
            return InternalRequestAsync<UpdateEventBusResponse>(req, "UpdateEventBus");
        }

        /// <summary>
        /// 更新事件集
        /// </summary>
        /// <param name="req"><see cref="UpdateEventBusRequest"/></param>
        /// <returns><see cref="UpdateEventBusResponse"/></returns>
        public UpdateEventBusResponse UpdateEventBusSync(UpdateEventBusRequest req)
        {
            return InternalRequestAsync<UpdateEventBusResponse>(req, "UpdateEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新事件规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public Task<UpdateRuleResponse> UpdateRule(UpdateRuleRequest req)
        {
            return InternalRequestAsync<UpdateRuleResponse>(req, "UpdateRule");
        }

        /// <summary>
        /// 更新事件规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public UpdateRuleResponse UpdateRuleSync(UpdateRuleRequest req)
        {
            return InternalRequestAsync<UpdateRuleResponse>(req, "UpdateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新事件目标
        /// </summary>
        /// <param name="req"><see cref="UpdateTargetRequest"/></param>
        /// <returns><see cref="UpdateTargetResponse"/></returns>
        public Task<UpdateTargetResponse> UpdateTarget(UpdateTargetRequest req)
        {
            return InternalRequestAsync<UpdateTargetResponse>(req, "UpdateTarget");
        }

        /// <summary>
        /// 更新事件目标
        /// </summary>
        /// <param name="req"><see cref="UpdateTargetRequest"/></param>
        /// <returns><see cref="UpdateTargetResponse"/></returns>
        public UpdateTargetResponse UpdateTargetSync(UpdateTargetRequest req)
        {
            return InternalRequestAsync<UpdateTargetResponse>(req, "UpdateTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于更新转换器
        /// </summary>
        /// <param name="req"><see cref="UpdateTransformationRequest"/></param>
        /// <returns><see cref="UpdateTransformationResponse"/></returns>
        public Task<UpdateTransformationResponse> UpdateTransformation(UpdateTransformationRequest req)
        {
            return InternalRequestAsync<UpdateTransformationResponse>(req, "UpdateTransformation");
        }

        /// <summary>
        /// 用于更新转换器
        /// </summary>
        /// <param name="req"><see cref="UpdateTransformationRequest"/></param>
        /// <returns><see cref="UpdateTransformationResponse"/></returns>
        public UpdateTransformationResponse UpdateTransformationSync(UpdateTransformationRequest req)
        {
            return InternalRequestAsync<UpdateTransformationResponse>(req, "UpdateTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
