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

namespace TencentCloud.Trocket.V20230308
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trocket.V20230308.Models;

   public class TrocketClient : AbstractClient{

       private const string endpoint = "trocket.tencentcloudapi.com";
       private const string version = "2023-03-08";
       private const string sdkVersion = "SDK_NET_3.0.1107";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrocketClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrocketClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建消费组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public Task<CreateConsumerGroupResponse> CreateConsumerGroup(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup");
        }

        /// <summary>
        /// 创建消费组
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerGroupRequest"/></param>
        /// <returns><see cref="CreateConsumerGroupResponse"/></returns>
        public CreateConsumerGroupResponse CreateConsumerGroupSync(CreateConsumerGroupRequest req)
        {
            return InternalRequestAsync<CreateConsumerGroupResponse>(req, "CreateConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 RocketMQ 5.x 集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// 创建 RocketMQ 5.x 集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为MQTT实例创建公网接入点
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTInsPublicEndpointRequest"/></param>
        /// <returns><see cref="CreateMQTTInsPublicEndpointResponse"/></returns>
        public Task<CreateMQTTInsPublicEndpointResponse> CreateMQTTInsPublicEndpoint(CreateMQTTInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<CreateMQTTInsPublicEndpointResponse>(req, "CreateMQTTInsPublicEndpoint");
        }

        /// <summary>
        /// 为MQTT实例创建公网接入点
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTInsPublicEndpointRequest"/></param>
        /// <returns><see cref="CreateMQTTInsPublicEndpointResponse"/></returns>
        public CreateMQTTInsPublicEndpointResponse CreateMQTTInsPublicEndpointSync(CreateMQTTInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<CreateMQTTInsPublicEndpointResponse>(req, "CreateMQTTInsPublicEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买新的MQTT实例
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTInstanceRequest"/></param>
        /// <returns><see cref="CreateMQTTInstanceResponse"/></returns>
        public Task<CreateMQTTInstanceResponse> CreateMQTTInstance(CreateMQTTInstanceRequest req)
        {
            return InternalRequestAsync<CreateMQTTInstanceResponse>(req, "CreateMQTTInstance");
        }

        /// <summary>
        /// 购买新的MQTT实例
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTInstanceRequest"/></param>
        /// <returns><see cref="CreateMQTTInstanceResponse"/></returns>
        public CreateMQTTInstanceResponse CreateMQTTInstanceSync(CreateMQTTInstanceRequest req)
        {
            return InternalRequestAsync<CreateMQTTInstanceResponse>(req, "CreateMQTTInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建主题
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTTopicRequest"/></param>
        /// <returns><see cref="CreateMQTTTopicResponse"/></returns>
        public Task<CreateMQTTTopicResponse> CreateMQTTTopic(CreateMQTTTopicRequest req)
        {
            return InternalRequestAsync<CreateMQTTTopicResponse>(req, "CreateMQTTTopic");
        }

        /// <summary>
        /// 创建主题
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTTopicRequest"/></param>
        /// <returns><see cref="CreateMQTTTopicResponse"/></returns>
        public CreateMQTTTopicResponse CreateMQTTTopicSync(CreateMQTTTopicRequest req)
        {
            return InternalRequestAsync<CreateMQTTTopicResponse>(req, "CreateMQTTTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加mqtt角色
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTUserRequest"/></param>
        /// <returns><see cref="CreateMQTTUserResponse"/></returns>
        public Task<CreateMQTTUserResponse> CreateMQTTUser(CreateMQTTUserRequest req)
        {
            return InternalRequestAsync<CreateMQTTUserResponse>(req, "CreateMQTTUser");
        }

        /// <summary>
        /// 添加mqtt角色
        /// </summary>
        /// <param name="req"><see cref="CreateMQTTUserRequest"/></param>
        /// <returns><see cref="CreateMQTTUserResponse"/></returns>
        public CreateMQTTUserResponse CreateMQTTUserSync(CreateMQTTUserRequest req)
        {
            return InternalRequestAsync<CreateMQTTUserResponse>(req, "CreateMQTTUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole");
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// 创建主题
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public Task<DeleteConsumerGroupResponse> DeleteConsumerGroup(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup");
        }

        /// <summary>
        /// 删除消费组
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerGroupRequest"/></param>
        /// <returns><see cref="DeleteConsumerGroupResponse"/></returns>
        public DeleteConsumerGroupResponse DeleteConsumerGroupSync(DeleteConsumerGroupRequest req)
        {
            return InternalRequestAsync<DeleteConsumerGroupResponse>(req, "DeleteConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// 删除实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除MQTT实例的公网接入点
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTInsPublicEndpointRequest"/></param>
        /// <returns><see cref="DeleteMQTTInsPublicEndpointResponse"/></returns>
        public Task<DeleteMQTTInsPublicEndpointResponse> DeleteMQTTInsPublicEndpoint(DeleteMQTTInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<DeleteMQTTInsPublicEndpointResponse>(req, "DeleteMQTTInsPublicEndpoint");
        }

        /// <summary>
        /// 删除MQTT实例的公网接入点
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTInsPublicEndpointRequest"/></param>
        /// <returns><see cref="DeleteMQTTInsPublicEndpointResponse"/></returns>
        public DeleteMQTTInsPublicEndpointResponse DeleteMQTTInsPublicEndpointSync(DeleteMQTTInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<DeleteMQTTInsPublicEndpointResponse>(req, "DeleteMQTTInsPublicEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除MQTT实例
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTInstanceRequest"/></param>
        /// <returns><see cref="DeleteMQTTInstanceResponse"/></returns>
        public Task<DeleteMQTTInstanceResponse> DeleteMQTTInstance(DeleteMQTTInstanceRequest req)
        {
            return InternalRequestAsync<DeleteMQTTInstanceResponse>(req, "DeleteMQTTInstance");
        }

        /// <summary>
        /// 删除MQTT实例
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTInstanceRequest"/></param>
        /// <returns><see cref="DeleteMQTTInstanceResponse"/></returns>
        public DeleteMQTTInstanceResponse DeleteMQTTInstanceSync(DeleteMQTTInstanceRequest req)
        {
            return InternalRequestAsync<DeleteMQTTInstanceResponse>(req, "DeleteMQTTInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除MQTT主题
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTTopicRequest"/></param>
        /// <returns><see cref="DeleteMQTTTopicResponse"/></returns>
        public Task<DeleteMQTTTopicResponse> DeleteMQTTTopic(DeleteMQTTTopicRequest req)
        {
            return InternalRequestAsync<DeleteMQTTTopicResponse>(req, "DeleteMQTTTopic");
        }

        /// <summary>
        /// 删除MQTT主题
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTTopicRequest"/></param>
        /// <returns><see cref="DeleteMQTTTopicResponse"/></returns>
        public DeleteMQTTTopicResponse DeleteMQTTTopicSync(DeleteMQTTTopicRequest req)
        {
            return InternalRequestAsync<DeleteMQTTTopicResponse>(req, "DeleteMQTTTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除MQTT访问用户
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTUserRequest"/></param>
        /// <returns><see cref="DeleteMQTTUserResponse"/></returns>
        public Task<DeleteMQTTUserResponse> DeleteMQTTUser(DeleteMQTTUserRequest req)
        {
            return InternalRequestAsync<DeleteMQTTUserResponse>(req, "DeleteMQTTUser");
        }

        /// <summary>
        /// 删除MQTT访问用户
        /// </summary>
        /// <param name="req"><see cref="DeleteMQTTUserRequest"/></param>
        /// <returns><see cref="DeleteMQTTUserResponse"/></returns>
        public DeleteMQTTUserResponse DeleteMQTTUserSync(DeleteMQTTUserRequest req)
        {
            return InternalRequestAsync<DeleteMQTTUserResponse>(req, "DeleteMQTTUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public Task<DeleteRoleResponse> DeleteRole(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole");
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public DeleteRoleResponse DeleteRoleSync(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// 删除主题
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消费组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public Task<DescribeConsumerGroupResponse> DescribeConsumerGroup(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup");
        }

        /// <summary>
        /// 查询消费组详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupResponse"/></returns>
        public DescribeConsumerGroupResponse DescribeConsumerGroupSync(DescribeConsumerGroupRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupResponse>(req, "DescribeConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取消费组列表，Filter参数使用说明如下：
        /// 
        /// 1. ConsumerGroupName，名称模糊查询
        /// 2. ConsumeMessageOrderly，投递顺序性。"true":顺序投递；"false":并发投递
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupListRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupListResponse"/></returns>
        public Task<DescribeConsumerGroupListResponse> DescribeConsumerGroupList(DescribeConsumerGroupListRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupListResponse>(req, "DescribeConsumerGroupList");
        }

        /// <summary>
        /// 获取消费组列表，Filter参数使用说明如下：
        /// 
        /// 1. ConsumerGroupName，名称模糊查询
        /// 2. ConsumeMessageOrderly，投递顺序性。"true":顺序投递；"false":并发投递
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerGroupListRequest"/></param>
        /// <returns><see cref="DescribeConsumerGroupListResponse"/></returns>
        public DescribeConsumerGroupListResponse DescribeConsumerGroupListSync(DescribeConsumerGroupListRequest req)
        {
            return InternalRequestAsync<DescribeConsumerGroupListResponse>(req, "DescribeConsumerGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定消费组堆积数。
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerLagRequest"/></param>
        /// <returns><see cref="DescribeConsumerLagResponse"/></returns>
        public Task<DescribeConsumerLagResponse> DescribeConsumerLag(DescribeConsumerLagRequest req)
        {
            return InternalRequestAsync<DescribeConsumerLagResponse>(req, "DescribeConsumerLag");
        }

        /// <summary>
        /// 查询指定消费组堆积数。
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerLagRequest"/></param>
        /// <returns><see cref="DescribeConsumerLagResponse"/></returns>
        public DescribeConsumerLagResponse DescribeConsumerLagSync(DescribeConsumerLagRequest req)
        {
            return InternalRequestAsync<DescribeConsumerLagResponse>(req, "DescribeConsumerLag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 4. Version，实例版本查询
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeFusionInstanceListRequest"/></param>
        /// <returns><see cref="DescribeFusionInstanceListResponse"/></returns>
        public Task<DescribeFusionInstanceListResponse> DescribeFusionInstanceList(DescribeFusionInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeFusionInstanceListResponse>(req, "DescribeFusionInstanceList");
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 4. Version，实例版本查询
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeFusionInstanceListRequest"/></param>
        /// <returns><see cref="DescribeFusionInstanceListResponse"/></returns>
        public DescribeFusionInstanceListResponse DescribeFusionInstanceListSync(DescribeFusionInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeFusionInstanceListResponse>(req, "DescribeFusionInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群列表，仅支持 5.x 集群，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，集群ID查询
        /// 3. InstanceType, 集群类型查询，支持多选
        /// 3. InstanceStatus，集群状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList");
        }

        /// <summary>
        /// 获取集群列表，仅支持 5.x 集群，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，集群ID查询
        /// 3. InstanceType, 集群类型查询，支持多选
        /// 3. InstanceStatus，集群状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 MQTT 客户端详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTClientRequest"/></param>
        /// <returns><see cref="DescribeMQTTClientResponse"/></returns>
        public Task<DescribeMQTTClientResponse> DescribeMQTTClient(DescribeMQTTClientRequest req)
        {
            return InternalRequestAsync<DescribeMQTTClientResponse>(req, "DescribeMQTTClient");
        }

        /// <summary>
        /// 查询 MQTT 客户端详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTClientRequest"/></param>
        /// <returns><see cref="DescribeMQTTClientResponse"/></returns>
        public DescribeMQTTClientResponse DescribeMQTTClientSync(DescribeMQTTClientRequest req)
        {
            return InternalRequestAsync<DescribeMQTTClientResponse>(req, "DescribeMQTTClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInsPublicEndpointsRequest"/></param>
        /// <returns><see cref="DescribeMQTTInsPublicEndpointsResponse"/></returns>
        public Task<DescribeMQTTInsPublicEndpointsResponse> DescribeMQTTInsPublicEndpoints(DescribeMQTTInsPublicEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInsPublicEndpointsResponse>(req, "DescribeMQTTInsPublicEndpoints");
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInsPublicEndpointsRequest"/></param>
        /// <returns><see cref="DescribeMQTTInsPublicEndpointsResponse"/></returns>
        public DescribeMQTTInsPublicEndpointsResponse DescribeMQTTInsPublicEndpointsSync(DescribeMQTTInsPublicEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInsPublicEndpointsResponse>(req, "DescribeMQTTInsPublicEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInsVPCEndpointsRequest"/></param>
        /// <returns><see cref="DescribeMQTTInsVPCEndpointsResponse"/></returns>
        public Task<DescribeMQTTInsVPCEndpointsResponse> DescribeMQTTInsVPCEndpoints(DescribeMQTTInsVPCEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInsVPCEndpointsResponse>(req, "DescribeMQTTInsVPCEndpoints");
        }

        /// <summary>
        /// 查询MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInsVPCEndpointsRequest"/></param>
        /// <returns><see cref="DescribeMQTTInsVPCEndpointsResponse"/></returns>
        public DescribeMQTTInsVPCEndpointsResponse DescribeMQTTInsVPCEndpointsSync(DescribeMQTTInsVPCEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInsVPCEndpointsResponse>(req, "DescribeMQTTInsVPCEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInstanceRequest"/></param>
        /// <returns><see cref="DescribeMQTTInstanceResponse"/></returns>
        public Task<DescribeMQTTInstanceResponse> DescribeMQTTInstance(DescribeMQTTInstanceRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInstanceResponse>(req, "DescribeMQTTInstance");
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInstanceRequest"/></param>
        /// <returns><see cref="DescribeMQTTInstanceResponse"/></returns>
        public DescribeMQTTInstanceResponse DescribeMQTTInstanceSync(DescribeMQTTInstanceRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInstanceResponse>(req, "DescribeMQTTInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT集群证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInstanceCertRequest"/></param>
        /// <returns><see cref="DescribeMQTTInstanceCertResponse"/></returns>
        public Task<DescribeMQTTInstanceCertResponse> DescribeMQTTInstanceCert(DescribeMQTTInstanceCertRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInstanceCertResponse>(req, "DescribeMQTTInstanceCert");
        }

        /// <summary>
        /// 查询MQTT集群证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInstanceCertRequest"/></param>
        /// <returns><see cref="DescribeMQTTInstanceCertResponse"/></returns>
        public DescribeMQTTInstanceCertResponse DescribeMQTTInstanceCertSync(DescribeMQTTInstanceCertRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInstanceCertResponse>(req, "DescribeMQTTInstanceCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 3. InstanceStatus，实例状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInstanceListRequest"/></param>
        /// <returns><see cref="DescribeMQTTInstanceListResponse"/></returns>
        public Task<DescribeMQTTInstanceListResponse> DescribeMQTTInstanceList(DescribeMQTTInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInstanceListResponse>(req, "DescribeMQTTInstanceList");
        }

        /// <summary>
        /// 获取实例列表，Filters参数使用说明如下：
        /// 1. InstanceName, 名称模糊查询
        /// 2. InstanceId，实例ID查询
        /// 3. InstanceType, 实例类型查询，支持多选
        /// 3. InstanceStatus，实例状态查询，支持多选
        /// 
        /// 当使用TagFilters查询时，Filters参数失效。
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTInstanceListRequest"/></param>
        /// <returns><see cref="DescribeMQTTInstanceListResponse"/></returns>
        public DescribeMQTTInstanceListResponse DescribeMQTTInstanceListSync(DescribeMQTTInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTInstanceListResponse>(req, "DescribeMQTTInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询MQTT消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTMessageRequest"/></param>
        /// <returns><see cref="DescribeMQTTMessageResponse"/></returns>
        public Task<DescribeMQTTMessageResponse> DescribeMQTTMessage(DescribeMQTTMessageRequest req)
        {
            return InternalRequestAsync<DescribeMQTTMessageResponse>(req, "DescribeMQTTMessage");
        }

        /// <summary>
        /// 查询MQTT消息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTMessageRequest"/></param>
        /// <returns><see cref="DescribeMQTTMessageResponse"/></returns>
        public DescribeMQTTMessageResponse DescribeMQTTMessageSync(DescribeMQTTMessageRequest req)
        {
            return InternalRequestAsync<DescribeMQTTMessageResponse>(req, "DescribeMQTTMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消息列表，如查询死信，请设置ConsumerGroup参数
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTMessageListRequest"/></param>
        /// <returns><see cref="DescribeMQTTMessageListResponse"/></returns>
        public Task<DescribeMQTTMessageListResponse> DescribeMQTTMessageList(DescribeMQTTMessageListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTMessageListResponse>(req, "DescribeMQTTMessageList");
        }

        /// <summary>
        /// 查询消息列表，如查询死信，请设置ConsumerGroup参数
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTMessageListRequest"/></param>
        /// <returns><see cref="DescribeMQTTMessageListResponse"/></returns>
        public DescribeMQTTMessageListResponse DescribeMQTTMessageListSync(DescribeMQTTMessageListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTMessageListResponse>(req, "DescribeMQTTMessageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品售卖规格
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTProductSKUListRequest"/></param>
        /// <returns><see cref="DescribeMQTTProductSKUListResponse"/></returns>
        public Task<DescribeMQTTProductSKUListResponse> DescribeMQTTProductSKUList(DescribeMQTTProductSKUListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTProductSKUListResponse>(req, "DescribeMQTTProductSKUList");
        }

        /// <summary>
        /// 获取产品售卖规格
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTProductSKUListRequest"/></param>
        /// <returns><see cref="DescribeMQTTProductSKUListResponse"/></returns>
        public DescribeMQTTProductSKUListResponse DescribeMQTTProductSKUListSync(DescribeMQTTProductSKUListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTProductSKUListResponse>(req, "DescribeMQTTProductSKUList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询mqtt主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTTopicRequest"/></param>
        /// <returns><see cref="DescribeMQTTTopicResponse"/></returns>
        public Task<DescribeMQTTTopicResponse> DescribeMQTTTopic(DescribeMQTTTopicRequest req)
        {
            return InternalRequestAsync<DescribeMQTTTopicResponse>(req, "DescribeMQTTTopic");
        }

        /// <summary>
        /// 查询mqtt主题详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTTopicRequest"/></param>
        /// <returns><see cref="DescribeMQTTTopicResponse"/></returns>
        public DescribeMQTTTopicResponse DescribeMQTTTopicSync(DescribeMQTTTopicRequest req)
        {
            return InternalRequestAsync<DescribeMQTTTopicResponse>(req, "DescribeMQTTTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTTopicListRequest"/></param>
        /// <returns><see cref="DescribeMQTTTopicListResponse"/></returns>
        public Task<DescribeMQTTTopicListResponse> DescribeMQTTTopicList(DescribeMQTTTopicListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTTopicListResponse>(req, "DescribeMQTTTopicList");
        }

        /// <summary>
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTTopicListRequest"/></param>
        /// <returns><see cref="DescribeMQTTTopicListResponse"/></returns>
        public DescribeMQTTTopicListResponse DescribeMQTTTopicListSync(DescribeMQTTTopicListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTTopicListResponse>(req, "DescribeMQTTTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户列表，Filter参数使用说明如下：
        /// 
        /// 1. Username，用户名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTUserListRequest"/></param>
        /// <returns><see cref="DescribeMQTTUserListResponse"/></returns>
        public Task<DescribeMQTTUserListResponse> DescribeMQTTUserList(DescribeMQTTUserListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTUserListResponse>(req, "DescribeMQTTUserList");
        }

        /// <summary>
        /// 查询用户列表，Filter参数使用说明如下：
        /// 
        /// 1. Username，用户名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeMQTTUserListRequest"/></param>
        /// <returns><see cref="DescribeMQTTUserListResponse"/></returns>
        public DescribeMQTTUserListResponse DescribeMQTTUserListSync(DescribeMQTTUserListRequest req)
        {
            return InternalRequestAsync<DescribeMQTTUserListResponse>(req, "DescribeMQTTUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询产品售卖规格，针对 RocketMQ 5.x 集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSKUsRequest"/></param>
        /// <returns><see cref="DescribeProductSKUsResponse"/></returns>
        public Task<DescribeProductSKUsResponse> DescribeProductSKUs(DescribeProductSKUsRequest req)
        {
            return InternalRequestAsync<DescribeProductSKUsResponse>(req, "DescribeProductSKUs");
        }

        /// <summary>
        /// 查询产品售卖规格，针对 RocketMQ 5.x 集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductSKUsRequest"/></param>
        /// <returns><see cref="DescribeProductSKUsResponse"/></returns>
        public DescribeProductSKUsResponse DescribeProductSKUsSync(DescribeProductSKUsRequest req)
        {
            return InternalRequestAsync<DescribeProductSKUsResponse>(req, "DescribeProductSKUs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询角色列表，Filter参数使用说明如下：
        /// 
        /// 1. RoleName，角色名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList");
        }

        /// <summary>
        /// 查询角色列表，Filter参数使用说明如下：
        /// 
        /// 1. RoleName，角色名称模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询主题详情，Offset和Limit参数是指订阅该主题的消费组查询分页参数，Filter参数使用说明如下：
        /// 
        /// ConsumerGroup，消费组名称过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public Task<DescribeTopicResponse> DescribeTopic(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic");
        }

        /// <summary>
        /// 查询主题详情，Offset和Limit参数是指订阅该主题的消费组查询分页参数，Filter参数使用说明如下：
        /// 
        /// ConsumerGroup，消费组名称过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRequest"/></param>
        /// <returns><see cref="DescribeTopicResponse"/></returns>
        public DescribeTopicResponse DescribeTopicSync(DescribeTopicRequest req)
        {
            return InternalRequestAsync<DescribeTopicResponse>(req, "DescribeTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public Task<DescribeTopicListResponse> DescribeTopicList(DescribeTopicListRequest req)
        {
            return InternalRequestAsync<DescribeTopicListResponse>(req, "DescribeTopicList");
        }

        /// <summary>
        /// 获取主题列表，Filter参数使用说明如下：
        /// 
        /// 1. TopicName，主题名称模糊搜索
        /// 2. TopicType，主题类型查询，支持多选，可选值：Normal,Order,Transaction,DelayScheduled
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicListRequest"/></param>
        /// <returns><see cref="DescribeTopicListResponse"/></returns>
        public DescribeTopicListResponse DescribeTopicListSync(DescribeTopicListRequest req)
        {
            return InternalRequestAsync<DescribeTopicListResponse>(req, "DescribeTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入消费者组列表
        /// </summary>
        /// <param name="req"><see cref="ImportSourceClusterConsumerGroupsRequest"/></param>
        /// <returns><see cref="ImportSourceClusterConsumerGroupsResponse"/></returns>
        public Task<ImportSourceClusterConsumerGroupsResponse> ImportSourceClusterConsumerGroups(ImportSourceClusterConsumerGroupsRequest req)
        {
            return InternalRequestAsync<ImportSourceClusterConsumerGroupsResponse>(req, "ImportSourceClusterConsumerGroups");
        }

        /// <summary>
        /// 导入消费者组列表
        /// </summary>
        /// <param name="req"><see cref="ImportSourceClusterConsumerGroupsRequest"/></param>
        /// <returns><see cref="ImportSourceClusterConsumerGroupsResponse"/></returns>
        public ImportSourceClusterConsumerGroupsResponse ImportSourceClusterConsumerGroupsSync(ImportSourceClusterConsumerGroupsRequest req)
        {
            return InternalRequestAsync<ImportSourceClusterConsumerGroupsResponse>(req, "ImportSourceClusterConsumerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入topic列表
        /// </summary>
        /// <param name="req"><see cref="ImportSourceClusterTopicsRequest"/></param>
        /// <returns><see cref="ImportSourceClusterTopicsResponse"/></returns>
        public Task<ImportSourceClusterTopicsResponse> ImportSourceClusterTopics(ImportSourceClusterTopicsRequest req)
        {
            return InternalRequestAsync<ImportSourceClusterTopicsResponse>(req, "ImportSourceClusterTopics");
        }

        /// <summary>
        /// 导入topic列表
        /// </summary>
        /// <param name="req"><see cref="ImportSourceClusterTopicsRequest"/></param>
        /// <returns><see cref="ImportSourceClusterTopicsResponse"/></returns>
        public ImportSourceClusterTopicsResponse ImportSourceClusterTopicsSync(ImportSourceClusterTopicsRequest req)
        {
            return InternalRequestAsync<ImportSourceClusterTopicsResponse>(req, "ImportSourceClusterTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改消费组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public Task<ModifyConsumerGroupResponse> ModifyConsumerGroup(ModifyConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupResponse>(req, "ModifyConsumerGroup");
        }

        /// <summary>
        /// 修改消费组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerGroupRequest"/></param>
        /// <returns><see cref="ModifyConsumerGroupResponse"/></returns>
        public ModifyConsumerGroupResponse ModifyConsumerGroupSync(ModifyConsumerGroupRequest req)
        {
            return InternalRequestAsync<ModifyConsumerGroupResponse>(req, "ModifyConsumerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 修改实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTInsPublicEndpointRequest"/></param>
        /// <returns><see cref="ModifyMQTTInsPublicEndpointResponse"/></returns>
        public Task<ModifyMQTTInsPublicEndpointResponse> ModifyMQTTInsPublicEndpoint(ModifyMQTTInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<ModifyMQTTInsPublicEndpointResponse>(req, "ModifyMQTTInsPublicEndpoint");
        }

        /// <summary>
        /// 更新MQTT实例公网接入点
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTInsPublicEndpointRequest"/></param>
        /// <returns><see cref="ModifyMQTTInsPublicEndpointResponse"/></returns>
        public ModifyMQTTInsPublicEndpointResponse ModifyMQTTInsPublicEndpointSync(ModifyMQTTInsPublicEndpointRequest req)
        {
            return InternalRequestAsync<ModifyMQTTInsPublicEndpointResponse>(req, "ModifyMQTTInsPublicEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTInstanceRequest"/></param>
        /// <returns><see cref="ModifyMQTTInstanceResponse"/></returns>
        public Task<ModifyMQTTInstanceResponse> ModifyMQTTInstance(ModifyMQTTInstanceRequest req)
        {
            return InternalRequestAsync<ModifyMQTTInstanceResponse>(req, "ModifyMQTTInstance");
        }

        /// <summary>
        /// 修改实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTInstanceRequest"/></param>
        /// <returns><see cref="ModifyMQTTInstanceResponse"/></returns>
        public ModifyMQTTInstanceResponse ModifyMQTTInstanceSync(ModifyMQTTInstanceRequest req)
        {
            return InternalRequestAsync<ModifyMQTTInstanceResponse>(req, "ModifyMQTTInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新MQTT集群绑定证书
        /// 参数传空，则为删除证书
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTInstanceCertBindingRequest"/></param>
        /// <returns><see cref="ModifyMQTTInstanceCertBindingResponse"/></returns>
        public Task<ModifyMQTTInstanceCertBindingResponse> ModifyMQTTInstanceCertBinding(ModifyMQTTInstanceCertBindingRequest req)
        {
            return InternalRequestAsync<ModifyMQTTInstanceCertBindingResponse>(req, "ModifyMQTTInstanceCertBinding");
        }

        /// <summary>
        /// 更新MQTT集群绑定证书
        /// 参数传空，则为删除证书
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTInstanceCertBindingRequest"/></param>
        /// <returns><see cref="ModifyMQTTInstanceCertBindingResponse"/></returns>
        public ModifyMQTTInstanceCertBindingResponse ModifyMQTTInstanceCertBindingSync(ModifyMQTTInstanceCertBindingRequest req)
        {
            return InternalRequestAsync<ModifyMQTTInstanceCertBindingResponse>(req, "ModifyMQTTInstanceCertBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTTopicRequest"/></param>
        /// <returns><see cref="ModifyMQTTTopicResponse"/></returns>
        public Task<ModifyMQTTTopicResponse> ModifyMQTTTopic(ModifyMQTTTopicRequest req)
        {
            return InternalRequestAsync<ModifyMQTTTopicResponse>(req, "ModifyMQTTTopic");
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTTopicRequest"/></param>
        /// <returns><see cref="ModifyMQTTTopicResponse"/></returns>
        public ModifyMQTTTopicResponse ModifyMQTTTopicSync(ModifyMQTTTopicRequest req)
        {
            return InternalRequestAsync<ModifyMQTTTopicResponse>(req, "ModifyMQTTTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改MQTT角色
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTUserRequest"/></param>
        /// <returns><see cref="ModifyMQTTUserResponse"/></returns>
        public Task<ModifyMQTTUserResponse> ModifyMQTTUser(ModifyMQTTUserRequest req)
        {
            return InternalRequestAsync<ModifyMQTTUserResponse>(req, "ModifyMQTTUser");
        }

        /// <summary>
        /// 修改MQTT角色
        /// </summary>
        /// <param name="req"><see cref="ModifyMQTTUserRequest"/></param>
        /// <returns><see cref="ModifyMQTTUserResponse"/></returns>
        public ModifyMQTTUserResponse ModifyMQTTUserSync(ModifyMQTTUserRequest req)
        {
            return InternalRequestAsync<ModifyMQTTUserResponse>(req, "ModifyMQTTUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public Task<ModifyRoleResponse> ModifyRole(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole");
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="req"><see cref="ModifyRoleRequest"/></param>
        /// <returns><see cref="ModifyRoleResponse"/></returns>
        public ModifyRoleResponse ModifyRoleSync(ModifyRoleRequest req)
        {
            return InternalRequestAsync<ModifyRoleResponse>(req, "ModifyRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// 修改主题属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
