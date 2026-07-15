/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Alb.V20251030
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Alb.V20251030.Models;

   public class AlbClient : AbstractClient{

       private const string endpoint = "alb.tencentcloudapi.com";
       private const string version = "2025-10-30";
       private const string sdkVersion = "SDK_NET_3.0.1462";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AlbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AlbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 向目标组内添加后端服务
        /// </summary>
        /// <param name="req"><see cref="AddTargetsToTargetGroupRequest"/></param>
        /// <returns><see cref="AddTargetsToTargetGroupResponse"/></returns>
        public Task<AddTargetsToTargetGroupResponse> AddTargetsToTargetGroup(AddTargetsToTargetGroupRequest req)
        {
            return InternalRequestAsync<AddTargetsToTargetGroupResponse>(req, "AddTargetsToTargetGroup");
        }

        /// <summary>
        /// 向目标组内添加后端服务
        /// </summary>
        /// <param name="req"><see cref="AddTargetsToTargetGroupRequest"/></param>
        /// <returns><see cref="AddTargetsToTargetGroupResponse"/></returns>
        public AddTargetsToTargetGroupResponse AddTargetsToTargetGroupSync(AddTargetsToTargetGroupRequest req)
        {
            return InternalRequestAsync<AddTargetsToTargetGroupResponse>(req, "AddTargetsToTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将共享带宽包绑定到应用型负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateBandwidthPackageWithLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateBandwidthPackageWithLoadBalancerResponse"/></returns>
        public Task<AssociateBandwidthPackageWithLoadBalancerResponse> AssociateBandwidthPackageWithLoadBalancer(AssociateBandwidthPackageWithLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateBandwidthPackageWithLoadBalancerResponse>(req, "AssociateBandwidthPackageWithLoadBalancer");
        }

        /// <summary>
        /// 将共享带宽包绑定到应用型负载均衡实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateBandwidthPackageWithLoadBalancerRequest"/></param>
        /// <returns><see cref="AssociateBandwidthPackageWithLoadBalancerResponse"/></returns>
        public AssociateBandwidthPackageWithLoadBalancerResponse AssociateBandwidthPackageWithLoadBalancerSync(AssociateBandwidthPackageWithLoadBalancerRequest req)
        {
            return InternalRequestAsync<AssociateBandwidthPackageWithLoadBalancerResponse>(req, "AssociateBandwidthPackageWithLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// AssociateListenerAdditionalCertificates属于异步接口，即系统返回一个请求 ID，但该扩展证书尚未添加成功，系统后台的添加任务仍在进行。您可以调用DescribeListenerCertificates接口查询扩展证书的添加状态：
        /// 当HTTPS和QUIC监听器处于Associating状态时，表示扩展证书正在添加中。
        /// 当HTTPS和QUIC监听器处于Associated状态时，表示扩展证书添加成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="AssociateListenerAdditionalCertificatesResponse"/></returns>
        public Task<AssociateListenerAdditionalCertificatesResponse> AssociateListenerAdditionalCertificates(AssociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<AssociateListenerAdditionalCertificatesResponse>(req, "AssociateListenerAdditionalCertificates");
        }

        /// <summary>
        /// AssociateListenerAdditionalCertificates属于异步接口，即系统返回一个请求 ID，但该扩展证书尚未添加成功，系统后台的添加任务仍在进行。您可以调用DescribeListenerCertificates接口查询扩展证书的添加状态：
        /// 当HTTPS和QUIC监听器处于Associating状态时，表示扩展证书正在添加中。
        /// 当HTTPS和QUIC监听器处于Associated状态时，表示扩展证书添加成功。
        /// </summary>
        /// <param name="req"><see cref="AssociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="AssociateListenerAdditionalCertificatesResponse"/></returns>
        public AssociateListenerAdditionalCertificatesResponse AssociateListenerAdditionalCertificatesSync(AssociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<AssociateListenerAdditionalCertificatesResponse>(req, "AssociateListenerAdditionalCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建健康检查模板
        /// </summary>
        /// <param name="req"><see cref="CreateHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="CreateHealthCheckTemplateResponse"/></returns>
        public Task<CreateHealthCheckTemplateResponse> CreateHealthCheckTemplate(CreateHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<CreateHealthCheckTemplateResponse>(req, "CreateHealthCheckTemplate");
        }

        /// <summary>
        /// 创建健康检查模板
        /// </summary>
        /// <param name="req"><see cref="CreateHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="CreateHealthCheckTemplateResponse"/></returns>
        public CreateHealthCheckTemplateResponse CreateHealthCheckTemplateSync(CreateHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<CreateHealthCheckTemplateResponse>(req, "CreateHealthCheckTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建监听器
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// 创建监听器
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **CreateLoadBalancer**接口属于异步接口，即系统返回一个实例ID，但该应用型负载均衡实例尚未创建成功，系统后台的创建任务仍在进行。您可以调用[DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711)查询应用型负载均衡实例的创建状态：
        /// - 当应用型负载均衡实例处于**Provisioning**状态时，表示应用型负载均衡实例正在创建中。
        /// - 当应用型负载均衡实例处于**Active**状态时，表示应用型负载均衡实例创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// **CreateLoadBalancer**接口属于异步接口，即系统返回一个实例ID，但该应用型负载均衡实例尚未创建成功，系统后台的创建任务仍在进行。您可以调用[DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711)查询应用型负载均衡实例的创建状态：
        /// - 当应用型负载均衡实例处于**Provisioning**状态时，表示应用型负载均衡实例正在创建中。
        /// - 当应用型负载均衡实例处于**Active**状态时，表示应用型负载均衡实例创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateRules创建转发规则，本接口为异步接口，返回成功后需以返回的RequestID为入参，调用DescribeAsyncJobs接口查询本次任务是否成功。
        /// 一条规则最多支持10个转发条件（Conditions），5个转发动作（Actions）。
        /// </summary>
        /// <param name="req"><see cref="CreateRulesRequest"/></param>
        /// <returns><see cref="CreateRulesResponse"/></returns>
        public Task<CreateRulesResponse> CreateRules(CreateRulesRequest req)
        {
            return InternalRequestAsync<CreateRulesResponse>(req, "CreateRules");
        }

        /// <summary>
        /// CreateRules创建转发规则，本接口为异步接口，返回成功后需以返回的RequestID为入参，调用DescribeAsyncJobs接口查询本次任务是否成功。
        /// 一条规则最多支持10个转发条件（Conditions），5个转发动作（Actions）。
        /// </summary>
        /// <param name="req"><see cref="CreateRulesRequest"/></param>
        /// <returns><see cref="CreateRulesResponse"/></returns>
        public CreateRulesResponse CreateRulesSync(CreateRulesRequest req)
        {
            return InternalRequestAsync<CreateRulesResponse>(req, "CreateRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义安全策略，用于配置 HTTPS 监听器的 TLS 协议版本和加密套件。通过安全策略，您可以灵活控制客户端与负载均衡之间 HTTPS 通信的安全级别。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy");
        }

        /// <summary>
        /// 创建自定义安全策略，用于配置 HTTPS 监听器的 TLS 协议版本和加密套件。通过安全策略，您可以灵活控制客户端与负载均衡之间 HTTPS 通信的安全级别。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 目标组相关接口
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup");
        }

        /// <summary>
        /// 目标组相关接口
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除健康检查模板
        /// </summary>
        /// <param name="req"><see cref="DeleteHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DeleteHealthCheckTemplatesResponse"/></returns>
        public Task<DeleteHealthCheckTemplatesResponse> DeleteHealthCheckTemplates(DeleteHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteHealthCheckTemplatesResponse>(req, "DeleteHealthCheckTemplates");
        }

        /// <summary>
        /// 删除健康检查模板
        /// </summary>
        /// <param name="req"><see cref="DeleteHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DeleteHealthCheckTemplatesResponse"/></returns>
        public DeleteHealthCheckTemplatesResponse DeleteHealthCheckTemplatesSync(DeleteHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteHealthCheckTemplatesResponse>(req, "DeleteHealthCheckTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// 删除监听器
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **DeleteLoadBalancers**接口属于异步接口，即系统返回一个请求ID，但该应用型负载均衡实例尚未删除成功，系统后台的删除任务仍在进行。您可以调用[DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711)查询应用型负载均衡实例的删除状态：
        /// - 当应用型负载均衡实例处于**Deleting**状态时，表示应用型负载均衡实例正在删除中。
        /// - 当查询不到指定的应用型负载均衡实例时，表示应用型负载均衡实例删除成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancersResponse"/></returns>
        public Task<DeleteLoadBalancersResponse> DeleteLoadBalancers(DeleteLoadBalancersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancersResponse>(req, "DeleteLoadBalancers");
        }

        /// <summary>
        /// **DeleteLoadBalancers**接口属于异步接口，即系统返回一个请求ID，但该应用型负载均衡实例尚未删除成功，系统后台的删除任务仍在进行。您可以调用[DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711)查询应用型负载均衡实例的删除状态：
        /// - 当应用型负载均衡实例处于**Deleting**状态时，表示应用型负载均衡实例正在删除中。
        /// - 当查询不到指定的应用型负载均衡实例时，表示应用型负载均衡实例删除成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancersResponse"/></returns>
        public DeleteLoadBalancersResponse DeleteLoadBalancersSync(DeleteLoadBalancersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancersResponse>(req, "DeleteLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteRules删除转发规则，本接口为异步接口，返回成功后需以返回的RequestID为入参，调用DescribeAsyncJobs接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules");
        }

        /// <summary>
        /// DeleteRules删除转发规则，本接口为异步接口，返回成功后需以返回的RequestID为入参，调用DescribeAsyncJobs接口查询本次任务是否成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一个或多个自定义安全策略。删除安全策略前，请确保该策略未被任何 HTTPS 监听器引用，否则删除操作将失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy");
        }

        /// <summary>
        /// 删除一个或多个自定义安全策略。删除安全策略前，请确保该策略未被任何 HTTPS 监听器引用，否则删除操作将失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除目标组。
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups");
        }

        /// <summary>
        /// 删除目标组。
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 异步任务查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncJobsRequest"/></param>
        /// <returns><see cref="DescribeAsyncJobsResponse"/></returns>
        public Task<DescribeAsyncJobsResponse> DescribeAsyncJobs(DescribeAsyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeAsyncJobsResponse>(req, "DescribeAsyncJobs");
        }

        /// <summary>
        /// 异步任务查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncJobsRequest"/></param>
        /// <returns><see cref="DescribeAsyncJobsResponse"/></returns>
        public DescribeAsyncJobsResponse DescribeAsyncJobsSync(DescribeAsyncJobsRequest req)
        {
            return InternalRequestAsync<DescribeAsyncJobsResponse>(req, "DescribeAsyncJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询健康检查模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckTemplatesResponse"/></returns>
        public Task<DescribeHealthCheckTemplatesResponse> DescribeHealthCheckTemplates(DescribeHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckTemplatesResponse>(req, "DescribeHealthCheckTemplates");
        }

        /// <summary>
        /// 查询健康检查模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthCheckTemplatesRequest"/></param>
        /// <returns><see cref="DescribeHealthCheckTemplatesResponse"/></returns>
        public DescribeHealthCheckTemplatesResponse DescribeHealthCheckTemplatesSync(DescribeHealthCheckTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeHealthCheckTemplatesResponse>(req, "DescribeHealthCheckTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据实例id和监听器id，查询指定监听器绑定的证书列表
        /// 若输入CertificateType为SVR，返回扩展服务器证书与默认服务器证书的信息
        /// 若输入CertificateType为CA，返回默认CA证书的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerCertificatesRequest"/></param>
        /// <returns><see cref="DescribeListenerCertificatesResponse"/></returns>
        public Task<DescribeListenerCertificatesResponse> DescribeListenerCertificates(DescribeListenerCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeListenerCertificatesResponse>(req, "DescribeListenerCertificates");
        }

        /// <summary>
        /// 根据实例id和监听器id，查询指定监听器绑定的证书列表
        /// 若输入CertificateType为SVR，返回扩展服务器证书与默认服务器证书的信息
        /// 若输入CertificateType为CA，返回默认CA证书的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerCertificatesRequest"/></param>
        /// <returns><see cref="DescribeListenerCertificatesResponse"/></returns>
        public DescribeListenerCertificatesResponse DescribeListenerCertificatesSync(DescribeListenerCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeListenerCertificatesResponse>(req, "DescribeListenerCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个监听器详情
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerDetailRequest"/></param>
        /// <returns><see cref="DescribeListenerDetailResponse"/></returns>
        public Task<DescribeListenerDetailResponse> DescribeListenerDetail(DescribeListenerDetailRequest req)
        {
            return InternalRequestAsync<DescribeListenerDetailResponse>(req, "DescribeListenerDetail");
        }

        /// <summary>
        /// 查询单个监听器详情
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerDetailRequest"/></param>
        /// <returns><see cref="DescribeListenerDetailResponse"/></returns>
        public DescribeListenerDetailResponse DescribeListenerDetailSync(DescribeListenerDetailRequest req)
        {
            return InternalRequestAsync<DescribeListenerDetailResponse>(req, "DescribeListenerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询监听器健康状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeListenerHealthStatusResponse"/></returns>
        public Task<DescribeListenerHealthStatusResponse> DescribeListenerHealthStatus(DescribeListenerHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeListenerHealthStatusResponse>(req, "DescribeListenerHealthStatus");
        }

        /// <summary>
        /// 查询监听器健康状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeListenerHealthStatusResponse"/></returns>
        public DescribeListenerHealthStatusResponse DescribeListenerHealthStatusSync(DescribeListenerHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeListenerHealthStatusResponse>(req, "DescribeListenerHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// 查询监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定负载均衡实例的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerDetailResponse"/></returns>
        public Task<DescribeLoadBalancerDetailResponse> DescribeLoadBalancerDetail(DescribeLoadBalancerDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerDetailResponse>(req, "DescribeLoadBalancerDetail");
        }

        /// <summary>
        /// 查询指定负载均衡实例的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerDetailResponse"/></returns>
        public DescribeLoadBalancerDetailResponse DescribeLoadBalancerDetailSync(DescribeLoadBalancerDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerDetailResponse>(req, "DescribeLoadBalancerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers");
        }

        /// <summary>
        /// 查询实例配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前账号的 ALB 配额配置。支持按配额类型查询，也支持传入资源ID查询资源级配额；可通过 DisplayFields 按需返回已使用量和剩余可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota");
        }

        /// <summary>
        /// 查询当前账号的 ALB 配额配置。支持按配额类型查询，也支持传入资源ID查询资源级配额；可通过 DisplayFields 按需返回已使用量和剩余可用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public DescribeQuotaResponse DescribeQuotaSync(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// 查询转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自定义安全策略列表，支持按安全策略 ID、名称或标签进行筛选，并支持分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public Task<DescribeSecurityPoliciesResponse> DescribeSecurityPolicies(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies");
        }

        /// <summary>
        /// 查询自定义安全策略列表，支持按安全策略 ID、名称或标签进行筛选，并支持分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPoliciesResponse"/></returns>
        public DescribeSecurityPoliciesResponse DescribeSecurityPoliciesSync(DescribeSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPoliciesResponse>(req, "DescribeSecurityPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前地域支持的安全策略配置能力，包括可选的 TLS 协议版本及各版本对应的加密套件列表。在创建或修改自定义安全策略前，建议先调用此接口获取可用的配置选项。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyCapabilitiesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyCapabilitiesResponse"/></returns>
        public Task<DescribeSecurityPolicyCapabilitiesResponse> DescribeSecurityPolicyCapabilities(DescribeSecurityPolicyCapabilitiesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyCapabilitiesResponse>(req, "DescribeSecurityPolicyCapabilities");
        }

        /// <summary>
        /// 查询当前地域支持的安全策略配置能力，包括可选的 TLS 协议版本及各版本对应的加密套件列表。在创建或修改自定义安全策略前，建议先调用此接口获取可用的配置选项。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyCapabilitiesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyCapabilitiesResponse"/></returns>
        public DescribeSecurityPolicyCapabilitiesResponse DescribeSecurityPolicyCapabilitiesSync(DescribeSecurityPolicyCapabilitiesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyCapabilitiesResponse>(req, "DescribeSecurityPolicyCapabilities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全策略的关联关系，即安全策略被哪些 HTTPS 监听器引用。在删除或修改安全策略前，建议先调用此接口确认影响范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRelationsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRelationsResponse"/></returns>
        public Task<DescribeSecurityPolicyRelationsResponse> DescribeSecurityPolicyRelations(DescribeSecurityPolicyRelationsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyRelationsResponse>(req, "DescribeSecurityPolicyRelations");
        }

        /// <summary>
        /// 查询安全策略的关联关系，即安全策略被哪些 HTTPS 监听器引用。在删除或修改安全策略前，建议先调用此接口确认影响范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRelationsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRelationsResponse"/></returns>
        public DescribeSecurityPolicyRelationsResponse DescribeSecurityPolicyRelationsSync(DescribeSecurityPolicyRelationsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyRelationsResponse>(req, "DescribeSecurityPolicyRelations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询系统安全策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSystemSecurityPoliciesResponse"/></returns>
        public Task<DescribeSystemSecurityPoliciesResponse> DescribeSystemSecurityPolicies(DescribeSystemSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSystemSecurityPoliciesResponse>(req, "DescribeSystemSecurityPolicies");
        }

        /// <summary>
        /// 查询系统安全策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemSecurityPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSystemSecurityPoliciesResponse"/></returns>
        public DescribeSystemSecurityPoliciesResponse DescribeSystemSecurityPoliciesSync(DescribeSystemSecurityPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSystemSecurityPoliciesResponse>(req, "DescribeSystemSecurityPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目标组内后端服务
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupTargetsResponse"/></returns>
        public Task<DescribeTargetGroupTargetsResponse> DescribeTargetGroupTargets(DescribeTargetGroupTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupTargetsResponse>(req, "DescribeTargetGroupTargets");
        }

        /// <summary>
        /// 查询目标组内后端服务
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupTargetsResponse"/></returns>
        public DescribeTargetGroupTargetsResponse DescribeTargetGroupTargetsSync(DescribeTargetGroupTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupTargetsResponse>(req, "DescribeTargetGroupTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups");
        }

        /// <summary>
        /// 查询目标组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据子机查询绑定的目标组
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsByTargetRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsByTargetResponse"/></returns>
        public Task<DescribeTargetGroupsByTargetResponse> DescribeTargetGroupsByTarget(DescribeTargetGroupsByTargetRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsByTargetResponse>(req, "DescribeTargetGroupsByTarget");
        }

        /// <summary>
        /// 根据子机查询绑定的目标组
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsByTargetRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsByTargetResponse"/></returns>
        public DescribeTargetGroupsByTargetResponse DescribeTargetGroupsByTargetSync(DescribeTargetGroupsByTargetRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsByTargetResponse>(req, "DescribeTargetGroupsByTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 查询可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将共享带宽包从应用型负载均衡实例解绑。
        /// </summary>
        /// <param name="req"><see cref="DisassociateBandwidthPackageFromLoadBalancerRequest"/></param>
        /// <returns><see cref="DisassociateBandwidthPackageFromLoadBalancerResponse"/></returns>
        public Task<DisassociateBandwidthPackageFromLoadBalancerResponse> DisassociateBandwidthPackageFromLoadBalancer(DisassociateBandwidthPackageFromLoadBalancerRequest req)
        {
            return InternalRequestAsync<DisassociateBandwidthPackageFromLoadBalancerResponse>(req, "DisassociateBandwidthPackageFromLoadBalancer");
        }

        /// <summary>
        /// 将共享带宽包从应用型负载均衡实例解绑。
        /// </summary>
        /// <param name="req"><see cref="DisassociateBandwidthPackageFromLoadBalancerRequest"/></param>
        /// <returns><see cref="DisassociateBandwidthPackageFromLoadBalancerResponse"/></returns>
        public DisassociateBandwidthPackageFromLoadBalancerResponse DisassociateBandwidthPackageFromLoadBalancerSync(DisassociateBandwidthPackageFromLoadBalancerRequest req)
        {
            return InternalRequestAsync<DisassociateBandwidthPackageFromLoadBalancerResponse>(req, "DisassociateBandwidthPackageFromLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DisassociateListenerAdditionalCertificates属于异步接口，即系统返回一个请求 ID，但该扩展证书尚未解绑成功，系统后台的解绑任务仍在进行。您可以调用DescribeListenerCertificates接口查询证书的解绑状态：若证书处于Disassociating状态，则证书正在解绑中。
        /// </summary>
        /// <param name="req"><see cref="DisassociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="DisassociateListenerAdditionalCertificatesResponse"/></returns>
        public Task<DisassociateListenerAdditionalCertificatesResponse> DisassociateListenerAdditionalCertificates(DisassociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<DisassociateListenerAdditionalCertificatesResponse>(req, "DisassociateListenerAdditionalCertificates");
        }

        /// <summary>
        /// DisassociateListenerAdditionalCertificates属于异步接口，即系统返回一个请求 ID，但该扩展证书尚未解绑成功，系统后台的解绑任务仍在进行。您可以调用DescribeListenerCertificates接口查询证书的解绑状态：若证书处于Disassociating状态，则证书正在解绑中。
        /// </summary>
        /// <param name="req"><see cref="DisassociateListenerAdditionalCertificatesRequest"/></param>
        /// <returns><see cref="DisassociateListenerAdditionalCertificatesResponse"/></returns>
        public DisassociateListenerAdditionalCertificatesResponse DisassociateListenerAdditionalCertificatesSync(DisassociateListenerAdditionalCertificatesRequest req)
        {
            return InternalRequestAsync<DisassociateListenerAdditionalCertificatesResponse>(req, "DisassociateListenerAdditionalCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// InquirePriceCreateLoadBalancer接口查询创建负载均衡的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateLoadBalancerResponse"/></returns>
        public Task<InquirePriceCreateLoadBalancerResponse> InquirePriceCreateLoadBalancer(InquirePriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateLoadBalancerResponse>(req, "InquirePriceCreateLoadBalancer");
        }

        /// <summary>
        /// InquirePriceCreateLoadBalancer接口查询创建负载均衡的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateLoadBalancerResponse"/></returns>
        public InquirePriceCreateLoadBalancerResponse InquirePriceCreateLoadBalancerSync(InquirePriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateLoadBalancerResponse>(req, "InquirePriceCreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改健康检查模板
        /// </summary>
        /// <param name="req"><see cref="ModifyHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="ModifyHealthCheckTemplateResponse"/></returns>
        public Task<ModifyHealthCheckTemplateResponse> ModifyHealthCheckTemplate(ModifyHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHealthCheckTemplateResponse>(req, "ModifyHealthCheckTemplate");
        }

        /// <summary>
        /// 修改健康检查模板
        /// </summary>
        /// <param name="req"><see cref="ModifyHealthCheckTemplateRequest"/></param>
        /// <returns><see cref="ModifyHealthCheckTemplateResponse"/></returns>
        public ModifyHealthCheckTemplateResponse ModifyHealthCheckTemplateSync(ModifyHealthCheckTemplateRequest req)
        {
            return InternalRequestAsync<ModifyHealthCheckTemplateResponse>(req, "ModifyHealthCheckTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改监听器属性
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerAttributesRequest"/></param>
        /// <returns><see cref="ModifyListenerAttributesResponse"/></returns>
        public Task<ModifyListenerAttributesResponse> ModifyListenerAttributes(ModifyListenerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyListenerAttributesResponse>(req, "ModifyListenerAttributes");
        }

        /// <summary>
        /// 修改监听器属性
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerAttributesRequest"/></param>
        /// <returns><see cref="ModifyListenerAttributesResponse"/></returns>
        public ModifyListenerAttributesResponse ModifyListenerAttributesSync(ModifyListenerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyListenerAttributesResponse>(req, "ModifyListenerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **前提条件：**
        /// 您已经创建应用型负载均衡实例，具体操作，请参见 CreateLoadBalancer 。
        /// 当您需要通过此接口将应用型负载均衡实例的网络类型由私网变为公网时，您需要先创建一个弹性公网 IP。
        /// **使用说明：**
        /// ModifyLoadBalancerAddressType 接口属于异步接口，即系统返回一个请求 ID，但该应用型负载均衡实例的网络类型尚未变更成功，系统后台的变更任务仍在进行。您可以调用 DescribeLoadBalancerDetail 查询应用型负载均衡实例的网络类型的变更状态：
        /// 当应用型负载均衡实例处于 Configuring 状态时，表示应用型负载均衡实例的网络类型正在变更中。
        /// 当应用型负载均衡实例处于 Active 状态时，表示应用型负载均衡实例的网络类型变更成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAddressTypeRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAddressTypeResponse"/></returns>
        public Task<ModifyLoadBalancerAddressTypeResponse> ModifyLoadBalancerAddressType(ModifyLoadBalancerAddressTypeRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAddressTypeResponse>(req, "ModifyLoadBalancerAddressType");
        }

        /// <summary>
        /// **前提条件：**
        /// 您已经创建应用型负载均衡实例，具体操作，请参见 CreateLoadBalancer 。
        /// 当您需要通过此接口将应用型负载均衡实例的网络类型由私网变为公网时，您需要先创建一个弹性公网 IP。
        /// **使用说明：**
        /// ModifyLoadBalancerAddressType 接口属于异步接口，即系统返回一个请求 ID，但该应用型负载均衡实例的网络类型尚未变更成功，系统后台的变更任务仍在进行。您可以调用 DescribeLoadBalancerDetail 查询应用型负载均衡实例的网络类型的变更状态：
        /// 当应用型负载均衡实例处于 Configuring 状态时，表示应用型负载均衡实例的网络类型正在变更中。
        /// 当应用型负载均衡实例处于 Active 状态时，表示应用型负载均衡实例的网络类型变更成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAddressTypeRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAddressTypeResponse"/></returns>
        public ModifyLoadBalancerAddressTypeResponse ModifyLoadBalancerAddressTypeSync(ModifyLoadBalancerAddressTypeRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAddressTypeResponse>(req, "ModifyLoadBalancerAddressType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **ModifyLoadBalancerAttributes**接口属于异步接口，即系统返回一个请求ID，但该应用型负载均衡实例属性尚未修改成功，系统后台的修改任务仍在进行。您可以调用[DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711)查询应用型负载均衡实例属性的修改状态：
        /// - 当应用型负载均衡实例属性处于**Configuring**状态时，表示应用型负载均衡实例属性正在修改中。
        /// - 当应用型负载均衡实例属性处于**Active**状态时，表示应用型负载均衡实例属性修改成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes");
        }

        /// <summary>
        /// **ModifyLoadBalancerAttributes**接口属于异步接口，即系统返回一个请求ID，但该应用型负载均衡实例属性尚未修改成功，系统后台的修改任务仍在进行。您可以调用[DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711)查询应用型负载均衡实例属性的修改状态：
        /// - 当应用型负载均衡实例属性处于**Configuring**状态时，表示应用型负载均衡实例属性正在修改中。
        /// - 当应用型负载均衡实例属性处于**Active**状态时，表示应用型负载均衡实例属性修改成功。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置负载均衡实例修改保护。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerModificationProtectionRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerModificationProtectionResponse"/></returns>
        public Task<ModifyLoadBalancerModificationProtectionResponse> ModifyLoadBalancerModificationProtection(ModifyLoadBalancerModificationProtectionRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerModificationProtectionResponse>(req, "ModifyLoadBalancerModificationProtection");
        }

        /// <summary>
        /// 设置负载均衡实例修改保护。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerModificationProtectionRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerModificationProtectionResponse"/></returns>
        public ModifyLoadBalancerModificationProtectionResponse ModifyLoadBalancerModificationProtectionSync(ModifyLoadBalancerModificationProtectionRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerModificationProtectionResponse>(req, "ModifyLoadBalancerModificationProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyRulesAttributes修改转发规则属性，本接口为异步接口，返回成功后需以返回的RequestID为入参，调用DescribeAsyncJobs接口查询本次任务是否成功。
        /// 一条规则最多支持10个转发条件（Conditions），5个转发动作（Actions）。
        /// </summary>
        /// <param name="req"><see cref="ModifyRulesAttributesRequest"/></param>
        /// <returns><see cref="ModifyRulesAttributesResponse"/></returns>
        public Task<ModifyRulesAttributesResponse> ModifyRulesAttributes(ModifyRulesAttributesRequest req)
        {
            return InternalRequestAsync<ModifyRulesAttributesResponse>(req, "ModifyRulesAttributes");
        }

        /// <summary>
        /// ModifyRulesAttributes修改转发规则属性，本接口为异步接口，返回成功后需以返回的RequestID为入参，调用DescribeAsyncJobs接口查询本次任务是否成功。
        /// 一条规则最多支持10个转发条件（Conditions），5个转发动作（Actions）。
        /// </summary>
        /// <param name="req"><see cref="ModifyRulesAttributesRequest"/></param>
        /// <returns><see cref="ModifyRulesAttributesResponse"/></returns>
        public ModifyRulesAttributesResponse ModifyRulesAttributesSync(ModifyRulesAttributesRequest req)
        {
            return InternalRequestAsync<ModifyRulesAttributesResponse>(req, "ModifyRulesAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自定义安全策略的属性，包括策略名称、TLS 协议版本和加密套件。修改后的配置将立即应用到所有关联该策略的 HTTPS 监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyAttributesRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyAttributesResponse"/></returns>
        public Task<ModifySecurityPolicyAttributesResponse> ModifySecurityPolicyAttributes(ModifySecurityPolicyAttributesRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyAttributesResponse>(req, "ModifySecurityPolicyAttributes");
        }

        /// <summary>
        /// 修改自定义安全策略的属性，包括策略名称、TLS 协议版本和加密套件。修改后的配置将立即应用到所有关联该策略的 HTTPS 监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyAttributesRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyAttributesResponse"/></returns>
        public ModifySecurityPolicyAttributesResponse ModifySecurityPolicyAttributesSync(ModifySecurityPolicyAttributesRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyAttributesResponse>(req, "ModifySecurityPolicyAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改目标组。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributesRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributesResponse"/></returns>
        public Task<ModifyTargetGroupAttributesResponse> ModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributesResponse>(req, "ModifyTargetGroupAttributes");
        }

        /// <summary>
        /// 修改目标组。
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributesRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributesResponse"/></returns>
        public ModifyTargetGroupAttributesResponse ModifyTargetGroupAttributesSync(ModifyTargetGroupAttributesRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributesResponse>(req, "ModifyTargetGroupAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改目标组内后端服务信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetsInTargetGroupRequest"/></param>
        /// <returns><see cref="ModifyTargetsInTargetGroupResponse"/></returns>
        public Task<ModifyTargetsInTargetGroupResponse> ModifyTargetsInTargetGroup(ModifyTargetsInTargetGroupRequest req)
        {
            return InternalRequestAsync<ModifyTargetsInTargetGroupResponse>(req, "ModifyTargetsInTargetGroup");
        }

        /// <summary>
        /// 修改目标组内后端服务信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetsInTargetGroupRequest"/></param>
        /// <returns><see cref="ModifyTargetsInTargetGroupResponse"/></returns>
        public ModifyTargetsInTargetGroupResponse ModifyTargetsInTargetGroupSync(ModifyTargetsInTargetGroupRequest req)
        {
            return InternalRequestAsync<ModifyTargetsInTargetGroupResponse>(req, "ModifyTargetsInTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通知负载均衡解绑后端服务
        /// </summary>
        /// <param name="req"><see cref="NotifyUnbindTargetRequest"/></param>
        /// <returns><see cref="NotifyUnbindTargetResponse"/></returns>
        public Task<NotifyUnbindTargetResponse> NotifyUnbindTarget(NotifyUnbindTargetRequest req)
        {
            return InternalRequestAsync<NotifyUnbindTargetResponse>(req, "NotifyUnbindTarget");
        }

        /// <summary>
        /// 通知负载均衡解绑后端服务
        /// </summary>
        /// <param name="req"><see cref="NotifyUnbindTargetRequest"/></param>
        /// <returns><see cref="NotifyUnbindTargetResponse"/></returns>
        public NotifyUnbindTargetResponse NotifyUnbindTargetSync(NotifyUnbindTargetRequest req)
        {
            return InternalRequestAsync<NotifyUnbindTargetResponse>(req, "NotifyUnbindTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从目标组内移除后端服务
        /// </summary>
        /// <param name="req"><see cref="RemoveTargetsFromTargetGroupRequest"/></param>
        /// <returns><see cref="RemoveTargetsFromTargetGroupResponse"/></returns>
        public Task<RemoveTargetsFromTargetGroupResponse> RemoveTargetsFromTargetGroup(RemoveTargetsFromTargetGroupRequest req)
        {
            return InternalRequestAsync<RemoveTargetsFromTargetGroupResponse>(req, "RemoveTargetsFromTargetGroup");
        }

        /// <summary>
        /// 从目标组内移除后端服务
        /// </summary>
        /// <param name="req"><see cref="RemoveTargetsFromTargetGroupRequest"/></param>
        /// <returns><see cref="RemoveTargetsFromTargetGroupResponse"/></returns>
        public RemoveTargetsFromTargetGroupResponse RemoveTargetsFromTargetGroupSync(RemoveTargetsFromTargetGroupRequest req)
        {
            return InternalRequestAsync<RemoveTargetsFromTargetGroupResponse>(req, "RemoveTargetsFromTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SetLoadBalancerSecurityGroups 接口支持对一个公网负载均衡实例执行设置（绑定、解绑）安全组操作。查询一个负载均衡实例目前已绑定的安全组，可使用 [DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711) 接口。本接口是set语义，
        /// 绑定操作时，入参需要传入负载均衡实例要绑定的所有安全组（已绑定的+新增绑定的）。
        /// 解绑操作时，入参需要传入负载均衡实例执行解绑后所绑定的所有安全组；如果要解绑所有安全组，可不传此参数，或传入空数组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups");
        }

        /// <summary>
        /// SetLoadBalancerSecurityGroups 接口支持对一个公网负载均衡实例执行设置（绑定、解绑）安全组操作。查询一个负载均衡实例目前已绑定的安全组，可使用 [DescribeLoadBalancerDetail](https://cloud.tencent.com/document/api/1822/133711) 接口。本接口是set语义，
        /// 绑定操作时，入参需要传入负载均衡实例要绑定的所有安全组（已绑定的+新增绑定的）。
        /// 解绑操作时，入参需要传入负载均衡实例执行解绑后所绑定的所有安全组；如果要解绑所有安全组，可不传此参数，或传入空数组。
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
