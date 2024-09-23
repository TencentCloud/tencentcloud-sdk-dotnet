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

namespace TencentCloud.Bmlb.V20180625
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bmlb.V20180625.Models;

   public class BmlbClient : AbstractClient{

       private const string endpoint = "bmlb.tencentcloudapi.com";
       private const string version = "2018-06-25";
       private const string sdkVersion = "SDK_NET_3.0.1093";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmlbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmlbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 绑定黑石服务器到四层监听器。服务器包括物理服务器、虚拟机以及半托管机器。
        /// </summary>
        /// <param name="req"><see cref="BindL4BackendsRequest"/></param>
        /// <returns><see cref="BindL4BackendsResponse"/></returns>
        public Task<BindL4BackendsResponse> BindL4Backends(BindL4BackendsRequest req)
        {
            return InternalRequestAsync<BindL4BackendsResponse>(req, "BindL4Backends");
        }

        /// <summary>
        /// 绑定黑石服务器到四层监听器。服务器包括物理服务器、虚拟机以及半托管机器。
        /// </summary>
        /// <param name="req"><see cref="BindL4BackendsRequest"/></param>
        /// <returns><see cref="BindL4BackendsResponse"/></returns>
        public BindL4BackendsResponse BindL4BackendsSync(BindL4BackendsRequest req)
        {
            return InternalRequestAsync<BindL4BackendsResponse>(req, "BindL4Backends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定黑石物理服务器或半托管服务器到七层转发路径。
        /// </summary>
        /// <param name="req"><see cref="BindL7BackendsRequest"/></param>
        /// <returns><see cref="BindL7BackendsResponse"/></returns>
        public Task<BindL7BackendsResponse> BindL7Backends(BindL7BackendsRequest req)
        {
            return InternalRequestAsync<BindL7BackendsResponse>(req, "BindL7Backends");
        }

        /// <summary>
        /// 绑定黑石物理服务器或半托管服务器到七层转发路径。
        /// </summary>
        /// <param name="req"><see cref="BindL7BackendsRequest"/></param>
        /// <returns><see cref="BindL7BackendsResponse"/></returns>
        public BindL7BackendsResponse BindL7BackendsSync(BindL7BackendsRequest req)
        {
            return InternalRequestAsync<BindL7BackendsResponse>(req, "BindL7Backends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定黑石服务器七层监听器到流量镜像实例。
        /// </summary>
        /// <param name="req"><see cref="BindTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="BindTrafficMirrorListenersResponse"/></returns>
        public Task<BindTrafficMirrorListenersResponse> BindTrafficMirrorListeners(BindTrafficMirrorListenersRequest req)
        {
            return InternalRequestAsync<BindTrafficMirrorListenersResponse>(req, "BindTrafficMirrorListeners");
        }

        /// <summary>
        /// 绑定黑石服务器七层监听器到流量镜像实例。
        /// </summary>
        /// <param name="req"><see cref="BindTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="BindTrafficMirrorListenersResponse"/></returns>
        public BindTrafficMirrorListenersResponse BindTrafficMirrorListenersSync(BindTrafficMirrorListenersRequest req)
        {
            return InternalRequestAsync<BindTrafficMirrorListenersResponse>(req, "BindTrafficMirrorListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定黑石物理服务器成为流量镜像接收机。
        /// </summary>
        /// <param name="req"><see cref="BindTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="BindTrafficMirrorReceiversResponse"/></returns>
        public Task<BindTrafficMirrorReceiversResponse> BindTrafficMirrorReceivers(BindTrafficMirrorReceiversRequest req)
        {
            return InternalRequestAsync<BindTrafficMirrorReceiversResponse>(req, "BindTrafficMirrorReceivers");
        }

        /// <summary>
        /// 绑定黑石物理服务器成为流量镜像接收机。
        /// </summary>
        /// <param name="req"><see cref="BindTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="BindTrafficMirrorReceiversResponse"/></returns>
        public BindTrafficMirrorReceiversResponse BindTrafficMirrorReceiversSync(BindTrafficMirrorReceiversRequest req)
        {
            return InternalRequestAsync<BindTrafficMirrorReceiversResponse>(req, "BindTrafficMirrorReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石四层负载均衡监听器功能。黑石负载均衡四层监听器提供了转发用户请求的具体规则，包括端口、协议、会话保持、健康检查等参数。
        /// </summary>
        /// <param name="req"><see cref="CreateL4ListenersRequest"/></param>
        /// <returns><see cref="CreateL4ListenersResponse"/></returns>
        public Task<CreateL4ListenersResponse> CreateL4Listeners(CreateL4ListenersRequest req)
        {
            return InternalRequestAsync<CreateL4ListenersResponse>(req, "CreateL4Listeners");
        }

        /// <summary>
        /// 创建黑石四层负载均衡监听器功能。黑石负载均衡四层监听器提供了转发用户请求的具体规则，包括端口、协议、会话保持、健康检查等参数。
        /// </summary>
        /// <param name="req"><see cref="CreateL4ListenersRequest"/></param>
        /// <returns><see cref="CreateL4ListenersResponse"/></returns>
        public CreateL4ListenersResponse CreateL4ListenersSync(CreateL4ListenersRequest req)
        {
            return InternalRequestAsync<CreateL4ListenersResponse>(req, "CreateL4Listeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石负载均衡七层监听器功能。负载均衡七层监听器提供了转发用户请求的具体规则，包括端口、协议等参数。
        /// </summary>
        /// <param name="req"><see cref="CreateL7ListenersRequest"/></param>
        /// <returns><see cref="CreateL7ListenersResponse"/></returns>
        public Task<CreateL7ListenersResponse> CreateL7Listeners(CreateL7ListenersRequest req)
        {
            return InternalRequestAsync<CreateL7ListenersResponse>(req, "CreateL7Listeners");
        }

        /// <summary>
        /// 创建黑石负载均衡七层监听器功能。负载均衡七层监听器提供了转发用户请求的具体规则，包括端口、协议等参数。
        /// </summary>
        /// <param name="req"><see cref="CreateL7ListenersRequest"/></param>
        /// <returns><see cref="CreateL7ListenersResponse"/></returns>
        public CreateL7ListenersResponse CreateL7ListenersSync(CreateL7ListenersRequest req)
        {
            return InternalRequestAsync<CreateL7ListenersResponse>(req, "CreateL7Listeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public Task<CreateL7RulesResponse> CreateL7Rules(CreateL7RulesRequest req)
        {
            return InternalRequestAsync<CreateL7RulesResponse>(req, "CreateL7Rules");
        }

        /// <summary>
        /// 创建黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public CreateL7RulesResponse CreateL7RulesSync(CreateL7RulesRequest req)
        {
            return InternalRequestAsync<CreateL7RulesResponse>(req, "CreateL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用来创建黑石负载均衡。为了使用黑石负载均衡服务，您必须要创建一个或者多个负载均衡实例。通过成功调用该接口，会返回负载均衡实例的唯一ID。用户可以购买的黑石负载均衡实例类型分为：公网类型、内网类型。公网类型负载均衡对应一个BGP VIP，可用于快速访问公网负载均衡绑定的物理服务器；内网类型负载均衡对应一个腾讯云内部的VIP，不能通过Internet访问，可快速访问内网负载均衡绑定的物理服务器。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancersRequest"/></param>
        /// <returns><see cref="CreateLoadBalancersResponse"/></returns>
        public Task<CreateLoadBalancersResponse> CreateLoadBalancers(CreateLoadBalancersRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancersResponse>(req, "CreateLoadBalancers");
        }

        /// <summary>
        /// 用来创建黑石负载均衡。为了使用黑石负载均衡服务，您必须要创建一个或者多个负载均衡实例。通过成功调用该接口，会返回负载均衡实例的唯一ID。用户可以购买的黑石负载均衡实例类型分为：公网类型、内网类型。公网类型负载均衡对应一个BGP VIP，可用于快速访问公网负载均衡绑定的物理服务器；内网类型负载均衡对应一个腾讯云内部的VIP，不能通过Internet访问，可快速访问内网负载均衡绑定的物理服务器。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancersRequest"/></param>
        /// <returns><see cref="CreateLoadBalancersResponse"/></returns>
        public CreateLoadBalancersResponse CreateLoadBalancersSync(CreateLoadBalancersRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancersResponse>(req, "CreateLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建流量镜像实例。
        /// </summary>
        /// <param name="req"><see cref="CreateTrafficMirrorRequest"/></param>
        /// <returns><see cref="CreateTrafficMirrorResponse"/></returns>
        public Task<CreateTrafficMirrorResponse> CreateTrafficMirror(CreateTrafficMirrorRequest req)
        {
            return InternalRequestAsync<CreateTrafficMirrorResponse>(req, "CreateTrafficMirror");
        }

        /// <summary>
        /// 创建流量镜像实例。
        /// </summary>
        /// <param name="req"><see cref="CreateTrafficMirrorRequest"/></param>
        /// <returns><see cref="CreateTrafficMirrorResponse"/></returns>
        public CreateTrafficMirrorResponse CreateTrafficMirrorSync(CreateTrafficMirrorRequest req)
        {
            return InternalRequestAsync<CreateTrafficMirrorResponse>(req, "CreateTrafficMirror")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除黑石负载均衡七层转发域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7DomainsRequest"/></param>
        /// <returns><see cref="DeleteL7DomainsResponse"/></returns>
        public Task<DeleteL7DomainsResponse> DeleteL7Domains(DeleteL7DomainsRequest req)
        {
            return InternalRequestAsync<DeleteL7DomainsResponse>(req, "DeleteL7Domains");
        }

        /// <summary>
        /// 删除黑石负载均衡七层转发域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7DomainsRequest"/></param>
        /// <returns><see cref="DeleteL7DomainsResponse"/></returns>
        public DeleteL7DomainsResponse DeleteL7DomainsSync(DeleteL7DomainsRequest req)
        {
            return InternalRequestAsync<DeleteL7DomainsResponse>(req, "DeleteL7Domains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public Task<DeleteL7RulesResponse> DeleteL7Rules(DeleteL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteL7RulesResponse>(req, "DeleteL7Rules");
        }

        /// <summary>
        /// 删除黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public DeleteL7RulesResponse DeleteL7RulesSync(DeleteL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteL7RulesResponse>(req, "DeleteL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除黑石负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public Task<DeleteListenersResponse> DeleteListeners(DeleteListenersRequest req)
        {
            return InternalRequestAsync<DeleteListenersResponse>(req, "DeleteListeners");
        }

        /// <summary>
        /// 删除黑石负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public DeleteListenersResponse DeleteListenersSync(DeleteListenersRequest req)
        {
            return InternalRequestAsync<DeleteListenersResponse>(req, "DeleteListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户指定的黑石负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// 删除用户指定的黑石负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已创建的黑石流量镜像实例，删除过程是异步执行的，因此需要使用查询任务接口获取删除的结果。
        /// </summary>
        /// <param name="req"><see cref="DeleteTrafficMirrorRequest"/></param>
        /// <returns><see cref="DeleteTrafficMirrorResponse"/></returns>
        public Task<DeleteTrafficMirrorResponse> DeleteTrafficMirror(DeleteTrafficMirrorRequest req)
        {
            return InternalRequestAsync<DeleteTrafficMirrorResponse>(req, "DeleteTrafficMirror");
        }

        /// <summary>
        /// 删除已创建的黑石流量镜像实例，删除过程是异步执行的，因此需要使用查询任务接口获取删除的结果。
        /// </summary>
        /// <param name="req"><see cref="DeleteTrafficMirrorRequest"/></param>
        /// <returns><see cref="DeleteTrafficMirrorResponse"/></returns>
        public DeleteTrafficMirrorResponse DeleteTrafficMirrorSync(DeleteTrafficMirrorRequest req)
        {
            return InternalRequestAsync<DeleteTrafficMirrorResponse>(req, "DeleteTrafficMirror")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡证书详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDetailRequest"/></param>
        /// <returns><see cref="DescribeCertDetailResponse"/></returns>
        public Task<DescribeCertDetailResponse> DescribeCertDetail(DescribeCertDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertDetailResponse>(req, "DescribeCertDetail");
        }

        /// <summary>
        /// 获取黑石负载均衡证书详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDetailRequest"/></param>
        /// <returns><see cref="DescribeCertDetailResponse"/></returns>
        public DescribeCertDetailResponse DescribeCertDetailSync(DescribeCertDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertDetailResponse>(req, "DescribeCertDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询黑石物理机和虚机以及托管服务器绑定的黑石负载均衡详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesBindInfoRequest"/></param>
        /// <returns><see cref="DescribeDevicesBindInfoResponse"/></returns>
        public Task<DescribeDevicesBindInfoResponse> DescribeDevicesBindInfo(DescribeDevicesBindInfoRequest req)
        {
            return InternalRequestAsync<DescribeDevicesBindInfoResponse>(req, "DescribeDevicesBindInfo");
        }

        /// <summary>
        /// 查询黑石物理机和虚机以及托管服务器绑定的黑石负载均衡详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesBindInfoRequest"/></param>
        /// <returns><see cref="DescribeDevicesBindInfoResponse"/></returns>
        public DescribeDevicesBindInfoResponse DescribeDevicesBindInfoSync(DescribeDevicesBindInfoRequest req)
        {
            return InternalRequestAsync<DescribeDevicesBindInfoResponse>(req, "DescribeDevicesBindInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡四层监听器绑定的主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4BackendsRequest"/></param>
        /// <returns><see cref="DescribeL4BackendsResponse"/></returns>
        public Task<DescribeL4BackendsResponse> DescribeL4Backends(DescribeL4BackendsRequest req)
        {
            return InternalRequestAsync<DescribeL4BackendsResponse>(req, "DescribeL4Backends");
        }

        /// <summary>
        /// 获取黑石负载均衡四层监听器绑定的主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4BackendsRequest"/></param>
        /// <returns><see cref="DescribeL4BackendsResponse"/></returns>
        public DescribeL4BackendsResponse DescribeL4BackendsSync(DescribeL4BackendsRequest req)
        {
            return InternalRequestAsync<DescribeL4BackendsResponse>(req, "DescribeL4Backends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查找绑定了某主机或者指定监听器名称的黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ListenerInfoRequest"/></param>
        /// <returns><see cref="DescribeL4ListenerInfoResponse"/></returns>
        public Task<DescribeL4ListenerInfoResponse> DescribeL4ListenerInfo(DescribeL4ListenerInfoRequest req)
        {
            return InternalRequestAsync<DescribeL4ListenerInfoResponse>(req, "DescribeL4ListenerInfo");
        }

        /// <summary>
        /// 查找绑定了某主机或者指定监听器名称的黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ListenerInfoRequest"/></param>
        /// <returns><see cref="DescribeL4ListenerInfoResponse"/></returns>
        public DescribeL4ListenerInfoResponse DescribeL4ListenerInfoSync(DescribeL4ListenerInfoRequest req)
        {
            return InternalRequestAsync<DescribeL4ListenerInfoResponse>(req, "DescribeL4ListenerInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ListenersRequest"/></param>
        /// <returns><see cref="DescribeL4ListenersResponse"/></returns>
        public Task<DescribeL4ListenersResponse> DescribeL4Listeners(DescribeL4ListenersRequest req)
        {
            return InternalRequestAsync<DescribeL4ListenersResponse>(req, "DescribeL4Listeners");
        }

        /// <summary>
        /// 获取黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ListenersRequest"/></param>
        /// <returns><see cref="DescribeL4ListenersResponse"/></returns>
        public DescribeL4ListenersResponse DescribeL4ListenersSync(DescribeL4ListenersRequest req)
        {
            return InternalRequestAsync<DescribeL4ListenersResponse>(req, "DescribeL4Listeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡七层监听器绑定的主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeL7BackendsRequest"/></param>
        /// <returns><see cref="DescribeL7BackendsResponse"/></returns>
        public Task<DescribeL7BackendsResponse> DescribeL7Backends(DescribeL7BackendsRequest req)
        {
            return InternalRequestAsync<DescribeL7BackendsResponse>(req, "DescribeL7Backends");
        }

        /// <summary>
        /// 获取黑石负载均衡七层监听器绑定的主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeL7BackendsRequest"/></param>
        /// <returns><see cref="DescribeL7BackendsResponse"/></returns>
        public DescribeL7BackendsResponse DescribeL7BackendsSync(DescribeL7BackendsRequest req)
        {
            return InternalRequestAsync<DescribeL7BackendsResponse>(req, "DescribeL7Backends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查找绑定了某主机或者有某转发域名黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenerInfoRequest"/></param>
        /// <returns><see cref="DescribeL7ListenerInfoResponse"/></returns>
        public Task<DescribeL7ListenerInfoResponse> DescribeL7ListenerInfo(DescribeL7ListenerInfoRequest req)
        {
            return InternalRequestAsync<DescribeL7ListenerInfoResponse>(req, "DescribeL7ListenerInfo");
        }

        /// <summary>
        /// 查找绑定了某主机或者有某转发域名黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenerInfoRequest"/></param>
        /// <returns><see cref="DescribeL7ListenerInfoResponse"/></returns>
        public DescribeL7ListenerInfoResponse DescribeL7ListenerInfoSync(DescribeL7ListenerInfoRequest req)
        {
            return InternalRequestAsync<DescribeL7ListenerInfoResponse>(req, "DescribeL7ListenerInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡七层监听器列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenersRequest"/></param>
        /// <returns><see cref="DescribeL7ListenersResponse"/></returns>
        public Task<DescribeL7ListenersResponse> DescribeL7Listeners(DescribeL7ListenersRequest req)
        {
            return InternalRequestAsync<DescribeL7ListenersResponse>(req, "DescribeL7Listeners");
        }

        /// <summary>
        /// 获取黑石负载均衡七层监听器列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenersRequest"/></param>
        /// <returns><see cref="DescribeL7ListenersResponse"/></returns>
        public DescribeL7ListenersResponse DescribeL7ListenersSync(DescribeL7ListenersRequest req)
        {
            return InternalRequestAsync<DescribeL7ListenersResponse>(req, "DescribeL7Listeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定VPC下的7层监听器(支持模糊匹配)。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenersExRequest"/></param>
        /// <returns><see cref="DescribeL7ListenersExResponse"/></returns>
        public Task<DescribeL7ListenersExResponse> DescribeL7ListenersEx(DescribeL7ListenersExRequest req)
        {
            return InternalRequestAsync<DescribeL7ListenersExResponse>(req, "DescribeL7ListenersEx");
        }

        /// <summary>
        /// 获取指定VPC下的7层监听器(支持模糊匹配)。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenersExRequest"/></param>
        /// <returns><see cref="DescribeL7ListenersExResponse"/></returns>
        public DescribeL7ListenersExResponse DescribeL7ListenersExSync(DescribeL7ListenersExRequest req)
        {
            return InternalRequestAsync<DescribeL7ListenersExResponse>(req, "DescribeL7ListenersEx")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesRequest"/></param>
        /// <returns><see cref="DescribeL7RulesResponse"/></returns>
        public Task<DescribeL7RulesResponse> DescribeL7Rules(DescribeL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeL7RulesResponse>(req, "DescribeL7Rules");
        }

        /// <summary>
        /// 获取黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesRequest"/></param>
        /// <returns><see cref="DescribeL7RulesResponse"/></returns>
        public DescribeL7RulesResponse DescribeL7RulesSync(DescribeL7RulesRequest req)
        {
            return InternalRequestAsync<DescribeL7RulesResponse>(req, "DescribeL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡端口相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerPortInfoRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerPortInfoResponse"/></returns>
        public Task<DescribeLoadBalancerPortInfoResponse> DescribeLoadBalancerPortInfo(DescribeLoadBalancerPortInfoRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerPortInfoResponse>(req, "DescribeLoadBalancerPortInfo");
        }

        /// <summary>
        /// 获取黑石负载均衡端口相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerPortInfoRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerPortInfoResponse"/></returns>
        public DescribeLoadBalancerPortInfoResponse DescribeLoadBalancerPortInfoSync(DescribeLoadBalancerPortInfoRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerPortInfoResponse>(req, "DescribeLoadBalancerPortInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡实例异步任务的执行情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTaskResultRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTaskResultResponse"/></returns>
        public Task<DescribeLoadBalancerTaskResultResponse> DescribeLoadBalancerTaskResult(DescribeLoadBalancerTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerTaskResultResponse>(req, "DescribeLoadBalancerTaskResult");
        }

        /// <summary>
        /// 查询负载均衡实例异步任务的执行情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTaskResultRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTaskResultResponse"/></returns>
        public DescribeLoadBalancerTaskResultResponse DescribeLoadBalancerTaskResultSync(DescribeLoadBalancerTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerTaskResultResponse>(req, "DescribeLoadBalancerTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑石负载均衡实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers");
        }

        /// <summary>
        /// 获取黑石负载均衡实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取流量镜像的监听器列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorListenersResponse"/></returns>
        public Task<DescribeTrafficMirrorListenersResponse> DescribeTrafficMirrorListeners(DescribeTrafficMirrorListenersRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorListenersResponse>(req, "DescribeTrafficMirrorListeners");
        }

        /// <summary>
        /// 获取流量镜像的监听器列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorListenersResponse"/></returns>
        public DescribeTrafficMirrorListenersResponse DescribeTrafficMirrorListenersSync(DescribeTrafficMirrorListenersRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorListenersResponse>(req, "DescribeTrafficMirrorListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取流量镜像接收机健康状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorReceiverHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorReceiverHealthStatusResponse"/></returns>
        public Task<DescribeTrafficMirrorReceiverHealthStatusResponse> DescribeTrafficMirrorReceiverHealthStatus(DescribeTrafficMirrorReceiverHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorReceiverHealthStatusResponse>(req, "DescribeTrafficMirrorReceiverHealthStatus");
        }

        /// <summary>
        /// 获取流量镜像接收机健康状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorReceiverHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorReceiverHealthStatusResponse"/></returns>
        public DescribeTrafficMirrorReceiverHealthStatusResponse DescribeTrafficMirrorReceiverHealthStatusSync(DescribeTrafficMirrorReceiverHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorReceiverHealthStatusResponse>(req, "DescribeTrafficMirrorReceiverHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定流量镜像实例的接收机信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorReceiversResponse"/></returns>
        public Task<DescribeTrafficMirrorReceiversResponse> DescribeTrafficMirrorReceivers(DescribeTrafficMirrorReceiversRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorReceiversResponse>(req, "DescribeTrafficMirrorReceivers");
        }

        /// <summary>
        /// 获取指定流量镜像实例的接收机信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorReceiversResponse"/></returns>
        public DescribeTrafficMirrorReceiversResponse DescribeTrafficMirrorReceiversSync(DescribeTrafficMirrorReceiversRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorReceiversResponse>(req, "DescribeTrafficMirrorReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取流量镜像实例的列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorsRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorsResponse"/></returns>
        public Task<DescribeTrafficMirrorsResponse> DescribeTrafficMirrors(DescribeTrafficMirrorsRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorsResponse>(req, "DescribeTrafficMirrors");
        }

        /// <summary>
        /// 获取流量镜像实例的列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorsRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorsResponse"/></returns>
        public DescribeTrafficMirrorsResponse DescribeTrafficMirrorsSync(DescribeTrafficMirrorsRequest req)
        {
            return InternalRequestAsync<DescribeTrafficMirrorsResponse>(req, "DescribeTrafficMirrors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端实例端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendPortRequest"/></param>
        /// <returns><see cref="ModifyL4BackendPortResponse"/></returns>
        public Task<ModifyL4BackendPortResponse> ModifyL4BackendPort(ModifyL4BackendPortRequest req)
        {
            return InternalRequestAsync<ModifyL4BackendPortResponse>(req, "ModifyL4BackendPort");
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端实例端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendPortRequest"/></param>
        /// <returns><see cref="ModifyL4BackendPortResponse"/></returns>
        public ModifyL4BackendPortResponse ModifyL4BackendPortSync(ModifyL4BackendPortRequest req)
        {
            return InternalRequestAsync<ModifyL4BackendPortResponse>(req, "ModifyL4BackendPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端探测端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendProbePortRequest"/></param>
        /// <returns><see cref="ModifyL4BackendProbePortResponse"/></returns>
        public Task<ModifyL4BackendProbePortResponse> ModifyL4BackendProbePort(ModifyL4BackendProbePortRequest req)
        {
            return InternalRequestAsync<ModifyL4BackendProbePortResponse>(req, "ModifyL4BackendProbePort");
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端探测端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendProbePortRequest"/></param>
        /// <returns><see cref="ModifyL4BackendProbePortResponse"/></returns>
        public ModifyL4BackendProbePortResponse ModifyL4BackendProbePortSync(ModifyL4BackendProbePortRequest req)
        {
            return InternalRequestAsync<ModifyL4BackendProbePortResponse>(req, "ModifyL4BackendProbePort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端实例权重功能。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendWeightRequest"/></param>
        /// <returns><see cref="ModifyL4BackendWeightResponse"/></returns>
        public Task<ModifyL4BackendWeightResponse> ModifyL4BackendWeight(ModifyL4BackendWeightRequest req)
        {
            return InternalRequestAsync<ModifyL4BackendWeightResponse>(req, "ModifyL4BackendWeight");
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端实例权重功能。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendWeightRequest"/></param>
        /// <returns><see cref="ModifyL4BackendWeightResponse"/></returns>
        public ModifyL4BackendWeightResponse ModifyL4BackendWeightSync(ModifyL4BackendWeightRequest req)
        {
            return InternalRequestAsync<ModifyL4BackendWeightResponse>(req, "ModifyL4BackendWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ListenerRequest"/></param>
        /// <returns><see cref="ModifyL4ListenerResponse"/></returns>
        public Task<ModifyL4ListenerResponse> ModifyL4Listener(ModifyL4ListenerRequest req)
        {
            return InternalRequestAsync<ModifyL4ListenerResponse>(req, "ModifyL4Listener");
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ListenerRequest"/></param>
        /// <returns><see cref="ModifyL4ListenerResponse"/></returns>
        public ModifyL4ListenerResponse ModifyL4ListenerSync(ModifyL4ListenerRequest req)
        {
            return InternalRequestAsync<ModifyL4ListenerResponse>(req, "ModifyL4Listener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径后端实例端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7BackendPortRequest"/></param>
        /// <returns><see cref="ModifyL7BackendPortResponse"/></returns>
        public Task<ModifyL7BackendPortResponse> ModifyL7BackendPort(ModifyL7BackendPortRequest req)
        {
            return InternalRequestAsync<ModifyL7BackendPortResponse>(req, "ModifyL7BackendPort");
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径后端实例端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7BackendPortRequest"/></param>
        /// <returns><see cref="ModifyL7BackendPortResponse"/></returns>
        public ModifyL7BackendPortResponse ModifyL7BackendPortSync(ModifyL7BackendPortRequest req)
        {
            return InternalRequestAsync<ModifyL7BackendPortResponse>(req, "ModifyL7BackendPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径后端实例权重。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7BackendWeightRequest"/></param>
        /// <returns><see cref="ModifyL7BackendWeightResponse"/></returns>
        public Task<ModifyL7BackendWeightResponse> ModifyL7BackendWeight(ModifyL7BackendWeightRequest req)
        {
            return InternalRequestAsync<ModifyL7BackendWeightResponse>(req, "ModifyL7BackendWeight");
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径后端实例权重。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7BackendWeightRequest"/></param>
        /// <returns><see cref="ModifyL7BackendWeightResponse"/></returns>
        public ModifyL7BackendWeightResponse ModifyL7BackendWeightSync(ModifyL7BackendWeightRequest req)
        {
            return InternalRequestAsync<ModifyL7BackendWeightResponse>(req, "ModifyL7BackendWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7ListenerRequest"/></param>
        /// <returns><see cref="ModifyL7ListenerResponse"/></returns>
        public Task<ModifyL7ListenerResponse> ModifyL7Listener(ModifyL7ListenerRequest req)
        {
            return InternalRequestAsync<ModifyL7ListenerResponse>(req, "ModifyL7Listener");
        }

        /// <summary>
        /// 修改黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7ListenerRequest"/></param>
        /// <returns><see cref="ModifyL7ListenerResponse"/></returns>
        public ModifyL7ListenerResponse ModifyL7ListenerSync(ModifyL7ListenerRequest req)
        {
            return InternalRequestAsync<ModifyL7ListenerResponse>(req, "ModifyL7Listener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7LocationsRequest"/></param>
        /// <returns><see cref="ModifyL7LocationsResponse"/></returns>
        public Task<ModifyL7LocationsResponse> ModifyL7Locations(ModifyL7LocationsRequest req)
        {
            return InternalRequestAsync<ModifyL7LocationsResponse>(req, "ModifyL7Locations");
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7LocationsRequest"/></param>
        /// <returns><see cref="ModifyL7LocationsResponse"/></returns>
        public ModifyL7LocationsResponse ModifyL7LocationsSync(ModifyL7LocationsRequest req)
        {
            return InternalRequestAsync<ModifyL7LocationsResponse>(req, "ModifyL7Locations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据输入参数来修改黑石负载均衡实例的基本配置信息。可能的信息包括负载均衡实例的名称，域名前缀。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public Task<ModifyLoadBalancerResponse> ModifyLoadBalancer(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer");
        }

        /// <summary>
        /// 根据输入参数来修改黑石负载均衡实例的基本配置信息。可能的信息包括负载均衡实例的名称，域名前缀。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public ModifyLoadBalancerResponse ModifyLoadBalancerSync(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更改黑石负载均衡的计费方式
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerChargeModeRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerChargeModeResponse"/></returns>
        public Task<ModifyLoadBalancerChargeModeResponse> ModifyLoadBalancerChargeMode(ModifyLoadBalancerChargeModeRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerChargeModeResponse>(req, "ModifyLoadBalancerChargeMode");
        }

        /// <summary>
        /// 更改黑石负载均衡的计费方式
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerChargeModeRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerChargeModeResponse"/></returns>
        public ModifyLoadBalancerChargeModeResponse ModifyLoadBalancerChargeModeSync(ModifyLoadBalancerChargeModeRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerChargeModeResponse>(req, "ModifyLoadBalancerChargeMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新黑石负载均衡证书。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertRequest"/></param>
        /// <returns><see cref="ReplaceCertResponse"/></returns>
        public Task<ReplaceCertResponse> ReplaceCert(ReplaceCertRequest req)
        {
            return InternalRequestAsync<ReplaceCertResponse>(req, "ReplaceCert");
        }

        /// <summary>
        /// 更新黑石负载均衡证书。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertRequest"/></param>
        /// <returns><see cref="ReplaceCertResponse"/></returns>
        public ReplaceCertResponse ReplaceCertSync(ReplaceCertRequest req)
        {
            return InternalRequestAsync<ReplaceCertResponse>(req, "ReplaceCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置流量镜像的别名。
        /// </summary>
        /// <param name="req"><see cref="SetTrafficMirrorAliasRequest"/></param>
        /// <returns><see cref="SetTrafficMirrorAliasResponse"/></returns>
        public Task<SetTrafficMirrorAliasResponse> SetTrafficMirrorAlias(SetTrafficMirrorAliasRequest req)
        {
            return InternalRequestAsync<SetTrafficMirrorAliasResponse>(req, "SetTrafficMirrorAlias");
        }

        /// <summary>
        /// 设置流量镜像的别名。
        /// </summary>
        /// <param name="req"><see cref="SetTrafficMirrorAliasRequest"/></param>
        /// <returns><see cref="SetTrafficMirrorAliasResponse"/></returns>
        public SetTrafficMirrorAliasResponse SetTrafficMirrorAliasSync(SetTrafficMirrorAliasRequest req)
        {
            return InternalRequestAsync<SetTrafficMirrorAliasResponse>(req, "SetTrafficMirrorAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置流量镜像的健康检查参数。
        /// </summary>
        /// <param name="req"><see cref="SetTrafficMirrorHealthSwitchRequest"/></param>
        /// <returns><see cref="SetTrafficMirrorHealthSwitchResponse"/></returns>
        public Task<SetTrafficMirrorHealthSwitchResponse> SetTrafficMirrorHealthSwitch(SetTrafficMirrorHealthSwitchRequest req)
        {
            return InternalRequestAsync<SetTrafficMirrorHealthSwitchResponse>(req, "SetTrafficMirrorHealthSwitch");
        }

        /// <summary>
        /// 设置流量镜像的健康检查参数。
        /// </summary>
        /// <param name="req"><see cref="SetTrafficMirrorHealthSwitchRequest"/></param>
        /// <returns><see cref="SetTrafficMirrorHealthSwitchResponse"/></returns>
        public SetTrafficMirrorHealthSwitchResponse SetTrafficMirrorHealthSwitchSync(SetTrafficMirrorHealthSwitchRequest req)
        {
            return InternalRequestAsync<SetTrafficMirrorHealthSwitchResponse>(req, "SetTrafficMirrorHealthSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑黑石负载均衡四层监听器物理服务器。
        /// </summary>
        /// <param name="req"><see cref="UnbindL4BackendsRequest"/></param>
        /// <returns><see cref="UnbindL4BackendsResponse"/></returns>
        public Task<UnbindL4BackendsResponse> UnbindL4Backends(UnbindL4BackendsRequest req)
        {
            return InternalRequestAsync<UnbindL4BackendsResponse>(req, "UnbindL4Backends");
        }

        /// <summary>
        /// 解绑黑石负载均衡四层监听器物理服务器。
        /// </summary>
        /// <param name="req"><see cref="UnbindL4BackendsRequest"/></param>
        /// <returns><see cref="UnbindL4BackendsResponse"/></returns>
        public UnbindL4BackendsResponse UnbindL4BackendsSync(UnbindL4BackendsRequest req)
        {
            return InternalRequestAsync<UnbindL4BackendsResponse>(req, "UnbindL4Backends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑黑石物理服务器或者托管服务器到七层转发路径功能。
        /// </summary>
        /// <param name="req"><see cref="UnbindL7BackendsRequest"/></param>
        /// <returns><see cref="UnbindL7BackendsResponse"/></returns>
        public Task<UnbindL7BackendsResponse> UnbindL7Backends(UnbindL7BackendsRequest req)
        {
            return InternalRequestAsync<UnbindL7BackendsResponse>(req, "UnbindL7Backends");
        }

        /// <summary>
        /// 解绑黑石物理服务器或者托管服务器到七层转发路径功能。
        /// </summary>
        /// <param name="req"><see cref="UnbindL7BackendsRequest"/></param>
        /// <returns><see cref="UnbindL7BackendsResponse"/></returns>
        public UnbindL7BackendsResponse UnbindL7BackendsSync(UnbindL7BackendsRequest req)
        {
            return InternalRequestAsync<UnbindL7BackendsResponse>(req, "UnbindL7Backends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑流量镜像监听器。
        /// </summary>
        /// <param name="req"><see cref="UnbindTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="UnbindTrafficMirrorListenersResponse"/></returns>
        public Task<UnbindTrafficMirrorListenersResponse> UnbindTrafficMirrorListeners(UnbindTrafficMirrorListenersRequest req)
        {
            return InternalRequestAsync<UnbindTrafficMirrorListenersResponse>(req, "UnbindTrafficMirrorListeners");
        }

        /// <summary>
        /// 解绑流量镜像监听器。
        /// </summary>
        /// <param name="req"><see cref="UnbindTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="UnbindTrafficMirrorListenersResponse"/></returns>
        public UnbindTrafficMirrorListenersResponse UnbindTrafficMirrorListenersSync(UnbindTrafficMirrorListenersRequest req)
        {
            return InternalRequestAsync<UnbindTrafficMirrorListenersResponse>(req, "UnbindTrafficMirrorListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从流量镜像实例上解绑流量镜像接收机。
        /// </summary>
        /// <param name="req"><see cref="UnbindTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="UnbindTrafficMirrorReceiversResponse"/></returns>
        public Task<UnbindTrafficMirrorReceiversResponse> UnbindTrafficMirrorReceivers(UnbindTrafficMirrorReceiversRequest req)
        {
            return InternalRequestAsync<UnbindTrafficMirrorReceiversResponse>(req, "UnbindTrafficMirrorReceivers");
        }

        /// <summary>
        /// 从流量镜像实例上解绑流量镜像接收机。
        /// </summary>
        /// <param name="req"><see cref="UnbindTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="UnbindTrafficMirrorReceiversResponse"/></returns>
        public UnbindTrafficMirrorReceiversResponse UnbindTrafficMirrorReceiversSync(UnbindTrafficMirrorReceiversRequest req)
        {
            return InternalRequestAsync<UnbindTrafficMirrorReceiversResponse>(req, "UnbindTrafficMirrorReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石负载均衡证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertRequest"/></param>
        /// <returns><see cref="UploadCertResponse"/></returns>
        public Task<UploadCertResponse> UploadCert(UploadCertRequest req)
        {
            return InternalRequestAsync<UploadCertResponse>(req, "UploadCert");
        }

        /// <summary>
        /// 创建黑石负载均衡证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertRequest"/></param>
        /// <returns><see cref="UploadCertResponse"/></returns>
        public UploadCertResponse UploadCertSync(UploadCertRequest req)
        {
            return InternalRequestAsync<UploadCertResponse>(req, "UploadCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
