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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmlbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 绑定黑石服务器到四层监听器。服务器包括物理服务器、虚拟机以及半托管机器。
        /// </summary>
        /// <param name="req"><see cref="BindL4BackendsRequest"/></param>
        /// <returns><see cref="BindL4BackendsResponse"/></returns>
        public async Task<BindL4BackendsResponse> BindL4Backends(BindL4BackendsRequest req)
        {
             JsonResponseModel<BindL4BackendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindL4Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindL4BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindL4Backends接口的同步版本，绑定黑石服务器到四层监听器。服务器包括物理服务器、虚拟机以及半托管机器。
        /// </summary>
        /// <param name="req">参考<see cref="BindL4BackendsRequest"/></param>
        /// <returns>参考<see cref="BindL4BackendsResponse"/>实例</returns>
        public BindL4BackendsResponse BindL4BackendsSync(BindL4BackendsRequest req)
        {
             JsonResponseModel<BindL4BackendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindL4Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindL4BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定黑石物理服务器或半托管服务器到七层转发路径。
        /// </summary>
        /// <param name="req"><see cref="BindL7BackendsRequest"/></param>
        /// <returns><see cref="BindL7BackendsResponse"/></returns>
        public async Task<BindL7BackendsResponse> BindL7Backends(BindL7BackendsRequest req)
        {
             JsonResponseModel<BindL7BackendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindL7Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindL7BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindL7Backends接口的同步版本，绑定黑石物理服务器或半托管服务器到七层转发路径。
        /// </summary>
        /// <param name="req">参考<see cref="BindL7BackendsRequest"/></param>
        /// <returns>参考<see cref="BindL7BackendsResponse"/>实例</returns>
        public BindL7BackendsResponse BindL7BackendsSync(BindL7BackendsRequest req)
        {
             JsonResponseModel<BindL7BackendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindL7Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindL7BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定黑石服务器七层监听器到流量镜像实例。
        /// </summary>
        /// <param name="req"><see cref="BindTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="BindTrafficMirrorListenersResponse"/></returns>
        public async Task<BindTrafficMirrorListenersResponse> BindTrafficMirrorListeners(BindTrafficMirrorListenersRequest req)
        {
             JsonResponseModel<BindTrafficMirrorListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindTrafficMirrorListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindTrafficMirrorListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindTrafficMirrorListeners接口的同步版本，绑定黑石服务器七层监听器到流量镜像实例。
        /// </summary>
        /// <param name="req">参考<see cref="BindTrafficMirrorListenersRequest"/></param>
        /// <returns>参考<see cref="BindTrafficMirrorListenersResponse"/>实例</returns>
        public BindTrafficMirrorListenersResponse BindTrafficMirrorListenersSync(BindTrafficMirrorListenersRequest req)
        {
             JsonResponseModel<BindTrafficMirrorListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindTrafficMirrorListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindTrafficMirrorListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定黑石物理服务器成为流量镜像接收机。
        /// </summary>
        /// <param name="req"><see cref="BindTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="BindTrafficMirrorReceiversResponse"/></returns>
        public async Task<BindTrafficMirrorReceiversResponse> BindTrafficMirrorReceivers(BindTrafficMirrorReceiversRequest req)
        {
             JsonResponseModel<BindTrafficMirrorReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindTrafficMirrorReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindTrafficMirrorReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindTrafficMirrorReceivers接口的同步版本，绑定黑石物理服务器成为流量镜像接收机。
        /// </summary>
        /// <param name="req">参考<see cref="BindTrafficMirrorReceiversRequest"/></param>
        /// <returns>参考<see cref="BindTrafficMirrorReceiversResponse"/>实例</returns>
        public BindTrafficMirrorReceiversResponse BindTrafficMirrorReceiversSync(BindTrafficMirrorReceiversRequest req)
        {
             JsonResponseModel<BindTrafficMirrorReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindTrafficMirrorReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindTrafficMirrorReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石四层负载均衡监听器功能。黑石负载均衡四层监听器提供了转发用户请求的具体规则，包括端口、协议、会话保持、健康检查等参数。
        /// </summary>
        /// <param name="req"><see cref="CreateL4ListenersRequest"/></param>
        /// <returns><see cref="CreateL4ListenersResponse"/></returns>
        public async Task<CreateL4ListenersResponse> CreateL4Listeners(CreateL4ListenersRequest req)
        {
             JsonResponseModel<CreateL4ListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL4Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL4Listeners接口的同步版本，创建黑石四层负载均衡监听器功能。黑石负载均衡四层监听器提供了转发用户请求的具体规则，包括端口、协议、会话保持、健康检查等参数。
        /// </summary>
        /// <param name="req">参考<see cref="CreateL4ListenersRequest"/></param>
        /// <returns>参考<see cref="CreateL4ListenersResponse"/>实例</returns>
        public CreateL4ListenersResponse CreateL4ListenersSync(CreateL4ListenersRequest req)
        {
             JsonResponseModel<CreateL4ListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL4Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石负载均衡七层监听器功能。负载均衡七层监听器提供了转发用户请求的具体规则，包括端口、协议等参数。
        /// </summary>
        /// <param name="req"><see cref="CreateL7ListenersRequest"/></param>
        /// <returns><see cref="CreateL7ListenersResponse"/></returns>
        public async Task<CreateL7ListenersResponse> CreateL7Listeners(CreateL7ListenersRequest req)
        {
             JsonResponseModel<CreateL7ListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL7Listeners接口的同步版本，创建黑石负载均衡七层监听器功能。负载均衡七层监听器提供了转发用户请求的具体规则，包括端口、协议等参数。
        /// </summary>
        /// <param name="req">参考<see cref="CreateL7ListenersRequest"/></param>
        /// <returns>参考<see cref="CreateL7ListenersResponse"/>实例</returns>
        public CreateL7ListenersResponse CreateL7ListenersSync(CreateL7ListenersRequest req)
        {
             JsonResponseModel<CreateL7ListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public async Task<CreateL7RulesResponse> CreateL7Rules(CreateL7RulesRequest req)
        {
             JsonResponseModel<CreateL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL7Rules接口的同步版本，创建黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req">参考<see cref="CreateL7RulesRequest"/></param>
        /// <returns>参考<see cref="CreateL7RulesResponse"/>实例</returns>
        public CreateL7RulesResponse CreateL7RulesSync(CreateL7RulesRequest req)
        {
             JsonResponseModel<CreateL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用来创建黑石负载均衡。为了使用黑石负载均衡服务，您必须要创建一个或者多个负载均衡实例。通过成功调用该接口，会返回负载均衡实例的唯一ID。用户可以购买的黑石负载均衡实例类型分为：公网类型、内网类型。公网类型负载均衡对应一个BGP VIP，可用于快速访问公网负载均衡绑定的物理服务器；内网类型负载均衡对应一个腾讯云内部的VIP，不能通过Internet访问，可快速访问内网负载均衡绑定的物理服务器。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancersRequest"/></param>
        /// <returns><see cref="CreateLoadBalancersResponse"/></returns>
        public async Task<CreateLoadBalancersResponse> CreateLoadBalancers(CreateLoadBalancersRequest req)
        {
             JsonResponseModel<CreateLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLoadBalancers接口的同步版本，用来创建黑石负载均衡。为了使用黑石负载均衡服务，您必须要创建一个或者多个负载均衡实例。通过成功调用该接口，会返回负载均衡实例的唯一ID。用户可以购买的黑石负载均衡实例类型分为：公网类型、内网类型。公网类型负载均衡对应一个BGP VIP，可用于快速访问公网负载均衡绑定的物理服务器；内网类型负载均衡对应一个腾讯云内部的VIP，不能通过Internet访问，可快速访问内网负载均衡绑定的物理服务器。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLoadBalancersRequest"/></param>
        /// <returns>参考<see cref="CreateLoadBalancersResponse"/>实例</returns>
        public CreateLoadBalancersResponse CreateLoadBalancersSync(CreateLoadBalancersRequest req)
        {
             JsonResponseModel<CreateLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建流量镜像实例。
        /// </summary>
        /// <param name="req"><see cref="CreateTrafficMirrorRequest"/></param>
        /// <returns><see cref="CreateTrafficMirrorResponse"/></returns>
        public async Task<CreateTrafficMirrorResponse> CreateTrafficMirror(CreateTrafficMirrorRequest req)
        {
             JsonResponseModel<CreateTrafficMirrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrafficMirror");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrafficMirrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateTrafficMirror接口的同步版本，创建流量镜像实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateTrafficMirrorRequest"/></param>
        /// <returns>参考<see cref="CreateTrafficMirrorResponse"/>实例</returns>
        public CreateTrafficMirrorResponse CreateTrafficMirrorSync(CreateTrafficMirrorRequest req)
        {
             JsonResponseModel<CreateTrafficMirrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrafficMirror");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrafficMirrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除黑石负载均衡七层转发域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7DomainsRequest"/></param>
        /// <returns><see cref="DeleteL7DomainsResponse"/></returns>
        public async Task<DeleteL7DomainsResponse> DeleteL7Domains(DeleteL7DomainsRequest req)
        {
             JsonResponseModel<DeleteL7DomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteL7Domains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7DomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteL7Domains接口的同步版本，删除黑石负载均衡七层转发域名。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteL7DomainsRequest"/></param>
        /// <returns>参考<see cref="DeleteL7DomainsResponse"/>实例</returns>
        public DeleteL7DomainsResponse DeleteL7DomainsSync(DeleteL7DomainsRequest req)
        {
             JsonResponseModel<DeleteL7DomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteL7Domains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7DomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public async Task<DeleteL7RulesResponse> DeleteL7Rules(DeleteL7RulesRequest req)
        {
             JsonResponseModel<DeleteL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteL7Rules接口的同步版本，删除黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteL7RulesRequest"/></param>
        /// <returns>参考<see cref="DeleteL7RulesResponse"/>实例</returns>
        public DeleteL7RulesResponse DeleteL7RulesSync(DeleteL7RulesRequest req)
        {
             JsonResponseModel<DeleteL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除黑石负载均衡监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public async Task<DeleteListenersResponse> DeleteListeners(DeleteListenersRequest req)
        {
             JsonResponseModel<DeleteListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteListeners接口的同步版本，删除黑石负载均衡监听器。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteListenersRequest"/></param>
        /// <returns>参考<see cref="DeleteListenersResponse"/>实例</returns>
        public DeleteListenersResponse DeleteListenersSync(DeleteListenersRequest req)
        {
             JsonResponseModel<DeleteListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户指定的黑石负载均衡实例。
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
        /// DeleteLoadBalancer接口的同步版本，删除用户指定的黑石负载均衡实例。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns>参考<see cref="DeleteLoadBalancerResponse"/>实例</returns>
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
        /// 删除已创建的黑石流量镜像实例，删除过程是异步执行的，因此需要使用查询任务接口获取删除的结果。
        /// </summary>
        /// <param name="req"><see cref="DeleteTrafficMirrorRequest"/></param>
        /// <returns><see cref="DeleteTrafficMirrorResponse"/></returns>
        public async Task<DeleteTrafficMirrorResponse> DeleteTrafficMirror(DeleteTrafficMirrorRequest req)
        {
             JsonResponseModel<DeleteTrafficMirrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrafficMirror");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrafficMirrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteTrafficMirror接口的同步版本，删除已创建的黑石流量镜像实例，删除过程是异步执行的，因此需要使用查询任务接口获取删除的结果。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTrafficMirrorRequest"/></param>
        /// <returns>参考<see cref="DeleteTrafficMirrorResponse"/>实例</returns>
        public DeleteTrafficMirrorResponse DeleteTrafficMirrorSync(DeleteTrafficMirrorRequest req)
        {
             JsonResponseModel<DeleteTrafficMirrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrafficMirror");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTrafficMirrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡证书详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDetailRequest"/></param>
        /// <returns><see cref="DescribeCertDetailResponse"/></returns>
        public async Task<DescribeCertDetailResponse> DescribeCertDetail(DescribeCertDetailRequest req)
        {
             JsonResponseModel<DescribeCertDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCertDetail接口的同步版本，获取黑石负载均衡证书详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCertDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeCertDetailResponse"/>实例</returns>
        public DescribeCertDetailResponse DescribeCertDetailSync(DescribeCertDetailRequest req)
        {
             JsonResponseModel<DescribeCertDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询黑石物理机和虚机以及托管服务器绑定的黑石负载均衡详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesBindInfoRequest"/></param>
        /// <returns><see cref="DescribeDevicesBindInfoResponse"/></returns>
        public async Task<DescribeDevicesBindInfoResponse> DescribeDevicesBindInfo(DescribeDevicesBindInfoRequest req)
        {
             JsonResponseModel<DescribeDevicesBindInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicesBindInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesBindInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDevicesBindInfo接口的同步版本，查询黑石物理机和虚机以及托管服务器绑定的黑石负载均衡详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicesBindInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicesBindInfoResponse"/>实例</returns>
        public DescribeDevicesBindInfoResponse DescribeDevicesBindInfoSync(DescribeDevicesBindInfoRequest req)
        {
             JsonResponseModel<DescribeDevicesBindInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevicesBindInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesBindInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡四层监听器绑定的主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4BackendsRequest"/></param>
        /// <returns><see cref="DescribeL4BackendsResponse"/></returns>
        public async Task<DescribeL4BackendsResponse> DescribeL4Backends(DescribeL4BackendsRequest req)
        {
             JsonResponseModel<DescribeL4BackendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL4Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL4Backends接口的同步版本，获取黑石负载均衡四层监听器绑定的主机列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL4BackendsRequest"/></param>
        /// <returns>参考<see cref="DescribeL4BackendsResponse"/>实例</returns>
        public DescribeL4BackendsResponse DescribeL4BackendsSync(DescribeL4BackendsRequest req)
        {
             JsonResponseModel<DescribeL4BackendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL4Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查找绑定了某主机或者指定监听器名称的黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ListenerInfoRequest"/></param>
        /// <returns><see cref="DescribeL4ListenerInfoResponse"/></returns>
        public async Task<DescribeL4ListenerInfoResponse> DescribeL4ListenerInfo(DescribeL4ListenerInfoRequest req)
        {
             JsonResponseModel<DescribeL4ListenerInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL4ListenerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4ListenerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL4ListenerInfo接口的同步版本，查找绑定了某主机或者指定监听器名称的黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL4ListenerInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeL4ListenerInfoResponse"/>实例</returns>
        public DescribeL4ListenerInfoResponse DescribeL4ListenerInfoSync(DescribeL4ListenerInfoRequest req)
        {
             JsonResponseModel<DescribeL4ListenerInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL4ListenerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4ListenerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ListenersRequest"/></param>
        /// <returns><see cref="DescribeL4ListenersResponse"/></returns>
        public async Task<DescribeL4ListenersResponse> DescribeL4Listeners(DescribeL4ListenersRequest req)
        {
             JsonResponseModel<DescribeL4ListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL4Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL4Listeners接口的同步版本，获取黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL4ListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeL4ListenersResponse"/>实例</returns>
        public DescribeL4ListenersResponse DescribeL4ListenersSync(DescribeL4ListenersRequest req)
        {
             JsonResponseModel<DescribeL4ListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL4Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡七层监听器绑定的主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeL7BackendsRequest"/></param>
        /// <returns><see cref="DescribeL7BackendsResponse"/></returns>
        public async Task<DescribeL7BackendsResponse> DescribeL7Backends(DescribeL7BackendsRequest req)
        {
             JsonResponseModel<DescribeL7BackendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL7Backends接口的同步版本，获取黑石负载均衡七层监听器绑定的主机列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL7BackendsRequest"/></param>
        /// <returns>参考<see cref="DescribeL7BackendsResponse"/>实例</returns>
        public DescribeL7BackendsResponse DescribeL7BackendsSync(DescribeL7BackendsRequest req)
        {
             JsonResponseModel<DescribeL7BackendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查找绑定了某主机或者有某转发域名黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenerInfoRequest"/></param>
        /// <returns><see cref="DescribeL7ListenerInfoResponse"/></returns>
        public async Task<DescribeL7ListenerInfoResponse> DescribeL7ListenerInfo(DescribeL7ListenerInfoRequest req)
        {
             JsonResponseModel<DescribeL7ListenerInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7ListenerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7ListenerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL7ListenerInfo接口的同步版本，查找绑定了某主机或者有某转发域名黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL7ListenerInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeL7ListenerInfoResponse"/>实例</returns>
        public DescribeL7ListenerInfoResponse DescribeL7ListenerInfoSync(DescribeL7ListenerInfoRequest req)
        {
             JsonResponseModel<DescribeL7ListenerInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7ListenerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7ListenerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡七层监听器列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenersRequest"/></param>
        /// <returns><see cref="DescribeL7ListenersResponse"/></returns>
        public async Task<DescribeL7ListenersResponse> DescribeL7Listeners(DescribeL7ListenersRequest req)
        {
             JsonResponseModel<DescribeL7ListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL7Listeners接口的同步版本，获取黑石负载均衡七层监听器列表信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL7ListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeL7ListenersResponse"/>实例</returns>
        public DescribeL7ListenersResponse DescribeL7ListenersSync(DescribeL7ListenersRequest req)
        {
             JsonResponseModel<DescribeL7ListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7Listeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7ListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定VPC下的7层监听器(支持模糊匹配)。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7ListenersExRequest"/></param>
        /// <returns><see cref="DescribeL7ListenersExResponse"/></returns>
        public async Task<DescribeL7ListenersExResponse> DescribeL7ListenersEx(DescribeL7ListenersExRequest req)
        {
             JsonResponseModel<DescribeL7ListenersExResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7ListenersEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7ListenersExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL7ListenersEx接口的同步版本，获取指定VPC下的7层监听器(支持模糊匹配)。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL7ListenersExRequest"/></param>
        /// <returns>参考<see cref="DescribeL7ListenersExResponse"/>实例</returns>
        public DescribeL7ListenersExResponse DescribeL7ListenersExSync(DescribeL7ListenersExRequest req)
        {
             JsonResponseModel<DescribeL7ListenersExResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7ListenersEx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7ListenersExResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7RulesRequest"/></param>
        /// <returns><see cref="DescribeL7RulesResponse"/></returns>
        public async Task<DescribeL7RulesResponse> DescribeL7Rules(DescribeL7RulesRequest req)
        {
             JsonResponseModel<DescribeL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL7Rules接口的同步版本，获取黑石负载均衡七层转发规则。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL7RulesRequest"/></param>
        /// <returns>参考<see cref="DescribeL7RulesResponse"/>实例</returns>
        public DescribeL7RulesResponse DescribeL7RulesSync(DescribeL7RulesRequest req)
        {
             JsonResponseModel<DescribeL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡端口相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerPortInfoRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerPortInfoResponse"/></returns>
        public async Task<DescribeLoadBalancerPortInfoResponse> DescribeLoadBalancerPortInfo(DescribeLoadBalancerPortInfoRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerPortInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancerPortInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerPortInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLoadBalancerPortInfo接口的同步版本，获取黑石负载均衡端口相关信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLoadBalancerPortInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeLoadBalancerPortInfoResponse"/>实例</returns>
        public DescribeLoadBalancerPortInfoResponse DescribeLoadBalancerPortInfoSync(DescribeLoadBalancerPortInfoRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerPortInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancerPortInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerPortInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询负载均衡实例异步任务的执行情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTaskResultRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTaskResultResponse"/></returns>
        public async Task<DescribeLoadBalancerTaskResultResponse> DescribeLoadBalancerTaskResult(DescribeLoadBalancerTaskResultRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancerTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLoadBalancerTaskResult接口的同步版本，查询负载均衡实例异步任务的执行情况。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLoadBalancerTaskResultRequest"/></param>
        /// <returns>参考<see cref="DescribeLoadBalancerTaskResultResponse"/>实例</returns>
        public DescribeLoadBalancerTaskResultResponse DescribeLoadBalancerTaskResultSync(DescribeLoadBalancerTaskResultRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancerTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑石负载均衡实例列表
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
        /// DescribeLoadBalancers接口的同步版本，获取黑石负载均衡实例列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns>参考<see cref="DescribeLoadBalancersResponse"/>实例</returns>
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
        /// 获取流量镜像的监听器列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorListenersResponse"/></returns>
        public async Task<DescribeTrafficMirrorListenersResponse> DescribeTrafficMirrorListeners(DescribeTrafficMirrorListenersRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficMirrorListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficMirrorListeners接口的同步版本，获取流量镜像的监听器列表信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTrafficMirrorListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeTrafficMirrorListenersResponse"/>实例</returns>
        public DescribeTrafficMirrorListenersResponse DescribeTrafficMirrorListenersSync(DescribeTrafficMirrorListenersRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficMirrorListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取流量镜像接收机健康状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorReceiverHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorReceiverHealthStatusResponse"/></returns>
        public async Task<DescribeTrafficMirrorReceiverHealthStatusResponse> DescribeTrafficMirrorReceiverHealthStatus(DescribeTrafficMirrorReceiverHealthStatusRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorReceiverHealthStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficMirrorReceiverHealthStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorReceiverHealthStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficMirrorReceiverHealthStatus接口的同步版本，获取流量镜像接收机健康状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTrafficMirrorReceiverHealthStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeTrafficMirrorReceiverHealthStatusResponse"/>实例</returns>
        public DescribeTrafficMirrorReceiverHealthStatusResponse DescribeTrafficMirrorReceiverHealthStatusSync(DescribeTrafficMirrorReceiverHealthStatusRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorReceiverHealthStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficMirrorReceiverHealthStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorReceiverHealthStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定流量镜像实例的接收机信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorReceiversResponse"/></returns>
        public async Task<DescribeTrafficMirrorReceiversResponse> DescribeTrafficMirrorReceivers(DescribeTrafficMirrorReceiversRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficMirrorReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficMirrorReceivers接口的同步版本，获取指定流量镜像实例的接收机信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTrafficMirrorReceiversRequest"/></param>
        /// <returns>参考<see cref="DescribeTrafficMirrorReceiversResponse"/>实例</returns>
        public DescribeTrafficMirrorReceiversResponse DescribeTrafficMirrorReceiversSync(DescribeTrafficMirrorReceiversRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficMirrorReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取流量镜像实例的列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficMirrorsRequest"/></param>
        /// <returns><see cref="DescribeTrafficMirrorsResponse"/></returns>
        public async Task<DescribeTrafficMirrorsResponse> DescribeTrafficMirrors(DescribeTrafficMirrorsRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficMirrors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficMirrors接口的同步版本，获取流量镜像实例的列表信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTrafficMirrorsRequest"/></param>
        /// <returns>参考<see cref="DescribeTrafficMirrorsResponse"/>实例</returns>
        public DescribeTrafficMirrorsResponse DescribeTrafficMirrorsSync(DescribeTrafficMirrorsRequest req)
        {
             JsonResponseModel<DescribeTrafficMirrorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficMirrors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficMirrorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端实例端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendPortRequest"/></param>
        /// <returns><see cref="ModifyL4BackendPortResponse"/></returns>
        public async Task<ModifyL4BackendPortResponse> ModifyL4BackendPort(ModifyL4BackendPortRequest req)
        {
             JsonResponseModel<ModifyL4BackendPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4BackendPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4BackendPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL4BackendPort接口的同步版本，修改黑石负载均衡四层监听器后端实例端口。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL4BackendPortRequest"/></param>
        /// <returns>参考<see cref="ModifyL4BackendPortResponse"/>实例</returns>
        public ModifyL4BackendPortResponse ModifyL4BackendPortSync(ModifyL4BackendPortRequest req)
        {
             JsonResponseModel<ModifyL4BackendPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4BackendPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4BackendPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端探测端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendProbePortRequest"/></param>
        /// <returns><see cref="ModifyL4BackendProbePortResponse"/></returns>
        public async Task<ModifyL4BackendProbePortResponse> ModifyL4BackendProbePort(ModifyL4BackendProbePortRequest req)
        {
             JsonResponseModel<ModifyL4BackendProbePortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4BackendProbePort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4BackendProbePortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL4BackendProbePort接口的同步版本，修改黑石负载均衡四层监听器后端探测端口。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL4BackendProbePortRequest"/></param>
        /// <returns>参考<see cref="ModifyL4BackendProbePortResponse"/>实例</returns>
        public ModifyL4BackendProbePortResponse ModifyL4BackendProbePortSync(ModifyL4BackendProbePortRequest req)
        {
             JsonResponseModel<ModifyL4BackendProbePortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4BackendProbePort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4BackendProbePortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器后端实例权重功能。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4BackendWeightRequest"/></param>
        /// <returns><see cref="ModifyL4BackendWeightResponse"/></returns>
        public async Task<ModifyL4BackendWeightResponse> ModifyL4BackendWeight(ModifyL4BackendWeightRequest req)
        {
             JsonResponseModel<ModifyL4BackendWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4BackendWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4BackendWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL4BackendWeight接口的同步版本，修改黑石负载均衡四层监听器后端实例权重功能。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL4BackendWeightRequest"/></param>
        /// <returns>参考<see cref="ModifyL4BackendWeightResponse"/>实例</returns>
        public ModifyL4BackendWeightResponse ModifyL4BackendWeightSync(ModifyL4BackendWeightRequest req)
        {
             JsonResponseModel<ModifyL4BackendWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4BackendWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4BackendWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ListenerRequest"/></param>
        /// <returns><see cref="ModifyL4ListenerResponse"/></returns>
        public async Task<ModifyL4ListenerResponse> ModifyL4Listener(ModifyL4ListenerRequest req)
        {
             JsonResponseModel<ModifyL4ListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4Listener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4ListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL4Listener接口的同步版本，修改黑石负载均衡四层监听器。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL4ListenerRequest"/></param>
        /// <returns>参考<see cref="ModifyL4ListenerResponse"/>实例</returns>
        public ModifyL4ListenerResponse ModifyL4ListenerSync(ModifyL4ListenerRequest req)
        {
             JsonResponseModel<ModifyL4ListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4Listener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4ListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径后端实例端口。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7BackendPortRequest"/></param>
        /// <returns><see cref="ModifyL7BackendPortResponse"/></returns>
        public async Task<ModifyL7BackendPortResponse> ModifyL7BackendPort(ModifyL7BackendPortRequest req)
        {
             JsonResponseModel<ModifyL7BackendPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL7BackendPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7BackendPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL7BackendPort接口的同步版本，修改黑石负载均衡七层转发路径后端实例端口。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL7BackendPortRequest"/></param>
        /// <returns>参考<see cref="ModifyL7BackendPortResponse"/>实例</returns>
        public ModifyL7BackendPortResponse ModifyL7BackendPortSync(ModifyL7BackendPortRequest req)
        {
             JsonResponseModel<ModifyL7BackendPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL7BackendPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7BackendPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径后端实例权重。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7BackendWeightRequest"/></param>
        /// <returns><see cref="ModifyL7BackendWeightResponse"/></returns>
        public async Task<ModifyL7BackendWeightResponse> ModifyL7BackendWeight(ModifyL7BackendWeightRequest req)
        {
             JsonResponseModel<ModifyL7BackendWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL7BackendWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7BackendWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL7BackendWeight接口的同步版本，修改黑石负载均衡七层转发路径后端实例权重。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL7BackendWeightRequest"/></param>
        /// <returns>参考<see cref="ModifyL7BackendWeightResponse"/>实例</returns>
        public ModifyL7BackendWeightResponse ModifyL7BackendWeightSync(ModifyL7BackendWeightRequest req)
        {
             JsonResponseModel<ModifyL7BackendWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL7BackendWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7BackendWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7ListenerRequest"/></param>
        /// <returns><see cref="ModifyL7ListenerResponse"/></returns>
        public async Task<ModifyL7ListenerResponse> ModifyL7Listener(ModifyL7ListenerRequest req)
        {
             JsonResponseModel<ModifyL7ListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL7Listener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7ListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL7Listener接口的同步版本，修改黑石负载均衡七层监听器。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL7ListenerRequest"/></param>
        /// <returns>参考<see cref="ModifyL7ListenerResponse"/>实例</returns>
        public ModifyL7ListenerResponse ModifyL7ListenerSync(ModifyL7ListenerRequest req)
        {
             JsonResponseModel<ModifyL7ListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL7Listener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7ListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改黑石负载均衡七层转发路径。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7LocationsRequest"/></param>
        /// <returns><see cref="ModifyL7LocationsResponse"/></returns>
        public async Task<ModifyL7LocationsResponse> ModifyL7Locations(ModifyL7LocationsRequest req)
        {
             JsonResponseModel<ModifyL7LocationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL7Locations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7LocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL7Locations接口的同步版本，修改黑石负载均衡七层转发路径。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL7LocationsRequest"/></param>
        /// <returns>参考<see cref="ModifyL7LocationsResponse"/>实例</returns>
        public ModifyL7LocationsResponse ModifyL7LocationsSync(ModifyL7LocationsRequest req)
        {
             JsonResponseModel<ModifyL7LocationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL7Locations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7LocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据输入参数来修改黑石负载均衡实例的基本配置信息。可能的信息包括负载均衡实例的名称，域名前缀。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public async Task<ModifyLoadBalancerResponse> ModifyLoadBalancer(ModifyLoadBalancerRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLoadBalancer接口的同步版本，根据输入参数来修改黑石负载均衡实例的基本配置信息。可能的信息包括负载均衡实例的名称，域名前缀。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns>参考<see cref="ModifyLoadBalancerResponse"/>实例</returns>
        public ModifyLoadBalancerResponse ModifyLoadBalancerSync(ModifyLoadBalancerRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改黑石负载均衡的计费方式
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerChargeModeRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerChargeModeResponse"/></returns>
        public async Task<ModifyLoadBalancerChargeModeResponse> ModifyLoadBalancerChargeMode(ModifyLoadBalancerChargeModeRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerChargeModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancerChargeMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerChargeModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLoadBalancerChargeMode接口的同步版本，更改黑石负载均衡的计费方式
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLoadBalancerChargeModeRequest"/></param>
        /// <returns>参考<see cref="ModifyLoadBalancerChargeModeResponse"/>实例</returns>
        public ModifyLoadBalancerChargeModeResponse ModifyLoadBalancerChargeModeSync(ModifyLoadBalancerChargeModeRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerChargeModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancerChargeMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerChargeModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新黑石负载均衡证书。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertRequest"/></param>
        /// <returns><see cref="ReplaceCertResponse"/></returns>
        public async Task<ReplaceCertResponse> ReplaceCert(ReplaceCertRequest req)
        {
             JsonResponseModel<ReplaceCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ReplaceCert接口的同步版本，更新黑石负载均衡证书。
        /// </summary>
        /// <param name="req">参考<see cref="ReplaceCertRequest"/></param>
        /// <returns>参考<see cref="ReplaceCertResponse"/>实例</returns>
        public ReplaceCertResponse ReplaceCertSync(ReplaceCertRequest req)
        {
             JsonResponseModel<ReplaceCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置流量镜像的别名。
        /// </summary>
        /// <param name="req"><see cref="SetTrafficMirrorAliasRequest"/></param>
        /// <returns><see cref="SetTrafficMirrorAliasResponse"/></returns>
        public async Task<SetTrafficMirrorAliasResponse> SetTrafficMirrorAlias(SetTrafficMirrorAliasRequest req)
        {
             JsonResponseModel<SetTrafficMirrorAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTrafficMirrorAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTrafficMirrorAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetTrafficMirrorAlias接口的同步版本，设置流量镜像的别名。
        /// </summary>
        /// <param name="req">参考<see cref="SetTrafficMirrorAliasRequest"/></param>
        /// <returns>参考<see cref="SetTrafficMirrorAliasResponse"/>实例</returns>
        public SetTrafficMirrorAliasResponse SetTrafficMirrorAliasSync(SetTrafficMirrorAliasRequest req)
        {
             JsonResponseModel<SetTrafficMirrorAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTrafficMirrorAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTrafficMirrorAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置流量镜像的健康检查参数。
        /// </summary>
        /// <param name="req"><see cref="SetTrafficMirrorHealthSwitchRequest"/></param>
        /// <returns><see cref="SetTrafficMirrorHealthSwitchResponse"/></returns>
        public async Task<SetTrafficMirrorHealthSwitchResponse> SetTrafficMirrorHealthSwitch(SetTrafficMirrorHealthSwitchRequest req)
        {
             JsonResponseModel<SetTrafficMirrorHealthSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTrafficMirrorHealthSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTrafficMirrorHealthSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetTrafficMirrorHealthSwitch接口的同步版本，设置流量镜像的健康检查参数。
        /// </summary>
        /// <param name="req">参考<see cref="SetTrafficMirrorHealthSwitchRequest"/></param>
        /// <returns>参考<see cref="SetTrafficMirrorHealthSwitchResponse"/>实例</returns>
        public SetTrafficMirrorHealthSwitchResponse SetTrafficMirrorHealthSwitchSync(SetTrafficMirrorHealthSwitchRequest req)
        {
             JsonResponseModel<SetTrafficMirrorHealthSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTrafficMirrorHealthSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTrafficMirrorHealthSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑黑石负载均衡四层监听器物理服务器。
        /// </summary>
        /// <param name="req"><see cref="UnbindL4BackendsRequest"/></param>
        /// <returns><see cref="UnbindL4BackendsResponse"/></returns>
        public async Task<UnbindL4BackendsResponse> UnbindL4Backends(UnbindL4BackendsRequest req)
        {
             JsonResponseModel<UnbindL4BackendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindL4Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindL4BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindL4Backends接口的同步版本，解绑黑石负载均衡四层监听器物理服务器。
        /// </summary>
        /// <param name="req">参考<see cref="UnbindL4BackendsRequest"/></param>
        /// <returns>参考<see cref="UnbindL4BackendsResponse"/>实例</returns>
        public UnbindL4BackendsResponse UnbindL4BackendsSync(UnbindL4BackendsRequest req)
        {
             JsonResponseModel<UnbindL4BackendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindL4Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindL4BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑黑石物理服务器或者托管服务器到七层转发路径功能。
        /// </summary>
        /// <param name="req"><see cref="UnbindL7BackendsRequest"/></param>
        /// <returns><see cref="UnbindL7BackendsResponse"/></returns>
        public async Task<UnbindL7BackendsResponse> UnbindL7Backends(UnbindL7BackendsRequest req)
        {
             JsonResponseModel<UnbindL7BackendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindL7Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindL7BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindL7Backends接口的同步版本，解绑黑石物理服务器或者托管服务器到七层转发路径功能。
        /// </summary>
        /// <param name="req">参考<see cref="UnbindL7BackendsRequest"/></param>
        /// <returns>参考<see cref="UnbindL7BackendsResponse"/>实例</returns>
        public UnbindL7BackendsResponse UnbindL7BackendsSync(UnbindL7BackendsRequest req)
        {
             JsonResponseModel<UnbindL7BackendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindL7Backends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindL7BackendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑流量镜像监听器。
        /// </summary>
        /// <param name="req"><see cref="UnbindTrafficMirrorListenersRequest"/></param>
        /// <returns><see cref="UnbindTrafficMirrorListenersResponse"/></returns>
        public async Task<UnbindTrafficMirrorListenersResponse> UnbindTrafficMirrorListeners(UnbindTrafficMirrorListenersRequest req)
        {
             JsonResponseModel<UnbindTrafficMirrorListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindTrafficMirrorListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindTrafficMirrorListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindTrafficMirrorListeners接口的同步版本，解绑流量镜像监听器。
        /// </summary>
        /// <param name="req">参考<see cref="UnbindTrafficMirrorListenersRequest"/></param>
        /// <returns>参考<see cref="UnbindTrafficMirrorListenersResponse"/>实例</returns>
        public UnbindTrafficMirrorListenersResponse UnbindTrafficMirrorListenersSync(UnbindTrafficMirrorListenersRequest req)
        {
             JsonResponseModel<UnbindTrafficMirrorListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindTrafficMirrorListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindTrafficMirrorListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从流量镜像实例上解绑流量镜像接收机。
        /// </summary>
        /// <param name="req"><see cref="UnbindTrafficMirrorReceiversRequest"/></param>
        /// <returns><see cref="UnbindTrafficMirrorReceiversResponse"/></returns>
        public async Task<UnbindTrafficMirrorReceiversResponse> UnbindTrafficMirrorReceivers(UnbindTrafficMirrorReceiversRequest req)
        {
             JsonResponseModel<UnbindTrafficMirrorReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindTrafficMirrorReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindTrafficMirrorReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindTrafficMirrorReceivers接口的同步版本，从流量镜像实例上解绑流量镜像接收机。
        /// </summary>
        /// <param name="req">参考<see cref="UnbindTrafficMirrorReceiversRequest"/></param>
        /// <returns>参考<see cref="UnbindTrafficMirrorReceiversResponse"/>实例</returns>
        public UnbindTrafficMirrorReceiversResponse UnbindTrafficMirrorReceiversSync(UnbindTrafficMirrorReceiversRequest req)
        {
             JsonResponseModel<UnbindTrafficMirrorReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindTrafficMirrorReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindTrafficMirrorReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石负载均衡证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertRequest"/></param>
        /// <returns><see cref="UploadCertResponse"/></returns>
        public async Task<UploadCertResponse> UploadCert(UploadCertRequest req)
        {
             JsonResponseModel<UploadCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UploadCert接口的同步版本，创建黑石负载均衡证书。
        /// </summary>
        /// <param name="req">参考<see cref="UploadCertRequest"/></param>
        /// <returns>参考<see cref="UploadCertResponse"/>实例</returns>
        public UploadCertResponse UploadCertSync(UploadCertRequest req)
        {
             JsonResponseModel<UploadCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
