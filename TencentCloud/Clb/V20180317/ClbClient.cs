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
       private const string sdkVersion = "SDK_NET_3.0.991";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ClbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(AssociateTargetGroups)用来将目标组绑定到负载均衡的监听器（四层协议）或转发规则（七层协议）上。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public Task<AssociateTargetGroupsResponse> AssociateTargetGroups(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups");
        }

        /// <summary>
        /// 本接口(AssociateTargetGroups)用来将目标组绑定到负载均衡的监听器（四层协议）或转发规则（七层协议）上。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public AssociateTargetGroupsResponse AssociateTargetGroupsSync(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户需要先创建出一个HTTPS:443监听器，并在其下创建转发规则。通过调用本接口，系统会自动创建出一个HTTP:80监听器（如果之前不存在），并在其下创建转发规则，与HTTPS:443监听器下的Domains（在入参中指定）对应。创建成功后可以通过HTTP:80地址自动跳转为HTTPS:443地址进行访问。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public Task<AutoRewriteResponse> AutoRewrite(AutoRewriteRequest req)
        {
            return InternalRequestAsync<AutoRewriteResponse>(req, "AutoRewrite");
        }

        /// <summary>
        /// 用户需要先创建出一个HTTPS:443监听器，并在其下创建转发规则。通过调用本接口，系统会自动创建出一个HTTP:80监听器（如果之前不存在），并在其下创建转发规则，与HTTPS:443监听器下的Domains（在入参中指定）对应。创建成功后可以通过HTTP:80地址自动跳转为HTTPS:443地址进行访问。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public AutoRewriteResponse AutoRewriteSync(AutoRewriteRequest req)
        {
            return InternalRequestAsync<AutoRewriteResponse>(req, "AutoRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量解绑四七层后端服务。批量解绑的资源数量上限为500。只支持VPC网络负载均衡。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public Task<BatchDeregisterTargetsResponse> BatchDeregisterTargets(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets");
        }

        /// <summary>
        /// 批量解绑四七层后端服务。批量解绑的资源数量上限为500。只支持VPC网络负载均衡。
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public BatchDeregisterTargetsResponse BatchDeregisterTargetsSync(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// BatchModifyTargetTag 接口用于批量修改负载均衡监听器绑定的后端机器的标签。批量修改的资源数量上限为500。本接口为同步接口。<br/>负载均衡的4层和7层监听器支持此接口，传统型负载均衡不支持。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetTagRequest"/></param>
        /// <returns><see cref="BatchModifyTargetTagResponse"/></returns>
        public Task<BatchModifyTargetTagResponse> BatchModifyTargetTag(BatchModifyTargetTagRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetTagResponse>(req, "BatchModifyTargetTag");
        }

        /// <summary>
        /// BatchModifyTargetTag 接口用于批量修改负载均衡监听器绑定的后端机器的标签。批量修改的资源数量上限为500。本接口为同步接口。<br/>负载均衡的4层和7层监听器支持此接口，传统型负载均衡不支持。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetTagRequest"/></param>
        /// <returns><see cref="BatchModifyTargetTagResponse"/></returns>
        public BatchModifyTargetTagResponse BatchModifyTargetTagSync(BatchModifyTargetTagRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetTagResponse>(req, "BatchModifyTargetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// BatchModifyTargetWeight 接口用于批量修改负载均衡监听器绑定的后端机器的转发权重。批量修改的资源数量上限为500。本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。<br/>负载均衡的4层和7层监听器支持此接口，传统型负载均衡不支持。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight");
        }

        /// <summary>
        /// BatchModifyTargetWeight 接口用于批量修改负载均衡监听器绑定的后端机器的转发权重。批量修改的资源数量上限为500。本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。<br/>负载均衡的4层和7层监听器支持此接口，传统型负载均衡不支持。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public BatchModifyTargetWeightResponse BatchModifyTargetWeightSync(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量绑定虚拟主机或弹性网卡，支持跨域绑定，支持四层、七层（TCP、UDP、HTTP、HTTPS）协议绑定。批量绑定的资源数量上限为500。只支持VPC网络负载均衡。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public Task<BatchRegisterTargetsResponse> BatchRegisterTargets(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets");
        }

        /// <summary>
        /// 批量绑定虚拟主机或弹性网卡，支持跨域绑定，支持四层、七层（TCP、UDP、HTTP、HTTPS）协议绑定。批量绑定的资源数量上限为500。只支持VPC网络负载均衡。
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public BatchRegisterTargetsResponse BatchRegisterTargetsSync(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 克隆负载均衡实例，根据指定的负载均衡实例，复制出相同规则和绑定关系的负载均衡实例。克隆接口为异步操作，克隆的数据以调用CloneLoadBalancer时为准，如果调用CloneLoadBalancer后克隆CLB发生变化，变化规则不会克隆。
        /// 
        /// 注：查询实例创建状态可以根据返回值中的requestId访问[DescribeTaskStatus](https://cloud.tencent.com/document/product/214/30683)接口
        /// 
        /// 限制说明：
        /// 实例属性维度限制
        ///   仅支持克隆按量计费实例，不支持包年包月实例。
        ///   不支持克隆未关联实例计费项的 CLB。
        ///   不支持克隆传统型负载均衡实例和高防 CLB。
        ///   不支持克隆基础网络类型的实例。
        ///   不支持克隆 IPv6、IPv6 NAT64 版本以及混绑的实例。
        ///   个性化配置、重定向配置、安全组默认放通开关的配置将不会被克隆，需重新配置。
        ///   执行克隆操作前，请确保实例上没有使用已过期证书，否则会导致克隆失败。
        /// 监听器维度限制
        ///   不支持克隆监听器为 QUIC 类型和端口段的实例。
        ///   不支持监听器为 TCP_SSL 的内网型负载均衡的实例。
        ///   不支持克隆七层监听器没有转发规则的实例。
        ///   当实例的监听器个数超过50个时，不支持克隆。
        /// 后端服务维度限制
        ///   不支持克隆绑定的后端服务类型为目标组和 SCF 云函数的实例。
        /// 
        /// 通过接口调用：
        /// BGP带宽包必须传带宽包id
        /// 独占集群克隆必须传对应的参数，否则按共享型创建
        /// 功能内测中，请提交 [内测申请](https://cloud.tencent.com/apply/p/1akuvsmyn0g)。
        /// </summary>
        /// <param name="req"><see cref="CloneLoadBalancerRequest"/></param>
        /// <returns><see cref="CloneLoadBalancerResponse"/></returns>
        public Task<CloneLoadBalancerResponse> CloneLoadBalancer(CloneLoadBalancerRequest req)
        {
            return InternalRequestAsync<CloneLoadBalancerResponse>(req, "CloneLoadBalancer");
        }

        /// <summary>
        /// 克隆负载均衡实例，根据指定的负载均衡实例，复制出相同规则和绑定关系的负载均衡实例。克隆接口为异步操作，克隆的数据以调用CloneLoadBalancer时为准，如果调用CloneLoadBalancer后克隆CLB发生变化，变化规则不会克隆。
        /// 
        /// 注：查询实例创建状态可以根据返回值中的requestId访问[DescribeTaskStatus](https://cloud.tencent.com/document/product/214/30683)接口
        /// 
        /// 限制说明：
        /// 实例属性维度限制
        ///   仅支持克隆按量计费实例，不支持包年包月实例。
        ///   不支持克隆未关联实例计费项的 CLB。
        ///   不支持克隆传统型负载均衡实例和高防 CLB。
        ///   不支持克隆基础网络类型的实例。
        ///   不支持克隆 IPv6、IPv6 NAT64 版本以及混绑的实例。
        ///   个性化配置、重定向配置、安全组默认放通开关的配置将不会被克隆，需重新配置。
        ///   执行克隆操作前，请确保实例上没有使用已过期证书，否则会导致克隆失败。
        /// 监听器维度限制
        ///   不支持克隆监听器为 QUIC 类型和端口段的实例。
        ///   不支持监听器为 TCP_SSL 的内网型负载均衡的实例。
        ///   不支持克隆七层监听器没有转发规则的实例。
        ///   当实例的监听器个数超过50个时，不支持克隆。
        /// 后端服务维度限制
        ///   不支持克隆绑定的后端服务类型为目标组和 SCF 云函数的实例。
        /// 
        /// 通过接口调用：
        /// BGP带宽包必须传带宽包id
        /// 独占集群克隆必须传对应的参数，否则按共享型创建
        /// 功能内测中，请提交 [内测申请](https://cloud.tencent.com/apply/p/1akuvsmyn0g)。
        /// </summary>
        /// <param name="req"><see cref="CloneLoadBalancerRequest"/></param>
        /// <returns><see cref="CloneLoadBalancerResponse"/></returns>
        public CloneLoadBalancerResponse CloneLoadBalancerSync(CloneLoadBalancerRequest req)
        {
            return InternalRequestAsync<CloneLoadBalancerResponse>(req, "CloneLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建CLB专有日志集，此日志集用于存储CLB的日志。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public Task<CreateClsLogSetResponse> CreateClsLogSet(CreateClsLogSetRequest req)
        {
            return InternalRequestAsync<CreateClsLogSetResponse>(req, "CreateClsLogSet");
        }

        /// <summary>
        /// 创建CLB专有日志集，此日志集用于存储CLB的日志。
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public CreateClsLogSetResponse CreateClsLogSetSync(CreateClsLogSetRequest req)
        {
            return InternalRequestAsync<CreateClsLogSetResponse>(req, "CreateClsLogSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在一个负载均衡实例下创建监听器。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// 在一个负载均衡实例下创建监听器。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateLoadBalancer)用来创建负载均衡实例（本接口只支持购买按量计费的负载均衡，包年包月的负载均衡请通过控制台购买）。为了使用负载均衡服务，您必须购买一个或多个负载均衡实例。成功调用该接口后，会返回负载均衡实例的唯一 ID。负载均衡实例的类型分为：公网、内网。详情可参考产品说明中的产品类型。
        /// 注意：(1)指定可用区申请负载均衡、跨zone容灾(仅香港支持)【如果您需要体验该功能，请通过 [工单申请](https://console.cloud.tencent.com/workorder/category)】；(2)目前只有北京、上海、广州支持IPv6；(3)一个账号在每个地域的默认购买配额为：公网100个，内网100个。
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// 本接口(CreateLoadBalancer)用来创建负载均衡实例（本接口只支持购买按量计费的负载均衡，包年包月的负载均衡请通过控制台购买）。为了使用负载均衡服务，您必须购买一个或多个负载均衡实例。成功调用该接口后，会返回负载均衡实例的唯一 ID。负载均衡实例的类型分为：公网、内网。详情可参考产品说明中的产品类型。
        /// 注意：(1)指定可用区申请负载均衡、跨zone容灾(仅香港支持)【如果您需要体验该功能，请通过 [工单申请](https://console.cloud.tencent.com/workorder/category)】；(2)目前只有北京、上海、广州支持IPv6；(3)一个账号在每个地域的默认购买配额为：公网100个，内网100个。
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对SnatPro负载均衡，这个接口用于添加SnatIp，如果负载均衡没有开启SnatPro，添加SnatIp后会自动开启。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public Task<CreateLoadBalancerSnatIpsResponse> CreateLoadBalancerSnatIps(CreateLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerSnatIpsResponse>(req, "CreateLoadBalancerSnatIps");
        }

        /// <summary>
        /// 针对SnatPro负载均衡，这个接口用于添加SnatIp，如果负载均衡没有开启SnatPro，添加SnatIp后会自动开启。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public CreateLoadBalancerSnatIpsResponse CreateLoadBalancerSnatIpsSync(CreateLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerSnatIpsResponse>(req, "CreateLoadBalancerSnatIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateRule 接口用于在一个已存在的负载均衡七层监听器下创建转发规则，七层监听器中，后端服务必须绑定到规则上而非监听器上。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// CreateRule 接口用于在一个已存在的负载均衡七层监听器下创建转发规则，七层监听器中，后端服务必须绑定到规则上而非监听器上。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建目标组。该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup");
        }

        /// <summary>
        /// 创建目标组。该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建主题，默认开启全文索引和键值索引。如果不存在CLB专有日志集，则创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// 创建主题，默认开启全文索引和键值索引。如果不存在CLB专有日志集，则创建失败。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用来删除负载均衡实例下的监听器（四层和七层）。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// 本接口用来删除负载均衡实例下的监听器（四层和七层）。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteLoadBalancer 接口用以删除指定的一个或多个负载均衡实例。成功删除后，会把负载均衡实例下的监听器、转发规则一起删除，并把后端服务解绑。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// DeleteLoadBalancer 接口用以删除指定的一个或多个负载均衡实例。成功删除后，会把负载均衡实例下的监听器、转发规则一起删除，并把后端服务解绑。
        /// 本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口支持删除负载均衡的多个监听器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners");
        }

        /// <summary>
        /// 该接口支持删除负载均衡的多个监听器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 这个接口用于删除SnatPro的负载均衡的SnatIp。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public Task<DeleteLoadBalancerSnatIpsResponse> DeleteLoadBalancerSnatIps(DeleteLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerSnatIpsResponse>(req, "DeleteLoadBalancerSnatIps");
        }

        /// <summary>
        /// 这个接口用于删除SnatPro的负载均衡的SnatIp。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public DeleteLoadBalancerSnatIpsResponse DeleteLoadBalancerSnatIpsSync(DeleteLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerSnatIpsResponse>(req, "DeleteLoadBalancerSnatIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteRewrite 接口支持删除指定转发规则之间的重定向关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public Task<DeleteRewriteResponse> DeleteRewrite(DeleteRewriteRequest req)
        {
            return InternalRequestAsync<DeleteRewriteResponse>(req, "DeleteRewrite");
        }

        /// <summary>
        /// DeleteRewrite 接口支持删除指定转发规则之间的重定向关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public DeleteRewriteResponse DeleteRewriteSync(DeleteRewriteRequest req)
        {
            return InternalRequestAsync<DeleteRewriteResponse>(req, "DeleteRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteRule 接口用来删除负载均衡实例七层监听器下的转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// DeleteRule 接口用来删除负载均衡实例七层监听器下的转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除目标组
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups");
        }

        /// <summary>
        /// 删除目标组
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeregisterFunctionTargets 接口用来将一个云函数从负载均衡的转发规则上解绑，对于七层监听器，还需通过 LocationId 或 Domain+Url 指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 [DescribeTaskStatus](https://cloud.tencent.com/document/product/214/30683) 接口查询本次任务是否成功。
        /// <br/>限制说明：
        /// 
        /// - 仅广州、深圳金融、上海、上海金融、北京、成都、中国香港、新加坡、孟买、东京、硅谷地域支持绑定 SCF。
        /// - 仅标准账户类型支持绑定 SCF，传统账户类型不支持。建议升级为标准账户类型，详情可参见 [账户类型升级说明](https://cloud.tencent.com/document/product/1199/49090)。
        /// - 传统型负载均衡不支持绑定 SCF。
        /// - 基础网络类型不支持绑定 SCF。
        /// - CLB 默认支持绑定同地域下的所有 SCF，可支持跨 VPC 绑定 SCF，不支持跨地域绑定。
        /// - 目前仅 IPv4、IPv6 NAT64 版本的负载均衡支持绑定 SCF，IPv6 版本的暂不支持。
        /// - 仅七层（HTTP、HTTPS）监听器支持绑定 SCF，四层（TCP、UDP、TCP SSL）监听器和七层 QUIC 监听器不支持。
        /// - CLB 绑定 SCF 仅支持绑定“Event 函数”类型的云函数。
        /// </summary>
        /// <param name="req"><see cref="DeregisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="DeregisterFunctionTargetsResponse"/></returns>
        public Task<DeregisterFunctionTargetsResponse> DeregisterFunctionTargets(DeregisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterFunctionTargetsResponse>(req, "DeregisterFunctionTargets");
        }

        /// <summary>
        /// DeregisterFunctionTargets 接口用来将一个云函数从负载均衡的转发规则上解绑，对于七层监听器，还需通过 LocationId 或 Domain+Url 指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 [DescribeTaskStatus](https://cloud.tencent.com/document/product/214/30683) 接口查询本次任务是否成功。
        /// <br/>限制说明：
        /// 
        /// - 仅广州、深圳金融、上海、上海金融、北京、成都、中国香港、新加坡、孟买、东京、硅谷地域支持绑定 SCF。
        /// - 仅标准账户类型支持绑定 SCF，传统账户类型不支持。建议升级为标准账户类型，详情可参见 [账户类型升级说明](https://cloud.tencent.com/document/product/1199/49090)。
        /// - 传统型负载均衡不支持绑定 SCF。
        /// - 基础网络类型不支持绑定 SCF。
        /// - CLB 默认支持绑定同地域下的所有 SCF，可支持跨 VPC 绑定 SCF，不支持跨地域绑定。
        /// - 目前仅 IPv4、IPv6 NAT64 版本的负载均衡支持绑定 SCF，IPv6 版本的暂不支持。
        /// - 仅七层（HTTP、HTTPS）监听器支持绑定 SCF，四层（TCP、UDP、TCP SSL）监听器和七层 QUIC 监听器不支持。
        /// - CLB 绑定 SCF 仅支持绑定“Event 函数”类型的云函数。
        /// </summary>
        /// <param name="req"><see cref="DeregisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="DeregisterFunctionTargetsResponse"/></returns>
        public DeregisterFunctionTargetsResponse DeregisterFunctionTargetsSync(DeregisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterFunctionTargetsResponse>(req, "DeregisterFunctionTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从目标组中解绑服务器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public Task<DeregisterTargetGroupInstancesResponse> DeregisterTargetGroupInstances(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances");
        }

        /// <summary>
        /// 从目标组中解绑服务器。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public DeregisterTargetGroupInstancesResponse DeregisterTargetGroupInstancesSync(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeregisterTargets 接口用来将一台或多台后端服务从负载均衡的监听器或转发规则上解绑，对于四层监听器，只需指定监听器ID即可，对于七层监听器，还需通过LocationId或Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public Task<DeregisterTargetsResponse> DeregisterTargets(DeregisterTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsResponse>(req, "DeregisterTargets");
        }

        /// <summary>
        /// DeregisterTargets 接口用来将一台或多台后端服务从负载均衡的监听器或转发规则上解绑，对于四层监听器，只需指定监听器ID即可，对于七层监听器，还需通过LocationId或Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public DeregisterTargetsResponse DeregisterTargetsSync(DeregisterTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsResponse>(req, "DeregisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeregisterTargetsFromClassicalLB 接口用于解绑负载均衡后端服务。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public Task<DeregisterTargetsFromClassicalLBResponse> DeregisterTargetsFromClassicalLB(DeregisterTargetsFromClassicalLBRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsFromClassicalLBResponse>(req, "DeregisterTargetsFromClassicalLB");
        }

        /// <summary>
        /// DeregisterTargetsFromClassicalLB 接口用于解绑负载均衡后端服务。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public DeregisterTargetsFromClassicalLBResponse DeregisterTargetsFromClassicalLBSync(DeregisterTargetsFromClassicalLBRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsFromClassicalLBResponse>(req, "DeregisterTargetsFromClassicalLB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询一个负载均衡所封禁的IP列表（黑名单）。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public Task<DescribeBlockIPListResponse> DescribeBlockIPList(DescribeBlockIPListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPListResponse>(req, "DescribeBlockIPList");
        }

        /// <summary>
        /// 查询一个负载均衡所封禁的IP列表（黑名单）。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public DescribeBlockIPListResponse DescribeBlockIPListSync(DescribeBlockIPListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPListResponse>(req, "DescribeBlockIPList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据 ModifyBlockIPList 接口返回的异步任务的ID，查询封禁IP（黑名单）异步任务的执行状态。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public Task<DescribeBlockIPTaskResponse> DescribeBlockIPTask(DescribeBlockIPTaskRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPTaskResponse>(req, "DescribeBlockIPTask");
        }

        /// <summary>
        /// 根据 ModifyBlockIPList 接口返回的异步任务的ID，查询封禁IP（黑名单）异步任务的执行状态。（接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public DescribeBlockIPTaskResponse DescribeBlockIPTaskSync(DescribeBlockIPTaskRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPTaskResponse>(req, "DescribeBlockIPTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeClassicalLBByInstanceId用于通过后端实例ID获取传统型负载均衡ID列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public Task<DescribeClassicalLBByInstanceIdResponse> DescribeClassicalLBByInstanceId(DescribeClassicalLBByInstanceIdRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBByInstanceIdResponse>(req, "DescribeClassicalLBByInstanceId");
        }

        /// <summary>
        /// DescribeClassicalLBByInstanceId用于通过后端实例ID获取传统型负载均衡ID列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public DescribeClassicalLBByInstanceIdResponse DescribeClassicalLBByInstanceIdSync(DescribeClassicalLBByInstanceIdRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBByInstanceIdResponse>(req, "DescribeClassicalLBByInstanceId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeClassicalLBHealthStatus用于获取传统型负载均衡后端的健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public Task<DescribeClassicalLBHealthStatusResponse> DescribeClassicalLBHealthStatus(DescribeClassicalLBHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBHealthStatusResponse>(req, "DescribeClassicalLBHealthStatus");
        }

        /// <summary>
        /// DescribeClassicalLBHealthStatus用于获取传统型负载均衡后端的健康状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public DescribeClassicalLBHealthStatusResponse DescribeClassicalLBHealthStatusSync(DescribeClassicalLBHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBHealthStatusResponse>(req, "DescribeClassicalLBHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeClassicalLBListeners 接口用于获取传统型负载均衡的监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public Task<DescribeClassicalLBListenersResponse> DescribeClassicalLBListeners(DescribeClassicalLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBListenersResponse>(req, "DescribeClassicalLBListeners");
        }

        /// <summary>
        /// DescribeClassicalLBListeners 接口用于获取传统型负载均衡的监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public DescribeClassicalLBListenersResponse DescribeClassicalLBListenersSync(DescribeClassicalLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBListenersResponse>(req, "DescribeClassicalLBListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeClassicalLBTargets用于获取传统型负载均衡绑定的后端服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public Task<DescribeClassicalLBTargetsResponse> DescribeClassicalLBTargets(DescribeClassicalLBTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBTargetsResponse>(req, "DescribeClassicalLBTargets");
        }

        /// <summary>
        /// DescribeClassicalLBTargets用于获取传统型负载均衡绑定的后端服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public DescribeClassicalLBTargetsResponse DescribeClassicalLBTargetsSync(DescribeClassicalLBTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBTargetsResponse>(req, "DescribeClassicalLBTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户的CLB专有日志集。
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public Task<DescribeClsLogSetResponse> DescribeClsLogSet(DescribeClsLogSetRequest req)
        {
            return InternalRequestAsync<DescribeClsLogSetResponse>(req, "DescribeClsLogSet");
        }

        /// <summary>
        /// 获取用户的CLB专有日志集。
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public DescribeClsLogSetResponse DescribeClsLogSetSync(DescribeClsLogSetRequest req)
        {
            return InternalRequestAsync<DescribeClsLogSetResponse>(req, "DescribeClsLogSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询独占集群中的资源列表，支持按集群ID、VIP、负载均衡ID、是否闲置为过滤条件检索。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterResourcesRequest"/></param>
        /// <returns><see cref="DescribeClusterResourcesResponse"/></returns>
        public Task<DescribeClusterResourcesResponse> DescribeClusterResources(DescribeClusterResourcesRequest req)
        {
            return InternalRequestAsync<DescribeClusterResourcesResponse>(req, "DescribeClusterResources");
        }

        /// <summary>
        /// 查询独占集群中的资源列表，支持按集群ID、VIP、负载均衡ID、是否闲置为过滤条件检索。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterResourcesRequest"/></param>
        /// <returns><see cref="DescribeClusterResourcesResponse"/></returns>
        public DescribeClusterResourcesResponse DescribeClusterResourcesSync(DescribeClusterResourcesRequest req)
        {
            return InternalRequestAsync<DescribeClusterResourcesResponse>(req, "DescribeClusterResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询跨域2.0版本云联网后端子机和网卡信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossTargetsRequest"/></param>
        /// <returns><see cref="DescribeCrossTargetsResponse"/></returns>
        public Task<DescribeCrossTargetsResponse> DescribeCrossTargets(DescribeCrossTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCrossTargetsResponse>(req, "DescribeCrossTargets");
        }

        /// <summary>
        /// 查询跨域2.0版本云联网后端子机和网卡信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossTargetsRequest"/></param>
        /// <returns><see cref="DescribeCrossTargetsResponse"/></returns>
        public DescribeCrossTargetsResponse DescribeCrossTargetsSync(DescribeCrossTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCrossTargetsResponse>(req, "DescribeCrossTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取配置绑定的 server 或 location，如果 domain 存在，结果将根据 domain 过滤。或拉取配置绑定的 loadbalancer。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public Task<DescribeCustomizedConfigAssociateListResponse> DescribeCustomizedConfigAssociateList(DescribeCustomizedConfigAssociateListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigAssociateListResponse>(req, "DescribeCustomizedConfigAssociateList");
        }

        /// <summary>
        /// 拉取配置绑定的 server 或 location，如果 domain 存在，结果将根据 domain 过滤。或拉取配置绑定的 loadbalancer。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public DescribeCustomizedConfigAssociateListResponse DescribeCustomizedConfigAssociateListSync(DescribeCustomizedConfigAssociateListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigAssociateListResponse>(req, "DescribeCustomizedConfigAssociateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取个性化配置列表，返回用户 AppId 下指定类型的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public Task<DescribeCustomizedConfigListResponse> DescribeCustomizedConfigList(DescribeCustomizedConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigListResponse>(req, "DescribeCustomizedConfigList");
        }

        /// <summary>
        /// 拉取个性化配置列表，返回用户 AppId 下指定类型的配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public DescribeCustomizedConfigListResponse DescribeCustomizedConfigListSync(DescribeCustomizedConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigListResponse>(req, "DescribeCustomizedConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群信息列表，支持以集群类型、集群唯一ID、集群名字、集群标签、集群内vip、集群内负载均衡唯一id、集群网络类型、可用区等条件进行检索
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveClustersRequest"/></param>
        /// <returns><see cref="DescribeExclusiveClustersResponse"/></returns>
        public Task<DescribeExclusiveClustersResponse> DescribeExclusiveClusters(DescribeExclusiveClustersRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveClustersResponse>(req, "DescribeExclusiveClusters");
        }

        /// <summary>
        /// 查询集群信息列表，支持以集群类型、集群唯一ID、集群名字、集群标签、集群内vip、集群内负载均衡唯一id、集群网络类型、可用区等条件进行检索
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveClustersRequest"/></param>
        /// <returns><see cref="DescribeExclusiveClustersResponse"/></returns>
        public DescribeExclusiveClustersResponse DescribeExclusiveClustersSync(DescribeExclusiveClustersRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveClustersResponse>(req, "DescribeExclusiveClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 闲置实例是指创建超过7天后付费实例，且没有创建规则或创建规则没有绑定子机的负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeIdleLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeIdleLoadBalancersResponse"/></returns>
        public Task<DescribeIdleLoadBalancersResponse> DescribeIdleLoadBalancers(DescribeIdleLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeIdleLoadBalancersResponse>(req, "DescribeIdleLoadBalancers");
        }

        /// <summary>
        /// 闲置实例是指创建超过7天后付费实例，且没有创建规则或创建规则没有绑定子机的负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeIdleLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeIdleLoadBalancersResponse"/></returns>
        public DescribeIdleLoadBalancersResponse DescribeIdleLoadBalancersSync(DescribeIdleLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeIdleLoadBalancersResponse>(req, "DescribeIdleLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询后端云主机或弹性网卡绑定的负载均衡，支持弹性网卡和cvm查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public Task<DescribeLBListenersResponse> DescribeLBListeners(DescribeLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeLBListenersResponse>(req, "DescribeLBListeners");
        }

        /// <summary>
        /// 查询后端云主机或弹性网卡绑定的负载均衡，支持弹性网卡和cvm查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public DescribeLBListenersResponse DescribeLBListenersSync(DescribeLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeLBListenersResponse>(req, "DescribeLBListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeListeners 接口可根据负载均衡器 ID、监听器的协议或端口作为过滤条件获取监听器列表。如果不指定任何过滤条件，则返回该负载均衡实例下的所有监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// DescribeListeners 接口可根据负载均衡器 ID、监听器的协议或端口作为过滤条件获取监听器列表。如果不指定任何过滤条件，则返回该负载均衡实例下的所有监听器。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据证书ID查询其在一个地域中所关联到负载均衡实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public Task<DescribeLoadBalancerListByCertIdResponse> DescribeLoadBalancerListByCertId(DescribeLoadBalancerListByCertIdRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListByCertIdResponse>(req, "DescribeLoadBalancerListByCertId");
        }

        /// <summary>
        /// 根据证书ID查询其在一个地域中所关联到负载均衡实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public DescribeLoadBalancerListByCertIdResponse DescribeLoadBalancerListByCertIdSync(DescribeLoadBalancerListByCertIdRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListByCertIdResponse>(req, "DescribeLoadBalancerListByCertId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询运行中、隔离中、即将到期和负载均衡总数。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerOverviewRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerOverviewResponse"/></returns>
        public Task<DescribeLoadBalancerOverviewResponse> DescribeLoadBalancerOverview(DescribeLoadBalancerOverviewRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerOverviewResponse>(req, "DescribeLoadBalancerOverview");
        }

        /// <summary>
        /// 查询运行中、隔离中、即将到期和负载均衡总数。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerOverviewRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerOverviewResponse"/></returns>
        public DescribeLoadBalancerOverviewResponse DescribeLoadBalancerOverviewSync(DescribeLoadBalancerOverviewRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerOverviewResponse>(req, "DescribeLoadBalancerOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账号下的高流量负载均衡，返回前10个负载均衡。如果是子账号登录，只返回子账号有权限的负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public Task<DescribeLoadBalancerTrafficResponse> DescribeLoadBalancerTraffic(DescribeLoadBalancerTrafficRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerTrafficResponse>(req, "DescribeLoadBalancerTraffic");
        }

        /// <summary>
        /// 查询账号下的高流量负载均衡，返回前10个负载均衡。如果是子账号登录，只返回子账号有权限的负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public DescribeLoadBalancerTrafficResponse DescribeLoadBalancerTrafficSync(DescribeLoadBalancerTrafficRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerTrafficResponse>(req, "DescribeLoadBalancerTraffic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询一个地域的负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers");
        }

        /// <summary>
        /// 查询一个地域的负载均衡实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡的详细信息，包括监听器，规则及后端目标。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public Task<DescribeLoadBalancersDetailResponse> DescribeLoadBalancersDetail(DescribeLoadBalancersDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersDetailResponse>(req, "DescribeLoadBalancersDetail");
        }

        /// <summary>
        /// 查询负载均衡的详细信息，包括监听器，规则及后端目标。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public DescribeLoadBalancersDetailResponse DescribeLoadBalancersDetailSync(DescribeLoadBalancersDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersDetailResponse>(req, "DescribeLoadBalancersDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户当前地域下的各项配额
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota");
        }

        /// <summary>
        /// 查询用户当前地域下的各项配额
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public DescribeQuotaResponse DescribeQuotaSync(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户在当前地域支持可用区列表和资源列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources");
        }

        /// <summary>
        /// 查询用户在当前地域支持可用区列表和资源列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeRewrite 接口可根据负载均衡实例ID，查询一个负载均衡实例下转发规则的重定向关系。如果不指定监听器ID或转发规则ID，则返回该负载均衡实例下的所有重定向关系。
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public Task<DescribeRewriteResponse> DescribeRewrite(DescribeRewriteRequest req)
        {
            return InternalRequestAsync<DescribeRewriteResponse>(req, "DescribeRewrite");
        }

        /// <summary>
        /// DescribeRewrite 接口可根据负载均衡实例ID，查询一个负载均衡实例下转发规则的重定向关系。如果不指定监听器ID或转发规则ID，则返回该负载均衡实例下的所有重定向关系。
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public DescribeRewriteResponse DescribeRewriteSync(DescribeRewriteRequest req)
        {
            return InternalRequestAsync<DescribeRewriteResponse>(req, "DescribeRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取目标组绑定的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public Task<DescribeTargetGroupInstancesResponse> DescribeTargetGroupInstances(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances");
        }

        /// <summary>
        /// 获取目标组绑定的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public DescribeTargetGroupInstancesResponse DescribeTargetGroupInstancesSync(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public Task<DescribeTargetGroupListResponse> DescribeTargetGroupList(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList");
        }

        /// <summary>
        /// 获取目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public DescribeTargetGroupListResponse DescribeTargetGroupListSync(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目标组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups");
        }

        /// <summary>
        /// 查询目标组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeTargetHealth 接口用来获取负载均衡后端服务的健康检查结果，不支持传统型负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public Task<DescribeTargetHealthResponse> DescribeTargetHealth(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth");
        }

        /// <summary>
        /// DescribeTargetHealth 接口用来获取负载均衡后端服务的健康检查结果，不支持传统型负载均衡。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public DescribeTargetHealthResponse DescribeTargetHealthSync(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeTargets 接口用来查询负载均衡实例的某些监听器绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public Task<DescribeTargetsResponse> DescribeTargets(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets");
        }

        /// <summary>
        /// DescribeTargets 接口用来查询负载均衡实例的某些监听器绑定的后端服务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public DescribeTargetsResponse DescribeTargetsSync(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询异步任务的执行状态，对于非查询类的接口（创建/删除负载均衡实例、监听器、规则以及绑定或解绑后端服务等），在接口调用成功后，都需要使用本接口查询任务最终是否执行成功。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 本接口用于查询异步任务的执行状态，对于非查询类的接口（创建/删除负载均衡实例、监听器、规则以及绑定或解绑后端服务等），在接口调用成功后，都需要使用本接口查询任务最终是否执行成功。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除规则的目标组关联关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public Task<DisassociateTargetGroupsResponse> DisassociateTargetGroups(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups");
        }

        /// <summary>
        /// 解除规则的目标组关联关系。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public DisassociateTargetGroupsResponse DisassociateTargetGroupsSync(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// InquiryPriceCreateLoadBalancer接口查询创建负载均衡的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateLoadBalancerResponse"/></returns>
        public Task<InquiryPriceCreateLoadBalancerResponse> InquiryPriceCreateLoadBalancer(InquiryPriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateLoadBalancerResponse>(req, "InquiryPriceCreateLoadBalancer");
        }

        /// <summary>
        /// InquiryPriceCreateLoadBalancer接口查询创建负载均衡的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateLoadBalancerResponse"/></returns>
        public InquiryPriceCreateLoadBalancerResponse InquiryPriceCreateLoadBalancerSync(InquiryPriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateLoadBalancerResponse>(req, "InquiryPriceCreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// InquiryPriceModifyLoadBalancer接口修改负载均衡配置询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceModifyLoadBalancerResponse"/></returns>
        public Task<InquiryPriceModifyLoadBalancerResponse> InquiryPriceModifyLoadBalancer(InquiryPriceModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceModifyLoadBalancerResponse>(req, "InquiryPriceModifyLoadBalancer");
        }

        /// <summary>
        /// InquiryPriceModifyLoadBalancer接口修改负载均衡配置询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceModifyLoadBalancerResponse"/></returns>
        public InquiryPriceModifyLoadBalancerResponse InquiryPriceModifyLoadBalancerSync(InquiryPriceModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceModifyLoadBalancerResponse>(req, "InquiryPriceModifyLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// InquiryPriceRefundLoadBalancer接口查询负载均衡退费价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRefundLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRefundLoadBalancerResponse"/></returns>
        public Task<InquiryPriceRefundLoadBalancerResponse> InquiryPriceRefundLoadBalancer(InquiryPriceRefundLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRefundLoadBalancerResponse>(req, "InquiryPriceRefundLoadBalancer");
        }

        /// <summary>
        /// InquiryPriceRefundLoadBalancer接口查询负载均衡退费价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRefundLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRefundLoadBalancerResponse"/></returns>
        public InquiryPriceRefundLoadBalancerResponse InquiryPriceRefundLoadBalancerSync(InquiryPriceRefundLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRefundLoadBalancerResponse>(req, "InquiryPriceRefundLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// InquiryPriceRenewLoadBalancer接口查询对负载均衡续费的价格，只支持预付费负载均衡续费。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewLoadBalancerResponse"/></returns>
        public Task<InquiryPriceRenewLoadBalancerResponse> InquiryPriceRenewLoadBalancer(InquiryPriceRenewLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewLoadBalancerResponse>(req, "InquiryPriceRenewLoadBalancer");
        }

        /// <summary>
        /// InquiryPriceRenewLoadBalancer接口查询对负载均衡续费的价格，只支持预付费负载均衡续费。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewLoadBalancerResponse"/></returns>
        public InquiryPriceRenewLoadBalancerResponse InquiryPriceRenewLoadBalancerSync(InquiryPriceRenewLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewLoadBalancerResponse>(req, "InquiryPriceRenewLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户手动配置原访问地址和重定向地址，系统自动将原访问地址的请求重定向至对应路径的目的地址。同一域名下可以配置多条路径作为重定向策略，实现http/https之间请求的自动跳转。设置重定向时，需满足如下约束条件：若A已经重定向至B，则A不能再重定向至C（除非先删除老的重定向关系，再建立新的重定向关系），B不能重定向至任何其它地址。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public Task<ManualRewriteResponse> ManualRewrite(ManualRewriteRequest req)
        {
            return InternalRequestAsync<ManualRewriteResponse>(req, "ManualRewrite");
        }

        /// <summary>
        /// 用户手动配置原访问地址和重定向地址，系统自动将原访问地址的请求重定向至对应路径的目的地址。同一域名下可以配置多条路径作为重定向策略，实现http/https之间请求的自动跳转。设置重定向时，需满足如下约束条件：若A已经重定向至B，则A不能再重定向至C（除非先删除老的重定向关系，再建立新的重定向关系），B不能重定向至任何其它地址。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public ManualRewriteResponse ManualRewriteSync(ManualRewriteRequest req)
        {
            return InternalRequestAsync<ManualRewriteResponse>(req, "ManualRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口将传统型负载均衡迁移成(原应用型)负载均衡
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="MigrateClassicalLoadBalancersRequest"/></param>
        /// <returns><see cref="MigrateClassicalLoadBalancersResponse"/></returns>
        public Task<MigrateClassicalLoadBalancersResponse> MigrateClassicalLoadBalancers(MigrateClassicalLoadBalancersRequest req)
        {
            return InternalRequestAsync<MigrateClassicalLoadBalancersResponse>(req, "MigrateClassicalLoadBalancers");
        }

        /// <summary>
        /// 本接口将传统型负载均衡迁移成(原应用型)负载均衡
        /// 本接口为异步接口，接口成功返回后，可使用 DescribeLoadBalancers 接口查询负载均衡实例的状态（如创建中、正常），以确定是否创建成功。
        /// </summary>
        /// <param name="req"><see cref="MigrateClassicalLoadBalancersRequest"/></param>
        /// <returns><see cref="MigrateClassicalLoadBalancersResponse"/></returns>
        public MigrateClassicalLoadBalancersResponse MigrateClassicalLoadBalancersSync(MigrateClassicalLoadBalancersRequest req)
        {
            return InternalRequestAsync<MigrateClassicalLoadBalancersResponse>(req, "MigrateClassicalLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改负载均衡的IP（client IP）封禁黑名单列表，一个转发规则最多支持封禁 2000000 个IP，及黑名单容量为 2000000。
        /// （接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public Task<ModifyBlockIPListResponse> ModifyBlockIPList(ModifyBlockIPListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIPListResponse>(req, "ModifyBlockIPList");
        }

        /// <summary>
        /// 修改负载均衡的IP（client IP）封禁黑名单列表，一个转发规则最多支持封禁 2000000 个IP，及黑名单容量为 2000000。
        /// （接口灰度中，如需使用请提工单）
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public ModifyBlockIPListResponse ModifyBlockIPListSync(ModifyBlockIPListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIPListResponse>(req, "ModifyBlockIPList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyDomain接口用来修改负载均衡七层监听器下的域名。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain");
        }

        /// <summary>
        /// ModifyDomain接口用来修改负载均衡七层监听器下的域名。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyDomainAttributes接口用于修改负载均衡7层监听器转发规则的域名级别属性，如修改域名、修改DefaultServer、开启/关闭Http2、修改证书。
        /// 本接口为异步接口，本接口返回成功后，需以返回的RequestId为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public Task<ModifyDomainAttributesResponse> ModifyDomainAttributes(ModifyDomainAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDomainAttributesResponse>(req, "ModifyDomainAttributes");
        }

        /// <summary>
        /// ModifyDomainAttributes接口用于修改负载均衡7层监听器转发规则的域名级别属性，如修改域名、修改DefaultServer、开启/关闭Http2、修改证书。
        /// 本接口为异步接口，本接口返回成功后，需以返回的RequestId为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public ModifyDomainAttributesResponse ModifyDomainAttributesSync(ModifyDomainAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDomainAttributesResponse>(req, "ModifyDomainAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改负载均衡转发规则上所绑定的云函数。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionTargetsRequest"/></param>
        /// <returns><see cref="ModifyFunctionTargetsResponse"/></returns>
        public Task<ModifyFunctionTargetsResponse> ModifyFunctionTargets(ModifyFunctionTargetsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionTargetsResponse>(req, "ModifyFunctionTargets");
        }

        /// <summary>
        /// 修改负载均衡转发规则上所绑定的云函数。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionTargetsRequest"/></param>
        /// <returns><see cref="ModifyFunctionTargetsResponse"/></returns>
        public ModifyFunctionTargetsResponse ModifyFunctionTargetsSync(ModifyFunctionTargetsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionTargetsResponse>(req, "ModifyFunctionTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyListener接口用来修改负载均衡监听器的属性，包括监听器名称、健康检查参数、证书信息、转发策略等。本接口不支持传统型负载均衡。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener");
        }

        /// <summary>
        /// ModifyListener接口用来修改负载均衡监听器的属性，包括监听器名称、健康检查参数、证书信息、转发策略等。本接口不支持传统型负载均衡。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改负载均衡实例的属性。支持修改负载均衡实例的名称、设置负载均衡的跨域属性。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes");
        }

        /// <summary>
        /// 修改负载均衡实例的属性。支持修改负载均衡实例的名称、设置负载均衡的跨域属性。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改IPv6FullChain负载均衡7层监听器支持混绑IPv4/IPv6目标特性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerMixIpTargetRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerMixIpTargetResponse"/></returns>
        public Task<ModifyLoadBalancerMixIpTargetResponse> ModifyLoadBalancerMixIpTarget(ModifyLoadBalancerMixIpTargetRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerMixIpTargetResponse>(req, "ModifyLoadBalancerMixIpTarget");
        }

        /// <summary>
        /// 修改IPv6FullChain负载均衡7层监听器支持混绑IPv4/IPv6目标特性。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerMixIpTargetRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerMixIpTargetResponse"/></returns>
        public ModifyLoadBalancerMixIpTargetResponse ModifyLoadBalancerMixIpTargetSync(ModifyLoadBalancerMixIpTargetRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerMixIpTargetResponse>(req, "ModifyLoadBalancerMixIpTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyLoadBalancerSla）用于将按量计费模式的共享型实例升级为性能容量型实例。<br/>
        /// 限制条件：
        /// - 本接口只支持升级按量计费的CLB实例，包年包月的CLB实例升级请通过控制台进行升级。
        /// - 升级为性能容量型实例后，不支持再回退到共享型实例。
        /// - 传统型负载均衡实例不支持升级为性能容量型实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerSlaRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerSlaResponse"/></returns>
        public Task<ModifyLoadBalancerSlaResponse> ModifyLoadBalancerSla(ModifyLoadBalancerSlaRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerSlaResponse>(req, "ModifyLoadBalancerSla");
        }

        /// <summary>
        /// 本接口（ModifyLoadBalancerSla）用于将按量计费模式的共享型实例升级为性能容量型实例。<br/>
        /// 限制条件：
        /// - 本接口只支持升级按量计费的CLB实例，包年包月的CLB实例升级请通过控制台进行升级。
        /// - 升级为性能容量型实例后，不支持再回退到共享型实例。
        /// - 传统型负载均衡实例不支持升级为性能容量型实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerSlaRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerSlaResponse"/></returns>
        public ModifyLoadBalancerSlaResponse ModifyLoadBalancerSlaSync(ModifyLoadBalancerSlaRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerSlaResponse>(req, "ModifyLoadBalancerSla")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改一个或多个负载均衡实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersProjectRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersProjectResponse"/></returns>
        public Task<ModifyLoadBalancersProjectResponse> ModifyLoadBalancersProject(ModifyLoadBalancersProjectRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersProjectResponse>(req, "ModifyLoadBalancersProject");
        }

        /// <summary>
        /// 修改一个或多个负载均衡实例所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersProjectRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersProjectResponse"/></returns>
        public ModifyLoadBalancersProjectResponse ModifyLoadBalancersProjectSync(ModifyLoadBalancersProjectRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersProjectResponse>(req, "ModifyLoadBalancersProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyRule 接口用来修改负载均衡七层监听器下的转发规则的各项属性，包括转发路径、健康检查属性、转发策略等。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// ModifyRule 接口用来修改负载均衡七层监听器下的转发规则的各项属性，包括转发路径、健康检查属性、转发策略等。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改目标组的名称或者默认端口属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public Task<ModifyTargetGroupAttributeResponse> ModifyTargetGroupAttribute(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute");
        }

        /// <summary>
        /// 修改目标组的名称或者默认端口属性
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public ModifyTargetGroupAttributeResponse ModifyTargetGroupAttributeSync(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改目标组服务器端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public Task<ModifyTargetGroupInstancesPortResponse> ModifyTargetGroupInstancesPort(ModifyTargetGroupInstancesPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesPortResponse>(req, "ModifyTargetGroupInstancesPort");
        }

        /// <summary>
        /// 批量修改目标组服务器端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public ModifyTargetGroupInstancesPortResponse ModifyTargetGroupInstancesPortSync(ModifyTargetGroupInstancesPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesPortResponse>(req, "ModifyTargetGroupInstancesPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改目标组的服务器权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public Task<ModifyTargetGroupInstancesWeightResponse> ModifyTargetGroupInstancesWeight(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight");
        }

        /// <summary>
        /// 批量修改目标组的服务器权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public ModifyTargetGroupInstancesWeightResponse ModifyTargetGroupInstancesWeightSync(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyTargetPort接口用于修改监听器绑定的后端服务的端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public Task<ModifyTargetPortResponse> ModifyTargetPort(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort");
        }

        /// <summary>
        /// ModifyTargetPort接口用于修改监听器绑定的后端服务的端口。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public ModifyTargetPortResponse ModifyTargetPortSync(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyTargetWeight 接口用于修改负载均衡绑定的后端服务的转发权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight");
        }

        /// <summary>
        /// ModifyTargetWeight 接口用于修改负载均衡绑定的后端服务的转发权重。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RegisterFunctionTargets 接口用来将一个云函数绑定到负载均衡的7层转发规则，在此之前您需要先行创建相关的7层监听器（HTTP、HTTPS）和转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。<br/>
        /// 限制说明：
        /// - 仅广州、深圳金融、上海、上海金融、北京、成都、中国香港、新加坡、孟买、东京、硅谷地域支持绑定 SCF。
        /// - 仅标准账户类型支持绑定 SCF，传统账户类型不支持。建议升级为标准账户类型，详情可参见 [账户类型升级说明](https://cloud.tencent.com/document/product/1199/49090)。 
        /// - 传统型负载均衡不支持绑定 SCF。
        /// - 基础网络类型不支持绑定 SCF。
        /// - CLB 默认支持绑定同地域下的所有 SCF，可支持跨 VPC 绑定 SCF，不支持跨地域绑定。
        /// - 目前仅 IPv4、IPv6 NAT64 版本的负载均衡支持绑定 SCF，IPv6 版本的暂不支持。
        /// - 仅七层（HTTP、HTTPS）监听器支持绑定 SCF，四层（TCP、UDP、TCP SSL）监听器和七层 QUIC 监听器不支持。
        /// - CLB 绑定 SCF 仅支持绑定“Event 函数”类型的云函数。
        /// </summary>
        /// <param name="req"><see cref="RegisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="RegisterFunctionTargetsResponse"/></returns>
        public Task<RegisterFunctionTargetsResponse> RegisterFunctionTargets(RegisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<RegisterFunctionTargetsResponse>(req, "RegisterFunctionTargets");
        }

        /// <summary>
        /// RegisterFunctionTargets 接口用来将一个云函数绑定到负载均衡的7层转发规则，在此之前您需要先行创建相关的7层监听器（HTTP、HTTPS）和转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。<br/>
        /// 限制说明：
        /// - 仅广州、深圳金融、上海、上海金融、北京、成都、中国香港、新加坡、孟买、东京、硅谷地域支持绑定 SCF。
        /// - 仅标准账户类型支持绑定 SCF，传统账户类型不支持。建议升级为标准账户类型，详情可参见 [账户类型升级说明](https://cloud.tencent.com/document/product/1199/49090)。 
        /// - 传统型负载均衡不支持绑定 SCF。
        /// - 基础网络类型不支持绑定 SCF。
        /// - CLB 默认支持绑定同地域下的所有 SCF，可支持跨 VPC 绑定 SCF，不支持跨地域绑定。
        /// - 目前仅 IPv4、IPv6 NAT64 版本的负载均衡支持绑定 SCF，IPv6 版本的暂不支持。
        /// - 仅七层（HTTP、HTTPS）监听器支持绑定 SCF，四层（TCP、UDP、TCP SSL）监听器和七层 QUIC 监听器不支持。
        /// - CLB 绑定 SCF 仅支持绑定“Event 函数”类型的云函数。
        /// </summary>
        /// <param name="req"><see cref="RegisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="RegisterFunctionTargetsResponse"/></returns>
        public RegisterFunctionTargetsResponse RegisterFunctionTargetsSync(RegisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<RegisterFunctionTargetsResponse>(req, "RegisterFunctionTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注册服务器到目标组。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public Task<RegisterTargetGroupInstancesResponse> RegisterTargetGroupInstances(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances");
        }

        /// <summary>
        /// 注册服务器到目标组。
        /// 本接口为异步接口，本接口返回成功后需以返回的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public RegisterTargetGroupInstancesResponse RegisterTargetGroupInstancesSync(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RegisterTargets 接口用来将一台或多台后端服务绑定到负载均衡的监听器（或7层转发规则），在此之前您需要先行创建相关的4层监听器或7层转发规则。对于四层监听器（TCP、UDP），只需指定监听器ID即可，对于七层监听器（HTTP、HTTPS），还需通过LocationId或者Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public Task<RegisterTargetsResponse> RegisterTargets(RegisterTargetsRequest req)
        {
            return InternalRequestAsync<RegisterTargetsResponse>(req, "RegisterTargets");
        }

        /// <summary>
        /// RegisterTargets 接口用来将一台或多台后端服务绑定到负载均衡的监听器（或7层转发规则），在此之前您需要先行创建相关的4层监听器或7层转发规则。对于四层监听器（TCP、UDP），只需指定监听器ID即可，对于七层监听器（HTTP、HTTPS），还需通过LocationId或者Domain+Url指定转发规则。
        /// 本接口为异步接口，本接口返回成功后需以返回的RequestID为入参，调用DescribeTaskStatus接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public RegisterTargetsResponse RegisterTargetsSync(RegisterTargetsRequest req)
        {
            return InternalRequestAsync<RegisterTargetsResponse>(req, "RegisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RegisterTargetsWithClassicalLB 接口用于绑定后端服务到传统型负载均衡。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public Task<RegisterTargetsWithClassicalLBResponse> RegisterTargetsWithClassicalLB(RegisterTargetsWithClassicalLBRequest req)
        {
            return InternalRequestAsync<RegisterTargetsWithClassicalLBResponse>(req, "RegisterTargetsWithClassicalLB");
        }

        /// <summary>
        /// RegisterTargetsWithClassicalLB 接口用于绑定后端服务到传统型负载均衡。本接口为异步接口，接口返回成功后，需以返回的 RequestId 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public RegisterTargetsWithClassicalLBResponse RegisterTargetsWithClassicalLBSync(RegisterTargetsWithClassicalLBRequest req)
        {
            return InternalRequestAsync<RegisterTargetsWithClassicalLBResponse>(req, "RegisterTargetsWithClassicalLB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ReplaceCertForLoadBalancers 接口用以替换负载均衡实例所关联的证书，对于各个地域的负载均衡，如果指定的老的证书ID与其有关联关系，则会先解除关联，再建立新证书与该负载均衡的关联关系。
        /// 此接口支持替换服务端证书或客户端证书。
        /// 需要使用的新证书，可以通过传入证书ID来指定，如果不指定证书ID，则必须传入证书内容等相关信息，用以新建证书并绑定至负载均衡。
        /// 注：本接口仅可从广州地域调用。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertForLoadBalancersRequest"/></param>
        /// <returns><see cref="ReplaceCertForLoadBalancersResponse"/></returns>
        public Task<ReplaceCertForLoadBalancersResponse> ReplaceCertForLoadBalancers(ReplaceCertForLoadBalancersRequest req)
        {
            return InternalRequestAsync<ReplaceCertForLoadBalancersResponse>(req, "ReplaceCertForLoadBalancers");
        }

        /// <summary>
        /// ReplaceCertForLoadBalancers 接口用以替换负载均衡实例所关联的证书，对于各个地域的负载均衡，如果指定的老的证书ID与其有关联关系，则会先解除关联，再建立新证书与该负载均衡的关联关系。
        /// 此接口支持替换服务端证书或客户端证书。
        /// 需要使用的新证书，可以通过传入证书ID来指定，如果不指定证书ID，则必须传入证书内容等相关信息，用以新建证书并绑定至负载均衡。
        /// 注：本接口仅可从广州地域调用。
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertForLoadBalancersRequest"/></param>
        /// <returns><see cref="ReplaceCertForLoadBalancersResponse"/></returns>
        public ReplaceCertForLoadBalancersResponse ReplaceCertForLoadBalancersSync(ReplaceCertForLoadBalancersRequest req)
        {
            return InternalRequestAsync<ReplaceCertForLoadBalancersResponse>(req, "ReplaceCertForLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 负载均衡维度的个性化配置相关操作：创建、删除、修改、绑定、解绑
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public Task<SetCustomizedConfigForLoadBalancerResponse> SetCustomizedConfigForLoadBalancer(SetCustomizedConfigForLoadBalancerRequest req)
        {
            return InternalRequestAsync<SetCustomizedConfigForLoadBalancerResponse>(req, "SetCustomizedConfigForLoadBalancer");
        }

        /// <summary>
        /// 负载均衡维度的个性化配置相关操作：创建、删除、修改、绑定、解绑
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public SetCustomizedConfigForLoadBalancerResponse SetCustomizedConfigForLoadBalancerSync(SetCustomizedConfigForLoadBalancerRequest req)
        {
            return InternalRequestAsync<SetCustomizedConfigForLoadBalancerResponse>(req, "SetCustomizedConfigForLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加、删除、更新负载均衡的日志服务(CLS)主题。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public Task<SetLoadBalancerClsLogResponse> SetLoadBalancerClsLog(SetLoadBalancerClsLogRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerClsLogResponse>(req, "SetLoadBalancerClsLog");
        }

        /// <summary>
        /// 增加、删除、更新负载均衡的日志服务(CLS)主题。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public SetLoadBalancerClsLogResponse SetLoadBalancerClsLogSync(SetLoadBalancerClsLogRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerClsLogResponse>(req, "SetLoadBalancerClsLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SetLoadBalancerSecurityGroups 接口支持对一个公网负载均衡实例执行设置（绑定、解绑）安全组操作。查询一个负载均衡实例目前已绑定的安全组，可使用 DescribeLoadBalancers 接口。本接口是set语义，
        /// 绑定操作时，入参需要传入负载均衡实例要绑定的所有安全组（已绑定的+新增绑定的）。
        /// 解绑操作时，入参需要传入负载均衡实例执行解绑后所绑定的所有安全组；如果要解绑所有安全组，可不传此参数，或传入空数组。注意：内网 CLB 绑定 EIP 后，CLB 上的安全组对来自 EIP 的流量不生效，对来自内网 CLB 的流量生效。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups");
        }

        /// <summary>
        /// SetLoadBalancerSecurityGroups 接口支持对一个公网负载均衡实例执行设置（绑定、解绑）安全组操作。查询一个负载均衡实例目前已绑定的安全组，可使用 DescribeLoadBalancers 接口。本接口是set语义，
        /// 绑定操作时，入参需要传入负载均衡实例要绑定的所有安全组（已绑定的+新增绑定的）。
        /// 解绑操作时，入参需要传入负载均衡实例执行解绑后所绑定的所有安全组；如果要解绑所有安全组，可不传此参数，或传入空数组。注意：内网 CLB 绑定 EIP 后，CLB 上的安全组对来自 EIP 的流量不生效，对来自内网 CLB 的流量生效。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启停负载均衡实例或者监听器。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// 该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerStartStatusRequest"/></param>
        /// <returns><see cref="SetLoadBalancerStartStatusResponse"/></returns>
        public Task<SetLoadBalancerStartStatusResponse> SetLoadBalancerStartStatus(SetLoadBalancerStartStatusRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerStartStatusResponse>(req, "SetLoadBalancerStartStatus");
        }

        /// <summary>
        /// 启停负载均衡实例或者监听器。
        /// 本接口为异步接口，接口返回成功后，需以得到的 RequestID 为入参，调用 DescribeTaskStatus 接口查询本次任务是否成功。
        /// 该功能正在内测中，如需使用，请通过[工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1)。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerStartStatusRequest"/></param>
        /// <returns><see cref="SetLoadBalancerStartStatusResponse"/></returns>
        public SetLoadBalancerStartStatusResponse SetLoadBalancerStartStatusSync(SetLoadBalancerStartStatusRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerStartStatusResponse>(req, "SetLoadBalancerStartStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个公网负载均衡实例。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers");
        }

        /// <summary>
        /// 绑定或解绑一个安全组到多个公网负载均衡实例。注意：内网负载均衡不支持绑定安全组。
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public SetSecurityGroupForLoadbalancersResponse SetSecurityGroupForLoadbalancersSync(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
