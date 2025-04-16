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
       private const string sdkVersion = "SDK_NET_3.0.1222";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdmqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 根据提供的 MessageID 确认指定 topic 中的消息
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public Task<AcknowledgeMessageResponse> AcknowledgeMessage(AcknowledgeMessageRequest req)
        {
            return InternalRequestAsync<AcknowledgeMessageResponse>(req, "AcknowledgeMessage");
        }

        /// <summary>
        /// 根据提供的 MessageID 确认指定 topic 中的消息
        /// </summary>
        /// <param name="req"><see cref="AcknowledgeMessageRequest"/></param>
        /// <returns><see cref="AcknowledgeMessageResponse"/></returns>
        public AcknowledgeMessageResponse AcknowledgeMessageSync(AcknowledgeMessageRequest req)
        {
            return InternalRequestAsync<AcknowledgeMessageResponse>(req, "AcknowledgeMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 清空cmq消息队列中的消息
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public Task<ClearCmqQueueResponse> ClearCmqQueue(ClearCmqQueueRequest req)
        {
            return InternalRequestAsync<ClearCmqQueueResponse>(req, "ClearCmqQueue");
        }

        /// <summary>
        /// 清空cmq消息队列中的消息
        /// </summary>
        /// <param name="req"><see cref="ClearCmqQueueRequest"/></param>
        /// <returns><see cref="ClearCmqQueueResponse"/></returns>
        public ClearCmqQueueResponse ClearCmqQueueSync(ClearCmqQueueRequest req)
        {
            return InternalRequestAsync<ClearCmqQueueResponse>(req, "ClearCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 清空订阅者消息标签
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public Task<ClearCmqSubscriptionFilterTagsResponse> ClearCmqSubscriptionFilterTags(ClearCmqSubscriptionFilterTagsRequest req)
        {
            return InternalRequestAsync<ClearCmqSubscriptionFilterTagsResponse>(req, "ClearCmqSubscriptionFilterTags");
        }

        /// <summary>
        /// 清空订阅者消息标签
        /// </summary>
        /// <param name="req"><see cref="ClearCmqSubscriptionFilterTagsRequest"/></param>
        /// <returns><see cref="ClearCmqSubscriptionFilterTagsResponse"/></returns>
        public ClearCmqSubscriptionFilterTagsResponse ClearCmqSubscriptionFilterTagsSync(ClearCmqSubscriptionFilterTagsRequest req)
        {
            return InternalRequestAsync<ClearCmqSubscriptionFilterTagsResponse>(req, "ClearCmqSubscriptionFilterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户的集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// 创建用户的集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建cmq队列接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public Task<CreateCmqQueueResponse> CreateCmqQueue(CreateCmqQueueRequest req)
        {
            return InternalRequestAsync<CreateCmqQueueResponse>(req, "CreateCmqQueue");
        }

        /// <summary>
        /// 创建cmq队列接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqQueueRequest"/></param>
        /// <returns><see cref="CreateCmqQueueResponse"/></returns>
        public CreateCmqQueueResponse CreateCmqQueueSync(CreateCmqQueueRequest req)
        {
            return InternalRequestAsync<CreateCmqQueueResponse>(req, "CreateCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建cmq订阅接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public Task<CreateCmqSubscribeResponse> CreateCmqSubscribe(CreateCmqSubscribeRequest req)
        {
            return InternalRequestAsync<CreateCmqSubscribeResponse>(req, "CreateCmqSubscribe");
        }

        /// <summary>
        /// 创建cmq订阅接口
        /// </summary>
        /// <param name="req"><see cref="CreateCmqSubscribeRequest"/></param>
        /// <returns><see cref="CreateCmqSubscribeResponse"/></returns>
        public CreateCmqSubscribeResponse CreateCmqSubscribeSync(CreateCmqSubscribeRequest req)
        {
            return InternalRequestAsync<CreateCmqSubscribeResponse>(req, "CreateCmqSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建cmq主题
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public Task<CreateCmqTopicResponse> CreateCmqTopic(CreateCmqTopicRequest req)
        {
            return InternalRequestAsync<CreateCmqTopicResponse>(req, "CreateCmqTopic");
        }

        /// <summary>
        /// 创建cmq主题
        /// </summary>
        /// <param name="req"><see cref="CreateCmqTopicRequest"/></param>
        /// <returns><see cref="CreateCmqTopicResponse"/></returns>
        public CreateCmqTopicResponse CreateCmqTopicSync(CreateCmqTopicRequest req)
        {
            return InternalRequestAsync<CreateCmqTopicResponse>(req, "CreateCmqTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在用户账户下创建消息队列 Tdmq 命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment");
        }

        /// <summary>
        /// 用于在用户账户下创建消息队列 Tdmq 命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建环境角色授权
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public Task<CreateEnvironmentRoleResponse> CreateEnvironmentRole(CreateEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentRoleResponse>(req, "CreateEnvironmentRole");
        }

        /// <summary>
        /// 创建环境角色授权
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateEnvironmentRoleResponse"/></returns>
        public CreateEnvironmentRoleResponse CreateEnvironmentRoleSync(CreateEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentRoleResponse>(req, "CreateEnvironmentRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建专业集群——预付费，仅通过api调用
        /// </summary>
        /// <param name="req"><see cref="CreateProClusterRequest"/></param>
        /// <returns><see cref="CreateProClusterResponse"/></returns>
        public Task<CreateProClusterResponse> CreateProCluster(CreateProClusterRequest req)
        {
            return InternalRequestAsync<CreateProClusterResponse>(req, "CreateProCluster");
        }

        /// <summary>
        /// 创建专业集群——预付费，仅通过api调用
        /// </summary>
        /// <param name="req"><see cref="CreateProClusterRequest"/></param>
        /// <returns><see cref="CreateProClusterResponse"/></returns>
        public CreateProClusterResponse CreateProClusterSync(CreateProClusterRequest req)
        {
            return InternalRequestAsync<CreateProClusterResponse>(req, "CreateProCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RabbitMQ路由关系
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQBindingRequest"/></param>
        /// <returns><see cref="CreateRabbitMQBindingResponse"/></returns>
        public Task<CreateRabbitMQBindingResponse> CreateRabbitMQBinding(CreateRabbitMQBindingRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQBindingResponse>(req, "CreateRabbitMQBinding");
        }

        /// <summary>
        /// 创建RabbitMQ路由关系
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQBindingRequest"/></param>
        /// <returns><see cref="CreateRabbitMQBindingResponse"/></returns>
        public CreateRabbitMQBindingResponse CreateRabbitMQBindingSync(CreateRabbitMQBindingRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQBindingResponse>(req, "CreateRabbitMQBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQUserResponse"/></returns>
        public Task<CreateRabbitMQUserResponse> CreateRabbitMQUser(CreateRabbitMQUserRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQUserResponse>(req, "CreateRabbitMQUser");
        }

        /// <summary>
        /// 创建RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQUserResponse"/></returns>
        public CreateRabbitMQUserResponse CreateRabbitMQUserSync(CreateRabbitMQUserRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQUserResponse>(req, "CreateRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVipInstanceResponse"/></returns>
        public Task<CreateRabbitMQVipInstanceResponse> CreateRabbitMQVipInstance(CreateRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVipInstanceResponse>(req, "CreateRabbitMQVipInstance");
        }

        /// <summary>
        /// 创建RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVipInstanceResponse"/></returns>
        public CreateRabbitMQVipInstanceResponse CreateRabbitMQVipInstanceSync(CreateRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVipInstanceResponse>(req, "CreateRabbitMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVirtualHostResponse"/></returns>
        public Task<CreateRabbitMQVirtualHostResponse> CreateRabbitMQVirtualHost(CreateRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVirtualHostResponse>(req, "CreateRabbitMQVirtualHost");
        }

        /// <summary>
        /// 创建RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQVirtualHostResponse"/></returns>
        public CreateRabbitMQVirtualHostResponse CreateRabbitMQVirtualHostSync(CreateRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQVirtualHostResponse>(req, "CreateRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于创建一个RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public Task<CreateRocketMQClusterResponse> CreateRocketMQCluster(CreateRocketMQClusterRequest req)
        {
            return InternalRequestAsync<CreateRocketMQClusterResponse>(req, "CreateRocketMQCluster");
        }

        /// <summary>
        /// 此接口用于创建一个RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQClusterRequest"/></param>
        /// <returns><see cref="CreateRocketMQClusterResponse"/></returns>
        public CreateRocketMQClusterResponse CreateRocketMQClusterSync(CreateRocketMQClusterRequest req)
        {
            return InternalRequestAsync<CreateRocketMQClusterResponse>(req, "CreateRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建环境角色授权
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateRocketMQEnvironmentRoleResponse"/></returns>
        public Task<CreateRocketMQEnvironmentRoleResponse> CreateRocketMQEnvironmentRole(CreateRocketMQEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<CreateRocketMQEnvironmentRoleResponse>(req, "CreateRocketMQEnvironmentRole");
        }

        /// <summary>
        /// 创建环境角色授权
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQEnvironmentRoleRequest"/></param>
        /// <returns><see cref="CreateRocketMQEnvironmentRoleResponse"/></returns>
        public CreateRocketMQEnvironmentRoleResponse CreateRocketMQEnvironmentRoleSync(CreateRocketMQEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<CreateRocketMQEnvironmentRoleResponse>(req, "CreateRocketMQEnvironmentRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public Task<CreateRocketMQGroupResponse> CreateRocketMQGroup(CreateRocketMQGroupRequest req)
        {
            return InternalRequestAsync<CreateRocketMQGroupResponse>(req, "CreateRocketMQGroup");
        }

        /// <summary>
        /// 创建RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQGroupRequest"/></param>
        /// <returns><see cref="CreateRocketMQGroupResponse"/></returns>
        public CreateRocketMQGroupResponse CreateRocketMQGroupSync(CreateRocketMQGroupRequest req)
        {
            return InternalRequestAsync<CreateRocketMQGroupResponse>(req, "CreateRocketMQGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public Task<CreateRocketMQNamespaceResponse> CreateRocketMQNamespace(CreateRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<CreateRocketMQNamespaceResponse>(req, "CreateRocketMQNamespace");
        }

        /// <summary>
        /// 创建RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="CreateRocketMQNamespaceResponse"/></returns>
        public CreateRocketMQNamespaceResponse CreateRocketMQNamespaceSync(CreateRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<CreateRocketMQNamespaceResponse>(req, "CreateRocketMQNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQRoleRequest"/></param>
        /// <returns><see cref="CreateRocketMQRoleResponse"/></returns>
        public Task<CreateRocketMQRoleResponse> CreateRocketMQRole(CreateRocketMQRoleRequest req)
        {
            return InternalRequestAsync<CreateRocketMQRoleResponse>(req, "CreateRocketMQRole");
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQRoleRequest"/></param>
        /// <returns><see cref="CreateRocketMQRoleResponse"/></returns>
        public CreateRocketMQRoleResponse CreateRocketMQRoleSync(CreateRocketMQRoleRequest req)
        {
            return InternalRequestAsync<CreateRocketMQRoleResponse>(req, "CreateRocketMQRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public Task<CreateRocketMQTopicResponse> CreateRocketMQTopic(CreateRocketMQTopicRequest req)
        {
            return InternalRequestAsync<CreateRocketMQTopicResponse>(req, "CreateRocketMQTopic");
        }

        /// <summary>
        /// 创建RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQTopicRequest"/></param>
        /// <returns><see cref="CreateRocketMQTopicResponse"/></returns>
        public CreateRocketMQTopicResponse CreateRocketMQTopicSync(CreateRocketMQTopicRequest req)
        {
            return InternalRequestAsync<CreateRocketMQTopicResponse>(req, "CreateRocketMQTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建RocketMQ专享实例
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRocketMQVipInstanceResponse"/></returns>
        public Task<CreateRocketMQVipInstanceResponse> CreateRocketMQVipInstance(CreateRocketMQVipInstanceRequest req)
        {
            return InternalRequestAsync<CreateRocketMQVipInstanceResponse>(req, "CreateRocketMQVipInstance");
        }

        /// <summary>
        /// 创建RocketMQ专享实例
        /// </summary>
        /// <param name="req"><see cref="CreateRocketMQVipInstanceRequest"/></param>
        /// <returns><see cref="CreateRocketMQVipInstanceResponse"/></returns>
        public CreateRocketMQVipInstanceResponse CreateRocketMQVipInstanceSync(CreateRocketMQVipInstanceRequest req)
        {
            return InternalRequestAsync<CreateRocketMQVipInstanceResponse>(req, "CreateRocketMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole");
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个主题的订阅关系
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest req)
        {
            return InternalRequestAsync<CreateSubscriptionResponse>(req, "CreateSubscription");
        }

        /// <summary>
        /// 创建一个主题的订阅关系
        /// </summary>
        /// <param name="req"><see cref="CreateSubscriptionRequest"/></param>
        /// <returns><see cref="CreateSubscriptionResponse"/></returns>
        public CreateSubscriptionResponse CreateSubscriptionSync(CreateSubscriptionRequest req)
        {
            return InternalRequestAsync<CreateSubscriptionResponse>(req, "CreateSubscription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增指定分区、类型的消息主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// 新增指定分区、类型的消息主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除cmq队列
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public Task<DeleteCmqQueueResponse> DeleteCmqQueue(DeleteCmqQueueRequest req)
        {
            return InternalRequestAsync<DeleteCmqQueueResponse>(req, "DeleteCmqQueue");
        }

        /// <summary>
        /// 删除cmq队列
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqQueueRequest"/></param>
        /// <returns><see cref="DeleteCmqQueueResponse"/></returns>
        public DeleteCmqQueueResponse DeleteCmqQueueSync(DeleteCmqQueueRequest req)
        {
            return InternalRequestAsync<DeleteCmqQueueResponse>(req, "DeleteCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除cmq订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public Task<DeleteCmqSubscribeResponse> DeleteCmqSubscribe(DeleteCmqSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteCmqSubscribeResponse>(req, "DeleteCmqSubscribe");
        }

        /// <summary>
        /// 删除cmq订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqSubscribeRequest"/></param>
        /// <returns><see cref="DeleteCmqSubscribeResponse"/></returns>
        public DeleteCmqSubscribeResponse DeleteCmqSubscribeSync(DeleteCmqSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteCmqSubscribeResponse>(req, "DeleteCmqSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除cmq主题
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public Task<DeleteCmqTopicResponse> DeleteCmqTopic(DeleteCmqTopicRequest req)
        {
            return InternalRequestAsync<DeleteCmqTopicResponse>(req, "DeleteCmqTopic");
        }

        /// <summary>
        /// 删除cmq主题
        /// </summary>
        /// <param name="req"><see cref="DeleteCmqTopicRequest"/></param>
        /// <returns><see cref="DeleteCmqTopicResponse"/></returns>
        public DeleteCmqTopicResponse DeleteCmqTopicSync(DeleteCmqTopicRequest req)
        {
            return InternalRequestAsync<DeleteCmqTopicResponse>(req, "DeleteCmqTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public Task<DeleteEnvironmentRolesResponse> DeleteEnvironmentRoles(DeleteEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentRolesResponse>(req, "DeleteEnvironmentRoles");
        }

        /// <summary>
        /// 删除环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentRolesResponse"/></returns>
        public DeleteEnvironmentRolesResponse DeleteEnvironmentRolesSync(DeleteEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentRolesResponse>(req, "DeleteEnvironmentRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除租户下的命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public Task<DeleteEnvironmentsResponse> DeleteEnvironments(DeleteEnvironmentsRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentsResponse>(req, "DeleteEnvironments");
        }

        /// <summary>
        /// 批量删除租户下的命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public DeleteEnvironmentsResponse DeleteEnvironmentsSync(DeleteEnvironmentsRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentsResponse>(req, "DeleteEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除专业集群——预付费，仅通过API 调用
        /// </summary>
        /// <param name="req"><see cref="DeleteProClusterRequest"/></param>
        /// <returns><see cref="DeleteProClusterResponse"/></returns>
        public Task<DeleteProClusterResponse> DeleteProCluster(DeleteProClusterRequest req)
        {
            return InternalRequestAsync<DeleteProClusterResponse>(req, "DeleteProCluster");
        }

        /// <summary>
        /// 删除专业集群——预付费，仅通过API 调用
        /// </summary>
        /// <param name="req"><see cref="DeleteProClusterRequest"/></param>
        /// <returns><see cref="DeleteProClusterResponse"/></returns>
        public DeleteProClusterResponse DeleteProClusterSync(DeleteProClusterRequest req)
        {
            return InternalRequestAsync<DeleteProClusterResponse>(req, "DeleteProCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑RabbitMQ路由关系
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQBindingRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQBindingResponse"/></returns>
        public Task<DeleteRabbitMQBindingResponse> DeleteRabbitMQBinding(DeleteRabbitMQBindingRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQBindingResponse>(req, "DeleteRabbitMQBinding");
        }

        /// <summary>
        /// 解绑RabbitMQ路由关系
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQBindingRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQBindingResponse"/></returns>
        public DeleteRabbitMQBindingResponse DeleteRabbitMQBindingSync(DeleteRabbitMQBindingRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQBindingResponse>(req, "DeleteRabbitMQBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RabbitMQ的权限
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQPermissionRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQPermissionResponse"/></returns>
        public Task<DeleteRabbitMQPermissionResponse> DeleteRabbitMQPermission(DeleteRabbitMQPermissionRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQPermissionResponse>(req, "DeleteRabbitMQPermission");
        }

        /// <summary>
        /// 删除RabbitMQ的权限
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQPermissionRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQPermissionResponse"/></returns>
        public DeleteRabbitMQPermissionResponse DeleteRabbitMQPermissionSync(DeleteRabbitMQPermissionRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQPermissionResponse>(req, "DeleteRabbitMQPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQUserResponse"/></returns>
        public Task<DeleteRabbitMQUserResponse> DeleteRabbitMQUser(DeleteRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQUserResponse>(req, "DeleteRabbitMQUser");
        }

        /// <summary>
        /// 删除RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQUserResponse"/></returns>
        public DeleteRabbitMQUserResponse DeleteRabbitMQUserSync(DeleteRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQUserResponse>(req, "DeleteRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVipInstanceResponse"/></returns>
        public Task<DeleteRabbitMQVipInstanceResponse> DeleteRabbitMQVipInstance(DeleteRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVipInstanceResponse>(req, "DeleteRabbitMQVipInstance");
        }

        /// <summary>
        /// 删除RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVipInstanceResponse"/></returns>
        public DeleteRabbitMQVipInstanceResponse DeleteRabbitMQVipInstanceSync(DeleteRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVipInstanceResponse>(req, "DeleteRabbitMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVirtualHostResponse"/></returns>
        public Task<DeleteRabbitMQVirtualHostResponse> DeleteRabbitMQVirtualHost(DeleteRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVirtualHostResponse>(req, "DeleteRabbitMQVirtualHost");
        }

        /// <summary>
        /// 删除RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQVirtualHostResponse"/></returns>
        public DeleteRabbitMQVirtualHostResponse DeleteRabbitMQVirtualHostSync(DeleteRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQVirtualHostResponse>(req, "DeleteRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public Task<DeleteRocketMQClusterResponse> DeleteRocketMQCluster(DeleteRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQClusterResponse>(req, "DeleteRocketMQCluster");
        }

        /// <summary>
        /// 删除RocketMQ集群
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQClusterRequest"/></param>
        /// <returns><see cref="DeleteRocketMQClusterResponse"/></returns>
        public DeleteRocketMQClusterResponse DeleteRocketMQClusterSync(DeleteRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQClusterResponse>(req, "DeleteRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteRocketMQEnvironmentRolesResponse"/></returns>
        public Task<DeleteRocketMQEnvironmentRolesResponse> DeleteRocketMQEnvironmentRoles(DeleteRocketMQEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQEnvironmentRolesResponse>(req, "DeleteRocketMQEnvironmentRoles");
        }

        /// <summary>
        /// 删除环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DeleteRocketMQEnvironmentRolesResponse"/></returns>
        public DeleteRocketMQEnvironmentRolesResponse DeleteRocketMQEnvironmentRolesSync(DeleteRocketMQEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQEnvironmentRolesResponse>(req, "DeleteRocketMQEnvironmentRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public Task<DeleteRocketMQGroupResponse> DeleteRocketMQGroup(DeleteRocketMQGroupRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQGroupResponse>(req, "DeleteRocketMQGroup");
        }

        /// <summary>
        /// 删除RocketMQ消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQGroupRequest"/></param>
        /// <returns><see cref="DeleteRocketMQGroupResponse"/></returns>
        public DeleteRocketMQGroupResponse DeleteRocketMQGroupSync(DeleteRocketMQGroupRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQGroupResponse>(req, "DeleteRocketMQGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public Task<DeleteRocketMQNamespaceResponse> DeleteRocketMQNamespace(DeleteRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQNamespaceResponse>(req, "DeleteRocketMQNamespace");
        }

        /// <summary>
        /// 删除RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQNamespaceResponse"/></returns>
        public DeleteRocketMQNamespaceResponse DeleteRocketMQNamespaceSync(DeleteRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQNamespaceResponse>(req, "DeleteRocketMQNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除角色，支持批量。
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQRolesRequest"/></param>
        /// <returns><see cref="DeleteRocketMQRolesResponse"/></returns>
        public Task<DeleteRocketMQRolesResponse> DeleteRocketMQRoles(DeleteRocketMQRolesRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQRolesResponse>(req, "DeleteRocketMQRoles");
        }

        /// <summary>
        /// 删除角色，支持批量。
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQRolesRequest"/></param>
        /// <returns><see cref="DeleteRocketMQRolesResponse"/></returns>
        public DeleteRocketMQRolesResponse DeleteRocketMQRolesSync(DeleteRocketMQRolesRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQRolesResponse>(req, "DeleteRocketMQRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public Task<DeleteRocketMQTopicResponse> DeleteRocketMQTopic(DeleteRocketMQTopicRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQTopicResponse>(req, "DeleteRocketMQTopic");
        }

        /// <summary>
        /// 删除RocketMQ主题
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQTopicRequest"/></param>
        /// <returns><see cref="DeleteRocketMQTopicResponse"/></returns>
        public DeleteRocketMQTopicResponse DeleteRocketMQTopicSync(DeleteRocketMQTopicRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQTopicResponse>(req, "DeleteRocketMQTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除RocketMQ专享实例
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQVipInstanceResponse"/></returns>
        public Task<DeleteRocketMQVipInstanceResponse> DeleteRocketMQVipInstance(DeleteRocketMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQVipInstanceResponse>(req, "DeleteRocketMQVipInstance");
        }

        /// <summary>
        /// 删除RocketMQ专享实例
        /// </summary>
        /// <param name="req"><see cref="DeleteRocketMQVipInstanceRequest"/></param>
        /// <returns><see cref="DeleteRocketMQVipInstanceResponse"/></returns>
        public DeleteRocketMQVipInstanceResponse DeleteRocketMQVipInstanceSync(DeleteRocketMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DeleteRocketMQVipInstanceResponse>(req, "DeleteRocketMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除角色，支持批量。
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public Task<DeleteRolesResponse> DeleteRoles(DeleteRolesRequest req)
        {
            return InternalRequestAsync<DeleteRolesResponse>(req, "DeleteRoles");
        }

        /// <summary>
        /// 删除角色，支持批量。
        /// </summary>
        /// <param name="req"><see cref="DeleteRolesRequest"/></param>
        /// <returns><see cref="DeleteRolesResponse"/></returns>
        public DeleteRolesResponse DeleteRolesSync(DeleteRolesRequest req)
        {
            return InternalRequestAsync<DeleteRolesResponse>(req, "DeleteRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除订阅关系
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscriptionsRequest"/></param>
        /// <returns><see cref="DeleteSubscriptionsResponse"/></returns>
        public Task<DeleteSubscriptionsResponse> DeleteSubscriptions(DeleteSubscriptionsRequest req)
        {
            return InternalRequestAsync<DeleteSubscriptionsResponse>(req, "DeleteSubscriptions");
        }

        /// <summary>
        /// 删除订阅关系
        /// </summary>
        /// <param name="req"><see cref="DeleteSubscriptionsRequest"/></param>
        /// <returns><see cref="DeleteSubscriptionsResponse"/></returns>
        public DeleteSubscriptionsResponse DeleteSubscriptionsSync(DeleteSubscriptionsRequest req)
        {
            return InternalRequestAsync<DeleteSubscriptionsResponse>(req, "DeleteSubscriptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除topics
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicsRequest"/></param>
        /// <returns><see cref="DeleteTopicsResponse"/></returns>
        public Task<DeleteTopicsResponse> DeleteTopics(DeleteTopicsRequest req)
        {
            return InternalRequestAsync<DeleteTopicsResponse>(req, "DeleteTopics");
        }

        /// <summary>
        /// 批量删除topics
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicsRequest"/></param>
        /// <returns><see cref="DeleteTopicsResponse"/></returns>
        public DeleteTopicsResponse DeleteTopicsSync(DeleteTopicsRequest req)
        {
            return InternalRequestAsync<DeleteTopicsResponse>(req, "DeleteTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 历史原因，该接口位于tdmq-manager，目前rabbitmq产品没有使用该接口，当前使用的是DescribeRabbitMQVipInstances。不过从调用链上看，线网还有请求流程，所以走预下线流程。
        /// 
        /// 获取amqp集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPClustersRequest"/></param>
        /// <returns><see cref="DescribeAMQPClustersResponse"/></returns>
        public Task<DescribeAMQPClustersResponse> DescribeAMQPClusters(DescribeAMQPClustersRequest req)
        {
            return InternalRequestAsync<DescribeAMQPClustersResponse>(req, "DescribeAMQPClusters");
        }

        /// <summary>
        /// 历史原因，该接口位于tdmq-manager，目前rabbitmq产品没有使用该接口，当前使用的是DescribeRabbitMQVipInstances。不过从调用链上看，线网还有请求流程，所以走预下线流程。
        /// 
        /// 获取amqp集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAMQPClustersRequest"/></param>
        /// <returns><see cref="DescribeAMQPClustersResponse"/></returns>
        public DescribeAMQPClustersResponse DescribeAMQPClustersSync(DescribeAMQPClustersRequest req)
        {
            return InternalRequestAsync<DescribeAMQPClustersResponse>(req, "DescribeAMQPClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某个租户的虚拟集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAllTenantsRequest"/></param>
        /// <returns><see cref="DescribeAllTenantsResponse"/></returns>
        public Task<DescribeAllTenantsResponse> DescribeAllTenants(DescribeAllTenantsRequest req)
        {
            return InternalRequestAsync<DescribeAllTenantsResponse>(req, "DescribeAllTenants");
        }

        /// <summary>
        /// 获取某个租户的虚拟集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAllTenantsRequest"/></param>
        /// <returns><see cref="DescribeAllTenantsResponse"/></returns>
        public DescribeAllTenantsResponse DescribeAllTenantsSync(DescribeAllTenantsRequest req)
        {
            return InternalRequestAsync<DescribeAllTenantsResponse>(req, "DescribeAllTenants")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户绑定的专享集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindClustersRequest"/></param>
        /// <returns><see cref="DescribeBindClustersResponse"/></returns>
        public Task<DescribeBindClustersResponse> DescribeBindClusters(DescribeBindClustersRequest req)
        {
            return InternalRequestAsync<DescribeBindClustersResponse>(req, "DescribeBindClusters");
        }

        /// <summary>
        /// 获取用户绑定的专享集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindClustersRequest"/></param>
        /// <returns><see cref="DescribeBindClustersResponse"/></returns>
        public DescribeBindClustersResponse DescribeBindClustersSync(DescribeBindClustersRequest req)
        {
            return InternalRequestAsync<DescribeBindClustersResponse>(req, "DescribeBindClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取租户VPC绑定关系
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public Task<DescribeBindVpcsResponse> DescribeBindVpcs(DescribeBindVpcsRequest req)
        {
            return InternalRequestAsync<DescribeBindVpcsResponse>(req, "DescribeBindVpcs");
        }

        /// <summary>
        /// 获取租户VPC绑定关系
        /// </summary>
        /// <param name="req"><see cref="DescribeBindVpcsRequest"/></param>
        /// <returns><see cref="DescribeBindVpcsResponse"/></returns>
        public DescribeBindVpcsResponse DescribeBindVpcsSync(DescribeBindVpcsRequest req)
        {
            return InternalRequestAsync<DescribeBindVpcsResponse>(req, "DescribeBindVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail");
        }

        /// <summary>
        /// 获取集群的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询cmq队列详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public Task<DescribeCmqQueueDetailResponse> DescribeCmqQueueDetail(DescribeCmqQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueueDetailResponse>(req, "DescribeCmqQueueDetail");
        }

        /// <summary>
        /// 查询cmq队列详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqQueueDetailResponse"/></returns>
        public DescribeCmqQueueDetailResponse DescribeCmqQueueDetailSync(DescribeCmqQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueueDetailResponse>(req, "DescribeCmqQueueDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询cmq全量队列
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqQueuesResponse"/></returns>
        public Task<DescribeCmqQueuesResponse> DescribeCmqQueues(DescribeCmqQueuesRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueuesResponse>(req, "DescribeCmqQueues");
        }

        /// <summary>
        /// 查询cmq全量队列
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqQueuesRequest"/></param>
        /// <returns><see cref="DescribeCmqQueuesResponse"/></returns>
        public DescribeCmqQueuesResponse DescribeCmqQueuesSync(DescribeCmqQueuesRequest req)
        {
            return InternalRequestAsync<DescribeCmqQueuesResponse>(req, "DescribeCmqQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询cmq订阅详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public Task<DescribeCmqSubscriptionDetailResponse> DescribeCmqSubscriptionDetail(DescribeCmqSubscriptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqSubscriptionDetailResponse>(req, "DescribeCmqSubscriptionDetail");
        }

        /// <summary>
        /// 查询cmq订阅详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqSubscriptionDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqSubscriptionDetailResponse"/></returns>
        public DescribeCmqSubscriptionDetailResponse DescribeCmqSubscriptionDetailSync(DescribeCmqSubscriptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqSubscriptionDetailResponse>(req, "DescribeCmqSubscriptionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询cmq主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public Task<DescribeCmqTopicDetailResponse> DescribeCmqTopicDetail(DescribeCmqTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicDetailResponse>(req, "DescribeCmqTopicDetail");
        }

        /// <summary>
        /// 查询cmq主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicDetailRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicDetailResponse"/></returns>
        public DescribeCmqTopicDetailResponse DescribeCmqTopicDetailSync(DescribeCmqTopicDetailRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicDetailResponse>(req, "DescribeCmqTopicDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 枚举cmq全量主题
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicsRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicsResponse"/></returns>
        public Task<DescribeCmqTopicsResponse> DescribeCmqTopics(DescribeCmqTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicsResponse>(req, "DescribeCmqTopics");
        }

        /// <summary>
        /// 枚举cmq全量主题
        /// </summary>
        /// <param name="req"><see cref="DescribeCmqTopicsRequest"/></param>
        /// <returns><see cref="DescribeCmqTopicsResponse"/></returns>
        public DescribeCmqTopicsResponse DescribeCmqTopicsSync(DescribeCmqTopicsRequest req)
        {
            return InternalRequestAsync<DescribeCmqTopicsResponse>(req, "DescribeCmqTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定命名空间的属性
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public Task<DescribeEnvironmentAttributesResponse> DescribeEnvironmentAttributes(DescribeEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentAttributesResponse>(req, "DescribeEnvironmentAttributes");
        }

        /// <summary>
        /// 获取指定命名空间的属性
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentAttributesResponse"/></returns>
        public DescribeEnvironmentAttributesResponse DescribeEnvironmentAttributesSync(DescribeEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentAttributesResponse>(req, "DescribeEnvironmentAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取命名空间角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentRolesResponse"/></returns>
        public Task<DescribeEnvironmentRolesResponse> DescribeEnvironmentRoles(DescribeEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentRolesResponse>(req, "DescribeEnvironmentRoles");
        }

        /// <summary>
        /// 获取命名空间角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentRolesResponse"/></returns>
        public DescribeEnvironmentRolesResponse DescribeEnvironmentRolesSync(DescribeEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentRolesResponse>(req, "DescribeEnvironmentRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取租户下命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// 获取租户下命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消息轨迹
        /// </summary>
        /// <param name="req"><see cref="DescribeMqMsgTraceRequest"/></param>
        /// <returns><see cref="DescribeMqMsgTraceResponse"/></returns>
        public Task<DescribeMqMsgTraceResponse> DescribeMqMsgTrace(DescribeMqMsgTraceRequest req)
        {
            return InternalRequestAsync<DescribeMqMsgTraceResponse>(req, "DescribeMqMsgTrace");
        }

        /// <summary>
        /// 查询消息轨迹
        /// </summary>
        /// <param name="req"><see cref="DescribeMqMsgTraceRequest"/></param>
        /// <returns><see cref="DescribeMqMsgTraceResponse"/></returns>
        public DescribeMqMsgTraceResponse DescribeMqMsgTraceSync(DescribeMqMsgTraceRequest req)
        {
            return InternalRequestAsync<DescribeMqMsgTraceResponse>(req, "DescribeMqMsgTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRequest"/></param>
        /// <returns><see cref="DescribeMsgResponse"/></returns>
        public Task<DescribeMsgResponse> DescribeMsg(DescribeMsgRequest req)
        {
            return InternalRequestAsync<DescribeMsgResponse>(req, "DescribeMsg");
        }

        /// <summary>
        /// 消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRequest"/></param>
        /// <returns><see cref="DescribeMsgResponse"/></returns>
        public DescribeMsgResponse DescribeMsgSync(DescribeMsgRequest req)
        {
            return InternalRequestAsync<DescribeMsgResponse>(req, "DescribeMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消息轨迹
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgTraceRequest"/></param>
        /// <returns><see cref="DescribeMsgTraceResponse"/></returns>
        public Task<DescribeMsgTraceResponse> DescribeMsgTrace(DescribeMsgTraceRequest req)
        {
            return InternalRequestAsync<DescribeMsgTraceResponse>(req, "DescribeMsgTrace");
        }

        /// <summary>
        /// 查询消息轨迹
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgTraceRequest"/></param>
        /// <returns><see cref="DescribeMsgTraceResponse"/></returns>
        public DescribeMsgTraceResponse DescribeMsgTraceSync(DescribeMsgTraceRequest req)
        {
            return InternalRequestAsync<DescribeMsgTraceResponse>(req, "DescribeMsgTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运营端获取命名空间bundle列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceBundlesOptRequest"/></param>
        /// <returns><see cref="DescribeNamespaceBundlesOptResponse"/></returns>
        public Task<DescribeNamespaceBundlesOptResponse> DescribeNamespaceBundlesOpt(DescribeNamespaceBundlesOptRequest req)
        {
            return InternalRequestAsync<DescribeNamespaceBundlesOptResponse>(req, "DescribeNamespaceBundlesOpt");
        }

        /// <summary>
        /// 运营端获取命名空间bundle列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceBundlesOptRequest"/></param>
        /// <returns><see cref="DescribeNamespaceBundlesOptResponse"/></returns>
        public DescribeNamespaceBundlesOptResponse DescribeNamespaceBundlesOptSync(DescribeNamespaceBundlesOptRequest req)
        {
            return InternalRequestAsync<DescribeNamespaceBundlesOptResponse>(req, "DescribeNamespaceBundlesOpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运营端获节点健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeHealthOptRequest"/></param>
        /// <returns><see cref="DescribeNodeHealthOptResponse"/></returns>
        public Task<DescribeNodeHealthOptResponse> DescribeNodeHealthOpt(DescribeNodeHealthOptRequest req)
        {
            return InternalRequestAsync<DescribeNodeHealthOptResponse>(req, "DescribeNodeHealthOpt");
        }

        /// <summary>
        /// 运营端获节点健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeHealthOptRequest"/></param>
        /// <returns><see cref="DescribeNodeHealthOptResponse"/></returns>
        public DescribeNodeHealthOptResponse DescribeNodeHealthOptSync(DescribeNodeHealthOptRequest req)
        {
            return InternalRequestAsync<DescribeNodeHealthOptResponse>(req, "DescribeNodeHealthOpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取消息生产概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public Task<DescribePublisherSummaryResponse> DescribePublisherSummary(DescribePublisherSummaryRequest req)
        {
            return InternalRequestAsync<DescribePublisherSummaryResponse>(req, "DescribePublisherSummary");
        }

        /// <summary>
        /// 获取消息生产概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublisherSummaryRequest"/></param>
        /// <returns><see cref="DescribePublisherSummaryResponse"/></returns>
        public DescribePublisherSummaryResponse DescribePublisherSummarySync(DescribePublisherSummaryRequest req)
        {
            return InternalRequestAsync<DescribePublisherSummaryResponse>(req, "DescribePublisherSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取生产者信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public Task<DescribePublishersResponse> DescribePublishers(DescribePublishersRequest req)
        {
            return InternalRequestAsync<DescribePublishersResponse>(req, "DescribePublishers");
        }

        /// <summary>
        /// 获取生产者信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublishersRequest"/></param>
        /// <returns><see cref="DescribePublishersResponse"/></returns>
        public DescribePublishersResponse DescribePublishersSync(DescribePublishersRequest req)
        {
            return InternalRequestAsync<DescribePublishersResponse>(req, "DescribePublishers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Pulsar专业版集群实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstanceDetailResponse"/></returns>
        public Task<DescribePulsarProInstanceDetailResponse> DescribePulsarProInstanceDetail(DescribePulsarProInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstanceDetailResponse>(req, "DescribePulsarProInstanceDetail");
        }

        /// <summary>
        /// 获取Pulsar专业版集群实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstanceDetailResponse"/></returns>
        public DescribePulsarProInstanceDetailResponse DescribePulsarProInstanceDetailSync(DescribePulsarProInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstanceDetailResponse>(req, "DescribePulsarProInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户已购的Pulsar专业版实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstancesRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstancesResponse"/></returns>
        public Task<DescribePulsarProInstancesResponse> DescribePulsarProInstances(DescribePulsarProInstancesRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstancesResponse>(req, "DescribePulsarProInstances");
        }

        /// <summary>
        /// 查询用户已购的Pulsar专业版实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePulsarProInstancesRequest"/></param>
        /// <returns><see cref="DescribePulsarProInstancesResponse"/></returns>
        public DescribePulsarProInstancesResponse DescribePulsarProInstancesSync(DescribePulsarProInstancesRequest req)
        {
            return InternalRequestAsync<DescribePulsarProInstancesResponse>(req, "DescribePulsarProInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询RabbitMQ路由关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQBindingsRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQBindingsResponse"/></returns>
        public Task<DescribeRabbitMQBindingsResponse> DescribeRabbitMQBindings(DescribeRabbitMQBindingsRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQBindingsResponse>(req, "DescribeRabbitMQBindings");
        }

        /// <summary>
        /// 查询RabbitMQ路由关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQBindingsRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQBindingsResponse"/></returns>
        public DescribeRabbitMQBindingsResponse DescribeRabbitMQBindingsSync(DescribeRabbitMQBindingsRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQBindingsResponse>(req, "DescribeRabbitMQBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询RabbitMQ exchange 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQExchangesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQExchangesResponse"/></returns>
        public Task<DescribeRabbitMQExchangesResponse> DescribeRabbitMQExchanges(DescribeRabbitMQExchangesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQExchangesResponse>(req, "DescribeRabbitMQExchanges");
        }

        /// <summary>
        /// 查询RabbitMQ exchange 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQExchangesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQExchangesResponse"/></returns>
        public DescribeRabbitMQExchangesResponse DescribeRabbitMQExchangesSync(DescribeRabbitMQExchangesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQExchangesResponse>(req, "DescribeRabbitMQExchanges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RabbitMQ专享版查询节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQNodeListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQNodeListResponse"/></returns>
        public Task<DescribeRabbitMQNodeListResponse> DescribeRabbitMQNodeList(DescribeRabbitMQNodeListRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQNodeListResponse>(req, "DescribeRabbitMQNodeList");
        }

        /// <summary>
        /// RabbitMQ专享版查询节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQNodeListRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQNodeListResponse"/></returns>
        public DescribeRabbitMQNodeListResponse DescribeRabbitMQNodeListSync(DescribeRabbitMQNodeListRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQNodeListResponse>(req, "DescribeRabbitMQNodeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询RabbitMQ权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQPermissionRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQPermissionResponse"/></returns>
        public Task<DescribeRabbitMQPermissionResponse> DescribeRabbitMQPermission(DescribeRabbitMQPermissionRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQPermissionResponse>(req, "DescribeRabbitMQPermission");
        }

        /// <summary>
        /// 查询RabbitMQ权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQPermissionRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQPermissionResponse"/></returns>
        public DescribeRabbitMQPermissionResponse DescribeRabbitMQPermissionSync(DescribeRabbitMQPermissionRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQPermissionResponse>(req, "DescribeRabbitMQPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询RabbitMQ队列详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQQueueDetailResponse"/></returns>
        public Task<DescribeRabbitMQQueueDetailResponse> DescribeRabbitMQQueueDetail(DescribeRabbitMQQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQQueueDetailResponse>(req, "DescribeRabbitMQQueueDetail");
        }

        /// <summary>
        /// 查询RabbitMQ队列详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQQueueDetailResponse"/></returns>
        public DescribeRabbitMQQueueDetailResponse DescribeRabbitMQQueueDetailSync(DescribeRabbitMQQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQQueueDetailResponse>(req, "DescribeRabbitMQQueueDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询RabbitMQ队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQQueuesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQQueuesResponse"/></returns>
        public Task<DescribeRabbitMQQueuesResponse> DescribeRabbitMQQueues(DescribeRabbitMQQueuesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQQueuesResponse>(req, "DescribeRabbitMQQueues");
        }

        /// <summary>
        /// 查询RabbitMQ队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQQueuesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQQueuesResponse"/></returns>
        public DescribeRabbitMQQueuesResponse DescribeRabbitMQQueuesSync(DescribeRabbitMQQueuesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQQueuesResponse>(req, "DescribeRabbitMQQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询RabbitMQ用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQUserResponse"/></returns>
        public Task<DescribeRabbitMQUserResponse> DescribeRabbitMQUser(DescribeRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQUserResponse>(req, "DescribeRabbitMQUser");
        }

        /// <summary>
        /// 查询RabbitMQ用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQUserResponse"/></returns>
        public DescribeRabbitMQUserResponse DescribeRabbitMQUserSync(DescribeRabbitMQUserRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQUserResponse>(req, "DescribeRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个RabbitMQ专享实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstanceResponse"/></returns>
        public Task<DescribeRabbitMQVipInstanceResponse> DescribeRabbitMQVipInstance(DescribeRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVipInstanceResponse>(req, "DescribeRabbitMQVipInstance");
        }

        /// <summary>
        /// 获取单个RabbitMQ专享实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstanceResponse"/></returns>
        public DescribeRabbitMQVipInstanceResponse DescribeRabbitMQVipInstanceSync(DescribeRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVipInstanceResponse>(req, "DescribeRabbitMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户已购的RabbitMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstancesResponse"/></returns>
        public Task<DescribeRabbitMQVipInstancesResponse> DescribeRabbitMQVipInstances(DescribeRabbitMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVipInstancesResponse>(req, "DescribeRabbitMQVipInstances");
        }

        /// <summary>
        /// 查询用户已购的RabbitMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVipInstancesResponse"/></returns>
        public DescribeRabbitMQVipInstancesResponse DescribeRabbitMQVipInstancesSync(DescribeRabbitMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVipInstancesResponse>(req, "DescribeRabbitMQVipInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询RabbitMQ vhost列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostResponse"/></returns>
        public Task<DescribeRabbitMQVirtualHostResponse> DescribeRabbitMQVirtualHost(DescribeRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVirtualHostResponse>(req, "DescribeRabbitMQVirtualHost");
        }

        /// <summary>
        /// 查询RabbitMQ vhost列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQVirtualHostResponse"/></returns>
        public DescribeRabbitMQVirtualHostResponse DescribeRabbitMQVirtualHostSync(DescribeRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQVirtualHostResponse>(req, "DescribeRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public Task<DescribeRocketMQClusterResponse> DescribeRocketMQCluster(DescribeRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClusterResponse>(req, "DescribeRocketMQCluster");
        }

        /// <summary>
        /// 获取单个RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClusterRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClusterResponse"/></returns>
        public DescribeRocketMQClusterResponse DescribeRocketMQClusterSync(DescribeRocketMQClusterRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClusterResponse>(req, "DescribeRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取RocketMQ集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClustersRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClustersResponse"/></returns>
        public Task<DescribeRocketMQClustersResponse> DescribeRocketMQClusters(DescribeRocketMQClustersRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClustersResponse>(req, "DescribeRocketMQClusters");
        }

        /// <summary>
        /// 获取RocketMQ集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQClustersRequest"/></param>
        /// <returns><see cref="DescribeRocketMQClustersResponse"/></returns>
        public DescribeRocketMQClustersResponse DescribeRocketMQClustersSync(DescribeRocketMQClustersRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQClustersResponse>(req, "DescribeRocketMQClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取消费详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQConsumeStatsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQConsumeStatsResponse"/></returns>
        public Task<DescribeRocketMQConsumeStatsResponse> DescribeRocketMQConsumeStats(DescribeRocketMQConsumeStatsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQConsumeStatsResponse>(req, "DescribeRocketMQConsumeStats");
        }

        /// <summary>
        /// 获取消费详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQConsumeStatsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQConsumeStatsResponse"/></returns>
        public DescribeRocketMQConsumeStatsResponse DescribeRocketMQConsumeStatsSync(DescribeRocketMQConsumeStatsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQConsumeStatsResponse>(req, "DescribeRocketMQConsumeStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取在线消费端详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQConsumerConnectionDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQConsumerConnectionDetailResponse"/></returns>
        public Task<DescribeRocketMQConsumerConnectionDetailResponse> DescribeRocketMQConsumerConnectionDetail(DescribeRocketMQConsumerConnectionDetailRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQConsumerConnectionDetailResponse>(req, "DescribeRocketMQConsumerConnectionDetail");
        }

        /// <summary>
        /// 获取在线消费端详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQConsumerConnectionDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQConsumerConnectionDetailResponse"/></returns>
        public DescribeRocketMQConsumerConnectionDetailResponse DescribeRocketMQConsumerConnectionDetailSync(DescribeRocketMQConsumerConnectionDetailRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQConsumerConnectionDetailResponse>(req, "DescribeRocketMQConsumerConnectionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定消费组下当前客户端的连接情况
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQConsumerConnectionsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQConsumerConnectionsResponse"/></returns>
        public Task<DescribeRocketMQConsumerConnectionsResponse> DescribeRocketMQConsumerConnections(DescribeRocketMQConsumerConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQConsumerConnectionsResponse>(req, "DescribeRocketMQConsumerConnections");
        }

        /// <summary>
        /// 获取指定消费组下当前客户端的连接情况
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQConsumerConnectionsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQConsumerConnectionsResponse"/></returns>
        public DescribeRocketMQConsumerConnectionsResponse DescribeRocketMQConsumerConnectionsSync(DescribeRocketMQConsumerConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQConsumerConnectionsResponse>(req, "DescribeRocketMQConsumerConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取命名空间角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQEnvironmentRolesResponse"/></returns>
        public Task<DescribeRocketMQEnvironmentRolesResponse> DescribeRocketMQEnvironmentRoles(DescribeRocketMQEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQEnvironmentRolesResponse>(req, "DescribeRocketMQEnvironmentRoles");
        }

        /// <summary>
        /// 获取命名空间角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQEnvironmentRolesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQEnvironmentRolesResponse"/></returns>
        public DescribeRocketMQEnvironmentRolesResponse DescribeRocketMQEnvironmentRolesSync(DescribeRocketMQEnvironmentRolesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQEnvironmentRolesResponse>(req, "DescribeRocketMQEnvironmentRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取RocketMQ消费组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQGroupsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQGroupsResponse"/></returns>
        public Task<DescribeRocketMQGroupsResponse> DescribeRocketMQGroups(DescribeRocketMQGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQGroupsResponse>(req, "DescribeRocketMQGroups");
        }

        /// <summary>
        /// 获取RocketMQ消费组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQGroupsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQGroupsResponse"/></returns>
        public DescribeRocketMQGroupsResponse DescribeRocketMQGroupsSync(DescribeRocketMQGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQGroupsResponse>(req, "DescribeRocketMQGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Topic迁移状态列表，源集群和目标集群客户端数量信息需要配合DescribeRocketMQSmoothMigrationTaskTopicInsNum接口查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMigratingTopicListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMigratingTopicListResponse"/></returns>
        public Task<DescribeRocketMQMigratingTopicListResponse> DescribeRocketMQMigratingTopicList(DescribeRocketMQMigratingTopicListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMigratingTopicListResponse>(req, "DescribeRocketMQMigratingTopicList");
        }

        /// <summary>
        /// 查询Topic迁移状态列表，源集群和目标集群客户端数量信息需要配合DescribeRocketMQSmoothMigrationTaskTopicInsNum接口查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMigratingTopicListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMigratingTopicListResponse"/></returns>
        public DescribeRocketMQMigratingTopicListResponse DescribeRocketMQMigratingTopicListSync(DescribeRocketMQMigratingTopicListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMigratingTopicListResponse>(req, "DescribeRocketMQMigratingTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// rocketmq消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgResponse"/></returns>
        public Task<DescribeRocketMQMsgResponse> DescribeRocketMQMsg(DescribeRocketMQMsgRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMsgResponse>(req, "DescribeRocketMQMsg");
        }

        /// <summary>
        /// rocketmq消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgResponse"/></returns>
        public DescribeRocketMQMsgResponse DescribeRocketMQMsgSync(DescribeRocketMQMsgRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMsgResponse>(req, "DescribeRocketMQMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消息轨迹
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgTraceRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgTraceResponse"/></returns>
        public Task<DescribeRocketMQMsgTraceResponse> DescribeRocketMQMsgTrace(DescribeRocketMQMsgTraceRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMsgTraceResponse>(req, "DescribeRocketMQMsgTrace");
        }

        /// <summary>
        /// 查询消息轨迹
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQMsgTraceRequest"/></param>
        /// <returns><see cref="DescribeRocketMQMsgTraceResponse"/></returns>
        public DescribeRocketMQMsgTraceResponse DescribeRocketMQMsgTraceSync(DescribeRocketMQMsgTraceRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQMsgTraceResponse>(req, "DescribeRocketMQMsgTrace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取RocketMQ命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQNamespacesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQNamespacesResponse"/></returns>
        public Task<DescribeRocketMQNamespacesResponse> DescribeRocketMQNamespaces(DescribeRocketMQNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQNamespacesResponse>(req, "DescribeRocketMQNamespaces");
        }

        /// <summary>
        /// 获取RocketMQ命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQNamespacesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQNamespacesResponse"/></returns>
        public DescribeRocketMQNamespacesResponse DescribeRocketMQNamespacesSync(DescribeRocketMQNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQNamespacesResponse>(req, "DescribeRocketMQNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从腾讯云可观测平台拉取公网指标监控数据，目前仅支持客户端到 LB 的入带宽和出宽带指标。
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQPublicAccessMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeRocketMQPublicAccessMonitorDataResponse"/></returns>
        public Task<DescribeRocketMQPublicAccessMonitorDataResponse> DescribeRocketMQPublicAccessMonitorData(DescribeRocketMQPublicAccessMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQPublicAccessMonitorDataResponse>(req, "DescribeRocketMQPublicAccessMonitorData");
        }

        /// <summary>
        /// 从腾讯云可观测平台拉取公网指标监控数据，目前仅支持客户端到 LB 的入带宽和出宽带指标。
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQPublicAccessMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeRocketMQPublicAccessMonitorDataResponse"/></returns>
        public DescribeRocketMQPublicAccessMonitorDataResponse DescribeRocketMQPublicAccessMonitorDataSync(DescribeRocketMQPublicAccessMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQPublicAccessMonitorDataResponse>(req, "DescribeRocketMQPublicAccessMonitorData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于查询RocketMQ实例的公网接入信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQPublicAccessPointRequest"/></param>
        /// <returns><see cref="DescribeRocketMQPublicAccessPointResponse"/></returns>
        public Task<DescribeRocketMQPublicAccessPointResponse> DescribeRocketMQPublicAccessPoint(DescribeRocketMQPublicAccessPointRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQPublicAccessPointResponse>(req, "DescribeRocketMQPublicAccessPoint");
        }

        /// <summary>
        /// 接口用于查询RocketMQ实例的公网接入信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQPublicAccessPointRequest"/></param>
        /// <returns><see cref="DescribeRocketMQPublicAccessPointResponse"/></returns>
        public DescribeRocketMQPublicAccessPointResponse DescribeRocketMQPublicAccessPointSync(DescribeRocketMQPublicAccessPointRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQPublicAccessPointResponse>(req, "DescribeRocketMQPublicAccessPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQRolesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQRolesResponse"/></returns>
        public Task<DescribeRocketMQRolesResponse> DescribeRocketMQRoles(DescribeRocketMQRolesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQRolesResponse>(req, "DescribeRocketMQRoles");
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQRolesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQRolesResponse"/></returns>
        public DescribeRocketMQRolesResponse DescribeRocketMQRolesSync(DescribeRocketMQRolesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQRolesResponse>(req, "DescribeRocketMQRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取RocketMQ平滑迁移任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSmoothMigrationTaskRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSmoothMigrationTaskResponse"/></returns>
        public Task<DescribeRocketMQSmoothMigrationTaskResponse> DescribeRocketMQSmoothMigrationTask(DescribeRocketMQSmoothMigrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSmoothMigrationTaskResponse>(req, "DescribeRocketMQSmoothMigrationTask");
        }

        /// <summary>
        /// 用于获取RocketMQ平滑迁移任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSmoothMigrationTaskRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSmoothMigrationTaskResponse"/></returns>
        public DescribeRocketMQSmoothMigrationTaskResponse DescribeRocketMQSmoothMigrationTaskSync(DescribeRocketMQSmoothMigrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSmoothMigrationTaskResponse>(req, "DescribeRocketMQSmoothMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 平滑迁移相关接口已迁移至trocket产品下，该接口已废弃
        /// 
        /// 用于查询RocketMQ平滑迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSmoothMigrationTaskListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSmoothMigrationTaskListResponse"/></returns>
        public Task<DescribeRocketMQSmoothMigrationTaskListResponse> DescribeRocketMQSmoothMigrationTaskList(DescribeRocketMQSmoothMigrationTaskListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSmoothMigrationTaskListResponse>(req, "DescribeRocketMQSmoothMigrationTaskList");
        }

        /// <summary>
        /// 平滑迁移相关接口已迁移至trocket产品下，该接口已废弃
        /// 
        /// 用于查询RocketMQ平滑迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSmoothMigrationTaskListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSmoothMigrationTaskListResponse"/></returns>
        public DescribeRocketMQSmoothMigrationTaskListResponse DescribeRocketMQSmoothMigrationTaskListSync(DescribeRocketMQSmoothMigrationTaskListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSmoothMigrationTaskListResponse>(req, "DescribeRocketMQSmoothMigrationTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 平滑迁移相关接口已迁移至trocket产品下，该接口已废弃
        /// 
        /// 平滑迁移过程获取源集群group列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSourceClusterGroupListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSourceClusterGroupListResponse"/></returns>
        public Task<DescribeRocketMQSourceClusterGroupListResponse> DescribeRocketMQSourceClusterGroupList(DescribeRocketMQSourceClusterGroupListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSourceClusterGroupListResponse>(req, "DescribeRocketMQSourceClusterGroupList");
        }

        /// <summary>
        /// 平滑迁移相关接口已迁移至trocket产品下，该接口已废弃
        /// 
        /// 平滑迁移过程获取源集群group列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSourceClusterGroupListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSourceClusterGroupListResponse"/></returns>
        public DescribeRocketMQSourceClusterGroupListResponse DescribeRocketMQSourceClusterGroupListSync(DescribeRocketMQSourceClusterGroupListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSourceClusterGroupListResponse>(req, "DescribeRocketMQSourceClusterGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 平滑迁移相关接口已迁移至trocket产品下，该接口已废弃
        /// 
        /// 平滑迁移过程获取源集群topic列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSourceClusterTopicListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSourceClusterTopicListResponse"/></returns>
        public Task<DescribeRocketMQSourceClusterTopicListResponse> DescribeRocketMQSourceClusterTopicList(DescribeRocketMQSourceClusterTopicListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSourceClusterTopicListResponse>(req, "DescribeRocketMQSourceClusterTopicList");
        }

        /// <summary>
        /// 平滑迁移相关接口已迁移至trocket产品下，该接口已废弃
        /// 
        /// 平滑迁移过程获取源集群topic列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSourceClusterTopicListRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSourceClusterTopicListResponse"/></returns>
        public DescribeRocketMQSourceClusterTopicListResponse DescribeRocketMQSourceClusterTopicListSync(DescribeRocketMQSourceClusterTopicListRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSourceClusterTopicListResponse>(req, "DescribeRocketMQSourceClusterTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取RocketMQ消费组订阅关系数据
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSubscriptionsResponse"/></returns>
        public Task<DescribeRocketMQSubscriptionsResponse> DescribeRocketMQSubscriptions(DescribeRocketMQSubscriptionsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSubscriptionsResponse>(req, "DescribeRocketMQSubscriptions");
        }

        /// <summary>
        /// 用于获取RocketMQ消费组订阅关系数据
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQSubscriptionsResponse"/></returns>
        public DescribeRocketMQSubscriptionsResponse DescribeRocketMQSubscriptionsSync(DescribeRocketMQSubscriptionsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQSubscriptionsResponse>(req, "DescribeRocketMQSubscriptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取RocketMQ指标排序列表，比如集群实例下占用存储空间最多的主题排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopUsagesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopUsagesResponse"/></returns>
        public Task<DescribeRocketMQTopUsagesResponse> DescribeRocketMQTopUsages(DescribeRocketMQTopUsagesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopUsagesResponse>(req, "DescribeRocketMQTopUsages");
        }

        /// <summary>
        /// 用于获取RocketMQ指标排序列表，比如集群实例下占用存储空间最多的主题排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopUsagesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopUsagesResponse"/></returns>
        public DescribeRocketMQTopUsagesResponse DescribeRocketMQTopUsagesSync(DescribeRocketMQTopUsagesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopUsagesResponse>(req, "DescribeRocketMQTopUsages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// rocketmq 消息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicMsgsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicMsgsResponse"/></returns>
        public Task<DescribeRocketMQTopicMsgsResponse> DescribeRocketMQTopicMsgs(DescribeRocketMQTopicMsgsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicMsgsResponse>(req, "DescribeRocketMQTopicMsgs");
        }

        /// <summary>
        /// rocketmq 消息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicMsgsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicMsgsResponse"/></returns>
        public DescribeRocketMQTopicMsgsResponse DescribeRocketMQTopicMsgsSync(DescribeRocketMQTopicMsgsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicMsgsResponse>(req, "DescribeRocketMQTopicMsgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Topic生产详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicStatsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicStatsResponse"/></returns>
        public Task<DescribeRocketMQTopicStatsResponse> DescribeRocketMQTopicStats(DescribeRocketMQTopicStatsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicStatsResponse>(req, "DescribeRocketMQTopicStats");
        }

        /// <summary>
        /// 获取Topic生产详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicStatsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicStatsResponse"/></returns>
        public DescribeRocketMQTopicStatsResponse DescribeRocketMQTopicStatsSync(DescribeRocketMQTopicStatsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicStatsResponse>(req, "DescribeRocketMQTopicStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取RocketMQ主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsResponse"/></returns>
        public Task<DescribeRocketMQTopicsResponse> DescribeRocketMQTopics(DescribeRocketMQTopicsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicsResponse>(req, "DescribeRocketMQTopics");
        }

        /// <summary>
        /// 获取RocketMQ主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsResponse"/></returns>
        public DescribeRocketMQTopicsResponse DescribeRocketMQTopicsSync(DescribeRocketMQTopicsRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicsResponse>(req, "DescribeRocketMQTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定消费组下订阅的主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsByGroupRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsByGroupResponse"/></returns>
        public Task<DescribeRocketMQTopicsByGroupResponse> DescribeRocketMQTopicsByGroup(DescribeRocketMQTopicsByGroupRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicsByGroupResponse>(req, "DescribeRocketMQTopicsByGroup");
        }

        /// <summary>
        /// 获取指定消费组下订阅的主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQTopicsByGroupRequest"/></param>
        /// <returns><see cref="DescribeRocketMQTopicsByGroupResponse"/></returns>
        public DescribeRocketMQTopicsByGroupResponse DescribeRocketMQTopicsByGroupSync(DescribeRocketMQTopicsByGroupRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQTopicsByGroupResponse>(req, "DescribeRocketMQTopicsByGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个RocketMQ专享集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstanceDetailResponse"/></returns>
        public Task<DescribeRocketMQVipInstanceDetailResponse> DescribeRocketMQVipInstanceDetail(DescribeRocketMQVipInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstanceDetailResponse>(req, "DescribeRocketMQVipInstanceDetail");
        }

        /// <summary>
        /// 获取单个RocketMQ专享集群信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstanceDetailResponse"/></returns>
        public DescribeRocketMQVipInstanceDetailResponse DescribeRocketMQVipInstanceDetailSync(DescribeRocketMQVipInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstanceDetailResponse>(req, "DescribeRocketMQVipInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户已购的RocketMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstancesResponse"/></returns>
        public Task<DescribeRocketMQVipInstancesResponse> DescribeRocketMQVipInstances(DescribeRocketMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstancesResponse>(req, "DescribeRocketMQVipInstances");
        }

        /// <summary>
        /// 查询用户已购的RocketMQ专享实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRocketMQVipInstancesRequest"/></param>
        /// <returns><see cref="DescribeRocketMQVipInstancesResponse"/></returns>
        public DescribeRocketMQVipInstancesResponse DescribeRocketMQVipInstancesSync(DescribeRocketMQVipInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRocketMQVipInstancesResponse>(req, "DescribeRocketMQVipInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public Task<DescribeRolesResponse> DescribeRoles(DescribeRolesRequest req)
        {
            return InternalRequestAsync<DescribeRolesResponse>(req, "DescribeRoles");
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRolesRequest"/></param>
        /// <returns><see cref="DescribeRolesResponse"/></returns>
        public DescribeRolesResponse DescribeRolesSync(DescribeRolesRequest req)
        {
            return InternalRequestAsync<DescribeRolesResponse>(req, "DescribeRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定环境和主题下的订阅者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionsResponse"/></returns>
        public Task<DescribeSubscriptionsResponse> DescribeSubscriptions(DescribeSubscriptionsRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionsResponse>(req, "DescribeSubscriptions");
        }

        /// <summary>
        /// 查询指定环境和主题下的订阅者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionsRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionsResponse"/></returns>
        public DescribeSubscriptionsResponse DescribeSubscriptionsSync(DescribeSubscriptionsRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionsResponse>(req, "DescribeSubscriptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 消息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicMsgsRequest"/></param>
        /// <returns><see cref="DescribeTopicMsgsResponse"/></returns>
        public Task<DescribeTopicMsgsResponse> DescribeTopicMsgs(DescribeTopicMsgsRequest req)
        {
            return InternalRequestAsync<DescribeTopicMsgsResponse>(req, "DescribeTopicMsgs");
        }

        /// <summary>
        /// 消息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicMsgsRequest"/></param>
        /// <returns><see cref="DescribeTopicMsgsResponse"/></returns>
        public DescribeTopicMsgsResponse DescribeTopicMsgsSync(DescribeTopicMsgsRequest req)
        {
            return InternalRequestAsync<DescribeTopicMsgsResponse>(req, "DescribeTopicMsgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境下主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics");
        }

        /// <summary>
        /// 获取环境下主题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出RocketMQ消息详情
        /// </summary>
        /// <param name="req"><see cref="ExportRocketMQMessageDetailRequest"/></param>
        /// <returns><see cref="ExportRocketMQMessageDetailResponse"/></returns>
        public Task<ExportRocketMQMessageDetailResponse> ExportRocketMQMessageDetail(ExportRocketMQMessageDetailRequest req)
        {
            return InternalRequestAsync<ExportRocketMQMessageDetailResponse>(req, "ExportRocketMQMessageDetail");
        }

        /// <summary>
        /// 导出RocketMQ消息详情
        /// </summary>
        /// <param name="req"><see cref="ExportRocketMQMessageDetailRequest"/></param>
        /// <returns><see cref="ExportRocketMQMessageDetailResponse"/></returns>
        public ExportRocketMQMessageDetailResponse ExportRocketMQMessageDetailSync(ExportRocketMQMessageDetailRequest req)
        {
            return InternalRequestAsync<ExportRocketMQMessageDetailResponse>(req, "ExportRocketMQMessageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境下主题列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicListRequest"/></param>
        /// <returns><see cref="GetTopicListResponse"/></returns>
        public Task<GetTopicListResponse> GetTopicList(GetTopicListRequest req)
        {
            return InternalRequestAsync<GetTopicListResponse>(req, "GetTopicList");
        }

        /// <summary>
        /// 获取环境下主题列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicListRequest"/></param>
        /// <returns><see cref="GetTopicListResponse"/></returns>
        public GetTopicListResponse GetTopicListSync(GetTopicListRequest req)
        {
            return InternalRequestAsync<GetTopicListResponse>(req, "GetTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输入迁移任务id和要导入的Group，导入后台
        /// </summary>
        /// <param name="req"><see cref="ImportRocketMQConsumerGroupsRequest"/></param>
        /// <returns><see cref="ImportRocketMQConsumerGroupsResponse"/></returns>
        public Task<ImportRocketMQConsumerGroupsResponse> ImportRocketMQConsumerGroups(ImportRocketMQConsumerGroupsRequest req)
        {
            return InternalRequestAsync<ImportRocketMQConsumerGroupsResponse>(req, "ImportRocketMQConsumerGroups");
        }

        /// <summary>
        /// 输入迁移任务id和要导入的Group，导入后台
        /// </summary>
        /// <param name="req"><see cref="ImportRocketMQConsumerGroupsRequest"/></param>
        /// <returns><see cref="ImportRocketMQConsumerGroupsResponse"/></returns>
        public ImportRocketMQConsumerGroupsResponse ImportRocketMQConsumerGroupsSync(ImportRocketMQConsumerGroupsRequest req)
        {
            return InternalRequestAsync<ImportRocketMQConsumerGroupsResponse>(req, "ImportRocketMQConsumerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入topic列表
        /// </summary>
        /// <param name="req"><see cref="ImportRocketMQTopicsRequest"/></param>
        /// <returns><see cref="ImportRocketMQTopicsResponse"/></returns>
        public Task<ImportRocketMQTopicsResponse> ImportRocketMQTopics(ImportRocketMQTopicsRequest req)
        {
            return InternalRequestAsync<ImportRocketMQTopicsResponse>(req, "ImportRocketMQTopics");
        }

        /// <summary>
        /// 导入topic列表
        /// </summary>
        /// <param name="req"><see cref="ImportRocketMQTopicsRequest"/></param>
        /// <returns><see cref="ImportRocketMQTopicsResponse"/></returns>
        public ImportRocketMQTopicsResponse ImportRocketMQTopicsSync(ImportRocketMQTopicsRequest req)
        {
            return InternalRequestAsync<ImportRocketMQTopicsResponse>(req, "ImportRocketMQTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public Task<ModifyClusterResponse> ModifyCluster(ModifyClusterRequest req)
        {
            return InternalRequestAsync<ModifyClusterResponse>(req, "ModifyCluster");
        }

        /// <summary>
        /// 更新集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRequest"/></param>
        /// <returns><see cref="ModifyClusterResponse"/></returns>
        public ModifyClusterResponse ModifyClusterSync(ModifyClusterRequest req)
        {
            return InternalRequestAsync<ModifyClusterResponse>(req, "ModifyCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改cmq队列属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public Task<ModifyCmqQueueAttributeResponse> ModifyCmqQueueAttribute(ModifyCmqQueueAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqQueueAttributeResponse>(req, "ModifyCmqQueueAttribute");
        }

        /// <summary>
        /// 修改cmq队列属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqQueueAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqQueueAttributeResponse"/></returns>
        public ModifyCmqQueueAttributeResponse ModifyCmqQueueAttributeSync(ModifyCmqQueueAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqQueueAttributeResponse>(req, "ModifyCmqQueueAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改cmq订阅属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public Task<ModifyCmqSubscriptionAttributeResponse> ModifyCmqSubscriptionAttribute(ModifyCmqSubscriptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqSubscriptionAttributeResponse>(req, "ModifyCmqSubscriptionAttribute");
        }

        /// <summary>
        /// 修改cmq订阅属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqSubscriptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqSubscriptionAttributeResponse"/></returns>
        public ModifyCmqSubscriptionAttributeResponse ModifyCmqSubscriptionAttributeSync(ModifyCmqSubscriptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqSubscriptionAttributeResponse>(req, "ModifyCmqSubscriptionAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改cmq主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public Task<ModifyCmqTopicAttributeResponse> ModifyCmqTopicAttribute(ModifyCmqTopicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqTopicAttributeResponse>(req, "ModifyCmqTopicAttribute");
        }

        /// <summary>
        /// 修改cmq主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyCmqTopicAttributeRequest"/></param>
        /// <returns><see cref="ModifyCmqTopicAttributeResponse"/></returns>
        public ModifyCmqTopicAttributeResponse ModifyCmqTopicAttributeSync(ModifyCmqTopicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCmqTopicAttributeResponse>(req, "ModifyCmqTopicAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改指定命名空间的属性值
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public Task<ModifyEnvironmentAttributesResponse> ModifyEnvironmentAttributes(ModifyEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentAttributesResponse>(req, "ModifyEnvironmentAttributes");
        }

        /// <summary>
        /// 修改指定命名空间的属性值
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentAttributesRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentAttributesResponse"/></returns>
        public ModifyEnvironmentAttributesResponse ModifyEnvironmentAttributesSync(ModifyEnvironmentAttributesRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentAttributesResponse>(req, "ModifyEnvironmentAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public Task<ModifyEnvironmentRoleResponse> ModifyEnvironmentRole(ModifyEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentRoleResponse>(req, "ModifyEnvironmentRole");
        }

        /// <summary>
        /// 修改环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentRoleResponse"/></returns>
        public ModifyEnvironmentRoleResponse ModifyEnvironmentRoleSync(ModifyEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentRoleResponse>(req, "ModifyEnvironmentRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改pulsar专业版公网安全策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicNetworkSecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifyPublicNetworkSecurityPolicyResponse"/></returns>
        public Task<ModifyPublicNetworkSecurityPolicyResponse> ModifyPublicNetworkSecurityPolicy(ModifyPublicNetworkSecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPublicNetworkSecurityPolicyResponse>(req, "ModifyPublicNetworkSecurityPolicy");
        }

        /// <summary>
        /// 修改pulsar专业版公网安全策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicNetworkSecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifyPublicNetworkSecurityPolicyResponse"/></returns>
        public ModifyPublicNetworkSecurityPolicyResponse ModifyPublicNetworkSecurityPolicySync(ModifyPublicNetworkSecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPublicNetworkSecurityPolicyResponse>(req, "ModifyPublicNetworkSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改RabbitMQ的权限
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQPermissionRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQPermissionResponse"/></returns>
        public Task<ModifyRabbitMQPermissionResponse> ModifyRabbitMQPermission(ModifyRabbitMQPermissionRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQPermissionResponse>(req, "ModifyRabbitMQPermission");
        }

        /// <summary>
        /// 修改RabbitMQ的权限
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQPermissionRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQPermissionResponse"/></returns>
        public ModifyRabbitMQPermissionResponse ModifyRabbitMQPermissionSync(ModifyRabbitMQPermissionRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQPermissionResponse>(req, "ModifyRabbitMQPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQUserResponse"/></returns>
        public Task<ModifyRabbitMQUserResponse> ModifyRabbitMQUser(ModifyRabbitMQUserRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQUserResponse>(req, "ModifyRabbitMQUser");
        }

        /// <summary>
        /// 修改RabbitMQ的用户
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQUserResponse"/></returns>
        public ModifyRabbitMQUserResponse ModifyRabbitMQUserSync(ModifyRabbitMQUserRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQUserResponse>(req, "ModifyRabbitMQUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVipInstanceResponse"/></returns>
        public Task<ModifyRabbitMQVipInstanceResponse> ModifyRabbitMQVipInstance(ModifyRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQVipInstanceResponse>(req, "ModifyRabbitMQVipInstance");
        }

        /// <summary>
        /// 修改RabbitMQ专享版实例
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVipInstanceRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVipInstanceResponse"/></returns>
        public ModifyRabbitMQVipInstanceResponse ModifyRabbitMQVipInstanceSync(ModifyRabbitMQVipInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQVipInstanceResponse>(req, "ModifyRabbitMQVipInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVirtualHostResponse"/></returns>
        public Task<ModifyRabbitMQVirtualHostResponse> ModifyRabbitMQVirtualHost(ModifyRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQVirtualHostResponse>(req, "ModifyRabbitMQVirtualHost");
        }

        /// <summary>
        /// 修改RabbitMQ的vhost
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQVirtualHostResponse"/></returns>
        public ModifyRabbitMQVirtualHostResponse ModifyRabbitMQVirtualHostSync(ModifyRabbitMQVirtualHostRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQVirtualHostResponse>(req, "ModifyRabbitMQVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public Task<ModifyRocketMQClusterResponse> ModifyRocketMQCluster(ModifyRocketMQClusterRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQClusterResponse>(req, "ModifyRocketMQCluster");
        }

        /// <summary>
        /// 更新RocketMQ集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQClusterRequest"/></param>
        /// <returns><see cref="ModifyRocketMQClusterResponse"/></returns>
        public ModifyRocketMQClusterResponse ModifyRocketMQClusterSync(ModifyRocketMQClusterRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQClusterResponse>(req, "ModifyRocketMQCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyRocketMQEnvironmentRoleResponse"/></returns>
        public Task<ModifyRocketMQEnvironmentRoleResponse> ModifyRocketMQEnvironmentRole(ModifyRocketMQEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQEnvironmentRoleResponse>(req, "ModifyRocketMQEnvironmentRole");
        }

        /// <summary>
        /// 修改环境角色授权。
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQEnvironmentRoleRequest"/></param>
        /// <returns><see cref="ModifyRocketMQEnvironmentRoleResponse"/></returns>
        public ModifyRocketMQEnvironmentRoleResponse ModifyRocketMQEnvironmentRoleSync(ModifyRocketMQEnvironmentRoleRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQEnvironmentRoleResponse>(req, "ModifyRocketMQEnvironmentRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新RocketMQ消费组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public Task<ModifyRocketMQGroupResponse> ModifyRocketMQGroup(ModifyRocketMQGroupRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQGroupResponse>(req, "ModifyRocketMQGroup");
        }

        /// <summary>
        /// 更新RocketMQ消费组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQGroupRequest"/></param>
        /// <returns><see cref="ModifyRocketMQGroupResponse"/></returns>
        public ModifyRocketMQGroupResponse ModifyRocketMQGroupSync(ModifyRocketMQGroupRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQGroupResponse>(req, "ModifyRocketMQGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改RocketMQ专享实例
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceResponse"/></returns>
        public Task<ModifyRocketMQInstanceResponse> ModifyRocketMQInstance(ModifyRocketMQInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQInstanceResponse>(req, "ModifyRocketMQInstance");
        }

        /// <summary>
        /// 修改RocketMQ专享实例
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceResponse"/></returns>
        public ModifyRocketMQInstanceResponse ModifyRocketMQInstanceSync(ModifyRocketMQInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQInstanceResponse>(req, "ModifyRocketMQInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本API用于修改RocketMQ专享实例配置，可以支持实例规格、节点数和存储的升配和实例规格的降配。本API发起订单并成功支付后进入实例配置变更的流程，可通过DescribeRocketMQVipInstances查询实例是否已变更完成。
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceSpecResponse"/></returns>
        public Task<ModifyRocketMQInstanceSpecResponse> ModifyRocketMQInstanceSpec(ModifyRocketMQInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQInstanceSpecResponse>(req, "ModifyRocketMQInstanceSpec");
        }

        /// <summary>
        /// 本API用于修改RocketMQ专享实例配置，可以支持实例规格、节点数和存储的升配和实例规格的降配。本API发起订单并成功支付后进入实例配置变更的流程，可通过DescribeRocketMQVipInstances查询实例是否已变更完成。
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyRocketMQInstanceSpecResponse"/></returns>
        public ModifyRocketMQInstanceSpecResponse ModifyRocketMQInstanceSpecSync(ModifyRocketMQInstanceSpecRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQInstanceSpecResponse>(req, "ModifyRocketMQInstanceSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public Task<ModifyRocketMQNamespaceResponse> ModifyRocketMQNamespace(ModifyRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQNamespaceResponse>(req, "ModifyRocketMQNamespace");
        }

        /// <summary>
        /// 更新RocketMQ命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQNamespaceRequest"/></param>
        /// <returns><see cref="ModifyRocketMQNamespaceResponse"/></returns>
        public ModifyRocketMQNamespaceResponse ModifyRocketMQNamespaceSync(ModifyRocketMQNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQNamespaceResponse>(req, "ModifyRocketMQNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQRoleRequest"/></param>
        /// <returns><see cref="ModifyRocketMQRoleResponse"/></returns>
        public Task<ModifyRocketMQRoleResponse> ModifyRocketMQRole(ModifyRocketMQRoleRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQRoleResponse>(req, "ModifyRocketMQRole");
        }

        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQRoleRequest"/></param>
        /// <returns><see cref="ModifyRocketMQRoleResponse"/></returns>
        public ModifyRocketMQRoleResponse ModifyRocketMQRoleSync(ModifyRocketMQRoleRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQRoleResponse>(req, "ModifyRocketMQRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新RocketMQ主题信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public Task<ModifyRocketMQTopicResponse> ModifyRocketMQTopic(ModifyRocketMQTopicRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQTopicResponse>(req, "ModifyRocketMQTopic");
        }

        /// <summary>
        /// 更新RocketMQ主题信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRocketMQTopicRequest"/></param>
        /// <returns><see cref="ModifyRocketMQTopicResponse"/></returns>
        public ModifyRocketMQTopicResponse ModifyRocketMQTopicSync(ModifyRocketMQTopicRequest req)
        {
            return InternalRequestAsync<ModifyRocketMQTopicResponse>(req, "ModifyRocketMQTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public Task<ModifyRoleResponse> ModifyRole(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole");
        }

        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public ModifyRoleResponse ModifyRoleSync(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改主题备注和分区数
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// 修改主题备注和分区数
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送cmq主题消息
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public Task<PublishCmqMsgResponse> PublishCmqMsg(PublishCmqMsgRequest req)
        {
            return InternalRequestAsync<PublishCmqMsgResponse>(req, "PublishCmqMsg");
        }

        /// <summary>
        /// 发送cmq主题消息
        /// </summary>
        /// <param name="req"><see cref="PublishCmqMsgRequest"/></param>
        /// <returns><see cref="PublishCmqMsgResponse"/></returns>
        public PublishCmqMsgResponse PublishCmqMsgSync(PublishCmqMsgRequest req)
        {
            return InternalRequestAsync<PublishCmqMsgResponse>(req, "PublishCmqMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<ReceiveMessageResponse> ReceiveMessage(ReceiveMessageRequest req)
        {
            return InternalRequestAsync<ReceiveMessageResponse>(req, "ReceiveMessage");
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
            return InternalRequestAsync<ReceiveMessageResponse>(req, "ReceiveMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据时间戳进行消息回溯，精确到毫秒
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public Task<ResetMsgSubOffsetByTimestampResponse> ResetMsgSubOffsetByTimestamp(ResetMsgSubOffsetByTimestampRequest req)
        {
            return InternalRequestAsync<ResetMsgSubOffsetByTimestampResponse>(req, "ResetMsgSubOffsetByTimestamp");
        }

        /// <summary>
        /// 根据时间戳进行消息回溯，精确到毫秒
        /// </summary>
        /// <param name="req"><see cref="ResetMsgSubOffsetByTimestampRequest"/></param>
        /// <returns><see cref="ResetMsgSubOffsetByTimestampResponse"/></returns>
        public ResetMsgSubOffsetByTimestampResponse ResetMsgSubOffsetByTimestampSync(ResetMsgSubOffsetByTimestampRequest req)
        {
            return InternalRequestAsync<ResetMsgSubOffsetByTimestampResponse>(req, "ResetMsgSubOffsetByTimestamp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置指定Group的消费位点到指定时间戳
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public Task<ResetRocketMQConsumerOffSetResponse> ResetRocketMQConsumerOffSet(ResetRocketMQConsumerOffSetRequest req)
        {
            return InternalRequestAsync<ResetRocketMQConsumerOffSetResponse>(req, "ResetRocketMQConsumerOffSet");
        }

        /// <summary>
        /// 重置指定Group的消费位点到指定时间戳
        /// </summary>
        /// <param name="req"><see cref="ResetRocketMQConsumerOffSetRequest"/></param>
        /// <returns><see cref="ResetRocketMQConsumerOffSetResponse"/></returns>
        public ResetRocketMQConsumerOffSetResponse ResetRocketMQConsumerOffSetSync(ResetRocketMQConsumerOffSetRequest req)
        {
            return InternalRequestAsync<ResetRocketMQConsumerOffSetResponse>(req, "ResetRocketMQConsumerOffSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重发RocketMQ死信消息
        /// </summary>
        /// <param name="req"><see cref="RetryRocketMQDlqMessageRequest"/></param>
        /// <returns><see cref="RetryRocketMQDlqMessageResponse"/></returns>
        public Task<RetryRocketMQDlqMessageResponse> RetryRocketMQDlqMessage(RetryRocketMQDlqMessageRequest req)
        {
            return InternalRequestAsync<RetryRocketMQDlqMessageResponse>(req, "RetryRocketMQDlqMessage");
        }

        /// <summary>
        /// 重发RocketMQ死信消息
        /// </summary>
        /// <param name="req"><see cref="RetryRocketMQDlqMessageRequest"/></param>
        /// <returns><see cref="RetryRocketMQDlqMessageResponse"/></returns>
        public RetryRocketMQDlqMessageResponse RetryRocketMQDlqMessageSync(RetryRocketMQDlqMessageRequest req)
        {
            return InternalRequestAsync<RetryRocketMQDlqMessageResponse>(req, "RetryRocketMQDlqMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回溯cmq队列
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public Task<RewindCmqQueueResponse> RewindCmqQueue(RewindCmqQueueRequest req)
        {
            return InternalRequestAsync<RewindCmqQueueResponse>(req, "RewindCmqQueue");
        }

        /// <summary>
        /// 回溯cmq队列
        /// </summary>
        /// <param name="req"><see cref="RewindCmqQueueRequest"/></param>
        /// <returns><see cref="RewindCmqQueueResponse"/></returns>
        public RewindCmqQueueResponse RewindCmqQueueSync(RewindCmqQueueRequest req)
        {
            return InternalRequestAsync<RewindCmqQueueResponse>(req, "RewindCmqQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量发送消息
        /// 
        /// 注意：TDMQ 批量发送消息的接口是在 TDMQ-HTTP 的服务侧将消息打包为一个 Batch，然后将该 Batch 在服务内部当作一次 TCP 请求发送出去。所以在使用过程中，用户还是按照单条消息发送的逻辑，每一条消息是一个独立的 HTTP 的请求，在 TDMQ-HTTP 的服务内部，会将多个 HTTP 的请求聚合为一个 Batch 发送到服务端。即，批量发送消息在使用上与发送单条消息是一致的，batch 的聚合是在 TDMQ-HTTP 的服务内部完成的。
        /// </summary>
        /// <param name="req"><see cref="SendBatchMessagesRequest"/></param>
        /// <returns><see cref="SendBatchMessagesResponse"/></returns>
        public Task<SendBatchMessagesResponse> SendBatchMessages(SendBatchMessagesRequest req)
        {
            return InternalRequestAsync<SendBatchMessagesResponse>(req, "SendBatchMessages");
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
            return InternalRequestAsync<SendBatchMessagesResponse>(req, "SendBatchMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送cmq消息
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public Task<SendCmqMsgResponse> SendCmqMsg(SendCmqMsgRequest req)
        {
            return InternalRequestAsync<SendCmqMsgResponse>(req, "SendCmqMsg");
        }

        /// <summary>
        /// 发送cmq消息
        /// </summary>
        /// <param name="req"><see cref="SendCmqMsgRequest"/></param>
        /// <returns><see cref="SendCmqMsgResponse"/></returns>
        public SendCmqMsgResponse SendCmqMsgSync(SendCmqMsgRequest req)
        {
            return InternalRequestAsync<SendCmqMsgResponse>(req, "SendCmqMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送单条消息
        /// 不支持持久topic
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public Task<SendMessagesResponse> SendMessages(SendMessagesRequest req)
        {
            return InternalRequestAsync<SendMessagesResponse>(req, "SendMessages");
        }

        /// <summary>
        /// 发送单条消息
        /// 不支持持久topic
        /// </summary>
        /// <param name="req"><see cref="SendMessagesRequest"/></param>
        /// <returns><see cref="SendMessagesResponse"/></returns>
        public SendMessagesResponse SendMessagesSync(SendMessagesRequest req)
        {
            return InternalRequestAsync<SendMessagesResponse>(req, "SendMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口仅用于测试发生消息，不能作为现网正式生产使用
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public Task<SendMsgResponse> SendMsg(SendMsgRequest req)
        {
            return InternalRequestAsync<SendMsgResponse>(req, "SendMsg");
        }

        /// <summary>
        /// 此接口仅用于测试发生消息，不能作为现网正式生产使用
        /// </summary>
        /// <param name="req"><see cref="SendMsgRequest"/></param>
        /// <returns><see cref="SendMsgResponse"/></returns>
        public SendMsgResponse SendMsgSync(SendMsgRequest req)
        {
            return InternalRequestAsync<SendMsgResponse>(req, "SendMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送RocketMQ消息
        /// </summary>
        /// <param name="req"><see cref="SendRocketMQMessageRequest"/></param>
        /// <returns><see cref="SendRocketMQMessageResponse"/></returns>
        public Task<SendRocketMQMessageResponse> SendRocketMQMessage(SendRocketMQMessageRequest req)
        {
            return InternalRequestAsync<SendRocketMQMessageResponse>(req, "SendRocketMQMessage");
        }

        /// <summary>
        /// 发送RocketMQ消息
        /// </summary>
        /// <param name="req"><see cref="SendRocketMQMessageRequest"/></param>
        /// <returns><see cref="SendRocketMQMessageResponse"/></returns>
        public SendRocketMQMessageResponse SendRocketMQMessageSync(SendRocketMQMessageRequest req)
        {
            return InternalRequestAsync<SendRocketMQMessageResponse>(req, "SendRocketMQMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于开启关闭公网访问、设置安全访问策略
        /// </summary>
        /// <param name="req"><see cref="SetRocketMQPublicAccessPointRequest"/></param>
        /// <returns><see cref="SetRocketMQPublicAccessPointResponse"/></returns>
        public Task<SetRocketMQPublicAccessPointResponse> SetRocketMQPublicAccessPoint(SetRocketMQPublicAccessPointRequest req)
        {
            return InternalRequestAsync<SetRocketMQPublicAccessPointResponse>(req, "SetRocketMQPublicAccessPoint");
        }

        /// <summary>
        /// 该接口用于开启关闭公网访问、设置安全访问策略
        /// </summary>
        /// <param name="req"><see cref="SetRocketMQPublicAccessPointRequest"/></param>
        /// <returns><see cref="SetRocketMQPublicAccessPointResponse"/></returns>
        public SetRocketMQPublicAccessPointResponse SetRocketMQPublicAccessPointSync(SetRocketMQPublicAccessPointRequest req)
        {
            return InternalRequestAsync<SetRocketMQPublicAccessPointResponse>(req, "SetRocketMQPublicAccessPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑cmq死信队列
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public Task<UnbindCmqDeadLetterResponse> UnbindCmqDeadLetter(UnbindCmqDeadLetterRequest req)
        {
            return InternalRequestAsync<UnbindCmqDeadLetterResponse>(req, "UnbindCmqDeadLetter");
        }

        /// <summary>
        /// 解绑cmq死信队列
        /// </summary>
        /// <param name="req"><see cref="UnbindCmqDeadLetterRequest"/></param>
        /// <returns><see cref="UnbindCmqDeadLetterResponse"/></returns>
        public UnbindCmqDeadLetterResponse UnbindCmqDeadLetterSync(UnbindCmqDeadLetterRequest req)
        {
            return InternalRequestAsync<UnbindCmqDeadLetterResponse>(req, "UnbindCmqDeadLetter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rocketmq消费验证
        /// </summary>
        /// <param name="req"><see cref="VerifyRocketMQConsumeRequest"/></param>
        /// <returns><see cref="VerifyRocketMQConsumeResponse"/></returns>
        public Task<VerifyRocketMQConsumeResponse> VerifyRocketMQConsume(VerifyRocketMQConsumeRequest req)
        {
            return InternalRequestAsync<VerifyRocketMQConsumeResponse>(req, "VerifyRocketMQConsume");
        }

        /// <summary>
        /// Rocketmq消费验证
        /// </summary>
        /// <param name="req"><see cref="VerifyRocketMQConsumeRequest"/></param>
        /// <returns><see cref="VerifyRocketMQConsumeResponse"/></returns>
        public VerifyRocketMQConsumeResponse VerifyRocketMQConsumeSync(VerifyRocketMQConsumeRequest req)
        {
            return InternalRequestAsync<VerifyRocketMQConsumeResponse>(req, "VerifyRocketMQConsume")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
