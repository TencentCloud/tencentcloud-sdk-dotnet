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

namespace TencentCloud.Dbdc.V20201029
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbdc.V20201029.Models;

   public class DbdcClient : AbstractClient{

       private const string endpoint = "dbdc.tencentcloudapi.com";
       private const string version = "2020-10-29";
       private const string sdkVersion = "SDK_NET_3.0.1454";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbdcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DbdcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 该接口（AddNodesToDBCustomCluster）用于为 DB Custom 集群上架节点。
        /// </summary>
        /// <param name="req"><see cref="AddNodesToDBCustomClusterRequest"/></param>
        /// <returns><see cref="AddNodesToDBCustomClusterResponse"/></returns>
        public Task<AddNodesToDBCustomClusterResponse> AddNodesToDBCustomCluster(AddNodesToDBCustomClusterRequest req)
        {
            return InternalRequestAsync<AddNodesToDBCustomClusterResponse>(req, "AddNodesToDBCustomCluster");
        }

        /// <summary>
        /// 该接口（AddNodesToDBCustomCluster）用于为 DB Custom 集群上架节点。
        /// </summary>
        /// <param name="req"><see cref="AddNodesToDBCustomClusterRequest"/></param>
        /// <returns><see cref="AddNodesToDBCustomClusterResponse"/></returns>
        public AddNodesToDBCustomClusterResponse AddNodesToDBCustomClusterSync(AddNodesToDBCustomClusterRequest req)
        {
            return InternalRequestAsync<AddNodesToDBCustomClusterResponse>(req, "AddNodesToDBCustomCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查服务相关角色是否已创建
        /// </summary>
        /// <param name="req"><see cref="CheckRoleAuthorizedRequest"/></param>
        /// <returns><see cref="CheckRoleAuthorizedResponse"/></returns>
        public Task<CheckRoleAuthorizedResponse> CheckRoleAuthorized(CheckRoleAuthorizedRequest req)
        {
            return InternalRequestAsync<CheckRoleAuthorizedResponse>(req, "CheckRoleAuthorized");
        }

        /// <summary>
        /// 检查服务相关角色是否已创建
        /// </summary>
        /// <param name="req"><see cref="CheckRoleAuthorizedRequest"/></param>
        /// <returns><see cref="CheckRoleAuthorizedResponse"/></returns>
        public CheckRoleAuthorizedResponse CheckRoleAuthorizedSync(CheckRoleAuthorizedRequest req)
        {
            return InternalRequestAsync<CheckRoleAuthorizedResponse>(req, "CheckRoleAuthorized")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateDBCustomCluster）用于创建 DB Custom 集群。
        /// </summary>
        /// <param name="req"><see cref="CreateDBCustomClusterRequest"/></param>
        /// <returns><see cref="CreateDBCustomClusterResponse"/></returns>
        public Task<CreateDBCustomClusterResponse> CreateDBCustomCluster(CreateDBCustomClusterRequest req)
        {
            return InternalRequestAsync<CreateDBCustomClusterResponse>(req, "CreateDBCustomCluster");
        }

        /// <summary>
        /// 该接口（CreateDBCustomCluster）用于创建 DB Custom 集群。
        /// </summary>
        /// <param name="req"><see cref="CreateDBCustomClusterRequest"/></param>
        /// <returns><see cref="CreateDBCustomClusterResponse"/></returns>
        public CreateDBCustomClusterResponse CreateDBCustomClusterSync(CreateDBCustomClusterRequest req)
        {
            return InternalRequestAsync<CreateDBCustomClusterResponse>(req, "CreateDBCustomCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateDBCustomNodes）用于创建 DB Custom 节点(需支付)。
        /// </summary>
        /// <param name="req"><see cref="CreateDBCustomNodesRequest"/></param>
        /// <returns><see cref="CreateDBCustomNodesResponse"/></returns>
        public Task<CreateDBCustomNodesResponse> CreateDBCustomNodes(CreateDBCustomNodesRequest req)
        {
            return InternalRequestAsync<CreateDBCustomNodesResponse>(req, "CreateDBCustomNodes");
        }

        /// <summary>
        /// 该接口（CreateDBCustomNodes）用于创建 DB Custom 节点(需支付)。
        /// </summary>
        /// <param name="req"><see cref="CreateDBCustomNodesRequest"/></param>
        /// <returns><see cref="CreateDBCustomNodesResponse"/></returns>
        public CreateDBCustomNodesResponse CreateDBCustomNodesSync(CreateDBCustomNodesRequest req)
        {
            return InternalRequestAsync<CreateDBCustomNodesResponse>(req, "CreateDBCustomNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口(DescribeDBCustomClusterDetail) 用于查询 DB Custom 集群的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClusterDetailResponse"/></returns>
        public Task<DescribeDBCustomClusterDetailResponse> DescribeDBCustomClusterDetail(DescribeDBCustomClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClusterDetailResponse>(req, "DescribeDBCustomClusterDetail");
        }

        /// <summary>
        /// 该接口(DescribeDBCustomClusterDetail) 用于查询 DB Custom 集群的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClusterDetailResponse"/></returns>
        public DescribeDBCustomClusterDetailResponse DescribeDBCustomClusterDetailSync(DescribeDBCustomClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClusterDetailResponse>(req, "DescribeDBCustomClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeDBCustomClusterKubeconfig）用于查询 DB Custom 集群 Kubeconfig。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClusterKubeconfigResponse"/></returns>
        public Task<DescribeDBCustomClusterKubeconfigResponse> DescribeDBCustomClusterKubeconfig(DescribeDBCustomClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClusterKubeconfigResponse>(req, "DescribeDBCustomClusterKubeconfig");
        }

        /// <summary>
        /// 该接口（DescribeDBCustomClusterKubeconfig）用于查询 DB Custom 集群 Kubeconfig。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClusterKubeconfigResponse"/></returns>
        public DescribeDBCustomClusterKubeconfigResponse DescribeDBCustomClusterKubeconfigSync(DescribeDBCustomClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClusterKubeconfigResponse>(req, "DescribeDBCustomClusterKubeconfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeDBCustomClusterNodes）用于查询 DB Custom 集群中的节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClusterNodesResponse"/></returns>
        public Task<DescribeDBCustomClusterNodesResponse> DescribeDBCustomClusterNodes(DescribeDBCustomClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClusterNodesResponse>(req, "DescribeDBCustomClusterNodes");
        }

        /// <summary>
        /// 该接口（DescribeDBCustomClusterNodes）用于查询 DB Custom 集群中的节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClusterNodesResponse"/></returns>
        public DescribeDBCustomClusterNodesResponse DescribeDBCustomClusterNodesSync(DescribeDBCustomClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClusterNodesResponse>(req, "DescribeDBCustomClusterNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeDBCustomClusters）为DB Custom 集群列表查询接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClustersRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClustersResponse"/></returns>
        public Task<DescribeDBCustomClustersResponse> DescribeDBCustomClusters(DescribeDBCustomClustersRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClustersResponse>(req, "DescribeDBCustomClusters");
        }

        /// <summary>
        /// 该接口（DescribeDBCustomClusters）为DB Custom 集群列表查询接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomClustersRequest"/></param>
        /// <returns><see cref="DescribeDBCustomClustersResponse"/></returns>
        public DescribeDBCustomClustersResponse DescribeDBCustomClustersSync(DescribeDBCustomClustersRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomClustersResponse>(req, "DescribeDBCustomClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeDBCustomImages）用于查询 DB Custom 可用的操作系统镜像列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomImagesRequest"/></param>
        /// <returns><see cref="DescribeDBCustomImagesResponse"/></returns>
        public Task<DescribeDBCustomImagesResponse> DescribeDBCustomImages(DescribeDBCustomImagesRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomImagesResponse>(req, "DescribeDBCustomImages");
        }

        /// <summary>
        /// 该接口（DescribeDBCustomImages）用于查询 DB Custom 可用的操作系统镜像列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomImagesRequest"/></param>
        /// <returns><see cref="DescribeDBCustomImagesResponse"/></returns>
        public DescribeDBCustomImagesResponse DescribeDBCustomImagesSync(DescribeDBCustomImagesRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomImagesResponse>(req, "DescribeDBCustomImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeDBCustomNodes）用于查询 DB Custom 节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomNodesRequest"/></param>
        /// <returns><see cref="DescribeDBCustomNodesResponse"/></returns>
        public Task<DescribeDBCustomNodesResponse> DescribeDBCustomNodes(DescribeDBCustomNodesRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomNodesResponse>(req, "DescribeDBCustomNodes");
        }

        /// <summary>
        /// 该接口（DescribeDBCustomNodes）用于查询 DB Custom 节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomNodesRequest"/></param>
        /// <returns><see cref="DescribeDBCustomNodesResponse"/></returns>
        public DescribeDBCustomNodesResponse DescribeDBCustomNodesSync(DescribeDBCustomNodesRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomNodesResponse>(req, "DescribeDBCustomNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeDBCustomTaskStatus）用于查询 DB Custom 任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDBCustomTaskStatusResponse"/></returns>
        public Task<DescribeDBCustomTaskStatusResponse> DescribeDBCustomTaskStatus(DescribeDBCustomTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomTaskStatusResponse>(req, "DescribeDBCustomTaskStatus");
        }

        /// <summary>
        /// 该接口（DescribeDBCustomTaskStatus）用于查询 DB Custom 任务的状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBCustomTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDBCustomTaskStatusResponse"/></returns>
        public DescribeDBCustomTaskStatusResponse DescribeDBCustomTaskStatusSync(DescribeDBCustomTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeDBCustomTaskStatusResponse>(req, "DescribeDBCustomTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询独享集群内的DB实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// 本接口用于查询独享集群内的DB实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostListRequest"/></param>
        /// <returns><see cref="DescribeHostListResponse"/></returns>
        public Task<DescribeHostListResponse> DescribeHostList(DescribeHostListRequest req)
        {
            return InternalRequestAsync<DescribeHostListResponse>(req, "DescribeHostList");
        }

        /// <summary>
        /// 本接口用于查询主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostListRequest"/></param>
        /// <returns><see cref="DescribeHostListResponse"/></returns>
        public DescribeHostListResponse DescribeHostListSync(DescribeHostListRequest req)
        {
            return InternalRequestAsync<DescribeHostListResponse>(req, "DescribeHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询独享集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public Task<DescribeInstanceDetailResponse> DescribeInstanceDetail(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail");
        }

        /// <summary>
        /// 本接口用于查询独享集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public DescribeInstanceDetailResponse DescribeInstanceDetailSync(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询独享集群实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList");
        }

        /// <summary>
        /// 本接口用于查询独享集群实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据不同地域不同用户，获取集群列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 根据不同地域不同用户，获取集群列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DestroyDBCustomCluster）用于销毁 DB Custom 集群。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBCustomClusterRequest"/></param>
        /// <returns><see cref="DestroyDBCustomClusterResponse"/></returns>
        public Task<DestroyDBCustomClusterResponse> DestroyDBCustomCluster(DestroyDBCustomClusterRequest req)
        {
            return InternalRequestAsync<DestroyDBCustomClusterResponse>(req, "DestroyDBCustomCluster");
        }

        /// <summary>
        /// 该接口（DestroyDBCustomCluster）用于销毁 DB Custom 集群。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBCustomClusterRequest"/></param>
        /// <returns><see cref="DestroyDBCustomClusterResponse"/></returns>
        public DestroyDBCustomClusterResponse DestroyDBCustomClusterSync(DestroyDBCustomClusterRequest req)
        {
            return InternalRequestAsync<DestroyDBCustomClusterResponse>(req, "DestroyDBCustomCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DestroyDBCustomNode）用于销毁 DB Custom 节点。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBCustomNodeRequest"/></param>
        /// <returns><see cref="DestroyDBCustomNodeResponse"/></returns>
        public Task<DestroyDBCustomNodeResponse> DestroyDBCustomNode(DestroyDBCustomNodeRequest req)
        {
            return InternalRequestAsync<DestroyDBCustomNodeResponse>(req, "DestroyDBCustomNode");
        }

        /// <summary>
        /// 该接口（DestroyDBCustomNode）用于销毁 DB Custom 节点。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBCustomNodeRequest"/></param>
        /// <returns><see cref="DestroyDBCustomNodeResponse"/></returns>
        public DestroyDBCustomNodeResponse DestroyDBCustomNodeSync(DestroyDBCustomNodeRequest req)
        {
            return InternalRequestAsync<DestroyDBCustomNodeResponse>(req, "DestroyDBCustomNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口 (IsolateDBCustomNode) 用于隔离 DB Custom 节点。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBCustomNodeRequest"/></param>
        /// <returns><see cref="IsolateDBCustomNodeResponse"/></returns>
        public Task<IsolateDBCustomNodeResponse> IsolateDBCustomNode(IsolateDBCustomNodeRequest req)
        {
            return InternalRequestAsync<IsolateDBCustomNodeResponse>(req, "IsolateDBCustomNode");
        }

        /// <summary>
        /// 该接口 (IsolateDBCustomNode) 用于隔离 DB Custom 节点。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBCustomNodeRequest"/></param>
        /// <returns><see cref="IsolateDBCustomNodeResponse"/></returns>
        public IsolateDBCustomNodeResponse IsolateDBCustomNodeSync(IsolateDBCustomNodeRequest req)
        {
            return InternalRequestAsync<IsolateDBCustomNodeResponse>(req, "IsolateDBCustomNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（ModifyDBCustomClusterTags）用于修改 DB Custom 集群的标签配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBCustomClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyDBCustomClusterTagsResponse"/></returns>
        public Task<ModifyDBCustomClusterTagsResponse> ModifyDBCustomClusterTags(ModifyDBCustomClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyDBCustomClusterTagsResponse>(req, "ModifyDBCustomClusterTags");
        }

        /// <summary>
        /// 该接口（ModifyDBCustomClusterTags）用于修改 DB Custom 集群的标签配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBCustomClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyDBCustomClusterTagsResponse"/></returns>
        public ModifyDBCustomClusterTagsResponse ModifyDBCustomClusterTagsSync(ModifyDBCustomClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyDBCustomClusterTagsResponse>(req, "ModifyDBCustomClusterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（ModifyDBCustomNodeTags）用于修改 DB Custom 节点的标签配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBCustomNodeTagsRequest"/></param>
        /// <returns><see cref="ModifyDBCustomNodeTagsResponse"/></returns>
        public Task<ModifyDBCustomNodeTagsResponse> ModifyDBCustomNodeTags(ModifyDBCustomNodeTagsRequest req)
        {
            return InternalRequestAsync<ModifyDBCustomNodeTagsResponse>(req, "ModifyDBCustomNodeTags");
        }

        /// <summary>
        /// 该接口（ModifyDBCustomNodeTags）用于修改 DB Custom 节点的标签配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBCustomNodeTagsRequest"/></param>
        /// <returns><see cref="ModifyDBCustomNodeTagsResponse"/></returns>
        public ModifyDBCustomNodeTagsResponse ModifyDBCustomNodeTagsSync(ModifyDBCustomNodeTagsRequest req)
        {
            return InternalRequestAsync<ModifyDBCustomNodeTagsResponse>(req, "ModifyDBCustomNodeTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName");
        }

        /// <summary>
        /// 本接口用于修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（RemoveNodesFromDBCustomCluster）用于从 DB Custom 集群移除节点。
        /// </summary>
        /// <param name="req"><see cref="RemoveNodesFromDBCustomClusterRequest"/></param>
        /// <returns><see cref="RemoveNodesFromDBCustomClusterResponse"/></returns>
        public Task<RemoveNodesFromDBCustomClusterResponse> RemoveNodesFromDBCustomCluster(RemoveNodesFromDBCustomClusterRequest req)
        {
            return InternalRequestAsync<RemoveNodesFromDBCustomClusterResponse>(req, "RemoveNodesFromDBCustomCluster");
        }

        /// <summary>
        /// 该接口（RemoveNodesFromDBCustomCluster）用于从 DB Custom 集群移除节点。
        /// </summary>
        /// <param name="req"><see cref="RemoveNodesFromDBCustomClusterRequest"/></param>
        /// <returns><see cref="RemoveNodesFromDBCustomClusterResponse"/></returns>
        public RemoveNodesFromDBCustomClusterResponse RemoveNodesFromDBCustomClusterSync(RemoveNodesFromDBCustomClusterRequest req)
        {
            return InternalRequestAsync<RemoveNodesFromDBCustomClusterResponse>(req, "RemoveNodesFromDBCustomCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（RenewDBCustomNode）用于给 DB Custom 节点续费。
        /// </summary>
        /// <param name="req"><see cref="RenewDBCustomNodeRequest"/></param>
        /// <returns><see cref="RenewDBCustomNodeResponse"/></returns>
        public Task<RenewDBCustomNodeResponse> RenewDBCustomNode(RenewDBCustomNodeRequest req)
        {
            return InternalRequestAsync<RenewDBCustomNodeResponse>(req, "RenewDBCustomNode");
        }

        /// <summary>
        /// 该接口（RenewDBCustomNode）用于给 DB Custom 节点续费。
        /// </summary>
        /// <param name="req"><see cref="RenewDBCustomNodeRequest"/></param>
        /// <returns><see cref="RenewDBCustomNodeResponse"/></returns>
        public RenewDBCustomNodeResponse RenewDBCustomNodeSync(RenewDBCustomNodeRequest req)
        {
            return InternalRequestAsync<RenewDBCustomNodeResponse>(req, "RenewDBCustomNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
