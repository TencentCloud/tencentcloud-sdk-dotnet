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
       private const string sdkVersion = "SDK_NET_3.0.1023";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 申请一个或多个弹性公网IP（简称 EIP）
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public Task<AllocateAddressesResponse> AllocateAddresses(AllocateAddressesRequest req)
        {
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses");
        }

        /// <summary>
        /// 申请一个或多个弹性公网IP（简称 EIP）
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public AllocateAddressesResponse AllocateAddressesSync(AllocateAddressesRequest req)
        {
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于给IPv6地址分配公网带宽
        /// </summary>
        /// <param name="req"><see cref="AllocateIpv6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="AllocateIpv6AddressesBandwidthResponse"/></returns>
        public Task<AllocateIpv6AddressesBandwidthResponse> AllocateIpv6AddressesBandwidth(AllocateIpv6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<AllocateIpv6AddressesBandwidthResponse>(req, "AllocateIpv6AddressesBandwidth");
        }

        /// <summary>
        /// 本接口用于给IPv6地址分配公网带宽
        /// </summary>
        /// <param name="req"><see cref="AllocateIpv6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="AllocateIpv6AddressesBandwidthResponse"/></returns>
        public AllocateIpv6AddressesBandwidthResponse AllocateIpv6AddressesBandwidthSync(AllocateIpv6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<AllocateIpv6AddressesBandwidthResponse>(req, "AllocateIpv6AddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssignIpv6Addresses）用于弹性网卡申请IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public Task<AssignIpv6AddressesResponse> AssignIpv6Addresses(AssignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<AssignIpv6AddressesResponse>(req, "AssignIpv6Addresses");
        }

        /// <summary>
        /// 本接口（AssignIpv6Addresses）用于弹性网卡申请IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public AssignIpv6AddressesResponse AssignIpv6AddressesSync(AssignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<AssignIpv6AddressesResponse>(req, "AssignIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssignIpv6CidrBlock）用于分配IPv6网段。
        /// 
        /// 使用本接口前，您需要已有VPC实例，如果没有可通过接口CreateVpc创建。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public Task<AssignIpv6CidrBlockResponse> AssignIpv6CidrBlock(AssignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6CidrBlockResponse>(req, "AssignIpv6CidrBlock");
        }

        /// <summary>
        /// 本接口（AssignIpv6CidrBlock）用于分配IPv6网段。
        /// 
        /// 使用本接口前，您需要已有VPC实例，如果没有可通过接口CreateVpc创建。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public AssignIpv6CidrBlockResponse AssignIpv6CidrBlockSync(AssignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6CidrBlockResponse>(req, "AssignIpv6CidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssignIpv6CidrBlocks）用于分配IPv6网段。
        /// 
        /// 使用本接口前，您需要已有VPC实例，如果没有可通过接口CreateVpc创建。
        /// 每个VPC 可以同时支持运营商网络('CMCC'-中国移动, 'CTCC'-中国电信, 'CUCC'-中国联调)。本接口可以同时申请不同类型的IPv6网段
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlocksRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlocksResponse"/></returns>
        public Task<AssignIpv6CidrBlocksResponse> AssignIpv6CidrBlocks(AssignIpv6CidrBlocksRequest req)
        {
            return InternalRequestAsync<AssignIpv6CidrBlocksResponse>(req, "AssignIpv6CidrBlocks");
        }

        /// <summary>
        /// 本接口（AssignIpv6CidrBlocks）用于分配IPv6网段。
        /// 
        /// 使用本接口前，您需要已有VPC实例，如果没有可通过接口CreateVpc创建。
        /// 每个VPC 可以同时支持运营商网络('CMCC'-中国移动, 'CTCC'-中国电信, 'CUCC'-中国联调)。本接口可以同时申请不同类型的IPv6网段
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlocksRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlocksResponse"/></returns>
        public AssignIpv6CidrBlocksResponse AssignIpv6CidrBlocksSync(AssignIpv6CidrBlocksRequest req)
        {
            return InternalRequestAsync<AssignIpv6CidrBlocksResponse>(req, "AssignIpv6CidrBlocks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssignIpv6SubnetCidrBlock）用于分配IPv6子网段。
        /// 
        /// 给子网分配 IPv6 网段，要求子网所属 VPC 已获得 IPv6 网段。如果尚未分配，请先通过接口 AssignIpv6CidrBlock 给子网所属 VPC 分配一个 IPv6 网段。否则无法分配 IPv6 子网段。
        /// 每个子网只能分配一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public Task<AssignIpv6SubnetCidrBlockResponse> AssignIpv6SubnetCidrBlock(AssignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6SubnetCidrBlockResponse>(req, "AssignIpv6SubnetCidrBlock");
        }

        /// <summary>
        /// 本接口（AssignIpv6SubnetCidrBlock）用于分配IPv6子网段。
        /// 
        /// 给子网分配 IPv6 网段，要求子网所属 VPC 已获得 IPv6 网段。如果尚未分配，请先通过接口 AssignIpv6CidrBlock 给子网所属 VPC 分配一个 IPv6 网段。否则无法分配 IPv6 子网段。
        /// 每个子网只能分配一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public AssignIpv6SubnetCidrBlockResponse AssignIpv6SubnetCidrBlockSync(AssignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6SubnetCidrBlockResponse>(req, "AssignIpv6SubnetCidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 弹性网卡申请内网 IP
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses");
        }

        /// <summary>
        /// 弹性网卡申请内网 IP
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddressesSync(AssignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将弹性公网IP（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// 将 EIP 绑定到实例（ECM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// 将 EIP 绑定到指定网卡的内网 IP上，内网IP已经绑定了EIP或普通公网IP，则反馈失败。必须先解绑该 EIP，才能再绑定新的。
        /// 只有状态为 UNBIND 的 EIP 才能够绑定内网IP。
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public Task<AssociateAddressResponse> AssociateAddress(AssociateAddressRequest req)
        {
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress");
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
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定安全组
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// 绑定安全组
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachDisks）用于挂载云硬盘。
        ///  
        /// * 支持批量操作，将多块云盘挂载到同一云主机。如果多个云盘中存在不允许挂载的云盘，则操作不执行，返回特定的错误码。
        /// * 本接口为异步接口，当挂载云盘的请求成功返回时，表示后台已发起挂载云盘的操作，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHING”变为“ATTACHED”，则为挂载成功。
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks");
        }

        /// <summary>
        /// 本接口（AttachDisks）用于挂载云硬盘。
        ///  
        /// * 支持批量操作，将多块云盘挂载到同一云主机。如果多个云盘中存在不允许挂载的云盘，则操作不执行，返回特定的错误码。
        /// * 本接口为异步接口，当挂载云盘的请求成功返回时，表示后台已发起挂载云盘的操作，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHING”变为“ATTACHED”，则为挂载成功。
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 弹性网卡绑定云主机
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public Task<AttachNetworkInterfaceResponse> AttachNetworkInterface(AttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface");
        }

        /// <summary>
        /// 弹性网卡绑定云主机
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterfaceSync(AttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解绑后端服务。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public Task<BatchDeregisterTargetsResponse> BatchDeregisterTargets(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets");
        }

        /// <summary>
        /// 批量解绑后端服务。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public BatchDeregisterTargetsResponse BatchDeregisterTargetsSync(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight");
        }

        /// <summary>
        /// 批量修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public BatchModifyTargetWeightResponse BatchModifyTargetWeightSync(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量绑定后端目标。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public Task<BatchRegisterTargetsResponse> BatchRegisterTargets(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets");
        }

        /// <summary>
        /// 批量绑定后端目标。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public BatchRegisterTargetsResponse BatchRegisterTargetsSync(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDisks）用于创建云硬盘。
        /// 
        /// * 预付费云盘的购买会预先扣除本次云盘购买所需金额，在调用本接口前请确保账户余额充足。
        /// * 本接口支持传入数据盘快照来创建云盘，实现将快照数据复制到新购云盘上。
        /// * 本接口为异步接口，当创建请求下发成功后会返回一个新建的云盘ID列表，此时云盘的创建并未立即完成。可以通过调用[DescribeDisks](/document/product/362/16315)接口根据DiskId查询对应云盘，如果能查到云盘，且状态为'UNATTACHED'或'ATTACHED'，则表示创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public Task<CreateDisksResponse> CreateDisks(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks");
        }

        /// <summary>
        /// 本接口（CreateDisks）用于创建云硬盘。
        /// 
        /// * 预付费云盘的购买会预先扣除本次云盘购买所需金额，在调用本接口前请确保账户余额充足。
        /// * 本接口支持传入数据盘快照来创建云盘，实现将快照数据复制到新购云盘上。
        /// * 本接口为异步接口，当创建请求下发成功后会返回一个新建的云盘ID列表，此时云盘的创建并未立即完成。可以通过调用[DescribeDisks](/document/product/362/16315)接口根据DiskId查询对应云盘，如果能查到云盘，且状态为'UNATTACHED'或'ATTACHED'，则表示创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateDisksRequest"/></param>
        /// <returns><see cref="CreateDisksResponse"/></returns>
        public CreateDisksResponse CreateDisksSync(CreateDisksRequest req)
        {
            return InternalRequestAsync<CreateDisksResponse>(req, "CreateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public Task<CreateHaVipResponse> CreateHaVip(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip");
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public CreateHaVipResponse CreateHaVipSync(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateImage)用于将实例的系统盘制作为新镜像，创建后的镜像可以用于创建实例。
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage");
        }

        /// <summary>
        /// 本接口(CreateImage)用于将实例的系统盘制作为新镜像，创建后的镜像可以用于创建实例。
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建一个 OpenSSH RSA 密钥对，可以用于登录 Linux 实例。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair");
        }

        /// <summary>
        /// 用于创建一个 OpenSSH RSA 密钥对，可以用于登录 Linux 实例。
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// 创建负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// 购买负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public Task<CreateModuleResponse> CreateModule(CreateModuleRequest req)
        {
            return InternalRequestAsync<CreateModuleResponse>(req, "CreateModule");
        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public CreateModuleResponse CreateModuleSync(CreateModuleRequest req)
        {
            return InternalRequestAsync<CreateModuleResponse>(req, "CreateModule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建弹性网卡
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public Task<CreateNetworkInterfaceResponse> CreateNetworkInterface(CreateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface");
        }

        /// <summary>
        /// 创建弹性网卡
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public CreateNetworkInterfaceResponse CreateNetworkInterfaceSync(CreateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public Task<CreateRouteTableResponse> CreateRouteTable(CreateRouteTableRequest req)
        {
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable");
        }

        /// <summary>
        /// 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public CreateRouteTableResponse CreateRouteTableSync(CreateRouteTableRequest req)
        {
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建路由策略
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public Task<CreateRoutesResponse> CreateRoutes(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes");
        }

        /// <summary>
        /// 创建路由策略
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public CreateRoutesResponse CreateRoutesSync(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安全组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup");
        }

        /// <summary>
        /// 创建安全组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public CreateSecurityGroupResponse CreateSecurityGroupSync(CreateSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateSecurityGroupPoliciesResponse> CreateSecurityGroupPolicies(CreateSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies");
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
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建子网，若创建成功，则此子网会成为此可用区的默认子网。
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet");
        }

        /// <summary>
        /// 创建子网，若创建成功，则此子网会成为此可用区的默认子网。
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public CreateSubnetResponse CreateSubnetSync(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建私有网络
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc");
        }

        /// <summary>
        /// 创建私有网络
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public CreateVpcResponse CreateVpcSync(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public Task<DeleteHaVipResponse> DeleteHaVip(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip");
        }

        /// <summary>
        /// 用于删除高可用虚拟IP（HAVIP）
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public DeleteHaVipResponse DeleteHaVipSync(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage");
        }

        /// <summary>
        /// 删除镜像
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// 删除负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// 删除负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除负载均衡多个监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners");
        }

        /// <summary>
        /// 删除负载均衡多个监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除业务模块
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public Task<DeleteModuleResponse> DeleteModule(DeleteModuleRequest req)
        {
            return InternalRequestAsync<DeleteModuleResponse>(req, "DeleteModule");
        }

        /// <summary>
        /// 删除业务模块
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public DeleteModuleResponse DeleteModuleSync(DeleteModuleRequest req)
        {
            return InternalRequestAsync<DeleteModuleResponse>(req, "DeleteModule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除弹性网卡
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterface(DeleteNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteNetworkInterfaceResponse>(req, "DeleteNetworkInterface");
        }

        /// <summary>
        /// 删除弹性网卡
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public DeleteNetworkInterfaceResponse DeleteNetworkInterfaceSync(DeleteNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteNetworkInterfaceResponse>(req, "DeleteNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public Task<DeleteRouteTableResponse> DeleteRouteTable(DeleteRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteRouteTableResponse>(req, "DeleteRouteTable");
        }

        /// <summary>
        /// 删除路由表
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public DeleteRouteTableResponse DeleteRouteTableSync(DeleteRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteRouteTableResponse>(req, "DeleteRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对某个路由表批量删除路由策略
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public Task<DeleteRoutesResponse> DeleteRoutes(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes");
        }

        /// <summary>
        /// 对某个路由表批量删除路由策略
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public DeleteRoutesResponse DeleteRoutesSync(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 只有当前账号下的安全组允许被删除。
        /// 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// 删除的安全组无法再找回，请谨慎调用。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public Task<DeleteSecurityGroupResponse> DeleteSecurityGroup(DeleteSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup");
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
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public Task<DeleteSecurityGroupPoliciesResponse> DeleteSecurityGroupPolicies(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies");
        }

        /// <summary>
        /// SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public DeleteSecurityGroupPoliciesResponse DeleteSecurityGroupPoliciesSync(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteSnapshots）用于删除快照。
        /// 
        /// * 快照必须处于NORMAL状态，快照状态可以通过[DescribeSnapshots](/document/product/362/15647)接口查询，见输出参数中SnapshotState字段解释。
        /// * 支持批量操作。如果多个快照存在无法删除的快照，则操作不执行，以返回特定的错误码返回。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots");
        }

        /// <summary>
        /// 本接口（DeleteSnapshots）用于删除快照。
        /// 
        /// * 快照必须处于NORMAL状态，快照状态可以通过[DescribeSnapshots](/document/product/362/15647)接口查询，见输出参数中SnapshotState字段解释。
        /// * 支持批量操作。如果多个快照存在无法删除的快照，则操作不执行，以返回特定的错误码返回。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除子网，若子网为可用区下的默认子网，则默认子网会回退到系统自动创建的默认子网，非用户最新创建的子网。若默认子网不满足需求，可调用设置默认子网接口设置。
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet");
        }

        /// <summary>
        /// 删除子网，若子网为可用区下的默认子网，则默认子网会回退到系统自动创建的默认子网，非用户最新创建的子网。若默认子网不满足需求，可调用设置默认子网接口设置。
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public DeleteSubnetResponse DeleteSubnetSync(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除私有网络
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc");
        }

        /// <summary>
        /// 删除私有网络
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public DeleteVpcResponse DeleteVpcSync(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询您账户的弹性公网IP（简称 EIP）在当前地域的配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public Task<DescribeAddressQuotaResponse> DescribeAddressQuota(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota");
        }

        /// <summary>
        /// 查询您账户的弹性公网IP（简称 EIP）在当前地域的配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public DescribeAddressQuotaResponse DescribeAddressQuotaSync(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询弹性公网IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public Task<DescribeAddressesResponse> DescribeAddresses(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses");
        }

        /// <summary>
        /// 查询弹性公网IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public DescribeAddressesResponse DescribeAddressesSync(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取概览页统计的基本数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public Task<DescribeBaseOverviewResponse> DescribeBaseOverview(DescribeBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaseOverviewResponse>(req, "DescribeBaseOverview");
        }

        /// <summary>
        /// 获取概览页统计的基本数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public DescribeBaseOverviewResponse DescribeBaseOverviewSync(DescribeBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaseOverviewResponse>(req, "DescribeBaseOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取带宽硬盘等数据的限制
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig");
        }

        /// <summary>
        /// 获取带宽硬盘等数据的限制
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询导入镜像任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public Task<DescribeCustomImageTaskResponse> DescribeCustomImageTask(DescribeCustomImageTaskRequest req)
        {
            return InternalRequestAsync<DescribeCustomImageTaskResponse>(req, "DescribeCustomImageTask");
        }

        /// <summary>
        /// 查询导入镜像任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public DescribeCustomImageTaskResponse DescribeCustomImageTaskSync(DescribeCustomImageTaskRequest req)
        {
            return InternalRequestAsync<DescribeCustomImageTaskResponse>(req, "DescribeCustomImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可用区的默认子网
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public Task<DescribeDefaultSubnetResponse> DescribeDefaultSubnet(DescribeDefaultSubnetRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSubnetResponse>(req, "DescribeDefaultSubnet");
        }

        /// <summary>
        /// 查询可用区的默认子网
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public DescribeDefaultSubnetResponse DescribeDefaultSubnetSync(DescribeDefaultSubnetRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSubnetResponse>(req, "DescribeDefaultSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDisks）用于查询云硬盘列表。
        /// 
        /// * 可以根据云硬盘ID、云硬盘类型或者云硬盘状态等信息来查询云硬盘的详细信息，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的云硬盘列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks");
        }

        /// <summary>
        /// 本接口（DescribeDisks）用于查询云硬盘列表。
        /// 
        /// * 可以根据云硬盘ID、云硬盘类型或者云硬盘状态等信息来查询云硬盘的详细信息，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// * 如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的云硬盘列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDisksRequest"/></param>
        /// <returns><see cref="DescribeDisksResponse"/></returns>
        public DescribeDisksResponse DescribeDisksSync(DescribeDisksRequest req)
        {
            return InternalRequestAsync<DescribeDisksResponse>(req, "DescribeDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询高可用虚拟IP（HAVIP）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public Task<DescribeHaVipsResponse> DescribeHaVips(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips");
        }

        /// <summary>
        /// 用于查询高可用虚拟IP（HAVIP）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public DescribeHaVipsResponse DescribeHaVipsSync(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage");
        }

        /// <summary>
        /// 展示镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询外部导入镜像支持的OS列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public Task<DescribeImportImageOsResponse> DescribeImportImageOs(DescribeImportImageOsRequest req)
        {
            return InternalRequestAsync<DescribeImportImageOsResponse>(req, "DescribeImportImageOs");
        }

        /// <summary>
        /// 查询外部导入镜像支持的OS列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public DescribeImportImageOsResponse DescribeImportImageOsSync(DescribeImportImageOsRequest req)
        {
            return InternalRequestAsync<DescribeImportImageOsResponse>(req, "DescribeImportImageOs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机型配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public Task<DescribeInstanceTypeConfigResponse> DescribeInstanceTypeConfig(DescribeInstanceTypeConfigRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypeConfigResponse>(req, "DescribeInstanceTypeConfig");
        }

        /// <summary>
        /// 获取机型配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public DescribeInstanceTypeConfigResponse DescribeInstanceTypeConfigSync(DescribeInstanceTypeConfigRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypeConfigResponse>(req, "DescribeInstanceTypeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例管理终端地址
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl");
        }

        /// <summary>
        /// 查询实例管理终端地址
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 获取实例的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过实例id获取当前禁止的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions");
        }

        /// <summary>
        /// 通过实例id获取当前禁止的操作
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡的监听器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// 查询负载均衡的监听器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡相关的任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public Task<DescribeLoadBalanceTaskStatusResponse> DescribeLoadBalanceTaskStatus(DescribeLoadBalanceTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalanceTaskStatusResponse>(req, "DescribeLoadBalanceTaskStatus");
        }

        /// <summary>
        /// 查询负载均衡相关的任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public DescribeLoadBalanceTaskStatusResponse DescribeLoadBalanceTaskStatusSync(DescribeLoadBalanceTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalanceTaskStatusResponse>(req, "DescribeLoadBalanceTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers");
        }

        /// <summary>
        /// 查询负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public Task<DescribeModuleResponse> DescribeModule(DescribeModuleRequest req)
        {
            return InternalRequestAsync<DescribeModuleResponse>(req, "DescribeModule");
        }

        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public DescribeModuleResponse DescribeModuleSync(DescribeModuleRequest req)
        {
            return InternalRequestAsync<DescribeModuleResponse>(req, "DescribeModule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示模块详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public Task<DescribeModuleDetailResponse> DescribeModuleDetail(DescribeModuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeModuleDetailResponse>(req, "DescribeModuleDetail");
        }

        /// <summary>
        /// 展示模块详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public DescribeModuleDetailResponse DescribeModuleDetailSync(DescribeModuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeModuleDetailResponse>(req, "DescribeModuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取客户节点上的出入带宽月峰和计费带宽信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public Task<DescribeMonthPeakNetworkResponse> DescribeMonthPeakNetwork(DescribeMonthPeakNetworkRequest req)
        {
            return InternalRequestAsync<DescribeMonthPeakNetworkResponse>(req, "DescribeMonthPeakNetwork");
        }

        /// <summary>
        /// 获取客户节点上的出入带宽月峰和计费带宽信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public DescribeMonthPeakNetworkResponse DescribeMonthPeakNetworkSync(DescribeMonthPeakNetworkRequest req)
        {
            return InternalRequestAsync<DescribeMonthPeakNetworkResponse>(req, "DescribeMonthPeakNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询弹性网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces");
        }

        /// <summary>
        /// 查询弹性网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesSync(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public Task<DescribeNodeResponse> DescribeNode(DescribeNodeRequest req)
        {
            return InternalRequestAsync<DescribeNodeResponse>(req, "DescribeNode");
        }

        /// <summary>
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public DescribeNodeResponse DescribeNodeSync(DescribeNodeRequest req)
        {
            return InternalRequestAsync<DescribeNodeResponse>(req, "DescribeNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用本接口获取某种机型在某些区域的装箱配额（当使用虚拟机型时，返回的是一组相互关联的装箱配额）。
        /// </summary>
        /// <param name="req"><see cref="DescribePackingQuotaGroupRequest"/></param>
        /// <returns><see cref="DescribePackingQuotaGroupResponse"/></returns>
        public Task<DescribePackingQuotaGroupResponse> DescribePackingQuotaGroup(DescribePackingQuotaGroupRequest req)
        {
            return InternalRequestAsync<DescribePackingQuotaGroupResponse>(req, "DescribePackingQuotaGroup");
        }

        /// <summary>
        /// 使用本接口获取某种机型在某些区域的装箱配额（当使用虚拟机型时，返回的是一组相互关联的装箱配额）。
        /// </summary>
        /// <param name="req"><see cref="DescribePackingQuotaGroupRequest"/></param>
        /// <returns><see cref="DescribePackingQuotaGroupResponse"/></returns>
        public DescribePackingQuotaGroupResponse DescribePackingQuotaGroupSync(DescribePackingQuotaGroupRequest req)
        {
            return InternalRequestAsync<DescribePackingQuotaGroupResponse>(req, "DescribePackingQuotaGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CPU 内存 硬盘等基础信息峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public Task<DescribePeakBaseOverviewResponse> DescribePeakBaseOverview(DescribePeakBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakBaseOverviewResponse>(req, "DescribePeakBaseOverview");
        }

        /// <summary>
        /// CPU 内存 硬盘等基础信息峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public DescribePeakBaseOverviewResponse DescribePeakBaseOverviewSync(DescribePeakBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakBaseOverviewResponse>(req, "DescribePeakBaseOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网络峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public Task<DescribePeakNetworkOverviewResponse> DescribePeakNetworkOverview(DescribePeakNetworkOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakNetworkOverviewResponse>(req, "DescribePeakNetworkOverview");
        }

        /// <summary>
        /// 获取网络峰值数据
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public DescribePeakNetworkOverviewResponse DescribePeakNetworkOverviewSync(DescribePeakNetworkOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakNetworkOverviewResponse>(req, "DescribePeakNetworkOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例价格
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRunInstanceRequest"/></param>
        /// <returns><see cref="DescribePriceRunInstanceResponse"/></returns>
        public Task<DescribePriceRunInstanceResponse> DescribePriceRunInstance(DescribePriceRunInstanceRequest req)
        {
            return InternalRequestAsync<DescribePriceRunInstanceResponse>(req, "DescribePriceRunInstance");
        }

        /// <summary>
        /// 查询实例价格
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRunInstanceRequest"/></param>
        /// <returns><see cref="DescribePriceRunInstanceResponse"/></returns>
        public DescribePriceRunInstanceResponse DescribePriceRunInstanceSync(DescribePriceRunInstanceRequest req)
        {
            return InternalRequestAsync<DescribePriceRunInstanceResponse>(req, "DescribePriceRunInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeRegionIpv6Addresses）用于查询ECM地域之下的IPV6地址信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeRegionIpv6AddressesResponse"/></returns>
        public Task<DescribeRegionIpv6AddressesResponse> DescribeRegionIpv6Addresses(DescribeRegionIpv6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeRegionIpv6AddressesResponse>(req, "DescribeRegionIpv6Addresses");
        }

        /// <summary>
        /// 该接口（DescribeRegionIpv6Addresses）用于查询ECM地域之下的IPV6地址信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeRegionIpv6AddressesResponse"/></returns>
        public DescribeRegionIpv6AddressesResponse DescribeRegionIpv6AddressesSync(DescribeRegionIpv6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeRegionIpv6AddressesResponse>(req, "DescribeRegionIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自定义路由策略与云联网路由策略冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public Task<DescribeRouteConflictsResponse> DescribeRouteConflicts(DescribeRouteConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteConflictsResponse>(req, "DescribeRouteConflicts");
        }

        /// <summary>
        /// 查询自定义路由策略与云联网路由策略冲突列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public DescribeRouteConflictsResponse DescribeRouteConflictsSync(DescribeRouteConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteConflictsResponse>(req, "DescribeRouteConflicts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询路由表对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public Task<DescribeRouteTablesResponse> DescribeRouteTables(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables");
        }

        /// <summary>
        /// 查询路由表对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public DescribeRouteTablesResponse DescribeRouteTablesSync(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全组关联实例统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public Task<DescribeSecurityGroupAssociationStatisticsResponse> DescribeSecurityGroupAssociationStatistics(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics");
        }

        /// <summary>
        /// 查询安全组关联实例统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public DescribeSecurityGroupAssociationStatisticsResponse DescribeSecurityGroupAssociationStatisticsSync(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户安全组配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public Task<DescribeSecurityGroupLimitsResponse> DescribeSecurityGroupLimits(DescribeSecurityGroupLimitsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupLimitsResponse>(req, "DescribeSecurityGroupLimits");
        }

        /// <summary>
        /// 查询用户安全组配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public DescribeSecurityGroupLimitsResponse DescribeSecurityGroupLimitsSync(DescribeSecurityGroupLimitsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupLimitsResponse>(req, "DescribeSecurityGroupLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public Task<DescribeSecurityGroupPoliciesResponse> DescribeSecurityGroupPolicies(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies");
        }

        /// <summary>
        /// 查询安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public DescribeSecurityGroupPoliciesResponse DescribeSecurityGroupPoliciesSync(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看安全组
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups");
        }

        /// <summary>
        /// 查看安全组
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsSync(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// 
        /// * 根据快照ID、创建快照的云硬盘ID、创建快照的云硬盘类型等对结果进行过滤，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// *  如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的快照列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
        }

        /// <summary>
        /// 本接口（DescribeSnapshots）用于查询快照的详细信息。
        /// 
        /// * 根据快照ID、创建快照的云硬盘ID、创建快照的云硬盘类型等对结果进行过滤，不同条件之间为与(AND)的关系，过滤信息详细请见过滤器`Filter`。
        /// *  如果参数为空，返回当前用户一定数量（`Limit`所指定的数量，默认为20）的快照列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets");
        }

        /// <summary>
        /// 查询子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public DescribeSubnetsResponse DescribeSubnetsSync(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取负载均衡后端服务的健康检查状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public Task<DescribeTargetHealthResponse> DescribeTargetHealth(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth");
        }

        /// <summary>
        /// 获取负载均衡后端服务的健康检查状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public DescribeTargetHealthResponse DescribeTargetHealthSync(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public Task<DescribeTargetsResponse> DescribeTargets(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets");
        }

        /// <summary>
        /// 查询负载均衡绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public DescribeTargetsResponse DescribeTargetsSync(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询EIP异步任务执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// 查询EIP异步任务执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeTaskStatus)用于获取异步任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 本接口(DescribeTaskStatus)用于获取异步任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私有网络列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs");
        }

        /// <summary>
        /// 查询私有网络列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public DescribeVpcsResponse DescribeVpcsSync(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachDisks）用于卸载云硬盘。
        /// 
        /// * 支持批量操作，卸载挂载在同一主机上的多块云盘。如果多块云盘中存在不允许卸载的云盘，则操作不执行，返回特定的错误码。
        /// * 本接口为异步接口，当请求成功返回时，云盘并未立即从主机卸载，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHED”变为“UNATTACHED”，则为卸载成功。
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public Task<DetachDisksResponse> DetachDisks(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks");
        }

        /// <summary>
        /// 本接口（DetachDisks）用于卸载云硬盘。
        /// 
        /// * 支持批量操作，卸载挂载在同一主机上的多块云盘。如果多块云盘中存在不允许卸载的云盘，则操作不执行，返回特定的错误码。
        /// * 本接口为异步接口，当请求成功返回时，云盘并未立即从主机卸载，可通过接口[DescribeDisks](/document/product/362/16315)来查询对应云盘的状态，如果云盘的状态由“ATTACHED”变为“UNATTACHED”，则为卸载成功。
        /// </summary>
        /// <param name="req"><see cref="DetachDisksRequest"/></param>
        /// <returns><see cref="DetachDisksResponse"/></returns>
        public DetachDisksResponse DetachDisksSync(DetachDisksRequest req)
        {
            return InternalRequestAsync<DetachDisksResponse>(req, "DetachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 弹性网卡解绑云主机
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public Task<DetachNetworkInterfaceResponse> DetachNetworkInterface(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface");
        }

        /// <summary>
        /// 弹性网卡解绑云主机
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterfaceSync(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用已启用的子网路由
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public Task<DisableRoutesResponse> DisableRoutes(DisableRoutesRequest req)
        {
            return InternalRequestAsync<DisableRoutesResponse>(req, "DisableRoutes");
        }

        /// <summary>
        /// 禁用已启用的子网路由
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public DisableRoutesResponse DisableRoutesSync(DisableRoutesRequest req)
        {
            return InternalRequestAsync<DisableRoutesResponse>(req, "DisableRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑弹性公网IP（简称 EIP）
        /// 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// EIP 如果被封堵，则不能进行解绑定操作。
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public Task<DisassociateAddressResponse> DisassociateAddress(DisassociateAddressRequest req)
        {
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress");
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
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于解除实例的密钥绑定关系。
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs");
        }

        /// <summary>
        /// 用于解除实例的密钥绑定关系。
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑安全组
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// 解绑安全组
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用已禁用的子网路由。
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public Task<EnableRoutesResponse> EnableRoutes(EnableRoutesRequest req)
        {
            return InternalRequestAsync<EnableRoutesResponse>(req, "EnableRoutes");
        }

        /// <summary>
        /// 启用已禁用的子网路由。
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public EnableRoutesResponse EnableRoutesSync(EnableRoutesRequest req)
        {
            return InternalRequestAsync<EnableRoutesResponse>(req, "EnableRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入自定义镜像，支持 RAW、VHD、QCOW2、VMDK 镜像格式
        /// </summary>
        /// <param name="req"><see cref="ImportCustomImageRequest"/></param>
        /// <returns><see cref="ImportCustomImageResponse"/></returns>
        public Task<ImportCustomImageResponse> ImportCustomImage(ImportCustomImageRequest req)
        {
            return InternalRequestAsync<ImportCustomImageResponse>(req, "ImportCustomImage");
        }

        /// <summary>
        /// 导入自定义镜像，支持 RAW、VHD、QCOW2、VMDK 镜像格式
        /// </summary>
        /// <param name="req"><see cref="ImportCustomImageRequest"/></param>
        /// <returns><see cref="ImportCustomImageResponse"/></returns>
        public ImportCustomImageResponse ImportCustomImageSync(ImportCustomImageRequest req)
        {
            return InternalRequestAsync<ImportCustomImageResponse>(req, "ImportCustomImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从CVM产品导入镜像到ECM
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public Task<ImportImageResponse> ImportImage(ImportImageRequest req)
        {
            return InternalRequestAsync<ImportImageResponse>(req, "ImportImage");
        }

        /// <summary>
        /// 从CVM产品导入镜像到ECM
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public ImportImageResponse ImportImageSync(ImportImageRequest req)
        {
            return InternalRequestAsync<ImportImageResponse>(req, "ImportImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 弹性网卡迁移
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public Task<MigrateNetworkInterfaceResponse> MigrateNetworkInterface(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface");
        }

        /// <summary>
        /// 弹性网卡迁移
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public MigrateNetworkInterfaceResponse MigrateNetworkInterfaceSync(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 弹性网卡内网IP迁移。
        /// 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// 迁移前后的弹性网卡必须在同一个子网内。
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public Task<MigratePrivateIpAddressResponse> MigratePrivateIpAddress(MigratePrivateIpAddressRequest req)
        {
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress");
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
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改弹性公网IP属性
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public Task<ModifyAddressAttributeResponse> ModifyAddressAttribute(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute");
        }

        /// <summary>
        /// 修改弹性公网IP属性
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public ModifyAddressAttributeResponse ModifyAddressAttributeSync(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整弹性公网IP带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public Task<ModifyAddressesBandwidthResponse> ModifyAddressesBandwidth(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth");
        }

        /// <summary>
        /// 调整弹性公网IP带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public ModifyAddressesBandwidthResponse ModifyAddressesBandwidthSync(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改在一个可用区下创建实例时使用的默认子网（创建实例时，未填写VPC参数时使用的sunbetId）
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public Task<ModifyDefaultSubnetResponse> ModifyDefaultSubnet(ModifyDefaultSubnetRequest req)
        {
            return InternalRequestAsync<ModifyDefaultSubnetResponse>(req, "ModifyDefaultSubnet");
        }

        /// <summary>
        /// 修改在一个可用区下创建实例时使用的默认子网（创建实例时，未填写VPC参数时使用的sunbetId）
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public ModifyDefaultSubnetResponse ModifyDefaultSubnetSync(ModifyDefaultSubnetRequest req)
        {
            return InternalRequestAsync<ModifyDefaultSubnetResponse>(req, "ModifyDefaultSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改高可用虚拟IP（HAVIP）属性
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public Task<ModifyHaVipAttributeResponse> ModifyHaVipAttribute(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute");
        }

        /// <summary>
        /// 用于修改高可用虚拟IP（HAVIP）属性
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public ModifyHaVipAttributeResponse ModifyHaVipAttributeSync(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyImageAttribute）用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public Task<ModifyImageAttributeResponse> ModifyImageAttribute(ModifyImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyImageAttributeResponse>(req, "ModifyImageAttribute");
        }

        /// <summary>
        /// 本接口（ModifyImageAttribute）用于修改镜像属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public ModifyImageAttributeResponse ModifyImageAttributeSync(ModifyImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyImageAttributeResponse>(req, "ModifyImageAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute");
        }

        /// <summary>
        /// 修改实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡IPv6地址属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public Task<ModifyIpv6AddressesAttributeResponse> ModifyIpv6AddressesAttribute(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute");
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡IPv6地址属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public ModifyIpv6AddressesAttributeResponse ModifyIpv6AddressesAttributeSync(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口(ModifyIpv6AddressesBandwidth)用于修改IPV6地址访问internet的带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesBandwidthResponse"/></returns>
        public Task<ModifyIpv6AddressesBandwidthResponse> ModifyIpv6AddressesBandwidth(ModifyIpv6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesBandwidthResponse>(req, "ModifyIpv6AddressesBandwidth");
        }

        /// <summary>
        /// 该接口(ModifyIpv6AddressesBandwidth)用于修改IPV6地址访问internet的带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesBandwidthResponse"/></returns>
        public ModifyIpv6AddressesBandwidthResponse ModifyIpv6AddressesBandwidthSync(ModifyIpv6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesBandwidthResponse>(req, "ModifyIpv6AddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改负载均衡监听器属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener");
        }

        /// <summary>
        /// 修改负载均衡监听器属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改负载均衡实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes");
        }

        /// <summary>
        /// 修改负载均衡实例的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模块配置，已关联实例的模块不支持调整配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public Task<ModifyModuleConfigResponse> ModifyModuleConfig(ModifyModuleConfigRequest req)
        {
            return InternalRequestAsync<ModifyModuleConfigResponse>(req, "ModifyModuleConfig");
        }

        /// <summary>
        /// 修改模块配置，已关联实例的模块不支持调整配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public ModifyModuleConfigResponse ModifyModuleConfigSync(ModifyModuleConfigRequest req)
        {
            return InternalRequestAsync<ModifyModuleConfigResponse>(req, "ModifyModuleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模块是否禁止分配外网ip的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public Task<ModifyModuleDisableWanIpResponse> ModifyModuleDisableWanIp(ModifyModuleDisableWanIpRequest req)
        {
            return InternalRequestAsync<ModifyModuleDisableWanIpResponse>(req, "ModifyModuleDisableWanIp");
        }

        /// <summary>
        /// 修改模块是否禁止分配外网ip的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public ModifyModuleDisableWanIpResponse ModifyModuleDisableWanIpSync(ModifyModuleDisableWanIpRequest req)
        {
            return InternalRequestAsync<ModifyModuleDisableWanIpResponse>(req, "ModifyModuleDisableWanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模块的默认镜像
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public Task<ModifyModuleImageResponse> ModifyModuleImage(ModifyModuleImageRequest req)
        {
            return InternalRequestAsync<ModifyModuleImageResponse>(req, "ModifyModuleImage");
        }

        /// <summary>
        /// 修改模块的默认镜像
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public ModifyModuleImageResponse ModifyModuleImageSync(ModifyModuleImageRequest req)
        {
            return InternalRequestAsync<ModifyModuleImageResponse>(req, "ModifyModuleImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模块IP直通。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public Task<ModifyModuleIpDirectResponse> ModifyModuleIpDirect(ModifyModuleIpDirectRequest req)
        {
            return InternalRequestAsync<ModifyModuleIpDirectResponse>(req, "ModifyModuleIpDirect");
        }

        /// <summary>
        /// 修改模块IP直通。
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public ModifyModuleIpDirectResponse ModifyModuleIpDirectSync(ModifyModuleIpDirectRequest req)
        {
            return InternalRequestAsync<ModifyModuleIpDirectResponse>(req, "ModifyModuleIpDirect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模块名称
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public Task<ModifyModuleNameResponse> ModifyModuleName(ModifyModuleNameRequest req)
        {
            return InternalRequestAsync<ModifyModuleNameResponse>(req, "ModifyModuleName");
        }

        /// <summary>
        /// 修改模块名称
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public ModifyModuleNameResponse ModifyModuleNameSync(ModifyModuleNameRequest req)
        {
            return InternalRequestAsync<ModifyModuleNameResponse>(req, "ModifyModuleName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模块默认带宽上限
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public Task<ModifyModuleNetworkResponse> ModifyModuleNetwork(ModifyModuleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyModuleNetworkResponse>(req, "ModifyModuleNetwork");
        }

        /// <summary>
        /// 修改模块默认带宽上限
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public ModifyModuleNetworkResponse ModifyModuleNetworkSync(ModifyModuleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyModuleNetworkResponse>(req, "ModifyModuleNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模块默认安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public Task<ModifyModuleSecurityGroupsResponse> ModifyModuleSecurityGroups(ModifyModuleSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyModuleSecurityGroupsResponse>(req, "ModifyModuleSecurityGroups");
        }

        /// <summary>
        /// 修改模块默认安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public ModifyModuleSecurityGroupsResponse ModifyModuleSecurityGroupsSync(ModifyModuleSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyModuleSecurityGroupsResponse>(req, "ModifyModuleSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改弹性网卡内网IP属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public Task<ModifyPrivateIpAddressesAttributeResponse> ModifyPrivateIpAddressesAttribute(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute");
        }

        /// <summary>
        /// 用于修改弹性网卡内网IP属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public ModifyPrivateIpAddressesAttributeResponse ModifyPrivateIpAddressesAttributeSync(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改路由表属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public Task<ModifyRouteTableAttributeResponse> ModifyRouteTableAttribute(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute");
        }

        /// <summary>
        /// 修改路由表属性
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public ModifyRouteTableAttributeResponse ModifyRouteTableAttributeSync(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安全组属性
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute");
        }

        /// <summary>
        /// 修改安全组属性
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttributeSync(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安全组出站和入站规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public Task<ModifySecurityGroupPoliciesResponse> ModifySecurityGroupPolicies(ModifySecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies");
        }

        /// <summary>
        /// 修改安全组出站和入站规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public ModifySecurityGroupPoliciesResponse ModifySecurityGroupPoliciesSync(ModifySecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies")
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
        /// 修改监听器绑定的后端机器的端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public Task<ModifyTargetPortResponse> ModifyTargetPort(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort");
        }

        /// <summary>
        /// 修改监听器绑定的后端机器的端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public ModifyTargetPortResponse ModifyTargetPortSync(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight");
        }

        /// <summary>
        /// 修改监听器绑定的后端机器的转发权重。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改私有网络（VPC）的相关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute");
        }

        /// <summary>
        /// 修改私有网络（VPC）的相关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public ModifyVpcAttributeResponse ModifyVpcAttributeSync(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私有网络下Vpc、子网、havip等异步任务请求结果
        /// </summary>
        /// <param name="req"><see cref="QueryVpcTaskResultRequest"/></param>
        /// <returns><see cref="QueryVpcTaskResultResponse"/></returns>
        public Task<QueryVpcTaskResultResponse> QueryVpcTaskResult(QueryVpcTaskResultRequest req)
        {
            return InternalRequestAsync<QueryVpcTaskResultResponse>(req, "QueryVpcTaskResult");
        }

        /// <summary>
        /// 查询私有网络下Vpc、子网、havip等异步任务请求结果
        /// </summary>
        /// <param name="req"><see cref="QueryVpcTaskResultRequest"/></param>
        /// <returns><see cref="QueryVpcTaskResultResponse"/></returns>
        public QueryVpcTaskResultResponse QueryVpcTaskResultSync(QueryVpcTaskResultRequest req)
        {
            return InternalRequestAsync<QueryVpcTaskResultResponse>(req, "QueryVpcTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 只有状态为RUNNING的实例才可以进行此操作；接口调用成功时，实例会进入REBOOTING状态；重启实例成功时，实例会进入RUNNING状态；支持强制重启，强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances");
        }

        /// <summary>
        /// 只有状态为RUNNING的实例才可以进行此操作；接口调用成功时，实例会进入REBOOTING状态；重启实例成功时，实例会进入RUNNING状态；支持强制重启，强制重启的效果等同于关闭物理计算机的电源开关再重新启动。强制重启可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常重启时使用。
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 释放一个或多个弹性公网IP（简称 EIP）。
        /// 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// 只有状态为 UNBIND 的 EIP 才能进行释放操作。
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public Task<ReleaseAddressesResponse> ReleaseAddresses(ReleaseAddressesRequest req)
        {
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses");
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
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public Task<ReleaseIpv6AddressesResponse> ReleaseIpv6Addresses(ReleaseIpv6AddressesRequest req)
        {
            return InternalRequestAsync<ReleaseIpv6AddressesResponse>(req, "ReleaseIpv6Addresses");
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡IPv6地址。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public ReleaseIpv6AddressesResponse ReleaseIpv6AddressesSync(ReleaseIpv6AddressesRequest req)
        {
            return InternalRequestAsync<ReleaseIpv6AddressesResponse>(req, "ReleaseIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于给弹性公网IPv6地址释放带宽。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesBandwidthResponse"/></returns>
        public Task<ReleaseIpv6AddressesBandwidthResponse> ReleaseIpv6AddressesBandwidth(ReleaseIpv6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ReleaseIpv6AddressesBandwidthResponse>(req, "ReleaseIpv6AddressesBandwidth");
        }

        /// <summary>
        /// 该接口用于给弹性公网IPv6地址释放带宽。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesBandwidthResponse"/></returns>
        public ReleaseIpv6AddressesBandwidthResponse ReleaseIpv6AddressesBandwidthSync(ReleaseIpv6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ReleaseIpv6AddressesBandwidthResponse>(req, "ReleaseIpv6AddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 弹性网卡退还内网 IP。
        /// 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public Task<RemovePrivateIpAddressesResponse> RemovePrivateIpAddresses(RemovePrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<RemovePrivateIpAddressesResponse>(req, "RemovePrivateIpAddresses");
        }

        /// <summary>
        /// 弹性网卡退还内网 IP。
        /// 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public RemovePrivateIpAddressesResponse RemovePrivateIpAddressesSync(RemovePrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<RemovePrivateIpAddressesResponse>(req, "RemovePrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改子网关联的路由表，一个子网只能关联一个路由表。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation");
        }

        /// <summary>
        /// 修改子网关联的路由表，一个子网只能关联一个路由表。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociationSync(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 替换路由策略
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public Task<ReplaceRoutesResponse> ReplaceRoutes(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes");
        }

        /// <summary>
        /// 替换路由策略
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public ReplaceRoutesResponse ReplaceRoutesSync(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 替换单条安全组路由规则, 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public Task<ReplaceSecurityGroupPolicyResponse> ReplaceSecurityGroupPolicy(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy");
        }

        /// <summary>
        /// 替换单条安全组路由规则, 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public ReplaceSecurityGroupPolicyResponse ReplaceSecurityGroupPolicySync(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重装实例，若指定了ImageId参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装；若未指定密码，则密码通过站内信形式随后发送。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public Task<ResetInstancesResponse> ResetInstances(ResetInstancesRequest req)
        {
            return InternalRequestAsync<ResetInstancesResponse>(req, "ResetInstances");
        }

        /// <summary>
        /// 重装实例，若指定了ImageId参数，则使用指定的镜像重装；否则按照当前实例使用的镜像进行重装；若未指定密码，则密码通过站内信形式随后发送。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public ResetInstancesResponse ResetInstancesSync(ResetInstancesRequest req)
        {
            return InternalRequestAsync<ResetInstancesResponse>(req, "ResetInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置实例的最大带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public Task<ResetInstancesMaxBandwidthResponse> ResetInstancesMaxBandwidth(ResetInstancesMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetInstancesMaxBandwidthResponse>(req, "ResetInstancesMaxBandwidth");
        }

        /// <summary>
        /// 重置实例的最大带宽上限。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public ResetInstancesMaxBandwidthResponse ResetInstancesMaxBandwidthSync(ResetInstancesMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetInstancesMaxBandwidthResponse>(req, "ResetInstancesMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置处于运行中状态的实例的密码，需要显式指定强制关机参数ForceStop。如果没有显式指定强制关机参数，则只有处于关机状态的实例才允许执行重置密码操作。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword");
        }

        /// <summary>
        /// 重置处于运行中状态的实例的密码，需要显式指定强制关机参数ForceStop。如果没有显式指定强制关机参数，则只有处于关机状态的实例才允许执行重置密码操作。
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对某个路由表名称和所有路由策略（Route）进行重新设置
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public Task<ResetRoutesResponse> ResetRoutes(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes");
        }

        /// <summary>
        /// 对某个路由表名称和所有路由策略（Route）进行重新设置
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public ResetRoutesResponse ResetRoutesSync(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建ECM实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances");
        }

        /// <summary>
        /// 创建ECM实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置负载均衡实例的安全组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups");
        }

        /// <summary>
        /// 设置负载均衡实例的安全组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers");
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public SetSecurityGroupForLoadbalancersResponse SetSecurityGroupForLoadbalancersSync(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 只有状态为STOPPED的实例才可以进行此操作；接口调用成功时，实例会进入STARTING状态；启动实例成功时，实例会进入RUNNING状态。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances");
        }

        /// <summary>
        /// 只有状态为STOPPED的实例才可以进行此操作；接口调用成功时，实例会进入STARTING状态；启动实例成功时，实例会进入RUNNING状态。
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 只有处于"RUNNING"状态的实例才能够进行关机操作；
        /// 调用成功时，实例会进入STOPPING状态；关闭实例成功时，实例会进入STOPPED状态；
        /// 支持强制关闭，强制关机的效果等同于关闭物理计算机的电源开关，强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances");
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
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TerminateDisks）用于退还云硬盘。
        /// 
        /// * 不再使用的云盘，可通过本接口主动退还。
        /// * 本接口支持退还预付费云盘和按小时后付费云盘。按小时后付费云盘可直接退还，预付费云盘需符合退还规则。
        /// * 支持批量操作，每次请求批量云硬盘的上限为50。如果批量云盘存在不允许操作的，请求会以特定错误码返回。
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public Task<TerminateDisksResponse> TerminateDisks(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks");
        }

        /// <summary>
        /// 本接口（TerminateDisks）用于退还云硬盘。
        /// 
        /// * 不再使用的云盘，可通过本接口主动退还。
        /// * 本接口支持退还预付费云盘和按小时后付费云盘。按小时后付费云盘可直接退还，预付费云盘需符合退还规则。
        /// * 支持批量操作，每次请求批量云硬盘的上限为50。如果批量云盘存在不允许操作的，请求会以特定错误码返回。
        /// </summary>
        /// <param name="req"><see cref="TerminateDisksRequest"/></param>
        /// <returns><see cref="TerminateDisksResponse"/></returns>
        public TerminateDisksResponse TerminateDisksSync(TerminateDisksRequest req)
        {
            return InternalRequestAsync<TerminateDisksResponse>(req, "TerminateDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// 销毁实例
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnassignIpv6SubnetCidrBlock）用于释放IPv6子网段。
        /// 子网段如果还有IP占用且未回收，则子网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public Task<UnassignIpv6SubnetCidrBlockResponse> UnassignIpv6SubnetCidrBlock(UnassignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6SubnetCidrBlockResponse>(req, "UnassignIpv6SubnetCidrBlock");
        }

        /// <summary>
        /// 本接口（UnassignIpv6SubnetCidrBlock）用于释放IPv6子网段。
        /// 子网段如果还有IP占用且未回收，则子网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public UnassignIpv6SubnetCidrBlockResponse UnassignIpv6SubnetCidrBlockSync(UnassignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6SubnetCidrBlockResponse>(req, "UnassignIpv6SubnetCidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
