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

namespace TencentCloud.Thpc.V20230321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Thpc.V20230321.Models;

   public class ThpcClient : AbstractClient{

       private const string endpoint = "thpc.tencentcloudapi.com";
       private const string version = "2023-03-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ThpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ThpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（AddClusterStorageOption）用于添加集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="AddClusterStorageOptionRequest"/></param>
        /// <returns><see cref="AddClusterStorageOptionResponse"/></returns>
        public async Task<AddClusterStorageOptionResponse> AddClusterStorageOption(AddClusterStorageOptionRequest req)
        {
             JsonResponseModel<AddClusterStorageOptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddClusterStorageOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddClusterStorageOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AddClusterStorageOption）用于添加集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="AddClusterStorageOptionRequest"/></param>
        /// <returns><see cref="AddClusterStorageOptionResponse"/></returns>
        public AddClusterStorageOptionResponse AddClusterStorageOptionSync(AddClusterStorageOptionRequest req)
        {
             JsonResponseModel<AddClusterStorageOptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddClusterStorageOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddClusterStorageOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AddNodes)用于添加一个或者多个计算节点或者登录节点到指定集群。
        /// </summary>
        /// <param name="req"><see cref="AddNodesRequest"/></param>
        /// <returns><see cref="AddNodesResponse"/></returns>
        public async Task<AddNodesResponse> AddNodes(AddNodesRequest req)
        {
             JsonResponseModel<AddNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AddNodes)用于添加一个或者多个计算节点或者登录节点到指定集群。
        /// </summary>
        /// <param name="req"><see cref="AddNodesRequest"/></param>
        /// <returns><see cref="AddNodesResponse"/></returns>
        public AddNodesResponse AddNodesSync(AddNodesRequest req)
        {
             JsonResponseModel<AddNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AddQueue)用于添加队列到指定集群。
        /// * 本接口为目前只支持SchedulerType为SLURM的集群。
        /// * 单个集群中队列数量上限为10个。
        /// </summary>
        /// <param name="req"><see cref="AddQueueRequest"/></param>
        /// <returns><see cref="AddQueueResponse"/></returns>
        public async Task<AddQueueResponse> AddQueue(AddQueueRequest req)
        {
             JsonResponseModel<AddQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AddQueue)用于添加队列到指定集群。
        /// * 本接口为目前只支持SchedulerType为SLURM的集群。
        /// * 单个集群中队列数量上限为10个。
        /// </summary>
        /// <param name="req"><see cref="AddQueueRequest"/></param>
        /// <returns><see cref="AddQueueResponse"/></returns>
        public AddQueueResponse AddQueueSync(AddQueueRequest req)
        {
             JsonResponseModel<AddQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateCluster) 用于创建并启动集群。
        /// 
        /// * 本接口为异步接口， 当创建集群请求下发成功后会返回一个集群`ID`和一个`RequestId`，此时创建集群操作并未立即完成。在此期间集群的状态将会处于“PENDING”或者“INITING”，集群创建结果可以通过调用 [DescribeClusters](https://cloud.tencent.com/document/product/1527/72100)  接口查询，如果集群状态(ClusterStatus)变为“RUNNING(运行中)”，则代表集群创建成功，“ INIT_FAILED”代表集群创建失败。
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
        /// 本接口 (CreateCluster) 用于创建并启动集群。
        /// 
        /// * 本接口为异步接口， 当创建集群请求下发成功后会返回一个集群`ID`和一个`RequestId`，此时创建集群操作并未立即完成。在此期间集群的状态将会处于“PENDING”或者“INITING”，集群创建结果可以通过调用 [DescribeClusters](https://cloud.tencent.com/document/product/1527/72100)  接口查询，如果集群状态(ClusterStatus)变为“RUNNING(运行中)”，则代表集群创建成功，“ INIT_FAILED”代表集群创建失败。
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
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
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
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
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
        /// 本接口 (DeleteClusterStorageOption) 用于删除集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DeleteClusterStorageOptionResponse"/></returns>
        public async Task<DeleteClusterStorageOptionResponse> DeleteClusterStorageOption(DeleteClusterStorageOptionRequest req)
        {
             JsonResponseModel<DeleteClusterStorageOptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterStorageOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterStorageOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteClusterStorageOption) 用于删除集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DeleteClusterStorageOptionResponse"/></returns>
        public DeleteClusterStorageOptionResponse DeleteClusterStorageOptionSync(DeleteClusterStorageOptionRequest req)
        {
             JsonResponseModel<DeleteClusterStorageOptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterStorageOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterStorageOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteNodes)用于删除指定集群中一个或者多个计算节点或者登录节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteNodesRequest"/></param>
        /// <returns><see cref="DeleteNodesResponse"/></returns>
        public async Task<DeleteNodesResponse> DeleteNodes(DeleteNodesRequest req)
        {
             JsonResponseModel<DeleteNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteNodes)用于删除指定集群中一个或者多个计算节点或者登录节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteNodesRequest"/></param>
        /// <returns><see cref="DeleteNodesResponse"/></returns>
        public DeleteNodesResponse DeleteNodesSync(DeleteNodesRequest req)
        {
             JsonResponseModel<DeleteNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteQueue)用于从指定集群删除队列。
        /// * 本接口为目前只支持SchedulerType为SLURM的集群。
        /// 
        /// * 删除队列时，需要保证队列内不存在节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteQueueRequest"/></param>
        /// <returns><see cref="DeleteQueueResponse"/></returns>
        public async Task<DeleteQueueResponse> DeleteQueue(DeleteQueueRequest req)
        {
             JsonResponseModel<DeleteQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteQueue)用于从指定集群删除队列。
        /// * 本接口为目前只支持SchedulerType为SLURM的集群。
        /// 
        /// * 删除队列时，需要保证队列内不存在节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteQueueRequest"/></param>
        /// <returns><see cref="DeleteQueueResponse"/></returns>
        public DeleteQueueResponse DeleteQueueSync(DeleteQueueRequest req)
        {
             JsonResponseModel<DeleteQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAutoScalingConfiguration)用于查询集群弹性伸缩配置信息。本接口仅适用于弹性伸缩类型为THPC_AS的集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingConfigurationResponse"/></returns>
        public async Task<DescribeAutoScalingConfigurationResponse> DescribeAutoScalingConfiguration(DescribeAutoScalingConfigurationRequest req)
        {
             JsonResponseModel<DescribeAutoScalingConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAutoScalingConfiguration)用于查询集群弹性伸缩配置信息。本接口仅适用于弹性伸缩类型为THPC_AS的集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingConfigurationResponse"/></returns>
        public DescribeAutoScalingConfigurationResponse DescribeAutoScalingConfigurationSync(DescribeAutoScalingConfigurationRequest req)
        {
             JsonResponseModel<DescribeAutoScalingConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoScalingConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClusterActivities）用于查询集群活动历史记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterActivitiesRequest"/></param>
        /// <returns><see cref="DescribeClusterActivitiesResponse"/></returns>
        public async Task<DescribeClusterActivitiesResponse> DescribeClusterActivities(DescribeClusterActivitiesRequest req)
        {
             JsonResponseModel<DescribeClusterActivitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClusterActivities）用于查询集群活动历史记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterActivitiesRequest"/></param>
        /// <returns><see cref="DescribeClusterActivitiesResponse"/></returns>
        public DescribeClusterActivitiesResponse DescribeClusterActivitiesSync(DescribeClusterActivitiesRequest req)
        {
             JsonResponseModel<DescribeClusterActivitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeClusterStorageOption) 用于查询集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterStorageOptionResponse"/></returns>
        public async Task<DescribeClusterStorageOptionResponse> DescribeClusterStorageOption(DescribeClusterStorageOptionRequest req)
        {
             JsonResponseModel<DescribeClusterStorageOptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterStorageOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterStorageOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeClusterStorageOption) 用于查询集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterStorageOptionResponse"/></returns>
        public DescribeClusterStorageOptionResponse DescribeClusterStorageOptionSync(DescribeClusterStorageOptionRequest req)
        {
             JsonResponseModel<DescribeClusterStorageOptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterStorageOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterStorageOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClusters）用于查询集群列表。
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
        /// 本接口（DescribeClusters）用于查询集群列表。
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
        /// 本接口 (DescribeInitNodeScripts) 用于查询节点初始化脚本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInitNodeScriptsRequest"/></param>
        /// <returns><see cref="DescribeInitNodeScriptsResponse"/></returns>
        public async Task<DescribeInitNodeScriptsResponse> DescribeInitNodeScripts(DescribeInitNodeScriptsRequest req)
        {
             JsonResponseModel<DescribeInitNodeScriptsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInitNodeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInitNodeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeInitNodeScripts) 用于查询节点初始化脚本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInitNodeScriptsRequest"/></param>
        /// <returns><see cref="DescribeInitNodeScriptsResponse"/></returns>
        public DescribeInitNodeScriptsResponse DescribeInitNodeScriptsSync(DescribeInitNodeScriptsRequest req)
        {
             JsonResponseModel<DescribeInitNodeScriptsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInitNodeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInitNodeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeNodes) 用于查询指定集群节点概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNodesRequest"/></param>
        /// <returns><see cref="DescribeNodesResponse"/></returns>
        public async Task<DescribeNodesResponse> DescribeNodes(DescribeNodesRequest req)
        {
             JsonResponseModel<DescribeNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeNodes) 用于查询指定集群节点概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNodesRequest"/></param>
        /// <returns><see cref="DescribeNodesResponse"/></returns>
        public DescribeNodesResponse DescribeNodesSync(DescribeNodesRequest req)
        {
             JsonResponseModel<DescribeNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeQueues)用于查询指定集群队列概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueuesRequest"/></param>
        /// <returns><see cref="DescribeQueuesResponse"/></returns>
        public async Task<DescribeQueuesResponse> DescribeQueues(DescribeQueuesRequest req)
        {
             JsonResponseModel<DescribeQueuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeQueues)用于查询指定集群队列概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueuesRequest"/></param>
        /// <returns><see cref="DescribeQueuesResponse"/></returns>
        public DescribeQueuesResponse DescribeQueuesSync(DescribeQueuesRequest req)
        {
             JsonResponseModel<DescribeQueuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyInitNodeScripts) 用于修改节点初始化脚本。
        /// </summary>
        /// <param name="req"><see cref="ModifyInitNodeScriptsRequest"/></param>
        /// <returns><see cref="ModifyInitNodeScriptsResponse"/></returns>
        public async Task<ModifyInitNodeScriptsResponse> ModifyInitNodeScripts(ModifyInitNodeScriptsRequest req)
        {
             JsonResponseModel<ModifyInitNodeScriptsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInitNodeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInitNodeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyInitNodeScripts) 用于修改节点初始化脚本。
        /// </summary>
        /// <param name="req"><see cref="ModifyInitNodeScriptsRequest"/></param>
        /// <returns><see cref="ModifyInitNodeScriptsResponse"/></returns>
        public ModifyInitNodeScriptsResponse ModifyInitNodeScriptsSync(ModifyInitNodeScriptsRequest req)
        {
             JsonResponseModel<ModifyInitNodeScriptsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInitNodeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInitNodeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(SetAutoScalingConfiguration)用于为集群设置集群弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="SetAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="SetAutoScalingConfigurationResponse"/></returns>
        public async Task<SetAutoScalingConfigurationResponse> SetAutoScalingConfiguration(SetAutoScalingConfigurationRequest req)
        {
             JsonResponseModel<SetAutoScalingConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAutoScalingConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoScalingConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(SetAutoScalingConfiguration)用于为集群设置集群弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="SetAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="SetAutoScalingConfigurationResponse"/></returns>
        public SetAutoScalingConfigurationResponse SetAutoScalingConfigurationSync(SetAutoScalingConfigurationRequest req)
        {
             JsonResponseModel<SetAutoScalingConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAutoScalingConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoScalingConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
