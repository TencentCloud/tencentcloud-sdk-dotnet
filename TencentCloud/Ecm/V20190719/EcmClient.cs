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

namespace TencentCloud.Ecm.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ecm.V20190719.Models;

   public class EcmClient : AbstractClient{

       private const string endpoint = "ecm.tencentcloudapi.com";
       private const string version = "2019-07-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EcmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请一个或多个弹性公网IP（简称 EIP）
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public async Task<AllocateAddressesResponse> AllocateAddresses(AllocateAddressesRequest req)
        {
             JsonResponseModel<AllocateAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请一个或多个弹性公网IP（简称 EIP）
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public AllocateAddressesResponse AllocateAddressesSync(AllocateAddressesRequest req)
        {
             JsonResponseModel<AllocateAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssignIpv6Addresses）用于弹性网卡申请IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public async Task<AssignIpv6AddressesResponse> AssignIpv6Addresses(AssignIpv6AddressesRequest req)
        {
             JsonResponseModel<AssignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssignIpv6Addresses）用于弹性网卡申请IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public AssignIpv6AddressesResponse AssignIpv6AddressesSync(AssignIpv6AddressesRequest req)
        {
             JsonResponseModel<AssignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡申请内网 IP
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public async Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<AssignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡申请内网 IP
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddressesSync(AssignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<AssignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将弹性公网IP（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// 将 EIP 绑定到实例（ECM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// 将 EIP 绑定到指定网卡的内网 IP上，内网IP已经绑定了EIP或普通公网IP，则反馈失败。必须先解绑该 EIP，才能再绑定新的。
        /// 只有状态为 UNBIND 的 EIP 才能够绑定内网IP。
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public async Task<AssociateAddressResponse> AssociateAddress(AssociateAddressRequest req)
        {
             JsonResponseModel<AssociateAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将弹性公网IP（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// 将 EIP 绑定到实例（ECM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// 将 EIP 绑定到指定网卡的内网 IP上，内网IP已经绑定了EIP或普通公网IP，则反馈失败。必须先解绑该 EIP，才能再绑定新的。
        /// 只有状态为 UNBIND 的 EIP 才能够绑定内网IP。
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public AssociateAddressResponse AssociateAddressSync(AssociateAddressRequest req)
        {
             JsonResponseModel<AssociateAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定安全组
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定安全组
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡绑定云主机
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public async Task<AttachNetworkInterfaceResponse> AttachNetworkInterface(AttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<AttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡绑定云主机
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterfaceSync(AttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<AttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑后端服务。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public async Task<BatchDeregisterTargetsResponse> BatchDeregisterTargets(BatchDeregisterTargetsRequest req)
        {
             JsonResponseModel<BatchDeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑后端服务。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public BatchDeregisterTargetsResponse BatchDeregisterTargetsSync(BatchDeregisterTargetsRequest req)
        {
             JsonResponseModel<BatchDeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public async Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
             JsonResponseModel<BatchModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public BatchModifyTargetWeightResponse BatchModifyTargetWeightSync(BatchModifyTargetWeightRequest req)
        {
             JsonResponseModel<BatchModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量绑定后端目标。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public async Task<BatchRegisterTargetsResponse> BatchRegisterTargets(BatchRegisterTargetsRequest req)
        {
             JsonResponseModel<BatchRegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchRegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量绑定后端目标。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public BatchRegisterTargetsResponse BatchRegisterTargetsSync(BatchRegisterTargetsRequest req)
        {
             JsonResponseModel<BatchRegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchRegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public async Task<CreateHaVipResponse> CreateHaVip(CreateHaVipRequest req)
        {
             JsonResponseModel<CreateHaVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public CreateHaVipResponse CreateHaVipSync(CreateHaVipRequest req)
        {
             JsonResponseModel<CreateHaVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateImage)用于将实例的系统盘制作为新镜像，创建后的镜像可以用于创建实例。
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public async Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateImage)用于将实例的系统盘制作为新镜像，创建后的镜像可以用于创建实例。
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public async Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
             JsonResponseModel<CreateListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
             JsonResponseModel<CreateListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
             JsonResponseModel<CreateLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
             JsonResponseModel<CreateLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public async Task<CreateModuleResponse> CreateModule(CreateModuleRequest req)
        {
             JsonResponseModel<CreateModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public CreateModuleResponse CreateModuleSync(CreateModuleRequest req)
        {
             JsonResponseModel<CreateModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建弹性网卡
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public async Task<CreateNetworkInterfaceResponse> CreateNetworkInterface(CreateNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建弹性网卡
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public CreateNetworkInterfaceResponse CreateNetworkInterfaceSync(CreateNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public async Task<CreateRouteTableResponse> CreateRouteTable(CreateRouteTableRequest req)
        {
             JsonResponseModel<CreateRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public CreateRouteTableResponse CreateRouteTableSync(CreateRouteTableRequest req)
        {
             JsonResponseModel<CreateRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建路由策略
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public async Task<CreateRoutesResponse> CreateRoutes(CreateRoutesRequest req)
        {
             JsonResponseModel<CreateRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建路由策略
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public CreateRoutesResponse CreateRoutesSync(CreateRoutesRequest req)
        {
             JsonResponseModel<CreateRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest req)
        {
             JsonResponseModel<CreateSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public CreateSecurityGroupResponse CreateSecurityGroupSync(CreateSecurityGroupRequest req)
        {
             JsonResponseModel<CreateSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p>本接口（CreateSecurityGroupPolicies）用于创建安全组规则（SecurityGroupPolicy）。</p>
        /// <p>在 SecurityGroupPolicySet 参数中：</p>
        /// <ul>
        /// <li>Version 安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。</li>
        /// <li>在创建出站和入站规则（Egress 和 Ingress）时：<ul>
        /// <li>Protocol 字段支持输入TCP, UDP, ICMP, GRE, ALL。</li>
        /// <li>CidrBlock 字段允许输入符合cidr格式标准的任意字符串。在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// <li>SecurityGroupId 字段允许输入与待修改的安全组位于相同项目中的安全组 ID，包括这个安全组 ID 本身，代表安全组下所有云服务器的内网 IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个 ID 所关联的云服务器变化而变化，不需要重新修改。</li>
        /// <li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受，即 Protocol 字段不是 TCP 或 UDP 时，Protocol 和 Port 排他关系，不允许同时输入，否则会接口报错。</li>
        /// <li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// <li>CidrBlock, SecurityGroupId, AddressTemplate 是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。</li>
        /// <li>一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。</li>
        /// </ul></li></ul>
        /// <p>默认接口请求频率限制：20次/秒。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupPoliciesResponse"/></returns>
        public async Task<CreateSecurityGroupPoliciesResponse> CreateSecurityGroupPolicies(CreateSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p>本接口（CreateSecurityGroupPolicies）用于创建安全组规则（SecurityGroupPolicy）。</p>
        /// <p>在 SecurityGroupPolicySet 参数中：</p>
        /// <ul>
        /// <li>Version 安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。</li>
        /// <li>在创建出站和入站规则（Egress 和 Ingress）时：<ul>
        /// <li>Protocol 字段支持输入TCP, UDP, ICMP, GRE, ALL。</li>
        /// <li>CidrBlock 字段允许输入符合cidr格式标准的任意字符串。在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// <li>SecurityGroupId 字段允许输入与待修改的安全组位于相同项目中的安全组 ID，包括这个安全组 ID 本身，代表安全组下所有云服务器的内网 IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个 ID 所关联的云服务器变化而变化，不需要重新修改。</li>
        /// <li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受，即 Protocol 字段不是 TCP 或 UDP 时，Protocol 和 Port 排他关系，不允许同时输入，否则会接口报错。</li>
        /// <li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// <li>CidrBlock, SecurityGroupId, AddressTemplate 是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。</li>
        /// <li>一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。</li>
        /// </ul></li></ul>
        /// <p>默认接口请求频率限制：20次/秒。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupPoliciesResponse"/></returns>
        public CreateSecurityGroupPoliciesResponse CreateSecurityGroupPoliciesSync(CreateSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建子网，若创建成功，则此子网会成为此可用区的默认子网。
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
        /// 创建子网，若创建成功，则此子网会成为此可用区的默认子网。
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
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
        /// 创建私有网络
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
        /// 创建私有网络
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
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
        /// 用于删除高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public async Task<DeleteHaVipResponse> DeleteHaVip(DeleteHaVipRequest req)
        {
             JsonResponseModel<DeleteHaVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public DeleteHaVipResponse DeleteHaVipSync(DeleteHaVipRequest req)
        {
             JsonResponseModel<DeleteHaVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public async Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public async Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
             JsonResponseModel<DeleteListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
             JsonResponseModel<DeleteListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡多个监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public async Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancerListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡多个监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancerListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除业务模块
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public async Task<DeleteModuleResponse> DeleteModule(DeleteModuleRequest req)
        {
             JsonResponseModel<DeleteModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除业务模块
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public DeleteModuleResponse DeleteModuleSync(DeleteModuleRequest req)
        {
             JsonResponseModel<DeleteModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除弹性网卡
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public async Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterface(DeleteNetworkInterfaceRequest req)
        {
             JsonResponseModel<DeleteNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除弹性网卡
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public DeleteNetworkInterfaceResponse DeleteNetworkInterfaceSync(DeleteNetworkInterfaceRequest req)
        {
             JsonResponseModel<DeleteNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public async Task<DeleteRouteTableResponse> DeleteRouteTable(DeleteRouteTableRequest req)
        {
             JsonResponseModel<DeleteRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public DeleteRouteTableResponse DeleteRouteTableSync(DeleteRouteTableRequest req)
        {
             JsonResponseModel<DeleteRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对某个路由表批量删除路由策略
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public async Task<DeleteRoutesResponse> DeleteRoutes(DeleteRoutesRequest req)
        {
             JsonResponseModel<DeleteRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对某个路由表批量删除路由策略
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public DeleteRoutesResponse DeleteRoutesSync(DeleteRoutesRequest req)
        {
             JsonResponseModel<DeleteRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有当前账号下的安全组允许被删除。
        /// 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// 删除的安全组无法再找回，请谨慎调用。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroup(DeleteSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有当前账号下的安全组允许被删除。
        /// 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// 删除的安全组无法再找回，请谨慎调用。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public DeleteSecurityGroupResponse DeleteSecurityGroupSync(DeleteSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public async Task<DeleteSecurityGroupPoliciesResponse> DeleteSecurityGroupPolicies(DeleteSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public DeleteSecurityGroupPoliciesResponse DeleteSecurityGroupPoliciesSync(DeleteSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除子网，若子网为可用区下的默认子网，则默认子网会回退到系统自动创建的默认子网，非用户最新创建的子网。若默认子网不满足需求，可调用设置默认子网接口设置。
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
        /// 删除子网，若子网为可用区下的默认子网，则默认子网会回退到系统自动创建的默认子网，非用户最新创建的子网。若默认子网不满足需求，可调用设置默认子网接口设置。
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
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
        /// 删除私有网络
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
        /// 删除私有网络
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
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
        /// 查询您账户的弹性公网IP（简称 EIP）在当前地域的配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public async Task<DescribeAddressQuotaResponse> DescribeAddressQuota(DescribeAddressQuotaRequest req)
        {
             JsonResponseModel<DescribeAddressQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询您账户的弹性公网IP（简称 EIP）在当前地域的配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public DescribeAddressQuotaResponse DescribeAddressQuotaSync(DescribeAddressQuotaRequest req)
        {
             JsonResponseModel<DescribeAddressQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddressQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性公网IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public async Task<DescribeAddressesResponse> DescribeAddresses(DescribeAddressesRequest req)
        {
             JsonResponseModel<DescribeAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性公网IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public DescribeAddressesResponse DescribeAddressesSync(DescribeAddressesRequest req)
        {
             JsonResponseModel<DescribeAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取概览页统计的基本数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public async Task<DescribeBaseOverviewResponse> DescribeBaseOverview(DescribeBaseOverviewRequest req)
        {
             JsonResponseModel<DescribeBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取概览页统计的基本数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public DescribeBaseOverviewResponse DescribeBaseOverviewSync(DescribeBaseOverviewRequest req)
        {
             JsonResponseModel<DescribeBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取带宽硬盘等数据的限制
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public async Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取带宽硬盘等数据的限制
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询导入镜像任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public async Task<DescribeCustomImageTaskResponse> DescribeCustomImageTask(DescribeCustomImageTaskRequest req)
        {
             JsonResponseModel<DescribeCustomImageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomImageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询导入镜像任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public DescribeCustomImageTaskResponse DescribeCustomImageTaskSync(DescribeCustomImageTaskRequest req)
        {
             JsonResponseModel<DescribeCustomImageTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomImageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可用区的默认子网
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public async Task<DescribeDefaultSubnetResponse> DescribeDefaultSubnet(DescribeDefaultSubnetRequest req)
        {
             JsonResponseModel<DescribeDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可用区的默认子网
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public DescribeDefaultSubnetResponse DescribeDefaultSubnetSync(DescribeDefaultSubnetRequest req)
        {
             JsonResponseModel<DescribeDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询高可用虚拟IP（HAVIP）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public async Task<DescribeHaVipsResponse> DescribeHaVips(DescribeHaVipsRequest req)
        {
             JsonResponseModel<DescribeHaVipsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHaVips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHaVipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询高可用虚拟IP（HAVIP）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public DescribeHaVipsResponse DescribeHaVipsSync(DescribeHaVipsRequest req)
        {
             JsonResponseModel<DescribeHaVipsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHaVips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHaVipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public async Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询外部导入镜像支持的OS列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public async Task<DescribeImportImageOsResponse> DescribeImportImageOs(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询外部导入镜像支持的OS列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public DescribeImportImageOsResponse DescribeImportImageOsSync(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机型配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public async Task<DescribeInstanceTypeConfigResponse> DescribeInstanceTypeConfig(DescribeInstanceTypeConfigRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceTypeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机型配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public DescribeInstanceTypeConfigResponse DescribeInstanceTypeConfigSync(DescribeInstanceTypeConfigRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceTypeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例管理终端地址
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例管理终端地址
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过实例id获取当前禁止的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public async Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过实例id获取当前禁止的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡的监听器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public async Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
             JsonResponseModel<DescribeListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡的监听器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
             JsonResponseModel<DescribeListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡相关的任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public async Task<DescribeLoadBalanceTaskStatusResponse> DescribeLoadBalanceTaskStatus(DescribeLoadBalanceTaskStatusRequest req)
        {
             JsonResponseModel<DescribeLoadBalanceTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalanceTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalanceTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡相关的任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public DescribeLoadBalanceTaskStatusResponse DescribeLoadBalanceTaskStatusSync(DescribeLoadBalanceTaskStatusRequest req)
        {
             JsonResponseModel<DescribeLoadBalanceTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalanceTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalanceTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public async Task<DescribeModuleResponse> DescribeModule(DescribeModuleRequest req)
        {
             JsonResponseModel<DescribeModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public DescribeModuleResponse DescribeModuleSync(DescribeModuleRequest req)
        {
             JsonResponseModel<DescribeModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示模块详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public async Task<DescribeModuleDetailResponse> DescribeModuleDetail(DescribeModuleDetailRequest req)
        {
             JsonResponseModel<DescribeModuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 展示模块详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public DescribeModuleDetailResponse DescribeModuleDetailSync(DescribeModuleDetailRequest req)
        {
             JsonResponseModel<DescribeModuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取客户节点上的出入带宽月峰和计费带宽信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public async Task<DescribeMonthPeakNetworkResponse> DescribeMonthPeakNetwork(DescribeMonthPeakNetworkRequest req)
        {
             JsonResponseModel<DescribeMonthPeakNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonthPeakNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonthPeakNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取客户节点上的出入带宽月峰和计费带宽信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public DescribeMonthPeakNetworkResponse DescribeMonthPeakNetworkSync(DescribeMonthPeakNetworkRequest req)
        {
             JsonResponseModel<DescribeMonthPeakNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonthPeakNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonthPeakNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询弹性网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesSync(DescribeNetworkInterfacesRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public async Task<DescribeNodeResponse> DescribeNode(DescribeNodeRequest req)
        {
             JsonResponseModel<DescribeNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public DescribeNodeResponse DescribeNodeSync(DescribeNodeRequest req)
        {
             JsonResponseModel<DescribeNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CPU 内存 硬盘等基础信息峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public async Task<DescribePeakBaseOverviewResponse> DescribePeakBaseOverview(DescribePeakBaseOverviewRequest req)
        {
             JsonResponseModel<DescribePeakBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CPU 内存 硬盘等基础信息峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public DescribePeakBaseOverviewResponse DescribePeakBaseOverviewSync(DescribePeakBaseOverviewRequest req)
        {
             JsonResponseModel<DescribePeakBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public async Task<DescribePeakNetworkOverviewResponse> DescribePeakNetworkOverview(DescribePeakNetworkOverviewRequest req)
        {
             JsonResponseModel<DescribePeakNetworkOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakNetworkOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakNetworkOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public DescribePeakNetworkOverviewResponse DescribePeakNetworkOverviewSync(DescribePeakNetworkOverviewRequest req)
        {
             JsonResponseModel<DescribePeakNetworkOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakNetworkOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakNetworkOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自定义路由策略与云联网路由策略冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public async Task<DescribeRouteConflictsResponse> DescribeRouteConflicts(DescribeRouteConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteConflictsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自定义路由策略与云联网路由策略冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public DescribeRouteConflictsResponse DescribeRouteConflictsSync(DescribeRouteConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteConflictsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRouteConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路由表对象列表
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
        /// 查询路由表对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
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
        /// 查询安全组关联实例统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public async Task<DescribeSecurityGroupAssociationStatisticsResponse> DescribeSecurityGroupAssociationStatistics(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupAssociationStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全组关联实例统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public DescribeSecurityGroupAssociationStatisticsResponse DescribeSecurityGroupAssociationStatisticsSync(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupAssociationStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户安全组配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public async Task<DescribeSecurityGroupLimitsResponse> DescribeSecurityGroupLimits(DescribeSecurityGroupLimitsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户安全组配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public DescribeSecurityGroupLimitsResponse DescribeSecurityGroupLimitsSync(DescribeSecurityGroupLimitsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public async Task<DescribeSecurityGroupPoliciesResponse> DescribeSecurityGroupPolicies(DescribeSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public DescribeSecurityGroupPoliciesResponse DescribeSecurityGroupPoliciesSync(DescribeSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看安全组
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看安全组
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsSync(DescribeSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询子网列表
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
        /// 查询子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
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
        /// 获取负载均衡后端服务的健康检查状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public async Task<DescribeTargetHealthResponse> DescribeTargetHealth(DescribeTargetHealthRequest req)
        {
             JsonResponseModel<DescribeTargetHealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取负载均衡后端服务的健康检查状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public DescribeTargetHealthResponse DescribeTargetHealthSync(DescribeTargetHealthRequest req)
        {
             JsonResponseModel<DescribeTargetHealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public async Task<DescribeTargetsResponse> DescribeTargets(DescribeTargetsRequest req)
        {
             JsonResponseModel<DescribeTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public DescribeTargetsResponse DescribeTargetsSync(DescribeTargetsRequest req)
        {
             JsonResponseModel<DescribeTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询EIP异步任务执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public async Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询EIP异步任务执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeTaskStatus)用于获取异步任务状态
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
        /// 本接口(DescribeTaskStatus)用于获取异步任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
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
        /// 查询私有网络列表
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
        /// 查询私有网络列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
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
        /// 弹性网卡解绑云主机
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public async Task<DetachNetworkInterfaceResponse> DetachNetworkInterface(DetachNetworkInterfaceRequest req)
        {
             JsonResponseModel<DetachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡解绑云主机
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterfaceSync(DetachNetworkInterfaceRequest req)
        {
             JsonResponseModel<DetachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用已启用的子网路由
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public async Task<DisableRoutesResponse> DisableRoutes(DisableRoutesRequest req)
        {
             JsonResponseModel<DisableRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用已启用的子网路由
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public DisableRoutesResponse DisableRoutesSync(DisableRoutesRequest req)
        {
             JsonResponseModel<DisableRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑弹性公网IP（简称 EIP）
        /// 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// EIP 如果被封堵，则不能进行解绑定操作。
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public async Task<DisassociateAddressResponse> DisassociateAddress(DisassociateAddressRequest req)
        {
             JsonResponseModel<DisassociateAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑弹性公网IP（简称 EIP）
        /// 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// EIP 如果被封堵，则不能进行解绑定操作。
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public DisassociateAddressResponse DisassociateAddressSync(DisassociateAddressRequest req)
        {
             JsonResponseModel<DisassociateAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑安全组
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑安全组
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用已禁用的子网路由。
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public async Task<EnableRoutesResponse> EnableRoutes(EnableRoutesRequest req)
        {
             JsonResponseModel<EnableRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用已禁用的子网路由。
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public EnableRoutesResponse EnableRoutesSync(EnableRoutesRequest req)
        {
             JsonResponseModel<EnableRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入自定义镜像，支持 RAW、VHD、QCOW2、VMDK 镜像格式
        /// </summary>
        /// <param name="req"><see cref="ImportCustomImageRequest"/></param>
        /// <returns><see cref="ImportCustomImageResponse"/></returns>
        public async Task<ImportCustomImageResponse> ImportCustomImage(ImportCustomImageRequest req)
        {
             JsonResponseModel<ImportCustomImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportCustomImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportCustomImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入自定义镜像，支持 RAW、VHD、QCOW2、VMDK 镜像格式
        /// </summary>
        /// <param name="req"><see cref="ImportCustomImageRequest"/></param>
        /// <returns><see cref="ImportCustomImageResponse"/></returns>
        public ImportCustomImageResponse ImportCustomImageSync(ImportCustomImageRequest req)
        {
             JsonResponseModel<ImportCustomImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportCustomImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportCustomImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从CVM产品导入镜像到ECM
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public async Task<ImportImageResponse> ImportImage(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从CVM产品导入镜像到ECM
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public ImportImageResponse ImportImageSync(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡迁移
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public async Task<MigrateNetworkInterfaceResponse> MigrateNetworkInterface(MigrateNetworkInterfaceRequest req)
        {
             JsonResponseModel<MigrateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigrateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡迁移
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public MigrateNetworkInterfaceResponse MigrateNetworkInterfaceSync(MigrateNetworkInterfaceRequest req)
        {
             JsonResponseModel<MigrateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MigrateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡内网IP迁移。
        /// 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// 迁移前后的弹性网卡必须在同一个子网内。
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public async Task<MigratePrivateIpAddressResponse> MigratePrivateIpAddress(MigratePrivateIpAddressRequest req)
        {
             JsonResponseModel<MigratePrivateIpAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigratePrivateIpAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigratePrivateIpAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡内网IP迁移。
        /// 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// 迁移前后的弹性网卡必须在同一个子网内。
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public MigratePrivateIpAddressResponse MigratePrivateIpAddressSync(MigratePrivateIpAddressRequest req)
        {
             JsonResponseModel<MigratePrivateIpAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MigratePrivateIpAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigratePrivateIpAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改弹性公网IP属性
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public async Task<ModifyAddressAttributeResponse> ModifyAddressAttribute(ModifyAddressAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改弹性公网IP属性
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public ModifyAddressAttributeResponse ModifyAddressAttributeSync(ModifyAddressAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整弹性公网IP带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public async Task<ModifyAddressesBandwidthResponse> ModifyAddressesBandwidth(ModifyAddressesBandwidthRequest req)
        {
             JsonResponseModel<ModifyAddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整弹性公网IP带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public ModifyAddressesBandwidthResponse ModifyAddressesBandwidthSync(ModifyAddressesBandwidthRequest req)
        {
             JsonResponseModel<ModifyAddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改在一个可用区下创建实例时使用的默认子网（创建实例时，未填写VPC参数时使用的sunbetId）
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public async Task<ModifyDefaultSubnetResponse> ModifyDefaultSubnet(ModifyDefaultSubnetRequest req)
        {
             JsonResponseModel<ModifyDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改在一个可用区下创建实例时使用的默认子网（创建实例时，未填写VPC参数时使用的sunbetId）
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public ModifyDefaultSubnetResponse ModifyDefaultSubnetSync(ModifyDefaultSubnetRequest req)
        {
             JsonResponseModel<ModifyDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改高可用虚拟IP（HAVIP）属性
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public async Task<ModifyHaVipAttributeResponse> ModifyHaVipAttribute(ModifyHaVipAttributeRequest req)
        {
             JsonResponseModel<ModifyHaVipAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHaVipAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHaVipAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改高可用虚拟IP（HAVIP）属性
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public ModifyHaVipAttributeResponse ModifyHaVipAttributeSync(ModifyHaVipAttributeRequest req)
        {
             JsonResponseModel<ModifyHaVipAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHaVipAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHaVipAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyImageAttribute）用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public async Task<ModifyImageAttributeResponse> ModifyImageAttribute(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyImageAttribute）用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public ModifyImageAttributeResponse ModifyImageAttributeSync(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public async Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡IPv6地址属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public async Task<ModifyIpv6AddressesAttributeResponse> ModifyIpv6AddressesAttribute(ModifyIpv6AddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyIpv6AddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIpv6AddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIpv6AddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡IPv6地址属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public ModifyIpv6AddressesAttributeResponse ModifyIpv6AddressesAttributeSync(ModifyIpv6AddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyIpv6AddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIpv6AddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIpv6AddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡监听器属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public async Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
             JsonResponseModel<ModifyListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡监听器属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
             JsonResponseModel<ModifyListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public async Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancerAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancerAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块配置，已关联实例的模块不支持调整配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public async Task<ModifyModuleConfigResponse> ModifyModuleConfig(ModifyModuleConfigRequest req)
        {
             JsonResponseModel<ModifyModuleConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块配置，已关联实例的模块不支持调整配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public ModifyModuleConfigResponse ModifyModuleConfigSync(ModifyModuleConfigRequest req)
        {
             JsonResponseModel<ModifyModuleConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块是否禁止分配外网ip的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public async Task<ModifyModuleDisableWanIpResponse> ModifyModuleDisableWanIp(ModifyModuleDisableWanIpRequest req)
        {
             JsonResponseModel<ModifyModuleDisableWanIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleDisableWanIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleDisableWanIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块是否禁止分配外网ip的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public ModifyModuleDisableWanIpResponse ModifyModuleDisableWanIpSync(ModifyModuleDisableWanIpRequest req)
        {
             JsonResponseModel<ModifyModuleDisableWanIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleDisableWanIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleDisableWanIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块的默认镜像
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public async Task<ModifyModuleImageResponse> ModifyModuleImage(ModifyModuleImageRequest req)
        {
             JsonResponseModel<ModifyModuleImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块的默认镜像
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public ModifyModuleImageResponse ModifyModuleImageSync(ModifyModuleImageRequest req)
        {
             JsonResponseModel<ModifyModuleImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块IP直通。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public async Task<ModifyModuleIpDirectResponse> ModifyModuleIpDirect(ModifyModuleIpDirectRequest req)
        {
             JsonResponseModel<ModifyModuleIpDirectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleIpDirect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleIpDirectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块IP直通。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public ModifyModuleIpDirectResponse ModifyModuleIpDirectSync(ModifyModuleIpDirectRequest req)
        {
             JsonResponseModel<ModifyModuleIpDirectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleIpDirect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleIpDirectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块名称
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public async Task<ModifyModuleNameResponse> ModifyModuleName(ModifyModuleNameRequest req)
        {
             JsonResponseModel<ModifyModuleNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块名称
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public ModifyModuleNameResponse ModifyModuleNameSync(ModifyModuleNameRequest req)
        {
             JsonResponseModel<ModifyModuleNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块默认带宽上限
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public async Task<ModifyModuleNetworkResponse> ModifyModuleNetwork(ModifyModuleNetworkRequest req)
        {
             JsonResponseModel<ModifyModuleNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块默认带宽上限
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public ModifyModuleNetworkResponse ModifyModuleNetworkSync(ModifyModuleNetworkRequest req)
        {
             JsonResponseModel<ModifyModuleNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块默认安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public async Task<ModifyModuleSecurityGroupsResponse> ModifyModuleSecurityGroups(ModifyModuleSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyModuleSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模块默认安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public ModifyModuleSecurityGroupsResponse ModifyModuleSecurityGroupsSync(ModifyModuleSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyModuleSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改弹性网卡内网IP属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public async Task<ModifyPrivateIpAddressesAttributeResponse> ModifyPrivateIpAddressesAttribute(ModifyPrivateIpAddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateIpAddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改弹性网卡内网IP属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public ModifyPrivateIpAddressesAttributeResponse ModifyPrivateIpAddressesAttributeSync(ModifyPrivateIpAddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateIpAddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改路由表属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public async Task<ModifyRouteTableAttributeResponse> ModifyRouteTableAttribute(ModifyRouteTableAttributeRequest req)
        {
             JsonResponseModel<ModifyRouteTableAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRouteTableAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRouteTableAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改路由表属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public ModifyRouteTableAttributeResponse ModifyRouteTableAttributeSync(ModifyRouteTableAttributeRequest req)
        {
             JsonResponseModel<ModifyRouteTableAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRouteTableAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRouteTableAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全组属性
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public async Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest req)
        {
             JsonResponseModel<ModifySecurityGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全组属性
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttributeSync(ModifySecurityGroupAttributeRequest req)
        {
             JsonResponseModel<ModifySecurityGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全组出站和入站规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public async Task<ModifySecurityGroupPoliciesResponse> ModifySecurityGroupPolicies(ModifySecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全组出站和入站规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public ModifySecurityGroupPoliciesResponse ModifySecurityGroupPoliciesSync(ModifySecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupPoliciesResponse>>(strResp);
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
        /// 修改子网属性
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
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
        /// 修改监听器绑定的后端机器的端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public async Task<ModifyTargetPortResponse> ModifyTargetPort(ModifyTargetPortRequest req)
        {
             JsonResponseModel<ModifyTargetPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改监听器绑定的后端机器的端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public ModifyTargetPortResponse ModifyTargetPortSync(ModifyTargetPortRequest req)
        {
             JsonResponseModel<ModifyTargetPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public async Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
             JsonResponseModel<ModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
             JsonResponseModel<ModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改私有网络（VPC）的相关属性
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
        /// 修改私有网络（VPC）的相关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
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
        /// 只有状态为RUNNING的实例才可以进行此操作；接口调用成功时，实例会进入REBOOTING状态；重启实例成功时，实例会进入RUNNING状态；支持强制重启，强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public async Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有状态为RUNNING的实例才可以进行此操作；接口调用成功时，实例会进入REBOOTING状态；重启实例成功时，实例会进入RUNNING状态；支持强制重启，强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 释放一个或多个弹性公网IP（简称 EIP）。
        /// 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// 只有状态为 UNBIND 的 EIP 才能进行释放操作。
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public async Task<ReleaseAddressesResponse> ReleaseAddresses(ReleaseAddressesRequest req)
        {
             JsonResponseModel<ReleaseAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 释放一个或多个弹性公网IP（简称 EIP）。
        /// 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// 只有状态为 UNBIND 的 EIP 才能进行释放操作。
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public ReleaseAddressesResponse ReleaseAddressesSync(ReleaseAddressesRequest req)
        {
             JsonResponseModel<ReleaseAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public async Task<ReleaseIpv6AddressesResponse> ReleaseIpv6Addresses(ReleaseIpv6AddressesRequest req)
        {
             JsonResponseModel<ReleaseIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public ReleaseIpv6AddressesResponse ReleaseIpv6AddressesSync(ReleaseIpv6AddressesRequest req)
        {
             JsonResponseModel<ReleaseIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡退还内网 IP。
        /// 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public async Task<RemovePrivateIpAddressesResponse> RemovePrivateIpAddresses(RemovePrivateIpAddressesRequest req)
        {
             JsonResponseModel<RemovePrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemovePrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemovePrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 弹性网卡退还内网 IP。
        /// 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public RemovePrivateIpAddressesResponse RemovePrivateIpAddressesSync(RemovePrivateIpAddressesRequest req)
        {
             JsonResponseModel<RemovePrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemovePrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemovePrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改子网关联的路由表，一个子网只能关联一个路由表。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public async Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest req)
        {
             JsonResponseModel<ReplaceRouteTableAssociationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceRouteTableAssociation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRouteTableAssociationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改子网关联的路由表，一个子网只能关联一个路由表。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociationSync(ReplaceRouteTableAssociationRequest req)
        {
             JsonResponseModel<ReplaceRouteTableAssociationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceRouteTableAssociation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRouteTableAssociationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 替换路由策略
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public async Task<ReplaceRoutesResponse> ReplaceRoutes(ReplaceRoutesRequest req)
        {
             JsonResponseModel<ReplaceRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 替换路由策略
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public ReplaceRoutesResponse ReplaceRoutesSync(ReplaceRoutesRequest req)
        {
             JsonResponseModel<ReplaceRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 替换单条安全组路由规则, 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public async Task<ReplaceSecurityGroupPolicyResponse> ReplaceSecurityGroupPolicy(ReplaceSecurityGroupPolicyRequest req)
        {
             JsonResponseModel<ReplaceSecurityGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceSecurityGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceSecurityGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 替换单条安全组路由规则, 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public ReplaceSecurityGroupPolicyResponse ReplaceSecurityGroupPolicySync(ReplaceSecurityGroupPolicyRequest req)
        {
             JsonResponseModel<ReplaceSecurityGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceSecurityGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceSecurityGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重装实例，若指定了ImageId参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装；若未指定密码，则密码通过站内信形式随后发送。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public async Task<ResetInstancesResponse> ResetInstances(ResetInstancesRequest req)
        {
             JsonResponseModel<ResetInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重装实例，若指定了ImageId参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装；若未指定密码，则密码通过站内信形式随后发送。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public ResetInstancesResponse ResetInstancesSync(ResetInstancesRequest req)
        {
             JsonResponseModel<ResetInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置实例的最大带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public async Task<ResetInstancesMaxBandwidthResponse> ResetInstancesMaxBandwidth(ResetInstancesMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置实例的最大带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public ResetInstancesMaxBandwidthResponse ResetInstancesMaxBandwidthSync(ResetInstancesMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置处于运行中状态的实例的密码，需要显式指定强制关机参数ForceStop。如果没有显式指定强制关机参数，则只有处于关机状态的实例才允许执行重置密码操作。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public async Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置处于运行中状态的实例的密码，需要显式指定强制关机参数ForceStop。如果没有显式指定强制关机参数，则只有处于关机状态的实例才允许执行重置密码操作。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对某个路由表名称和所有路由策略（Route）进行重新设置
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public async Task<ResetRoutesResponse> ResetRoutes(ResetRoutesRequest req)
        {
             JsonResponseModel<ResetRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对某个路由表名称和所有路由策略（Route）进行重新设置
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public ResetRoutesResponse ResetRoutesSync(ResetRoutesRequest req)
        {
             JsonResponseModel<ResetRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建ECM实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public async Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建ECM实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置负载均衡实例的安全组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public async Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
             JsonResponseModel<SetLoadBalancerSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLoadBalancerSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置负载均衡实例的安全组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
             JsonResponseModel<SetLoadBalancerSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetLoadBalancerSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public async Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
             JsonResponseModel<SetSecurityGroupForLoadbalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetSecurityGroupForLoadbalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetSecurityGroupForLoadbalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public SetSecurityGroupForLoadbalancersResponse SetSecurityGroupForLoadbalancersSync(SetSecurityGroupForLoadbalancersRequest req)
        {
             JsonResponseModel<SetSecurityGroupForLoadbalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetSecurityGroupForLoadbalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetSecurityGroupForLoadbalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有状态为STOPPED的实例才可以进行此操作；接口调用成功时，实例会进入STARTING状态；启动实例成功时，实例会进入RUNNING状态。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public async Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有状态为STOPPED的实例才可以进行此操作；接口调用成功时，实例会进入STARTING状态；启动实例成功时，实例会进入RUNNING状态。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有处于"RUNNING"状态的实例才能够进行关机操作；
        /// 调用成功时，实例会进入STOPPING状态；关闭实例成功时，实例会进入STOPPED状态；
        /// 支持强制关闭，强制关机的效果等同于关闭物理计算机的电源开关，强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public async Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 只有处于"RUNNING"状态的实例才能够进行关机操作；
        /// 调用成功时，实例会进入STOPPING状态；关闭实例成功时，实例会进入STOPPED状态；
        /// 支持强制关闭，强制关机的效果等同于关闭物理计算机的电源开关，强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public async Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
