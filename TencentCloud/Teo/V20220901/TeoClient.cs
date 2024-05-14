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
       private const string sdkVersion = "SDK_NET_3.0.1004";

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
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public Task<CreateAliasDomainResponse> CreateAliasDomain(CreateAliasDomainRequest req)
        {
            return InternalRequestAsync<CreateAliasDomainResponse>(req, "CreateAliasDomain");
        }

        /// <summary>
        /// 创建别称域名。
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
        /// 通过本接口创建实时日志投递任务。本接口有如下限制：
        /// 同一个实体（七层域名或者四层代理实例）在同种数据投递类型（LogType）和数据投递区域（Area）的组合下，只能被添加到一个实时日志投递任务中。建议先通过 [DescribeRealtimeLogDeliveryTasks](https://cloud.tencent.com/document/product/1552/104110)  接口根据实体查询实时日志投递任务列表，检查实体是否已经被添加到另一实时日志投递任务中。
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public Task<CreateRealtimeLogDeliveryTaskResponse> CreateRealtimeLogDeliveryTask(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask");
        }

        /// <summary>
        /// 通过本接口创建实时日志投递任务。本接口有如下限制：
        /// 同一个实体（七层域名或者四层代理实例）在同种数据投递类型（LogType）和数据投递区域（Area）的组合下，只能被添加到一个实时日志投递任务中。建议先通过 [DescribeRealtimeLogDeliveryTasks](https://cloud.tencent.com/document/product/1552/104110)  接口根据实体查询实时日志投递任务列表，检查实体是否已经被添加到另一实时日志投递任务中。
        /// </summary>
        /// <param name="req"><see cref="CreateRealtimeLogDeliveryTaskRequest"/></param>
        /// <returns><see cref="CreateRealtimeLogDeliveryTaskResponse"/></returns>
        public CreateRealtimeLogDeliveryTaskResponse CreateRealtimeLogDeliveryTaskSync(CreateRealtimeLogDeliveryTaskRequest req)
        {
            return InternalRequestAsync<CreateRealtimeLogDeliveryTaskResponse>(req, "CreateRealtimeLogDeliveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 规则引擎创建规则。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// 规则引擎创建规则。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
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
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public Task<DeleteAliasDomainResponse> DeleteAliasDomain(DeleteAliasDomainRequest req)
        {
            return InternalRequestAsync<DeleteAliasDomainResponse>(req, "DeleteAliasDomain");
        }

        /// <summary>
        /// 删除别称域名。
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
        /// 批量删除规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules");
        }

        /// <summary>
        /// 批量删除规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
            return InternalRequestAsync<DeleteRulesResponse>(req, "DeleteRules")
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
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public Task<DescribeAliasDomainsResponse> DescribeAliasDomains(DescribeAliasDomainsRequest req)
        {
            return InternalRequestAsync<DescribeAliasDomainsResponse>(req, "DescribeAliasDomains");
        }

        /// <summary>
        /// 查询别称域名信息列表。
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
        /// 用于查询域名配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public Task<DescribeHostsSettingResponse> DescribeHostsSetting(DescribeHostsSettingRequest req)
        {
            return InternalRequestAsync<DescribeHostsSettingResponse>(req, "DescribeHostsSetting");
        }

        /// <summary>
        /// 用于查询域名配置信息
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
        /// 查询源站防护信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public Task<DescribeOriginProtectionResponse> DescribeOriginProtection(DescribeOriginProtectionRequest req)
        {
            return InternalRequestAsync<DescribeOriginProtectionResponse>(req, "DescribeOriginProtection");
        }

        /// <summary>
        /// 查询源站防护信息
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
        /// 查询规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// 查询规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回规则引擎可应用匹配请求的设置列表及其详细建议配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public Task<DescribeRulesSettingResponse> DescribeRulesSetting(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting");
        }

        /// <summary>
        /// 返回规则引擎可应用匹配请求的设置列表及其详细建议配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public DescribeRulesSettingResponse DescribeRulesSettingSync(DescribeRulesSettingRequest req)
        {
            return InternalRequestAsync<DescribeRulesSettingResponse>(req, "DescribeRulesSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全 IP 组的配置信息，包括安全 IP 组的 ID、名称和内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public Task<DescribeSecurityIPGroupResponse> DescribeSecurityIPGroup(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup");
        }

        /// <summary>
        /// 查询安全 IP 组的配置信息，包括安全 IP 组的 ID、名称和内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityIPGroupResponse"/></returns>
        public DescribeSecurityIPGroupResponse DescribeSecurityIPGroupSync(DescribeSecurityIPGroupRequest req)
        {
            return InternalRequestAsync<DescribeSecurityIPGroupResponse>(req, "DescribeSecurityIPGroup")
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
        /// 本接口（DescribeTimingL7AnalysisData）查询七层数据分析类时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public Task<DescribeTimingL7AnalysisDataResponse> DescribeTimingL7AnalysisData(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData");
        }

        /// <summary>
        /// 本接口（DescribeTimingL7AnalysisData）查询七层数据分析类时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public DescribeTimingL7AnalysisDataResponse DescribeTimingL7AnalysisDataSync(DescribeTimingL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7AnalysisDataResponse>(req, "DescribeTimingL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTimingL7CacheData）用于查询七层缓存分析时序类流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public Task<DescribeTimingL7CacheDataResponse> DescribeTimingL7CacheData(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData");
        }

        /// <summary>
        /// 本接口（DescribeTimingL7CacheData）用于查询七层缓存分析时序类流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public DescribeTimingL7CacheDataResponse DescribeTimingL7CacheDataSync(DescribeTimingL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTimingL7CacheDataResponse>(req, "DescribeTimingL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTopL7AnalysisData）用于查询七层流量前topN的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public Task<DescribeTopL7AnalysisDataResponse> DescribeTopL7AnalysisData(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData");
        }

        /// <summary>
        /// 本接口（DescribeTopL7AnalysisData）用于查询七层流量前topN的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public DescribeTopL7AnalysisDataResponse DescribeTopL7AnalysisDataSync(DescribeTopL7AnalysisDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7AnalysisDataResponse>(req, "DescribeTopL7AnalysisData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTopL7CacheData）用于查询七层缓存分析topN流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public Task<DescribeTopL7CacheDataResponse> DescribeTopL7CacheData(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData");
        }

        /// <summary>
        /// 本接口（DescribeTopL7CacheData）用于查询七层缓存分析topN流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public DescribeTopL7CacheDataResponse DescribeTopL7CacheDataSync(DescribeTopL7CacheDataRequest req)
        {
            return InternalRequestAsync<DescribeTopL7CacheDataResponse>(req, "DescribeTopL7CacheData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询站点的所有配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public Task<DescribeZoneSettingResponse> DescribeZoneSetting(DescribeZoneSettingRequest req)
        {
            return InternalRequestAsync<DescribeZoneSettingResponse>(req, "DescribeZoneSetting");
        }

        /// <summary>
        /// 用于查询站点的所有配置信息。
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
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public Task<ModifyAliasDomainResponse> ModifyAliasDomain(ModifyAliasDomainRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainResponse>(req, "ModifyAliasDomain");
        }

        /// <summary>
        /// 修改别称域名。
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
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public Task<ModifyAliasDomainStatusResponse> ModifyAliasDomainStatus(ModifyAliasDomainStatusRequest req)
        {
            return InternalRequestAsync<ModifyAliasDomainStatusResponse>(req, "ModifyAliasDomainStatus");
        }

        /// <summary>
        /// 修改别称域名状态。
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
        /// 修改规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// 修改规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
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
        /// 用于修改站点配置
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public Task<ModifyZoneSettingResponse> ModifyZoneSetting(ModifyZoneSettingRequest req)
        {
            return InternalRequestAsync<ModifyZoneSettingResponse>(req, "ModifyZoneSetting");
        }

        /// <summary>
        /// 用于修改站点配置
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
