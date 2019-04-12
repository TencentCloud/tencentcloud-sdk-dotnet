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

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public BmvpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public BmvpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接受黑石对等连接
        /// </summary>
        /// <param name="req">参考<see cref="AcceptVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="AcceptVpcPeerConnectionResponse"/>实例</returns>
        public async Task<AcceptVpcPeerConnectionResponse> AcceptVpcPeerConnection(AcceptVpcPeerConnectionRequest req)
        {
             JsonResponseModel<AcceptVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptVpcPeerConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptVpcPeerConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量注册虚拟IP，异步接口。通过接口来查询任务进度。每次请求最多注册256个IP
        /// </summary>
        /// <param name="req">参考<see cref="AsyncRegisterIpsRequest"/></param>
        /// <returns>参考<see cref="AsyncRegisterIpsResponse"/>实例</returns>
        public async Task<AsyncRegisterIpsResponse> AsyncRegisterIps(AsyncRegisterIpsRequest req)
        {
             JsonResponseModel<AsyncRegisterIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AsyncRegisterIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AsyncRegisterIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// NAT网关绑定EIP接口，可将EIP绑定到NAT网关，该EIP作为访问外网的源IP地址，将流量发送到Internet
        /// </summary>
        /// <param name="req">参考<see cref="BindEipsToNatGatewayRequest"/></param>
        /// <returns>参考<see cref="BindEipsToNatGatewayResponse"/>实例</returns>
        public async Task<BindEipsToNatGatewayResponse> BindEipsToNatGateway(BindEipsToNatGatewayRequest req)
        {
             JsonResponseModel<BindEipsToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindEipsToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEipsToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可用于将子网的部分IP绑定到NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="BindIpsToNatGatewayRequest"/></param>
        /// <returns>参考<see cref="BindIpsToNatGatewayResponse"/>实例</returns>
        public async Task<BindIpsToNatGatewayResponse> BindIpsToNatGateway(BindIpsToNatGatewayRequest req)
        {
             JsonResponseModel<BindIpsToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindIpsToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindIpsToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// NAT网关绑定子网后，该子网内全部IP可出公网
        /// </summary>
        /// <param name="req">参考<see cref="BindSubnetsToNatGatewayRequest"/></param>
        /// <returns>参考<see cref="BindSubnetsToNatGatewayResponse"/>实例</returns>
        public async Task<BindSubnetsToNatGatewayResponse> BindSubnetsToNatGateway(BindSubnetsToNatGatewayRequest req)
        {
             JsonResponseModel<BindSubnetsToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindSubnetsToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSubnetsToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石Docker子网， 如果不指定VlanId，将会分配2000--2999范围的VlanId; 子网会关闭分布式网关
        /// </summary>
        /// <param name="req">参考<see cref="CreateDockerSubnetWithVlanRequest"/></param>
        /// <returns>参考<see cref="CreateDockerSubnetWithVlanResponse"/>实例</returns>
        public async Task<CreateDockerSubnetWithVlanResponse> CreateDockerSubnetWithVlan(CreateDockerSubnetWithVlanRequest req)
        {
             JsonResponseModel<CreateDockerSubnetWithVlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDockerSubnetWithVlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDockerSubnetWithVlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateHostedInterface）用于黑石托管机器加入带VLANID不为5的子网。
        /// 
        /// 1) 不能加入vlanId 为5的子网，只能加入VLANID范围为2000-2999的子网。
        /// 2) 每台托管机器最多可以加入20个子网。
        /// 3) 每次调用最多能支持传入10台托管机器。
        /// </summary>
        /// <param name="req">参考<see cref="CreateHostedInterfaceRequest"/></param>
        /// <returns>参考<see cref="CreateHostedInterfaceResponse"/>实例</returns>
        public async Task<CreateHostedInterfaceResponse> CreateHostedInterface(CreateHostedInterfaceRequest req)
        {
             JsonResponseModel<CreateHostedInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHostedInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHostedInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 物理机加入子网
        /// </summary>
        /// <param name="req">参考<see cref="CreateInterfacesRequest"/></param>
        /// <returns>参考<see cref="CreateInterfacesResponse"/>实例</returns>
        public async Task<CreateInterfacesResponse> CreateInterfaces(CreateInterfacesRequest req)
        {
             JsonResponseModel<CreateInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建NAT网关接口，可针对网段方式、子网全部IP、子网部分IP这三种方式创建NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="CreateNatGatewayRequest"/></param>
        /// <returns>参考<see cref="CreateNatGatewayResponse"/>实例</returns>
        public async Task<CreateNatGatewayResponse> CreateNatGateway(CreateNatGatewayRequest req)
        {
             JsonResponseModel<CreateNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石路由表的路由规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateRoutePoliciesRequest"/></param>
        /// <returns>参考<see cref="CreateRoutePoliciesResponse"/>实例</returns>
        public async Task<CreateRoutePoliciesResponse> CreateRoutePolicies(CreateRoutePoliciesRequest req)
        {
             JsonResponseModel<CreateRoutePoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoutePolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoutePoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石私有网络的子网
        /// 访问管理: 用户可以对VpcId进行授权操作。比如设置资源为["qcs::bmvpc:::unVpc/vpc-xxxxx"]
        /// </summary>
        /// <param name="req">参考<see cref="CreateSubnetRequest"/></param>
        /// <returns>参考<see cref="CreateSubnetResponse"/>实例</returns>
        public async Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
             JsonResponseModel<CreateSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石虚拟子网， 虚拟子网用于在黑石上创建虚拟网络，与黑石子网要做好规划。虚拟子网会分配2000-2999的VlanId。
        /// </summary>
        /// <param name="req">参考<see cref="CreateVirtualSubnetWithVlanRequest"/></param>
        /// <returns>参考<see cref="CreateVirtualSubnetWithVlanResponse"/>实例</returns>
        public async Task<CreateVirtualSubnetWithVlanResponse> CreateVirtualSubnetWithVlan(CreateVirtualSubnetWithVlanRequest req)
        {
             JsonResponseModel<CreateVirtualSubnetWithVlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVirtualSubnetWithVlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVirtualSubnetWithVlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石私有网络
        /// </summary>
        /// <param name="req">参考<see cref="CreateVpcRequest"/></param>
        /// <returns>参考<see cref="CreateVpcResponse"/>实例</returns>
        public async Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
             JsonResponseModel<CreateVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建对等连接
        /// </summary>
        /// <param name="req">参考<see cref="CreateVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="CreateVpcPeerConnectionResponse"/>实例</returns>
        public async Task<CreateVpcPeerConnectionResponse> CreateVpcPeerConnection(CreateVpcPeerConnectionRequest req)
        {
             JsonResponseModel<CreateVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpcPeerConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcPeerConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCustomerGateway）用于删除对端网关。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteCustomerGatewayResponse"/>实例</returns>
        public async Task<DeleteCustomerGatewayResponse> DeleteCustomerGateway(DeleteCustomerGatewayRequest req)
        {
             JsonResponseModel<DeleteCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于托管机器从VLANID不为5的子网中移除。
        /// 1) 不能从vlanId 为5的子网中移除。
        /// 2) 每次调用最多能支持传入10台物理机。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteHostedInterfaceRequest"/></param>
        /// <returns>参考<see cref="DeleteHostedInterfaceResponse"/>实例</returns>
        public async Task<DeleteHostedInterfaceResponse> DeleteHostedInterface(DeleteHostedInterfaceRequest req)
        {
             JsonResponseModel<DeleteHostedInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteHostedInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHostedInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 托管机器移除子网批量接口，传入一台托管机器和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteHostedInterfacesRequest"/></param>
        /// <returns>参考<see cref="DeleteHostedInterfacesResponse"/>实例</returns>
        public async Task<DeleteHostedInterfacesResponse> DeleteHostedInterfaces(DeleteHostedInterfacesRequest req)
        {
             JsonResponseModel<DeleteHostedInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteHostedInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHostedInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 物理机移除子网批量接口，传入一台物理机和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteInterfacesRequest"/></param>
        /// <returns>参考<see cref="DeleteInterfacesResponse"/>实例</returns>
        public async Task<DeleteInterfacesResponse> DeleteInterfaces(DeleteInterfacesRequest req)
        {
             JsonResponseModel<DeleteInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNatGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteNatGatewayResponse"/>实例</returns>
        public async Task<DeleteNatGatewayResponse> DeleteNatGateway(DeleteNatGatewayRequest req)
        {
             JsonResponseModel<DeleteNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除黑石路由表路由规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRoutePolicyRequest"/></param>
        /// <returns>参考<see cref="DeleteRoutePolicyResponse"/>实例</returns>
        public async Task<DeleteRoutePolicyResponse> DeleteRoutePolicy(DeleteRoutePolicyRequest req)
        {
             JsonResponseModel<DeleteRoutePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoutePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoutePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSubnet）用于删除黑石私有网络子网。
        /// 删除子网前，请清理该子网下所有资源，包括物理机、负载均衡、黑石数据库、弹性IP、NAT网关等资源
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSubnetRequest"/></param>
        /// <returns>参考<see cref="DeleteSubnetResponse"/>实例</returns>
        public async Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
             JsonResponseModel<DeleteSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 退还虚拟IP。此接口只能退还虚拟IP，物理机IP不能退还。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVirtualIpRequest"/></param>
        /// <returns>参考<see cref="DeleteVirtualIpResponse"/>实例</returns>
        public async Task<DeleteVirtualIpResponse> DeleteVirtualIp(DeleteVirtualIpRequest req)
        {
             JsonResponseModel<DeleteVirtualIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVirtualIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVirtualIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteVpc)用于删除黑石私有网络(VPC)。
        /// 
        /// 删除私有网络前，请清理该私有网络下所有资源，包括子网、负载均衡、弹性 IP、对等连接、NAT 网关、专线通道、SSLVPN 等资源。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpcRequest"/></param>
        /// <returns>参考<see cref="DeleteVpcResponse"/>实例</returns>
        public async Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
             JsonResponseModel<DeleteVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除黑石对等连接
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="DeleteVpcPeerConnectionResponse"/>实例</returns>
        public async Task<DeleteVpcPeerConnectionResponse> DeleteVpcPeerConnection(DeleteVpcPeerConnectionRequest req)
        {
             JsonResponseModel<DeleteVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcPeerConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcPeerConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteVpnConnection)用于删除VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns>参考<see cref="DeleteVpnConnectionResponse"/>实例</returns>
        public async Task<DeleteVpnConnectionResponse> DeleteVpnConnection(DeleteVpnConnectionRequest req)
        {
             JsonResponseModel<DeleteVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpnGateway）用于删除VPN网关。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteVpnGatewayResponse"/>实例</returns>
        public async Task<DeleteVpnGatewayResponse> DeleteVpnGateway(DeleteVpnGatewayRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注销私有网络IP为空闲
        /// </summary>
        /// <param name="req">参考<see cref="DeregisterIpsRequest"/></param>
        /// <returns>参考<see cref="DeregisterIpsResponse"/>实例</returns>
        public async Task<DeregisterIpsResponse> DeregisterIps(DeregisterIpsRequest req)
        {
             JsonResponseModel<DeregisterIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCustomerGateways）用于查询对端网关列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeCustomerGatewaysResponse"/>实例</returns>
        public async Task<DescribeCustomerGatewaysResponse> DescribeCustomerGateways(DescribeCustomerGatewaysRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取NAT网关信息，包括NAT网关 ID、网关名称、私有网络、网关并发连接上限、绑定EIP列表等
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeNatGatewaysResponse"/>实例</returns>
        public async Task<DescribeNatGatewaysResponse> DescribeNatGateways(DescribeNatGatewaysRequest req)
        {
             JsonResponseModel<DescribeNatGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可获取NAT网关绑定的子网信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNatSubnetsRequest"/></param>
        /// <returns>参考<see cref="DescribeNatSubnetsResponse"/>实例</returns>
        public async Task<DescribeNatSubnetsResponse> DescribeNatSubnets(DescribeNatSubnetsRequest req)
        {
             JsonResponseModel<DescribeNatSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRoutePolicies）用于查询路由表条目。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRoutePoliciesRequest"/></param>
        /// <returns>参考<see cref="DescribeRoutePoliciesResponse"/>实例</returns>
        public async Task<DescribeRoutePoliciesResponse> DescribeRoutePolicies(DescribeRoutePoliciesRequest req)
        {
             JsonResponseModel<DescribeRoutePoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoutePolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoutePoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRouteTables）用于查询路由表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRouteTablesRequest"/></param>
        /// <returns>参考<see cref="DescribeRouteTablesResponse"/>实例</returns>
        public async Task<DescribeRouteTablesResponse> DescribeRouteTables(DescribeRouteTablesRequest req)
        {
             JsonResponseModel<DescribeRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取子网内可用IP列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetAvailableIpsRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetAvailableIpsResponse"/>实例</returns>
        public async Task<DescribeSubnetAvailableIpsResponse> DescribeSubnetAvailableIps(DescribeSubnetAvailableIpsRequest req)
        {
             JsonResponseModel<DescribeSubnetAvailableIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnetAvailableIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetAvailableIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 物理机可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询物理机加入的子网。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetByDeviceRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetByDeviceResponse"/>实例</returns>
        public async Task<DescribeSubnetByDeviceResponse> DescribeSubnetByDevice(DescribeSubnetByDeviceRequest req)
        {
             JsonResponseModel<DescribeSubnetByDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnetByDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetByDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 托管可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询托管加入的子网。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetByHostedDeviceRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetByHostedDeviceResponse"/>实例</returns>
        public async Task<DescribeSubnetByHostedDeviceResponse> DescribeSubnetByHostedDevice(DescribeSubnetByHostedDeviceRequest req)
        {
             JsonResponseModel<DescribeSubnetByHostedDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnetByHostedDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetByHostedDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSubnets）用于查询黑石子网列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetsRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetsResponse"/>实例</returns>
        public async Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
             JsonResponseModel<DescribeSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据任务ID，获取任务的执行状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskStatusResponse"/>实例</returns>
        public async Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcQuota）用于查询用户VPC相关配额限制。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcQuotaResponse"/>实例</returns>
        public async Task<DescribeVpcQuotaResponse> DescribeVpcQuota(DescribeVpcQuotaRequest req)
        {
             JsonResponseModel<DescribeVpcQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询黑石私有网络关联资源
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcResourceRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcResourceResponse"/>实例</returns>
        public async Task<DescribeVpcResourceResponse> DescribeVpcResource(DescribeVpcResourceRequest req)
        {
             JsonResponseModel<DescribeVpcResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcView）用于查询VPC网络拓扑视图。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcViewRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcViewResponse"/>实例</returns>
        public async Task<DescribeVpcViewResponse> DescribeVpcView(DescribeVpcViewRequest req)
        {
             JsonResponseModel<DescribeVpcViewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcView");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcViewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
        /// 本接口不传参数时，返回默认排序下的前20条VPC信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcsRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcsResponse"/>实例</returns>
        public async Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
             JsonResponseModel<DescribeVpcsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DownloadCustomerGatewayConfiguration)用于下载VPN通道配置。
        /// </summary>
        /// <param name="req">参考<see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns>参考<see cref="DownloadCustomerGatewayConfigurationResponse"/>实例</returns>
        public async Task<DownloadCustomerGatewayConfigurationResponse> DownloadCustomerGatewayConfiguration(DownloadCustomerGatewayConfigurationRequest req)
        {
             JsonResponseModel<DownloadCustomerGatewayConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadCustomerGatewayConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCustomerGatewayConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCustomerGatewayAttribute）用于修改对端网关信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyCustomerGatewayAttributeResponse"/>实例</returns>
        public async Task<ModifyCustomerGatewayAttributeResponse> ModifyCustomerGatewayAttribute(ModifyCustomerGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyCustomerGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomerGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomerGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改自定义路由
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRoutePolicyRequest"/></param>
        /// <returns>参考<see cref="ModifyRoutePolicyResponse"/>实例</returns>
        public async Task<ModifyRoutePolicyResponse> ModifyRoutePolicy(ModifyRoutePolicyRequest req)
        {
             JsonResponseModel<ModifyRoutePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRoutePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoutePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改路由表
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRouteTableRequest"/></param>
        /// <returns>参考<see cref="ModifyRouteTableResponse"/>实例</returns>
        public async Task<ModifyRouteTableResponse> ModifyRouteTable(ModifyRouteTableRequest req)
        {
             JsonResponseModel<ModifyRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改子网属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifySubnetAttributeResponse"/>实例</returns>
        public async Task<ModifySubnetAttributeResponse> ModifySubnetAttribute(ModifySubnetAttributeRequest req)
        {
             JsonResponseModel<ModifySubnetAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubnetAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubnetAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改子网DHCP Relay属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifySubnetDHCPRelayRequest"/></param>
        /// <returns>参考<see cref="ModifySubnetDHCPRelayResponse"/>实例</returns>
        public async Task<ModifySubnetDHCPRelayResponse> ModifySubnetDHCPRelay(ModifySubnetDHCPRelayRequest req)
        {
             JsonResponseModel<ModifySubnetDHCPRelayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubnetDHCPRelay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubnetDHCPRelayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcAttribute）用于修改VPC的标识名称和控制VPC的监控起停。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpcAttributeResponse"/>实例</returns>
        public async Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石对等连接
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="ModifyVpcPeerConnectionResponse"/>实例</returns>
        public async Task<ModifyVpcPeerConnectionResponse> ModifyVpcPeerConnection(ModifyVpcPeerConnectionRequest req)
        {
             JsonResponseModel<ModifyVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcPeerConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcPeerConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpnConnectionAttribute）用于修改VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpnConnectionAttributeResponse"/>实例</returns>
        public async Task<ModifyVpnConnectionAttributeResponse> ModifyVpnConnectionAttribute(ModifyVpnConnectionAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnConnectionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnConnectionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnConnectionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayAttribute）用于修改VPN网关属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpnGatewayAttributeResponse"/>实例</returns>
        public async Task<ModifyVpnGatewayAttributeResponse> ModifyVpnGatewayAttribute(ModifyVpnGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拒绝黑石对等连接申请
        /// </summary>
        /// <param name="req">参考<see cref="RejectVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="RejectVpcPeerConnectionResponse"/>实例</returns>
        public async Task<RejectVpcPeerConnectionResponse> RejectVpcPeerConnection(RejectVpcPeerConnectionRequest req)
        {
             JsonResponseModel<RejectVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RejectVpcPeerConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectVpcPeerConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ResetVpnConnection)用于重置VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="ResetVpnConnectionRequest"/></param>
        /// <returns>参考<see cref="ResetVpnConnectionResponse"/>实例</returns>
        public async Task<ResetVpnConnectionResponse> ResetVpnConnection(ResetVpnConnectionRequest req)
        {
             JsonResponseModel<ResetVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// NAT网关解绑该EIP后，NAT网关将不会使用该EIP作为访问外网的源IP地址
        /// </summary>
        /// <param name="req">参考<see cref="UnbindEipsFromNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UnbindEipsFromNatGatewayResponse"/>实例</returns>
        public async Task<UnbindEipsFromNatGatewayResponse> UnbindEipsFromNatGateway(UnbindEipsFromNatGatewayRequest req)
        {
             JsonResponseModel<UnbindEipsFromNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindEipsFromNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindEipsFromNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// NAT网关解绑IP接口，可将子网的部分IP从NAT网关中解绑
        /// </summary>
        /// <param name="req">参考<see cref="UnbindIpsFromNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UnbindIpsFromNatGatewayResponse"/>实例</returns>
        public async Task<UnbindIpsFromNatGatewayResponse> UnbindIpsFromNatGateway(UnbindIpsFromNatGatewayRequest req)
        {
             JsonResponseModel<UnbindIpsFromNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindIpsFromNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindIpsFromNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// NAT网关解绑子网接口，可将子网解绑NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="UnbindSubnetsFromNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UnbindSubnetsFromNatGatewayResponse"/>实例</returns>
        public async Task<UnbindSubnetsFromNatGatewayResponse> UnbindSubnetsFromNatGateway(UnbindSubnetsFromNatGatewayRequest req)
        {
             JsonResponseModel<UnbindSubnetsFromNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindSubnetsFromNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindSubnetsFromNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级NAT网关接口，可NAT网关修改为小型NAT网关、中型NAT网关、以及大型NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UpgradeNatGatewayResponse"/>实例</returns>
        public async Task<UpgradeNatGatewayResponse> UpgradeNatGateway(UpgradeNatGatewayRequest req)
        {
             JsonResponseModel<UpgradeNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
