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
       private const string sdkVersion = "SDK_NET_3.0.1500";

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
        /// 本接口 (BindClusterVpc) 用于为IDC集群绑定VPC和子网。
        /// 
        /// * 绑定VPC后，集群可在该VPC内开启专线/VPN代理。
        /// * VpcId和SubnetId为必填参数，且子网必须属于指定的VPC。
        /// * 若集群已开通代理，需先关闭代理（DisableClusterDedicatedProxy）再变更VPC绑定。
        /// </summary>
        /// <param name="req"><see cref="BindClusterVpcRequest"/></param>
        /// <returns><see cref="BindClusterVpcResponse"/></returns>
        public Task<BindClusterVpcResponse> BindClusterVpc(BindClusterVpcRequest req)
        {
            return InternalRequestAsync<BindClusterVpcResponse>(req, "BindClusterVpc");
        }

        /// <summary>
        /// 本接口 (BindClusterVpc) 用于为IDC集群绑定VPC和子网。
        /// 
        /// * 绑定VPC后，集群可在该VPC内开启专线/VPN代理。
        /// * VpcId和SubnetId为必填参数，且子网必须属于指定的VPC。
        /// * 若集群已开通代理，需先关闭代理（DisableClusterDedicatedProxy）再变更VPC绑定。
        /// </summary>
        /// <param name="req"><see cref="BindClusterVpcRequest"/></param>
        /// <returns><see cref="BindClusterVpcResponse"/></returns>
        public BindClusterVpcResponse BindClusterVpcSync(BindClusterVpcRequest req)
        {
            return InternalRequestAsync<BindClusterVpcResponse>(req, "BindClusterVpc")
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
        /// 为指定集群队列创建定时伸缩任务，按计划时间自动调整队列的节点数量。
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public Task<CreateScheduledActionResponse> CreateScheduledAction(CreateScheduledActionRequest req)
        {
            return InternalRequestAsync<CreateScheduledActionResponse>(req, "CreateScheduledAction");
        }

        /// <summary>
        /// 为指定集群队列创建定时伸缩任务，按计划时间自动调整队列的节点数量。
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public CreateScheduledActionResponse CreateScheduledActionSync(CreateScheduledActionRequest req)
        {
            return InternalRequestAsync<CreateScheduledActionResponse>(req, "CreateScheduledAction")
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
        /// 本接口 (DeleteJob) 用于删除一个作业任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob");
        }

        /// <summary>
        /// 本接口 (DeleteJob) 用于删除一个作业任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public DeleteJobResponse DeleteJobSync(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob")
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
        /// 删除指定的定时伸缩任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public Task<DeleteScheduledActionResponse> DeleteScheduledAction(DeleteScheduledActionRequest req)
        {
            return InternalRequestAsync<DeleteScheduledActionResponse>(req, "DeleteScheduledAction");
        }

        /// <summary>
        /// 删除指定的定时伸缩任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public DeleteScheduledActionResponse DeleteScheduledActionSync(DeleteScheduledActionRequest req)
        {
            return InternalRequestAsync<DeleteScheduledActionResponse>(req, "DeleteScheduledAction")
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
        /// 本接口 (DescribeClusterDedicatedProxy) 用于查询IDC集群专线/VPN代理的状态。
        /// 
        /// * 返回终端节点（EndPoint）的当前状态，包括是否就绪、VIP地址等信息。
        /// * 若代理未开通，EndPointReady返回false，EndPointStatus为UNKNOWN。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDedicatedProxyRequest"/></param>
        /// <returns><see cref="DescribeClusterDedicatedProxyResponse"/></returns>
        public Task<DescribeClusterDedicatedProxyResponse> DescribeClusterDedicatedProxy(DescribeClusterDedicatedProxyRequest req)
        {
            return InternalRequestAsync<DescribeClusterDedicatedProxyResponse>(req, "DescribeClusterDedicatedProxy");
        }

        /// <summary>
        /// 本接口 (DescribeClusterDedicatedProxy) 用于查询IDC集群专线/VPN代理的状态。
        /// 
        /// * 返回终端节点（EndPoint）的当前状态，包括是否就绪、VIP地址等信息。
        /// * 若代理未开通，EndPointReady返回false，EndPointStatus为UNKNOWN。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDedicatedProxyRequest"/></param>
        /// <returns><see cref="DescribeClusterDedicatedProxyResponse"/></returns>
        public DescribeClusterDedicatedProxyResponse DescribeClusterDedicatedProxySync(DescribeClusterDedicatedProxyRequest req)
        {
            return InternalRequestAsync<DescribeClusterDedicatedProxyResponse>(req, "DescribeClusterDedicatedProxy")
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
        /// 查询指定集群可用的机型族列表，用于弹性伸缩配置时选择机型族。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFamiliesRequest"/></param>
        /// <returns><see cref="DescribeInstanceFamiliesResponse"/></returns>
        public Task<DescribeInstanceFamiliesResponse> DescribeInstanceFamilies(DescribeInstanceFamiliesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceFamiliesResponse>(req, "DescribeInstanceFamilies");
        }

        /// <summary>
        /// 查询指定集群可用的机型族列表，用于弹性伸缩配置时选择机型族。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFamiliesRequest"/></param>
        /// <returns><see cref="DescribeInstanceFamiliesResponse"/></returns>
        public DescribeInstanceFamiliesResponse DescribeInstanceFamiliesSync(DescribeInstanceFamiliesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceFamiliesResponse>(req, "DescribeInstanceFamilies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询作业的提交信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public Task<DescribeJobSubmitInfoResponse> DescribeJobSubmitInfo(DescribeJobSubmitInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmitInfoResponse>(req, "DescribeJobSubmitInfo");
        }

        /// <summary>
        /// 本接口用于查询作业的提交信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public DescribeJobSubmitInfoResponse DescribeJobSubmitInfoSync(DescribeJobSubmitInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmitInfoResponse>(req, "DescribeJobSubmitInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeJobs) 用于查询作业任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs");
        }

        /// <summary>
        /// 本接口 (DescribeJobs) 用于查询作业任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeJobs) 用于查询作业任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsOverviewRequest"/></param>
        /// <returns><see cref="DescribeJobsOverviewResponse"/></returns>
        public Task<DescribeJobsOverviewResponse> DescribeJobsOverview(DescribeJobsOverviewRequest req)
        {
            return InternalRequestAsync<DescribeJobsOverviewResponse>(req, "DescribeJobsOverview");
        }

        /// <summary>
        /// 本接口 (DescribeJobs) 用于查询作业任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsOverviewRequest"/></param>
        /// <returns><see cref="DescribeJobsOverviewResponse"/></returns>
        public DescribeJobsOverviewResponse DescribeJobsOverviewSync(DescribeJobsOverviewRequest req)
        {
            return InternalRequestAsync<DescribeJobsOverviewResponse>(req, "DescribeJobsOverview")
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
        /// 查询指定集群的队列弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueAutoScalingRequest"/></param>
        /// <returns><see cref="DescribeQueueAutoScalingResponse"/></returns>
        public Task<DescribeQueueAutoScalingResponse> DescribeQueueAutoScaling(DescribeQueueAutoScalingRequest req)
        {
            return InternalRequestAsync<DescribeQueueAutoScalingResponse>(req, "DescribeQueueAutoScaling");
        }

        /// <summary>
        /// 查询指定集群的队列弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueAutoScalingRequest"/></param>
        /// <returns><see cref="DescribeQueueAutoScalingResponse"/></returns>
        public DescribeQueueAutoScalingResponse DescribeQueueAutoScalingSync(DescribeQueueAutoScalingRequest req)
        {
            return InternalRequestAsync<DescribeQueueAutoScalingResponse>(req, "DescribeQueueAutoScaling")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定集群的队列弹性伸缩概览信息，包括期望容量、当前容量、当前动态节点数、有效定时任务数等。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueAutoScalingOverviewRequest"/></param>
        /// <returns><see cref="DescribeQueueAutoScalingOverviewResponse"/></returns>
        public Task<DescribeQueueAutoScalingOverviewResponse> DescribeQueueAutoScalingOverview(DescribeQueueAutoScalingOverviewRequest req)
        {
            return InternalRequestAsync<DescribeQueueAutoScalingOverviewResponse>(req, "DescribeQueueAutoScalingOverview");
        }

        /// <summary>
        /// 查询指定集群的队列弹性伸缩概览信息，包括期望容量、当前容量、当前动态节点数、有效定时任务数等。
        /// </summary>
        /// <param name="req"><see cref="DescribeQueueAutoScalingOverviewRequest"/></param>
        /// <returns><see cref="DescribeQueueAutoScalingOverviewResponse"/></returns>
        public DescribeQueueAutoScalingOverviewResponse DescribeQueueAutoScalingOverviewSync(DescribeQueueAutoScalingOverviewRequest req)
        {
            return InternalRequestAsync<DescribeQueueAutoScalingOverviewResponse>(req, "DescribeQueueAutoScalingOverview")
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
        /// 查询指定集群队列的定时伸缩任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns><see cref="DescribeScheduledActionsResponse"/></returns>
        public Task<DescribeScheduledActionsResponse> DescribeScheduledActions(DescribeScheduledActionsRequest req)
        {
            return InternalRequestAsync<DescribeScheduledActionsResponse>(req, "DescribeScheduledActions");
        }

        /// <summary>
        /// 查询指定集群队列的定时伸缩任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns><see cref="DescribeScheduledActionsResponse"/></returns>
        public DescribeScheduledActionsResponse DescribeScheduledActionsSync(DescribeScheduledActionsRequest req)
        {
            return InternalRequestAsync<DescribeScheduledActionsResponse>(req, "DescribeScheduledActions")
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
        /// 本接口 (DisableClusterDedicatedProxy) 用于关闭IDC集群的专线/VPN代理。
        /// 
        /// * 关闭后，系统将删除VPC终端节点（EndPoint），断开IDC集群与云上VPC的网络连接。
        /// * 若代理未开通，调用将返回ProxyNotEnabled错误。
        /// * 操作不可逆，关闭后需重新调用EnableClusterDedicatedProxy开启。
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDedicatedProxyRequest"/></param>
        /// <returns><see cref="DisableClusterDedicatedProxyResponse"/></returns>
        public Task<DisableClusterDedicatedProxyResponse> DisableClusterDedicatedProxy(DisableClusterDedicatedProxyRequest req)
        {
            return InternalRequestAsync<DisableClusterDedicatedProxyResponse>(req, "DisableClusterDedicatedProxy");
        }

        /// <summary>
        /// 本接口 (DisableClusterDedicatedProxy) 用于关闭IDC集群的专线/VPN代理。
        /// 
        /// * 关闭后，系统将删除VPC终端节点（EndPoint），断开IDC集群与云上VPC的网络连接。
        /// * 若代理未开通，调用将返回ProxyNotEnabled错误。
        /// * 操作不可逆，关闭后需重新调用EnableClusterDedicatedProxy开启。
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDedicatedProxyRequest"/></param>
        /// <returns><see cref="DisableClusterDedicatedProxyResponse"/></returns>
        public DisableClusterDedicatedProxyResponse DisableClusterDedicatedProxySync(DisableClusterDedicatedProxyRequest req)
        {
            return InternalRequestAsync<DisableClusterDedicatedProxyResponse>(req, "DisableClusterDedicatedProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (EnableClusterDedicatedProxy) 用于开启IDC集群的专线/VPN代理。
        /// 
        /// * 开启后，系统将自动创建VPC终端节点（EndPoint），实现IDC集群与云上VPC的网络互通。
        /// * 若代理已开通，重复调用将幂等返回已有EndPoint信息。
        /// * SubnetId与VpcId需同时指定或同时不指定。若不指定，则使用集群已绑定的VPC和子网。
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDedicatedProxyRequest"/></param>
        /// <returns><see cref="EnableClusterDedicatedProxyResponse"/></returns>
        public Task<EnableClusterDedicatedProxyResponse> EnableClusterDedicatedProxy(EnableClusterDedicatedProxyRequest req)
        {
            return InternalRequestAsync<EnableClusterDedicatedProxyResponse>(req, "EnableClusterDedicatedProxy");
        }

        /// <summary>
        /// 本接口 (EnableClusterDedicatedProxy) 用于开启IDC集群的专线/VPN代理。
        /// 
        /// * 开启后，系统将自动创建VPC终端节点（EndPoint），实现IDC集群与云上VPC的网络互通。
        /// * 若代理已开通，重复调用将幂等返回已有EndPoint信息。
        /// * SubnetId与VpcId需同时指定或同时不指定。若不指定，则使用集群已绑定的VPC和子网。
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDedicatedProxyRequest"/></param>
        /// <returns><see cref="EnableClusterDedicatedProxyResponse"/></returns>
        public EnableClusterDedicatedProxyResponse EnableClusterDedicatedProxySync(EnableClusterDedicatedProxyRequest req)
        {
            return InternalRequestAsync<EnableClusterDedicatedProxyResponse>(req, "EnableClusterDedicatedProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GenerateRegisterCode)用于为队列创建一个注册码，注册码用于IDC机器的注册纳管。
        /// </summary>
        /// <param name="req"><see cref="GenerateRegisterCodeRequest"/></param>
        /// <returns><see cref="GenerateRegisterCodeResponse"/></returns>
        public Task<GenerateRegisterCodeResponse> GenerateRegisterCode(GenerateRegisterCodeRequest req)
        {
            return InternalRequestAsync<GenerateRegisterCodeResponse>(req, "GenerateRegisterCode");
        }

        /// <summary>
        /// 本接口(GenerateRegisterCode)用于为队列创建一个注册码，注册码用于IDC机器的注册纳管。
        /// </summary>
        /// <param name="req"><see cref="GenerateRegisterCodeRequest"/></param>
        /// <returns><see cref="GenerateRegisterCodeResponse"/></returns>
        public GenerateRegisterCodeResponse GenerateRegisterCodeSync(GenerateRegisterCodeRequest req)
        {
            return InternalRequestAsync<GenerateRegisterCodeResponse>(req, "GenerateRegisterCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (GenerateRegisterCommand) 用于生成IDC集群的节点注册命令。
        /// 
        /// * 返回的注册命令可直接在IDC机器上以root身份执行，将该机器纳管进指定的IDC集群。
        /// * 当<code>Proxy=true</code>时，系统会先确保集群专线代理就绪（自动开启终端节点并轮询至ACTIVE），再签发注册码并渲染带代理VIP的注册命令；若在超时窗口内代理仍未就绪，将返回<code>FailedOperation.ProxyNotReady</code>。
        /// * 当<code>Proxy=false</code>时，IDC机器需可直连集群，直接签发注册码并渲染注册命令。
        /// * VpcId与SubnetId需同时指定或同时不指定；仅当<code>Proxy=true</code>且集群未绑定VPC时二者必填。当<code>Proxy=false</code>时二者不生效，若仍传入将返回<code>InvalidParameterValue.ParametersNotSupported</code>。
        /// * 若集群此前已开启专线代理并绑定了VPC/子网，本次传入的VpcId/SubnetId与已绑定值不一致时，将返回<code>UnsupportedOperation.VpcAlreadyBound</code>（不支持改绑）。
        /// * 仅支持IDC类型集群，对非IDC集群调用将返回<code>InvalidParameterValue.ParametersNotSupported</code>。
        /// </summary>
        /// <param name="req"><see cref="GenerateRegisterCommandRequest"/></param>
        /// <returns><see cref="GenerateRegisterCommandResponse"/></returns>
        public Task<GenerateRegisterCommandResponse> GenerateRegisterCommand(GenerateRegisterCommandRequest req)
        {
            return InternalRequestAsync<GenerateRegisterCommandResponse>(req, "GenerateRegisterCommand");
        }

        /// <summary>
        /// 本接口 (GenerateRegisterCommand) 用于生成IDC集群的节点注册命令。
        /// 
        /// * 返回的注册命令可直接在IDC机器上以root身份执行，将该机器纳管进指定的IDC集群。
        /// * 当<code>Proxy=true</code>时，系统会先确保集群专线代理就绪（自动开启终端节点并轮询至ACTIVE），再签发注册码并渲染带代理VIP的注册命令；若在超时窗口内代理仍未就绪，将返回<code>FailedOperation.ProxyNotReady</code>。
        /// * 当<code>Proxy=false</code>时，IDC机器需可直连集群，直接签发注册码并渲染注册命令。
        /// * VpcId与SubnetId需同时指定或同时不指定；仅当<code>Proxy=true</code>且集群未绑定VPC时二者必填。当<code>Proxy=false</code>时二者不生效，若仍传入将返回<code>InvalidParameterValue.ParametersNotSupported</code>。
        /// * 若集群此前已开启专线代理并绑定了VPC/子网，本次传入的VpcId/SubnetId与已绑定值不一致时，将返回<code>UnsupportedOperation.VpcAlreadyBound</code>（不支持改绑）。
        /// * 仅支持IDC类型集群，对非IDC集群调用将返回<code>InvalidParameterValue.ParametersNotSupported</code>。
        /// </summary>
        /// <param name="req"><see cref="GenerateRegisterCommandRequest"/></param>
        /// <returns><see cref="GenerateRegisterCommandResponse"/></returns>
        public GenerateRegisterCommandResponse GenerateRegisterCommandSync(GenerateRegisterCommandRequest req)
        {
            return InternalRequestAsync<GenerateRegisterCommandResponse>(req, "GenerateRegisterCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(InquirePriceCreateWorkspaces)用于创建实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateWorkspacesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateWorkspacesResponse"/></returns>
        public Task<InquirePriceCreateWorkspacesResponse> InquirePriceCreateWorkspaces(InquirePriceCreateWorkspacesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateWorkspacesResponse>(req, "InquirePriceCreateWorkspaces");
        }

        /// <summary>
        /// 本接口(InquirePriceCreateWorkspaces)用于创建实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateWorkspacesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateWorkspacesResponse"/></returns>
        public InquirePriceCreateWorkspacesResponse InquirePriceCreateWorkspacesSync(InquirePriceCreateWorkspacesRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateWorkspacesResponse>(req, "InquirePriceCreateWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询按量计费工作空间转换为包年包月的价格。不会创建订单或变更资源。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyWorkspacesChargeTypeRequest"/></param>
        /// <returns><see cref="InquirePriceModifyWorkspacesChargeTypeResponse"/></returns>
        public Task<InquirePriceModifyWorkspacesChargeTypeResponse> InquirePriceModifyWorkspacesChargeType(InquirePriceModifyWorkspacesChargeTypeRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyWorkspacesChargeTypeResponse>(req, "InquirePriceModifyWorkspacesChargeType");
        }

        /// <summary>
        /// 查询按量计费工作空间转换为包年包月的价格。不会创建订单或变更资源。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyWorkspacesChargeTypeRequest"/></param>
        /// <returns><see cref="InquirePriceModifyWorkspacesChargeTypeResponse"/></returns>
        public InquirePriceModifyWorkspacesChargeTypeResponse InquirePriceModifyWorkspacesChargeTypeSync(InquirePriceModifyWorkspacesChargeTypeRequest req)
        {
            return InternalRequestAsync<InquirePriceModifyWorkspacesChargeTypeResponse>(req, "InquirePriceModifyWorkspacesChargeType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群删除保护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="ModifyClusterDeletionProtectionResponse"/></returns>
        public Task<ModifyClusterDeletionProtectionResponse> ModifyClusterDeletionProtection(ModifyClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<ModifyClusterDeletionProtectionResponse>(req, "ModifyClusterDeletionProtection");
        }

        /// <summary>
        /// 修改集群删除保护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="ModifyClusterDeletionProtectionResponse"/></returns>
        public ModifyClusterDeletionProtectionResponse ModifyClusterDeletionProtectionSync(ModifyClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<ModifyClusterDeletionProtectionResponse>(req, "ModifyClusterDeletionProtection")
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
        /// 本接口用于修改节点属性
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeAttributeRequest"/></param>
        /// <returns><see cref="ModifyNodeAttributeResponse"/></returns>
        public Task<ModifyNodeAttributeResponse> ModifyNodeAttribute(ModifyNodeAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNodeAttributeResponse>(req, "ModifyNodeAttribute");
        }

        /// <summary>
        /// 本接口用于修改节点属性
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeAttributeRequest"/></param>
        /// <returns><see cref="ModifyNodeAttributeResponse"/></returns>
        public ModifyNodeAttributeResponse ModifyNodeAttributeSync(ModifyNodeAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNodeAttributeResponse>(req, "ModifyNodeAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改指定的定时伸缩任务配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public Task<ModifyScheduledActionResponse> ModifyScheduledAction(ModifyScheduledActionRequest req)
        {
            return InternalRequestAsync<ModifyScheduledActionResponse>(req, "ModifyScheduledAction");
        }

        /// <summary>
        /// 修改指定的定时伸缩任务配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public ModifyScheduledActionResponse ModifyScheduledActionSync(ModifyScheduledActionRequest req)
        {
            return InternalRequestAsync<ModifyScheduledActionResponse>(req, "ModifyScheduledAction")
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
        /// 正式提交按量计费工作空间转包年包月订单。仅支持 ONLINE 且计费模式为 POSTPAID_BY_HOUR 的工作空间。
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspacesChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyWorkspacesChargeTypeResponse"/></returns>
        public Task<ModifyWorkspacesChargeTypeResponse> ModifyWorkspacesChargeType(ModifyWorkspacesChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyWorkspacesChargeTypeResponse>(req, "ModifyWorkspacesChargeType");
        }

        /// <summary>
        /// 正式提交按量计费工作空间转包年包月订单。仅支持 ONLINE 且计费模式为 POSTPAID_BY_HOUR 的工作空间。
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspacesChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyWorkspacesChargeTypeResponse"/></returns>
        public ModifyWorkspacesChargeTypeResponse ModifyWorkspacesChargeTypeSync(ModifyWorkspacesChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyWorkspacesChargeTypeResponse>(req, "ModifyWorkspacesChargeType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyWorkspacesAttribute) 用于修改工作空间的属性（目前只支持修改工作空间的名称）。
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspacesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyWorkspacesRenewFlagResponse"/></returns>
        public Task<ModifyWorkspacesRenewFlagResponse> ModifyWorkspacesRenewFlag(ModifyWorkspacesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyWorkspacesRenewFlagResponse>(req, "ModifyWorkspacesRenewFlag");
        }

        /// <summary>
        /// 本接口 (ModifyWorkspacesAttribute) 用于修改工作空间的属性（目前只支持修改工作空间的名称）。
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspacesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyWorkspacesRenewFlagResponse"/></returns>
        public ModifyWorkspacesRenewFlagResponse ModifyWorkspacesRenewFlagSync(ModifyWorkspacesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyWorkspacesRenewFlagResponse>(req, "ModifyWorkspacesRenewFlag")
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
        /// 为指定集群的队列配置弹性伸缩策略，包括伸缩容量、扩容方式等。
        /// </summary>
        /// <param name="req"><see cref="SetQueueAutoScalingRequest"/></param>
        /// <returns><see cref="SetQueueAutoScalingResponse"/></returns>
        public Task<SetQueueAutoScalingResponse> SetQueueAutoScaling(SetQueueAutoScalingRequest req)
        {
            return InternalRequestAsync<SetQueueAutoScalingResponse>(req, "SetQueueAutoScaling");
        }

        /// <summary>
        /// 为指定集群的队列配置弹性伸缩策略，包括伸缩容量、扩容方式等。
        /// </summary>
        /// <param name="req"><see cref="SetQueueAutoScalingRequest"/></param>
        /// <returns><see cref="SetQueueAutoScalingResponse"/></returns>
        public SetQueueAutoScalingResponse SetQueueAutoScalingSync(SetQueueAutoScalingRequest req)
        {
            return InternalRequestAsync<SetQueueAutoScalingResponse>(req, "SetQueueAutoScaling")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (SubmitJob) 用于提交一个作业任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitJobRequest"/></param>
        /// <returns><see cref="SubmitJobResponse"/></returns>
        public Task<SubmitJobResponse> SubmitJob(SubmitJobRequest req)
        {
            return InternalRequestAsync<SubmitJobResponse>(req, "SubmitJob");
        }

        /// <summary>
        /// 本接口 (SubmitJob) 用于提交一个作业任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitJobRequest"/></param>
        /// <returns><see cref="SubmitJobResponse"/></returns>
        public SubmitJobResponse SubmitJobSync(SubmitJobRequest req)
        {
            return InternalRequestAsync<SubmitJobResponse>(req, "SubmitJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (TerminateJob) 用于终止一个作业任务。
        /// </summary>
        /// <param name="req"><see cref="TerminateJobRequest"/></param>
        /// <returns><see cref="TerminateJobResponse"/></returns>
        public Task<TerminateJobResponse> TerminateJob(TerminateJobRequest req)
        {
            return InternalRequestAsync<TerminateJobResponse>(req, "TerminateJob");
        }

        /// <summary>
        /// 本接口 (TerminateJob) 用于终止一个作业任务。
        /// </summary>
        /// <param name="req"><see cref="TerminateJobRequest"/></param>
        /// <returns><see cref="TerminateJobResponse"/></returns>
        public TerminateJobResponse TerminateJobSync(TerminateJobRequest req)
        {
            return InternalRequestAsync<TerminateJobResponse>(req, "TerminateJob")
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
