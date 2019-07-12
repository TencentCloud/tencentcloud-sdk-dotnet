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

namespace TencentCloud.Clb.V20180317
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Clb.V20180317.Models;

   public class ClbClient : AbstractClient{

       private const string endpoint = "clb.tencentcloudapi.com";
       private const string version = "2018-03-17";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public ClbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public ClbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用户需要先创建出一个HTTPS:443监听器，并在其下创建转发规则。通过调用本接口，系统会自动创建出一个HTTP:80监听器（如果之前不存在），并在其下创建转发规则，与HTTPS:443监听器下的Domains（在入参中指定）对应。创建成功后可以通过HTTP:80地址自动跳转为HTTPS:443地址进行访问。
        /// </summary>
        /// <param name="req">参考<see cref="AutoRewriteRequest"/></param>
        /// <returns>参考<see cref="AutoRewriteResponse"/>实例</returns>
        public async Task<AutoRewriteResponse> AutoRewrite(AutoRewriteRequest req)
        {
             JsonResponseModel<AutoRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AutoRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AutoRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BatchModifyTargetWeight接口用于批量修改监听器绑定的后端机器的转发权重，当前接口只支持应用型HTTP/HTTPS监听器。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns>参考<see cref="BatchModifyTargetWeightResponse"/>实例</returns>
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
        /// 在一个负载均衡实例下创建监听器。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="CreateListenerRequest"/></param>
        /// <returns>参考<see cref="CreateListenerResponse"/>实例</returns>
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
        /// CreateLoadBalancer 接口用来创建负载均衡实例。为了使用负载均衡服务，您必须购买一个或多个负载均衡实例。成功调用该接口后，会返回负载均衡实例的唯一 ID。负载均衡实例的类型分为：公网、内网。详情可参考产品说明中的产品类型。
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLoadBalancerRequest"/></param>
        /// <returns>参考<see cref="CreateLoadBalancerResponse"/>实例</returns>
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
        /// CreateRule 接口用于在一个已存在的负载均衡七层监听器下创建转发规则，七层监听器中，后端服务必须绑定到规则上而非监听器上。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="CreateRuleRequest"/></param>
        /// <returns>参考<see cref="CreateRuleResponse"/>实例</returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来删除负载均衡实例下的监听器（四层和七层）。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteListenerRequest"/></param>
        /// <returns>参考<see cref="DeleteListenerResponse"/>实例</returns>
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
        /// DeleteLoadBalancer 接口用以删除指定的一个或多个负载均衡实例。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns>参考<see cref="DeleteLoadBalancerResponse"/>实例</returns>
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
        /// DeleteRewrite 接口支持删除指定转发规则之间的重定向关系。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRewriteRequest"/></param>
        /// <returns>参考<see cref="DeleteRewriteResponse"/>实例</returns>
        public async Task<DeleteRewriteResponse> DeleteRewrite(DeleteRewriteRequest req)
        {
             JsonResponseModel<DeleteRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteRule 接口用来删除负载均衡实例七层监听器下的转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteRuleResponse"/>实例</returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeregisterTargets 接口用来将一台或多台后端机器从应用型负载均衡的监听器上解绑，对于四层监听器（TCP、UDP），只需指定监听器ID即可，对于七层监听器（HTTP、HTTPS），还需通过LocationId或者Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="DeregisterTargetsRequest"/></param>
        /// <returns>参考<see cref="DeregisterTargetsResponse"/>实例</returns>
        public async Task<DeregisterTargetsResponse> DeregisterTargets(DeregisterTargetsRequest req)
        {
             JsonResponseModel<DeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeregisterTargetsFromClassicalLB 接口用于解绑负载均衡后端服务。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns>参考<see cref="DeregisterTargetsFromClassicalLBResponse"/>实例</returns>
        public async Task<DeregisterTargetsFromClassicalLBResponse> DeregisterTargetsFromClassicalLB(DeregisterTargetsFromClassicalLBRequest req)
        {
             JsonResponseModel<DeregisterTargetsFromClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargetsFromClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsFromClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBByInstanceId用于通过后端实例ID获取传统型负载均衡ID列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns>参考<see cref="DescribeClassicalLBByInstanceIdResponse"/>实例</returns>
        public async Task<DescribeClassicalLBByInstanceIdResponse> DescribeClassicalLBByInstanceId(DescribeClassicalLBByInstanceIdRequest req)
        {
             JsonResponseModel<DescribeClassicalLBByInstanceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBByInstanceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBByInstanceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBHealthStatus用于获取传统型负载均衡后端的健康状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeClassicalLBHealthStatusResponse"/>实例</returns>
        public async Task<DescribeClassicalLBHealthStatusResponse> DescribeClassicalLBHealthStatus(DescribeClassicalLBHealthStatusRequest req)
        {
             JsonResponseModel<DescribeClassicalLBHealthStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBHealthStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBHealthStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBListeners 接口用于获取传统型负载均衡的监听器信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeClassicalLBListenersResponse"/>实例</returns>
        public async Task<DescribeClassicalLBListenersResponse> DescribeClassicalLBListeners(DescribeClassicalLBListenersRequest req)
        {
             JsonResponseModel<DescribeClassicalLBListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeClassicalLBTargets用于获取传统型负载均衡绑定的后端服务
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns>参考<see cref="DescribeClassicalLBTargetsResponse"/>实例</returns>
        public async Task<DescribeClassicalLBTargetsResponse> DescribeClassicalLBTargets(DescribeClassicalLBTargetsRequest req)
        {
             JsonResponseModel<DescribeClassicalLBTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeListeners 接口可根据负载均衡器 ID，监听器的协议或端口作为过滤条件获取监听器列表。如果不指定任何过滤条件，默认返该负载均衡器下的默认数据长度（20 个）的监听器。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeListenersRequest"/></param>
        /// <returns>参考<see cref="DescribeListenersResponse"/>实例</returns>
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
        /// 查询负载均衡实例列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns>参考<see cref="DescribeLoadBalancersResponse"/>实例</returns>
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
        /// DescribeRewrite 接口可根据负载均衡实例ID，查询一个负载均衡实例下转发规则的重定向关系。如果不指定监听器ID或转发规则ID，则返回该负载均衡实例下的所有重定向关系。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRewriteRequest"/></param>
        /// <returns>参考<see cref="DescribeRewriteResponse"/>实例</returns>
        public async Task<DescribeRewriteResponse> DescribeRewrite(DescribeRewriteRequest req)
        {
             JsonResponseModel<DescribeRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTargetHealth 接口用来获取应用型负载均衡后端的健康检查结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTargetHealthRequest"/></param>
        /// <returns>参考<see cref="DescribeTargetHealthResponse"/>实例</returns>
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
        /// DescribeTargets 接口用来查询应用型负载均衡实例的某些监听器后端绑定的机器列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTargetsRequest"/></param>
        /// <returns>参考<see cref="DescribeTargetsResponse"/>实例</returns>
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
        /// 本接口用于查询异步任务的执行状态，对于非查询类的接口（创建/删除负载均衡实例、监听器、规则以及绑定或解绑后端服务等），在接口调用成功后，都需要使用本接口查询任务最终是否执行成功。
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
        /// 用户手动配置原访问地址和重定向地址，系统自动将原访问地址的请求重定向至对应路径的目的地址。同一域名下可以配置多条路径作为重定向策略，实现http/https之间请求的自动跳转。设置重定向时，需满足如下约束条件：若A已经重定向至B，则A不能再重定向至C（除非先删除老的重定向关系，再建立新的重定向关系），B不能重定向至任何其它地址。
        /// </summary>
        /// <param name="req">参考<see cref="ManualRewriteRequest"/></param>
        /// <returns>参考<see cref="ManualRewriteResponse"/>实例</returns>
        public async Task<ManualRewriteResponse> ManualRewrite(ManualRewriteRequest req)
        {
             JsonResponseModel<ManualRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManualRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDomain接口用来修改负载均衡七层监听器下的域名。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDomainRequest"/></param>
        /// <returns>参考<see cref="ModifyDomainResponse"/>实例</returns>
        public async Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyListener接口用来修改应用型负载均衡监听器的属性，包括监听器名称、健康检查参数、证书信息、转发策略等。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyListenerRequest"/></param>
        /// <returns>参考<see cref="ModifyListenerResponse"/>实例</returns>
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
        /// 修改负载均衡实例的属性。支持修改负载均衡实例的名称、设置负载均衡的跨域属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns>参考<see cref="ModifyLoadBalancerAttributesResponse"/>实例</returns>
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
        /// ModifyRule 接口用来修改负载均衡七层监听器下的转发规则的各项属性，包括转发路径、健康检查属性、转发策略等。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyRuleRequest"/></param>
        /// <returns>参考<see cref="ModifyRuleResponse"/>实例</returns>
        public async Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTargetPort接口用于修改监听器绑定的后端云服务器的端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTargetPortRequest"/></param>
        /// <returns>参考<see cref="ModifyTargetPortResponse"/>实例</returns>
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
        /// ModifyTargetWeight 接口用于修改监听器绑定的后端机器的转发权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTargetWeightRequest"/></param>
        /// <returns>参考<see cref="ModifyTargetWeightResponse"/>实例</returns>
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
        /// RegisterTargets 接口用来将一台或多台后端服务绑定到负载均衡的监听器（或7层转发规则），在此之前您需要先行创建相关的4层监听器或7层转发规则。对于四层监听器（TCP、UDP），只需指定监听器ID即可，对于七层监听器（HTTP、HTTPS），还需通过LocationId或者Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="RegisterTargetsRequest"/></param>
        /// <returns>参考<see cref="RegisterTargetsResponse"/>实例</returns>
        public async Task<RegisterTargetsResponse> RegisterTargets(RegisterTargetsRequest req)
        {
             JsonResponseModel<RegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RegisterTargetsWithClassicalLB 接口用于绑定后端服务到传统型负载均衡。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req">参考<see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns>参考<see cref="RegisterTargetsWithClassicalLBResponse"/>实例</returns>
        public async Task<RegisterTargetsWithClassicalLBResponse> RegisterTargetsWithClassicalLB(RegisterTargetsWithClassicalLBRequest req)
        {
             JsonResponseModel<RegisterTargetsWithClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargetsWithClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsWithClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetLoadBalancerSecurityGroups 接口支持对一个公网负载均衡实例执行设置（绑定、解绑）安全组操作。查询一个负载均衡实例目前已绑定的安全组，可使用 DescribeLoadBalancers 接口。本接口是set语义，
        /// 绑定操作时，入参需要传入负载均衡实例要绑定的所有安全组（已绑定的+新增绑定的）。
        /// 解绑操作时，入参需要传入负载均衡实例执行解绑后所绑定的所有安全组；如果要解绑所有安全组，可不传此参数，或传入空数组。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req">参考<see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="SetLoadBalancerSecurityGroupsResponse"/>实例</returns>
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
        /// 绑定或解绑一个安全组到多个公网负载均衡实例。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req">参考<see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns>参考<see cref="SetSecurityGroupForLoadbalancersResponse"/>实例</returns>
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

    }
}
