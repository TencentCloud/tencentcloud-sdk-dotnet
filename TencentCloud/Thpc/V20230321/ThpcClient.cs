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
       private const string sdkVersion = "SDK_NET_3.0.1175";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ThpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（AddClusterStorageOption）用于添加集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="AddClusterStorageOptionRequest"/></param>
        /// <returns><see cref="AddClusterStorageOptionResponse"/></returns>
        public Task<AddClusterStorageOptionResponse> AddClusterStorageOption(AddClusterStorageOptionRequest req)
        {
            return InternalRequestAsync<AddClusterStorageOptionResponse>(req, "AddClusterStorageOption");
        }

        /// <summary>
        /// 本接口（AddClusterStorageOption）用于添加集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="AddClusterStorageOptionRequest"/></param>
        /// <returns><see cref="AddClusterStorageOptionResponse"/></returns>
        public AddClusterStorageOptionResponse AddClusterStorageOptionSync(AddClusterStorageOptionRequest req)
        {
            return InternalRequestAsync<AddClusterStorageOptionResponse>(req, "AddClusterStorageOption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(AddNodes)用于添加一个或者多个计算节点或者登录节点到指定集群。
        /// </summary>
        /// <param name="req"><see cref="AddNodesRequest"/></param>
        /// <returns><see cref="AddNodesResponse"/></returns>
        public Task<AddNodesResponse> AddNodes(AddNodesRequest req)
        {
            return InternalRequestAsync<AddNodesResponse>(req, "AddNodes");
        }

        /// <summary>
        /// 本接口(AddNodes)用于添加一个或者多个计算节点或者登录节点到指定集群。
        /// </summary>
        /// <param name="req"><see cref="AddNodesRequest"/></param>
        /// <returns><see cref="AddNodesResponse"/></returns>
        public AddNodesResponse AddNodesSync(AddNodesRequest req)
        {
            return InternalRequestAsync<AddNodesResponse>(req, "AddNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(AddQueue)用于添加队列到指定集群。
        /// * 本接口为目前只支持SchedulerType为SLURM的集群。
        /// * 单个集群中队列数量上限为10个。
        /// </summary>
        /// <param name="req"><see cref="AddQueueRequest"/></param>
        /// <returns><see cref="AddQueueResponse"/></returns>
        public Task<AddQueueResponse> AddQueue(AddQueueRequest req)
        {
            return InternalRequestAsync<AddQueueResponse>(req, "AddQueue");
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
            return InternalRequestAsync<AddQueueResponse>(req, "AddQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AttachNodes) 用于绑定一个或者多个计算节点指定资源到指定集群中。
        /// </summary>
        /// <param name="req"><see cref="AttachNodesRequest"/></param>
        /// <returns><see cref="AttachNodesResponse"/></returns>
        public Task<AttachNodesResponse> AttachNodes(AttachNodesRequest req)
        {
            return InternalRequestAsync<AttachNodesResponse>(req, "AttachNodes");
        }

        /// <summary>
        /// 本接口 (AttachNodes) 用于绑定一个或者多个计算节点指定资源到指定集群中。
        /// </summary>
        /// <param name="req"><see cref="AttachNodesRequest"/></param>
        /// <returns><see cref="AttachNodesResponse"/></returns>
        public AttachNodesResponse AttachNodesSync(AttachNodesRequest req)
        {
            return InternalRequestAsync<AttachNodesResponse>(req, "AttachNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateCluster) 用于创建并启动集群。
        /// 
        /// * 本接口为异步接口， 当创建集群请求下发成功后会返回一个集群`ID`和一个`RequestId`，此时创建集群操作并未立即完成。在此期间集群的状态将会处于“PENDING”或者“INITING”，集群创建结果可以通过调用 [DescribeClusters](https://cloud.tencent.com/document/product/1527/72100)  接口查询，如果集群状态(ClusterStatus)变为“RUNNING(运行中)”，则代表集群创建成功，“ INIT_FAILED”代表集群创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
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
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateWorkspaces) 用于创建工作空间。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspacesRequest"/></param>
        /// <returns><see cref="CreateWorkspacesResponse"/></returns>
        public Task<CreateWorkspacesResponse> CreateWorkspaces(CreateWorkspacesRequest req)
        {
            return InternalRequestAsync<CreateWorkspacesResponse>(req, "CreateWorkspaces");
        }

        /// <summary>
        /// 本接口 (CreateWorkspaces) 用于创建工作空间。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspacesRequest"/></param>
        /// <returns><see cref="CreateWorkspacesResponse"/></returns>
        public CreateWorkspacesResponse CreateWorkspacesSync(CreateWorkspacesRequest req)
        {
            return InternalRequestAsync<CreateWorkspacesResponse>(req, "CreateWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteClusterStorageOption) 用于删除集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DeleteClusterStorageOptionResponse"/></returns>
        public Task<DeleteClusterStorageOptionResponse> DeleteClusterStorageOption(DeleteClusterStorageOptionRequest req)
        {
            return InternalRequestAsync<DeleteClusterStorageOptionResponse>(req, "DeleteClusterStorageOption");
        }

        /// <summary>
        /// 本接口 (DeleteClusterStorageOption) 用于删除集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DeleteClusterStorageOptionResponse"/></returns>
        public DeleteClusterStorageOptionResponse DeleteClusterStorageOptionSync(DeleteClusterStorageOptionRequest req)
        {
            return InternalRequestAsync<DeleteClusterStorageOptionResponse>(req, "DeleteClusterStorageOption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteNodes)用于删除指定集群中一个或者多个计算节点或者登录节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteNodesRequest"/></param>
        /// <returns><see cref="DeleteNodesResponse"/></returns>
        public Task<DeleteNodesResponse> DeleteNodes(DeleteNodesRequest req)
        {
            return InternalRequestAsync<DeleteNodesResponse>(req, "DeleteNodes");
        }

        /// <summary>
        /// 本接口(DeleteNodes)用于删除指定集群中一个或者多个计算节点或者登录节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteNodesRequest"/></param>
        /// <returns><see cref="DeleteNodesResponse"/></returns>
        public DeleteNodesResponse DeleteNodesSync(DeleteNodesRequest req)
        {
            return InternalRequestAsync<DeleteNodesResponse>(req, "DeleteNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteQueue)用于从指定集群删除队列。
        /// * 本接口为目前只支持SchedulerType为SLURM的集群。
        /// 
        /// * 删除队列时，需要保证队列内不存在节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteQueueRequest"/></param>
        /// <returns><see cref="DeleteQueueResponse"/></returns>
        public Task<DeleteQueueResponse> DeleteQueue(DeleteQueueRequest req)
        {
            return InternalRequestAsync<DeleteQueueResponse>(req, "DeleteQueue");
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
            return InternalRequestAsync<DeleteQueueResponse>(req, "DeleteQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAutoScalingConfiguration)用于查询集群弹性伸缩配置信息。本接口仅适用于弹性伸缩类型为THPC_AS的集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingConfigurationResponse"/></returns>
        public Task<DescribeAutoScalingConfigurationResponse> DescribeAutoScalingConfiguration(DescribeAutoScalingConfigurationRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingConfigurationResponse>(req, "DescribeAutoScalingConfiguration");
        }

        /// <summary>
        /// 本接口(DescribeAutoScalingConfiguration)用于查询集群弹性伸缩配置信息。本接口仅适用于弹性伸缩类型为THPC_AS的集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingConfigurationResponse"/></returns>
        public DescribeAutoScalingConfigurationResponse DescribeAutoScalingConfigurationSync(DescribeAutoScalingConfigurationRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingConfigurationResponse>(req, "DescribeAutoScalingConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusterActivities）用于查询集群活动历史记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterActivitiesRequest"/></param>
        /// <returns><see cref="DescribeClusterActivitiesResponse"/></returns>
        public Task<DescribeClusterActivitiesResponse> DescribeClusterActivities(DescribeClusterActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeClusterActivitiesResponse>(req, "DescribeClusterActivities");
        }

        /// <summary>
        /// 本接口（DescribeClusterActivities）用于查询集群活动历史记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterActivitiesRequest"/></param>
        /// <returns><see cref="DescribeClusterActivitiesResponse"/></returns>
        public DescribeClusterActivitiesResponse DescribeClusterActivitiesSync(DescribeClusterActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeClusterActivitiesResponse>(req, "DescribeClusterActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeClusterStorageOption) 用于查询集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterStorageOptionResponse"/></returns>
        public Task<DescribeClusterStorageOptionResponse> DescribeClusterStorageOption(DescribeClusterStorageOptionRequest req)
        {
            return InternalRequestAsync<DescribeClusterStorageOptionResponse>(req, "DescribeClusterStorageOption");
        }

        /// <summary>
        /// 本接口 (DescribeClusterStorageOption) 用于查询集群存储选项信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStorageOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterStorageOptionResponse"/></returns>
        public DescribeClusterStorageOptionResponse DescribeClusterStorageOptionSync(DescribeClusterStorageOptionRequest req)
        {
            return InternalRequestAsync<DescribeClusterStorageOptionResponse>(req, "DescribeClusterStorageOption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusters）用于查询集群列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 本接口（DescribeClusters）用于查询集群列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeInitNodeScripts) 用于查询节点初始化脚本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInitNodeScriptsRequest"/></param>
        /// <returns><see cref="DescribeInitNodeScriptsResponse"/></returns>
        public Task<DescribeInitNodeScriptsResponse> DescribeInitNodeScripts(DescribeInitNodeScriptsRequest req)
        {
            return InternalRequestAsync<DescribeInitNodeScriptsResponse>(req, "DescribeInitNodeScripts");
        }

        /// <summary>
        /// 本接口 (DescribeInitNodeScripts) 用于查询节点初始化脚本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInitNodeScriptsRequest"/></param>
        /// <returns><see cref="DescribeInitNodeScriptsResponse"/></returns>
        public DescribeInitNodeScriptsResponse DescribeInitNodeScriptsSync(DescribeInitNodeScriptsRequest req)
        {
            return InternalRequestAsync<DescribeInitNodeScriptsResponse>(req, "DescribeInitNodeScripts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeNodes) 用于查询指定集群节点概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNodesRequest"/></param>
        /// <returns><see cref="DescribeNodesResponse"/></returns>
        public Task<DescribeNodesResponse> DescribeNodes(DescribeNodesRequest req)
        {
            return InternalRequestAsync<DescribeNodesResponse>(req, "DescribeNodes");
        }

        /// <summary>
        /// 本接口 (DescribeNodes) 用于查询指定集群节点概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNodesRequest"/></param>
        /// <returns><see cref="DescribeNodesResponse"/></returns>
        public DescribeNodesResponse DescribeNodesSync(DescribeNodesRequest req)
        {
            return InternalRequestAsync<DescribeNodesResponse>(req, "DescribeNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeQueues)用于查询指定集群队列概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueuesRequest"/></param>
        /// <returns><see cref="DescribeQueuesResponse"/></returns>
        public Task<DescribeQueuesResponse> DescribeQueues(DescribeQueuesRequest req)
        {
            return InternalRequestAsync<DescribeQueuesResponse>(req, "DescribeQueues");
        }

        /// <summary>
        /// 本接口(DescribeQueues)用于查询指定集群队列概览信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueuesRequest"/></param>
        /// <returns><see cref="DescribeQueuesResponse"/></returns>
        public DescribeQueuesResponse DescribeQueuesSync(DescribeQueuesRequest req)
        {
            return InternalRequestAsync<DescribeQueuesResponse>(req, "DescribeQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeWorkspaces）用于查询工作空间列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public Task<DescribeWorkspacesResponse> DescribeWorkspaces(DescribeWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkspacesResponse>(req, "DescribeWorkspaces");
        }

        /// <summary>
        /// 本接口（DescribeWorkspaces）用于查询工作空间列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public DescribeWorkspacesResponse DescribeWorkspacesSync(DescribeWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkspacesResponse>(req, "DescribeWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DetachNodes) 用于将一个或者多个计算节点从集群中移除，但是不销毁指定计算资源。
        /// </summary>
        /// <param name="req"><see cref="DetachNodesRequest"/></param>
        /// <returns><see cref="DetachNodesResponse"/></returns>
        public Task<DetachNodesResponse> DetachNodes(DetachNodesRequest req)
        {
            return InternalRequestAsync<DetachNodesResponse>(req, "DetachNodes");
        }

        /// <summary>
        /// 本接口 (DetachNodes) 用于将一个或者多个计算节点从集群中移除，但是不销毁指定计算资源。
        /// </summary>
        /// <param name="req"><see cref="DetachNodesRequest"/></param>
        /// <returns><see cref="DetachNodesResponse"/></returns>
        public DetachNodesResponse DetachNodesSync(DetachNodesRequest req)
        {
            return InternalRequestAsync<DetachNodesResponse>(req, "DetachNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyInitNodeScripts) 用于修改节点初始化脚本。
        /// </summary>
        /// <param name="req"><see cref="ModifyInitNodeScriptsRequest"/></param>
        /// <returns><see cref="ModifyInitNodeScriptsResponse"/></returns>
        public Task<ModifyInitNodeScriptsResponse> ModifyInitNodeScripts(ModifyInitNodeScriptsRequest req)
        {
            return InternalRequestAsync<ModifyInitNodeScriptsResponse>(req, "ModifyInitNodeScripts");
        }

        /// <summary>
        /// 本接口 (ModifyInitNodeScripts) 用于修改节点初始化脚本。
        /// </summary>
        /// <param name="req"><see cref="ModifyInitNodeScriptsRequest"/></param>
        /// <returns><see cref="ModifyInitNodeScriptsResponse"/></returns>
        public ModifyInitNodeScriptsResponse ModifyInitNodeScriptsSync(ModifyInitNodeScriptsRequest req)
        {
            return InternalRequestAsync<ModifyInitNodeScriptsResponse>(req, "ModifyInitNodeScripts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyWorkspacesAttribute) 用于修改工作空间的属性（目前只支持修改工作空间的名称）。
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspacesAttributeRequest"/></param>
        /// <returns><see cref="ModifyWorkspacesAttributeResponse"/></returns>
        public Task<ModifyWorkspacesAttributeResponse> ModifyWorkspacesAttribute(ModifyWorkspacesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyWorkspacesAttributeResponse>(req, "ModifyWorkspacesAttribute");
        }

        /// <summary>
        /// 本接口 (ModifyWorkspacesAttribute) 用于修改工作空间的属性（目前只支持修改工作空间的名称）。
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspacesAttributeRequest"/></param>
        /// <returns><see cref="ModifyWorkspacesAttributeResponse"/></returns>
        public ModifyWorkspacesAttributeResponse ModifyWorkspacesAttributeSync(ModifyWorkspacesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyWorkspacesAttributeResponse>(req, "ModifyWorkspacesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(SetAutoScalingConfiguration)用于为集群设置集群弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="SetAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="SetAutoScalingConfigurationResponse"/></returns>
        public Task<SetAutoScalingConfigurationResponse> SetAutoScalingConfiguration(SetAutoScalingConfigurationRequest req)
        {
            return InternalRequestAsync<SetAutoScalingConfigurationResponse>(req, "SetAutoScalingConfiguration");
        }

        /// <summary>
        /// 本接口(SetAutoScalingConfiguration)用于为集群设置集群弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="SetAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="SetAutoScalingConfigurationResponse"/></returns>
        public SetAutoScalingConfigurationResponse SetAutoScalingConfigurationSync(SetAutoScalingConfigurationRequest req)
        {
            return InternalRequestAsync<SetAutoScalingConfigurationResponse>(req, "SetAutoScalingConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (TerminateWorkspaces) 用于主动退还工作空间。
        /// </summary>
        /// <param name="req"><see cref="TerminateWorkspacesRequest"/></param>
        /// <returns><see cref="TerminateWorkspacesResponse"/></returns>
        public Task<TerminateWorkspacesResponse> TerminateWorkspaces(TerminateWorkspacesRequest req)
        {
            return InternalRequestAsync<TerminateWorkspacesResponse>(req, "TerminateWorkspaces");
        }

        /// <summary>
        /// 本接口 (TerminateWorkspaces) 用于主动退还工作空间。
        /// </summary>
        /// <param name="req"><see cref="TerminateWorkspacesRequest"/></param>
        /// <returns><see cref="TerminateWorkspacesResponse"/></returns>
        public TerminateWorkspacesResponse TerminateWorkspacesSync(TerminateWorkspacesRequest req)
        {
            return InternalRequestAsync<TerminateWorkspacesResponse>(req, "TerminateWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
