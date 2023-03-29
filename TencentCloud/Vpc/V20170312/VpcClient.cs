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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 本接口（AcceptAttachCcnInstances）用于跨账号关联实例时，云联网所有者接受并同意关联操作。
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public async Task<AcceptAttachCcnInstancesResponse> AcceptAttachCcnInstances(AcceptAttachCcnInstancesRequest req)
        {
             JsonResponseModel<AcceptAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AcceptAttachCcnInstances）用于跨账号关联实例时，云联网所有者接受并同意关联操作。
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public AcceptAttachCcnInstancesResponse AcceptAttachCcnInstancesSync(AcceptAttachCcnInstancesRequest req)
        {
             JsonResponseModel<AcceptAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcceptAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于添加带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public async Task<AddBandwidthPackageResourcesResponse> AddBandwidthPackageResources(AddBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<AddBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于添加带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public AddBandwidthPackageResourcesResponse AddBandwidthPackageResourcesSync(AddBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<AddBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于在转换实例下添加IPV6转换规则。
        /// 2. 支持在同一个转换实例下批量添加转换规则，一个账户在一个地域最多50个。
        /// 3. 一个完整的转换规则包括vip6:vport6:protocol:vip:vport，其中vip6:vport6:protocol必须是唯一。
        /// </summary>
        /// <param name="req"><see cref="AddIp6RulesRequest"/></param>
        /// <returns><see cref="AddIp6RulesResponse"/></returns>
        public async Task<AddIp6RulesResponse> AddIp6Rules(AddIp6RulesRequest req)
        {
             JsonResponseModel<AddIp6RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddIp6Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddIp6RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AddIp6RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddIp6Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddIp6RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加模板对象中的IP地址、协议端口、IP地址组、协议端口组。当前仅支持北京、泰国、北美地域请求。
        /// </summary>
        /// <param name="req"><see cref="AddTemplateMemberRequest"/></param>
        /// <returns><see cref="AddTemplateMemberResponse"/></returns>
        public async Task<AddTemplateMemberResponse> AddTemplateMember(AddTemplateMemberRequest req)
        {
             JsonResponseModel<AddTemplateMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddTemplateMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTemplateMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加模板对象中的IP地址、协议端口、IP地址组、协议端口组。当前仅支持北京、泰国、北美地域请求。
        /// </summary>
        /// <param name="req"><see cref="AddTemplateMemberRequest"/></param>
        /// <returns><see cref="AddTemplateMemberResponse"/></returns>
        public AddTemplateMemberResponse AddTemplateMemberSync(AddTemplateMemberRequest req)
        {
             JsonResponseModel<AddTemplateMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddTemplateMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTemplateMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AdjustPublicAddress) 用于更换IP地址，支持更换CVM实例的普通公网IP和包月带宽的EIP。
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public async Task<AdjustPublicAddressResponse> AdjustPublicAddress(AdjustPublicAddressRequest req)
        {
             JsonResponseModel<AdjustPublicAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AdjustPublicAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustPublicAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AdjustPublicAddress) 用于更换IP地址，支持更换CVM实例的普通公网IP和包月带宽的EIP。
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public AdjustPublicAddressResponse AdjustPublicAddressSync(AdjustPublicAddressRequest req)
        {
             JsonResponseModel<AdjustPublicAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AdjustPublicAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustPublicAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (AllocateAddresses) 用于申请一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * EIP 是专为动态云计算设计的静态 IP 地址。借助 EIP，您可以快速将 EIP 重新映射到您的另一个实例上，从而屏蔽实例故障。
        /// * 您的 EIP 与腾讯云账户相关联，而不是与某个实例相关联。在您选择显式释放该地址，或欠费超过24小时之前，它会一直与您的腾讯云账户保持关联。
        /// * 一个腾讯云账户在每个地域能申请的 EIP 最大配额有所限制，可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)，上述配额可通过 DescribeAddressQuota 接口获取。
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
        /// 本接口 (AllocateAddresses) 用于申请一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * EIP 是专为动态云计算设计的静态 IP 地址。借助 EIP，您可以快速将 EIP 重新映射到您的另一个实例上，从而屏蔽实例故障。
        /// * 您的 EIP 与腾讯云账户相关联，而不是与某个实例相关联。在您选择显式释放该地址，或欠费超过24小时之前，它会一直与您的腾讯云账户保持关联。
        /// * 一个腾讯云账户在每个地域能申请的 EIP 最大配额有所限制，可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)，上述配额可通过 DescribeAddressQuota 接口获取。
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
        /// 该接口用于给IPv6地址初次分配公网带宽
        /// </summary>
        /// <param name="req"><see cref="AllocateIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="AllocateIp6AddressesBandwidthResponse"/></returns>
        public async Task<AllocateIp6AddressesBandwidthResponse> AllocateIp6AddressesBandwidth(AllocateIp6AddressesBandwidthRequest req)
        {
             JsonResponseModel<AllocateIp6AddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateIp6AddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateIp6AddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于给IPv6地址初次分配公网带宽
        /// </summary>
        /// <param name="req"><see cref="AllocateIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="AllocateIp6AddressesBandwidthResponse"/></returns>
        public AllocateIp6AddressesBandwidthResponse AllocateIp6AddressesBandwidthSync(AllocateIp6AddressesBandwidthRequest req)
        {
             JsonResponseModel<AllocateIp6AddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateIp6AddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateIp6AddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 本接口（AssignIpv6CidrBlock）用于分配IPv6网段。
        /// * 使用本接口前，您需要已有VPC实例，如果没有可通过接口<a href="https://cloud.tencent.com/document/api/215/15774" title="CreateVpc" target="_blank">CreateVpc</a>创建。
        /// * 每个VPC只能申请一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public async Task<AssignIpv6CidrBlockResponse> AssignIpv6CidrBlock(AssignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AssignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssignIpv6SubnetCidrBlock）用于分配IPv6子网段。
        /// * 给子网分配 `IPv6` 网段，要求子网所属 `VPC` 已获得 `IPv6` 网段。如果尚未分配，请先通过接口 `AssignIpv6CidrBlock` 给子网所属 `VPC` 分配一个 `IPv6` 网段。否则无法分配 `IPv6` 子网段。
        /// * 每个子网只能分配一个IPv6网段。
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public async Task<AssignIpv6SubnetCidrBlockResponse> AssignIpv6SubnetCidrBlock(AssignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AssignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 本接口 (AssociateAddress) 用于将[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// * 将 EIP 绑定到实例（CVM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// * 将 EIP 绑定到主网卡的主内网IP上，绑定过程会把其上绑定的普通公网 IP 自动解绑并释放。
        /// * 将 EIP 绑定到指定网卡的内网 IP上（非主网卡的主内网IP），则必须先解绑该 EIP，才能再绑定新的。
        /// * 将EIP绑定到绑定内网型CLB实例的功能处于内测阶段，如需使用，请提交内测申请。
        /// * 将 EIP 绑定到NAT网关，请使用接口[AssociateNatGatewayAddress](https://cloud.tencent.com/document/product/215/36722)
        /// * EIP 如果欠费或被封堵，则不能被绑定。
        /// * 只有状态为 UNBIND 的 EIP 才能够被绑定。
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
        /// 本接口 (AssociateAddress) 用于将[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）绑定到实例或弹性网卡的指定内网 IP 上。
        /// * 将 EIP 绑定到实例（CVM）上，其本质是将 EIP 绑定到实例上主网卡的主内网 IP 上。
        /// * 将 EIP 绑定到主网卡的主内网IP上，绑定过程会把其上绑定的普通公网 IP 自动解绑并释放。
        /// * 将 EIP 绑定到指定网卡的内网 IP上（非主网卡的主内网IP），则必须先解绑该 EIP，才能再绑定新的。
        /// * 将EIP绑定到绑定内网型CLB实例的功能处于内测阶段，如需使用，请提交内测申请。
        /// * 将 EIP 绑定到NAT网关，请使用接口[AssociateNatGatewayAddress](https://cloud.tencent.com/document/product/215/36722)
        /// * EIP 如果欠费或被封堵，则不能被绑定。
        /// * 只有状态为 UNBIND 的 EIP 才能够被绑定。
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
        /// 本接口（AssociateDhcpIpWithAddressIp）用于DhcpIp绑定弹性公网IP（EIP）。<br />
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="AssociateDhcpIpWithAddressIpRequest"/></param>
        /// <returns><see cref="AssociateDhcpIpWithAddressIpResponse"/></returns>
        public async Task<AssociateDhcpIpWithAddressIpResponse> AssociateDhcpIpWithAddressIp(AssociateDhcpIpWithAddressIpRequest req)
        {
             JsonResponseModel<AssociateDhcpIpWithAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDhcpIpWithAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDhcpIpWithAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AssociateDhcpIpWithAddressIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDhcpIpWithAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDhcpIpWithAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将专线网关与NAT网关绑定，专线网关默认路由指向NAT网关
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public async Task<AssociateDirectConnectGatewayNatGatewayResponse> AssociateDirectConnectGatewayNatGateway(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将专线网关与NAT网关绑定，专线网关默认路由指向NAT网关
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public AssociateDirectConnectGatewayNatGatewayResponse AssociateDirectConnectGatewayNatGatewaySync(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AssociateNatGatewayAddress)用于NAT网关绑定弹性IP（EIP）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public async Task<AssociateNatGatewayAddressResponse> AssociateNatGatewayAddress(AssociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<AssociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AssociateNatGatewayAddress)用于NAT网关绑定弹性IP（EIP）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public AssociateNatGatewayAddressResponse AssociateNatGatewayAddressSync(AssociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<AssociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssociateNetworkAclSubnets）用于网络ACL关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public async Task<AssociateNetworkAclSubnetsResponse> AssociateNetworkAclSubnets(AssociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<AssociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssociateNetworkAclSubnets）用于网络ACL关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public AssociateNetworkAclSubnetsResponse AssociateNetworkAclSubnetsSync(AssociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<AssociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssociateNetworkInterfaceSecurityGroups）用于弹性网卡绑定安全组（SecurityGroup）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public async Task<AssociateNetworkInterfaceSecurityGroupsResponse> AssociateNetworkInterfaceSecurityGroups(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssociateNetworkInterfaceSecurityGroups）用于弹性网卡绑定安全组（SecurityGroup）。
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public AssociateNetworkInterfaceSecurityGroupsResponse AssociateNetworkInterfaceSecurityGroupsSync(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachCcnInstances）用于将网络实例加载到云联网实例中，网络实例包括VPC和专线网关。<br />
        /// 每个云联网能够关联的网络实例个数是有限的，详请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public async Task<AttachCcnInstancesResponse> AttachCcnInstances(AttachCcnInstancesRequest req)
        {
             JsonResponseModel<AttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachCcnInstances）用于将网络实例加载到云联网实例中，网络实例包括VPC和专线网关。<br />
        /// 每个云联网能够关联的网络实例个数是有限的，详请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public AttachCcnInstancesResponse AttachCcnInstancesSync(AttachCcnInstancesRequest req)
        {
             JsonResponseModel<AttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpc(AttachClassicLinkVpcRequest req)
        {
             JsonResponseModel<AttachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AttachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 本接口（AttachSnapshotInstances）用于快照策略关联实例。
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public async Task<AttachSnapshotInstancesResponse> AttachSnapshotInstances(AttachSnapshotInstancesRequest req)
        {
             JsonResponseModel<AttachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachSnapshotInstances）用于快照策略关联实例。
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public AttachSnapshotInstancesResponse AttachSnapshotInstancesSync(AttachSnapshotInstancesRequest req)
        {
             JsonResponseModel<AttachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AuditCrossBorderCompliance）用于服务商操作合规化资质审批。
        /// * 服务商只能操作提交到本服务商的审批单，后台会校验身份。即只授权给服务商的`APPID` 调用本接口。
        /// * `APPROVED` 状态的审批单，可以再次操作为 `DENY`；`DENY` 状态的审批单，也可以再次操作为 `APPROVED`。
        /// </summary>
        /// <param name="req"><see cref="AuditCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="AuditCrossBorderComplianceResponse"/></returns>
        public async Task<AuditCrossBorderComplianceResponse> AuditCrossBorderCompliance(AuditCrossBorderComplianceRequest req)
        {
             JsonResponseModel<AuditCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AuditCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuditCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AuditCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AuditCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuditCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckAssistantCidr）用于检查辅助CIDR是否与存量路由、对等连接（对端VPC的CIDR）等资源存在冲突。如果存在重叠，则返回重叠的资源。
        /// * 检测辅助CIDR是否与当前VPC的主CIDR和辅助CIDR存在重叠。
        /// * 检测辅助CIDR是否与当前VPC的路由的目的端存在重叠。
        /// * 检测辅助CIDR是否与当前VPC的对等连接，对端VPC下的主CIDR或辅助CIDR存在重叠。
        /// </summary>
        /// <param name="req"><see cref="CheckAssistantCidrRequest"/></param>
        /// <returns><see cref="CheckAssistantCidrResponse"/></returns>
        public async Task<CheckAssistantCidrResponse> CheckAssistantCidr(CheckAssistantCidrRequest req)
        {
             JsonResponseModel<CheckAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CheckAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDefaultSubnet）用于预判是否可建默认子网。
        /// </summary>
        /// <param name="req"><see cref="CheckDefaultSubnetRequest"/></param>
        /// <returns><see cref="CheckDefaultSubnetResponse"/></returns>
        public async Task<CheckDefaultSubnetResponse> CheckDefaultSubnet(CheckDefaultSubnetRequest req)
        {
             JsonResponseModel<CheckDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDefaultSubnet）用于预判是否可建默认子网。
        /// </summary>
        /// <param name="req"><see cref="CheckDefaultSubnetRequest"/></param>
        /// <returns><see cref="CheckDefaultSubnetResponse"/></returns>
        public CheckDefaultSubnetResponse CheckDefaultSubnetSync(CheckDefaultSubnetRequest req)
        {
             JsonResponseModel<CheckDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckNetDetectState）用于验证网络探测。
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public async Task<CheckNetDetectStateResponse> CheckNetDetectState(CheckNetDetectStateRequest req)
        {
             JsonResponseModel<CheckNetDetectStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckNetDetectState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNetDetectStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckNetDetectState）用于验证网络探测。
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public CheckNetDetectStateResponse CheckNetDetectStateSync(CheckNetDetectStateRequest req)
        {
             JsonResponseModel<CheckNetDetectStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckNetDetectState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNetDetectStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloneSecurityGroup）用于根据存量的安全组，克隆创建出同样规则配置的安全组。仅克隆安全组及其规则信息，不会克隆安全组标签信息。
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public async Task<CloneSecurityGroupResponse> CloneSecurityGroup(CloneSecurityGroupRequest req)
        {
             JsonResponseModel<CloneSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloneSecurityGroup）用于根据存量的安全组，克隆创建出同样规则配置的安全组。仅克隆安全组及其规则信息，不会克隆安全组标签信息。
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public CloneSecurityGroupResponse CloneSecurityGroupSync(CloneSecurityGroupRequest req)
        {
             JsonResponseModel<CloneSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAddressTemplate）用于创建IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public async Task<CreateAddressTemplateResponse> CreateAddressTemplate(CreateAddressTemplateRequest req)
        {
             JsonResponseModel<CreateAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAddressTemplate）用于创建IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public CreateAddressTemplateResponse CreateAddressTemplateSync(CreateAddressTemplateRequest req)
        {
             JsonResponseModel<CreateAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAddressTemplateGroup）用于创建IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public async Task<CreateAddressTemplateGroupResponse> CreateAddressTemplateGroup(CreateAddressTemplateGroupRequest req)
        {
             JsonResponseModel<CreateAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAddressTemplateGroup）用于创建IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public CreateAddressTemplateGroupResponse CreateAddressTemplateGroupSync(CreateAddressTemplateGroupRequest req)
        {
             JsonResponseModel<CreateAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateAndAttachNetworkInterfaceResponse> CreateAndAttachNetworkInterface(CreateAndAttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateAndAttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAndAttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAndAttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateAndAttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAndAttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAndAttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAssistantCidr）用于批量创建辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public async Task<CreateAssistantCidrResponse> CreateAssistantCidr(CreateAssistantCidrRequest req)
        {
             JsonResponseModel<CreateAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAssistantCidr）用于批量创建辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public CreateAssistantCidrResponse CreateAssistantCidrSync(CreateAssistantCidrRequest req)
        {
             JsonResponseModel<CreateAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateBandwidthPackage) 支持创建[设备带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)和[IP带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)。
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public async Task<CreateBandwidthPackageResponse> CreateBandwidthPackage(CreateBandwidthPackageRequest req)
        {
             JsonResponseModel<CreateBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateBandwidthPackage) 支持创建[设备带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)和[IP带宽包](https://cloud.tencent.com/document/product/684/15245#bwptype)。
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public CreateBandwidthPackageResponse CreateBandwidthPackageSync(CreateBandwidthPackageRequest req)
        {
             JsonResponseModel<CreateBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCcn）用于创建云联网（CCN）。<br />
        /// * 创建云联网同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// * 每个账号能创建的云联网实例个数是有限的，详请参考产品文档。如果需要扩充请联系在线客服。
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRequest"/></param>
        /// <returns><see cref="CreateCcnResponse"/></returns>
        public async Task<CreateCcnResponse> CreateCcn(CreateCcnRequest req)
        {
             JsonResponseModel<CreateCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcnResponse>>(strResp);
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
        /// 本接口（CreateCustomerGateway）用于创建对端网关。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
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
        /// 本接口（CreateDefaultSecurityGroup）用于创建（如果项目下未存在默认安全组，则创建；已存在则获取。）默认安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 默认安全组会放通所有IPv4规则，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// * 创建安全组同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateDefaultSecurityGroupResponse"/></returns>
        public async Task<CreateDefaultSecurityGroupResponse> CreateDefaultSecurityGroup(CreateDefaultSecurityGroupRequest req)
        {
             JsonResponseModel<CreateDefaultSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateDefaultSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefaultSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateDefaultVpcResponse> CreateDefaultVpc(CreateDefaultVpcRequest req)
        {
             JsonResponseModel<CreateDefaultVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateDefaultVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefaultVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDhcpIp）用于创建DhcpIp。
        /// </summary>
        /// <param name="req"><see cref="CreateDhcpIpRequest"/></param>
        /// <returns><see cref="CreateDhcpIpResponse"/></returns>
        public async Task<CreateDhcpIpResponse> CreateDhcpIp(CreateDhcpIpRequest req)
        {
             JsonResponseModel<CreateDhcpIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDhcpIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDhcpIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDhcpIp）用于创建DhcpIp。
        /// </summary>
        /// <param name="req"><see cref="CreateDhcpIpRequest"/></param>
        /// <returns><see cref="CreateDhcpIpResponse"/></returns>
        public CreateDhcpIpResponse CreateDhcpIpSync(CreateDhcpIpRequest req)
        {
             JsonResponseModel<CreateDhcpIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDhcpIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDhcpIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGateway）用于创建专线网关。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public async Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGateway(CreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGateway）用于创建专线网关。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public CreateDirectConnectGatewayResponse CreateDirectConnectGatewaySync(CreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGatewayCcnRoutes）用于创建专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<CreateDirectConnectGatewayCcnRoutesResponse> CreateDirectConnectGatewayCcnRoutes(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDirectConnectGatewayCcnRoutes）用于创建专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public CreateDirectConnectGatewayCcnRoutesResponse CreateDirectConnectGatewayCcnRoutesSync(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateFlowLog）用于创建网络流日志。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public async Task<CreateFlowLogResponse> CreateFlowLog(CreateFlowLogRequest req)
        {
             JsonResponseModel<CreateFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateFlowLog）用于创建网络流日志。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public CreateFlowLogResponse CreateFlowLogSync(CreateFlowLogRequest req)
        {
             JsonResponseModel<CreateFlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）。
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
        /// 本接口（CreateHaVip）用于创建高可用虚拟IP（HAVIP）。
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
        /// 1. 该接口用于创建IPV6转换IPV4实例，支持批量
        /// 2. 同一个账户在一个地域最多允许创建10个转换实例
        /// </summary>
        /// <param name="req"><see cref="CreateIp6TranslatorsRequest"/></param>
        /// <returns><see cref="CreateIp6TranslatorsResponse"/></returns>
        public async Task<CreateIp6TranslatorsResponse> CreateIp6Translators(CreateIp6TranslatorsRequest req)
        {
             JsonResponseModel<CreateIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于创建IPV6转换IPV4实例，支持批量
        /// 2. 同一个账户在一个地域最多允许创建10个转换实例
        /// </summary>
        /// <param name="req"><see cref="CreateIp6TranslatorsRequest"/></param>
        /// <returns><see cref="CreateIp6TranslatorsResponse"/></returns>
        public CreateIp6TranslatorsResponse CreateIp6TranslatorsSync(CreateIp6TranslatorsRequest req)
        {
             JsonResponseModel<CreateIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateLocalGateway）用于创建用于CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public async Task<CreateLocalGatewayResponse> CreateLocalGateway(CreateLocalGatewayRequest req)
        {
             JsonResponseModel<CreateLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateLocalGateway）用于创建用于CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public CreateLocalGatewayResponse CreateLocalGatewaySync(CreateLocalGatewayRequest req)
        {
             JsonResponseModel<CreateLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateNatGateway)用于创建NAT网关。
        /// 在对新建的NAT网关做其他操作前，需先确认此网关已被创建完成（DescribeNatGateway接口返回的实例State字段为AVAILABLE）。
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
        /// 本接口(CreateNatGateway)用于创建NAT网关。
        /// 在对新建的NAT网关做其他操作前，需先确认此网关已被创建完成（DescribeNatGateway接口返回的实例State字段为AVAILABLE）。
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
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
        /// 本接口(CreateNatGatewayDestinationIpPortTranslationNatRule)用于创建NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public async Task<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> CreateNatGatewayDestinationIpPortTranslationNatRule(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateNatGatewayDestinationIpPortTranslationNatRule)用于创建NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public CreateNatGatewayDestinationIpPortTranslationNatRuleResponse CreateNatGatewayDestinationIpPortTranslationNatRuleSync(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateNatGatewaySourceIpTranslationNatRule)用于创建NAT网关SNAT规则
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public async Task<CreateNatGatewaySourceIpTranslationNatRuleResponse> CreateNatGatewaySourceIpTranslationNatRule(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateNatGatewaySourceIpTranslationNatRule)用于创建NAT网关SNAT规则
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public CreateNatGatewaySourceIpTranslationNatRuleResponse CreateNatGatewaySourceIpTranslationNatRuleSync(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNetDetect）用于创建网络探测。
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public async Task<CreateNetDetectResponse> CreateNetDetect(CreateNetDetectRequest req)
        {
             JsonResponseModel<CreateNetDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNetDetect）用于创建网络探测。
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public CreateNetDetectResponse CreateNetDetectSync(CreateNetDetectRequest req)
        {
             JsonResponseModel<CreateNetDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNetworkAcl）用于创建新的<a href="https://cloud.tencent.com/document/product/215/20088">网络ACL</a>。
        /// * 新建的网络ACL的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用ModifyNetworkAclEntries将网络ACL的规则设置为需要的规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public async Task<CreateNetworkAclResponse> CreateNetworkAcl(CreateNetworkAclRequest req)
        {
             JsonResponseModel<CreateNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNetworkAcl）用于创建新的<a href="https://cloud.tencent.com/document/product/215/20088">网络ACL</a>。
        /// * 新建的网络ACL的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用ModifyNetworkAclEntries将网络ACL的规则设置为需要的规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public CreateNetworkAclResponse CreateNetworkAclSync(CreateNetworkAclRequest req)
        {
             JsonResponseModel<CreateNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNetworkAclQuintupleEntries）用于增量网络ACL五元组的入站规则和出站规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<CreateNetworkAclQuintupleEntriesResponse> CreateNetworkAclQuintupleEntries(CreateNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNetworkAclQuintupleEntries）用于增量网络ACL五元组的入站规则和出站规则。
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public CreateNetworkAclQuintupleEntriesResponse CreateNetworkAclQuintupleEntriesSync(CreateNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 本接口(CreateRouteTable)用于创建路由表。
        /// * 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// * 创建路由表同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
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
        /// 本接口(CreateRouteTable)用于创建路由表。
        /// * 创建了VPC后，系统会创建一个默认路由表，所有新建的子网都会关联到默认路由表。默认情况下您可以直接使用默认路由表来管理您的路由策略。当您的路由策略较多时，您可以调用创建路由表接口创建更多路由表管理您的路由策略。
        /// * 创建路由表同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
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
        /// 本接口(CreateRoutes)用于创建路由策略。
        /// * 向指定路由表批量新增路由策略。
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
        /// 本接口(CreateRoutes)用于创建路由策略。
        /// * 向指定路由表批量新增路由策略。
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
        /// 本接口（CreateSecurityGroup）用于创建新的安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// * 创建安全组同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
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
        /// 本接口（CreateSecurityGroup）用于创建新的安全组（SecurityGroup）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// * 创建安全组同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
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
        /// <li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受，即 Protocol 字段不是 TCP 或 UDP 时，Protocol 和 Port 排他关系，不允许同时输入，否则会接口报错。</li>
        /// <li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// <li>CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate 四者是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。IPv6CidrBlock和ICMP是排他关系，如需使用，请输入ICMPV6。</li>
        /// <li>一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。如想在规则最前面插入一条，则填0即可，如果想在最后追加，该字段可不填。</li>
        /// </ul></li></ul>
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
        /// <li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受，即 Protocol 字段不是 TCP 或 UDP 时，Protocol 和 Port 排他关系，不允许同时输入，否则会接口报错。</li>
        /// <li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// <li>CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate 四者是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。IPv6CidrBlock和ICMP是排他关系，如需使用，请输入ICMPV6。</li>
        /// <li>一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。如想在规则最前面插入一条，则填0即可，如果想在最后追加，该字段可不填。</li>
        /// </ul></li></ul>
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
        /// 本接口（CreateSecurityGroupWithPolicies）用于创建新的安全组（SecurityGroup），并且可以同时添加安全组规则（SecurityGroupPolicy）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// 
        /// 安全组规则说明：
        /// * Version安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。
        /// * Protocol字段支持输入TCP, UDP, ICMP, ICMPV6, GRE, ALL。
        /// * CidrBlock字段允许输入符合cidr格式标准的任意字符串。(展开)在基础网络中，如果CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * Ipv6CidrBlock字段允许输入符合IPv6 cidr格式标准的任意字符串。(展开)在基础网络中，如果Ipv6CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * SecurityGroupId字段允许输入与待修改的安全组位于相同项目中的安全组ID，包括这个安全组ID本身，代表安全组下所有云服务器的内网IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。
        /// * Port字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当Protocol字段是TCP或UDP时，Port字段才被接受，即Protocol字段不是TCP或UDP时，Protocol和Port排他关系，不允许同时输入，否则会接口报错。
        /// * Action字段只允许输入ACCEPT或DROP。
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate四者是排他关系，不允许同时输入，Protocol + Port和ServiceTemplate二者是排他关系，不允许同时输入。
        /// * 一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public async Task<CreateSecurityGroupWithPoliciesResponse> CreateSecurityGroupWithPolicies(CreateSecurityGroupWithPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupWithPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupWithPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupWithPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSecurityGroupWithPolicies）用于创建新的安全组（SecurityGroup），并且可以同时添加安全组规则（SecurityGroupPolicy）。
        /// * 每个账户下每个地域的每个项目的<a href="https://cloud.tencent.com/document/product/213/12453">安全组数量限制</a>。
        /// * 新建的安全组的入站和出站规则默认都是全部拒绝，在创建后通常您需要再调用CreateSecurityGroupPolicies将安全组的规则设置为需要的规则。
        /// 
        /// 安全组规则说明：
        /// * Version安全组规则版本号，用户每次更新安全规则版本会自动加1，防止您更新的路由规则已过期，不填不考虑冲突。
        /// * Protocol字段支持输入TCP, UDP, ICMP, ICMPV6, GRE, ALL。
        /// * CidrBlock字段允许输入符合cidr格式标准的任意字符串。(展开)在基础网络中，如果CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * Ipv6CidrBlock字段允许输入符合IPv6 cidr格式标准的任意字符串。(展开)在基础网络中，如果Ipv6CidrBlock包含您的账户内的云服务器之外的设备在腾讯云的内网IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。
        /// * SecurityGroupId字段允许输入与待修改的安全组位于相同项目中的安全组ID，包括这个安全组ID本身，代表安全组下所有云服务器的内网IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。
        /// * Port字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当Protocol字段是TCP或UDP时，Port字段才被接受，即Protocol字段不是TCP或UDP时，Protocol和Port排他关系，不允许同时输入，否则会接口报错。
        /// * Action字段只允许输入ACCEPT或DROP。
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate四者是排他关系，不允许同时输入，Protocol + Port和ServiceTemplate二者是排他关系，不允许同时输入。
        /// * 一次请求中只能创建单个方向的规则, 如果需要指定索引（PolicyIndex）参数, 多条规则的索引必须一致。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public CreateSecurityGroupWithPoliciesResponse CreateSecurityGroupWithPoliciesSync(CreateSecurityGroupWithPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupWithPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroupWithPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupWithPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateServiceTemplate）用于创建协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public async Task<CreateServiceTemplateResponse> CreateServiceTemplate(CreateServiceTemplateRequest req)
        {
             JsonResponseModel<CreateServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateServiceTemplate）用于创建协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public CreateServiceTemplateResponse CreateServiceTemplateSync(CreateServiceTemplateRequest req)
        {
             JsonResponseModel<CreateServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateServiceTemplateGroup）用于创建协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public async Task<CreateServiceTemplateGroupResponse> CreateServiceTemplateGroup(CreateServiceTemplateGroupRequest req)
        {
             JsonResponseModel<CreateServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateServiceTemplateGroup）用于创建协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public CreateServiceTemplateGroupResponse CreateServiceTemplateGroupSync(CreateServiceTemplateGroupRequest req)
        {
             JsonResponseModel<CreateServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSnapshotPolicies）用于创建快照策略。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public async Task<CreateSnapshotPoliciesResponse> CreateSnapshotPolicies(CreateSnapshotPoliciesRequest req)
        {
             JsonResponseModel<CreateSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSnapshotPolicies）用于创建快照策略。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public CreateSnapshotPoliciesResponse CreateSnapshotPoliciesSync(CreateSnapshotPoliciesRequest req)
        {
             JsonResponseModel<CreateSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateSubnetsResponse> CreateSubnets(CreateSubnetsRequest req)
        {
             JsonResponseModel<CreateSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateTrafficPackages) 用于创建共享流量包。
        /// </summary>
        /// <param name="req"><see cref="CreateTrafficPackagesRequest"/></param>
        /// <returns><see cref="CreateTrafficPackagesResponse"/></returns>
        public async Task<CreateTrafficPackagesResponse> CreateTrafficPackages(CreateTrafficPackagesRequest req)
        {
             JsonResponseModel<CreateTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateTrafficPackages) 用于创建共享流量包。
        /// </summary>
        /// <param name="req"><see cref="CreateTrafficPackagesRequest"/></param>
        /// <returns><see cref="CreateTrafficPackagesResponse"/></returns>
        public CreateTrafficPackagesResponse CreateTrafficPackagesSync(CreateTrafficPackagesRequest req)
        {
             JsonResponseModel<CreateTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpc）用于创建私有网络（VPC）。
        /// * 用户可以创建的最小网段子网掩码为28（有16个IP地址），10.0.0.0/12，172.16.0.0/12最大网段子网掩码为12（1,048,576个IP地址），192.168.0.0/16最大网段子网掩码为16（65,536个IP地址）如果需要规划VPC网段请参见[网络规划](https://cloud.tencent.com/document/product/215/30313)。
        /// * 同一个地域能创建的VPC资源个数也是有限制的，详见 <a href="https://cloud.tencent.com/doc/product/215/537" title="VPC使用限制">VPC使用限制</a>，如果需要申请更多资源，请提交[工单申请](https://console.cloud.tencent.com/workorder/category)。
        /// * 创建VPC同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
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
        /// 本接口（CreateVpc）用于创建私有网络（VPC）。
        /// * 用户可以创建的最小网段子网掩码为28（有16个IP地址），10.0.0.0/12，172.16.0.0/12最大网段子网掩码为12（1,048,576个IP地址），192.168.0.0/16最大网段子网掩码为16（65,536个IP地址）如果需要规划VPC网段请参见[网络规划](https://cloud.tencent.com/document/product/215/30313)。
        /// * 同一个地域能创建的VPC资源个数也是有限制的，详见 <a href="https://cloud.tencent.com/doc/product/215/537" title="VPC使用限制">VPC使用限制</a>，如果需要申请更多资源，请提交[工单申请](https://console.cloud.tencent.com/workorder/category)。
        /// * 创建VPC同时可以绑定标签, 应答里的标签列表代表添加成功的标签。
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
        /// 本接口（CreateVpcEndPoint）用于创建终端节点。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public async Task<CreateVpcEndPointResponse> CreateVpcEndPoint(CreateVpcEndPointRequest req)
        {
             JsonResponseModel<CreateVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpcEndPoint）用于创建终端节点。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public CreateVpcEndPointResponse CreateVpcEndPointSync(CreateVpcEndPointRequest req)
        {
             JsonResponseModel<CreateVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointService）用于创建终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public async Task<CreateVpcEndPointServiceResponse> CreateVpcEndPointService(CreateVpcEndPointServiceRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointService）用于创建终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public CreateVpcEndPointServiceResponse CreateVpcEndPointServiceSync(CreateVpcEndPointServiceRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointServiceWhiteList）创建终端服务白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<CreateVpcEndPointServiceWhiteListResponse> CreateVpcEndPointServiceWhiteList(CreateVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpcEndPointServiceWhiteList）创建终端服务白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public CreateVpcEndPointServiceWhiteListResponse CreateVpcEndPointServiceWhiteListSync(CreateVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpnConnection）用于创建VPN通道。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateVpnConnectionRequest"/></param>
        /// <returns><see cref="CreateVpnConnectionResponse"/></returns>
        public async Task<CreateVpnConnectionResponse> CreateVpnConnection(CreateVpnConnectionRequest req)
        {
             JsonResponseModel<CreateVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpnGateway）用于创建VPN网关。
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public async Task<CreateVpnGatewayResponse> CreateVpnGateway(CreateVpnGatewayRequest req)
        {
             JsonResponseModel<CreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateVpnGateway）用于创建VPN网关。
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public CreateVpnGatewayResponse CreateVpnGatewaySync(CreateVpnGatewayRequest req)
        {
             JsonResponseModel<CreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建路由型VPN网关的目的路由
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public async Task<CreateVpnGatewayRoutesResponse> CreateVpnGatewayRoutes(CreateVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<CreateVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建路由型VPN网关的目的路由
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public CreateVpnGatewayRoutesResponse CreateVpnGatewayRoutesSync(CreateVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<CreateVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建SSL-VPN-CLIENT
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslClientResponse"/></returns>
        public async Task<CreateVpnGatewaySslClientResponse> CreateVpnGatewaySslClient(CreateVpnGatewaySslClientRequest req)
        {
             JsonResponseModel<CreateVpnGatewaySslClientResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnGatewaySslClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewaySslClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建SSL-VPN-CLIENT
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslClientResponse"/></returns>
        public CreateVpnGatewaySslClientResponse CreateVpnGatewaySslClientSync(CreateVpnGatewaySslClientRequest req)
        {
             JsonResponseModel<CreateVpnGatewaySslClientResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnGatewaySslClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewaySslClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 Server端
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslServerResponse"/></returns>
        public async Task<CreateVpnGatewaySslServerResponse> CreateVpnGatewaySslServer(CreateVpnGatewaySslServerRequest req)
        {
             JsonResponseModel<CreateVpnGatewaySslServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnGatewaySslServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewaySslServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 Server端
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="CreateVpnGatewaySslServerResponse"/></returns>
        public CreateVpnGatewaySslServerResponse CreateVpnGatewaySslServerSync(CreateVpnGatewaySslServerRequest req)
        {
             JsonResponseModel<CreateVpnGatewaySslServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnGatewaySslServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewaySslServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplate）用于删除IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public async Task<DeleteAddressTemplateResponse> DeleteAddressTemplate(DeleteAddressTemplateRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplate）用于删除IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public DeleteAddressTemplateResponse DeleteAddressTemplateSync(DeleteAddressTemplateRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplateGroup）用于删除IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public async Task<DeleteAddressTemplateGroupResponse> DeleteAddressTemplateGroup(DeleteAddressTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAddressTemplateGroup）用于删除IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public DeleteAddressTemplateGroupResponse DeleteAddressTemplateGroupSync(DeleteAddressTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAssistantCidr）用于删除辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public async Task<DeleteAssistantCidrResponse> DeleteAssistantCidr(DeleteAssistantCidrRequest req)
        {
             JsonResponseModel<DeleteAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAssistantCidr）用于删除辅助CIDR。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public DeleteAssistantCidrResponse DeleteAssistantCidrSync(DeleteAssistantCidrRequest req)
        {
             JsonResponseModel<DeleteAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口支持删除共享带宽包，包括[设备带宽包](https://cloud.tencent.com/document/product/684/15246#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85)和[IP带宽包](https://cloud.tencent.com/document/product/684/15246#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85)
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackage(DeleteBandwidthPackageRequest req)
        {
             JsonResponseModel<DeleteBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口支持删除共享带宽包，包括[设备带宽包](https://cloud.tencent.com/document/product/684/15246#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85)和[IP带宽包](https://cloud.tencent.com/document/product/684/15246#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85)
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public DeleteBandwidthPackageResponse DeleteBandwidthPackageSync(DeleteBandwidthPackageRequest req)
        {
             JsonResponseModel<DeleteBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCcn）用于删除云联网。
        /// * 删除后，云联网关联的所有实例间路由将被删除，网络将会中断，请务必确认
        /// * 删除云联网是不可逆的操作，请谨慎处理。
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRequest"/></param>
        /// <returns><see cref="DeleteCcnResponse"/></returns>
        public async Task<DeleteCcnResponse> DeleteCcn(DeleteCcnRequest req)
        {
             JsonResponseModel<DeleteCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcnResponse>>(strResp);
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
        /// 本接口（DeleteCustomerGateway）用于删除对端网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
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
        /// 本接口（DeleteDhcpIp）用于删除DhcpIp。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DeleteDhcpIpRequest"/></param>
        /// <returns><see cref="DeleteDhcpIpResponse"/></returns>
        public async Task<DeleteDhcpIpResponse> DeleteDhcpIp(DeleteDhcpIpRequest req)
        {
             JsonResponseModel<DeleteDhcpIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDhcpIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDhcpIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteDhcpIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDhcpIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDhcpIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGateway）用于删除专线网关。
        /// <li>如果是 NAT 网关，删除专线网关后，NAT 规则以及 ACL 策略都被清理了。</li>
        /// <li>删除专线网关后，系统会删除路由表中跟该专线网关相关的路由策略。</li>
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`QueryTask`接口
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayResponse"/></returns>
        public async Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGatewayCcnRoutes）用于删除专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<DeleteDirectConnectGatewayCcnRoutesResponse> DeleteDirectConnectGatewayCcnRoutes(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDirectConnectGatewayCcnRoutes）用于删除专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DeleteDirectConnectGatewayCcnRoutesResponse DeleteDirectConnectGatewayCcnRoutesSync(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteFlowLog）用于删除流日志
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public async Task<DeleteFlowLogResponse> DeleteFlowLog(DeleteFlowLogRequest req)
        {
             JsonResponseModel<DeleteFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteFlowLog）用于删除流日志
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public DeleteFlowLogResponse DeleteFlowLogSync(DeleteFlowLogRequest req)
        {
             JsonResponseModel<DeleteFlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteHaVip）用于删除高可用虚拟IP（HAVIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        /// 本接口（DeleteHaVip）用于删除高可用虚拟IP（HAVIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        /// 1. 该接口用于释放IPV6转换实例，支持批量。
        /// 2.  如果IPV6转换实例建立有转换规则，会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DeleteIp6TranslatorsResponse"/></returns>
        public async Task<DeleteIp6TranslatorsResponse> DeleteIp6Translators(DeleteIp6TranslatorsRequest req)
        {
             JsonResponseModel<DeleteIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于释放IPV6转换实例，支持批量。
        /// 2.  如果IPV6转换实例建立有转换规则，会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DeleteIp6TranslatorsResponse"/></returns>
        public DeleteIp6TranslatorsResponse DeleteIp6TranslatorsSync(DeleteIp6TranslatorsRequest req)
        {
             JsonResponseModel<DeleteIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteLocalGateway）用于删除CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public async Task<DeleteLocalGatewayResponse> DeleteLocalGateway(DeleteLocalGatewayRequest req)
        {
             JsonResponseModel<DeleteLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteLocalGateway）用于删除CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public DeleteLocalGatewayResponse DeleteLocalGatewaySync(DeleteLocalGatewayRequest req)
        {
             JsonResponseModel<DeleteLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNatGateway）用于删除NAT网关。
        /// 删除 NAT 网关后，系统会自动删除路由表中包含此 NAT 网关的路由项，同时也会解绑弹性公网IP（EIP）。
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
        /// 本接口（DeleteNatGateway）用于删除NAT网关。
        /// 删除 NAT 网关后，系统会自动删除路由表中包含此 NAT 网关的路由项，同时也会解绑弹性公网IP（EIP）。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
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
        /// 本接口（DeleteNatGatewayDestinationIpPortTranslationNatRule）用于删除NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public async Task<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> DeleteNatGatewayDestinationIpPortTranslationNatRule(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNatGatewayDestinationIpPortTranslationNatRule）用于删除NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse DeleteNatGatewayDestinationIpPortTranslationNatRuleSync(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNatGatewaySourceIpTranslationNatRule）用于删除NAT网关端口SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public async Task<DeleteNatGatewaySourceIpTranslationNatRuleResponse> DeleteNatGatewaySourceIpTranslationNatRule(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNatGatewaySourceIpTranslationNatRule）用于删除NAT网关端口SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewaySourceIpTranslationNatRuleResponse DeleteNatGatewaySourceIpTranslationNatRuleSync(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNetDetect）用于删除网络探测实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public async Task<DeleteNetDetectResponse> DeleteNetDetect(DeleteNetDetectRequest req)
        {
             JsonResponseModel<DeleteNetDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNetDetect）用于删除网络探测实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public DeleteNetDetectResponse DeleteNetDetectSync(DeleteNetDetectRequest req)
        {
             JsonResponseModel<DeleteNetDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNetworkAcl）用于删除网络ACL。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public async Task<DeleteNetworkAclResponse> DeleteNetworkAcl(DeleteNetworkAclRequest req)
        {
             JsonResponseModel<DeleteNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNetworkAcl）用于删除网络ACL。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public DeleteNetworkAclResponse DeleteNetworkAclSync(DeleteNetworkAclRequest req)
        {
             JsonResponseModel<DeleteNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNetworkAclQuintupleEntries）用于删除网络ACL五元组指定的入站规则和出站规则（但不是全量删除该ACL下的所有条目）。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<DeleteNetworkAclQuintupleEntriesResponse> DeleteNetworkAclQuintupleEntries(DeleteNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNetworkAclQuintupleEntries）用于删除网络ACL五元组指定的入站规则和出站规则（但不是全量删除该ACL下的所有条目）。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public DeleteNetworkAclQuintupleEntriesResponse DeleteNetworkAclQuintupleEntriesSync(DeleteNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 本接口（DeleteRouteTable）用于删除路由表。
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
        /// 本接口（DeleteRouteTable）用于删除路由表。
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
        /// 本接口(DeleteRoutes)用于对某个路由表批量删除路由策略（Route）。
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
        /// 本接口(DeleteRoutes)用于对某个路由表批量删除路由策略（Route）。
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
        /// 本接口（DeleteSecurityGroup）用于删除安全组（SecurityGroup）。
        /// * 只有当前账号下的安全组允许被删除。
        /// * 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// * 删除的安全组无法再找回，请谨慎调用。
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
        /// 本接口（DeleteSecurityGroup）用于删除安全组（SecurityGroup）。
        /// * 只有当前账号下的安全组允许被删除。
        /// * 安全组实例ID如果在其他安全组的规则中被引用，则无法直接删除。这种情况下，需要先进行规则修改，再删除安全组。
        /// * 删除的安全组无法再找回，请谨慎调用。
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
        /// 本接口（DeleteSecurityGroupPolicies）用于用于删除安全组规则（SecurityGroupPolicy）。
        /// * SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
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
        /// 本接口（DeleteSecurityGroupPolicies）用于用于删除安全组规则（SecurityGroupPolicy）。
        /// * SecurityGroupPolicySet.Version 用于指定要操作的安全组的版本。传入 Version 版本号若不等于当前安全组的最新版本，将返回失败；若不传 Version 则直接删除指定PolicyIndex的规则。
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
        /// 本接口（DeleteServiceTemplate）用于删除协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public async Task<DeleteServiceTemplateResponse> DeleteServiceTemplate(DeleteServiceTemplateRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplate）用于删除协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public DeleteServiceTemplateResponse DeleteServiceTemplateSync(DeleteServiceTemplateRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplateGroup）用于删除协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public async Task<DeleteServiceTemplateGroupResponse> DeleteServiceTemplateGroup(DeleteServiceTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteServiceTemplateGroup）用于删除协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public DeleteServiceTemplateGroupResponse DeleteServiceTemplateGroupSync(DeleteServiceTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSnapshotPolicies）用于删除快照策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public async Task<DeleteSnapshotPoliciesResponse> DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DeleteSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSnapshotPolicies）用于删除快照策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public DeleteSnapshotPoliciesResponse DeleteSnapshotPoliciesSync(DeleteSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DeleteSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteSubnet）用于用于删除子网（Subnet）。
        /// * 删除子网前，请清理该子网下所有资源，包括云服务器、负载均衡、云数据、NoSQL、弹性网卡等资源。
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
        /// 本接口（DeleteSubnet）用于用于删除子网（Subnet）。
        /// * 删除子网前，请清理该子网下所有资源，包括云服务器、负载均衡、云数据、NoSQL、弹性网卡等资源。
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
        /// 删除模板对象中的IP地址、协议端口、IP地址组、协议端口组。当前仅支持北京、泰国、北美地域请求。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateMemberRequest"/></param>
        /// <returns><see cref="DeleteTemplateMemberResponse"/></returns>
        public async Task<DeleteTemplateMemberResponse> DeleteTemplateMember(DeleteTemplateMemberRequest req)
        {
             JsonResponseModel<DeleteTemplateMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTemplateMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTemplateMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除模板对象中的IP地址、协议端口、IP地址组、协议端口组。当前仅支持北京、泰国、北美地域请求。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateMemberRequest"/></param>
        /// <returns><see cref="DeleteTemplateMemberResponse"/></returns>
        public DeleteTemplateMemberResponse DeleteTemplateMemberSync(DeleteTemplateMemberRequest req)
        {
             JsonResponseModel<DeleteTemplateMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTemplateMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTemplateMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpc）用于删除私有网络。
        /// * 删除前请确保 VPC 内已经没有相关资源，例如云服务器、云数据库、NoSQL、VPN网关、专线网关、负载均衡、对等连接、与之互通的基础网络设备等。
        /// * 删除私有网络是不可逆的操作，请谨慎处理。
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
        /// 本接口（DeleteVpc）用于删除私有网络。
        /// * 删除前请确保 VPC 内已经没有相关资源，例如云服务器、云数据库、NoSQL、VPN网关、专线网关、负载均衡、对等连接、与之互通的基础网络设备等。
        /// * 删除私有网络是不可逆的操作，请谨慎处理。
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
        /// 本接口（DeleteVpcEndPoint）用于删除终端节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public async Task<DeleteVpcEndPointResponse> DeleteVpcEndPoint(DeleteVpcEndPointRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPoint）用于删除终端节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public DeleteVpcEndPointResponse DeleteVpcEndPointSync(DeleteVpcEndPointRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointService）用于删除终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public async Task<DeleteVpcEndPointServiceResponse> DeleteVpcEndPointService(DeleteVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointService）用于删除终端节点服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public DeleteVpcEndPointServiceResponse DeleteVpcEndPointServiceSync(DeleteVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointServiceWhiteList）用于删除终端节点服务白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<DeleteVpcEndPointServiceWhiteListResponse> DeleteVpcEndPointServiceWhiteList(DeleteVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpcEndPointServiceWhiteList）用于删除终端节点服务白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public DeleteVpcEndPointServiceWhiteListResponse DeleteVpcEndPointServiceWhiteListSync(DeleteVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse>>(strResp);
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
        /// 本接口(DeleteVpnConnection)用于删除VPN通道。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
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
        /// 本接口（DeleteVpnGateway）用于删除VPN网关。目前只支持删除运行中的按量计费的IPSEC网关实例。
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
        /// 本接口（DeleteVpnGateway）用于删除VPN网关。目前只支持删除运行中的按量计费的IPSEC网关实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
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
        /// 本接口（DeleteVpnGatewayCcnRoutes）用于删除VPN网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public async Task<DeleteVpnGatewayRoutesResponse> DeleteVpnGatewayRoutes(DeleteVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteVpnGatewayCcnRoutes）用于删除VPN网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public DeleteVpnGatewayRoutesResponse DeleteVpnGatewayRoutesSync(DeleteVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SSL-VPN-CLIENT
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslClientResponse"/></returns>
        public async Task<DeleteVpnGatewaySslClientResponse> DeleteVpnGatewaySslClient(DeleteVpnGatewaySslClientRequest req)
        {
             JsonResponseModel<DeleteVpnGatewaySslClientResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnGatewaySslClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewaySslClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SSL-VPN-CLIENT
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslClientRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslClientResponse"/></returns>
        public DeleteVpnGatewaySslClientResponse DeleteVpnGatewaySslClientSync(DeleteVpnGatewaySslClientRequest req)
        {
             JsonResponseModel<DeleteVpnGatewaySslClientResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnGatewaySslClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewaySslClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SSL-VPN-SERVER 实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslServerResponse"/></returns>
        public async Task<DeleteVpnGatewaySslServerResponse> DeleteVpnGatewaySslServer(DeleteVpnGatewaySslServerRequest req)
        {
             JsonResponseModel<DeleteVpnGatewaySslServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnGatewaySslServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewaySslServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除SSL-VPN-SERVER 实例
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewaySslServerRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewaySslServerResponse"/></returns>
        public DeleteVpnGatewaySslServerResponse DeleteVpnGatewaySslServerSync(DeleteVpnGatewaySslServerRequest req)
        {
             JsonResponseModel<DeleteVpnGatewaySslServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnGatewaySslServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewaySslServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccountAttributes）用于查询用户账号私有属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public async Task<DescribeAccountAttributesResponse> DescribeAccountAttributes(DescribeAccountAttributesRequest req)
        {
             JsonResponseModel<DescribeAccountAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccountAttributes）用于查询用户账号私有属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributesSync(DescribeAccountAttributesRequest req)
        {
             JsonResponseModel<DescribeAccountAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAddressQuota) 用于查询您账户的[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）在当前地域的配额信息。配额详情可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)。
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
        /// 本接口 (DescribeAddressQuota) 用于查询您账户的[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）在当前地域的配额信息。配额详情可参见 [EIP 产品简介](https://cloud.tencent.com/document/product/213/5733)。
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
        /// 本接口（DescribeAddressTemplateGroups）用于查询IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public async Task<DescribeAddressTemplateGroupsResponse> DescribeAddressTemplateGroups(DescribeAddressTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeAddressTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplateGroups）用于查询IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public DescribeAddressTemplateGroupsResponse DescribeAddressTemplateGroupsSync(DescribeAddressTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeAddressTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddressTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplates）用于查询IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public async Task<DescribeAddressTemplatesResponse> DescribeAddressTemplates(DescribeAddressTemplatesRequest req)
        {
             JsonResponseModel<DescribeAddressTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAddressTemplates）用于查询IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public DescribeAddressTemplatesResponse DescribeAddressTemplatesSync(DescribeAddressTemplatesRequest req)
        {
             JsonResponseModel<DescribeAddressTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddressTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAddresses) 用于查询一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的详细信息。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的 EIP。
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
        /// 本接口 (DescribeAddresses) 用于查询一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的详细信息。
        /// * 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的 EIP。
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
        /// 本接口（DescribeAssistantCidr）用于查询辅助CIDR列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public async Task<DescribeAssistantCidrResponse> DescribeAssistantCidr(DescribeAssistantCidrRequest req)
        {
             JsonResponseModel<DescribeAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAssistantCidr）用于查询辅助CIDR列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public DescribeAssistantCidrResponse DescribeAssistantCidrSync(DescribeAssistantCidrRequest req)
        {
             JsonResponseModel<DescribeAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageBillUsage) 用于查询后付费共享带宽包当前的计费用量.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public async Task<DescribeBandwidthPackageBillUsageResponse> DescribeBandwidthPackageBillUsage(DescribeBandwidthPackageBillUsageRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageBillUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackageBillUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageBillUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageBillUsage) 用于查询后付费共享带宽包当前的计费用量.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public DescribeBandwidthPackageBillUsageResponse DescribeBandwidthPackageBillUsageSync(DescribeBandwidthPackageBillUsageRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageBillUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackageBillUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageBillUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询账户在当前地域的带宽包上限数量以及使用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public async Task<DescribeBandwidthPackageQuotaResponse> DescribeBandwidthPackageQuota(DescribeBandwidthPackageQuotaRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询账户在当前地域的带宽包上限数量以及使用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public DescribeBandwidthPackageQuotaResponse DescribeBandwidthPackageQuotaSync(DescribeBandwidthPackageQuotaRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageResources) 用于根据共享带宽包唯一ID查询共享带宽包内的资源列表，支持按条件过滤查询结果和分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public async Task<DescribeBandwidthPackageResourcesResponse> DescribeBandwidthPackageResources(DescribeBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBandwidthPackageResources) 用于根据共享带宽包唯一ID查询共享带宽包内的资源列表，支持按条件过滤查询结果和分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public DescribeBandwidthPackageResourcesResponse DescribeBandwidthPackageResourcesSync(DescribeBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询带宽包详细信息，包括带宽包唯一标识ID，类型，计费模式，名称，资源信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public async Task<DescribeBandwidthPackagesResponse> DescribeBandwidthPackages(DescribeBandwidthPackagesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于查询带宽包详细信息，包括带宽包唯一标识ID，类型，计费模式，名称，资源信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public DescribeBandwidthPackagesResponse DescribeBandwidthPackagesSync(DescribeBandwidthPackagesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnAttachedInstances）用于查询云联网实例下已关联的网络实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public async Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnAttachedInstances）用于查询云联网实例下已关联的网络实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnRegionBandwidthLimits）用于查询云联网各地域出带宽上限，该接口只返回已关联网络实例包含的地域。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public async Task<DescribeCcnRegionBandwidthLimitsResponse> DescribeCcnRegionBandwidthLimits(DescribeCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnRegionBandwidthLimits）用于查询云联网各地域出带宽上限，该接口只返回已关联网络实例包含的地域。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public DescribeCcnRegionBandwidthLimitsResponse DescribeCcnRegionBandwidthLimitsSync(DescribeCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnRoutes）用于查询已加入云联网（CCN）的路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public async Task<DescribeCcnRoutesResponse> DescribeCcnRoutes(DescribeCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnRoutes）用于查询已加入云联网（CCN）的路由。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public DescribeCcnRoutesResponse DescribeCcnRoutesSync(DescribeCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcns）用于查询云联网（CCN）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public async Task<DescribeCcnsResponse> DescribeCcns(DescribeCcnsRequest req)
        {
             JsonResponseModel<DescribeCcnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcns）用于查询云联网（CCN）列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public DescribeCcnsResponse DescribeCcnsSync(DescribeCcnsRequest req)
        {
             JsonResponseModel<DescribeCcnsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClassicLinkInstances）用于查询私有网络和基础网络设备互通列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public async Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest req)
        {
             JsonResponseModel<DescribeClassicLinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicLinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicLinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClassicLinkInstances）用于查询私有网络和基础网络设备互通列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstancesSync(DescribeClassicLinkInstancesRequest req)
        {
             JsonResponseModel<DescribeClassicLinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicLinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicLinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderCcnRegionBandwidthLimits）用于获取要锁定的限速实例列表。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（DescribeTenantCcns）
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderCcnRegionBandwidthLimitsResponse"/></returns>
        public async Task<DescribeCrossBorderCcnRegionBandwidthLimitsResponse> DescribeCrossBorderCcnRegionBandwidthLimits(DescribeCrossBorderCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<DescribeCrossBorderCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCrossBorderCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeCrossBorderCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCrossBorderCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderCompliance）用于查询用户创建的合规化资质审批单。
        /// 服务商可以查询服务名下的任意 `APPID` 创建的审批单；非服务商，只能查询自己审批单。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public async Task<DescribeCrossBorderComplianceResponse> DescribeCrossBorderCompliance(DescribeCrossBorderComplianceRequest req)
        {
             JsonResponseModel<DescribeCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderCompliance）用于查询用户创建的合规化资质审批单。
        /// 服务商可以查询服务名下的任意 `APPID` 创建的审批单；非服务商，只能查询自己审批单。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public DescribeCrossBorderComplianceResponse DescribeCrossBorderComplianceSync(DescribeCrossBorderComplianceRequest req)
        {
             JsonResponseModel<DescribeCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderFlowMonitor）用于查询跨境带宽监控数据，该接口目前只提供给服务商联通使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderFlowMonitorRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderFlowMonitorResponse"/></returns>
        public async Task<DescribeCrossBorderFlowMonitorResponse> DescribeCrossBorderFlowMonitor(DescribeCrossBorderFlowMonitorRequest req)
        {
             JsonResponseModel<DescribeCrossBorderFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCrossBorderFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderFlowMonitor）用于查询跨境带宽监控数据，该接口目前只提供给服务商联通使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderFlowMonitorRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderFlowMonitorResponse"/></returns>
        public DescribeCrossBorderFlowMonitorResponse DescribeCrossBorderFlowMonitorSync(DescribeCrossBorderFlowMonitorRequest req)
        {
             JsonResponseModel<DescribeCrossBorderFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCrossBorderFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCustomerGatewayVendors）用于查询可支持的对端网关厂商信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public async Task<DescribeCustomerGatewayVendorsResponse> DescribeCustomerGatewayVendors(DescribeCustomerGatewayVendorsRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewayVendorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerGatewayVendors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewayVendorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCustomerGatewayVendors）用于查询可支持的对端网关厂商信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public DescribeCustomerGatewayVendorsResponse DescribeCustomerGatewayVendorsSync(DescribeCustomerGatewayVendorsRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewayVendorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomerGatewayVendors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewayVendorsResponse>>(strResp);
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
        /// 本接口（DescribeCustomerGateways）用于查询对端网关列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
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
        /// 本接口（DescribeDhcpIps）用于查询DhcpIp列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDhcpIpsRequest"/></param>
        /// <returns><see cref="DescribeDhcpIpsResponse"/></returns>
        public async Task<DescribeDhcpIpsResponse> DescribeDhcpIps(DescribeDhcpIpsRequest req)
        {
             JsonResponseModel<DescribeDhcpIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDhcpIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDhcpIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDhcpIps）用于查询DhcpIp列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDhcpIpsRequest"/></param>
        /// <returns><see cref="DescribeDhcpIpsResponse"/></returns>
        public DescribeDhcpIpsResponse DescribeDhcpIpsSync(DescribeDhcpIpsRequest req)
        {
             JsonResponseModel<DescribeDhcpIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDhcpIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDhcpIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGatewayCcnRoutes）用于查询专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<DescribeDirectConnectGatewayCcnRoutesResponse> DescribeDirectConnectGatewayCcnRoutes(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGatewayCcnRoutes）用于查询专线网关的云联网路由（IDC网段）
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DescribeDirectConnectGatewayCcnRoutesResponse DescribeDirectConnectGatewayCcnRoutesSync(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGateways）用于查询专线网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public async Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectGateways）用于查询专线网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public DescribeDirectConnectGatewaysResponse DescribeDirectConnectGatewaysSync(DescribeDirectConnectGatewaysRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlowLog）用于查询流日志实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public async Task<DescribeFlowLogResponse> DescribeFlowLog(DescribeFlowLogRequest req)
        {
             JsonResponseModel<DescribeFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlowLog）用于查询流日志实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public DescribeFlowLogResponse DescribeFlowLogSync(DescribeFlowLogRequest req)
        {
             JsonResponseModel<DescribeFlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlowLogs）用于查询获取流日志集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public async Task<DescribeFlowLogsResponse> DescribeFlowLogs(DescribeFlowLogsRequest req)
        {
             JsonResponseModel<DescribeFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFlowLogs）用于查询获取流日志集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public DescribeFlowLogsResponse DescribeFlowLogsSync(DescribeFlowLogsRequest req)
        {
             JsonResponseModel<DescribeFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowMonitorDetail）用于查询网关流量监控明细。
        /// * 只支持单个网关实例查询。即入参 `VpnId`、 `DirectConnectGatewayId`、 `PeeringConnectionId`、 `NatId` 最多只支持传一个，且必须传一个。
        /// * 如果网关有流量，但调用本接口没有返回数据，请在控制台对应网关详情页确认是否开启网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowMonitorDetailResponse"/></returns>
        public async Task<DescribeGatewayFlowMonitorDetailResponse> DescribeGatewayFlowMonitorDetail(DescribeGatewayFlowMonitorDetailRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayFlowMonitorDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayFlowMonitorDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowQos）用于查询网关来访IP流控带宽。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public async Task<DescribeGatewayFlowQosResponse> DescribeGatewayFlowQos(DescribeGatewayFlowQosRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGatewayFlowQos）用于查询网关来访IP流控带宽。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public DescribeGatewayFlowQosResponse DescribeGatewayFlowQosSync(DescribeGatewayFlowQosRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeHaVips）用于查询高可用虚拟IP（HAVIP）列表。
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
        /// 本接口（DescribeHaVips）用于查询高可用虚拟IP（HAVIP）列表。
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
        /// 该接口用于查询IPV6地址信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6AddressesRequest"/></param>
        /// <returns><see cref="DescribeIp6AddressesResponse"/></returns>
        public async Task<DescribeIp6AddressesResponse> DescribeIp6Addresses(DescribeIp6AddressesRequest req)
        {
             JsonResponseModel<DescribeIp6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIp6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询IPV6地址信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6AddressesRequest"/></param>
        /// <returns><see cref="DescribeIp6AddressesResponse"/></returns>
        public DescribeIp6AddressesResponse DescribeIp6AddressesSync(DescribeIp6AddressesRequest req)
        {
             JsonResponseModel<DescribeIp6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIp6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账户在指定地域IPV6转换实例和规则的配额
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorQuotaRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorQuotaResponse"/></returns>
        public async Task<DescribeIp6TranslatorQuotaResponse> DescribeIp6TranslatorQuota(DescribeIp6TranslatorQuotaRequest req)
        {
             JsonResponseModel<DescribeIp6TranslatorQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIp6TranslatorQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6TranslatorQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账户在指定地域IPV6转换实例和规则的配额
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorQuotaRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorQuotaResponse"/></returns>
        public DescribeIp6TranslatorQuotaResponse DescribeIp6TranslatorQuotaSync(DescribeIp6TranslatorQuotaRequest req)
        {
             JsonResponseModel<DescribeIp6TranslatorQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIp6TranslatorQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6TranslatorQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于查询账户下的IPV6转换实例及其绑定的转换规则信息
        /// 2. 支持过滤查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorsResponse"/></returns>
        public async Task<DescribeIp6TranslatorsResponse> DescribeIp6Translators(DescribeIp6TranslatorsRequest req)
        {
             JsonResponseModel<DescribeIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于查询账户下的IPV6转换实例及其绑定的转换规则信息
        /// 2. 支持过滤查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIp6TranslatorsRequest"/></param>
        /// <returns><see cref="DescribeIp6TranslatorsResponse"/></returns>
        public DescribeIp6TranslatorsResponse DescribeIp6TranslatorsSync(DescribeIp6TranslatorsRequest req)
        {
             JsonResponseModel<DescribeIp6TranslatorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIp6Translators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIp6TranslatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationDatabaseUrl）用于获取IP地理位置库下载链接。
        /// <font color="#FF0000">本接口即将下线，仅供存量用户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public async Task<DescribeIpGeolocationDatabaseUrlResponse> DescribeIpGeolocationDatabaseUrl(DescribeIpGeolocationDatabaseUrlRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpGeolocationDatabaseUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationDatabaseUrl）用于获取IP地理位置库下载链接。
        /// <font color="#FF0000">本接口即将下线，仅供存量用户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public DescribeIpGeolocationDatabaseUrlResponse DescribeIpGeolocationDatabaseUrlSync(DescribeIpGeolocationDatabaseUrlRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpGeolocationDatabaseUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationInfos）用于查询IP地址信息，包括地理位置信息和网络信息。
        /// <font color="#FF0000">本接口即将下线，仅供存量客户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public async Task<DescribeIpGeolocationInfosResponse> DescribeIpGeolocationInfos(DescribeIpGeolocationInfosRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpGeolocationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIpGeolocationInfos）用于查询IP地址信息，包括地理位置信息和网络信息。
        /// <font color="#FF0000">本接口即将下线，仅供存量客户使用，暂停新增用户。</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public DescribeIpGeolocationInfosResponse DescribeIpGeolocationInfosSync(DescribeIpGeolocationInfosRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpGeolocationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLocalGateway）用于查询CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public async Task<DescribeLocalGatewayResponse> DescribeLocalGateway(DescribeLocalGatewayRequest req)
        {
             JsonResponseModel<DescribeLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLocalGateway）用于查询CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public DescribeLocalGatewayResponse DescribeLocalGatewaySync(DescribeLocalGatewayRequest req)
        {
             JsonResponseModel<DescribeLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNatGatewayDestinationIpPortTranslationNatRules）用于查询NAT网关端口转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public async Task<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> DescribeNatGatewayDestinationIpPortTranslationNatRules(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNatGatewayDestinationIpPortTranslationNatRules）用于查询NAT网关端口转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse DescribeNatGatewayDestinationIpPortTranslationNatRulesSync(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专线绑定NAT的路由
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public async Task<DescribeNatGatewayDirectConnectGatewayRouteResponse> DescribeNatGatewayDirectConnectGatewayRoute(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGatewayDirectConnectGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询专线绑定NAT的路由
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public DescribeNatGatewayDirectConnectGatewayRouteResponse DescribeNatGatewayDirectConnectGatewayRouteSync(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGatewayDirectConnectGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNatGatewaySourceIpTranslationNatRules）用于查询NAT网关SNAT转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public async Task<DescribeNatGatewaySourceIpTranslationNatRulesResponse> DescribeNatGatewaySourceIpTranslationNatRules(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGatewaySourceIpTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNatGatewaySourceIpTranslationNatRules）用于查询NAT网关SNAT转发规则对象数组。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewaySourceIpTranslationNatRulesResponse DescribeNatGatewaySourceIpTranslationNatRulesSync(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGatewaySourceIpTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNatGateways）用于查询 NAT 网关。
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
        /// 本接口（DescribeNatGateways）用于查询 NAT 网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
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
        /// 本接口(DescribeNetDetectStates)用于查询网络探测验证结果列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public async Task<DescribeNetDetectStatesResponse> DescribeNetDetectStates(DescribeNetDetectStatesRequest req)
        {
             JsonResponseModel<DescribeNetDetectStatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetDetectStates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectStatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeNetDetectStates)用于查询网络探测验证结果列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public DescribeNetDetectStatesResponse DescribeNetDetectStatesSync(DescribeNetDetectStatesRequest req)
        {
             JsonResponseModel<DescribeNetDetectStatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetDetectStates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectStatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetDetects）用于查询网络探测列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public async Task<DescribeNetDetectsResponse> DescribeNetDetects(DescribeNetDetectsRequest req)
        {
             JsonResponseModel<DescribeNetDetectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetDetects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetDetects）用于查询网络探测列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public DescribeNetDetectsResponse DescribeNetDetectsSync(DescribeNetDetectsRequest req)
        {
             JsonResponseModel<DescribeNetDetectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetDetects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断用户在网络侧的用户类型，如标准（带宽上移），传统（非上移）。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAccountTypeRequest"/></param>
        /// <returns><see cref="DescribeNetworkAccountTypeResponse"/></returns>
        public async Task<DescribeNetworkAccountTypeResponse> DescribeNetworkAccountType(DescribeNetworkAccountTypeRequest req)
        {
             JsonResponseModel<DescribeNetworkAccountTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkAccountType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAccountTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断用户在网络侧的用户类型，如标准（带宽上移），传统（非上移）。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAccountTypeRequest"/></param>
        /// <returns><see cref="DescribeNetworkAccountTypeResponse"/></returns>
        public DescribeNetworkAccountTypeResponse DescribeNetworkAccountTypeSync(DescribeNetworkAccountTypeRequest req)
        {
             JsonResponseModel<DescribeNetworkAccountTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkAccountType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAccountTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkAclQuintupleEntries）查询入方向或出方向网络ACL五元组条目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<DescribeNetworkAclQuintupleEntriesResponse> DescribeNetworkAclQuintupleEntries(DescribeNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkAclQuintupleEntries）查询入方向或出方向网络ACL五元组条目列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public DescribeNetworkAclQuintupleEntriesResponse DescribeNetworkAclQuintupleEntriesSync(DescribeNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkAcls）用于查询网络ACL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public async Task<DescribeNetworkAclsResponse> DescribeNetworkAcls(DescribeNetworkAclsRequest req)
        {
             JsonResponseModel<DescribeNetworkAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkAcls）用于查询网络ACL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public DescribeNetworkAclsResponse DescribeNetworkAclsSync(DescribeNetworkAclsRequest req)
        {
             JsonResponseModel<DescribeNetworkAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaceLimit）根据CVM实例ID或弹性网卡ID查询弹性网卡配额，返回该CVM实例或弹性网卡能绑定的弹性网卡配额，以及弹性网卡可以分配的IP配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public async Task<DescribeNetworkInterfaceLimitResponse> DescribeNetworkInterfaceLimit(DescribeNetworkInterfaceLimitRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfaceLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkInterfaceLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfaceLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaceLimit）根据CVM实例ID或弹性网卡ID查询弹性网卡配额，返回该CVM实例或弹性网卡能绑定的弹性网卡配额，以及弹性网卡可以分配的IP配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public DescribeNetworkInterfaceLimitResponse DescribeNetworkInterfaceLimitSync(DescribeNetworkInterfaceLimitRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfaceLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkInterfaceLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfaceLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNetworkInterfaces）用于查询弹性网卡列表。
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
        /// 本接口（DescribeNetworkInterfaces）用于查询弹性网卡列表。
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
        /// 本接口（DescribeProductQuota）用于查询网络产品的配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductQuotaRequest"/></param>
        /// <returns><see cref="DescribeProductQuotaResponse"/></returns>
        public async Task<DescribeProductQuotaResponse> DescribeProductQuota(DescribeProductQuotaRequest req)
        {
             JsonResponseModel<DescribeProductQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductQuota）用于查询网络产品的配额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductQuotaRequest"/></param>
        /// <returns><see cref="DescribeProductQuotaResponse"/></returns>
        public DescribeProductQuotaResponse DescribeProductQuotaSync(DescribeProductQuotaRequest req)
        {
             JsonResponseModel<DescribeProductQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRouteConflicts）用于查询自定义路由策略与云联网路由策略冲突列表。
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
        /// 本接口（DescribeRouteConflicts）用于查询自定义路由策略与云联网路由策略冲突列表。
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
        ///  本接口（DescribeRouteTables）用于查询路由表。
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
        ///  本接口（DescribeRouteTables）用于查询路由表。
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
        /// 本接口（DescribeSecurityGroupAssociationStatistics）用于查询安全组关联的实例统计。
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
        /// 本接口（DescribeSecurityGroupAssociationStatistics）用于查询安全组关联的实例统计。
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
        /// 本接口(DescribeSecurityGroupLimits)用于查询用户安全组配额。
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
        /// 本接口(DescribeSecurityGroupLimits)用于查询用户安全组配额。
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
        /// 本接口（DescribeSecurityGroupPolicies）用于查询安全组规则。
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
        /// 本接口（DescribeSecurityGroupPolicies）用于查询安全组规则。
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
        /// 本接口（DescribeSecurityGroupReferences）用于查询安全组被引用信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public async Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupReferencesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupReferences");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupReferencesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroupReferences）用于查询安全组被引用信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferencesSync(DescribeSecurityGroupReferencesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupReferencesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupReferences");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupReferencesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSecurityGroups）用于查询安全组。
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
        /// 本接口（DescribeSecurityGroups）用于查询安全组。
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
        /// 本接口（DescribeServiceTemplateGroups）用于查询协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public async Task<DescribeServiceTemplateGroupsResponse> DescribeServiceTemplateGroups(DescribeServiceTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeServiceTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplateGroups）用于查询协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public DescribeServiceTemplateGroupsResponse DescribeServiceTemplateGroupsSync(DescribeServiceTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeServiceTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplates）用于查询协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public async Task<DescribeServiceTemplatesResponse> DescribeServiceTemplates(DescribeServiceTemplatesRequest req)
        {
             JsonResponseModel<DescribeServiceTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceTemplates）用于查询协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public DescribeServiceTemplatesResponse DescribeServiceTemplatesSync(DescribeServiceTemplatesRequest req)
        {
             JsonResponseModel<DescribeServiceTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSgSnapshotFileContent）用于查询安全组快照文件内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public async Task<DescribeSgSnapshotFileContentResponse> DescribeSgSnapshotFileContent(DescribeSgSnapshotFileContentRequest req)
        {
             JsonResponseModel<DescribeSgSnapshotFileContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSgSnapshotFileContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSgSnapshotFileContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSgSnapshotFileContent）用于查询安全组快照文件内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public DescribeSgSnapshotFileContentResponse DescribeSgSnapshotFileContentSync(DescribeSgSnapshotFileContentRequest req)
        {
             JsonResponseModel<DescribeSgSnapshotFileContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSgSnapshotFileContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSgSnapshotFileContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotAttachedInstances）用于查询快照策略关联实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public async Task<DescribeSnapshotAttachedInstancesResponse> DescribeSnapshotAttachedInstances(DescribeSnapshotAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeSnapshotAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotAttachedInstances）用于查询快照策略关联实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public DescribeSnapshotAttachedInstancesResponse DescribeSnapshotAttachedInstancesSync(DescribeSnapshotAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeSnapshotAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotFiles）用于查询快照文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public async Task<DescribeSnapshotFilesResponse> DescribeSnapshotFiles(DescribeSnapshotFilesRequest req)
        {
             JsonResponseModel<DescribeSnapshotFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotFiles）用于查询快照文件。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public DescribeSnapshotFilesResponse DescribeSnapshotFilesSync(DescribeSnapshotFilesRequest req)
        {
             JsonResponseModel<DescribeSnapshotFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotPolicies）用于查询快照策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public async Task<DescribeSnapshotPoliciesResponse> DescribeSnapshotPolicies(DescribeSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSnapshotPolicies）用于查询快照策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public DescribeSnapshotPoliciesResponse DescribeSnapshotPoliciesSync(DescribeSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSubnets）用于查询子网列表。
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
        /// 本接口（DescribeSubnets）用于查询子网列表。
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
        /// 本接口（DescribeTemplateLimits）用于查询参数模板配额列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateLimitsRequest"/></param>
        /// <returns><see cref="DescribeTemplateLimitsResponse"/></returns>
        public async Task<DescribeTemplateLimitsResponse> DescribeTemplateLimits(DescribeTemplateLimitsRequest req)
        {
             JsonResponseModel<DescribeTemplateLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplateLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTemplateLimits）用于查询参数模板配额列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateLimitsRequest"/></param>
        /// <returns><see cref="DescribeTemplateLimitsResponse"/></returns>
        public DescribeTemplateLimitsResponse DescribeTemplateLimitsSync(DescribeTemplateLimitsRequest req)
        {
             JsonResponseModel<DescribeTemplateLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplateLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTenantCcns）用于获取要锁定的云联网实例列表。
        /// 该接口一般用来封禁出口限速的云联网实例, 目前联通内部运营系统通过云API调用, 因为出口限速无法按地域间封禁, 只能按更粗的云联网实例粒度封禁, 如果是地域间限速, 一般可以通过更细的限速实例粒度封禁（DescribeCrossBorderCcnRegionBandwidthLimits）
        /// 如有需要, 可以封禁任意云联网实例, 可接入到内部运营系统
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantCcnsRequest"/></param>
        /// <returns><see cref="DescribeTenantCcnsResponse"/></returns>
        public async Task<DescribeTenantCcnsResponse> DescribeTenantCcns(DescribeTenantCcnsRequest req)
        {
             JsonResponseModel<DescribeTenantCcnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTenantCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeTenantCcnsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTenantCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTrafficPackages)  用于查询共享流量包详细信息，包括共享流量包唯一标识ID，名称，流量使用信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public async Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTrafficPackages)  用于查询共享流量包详细信息，包括共享流量包唯一标识ID，名称，流量使用信息等
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPoint）用于查询终端节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public async Task<DescribeVpcEndPointResponse> DescribeVpcEndPoint(DescribeVpcEndPointRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPoint）用于查询终端节点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public DescribeVpcEndPointResponse DescribeVpcEndPointSync(DescribeVpcEndPointRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询终端节点服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public async Task<DescribeVpcEndPointServiceResponse> DescribeVpcEndPointService(DescribeVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询终端节点服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public DescribeVpcEndPointServiceResponse DescribeVpcEndPointServiceSync(DescribeVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPointServiceWhiteList）用于查询终端节点服务的服务白名单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<DescribeVpcEndPointServiceWhiteListResponse> DescribeVpcEndPointServiceWhiteList(DescribeVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcEndPointServiceWhiteList）用于查询终端节点服务的服务白名单列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public DescribeVpcEndPointServiceWhiteListResponse DescribeVpcEndPointServiceWhiteListSync(DescribeVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcInstances）用于查询VPC下的云主机实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public async Task<DescribeVpcInstancesResponse> DescribeVpcInstances(DescribeVpcInstancesRequest req)
        {
             JsonResponseModel<DescribeVpcInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcInstances）用于查询VPC下的云主机实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public DescribeVpcInstancesResponse DescribeVpcInstancesSync(DescribeVpcInstancesRequest req)
        {
             JsonResponseModel<DescribeVpcInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcIpv6Addresses）用于查询 `VPC` `IPv6` 信息。
        /// 只能查询已使用的`IPv6`信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public async Task<DescribeVpcIpv6AddressesResponse> DescribeVpcIpv6Addresses(DescribeVpcIpv6AddressesRequest req)
        {
             JsonResponseModel<DescribeVpcIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcIpv6Addresses）用于查询 `VPC` `IPv6` 信息。
        /// 只能查询已使用的`IPv6`信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public DescribeVpcIpv6AddressesResponse DescribeVpcIpv6AddressesSync(DescribeVpcIpv6AddressesRequest req)
        {
             JsonResponseModel<DescribeVpcIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DescribeVpcLimitsResponse> DescribeVpcLimits(DescribeVpcLimitsRequest req)
        {
             JsonResponseModel<DescribeVpcLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeVpcLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcPrivateIpAddresses）用于查询VPC内网IP信息。<br />
        /// 只能查询已使用的IP信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public async Task<DescribeVpcPrivateIpAddressesResponse> DescribeVpcPrivateIpAddresses(DescribeVpcPrivateIpAddressesRequest req)
        {
             JsonResponseModel<DescribeVpcPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcPrivateIpAddresses）用于查询VPC内网IP信息。<br />
        /// 只能查询已使用的IP信息，当查询未使用的IP时，本接口不会报错，但不会出现在返回结果里。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public DescribeVpcPrivateIpAddressesResponse DescribeVpcPrivateIpAddressesSync(DescribeVpcPrivateIpAddressesRequest req)
        {
             JsonResponseModel<DescribeVpcPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeVpcResourceDashboard)用于查看VPC资源信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public async Task<DescribeVpcResourceDashboardResponse> DescribeVpcResourceDashboard(DescribeVpcResourceDashboardRequest req)
        {
             JsonResponseModel<DescribeVpcResourceDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcResourceDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcResourceDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeVpcResourceDashboard)用于查看VPC资源信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public DescribeVpcResourceDashboardResponse DescribeVpcResourceDashboardSync(DescribeVpcResourceDashboardRequest req)
        {
             JsonResponseModel<DescribeVpcResourceDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcResourceDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcResourceDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcTaskResult）用于查询VPC任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public async Task<DescribeVpcTaskResultResponse> DescribeVpcTaskResult(DescribeVpcTaskResultRequest req)
        {
             JsonResponseModel<DescribeVpcTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcTaskResult）用于查询VPC任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public DescribeVpcTaskResultResponse DescribeVpcTaskResultSync(DescribeVpcTaskResultRequest req)
        {
             JsonResponseModel<DescribeVpcTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
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
        /// 本接口（DescribeVpcs）用于查询私有网络列表。
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
        ///  本接口（DescribeVpnConnections）查询VPN通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
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
        /// 本接口（DescribeVpnGatewayCcnRoutes）用于查询VPN网关云联网路由
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public async Task<DescribeVpnGatewayCcnRoutesResponse> DescribeVpnGatewayCcnRoutes(DescribeVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeVpnGatewayCcnRoutes）用于查询VPN网关云联网路由
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public DescribeVpnGatewayCcnRoutesResponse DescribeVpnGatewayCcnRoutesSync(DescribeVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路由型VPN网关的目的路由
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public async Task<DescribeVpnGatewayRoutesResponse> DescribeVpnGatewayRoutes(DescribeVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询路由型VPN网关的目的路由
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public DescribeVpnGatewayRoutesResponse DescribeVpnGatewayRoutesSync(DescribeVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SSL-VPN-CLIENT 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslClientsRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslClientsResponse"/></returns>
        public async Task<DescribeVpnGatewaySslClientsResponse> DescribeVpnGatewaySslClients(DescribeVpnGatewaySslClientsRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaySslClientsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGatewaySslClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaySslClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SSL-VPN-CLIENT 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslClientsRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslClientsResponse"/></returns>
        public DescribeVpnGatewaySslClientsResponse DescribeVpnGatewaySslClientsSync(DescribeVpnGatewaySslClientsRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaySslClientsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGatewaySslClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaySslClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SSL-VPN SERVER 列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslServersRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslServersResponse"/></returns>
        public async Task<DescribeVpnGatewaySslServersResponse> DescribeVpnGatewaySslServers(DescribeVpnGatewaySslServersRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaySslServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGatewaySslServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaySslServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询SSL-VPN SERVER 列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaySslServersRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaySslServersResponse"/></returns>
        public DescribeVpnGatewaySslServersResponse DescribeVpnGatewaySslServersSync(DescribeVpnGatewaySslServersRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaySslServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGatewaySslServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaySslServersResponse>>(strResp);
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
        /// 本接口（DescribeVpnGateways）用于查询VPN网关列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
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
        /// 本接口（DetachCcnInstances）用于从云联网实例中解关联指定的网络实例。<br />
        /// 解关联网络实例后，相应的路由策略会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public async Task<DetachCcnInstancesResponse> DetachCcnInstances(DetachCcnInstancesRequest req)
        {
             JsonResponseModel<DetachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachCcnInstances）用于从云联网实例中解关联指定的网络实例。<br />
        /// 解关联网络实例后，相应的路由策略会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public DetachCcnInstancesResponse DetachCcnInstancesSync(DetachCcnInstancesRequest req)
        {
             JsonResponseModel<DetachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DetachClassicLinkVpc)用于删除私有网络和基础网络设备互通。
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DetachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="DetachClassicLinkVpcResponse"/></returns>
        public async Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpc(DetachClassicLinkVpcRequest req)
        {
             JsonResponseModel<DetachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DetachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachNetworkInterface）用于弹性网卡解绑云服务器。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        /// 本接口（DetachNetworkInterface）用于弹性网卡解绑云服务器。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        /// 本接口（DetachSnapshotInstances）用于快照策略解关联实例。
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public async Task<DetachSnapshotInstancesResponse> DetachSnapshotInstances(DetachSnapshotInstancesRequest req)
        {
             JsonResponseModel<DetachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachSnapshotInstances）用于快照策略解关联实例。
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public DetachSnapshotInstancesResponse DetachSnapshotInstancesSync(DetachSnapshotInstancesRequest req)
        {
             JsonResponseModel<DetachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableCcnRoutes）用于禁用已经启用的云联网（CCN）路由。
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public async Task<DisableCcnRoutesResponse> DisableCcnRoutes(DisableCcnRoutesRequest req)
        {
             JsonResponseModel<DisableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableCcnRoutes）用于禁用已经启用的云联网（CCN）路由。
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public DisableCcnRoutesResponse DisableCcnRoutesSync(DisableCcnRoutesRequest req)
        {
             JsonResponseModel<DisableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableFlowLogs）用于停止流日志。
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public async Task<DisableFlowLogsResponse> DisableFlowLogs(DisableFlowLogsRequest req)
        {
             JsonResponseModel<DisableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableFlowLogs）用于停止流日志。
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public DisableFlowLogsResponse DisableFlowLogsSync(DisableFlowLogsRequest req)
        {
             JsonResponseModel<DisableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableGatewayFlowMonitor）用于关闭网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public async Task<DisableGatewayFlowMonitorResponse> DisableGatewayFlowMonitor(DisableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<DisableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableGatewayFlowMonitor）用于关闭网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public DisableGatewayFlowMonitorResponse DisableGatewayFlowMonitorSync(DisableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<DisableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableRoutes）用于禁用已启用的子网路由
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
        /// 本接口（DisableRoutes）用于禁用已启用的子网路由
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
        /// 本接口（DisableSnapshotPolicies）用于停用快照策略。
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public async Task<DisableSnapshotPoliciesResponse> DisableSnapshotPolicies(DisableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DisableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableSnapshotPolicies）用于停用快照策略。
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public DisableSnapshotPoliciesResponse DisableSnapshotPoliciesSync(DisableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DisableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用SSL-VPN-CLIENT 证书
        /// </summary>
        /// <param name="req"><see cref="DisableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DisableVpnGatewaySslClientCertResponse"/></returns>
        public async Task<DisableVpnGatewaySslClientCertResponse> DisableVpnGatewaySslClientCert(DisableVpnGatewaySslClientCertRequest req)
        {
             JsonResponseModel<DisableVpnGatewaySslClientCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableVpnGatewaySslClientCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableVpnGatewaySslClientCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用SSL-VPN-CLIENT 证书
        /// </summary>
        /// <param name="req"><see cref="DisableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DisableVpnGatewaySslClientCertResponse"/></returns>
        public DisableVpnGatewaySslClientCertResponse DisableVpnGatewaySslClientCertSync(DisableVpnGatewaySslClientCertRequest req)
        {
             JsonResponseModel<DisableVpnGatewaySslClientCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableVpnGatewaySslClientCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableVpnGatewaySslClientCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DisassociateAddress) 用于解绑[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 支持CVM实例，弹性网卡上的EIP解绑
        /// * 不支持NAT上的EIP解绑。NAT上的EIP解绑请参考[DisassociateNatGatewayAddress](https://cloud.tencent.com/document/api/215/36716)
        /// * 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// * EIP 如果被封堵，则不能进行解绑定操作。
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
        /// 本接口 (DisassociateAddress) 用于解绑[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 支持CVM实例，弹性网卡上的EIP解绑
        /// * 不支持NAT上的EIP解绑。NAT上的EIP解绑请参考[DisassociateNatGatewayAddress](https://cloud.tencent.com/document/api/215/36716)
        /// * 只有状态为 BIND 和 BIND_ENI 的 EIP 才能进行解绑定操作。
        /// * EIP 如果被封堵，则不能进行解绑定操作。
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
        /// 本接口（DisassociateDhcpIpWithAddressIp）用于将DhcpIp已绑定的弹性公网IP（EIP）解除绑定。<br />
        /// >?本接口为异步接口，可调用 [DescribeVpcTaskResult](https://cloud.tencent.com/document/api/215/59037) 接口查询任务执行结果，待任务执行成功后再进行其他操作。
        /// >
        /// </summary>
        /// <param name="req"><see cref="DisassociateDhcpIpWithAddressIpRequest"/></param>
        /// <returns><see cref="DisassociateDhcpIpWithAddressIpResponse"/></returns>
        public async Task<DisassociateDhcpIpWithAddressIpResponse> DisassociateDhcpIpWithAddressIp(DisassociateDhcpIpWithAddressIpRequest req)
        {
             JsonResponseModel<DisassociateDhcpIpWithAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateDhcpIpWithAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDhcpIpWithAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DisassociateDhcpIpWithAddressIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateDhcpIpWithAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDhcpIpWithAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将专线网关与NAT网关解绑，解绑之后，专线网关将不能通过NAT网关访问公网
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public async Task<DisassociateDirectConnectGatewayNatGatewayResponse> DisassociateDirectConnectGatewayNatGateway(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将专线网关与NAT网关解绑，解绑之后，专线网关将不能通过NAT网关访问公网
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public DisassociateDirectConnectGatewayNatGatewayResponse DisassociateDirectConnectGatewayNatGatewaySync(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateNatGatewayAddress）用于NAT网关解绑弹性IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public async Task<DisassociateNatGatewayAddressResponse> DisassociateNatGatewayAddress(DisassociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<DisassociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateNatGatewayAddress）用于NAT网关解绑弹性IP。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public DisassociateNatGatewayAddressResponse DisassociateNatGatewayAddressSync(DisassociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<DisassociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateNetworkAclSubnets）用于网络ACL解关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public async Task<DisassociateNetworkAclSubnetsResponse> DisassociateNetworkAclSubnets(DisassociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<DisassociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateNetworkAclSubnets）用于网络ACL解关联VPC下的子网。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public DisassociateNetworkAclSubnetsResponse DisassociateNetworkAclSubnetsSync(DisassociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<DisassociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateNetworkInterfaceSecurityGroups）用于弹性网卡解绑安全组。支持弹性网卡完全解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public async Task<DisassociateNetworkInterfaceSecurityGroupsResponse> DisassociateNetworkInterfaceSecurityGroups(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateNetworkInterfaceSecurityGroups）用于弹性网卡解绑安全组。支持弹性网卡完全解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public DisassociateNetworkInterfaceSecurityGroupsResponse DisassociateNetworkInterfaceSecurityGroupsSync(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateVpcEndPointSecurityGroups）用于终端节点解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public async Task<DisassociateVpcEndPointSecurityGroupsResponse> DisassociateVpcEndPointSecurityGroups(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateVpcEndPointSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisassociateVpcEndPointSecurityGroups）用于终端节点解绑安全组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public DisassociateVpcEndPointSecurityGroupsResponse DisassociateVpcEndPointSecurityGroupsSync(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateVpcEndPointSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadCustomerGatewayConfiguration）用于下载VPN通道配置。
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
        /// 本接口（DownloadCustomerGatewayConfiguration）用于下载VPN通道配置。
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
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
        /// 下载SSL-VPN-CLIENT 客户端证书
        /// </summary>
        /// <param name="req"><see cref="DownloadVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DownloadVpnGatewaySslClientCertResponse"/></returns>
        public async Task<DownloadVpnGatewaySslClientCertResponse> DownloadVpnGatewaySslClientCert(DownloadVpnGatewaySslClientCertRequest req)
        {
             JsonResponseModel<DownloadVpnGatewaySslClientCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadVpnGatewaySslClientCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadVpnGatewaySslClientCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载SSL-VPN-CLIENT 客户端证书
        /// </summary>
        /// <param name="req"><see cref="DownloadVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="DownloadVpnGatewaySslClientCertResponse"/></returns>
        public DownloadVpnGatewaySslClientCertResponse DownloadVpnGatewaySslClientCertSync(DownloadVpnGatewaySslClientCertRequest req)
        {
             JsonResponseModel<DownloadVpnGatewaySslClientCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadVpnGatewaySslClientCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadVpnGatewaySslClientCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableCcnRoutes）用于启用已经加入云联网（CCN）的路由。<br />
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public async Task<EnableCcnRoutesResponse> EnableCcnRoutes(EnableCcnRoutesRequest req)
        {
             JsonResponseModel<EnableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableCcnRoutes）用于启用已经加入云联网（CCN）的路由。<br />
        /// 本接口会校验启用后，是否与已有路由冲突，如果冲突，则无法启用，失败处理。路由冲突时，需要先禁用与之冲突的路由，才能启用该路由。
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public EnableCcnRoutesResponse EnableCcnRoutesSync(EnableCcnRoutesRequest req)
        {
             JsonResponseModel<EnableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableFlowLogs）用于启动流日志。
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public async Task<EnableFlowLogsResponse> EnableFlowLogs(EnableFlowLogsRequest req)
        {
             JsonResponseModel<EnableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableFlowLogs）用于启动流日志。
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public EnableFlowLogsResponse EnableFlowLogsSync(EnableFlowLogsRequest req)
        {
             JsonResponseModel<EnableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableGatewayFlowMonitor）用于开启网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public async Task<EnableGatewayFlowMonitorResponse> EnableGatewayFlowMonitor(EnableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<EnableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableGatewayFlowMonitor）用于开启网关流量监控。
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public EnableGatewayFlowMonitorResponse EnableGatewayFlowMonitorSync(EnableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<EnableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableRoutes）用于启用已禁用的子网路由。<br />
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
        /// 本接口（EnableRoutes）用于启用已禁用的子网路由。<br />
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
        /// 本接口（EnableSnapshotPolicies）用于启用快照策略。
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public async Task<EnableSnapshotPoliciesResponse> EnableSnapshotPolicies(EnableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<EnableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableSnapshotPolicies）用于启用快照策略。
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public EnableSnapshotPoliciesResponse EnableSnapshotPoliciesSync(EnableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<EnableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableVpcEndPointConnect）用于是否接受终端节点连接请求。
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public async Task<EnableVpcEndPointConnectResponse> EnableVpcEndPointConnect(EnableVpcEndPointConnectRequest req)
        {
             JsonResponseModel<EnableVpcEndPointConnectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableVpcEndPointConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcEndPointConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableVpcEndPointConnect）用于是否接受终端节点连接请求。
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public EnableVpcEndPointConnectResponse EnableVpcEndPointConnectSync(EnableVpcEndPointConnectRequest req)
        {
             JsonResponseModel<EnableVpcEndPointConnectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableVpcEndPointConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcEndPointConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用SSL-VPN-CLIENT 证书
        /// </summary>
        /// <param name="req"><see cref="EnableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="EnableVpnGatewaySslClientCertResponse"/></returns>
        public async Task<EnableVpnGatewaySslClientCertResponse> EnableVpnGatewaySslClientCert(EnableVpnGatewaySslClientCertRequest req)
        {
             JsonResponseModel<EnableVpnGatewaySslClientCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableVpnGatewaySslClientCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpnGatewaySslClientCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用SSL-VPN-CLIENT 证书
        /// </summary>
        /// <param name="req"><see cref="EnableVpnGatewaySslClientCertRequest"/></param>
        /// <returns><see cref="EnableVpnGatewaySslClientCertResponse"/></returns>
        public EnableVpnGatewaySslClientCertResponse EnableVpnGatewaySslClientCertSync(EnableVpnGatewaySslClientCertRequest req)
        {
             JsonResponseModel<EnableVpnGatewaySslClientCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableVpnGatewaySslClientCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpnGatewaySslClientCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetCcnRegionBandwidthLimits）用于查询云联网相关地域带宽信息，其中预付费模式的云联网仅支持地域间限速，后付费模式的云联网支持地域间限速和地域出口限速。
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public async Task<GetCcnRegionBandwidthLimitsResponse> GetCcnRegionBandwidthLimits(GetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<GetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetCcnRegionBandwidthLimits）用于查询云联网相关地域带宽信息，其中预付费模式的云联网仅支持地域间限速，后付费模式的云联网支持地域间限速和地域出口限速。
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public GetCcnRegionBandwidthLimitsResponse GetCcnRegionBandwidthLimitsSync(GetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<GetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（HaVipAssociateAddressIp）用于高可用虚拟IP（HAVIP）绑定弹性公网IP（EIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public async Task<HaVipAssociateAddressIpResponse> HaVipAssociateAddressIp(HaVipAssociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipAssociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HaVipAssociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipAssociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（HaVipAssociateAddressIp）用于高可用虚拟IP（HAVIP）绑定弹性公网IP（EIP）。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public HaVipAssociateAddressIpResponse HaVipAssociateAddressIpSync(HaVipAssociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipAssociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HaVipAssociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipAssociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（HaVipDisassociateAddressIp）用于将高可用虚拟IP（HAVIP）已绑定的弹性公网IP（EIP）解除绑定。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public async Task<HaVipDisassociateAddressIpResponse> HaVipDisassociateAddressIp(HaVipDisassociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipDisassociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HaVipDisassociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipDisassociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（HaVipDisassociateAddressIp）用于将高可用虚拟IP（HAVIP）已绑定的弹性公网IP（EIP）解除绑定。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public HaVipDisassociateAddressIpResponse HaVipDisassociateAddressIpSync(HaVipDisassociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipDisassociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HaVipDisassociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipDisassociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePriceCreateDirectConnectGateway）用于创建专线网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public async Task<InquirePriceCreateDirectConnectGatewayResponse> InquirePriceCreateDirectConnectGateway(InquirePriceCreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePriceCreateDirectConnectGateway）用于创建专线网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public InquirePriceCreateDirectConnectGatewayResponse InquirePriceCreateDirectConnectGatewaySync(InquirePriceCreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateVpnGateway）用于创建VPN网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateVpnGatewayResponse"/></returns>
        public async Task<InquiryPriceCreateVpnGatewayResponse> InquiryPriceCreateVpnGateway(InquiryPriceCreateVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceCreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateVpnGateway）用于创建VPN网关询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateVpnGatewayResponse"/></returns>
        public InquiryPriceCreateVpnGatewayResponse InquiryPriceCreateVpnGatewaySync(InquiryPriceCreateVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceCreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewVpnGateway）用于续费VPN网关询价。目前仅支持IPSEC类型网关的询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public async Task<InquiryPriceRenewVpnGatewayResponse> InquiryPriceRenewVpnGateway(InquiryPriceRenewVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceRenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewVpnGateway）用于续费VPN网关询价。目前仅支持IPSEC类型网关的询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public InquiryPriceRenewVpnGatewayResponse InquiryPriceRenewVpnGatewaySync(InquiryPriceRenewVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceRenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceResetVpnGatewayInternetMaxBandwidth）调整VPN网关带宽上限询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public async Task<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> InquiryPriceResetVpnGatewayInternetMaxBandwidth(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceResetVpnGatewayInternetMaxBandwidth）调整VPN网关带宽上限询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse InquiryPriceResetVpnGatewayInternetMaxBandwidthSync(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（LockCcnBandwidths）用户锁定云联网限速实例。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（LockCcns）。
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统。
        /// </summary>
        /// <param name="req"><see cref="LockCcnBandwidthsRequest"/></param>
        /// <returns><see cref="LockCcnBandwidthsResponse"/></returns>
        public async Task<LockCcnBandwidthsResponse> LockCcnBandwidths(LockCcnBandwidthsRequest req)
        {
             JsonResponseModel<LockCcnBandwidthsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LockCcnBandwidths");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockCcnBandwidthsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<LockCcnBandwidthsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LockCcnBandwidths");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockCcnBandwidthsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<LockCcnsResponse> LockCcns(LockCcnsRequest req)
        {
             JsonResponseModel<LockCcnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LockCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<LockCcnsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LockCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（MigrateNetworkInterface）用于弹性网卡迁移。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        /// 本接口（MigrateNetworkInterface）用于弹性网卡迁移。
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        ///  本接口（MigratePrivateIpAddress）用于弹性网卡内网IP迁移。
        /// * 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// * 迁移前后的弹性网卡必须在同一个子网内。  
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        ///  本接口（MigratePrivateIpAddress）用于弹性网卡内网IP迁移。
        /// * 该接口用于将一个内网IP从一个弹性网卡上迁移到另外一个弹性网卡，主IP地址不支持迁移。
        /// * 迁移前后的弹性网卡必须在同一个子网内。  
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
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
        /// 本接口 (ModifyAddressAttribute) 用于修改[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的名称。
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
        /// 本接口 (ModifyAddressAttribute) 用于修改[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）的名称。
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
        /// 该接口用于调整具有带宽属性弹性公网IP的网络计费模式
        /// * 支持BANDWIDTH_PREPAID_BY_MONTH和TRAFFIC_POSTPAID_BY_HOUR两种网络计费模式之间的切换。
        /// * 每个弹性公网IP支持调整两次，次数超出则无法调整。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressInternetChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyAddressInternetChargeTypeResponse"/></returns>
        public async Task<ModifyAddressInternetChargeTypeResponse> ModifyAddressInternetChargeType(ModifyAddressInternetChargeTypeRequest req)
        {
             JsonResponseModel<ModifyAddressInternetChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressInternetChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressInternetChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyAddressInternetChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressInternetChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressInternetChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateAttribute）用于修改IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public async Task<ModifyAddressTemplateAttributeResponse> ModifyAddressTemplateAttribute(ModifyAddressTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateAttribute）用于修改IP地址模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public ModifyAddressTemplateAttributeResponse ModifyAddressTemplateAttributeSync(ModifyAddressTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateGroupAttribute）用于修改IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public async Task<ModifyAddressTemplateGroupAttributeResponse> ModifyAddressTemplateGroupAttribute(ModifyAddressTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressTemplateGroupAttribute）用于修改IP地址模板集合。
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public ModifyAddressTemplateGroupAttributeResponse ModifyAddressTemplateGroupAttributeSync(ModifyAddressTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAddressesBandwidth）用于调整[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)(简称EIP)带宽，支持后付费EIP, 预付费EIP和带宽包EIP
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
        /// 本接口（ModifyAddressesBandwidth）用于调整[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)(简称EIP)带宽，支持后付费EIP, 预付费EIP和带宽包EIP
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
        /// 本接口（ModifyAssistantCidr）用于批量修改辅助CIDR，支持新增和删除。
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public async Task<ModifyAssistantCidrResponse> ModifyAssistantCidr(ModifyAssistantCidrRequest req)
        {
             JsonResponseModel<ModifyAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAssistantCidr）用于批量修改辅助CIDR，支持新增和删除。
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public ModifyAssistantCidrResponse ModifyAssistantCidrSync(ModifyAssistantCidrRequest req)
        {
             JsonResponseModel<ModifyAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于修改带宽包属性，包括带宽包名字等
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public async Task<ModifyBandwidthPackageAttributeResponse> ModifyBandwidthPackageAttribute(ModifyBandwidthPackageAttributeRequest req)
        {
             JsonResponseModel<ModifyBandwidthPackageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBandwidthPackageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBandwidthPackageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于修改带宽包属性，包括带宽包名字等
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public ModifyBandwidthPackageAttributeResponse ModifyBandwidthPackageAttributeSync(ModifyBandwidthPackageAttributeRequest req)
        {
             JsonResponseModel<ModifyBandwidthPackageAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBandwidthPackageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBandwidthPackageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CCN关联实例属性，目前仅修改备注description
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public async Task<ModifyCcnAttachedInstancesAttributeResponse> ModifyCcnAttachedInstancesAttribute(ModifyCcnAttachedInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcnAttachedInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CCN关联实例属性，目前仅修改备注description
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public ModifyCcnAttachedInstancesAttributeResponse ModifyCcnAttachedInstancesAttributeSync(ModifyCcnAttachedInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcnAttachedInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCcnAttribute）用于修改云联网（CCN）的相关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public async Task<ModifyCcnAttributeResponse> ModifyCcnAttribute(ModifyCcnAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcnAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCcnAttribute）用于修改云联网（CCN）的相关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public ModifyCcnAttributeResponse ModifyCcnAttributeSync(ModifyCcnAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcnAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCcnRegionBandwidthLimitsType）用于修改后付费云联网实例修改带宽限速策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public async Task<ModifyCcnRegionBandwidthLimitsTypeResponse> ModifyCcnRegionBandwidthLimitsType(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
             JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcnRegionBandwidthLimitsType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyCcnRegionBandwidthLimitsType）用于修改后付费云联网实例修改带宽限速策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public ModifyCcnRegionBandwidthLimitsTypeResponse ModifyCcnRegionBandwidthLimitsTypeSync(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
             JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcnRegionBandwidthLimitsType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse>>(strResp);
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
        /// 本接口（ModifyCustomerGatewayAttribute）用于修改对端网关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
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
        /// 本接口（ModifyDhcpIpAttribute）用于修改DhcpIp属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDhcpIpAttributeRequest"/></param>
        /// <returns><see cref="ModifyDhcpIpAttributeResponse"/></returns>
        public async Task<ModifyDhcpIpAttributeResponse> ModifyDhcpIpAttribute(ModifyDhcpIpAttributeRequest req)
        {
             JsonResponseModel<ModifyDhcpIpAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDhcpIpAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDhcpIpAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDhcpIpAttribute）用于修改DhcpIp属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDhcpIpAttributeRequest"/></param>
        /// <returns><see cref="ModifyDhcpIpAttributeResponse"/></returns>
        public ModifyDhcpIpAttributeResponse ModifyDhcpIpAttributeSync(ModifyDhcpIpAttributeRequest req)
        {
             JsonResponseModel<ModifyDhcpIpAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDhcpIpAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDhcpIpAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDirectConnectGatewayAttribute）用于修改专线网关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public async Task<ModifyDirectConnectGatewayAttributeResponse> ModifyDirectConnectGatewayAttribute(ModifyDirectConnectGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDirectConnectGatewayAttribute）用于修改专线网关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public ModifyDirectConnectGatewayAttributeResponse ModifyDirectConnectGatewayAttributeSync(ModifyDirectConnectGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDirectConnectGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyFlowLogAttribute）用于修改流日志属性
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest req)
        {
             JsonResponseModel<ModifyFlowLogAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFlowLogAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlowLogAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyFlowLogAttribute）用于修改流日志属性
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeSync(ModifyFlowLogAttributeRequest req)
        {
             JsonResponseModel<ModifyFlowLogAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFlowLogAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlowLogAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyGatewayFlowQos）用于调整网关流控带宽。
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public async Task<ModifyGatewayFlowQosResponse> ModifyGatewayFlowQos(ModifyGatewayFlowQosRequest req)
        {
             JsonResponseModel<ModifyGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyGatewayFlowQos）用于调整网关流控带宽。
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public ModifyGatewayFlowQosResponse ModifyGatewayFlowQosSync(ModifyGatewayFlowQosRequest req)
        {
             JsonResponseModel<ModifyGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyHaVipAttribute）用于修改高可用虚拟IP（HAVIP）属性。
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
        /// 本接口（ModifyHaVipAttribute）用于修改高可用虚拟IP（HAVIP）属性。
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
        /// 该接口用于修改IPV6地址访问internet的带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyIp6AddressesBandwidthResponse"/></returns>
        public async Task<ModifyIp6AddressesBandwidthResponse> ModifyIp6AddressesBandwidth(ModifyIp6AddressesBandwidthRequest req)
        {
             JsonResponseModel<ModifyIp6AddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIp6AddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6AddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改IPV6地址访问internet的带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyIp6AddressesBandwidthResponse"/></returns>
        public ModifyIp6AddressesBandwidthResponse ModifyIp6AddressesBandwidthSync(ModifyIp6AddressesBandwidthRequest req)
        {
             JsonResponseModel<ModifyIp6AddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIp6AddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6AddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改IPV6转换规则，当前仅支持修改转换规则名称，IPV4地址和IPV4端口号
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6RuleRequest"/></param>
        /// <returns><see cref="ModifyIp6RuleResponse"/></returns>
        public async Task<ModifyIp6RuleResponse> ModifyIp6Rule(ModifyIp6RuleRequest req)
        {
             JsonResponseModel<ModifyIp6RuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIp6Rule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6RuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改IPV6转换规则，当前仅支持修改转换规则名称，IPV4地址和IPV4端口号
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6RuleRequest"/></param>
        /// <returns><see cref="ModifyIp6RuleResponse"/></returns>
        public ModifyIp6RuleResponse ModifyIp6RuleSync(ModifyIp6RuleRequest req)
        {
             JsonResponseModel<ModifyIp6RuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIp6Rule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6RuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改IP6转换实例属性，当前仅支持修改实例名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6TranslatorRequest"/></param>
        /// <returns><see cref="ModifyIp6TranslatorResponse"/></returns>
        public async Task<ModifyIp6TranslatorResponse> ModifyIp6Translator(ModifyIp6TranslatorRequest req)
        {
             JsonResponseModel<ModifyIp6TranslatorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIp6Translator");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6TranslatorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改IP6转换实例属性，当前仅支持修改实例名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyIp6TranslatorRequest"/></param>
        /// <returns><see cref="ModifyIp6TranslatorResponse"/></returns>
        public ModifyIp6TranslatorResponse ModifyIp6TranslatorSync(ModifyIp6TranslatorRequest req)
        {
             JsonResponseModel<ModifyIp6TranslatorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIp6Translator");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIp6TranslatorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡内网IPv6地址属性。
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
        /// 本接口（ModifyIpv6AddressesAttribute）用于修改弹性网卡内网IPv6地址属性。
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
        /// 本接口（ModifyLocalGateway）用于修改CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public async Task<ModifyLocalGatewayResponse> ModifyLocalGateway(ModifyLocalGatewayRequest req)
        {
             JsonResponseModel<ModifyLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyLocalGateway）用于修改CDC的本地网关。
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public ModifyLocalGatewayResponse ModifyLocalGatewaySync(ModifyLocalGatewayRequest req)
        {
             JsonResponseModel<ModifyLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayAttribute）用于修改NAT网关的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public async Task<ModifyNatGatewayAttributeResponse> ModifyNatGatewayAttribute(ModifyNatGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyNatGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayAttribute）用于修改NAT网关的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public ModifyNatGatewayAttributeResponse ModifyNatGatewayAttributeSync(ModifyNatGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyNatGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayDestinationIpPortTranslationNatRule）用于修改NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public async Task<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> ModifyNatGatewayDestinationIpPortTranslationNatRule(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNatGatewayDestinationIpPortTranslationNatRule）用于修改NAT网关端口转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse ModifyNatGatewayDestinationIpPortTranslationNatRuleSync(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNatGatewaySourceIpTranslationNatRule）用于修改NAT网关SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public async Task<ModifyNatGatewaySourceIpTranslationNatRuleResponse> ModifyNatGatewaySourceIpTranslationNatRule(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNatGatewaySourceIpTranslationNatRule）用于修改NAT网关SNAT转发规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewaySourceIpTranslationNatRuleResponse ModifyNatGatewaySourceIpTranslationNatRuleSync(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyNetDetect)用于修改网络探测参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public async Task<ModifyNetDetectResponse> ModifyNetDetect(ModifyNetDetectRequest req)
        {
             JsonResponseModel<ModifyNetDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyNetDetect)用于修改网络探测参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public ModifyNetDetectResponse ModifyNetDetectSync(ModifyNetDetectRequest req)
        {
             JsonResponseModel<ModifyNetDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclAttribute）用于修改网络ACL属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public async Task<ModifyNetworkAclAttributeResponse> ModifyNetworkAclAttribute(ModifyNetworkAclAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkAclAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkAclAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclAttribute）用于修改网络ACL属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public ModifyNetworkAclAttributeResponse ModifyNetworkAclAttributeSync(ModifyNetworkAclAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkAclAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkAclAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclEntries）用于修改（包括添加和删除）网络ACL的入站规则和出站规则。在NetworkAclEntrySet参数中：
        /// * 若同时传入入站规则和出站规则，则重置原有的入站规则和出站规则，并分别导入传入的规则。
        /// * 若仅传入入站规则，则仅重置原有的入站规则，并导入传入的规则，不影响原有的出站规则（若仅传入出站规则，处理方式类似入站方向）。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclEntriesResponse"/></returns>
        public async Task<ModifyNetworkAclEntriesResponse> ModifyNetworkAclEntries(ModifyNetworkAclEntriesRequest req)
        {
             JsonResponseModel<ModifyNetworkAclEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkAclEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyNetworkAclEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkAclEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclQuintupleEntries）用于修改网络ACL五元组的入站规则和出站规则。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<ModifyNetworkAclQuintupleEntriesResponse> ModifyNetworkAclQuintupleEntries(ModifyNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkAclQuintupleEntries）用于修改网络ACL五元组的入站规则和出站规则。在NetworkAclQuintupleEntrySet参数中：NetworkAclQuintupleEntry需要提供NetworkAclQuintupleEntryId。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public ModifyNetworkAclQuintupleEntriesResponse ModifyNetworkAclQuintupleEntriesSync(ModifyNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceAttribute）用于修改弹性网卡属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public async Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkInterfaceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkInterfaceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkInterfaceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceAttribute）用于修改弹性网卡属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttributeSync(ModifyNetworkInterfaceAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkInterfaceAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkInterfaceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkInterfaceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceQos）用于修改弹性网卡服务质量。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceQosRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceQosResponse"/></returns>
        public async Task<ModifyNetworkInterfaceQosResponse> ModifyNetworkInterfaceQos(ModifyNetworkInterfaceQosRequest req)
        {
             JsonResponseModel<ModifyNetworkInterfaceQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkInterfaceQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkInterfaceQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyNetworkInterfaceQos）用于修改弹性网卡服务质量。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceQosRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceQosResponse"/></returns>
        public ModifyNetworkInterfaceQosResponse ModifyNetworkInterfaceQosSync(ModifyNetworkInterfaceQosRequest req)
        {
             JsonResponseModel<ModifyNetworkInterfaceQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkInterfaceQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkInterfaceQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyPrivateIpAddressesAttribute）用于修改弹性网卡内网IP属性。
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
        /// 本接口（ModifyPrivateIpAddressesAttribute）用于修改弹性网卡内网IP属性。
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
        /// 本接口（ModifyRouteTableAttribute）用于修改路由表（RouteTable）属性。
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
        /// 本接口（ModifyRouteTableAttribute）用于修改路由表（RouteTable）属性。
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
        /// 本接口（ModifySecurityGroupAttribute）用于修改安全组（SecurityGroupPolicy）属性。
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
        /// 本接口（ModifySecurityGroupAttribute）用于修改安全组（SecurityGroupPolicy）属性。
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
        /// 本接口（ModifySecurityGroupPolicies）用于重置安全组出站和入站规则（SecurityGroupPolicy）。
        /// 
        /// <ul>
        /// <li>该接口不支持自定义索引 PolicyIndex。</li>
        /// <li>在 SecurityGroupPolicySet 参数中：<ul>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 为0, 表示清空所有规则，并忽略 Egress 和 Ingress。</li>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 不为0, 在添加出站和入站规则（Egress 和 Ingress）时：<ul>
        /// 		<li>Protocol 字段支持输入 TCP, UDP, ICMP, ICMPV6, GRE, ALL。</li>
        /// 		<li>CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。(展开)在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// 		<li>Ipv6CidrBlock 字段允许输入符合 IPv6 cidr 格式标准的任意字符串。(展开)在基础网络中，如果Ipv6CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// 		<li>SecurityGroupId 字段允许输入与待修改的安全组位于相同项目中的安全组 ID，包括这个安全组 ID 本身，代表安全组下所有云服务器的内网 IP。使用这个字段时，这条规则用来匹配网络报文的过程中会随着被使用的这个ID所关联的云服务器变化而变化，不需要重新修改。</li>
        /// 		<li>Port 字段允许输入一个单独端口号，或者用减号分隔的两个端口号代表端口范围，例如80或8000-8010。只有当 Protocol 字段是 TCP 或 UDP 时，Port 字段才被接受。</li>
        /// 		<li>Action 字段只允许输入 ACCEPT 或 DROP。</li>
        /// 		<li>CidrBlock, Ipv6CidrBlock, SecurityGroupId, AddressTemplate 四者是排他关系，不允许同时输入，Protocol + Port 和 ServiceTemplate 二者是排他关系，不允许同时输入。</li>
        /// </ul></li></ul></li>
        /// </ul>
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
        /// 本接口（ModifySecurityGroupPolicies）用于重置安全组出站和入站规则（SecurityGroupPolicy）。
        /// 
        /// <ul>
        /// <li>该接口不支持自定义索引 PolicyIndex。</li>
        /// <li>在 SecurityGroupPolicySet 参数中：<ul>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 为0, 表示清空所有规则，并忽略 Egress 和 Ingress。</li>
        /// 	<li> 如果指定 SecurityGroupPolicySet.Version 不为0, 在添加出站和入站规则（Egress 和 Ingress）时：<ul>
        /// 		<li>Protocol 字段支持输入 TCP, UDP, ICMP, ICMPV6, GRE, ALL。</li>
        /// 		<li>CidrBlock 字段允许输入符合 cidr 格式标准的任意字符串。(展开)在基础网络中，如果 CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IP，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
        /// 		<li>Ipv6CidrBlock 字段允许输入符合 IPv6 cidr 格式标准的任意字符串。(展开)在基础网络中，如果Ipv6CidrBlock 包含您的账户内的云服务器之外的设备在腾讯云的内网 IPv6，并不代表此规则允许您访问这些设备，租户之间网络隔离规则优先于安全组中的内网规则。</li>
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
        /// 本接口（ModifyServiceTemplateAttribute）用于修改协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public async Task<ModifyServiceTemplateAttributeResponse> ModifyServiceTemplateAttribute(ModifyServiceTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateAttribute）用于修改协议端口模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public ModifyServiceTemplateAttributeResponse ModifyServiceTemplateAttributeSync(ModifyServiceTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateGroupAttribute）用于修改协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public async Task<ModifyServiceTemplateGroupAttributeResponse> ModifyServiceTemplateGroupAttribute(ModifyServiceTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyServiceTemplateGroupAttribute）用于修改协议端口模板集合。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public ModifyServiceTemplateGroupAttributeResponse ModifyServiceTemplateGroupAttributeSync(ModifyServiceTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySnapshotPolicies）用于修改快照策略。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public async Task<ModifySnapshotPoliciesResponse> ModifySnapshotPolicies(ModifySnapshotPoliciesRequest req)
        {
             JsonResponseModel<ModifySnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySnapshotPolicies）用于修改快照策略。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public ModifySnapshotPoliciesResponse ModifySnapshotPoliciesSync(ModifySnapshotPoliciesRequest req)
        {
             JsonResponseModel<ModifySnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySubnetAttribute）用于修改子网属性。
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
        /// 本接口（ModifySubnetAttribute）用于修改子网属性。
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
        /// 修改模板对象中的IP地址、协议端口、IP地址组、协议端口组。当前仅支持北京、泰国、北美地域请求。
        /// </summary>
        /// <param name="req"><see cref="ModifyTemplateMemberRequest"/></param>
        /// <returns><see cref="ModifyTemplateMemberResponse"/></returns>
        public async Task<ModifyTemplateMemberResponse> ModifyTemplateMember(ModifyTemplateMemberRequest req)
        {
             JsonResponseModel<ModifyTemplateMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTemplateMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTemplateMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改模板对象中的IP地址、协议端口、IP地址组、协议端口组。当前仅支持北京、泰国、北美地域请求。
        /// </summary>
        /// <param name="req"><see cref="ModifyTemplateMemberRequest"/></param>
        /// <returns><see cref="ModifyTemplateMemberResponse"/></returns>
        public ModifyTemplateMemberResponse ModifyTemplateMemberSync(ModifyTemplateMemberRequest req)
        {
             JsonResponseModel<ModifyTemplateMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTemplateMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTemplateMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcAttribute）用于修改私有网络（VPC）的相关属性。
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
        /// 本接口（ModifyVpcAttribute）用于修改私有网络（VPC）的相关属性。
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
        /// 本接口（ModifyVpcEndPointAttribute）用于修改终端节点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public async Task<ModifyVpcEndPointAttributeResponse> ModifyVpcEndPointAttribute(ModifyVpcEndPointAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcEndPointAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointAttribute）用于修改终端节点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public ModifyVpcEndPointAttributeResponse ModifyVpcEndPointAttributeSync(ModifyVpcEndPointAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcEndPointAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceAttribute）用于修改终端节点服务属性。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public async Task<ModifyVpcEndPointServiceAttributeResponse> ModifyVpcEndPointServiceAttribute(ModifyVpcEndPointServiceAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcEndPointServiceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceAttribute）用于修改终端节点服务属性。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public ModifyVpcEndPointServiceAttributeResponse ModifyVpcEndPointServiceAttributeSync(ModifyVpcEndPointServiceAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcEndPointServiceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceWhiteList）用于修改终端节点服务白名单属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<ModifyVpcEndPointServiceWhiteListResponse> ModifyVpcEndPointServiceWhiteList(ModifyVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpcEndPointServiceWhiteList）用于修改终端节点服务白名单属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public ModifyVpcEndPointServiceWhiteListResponse ModifyVpcEndPointServiceWhiteListSync(ModifyVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse>>(strResp);
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
        /// 本接口（ModifyVpnConnectionAttribute）用于修改VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
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
        /// 本接口（ModifyVpnGatewayAttribute）用于修改VPN网关属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
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
        /// 本接口（ModifyVpnGatewayCcnRoutes）用于修改VPN网关云联网路由
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public async Task<ModifyVpnGatewayCcnRoutesResponse> ModifyVpnGatewayCcnRoutes(ModifyVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyVpnGatewayCcnRoutes）用于修改VPN网关云联网路由
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public ModifyVpnGatewayCcnRoutesResponse ModifyVpnGatewayCcnRoutesSync(ModifyVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改VPN路由是否启用
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public async Task<ModifyVpnGatewayRoutesResponse> ModifyVpnGatewayRoutes(ModifyVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改VPN路由是否启用
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public ModifyVpnGatewayRoutesResponse ModifyVpnGatewayRoutesSync(ModifyVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（NotifyRoutes）用于路由表列表页操作增加“发布到云联网”，发布路由到云联网。
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public async Task<NotifyRoutesResponse> NotifyRoutes(NotifyRoutesRequest req)
        {
             JsonResponseModel<NotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "NotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<NotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（NotifyRoutes）用于路由表列表页操作增加“发布到云联网”，发布路由到云联网。
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public NotifyRoutesResponse NotifyRoutesSync(NotifyRoutesRequest req)
        {
             JsonResponseModel<NotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "NotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<NotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新专线直连nat路由，更新nat到专线的路由表
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public async Task<RefreshDirectConnectGatewayRouteToNatGatewayResponse> RefreshDirectConnectGatewayRouteToNatGateway(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
             JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefreshDirectConnectGatewayRouteToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新专线直连nat路由，更新nat到专线的路由表
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public RefreshDirectConnectGatewayRouteToNatGatewayResponse RefreshDirectConnectGatewayRouteToNatGatewaySync(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
             JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefreshDirectConnectGatewayRouteToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RejectAttachCcnInstances）用于跨账号关联实例时，云联网所有者拒绝关联操作。
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public async Task<RejectAttachCcnInstancesResponse> RejectAttachCcnInstances(RejectAttachCcnInstancesRequest req)
        {
             JsonResponseModel<RejectAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RejectAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RejectAttachCcnInstances）用于跨账号关联实例时，云联网所有者拒绝关联操作。
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public RejectAttachCcnInstancesResponse RejectAttachCcnInstancesSync(RejectAttachCcnInstancesRequest req)
        {
             JsonResponseModel<RejectAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RejectAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ReleaseAddresses) 用于释放一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// * 只有状态为 UNBIND 的 EIP 才能进行释放操作。
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
        /// 本接口 (ReleaseAddresses) 用于释放一个或多个[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 该操作不可逆，释放后 EIP 关联的 IP 地址将不再属于您的名下。
        /// * 只有状态为 UNBIND 的 EIP 才能进行释放操作。
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
        /// 该接口用于给弹性公网IPv6地址释放带宽。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ReleaseIp6AddressesBandwidthResponse"/></returns>
        public async Task<ReleaseIp6AddressesBandwidthResponse> ReleaseIp6AddressesBandwidth(ReleaseIp6AddressesBandwidthRequest req)
        {
             JsonResponseModel<ReleaseIp6AddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseIp6AddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIp6AddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于给弹性公网IPv6地址释放带宽。
        /// </summary>
        /// <param name="req"><see cref="ReleaseIp6AddressesBandwidthRequest"/></param>
        /// <returns><see cref="ReleaseIp6AddressesBandwidthResponse"/></returns>
        public ReleaseIp6AddressesBandwidthResponse ReleaseIp6AddressesBandwidthSync(ReleaseIp6AddressesBandwidthRequest req)
        {
             JsonResponseModel<ReleaseIp6AddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseIp6AddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIp6AddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于删除带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public async Task<RemoveBandwidthPackageResourcesResponse> RemoveBandwidthPackageResources(RemoveBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<RemoveBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口用于删除带宽包资源，包括[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)和[负载均衡](https://cloud.tencent.com/document/product/214/517)等
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public RemoveBandwidthPackageResourcesResponse RemoveBandwidthPackageResourcesSync(RemoveBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<RemoveBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于删除IPV6转换规则
        /// 2. 支持批量删除同一个转换实例下的多个转换规则
        /// </summary>
        /// <param name="req"><see cref="RemoveIp6RulesRequest"/></param>
        /// <returns><see cref="RemoveIp6RulesResponse"/></returns>
        public async Task<RemoveIp6RulesResponse> RemoveIp6Rules(RemoveIp6RulesRequest req)
        {
             JsonResponseModel<RemoveIp6RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveIp6Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveIp6RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 1. 该接口用于删除IPV6转换规则
        /// 2. 支持批量删除同一个转换实例下的多个转换规则
        /// </summary>
        /// <param name="req"><see cref="RemoveIp6RulesRequest"/></param>
        /// <returns><see cref="RemoveIp6RulesResponse"/></returns>
        public RemoveIp6RulesResponse RemoveIp6RulesSync(RemoveIp6RulesRequest req)
        {
             JsonResponseModel<RemoveIp6RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveIp6Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveIp6RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于续费包月带宽计费模式的弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="RenewAddressesRequest"/></param>
        /// <returns><see cref="RenewAddressesResponse"/></returns>
        public async Task<RenewAddressesResponse> RenewAddresses(RenewAddressesRequest req)
        {
             JsonResponseModel<RenewAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于续费包月带宽计费模式的弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="RenewAddressesRequest"/></param>
        /// <returns><see cref="RenewAddressesResponse"/></returns>
        public RenewAddressesResponse RenewAddressesSync(RenewAddressesRequest req)
        {
             JsonResponseModel<RenewAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewVpnGateway）用于预付费（包年包月）VPN网关续费。目前只支持IPSEC网关。
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public async Task<RenewVpnGatewayResponse> RenewVpnGateway(RenewVpnGatewayRequest req)
        {
             JsonResponseModel<RenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewVpnGateway）用于预付费（包年包月）VPN网关续费。目前只支持IPSEC网关。
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public RenewVpnGatewayResponse RenewVpnGatewaySync(RenewVpnGatewayRequest req)
        {
             JsonResponseModel<RenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceDirectConnectGatewayCcnRoutes）根据路由ID（RouteId）修改指定的路由（Route），支持批量修改。
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<ReplaceDirectConnectGatewayCcnRoutesResponse> ReplaceDirectConnectGatewayCcnRoutes(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceDirectConnectGatewayCcnRoutes）根据路由ID（RouteId）修改指定的路由（Route），支持批量修改。
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public ReplaceDirectConnectGatewayCcnRoutesResponse ReplaceDirectConnectGatewayCcnRoutesSync(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceRouteTableAssociation）用于修改子网（Subnet）关联的路由表（RouteTable）。
        /// * 一个子网只能关联一个路由表。
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
        /// 本接口（ReplaceRouteTableAssociation）用于修改子网（Subnet）关联的路由表（RouteTable）。
        /// * 一个子网只能关联一个路由表。
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
        /// 本接口（ReplaceRoutes）根据路由策略ID（RouteId）修改指定的路由策略（Route），支持批量修改。
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
        /// 本接口（ReplaceRoutes）根据路由策略ID（RouteId）修改指定的路由策略（Route），支持批量修改。
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
        /// 本接口（ReplaceSecurityGroupPolicies）用于批量修改安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条或多条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPoliciesResponse"/></returns>
        public async Task<ReplaceSecurityGroupPoliciesResponse> ReplaceSecurityGroupPolicies(ReplaceSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<ReplaceSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceSecurityGroupPolicies）用于批量修改安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条或多条规则, 必须要指定索引（PolicyIndex）。
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPoliciesResponse"/></returns>
        public ReplaceSecurityGroupPoliciesResponse ReplaceSecurityGroupPoliciesSync(ReplaceSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<ReplaceSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceSecurityGroupPolicy）用于替换单条安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
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
        /// 本接口（ReplaceSecurityGroupPolicy）用于替换单条安全组规则（SecurityGroupPolicy）。
        /// 单个请求中只能替换单个方向的一条规则, 必须要指定索引（PolicyIndex）。
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
        /// 本接口（ResetAttachCcnInstances）用于跨账号关联实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public async Task<ResetAttachCcnInstancesResponse> ResetAttachCcnInstances(ResetAttachCcnInstancesRequest req)
        {
             JsonResponseModel<ResetAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetAttachCcnInstances）用于跨账号关联实例申请过期时，重新申请关联操作。
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public ResetAttachCcnInstancesResponse ResetAttachCcnInstancesSync(ResetAttachCcnInstancesRequest req)
        {
             JsonResponseModel<ResetAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetNatGatewayConnection）用来NAT网关并发连接上限。
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public async Task<ResetNatGatewayConnectionResponse> ResetNatGatewayConnection(ResetNatGatewayConnectionRequest req)
        {
             JsonResponseModel<ResetNatGatewayConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetNatGatewayConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetNatGatewayConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetNatGatewayConnection）用来NAT网关并发连接上限。
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public ResetNatGatewayConnectionResponse ResetNatGatewayConnectionSync(ResetNatGatewayConnectionRequest req)
        {
             JsonResponseModel<ResetNatGatewayConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetNatGatewayConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetNatGatewayConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetRoutes）用于对某个路由表名称和所有路由策略（Route）进行重新设置。<br />
        /// 注意: 调用本接口是先删除当前路由表中所有路由策略, 再保存新提交的路由策略内容, 会引起网络中断。
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
        /// 本接口（ResetRoutes）用于对某个路由表名称和所有路由策略（Route）进行重新设置。<br />
        /// 注意: 调用本接口是先删除当前路由表中所有路由策略, 再保存新提交的路由策略内容, 会引起网络中断。
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
        /// 本接口(ResetVpnConnection)用于重置VPN通道。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
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
        /// 本接口（ResetVpnGatewayInternetMaxBandwidth）调整VPN网关带宽上限。目前支持升级配置，如果是包年包月VPN网关需要在有效期内。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public async Task<ResetVpnGatewayInternetMaxBandwidthResponse> ResetVpnGatewayInternetMaxBandwidth(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetVpnGatewayInternetMaxBandwidth）调整VPN网关带宽上限。目前支持升级配置，如果是包年包月VPN网关需要在有效期内。
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public ResetVpnGatewayInternetMaxBandwidthResponse ResetVpnGatewayInternetMaxBandwidthSync(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResumeSnapshotInstance）用于根据备份内容恢复安全组策略。
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public async Task<ResumeSnapshotInstanceResponse> ResumeSnapshotInstance(ResumeSnapshotInstanceRequest req)
        {
             JsonResponseModel<ResumeSnapshotInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeSnapshotInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSnapshotInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResumeSnapshotInstance）用于根据备份内容恢复安全组策略。
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public ResumeSnapshotInstanceResponse ResumeSnapshotInstanceSync(ResumeSnapshotInstanceRequest req)
        {
             JsonResponseModel<ResumeSnapshotInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeSnapshotInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSnapshotInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReturnNormalAddresses）用于解绑并释放普通公网IP。
        /// 为完善公网IP的访问管理功能，此接口于2022年12月15日升级优化鉴权功能，升级后子用户调用此接口需向主账号申请CAM策略授权，否则可能调用失败。您可以提前为子账号配置操作授权，详情见[授权指南](https://cloud.tencent.com/document/product/598/34545)。
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public async Task<ReturnNormalAddressesResponse> ReturnNormalAddresses(ReturnNormalAddressesRequest req)
        {
             JsonResponseModel<ReturnNormalAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReturnNormalAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReturnNormalAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReturnNormalAddresses）用于解绑并释放普通公网IP。
        /// 为完善公网IP的访问管理功能，此接口于2022年12月15日升级优化鉴权功能，升级后子用户调用此接口需向主账号申请CAM策略授权，否则可能调用失败。您可以提前为子账号配置操作授权，详情见[授权指南](https://cloud.tencent.com/document/product/598/34545)。
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public ReturnNormalAddressesResponse ReturnNormalAddressesSync(ReturnNormalAddressesRequest req)
        {
             JsonResponseModel<ReturnNormalAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReturnNormalAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReturnNormalAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetCcnRegionBandwidthLimits）用于设置云联网（CCN）各地域出带宽上限，或者地域间带宽上限。
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public async Task<SetCcnRegionBandwidthLimitsResponse> SetCcnRegionBandwidthLimits(SetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<SetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetCcnRegionBandwidthLimits）用于设置云联网（CCN）各地域出带宽上限，或者地域间带宽上限。
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public SetCcnRegionBandwidthLimitsResponse SetCcnRegionBandwidthLimitsSync(SetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<SetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置VPNGW续费标记
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public async Task<SetVpnGatewaysRenewFlagResponse> SetVpnGatewaysRenewFlag(SetVpnGatewaysRenewFlagRequest req)
        {
             JsonResponseModel<SetVpnGatewaysRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetVpnGatewaysRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVpnGatewaysRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置VPNGW续费标记
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public SetVpnGatewaysRenewFlagResponse SetVpnGatewaysRenewFlagSync(SetVpnGatewaysRenewFlagRequest req)
        {
             JsonResponseModel<SetVpnGatewaysRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetVpnGatewaysRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVpnGatewaysRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TransformAddress) 用于将实例的普通公网 IP 转换为[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 平台对用户每地域每日解绑 EIP 重新分配普通公网 IP 次数有所限制（可参见 [EIP 产品简介](/document/product/213/1941)）。上述配额可通过 [DescribeAddressQuota](https://cloud.tencent.com/document/api/213/1378) 接口获取。
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public async Task<TransformAddressResponse> TransformAddress(TransformAddressRequest req)
        {
             JsonResponseModel<TransformAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransformAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransformAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (TransformAddress) 用于将实例的普通公网 IP 转换为[弹性公网IP](https://cloud.tencent.com/document/product/213/1941)（简称 EIP）。
        /// * 平台对用户每地域每日解绑 EIP 重新分配普通公网 IP 次数有所限制（可参见 [EIP 产品简介](/document/product/213/1941)）。上述配额可通过 [DescribeAddressQuota](https://cloud.tencent.com/document/api/213/1378) 接口获取。
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public TransformAddressResponse TransformAddressSync(TransformAddressRequest req)
        {
             JsonResponseModel<TransformAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransformAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransformAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public async Task<UnassignIpv6AddressesResponse> UnassignIpv6Addresses(UnassignIpv6AddressesRequest req)
        {
             JsonResponseModel<UnassignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6Addresses）用于释放弹性网卡`IPv6`地址。<br />
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public UnassignIpv6AddressesResponse UnassignIpv6AddressesSync(UnassignIpv6AddressesRequest req)
        {
             JsonResponseModel<UnassignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6CidrBlock）用于释放IPv6网段。<br />
        /// 网段如果还有IP占用且未回收，则网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public async Task<UnassignIpv6CidrBlockResponse> UnassignIpv6CidrBlock(UnassignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6CidrBlock）用于释放IPv6网段。<br />
        /// 网段如果还有IP占用且未回收，则网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public UnassignIpv6CidrBlockResponse UnassignIpv6CidrBlockSync(UnassignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6SubnetCidrBlock）用于释放IPv6子网段。<br />
        /// 子网段如果还有IP占用且未回收，则子网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public async Task<UnassignIpv6SubnetCidrBlockResponse> UnassignIpv6SubnetCidrBlock(UnassignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignIpv6SubnetCidrBlock）用于释放IPv6子网段。<br />
        /// 子网段如果还有IP占用且未回收，则子网段无法释放。
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public UnassignIpv6SubnetCidrBlockResponse UnassignIpv6SubnetCidrBlockSync(UnassignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnassignPrivateIpAddresses）用于弹性网卡退还内网 IP。
        /// * 退还弹性网卡上的辅助内网IP，接口自动解关联弹性公网 IP。不能退还弹性网卡的主内网IP。
        /// 
        /// 本接口是异步完成，如需查询异步任务执行结果，请使用本接口返回的`RequestId`轮询`DescribeVpcTaskResult`接口。
        /// </summary>
        /// <param name="req"><see cref="UnassignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="UnassignPrivateIpAddressesResponse"/></returns>
        public async Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<UnassignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<UnassignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnlockCcnBandwidths）用户解锁云联网限速实例。
        /// 该接口一般用来封禁地域间限速的云联网实例下的限速实例, 目前联通内部运营系统通过云API调用, 如果是出口限速, 一般使用更粗的云联网实例粒度封禁（SecurityUnlockCcns）。
        /// 如有需要, 可以封禁任意限速实例, 可接入到内部运营系统。
        /// </summary>
        /// <param name="req"><see cref="UnlockCcnBandwidthsRequest"/></param>
        /// <returns><see cref="UnlockCcnBandwidthsResponse"/></returns>
        public async Task<UnlockCcnBandwidthsResponse> UnlockCcnBandwidths(UnlockCcnBandwidthsRequest req)
        {
             JsonResponseModel<UnlockCcnBandwidthsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnlockCcnBandwidths");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockCcnBandwidthsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<UnlockCcnBandwidthsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnlockCcnBandwidths");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockCcnBandwidthsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<UnlockCcnsResponse> UnlockCcns(UnlockCcnsRequest req)
        {
             JsonResponseModel<UnlockCcnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnlockCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<UnlockCcnsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnlockCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（WithdrawNotifyRoutes）用于撤销已发布到云联网的路由。路由表列表页操作增加“从云联网撤销”。
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public async Task<WithdrawNotifyRoutesResponse> WithdrawNotifyRoutes(WithdrawNotifyRoutesRequest req)
        {
             JsonResponseModel<WithdrawNotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WithdrawNotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WithdrawNotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（WithdrawNotifyRoutes）用于撤销已发布到云联网的路由。路由表列表页操作增加“从云联网撤销”。
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public WithdrawNotifyRoutesResponse WithdrawNotifyRoutesSync(WithdrawNotifyRoutesRequest req)
        {
             JsonResponseModel<WithdrawNotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "WithdrawNotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WithdrawNotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
