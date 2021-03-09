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
        /// 获取生产者列表，仅显示在线的生产者
        /// </summary>
        /// <param name="req"><see cref="DescribeProducersRequest"/></param>
        /// <returns><see cref="DescribeProducersResponse"/></returns>
        public async Task<DescribeProducersResponse> DescribeProducers(DescribeProducersRequest req)
        {
             JsonResponseModel<DescribeProducersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProducers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProducersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取生产者列表，仅显示在线的生产者
        /// </summary>
        /// <param name="req"><see cref="DescribeProducersRequest"/></param>
        /// <returns><see cref="DescribeProducersResponse"/></returns>
        public DescribeProducersResponse DescribeProducersSync(DescribeProducersRequest req)
        {
             JsonResponseModel<DescribeProducersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProducers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProducersResponse>>(strResp);
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
        /// 批量发送消息
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
        /// 发送单条消息
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

    }
}
