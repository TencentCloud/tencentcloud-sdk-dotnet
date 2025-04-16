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

namespace TencentCloud.Bmvpc.V20180625
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bmvpc.V20180625.Models;

   public class BmvpcClient : AbstractClient{

       private const string endpoint = "bmvpc.tencentcloudapi.com";
       private const string version = "2018-06-25";
       private const string sdkVersion = "SDK_NET_3.0.1222";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmvpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmvpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 接受黑石对等连接
        /// </summary>
        /// <param name="req"><see cref="AcceptVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="AcceptVpcPeerConnectionResponse"/></returns>
        public Task<AcceptVpcPeerConnectionResponse> AcceptVpcPeerConnection(AcceptVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<AcceptVpcPeerConnectionResponse>(req, "AcceptVpcPeerConnection");
        }

        /// <summary>
        /// 接受黑石对等连接
        /// </summary>
        /// <param name="req"><see cref="AcceptVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="AcceptVpcPeerConnectionResponse"/></returns>
        public AcceptVpcPeerConnectionResponse AcceptVpcPeerConnectionSync(AcceptVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<AcceptVpcPeerConnectionResponse>(req, "AcceptVpcPeerConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量注册虚拟IP，异步接口。通过接口来查询任务进度。每次请求最多注册256个IP
        /// </summary>
        /// <param name="req"><see cref="AsyncRegisterIpsRequest"/></param>
        /// <returns><see cref="AsyncRegisterIpsResponse"/></returns>
        public Task<AsyncRegisterIpsResponse> AsyncRegisterIps(AsyncRegisterIpsRequest req)
        {
            return InternalRequestAsync<AsyncRegisterIpsResponse>(req, "AsyncRegisterIps");
        }

        /// <summary>
        /// 批量注册虚拟IP，异步接口。通过接口来查询任务进度。每次请求最多注册256个IP
        /// </summary>
        /// <param name="req"><see cref="AsyncRegisterIpsRequest"/></param>
        /// <returns><see cref="AsyncRegisterIpsResponse"/></returns>
        public AsyncRegisterIpsResponse AsyncRegisterIpsSync(AsyncRegisterIpsRequest req)
        {
            return InternalRequestAsync<AsyncRegisterIpsResponse>(req, "AsyncRegisterIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// NAT网关绑定EIP接口，可将EIP绑定到NAT网关，该EIP作为访问外网的源IP地址，将流量发送到Internet
        /// </summary>
        /// <param name="req"><see cref="BindEipsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindEipsToNatGatewayResponse"/></returns>
        public Task<BindEipsToNatGatewayResponse> BindEipsToNatGateway(BindEipsToNatGatewayRequest req)
        {
            return InternalRequestAsync<BindEipsToNatGatewayResponse>(req, "BindEipsToNatGateway");
        }

        /// <summary>
        /// NAT网关绑定EIP接口，可将EIP绑定到NAT网关，该EIP作为访问外网的源IP地址，将流量发送到Internet
        /// </summary>
        /// <param name="req"><see cref="BindEipsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindEipsToNatGatewayResponse"/></returns>
        public BindEipsToNatGatewayResponse BindEipsToNatGatewaySync(BindEipsToNatGatewayRequest req)
        {
            return InternalRequestAsync<BindEipsToNatGatewayResponse>(req, "BindEipsToNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可用于将子网的部分IP绑定到NAT网关
        /// </summary>
        /// <param name="req"><see cref="BindIpsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindIpsToNatGatewayResponse"/></returns>
        public Task<BindIpsToNatGatewayResponse> BindIpsToNatGateway(BindIpsToNatGatewayRequest req)
        {
            return InternalRequestAsync<BindIpsToNatGatewayResponse>(req, "BindIpsToNatGateway");
        }

        /// <summary>
        /// 可用于将子网的部分IP绑定到NAT网关
        /// </summary>
        /// <param name="req"><see cref="BindIpsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindIpsToNatGatewayResponse"/></returns>
        public BindIpsToNatGatewayResponse BindIpsToNatGatewaySync(BindIpsToNatGatewayRequest req)
        {
            return InternalRequestAsync<BindIpsToNatGatewayResponse>(req, "BindIpsToNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// NAT网关绑定子网后，该子网内全部IP可出公网
        /// </summary>
        /// <param name="req"><see cref="BindSubnetsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindSubnetsToNatGatewayResponse"/></returns>
        public Task<BindSubnetsToNatGatewayResponse> BindSubnetsToNatGateway(BindSubnetsToNatGatewayRequest req)
        {
            return InternalRequestAsync<BindSubnetsToNatGatewayResponse>(req, "BindSubnetsToNatGateway");
        }

        /// <summary>
        /// NAT网关绑定子网后，该子网内全部IP可出公网
        /// </summary>
        /// <param name="req"><see cref="BindSubnetsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindSubnetsToNatGatewayResponse"/></returns>
        public BindSubnetsToNatGatewayResponse BindSubnetsToNatGatewaySync(BindSubnetsToNatGatewayRequest req)
        {
            return InternalRequestAsync<BindSubnetsToNatGatewayResponse>(req, "BindSubnetsToNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCustomerGateway）用于创建对端网关。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
        public Task<CreateCustomerGatewayResponse> CreateCustomerGateway(CreateCustomerGatewayRequest req)
        {
            return InternalRequestAsync<CreateCustomerGatewayResponse>(req, "CreateCustomerGateway");
        }

        /// <summary>
        /// 本接口（CreateCustomerGateway）用于创建对端网关。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
        public CreateCustomerGatewayResponse CreateCustomerGatewaySync(CreateCustomerGatewayRequest req)
        {
            return InternalRequestAsync<CreateCustomerGatewayResponse>(req, "CreateCustomerGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石Docker子网， 如果不指定VlanId，将会分配2000--2999范围的VlanId; 子网会关闭分布式网关
        /// </summary>
        /// <param name="req"><see cref="CreateDockerSubnetWithVlanRequest"/></param>
        /// <returns><see cref="CreateDockerSubnetWithVlanResponse"/></returns>
        public Task<CreateDockerSubnetWithVlanResponse> CreateDockerSubnetWithVlan(CreateDockerSubnetWithVlanRequest req)
        {
            return InternalRequestAsync<CreateDockerSubnetWithVlanResponse>(req, "CreateDockerSubnetWithVlan");
        }

        /// <summary>
        /// 创建黑石Docker子网， 如果不指定VlanId，将会分配2000--2999范围的VlanId; 子网会关闭分布式网关
        /// </summary>
        /// <param name="req"><see cref="CreateDockerSubnetWithVlanRequest"/></param>
        /// <returns><see cref="CreateDockerSubnetWithVlanResponse"/></returns>
        public CreateDockerSubnetWithVlanResponse CreateDockerSubnetWithVlanSync(CreateDockerSubnetWithVlanRequest req)
        {
            return InternalRequestAsync<CreateDockerSubnetWithVlanResponse>(req, "CreateDockerSubnetWithVlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateHostedInterface）用于黑石托管机器加入带VLANID不为5的子网。
        /// 
        /// 1) 不能加入vlanId 为5的子网，只能加入VLANID范围为2000-2999的子网。
        /// 2) 每台托管机器最多可以加入20个子网。
        /// 3) 每次调用最多能支持传入10台托管机器。
        /// </summary>
        /// <param name="req"><see cref="CreateHostedInterfaceRequest"/></param>
        /// <returns><see cref="CreateHostedInterfaceResponse"/></returns>
        public Task<CreateHostedInterfaceResponse> CreateHostedInterface(CreateHostedInterfaceRequest req)
        {
            return InternalRequestAsync<CreateHostedInterfaceResponse>(req, "CreateHostedInterface");
        }

        /// <summary>
        /// 本接口（CreateHostedInterface）用于黑石托管机器加入带VLANID不为5的子网。
        /// 
        /// 1) 不能加入vlanId 为5的子网，只能加入VLANID范围为2000-2999的子网。
        /// 2) 每台托管机器最多可以加入20个子网。
        /// 3) 每次调用最多能支持传入10台托管机器。
        /// </summary>
        /// <param name="req"><see cref="CreateHostedInterfaceRequest"/></param>
        /// <returns><see cref="CreateHostedInterfaceResponse"/></returns>
        public CreateHostedInterfaceResponse CreateHostedInterfaceSync(CreateHostedInterfaceRequest req)
        {
            return InternalRequestAsync<CreateHostedInterfaceResponse>(req, "CreateHostedInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 物理机加入子网
        /// </summary>
        /// <param name="req"><see cref="CreateInterfacesRequest"/></param>
        /// <returns><see cref="CreateInterfacesResponse"/></returns>
        public Task<CreateInterfacesResponse> CreateInterfaces(CreateInterfacesRequest req)
        {
            return InternalRequestAsync<CreateInterfacesResponse>(req, "CreateInterfaces");
        }

        /// <summary>
        /// 物理机加入子网
        /// </summary>
        /// <param name="req"><see cref="CreateInterfacesRequest"/></param>
        /// <returns><see cref="CreateInterfacesResponse"/></returns>
        public CreateInterfacesResponse CreateInterfacesSync(CreateInterfacesRequest req)
        {
            return InternalRequestAsync<CreateInterfacesResponse>(req, "CreateInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建NAT网关接口，可针对网段方式、子网全部IP、子网部分IP这三种方式创建NAT网关
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public Task<CreateNatGatewayResponse> CreateNatGateway(CreateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayResponse>(req, "CreateNatGateway");
        }

        /// <summary>
        /// 创建NAT网关接口，可针对网段方式、子网全部IP、子网部分IP这三种方式创建NAT网关
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public CreateNatGatewayResponse CreateNatGatewaySync(CreateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayResponse>(req, "CreateNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石路由表的路由规则
        /// </summary>
        /// <param name="req"><see cref="CreateRoutePoliciesRequest"/></param>
        /// <returns><see cref="CreateRoutePoliciesResponse"/></returns>
        public Task<CreateRoutePoliciesResponse> CreateRoutePolicies(CreateRoutePoliciesRequest req)
        {
            return InternalRequestAsync<CreateRoutePoliciesResponse>(req, "CreateRoutePolicies");
        }

        /// <summary>
        /// 创建黑石路由表的路由规则
        /// </summary>
        /// <param name="req"><see cref="CreateRoutePoliciesRequest"/></param>
        /// <returns><see cref="CreateRoutePoliciesResponse"/></returns>
        public CreateRoutePoliciesResponse CreateRoutePoliciesSync(CreateRoutePoliciesRequest req)
        {
            return InternalRequestAsync<CreateRoutePoliciesResponse>(req, "CreateRoutePolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石私有网络的子网
        /// 访问管理: 用户可以对VpcId进行授权操作。例如设置资源为["qcs::bmvpc:::unVpc/vpc-xxxxx"]
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet");
        }

        /// <summary>
        /// 创建黑石私有网络的子网
        /// 访问管理: 用户可以对VpcId进行授权操作。例如设置资源为["qcs::bmvpc:::unVpc/vpc-xxxxx"]
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public CreateSubnetResponse CreateSubnetSync(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石虚拟子网， 虚拟子网用于在黑石上创建虚拟网络，与黑石子网要做好规划。虚拟子网会分配2000-2999的VlanId。
        /// </summary>
        /// <param name="req"><see cref="CreateVirtualSubnetWithVlanRequest"/></param>
        /// <returns><see cref="CreateVirtualSubnetWithVlanResponse"/></returns>
        public Task<CreateVirtualSubnetWithVlanResponse> CreateVirtualSubnetWithVlan(CreateVirtualSubnetWithVlanRequest req)
        {
            return InternalRequestAsync<CreateVirtualSubnetWithVlanResponse>(req, "CreateVirtualSubnetWithVlan");
        }

        /// <summary>
        /// 创建黑石虚拟子网， 虚拟子网用于在黑石上创建虚拟网络，与黑石子网要做好规划。虚拟子网会分配2000-2999的VlanId。
        /// </summary>
        /// <param name="req"><see cref="CreateVirtualSubnetWithVlanRequest"/></param>
        /// <returns><see cref="CreateVirtualSubnetWithVlanResponse"/></returns>
        public CreateVirtualSubnetWithVlanResponse CreateVirtualSubnetWithVlanSync(CreateVirtualSubnetWithVlanRequest req)
        {
            return InternalRequestAsync<CreateVirtualSubnetWithVlanResponse>(req, "CreateVirtualSubnetWithVlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石私有网络
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc");
        }

        /// <summary>
        /// 创建黑石私有网络
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public CreateVpcResponse CreateVpcSync(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建对等连接
        /// </summary>
        /// <param name="req"><see cref="CreateVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="CreateVpcPeerConnectionResponse"/></returns>
        public Task<CreateVpcPeerConnectionResponse> CreateVpcPeerConnection(CreateVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<CreateVpcPeerConnectionResponse>(req, "CreateVpcPeerConnection");
        }

        /// <summary>
        /// 创建对等连接
        /// </summary>
        /// <param name="req"><see cref="CreateVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="CreateVpcPeerConnectionResponse"/></returns>
        public CreateVpcPeerConnectionResponse CreateVpcPeerConnectionSync(CreateVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<CreateVpcPeerConnectionResponse>(req, "CreateVpcPeerConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCustomerGateway）用于删除对端网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
        public Task<DeleteCustomerGatewayResponse> DeleteCustomerGateway(DeleteCustomerGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCustomerGatewayResponse>(req, "DeleteCustomerGateway");
        }

        /// <summary>
        /// 本接口（DeleteCustomerGateway）用于删除对端网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
        public DeleteCustomerGatewayResponse DeleteCustomerGatewaySync(DeleteCustomerGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCustomerGatewayResponse>(req, "DeleteCustomerGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于托管机器从VLANID不为5的子网中移除。
        /// 1) 不能从vlanId 为5的子网中移除。
        /// 2) 每次调用最多能支持传入10台物理机。
        /// </summary>
        /// <param name="req"><see cref="DeleteHostedInterfaceRequest"/></param>
        /// <returns><see cref="DeleteHostedInterfaceResponse"/></returns>
        public Task<DeleteHostedInterfaceResponse> DeleteHostedInterface(DeleteHostedInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteHostedInterfaceResponse>(req, "DeleteHostedInterface");
        }

        /// <summary>
        /// 本接口用于托管机器从VLANID不为5的子网中移除。
        /// 1) 不能从vlanId 为5的子网中移除。
        /// 2) 每次调用最多能支持传入10台物理机。
        /// </summary>
        /// <param name="req"><see cref="DeleteHostedInterfaceRequest"/></param>
        /// <returns><see cref="DeleteHostedInterfaceResponse"/></returns>
        public DeleteHostedInterfaceResponse DeleteHostedInterfaceSync(DeleteHostedInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteHostedInterfaceResponse>(req, "DeleteHostedInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 托管机器移除子网批量接口，传入一台托管机器和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req"><see cref="DeleteHostedInterfacesRequest"/></param>
        /// <returns><see cref="DeleteHostedInterfacesResponse"/></returns>
        public Task<DeleteHostedInterfacesResponse> DeleteHostedInterfaces(DeleteHostedInterfacesRequest req)
        {
            return InternalRequestAsync<DeleteHostedInterfacesResponse>(req, "DeleteHostedInterfaces");
        }

        /// <summary>
        /// 托管机器移除子网批量接口，传入一台托管机器和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req"><see cref="DeleteHostedInterfacesRequest"/></param>
        /// <returns><see cref="DeleteHostedInterfacesResponse"/></returns>
        public DeleteHostedInterfacesResponse DeleteHostedInterfacesSync(DeleteHostedInterfacesRequest req)
        {
            return InternalRequestAsync<DeleteHostedInterfacesResponse>(req, "DeleteHostedInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 物理机移除子网批量接口，传入一台物理机和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req"><see cref="DeleteInterfacesRequest"/></param>
        /// <returns><see cref="DeleteInterfacesResponse"/></returns>
        public Task<DeleteInterfacesResponse> DeleteInterfaces(DeleteInterfacesRequest req)
        {
            return InternalRequestAsync<DeleteInterfacesResponse>(req, "DeleteInterfaces");
        }

        /// <summary>
        /// 物理机移除子网批量接口，传入一台物理机和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req"><see cref="DeleteInterfacesRequest"/></param>
        /// <returns><see cref="DeleteInterfacesResponse"/></returns>
        public DeleteInterfacesResponse DeleteInterfacesSync(DeleteInterfacesRequest req)
        {
            return InternalRequestAsync<DeleteInterfacesResponse>(req, "DeleteInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除NAT网关
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public Task<DeleteNatGatewayResponse> DeleteNatGateway(DeleteNatGatewayRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayResponse>(req, "DeleteNatGateway");
        }

        /// <summary>
        /// 删除NAT网关
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public DeleteNatGatewayResponse DeleteNatGatewaySync(DeleteNatGatewayRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayResponse>(req, "DeleteNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除黑石路由表路由规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutePolicyRequest"/></param>
        /// <returns><see cref="DeleteRoutePolicyResponse"/></returns>
        public Task<DeleteRoutePolicyResponse> DeleteRoutePolicy(DeleteRoutePolicyRequest req)
        {
            return InternalRequestAsync<DeleteRoutePolicyResponse>(req, "DeleteRoutePolicy");
        }

        /// <summary>
        /// 删除黑石路由表路由规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutePolicyRequest"/></param>
        /// <returns><see cref="DeleteRoutePolicyResponse"/></returns>
        public DeleteRoutePolicyResponse DeleteRoutePolicySync(DeleteRoutePolicyRequest req)
        {
            return InternalRequestAsync<DeleteRoutePolicyResponse>(req, "DeleteRoutePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteSubnet）用于删除黑石私有网络子网。
        /// 删除子网前，请清理该子网下所有资源，包括物理机、负载均衡、黑石数据库、弹性IP、NAT网关等资源
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet");
        }

        /// <summary>
        /// 本接口（DeleteSubnet）用于删除黑石私有网络子网。
        /// 删除子网前，请清理该子网下所有资源，包括物理机、负载均衡、黑石数据库、弹性IP、NAT网关等资源
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public DeleteSubnetResponse DeleteSubnetSync(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 退还虚拟IP。此接口只能退还虚拟IP，物理机IP不能退还。
        /// </summary>
        /// <param name="req"><see cref="DeleteVirtualIpRequest"/></param>
        /// <returns><see cref="DeleteVirtualIpResponse"/></returns>
        public Task<DeleteVirtualIpResponse> DeleteVirtualIp(DeleteVirtualIpRequest req)
        {
            return InternalRequestAsync<DeleteVirtualIpResponse>(req, "DeleteVirtualIp");
        }

        /// <summary>
        /// 退还虚拟IP。此接口只能退还虚拟IP，物理机IP不能退还。
        /// </summary>
        /// <param name="req"><see cref="DeleteVirtualIpRequest"/></param>
        /// <returns><see cref="DeleteVirtualIpResponse"/></returns>
        public DeleteVirtualIpResponse DeleteVirtualIpSync(DeleteVirtualIpRequest req)
        {
            return InternalRequestAsync<DeleteVirtualIpResponse>(req, "DeleteVirtualIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteVpc)用于删除黑石私有网络(VPC)。
        /// 
        /// 删除私有网络前，请清理该私有网络下所有资源，包括子网、负载均衡、弹性 IP、对等连接、NAT 网关、专线通道、SSLVPN 等资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc");
        }

        /// <summary>
        /// 本接口(DeleteVpc)用于删除黑石私有网络(VPC)。
        /// 
        /// 删除私有网络前，请清理该私有网络下所有资源，包括子网、负载均衡、弹性 IP、对等连接、NAT 网关、专线通道、SSLVPN 等资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public DeleteVpcResponse DeleteVpcSync(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除黑石对等连接
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpcPeerConnectionResponse"/></returns>
        public Task<DeleteVpcPeerConnectionResponse> DeleteVpcPeerConnection(DeleteVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpcPeerConnectionResponse>(req, "DeleteVpcPeerConnection");
        }

        /// <summary>
        /// 删除黑石对等连接
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpcPeerConnectionResponse"/></returns>
        public DeleteVpcPeerConnectionResponse DeleteVpcPeerConnectionSync(DeleteVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpcPeerConnectionResponse>(req, "DeleteVpcPeerConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteVpnConnection)用于删除VPN通道。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
        public Task<DeleteVpnConnectionResponse> DeleteVpnConnection(DeleteVpnConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpnConnectionResponse>(req, "DeleteVpnConnection");
        }

        /// <summary>
        /// 本接口(DeleteVpnConnection)用于删除VPN通道。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
        public DeleteVpnConnectionResponse DeleteVpnConnectionSync(DeleteVpnConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpnConnectionResponse>(req, "DeleteVpnConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpnGateway）用于删除VPN网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
        public Task<DeleteVpnGatewayResponse> DeleteVpnGateway(DeleteVpnGatewayRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayResponse>(req, "DeleteVpnGateway");
        }

        /// <summary>
        /// 本接口（DeleteVpnGateway）用于删除VPN网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
        public DeleteVpnGatewayResponse DeleteVpnGatewaySync(DeleteVpnGatewayRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayResponse>(req, "DeleteVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注销私有网络IP为空闲
        /// </summary>
        /// <param name="req"><see cref="DeregisterIpsRequest"/></param>
        /// <returns><see cref="DeregisterIpsResponse"/></returns>
        public Task<DeregisterIpsResponse> DeregisterIps(DeregisterIpsRequest req)
        {
            return InternalRequestAsync<DeregisterIpsResponse>(req, "DeregisterIps");
        }

        /// <summary>
        /// 注销私有网络IP为空闲
        /// </summary>
        /// <param name="req"><see cref="DeregisterIpsRequest"/></param>
        /// <returns><see cref="DeregisterIpsResponse"/></returns>
        public DeregisterIpsResponse DeregisterIpsSync(DeregisterIpsRequest req)
        {
            return InternalRequestAsync<DeregisterIpsResponse>(req, "DeregisterIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCustomerGateways）用于查询对端网关列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
        public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGateways(DescribeCustomerGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewaysResponse>(req, "DescribeCustomerGateways");
        }

        /// <summary>
        /// 本接口（DescribeCustomerGateways）用于查询对端网关列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
        public DescribeCustomerGatewaysResponse DescribeCustomerGatewaysSync(DescribeCustomerGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewaysResponse>(req, "DescribeCustomerGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取NAT网关信息，包括NAT网关 ID、网关名称、私有网络、网关并发连接上限、绑定EIP列表等
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public Task<DescribeNatGatewaysResponse> DescribeNatGateways(DescribeNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaysResponse>(req, "DescribeNatGateways");
        }

        /// <summary>
        /// 获取NAT网关信息，包括NAT网关 ID、网关名称、私有网络、网关并发连接上限、绑定EIP列表等
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public DescribeNatGatewaysResponse DescribeNatGatewaysSync(DescribeNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaysResponse>(req, "DescribeNatGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可获取NAT网关绑定的子网信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNatSubnetsRequest"/></param>
        /// <returns><see cref="DescribeNatSubnetsResponse"/></returns>
        public Task<DescribeNatSubnetsResponse> DescribeNatSubnets(DescribeNatSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeNatSubnetsResponse>(req, "DescribeNatSubnets");
        }

        /// <summary>
        /// 可获取NAT网关绑定的子网信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNatSubnetsRequest"/></param>
        /// <returns><see cref="DescribeNatSubnetsResponse"/></returns>
        public DescribeNatSubnetsResponse DescribeNatSubnetsSync(DescribeNatSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeNatSubnetsResponse>(req, "DescribeNatSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRoutePolicies）用于查询路由表条目。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoutePoliciesRequest"/></param>
        /// <returns><see cref="DescribeRoutePoliciesResponse"/></returns>
        public Task<DescribeRoutePoliciesResponse> DescribeRoutePolicies(DescribeRoutePoliciesRequest req)
        {
            return InternalRequestAsync<DescribeRoutePoliciesResponse>(req, "DescribeRoutePolicies");
        }

        /// <summary>
        /// 本接口（DescribeRoutePolicies）用于查询路由表条目。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoutePoliciesRequest"/></param>
        /// <returns><see cref="DescribeRoutePoliciesResponse"/></returns>
        public DescribeRoutePoliciesResponse DescribeRoutePoliciesSync(DescribeRoutePoliciesRequest req)
        {
            return InternalRequestAsync<DescribeRoutePoliciesResponse>(req, "DescribeRoutePolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRouteTables）用于查询路由表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public Task<DescribeRouteTablesResponse> DescribeRouteTables(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables");
        }

        /// <summary>
        /// 本接口（DescribeRouteTables）用于查询路由表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public DescribeRouteTablesResponse DescribeRouteTablesSync(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取子网内可用IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAvailableIpsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAvailableIpsResponse"/></returns>
        public Task<DescribeSubnetAvailableIpsResponse> DescribeSubnetAvailableIps(DescribeSubnetAvailableIpsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAvailableIpsResponse>(req, "DescribeSubnetAvailableIps");
        }

        /// <summary>
        /// 获取子网内可用IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAvailableIpsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAvailableIpsResponse"/></returns>
        public DescribeSubnetAvailableIpsResponse DescribeSubnetAvailableIpsSync(DescribeSubnetAvailableIpsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAvailableIpsResponse>(req, "DescribeSubnetAvailableIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 物理机可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询物理机加入的子网。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetByDeviceRequest"/></param>
        /// <returns><see cref="DescribeSubnetByDeviceResponse"/></returns>
        public Task<DescribeSubnetByDeviceResponse> DescribeSubnetByDevice(DescribeSubnetByDeviceRequest req)
        {
            return InternalRequestAsync<DescribeSubnetByDeviceResponse>(req, "DescribeSubnetByDevice");
        }

        /// <summary>
        /// 物理机可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询物理机加入的子网。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetByDeviceRequest"/></param>
        /// <returns><see cref="DescribeSubnetByDeviceResponse"/></returns>
        public DescribeSubnetByDeviceResponse DescribeSubnetByDeviceSync(DescribeSubnetByDeviceRequest req)
        {
            return InternalRequestAsync<DescribeSubnetByDeviceResponse>(req, "DescribeSubnetByDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 托管可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询托管加入的子网。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetByHostedDeviceRequest"/></param>
        /// <returns><see cref="DescribeSubnetByHostedDeviceResponse"/></returns>
        public Task<DescribeSubnetByHostedDeviceResponse> DescribeSubnetByHostedDevice(DescribeSubnetByHostedDeviceRequest req)
        {
            return InternalRequestAsync<DescribeSubnetByHostedDeviceResponse>(req, "DescribeSubnetByHostedDevice");
        }

        /// <summary>
        /// 托管可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询托管加入的子网。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetByHostedDeviceRequest"/></param>
        /// <returns><see cref="DescribeSubnetByHostedDeviceResponse"/></returns>
        public DescribeSubnetByHostedDeviceResponse DescribeSubnetByHostedDeviceSync(DescribeSubnetByHostedDeviceRequest req)
        {
            return InternalRequestAsync<DescribeSubnetByHostedDeviceResponse>(req, "DescribeSubnetByHostedDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSubnets）用于查询黑石子网列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets");
        }

        /// <summary>
        /// 本接口（DescribeSubnets）用于查询黑石子网列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public DescribeSubnetsResponse DescribeSubnetsSync(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID，获取任务的执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 根据任务ID，获取任务的执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取对等连接列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPeerConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpcPeerConnectionsResponse"/></returns>
        public Task<DescribeVpcPeerConnectionsResponse> DescribeVpcPeerConnections(DescribeVpcPeerConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpcPeerConnectionsResponse>(req, "DescribeVpcPeerConnections");
        }

        /// <summary>
        /// 获取对等连接列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPeerConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpcPeerConnectionsResponse"/></returns>
        public DescribeVpcPeerConnectionsResponse DescribeVpcPeerConnectionsSync(DescribeVpcPeerConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpcPeerConnectionsResponse>(req, "DescribeVpcPeerConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcQuota）用于查询用户VPC相关配额限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcQuotaRequest"/></param>
        /// <returns><see cref="DescribeVpcQuotaResponse"/></returns>
        public Task<DescribeVpcQuotaResponse> DescribeVpcQuota(DescribeVpcQuotaRequest req)
        {
            return InternalRequestAsync<DescribeVpcQuotaResponse>(req, "DescribeVpcQuota");
        }

        /// <summary>
        /// 本接口（DescribeVpcQuota）用于查询用户VPC相关配额限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcQuotaRequest"/></param>
        /// <returns><see cref="DescribeVpcQuotaResponse"/></returns>
        public DescribeVpcQuotaResponse DescribeVpcQuotaSync(DescribeVpcQuotaRequest req)
        {
            return InternalRequestAsync<DescribeVpcQuotaResponse>(req, "DescribeVpcQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询黑石私有网络关联资源
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceResponse"/></returns>
        public Task<DescribeVpcResourceResponse> DescribeVpcResource(DescribeVpcResourceRequest req)
        {
            return InternalRequestAsync<DescribeVpcResourceResponse>(req, "DescribeVpcResource");
        }

        /// <summary>
        /// 查询黑石私有网络关联资源
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceResponse"/></returns>
        public DescribeVpcResourceResponse DescribeVpcResourceSync(DescribeVpcResourceRequest req)
        {
            return InternalRequestAsync<DescribeVpcResourceResponse>(req, "DescribeVpcResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcView）用于查询VPC网络拓扑视图。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcViewRequest"/></param>
        /// <returns><see cref="DescribeVpcViewResponse"/></returns>
        public Task<DescribeVpcViewResponse> DescribeVpcView(DescribeVpcViewRequest req)
        {
            return InternalRequestAsync<DescribeVpcViewResponse>(req, "DescribeVpcView");
        }

        /// <summary>
        /// 本接口（DescribeVpcView）用于查询VPC网络拓扑视图。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcViewRequest"/></param>
        /// <returns><see cref="DescribeVpcViewResponse"/></returns>
        public DescribeVpcViewResponse DescribeVpcViewSync(DescribeVpcViewRequest req)
        {
            return InternalRequestAsync<DescribeVpcViewResponse>(req, "DescribeVpcView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
        /// 本接口不传参数时，返回默认排序下的前20条VPC信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs");
        }

        /// <summary>
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
        /// 本接口不传参数时，返回默认排序下的前20条VPC信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public DescribeVpcsResponse DescribeVpcsSync(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  本接口（DescribeVpnConnections）查询VPN通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnections(DescribeVpnConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpnConnectionsResponse>(req, "DescribeVpnConnections");
        }

        /// <summary>
        ///  本接口（DescribeVpnConnections）查询VPN通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnectionsSync(DescribeVpnConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpnConnectionsResponse>(req, "DescribeVpnConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpnGateways）用于查询VPN网关列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
        public Task<DescribeVpnGatewaysResponse> DescribeVpnGateways(DescribeVpnGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaysResponse>(req, "DescribeVpnGateways");
        }

        /// <summary>
        /// 本接口（DescribeVpnGateways）用于查询VPN网关列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
        public DescribeVpnGatewaysResponse DescribeVpnGatewaysSync(DescribeVpnGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaysResponse>(req, "DescribeVpnGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DownloadCustomerGatewayConfiguration)用于下载VPN通道配置。
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public Task<DownloadCustomerGatewayConfigurationResponse> DownloadCustomerGatewayConfiguration(DownloadCustomerGatewayConfigurationRequest req)
        {
            return InternalRequestAsync<DownloadCustomerGatewayConfigurationResponse>(req, "DownloadCustomerGatewayConfiguration");
        }

        /// <summary>
        /// 本接口(DownloadCustomerGatewayConfiguration)用于下载VPN通道配置。
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public DownloadCustomerGatewayConfigurationResponse DownloadCustomerGatewayConfigurationSync(DownloadCustomerGatewayConfigurationRequest req)
        {
            return InternalRequestAsync<DownloadCustomerGatewayConfigurationResponse>(req, "DownloadCustomerGatewayConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyCustomerGatewayAttribute）用于修改对端网关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
        public Task<ModifyCustomerGatewayAttributeResponse> ModifyCustomerGatewayAttribute(ModifyCustomerGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCustomerGatewayAttributeResponse>(req, "ModifyCustomerGatewayAttribute");
        }

        /// <summary>
        /// 本接口（ModifyCustomerGatewayAttribute）用于修改对端网关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
        public ModifyCustomerGatewayAttributeResponse ModifyCustomerGatewayAttributeSync(ModifyCustomerGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCustomerGatewayAttributeResponse>(req, "ModifyCustomerGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自定义路由
        /// </summary>
        /// <param name="req"><see cref="ModifyRoutePolicyRequest"/></param>
        /// <returns><see cref="ModifyRoutePolicyResponse"/></returns>
        public Task<ModifyRoutePolicyResponse> ModifyRoutePolicy(ModifyRoutePolicyRequest req)
        {
            return InternalRequestAsync<ModifyRoutePolicyResponse>(req, "ModifyRoutePolicy");
        }

        /// <summary>
        /// 修改自定义路由
        /// </summary>
        /// <param name="req"><see cref="ModifyRoutePolicyRequest"/></param>
        /// <returns><see cref="ModifyRoutePolicyResponse"/></returns>
        public ModifyRoutePolicyResponse ModifyRoutePolicySync(ModifyRoutePolicyRequest req)
        {
            return InternalRequestAsync<ModifyRoutePolicyResponse>(req, "ModifyRoutePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改路由表
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableRequest"/></param>
        /// <returns><see cref="ModifyRouteTableResponse"/></returns>
        public Task<ModifyRouteTableResponse> ModifyRouteTable(ModifyRouteTableRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableResponse>(req, "ModifyRouteTable");
        }

        /// <summary>
        /// 修改路由表
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableRequest"/></param>
        /// <returns><see cref="ModifyRouteTableResponse"/></returns>
        public ModifyRouteTableResponse ModifyRouteTableSync(ModifyRouteTableRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableResponse>(req, "ModifyRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改子网属性
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public Task<ModifySubnetAttributeResponse> ModifySubnetAttribute(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute");
        }

        /// <summary>
        /// 修改子网属性
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public ModifySubnetAttributeResponse ModifySubnetAttributeSync(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改子网DHCP Relay属性
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetDHCPRelayRequest"/></param>
        /// <returns><see cref="ModifySubnetDHCPRelayResponse"/></returns>
        public Task<ModifySubnetDHCPRelayResponse> ModifySubnetDHCPRelay(ModifySubnetDHCPRelayRequest req)
        {
            return InternalRequestAsync<ModifySubnetDHCPRelayResponse>(req, "ModifySubnetDHCPRelay");
        }

        /// <summary>
        /// 修改子网DHCP Relay属性
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetDHCPRelayRequest"/></param>
        /// <returns><see cref="ModifySubnetDHCPRelayResponse"/></returns>
        public ModifySubnetDHCPRelayResponse ModifySubnetDHCPRelaySync(ModifySubnetDHCPRelayRequest req)
        {
            return InternalRequestAsync<ModifySubnetDHCPRelayResponse>(req, "ModifySubnetDHCPRelay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpcAttribute）用于修改VPC的标识名称和控制VPC的监控起停。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute");
        }

        /// <summary>
        /// 本接口（ModifyVpcAttribute）用于修改VPC的标识名称和控制VPC的监控起停。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public ModifyVpcAttributeResponse ModifyVpcAttributeSync(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石对等连接
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="ModifyVpcPeerConnectionResponse"/></returns>
        public Task<ModifyVpcPeerConnectionResponse> ModifyVpcPeerConnection(ModifyVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<ModifyVpcPeerConnectionResponse>(req, "ModifyVpcPeerConnection");
        }

        /// <summary>
        /// 修改黑石对等连接
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="ModifyVpcPeerConnectionResponse"/></returns>
        public ModifyVpcPeerConnectionResponse ModifyVpcPeerConnectionSync(ModifyVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<ModifyVpcPeerConnectionResponse>(req, "ModifyVpcPeerConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpnConnectionAttribute）用于修改VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
        public Task<ModifyVpnConnectionAttributeResponse> ModifyVpnConnectionAttribute(ModifyVpnConnectionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnConnectionAttributeResponse>(req, "ModifyVpnConnectionAttribute");
        }

        /// <summary>
        /// 本接口（ModifyVpnConnectionAttribute）用于修改VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
        public ModifyVpnConnectionAttributeResponse ModifyVpnConnectionAttributeSync(ModifyVpnConnectionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnConnectionAttributeResponse>(req, "ModifyVpnConnectionAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayAttribute）用于修改VPN网关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
        public Task<ModifyVpnGatewayAttributeResponse> ModifyVpnGatewayAttribute(ModifyVpnGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayAttributeResponse>(req, "ModifyVpnGatewayAttribute");
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayAttribute）用于修改VPN网关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
        public ModifyVpnGatewayAttributeResponse ModifyVpnGatewayAttributeSync(ModifyVpnGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayAttributeResponse>(req, "ModifyVpnGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拒绝黑石对等连接申请
        /// </summary>
        /// <param name="req"><see cref="RejectVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="RejectVpcPeerConnectionResponse"/></returns>
        public Task<RejectVpcPeerConnectionResponse> RejectVpcPeerConnection(RejectVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<RejectVpcPeerConnectionResponse>(req, "RejectVpcPeerConnection");
        }

        /// <summary>
        /// 拒绝黑石对等连接申请
        /// </summary>
        /// <param name="req"><see cref="RejectVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="RejectVpcPeerConnectionResponse"/></returns>
        public RejectVpcPeerConnectionResponse RejectVpcPeerConnectionSync(RejectVpcPeerConnectionRequest req)
        {
            return InternalRequestAsync<RejectVpcPeerConnectionResponse>(req, "RejectVpcPeerConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ResetVpnConnection)用于重置VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public Task<ResetVpnConnectionResponse> ResetVpnConnection(ResetVpnConnectionRequest req)
        {
            return InternalRequestAsync<ResetVpnConnectionResponse>(req, "ResetVpnConnection");
        }

        /// <summary>
        /// 本接口(ResetVpnConnection)用于重置VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public ResetVpnConnectionResponse ResetVpnConnectionSync(ResetVpnConnectionRequest req)
        {
            return InternalRequestAsync<ResetVpnConnectionResponse>(req, "ResetVpnConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// NAT网关解绑该EIP后，NAT网关将不会使用该EIP作为访问外网的源IP地址
        /// </summary>
        /// <param name="req"><see cref="UnbindEipsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindEipsFromNatGatewayResponse"/></returns>
        public Task<UnbindEipsFromNatGatewayResponse> UnbindEipsFromNatGateway(UnbindEipsFromNatGatewayRequest req)
        {
            return InternalRequestAsync<UnbindEipsFromNatGatewayResponse>(req, "UnbindEipsFromNatGateway");
        }

        /// <summary>
        /// NAT网关解绑该EIP后，NAT网关将不会使用该EIP作为访问外网的源IP地址
        /// </summary>
        /// <param name="req"><see cref="UnbindEipsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindEipsFromNatGatewayResponse"/></returns>
        public UnbindEipsFromNatGatewayResponse UnbindEipsFromNatGatewaySync(UnbindEipsFromNatGatewayRequest req)
        {
            return InternalRequestAsync<UnbindEipsFromNatGatewayResponse>(req, "UnbindEipsFromNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// NAT网关解绑IP接口，可将子网的部分IP从NAT网关中解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindIpsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindIpsFromNatGatewayResponse"/></returns>
        public Task<UnbindIpsFromNatGatewayResponse> UnbindIpsFromNatGateway(UnbindIpsFromNatGatewayRequest req)
        {
            return InternalRequestAsync<UnbindIpsFromNatGatewayResponse>(req, "UnbindIpsFromNatGateway");
        }

        /// <summary>
        /// NAT网关解绑IP接口，可将子网的部分IP从NAT网关中解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindIpsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindIpsFromNatGatewayResponse"/></returns>
        public UnbindIpsFromNatGatewayResponse UnbindIpsFromNatGatewaySync(UnbindIpsFromNatGatewayRequest req)
        {
            return InternalRequestAsync<UnbindIpsFromNatGatewayResponse>(req, "UnbindIpsFromNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// NAT网关解绑子网接口，可将子网解绑NAT网关
        /// </summary>
        /// <param name="req"><see cref="UnbindSubnetsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindSubnetsFromNatGatewayResponse"/></returns>
        public Task<UnbindSubnetsFromNatGatewayResponse> UnbindSubnetsFromNatGateway(UnbindSubnetsFromNatGatewayRequest req)
        {
            return InternalRequestAsync<UnbindSubnetsFromNatGatewayResponse>(req, "UnbindSubnetsFromNatGateway");
        }

        /// <summary>
        /// NAT网关解绑子网接口，可将子网解绑NAT网关
        /// </summary>
        /// <param name="req"><see cref="UnbindSubnetsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindSubnetsFromNatGatewayResponse"/></returns>
        public UnbindSubnetsFromNatGatewayResponse UnbindSubnetsFromNatGatewaySync(UnbindSubnetsFromNatGatewayRequest req)
        {
            return InternalRequestAsync<UnbindSubnetsFromNatGatewayResponse>(req, "UnbindSubnetsFromNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级NAT网关接口，可NAT网关修改为小型NAT网关、中型NAT网关、以及大型NAT网关
        /// </summary>
        /// <param name="req"><see cref="UpgradeNatGatewayRequest"/></param>
        /// <returns><see cref="UpgradeNatGatewayResponse"/></returns>
        public Task<UpgradeNatGatewayResponse> UpgradeNatGateway(UpgradeNatGatewayRequest req)
        {
            return InternalRequestAsync<UpgradeNatGatewayResponse>(req, "UpgradeNatGateway");
        }

        /// <summary>
        /// 升级NAT网关接口，可NAT网关修改为小型NAT网关、中型NAT网关、以及大型NAT网关
        /// </summary>
        /// <param name="req"><see cref="UpgradeNatGatewayRequest"/></param>
        /// <returns><see cref="UpgradeNatGatewayResponse"/></returns>
        public UpgradeNatGatewayResponse UpgradeNatGatewaySync(UpgradeNatGatewayRequest req)
        {
            return InternalRequestAsync<UpgradeNatGatewayResponse>(req, "UpgradeNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
