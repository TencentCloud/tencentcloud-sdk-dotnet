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
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmvpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 接受黑石对等连接
        /// </summary>
        /// <param name="req"><see cref="AcceptVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="AcceptVpcPeerConnectionResponse"/></returns>
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
        /// AcceptVpcPeerConnection接口的同步版本，接受黑石对等连接
        /// </summary>
        /// <param name="req">参考<see cref="AcceptVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="AcceptVpcPeerConnectionResponse"/>实例</returns>
        public AcceptVpcPeerConnectionResponse AcceptVpcPeerConnectionSync(AcceptVpcPeerConnectionRequest req)
        {
             JsonResponseModel<AcceptVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcceptVpcPeerConnection");
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
        /// <param name="req"><see cref="AsyncRegisterIpsRequest"/></param>
        /// <returns><see cref="AsyncRegisterIpsResponse"/></returns>
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
        /// AsyncRegisterIps接口的同步版本，批量注册虚拟IP，异步接口。通过接口来查询任务进度。每次请求最多注册256个IP
        /// </summary>
        /// <param name="req">参考<see cref="AsyncRegisterIpsRequest"/></param>
        /// <returns>参考<see cref="AsyncRegisterIpsResponse"/>实例</returns>
        public AsyncRegisterIpsResponse AsyncRegisterIpsSync(AsyncRegisterIpsRequest req)
        {
             JsonResponseModel<AsyncRegisterIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AsyncRegisterIps");
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
        /// <param name="req"><see cref="BindEipsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindEipsToNatGatewayResponse"/></returns>
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
        /// BindEipsToNatGateway接口的同步版本，NAT网关绑定EIP接口，可将EIP绑定到NAT网关，该EIP作为访问外网的源IP地址，将流量发送到Internet
        /// </summary>
        /// <param name="req">参考<see cref="BindEipsToNatGatewayRequest"/></param>
        /// <returns>参考<see cref="BindEipsToNatGatewayResponse"/>实例</returns>
        public BindEipsToNatGatewayResponse BindEipsToNatGatewaySync(BindEipsToNatGatewayRequest req)
        {
             JsonResponseModel<BindEipsToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindEipsToNatGateway");
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
        /// <param name="req"><see cref="BindIpsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindIpsToNatGatewayResponse"/></returns>
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
        /// BindIpsToNatGateway接口的同步版本，可用于将子网的部分IP绑定到NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="BindIpsToNatGatewayRequest"/></param>
        /// <returns>参考<see cref="BindIpsToNatGatewayResponse"/>实例</returns>
        public BindIpsToNatGatewayResponse BindIpsToNatGatewaySync(BindIpsToNatGatewayRequest req)
        {
             JsonResponseModel<BindIpsToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindIpsToNatGateway");
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
        /// <param name="req"><see cref="BindSubnetsToNatGatewayRequest"/></param>
        /// <returns><see cref="BindSubnetsToNatGatewayResponse"/></returns>
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
        /// BindSubnetsToNatGateway接口的同步版本，NAT网关绑定子网后，该子网内全部IP可出公网
        /// </summary>
        /// <param name="req">参考<see cref="BindSubnetsToNatGatewayRequest"/></param>
        /// <returns>参考<see cref="BindSubnetsToNatGatewayResponse"/>实例</returns>
        public BindSubnetsToNatGatewayResponse BindSubnetsToNatGatewaySync(BindSubnetsToNatGatewayRequest req)
        {
             JsonResponseModel<BindSubnetsToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindSubnetsToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSubnetsToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCustomerGateway）用于创建对端网关。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
        public async Task<CreateCustomerGatewayResponse> CreateCustomerGateway(CreateCustomerGatewayRequest req)
        {
             JsonResponseModel<CreateCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateCustomerGateway接口的同步版本，本接口（CreateCustomerGateway）用于创建对端网关。
        /// </summary>
        /// <param name="req">参考<see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns>参考<see cref="CreateCustomerGatewayResponse"/>实例</returns>
        public CreateCustomerGatewayResponse CreateCustomerGatewaySync(CreateCustomerGatewayRequest req)
        {
             JsonResponseModel<CreateCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomerGatewayResponse>>(strResp);
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
        /// <param name="req"><see cref="CreateDockerSubnetWithVlanRequest"/></param>
        /// <returns><see cref="CreateDockerSubnetWithVlanResponse"/></returns>
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
        /// CreateDockerSubnetWithVlan接口的同步版本，创建黑石Docker子网， 如果不指定VlanId，将会分配2000--2999范围的VlanId; 子网会关闭分布式网关
        /// </summary>
        /// <param name="req">参考<see cref="CreateDockerSubnetWithVlanRequest"/></param>
        /// <returns>参考<see cref="CreateDockerSubnetWithVlanResponse"/>实例</returns>
        public CreateDockerSubnetWithVlanResponse CreateDockerSubnetWithVlanSync(CreateDockerSubnetWithVlanRequest req)
        {
             JsonResponseModel<CreateDockerSubnetWithVlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDockerSubnetWithVlan");
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
        /// <param name="req"><see cref="CreateHostedInterfaceRequest"/></param>
        /// <returns><see cref="CreateHostedInterfaceResponse"/></returns>
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
        /// CreateHostedInterface接口的同步版本，本接口（CreateHostedInterface）用于黑石托管机器加入带VLANID不为5的子网。
        /// 
        /// 1) 不能加入vlanId 为5的子网，只能加入VLANID范围为2000-2999的子网。
        /// 2) 每台托管机器最多可以加入20个子网。
        /// 3) 每次调用最多能支持传入10台托管机器。
        /// </summary>
        /// <param name="req">参考<see cref="CreateHostedInterfaceRequest"/></param>
        /// <returns>参考<see cref="CreateHostedInterfaceResponse"/>实例</returns>
        public CreateHostedInterfaceResponse CreateHostedInterfaceSync(CreateHostedInterfaceRequest req)
        {
             JsonResponseModel<CreateHostedInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHostedInterface");
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
        /// <param name="req"><see cref="CreateInterfacesRequest"/></param>
        /// <returns><see cref="CreateInterfacesResponse"/></returns>
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
        /// CreateInterfaces接口的同步版本，物理机加入子网
        /// </summary>
        /// <param name="req">参考<see cref="CreateInterfacesRequest"/></param>
        /// <returns>参考<see cref="CreateInterfacesResponse"/>实例</returns>
        public CreateInterfacesResponse CreateInterfacesSync(CreateInterfacesRequest req)
        {
             JsonResponseModel<CreateInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInterfaces");
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
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
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
        /// CreateNatGateway接口的同步版本，创建NAT网关接口，可针对网段方式、子网全部IP、子网部分IP这三种方式创建NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="CreateNatGatewayRequest"/></param>
        /// <returns>参考<see cref="CreateNatGatewayResponse"/>实例</returns>
        public CreateNatGatewayResponse CreateNatGatewaySync(CreateNatGatewayRequest req)
        {
             JsonResponseModel<CreateNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatGateway");
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
        /// <param name="req"><see cref="CreateRoutePoliciesRequest"/></param>
        /// <returns><see cref="CreateRoutePoliciesResponse"/></returns>
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
        /// CreateRoutePolicies接口的同步版本，创建黑石路由表的路由规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateRoutePoliciesRequest"/></param>
        /// <returns>参考<see cref="CreateRoutePoliciesResponse"/>实例</returns>
        public CreateRoutePoliciesResponse CreateRoutePoliciesSync(CreateRoutePoliciesRequest req)
        {
             JsonResponseModel<CreateRoutePoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoutePolicies");
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
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
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
        /// CreateSubnet接口的同步版本，创建黑石私有网络的子网
        /// 访问管理: 用户可以对VpcId进行授权操作。比如设置资源为["qcs::bmvpc:::unVpc/vpc-xxxxx"]
        /// </summary>
        /// <param name="req">参考<see cref="CreateSubnetRequest"/></param>
        /// <returns>参考<see cref="CreateSubnetResponse"/>实例</returns>
        public CreateSubnetResponse CreateSubnetSync(CreateSubnetRequest req)
        {
             JsonResponseModel<CreateSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubnet");
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
        /// <param name="req"><see cref="CreateVirtualSubnetWithVlanRequest"/></param>
        /// <returns><see cref="CreateVirtualSubnetWithVlanResponse"/></returns>
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
        /// CreateVirtualSubnetWithVlan接口的同步版本，创建黑石虚拟子网， 虚拟子网用于在黑石上创建虚拟网络，与黑石子网要做好规划。虚拟子网会分配2000-2999的VlanId。
        /// </summary>
        /// <param name="req">参考<see cref="CreateVirtualSubnetWithVlanRequest"/></param>
        /// <returns>参考<see cref="CreateVirtualSubnetWithVlanResponse"/>实例</returns>
        public CreateVirtualSubnetWithVlanResponse CreateVirtualSubnetWithVlanSync(CreateVirtualSubnetWithVlanRequest req)
        {
             JsonResponseModel<CreateVirtualSubnetWithVlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVirtualSubnetWithVlan");
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
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
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
        /// CreateVpc接口的同步版本，创建黑石私有网络
        /// </summary>
        /// <param name="req">参考<see cref="CreateVpcRequest"/></param>
        /// <returns>参考<see cref="CreateVpcResponse"/>实例</returns>
        public CreateVpcResponse CreateVpcSync(CreateVpcRequest req)
        {
             JsonResponseModel<CreateVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpc");
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
        /// <param name="req"><see cref="CreateVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="CreateVpcPeerConnectionResponse"/></returns>
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
        /// CreateVpcPeerConnection接口的同步版本，创建对等连接
        /// </summary>
        /// <param name="req">参考<see cref="CreateVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="CreateVpcPeerConnectionResponse"/>实例</returns>
        public CreateVpcPeerConnectionResponse CreateVpcPeerConnectionSync(CreateVpcPeerConnectionRequest req)
        {
             JsonResponseModel<CreateVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpcPeerConnection");
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
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
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
        /// DeleteCustomerGateway接口的同步版本，本接口（DeleteCustomerGateway）用于删除对端网关。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteCustomerGatewayResponse"/>实例</returns>
        public DeleteCustomerGatewayResponse DeleteCustomerGatewaySync(DeleteCustomerGatewayRequest req)
        {
             JsonResponseModel<DeleteCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomerGateway");
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
        /// <param name="req"><see cref="DeleteHostedInterfaceRequest"/></param>
        /// <returns><see cref="DeleteHostedInterfaceResponse"/></returns>
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
        /// DeleteHostedInterface接口的同步版本，本接口用于托管机器从VLANID不为5的子网中移除。
        /// 1) 不能从vlanId 为5的子网中移除。
        /// 2) 每次调用最多能支持传入10台物理机。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteHostedInterfaceRequest"/></param>
        /// <returns>参考<see cref="DeleteHostedInterfaceResponse"/>实例</returns>
        public DeleteHostedInterfaceResponse DeleteHostedInterfaceSync(DeleteHostedInterfaceRequest req)
        {
             JsonResponseModel<DeleteHostedInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteHostedInterface");
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
        /// <param name="req"><see cref="DeleteHostedInterfacesRequest"/></param>
        /// <returns><see cref="DeleteHostedInterfacesResponse"/></returns>
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
        /// DeleteHostedInterfaces接口的同步版本，托管机器移除子网批量接口，传入一台托管机器和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteHostedInterfacesRequest"/></param>
        /// <returns>参考<see cref="DeleteHostedInterfacesResponse"/>实例</returns>
        public DeleteHostedInterfacesResponse DeleteHostedInterfacesSync(DeleteHostedInterfacesRequest req)
        {
             JsonResponseModel<DeleteHostedInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteHostedInterfaces");
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
        /// <param name="req"><see cref="DeleteInterfacesRequest"/></param>
        /// <returns><see cref="DeleteInterfacesResponse"/></returns>
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
        /// DeleteInterfaces接口的同步版本，物理机移除子网批量接口，传入一台物理机和多个子网，批量移除这些子网。异步接口，接口返回TaskId。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteInterfacesRequest"/></param>
        /// <returns>参考<see cref="DeleteInterfacesResponse"/>实例</returns>
        public DeleteInterfacesResponse DeleteInterfacesSync(DeleteInterfacesRequest req)
        {
             JsonResponseModel<DeleteInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInterfaces");
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
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
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
        /// DeleteNatGateway接口的同步版本，删除NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="DeleteNatGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteNatGatewayResponse"/>实例</returns>
        public DeleteNatGatewayResponse DeleteNatGatewaySync(DeleteNatGatewayRequest req)
        {
             JsonResponseModel<DeleteNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNatGateway");
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
        /// <param name="req"><see cref="DeleteRoutePolicyRequest"/></param>
        /// <returns><see cref="DeleteRoutePolicyResponse"/></returns>
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
        /// DeleteRoutePolicy接口的同步版本，删除黑石路由表路由规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRoutePolicyRequest"/></param>
        /// <returns>参考<see cref="DeleteRoutePolicyResponse"/>实例</returns>
        public DeleteRoutePolicyResponse DeleteRoutePolicySync(DeleteRoutePolicyRequest req)
        {
             JsonResponseModel<DeleteRoutePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoutePolicy");
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
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
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
        /// DeleteSubnet接口的同步版本，本接口（DeleteSubnet）用于删除黑石私有网络子网。
        /// 删除子网前，请清理该子网下所有资源，包括物理机、负载均衡、黑石数据库、弹性IP、NAT网关等资源
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSubnetRequest"/></param>
        /// <returns>参考<see cref="DeleteSubnetResponse"/>实例</returns>
        public DeleteSubnetResponse DeleteSubnetSync(DeleteSubnetRequest req)
        {
             JsonResponseModel<DeleteSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSubnet");
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
        /// <param name="req"><see cref="DeleteVirtualIpRequest"/></param>
        /// <returns><see cref="DeleteVirtualIpResponse"/></returns>
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
        /// DeleteVirtualIp接口的同步版本，退还虚拟IP。此接口只能退还虚拟IP，物理机IP不能退还。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVirtualIpRequest"/></param>
        /// <returns>参考<see cref="DeleteVirtualIpResponse"/>实例</returns>
        public DeleteVirtualIpResponse DeleteVirtualIpSync(DeleteVirtualIpRequest req)
        {
             JsonResponseModel<DeleteVirtualIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVirtualIp");
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
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
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
        /// DeleteVpc接口的同步版本，本接口(DeleteVpc)用于删除黑石私有网络(VPC)。
        /// 
        /// 删除私有网络前，请清理该私有网络下所有资源，包括子网、负载均衡、弹性 IP、对等连接、NAT 网关、专线通道、SSLVPN 等资源。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpcRequest"/></param>
        /// <returns>参考<see cref="DeleteVpcResponse"/>实例</returns>
        public DeleteVpcResponse DeleteVpcSync(DeleteVpcRequest req)
        {
             JsonResponseModel<DeleteVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpc");
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
        /// <param name="req"><see cref="DeleteVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpcPeerConnectionResponse"/></returns>
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
        /// DeleteVpcPeerConnection接口的同步版本，删除黑石对等连接
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="DeleteVpcPeerConnectionResponse"/>实例</returns>
        public DeleteVpcPeerConnectionResponse DeleteVpcPeerConnectionSync(DeleteVpcPeerConnectionRequest req)
        {
             JsonResponseModel<DeleteVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcPeerConnection");
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
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
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
        /// DeleteVpnConnection接口的同步版本，本接口(DeleteVpnConnection)用于删除VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns>参考<see cref="DeleteVpnConnectionResponse"/>实例</returns>
        public DeleteVpnConnectionResponse DeleteVpnConnectionSync(DeleteVpnConnectionRequest req)
        {
             JsonResponseModel<DeleteVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnConnection");
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
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
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
        /// DeleteVpnGateway接口的同步版本，本接口（DeleteVpnGateway）用于删除VPN网关。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns>参考<see cref="DeleteVpnGatewayResponse"/>实例</returns>
        public DeleteVpnGatewayResponse DeleteVpnGatewaySync(DeleteVpnGatewayRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnGateway");
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
        /// <param name="req"><see cref="DeregisterIpsRequest"/></param>
        /// <returns><see cref="DeregisterIpsResponse"/></returns>
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
        /// DeregisterIps接口的同步版本，注销私有网络IP为空闲
        /// </summary>
        /// <param name="req">参考<see cref="DeregisterIpsRequest"/></param>
        /// <returns>参考<see cref="DeregisterIpsResponse"/>实例</returns>
        public DeregisterIpsResponse DeregisterIpsSync(DeregisterIpsRequest req)
        {
             JsonResponseModel<DeregisterIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterIps");
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
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
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
        /// DescribeCustomerGateways接口的同步版本，本接口（DescribeCustomerGateways）用于查询对端网关列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeCustomerGatewaysResponse"/>实例</returns>
        public DescribeCustomerGatewaysResponse DescribeCustomerGatewaysSync(DescribeCustomerGatewaysRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomerGateways");
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
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
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
        /// DescribeNatGateways接口的同步版本，获取NAT网关信息，包括NAT网关 ID、网关名称、私有网络、网关并发连接上限、绑定EIP列表等
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeNatGatewaysResponse"/>实例</returns>
        public DescribeNatGatewaysResponse DescribeNatGatewaysSync(DescribeNatGatewaysRequest req)
        {
             JsonResponseModel<DescribeNatGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGateways");
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
        /// <param name="req"><see cref="DescribeNatSubnetsRequest"/></param>
        /// <returns><see cref="DescribeNatSubnetsResponse"/></returns>
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
        /// DescribeNatSubnets接口的同步版本，可获取NAT网关绑定的子网信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeNatSubnetsRequest"/></param>
        /// <returns>参考<see cref="DescribeNatSubnetsResponse"/>实例</returns>
        public DescribeNatSubnetsResponse DescribeNatSubnetsSync(DescribeNatSubnetsRequest req)
        {
             JsonResponseModel<DescribeNatSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatSubnets");
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
        /// <param name="req"><see cref="DescribeRoutePoliciesRequest"/></param>
        /// <returns><see cref="DescribeRoutePoliciesResponse"/></returns>
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
        /// DescribeRoutePolicies接口的同步版本，本接口（DescribeRoutePolicies）用于查询路由表条目。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRoutePoliciesRequest"/></param>
        /// <returns>参考<see cref="DescribeRoutePoliciesResponse"/>实例</returns>
        public DescribeRoutePoliciesResponse DescribeRoutePoliciesSync(DescribeRoutePoliciesRequest req)
        {
             JsonResponseModel<DescribeRoutePoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoutePolicies");
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
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
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
        /// DescribeRouteTables接口的同步版本，本接口（DescribeRouteTables）用于查询路由表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRouteTablesRequest"/></param>
        /// <returns>参考<see cref="DescribeRouteTablesResponse"/>实例</returns>
        public DescribeRouteTablesResponse DescribeRouteTablesSync(DescribeRouteTablesRequest req)
        {
             JsonResponseModel<DescribeRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRouteTables");
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
        /// <param name="req"><see cref="DescribeSubnetAvailableIpsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAvailableIpsResponse"/></returns>
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
        /// DescribeSubnetAvailableIps接口的同步版本，获取子网内可用IP列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetAvailableIpsRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetAvailableIpsResponse"/>实例</returns>
        public DescribeSubnetAvailableIpsResponse DescribeSubnetAvailableIpsSync(DescribeSubnetAvailableIpsRequest req)
        {
             JsonResponseModel<DescribeSubnetAvailableIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubnetAvailableIps");
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
        /// <param name="req"><see cref="DescribeSubnetByDeviceRequest"/></param>
        /// <returns><see cref="DescribeSubnetByDeviceResponse"/></returns>
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
        /// DescribeSubnetByDevice接口的同步版本，物理机可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询物理机加入的子网。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetByDeviceRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetByDeviceResponse"/>实例</returns>
        public DescribeSubnetByDeviceResponse DescribeSubnetByDeviceSync(DescribeSubnetByDeviceRequest req)
        {
             JsonResponseModel<DescribeSubnetByDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubnetByDevice");
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
        /// <param name="req"><see cref="DescribeSubnetByHostedDeviceRequest"/></param>
        /// <returns><see cref="DescribeSubnetByHostedDeviceResponse"/></returns>
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
        /// DescribeSubnetByHostedDevice接口的同步版本，托管可以加入物理机子网，虚拟子网，DOCKER子网，通过此接口可以查询托管加入的子网。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetByHostedDeviceRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetByHostedDeviceResponse"/>实例</returns>
        public DescribeSubnetByHostedDeviceResponse DescribeSubnetByHostedDeviceSync(DescribeSubnetByHostedDeviceRequest req)
        {
             JsonResponseModel<DescribeSubnetByHostedDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubnetByHostedDevice");
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
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
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
        /// DescribeSubnets接口的同步版本，本接口（DescribeSubnets）用于查询黑石子网列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSubnetsRequest"/></param>
        /// <returns>参考<see cref="DescribeSubnetsResponse"/>实例</returns>
        public DescribeSubnetsResponse DescribeSubnetsSync(DescribeSubnetsRequest req)
        {
             JsonResponseModel<DescribeSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubnets");
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
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
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
        /// DescribeTaskStatus接口的同步版本，根据任务ID，获取任务的执行状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskStatusResponse"/>实例</returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取对等连接列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPeerConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpcPeerConnectionsResponse"/></returns>
        public async Task<DescribeVpcPeerConnectionsResponse> DescribeVpcPeerConnections(DescribeVpcPeerConnectionsRequest req)
        {
             JsonResponseModel<DescribeVpcPeerConnectionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcPeerConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcPeerConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeVpcPeerConnections接口的同步版本，获取对等连接列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcPeerConnectionsRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcPeerConnectionsResponse"/>实例</returns>
        public DescribeVpcPeerConnectionsResponse DescribeVpcPeerConnectionsSync(DescribeVpcPeerConnectionsRequest req)
        {
             JsonResponseModel<DescribeVpcPeerConnectionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcPeerConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcPeerConnectionsResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeVpcQuotaRequest"/></param>
        /// <returns><see cref="DescribeVpcQuotaResponse"/></returns>
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
        /// DescribeVpcQuota接口的同步版本，本接口（DescribeVpcQuota）用于查询用户VPC相关配额限制。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcQuotaRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcQuotaResponse"/>实例</returns>
        public DescribeVpcQuotaResponse DescribeVpcQuotaSync(DescribeVpcQuotaRequest req)
        {
             JsonResponseModel<DescribeVpcQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcQuota");
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
        /// <param name="req"><see cref="DescribeVpcResourceRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceResponse"/></returns>
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
        /// DescribeVpcResource接口的同步版本，查询黑石私有网络关联资源
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcResourceRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcResourceResponse"/>实例</returns>
        public DescribeVpcResourceResponse DescribeVpcResourceSync(DescribeVpcResourceRequest req)
        {
             JsonResponseModel<DescribeVpcResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcResource");
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
        /// <param name="req"><see cref="DescribeVpcViewRequest"/></param>
        /// <returns><see cref="DescribeVpcViewResponse"/></returns>
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
        /// DescribeVpcView接口的同步版本，本接口（DescribeVpcView）用于查询VPC网络拓扑视图。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcViewRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcViewResponse"/>实例</returns>
        public DescribeVpcViewResponse DescribeVpcViewSync(DescribeVpcViewRequest req)
        {
             JsonResponseModel<DescribeVpcViewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcView");
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
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
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
        /// DescribeVpcs接口的同步版本，本接口（DescribeVpcs）用于查询私有网络列表。
        /// 本接口不传参数时，返回默认排序下的前20条VPC信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpcsRequest"/></param>
        /// <returns>参考<see cref="DescribeVpcsResponse"/>实例</returns>
        public DescribeVpcsResponse DescribeVpcsSync(DescribeVpcsRequest req)
        {
             JsonResponseModel<DescribeVpcsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  本接口（DescribeVpnConnections）查询VPN通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public async Task<DescribeVpnConnectionsResponse> DescribeVpnConnections(DescribeVpnConnectionsRequest req)
        {
             JsonResponseModel<DescribeVpnConnectionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeVpnConnections接口的同步版本， 本接口（DescribeVpnConnections）查询VPN通道列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns>参考<see cref="DescribeVpnConnectionsResponse"/>实例</returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnectionsSync(DescribeVpnConnectionsRequest req)
        {
             JsonResponseModel<DescribeVpnConnectionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpnGateways）用于查询VPN网关列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
        public async Task<DescribeVpnGatewaysResponse> DescribeVpnGateways(DescribeVpnGatewaysRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeVpnGateways接口的同步版本，本接口（DescribeVpnGateways）用于查询VPN网关列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns>参考<see cref="DescribeVpnGatewaysResponse"/>实例</returns>
        public DescribeVpnGatewaysResponse DescribeVpnGatewaysSync(DescribeVpnGatewaysRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaysResponse>>(strResp);
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
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
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
        /// DownloadCustomerGatewayConfiguration接口的同步版本，本接口(DownloadCustomerGatewayConfiguration)用于下载VPN通道配置。
        /// </summary>
        /// <param name="req">参考<see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns>参考<see cref="DownloadCustomerGatewayConfigurationResponse"/>实例</returns>
        public DownloadCustomerGatewayConfigurationResponse DownloadCustomerGatewayConfigurationSync(DownloadCustomerGatewayConfigurationRequest req)
        {
             JsonResponseModel<DownloadCustomerGatewayConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadCustomerGatewayConfiguration");
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
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
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
        /// ModifyCustomerGatewayAttribute接口的同步版本，本接口（ModifyCustomerGatewayAttribute）用于修改对端网关信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyCustomerGatewayAttributeResponse"/>实例</returns>
        public ModifyCustomerGatewayAttributeResponse ModifyCustomerGatewayAttributeSync(ModifyCustomerGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyCustomerGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomerGatewayAttribute");
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
        /// <param name="req"><see cref="ModifyRoutePolicyRequest"/></param>
        /// <returns><see cref="ModifyRoutePolicyResponse"/></returns>
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
        /// ModifyRoutePolicy接口的同步版本，修改自定义路由
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRoutePolicyRequest"/></param>
        /// <returns>参考<see cref="ModifyRoutePolicyResponse"/>实例</returns>
        public ModifyRoutePolicyResponse ModifyRoutePolicySync(ModifyRoutePolicyRequest req)
        {
             JsonResponseModel<ModifyRoutePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRoutePolicy");
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
        /// <param name="req"><see cref="ModifyRouteTableRequest"/></param>
        /// <returns><see cref="ModifyRouteTableResponse"/></returns>
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
        /// ModifyRouteTable接口的同步版本，修改路由表
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRouteTableRequest"/></param>
        /// <returns>参考<see cref="ModifyRouteTableResponse"/>实例</returns>
        public ModifyRouteTableResponse ModifyRouteTableSync(ModifyRouteTableRequest req)
        {
             JsonResponseModel<ModifyRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRouteTable");
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
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
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
        /// ModifySubnetAttribute接口的同步版本，修改子网属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifySubnetAttributeResponse"/>实例</returns>
        public ModifySubnetAttributeResponse ModifySubnetAttributeSync(ModifySubnetAttributeRequest req)
        {
             JsonResponseModel<ModifySubnetAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubnetAttribute");
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
        /// <param name="req"><see cref="ModifySubnetDHCPRelayRequest"/></param>
        /// <returns><see cref="ModifySubnetDHCPRelayResponse"/></returns>
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
        /// ModifySubnetDHCPRelay接口的同步版本，修改子网DHCP Relay属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifySubnetDHCPRelayRequest"/></param>
        /// <returns>参考<see cref="ModifySubnetDHCPRelayResponse"/>实例</returns>
        public ModifySubnetDHCPRelayResponse ModifySubnetDHCPRelaySync(ModifySubnetDHCPRelayRequest req)
        {
             JsonResponseModel<ModifySubnetDHCPRelayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubnetDHCPRelay");
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
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
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
        /// ModifyVpcAttribute接口的同步版本，本接口（ModifyVpcAttribute）用于修改VPC的标识名称和控制VPC的监控起停。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpcAttributeResponse"/>实例</returns>
        public ModifyVpcAttributeResponse ModifyVpcAttributeSync(ModifyVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcAttribute");
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
        /// <param name="req"><see cref="ModifyVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="ModifyVpcPeerConnectionResponse"/></returns>
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
        /// ModifyVpcPeerConnection接口的同步版本，修改黑石对等连接
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="ModifyVpcPeerConnectionResponse"/>实例</returns>
        public ModifyVpcPeerConnectionResponse ModifyVpcPeerConnectionSync(ModifyVpcPeerConnectionRequest req)
        {
             JsonResponseModel<ModifyVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcPeerConnection");
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
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
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
        /// ModifyVpnConnectionAttribute接口的同步版本，本接口（ModifyVpnConnectionAttribute）用于修改VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpnConnectionAttributeResponse"/>实例</returns>
        public ModifyVpnConnectionAttributeResponse ModifyVpnConnectionAttributeSync(ModifyVpnConnectionAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnConnectionAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnConnectionAttribute");
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
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
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
        /// ModifyVpnGatewayAttribute接口的同步版本，本接口（ModifyVpnGatewayAttribute）用于修改VPN网关属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyVpnGatewayAttributeResponse"/>实例</returns>
        public ModifyVpnGatewayAttributeResponse ModifyVpnGatewayAttributeSync(ModifyVpnGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnGatewayAttribute");
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
        /// <param name="req"><see cref="RejectVpcPeerConnectionRequest"/></param>
        /// <returns><see cref="RejectVpcPeerConnectionResponse"/></returns>
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
        /// RejectVpcPeerConnection接口的同步版本，拒绝黑石对等连接申请
        /// </summary>
        /// <param name="req">参考<see cref="RejectVpcPeerConnectionRequest"/></param>
        /// <returns>参考<see cref="RejectVpcPeerConnectionResponse"/>实例</returns>
        public RejectVpcPeerConnectionResponse RejectVpcPeerConnectionSync(RejectVpcPeerConnectionRequest req)
        {
             JsonResponseModel<RejectVpcPeerConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RejectVpcPeerConnection");
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
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
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
        /// ResetVpnConnection接口的同步版本，本接口(ResetVpnConnection)用于重置VPN通道。
        /// </summary>
        /// <param name="req">参考<see cref="ResetVpnConnectionRequest"/></param>
        /// <returns>参考<see cref="ResetVpnConnectionResponse"/>实例</returns>
        public ResetVpnConnectionResponse ResetVpnConnectionSync(ResetVpnConnectionRequest req)
        {
             JsonResponseModel<ResetVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetVpnConnection");
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
        /// <param name="req"><see cref="UnbindEipsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindEipsFromNatGatewayResponse"/></returns>
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
        /// UnbindEipsFromNatGateway接口的同步版本，NAT网关解绑该EIP后，NAT网关将不会使用该EIP作为访问外网的源IP地址
        /// </summary>
        /// <param name="req">参考<see cref="UnbindEipsFromNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UnbindEipsFromNatGatewayResponse"/>实例</returns>
        public UnbindEipsFromNatGatewayResponse UnbindEipsFromNatGatewaySync(UnbindEipsFromNatGatewayRequest req)
        {
             JsonResponseModel<UnbindEipsFromNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindEipsFromNatGateway");
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
        /// <param name="req"><see cref="UnbindIpsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindIpsFromNatGatewayResponse"/></returns>
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
        /// UnbindIpsFromNatGateway接口的同步版本，NAT网关解绑IP接口，可将子网的部分IP从NAT网关中解绑
        /// </summary>
        /// <param name="req">参考<see cref="UnbindIpsFromNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UnbindIpsFromNatGatewayResponse"/>实例</returns>
        public UnbindIpsFromNatGatewayResponse UnbindIpsFromNatGatewaySync(UnbindIpsFromNatGatewayRequest req)
        {
             JsonResponseModel<UnbindIpsFromNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindIpsFromNatGateway");
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
        /// <param name="req"><see cref="UnbindSubnetsFromNatGatewayRequest"/></param>
        /// <returns><see cref="UnbindSubnetsFromNatGatewayResponse"/></returns>
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
        /// UnbindSubnetsFromNatGateway接口的同步版本，NAT网关解绑子网接口，可将子网解绑NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="UnbindSubnetsFromNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UnbindSubnetsFromNatGatewayResponse"/>实例</returns>
        public UnbindSubnetsFromNatGatewayResponse UnbindSubnetsFromNatGatewaySync(UnbindSubnetsFromNatGatewayRequest req)
        {
             JsonResponseModel<UnbindSubnetsFromNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindSubnetsFromNatGateway");
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
        /// <param name="req"><see cref="UpgradeNatGatewayRequest"/></param>
        /// <returns><see cref="UpgradeNatGatewayResponse"/></returns>
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

        /// <summary>
        /// UpgradeNatGateway接口的同步版本，升级NAT网关接口，可NAT网关修改为小型NAT网关、中型NAT网关、以及大型NAT网关
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeNatGatewayRequest"/></param>
        /// <returns>参考<see cref="UpgradeNatGatewayResponse"/>实例</returns>
        public UpgradeNatGatewayResponse UpgradeNatGatewaySync(UpgradeNatGatewayRequest req)
        {
             JsonResponseModel<UpgradeNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeNatGateway");
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
