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
        /// 为已经存在的集群创建伸缩组
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAsGroupRequest"/></param>
        /// <returns><see cref="CreateClusterAsGroupResponse"/></returns>
        public async Task<CreateClusterAsGroupResponse> CreateClusterAsGroup(CreateClusterAsGroupRequest req)
        {
             JsonResponseModel<CreateClusterAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为已经存在的集群创建伸缩组
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAsGroupRequest"/></param>
        /// <returns><see cref="CreateClusterAsGroupResponse"/></returns>
        public CreateClusterAsGroupResponse CreateClusterAsGroupSync(CreateClusterAsGroupRequest req)
        {
             JsonResponseModel<CreateClusterAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群访问端口(独立集群开启内网/外网访问，托管集群支持开启内网访问)
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
        /// 创建集群访问端口(独立集群开启内网/外网访问，托管集群支持开启内网访问)
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
        /// 从伸缩组创建节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolFromExistingAsgRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolFromExistingAsgResponse"/></returns>
        public async Task<CreateClusterNodePoolFromExistingAsgResponse> CreateClusterNodePoolFromExistingAsg(CreateClusterNodePoolFromExistingAsgRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterNodePoolFromExistingAsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从伸缩组创建节点池
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolFromExistingAsgRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolFromExistingAsgResponse"/></returns>
        public CreateClusterNodePoolFromExistingAsgResponse CreateClusterNodePoolFromExistingAsgSync(CreateClusterNodePoolFromExistingAsgRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterNodePoolFromExistingAsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse>>(strResp);
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
        /// 删除集群访问端口(独立集群开启内网/外网访问，托管集群支持开启内网访问)
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
        /// 删除集群访问端口(独立集群开启内网/外网访问，托管集群支持开启内网访问)
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
        ///  查询集群下节点实例信息 
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
        ///  查询集群下节点实例信息 
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

    }
}
