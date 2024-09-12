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

namespace TencentCloud.Vpc.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vpc.V20170312.Models;

   public class VpcClient : AbstractClient{

       private const string endpoint = "vpc.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1087";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（AcceptAttachCcnInstances）用于跨账号关联实例时，云联网所有者接受并同意关联操作。
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public Task<AcceptAttachCcnInstancesResponse> AcceptAttachCcnInstances(AcceptAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AcceptAttachCcnInstancesResponse>(req, "AcceptAttachCcnInstances");
        }

        /// <summary>
        /// 本接口（AcceptAttachCcnInstances）用于跨账号关联实例时，云联网所有者接受并同意关联操作。
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public AcceptAttachCcnInstancesResponse AcceptAttachCcnInstancesSync(AcceptAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AcceptAttachCcnInstancesResponse>(req, "AcceptAttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AcceptVpcPeeringConnection）用于接受对等连接请求。
        /// </summary>
        /// <param name="req"><see cref="AcceptVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="AcceptVpcPeeringConnectionResponse"/></returns>
        public Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<AcceptVpcPeeringConnectionResponse>(req, "AcceptVpcPeeringConnection");
        }

        /// <summary>
        /// 本接口（AcceptVpcPeeringConnection）用于接受对等连接请求。
        /// </summary>
        /// <param name="req"><see cref="AcceptVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="AcceptVpcPeeringConnectionResponse"/></returns>
        public AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnectionSync(AcceptVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<AcceptVpcPeeringConnectionResponse>(req, "AcceptVpcPeeringConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于添加带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public Task<AddBandwidthPackageResourcesResponse> AddBandwidthPackageResources(AddBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<AddBandwidthPackageResourcesResponse>(req, "AddBandwidthPackageResources");
        }

        /// <summary>
        /// 接口用于添加带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public AddBandwidthPackageResourcesResponse AddBandwidthPackageResourcesSync(AddBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<AddBandwidthPackageResourcesResponse>(req, "AddBandwidthPackageResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 该接口用于在转换实例下添加IPV6转换规则。
        /// 2. 支持在同一个转换实例下批量添加转换规则，一个账户在一个地域最多50个。
        /// 3. 一个完整的转换规则包括vip6:vport6:protocol:vip:vport，其中vip6:vport6:protocol必须是唯一。
        /// </summary>
        /// <param name="req"><see cref="AddIp6RulesRequest"/></param>
        /// <returns><see cref="AddIp6RulesResponse"/></returns>
        public Task<AddIp6RulesResponse> AddIp6Rules(AddIp6RulesRequest req)
        {
            return InternalRequestAsync<AddIp6RulesResponse>(req, "AddIp6Rules");
        }

        /// <summary>
        /// 1. 该接口用于在转换实例下添加IPV6转换规则。
        /// 2. 支持在同一个转换实例下批量添加转换规则，一个账户在一个地域最多50个。
        /// 3. 一个完整的转换规则包括vip6:vport6:protocol:vip:vport，其中vip6:vport6:protocol必须是唯一。
        /// </summary>
        /// <param name="req"><see cref="AddIp6RulesRequest"/></param>
        /// <returns><see cref="AddIp6RulesResponse"/></returns>
        public AddIp6RulesResponse AddIp6RulesSync(AddIp6RulesRequest req)
        {
            return InternalRequestAsync<AddIp6RulesResponse>(req, "AddIp6Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加模板对象中的IP地址、协议端口、IP地址组、协议端口组。
        /// </summary>
        /// <param name="req"><see cref="AddTemplateMemberRequest"/></param>
        /// <returns><see cref="AddTemplateMemberResponse"/></returns>
        public Task<AddTemplateMemberResponse> AddTemplateMember(AddTemplateMemberRequest req)
        {
            return InternalRequestAsync<AddTemplateMemberResponse>(req, "AddTemplateMember");
        }

        /// <summary>
        /// 增加模板对象中的IP地址、协议端口、IP地址组、协议端口组。
        /// </summary>
        /// <param name="req"><see cref="AddTemplateMemberRequest"/></param>
        /// <returns><see cref="AddTemplateMemberResponse"/></returns>
        public AddTemplateMemberResponse AddTemplateMemberSync(AddTemplateMemberRequest req)
        {
            return InternalRequestAsync<AddTemplateMemberResponse>(req, "AddTemplateMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AdjustPublicAddress) 用于更换IP地址，支持更换CVM实例的普通公网IP和包月带宽的EIP。
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public Task<AdjustPublicAddressResponse> AdjustPublicAddress(AdjustPublicAddressRequest req)
        {
            return InternalRequestAsync<AdjustPublicAddressResponse>(req, "AdjustPublicAddress");
        }

        /// <summary>
        /// 本接口 (AdjustPublicAddress) 用于更换IP地址，支持更换CVM实例的普通公网IP和包月带宽的EIP。
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public AdjustPublicAddressResponse AdjustPublicAddressSync(AdjustPublicAddressRequest req)
        {
            return InternalRequestAsync<AdjustPublicAddressResponse>(req, "AdjustPublicAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AllocateAddresses) 用于申请一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * EIP 是专为动态云计算设计的静态 IP 地址。借助 EIP，您可以快速将 EIP 重新映射到您的另一个实例上，从而屏蔽实例故障。
        /// * 您的 EIP 与腾讯云账户相关联，而不是与某个实例相关联。在您选择显式释放该地址，或欠费超过24小时之前，它会一直与您的腾讯云账户保持关联。
        /// * 一个腾讯云账户在每个地域能申请的 EIP 最大配额有所限制，可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)，上述配额可通过 DescribeAddressQuota 接口获取。
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public Task<AllocateAddressesResponse> AllocateAddresses(AllocateAddressesRequest req)
        {
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses");
        }

        /// <summary>
        /// 本接口 (AllocateAddresses) 用于申请一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * EIP 是专为动态云计算设计的静态 IP 地址。借助 EIP，您可以快速将 EIP 重新映射到您的另一个实例上，从而屏蔽实例故障。
        /// * 您的 EIP 与腾讯云账户相关联，而不是与某个实例相关联。在您选择显式释放该地址，或欠费超过24小时之前，它会一直与您的腾讯云账户保持关联。
        /// * 一个腾讯云账户在每个地域能申请的 EIP 最大配额有所限制，可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)，上述配额可通过 DescribeAddressQuota 接口获取。
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public AllocateAddressesResponse AllocateAddressesSync(AllocateAddressesRequest req)
        {
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于给IPv6地址初次分配公网带宽
        /// </summary>
        /// <param name="req"><see cref="AllocateIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="AllocateIp6AddressesBandwidthResponse"/></returns>
        public Task<AllocateIp6AddressesBandwidthResponse> AllocateIp6AddressesBandwidth(AllocateIp6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<AllocateIp6AddressesBandwidthResponse>(req, "AllocateIp6AddressesBandwidth");
        }

        /// <summary>
        /// 该接口用于给IPv6地址初次分配公网带宽
        /// </summary>
        /// <param name="req"><see cref="AllocateIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="AllocateIp6AddressesBandwidthResponse"/></returns>
        public AllocateIp6AddressesBandwidthResponse AllocateIp6AddressesBandwidthSync(AllocateIp6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<AllocateIp6AddressesBandwidthResponse>(req, "AllocateIp6AddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssignIpv6Addresses）用于弹性网卡申请`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 可以指定`IPv6`地址申请，地址类型不能为主`IP`，`IPv6`地址暂时只支持作为辅助`IP`。
        /// * 地址必须要在弹性网卡所在子网内，而且不能被占用。
        /// * 在弹性网卡上申请一个到多个辅助`IPv6`地址，接口会在弹性网卡所在子网段内返回指定数量的辅助`IPv6`地址。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public Task<AssignIpv6AddressesResponse> AssignIpv6Addresses(AssignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<AssignIpv6AddressesResponse>(req, "AssignIpv6Addresses");
        }

        /// <summary>
        /// 本接口（AssignIpv6Addresses）用于弹性网卡申请`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 可以指定`IPv6`地址申请，地址类型不能为主`IP`，`IPv6`地址暂时只支持作为辅助`IP`。
        /// * 地址必须要在弹性网卡所在子网内，而且不能被占用。
        /// * 在弹性网卡上申请一个到多个辅助`IPv6`地址，接口会在弹性网卡所在子网段内返回指定数量的辅助`IPv6`地址。
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
        /// * 使用本接口前，您需要已有VPC实例，如果没有可通过接口<a href="https://cloud.tencent.com/document/api/215/15774" title="CreateVpc" target="_blank">CreateVpc</a>创建。
        /// * 每个VPC只能申请一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public Task<AssignIpv6CidrBlockResponse> AssignIpv6CidrBlock(AssignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6CidrBlockResponse>(req, "AssignIpv6CidrBlock");
        }

        /// <summary>
        /// 本接口（AssignIpv6CidrBlock）用于分配IPv6网段。
        /// * 使用本接口前，您需要已有VPC实例，如果没有可通过接口<a href="https://cloud.tencent.com/document/api/215/15774" title="CreateVpc" target="_blank">CreateVpc</a>创建。
        /// * 每个VPC只能申请一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public AssignIpv6CidrBlockResponse AssignIpv6CidrBlockSync(AssignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6CidrBlockResponse>(req, "AssignIpv6CidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssignIpv6SubnetCidrBlock）用于分配IPv6子网段。
        /// * 给子网分配 `IPv6` 网段，要求子网所属 `VPC` 已获得 `IPv6` 网段。如果尚未分配，请先通过接口 `AssignIpv6CidrBlock` 给子网所属 `VPC` 分配一个 `IPv6` 网段。否则无法分配 `IPv6` 子网段。
        /// * 每个子网只能分配一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public Task<AssignIpv6SubnetCidrBlockResponse> AssignIpv6SubnetCidrBlock(AssignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6SubnetCidrBlockResponse>(req, "AssignIpv6SubnetCidrBlock");
        }

        /// <summary>
        /// 本接口（AssignIpv6SubnetCidrBlock）用于分配IPv6子网段。
        /// * 给子网分配 `IPv6` 网段，要求子网所属 `VPC` 已获得 `IPv6` 网段。如果尚未分配，请先通过接口 `AssignIpv6CidrBlock` 给子网所属 `VPC` 分配一个 `IPv6` 网段。否则无法分配 `IPv6` 子网段。
        /// * 每个子网只能分配一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public AssignIpv6SubnetCidrBlockResponse AssignIpv6SubnetCidrBlockSync(AssignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6SubnetCidrBlockResponse>(req, "AssignIpv6SubnetCidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssignPrivateIpAddresses）用于弹性网卡申请内网 IP。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 可以指定内网IP地址申请，内网IP地址类型不能为主IP，主IP已存在，不能修改，内网IP必须要弹性网卡所在子网内，而且不能被占用。
        /// * 在弹性网卡上申请一个到多个辅助内网IP，接口会在弹性网卡所在子网网段内返回指定数量的辅助内网IP。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses");
        }

        /// <summary>
        /// 本接口（AssignPrivateIpAddresses）用于弹性网卡申请内网 IP。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 可以指定内网IP地址申请，内网IP地址类型不能为主IP，主IP已存在，不能修改，内网IP必须要弹性网卡所在子网内，而且不能被占用。
        /// * 在弹性网卡上申请一个到多个辅助内网IP，接口会在弹性网卡所在子网网段内返回指定数量的辅助内网IP。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddressesSync(AssignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (AssociateAddress) 用于将[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// * 将 EIP 绑定到实例（CVM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// * 将 EIP 绑定到主网卡的主内网IP时，如主内网IP已绑定普通公网IP，必须先退还才能绑定EIP。
        /// * 将 EIP 绑定到指定网卡的内网 IP上（非主网卡的主内网IP），则必须先解绑该 EIP，才能再绑定新的。
        /// * 将 EIP 绑定到内网型CLB实例的功能处于内测阶段，如需使用，请提交[内测申请](https://cloud.tencent.com/apply/p/4kxj7picqci)。
        /// * 将 EIP 绑定到NAT网关，请使用接口[AssociateNatGatewayAddress](https://cloud.tencent.com/document/product/215/36722)
        /// * EIP 如果欠费或被封堵，则不能被绑定。
        /// * 只有状态为 UNBIND 的 EIP 才能够被绑定。
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public Task<AssociateAddressResponse> AssociateAddress(AssociateAddressRequest req)
        {
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress");
        }

        /// <summary>
        /// 本接口 (AssociateAddress) 用于将[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// * 将 EIP 绑定到实例（CVM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// * 将 EIP 绑定到主网卡的主内网IP时，如主内网IP已绑定普通公网IP，必须先退还才能绑定EIP。
        /// * 将 EIP 绑定到指定网卡的内网 IP上（非主网卡的主内网IP），则必须先解绑该 EIP，才能再绑定新的。
        /// * 将 EIP 绑定到内网型CLB实例的功能处于内测阶段，如需使用，请提交[内测申请](https://cloud.tencent.com/apply/p/4kxj7picqci)。
        /// * 将 EIP 绑定到NAT网关，请使用接口[AssociateNatGatewayAddress](https://cloud.tencent.com/document/product/215/36722)
        /// * EIP 如果欠费或被封堵，则不能被绑定。
        /// * 只有状态为 UNBIND 的 EIP 才能够被绑定。
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public AssociateAddressResponse AssociateAddressSync(AssociateAddressRequest req)
        {
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssociateDhcpIpWithAddressIp）用于DhcpIp绑定弹性公网IP（EIP）。<br />
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="AssociateDhcpIpWithAddressIpRequest"/></param>
        /// <returns><see cref="AssociateDhcpIpWithAddressIpResponse"/></returns>
        public Task<AssociateDhcpIpWithAddressIpResponse> AssociateDhcpIpWithAddressIp(AssociateDhcpIpWithAddressIpRequest req)
        {
            return InternalRequestAsync<AssociateDhcpIpWithAddressIpResponse>(req, "AssociateDhcpIpWithAddressIp");
        }

        /// <summary>
        /// 本接口（AssociateDhcpIpWithAddressIp）用于DhcpIp绑定弹性公网IP（EIP）。<br />
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="AssociateDhcpIpWithAddressIpRequest"/></param>
        /// <returns><see cref="AssociateDhcpIpWithAddressIpResponse"/></returns>
        public AssociateDhcpIpWithAddressIpResponse AssociateDhcpIpWithAddressIpSync(AssociateDhcpIpWithAddressIpRequest req)
        {
            return InternalRequestAsync<AssociateDhcpIpWithAddressIpResponse>(req, "AssociateDhcpIpWithAddressIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将专线网关与NAT网关绑定，专线网关默认路由指向NAT网关
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public Task<AssociateDirectConnectGatewayNatGatewayResponse> AssociateDirectConnectGatewayNatGateway(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<AssociateDirectConnectGatewayNatGatewayResponse>(req, "AssociateDirectConnectGatewayNatGateway");
        }

        /// <summary>
        /// 将专线网关与NAT网关绑定，专线网关默认路由指向NAT网关
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public AssociateDirectConnectGatewayNatGatewayResponse AssociateDirectConnectGatewayNatGatewaySync(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<AssociateDirectConnectGatewayNatGatewayResponse>(req, "AssociateDirectConnectGatewayNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssociateInstancesToCcnRouteTable）用于将指定的云联网实例关联到指定的云联网路由表。
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesToCcnRouteTableRequest"/></param>
        /// <returns><see cref="AssociateInstancesToCcnRouteTableResponse"/></returns>
        public Task<AssociateInstancesToCcnRouteTableResponse> AssociateInstancesToCcnRouteTable(AssociateInstancesToCcnRouteTableRequest req)
        {
            return InternalRequestAsync<AssociateInstancesToCcnRouteTableResponse>(req, "AssociateInstancesToCcnRouteTable");
        }

        /// <summary>
        /// 本接口（AssociateInstancesToCcnRouteTable）用于将指定的云联网实例关联到指定的云联网路由表。
        /// </summary>
        /// <param name="req"><see cref="AssociateInstancesToCcnRouteTableRequest"/></param>
        /// <returns><see cref="AssociateInstancesToCcnRouteTableResponse"/></returns>
        public AssociateInstancesToCcnRouteTableResponse AssociateInstancesToCcnRouteTableSync(AssociateInstancesToCcnRouteTableRequest req)
        {
            return InternalRequestAsync<AssociateInstancesToCcnRouteTableResponse>(req, "AssociateInstancesToCcnRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(AssociateNatGatewayAddress)用于NAT网关绑定弹性IP（EIP）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public Task<AssociateNatGatewayAddressResponse> AssociateNatGatewayAddress(AssociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<AssociateNatGatewayAddressResponse>(req, "AssociateNatGatewayAddress");
        }

        /// <summary>
        /// 本接口(AssociateNatGatewayAddress)用于NAT网关绑定弹性IP（EIP）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public AssociateNatGatewayAddressResponse AssociateNatGatewayAddressSync(AssociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<AssociateNatGatewayAddressResponse>(req, "AssociateNatGatewayAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssociateNetworkAclSubnets）用于网络ACL关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public Task<AssociateNetworkAclSubnetsResponse> AssociateNetworkAclSubnets(AssociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkAclSubnetsResponse>(req, "AssociateNetworkAclSubnets");
        }

        /// <summary>
        /// 本接口（AssociateNetworkAclSubnets）用于网络ACL关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public AssociateNetworkAclSubnetsResponse AssociateNetworkAclSubnetsSync(AssociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkAclSubnetsResponse>(req, "AssociateNetworkAclSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssociateNetworkInterfaceSecurityGroups）用于弹性网卡绑定安全组（SecurityGroup）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public Task<AssociateNetworkInterfaceSecurityGroupsResponse> AssociateNetworkInterfaceSecurityGroups(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkInterfaceSecurityGroupsResponse>(req, "AssociateNetworkInterfaceSecurityGroups");
        }

        /// <summary>
        /// 本接口（AssociateNetworkInterfaceSecurityGroups）用于弹性网卡绑定安全组（SecurityGroup）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public AssociateNetworkInterfaceSecurityGroupsResponse AssociateNetworkInterfaceSecurityGroupsSync(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkInterfaceSecurityGroupsResponse>(req, "AssociateNetworkInterfaceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachCcnInstances）用于将网络实例加载到云联网实例中，网络实例包括VPC和专线网关。<br />
        /// 每个云联网能够关联的网络实例个数是有限的，详情请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public Task<AttachCcnInstancesResponse> AttachCcnInstances(AttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AttachCcnInstancesResponse>(req, "AttachCcnInstances");
        }

        /// <summary>
        /// 本接口（AttachCcnInstances）用于将网络实例加载到云联网实例中，网络实例包括VPC和专线网关。<br />
        /// 每个云联网能够关联的网络实例个数是有限的，详情请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public AttachCcnInstancesResponse AttachCcnInstancesSync(AttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AttachCcnInstancesResponse>(req, "AttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(AttachClassicLinkVpc)用于创建私有网络和基础网络设备互通。
        /// * 私有网络和基础网络设备必须在同一个地域。
        /// * 私有网络和基础网络的区别详见vpc产品文档-<a href="https://cloud.tencent.com/document/product/215/30720">私有网络与基础网络</a>。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="AttachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="AttachClassicLinkVpcResponse"/></returns>
        public Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpc(AttachClassicLinkVpcRequest req)
        {
            return InternalRequestAsync<AttachClassicLinkVpcResponse>(req, "AttachClassicLinkVpc");
        }

        /// <summary>
        /// 本接口(AttachClassicLinkVpc)用于创建私有网络和基础网络设备互通。
        /// * 私有网络和基础网络设备必须在同一个地域。
        /// * 私有网络和基础网络的区别详见vpc产品文档-<a href="https://cloud.tencent.com/document/product/215/30720">私有网络与基础网络</a>。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="AttachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="AttachClassicLinkVpcResponse"/></returns>
        public AttachClassicLinkVpcResponse AttachClassicLinkVpcSync(AttachClassicLinkVpcRequest req)
        {
            return InternalRequestAsync<AttachClassicLinkVpcResponse>(req, "AttachClassicLinkVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachNetworkInterface）用于弹性网卡绑定云服务器。
        /// * 一个弹性网卡请至少绑定一个安全组，如需绑定请参见<a href="https://cloud.tencent.com/document/product/215/43132">弹性网卡绑定安全组</a>。
        /// * 一个云服务器可以绑定多个弹性网卡，但只能绑定一个主网卡。更多限制信息详见<a href="https://cloud.tencent.com/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 一个弹性网卡只能同时绑定一个云服务器。
        /// * 只有运行中或者已关机状态的云服务器才能绑定弹性网卡，查看云服务器状态详见<a href="https://cloud.tencent.com/document/api/213/9452#InstanceStatus">腾讯云服务器信息</a>。
        /// * 弹性网卡绑定的云服务器必须是私有网络的，而且云服务器所在可用区必须和弹性网卡子网的可用区相同。
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public Task<AttachNetworkInterfaceResponse> AttachNetworkInterface(AttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface");
        }

        /// <summary>
        /// 本接口（AttachNetworkInterface）用于弹性网卡绑定云服务器。
        /// * 一个弹性网卡请至少绑定一个安全组，如需绑定请参见<a href="https://cloud.tencent.com/document/product/215/43132">弹性网卡绑定安全组</a>。
        /// * 一个云服务器可以绑定多个弹性网卡，但只能绑定一个主网卡。更多限制信息详见<a href="https://cloud.tencent.com/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 一个弹性网卡只能同时绑定一个云服务器。
        /// * 只有运行中或者已关机状态的云服务器才能绑定弹性网卡，查看云服务器状态详见<a href="https://cloud.tencent.com/document/api/213/9452#InstanceStatus">腾讯云服务器信息</a>。
        /// * 弹性网卡绑定的云服务器必须是私有网络的，而且云服务器所在可用区必须和弹性网卡子网的可用区相同。
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterfaceSync(AttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AttachSnapshotInstances）用于快照策略关联实例。
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public Task<AttachSnapshotInstancesResponse> AttachSnapshotInstances(AttachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<AttachSnapshotInstancesResponse>(req, "AttachSnapshotInstances");
        }

        /// <summary>
        /// 本接口（AttachSnapshotInstances）用于快照策略关联实例。
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public AttachSnapshotInstancesResponse AttachSnapshotInstancesSync(AttachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<AttachSnapshotInstancesResponse>(req, "AttachSnapshotInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AuditCrossBorderCompliance）用于服务商操作合规化资质审批。
        /// * 服务商只能操作提交到本服务商的审批单，后台会校验身份。即只授权给服务商的`APPID` 调用本接口。
        /// * `APPROVED` 状态的审批单，可以再次操作为 `DENY`；`DENY` 状态的审批单，也可以再次操作为 `APPROVED`。
        /// </summary>
        /// <param name="req"><see cref="AuditCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="AuditCrossBorderComplianceResponse"/></returns>
        public Task<AuditCrossBorderComplianceResponse> AuditCrossBorderCompliance(AuditCrossBorderComplianceRequest req)
        {
            return InternalRequestAsync<AuditCrossBorderComplianceResponse>(req, "AuditCrossBorderCompliance");
        }

        /// <summary>
        /// 本接口（AuditCrossBorderCompliance）用于服务商操作合规化资质审批。
        /// * 服务商只能操作提交到本服务商的审批单，后台会校验身份。即只授权给服务商的`APPID` 调用本接口。
        /// * `APPROVED` 状态的审批单，可以再次操作为 `DENY`；`DENY` 状态的审批单，也可以再次操作为 `APPROVED`。
        /// </summary>
        /// <param name="req"><see cref="AuditCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="AuditCrossBorderComplianceResponse"/></returns>
        public AuditCrossBorderComplianceResponse AuditCrossBorderComplianceSync(AuditCrossBorderComplianceRequest req)
        {
            return InternalRequestAsync<AuditCrossBorderComplianceResponse>(req, "AuditCrossBorderCompliance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckAssistantCidr）用于检查辅助CIDR是否与存量路由、对等连接（对端VPC的CIDR）等资源存在冲突。如果存在重叠，则返回重叠的资源。
        /// * 检测辅助CIDR是否与当前VPC的主CIDR和辅助CIDR存在重叠。
        /// * 检测辅助CIDR是否与当前VPC的路由的目的端存在重叠。
        /// * 检测辅助CIDR是否与当前VPC的对等连接，对端VPC下的主CIDR或辅助CIDR存在重叠。
        /// </summary>
        /// <param name="req"><see cref="CheckAssistantCidrRequest"/></param>
        /// <returns><see cref="CheckAssistantCidrResponse"/></returns>
        public Task<CheckAssistantCidrResponse> CheckAssistantCidr(CheckAssistantCidrRequest req)
        {
            return InternalRequestAsync<CheckAssistantCidrResponse>(req, "CheckAssistantCidr");
        }

        /// <summary>
        /// 本接口（CheckAssistantCidr）用于检查辅助CIDR是否与存量路由、对等连接（对端VPC的CIDR）等资源存在冲突。如果存在重叠，则返回重叠的资源。
        /// * 检测辅助CIDR是否与当前VPC的主CIDR和辅助CIDR存在重叠。
        /// * 检测辅助CIDR是否与当前VPC的路由的目的端存在重叠。
        /// * 检测辅助CIDR是否与当前VPC的对等连接，对端VPC下的主CIDR或辅助CIDR存在重叠。
        /// </summary>
        /// <param name="req"><see cref="CheckAssistantCidrRequest"/></param>
        /// <returns><see cref="CheckAssistantCidrResponse"/></returns>
        public CheckAssistantCidrResponse CheckAssistantCidrSync(CheckAssistantCidrRequest req)
        {
            return InternalRequestAsync<CheckAssistantCidrResponse>(req, "CheckAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckDefaultSubnet）用于预判是否可建默认子网。
        /// </summary>
        /// <param name="req"><see cref="CheckDefaultSubnetRequest"/></param>
        /// <returns><see cref="CheckDefaultSubnetResponse"/></returns>
        public Task<CheckDefaultSubnetResponse> CheckDefaultSubnet(CheckDefaultSubnetRequest req)
        {
            return InternalRequestAsync<CheckDefaultSubnetResponse>(req, "CheckDefaultSubnet");
        }

        /// <summary>
        /// 本接口（CheckDefaultSubnet）用于预判是否可建默认子网。
        /// </summary>
        /// <param name="req"><see cref="CheckDefaultSubnetRequest"/></param>
        /// <returns><see cref="CheckDefaultSubnetResponse"/></returns>
        public CheckDefaultSubnetResponse CheckDefaultSubnetSync(CheckDefaultSubnetRequest req)
        {
            return InternalRequestAsync<CheckDefaultSubnetResponse>(req, "CheckDefaultSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckNetDetectState）用于验证网络探测。
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public Task<CheckNetDetectStateResponse> CheckNetDetectState(CheckNetDetectStateRequest req)
        {
            return InternalRequestAsync<CheckNetDetectStateResponse>(req, "CheckNetDetectState");
        }

        /// <summary>
        /// 本接口（CheckNetDetectState）用于验证网络探测。
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public CheckNetDetectStateResponse CheckNetDetectStateSync(CheckNetDetectStateRequest req)
        {
            return InternalRequestAsync<CheckNetDetectStateResponse>(req, "CheckNetDetectState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ClearRouteTableSelectionPolicies）用于清空指定云联网的路由表选择策略。
        /// </summary>
        /// <param name="req"><see cref="ClearRouteTableSelectionPoliciesRequest"/></param>
        /// <returns><see cref="ClearRouteTableSelectionPoliciesResponse"/></returns>
        public Task<ClearRouteTableSelectionPoliciesResponse> ClearRouteTableSelectionPolicies(ClearRouteTableSelectionPoliciesRequest req)
        {
            return InternalRequestAsync<ClearRouteTableSelectionPoliciesResponse>(req, "ClearRouteTableSelectionPolicies");
        }

        /// <summary>
        /// 本接口（ClearRouteTableSelectionPolicies）用于清空指定云联网的路由表选择策略。
        /// </summary>
        /// <param name="req"><see cref="ClearRouteTableSelectionPoliciesRequest"/></param>
        /// <returns><see cref="ClearRouteTableSelectionPoliciesResponse"/></returns>
        public ClearRouteTableSelectionPoliciesResponse ClearRouteTableSelectionPoliciesSync(ClearRouteTableSelectionPoliciesRequest req)
        {
            return InternalRequestAsync<ClearRouteTableSelectionPoliciesResponse>(req, "ClearRouteTableSelectionPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloneSecurityGroup）用于根据存量的安全组，克隆创建出同样规则配置的安全组。仅克隆安全组及其规则信息，不会克隆安全组标签信息。
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public Task<CloneSecurityGroupResponse> CloneSecurityGroup(CloneSecurityGroupRequest req)
        {
            return InternalRequestAsync<CloneSecurityGroupResponse>(req, "CloneSecurityGroup");
        }

        /// <summary>
        /// 本接口（CloneSecurityGroup）用于根据存量的安全组，克隆创建出同样规则配置的安全组。仅克隆安全组及其规则信息，不会克隆安全组标签信息。
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public CloneSecurityGroupResponse CloneSecurityGroupSync(CloneSecurityGroupRequest req)
        {
            return InternalRequestAsync<CloneSecurityGroupResponse>(req, "CloneSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAddressTemplate）用于创建IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public Task<CreateAddressTemplateResponse> CreateAddressTemplate(CreateAddressTemplateRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateResponse>(req, "CreateAddressTemplate");
        }

        /// <summary>
        /// 本接口（CreateAddressTemplate）用于创建IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public CreateAddressTemplateResponse CreateAddressTemplateSync(CreateAddressTemplateRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateResponse>(req, "CreateAddressTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAddressTemplateGroup）用于创建IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public Task<CreateAddressTemplateGroupResponse> CreateAddressTemplateGroup(CreateAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateGroupResponse>(req, "CreateAddressTemplateGroup");
        }

        /// <summary>
        /// 本接口（CreateAddressTemplateGroup）用于创建IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public CreateAddressTemplateGroupResponse CreateAddressTemplateGroupSync(CreateAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateGroupResponse>(req, "CreateAddressTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAndAttachNetworkInterface）用于创建弹性网卡并绑定云服务器。
        /// * 创建弹性网卡时可以指定内网IP，并且可以指定一个主IP，指定的内网IP必须在弹性网卡所在子网内，而且不能被占用。
        /// * 创建弹性网卡时可以指定需要申请的内网IP数量，系统会随机生成内网IP地址。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 创建弹性网卡同时可以绑定已有安全组。
        /// * 创建弹性网卡同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateAndAttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateAndAttachNetworkInterfaceResponse"/></returns>
        public Task<CreateAndAttachNetworkInterfaceResponse> CreateAndAttachNetworkInterface(CreateAndAttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateAndAttachNetworkInterfaceResponse>(req, "CreateAndAttachNetworkInterface");
        }

        /// <summary>
        /// 本接口（CreateAndAttachNetworkInterface）用于创建弹性网卡并绑定云服务器。
        /// * 创建弹性网卡时可以指定内网IP，并且可以指定一个主IP，指定的内网IP必须在弹性网卡所在子网内，而且不能被占用。
        /// * 创建弹性网卡时可以指定需要申请的内网IP数量，系统会随机生成内网IP地址。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 创建弹性网卡同时可以绑定已有安全组。
        /// * 创建弹性网卡同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateAndAttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateAndAttachNetworkInterfaceResponse"/></returns>
        public CreateAndAttachNetworkInterfaceResponse CreateAndAttachNetworkInterfaceSync(CreateAndAttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateAndAttachNetworkInterfaceResponse>(req, "CreateAndAttachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAssistantCidr）用于批量创建辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public Task<CreateAssistantCidrResponse> CreateAssistantCidr(CreateAssistantCidrRequest req)
        {
            return InternalRequestAsync<CreateAssistantCidrResponse>(req, "CreateAssistantCidr");
        }

        /// <summary>
        /// 本接口（CreateAssistantCidr）用于批量创建辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public CreateAssistantCidrResponse CreateAssistantCidrSync(CreateAssistantCidrRequest req)
        {
            return InternalRequestAsync<CreateAssistantCidrResponse>(req, "CreateAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateBandwidthPackage) 支持创建[设备带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)和[IP带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)。
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public Task<CreateBandwidthPackageResponse> CreateBandwidthPackage(CreateBandwidthPackageRequest req)
        {
            return InternalRequestAsync<CreateBandwidthPackageResponse>(req, "CreateBandwidthPackage");
        }

        /// <summary>
        /// 本接口 (CreateBandwidthPackage) 支持创建[设备带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)和[IP带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)。
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public CreateBandwidthPackageResponse CreateBandwidthPackageSync(CreateBandwidthPackageRequest req)
        {
            return InternalRequestAsync<CreateBandwidthPackageResponse>(req, "CreateBandwidthPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCcn）用于创建云联网（CCN）。<br />
        /// * 创建云联网同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// * 每个账号能创建的云联网实例个数是有限的，详请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRequest"/></param>
        /// <returns><see cref="CreateCcnResponse"/></returns>
        public Task<CreateCcnResponse> CreateCcn(CreateCcnRequest req)
        {
            return InternalRequestAsync<CreateCcnResponse>(req, "CreateCcn");
        }

        /// <summary>
        /// 本接口（CreateCcn）用于创建云联网（CCN）。<br />
        /// * 创建云联网同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// * 每个账号能创建的云联网实例个数是有限的，详请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRequest"/></param>
        /// <returns><see cref="CreateCcnResponse"/></returns>
        public CreateCcnResponse CreateCcnSync(CreateCcnRequest req)
        {
            return InternalRequestAsync<CreateCcnResponse>(req, "CreateCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCcnRouteTables）用于给指定的云联网实例新建路由表。
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRouteTablesRequest"/></param>
        /// <returns><see cref="CreateCcnRouteTablesResponse"/></returns>
        public Task<CreateCcnRouteTablesResponse> CreateCcnRouteTables(CreateCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<CreateCcnRouteTablesResponse>(req, "CreateCcnRouteTables");
        }

        /// <summary>
        /// 本接口（CreateCcnRouteTables）用于给指定的云联网实例新建路由表。
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRouteTablesRequest"/></param>
        /// <returns><see cref="CreateCcnRouteTablesResponse"/></returns>
        public CreateCcnRouteTablesResponse CreateCcnRouteTablesSync(CreateCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<CreateCcnRouteTablesResponse>(req, "CreateCcnRouteTables")
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
        /// 本接口（CreateDefaultSecurityGroup）用于创建（如果项目下未存在默认安全组，则创建；已存在则获取。）默认安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 默认安全组会放通所有IPv4规则，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// * 创建安全组同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateDefaultSecurityGroupResponse"/></returns>
        public Task<CreateDefaultSecurityGroupResponse> CreateDefaultSecurityGroup(CreateDefaultSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateDefaultSecurityGroupResponse>(req, "CreateDefaultSecurityGroup");
        }

        /// <summary>
        /// 本接口（CreateDefaultSecurityGroup）用于创建（如果项目下未存在默认安全组，则创建；已存在则获取。）默认安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 默认安全组会放通所有IPv4规则，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// * 创建安全组同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateDefaultSecurityGroupResponse"/></returns>
        public CreateDefaultSecurityGroupResponse CreateDefaultSecurityGroupSync(CreateDefaultSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateDefaultSecurityGroupResponse>(req, "CreateDefaultSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDefaultVpc）用于创建默认私有网络(VPC）。
        /// 
        /// 默认VPC适用于快速入门和启动公共实例，您可以像使用任何其他VPC一样使用默认VPC。如果您想创建标准VPC，即指定VPC名称、VPC网段、子网网段、子网可用区，请使用常规创建VPC接口（CreateVpc）
        /// 
        /// 正常情况，本接口并不一定生产默认VPC，而是根据用户账号的网络属性（DescribeAccountAttributes）来决定的
        /// * 支持基础网络、VPC，返回VpcId为0
        /// * 只支持VPC，返回默认VPC信息
        /// 
        /// 您也可以通过 Force 参数，强制返回默认VPC。
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultVpcRequest"/></param>
        /// <returns><see cref="CreateDefaultVpcResponse"/></returns>
        public Task<CreateDefaultVpcResponse> CreateDefaultVpc(CreateDefaultVpcRequest req)
        {
            return InternalRequestAsync<CreateDefaultVpcResponse>(req, "CreateDefaultVpc");
        }

        /// <summary>
        /// 本接口（CreateDefaultVpc）用于创建默认私有网络(VPC）。
        /// 
        /// 默认VPC适用于快速入门和启动公共实例，您可以像使用任何其他VPC一样使用默认VPC。如果您想创建标准VPC，即指定VPC名称、VPC网段、子网网段、子网可用区，请使用常规创建VPC接口（CreateVpc）
        /// 
        /// 正常情况，本接口并不一定生产默认VPC，而是根据用户账号的网络属性（DescribeAccountAttributes）来决定的
        /// * 支持基础网络、VPC，返回VpcId为0
        /// * 只支持VPC，返回默认VPC信息
        /// 
        /// 您也可以通过 Force 参数，强制返回默认VPC。
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultVpcRequest"/></param>
        /// <returns><see cref="CreateDefaultVpcResponse"/></returns>
        public CreateDefaultVpcResponse CreateDefaultVpcSync(CreateDefaultVpcRequest req)
        {
            return InternalRequestAsync<CreateDefaultVpcResponse>(req, "CreateDefaultVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDhcpIp）用于创建DhcpIp。
        /// </summary>
        /// <param name="req"><see cref="CreateDhcpIpRequest"/></param>
        /// <returns><see cref="CreateDhcpIpResponse"/></returns>
        public Task<CreateDhcpIpResponse> CreateDhcpIp(CreateDhcpIpRequest req)
        {
            return InternalRequestAsync<CreateDhcpIpResponse>(req, "CreateDhcpIp");
        }

        /// <summary>
        /// 本接口（CreateDhcpIp）用于创建DhcpIp。
        /// </summary>
        /// <param name="req"><see cref="CreateDhcpIpRequest"/></param>
        /// <returns><see cref="CreateDhcpIpResponse"/></returns>
        public CreateDhcpIpResponse CreateDhcpIpSync(CreateDhcpIpRequest req)
        {
            return InternalRequestAsync<CreateDhcpIpResponse>(req, "CreateDhcpIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGateway）用于创建专线网关。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGateway(CreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayResponse>(req, "CreateDirectConnectGateway");
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGateway）用于创建专线网关。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public CreateDirectConnectGatewayResponse CreateDirectConnectGatewaySync(CreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayResponse>(req, "CreateDirectConnectGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGatewayCcnRoutes）用于创建专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<CreateDirectConnectGatewayCcnRoutesResponse> CreateDirectConnectGatewayCcnRoutes(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayCcnRoutesResponse>(req, "CreateDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGatewayCcnRoutes）用于创建专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public CreateDirectConnectGatewayCcnRoutesResponse CreateDirectConnectGatewayCcnRoutesSync(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayCcnRoutesResponse>(req, "CreateDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateFlowLog）用于创建网络流日志。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public Task<CreateFlowLogResponse> CreateFlowLog(CreateFlowLogRequest req)
        {
            return InternalRequestAsync<CreateFlowLogResponse>(req, "CreateFlowLog");
        }

        /// <summary>
        /// 本接口（CreateFlowLog）用于创建网络流日志。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public CreateFlowLogResponse CreateFlowLogSync(CreateFlowLogRequest req)
        {
            return InternalRequestAsync<CreateFlowLogResponse>(req, "CreateFlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）。
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public Task<CreateHaVipResponse> CreateHaVip(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip");
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）。
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public CreateHaVipResponse CreateHaVipSync(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 该接口用于创建IPV6转换IPV4实例，支持批量
        /// 2. 同一个账户在一个地域最多允许创建10个转换实例
        /// </summary>
        /// <param name="req"><see cref="CreateIp6TranslatorsRequest"/></param>
        /// <returns><see cref="CreateIp6TranslatorsResponse"/></returns>
        public Task<CreateIp6TranslatorsResponse> CreateIp6Translators(CreateIp6TranslatorsRequest req)
        {
            return InternalRequestAsync<CreateIp6TranslatorsResponse>(req, "CreateIp6Translators");
        }

        /// <summary>
        /// 1. 该接口用于创建IPV6转换IPV4实例，支持批量
        /// 2. 同一个账户在一个地域最多允许创建10个转换实例
        /// </summary>
        /// <param name="req"><see cref="CreateIp6TranslatorsRequest"/></param>
        /// <returns><see cref="CreateIp6TranslatorsResponse"/></returns>
        public CreateIp6TranslatorsResponse CreateIp6TranslatorsSync(CreateIp6TranslatorsRequest req)
        {
            return InternalRequestAsync<CreateIp6TranslatorsResponse>(req, "CreateIp6Translators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateLocalGateway）用于创建用于CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public Task<CreateLocalGatewayResponse> CreateLocalGateway(CreateLocalGatewayRequest req)
        {
            return InternalRequestAsync<CreateLocalGatewayResponse>(req, "CreateLocalGateway");
        }

        /// <summary>
        /// 本接口（CreateLocalGateway）用于创建用于CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public CreateLocalGatewayResponse CreateLocalGatewaySync(CreateLocalGatewayRequest req)
        {
            return InternalRequestAsync<CreateLocalGatewayResponse>(req, "CreateLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateNatGateway)用于创建NAT网关。
        /// 在对新建的NAT网关做其他操作前，需先确认此网关已被创建完成（DescribeNatGateway接口返回的实例State字段为AVAILABLE）。
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public Task<CreateNatGatewayResponse> CreateNatGateway(CreateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayResponse>(req, "CreateNatGateway");
        }

        /// <summary>
        /// 本接口(CreateNatGateway)用于创建NAT网关。
        /// 在对新建的NAT网关做其他操作前，需先确认此网关已被创建完成（DescribeNatGateway接口返回的实例State字段为AVAILABLE）。
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public CreateNatGatewayResponse CreateNatGatewaySync(CreateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayResponse>(req, "CreateNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateNatGatewayDestinationIpPortTranslationNatRule)用于创建NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> CreateNatGatewayDestinationIpPortTranslationNatRule(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "CreateNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// 本接口(CreateNatGatewayDestinationIpPortTranslationNatRule)用于创建NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public CreateNatGatewayDestinationIpPortTranslationNatRuleResponse CreateNatGatewayDestinationIpPortTranslationNatRuleSync(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "CreateNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateNatGatewaySourceIpTranslationNatRule)用于创建NAT网关SNAT规则
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public Task<CreateNatGatewaySourceIpTranslationNatRuleResponse> CreateNatGatewaySourceIpTranslationNatRule(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewaySourceIpTranslationNatRuleResponse>(req, "CreateNatGatewaySourceIpTranslationNatRule");
        }

        /// <summary>
        /// 本接口(CreateNatGatewaySourceIpTranslationNatRule)用于创建NAT网关SNAT规则
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public CreateNatGatewaySourceIpTranslationNatRuleResponse CreateNatGatewaySourceIpTranslationNatRuleSync(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewaySourceIpTranslationNatRuleResponse>(req, "CreateNatGatewaySourceIpTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNetDetect）用于创建网络探测。
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public Task<CreateNetDetectResponse> CreateNetDetect(CreateNetDetectRequest req)
        {
            return InternalRequestAsync<CreateNetDetectResponse>(req, "CreateNetDetect");
        }

        /// <summary>
        /// 本接口（CreateNetDetect）用于创建网络探测。
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public CreateNetDetectResponse CreateNetDetectSync(CreateNetDetectRequest req)
        {
            return InternalRequestAsync<CreateNetDetectResponse>(req, "CreateNetDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNetworkAcl）用于创建新的<a href="https://cloud.tencent.com/document/product/215/20088">网络ACL</a>。
        /// * 新建的网络ACL的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用ModifyNetworkAclEntries将网络ACL的规则设置为需要的规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public Task<CreateNetworkAclResponse> CreateNetworkAcl(CreateNetworkAclRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclResponse>(req, "CreateNetworkAcl");
        }

        /// <summary>
        /// 本接口（CreateNetworkAcl）用于创建新的<a href="https://cloud.tencent.com/document/product/215/20088">网络ACL</a>。
        /// * 新建的网络ACL的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用ModifyNetworkAclEntries将网络ACL的规则设置为需要的规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public CreateNetworkAclResponse CreateNetworkAclSync(CreateNetworkAclRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclResponse>(req, "CreateNetworkAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNetworkAclEntries）用于增量添加网络ACL三元组的入站规则和出站规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclEntriesResponse"/></returns>
        public Task<CreateNetworkAclEntriesResponse> CreateNetworkAclEntries(CreateNetworkAclEntriesRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclEntriesResponse>(req, "CreateNetworkAclEntries");
        }

        /// <summary>
        /// 本接口（CreateNetworkAclEntries）用于增量添加网络ACL三元组的入站规则和出站规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclEntriesResponse"/></returns>
        public CreateNetworkAclEntriesResponse CreateNetworkAclEntriesSync(CreateNetworkAclEntriesRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclEntriesResponse>(req, "CreateNetworkAclEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNetworkAclQuintupleEntries）用于增量网络ACL五元组的入站规则和出站规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<CreateNetworkAclQuintupleEntriesResponse> CreateNetworkAclQuintupleEntries(CreateNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclQuintupleEntriesResponse>(req, "CreateNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// 本接口（CreateNetworkAclQuintupleEntries）用于增量网络ACL五元组的入站规则和出站规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public CreateNetworkAclQuintupleEntriesResponse CreateNetworkAclQuintupleEntriesSync(CreateNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclQuintupleEntriesResponse>(req, "CreateNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNetworkInterface）用于创建弹性网卡。
        /// * 创建弹性网卡时可以指定内网IP，并且可以指定一个主IP，指定的内网IP必须在弹性网卡所在子网内，而且不能被占用。
        /// * 创建弹性网卡时可以指定需要申请的内网IP数量，系统会随机生成内网IP地址。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 创建弹性网卡同时可以绑定已有安全组。
        /// * 创建弹性网卡同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public Task<CreateNetworkInterfaceResponse> CreateNetworkInterface(CreateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface");
        }

        /// <summary>
        /// 本接口（CreateNetworkInterface）用于创建弹性网卡。
        /// * 创建弹性网卡时可以指定内网IP，并且可以指定一个主IP，指定的内网IP必须在弹性网卡所在子网内，而且不能被占用。
        /// * 创建弹性网卡时可以指定需要申请的内网IP数量，系统会随机生成内网IP地址。
        /// * 一个弹性网卡支持绑定的IP地址是有限制的，更多资源限制信息详见<a href="/document/product/576/18527">弹性网卡使用限制</a>。
        /// * 创建弹性网卡同时可以绑定已有安全组。
        /// * 创建弹性网卡同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public CreateNetworkInterfaceResponse CreateNetworkInterfaceSync(CreateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreatePrivateNatGateway）用于创建私网NAT网关。
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayResponse"/></returns>
        public Task<CreatePrivateNatGatewayResponse> CreatePrivateNatGateway(CreatePrivateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayResponse>(req, "CreatePrivateNatGateway");
        }

        /// <summary>
        /// 本接口（CreatePrivateNatGateway）用于创建私网NAT网关。
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayResponse"/></returns>
        public CreatePrivateNatGatewayResponse CreatePrivateNatGatewaySync(CreatePrivateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayResponse>(req, "CreatePrivateNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreatePrivateNatGatewayDestinationIpPortTranslationNatRule）用于创建私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse> CreatePrivateNatGatewayDestinationIpPortTranslationNatRule(CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "CreatePrivateNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// 本接口（CreatePrivateNatGatewayDestinationIpPortTranslationNatRule）用于创建私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleSync(CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "CreatePrivateNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ CreatePrivateNatGatewayTranslationAclRule）用于创建私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayTranslationAclRuleRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayTranslationAclRuleResponse"/></returns>
        public Task<CreatePrivateNatGatewayTranslationAclRuleResponse> CreatePrivateNatGatewayTranslationAclRule(CreatePrivateNatGatewayTranslationAclRuleRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayTranslationAclRuleResponse>(req, "CreatePrivateNatGatewayTranslationAclRule");
        }

        /// <summary>
        /// 本接口（ CreatePrivateNatGatewayTranslationAclRule）用于创建私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayTranslationAclRuleRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayTranslationAclRuleResponse"/></returns>
        public CreatePrivateNatGatewayTranslationAclRuleResponse CreatePrivateNatGatewayTranslationAclRuleSync(CreatePrivateNatGatewayTranslationAclRuleRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayTranslationAclRuleResponse>(req, "CreatePrivateNatGatewayTranslationAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreatePrivateNatGatewayTranslationNatRule）用于创建私网NAT网关源端转换规则。
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayTranslationNatRuleResponse"/></returns>
        public Task<CreatePrivateNatGatewayTranslationNatRuleResponse> CreatePrivateNatGatewayTranslationNatRule(CreatePrivateNatGatewayTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayTranslationNatRuleResponse>(req, "CreatePrivateNatGatewayTranslationNatRule");
        }

        /// <summary>
        /// 本接口（CreatePrivateNatGatewayTranslationNatRule）用于创建私网NAT网关源端转换规则。
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNatGatewayTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreatePrivateNatGatewayTranslationNatRuleResponse"/></returns>
        public CreatePrivateNatGatewayTranslationNatRuleResponse CreatePrivateNatGatewayTranslationNatRuleSync(CreatePrivateNatGatewayTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreatePrivateNatGatewayTranslationNatRuleResponse>(req, "CreatePrivateNatGatewayTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateRouteTable)用于创建路由表。
        /// * 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// * 创建路由表同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public Task<CreateRouteTableResponse> CreateRouteTable(CreateRouteTableRequest req)
        {
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable");
        }

        /// <summary>
        /// 本接口(CreateRouteTable)用于创建路由表。
        /// * 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// * 创建路由表同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public CreateRouteTableResponse CreateRouteTableSync(CreateRouteTableRequest req)
        {
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateRoutes）用于创建路由策略。
        /// * 向指定路由表批量新增路由策略。
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public Task<CreateRoutesResponse> CreateRoutes(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes");
        }

        /// <summary>
        /// 本接口（CreateRoutes）用于创建路由策略。
        /// * 向指定路由表批量新增路由策略。
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public CreateRoutesResponse CreateRoutesSync(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSecurityGroup）用于创建新的安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// * 创建安全组同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup");
        }

        /// <summary>
        /// 本接口（CreateSecurityGroup）用于创建新的安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// * 创建安全组同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public CreateSecurityGroupResponse CreateSecurityGroupSync(CreateSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSecurityGroupPolicies）用于创建安全组规则（SecurityGroupPolicy）。
        /// 
        /// 在 SecurityGroupPolicySet 参数中：
        /// <ul>
        /// <li>Version 安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。</li>
        /// <li>在创建出站和入站规则（Egress 和 Ingress）时：<ul>
        /// <li>Protocol 字段支持输入TCP, UDP, ICMP, ICMPV6, GRE, ALL。</li>
        /// <li>CidrBlock 字段允许输入符合cidr格式标准的任意字符串。在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// <li>Ipv6CidrBlock 字段允许输入符合IPv6 cidr格式标准的任意字符串。在基础网络中，如果Ipv6CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// <li>SecurityGroupId 字段允许输入与待修改的安全组位于相同项目中的安全组 ID，包括这个安全组 ID 本身，代表安全组下所有云服务器的内网 IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个 ID 所关联的云服务器变化而变化，不需要重新修改。</li>
        /// <li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受，即 Protocol 字段不是 TCP 或 UDP 时，Protocol 和 Port 是排他关系，不允许同时输入，否则会接口报错。</li>
        /// <li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// <li>CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate 四者是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。IPv6CidrBlock和ICMP是排他关系，如需使用，请输入ICMPV6。</li>
        /// <li>一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。如想在规则最前面插入一条，则填0即可，如果想在最后追加，该字段可不填。</li>
        /// </ul></li></ul>
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupPoliciesResponse"/></returns>
        public Task<CreateSecurityGroupPoliciesResponse> CreateSecurityGroupPolicies(CreateSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies");
        }

        /// <summary>
        /// 本接口（CreateSecurityGroupPolicies）用于创建安全组规则（SecurityGroupPolicy）。
        /// 
        /// 在 SecurityGroupPolicySet 参数中：
        /// <ul>
        /// <li>Version 安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。</li>
        /// <li>在创建出站和入站规则（Egress 和 Ingress）时：<ul>
        /// <li>Protocol 字段支持输入TCP, UDP, ICMP, ICMPV6, GRE, ALL。</li>
        /// <li>CidrBlock 字段允许输入符合cidr格式标准的任意字符串。在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// <li>Ipv6CidrBlock 字段允许输入符合IPv6 cidr格式标准的任意字符串。在基础网络中，如果Ipv6CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// <li>SecurityGroupId 字段允许输入与待修改的安全组位于相同项目中的安全组 ID，包括这个安全组 ID 本身，代表安全组下所有云服务器的内网 IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个 ID 所关联的云服务器变化而变化，不需要重新修改。</li>
        /// <li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受，即 Protocol 字段不是 TCP 或 UDP 时，Protocol 和 Port 是排他关系，不允许同时输入，否则会接口报错。</li>
        /// <li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// <li>CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate 四者是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。IPv6CidrBlock和ICMP是排他关系，如需使用，请输入ICMPV6。</li>
        /// <li>一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。如想在规则最前面插入一条，则填0即可，如果想在最后追加，该字段可不填。</li>
        /// </ul></li></ul>
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupPoliciesResponse"/></returns>
        public CreateSecurityGroupPoliciesResponse CreateSecurityGroupPoliciesSync(CreateSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSecurityGroupWithPolicies）用于创建新的安全组（SecurityGroup），并且可以同时添加安全组规则（SecurityGroupPolicy）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用<a href="https://cloud.tencent.com/document/product/215/15807">CreateSecurityGroupPolicies</a>
        /// 将安全组的规则设置为需要的规则。
        /// 
        /// 安全组规则说明：
        /// * Version安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。
        /// * Protocol字段支持输入TCP, UDP, ICMP, ICMPV6, GRE, ALL。
        /// * CidrBlock字段允许输入符合cidr格式标准的任意字符串。(展开)在基础网络中，如果CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * Ipv6CidrBlock字段允许输入符合IPv6 cidr格式标准的任意字符串。(展开)在基础网络中，如果Ipv6CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * SecurityGroupId字段允许输入与待修改的安全组位于相同项目中的安全组ID，包括这个安全组ID本身，代表安全组下所有云服务器的内网IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。
        /// * Port字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当Protocol字段是TCP或UDP时，Port字段才被接受，即Protocol字段不是TCP或UDP时，Protocol和Port是排他关系，不允许同时输入，否则会接口报错。
        /// * Action字段只允许输入ACCEPT或DROP。
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate四者是排他关系，不允许同时输入，Protocol + Port和ServiceTemplate二者是排他关系，不允许同时输入。
        /// * 一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public Task<CreateSecurityGroupWithPoliciesResponse> CreateSecurityGroupWithPolicies(CreateSecurityGroupWithPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupWithPoliciesResponse>(req, "CreateSecurityGroupWithPolicies");
        }

        /// <summary>
        /// 本接口（CreateSecurityGroupWithPolicies）用于创建新的安全组（SecurityGroup），并且可以同时添加安全组规则（SecurityGroupPolicy）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用<a href="https://cloud.tencent.com/document/product/215/15807">CreateSecurityGroupPolicies</a>
        /// 将安全组的规则设置为需要的规则。
        /// 
        /// 安全组规则说明：
        /// * Version安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。
        /// * Protocol字段支持输入TCP, UDP, ICMP, ICMPV6, GRE, ALL。
        /// * CidrBlock字段允许输入符合cidr格式标准的任意字符串。(展开)在基础网络中，如果CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * Ipv6CidrBlock字段允许输入符合IPv6 cidr格式标准的任意字符串。(展开)在基础网络中，如果Ipv6CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * SecurityGroupId字段允许输入与待修改的安全组位于相同项目中的安全组ID，包括这个安全组ID本身，代表安全组下所有云服务器的内网IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。
        /// * Port字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当Protocol字段是TCP或UDP时，Port字段才被接受，即Protocol字段不是TCP或UDP时，Protocol和Port是排他关系，不允许同时输入，否则会接口报错。
        /// * Action字段只允许输入ACCEPT或DROP。
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate四者是排他关系，不允许同时输入，Protocol + Port和ServiceTemplate二者是排他关系，不允许同时输入。
        /// * 一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public CreateSecurityGroupWithPoliciesResponse CreateSecurityGroupWithPoliciesSync(CreateSecurityGroupWithPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupWithPoliciesResponse>(req, "CreateSecurityGroupWithPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateServiceTemplate）用于创建协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public Task<CreateServiceTemplateResponse> CreateServiceTemplate(CreateServiceTemplateRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateResponse>(req, "CreateServiceTemplate");
        }

        /// <summary>
        /// 本接口（CreateServiceTemplate）用于创建协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public CreateServiceTemplateResponse CreateServiceTemplateSync(CreateServiceTemplateRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateResponse>(req, "CreateServiceTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateServiceTemplateGroup）用于创建协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public Task<CreateServiceTemplateGroupResponse> CreateServiceTemplateGroup(CreateServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateGroupResponse>(req, "CreateServiceTemplateGroup");
        }

        /// <summary>
        /// 本接口（CreateServiceTemplateGroup）用于创建协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public CreateServiceTemplateGroupResponse CreateServiceTemplateGroupSync(CreateServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateGroupResponse>(req, "CreateServiceTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSnapshotPolicies）用于创建快照策略。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public Task<CreateSnapshotPoliciesResponse> CreateSnapshotPolicies(CreateSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSnapshotPoliciesResponse>(req, "CreateSnapshotPolicies");
        }

        /// <summary>
        /// 本接口（CreateSnapshotPolicies）用于创建快照策略。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public CreateSnapshotPoliciesResponse CreateSnapshotPoliciesSync(CreateSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSnapshotPoliciesResponse>(req, "CreateSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSubnet）用于创建子网。
        /// * 创建子网前必须创建好 VPC。
        /// * 子网创建成功后，子网网段不能修改。子网网段必须在VPC网段内，可以和VPC网段相同（VPC有且只有一个子网时），建议子网网段在VPC网段内，预留网段给其他子网使用。
        /// * 您可以创建的最小网段子网掩码为28（有16个IP地址），最大网段子网掩码为16（65,536个IP地址）。
        /// * 同一个VPC内，多个子网的网段不能重叠。
        /// * 子网创建后会自动关联到默认路由表。
        /// * 创建子网同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet");
        }

        /// <summary>
        /// 本接口（CreateSubnet）用于创建子网。
        /// * 创建子网前必须创建好 VPC。
        /// * 子网创建成功后，子网网段不能修改。子网网段必须在VPC网段内，可以和VPC网段相同（VPC有且只有一个子网时），建议子网网段在VPC网段内，预留网段给其他子网使用。
        /// * 您可以创建的最小网段子网掩码为28（有16个IP地址），最大网段子网掩码为16（65,536个IP地址）。
        /// * 同一个VPC内，多个子网的网段不能重叠。
        /// * 子网创建后会自动关联到默认路由表。
        /// * 创建子网同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public CreateSubnetResponse CreateSubnetSync(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSubnets）用于批量创建子网。
        /// * 创建子网前必须创建好 VPC。
        /// * 子网创建成功后，子网网段不能修改。子网网段必须在VPC网段内，可以和VPC网段相同（VPC有且只有一个子网时），建议子网网段在VPC网段内，预留网段给其他子网使用。
        /// * 您可以创建的最小网段子网掩码为28（有16个IP地址），最大网段子网掩码为16（65,536个IP地址）。
        /// * 同一个VPC内，多个子网的网段不能重叠。
        /// * 子网创建后会自动关联到默认路由表。
        /// * 创建子网同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetsRequest"/></param>
        /// <returns><see cref="CreateSubnetsResponse"/></returns>
        public Task<CreateSubnetsResponse> CreateSubnets(CreateSubnetsRequest req)
        {
            return InternalRequestAsync<CreateSubnetsResponse>(req, "CreateSubnets");
        }

        /// <summary>
        /// 本接口（CreateSubnets）用于批量创建子网。
        /// * 创建子网前必须创建好 VPC。
        /// * 子网创建成功后，子网网段不能修改。子网网段必须在VPC网段内，可以和VPC网段相同（VPC有且只有一个子网时），建议子网网段在VPC网段内，预留网段给其他子网使用。
        /// * 您可以创建的最小网段子网掩码为28（有16个IP地址），最大网段子网掩码为16（65,536个IP地址）。
        /// * 同一个VPC内，多个子网的网段不能重叠。
        /// * 子网创建后会自动关联到默认路由表。
        /// * 创建子网同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetsRequest"/></param>
        /// <returns><see cref="CreateSubnetsResponse"/></returns>
        public CreateSubnetsResponse CreateSubnetsSync(CreateSubnetsRequest req)
        {
            return InternalRequestAsync<CreateSubnetsResponse>(req, "CreateSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateTrafficPackages) 用于创建共享流量包。
        /// </summary>
        /// <param name="req"><see cref="CreateTrafficPackagesRequest"/></param>
        /// <returns><see cref="CreateTrafficPackagesResponse"/></returns>
        public Task<CreateTrafficPackagesResponse> CreateTrafficPackages(CreateTrafficPackagesRequest req)
        {
            return InternalRequestAsync<CreateTrafficPackagesResponse>(req, "CreateTrafficPackages");
        }

        /// <summary>
        /// 本接口 (CreateTrafficPackages) 用于创建共享流量包。
        /// </summary>
        /// <param name="req"><see cref="CreateTrafficPackagesRequest"/></param>
        /// <returns><see cref="CreateTrafficPackagesResponse"/></returns>
        public CreateTrafficPackagesResponse CreateTrafficPackagesSync(CreateTrafficPackagesRequest req)
        {
            return InternalRequestAsync<CreateTrafficPackagesResponse>(req, "CreateTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpc）用于创建私有网络（VPC）。
        /// * 用户可以创建的最小网段子网掩码为28（有16个IP地址），10.0.0.0/12，172.16.0.0/12最大网段子网掩码为12（1,048,576个IP地址），192.168.0.0/16最大网段子网掩码为16（65,536个IP地址）如果需要规划VPC网段请参见[网络规划](https://cloud.tencent.com/document/product/215/30313)。
        /// * 同一个地域能创建的VPC资源个数也是有限制的，详见 <a href="https://cloud.tencent.com/doc/product/215/537" title="VPC使用限制">VPC使用限制</a>，如果需要申请更多资源，请提交[工单申请](https://console.cloud.tencent.com/workorder/category)。
        /// * 创建VPC同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc");
        }

        /// <summary>
        /// 本接口（CreateVpc）用于创建私有网络（VPC）。
        /// * 用户可以创建的最小网段子网掩码为28（有16个IP地址），10.0.0.0/12，172.16.0.0/12最大网段子网掩码为12（1,048,576个IP地址），192.168.0.0/16最大网段子网掩码为16（65,536个IP地址）如果需要规划VPC网段请参见[网络规划](https://cloud.tencent.com/document/product/215/30313)。
        /// * 同一个地域能创建的VPC资源个数也是有限制的，详见 <a href="https://cloud.tencent.com/doc/product/215/537" title="VPC使用限制">VPC使用限制</a>，如果需要申请更多资源，请提交[工单申请](https://console.cloud.tencent.com/workorder/category)。
        /// * 创建VPC同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public CreateVpcResponse CreateVpcSync(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpcEndPoint）用于创建终端节点。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public Task<CreateVpcEndPointResponse> CreateVpcEndPoint(CreateVpcEndPointRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointResponse>(req, "CreateVpcEndPoint");
        }

        /// <summary>
        /// 本接口（CreateVpcEndPoint）用于创建终端节点。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public CreateVpcEndPointResponse CreateVpcEndPointSync(CreateVpcEndPointRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointResponse>(req, "CreateVpcEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointService）用于创建终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public Task<CreateVpcEndPointServiceResponse> CreateVpcEndPointService(CreateVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceResponse>(req, "CreateVpcEndPointService");
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointService）用于创建终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public CreateVpcEndPointServiceResponse CreateVpcEndPointServiceSync(CreateVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceResponse>(req, "CreateVpcEndPointService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointServiceWhiteList）创建终端服务白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<CreateVpcEndPointServiceWhiteListResponse> CreateVpcEndPointServiceWhiteList(CreateVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceWhiteListResponse>(req, "CreateVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointServiceWhiteList）创建终端服务白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public CreateVpcEndPointServiceWhiteListResponse CreateVpcEndPointServiceWhiteListSync(CreateVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceWhiteListResponse>(req, "CreateVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpcPeeringConnection）用于创建私有网络对等连接。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="CreateVpcPeeringConnectionResponse"/></returns>
        public Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<CreateVpcPeeringConnectionResponse>(req, "CreateVpcPeeringConnection");
        }

        /// <summary>
        /// 本接口（CreateVpcPeeringConnection）用于创建私有网络对等连接。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="CreateVpcPeeringConnectionResponse"/></returns>
        public CreateVpcPeeringConnectionResponse CreateVpcPeeringConnectionSync(CreateVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<CreateVpcPeeringConnectionResponse>(req, "CreateVpcPeeringConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpnConnection）用于创建VPN通道。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateVpnConnectionRequest"/></param>
        /// <returns><see cref="CreateVpnConnectionResponse"/></returns>
        public Task<CreateVpnConnectionResponse> CreateVpnConnection(CreateVpnConnectionRequest req)
        {
            return InternalRequestAsync<CreateVpnConnectionResponse>(req, "CreateVpnConnection");
        }

        /// <summary>
        /// 本接口（CreateVpnConnection）用于创建VPN通道。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateVpnConnectionRequest"/></param>
        /// <returns><see cref="CreateVpnConnectionResponse"/></returns>
        public CreateVpnConnectionResponse CreateVpnConnectionSync(CreateVpnConnectionRequest req)
        {
            return InternalRequestAsync<CreateVpnConnectionResponse>(req, "CreateVpnConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpnGateway）用于创建VPN网关。
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public Task<CreateVpnGatewayResponse> CreateVpnGateway(CreateVpnGatewayRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayResponse>(req, "CreateVpnGateway");
        }

        /// <summary>
        /// 本接口（CreateVpnGateway）用于创建VPN网关。
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public CreateVpnGatewayResponse CreateVpnGatewaySync(CreateVpnGatewayRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayResponse>(req, "CreateVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建路由型VPN网关的目的路由
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public Task<CreateVpnGatewayRoutesResponse> CreateVpnGatewayRoutes(CreateVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayRoutesResponse>(req, "CreateVpnGatewayRoutes");
        }

        /// <summary>
        /// 创建路由型VPN网关的目的路由
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public CreateVpnGatewayRoutesResponse CreateVpnGatewayRoutesSync(CreateVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayRoutesResponse>(req, "CreateVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建SSL-VPN-CLIENT
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslClientResponse"/></returns>
        public Task<CreateVpnGatewaySslClientResponse> CreateVpnGatewaySslClient(CreateVpnGatewaySslClientRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewaySslClientResponse>(req, "CreateVpnGatewaySslClient");
        }

        /// <summary>
        /// 创建SSL-VPN-CLIENT
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslClientResponse"/></returns>
        public CreateVpnGatewaySslClientResponse CreateVpnGatewaySslClientSync(CreateVpnGatewaySslClientRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewaySslClientResponse>(req, "CreateVpnGatewaySslClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateVpnGatewaySslServer）用于创建SSL-VPN Server端。
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslServerResponse"/></returns>
        public Task<CreateVpnGatewaySslServerResponse> CreateVpnGatewaySslServer(CreateVpnGatewaySslServerRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewaySslServerResponse>(req, "CreateVpnGatewaySslServer");
        }

        /// <summary>
        /// 本接口（CreateVpnGatewaySslServer）用于创建SSL-VPN Server端。
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslServerResponse"/></returns>
        public CreateVpnGatewaySslServerResponse CreateVpnGatewaySslServerSync(CreateVpnGatewaySslServerRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewaySslServerResponse>(req, "CreateVpnGatewaySslServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplate）用于删除IP地址模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public Task<DeleteAddressTemplateResponse> DeleteAddressTemplate(DeleteAddressTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateResponse>(req, "DeleteAddressTemplate");
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplate）用于删除IP地址模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public DeleteAddressTemplateResponse DeleteAddressTemplateSync(DeleteAddressTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateResponse>(req, "DeleteAddressTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplateGroup）用于删除IP地址模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public Task<DeleteAddressTemplateGroupResponse> DeleteAddressTemplateGroup(DeleteAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateGroupResponse>(req, "DeleteAddressTemplateGroup");
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplateGroup）用于删除IP地址模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public DeleteAddressTemplateGroupResponse DeleteAddressTemplateGroupSync(DeleteAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateGroupResponse>(req, "DeleteAddressTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteAssistantCidr）用于删除辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public Task<DeleteAssistantCidrResponse> DeleteAssistantCidr(DeleteAssistantCidrRequest req)
        {
            return InternalRequestAsync<DeleteAssistantCidrResponse>(req, "DeleteAssistantCidr");
        }

        /// <summary>
        /// 本接口（DeleteAssistantCidr）用于删除辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public DeleteAssistantCidrResponse DeleteAssistantCidrSync(DeleteAssistantCidrRequest req)
        {
            return InternalRequestAsync<DeleteAssistantCidrResponse>(req, "DeleteAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口支持删除共享带宽包，包括[设备带宽包](https://cloud.tencent.com/document/product/684/15246#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85)和[IP带宽包](https://cloud.tencent.com/document/product/684/15246#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85)
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackage(DeleteBandwidthPackageRequest req)
        {
            return InternalRequestAsync<DeleteBandwidthPackageResponse>(req, "DeleteBandwidthPackage");
        }

        /// <summary>
        /// 接口支持删除共享带宽包，包括[设备带宽包](https://cloud.tencent.com/document/product/684/15246#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85)和[IP带宽包](https://cloud.tencent.com/document/product/684/15246#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85)
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public DeleteBandwidthPackageResponse DeleteBandwidthPackageSync(DeleteBandwidthPackageRequest req)
        {
            return InternalRequestAsync<DeleteBandwidthPackageResponse>(req, "DeleteBandwidthPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCcn）用于删除云联网。
        /// * 删除后，云联网关联的所有实例间路由将被删除，网络将会中断，请务必确认
        /// * 删除云联网是不可逆的操作，请谨慎处理。
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRequest"/></param>
        /// <returns><see cref="DeleteCcnResponse"/></returns>
        public Task<DeleteCcnResponse> DeleteCcn(DeleteCcnRequest req)
        {
            return InternalRequestAsync<DeleteCcnResponse>(req, "DeleteCcn");
        }

        /// <summary>
        /// 本接口（DeleteCcn）用于删除云联网。
        /// * 删除后，云联网关联的所有实例间路由将被删除，网络将会中断，请务必确认
        /// * 删除云联网是不可逆的操作，请谨慎处理。
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRequest"/></param>
        /// <returns><see cref="DeleteCcnResponse"/></returns>
        public DeleteCcnResponse DeleteCcnSync(DeleteCcnRequest req)
        {
            return InternalRequestAsync<DeleteCcnResponse>(req, "DeleteCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCcnRouteTables）用于删除云联网路由表。
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRouteTablesRequest"/></param>
        /// <returns><see cref="DeleteCcnRouteTablesResponse"/></returns>
        public Task<DeleteCcnRouteTablesResponse> DeleteCcnRouteTables(DeleteCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<DeleteCcnRouteTablesResponse>(req, "DeleteCcnRouteTables");
        }

        /// <summary>
        /// 本接口（DeleteCcnRouteTables）用于删除云联网路由表。
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRouteTablesRequest"/></param>
        /// <returns><see cref="DeleteCcnRouteTablesResponse"/></returns>
        public DeleteCcnRouteTablesResponse DeleteCcnRouteTablesSync(DeleteCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<DeleteCcnRouteTablesResponse>(req, "DeleteCcnRouteTables")
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
        /// 本接口（DeleteDhcpIp）用于删除DhcpIp。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteDhcpIpRequest"/></param>
        /// <returns><see cref="DeleteDhcpIpResponse"/></returns>
        public Task<DeleteDhcpIpResponse> DeleteDhcpIp(DeleteDhcpIpRequest req)
        {
            return InternalRequestAsync<DeleteDhcpIpResponse>(req, "DeleteDhcpIp");
        }

        /// <summary>
        /// 本接口（DeleteDhcpIp）用于删除DhcpIp。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteDhcpIpRequest"/></param>
        /// <returns><see cref="DeleteDhcpIpResponse"/></returns>
        public DeleteDhcpIpResponse DeleteDhcpIpSync(DeleteDhcpIpRequest req)
        {
            return InternalRequestAsync<DeleteDhcpIpResponse>(req, "DeleteDhcpIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGateway）用于删除专线网关。
        /// <li>如果是 NAT 网关，删除专线网关后，NAT 规则以及 ACL 策略都被清理了。</li>
        /// <li>删除专线网关后，系统会删除路由表中跟该专线网关相关的路由策略。</li>
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayResponse"/></returns>
        public Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectGatewayResponse>(req, "DeleteDirectConnectGateway");
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGateway）用于删除专线网关。
        /// <li>如果是 NAT 网关，删除专线网关后，NAT 规则以及 ACL 策略都被清理了。</li>
        /// <li>删除专线网关后，系统会删除路由表中跟该专线网关相关的路由策略。</li>
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayResponse"/></returns>
        public DeleteDirectConnectGatewayResponse DeleteDirectConnectGatewaySync(DeleteDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectGatewayResponse>(req, "DeleteDirectConnectGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGatewayCcnRoutes）用于删除专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<DeleteDirectConnectGatewayCcnRoutesResponse> DeleteDirectConnectGatewayCcnRoutes(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectGatewayCcnRoutesResponse>(req, "DeleteDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGatewayCcnRoutes）用于删除专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DeleteDirectConnectGatewayCcnRoutesResponse DeleteDirectConnectGatewayCcnRoutesSync(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectGatewayCcnRoutesResponse>(req, "DeleteDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteFlowLog）用于删除流日志。
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public Task<DeleteFlowLogResponse> DeleteFlowLog(DeleteFlowLogRequest req)
        {
            return InternalRequestAsync<DeleteFlowLogResponse>(req, "DeleteFlowLog");
        }

        /// <summary>
        /// 本接口（DeleteFlowLog）用于删除流日志。
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public DeleteFlowLogResponse DeleteFlowLogSync(DeleteFlowLogRequest req)
        {
            return InternalRequestAsync<DeleteFlowLogResponse>(req, "DeleteFlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteHaVip）用于删除高可用虚拟IP（HAVIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public Task<DeleteHaVipResponse> DeleteHaVip(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip");
        }

        /// <summary>
        /// 本接口（DeleteHaVip）用于删除高可用虚拟IP（HAVIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public DeleteHaVipResponse DeleteHaVipSync(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 该接口用于释放IPV6转换实例，支持批量。
        /// 2.  如果IPV6转换实例建立有转换规则，会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DeleteIp6TranslatorsResponse"/></returns>
        public Task<DeleteIp6TranslatorsResponse> DeleteIp6Translators(DeleteIp6TranslatorsRequest req)
        {
            return InternalRequestAsync<DeleteIp6TranslatorsResponse>(req, "DeleteIp6Translators");
        }

        /// <summary>
        /// 1. 该接口用于释放IPV6转换实例，支持批量。
        /// 2.  如果IPV6转换实例建立有转换规则，会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DeleteIp6TranslatorsResponse"/></returns>
        public DeleteIp6TranslatorsResponse DeleteIp6TranslatorsSync(DeleteIp6TranslatorsRequest req)
        {
            return InternalRequestAsync<DeleteIp6TranslatorsResponse>(req, "DeleteIp6Translators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteLocalGateway）用于删除CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public Task<DeleteLocalGatewayResponse> DeleteLocalGateway(DeleteLocalGatewayRequest req)
        {
            return InternalRequestAsync<DeleteLocalGatewayResponse>(req, "DeleteLocalGateway");
        }

        /// <summary>
        /// 本接口（DeleteLocalGateway）用于删除CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public DeleteLocalGatewayResponse DeleteLocalGatewaySync(DeleteLocalGatewayRequest req)
        {
            return InternalRequestAsync<DeleteLocalGatewayResponse>(req, "DeleteLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNatGateway）用于删除NAT网关。
        /// 删除 NAT 网关后，系统会自动删除路由表中包含此 NAT 网关的路由项，同时也会解绑弹性公网IP（EIP）。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public Task<DeleteNatGatewayResponse> DeleteNatGateway(DeleteNatGatewayRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayResponse>(req, "DeleteNatGateway");
        }

        /// <summary>
        /// 本接口（DeleteNatGateway）用于删除NAT网关。
        /// 删除 NAT 网关后，系统会自动删除路由表中包含此 NAT 网关的路由项，同时也会解绑弹性公网IP（EIP）。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public DeleteNatGatewayResponse DeleteNatGatewaySync(DeleteNatGatewayRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayResponse>(req, "DeleteNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNatGatewayDestinationIpPortTranslationNatRule）用于删除NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> DeleteNatGatewayDestinationIpPortTranslationNatRule(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// 本接口（DeleteNatGatewayDestinationIpPortTranslationNatRule）用于删除NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse DeleteNatGatewayDestinationIpPortTranslationNatRuleSync(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNatGatewaySourceIpTranslationNatRule）用于删除NAT网关端口SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public Task<DeleteNatGatewaySourceIpTranslationNatRuleResponse> DeleteNatGatewaySourceIpTranslationNatRule(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewaySourceIpTranslationNatRuleResponse>(req, "DeleteNatGatewaySourceIpTranslationNatRule");
        }

        /// <summary>
        /// 本接口（DeleteNatGatewaySourceIpTranslationNatRule）用于删除NAT网关端口SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewaySourceIpTranslationNatRuleResponse DeleteNatGatewaySourceIpTranslationNatRuleSync(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewaySourceIpTranslationNatRuleResponse>(req, "DeleteNatGatewaySourceIpTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNetDetect）用于删除网络探测实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public Task<DeleteNetDetectResponse> DeleteNetDetect(DeleteNetDetectRequest req)
        {
            return InternalRequestAsync<DeleteNetDetectResponse>(req, "DeleteNetDetect");
        }

        /// <summary>
        /// 本接口（DeleteNetDetect）用于删除网络探测实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public DeleteNetDetectResponse DeleteNetDetectSync(DeleteNetDetectRequest req)
        {
            return InternalRequestAsync<DeleteNetDetectResponse>(req, "DeleteNetDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNetworkAcl）用于删除网络ACL。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public Task<DeleteNetworkAclResponse> DeleteNetworkAcl(DeleteNetworkAclRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclResponse>(req, "DeleteNetworkAcl");
        }

        /// <summary>
        /// 本接口（DeleteNetworkAcl）用于删除网络ACL。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public DeleteNetworkAclResponse DeleteNetworkAclSync(DeleteNetworkAclRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclResponse>(req, "DeleteNetworkAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNetworkAclEntries）用于删除三元组网络ACL的入站规则和出站规则。在NetworkAclEntrySet参数中：
        /// * 删除IPv4规则，需要传入NetworkAclIpv4EntryId。
        /// * 删除IPv6规则，需要传入NetworkAclIpv6EntryId。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclEntriesResponse"/></returns>
        public Task<DeleteNetworkAclEntriesResponse> DeleteNetworkAclEntries(DeleteNetworkAclEntriesRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclEntriesResponse>(req, "DeleteNetworkAclEntries");
        }

        /// <summary>
        /// 本接口（DeleteNetworkAclEntries）用于删除三元组网络ACL的入站规则和出站规则。在NetworkAclEntrySet参数中：
        /// * 删除IPv4规则，需要传入NetworkAclIpv4EntryId。
        /// * 删除IPv6规则，需要传入NetworkAclIpv6EntryId。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclEntriesResponse"/></returns>
        public DeleteNetworkAclEntriesResponse DeleteNetworkAclEntriesSync(DeleteNetworkAclEntriesRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclEntriesResponse>(req, "DeleteNetworkAclEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNetworkAclQuintupleEntries）用于删除网络ACL五元组指定的入站规则和出站规则（但不是全量删除该ACL下的所有条目）。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<DeleteNetworkAclQuintupleEntriesResponse> DeleteNetworkAclQuintupleEntries(DeleteNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclQuintupleEntriesResponse>(req, "DeleteNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// 本接口（DeleteNetworkAclQuintupleEntries）用于删除网络ACL五元组指定的入站规则和出站规则（但不是全量删除该ACL下的所有条目）。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public DeleteNetworkAclQuintupleEntriesResponse DeleteNetworkAclQuintupleEntriesSync(DeleteNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclQuintupleEntriesResponse>(req, "DeleteNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNetworkInterface）用于删除弹性网卡。
        /// * 弹性网卡上绑定了云服务器时，不能被删除。
        /// * 删除指定弹性网卡，弹性网卡必须先和子机解绑才能删除。删除之后弹性网卡上所有内网IP都将被退还。
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterface(DeleteNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteNetworkInterfaceResponse>(req, "DeleteNetworkInterface");
        }

        /// <summary>
        /// 本接口（DeleteNetworkInterface）用于删除弹性网卡。
        /// * 弹性网卡上绑定了云服务器时，不能被删除。
        /// * 删除指定弹性网卡，弹性网卡必须先和子机解绑才能删除。删除之后弹性网卡上所有内网IP都将被退还。
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public DeleteNetworkInterfaceResponse DeleteNetworkInterfaceSync(DeleteNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteNetworkInterfaceResponse>(req, "DeleteNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGateway）用于删除私网NAT网关。
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayResponse"/></returns>
        public Task<DeletePrivateNatGatewayResponse> DeletePrivateNatGateway(DeletePrivateNatGatewayRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayResponse>(req, "DeletePrivateNatGateway");
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGateway）用于删除私网NAT网关。
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayResponse"/></returns>
        public DeletePrivateNatGatewayResponse DeletePrivateNatGatewaySync(DeletePrivateNatGatewayRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayResponse>(req, "DeletePrivateNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGatewayDestinationIpPortTranslationNatRule）用于删除私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse> DeletePrivateNatGatewayDestinationIpPortTranslationNatRule(DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "DeletePrivateNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGatewayDestinationIpPortTranslationNatRule）用于删除私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleSync(DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "DeletePrivateNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGatewayTranslationAclRule）用于删除私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayTranslationAclRuleRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayTranslationAclRuleResponse"/></returns>
        public Task<DeletePrivateNatGatewayTranslationAclRuleResponse> DeletePrivateNatGatewayTranslationAclRule(DeletePrivateNatGatewayTranslationAclRuleRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayTranslationAclRuleResponse>(req, "DeletePrivateNatGatewayTranslationAclRule");
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGatewayTranslationAclRule）用于删除私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayTranslationAclRuleRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayTranslationAclRuleResponse"/></returns>
        public DeletePrivateNatGatewayTranslationAclRuleResponse DeletePrivateNatGatewayTranslationAclRuleSync(DeletePrivateNatGatewayTranslationAclRuleRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayTranslationAclRuleResponse>(req, "DeletePrivateNatGatewayTranslationAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGatewayTranslationNatRule）用于删除私网NAT网关源端转换规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayTranslationNatRuleResponse"/></returns>
        public Task<DeletePrivateNatGatewayTranslationNatRuleResponse> DeletePrivateNatGatewayTranslationNatRule(DeletePrivateNatGatewayTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayTranslationNatRuleResponse>(req, "DeletePrivateNatGatewayTranslationNatRule");
        }

        /// <summary>
        /// 本接口（DeletePrivateNatGatewayTranslationNatRule）用于删除私网NAT网关源端转换规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNatGatewayTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeletePrivateNatGatewayTranslationNatRuleResponse"/></returns>
        public DeletePrivateNatGatewayTranslationNatRuleResponse DeletePrivateNatGatewayTranslationNatRuleSync(DeletePrivateNatGatewayTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeletePrivateNatGatewayTranslationNatRuleResponse>(req, "DeletePrivateNatGatewayTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteRouteTable）用于删除路由表。
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public Task<DeleteRouteTableResponse> DeleteRouteTable(DeleteRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteRouteTableResponse>(req, "DeleteRouteTable");
        }

        /// <summary>
        /// 本接口（DeleteRouteTable）用于删除路由表。
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public DeleteRouteTableResponse DeleteRouteTableSync(DeleteRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteRouteTableResponse>(req, "DeleteRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteRoutes)用于对某个路由表批量删除路由策略（Route）。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public Task<DeleteRoutesResponse> DeleteRoutes(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes");
        }

        /// <summary>
        /// 本接口(DeleteRoutes)用于对某个路由表批量删除路由策略（Route）。
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public DeleteRoutesResponse DeleteRoutesSync(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteSecurityGroup）用于删除安全组（SecurityGroup）。
        /// * 只有当前账号下的安全组允许被删除。
        /// * 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// * 删除的安全组无法再找回，请谨慎调用。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public Task<DeleteSecurityGroupResponse> DeleteSecurityGroup(DeleteSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup");
        }

        /// <summary>
        /// 本接口（DeleteSecurityGroup）用于删除安全组（SecurityGroup）。
        /// * 只有当前账号下的安全组允许被删除。
        /// * 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// * 删除的安全组无法再找回，请谨慎调用。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public DeleteSecurityGroupResponse DeleteSecurityGroupSync(DeleteSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteSecurityGroupPolicies）用于用于删除安全组规则（SecurityGroupPolicy）。
        /// * SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public Task<DeleteSecurityGroupPoliciesResponse> DeleteSecurityGroupPolicies(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies");
        }

        /// <summary>
        /// 本接口（DeleteSecurityGroupPolicies）用于用于删除安全组规则（SecurityGroupPolicy）。
        /// * SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public DeleteSecurityGroupPoliciesResponse DeleteSecurityGroupPoliciesSync(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplate）用于删除协议端口模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public Task<DeleteServiceTemplateResponse> DeleteServiceTemplate(DeleteServiceTemplateRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateResponse>(req, "DeleteServiceTemplate");
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplate）用于删除协议端口模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public DeleteServiceTemplateResponse DeleteServiceTemplateSync(DeleteServiceTemplateRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateResponse>(req, "DeleteServiceTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplateGroup）用于删除协议端口模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public Task<DeleteServiceTemplateGroupResponse> DeleteServiceTemplateGroup(DeleteServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateGroupResponse>(req, "DeleteServiceTemplateGroup");
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplateGroup）用于删除协议端口模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public DeleteServiceTemplateGroupResponse DeleteServiceTemplateGroupSync(DeleteServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateGroupResponse>(req, "DeleteServiceTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteSnapshotPolicies）用于删除快照策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public Task<DeleteSnapshotPoliciesResponse> DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotPoliciesResponse>(req, "DeleteSnapshotPolicies");
        }

        /// <summary>
        /// 本接口（DeleteSnapshotPolicies）用于删除快照策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public DeleteSnapshotPoliciesResponse DeleteSnapshotPoliciesSync(DeleteSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotPoliciesResponse>(req, "DeleteSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteSubnet）用于删除子网（Subnet）。
        /// * 删除子网前，请清理该子网下所有资源，包括云服务器、负载均衡、云数据、NoSQL、弹性网卡等资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet");
        }

        /// <summary>
        /// 本接口（DeleteSubnet）用于删除子网（Subnet）。
        /// * 删除子网前，请清理该子网下所有资源，包括云服务器、负载均衡、云数据、NoSQL、弹性网卡等资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public DeleteSubnetResponse DeleteSubnetSync(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除模板对象中的IP地址、协议端口、IP地址组、协议端口组。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateMemberRequest"/></param>
        /// <returns><see cref="DeleteTemplateMemberResponse"/></returns>
        public Task<DeleteTemplateMemberResponse> DeleteTemplateMember(DeleteTemplateMemberRequest req)
        {
            return InternalRequestAsync<DeleteTemplateMemberResponse>(req, "DeleteTemplateMember");
        }

        /// <summary>
        /// 删除模板对象中的IP地址、协议端口、IP地址组、协议端口组。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateMemberRequest"/></param>
        /// <returns><see cref="DeleteTemplateMemberResponse"/></returns>
        public DeleteTemplateMemberResponse DeleteTemplateMemberSync(DeleteTemplateMemberRequest req)
        {
            return InternalRequestAsync<DeleteTemplateMemberResponse>(req, "DeleteTemplateMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除共享带宽包（仅非活动状态的流量包可删除）。
        /// </summary>
        /// <param name="req"><see cref="DeleteTrafficPackagesRequest"/></param>
        /// <returns><see cref="DeleteTrafficPackagesResponse"/></returns>
        public Task<DeleteTrafficPackagesResponse> DeleteTrafficPackages(DeleteTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DeleteTrafficPackagesResponse>(req, "DeleteTrafficPackages");
        }

        /// <summary>
        /// 删除共享带宽包（仅非活动状态的流量包可删除）。
        /// </summary>
        /// <param name="req"><see cref="DeleteTrafficPackagesRequest"/></param>
        /// <returns><see cref="DeleteTrafficPackagesResponse"/></returns>
        public DeleteTrafficPackagesResponse DeleteTrafficPackagesSync(DeleteTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DeleteTrafficPackagesResponse>(req, "DeleteTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpc）用于删除私有网络。
        /// * 删除前请确保 VPC 内已经没有相关资源，例如云服务器、云数据库、NoSQL、VPN网关、专线网关、负载均衡、对等连接、与之互通的基础网络设备等。
        /// * 删除私有网络是不可逆的操作，请谨慎处理。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc");
        }

        /// <summary>
        /// 本接口（DeleteVpc）用于删除私有网络。
        /// * 删除前请确保 VPC 内已经没有相关资源，例如云服务器、云数据库、NoSQL、VPN网关、专线网关、负载均衡、对等连接、与之互通的基础网络设备等。
        /// * 删除私有网络是不可逆的操作，请谨慎处理。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public DeleteVpcResponse DeleteVpcSync(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPoint）用于删除终端节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public Task<DeleteVpcEndPointResponse> DeleteVpcEndPoint(DeleteVpcEndPointRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointResponse>(req, "DeleteVpcEndPoint");
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPoint）用于删除终端节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public DeleteVpcEndPointResponse DeleteVpcEndPointSync(DeleteVpcEndPointRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointResponse>(req, "DeleteVpcEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointService）用于删除终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public Task<DeleteVpcEndPointServiceResponse> DeleteVpcEndPointService(DeleteVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceResponse>(req, "DeleteVpcEndPointService");
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointService）用于删除终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public DeleteVpcEndPointServiceResponse DeleteVpcEndPointServiceSync(DeleteVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceResponse>(req, "DeleteVpcEndPointService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointServiceWhiteList）用于删除终端节点服务白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<DeleteVpcEndPointServiceWhiteListResponse> DeleteVpcEndPointServiceWhiteList(DeleteVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceWhiteListResponse>(req, "DeleteVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointServiceWhiteList）用于删除终端节点服务白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public DeleteVpcEndPointServiceWhiteListResponse DeleteVpcEndPointServiceWhiteListSync(DeleteVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceWhiteListResponse>(req, "DeleteVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpcPeeringConnection）用于删除私有网络对等连接。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpcPeeringConnectionResponse"/></returns>
        public Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpcPeeringConnectionResponse>(req, "DeleteVpcPeeringConnection");
        }

        /// <summary>
        /// 本接口（DeleteVpcPeeringConnection）用于删除私有网络对等连接。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpcPeeringConnectionResponse"/></returns>
        public DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnectionSync(DeleteVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpcPeeringConnectionResponse>(req, "DeleteVpcPeeringConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpnConnection）用于删除VPN通道。
        /// >?本接口为异步接口
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
        public Task<DeleteVpnConnectionResponse> DeleteVpnConnection(DeleteVpnConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpnConnectionResponse>(req, "DeleteVpnConnection");
        }

        /// <summary>
        /// 本接口（DeleteVpnConnection）用于删除VPN通道。
        /// >?本接口为异步接口
        /// >
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
        /// 本接口（DeleteVpnGatewayRoutes）用于删除VPN网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public Task<DeleteVpnGatewayRoutesResponse> DeleteVpnGatewayRoutes(DeleteVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayRoutesResponse>(req, "DeleteVpnGatewayRoutes");
        }

        /// <summary>
        /// 本接口（DeleteVpnGatewayRoutes）用于删除VPN网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public DeleteVpnGatewayRoutesResponse DeleteVpnGatewayRoutesSync(DeleteVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayRoutesResponse>(req, "DeleteVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteVpnGatewaySslClient）用于删除SSL-VPN-CLIENT。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslClientResponse"/></returns>
        public Task<DeleteVpnGatewaySslClientResponse> DeleteVpnGatewaySslClient(DeleteVpnGatewaySslClientRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewaySslClientResponse>(req, "DeleteVpnGatewaySslClient");
        }

        /// <summary>
        /// 本接口（DeleteVpnGatewaySslClient）用于删除SSL-VPN-CLIENT。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslClientResponse"/></returns>
        public DeleteVpnGatewaySslClientResponse DeleteVpnGatewaySslClientSync(DeleteVpnGatewaySslClientRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewaySslClientResponse>(req, "DeleteVpnGatewaySslClient")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除SSL-VPN-SERVER 实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslServerResponse"/></returns>
        public Task<DeleteVpnGatewaySslServerResponse> DeleteVpnGatewaySslServer(DeleteVpnGatewaySslServerRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewaySslServerResponse>(req, "DeleteVpnGatewaySslServer");
        }

        /// <summary>
        /// 删除SSL-VPN-SERVER 实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslServerResponse"/></returns>
        public DeleteVpnGatewaySslServerResponse DeleteVpnGatewaySslServerSync(DeleteVpnGatewaySslServerRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewaySslServerResponse>(req, "DeleteVpnGatewaySslServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccountAttributes）用于查询用户账号私有属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributes(DescribeAccountAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAccountAttributesResponse>(req, "DescribeAccountAttributes");
        }

        /// <summary>
        /// 本接口（DescribeAccountAttributes）用于查询用户账号私有属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributesSync(DescribeAccountAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAccountAttributesResponse>(req, "DescribeAccountAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeAddressQuota) 用于查询您账户的[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）在当前地域的配额信息。配额详情可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public Task<DescribeAddressQuotaResponse> DescribeAddressQuota(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota");
        }

        /// <summary>
        /// 本接口 (DescribeAddressQuota) 用于查询您账户的[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）在当前地域的配额信息。配额详情可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public DescribeAddressQuotaResponse DescribeAddressQuotaSync(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplateGroups）用于查询IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public Task<DescribeAddressTemplateGroupsResponse> DescribeAddressTemplateGroups(DescribeAddressTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplateGroupsResponse>(req, "DescribeAddressTemplateGroups");
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplateGroups）用于查询IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public DescribeAddressTemplateGroupsResponse DescribeAddressTemplateGroupsSync(DescribeAddressTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplateGroupsResponse>(req, "DescribeAddressTemplateGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplates）用于查询IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public Task<DescribeAddressTemplatesResponse> DescribeAddressTemplates(DescribeAddressTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplatesResponse>(req, "DescribeAddressTemplates");
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplates）用于查询IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public DescribeAddressTemplatesResponse DescribeAddressTemplatesSync(DescribeAddressTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplatesResponse>(req, "DescribeAddressTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeAddresses) 用于查询一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的详细信息。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的 EIP。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public Task<DescribeAddressesResponse> DescribeAddresses(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses");
        }

        /// <summary>
        /// 本接口 (DescribeAddresses) 用于查询一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的详细信息。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的 EIP。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public DescribeAddressesResponse DescribeAddressesSync(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAssistantCidr）用于查询辅助CIDR列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public Task<DescribeAssistantCidrResponse> DescribeAssistantCidr(DescribeAssistantCidrRequest req)
        {
            return InternalRequestAsync<DescribeAssistantCidrResponse>(req, "DescribeAssistantCidr");
        }

        /// <summary>
        /// 本接口（DescribeAssistantCidr）用于查询辅助CIDR列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public DescribeAssistantCidrResponse DescribeAssistantCidrSync(DescribeAssistantCidrRequest req)
        {
            return InternalRequestAsync<DescribeAssistantCidrResponse>(req, "DescribeAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageBillUsage) 用于查询后付费共享带宽包当前的计费用量.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public Task<DescribeBandwidthPackageBillUsageResponse> DescribeBandwidthPackageBillUsage(DescribeBandwidthPackageBillUsageRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageBillUsageResponse>(req, "DescribeBandwidthPackageBillUsage");
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageBillUsage) 用于查询后付费共享带宽包当前的计费用量.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public DescribeBandwidthPackageBillUsageResponse DescribeBandwidthPackageBillUsageSync(DescribeBandwidthPackageBillUsageRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageBillUsageResponse>(req, "DescribeBandwidthPackageBillUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于查询账户在当前地域的带宽包上限数量以及使用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public Task<DescribeBandwidthPackageQuotaResponse> DescribeBandwidthPackageQuota(DescribeBandwidthPackageQuotaRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageQuotaResponse>(req, "DescribeBandwidthPackageQuota");
        }

        /// <summary>
        /// 接口用于查询账户在当前地域的带宽包上限数量以及使用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public DescribeBandwidthPackageQuotaResponse DescribeBandwidthPackageQuotaSync(DescribeBandwidthPackageQuotaRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageQuotaResponse>(req, "DescribeBandwidthPackageQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageResources) 用于根据共享带宽包唯一ID查询共享带宽包内的资源列表，支持按条件过滤查询结果和分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public Task<DescribeBandwidthPackageResourcesResponse> DescribeBandwidthPackageResources(DescribeBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageResourcesResponse>(req, "DescribeBandwidthPackageResources");
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageResources) 用于根据共享带宽包唯一ID查询共享带宽包内的资源列表，支持按条件过滤查询结果和分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public DescribeBandwidthPackageResourcesResponse DescribeBandwidthPackageResourcesSync(DescribeBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageResourcesResponse>(req, "DescribeBandwidthPackageResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于查询带宽包详细信息，包括带宽包唯一标识ID，类型，计费模式，名称，资源信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public Task<DescribeBandwidthPackagesResponse> DescribeBandwidthPackages(DescribeBandwidthPackagesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackagesResponse>(req, "DescribeBandwidthPackages");
        }

        /// <summary>
        /// 接口用于查询带宽包详细信息，包括带宽包唯一标识ID，类型，计费模式，名称，资源信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public DescribeBandwidthPackagesResponse DescribeBandwidthPackagesSync(DescribeBandwidthPackagesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackagesResponse>(req, "DescribeBandwidthPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCcnAttachedInstances）用于查询云联网实例下已关联的网络实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances");
        }

        /// <summary>
        /// 本接口（DescribeCcnAttachedInstances）用于查询云联网实例下已关联的网络实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCcnRegionBandwidthLimits）用于查询云联网各地域出带宽上限，该接口只返回已关联网络实例包含的地域。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public Task<DescribeCcnRegionBandwidthLimitsResponse> DescribeCcnRegionBandwidthLimits(DescribeCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<DescribeCcnRegionBandwidthLimitsResponse>(req, "DescribeCcnRegionBandwidthLimits");
        }

        /// <summary>
        /// 本接口（DescribeCcnRegionBandwidthLimits）用于查询云联网各地域出带宽上限，该接口只返回已关联网络实例包含的地域。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public DescribeCcnRegionBandwidthLimitsResponse DescribeCcnRegionBandwidthLimitsSync(DescribeCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<DescribeCcnRegionBandwidthLimitsResponse>(req, "DescribeCcnRegionBandwidthLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCcnRouteTableBroadcastPolicys)用于查询指定云联网路由表的路由传播策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRouteTableBroadcastPolicysRequest"/></param>
        /// <returns><see cref="DescribeCcnRouteTableBroadcastPolicysResponse"/></returns>
        public Task<DescribeCcnRouteTableBroadcastPolicysResponse> DescribeCcnRouteTableBroadcastPolicys(DescribeCcnRouteTableBroadcastPolicysRequest req)
        {
            return InternalRequestAsync<DescribeCcnRouteTableBroadcastPolicysResponse>(req, "DescribeCcnRouteTableBroadcastPolicys");
        }

        /// <summary>
        /// 本接口(DescribeCcnRouteTableBroadcastPolicys)用于查询指定云联网路由表的路由传播策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRouteTableBroadcastPolicysRequest"/></param>
        /// <returns><see cref="DescribeCcnRouteTableBroadcastPolicysResponse"/></returns>
        public DescribeCcnRouteTableBroadcastPolicysResponse DescribeCcnRouteTableBroadcastPolicysSync(DescribeCcnRouteTableBroadcastPolicysRequest req)
        {
            return InternalRequestAsync<DescribeCcnRouteTableBroadcastPolicysResponse>(req, "DescribeCcnRouteTableBroadcastPolicys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCcnRouteTableInputPolicys)用于查询指定云联网路由表的路由接收策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRouteTableInputPolicysRequest"/></param>
        /// <returns><see cref="DescribeCcnRouteTableInputPolicysResponse"/></returns>
        public Task<DescribeCcnRouteTableInputPolicysResponse> DescribeCcnRouteTableInputPolicys(DescribeCcnRouteTableInputPolicysRequest req)
        {
            return InternalRequestAsync<DescribeCcnRouteTableInputPolicysResponse>(req, "DescribeCcnRouteTableInputPolicys");
        }

        /// <summary>
        /// 本接口(DescribeCcnRouteTableInputPolicys)用于查询指定云联网路由表的路由接收策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRouteTableInputPolicysRequest"/></param>
        /// <returns><see cref="DescribeCcnRouteTableInputPolicysResponse"/></returns>
        public DescribeCcnRouteTableInputPolicysResponse DescribeCcnRouteTableInputPolicysSync(DescribeCcnRouteTableInputPolicysRequest req)
        {
            return InternalRequestAsync<DescribeCcnRouteTableInputPolicysResponse>(req, "DescribeCcnRouteTableInputPolicys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询指定的云联网实例的路由表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeCcnRouteTablesResponse"/></returns>
        public Task<DescribeCcnRouteTablesResponse> DescribeCcnRouteTables(DescribeCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeCcnRouteTablesResponse>(req, "DescribeCcnRouteTables");
        }

        /// <summary>
        /// 该接口用于查询指定的云联网实例的路由表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeCcnRouteTablesResponse"/></returns>
        public DescribeCcnRouteTablesResponse DescribeCcnRouteTablesSync(DescribeCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeCcnRouteTablesResponse>(req, "DescribeCcnRouteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCcnRoutes）用于查询已加入云联网（CCN）的路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public Task<DescribeCcnRoutesResponse> DescribeCcnRoutes(DescribeCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCcnRoutesResponse>(req, "DescribeCcnRoutes");
        }

        /// <summary>
        /// 本接口（DescribeCcnRoutes）用于查询已加入云联网（CCN）的路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public DescribeCcnRoutesResponse DescribeCcnRoutesSync(DescribeCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCcnRoutesResponse>(req, "DescribeCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCcns）用于查询云联网（CCN）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public Task<DescribeCcnsResponse> DescribeCcns(DescribeCcnsRequest req)
        {
            return InternalRequestAsync<DescribeCcnsResponse>(req, "DescribeCcns");
        }

        /// <summary>
        /// 本接口（DescribeCcns）用于查询云联网（CCN）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public DescribeCcnsResponse DescribeCcnsSync(DescribeCcnsRequest req)
        {
            return InternalRequestAsync<DescribeCcnsResponse>(req, "DescribeCcns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClassicLinkInstances）用于查询私有网络和基础网络设备互通列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClassicLinkInstancesResponse>(req, "DescribeClassicLinkInstances");
        }

        /// <summary>
        /// 本接口（DescribeClassicLinkInstances）用于查询私有网络和基础网络设备互通列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstancesSync(DescribeClassicLinkInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClassicLinkInstancesResponse>(req, "DescribeClassicLinkInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderCcnRegionBandwidthLimits）用于获取要锁定的限速实例列表。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（DescribeTenantCcns）
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderCcnRegionBandwidthLimitsResponse"/></returns>
        public Task<DescribeCrossBorderCcnRegionBandwidthLimitsResponse> DescribeCrossBorderCcnRegionBandwidthLimits(DescribeCrossBorderCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderCcnRegionBandwidthLimitsResponse>(req, "DescribeCrossBorderCcnRegionBandwidthLimits");
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderCcnRegionBandwidthLimits）用于获取要锁定的限速实例列表。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（DescribeTenantCcns）
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderCcnRegionBandwidthLimitsResponse"/></returns>
        public DescribeCrossBorderCcnRegionBandwidthLimitsResponse DescribeCrossBorderCcnRegionBandwidthLimitsSync(DescribeCrossBorderCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderCcnRegionBandwidthLimitsResponse>(req, "DescribeCrossBorderCcnRegionBandwidthLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderCompliance）用于查询用户创建的合规化资质审批单。
        /// 服务商可以查询服务名下的任意 `APPID` 创建的审批单；非服务商，只能查询自己审批单。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public Task<DescribeCrossBorderComplianceResponse> DescribeCrossBorderCompliance(DescribeCrossBorderComplianceRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderComplianceResponse>(req, "DescribeCrossBorderCompliance");
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderCompliance）用于查询用户创建的合规化资质审批单。
        /// 服务商可以查询服务名下的任意 `APPID` 创建的审批单；非服务商，只能查询自己审批单。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public DescribeCrossBorderComplianceResponse DescribeCrossBorderComplianceSync(DescribeCrossBorderComplianceRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderComplianceResponse>(req, "DescribeCrossBorderCompliance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderFlowMonitor）用于查询跨境带宽监控数据，该接口目前只提供给服务商联通使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderFlowMonitorRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderFlowMonitorResponse"/></returns>
        public Task<DescribeCrossBorderFlowMonitorResponse> DescribeCrossBorderFlowMonitor(DescribeCrossBorderFlowMonitorRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderFlowMonitorResponse>(req, "DescribeCrossBorderFlowMonitor");
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderFlowMonitor）用于查询跨境带宽监控数据，该接口目前只提供给服务商联通使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderFlowMonitorRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderFlowMonitorResponse"/></returns>
        public DescribeCrossBorderFlowMonitorResponse DescribeCrossBorderFlowMonitorSync(DescribeCrossBorderFlowMonitorRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderFlowMonitorResponse>(req, "DescribeCrossBorderFlowMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCustomerGatewayVendors）用于查询可支持的对端网关厂商信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public Task<DescribeCustomerGatewayVendorsResponse> DescribeCustomerGatewayVendors(DescribeCustomerGatewayVendorsRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewayVendorsResponse>(req, "DescribeCustomerGatewayVendors");
        }

        /// <summary>
        /// 本接口（DescribeCustomerGatewayVendors）用于查询可支持的对端网关厂商信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public DescribeCustomerGatewayVendorsResponse DescribeCustomerGatewayVendorsSync(DescribeCustomerGatewayVendorsRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewayVendorsResponse>(req, "DescribeCustomerGatewayVendors")
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
        /// 本接口（DescribeDhcpIps）用于查询DhcpIp列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDhcpIpsRequest"/></param>
        /// <returns><see cref="DescribeDhcpIpsResponse"/></returns>
        public Task<DescribeDhcpIpsResponse> DescribeDhcpIps(DescribeDhcpIpsRequest req)
        {
            return InternalRequestAsync<DescribeDhcpIpsResponse>(req, "DescribeDhcpIps");
        }

        /// <summary>
        /// 本接口（DescribeDhcpIps）用于查询DhcpIp列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDhcpIpsRequest"/></param>
        /// <returns><see cref="DescribeDhcpIpsResponse"/></returns>
        public DescribeDhcpIpsResponse DescribeDhcpIpsSync(DescribeDhcpIpsRequest req)
        {
            return InternalRequestAsync<DescribeDhcpIpsResponse>(req, "DescribeDhcpIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGatewayCcnRoutes）用于查询专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<DescribeDirectConnectGatewayCcnRoutesResponse> DescribeDirectConnectGatewayCcnRoutes(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewayCcnRoutesResponse>(req, "DescribeDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGatewayCcnRoutes）用于查询专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DescribeDirectConnectGatewayCcnRoutesResponse DescribeDirectConnectGatewayCcnRoutesSync(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewayCcnRoutesResponse>(req, "DescribeDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGateways）用于查询专线网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewaysResponse>(req, "DescribeDirectConnectGateways");
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGateways）用于查询专线网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public DescribeDirectConnectGatewaysResponse DescribeDirectConnectGatewaysSync(DescribeDirectConnectGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewaysResponse>(req, "DescribeDirectConnectGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFlowLog）用于查询流日志实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public Task<DescribeFlowLogResponse> DescribeFlowLog(DescribeFlowLogRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogResponse>(req, "DescribeFlowLog");
        }

        /// <summary>
        /// 本接口（DescribeFlowLog）用于查询流日志实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public DescribeFlowLogResponse DescribeFlowLogSync(DescribeFlowLogRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogResponse>(req, "DescribeFlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFlowLogs）用于查询获取流日志集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public Task<DescribeFlowLogsResponse> DescribeFlowLogs(DescribeFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogsResponse>(req, "DescribeFlowLogs");
        }

        /// <summary>
        /// 本接口（DescribeFlowLogs）用于查询获取流日志集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public DescribeFlowLogsResponse DescribeFlowLogsSync(DescribeFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogsResponse>(req, "DescribeFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowMonitorDetail）用于查询网关流量监控明细。
        /// * 只支持单个网关实例查询。即入参 `VpnId`、 `DirectConnectGatewayId`、 `PeeringConnectionId`、 `NatId` 最多只支持传一个，且必须传一个。
        /// * 如果网关有流量，但调用本接口没有返回数据，请在控制台对应网关详情页确认是否开启网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowMonitorDetailResponse"/></returns>
        public Task<DescribeGatewayFlowMonitorDetailResponse> DescribeGatewayFlowMonitorDetail(DescribeGatewayFlowMonitorDetailRequest req)
        {
            return InternalRequestAsync<DescribeGatewayFlowMonitorDetailResponse>(req, "DescribeGatewayFlowMonitorDetail");
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowMonitorDetail）用于查询网关流量监控明细。
        /// * 只支持单个网关实例查询。即入参 `VpnId`、 `DirectConnectGatewayId`、 `PeeringConnectionId`、 `NatId` 最多只支持传一个，且必须传一个。
        /// * 如果网关有流量，但调用本接口没有返回数据，请在控制台对应网关详情页确认是否开启网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowMonitorDetailResponse"/></returns>
        public DescribeGatewayFlowMonitorDetailResponse DescribeGatewayFlowMonitorDetailSync(DescribeGatewayFlowMonitorDetailRequest req)
        {
            return InternalRequestAsync<DescribeGatewayFlowMonitorDetailResponse>(req, "DescribeGatewayFlowMonitorDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowQos）用于查询网关来访IP流控带宽。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public Task<DescribeGatewayFlowQosResponse> DescribeGatewayFlowQos(DescribeGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<DescribeGatewayFlowQosResponse>(req, "DescribeGatewayFlowQos");
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowQos）用于查询网关来访IP流控带宽。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public DescribeGatewayFlowQosResponse DescribeGatewayFlowQosSync(DescribeGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<DescribeGatewayFlowQosResponse>(req, "DescribeGatewayFlowQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeHaVips）用于查询高可用虚拟IP（HAVIP）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public Task<DescribeHaVipsResponse> DescribeHaVips(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips");
        }

        /// <summary>
        /// 本接口（DescribeHaVips）用于查询高可用虚拟IP（HAVIP）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public DescribeHaVipsResponse DescribeHaVipsSync(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询IPV6地址信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6AddressesRequest"/></param>
        /// <returns><see cref="DescribeIp6AddressesResponse"/></returns>
        public Task<DescribeIp6AddressesResponse> DescribeIp6Addresses(DescribeIp6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeIp6AddressesResponse>(req, "DescribeIp6Addresses");
        }

        /// <summary>
        /// 该接口用于查询IPV6地址信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6AddressesRequest"/></param>
        /// <returns><see cref="DescribeIp6AddressesResponse"/></returns>
        public DescribeIp6AddressesResponse DescribeIp6AddressesSync(DescribeIp6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeIp6AddressesResponse>(req, "DescribeIp6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账户在指定地域IPV6转换实例和规则的配额
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorQuotaRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorQuotaResponse"/></returns>
        public Task<DescribeIp6TranslatorQuotaResponse> DescribeIp6TranslatorQuota(DescribeIp6TranslatorQuotaRequest req)
        {
            return InternalRequestAsync<DescribeIp6TranslatorQuotaResponse>(req, "DescribeIp6TranslatorQuota");
        }

        /// <summary>
        /// 查询账户在指定地域IPV6转换实例和规则的配额
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorQuotaRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorQuotaResponse"/></returns>
        public DescribeIp6TranslatorQuotaResponse DescribeIp6TranslatorQuotaSync(DescribeIp6TranslatorQuotaRequest req)
        {
            return InternalRequestAsync<DescribeIp6TranslatorQuotaResponse>(req, "DescribeIp6TranslatorQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 该接口用于查询账户下的IPV6转换实例及其绑定的转换规则信息
        /// 2. 支持过滤查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorsResponse"/></returns>
        public Task<DescribeIp6TranslatorsResponse> DescribeIp6Translators(DescribeIp6TranslatorsRequest req)
        {
            return InternalRequestAsync<DescribeIp6TranslatorsResponse>(req, "DescribeIp6Translators");
        }

        /// <summary>
        /// 1. 该接口用于查询账户下的IPV6转换实例及其绑定的转换规则信息
        /// 2. 支持过滤查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorsResponse"/></returns>
        public DescribeIp6TranslatorsResponse DescribeIp6TranslatorsSync(DescribeIp6TranslatorsRequest req)
        {
            return InternalRequestAsync<DescribeIp6TranslatorsResponse>(req, "DescribeIp6Translators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationDatabaseUrl）用于获取IP地理位置库下载链接。
        /// <font color="#FF0000">本接口即将下线，仅供存量用户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public Task<DescribeIpGeolocationDatabaseUrlResponse> DescribeIpGeolocationDatabaseUrl(DescribeIpGeolocationDatabaseUrlRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationDatabaseUrlResponse>(req, "DescribeIpGeolocationDatabaseUrl");
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationDatabaseUrl）用于获取IP地理位置库下载链接。
        /// <font color="#FF0000">本接口即将下线，仅供存量用户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public DescribeIpGeolocationDatabaseUrlResponse DescribeIpGeolocationDatabaseUrlSync(DescribeIpGeolocationDatabaseUrlRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationDatabaseUrlResponse>(req, "DescribeIpGeolocationDatabaseUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationInfos）用于查询IP地址信息，包括地理位置信息和网络信息。
        /// <font color="#FF0000">本接口即将下线，仅供存量客户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public Task<DescribeIpGeolocationInfosResponse> DescribeIpGeolocationInfos(DescribeIpGeolocationInfosRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationInfosResponse>(req, "DescribeIpGeolocationInfos");
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationInfos）用于查询IP地址信息，包括地理位置信息和网络信息。
        /// <font color="#FF0000">本接口即将下线，仅供存量客户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public DescribeIpGeolocationInfosResponse DescribeIpGeolocationInfosSync(DescribeIpGeolocationInfosRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationInfosResponse>(req, "DescribeIpGeolocationInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeLocalGateway）用于查询CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public Task<DescribeLocalGatewayResponse> DescribeLocalGateway(DescribeLocalGatewayRequest req)
        {
            return InternalRequestAsync<DescribeLocalGatewayResponse>(req, "DescribeLocalGateway");
        }

        /// <summary>
        /// 本接口（DescribeLocalGateway）用于查询CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public DescribeLocalGatewayResponse DescribeLocalGatewaySync(DescribeLocalGatewayRequest req)
        {
            return InternalRequestAsync<DescribeLocalGatewayResponse>(req, "DescribeLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNatGatewayDestinationIpPortTranslationNatRules）用于查询NAT网关端口转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public Task<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> DescribeNatGatewayDestinationIpPortTranslationNatRules(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules");
        }

        /// <summary>
        /// 本接口（DescribeNatGatewayDestinationIpPortTranslationNatRules）用于查询NAT网关端口转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse DescribeNatGatewayDestinationIpPortTranslationNatRulesSync(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询专线绑定NAT的路由
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public Task<DescribeNatGatewayDirectConnectGatewayRouteResponse> DescribeNatGatewayDirectConnectGatewayRoute(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDirectConnectGatewayRouteResponse>(req, "DescribeNatGatewayDirectConnectGatewayRoute");
        }

        /// <summary>
        /// 查询专线绑定NAT的路由
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public DescribeNatGatewayDirectConnectGatewayRouteResponse DescribeNatGatewayDirectConnectGatewayRouteSync(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDirectConnectGatewayRouteResponse>(req, "DescribeNatGatewayDirectConnectGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNatGatewaySourceIpTranslationNatRules）用于查询NAT网关SNAT转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public Task<DescribeNatGatewaySourceIpTranslationNatRulesResponse> DescribeNatGatewaySourceIpTranslationNatRules(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaySourceIpTranslationNatRulesResponse>(req, "DescribeNatGatewaySourceIpTranslationNatRules");
        }

        /// <summary>
        /// 本接口（DescribeNatGatewaySourceIpTranslationNatRules）用于查询NAT网关SNAT转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewaySourceIpTranslationNatRulesResponse DescribeNatGatewaySourceIpTranslationNatRulesSync(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaySourceIpTranslationNatRulesResponse>(req, "DescribeNatGatewaySourceIpTranslationNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNatGateways）用于查询 NAT 网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public Task<DescribeNatGatewaysResponse> DescribeNatGateways(DescribeNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaysResponse>(req, "DescribeNatGateways");
        }

        /// <summary>
        /// 本接口（DescribeNatGateways）用于查询 NAT 网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public DescribeNatGatewaysResponse DescribeNatGatewaysSync(DescribeNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaysResponse>(req, "DescribeNatGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeNetDetectStates)用于查询网络探测验证结果列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public Task<DescribeNetDetectStatesResponse> DescribeNetDetectStates(DescribeNetDetectStatesRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectStatesResponse>(req, "DescribeNetDetectStates");
        }

        /// <summary>
        /// 本接口(DescribeNetDetectStates)用于查询网络探测验证结果列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public DescribeNetDetectStatesResponse DescribeNetDetectStatesSync(DescribeNetDetectStatesRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectStatesResponse>(req, "DescribeNetDetectStates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNetDetects）用于查询网络探测列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public Task<DescribeNetDetectsResponse> DescribeNetDetects(DescribeNetDetectsRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectsResponse>(req, "DescribeNetDetects");
        }

        /// <summary>
        /// 本接口（DescribeNetDetects）用于查询网络探测列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public DescribeNetDetectsResponse DescribeNetDetectsSync(DescribeNetDetectsRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectsResponse>(req, "DescribeNetDetects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断用户在网络侧的用户类型，如标准（带宽上移），传统（非上移）。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAccountTypeRequest"/></param>
        /// <returns><see cref="DescribeNetworkAccountTypeResponse"/></returns>
        public Task<DescribeNetworkAccountTypeResponse> DescribeNetworkAccountType(DescribeNetworkAccountTypeRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAccountTypeResponse>(req, "DescribeNetworkAccountType");
        }

        /// <summary>
        /// 判断用户在网络侧的用户类型，如标准（带宽上移），传统（非上移）。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAccountTypeRequest"/></param>
        /// <returns><see cref="DescribeNetworkAccountTypeResponse"/></returns>
        public DescribeNetworkAccountTypeResponse DescribeNetworkAccountTypeSync(DescribeNetworkAccountTypeRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAccountTypeResponse>(req, "DescribeNetworkAccountType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNetworkAclQuintupleEntries）查询入方向或出方向网络ACL五元组条目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<DescribeNetworkAclQuintupleEntriesResponse> DescribeNetworkAclQuintupleEntries(DescribeNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclQuintupleEntriesResponse>(req, "DescribeNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// 本接口（DescribeNetworkAclQuintupleEntries）查询入方向或出方向网络ACL五元组条目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public DescribeNetworkAclQuintupleEntriesResponse DescribeNetworkAclQuintupleEntriesSync(DescribeNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclQuintupleEntriesResponse>(req, "DescribeNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNetworkAcls）用于查询网络ACL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public Task<DescribeNetworkAclsResponse> DescribeNetworkAcls(DescribeNetworkAclsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclsResponse>(req, "DescribeNetworkAcls");
        }

        /// <summary>
        /// 本接口（DescribeNetworkAcls）用于查询网络ACL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public DescribeNetworkAclsResponse DescribeNetworkAclsSync(DescribeNetworkAclsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclsResponse>(req, "DescribeNetworkAcls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaceLimit）根据CVM实例ID或弹性网卡ID查询弹性网卡配额，返回该CVM实例或弹性网卡能绑定的弹性网卡配额，以及弹性网卡可以分配的IP配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public Task<DescribeNetworkInterfaceLimitResponse> DescribeNetworkInterfaceLimit(DescribeNetworkInterfaceLimitRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfaceLimitResponse>(req, "DescribeNetworkInterfaceLimit");
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaceLimit）根据CVM实例ID或弹性网卡ID查询弹性网卡配额，返回该CVM实例或弹性网卡能绑定的弹性网卡配额，以及弹性网卡可以分配的IP配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public DescribeNetworkInterfaceLimitResponse DescribeNetworkInterfaceLimitSync(DescribeNetworkInterfaceLimitRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfaceLimitResponse>(req, "DescribeNetworkInterfaceLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaces）用于查询弹性网卡列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces");
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaces）用于查询弹性网卡列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesSync(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayDestinationIpPortTranslationNatRules）用于查询私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public Task<DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesResponse> DescribePrivateNatGatewayDestinationIpPortTranslationNatRules(DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesResponse>(req, "DescribePrivateNatGatewayDestinationIpPortTranslationNatRules");
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayDestinationIpPortTranslationNatRules）用于查询私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesResponse DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesSync(DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayDestinationIpPortTranslationNatRulesResponse>(req, "DescribePrivateNatGatewayDestinationIpPortTranslationNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayLimits）用于查询可创建的私网NAT网关配额数量
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayLimitsRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayLimitsResponse"/></returns>
        public Task<DescribePrivateNatGatewayLimitsResponse> DescribePrivateNatGatewayLimits(DescribePrivateNatGatewayLimitsRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayLimitsResponse>(req, "DescribePrivateNatGatewayLimits");
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayLimits）用于查询可创建的私网NAT网关配额数量
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayLimitsRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayLimitsResponse"/></returns>
        public DescribePrivateNatGatewayLimitsResponse DescribePrivateNatGatewayLimitsSync(DescribePrivateNatGatewayLimitsRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayLimitsResponse>(req, "DescribePrivateNatGatewayLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayRegions）用于查询查询私网NAT网关可支持地域
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayRegionsRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayRegionsResponse"/></returns>
        public Task<DescribePrivateNatGatewayRegionsResponse> DescribePrivateNatGatewayRegions(DescribePrivateNatGatewayRegionsRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayRegionsResponse>(req, "DescribePrivateNatGatewayRegions");
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayRegions）用于查询查询私网NAT网关可支持地域
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayRegionsRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayRegionsResponse"/></returns>
        public DescribePrivateNatGatewayRegionsResponse DescribePrivateNatGatewayRegionsSync(DescribePrivateNatGatewayRegionsRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayRegionsResponse>(req, "DescribePrivateNatGatewayRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayTranslationAclRules）用于查询私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayTranslationAclRulesRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayTranslationAclRulesResponse"/></returns>
        public Task<DescribePrivateNatGatewayTranslationAclRulesResponse> DescribePrivateNatGatewayTranslationAclRules(DescribePrivateNatGatewayTranslationAclRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayTranslationAclRulesResponse>(req, "DescribePrivateNatGatewayTranslationAclRules");
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayTranslationAclRules）用于查询私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayTranslationAclRulesRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayTranslationAclRulesResponse"/></returns>
        public DescribePrivateNatGatewayTranslationAclRulesResponse DescribePrivateNatGatewayTranslationAclRulesSync(DescribePrivateNatGatewayTranslationAclRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayTranslationAclRulesResponse>(req, "DescribePrivateNatGatewayTranslationAclRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayTranslationNatRules）用于查询私网NAT网关源端转换规则
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayTranslationNatRulesResponse"/></returns>
        public Task<DescribePrivateNatGatewayTranslationNatRulesResponse> DescribePrivateNatGatewayTranslationNatRules(DescribePrivateNatGatewayTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayTranslationNatRulesResponse>(req, "DescribePrivateNatGatewayTranslationNatRules");
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGatewayTranslationNatRules）用于查询私网NAT网关源端转换规则
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewayTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewayTranslationNatRulesResponse"/></returns>
        public DescribePrivateNatGatewayTranslationNatRulesResponse DescribePrivateNatGatewayTranslationNatRulesSync(DescribePrivateNatGatewayTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewayTranslationNatRulesResponse>(req, "DescribePrivateNatGatewayTranslationNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGateways）用于查询私网NAT网关
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewaysResponse"/></returns>
        public Task<DescribePrivateNatGatewaysResponse> DescribePrivateNatGateways(DescribePrivateNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewaysResponse>(req, "DescribePrivateNatGateways");
        }

        /// <summary>
        /// 本接口（DescribePrivateNatGateways）用于查询私网NAT网关
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribePrivateNatGatewaysResponse"/></returns>
        public DescribePrivateNatGatewaysResponse DescribePrivateNatGatewaysSync(DescribePrivateNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribePrivateNatGatewaysResponse>(req, "DescribePrivateNatGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProductQuota）用于查询网络产品的配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductQuotaRequest"/></param>
        /// <returns><see cref="DescribeProductQuotaResponse"/></returns>
        public Task<DescribeProductQuotaResponse> DescribeProductQuota(DescribeProductQuotaRequest req)
        {
            return InternalRequestAsync<DescribeProductQuotaResponse>(req, "DescribeProductQuota");
        }

        /// <summary>
        /// 本接口（DescribeProductQuota）用于查询网络产品的配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductQuotaRequest"/></param>
        /// <returns><see cref="DescribeProductQuotaResponse"/></returns>
        public DescribeProductQuotaResponse DescribeProductQuotaSync(DescribeProductQuotaRequest req)
        {
            return InternalRequestAsync<DescribeProductQuotaResponse>(req, "DescribeProductQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRouteConflicts）用于查询自定义路由策略与云联网路由策略冲突列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public Task<DescribeRouteConflictsResponse> DescribeRouteConflicts(DescribeRouteConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteConflictsResponse>(req, "DescribeRouteConflicts");
        }

        /// <summary>
        /// 本接口（DescribeRouteConflicts）用于查询自定义路由策略与云联网路由策略冲突列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public DescribeRouteConflictsResponse DescribeRouteConflictsSync(DescribeRouteConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteConflictsResponse>(req, "DescribeRouteConflicts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRouteTableAssociatedInstances）用于查询指定的云联网关联的实例所绑定的路由表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableAssociatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRouteTableAssociatedInstancesResponse"/></returns>
        public Task<DescribeRouteTableAssociatedInstancesResponse> DescribeRouteTableAssociatedInstances(DescribeRouteTableAssociatedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableAssociatedInstancesResponse>(req, "DescribeRouteTableAssociatedInstances");
        }

        /// <summary>
        /// 本接口（DescribeRouteTableAssociatedInstances）用于查询指定的云联网关联的实例所绑定的路由表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableAssociatedInstancesRequest"/></param>
        /// <returns><see cref="DescribeRouteTableAssociatedInstancesResponse"/></returns>
        public DescribeRouteTableAssociatedInstancesResponse DescribeRouteTableAssociatedInstancesSync(DescribeRouteTableAssociatedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableAssociatedInstancesResponse>(req, "DescribeRouteTableAssociatedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRouteTableSelectionPolicies）用于查询云联网路由表选择策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableSelectionPoliciesRequest"/></param>
        /// <returns><see cref="DescribeRouteTableSelectionPoliciesResponse"/></returns>
        public Task<DescribeRouteTableSelectionPoliciesResponse> DescribeRouteTableSelectionPolicies(DescribeRouteTableSelectionPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableSelectionPoliciesResponse>(req, "DescribeRouteTableSelectionPolicies");
        }

        /// <summary>
        /// 本接口（DescribeRouteTableSelectionPolicies）用于查询云联网路由表选择策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableSelectionPoliciesRequest"/></param>
        /// <returns><see cref="DescribeRouteTableSelectionPoliciesResponse"/></returns>
        public DescribeRouteTableSelectionPoliciesResponse DescribeRouteTableSelectionPoliciesSync(DescribeRouteTableSelectionPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableSelectionPoliciesResponse>(req, "DescribeRouteTableSelectionPolicies")
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
        /// 本接口（DescribeSecurityGroupAssociationStatistics）用于查询安全组关联的实例统计。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public Task<DescribeSecurityGroupAssociationStatisticsResponse> DescribeSecurityGroupAssociationStatistics(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics");
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupAssociationStatistics）用于查询安全组关联的实例统计。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public DescribeSecurityGroupAssociationStatisticsResponse DescribeSecurityGroupAssociationStatisticsSync(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSecurityGroupLimits)用于查询用户安全组配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public Task<DescribeSecurityGroupLimitsResponse> DescribeSecurityGroupLimits(DescribeSecurityGroupLimitsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupLimitsResponse>(req, "DescribeSecurityGroupLimits");
        }

        /// <summary>
        /// 本接口(DescribeSecurityGroupLimits)用于查询用户安全组配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public DescribeSecurityGroupLimitsResponse DescribeSecurityGroupLimitsSync(DescribeSecurityGroupLimitsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupLimitsResponse>(req, "DescribeSecurityGroupLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupPolicies）用于查询安全组规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public Task<DescribeSecurityGroupPoliciesResponse> DescribeSecurityGroupPolicies(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies");
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupPolicies）用于查询安全组规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public DescribeSecurityGroupPoliciesResponse DescribeSecurityGroupPoliciesSync(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupReferences）用于查询安全组被引用信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupReferencesResponse>(req, "DescribeSecurityGroupReferences");
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupReferences）用于查询安全组被引用信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferencesSync(DescribeSecurityGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupReferencesResponse>(req, "DescribeSecurityGroupReferences")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroups）用于查询安全组。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups");
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroups）用于查询安全组。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsSync(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplateGroups）用于查询协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public Task<DescribeServiceTemplateGroupsResponse> DescribeServiceTemplateGroups(DescribeServiceTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplateGroupsResponse>(req, "DescribeServiceTemplateGroups");
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplateGroups）用于查询协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public DescribeServiceTemplateGroupsResponse DescribeServiceTemplateGroupsSync(DescribeServiceTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplateGroupsResponse>(req, "DescribeServiceTemplateGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplates）用于查询协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public Task<DescribeServiceTemplatesResponse> DescribeServiceTemplates(DescribeServiceTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplatesResponse>(req, "DescribeServiceTemplates");
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplates）用于查询协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public DescribeServiceTemplatesResponse DescribeServiceTemplatesSync(DescribeServiceTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplatesResponse>(req, "DescribeServiceTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSgSnapshotFileContent）用于查询安全组快照文件内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public Task<DescribeSgSnapshotFileContentResponse> DescribeSgSnapshotFileContent(DescribeSgSnapshotFileContentRequest req)
        {
            return InternalRequestAsync<DescribeSgSnapshotFileContentResponse>(req, "DescribeSgSnapshotFileContent");
        }

        /// <summary>
        /// 本接口（DescribeSgSnapshotFileContent）用于查询安全组快照文件内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public DescribeSgSnapshotFileContentResponse DescribeSgSnapshotFileContentSync(DescribeSgSnapshotFileContentRequest req)
        {
            return InternalRequestAsync<DescribeSgSnapshotFileContentResponse>(req, "DescribeSgSnapshotFileContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSnapshotAttachedInstances）用于查询快照策略关联实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public Task<DescribeSnapshotAttachedInstancesResponse> DescribeSnapshotAttachedInstances(DescribeSnapshotAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotAttachedInstancesResponse>(req, "DescribeSnapshotAttachedInstances");
        }

        /// <summary>
        /// 本接口（DescribeSnapshotAttachedInstances）用于查询快照策略关联实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public DescribeSnapshotAttachedInstancesResponse DescribeSnapshotAttachedInstancesSync(DescribeSnapshotAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotAttachedInstancesResponse>(req, "DescribeSnapshotAttachedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSnapshotFiles）用于查询快照文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public Task<DescribeSnapshotFilesResponse> DescribeSnapshotFiles(DescribeSnapshotFilesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotFilesResponse>(req, "DescribeSnapshotFiles");
        }

        /// <summary>
        /// 本接口（DescribeSnapshotFiles）用于查询快照文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public DescribeSnapshotFilesResponse DescribeSnapshotFilesSync(DescribeSnapshotFilesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotFilesResponse>(req, "DescribeSnapshotFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSnapshotPolicies）用于查询快照策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public Task<DescribeSnapshotPoliciesResponse> DescribeSnapshotPolicies(DescribeSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotPoliciesResponse>(req, "DescribeSnapshotPolicies");
        }

        /// <summary>
        /// 本接口（DescribeSnapshotPolicies）用于查询快照策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public DescribeSnapshotPoliciesResponse DescribeSnapshotPoliciesSync(DescribeSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotPoliciesResponse>(req, "DescribeSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeSpecificTrafficPackageUsedDetails) 用于查询指定 共享流量包 的用量明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecificTrafficPackageUsedDetailsRequest"/></param>
        /// <returns><see cref="DescribeSpecificTrafficPackageUsedDetailsResponse"/></returns>
        public Task<DescribeSpecificTrafficPackageUsedDetailsResponse> DescribeSpecificTrafficPackageUsedDetails(DescribeSpecificTrafficPackageUsedDetailsRequest req)
        {
            return InternalRequestAsync<DescribeSpecificTrafficPackageUsedDetailsResponse>(req, "DescribeSpecificTrafficPackageUsedDetails");
        }

        /// <summary>
        /// 本接口 (DescribeSpecificTrafficPackageUsedDetails) 用于查询指定 共享流量包 的用量明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecificTrafficPackageUsedDetailsRequest"/></param>
        /// <returns><see cref="DescribeSpecificTrafficPackageUsedDetailsResponse"/></returns>
        public DescribeSpecificTrafficPackageUsedDetailsResponse DescribeSpecificTrafficPackageUsedDetailsSync(DescribeSpecificTrafficPackageUsedDetailsRequest req)
        {
            return InternalRequestAsync<DescribeSpecificTrafficPackageUsedDetailsResponse>(req, "DescribeSpecificTrafficPackageUsedDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSubnetResourceDashboard)用于查看Subnet资源信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeSubnetResourceDashboardResponse"/></returns>
        public Task<DescribeSubnetResourceDashboardResponse> DescribeSubnetResourceDashboard(DescribeSubnetResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeSubnetResourceDashboardResponse>(req, "DescribeSubnetResourceDashboard");
        }

        /// <summary>
        /// 本接口(DescribeSubnetResourceDashboard)用于查看Subnet资源信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeSubnetResourceDashboardResponse"/></returns>
        public DescribeSubnetResourceDashboardResponse DescribeSubnetResourceDashboardSync(DescribeSubnetResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeSubnetResourceDashboardResponse>(req, "DescribeSubnetResourceDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSubnets）用于查询子网列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets");
        }

        /// <summary>
        /// 本接口（DescribeSubnets）用于查询子网列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public DescribeSubnetsResponse DescribeSubnetsSync(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets")
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
        /// 本接口（DescribeTemplateLimits）用于查询参数模板配额列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateLimitsRequest"/></param>
        /// <returns><see cref="DescribeTemplateLimitsResponse"/></returns>
        public Task<DescribeTemplateLimitsResponse> DescribeTemplateLimits(DescribeTemplateLimitsRequest req)
        {
            return InternalRequestAsync<DescribeTemplateLimitsResponse>(req, "DescribeTemplateLimits");
        }

        /// <summary>
        /// 本接口（DescribeTemplateLimits）用于查询参数模板配额列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateLimitsRequest"/></param>
        /// <returns><see cref="DescribeTemplateLimitsResponse"/></returns>
        public DescribeTemplateLimitsResponse DescribeTemplateLimitsSync(DescribeTemplateLimitsRequest req)
        {
            return InternalRequestAsync<DescribeTemplateLimitsResponse>(req, "DescribeTemplateLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTenantCcns）用于获取要锁定的云联网实例列表。
        /// 该接口一般用来封禁出口限速的云联网实例, 目前联通内部运营系统通过云API调用, 因为出口限速无法按地域间封禁, 只能按更粗的云联网实例粒度封禁, 如果是地域间限速, 一般可以通过更细的限速实例粒度封禁（DescribeCrossBorderCcnRegionBandwidthLimits）
        /// 如有需要, 可以封禁任意云联网实例, 可接入到内部运营系统
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantCcnsRequest"/></param>
        /// <returns><see cref="DescribeTenantCcnsResponse"/></returns>
        public Task<DescribeTenantCcnsResponse> DescribeTenantCcns(DescribeTenantCcnsRequest req)
        {
            return InternalRequestAsync<DescribeTenantCcnsResponse>(req, "DescribeTenantCcns");
        }

        /// <summary>
        /// 本接口（DescribeTenantCcns）用于获取要锁定的云联网实例列表。
        /// 该接口一般用来封禁出口限速的云联网实例, 目前联通内部运营系统通过云API调用, 因为出口限速无法按地域间封禁, 只能按更粗的云联网实例粒度封禁, 如果是地域间限速, 一般可以通过更细的限速实例粒度封禁（DescribeCrossBorderCcnRegionBandwidthLimits）
        /// 如有需要, 可以封禁任意云联网实例, 可接入到内部运营系统
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantCcnsRequest"/></param>
        /// <returns><see cref="DescribeTenantCcnsResponse"/></returns>
        public DescribeTenantCcnsResponse DescribeTenantCcnsSync(DescribeTenantCcnsRequest req)
        {
            return InternalRequestAsync<DescribeTenantCcnsResponse>(req, "DescribeTenantCcns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeTrafficPackages)  用于查询共享流量包详细信息，包括共享流量包唯一标识ID，名称，流量使用信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages");
        }

        /// <summary>
        /// 本接口 (DescribeTrafficPackages)  用于查询共享流量包详细信息，包括共享流量包唯一标识ID，名称，流量使用信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeUsedIpAddress)用于查询Subnet或者Vpc内的ip的使用情况，
        /// 如ip被占用，返回占用ip的资源类别与id；如未被占用，返回空值
        /// </summary>
        /// <param name="req"><see cref="DescribeUsedIpAddressRequest"/></param>
        /// <returns><see cref="DescribeUsedIpAddressResponse"/></returns>
        public Task<DescribeUsedIpAddressResponse> DescribeUsedIpAddress(DescribeUsedIpAddressRequest req)
        {
            return InternalRequestAsync<DescribeUsedIpAddressResponse>(req, "DescribeUsedIpAddress");
        }

        /// <summary>
        /// 本接口(DescribeUsedIpAddress)用于查询Subnet或者Vpc内的ip的使用情况，
        /// 如ip被占用，返回占用ip的资源类别与id；如未被占用，返回空值
        /// </summary>
        /// <param name="req"><see cref="DescribeUsedIpAddressRequest"/></param>
        /// <returns><see cref="DescribeUsedIpAddressResponse"/></returns>
        public DescribeUsedIpAddressResponse DescribeUsedIpAddressSync(DescribeUsedIpAddressRequest req)
        {
            return InternalRequestAsync<DescribeUsedIpAddressResponse>(req, "DescribeUsedIpAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPoint）用于查询终端节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public Task<DescribeVpcEndPointResponse> DescribeVpcEndPoint(DescribeVpcEndPointRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointResponse>(req, "DescribeVpcEndPoint");
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPoint）用于查询终端节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public DescribeVpcEndPointResponse DescribeVpcEndPointSync(DescribeVpcEndPointRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointResponse>(req, "DescribeVpcEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPointService）用于查询终端节点服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public Task<DescribeVpcEndPointServiceResponse> DescribeVpcEndPointService(DescribeVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceResponse>(req, "DescribeVpcEndPointService");
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPointService）用于查询终端节点服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public DescribeVpcEndPointServiceResponse DescribeVpcEndPointServiceSync(DescribeVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceResponse>(req, "DescribeVpcEndPointService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPointServiceWhiteList）用于查询终端节点服务的服务白名单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<DescribeVpcEndPointServiceWhiteListResponse> DescribeVpcEndPointServiceWhiteList(DescribeVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceWhiteListResponse>(req, "DescribeVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPointServiceWhiteList）用于查询终端节点服务的服务白名单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public DescribeVpcEndPointServiceWhiteListResponse DescribeVpcEndPointServiceWhiteListSync(DescribeVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceWhiteListResponse>(req, "DescribeVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcInstances）用于查询VPC下的云主机实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public Task<DescribeVpcInstancesResponse> DescribeVpcInstances(DescribeVpcInstancesRequest req)
        {
            return InternalRequestAsync<DescribeVpcInstancesResponse>(req, "DescribeVpcInstances");
        }

        /// <summary>
        /// 本接口（DescribeVpcInstances）用于查询VPC下的云主机实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public DescribeVpcInstancesResponse DescribeVpcInstancesSync(DescribeVpcInstancesRequest req)
        {
            return InternalRequestAsync<DescribeVpcInstancesResponse>(req, "DescribeVpcInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcIpv6Addresses）用于查询 `VPC` `IPv6` 信息。
        /// 只能查询已使用的`IPv6`信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public Task<DescribeVpcIpv6AddressesResponse> DescribeVpcIpv6Addresses(DescribeVpcIpv6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcIpv6AddressesResponse>(req, "DescribeVpcIpv6Addresses");
        }

        /// <summary>
        /// 本接口（DescribeVpcIpv6Addresses）用于查询 `VPC` `IPv6` 信息。
        /// 只能查询已使用的`IPv6`信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public DescribeVpcIpv6AddressesResponse DescribeVpcIpv6AddressesSync(DescribeVpcIpv6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcIpv6AddressesResponse>(req, "DescribeVpcIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcLimits）用于获取私有网络配额，部分私有网络的配额有地域属性。
        /// LimitTypes取值范围：
        /// * appid-max-vpcs （每个开发商每个地域可创建的VPC数）。
        /// * vpc-max-subnets（每个VPC可创建的子网数）。
        /// * vpc-max-route-tables（每个VPC可创建的路由表数）。
        /// * route-table-max-policies（每个路由表可添加的策略数）。
        /// * vpc-max-vpn-gateways（每个VPC可创建的VPN网关数）。
        /// * appid-max-custom-gateways（每个开发商可创建的对端网关数）。
        /// * appid-max-vpn-connections（每个开发商可创建的VPN通道数）。
        /// * custom-gateway-max-vpn-connections（每个对端网关可创建的VPN通道数）。
        /// * vpn-gateway-max-custom-gateways（每个VPNGW可以创建的通道数）。
        /// * vpc-max-network-acls（每个VPC可创建的网络ACL数）。
        /// * network-acl-max-inbound-policies（每个网络ACL可添加的入站规则数）。
        /// * network-acl-max-outbound-policies（每个网络ACL可添加的出站规则数）。
        /// * vpc-max-vpcpeers（每个VPC可创建的对等连接数）。
        /// * vpc-max-available-vpcpeers（每个VPC可创建的有效对等连接数）。
        /// * vpc-max-basic-network-interconnections（每个VPC可创建的基础网络云主机与VPC互通数）。
        /// * direct-connection-max-snats（每个专线网关可创建的SNAT数）。
        /// * direct-connection-max-dnats（每个专线网关可创建的DNAT数）。
        /// * direct-connection-max-snapts（每个专线网关可创建的SNAPT数）。
        /// * direct-connection-max-dnapts（每个专线网关可创建的DNAPT数）。
        /// * vpc-max-nat-gateways（每个VPC可创建的NAT网关数）。
        /// * nat-gateway-max-eips（每个NAT可以购买的外网IP数量）。
        /// * vpc-max-enis（每个VPC可创建弹性网卡数）。
        /// * vpc-max-havips（每个VPC可创建HAVIP数）。
        /// * eni-max-private-ips（每个ENI可以绑定的内网IP数（ENI未绑定子机））。
        /// * nat-gateway-max-dnapts（每个NAT网关可创建的DNAPT数）。
        /// * vpc-max-ipv6s（每个VPC可分配的IPv6地址数）。
        /// * eni-max-ipv6s（每个ENI可分配的IPv6地址数）。
        /// * vpc-max-assistant_cidrs（每个VPC可分配的辅助CIDR数）。
        /// * appid-max-end-point-services （每个开发商每个地域可创建的终端节点服务个数）。
        /// * appid-max-end-point-service-white-lists （每个开发商每个地域可创建的终端节点服务白名单个数）。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcLimitsResponse"/></returns>
        public Task<DescribeVpcLimitsResponse> DescribeVpcLimits(DescribeVpcLimitsRequest req)
        {
            return InternalRequestAsync<DescribeVpcLimitsResponse>(req, "DescribeVpcLimits");
        }

        /// <summary>
        /// 本接口（DescribeVpcLimits）用于获取私有网络配额，部分私有网络的配额有地域属性。
        /// LimitTypes取值范围：
        /// * appid-max-vpcs （每个开发商每个地域可创建的VPC数）。
        /// * vpc-max-subnets（每个VPC可创建的子网数）。
        /// * vpc-max-route-tables（每个VPC可创建的路由表数）。
        /// * route-table-max-policies（每个路由表可添加的策略数）。
        /// * vpc-max-vpn-gateways（每个VPC可创建的VPN网关数）。
        /// * appid-max-custom-gateways（每个开发商可创建的对端网关数）。
        /// * appid-max-vpn-connections（每个开发商可创建的VPN通道数）。
        /// * custom-gateway-max-vpn-connections（每个对端网关可创建的VPN通道数）。
        /// * vpn-gateway-max-custom-gateways（每个VPNGW可以创建的通道数）。
        /// * vpc-max-network-acls（每个VPC可创建的网络ACL数）。
        /// * network-acl-max-inbound-policies（每个网络ACL可添加的入站规则数）。
        /// * network-acl-max-outbound-policies（每个网络ACL可添加的出站规则数）。
        /// * vpc-max-vpcpeers（每个VPC可创建的对等连接数）。
        /// * vpc-max-available-vpcpeers（每个VPC可创建的有效对等连接数）。
        /// * vpc-max-basic-network-interconnections（每个VPC可创建的基础网络云主机与VPC互通数）。
        /// * direct-connection-max-snats（每个专线网关可创建的SNAT数）。
        /// * direct-connection-max-dnats（每个专线网关可创建的DNAT数）。
        /// * direct-connection-max-snapts（每个专线网关可创建的SNAPT数）。
        /// * direct-connection-max-dnapts（每个专线网关可创建的DNAPT数）。
        /// * vpc-max-nat-gateways（每个VPC可创建的NAT网关数）。
        /// * nat-gateway-max-eips（每个NAT可以购买的外网IP数量）。
        /// * vpc-max-enis（每个VPC可创建弹性网卡数）。
        /// * vpc-max-havips（每个VPC可创建HAVIP数）。
        /// * eni-max-private-ips（每个ENI可以绑定的内网IP数（ENI未绑定子机））。
        /// * nat-gateway-max-dnapts（每个NAT网关可创建的DNAPT数）。
        /// * vpc-max-ipv6s（每个VPC可分配的IPv6地址数）。
        /// * eni-max-ipv6s（每个ENI可分配的IPv6地址数）。
        /// * vpc-max-assistant_cidrs（每个VPC可分配的辅助CIDR数）。
        /// * appid-max-end-point-services （每个开发商每个地域可创建的终端节点服务个数）。
        /// * appid-max-end-point-service-white-lists （每个开发商每个地域可创建的终端节点服务白名单个数）。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcLimitsResponse"/></returns>
        public DescribeVpcLimitsResponse DescribeVpcLimitsSync(DescribeVpcLimitsRequest req)
        {
            return InternalRequestAsync<DescribeVpcLimitsResponse>(req, "DescribeVpcLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私有网络对等连接。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPeeringConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpcPeeringConnectionsResponse"/></returns>
        public Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpcPeeringConnectionsResponse>(req, "DescribeVpcPeeringConnections");
        }

        /// <summary>
        /// 查询私有网络对等连接。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPeeringConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpcPeeringConnectionsResponse"/></returns>
        public DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnectionsSync(DescribeVpcPeeringConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpcPeeringConnectionsResponse>(req, "DescribeVpcPeeringConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcPrivateIpAddresses）用于查询VPC内网IP信息。<br />
        /// 只能查询已使用的IP信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public Task<DescribeVpcPrivateIpAddressesResponse> DescribeVpcPrivateIpAddresses(DescribeVpcPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcPrivateIpAddressesResponse>(req, "DescribeVpcPrivateIpAddresses");
        }

        /// <summary>
        /// 本接口（DescribeVpcPrivateIpAddresses）用于查询VPC内网IP信息。<br />
        /// 只能查询已使用的IP信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public DescribeVpcPrivateIpAddressesResponse DescribeVpcPrivateIpAddressesSync(DescribeVpcPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcPrivateIpAddressesResponse>(req, "DescribeVpcPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeVpcResourceDashboard)用于查看VPC资源信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public Task<DescribeVpcResourceDashboardResponse> DescribeVpcResourceDashboard(DescribeVpcResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeVpcResourceDashboardResponse>(req, "DescribeVpcResourceDashboard");
        }

        /// <summary>
        /// 本接口(DescribeVpcResourceDashboard)用于查看VPC资源信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public DescribeVpcResourceDashboardResponse DescribeVpcResourceDashboardSync(DescribeVpcResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeVpcResourceDashboardResponse>(req, "DescribeVpcResourceDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcTaskResult）用于查询VPC任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public Task<DescribeVpcTaskResultResponse> DescribeVpcTaskResult(DescribeVpcTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeVpcTaskResultResponse>(req, "DescribeVpcTaskResult");
        }

        /// <summary>
        /// 本接口（DescribeVpcTaskResult）用于查询VPC任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public DescribeVpcTaskResultResponse DescribeVpcTaskResultSync(DescribeVpcTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeVpcTaskResultResponse>(req, "DescribeVpcTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs");
        }

        /// <summary>
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public DescribeVpcsResponse DescribeVpcsSync(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpnConnections）用于查询VPN通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnections(DescribeVpnConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpnConnectionsResponse>(req, "DescribeVpnConnections");
        }

        /// <summary>
        /// 本接口（DescribeVpnConnections）用于查询VPN通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnectionsSync(DescribeVpnConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpnConnectionsResponse>(req, "DescribeVpnConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewayCcnRoutes）用于查询VPN网关云联网路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public Task<DescribeVpnGatewayCcnRoutesResponse> DescribeVpnGatewayCcnRoutes(DescribeVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayCcnRoutesResponse>(req, "DescribeVpnGatewayCcnRoutes");
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewayCcnRoutes）用于查询VPN网关云联网路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public DescribeVpnGatewayCcnRoutesResponse DescribeVpnGatewayCcnRoutesSync(DescribeVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayCcnRoutesResponse>(req, "DescribeVpnGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewayRoutes）用于查询VPN网关路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public Task<DescribeVpnGatewayRoutesResponse> DescribeVpnGatewayRoutes(DescribeVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayRoutesResponse>(req, "DescribeVpnGatewayRoutes");
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewayRoutes）用于查询VPN网关路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public DescribeVpnGatewayRoutesResponse DescribeVpnGatewayRoutesSync(DescribeVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayRoutesResponse>(req, "DescribeVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewaySslClients）用于查询SSL-VPN-CLIENT 列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslClientsRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslClientsResponse"/></returns>
        public Task<DescribeVpnGatewaySslClientsResponse> DescribeVpnGatewaySslClients(DescribeVpnGatewaySslClientsRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaySslClientsResponse>(req, "DescribeVpnGatewaySslClients");
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewaySslClients）用于查询SSL-VPN-CLIENT 列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslClientsRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslClientsResponse"/></returns>
        public DescribeVpnGatewaySslClientsResponse DescribeVpnGatewaySslClientsSync(DescribeVpnGatewaySslClientsRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaySslClientsResponse>(req, "DescribeVpnGatewaySslClients")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewaySslServers）用于查询SSL-VPN SERVER 列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslServersRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslServersResponse"/></returns>
        public Task<DescribeVpnGatewaySslServersResponse> DescribeVpnGatewaySslServers(DescribeVpnGatewaySslServersRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaySslServersResponse>(req, "DescribeVpnGatewaySslServers");
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewaySslServers）用于查询SSL-VPN SERVER 列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslServersRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslServersResponse"/></returns>
        public DescribeVpnGatewaySslServersResponse DescribeVpnGatewaySslServersSync(DescribeVpnGatewaySslServersRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaySslServersResponse>(req, "DescribeVpnGatewaySslServers")
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
        /// 本接口（DetachCcnInstances）用于从云联网实例中解关联指定的网络实例。<br />
        /// 解关联网络实例后，相应的路由策略会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public Task<DetachCcnInstancesResponse> DetachCcnInstances(DetachCcnInstancesRequest req)
        {
            return InternalRequestAsync<DetachCcnInstancesResponse>(req, "DetachCcnInstances");
        }

        /// <summary>
        /// 本接口（DetachCcnInstances）用于从云联网实例中解关联指定的网络实例。<br />
        /// 解关联网络实例后，相应的路由策略会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public DetachCcnInstancesResponse DetachCcnInstancesSync(DetachCcnInstancesRequest req)
        {
            return InternalRequestAsync<DetachCcnInstancesResponse>(req, "DetachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DetachClassicLinkVpc)用于删除私有网络和基础网络设备互通。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DetachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="DetachClassicLinkVpcResponse"/></returns>
        public Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpc(DetachClassicLinkVpcRequest req)
        {
            return InternalRequestAsync<DetachClassicLinkVpcResponse>(req, "DetachClassicLinkVpc");
        }

        /// <summary>
        /// 本接口(DetachClassicLinkVpc)用于删除私有网络和基础网络设备互通。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DetachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="DetachClassicLinkVpcResponse"/></returns>
        public DetachClassicLinkVpcResponse DetachClassicLinkVpcSync(DetachClassicLinkVpcRequest req)
        {
            return InternalRequestAsync<DetachClassicLinkVpcResponse>(req, "DetachClassicLinkVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachNetworkInterface）用于弹性网卡解绑云服务器。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public Task<DetachNetworkInterfaceResponse> DetachNetworkInterface(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface");
        }

        /// <summary>
        /// 本接口（DetachNetworkInterface）用于弹性网卡解绑云服务器。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterfaceSync(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DetachSnapshotInstances）用于快照策略解关联实例。
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public Task<DetachSnapshotInstancesResponse> DetachSnapshotInstances(DetachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<DetachSnapshotInstancesResponse>(req, "DetachSnapshotInstances");
        }

        /// <summary>
        /// 本接口（DetachSnapshotInstances）用于快照策略解关联实例。
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public DetachSnapshotInstancesResponse DetachSnapshotInstancesSync(DetachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<DetachSnapshotInstancesResponse>(req, "DetachSnapshotInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableCcnRoutes）用于禁用已经启用的云联网（CCN）路由。
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public Task<DisableCcnRoutesResponse> DisableCcnRoutes(DisableCcnRoutesRequest req)
        {
            return InternalRequestAsync<DisableCcnRoutesResponse>(req, "DisableCcnRoutes");
        }

        /// <summary>
        /// 本接口（DisableCcnRoutes）用于禁用已经启用的云联网（CCN）路由。
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public DisableCcnRoutesResponse DisableCcnRoutesSync(DisableCcnRoutesRequest req)
        {
            return InternalRequestAsync<DisableCcnRoutesResponse>(req, "DisableCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableFlowLogs）用于停止流日志。
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public Task<DisableFlowLogsResponse> DisableFlowLogs(DisableFlowLogsRequest req)
        {
            return InternalRequestAsync<DisableFlowLogsResponse>(req, "DisableFlowLogs");
        }

        /// <summary>
        /// 本接口（DisableFlowLogs）用于停止流日志。
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public DisableFlowLogsResponse DisableFlowLogsSync(DisableFlowLogsRequest req)
        {
            return InternalRequestAsync<DisableFlowLogsResponse>(req, "DisableFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableGatewayFlowMonitor）用于关闭网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public Task<DisableGatewayFlowMonitorResponse> DisableGatewayFlowMonitor(DisableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<DisableGatewayFlowMonitorResponse>(req, "DisableGatewayFlowMonitor");
        }

        /// <summary>
        /// 本接口（DisableGatewayFlowMonitor）用于关闭网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public DisableGatewayFlowMonitorResponse DisableGatewayFlowMonitorSync(DisableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<DisableGatewayFlowMonitorResponse>(req, "DisableGatewayFlowMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableRoutes）用于禁用已启用的子网路由
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public Task<DisableRoutesResponse> DisableRoutes(DisableRoutesRequest req)
        {
            return InternalRequestAsync<DisableRoutesResponse>(req, "DisableRoutes");
        }

        /// <summary>
        /// 本接口（DisableRoutes）用于禁用已启用的子网路由
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public DisableRoutesResponse DisableRoutesSync(DisableRoutesRequest req)
        {
            return InternalRequestAsync<DisableRoutesResponse>(req, "DisableRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableSnapshotPolicies）用于停用快照策略。
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public Task<DisableSnapshotPoliciesResponse> DisableSnapshotPolicies(DisableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DisableSnapshotPoliciesResponse>(req, "DisableSnapshotPolicies");
        }

        /// <summary>
        /// 本接口（DisableSnapshotPolicies）用于停用快照策略。
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public DisableSnapshotPoliciesResponse DisableSnapshotPoliciesSync(DisableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DisableSnapshotPoliciesResponse>(req, "DisableSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用SSL-VPN-CLIENT 证书
        /// </summary>
        /// <param name="req"><see cref="DisableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DisableVpnGatewaySslClientCertResponse"/></returns>
        public Task<DisableVpnGatewaySslClientCertResponse> DisableVpnGatewaySslClientCert(DisableVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<DisableVpnGatewaySslClientCertResponse>(req, "DisableVpnGatewaySslClientCert");
        }

        /// <summary>
        /// 禁用SSL-VPN-CLIENT 证书
        /// </summary>
        /// <param name="req"><see cref="DisableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DisableVpnGatewaySslClientCertResponse"/></returns>
        public DisableVpnGatewaySslClientCertResponse DisableVpnGatewaySslClientCertSync(DisableVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<DisableVpnGatewaySslClientCertResponse>(req, "DisableVpnGatewaySslClientCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DisassociateAddress) 用于解绑[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 支持CVM实例，弹性网卡上的EIP解绑
        /// * 不支持NAT上的EIP解绑。NAT上的EIP解绑请参考[DisassociateNatGatewayAddress](https://cloud.tencent.com/document/api/215/36716)
        /// * 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public Task<DisassociateAddressResponse> DisassociateAddress(DisassociateAddressRequest req)
        {
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress");
        }

        /// <summary>
        /// 本接口 (DisassociateAddress) 用于解绑[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 支持CVM实例，弹性网卡上的EIP解绑
        /// * 不支持NAT上的EIP解绑。NAT上的EIP解绑请参考[DisassociateNatGatewayAddress](https://cloud.tencent.com/document/api/215/36716)
        /// * 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public DisassociateAddressResponse DisassociateAddressSync(DisassociateAddressRequest req)
        {
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisassociateDhcpIpWithAddressIp）用于将DhcpIp已绑定的弹性公网IP（EIP）解除绑定。<br />
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DisassociateDhcpIpWithAddressIpRequest"/></param>
        /// <returns><see cref="DisassociateDhcpIpWithAddressIpResponse"/></returns>
        public Task<DisassociateDhcpIpWithAddressIpResponse> DisassociateDhcpIpWithAddressIp(DisassociateDhcpIpWithAddressIpRequest req)
        {
            return InternalRequestAsync<DisassociateDhcpIpWithAddressIpResponse>(req, "DisassociateDhcpIpWithAddressIp");
        }

        /// <summary>
        /// 本接口（DisassociateDhcpIpWithAddressIp）用于将DhcpIp已绑定的弹性公网IP（EIP）解除绑定。<br />
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DisassociateDhcpIpWithAddressIpRequest"/></param>
        /// <returns><see cref="DisassociateDhcpIpWithAddressIpResponse"/></returns>
        public DisassociateDhcpIpWithAddressIpResponse DisassociateDhcpIpWithAddressIpSync(DisassociateDhcpIpWithAddressIpRequest req)
        {
            return InternalRequestAsync<DisassociateDhcpIpWithAddressIpResponse>(req, "DisassociateDhcpIpWithAddressIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将专线网关与NAT网关解绑，解绑之后，专线网关将不能通过NAT网关访问公网
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public Task<DisassociateDirectConnectGatewayNatGatewayResponse> DisassociateDirectConnectGatewayNatGateway(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<DisassociateDirectConnectGatewayNatGatewayResponse>(req, "DisassociateDirectConnectGatewayNatGateway");
        }

        /// <summary>
        /// 将专线网关与NAT网关解绑，解绑之后，专线网关将不能通过NAT网关访问公网
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public DisassociateDirectConnectGatewayNatGatewayResponse DisassociateDirectConnectGatewayNatGatewaySync(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<DisassociateDirectConnectGatewayNatGatewayResponse>(req, "DisassociateDirectConnectGatewayNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisassociateNatGatewayAddress）用于NAT网关解绑弹性IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public Task<DisassociateNatGatewayAddressResponse> DisassociateNatGatewayAddress(DisassociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<DisassociateNatGatewayAddressResponse>(req, "DisassociateNatGatewayAddress");
        }

        /// <summary>
        /// 本接口（DisassociateNatGatewayAddress）用于NAT网关解绑弹性IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public DisassociateNatGatewayAddressResponse DisassociateNatGatewayAddressSync(DisassociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<DisassociateNatGatewayAddressResponse>(req, "DisassociateNatGatewayAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisassociateNetworkAclSubnets）用于网络ACL解关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public Task<DisassociateNetworkAclSubnetsResponse> DisassociateNetworkAclSubnets(DisassociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkAclSubnetsResponse>(req, "DisassociateNetworkAclSubnets");
        }

        /// <summary>
        /// 本接口（DisassociateNetworkAclSubnets）用于网络ACL解关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public DisassociateNetworkAclSubnetsResponse DisassociateNetworkAclSubnetsSync(DisassociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkAclSubnetsResponse>(req, "DisassociateNetworkAclSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisassociateNetworkInterfaceSecurityGroups）用于弹性网卡解绑安全组。支持弹性网卡完全解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public Task<DisassociateNetworkInterfaceSecurityGroupsResponse> DisassociateNetworkInterfaceSecurityGroups(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkInterfaceSecurityGroupsResponse>(req, "DisassociateNetworkInterfaceSecurityGroups");
        }

        /// <summary>
        /// 本接口（DisassociateNetworkInterfaceSecurityGroups）用于弹性网卡解绑安全组。支持弹性网卡完全解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public DisassociateNetworkInterfaceSecurityGroupsResponse DisassociateNetworkInterfaceSecurityGroupsSync(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkInterfaceSecurityGroupsResponse>(req, "DisassociateNetworkInterfaceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisassociateVpcEndPointSecurityGroups）用于终端节点解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public Task<DisassociateVpcEndPointSecurityGroupsResponse> DisassociateVpcEndPointSecurityGroups(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateVpcEndPointSecurityGroupsResponse>(req, "DisassociateVpcEndPointSecurityGroups");
        }

        /// <summary>
        /// 本接口（DisassociateVpcEndPointSecurityGroups）用于终端节点解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public DisassociateVpcEndPointSecurityGroupsResponse DisassociateVpcEndPointSecurityGroupsSync(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateVpcEndPointSecurityGroupsResponse>(req, "DisassociateVpcEndPointSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DownloadCustomerGatewayConfiguration）用于下载VPN通道配置。
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public Task<DownloadCustomerGatewayConfigurationResponse> DownloadCustomerGatewayConfiguration(DownloadCustomerGatewayConfigurationRequest req)
        {
            return InternalRequestAsync<DownloadCustomerGatewayConfigurationResponse>(req, "DownloadCustomerGatewayConfiguration");
        }

        /// <summary>
        /// 本接口（DownloadCustomerGatewayConfiguration）用于下载VPN通道配置。
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public DownloadCustomerGatewayConfigurationResponse DownloadCustomerGatewayConfigurationSync(DownloadCustomerGatewayConfigurationRequest req)
        {
            return InternalRequestAsync<DownloadCustomerGatewayConfigurationResponse>(req, "DownloadCustomerGatewayConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DownloadVpnGatewaySslClientCert）用于下载SSL-VPN-CLIENT 客户端证书。
        /// </summary>
        /// <param name="req"><see cref="DownloadVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DownloadVpnGatewaySslClientCertResponse"/></returns>
        public Task<DownloadVpnGatewaySslClientCertResponse> DownloadVpnGatewaySslClientCert(DownloadVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<DownloadVpnGatewaySslClientCertResponse>(req, "DownloadVpnGatewaySslClientCert");
        }

        /// <summary>
        /// 本接口（DownloadVpnGatewaySslClientCert）用于下载SSL-VPN-CLIENT 客户端证书。
        /// </summary>
        /// <param name="req"><see cref="DownloadVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DownloadVpnGatewaySslClientCertResponse"/></returns>
        public DownloadVpnGatewaySslClientCertResponse DownloadVpnGatewaySslClientCertSync(DownloadVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<DownloadVpnGatewaySslClientCertResponse>(req, "DownloadVpnGatewaySslClientCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableCcnRoutes）用于启用已经加入云联网（CCN）的路由。<br />
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public Task<EnableCcnRoutesResponse> EnableCcnRoutes(EnableCcnRoutesRequest req)
        {
            return InternalRequestAsync<EnableCcnRoutesResponse>(req, "EnableCcnRoutes");
        }

        /// <summary>
        /// 本接口（EnableCcnRoutes）用于启用已经加入云联网（CCN）的路由。<br />
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public EnableCcnRoutesResponse EnableCcnRoutesSync(EnableCcnRoutesRequest req)
        {
            return InternalRequestAsync<EnableCcnRoutesResponse>(req, "EnableCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableFlowLogs）用于启动流日志。
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public Task<EnableFlowLogsResponse> EnableFlowLogs(EnableFlowLogsRequest req)
        {
            return InternalRequestAsync<EnableFlowLogsResponse>(req, "EnableFlowLogs");
        }

        /// <summary>
        /// 本接口（EnableFlowLogs）用于启动流日志。
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public EnableFlowLogsResponse EnableFlowLogsSync(EnableFlowLogsRequest req)
        {
            return InternalRequestAsync<EnableFlowLogsResponse>(req, "EnableFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableGatewayFlowMonitor）用于开启网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public Task<EnableGatewayFlowMonitorResponse> EnableGatewayFlowMonitor(EnableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<EnableGatewayFlowMonitorResponse>(req, "EnableGatewayFlowMonitor");
        }

        /// <summary>
        /// 本接口（EnableGatewayFlowMonitor）用于开启网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public EnableGatewayFlowMonitorResponse EnableGatewayFlowMonitorSync(EnableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<EnableGatewayFlowMonitorResponse>(req, "EnableGatewayFlowMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableRoutes）用于启用已禁用的子网路由。<br />
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public Task<EnableRoutesResponse> EnableRoutes(EnableRoutesRequest req)
        {
            return InternalRequestAsync<EnableRoutesResponse>(req, "EnableRoutes");
        }

        /// <summary>
        /// 本接口（EnableRoutes）用于启用已禁用的子网路由。<br />
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
        /// 本接口（EnableSnapshotPolicies）用于启用快照策略。
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public Task<EnableSnapshotPoliciesResponse> EnableSnapshotPolicies(EnableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<EnableSnapshotPoliciesResponse>(req, "EnableSnapshotPolicies");
        }

        /// <summary>
        /// 本接口（EnableSnapshotPolicies）用于启用快照策略。
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public EnableSnapshotPoliciesResponse EnableSnapshotPoliciesSync(EnableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<EnableSnapshotPoliciesResponse>(req, "EnableSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableVpcEndPointConnect）用于是否接受终端节点连接请求。
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public Task<EnableVpcEndPointConnectResponse> EnableVpcEndPointConnect(EnableVpcEndPointConnectRequest req)
        {
            return InternalRequestAsync<EnableVpcEndPointConnectResponse>(req, "EnableVpcEndPointConnect");
        }

        /// <summary>
        /// 本接口（EnableVpcEndPointConnect）用于是否接受终端节点连接请求。
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public EnableVpcEndPointConnectResponse EnableVpcEndPointConnectSync(EnableVpcEndPointConnectRequest req)
        {
            return InternalRequestAsync<EnableVpcEndPointConnectResponse>(req, "EnableVpcEndPointConnect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableVpnGatewaySslClientCert）用于启用SSL-VPN-CLIENT 证书。
        /// </summary>
        /// <param name="req"><see cref="EnableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="EnableVpnGatewaySslClientCertResponse"/></returns>
        public Task<EnableVpnGatewaySslClientCertResponse> EnableVpnGatewaySslClientCert(EnableVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<EnableVpnGatewaySslClientCertResponse>(req, "EnableVpnGatewaySslClientCert");
        }

        /// <summary>
        /// 本接口（EnableVpnGatewaySslClientCert）用于启用SSL-VPN-CLIENT 证书。
        /// </summary>
        /// <param name="req"><see cref="EnableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="EnableVpnGatewaySslClientCertResponse"/></returns>
        public EnableVpnGatewaySslClientCertResponse EnableVpnGatewaySslClientCertSync(EnableVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<EnableVpnGatewaySslClientCertResponse>(req, "EnableVpnGatewaySslClientCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GenerateVpnConnectionDefaultHealthCheckIp）用于获取一对VPN通道健康检查地址。
        /// </summary>
        /// <param name="req"><see cref="GenerateVpnConnectionDefaultHealthCheckIpRequest"/></param>
        /// <returns><see cref="GenerateVpnConnectionDefaultHealthCheckIpResponse"/></returns>
        public Task<GenerateVpnConnectionDefaultHealthCheckIpResponse> GenerateVpnConnectionDefaultHealthCheckIp(GenerateVpnConnectionDefaultHealthCheckIpRequest req)
        {
            return InternalRequestAsync<GenerateVpnConnectionDefaultHealthCheckIpResponse>(req, "GenerateVpnConnectionDefaultHealthCheckIp");
        }

        /// <summary>
        /// 本接口（GenerateVpnConnectionDefaultHealthCheckIp）用于获取一对VPN通道健康检查地址。
        /// </summary>
        /// <param name="req"><see cref="GenerateVpnConnectionDefaultHealthCheckIpRequest"/></param>
        /// <returns><see cref="GenerateVpnConnectionDefaultHealthCheckIpResponse"/></returns>
        public GenerateVpnConnectionDefaultHealthCheckIpResponse GenerateVpnConnectionDefaultHealthCheckIpSync(GenerateVpnConnectionDefaultHealthCheckIpRequest req)
        {
            return InternalRequestAsync<GenerateVpnConnectionDefaultHealthCheckIpResponse>(req, "GenerateVpnConnectionDefaultHealthCheckIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetCcnRegionBandwidthLimits）用于查询云联网相关地域带宽信息，其中预付费模式的云联网仅支持地域间限速，后付费模式的云联网支持地域间限速和地域出口限速。
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public Task<GetCcnRegionBandwidthLimitsResponse> GetCcnRegionBandwidthLimits(GetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<GetCcnRegionBandwidthLimitsResponse>(req, "GetCcnRegionBandwidthLimits");
        }

        /// <summary>
        /// 本接口（GetCcnRegionBandwidthLimits）用于查询云联网相关地域带宽信息，其中预付费模式的云联网仅支持地域间限速，后付费模式的云联网支持地域间限速和地域出口限速。
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public GetCcnRegionBandwidthLimitsResponse GetCcnRegionBandwidthLimitsSync(GetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<GetCcnRegionBandwidthLimitsResponse>(req, "GetCcnRegionBandwidthLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（HaVipAssociateAddressIp）用于高可用虚拟IP（HAVIP）绑定弹性公网IP（EIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public Task<HaVipAssociateAddressIpResponse> HaVipAssociateAddressIp(HaVipAssociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipAssociateAddressIpResponse>(req, "HaVipAssociateAddressIp");
        }

        /// <summary>
        /// 本接口（HaVipAssociateAddressIp）用于高可用虚拟IP（HAVIP）绑定弹性公网IP（EIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public HaVipAssociateAddressIpResponse HaVipAssociateAddressIpSync(HaVipAssociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipAssociateAddressIpResponse>(req, "HaVipAssociateAddressIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（HaVipDisassociateAddressIp）用于将高可用虚拟IP（HAVIP）已绑定的弹性公网IP（EIP）解除绑定。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public Task<HaVipDisassociateAddressIpResponse> HaVipDisassociateAddressIp(HaVipDisassociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipDisassociateAddressIpResponse>(req, "HaVipDisassociateAddressIp");
        }

        /// <summary>
        /// 本接口（HaVipDisassociateAddressIp）用于将高可用虚拟IP（HAVIP）已绑定的弹性公网IP（EIP）解除绑定。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public HaVipDisassociateAddressIpResponse HaVipDisassociateAddressIpSync(HaVipDisassociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipDisassociateAddressIpResponse>(req, "HaVipDisassociateAddressIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePriceCreateDirectConnectGateway）用于创建专线网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public Task<InquirePriceCreateDirectConnectGatewayResponse> InquirePriceCreateDirectConnectGateway(InquirePriceCreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDirectConnectGatewayResponse>(req, "InquirePriceCreateDirectConnectGateway");
        }

        /// <summary>
        /// 本接口（DescribePriceCreateDirectConnectGateway）用于创建专线网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public InquirePriceCreateDirectConnectGatewayResponse InquirePriceCreateDirectConnectGatewaySync(InquirePriceCreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDirectConnectGatewayResponse>(req, "InquirePriceCreateDirectConnectGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateVpnGateway）用于创建VPN网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateVpnGatewayResponse"/></returns>
        public Task<InquiryPriceCreateVpnGatewayResponse> InquiryPriceCreateVpnGateway(InquiryPriceCreateVpnGatewayRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateVpnGatewayResponse>(req, "InquiryPriceCreateVpnGateway");
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateVpnGateway）用于创建VPN网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateVpnGatewayResponse"/></returns>
        public InquiryPriceCreateVpnGatewayResponse InquiryPriceCreateVpnGatewaySync(InquiryPriceCreateVpnGatewayRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateVpnGatewayResponse>(req, "InquiryPriceCreateVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewVpnGateway）用于续费VPN网关询价。目前仅支持IPSEC类型网关的询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public Task<InquiryPriceRenewVpnGatewayResponse> InquiryPriceRenewVpnGateway(InquiryPriceRenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewVpnGatewayResponse>(req, "InquiryPriceRenewVpnGateway");
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewVpnGateway）用于续费VPN网关询价。目前仅支持IPSEC类型网关的询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public InquiryPriceRenewVpnGatewayResponse InquiryPriceRenewVpnGatewaySync(InquiryPriceRenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewVpnGatewayResponse>(req, "InquiryPriceRenewVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceResetVpnGatewayInternetMaxBandwidth）用于调整VPN网关带宽上限询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public Task<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> InquiryPriceResetVpnGatewayInternetMaxBandwidth(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth");
        }

        /// <summary>
        /// 本接口（InquiryPriceResetVpnGatewayInternetMaxBandwidth）用于调整VPN网关带宽上限询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse InquiryPriceResetVpnGatewayInternetMaxBandwidthSync(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（LockCcnBandwidths）用户锁定云联网限速实例。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（LockCcns）。
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统。
        /// </summary>
        /// <param name="req"><see cref="LockCcnBandwidthsRequest"/></param>
        /// <returns><see cref="LockCcnBandwidthsResponse"/></returns>
        public Task<LockCcnBandwidthsResponse> LockCcnBandwidths(LockCcnBandwidthsRequest req)
        {
            return InternalRequestAsync<LockCcnBandwidthsResponse>(req, "LockCcnBandwidths");
        }

        /// <summary>
        /// 本接口（LockCcnBandwidths）用户锁定云联网限速实例。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（LockCcns）。
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统。
        /// </summary>
        /// <param name="req"><see cref="LockCcnBandwidthsRequest"/></param>
        /// <returns><see cref="LockCcnBandwidthsResponse"/></returns>
        public LockCcnBandwidthsResponse LockCcnBandwidthsSync(LockCcnBandwidthsRequest req)
        {
            return InternalRequestAsync<LockCcnBandwidthsResponse>(req, "LockCcnBandwidths")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（LockCcns）用于锁定云联网实例
        /// 
        /// 该接口一般用来封禁出口限速的云联网实例, 目前联通内部运营系统通过云API调用, 因为出口限速无法按地域间封禁, 只能按更粗的云联网实例粒度封禁, 如果是地域间限速, 一般可以通过更细的限速实例粒度封禁（LockCcnBandwidths）
        /// 
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统
        /// 
        /// </summary>
        /// <param name="req"><see cref="LockCcnsRequest"/></param>
        /// <returns><see cref="LockCcnsResponse"/></returns>
        public Task<LockCcnsResponse> LockCcns(LockCcnsRequest req)
        {
            return InternalRequestAsync<LockCcnsResponse>(req, "LockCcns");
        }

        /// <summary>
        /// 本接口（LockCcns）用于锁定云联网实例
        /// 
        /// 该接口一般用来封禁出口限速的云联网实例, 目前联通内部运营系统通过云API调用, 因为出口限速无法按地域间封禁, 只能按更粗的云联网实例粒度封禁, 如果是地域间限速, 一般可以通过更细的限速实例粒度封禁（LockCcnBandwidths）
        /// 
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统
        /// 
        /// </summary>
        /// <param name="req"><see cref="LockCcnsRequest"/></param>
        /// <returns><see cref="LockCcnsResponse"/></returns>
        public LockCcnsResponse LockCcnsSync(LockCcnsRequest req)
        {
            return InternalRequestAsync<LockCcnsResponse>(req, "LockCcns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（MigrateNetworkInterface）用于弹性网卡迁移。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public Task<MigrateNetworkInterfaceResponse> MigrateNetworkInterface(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface");
        }

        /// <summary>
        /// 本接口（MigrateNetworkInterface）用于弹性网卡迁移。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public MigrateNetworkInterfaceResponse MigrateNetworkInterfaceSync(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（MigratePrivateIpAddress）用于弹性网卡内网IP迁移。
        /// * 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// * 迁移前后的弹性网卡必须在同一个子网内。  
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public Task<MigratePrivateIpAddressResponse> MigratePrivateIpAddress(MigratePrivateIpAddressRequest req)
        {
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress");
        }

        /// <summary>
        /// 本接口（MigratePrivateIpAddress）用于弹性网卡内网IP迁移。
        /// * 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// * 迁移前后的弹性网卡必须在同一个子网内。  
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public MigratePrivateIpAddressResponse MigratePrivateIpAddressSync(MigratePrivateIpAddressRequest req)
        {
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyAddressAttribute) 用于修改[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public Task<ModifyAddressAttributeResponse> ModifyAddressAttribute(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute");
        }

        /// <summary>
        /// 本接口 (ModifyAddressAttribute) 用于修改[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public ModifyAddressAttributeResponse ModifyAddressAttributeSync(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于调整具有带宽属性弹性公网IP的网络计费模式
        /// * 支持BANDWIDTH_PREPAID_BY_MONTH和TRAFFIC_POSTPAID_BY_HOUR两种网络计费模式之间的切换。
        /// * 每个弹性公网IP支持调整两次，次数超出则无法调整。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressInternetChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyAddressInternetChargeTypeResponse"/></returns>
        public Task<ModifyAddressInternetChargeTypeResponse> ModifyAddressInternetChargeType(ModifyAddressInternetChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyAddressInternetChargeTypeResponse>(req, "ModifyAddressInternetChargeType");
        }

        /// <summary>
        /// 该接口用于调整具有带宽属性弹性公网IP的网络计费模式
        /// * 支持BANDWIDTH_PREPAID_BY_MONTH和TRAFFIC_POSTPAID_BY_HOUR两种网络计费模式之间的切换。
        /// * 每个弹性公网IP支持调整两次，次数超出则无法调整。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressInternetChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyAddressInternetChargeTypeResponse"/></returns>
        public ModifyAddressInternetChargeTypeResponse ModifyAddressInternetChargeTypeSync(ModifyAddressInternetChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyAddressInternetChargeTypeResponse>(req, "ModifyAddressInternetChargeType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateAttribute）用于修改IP地址模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public Task<ModifyAddressTemplateAttributeResponse> ModifyAddressTemplateAttribute(ModifyAddressTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateAttributeResponse>(req, "ModifyAddressTemplateAttribute");
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateAttribute）用于修改IP地址模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public ModifyAddressTemplateAttributeResponse ModifyAddressTemplateAttributeSync(ModifyAddressTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateAttributeResponse>(req, "ModifyAddressTemplateAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateGroupAttribute）用于修改IP地址模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public Task<ModifyAddressTemplateGroupAttributeResponse> ModifyAddressTemplateGroupAttribute(ModifyAddressTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateGroupAttributeResponse>(req, "ModifyAddressTemplateGroupAttribute");
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateGroupAttribute）用于修改IP地址模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public ModifyAddressTemplateGroupAttributeResponse ModifyAddressTemplateGroupAttributeSync(ModifyAddressTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateGroupAttributeResponse>(req, "ModifyAddressTemplateGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAddressesBandwidth）用于调整[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)(简称EIP)带宽，支持后付费EIP, 预付费EIP和带宽包EIP
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public Task<ModifyAddressesBandwidthResponse> ModifyAddressesBandwidth(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth");
        }

        /// <summary>
        /// 本接口（ModifyAddressesBandwidth）用于调整[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)(简称EIP)带宽，支持后付费EIP, 预付费EIP和带宽包EIP
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public ModifyAddressesBandwidthResponse ModifyAddressesBandwidthSync(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAssistantCidr）用于批量修改辅助CIDR，支持新增和删除。
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public Task<ModifyAssistantCidrResponse> ModifyAssistantCidr(ModifyAssistantCidrRequest req)
        {
            return InternalRequestAsync<ModifyAssistantCidrResponse>(req, "ModifyAssistantCidr");
        }

        /// <summary>
        /// 本接口（ModifyAssistantCidr）用于批量修改辅助CIDR，支持新增和删除。
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public ModifyAssistantCidrResponse ModifyAssistantCidrSync(ModifyAssistantCidrRequest req)
        {
            return InternalRequestAsync<ModifyAssistantCidrResponse>(req, "ModifyAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于修改带宽包属性，包括带宽包名字等
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public Task<ModifyBandwidthPackageAttributeResponse> ModifyBandwidthPackageAttribute(ModifyBandwidthPackageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBandwidthPackageAttributeResponse>(req, "ModifyBandwidthPackageAttribute");
        }

        /// <summary>
        /// 接口用于修改带宽包属性，包括带宽包名字等
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public ModifyBandwidthPackageAttributeResponse ModifyBandwidthPackageAttributeSync(ModifyBandwidthPackageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBandwidthPackageAttributeResponse>(req, "ModifyBandwidthPackageAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CCN关联实例属性，目前仅修改备注description
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public Task<ModifyCcnAttachedInstancesAttributeResponse> ModifyCcnAttachedInstancesAttribute(ModifyCcnAttachedInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttachedInstancesAttributeResponse>(req, "ModifyCcnAttachedInstancesAttribute");
        }

        /// <summary>
        /// 修改CCN关联实例属性，目前仅修改备注description
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public ModifyCcnAttachedInstancesAttributeResponse ModifyCcnAttachedInstancesAttributeSync(ModifyCcnAttachedInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttachedInstancesAttributeResponse>(req, "ModifyCcnAttachedInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyCcnAttribute）用于修改云联网（CCN）的相关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public Task<ModifyCcnAttributeResponse> ModifyCcnAttribute(ModifyCcnAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttributeResponse>(req, "ModifyCcnAttribute");
        }

        /// <summary>
        /// 本接口（ModifyCcnAttribute）用于修改云联网（CCN）的相关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public ModifyCcnAttributeResponse ModifyCcnAttributeSync(ModifyCcnAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttributeResponse>(req, "ModifyCcnAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyCcnRegionBandwidthLimitsType）用于修改后付费云联网实例修改带宽限速策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public Task<ModifyCcnRegionBandwidthLimitsTypeResponse> ModifyCcnRegionBandwidthLimitsType(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
            return InternalRequestAsync<ModifyCcnRegionBandwidthLimitsTypeResponse>(req, "ModifyCcnRegionBandwidthLimitsType");
        }

        /// <summary>
        /// 本接口（ModifyCcnRegionBandwidthLimitsType）用于修改后付费云联网实例修改带宽限速策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public ModifyCcnRegionBandwidthLimitsTypeResponse ModifyCcnRegionBandwidthLimitsTypeSync(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
            return InternalRequestAsync<ModifyCcnRegionBandwidthLimitsTypeResponse>(req, "ModifyCcnRegionBandwidthLimitsType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改云联网路由表名称和备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRouteTablesRequest"/></param>
        /// <returns><see cref="ModifyCcnRouteTablesResponse"/></returns>
        public Task<ModifyCcnRouteTablesResponse> ModifyCcnRouteTables(ModifyCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<ModifyCcnRouteTablesResponse>(req, "ModifyCcnRouteTables");
        }

        /// <summary>
        /// 该接口用于修改云联网路由表名称和备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRouteTablesRequest"/></param>
        /// <returns><see cref="ModifyCcnRouteTablesResponse"/></returns>
        public ModifyCcnRouteTablesResponse ModifyCcnRouteTablesSync(ModifyCcnRouteTablesRequest req)
        {
            return InternalRequestAsync<ModifyCcnRouteTablesResponse>(req, "ModifyCcnRouteTables")
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
        /// 本接口（ModifyDhcpIpAttribute）用于修改DhcpIp属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDhcpIpAttributeRequest"/></param>
        /// <returns><see cref="ModifyDhcpIpAttributeResponse"/></returns>
        public Task<ModifyDhcpIpAttributeResponse> ModifyDhcpIpAttribute(ModifyDhcpIpAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDhcpIpAttributeResponse>(req, "ModifyDhcpIpAttribute");
        }

        /// <summary>
        /// 本接口（ModifyDhcpIpAttribute）用于修改DhcpIp属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDhcpIpAttributeRequest"/></param>
        /// <returns><see cref="ModifyDhcpIpAttributeResponse"/></returns>
        public ModifyDhcpIpAttributeResponse ModifyDhcpIpAttributeSync(ModifyDhcpIpAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDhcpIpAttributeResponse>(req, "ModifyDhcpIpAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDirectConnectGatewayAttribute）用于修改专线网关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public Task<ModifyDirectConnectGatewayAttributeResponse> ModifyDirectConnectGatewayAttribute(ModifyDirectConnectGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectGatewayAttributeResponse>(req, "ModifyDirectConnectGatewayAttribute");
        }

        /// <summary>
        /// 本接口（ModifyDirectConnectGatewayAttribute）用于修改专线网关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public ModifyDirectConnectGatewayAttributeResponse ModifyDirectConnectGatewayAttributeSync(ModifyDirectConnectGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectGatewayAttributeResponse>(req, "ModifyDirectConnectGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyFlowLogAttribute）用于修改流日志属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest req)
        {
            return InternalRequestAsync<ModifyFlowLogAttributeResponse>(req, "ModifyFlowLogAttribute");
        }

        /// <summary>
        /// 本接口（ModifyFlowLogAttribute）用于修改流日志属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeSync(ModifyFlowLogAttributeRequest req)
        {
            return InternalRequestAsync<ModifyFlowLogAttributeResponse>(req, "ModifyFlowLogAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyGatewayFlowQos）用于调整网关流控带宽。
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public Task<ModifyGatewayFlowQosResponse> ModifyGatewayFlowQos(ModifyGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<ModifyGatewayFlowQosResponse>(req, "ModifyGatewayFlowQos");
        }

        /// <summary>
        /// 本接口（ModifyGatewayFlowQos）用于调整网关流控带宽。
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public ModifyGatewayFlowQosResponse ModifyGatewayFlowQosSync(ModifyGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<ModifyGatewayFlowQosResponse>(req, "ModifyGatewayFlowQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyHaVipAttribute）用于修改高可用虚拟IP（HAVIP）属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public Task<ModifyHaVipAttributeResponse> ModifyHaVipAttribute(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute");
        }

        /// <summary>
        /// 本接口（ModifyHaVipAttribute）用于修改高可用虚拟IP（HAVIP）属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public ModifyHaVipAttributeResponse ModifyHaVipAttributeSync(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改IPV6地址访问internet的带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyIp6AddressesBandwidthResponse"/></returns>
        public Task<ModifyIp6AddressesBandwidthResponse> ModifyIp6AddressesBandwidth(ModifyIp6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyIp6AddressesBandwidthResponse>(req, "ModifyIp6AddressesBandwidth");
        }

        /// <summary>
        /// 该接口用于修改IPV6地址访问internet的带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyIp6AddressesBandwidthResponse"/></returns>
        public ModifyIp6AddressesBandwidthResponse ModifyIp6AddressesBandwidthSync(ModifyIp6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyIp6AddressesBandwidthResponse>(req, "ModifyIp6AddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改IPV6转换规则，当前仅支持修改转换规则名称，IPV4地址和IPV4端口号
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6RuleRequest"/></param>
        /// <returns><see cref="ModifyIp6RuleResponse"/></returns>
        public Task<ModifyIp6RuleResponse> ModifyIp6Rule(ModifyIp6RuleRequest req)
        {
            return InternalRequestAsync<ModifyIp6RuleResponse>(req, "ModifyIp6Rule");
        }

        /// <summary>
        /// 该接口用于修改IPV6转换规则，当前仅支持修改转换规则名称，IPV4地址和IPV4端口号
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6RuleRequest"/></param>
        /// <returns><see cref="ModifyIp6RuleResponse"/></returns>
        public ModifyIp6RuleResponse ModifyIp6RuleSync(ModifyIp6RuleRequest req)
        {
            return InternalRequestAsync<ModifyIp6RuleResponse>(req, "ModifyIp6Rule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改IP6转换实例属性，当前仅支持修改实例名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6TranslatorRequest"/></param>
        /// <returns><see cref="ModifyIp6TranslatorResponse"/></returns>
        public Task<ModifyIp6TranslatorResponse> ModifyIp6Translator(ModifyIp6TranslatorRequest req)
        {
            return InternalRequestAsync<ModifyIp6TranslatorResponse>(req, "ModifyIp6Translator");
        }

        /// <summary>
        /// 该接口用于修改IP6转换实例属性，当前仅支持修改实例名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6TranslatorRequest"/></param>
        /// <returns><see cref="ModifyIp6TranslatorResponse"/></returns>
        public ModifyIp6TranslatorResponse ModifyIp6TranslatorSync(ModifyIp6TranslatorRequest req)
        {
            return InternalRequestAsync<ModifyIp6TranslatorResponse>(req, "ModifyIp6Translator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡内网IPv6地址属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public Task<ModifyIpv6AddressesAttributeResponse> ModifyIpv6AddressesAttribute(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute");
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡内网IPv6地址属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public ModifyIpv6AddressesAttributeResponse ModifyIpv6AddressesAttributeSync(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyLocalGateway）用于修改CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public Task<ModifyLocalGatewayResponse> ModifyLocalGateway(ModifyLocalGatewayRequest req)
        {
            return InternalRequestAsync<ModifyLocalGatewayResponse>(req, "ModifyLocalGateway");
        }

        /// <summary>
        /// 本接口（ModifyLocalGateway）用于修改CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public ModifyLocalGatewayResponse ModifyLocalGatewaySync(ModifyLocalGatewayRequest req)
        {
            return InternalRequestAsync<ModifyLocalGatewayResponse>(req, "ModifyLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayAttribute）用于修改NAT网关的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public Task<ModifyNatGatewayAttributeResponse> ModifyNatGatewayAttribute(ModifyNatGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayAttributeResponse>(req, "ModifyNatGatewayAttribute");
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayAttribute）用于修改NAT网关的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public ModifyNatGatewayAttributeResponse ModifyNatGatewayAttributeSync(ModifyNatGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayAttributeResponse>(req, "ModifyNatGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayDestinationIpPortTranslationNatRule）用于修改NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> ModifyNatGatewayDestinationIpPortTranslationNatRule(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayDestinationIpPortTranslationNatRule）用于修改NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse ModifyNatGatewayDestinationIpPortTranslationNatRuleSync(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNatGatewaySourceIpTranslationNatRule）用于修改NAT网关SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public Task<ModifyNatGatewaySourceIpTranslationNatRuleResponse> ModifyNatGatewaySourceIpTranslationNatRule(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewaySourceIpTranslationNatRuleResponse>(req, "ModifyNatGatewaySourceIpTranslationNatRule");
        }

        /// <summary>
        /// 本接口（ModifyNatGatewaySourceIpTranslationNatRule）用于修改NAT网关SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewaySourceIpTranslationNatRuleResponse ModifyNatGatewaySourceIpTranslationNatRuleSync(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewaySourceIpTranslationNatRuleResponse>(req, "ModifyNatGatewaySourceIpTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyNetDetect)用于修改网络探测参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public Task<ModifyNetDetectResponse> ModifyNetDetect(ModifyNetDetectRequest req)
        {
            return InternalRequestAsync<ModifyNetDetectResponse>(req, "ModifyNetDetect");
        }

        /// <summary>
        /// 本接口(ModifyNetDetect)用于修改网络探测参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public ModifyNetDetectResponse ModifyNetDetectSync(ModifyNetDetectRequest req)
        {
            return InternalRequestAsync<ModifyNetDetectResponse>(req, "ModifyNetDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclAttribute）用于修改网络ACL属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public Task<ModifyNetworkAclAttributeResponse> ModifyNetworkAclAttribute(ModifyNetworkAclAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclAttributeResponse>(req, "ModifyNetworkAclAttribute");
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclAttribute）用于修改网络ACL属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public ModifyNetworkAclAttributeResponse ModifyNetworkAclAttributeSync(ModifyNetworkAclAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclAttributeResponse>(req, "ModifyNetworkAclAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclEntries）用于修改（包括添加和删除）网络ACL的入站规则和出站规则。在NetworkAclEntrySet参数中：
        /// * 若同时传入入站规则和出站规则，则重置原有的入站规则和出站规则，并分别导入传入的规则。
        /// * 若仅传入入站规则，则仅重置原有的入站规则，并导入传入的规则，不影响原有的出站规则（若仅传入出站规则，处理方式类似入站方向）。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclEntriesResponse"/></returns>
        public Task<ModifyNetworkAclEntriesResponse> ModifyNetworkAclEntries(ModifyNetworkAclEntriesRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclEntriesResponse>(req, "ModifyNetworkAclEntries");
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclEntries）用于修改（包括添加和删除）网络ACL的入站规则和出站规则。在NetworkAclEntrySet参数中：
        /// * 若同时传入入站规则和出站规则，则重置原有的入站规则和出站规则，并分别导入传入的规则。
        /// * 若仅传入入站规则，则仅重置原有的入站规则，并导入传入的规则，不影响原有的出站规则（若仅传入出站规则，处理方式类似入站方向）。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclEntriesResponse"/></returns>
        public ModifyNetworkAclEntriesResponse ModifyNetworkAclEntriesSync(ModifyNetworkAclEntriesRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclEntriesResponse>(req, "ModifyNetworkAclEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclQuintupleEntries）用于修改网络ACL五元组的入站规则和出站规则。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<ModifyNetworkAclQuintupleEntriesResponse> ModifyNetworkAclQuintupleEntries(ModifyNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclQuintupleEntriesResponse>(req, "ModifyNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclQuintupleEntries）用于修改网络ACL五元组的入站规则和出站规则。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public ModifyNetworkAclQuintupleEntriesResponse ModifyNetworkAclQuintupleEntriesSync(ModifyNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclQuintupleEntriesResponse>(req, "ModifyNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceAttribute）用于修改弹性网卡属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkInterfaceAttributeResponse>(req, "ModifyNetworkInterfaceAttribute");
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceAttribute）用于修改弹性网卡属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttributeSync(ModifyNetworkInterfaceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkInterfaceAttributeResponse>(req, "ModifyNetworkInterfaceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceQos）用于修改弹性网卡服务质量。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceQosRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceQosResponse"/></returns>
        public Task<ModifyNetworkInterfaceQosResponse> ModifyNetworkInterfaceQos(ModifyNetworkInterfaceQosRequest req)
        {
            return InternalRequestAsync<ModifyNetworkInterfaceQosResponse>(req, "ModifyNetworkInterfaceQos");
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceQos）用于修改弹性网卡服务质量。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceQosRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceQosResponse"/></returns>
        public ModifyNetworkInterfaceQosResponse ModifyNetworkInterfaceQosSync(ModifyNetworkInterfaceQosRequest req)
        {
            return InternalRequestAsync<ModifyNetworkInterfaceQosResponse>(req, "ModifyNetworkInterfaceQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyPrivateIpAddressesAttribute）用于修改弹性网卡内网IP属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public Task<ModifyPrivateIpAddressesAttributeResponse> ModifyPrivateIpAddressesAttribute(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute");
        }

        /// <summary>
        /// 本接口（ModifyPrivateIpAddressesAttribute）用于修改弹性网卡内网IP属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public ModifyPrivateIpAddressesAttributeResponse ModifyPrivateIpAddressesAttributeSync(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayAttribute）用于修改私网NAT网关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayAttributeResponse"/></returns>
        public Task<ModifyPrivateNatGatewayAttributeResponse> ModifyPrivateNatGatewayAttribute(ModifyPrivateNatGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayAttributeResponse>(req, "ModifyPrivateNatGatewayAttribute");
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayAttribute）用于修改私网NAT网关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayAttributeResponse"/></returns>
        public ModifyPrivateNatGatewayAttributeResponse ModifyPrivateNatGatewayAttributeSync(ModifyPrivateNatGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayAttributeResponse>(req, "ModifyPrivateNatGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayDestinationIpPortTranslationNatRule）用于修改私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleResponse> ModifyPrivateNatGatewayDestinationIpPortTranslationNatRule(ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "ModifyPrivateNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayDestinationIpPortTranslationNatRule）用于修改私网NAT网关目的端口转换规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleResponse ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleSync(ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "ModifyPrivateNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayTranslationAclRule）用于修改私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayTranslationAclRuleRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayTranslationAclRuleResponse"/></returns>
        public Task<ModifyPrivateNatGatewayTranslationAclRuleResponse> ModifyPrivateNatGatewayTranslationAclRule(ModifyPrivateNatGatewayTranslationAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayTranslationAclRuleResponse>(req, "ModifyPrivateNatGatewayTranslationAclRule");
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayTranslationAclRule）用于修改私网NAT网关源端转换访问控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayTranslationAclRuleRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayTranslationAclRuleResponse"/></returns>
        public ModifyPrivateNatGatewayTranslationAclRuleResponse ModifyPrivateNatGatewayTranslationAclRuleSync(ModifyPrivateNatGatewayTranslationAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayTranslationAclRuleResponse>(req, "ModifyPrivateNatGatewayTranslationAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayTranslationNatRule）用于修改私网NAT网关源端转换规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayTranslationNatRuleResponse"/></returns>
        public Task<ModifyPrivateNatGatewayTranslationNatRuleResponse> ModifyPrivateNatGatewayTranslationNatRule(ModifyPrivateNatGatewayTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayTranslationNatRuleResponse>(req, "ModifyPrivateNatGatewayTranslationNatRule");
        }

        /// <summary>
        /// 本接口（ModifyPrivateNatGatewayTranslationNatRule）用于修改私网NAT网关源端转换规则
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNatGatewayTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyPrivateNatGatewayTranslationNatRuleResponse"/></returns>
        public ModifyPrivateNatGatewayTranslationNatRuleResponse ModifyPrivateNatGatewayTranslationNatRuleSync(ModifyPrivateNatGatewayTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNatGatewayTranslationNatRuleResponse>(req, "ModifyPrivateNatGatewayTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyRouteTableAttribute）用于修改路由表（RouteTable）属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public Task<ModifyRouteTableAttributeResponse> ModifyRouteTableAttribute(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute");
        }

        /// <summary>
        /// 本接口（ModifyRouteTableAttribute）用于修改路由表（RouteTable）属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public ModifyRouteTableAttributeResponse ModifyRouteTableAttributeSync(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于编辑云联网路由表选择策略
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableSelectionPoliciesRequest"/></param>
        /// <returns><see cref="ModifyRouteTableSelectionPoliciesResponse"/></returns>
        public Task<ModifyRouteTableSelectionPoliciesResponse> ModifyRouteTableSelectionPolicies(ModifyRouteTableSelectionPoliciesRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableSelectionPoliciesResponse>(req, "ModifyRouteTableSelectionPolicies");
        }

        /// <summary>
        /// 该接口用于编辑云联网路由表选择策略
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableSelectionPoliciesRequest"/></param>
        /// <returns><see cref="ModifyRouteTableSelectionPoliciesResponse"/></returns>
        public ModifyRouteTableSelectionPoliciesResponse ModifyRouteTableSelectionPoliciesSync(ModifyRouteTableSelectionPoliciesRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableSelectionPoliciesResponse>(req, "ModifyRouteTableSelectionPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySecurityGroupAttribute）用于修改安全组（SecurityGroupPolicy）属性。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute");
        }

        /// <summary>
        /// 本接口（ModifySecurityGroupAttribute）用于修改安全组（SecurityGroupPolicy）属性。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttributeSync(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySecurityGroupPolicies）用于重置安全组出站和入站规则（SecurityGroupPolicy）。
        /// 
        /// <ul>
        /// <li>该接口不支持自定义索引 PolicyIndex。</li>
        /// <li>在 SecurityGroupPolicySet 参数中：<ul>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 为0, 表示清空所有规则，并忽略 Egress 和 Ingress。</li>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 不为0, 在添加出站和入站规则（Egress 和 Ingress）时：<ul>
        /// 		<li>Protocol 字段支持输入 TCP, UDP, ICMP, ICMPV6, GRE, ALL。</li>
        /// 		<li>CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// 		<li>Ipv6CidrBlock 字段允许输入符合 IPv6 cidr 格式标准的任意字符串。在基础网络中，如果Ipv6CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// 		<li>SecurityGroupId 字段允许输入与待修改的安全组位于相同项目中的安全组 ID，包括这个安全组 ID 本身，代表安全组下所有云服务器的内网 IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。</li>
        /// 		<li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受。</li>
        /// 		<li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// 		<li>CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate 四者是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。</li>
        /// </ul></li></ul></li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public Task<ModifySecurityGroupPoliciesResponse> ModifySecurityGroupPolicies(ModifySecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies");
        }

        /// <summary>
        /// 本接口（ModifySecurityGroupPolicies）用于重置安全组出站和入站规则（SecurityGroupPolicy）。
        /// 
        /// <ul>
        /// <li>该接口不支持自定义索引 PolicyIndex。</li>
        /// <li>在 SecurityGroupPolicySet 参数中：<ul>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 为0, 表示清空所有规则，并忽略 Egress 和 Ingress。</li>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 不为0, 在添加出站和入站规则（Egress 和 Ingress）时：<ul>
        /// 		<li>Protocol 字段支持输入 TCP, UDP, ICMP, ICMPV6, GRE, ALL。</li>
        /// 		<li>CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// 		<li>Ipv6CidrBlock 字段允许输入符合 IPv6 cidr 格式标准的任意字符串。在基础网络中，如果Ipv6CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// 		<li>SecurityGroupId 字段允许输入与待修改的安全组位于相同项目中的安全组 ID，包括这个安全组 ID 本身，代表安全组下所有云服务器的内网 IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。</li>
        /// 		<li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受。</li>
        /// 		<li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// 		<li>CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate 四者是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。</li>
        /// </ul></li></ul></li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public ModifySecurityGroupPoliciesResponse ModifySecurityGroupPoliciesSync(ModifySecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateAttribute）用于修改协议端口模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public Task<ModifyServiceTemplateAttributeResponse> ModifyServiceTemplateAttribute(ModifyServiceTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateAttributeResponse>(req, "ModifyServiceTemplateAttribute");
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateAttribute）用于修改协议端口模板。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public ModifyServiceTemplateAttributeResponse ModifyServiceTemplateAttributeSync(ModifyServiceTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateAttributeResponse>(req, "ModifyServiceTemplateAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateGroupAttribute）用于修改协议端口模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public Task<ModifyServiceTemplateGroupAttributeResponse> ModifyServiceTemplateGroupAttribute(ModifyServiceTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateGroupAttributeResponse>(req, "ModifyServiceTemplateGroupAttribute");
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateGroupAttribute）用于修改协议端口模板集合。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public ModifyServiceTemplateGroupAttributeResponse ModifyServiceTemplateGroupAttributeSync(ModifyServiceTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateGroupAttributeResponse>(req, "ModifyServiceTemplateGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySnapshotPolicies）用于修改快照策略。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public Task<ModifySnapshotPoliciesResponse> ModifySnapshotPolicies(ModifySnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySnapshotPoliciesResponse>(req, "ModifySnapshotPolicies");
        }

        /// <summary>
        /// 本接口（ModifySnapshotPolicies）用于修改快照策略。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public ModifySnapshotPoliciesResponse ModifySnapshotPoliciesSync(ModifySnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySnapshotPoliciesResponse>(req, "ModifySnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySubnetAttribute）用于修改子网属性。
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public Task<ModifySubnetAttributeResponse> ModifySubnetAttribute(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute");
        }

        /// <summary>
        /// 本接口（ModifySubnetAttribute）用于修改子网属性。
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public ModifySubnetAttributeResponse ModifySubnetAttributeSync(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模板对象中的IP地址、协议端口、IP地址组、协议端口组。
        /// </summary>
        /// <param name="req"><see cref="ModifyTemplateMemberRequest"/></param>
        /// <returns><see cref="ModifyTemplateMemberResponse"/></returns>
        public Task<ModifyTemplateMemberResponse> ModifyTemplateMember(ModifyTemplateMemberRequest req)
        {
            return InternalRequestAsync<ModifyTemplateMemberResponse>(req, "ModifyTemplateMember");
        }

        /// <summary>
        /// 修改模板对象中的IP地址、协议端口、IP地址组、协议端口组。
        /// </summary>
        /// <param name="req"><see cref="ModifyTemplateMemberRequest"/></param>
        /// <returns><see cref="ModifyTemplateMemberResponse"/></returns>
        public ModifyTemplateMemberResponse ModifyTemplateMemberSync(ModifyTemplateMemberRequest req)
        {
            return InternalRequestAsync<ModifyTemplateMemberResponse>(req, "ModifyTemplateMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpcAttribute）用于修改私有网络（VPC）的相关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute");
        }

        /// <summary>
        /// 本接口（ModifyVpcAttribute）用于修改私有网络（VPC）的相关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public ModifyVpcAttributeResponse ModifyVpcAttributeSync(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointAttribute）用于修改终端节点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public Task<ModifyVpcEndPointAttributeResponse> ModifyVpcEndPointAttribute(ModifyVpcEndPointAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointAttributeResponse>(req, "ModifyVpcEndPointAttribute");
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointAttribute）用于修改终端节点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public ModifyVpcEndPointAttributeResponse ModifyVpcEndPointAttributeSync(ModifyVpcEndPointAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointAttributeResponse>(req, "ModifyVpcEndPointAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceAttribute）用于修改终端节点服务属性。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public Task<ModifyVpcEndPointServiceAttributeResponse> ModifyVpcEndPointServiceAttribute(ModifyVpcEndPointServiceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceAttributeResponse>(req, "ModifyVpcEndPointServiceAttribute");
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceAttribute）用于修改终端节点服务属性。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public ModifyVpcEndPointServiceAttributeResponse ModifyVpcEndPointServiceAttributeSync(ModifyVpcEndPointServiceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceAttributeResponse>(req, "ModifyVpcEndPointServiceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceWhiteList）用于修改终端节点服务白名单属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<ModifyVpcEndPointServiceWhiteListResponse> ModifyVpcEndPointServiceWhiteList(ModifyVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceWhiteListResponse>(req, "ModifyVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceWhiteList）用于修改终端节点服务白名单属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public ModifyVpcEndPointServiceWhiteListResponse ModifyVpcEndPointServiceWhiteListSync(ModifyVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceWhiteListResponse>(req, "ModifyVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpcPeeringConnection）用于修改私有网络对等连接属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="ModifyVpcPeeringConnectionResponse"/></returns>
        public Task<ModifyVpcPeeringConnectionResponse> ModifyVpcPeeringConnection(ModifyVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<ModifyVpcPeeringConnectionResponse>(req, "ModifyVpcPeeringConnection");
        }

        /// <summary>
        /// 本接口（ModifyVpcPeeringConnection）用于修改私有网络对等连接属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="ModifyVpcPeeringConnectionResponse"/></returns>
        public ModifyVpcPeeringConnectionResponse ModifyVpcPeeringConnectionSync(ModifyVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<ModifyVpcPeeringConnectionResponse>(req, "ModifyVpcPeeringConnection")
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
        /// 本接口（ModifyVpnGatewayCcnRoutes）用于修改VPN网关云联网路由。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public Task<ModifyVpnGatewayCcnRoutesResponse> ModifyVpnGatewayCcnRoutes(ModifyVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayCcnRoutesResponse>(req, "ModifyVpnGatewayCcnRoutes");
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayCcnRoutes）用于修改VPN网关云联网路由。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public ModifyVpnGatewayCcnRoutesResponse ModifyVpnGatewayCcnRoutesSync(ModifyVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayCcnRoutesResponse>(req, "ModifyVpnGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayRoutes）用于修改VPN路由是否启用。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public Task<ModifyVpnGatewayRoutesResponse> ModifyVpnGatewayRoutes(ModifyVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayRoutesResponse>(req, "ModifyVpnGatewayRoutes");
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayRoutes）用于修改VPN路由是否启用。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public ModifyVpnGatewayRoutesResponse ModifyVpnGatewayRoutesSync(ModifyVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayRoutesResponse>(req, "ModifyVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新SslVpnClient证书
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewaySslClientCertResponse"/></returns>
        public Task<ModifyVpnGatewaySslClientCertResponse> ModifyVpnGatewaySslClientCert(ModifyVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewaySslClientCertResponse>(req, "ModifyVpnGatewaySslClientCert");
        }

        /// <summary>
        /// 更新SslVpnClient证书
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewaySslClientCertResponse"/></returns>
        public ModifyVpnGatewaySslClientCertResponse ModifyVpnGatewaySslClientCertSync(ModifyVpnGatewaySslClientCertRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewaySslClientCertResponse>(req, "ModifyVpnGatewaySslClientCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改 SSL-VPN 服务端属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewaySslServerResponse"/></returns>
        public Task<ModifyVpnGatewaySslServerResponse> ModifyVpnGatewaySslServer(ModifyVpnGatewaySslServerRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewaySslServerResponse>(req, "ModifyVpnGatewaySslServer");
        }

        /// <summary>
        /// 本接口用于修改 SSL-VPN 服务端属性
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewaySslServerResponse"/></returns>
        public ModifyVpnGatewaySslServerResponse ModifyVpnGatewaySslServerSync(ModifyVpnGatewaySslServerRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewaySslServerResponse>(req, "ModifyVpnGatewaySslServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（NotifyRoutes）用于路由表列表页操作增加“发布到云联网”，发布路由到云联网。
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public Task<NotifyRoutesResponse> NotifyRoutes(NotifyRoutesRequest req)
        {
            return InternalRequestAsync<NotifyRoutesResponse>(req, "NotifyRoutes");
        }

        /// <summary>
        /// 本接口（NotifyRoutes）用于路由表列表页操作增加“发布到云联网”，发布路由到云联网。
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public NotifyRoutesResponse NotifyRoutesSync(NotifyRoutesRequest req)
        {
            return InternalRequestAsync<NotifyRoutesResponse>(req, "NotifyRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 刷新专线直连nat路由，更新nat到专线的路由表
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public Task<RefreshDirectConnectGatewayRouteToNatGatewayResponse> RefreshDirectConnectGatewayRouteToNatGateway(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
            return InternalRequestAsync<RefreshDirectConnectGatewayRouteToNatGatewayResponse>(req, "RefreshDirectConnectGatewayRouteToNatGateway");
        }

        /// <summary>
        /// 刷新专线直连nat路由，更新nat到专线的路由表
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public RefreshDirectConnectGatewayRouteToNatGatewayResponse RefreshDirectConnectGatewayRouteToNatGatewaySync(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
            return InternalRequestAsync<RefreshDirectConnectGatewayRouteToNatGatewayResponse>(req, "RefreshDirectConnectGatewayRouteToNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RejectAttachCcnInstances）用于跨账号关联实例时，云联网所有者拒绝关联操作。
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public Task<RejectAttachCcnInstancesResponse> RejectAttachCcnInstances(RejectAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<RejectAttachCcnInstancesResponse>(req, "RejectAttachCcnInstances");
        }

        /// <summary>
        /// 本接口（RejectAttachCcnInstances）用于跨账号关联实例时，云联网所有者拒绝关联操作。
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public RejectAttachCcnInstancesResponse RejectAttachCcnInstancesSync(RejectAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<RejectAttachCcnInstancesResponse>(req, "RejectAttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RejectVpcPeeringConnection）用于驳回对等连接请求。
        /// </summary>
        /// <param name="req"><see cref="RejectVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="RejectVpcPeeringConnectionResponse"/></returns>
        public Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<RejectVpcPeeringConnectionResponse>(req, "RejectVpcPeeringConnection");
        }

        /// <summary>
        /// 本接口（RejectVpcPeeringConnection）用于驳回对等连接请求。
        /// </summary>
        /// <param name="req"><see cref="RejectVpcPeeringConnectionRequest"/></param>
        /// <returns><see cref="RejectVpcPeeringConnectionResponse"/></returns>
        public RejectVpcPeeringConnectionResponse RejectVpcPeeringConnectionSync(RejectVpcPeeringConnectionRequest req)
        {
            return InternalRequestAsync<RejectVpcPeeringConnectionResponse>(req, "RejectVpcPeeringConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ReleaseAddresses) 用于释放一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// * 只有状态为 UNBIND 的 EIP 才能进行释放操作。
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public Task<ReleaseAddressesResponse> ReleaseAddresses(ReleaseAddressesRequest req)
        {
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses");
        }

        /// <summary>
        /// 本接口 (ReleaseAddresses) 用于释放一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// * 只有状态为 UNBIND 的 EIP 才能进行释放操作。
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public ReleaseAddressesResponse ReleaseAddressesSync(ReleaseAddressesRequest req)
        {
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于给弹性公网IPv6地址释放带宽。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ReleaseIp6AddressesBandwidthResponse"/></returns>
        public Task<ReleaseIp6AddressesBandwidthResponse> ReleaseIp6AddressesBandwidth(ReleaseIp6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ReleaseIp6AddressesBandwidthResponse>(req, "ReleaseIp6AddressesBandwidth");
        }

        /// <summary>
        /// 该接口用于给弹性公网IPv6地址释放带宽。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ReleaseIp6AddressesBandwidthResponse"/></returns>
        public ReleaseIp6AddressesBandwidthResponse ReleaseIp6AddressesBandwidthSync(ReleaseIp6AddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ReleaseIp6AddressesBandwidthResponse>(req, "ReleaseIp6AddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口用于删除带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public Task<RemoveBandwidthPackageResourcesResponse> RemoveBandwidthPackageResources(RemoveBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<RemoveBandwidthPackageResourcesResponse>(req, "RemoveBandwidthPackageResources");
        }

        /// <summary>
        /// 接口用于删除带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public RemoveBandwidthPackageResourcesResponse RemoveBandwidthPackageResourcesSync(RemoveBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<RemoveBandwidthPackageResourcesResponse>(req, "RemoveBandwidthPackageResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. 该接口用于删除IPV6转换规则
        /// 2. 支持批量删除同一个转换实例下的多个转换规则
        /// </summary>
        /// <param name="req"><see cref="RemoveIp6RulesRequest"/></param>
        /// <returns><see cref="RemoveIp6RulesResponse"/></returns>
        public Task<RemoveIp6RulesResponse> RemoveIp6Rules(RemoveIp6RulesRequest req)
        {
            return InternalRequestAsync<RemoveIp6RulesResponse>(req, "RemoveIp6Rules");
        }

        /// <summary>
        /// 1. 该接口用于删除IPV6转换规则
        /// 2. 支持批量删除同一个转换实例下的多个转换规则
        /// </summary>
        /// <param name="req"><see cref="RemoveIp6RulesRequest"/></param>
        /// <returns><see cref="RemoveIp6RulesResponse"/></returns>
        public RemoveIp6RulesResponse RemoveIp6RulesSync(RemoveIp6RulesRequest req)
        {
            return InternalRequestAsync<RemoveIp6RulesResponse>(req, "RemoveIp6Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于续费包月带宽计费模式的弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="RenewAddressesRequest"/></param>
        /// <returns><see cref="RenewAddressesResponse"/></returns>
        public Task<RenewAddressesResponse> RenewAddresses(RenewAddressesRequest req)
        {
            return InternalRequestAsync<RenewAddressesResponse>(req, "RenewAddresses");
        }

        /// <summary>
        /// 该接口用于续费包月带宽计费模式的弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="RenewAddressesRequest"/></param>
        /// <returns><see cref="RenewAddressesResponse"/></returns>
        public RenewAddressesResponse RenewAddressesSync(RenewAddressesRequest req)
        {
            return InternalRequestAsync<RenewAddressesResponse>(req, "RenewAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RenewVpnGateway）用于预付费（包年包月）VPN网关续费。目前只支持IPSEC网关。
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public Task<RenewVpnGatewayResponse> RenewVpnGateway(RenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<RenewVpnGatewayResponse>(req, "RenewVpnGateway");
        }

        /// <summary>
        /// 本接口（RenewVpnGateway）用于预付费（包年包月）VPN网关续费。目前只支持IPSEC网关。
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public RenewVpnGatewayResponse RenewVpnGatewaySync(RenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<RenewVpnGatewayResponse>(req, "RenewVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ReplaceCcnRouteTableBroadcastPolicys)用于替换云联网路由表路由传播策略。
        /// > 特别注意：是全量覆盖，非增量添加
        /// 
        /// **路由条件支持以下四种：**
        /// 
        /// - 实例类型: `instance-type`，可选值：私有网络 `VPC`、专线网关 `DIRECTCONNECT`、专线网关 `VPNGW`
        /// - 实例ID: `instance-id`，例如：`dcg-8zljkrft`、`vpc-jdevjrup`，暂不支持 `Edge` 实例
        /// - 实例地域: `instance-region`，例如：`ap-guangzhou`<br />产品支持的所有地域列表可通过接口 [DescribeRegions](https://cloud.tencent.com/document/product/1596/77930) 查询，其中参数 `Product` 设置为 `ccn`
        /// - 路由前缀: `cidr-block`，例如：`10.1.0.0/16`
        /// 
        /// 
        /// **传播条件支持以下三种：**
        /// 
        /// - 实例类型: `instance-type`，格式同路由条件
        /// - 实例ID: `instance-id`，格式同路由条件
        /// - 实例地域: `instance-region`，格式同路由条件
        /// 
        /// 
        /// **使用限制：**
        /// - 一条策略内的单个条件类型，最大支持设置 `25` 个条件值
        /// - 一张路由表，最大支持 `100` 条路由传播策略
        /// - 路由条件类型中，只有 `cidr-block` 类型支持模糊匹配和精确匹配两种，其它类型只支持精确匹配一种模式
        /// </summary>
        /// <param name="req"><see cref="ReplaceCcnRouteTableBroadcastPolicysRequest"/></param>
        /// <returns><see cref="ReplaceCcnRouteTableBroadcastPolicysResponse"/></returns>
        public Task<ReplaceCcnRouteTableBroadcastPolicysResponse> ReplaceCcnRouteTableBroadcastPolicys(ReplaceCcnRouteTableBroadcastPolicysRequest req)
        {
            return InternalRequestAsync<ReplaceCcnRouteTableBroadcastPolicysResponse>(req, "ReplaceCcnRouteTableBroadcastPolicys");
        }

        /// <summary>
        /// 本接口(ReplaceCcnRouteTableBroadcastPolicys)用于替换云联网路由表路由传播策略。
        /// > 特别注意：是全量覆盖，非增量添加
        /// 
        /// **路由条件支持以下四种：**
        /// 
        /// - 实例类型: `instance-type`，可选值：私有网络 `VPC`、专线网关 `DIRECTCONNECT`、专线网关 `VPNGW`
        /// - 实例ID: `instance-id`，例如：`dcg-8zljkrft`、`vpc-jdevjrup`，暂不支持 `Edge` 实例
        /// - 实例地域: `instance-region`，例如：`ap-guangzhou`<br />产品支持的所有地域列表可通过接口 [DescribeRegions](https://cloud.tencent.com/document/product/1596/77930) 查询，其中参数 `Product` 设置为 `ccn`
        /// - 路由前缀: `cidr-block`，例如：`10.1.0.0/16`
        /// 
        /// 
        /// **传播条件支持以下三种：**
        /// 
        /// - 实例类型: `instance-type`，格式同路由条件
        /// - 实例ID: `instance-id`，格式同路由条件
        /// - 实例地域: `instance-region`，格式同路由条件
        /// 
        /// 
        /// **使用限制：**
        /// - 一条策略内的单个条件类型，最大支持设置 `25` 个条件值
        /// - 一张路由表，最大支持 `100` 条路由传播策略
        /// - 路由条件类型中，只有 `cidr-block` 类型支持模糊匹配和精确匹配两种，其它类型只支持精确匹配一种模式
        /// </summary>
        /// <param name="req"><see cref="ReplaceCcnRouteTableBroadcastPolicysRequest"/></param>
        /// <returns><see cref="ReplaceCcnRouteTableBroadcastPolicysResponse"/></returns>
        public ReplaceCcnRouteTableBroadcastPolicysResponse ReplaceCcnRouteTableBroadcastPolicysSync(ReplaceCcnRouteTableBroadcastPolicysRequest req)
        {
            return InternalRequestAsync<ReplaceCcnRouteTableBroadcastPolicysResponse>(req, "ReplaceCcnRouteTableBroadcastPolicys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ReplaceRouteTableInputPolicys)用于替换云联网路由表路由接收策略。
        /// > 特别注意：是全量覆盖，非增量添加
        /// 
        /// **路由条件支持以下四种：**
        /// 
        /// - 实例类型: `instance-type`，可选值：私有网络 `VPC`、专线网关 `DIRECTCONNECT`、专线网关 `VPNGW`
        /// - 实例ID: `instance-id`，例如：`dcg-8zljkrft`、`vpc-jdevjrup`，暂不支持 `Edge` 实例
        /// - 实例地域: `instance-region`，例如：`ap-guangzhou`<br />产品支持的所有地域列表可通过接口 [DescribeRegions](https://cloud.tencent.com/document/product/1596/77930) 查询，其中参数 `Product` 设置为 `ccn`
        /// - 路由前缀: `cidr-block`，例如：`10.1.0.0/16`
        /// 
        /// 
        /// **使用限制：**
        /// - 一条策略内的单个条件类型，最大支持设置 `25` 个条件值
        /// - 一张路由表，最大支持 `100` 条路由接收策略
        /// - 路由条件类型中，只有 `cidr-block` 类型支持模糊匹配和精确匹配两种，其它类型只支持精确匹配一种模式
        /// </summary>
        /// <param name="req"><see cref="ReplaceCcnRouteTableInputPolicysRequest"/></param>
        /// <returns><see cref="ReplaceCcnRouteTableInputPolicysResponse"/></returns>
        public Task<ReplaceCcnRouteTableInputPolicysResponse> ReplaceCcnRouteTableInputPolicys(ReplaceCcnRouteTableInputPolicysRequest req)
        {
            return InternalRequestAsync<ReplaceCcnRouteTableInputPolicysResponse>(req, "ReplaceCcnRouteTableInputPolicys");
        }

        /// <summary>
        /// 本接口(ReplaceRouteTableInputPolicys)用于替换云联网路由表路由接收策略。
        /// > 特别注意：是全量覆盖，非增量添加
        /// 
        /// **路由条件支持以下四种：**
        /// 
        /// - 实例类型: `instance-type`，可选值：私有网络 `VPC`、专线网关 `DIRECTCONNECT`、专线网关 `VPNGW`
        /// - 实例ID: `instance-id`，例如：`dcg-8zljkrft`、`vpc-jdevjrup`，暂不支持 `Edge` 实例
        /// - 实例地域: `instance-region`，例如：`ap-guangzhou`<br />产品支持的所有地域列表可通过接口 [DescribeRegions](https://cloud.tencent.com/document/product/1596/77930) 查询，其中参数 `Product` 设置为 `ccn`
        /// - 路由前缀: `cidr-block`，例如：`10.1.0.0/16`
        /// 
        /// 
        /// **使用限制：**
        /// - 一条策略内的单个条件类型，最大支持设置 `25` 个条件值
        /// - 一张路由表，最大支持 `100` 条路由接收策略
        /// - 路由条件类型中，只有 `cidr-block` 类型支持模糊匹配和精确匹配两种，其它类型只支持精确匹配一种模式
        /// </summary>
        /// <param name="req"><see cref="ReplaceCcnRouteTableInputPolicysRequest"/></param>
        /// <returns><see cref="ReplaceCcnRouteTableInputPolicysResponse"/></returns>
        public ReplaceCcnRouteTableInputPolicysResponse ReplaceCcnRouteTableInputPolicysSync(ReplaceCcnRouteTableInputPolicysRequest req)
        {
            return InternalRequestAsync<ReplaceCcnRouteTableInputPolicysResponse>(req, "ReplaceCcnRouteTableInputPolicys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReplaceDirectConnectGatewayCcnRoutes）根据路由ID（RouteId）修改指定的路由（Route），支持批量修改。
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<ReplaceDirectConnectGatewayCcnRoutesResponse> ReplaceDirectConnectGatewayCcnRoutes(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceDirectConnectGatewayCcnRoutesResponse>(req, "ReplaceDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// 本接口（ReplaceDirectConnectGatewayCcnRoutes）根据路由ID（RouteId）修改指定的路由（Route），支持批量修改。
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public ReplaceDirectConnectGatewayCcnRoutesResponse ReplaceDirectConnectGatewayCcnRoutesSync(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceDirectConnectGatewayCcnRoutesResponse>(req, "ReplaceDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReplaceRouteTableAssociation）用于修改子网（Subnet）关联的路由表（RouteTable）。
        /// * 一个子网只能关联一个路由表。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation");
        }

        /// <summary>
        /// 本接口（ReplaceRouteTableAssociation）用于修改子网（Subnet）关联的路由表（RouteTable）。
        /// * 一个子网只能关联一个路由表。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociationSync(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReplaceRoutes）根据路由策略ID（RouteId）修改指定的路由策略（Route），支持批量修改。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public Task<ReplaceRoutesResponse> ReplaceRoutes(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes");
        }

        /// <summary>
        /// 本接口（ReplaceRoutes）根据路由策略ID（RouteId）修改指定的路由策略（Route），支持批量修改。
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public ReplaceRoutesResponse ReplaceRoutesSync(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReplaceSecurityGroupPolicies）用于批量修改安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条或多条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPoliciesResponse"/></returns>
        public Task<ReplaceSecurityGroupPoliciesResponse> ReplaceSecurityGroupPolicies(ReplaceSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPoliciesResponse>(req, "ReplaceSecurityGroupPolicies");
        }

        /// <summary>
        /// 本接口（ReplaceSecurityGroupPolicies）用于批量修改安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条或多条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPoliciesResponse"/></returns>
        public ReplaceSecurityGroupPoliciesResponse ReplaceSecurityGroupPoliciesSync(ReplaceSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPoliciesResponse>(req, "ReplaceSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReplaceSecurityGroupPolicy）用于替换单条安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public Task<ReplaceSecurityGroupPolicyResponse> ReplaceSecurityGroupPolicy(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy");
        }

        /// <summary>
        /// 本接口（ReplaceSecurityGroupPolicy）用于替换单条安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public ReplaceSecurityGroupPolicyResponse ReplaceSecurityGroupPolicySync(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetAttachCcnInstances）用于跨账号关联实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public Task<ResetAttachCcnInstancesResponse> ResetAttachCcnInstances(ResetAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnInstancesResponse>(req, "ResetAttachCcnInstances");
        }

        /// <summary>
        /// 本接口（ResetAttachCcnInstances）用于跨账号关联实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public ResetAttachCcnInstancesResponse ResetAttachCcnInstancesSync(ResetAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnInstancesResponse>(req, "ResetAttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetNatGatewayConnection）用来NAT网关并发连接上限。
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public Task<ResetNatGatewayConnectionResponse> ResetNatGatewayConnection(ResetNatGatewayConnectionRequest req)
        {
            return InternalRequestAsync<ResetNatGatewayConnectionResponse>(req, "ResetNatGatewayConnection");
        }

        /// <summary>
        /// 本接口（ResetNatGatewayConnection）用来NAT网关并发连接上限。
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public ResetNatGatewayConnectionResponse ResetNatGatewayConnectionSync(ResetNatGatewayConnectionRequest req)
        {
            return InternalRequestAsync<ResetNatGatewayConnectionResponse>(req, "ResetNatGatewayConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetRoutes）用于对某个路由表名称和所有路由策略（Route）进行重新设置。<br />
        /// 注意: 调用本接口是先删除当前路由表中所有路由策略, 再保存新提交的路由策略内容, 会引起网络中断。
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public Task<ResetRoutesResponse> ResetRoutes(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes");
        }

        /// <summary>
        /// 本接口（ResetRoutes）用于对某个路由表名称和所有路由策略（Route）进行重新设置。<br />
        /// 注意: 调用本接口是先删除当前路由表中所有路由策略, 再保存新提交的路由策略内容, 会引起网络中断。
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public ResetRoutesResponse ResetRoutesSync(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetVpnConnection）用于重置VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public Task<ResetVpnConnectionResponse> ResetVpnConnection(ResetVpnConnectionRequest req)
        {
            return InternalRequestAsync<ResetVpnConnectionResponse>(req, "ResetVpnConnection");
        }

        /// <summary>
        /// 本接口（ResetVpnConnection）用于重置VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public ResetVpnConnectionResponse ResetVpnConnectionSync(ResetVpnConnectionRequest req)
        {
            return InternalRequestAsync<ResetVpnConnectionResponse>(req, "ResetVpnConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetVpnGatewayInternetMaxBandwidth）用于调整VPN网关带宽上限。VPN网关带宽目前仅支持部分带宽范围内升降配，如【5,100】Mbps和【200,1000】Mbps，在各自带宽范围内可提升配额，跨范围提升配额和降配暂不支持，如果是包年包月VPN网关需要在有效期内。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public Task<ResetVpnGatewayInternetMaxBandwidthResponse> ResetVpnGatewayInternetMaxBandwidth(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetVpnGatewayInternetMaxBandwidthResponse>(req, "ResetVpnGatewayInternetMaxBandwidth");
        }

        /// <summary>
        /// 本接口（ResetVpnGatewayInternetMaxBandwidth）用于调整VPN网关带宽上限。VPN网关带宽目前仅支持部分带宽范围内升降配，如【5,100】Mbps和【200,1000】Mbps，在各自带宽范围内可提升配额，跨范围提升配额和降配暂不支持，如果是包年包月VPN网关需要在有效期内。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public ResetVpnGatewayInternetMaxBandwidthResponse ResetVpnGatewayInternetMaxBandwidthSync(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetVpnGatewayInternetMaxBandwidthResponse>(req, "ResetVpnGatewayInternetMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResumeSnapshotInstance）用于根据备份内容恢复安全组策略。
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public Task<ResumeSnapshotInstanceResponse> ResumeSnapshotInstance(ResumeSnapshotInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSnapshotInstanceResponse>(req, "ResumeSnapshotInstance");
        }

        /// <summary>
        /// 本接口（ResumeSnapshotInstance）用于根据备份内容恢复安全组策略。
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public ResumeSnapshotInstanceResponse ResumeSnapshotInstanceSync(ResumeSnapshotInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSnapshotInstanceResponse>(req, "ResumeSnapshotInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReturnNormalAddresses）用于解绑并释放普通公网IP。
        /// 为完善公网IP的访问管理功能，此接口于2022年12月15日升级优化鉴权功能，升级后子用户调用此接口需向主账号申请CAM策略授权，否则可能调用失败。您可以提前为子账号配置操作授权，详情见[授权指南](https://cloud.tencent.com/document/product/598/34545)。
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public Task<ReturnNormalAddressesResponse> ReturnNormalAddresses(ReturnNormalAddressesRequest req)
        {
            return InternalRequestAsync<ReturnNormalAddressesResponse>(req, "ReturnNormalAddresses");
        }

        /// <summary>
        /// 本接口（ReturnNormalAddresses）用于解绑并释放普通公网IP。
        /// 为完善公网IP的访问管理功能，此接口于2022年12月15日升级优化鉴权功能，升级后子用户调用此接口需向主账号申请CAM策略授权，否则可能调用失败。您可以提前为子账号配置操作授权，详情见[授权指南](https://cloud.tencent.com/document/product/598/34545)。
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public ReturnNormalAddressesResponse ReturnNormalAddressesSync(ReturnNormalAddressesRequest req)
        {
            return InternalRequestAsync<ReturnNormalAddressesResponse>(req, "ReturnNormalAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetCcnRegionBandwidthLimits）用于设置云联网（CCN）各地域出带宽上限，或者地域间带宽上限。
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public Task<SetCcnRegionBandwidthLimitsResponse> SetCcnRegionBandwidthLimits(SetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<SetCcnRegionBandwidthLimitsResponse>(req, "SetCcnRegionBandwidthLimits");
        }

        /// <summary>
        /// 本接口（SetCcnRegionBandwidthLimits）用于设置云联网（CCN）各地域出带宽上限，或者地域间带宽上限。
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public SetCcnRegionBandwidthLimitsResponse SetCcnRegionBandwidthLimitsSync(SetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<SetCcnRegionBandwidthLimitsResponse>(req, "SetCcnRegionBandwidthLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetVpnGatewaysRenewFlag）用于设置VPNGW续费标记。
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public Task<SetVpnGatewaysRenewFlagResponse> SetVpnGatewaysRenewFlag(SetVpnGatewaysRenewFlagRequest req)
        {
            return InternalRequestAsync<SetVpnGatewaysRenewFlagResponse>(req, "SetVpnGatewaysRenewFlag");
        }

        /// <summary>
        /// 本接口（SetVpnGatewaysRenewFlag）用于设置VPNGW续费标记。
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public SetVpnGatewaysRenewFlagResponse SetVpnGatewaysRenewFlagSync(SetVpnGatewaysRenewFlagRequest req)
        {
            return InternalRequestAsync<SetVpnGatewaysRenewFlagResponse>(req, "SetVpnGatewaysRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (TransformAddress) 用于将实例的普通公网 IP 转换为[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 平台对用户每地域每日解绑 EIP 重新分配普通公网 IP 次数有所限制（可参见 [EIP 产品简介](/document/product/213/1941)）。上述配额可通过 [DescribeAddressQuota](https://cloud.tencent.com/document/api/213/1378) 接口获取。
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public Task<TransformAddressResponse> TransformAddress(TransformAddressRequest req)
        {
            return InternalRequestAsync<TransformAddressResponse>(req, "TransformAddress");
        }

        /// <summary>
        /// 本接口 (TransformAddress) 用于将实例的普通公网 IP 转换为[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 平台对用户每地域每日解绑 EIP 重新分配普通公网 IP 次数有所限制（可参见 [EIP 产品简介](/document/product/213/1941)）。上述配额可通过 [DescribeAddressQuota](https://cloud.tencent.com/document/api/213/1378) 接口获取。
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public TransformAddressResponse TransformAddressSync(TransformAddressRequest req)
        {
            return InternalRequestAsync<TransformAddressResponse>(req, "TransformAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public Task<UnassignIpv6AddressesResponse> UnassignIpv6Addresses(UnassignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<UnassignIpv6AddressesResponse>(req, "UnassignIpv6Addresses");
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public UnassignIpv6AddressesResponse UnassignIpv6AddressesSync(UnassignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<UnassignIpv6AddressesResponse>(req, "UnassignIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnassignIpv6CidrBlock）用于释放IPv6网段。<br />
        /// 网段如果还有IP占用且未回收，则网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public Task<UnassignIpv6CidrBlockResponse> UnassignIpv6CidrBlock(UnassignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6CidrBlockResponse>(req, "UnassignIpv6CidrBlock");
        }

        /// <summary>
        /// 本接口（UnassignIpv6CidrBlock）用于释放IPv6网段。<br />
        /// 网段如果还有IP占用且未回收，则网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public UnassignIpv6CidrBlockResponse UnassignIpv6CidrBlockSync(UnassignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6CidrBlockResponse>(req, "UnassignIpv6CidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnassignIpv6SubnetCidrBlock）用于释放IPv6子网段。<br />
        /// 子网段如果还有IP占用且未回收，则子网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public Task<UnassignIpv6SubnetCidrBlockResponse> UnassignIpv6SubnetCidrBlock(UnassignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6SubnetCidrBlockResponse>(req, "UnassignIpv6SubnetCidrBlock");
        }

        /// <summary>
        /// 本接口（UnassignIpv6SubnetCidrBlock）用于释放IPv6子网段。<br />
        /// 子网段如果还有IP占用且未回收，则子网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public UnassignIpv6SubnetCidrBlockResponse UnassignIpv6SubnetCidrBlockSync(UnassignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6SubnetCidrBlockResponse>(req, "UnassignIpv6SubnetCidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnassignPrivateIpAddresses）用于弹性网卡退还内网 IP。
        /// * 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="UnassignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="UnassignPrivateIpAddressesResponse"/></returns>
        public Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<UnassignPrivateIpAddressesResponse>(req, "UnassignPrivateIpAddresses");
        }

        /// <summary>
        /// 本接口（UnassignPrivateIpAddresses）用于弹性网卡退还内网 IP。
        /// * 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="UnassignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="UnassignPrivateIpAddressesResponse"/></returns>
        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddressesSync(UnassignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<UnassignPrivateIpAddressesResponse>(req, "UnassignPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnlockCcnBandwidths）用户解锁云联网限速实例。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（SecurityUnlockCcns）。
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统。
        /// </summary>
        /// <param name="req"><see cref="UnlockCcnBandwidthsRequest"/></param>
        /// <returns><see cref="UnlockCcnBandwidthsResponse"/></returns>
        public Task<UnlockCcnBandwidthsResponse> UnlockCcnBandwidths(UnlockCcnBandwidthsRequest req)
        {
            return InternalRequestAsync<UnlockCcnBandwidthsResponse>(req, "UnlockCcnBandwidths");
        }

        /// <summary>
        /// 本接口（UnlockCcnBandwidths）用户解锁云联网限速实例。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（SecurityUnlockCcns）。
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统。
        /// </summary>
        /// <param name="req"><see cref="UnlockCcnBandwidthsRequest"/></param>
        /// <returns><see cref="UnlockCcnBandwidthsResponse"/></returns>
        public UnlockCcnBandwidthsResponse UnlockCcnBandwidthsSync(UnlockCcnBandwidthsRequest req)
        {
            return InternalRequestAsync<UnlockCcnBandwidthsResponse>(req, "UnlockCcnBandwidths")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnlockCcns）用于解锁云联网实例
        /// 
        /// 该接口一般用来解封禁出口限速的云联网实例, 目前联通内部运营系统通过云API调用, 因为出口限速无法按地域间解封禁, 只能按更粗的云联网实例粒度解封禁, 如果是地域间限速, 一般可以通过更细的限速实例粒度解封禁（UnlockCcnBandwidths）
        /// 
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统
        /// 
        /// </summary>
        /// <param name="req"><see cref="UnlockCcnsRequest"/></param>
        /// <returns><see cref="UnlockCcnsResponse"/></returns>
        public Task<UnlockCcnsResponse> UnlockCcns(UnlockCcnsRequest req)
        {
            return InternalRequestAsync<UnlockCcnsResponse>(req, "UnlockCcns");
        }

        /// <summary>
        /// 本接口（UnlockCcns）用于解锁云联网实例
        /// 
        /// 该接口一般用来解封禁出口限速的云联网实例, 目前联通内部运营系统通过云API调用, 因为出口限速无法按地域间解封禁, 只能按更粗的云联网实例粒度解封禁, 如果是地域间限速, 一般可以通过更细的限速实例粒度解封禁（UnlockCcnBandwidths）
        /// 
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统
        /// 
        /// </summary>
        /// <param name="req"><see cref="UnlockCcnsRequest"/></param>
        /// <returns><see cref="UnlockCcnsResponse"/></returns>
        public UnlockCcnsResponse UnlockCcnsSync(UnlockCcnsRequest req)
        {
            return InternalRequestAsync<UnlockCcnsResponse>(req, "UnlockCcns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（WithdrawNotifyRoutes）用于撤销已发布到云联网的路由。路由表列表页操作增加“从云联网撤销”。
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public Task<WithdrawNotifyRoutesResponse> WithdrawNotifyRoutes(WithdrawNotifyRoutesRequest req)
        {
            return InternalRequestAsync<WithdrawNotifyRoutesResponse>(req, "WithdrawNotifyRoutes");
        }

        /// <summary>
        /// 本接口（WithdrawNotifyRoutes）用于撤销已发布到云联网的路由。路由表列表页操作增加“从云联网撤销”。
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public WithdrawNotifyRoutesResponse WithdrawNotifyRoutesSync(WithdrawNotifyRoutesRequest req)
        {
            return InternalRequestAsync<WithdrawNotifyRoutesResponse>(req, "WithdrawNotifyRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
