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

namespace TencentCloud.Tdmq.V20200217
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdmq.V20200217.Models;

   public class TdmqClient : AbstractClient{

       private const string endpoint = "tdmq.tencentcloudapi.com";
       private const string version = "2020-02-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdmqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdmqClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 根据提供的 MessageID 确认指定 topic 中的消息
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public async Task<AcknowledgeMessageResponse> AcknowledgeMessage(AcknowledgeMessageRequest req)
        {
             JsonResponseModel<AcknowledgeMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcknowledgeMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcknowledgeMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据提供的 MessageID 确认指定 topic 中的消息
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public AcknowledgeMessageResponse AcknowledgeMessageSync(AcknowledgeMessageRequest req)
        {
             JsonResponseModel<AcknowledgeMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcknowledgeMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcknowledgeMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清空cmq消息队列中的消息
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public async Task<ClearCmqQueueResponse> ClearCmqQueue(ClearCmqQueueRequest req)
        {
             JsonResponseModel<ClearCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清空cmq消息队列中的消息
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public ClearCmqQueueResponse ClearCmqQueueSync(ClearCmqQueueRequest req)
        {
             JsonResponseModel<ClearCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清空订阅者消息标签
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public async Task<ClearCmqSubscriptionFilterTagsResponse> ClearCmqSubscriptionFilterTags(ClearCmqSubscriptionFilterTagsRequest req)
        {
             JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearCmqSubscriptionFilterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清空订阅者消息标签
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public ClearCmqSubscriptionFilterTagsResponse ClearCmqSubscriptionFilterTagsSync(ClearCmqSubscriptionFilterTagsRequest req)
        {
             JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearCmqSubscriptionFilterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearCmqSubscriptionFilterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP集群
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPClusterRequest"/></param>
        /// <returns><see cref="CreateAMQPClusterResponse"/></returns>
        public async Task<CreateAMQPClusterResponse> CreateAMQPCluster(CreateAMQPClusterRequest req)
        {
             JsonResponseModel<CreateAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP集群
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPClusterRequest"/></param>
        /// <returns><see cref="CreateAMQPClusterResponse"/></returns>
        public CreateAMQPClusterResponse CreateAMQPClusterSync(CreateAMQPClusterRequest req)
        {
             JsonResponseModel<CreateAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP Exchange
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPExchangeRequest"/></param>
        /// <returns><see cref="CreateAMQPExchangeResponse"/></returns>
        public async Task<CreateAMQPExchangeResponse> CreateAMQPExchange(CreateAMQPExchangeRequest req)
        {
             JsonResponseModel<CreateAMQPExchangeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAMQPExchange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPExchangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP Exchange
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPExchangeRequest"/></param>
        /// <returns><see cref="CreateAMQPExchangeResponse"/></returns>
        public CreateAMQPExchangeResponse CreateAMQPExchangeSync(CreateAMQPExchangeRequest req)
        {
             JsonResponseModel<CreateAMQPExchangeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAMQPExchange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPExchangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP队列
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPQueueRequest"/></param>
        /// <returns><see cref="CreateAMQPQueueResponse"/></returns>
        public async Task<CreateAMQPQueueResponse> CreateAMQPQueue(CreateAMQPQueueRequest req)
        {
             JsonResponseModel<CreateAMQPQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAMQPQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP队列
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPQueueRequest"/></param>
        /// <returns><see cref="CreateAMQPQueueResponse"/></returns>
        public CreateAMQPQueueResponse CreateAMQPQueueSync(CreateAMQPQueueRequest req)
        {
             JsonResponseModel<CreateAMQPQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAMQPQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP路由关系
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPRouteRelationRequest"/></param>
        /// <returns><see cref="CreateAMQPRouteRelationResponse"/></returns>
        public async Task<CreateAMQPRouteRelationResponse> CreateAMQPRouteRelation(CreateAMQPRouteRelationRequest req)
        {
             JsonResponseModel<CreateAMQPRouteRelationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAMQPRouteRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPRouteRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建AMQP路由关系
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPRouteRelationRequest"/></param>
        /// <returns><see cref="CreateAMQPRouteRelationResponse"/></returns>
        public CreateAMQPRouteRelationResponse CreateAMQPRouteRelationSync(CreateAMQPRouteRelationRequest req)
        {
             JsonResponseModel<CreateAMQPRouteRelationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAMQPRouteRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPRouteRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建Amqp Vhost
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPVHostRequest"/></param>
        /// <returns><see cref="CreateAMQPVHostResponse"/></returns>
        public async Task<CreateAMQPVHostResponse> CreateAMQPVHost(CreateAMQPVHostRequest req)
        {
             JsonResponseModel<CreateAMQPVHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAMQPVHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPVHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 创建Amqp Vhost
        /// </summary>
        /// <param name="req"><see cref="CreateAMQPVHostRequest"/></param>
        /// <returns><see cref="CreateAMQPVHostResponse"/></returns>
        public CreateAMQPVHostResponse CreateAMQPVHostSync(CreateAMQPVHostRequest req)
        {
             JsonResponseModel<CreateAMQPVHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAMQPVHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAMQPVHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户的集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public async Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户的集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建cmq队列接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public async Task<CreateCmqQueueResponse> CreateCmqQueue(CreateCmqQueueRequest req)
        {
             JsonResponseModel<CreateCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建cmq队列接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public CreateCmqQueueResponse CreateCmqQueueSync(CreateCmqQueueRequest req)
        {
             JsonResponseModel<CreateCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建cmq订阅接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public async Task<CreateCmqSubscribeResponse> CreateCmqSubscribe(CreateCmqSubscribeRequest req)
        {
             JsonResponseModel<CreateCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建cmq订阅接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public CreateCmqSubscribeResponse CreateCmqSubscribeSync(CreateCmqSubscribeRequest req)
        {
             JsonResponseModel<CreateCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建cmq主题
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public async Task<CreateCmqTopicResponse> CreateCmqTopic(CreateCmqTopicRequest req)
        {
             JsonResponseModel<CreateCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建cmq主题
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public CreateCmqTopicResponse CreateCmqTopicSync(CreateCmqTopicRequest req)
        {
             JsonResponseModel<CreateCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在用户账户下创建消息队列 Tdmq 命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public async Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
             JsonResponseModel<CreateEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于在用户账户下创建消息队列 Tdmq 命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
             JsonResponseModel<CreateEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建环境角色授权
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public async Task<CreateEnvironmentRoleResponse> CreateEnvironmentRole(CreateEnvironmentRoleRequest req)
        {
             JsonResponseModel<CreateEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建环境角色授权
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public CreateEnvironmentRoleResponse CreateEnvironmentRoleSync(CreateEnvironmentRoleRequest req)
        {
             JsonResponseModel<CreateEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQUserResponse"/></returns>
        public async Task<CreateRabbitMQUserResponse> CreateRabbitMQUser(CreateRabbitMQUserRequest req)
        {
             JsonResponseModel<CreateRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQUserResponse"/></returns>
        public CreateRabbitMQUserResponse CreateRabbitMQUserSync(CreateRabbitMQUserRequest req)
        {
             JsonResponseModel<CreateRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVipInstanceResponse"/></returns>
        public async Task<CreateRabbitMQVipInstanceResponse> CreateRabbitMQVipInstance(CreateRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<CreateRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVipInstanceResponse"/></returns>
        public CreateRabbitMQVipInstanceResponse CreateRabbitMQVipInstanceSync(CreateRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<CreateRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVirtualHostResponse"/></returns>
        public async Task<CreateRabbitMQVirtualHostResponse> CreateRabbitMQVirtualHost(CreateRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<CreateRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVirtualHostResponse"/></returns>
        public CreateRabbitMQVirtualHostResponse CreateRabbitMQVirtualHostSync(CreateRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<CreateRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于创建一个RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public async Task<CreateRocketMQClusterResponse> CreateRocketMQCluster(CreateRocketMQClusterRequest req)
        {
             JsonResponseModel<CreateRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于创建一个RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public CreateRocketMQClusterResponse CreateRocketMQClusterSync(CreateRocketMQClusterRequest req)
        {
             JsonResponseModel<CreateRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public async Task<CreateRocketMQGroupResponse> CreateRocketMQGroup(CreateRocketMQGroupRequest req)
        {
             JsonResponseModel<CreateRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public CreateRocketMQGroupResponse CreateRocketMQGroupSync(CreateRocketMQGroupRequest req)
        {
             JsonResponseModel<CreateRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public async Task<CreateRocketMQNamespaceResponse> CreateRocketMQNamespace(CreateRocketMQNamespaceRequest req)
        {
             JsonResponseModel<CreateRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public CreateRocketMQNamespaceResponse CreateRocketMQNamespaceSync(CreateRocketMQNamespaceRequest req)
        {
             JsonResponseModel<CreateRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public async Task<CreateRocketMQTopicResponse> CreateRocketMQTopic(CreateRocketMQTopicRequest req)
        {
             JsonResponseModel<CreateRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public CreateRocketMQTopicResponse CreateRocketMQTopicSync(CreateRocketMQTopicRequest req)
        {
             JsonResponseModel<CreateRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public async Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
             JsonResponseModel<CreateRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个主题的订阅关系
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public async Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest req)
        {
             JsonResponseModel<CreateSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个主题的订阅关系
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public CreateSubscriptionResponse CreateSubscriptionSync(CreateSubscriptionRequest req)
        {
             JsonResponseModel<CreateSubscriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubscription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubscriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增指定分区、类型的消息主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增指定分区、类型的消息主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除AMQP集群
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPClusterRequest"/></param>
        /// <returns><see cref="DeleteAMQPClusterResponse"/></returns>
        public async Task<DeleteAMQPClusterResponse> DeleteAMQPCluster(DeleteAMQPClusterRequest req)
        {
             JsonResponseModel<DeleteAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除AMQP集群
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPClusterRequest"/></param>
        /// <returns><see cref="DeleteAMQPClusterResponse"/></returns>
        public DeleteAMQPClusterResponse DeleteAMQPClusterSync(DeleteAMQPClusterRequest req)
        {
             JsonResponseModel<DeleteAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Amqp交换机
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPExchangeRequest"/></param>
        /// <returns><see cref="DeleteAMQPExchangeResponse"/></returns>
        public async Task<DeleteAMQPExchangeResponse> DeleteAMQPExchange(DeleteAMQPExchangeRequest req)
        {
             JsonResponseModel<DeleteAMQPExchangeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAMQPExchange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPExchangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Amqp交换机
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPExchangeRequest"/></param>
        /// <returns><see cref="DeleteAMQPExchangeResponse"/></returns>
        public DeleteAMQPExchangeResponse DeleteAMQPExchangeSync(DeleteAMQPExchangeRequest req)
        {
             JsonResponseModel<DeleteAMQPExchangeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAMQPExchange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPExchangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Amqp队列
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPQueueRequest"/></param>
        /// <returns><see cref="DeleteAMQPQueueResponse"/></returns>
        public async Task<DeleteAMQPQueueResponse> DeleteAMQPQueue(DeleteAMQPQueueRequest req)
        {
             JsonResponseModel<DeleteAMQPQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAMQPQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Amqp队列
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPQueueRequest"/></param>
        /// <returns><see cref="DeleteAMQPQueueResponse"/></returns>
        public DeleteAMQPQueueResponse DeleteAMQPQueueSync(DeleteAMQPQueueRequest req)
        {
             JsonResponseModel<DeleteAMQPQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAMQPQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Amqp路由关系
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPRouteRelationRequest"/></param>
        /// <returns><see cref="DeleteAMQPRouteRelationResponse"/></returns>
        public async Task<DeleteAMQPRouteRelationResponse> DeleteAMQPRouteRelation(DeleteAMQPRouteRelationRequest req)
        {
             JsonResponseModel<DeleteAMQPRouteRelationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAMQPRouteRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPRouteRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Amqp路由关系
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPRouteRelationRequest"/></param>
        /// <returns><see cref="DeleteAMQPRouteRelationResponse"/></returns>
        public DeleteAMQPRouteRelationResponse DeleteAMQPRouteRelationSync(DeleteAMQPRouteRelationRequest req)
        {
             JsonResponseModel<DeleteAMQPRouteRelationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAMQPRouteRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPRouteRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Vhost
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPVHostRequest"/></param>
        /// <returns><see cref="DeleteAMQPVHostResponse"/></returns>
        public async Task<DeleteAMQPVHostResponse> DeleteAMQPVHost(DeleteAMQPVHostRequest req)
        {
             JsonResponseModel<DeleteAMQPVHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAMQPVHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPVHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 删除Vhost
        /// </summary>
        /// <param name="req"><see cref="DeleteAMQPVHostRequest"/></param>
        /// <returns><see cref="DeleteAMQPVHostResponse"/></returns>
        public DeleteAMQPVHostResponse DeleteAMQPVHostSync(DeleteAMQPVHostRequest req)
        {
             JsonResponseModel<DeleteAMQPVHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAMQPVHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAMQPVHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public async Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除cmq队列
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public async Task<DeleteCmqQueueResponse> DeleteCmqQueue(DeleteCmqQueueRequest req)
        {
             JsonResponseModel<DeleteCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除cmq队列
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public DeleteCmqQueueResponse DeleteCmqQueueSync(DeleteCmqQueueRequest req)
        {
             JsonResponseModel<DeleteCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除cmq订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public async Task<DeleteCmqSubscribeResponse> DeleteCmqSubscribe(DeleteCmqSubscribeRequest req)
        {
             JsonResponseModel<DeleteCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除cmq订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public DeleteCmqSubscribeResponse DeleteCmqSubscribeSync(DeleteCmqSubscribeRequest req)
        {
             JsonResponseModel<DeleteCmqSubscribeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCmqSubscribe");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqSubscribeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除cmq主题
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public async Task<DeleteCmqTopicResponse> DeleteCmqTopic(DeleteCmqTopicRequest req)
        {
             JsonResponseModel<DeleteCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除cmq主题
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public DeleteCmqTopicResponse DeleteCmqTopicSync(DeleteCmqTopicRequest req)
        {
             JsonResponseModel<DeleteCmqTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCmqTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCmqTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public async Task<DeleteEnvironmentRolesResponse> DeleteEnvironmentRoles(DeleteEnvironmentRolesRequest req)
        {
             JsonResponseModel<DeleteEnvironmentRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEnvironmentRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public DeleteEnvironmentRolesResponse DeleteEnvironmentRolesSync(DeleteEnvironmentRolesRequest req)
        {
             JsonResponseModel<DeleteEnvironmentRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEnvironmentRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除租户下的命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public async Task<DeleteEnvironmentsResponse> DeleteEnvironments(DeleteEnvironmentsRequest req)
        {
             JsonResponseModel<DeleteEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除租户下的命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public DeleteEnvironmentsResponse DeleteEnvironmentsSync(DeleteEnvironmentsRequest req)
        {
             JsonResponseModel<DeleteEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQUserResponse"/></returns>
        public async Task<DeleteRabbitMQUserResponse> DeleteRabbitMQUser(DeleteRabbitMQUserRequest req)
        {
             JsonResponseModel<DeleteRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQUserResponse"/></returns>
        public DeleteRabbitMQUserResponse DeleteRabbitMQUserSync(DeleteRabbitMQUserRequest req)
        {
             JsonResponseModel<DeleteRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVipInstanceResponse"/></returns>
        public async Task<DeleteRabbitMQVipInstanceResponse> DeleteRabbitMQVipInstance(DeleteRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<DeleteRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVipInstanceResponse"/></returns>
        public DeleteRabbitMQVipInstanceResponse DeleteRabbitMQVipInstanceSync(DeleteRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<DeleteRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVirtualHostResponse"/></returns>
        public async Task<DeleteRabbitMQVirtualHostResponse> DeleteRabbitMQVirtualHost(DeleteRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<DeleteRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVirtualHostResponse"/></returns>
        public DeleteRabbitMQVirtualHostResponse DeleteRabbitMQVirtualHostSync(DeleteRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<DeleteRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public async Task<DeleteRocketMQClusterResponse> DeleteRocketMQCluster(DeleteRocketMQClusterRequest req)
        {
             JsonResponseModel<DeleteRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public DeleteRocketMQClusterResponse DeleteRocketMQClusterSync(DeleteRocketMQClusterRequest req)
        {
             JsonResponseModel<DeleteRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public async Task<DeleteRocketMQGroupResponse> DeleteRocketMQGroup(DeleteRocketMQGroupRequest req)
        {
             JsonResponseModel<DeleteRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public DeleteRocketMQGroupResponse DeleteRocketMQGroupSync(DeleteRocketMQGroupRequest req)
        {
             JsonResponseModel<DeleteRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public async Task<DeleteRocketMQNamespaceResponse> DeleteRocketMQNamespace(DeleteRocketMQNamespaceRequest req)
        {
             JsonResponseModel<DeleteRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public DeleteRocketMQNamespaceResponse DeleteRocketMQNamespaceSync(DeleteRocketMQNamespaceRequest req)
        {
             JsonResponseModel<DeleteRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public async Task<DeleteRocketMQTopicResponse> DeleteRocketMQTopic(DeleteRocketMQTopicRequest req)
        {
             JsonResponseModel<DeleteRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public DeleteRocketMQTopicResponse DeleteRocketMQTopicSync(DeleteRocketMQTopicRequest req)
        {
             JsonResponseModel<DeleteRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除角色，支持批量。
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public async Task<DeleteRolesResponse> DeleteRoles(DeleteRolesRequest req)
        {
             JsonResponseModel<DeleteRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除角色，支持批量。
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public DeleteRolesResponse DeleteRolesSync(DeleteRolesRequest req)
        {
             JsonResponseModel<DeleteRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除订阅关系
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscriptionsRequest"/></param>
        /// <returns><see cref="DeleteSubscriptionsResponse"/></returns>
        public async Task<DeleteSubscriptionsResponse> DeleteSubscriptions(DeleteSubscriptionsRequest req)
        {
             JsonResponseModel<DeleteSubscriptionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSubscriptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubscriptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除订阅关系
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscriptionsRequest"/></param>
        /// <returns><see cref="DeleteSubscriptionsResponse"/></returns>
        public DeleteSubscriptionsResponse DeleteSubscriptionsSync(DeleteSubscriptionsRequest req)
        {
             JsonResponseModel<DeleteSubscriptionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSubscriptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubscriptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除topics
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicsRequest"/></param>
        /// <returns><see cref="DeleteTopicsResponse"/></returns>
        public async Task<DeleteTopicsResponse> DeleteTopics(DeleteTopicsRequest req)
        {
             JsonResponseModel<DeleteTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除topics
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicsRequest"/></param>
        /// <returns><see cref="DeleteTopicsResponse"/></returns>
        public DeleteTopicsResponse DeleteTopicsSync(DeleteTopicsRequest req)
        {
             JsonResponseModel<DeleteTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取单个Amqp集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPClusterRequest"/></param>
        /// <returns><see cref="DescribeAMQPClusterResponse"/></returns>
        public async Task<DescribeAMQPClusterResponse> DescribeAMQPCluster(DescribeAMQPClusterRequest req)
        {
             JsonResponseModel<DescribeAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取单个Amqp集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPClusterRequest"/></param>
        /// <returns><see cref="DescribeAMQPClusterResponse"/></returns>
        public DescribeAMQPClusterResponse DescribeAMQPClusterSync(DescribeAMQPClusterRequest req)
        {
             JsonResponseModel<DescribeAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取amqp集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPClustersRequest"/></param>
        /// <returns><see cref="DescribeAMQPClustersResponse"/></returns>
        public async Task<DescribeAMQPClustersResponse> DescribeAMQPClusters(DescribeAMQPClustersRequest req)
        {
             JsonResponseModel<DescribeAMQPClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAMQPClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取amqp集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPClustersRequest"/></param>
        /// <returns><see cref="DescribeAMQPClustersResponse"/></returns>
        public DescribeAMQPClustersResponse DescribeAMQPClustersSync(DescribeAMQPClustersRequest req)
        {
             JsonResponseModel<DescribeAMQPClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAMQPClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取用户的配额，如Queue容量，Exchange容量，Vhost容量，单Vhost Tps数,剩余可创建集群数
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPCreateQuotaRequest"/></param>
        /// <returns><see cref="DescribeAMQPCreateQuotaResponse"/></returns>
        public async Task<DescribeAMQPCreateQuotaResponse> DescribeAMQPCreateQuota(DescribeAMQPCreateQuotaRequest req)
        {
             JsonResponseModel<DescribeAMQPCreateQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAMQPCreateQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPCreateQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取用户的配额，如Queue容量，Exchange容量，Vhost容量，单Vhost Tps数,剩余可创建集群数
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPCreateQuotaRequest"/></param>
        /// <returns><see cref="DescribeAMQPCreateQuotaResponse"/></returns>
        public DescribeAMQPCreateQuotaResponse DescribeAMQPCreateQuotaSync(DescribeAMQPCreateQuotaRequest req)
        {
             JsonResponseModel<DescribeAMQPCreateQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAMQPCreateQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPCreateQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取AMQP Exchange列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPExchangesRequest"/></param>
        /// <returns><see cref="DescribeAMQPExchangesResponse"/></returns>
        public async Task<DescribeAMQPExchangesResponse> DescribeAMQPExchanges(DescribeAMQPExchangesRequest req)
        {
             JsonResponseModel<DescribeAMQPExchangesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAMQPExchanges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPExchangesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取AMQP Exchange列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPExchangesRequest"/></param>
        /// <returns><see cref="DescribeAMQPExchangesResponse"/></returns>
        public DescribeAMQPExchangesResponse DescribeAMQPExchangesSync(DescribeAMQPExchangesRequest req)
        {
             JsonResponseModel<DescribeAMQPExchangesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAMQPExchanges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPExchangesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取Amqp队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPQueuesRequest"/></param>
        /// <returns><see cref="DescribeAMQPQueuesResponse"/></returns>
        public async Task<DescribeAMQPQueuesResponse> DescribeAMQPQueues(DescribeAMQPQueuesRequest req)
        {
             JsonResponseModel<DescribeAMQPQueuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAMQPQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取Amqp队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPQueuesRequest"/></param>
        /// <returns><see cref="DescribeAMQPQueuesResponse"/></returns>
        public DescribeAMQPQueuesResponse DescribeAMQPQueuesSync(DescribeAMQPQueuesRequest req)
        {
             JsonResponseModel<DescribeAMQPQueuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAMQPQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取Amqp路由关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPRouteRelationsRequest"/></param>
        /// <returns><see cref="DescribeAMQPRouteRelationsResponse"/></returns>
        public async Task<DescribeAMQPRouteRelationsResponse> DescribeAMQPRouteRelations(DescribeAMQPRouteRelationsRequest req)
        {
             JsonResponseModel<DescribeAMQPRouteRelationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAMQPRouteRelations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPRouteRelationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取Amqp路由关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPRouteRelationsRequest"/></param>
        /// <returns><see cref="DescribeAMQPRouteRelationsResponse"/></returns>
        public DescribeAMQPRouteRelationsResponse DescribeAMQPRouteRelationsSync(DescribeAMQPRouteRelationsRequest req)
        {
             JsonResponseModel<DescribeAMQPRouteRelationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAMQPRouteRelations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPRouteRelationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取Amqp Vhost 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPVHostsRequest"/></param>
        /// <returns><see cref="DescribeAMQPVHostsResponse"/></returns>
        public async Task<DescribeAMQPVHostsResponse> DescribeAMQPVHosts(DescribeAMQPVHostsRequest req)
        {
             JsonResponseModel<DescribeAMQPVHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAMQPVHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPVHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 获取Amqp Vhost 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPVHostsRequest"/></param>
        /// <returns><see cref="DescribeAMQPVHostsResponse"/></returns>
        public DescribeAMQPVHostsResponse DescribeAMQPVHostsSync(DescribeAMQPVHostsRequest req)
        {
             JsonResponseModel<DescribeAMQPVHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAMQPVHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAMQPVHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个租户的虚拟集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAllTenantsRequest"/></param>
        /// <returns><see cref="DescribeAllTenantsResponse"/></returns>
        public async Task<DescribeAllTenantsResponse> DescribeAllTenants(DescribeAllTenantsRequest req)
        {
             JsonResponseModel<DescribeAllTenantsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllTenants");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllTenantsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个租户的虚拟集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAllTenantsRequest"/></param>
        /// <returns><see cref="DescribeAllTenantsResponse"/></returns>
        public DescribeAllTenantsResponse DescribeAllTenantsSync(DescribeAllTenantsRequest req)
        {
             JsonResponseModel<DescribeAllTenantsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllTenants");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllTenantsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户绑定的专享集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindClustersRequest"/></param>
        /// <returns><see cref="DescribeBindClustersResponse"/></returns>
        public async Task<DescribeBindClustersResponse> DescribeBindClusters(DescribeBindClustersRequest req)
        {
             JsonResponseModel<DescribeBindClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户绑定的专享集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindClustersRequest"/></param>
        /// <returns><see cref="DescribeBindClustersResponse"/></returns>
        public DescribeBindClustersResponse DescribeBindClustersSync(DescribeBindClustersRequest req)
        {
             JsonResponseModel<DescribeBindClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户VPC绑定关系
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public async Task<DescribeBindVpcsResponse> DescribeBindVpcs(DescribeBindVpcsRequest req)
        {
             JsonResponseModel<DescribeBindVpcsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户VPC绑定关系
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public DescribeBindVpcsResponse DescribeBindVpcsSync(DescribeBindVpcsRequest req)
        {
             JsonResponseModel<DescribeBindVpcsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public async Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public async Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举cmq死信队列源队列
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqDeadLetterSourceQueuesResponse"/></returns>
        public async Task<DescribeCmqDeadLetterSourceQueuesResponse> DescribeCmqDeadLetterSourceQueues(DescribeCmqDeadLetterSourceQueuesRequest req)
        {
             JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqDeadLetterSourceQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举cmq死信队列源队列
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqDeadLetterSourceQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqDeadLetterSourceQueuesResponse"/></returns>
        public DescribeCmqDeadLetterSourceQueuesResponse DescribeCmqDeadLetterSourceQueuesSync(DescribeCmqDeadLetterSourceQueuesRequest req)
        {
             JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqDeadLetterSourceQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqDeadLetterSourceQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq队列详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public async Task<DescribeCmqQueueDetailResponse> DescribeCmqQueueDetail(DescribeCmqQueueDetailRequest req)
        {
             JsonResponseModel<DescribeCmqQueueDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqQueueDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqQueueDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq队列详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public DescribeCmqQueueDetailResponse DescribeCmqQueueDetailSync(DescribeCmqQueueDetailRequest req)
        {
             JsonResponseModel<DescribeCmqQueueDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqQueueDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqQueueDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq全量队列
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqQueuesResponse"/></returns>
        public async Task<DescribeCmqQueuesResponse> DescribeCmqQueues(DescribeCmqQueuesRequest req)
        {
             JsonResponseModel<DescribeCmqQueuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq全量队列
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqQueuesResponse"/></returns>
        public DescribeCmqQueuesResponse DescribeCmqQueuesSync(DescribeCmqQueuesRequest req)
        {
             JsonResponseModel<DescribeCmqQueuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq订阅详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public async Task<DescribeCmqSubscriptionDetailResponse> DescribeCmqSubscriptionDetail(DescribeCmqSubscriptionDetailRequest req)
        {
             JsonResponseModel<DescribeCmqSubscriptionDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqSubscriptionDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqSubscriptionDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq订阅详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public DescribeCmqSubscriptionDetailResponse DescribeCmqSubscriptionDetailSync(DescribeCmqSubscriptionDetailRequest req)
        {
             JsonResponseModel<DescribeCmqSubscriptionDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqSubscriptionDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqSubscriptionDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public async Task<DescribeCmqTopicDetailResponse> DescribeCmqTopicDetail(DescribeCmqTopicDetailRequest req)
        {
             JsonResponseModel<DescribeCmqTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询cmq主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public DescribeCmqTopicDetailResponse DescribeCmqTopicDetailSync(DescribeCmqTopicDetailRequest req)
        {
             JsonResponseModel<DescribeCmqTopicDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqTopicDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqTopicDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举cmq全量主题
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicsRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicsResponse"/></returns>
        public async Task<DescribeCmqTopicsResponse> DescribeCmqTopics(DescribeCmqTopicsRequest req)
        {
             JsonResponseModel<DescribeCmqTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCmqTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 枚举cmq全量主题
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicsRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicsResponse"/></returns>
        public DescribeCmqTopicsResponse DescribeCmqTopicsSync(DescribeCmqTopicsRequest req)
        {
             JsonResponseModel<DescribeCmqTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCmqTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCmqTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定命名空间的属性
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public async Task<DescribeEnvironmentAttributesResponse> DescribeEnvironmentAttributes(DescribeEnvironmentAttributesRequest req)
        {
             JsonResponseModel<DescribeEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定命名空间的属性
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public DescribeEnvironmentAttributesResponse DescribeEnvironmentAttributesSync(DescribeEnvironmentAttributesRequest req)
        {
             JsonResponseModel<DescribeEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentRolesResponse"/></returns>
        public async Task<DescribeEnvironmentRolesResponse> DescribeEnvironmentRoles(DescribeEnvironmentRolesRequest req)
        {
             JsonResponseModel<DescribeEnvironmentRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvironmentRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentRolesResponse"/></returns>
        public DescribeEnvironmentRolesResponse DescribeEnvironmentRolesSync(DescribeEnvironmentRolesRequest req)
        {
             JsonResponseModel<DescribeEnvironmentRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvironmentRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户下命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public async Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户下命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营端获取命名空间bundle列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceBundlesOptRequest"/></param>
        /// <returns><see cref="DescribeNamespaceBundlesOptResponse"/></returns>
        public async Task<DescribeNamespaceBundlesOptResponse> DescribeNamespaceBundlesOpt(DescribeNamespaceBundlesOptRequest req)
        {
             JsonResponseModel<DescribeNamespaceBundlesOptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNamespaceBundlesOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespaceBundlesOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营端获取命名空间bundle列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceBundlesOptRequest"/></param>
        /// <returns><see cref="DescribeNamespaceBundlesOptResponse"/></returns>
        public DescribeNamespaceBundlesOptResponse DescribeNamespaceBundlesOptSync(DescribeNamespaceBundlesOptRequest req)
        {
             JsonResponseModel<DescribeNamespaceBundlesOptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNamespaceBundlesOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespaceBundlesOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营端获节点健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeHealthOptRequest"/></param>
        /// <returns><see cref="DescribeNodeHealthOptResponse"/></returns>
        public async Task<DescribeNodeHealthOptResponse> DescribeNodeHealthOpt(DescribeNodeHealthOptRequest req)
        {
             JsonResponseModel<DescribeNodeHealthOptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNodeHealthOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeHealthOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营端获节点健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeHealthOptRequest"/></param>
        /// <returns><see cref="DescribeNodeHealthOptResponse"/></returns>
        public DescribeNodeHealthOptResponse DescribeNodeHealthOptSync(DescribeNodeHealthOptRequest req)
        {
             JsonResponseModel<DescribeNodeHealthOptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNodeHealthOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeHealthOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取消息生产概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public async Task<DescribePublisherSummaryResponse> DescribePublisherSummary(DescribePublisherSummaryRequest req)
        {
             JsonResponseModel<DescribePublisherSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublisherSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublisherSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取消息生产概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public DescribePublisherSummaryResponse DescribePublisherSummarySync(DescribePublisherSummaryRequest req)
        {
             JsonResponseModel<DescribePublisherSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublisherSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublisherSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取生产者信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public async Task<DescribePublishersResponse> DescribePublishers(DescribePublishersRequest req)
        {
             JsonResponseModel<DescribePublishersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublishers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublishersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取生产者信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public DescribePublishersResponse DescribePublishersSync(DescribePublishersRequest req)
        {
             JsonResponseModel<DescribePublishersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublishers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublishersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Pulsar专业版集群实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstanceDetailResponse"/></returns>
        public async Task<DescribePulsarProInstanceDetailResponse> DescribePulsarProInstanceDetail(DescribePulsarProInstanceDetailRequest req)
        {
             JsonResponseModel<DescribePulsarProInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePulsarProInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePulsarProInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Pulsar专业版集群实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstanceDetailResponse"/></returns>
        public DescribePulsarProInstanceDetailResponse DescribePulsarProInstanceDetailSync(DescribePulsarProInstanceDetailRequest req)
        {
             JsonResponseModel<DescribePulsarProInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePulsarProInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePulsarProInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户已购的Pulsar专业版实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstancesRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstancesResponse"/></returns>
        public async Task<DescribePulsarProInstancesResponse> DescribePulsarProInstances(DescribePulsarProInstancesRequest req)
        {
             JsonResponseModel<DescribePulsarProInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePulsarProInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePulsarProInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户已购的Pulsar专业版实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstancesRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstancesResponse"/></returns>
        public DescribePulsarProInstancesResponse DescribePulsarProInstancesSync(DescribePulsarProInstancesRequest req)
        {
             JsonResponseModel<DescribePulsarProInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePulsarProInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePulsarProInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RabbitMQ专享版查询节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQNodeListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQNodeListResponse"/></returns>
        public async Task<DescribeRabbitMQNodeListResponse> DescribeRabbitMQNodeList(DescribeRabbitMQNodeListRequest req)
        {
             JsonResponseModel<DescribeRabbitMQNodeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRabbitMQNodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQNodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RabbitMQ专享版查询节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQNodeListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQNodeListResponse"/></returns>
        public DescribeRabbitMQNodeListResponse DescribeRabbitMQNodeListSync(DescribeRabbitMQNodeListRequest req)
        {
             JsonResponseModel<DescribeRabbitMQNodeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRabbitMQNodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQNodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询RabbitMQ用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQUserResponse"/></returns>
        public async Task<DescribeRabbitMQUserResponse> DescribeRabbitMQUser(DescribeRabbitMQUserRequest req)
        {
             JsonResponseModel<DescribeRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询RabbitMQ用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQUserResponse"/></returns>
        public DescribeRabbitMQUserResponse DescribeRabbitMQUserSync(DescribeRabbitMQUserRequest req)
        {
             JsonResponseModel<DescribeRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个RabbitMQ专享实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstanceResponse"/></returns>
        public async Task<DescribeRabbitMQVipInstanceResponse> DescribeRabbitMQVipInstance(DescribeRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个RabbitMQ专享实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstanceResponse"/></returns>
        public DescribeRabbitMQVipInstanceResponse DescribeRabbitMQVipInstanceSync(DescribeRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户已购的RabbitMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstancesResponse"/></returns>
        public async Task<DescribeRabbitMQVipInstancesResponse> DescribeRabbitMQVipInstances(DescribeRabbitMQVipInstancesRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVipInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRabbitMQVipInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVipInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户已购的RabbitMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstancesResponse"/></returns>
        public DescribeRabbitMQVipInstancesResponse DescribeRabbitMQVipInstancesSync(DescribeRabbitMQVipInstancesRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVipInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRabbitMQVipInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVipInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询RabbitMQ vhost列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostResponse"/></returns>
        public async Task<DescribeRabbitMQVirtualHostResponse> DescribeRabbitMQVirtualHost(DescribeRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询RabbitMQ vhost列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostResponse"/></returns>
        public DescribeRabbitMQVirtualHostResponse DescribeRabbitMQVirtualHostSync(DescribeRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RabbitMQ专享版查询虚拟主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostListResponse"/></returns>
        public async Task<DescribeRabbitMQVirtualHostListResponse> DescribeRabbitMQVirtualHostList(DescribeRabbitMQVirtualHostListRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVirtualHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRabbitMQVirtualHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVirtualHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RabbitMQ专享版查询虚拟主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostListResponse"/></returns>
        public DescribeRabbitMQVirtualHostListResponse DescribeRabbitMQVirtualHostListSync(DescribeRabbitMQVirtualHostListRequest req)
        {
             JsonResponseModel<DescribeRabbitMQVirtualHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRabbitMQVirtualHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRabbitMQVirtualHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public async Task<DescribeRocketMQClusterResponse> DescribeRocketMQCluster(DescribeRocketMQClusterRequest req)
        {
             JsonResponseModel<DescribeRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public DescribeRocketMQClusterResponse DescribeRocketMQClusterSync(DescribeRocketMQClusterRequest req)
        {
             JsonResponseModel<DescribeRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClustersRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClustersResponse"/></returns>
        public async Task<DescribeRocketMQClustersResponse> DescribeRocketMQClusters(DescribeRocketMQClustersRequest req)
        {
             JsonResponseModel<DescribeRocketMQClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClustersRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClustersResponse"/></returns>
        public DescribeRocketMQClustersResponse DescribeRocketMQClustersSync(DescribeRocketMQClustersRequest req)
        {
             JsonResponseModel<DescribeRocketMQClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ消费组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQGroupsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQGroupsResponse"/></returns>
        public async Task<DescribeRocketMQGroupsResponse> DescribeRocketMQGroups(DescribeRocketMQGroupsRequest req)
        {
             JsonResponseModel<DescribeRocketMQGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ消费组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQGroupsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQGroupsResponse"/></returns>
        public DescribeRocketMQGroupsResponse DescribeRocketMQGroupsSync(DescribeRocketMQGroupsRequest req)
        {
             JsonResponseModel<DescribeRocketMQGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// rocketmq消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgResponse"/></returns>
        public async Task<DescribeRocketMQMsgResponse> DescribeRocketMQMsg(DescribeRocketMQMsgRequest req)
        {
             JsonResponseModel<DescribeRocketMQMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// rocketmq消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgResponse"/></returns>
        public DescribeRocketMQMsgResponse DescribeRocketMQMsgSync(DescribeRocketMQMsgRequest req)
        {
             JsonResponseModel<DescribeRocketMQMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQNamespacesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQNamespacesResponse"/></returns>
        public async Task<DescribeRocketMQNamespacesResponse> DescribeRocketMQNamespaces(DescribeRocketMQNamespacesRequest req)
        {
             JsonResponseModel<DescribeRocketMQNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQNamespacesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQNamespacesResponse"/></returns>
        public DescribeRocketMQNamespacesResponse DescribeRocketMQNamespacesSync(DescribeRocketMQNamespacesRequest req)
        {
             JsonResponseModel<DescribeRocketMQNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsResponse"/></returns>
        public async Task<DescribeRocketMQTopicsResponse> DescribeRocketMQTopics(DescribeRocketMQTopicsRequest req)
        {
             JsonResponseModel<DescribeRocketMQTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RocketMQ主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsResponse"/></returns>
        public DescribeRocketMQTopicsResponse DescribeRocketMQTopicsSync(DescribeRocketMQTopicsRequest req)
        {
             JsonResponseModel<DescribeRocketMQTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个RocketMQ专享集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstanceDetailResponse"/></returns>
        public async Task<DescribeRocketMQVipInstanceDetailResponse> DescribeRocketMQVipInstanceDetail(DescribeRocketMQVipInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeRocketMQVipInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQVipInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQVipInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个RocketMQ专享集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstanceDetailResponse"/></returns>
        public DescribeRocketMQVipInstanceDetailResponse DescribeRocketMQVipInstanceDetailSync(DescribeRocketMQVipInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeRocketMQVipInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQVipInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQVipInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户已购的RocketMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstancesResponse"/></returns>
        public async Task<DescribeRocketMQVipInstancesResponse> DescribeRocketMQVipInstances(DescribeRocketMQVipInstancesRequest req)
        {
             JsonResponseModel<DescribeRocketMQVipInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRocketMQVipInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQVipInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户已购的RocketMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstancesResponse"/></returns>
        public DescribeRocketMQVipInstancesResponse DescribeRocketMQVipInstancesSync(DescribeRocketMQVipInstancesRequest req)
        {
             JsonResponseModel<DescribeRocketMQVipInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRocketMQVipInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRocketMQVipInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public async Task<DescribeRolesResponse> DescribeRoles(DescribeRolesRequest req)
        {
             JsonResponseModel<DescribeRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public DescribeRolesResponse DescribeRolesSync(DescribeRolesRequest req)
        {
             JsonResponseModel<DescribeRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定环境和主题下的订阅者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionsResponse"/></returns>
        public async Task<DescribeSubscriptionsResponse> DescribeSubscriptions(DescribeSubscriptionsRequest req)
        {
             JsonResponseModel<DescribeSubscriptionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubscriptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscriptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定环境和主题下的订阅者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionsResponse"/></returns>
        public DescribeSubscriptionsResponse DescribeSubscriptionsSync(DescribeSubscriptionsRequest req)
        {
             JsonResponseModel<DescribeSubscriptionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubscriptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscriptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境下主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public async Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
             JsonResponseModel<DescribeTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境下主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
             JsonResponseModel<DescribeTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新Amqp集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAMQPClusterRequest"/></param>
        /// <returns><see cref="ModifyAMQPClusterResponse"/></returns>
        public async Task<ModifyAMQPClusterResponse> ModifyAMQPCluster(ModifyAMQPClusterRequest req)
        {
             JsonResponseModel<ModifyAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新Amqp集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAMQPClusterRequest"/></param>
        /// <returns><see cref="ModifyAMQPClusterResponse"/></returns>
        public ModifyAMQPClusterResponse ModifyAMQPClusterSync(ModifyAMQPClusterRequest req)
        {
             JsonResponseModel<ModifyAMQPClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAMQPCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAMQPClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 更新Amqp交换机
        /// </summary>
        /// <param name="req"><see cref="ModifyAMQPExchangeRequest"/></param>
        /// <returns><see cref="ModifyAMQPExchangeResponse"/></returns>
        public async Task<ModifyAMQPExchangeResponse> ModifyAMQPExchange(ModifyAMQPExchangeRequest req)
        {
             JsonResponseModel<ModifyAMQPExchangeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAMQPExchange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAMQPExchangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 更新Amqp交换机
        /// </summary>
        /// <param name="req"><see cref="ModifyAMQPExchangeRequest"/></param>
        /// <returns><see cref="ModifyAMQPExchangeResponse"/></returns>
        public ModifyAMQPExchangeResponse ModifyAMQPExchangeSync(ModifyAMQPExchangeRequest req)
        {
             JsonResponseModel<ModifyAMQPExchangeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAMQPExchange");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAMQPExchangeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 更新Amqp队列
        /// </summary>
        /// <param name="req"><see cref="ModifyAMQPQueueRequest"/></param>
        /// <returns><see cref="ModifyAMQPQueueResponse"/></returns>
        public async Task<ModifyAMQPQueueResponse> ModifyAMQPQueue(ModifyAMQPQueueRequest req)
        {
             JsonResponseModel<ModifyAMQPQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAMQPQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAMQPQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品下线了，对应的接口也要下线。
        /// 
        /// 更新Amqp队列
        /// </summary>
        /// <param name="req"><see cref="ModifyAMQPQueueRequest"/></param>
        /// <returns><see cref="ModifyAMQPQueueResponse"/></returns>
        public ModifyAMQPQueueResponse ModifyAMQPQueueSync(ModifyAMQPQueueRequest req)
        {
             JsonResponseModel<ModifyAMQPQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAMQPQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAMQPQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public async Task<ModifyClusterResponse> ModifyCluster(ModifyClusterRequest req)
        {
             JsonResponseModel<ModifyClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public ModifyClusterResponse ModifyClusterSync(ModifyClusterRequest req)
        {
             JsonResponseModel<ModifyClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改cmq队列属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public async Task<ModifyCmqQueueAttributeResponse> ModifyCmqQueueAttribute(ModifyCmqQueueAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqQueueAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCmqQueueAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqQueueAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改cmq队列属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public ModifyCmqQueueAttributeResponse ModifyCmqQueueAttributeSync(ModifyCmqQueueAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqQueueAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCmqQueueAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqQueueAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改cmq订阅属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public async Task<ModifyCmqSubscriptionAttributeResponse> ModifyCmqSubscriptionAttribute(ModifyCmqSubscriptionAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqSubscriptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCmqSubscriptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqSubscriptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改cmq订阅属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public ModifyCmqSubscriptionAttributeResponse ModifyCmqSubscriptionAttributeSync(ModifyCmqSubscriptionAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqSubscriptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCmqSubscriptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqSubscriptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改cmq主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public async Task<ModifyCmqTopicAttributeResponse> ModifyCmqTopicAttribute(ModifyCmqTopicAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqTopicAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCmqTopicAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqTopicAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改cmq主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public ModifyCmqTopicAttributeResponse ModifyCmqTopicAttributeSync(ModifyCmqTopicAttributeRequest req)
        {
             JsonResponseModel<ModifyCmqTopicAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCmqTopicAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCmqTopicAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定命名空间的属性值
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public async Task<ModifyEnvironmentAttributesResponse> ModifyEnvironmentAttributes(ModifyEnvironmentAttributesRequest req)
        {
             JsonResponseModel<ModifyEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定命名空间的属性值
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public ModifyEnvironmentAttributesResponse ModifyEnvironmentAttributesSync(ModifyEnvironmentAttributesRequest req)
        {
             JsonResponseModel<ModifyEnvironmentAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnvironmentAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public async Task<ModifyEnvironmentRoleResponse> ModifyEnvironmentRole(ModifyEnvironmentRoleRequest req)
        {
             JsonResponseModel<ModifyEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public ModifyEnvironmentRoleResponse ModifyEnvironmentRoleSync(ModifyEnvironmentRoleRequest req)
        {
             JsonResponseModel<ModifyEnvironmentRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnvironmentRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvironmentRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQUserResponse"/></returns>
        public async Task<ModifyRabbitMQUserResponse> ModifyRabbitMQUser(ModifyRabbitMQUserRequest req)
        {
             JsonResponseModel<ModifyRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQUserResponse"/></returns>
        public ModifyRabbitMQUserResponse ModifyRabbitMQUserSync(ModifyRabbitMQUserRequest req)
        {
             JsonResponseModel<ModifyRabbitMQUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRabbitMQUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRabbitMQUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVipInstanceResponse"/></returns>
        public async Task<ModifyRabbitMQVipInstanceResponse> ModifyRabbitMQVipInstance(ModifyRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<ModifyRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVipInstanceResponse"/></returns>
        public ModifyRabbitMQVipInstanceResponse ModifyRabbitMQVipInstanceSync(ModifyRabbitMQVipInstanceRequest req)
        {
             JsonResponseModel<ModifyRabbitMQVipInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRabbitMQVipInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRabbitMQVipInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVirtualHostResponse"/></returns>
        public async Task<ModifyRabbitMQVirtualHostResponse> ModifyRabbitMQVirtualHost(ModifyRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<ModifyRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVirtualHostResponse"/></returns>
        public ModifyRabbitMQVirtualHostResponse ModifyRabbitMQVirtualHostSync(ModifyRabbitMQVirtualHostRequest req)
        {
             JsonResponseModel<ModifyRabbitMQVirtualHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRabbitMQVirtualHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRabbitMQVirtualHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public async Task<ModifyRocketMQClusterResponse> ModifyRocketMQCluster(ModifyRocketMQClusterRequest req)
        {
             JsonResponseModel<ModifyRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public ModifyRocketMQClusterResponse ModifyRocketMQClusterSync(ModifyRocketMQClusterRequest req)
        {
             JsonResponseModel<ModifyRocketMQClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ消费组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public async Task<ModifyRocketMQGroupResponse> ModifyRocketMQGroup(ModifyRocketMQGroupRequest req)
        {
             JsonResponseModel<ModifyRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ消费组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public ModifyRocketMQGroupResponse ModifyRocketMQGroupSync(ModifyRocketMQGroupRequest req)
        {
             JsonResponseModel<ModifyRocketMQGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本API用于修改RocketMQ专享实例配置，可以支持实例规格、节点数和存储的升配和实例规格的降配。本API发起订单并成功支付后进入实例配置变更的流程，可通过DescribeRocketMQVipInstances查询实例是否已变更完成。
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceSpecResponse"/></returns>
        public async Task<ModifyRocketMQInstanceSpecResponse> ModifyRocketMQInstanceSpec(ModifyRocketMQInstanceSpecRequest req)
        {
             JsonResponseModel<ModifyRocketMQInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本API用于修改RocketMQ专享实例配置，可以支持实例规格、节点数和存储的升配和实例规格的降配。本API发起订单并成功支付后进入实例配置变更的流程，可通过DescribeRocketMQVipInstances查询实例是否已变更完成。
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceSpecResponse"/></returns>
        public ModifyRocketMQInstanceSpecResponse ModifyRocketMQInstanceSpecSync(ModifyRocketMQInstanceSpecRequest req)
        {
             JsonResponseModel<ModifyRocketMQInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public async Task<ModifyRocketMQNamespaceResponse> ModifyRocketMQNamespace(ModifyRocketMQNamespaceRequest req)
        {
             JsonResponseModel<ModifyRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public ModifyRocketMQNamespaceResponse ModifyRocketMQNamespaceSync(ModifyRocketMQNamespaceRequest req)
        {
             JsonResponseModel<ModifyRocketMQNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ主题信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public async Task<ModifyRocketMQTopicResponse> ModifyRocketMQTopic(ModifyRocketMQTopicRequest req)
        {
             JsonResponseModel<ModifyRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新RocketMQ主题信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public ModifyRocketMQTopicResponse ModifyRocketMQTopicSync(ModifyRocketMQTopicRequest req)
        {
             JsonResponseModel<ModifyRocketMQTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRocketMQTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRocketMQTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public async Task<ModifyRoleResponse> ModifyRole(ModifyRoleRequest req)
        {
             JsonResponseModel<ModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public ModifyRoleResponse ModifyRoleSync(ModifyRoleRequest req)
        {
             JsonResponseModel<ModifyRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改主题备注和分区数
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public async Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改主题备注和分区数
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送cmq主题消息
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public async Task<PublishCmqMsgResponse> PublishCmqMsg(PublishCmqMsgRequest req)
        {
             JsonResponseModel<PublishCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送cmq主题消息
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public PublishCmqMsgResponse PublishCmqMsgSync(PublishCmqMsgRequest req)
        {
             JsonResponseModel<PublishCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前 ReceiveMessage 接口只支持 Partitioned 类型的 Topic。该接口用于接收发送到指定 Partitioned Topic 中的消息，当 Partitioned Topic 中没有消息但还去尝试调用该接口时，会抛出 ReceiveTimeout 的异常。
        /// 
        /// 如何使用 BatchReceivePolicy：
        /// 
        /// BatchReceive 接口提供了如下三个参数：
        /// 
        /// ● MaxNumMessages: 即每次使用 BatchReceive 的时候，最多一次Receive接口返回多少条消息。
        /// ● MaxNumBytes：即每次使用 BatchReceive 的时候，最多一次Receive接口返回多大内容的消息，单位是：bytes。
        /// ● Timeout：即每次使用 BatchReceive 的时候，最多一次 Receive 接口的超时时间是多久，单位是：MS。
        /// 
        /// 默认如果上述三个参数都不指定，即关闭 BatchReceive 的特性。如果三个参数中的任意一个参数指定的数值大于 0，即开启 BatchReceive。BatchReceive 的结束条件为到达上述三个参数中任意一个指定的阈值。
        /// 
        /// 注意：MaxNumMessages 和 MaxNumBytes 每一次接收的最大消息同时受限于 ReceiveQueueSize 的大小，如果 ReceiveQueueSize 的大小设置为 5，MaxNumMessages 设置为10，那么一次 BatchReceive 接收的最多的消息是 5条，而不是10条。
        /// 
        /// 
        /// 
        /// BatchReceivePolicy 的接口会一次性返回多条消息：
        /// 
        /// 1. 多条消息的内容之间使用特殊字符 '###' 来进行分割，业务侧接收到消息之后，可以利用不同语言提供的 Split 工具分割不同的消息。
        /// 2. 多条消息的 MessageID 之间使用特殊字符 '###' 来进行分割，业务侧接收到消息之后，可以利用不同语言提供的 Split 工具分割不同的消息。（用于在调用 AcknowledgeMessage 接口中填入所需要的 MessageID 字段信息）
        /// </summary>
        /// <param name="req"><see cref="ReceiveMessageRequest"/></param>
        /// <returns><see cref="ReceiveMessageResponse"/></returns>
        public async Task<ReceiveMessageResponse> ReceiveMessage(ReceiveMessageRequest req)
        {
             JsonResponseModel<ReceiveMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReceiveMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReceiveMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前 ReceiveMessage 接口只支持 Partitioned 类型的 Topic。该接口用于接收发送到指定 Partitioned Topic 中的消息，当 Partitioned Topic 中没有消息但还去尝试调用该接口时，会抛出 ReceiveTimeout 的异常。
        /// 
        /// 如何使用 BatchReceivePolicy：
        /// 
        /// BatchReceive 接口提供了如下三个参数：
        /// 
        /// ● MaxNumMessages: 即每次使用 BatchReceive 的时候，最多一次Receive接口返回多少条消息。
        /// ● MaxNumBytes：即每次使用 BatchReceive 的时候，最多一次Receive接口返回多大内容的消息，单位是：bytes。
        /// ● Timeout：即每次使用 BatchReceive 的时候，最多一次 Receive 接口的超时时间是多久，单位是：MS。
        /// 
        /// 默认如果上述三个参数都不指定，即关闭 BatchReceive 的特性。如果三个参数中的任意一个参数指定的数值大于 0，即开启 BatchReceive。BatchReceive 的结束条件为到达上述三个参数中任意一个指定的阈值。
        /// 
        /// 注意：MaxNumMessages 和 MaxNumBytes 每一次接收的最大消息同时受限于 ReceiveQueueSize 的大小，如果 ReceiveQueueSize 的大小设置为 5，MaxNumMessages 设置为10，那么一次 BatchReceive 接收的最多的消息是 5条，而不是10条。
        /// 
        /// 
        /// 
        /// BatchReceivePolicy 的接口会一次性返回多条消息：
        /// 
        /// 1. 多条消息的内容之间使用特殊字符 '###' 来进行分割，业务侧接收到消息之后，可以利用不同语言提供的 Split 工具分割不同的消息。
        /// 2. 多条消息的 MessageID 之间使用特殊字符 '###' 来进行分割，业务侧接收到消息之后，可以利用不同语言提供的 Split 工具分割不同的消息。（用于在调用 AcknowledgeMessage 接口中填入所需要的 MessageID 字段信息）
        /// </summary>
        /// <param name="req"><see cref="ReceiveMessageRequest"/></param>
        /// <returns><see cref="ReceiveMessageResponse"/></returns>
        public ReceiveMessageResponse ReceiveMessageSync(ReceiveMessageRequest req)
        {
             JsonResponseModel<ReceiveMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReceiveMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReceiveMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间戳进行消息回溯，精确到毫秒
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public async Task<ResetMsgSubOffsetByTimestampResponse> ResetMsgSubOffsetByTimestamp(ResetMsgSubOffsetByTimestampRequest req)
        {
             JsonResponseModel<ResetMsgSubOffsetByTimestampResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetMsgSubOffsetByTimestamp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetMsgSubOffsetByTimestampResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间戳进行消息回溯，精确到毫秒
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public ResetMsgSubOffsetByTimestampResponse ResetMsgSubOffsetByTimestampSync(ResetMsgSubOffsetByTimestampRequest req)
        {
             JsonResponseModel<ResetMsgSubOffsetByTimestampResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetMsgSubOffsetByTimestamp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetMsgSubOffsetByTimestampResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置指定Group的消费位点到指定时间戳
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public async Task<ResetRocketMQConsumerOffSetResponse> ResetRocketMQConsumerOffSet(ResetRocketMQConsumerOffSetRequest req)
        {
             JsonResponseModel<ResetRocketMQConsumerOffSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetRocketMQConsumerOffSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRocketMQConsumerOffSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置指定Group的消费位点到指定时间戳
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public ResetRocketMQConsumerOffSetResponse ResetRocketMQConsumerOffSetSync(ResetRocketMQConsumerOffSetRequest req)
        {
             JsonResponseModel<ResetRocketMQConsumerOffSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetRocketMQConsumerOffSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRocketMQConsumerOffSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回溯cmq队列
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public async Task<RewindCmqQueueResponse> RewindCmqQueue(RewindCmqQueueRequest req)
        {
             JsonResponseModel<RewindCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RewindCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RewindCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回溯cmq队列
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public RewindCmqQueueResponse RewindCmqQueueSync(RewindCmqQueueRequest req)
        {
             JsonResponseModel<RewindCmqQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RewindCmqQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RewindCmqQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量发送消息
        /// 
        /// 注意：TDMQ 批量发送消息的接口是在 TDMQ-HTTP 的服务侧将消息打包为一个 Batch，然后将该 Batch 在服务内部当作一次 TCP 请求发送出去。所以在使用过程中，用户还是按照单条消息发送的逻辑，每一条消息是一个独立的 HTTP 的请求，在 TDMQ-HTTP 的服务内部，会将多个 HTTP 的请求聚合为一个 Batch 发送到服务端。即，批量发送消息在使用上与发送单条消息是一致的，batch 的聚合是在 TDMQ-HTTP 的服务内部完成的。
        /// </summary>
        /// <param name="req"><see cref="SendBatchMessagesRequest"/></param>
        /// <returns><see cref="SendBatchMessagesResponse"/></returns>
        public async Task<SendBatchMessagesResponse> SendBatchMessages(SendBatchMessagesRequest req)
        {
             JsonResponseModel<SendBatchMessagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendBatchMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendBatchMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量发送消息
        /// 
        /// 注意：TDMQ 批量发送消息的接口是在 TDMQ-HTTP 的服务侧将消息打包为一个 Batch，然后将该 Batch 在服务内部当作一次 TCP 请求发送出去。所以在使用过程中，用户还是按照单条消息发送的逻辑，每一条消息是一个独立的 HTTP 的请求，在 TDMQ-HTTP 的服务内部，会将多个 HTTP 的请求聚合为一个 Batch 发送到服务端。即，批量发送消息在使用上与发送单条消息是一致的，batch 的聚合是在 TDMQ-HTTP 的服务内部完成的。
        /// </summary>
        /// <param name="req"><see cref="SendBatchMessagesRequest"/></param>
        /// <returns><see cref="SendBatchMessagesResponse"/></returns>
        public SendBatchMessagesResponse SendBatchMessagesSync(SendBatchMessagesRequest req)
        {
             JsonResponseModel<SendBatchMessagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendBatchMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendBatchMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送cmq消息
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public async Task<SendCmqMsgResponse> SendCmqMsg(SendCmqMsgRequest req)
        {
             JsonResponseModel<SendCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送cmq消息
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public SendCmqMsgResponse SendCmqMsgSync(SendCmqMsgRequest req)
        {
             JsonResponseModel<SendCmqMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendCmqMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCmqMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送单条消息
        /// 不支持持久topic
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public async Task<SendMessagesResponse> SendMessages(SendMessagesRequest req)
        {
             JsonResponseModel<SendMessagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送单条消息
        /// 不支持持久topic
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public SendMessagesResponse SendMessagesSync(SendMessagesRequest req)
        {
             JsonResponseModel<SendMessagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendMessages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMessagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口仅用于测试发生消息，不能作为现网正式生产使用
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public async Task<SendMsgResponse> SendMsg(SendMsgRequest req)
        {
             JsonResponseModel<SendMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口仅用于测试发生消息，不能作为现网正式生产使用
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public SendMsgResponse SendMsgSync(SendMsgRequest req)
        {
             JsonResponseModel<SendMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送RocketMQ消息
        /// </summary>
        /// <param name="req"><see cref="SendRocketMQMessageRequest"/></param>
        /// <returns><see cref="SendRocketMQMessageResponse"/></returns>
        public async Task<SendRocketMQMessageResponse> SendRocketMQMessage(SendRocketMQMessageRequest req)
        {
             JsonResponseModel<SendRocketMQMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendRocketMQMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendRocketMQMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送RocketMQ消息
        /// </summary>
        /// <param name="req"><see cref="SendRocketMQMessageRequest"/></param>
        /// <returns><see cref="SendRocketMQMessageResponse"/></returns>
        public SendRocketMQMessageResponse SendRocketMQMessageSync(SendRocketMQMessageRequest req)
        {
             JsonResponseModel<SendRocketMQMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendRocketMQMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendRocketMQMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑cmq死信队列
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public async Task<UnbindCmqDeadLetterResponse> UnbindCmqDeadLetter(UnbindCmqDeadLetterRequest req)
        {
             JsonResponseModel<UnbindCmqDeadLetterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindCmqDeadLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCmqDeadLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑cmq死信队列
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public UnbindCmqDeadLetterResponse UnbindCmqDeadLetterSync(UnbindCmqDeadLetterRequest req)
        {
             JsonResponseModel<UnbindCmqDeadLetterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindCmqDeadLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindCmqDeadLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
