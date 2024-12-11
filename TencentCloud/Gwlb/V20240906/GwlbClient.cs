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

namespace TencentCloud.Gwlb.V20240906
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gwlb.V20240906.Models;

   public class GwlbClient : AbstractClient{

       private const string endpoint = "gwlb.tencentcloudapi.com";
       private const string version = "2024-09-06";
       private const string sdkVersion = "SDK_NET_3.0.1140";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GwlbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GwlbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(AssociateTargetGroups)用来将目标组绑定到负载均衡。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public Task<AssociateTargetGroupsResponse> AssociateTargetGroups(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups");
        }

        /// <summary>
        /// 本接口(AssociateTargetGroups)用来将目标组绑定到负载均衡。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public AssociateTargetGroupsResponse AssociateTargetGroupsSync(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateGatewayLoadBalancer)用来创建网关负载均衡实例。为了使用网关负载均衡服务，您必须购买一个或多个网关负载均衡实例。成功调用该接口后，会返回网关负载均衡实例的唯一 ID。
        /// 注意：单个账号在每个地域的默认购买配额为：10个。
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeGatewayLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateGatewayLoadBalancerResponse"/></returns>
        public Task<CreateGatewayLoadBalancerResponse> CreateGatewayLoadBalancer(CreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateGatewayLoadBalancerResponse>(req, "CreateGatewayLoadBalancer");
        }

        /// <summary>
        /// 本接口(CreateGatewayLoadBalancer)用来创建网关负载均衡实例。为了使用网关负载均衡服务，您必须购买一个或多个网关负载均衡实例。成功调用该接口后，会返回网关负载均衡实例的唯一 ID。
        /// 注意：单个账号在每个地域的默认购买配额为：10个。
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeGatewayLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateGatewayLoadBalancerResponse"/></returns>
        public CreateGatewayLoadBalancerResponse CreateGatewayLoadBalancerSync(CreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateGatewayLoadBalancerResponse>(req, "CreateGatewayLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建目标组。该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup");
        }

        /// <summary>
        /// 创建目标组。该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteGatewayLoadBalancer 接口用以删除指定的一个或多个网关负载均衡实例。成功删除后，会把网关负载均衡实例与后端服务解绑。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteGatewayLoadBalancerResponse"/></returns>
        public Task<DeleteGatewayLoadBalancerResponse> DeleteGatewayLoadBalancer(DeleteGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteGatewayLoadBalancerResponse>(req, "DeleteGatewayLoadBalancer");
        }

        /// <summary>
        /// DeleteGatewayLoadBalancer 接口用以删除指定的一个或多个网关负载均衡实例。成功删除后，会把网关负载均衡实例与后端服务解绑。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteGatewayLoadBalancerResponse"/></returns>
        public DeleteGatewayLoadBalancerResponse DeleteGatewayLoadBalancerSync(DeleteGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteGatewayLoadBalancerResponse>(req, "DeleteGatewayLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除目标组
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups");
        }

        /// <summary>
        /// 删除目标组
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从目标组中解绑服务器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public Task<DeregisterTargetGroupInstancesResponse> DeregisterTargetGroupInstances(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances");
        }

        /// <summary>
        /// 从目标组中解绑服务器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public DeregisterTargetGroupInstancesResponse DeregisterTargetGroupInstancesSync(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询一个地域的网关负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeGatewayLoadBalancersResponse"/></returns>
        public Task<DescribeGatewayLoadBalancersResponse> DescribeGatewayLoadBalancers(DescribeGatewayLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeGatewayLoadBalancersResponse>(req, "DescribeGatewayLoadBalancers");
        }

        /// <summary>
        /// 查询一个地域的网关负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeGatewayLoadBalancersResponse"/></returns>
        public DescribeGatewayLoadBalancersResponse DescribeGatewayLoadBalancersSync(DescribeGatewayLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeGatewayLoadBalancersResponse>(req, "DescribeGatewayLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目标组后端服务状态。目前仅支持网关负载均衡类型的目标组支持查询后端服务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstanceStatusResponse"/></returns>
        public Task<DescribeTargetGroupInstanceStatusResponse> DescribeTargetGroupInstanceStatus(DescribeTargetGroupInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstanceStatusResponse>(req, "DescribeTargetGroupInstanceStatus");
        }

        /// <summary>
        /// 查询目标组后端服务状态。目前仅支持网关负载均衡类型的目标组支持查询后端服务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstanceStatusResponse"/></returns>
        public DescribeTargetGroupInstanceStatusResponse DescribeTargetGroupInstanceStatusSync(DescribeTargetGroupInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstanceStatusResponse>(req, "DescribeTargetGroupInstanceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取目标组绑定的服务器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public Task<DescribeTargetGroupInstancesResponse> DescribeTargetGroupInstances(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances");
        }

        /// <summary>
        /// 获取目标组绑定的服务器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public DescribeTargetGroupInstancesResponse DescribeTargetGroupInstancesSync(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public Task<DescribeTargetGroupListResponse> DescribeTargetGroupList(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList");
        }

        /// <summary>
        /// 获取目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public DescribeTargetGroupListResponse DescribeTargetGroupListSync(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目标组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups");
        }

        /// <summary>
        /// 查询目标组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询异步任务的执行状态，对于非查询类的接口（创建/删除负载均衡实例等），在接口调用成功后，都需要使用本接口查询任务最终是否执行成功。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 本接口用于查询异步任务的执行状态，对于非查询类的接口（创建/删除负载均衡实例等），在接口调用成功后，都需要使用本接口查询任务最终是否执行成功。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除负载均衡和目标组的关联关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public Task<DisassociateTargetGroupsResponse> DisassociateTargetGroups(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups");
        }

        /// <summary>
        /// 解除负载均衡和目标组的关联关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public DisassociateTargetGroupsResponse DisassociateTargetGroupsSync(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// InquirePriceCreateGatewayLoadBalancer接口查询创建网关负载均衡的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateGatewayLoadBalancerResponse"/></returns>
        public Task<InquirePriceCreateGatewayLoadBalancerResponse> InquirePriceCreateGatewayLoadBalancer(InquirePriceCreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateGatewayLoadBalancerResponse>(req, "InquirePriceCreateGatewayLoadBalancer");
        }

        /// <summary>
        /// InquirePriceCreateGatewayLoadBalancer接口查询创建网关负载均衡的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateGatewayLoadBalancerResponse"/></returns>
        public InquirePriceCreateGatewayLoadBalancerResponse InquirePriceCreateGatewayLoadBalancerSync(InquirePriceCreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateGatewayLoadBalancerResponse>(req, "InquirePriceCreateGatewayLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyGatewayLoadBalancerAttribute 接口用于修改负载均衡实例的属性。支持修改负载均衡实例的名称、带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayLoadBalancerAttributeRequest"/></param>
        /// <returns><see cref="ModifyGatewayLoadBalancerAttributeResponse"/></returns>
        public Task<ModifyGatewayLoadBalancerAttributeResponse> ModifyGatewayLoadBalancerAttribute(ModifyGatewayLoadBalancerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyGatewayLoadBalancerAttributeResponse>(req, "ModifyGatewayLoadBalancerAttribute");
        }

        /// <summary>
        /// ModifyGatewayLoadBalancerAttribute 接口用于修改负载均衡实例的属性。支持修改负载均衡实例的名称、带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayLoadBalancerAttributeRequest"/></param>
        /// <returns><see cref="ModifyGatewayLoadBalancerAttributeResponse"/></returns>
        public ModifyGatewayLoadBalancerAttributeResponse ModifyGatewayLoadBalancerAttributeSync(ModifyGatewayLoadBalancerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyGatewayLoadBalancerAttributeResponse>(req, "ModifyGatewayLoadBalancerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改目标组的名称、健康探测等属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public Task<ModifyTargetGroupAttributeResponse> ModifyTargetGroupAttribute(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute");
        }

        /// <summary>
        /// 修改目标组的名称、健康探测等属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public ModifyTargetGroupAttributeResponse ModifyTargetGroupAttributeSync(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改目标组的服务器权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public Task<ModifyTargetGroupInstancesWeightResponse> ModifyTargetGroupInstancesWeight(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight");
        }

        /// <summary>
        /// 修改目标组的服务器权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public ModifyTargetGroupInstancesWeightResponse ModifyTargetGroupInstancesWeightSync(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册服务器到目标组。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public Task<RegisterTargetGroupInstancesResponse> RegisterTargetGroupInstances(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances");
        }

        /// <summary>
        /// 注册服务器到目标组。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public RegisterTargetGroupInstancesResponse RegisterTargetGroupInstancesSync(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
