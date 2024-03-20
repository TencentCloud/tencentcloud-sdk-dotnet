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

namespace TencentCloud.Tse.V20201207
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tse.V20201207.Models;

   public class TseClient : AbstractClient{

       private const string endpoint = "tse.tencentcloudapi.com";
       private const string version = "2020-12-07";
       private const string sdkVersion = "SDK_NET_3.0.969";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 弹性伸缩策略批量绑定网关分组
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalerResourceStrategyToGroupsRequest"/></param>
        /// <returns><see cref="BindAutoScalerResourceStrategyToGroupsResponse"/></returns>
        public Task<BindAutoScalerResourceStrategyToGroupsResponse> BindAutoScalerResourceStrategyToGroups(BindAutoScalerResourceStrategyToGroupsRequest req)
        {
            return InternalRequestAsync<BindAutoScalerResourceStrategyToGroupsResponse>(req, "BindAutoScalerResourceStrategyToGroups");
        }

        /// <summary>
        /// 弹性伸缩策略批量绑定网关分组
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalerResourceStrategyToGroupsRequest"/></param>
        /// <returns><see cref="BindAutoScalerResourceStrategyToGroupsResponse"/></returns>
        public BindAutoScalerResourceStrategyToGroupsResponse BindAutoScalerResourceStrategyToGroupsSync(BindAutoScalerResourceStrategyToGroupsRequest req)
        {
            return InternalRequestAsync<BindAutoScalerResourceStrategyToGroupsResponse>(req, "BindAutoScalerResourceStrategyToGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭 WAF 防护
        /// </summary>
        /// <param name="req"><see cref="CloseWafProtectionRequest"/></param>
        /// <returns><see cref="CloseWafProtectionResponse"/></returns>
        public Task<CloseWafProtectionResponse> CloseWafProtection(CloseWafProtectionRequest req)
        {
            return InternalRequestAsync<CloseWafProtectionResponse>(req, "CloseWafProtection");
        }

        /// <summary>
        /// 关闭 WAF 防护
        /// </summary>
        /// <param name="req"><see cref="CloseWafProtectionRequest"/></param>
        /// <returns><see cref="CloseWafProtectionResponse"/></returns>
        public CloseWafProtectionResponse CloseWafProtectionSync(CloseWafProtectionRequest req)
        {
            return InternalRequestAsync<CloseWafProtectionResponse>(req, "CloseWafProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建弹性伸缩策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="CreateAutoScalerResourceStrategyResponse"/></returns>
        public Task<CreateAutoScalerResourceStrategyResponse> CreateAutoScalerResourceStrategy(CreateAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<CreateAutoScalerResourceStrategyResponse>(req, "CreateAutoScalerResourceStrategy");
        }

        /// <summary>
        /// 创建弹性伸缩策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="CreateAutoScalerResourceStrategyResponse"/></returns>
        public CreateAutoScalerResourceStrategyResponse CreateAutoScalerResourceStrategySync(CreateAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<CreateAutoScalerResourceStrategyResponse>(req, "CreateAutoScalerResourceStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayResponse> CreateCloudNativeAPIGateway(CreateCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayResponse>(req, "CreateCloudNativeAPIGateway");
        }

        /// <summary>
        /// 创建云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayResponse"/></returns>
        public CreateCloudNativeAPIGatewayResponse CreateCloudNativeAPIGatewaySync(CreateCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayResponse>(req, "CreateCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayCanaryRuleResponse> CreateCloudNativeAPIGatewayCanaryRule(CreateCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCanaryRuleResponse>(req, "CreateCloudNativeAPIGatewayCanaryRule");
        }

        /// <summary>
        /// 创建云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public CreateCloudNativeAPIGatewayCanaryRuleResponse CreateCloudNativeAPIGatewayCanaryRuleSync(CreateCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCanaryRuleResponse>(req, "CreateCloudNativeAPIGatewayCanaryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关证书
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCertificateResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayCertificateResponse> CreateCloudNativeAPIGatewayCertificate(CreateCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCertificateResponse>(req, "CreateCloudNativeAPIGatewayCertificate");
        }

        /// <summary>
        /// 创建云原生网关证书
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCertificateResponse"/></returns>
        public CreateCloudNativeAPIGatewayCertificateResponse CreateCloudNativeAPIGatewayCertificateSync(CreateCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayCertificateResponse>(req, "CreateCloudNativeAPIGatewayCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建公网网络配置
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayPublicNetworkResponse> CreateCloudNativeAPIGatewayPublicNetwork(CreateCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayPublicNetworkResponse>(req, "CreateCloudNativeAPIGatewayPublicNetwork");
        }

        /// <summary>
        /// 创建公网网络配置
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public CreateCloudNativeAPIGatewayPublicNetworkResponse CreateCloudNativeAPIGatewayPublicNetworkSync(CreateCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayPublicNetworkResponse>(req, "CreateCloudNativeAPIGatewayPublicNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayRouteResponse> CreateCloudNativeAPIGatewayRoute(CreateCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteResponse>(req, "CreateCloudNativeAPIGatewayRoute");
        }

        /// <summary>
        /// 创建云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteResponse"/></returns>
        public CreateCloudNativeAPIGatewayRouteResponse CreateCloudNativeAPIGatewayRouteSync(CreateCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteResponse>(req, "CreateCloudNativeAPIGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayRouteRateLimitResponse> CreateCloudNativeAPIGatewayRouteRateLimit(CreateCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteRateLimitResponse>(req, "CreateCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// 创建云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public CreateCloudNativeAPIGatewayRouteRateLimitResponse CreateCloudNativeAPIGatewayRouteRateLimitSync(CreateCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayRouteRateLimitResponse>(req, "CreateCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayServiceResponse> CreateCloudNativeAPIGatewayService(CreateCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceResponse>(req, "CreateCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// 创建云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceResponse"/></returns>
        public CreateCloudNativeAPIGatewayServiceResponse CreateCloudNativeAPIGatewayServiceSync(CreateCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceResponse>(req, "CreateCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<CreateCloudNativeAPIGatewayServiceRateLimitResponse> CreateCloudNativeAPIGatewayServiceRateLimit(CreateCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceRateLimitResponse>(req, "CreateCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// 创建云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public CreateCloudNativeAPIGatewayServiceRateLimitResponse CreateCloudNativeAPIGatewayServiceRateLimitSync(CreateCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<CreateCloudNativeAPIGatewayServiceRateLimitResponse>(req, "CreateCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建配置文件
        /// </summary>
        /// <param name="req"><see cref="CreateConfigFileRequest"/></param>
        /// <returns><see cref="CreateConfigFileResponse"/></returns>
        public Task<CreateConfigFileResponse> CreateConfigFile(CreateConfigFileRequest req)
        {
            return InternalRequestAsync<CreateConfigFileResponse>(req, "CreateConfigFile");
        }

        /// <summary>
        /// 创建配置文件
        /// </summary>
        /// <param name="req"><see cref="CreateConfigFileRequest"/></param>
        /// <returns><see cref="CreateConfigFileResponse"/></returns>
        public CreateConfigFileResponse CreateConfigFileSync(CreateConfigFileRequest req)
        {
            return InternalRequestAsync<CreateConfigFileResponse>(req, "CreateConfigFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建服务治理中心配置文件组
        /// </summary>
        /// <param name="req"><see cref="CreateConfigFileGroupRequest"/></param>
        /// <returns><see cref="CreateConfigFileGroupResponse"/></returns>
        public Task<CreateConfigFileGroupResponse> CreateConfigFileGroup(CreateConfigFileGroupRequest req)
        {
            return InternalRequestAsync<CreateConfigFileGroupResponse>(req, "CreateConfigFileGroup");
        }

        /// <summary>
        /// 创建服务治理中心配置文件组
        /// </summary>
        /// <param name="req"><see cref="CreateConfigFileGroupRequest"/></param>
        /// <returns><see cref="CreateConfigFileGroupResponse"/></returns>
        public CreateConfigFileGroupResponse CreateConfigFileGroupSync(CreateConfigFileGroupRequest req)
        {
            return InternalRequestAsync<CreateConfigFileGroupResponse>(req, "CreateConfigFileGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建引擎实例
        /// </summary>
        /// <param name="req"><see cref="CreateEngineRequest"/></param>
        /// <returns><see cref="CreateEngineResponse"/></returns>
        public Task<CreateEngineResponse> CreateEngine(CreateEngineRequest req)
        {
            return InternalRequestAsync<CreateEngineResponse>(req, "CreateEngine");
        }

        /// <summary>
        /// 创建引擎实例
        /// </summary>
        /// <param name="req"><see cref="CreateEngineRequest"/></param>
        /// <returns><see cref="CreateEngineResponse"/></returns>
        public CreateEngineResponse CreateEngineSync(CreateEngineRequest req)
        {
            return InternalRequestAsync<CreateEngineResponse>(req, "CreateEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建治理中心服务别名
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceAliasRequest"/></param>
        /// <returns><see cref="CreateGovernanceAliasResponse"/></returns>
        public Task<CreateGovernanceAliasResponse> CreateGovernanceAlias(CreateGovernanceAliasRequest req)
        {
            return InternalRequestAsync<CreateGovernanceAliasResponse>(req, "CreateGovernanceAlias");
        }

        /// <summary>
        /// 创建治理中心服务别名
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceAliasRequest"/></param>
        /// <returns><see cref="CreateGovernanceAliasResponse"/></returns>
        public CreateGovernanceAliasResponse CreateGovernanceAliasSync(CreateGovernanceAliasRequest req)
        {
            return InternalRequestAsync<CreateGovernanceAliasResponse>(req, "CreateGovernanceAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建服务实例
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceInstancesRequest"/></param>
        /// <returns><see cref="CreateGovernanceInstancesResponse"/></returns>
        public Task<CreateGovernanceInstancesResponse> CreateGovernanceInstances(CreateGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<CreateGovernanceInstancesResponse>(req, "CreateGovernanceInstances");
        }

        /// <summary>
        /// 创建服务实例
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceInstancesRequest"/></param>
        /// <returns><see cref="CreateGovernanceInstancesResponse"/></returns>
        public CreateGovernanceInstancesResponse CreateGovernanceInstancesSync(CreateGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<CreateGovernanceInstancesResponse>(req, "CreateGovernanceInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建治理中心命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="CreateGovernanceNamespacesResponse"/></returns>
        public Task<CreateGovernanceNamespacesResponse> CreateGovernanceNamespaces(CreateGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<CreateGovernanceNamespacesResponse>(req, "CreateGovernanceNamespaces");
        }

        /// <summary>
        /// 创建治理中心命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="CreateGovernanceNamespacesResponse"/></returns>
        public CreateGovernanceNamespacesResponse CreateGovernanceNamespacesSync(CreateGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<CreateGovernanceNamespacesResponse>(req, "CreateGovernanceNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建治理中心服务
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceServicesRequest"/></param>
        /// <returns><see cref="CreateGovernanceServicesResponse"/></returns>
        public Task<CreateGovernanceServicesResponse> CreateGovernanceServices(CreateGovernanceServicesRequest req)
        {
            return InternalRequestAsync<CreateGovernanceServicesResponse>(req, "CreateGovernanceServices");
        }

        /// <summary>
        /// 创建治理中心服务
        /// </summary>
        /// <param name="req"><see cref="CreateGovernanceServicesRequest"/></param>
        /// <returns><see cref="CreateGovernanceServicesResponse"/></returns>
        public CreateGovernanceServicesResponse CreateGovernanceServicesSync(CreateGovernanceServicesRequest req)
        {
            return InternalRequestAsync<CreateGovernanceServicesResponse>(req, "CreateGovernanceServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云原生网关引擎分组
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServerGroupResponse"/></returns>
        public Task<CreateNativeGatewayServerGroupResponse> CreateNativeGatewayServerGroup(CreateNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<CreateNativeGatewayServerGroupResponse>(req, "CreateNativeGatewayServerGroup");
        }

        /// <summary>
        /// 创建云原生网关引擎分组
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServerGroupResponse"/></returns>
        public CreateNativeGatewayServerGroupResponse CreateNativeGatewayServerGroupSync(CreateNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<CreateNativeGatewayServerGroupResponse>(req, "CreateNativeGatewayServerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建或更新配置文件并发布配置
        /// </summary>
        /// <param name="req"><see cref="CreateOrUpdateConfigFileAndReleaseRequest"/></param>
        /// <returns><see cref="CreateOrUpdateConfigFileAndReleaseResponse"/></returns>
        public Task<CreateOrUpdateConfigFileAndReleaseResponse> CreateOrUpdateConfigFileAndRelease(CreateOrUpdateConfigFileAndReleaseRequest req)
        {
            return InternalRequestAsync<CreateOrUpdateConfigFileAndReleaseResponse>(req, "CreateOrUpdateConfigFileAndRelease");
        }

        /// <summary>
        /// 创建或更新配置文件并发布配置
        /// </summary>
        /// <param name="req"><see cref="CreateOrUpdateConfigFileAndReleaseRequest"/></param>
        /// <returns><see cref="CreateOrUpdateConfigFileAndReleaseResponse"/></returns>
        public CreateOrUpdateConfigFileAndReleaseResponse CreateOrUpdateConfigFileAndReleaseSync(CreateOrUpdateConfigFileAndReleaseRequest req)
        {
            return InternalRequestAsync<CreateOrUpdateConfigFileAndReleaseResponse>(req, "CreateOrUpdateConfigFileAndRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建 WAF 防护域名
        /// </summary>
        /// <param name="req"><see cref="CreateWafDomainsRequest"/></param>
        /// <returns><see cref="CreateWafDomainsResponse"/></returns>
        public Task<CreateWafDomainsResponse> CreateWafDomains(CreateWafDomainsRequest req)
        {
            return InternalRequestAsync<CreateWafDomainsResponse>(req, "CreateWafDomains");
        }

        /// <summary>
        /// 新建 WAF 防护域名
        /// </summary>
        /// <param name="req"><see cref="CreateWafDomainsRequest"/></param>
        /// <returns><see cref="CreateWafDomainsResponse"/></returns>
        public CreateWafDomainsResponse CreateWafDomainsSync(CreateWafDomainsRequest req)
        {
            return InternalRequestAsync<CreateWafDomainsResponse>(req, "CreateWafDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除弹性伸缩策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScalerResourceStrategyResponse"/></returns>
        public Task<DeleteAutoScalerResourceStrategyResponse> DeleteAutoScalerResourceStrategy(DeleteAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalerResourceStrategyResponse>(req, "DeleteAutoScalerResourceStrategy");
        }

        /// <summary>
        /// 删除弹性伸缩策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScalerResourceStrategyResponse"/></returns>
        public DeleteAutoScalerResourceStrategyResponse DeleteAutoScalerResourceStrategySync(DeleteAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalerResourceStrategyResponse>(req, "DeleteAutoScalerResourceStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayResponse> DeleteCloudNativeAPIGateway(DeleteCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayResponse>(req, "DeleteCloudNativeAPIGateway");
        }

        /// <summary>
        /// 删除云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayResponse"/></returns>
        public DeleteCloudNativeAPIGatewayResponse DeleteCloudNativeAPIGatewaySync(DeleteCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayResponse>(req, "DeleteCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayCanaryRuleResponse> DeleteCloudNativeAPIGatewayCanaryRule(DeleteCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCanaryRuleResponse>(req, "DeleteCloudNativeAPIGatewayCanaryRule");
        }

        /// <summary>
        /// 删除云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public DeleteCloudNativeAPIGatewayCanaryRuleResponse DeleteCloudNativeAPIGatewayCanaryRuleSync(DeleteCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCanaryRuleResponse>(req, "DeleteCloudNativeAPIGatewayCanaryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生网关证书
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCertificateResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayCertificateResponse> DeleteCloudNativeAPIGatewayCertificate(DeleteCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCertificateResponse>(req, "DeleteCloudNativeAPIGatewayCertificate");
        }

        /// <summary>
        /// 删除云原生网关证书
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCertificateResponse"/></returns>
        public DeleteCloudNativeAPIGatewayCertificateResponse DeleteCloudNativeAPIGatewayCertificateSync(DeleteCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayCertificateResponse>(req, "DeleteCloudNativeAPIGatewayCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除公网网络配置
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayPublicNetworkResponse> DeleteCloudNativeAPIGatewayPublicNetwork(DeleteCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayPublicNetworkResponse>(req, "DeleteCloudNativeAPIGatewayPublicNetwork");
        }

        /// <summary>
        /// 删除公网网络配置
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayPublicNetworkRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayPublicNetworkResponse"/></returns>
        public DeleteCloudNativeAPIGatewayPublicNetworkResponse DeleteCloudNativeAPIGatewayPublicNetworkSync(DeleteCloudNativeAPIGatewayPublicNetworkRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayPublicNetworkResponse>(req, "DeleteCloudNativeAPIGatewayPublicNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayRouteResponse> DeleteCloudNativeAPIGatewayRoute(DeleteCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteResponse>(req, "DeleteCloudNativeAPIGatewayRoute");
        }

        /// <summary>
        /// 删除云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteResponse"/></returns>
        public DeleteCloudNativeAPIGatewayRouteResponse DeleteCloudNativeAPIGatewayRouteSync(DeleteCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteResponse>(req, "DeleteCloudNativeAPIGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayRouteRateLimitResponse> DeleteCloudNativeAPIGatewayRouteRateLimit(DeleteCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// 删除云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public DeleteCloudNativeAPIGatewayRouteRateLimitResponse DeleteCloudNativeAPIGatewayRouteRateLimitSync(DeleteCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayServiceResponse> DeleteCloudNativeAPIGatewayService(DeleteCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceResponse>(req, "DeleteCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// 删除云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceResponse"/></returns>
        public DeleteCloudNativeAPIGatewayServiceResponse DeleteCloudNativeAPIGatewayServiceSync(DeleteCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceResponse>(req, "DeleteCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<DeleteCloudNativeAPIGatewayServiceRateLimitResponse> DeleteCloudNativeAPIGatewayServiceRateLimit(DeleteCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// 删除云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public DeleteCloudNativeAPIGatewayServiceRateLimitResponse DeleteCloudNativeAPIGatewayServiceRateLimitSync(DeleteCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DeleteCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DeleteCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除配置文件分组
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFileGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFileGroupResponse"/></returns>
        public Task<DeleteConfigFileGroupResponse> DeleteConfigFileGroup(DeleteConfigFileGroupRequest req)
        {
            return InternalRequestAsync<DeleteConfigFileGroupResponse>(req, "DeleteConfigFileGroup");
        }

        /// <summary>
        /// 删除配置文件分组
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFileGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFileGroupResponse"/></returns>
        public DeleteConfigFileGroupResponse DeleteConfigFileGroupSync(DeleteConfigFileGroupRequest req)
        {
            return InternalRequestAsync<DeleteConfigFileGroupResponse>(req, "DeleteConfigFileGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除配置发布
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFileReleasesRequest"/></param>
        /// <returns><see cref="DeleteConfigFileReleasesResponse"/></returns>
        public Task<DeleteConfigFileReleasesResponse> DeleteConfigFileReleases(DeleteConfigFileReleasesRequest req)
        {
            return InternalRequestAsync<DeleteConfigFileReleasesResponse>(req, "DeleteConfigFileReleases");
        }

        /// <summary>
        /// 删除配置发布
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFileReleasesRequest"/></param>
        /// <returns><see cref="DeleteConfigFileReleasesResponse"/></returns>
        public DeleteConfigFileReleasesResponse DeleteConfigFileReleasesSync(DeleteConfigFileReleasesRequest req)
        {
            return InternalRequestAsync<DeleteConfigFileReleasesResponse>(req, "DeleteConfigFileReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除配置文件
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFilesRequest"/></param>
        /// <returns><see cref="DeleteConfigFilesResponse"/></returns>
        public Task<DeleteConfigFilesResponse> DeleteConfigFiles(DeleteConfigFilesRequest req)
        {
            return InternalRequestAsync<DeleteConfigFilesResponse>(req, "DeleteConfigFiles");
        }

        /// <summary>
        /// 删除配置文件
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFilesRequest"/></param>
        /// <returns><see cref="DeleteConfigFilesResponse"/></returns>
        public DeleteConfigFilesResponse DeleteConfigFilesSync(DeleteConfigFilesRequest req)
        {
            return InternalRequestAsync<DeleteConfigFilesResponse>(req, "DeleteConfigFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除引擎实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEngineRequest"/></param>
        /// <returns><see cref="DeleteEngineResponse"/></returns>
        public Task<DeleteEngineResponse> DeleteEngine(DeleteEngineRequest req)
        {
            return InternalRequestAsync<DeleteEngineResponse>(req, "DeleteEngine");
        }

        /// <summary>
        /// 删除引擎实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEngineRequest"/></param>
        /// <returns><see cref="DeleteEngineResponse"/></returns>
        public DeleteEngineResponse DeleteEngineSync(DeleteEngineRequest req)
        {
            return InternalRequestAsync<DeleteEngineResponse>(req, "DeleteEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除治理中心服务别名
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceAliasesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceAliasesResponse"/></returns>
        public Task<DeleteGovernanceAliasesResponse> DeleteGovernanceAliases(DeleteGovernanceAliasesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceAliasesResponse>(req, "DeleteGovernanceAliases");
        }

        /// <summary>
        /// 删除治理中心服务别名
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceAliasesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceAliasesResponse"/></returns>
        public DeleteGovernanceAliasesResponse DeleteGovernanceAliasesSync(DeleteGovernanceAliasesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceAliasesResponse>(req, "DeleteGovernanceAliases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除服务实例
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceInstancesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceInstancesResponse"/></returns>
        public Task<DeleteGovernanceInstancesResponse> DeleteGovernanceInstances(DeleteGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceInstancesResponse>(req, "DeleteGovernanceInstances");
        }

        /// <summary>
        /// 删除服务实例
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceInstancesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceInstancesResponse"/></returns>
        public DeleteGovernanceInstancesResponse DeleteGovernanceInstancesSync(DeleteGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceInstancesResponse>(req, "DeleteGovernanceInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除治理中心服务实例
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceInstancesByHostRequest"/></param>
        /// <returns><see cref="DeleteGovernanceInstancesByHostResponse"/></returns>
        public Task<DeleteGovernanceInstancesByHostResponse> DeleteGovernanceInstancesByHost(DeleteGovernanceInstancesByHostRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceInstancesByHostResponse>(req, "DeleteGovernanceInstancesByHost");
        }

        /// <summary>
        /// 删除治理中心服务实例
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceInstancesByHostRequest"/></param>
        /// <returns><see cref="DeleteGovernanceInstancesByHostResponse"/></returns>
        public DeleteGovernanceInstancesByHostResponse DeleteGovernanceInstancesByHostSync(DeleteGovernanceInstancesByHostRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceInstancesByHostResponse>(req, "DeleteGovernanceInstancesByHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除治理中心命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceNamespacesResponse"/></returns>
        public Task<DeleteGovernanceNamespacesResponse> DeleteGovernanceNamespaces(DeleteGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceNamespacesResponse>(req, "DeleteGovernanceNamespaces");
        }

        /// <summary>
        /// 删除治理中心命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceNamespacesResponse"/></returns>
        public DeleteGovernanceNamespacesResponse DeleteGovernanceNamespacesSync(DeleteGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceNamespacesResponse>(req, "DeleteGovernanceNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除治理中心服务
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceServicesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceServicesResponse"/></returns>
        public Task<DeleteGovernanceServicesResponse> DeleteGovernanceServices(DeleteGovernanceServicesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceServicesResponse>(req, "DeleteGovernanceServices");
        }

        /// <summary>
        /// 删除治理中心服务
        /// </summary>
        /// <param name="req"><see cref="DeleteGovernanceServicesRequest"/></param>
        /// <returns><see cref="DeleteGovernanceServicesResponse"/></returns>
        public DeleteGovernanceServicesResponse DeleteGovernanceServicesSync(DeleteGovernanceServicesRequest req)
        {
            return InternalRequestAsync<DeleteGovernanceServicesResponse>(req, "DeleteGovernanceServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除网关实例分组
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServerGroupResponse"/></returns>
        public Task<DeleteNativeGatewayServerGroupResponse> DeleteNativeGatewayServerGroup(DeleteNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<DeleteNativeGatewayServerGroupResponse>(req, "DeleteNativeGatewayServerGroup");
        }

        /// <summary>
        /// 删除网关实例分组
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServerGroupResponse"/></returns>
        public DeleteNativeGatewayServerGroupResponse DeleteNativeGatewayServerGroupSync(DeleteNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<DeleteNativeGatewayServerGroupResponse>(req, "DeleteNativeGatewayServerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 WAF 防护域名
        /// </summary>
        /// <param name="req"><see cref="DeleteWafDomainsRequest"/></param>
        /// <returns><see cref="DeleteWafDomainsResponse"/></returns>
        public Task<DeleteWafDomainsResponse> DeleteWafDomains(DeleteWafDomainsRequest req)
        {
            return InternalRequestAsync<DeleteWafDomainsResponse>(req, "DeleteWafDomains");
        }

        /// <summary>
        /// 删除 WAF 防护域名
        /// </summary>
        /// <param name="req"><see cref="DeleteWafDomainsRequest"/></param>
        /// <returns><see cref="DeleteWafDomainsResponse"/></returns>
        public DeleteWafDomainsResponse DeleteWafDomainsSync(DeleteWafDomainsRequest req)
        {
            return InternalRequestAsync<DeleteWafDomainsResponse>(req, "DeleteWafDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取全量配置文件模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAllConfigFileTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAllConfigFileTemplatesResponse"/></returns>
        public Task<DescribeAllConfigFileTemplatesResponse> DescribeAllConfigFileTemplates(DescribeAllConfigFileTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAllConfigFileTemplatesResponse>(req, "DescribeAllConfigFileTemplates");
        }

        /// <summary>
        /// 获取全量配置文件模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAllConfigFileTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAllConfigFileTemplatesResponse"/></returns>
        public DescribeAllConfigFileTemplatesResponse DescribeAllConfigFileTemplatesSync(DescribeAllConfigFileTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAllConfigFileTemplatesResponse>(req, "DescribeAllConfigFileTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看弹性伸缩策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategiesResponse"/></returns>
        public Task<DescribeAutoScalerResourceStrategiesResponse> DescribeAutoScalerResourceStrategies(DescribeAutoScalerResourceStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategiesResponse>(req, "DescribeAutoScalerResourceStrategies");
        }

        /// <summary>
        /// 查看弹性伸缩策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategiesResponse"/></returns>
        public DescribeAutoScalerResourceStrategiesResponse DescribeAutoScalerResourceStrategiesSync(DescribeAutoScalerResourceStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategiesResponse>(req, "DescribeAutoScalerResourceStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看弹性伸缩策略绑定的网关分组
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategyBindingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategyBindingGroupsResponse"/></returns>
        public Task<DescribeAutoScalerResourceStrategyBindingGroupsResponse> DescribeAutoScalerResourceStrategyBindingGroups(DescribeAutoScalerResourceStrategyBindingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategyBindingGroupsResponse>(req, "DescribeAutoScalerResourceStrategyBindingGroups");
        }

        /// <summary>
        /// 查看弹性伸缩策略绑定的网关分组
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalerResourceStrategyBindingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalerResourceStrategyBindingGroupsResponse"/></returns>
        public DescribeAutoScalerResourceStrategyBindingGroupsResponse DescribeAutoScalerResourceStrategyBindingGroupsSync(DescribeAutoScalerResourceStrategyBindingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalerResourceStrategyBindingGroupsResponse>(req, "DescribeAutoScalerResourceStrategyBindingGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生API网关实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayResponse> DescribeCloudNativeAPIGateway(DescribeCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayResponse>(req, "DescribeCloudNativeAPIGateway");
        }

        /// <summary>
        /// 获取云原生API网关实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayResponse"/></returns>
        public DescribeCloudNativeAPIGatewayResponse DescribeCloudNativeAPIGatewaySync(DescribeCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayResponse>(req, "DescribeCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关灰度规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCanaryRulesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCanaryRulesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayCanaryRulesResponse> DescribeCloudNativeAPIGatewayCanaryRules(DescribeCloudNativeAPIGatewayCanaryRulesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCanaryRulesResponse>(req, "DescribeCloudNativeAPIGatewayCanaryRules");
        }

        /// <summary>
        /// 查询云原生网关灰度规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCanaryRulesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCanaryRulesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCanaryRulesResponse DescribeCloudNativeAPIGatewayCanaryRulesSync(DescribeCloudNativeAPIGatewayCanaryRulesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCanaryRulesResponse>(req, "DescribeCloudNativeAPIGatewayCanaryRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关单个证书详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayCertificateDetailsResponse> DescribeCloudNativeAPIGatewayCertificateDetails(DescribeCloudNativeAPIGatewayCertificateDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificateDetailsResponse>(req, "DescribeCloudNativeAPIGatewayCertificateDetails");
        }

        /// <summary>
        /// 查询云原生网关单个证书详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificateDetailsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCertificateDetailsResponse DescribeCloudNativeAPIGatewayCertificateDetailsSync(DescribeCloudNativeAPIGatewayCertificateDetailsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificateDetailsResponse>(req, "DescribeCloudNativeAPIGatewayCertificateDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificatesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayCertificatesResponse> DescribeCloudNativeAPIGatewayCertificates(DescribeCloudNativeAPIGatewayCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificatesResponse>(req, "DescribeCloudNativeAPIGatewayCertificates");
        }

        /// <summary>
        /// 查询云原生网关证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCertificatesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCertificatesResponse DescribeCloudNativeAPIGatewayCertificatesSync(DescribeCloudNativeAPIGatewayCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayCertificatesResponse>(req, "DescribeCloudNativeAPIGatewayCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生API网关实例网络配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConfigRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConfigResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayConfigResponse> DescribeCloudNativeAPIGatewayConfig(DescribeCloudNativeAPIGatewayConfigRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConfigResponse>(req, "DescribeCloudNativeAPIGatewayConfig");
        }

        /// <summary>
        /// 获取云原生API网关实例网络配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayConfigRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayConfigResponse"/></returns>
        public DescribeCloudNativeAPIGatewayConfigResponse DescribeCloudNativeAPIGatewayConfigSync(DescribeCloudNativeAPIGatewayConfigRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayConfigResponse>(req, "DescribeCloudNativeAPIGatewayConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生网关节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayNodesResponse> DescribeCloudNativeAPIGatewayNodes(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayNodesResponse>(req, "DescribeCloudNativeAPIGatewayNodes");
        }

        /// <summary>
        /// 获取云原生网关节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayNodesResponse DescribeCloudNativeAPIGatewayNodesSync(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayNodesResponse>(req, "DescribeCloudNativeAPIGatewayNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生API网关实例端口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayPortsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayPortsResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayPortsResponse> DescribeCloudNativeAPIGatewayPorts(DescribeCloudNativeAPIGatewayPortsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayPortsResponse>(req, "DescribeCloudNativeAPIGatewayPorts");
        }

        /// <summary>
        /// 获取云原生API网关实例端口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayPortsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayPortsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayPortsResponse DescribeCloudNativeAPIGatewayPortsSync(DescribeCloudNativeAPIGatewayPortsRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayPortsResponse>(req, "DescribeCloudNativeAPIGatewayPorts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayRouteRateLimitResponse> DescribeCloudNativeAPIGatewayRouteRateLimit(DescribeCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// 查询云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public DescribeCloudNativeAPIGatewayRouteRateLimitResponse DescribeCloudNativeAPIGatewayRouteRateLimitSync(DescribeCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRouteRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRoutesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayRoutesResponse> DescribeCloudNativeAPIGatewayRoutes(DescribeCloudNativeAPIGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRoutesResponse>(req, "DescribeCloudNativeAPIGatewayRoutes");
        }

        /// <summary>
        /// 查询云原生网关路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRoutesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayRoutesResponse DescribeCloudNativeAPIGatewayRoutesSync(DescribeCloudNativeAPIGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayRoutesResponse>(req, "DescribeCloudNativeAPIGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayServiceRateLimitResponse> DescribeCloudNativeAPIGatewayServiceRateLimit(DescribeCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// 查询云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public DescribeCloudNativeAPIGatewayServiceRateLimitResponse DescribeCloudNativeAPIGatewayServiceRateLimitSync(DescribeCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServiceRateLimitResponse>(req, "DescribeCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayServicesResponse> DescribeCloudNativeAPIGatewayServices(DescribeCloudNativeAPIGatewayServicesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServicesResponse>(req, "DescribeCloudNativeAPIGatewayServices");
        }

        /// <summary>
        /// 查询云原生网关服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayServicesResponse DescribeCloudNativeAPIGatewayServicesSync(DescribeCloudNativeAPIGatewayServicesRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayServicesResponse>(req, "DescribeCloudNativeAPIGatewayServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生网关服务详情下的Upstream列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayUpstreamRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayUpstreamResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewayUpstreamResponse> DescribeCloudNativeAPIGatewayUpstream(DescribeCloudNativeAPIGatewayUpstreamRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayUpstreamResponse>(req, "DescribeCloudNativeAPIGatewayUpstream");
        }

        /// <summary>
        /// 获取云原生网关服务详情下的Upstream列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayUpstreamRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayUpstreamResponse"/></returns>
        public DescribeCloudNativeAPIGatewayUpstreamResponse DescribeCloudNativeAPIGatewayUpstreamSync(DescribeCloudNativeAPIGatewayUpstreamRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewayUpstreamResponse>(req, "DescribeCloudNativeAPIGatewayUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生API网关实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaysResponse"/></returns>
        public Task<DescribeCloudNativeAPIGatewaysResponse> DescribeCloudNativeAPIGateways(DescribeCloudNativeAPIGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaysResponse>(req, "DescribeCloudNativeAPIGateways");
        }

        /// <summary>
        /// 获取云原生API网关实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaysResponse"/></returns>
        public DescribeCloudNativeAPIGatewaysResponse DescribeCloudNativeAPIGatewaysSync(DescribeCloudNativeAPIGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCloudNativeAPIGatewaysResponse>(req, "DescribeCloudNativeAPIGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据命名空间、组、名字查找配置文件
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileRequest"/></param>
        /// <returns><see cref="DescribeConfigFileResponse"/></returns>
        public Task<DescribeConfigFileResponse> DescribeConfigFile(DescribeConfigFileRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileResponse>(req, "DescribeConfigFile");
        }

        /// <summary>
        /// 根据命名空间、组、名字查找配置文件
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileRequest"/></param>
        /// <returns><see cref="DescribeConfigFileResponse"/></returns>
        public DescribeConfigFileResponse DescribeConfigFileSync(DescribeConfigFileRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileResponse>(req, "DescribeConfigFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据条件分页查询配置文件组
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigFileGroupsResponse"/></returns>
        public Task<DescribeConfigFileGroupsResponse> DescribeConfigFileGroups(DescribeConfigFileGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileGroupsResponse>(req, "DescribeConfigFileGroups");
        }

        /// <summary>
        /// 根据条件分页查询配置文件组
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigFileGroupsResponse"/></returns>
        public DescribeConfigFileGroupsResponse DescribeConfigFileGroupsSync(DescribeConfigFileGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileGroupsResponse>(req, "DescribeConfigFileGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取配置文件发布
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleaseRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleaseResponse"/></returns>
        public Task<DescribeConfigFileReleaseResponse> DescribeConfigFileRelease(DescribeConfigFileReleaseRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleaseResponse>(req, "DescribeConfigFileRelease");
        }

        /// <summary>
        /// 获取配置文件发布
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleaseRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleaseResponse"/></returns>
        public DescribeConfigFileReleaseResponse DescribeConfigFileReleaseSync(DescribeConfigFileReleaseRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleaseResponse>(req, "DescribeConfigFileRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取配置文件发布历史列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleaseHistoriesRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleaseHistoriesResponse"/></returns>
        public Task<DescribeConfigFileReleaseHistoriesResponse> DescribeConfigFileReleaseHistories(DescribeConfigFileReleaseHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleaseHistoriesResponse>(req, "DescribeConfigFileReleaseHistories");
        }

        /// <summary>
        /// 获取配置文件发布历史列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleaseHistoriesRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleaseHistoriesResponse"/></returns>
        public DescribeConfigFileReleaseHistoriesResponse DescribeConfigFileReleaseHistoriesSync(DescribeConfigFileReleaseHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleaseHistoriesResponse>(req, "DescribeConfigFileReleaseHistories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个配置所有版本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleaseVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleaseVersionsResponse"/></returns>
        public Task<DescribeConfigFileReleaseVersionsResponse> DescribeConfigFileReleaseVersions(DescribeConfigFileReleaseVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleaseVersionsResponse>(req, "DescribeConfigFileReleaseVersions");
        }

        /// <summary>
        /// 查询某个配置所有版本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleaseVersionsRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleaseVersionsResponse"/></returns>
        public DescribeConfigFileReleaseVersionsResponse DescribeConfigFileReleaseVersionsSync(DescribeConfigFileReleaseVersionsRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleaseVersionsResponse>(req, "DescribeConfigFileReleaseVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询配置版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleasesRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleasesResponse"/></returns>
        public Task<DescribeConfigFileReleasesResponse> DescribeConfigFileReleases(DescribeConfigFileReleasesRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleasesResponse>(req, "DescribeConfigFileReleases");
        }

        /// <summary>
        /// 查询配置版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFileReleasesRequest"/></param>
        /// <returns><see cref="DescribeConfigFileReleasesResponse"/></returns>
        public DescribeConfigFileReleasesResponse DescribeConfigFileReleasesSync(DescribeConfigFileReleasesRequest req)
        {
            return InternalRequestAsync<DescribeConfigFileReleasesResponse>(req, "DescribeConfigFileReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据命名空间、组名、名称、标签查询配置文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFilesRequest"/></param>
        /// <returns><see cref="DescribeConfigFilesResponse"/></returns>
        public Task<DescribeConfigFilesResponse> DescribeConfigFiles(DescribeConfigFilesRequest req)
        {
            return InternalRequestAsync<DescribeConfigFilesResponse>(req, "DescribeConfigFiles");
        }

        /// <summary>
        /// 根据命名空间、组名、名称、标签查询配置文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFilesRequest"/></param>
        /// <returns><see cref="DescribeConfigFilesResponse"/></returns>
        public DescribeConfigFilesResponse DescribeConfigFilesSync(DescribeConfigFilesRequest req)
        {
            return InternalRequestAsync<DescribeConfigFilesResponse>(req, "DescribeConfigFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据group查询配置文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFilesByGroupRequest"/></param>
        /// <returns><see cref="DescribeConfigFilesByGroupResponse"/></returns>
        public Task<DescribeConfigFilesByGroupResponse> DescribeConfigFilesByGroup(DescribeConfigFilesByGroupRequest req)
        {
            return InternalRequestAsync<DescribeConfigFilesByGroupResponse>(req, "DescribeConfigFilesByGroup");
        }

        /// <summary>
        /// 根据group查询配置文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigFilesByGroupRequest"/></param>
        /// <returns><see cref="DescribeConfigFilesByGroupResponse"/></returns>
        public DescribeConfigFilesByGroupResponse DescribeConfigFilesByGroupSync(DescribeConfigFilesByGroupRequest req)
        {
            return InternalRequestAsync<DescribeConfigFilesByGroupResponse>(req, "DescribeConfigFilesByGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询治理中心服务别名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceAliasesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceAliasesResponse"/></returns>
        public Task<DescribeGovernanceAliasesResponse> DescribeGovernanceAliases(DescribeGovernanceAliasesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceAliasesResponse>(req, "DescribeGovernanceAliases");
        }

        /// <summary>
        /// 查询治理中心服务别名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceAliasesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceAliasesResponse"/></returns>
        public DescribeGovernanceAliasesResponse DescribeGovernanceAliasesSync(DescribeGovernanceAliasesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceAliasesResponse>(req, "DescribeGovernanceAliases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务实例
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceInstancesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceInstancesResponse"/></returns>
        public Task<DescribeGovernanceInstancesResponse> DescribeGovernanceInstances(DescribeGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceInstancesResponse>(req, "DescribeGovernanceInstances");
        }

        /// <summary>
        /// 查询服务实例
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceInstancesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceInstancesResponse"/></returns>
        public DescribeGovernanceInstancesResponse DescribeGovernanceInstancesSync(DescribeGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceInstancesResponse>(req, "DescribeGovernanceInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务治理中心命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceNamespacesResponse"/></returns>
        public Task<DescribeGovernanceNamespacesResponse> DescribeGovernanceNamespaces(DescribeGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceNamespacesResponse>(req, "DescribeGovernanceNamespaces");
        }

        /// <summary>
        /// 查询服务治理中心命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceNamespacesResponse"/></returns>
        public DescribeGovernanceNamespacesResponse DescribeGovernanceNamespacesSync(DescribeGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceNamespacesResponse>(req, "DescribeGovernanceNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务下契约版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceServiceContractVersionsRequest"/></param>
        /// <returns><see cref="DescribeGovernanceServiceContractVersionsResponse"/></returns>
        public Task<DescribeGovernanceServiceContractVersionsResponse> DescribeGovernanceServiceContractVersions(DescribeGovernanceServiceContractVersionsRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceServiceContractVersionsResponse>(req, "DescribeGovernanceServiceContractVersions");
        }

        /// <summary>
        /// 查询服务下契约版本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceServiceContractVersionsRequest"/></param>
        /// <returns><see cref="DescribeGovernanceServiceContractVersionsResponse"/></returns>
        public DescribeGovernanceServiceContractVersionsResponse DescribeGovernanceServiceContractVersionsSync(DescribeGovernanceServiceContractVersionsRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceServiceContractVersionsResponse>(req, "DescribeGovernanceServiceContractVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务契约定义列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceServiceContractsRequest"/></param>
        /// <returns><see cref="DescribeGovernanceServiceContractsResponse"/></returns>
        public Task<DescribeGovernanceServiceContractsResponse> DescribeGovernanceServiceContracts(DescribeGovernanceServiceContractsRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceServiceContractsResponse>(req, "DescribeGovernanceServiceContracts");
        }

        /// <summary>
        /// 查询服务契约定义列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceServiceContractsRequest"/></param>
        /// <returns><see cref="DescribeGovernanceServiceContractsResponse"/></returns>
        public DescribeGovernanceServiceContractsResponse DescribeGovernanceServiceContractsSync(DescribeGovernanceServiceContractsRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceServiceContractsResponse>(req, "DescribeGovernanceServiceContracts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询治理中心服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceServicesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceServicesResponse"/></returns>
        public Task<DescribeGovernanceServicesResponse> DescribeGovernanceServices(DescribeGovernanceServicesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceServicesResponse>(req, "DescribeGovernanceServices");
        }

        /// <summary>
        /// 查询治理中心服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGovernanceServicesRequest"/></param>
        /// <returns><see cref="DescribeGovernanceServicesResponse"/></returns>
        public DescribeGovernanceServicesResponse DescribeGovernanceServicesSync(DescribeGovernanceServicesRequest req)
        {
            return InternalRequestAsync<DescribeGovernanceServicesResponse>(req, "DescribeGovernanceServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Nacos类型引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosReplicasRequest"/></param>
        /// <returns><see cref="DescribeNacosReplicasResponse"/></returns>
        public Task<DescribeNacosReplicasResponse> DescribeNacosReplicas(DescribeNacosReplicasRequest req)
        {
            return InternalRequestAsync<DescribeNacosReplicasResponse>(req, "DescribeNacosReplicas");
        }

        /// <summary>
        /// 查询Nacos类型引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosReplicasRequest"/></param>
        /// <returns><see cref="DescribeNacosReplicasResponse"/></returns>
        public DescribeNacosReplicasResponse DescribeNacosReplicasSync(DescribeNacosReplicasRequest req)
        {
            return InternalRequestAsync<DescribeNacosReplicasResponse>(req, "DescribeNacosReplicas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询nacos服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNacosServerInterfacesResponse"/></returns>
        public Task<DescribeNacosServerInterfacesResponse> DescribeNacosServerInterfaces(DescribeNacosServerInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNacosServerInterfacesResponse>(req, "DescribeNacosServerInterfaces");
        }

        /// <summary>
        /// 查询nacos服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNacosServerInterfacesResponse"/></returns>
        public DescribeNacosServerInterfacesResponse DescribeNacosServerInterfacesSync(DescribeNacosServerInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNacosServerInterfacesResponse>(req, "DescribeNacosServerInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生网关分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeGatewayServerGroupsRequest"/></param>
        /// <returns><see cref="DescribeNativeGatewayServerGroupsResponse"/></returns>
        public Task<DescribeNativeGatewayServerGroupsResponse> DescribeNativeGatewayServerGroups(DescribeNativeGatewayServerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeNativeGatewayServerGroupsResponse>(req, "DescribeNativeGatewayServerGroups");
        }

        /// <summary>
        /// 查询云原生网关分组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeGatewayServerGroupsRequest"/></param>
        /// <returns><see cref="DescribeNativeGatewayServerGroupsResponse"/></returns>
        public DescribeNativeGatewayServerGroupsResponse DescribeNativeGatewayServerGroupsSync(DescribeNativeGatewayServerGroupsRequest req)
        {
            return InternalRequestAsync<DescribeNativeGatewayServerGroupsResponse>(req, "DescribeNativeGatewayServerGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生网关服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeOneCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DescribeOneCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<DescribeOneCloudNativeAPIGatewayServiceResponse> DescribeOneCloudNativeAPIGatewayService(DescribeOneCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DescribeOneCloudNativeAPIGatewayServiceResponse>(req, "DescribeOneCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// 获取云原生网关服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeOneCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DescribeOneCloudNativeAPIGatewayServiceResponse"/></returns>
        public DescribeOneCloudNativeAPIGatewayServiceResponse DescribeOneCloudNativeAPIGatewayServiceSync(DescribeOneCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<DescribeOneCloudNativeAPIGatewayServiceResponse>(req, "DescribeOneCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云原生API网关实例公网详情
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkResponse"/></returns>
        public Task<DescribePublicNetworkResponse> DescribePublicNetwork(DescribePublicNetworkRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkResponse>(req, "DescribePublicNetwork");
        }

        /// <summary>
        /// 查询云原生API网关实例公网详情
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkResponse"/></returns>
        public DescribePublicNetworkResponse DescribePublicNetworkSync(DescribePublicNetworkRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkResponse>(req, "DescribePublicNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public Task<DescribeSREInstanceAccessAddressResponse> DescribeSREInstanceAccessAddress(DescribeSREInstanceAccessAddressRequest req)
        {
            return InternalRequestAsync<DescribeSREInstanceAccessAddressResponse>(req, "DescribeSREInstanceAccessAddress");
        }

        /// <summary>
        /// 查询引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public DescribeSREInstanceAccessAddressResponse DescribeSREInstanceAccessAddressSync(DescribeSREInstanceAccessAddressRequest req)
        {
            return InternalRequestAsync<DescribeSREInstanceAccessAddressResponse>(req, "DescribeSREInstanceAccessAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public Task<DescribeSREInstancesResponse> DescribeSREInstances(DescribeSREInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSREInstancesResponse>(req, "DescribeSREInstances");
        }

        /// <summary>
        /// 用于查询引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public DescribeSREInstancesResponse DescribeSREInstancesSync(DescribeSREInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSREInstancesResponse>(req, "DescribeSREInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云原生网关服务健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="DescribeUpstreamHealthCheckConfigResponse"/></returns>
        public Task<DescribeUpstreamHealthCheckConfigResponse> DescribeUpstreamHealthCheckConfig(DescribeUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamHealthCheckConfigResponse>(req, "DescribeUpstreamHealthCheckConfig");
        }

        /// <summary>
        /// 获取云原生网关服务健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="DescribeUpstreamHealthCheckConfigResponse"/></returns>
        public DescribeUpstreamHealthCheckConfigResponse DescribeUpstreamHealthCheckConfigSync(DescribeUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamHealthCheckConfigResponse>(req, "DescribeUpstreamHealthCheckConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 WAF 防护域名
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDomainsRequest"/></param>
        /// <returns><see cref="DescribeWafDomainsResponse"/></returns>
        public Task<DescribeWafDomainsResponse> DescribeWafDomains(DescribeWafDomainsRequest req)
        {
            return InternalRequestAsync<DescribeWafDomainsResponse>(req, "DescribeWafDomains");
        }

        /// <summary>
        /// 获取 WAF 防护域名
        /// </summary>
        /// <param name="req"><see cref="DescribeWafDomainsRequest"/></param>
        /// <returns><see cref="DescribeWafDomainsResponse"/></returns>
        public DescribeWafDomainsResponse DescribeWafDomainsSync(DescribeWafDomainsRequest req)
        {
            return InternalRequestAsync<DescribeWafDomainsResponse>(req, "DescribeWafDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 WAF 防护状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWafProtectionRequest"/></param>
        /// <returns><see cref="DescribeWafProtectionResponse"/></returns>
        public Task<DescribeWafProtectionResponse> DescribeWafProtection(DescribeWafProtectionRequest req)
        {
            return InternalRequestAsync<DescribeWafProtectionResponse>(req, "DescribeWafProtection");
        }

        /// <summary>
        /// 获取 WAF 防护状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWafProtectionRequest"/></param>
        /// <returns><see cref="DescribeWafProtectionResponse"/></returns>
        public DescribeWafProtectionResponse DescribeWafProtectionSync(DescribeWafProtectionRequest req)
        {
            return InternalRequestAsync<DescribeWafProtectionResponse>(req, "DescribeWafProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Zookeeper类型注册引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperReplicasRequest"/></param>
        /// <returns><see cref="DescribeZookeeperReplicasResponse"/></returns>
        public Task<DescribeZookeeperReplicasResponse> DescribeZookeeperReplicas(DescribeZookeeperReplicasRequest req)
        {
            return InternalRequestAsync<DescribeZookeeperReplicasResponse>(req, "DescribeZookeeperReplicas");
        }

        /// <summary>
        /// 查询Zookeeper类型注册引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperReplicasRequest"/></param>
        /// <returns><see cref="DescribeZookeeperReplicasResponse"/></returns>
        public DescribeZookeeperReplicasResponse DescribeZookeeperReplicasSync(DescribeZookeeperReplicasRequest req)
        {
            return InternalRequestAsync<DescribeZookeeperReplicasResponse>(req, "DescribeZookeeperReplicas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询zookeeper服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeZookeeperServerInterfacesResponse"/></returns>
        public Task<DescribeZookeeperServerInterfacesResponse> DescribeZookeeperServerInterfaces(DescribeZookeeperServerInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeZookeeperServerInterfacesResponse>(req, "DescribeZookeeperServerInterfaces");
        }

        /// <summary>
        /// 查询zookeeper服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeZookeeperServerInterfacesResponse"/></returns>
        public DescribeZookeeperServerInterfacesResponse DescribeZookeeperServerInterfacesSync(DescribeZookeeperServerInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeZookeeperServerInterfacesResponse>(req, "DescribeZookeeperServerInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新弹性伸缩策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScalerResourceStrategyResponse"/></returns>
        public Task<ModifyAutoScalerResourceStrategyResponse> ModifyAutoScalerResourceStrategy(ModifyAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalerResourceStrategyResponse>(req, "ModifyAutoScalerResourceStrategy");
        }

        /// <summary>
        /// 更新弹性伸缩策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalerResourceStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScalerResourceStrategyResponse"/></returns>
        public ModifyAutoScalerResourceStrategyResponse ModifyAutoScalerResourceStrategySync(ModifyAutoScalerResourceStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalerResourceStrategyResponse>(req, "ModifyAutoScalerResourceStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生API网关实例基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayResponse> ModifyCloudNativeAPIGateway(ModifyCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayResponse>(req, "ModifyCloudNativeAPIGateway");
        }

        /// <summary>
        /// 修改云原生API网关实例基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayResponse"/></returns>
        public ModifyCloudNativeAPIGatewayResponse ModifyCloudNativeAPIGatewaySync(ModifyCloudNativeAPIGatewayRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayResponse>(req, "ModifyCloudNativeAPIGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayCanaryRuleResponse> ModifyCloudNativeAPIGatewayCanaryRule(ModifyCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCanaryRuleResponse>(req, "ModifyCloudNativeAPIGatewayCanaryRule");
        }

        /// <summary>
        /// 修改云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public ModifyCloudNativeAPIGatewayCanaryRuleResponse ModifyCloudNativeAPIGatewayCanaryRuleSync(ModifyCloudNativeAPIGatewayCanaryRuleRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCanaryRuleResponse>(req, "ModifyCloudNativeAPIGatewayCanaryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新云原生网关证书
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCertificateResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayCertificateResponse> ModifyCloudNativeAPIGatewayCertificate(ModifyCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCertificateResponse>(req, "ModifyCloudNativeAPIGatewayCertificate");
        }

        /// <summary>
        /// 更新云原生网关证书
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCertificateRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCertificateResponse"/></returns>
        public ModifyCloudNativeAPIGatewayCertificateResponse ModifyCloudNativeAPIGatewayCertificateSync(ModifyCloudNativeAPIGatewayCertificateRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayCertificateResponse>(req, "ModifyCloudNativeAPIGatewayCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayRouteResponse> ModifyCloudNativeAPIGatewayRoute(ModifyCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteResponse>(req, "ModifyCloudNativeAPIGatewayRoute");
        }

        /// <summary>
        /// 修改云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteResponse"/></returns>
        public ModifyCloudNativeAPIGatewayRouteResponse ModifyCloudNativeAPIGatewayRouteSync(ModifyCloudNativeAPIGatewayRouteRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteResponse>(req, "ModifyCloudNativeAPIGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayRouteRateLimitResponse> ModifyCloudNativeAPIGatewayRouteRateLimit(ModifyCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayRouteRateLimit");
        }

        /// <summary>
        /// 修改云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public ModifyCloudNativeAPIGatewayRouteRateLimitResponse ModifyCloudNativeAPIGatewayRouteRateLimitSync(ModifyCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayRouteRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayRouteRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayServiceResponse> ModifyCloudNativeAPIGatewayService(ModifyCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceResponse>(req, "ModifyCloudNativeAPIGatewayService");
        }

        /// <summary>
        /// 修改云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceResponse"/></returns>
        public ModifyCloudNativeAPIGatewayServiceResponse ModifyCloudNativeAPIGatewayServiceSync(ModifyCloudNativeAPIGatewayServiceRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceResponse>(req, "ModifyCloudNativeAPIGatewayService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public Task<ModifyCloudNativeAPIGatewayServiceRateLimitResponse> ModifyCloudNativeAPIGatewayServiceRateLimit(ModifyCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayServiceRateLimit");
        }

        /// <summary>
        /// 修改云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public ModifyCloudNativeAPIGatewayServiceRateLimitResponse ModifyCloudNativeAPIGatewayServiceRateLimitSync(ModifyCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
            return InternalRequestAsync<ModifyCloudNativeAPIGatewayServiceRateLimitResponse>(req, "ModifyCloudNativeAPIGatewayServiceRateLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改配置文件组
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigFileGroupRequest"/></param>
        /// <returns><see cref="ModifyConfigFileGroupResponse"/></returns>
        public Task<ModifyConfigFileGroupResponse> ModifyConfigFileGroup(ModifyConfigFileGroupRequest req)
        {
            return InternalRequestAsync<ModifyConfigFileGroupResponse>(req, "ModifyConfigFileGroup");
        }

        /// <summary>
        /// 批量修改配置文件组
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigFileGroupRequest"/></param>
        /// <returns><see cref="ModifyConfigFileGroupResponse"/></returns>
        public ModifyConfigFileGroupResponse ModifyConfigFileGroupSync(ModifyConfigFileGroupRequest req)
        {
            return InternalRequestAsync<ModifyConfigFileGroupResponse>(req, "ModifyConfigFileGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改配置文件
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigFilesRequest"/></param>
        /// <returns><see cref="ModifyConfigFilesResponse"/></returns>
        public Task<ModifyConfigFilesResponse> ModifyConfigFiles(ModifyConfigFilesRequest req)
        {
            return InternalRequestAsync<ModifyConfigFilesResponse>(req, "ModifyConfigFiles");
        }

        /// <summary>
        /// 修改配置文件
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigFilesRequest"/></param>
        /// <returns><see cref="ModifyConfigFilesResponse"/></returns>
        public ModifyConfigFilesResponse ModifyConfigFilesSync(ModifyConfigFilesRequest req)
        {
            return InternalRequestAsync<ModifyConfigFilesResponse>(req, "ModifyConfigFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改网关实例Konga网络配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleNetworkRequest"/></param>
        /// <returns><see cref="ModifyConsoleNetworkResponse"/></returns>
        public Task<ModifyConsoleNetworkResponse> ModifyConsoleNetwork(ModifyConsoleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyConsoleNetworkResponse>(req, "ModifyConsoleNetwork");
        }

        /// <summary>
        /// 修改网关实例Konga网络配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleNetworkRequest"/></param>
        /// <returns><see cref="ModifyConsoleNetworkResponse"/></returns>
        public ModifyConsoleNetworkResponse ModifyConsoleNetworkSync(ModifyConsoleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyConsoleNetworkResponse>(req, "ModifyConsoleNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改治理中心服务别名
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceAliasRequest"/></param>
        /// <returns><see cref="ModifyGovernanceAliasResponse"/></returns>
        public Task<ModifyGovernanceAliasResponse> ModifyGovernanceAlias(ModifyGovernanceAliasRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceAliasResponse>(req, "ModifyGovernanceAlias");
        }

        /// <summary>
        /// 修改治理中心服务别名
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceAliasRequest"/></param>
        /// <returns><see cref="ModifyGovernanceAliasResponse"/></returns>
        public ModifyGovernanceAliasResponse ModifyGovernanceAliasSync(ModifyGovernanceAliasRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceAliasResponse>(req, "ModifyGovernanceAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改治理中心服务实例
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceInstancesRequest"/></param>
        /// <returns><see cref="ModifyGovernanceInstancesResponse"/></returns>
        public Task<ModifyGovernanceInstancesResponse> ModifyGovernanceInstances(ModifyGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceInstancesResponse>(req, "ModifyGovernanceInstances");
        }

        /// <summary>
        /// 修改治理中心服务实例
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceInstancesRequest"/></param>
        /// <returns><see cref="ModifyGovernanceInstancesResponse"/></returns>
        public ModifyGovernanceInstancesResponse ModifyGovernanceInstancesSync(ModifyGovernanceInstancesRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceInstancesResponse>(req, "ModifyGovernanceInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改治理中心命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="ModifyGovernanceNamespacesResponse"/></returns>
        public Task<ModifyGovernanceNamespacesResponse> ModifyGovernanceNamespaces(ModifyGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceNamespacesResponse>(req, "ModifyGovernanceNamespaces");
        }

        /// <summary>
        /// 修改治理中心命名空间
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceNamespacesRequest"/></param>
        /// <returns><see cref="ModifyGovernanceNamespacesResponse"/></returns>
        public ModifyGovernanceNamespacesResponse ModifyGovernanceNamespacesSync(ModifyGovernanceNamespacesRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceNamespacesResponse>(req, "ModifyGovernanceNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改治理中心服务
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceServicesRequest"/></param>
        /// <returns><see cref="ModifyGovernanceServicesResponse"/></returns>
        public Task<ModifyGovernanceServicesResponse> ModifyGovernanceServices(ModifyGovernanceServicesRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceServicesResponse>(req, "ModifyGovernanceServices");
        }

        /// <summary>
        /// 修改治理中心服务
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernanceServicesRequest"/></param>
        /// <returns><see cref="ModifyGovernanceServicesResponse"/></returns>
        public ModifyGovernanceServicesResponse ModifyGovernanceServicesSync(ModifyGovernanceServicesRequest req)
        {
            return InternalRequestAsync<ModifyGovernanceServicesResponse>(req, "ModifyGovernanceServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生API网关实例分组基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServerGroupResponse"/></returns>
        public Task<ModifyNativeGatewayServerGroupResponse> ModifyNativeGatewayServerGroup(ModifyNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<ModifyNativeGatewayServerGroupResponse>(req, "ModifyNativeGatewayServerGroup");
        }

        /// <summary>
        /// 修改云原生API网关实例分组基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServerGroupResponse"/></returns>
        public ModifyNativeGatewayServerGroupResponse ModifyNativeGatewayServerGroupSync(ModifyNativeGatewayServerGroupRequest req)
        {
            return InternalRequestAsync<ModifyNativeGatewayServerGroupResponse>(req, "ModifyNativeGatewayServerGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生API网关实例Kong访问策略，支持白名单或者黑名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAccessStrategyRequest"/></param>
        /// <returns><see cref="ModifyNetworkAccessStrategyResponse"/></returns>
        public Task<ModifyNetworkAccessStrategyResponse> ModifyNetworkAccessStrategy(ModifyNetworkAccessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAccessStrategyResponse>(req, "ModifyNetworkAccessStrategy");
        }

        /// <summary>
        /// 修改云原生API网关实例Kong访问策略，支持白名单或者黑名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAccessStrategyRequest"/></param>
        /// <returns><see cref="ModifyNetworkAccessStrategyResponse"/></returns>
        public ModifyNetworkAccessStrategyResponse ModifyNetworkAccessStrategySync(ModifyNetworkAccessStrategyRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAccessStrategyResponse>(req, "ModifyNetworkAccessStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生API网关实例网络基本信息，例如带宽以及描述，只支持修改客户端公网/内网的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyNetworkBasicInfoResponse"/></returns>
        public Task<ModifyNetworkBasicInfoResponse> ModifyNetworkBasicInfo(ModifyNetworkBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyNetworkBasicInfoResponse>(req, "ModifyNetworkBasicInfo");
        }

        /// <summary>
        /// 修改云原生API网关实例网络基本信息，例如带宽以及描述，只支持修改客户端公网/内网的信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyNetworkBasicInfoResponse"/></returns>
        public ModifyNetworkBasicInfoResponse ModifyNetworkBasicInfoSync(ModifyNetworkBasicInfoRequest req)
        {
            return InternalRequestAsync<ModifyNetworkBasicInfoResponse>(req, "ModifyNetworkBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生网关上游实例节点健康状态
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyUpstreamNodeStatusResponse"/></returns>
        public Task<ModifyUpstreamNodeStatusResponse> ModifyUpstreamNodeStatus(ModifyUpstreamNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamNodeStatusResponse>(req, "ModifyUpstreamNodeStatus");
        }

        /// <summary>
        /// 修改云原生网关上游实例节点健康状态
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamNodeStatusRequest"/></param>
        /// <returns><see cref="ModifyUpstreamNodeStatusResponse"/></returns>
        public ModifyUpstreamNodeStatusResponse ModifyUpstreamNodeStatusSync(ModifyUpstreamNodeStatusRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamNodeStatusResponse>(req, "ModifyUpstreamNodeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启 WAF 防护
        /// </summary>
        /// <param name="req"><see cref="OpenWafProtectionRequest"/></param>
        /// <returns><see cref="OpenWafProtectionResponse"/></returns>
        public Task<OpenWafProtectionResponse> OpenWafProtection(OpenWafProtectionRequest req)
        {
            return InternalRequestAsync<OpenWafProtectionResponse>(req, "OpenWafProtection");
        }

        /// <summary>
        /// 开启 WAF 防护
        /// </summary>
        /// <param name="req"><see cref="OpenWafProtectionRequest"/></param>
        /// <returns><see cref="OpenWafProtectionResponse"/></returns>
        public OpenWafProtectionResponse OpenWafProtectionSync(OpenWafProtectionRequest req)
        {
            return InternalRequestAsync<OpenWafProtectionResponse>(req, "OpenWafProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布配置文件
        /// </summary>
        /// <param name="req"><see cref="PublishConfigFilesRequest"/></param>
        /// <returns><see cref="PublishConfigFilesResponse"/></returns>
        public Task<PublishConfigFilesResponse> PublishConfigFiles(PublishConfigFilesRequest req)
        {
            return InternalRequestAsync<PublishConfigFilesResponse>(req, "PublishConfigFiles");
        }

        /// <summary>
        /// 发布配置文件
        /// </summary>
        /// <param name="req"><see cref="PublishConfigFilesRequest"/></param>
        /// <returns><see cref="PublishConfigFilesResponse"/></returns>
        public PublishConfigFilesResponse PublishConfigFilesSync(PublishConfigFilesRequest req)
        {
            return InternalRequestAsync<PublishConfigFilesResponse>(req, "PublishConfigFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回滚配置发布
        /// </summary>
        /// <param name="req"><see cref="RollbackConfigFileReleasesRequest"/></param>
        /// <returns><see cref="RollbackConfigFileReleasesResponse"/></returns>
        public Task<RollbackConfigFileReleasesResponse> RollbackConfigFileReleases(RollbackConfigFileReleasesRequest req)
        {
            return InternalRequestAsync<RollbackConfigFileReleasesResponse>(req, "RollbackConfigFileReleases");
        }

        /// <summary>
        /// 回滚配置发布
        /// </summary>
        /// <param name="req"><see cref="RollbackConfigFileReleasesRequest"/></param>
        /// <returns><see cref="RollbackConfigFileReleasesResponse"/></returns>
        public RollbackConfigFileReleasesResponse RollbackConfigFileReleasesSync(RollbackConfigFileReleasesRequest req)
        {
            return InternalRequestAsync<RollbackConfigFileReleasesResponse>(req, "RollbackConfigFileReleases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 弹性伸缩策略批量解绑网关分组
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoScalerResourceStrategyFromGroupsRequest"/></param>
        /// <returns><see cref="UnbindAutoScalerResourceStrategyFromGroupsResponse"/></returns>
        public Task<UnbindAutoScalerResourceStrategyFromGroupsResponse> UnbindAutoScalerResourceStrategyFromGroups(UnbindAutoScalerResourceStrategyFromGroupsRequest req)
        {
            return InternalRequestAsync<UnbindAutoScalerResourceStrategyFromGroupsResponse>(req, "UnbindAutoScalerResourceStrategyFromGroups");
        }

        /// <summary>
        /// 弹性伸缩策略批量解绑网关分组
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoScalerResourceStrategyFromGroupsRequest"/></param>
        /// <returns><see cref="UnbindAutoScalerResourceStrategyFromGroupsResponse"/></returns>
        public UnbindAutoScalerResourceStrategyFromGroupsResponse UnbindAutoScalerResourceStrategyFromGroupsSync(UnbindAutoScalerResourceStrategyFromGroupsRequest req)
        {
            return InternalRequestAsync<UnbindAutoScalerResourceStrategyFromGroupsResponse>(req, "UnbindAutoScalerResourceStrategyFromGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生网关证书信息
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewayCertificateInfoRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewayCertificateInfoResponse"/></returns>
        public Task<UpdateCloudNativeAPIGatewayCertificateInfoResponse> UpdateCloudNativeAPIGatewayCertificateInfo(UpdateCloudNativeAPIGatewayCertificateInfoRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewayCertificateInfoResponse>(req, "UpdateCloudNativeAPIGatewayCertificateInfo");
        }

        /// <summary>
        /// 修改云原生网关证书信息
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewayCertificateInfoRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewayCertificateInfoResponse"/></returns>
        public UpdateCloudNativeAPIGatewayCertificateInfoResponse UpdateCloudNativeAPIGatewayCertificateInfoSync(UpdateCloudNativeAPIGatewayCertificateInfoRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewayCertificateInfoResponse>(req, "UpdateCloudNativeAPIGatewayCertificateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云原生API网关实例的节点规格信息，例如节点扩缩容或者升降配
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewaySpecRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewaySpecResponse"/></returns>
        public Task<UpdateCloudNativeAPIGatewaySpecResponse> UpdateCloudNativeAPIGatewaySpec(UpdateCloudNativeAPIGatewaySpecRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewaySpecResponse>(req, "UpdateCloudNativeAPIGatewaySpec");
        }

        /// <summary>
        /// 修改云原生API网关实例的节点规格信息，例如节点扩缩容或者升降配
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewaySpecRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewaySpecResponse"/></returns>
        public UpdateCloudNativeAPIGatewaySpecResponse UpdateCloudNativeAPIGatewaySpecSync(UpdateCloudNativeAPIGatewaySpecRequest req)
        {
            return InternalRequestAsync<UpdateCloudNativeAPIGatewaySpecResponse>(req, "UpdateCloudNativeAPIGatewaySpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改引擎公网访问配置
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineInternetAccessRequest"/></param>
        /// <returns><see cref="UpdateEngineInternetAccessResponse"/></returns>
        public Task<UpdateEngineInternetAccessResponse> UpdateEngineInternetAccess(UpdateEngineInternetAccessRequest req)
        {
            return InternalRequestAsync<UpdateEngineInternetAccessResponse>(req, "UpdateEngineInternetAccess");
        }

        /// <summary>
        /// 修改引擎公网访问配置
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineInternetAccessRequest"/></param>
        /// <returns><see cref="UpdateEngineInternetAccessResponse"/></returns>
        public UpdateEngineInternetAccessResponse UpdateEngineInternetAccessSync(UpdateEngineInternetAccessRequest req)
        {
            return InternalRequestAsync<UpdateEngineInternetAccessResponse>(req, "UpdateEngineInternetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新云原生网关健康检查配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="UpdateUpstreamHealthCheckConfigResponse"/></returns>
        public Task<UpdateUpstreamHealthCheckConfigResponse> UpdateUpstreamHealthCheckConfig(UpdateUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamHealthCheckConfigResponse>(req, "UpdateUpstreamHealthCheckConfig");
        }

        /// <summary>
        /// 更新云原生网关健康检查配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamHealthCheckConfigRequest"/></param>
        /// <returns><see cref="UpdateUpstreamHealthCheckConfigResponse"/></returns>
        public UpdateUpstreamHealthCheckConfigResponse UpdateUpstreamHealthCheckConfigSync(UpdateUpstreamHealthCheckConfigRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamHealthCheckConfigResponse>(req, "UpdateUpstreamHealthCheckConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新网关上游实例列表，仅支持IPList服务类型
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamTargetsRequest"/></param>
        /// <returns><see cref="UpdateUpstreamTargetsResponse"/></returns>
        public Task<UpdateUpstreamTargetsResponse> UpdateUpstreamTargets(UpdateUpstreamTargetsRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamTargetsResponse>(req, "UpdateUpstreamTargets");
        }

        /// <summary>
        /// 更新网关上游实例列表，仅支持IPList服务类型
        /// </summary>
        /// <param name="req"><see cref="UpdateUpstreamTargetsRequest"/></param>
        /// <returns><see cref="UpdateUpstreamTargetsResponse"/></returns>
        public UpdateUpstreamTargetsResponse UpdateUpstreamTargetsSync(UpdateUpstreamTargetsRequest req)
        {
            return InternalRequestAsync<UpdateUpstreamTargetsResponse>(req, "UpdateUpstreamTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
