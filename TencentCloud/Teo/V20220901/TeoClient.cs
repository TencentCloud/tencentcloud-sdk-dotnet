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

namespace TencentCloud.Teo.V20220901
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Teo.V20220901.Models;

   public class TeoClient : AbstractClient{

       private const string endpoint = "teo.tencentcloudapi.com";
       private const string version = "2022-09-01";
       private const string sdkVersion = "SDK_NET_3.0.1315";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TeoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TeoClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 操作安全策略模板，支持将域名绑定或换绑到指定的策略模板，或者从指定的策略模板解绑。
        /// </summary>
        /// <param name="req"><see cref="BindSecurityTemplateToEntityRequest"/></param>
        /// <returns><see cref="BindSecurityTemplateToEntityResponse"/></returns>
        public Task<BindSecurityTemplateToEntityResponse> BindSecurityTemplateToEntity(BindSecurityTemplateToEntityRequest req)
        {
            return InternalRequestAsync<BindSecurityTemplateToEntityResponse>(req, "BindSecurityTemplateToEntity");
        }

        /// <summary>
        /// 操作安全策略模板，支持将域名绑定或换绑到指定的策略模板，或者从指定的策略模板解绑。
        /// </summary>
        /// <param name="req"><see cref="BindSecurityTemplateToEntityRequest"/></param>
        /// <returns><see cref="BindSecurityTemplateToEntityResponse"/></returns>
        public BindSecurityTemplateToEntityResponse BindSecurityTemplateToEntitySync(BindSecurityTemplateToEntityRequest req)
        {
            return InternalRequestAsync<BindSecurityTemplateToEntityResponse>(req, "BindSecurityTemplateToEntity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于加速域名绑定或解绑共享 CNAME，该功能白名单内测中。
        /// </summary>
        /// <param name="req"><see cref="BindSharedCNAMERequest"/></param>
        /// <returns><see cref="BindSharedCNAMEResponse"/></returns>
        public Task<BindSharedCNAMEResponse> BindSharedCNAME(BindSharedCNAMERequest req)
        {
            return InternalRequestAsync<BindSharedCNAMEResponse>(req, "BindSharedCNAME");
        }

        /// <summary>
        /// 用于加速域名绑定或解绑共享 CNAME，该功能白名单内测中。
        /// </summary>
        /// <param name="req"><see cref="BindSharedCNAMERequest"/></param>
        /// <returns><see cref="BindSharedCNAMEResponse"/></returns>
        public BindSharedCNAMEResponse BindSharedCNAMESync(BindSharedCNAMERequest req)
        {
            return InternalRequestAsync<BindSharedCNAMEResponse>(req, "BindSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将未绑定套餐的站点绑定到已有套餐
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public Task<BindZoneToPlanResponse> BindZoneToPlan(BindZoneToPlanRequest req)
        {
            return InternalRequestAsync<BindZoneToPlanResponse>(req, "BindZoneToPlan");
        }

        /// <summary>
        /// 将未绑定套餐的站点绑定到已有套餐
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public BindZoneToPlanResponse BindZoneToPlanSync(BindZoneToPlanRequest req)
        {
            return InternalRequestAsync<BindZoneToPlanResponse>(req, "BindZoneToPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 校验域名 CNAME 状态
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public Task<CheckCnameStatusResponse> CheckCnameStatus(CheckCnameStatusRequest req)
        {
            return InternalRequestAsync<CheckCnameStatusResponse>(req, "CheckCnameStatus");
        }

        /// <summary>
        /// 校验域名 CNAME 状态
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public CheckCnameStatusResponse CheckCnameStatusSync(CheckCnameStatusRequest req)
        {
            return InternalRequestAsync<CheckCnameStatusResponse>(req, "CheckCnameStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于回源 IP 网段发生变更时，确认已将最新回源 IP 网段更新至源站防火墙。确认已更新至最新的回源 IP 网段后，相关变更通知将会停止推送。
        /// </summary>
        /// <param name="req"><see cref="ConfirmOriginACLUpdateRequest"/></param>
        /// <returns><see cref="ConfirmOriginACLUpdateResponse"/></returns>
        public Task<ConfirmOriginACLUpdateResponse> ConfirmOriginACLUpdate(ConfirmOriginACLUpdateRequest req)
        {
            return InternalRequestAsync<ConfirmOriginACLUpdateResponse>(req, "ConfirmOriginACLUpdate");
        }

        /// <summary>
        /// 本接口用于回源 IP 网段发生变更时，确认已将最新回源 IP 网段更新至源站防火墙。确认已更新至最新的回源 IP 网段后，相关变更通知将会停止推送。
        /// </summary>
        /// <param name="req"><see cref="ConfirmOriginACLUpdateRequest"/></param>
        /// <returns><see cref="ConfirmOriginACLUpdateResponse"/></returns>
        public ConfirmOriginACLUpdateResponse ConfirmOriginACLUpdateSync(ConfirmOriginACLUpdateRequest req)
        {
            return InternalRequestAsync<ConfirmOriginACLUpdateResponse>(req, "ConfirmOriginACLUpdate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在创建完站点之后，您可以通过本接口创建加速域名。 
        /// 
        /// CNAME 模式接入时，若您未完成站点归属权校验，本接口将为您返回域名归属权验证信息，您可以单独对域名进行归属权验证，详情参考 [站点/域名归属权验证](https://cloud.tencent.com/document/product/1552/70789)。
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerationDomainRequest"/></param>
        /// <returns><see cref="CreateAccelerationDomainResponse"/></returns>
        public Task<CreateAccelerationDomainResponse> CreateAccelerationDomain(CreateAccelerationDomainRequest req)
        {
            return InternalRequestAsync<CreateAccelerationDomainResponse>(req, "CreateAccelerationDomain");
        }

        /// <summary>
        /// 在创建完站点之后，您可以通过本接口创建加速域名。 
        /// 
        /// CNAME 模式接入时，若您未完成站点归属权校验，本接口将为您返回域名归属权验证信息，您可以单独对域名进行归属权验证，详情参考 [站点/域名归属权验证](https://cloud.tencent.com/document/product/1552/70789)。
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerationDomainRequest"/></param>
        /// <returns><see cref="CreateAccelerationDomainResponse"/></returns>
        public CreateAccelerationDomainResponse CreateAccelerationDomainSync(CreateAccelerationDomainRequest req)
        {
            return InternalRequestAsync<CreateAccelerationDomainResponse>(req, "CreateAccelerationDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建别称域名。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public Task<CreateAliasDomainResponse> CreateAliasDomain(CreateAliasDomainRequest req)
        {
            return InternalRequestAsync<CreateAliasDomainResponse>(req, "CreateAliasDomain");
        }

        /// <summary>
        /// 创建别称域名。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public CreateAliasDomainResponse CreateAliasDomainSync(CreateAliasDomainRequest req)
        {
            return InternalRequestAsync<CreateAliasDomainResponse>(req, "CreateAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版 [创建四层代理实例](https://cloud.tencent.com/document/product/1552/103417) 。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public Task<CreateApplicationProxyResponse> CreateApplicationProxy(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版 [创建四层代理实例](https://cloud.tencent.com/document/product/1552/103417) 。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public CreateApplicationProxyResponse CreateApplicationProxySync(CreateApplicationProxyRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyResponse>(req, "CreateApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [创建四层代理转发规则
        /// ](https://cloud.tencent.com/document/product/1552/103416) 。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public Task<CreateApplicationProxyRuleResponse> CreateApplicationProxyRule(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [创建四层代理转发规则
        /// ](https://cloud.tencent.com/document/product/1552/103416) 。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public CreateApplicationProxyRuleResponse CreateApplicationProxyRuleSync(CreateApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<CreateApplicationProxyRuleResponse>(req, "CreateApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对指定实时日志投递任务（task-id），在对应的腾讯云 CLS 日志主题中创建投递日志字段对应的键值索引。如果您在腾讯云 CLS 已经创建索引，本接口将采用合并的方式追加索引。
        /// </summary>
        /// <param name="req"><see cref="CreateCLSIndexRequest"/></param>
        /// <returns><see cref="CreateCLSIndexResponse"/></returns>
        public Task<CreateCLSIndexResponse> CreateCLSIndex(CreateCLSIndexRequest req)
        {
            return InternalRequestAsync<CreateCLSIndexResponse>(req, "CreateCLSIndex");
        }

        /// <summary>
        /// 针对指定实时日志投递任务（task-id），在对应的腾讯云 CLS 日志主题中创建投递日志字段对应的键值索引。如果您在腾讯云 CLS 已经创建索引，本接口将采用合并的方式追加索引。
        /// </summary>
        /// <param name="req"><see cref="CreateCLSIndexRequest"/></param>
        /// <returns><see cref="CreateCLSIndexResponse"/></returns>
        public CreateCLSIndexResponse CreateCLSIndexSync(CreateCLSIndexRequest req)
        {
            return InternalRequestAsync<CreateCLSIndexResponse>(req, "CreateCLSIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在版本管理模式下，用于创建指定配置组的新版本。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="CreateConfigGroupVersionRequest"/></param>
        /// <returns><see cref="CreateConfigGroupVersionResponse"/></returns>
        public Task<CreateConfigGroupVersionResponse> CreateConfigGroupVersion(CreateConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<CreateConfigGroupVersionResponse>(req, "CreateConfigGroupVersion");
        }

        /// <summary>
        /// 在版本管理模式下，用于创建指定配置组的新版本。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="CreateConfigGroupVersionRequest"/></param>
        /// <returns><see cref="CreateConfigGroupVersionResponse"/></returns>
        public CreateConfigGroupVersionResponse CreateConfigGroupVersionSync(CreateConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<CreateConfigGroupVersionResponse>(req, "CreateConfigGroupVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建内容标识符，可以设置描述、标签等信息，同时需要绑定企业版套餐用于统计计费数据；一个内容标识符只能绑定一个计费套餐，一个计费套餐可以绑定多个内容标识符。该功能仅限白名单开放。
        /// </summary>
        /// <param name="req"><see cref="CreateContentIdentifierRequest"/></param>
        /// <returns><see cref="CreateContentIdentifierResponse"/></returns>
        public Task<CreateContentIdentifierResponse> CreateContentIdentifier(CreateContentIdentifierRequest req)
        {
            return InternalRequestAsync<CreateContentIdentifierResponse>(req, "CreateContentIdentifier");
        }

        /// <summary>
        /// 创建内容标识符，可以设置描述、标签等信息，同时需要绑定企业版套餐用于统计计费数据；一个内容标识符只能绑定一个计费套餐，一个计费套餐可以绑定多个内容标识符。该功能仅限白名单开放。
        /// </summary>
        /// <param name="req"><see cref="CreateContentIdentifierRequest"/></param>
        /// <returns><see cref="CreateContentIdentifierResponse"/></returns>
        public CreateContentIdentifierResponse CreateContentIdentifierSync(CreateContentIdentifierRequest req)
        {
            return InternalRequestAsync<CreateContentIdentifierResponse>(req, "CreateContentIdentifier")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义错误页面。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizeErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomizeErrorPageResponse"/></returns>
        public Task<CreateCustomizeErrorPageResponse> CreateCustomizeErrorPage(CreateCustomizeErrorPageRequest req)
        {
            return InternalRequestAsync<CreateCustomizeErrorPageResponse>(req, "CreateCustomizeErrorPage");
        }

        /// <summary>
        /// 创建自定义错误页面。
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizeErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomizeErrorPageResponse"/></returns>
        public CreateCustomizeErrorPageResponse CreateCustomizeErrorPageSync(CreateCustomizeErrorPageRequest req)
        {
            return InternalRequestAsync<CreateCustomizeErrorPageResponse>(req, "CreateCustomizeErrorPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在创建完站点后，并且站点为 NS 模式接入时，您可以通过本接口创建 DNS 记录。
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public Task<CreateDnsRecordResponse> CreateDnsRecord(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord");
        }

        /// <summary>
        /// 在创建完站点后，并且站点为 NS 模式接入时，您可以通过本接口创建 DNS 记录。
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public CreateDnsRecordResponse CreateDnsRecordSync(CreateDnsRecordRequest req)
        {
            return InternalRequestAsync<CreateDnsRecordResponse>(req, "CreateDnsRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建并部署边缘函数至 EdgeOne 的边缘节点。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public Task<CreateFunctionResponse> CreateFunction(CreateFunctionRequest req)
        {
            return InternalRequestAsync<CreateFunctionResponse>(req, "CreateFunction");
        }

        /// <summary>
        /// 创建并部署边缘函数至 EdgeOne 的边缘节点。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public CreateFunctionResponse CreateFunctionSync(CreateFunctionRequest req)
        {
            return InternalRequestAsync<CreateFunctionResponse>(req, "CreateFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建边缘函数的触发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRuleRequest"/></param>
        /// <returns><see cref="CreateFunctionRuleResponse"/></returns>
        public Task<CreateFunctionRuleResponse> CreateFunctionRule(CreateFunctionRuleRequest req)
        {
            return InternalRequestAsync<CreateFunctionRuleResponse>(req, "CreateFunctionRule");
        }

        /// <summary>
        /// 创建边缘函数的触发规则。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRuleRequest"/></param>
        /// <returns><see cref="CreateFunctionRuleResponse"/></returns>
        public CreateFunctionRuleResponse CreateFunctionRuleSync(CreateFunctionRuleRequest req)
        {
            return InternalRequestAsync<CreateFunctionRuleResponse>(req, "CreateFunctionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即时转码已经提供了预置转码模板，满足大部分的需求。如果有个性化的转码需求，可以通过本接口创建自定义的转码模板，最多可创建100个自定义转码模板。
        /// 为了确保即时转码效果的一致性，避免因 EO 缓存或 M3U8 分片处理过程中的模板变更导致视频输出异常，模板在创建后不可进行修改。
        /// 即时转码详细能力了解：[EdgeOne视频即时处理功能介绍](https://cloud.tencent.com/document/product/1552/111927)。
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public Task<CreateJustInTimeTranscodeTemplateResponse> CreateJustInTimeTranscodeTemplate(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate");
        }

        /// <summary>
        /// 即时转码已经提供了预置转码模板，满足大部分的需求。如果有个性化的转码需求，可以通过本接口创建自定义的转码模板，最多可创建100个自定义转码模板。
        /// 为了确保即时转码效果的一致性，避免因 EO 缓存或 M3U8 分片处理过程中的模板变更导致视频输出异常，模板在创建后不可进行修改。
        /// 即时转码详细能力了解：[EdgeOne视频即时处理功能介绍](https://cloud.tencent.com/document/product/1552/111927)。
        /// </summary>
        /// <param name="req"><see cref="CreateJustInTimeTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateJustInTimeTranscodeTemplateResponse"/></returns>
        public CreateJustInTimeTranscodeTemplateResponse CreateJustInTimeTranscodeTemplateSync(CreateJustInTimeTranscodeTemplateRequest req)
        {
            return InternalRequestAsync<CreateJustInTimeTranscodeTemplateResponse>(req, "CreateJustInTimeTranscodeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建四层代理实例。
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRequest"/></param>
        /// <returns><see cref="CreateL4ProxyResponse"/></returns>
        public Task<CreateL4ProxyResponse> CreateL4Proxy(CreateL4ProxyRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyResponse>(req, "CreateL4Proxy");
        }

        /// <summary>
        /// 用于创建四层代理实例。
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRequest"/></param>
        /// <returns><see cref="CreateL4ProxyResponse"/></returns>
        public CreateL4ProxyResponse CreateL4ProxySync(CreateL4ProxyRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyResponse>(req, "CreateL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建四层代理实例规则，支持单条或者批量创建。
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRulesRequest"/></param>
        /// <returns><see cref="CreateL4ProxyRulesResponse"/></returns>
        public Task<CreateL4ProxyRulesResponse> CreateL4ProxyRules(CreateL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyRulesResponse>(req, "CreateL4ProxyRules");
        }

        /// <summary>
        /// 用于创建四层代理实例规则，支持单条或者批量创建。
        /// </summary>
        /// <param name="req"><see cref="CreateL4ProxyRulesRequest"/></param>
        /// <returns><see cref="CreateL4ProxyRulesResponse"/></returns>
        public CreateL4ProxyRulesResponse CreateL4ProxyRulesSync(CreateL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<CreateL4ProxyRulesResponse>(req, "CreateL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于在[规则引擎](https://cloud.tencent.com/document/product/1552/70901)中创建规则，支持批量创建。
        /// </summary>
        /// <param name="req"><see cref="CreateL7AccRulesRequest"/></param>
        /// <returns><see cref="CreateL7AccRulesResponse"/></returns>
        public Task<CreateL7AccRulesResponse> CreateL7AccRules(CreateL7AccRulesRequest req)
        {
            return InternalRequestAsync<CreateL7AccRulesResponse>(req, "CreateL7AccRules");
        }

        /// <summary>
        /// 本接口用于在[规则引擎](https://cloud.tencent.com/document/product/1552/70901)中创建规则，支持批量创建。
        /// </summary>
        /// <param name="req"><see cref="CreateL7AccRulesRequest"/></param>
        /// <returns><see cref="CreateL7AccRulesResponse"/></returns>
        public CreateL7AccRulesResponse CreateL7AccRulesSync(CreateL7AccRulesRequest req)
        {
            return InternalRequestAsync<CreateL7AccRulesResponse>(req, "CreateL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建负载均衡实例。详情请参考 [快速创建负载均衡实例](https://cloud.tencent.com/document/product/1552/104223)。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// 创建负载均衡实例。详情请参考 [快速创建负载均衡实例](https://cloud.tencent.com/document/product/1552/104223)。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口创建多通道安全加速网关，包括云上网关（腾讯云创建和管理的网关）和自有网关（用户部署的私有网关），需要通过接口 DescribeMultiPathGateway，查询状态为 online 即创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayResponse"/></returns>
        public Task<CreateMultiPathGatewayResponse> CreateMultiPathGateway(CreateMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayResponse>(req, "CreateMultiPathGateway");
        }

        /// <summary>
        /// 通过本接口创建多通道安全加速网关，包括云上网关（腾讯云创建和管理的网关）和自有网关（用户部署的私有网关），需要通过接口 DescribeMultiPathGateway，查询状态为 online 即创建成功。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayResponse"/></returns>
        public CreateMultiPathGatewayResponse CreateMultiPathGatewaySync(CreateMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayResponse>(req, "CreateMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口创建接入多通道安全加速网关的线路。包括 EdgeOne 四层代理线路、自定义线路。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayLineResponse"/></returns>
        public Task<CreateMultiPathGatewayLineResponse> CreateMultiPathGatewayLine(CreateMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayLineResponse>(req, "CreateMultiPathGatewayLine");
        }

        /// <summary>
        /// 通过本接口创建接入多通道安全加速网关的线路。包括 EdgeOne 四层代理线路、自定义线路。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewayLineResponse"/></returns>
        public CreateMultiPathGatewayLineResponse CreateMultiPathGatewayLineSync(CreateMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewayLineResponse>(req, "CreateMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口创建接入多通道安全加速网关的密钥，客户基于接入密钥签名接入多通道安全加速网关。每个站点下只有一个密钥，可用于接入该站点下的所有网关，可通过接口 DescribeMultiPathGatewaySecretKey 查询。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<CreateMultiPathGatewaySecretKeyResponse> CreateMultiPathGatewaySecretKey(CreateMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewaySecretKeyResponse>(req, "CreateMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// 通过本接口创建接入多通道安全加速网关的密钥，客户基于接入密钥签名接入多通道安全加速网关。每个站点下只有一个密钥，可用于接入该站点下的所有网关，可通过接口 DescribeMultiPathGatewaySecretKey 查询。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="CreateMultiPathGatewaySecretKeyResponse"/></returns>
        public CreateMultiPathGatewaySecretKeyResponse CreateMultiPathGatewaySecretKeySync(CreateMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<CreateMultiPathGatewaySecretKeyResponse>(req, "CreateMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建源站组，以源站组的方式管理业务源站。此处配置的源站组可于**添加加速域名**和**四层代理**等功能中引用。
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public Task<CreateOriginGroupResponse> CreateOriginGroup(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup");
        }

        /// <summary>
        /// 创建源站组，以源站组的方式管理业务源站。此处配置的源站组可于**添加加速域名**和**四层代理**等功能中引用。
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public CreateOriginGroupResponse CreateOriginGroupSync(CreateOriginGroupRequest req)
        {
            return InternalRequestAsync<CreateOriginGroupResponse>(req, "CreateOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 若您需要使用 Edgeone 产品，您需要通过此接口创建计费套餐。
        /// > 创建套餐后，您需要通过 [CreateZone](https://cloud.tencent.com/document/product/1552/80719) 完成创建站点，绑定套餐的流程，Edgeone 才能正常提供服务。
        /// </summary>
        /// <param name="req"><see cref="CreatePlanRequest"/></param>
        /// <returns><see cref="CreatePlanResponse"/></returns>
        public Task<CreatePlanResponse> CreatePlan(CreatePlanRequest req)
        {
            return InternalRequestAsync<CreatePlanResponse>(req, "CreatePlan");
        }

        /// <summary>
        /// 若您需要使用 Edgeone 产品，您需要通过此接口创建计费套餐。
        /// > 创建套餐后，您需要通过 [CreateZone](https://cloud.tencent.com/document/product/1552/80719) 完成创建站点，绑定套餐的流程，Edgeone 才能正常提供服务。
        /// </summary>
        /// <param name="req"><see cref="CreatePlanRequest"/></param>
        /// <returns><see cref="CreatePlanResponse"/></returns>
        public CreatePlanResponse CreatePlanSync(CreatePlanRequest req)
        {
            return InternalRequestAsync<CreatePlanResponse>(req, "CreatePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为未购买套餐的站点购买套餐
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public Task<CreatePlanForZoneResponse> CreatePlanForZone(CreatePlanForZoneRequest req)
        {
            return InternalRequestAsync<CreatePlanForZoneResponse>(req, "CreatePlanForZone");
        }

        /// <summary>
        /// 为未购买套餐的站点购买套餐
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public CreatePlanForZoneResponse CreatePlanForZoneSync(CreatePlanForZoneRequest req)
        {
            return InternalRequestAsync<CreatePlanForZoneResponse>(req, "CreatePlanForZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public Task<CreatePrefetchTaskResponse> CreatePrefetchTask(CreatePrefetchTaskRequest req)
        {
            return InternalRequestAsync<CreatePrefetchTaskResponse>(req, "CreatePrefetchTask");
        }

        /// <summary>
        /// 创建预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public CreatePrefetchTaskResponse CreatePrefetchTaskSync(CreatePrefetchTaskRequest req)
        {
            return InternalRequestAsync<CreatePrefetchTaskResponse>(req, "CreatePrefetchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当源站资源更新，但节点缓存 TTL 未过期时，用户仍会访问到旧的资源，此时可以通过该接口实现节点资源更新。触发更新的方法有以下两种：<li>直接删除：不做任何校验，直接删除节点缓存，用户请求时触发回源拉取；</li><li>标记过期：将节点资源置为过期，用户请求时触发回源校验，即发送带有 If-None-Match 和 If-Modified-Since 头部的 HTTP 条件请求。若源站响应 200，则节点会回源拉取新的资源并更新缓存；若源站响应 304，则节点不会更新缓存；</li>
        /// 
        /// 清除缓存任务详情请查看[清除缓存](https://cloud.tencent.com/document/product/1552/70759)。
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public Task<CreatePurgeTaskResponse> CreatePurgeTask(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask");
        }

        /// <summary>
        /// 当源站资源更新，但节点缓存 TTL 未过期时，用户仍会访问到旧的资源，此时可以通过该接口实现节点资源更新。触发更新的方法有以下两种：<li>直接删除：不做任何校验，直接删除节点缓存，用户请求时触发回源拉取；</li><li>标记过期：将节点资源置为过期，用户请求时触发回源校验，即发送带有 If-None-Match 和 If-Modified-Since 头部的 HTTP 条件请求。若源站响应 200，则节点会回源拉取新的资源并更新缓存；若源站响应 304，则节点不会更新缓存；</li>
        /// 
        /// 清除缓存任务详情请查看[清除缓存](https://cloud.tencent.com/document/product/1552/70759)。
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public CreatePurgeTaskResponse CreatePurgeTaskSync(CreatePurgeTaskRequest req)
        {
            return InternalRequestAsync<CreatePurgeTaskResponse>(req, "CreatePurgeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建实时日志投递任务。本接口有如下限制：
        /// - 当数据投递类型（LogType）为站点加速日志（七层访问日志）、四层代理日志、边缘函数运行日志时，同一个实体（七层域名、四层代理实例、边缘函数实例）在同种数据投递类型（LogType）和数据投递区域（Area）的组合下，只能被添加到如下实时日志投递任务类型（TaskType）组合中：
        ///     - 一个推送至腾讯云  CLS 的任务，加上另一个推送至自定义 HTTP(S) 地址的任务；
        ///     - 一个推送至腾讯云  CLS 的任务，加上另一个推送至 AWS S3 兼容对象存储的任务；
        /// - 当数据投递类型（LogType）为速率限制和 CC 攻击防护日志、托管规则日志、自定义规则日志、Bot 管理日志时，同一个实体在同种数据投递类型（LogType）和数据投递区域（Area）的组合下，只能被添加到一个实时日志投递任务中。
        /// 
        /// 建议先通过 [DescribeRealtimeLogDeliveryTasks](https://cloud.tencent.com/document/product/1552/104110)  接口根据实体查询实时日志投递任务列表，检查实体是否已经被添加到另一实时日志投递任务中。
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<CreateRealtimeLogDeliveryTaskResponse> CreateRealtimeLogDeliveryTask(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// 本接口用于创建实时日志投递任务。本接口有如下限制：
        /// - 当数据投递类型（LogType）为站点加速日志（七层访问日志）、四层代理日志、边缘函数运行日志时，同一个实体（七层域名、四层代理实例、边缘函数实例）在同种数据投递类型（LogType）和数据投递区域（Area）的组合下，只能被添加到如下实时日志投递任务类型（TaskType）组合中：
        ///     - 一个推送至腾讯云  CLS 的任务，加上另一个推送至自定义 HTTP(S) 地址的任务；
        ///     - 一个推送至腾讯云  CLS 的任务，加上另一个推送至 AWS S3 兼容对象存储的任务；
        /// - 当数据投递类型（LogType）为速率限制和 CC 攻击防护日志、托管规则日志、自定义规则日志、Bot 管理日志时，同一个实体在同种数据投递类型（LogType）和数据投递区域（Area）的组合下，只能被添加到一个实时日志投递任务中。
        /// 
        /// 建议先通过 [DescribeRealtimeLogDeliveryTasks](https://cloud.tencent.com/document/product/1552/104110)  接口根据实体查询实时日志投递任务列表，检查实体是否已经被添加到另一实时日志投递任务中。
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public CreateRealtimeLogDeliveryTaskResponse CreateRealtimeLogDeliveryTaskSync(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版本创建规则引擎接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本创建七层加速规则接口详情请参考 [CreateL7AccRules](https://cloud.tencent.com/document/product/1552/115822)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// 本接口为旧版本创建规则引擎接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本创建七层加速规则接口详情请参考 [CreateL7AccRules](https://cloud.tencent.com/document/product/1552/115822)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建 API 资源。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIResourceResponse"/></returns>
        public Task<CreateSecurityAPIResourceResponse> CreateSecurityAPIResource(CreateSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIResourceResponse>(req, "CreateSecurityAPIResource");
        }

        /// <summary>
        /// 用于创建 API 资源。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIResourceResponse"/></returns>
        public CreateSecurityAPIResourceResponse CreateSecurityAPIResourceSync(CreateSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIResourceResponse>(req, "CreateSecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建 API 服务。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIServiceResponse"/></returns>
        public Task<CreateSecurityAPIServiceResponse> CreateSecurityAPIService(CreateSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIServiceResponse>(req, "CreateSecurityAPIService");
        }

        /// <summary>
        /// 用于创建 API 服务。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="CreateSecurityAPIServiceResponse"/></returns>
        public CreateSecurityAPIServiceResponse CreateSecurityAPIServiceSync(CreateSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<CreateSecurityAPIServiceResponse>(req, "CreateSecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建客户端认证选项。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="CreateSecurityClientAttesterResponse"/></returns>
        public Task<CreateSecurityClientAttesterResponse> CreateSecurityClientAttester(CreateSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<CreateSecurityClientAttesterResponse>(req, "CreateSecurityClientAttester");
        }

        /// <summary>
        /// 创建客户端认证选项。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="CreateSecurityClientAttesterResponse"/></returns>
        public CreateSecurityClientAttesterResponse CreateSecurityClientAttesterSync(CreateSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<CreateSecurityClientAttesterResponse>(req, "CreateSecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安全 IP 组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public Task<CreateSecurityIPGroupResponse> CreateSecurityIPGroup(CreateSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityIPGroupResponse>(req, "CreateSecurityIPGroup");
        }

        /// <summary>
        /// 创建安全 IP 组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public CreateSecurityIPGroupResponse CreateSecurityIPGroupSync(CreateSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityIPGroupResponse>(req, "CreateSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="CreateSecurityJSInjectionRuleResponse"/></returns>
        public Task<CreateSecurityJSInjectionRuleResponse> CreateSecurityJSInjectionRule(CreateSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<CreateSecurityJSInjectionRuleResponse>(req, "CreateSecurityJSInjectionRule");
        }

        /// <summary>
        /// 创建 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="CreateSecurityJSInjectionRuleResponse"/></returns>
        public CreateSecurityJSInjectionRuleResponse CreateSecurityJSInjectionRuleSync(CreateSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<CreateSecurityJSInjectionRuleResponse>(req, "CreateSecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建共享 CNAME，该功能白名单内测中。
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public Task<CreateSharedCNAMEResponse> CreateSharedCNAME(CreateSharedCNAMERequest req)
        {
            return InternalRequestAsync<CreateSharedCNAMEResponse>(req, "CreateSharedCNAME");
        }

        /// <summary>
        /// 用于创建共享 CNAME，该功能白名单内测中。
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public CreateSharedCNAMEResponse CreateSharedCNAMESync(CreateSharedCNAMERequest req)
        {
            return InternalRequestAsync<CreateSharedCNAMEResponse>(req, "CreateSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安全策略配置模板
        /// </summary>
        /// <param name="req"><see cref="CreateWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="CreateWebSecurityTemplateResponse"/></returns>
        public Task<CreateWebSecurityTemplateResponse> CreateWebSecurityTemplate(CreateWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<CreateWebSecurityTemplateResponse>(req, "CreateWebSecurityTemplate");
        }

        /// <summary>
        /// 创建安全策略配置模板
        /// </summary>
        /// <param name="req"><see cref="CreateWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="CreateWebSecurityTemplateResponse"/></returns>
        public CreateWebSecurityTemplateResponse CreateWebSecurityTemplateSync(CreateWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<CreateWebSecurityTemplateResponse>(req, "CreateWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EdgeOne 为您提供 CNAME、NS 和无域名接入三种接入方式，您需要先通过此接口完成站点创建。CNAME 和 NS 接入站点的场景可参考 [从零开始快速接入 EdgeOne](https://cloud.tencent.com/document/product/1552/87601); 无域名接入的场景可参考 [快速启用四层代理服务](https://cloud.tencent.com/document/product/1552/96051)。
        /// 
        /// > 建议您在账号下已存在套餐时调用本接口创建站点，请在入参时传入 PlanId ，直接将站点绑定至该套餐；不传入 PlanId 时，创建出来的站点会处于未激活状态，无法正常服务，您需要通过 [BindZoneToPlan](https://cloud.tencent.com/document/product/1552/83042) 完成套餐绑定之后，站点才可正常提供服务 。若您当前没有可绑定的套餐时，请前往控制台购买套餐完成站点创建。
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public Task<CreateZoneResponse> CreateZone(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone");
        }

        /// <summary>
        /// EdgeOne 为您提供 CNAME、NS 和无域名接入三种接入方式，您需要先通过此接口完成站点创建。CNAME 和 NS 接入站点的场景可参考 [从零开始快速接入 EdgeOne](https://cloud.tencent.com/document/product/1552/87601); 无域名接入的场景可参考 [快速启用四层代理服务](https://cloud.tencent.com/document/product/1552/96051)。
        /// 
        /// > 建议您在账号下已存在套餐时调用本接口创建站点，请在入参时传入 PlanId ，直接将站点绑定至该套餐；不传入 PlanId 时，创建出来的站点会处于未激活状态，无法正常服务，您需要通过 [BindZoneToPlan](https://cloud.tencent.com/document/product/1552/83042) 完成套餐绑定之后，站点才可正常提供服务 。若您当前没有可绑定的套餐时，请前往控制台购买套餐完成站点创建。
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public CreateZoneResponse CreateZoneSync(CreateZoneRequest req)
        {
            return InternalRequestAsync<CreateZoneResponse>(req, "CreateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public Task<DeleteAccelerationDomainsResponse> DeleteAccelerationDomains(DeleteAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DeleteAccelerationDomainsResponse>(req, "DeleteAccelerationDomains");
        }

        /// <summary>
        /// 批量删除加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public DeleteAccelerationDomainsResponse DeleteAccelerationDomainsSync(DeleteAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DeleteAccelerationDomainsResponse>(req, "DeleteAccelerationDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除别称域名。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public Task<DeleteAliasDomainResponse> DeleteAliasDomain(DeleteAliasDomainRequest req)
        {
            return InternalRequestAsync<DeleteAliasDomainResponse>(req, "DeleteAliasDomain");
        }

        /// <summary>
        /// 删除别称域名。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public DeleteAliasDomainResponse DeleteAliasDomainSync(DeleteAliasDomainRequest req)
        {
            return InternalRequestAsync<DeleteAliasDomainResponse>(req, "DeleteAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [删除四层代理实例
        /// ](https://cloud.tencent.com/document/product/1552/103415) 。
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public Task<DeleteApplicationProxyResponse> DeleteApplicationProxy(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [删除四层代理实例
        /// ](https://cloud.tencent.com/document/product/1552/103415) 。
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public DeleteApplicationProxyResponse DeleteApplicationProxySync(DeleteApplicationProxyRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyResponse>(req, "DeleteApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [删除四层代理转发规则](https://cloud.tencent.com/document/product/1552/103414) 。
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public Task<DeleteApplicationProxyRuleResponse> DeleteApplicationProxyRule(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [删除四层代理转发规则](https://cloud.tencent.com/document/product/1552/103414) 。
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public DeleteApplicationProxyRuleResponse DeleteApplicationProxyRuleSync(DeleteApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProxyRuleResponse>(req, "DeleteApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定的内容标识符。该功能仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentIdentifierRequest"/></param>
        /// <returns><see cref="DeleteContentIdentifierResponse"/></returns>
        public Task<DeleteContentIdentifierResponse> DeleteContentIdentifier(DeleteContentIdentifierRequest req)
        {
            return InternalRequestAsync<DeleteContentIdentifierResponse>(req, "DeleteContentIdentifier");
        }

        /// <summary>
        /// 删除指定的内容标识符。该功能仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentIdentifierRequest"/></param>
        /// <returns><see cref="DeleteContentIdentifierResponse"/></returns>
        public DeleteContentIdentifierResponse DeleteContentIdentifierSync(DeleteContentIdentifierRequest req)
        {
            return InternalRequestAsync<DeleteContentIdentifierResponse>(req, "DeleteContentIdentifier")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义错误页面。
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomErrorPageRequest"/></param>
        /// <returns><see cref="DeleteCustomErrorPageResponse"/></returns>
        public Task<DeleteCustomErrorPageResponse> DeleteCustomErrorPage(DeleteCustomErrorPageRequest req)
        {
            return InternalRequestAsync<DeleteCustomErrorPageResponse>(req, "DeleteCustomErrorPage");
        }

        /// <summary>
        /// 删除自定义错误页面。
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomErrorPageRequest"/></param>
        /// <returns><see cref="DeleteCustomErrorPageResponse"/></returns>
        public DeleteCustomErrorPageResponse DeleteCustomErrorPageSync(DeleteCustomErrorPageRequest req)
        {
            return InternalRequestAsync<DeleteCustomErrorPageResponse>(req, "DeleteCustomErrorPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您可以用本接口批量删除 DNS 记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public Task<DeleteDnsRecordsResponse> DeleteDnsRecords(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords");
        }

        /// <summary>
        /// 您可以用本接口批量删除 DNS 记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public DeleteDnsRecordsResponse DeleteDnsRecordsSync(DeleteDnsRecordsRequest req)
        {
            return InternalRequestAsync<DeleteDnsRecordsResponse>(req, "DeleteDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘函数，删除后函数无法恢复，关联的触发规则会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction");
        }

        /// <summary>
        /// 删除边缘函数，删除后函数无法恢复，关联的触发规则会一并删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public DeleteFunctionResponse DeleteFunctionSync(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除边缘函数触发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRulesRequest"/></param>
        /// <returns><see cref="DeleteFunctionRulesResponse"/></returns>
        public Task<DeleteFunctionRulesResponse> DeleteFunctionRules(DeleteFunctionRulesRequest req)
        {
            return InternalRequestAsync<DeleteFunctionRulesResponse>(req, "DeleteFunctionRules");
        }

        /// <summary>
        /// 删除边缘函数触发规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRulesRequest"/></param>
        /// <returns><see cref="DeleteFunctionRulesResponse"/></returns>
        public DeleteFunctionRulesResponse DeleteFunctionRulesSync(DeleteFunctionRulesRequest req)
        {
            return InternalRequestAsync<DeleteFunctionRulesResponse>(req, "DeleteFunctionRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据站点 id 下唯一的模板标识，删除相应的即时转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplatesResponse"/></returns>
        public Task<DeleteJustInTimeTranscodeTemplatesResponse> DeleteJustInTimeTranscodeTemplates(DeleteJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplatesResponse>(req, "DeleteJustInTimeTranscodeTemplates");
        }

        /// <summary>
        /// 根据站点 id 下唯一的模板标识，删除相应的即时转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DeleteJustInTimeTranscodeTemplatesResponse"/></returns>
        public DeleteJustInTimeTranscodeTemplatesResponse DeleteJustInTimeTranscodeTemplatesSync(DeleteJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteJustInTimeTranscodeTemplatesResponse>(req, "DeleteJustInTimeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除四层代理实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyResponse"/></returns>
        public Task<DeleteL4ProxyResponse> DeleteL4Proxy(DeleteL4ProxyRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyResponse>(req, "DeleteL4Proxy");
        }

        /// <summary>
        /// 用于删除四层代理实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyResponse"/></returns>
        public DeleteL4ProxyResponse DeleteL4ProxySync(DeleteL4ProxyRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyResponse>(req, "DeleteL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除四层代理转发规则，支持单条或者批量操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyRulesResponse"/></returns>
        public Task<DeleteL4ProxyRulesResponse> DeleteL4ProxyRules(DeleteL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyRulesResponse>(req, "DeleteL4ProxyRules");
        }

        /// <summary>
        /// 用于删除四层代理转发规则，支持单条或者批量操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DeleteL4ProxyRulesResponse"/></returns>
        public DeleteL4ProxyRulesResponse DeleteL4ProxyRulesSync(DeleteL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DeleteL4ProxyRulesResponse>(req, "DeleteL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除[规则引擎](https://cloud.tencent.com/document/product/1552/70901)的规则，支持批量删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7AccRulesRequest"/></param>
        /// <returns><see cref="DeleteL7AccRulesResponse"/></returns>
        public Task<DeleteL7AccRulesResponse> DeleteL7AccRules(DeleteL7AccRulesRequest req)
        {
            return InternalRequestAsync<DeleteL7AccRulesResponse>(req, "DeleteL7AccRules");
        }

        /// <summary>
        /// 本接口用于删除[规则引擎](https://cloud.tencent.com/document/product/1552/70901)的规则，支持批量删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteL7AccRulesRequest"/></param>
        /// <returns><see cref="DeleteL7AccRulesResponse"/></returns>
        public DeleteL7AccRulesResponse DeleteL7AccRulesSync(DeleteL7AccRulesRequest req)
        {
            return InternalRequestAsync<DeleteL7AccRulesResponse>(req, "DeleteL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除负载均衡实例，若负载均衡示例被其他服务（例如：四层代理等）引用的时候，示例无法被删除，需要先解除引用关系。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// 删除负载均衡实例，若负载均衡示例被其他服务（例如：四层代理等）引用的时候，示例无法被删除，需要先解除引用关系。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口删除多通道安全加速网关，包括自有网关和云上网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayResponse"/></returns>
        public Task<DeleteMultiPathGatewayResponse> DeleteMultiPathGateway(DeleteMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayResponse>(req, "DeleteMultiPathGateway");
        }

        /// <summary>
        /// 通过本接口删除多通道安全加速网关，包括自有网关和云上网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayResponse"/></returns>
        public DeleteMultiPathGatewayResponse DeleteMultiPathGatewaySync(DeleteMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayResponse>(req, "DeleteMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口删除接入多通道安全加速网关的线路，仅自定义线路支持删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayLineResponse"/></returns>
        public Task<DeleteMultiPathGatewayLineResponse> DeleteMultiPathGatewayLine(DeleteMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayLineResponse>(req, "DeleteMultiPathGatewayLine");
        }

        /// <summary>
        /// 通过本接口删除接入多通道安全加速网关的线路，仅自定义线路支持删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DeleteMultiPathGatewayLineResponse"/></returns>
        public DeleteMultiPathGatewayLineResponse DeleteMultiPathGatewayLineSync(DeleteMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DeleteMultiPathGatewayLineResponse>(req, "DeleteMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除源站组，若源站组仍然被服务（例如：四层代理，域名服务，负载均衡，规则引起）引用，将不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public Task<DeleteOriginGroupResponse> DeleteOriginGroup(DeleteOriginGroupRequest req)
        {
            return InternalRequestAsync<DeleteOriginGroupResponse>(req, "DeleteOriginGroup");
        }

        /// <summary>
        /// 删除源站组，若源站组仍然被服务（例如：四层代理，域名服务，负载均衡，规则引起）引用，将不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public DeleteOriginGroupResponse DeleteOriginGroupSync(DeleteOriginGroupRequest req)
        {
            return InternalRequestAsync<DeleteOriginGroupResponse>(req, "DeleteOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口删除实时日志投递任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="DeleteRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<DeleteRealtimeLogDeliveryTaskResponse> DeleteRealtimeLogDeliveryTask(DeleteRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteRealtimeLogDeliveryTaskResponse>(req, "DeleteRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// 通过本接口删除实时日志投递任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="DeleteRealtimeLogDeliveryTaskResponse"/></returns>
        public DeleteRealtimeLogDeliveryTaskResponse DeleteRealtimeLogDeliveryTaskSync(DeleteRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteRealtimeLogDeliveryTaskResponse>(req, "DeleteRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版本删除规则引擎接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本删除七层加速规则接口详情请参考 [DeleteL7AccRules](https://cloud.tencent.com/document/product/1552/115821)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules");
        }

        /// <summary>
        /// 本接口为旧版本删除规则引擎接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本删除七层加速规则接口详情请参考 [DeleteL7AccRules](https://cloud.tencent.com/document/product/1552/115821)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除 API 资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIResourceResponse"/></returns>
        public Task<DeleteSecurityAPIResourceResponse> DeleteSecurityAPIResource(DeleteSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIResourceResponse>(req, "DeleteSecurityAPIResource");
        }

        /// <summary>
        /// 用于删除 API 资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIResourceResponse"/></returns>
        public DeleteSecurityAPIResourceResponse DeleteSecurityAPIResourceSync(DeleteSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIResourceResponse>(req, "DeleteSecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除 API 服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIServiceResponse"/></returns>
        public Task<DeleteSecurityAPIServiceResponse> DeleteSecurityAPIService(DeleteSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIServiceResponse>(req, "DeleteSecurityAPIService");
        }

        /// <summary>
        /// 用于删除 API 服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DeleteSecurityAPIServiceResponse"/></returns>
        public DeleteSecurityAPIServiceResponse DeleteSecurityAPIServiceSync(DeleteSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAPIServiceResponse>(req, "DeleteSecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除客户端认证选项。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DeleteSecurityClientAttesterResponse"/></returns>
        public Task<DeleteSecurityClientAttesterResponse> DeleteSecurityClientAttester(DeleteSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DeleteSecurityClientAttesterResponse>(req, "DeleteSecurityClientAttester");
        }

        /// <summary>
        /// 删除客户端认证选项。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DeleteSecurityClientAttesterResponse"/></returns>
        public DeleteSecurityClientAttesterResponse DeleteSecurityClientAttesterSync(DeleteSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DeleteSecurityClientAttesterResponse>(req, "DeleteSecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定 IP 组，如果有规则引用了 IP 组情况，则不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public Task<DeleteSecurityIPGroupResponse> DeleteSecurityIPGroup(DeleteSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityIPGroupResponse>(req, "DeleteSecurityIPGroup");
        }

        /// <summary>
        /// 删除指定 IP 组，如果有规则引用了 IP 组情况，则不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public DeleteSecurityIPGroupResponse DeleteSecurityIPGroupSync(DeleteSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityIPGroupResponse>(req, "DeleteSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityJSInjectionRuleResponse"/></returns>
        public Task<DeleteSecurityJSInjectionRuleResponse> DeleteSecurityJSInjectionRule(DeleteSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityJSInjectionRuleResponse>(req, "DeleteSecurityJSInjectionRule");
        }

        /// <summary>
        /// 删除 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityJSInjectionRuleResponse"/></returns>
        public DeleteSecurityJSInjectionRuleResponse DeleteSecurityJSInjectionRuleSync(DeleteSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityJSInjectionRuleResponse>(req, "DeleteSecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除共享 CNAME，该功能白名单内测中。
        /// </summary>
        /// <param name="req"><see cref="DeleteSharedCNAMERequest"/></param>
        /// <returns><see cref="DeleteSharedCNAMEResponse"/></returns>
        public Task<DeleteSharedCNAMEResponse> DeleteSharedCNAME(DeleteSharedCNAMERequest req)
        {
            return InternalRequestAsync<DeleteSharedCNAMEResponse>(req, "DeleteSharedCNAME");
        }

        /// <summary>
        /// 用于删除共享 CNAME，该功能白名单内测中。
        /// </summary>
        /// <param name="req"><see cref="DeleteSharedCNAMERequest"/></param>
        /// <returns><see cref="DeleteSharedCNAMEResponse"/></returns>
        public DeleteSharedCNAMEResponse DeleteSharedCNAMESync(DeleteSharedCNAMERequest req)
        {
            return InternalRequestAsync<DeleteSharedCNAMEResponse>(req, "DeleteSharedCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安全策略配置模板
        /// </summary>
        /// <param name="req"><see cref="DeleteWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DeleteWebSecurityTemplateResponse"/></returns>
        public Task<DeleteWebSecurityTemplateResponse> DeleteWebSecurityTemplate(DeleteWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWebSecurityTemplateResponse>(req, "DeleteWebSecurityTemplate");
        }

        /// <summary>
        /// 删除安全策略配置模板
        /// </summary>
        /// <param name="req"><see cref="DeleteWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DeleteWebSecurityTemplateResponse"/></returns>
        public DeleteWebSecurityTemplateResponse DeleteWebSecurityTemplateSync(DeleteWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DeleteWebSecurityTemplateResponse>(req, "DeleteWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除站点。
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public Task<DeleteZoneResponse> DeleteZone(DeleteZoneRequest req)
        {
            return InternalRequestAsync<DeleteZoneResponse>(req, "DeleteZone");
        }

        /// <summary>
        /// 删除站点。
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public DeleteZoneResponse DeleteZoneSync(DeleteZoneRequest req)
        {
            return InternalRequestAsync<DeleteZoneResponse>(req, "DeleteZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在版本管理模式下，用于版本发布，可通过 EnvId 将版本发布至测试环境或生产环境。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DeployConfigGroupVersionRequest"/></param>
        /// <returns><see cref="DeployConfigGroupVersionResponse"/></returns>
        public Task<DeployConfigGroupVersionResponse> DeployConfigGroupVersion(DeployConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<DeployConfigGroupVersionResponse>(req, "DeployConfigGroupVersion");
        }

        /// <summary>
        /// 在版本管理模式下，用于版本发布，可通过 EnvId 将版本发布至测试环境或生产环境。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DeployConfigGroupVersionRequest"/></param>
        /// <returns><see cref="DeployConfigGroupVersionResponse"/></returns>
        public DeployConfigGroupVersionResponse DeployConfigGroupVersionSync(DeployConfigGroupVersionRequest req)
        {
            return InternalRequestAsync<DeployConfigGroupVersionResponse>(req, "DeployConfigGroupVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您可以通过本接口查看站点下的域名信息，包括加速域名、源站以及域名状态等信息。您可以查看站点下全部域名的信息，也可以指定过滤条件查询对应的域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public Task<DescribeAccelerationDomainsResponse> DescribeAccelerationDomains(DescribeAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerationDomainsResponse>(req, "DescribeAccelerationDomains");
        }

        /// <summary>
        /// 您可以通过本接口查看站点下的域名信息，包括加速域名、源站以及域名状态等信息。您可以查看站点下全部域名的信息，也可以指定过滤条件查询对应的域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public DescribeAccelerationDomainsResponse DescribeAccelerationDomainsSync(DescribeAccelerationDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerationDomainsResponse>(req, "DescribeAccelerationDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询别称域名信息列表。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public Task<DescribeAliasDomainsResponse> DescribeAliasDomains(DescribeAliasDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAliasDomainsResponse>(req, "DescribeAliasDomains");
        }

        /// <summary>
        /// 查询别称域名信息列表。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public DescribeAliasDomainsResponse DescribeAliasDomainsSync(DescribeAliasDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAliasDomainsResponse>(req, "DescribeAliasDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，新版接口中将四层代理实例列表的查询和四层转发规则的查询拆分成两个接口，详情请参考 [查询四层代理实例列表](https://cloud.tencent.com/document/product/1552/103413) 和 [查询四层代理转发规则列表](https://cloud.tencent.com/document/product/1552/103412)。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public Task<DescribeApplicationProxiesResponse> DescribeApplicationProxies(DescribeApplicationProxiesRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxiesResponse>(req, "DescribeApplicationProxies");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，新版接口中将四层代理实例列表的查询和四层转发规则的查询拆分成两个接口，详情请参考 [查询四层代理实例列表](https://cloud.tencent.com/document/product/1552/103413) 和 [查询四层代理转发规则列表](https://cloud.tencent.com/document/product/1552/103412)。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public DescribeApplicationProxiesResponse DescribeApplicationProxiesSync(DescribeApplicationProxiesRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProxiesResponse>(req, "DescribeApplicationProxies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前账户可用套餐信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public Task<DescribeAvailablePlansResponse> DescribeAvailablePlans(DescribeAvailablePlansRequest req)
        {
            return InternalRequestAsync<DescribeAvailablePlansResponse>(req, "DescribeAvailablePlans");
        }

        /// <summary>
        /// 查询当前账户可用套餐信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public DescribeAvailablePlansResponse DescribeAvailablePlansSync(DescribeAvailablePlansRequest req)
        {
            return InternalRequestAsync<DescribeAvailablePlansResponse>(req, "DescribeAvailablePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口查询计费数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public Task<DescribeBillingDataResponse> DescribeBillingData(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData");
        }

        /// <summary>
        /// 通过本接口查询计费数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public DescribeBillingDataResponse DescribeBillingDataSync(DescribeBillingDataRequest req)
        {
            return InternalRequestAsync<DescribeBillingDataResponse>(req, "DescribeBillingData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在版本管理模式下，用于获取版本的详细信息，包括版本 ID、描述、状态、创建时间、所属配置组信息以及版本配置文件的内容。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionDetailRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionDetailResponse"/></returns>
        public Task<DescribeConfigGroupVersionDetailResponse> DescribeConfigGroupVersionDetail(DescribeConfigGroupVersionDetailRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionDetailResponse>(req, "DescribeConfigGroupVersionDetail");
        }

        /// <summary>
        /// 在版本管理模式下，用于获取版本的详细信息，包括版本 ID、描述、状态、创建时间、所属配置组信息以及版本配置文件的内容。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionDetailRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionDetailResponse"/></returns>
        public DescribeConfigGroupVersionDetailResponse DescribeConfigGroupVersionDetailSync(DescribeConfigGroupVersionDetailRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionDetailResponse>(req, "DescribeConfigGroupVersionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在版本管理模式下，用于查询指定配置组的版本列表。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionsResponse"/></returns>
        public Task<DescribeConfigGroupVersionsResponse> DescribeConfigGroupVersions(DescribeConfigGroupVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionsResponse>(req, "DescribeConfigGroupVersions");
        }

        /// <summary>
        /// 在版本管理模式下，用于查询指定配置组的版本列表。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigGroupVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigGroupVersionsResponse"/></returns>
        public DescribeConfigGroupVersionsResponse DescribeConfigGroupVersionsSync(DescribeConfigGroupVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigGroupVersionsResponse>(req, "DescribeConfigGroupVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询内容标识符，可以根据 ID、描述、状态或者标签过滤。按照状态查询被删除的内容标识符仅保留三个月。该功能仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentIdentifiersRequest"/></param>
        /// <returns><see cref="DescribeContentIdentifiersResponse"/></returns>
        public Task<DescribeContentIdentifiersResponse> DescribeContentIdentifiers(DescribeContentIdentifiersRequest req)
        {
            return InternalRequestAsync<DescribeContentIdentifiersResponse>(req, "DescribeContentIdentifiers");
        }

        /// <summary>
        /// 批量查询内容标识符，可以根据 ID、描述、状态或者标签过滤。按照状态查询被删除的内容标识符仅保留三个月。该功能仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentIdentifiersRequest"/></param>
        /// <returns><see cref="DescribeContentIdentifiersResponse"/></returns>
        public DescribeContentIdentifiersResponse DescribeContentIdentifiersSync(DescribeContentIdentifiersRequest req)
        {
            return InternalRequestAsync<DescribeContentIdentifiersResponse>(req, "DescribeContentIdentifiers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询内容管理接口配额
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public Task<DescribeContentQuotaResponse> DescribeContentQuota(DescribeContentQuotaRequest req)
        {
            return InternalRequestAsync<DescribeContentQuotaResponse>(req, "DescribeContentQuota");
        }

        /// <summary>
        /// 查询内容管理接口配额
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public DescribeContentQuotaResponse DescribeContentQuotaSync(DescribeContentQuotaRequest req)
        {
            return InternalRequestAsync<DescribeContentQuotaResponse>(req, "DescribeContentQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自定义错误页列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomErrorPagesRequest"/></param>
        /// <returns><see cref="DescribeCustomErrorPagesResponse"/></returns>
        public Task<DescribeCustomErrorPagesResponse> DescribeCustomErrorPages(DescribeCustomErrorPagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomErrorPagesResponse>(req, "DescribeCustomErrorPages");
        }

        /// <summary>
        /// 查询自定义错误页列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomErrorPagesRequest"/></param>
        /// <returns><see cref="DescribeCustomErrorPagesResponse"/></returns>
        public DescribeCustomErrorPagesResponse DescribeCustomErrorPagesSync(DescribeCustomErrorPagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomErrorPagesResponse>(req, "DescribeCustomErrorPages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackData）用于查询DDoS攻击时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public Task<DescribeDDoSAttackDataResponse> DescribeDDoSAttackData(DescribeDDoSAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackDataResponse>(req, "DescribeDDoSAttackData");
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackData）用于查询DDoS攻击时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public DescribeDDoSAttackDataResponse DescribeDDoSAttackDataSync(DescribeDDoSAttackDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackDataResponse>(req, "DescribeDDoSAttackData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackEvent）用于查询DDoS攻击事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public Task<DescribeDDoSAttackEventResponse> DescribeDDoSAttackEvent(DescribeDDoSAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackEventResponse>(req, "DescribeDDoSAttackEvent");
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackEvent）用于查询DDoS攻击事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public DescribeDDoSAttackEventResponse DescribeDDoSAttackEventSync(DescribeDDoSAttackEventRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackEventResponse>(req, "DescribeDDoSAttackEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackTopData）用于查询DDoS攻击Top数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public Task<DescribeDDoSAttackTopDataResponse> DescribeDDoSAttackTopData(DescribeDDoSAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackTopDataResponse>(req, "DescribeDDoSAttackTopData");
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackTopData）用于查询DDoS攻击Top数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public DescribeDDoSAttackTopDataResponse DescribeDDoSAttackTopDataSync(DescribeDDoSAttackTopDataRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackTopDataResponse>(req, "DescribeDDoSAttackTopData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取站点的独立 DDoS 防护信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSProtectionRequest"/></param>
        /// <returns><see cref="DescribeDDoSProtectionResponse"/></returns>
        public Task<DescribeDDoSProtectionResponse> DescribeDDoSProtection(DescribeDDoSProtectionRequest req)
        {
            return InternalRequestAsync<DescribeDDoSProtectionResponse>(req, "DescribeDDoSProtection");
        }

        /// <summary>
        /// 获取站点的独立 DDoS 防护信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSProtectionRequest"/></param>
        /// <returns><see cref="DescribeDDoSProtectionResponse"/></returns>
        public DescribeDDoSProtectionResponse DescribeDDoSProtectionSync(DescribeDDoSProtectionRequest req)
        {
            return InternalRequestAsync<DescribeDDoSProtectionResponse>(req, "DescribeDDoSProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询默认证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public Task<DescribeDefaultCertificatesResponse> DescribeDefaultCertificates(DescribeDefaultCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDefaultCertificatesResponse>(req, "DescribeDefaultCertificates");
        }

        /// <summary>
        /// 查询默认证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public DescribeDefaultCertificatesResponse DescribeDefaultCertificatesSync(DescribeDefaultCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeDefaultCertificatesResponse>(req, "DescribeDefaultCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在版本管理模式下，用于查询生产/测试环境的版本发布历史。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeployHistoryResponse"/></returns>
        public Task<DescribeDeployHistoryResponse> DescribeDeployHistory(DescribeDeployHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeployHistoryResponse>(req, "DescribeDeployHistory");
        }

        /// <summary>
        /// 在版本管理模式下，用于查询生产/测试环境的版本发布历史。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeployHistoryResponse"/></returns>
        public DescribeDeployHistoryResponse DescribeDeployHistorySync(DescribeDeployHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeployHistoryResponse>(req, "DescribeDeployHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您可以用过本接口查看站点下的 DNS 记录信息，包括 DNS 记录名、记录类型以及记录内容等信息，支持指定过滤条件查询对应的 DNS 记录信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public Task<DescribeDnsRecordsResponse> DescribeDnsRecords(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords");
        }

        /// <summary>
        /// 您可以用过本接口查看站点下的 DNS 记录信息，包括 DNS 记录名、记录类型以及记录内容等信息，支持指定过滤条件查询对应的 DNS 记录信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public DescribeDnsRecordsResponse DescribeDnsRecordsSync(DescribeDnsRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDnsRecordsResponse>(req, "DescribeDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在版本管理模式下，用于查询环境信息，可获取环境 ID、类型、当前生效版本等。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// 在版本管理模式下，用于查询环境信息，可获取环境 ID、类型、当前生效版本等。版本管理功能内测中，当前仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘函数触发规则列表，支持按照规则 ID、函数 ID、规则描述等条件进行过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRulesRequest"/></param>
        /// <returns><see cref="DescribeFunctionRulesResponse"/></returns>
        public Task<DescribeFunctionRulesResponse> DescribeFunctionRules(DescribeFunctionRulesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRulesResponse>(req, "DescribeFunctionRules");
        }

        /// <summary>
        /// 查询边缘函数触发规则列表，支持按照规则 ID、函数 ID、规则描述等条件进行过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRulesRequest"/></param>
        /// <returns><see cref="DescribeFunctionRulesResponse"/></returns>
        public DescribeFunctionRulesResponse DescribeFunctionRulesSync(DescribeFunctionRulesRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRulesResponse>(req, "DescribeFunctionRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘函数运行环境，包括环境变量。
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeFunctionRuntimeEnvironmentResponse"/></returns>
        public Task<DescribeFunctionRuntimeEnvironmentResponse> DescribeFunctionRuntimeEnvironment(DescribeFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRuntimeEnvironmentResponse>(req, "DescribeFunctionRuntimeEnvironment");
        }

        /// <summary>
        /// 查询边缘函数运行环境，包括环境变量。
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeFunctionRuntimeEnvironmentResponse"/></returns>
        public DescribeFunctionRuntimeEnvironmentResponse DescribeFunctionRuntimeEnvironmentSync(DescribeFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeFunctionRuntimeEnvironmentResponse>(req, "DescribeFunctionRuntimeEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘函数列表，支持函数 ID、函数名称、描述等条件的过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionsRequest"/></param>
        /// <returns><see cref="DescribeFunctionsResponse"/></returns>
        public Task<DescribeFunctionsResponse> DescribeFunctions(DescribeFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionsResponse>(req, "DescribeFunctions");
        }

        /// <summary>
        /// 查询边缘函数列表，支持函数 ID、函数名称、描述等条件的过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeFunctionsRequest"/></param>
        /// <returns><see cref="DescribeFunctionsResponse"/></returns>
        public DescribeFunctionsResponse DescribeFunctionsSync(DescribeFunctionsRequest req)
        {
            return InternalRequestAsync<DescribeFunctionsResponse>(req, "DescribeFunctions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，可通过 [DescribeL7AccSetting](https://cloud.tencent.com/document/product/1552/115819) 和 [DescribeL7AccRules](https://cloud.tencent.com/document/product/1552/115820) 来获取域名的详细配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public Task<DescribeHostsSettingResponse> DescribeHostsSetting(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting");
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，可通过 [DescribeL7AccSetting](https://cloud.tencent.com/document/product/1552/115819) 和 [DescribeL7AccRules](https://cloud.tencent.com/document/product/1552/115820) 来获取域名的详细配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public DescribeHostsSettingResponse DescribeHostsSettingSync(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口可用于查询 IP 是否为 EdgeOne IP。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPRegionRequest"/></param>
        /// <returns><see cref="DescribeIPRegionResponse"/></returns>
        public Task<DescribeIPRegionResponse> DescribeIPRegion(DescribeIPRegionRequest req)
        {
            return InternalRequestAsync<DescribeIPRegionResponse>(req, "DescribeIPRegion");
        }

        /// <summary>
        /// 该接口可用于查询 IP 是否为 EdgeOne IP。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPRegionRequest"/></param>
        /// <returns><see cref="DescribeIPRegionResponse"/></returns>
        public DescribeIPRegionResponse DescribeIPRegionSync(DescribeIPRegionRequest req)
        {
            return InternalRequestAsync<DescribeIPRegionResponse>(req, "DescribeIPRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询站点的验证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public Task<DescribeIdentificationsResponse> DescribeIdentifications(DescribeIdentificationsRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationsResponse>(req, "DescribeIdentifications");
        }

        /// <summary>
        /// 查询站点的验证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public DescribeIdentificationsResponse DescribeIdentificationsSync(DescribeIdentificationsRequest req)
        {
            return InternalRequestAsync<DescribeIdentificationsResponse>(req, "DescribeIdentifications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据即时转码模板名字、模板类型或唯一标识，获取即时转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及预置模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public Task<DescribeJustInTimeTranscodeTemplatesResponse> DescribeJustInTimeTranscodeTemplates(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates");
        }

        /// <summary>
        /// 根据即时转码模板名字、模板类型或唯一标识，获取即时转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及预置模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeJustInTimeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeJustInTimeTranscodeTemplatesResponse"/></returns>
        public DescribeJustInTimeTranscodeTemplatesResponse DescribeJustInTimeTranscodeTemplatesSync(DescribeJustInTimeTranscodeTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeJustInTimeTranscodeTemplatesResponse>(req, "DescribeJustInTimeTranscodeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询四层代理实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyResponse"/></returns>
        public Task<DescribeL4ProxyResponse> DescribeL4Proxy(DescribeL4ProxyRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyResponse>(req, "DescribeL4Proxy");
        }

        /// <summary>
        /// 用于查询四层代理实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyResponse"/></returns>
        public DescribeL4ProxyResponse DescribeL4ProxySync(DescribeL4ProxyRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyResponse>(req, "DescribeL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询四层代理实例下的转发规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyRulesResponse"/></returns>
        public Task<DescribeL4ProxyRulesResponse> DescribeL4ProxyRules(DescribeL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyRulesResponse>(req, "DescribeL4ProxyRules");
        }

        /// <summary>
        /// 查询四层代理实例下的转发规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL4ProxyRulesRequest"/></param>
        /// <returns><see cref="DescribeL4ProxyRulesResponse"/></returns>
        public DescribeL4ProxyRulesResponse DescribeL4ProxyRulesSync(DescribeL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<DescribeL4ProxyRulesResponse>(req, "DescribeL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询[规则引擎](https://cloud.tencent.com/document/product/1552/70901)的规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccRulesRequest"/></param>
        /// <returns><see cref="DescribeL7AccRulesResponse"/></returns>
        public Task<DescribeL7AccRulesResponse> DescribeL7AccRules(DescribeL7AccRulesRequest req)
        {
            return InternalRequestAsync<DescribeL7AccRulesResponse>(req, "DescribeL7AccRules");
        }

        /// <summary>
        /// 本接口用于查询[规则引擎](https://cloud.tencent.com/document/product/1552/70901)的规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccRulesRequest"/></param>
        /// <returns><see cref="DescribeL7AccRulesResponse"/></returns>
        public DescribeL7AccRulesResponse DescribeL7AccRulesSync(DescribeL7AccRulesRequest req)
        {
            return InternalRequestAsync<DescribeL7AccRulesResponse>(req, "DescribeL7AccRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询[站点加速](https://cloud.tencent.com/document/product/1552/96193)全局配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccSettingRequest"/></param>
        /// <returns><see cref="DescribeL7AccSettingResponse"/></returns>
        public Task<DescribeL7AccSettingResponse> DescribeL7AccSetting(DescribeL7AccSettingRequest req)
        {
            return InternalRequestAsync<DescribeL7AccSettingResponse>(req, "DescribeL7AccSetting");
        }

        /// <summary>
        /// 本接口用于查询[站点加速](https://cloud.tencent.com/document/product/1552/96193)全局配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeL7AccSettingRequest"/></param>
        /// <returns><see cref="DescribeL7AccSettingResponse"/></returns>
        public DescribeL7AccSettingResponse DescribeL7AccSettingSync(DescribeL7AccSettingRequest req)
        {
            return InternalRequestAsync<DescribeL7AccSettingResponse>(req, "DescribeL7AccSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡实例列表。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListResponse"/></returns>
        public Task<DescribeLoadBalancerListResponse> DescribeLoadBalancerList(DescribeLoadBalancerListRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListResponse>(req, "DescribeLoadBalancerList");
        }

        /// <summary>
        /// 查询负载均衡实例列表。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListResponse"/></returns>
        public DescribeLoadBalancerListResponse DescribeLoadBalancerListSync(DescribeLoadBalancerListRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListResponse>(req, "DescribeLoadBalancerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口查询多通道安全加速网关详情。如名称、网关 ID、IP、端口、类型等。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayResponse"/></returns>
        public Task<DescribeMultiPathGatewayResponse> DescribeMultiPathGateway(DescribeMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayResponse>(req, "DescribeMultiPathGateway");
        }

        /// <summary>
        /// 通过本接口查询多通道安全加速网关详情。如名称、网关 ID、IP、端口、类型等。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayResponse"/></returns>
        public DescribeMultiPathGatewayResponse DescribeMultiPathGatewaySync(DescribeMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayResponse>(req, "DescribeMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口查询接入多通道安全加速网关的线路。包括直连、EdgeOne 四层代理线路、自定义线路。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayLineResponse"/></returns>
        public Task<DescribeMultiPathGatewayLineResponse> DescribeMultiPathGatewayLine(DescribeMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayLineResponse>(req, "DescribeMultiPathGatewayLine");
        }

        /// <summary>
        /// 通过本接口查询接入多通道安全加速网关的线路。包括直连、EdgeOne 四层代理线路、自定义线路。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayLineResponse"/></returns>
        public DescribeMultiPathGatewayLineResponse DescribeMultiPathGatewayLineSync(DescribeMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayLineResponse>(req, "DescribeMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口查询用户创建的多通道安全加速网关（云上网关）的可用地域列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRegionsRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayRegionsResponse"/></returns>
        public Task<DescribeMultiPathGatewayRegionsResponse> DescribeMultiPathGatewayRegions(DescribeMultiPathGatewayRegionsRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayRegionsResponse>(req, "DescribeMultiPathGatewayRegions");
        }

        /// <summary>
        /// 通过本接口查询用户创建的多通道安全加速网关（云上网关）的可用地域列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewayRegionsRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewayRegionsResponse"/></returns>
        public DescribeMultiPathGatewayRegionsResponse DescribeMultiPathGatewayRegionsSync(DescribeMultiPathGatewayRegionsRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewayRegionsResponse>(req, "DescribeMultiPathGatewayRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口查询接入多通道安全加速网关的密钥，客户基于接入密钥签名接入多通道安全加速网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<DescribeMultiPathGatewaySecretKeyResponse> DescribeMultiPathGatewaySecretKey(DescribeMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaySecretKeyResponse>(req, "DescribeMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// 通过本接口查询接入多通道安全加速网关的密钥，客户基于接入密钥签名接入多通道安全加速网关。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaySecretKeyResponse"/></returns>
        public DescribeMultiPathGatewaySecretKeyResponse DescribeMultiPathGatewaySecretKeySync(DescribeMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaySecretKeyResponse>(req, "DescribeMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口查询用户创建的多通道安全加速网关列表。支持翻页。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaysRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaysResponse"/></returns>
        public Task<DescribeMultiPathGatewaysResponse> DescribeMultiPathGateways(DescribeMultiPathGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaysResponse>(req, "DescribeMultiPathGateways");
        }

        /// <summary>
        /// 通过本接口查询用户创建的多通道安全加速网关列表。支持翻页。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiPathGatewaysRequest"/></param>
        /// <returns><see cref="DescribeMultiPathGatewaysResponse"/></returns>
        public DescribeMultiPathGatewaysResponse DescribeMultiPathGatewaysSync(DescribeMultiPathGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeMultiPathGatewaysResponse>(req, "DescribeMultiPathGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询站点下的七层加速域名/四层代理实例与回源 IP 网段的绑定关系，以及回源 IP 网段详情。如果您想通过自动化脚本定期获取回源 IP 网段的最新版本，可以较低频率（建议每三天一次）轮询本接口，若 NextOriginACL 字段有返回值，则将最新的回源 IP 网段同步到源站防火墙配置中。
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginACLRequest"/></param>
        /// <returns><see cref="DescribeOriginACLResponse"/></returns>
        public Task<DescribeOriginACLResponse> DescribeOriginACL(DescribeOriginACLRequest req)
        {
            return InternalRequestAsync<DescribeOriginACLResponse>(req, "DescribeOriginACL");
        }

        /// <summary>
        /// 本接口用于查询站点下的七层加速域名/四层代理实例与回源 IP 网段的绑定关系，以及回源 IP 网段详情。如果您想通过自动化脚本定期获取回源 IP 网段的最新版本，可以较低频率（建议每三天一次）轮询本接口，若 NextOriginACL 字段有返回值，则将最新的回源 IP 网段同步到源站防火墙配置中。
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginACLRequest"/></param>
        /// <returns><see cref="DescribeOriginACLResponse"/></returns>
        public DescribeOriginACLResponse DescribeOriginACLSync(DescribeOriginACLRequest req)
        {
            return InternalRequestAsync<DescribeOriginACLResponse>(req, "DescribeOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取源站组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public Task<DescribeOriginGroupResponse> DescribeOriginGroup(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup");
        }

        /// <summary>
        /// 获取源站组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public DescribeOriginGroupResponse DescribeOriginGroupSync(DescribeOriginGroupRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupResponse>(req, "DescribeOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询负载均衡实例下源站组健康状态。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupHealthStatusResponse"/></returns>
        public Task<DescribeOriginGroupHealthStatusResponse> DescribeOriginGroupHealthStatus(DescribeOriginGroupHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupHealthStatusResponse>(req, "DescribeOriginGroupHealthStatus");
        }

        /// <summary>
        /// 查询负载均衡实例下源站组健康状态。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupHealthStatusResponse"/></returns>
        public DescribeOriginGroupHealthStatusResponse DescribeOriginGroupHealthStatusSync(DescribeOriginGroupHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeOriginGroupHealthStatusResponse>(req, "DescribeOriginGroupHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版本查询源站防护接口，EdgeOne 于 2025 年 6 月 27 日已对源站防护相关接口全面升级，新版本查询源站防护接口详情请参考 [DescribeOriginACL](https://cloud.tencent.com/document/product/1552/120408)。
        /// 
        /// <p style="color: red;">注意：自 2025 年 6 月 27 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版源站防护接口。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public Task<DescribeOriginProtectionResponse> DescribeOriginProtection(DescribeOriginProtectionRequest req)
        {
            return InternalRequestAsync<DescribeOriginProtectionResponse>(req, "DescribeOriginProtection");
        }

        /// <summary>
        /// 本接口为旧版本查询源站防护接口，EdgeOne 于 2025 年 6 月 27 日已对源站防护相关接口全面升级，新版本查询源站防护接口详情请参考 [DescribeOriginACL](https://cloud.tencent.com/document/product/1552/120408)。
        /// 
        /// <p style="color: red;">注意：自 2025 年 6 月 27 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版源站防护接口。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public DescribeOriginProtectionResponse DescribeOriginProtectionSync(DescribeOriginProtectionRequest req)
        {
            return InternalRequestAsync<DescribeOriginProtectionResponse>(req, "DescribeOriginProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeOverviewL7Data）用于查询七层监控类时序流量数据。此接口待废弃，请使用 <a href="https://cloud.tencent.com/document/product/1552/80648">DescribeTimingL7AnalysisData</a> 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public Task<DescribeOverviewL7DataResponse> DescribeOverviewL7Data(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data");
        }

        /// <summary>
        /// 本接口（DescribeOverviewL7Data）用于查询七层监控类时序流量数据。此接口待废弃，请使用 <a href="https://cloud.tencent.com/document/product/1552/80648">DescribeTimingL7AnalysisData</a> 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public DescribeOverviewL7DataResponse DescribeOverviewL7DataSync(DescribeOverviewL7DataRequest req)
        {
            return InternalRequestAsync<DescribeOverviewL7DataResponse>(req, "DescribeOverviewL7Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询套餐信息列表，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribePlansRequest"/></param>
        /// <returns><see cref="DescribePlansResponse"/></returns>
        public Task<DescribePlansResponse> DescribePlans(DescribePlansRequest req)
        {
            return InternalRequestAsync<DescribePlansResponse>(req, "DescribePlans");
        }

        /// <summary>
        /// 查询套餐信息列表，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribePlansRequest"/></param>
        /// <returns><see cref="DescribePlansResponse"/></returns>
        public DescribePlansResponse DescribePlansSync(DescribePlansRequest req)
        {
            return InternalRequestAsync<DescribePlansResponse>(req, "DescribePlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePrefetchTasks 用于查询预热任务提交历史记录及执行进度，通过 CreatePrefetchTasks 接口提交的任务可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public Task<DescribePrefetchTasksResponse> DescribePrefetchTasks(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks");
        }

        /// <summary>
        /// DescribePrefetchTasks 用于查询预热任务提交历史记录及执行进度，通过 CreatePrefetchTasks 接口提交的任务可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public DescribePrefetchTasksResponse DescribePrefetchTasksSync(DescribePrefetchTasksRequest req)
        {
            return InternalRequestAsync<DescribePrefetchTasksResponse>(req, "DescribePrefetchTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 CreatePurgeTasks 接口提交的任务均可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks");
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 CreatePurgeTasks 接口提交的任务均可通过此接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口查询实时日志投递任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeLogDeliveryTasksRequest"/></param>
        /// <returns><see cref="DescribeRealtimeLogDeliveryTasksResponse"/></returns>
        public Task<DescribeRealtimeLogDeliveryTasksResponse> DescribeRealtimeLogDeliveryTasks(DescribeRealtimeLogDeliveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeRealtimeLogDeliveryTasksResponse>(req, "DescribeRealtimeLogDeliveryTasks");
        }

        /// <summary>
        /// 通过本接口查询实时日志投递任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeLogDeliveryTasksRequest"/></param>
        /// <returns><see cref="DescribeRealtimeLogDeliveryTasksResponse"/></returns>
        public DescribeRealtimeLogDeliveryTasksResponse DescribeRealtimeLogDeliveryTasksSync(DescribeRealtimeLogDeliveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeRealtimeLogDeliveryTasksResponse>(req, "DescribeRealtimeLogDeliveryTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版本查询规则引擎规则接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本查询七层加速规则接口详情请参考  [DescribeL7AccRules](https://cloud.tencent.com/document/product/1552/115820)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// 本接口为旧版本查询规则引擎规则接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本查询七层加速规则接口详情请参考  [DescribeL7AccRules](https://cloud.tencent.com/document/product/1552/115820)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，详情请参考 [RuleEngineAction](https://cloud.tencent.com/document/product/1552/80721#RuleEngineAction)。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public Task<DescribeRulesSettingResponse> DescribeRulesSetting(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting");
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，详情请参考 [RuleEngineAction](https://cloud.tencent.com/document/product/1552/80721#RuleEngineAction)。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public DescribeRulesSettingResponse DescribeRulesSettingSync(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询站点下的 API 资源。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIResourceResponse"/></returns>
        public Task<DescribeSecurityAPIResourceResponse> DescribeSecurityAPIResource(DescribeSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIResourceResponse>(req, "DescribeSecurityAPIResource");
        }

        /// <summary>
        /// 查询站点下的 API 资源。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIResourceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIResourceResponse"/></returns>
        public DescribeSecurityAPIResourceResponse DescribeSecurityAPIResourceSync(DescribeSecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIResourceResponse>(req, "DescribeSecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询站点下的 API 服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIServiceResponse"/></returns>
        public Task<DescribeSecurityAPIServiceResponse> DescribeSecurityAPIService(DescribeSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIServiceResponse>(req, "DescribeSecurityAPIService");
        }

        /// <summary>
        /// 查询站点下的 API 服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAPIServiceRequest"/></param>
        /// <returns><see cref="DescribeSecurityAPIServiceResponse"/></returns>
        public DescribeSecurityAPIServiceResponse DescribeSecurityAPIServiceSync(DescribeSecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAPIServiceResponse>(req, "DescribeSecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询客户端认证选项配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DescribeSecurityClientAttesterResponse"/></returns>
        public Task<DescribeSecurityClientAttesterResponse> DescribeSecurityClientAttester(DescribeSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DescribeSecurityClientAttesterResponse>(req, "DescribeSecurityClientAttester");
        }

        /// <summary>
        /// 查询客户端认证选项配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityClientAttesterRequest"/></param>
        /// <returns><see cref="DescribeSecurityClientAttesterResponse"/></returns>
        public DescribeSecurityClientAttesterResponse DescribeSecurityClientAttesterSync(DescribeSecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<DescribeSecurityClientAttesterResponse>(req, "DescribeSecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全 IP 组的配置信息，包括安全 IP 组的 ID、名称和内容。本接口的查询结果中，每个 IP 组最多只返回 2000 个 IP / 网段。如果存在超过 2000 个 IP / 网段的超大 IP 组，请调用 DescribeSecurityIPGroupContent 进行分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public Task<DescribeSecurityIPGroupResponse> DescribeSecurityIPGroup(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup");
        }

        /// <summary>
        /// 查询安全 IP 组的配置信息，包括安全 IP 组的 ID、名称和内容。本接口的查询结果中，每个 IP 组最多只返回 2000 个 IP / 网段。如果存在超过 2000 个 IP / 网段的超大 IP 组，请调用 DescribeSecurityIPGroupContent 进行分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public DescribeSecurityIPGroupResponse DescribeSecurityIPGroupSync(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于分页查询指定 IP 组中的 IP 地址列表。当 IP 组中的 IP 地址数量超过 2000 个时，可以使用此接口进行分页查询，以获取完整的 IP 地址列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupContentRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupContentResponse"/></returns>
        public Task<DescribeSecurityIPGroupContentResponse> DescribeSecurityIPGroupContent(DescribeSecurityIPGroupContentRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupContentResponse>(req, "DescribeSecurityIPGroupContent");
        }

        /// <summary>
        /// 该接口用于分页查询指定 IP 组中的 IP 地址列表。当 IP 组中的 IP 地址数量超过 2000 个时，可以使用此接口进行分页查询，以获取完整的 IP 地址列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupContentRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupContentResponse"/></returns>
        public DescribeSecurityIPGroupContentResponse DescribeSecurityIPGroupContentSync(DescribeSecurityIPGroupContentRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupContentResponse>(req, "DescribeSecurityIPGroupContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口已废弃，将于 2024 年 6 月 30 日停止服务。请使用 [查询安全 IP 组
        /// ](https://cloud.tencent.com/document/product/1552/105866) 接口。
        /// 
        /// 查询 IP 组的配置信息，包括 IP 组名称、 IP 组内容、 IP 组归属站点。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupInfoResponse"/></returns>
        public Task<DescribeSecurityIPGroupInfoResponse> DescribeSecurityIPGroupInfo(DescribeSecurityIPGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupInfoResponse>(req, "DescribeSecurityIPGroupInfo");
        }

        /// <summary>
        /// 接口已废弃，将于 2024 年 6 月 30 日停止服务。请使用 [查询安全 IP 组
        /// ](https://cloud.tencent.com/document/product/1552/105866) 接口。
        /// 
        /// 查询 IP 组的配置信息，包括 IP 组名称、 IP 组内容、 IP 组归属站点。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupInfoResponse"/></returns>
        public DescribeSecurityIPGroupInfoResponse DescribeSecurityIPGroupInfoSync(DescribeSecurityIPGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupInfoResponse>(req, "DescribeSecurityIPGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityJSInjectionRuleResponse"/></returns>
        public Task<DescribeSecurityJSInjectionRuleResponse> DescribeSecurityJSInjectionRule(DescribeSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityJSInjectionRuleResponse>(req, "DescribeSecurityJSInjectionRule");
        }

        /// <summary>
        /// 查询 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityJSInjectionRuleResponse"/></returns>
        public DescribeSecurityJSInjectionRuleResponse DescribeSecurityJSInjectionRuleSync(DescribeSecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityJSInjectionRuleResponse>(req, "DescribeSecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全防护配置详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicy(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy");
        }

        /// <summary>
        /// 查询安全防护配置详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public DescribeSecurityPolicyResponse DescribeSecurityPolicySync(DescribeSecurityPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityPolicyResponse>(req, "DescribeSecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定策略模板的绑定关系列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTemplateBindingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTemplateBindingsResponse"/></returns>
        public Task<DescribeSecurityTemplateBindingsResponse> DescribeSecurityTemplateBindings(DescribeSecurityTemplateBindingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTemplateBindingsResponse>(req, "DescribeSecurityTemplateBindings");
        }

        /// <summary>
        /// 查询指定策略模板的绑定关系列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTemplateBindingsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTemplateBindingsResponse"/></returns>
        public DescribeSecurityTemplateBindingsResponse DescribeSecurityTemplateBindingsSync(DescribeSecurityTemplateBindingsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTemplateBindingsResponse>(req, "DescribeSecurityTemplateBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTimingL4Data）用于查询四层时序流量数据列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public Task<DescribeTimingL4DataResponse> DescribeTimingL4Data(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data");
        }

        /// <summary>
        /// 本接口（DescribeTimingL4Data）用于查询四层时序流量数据列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public DescribeTimingL4DataResponse DescribeTimingL4DataSync(DescribeTimingL4DataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL4DataResponse>(req, "DescribeTimingL4Data")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询七层域名业务的时序数据。
        /// 注意：
        /// 1. 本接口查询数据有 10 分钟左右延迟，建议拉取当前时间 10 分钟以前的数据。
        /// 2. 本接口默认返回防护后的流量请求数据，用户可在 `Filters.mitigatedByWebSecurity` 中自定义查询已防护缓释的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public Task<DescribeTimingL7AnalysisDataResponse> DescribeTimingL7AnalysisData(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData");
        }

        /// <summary>
        /// 本接口用于查询七层域名业务的时序数据。
        /// 注意：
        /// 1. 本接口查询数据有 10 分钟左右延迟，建议拉取当前时间 10 分钟以前的数据。
        /// 2. 本接口默认返回防护后的流量请求数据，用户可在 `Filters.mitigatedByWebSecurity` 中自定义查询已防护缓释的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public DescribeTimingL7AnalysisDataResponse DescribeTimingL7AnalysisDataSync(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询七层缓存分析时序类流量数据。此接口待废弃，请使用 <a href="https://cloud.tencent.com/document/product/1552/80648">DescribeTimingL7AnalysisData</a> 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public Task<DescribeTimingL7CacheDataResponse> DescribeTimingL7CacheData(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData");
        }

        /// <summary>
        /// 本接口用于查询七层缓存分析时序类流量数据。此接口待废弃，请使用 <a href="https://cloud.tencent.com/document/product/1552/80648">DescribeTimingL7AnalysisData</a> 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public DescribeTimingL7CacheDataResponse DescribeTimingL7CacheDataSync(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询七层域名业务按照指定维度的 topN 数据。
        /// 注意：
        /// 1. 本接口查询数据有 10 分钟左右延迟，建议拉取当前时间 10 分钟以前的数据。
        /// 2. 本接口默认返回防护后的流量请求数据，用户可在 `Filters.mitigatedByWebSecurity` 中自定义查询已防护缓释的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public Task<DescribeTopL7AnalysisDataResponse> DescribeTopL7AnalysisData(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData");
        }

        /// <summary>
        /// 本接口用于查询七层域名业务按照指定维度的 topN 数据。
        /// 注意：
        /// 1. 本接口查询数据有 10 分钟左右延迟，建议拉取当前时间 10 分钟以前的数据。
        /// 2. 本接口默认返回防护后的流量请求数据，用户可在 `Filters.mitigatedByWebSecurity` 中自定义查询已防护缓释的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public DescribeTopL7AnalysisDataResponse DescribeTopL7AnalysisDataSync(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询七层缓存分析 topN 数据。此接口待废弃，请使用 <a href="https://cloud.tencent.com/document/product/1552/80646"> DescribeTopL7AnalysisData</a> 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public Task<DescribeTopL7CacheDataResponse> DescribeTopL7CacheData(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData");
        }

        /// <summary>
        /// 本接口用于查询七层缓存分析 topN 数据。此接口待废弃，请使用 <a href="https://cloud.tencent.com/document/product/1552/80646"> DescribeTopL7AnalysisData</a> 接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public DescribeTopL7CacheDataResponse DescribeTopL7CacheDataSync(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全策略配置模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplateResponse"/></returns>
        public Task<DescribeWebSecurityTemplateResponse> DescribeWebSecurityTemplate(DescribeWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplateResponse>(req, "DescribeWebSecurityTemplate");
        }

        /// <summary>
        /// 查询安全策略配置模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplateResponse"/></returns>
        public DescribeWebSecurityTemplateResponse DescribeWebSecurityTemplateSync(DescribeWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplateResponse>(req, "DescribeWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全策略配置模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplatesResponse"/></returns>
        public Task<DescribeWebSecurityTemplatesResponse> DescribeWebSecurityTemplates(DescribeWebSecurityTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplatesResponse>(req, "DescribeWebSecurityTemplates");
        }

        /// <summary>
        /// 查询安全策略配置模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebSecurityTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWebSecurityTemplatesResponse"/></returns>
        public DescribeWebSecurityTemplatesResponse DescribeWebSecurityTemplatesSync(DescribeWebSecurityTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeWebSecurityTemplatesResponse>(req, "DescribeWebSecurityTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询站点配置项导入结果接口，本接口用于站点配置导入接口（ImportZoneConfig）的结果查询。该功能仅支持标准版或企业版套餐的站点使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneConfigImportResultRequest"/></param>
        /// <returns><see cref="DescribeZoneConfigImportResultResponse"/></returns>
        public Task<DescribeZoneConfigImportResultResponse> DescribeZoneConfigImportResult(DescribeZoneConfigImportResultRequest req)
        {
            return InternalRequestAsync<DescribeZoneConfigImportResultResponse>(req, "DescribeZoneConfigImportResult");
        }

        /// <summary>
        /// 查询站点配置项导入结果接口，本接口用于站点配置导入接口（ImportZoneConfig）的结果查询。该功能仅支持标准版或企业版套餐的站点使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneConfigImportResultRequest"/></param>
        /// <returns><see cref="DescribeZoneConfigImportResultResponse"/></returns>
        public DescribeZoneConfigImportResultResponse DescribeZoneConfigImportResultSync(DescribeZoneConfigImportResultRequest req)
        {
            return InternalRequestAsync<DescribeZoneConfigImportResultResponse>(req, "DescribeZoneConfigImportResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，详情请参考 [DescribeL7AccSetting](https://cloud.tencent.com/document/product/1552/115819)。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public Task<DescribeZoneSettingResponse> DescribeZoneSetting(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting");
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，详情请参考 [DescribeL7AccSetting](https://cloud.tencent.com/document/product/1552/115819)。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public DescribeZoneSettingResponse DescribeZoneSettingSync(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询您有权限的站点信息。可根据不同查询条件筛选站点。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 该接口用于查询您有权限的站点信息。可根据不同查询条件筛选站点。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当您需要停止 Edgeone 套餐的计费，可以通过该接口销毁计费套餐。
        /// > 销毁计费套餐需要满足以下条件：
        ///     1.套餐已过期（企业版套餐除外）；
        ///     2.套餐下所有站点均已关闭或删除。
        /// 
        /// > 站点状态可以通过 [查询站点列表](https://cloud.tencent.com/document/product/1552/80713) 接口进行查询
        /// 停用站点可以通过 [切换站点状态](https://cloud.tencent.com/document/product/1552/80707) 接口将站点切换至关闭状态
        /// 删除站点可以通过 [删除站点](https://cloud.tencent.com/document/product/1552/80717) 接口将站点删除
        /// </summary>
        /// <param name="req"><see cref="DestroyPlanRequest"/></param>
        /// <returns><see cref="DestroyPlanResponse"/></returns>
        public Task<DestroyPlanResponse> DestroyPlan(DestroyPlanRequest req)
        {
            return InternalRequestAsync<DestroyPlanResponse>(req, "DestroyPlan");
        }

        /// <summary>
        /// 当您需要停止 Edgeone 套餐的计费，可以通过该接口销毁计费套餐。
        /// > 销毁计费套餐需要满足以下条件：
        ///     1.套餐已过期（企业版套餐除外）；
        ///     2.套餐下所有站点均已关闭或删除。
        /// 
        /// > 站点状态可以通过 [查询站点列表](https://cloud.tencent.com/document/product/1552/80713) 接口进行查询
        /// 停用站点可以通过 [切换站点状态](https://cloud.tencent.com/document/product/1552/80707) 接口将站点切换至关闭状态
        /// 删除站点可以通过 [删除站点](https://cloud.tencent.com/document/product/1552/80717) 接口将站点删除
        /// </summary>
        /// <param name="req"><see cref="DestroyPlanRequest"/></param>
        /// <returns><see cref="DestroyPlanResponse"/></returns>
        public DestroyPlanResponse DestroyPlanSync(DestroyPlanRequest req)
        {
            return InternalRequestAsync<DestroyPlanResponse>(req, "DestroyPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于关闭站点的源站防护功能。停用后，相关资源不再仅使用「源站防护」提供的回源 IP 网段请求您的源站，同时停止发送回源 IP 网段更新通知。
        /// </summary>
        /// <param name="req"><see cref="DisableOriginACLRequest"/></param>
        /// <returns><see cref="DisableOriginACLResponse"/></returns>
        public Task<DisableOriginACLResponse> DisableOriginACL(DisableOriginACLRequest req)
        {
            return InternalRequestAsync<DisableOriginACLResponse>(req, "DisableOriginACL");
        }

        /// <summary>
        /// 本接口用于关闭站点的源站防护功能。停用后，相关资源不再仅使用「源站防护」提供的回源 IP 网段请求您的源站，同时停止发送回源 IP 网段更新通知。
        /// </summary>
        /// <param name="req"><see cref="DisableOriginACLRequest"/></param>
        /// <returns><see cref="DisableOriginACLResponse"/></returns>
        public DisableOriginACLResponse DisableOriginACLSync(DisableOriginACLRequest req)
        {
            return InternalRequestAsync<DisableOriginACLResponse>(req, "DisableOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DownloadL4Logs）用于下载四层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public Task<DownloadL4LogsResponse> DownloadL4Logs(DownloadL4LogsRequest req)
        {
            return InternalRequestAsync<DownloadL4LogsResponse>(req, "DownloadL4Logs");
        }

        /// <summary>
        /// 本接口（DownloadL4Logs）用于下载四层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public DownloadL4LogsResponse DownloadL4LogsSync(DownloadL4LogsRequest req)
        {
            return InternalRequestAsync<DownloadL4LogsResponse>(req, "DownloadL4Logs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DownloadL7Logs）下载七层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public Task<DownloadL7LogsResponse> DownloadL7Logs(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs");
        }

        /// <summary>
        /// 本接口（DownloadL7Logs）下载七层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public DownloadL7LogsResponse DownloadL7LogsSync(DownloadL7LogsRequest req)
        {
            return InternalRequestAsync<DownloadL7LogsResponse>(req, "DownloadL7Logs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于站点首次开启源站防护，启用后 EdgeOne 将会使用特定的回源 IP 网段为七层加速域名/四层代理实例回源。单次支持提交的七层加速域名的数量最大为 200，四层代理实例的数量最大为 100，支持七层加速域名/四层代理实例混合提交，总实例个数最大为 200。如需要启用超过 200 个资源，可先通过指定资源的方式以最大数量启用，剩余资源通过 ModifyOriginACL 接口启用。后续新增七层加速域名/四层代理实例均请通过 ModifyOriginACL 接口配置。
        /// 
        /// 注意：
        /// - 调用本接口视为同意 [源站防护启用特别约定](https://cloud.tencent.com/document/product/1552/120141)；
        /// - 回源 IP 网段会不定期变更，EdgeOne 将在回源 IP 网段变更前 14 天、前 7 天、前 3 天和前 1 天分别通过站内信、短信、邮件等一种或多种方式发起通知，为了能正常收到回源 IP 网段的变更通知，请务必确保您在 [腾讯云消息中心控制台](https://console.cloud.tencent.com/message)内，已勾选边缘安全加速平台 EO 的产品服务相关消息通知，并配置正确的消息接收人。配置方式请参考 [消息订阅管理](https://cloud.tencent.com/document/product/567/43476)。
        /// </summary>
        /// <param name="req"><see cref="EnableOriginACLRequest"/></param>
        /// <returns><see cref="EnableOriginACLResponse"/></returns>
        public Task<EnableOriginACLResponse> EnableOriginACL(EnableOriginACLRequest req)
        {
            return InternalRequestAsync<EnableOriginACLResponse>(req, "EnableOriginACL");
        }

        /// <summary>
        /// 本接口用于站点首次开启源站防护，启用后 EdgeOne 将会使用特定的回源 IP 网段为七层加速域名/四层代理实例回源。单次支持提交的七层加速域名的数量最大为 200，四层代理实例的数量最大为 100，支持七层加速域名/四层代理实例混合提交，总实例个数最大为 200。如需要启用超过 200 个资源，可先通过指定资源的方式以最大数量启用，剩余资源通过 ModifyOriginACL 接口启用。后续新增七层加速域名/四层代理实例均请通过 ModifyOriginACL 接口配置。
        /// 
        /// 注意：
        /// - 调用本接口视为同意 [源站防护启用特别约定](https://cloud.tencent.com/document/product/1552/120141)；
        /// - 回源 IP 网段会不定期变更，EdgeOne 将在回源 IP 网段变更前 14 天、前 7 天、前 3 天和前 1 天分别通过站内信、短信、邮件等一种或多种方式发起通知，为了能正常收到回源 IP 网段的变更通知，请务必确保您在 [腾讯云消息中心控制台](https://console.cloud.tencent.com/message)内，已勾选边缘安全加速平台 EO 的产品服务相关消息通知，并配置正确的消息接收人。配置方式请参考 [消息订阅管理](https://cloud.tencent.com/document/product/567/43476)。
        /// </summary>
        /// <param name="req"><see cref="EnableOriginACLRequest"/></param>
        /// <returns><see cref="EnableOriginACLResponse"/></returns>
        public EnableOriginACLResponse EnableOriginACLSync(EnableOriginACLRequest req)
        {
            return InternalRequestAsync<EnableOriginACLResponse>(req, "EnableOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出站点配置接口，本接口支持用户根据需要的配置项进行配置导出，导出的配置用于导入站点配置接口（ImportZoneConfig）进行配置导入。该功能仅支持标准版和企业版套餐站点使用。
        /// </summary>
        /// <param name="req"><see cref="ExportZoneConfigRequest"/></param>
        /// <returns><see cref="ExportZoneConfigResponse"/></returns>
        public Task<ExportZoneConfigResponse> ExportZoneConfig(ExportZoneConfigRequest req)
        {
            return InternalRequestAsync<ExportZoneConfigResponse>(req, "ExportZoneConfig");
        }

        /// <summary>
        /// 导出站点配置接口，本接口支持用户根据需要的配置项进行配置导出，导出的配置用于导入站点配置接口（ImportZoneConfig）进行配置导入。该功能仅支持标准版和企业版套餐站点使用。
        /// </summary>
        /// <param name="req"><see cref="ExportZoneConfigRequest"/></param>
        /// <returns><see cref="ExportZoneConfigResponse"/></returns>
        public ExportZoneConfigResponse ExportZoneConfigSync(ExportZoneConfigRequest req)
        {
            return InternalRequestAsync<ExportZoneConfigResponse>(req, "ExportZoneConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作边缘函数运行环境，支持环境变量的相关设置。
        /// 设置环境变量后，可在函数代码中使用，具体参考 [边缘函数引入环境变量](https://cloud.tencent.com/document/product/1552/109151#0151fd9a-8b0e-407b-ae37-54553a60ded6)。
        /// </summary>
        /// <param name="req"><see cref="HandleFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="HandleFunctionRuntimeEnvironmentResponse"/></returns>
        public Task<HandleFunctionRuntimeEnvironmentResponse> HandleFunctionRuntimeEnvironment(HandleFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<HandleFunctionRuntimeEnvironmentResponse>(req, "HandleFunctionRuntimeEnvironment");
        }

        /// <summary>
        /// 操作边缘函数运行环境，支持环境变量的相关设置。
        /// 设置环境变量后，可在函数代码中使用，具体参考 [边缘函数引入环境变量](https://cloud.tencent.com/document/product/1552/109151#0151fd9a-8b0e-407b-ae37-54553a60ded6)。
        /// </summary>
        /// <param name="req"><see cref="HandleFunctionRuntimeEnvironmentRequest"/></param>
        /// <returns><see cref="HandleFunctionRuntimeEnvironmentResponse"/></returns>
        public HandleFunctionRuntimeEnvironmentResponse HandleFunctionRuntimeEnvironmentSync(HandleFunctionRuntimeEnvironmentRequest req)
        {
            return InternalRequestAsync<HandleFunctionRuntimeEnvironmentResponse>(req, "HandleFunctionRuntimeEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于验证站点所有权。
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public Task<IdentifyZoneResponse> IdentifyZone(IdentifyZoneRequest req)
        {
            return InternalRequestAsync<IdentifyZoneResponse>(req, "IdentifyZone");
        }

        /// <summary>
        /// 用于验证站点所有权。
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public IdentifyZoneResponse IdentifyZoneSync(IdentifyZoneRequest req)
        {
            return InternalRequestAsync<IdentifyZoneResponse>(req, "IdentifyZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入站点配置接口，本接口支持站点配置文件的快速导入，发起导入后接口会返回对应的任务 ID（TaskId），用户需通过查询站点配置导入结果接口（DescribeZoneConfigImportResult）获取本次导入任务执行的结果。该功能仅支持标准版和企业版套餐站点使用。
        /// </summary>
        /// <param name="req"><see cref="ImportZoneConfigRequest"/></param>
        /// <returns><see cref="ImportZoneConfigResponse"/></returns>
        public Task<ImportZoneConfigResponse> ImportZoneConfig(ImportZoneConfigRequest req)
        {
            return InternalRequestAsync<ImportZoneConfigResponse>(req, "ImportZoneConfig");
        }

        /// <summary>
        /// 导入站点配置接口，本接口支持站点配置文件的快速导入，发起导入后接口会返回对应的任务 ID（TaskId），用户需通过查询站点配置导入结果接口（DescribeZoneConfigImportResult）获取本次导入任务执行的结果。该功能仅支持标准版和企业版套餐站点使用。
        /// </summary>
        /// <param name="req"><see cref="ImportZoneConfigRequest"/></param>
        /// <returns><see cref="ImportZoneConfigResponse"/></returns>
        public ImportZoneConfigResponse ImportZoneConfigSync(ImportZoneConfigRequest req)
        {
            return InternalRequestAsync<ImportZoneConfigResponse>(req, "ImportZoneConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当您的套餐绑定的站点数，或配置的 Web 防护 - 自定义规则 - 精准匹配策略的规则数，或 Web 防护 - 速率限制 - 精准速率限制模块的规则数达到套餐允许的配额上限，可以通过该接口增购对应配额。
        /// > 该接口该仅支持企业版套餐。
        /// </summary>
        /// <param name="req"><see cref="IncreasePlanQuotaRequest"/></param>
        /// <returns><see cref="IncreasePlanQuotaResponse"/></returns>
        public Task<IncreasePlanQuotaResponse> IncreasePlanQuota(IncreasePlanQuotaRequest req)
        {
            return InternalRequestAsync<IncreasePlanQuotaResponse>(req, "IncreasePlanQuota");
        }

        /// <summary>
        /// 当您的套餐绑定的站点数，或配置的 Web 防护 - 自定义规则 - 精准匹配策略的规则数，或 Web 防护 - 速率限制 - 精准速率限制模块的规则数达到套餐允许的配额上限，可以通过该接口增购对应配额。
        /// > 该接口该仅支持企业版套餐。
        /// </summary>
        /// <param name="req"><see cref="IncreasePlanQuotaRequest"/></param>
        /// <returns><see cref="IncreasePlanQuotaResponse"/></returns>
        public IncreasePlanQuotaResponse IncreasePlanQuotaSync(IncreasePlanQuotaRequest req)
        {
            return InternalRequestAsync<IncreasePlanQuotaResponse>(req, "IncreasePlanQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改加速域名信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public Task<ModifyAccelerationDomainResponse> ModifyAccelerationDomain(ModifyAccelerationDomainRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainResponse>(req, "ModifyAccelerationDomain");
        }

        /// <summary>
        /// 修改加速域名信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public ModifyAccelerationDomainResponse ModifyAccelerationDomainSync(ModifyAccelerationDomainRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainResponse>(req, "ModifyAccelerationDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改加速域名状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public Task<ModifyAccelerationDomainStatusesResponse> ModifyAccelerationDomainStatuses(ModifyAccelerationDomainStatusesRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainStatusesResponse>(req, "ModifyAccelerationDomainStatuses");
        }

        /// <summary>
        /// 批量修改加速域名状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public ModifyAccelerationDomainStatusesResponse ModifyAccelerationDomainStatusesSync(ModifyAccelerationDomainStatusesRequest req)
        {
            return InternalRequestAsync<ModifyAccelerationDomainStatusesResponse>(req, "ModifyAccelerationDomainStatuses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改别称域名。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public Task<ModifyAliasDomainResponse> ModifyAliasDomain(ModifyAliasDomainRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainResponse>(req, "ModifyAliasDomain");
        }

        /// <summary>
        /// 修改别称域名。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public ModifyAliasDomainResponse ModifyAliasDomainSync(ModifyAliasDomainRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainResponse>(req, "ModifyAliasDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改别称域名状态。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public Task<ModifyAliasDomainStatusResponse> ModifyAliasDomainStatus(ModifyAliasDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainStatusResponse>(req, "ModifyAliasDomainStatus");
        }

        /// <summary>
        /// 修改别称域名状态。
        /// 该功能仅企业版套餐支持，并且该功能当前仍在内测中，如需使用，请[联系我们](https://cloud.tencent.com/online-service?from=connect-us)。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public ModifyAliasDomainStatusResponse ModifyAliasDomainStatusSync(ModifyAliasDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainStatusResponse>(req, "ModifyAliasDomainStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理实例
        /// ](https://cloud.tencent.com/document/product/1552/103411) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public Task<ModifyApplicationProxyResponse> ModifyApplicationProxy(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理实例
        /// ](https://cloud.tencent.com/document/product/1552/103411) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public ModifyApplicationProxyResponse ModifyApplicationProxySync(ModifyApplicationProxyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyResponse>(req, "ModifyApplicationProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理转发规则
        /// ](https://cloud.tencent.com/document/product/1552/103410) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public Task<ModifyApplicationProxyRuleResponse> ModifyApplicationProxyRule(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理转发规则
        /// ](https://cloud.tencent.com/document/product/1552/103410) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public ModifyApplicationProxyRuleResponse ModifyApplicationProxyRuleSync(ModifyApplicationProxyRuleRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleResponse>(req, "ModifyApplicationProxyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理转发规则状态
        /// ](https://cloud.tencent.com/document/product/1552/103409) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public Task<ModifyApplicationProxyRuleStatusResponse> ModifyApplicationProxyRuleStatus(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理转发规则状态
        /// ](https://cloud.tencent.com/document/product/1552/103409) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public ModifyApplicationProxyRuleStatusResponse ModifyApplicationProxyRuleStatusSync(ModifyApplicationProxyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyRuleStatusResponse>(req, "ModifyApplicationProxyRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理实例状态](https://cloud.tencent.com/document/product/1552/103408) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public Task<ModifyApplicationProxyStatusResponse> ModifyApplicationProxyStatus(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus");
        }

        /// <summary>
        /// 本接口为旧版，如需调用请尽快迁移至新版，详情请参考 [修改四层代理实例状态](https://cloud.tencent.com/document/product/1552/103408) 。
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public ModifyApplicationProxyStatusResponse ModifyApplicationProxyStatusSync(ModifyApplicationProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProxyStatusResponse>(req, "ModifyApplicationProxyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改内容标识符，仅支持修改描述。该功能仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentIdentifierRequest"/></param>
        /// <returns><see cref="ModifyContentIdentifierResponse"/></returns>
        public Task<ModifyContentIdentifierResponse> ModifyContentIdentifier(ModifyContentIdentifierRequest req)
        {
            return InternalRequestAsync<ModifyContentIdentifierResponse>(req, "ModifyContentIdentifier");
        }

        /// <summary>
        /// 修改内容标识符，仅支持修改描述。该功能仅白名单开放。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentIdentifierRequest"/></param>
        /// <returns><see cref="ModifyContentIdentifierResponse"/></returns>
        public ModifyContentIdentifierResponse ModifyContentIdentifierSync(ModifyContentIdentifierRequest req)
        {
            return InternalRequestAsync<ModifyContentIdentifierResponse>(req, "ModifyContentIdentifier")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自定义错误页面。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomErrorPageRequest"/></param>
        /// <returns><see cref="ModifyCustomErrorPageResponse"/></returns>
        public Task<ModifyCustomErrorPageResponse> ModifyCustomErrorPage(ModifyCustomErrorPageRequest req)
        {
            return InternalRequestAsync<ModifyCustomErrorPageResponse>(req, "ModifyCustomErrorPage");
        }

        /// <summary>
        /// 修改自定义错误页面。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomErrorPageRequest"/></param>
        /// <returns><see cref="ModifyCustomErrorPageResponse"/></returns>
        public ModifyCustomErrorPageResponse ModifyCustomErrorPageSync(ModifyCustomErrorPageRequest req)
        {
            return InternalRequestAsync<ModifyCustomErrorPageResponse>(req, "ModifyCustomErrorPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改站点的独立 DDoS 防护。
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSProtectionRequest"/></param>
        /// <returns><see cref="ModifyDDoSProtectionResponse"/></returns>
        public Task<ModifyDDoSProtectionResponse> ModifyDDoSProtection(ModifyDDoSProtectionRequest req)
        {
            return InternalRequestAsync<ModifyDDoSProtectionResponse>(req, "ModifyDDoSProtection");
        }

        /// <summary>
        /// 修改站点的独立 DDoS 防护。
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSProtectionRequest"/></param>
        /// <returns><see cref="ModifyDDoSProtectionResponse"/></returns>
        public ModifyDDoSProtectionResponse ModifyDDoSProtectionSync(ModifyDDoSProtectionRequest req)
        {
            return InternalRequestAsync<ModifyDDoSProtectionResponse>(req, "ModifyDDoSProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您可以通过本接口批量修改 DNS 记录。
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsResponse"/></returns>
        public Task<ModifyDnsRecordsResponse> ModifyDnsRecords(ModifyDnsRecordsRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsResponse>(req, "ModifyDnsRecords");
        }

        /// <summary>
        /// 您可以通过本接口批量修改 DNS 记录。
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsResponse"/></returns>
        public ModifyDnsRecordsResponse ModifyDnsRecordsSync(ModifyDnsRecordsRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsResponse>(req, "ModifyDnsRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您可以通过本接口批量修改 DNS 记录的状态，批量对记录进行开启和停用。
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsStatusResponse"/></returns>
        public Task<ModifyDnsRecordsStatusResponse> ModifyDnsRecordsStatus(ModifyDnsRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsStatusResponse>(req, "ModifyDnsRecordsStatus");
        }

        /// <summary>
        /// 您可以通过本接口批量修改 DNS 记录的状态，批量对记录进行开启和停用。
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordsStatusRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordsStatusResponse"/></returns>
        public ModifyDnsRecordsStatusResponse ModifyDnsRecordsStatusSync(ModifyDnsRecordsStatusRequest req)
        {
            return InternalRequestAsync<ModifyDnsRecordsStatusResponse>(req, "ModifyDnsRecordsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边缘函数，支持修改函数的内容及描述信息，修改且重新部署后，函数立刻生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRequest"/></param>
        /// <returns><see cref="ModifyFunctionResponse"/></returns>
        public Task<ModifyFunctionResponse> ModifyFunction(ModifyFunctionRequest req)
        {
            return InternalRequestAsync<ModifyFunctionResponse>(req, "ModifyFunction");
        }

        /// <summary>
        /// 修改边缘函数，支持修改函数的内容及描述信息，修改且重新部署后，函数立刻生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRequest"/></param>
        /// <returns><see cref="ModifyFunctionResponse"/></returns>
        public ModifyFunctionResponse ModifyFunctionSync(ModifyFunctionRequest req)
        {
            return InternalRequestAsync<ModifyFunctionResponse>(req, "ModifyFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边缘函数触发规则，支持修改规则条件、执行函数以及描述信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRuleRequest"/></param>
        /// <returns><see cref="ModifyFunctionRuleResponse"/></returns>
        public Task<ModifyFunctionRuleResponse> ModifyFunctionRule(ModifyFunctionRuleRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRuleResponse>(req, "ModifyFunctionRule");
        }

        /// <summary>
        /// 修改边缘函数触发规则，支持修改规则条件、执行函数以及描述信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRuleRequest"/></param>
        /// <returns><see cref="ModifyFunctionRuleResponse"/></returns>
        public ModifyFunctionRuleResponse ModifyFunctionRuleSync(ModifyFunctionRuleRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRuleResponse>(req, "ModifyFunctionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改边缘函数触发规则的优先级。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyFunctionRulePriorityResponse"/></returns>
        public Task<ModifyFunctionRulePriorityResponse> ModifyFunctionRulePriority(ModifyFunctionRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRulePriorityResponse>(req, "ModifyFunctionRulePriority");
        }

        /// <summary>
        /// 修改边缘函数触发规则的优先级。
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyFunctionRulePriorityResponse"/></returns>
        public ModifyFunctionRulePriorityResponse ModifyFunctionRulePrioritySync(ModifyFunctionRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyFunctionRulePriorityResponse>(req, "ModifyFunctionRulePriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完成域名创建之后，您可以为域名配置自有证书，也可以使用 EdgeOne 为您提供的 [免费证书](https://cloud.tencent.com/document/product/1552/90437)。
        /// 如果您需要配置自有证书，请先将证书上传至 [SSL证书控制台](https://console.cloud.tencent.com/certoverview)，然后在本接口中传入对应的证书 ID。详情参考 [部署自有证书至 EdgeOne 域名
        /// ](https://cloud.tencent.com/document/product/1552/88874)。
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public Task<ModifyHostsCertificateResponse> ModifyHostsCertificate(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate");
        }

        /// <summary>
        /// 完成域名创建之后，您可以为域名配置自有证书，也可以使用 EdgeOne 为您提供的 [免费证书](https://cloud.tencent.com/document/product/1552/90437)。
        /// 如果您需要配置自有证书，请先将证书上传至 [SSL证书控制台](https://console.cloud.tencent.com/certoverview)，然后在本接口中传入对应的证书 ID。详情参考 [部署自有证书至 EdgeOne 域名
        /// ](https://cloud.tencent.com/document/product/1552/88874)。
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public ModifyHostsCertificateResponse ModifyHostsCertificateSync(ModifyHostsCertificateRequest req)
        {
            return InternalRequestAsync<ModifyHostsCertificateResponse>(req, "ModifyHostsCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改四层代理实例的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyResponse"/></returns>
        public Task<ModifyL4ProxyResponse> ModifyL4Proxy(ModifyL4ProxyRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyResponse>(req, "ModifyL4Proxy");
        }

        /// <summary>
        /// 用于修改四层代理实例的配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyResponse"/></returns>
        public ModifyL4ProxyResponse ModifyL4ProxySync(ModifyL4ProxyRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyResponse>(req, "ModifyL4Proxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改四层代理转发规则，支持单条或者批量修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesResponse"/></returns>
        public Task<ModifyL4ProxyRulesResponse> ModifyL4ProxyRules(ModifyL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesResponse>(req, "ModifyL4ProxyRules");
        }

        /// <summary>
        /// 用于修改四层代理转发规则，支持单条或者批量修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesResponse"/></returns>
        public ModifyL4ProxyRulesResponse ModifyL4ProxyRulesSync(ModifyL4ProxyRulesRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesResponse>(req, "ModifyL4ProxyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于启用/停用四层代理转发规则状态，支持单条或者批量操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesStatusResponse"/></returns>
        public Task<ModifyL4ProxyRulesStatusResponse> ModifyL4ProxyRulesStatus(ModifyL4ProxyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesStatusResponse>(req, "ModifyL4ProxyRulesStatus");
        }

        /// <summary>
        /// 用于启用/停用四层代理转发规则状态，支持单条或者批量操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyRulesStatusResponse"/></returns>
        public ModifyL4ProxyRulesStatusResponse ModifyL4ProxyRulesStatusSync(ModifyL4ProxyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyRulesStatusResponse>(req, "ModifyL4ProxyRulesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于启用/停用四层代理实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyStatusResponse"/></returns>
        public Task<ModifyL4ProxyStatusResponse> ModifyL4ProxyStatus(ModifyL4ProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyStatusResponse>(req, "ModifyL4ProxyStatus");
        }

        /// <summary>
        /// 用于启用/停用四层代理实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyL4ProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyL4ProxyStatusResponse"/></returns>
        public ModifyL4ProxyStatusResponse ModifyL4ProxyStatusSync(ModifyL4ProxyStatusRequest req)
        {
            return InternalRequestAsync<ModifyL4ProxyStatusResponse>(req, "ModifyL4ProxyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改[规则引擎](https://cloud.tencent.com/document/product/1552/70901)中的规则，单次仅支持修改单条规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRuleRequest"/></param>
        /// <returns><see cref="ModifyL7AccRuleResponse"/></returns>
        public Task<ModifyL7AccRuleResponse> ModifyL7AccRule(ModifyL7AccRuleRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRuleResponse>(req, "ModifyL7AccRule");
        }

        /// <summary>
        /// 本接口用于修改[规则引擎](https://cloud.tencent.com/document/product/1552/70901)中的规则，单次仅支持修改单条规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRuleRequest"/></param>
        /// <returns><see cref="ModifyL7AccRuleResponse"/></returns>
        public ModifyL7AccRuleResponse ModifyL7AccRuleSync(ModifyL7AccRuleRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRuleResponse>(req, "ModifyL7AccRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改[规则引擎](https://cloud.tencent.com/document/product/1552/70901)中规则列表的优先级，本接口需要传入站点 ID 下完整的规则 ID 列表，规则 ID 列表可以通过[查询七层加速规则](https://cloud.tencent.com/document/product/1552/115820)接口获取，最终优先级顺序将调整成规则 ID 列表的顺序，从前往后执行。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyL7AccRulePriorityResponse"/></returns>
        public Task<ModifyL7AccRulePriorityResponse> ModifyL7AccRulePriority(ModifyL7AccRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRulePriorityResponse>(req, "ModifyL7AccRulePriority");
        }

        /// <summary>
        /// 本接口用于修改[规则引擎](https://cloud.tencent.com/document/product/1552/70901)中规则列表的优先级，本接口需要传入站点 ID 下完整的规则 ID 列表，规则 ID 列表可以通过[查询七层加速规则](https://cloud.tencent.com/document/product/1552/115820)接口获取，最终优先级顺序将调整成规则 ID 列表的顺序，从前往后执行。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyL7AccRulePriorityResponse"/></returns>
        public ModifyL7AccRulePriorityResponse ModifyL7AccRulePrioritySync(ModifyL7AccRulePriorityRequest req)
        {
            return InternalRequestAsync<ModifyL7AccRulePriorityResponse>(req, "ModifyL7AccRulePriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改[站点加速](https://cloud.tencent.com/document/product/1552/96193)全局配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccSettingRequest"/></param>
        /// <returns><see cref="ModifyL7AccSettingResponse"/></returns>
        public Task<ModifyL7AccSettingResponse> ModifyL7AccSetting(ModifyL7AccSettingRequest req)
        {
            return InternalRequestAsync<ModifyL7AccSettingResponse>(req, "ModifyL7AccSetting");
        }

        /// <summary>
        /// 本接口用于修改[站点加速](https://cloud.tencent.com/document/product/1552/96193)全局配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyL7AccSettingRequest"/></param>
        /// <returns><see cref="ModifyL7AccSettingResponse"/></returns>
        public ModifyL7AccSettingResponse ModifyL7AccSettingSync(ModifyL7AccSettingRequest req)
        {
            return InternalRequestAsync<ModifyL7AccSettingResponse>(req, "ModifyL7AccSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改负载均衡实例配置。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public Task<ModifyLoadBalancerResponse> ModifyLoadBalancer(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer");
        }

        /// <summary>
        /// 修改负载均衡实例配置。负载均衡功能内测中，如您需要使用请 [联系我们](https://cloud.tencent.com/online-service)。
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerResponse"/></returns>
        public ModifyLoadBalancerResponse ModifyLoadBalancerSync(ModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerResponse>(req, "ModifyLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口修改多通道安全加速网关信息，如名称、网关 ID、IP、端口等。
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayResponse"/></returns>
        public Task<ModifyMultiPathGatewayResponse> ModifyMultiPathGateway(ModifyMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayResponse>(req, "ModifyMultiPathGateway");
        }

        /// <summary>
        /// 通过本接口修改多通道安全加速网关信息，如名称、网关 ID、IP、端口等。
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayResponse"/></returns>
        public ModifyMultiPathGatewayResponse ModifyMultiPathGatewaySync(ModifyMultiPathGatewayRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayResponse>(req, "ModifyMultiPathGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口修改接入多通道安全加速网关的线路，包括 EdgeOne 四层代理线路、自定义线路。
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayLineResponse"/></returns>
        public Task<ModifyMultiPathGatewayLineResponse> ModifyMultiPathGatewayLine(ModifyMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayLineResponse>(req, "ModifyMultiPathGatewayLine");
        }

        /// <summary>
        /// 通过本接口修改接入多通道安全加速网关的线路，包括 EdgeOne 四层代理线路、自定义线路。
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewayLineRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewayLineResponse"/></returns>
        public ModifyMultiPathGatewayLineResponse ModifyMultiPathGatewayLineSync(ModifyMultiPathGatewayLineRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewayLineResponse>(req, "ModifyMultiPathGatewayLine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口修改接入多通道安全加速网关的密钥，客户基于接入密钥签名接入多通道安全加速网关，修改后原密钥失效。
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<ModifyMultiPathGatewaySecretKeyResponse> ModifyMultiPathGatewaySecretKey(ModifyMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewaySecretKeyResponse>(req, "ModifyMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// 通过本接口修改接入多通道安全加速网关的密钥，客户基于接入密钥签名接入多通道安全加速网关，修改后原密钥失效。
        /// </summary>
        /// <param name="req"><see cref="ModifyMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="ModifyMultiPathGatewaySecretKeyResponse"/></returns>
        public ModifyMultiPathGatewaySecretKeyResponse ModifyMultiPathGatewaySecretKeySync(ModifyMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<ModifyMultiPathGatewaySecretKeyResponse>(req, "ModifyMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于对七层加速域名/四层代理实例启用/关闭特定回源 IP 网段回源。单次支持提交的七层加速域名的数量最大为 200，四层代理实例的数量最大为 100，支持七层加速域名/四层代理实例混合提交，总实例个数最大为 200。如需变更超过 200 个实例，请通过本接口分批提交。
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginACLRequest"/></param>
        /// <returns><see cref="ModifyOriginACLResponse"/></returns>
        public Task<ModifyOriginACLResponse> ModifyOriginACL(ModifyOriginACLRequest req)
        {
            return InternalRequestAsync<ModifyOriginACLResponse>(req, "ModifyOriginACL");
        }

        /// <summary>
        /// 本接口用于对七层加速域名/四层代理实例启用/关闭特定回源 IP 网段回源。单次支持提交的七层加速域名的数量最大为 200，四层代理实例的数量最大为 100，支持七层加速域名/四层代理实例混合提交，总实例个数最大为 200。如需变更超过 200 个实例，请通过本接口分批提交。
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginACLRequest"/></param>
        /// <returns><see cref="ModifyOriginACLResponse"/></returns>
        public ModifyOriginACLResponse ModifyOriginACLSync(ModifyOriginACLRequest req)
        {
            return InternalRequestAsync<ModifyOriginACLResponse>(req, "ModifyOriginACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改源站组配置，新提交的源站记录将会覆盖原有源站组中的源站记录。
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public Task<ModifyOriginGroupResponse> ModifyOriginGroup(ModifyOriginGroupRequest req)
        {
            return InternalRequestAsync<ModifyOriginGroupResponse>(req, "ModifyOriginGroup");
        }

        /// <summary>
        /// 修改源站组配置，新提交的源站记录将会覆盖原有源站组中的源站记录。
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public ModifyOriginGroupResponse ModifyOriginGroupSync(ModifyOriginGroupRequest req)
        {
            return InternalRequestAsync<ModifyOriginGroupResponse>(req, "ModifyOriginGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改套餐配置。目前仅支持修改预付费套餐的自动续费开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyPlanRequest"/></param>
        /// <returns><see cref="ModifyPlanResponse"/></returns>
        public Task<ModifyPlanResponse> ModifyPlan(ModifyPlanRequest req)
        {
            return InternalRequestAsync<ModifyPlanResponse>(req, "ModifyPlan");
        }

        /// <summary>
        /// 修改套餐配置。目前仅支持修改预付费套餐的自动续费开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyPlanRequest"/></param>
        /// <returns><see cref="ModifyPlanResponse"/></returns>
        public ModifyPlanResponse ModifyPlanSync(ModifyPlanRequest req)
        {
            return InternalRequestAsync<ModifyPlanResponse>(req, "ModifyPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口修改实时日志投递任务配置。本接口有如下限制：<li>不支持修改实时日志投递任务目的地类型（TaskType）；</li><li>不支持修改数据投递类型（LogType）</li><li>不支持修改数据投递区域（Area）</li><li>当原实时日志投递任务的目的地为腾讯云 CLS 时，不支持修改目的地详细配置，如日志集、日志主题。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="ModifyRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<ModifyRealtimeLogDeliveryTaskResponse> ModifyRealtimeLogDeliveryTask(ModifyRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyRealtimeLogDeliveryTaskResponse>(req, "ModifyRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// 通过本接口修改实时日志投递任务配置。本接口有如下限制：<li>不支持修改实时日志投递任务目的地类型（TaskType）；</li><li>不支持修改数据投递类型（LogType）</li><li>不支持修改数据投递区域（Area）</li><li>当原实时日志投递任务的目的地为腾讯云 CLS 时，不支持修改目的地详细配置，如日志集、日志主题。</li>
        /// </summary>
        /// <param name="req"><see cref="ModifyRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="ModifyRealtimeLogDeliveryTaskResponse"/></returns>
        public ModifyRealtimeLogDeliveryTaskResponse ModifyRealtimeLogDeliveryTaskSync(ModifyRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyRealtimeLogDeliveryTaskResponse>(req, "ModifyRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版本修改规则引擎接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本修改七层加速规则接口详情请参考 [ModifyL7AccRule](https://cloud.tencent.com/document/product/1552/115818)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// 本接口为旧版本修改规则引擎接口，EdgeOne 于 2025 年 1 月 21 日已对规则引擎相关接口全面升级，新版本修改七层加速规则接口详情请参考 [ModifyL7AccRule](https://cloud.tencent.com/document/product/1552/115818)。
        /// <p style="color: red;">注意：自 2025 年 1 月 21 日起，旧版接口停止更新迭代，后续新增功能将仅在新版接口中提供，旧版接口支持的原有能力将不受影响。为避免在使用旧版接口时出现数据字段冲突，建议您尽早迁移到新版规则引擎接口。</p>
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改 API 资源。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIResourceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIResourceResponse"/></returns>
        public Task<ModifySecurityAPIResourceResponse> ModifySecurityAPIResource(ModifySecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIResourceResponse>(req, "ModifySecurityAPIResource");
        }

        /// <summary>
        /// 该接口用于修改 API 资源。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIResourceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIResourceResponse"/></returns>
        public ModifySecurityAPIResourceResponse ModifySecurityAPIResourceSync(ModifySecurityAPIResourceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIResourceResponse>(req, "ModifySecurityAPIResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改 API 服务。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIServiceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIServiceResponse"/></returns>
        public Task<ModifySecurityAPIServiceResponse> ModifySecurityAPIService(ModifySecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIServiceResponse>(req, "ModifySecurityAPIService");
        }

        /// <summary>
        /// 该接口用于修改 API 服务。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityAPIServiceRequest"/></param>
        /// <returns><see cref="ModifySecurityAPIServiceResponse"/></returns>
        public ModifySecurityAPIServiceResponse ModifySecurityAPIServiceSync(ModifySecurityAPIServiceRequest req)
        {
            return InternalRequestAsync<ModifySecurityAPIServiceResponse>(req, "ModifySecurityAPIService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改客户端认证选项。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityClientAttesterRequest"/></param>
        /// <returns><see cref="ModifySecurityClientAttesterResponse"/></returns>
        public Task<ModifySecurityClientAttesterResponse> ModifySecurityClientAttester(ModifySecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<ModifySecurityClientAttesterResponse>(req, "ModifySecurityClientAttester");
        }

        /// <summary>
        /// 修改客户端认证选项。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityClientAttesterRequest"/></param>
        /// <returns><see cref="ModifySecurityClientAttesterResponse"/></returns>
        public ModifySecurityClientAttesterResponse ModifySecurityClientAttesterSync(ModifySecurityClientAttesterRequest req)
        {
            return InternalRequestAsync<ModifySecurityClientAttesterResponse>(req, "ModifySecurityClientAttester")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安全 IP 组。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public Task<ModifySecurityIPGroupResponse> ModifySecurityIPGroup(ModifySecurityIPGroupRequest req)
        {
            return InternalRequestAsync<ModifySecurityIPGroupResponse>(req, "ModifySecurityIPGroup");
        }

        /// <summary>
        /// 修改安全 IP 组。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public ModifySecurityIPGroupResponse ModifySecurityIPGroupSync(ModifySecurityIPGroupRequest req)
        {
            return InternalRequestAsync<ModifySecurityIPGroupResponse>(req, "ModifySecurityIPGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityJSInjectionRuleResponse"/></returns>
        public Task<ModifySecurityJSInjectionRuleResponse> ModifySecurityJSInjectionRule(ModifySecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityJSInjectionRuleResponse>(req, "ModifySecurityJSInjectionRule");
        }

        /// <summary>
        /// 修改 JavaScript 注入规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityJSInjectionRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityJSInjectionRuleResponse"/></returns>
        public ModifySecurityJSInjectionRuleResponse ModifySecurityJSInjectionRuleSync(ModifySecurityJSInjectionRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityJSInjectionRuleResponse>(req, "ModifySecurityJSInjectionRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Web&Bot安全配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy");
        }

        /// <summary>
        /// 修改Web&Bot安全配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
            return InternalRequestAsync<ModifySecurityPolicyResponse>(req, "ModifySecurityPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安全策略配置模板
        /// </summary>
        /// <param name="req"><see cref="ModifyWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="ModifyWebSecurityTemplateResponse"/></returns>
        public Task<ModifyWebSecurityTemplateResponse> ModifyWebSecurityTemplate(ModifyWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWebSecurityTemplateResponse>(req, "ModifyWebSecurityTemplate");
        }

        /// <summary>
        /// 修改安全策略配置模板
        /// </summary>
        /// <param name="req"><see cref="ModifyWebSecurityTemplateRequest"/></param>
        /// <returns><see cref="ModifyWebSecurityTemplateResponse"/></returns>
        public ModifyWebSecurityTemplateResponse ModifyWebSecurityTemplateSync(ModifyWebSecurityTemplateRequest req)
        {
            return InternalRequestAsync<ModifyWebSecurityTemplateResponse>(req, "ModifyWebSecurityTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改站点信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public Task<ModifyZoneResponse> ModifyZone(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone");
        }

        /// <summary>
        /// 修改站点信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public ModifyZoneResponse ModifyZoneSync(ModifyZoneRequest req)
        {
            return InternalRequestAsync<ModifyZoneResponse>(req, "ModifyZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，详情请参考 [ModifyL7AccSetting](https://cloud.tencent.com/document/product/1552/115817)。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public Task<ModifyZoneSettingResponse> ModifyZoneSetting(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting");
        }

        /// <summary>
        /// 本接口为旧版，EdgeOne 已对规则引擎相关接口全面升级，详情请参考 [ModifyL7AccSetting](https://cloud.tencent.com/document/product/1552/115817)。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public ModifyZoneSettingResponse ModifyZoneSettingSync(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于开启，关闭站点。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public Task<ModifyZoneStatusResponse> ModifyZoneStatus(ModifyZoneStatusRequest req)
        {
            return InternalRequestAsync<ModifyZoneStatusResponse>(req, "ModifyZoneStatus");
        }

        /// <summary>
        /// 用于开启，关闭站点。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public ModifyZoneStatusResponse ModifyZoneStatusSync(ModifyZoneStatusRequest req)
        {
            return InternalRequestAsync<ModifyZoneStatusResponse>(req, "ModifyZoneStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过本接口刷新多通道安全加速网关的密钥。客户基于接入密钥签名接入多通道安全加速网关。每个站点下只有一个密钥，可用于接入该站点下的所有网关，刷新密钥后，原始密钥会失效。
        /// </summary>
        /// <param name="req"><see cref="RefreshMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="RefreshMultiPathGatewaySecretKeyResponse"/></returns>
        public Task<RefreshMultiPathGatewaySecretKeyResponse> RefreshMultiPathGatewaySecretKey(RefreshMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<RefreshMultiPathGatewaySecretKeyResponse>(req, "RefreshMultiPathGatewaySecretKey");
        }

        /// <summary>
        /// 通过本接口刷新多通道安全加速网关的密钥。客户基于接入密钥签名接入多通道安全加速网关。每个站点下只有一个密钥，可用于接入该站点下的所有网关，刷新密钥后，原始密钥会失效。
        /// </summary>
        /// <param name="req"><see cref="RefreshMultiPathGatewaySecretKeyRequest"/></param>
        /// <returns><see cref="RefreshMultiPathGatewaySecretKeyResponse"/></returns>
        public RefreshMultiPathGatewaySecretKeyResponse RefreshMultiPathGatewaySecretKeySync(RefreshMultiPathGatewaySecretKeyRequest req)
        {
            return InternalRequestAsync<RefreshMultiPathGatewaySecretKeyResponse>(req, "RefreshMultiPathGatewaySecretKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当您的套餐需要延长有效期，可以通过该接口进行续费。套餐续费仅支持个人版，基础版，标准版套餐。
        /// > 费用详情可参考 [套餐费用](https://cloud.tencent.com/document/product/1552/94158)
        /// </summary>
        /// <param name="req"><see cref="RenewPlanRequest"/></param>
        /// <returns><see cref="RenewPlanResponse"/></returns>
        public Task<RenewPlanResponse> RenewPlan(RenewPlanRequest req)
        {
            return InternalRequestAsync<RenewPlanResponse>(req, "RenewPlan");
        }

        /// <summary>
        /// 当您的套餐需要延长有效期，可以通过该接口进行续费。套餐续费仅支持个人版，基础版，标准版套餐。
        /// > 费用详情可参考 [套餐费用](https://cloud.tencent.com/document/product/1552/94158)
        /// </summary>
        /// <param name="req"><see cref="RenewPlanRequest"/></param>
        /// <returns><see cref="RenewPlanResponse"/></returns>
        public RenewPlanResponse RenewPlanSync(RenewPlanRequest req)
        {
            return InternalRequestAsync<RenewPlanResponse>(req, "RenewPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当您需要使用高等级套餐才拥有的功能，可以通过本接口升级套餐，仅支持个人版，基础版套餐进行升级。
        /// > 不同类型 Edgeone 计费套餐区别参考 [Edgeone计费套餐选型对比](https://cloud.tencent.com/document/product/1552/94165)
        /// 计费套餐升级规则以及资费详情参考 [Edgeone计费套餐升配说明](https://cloud.tencent.com/document/product/1552/95291)
        /// 如果需要将套餐升级至企业版，请 [联系我们](https://cloud.tencent.com/online-service)
        /// </summary>
        /// <param name="req"><see cref="UpgradePlanRequest"/></param>
        /// <returns><see cref="UpgradePlanResponse"/></returns>
        public Task<UpgradePlanResponse> UpgradePlan(UpgradePlanRequest req)
        {
            return InternalRequestAsync<UpgradePlanResponse>(req, "UpgradePlan");
        }

        /// <summary>
        /// 当您需要使用高等级套餐才拥有的功能，可以通过本接口升级套餐，仅支持个人版，基础版套餐进行升级。
        /// > 不同类型 Edgeone 计费套餐区别参考 [Edgeone计费套餐选型对比](https://cloud.tencent.com/document/product/1552/94165)
        /// 计费套餐升级规则以及资费详情参考 [Edgeone计费套餐升配说明](https://cloud.tencent.com/document/product/1552/95291)
        /// 如果需要将套餐升级至企业版，请 [联系我们](https://cloud.tencent.com/online-service)
        /// </summary>
        /// <param name="req"><see cref="UpgradePlanRequest"/></param>
        /// <returns><see cref="UpgradePlanResponse"/></returns>
        public UpgradePlanResponse UpgradePlanSync(UpgradePlanRequest req)
        {
            return InternalRequestAsync<UpgradePlanResponse>(req, "UpgradePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在 CNAME 接入模式下，您需要对站点或者域名的归属权进行验证，可以通过本接口触发验证。若站点通过归属权验证后，后续添加域名无需再验证。详情参考 [站点/域名归属权验证](https://cloud.tencent.com/document/product/1552/70789)。
        /// 
        /// 在 NS 接入模式下，您也可以通过本接口来查询 NS 服务器是否切换成功，详情参考 [修改 DNS 服务器](https://cloud.tencent.com/document/product/1552/90452)。
        /// </summary>
        /// <param name="req"><see cref="VerifyOwnershipRequest"/></param>
        /// <returns><see cref="VerifyOwnershipResponse"/></returns>
        public Task<VerifyOwnershipResponse> VerifyOwnership(VerifyOwnershipRequest req)
        {
            return InternalRequestAsync<VerifyOwnershipResponse>(req, "VerifyOwnership");
        }

        /// <summary>
        /// 在 CNAME 接入模式下，您需要对站点或者域名的归属权进行验证，可以通过本接口触发验证。若站点通过归属权验证后，后续添加域名无需再验证。详情参考 [站点/域名归属权验证](https://cloud.tencent.com/document/product/1552/70789)。
        /// 
        /// 在 NS 接入模式下，您也可以通过本接口来查询 NS 服务器是否切换成功，详情参考 [修改 DNS 服务器](https://cloud.tencent.com/document/product/1552/90452)。
        /// </summary>
        /// <param name="req"><see cref="VerifyOwnershipRequest"/></param>
        /// <returns><see cref="VerifyOwnershipResponse"/></returns>
        public VerifyOwnershipResponse VerifyOwnershipSync(VerifyOwnershipRequest req)
        {
            return InternalRequestAsync<VerifyOwnershipResponse>(req, "VerifyOwnership")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
