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

namespace TencentCloud.Gaap.V20180529
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gaap.V20180529.Models;

   public class GaapClient : AbstractClient{

       private const string endpoint = "gaap.tencentcloudapi.com";
       private const string version = "2018-05-29";
       private const string sdkVersion = "SDK_NET_3.0.1157";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GaapClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GaapClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加源站(服务器)信息，支持IP或域名
        /// </summary>
        /// <param name="req"><see cref="AddRealServersRequest"/></param>
        /// <returns><see cref="AddRealServersResponse"/></returns>
        public Task<AddRealServersResponse> AddRealServers(AddRealServersRequest req)
        {
            return InternalRequestAsync<AddRealServersResponse>(req, "AddRealServers");
        }

        /// <summary>
        /// 添加源站(服务器)信息，支持IP或域名
        /// </summary>
        /// <param name="req"><see cref="AddRealServersRequest"/></param>
        /// <returns><see cref="AddRealServersResponse"/></returns>
        public AddRealServersResponse AddRealServersSync(AddRealServersRequest req)
        {
            return InternalRequestAsync<AddRealServersResponse>(req, "AddRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BanAndRecoverProxy）用于联通封禁解封GAAP跨境通道实例，支持按照客户UIN维度下发请求。被封禁的实例带宽上限将会被限制到0Mbps，无法正常处理客户端和源站之间的请求。
        /// </summary>
        /// <param name="req"><see cref="BanAndRecoverProxyRequest"/></param>
        /// <returns><see cref="BanAndRecoverProxyResponse"/></returns>
        public Task<BanAndRecoverProxyResponse> BanAndRecoverProxy(BanAndRecoverProxyRequest req)
        {
            return InternalRequestAsync<BanAndRecoverProxyResponse>(req, "BanAndRecoverProxy");
        }

        /// <summary>
        /// 本接口（BanAndRecoverProxy）用于联通封禁解封GAAP跨境通道实例，支持按照客户UIN维度下发请求。被封禁的实例带宽上限将会被限制到0Mbps，无法正常处理客户端和源站之间的请求。
        /// </summary>
        /// <param name="req"><see cref="BanAndRecoverProxyRequest"/></param>
        /// <returns><see cref="BanAndRecoverProxyResponse"/></returns>
        public BanAndRecoverProxyResponse BanAndRecoverProxySync(BanAndRecoverProxyRequest req)
        {
            return InternalRequestAsync<BanAndRecoverProxyResponse>(req, "BanAndRecoverProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BindListenerRealServers）用于TCP/UDP监听器绑定解绑源站。
        /// 注意：本接口会解绑之前绑定的源站，绑定本次调用所选择的源站。例如：原来绑定的源站为A，B，C，本次调用的选择绑定的源站为C，D，E，那么调用后所绑定的源站为C，D，E。
        /// </summary>
        /// <param name="req"><see cref="BindListenerRealServersRequest"/></param>
        /// <returns><see cref="BindListenerRealServersResponse"/></returns>
        public Task<BindListenerRealServersResponse> BindListenerRealServers(BindListenerRealServersRequest req)
        {
            return InternalRequestAsync<BindListenerRealServersResponse>(req, "BindListenerRealServers");
        }

        /// <summary>
        /// 本接口（BindListenerRealServers）用于TCP/UDP监听器绑定解绑源站。
        /// 注意：本接口会解绑之前绑定的源站，绑定本次调用所选择的源站。例如：原来绑定的源站为A，B，C，本次调用的选择绑定的源站为C，D，E，那么调用后所绑定的源站为C，D，E。
        /// </summary>
        /// <param name="req"><see cref="BindListenerRealServersRequest"/></param>
        /// <returns><see cref="BindListenerRealServersResponse"/></returns>
        public BindListenerRealServersResponse BindListenerRealServersSync(BindListenerRealServersRequest req)
        {
            return InternalRequestAsync<BindListenerRealServersResponse>(req, "BindListenerRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于7层监听器的转发规则绑定源站。注意：本接口会解绑之前绑定的源站，绑定本次调用所选择的源站。
        /// </summary>
        /// <param name="req"><see cref="BindRuleRealServersRequest"/></param>
        /// <returns><see cref="BindRuleRealServersResponse"/></returns>
        public Task<BindRuleRealServersResponse> BindRuleRealServers(BindRuleRealServersRequest req)
        {
            return InternalRequestAsync<BindRuleRealServersResponse>(req, "BindRuleRealServers");
        }

        /// <summary>
        /// 该接口用于7层监听器的转发规则绑定源站。注意：本接口会解绑之前绑定的源站，绑定本次调用所选择的源站。
        /// </summary>
        /// <param name="req"><see cref="BindRuleRealServersRequest"/></param>
        /// <returns><see cref="BindRuleRealServersResponse"/></returns>
        public BindRuleRealServersResponse BindRuleRealServersSync(BindRuleRealServersRequest req)
        {
            return InternalRequestAsync<BindRuleRealServersResponse>(req, "BindRuleRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CheckProxyCreate)用于查询能否创建指定配置的加速通道。
        /// </summary>
        /// <param name="req"><see cref="CheckProxyCreateRequest"/></param>
        /// <returns><see cref="CheckProxyCreateResponse"/></returns>
        public Task<CheckProxyCreateResponse> CheckProxyCreate(CheckProxyCreateRequest req)
        {
            return InternalRequestAsync<CheckProxyCreateResponse>(req, "CheckProxyCreate");
        }

        /// <summary>
        /// 本接口(CheckProxyCreate)用于查询能否创建指定配置的加速通道。
        /// </summary>
        /// <param name="req"><see cref="CheckProxyCreateRequest"/></param>
        /// <returns><see cref="CheckProxyCreateResponse"/></returns>
        public CheckProxyCreateResponse CheckProxyCreateSync(CheckProxyCreateRequest req)
        {
            return InternalRequestAsync<CheckProxyCreateResponse>(req, "CheckProxyCreate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloseProxies）用于关闭通道。通道关闭后，不再产生流量，但每天仍然收取通道基础配置费用。
        /// </summary>
        /// <param name="req"><see cref="CloseProxiesRequest"/></param>
        /// <returns><see cref="CloseProxiesResponse"/></returns>
        public Task<CloseProxiesResponse> CloseProxies(CloseProxiesRequest req)
        {
            return InternalRequestAsync<CloseProxiesResponse>(req, "CloseProxies");
        }

        /// <summary>
        /// 本接口（CloseProxies）用于关闭通道。通道关闭后，不再产生流量，但每天仍然收取通道基础配置费用。
        /// </summary>
        /// <param name="req"><see cref="CloseProxiesRequest"/></param>
        /// <returns><see cref="CloseProxiesResponse"/></returns>
        public CloseProxiesResponse CloseProxiesSync(CloseProxiesRequest req)
        {
            return InternalRequestAsync<CloseProxiesResponse>(req, "CloseProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CloseProxyGroup）用于关闭通道组。通道组关闭后，不再产生流量，但每天仍然收取通道基础配置费用。
        /// </summary>
        /// <param name="req"><see cref="CloseProxyGroupRequest"/></param>
        /// <returns><see cref="CloseProxyGroupResponse"/></returns>
        public Task<CloseProxyGroupResponse> CloseProxyGroup(CloseProxyGroupRequest req)
        {
            return InternalRequestAsync<CloseProxyGroupResponse>(req, "CloseProxyGroup");
        }

        /// <summary>
        /// 本接口（CloseProxyGroup）用于关闭通道组。通道组关闭后，不再产生流量，但每天仍然收取通道基础配置费用。
        /// </summary>
        /// <param name="req"><see cref="CloseProxyGroupRequest"/></param>
        /// <returns><see cref="CloseProxyGroupResponse"/></returns>
        public CloseProxyGroupResponse CloseProxyGroupSync(CloseProxyGroupRequest req)
        {
            return InternalRequestAsync<CloseProxyGroupResponse>(req, "CloseProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭安全策略
        /// </summary>
        /// <param name="req"><see cref="CloseSecurityPolicyRequest"/></param>
        /// <returns><see cref="CloseSecurityPolicyResponse"/></returns>
        public Task<CloseSecurityPolicyResponse> CloseSecurityPolicy(CloseSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CloseSecurityPolicyResponse>(req, "CloseSecurityPolicy");
        }

        /// <summary>
        /// 关闭安全策略
        /// </summary>
        /// <param name="req"><see cref="CloseSecurityPolicyRequest"/></param>
        /// <returns><see cref="CloseSecurityPolicyResponse"/></returns>
        public CloseSecurityPolicyResponse CloseSecurityPolicySync(CloseSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CloseSecurityPolicyResponse>(req, "CloseSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCertificate）用于创建Gaap相关证书和配置文件，包括基础认证配置文件，客户端CA证书，服务器SSL证书，Gaap SSL证书以及源站CA证书。
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate");
        }

        /// <summary>
        /// 本接口（CreateCertificate）用于创建Gaap相关证书和配置文件，包括基础认证配置文件，客户端CA证书，服务器SSL证书，Gaap SSL证书以及源站CA证书。
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public CreateCertificateResponse CreateCertificateSync(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateCustomHeader）用于创建HTTP/HTTPS监听器的自定义header，客户端请求通过访问该监听器时，会将监听器中配置的header信息发送到源站。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomHeaderRequest"/></param>
        /// <returns><see cref="CreateCustomHeaderResponse"/></returns>
        public Task<CreateCustomHeaderResponse> CreateCustomHeader(CreateCustomHeaderRequest req)
        {
            return InternalRequestAsync<CreateCustomHeaderResponse>(req, "CreateCustomHeader");
        }

        /// <summary>
        /// 本接口（CreateCustomHeader）用于创建HTTP/HTTPS监听器的自定义header，客户端请求通过访问该监听器时，会将监听器中配置的header信息发送到源站。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomHeaderRequest"/></param>
        /// <returns><see cref="CreateCustomHeaderResponse"/></returns>
        public CreateCustomHeaderResponse CreateCustomHeaderSync(CreateCustomHeaderRequest req)
        {
            return InternalRequestAsync<CreateCustomHeaderResponse>(req, "CreateCustomHeader")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDomain）用于创建HTTP/HTTPS监听器的访问域名，客户端请求通过访问该域名来请求后端业务。
        /// 该接口仅支持version3.0的通道。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain");
        }

        /// <summary>
        /// 本接口（CreateDomain）用于创建HTTP/HTTPS监听器的访问域名，客户端请求通过访问该域名来请求后端业务。
        /// 该接口仅支持version3.0的通道。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 定制域名指定错误码的错误响应
        /// </summary>
        /// <param name="req"><see cref="CreateDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="CreateDomainErrorPageInfoResponse"/></returns>
        public Task<CreateDomainErrorPageInfoResponse> CreateDomainErrorPageInfo(CreateDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<CreateDomainErrorPageInfoResponse>(req, "CreateDomainErrorPageInfo");
        }

        /// <summary>
        /// 定制域名指定错误码的错误响应
        /// </summary>
        /// <param name="req"><see cref="CreateDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="CreateDomainErrorPageInfoResponse"/></returns>
        public CreateDomainErrorPageInfoResponse CreateDomainErrorPageInfoSync(CreateDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<CreateDomainErrorPageInfoResponse>(req, "CreateDomainErrorPageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateFirstLinkSession）用于创建接入段加速会话，创建有可能成功，也可能失败，需要通过返回码来进行判断。
        /// </summary>
        /// <param name="req"><see cref="CreateFirstLinkSessionRequest"/></param>
        /// <returns><see cref="CreateFirstLinkSessionResponse"/></returns>
        public Task<CreateFirstLinkSessionResponse> CreateFirstLinkSession(CreateFirstLinkSessionRequest req)
        {
            return InternalRequestAsync<CreateFirstLinkSessionResponse>(req, "CreateFirstLinkSession");
        }

        /// <summary>
        /// 本接口（CreateFirstLinkSession）用于创建接入段加速会话，创建有可能成功，也可能失败，需要通过返回码来进行判断。
        /// </summary>
        /// <param name="req"><see cref="CreateFirstLinkSessionRequest"/></param>
        /// <returns><see cref="CreateFirstLinkSessionResponse"/></returns>
        public CreateFirstLinkSessionResponse CreateFirstLinkSessionSync(CreateFirstLinkSessionRequest req)
        {
            return InternalRequestAsync<CreateFirstLinkSessionResponse>(req, "CreateFirstLinkSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用来创建统一域名
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainResponse"/></returns>
        public Task<CreateGlobalDomainResponse> CreateGlobalDomain(CreateGlobalDomainRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainResponse>(req, "CreateGlobalDomain");
        }

        /// <summary>
        /// 用来创建统一域名
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainResponse"/></returns>
        public CreateGlobalDomainResponse CreateGlobalDomainSync(CreateGlobalDomainRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainResponse>(req, "CreateGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建域名解析记录
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainDnsResponse"/></returns>
        public Task<CreateGlobalDomainDnsResponse> CreateGlobalDomainDns(CreateGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainDnsResponse>(req, "CreateGlobalDomainDns");
        }

        /// <summary>
        /// 创建域名解析记录
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainDnsResponse"/></returns>
        public CreateGlobalDomainDnsResponse CreateGlobalDomainDnsSync(CreateGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainDnsResponse>(req, "CreateGlobalDomainDns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateHTTPListener）用于在通道实例下创建HTTP协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPListenerResponse"/></returns>
        public Task<CreateHTTPListenerResponse> CreateHTTPListener(CreateHTTPListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPListenerResponse>(req, "CreateHTTPListener");
        }

        /// <summary>
        /// 该接口（CreateHTTPListener）用于在通道实例下创建HTTP协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPListenerResponse"/></returns>
        public CreateHTTPListenerResponse CreateHTTPListenerSync(CreateHTTPListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPListenerResponse>(req, "CreateHTTPListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateHTTPSListener）用于在通道实例下创建HTTPS协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPSListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPSListenerResponse"/></returns>
        public Task<CreateHTTPSListenerResponse> CreateHTTPSListener(CreateHTTPSListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPSListenerResponse>(req, "CreateHTTPSListener");
        }

        /// <summary>
        /// 该接口（CreateHTTPSListener）用于在通道实例下创建HTTPS协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateHTTPSListenerRequest"/></param>
        /// <returns><see cref="CreateHTTPSListenerResponse"/></returns>
        public CreateHTTPSListenerResponse CreateHTTPSListenerSync(CreateHTTPSListenerRequest req)
        {
            return InternalRequestAsync<CreateHTTPSListenerResponse>(req, "CreateHTTPSListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateProxy）用于创建/复制一个指定配置的加速通道。当复制通道时，需要设置新通道的基本配置参数，并设置ClonedProxyId来指定被复制的通道。
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public Task<CreateProxyResponse> CreateProxy(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy");
        }

        /// <summary>
        /// 本接口（CreateProxy）用于创建/复制一个指定配置的加速通道。当复制通道时，需要设置新通道的基本配置参数，并设置ClonedProxyId来指定被复制的通道。
        /// </summary>
        /// <param name="req"><see cref="CreateProxyRequest"/></param>
        /// <returns><see cref="CreateProxyResponse"/></returns>
        public CreateProxyResponse CreateProxySync(CreateProxyRequest req)
        {
            return InternalRequestAsync<CreateProxyResponse>(req, "CreateProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateProxyGroup）用于创建通道组。
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupRequest"/></param>
        /// <returns><see cref="CreateProxyGroupResponse"/></returns>
        public Task<CreateProxyGroupResponse> CreateProxyGroup(CreateProxyGroupRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupResponse>(req, "CreateProxyGroup");
        }

        /// <summary>
        /// 本接口（CreateProxyGroup）用于创建通道组。
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupRequest"/></param>
        /// <returns><see cref="CreateProxyGroupResponse"/></returns>
        public CreateProxyGroupResponse CreateProxyGroupSync(CreateProxyGroupRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupResponse>(req, "CreateProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateProxyGroupDomain）用于创建通道组域名，并开启域名解析。
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupDomainRequest"/></param>
        /// <returns><see cref="CreateProxyGroupDomainResponse"/></returns>
        public Task<CreateProxyGroupDomainResponse> CreateProxyGroupDomain(CreateProxyGroupDomainRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupDomainResponse>(req, "CreateProxyGroupDomain");
        }

        /// <summary>
        /// 本接口（CreateProxyGroupDomain）用于创建通道组域名，并开启域名解析。
        /// </summary>
        /// <param name="req"><see cref="CreateProxyGroupDomainRequest"/></param>
        /// <returns><see cref="CreateProxyGroupDomainResponse"/></returns>
        public CreateProxyGroupDomainResponse CreateProxyGroupDomainSync(CreateProxyGroupDomainRequest req)
        {
            return InternalRequestAsync<CreateProxyGroupDomainResponse>(req, "CreateProxyGroupDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateRule）用于创建HTTP/HTTPS监听器转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// 该接口（CreateRule）用于创建HTTP/HTTPS监听器转发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安全策略
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public Task<CreateSecurityPolicyResponse> CreateSecurityPolicy(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy");
        }

        /// <summary>
        /// 创建安全策略
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateSecurityPolicyResponse"/></returns>
        public CreateSecurityPolicyResponse CreateSecurityPolicySync(CreateSecurityPolicyRequest req)
        {
            return InternalRequestAsync<CreateSecurityPolicyResponse>(req, "CreateSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加安全策略规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityRulesResponse"/></returns>
        public Task<CreateSecurityRulesResponse> CreateSecurityRules(CreateSecurityRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityRulesResponse>(req, "CreateSecurityRules");
        }

        /// <summary>
        /// 添加安全策略规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityRulesResponse"/></returns>
        public CreateSecurityRulesResponse CreateSecurityRulesSync(CreateSecurityRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityRulesResponse>(req, "CreateSecurityRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateTCPListeners）用于批量创建单通道或者通道组的TCP协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateTCPListenersRequest"/></param>
        /// <returns><see cref="CreateTCPListenersResponse"/></returns>
        public Task<CreateTCPListenersResponse> CreateTCPListeners(CreateTCPListenersRequest req)
        {
            return InternalRequestAsync<CreateTCPListenersResponse>(req, "CreateTCPListeners");
        }

        /// <summary>
        /// 该接口（CreateTCPListeners）用于批量创建单通道或者通道组的TCP协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateTCPListenersRequest"/></param>
        /// <returns><see cref="CreateTCPListenersResponse"/></returns>
        public CreateTCPListenersResponse CreateTCPListenersSync(CreateTCPListenersRequest req)
        {
            return InternalRequestAsync<CreateTCPListenersResponse>(req, "CreateTCPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateUDPListeners）用于批量创建单通道或者通道组的UDP协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateUDPListenersRequest"/></param>
        /// <returns><see cref="CreateUDPListenersResponse"/></returns>
        public Task<CreateUDPListenersResponse> CreateUDPListeners(CreateUDPListenersRequest req)
        {
            return InternalRequestAsync<CreateUDPListenersResponse>(req, "CreateUDPListeners");
        }

        /// <summary>
        /// 该接口（CreateUDPListeners）用于批量创建单通道或者通道组的UDP协议类型的监听器。
        /// </summary>
        /// <param name="req"><see cref="CreateUDPListenersRequest"/></param>
        /// <returns><see cref="CreateUDPListenersResponse"/></returns>
        public CreateUDPListenersResponse CreateUDPListenersSync(CreateUDPListenersRequest req)
        {
            return InternalRequestAsync<CreateUDPListenersResponse>(req, "CreateUDPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCertificate）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate");
        }

        /// <summary>
        /// 本接口（DeleteCertificate）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public DeleteCertificateResponse DeleteCertificateSync(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDomain）仅适用于7层监听器，用于删除该监听器下对应域名及域名下的所有规则，所有已绑定源站的规则将自动解绑。
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain");
        }

        /// <summary>
        /// 本接口（DeleteDomain）仅适用于7层监听器，用于删除该监听器下对应域名及域名下的所有规则，所有已绑定源站的规则将自动解绑。
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除域名的定制错误
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DeleteDomainErrorPageInfoResponse"/></returns>
        public Task<DeleteDomainErrorPageInfoResponse> DeleteDomainErrorPageInfo(DeleteDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DeleteDomainErrorPageInfoResponse>(req, "DeleteDomainErrorPageInfo");
        }

        /// <summary>
        /// 删除域名的定制错误
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DeleteDomainErrorPageInfoResponse"/></returns>
        public DeleteDomainErrorPageInfoResponse DeleteDomainErrorPageInfoSync(DeleteDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DeleteDomainErrorPageInfoResponse>(req, "DeleteDomainErrorPageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteFirstLinkSession）用于删除接入段加速会话，删除加速会话后会停止加速。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirstLinkSessionRequest"/></param>
        /// <returns><see cref="DeleteFirstLinkSessionResponse"/></returns>
        public Task<DeleteFirstLinkSessionResponse> DeleteFirstLinkSession(DeleteFirstLinkSessionRequest req)
        {
            return InternalRequestAsync<DeleteFirstLinkSessionResponse>(req, "DeleteFirstLinkSession");
        }

        /// <summary>
        /// 本接口（DeleteFirstLinkSession）用于删除接入段加速会话，删除加速会话后会停止加速。
        /// </summary>
        /// <param name="req"><see cref="DeleteFirstLinkSessionRequest"/></param>
        /// <returns><see cref="DeleteFirstLinkSessionResponse"/></returns>
        public DeleteFirstLinkSessionResponse DeleteFirstLinkSessionSync(DeleteFirstLinkSessionRequest req)
        {
            return InternalRequestAsync<DeleteFirstLinkSessionResponse>(req, "DeleteFirstLinkSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除统一域名
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainResponse"/></returns>
        public Task<DeleteGlobalDomainResponse> DeleteGlobalDomain(DeleteGlobalDomainRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainResponse>(req, "DeleteGlobalDomain");
        }

        /// <summary>
        /// 删除统一域名
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainResponse"/></returns>
        public DeleteGlobalDomainResponse DeleteGlobalDomainSync(DeleteGlobalDomainRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainResponse>(req, "DeleteGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除域名的某条解析记录
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainDnsResponse"/></returns>
        public Task<DeleteGlobalDomainDnsResponse> DeleteGlobalDomainDns(DeleteGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainDnsResponse>(req, "DeleteGlobalDomainDns");
        }

        /// <summary>
        /// 删除域名的某条解析记录
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainDnsResponse"/></returns>
        public DeleteGlobalDomainDnsResponse DeleteGlobalDomainDnsSync(DeleteGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainDnsResponse>(req, "DeleteGlobalDomainDns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DeleteListeners）用于批量删除通道或通道组的监听器，包括4/7层监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public Task<DeleteListenersResponse> DeleteListeners(DeleteListenersRequest req)
        {
            return InternalRequestAsync<DeleteListenersResponse>(req, "DeleteListeners");
        }

        /// <summary>
        /// 该接口（DeleteListeners）用于批量删除通道或通道组的监听器，包括4/7层监听器。
        /// </summary>
        /// <param name="req"><see cref="DeleteListenersRequest"/></param>
        /// <returns><see cref="DeleteListenersResponse"/></returns>
        public DeleteListenersResponse DeleteListenersSync(DeleteListenersRequest req)
        {
            return InternalRequestAsync<DeleteListenersResponse>(req, "DeleteListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteProxyGroup）用于删除通道组。
        /// </summary>
        /// <param name="req"><see cref="DeleteProxyGroupRequest"/></param>
        /// <returns><see cref="DeleteProxyGroupResponse"/></returns>
        public Task<DeleteProxyGroupResponse> DeleteProxyGroup(DeleteProxyGroupRequest req)
        {
            return InternalRequestAsync<DeleteProxyGroupResponse>(req, "DeleteProxyGroup");
        }

        /// <summary>
        /// 本接口（DeleteProxyGroup）用于删除通道组。
        /// </summary>
        /// <param name="req"><see cref="DeleteProxyGroupRequest"/></param>
        /// <returns><see cref="DeleteProxyGroupResponse"/></returns>
        public DeleteProxyGroupResponse DeleteProxyGroupSync(DeleteProxyGroupRequest req)
        {
            return InternalRequestAsync<DeleteProxyGroupResponse>(req, "DeleteProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DeleteRule）用于删除HTTP/HTTPS监听器的转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// 该接口（DeleteRule）用于删除HTTP/HTTPS监听器的转发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安全策略
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicy(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy");
        }

        /// <summary>
        /// 删除安全策略
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteSecurityPolicyResponse"/></returns>
        public DeleteSecurityPolicyResponse DeleteSecurityPolicySync(DeleteSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DeleteSecurityPolicyResponse>(req, "DeleteSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安全策略规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityRulesRequest"/></param>
        /// <returns><see cref="DeleteSecurityRulesResponse"/></returns>
        public Task<DeleteSecurityRulesResponse> DeleteSecurityRules(DeleteSecurityRulesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityRulesResponse>(req, "DeleteSecurityRules");
        }

        /// <summary>
        /// 删除安全策略规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityRulesRequest"/></param>
        /// <returns><see cref="DeleteSecurityRulesResponse"/></returns>
        public DeleteSecurityRulesResponse DeleteSecurityRulesSync(DeleteSecurityRulesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityRulesResponse>(req, "DeleteSecurityRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccessRegions）用于查询加速区域，即客户端接入区域。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsResponse"/></returns>
        public Task<DescribeAccessRegionsResponse> DescribeAccessRegions(DescribeAccessRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsResponse>(req, "DescribeAccessRegions");
        }

        /// <summary>
        /// 本接口（DescribeAccessRegions）用于查询加速区域，即客户端接入区域。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsResponse"/></returns>
        public DescribeAccessRegionsResponse DescribeAccessRegionsSync(DescribeAccessRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsResponse>(req, "DescribeAccessRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAccessRegionsByDestRegion）根据源站区域查询可用的加速区域列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsByDestRegionRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsByDestRegionResponse"/></returns>
        public Task<DescribeAccessRegionsByDestRegionResponse> DescribeAccessRegionsByDestRegion(DescribeAccessRegionsByDestRegionRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsByDestRegionResponse>(req, "DescribeAccessRegionsByDestRegion");
        }

        /// <summary>
        /// 本接口（DescribeAccessRegionsByDestRegion）根据源站区域查询可用的加速区域列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRegionsByDestRegionRequest"/></param>
        /// <returns><see cref="DescribeAccessRegionsByDestRegionResponse"/></returns>
        public DescribeAccessRegionsByDestRegionResponse DescribeAccessRegionsByDestRegionSync(DescribeAccessRegionsByDestRegionRequest req)
        {
            return InternalRequestAsync<DescribeAccessRegionsByDestRegionResponse>(req, "DescribeAccessRegionsByDestRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为了防止在下单、询价、后付费开通等过程中确保来源合法以及订单参数没有被篡改过，各个业务方使用下单、询价等场景需调用计费签名接口获取签名，获取签名的请求需带上签名以验证身份，本接口可以获取计费签名。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthSignatureRequest"/></param>
        /// <returns><see cref="DescribeAuthSignatureResponse"/></returns>
        public Task<DescribeAuthSignatureResponse> DescribeAuthSignature(DescribeAuthSignatureRequest req)
        {
            return InternalRequestAsync<DescribeAuthSignatureResponse>(req, "DescribeAuthSignature");
        }

        /// <summary>
        /// 为了防止在下单、询价、后付费开通等过程中确保来源合法以及订单参数没有被篡改过，各个业务方使用下单、询价等场景需调用计费签名接口获取签名，获取签名的请求需带上签名以验证身份，本接口可以获取计费签名。
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthSignatureRequest"/></param>
        /// <returns><see cref="DescribeAuthSignatureResponse"/></returns>
        public DescribeAuthSignatureResponse DescribeAuthSignatureSync(DescribeAuthSignatureRequest req)
        {
            return InternalRequestAsync<DescribeAuthSignatureResponse>(req, "DescribeAuthSignature")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBlackHeader）用于查询禁用的自定义header 名称
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackHeaderRequest"/></param>
        /// <returns><see cref="DescribeBlackHeaderResponse"/></returns>
        public Task<DescribeBlackHeaderResponse> DescribeBlackHeader(DescribeBlackHeaderRequest req)
        {
            return InternalRequestAsync<DescribeBlackHeaderResponse>(req, "DescribeBlackHeader");
        }

        /// <summary>
        /// 本接口（DescribeBlackHeader）用于查询禁用的自定义header 名称
        /// </summary>
        /// <param name="req"><see cref="DescribeBlackHeaderRequest"/></param>
        /// <returns><see cref="DescribeBlackHeaderResponse"/></returns>
        public DescribeBlackHeaderResponse DescribeBlackHeaderSync(DescribeBlackHeaderRequest req)
        {
            return InternalRequestAsync<DescribeBlackHeaderResponse>(req, "DescribeBlackHeader")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCertificateDetail）用于查询证书详情，包括证书ID，证书名字，证书类型，证书内容以及密钥等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail");
        }

        /// <summary>
        /// 本接口（DescribeCertificateDetail）用于查询证书详情，包括证书ID，证书名字，证书类型，证书内容以及密钥等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public DescribeCertificateDetailResponse DescribeCertificateDetailSync(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCertificates）用来查询可以使用的证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates");
        }

        /// <summary>
        /// 本接口（DescribeCertificates）用来查询可以使用的证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public DescribeCertificatesResponse DescribeCertificatesSync(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCountryAreaMapping）用于获取国家地区编码映射表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCountryAreaMappingRequest"/></param>
        /// <returns><see cref="DescribeCountryAreaMappingResponse"/></returns>
        public Task<DescribeCountryAreaMappingResponse> DescribeCountryAreaMapping(DescribeCountryAreaMappingRequest req)
        {
            return InternalRequestAsync<DescribeCountryAreaMappingResponse>(req, "DescribeCountryAreaMapping");
        }

        /// <summary>
        /// 本接口（DescribeCountryAreaMapping）用于获取国家地区编码映射表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCountryAreaMappingRequest"/></param>
        /// <returns><see cref="DescribeCountryAreaMappingResponse"/></returns>
        public DescribeCountryAreaMappingResponse DescribeCountryAreaMappingSync(DescribeCountryAreaMappingRequest req)
        {
            return InternalRequestAsync<DescribeCountryAreaMappingResponse>(req, "DescribeCountryAreaMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderProxies）用于查询跨境通道实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderProxiesRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderProxiesResponse"/></returns>
        public Task<DescribeCrossBorderProxiesResponse> DescribeCrossBorderProxies(DescribeCrossBorderProxiesRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderProxiesResponse>(req, "DescribeCrossBorderProxies");
        }

        /// <summary>
        /// 本接口（DescribeCrossBorderProxies）用于查询跨境通道实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderProxiesRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderProxiesResponse"/></returns>
        public DescribeCrossBorderProxiesResponse DescribeCrossBorderProxiesSync(DescribeCrossBorderProxiesRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderProxiesResponse>(req, "DescribeCrossBorderProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeCustomHeader）用于自定义header列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomHeaderRequest"/></param>
        /// <returns><see cref="DescribeCustomHeaderResponse"/></returns>
        public Task<DescribeCustomHeaderResponse> DescribeCustomHeader(DescribeCustomHeaderRequest req)
        {
            return InternalRequestAsync<DescribeCustomHeaderResponse>(req, "DescribeCustomHeader");
        }

        /// <summary>
        /// 本接口（DescribeCustomHeader）用于自定义header列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomHeaderRequest"/></param>
        /// <returns><see cref="DescribeCustomHeaderResponse"/></returns>
        public DescribeCustomHeaderResponse DescribeCustomHeaderSync(DescribeCustomHeaderRequest req)
        {
            return InternalRequestAsync<DescribeCustomHeaderResponse>(req, "DescribeCustomHeader")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDestRegions）用于查询源站区域，即源站服务器所在区域。
        /// </summary>
        /// <param name="req"><see cref="DescribeDestRegionsRequest"/></param>
        /// <returns><see cref="DescribeDestRegionsResponse"/></returns>
        public Task<DescribeDestRegionsResponse> DescribeDestRegions(DescribeDestRegionsRequest req)
        {
            return InternalRequestAsync<DescribeDestRegionsResponse>(req, "DescribeDestRegions");
        }

        /// <summary>
        /// 本接口（DescribeDestRegions）用于查询源站区域，即源站服务器所在区域。
        /// </summary>
        /// <param name="req"><see cref="DescribeDestRegionsRequest"/></param>
        /// <returns><see cref="DescribeDestRegionsResponse"/></returns>
        public DescribeDestRegionsResponse DescribeDestRegionsSync(DescribeDestRegionsRequest req)
        {
            return InternalRequestAsync<DescribeDestRegionsResponse>(req, "DescribeDestRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询目前定制域名的错误响应
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoResponse"/></returns>
        public Task<DescribeDomainErrorPageInfoResponse> DescribeDomainErrorPageInfo(DescribeDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoResponse>(req, "DescribeDomainErrorPageInfo");
        }

        /// <summary>
        /// 查询目前定制域名的错误响应
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoResponse"/></returns>
        public DescribeDomainErrorPageInfoResponse DescribeDomainErrorPageInfoSync(DescribeDomainErrorPageInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoResponse>(req, "DescribeDomainErrorPageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据定制错误ID查询错误响应
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoByIdsRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoByIdsResponse"/></returns>
        public Task<DescribeDomainErrorPageInfoByIdsResponse> DescribeDomainErrorPageInfoByIds(DescribeDomainErrorPageInfoByIdsRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoByIdsResponse>(req, "DescribeDomainErrorPageInfoByIds");
        }

        /// <summary>
        /// 根据定制错误ID查询错误响应
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainErrorPageInfoByIdsRequest"/></param>
        /// <returns><see cref="DescribeDomainErrorPageInfoByIdsResponse"/></returns>
        public DescribeDomainErrorPageInfoByIdsResponse DescribeDomainErrorPageInfoByIdsSync(DescribeDomainErrorPageInfoByIdsRequest req)
        {
            return InternalRequestAsync<DescribeDomainErrorPageInfoByIdsResponse>(req, "DescribeDomainErrorPageInfoByIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFirstLinkSession）用于查询接入段加速会话状态，包括会话状态，生效时长，加速套餐等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirstLinkSessionRequest"/></param>
        /// <returns><see cref="DescribeFirstLinkSessionResponse"/></returns>
        public Task<DescribeFirstLinkSessionResponse> DescribeFirstLinkSession(DescribeFirstLinkSessionRequest req)
        {
            return InternalRequestAsync<DescribeFirstLinkSessionResponse>(req, "DescribeFirstLinkSession");
        }

        /// <summary>
        /// 本接口（DescribeFirstLinkSession）用于查询接入段加速会话状态，包括会话状态，生效时长，加速套餐等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFirstLinkSessionRequest"/></param>
        /// <returns><see cref="DescribeFirstLinkSessionResponse"/></returns>
        public DescribeFirstLinkSessionResponse DescribeFirstLinkSessionSync(DescribeFirstLinkSessionRequest req)
        {
            return InternalRequestAsync<DescribeFirstLinkSessionResponse>(req, "DescribeFirstLinkSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询域名解析列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainDnsResponse"/></returns>
        public Task<DescribeGlobalDomainDnsResponse> DescribeGlobalDomainDns(DescribeGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainDnsResponse>(req, "DescribeGlobalDomainDns");
        }

        /// <summary>
        /// 查询域名解析列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainDnsResponse"/></returns>
        public DescribeGlobalDomainDnsResponse DescribeGlobalDomainDnsSync(DescribeGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainDnsResponse>(req, "DescribeGlobalDomainDns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainsRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainsResponse"/></returns>
        public Task<DescribeGlobalDomainsResponse> DescribeGlobalDomains(DescribeGlobalDomainsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainsResponse>(req, "DescribeGlobalDomains");
        }

        /// <summary>
        /// 查询域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainsRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainsResponse"/></returns>
        public DescribeGlobalDomainsResponse DescribeGlobalDomainsSync(DescribeGlobalDomainsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainsResponse>(req, "DescribeGlobalDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为内部接口，用于查询可以获取统计数据的通道组和通道信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAndStatisticsProxyRequest"/></param>
        /// <returns><see cref="DescribeGroupAndStatisticsProxyResponse"/></returns>
        public Task<DescribeGroupAndStatisticsProxyResponse> DescribeGroupAndStatisticsProxy(DescribeGroupAndStatisticsProxyRequest req)
        {
            return InternalRequestAsync<DescribeGroupAndStatisticsProxyResponse>(req, "DescribeGroupAndStatisticsProxy");
        }

        /// <summary>
        /// 该接口为内部接口，用于查询可以获取统计数据的通道组和通道信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupAndStatisticsProxyRequest"/></param>
        /// <returns><see cref="DescribeGroupAndStatisticsProxyResponse"/></returns>
        public DescribeGroupAndStatisticsProxyResponse DescribeGroupAndStatisticsProxySync(DescribeGroupAndStatisticsProxyRequest req)
        {
            return InternalRequestAsync<DescribeGroupAndStatisticsProxyResponse>(req, "DescribeGroupAndStatisticsProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeGroupDomainConfig）用于获取通道组域名解析配置详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDomainConfigRequest"/></param>
        /// <returns><see cref="DescribeGroupDomainConfigResponse"/></returns>
        public Task<DescribeGroupDomainConfigResponse> DescribeGroupDomainConfig(DescribeGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<DescribeGroupDomainConfigResponse>(req, "DescribeGroupDomainConfig");
        }

        /// <summary>
        /// 本接口（DescribeGroupDomainConfig）用于获取通道组域名解析配置详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDomainConfigRequest"/></param>
        /// <returns><see cref="DescribeGroupDomainConfigResponse"/></returns>
        public DescribeGroupDomainConfigResponse DescribeGroupDomainConfigSync(DescribeGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<DescribeGroupDomainConfigResponse>(req, "DescribeGroupDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeHTTPListeners）用来查询HTTP监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPListenersResponse"/></returns>
        public Task<DescribeHTTPListenersResponse> DescribeHTTPListeners(DescribeHTTPListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPListenersResponse>(req, "DescribeHTTPListeners");
        }

        /// <summary>
        /// 该接口（DescribeHTTPListeners）用来查询HTTP监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPListenersResponse"/></returns>
        public DescribeHTTPListenersResponse DescribeHTTPListenersSync(DescribeHTTPListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPListenersResponse>(req, "DescribeHTTPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeHTTPSListeners）用来查询HTTPS监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPSListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPSListenersResponse"/></returns>
        public Task<DescribeHTTPSListenersResponse> DescribeHTTPSListeners(DescribeHTTPSListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPSListenersResponse>(req, "DescribeHTTPSListeners");
        }

        /// <summary>
        /// 本接口（DescribeHTTPSListeners）用来查询HTTPS监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeHTTPSListenersRequest"/></param>
        /// <returns><see cref="DescribeHTTPSListenersResponse"/></returns>
        public DescribeHTTPSListenersResponse DescribeHTTPSListenersSync(DescribeHTTPSListenersRequest req)
        {
            return InternalRequestAsync<DescribeHTTPSListenersResponse>(req, "DescribeHTTPSListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeListenerRealServers）用于查询TCP/UDP监听器源站列表，包括该监听器已经绑定的源站列表以及可以绑定的源站列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerRealServersRequest"/></param>
        /// <returns><see cref="DescribeListenerRealServersResponse"/></returns>
        public Task<DescribeListenerRealServersResponse> DescribeListenerRealServers(DescribeListenerRealServersRequest req)
        {
            return InternalRequestAsync<DescribeListenerRealServersResponse>(req, "DescribeListenerRealServers");
        }

        /// <summary>
        /// 该接口（DescribeListenerRealServers）用于查询TCP/UDP监听器源站列表，包括该监听器已经绑定的源站列表以及可以绑定的源站列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerRealServersRequest"/></param>
        /// <returns><see cref="DescribeListenerRealServersResponse"/></returns>
        public DescribeListenerRealServersResponse DescribeListenerRealServersSync(DescribeListenerRealServersRequest req)
        {
            return InternalRequestAsync<DescribeListenerRealServersResponse>(req, "DescribeListenerRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发数据。支持300秒, 3600秒和86400秒的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeListenerStatisticsResponse"/></returns>
        public Task<DescribeListenerStatisticsResponse> DescribeListenerStatistics(DescribeListenerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeListenerStatisticsResponse>(req, "DescribeListenerStatistics");
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发数据。支持300秒, 3600秒和86400秒的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeListenerStatisticsResponse"/></returns>
        public DescribeListenerStatisticsResponse DescribeListenerStatisticsSync(DescribeListenerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeListenerStatisticsResponse>(req, "DescribeListenerStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxies）用于查询通道实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public Task<DescribeProxiesResponse> DescribeProxies(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies");
        }

        /// <summary>
        /// 本接口（DescribeProxies）用于查询通道实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesRequest"/></param>
        /// <returns><see cref="DescribeProxiesResponse"/></returns>
        public DescribeProxiesResponse DescribeProxiesSync(DescribeProxiesRequest req)
        {
            return InternalRequestAsync<DescribeProxiesResponse>(req, "DescribeProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxiesStatus）用于查询通道状态列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesStatusRequest"/></param>
        /// <returns><see cref="DescribeProxiesStatusResponse"/></returns>
        public Task<DescribeProxiesStatusResponse> DescribeProxiesStatus(DescribeProxiesStatusRequest req)
        {
            return InternalRequestAsync<DescribeProxiesStatusResponse>(req, "DescribeProxiesStatus");
        }

        /// <summary>
        /// 本接口（DescribeProxiesStatus）用于查询通道状态列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxiesStatusRequest"/></param>
        /// <returns><see cref="DescribeProxiesStatusResponse"/></returns>
        public DescribeProxiesStatusResponse DescribeProxiesStatusSync(DescribeProxiesStatusRequest req)
        {
            return InternalRequestAsync<DescribeProxiesStatusResponse>(req, "DescribeProxiesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口为内部接口，用于查询可以获取统计数据的通道和监听器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyAndStatisticsListenersRequest"/></param>
        /// <returns><see cref="DescribeProxyAndStatisticsListenersResponse"/></returns>
        public Task<DescribeProxyAndStatisticsListenersResponse> DescribeProxyAndStatisticsListeners(DescribeProxyAndStatisticsListenersRequest req)
        {
            return InternalRequestAsync<DescribeProxyAndStatisticsListenersResponse>(req, "DescribeProxyAndStatisticsListeners");
        }

        /// <summary>
        /// 该接口为内部接口，用于查询可以获取统计数据的通道和监听器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyAndStatisticsListenersRequest"/></param>
        /// <returns><see cref="DescribeProxyAndStatisticsListenersResponse"/></returns>
        public DescribeProxyAndStatisticsListenersResponse DescribeProxyAndStatisticsListenersSync(DescribeProxyAndStatisticsListenersRequest req)
        {
            return InternalRequestAsync<DescribeProxyAndStatisticsListenersResponse>(req, "DescribeProxyAndStatisticsListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxyDetail）用于查询通道详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeProxyDetailResponse"/></returns>
        public Task<DescribeProxyDetailResponse> DescribeProxyDetail(DescribeProxyDetailRequest req)
        {
            return InternalRequestAsync<DescribeProxyDetailResponse>(req, "DescribeProxyDetail");
        }

        /// <summary>
        /// 本接口（DescribeProxyDetail）用于查询通道详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeProxyDetailResponse"/></returns>
        public DescribeProxyDetailResponse DescribeProxyDetailSync(DescribeProxyDetailRequest req)
        {
            return InternalRequestAsync<DescribeProxyDetailResponse>(req, "DescribeProxyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxyGroupDetails）用于查询通道组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupDetailsResponse"/></returns>
        public Task<DescribeProxyGroupDetailsResponse> DescribeProxyGroupDetails(DescribeProxyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupDetailsResponse>(req, "DescribeProxyGroupDetails");
        }

        /// <summary>
        /// 本接口（DescribeProxyGroupDetails）用于查询通道组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupDetailsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupDetailsResponse"/></returns>
        public DescribeProxyGroupDetailsResponse DescribeProxyGroupDetailsSync(DescribeProxyGroupDetailsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupDetailsResponse>(req, "DescribeProxyGroupDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxyGroupList）用于拉取通道组列表及各通道组基本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupListRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupListResponse"/></returns>
        public Task<DescribeProxyGroupListResponse> DescribeProxyGroupList(DescribeProxyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupListResponse>(req, "DescribeProxyGroupList");
        }

        /// <summary>
        /// 本接口（DescribeProxyGroupList）用于拉取通道组列表及各通道组基本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupListRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupListResponse"/></returns>
        public DescribeProxyGroupListResponse DescribeProxyGroupListSync(DescribeProxyGroupListRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupListResponse>(req, "DescribeProxyGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发数据。支持300, 3600和86400的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupStatisticsResponse"/></returns>
        public Task<DescribeProxyGroupStatisticsResponse> DescribeProxyGroupStatistics(DescribeProxyGroupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupStatisticsResponse>(req, "DescribeProxyGroupStatistics");
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发数据。支持300, 3600和86400的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyGroupStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyGroupStatisticsResponse"/></returns>
        public DescribeProxyGroupStatisticsResponse DescribeProxyGroupStatisticsSync(DescribeProxyGroupStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyGroupStatisticsResponse>(req, "DescribeProxyGroupStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发，丢包和时延数据。支持300, 3600和86400的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyStatisticsResponse"/></returns>
        public Task<DescribeProxyStatisticsResponse> DescribeProxyStatistics(DescribeProxyStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyStatisticsResponse>(req, "DescribeProxyStatistics");
        }

        /// <summary>
        /// 该接口用于查询监听器统计数据，包括出入带宽，出入包量，并发，丢包和时延数据。支持300, 3600和86400的细粒度，取值为细粒度范围内最大值。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyStatisticsResponse"/></returns>
        public DescribeProxyStatisticsResponse DescribeProxyStatisticsSync(DescribeProxyStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyStatisticsResponse>(req, "DescribeProxyStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeRealServerStatistics）用于查询源站健康检查结果的统计数据。源站状态展示位为1：正常或者0：异常。查询的源站需要在监听器或者规则上进行了绑定，查询时需指定绑定的监听器或者规则ID。该接口支持1分钟细粒度的源站状态统计数据展示。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRealServerStatisticsResponse"/></returns>
        public Task<DescribeRealServerStatisticsResponse> DescribeRealServerStatistics(DescribeRealServerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRealServerStatisticsResponse>(req, "DescribeRealServerStatistics");
        }

        /// <summary>
        /// 该接口（DescribeRealServerStatistics）用于查询源站健康检查结果的统计数据。源站状态展示位为1：正常或者0：异常。查询的源站需要在监听器或者规则上进行了绑定，查询时需指定绑定的监听器或者规则ID。该接口支持1分钟细粒度的源站状态统计数据展示。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServerStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRealServerStatisticsResponse"/></returns>
        public DescribeRealServerStatisticsResponse DescribeRealServerStatisticsSync(DescribeRealServerStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRealServerStatisticsResponse>(req, "DescribeRealServerStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRealServers）用于查询源站信息，可以根据项目名查询所有的源站信息，此外支持指定IP或者域名的源站模糊查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersRequest"/></param>
        /// <returns><see cref="DescribeRealServersResponse"/></returns>
        public Task<DescribeRealServersResponse> DescribeRealServers(DescribeRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRealServersResponse>(req, "DescribeRealServers");
        }

        /// <summary>
        /// 本接口（DescribeRealServers）用于查询源站信息，可以根据项目名查询所有的源站信息，此外支持指定IP或者域名的源站模糊查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersRequest"/></param>
        /// <returns><see cref="DescribeRealServersResponse"/></returns>
        public DescribeRealServersResponse DescribeRealServersSync(DescribeRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRealServersResponse>(req, "DescribeRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRealServersStatus）用于查询源站是否已被规则或者监听器绑定
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersStatusRequest"/></param>
        /// <returns><see cref="DescribeRealServersStatusResponse"/></returns>
        public Task<DescribeRealServersStatusResponse> DescribeRealServersStatus(DescribeRealServersStatusRequest req)
        {
            return InternalRequestAsync<DescribeRealServersStatusResponse>(req, "DescribeRealServersStatus");
        }

        /// <summary>
        /// 本接口（DescribeRealServersStatus）用于查询源站是否已被规则或者监听器绑定
        /// </summary>
        /// <param name="req"><see cref="DescribeRealServersStatusRequest"/></param>
        /// <returns><see cref="DescribeRealServersStatusResponse"/></returns>
        public DescribeRealServersStatusResponse DescribeRealServersStatusSync(DescribeRealServersStatusRequest req)
        {
            return InternalRequestAsync<DescribeRealServersStatusResponse>(req, "DescribeRealServersStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeRegionAndPrice）用于获取源站区域和带宽梯度价格
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionAndPriceRequest"/></param>
        /// <returns><see cref="DescribeRegionAndPriceResponse"/></returns>
        public Task<DescribeRegionAndPriceResponse> DescribeRegionAndPrice(DescribeRegionAndPriceRequest req)
        {
            return InternalRequestAsync<DescribeRegionAndPriceResponse>(req, "DescribeRegionAndPrice");
        }

        /// <summary>
        /// 该接口（DescribeRegionAndPrice）用于获取源站区域和带宽梯度价格
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionAndPriceRequest"/></param>
        /// <returns><see cref="DescribeRegionAndPriceResponse"/></returns>
        public DescribeRegionAndPriceResponse DescribeRegionAndPriceSync(DescribeRegionAndPriceRequest req)
        {
            return InternalRequestAsync<DescribeRegionAndPriceResponse>(req, "DescribeRegionAndPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeResourcesByTag）用于根据标签来查询对应的资源信息，包括通道，通道组和源站。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagResponse"/></returns>
        public Task<DescribeResourcesByTagResponse> DescribeResourcesByTag(DescribeResourcesByTagRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagResponse>(req, "DescribeResourcesByTag");
        }

        /// <summary>
        /// 本接口（DescribeResourcesByTag）用于根据标签来查询对应的资源信息，包括通道，通道组和源站。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagResponse"/></returns>
        public DescribeResourcesByTagResponse DescribeResourcesByTagSync(DescribeResourcesByTagRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagResponse>(req, "DescribeResourcesByTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRuleRealServers）用于查询转发规则相关的源站信息， 包括该规则可绑定的源站信息和已绑定的源站信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRealServersRequest"/></param>
        /// <returns><see cref="DescribeRuleRealServersResponse"/></returns>
        public Task<DescribeRuleRealServersResponse> DescribeRuleRealServers(DescribeRuleRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRuleRealServersResponse>(req, "DescribeRuleRealServers");
        }

        /// <summary>
        /// 本接口（DescribeRuleRealServers）用于查询转发规则相关的源站信息， 包括该规则可绑定的源站信息和已绑定的源站信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRealServersRequest"/></param>
        /// <returns><see cref="DescribeRuleRealServersResponse"/></returns>
        public DescribeRuleRealServersResponse DescribeRuleRealServersSync(DescribeRuleRealServersRequest req)
        {
            return InternalRequestAsync<DescribeRuleRealServersResponse>(req, "DescribeRuleRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRules）用于查询监听器下的所有规则信息，包括规则域名，路径以及该规则下所绑定的源站列表。当通道版本为3.0时，该接口会返回该域名对应的高级认证配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// 本接口（DescribeRules）用于查询监听器下的所有规则信息，包括规则域名，路径以及该规则下所绑定的源站列表。当通道版本为3.0时，该接口会返回该域名对应的高级认证配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeRulesByRuleIds）用于根据规则ID拉取规则信息列表。支持一个或者多个规则信息的拉取。一次最多支持10个规则信息的拉取。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByRuleIdsRequest"/></param>
        /// <returns><see cref="DescribeRulesByRuleIdsResponse"/></returns>
        public Task<DescribeRulesByRuleIdsResponse> DescribeRulesByRuleIds(DescribeRulesByRuleIdsRequest req)
        {
            return InternalRequestAsync<DescribeRulesByRuleIdsResponse>(req, "DescribeRulesByRuleIds");
        }

        /// <summary>
        /// 本接口（DescribeRulesByRuleIds）用于根据规则ID拉取规则信息列表。支持一个或者多个规则信息的拉取。一次最多支持10个规则信息的拉取。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesByRuleIdsRequest"/></param>
        /// <returns><see cref="DescribeRulesByRuleIdsResponse"/></returns>
        public DescribeRulesByRuleIdsResponse DescribeRulesByRuleIdsSync(DescribeRulesByRuleIdsRequest req)
        {
            return InternalRequestAsync<DescribeRulesByRuleIdsResponse>(req, "DescribeRulesByRuleIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取安全策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyDetailResponse"/></returns>
        public Task<DescribeSecurityPolicyDetailResponse> DescribeSecurityPolicyDetail(DescribeSecurityPolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyDetailResponse>(req, "DescribeSecurityPolicyDetail");
        }

        /// <summary>
        /// 获取安全策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyDetailResponse"/></returns>
        public DescribeSecurityPolicyDetailResponse DescribeSecurityPolicyDetailSync(DescribeSecurityPolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyDetailResponse>(req, "DescribeSecurityPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSecurityRules）用于根据安全规则ID查询安全规则详情列表。支持一个或多个安全规则的查询。一次最多支持20个安全规则的查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityRulesResponse"/></returns>
        public Task<DescribeSecurityRulesResponse> DescribeSecurityRules(DescribeSecurityRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRulesResponse>(req, "DescribeSecurityRules");
        }

        /// <summary>
        /// 本接口（DescribeSecurityRules）用于根据安全规则ID查询安全规则详情列表。支持一个或多个安全规则的查询。一次最多支持20个安全规则的查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityRulesResponse"/></returns>
        public DescribeSecurityRulesResponse DescribeSecurityRulesSync(DescribeSecurityRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRulesResponse>(req, "DescribeSecurityRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeTCPListeners）用于查询单通道或者通道组下的TCP监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTCPListenersRequest"/></param>
        /// <returns><see cref="DescribeTCPListenersResponse"/></returns>
        public Task<DescribeTCPListenersResponse> DescribeTCPListeners(DescribeTCPListenersRequest req)
        {
            return InternalRequestAsync<DescribeTCPListenersResponse>(req, "DescribeTCPListeners");
        }

        /// <summary>
        /// 该接口（DescribeTCPListeners）用于查询单通道或者通道组下的TCP监听器信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTCPListenersRequest"/></param>
        /// <returns><see cref="DescribeTCPListenersResponse"/></returns>
        public DescribeTCPListenersResponse DescribeTCPListenersSync(DescribeTCPListenersRequest req)
        {
            return InternalRequestAsync<DescribeTCPListenersResponse>(req, "DescribeTCPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询异步任务执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 查询异步任务执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeUDPListeners）用于查询单通道或者通道组下的UDP监听器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUDPListenersRequest"/></param>
        /// <returns><see cref="DescribeUDPListenersResponse"/></returns>
        public Task<DescribeUDPListenersResponse> DescribeUDPListeners(DescribeUDPListenersRequest req)
        {
            return InternalRequestAsync<DescribeUDPListenersResponse>(req, "DescribeUDPListeners");
        }

        /// <summary>
        /// 该接口（DescribeUDPListeners）用于查询单通道或者通道组下的UDP监听器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUDPListenersRequest"/></param>
        /// <returns><see cref="DescribeUDPListenersResponse"/></returns>
        public DescribeUDPListenersResponse DescribeUDPListenersSync(DescribeUDPListenersRequest req)
        {
            return InternalRequestAsync<DescribeUDPListenersResponse>(req, "DescribeUDPListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DestroyProxies）用于销毁。通道销毁后，不再产生任何费用。
        /// </summary>
        /// <param name="req"><see cref="DestroyProxiesRequest"/></param>
        /// <returns><see cref="DestroyProxiesResponse"/></returns>
        public Task<DestroyProxiesResponse> DestroyProxies(DestroyProxiesRequest req)
        {
            return InternalRequestAsync<DestroyProxiesResponse>(req, "DestroyProxies");
        }

        /// <summary>
        /// 本接口（DestroyProxies）用于销毁。通道销毁后，不再产生任何费用。
        /// </summary>
        /// <param name="req"><see cref="DestroyProxiesRequest"/></param>
        /// <returns><see cref="DestroyProxiesResponse"/></returns>
        public DestroyProxiesResponse DestroyProxiesSync(DestroyProxiesRequest req)
        {
            return InternalRequestAsync<DestroyProxiesResponse>(req, "DestroyProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停域名解析
        /// </summary>
        /// <param name="req"><see cref="DisableGlobalDomainRequest"/></param>
        /// <returns><see cref="DisableGlobalDomainResponse"/></returns>
        public Task<DisableGlobalDomainResponse> DisableGlobalDomain(DisableGlobalDomainRequest req)
        {
            return InternalRequestAsync<DisableGlobalDomainResponse>(req, "DisableGlobalDomain");
        }

        /// <summary>
        /// 暂停域名解析
        /// </summary>
        /// <param name="req"><see cref="DisableGlobalDomainRequest"/></param>
        /// <returns><see cref="DisableGlobalDomainResponse"/></returns>
        public DisableGlobalDomainResponse DisableGlobalDomainSync(DisableGlobalDomainRequest req)
        {
            return InternalRequestAsync<DisableGlobalDomainResponse>(req, "DisableGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启域名解析
        /// </summary>
        /// <param name="req"><see cref="EnableGlobalDomainRequest"/></param>
        /// <returns><see cref="EnableGlobalDomainResponse"/></returns>
        public Task<EnableGlobalDomainResponse> EnableGlobalDomain(EnableGlobalDomainRequest req)
        {
            return InternalRequestAsync<EnableGlobalDomainResponse>(req, "EnableGlobalDomain");
        }

        /// <summary>
        /// 开启域名解析
        /// </summary>
        /// <param name="req"><see cref="EnableGlobalDomainRequest"/></param>
        /// <returns><see cref="EnableGlobalDomainResponse"/></returns>
        public EnableGlobalDomainResponse EnableGlobalDomainSync(EnableGlobalDomainRequest req)
        {
            return InternalRequestAsync<EnableGlobalDomainResponse>(req, "EnableGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateProxy）用于创建加速通道询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateProxyRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateProxyResponse"/></returns>
        public Task<InquiryPriceCreateProxyResponse> InquiryPriceCreateProxy(InquiryPriceCreateProxyRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateProxyResponse>(req, "InquiryPriceCreateProxy");
        }

        /// <summary>
        /// 本接口（InquiryPriceCreateProxy）用于创建加速通道询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateProxyRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateProxyResponse"/></returns>
        public InquiryPriceCreateProxyResponse InquiryPriceCreateProxySync(InquiryPriceCreateProxyRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateProxyResponse>(req, "InquiryPriceCreateProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyCertificate）用于修改监听器下的域名对应的证书。该接口仅适用于version3.0的通道。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateRequest"/></param>
        /// <returns><see cref="ModifyCertificateResponse"/></returns>
        public Task<ModifyCertificateResponse> ModifyCertificate(ModifyCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResponse>(req, "ModifyCertificate");
        }

        /// <summary>
        /// 本接口（ModifyCertificate）用于修改监听器下的域名对应的证书。该接口仅适用于version3.0的通道。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateRequest"/></param>
        /// <returns><see cref="ModifyCertificateResponse"/></returns>
        public ModifyCertificateResponse ModifyCertificateSync(ModifyCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResponse>(req, "ModifyCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyCertificateAttributes）用于修改证书，包括证书名字以及证书内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAttributesRequest"/></param>
        /// <returns><see cref="ModifyCertificateAttributesResponse"/></returns>
        public Task<ModifyCertificateAttributesResponse> ModifyCertificateAttributes(ModifyCertificateAttributesRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAttributesResponse>(req, "ModifyCertificateAttributes");
        }

        /// <summary>
        /// 本接口（ModifyCertificateAttributes）用于修改证书，包括证书名字以及证书内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAttributesRequest"/></param>
        /// <returns><see cref="ModifyCertificateAttributesResponse"/></returns>
        public ModifyCertificateAttributesResponse ModifyCertificateAttributesSync(ModifyCertificateAttributesRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAttributesResponse>(req, "ModifyCertificateAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyDomain）用于监听器下的域名。当通道版本为3.0时，支持对该域名所对应的证书修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain");
        }

        /// <summary>
        /// 本接口（ModifyDomain）用于监听器下的域名。当通道版本为3.0时，支持对该域名所对应的证书修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改域名属性
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainAttributeRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainAttributeResponse"/></returns>
        public Task<ModifyGlobalDomainAttributeResponse> ModifyGlobalDomainAttribute(ModifyGlobalDomainAttributeRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainAttributeResponse>(req, "ModifyGlobalDomainAttribute");
        }

        /// <summary>
        /// 修改域名属性
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainAttributeRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainAttributeResponse"/></returns>
        public ModifyGlobalDomainAttributeResponse ModifyGlobalDomainAttributeSync(ModifyGlobalDomainAttributeRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainAttributeResponse>(req, "ModifyGlobalDomainAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改域名解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainDnsResponse"/></returns>
        public Task<ModifyGlobalDomainDnsResponse> ModifyGlobalDomainDns(ModifyGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainDnsResponse>(req, "ModifyGlobalDomainDns");
        }

        /// <summary>
        /// 修改域名解析记录
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainDnsRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainDnsResponse"/></returns>
        public ModifyGlobalDomainDnsResponse ModifyGlobalDomainDnsSync(ModifyGlobalDomainDnsRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainDnsResponse>(req, "ModifyGlobalDomainDns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyGroupDomainConfig）用于配置通道组就近接入域名。
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyGroupDomainConfigResponse"/></returns>
        public Task<ModifyGroupDomainConfigResponse> ModifyGroupDomainConfig(ModifyGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyGroupDomainConfigResponse>(req, "ModifyGroupDomainConfig");
        }

        /// <summary>
        /// 本接口（ModifyGroupDomainConfig）用于配置通道组就近接入域名。
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupDomainConfigRequest"/></param>
        /// <returns><see cref="ModifyGroupDomainConfigResponse"/></returns>
        public ModifyGroupDomainConfigResponse ModifyGroupDomainConfigSync(ModifyGroupDomainConfigRequest req)
        {
            return InternalRequestAsync<ModifyGroupDomainConfigResponse>(req, "ModifyGroupDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（ModifyHTTPListenerAttribute）用于修改通道的HTTP监听器配置信息，目前仅支持修改监听器的名称。
        /// 注意：通道组通道暂时不支持HTTP/HTTPS监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPListenerAttributeResponse"/></returns>
        public Task<ModifyHTTPListenerAttributeResponse> ModifyHTTPListenerAttribute(ModifyHTTPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPListenerAttributeResponse>(req, "ModifyHTTPListenerAttribute");
        }

        /// <summary>
        /// 该接口（ModifyHTTPListenerAttribute）用于修改通道的HTTP监听器配置信息，目前仅支持修改监听器的名称。
        /// 注意：通道组通道暂时不支持HTTP/HTTPS监听器。
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPListenerAttributeResponse"/></returns>
        public ModifyHTTPListenerAttributeResponse ModifyHTTPListenerAttributeSync(ModifyHTTPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPListenerAttributeResponse>(req, "ModifyHTTPListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（ModifyHTTPSListenerAttribute）用于修改HTTPS监听器配置，当前不支持通道组和v1版本通道。
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPSListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPSListenerAttributeResponse"/></returns>
        public Task<ModifyHTTPSListenerAttributeResponse> ModifyHTTPSListenerAttribute(ModifyHTTPSListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPSListenerAttributeResponse>(req, "ModifyHTTPSListenerAttribute");
        }

        /// <summary>
        /// 该接口（ModifyHTTPSListenerAttribute）用于修改HTTPS监听器配置，当前不支持通道组和v1版本通道。
        /// </summary>
        /// <param name="req"><see cref="ModifyHTTPSListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyHTTPSListenerAttributeResponse"/></returns>
        public ModifyHTTPSListenerAttributeResponse ModifyHTTPSListenerAttributeSync(ModifyHTTPSListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHTTPSListenerAttributeResponse>(req, "ModifyHTTPSListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyProxiesAttribute）用于修改实例的属性（目前只支持修改通道的名称）。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxiesAttributeResponse"/></returns>
        public Task<ModifyProxiesAttributeResponse> ModifyProxiesAttribute(ModifyProxiesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxiesAttributeResponse>(req, "ModifyProxiesAttribute");
        }

        /// <summary>
        /// 本接口（ModifyProxiesAttribute）用于修改实例的属性（目前只支持修改通道的名称）。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxiesAttributeResponse"/></returns>
        public ModifyProxiesAttributeResponse ModifyProxiesAttributeSync(ModifyProxiesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxiesAttributeResponse>(req, "ModifyProxiesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyProxiesProject）用于修改通道所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesProjectRequest"/></param>
        /// <returns><see cref="ModifyProxiesProjectResponse"/></returns>
        public Task<ModifyProxiesProjectResponse> ModifyProxiesProject(ModifyProxiesProjectRequest req)
        {
            return InternalRequestAsync<ModifyProxiesProjectResponse>(req, "ModifyProxiesProject");
        }

        /// <summary>
        /// 本接口（ModifyProxiesProject）用于修改通道所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxiesProjectRequest"/></param>
        /// <returns><see cref="ModifyProxiesProjectResponse"/></returns>
        public ModifyProxiesProjectResponse ModifyProxiesProjectSync(ModifyProxiesProjectRequest req)
        {
            return InternalRequestAsync<ModifyProxiesProjectResponse>(req, "ModifyProxiesProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyProxyConfiguration）用于修改通道的配置。根据当前业务的容量需求，扩容或缩容相关通道的配置。仅支持Scalarable为1的通道,Scalarable可通过接口DescribeProxies获取。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyConfigurationRequest"/></param>
        /// <returns><see cref="ModifyProxyConfigurationResponse"/></returns>
        public Task<ModifyProxyConfigurationResponse> ModifyProxyConfiguration(ModifyProxyConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyProxyConfigurationResponse>(req, "ModifyProxyConfiguration");
        }

        /// <summary>
        /// 本接口（ModifyProxyConfiguration）用于修改通道的配置。根据当前业务的容量需求，扩容或缩容相关通道的配置。仅支持Scalarable为1的通道,Scalarable可通过接口DescribeProxies获取。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyConfigurationRequest"/></param>
        /// <returns><see cref="ModifyProxyConfigurationResponse"/></returns>
        public ModifyProxyConfigurationResponse ModifyProxyConfigurationSync(ModifyProxyConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyProxyConfigurationResponse>(req, "ModifyProxyConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyProxyGroupAttribute）用于修改通道组属性，目前仅支持修改通道组名称与项目ID。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxyGroupAttributeResponse"/></returns>
        public Task<ModifyProxyGroupAttributeResponse> ModifyProxyGroupAttribute(ModifyProxyGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxyGroupAttributeResponse>(req, "ModifyProxyGroupAttribute");
        }

        /// <summary>
        /// 本接口（ModifyProxyGroupAttribute）用于修改通道组属性，目前仅支持修改通道组名称与项目ID。
        /// </summary>
        /// <param name="req"><see cref="ModifyProxyGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyProxyGroupAttributeResponse"/></returns>
        public ModifyProxyGroupAttributeResponse ModifyProxyGroupAttributeSync(ModifyProxyGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyProxyGroupAttributeResponse>(req, "ModifyProxyGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyRealServerName）用于修改源站的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerNameRequest"/></param>
        /// <returns><see cref="ModifyRealServerNameResponse"/></returns>
        public Task<ModifyRealServerNameResponse> ModifyRealServerName(ModifyRealServerNameRequest req)
        {
            return InternalRequestAsync<ModifyRealServerNameResponse>(req, "ModifyRealServerName");
        }

        /// <summary>
        /// 本接口（ModifyRealServerName）用于修改源站的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyRealServerNameRequest"/></param>
        /// <returns><see cref="ModifyRealServerNameResponse"/></returns>
        public ModifyRealServerNameResponse ModifyRealServerNameSync(ModifyRealServerNameRequest req)
        {
            return InternalRequestAsync<ModifyRealServerNameResponse>(req, "ModifyRealServerName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyRuleAttribute）用于修改转发规则的信息，包括健康检查的配置以及转发策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleAttributeRequest"/></param>
        /// <returns><see cref="ModifyRuleAttributeResponse"/></returns>
        public Task<ModifyRuleAttributeResponse> ModifyRuleAttribute(ModifyRuleAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRuleAttributeResponse>(req, "ModifyRuleAttribute");
        }

        /// <summary>
        /// 本接口（ModifyRuleAttribute）用于修改转发规则的信息，包括健康检查的配置以及转发策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleAttributeRequest"/></param>
        /// <returns><see cref="ModifyRuleAttributeResponse"/></returns>
        public ModifyRuleAttributeResponse ModifyRuleAttributeSync(ModifyRuleAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRuleAttributeResponse>(req, "ModifyRuleAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安全策略规则名
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityRuleResponse"/></returns>
        public Task<ModifySecurityRuleResponse> ModifySecurityRule(ModifySecurityRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityRuleResponse>(req, "ModifySecurityRule");
        }

        /// <summary>
        /// 修改安全策略规则名
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityRuleResponse"/></returns>
        public ModifySecurityRuleResponse ModifySecurityRuleSync(ModifySecurityRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityRuleResponse>(req, "ModifySecurityRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyTCPListenerAttribute）用于修改通道实例下TCP监听器配置，包括健康检查的配置，调度策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyTCPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyTCPListenerAttributeResponse"/></returns>
        public Task<ModifyTCPListenerAttributeResponse> ModifyTCPListenerAttribute(ModifyTCPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTCPListenerAttributeResponse>(req, "ModifyTCPListenerAttribute");
        }

        /// <summary>
        /// 本接口（ModifyTCPListenerAttribute）用于修改通道实例下TCP监听器配置，包括健康检查的配置，调度策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyTCPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyTCPListenerAttributeResponse"/></returns>
        public ModifyTCPListenerAttributeResponse ModifyTCPListenerAttributeSync(ModifyTCPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTCPListenerAttributeResponse>(req, "ModifyTCPListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyUDPListenerAttribute）用于修改通道实例下UDP监听器配置，包括监听器名称和调度策略的修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyUDPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyUDPListenerAttributeResponse"/></returns>
        public Task<ModifyUDPListenerAttributeResponse> ModifyUDPListenerAttribute(ModifyUDPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyUDPListenerAttributeResponse>(req, "ModifyUDPListenerAttribute");
        }

        /// <summary>
        /// 本接口（ModifyUDPListenerAttribute）用于修改通道实例下UDP监听器配置，包括监听器名称和调度策略的修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyUDPListenerAttributeRequest"/></param>
        /// <returns><see cref="ModifyUDPListenerAttributeResponse"/></returns>
        public ModifyUDPListenerAttributeResponse ModifyUDPListenerAttributeSync(ModifyUDPListenerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyUDPListenerAttributeResponse>(req, "ModifyUDPListenerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（OpenProxies）用于开启一条或者多条通道。
        /// </summary>
        /// <param name="req"><see cref="OpenProxiesRequest"/></param>
        /// <returns><see cref="OpenProxiesResponse"/></returns>
        public Task<OpenProxiesResponse> OpenProxies(OpenProxiesRequest req)
        {
            return InternalRequestAsync<OpenProxiesResponse>(req, "OpenProxies");
        }

        /// <summary>
        /// 该接口（OpenProxies）用于开启一条或者多条通道。
        /// </summary>
        /// <param name="req"><see cref="OpenProxiesRequest"/></param>
        /// <returns><see cref="OpenProxiesResponse"/></returns>
        public OpenProxiesResponse OpenProxiesSync(OpenProxiesRequest req)
        {
            return InternalRequestAsync<OpenProxiesResponse>(req, "OpenProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（OpenProxyGroup）用于开启一条通道组中的所有通道
        /// </summary>
        /// <param name="req"><see cref="OpenProxyGroupRequest"/></param>
        /// <returns><see cref="OpenProxyGroupResponse"/></returns>
        public Task<OpenProxyGroupResponse> OpenProxyGroup(OpenProxyGroupRequest req)
        {
            return InternalRequestAsync<OpenProxyGroupResponse>(req, "OpenProxyGroup");
        }

        /// <summary>
        /// 该接口（OpenProxyGroup）用于开启一条通道组中的所有通道
        /// </summary>
        /// <param name="req"><see cref="OpenProxyGroupRequest"/></param>
        /// <returns><see cref="OpenProxyGroupResponse"/></returns>
        public OpenProxyGroupResponse OpenProxyGroupSync(OpenProxyGroupRequest req)
        {
            return InternalRequestAsync<OpenProxyGroupResponse>(req, "OpenProxyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启安全策略
        /// </summary>
        /// <param name="req"><see cref="OpenSecurityPolicyRequest"/></param>
        /// <returns><see cref="OpenSecurityPolicyResponse"/></returns>
        public Task<OpenSecurityPolicyResponse> OpenSecurityPolicy(OpenSecurityPolicyRequest req)
        {
            return InternalRequestAsync<OpenSecurityPolicyResponse>(req, "OpenSecurityPolicy");
        }

        /// <summary>
        /// 开启安全策略
        /// </summary>
        /// <param name="req"><see cref="OpenSecurityPolicyRequest"/></param>
        /// <returns><see cref="OpenSecurityPolicyResponse"/></returns>
        public OpenSecurityPolicyResponse OpenSecurityPolicySync(OpenSecurityPolicyRequest req)
        {
            return InternalRequestAsync<OpenSecurityPolicyResponse>(req, "OpenSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已添加的源站(服务器)IP或域名
        /// </summary>
        /// <param name="req"><see cref="RemoveRealServersRequest"/></param>
        /// <returns><see cref="RemoveRealServersResponse"/></returns>
        public Task<RemoveRealServersResponse> RemoveRealServers(RemoveRealServersRequest req)
        {
            return InternalRequestAsync<RemoveRealServersResponse>(req, "RemoveRealServers");
        }

        /// <summary>
        /// 删除已添加的源站(服务器)IP或域名
        /// </summary>
        /// <param name="req"><see cref="RemoveRealServersRequest"/></param>
        /// <returns><see cref="RemoveRealServersResponse"/></returns>
        public RemoveRealServersResponse RemoveRealServersSync(RemoveRealServersRequest req)
        {
            return InternalRequestAsync<RemoveRealServersResponse>(req, "RemoveRealServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SetAuthentication）用于通道的高级认证配置，包括认证方式选择，以及各种认证方式对应的证书选择。仅支持Version3.0的通道。
        /// </summary>
        /// <param name="req"><see cref="SetAuthenticationRequest"/></param>
        /// <returns><see cref="SetAuthenticationResponse"/></returns>
        public Task<SetAuthenticationResponse> SetAuthentication(SetAuthenticationRequest req)
        {
            return InternalRequestAsync<SetAuthenticationResponse>(req, "SetAuthentication");
        }

        /// <summary>
        /// 本接口（SetAuthentication）用于通道的高级认证配置，包括认证方式选择，以及各种认证方式对应的证书选择。仅支持Version3.0的通道。
        /// </summary>
        /// <param name="req"><see cref="SetAuthenticationRequest"/></param>
        /// <returns><see cref="SetAuthenticationResponse"/></returns>
        public SetAuthenticationResponse SetAuthenticationSync(SetAuthenticationRequest req)
        {
            return InternalRequestAsync<SetAuthenticationResponse>(req, "SetAuthentication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置监听器TLS配置
        /// </summary>
        /// <param name="req"><see cref="SetTlsVersionRequest"/></param>
        /// <returns><see cref="SetTlsVersionResponse"/></returns>
        public Task<SetTlsVersionResponse> SetTlsVersion(SetTlsVersionRequest req)
        {
            return InternalRequestAsync<SetTlsVersionResponse>(req, "SetTlsVersion");
        }

        /// <summary>
        /// 设置监听器TLS配置
        /// </summary>
        /// <param name="req"><see cref="SetTlsVersionRequest"/></param>
        /// <returns><see cref="SetTlsVersionResponse"/></returns>
        public SetTlsVersionResponse SetTlsVersionSync(SetTlsVersionRequest req)
        {
            return InternalRequestAsync<SetTlsVersionResponse>(req, "SetTlsVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
