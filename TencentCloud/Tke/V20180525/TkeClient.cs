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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 通过此接口，可以获取集群的tke:admin的ClusterRole，即管理员角色，可以用于CAM侧高权限的用户，通过CAM策略给予子账户此接口权限，进而可以通过此接口直接获取到kubernetes集群内的管理员角色。
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public async Task<AcquireClusterAdminRoleResponse> AcquireClusterAdminRole(AcquireClusterAdminRoleRequest req)
        {
             JsonResponseModel<AcquireClusterAdminRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcquireClusterAdminRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcquireClusterAdminRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，可以获取集群的tke:admin的ClusterRole，即管理员角色，可以用于CAM侧高权限的用户，通过CAM策略给予子账户此接口权限，进而可以通过此接口直接获取到kubernetes集群内的管理员角色。
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public AcquireClusterAdminRoleResponse AcquireClusterAdminRoleSync(AcquireClusterAdminRoleRequest req)
        {
             JsonResponseModel<AcquireClusterAdminRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcquireClusterAdminRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcquireClusterAdminRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给GR集群增加可用的ClusterCIDR
        /// </summary>
        /// <param name="req"><see cref="AddClusterCIDRRequest"/></param>
        /// <returns><see cref="AddClusterCIDRResponse"/></returns>
        public async Task<AddClusterCIDRResponse> AddClusterCIDR(AddClusterCIDRRequest req)
        {
             JsonResponseModel<AddClusterCIDRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddClusterCIDR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddClusterCIDRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给GR集群增加可用的ClusterCIDR
        /// </summary>
        /// <param name="req"><see cref="AddClusterCIDRRequest"/></param>
        /// <returns><see cref="AddClusterCIDRResponse"/></returns>
        public AddClusterCIDRResponse AddClusterCIDRSync(AddClusterCIDRRequest req)
        {
             JsonResponseModel<AddClusterCIDRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddClusterCIDR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddClusterCIDRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加已经存在的实例到集群
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public async Task<AddExistedInstancesResponse> AddExistedInstances(AddExistedInstancesRequest req)
        {
             JsonResponseModel<AddExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加已经存在的实例到集群
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public AddExistedInstancesResponse AddExistedInstancesSync(AddExistedInstancesRequest req)
        {
             JsonResponseModel<AddExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将集群内节点移入节点池
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public async Task<AddNodeToNodePoolResponse> AddNodeToNodePool(AddNodeToNodePoolRequest req)
        {
             JsonResponseModel<AddNodeToNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNodeToNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodeToNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将集群内节点移入节点池
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public AddNodeToNodePoolResponse AddNodeToNodePoolSync(AddNodeToNodePoolRequest req)
        {
             JsonResponseModel<AddNodeToNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNodeToNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodeToNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对VPC-CNI模式的集群，增加集群容器网络可使用的子网
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public async Task<AddVpcCniSubnetsResponse> AddVpcCniSubnets(AddVpcCniSubnetsRequest req)
        {
             JsonResponseModel<AddVpcCniSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddVpcCniSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddVpcCniSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对VPC-CNI模式的集群，增加集群容器网络可使用的子网
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public AddVpcCniSubnetsResponse AddVpcCniSubnetsSync(AddVpcCniSubnetsRequest req)
        {
             JsonResponseModel<AddVpcCniSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddVpcCniSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddVpcCniSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中取消安装失败的应用
        /// </summary>
        /// <param name="req"><see cref="CancelClusterReleaseRequest"/></param>
        /// <returns><see cref="CancelClusterReleaseResponse"/></returns>
        public async Task<CancelClusterReleaseResponse> CancelClusterRelease(CancelClusterReleaseRequest req)
        {
             JsonResponseModel<CancelClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中取消安装失败的应用
        /// </summary>
        /// <param name="req"><see cref="CancelClusterReleaseRequest"/></param>
        /// <returns><see cref="CancelClusterReleaseResponse"/></returns>
        public CancelClusterReleaseResponse CancelClusterReleaseSync(CancelClusterReleaseRequest req)
        {
             JsonResponseModel<CancelClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查边缘计算集群的CIDR是否冲突
        /// </summary>
        /// <param name="req"><see cref="CheckEdgeClusterCIDRRequest"/></param>
        /// <returns><see cref="CheckEdgeClusterCIDRResponse"/></returns>
        public async Task<CheckEdgeClusterCIDRResponse> CheckEdgeClusterCIDR(CheckEdgeClusterCIDRRequest req)
        {
             JsonResponseModel<CheckEdgeClusterCIDRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckEdgeClusterCIDR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckEdgeClusterCIDRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查边缘计算集群的CIDR是否冲突
        /// </summary>
        /// <param name="req"><see cref="CheckEdgeClusterCIDRRequest"/></param>
        /// <returns><see cref="CheckEdgeClusterCIDRResponse"/></returns>
        public CheckEdgeClusterCIDRResponse CheckEdgeClusterCIDRSync(CheckEdgeClusterCIDRRequest req)
        {
             JsonResponseModel<CheckEdgeClusterCIDRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckEdgeClusterCIDR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckEdgeClusterCIDRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查给定节点列表中哪些是可升级的
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public async Task<CheckInstancesUpgradeAbleResponse> CheckInstancesUpgradeAble(CheckInstancesUpgradeAbleRequest req)
        {
             JsonResponseModel<CheckInstancesUpgradeAbleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckInstancesUpgradeAble");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstancesUpgradeAbleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查给定节点列表中哪些是可升级的
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public CheckInstancesUpgradeAbleResponse CheckInstancesUpgradeAbleSync(CheckInstancesUpgradeAbleRequest req)
        {
             JsonResponseModel<CheckInstancesUpgradeAbleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckInstancesUpgradeAble");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstancesUpgradeAbleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建备份仓库，指定了存储仓库类型（如COS）、COS桶地区、名称等信息，当前最多允许创建100个仓库， 注意此接口当前是全局接口，多个地域的TKE集群如果要备份到相同的备份仓库中，不需要重复创建备份仓库
        /// </summary>
        /// <param name="req"><see cref="CreateBackupStorageLocationRequest"/></param>
        /// <returns><see cref="CreateBackupStorageLocationResponse"/></returns>
        public async Task<CreateBackupStorageLocationResponse> CreateBackupStorageLocation(CreateBackupStorageLocationRequest req)
        {
             JsonResponseModel<CreateBackupStorageLocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackupStorageLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupStorageLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建备份仓库，指定了存储仓库类型（如COS）、COS桶地区、名称等信息，当前最多允许创建100个仓库， 注意此接口当前是全局接口，多个地域的TKE集群如果要备份到相同的备份仓库中，不需要重复创建备份仓库
        /// </summary>
        /// <param name="req"><see cref="CreateBackupStorageLocationRequest"/></param>
        /// <returns><see cref="CreateBackupStorageLocationResponse"/></returns>
        public CreateBackupStorageLocationResponse CreateBackupStorageLocationSync(CreateBackupStorageLocationRequest req)
        {
             JsonResponseModel<CreateBackupStorageLocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackupStorageLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupStorageLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群
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
        /// 创建集群
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
        /// 创建集群访问端口
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public async Task<CreateClusterEndpointResponse> CreateClusterEndpoint(CreateClusterEndpointRequest req)
        {
             JsonResponseModel<CreateClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群访问端口
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public CreateClusterEndpointResponse CreateClusterEndpointSync(CreateClusterEndpointRequest req)
        {
             JsonResponseModel<CreateClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建托管集群外网访问端口（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public async Task<CreateClusterEndpointVipResponse> CreateClusterEndpointVip(CreateClusterEndpointVipRequest req)
        {
             JsonResponseModel<CreateClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建托管集群外网访问端口（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public CreateClusterEndpointVipResponse CreateClusterEndpointVipSync(CreateClusterEndpointVipRequest req)
        {
             JsonResponseModel<CreateClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩展(新建)集群节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public async Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩展(新建)集群节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public CreateClusterInstancesResponse CreateClusterInstancesSync(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public async Task<CreateClusterNodePoolResponse> CreateClusterNodePool(CreateClusterNodePoolRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public CreateClusterNodePoolResponse CreateClusterNodePoolSync(CreateClusterNodePoolRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateClusterReleaseRequest"/></param>
        /// <returns><see cref="CreateClusterReleaseResponse"/></returns>
        public async Task<CreateClusterReleaseResponse> CreateClusterRelease(CreateClusterReleaseRequest req)
        {
             JsonResponseModel<CreateClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateClusterReleaseRequest"/></param>
        /// <returns><see cref="CreateClusterReleaseResponse"/></returns>
        public CreateClusterReleaseResponse CreateClusterReleaseSync(CreateClusterReleaseRequest req)
        {
             JsonResponseModel<CreateClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群路由
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteRequest"/></param>
        /// <returns><see cref="CreateClusterRouteResponse"/></returns>
        public async Task<CreateClusterRouteResponse> CreateClusterRoute(CreateClusterRouteRequest req)
        {
             JsonResponseModel<CreateClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群路由
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteRequest"/></param>
        /// <returns><see cref="CreateClusterRouteResponse"/></returns>
        public CreateClusterRouteResponse CreateClusterRouteSync(CreateClusterRouteRequest req)
        {
             JsonResponseModel<CreateClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群路由表
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public async Task<CreateClusterRouteTableResponse> CreateClusterRouteTable(CreateClusterRouteTableRequest req)
        {
             JsonResponseModel<CreateClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群路由表
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public CreateClusterRouteTableResponse CreateClusterRouteTableSync(CreateClusterRouteTableRequest req)
        {
             JsonResponseModel<CreateClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建虚拟节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodeResponse"/></returns>
        public async Task<CreateClusterVirtualNodeResponse> CreateClusterVirtualNode(CreateClusterVirtualNodeRequest req)
        {
             JsonResponseModel<CreateClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建虚拟节点
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodeResponse"/></returns>
        public CreateClusterVirtualNodeResponse CreateClusterVirtualNodeSync(CreateClusterVirtualNodeRequest req)
        {
             JsonResponseModel<CreateClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建虚拟节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodePoolResponse"/></returns>
        public async Task<CreateClusterVirtualNodePoolResponse> CreateClusterVirtualNodePool(CreateClusterVirtualNodePoolRequest req)
        {
             JsonResponseModel<CreateClusterVirtualNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterVirtualNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterVirtualNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建虚拟节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodePoolResponse"/></returns>
        public CreateClusterVirtualNodePoolResponse CreateClusterVirtualNodePoolSync(CreateClusterVirtualNodePoolRequest req)
        {
             JsonResponseModel<CreateClusterVirtualNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterVirtualNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterVirtualNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘计算ECM机器
        /// </summary>
        /// <param name="req"><see cref="CreateECMInstancesRequest"/></param>
        /// <returns><see cref="CreateECMInstancesResponse"/></returns>
        public async Task<CreateECMInstancesResponse> CreateECMInstances(CreateECMInstancesRequest req)
        {
             JsonResponseModel<CreateECMInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateECMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateECMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘计算ECM机器
        /// </summary>
        /// <param name="req"><see cref="CreateECMInstancesRequest"/></param>
        /// <returns><see cref="CreateECMInstancesResponse"/></returns>
        public CreateECMInstancesResponse CreateECMInstancesSync(CreateECMInstancesRequest req)
        {
             JsonResponseModel<CreateECMInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateECMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateECMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建弹性集群
        /// </summary>
        /// <param name="req"><see cref="CreateEKSClusterRequest"/></param>
        /// <returns><see cref="CreateEKSClusterResponse"/></returns>
        public async Task<CreateEKSClusterResponse> CreateEKSCluster(CreateEKSClusterRequest req)
        {
             JsonResponseModel<CreateEKSClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEKSCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEKSClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建弹性集群
        /// </summary>
        /// <param name="req"><see cref="CreateEKSClusterRequest"/></param>
        /// <returns><see cref="CreateEKSClusterResponse"/></returns>
        public CreateEKSClusterResponse CreateEKSClusterSync(CreateEKSClusterRequest req)
        {
             JsonResponseModel<CreateEKSClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEKSCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEKSClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建容器实例
        /// </summary>
        /// <param name="req"><see cref="CreateEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="CreateEKSContainerInstancesResponse"/></returns>
        public async Task<CreateEKSContainerInstancesResponse> CreateEKSContainerInstances(CreateEKSContainerInstancesRequest req)
        {
             JsonResponseModel<CreateEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建容器实例
        /// </summary>
        /// <param name="req"><see cref="CreateEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="CreateEKSContainerInstancesResponse"/></returns>
        public CreateEKSContainerInstancesResponse CreateEKSContainerInstancesSync(CreateEKSContainerInstancesRequest req)
        {
             JsonResponseModel<CreateEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘容器CVM机器
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="CreateEdgeCVMInstancesResponse"/></returns>
        public async Task<CreateEdgeCVMInstancesResponse> CreateEdgeCVMInstances(CreateEdgeCVMInstancesRequest req)
        {
             JsonResponseModel<CreateEdgeCVMInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeCVMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeCVMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘容器CVM机器
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="CreateEdgeCVMInstancesResponse"/></returns>
        public CreateEdgeCVMInstancesResponse CreateEdgeCVMInstancesSync(CreateEdgeCVMInstancesRequest req)
        {
             JsonResponseModel<CreateEdgeCVMInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeCVMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeCVMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘集群日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeLogConfigRequest"/></param>
        /// <returns><see cref="CreateEdgeLogConfigResponse"/></returns>
        public async Task<CreateEdgeLogConfigResponse> CreateEdgeLogConfig(CreateEdgeLogConfigRequest req)
        {
             JsonResponseModel<CreateEdgeLogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘集群日志采集配置
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeLogConfigRequest"/></param>
        /// <returns><see cref="CreateEdgeLogConfigResponse"/></returns>
        public CreateEdgeLogConfigResponse CreateEdgeLogConfigSync(CreateEdgeLogConfigRequest req)
        {
             JsonResponseModel<CreateEdgeLogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像缓存的接口。创建过程中，请勿删除EKSCI实例和云盘，否则镜像缓存将创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateImageCacheRequest"/></param>
        /// <returns><see cref="CreateImageCacheResponse"/></returns>
        public async Task<CreateImageCacheResponse> CreateImageCache(CreateImageCacheRequest req)
        {
             JsonResponseModel<CreateImageCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像缓存的接口。创建过程中，请勿删除EKSCI实例和云盘，否则镜像缓存将创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateImageCacheRequest"/></param>
        /// <returns><see cref="CreateImageCacheResponse"/></returns>
        public CreateImageCacheResponse CreateImageCacheSync(CreateImageCacheRequest req)
        {
             JsonResponseModel<CreateImageCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public async Task<CreatePrometheusAlertPolicyResponse> CreatePrometheusAlertPolicy(CreatePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<CreatePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public CreatePrometheusAlertPolicyResponse CreatePrometheusAlertPolicySync(CreatePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<CreatePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建告警规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertRuleResponse"/></returns>
        public async Task<CreatePrometheusAlertRuleResponse> CreatePrometheusAlertRule(CreatePrometheusAlertRuleRequest req)
        {
             JsonResponseModel<CreatePrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建告警规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertRuleResponse"/></returns>
        public CreatePrometheusAlertRuleResponse CreatePrometheusAlertRuleSync(CreatePrometheusAlertRuleRequest req)
        {
             JsonResponseModel<CreatePrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 与云监控融合的2.0实例关联集群
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public async Task<CreatePrometheusClusterAgentResponse> CreatePrometheusClusterAgent(CreatePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<CreatePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 与云监控融合的2.0实例关联集群
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public CreatePrometheusClusterAgentResponse CreatePrometheusClusterAgentSync(CreatePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<CreatePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建prometheus配置
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public async Task<CreatePrometheusConfigResponse> CreatePrometheusConfig(CreatePrometheusConfigRequest req)
        {
             JsonResponseModel<CreatePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建prometheus配置
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public CreatePrometheusConfigResponse CreatePrometheusConfigSync(CreatePrometheusConfigRequest req)
        {
             JsonResponseModel<CreatePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建grafana监控面板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusDashboardRequest"/></param>
        /// <returns><see cref="CreatePrometheusDashboardResponse"/></returns>
        public async Task<CreatePrometheusDashboardResponse> CreatePrometheusDashboard(CreatePrometheusDashboardRequest req)
        {
             JsonResponseModel<CreatePrometheusDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建grafana监控面板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusDashboardRequest"/></param>
        /// <returns><see cref="CreatePrometheusDashboardResponse"/></returns>
        public CreatePrometheusDashboardResponse CreatePrometheusDashboardSync(CreatePrometheusDashboardRequest req)
        {
             JsonResponseModel<CreatePrometheusDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public async Task<CreatePrometheusGlobalNotificationResponse> CreatePrometheusGlobalNotification(CreatePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<CreatePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public CreatePrometheusGlobalNotificationResponse CreatePrometheusGlobalNotificationSync(CreatePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<CreatePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 以Yaml的方式创建聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public async Task<CreatePrometheusRecordRuleYamlResponse> CreatePrometheusRecordRuleYaml(CreatePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<CreatePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 以Yaml的方式创建聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public CreatePrometheusRecordRuleYamlResponse CreatePrometheusRecordRuleYamlSync(CreatePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<CreatePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public async Task<CreatePrometheusTempResponse> CreatePrometheusTemp(CreatePrometheusTempRequest req)
        {
             JsonResponseModel<CreatePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public CreatePrometheusTempResponse CreatePrometheusTempSync(CreatePrometheusTempRequest req)
        {
             JsonResponseModel<CreatePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板实例
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTemplateRequest"/></param>
        /// <returns><see cref="CreatePrometheusTemplateResponse"/></returns>
        public async Task<CreatePrometheusTemplateResponse> CreatePrometheusTemplate(CreatePrometheusTemplateRequest req)
        {
             JsonResponseModel<CreatePrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板实例
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTemplateRequest"/></param>
        /// <returns><see cref="CreatePrometheusTemplateResponse"/></returns>
        public CreatePrometheusTemplateResponse CreatePrometheusTemplateSync(CreatePrometheusTemplateRequest req)
        {
             JsonResponseModel<CreatePrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="CreateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="CreateTKEEdgeClusterResponse"/></returns>
        public async Task<CreateTKEEdgeClusterResponse> CreateTKEEdgeCluster(CreateTKEEdgeClusterRequest req)
        {
             JsonResponseModel<CreateTKEEdgeClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTKEEdgeCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTKEEdgeClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="CreateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="CreateTKEEdgeClusterResponse"/></returns>
        public CreateTKEEdgeClusterResponse CreateTKEEdgeClusterSync(CreateTKEEdgeClusterRequest req)
        {
             JsonResponseModel<CreateTKEEdgeClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTKEEdgeCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTKEEdgeClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个addon
        /// </summary>
        /// <param name="req"><see cref="DeleteAddonRequest"/></param>
        /// <returns><see cref="DeleteAddonResponse"/></returns>
        public async Task<DeleteAddonResponse> DeleteAddon(DeleteAddonRequest req)
        {
             JsonResponseModel<DeleteAddonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个addon
        /// </summary>
        /// <param name="req"><see cref="DeleteAddonRequest"/></param>
        /// <returns><see cref="DeleteAddonResponse"/></returns>
        public DeleteAddonResponse DeleteAddonSync(DeleteAddonRequest req)
        {
             JsonResponseModel<DeleteAddonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除备份仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupStorageLocationRequest"/></param>
        /// <returns><see cref="DeleteBackupStorageLocationResponse"/></returns>
        public async Task<DeleteBackupStorageLocationResponse> DeleteBackupStorageLocation(DeleteBackupStorageLocationRequest req)
        {
             JsonResponseModel<DeleteBackupStorageLocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBackupStorageLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBackupStorageLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除备份仓库
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupStorageLocationRequest"/></param>
        /// <returns><see cref="DeleteBackupStorageLocationResponse"/></returns>
        public DeleteBackupStorageLocationResponse DeleteBackupStorageLocationSync(DeleteBackupStorageLocationRequest req)
        {
             JsonResponseModel<DeleteBackupStorageLocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBackupStorageLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBackupStorageLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群(YUNAPI V3版本)
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
        /// 删除集群(YUNAPI V3版本)
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
        /// 删除集群伸缩组
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public async Task<DeleteClusterAsGroupsResponse> DeleteClusterAsGroups(DeleteClusterAsGroupsRequest req)
        {
             JsonResponseModel<DeleteClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群伸缩组
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public DeleteClusterAsGroupsResponse DeleteClusterAsGroupsSync(DeleteClusterAsGroupsRequest req)
        {
             JsonResponseModel<DeleteClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群访问端口
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public async Task<DeleteClusterEndpointResponse> DeleteClusterEndpoint(DeleteClusterEndpointRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群访问端口
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public DeleteClusterEndpointResponse DeleteClusterEndpointSync(DeleteClusterEndpointRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除托管集群外网访问端口（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public async Task<DeleteClusterEndpointVipResponse> DeleteClusterEndpointVip(DeleteClusterEndpointVipRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除托管集群外网访问端口（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public DeleteClusterEndpointVipResponse DeleteClusterEndpointVipSync(DeleteClusterEndpointVipRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群中的实例
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public async Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群中的实例
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public DeleteClusterInstancesResponse DeleteClusterInstancesSync(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public async Task<DeleteClusterNodePoolResponse> DeleteClusterNodePool(DeleteClusterNodePoolRequest req)
        {
             JsonResponseModel<DeleteClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public DeleteClusterNodePoolResponse DeleteClusterNodePoolSync(DeleteClusterNodePoolRequest req)
        {
             JsonResponseModel<DeleteClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群路由
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public async Task<DeleteClusterRouteResponse> DeleteClusterRoute(DeleteClusterRouteRequest req)
        {
             JsonResponseModel<DeleteClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群路由
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public DeleteClusterRouteResponse DeleteClusterRouteSync(DeleteClusterRouteRequest req)
        {
             JsonResponseModel<DeleteClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public async Task<DeleteClusterRouteTableResponse> DeleteClusterRouteTable(DeleteClusterRouteTableRequest req)
        {
             JsonResponseModel<DeleteClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public DeleteClusterRouteTableResponse DeleteClusterRouteTableSync(DeleteClusterRouteTableRequest req)
        {
             JsonResponseModel<DeleteClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除虚拟节点
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodeResponse"/></returns>
        public async Task<DeleteClusterVirtualNodeResponse> DeleteClusterVirtualNode(DeleteClusterVirtualNodeRequest req)
        {
             JsonResponseModel<DeleteClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除虚拟节点
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodeResponse"/></returns>
        public DeleteClusterVirtualNodeResponse DeleteClusterVirtualNodeSync(DeleteClusterVirtualNodeRequest req)
        {
             JsonResponseModel<DeleteClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除虚拟节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodePoolResponse"/></returns>
        public async Task<DeleteClusterVirtualNodePoolResponse> DeleteClusterVirtualNodePool(DeleteClusterVirtualNodePoolRequest req)
        {
             JsonResponseModel<DeleteClusterVirtualNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterVirtualNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterVirtualNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除虚拟节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodePoolResponse"/></returns>
        public DeleteClusterVirtualNodePoolResponse DeleteClusterVirtualNodePoolSync(DeleteClusterVirtualNodePoolRequest req)
        {
             JsonResponseModel<DeleteClusterVirtualNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterVirtualNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterVirtualNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ECM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteECMInstancesRequest"/></param>
        /// <returns><see cref="DeleteECMInstancesResponse"/></returns>
        public async Task<DeleteECMInstancesResponse> DeleteECMInstances(DeleteECMInstancesRequest req)
        {
             JsonResponseModel<DeleteECMInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteECMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteECMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ECM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteECMInstancesRequest"/></param>
        /// <returns><see cref="DeleteECMInstancesResponse"/></returns>
        public DeleteECMInstancesResponse DeleteECMInstancesSync(DeleteECMInstancesRequest req)
        {
             JsonResponseModel<DeleteECMInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteECMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteECMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除弹性集群(yunapiv3)
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSClusterRequest"/></param>
        /// <returns><see cref="DeleteEKSClusterResponse"/></returns>
        public async Task<DeleteEKSClusterResponse> DeleteEKSCluster(DeleteEKSClusterRequest req)
        {
             JsonResponseModel<DeleteEKSClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEKSCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEKSClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除弹性集群(yunapiv3)
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSClusterRequest"/></param>
        /// <returns><see cref="DeleteEKSClusterResponse"/></returns>
        public DeleteEKSClusterResponse DeleteEKSClusterSync(DeleteEKSClusterRequest req)
        {
             JsonResponseModel<DeleteEKSClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEKSCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEKSClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器实例，可批量删除
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DeleteEKSContainerInstancesResponse"/></returns>
        public async Task<DeleteEKSContainerInstancesResponse> DeleteEKSContainerInstances(DeleteEKSContainerInstancesRequest req)
        {
             JsonResponseModel<DeleteEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除容器实例，可批量删除
        /// </summary>
        /// <param name="req"><see cref="DeleteEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DeleteEKSContainerInstancesResponse"/></returns>
        public DeleteEKSContainerInstancesResponse DeleteEKSContainerInstancesSync(DeleteEKSContainerInstancesRequest req)
        {
             JsonResponseModel<DeleteEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘容器CVM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeCVMInstancesResponse"/></returns>
        public async Task<DeleteEdgeCVMInstancesResponse> DeleteEdgeCVMInstances(DeleteEdgeCVMInstancesRequest req)
        {
             JsonResponseModel<DeleteEdgeCVMInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeCVMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeCVMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘容器CVM实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeCVMInstancesResponse"/></returns>
        public DeleteEdgeCVMInstancesResponse DeleteEdgeCVMInstancesSync(DeleteEdgeCVMInstancesRequest req)
        {
             JsonResponseModel<DeleteEdgeCVMInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeCVMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeCVMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘计算实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeClusterInstancesResponse"/></returns>
        public async Task<DeleteEdgeClusterInstancesResponse> DeleteEdgeClusterInstances(DeleteEdgeClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteEdgeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘计算实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeClusterInstancesResponse"/></returns>
        public DeleteEdgeClusterInstancesResponse DeleteEdgeClusterInstancesSync(DeleteEdgeClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteEdgeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除镜像缓存
        /// </summary>
        /// <param name="req"><see cref="DeleteImageCachesRequest"/></param>
        /// <returns><see cref="DeleteImageCachesResponse"/></returns>
        public async Task<DeleteImageCachesResponse> DeleteImageCaches(DeleteImageCachesRequest req)
        {
             JsonResponseModel<DeleteImageCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除镜像缓存
        /// </summary>
        /// <param name="req"><see cref="DeleteImageCachesRequest"/></param>
        /// <returns><see cref="DeleteImageCachesResponse"/></returns>
        public DeleteImageCachesResponse DeleteImageCachesSync(DeleteImageCachesRequest req)
        {
             JsonResponseModel<DeleteImageCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public async Task<DeletePrometheusAlertPolicyResponse> DeletePrometheusAlertPolicy(DeletePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DeletePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public DeletePrometheusAlertPolicyResponse DeletePrometheusAlertPolicySync(DeletePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DeletePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertRuleResponse"/></returns>
        public async Task<DeletePrometheusAlertRuleResponse> DeletePrometheusAlertRule(DeletePrometheusAlertRuleRequest req)
        {
             JsonResponseModel<DeletePrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertRuleResponse"/></returns>
        public DeletePrometheusAlertRuleResponse DeletePrometheusAlertRuleSync(DeletePrometheusAlertRuleRequest req)
        {
             JsonResponseModel<DeletePrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除TMP实例的集群关联
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public async Task<DeletePrometheusClusterAgentResponse> DeletePrometheusClusterAgent(DeletePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<DeletePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除TMP实例的集群关联
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public DeletePrometheusClusterAgentResponse DeletePrometheusClusterAgentSync(DeletePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<DeletePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Prometheus配置，如果目标不存在，将返回成功
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public async Task<DeletePrometheusConfigResponse> DeletePrometheusConfig(DeletePrometheusConfigRequest req)
        {
             JsonResponseModel<DeletePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Prometheus配置，如果目标不存在，将返回成功
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public DeletePrometheusConfigResponse DeletePrometheusConfigSync(DeletePrometheusConfigRequest req)
        {
             JsonResponseModel<DeletePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除聚合实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public async Task<DeletePrometheusRecordRuleYamlResponse> DeletePrometheusRecordRuleYaml(DeletePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<DeletePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除聚合实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public DeletePrometheusRecordRuleYamlResponse DeletePrometheusRecordRuleYamlSync(DeletePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<DeletePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public async Task<DeletePrometheusTempResponse> DeletePrometheusTemp(DeletePrometheusTempRequest req)
        {
             JsonResponseModel<DeletePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public DeletePrometheusTempResponse DeletePrometheusTempSync(DeletePrometheusTempRequest req)
        {
             JsonResponseModel<DeletePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除模板同步，这将会删除目标中该模板所生产的配置，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public async Task<DeletePrometheusTempSyncResponse> DeletePrometheusTempSync(DeletePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DeletePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除模板同步，这将会删除目标中该模板所生产的配置，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public DeletePrometheusTempSyncResponse DeletePrometheusTempSyncSync(DeletePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DeletePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateResponse"/></returns>
        public async Task<DeletePrometheusTemplateResponse> DeletePrometheusTemplate(DeletePrometheusTemplateRequest req)
        {
             JsonResponseModel<DeletePrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateResponse"/></returns>
        public DeletePrometheusTemplateResponse DeletePrometheusTemplateSync(DeletePrometheusTemplateRequest req)
        {
             JsonResponseModel<DeletePrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消模板同步，这将会删除目标中该模板所生产的配置
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateSyncResponse"/></returns>
        public async Task<DeletePrometheusTemplateSyncResponse> DeletePrometheusTemplateSync(DeletePrometheusTemplateSyncRequest req)
        {
             JsonResponseModel<DeletePrometheusTemplateSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusTemplateSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTemplateSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消模板同步，这将会删除目标中该模板所生产的配置
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTemplateSyncResponse"/></returns>
        public DeletePrometheusTemplateSyncResponse DeletePrometheusTemplateSyncSync(DeletePrometheusTemplateSyncRequest req)
        {
             JsonResponseModel<DeletePrometheusTemplateSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusTemplateSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTemplateSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="DeleteTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="DeleteTKEEdgeClusterResponse"/></returns>
        public async Task<DeleteTKEEdgeClusterResponse> DeleteTKEEdgeCluster(DeleteTKEEdgeClusterRequest req)
        {
             JsonResponseModel<DeleteTKEEdgeClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTKEEdgeCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTKEEdgeClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘计算集群
        /// </summary>
        /// <param name="req"><see cref="DeleteTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="DeleteTKEEdgeClusterResponse"/></returns>
        public DeleteTKEEdgeClusterResponse DeleteTKEEdgeClusterSync(DeleteTKEEdgeClusterRequest req)
        {
             JsonResponseModel<DeleteTKEEdgeClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTKEEdgeCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTKEEdgeClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取addon列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonRequest"/></param>
        /// <returns><see cref="DescribeAddonResponse"/></returns>
        public async Task<DescribeAddonResponse> DescribeAddon(DescribeAddonRequest req)
        {
             JsonResponseModel<DescribeAddonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取addon列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonRequest"/></param>
        /// <returns><see cref="DescribeAddonResponse"/></returns>
        public DescribeAddonResponse DescribeAddonSync(DescribeAddonRequest req)
        {
             JsonResponseModel<DescribeAddonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一个addon的参数
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonValuesRequest"/></param>
        /// <returns><see cref="DescribeAddonValuesResponse"/></returns>
        public async Task<DescribeAddonValuesResponse> DescribeAddonValues(DescribeAddonValuesRequest req)
        {
             JsonResponseModel<DescribeAddonValuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddonValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddonValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一个addon的参数
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonValuesRequest"/></param>
        /// <returns><see cref="DescribeAddonValuesResponse"/></returns>
        public DescribeAddonValuesResponse DescribeAddonValuesSync(DescribeAddonValuesRequest req)
        {
             JsonResponseModel<DescribeAddonValuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddonValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddonValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群可以升级的所有版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public async Task<DescribeAvailableClusterVersionResponse> DescribeAvailableClusterVersion(DescribeAvailableClusterVersionRequest req)
        {
             JsonResponseModel<DescribeAvailableClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群可以升级的所有版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public DescribeAvailableClusterVersionResponse DescribeAvailableClusterVersionSync(DescribeAvailableClusterVersionRequest req)
        {
             JsonResponseModel<DescribeAvailableClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 边缘计算支持版本和k8s版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableTKEEdgeVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableTKEEdgeVersionResponse"/></returns>
        public async Task<DescribeAvailableTKEEdgeVersionResponse> DescribeAvailableTKEEdgeVersion(DescribeAvailableTKEEdgeVersionRequest req)
        {
             JsonResponseModel<DescribeAvailableTKEEdgeVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableTKEEdgeVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableTKEEdgeVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 边缘计算支持版本和k8s版本
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableTKEEdgeVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableTKEEdgeVersionResponse"/></returns>
        public DescribeAvailableTKEEdgeVersionResponse DescribeAvailableTKEEdgeVersionSync(DescribeAvailableTKEEdgeVersionRequest req)
        {
             JsonResponseModel<DescribeAvailableTKEEdgeVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableTKEEdgeVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableTKEEdgeVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStorageLocationsRequest"/></param>
        /// <returns><see cref="DescribeBackupStorageLocationsResponse"/></returns>
        public async Task<DescribeBackupStorageLocationsResponse> DescribeBackupStorageLocations(DescribeBackupStorageLocationsRequest req)
        {
             JsonResponseModel<DescribeBackupStorageLocationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupStorageLocations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupStorageLocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份仓库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStorageLocationsRequest"/></param>
        /// <returns><see cref="DescribeBackupStorageLocationsResponse"/></returns>
        public DescribeBackupStorageLocationsResponse DescribeBackupStorageLocationsSync(DescribeBackupStorageLocationsRequest req)
        {
             JsonResponseModel<DescribeBackupStorageLocationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupStorageLocations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupStorageLocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群弹性伸缩配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public async Task<DescribeClusterAsGroupOptionResponse> DescribeClusterAsGroupOption(DescribeClusterAsGroupOptionRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupOptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterAsGroupOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群弹性伸缩配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public DescribeClusterAsGroupOptionResponse DescribeClusterAsGroupOptionSync(DescribeClusterAsGroupOptionRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupOptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterAsGroupOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群关联的伸缩组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public async Task<DescribeClusterAsGroupsResponse> DescribeClusterAsGroups(DescribeClusterAsGroupsRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群关联的伸缩组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public DescribeClusterAsGroupsResponse DescribeClusterAsGroupsSync(DescribeClusterAsGroupsRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看集群认证配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="DescribeClusterAuthenticationOptionsResponse"/></returns>
        public async Task<DescribeClusterAuthenticationOptionsResponse> DescribeClusterAuthenticationOptions(DescribeClusterAuthenticationOptionsRequest req)
        {
             JsonResponseModel<DescribeClusterAuthenticationOptionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterAuthenticationOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAuthenticationOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看集群认证配置
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="DescribeClusterAuthenticationOptionsResponse"/></returns>
        public DescribeClusterAuthenticationOptionsResponse DescribeClusterAuthenticationOptionsSync(DescribeClusterAuthenticationOptionsRequest req)
        {
             JsonResponseModel<DescribeClusterAuthenticationOptionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterAuthenticationOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAuthenticationOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定子账户在RBAC授权模式中对应kube-apiserver客户端证书的CommonName字段，如果没有客户端证书，将会签发一个，此接口有最大传入子账户数量上限，当前为50
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public async Task<DescribeClusterCommonNamesResponse> DescribeClusterCommonNames(DescribeClusterCommonNamesRequest req)
        {
             JsonResponseModel<DescribeClusterCommonNamesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterCommonNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterCommonNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定子账户在RBAC授权模式中对应kube-apiserver客户端证书的CommonName字段，如果没有客户端证书，将会签发一个，此接口有最大传入子账户数量上限，当前为50
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public DescribeClusterCommonNamesResponse DescribeClusterCommonNamesSync(DescribeClusterCommonNamesRequest req)
        {
             JsonResponseModel<DescribeClusterCommonNamesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterCommonNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterCommonNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询Kubernetes的各个原生控制器是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterControllersRequest"/></param>
        /// <returns><see cref="DescribeClusterControllersResponse"/></returns>
        public async Task<DescribeClusterControllersResponse> DescribeClusterControllers(DescribeClusterControllersRequest req)
        {
             JsonResponseModel<DescribeClusterControllersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterControllers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterControllersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询Kubernetes的各个原生控制器是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterControllersRequest"/></param>
        /// <returns><see cref="DescribeClusterControllersResponse"/></returns>
        public DescribeClusterControllersResponse DescribeClusterControllersSync(DescribeClusterControllersRequest req)
        {
             JsonResponseModel<DescribeClusterControllersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterControllers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterControllersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群访问端口状态(独立集群开启内网/外网访问，托管集群支持开启内网访问)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public async Task<DescribeClusterEndpointStatusResponse> DescribeClusterEndpointStatus(DescribeClusterEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群访问端口状态(独立集群开启内网/外网访问，托管集群支持开启内网访问)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public DescribeClusterEndpointStatusResponse DescribeClusterEndpointStatusSync(DescribeClusterEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群开启端口流程状态(仅支持托管集群外网端口)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public async Task<DescribeClusterEndpointVipStatusResponse> DescribeClusterEndpointVipStatus(DescribeClusterEndpointVipStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointVipStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpointVipStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointVipStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群开启端口流程状态(仅支持托管集群外网端口)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public DescribeClusterEndpointVipStatusResponse DescribeClusterEndpointVipStatusSync(DescribeClusterEndpointVipStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointVipStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpointVipStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointVipStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群的访问地址，包括内网地址，外网地址，外网域名，外网访问安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public async Task<DescribeClusterEndpointsResponse> DescribeClusterEndpoints(DescribeClusterEndpointsRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群的访问地址，包括内网地址，外网地址，外网域名，外网访问安全策略
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public DescribeClusterEndpointsResponse DescribeClusterEndpointsSync(DescribeClusterEndpointsRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户单个Region下的所有集群巡检结果概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInspectionResultsOverviewRequest"/></param>
        /// <returns><see cref="DescribeClusterInspectionResultsOverviewResponse"/></returns>
        public async Task<DescribeClusterInspectionResultsOverviewResponse> DescribeClusterInspectionResultsOverview(DescribeClusterInspectionResultsOverviewRequest req)
        {
             JsonResponseModel<DescribeClusterInspectionResultsOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInspectionResultsOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInspectionResultsOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户单个Region下的所有集群巡检结果概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInspectionResultsOverviewRequest"/></param>
        /// <returns><see cref="DescribeClusterInspectionResultsOverviewResponse"/></returns>
        public DescribeClusterInspectionResultsOverviewResponse DescribeClusterInspectionResultsOverviewSync(DescribeClusterInspectionResultsOverviewRequest req)
        {
             JsonResponseModel<DescribeClusterInspectionResultsOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterInspectionResultsOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInspectionResultsOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public async Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群的kubeconfig文件，不同子账户获取自己的kubeconfig文件，该文件中有每个子账户自己的kube-apiserver的客户端证书，默认首次调此接口时候创建客户端证书，时效20年，未授予任何权限，如果是集群所有者或者主账户，则默认是cluster-admin权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public async Task<DescribeClusterKubeconfigResponse> DescribeClusterKubeconfig(DescribeClusterKubeconfigRequest req)
        {
             JsonResponseModel<DescribeClusterKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群的kubeconfig文件，不同子账户获取自己的kubeconfig文件，该文件中有每个子账户自己的kube-apiserver的客户端证书，默认首次调此接口时候创建客户端证书，时效20年，未授予任何权限，如果是集群所有者或者主账户，则默认是cluster-admin权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public DescribeClusterKubeconfigResponse DescribeClusterKubeconfigSync(DescribeClusterKubeconfigRequest req)
        {
             JsonResponseModel<DescribeClusterKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群规模
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelAttributeRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelAttributeResponse"/></returns>
        public async Task<DescribeClusterLevelAttributeResponse> DescribeClusterLevelAttribute(DescribeClusterLevelAttributeRequest req)
        {
             JsonResponseModel<DescribeClusterLevelAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterLevelAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterLevelAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群规模
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelAttributeRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelAttributeResponse"/></returns>
        public DescribeClusterLevelAttributeResponse DescribeClusterLevelAttributeSync(DescribeClusterLevelAttributeRequest req)
        {
             JsonResponseModel<DescribeClusterLevelAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterLevelAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterLevelAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群变配记录
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelChangeRecordsRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelChangeRecordsResponse"/></returns>
        public async Task<DescribeClusterLevelChangeRecordsResponse> DescribeClusterLevelChangeRecords(DescribeClusterLevelChangeRecordsRequest req)
        {
             JsonResponseModel<DescribeClusterLevelChangeRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterLevelChangeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterLevelChangeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群变配记录
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelChangeRecordsRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelChangeRecordsResponse"/></returns>
        public DescribeClusterLevelChangeRecordsResponse DescribeClusterLevelChangeRecordsSync(DescribeClusterLevelChangeRecordsRequest req)
        {
             JsonResponseModel<DescribeClusterLevelChangeRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterLevelChangeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterLevelChangeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点池详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetail(DescribeClusterNodePoolDetailRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterNodePoolDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点池详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetailSync(DescribeClusterNodePoolDetailRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterNodePoolDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePools(DescribeClusterNodePoolsRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterNodePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public DescribeClusterNodePoolsResponse DescribeClusterNodePoolsSync(DescribeClusterNodePoolsRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterNodePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中查询正在安装中的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPendingReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterPendingReleasesResponse"/></returns>
        public async Task<DescribeClusterPendingReleasesResponse> DescribeClusterPendingReleases(DescribeClusterPendingReleasesRequest req)
        {
             JsonResponseModel<DescribeClusterPendingReleasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterPendingReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterPendingReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中查询正在安装中的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPendingReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterPendingReleasesResponse"/></returns>
        public DescribeClusterPendingReleasesResponse DescribeClusterPendingReleasesSync(DescribeClusterPendingReleasesRequest req)
        {
             JsonResponseModel<DescribeClusterPendingReleasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterPendingReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterPendingReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询通过应用市场安装的某个应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseDetailsRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseDetailsResponse"/></returns>
        public async Task<DescribeClusterReleaseDetailsResponse> DescribeClusterReleaseDetails(DescribeClusterReleaseDetailsRequest req)
        {
             JsonResponseModel<DescribeClusterReleaseDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterReleaseDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterReleaseDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询通过应用市场安装的某个应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseDetailsRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseDetailsResponse"/></returns>
        public DescribeClusterReleaseDetailsResponse DescribeClusterReleaseDetailsSync(DescribeClusterReleaseDetailsRequest req)
        {
             JsonResponseModel<DescribeClusterReleaseDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterReleaseDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterReleaseDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群在应用市场中某个已安装应用的版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseHistoryResponse"/></returns>
        public async Task<DescribeClusterReleaseHistoryResponse> DescribeClusterReleaseHistory(DescribeClusterReleaseHistoryRequest req)
        {
             JsonResponseModel<DescribeClusterReleaseHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterReleaseHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterReleaseHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群在应用市场中某个已安装应用的版本历史
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeClusterReleaseHistoryResponse"/></returns>
        public DescribeClusterReleaseHistoryResponse DescribeClusterReleaseHistorySync(DescribeClusterReleaseHistoryRequest req)
        {
             JsonResponseModel<DescribeClusterReleaseHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterReleaseHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterReleaseHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群在应用市场中已安装应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterReleasesResponse"/></returns>
        public async Task<DescribeClusterReleasesResponse> DescribeClusterReleases(DescribeClusterReleasesRequest req)
        {
             JsonResponseModel<DescribeClusterReleasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群在应用市场中已安装应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterReleasesRequest"/></param>
        /// <returns><see cref="DescribeClusterReleasesResponse"/></returns>
        public DescribeClusterReleasesResponse DescribeClusterReleasesSync(DescribeClusterReleasesRequest req)
        {
             JsonResponseModel<DescribeClusterReleasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterReleases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterReleasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群路由表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public async Task<DescribeClusterRouteTablesResponse> DescribeClusterRouteTables(DescribeClusterRouteTablesRequest req)
        {
             JsonResponseModel<DescribeClusterRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群路由表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public DescribeClusterRouteTablesResponse DescribeClusterRouteTablesSync(DescribeClusterRouteTablesRequest req)
        {
             JsonResponseModel<DescribeClusterRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群路由
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public async Task<DescribeClusterRoutesResponse> DescribeClusterRoutes(DescribeClusterRoutesRequest req)
        {
             JsonResponseModel<DescribeClusterRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群路由
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public DescribeClusterRoutesResponse DescribeClusterRoutesSync(DescribeClusterRoutesRequest req)
        {
             JsonResponseModel<DescribeClusterRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群的密钥信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public async Task<DescribeClusterSecurityResponse> DescribeClusterSecurity(DescribeClusterSecurityRequest req)
        {
             JsonResponseModel<DescribeClusterSecurityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterSecurity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSecurityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群的密钥信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public DescribeClusterSecurityResponse DescribeClusterSecuritySync(DescribeClusterSecurityRequest req)
        {
             JsonResponseModel<DescribeClusterSecurityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterSecurity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSecurityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看集群状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterStatusResponse"/></returns>
        public async Task<DescribeClusterStatusResponse> DescribeClusterStatus(DescribeClusterStatusRequest req)
        {
             JsonResponseModel<DescribeClusterStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看集群状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterStatusResponse"/></returns>
        public DescribeClusterStatusResponse DescribeClusterStatusSync(DescribeClusterStatusRequest req)
        {
             JsonResponseModel<DescribeClusterStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看虚拟节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodeResponse"/></returns>
        public async Task<DescribeClusterVirtualNodeResponse> DescribeClusterVirtualNode(DescribeClusterVirtualNodeRequest req)
        {
             JsonResponseModel<DescribeClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看虚拟节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodeResponse"/></returns>
        public DescribeClusterVirtualNodeResponse DescribeClusterVirtualNodeSync(DescribeClusterVirtualNodeRequest req)
        {
             JsonResponseModel<DescribeClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看虚拟节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodePoolsResponse"/></returns>
        public async Task<DescribeClusterVirtualNodePoolsResponse> DescribeClusterVirtualNodePools(DescribeClusterVirtualNodePoolsRequest req)
        {
             JsonResponseModel<DescribeClusterVirtualNodePoolsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterVirtualNodePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterVirtualNodePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看虚拟节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodePoolsResponse"/></returns>
        public DescribeClusterVirtualNodePoolsResponse DescribeClusterVirtualNodePoolsSync(DescribeClusterVirtualNodePoolsRequest req)
        {
             JsonResponseModel<DescribeClusterVirtualNodePoolsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterVirtualNodePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterVirtualNodePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群列表
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
        /// 查询集群列表
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
        /// 获取ECM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeECMInstancesRequest"/></param>
        /// <returns><see cref="DescribeECMInstancesResponse"/></returns>
        public async Task<DescribeECMInstancesResponse> DescribeECMInstances(DescribeECMInstancesRequest req)
        {
             JsonResponseModel<DescribeECMInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeECMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeECMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ECM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeECMInstancesRequest"/></param>
        /// <returns><see cref="DescribeECMInstancesResponse"/></returns>
        public DescribeECMInstancesResponse DescribeECMInstancesSync(DescribeECMInstancesRequest req)
        {
             JsonResponseModel<DescribeECMInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeECMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeECMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取弹性容器集群的接入认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeEKSClusterCredentialResponse"/></returns>
        public async Task<DescribeEKSClusterCredentialResponse> DescribeEKSClusterCredential(DescribeEKSClusterCredentialRequest req)
        {
             JsonResponseModel<DescribeEKSClusterCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEKSClusterCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSClusterCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取弹性容器集群的接入认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeEKSClusterCredentialResponse"/></returns>
        public DescribeEKSClusterCredentialResponse DescribeEKSClusterCredentialSync(DescribeEKSClusterCredentialRequest req)
        {
             JsonResponseModel<DescribeEKSClusterCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEKSClusterCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSClusterCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClustersRequest"/></param>
        /// <returns><see cref="DescribeEKSClustersResponse"/></returns>
        public async Task<DescribeEKSClustersResponse> DescribeEKSClusters(DescribeEKSClustersRequest req)
        {
             JsonResponseModel<DescribeEKSClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEKSClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSClustersRequest"/></param>
        /// <returns><see cref="DescribeEKSClustersResponse"/></returns>
        public DescribeEKSClustersResponse DescribeEKSClustersSync(DescribeEKSClustersRequest req)
        {
             JsonResponseModel<DescribeEKSClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEKSClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例的事件
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceEventRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceEventResponse"/></returns>
        public async Task<DescribeEKSContainerInstanceEventResponse> DescribeEKSContainerInstanceEvent(DescribeEKSContainerInstanceEventRequest req)
        {
             JsonResponseModel<DescribeEKSContainerInstanceEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEKSContainerInstanceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSContainerInstanceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例的事件
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceEventRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceEventResponse"/></returns>
        public DescribeEKSContainerInstanceEventResponse DescribeEKSContainerInstanceEventSync(DescribeEKSContainerInstanceEventRequest req)
        {
             JsonResponseModel<DescribeEKSContainerInstanceEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEKSContainerInstanceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSContainerInstanceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例支持的地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceRegionsRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceRegionsResponse"/></returns>
        public async Task<DescribeEKSContainerInstanceRegionsResponse> DescribeEKSContainerInstanceRegions(DescribeEKSContainerInstanceRegionsRequest req)
        {
             JsonResponseModel<DescribeEKSContainerInstanceRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEKSContainerInstanceRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSContainerInstanceRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例支持的地域
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstanceRegionsRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstanceRegionsResponse"/></returns>
        public DescribeEKSContainerInstanceRegionsResponse DescribeEKSContainerInstanceRegionsSync(DescribeEKSContainerInstanceRegionsRequest req)
        {
             JsonResponseModel<DescribeEKSContainerInstanceRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEKSContainerInstanceRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSContainerInstanceRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstancesResponse"/></returns>
        public async Task<DescribeEKSContainerInstancesResponse> DescribeEKSContainerInstances(DescribeEKSContainerInstancesRequest req)
        {
             JsonResponseModel<DescribeEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例
        /// </summary>
        /// <param name="req"><see cref="DescribeEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="DescribeEKSContainerInstancesResponse"/></returns>
        public DescribeEKSContainerInstancesResponse DescribeEKSContainerInstancesSync(DescribeEKSContainerInstancesRequest req)
        {
             JsonResponseModel<DescribeEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘容器集群可用的自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAvailableExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeAvailableExtraArgsResponse"/></returns>
        public async Task<DescribeEdgeAvailableExtraArgsResponse> DescribeEdgeAvailableExtraArgs(DescribeEdgeAvailableExtraArgsRequest req)
        {
             JsonResponseModel<DescribeEdgeAvailableExtraArgsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeAvailableExtraArgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeAvailableExtraArgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘容器集群可用的自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAvailableExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeAvailableExtraArgsResponse"/></returns>
        public DescribeEdgeAvailableExtraArgsResponse DescribeEdgeAvailableExtraArgsSync(DescribeEdgeAvailableExtraArgsRequest req)
        {
             JsonResponseModel<DescribeEdgeAvailableExtraArgsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeAvailableExtraArgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeAvailableExtraArgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘容器CVM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeCVMInstancesResponse"/></returns>
        public async Task<DescribeEdgeCVMInstancesResponse> DescribeEdgeCVMInstances(DescribeEdgeCVMInstancesRequest req)
        {
             JsonResponseModel<DescribeEdgeCVMInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeCVMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeCVMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘容器CVM实例相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeCVMInstancesResponse"/></returns>
        public DescribeEdgeCVMInstancesResponse DescribeEdgeCVMInstancesSync(DescribeEdgeCVMInstancesRequest req)
        {
             JsonResponseModel<DescribeEdgeCVMInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeCVMInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeCVMInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterExtraArgsResponse"/></returns>
        public async Task<DescribeEdgeClusterExtraArgsResponse> DescribeEdgeClusterExtraArgs(DescribeEdgeClusterExtraArgsRequest req)
        {
             JsonResponseModel<DescribeEdgeClusterExtraArgsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeClusterExtraArgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeClusterExtraArgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群自定义参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterExtraArgsResponse"/></returns>
        public DescribeEdgeClusterExtraArgsResponse DescribeEdgeClusterExtraArgsSync(DescribeEdgeClusterExtraArgsRequest req)
        {
             JsonResponseModel<DescribeEdgeClusterExtraArgsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeClusterExtraArgs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeClusterExtraArgsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘计算集群的节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterInstancesResponse"/></returns>
        public async Task<DescribeEdgeClusterInstancesResponse> DescribeEdgeClusterInstances(DescribeEdgeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeEdgeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘计算集群的节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterInstancesResponse"/></returns>
        public DescribeEdgeClusterInstancesResponse DescribeEdgeClusterInstancesSync(DescribeEdgeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeEdgeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可以查询边缘集群升级信息，包含可以升级的组件，当前升级状态和升级错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterUpgradeInfoRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterUpgradeInfoResponse"/></returns>
        public async Task<DescribeEdgeClusterUpgradeInfoResponse> DescribeEdgeClusterUpgradeInfo(DescribeEdgeClusterUpgradeInfoRequest req)
        {
             JsonResponseModel<DescribeEdgeClusterUpgradeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeClusterUpgradeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeClusterUpgradeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可以查询边缘集群升级信息，包含可以升级的组件，当前升级状态和升级错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterUpgradeInfoRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterUpgradeInfoResponse"/></returns>
        public DescribeEdgeClusterUpgradeInfoResponse DescribeEdgeClusterUpgradeInfoSync(DescribeEdgeClusterUpgradeInfoRequest req)
        {
             JsonResponseModel<DescribeEdgeClusterUpgradeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeClusterUpgradeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeClusterUpgradeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件、审计和日志的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeEdgeLogSwitchesResponse"/></returns>
        public async Task<DescribeEdgeLogSwitchesResponse> DescribeEdgeLogSwitches(DescribeEdgeLogSwitchesRequest req)
        {
             JsonResponseModel<DescribeEdgeLogSwitchesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeLogSwitches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeLogSwitchesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取事件、审计和日志的状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeEdgeLogSwitchesResponse"/></returns>
        public DescribeEdgeLogSwitchesResponse DescribeEdgeLogSwitchesSync(DescribeEdgeLogSwitchesRequest req)
        {
             JsonResponseModel<DescribeEdgeLogSwitchesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeLogSwitches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeLogSwitchesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例中容器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEksContainerInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeEksContainerInstanceLogResponse"/></returns>
        public async Task<DescribeEksContainerInstanceLogResponse> DescribeEksContainerInstanceLog(DescribeEksContainerInstanceLogRequest req)
        {
             JsonResponseModel<DescribeEksContainerInstanceLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEksContainerInstanceLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEksContainerInstanceLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器实例中容器日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEksContainerInstanceLogRequest"/></param>
        /// <returns><see cref="DescribeEksContainerInstanceLogResponse"/></returns>
        public DescribeEksContainerInstanceLogResponse DescribeEksContainerInstanceLogSync(DescribeEksContainerInstanceLogRequest req)
        {
             JsonResponseModel<DescribeEksContainerInstanceLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEksContainerInstanceLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEksContainerInstanceLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询开启vpc-cni模式的任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public async Task<DescribeEnableVpcCniProgressResponse> DescribeEnableVpcCniProgress(DescribeEnableVpcCniProgressRequest req)
        {
             JsonResponseModel<DescribeEnableVpcCniProgressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnableVpcCniProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnableVpcCniProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询开启vpc-cni模式的任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public DescribeEnableVpcCniProgressResponse DescribeEnableVpcCniProgressSync(DescribeEnableVpcCniProgressRequest req)
        {
             JsonResponseModel<DescribeEnableVpcCniProgressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnableVpcCniProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnableVpcCniProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询etcd数据是否进行加密
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeEncryptionStatusResponse"/></returns>
        public async Task<DescribeEncryptionStatusResponse> DescribeEncryptionStatus(DescribeEncryptionStatusRequest req)
        {
             JsonResponseModel<DescribeEncryptionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEncryptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询etcd数据是否进行加密
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeEncryptionStatusResponse"/></returns>
        public DescribeEncryptionStatusResponse DescribeEncryptionStatusSync(DescribeEncryptionStatusRequest req)
        {
             JsonResponseModel<DescribeEncryptionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEncryptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询已经存在的节点，判断是否可以加入集群
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public async Task<DescribeExistedInstancesResponse> DescribeExistedInstances(DescribeExistedInstancesRequest req)
        {
             JsonResponseModel<DescribeExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询已经存在的节点，判断是否可以加入集群
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public DescribeExistedInstancesResponse DescribeExistedInstancesSync(DescribeExistedInstancesRequest req)
        {
             JsonResponseModel<DescribeExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取导入第三方集群YAML定义
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalClusterSpecRequest"/></param>
        /// <returns><see cref="DescribeExternalClusterSpecResponse"/></returns>
        public async Task<DescribeExternalClusterSpecResponse> DescribeExternalClusterSpec(DescribeExternalClusterSpecRequest req)
        {
             JsonResponseModel<DescribeExternalClusterSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExternalClusterSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalClusterSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取导入第三方集群YAML定义
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalClusterSpecRequest"/></param>
        /// <returns><see cref="DescribeExternalClusterSpecResponse"/></returns>
        public DescribeExternalClusterSpecResponse DescribeExternalClusterSpecSync(DescribeExternalClusterSpecRequest req)
        {
             JsonResponseModel<DescribeExternalClusterSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExternalClusterSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExternalClusterSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像缓存信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageCachesRequest"/></param>
        /// <returns><see cref="DescribeImageCachesResponse"/></returns>
        public async Task<DescribeImageCachesResponse> DescribeImageCaches(DescribeImageCachesRequest req)
        {
             JsonResponseModel<DescribeImageCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像缓存信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeImageCachesRequest"/></param>
        /// <returns><see cref="DescribeImageCachesResponse"/></returns>
        public DescribeImageCachesResponse DescribeImageCachesSync(DescribeImageCachesRequest req)
        {
             JsonResponseModel<DescribeImageCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取关联目标集群的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public async Task<DescribePrometheusAgentInstancesResponse> DescribePrometheusAgentInstances(DescribePrometheusAgentInstancesRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAgentInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取关联目标集群的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public DescribePrometheusAgentInstancesResponse DescribePrometheusAgentInstancesSync(DescribePrometheusAgentInstancesRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAgentInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取被关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public async Task<DescribePrometheusAgentsResponse> DescribePrometheusAgents(DescribePrometheusAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取被关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public DescribePrometheusAgentsResponse DescribePrometheusAgentsSync(DescribePrometheusAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警历史
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertHistoryRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertHistoryResponse"/></returns>
        public async Task<DescribePrometheusAlertHistoryResponse> DescribePrometheusAlertHistory(DescribePrometheusAlertHistoryRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAlertHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警历史
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertHistoryRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertHistoryResponse"/></returns>
        public DescribePrometheusAlertHistoryResponse DescribePrometheusAlertHistorySync(DescribePrometheusAlertHistoryRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAlertHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取2.0实例告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public async Task<DescribePrometheusAlertPolicyResponse> DescribePrometheusAlertPolicy(DescribePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取2.0实例告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public DescribePrometheusAlertPolicyResponse DescribePrometheusAlertPolicySync(DescribePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertRuleResponse"/></returns>
        public async Task<DescribePrometheusAlertRuleResponse> DescribePrometheusAlertRule(DescribePrometheusAlertRuleRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertRuleResponse"/></returns>
        public DescribePrometheusAlertRuleResponse DescribePrometheusAlertRuleSync(DescribePrometheusAlertRuleRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TMP实例关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public async Task<DescribePrometheusClusterAgentsResponse> DescribePrometheusClusterAgents(DescribePrometheusClusterAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusClusterAgentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusClusterAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusClusterAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TMP实例关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public DescribePrometheusClusterAgentsResponse DescribePrometheusClusterAgentsSync(DescribePrometheusClusterAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusClusterAgentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusClusterAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusClusterAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取Prometheus配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public async Task<DescribePrometheusConfigResponse> DescribePrometheusConfig(DescribePrometheusConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取Prometheus配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public DescribePrometheusConfigResponse DescribePrometheusConfigSync(DescribePrometheusConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获得实例级别抓取配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public async Task<DescribePrometheusGlobalConfigResponse> DescribePrometheusGlobalConfig(DescribePrometheusGlobalConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusGlobalConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获得实例级别抓取配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public DescribePrometheusGlobalConfigResponse DescribePrometheusGlobalConfigSync(DescribePrometheusGlobalConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusGlobalConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public async Task<DescribePrometheusGlobalNotificationResponse> DescribePrometheusGlobalNotification(DescribePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public DescribePrometheusGlobalNotificationResponse DescribePrometheusGlobalNotificationSync(DescribePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceResponse"/></returns>
        public async Task<DescribePrometheusInstanceResponse> DescribePrometheusInstance(DescribePrometheusInstanceRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceResponse"/></returns>
        public DescribePrometheusInstanceResponse DescribePrometheusInstanceSync(DescribePrometheusInstanceRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取2.0实例初始化任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public async Task<DescribePrometheusInstanceInitStatusResponse> DescribePrometheusInstanceInitStatus(DescribePrometheusInstanceInitStatusRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceInitStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstanceInitStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceInitStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取2.0实例初始化任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public DescribePrometheusInstanceInitStatusResponse DescribePrometheusInstanceInitStatusSync(DescribePrometheusInstanceInitStatusRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceInitStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstanceInitStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceInitStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取与云监控融合实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public async Task<DescribePrometheusInstancesOverviewResponse> DescribePrometheusInstancesOverview(DescribePrometheusInstancesOverviewRequest req)
        {
             JsonResponseModel<DescribePrometheusInstancesOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstancesOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstancesOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取与云监控融合实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public DescribePrometheusInstancesOverviewResponse DescribePrometheusInstancesOverviewSync(DescribePrometheusInstancesOverviewRequest req)
        {
             JsonResponseModel<DescribePrometheusInstancesOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstancesOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstancesOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusOverviewsRequest"/></param>
        /// <returns><see cref="DescribePrometheusOverviewsResponse"/></returns>
        public async Task<DescribePrometheusOverviewsResponse> DescribePrometheusOverviews(DescribePrometheusOverviewsRequest req)
        {
             JsonResponseModel<DescribePrometheusOverviewsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusOverviews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusOverviewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusOverviewsRequest"/></param>
        /// <returns><see cref="DescribePrometheusOverviewsResponse"/></returns>
        public DescribePrometheusOverviewsResponse DescribePrometheusOverviewsSync(DescribePrometheusOverviewsRequest req)
        {
             JsonResponseModel<DescribePrometheusOverviewsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusOverviews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusOverviewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取聚合规则列表，包含关联集群内crd资源创建的record rule
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public async Task<DescribePrometheusRecordRulesResponse> DescribePrometheusRecordRules(DescribePrometheusRecordRulesRequest req)
        {
             JsonResponseModel<DescribePrometheusRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取聚合规则列表，包含关联集群内crd资源创建的record rule
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public DescribePrometheusRecordRulesResponse DescribePrometheusRecordRulesSync(DescribePrometheusRecordRulesRequest req)
        {
             JsonResponseModel<DescribePrometheusRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取targets信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsResponse"/></returns>
        public async Task<DescribePrometheusTargetsResponse> DescribePrometheusTargets(DescribePrometheusTargetsRequest req)
        {
             JsonResponseModel<DescribePrometheusTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取targets信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsResponse"/></returns>
        public DescribePrometheusTargetsResponse DescribePrometheusTargetsSync(DescribePrometheusTargetsRequest req)
        {
             JsonResponseModel<DescribePrometheusTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public async Task<DescribePrometheusTempResponse> DescribePrometheusTemp(DescribePrometheusTempRequest req)
        {
             JsonResponseModel<DescribePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public DescribePrometheusTempResponse DescribePrometheusTempSync(DescribePrometheusTempRequest req)
        {
             JsonResponseModel<DescribePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板关联实例信息，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public async Task<DescribePrometheusTempSyncResponse> DescribePrometheusTempSync(DescribePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DescribePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板关联实例信息，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public DescribePrometheusTempSyncResponse DescribePrometheusTempSyncSync(DescribePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DescribePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板同步信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplateSyncResponse"/></returns>
        public async Task<DescribePrometheusTemplateSyncResponse> DescribePrometheusTemplateSync(DescribePrometheusTemplateSyncRequest req)
        {
             JsonResponseModel<DescribePrometheusTemplateSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTemplateSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTemplateSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板同步信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplateSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplateSyncResponse"/></returns>
        public DescribePrometheusTemplateSyncResponse DescribePrometheusTemplateSyncSync(DescribePrometheusTemplateSyncRequest req)
        {
             JsonResponseModel<DescribePrometheusTemplateSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTemplateSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTemplateSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplatesRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplatesResponse"/></returns>
        public async Task<DescribePrometheusTemplatesResponse> DescribePrometheusTemplates(DescribePrometheusTemplatesRequest req)
        {
             JsonResponseModel<DescribePrometheusTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTemplatesRequest"/></param>
        /// <returns><see cref="DescribePrometheusTemplatesResponse"/></returns>
        public DescribePrometheusTemplatesResponse DescribePrometheusTemplatesSync(DescribePrometheusTemplatesRequest req)
        {
             JsonResponseModel<DescribePrometheusTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取容器服务支持的所有地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取容器服务支持的所有地域
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群资源使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public async Task<DescribeResourceUsageResponse> DescribeResourceUsage(DescribeResourceUsageRequest req)
        {
             JsonResponseModel<DescribeResourceUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群资源使用量
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public DescribeResourceUsageResponse DescribeResourceUsageSync(DescribeResourceUsageRequest req)
        {
             JsonResponseModel<DescribeResourceUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路由表冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public async Task<DescribeRouteTableConflictsResponse> DescribeRouteTableConflicts(DescribeRouteTableConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteTableConflictsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteTableConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTableConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路由表冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public DescribeRouteTableConflictsResponse DescribeRouteTableConflictsSync(DescribeRouteTableConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteTableConflictsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRouteTableConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTableConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘计算集群的认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterCredentialResponse"/></returns>
        public async Task<DescribeTKEEdgeClusterCredentialResponse> DescribeTKEEdgeClusterCredential(DescribeTKEEdgeClusterCredentialRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeClusterCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTKEEdgeClusterCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeClusterCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘计算集群的认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterCredentialResponse"/></returns>
        public DescribeTKEEdgeClusterCredentialResponse DescribeTKEEdgeClusterCredentialSync(DescribeTKEEdgeClusterCredentialRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeClusterCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTKEEdgeClusterCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeClusterCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘计算集群的当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterStatusResponse"/></returns>
        public async Task<DescribeTKEEdgeClusterStatusResponse> DescribeTKEEdgeClusterStatus(DescribeTKEEdgeClusterStatusRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeClusterStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTKEEdgeClusterStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeClusterStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘计算集群的当前状态以及过程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterStatusResponse"/></returns>
        public DescribeTKEEdgeClusterStatusResponse DescribeTKEEdgeClusterStatusSync(DescribeTKEEdgeClusterStatusRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeClusterStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTKEEdgeClusterStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeClusterStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClustersRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClustersResponse"/></returns>
        public async Task<DescribeTKEEdgeClustersResponse> DescribeTKEEdgeClusters(DescribeTKEEdgeClustersRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTKEEdgeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClustersRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClustersResponse"/></returns>
        public DescribeTKEEdgeClustersResponse DescribeTKEEdgeClustersSync(DescribeTKEEdgeClustersRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTKEEdgeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘计算外部访问的kubeconfig
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeExternalKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeExternalKubeconfigResponse"/></returns>
        public async Task<DescribeTKEEdgeExternalKubeconfigResponse> DescribeTKEEdgeExternalKubeconfig(DescribeTKEEdgeExternalKubeconfigRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeExternalKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTKEEdgeExternalKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeExternalKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘计算外部访问的kubeconfig
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeExternalKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeExternalKubeconfigResponse"/></returns>
        public DescribeTKEEdgeExternalKubeconfigResponse DescribeTKEEdgeExternalKubeconfigSync(DescribeTKEEdgeExternalKubeconfigRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeExternalKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTKEEdgeExternalKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeExternalKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘脚本链接，此接口用于添加第三方节点，通过下载脚本从而将节点添加到边缘集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeScriptRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeScriptResponse"/></returns>
        public async Task<DescribeTKEEdgeScriptResponse> DescribeTKEEdgeScript(DescribeTKEEdgeScriptRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTKEEdgeScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘脚本链接，此接口用于添加第三方节点，通过下载脚本从而将节点添加到边缘集群。
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeScriptRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeScriptResponse"/></returns>
        public DescribeTKEEdgeScriptResponse DescribeTKEEdgeScriptSync(DescribeTKEEdgeScriptRequest req)
        {
             JsonResponseModel<DescribeTKEEdgeScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTKEEdgeScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTKEEdgeScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群版本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionsRequest"/></param>
        /// <returns><see cref="DescribeVersionsResponse"/></returns>
        public async Task<DescribeVersionsResponse> DescribeVersions(DescribeVersionsRequest req)
        {
             JsonResponseModel<DescribeVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群版本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionsRequest"/></param>
        /// <returns><see cref="DescribeVersionsResponse"/></returns>
        public DescribeVersionsResponse DescribeVersionsSync(DescribeVersionsRequest req)
        {
             JsonResponseModel<DescribeVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口查询当前用户和地域在指定可用区下的机型可支持的最大 TKE VPC-CNI 网络模式的 Pod 数量
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcCniPodLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcCniPodLimitsResponse"/></returns>
        public async Task<DescribeVpcCniPodLimitsResponse> DescribeVpcCniPodLimits(DescribeVpcCniPodLimitsRequest req)
        {
             JsonResponseModel<DescribeVpcCniPodLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcCniPodLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcCniPodLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口查询当前用户和地域在指定可用区下的机型可支持的最大 TKE VPC-CNI 网络模式的 Pod 数量
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcCniPodLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcCniPodLimitsResponse"/></returns>
        public DescribeVpcCniPodLimitsResponse DescribeVpcCniPodLimitsSync(DescribeVpcCniPodLimitsRequest req)
        {
             JsonResponseModel<DescribeVpcCniPodLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcCniPodLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcCniPodLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭集群审计
        /// </summary>
        /// <param name="req"><see cref="DisableClusterAuditRequest"/></param>
        /// <returns><see cref="DisableClusterAuditResponse"/></returns>
        public async Task<DisableClusterAuditResponse> DisableClusterAudit(DisableClusterAuditRequest req)
        {
             JsonResponseModel<DisableClusterAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableClusterAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClusterAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭集群审计
        /// </summary>
        /// <param name="req"><see cref="DisableClusterAuditRequest"/></param>
        /// <returns><see cref="DisableClusterAuditResponse"/></returns>
        public DisableClusterAuditResponse DisableClusterAuditSync(DisableClusterAuditRequest req)
        {
             JsonResponseModel<DisableClusterAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableClusterAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClusterAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭集群删除保护
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableClusterDeletionProtectionResponse"/></returns>
        public async Task<DisableClusterDeletionProtectionResponse> DisableClusterDeletionProtection(DisableClusterDeletionProtectionRequest req)
        {
             JsonResponseModel<DisableClusterDeletionProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableClusterDeletionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClusterDeletionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭集群删除保护
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableClusterDeletionProtectionResponse"/></returns>
        public DisableClusterDeletionProtectionResponse DisableClusterDeletionProtectionSync(DisableClusterDeletionProtectionRequest req)
        {
             JsonResponseModel<DisableClusterDeletionProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableClusterDeletionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClusterDeletionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭加密信息保护
        /// </summary>
        /// <param name="req"><see cref="DisableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="DisableEncryptionProtectionResponse"/></returns>
        public async Task<DisableEncryptionProtectionResponse> DisableEncryptionProtection(DisableEncryptionProtectionRequest req)
        {
             JsonResponseModel<DisableEncryptionProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableEncryptionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableEncryptionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭加密信息保护
        /// </summary>
        /// <param name="req"><see cref="DisableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="DisableEncryptionProtectionResponse"/></returns>
        public DisableEncryptionProtectionResponse DisableEncryptionProtectionSync(DisableEncryptionProtectionRequest req)
        {
             JsonResponseModel<DisableEncryptionProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableEncryptionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableEncryptionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="DisableEventPersistenceRequest"/></param>
        /// <returns><see cref="DisableEventPersistenceResponse"/></returns>
        public async Task<DisableEventPersistenceResponse> DisableEventPersistence(DisableEventPersistenceRequest req)
        {
             JsonResponseModel<DisableEventPersistenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableEventPersistence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableEventPersistenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="DisableEventPersistenceRequest"/></param>
        /// <returns><see cref="DisableEventPersistenceResponse"/></returns>
        public DisableEventPersistenceResponse DisableEventPersistenceSync(DisableEventPersistenceRequest req)
        {
             JsonResponseModel<DisableEventPersistenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableEventPersistence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableEventPersistenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供给附加了VPC-CNI能力的Global-Route集群关闭VPC-CNI
        /// </summary>
        /// <param name="req"><see cref="DisableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="DisableVpcCniNetworkTypeResponse"/></returns>
        public async Task<DisableVpcCniNetworkTypeResponse> DisableVpcCniNetworkType(DisableVpcCniNetworkTypeRequest req)
        {
             JsonResponseModel<DisableVpcCniNetworkTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableVpcCniNetworkType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableVpcCniNetworkTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供给附加了VPC-CNI能力的Global-Route集群关闭VPC-CNI
        /// </summary>
        /// <param name="req"><see cref="DisableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="DisableVpcCniNetworkTypeResponse"/></returns>
        public DisableVpcCniNetworkTypeResponse DisableVpcCniNetworkTypeSync(DisableVpcCniNetworkTypeRequest req)
        {
             JsonResponseModel<DisableVpcCniNetworkTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableVpcCniNetworkType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableVpcCniNetworkTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 驱逐虚拟节点
        /// </summary>
        /// <param name="req"><see cref="DrainClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DrainClusterVirtualNodeResponse"/></returns>
        public async Task<DrainClusterVirtualNodeResponse> DrainClusterVirtualNode(DrainClusterVirtualNodeRequest req)
        {
             JsonResponseModel<DrainClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DrainClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DrainClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 驱逐虚拟节点
        /// </summary>
        /// <param name="req"><see cref="DrainClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DrainClusterVirtualNodeResponse"/></returns>
        public DrainClusterVirtualNodeResponse DrainClusterVirtualNodeSync(DrainClusterVirtualNodeRequest req)
        {
             JsonResponseModel<DrainClusterVirtualNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DrainClusterVirtualNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DrainClusterVirtualNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启集群审计
        /// </summary>
        /// <param name="req"><see cref="EnableClusterAuditRequest"/></param>
        /// <returns><see cref="EnableClusterAuditResponse"/></returns>
        public async Task<EnableClusterAuditResponse> EnableClusterAudit(EnableClusterAuditRequest req)
        {
             JsonResponseModel<EnableClusterAuditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableClusterAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClusterAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启集群审计
        /// </summary>
        /// <param name="req"><see cref="EnableClusterAuditRequest"/></param>
        /// <returns><see cref="EnableClusterAuditResponse"/></returns>
        public EnableClusterAuditResponse EnableClusterAuditSync(EnableClusterAuditRequest req)
        {
             JsonResponseModel<EnableClusterAuditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableClusterAudit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClusterAuditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用集群删除保护
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableClusterDeletionProtectionResponse"/></returns>
        public async Task<EnableClusterDeletionProtectionResponse> EnableClusterDeletionProtection(EnableClusterDeletionProtectionRequest req)
        {
             JsonResponseModel<EnableClusterDeletionProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableClusterDeletionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClusterDeletionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用集群删除保护
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableClusterDeletionProtectionResponse"/></returns>
        public EnableClusterDeletionProtectionResponse EnableClusterDeletionProtectionSync(EnableClusterDeletionProtectionRequest req)
        {
             JsonResponseModel<EnableClusterDeletionProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableClusterDeletionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClusterDeletionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启加密数据保护
        /// </summary>
        /// <param name="req"><see cref="EnableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="EnableEncryptionProtectionResponse"/></returns>
        public async Task<EnableEncryptionProtectionResponse> EnableEncryptionProtection(EnableEncryptionProtectionRequest req)
        {
             JsonResponseModel<EnableEncryptionProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableEncryptionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableEncryptionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启加密数据保护
        /// </summary>
        /// <param name="req"><see cref="EnableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="EnableEncryptionProtectionResponse"/></returns>
        public EnableEncryptionProtectionResponse EnableEncryptionProtectionSync(EnableEncryptionProtectionRequest req)
        {
             JsonResponseModel<EnableEncryptionProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableEncryptionProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableEncryptionProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="EnableEventPersistenceRequest"/></param>
        /// <returns><see cref="EnableEventPersistenceResponse"/></returns>
        public async Task<EnableEventPersistenceResponse> EnableEventPersistence(EnableEventPersistenceRequest req)
        {
             JsonResponseModel<EnableEventPersistenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableEventPersistence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableEventPersistenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启事件持久化功能
        /// </summary>
        /// <param name="req"><see cref="EnableEventPersistenceRequest"/></param>
        /// <returns><see cref="EnableEventPersistenceResponse"/></returns>
        public EnableEventPersistenceResponse EnableEventPersistenceSync(EnableEventPersistenceRequest req)
        {
             JsonResponseModel<EnableEventPersistenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableEventPersistence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableEventPersistenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GR集群可以通过本接口附加vpc-cni容器网络插件，开启vpc-cni容器网络能力
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public async Task<EnableVpcCniNetworkTypeResponse> EnableVpcCniNetworkType(EnableVpcCniNetworkTypeRequest req)
        {
             JsonResponseModel<EnableVpcCniNetworkTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableVpcCniNetworkType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcCniNetworkTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GR集群可以通过本接口附加vpc-cni容器网络插件，开启vpc-cni容器网络能力
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public EnableVpcCniNetworkTypeResponse EnableVpcCniNetworkTypeSync(EnableVpcCniNetworkTypeRequest req)
        {
             JsonResponseModel<EnableVpcCniNetworkTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableVpcCniNetworkType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcCniNetworkTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 操作TKE集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardApplicationRequestV3Response"/></returns>
        public async Task<ForwardApplicationRequestV3Response> ForwardApplicationRequestV3(ForwardApplicationRequestV3Request req)
        {
             JsonResponseModel<ForwardApplicationRequestV3Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForwardApplicationRequestV3");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForwardApplicationRequestV3Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 操作TKE集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardApplicationRequestV3Response"/></returns>
        public ForwardApplicationRequestV3Response ForwardApplicationRequestV3Sync(ForwardApplicationRequestV3Request req)
        {
             JsonResponseModel<ForwardApplicationRequestV3Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForwardApplicationRequestV3");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForwardApplicationRequestV3Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 操作TKEEdge集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardTKEEdgeApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardTKEEdgeApplicationRequestV3Response"/></returns>
        public async Task<ForwardTKEEdgeApplicationRequestV3Response> ForwardTKEEdgeApplicationRequestV3(ForwardTKEEdgeApplicationRequestV3Request req)
        {
             JsonResponseModel<ForwardTKEEdgeApplicationRequestV3Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ForwardTKEEdgeApplicationRequestV3");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForwardTKEEdgeApplicationRequestV3Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 操作TKEEdge集群的addon
        /// </summary>
        /// <param name="req"><see cref="ForwardTKEEdgeApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardTKEEdgeApplicationRequestV3Response"/></returns>
        public ForwardTKEEdgeApplicationRequestV3Response ForwardTKEEdgeApplicationRequestV3Sync(ForwardTKEEdgeApplicationRequestV3Request req)
        {
             JsonResponseModel<ForwardTKEEdgeApplicationRequestV3Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ForwardTKEEdgeApplicationRequestV3");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ForwardTKEEdgeApplicationRequestV3Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群规模价格
        /// </summary>
        /// <param name="req"><see cref="GetClusterLevelPriceRequest"/></param>
        /// <returns><see cref="GetClusterLevelPriceResponse"/></returns>
        public async Task<GetClusterLevelPriceResponse> GetClusterLevelPrice(GetClusterLevelPriceRequest req)
        {
             JsonResponseModel<GetClusterLevelPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetClusterLevelPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetClusterLevelPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群规模价格
        /// </summary>
        /// <param name="req"><see cref="GetClusterLevelPriceRequest"/></param>
        /// <returns><see cref="GetClusterLevelPriceResponse"/></returns>
        public GetClusterLevelPriceResponse GetClusterLevelPriceSync(GetClusterLevelPriceRequest req)
        {
             JsonResponseModel<GetClusterLevelPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetClusterLevelPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetClusterLevelPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据镜像列表，查询匹配的镜像缓存
        /// </summary>
        /// <param name="req"><see cref="GetMostSuitableImageCacheRequest"/></param>
        /// <returns><see cref="GetMostSuitableImageCacheResponse"/></returns>
        public async Task<GetMostSuitableImageCacheResponse> GetMostSuitableImageCache(GetMostSuitableImageCacheRequest req)
        {
             JsonResponseModel<GetMostSuitableImageCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMostSuitableImageCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMostSuitableImageCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据镜像列表，查询匹配的镜像缓存
        /// </summary>
        /// <param name="req"><see cref="GetMostSuitableImageCacheRequest"/></param>
        /// <returns><see cref="GetMostSuitableImageCacheResponse"/></returns>
        public GetMostSuitableImageCacheResponse GetMostSuitableImageCacheSync(GetMostSuitableImageCacheRequest req)
        {
             JsonResponseModel<GetMostSuitableImageCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMostSuitableImageCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMostSuitableImageCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TKE支持的App列表
        /// </summary>
        /// <param name="req"><see cref="GetTkeAppChartListRequest"/></param>
        /// <returns><see cref="GetTkeAppChartListResponse"/></returns>
        public async Task<GetTkeAppChartListResponse> GetTkeAppChartList(GetTkeAppChartListRequest req)
        {
             JsonResponseModel<GetTkeAppChartListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTkeAppChartList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTkeAppChartListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取TKE支持的App列表
        /// </summary>
        /// <param name="req"><see cref="GetTkeAppChartListRequest"/></param>
        /// <returns><see cref="GetTkeAppChartListResponse"/></returns>
        public GetTkeAppChartListResponse GetTkeAppChartListSync(GetTkeAppChartListRequest req)
        {
             JsonResponseModel<GetTkeAppChartListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTkeAppChartList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTkeAppChartListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获得节点升级当前的进度
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public async Task<GetUpgradeInstanceProgressResponse> GetUpgradeInstanceProgress(GetUpgradeInstanceProgressRequest req)
        {
             JsonResponseModel<GetUpgradeInstanceProgressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUpgradeInstanceProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeInstanceProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获得节点升级当前的进度
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public GetUpgradeInstanceProgressResponse GetUpgradeInstanceProgressSync(GetUpgradeInstanceProgressRequest req)
        {
             JsonResponseModel<GetUpgradeInstanceProgressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUpgradeInstanceProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeInstanceProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为目标集群安装一个addon
        /// </summary>
        /// <param name="req"><see cref="InstallAddonRequest"/></param>
        /// <returns><see cref="InstallAddonResponse"/></returns>
        public async Task<InstallAddonResponse> InstallAddon(InstallAddonRequest req)
        {
             JsonResponseModel<InstallAddonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InstallAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为目标集群安装一个addon
        /// </summary>
        /// <param name="req"><see cref="InstallAddonRequest"/></param>
        /// <returns><see cref="InstallAddonResponse"/></returns>
        public InstallAddonResponse InstallAddonSync(InstallAddonRequest req)
        {
             JsonResponseModel<InstallAddonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InstallAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在tke@edge集群的边缘节点上安装日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="InstallEdgeLogAgentResponse"/></returns>
        public async Task<InstallEdgeLogAgentResponse> InstallEdgeLogAgent(InstallEdgeLogAgentRequest req)
        {
             JsonResponseModel<InstallEdgeLogAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InstallEdgeLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallEdgeLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在tke@edge集群的边缘节点上安装日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="InstallEdgeLogAgentResponse"/></returns>
        public InstallEdgeLogAgentResponse InstallEdgeLogAgentSync(InstallEdgeLogAgentRequest req)
        {
             JsonResponseModel<InstallEdgeLogAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InstallEdgeLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallEdgeLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在TKE集群中安装CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallLogAgentRequest"/></param>
        /// <returns><see cref="InstallLogAgentResponse"/></returns>
        public async Task<InstallLogAgentResponse> InstallLogAgent(InstallLogAgentRequest req)
        {
             JsonResponseModel<InstallLogAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InstallLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在TKE集群中安装CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="InstallLogAgentRequest"/></param>
        /// <returns><see cref="InstallLogAgentResponse"/></returns>
        public InstallLogAgentResponse InstallLogAgentSync(InstallLogAgentRequest req)
        {
             JsonResponseModel<InstallLogAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InstallLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定集群的巡检结果信息
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsResponse"/></returns>
        public async Task<ListClusterInspectionResultsResponse> ListClusterInspectionResults(ListClusterInspectionResultsRequest req)
        {
             JsonResponseModel<ListClusterInspectionResultsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListClusterInspectionResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClusterInspectionResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定集群的巡检结果信息
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsResponse"/></returns>
        public ListClusterInspectionResultsResponse ListClusterInspectionResultsSync(ListClusterInspectionResultsRequest req)
        {
             JsonResponseModel<ListClusterInspectionResultsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListClusterInspectionResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClusterInspectionResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群巡检结果历史列表
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsItemsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsItemsResponse"/></returns>
        public async Task<ListClusterInspectionResultsItemsResponse> ListClusterInspectionResultsItems(ListClusterInspectionResultsItemsRequest req)
        {
             JsonResponseModel<ListClusterInspectionResultsItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListClusterInspectionResultsItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClusterInspectionResultsItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群巡检结果历史列表
        /// </summary>
        /// <param name="req"><see cref="ListClusterInspectionResultsItemsRequest"/></param>
        /// <returns><see cref="ListClusterInspectionResultsItemsResponse"/></returns>
        public ListClusterInspectionResultsItemsResponse ListClusterInspectionResultsItemsSync(ListClusterInspectionResultsItemsRequest req)
        {
             JsonResponseModel<ListClusterInspectionResultsItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListClusterInspectionResultsItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClusterInspectionResultsItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群伸缩组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public async Task<ModifyClusterAsGroupAttributeResponse> ModifyClusterAsGroupAttribute(ModifyClusterAsGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterAsGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群伸缩组属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public ModifyClusterAsGroupAttributeResponse ModifyClusterAsGroupAttributeSync(ModifyClusterAsGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterAsGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群弹性伸缩属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public async Task<ModifyClusterAsGroupOptionAttributeResponse> ModifyClusterAsGroupOptionAttribute(ModifyClusterAsGroupOptionAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterAsGroupOptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群弹性伸缩属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public ModifyClusterAsGroupOptionAttributeResponse ModifyClusterAsGroupOptionAttributeSync(ModifyClusterAsGroupOptionAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterAsGroupOptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public async Task<ModifyClusterAttributeResponse> ModifyClusterAttribute(ModifyClusterAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群属性
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public ModifyClusterAttributeResponse ModifyClusterAttributeSync(ModifyClusterAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群认证配置
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="ModifyClusterAuthenticationOptionsResponse"/></returns>
        public async Task<ModifyClusterAuthenticationOptionsResponse> ModifyClusterAuthenticationOptions(ModifyClusterAuthenticationOptionsRequest req)
        {
             JsonResponseModel<ModifyClusterAuthenticationOptionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterAuthenticationOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAuthenticationOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群认证配置
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="ModifyClusterAuthenticationOptionsResponse"/></returns>
        public ModifyClusterAuthenticationOptionsResponse ModifyClusterAuthenticationOptionsSync(ModifyClusterAuthenticationOptionsRequest req)
        {
             JsonResponseModel<ModifyClusterAuthenticationOptionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterAuthenticationOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAuthenticationOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改托管集群外网端口的安全策略（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public async Task<ModifyClusterEndpointSPResponse> ModifyClusterEndpointSP(ModifyClusterEndpointSPRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointSPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterEndpointSP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointSPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改托管集群外网端口的安全策略（老的方式，仅支持托管集群外网端口）
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public ModifyClusterEndpointSPResponse ModifyClusterEndpointSPSync(ModifyClusterEndpointSPRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointSPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterEndpointSP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointSPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public async Task<ModifyClusterNodePoolResponse> ModifyClusterNodePool(ModifyClusterNodePoolRequest req)
        {
             JsonResponseModel<ModifyClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public ModifyClusterNodePoolResponse ModifyClusterNodePoolSync(ModifyClusterNodePoolRequest req)
        {
             JsonResponseModel<ModifyClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改虚拟节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterVirtualNodePoolResponse"/></returns>
        public async Task<ModifyClusterVirtualNodePoolResponse> ModifyClusterVirtualNodePool(ModifyClusterVirtualNodePoolRequest req)
        {
             JsonResponseModel<ModifyClusterVirtualNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterVirtualNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterVirtualNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改虚拟节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterVirtualNodePoolResponse"/></returns>
        public ModifyClusterVirtualNodePoolResponse ModifyClusterVirtualNodePoolSync(ModifyClusterVirtualNodePoolRequest req)
        {
             JsonResponseModel<ModifyClusterVirtualNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterVirtualNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterVirtualNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改节点池关联伸缩组的期望实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolDesiredCapacityAboutAsgRequest"/></param>
        /// <returns><see cref="ModifyNodePoolDesiredCapacityAboutAsgResponse"/></returns>
        public async Task<ModifyNodePoolDesiredCapacityAboutAsgResponse> ModifyNodePoolDesiredCapacityAboutAsg(ModifyNodePoolDesiredCapacityAboutAsgRequest req)
        {
             JsonResponseModel<ModifyNodePoolDesiredCapacityAboutAsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNodePoolDesiredCapacityAboutAsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNodePoolDesiredCapacityAboutAsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改节点池关联伸缩组的期望实例数
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolDesiredCapacityAboutAsgRequest"/></param>
        /// <returns><see cref="ModifyNodePoolDesiredCapacityAboutAsgResponse"/></returns>
        public ModifyNodePoolDesiredCapacityAboutAsgResponse ModifyNodePoolDesiredCapacityAboutAsgSync(ModifyNodePoolDesiredCapacityAboutAsgRequest req)
        {
             JsonResponseModel<ModifyNodePoolDesiredCapacityAboutAsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNodePoolDesiredCapacityAboutAsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNodePoolDesiredCapacityAboutAsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改节点池的机型配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolInstanceTypesRequest"/></param>
        /// <returns><see cref="ModifyNodePoolInstanceTypesResponse"/></returns>
        public async Task<ModifyNodePoolInstanceTypesResponse> ModifyNodePoolInstanceTypes(ModifyNodePoolInstanceTypesRequest req)
        {
             JsonResponseModel<ModifyNodePoolInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNodePoolInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNodePoolInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改节点池的机型配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolInstanceTypesRequest"/></param>
        /// <returns><see cref="ModifyNodePoolInstanceTypesResponse"/></returns>
        public ModifyNodePoolInstanceTypesResponse ModifyNodePoolInstanceTypesSync(ModifyNodePoolInstanceTypesRequest req)
        {
             JsonResponseModel<ModifyNodePoolInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNodePoolInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNodePoolInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改被关联集群的external labels
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public async Task<ModifyPrometheusAgentExternalLabelsResponse> ModifyPrometheusAgentExternalLabels(ModifyPrometheusAgentExternalLabelsRequest req)
        {
             JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusAgentExternalLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改被关联集群的external labels
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public ModifyPrometheusAgentExternalLabelsResponse ModifyPrometheusAgentExternalLabelsSync(ModifyPrometheusAgentExternalLabelsRequest req)
        {
             JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusAgentExternalLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public async Task<ModifyPrometheusAlertPolicyResponse> ModifyPrometheusAlertPolicy(ModifyPrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<ModifyPrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public ModifyPrometheusAlertPolicyResponse ModifyPrometheusAlertPolicySync(ModifyPrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<ModifyPrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertRuleResponse"/></returns>
        public async Task<ModifyPrometheusAlertRuleResponse> ModifyPrometheusAlertRule(ModifyPrometheusAlertRuleRequest req)
        {
             JsonResponseModel<ModifyPrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertRuleResponse"/></returns>
        public ModifyPrometheusAlertRuleResponse ModifyPrometheusAlertRuleSync(ModifyPrometheusAlertRuleRequest req)
        {
             JsonResponseModel<ModifyPrometheusAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改prometheus配置，如果配置项不存在，则会新增
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public async Task<ModifyPrometheusConfigResponse> ModifyPrometheusConfig(ModifyPrometheusConfigRequest req)
        {
             JsonResponseModel<ModifyPrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改prometheus配置，如果配置项不存在，则会新增
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public ModifyPrometheusConfigResponse ModifyPrometheusConfigSync(ModifyPrometheusConfigRequest req)
        {
             JsonResponseModel<ModifyPrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public async Task<ModifyPrometheusGlobalNotificationResponse> ModifyPrometheusGlobalNotification(ModifyPrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<ModifyPrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public ModifyPrometheusGlobalNotificationResponse ModifyPrometheusGlobalNotificationSync(ModifyPrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<ModifyPrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过yaml的方式修改Prometheus聚合实例
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public async Task<ModifyPrometheusRecordRuleYamlResponse> ModifyPrometheusRecordRuleYaml(ModifyPrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过yaml的方式修改Prometheus聚合实例
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public ModifyPrometheusRecordRuleYamlResponse ModifyPrometheusRecordRuleYamlSync(ModifyPrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public async Task<ModifyPrometheusTempResponse> ModifyPrometheusTemp(ModifyPrometheusTempRequest req)
        {
             JsonResponseModel<ModifyPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public ModifyPrometheusTempResponse ModifyPrometheusTempSync(ModifyPrometheusTempRequest req)
        {
             JsonResponseModel<ModifyPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTemplateRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTemplateResponse"/></returns>
        public async Task<ModifyPrometheusTemplateResponse> ModifyPrometheusTemplate(ModifyPrometheusTemplateRequest req)
        {
             JsonResponseModel<ModifyPrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTemplateRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTemplateResponse"/></returns>
        public ModifyPrometheusTemplateResponse ModifyPrometheusTemplateSync(ModifyPrometheusTemplateRequest req)
        {
             JsonResponseModel<ModifyPrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移出节点池节点，但保留在集群内
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public async Task<RemoveNodeFromNodePoolResponse> RemoveNodeFromNodePool(RemoveNodeFromNodePoolRequest req)
        {
             JsonResponseModel<RemoveNodeFromNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveNodeFromNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveNodeFromNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移出节点池节点，但保留在集群内
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public RemoveNodeFromNodePoolResponse RemoveNodeFromNodePoolSync(RemoveNodeFromNodePoolRequest req)
        {
             JsonResponseModel<RemoveNodeFromNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveNodeFromNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveNodeFromNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启弹性容器实例，支持批量操作
        /// </summary>
        /// <param name="req"><see cref="RestartEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="RestartEKSContainerInstancesResponse"/></returns>
        public async Task<RestartEKSContainerInstancesResponse> RestartEKSContainerInstances(RestartEKSContainerInstancesRequest req)
        {
             JsonResponseModel<RestartEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启弹性容器实例，支持批量操作
        /// </summary>
        /// <param name="req"><see cref="RestartEKSContainerInstancesRequest"/></param>
        /// <returns><see cref="RestartEKSContainerInstancesResponse"/></returns>
        public RestartEKSContainerInstancesResponse RestartEKSContainerInstancesSync(RestartEKSContainerInstancesRequest req)
        {
             JsonResponseModel<RestartEKSContainerInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartEKSContainerInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartEKSContainerInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中集群回滚应用至某个历史版本
        /// </summary>
        /// <param name="req"><see cref="RollbackClusterReleaseRequest"/></param>
        /// <returns><see cref="RollbackClusterReleaseResponse"/></returns>
        public async Task<RollbackClusterReleaseResponse> RollbackClusterRelease(RollbackClusterReleaseRequest req)
        {
             JsonResponseModel<RollbackClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中集群回滚应用至某个历史版本
        /// </summary>
        /// <param name="req"><see cref="RollbackClusterReleaseRequest"/></param>
        /// <returns><see cref="RollbackClusterReleaseResponse"/></returns>
        public RollbackClusterReleaseResponse RollbackClusterReleaseSync(RollbackClusterReleaseRequest req)
        {
             JsonResponseModel<RollbackClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 初始化TMP实例，开启集成中心时调用
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public async Task<RunPrometheusInstanceResponse> RunPrometheusInstance(RunPrometheusInstanceRequest req)
        {
             JsonResponseModel<RunPrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunPrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunPrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 初始化TMP实例，开启集成中心时调用
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public RunPrometheusInstanceResponse RunPrometheusInstanceSync(RunPrometheusInstanceRequest req)
        {
             JsonResponseModel<RunPrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunPrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunPrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 缩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleInClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleInClusterMasterResponse"/></returns>
        public async Task<ScaleInClusterMasterResponse> ScaleInClusterMaster(ScaleInClusterMasterRequest req)
        {
             JsonResponseModel<ScaleInClusterMasterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleInClusterMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleInClusterMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 缩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleInClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleInClusterMasterResponse"/></returns>
        public ScaleInClusterMasterResponse ScaleInClusterMasterSync(ScaleInClusterMasterRequest req)
        {
             JsonResponseModel<ScaleInClusterMasterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleInClusterMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleInClusterMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterMasterResponse"/></returns>
        public async Task<ScaleOutClusterMasterResponse> ScaleOutClusterMaster(ScaleOutClusterMasterRequest req)
        {
             JsonResponseModel<ScaleOutClusterMasterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleOutClusterMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutClusterMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩容独立集群master节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterMasterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterMasterResponse"/></returns>
        public ScaleOutClusterMasterResponse ScaleOutClusterMasterSync(ScaleOutClusterMasterRequest req)
        {
             JsonResponseModel<ScaleOutClusterMasterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleOutClusterMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutClusterMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仅能设置节点池中处于伸缩组的节点
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public async Task<SetNodePoolNodeProtectionResponse> SetNodePoolNodeProtection(SetNodePoolNodeProtectionRequest req)
        {
             JsonResponseModel<SetNodePoolNodeProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetNodePoolNodeProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNodePoolNodeProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 仅能设置节点池中处于伸缩组的节点
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public SetNodePoolNodeProtectionResponse SetNodePoolNodeProtectionSync(SetNodePoolNodeProtectionRequest req)
        {
             JsonResponseModel<SetNodePoolNodeProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetNodePoolNodeProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNodePoolNodeProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步模板到实例或者集群，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public async Task<SyncPrometheusTempResponse> SyncPrometheusTemp(SyncPrometheusTempRequest req)
        {
             JsonResponseModel<SyncPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步模板到实例或者集群，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public SyncPrometheusTempResponse SyncPrometheusTempSync(SyncPrometheusTempRequest req)
        {
             JsonResponseModel<SyncPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步模板到实例或者集群
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTemplateRequest"/></param>
        /// <returns><see cref="SyncPrometheusTemplateResponse"/></returns>
        public async Task<SyncPrometheusTemplateResponse> SyncPrometheusTemplate(SyncPrometheusTemplateRequest req)
        {
             JsonResponseModel<SyncPrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncPrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步模板到实例或者集群
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTemplateRequest"/></param>
        /// <returns><see cref="SyncPrometheusTemplateResponse"/></returns>
        public SyncPrometheusTemplateResponse SyncPrometheusTemplateSync(SyncPrometheusTemplateRequest req)
        {
             JsonResponseModel<SyncPrometheusTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncPrometheusTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPrometheusTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中集群删除某个应用
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterReleaseRequest"/></param>
        /// <returns><see cref="UninstallClusterReleaseResponse"/></returns>
        public async Task<UninstallClusterReleaseResponse> UninstallClusterRelease(UninstallClusterReleaseRequest req)
        {
             JsonResponseModel<UninstallClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UninstallClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在应用市场中集群删除某个应用
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterReleaseRequest"/></param>
        /// <returns><see cref="UninstallClusterReleaseResponse"/></returns>
        public UninstallClusterReleaseResponse UninstallClusterReleaseSync(UninstallClusterReleaseRequest req)
        {
             JsonResponseModel<UninstallClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UninstallClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从tke@edge集群边缘节点上卸载日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="UninstallEdgeLogAgentResponse"/></returns>
        public async Task<UninstallEdgeLogAgentResponse> UninstallEdgeLogAgent(UninstallEdgeLogAgentRequest req)
        {
             JsonResponseModel<UninstallEdgeLogAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UninstallEdgeLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallEdgeLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从tke@edge集群边缘节点上卸载日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="UninstallEdgeLogAgentResponse"/></returns>
        public UninstallEdgeLogAgentResponse UninstallEdgeLogAgentSync(UninstallEdgeLogAgentRequest req)
        {
             JsonResponseModel<UninstallEdgeLogAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UninstallEdgeLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallEdgeLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从TKE集群中卸载CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallLogAgentRequest"/></param>
        /// <returns><see cref="UninstallLogAgentResponse"/></returns>
        public async Task<UninstallLogAgentResponse> UninstallLogAgent(UninstallLogAgentRequest req)
        {
             JsonResponseModel<UninstallLogAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UninstallLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从TKE集群中卸载CLS日志采集组件
        /// </summary>
        /// <param name="req"><see cref="UninstallLogAgentRequest"/></param>
        /// <returns><see cref="UninstallLogAgentResponse"/></returns>
        public UninstallLogAgentResponse UninstallLogAgentSync(UninstallLogAgentRequest req)
        {
             JsonResponseModel<UninstallLogAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UninstallLogAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallLogAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新一个addon的参数和版本
        /// </summary>
        /// <param name="req"><see cref="UpdateAddonRequest"/></param>
        /// <returns><see cref="UpdateAddonResponse"/></returns>
        public async Task<UpdateAddonResponse> UpdateAddon(UpdateAddonRequest req)
        {
             JsonResponseModel<UpdateAddonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新一个addon的参数和版本
        /// </summary>
        /// <param name="req"><see cref="UpdateAddonRequest"/></param>
        /// <returns><see cref="UpdateAddonResponse"/></returns>
        public UpdateAddonResponse UpdateAddonSync(UpdateAddonRequest req)
        {
             JsonResponseModel<UpdateAddonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAddon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAddonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集群的Kubeconfig信息进行更新
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterKubeconfigRequest"/></param>
        /// <returns><see cref="UpdateClusterKubeconfigResponse"/></returns>
        public async Task<UpdateClusterKubeconfigResponse> UpdateClusterKubeconfig(UpdateClusterKubeconfigRequest req)
        {
             JsonResponseModel<UpdateClusterKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateClusterKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClusterKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集群的Kubeconfig信息进行更新
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterKubeconfigRequest"/></param>
        /// <returns><see cref="UpdateClusterKubeconfigResponse"/></returns>
        public UpdateClusterKubeconfigResponse UpdateClusterKubeconfigSync(UpdateClusterKubeconfigRequest req)
        {
             JsonResponseModel<UpdateClusterKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateClusterKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClusterKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级集群 Master 组件到指定版本
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public async Task<UpdateClusterVersionResponse> UpdateClusterVersion(UpdateClusterVersionRequest req)
        {
             JsonResponseModel<UpdateClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级集群 Master 组件到指定版本
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public UpdateClusterVersionResponse UpdateClusterVersionSync(UpdateClusterVersionRequest req)
        {
             JsonResponseModel<UpdateClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改弹性集群名称等属性 
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSClusterRequest"/></param>
        /// <returns><see cref="UpdateEKSClusterResponse"/></returns>
        public async Task<UpdateEKSClusterResponse> UpdateEKSCluster(UpdateEKSClusterRequest req)
        {
             JsonResponseModel<UpdateEKSClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEKSCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEKSClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改弹性集群名称等属性 
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSClusterRequest"/></param>
        /// <returns><see cref="UpdateEKSClusterResponse"/></returns>
        public UpdateEKSClusterResponse UpdateEKSClusterSync(UpdateEKSClusterRequest req)
        {
             JsonResponseModel<UpdateEKSClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEKSCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEKSClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新容器实例
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSContainerInstanceRequest"/></param>
        /// <returns><see cref="UpdateEKSContainerInstanceResponse"/></returns>
        public async Task<UpdateEKSContainerInstanceResponse> UpdateEKSContainerInstance(UpdateEKSContainerInstanceRequest req)
        {
             JsonResponseModel<UpdateEKSContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEKSContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEKSContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新容器实例
        /// </summary>
        /// <param name="req"><see cref="UpdateEKSContainerInstanceRequest"/></param>
        /// <returns><see cref="UpdateEKSContainerInstanceResponse"/></returns>
        public UpdateEKSContainerInstanceResponse UpdateEKSContainerInstanceSync(UpdateEKSContainerInstanceRequest req)
        {
             JsonResponseModel<UpdateEKSContainerInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEKSContainerInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEKSContainerInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级边缘集群组件到指定版本，此版本为TKEEdge专用版本。
        /// </summary>
        /// <param name="req"><see cref="UpdateEdgeClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateEdgeClusterVersionResponse"/></returns>
        public async Task<UpdateEdgeClusterVersionResponse> UpdateEdgeClusterVersion(UpdateEdgeClusterVersionRequest req)
        {
             JsonResponseModel<UpdateEdgeClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEdgeClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEdgeClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级边缘集群组件到指定版本，此版本为TKEEdge专用版本。
        /// </summary>
        /// <param name="req"><see cref="UpdateEdgeClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateEdgeClusterVersionResponse"/></returns>
        public UpdateEdgeClusterVersionResponse UpdateEdgeClusterVersionSync(UpdateEdgeClusterVersionRequest req)
        {
             JsonResponseModel<UpdateEdgeClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEdgeClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEdgeClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新镜像缓存接口
        /// </summary>
        /// <param name="req"><see cref="UpdateImageCacheRequest"/></param>
        /// <returns><see cref="UpdateImageCacheResponse"/></returns>
        public async Task<UpdateImageCacheResponse> UpdateImageCache(UpdateImageCacheRequest req)
        {
             JsonResponseModel<UpdateImageCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateImageCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateImageCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新镜像缓存接口
        /// </summary>
        /// <param name="req"><see cref="UpdateImageCacheRequest"/></param>
        /// <returns><see cref="UpdateImageCacheResponse"/></returns>
        public UpdateImageCacheResponse UpdateImageCacheSync(UpdateImageCacheRequest req)
        {
             JsonResponseModel<UpdateImageCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateImageCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateImageCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘计算集群名称等属性
        /// </summary>
        /// <param name="req"><see cref="UpdateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="UpdateTKEEdgeClusterResponse"/></returns>
        public async Task<UpdateTKEEdgeClusterResponse> UpdateTKEEdgeCluster(UpdateTKEEdgeClusterRequest req)
        {
             JsonResponseModel<UpdateTKEEdgeClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateTKEEdgeCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTKEEdgeClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘计算集群名称等属性
        /// </summary>
        /// <param name="req"><see cref="UpdateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="UpdateTKEEdgeClusterResponse"/></returns>
        public UpdateTKEEdgeClusterResponse UpdateTKEEdgeClusterSync(UpdateTKEEdgeClusterRequest req)
        {
             JsonResponseModel<UpdateTKEEdgeClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateTKEEdgeCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTKEEdgeClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给集群的一批work节点进行升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public async Task<UpgradeClusterInstancesResponse> UpgradeClusterInstances(UpgradeClusterInstancesRequest req)
        {
             JsonResponseModel<UpgradeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给集群的一批work节点进行升级
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public UpgradeClusterInstancesResponse UpgradeClusterInstancesSync(UpgradeClusterInstancesRequest req)
        {
             JsonResponseModel<UpgradeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级集群中已安装的应用
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterReleaseRequest"/></param>
        /// <returns><see cref="UpgradeClusterReleaseResponse"/></returns>
        public async Task<UpgradeClusterReleaseResponse> UpgradeClusterRelease(UpgradeClusterReleaseRequest req)
        {
             JsonResponseModel<UpgradeClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级集群中已安装的应用
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterReleaseRequest"/></param>
        /// <returns><see cref="UpgradeClusterReleaseResponse"/></returns>
        public UpgradeClusterReleaseResponse UpgradeClusterReleaseSync(UpgradeClusterReleaseRequest req)
        {
             JsonResponseModel<UpgradeClusterReleaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeClusterRelease");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeClusterReleaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
