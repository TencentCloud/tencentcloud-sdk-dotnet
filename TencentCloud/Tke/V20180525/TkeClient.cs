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

namespace TencentCloud.Tke.V20180525
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tke.V20180525.Models;

   public class TkeClient : AbstractClient{

       private const string endpoint = "tke.tencentcloudapi.com";
       private const string version = "2018-05-25";
       private const string sdkVersion = "SDK_NET_3.0.965";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 通过此接口，可以获取集群的tke:admin的ClusterRole，即管理员角色，可以用于CAM侧高权限的用户，通过CAM策略给予子账户此接口权限，进而可以通过此接口直接获取到kubernetes集群内的管理员角色。
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public Task<AcquireClusterAdminRoleResponse> AcquireClusterAdminRole(AcquireClusterAdminRoleRequest req)
        {
            return InternalRequestAsync<AcquireClusterAdminRoleResponse>(req, "AcquireClusterAdminRole");
        }

        /// <summary>
        /// 通过此接口，可以获取集群的tke:admin的ClusterRole，即管理员角色，可以用于CAM侧高权限的用户，通过CAM策略给予子账户此接口权限，进而可以通过此接口直接获取到kubernetes集群内的管理员角色。
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public AcquireClusterAdminRoleResponse AcquireClusterAdminRoleSync(AcquireClusterAdminRoleRequest req)
        {
            return InternalRequestAsync<AcquireClusterAdminRoleResponse>(req, "AcquireClusterAdminRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 给GR集群增加可用的ClusterCIDR（开白才能使用此功能，如需要请联系我们）
        /// </summary>
        /// <param name="req"><see cref="AddClusterCIDRRequest"/></param>
        /// <returns><see cref="AddClusterCIDRResponse"/></returns>
        public Task<AddClusterCIDRResponse> AddClusterCIDR(AddClusterCIDRRequest req)
        {
            return InternalRequestAsync<AddClusterCIDRResponse>(req, "AddClusterCIDR");
        }

        /// <summary>
        /// 给GR集群增加可用的ClusterCIDR（开白才能使用此功能，如需要请联系我们）
        /// </summary>
        /// <param name="req"><see cref="AddClusterCIDRRequest"/></param>
        /// <returns><see cref="AddClusterCIDRResponse"/></returns>
        public AddClusterCIDRResponse AddClusterCIDRSync(AddClusterCIDRRequest req)
        {
            return InternalRequestAsync<AddClusterCIDRResponse>(req, "AddClusterCIDR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加已经存在的实例到集群
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public Task<AddExistedInstancesResponse> AddExistedInstances(AddExistedInstancesRequest req)
        {
            return InternalRequestAsync<AddExistedInstancesResponse>(req, "AddExistedInstances");
        }

        /// <summary>
        /// 添加已经存在的实例到集群
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public AddExistedInstancesResponse AddExistedInstancesSync(AddExistedInstancesRequest req)
        {
            return InternalRequestAsync<AddExistedInstancesResponse>(req, "AddExistedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将集群内节点移入节点池
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public Task<AddNodeToNodePoolResponse> AddNodeToNodePool(AddNodeToNodePoolRequest req)
        {
            return InternalRequestAsync<AddNodeToNodePoolResponse>(req, "AddNodeToNodePool");
        }

        /// <summary>
        /// 将集群内节点移入节点池
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public AddNodeToNodePoolResponse AddNodeToNodePoolSync(AddNodeToNodePoolRequest req)
        {
            return InternalRequestAsync<AddNodeToNodePoolResponse>(req, "AddNodeToNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对VPC-CNI模式的集群，增加集群容器网络可使用的子网
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public Task<AddVpcCniSubnetsResponse> AddVpcCniSubnets(AddVpcCniSubnetsRequest req)
        {
            return InternalRequestAsync<AddVpcCniSubnetsResponse>(req, "AddVpcCniSubnets");
        }

        /// <summary>
        /// 针对VPC-CNI模式的集群，增加集群容器网络可使用的子网
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public AddVpcCniSubnetsResponse AddVpcCniSubnetsSync(AddVpcCniSubnetsRequest req)
        {
            return InternalRequestAsync<AddVpcCniSubnetsResponse>(req, "AddVpcCniSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在应用市场中取消安装失败的应用
        /// </summary>
        /// <param name="req"><see cref="CancelClusterReleaseRequest"/></param>
        /// <returns><see cref="CancelClusterReleaseResponse"/></returns>
        public Task<CancelClusterReleaseResponse> CancelClusterRelease(CancelClusterReleaseRequest req)
        {
            return InternalRequestAsync<CancelClusterReleaseResponse>(req, "CancelClusterRelease");
        }

        /// <summary>
        /// 在应用市场中取消安装失败的应用
        /// </summary>
        /// <param name="req"><see cref="CancelClusterReleaseRequest"/></param>
        /// <returns><see cref="CancelClusterReleaseResponse"/></returns>
        public CancelClusterReleaseResponse CancelClusterReleaseSync(CancelClusterReleaseRequest req)
        {
            return InternalRequestAsync<CancelClusterReleaseResponse>(req, "CancelClusterRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查边缘计算集群的CIDR是否冲突
        /// </summary>
        /// <param name="req"><see cref="CheckEdgeClusterCIDRRequest"/></param>
        /// <returns><see cref="CheckEdgeClusterCIDRResponse"/></returns>
        public Task<CheckEdgeClusterCIDRResponse> CheckEdgeClusterCIDR(CheckEdgeClusterCIDRRequest req)
        {
            return InternalRequestAsync<CheckEdgeClusterCIDRResponse>(req, "CheckEdgeClusterCIDR");
        }

        /// <summary>
        /// 检查边缘计算集群的CIDR是否冲突
        /// </summary>
        /// <param name="req"><see cref="CheckEdgeClusterCIDRRequest"/></param>
        /// <returns><see cref="CheckEdgeClusterCIDRResponse"/></returns>
        public CheckEdgeClusterCIDRResponse CheckEdgeClusterCIDRSync(CheckEdgeClusterCIDRRequest req)
        {
            return InternalRequestAsync<CheckEdgeClusterCIDRResponse>(req, "CheckEdgeClusterCIDR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查给定节点列表中哪些是可升级的
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public Task<CheckInstancesUpgradeAbleResponse> CheckInstancesUpgradeAble(CheckInstancesUpgradeAbleRequest req)
        {
            return InternalRequestAsync<CheckInstancesUpgradeAbleResponse>(req, "CheckInstancesUpgradeAble");
        }

        /// <summary>
        /// 检查给定节点列表中哪些是可升级的
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public CheckInstancesUpgradeAbleResponse CheckInstancesUpgradeAbleSync(CheckInstancesUpgradeAbleRequest req)
        {
            return InternalRequestAsync<CheckInstancesUpgradeAbleResponse>(req, "CheckInstancesUpgradeAble")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建备份仓库，指定了存储仓库类型（如COS）、COS桶地区、名称等信息，当前最多允许创建100个仓库， 注意此接口当前是全局接口，多个地域的TKE集群如果要备份到相同的备份仓库中，不需要重复创建备份仓库
        /// </summary>
        /// <param name="req"><see cref="CreateBackupStorageLocationRequest"/></param>
        /// <returns><see cref="CreateBackupStorageLocationResponse"/></returns>
        public Task<CreateBackupStorageLocationResponse> CreateBackupStorageLocation(CreateBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<CreateBackupStorageLocationResponse>(req, "CreateBackupStorageLocation");
        }

        /// <summary>
        /// 创建备份仓库，指定了存储仓库类型（如COS）、COS桶地区、名称等信息，当前最多允许创建100个仓库， 注意此接口当前是全局接口，多个地域的TKE集群如果要备份到相同的备份仓库中，不需要重复创建备份仓库
        /// </summary>
        /// <param name="req"><see cref="CreateBackupStorageLocationRequest"/></param>
        /// <returns><see cref="CreateBackupStorageLocationResponse"/></returns>
        public CreateBackupStorageLocationResponse CreateBackupStorageLocationSync(CreateBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<CreateBackupStorageLocationResponse>(req, "CreateBackupStorageLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogConfigRequest"/></param>
        /// <returns><see cref="CreateCLSLogConfigResponse"/></returns>
        public Task<CreateCLSLogConfigResponse> CreateCLSLogConfig(CreateCLSLogConfigRequest req)
        {
            return InternalRequestAsync<CreateCLSLogConfigResponse>(req, "CreateCLSLogConfig");
        }

        /// <summary>
        /// 创建日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogConfigRequest"/></param>
        /// <returns><see cref="CreateCLSLogConfigResponse"/></returns>
        public CreateCLSLogConfigResponse CreateCLSLogConfigSync(CreateCLSLogConfigRequest req)
        {
            return InternalRequestAsync<CreateCLSLogConfigResponse>(req, "CreateCLSLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群访问端口
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public Task<CreateClusterEndpointResponse> CreateClusterEndpoint(CreateClusterEndpointRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointResponse>(req, "CreateClusterEndpoint");
        }

        /// <summary>
        /// 创建集群访问端口
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public CreateClusterEndpointResponse CreateClusterEndpointSync(CreateClusterEndpointRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointResponse>(req, "CreateClusterEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建托管集群外网访问端口（不再维护，准备下线）请使用新接口：CreateClusterEndpoint
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public Task<CreateClusterEndpointVipResponse> CreateClusterEndpointVip(CreateClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointVipResponse>(req, "CreateClusterEndpointVip");
        }

        /// <summary>
        /// 创建托管集群外网访问端口（不再维护，准备下线）请使用新接口：CreateClusterEndpoint
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public CreateClusterEndpointVipResponse CreateClusterEndpointVipSync(CreateClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointVipResponse>(req, "CreateClusterEndpointVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩展(新建)集群节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
            return InternalRequestAsync<CreateClusterInstancesResponse>(req, "CreateClusterInstances");
        }

        /// <summary>
        /// 扩展(新建)集群节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public CreateClusterInstancesResponse CreateClusterInstancesSync(CreateClusterInstancesRequest req)
        {
            return InternalRequestAsync<CreateClusterInstancesResponse>(req, "CreateClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public Task<CreateClusterNodePoolResponse> CreateClusterNodePool(CreateClusterNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterNodePoolResponse>(req, "CreateClusterNodePool");
        }

        /// <summary>
        /// 创建节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public CreateClusterNodePoolResponse CreateClusterNodePoolSync(CreateClusterNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterNodePoolResponse>(req, "CreateClusterNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateClusterReleaseRequest"/></param>
        /// <returns><see cref="CreateClusterReleaseResponse"/></returns>
        public Task<CreateClusterReleaseResponse> CreateClusterRelease(CreateClusterReleaseRequest req)
        {
            return InternalRequestAsync<CreateClusterReleaseResponse>(req, "CreateClusterRelease");
        }

        /// <summary>
        /// 集群创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateClusterReleaseRequest"/></param>
        /// <returns><see cref="CreateClusterReleaseResponse"/></returns>
        public CreateClusterReleaseResponse CreateClusterReleaseSync(CreateClusterReleaseRequest req)
        {
            return InternalRequestAsync<CreateClusterReleaseResponse>(req, "CreateClusterRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群路由
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteRequest"/></param>
        /// <returns><see cref="CreateClusterRouteResponse"/></returns>
        public Task<CreateClusterRouteResponse> CreateClusterRoute(CreateClusterRouteRequest req)
        {
            return InternalRequestAsync<CreateClusterRouteResponse>(req, "CreateClusterRoute");
        }

        /// <summary>
        /// 创建集群路由
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteRequest"/></param>
        /// <returns><see cref="CreateClusterRouteResponse"/></returns>
        public CreateClusterRouteResponse CreateClusterRouteSync(CreateClusterRouteRequest req)
        {
            return InternalRequestAsync<CreateClusterRouteResponse>(req, "CreateClusterRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群路由表
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public Task<CreateClusterRouteTableResponse> CreateClusterRouteTable(CreateClusterRouteTableRequest req)
        {
            return InternalRequestAsync<CreateClusterRouteTableResponse>(req, "CreateClusterRouteTable");
        }

        /// <summary>
        /// 创建集群路由表
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public CreateClusterRouteTableResponse CreateClusterRouteTableSync(CreateClusterRouteTableRequest req)
        {
            return InternalRequestAsync<CreateClusterRouteTableResponse>(req, "CreateClusterRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建按量计费超级节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodeResponse"/></returns>
        public Task<CreateClusterVirtualNodeResponse> CreateClusterVirtualNode(CreateClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodeResponse>(req, "CreateClusterVirtualNode");
        }

        /// <summary>
        /// 创建按量计费超级节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodeResponse"/></returns>
        public CreateClusterVirtualNodeResponse CreateClusterVirtualNodeSync(CreateClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodeResponse>(req, "CreateClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建超级节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodePoolResponse"/></returns>
        public Task<CreateClusterVirtualNodePoolResponse> CreateClusterVirtualNodePool(CreateClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodePoolResponse>(req, "CreateClusterVirtualNodePool");
        }

        /// <summary>
        /// 创建超级节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodePoolResponse"/></returns>
        public CreateClusterVirtualNodePoolResponse CreateClusterVirtualNodePoolSync(CreateClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodePoolResponse>(req, "CreateClusterVirtualNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘计算ECM机器
        /// </summary>
        /// <param name="req"><see cref="CreateECMInstancesRequest"/></param>
        /// <returns><see cref="CreateECMInstancesResponse"/></returns>
        public Task<CreateECMInstancesResponse> CreateECMInstances(CreateECMInstancesRequest req)
        {
            return InternalRequestAsync<CreateECMInstancesResponse>(req, "CreateECMInstances");
        }

        /// <summary>
        /// 创建边缘计算ECM机器
        /// </summary>
        /// <param name="req"><see cref="CreateECMInstancesRequest"/></param>
        /// <returns><see cref="CreateECMInstancesResponse"/></returns>
        public CreateECMInstancesResponse CreateECMInstancesSync(CreateECMInstancesRequest req)
        {
            return InternalRequestAsync<CreateECMInstancesResponse>(req, "CreateECMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建弹性集群
        /// </summary>
        /// <param name="req"><see cref="CreateEKSClusterRequest"/></param>
        /// <returns><see cref="CreateEKSClusterResponse"/></returns>
        public Task<CreateEKSClusterResponse> CreateEKSCluster(CreateEKSClusterRequest req)
        {
            return InternalRequestAsync<CreateEKSClusterResponse>(req, "CreateEKSCluster");
        }

        /// <summary>
        /// 创建弹性集群
        /// </summary>
        /// <param name="req"><see cref="CreateEKSClusterRequest"/></param>
        /// <returns><see cref="CreateEKSClusterResponse"/></returns>
        public CreateEKSClusterResponse CreateEKSClusterSync(CreateEKSClusterRequest req)
        {
            return InternalRequestAsync<CreateEKSClusterResponse>(req, "CreateEKSCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建容器实例
        /// </summary>
        /// <param name="req"><see cref="CreateEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="CreateEKSContainerInstancesResponse"/></returns>
        public Task<CreateEKSContainerInstancesResponse> CreateEKSContainerInstances(CreateEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<CreateEKSContainerInstancesResponse>(req, "CreateEKSContainerInstances");
        }

        /// <summary>
        /// 创建容器实例
        /// </summary>
        /// <param name="req"><see cref="CreateEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="CreateEKSContainerInstancesResponse"/></returns>
        public CreateEKSContainerInstancesResponse CreateEKSContainerInstancesSync(CreateEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<CreateEKSContainerInstancesResponse>(req, "CreateEKSContainerInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘容器CVM机器
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="CreateEdgeCVMInstancesResponse"/></returns>
        public Task<CreateEdgeCVMInstancesResponse> CreateEdgeCVMInstances(CreateEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<CreateEdgeCVMInstancesResponse>(req, "CreateEdgeCVMInstances");
        }

        /// <summary>
        /// 创建边缘容器CVM机器
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="CreateEdgeCVMInstancesResponse"/></returns>
        public CreateEdgeCVMInstancesResponse CreateEdgeCVMInstancesSync(CreateEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<CreateEdgeCVMInstancesResponse>(req, "CreateEdgeCVMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘集群日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeLogConfigRequest"/></param>
        /// <returns><see cref="CreateEdgeLogConfigResponse"/></returns>
        public Task<CreateEdgeLogConfigResponse> CreateEdgeLogConfig(CreateEdgeLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEdgeLogConfigResponse>(req, "CreateEdgeLogConfig");
        }

        /// <summary>
        /// 创建边缘集群日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeLogConfigRequest"/></param>
        /// <returns><see cref="CreateEdgeLogConfigResponse"/></returns>
        public CreateEdgeLogConfigResponse CreateEdgeLogConfigSync(CreateEdgeLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEdgeLogConfigResponse>(req, "CreateEdgeLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为弹性集群创建日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateEksLogConfigRequest"/></param>
        /// <returns><see cref="CreateEksLogConfigResponse"/></returns>
        public Task<CreateEksLogConfigResponse> CreateEksLogConfig(CreateEksLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEksLogConfigResponse>(req, "CreateEksLogConfig");
        }

        /// <summary>
        /// 为弹性集群创建日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateEksLogConfigRequest"/></param>
        /// <returns><see cref="CreateEksLogConfigResponse"/></returns>
        public CreateEksLogConfigResponse CreateEksLogConfigSync(CreateEksLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEksLogConfigResponse>(req, "CreateEksLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像缓存的接口。创建过程中，请勿删除EKSCI实例和云盘，否则镜像缓存将创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateImageCacheRequest"/></param>
        /// <returns><see cref="CreateImageCacheResponse"/></returns>
        public Task<CreateImageCacheResponse> CreateImageCache(CreateImageCacheRequest req)
        {
            return InternalRequestAsync<CreateImageCacheResponse>(req, "CreateImageCache");
        }

        /// <summary>
        /// 创建镜像缓存的接口。创建过程中，请勿删除EKSCI实例和云盘，否则镜像缓存将创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateImageCacheRequest"/></param>
        /// <returns><see cref="CreateImageCacheResponse"/></returns>
        public CreateImageCacheResponse CreateImageCacheSync(CreateImageCacheRequest req)
        {
            return InternalRequestAsync<CreateImageCacheResponse>(req, "CreateImageCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public Task<CreatePrometheusAlertPolicyResponse> CreatePrometheusAlertPolicy(CreatePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertPolicyResponse>(req, "CreatePrometheusAlertPolicy");
        }

        /// <summary>
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public CreatePrometheusAlertPolicyResponse CreatePrometheusAlertPolicySync(CreatePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertPolicyResponse>(req, "CreatePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建告警规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertRuleResponse"/></returns>
        public Task<CreatePrometheusAlertRuleResponse> CreatePrometheusAlertRule(CreatePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertRuleResponse>(req, "CreatePrometheusAlertRule");
        }

        /// <summary>
        /// 创建告警规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertRuleResponse"/></returns>
        public CreatePrometheusAlertRuleResponse CreatePrometheusAlertRuleSync(CreatePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertRuleResponse>(req, "CreatePrometheusAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 与云监控融合的2.0实例关联集群
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public Task<CreatePrometheusClusterAgentResponse> CreatePrometheusClusterAgent(CreatePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusClusterAgentResponse>(req, "CreatePrometheusClusterAgent");
        }

        /// <summary>
        /// 与云监控融合的2.0实例关联集群
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public CreatePrometheusClusterAgentResponse CreatePrometheusClusterAgentSync(CreatePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusClusterAgentResponse>(req, "CreatePrometheusClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建prometheus配置
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public Task<CreatePrometheusConfigResponse> CreatePrometheusConfig(CreatePrometheusConfigRequest req)
        {
            return InternalRequestAsync<CreatePrometheusConfigResponse>(req, "CreatePrometheusConfig");
        }

        /// <summary>
        /// 创建prometheus配置
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public CreatePrometheusConfigResponse CreatePrometheusConfigSync(CreatePrometheusConfigRequest req)
        {
            return InternalRequestAsync<CreatePrometheusConfigResponse>(req, "CreatePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建grafana监控面板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusDashboardRequest"/></param>
        /// <returns><see cref="CreatePrometheusDashboardResponse"/></returns>
        public Task<CreatePrometheusDashboardResponse> CreatePrometheusDashboard(CreatePrometheusDashboardRequest req)
        {
            return InternalRequestAsync<CreatePrometheusDashboardResponse>(req, "CreatePrometheusDashboard");
        }

        /// <summary>
        /// 创建grafana监控面板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusDashboardRequest"/></param>
        /// <returns><see cref="CreatePrometheusDashboardResponse"/></returns>
        public CreatePrometheusDashboardResponse CreatePrometheusDashboardSync(CreatePrometheusDashboardRequest req)
        {
            return InternalRequestAsync<CreatePrometheusDashboardResponse>(req, "CreatePrometheusDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public Task<CreatePrometheusGlobalNotificationResponse> CreatePrometheusGlobalNotification(CreatePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<CreatePrometheusGlobalNotificationResponse>(req, "CreatePrometheusGlobalNotification");
        }

        /// <summary>
        /// 创建全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public CreatePrometheusGlobalNotificationResponse CreatePrometheusGlobalNotificationSync(CreatePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<CreatePrometheusGlobalNotificationResponse>(req, "CreatePrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以Yaml的方式创建聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public Task<CreatePrometheusRecordRuleYamlResponse> CreatePrometheusRecordRuleYaml(CreatePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<CreatePrometheusRecordRuleYamlResponse>(req, "CreatePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// 以Yaml的方式创建聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public CreatePrometheusRecordRuleYamlResponse CreatePrometheusRecordRuleYamlSync(CreatePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<CreatePrometheusRecordRuleYamlResponse>(req, "CreatePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public Task<CreatePrometheusTempResponse> CreatePrometheusTemp(CreatePrometheusTempRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTempResponse>(req, "CreatePrometheusTemp");
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public CreatePrometheusTempResponse CreatePrometheusTempSync(CreatePrometheusTempRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTempResponse>(req, "CreatePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板实例
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTemplateRequest"/></param>
        /// <returns><see cref="CreatePrometheusTemplateResponse"/></returns>
        public Task<CreatePrometheusTemplateResponse> CreatePrometheusTemplate(CreatePrometheusTemplateRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTemplateResponse>(req, "CreatePrometheusTemplate");
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板实例
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTemplateRequest"/></param>
        /// <returns><see cref="CreatePrometheusTemplateResponse"/></returns>
        public CreatePrometheusTemplateResponse CreatePrometheusTemplateSync(CreatePrometheusTemplateRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTemplateResponse>(req, "CreatePrometheusTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 预留券实例的购买会预先扣除本次实例购买所需金额，在调用本接口前请确保账户余额充足。
        /// </summary>
        /// <param name="req"><see cref="CreateReservedInstancesRequest"/></param>
        /// <returns><see cref="CreateReservedInstancesResponse"/></returns>
        public Task<CreateReservedInstancesResponse> CreateReservedInstances(CreateReservedInstancesRequest req)
        {
            return InternalRequestAsync<CreateReservedInstancesResponse>(req, "CreateReservedInstances");
        }

        /// <summary>
        /// 预留券实例的购买会预先扣除本次实例购买所需金额，在调用本接口前请确保账户余额充足。
        /// </summary>
        /// <param name="req"><see cref="CreateReservedInstancesRequest"/></param>
        /// <returns><see cref="CreateReservedInstancesResponse"/></returns>
        public CreateReservedInstancesResponse CreateReservedInstancesSync(CreateReservedInstancesRequest req)
        {
            return InternalRequestAsync<CreateReservedInstancesResponse>(req, "CreateReservedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="CreateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="CreateTKEEdgeClusterResponse"/></returns>
        public Task<CreateTKEEdgeClusterResponse> CreateTKEEdgeCluster(CreateTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<CreateTKEEdgeClusterResponse>(req, "CreateTKEEdgeCluster");
        }

        /// <summary>
        /// 创建边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="CreateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="CreateTKEEdgeClusterResponse"/></returns>
        public CreateTKEEdgeClusterResponse CreateTKEEdgeClusterSync(CreateTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<CreateTKEEdgeClusterResponse>(req, "CreateTKEEdgeCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一个addon
        /// </summary>
        /// <param name="req"><see cref="DeleteAddonRequest"/></param>
        /// <returns><see cref="DeleteAddonResponse"/></returns>
        public Task<DeleteAddonResponse> DeleteAddon(DeleteAddonRequest req)
        {
            return InternalRequestAsync<DeleteAddonResponse>(req, "DeleteAddon");
        }

        /// <summary>
        /// 删除一个addon
        /// </summary>
        /// <param name="req"><see cref="DeleteAddonRequest"/></param>
        /// <returns><see cref="DeleteAddonResponse"/></returns>
        public DeleteAddonResponse DeleteAddonSync(DeleteAddonRequest req)
        {
            return InternalRequestAsync<DeleteAddonResponse>(req, "DeleteAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupStorageLocationRequest"/></param>
        /// <returns><see cref="DeleteBackupStorageLocationResponse"/></returns>
        public Task<DeleteBackupStorageLocationResponse> DeleteBackupStorageLocation(DeleteBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<DeleteBackupStorageLocationResponse>(req, "DeleteBackupStorageLocation");
        }

        /// <summary>
        /// 删除备份仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupStorageLocationRequest"/></param>
        /// <returns><see cref="DeleteBackupStorageLocationResponse"/></returns>
        public DeleteBackupStorageLocationResponse DeleteBackupStorageLocationSync(DeleteBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<DeleteBackupStorageLocationResponse>(req, "DeleteBackupStorageLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群(YUNAPI V3版本)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 删除集群(YUNAPI V3版本)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群伸缩组
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public Task<DeleteClusterAsGroupsResponse> DeleteClusterAsGroups(DeleteClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DeleteClusterAsGroupsResponse>(req, "DeleteClusterAsGroups");
        }

        /// <summary>
        /// 删除集群伸缩组
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public DeleteClusterAsGroupsResponse DeleteClusterAsGroupsSync(DeleteClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DeleteClusterAsGroupsResponse>(req, "DeleteClusterAsGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群访问端口
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public Task<DeleteClusterEndpointResponse> DeleteClusterEndpoint(DeleteClusterEndpointRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointResponse>(req, "DeleteClusterEndpoint");
        }

        /// <summary>
        /// 删除集群访问端口
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public DeleteClusterEndpointResponse DeleteClusterEndpointSync(DeleteClusterEndpointRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointResponse>(req, "DeleteClusterEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除托管集群外网访问端口（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public Task<DeleteClusterEndpointVipResponse> DeleteClusterEndpointVip(DeleteClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointVipResponse>(req, "DeleteClusterEndpointVip");
        }

        /// <summary>
        /// 删除托管集群外网访问端口（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public DeleteClusterEndpointVipResponse DeleteClusterEndpointVipSync(DeleteClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointVipResponse>(req, "DeleteClusterEndpointVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群中的实例
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteClusterInstancesResponse>(req, "DeleteClusterInstances");
        }

        /// <summary>
        /// 删除集群中的实例
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public DeleteClusterInstancesResponse DeleteClusterInstancesSync(DeleteClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteClusterInstancesResponse>(req, "DeleteClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public Task<DeleteClusterNodePoolResponse> DeleteClusterNodePool(DeleteClusterNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterNodePoolResponse>(req, "DeleteClusterNodePool");
        }

        /// <summary>
        /// 删除节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public DeleteClusterNodePoolResponse DeleteClusterNodePoolSync(DeleteClusterNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterNodePoolResponse>(req, "DeleteClusterNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群路由
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public Task<DeleteClusterRouteResponse> DeleteClusterRoute(DeleteClusterRouteRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteResponse>(req, "DeleteClusterRoute");
        }

        /// <summary>
        /// 删除集群路由
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public DeleteClusterRouteResponse DeleteClusterRouteSync(DeleteClusterRouteRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteResponse>(req, "DeleteClusterRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public Task<DeleteClusterRouteTableResponse> DeleteClusterRouteTable(DeleteClusterRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteTableResponse>(req, "DeleteClusterRouteTable");
        }

        /// <summary>
        /// 删除集群路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public DeleteClusterRouteTableResponse DeleteClusterRouteTableSync(DeleteClusterRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteTableResponse>(req, "DeleteClusterRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除超级节点
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodeResponse"/></returns>
        public Task<DeleteClusterVirtualNodeResponse> DeleteClusterVirtualNode(DeleteClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodeResponse>(req, "DeleteClusterVirtualNode");
        }

        /// <summary>
        /// 删除超级节点
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodeResponse"/></returns>
        public DeleteClusterVirtualNodeResponse DeleteClusterVirtualNodeSync(DeleteClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodeResponse>(req, "DeleteClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除超级节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodePoolResponse"/></returns>
        public Task<DeleteClusterVirtualNodePoolResponse> DeleteClusterVirtualNodePool(DeleteClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodePoolResponse>(req, "DeleteClusterVirtualNodePool");
        }

        /// <summary>
        /// 删除超级节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodePoolResponse"/></returns>
        public DeleteClusterVirtualNodePoolResponse DeleteClusterVirtualNodePoolSync(DeleteClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodePoolResponse>(req, "DeleteClusterVirtualNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除ECM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteECMInstancesRequest"/></param>
        /// <returns><see cref="DeleteECMInstancesResponse"/></returns>
        public Task<DeleteECMInstancesResponse> DeleteECMInstances(DeleteECMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteECMInstancesResponse>(req, "DeleteECMInstances");
        }

        /// <summary>
        /// 删除ECM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteECMInstancesRequest"/></param>
        /// <returns><see cref="DeleteECMInstancesResponse"/></returns>
        public DeleteECMInstancesResponse DeleteECMInstancesSync(DeleteECMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteECMInstancesResponse>(req, "DeleteECMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除弹性集群(yunapiv3)
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSClusterRequest"/></param>
        /// <returns><see cref="DeleteEKSClusterResponse"/></returns>
        public Task<DeleteEKSClusterResponse> DeleteEKSCluster(DeleteEKSClusterRequest req)
        {
            return InternalRequestAsync<DeleteEKSClusterResponse>(req, "DeleteEKSCluster");
        }

        /// <summary>
        /// 删除弹性集群(yunapiv3)
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSClusterRequest"/></param>
        /// <returns><see cref="DeleteEKSClusterResponse"/></returns>
        public DeleteEKSClusterResponse DeleteEKSClusterSync(DeleteEKSClusterRequest req)
        {
            return InternalRequestAsync<DeleteEKSClusterResponse>(req, "DeleteEKSCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除容器实例，可批量删除
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DeleteEKSContainerInstancesResponse"/></returns>
        public Task<DeleteEKSContainerInstancesResponse> DeleteEKSContainerInstances(DeleteEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEKSContainerInstancesResponse>(req, "DeleteEKSContainerInstances");
        }

        /// <summary>
        /// 删除容器实例，可批量删除
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DeleteEKSContainerInstancesResponse"/></returns>
        public DeleteEKSContainerInstancesResponse DeleteEKSContainerInstancesSync(DeleteEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEKSContainerInstancesResponse>(req, "DeleteEKSContainerInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘容器CVM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeCVMInstancesResponse"/></returns>
        public Task<DeleteEdgeCVMInstancesResponse> DeleteEdgeCVMInstances(DeleteEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeCVMInstancesResponse>(req, "DeleteEdgeCVMInstances");
        }

        /// <summary>
        /// 删除边缘容器CVM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeCVMInstancesResponse"/></returns>
        public DeleteEdgeCVMInstancesResponse DeleteEdgeCVMInstancesSync(DeleteEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeCVMInstancesResponse>(req, "DeleteEdgeCVMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘计算实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeClusterInstancesResponse"/></returns>
        public Task<DeleteEdgeClusterInstancesResponse> DeleteEdgeClusterInstances(DeleteEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeClusterInstancesResponse>(req, "DeleteEdgeClusterInstances");
        }

        /// <summary>
        /// 删除边缘计算实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeClusterInstancesResponse"/></returns>
        public DeleteEdgeClusterInstancesResponse DeleteEdgeClusterInstancesSync(DeleteEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeClusterInstancesResponse>(req, "DeleteEdgeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除镜像缓存
        /// </summary>
        /// <param name="req"><see cref="DeleteImageCachesRequest"/></param>
        /// <returns><see cref="DeleteImageCachesResponse"/></returns>
        public Task<DeleteImageCachesResponse> DeleteImageCaches(DeleteImageCachesRequest req)
        {
            return InternalRequestAsync<DeleteImageCachesResponse>(req, "DeleteImageCaches");
        }

        /// <summary>
        /// 批量删除镜像缓存
        /// </summary>
        /// <param name="req"><see cref="DeleteImageCachesRequest"/></param>
        /// <returns><see cref="DeleteImageCachesResponse"/></returns>
        public DeleteImageCachesResponse DeleteImageCachesSync(DeleteImageCachesRequest req)
        {
            return InternalRequestAsync<DeleteImageCachesResponse>(req, "DeleteImageCaches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public Task<DeletePrometheusAlertPolicyResponse> DeletePrometheusAlertPolicy(DeletePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertPolicyResponse>(req, "DeletePrometheusAlertPolicy");
        }

        /// <summary>
        /// 删除2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public DeletePrometheusAlertPolicyResponse DeletePrometheusAlertPolicySync(DeletePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertPolicyResponse>(req, "DeletePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除告警规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertRuleResponse"/></returns>
        public Task<DeletePrometheusAlertRuleResponse> DeletePrometheusAlertRule(DeletePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertRuleResponse>(req, "DeletePrometheusAlertRule");
        }

        /// <summary>
        /// 删除告警规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertRuleResponse"/></returns>
        public DeletePrometheusAlertRuleResponse DeletePrometheusAlertRuleSync(DeletePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertRuleResponse>(req, "DeletePrometheusAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除TMP实例的集群关联
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public Task<DeletePrometheusClusterAgentResponse> DeletePrometheusClusterAgent(DeletePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<DeletePrometheusClusterAgentResponse>(req, "DeletePrometheusClusterAgent");
        }

        /// <summary>
        /// 解除TMP实例的集群关联
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public DeletePrometheusClusterAgentResponse DeletePrometheusClusterAgentSync(DeletePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<DeletePrometheusClusterAgentResponse>(req, "DeletePrometheusClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Prometheus配置，如果目标不存在，将返回成功
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public Task<DeletePrometheusConfigResponse> DeletePrometheusConfig(DeletePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DeletePrometheusConfigResponse>(req, "DeletePrometheusConfig");
        }

        /// <summary>
        /// 删除Prometheus配置，如果目标不存在，将返回成功
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public DeletePrometheusConfigResponse DeletePrometheusConfigSync(DeletePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DeletePrometheusConfigResponse>(req, "DeletePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除聚合实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public Task<DeletePrometheusRecordRuleYamlResponse> DeletePrometheusRecordRuleYaml(DeletePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DeletePrometheusRecordRuleYamlResponse>(req, "DeletePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// 删除聚合实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public DeletePrometheusRecordRuleYamlResponse DeletePrometheusRecordRuleYamlSync(DeletePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DeletePrometheusRecordRuleYamlResponse>(req, "DeletePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public Task<DeletePrometheusTempResponse> DeletePrometheusTemp(DeletePrometheusTempRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempResponse>(req, "DeletePrometheusTemp");
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public DeletePrometheusTempResponse DeletePrometheusTempSync(DeletePrometheusTempRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempResponse>(req, "DeletePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除模板同步，这将会删除目标中该模板所生产的配置，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public Task<DeletePrometheusTempSyncResponse> DeletePrometheusTempSync(DeletePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempSyncResponse>(req, "DeletePrometheusTempSync");
        }

        /// <summary>
        /// 解除模板同步，这将会删除目标中该模板所生产的配置，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public DeletePrometheusTempSyncResponse DeletePrometheusTempSyncSync(DeletePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempSyncResponse>(req, "DeletePrometheusTempSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateResponse"/></returns>
        public Task<DeletePrometheusTemplateResponse> DeletePrometheusTemplate(DeletePrometheusTemplateRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTemplateResponse>(req, "DeletePrometheusTemplate");
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateResponse"/></returns>
        public DeletePrometheusTemplateResponse DeletePrometheusTemplateSync(DeletePrometheusTemplateRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTemplateResponse>(req, "DeletePrometheusTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消模板同步，这将会删除目标中该模板所生产的配置
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateSyncResponse"/></returns>
        public Task<DeletePrometheusTemplateSyncResponse> DeletePrometheusTemplateSync(DeletePrometheusTemplateSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTemplateSyncResponse>(req, "DeletePrometheusTemplateSync");
        }

        /// <summary>
        /// 取消模板同步，这将会删除目标中该模板所生产的配置
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateSyncResponse"/></returns>
        public DeletePrometheusTemplateSyncResponse DeletePrometheusTemplateSyncSync(DeletePrometheusTemplateSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTemplateSyncResponse>(req, "DeletePrometheusTemplateSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 预留券实例如符合退还规则，可通过本接口主动退还。
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedInstancesRequest"/></param>
        /// <returns><see cref="DeleteReservedInstancesResponse"/></returns>
        public Task<DeleteReservedInstancesResponse> DeleteReservedInstances(DeleteReservedInstancesRequest req)
        {
            return InternalRequestAsync<DeleteReservedInstancesResponse>(req, "DeleteReservedInstances");
        }

        /// <summary>
        /// 预留券实例如符合退还规则，可通过本接口主动退还。
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedInstancesRequest"/></param>
        /// <returns><see cref="DeleteReservedInstancesResponse"/></returns>
        public DeleteReservedInstancesResponse DeleteReservedInstancesSync(DeleteReservedInstancesRequest req)
        {
            return InternalRequestAsync<DeleteReservedInstancesResponse>(req, "DeleteReservedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="DeleteTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="DeleteTKEEdgeClusterResponse"/></returns>
        public Task<DeleteTKEEdgeClusterResponse> DeleteTKEEdgeCluster(DeleteTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<DeleteTKEEdgeClusterResponse>(req, "DeleteTKEEdgeCluster");
        }

        /// <summary>
        /// 删除边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="DeleteTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="DeleteTKEEdgeClusterResponse"/></returns>
        public DeleteTKEEdgeClusterResponse DeleteTKEEdgeClusterSync(DeleteTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<DeleteTKEEdgeClusterResponse>(req, "DeleteTKEEdgeCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取addon列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonRequest"/></param>
        /// <returns><see cref="DescribeAddonResponse"/></returns>
        public Task<DescribeAddonResponse> DescribeAddon(DescribeAddonRequest req)
        {
            return InternalRequestAsync<DescribeAddonResponse>(req, "DescribeAddon");
        }

        /// <summary>
        /// 获取addon列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonRequest"/></param>
        /// <returns><see cref="DescribeAddonResponse"/></returns>
        public DescribeAddonResponse DescribeAddonSync(DescribeAddonRequest req)
        {
            return InternalRequestAsync<DescribeAddonResponse>(req, "DescribeAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取一个addon的参数
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonValuesRequest"/></param>
        /// <returns><see cref="DescribeAddonValuesResponse"/></returns>
        public Task<DescribeAddonValuesResponse> DescribeAddonValues(DescribeAddonValuesRequest req)
        {
            return InternalRequestAsync<DescribeAddonValuesResponse>(req, "DescribeAddonValues");
        }

        /// <summary>
        /// 获取一个addon的参数
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonValuesRequest"/></param>
        /// <returns><see cref="DescribeAddonValuesResponse"/></returns>
        public DescribeAddonValuesResponse DescribeAddonValuesSync(DescribeAddonValuesRequest req)
        {
            return InternalRequestAsync<DescribeAddonValuesResponse>(req, "DescribeAddonValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群可以升级的所有版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public Task<DescribeAvailableClusterVersionResponse> DescribeAvailableClusterVersion(DescribeAvailableClusterVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableClusterVersionResponse>(req, "DescribeAvailableClusterVersion");
        }

        /// <summary>
        /// 获取集群可以升级的所有版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public DescribeAvailableClusterVersionResponse DescribeAvailableClusterVersionSync(DescribeAvailableClusterVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableClusterVersionResponse>(req, "DescribeAvailableClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 边缘计算支持版本和k8s版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableTKEEdgeVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableTKEEdgeVersionResponse"/></returns>
        public Task<DescribeAvailableTKEEdgeVersionResponse> DescribeAvailableTKEEdgeVersion(DescribeAvailableTKEEdgeVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableTKEEdgeVersionResponse>(req, "DescribeAvailableTKEEdgeVersion");
        }

        /// <summary>
        /// 边缘计算支持版本和k8s版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableTKEEdgeVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableTKEEdgeVersionResponse"/></returns>
        public DescribeAvailableTKEEdgeVersionResponse DescribeAvailableTKEEdgeVersionSync(DescribeAvailableTKEEdgeVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableTKEEdgeVersionResponse>(req, "DescribeAvailableTKEEdgeVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStorageLocationsRequest"/></param>
        /// <returns><see cref="DescribeBackupStorageLocationsResponse"/></returns>
        public Task<DescribeBackupStorageLocationsResponse> DescribeBackupStorageLocations(DescribeBackupStorageLocationsRequest req)
        {
            return InternalRequestAsync<DescribeBackupStorageLocationsResponse>(req, "DescribeBackupStorageLocations");
        }

        /// <summary>
        /// 查询备份仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStorageLocationsRequest"/></param>
        /// <returns><see cref="DescribeBackupStorageLocationsResponse"/></returns>
        public DescribeBackupStorageLocationsResponse DescribeBackupStorageLocationsSync(DescribeBackupStorageLocationsRequest req)
        {
            return InternalRequestAsync<DescribeBackupStorageLocationsResponse>(req, "DescribeBackupStorageLocations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群弹性伸缩配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public Task<DescribeClusterAsGroupOptionResponse> DescribeClusterAsGroupOption(DescribeClusterAsGroupOptionRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupOptionResponse>(req, "DescribeClusterAsGroupOption");
        }

        /// <summary>
        /// 集群弹性伸缩配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public DescribeClusterAsGroupOptionResponse DescribeClusterAsGroupOptionSync(DescribeClusterAsGroupOptionRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupOptionResponse>(req, "DescribeClusterAsGroupOption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群关联的伸缩组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public Task<DescribeClusterAsGroupsResponse> DescribeClusterAsGroups(DescribeClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupsResponse>(req, "DescribeClusterAsGroups");
        }

        /// <summary>
        /// 集群关联的伸缩组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public DescribeClusterAsGroupsResponse DescribeClusterAsGroupsSync(DescribeClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupsResponse>(req, "DescribeClusterAsGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看集群认证配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="DescribeClusterAuthenticationOptionsResponse"/></returns>
        public Task<DescribeClusterAuthenticationOptionsResponse> DescribeClusterAuthenticationOptions(DescribeClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAuthenticationOptionsResponse>(req, "DescribeClusterAuthenticationOptions");
        }

        /// <summary>
        /// 查看集群认证配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="DescribeClusterAuthenticationOptionsResponse"/></returns>
        public DescribeClusterAuthenticationOptionsResponse DescribeClusterAuthenticationOptionsSync(DescribeClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAuthenticationOptionsResponse>(req, "DescribeClusterAuthenticationOptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定子账户在RBAC授权模式中对应kube-apiserver客户端证书的CommonName字段，如果没有客户端证书，将会签发一个，此接口有最大传入子账户数量上限，当前为50
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public Task<DescribeClusterCommonNamesResponse> DescribeClusterCommonNames(DescribeClusterCommonNamesRequest req)
        {
            return InternalRequestAsync<DescribeClusterCommonNamesResponse>(req, "DescribeClusterCommonNames");
        }

        /// <summary>
        /// 获取指定子账户在RBAC授权模式中对应kube-apiserver客户端证书的CommonName字段，如果没有客户端证书，将会签发一个，此接口有最大传入子账户数量上限，当前为50
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public DescribeClusterCommonNamesResponse DescribeClusterCommonNamesSync(DescribeClusterCommonNamesRequest req)
        {
            return InternalRequestAsync<DescribeClusterCommonNamesResponse>(req, "DescribeClusterCommonNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询Kubernetes的各个原生控制器是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterControllersRequest"/></param>
        /// <returns><see cref="DescribeClusterControllersResponse"/></returns>
        public Task<DescribeClusterControllersResponse> DescribeClusterControllers(DescribeClusterControllersRequest req)
        {
            return InternalRequestAsync<DescribeClusterControllersResponse>(req, "DescribeClusterControllers");
        }

        /// <summary>
        /// 用于查询Kubernetes的各个原生控制器是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterControllersRequest"/></param>
        /// <returns><see cref="DescribeClusterControllersResponse"/></returns>
        public DescribeClusterControllersResponse DescribeClusterControllersSync(DescribeClusterControllersRequest req)
        {
            return InternalRequestAsync<DescribeClusterControllersResponse>(req, "DescribeClusterControllers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群访问端口状态(独立集群开启内网/外网访问，托管集群支持开启内网访问)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public Task<DescribeClusterEndpointStatusResponse> DescribeClusterEndpointStatus(DescribeClusterEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointStatusResponse>(req, "DescribeClusterEndpointStatus");
        }

        /// <summary>
        /// 查询集群访问端口状态(独立集群开启内网/外网访问，托管集群支持开启内网访问)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public DescribeClusterEndpointStatusResponse DescribeClusterEndpointStatusSync(DescribeClusterEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointStatusResponse>(req, "DescribeClusterEndpointStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群开启端口流程状态(仅支持托管集群外网端口)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public Task<DescribeClusterEndpointVipStatusResponse> DescribeClusterEndpointVipStatus(DescribeClusterEndpointVipStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointVipStatusResponse>(req, "DescribeClusterEndpointVipStatus");
        }

        /// <summary>
        /// 查询集群开启端口流程状态(仅支持托管集群外网端口)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public DescribeClusterEndpointVipStatusResponse DescribeClusterEndpointVipStatusSync(DescribeClusterEndpointVipStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointVipStatusResponse>(req, "DescribeClusterEndpointVipStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群的访问地址，包括内网地址，外网地址，外网域名，外网访问安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public Task<DescribeClusterEndpointsResponse> DescribeClusterEndpoints(DescribeClusterEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointsResponse>(req, "DescribeClusterEndpoints");
        }

        /// <summary>
        /// 获取集群的访问地址，包括内网地址，外网地址，外网域名，外网访问安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public DescribeClusterEndpointsResponse DescribeClusterEndpointsSync(DescribeClusterEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointsResponse>(req, "DescribeClusterEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeClusterExtraArgsResponse"/></returns>
        public Task<DescribeClusterExtraArgsResponse> DescribeClusterExtraArgs(DescribeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeClusterExtraArgsResponse>(req, "DescribeClusterExtraArgs");
        }

        /// <summary>
        /// 查询集群自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeClusterExtraArgsResponse"/></returns>
        public DescribeClusterExtraArgsResponse DescribeClusterExtraArgsSync(DescribeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeClusterExtraArgsResponse>(req, "DescribeClusterExtraArgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户单个Region下的所有集群巡检结果概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInspectionResultsOverviewRequest"/></param>
        /// <returns><see cref="DescribeClusterInspectionResultsOverviewResponse"/></returns>
        public Task<DescribeClusterInspectionResultsOverviewResponse> DescribeClusterInspectionResultsOverview(DescribeClusterInspectionResultsOverviewRequest req)
        {
            return InternalRequestAsync<DescribeClusterInspectionResultsOverviewResponse>(req, "DescribeClusterInspectionResultsOverview");
        }

        /// <summary>
        /// 查询用户单个Region下的所有集群巡检结果概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInspectionResultsOverviewRequest"/></param>
        /// <returns><see cref="DescribeClusterInspectionResultsOverviewResponse"/></returns>
        public DescribeClusterInspectionResultsOverviewResponse DescribeClusterInspectionResultsOverviewSync(DescribeClusterInspectionResultsOverviewRequest req)
        {
            return InternalRequestAsync<DescribeClusterInspectionResultsOverviewResponse>(req, "DescribeClusterInspectionResultsOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances");
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群的kubeconfig文件，不同子账户获取自己的kubeconfig文件，该文件中有每个子账户自己的kube-apiserver的客户端证书，默认首次调此接口时候创建客户端证书，时效20年，未授予任何权限，如果是集群所有者或者主账户，则默认是cluster-admin权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public Task<DescribeClusterKubeconfigResponse> DescribeClusterKubeconfig(DescribeClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeClusterKubeconfigResponse>(req, "DescribeClusterKubeconfig");
        }

        /// <summary>
        /// 获取集群的kubeconfig文件，不同子账户获取自己的kubeconfig文件，该文件中有每个子账户自己的kube-apiserver的客户端证书，默认首次调此接口时候创建客户端证书，时效20年，未授予任何权限，如果是集群所有者或者主账户，则默认是cluster-admin权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public DescribeClusterKubeconfigResponse DescribeClusterKubeconfigSync(DescribeClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeClusterKubeconfigResponse>(req, "DescribeClusterKubeconfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群规模
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelAttributeRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelAttributeResponse"/></returns>
        public Task<DescribeClusterLevelAttributeResponse> DescribeClusterLevelAttribute(DescribeClusterLevelAttributeRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelAttributeResponse>(req, "DescribeClusterLevelAttribute");
        }

        /// <summary>
        /// 获取集群规模
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelAttributeRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelAttributeResponse"/></returns>
        public DescribeClusterLevelAttributeResponse DescribeClusterLevelAttributeSync(DescribeClusterLevelAttributeRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelAttributeResponse>(req, "DescribeClusterLevelAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群变配记录
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelChangeRecordsRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelChangeRecordsResponse"/></returns>
        public Task<DescribeClusterLevelChangeRecordsResponse> DescribeClusterLevelChangeRecords(DescribeClusterLevelChangeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelChangeRecordsResponse>(req, "DescribeClusterLevelChangeRecords");
        }

        /// <summary>
        /// 查询集群变配记录
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelChangeRecordsRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelChangeRecordsResponse"/></returns>
        public DescribeClusterLevelChangeRecordsResponse DescribeClusterLevelChangeRecordsSync(DescribeClusterLevelChangeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelChangeRecordsResponse>(req, "DescribeClusterLevelChangeRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询节点池详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetail(DescribeClusterNodePoolDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolDetailResponse>(req, "DescribeClusterNodePoolDetail");
        }

        /// <summary>
        /// 查询节点池详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetailSync(DescribeClusterNodePoolDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolDetailResponse>(req, "DescribeClusterNodePoolDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePools(DescribeClusterNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolsResponse>(req, "DescribeClusterNodePools");
        }

        /// <summary>
        /// 查询节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public DescribeClusterNodePoolsResponse DescribeClusterNodePoolsSync(DescribeClusterNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolsResponse>(req, "DescribeClusterNodePools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在应用市场中查询正在安装中的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPendingReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterPendingReleasesResponse"/></returns>
        public Task<DescribeClusterPendingReleasesResponse> DescribeClusterPendingReleases(DescribeClusterPendingReleasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterPendingReleasesResponse>(req, "DescribeClusterPendingReleases");
        }

        /// <summary>
        /// 在应用市场中查询正在安装中的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPendingReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterPendingReleasesResponse"/></returns>
        public DescribeClusterPendingReleasesResponse DescribeClusterPendingReleasesSync(DescribeClusterPendingReleasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterPendingReleasesResponse>(req, "DescribeClusterPendingReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询通过应用市场安装的某个应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseDetailsRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseDetailsResponse"/></returns>
        public Task<DescribeClusterReleaseDetailsResponse> DescribeClusterReleaseDetails(DescribeClusterReleaseDetailsRequest req)
        {
            return InternalRequestAsync<DescribeClusterReleaseDetailsResponse>(req, "DescribeClusterReleaseDetails");
        }

        /// <summary>
        /// 查询通过应用市场安装的某个应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseDetailsRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseDetailsResponse"/></returns>
        public DescribeClusterReleaseDetailsResponse DescribeClusterReleaseDetailsSync(DescribeClusterReleaseDetailsRequest req)
        {
            return InternalRequestAsync<DescribeClusterReleaseDetailsResponse>(req, "DescribeClusterReleaseDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群在应用市场中某个已安装应用的版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseHistoryResponse"/></returns>
        public Task<DescribeClusterReleaseHistoryResponse> DescribeClusterReleaseHistory(DescribeClusterReleaseHistoryRequest req)
        {
            return InternalRequestAsync<DescribeClusterReleaseHistoryResponse>(req, "DescribeClusterReleaseHistory");
        }

        /// <summary>
        /// 查询集群在应用市场中某个已安装应用的版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseHistoryResponse"/></returns>
        public DescribeClusterReleaseHistoryResponse DescribeClusterReleaseHistorySync(DescribeClusterReleaseHistoryRequest req)
        {
            return InternalRequestAsync<DescribeClusterReleaseHistoryResponse>(req, "DescribeClusterReleaseHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群在应用市场中已安装应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterReleasesResponse"/></returns>
        public Task<DescribeClusterReleasesResponse> DescribeClusterReleases(DescribeClusterReleasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterReleasesResponse>(req, "DescribeClusterReleases");
        }

        /// <summary>
        /// 查询集群在应用市场中已安装应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterReleasesResponse"/></returns>
        public DescribeClusterReleasesResponse DescribeClusterReleasesSync(DescribeClusterReleasesRequest req)
        {
            return InternalRequestAsync<DescribeClusterReleasesResponse>(req, "DescribeClusterReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群路由表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public Task<DescribeClusterRouteTablesResponse> DescribeClusterRouteTables(DescribeClusterRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRouteTablesResponse>(req, "DescribeClusterRouteTables");
        }

        /// <summary>
        /// 查询集群路由表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public DescribeClusterRouteTablesResponse DescribeClusterRouteTablesSync(DescribeClusterRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRouteTablesResponse>(req, "DescribeClusterRouteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群路由
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public Task<DescribeClusterRoutesResponse> DescribeClusterRoutes(DescribeClusterRoutesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRoutesResponse>(req, "DescribeClusterRoutes");
        }

        /// <summary>
        /// 查询集群路由
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public DescribeClusterRoutesResponse DescribeClusterRoutesSync(DescribeClusterRoutesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRoutesResponse>(req, "DescribeClusterRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群的密钥信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public Task<DescribeClusterSecurityResponse> DescribeClusterSecurity(DescribeClusterSecurityRequest req)
        {
            return InternalRequestAsync<DescribeClusterSecurityResponse>(req, "DescribeClusterSecurity");
        }

        /// <summary>
        /// 集群的密钥信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public DescribeClusterSecurityResponse DescribeClusterSecuritySync(DescribeClusterSecurityRequest req)
        {
            return InternalRequestAsync<DescribeClusterSecurityResponse>(req, "DescribeClusterSecurity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看集群状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterStatusResponse"/></returns>
        public Task<DescribeClusterStatusResponse> DescribeClusterStatus(DescribeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterStatusResponse>(req, "DescribeClusterStatus");
        }

        /// <summary>
        /// 查看集群状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterStatusResponse"/></returns>
        public DescribeClusterStatusResponse DescribeClusterStatusSync(DescribeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterStatusResponse>(req, "DescribeClusterStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看超级节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodeResponse"/></returns>
        public Task<DescribeClusterVirtualNodeResponse> DescribeClusterVirtualNode(DescribeClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodeResponse>(req, "DescribeClusterVirtualNode");
        }

        /// <summary>
        /// 查看超级节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodeResponse"/></returns>
        public DescribeClusterVirtualNodeResponse DescribeClusterVirtualNodeSync(DescribeClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodeResponse>(req, "DescribeClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看超级节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodePoolsResponse"/></returns>
        public Task<DescribeClusterVirtualNodePoolsResponse> DescribeClusterVirtualNodePools(DescribeClusterVirtualNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodePoolsResponse>(req, "DescribeClusterVirtualNodePools");
        }

        /// <summary>
        /// 查看超级节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodePoolsResponse"/></returns>
        public DescribeClusterVirtualNodePoolsResponse DescribeClusterVirtualNodePoolsSync(DescribeClusterVirtualNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodePoolsResponse>(req, "DescribeClusterVirtualNodePools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取ECM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeECMInstancesRequest"/></param>
        /// <returns><see cref="DescribeECMInstancesResponse"/></returns>
        public Task<DescribeECMInstancesResponse> DescribeECMInstances(DescribeECMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeECMInstancesResponse>(req, "DescribeECMInstances");
        }

        /// <summary>
        /// 获取ECM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeECMInstancesRequest"/></param>
        /// <returns><see cref="DescribeECMInstancesResponse"/></returns>
        public DescribeECMInstancesResponse DescribeECMInstancesSync(DescribeECMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeECMInstancesResponse>(req, "DescribeECMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取弹性容器集群的接入认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeEKSClusterCredentialResponse"/></returns>
        public Task<DescribeEKSClusterCredentialResponse> DescribeEKSClusterCredential(DescribeEKSClusterCredentialRequest req)
        {
            return InternalRequestAsync<DescribeEKSClusterCredentialResponse>(req, "DescribeEKSClusterCredential");
        }

        /// <summary>
        /// 获取弹性容器集群的接入认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeEKSClusterCredentialResponse"/></returns>
        public DescribeEKSClusterCredentialResponse DescribeEKSClusterCredentialSync(DescribeEKSClusterCredentialRequest req)
        {
            return InternalRequestAsync<DescribeEKSClusterCredentialResponse>(req, "DescribeEKSClusterCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询弹性集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClustersRequest"/></param>
        /// <returns><see cref="DescribeEKSClustersResponse"/></returns>
        public Task<DescribeEKSClustersResponse> DescribeEKSClusters(DescribeEKSClustersRequest req)
        {
            return InternalRequestAsync<DescribeEKSClustersResponse>(req, "DescribeEKSClusters");
        }

        /// <summary>
        /// 查询弹性集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClustersRequest"/></param>
        /// <returns><see cref="DescribeEKSClustersResponse"/></returns>
        public DescribeEKSClustersResponse DescribeEKSClustersSync(DescribeEKSClustersRequest req)
        {
            return InternalRequestAsync<DescribeEKSClustersResponse>(req, "DescribeEKSClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器实例的事件
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceEventRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceEventResponse"/></returns>
        public Task<DescribeEKSContainerInstanceEventResponse> DescribeEKSContainerInstanceEvent(DescribeEKSContainerInstanceEventRequest req)
        {
            return InternalRequestAsync<DescribeEKSContainerInstanceEventResponse>(req, "DescribeEKSContainerInstanceEvent");
        }

        /// <summary>
        /// 查询容器实例的事件
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceEventRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceEventResponse"/></returns>
        public DescribeEKSContainerInstanceEventResponse DescribeEKSContainerInstanceEventSync(DescribeEKSContainerInstanceEventRequest req)
        {
            return InternalRequestAsync<DescribeEKSContainerInstanceEventResponse>(req, "DescribeEKSContainerInstanceEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器实例支持的地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceRegionsRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceRegionsResponse"/></returns>
        public Task<DescribeEKSContainerInstanceRegionsResponse> DescribeEKSContainerInstanceRegions(DescribeEKSContainerInstanceRegionsRequest req)
        {
            return InternalRequestAsync<DescribeEKSContainerInstanceRegionsResponse>(req, "DescribeEKSContainerInstanceRegions");
        }

        /// <summary>
        /// 查询容器实例支持的地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceRegionsRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceRegionsResponse"/></returns>
        public DescribeEKSContainerInstanceRegionsResponse DescribeEKSContainerInstanceRegionsSync(DescribeEKSContainerInstanceRegionsRequest req)
        {
            return InternalRequestAsync<DescribeEKSContainerInstanceRegionsResponse>(req, "DescribeEKSContainerInstanceRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器实例
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstancesResponse"/></returns>
        public Task<DescribeEKSContainerInstancesResponse> DescribeEKSContainerInstances(DescribeEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEKSContainerInstancesResponse>(req, "DescribeEKSContainerInstances");
        }

        /// <summary>
        /// 查询容器实例
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstancesResponse"/></returns>
        public DescribeEKSContainerInstancesResponse DescribeEKSContainerInstancesSync(DescribeEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEKSContainerInstancesResponse>(req, "DescribeEKSContainerInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘容器集群可用的自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAvailableExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeAvailableExtraArgsResponse"/></returns>
        public Task<DescribeEdgeAvailableExtraArgsResponse> DescribeEdgeAvailableExtraArgs(DescribeEdgeAvailableExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAvailableExtraArgsResponse>(req, "DescribeEdgeAvailableExtraArgs");
        }

        /// <summary>
        /// 查询边缘容器集群可用的自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAvailableExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeAvailableExtraArgsResponse"/></returns>
        public DescribeEdgeAvailableExtraArgsResponse DescribeEdgeAvailableExtraArgsSync(DescribeEdgeAvailableExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAvailableExtraArgsResponse>(req, "DescribeEdgeAvailableExtraArgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边缘容器CVM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeCVMInstancesResponse"/></returns>
        public Task<DescribeEdgeCVMInstancesResponse> DescribeEdgeCVMInstances(DescribeEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeCVMInstancesResponse>(req, "DescribeEdgeCVMInstances");
        }

        /// <summary>
        /// 获取边缘容器CVM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeCVMInstancesResponse"/></returns>
        public DescribeEdgeCVMInstancesResponse DescribeEdgeCVMInstancesSync(DescribeEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeCVMInstancesResponse>(req, "DescribeEdgeCVMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘集群自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterExtraArgsResponse"/></returns>
        public Task<DescribeEdgeClusterExtraArgsResponse> DescribeEdgeClusterExtraArgs(DescribeEdgeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterExtraArgsResponse>(req, "DescribeEdgeClusterExtraArgs");
        }

        /// <summary>
        /// 查询边缘集群自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterExtraArgsResponse"/></returns>
        public DescribeEdgeClusterExtraArgsResponse DescribeEdgeClusterExtraArgsSync(DescribeEdgeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterExtraArgsResponse>(req, "DescribeEdgeClusterExtraArgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘计算集群的节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterInstancesResponse"/></returns>
        public Task<DescribeEdgeClusterInstancesResponse> DescribeEdgeClusterInstances(DescribeEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterInstancesResponse>(req, "DescribeEdgeClusterInstances");
        }

        /// <summary>
        /// 查询边缘计算集群的节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterInstancesResponse"/></returns>
        public DescribeEdgeClusterInstancesResponse DescribeEdgeClusterInstancesSync(DescribeEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterInstancesResponse>(req, "DescribeEdgeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可以查询边缘集群升级信息，包含可以升级的组件，当前升级状态和升级错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterUpgradeInfoRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterUpgradeInfoResponse"/></returns>
        public Task<DescribeEdgeClusterUpgradeInfoResponse> DescribeEdgeClusterUpgradeInfo(DescribeEdgeClusterUpgradeInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterUpgradeInfoResponse>(req, "DescribeEdgeClusterUpgradeInfo");
        }

        /// <summary>
        /// 可以查询边缘集群升级信息，包含可以升级的组件，当前升级状态和升级错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterUpgradeInfoRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterUpgradeInfoResponse"/></returns>
        public DescribeEdgeClusterUpgradeInfoResponse DescribeEdgeClusterUpgradeInfoSync(DescribeEdgeClusterUpgradeInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterUpgradeInfoResponse>(req, "DescribeEdgeClusterUpgradeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取事件、审计和日志的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeEdgeLogSwitchesResponse"/></returns>
        public Task<DescribeEdgeLogSwitchesResponse> DescribeEdgeLogSwitches(DescribeEdgeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeLogSwitchesResponse>(req, "DescribeEdgeLogSwitches");
        }

        /// <summary>
        /// 获取事件、审计和日志的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeEdgeLogSwitchesResponse"/></returns>
        public DescribeEdgeLogSwitchesResponse DescribeEdgeLogSwitchesSync(DescribeEdgeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeLogSwitchesResponse>(req, "DescribeEdgeLogSwitches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器实例中容器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEksContainerInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeEksContainerInstanceLogResponse"/></returns>
        public Task<DescribeEksContainerInstanceLogResponse> DescribeEksContainerInstanceLog(DescribeEksContainerInstanceLogRequest req)
        {
            return InternalRequestAsync<DescribeEksContainerInstanceLogResponse>(req, "DescribeEksContainerInstanceLog");
        }

        /// <summary>
        /// 查询容器实例中容器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEksContainerInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeEksContainerInstanceLogResponse"/></returns>
        public DescribeEksContainerInstanceLogResponse DescribeEksContainerInstanceLogSync(DescribeEksContainerInstanceLogRequest req)
        {
            return InternalRequestAsync<DescribeEksContainerInstanceLogResponse>(req, "DescribeEksContainerInstanceLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询开启vpc-cni模式的任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public Task<DescribeEnableVpcCniProgressResponse> DescribeEnableVpcCniProgress(DescribeEnableVpcCniProgressRequest req)
        {
            return InternalRequestAsync<DescribeEnableVpcCniProgressResponse>(req, "DescribeEnableVpcCniProgress");
        }

        /// <summary>
        /// 本接口用于查询开启vpc-cni模式的任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public DescribeEnableVpcCniProgressResponse DescribeEnableVpcCniProgressSync(DescribeEnableVpcCniProgressRequest req)
        {
            return InternalRequestAsync<DescribeEnableVpcCniProgressResponse>(req, "DescribeEnableVpcCniProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询etcd数据是否进行加密
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeEncryptionStatusResponse"/></returns>
        public Task<DescribeEncryptionStatusResponse> DescribeEncryptionStatus(DescribeEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionStatusResponse>(req, "DescribeEncryptionStatus");
        }

        /// <summary>
        /// 查询etcd数据是否进行加密
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeEncryptionStatusResponse"/></returns>
        public DescribeEncryptionStatusResponse DescribeEncryptionStatusSync(DescribeEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionStatusResponse>(req, "DescribeEncryptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询已经存在的节点，判断是否可以加入集群
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public Task<DescribeExistedInstancesResponse> DescribeExistedInstances(DescribeExistedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeExistedInstancesResponse>(req, "DescribeExistedInstances");
        }

        /// <summary>
        /// 查询已经存在的节点，判断是否可以加入集群
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public DescribeExistedInstancesResponse DescribeExistedInstancesSync(DescribeExistedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeExistedInstancesResponse>(req, "DescribeExistedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取导入第三方集群YAML定义
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalClusterSpecRequest"/></param>
        /// <returns><see cref="DescribeExternalClusterSpecResponse"/></returns>
        public Task<DescribeExternalClusterSpecResponse> DescribeExternalClusterSpec(DescribeExternalClusterSpecRequest req)
        {
            return InternalRequestAsync<DescribeExternalClusterSpecResponse>(req, "DescribeExternalClusterSpec");
        }

        /// <summary>
        /// 获取导入第三方集群YAML定义
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalClusterSpecRequest"/></param>
        /// <returns><see cref="DescribeExternalClusterSpecResponse"/></returns>
        public DescribeExternalClusterSpecResponse DescribeExternalClusterSpecSync(DescribeExternalClusterSpecRequest req)
        {
            return InternalRequestAsync<DescribeExternalClusterSpecResponse>(req, "DescribeExternalClusterSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看开启第三方节点池配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalNodeSupportConfigRequest"/></param>
        /// <returns><see cref="DescribeExternalNodeSupportConfigResponse"/></returns>
        public Task<DescribeExternalNodeSupportConfigResponse> DescribeExternalNodeSupportConfig(DescribeExternalNodeSupportConfigRequest req)
        {
            return InternalRequestAsync<DescribeExternalNodeSupportConfigResponse>(req, "DescribeExternalNodeSupportConfig");
        }

        /// <summary>
        /// 查看开启第三方节点池配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalNodeSupportConfigRequest"/></param>
        /// <returns><see cref="DescribeExternalNodeSupportConfigResponse"/></returns>
        public DescribeExternalNodeSupportConfigResponse DescribeExternalNodeSupportConfigSync(DescribeExternalNodeSupportConfigRequest req)
        {
            return InternalRequestAsync<DescribeExternalNodeSupportConfigResponse>(req, "DescribeExternalNodeSupportConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取eniipamd组件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIPAMDRequest"/></param>
        /// <returns><see cref="DescribeIPAMDResponse"/></returns>
        public Task<DescribeIPAMDResponse> DescribeIPAMD(DescribeIPAMDRequest req)
        {
            return InternalRequestAsync<DescribeIPAMDResponse>(req, "DescribeIPAMD");
        }

        /// <summary>
        /// 获取eniipamd组件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIPAMDRequest"/></param>
        /// <returns><see cref="DescribeIPAMDResponse"/></returns>
        public DescribeIPAMDResponse DescribeIPAMDSync(DescribeIPAMDRequest req)
        {
            return InternalRequestAsync<DescribeIPAMDResponse>(req, "DescribeIPAMD")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像缓存信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageCachesRequest"/></param>
        /// <returns><see cref="DescribeImageCachesResponse"/></returns>
        public Task<DescribeImageCachesResponse> DescribeImageCaches(DescribeImageCachesRequest req)
        {
            return InternalRequestAsync<DescribeImageCachesResponse>(req, "DescribeImageCaches");
        }

        /// <summary>
        /// 查询镜像缓存信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageCachesRequest"/></param>
        /// <returns><see cref="DescribeImageCachesResponse"/></returns>
        public DescribeImageCachesResponse DescribeImageCachesSync(DescribeImageCachesRequest req)
        {
            return InternalRequestAsync<DescribeImageCachesResponse>(req, "DescribeImageCaches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// 获取镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群日志（审计、事件、普通日志）开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeLogSwitchesResponse"/></returns>
        public Task<DescribeLogSwitchesResponse> DescribeLogSwitches(DescribeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeLogSwitchesResponse>(req, "DescribeLogSwitches");
        }

        /// <summary>
        /// 查询集群日志（审计、事件、普通日志）开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeLogSwitchesResponse"/></returns>
        public DescribeLogSwitchesResponse DescribeLogSwitchesSync(DescribeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeLogSwitchesResponse>(req, "DescribeLogSwitches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询各个规格的 Pod 的抵扣率
        /// </summary>
        /// <param name="req"><see cref="DescribePodDeductionRateRequest"/></param>
        /// <returns><see cref="DescribePodDeductionRateResponse"/></returns>
        public Task<DescribePodDeductionRateResponse> DescribePodDeductionRate(DescribePodDeductionRateRequest req)
        {
            return InternalRequestAsync<DescribePodDeductionRateResponse>(req, "DescribePodDeductionRate");
        }

        /// <summary>
        /// 查询各个规格的 Pod 的抵扣率
        /// </summary>
        /// <param name="req"><see cref="DescribePodDeductionRateRequest"/></param>
        /// <returns><see cref="DescribePodDeductionRateResponse"/></returns>
        public DescribePodDeductionRateResponse DescribePodDeductionRateSync(DescribePodDeductionRateRequest req)
        {
            return InternalRequestAsync<DescribePodDeductionRateResponse>(req, "DescribePodDeductionRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可以用预留券抵扣的 Pod 信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePodsBySpecRequest"/></param>
        /// <returns><see cref="DescribePodsBySpecResponse"/></returns>
        public Task<DescribePodsBySpecResponse> DescribePodsBySpec(DescribePodsBySpecRequest req)
        {
            return InternalRequestAsync<DescribePodsBySpecResponse>(req, "DescribePodsBySpec");
        }

        /// <summary>
        /// 查询可以用预留券抵扣的 Pod 信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePodsBySpecRequest"/></param>
        /// <returns><see cref="DescribePodsBySpecResponse"/></returns>
        public DescribePodsBySpecResponse DescribePodsBySpecSync(DescribePodsBySpecRequest req)
        {
            return InternalRequestAsync<DescribePodsBySpecResponse>(req, "DescribePodsBySpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 包括 Pod 资源统计和绑定的预留券资源统计。
        /// </summary>
        /// <param name="req"><see cref="DescribePostNodeResourcesRequest"/></param>
        /// <returns><see cref="DescribePostNodeResourcesResponse"/></returns>
        public Task<DescribePostNodeResourcesResponse> DescribePostNodeResources(DescribePostNodeResourcesRequest req)
        {
            return InternalRequestAsync<DescribePostNodeResourcesResponse>(req, "DescribePostNodeResources");
        }

        /// <summary>
        /// 包括 Pod 资源统计和绑定的预留券资源统计。
        /// </summary>
        /// <param name="req"><see cref="DescribePostNodeResourcesRequest"/></param>
        /// <returns><see cref="DescribePostNodeResourcesResponse"/></returns>
        public DescribePostNodeResourcesResponse DescribePostNodeResourcesSync(DescribePostNodeResourcesRequest req)
        {
            return InternalRequestAsync<DescribePostNodeResourcesResponse>(req, "DescribePostNodeResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取关联目标集群的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public Task<DescribePrometheusAgentInstancesResponse> DescribePrometheusAgentInstances(DescribePrometheusAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentInstancesResponse>(req, "DescribePrometheusAgentInstances");
        }

        /// <summary>
        /// 获取关联目标集群的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public DescribePrometheusAgentInstancesResponse DescribePrometheusAgentInstancesSync(DescribePrometheusAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentInstancesResponse>(req, "DescribePrometheusAgentInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取被关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public Task<DescribePrometheusAgentsResponse> DescribePrometheusAgents(DescribePrometheusAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentsResponse>(req, "DescribePrometheusAgents");
        }

        /// <summary>
        /// 获取被关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public DescribePrometheusAgentsResponse DescribePrometheusAgentsSync(DescribePrometheusAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentsResponse>(req, "DescribePrometheusAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警历史
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertHistoryRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertHistoryResponse"/></returns>
        public Task<DescribePrometheusAlertHistoryResponse> DescribePrometheusAlertHistory(DescribePrometheusAlertHistoryRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertHistoryResponse>(req, "DescribePrometheusAlertHistory");
        }

        /// <summary>
        /// 获取告警历史
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertHistoryRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertHistoryResponse"/></returns>
        public DescribePrometheusAlertHistoryResponse DescribePrometheusAlertHistorySync(DescribePrometheusAlertHistoryRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertHistoryResponse>(req, "DescribePrometheusAlertHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取2.0实例告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public Task<DescribePrometheusAlertPolicyResponse> DescribePrometheusAlertPolicy(DescribePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertPolicyResponse>(req, "DescribePrometheusAlertPolicy");
        }

        /// <summary>
        /// 获取2.0实例告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public DescribePrometheusAlertPolicyResponse DescribePrometheusAlertPolicySync(DescribePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertPolicyResponse>(req, "DescribePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertRuleResponse"/></returns>
        public Task<DescribePrometheusAlertRuleResponse> DescribePrometheusAlertRule(DescribePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertRuleResponse>(req, "DescribePrometheusAlertRule");
        }

        /// <summary>
        /// 获取告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertRuleResponse"/></returns>
        public DescribePrometheusAlertRuleResponse DescribePrometheusAlertRuleSync(DescribePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertRuleResponse>(req, "DescribePrometheusAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TMP实例关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public Task<DescribePrometheusClusterAgentsResponse> DescribePrometheusClusterAgents(DescribePrometheusClusterAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusClusterAgentsResponse>(req, "DescribePrometheusClusterAgents");
        }

        /// <summary>
        /// 获取TMP实例关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public DescribePrometheusClusterAgentsResponse DescribePrometheusClusterAgentsSync(DescribePrometheusClusterAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusClusterAgentsResponse>(req, "DescribePrometheusClusterAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取Prometheus配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public Task<DescribePrometheusConfigResponse> DescribePrometheusConfig(DescribePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusConfigResponse>(req, "DescribePrometheusConfig");
        }

        /// <summary>
        /// 拉取Prometheus配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public DescribePrometheusConfigResponse DescribePrometheusConfigSync(DescribePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusConfigResponse>(req, "DescribePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获得实例级别抓取配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public Task<DescribePrometheusGlobalConfigResponse> DescribePrometheusGlobalConfig(DescribePrometheusGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalConfigResponse>(req, "DescribePrometheusGlobalConfig");
        }

        /// <summary>
        /// 获得实例级别抓取配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public DescribePrometheusGlobalConfigResponse DescribePrometheusGlobalConfigSync(DescribePrometheusGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalConfigResponse>(req, "DescribePrometheusGlobalConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public Task<DescribePrometheusGlobalNotificationResponse> DescribePrometheusGlobalNotification(DescribePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalNotificationResponse>(req, "DescribePrometheusGlobalNotification");
        }

        /// <summary>
        /// 查询全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public DescribePrometheusGlobalNotificationResponse DescribePrometheusGlobalNotificationSync(DescribePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalNotificationResponse>(req, "DescribePrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceResponse"/></returns>
        public Task<DescribePrometheusInstanceResponse> DescribePrometheusInstance(DescribePrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceResponse>(req, "DescribePrometheusInstance");
        }

        /// <summary>
        /// 获取实例详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceResponse"/></returns>
        public DescribePrometheusInstanceResponse DescribePrometheusInstanceSync(DescribePrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceResponse>(req, "DescribePrometheusInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取2.0实例初始化任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public Task<DescribePrometheusInstanceInitStatusResponse> DescribePrometheusInstanceInitStatus(DescribePrometheusInstanceInitStatusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceInitStatusResponse>(req, "DescribePrometheusInstanceInitStatus");
        }

        /// <summary>
        /// 获取2.0实例初始化任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public DescribePrometheusInstanceInitStatusResponse DescribePrometheusInstanceInitStatusSync(DescribePrometheusInstanceInitStatusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceInitStatusResponse>(req, "DescribePrometheusInstanceInitStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取与云监控融合实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public Task<DescribePrometheusInstancesOverviewResponse> DescribePrometheusInstancesOverview(DescribePrometheusInstancesOverviewRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesOverviewResponse>(req, "DescribePrometheusInstancesOverview");
        }

        /// <summary>
        /// 获取与云监控融合实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public DescribePrometheusInstancesOverviewResponse DescribePrometheusInstancesOverviewSync(DescribePrometheusInstancesOverviewRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesOverviewResponse>(req, "DescribePrometheusInstancesOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusOverviewsRequest"/></param>
        /// <returns><see cref="DescribePrometheusOverviewsResponse"/></returns>
        public Task<DescribePrometheusOverviewsResponse> DescribePrometheusOverviews(DescribePrometheusOverviewsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusOverviewsResponse>(req, "DescribePrometheusOverviews");
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusOverviewsRequest"/></param>
        /// <returns><see cref="DescribePrometheusOverviewsResponse"/></returns>
        public DescribePrometheusOverviewsResponse DescribePrometheusOverviewsSync(DescribePrometheusOverviewsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusOverviewsResponse>(req, "DescribePrometheusOverviews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取聚合规则列表，包含关联集群内crd资源创建的record rule
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public Task<DescribePrometheusRecordRulesResponse> DescribePrometheusRecordRules(DescribePrometheusRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRulesResponse>(req, "DescribePrometheusRecordRules");
        }

        /// <summary>
        /// 获取聚合规则列表，包含关联集群内crd资源创建的record rule
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public DescribePrometheusRecordRulesResponse DescribePrometheusRecordRulesSync(DescribePrometheusRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRulesResponse>(req, "DescribePrometheusRecordRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取targets信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsResponse"/></returns>
        public Task<DescribePrometheusTargetsResponse> DescribePrometheusTargets(DescribePrometheusTargetsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTargetsResponse>(req, "DescribePrometheusTargets");
        }

        /// <summary>
        /// 获取targets信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsResponse"/></returns>
        public DescribePrometheusTargetsResponse DescribePrometheusTargetsSync(DescribePrometheusTargetsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTargetsResponse>(req, "DescribePrometheusTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public Task<DescribePrometheusTempResponse> DescribePrometheusTemp(DescribePrometheusTempRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempResponse>(req, "DescribePrometheusTemp");
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public DescribePrometheusTempResponse DescribePrometheusTempSync(DescribePrometheusTempRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempResponse>(req, "DescribePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模板关联实例信息，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public Task<DescribePrometheusTempSyncResponse> DescribePrometheusTempSync(DescribePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempSyncResponse>(req, "DescribePrometheusTempSync");
        }

        /// <summary>
        /// 获取模板关联实例信息，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public DescribePrometheusTempSyncResponse DescribePrometheusTempSyncSync(DescribePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempSyncResponse>(req, "DescribePrometheusTempSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模板同步信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplateSyncResponse"/></returns>
        public Task<DescribePrometheusTemplateSyncResponse> DescribePrometheusTemplateSync(DescribePrometheusTemplateSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTemplateSyncResponse>(req, "DescribePrometheusTemplateSync");
        }

        /// <summary>
        /// 获取模板同步信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplateSyncResponse"/></returns>
        public DescribePrometheusTemplateSyncResponse DescribePrometheusTemplateSyncSync(DescribePrometheusTemplateSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTemplateSyncResponse>(req, "DescribePrometheusTemplateSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplatesRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplatesResponse"/></returns>
        public Task<DescribePrometheusTemplatesResponse> DescribePrometheusTemplates(DescribePrometheusTemplatesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTemplatesResponse>(req, "DescribePrometheusTemplates");
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplatesRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplatesResponse"/></returns>
        public DescribePrometheusTemplatesResponse DescribePrometheusTemplatesSync(DescribePrometheusTemplatesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTemplatesResponse>(req, "DescribePrometheusTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 预留实例用量查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRIUtilizationDetailRequest"/></param>
        /// <returns><see cref="DescribeRIUtilizationDetailResponse"/></returns>
        public Task<DescribeRIUtilizationDetailResponse> DescribeRIUtilizationDetail(DescribeRIUtilizationDetailRequest req)
        {
            return InternalRequestAsync<DescribeRIUtilizationDetailResponse>(req, "DescribeRIUtilizationDetail");
        }

        /// <summary>
        /// 预留实例用量查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRIUtilizationDetailRequest"/></param>
        /// <returns><see cref="DescribeRIUtilizationDetailResponse"/></returns>
        public DescribeRIUtilizationDetailResponse DescribeRIUtilizationDetailSync(DescribeRIUtilizationDetailRequest req)
        {
            return InternalRequestAsync<DescribeRIUtilizationDetailResponse>(req, "DescribeRIUtilizationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取容器服务支持的所有地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 获取容器服务支持的所有地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询预留实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesResponse"/></returns>
        public Task<DescribeReservedInstancesResponse> DescribeReservedInstances(DescribeReservedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesResponse>(req, "DescribeReservedInstances");
        }

        /// <summary>
        /// 查询预留实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstancesRequest"/></param>
        /// <returns><see cref="DescribeReservedInstancesResponse"/></returns>
        public DescribeReservedInstancesResponse DescribeReservedInstancesSync(DescribeReservedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstancesResponse>(req, "DescribeReservedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群资源使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public Task<DescribeResourceUsageResponse> DescribeResourceUsage(DescribeResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageResponse>(req, "DescribeResourceUsage");
        }

        /// <summary>
        /// 获取集群资源使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public DescribeResourceUsageResponse DescribeResourceUsageSync(DescribeResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageResponse>(req, "DescribeResourceUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询路由表冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public Task<DescribeRouteTableConflictsResponse> DescribeRouteTableConflicts(DescribeRouteTableConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableConflictsResponse>(req, "DescribeRouteTableConflicts");
        }

        /// <summary>
        /// 查询路由表冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public DescribeRouteTableConflictsResponse DescribeRouteTableConflictsSync(DescribeRouteTableConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableConflictsResponse>(req, "DescribeRouteTableConflicts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边缘计算集群的认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterCredentialResponse"/></returns>
        public Task<DescribeTKEEdgeClusterCredentialResponse> DescribeTKEEdgeClusterCredential(DescribeTKEEdgeClusterCredentialRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterCredentialResponse>(req, "DescribeTKEEdgeClusterCredential");
        }

        /// <summary>
        /// 获取边缘计算集群的认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterCredentialResponse"/></returns>
        public DescribeTKEEdgeClusterCredentialResponse DescribeTKEEdgeClusterCredentialSync(DescribeTKEEdgeClusterCredentialRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterCredentialResponse>(req, "DescribeTKEEdgeClusterCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边缘计算集群的当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterStatusResponse"/></returns>
        public Task<DescribeTKEEdgeClusterStatusResponse> DescribeTKEEdgeClusterStatus(DescribeTKEEdgeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterStatusResponse>(req, "DescribeTKEEdgeClusterStatus");
        }

        /// <summary>
        /// 获取边缘计算集群的当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterStatusResponse"/></returns>
        public DescribeTKEEdgeClusterStatusResponse DescribeTKEEdgeClusterStatusSync(DescribeTKEEdgeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterStatusResponse>(req, "DescribeTKEEdgeClusterStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClustersRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClustersResponse"/></returns>
        public Task<DescribeTKEEdgeClustersResponse> DescribeTKEEdgeClusters(DescribeTKEEdgeClustersRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClustersResponse>(req, "DescribeTKEEdgeClusters");
        }

        /// <summary>
        /// 查询边缘集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClustersRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClustersResponse"/></returns>
        public DescribeTKEEdgeClustersResponse DescribeTKEEdgeClustersSync(DescribeTKEEdgeClustersRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClustersResponse>(req, "DescribeTKEEdgeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边缘计算外部访问的kubeconfig
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeExternalKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeExternalKubeconfigResponse"/></returns>
        public Task<DescribeTKEEdgeExternalKubeconfigResponse> DescribeTKEEdgeExternalKubeconfig(DescribeTKEEdgeExternalKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeExternalKubeconfigResponse>(req, "DescribeTKEEdgeExternalKubeconfig");
        }

        /// <summary>
        /// 获取边缘计算外部访问的kubeconfig
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeExternalKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeExternalKubeconfigResponse"/></returns>
        public DescribeTKEEdgeExternalKubeconfigResponse DescribeTKEEdgeExternalKubeconfigSync(DescribeTKEEdgeExternalKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeExternalKubeconfigResponse>(req, "DescribeTKEEdgeExternalKubeconfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取边缘脚本链接，此接口用于添加第三方节点，通过下载脚本从而将节点添加到边缘集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeScriptRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeScriptResponse"/></returns>
        public Task<DescribeTKEEdgeScriptResponse> DescribeTKEEdgeScript(DescribeTKEEdgeScriptRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeScriptResponse>(req, "DescribeTKEEdgeScript");
        }

        /// <summary>
        /// 获取边缘脚本链接，此接口用于添加第三方节点，通过下载脚本从而将节点添加到边缘集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeScriptRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeScriptResponse"/></returns>
        public DescribeTKEEdgeScriptResponse DescribeTKEEdgeScriptSync(DescribeTKEEdgeScriptRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeScriptResponse>(req, "DescribeTKEEdgeScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群版本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionsRequest"/></param>
        /// <returns><see cref="DescribeVersionsResponse"/></returns>
        public Task<DescribeVersionsResponse> DescribeVersions(DescribeVersionsRequest req)
        {
            return InternalRequestAsync<DescribeVersionsResponse>(req, "DescribeVersions");
        }

        /// <summary>
        /// 获取集群版本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionsRequest"/></param>
        /// <returns><see cref="DescribeVersionsResponse"/></returns>
        public DescribeVersionsResponse DescribeVersionsSync(DescribeVersionsRequest req)
        {
            return InternalRequestAsync<DescribeVersionsResponse>(req, "DescribeVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口查询当前用户和地域在指定可用区下的机型可支持的最大 TKE VPC-CNI 网络模式的 Pod 数量
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcCniPodLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcCniPodLimitsResponse"/></returns>
        public Task<DescribeVpcCniPodLimitsResponse> DescribeVpcCniPodLimits(DescribeVpcCniPodLimitsRequest req)
        {
            return InternalRequestAsync<DescribeVpcCniPodLimitsResponse>(req, "DescribeVpcCniPodLimits");
        }

        /// <summary>
        /// 本接口查询当前用户和地域在指定可用区下的机型可支持的最大 TKE VPC-CNI 网络模式的 Pod 数量
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcCniPodLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcCniPodLimitsResponse"/></returns>
        public DescribeVpcCniPodLimitsResponse DescribeVpcCniPodLimitsSync(DescribeVpcCniPodLimitsRequest req)
        {
            return InternalRequestAsync<DescribeVpcCniPodLimitsResponse>(req, "DescribeVpcCniPodLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭集群审计
        /// </summary>
        /// <param name="req"><see cref="DisableClusterAuditRequest"/></param>
        /// <returns><see cref="DisableClusterAuditResponse"/></returns>
        public Task<DisableClusterAuditResponse> DisableClusterAudit(DisableClusterAuditRequest req)
        {
            return InternalRequestAsync<DisableClusterAuditResponse>(req, "DisableClusterAudit");
        }

        /// <summary>
        /// 关闭集群审计
        /// </summary>
        /// <param name="req"><see cref="DisableClusterAuditRequest"/></param>
        /// <returns><see cref="DisableClusterAuditResponse"/></returns>
        public DisableClusterAuditResponse DisableClusterAuditSync(DisableClusterAuditRequest req)
        {
            return InternalRequestAsync<DisableClusterAuditResponse>(req, "DisableClusterAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭集群删除保护
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableClusterDeletionProtectionResponse"/></returns>
        public Task<DisableClusterDeletionProtectionResponse> DisableClusterDeletionProtection(DisableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<DisableClusterDeletionProtectionResponse>(req, "DisableClusterDeletionProtection");
        }

        /// <summary>
        /// 关闭集群删除保护
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableClusterDeletionProtectionResponse"/></returns>
        public DisableClusterDeletionProtectionResponse DisableClusterDeletionProtectionSync(DisableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<DisableClusterDeletionProtectionResponse>(req, "DisableClusterDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭加密信息保护
        /// </summary>
        /// <param name="req"><see cref="DisableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="DisableEncryptionProtectionResponse"/></returns>
        public Task<DisableEncryptionProtectionResponse> DisableEncryptionProtection(DisableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<DisableEncryptionProtectionResponse>(req, "DisableEncryptionProtection");
        }

        /// <summary>
        /// 关闭加密信息保护
        /// </summary>
        /// <param name="req"><see cref="DisableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="DisableEncryptionProtectionResponse"/></returns>
        public DisableEncryptionProtectionResponse DisableEncryptionProtectionSync(DisableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<DisableEncryptionProtectionResponse>(req, "DisableEncryptionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="DisableEventPersistenceRequest"/></param>
        /// <returns><see cref="DisableEventPersistenceResponse"/></returns>
        public Task<DisableEventPersistenceResponse> DisableEventPersistence(DisableEventPersistenceRequest req)
        {
            return InternalRequestAsync<DisableEventPersistenceResponse>(req, "DisableEventPersistence");
        }

        /// <summary>
        /// 关闭事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="DisableEventPersistenceRequest"/></param>
        /// <returns><see cref="DisableEventPersistenceResponse"/></returns>
        public DisableEventPersistenceResponse DisableEventPersistenceSync(DisableEventPersistenceRequest req)
        {
            return InternalRequestAsync<DisableEventPersistenceResponse>(req, "DisableEventPersistence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供给附加了VPC-CNI能力的Global-Route集群关闭VPC-CNI
        /// </summary>
        /// <param name="req"><see cref="DisableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="DisableVpcCniNetworkTypeResponse"/></returns>
        public Task<DisableVpcCniNetworkTypeResponse> DisableVpcCniNetworkType(DisableVpcCniNetworkTypeRequest req)
        {
            return InternalRequestAsync<DisableVpcCniNetworkTypeResponse>(req, "DisableVpcCniNetworkType");
        }

        /// <summary>
        /// 提供给附加了VPC-CNI能力的Global-Route集群关闭VPC-CNI
        /// </summary>
        /// <param name="req"><see cref="DisableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="DisableVpcCniNetworkTypeResponse"/></returns>
        public DisableVpcCniNetworkTypeResponse DisableVpcCniNetworkTypeSync(DisableVpcCniNetworkTypeRequest req)
        {
            return InternalRequestAsync<DisableVpcCniNetworkTypeResponse>(req, "DisableVpcCniNetworkType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 驱逐超级节点
        /// </summary>
        /// <param name="req"><see cref="DrainClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DrainClusterVirtualNodeResponse"/></returns>
        public Task<DrainClusterVirtualNodeResponse> DrainClusterVirtualNode(DrainClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DrainClusterVirtualNodeResponse>(req, "DrainClusterVirtualNode");
        }

        /// <summary>
        /// 驱逐超级节点
        /// </summary>
        /// <param name="req"><see cref="DrainClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DrainClusterVirtualNodeResponse"/></returns>
        public DrainClusterVirtualNodeResponse DrainClusterVirtualNodeSync(DrainClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DrainClusterVirtualNodeResponse>(req, "DrainClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启集群审计
        /// </summary>
        /// <param name="req"><see cref="EnableClusterAuditRequest"/></param>
        /// <returns><see cref="EnableClusterAuditResponse"/></returns>
        public Task<EnableClusterAuditResponse> EnableClusterAudit(EnableClusterAuditRequest req)
        {
            return InternalRequestAsync<EnableClusterAuditResponse>(req, "EnableClusterAudit");
        }

        /// <summary>
        /// 开启集群审计
        /// </summary>
        /// <param name="req"><see cref="EnableClusterAuditRequest"/></param>
        /// <returns><see cref="EnableClusterAuditResponse"/></returns>
        public EnableClusterAuditResponse EnableClusterAuditSync(EnableClusterAuditRequest req)
        {
            return InternalRequestAsync<EnableClusterAuditResponse>(req, "EnableClusterAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用集群删除保护
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableClusterDeletionProtectionResponse"/></returns>
        public Task<EnableClusterDeletionProtectionResponse> EnableClusterDeletionProtection(EnableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<EnableClusterDeletionProtectionResponse>(req, "EnableClusterDeletionProtection");
        }

        /// <summary>
        /// 启用集群删除保护
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableClusterDeletionProtectionResponse"/></returns>
        public EnableClusterDeletionProtectionResponse EnableClusterDeletionProtectionSync(EnableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<EnableClusterDeletionProtectionResponse>(req, "EnableClusterDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启加密数据保护
        /// </summary>
        /// <param name="req"><see cref="EnableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="EnableEncryptionProtectionResponse"/></returns>
        public Task<EnableEncryptionProtectionResponse> EnableEncryptionProtection(EnableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<EnableEncryptionProtectionResponse>(req, "EnableEncryptionProtection");
        }

        /// <summary>
        /// 开启加密数据保护
        /// </summary>
        /// <param name="req"><see cref="EnableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="EnableEncryptionProtectionResponse"/></returns>
        public EnableEncryptionProtectionResponse EnableEncryptionProtectionSync(EnableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<EnableEncryptionProtectionResponse>(req, "EnableEncryptionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="EnableEventPersistenceRequest"/></param>
        /// <returns><see cref="EnableEventPersistenceResponse"/></returns>
        public Task<EnableEventPersistenceResponse> EnableEventPersistence(EnableEventPersistenceRequest req)
        {
            return InternalRequestAsync<EnableEventPersistenceResponse>(req, "EnableEventPersistence");
        }

        /// <summary>
        /// 开启事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="EnableEventPersistenceRequest"/></param>
        /// <returns><see cref="EnableEventPersistenceResponse"/></returns>
        public EnableEventPersistenceResponse EnableEventPersistenceSync(EnableEventPersistenceRequest req)
        {
            return InternalRequestAsync<EnableEventPersistenceResponse>(req, "EnableEventPersistence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// GR集群可以通过本接口附加vpc-cni容器网络插件，开启vpc-cni容器网络能力
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public Task<EnableVpcCniNetworkTypeResponse> EnableVpcCniNetworkType(EnableVpcCniNetworkTypeRequest req)
        {
            return InternalRequestAsync<EnableVpcCniNetworkTypeResponse>(req, "EnableVpcCniNetworkType");
        }

        /// <summary>
        /// GR集群可以通过本接口附加vpc-cni容器网络插件，开启vpc-cni容器网络能力
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public EnableVpcCniNetworkTypeResponse EnableVpcCniNetworkTypeSync(EnableVpcCniNetworkTypeRequest req)
        {
            return InternalRequestAsync<EnableVpcCniNetworkTypeResponse>(req, "EnableVpcCniNetworkType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作TKE集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardApplicationRequestV3Response"/></returns>
        public Task<ForwardApplicationRequestV3Response> ForwardApplicationRequestV3(ForwardApplicationRequestV3Request req)
        {
            return InternalRequestAsync<ForwardApplicationRequestV3Response>(req, "ForwardApplicationRequestV3");
        }

        /// <summary>
        /// 操作TKE集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardApplicationRequestV3Response"/></returns>
        public ForwardApplicationRequestV3Response ForwardApplicationRequestV3Sync(ForwardApplicationRequestV3Request req)
        {
            return InternalRequestAsync<ForwardApplicationRequestV3Response>(req, "ForwardApplicationRequestV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作TKEEdge集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardTKEEdgeApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardTKEEdgeApplicationRequestV3Response"/></returns>
        public Task<ForwardTKEEdgeApplicationRequestV3Response> ForwardTKEEdgeApplicationRequestV3(ForwardTKEEdgeApplicationRequestV3Request req)
        {
            return InternalRequestAsync<ForwardTKEEdgeApplicationRequestV3Response>(req, "ForwardTKEEdgeApplicationRequestV3");
        }

        /// <summary>
        /// 操作TKEEdge集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardTKEEdgeApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardTKEEdgeApplicationRequestV3Response"/></returns>
        public ForwardTKEEdgeApplicationRequestV3Response ForwardTKEEdgeApplicationRequestV3Sync(ForwardTKEEdgeApplicationRequestV3Request req)
        {
            return InternalRequestAsync<ForwardTKEEdgeApplicationRequestV3Response>(req, "ForwardTKEEdgeApplicationRequestV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群规模价格
        /// </summary>
        /// <param name="req"><see cref="GetClusterLevelPriceRequest"/></param>
        /// <returns><see cref="GetClusterLevelPriceResponse"/></returns>
        public Task<GetClusterLevelPriceResponse> GetClusterLevelPrice(GetClusterLevelPriceRequest req)
        {
            return InternalRequestAsync<GetClusterLevelPriceResponse>(req, "GetClusterLevelPrice");
        }

        /// <summary>
        /// 获取集群规模价格
        /// </summary>
        /// <param name="req"><see cref="GetClusterLevelPriceRequest"/></param>
        /// <returns><see cref="GetClusterLevelPriceResponse"/></returns>
        public GetClusterLevelPriceResponse GetClusterLevelPriceSync(GetClusterLevelPriceRequest req)
        {
            return InternalRequestAsync<GetClusterLevelPriceResponse>(req, "GetClusterLevelPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据镜像列表，查询匹配的镜像缓存
        /// </summary>
        /// <param name="req"><see cref="GetMostSuitableImageCacheRequest"/></param>
        /// <returns><see cref="GetMostSuitableImageCacheResponse"/></returns>
        public Task<GetMostSuitableImageCacheResponse> GetMostSuitableImageCache(GetMostSuitableImageCacheRequest req)
        {
            return InternalRequestAsync<GetMostSuitableImageCacheResponse>(req, "GetMostSuitableImageCache");
        }

        /// <summary>
        /// 根据镜像列表，查询匹配的镜像缓存
        /// </summary>
        /// <param name="req"><see cref="GetMostSuitableImageCacheRequest"/></param>
        /// <returns><see cref="GetMostSuitableImageCacheResponse"/></returns>
        public GetMostSuitableImageCacheResponse GetMostSuitableImageCacheSync(GetMostSuitableImageCacheRequest req)
        {
            return InternalRequestAsync<GetMostSuitableImageCacheResponse>(req, "GetMostSuitableImageCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TKE支持的App列表
        /// </summary>
        /// <param name="req"><see cref="GetTkeAppChartListRequest"/></param>
        /// <returns><see cref="GetTkeAppChartListResponse"/></returns>
        public Task<GetTkeAppChartListResponse> GetTkeAppChartList(GetTkeAppChartListRequest req)
        {
            return InternalRequestAsync<GetTkeAppChartListResponse>(req, "GetTkeAppChartList");
        }

        /// <summary>
        /// 获取TKE支持的App列表
        /// </summary>
        /// <param name="req"><see cref="GetTkeAppChartListRequest"/></param>
        /// <returns><see cref="GetTkeAppChartListResponse"/></returns>
        public GetTkeAppChartListResponse GetTkeAppChartListSync(GetTkeAppChartListRequest req)
        {
            return InternalRequestAsync<GetTkeAppChartListResponse>(req, "GetTkeAppChartList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获得节点升级当前的进度
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public Task<GetUpgradeInstanceProgressResponse> GetUpgradeInstanceProgress(GetUpgradeInstanceProgressRequest req)
        {
            return InternalRequestAsync<GetUpgradeInstanceProgressResponse>(req, "GetUpgradeInstanceProgress");
        }

        /// <summary>
        /// 获得节点升级当前的进度
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public GetUpgradeInstanceProgressResponse GetUpgradeInstanceProgressSync(GetUpgradeInstanceProgressRequest req)
        {
            return InternalRequestAsync<GetUpgradeInstanceProgressResponse>(req, "GetUpgradeInstanceProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为目标集群安装一个addon
        /// </summary>
        /// <param name="req"><see cref="InstallAddonRequest"/></param>
        /// <returns><see cref="InstallAddonResponse"/></returns>
        public Task<InstallAddonResponse> InstallAddon(InstallAddonRequest req)
        {
            return InternalRequestAsync<InstallAddonResponse>(req, "InstallAddon");
        }

        /// <summary>
        /// 为目标集群安装一个addon
        /// </summary>
        /// <param name="req"><see cref="InstallAddonRequest"/></param>
        /// <returns><see cref="InstallAddonResponse"/></returns>
        public InstallAddonResponse InstallAddonSync(InstallAddonRequest req)
        {
            return InternalRequestAsync<InstallAddonResponse>(req, "InstallAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在tke@edge集群的边缘节点上安装日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="InstallEdgeLogAgentResponse"/></returns>
        public Task<InstallEdgeLogAgentResponse> InstallEdgeLogAgent(InstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<InstallEdgeLogAgentResponse>(req, "InstallEdgeLogAgent");
        }

        /// <summary>
        /// 在tke@edge集群的边缘节点上安装日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="InstallEdgeLogAgentResponse"/></returns>
        public InstallEdgeLogAgentResponse InstallEdgeLogAgentSync(InstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<InstallEdgeLogAgentResponse>(req, "InstallEdgeLogAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在TKE集群中安装CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallLogAgentRequest"/></param>
        /// <returns><see cref="InstallLogAgentResponse"/></returns>
        public Task<InstallLogAgentResponse> InstallLogAgent(InstallLogAgentRequest req)
        {
            return InternalRequestAsync<InstallLogAgentResponse>(req, "InstallLogAgent");
        }

        /// <summary>
        /// 在TKE集群中安装CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallLogAgentRequest"/></param>
        /// <returns><see cref="InstallLogAgentResponse"/></returns>
        public InstallLogAgentResponse InstallLogAgentSync(InstallLogAgentRequest req)
        {
            return InternalRequestAsync<InstallLogAgentResponse>(req, "InstallLogAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定集群的巡检结果信息
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsResponse"/></returns>
        public Task<ListClusterInspectionResultsResponse> ListClusterInspectionResults(ListClusterInspectionResultsRequest req)
        {
            return InternalRequestAsync<ListClusterInspectionResultsResponse>(req, "ListClusterInspectionResults");
        }

        /// <summary>
        /// 查询指定集群的巡检结果信息
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsResponse"/></returns>
        public ListClusterInspectionResultsResponse ListClusterInspectionResultsSync(ListClusterInspectionResultsRequest req)
        {
            return InternalRequestAsync<ListClusterInspectionResultsResponse>(req, "ListClusterInspectionResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群巡检结果历史列表
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsItemsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsItemsResponse"/></returns>
        public Task<ListClusterInspectionResultsItemsResponse> ListClusterInspectionResultsItems(ListClusterInspectionResultsItemsRequest req)
        {
            return InternalRequestAsync<ListClusterInspectionResultsItemsResponse>(req, "ListClusterInspectionResultsItems");
        }

        /// <summary>
        /// 查询集群巡检结果历史列表
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsItemsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsItemsResponse"/></returns>
        public ListClusterInspectionResultsItemsResponse ListClusterInspectionResultsItemsSync(ListClusterInspectionResultsItemsRequest req)
        {
            return InternalRequestAsync<ListClusterInspectionResultsItemsResponse>(req, "ListClusterInspectionResultsItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群伸缩组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public Task<ModifyClusterAsGroupAttributeResponse> ModifyClusterAsGroupAttribute(ModifyClusterAsGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupAttributeResponse>(req, "ModifyClusterAsGroupAttribute");
        }

        /// <summary>
        /// 修改集群伸缩组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public ModifyClusterAsGroupAttributeResponse ModifyClusterAsGroupAttributeSync(ModifyClusterAsGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupAttributeResponse>(req, "ModifyClusterAsGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群弹性伸缩属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public Task<ModifyClusterAsGroupOptionAttributeResponse> ModifyClusterAsGroupOptionAttribute(ModifyClusterAsGroupOptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupOptionAttributeResponse>(req, "ModifyClusterAsGroupOptionAttribute");
        }

        /// <summary>
        /// 修改集群弹性伸缩属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public ModifyClusterAsGroupOptionAttributeResponse ModifyClusterAsGroupOptionAttributeSync(ModifyClusterAsGroupOptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupOptionAttributeResponse>(req, "ModifyClusterAsGroupOptionAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public Task<ModifyClusterAttributeResponse> ModifyClusterAttribute(ModifyClusterAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAttributeResponse>(req, "ModifyClusterAttribute");
        }

        /// <summary>
        /// 修改集群属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public ModifyClusterAttributeResponse ModifyClusterAttributeSync(ModifyClusterAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAttributeResponse>(req, "ModifyClusterAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群认证配置
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="ModifyClusterAuthenticationOptionsResponse"/></returns>
        public Task<ModifyClusterAuthenticationOptionsResponse> ModifyClusterAuthenticationOptions(ModifyClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<ModifyClusterAuthenticationOptionsResponse>(req, "ModifyClusterAuthenticationOptions");
        }

        /// <summary>
        /// 修改集群认证配置
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="ModifyClusterAuthenticationOptionsResponse"/></returns>
        public ModifyClusterAuthenticationOptionsResponse ModifyClusterAuthenticationOptionsSync(ModifyClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<ModifyClusterAuthenticationOptionsResponse>(req, "ModifyClusterAuthenticationOptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改托管集群外网端口的安全策略（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public Task<ModifyClusterEndpointSPResponse> ModifyClusterEndpointSP(ModifyClusterEndpointSPRequest req)
        {
            return InternalRequestAsync<ModifyClusterEndpointSPResponse>(req, "ModifyClusterEndpointSP");
        }

        /// <summary>
        /// 修改托管集群外网端口的安全策略（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public ModifyClusterEndpointSPResponse ModifyClusterEndpointSPSync(ModifyClusterEndpointSPRequest req)
        {
            return InternalRequestAsync<ModifyClusterEndpointSPResponse>(req, "ModifyClusterEndpointSP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public Task<ModifyClusterNodePoolResponse> ModifyClusterNodePool(ModifyClusterNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterNodePoolResponse>(req, "ModifyClusterNodePool");
        }

        /// <summary>
        /// 编辑节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public ModifyClusterNodePoolResponse ModifyClusterNodePoolSync(ModifyClusterNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterNodePoolResponse>(req, "ModifyClusterNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改超级节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterVirtualNodePoolResponse"/></returns>
        public Task<ModifyClusterVirtualNodePoolResponse> ModifyClusterVirtualNodePool(ModifyClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterVirtualNodePoolResponse>(req, "ModifyClusterVirtualNodePool");
        }

        /// <summary>
        /// 修改超级节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterVirtualNodePoolResponse"/></returns>
        public ModifyClusterVirtualNodePoolResponse ModifyClusterVirtualNodePoolSync(ModifyClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterVirtualNodePoolResponse>(req, "ModifyClusterVirtualNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改节点池关联伸缩组的期望实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolDesiredCapacityAboutAsgRequest"/></param>
        /// <returns><see cref="ModifyNodePoolDesiredCapacityAboutAsgResponse"/></returns>
        public Task<ModifyNodePoolDesiredCapacityAboutAsgResponse> ModifyNodePoolDesiredCapacityAboutAsg(ModifyNodePoolDesiredCapacityAboutAsgRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolDesiredCapacityAboutAsgResponse>(req, "ModifyNodePoolDesiredCapacityAboutAsg");
        }

        /// <summary>
        /// 修改节点池关联伸缩组的期望实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolDesiredCapacityAboutAsgRequest"/></param>
        /// <returns><see cref="ModifyNodePoolDesiredCapacityAboutAsgResponse"/></returns>
        public ModifyNodePoolDesiredCapacityAboutAsgResponse ModifyNodePoolDesiredCapacityAboutAsgSync(ModifyNodePoolDesiredCapacityAboutAsgRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolDesiredCapacityAboutAsgResponse>(req, "ModifyNodePoolDesiredCapacityAboutAsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改节点池的机型配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolInstanceTypesRequest"/></param>
        /// <returns><see cref="ModifyNodePoolInstanceTypesResponse"/></returns>
        public Task<ModifyNodePoolInstanceTypesResponse> ModifyNodePoolInstanceTypes(ModifyNodePoolInstanceTypesRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolInstanceTypesResponse>(req, "ModifyNodePoolInstanceTypes");
        }

        /// <summary>
        /// 修改节点池的机型配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolInstanceTypesRequest"/></param>
        /// <returns><see cref="ModifyNodePoolInstanceTypesResponse"/></returns>
        public ModifyNodePoolInstanceTypesResponse ModifyNodePoolInstanceTypesSync(ModifyNodePoolInstanceTypesRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolInstanceTypesResponse>(req, "ModifyNodePoolInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改被关联集群的external labels
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public Task<ModifyPrometheusAgentExternalLabelsResponse> ModifyPrometheusAgentExternalLabels(ModifyPrometheusAgentExternalLabelsRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAgentExternalLabelsResponse>(req, "ModifyPrometheusAgentExternalLabels");
        }

        /// <summary>
        /// 修改被关联集群的external labels
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public ModifyPrometheusAgentExternalLabelsResponse ModifyPrometheusAgentExternalLabelsSync(ModifyPrometheusAgentExternalLabelsRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAgentExternalLabelsResponse>(req, "ModifyPrometheusAgentExternalLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public Task<ModifyPrometheusAlertPolicyResponse> ModifyPrometheusAlertPolicy(ModifyPrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertPolicyResponse>(req, "ModifyPrometheusAlertPolicy");
        }

        /// <summary>
        /// 修改2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public ModifyPrometheusAlertPolicyResponse ModifyPrometheusAlertPolicySync(ModifyPrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertPolicyResponse>(req, "ModifyPrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertRuleResponse"/></returns>
        public Task<ModifyPrometheusAlertRuleResponse> ModifyPrometheusAlertRule(ModifyPrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertRuleResponse>(req, "ModifyPrometheusAlertRule");
        }

        /// <summary>
        /// 修改告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertRuleResponse"/></returns>
        public ModifyPrometheusAlertRuleResponse ModifyPrometheusAlertRuleSync(ModifyPrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertRuleResponse>(req, "ModifyPrometheusAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改prometheus配置，如果配置项不存在，则会新增
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public Task<ModifyPrometheusConfigResponse> ModifyPrometheusConfig(ModifyPrometheusConfigRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusConfigResponse>(req, "ModifyPrometheusConfig");
        }

        /// <summary>
        /// 修改prometheus配置，如果配置项不存在，则会新增
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public ModifyPrometheusConfigResponse ModifyPrometheusConfigSync(ModifyPrometheusConfigRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusConfigResponse>(req, "ModifyPrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public Task<ModifyPrometheusGlobalNotificationResponse> ModifyPrometheusGlobalNotification(ModifyPrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusGlobalNotificationResponse>(req, "ModifyPrometheusGlobalNotification");
        }

        /// <summary>
        /// 修改全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public ModifyPrometheusGlobalNotificationResponse ModifyPrometheusGlobalNotificationSync(ModifyPrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusGlobalNotificationResponse>(req, "ModifyPrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过yaml的方式修改Prometheus聚合实例
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public Task<ModifyPrometheusRecordRuleYamlResponse> ModifyPrometheusRecordRuleYaml(ModifyPrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusRecordRuleYamlResponse>(req, "ModifyPrometheusRecordRuleYaml");
        }

        /// <summary>
        /// 通过yaml的方式修改Prometheus聚合实例
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public ModifyPrometheusRecordRuleYamlResponse ModifyPrometheusRecordRuleYamlSync(ModifyPrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusRecordRuleYamlResponse>(req, "ModifyPrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public Task<ModifyPrometheusTempResponse> ModifyPrometheusTemp(ModifyPrometheusTempRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTempResponse>(req, "ModifyPrometheusTemp");
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public ModifyPrometheusTempResponse ModifyPrometheusTempSync(ModifyPrometheusTempRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTempResponse>(req, "ModifyPrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTemplateRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTemplateResponse"/></returns>
        public Task<ModifyPrometheusTemplateResponse> ModifyPrometheusTemplate(ModifyPrometheusTemplateRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTemplateResponse>(req, "ModifyPrometheusTemplate");
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTemplateRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTemplateResponse"/></returns>
        public ModifyPrometheusTemplateResponse ModifyPrometheusTemplateSync(ModifyPrometheusTemplateRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTemplateResponse>(req, "ModifyPrometheusTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改预留券的抵扣范围，抵扣范围取值：Region、Zone 和 Node。
        /// </summary>
        /// <param name="req"><see cref="ModifyReservedInstanceScopeRequest"/></param>
        /// <returns><see cref="ModifyReservedInstanceScopeResponse"/></returns>
        public Task<ModifyReservedInstanceScopeResponse> ModifyReservedInstanceScope(ModifyReservedInstanceScopeRequest req)
        {
            return InternalRequestAsync<ModifyReservedInstanceScopeResponse>(req, "ModifyReservedInstanceScope");
        }

        /// <summary>
        /// 修改预留券的抵扣范围，抵扣范围取值：Region、Zone 和 Node。
        /// </summary>
        /// <param name="req"><see cref="ModifyReservedInstanceScopeRequest"/></param>
        /// <returns><see cref="ModifyReservedInstanceScopeResponse"/></returns>
        public ModifyReservedInstanceScopeResponse ModifyReservedInstanceScopeSync(ModifyReservedInstanceScopeRequest req)
        {
            return InternalRequestAsync<ModifyReservedInstanceScopeResponse>(req, "ModifyReservedInstanceScope")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移出节点池节点，但保留在集群内
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public Task<RemoveNodeFromNodePoolResponse> RemoveNodeFromNodePool(RemoveNodeFromNodePoolRequest req)
        {
            return InternalRequestAsync<RemoveNodeFromNodePoolResponse>(req, "RemoveNodeFromNodePool");
        }

        /// <summary>
        /// 移出节点池节点，但保留在集群内
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public RemoveNodeFromNodePoolResponse RemoveNodeFromNodePoolSync(RemoveNodeFromNodePoolRequest req)
        {
            return InternalRequestAsync<RemoveNodeFromNodePoolResponse>(req, "RemoveNodeFromNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续费时请确保账户余额充足。
        /// </summary>
        /// <param name="req"><see cref="RenewReservedInstancesRequest"/></param>
        /// <returns><see cref="RenewReservedInstancesResponse"/></returns>
        public Task<RenewReservedInstancesResponse> RenewReservedInstances(RenewReservedInstancesRequest req)
        {
            return InternalRequestAsync<RenewReservedInstancesResponse>(req, "RenewReservedInstances");
        }

        /// <summary>
        /// 续费时请确保账户余额充足。
        /// </summary>
        /// <param name="req"><see cref="RenewReservedInstancesRequest"/></param>
        /// <returns><see cref="RenewReservedInstancesResponse"/></returns>
        public RenewReservedInstancesResponse RenewReservedInstancesSync(RenewReservedInstancesRequest req)
        {
            return InternalRequestAsync<RenewReservedInstancesResponse>(req, "RenewReservedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启弹性容器实例，支持批量操作
        /// </summary>
        /// <param name="req"><see cref="RestartEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="RestartEKSContainerInstancesResponse"/></returns>
        public Task<RestartEKSContainerInstancesResponse> RestartEKSContainerInstances(RestartEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<RestartEKSContainerInstancesResponse>(req, "RestartEKSContainerInstances");
        }

        /// <summary>
        /// 重启弹性容器实例，支持批量操作
        /// </summary>
        /// <param name="req"><see cref="RestartEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="RestartEKSContainerInstancesResponse"/></returns>
        public RestartEKSContainerInstancesResponse RestartEKSContainerInstancesSync(RestartEKSContainerInstancesRequest req)
        {
            return InternalRequestAsync<RestartEKSContainerInstancesResponse>(req, "RestartEKSContainerInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在应用市场中集群回滚应用至某个历史版本
        /// </summary>
        /// <param name="req"><see cref="RollbackClusterReleaseRequest"/></param>
        /// <returns><see cref="RollbackClusterReleaseResponse"/></returns>
        public Task<RollbackClusterReleaseResponse> RollbackClusterRelease(RollbackClusterReleaseRequest req)
        {
            return InternalRequestAsync<RollbackClusterReleaseResponse>(req, "RollbackClusterRelease");
        }

        /// <summary>
        /// 在应用市场中集群回滚应用至某个历史版本
        /// </summary>
        /// <param name="req"><see cref="RollbackClusterReleaseRequest"/></param>
        /// <returns><see cref="RollbackClusterReleaseResponse"/></returns>
        public RollbackClusterReleaseResponse RollbackClusterReleaseSync(RollbackClusterReleaseRequest req)
        {
            return InternalRequestAsync<RollbackClusterReleaseResponse>(req, "RollbackClusterRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 初始化TMP实例，开启集成中心时调用
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public Task<RunPrometheusInstanceResponse> RunPrometheusInstance(RunPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<RunPrometheusInstanceResponse>(req, "RunPrometheusInstance");
        }

        /// <summary>
        /// 初始化TMP实例，开启集成中心时调用
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public RunPrometheusInstanceResponse RunPrometheusInstanceSync(RunPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<RunPrometheusInstanceResponse>(req, "RunPrometheusInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 缩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleInClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleInClusterMasterResponse"/></returns>
        public Task<ScaleInClusterMasterResponse> ScaleInClusterMaster(ScaleInClusterMasterRequest req)
        {
            return InternalRequestAsync<ScaleInClusterMasterResponse>(req, "ScaleInClusterMaster");
        }

        /// <summary>
        /// 缩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleInClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleInClusterMasterResponse"/></returns>
        public ScaleInClusterMasterResponse ScaleInClusterMasterSync(ScaleInClusterMasterRequest req)
        {
            return InternalRequestAsync<ScaleInClusterMasterResponse>(req, "ScaleInClusterMaster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterMasterResponse"/></returns>
        public Task<ScaleOutClusterMasterResponse> ScaleOutClusterMaster(ScaleOutClusterMasterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterMasterResponse>(req, "ScaleOutClusterMaster");
        }

        /// <summary>
        /// 扩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterMasterResponse"/></returns>
        public ScaleOutClusterMasterResponse ScaleOutClusterMasterSync(ScaleOutClusterMasterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterMasterResponse>(req, "ScaleOutClusterMaster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 仅能设置节点池中处于伸缩组的节点
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public Task<SetNodePoolNodeProtectionResponse> SetNodePoolNodeProtection(SetNodePoolNodeProtectionRequest req)
        {
            return InternalRequestAsync<SetNodePoolNodeProtectionResponse>(req, "SetNodePoolNodeProtection");
        }

        /// <summary>
        /// 仅能设置节点池中处于伸缩组的节点
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public SetNodePoolNodeProtectionResponse SetNodePoolNodeProtectionSync(SetNodePoolNodeProtectionRequest req)
        {
            return InternalRequestAsync<SetNodePoolNodeProtectionResponse>(req, "SetNodePoolNodeProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步模板到实例或者集群，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public Task<SyncPrometheusTempResponse> SyncPrometheusTemp(SyncPrometheusTempRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTempResponse>(req, "SyncPrometheusTemp");
        }

        /// <summary>
        /// 同步模板到实例或者集群，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public SyncPrometheusTempResponse SyncPrometheusTempSync(SyncPrometheusTempRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTempResponse>(req, "SyncPrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步模板到实例或者集群
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTemplateRequest"/></param>
        /// <returns><see cref="SyncPrometheusTemplateResponse"/></returns>
        public Task<SyncPrometheusTemplateResponse> SyncPrometheusTemplate(SyncPrometheusTemplateRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTemplateResponse>(req, "SyncPrometheusTemplate");
        }

        /// <summary>
        /// 同步模板到实例或者集群
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTemplateRequest"/></param>
        /// <returns><see cref="SyncPrometheusTemplateResponse"/></returns>
        public SyncPrometheusTemplateResponse SyncPrometheusTemplateSync(SyncPrometheusTemplateRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTemplateResponse>(req, "SyncPrometheusTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在应用市场中集群删除某个应用
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterReleaseRequest"/></param>
        /// <returns><see cref="UninstallClusterReleaseResponse"/></returns>
        public Task<UninstallClusterReleaseResponse> UninstallClusterRelease(UninstallClusterReleaseRequest req)
        {
            return InternalRequestAsync<UninstallClusterReleaseResponse>(req, "UninstallClusterRelease");
        }

        /// <summary>
        /// 在应用市场中集群删除某个应用
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterReleaseRequest"/></param>
        /// <returns><see cref="UninstallClusterReleaseResponse"/></returns>
        public UninstallClusterReleaseResponse UninstallClusterReleaseSync(UninstallClusterReleaseRequest req)
        {
            return InternalRequestAsync<UninstallClusterReleaseResponse>(req, "UninstallClusterRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从tke@edge集群边缘节点上卸载日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="UninstallEdgeLogAgentResponse"/></returns>
        public Task<UninstallEdgeLogAgentResponse> UninstallEdgeLogAgent(UninstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<UninstallEdgeLogAgentResponse>(req, "UninstallEdgeLogAgent");
        }

        /// <summary>
        /// 从tke@edge集群边缘节点上卸载日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="UninstallEdgeLogAgentResponse"/></returns>
        public UninstallEdgeLogAgentResponse UninstallEdgeLogAgentSync(UninstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<UninstallEdgeLogAgentResponse>(req, "UninstallEdgeLogAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从TKE集群中卸载CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallLogAgentRequest"/></param>
        /// <returns><see cref="UninstallLogAgentResponse"/></returns>
        public Task<UninstallLogAgentResponse> UninstallLogAgent(UninstallLogAgentRequest req)
        {
            return InternalRequestAsync<UninstallLogAgentResponse>(req, "UninstallLogAgent");
        }

        /// <summary>
        /// 从TKE集群中卸载CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallLogAgentRequest"/></param>
        /// <returns><see cref="UninstallLogAgentResponse"/></returns>
        public UninstallLogAgentResponse UninstallLogAgentSync(UninstallLogAgentRequest req)
        {
            return InternalRequestAsync<UninstallLogAgentResponse>(req, "UninstallLogAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新一个addon的参数和版本
        /// </summary>
        /// <param name="req"><see cref="UpdateAddonRequest"/></param>
        /// <returns><see cref="UpdateAddonResponse"/></returns>
        public Task<UpdateAddonResponse> UpdateAddon(UpdateAddonRequest req)
        {
            return InternalRequestAsync<UpdateAddonResponse>(req, "UpdateAddon");
        }

        /// <summary>
        /// 更新一个addon的参数和版本
        /// </summary>
        /// <param name="req"><see cref="UpdateAddonRequest"/></param>
        /// <returns><see cref="UpdateAddonResponse"/></returns>
        public UpdateAddonResponse UpdateAddonSync(UpdateAddonRequest req)
        {
            return InternalRequestAsync<UpdateAddonResponse>(req, "UpdateAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对集群的Kubeconfig信息进行更新
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterKubeconfigRequest"/></param>
        /// <returns><see cref="UpdateClusterKubeconfigResponse"/></returns>
        public Task<UpdateClusterKubeconfigResponse> UpdateClusterKubeconfig(UpdateClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<UpdateClusterKubeconfigResponse>(req, "UpdateClusterKubeconfig");
        }

        /// <summary>
        /// 对集群的Kubeconfig信息进行更新
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterKubeconfigRequest"/></param>
        /// <returns><see cref="UpdateClusterKubeconfigResponse"/></returns>
        public UpdateClusterKubeconfigResponse UpdateClusterKubeconfigSync(UpdateClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<UpdateClusterKubeconfigResponse>(req, "UpdateClusterKubeconfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级集群 Master 组件到指定版本
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public Task<UpdateClusterVersionResponse> UpdateClusterVersion(UpdateClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateClusterVersionResponse>(req, "UpdateClusterVersion");
        }

        /// <summary>
        /// 升级集群 Master 组件到指定版本
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public UpdateClusterVersionResponse UpdateClusterVersionSync(UpdateClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateClusterVersionResponse>(req, "UpdateClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改弹性集群名称等属性 
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSClusterRequest"/></param>
        /// <returns><see cref="UpdateEKSClusterResponse"/></returns>
        public Task<UpdateEKSClusterResponse> UpdateEKSCluster(UpdateEKSClusterRequest req)
        {
            return InternalRequestAsync<UpdateEKSClusterResponse>(req, "UpdateEKSCluster");
        }

        /// <summary>
        /// 修改弹性集群名称等属性 
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSClusterRequest"/></param>
        /// <returns><see cref="UpdateEKSClusterResponse"/></returns>
        public UpdateEKSClusterResponse UpdateEKSClusterSync(UpdateEKSClusterRequest req)
        {
            return InternalRequestAsync<UpdateEKSClusterResponse>(req, "UpdateEKSCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新容器实例
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSContainerInstanceRequest"/></param>
        /// <returns><see cref="UpdateEKSContainerInstanceResponse"/></returns>
        public Task<UpdateEKSContainerInstanceResponse> UpdateEKSContainerInstance(UpdateEKSContainerInstanceRequest req)
        {
            return InternalRequestAsync<UpdateEKSContainerInstanceResponse>(req, "UpdateEKSContainerInstance");
        }

        /// <summary>
        /// 更新容器实例
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSContainerInstanceRequest"/></param>
        /// <returns><see cref="UpdateEKSContainerInstanceResponse"/></returns>
        public UpdateEKSContainerInstanceResponse UpdateEKSContainerInstanceSync(UpdateEKSContainerInstanceRequest req)
        {
            return InternalRequestAsync<UpdateEKSContainerInstanceResponse>(req, "UpdateEKSContainerInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级边缘集群组件到指定版本，此版本为TKEEdge专用版本。
        /// </summary>
        /// <param name="req"><see cref="UpdateEdgeClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateEdgeClusterVersionResponse"/></returns>
        public Task<UpdateEdgeClusterVersionResponse> UpdateEdgeClusterVersion(UpdateEdgeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateEdgeClusterVersionResponse>(req, "UpdateEdgeClusterVersion");
        }

        /// <summary>
        /// 升级边缘集群组件到指定版本，此版本为TKEEdge专用版本。
        /// </summary>
        /// <param name="req"><see cref="UpdateEdgeClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateEdgeClusterVersionResponse"/></returns>
        public UpdateEdgeClusterVersionResponse UpdateEdgeClusterVersionSync(UpdateEdgeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateEdgeClusterVersionResponse>(req, "UpdateEdgeClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新镜像缓存接口
        /// </summary>
        /// <param name="req"><see cref="UpdateImageCacheRequest"/></param>
        /// <returns><see cref="UpdateImageCacheResponse"/></returns>
        public Task<UpdateImageCacheResponse> UpdateImageCache(UpdateImageCacheRequest req)
        {
            return InternalRequestAsync<UpdateImageCacheResponse>(req, "UpdateImageCache");
        }

        /// <summary>
        /// 更新镜像缓存接口
        /// </summary>
        /// <param name="req"><see cref="UpdateImageCacheRequest"/></param>
        /// <returns><see cref="UpdateImageCacheResponse"/></returns>
        public UpdateImageCacheResponse UpdateImageCacheSync(UpdateImageCacheRequest req)
        {
            return InternalRequestAsync<UpdateImageCacheResponse>(req, "UpdateImageCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边缘计算集群名称等属性
        /// </summary>
        /// <param name="req"><see cref="UpdateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="UpdateTKEEdgeClusterResponse"/></returns>
        public Task<UpdateTKEEdgeClusterResponse> UpdateTKEEdgeCluster(UpdateTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<UpdateTKEEdgeClusterResponse>(req, "UpdateTKEEdgeCluster");
        }

        /// <summary>
        /// 修改边缘计算集群名称等属性
        /// </summary>
        /// <param name="req"><see cref="UpdateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="UpdateTKEEdgeClusterResponse"/></returns>
        public UpdateTKEEdgeClusterResponse UpdateTKEEdgeClusterSync(UpdateTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<UpdateTKEEdgeClusterResponse>(req, "UpdateTKEEdgeCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 给集群的一批work节点进行升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public Task<UpgradeClusterInstancesResponse> UpgradeClusterInstances(UpgradeClusterInstancesRequest req)
        {
            return InternalRequestAsync<UpgradeClusterInstancesResponse>(req, "UpgradeClusterInstances");
        }

        /// <summary>
        /// 给集群的一批work节点进行升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public UpgradeClusterInstancesResponse UpgradeClusterInstancesSync(UpgradeClusterInstancesRequest req)
        {
            return InternalRequestAsync<UpgradeClusterInstancesResponse>(req, "UpgradeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级集群中已安装的应用
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterReleaseRequest"/></param>
        /// <returns><see cref="UpgradeClusterReleaseResponse"/></returns>
        public Task<UpgradeClusterReleaseResponse> UpgradeClusterRelease(UpgradeClusterReleaseRequest req)
        {
            return InternalRequestAsync<UpgradeClusterReleaseResponse>(req, "UpgradeClusterRelease");
        }

        /// <summary>
        /// 升级集群中已安装的应用
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterReleaseRequest"/></param>
        /// <returns><see cref="UpgradeClusterReleaseResponse"/></returns>
        public UpgradeClusterReleaseResponse UpgradeClusterReleaseSync(UpgradeClusterReleaseRequest req)
        {
            return InternalRequestAsync<UpgradeClusterReleaseResponse>(req, "UpgradeClusterRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
