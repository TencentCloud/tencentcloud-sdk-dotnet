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

namespace TencentCloud.Apigateway.V20180808
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apigateway.V20180808.Models;

   public class ApigatewayClient : AbstractClient{

       private const string endpoint = "apigateway.tencentcloudapi.com";
       private const string version = "2018-08-08";
       private const string sdkVersion = "SDK_NET_3.0.1273";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApigatewayClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApigatewayClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 绑定插件到API上。
        /// </summary>
        /// <param name="req"><see cref="AttachPluginRequest"/></param>
        /// <returns><see cref="AttachPluginResponse"/></returns>
        public Task<AttachPluginResponse> AttachPlugin(AttachPluginRequest req)
        {
            return InternalRequestAsync<AttachPluginResponse>(req, "AttachPlugin");
        }

        /// <summary>
        /// 绑定插件到API上。
        /// </summary>
        /// <param name="req"><see cref="AttachPluginRequest"/></param>
        /// <returns><see cref="AttachPluginResponse"/></returns>
        public AttachPluginResponse AttachPluginSync(AttachPluginRequest req)
        {
            return InternalRequestAsync<AttachPluginResponse>(req, "AttachPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BindApiApp）用于绑定应用到API。
        /// </summary>
        /// <param name="req"><see cref="BindApiAppRequest"/></param>
        /// <returns><see cref="BindApiAppResponse"/></returns>
        public Task<BindApiAppResponse> BindApiApp(BindApiAppRequest req)
        {
            return InternalRequestAsync<BindApiAppResponse>(req, "BindApiApp");
        }

        /// <summary>
        /// 本接口（BindApiApp）用于绑定应用到API。
        /// </summary>
        /// <param name="req"><see cref="BindApiAppRequest"/></param>
        /// <returns><see cref="BindApiAppResponse"/></returns>
        public BindApiAppResponse BindApiAppSync(BindApiAppRequest req)
        {
            return InternalRequestAsync<BindApiAppResponse>(req, "BindApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BindEnvironment）用于绑定使用计划到服务或API。
        /// 用户在发布服务到某个环境中后，如果 API 需要鉴权，还需要绑定使用计划才能进行调用，此接口用户将使用计划绑定到特定环境。
        /// 目前支持绑定使用计划到API，但是同一个服务不能同时存在绑定到服务的使用计划和绑定到API的使用计划，所以对已经绑定过服务级别使用计划的环境，请先使用 服务级别使用计划降级 接口进行降级操作。
        /// </summary>
        /// <param name="req"><see cref="BindEnvironmentRequest"/></param>
        /// <returns><see cref="BindEnvironmentResponse"/></returns>
        public Task<BindEnvironmentResponse> BindEnvironment(BindEnvironmentRequest req)
        {
            return InternalRequestAsync<BindEnvironmentResponse>(req, "BindEnvironment");
        }

        /// <summary>
        /// 本接口（BindEnvironment）用于绑定使用计划到服务或API。
        /// 用户在发布服务到某个环境中后，如果 API 需要鉴权，还需要绑定使用计划才能进行调用，此接口用户将使用计划绑定到特定环境。
        /// 目前支持绑定使用计划到API，但是同一个服务不能同时存在绑定到服务的使用计划和绑定到API的使用计划，所以对已经绑定过服务级别使用计划的环境，请先使用 服务级别使用计划降级 接口进行降级操作。
        /// </summary>
        /// <param name="req"><see cref="BindEnvironmentRequest"/></param>
        /// <returns><see cref="BindEnvironmentResponse"/></returns>
        public BindEnvironmentResponse BindEnvironmentSync(BindEnvironmentRequest req)
        {
            return InternalRequestAsync<BindEnvironmentResponse>(req, "BindEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BindIPStrategy）用于API绑定IP策略。
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public Task<BindIPStrategyResponse> BindIPStrategy(BindIPStrategyRequest req)
        {
            return InternalRequestAsync<BindIPStrategyResponse>(req, "BindIPStrategy");
        }

        /// <summary>
        /// 本接口（BindIPStrategy）用于API绑定IP策略。
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public BindIPStrategyResponse BindIPStrategySync(BindIPStrategyRequest req)
        {
            return InternalRequestAsync<BindIPStrategyResponse>(req, "BindIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BindSecretIds）用于为使用计划绑定密钥。
        /// 将密钥绑定到某个使用计划，并将此使用计划绑定到某个服务发布的环境上，调用者方可使用此密钥调用这个服务中的 API，可使用本接口为使用计划绑定密钥。
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public Task<BindSecretIdsResponse> BindSecretIds(BindSecretIdsRequest req)
        {
            return InternalRequestAsync<BindSecretIdsResponse>(req, "BindSecretIds");
        }

        /// <summary>
        /// 本接口（BindSecretIds）用于为使用计划绑定密钥。
        /// 将密钥绑定到某个使用计划，并将此使用计划绑定到某个服务发布的环境上，调用者方可使用此密钥调用这个服务中的 API，可使用本接口为使用计划绑定密钥。
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public BindSecretIdsResponse BindSecretIdsSync(BindSecretIdsRequest req)
        {
            return InternalRequestAsync<BindSecretIdsResponse>(req, "BindSecretIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BindSubDomain）用于绑定自定义域名到服务。
        /// API 网关中每个服务都会提供一个默认的域名供用户调用，但当用户想使用自己的已有域名时，也可以将自定义域名绑定到此服务，在做好备案、与默认域名的 CNAME 后，可直接调用自定义域名。
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public Task<BindSubDomainResponse> BindSubDomain(BindSubDomainRequest req)
        {
            return InternalRequestAsync<BindSubDomainResponse>(req, "BindSubDomain");
        }

        /// <summary>
        /// 本接口（BindSubDomain）用于绑定自定义域名到服务。
        /// API 网关中每个服务都会提供一个默认的域名供用户调用，但当用户想使用自己的已有域名时，也可以将自定义域名绑定到此服务，在做好备案、与默认域名的 CNAME 后，可直接调用自定义域名。
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public BindSubDomainResponse BindSubDomainSync(BindSubDomainRequest req)
        {
            return InternalRequestAsync<BindSubDomainResponse>(req, "BindSubDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 构建 API 文档
        /// </summary>
        /// <param name="req"><see cref="BuildAPIDocRequest"/></param>
        /// <returns><see cref="BuildAPIDocResponse"/></returns>
        public Task<BuildAPIDocResponse> BuildAPIDoc(BuildAPIDocRequest req)
        {
            return InternalRequestAsync<BuildAPIDocResponse>(req, "BuildAPIDoc");
        }

        /// <summary>
        /// 构建 API 文档
        /// </summary>
        /// <param name="req"><see cref="BuildAPIDocRequest"/></param>
        /// <returns><see cref="BuildAPIDocResponse"/></returns>
        public BuildAPIDocResponse BuildAPIDocSync(BuildAPIDocRequest req)
        {
            return InternalRequestAsync<BuildAPIDocResponse>(req, "BuildAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 API 文档
        /// </summary>
        /// <param name="req"><see cref="CreateAPIDocRequest"/></param>
        /// <returns><see cref="CreateAPIDocResponse"/></returns>
        public Task<CreateAPIDocResponse> CreateAPIDoc(CreateAPIDocRequest req)
        {
            return InternalRequestAsync<CreateAPIDocResponse>(req, "CreateAPIDoc");
        }

        /// <summary>
        /// 创建 API 文档
        /// </summary>
        /// <param name="req"><see cref="CreateAPIDocRequest"/></param>
        /// <returns><see cref="CreateAPIDocResponse"/></returns>
        public CreateAPIDocResponse CreateAPIDocSync(CreateAPIDocRequest req)
        {
            return InternalRequestAsync<CreateAPIDocResponse>(req, "CreateAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateApi）用于创建 API 接口，创建 API 前，用户需要先创建服务，每个 API 都有自己归属的服务。
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public Task<CreateApiResponse> CreateApi(CreateApiRequest req)
        {
            return InternalRequestAsync<CreateApiResponse>(req, "CreateApi");
        }

        /// <summary>
        /// 本接口（CreateApi）用于创建 API 接口，创建 API 前，用户需要先创建服务，每个 API 都有自己归属的服务。
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public CreateApiResponse CreateApiSync(CreateApiRequest req)
        {
            return InternalRequestAsync<CreateApiResponse>(req, "CreateApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateApiApp）用于创建应用。
        /// </summary>
        /// <param name="req"><see cref="CreateApiAppRequest"/></param>
        /// <returns><see cref="CreateApiAppResponse"/></returns>
        public Task<CreateApiAppResponse> CreateApiApp(CreateApiAppRequest req)
        {
            return InternalRequestAsync<CreateApiAppResponse>(req, "CreateApiApp");
        }

        /// <summary>
        /// 本接口（CreateApiApp）用于创建应用。
        /// </summary>
        /// <param name="req"><see cref="CreateApiAppRequest"/></param>
        /// <returns><see cref="CreateApiAppResponse"/></returns>
        public CreateApiAppResponse CreateApiAppSync(CreateApiAppRequest req)
        {
            return InternalRequestAsync<CreateApiAppResponse>(req, "CreateApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateApiKey）用于创建一对新的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public Task<CreateApiKeyResponse> CreateApiKey(CreateApiKeyRequest req)
        {
            return InternalRequestAsync<CreateApiKeyResponse>(req, "CreateApiKey");
        }

        /// <summary>
        /// 本接口（CreateApiKey）用于创建一对新的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public CreateApiKeyResponse CreateApiKeySync(CreateApiKeyRequest req)
        {
            return InternalRequestAsync<CreateApiKeyResponse>(req, "CreateApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建专享实例
        /// </summary>
        /// <param name="req"><see cref="CreateExclusiveInstancesRequest"/></param>
        /// <returns><see cref="CreateExclusiveInstancesResponse"/></returns>
        public Task<CreateExclusiveInstancesResponse> CreateExclusiveInstances(CreateExclusiveInstancesRequest req)
        {
            return InternalRequestAsync<CreateExclusiveInstancesResponse>(req, "CreateExclusiveInstances");
        }

        /// <summary>
        /// 创建专享实例
        /// </summary>
        /// <param name="req"><see cref="CreateExclusiveInstancesRequest"/></param>
        /// <returns><see cref="CreateExclusiveInstancesResponse"/></returns>
        public CreateExclusiveInstancesResponse CreateExclusiveInstancesSync(CreateExclusiveInstancesRequest req)
        {
            return InternalRequestAsync<CreateExclusiveInstancesResponse>(req, "CreateExclusiveInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateIPStrategy）用于创建服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public Task<CreateIPStrategyResponse> CreateIPStrategy(CreateIPStrategyRequest req)
        {
            return InternalRequestAsync<CreateIPStrategyResponse>(req, "CreateIPStrategy");
        }

        /// <summary>
        /// 本接口（CreateIPStrategy）用于创建服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public CreateIPStrategyResponse CreateIPStrategySync(CreateIPStrategyRequest req)
        {
            return InternalRequestAsync<CreateIPStrategyResponse>(req, "CreateIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建API网关插件。
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public Task<CreatePluginResponse> CreatePlugin(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin");
        }

        /// <summary>
        /// 创建API网关插件。
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public CreatePluginResponse CreatePluginSync(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateService）用于创建服务。
        /// API 网关使用的最大单元为服务，每个服务中可创建多个 API 接口。每个服务有一个默认域名供客户调用，用户也可绑定自定义域名到此服务中。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public Task<CreateServiceResponse> CreateService(CreateServiceRequest req)
        {
            return InternalRequestAsync<CreateServiceResponse>(req, "CreateService");
        }

        /// <summary>
        /// 本接口（CreateService）用于创建服务。
        /// API 网关使用的最大单元为服务，每个服务中可创建多个 API 接口。每个服务有一个默认域名供客户调用，用户也可绑定自定义域名到此服务中。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public CreateServiceResponse CreateServiceSync(CreateServiceRequest req)
        {
            return InternalRequestAsync<CreateServiceResponse>(req, "CreateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建后端通道
        /// </summary>
        /// <param name="req"><see cref="CreateUpstreamRequest"/></param>
        /// <returns><see cref="CreateUpstreamResponse"/></returns>
        public Task<CreateUpstreamResponse> CreateUpstream(CreateUpstreamRequest req)
        {
            return InternalRequestAsync<CreateUpstreamResponse>(req, "CreateUpstream");
        }

        /// <summary>
        /// 用于创建后端通道
        /// </summary>
        /// <param name="req"><see cref="CreateUpstreamRequest"/></param>
        /// <returns><see cref="CreateUpstreamResponse"/></returns>
        public CreateUpstreamResponse CreateUpstreamSync(CreateUpstreamRequest req)
        {
            return InternalRequestAsync<CreateUpstreamResponse>(req, "CreateUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateUsagePlan）用于创建使用计划。
        /// 用户在使用 API 网关时，需要创建使用计划并将其绑定到服务的环境中使用。
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public Task<CreateUsagePlanResponse> CreateUsagePlan(CreateUsagePlanRequest req)
        {
            return InternalRequestAsync<CreateUsagePlanResponse>(req, "CreateUsagePlan");
        }

        /// <summary>
        /// 本接口（CreateUsagePlan）用于创建使用计划。
        /// 用户在使用 API 网关时，需要创建使用计划并将其绑定到服务的环境中使用。
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public CreateUsagePlanResponse CreateUsagePlanSync(CreateUsagePlanRequest req)
        {
            return InternalRequestAsync<CreateUsagePlanResponse>(req, "CreateUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 API 文档
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIDocRequest"/></param>
        /// <returns><see cref="DeleteAPIDocResponse"/></returns>
        public Task<DeleteAPIDocResponse> DeleteAPIDoc(DeleteAPIDocRequest req)
        {
            return InternalRequestAsync<DeleteAPIDocResponse>(req, "DeleteAPIDoc");
        }

        /// <summary>
        /// 删除 API 文档
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIDocRequest"/></param>
        /// <returns><see cref="DeleteAPIDocResponse"/></returns>
        public DeleteAPIDocResponse DeleteAPIDocSync(DeleteAPIDocRequest req)
        {
            return InternalRequestAsync<DeleteAPIDocResponse>(req, "DeleteAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteApi）用于删除已经创建的API。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public Task<DeleteApiResponse> DeleteApi(DeleteApiRequest req)
        {
            return InternalRequestAsync<DeleteApiResponse>(req, "DeleteApi");
        }

        /// <summary>
        /// 本接口（DeleteApi）用于删除已经创建的API。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public DeleteApiResponse DeleteApiSync(DeleteApiRequest req)
        {
            return InternalRequestAsync<DeleteApiResponse>(req, "DeleteApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteApiApp）用于删除已经创建的应用。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiAppRequest"/></param>
        /// <returns><see cref="DeleteApiAppResponse"/></returns>
        public Task<DeleteApiAppResponse> DeleteApiApp(DeleteApiAppRequest req)
        {
            return InternalRequestAsync<DeleteApiAppResponse>(req, "DeleteApiApp");
        }

        /// <summary>
        /// 本接口（DeleteApiApp）用于删除已经创建的应用。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiAppRequest"/></param>
        /// <returns><see cref="DeleteApiAppResponse"/></returns>
        public DeleteApiAppResponse DeleteApiAppSync(DeleteApiAppRequest req)
        {
            return InternalRequestAsync<DeleteApiAppResponse>(req, "DeleteApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteApiKey）用于删除一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public Task<DeleteApiKeyResponse> DeleteApiKey(DeleteApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteApiKeyResponse>(req, "DeleteApiKey");
        }

        /// <summary>
        /// 本接口（DeleteApiKey）用于删除一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public DeleteApiKeyResponse DeleteApiKeySync(DeleteApiKeyRequest req)
        {
            return InternalRequestAsync<DeleteApiKeyResponse>(req, "DeleteApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteIPStrategy）用于删除服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public Task<DeleteIPStrategyResponse> DeleteIPStrategy(DeleteIPStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIPStrategyResponse>(req, "DeleteIPStrategy");
        }

        /// <summary>
        /// 本接口（DeleteIPStrategy）用于删除服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public DeleteIPStrategyResponse DeleteIPStrategySync(DeleteIPStrategyRequest req)
        {
            return InternalRequestAsync<DeleteIPStrategyResponse>(req, "DeleteIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除API网关插件
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public Task<DeletePluginResponse> DeletePlugin(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin");
        }

        /// <summary>
        /// 删除API网关插件
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public DeletePluginResponse DeletePluginSync(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteService）用于删除 API 网关中某个服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public Task<DeleteServiceResponse> DeleteService(DeleteServiceRequest req)
        {
            return InternalRequestAsync<DeleteServiceResponse>(req, "DeleteService");
        }

        /// <summary>
        /// 本接口（DeleteService）用于删除 API 网关中某个服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public DeleteServiceResponse DeleteServiceSync(DeleteServiceRequest req)
        {
            return InternalRequestAsync<DeleteServiceResponse>(req, "DeleteService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteServiceSubDomainMapping）用于删除服务中某个环境的自定义域名映射。
        /// 当用户使用自定义域名，并使用了自定义映射时，可使用此接口。但需注意，若删除了所有环境的映射时，调用此 API 均会返回失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public Task<DeleteServiceSubDomainMappingResponse> DeleteServiceSubDomainMapping(DeleteServiceSubDomainMappingRequest req)
        {
            return InternalRequestAsync<DeleteServiceSubDomainMappingResponse>(req, "DeleteServiceSubDomainMapping");
        }

        /// <summary>
        /// 本接口（DeleteServiceSubDomainMapping）用于删除服务中某个环境的自定义域名映射。
        /// 当用户使用自定义域名，并使用了自定义映射时，可使用此接口。但需注意，若删除了所有环境的映射时，调用此 API 均会返回失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public DeleteServiceSubDomainMappingResponse DeleteServiceSubDomainMappingSync(DeleteServiceSubDomainMappingRequest req)
        {
            return InternalRequestAsync<DeleteServiceSubDomainMappingResponse>(req, "DeleteServiceSubDomainMapping")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除后端通道，需要注意有API绑定时，不允许删除
        /// </summary>
        /// <param name="req"><see cref="DeleteUpstreamRequest"/></param>
        /// <returns><see cref="DeleteUpstreamResponse"/></returns>
        public Task<DeleteUpstreamResponse> DeleteUpstream(DeleteUpstreamRequest req)
        {
            return InternalRequestAsync<DeleteUpstreamResponse>(req, "DeleteUpstream");
        }

        /// <summary>
        /// 删除后端通道，需要注意有API绑定时，不允许删除
        /// </summary>
        /// <param name="req"><see cref="DeleteUpstreamRequest"/></param>
        /// <returns><see cref="DeleteUpstreamResponse"/></returns>
        public DeleteUpstreamResponse DeleteUpstreamSync(DeleteUpstreamRequest req)
        {
            return InternalRequestAsync<DeleteUpstreamResponse>(req, "DeleteUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteUsagePlan）用于删除使用计划。
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public Task<DeleteUsagePlanResponse> DeleteUsagePlan(DeleteUsagePlanRequest req)
        {
            return InternalRequestAsync<DeleteUsagePlanResponse>(req, "DeleteUsagePlan");
        }

        /// <summary>
        /// 本接口（DeleteUsagePlan）用于删除使用计划。
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public DeleteUsagePlanResponse DeleteUsagePlanSync(DeleteUsagePlanRequest req)
        {
            return InternalRequestAsync<DeleteUsagePlanResponse>(req, "DeleteUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DemoteServiceUsagePlan）用于将某个服务在某个环境的使用计划，降级到API上。
        /// 如果服务内没有API不允许进行此操作。
        /// 如果当前环境没有发布，不允许进行此操作。
        /// </summary>
        /// <param name="req"><see cref="DemoteServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DemoteServiceUsagePlanResponse"/></returns>
        public Task<DemoteServiceUsagePlanResponse> DemoteServiceUsagePlan(DemoteServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DemoteServiceUsagePlanResponse>(req, "DemoteServiceUsagePlan");
        }

        /// <summary>
        /// 本接口（DemoteServiceUsagePlan）用于将某个服务在某个环境的使用计划，降级到API上。
        /// 如果服务内没有API不允许进行此操作。
        /// 如果当前环境没有发布，不允许进行此操作。
        /// </summary>
        /// <param name="req"><see cref="DemoteServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DemoteServiceUsagePlanResponse"/></returns>
        public DemoteServiceUsagePlanResponse DemoteServiceUsagePlanSync(DemoteServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DemoteServiceUsagePlanResponse>(req, "DemoteServiceUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 API 文档详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocDetailRequest"/></param>
        /// <returns><see cref="DescribeAPIDocDetailResponse"/></returns>
        public Task<DescribeAPIDocDetailResponse> DescribeAPIDocDetail(DescribeAPIDocDetailRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocDetailResponse>(req, "DescribeAPIDocDetail");
        }

        /// <summary>
        /// 查询 API 文档详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocDetailRequest"/></param>
        /// <returns><see cref="DescribeAPIDocDetailResponse"/></returns>
        public DescribeAPIDocDetailResponse DescribeAPIDocDetailSync(DescribeAPIDocDetailRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocDetailResponse>(req, "DescribeAPIDocDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 API 文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocsRequest"/></param>
        /// <returns><see cref="DescribeAPIDocsResponse"/></returns>
        public Task<DescribeAPIDocsResponse> DescribeAPIDocs(DescribeAPIDocsRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocsResponse>(req, "DescribeAPIDocs");
        }

        /// <summary>
        /// 查询 API 文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIDocsRequest"/></param>
        /// <returns><see cref="DescribeAPIDocsResponse"/></returns>
        public DescribeAPIDocsResponse DescribeAPIDocsSync(DescribeAPIDocsRequest req)
        {
            return InternalRequestAsync<DescribeAPIDocsResponse>(req, "DescribeAPIDocs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示插件相关的API列表，包括已绑定的和未绑定的API信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllPluginApisRequest"/></param>
        /// <returns><see cref="DescribeAllPluginApisResponse"/></returns>
        public Task<DescribeAllPluginApisResponse> DescribeAllPluginApis(DescribeAllPluginApisRequest req)
        {
            return InternalRequestAsync<DescribeAllPluginApisResponse>(req, "DescribeAllPluginApis");
        }

        /// <summary>
        /// 展示插件相关的API列表，包括已绑定的和未绑定的API信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllPluginApisRequest"/></param>
        /// <returns><see cref="DescribeAllPluginApisResponse"/></returns>
        public DescribeAllPluginApisResponse DescribeAllPluginApisSync(DescribeAllPluginApisRequest req)
        {
            return InternalRequestAsync<DescribeAllPluginApisResponse>(req, "DescribeAllPluginApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApi）用于查询用户 API 网关的 API 接口的详细信息。​
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public Task<DescribeApiResponse> DescribeApi(DescribeApiRequest req)
        {
            return InternalRequestAsync<DescribeApiResponse>(req, "DescribeApi");
        }

        /// <summary>
        /// 本接口（DescribeApi）用于查询用户 API 网关的 API 接口的详细信息。​
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public DescribeApiResponse DescribeApiSync(DescribeApiRequest req)
        {
            return InternalRequestAsync<DescribeApiResponse>(req, "DescribeApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiApp）用于根据应用ID搜索应用。此接口已下线，如需使用功能请使用DescribeApiAppsStatus接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiAppResponse"/></returns>
        public Task<DescribeApiAppResponse> DescribeApiApp(DescribeApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiAppResponse>(req, "DescribeApiApp");
        }

        /// <summary>
        /// 本接口（DescribeApiApp）用于根据应用ID搜索应用。此接口已下线，如需使用功能请使用DescribeApiAppsStatus接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiAppResponse"/></returns>
        public DescribeApiAppResponse DescribeApiAppSync(DescribeApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiAppResponse>(req, "DescribeApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiAppBindApisStatus）查询应用绑定的Api列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppBindApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppBindApisStatusResponse"/></returns>
        public Task<DescribeApiAppBindApisStatusResponse> DescribeApiAppBindApisStatus(DescribeApiAppBindApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppBindApisStatusResponse>(req, "DescribeApiAppBindApisStatus");
        }

        /// <summary>
        /// 本接口（DescribeApiAppBindApisStatus）查询应用绑定的Api列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppBindApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppBindApisStatusResponse"/></returns>
        public DescribeApiAppBindApisStatusResponse DescribeApiAppBindApisStatusSync(DescribeApiAppBindApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppBindApisStatusResponse>(req, "DescribeApiAppBindApisStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiAppsStatus）查询应用列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppsStatusResponse"/></returns>
        public Task<DescribeApiAppsStatusResponse> DescribeApiAppsStatus(DescribeApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppsStatusResponse>(req, "DescribeApiAppsStatus");
        }

        /// <summary>
        /// 本接口（DescribeApiAppsStatus）查询应用列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiAppsStatusResponse"/></returns>
        public DescribeApiAppsStatusResponse DescribeApiAppsStatusSync(DescribeApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiAppsStatusResponse>(req, "DescribeApiAppsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiBindApiAppsStatus）查询Api绑定的应用列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiBindApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiBindApiAppsStatusResponse"/></returns>
        public Task<DescribeApiBindApiAppsStatusResponse> DescribeApiBindApiAppsStatus(DescribeApiBindApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiBindApiAppsStatusResponse>(req, "DescribeApiBindApiAppsStatus");
        }

        /// <summary>
        /// 本接口（DescribeApiBindApiAppsStatus）查询Api绑定的应用列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiBindApiAppsStatusRequest"/></param>
        /// <returns><see cref="DescribeApiBindApiAppsStatusResponse"/></returns>
        public DescribeApiBindApiAppsStatusResponse DescribeApiBindApiAppsStatusSync(DescribeApiBindApiAppsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiBindApiAppsStatusResponse>(req, "DescribeApiBindApiAppsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiEnvironmentStrategy）用于展示API绑定的限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public Task<DescribeApiEnvironmentStrategyResponse> DescribeApiEnvironmentStrategy(DescribeApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeApiEnvironmentStrategyResponse>(req, "DescribeApiEnvironmentStrategy");
        }

        /// <summary>
        /// 本接口（DescribeApiEnvironmentStrategy）用于展示API绑定的限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public DescribeApiEnvironmentStrategyResponse DescribeApiEnvironmentStrategySync(DescribeApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeApiEnvironmentStrategyResponse>(req, "DescribeApiEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiForApiApp）用于应用使用者查询部署于 API 网关的 API 接口的详细信息。​
        /// </summary>
        /// <param name="req"><see cref="DescribeApiForApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiForApiAppResponse"/></returns>
        public Task<DescribeApiForApiAppResponse> DescribeApiForApiApp(DescribeApiForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiForApiAppResponse>(req, "DescribeApiForApiApp");
        }

        /// <summary>
        /// 本接口（DescribeApiForApiApp）用于应用使用者查询部署于 API 网关的 API 接口的详细信息。​
        /// </summary>
        /// <param name="req"><see cref="DescribeApiForApiAppRequest"/></param>
        /// <returns><see cref="DescribeApiForApiAppResponse"/></returns>
        public DescribeApiForApiAppResponse DescribeApiForApiAppSync(DescribeApiForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeApiForApiAppResponse>(req, "DescribeApiForApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiKey）用于查询密钥详情。
        /// 用户在创建密钥后，可用此接口查询一个 API 密钥的详情，该接口会显示密钥 Key。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public Task<DescribeApiKeyResponse> DescribeApiKey(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey");
        }

        /// <summary>
        /// 本接口（DescribeApiKey）用于查询密钥详情。
        /// 用户在创建密钥后，可用此接口查询一个 API 密钥的详情，该接口会显示密钥 Key。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public DescribeApiKeyResponse DescribeApiKeySync(DescribeApiKeyRequest req)
        {
            return InternalRequestAsync<DescribeApiKeyResponse>(req, "DescribeApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiKeysStatus）用于查询密钥列表。
        /// 当用户创建了多个密钥对时，可使用本接口查询一个或多个 API 密钥信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public Task<DescribeApiKeysStatusResponse> DescribeApiKeysStatus(DescribeApiKeysStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiKeysStatusResponse>(req, "DescribeApiKeysStatus");
        }

        /// <summary>
        /// 本接口（DescribeApiKeysStatus）用于查询密钥列表。
        /// 当用户创建了多个密钥对时，可使用本接口查询一个或多个 API 密钥信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public DescribeApiKeysStatusResponse DescribeApiKeysStatusSync(DescribeApiKeysStatusRequest req)
        {
            return InternalRequestAsync<DescribeApiKeysStatusResponse>(req, "DescribeApiKeysStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApiUsagePlan）用于查询服务中 API 使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务及其中 API 的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public Task<DescribeApiUsagePlanResponse> DescribeApiUsagePlan(DescribeApiUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeApiUsagePlanResponse>(req, "DescribeApiUsagePlan");
        }

        /// <summary>
        /// 本接口（DescribeApiUsagePlan）用于查询服务中 API 使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务及其中 API 的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public DescribeApiUsagePlanResponse DescribeApiUsagePlanSync(DescribeApiUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeApiUsagePlanResponse>(req, "DescribeApiUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeApisStatus）用于查看一个服务下的某个 API 或所有 API 列表及其相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public Task<DescribeApisStatusResponse> DescribeApisStatus(DescribeApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApisStatusResponse>(req, "DescribeApisStatus");
        }

        /// <summary>
        /// 本接口（DescribeApisStatus）用于查看一个服务下的某个 API 或所有 API 列表及其相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public DescribeApisStatusResponse DescribeApisStatusSync(DescribeApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeApisStatusResponse>(req, "DescribeApisStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeExclusiveInstanceDetail）用于查询独享实例详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstanceDetailResponse"/></returns>
        public Task<DescribeExclusiveInstanceDetailResponse> DescribeExclusiveInstanceDetail(DescribeExclusiveInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstanceDetailResponse>(req, "DescribeExclusiveInstanceDetail");
        }

        /// <summary>
        /// 本接口（DescribeExclusiveInstanceDetail）用于查询独享实例详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstanceDetailResponse"/></returns>
        public DescribeExclusiveInstanceDetailResponse DescribeExclusiveInstanceDetailSync(DescribeExclusiveInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstanceDetailResponse>(req, "DescribeExclusiveInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the list of supported regions for dedicated instances
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstanceRegionsRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstanceRegionsResponse"/></returns>
        public Task<DescribeExclusiveInstanceRegionsResponse> DescribeExclusiveInstanceRegions(DescribeExclusiveInstanceRegionsRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstanceRegionsResponse>(req, "DescribeExclusiveInstanceRegions");
        }

        /// <summary>
        /// Get the list of supported regions for dedicated instances
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstanceRegionsRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstanceRegionsResponse"/></returns>
        public DescribeExclusiveInstanceRegionsResponse DescribeExclusiveInstanceRegionsSync(DescribeExclusiveInstanceRegionsRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstanceRegionsResponse>(req, "DescribeExclusiveInstanceRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeExclusiveInstances）用于查询独享实例列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstancesRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstancesResponse"/></returns>
        public Task<DescribeExclusiveInstancesResponse> DescribeExclusiveInstances(DescribeExclusiveInstancesRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstancesResponse>(req, "DescribeExclusiveInstances");
        }

        /// <summary>
        /// 本接口（DescribeExclusiveInstances）用于查询独享实例列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstancesRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstancesResponse"/></returns>
        public DescribeExclusiveInstancesResponse DescribeExclusiveInstancesSync(DescribeExclusiveInstancesRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstancesResponse>(req, "DescribeExclusiveInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询专享实例列表（新）
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstancesStatusResponse"/></returns>
        public Task<DescribeExclusiveInstancesStatusResponse> DescribeExclusiveInstancesStatus(DescribeExclusiveInstancesStatusRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstancesStatusResponse>(req, "DescribeExclusiveInstancesStatus");
        }

        /// <summary>
        /// 查询专享实例列表（新）
        /// </summary>
        /// <param name="req"><see cref="DescribeExclusiveInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeExclusiveInstancesStatusResponse"/></returns>
        public DescribeExclusiveInstancesStatusResponse DescribeExclusiveInstancesStatusSync(DescribeExclusiveInstancesStatusRequest req)
        {
            return InternalRequestAsync<DescribeExclusiveInstancesStatusResponse>(req, "DescribeExclusiveInstancesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIPStrategy）用于查询IP策略详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public Task<DescribeIPStrategyResponse> DescribeIPStrategy(DescribeIPStrategyRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyResponse>(req, "DescribeIPStrategy");
        }

        /// <summary>
        /// 本接口（DescribeIPStrategy）用于查询IP策略详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public DescribeIPStrategyResponse DescribeIPStrategySync(DescribeIPStrategyRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyResponse>(req, "DescribeIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIPStrategyApisStatus）用于查询IP策略可以绑定的API列表。即服务下所有API和该策略已绑定API的差集。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public Task<DescribeIPStrategyApisStatusResponse> DescribeIPStrategyApisStatus(DescribeIPStrategyApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyApisStatusResponse>(req, "DescribeIPStrategyApisStatus");
        }

        /// <summary>
        /// 本接口（DescribeIPStrategyApisStatus）用于查询IP策略可以绑定的API列表。即服务下所有API和该策略已绑定API的差集。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public DescribeIPStrategyApisStatusResponse DescribeIPStrategyApisStatusSync(DescribeIPStrategyApisStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategyApisStatusResponse>(req, "DescribeIPStrategyApisStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIPStrategysStatus）用于查询服务IP策略列表，因为接口名拼写错误，已不推荐使用，请优先使用DescribeIPStrategiesStatus接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public Task<DescribeIPStrategysStatusResponse> DescribeIPStrategysStatus(DescribeIPStrategysStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategysStatusResponse>(req, "DescribeIPStrategysStatus");
        }

        /// <summary>
        /// 本接口（DescribeIPStrategysStatus）用于查询服务IP策略列表，因为接口名拼写错误，已不推荐使用，请优先使用DescribeIPStrategiesStatus接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public DescribeIPStrategysStatusResponse DescribeIPStrategysStatusSync(DescribeIPStrategysStatusRequest req)
        {
            return InternalRequestAsync<DescribeIPStrategysStatusResponse>(req, "DescribeIPStrategysStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取专享实例网络配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesNetworkConfigRequest"/></param>
        /// <returns><see cref="DescribeInstancesNetworkConfigResponse"/></returns>
        public Task<DescribeInstancesNetworkConfigResponse> DescribeInstancesNetworkConfig(DescribeInstancesNetworkConfigRequest req)
        {
            return InternalRequestAsync<DescribeInstancesNetworkConfigResponse>(req, "DescribeInstancesNetworkConfig");
        }

        /// <summary>
        /// 获取专享实例网络配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesNetworkConfigRequest"/></param>
        /// <returns><see cref="DescribeInstancesNetworkConfigResponse"/></returns>
        public DescribeInstancesNetworkConfigResponse DescribeInstancesNetworkConfigSync(DescribeInstancesNetworkConfigRequest req)
        {
            return InternalRequestAsync<DescribeInstancesNetworkConfigResponse>(req, "DescribeInstancesNetworkConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口DescribeLogSearch用于搜索日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public Task<DescribeLogSearchResponse> DescribeLogSearch(DescribeLogSearchRequest req)
        {
            return InternalRequestAsync<DescribeLogSearchResponse>(req, "DescribeLogSearch");
        }

        /// <summary>
        /// 本接口DescribeLogSearch用于搜索日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public DescribeLogSearchResponse DescribeLogSearchSync(DescribeLogSearchRequest req)
        {
            return InternalRequestAsync<DescribeLogSearchResponse>(req, "DescribeLogSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示插件详情，支持按照插件ID进行。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public Task<DescribePluginResponse> DescribePlugin(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin");
        }

        /// <summary>
        /// 展示插件详情，支持按照插件ID进行。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public DescribePluginResponse DescribePluginSync(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定插件下绑定的API信息
        /// </summary>
        /// <param name="req"><see cref="DescribePluginApisRequest"/></param>
        /// <returns><see cref="DescribePluginApisResponse"/></returns>
        public Task<DescribePluginApisResponse> DescribePluginApis(DescribePluginApisRequest req)
        {
            return InternalRequestAsync<DescribePluginApisResponse>(req, "DescribePluginApis");
        }

        /// <summary>
        /// 查询指定插件下绑定的API信息
        /// </summary>
        /// <param name="req"><see cref="DescribePluginApisRequest"/></param>
        /// <returns><see cref="DescribePluginApisResponse"/></returns>
        public DescribePluginApisResponse DescribePluginApisSync(DescribePluginApisRequest req)
        {
            return InternalRequestAsync<DescribePluginApisResponse>(req, "DescribePluginApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示插件列表和详情，支持分页，支持按照插件类型查询，支持按照插件ID批量查询，支持按照插件名称查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginsRequest"/></param>
        /// <returns><see cref="DescribePluginsResponse"/></returns>
        public Task<DescribePluginsResponse> DescribePlugins(DescribePluginsRequest req)
        {
            return InternalRequestAsync<DescribePluginsResponse>(req, "DescribePlugins");
        }

        /// <summary>
        /// 展示插件列表和详情，支持分页，支持按照插件类型查询，支持按照插件ID批量查询，支持按照插件名称查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginsRequest"/></param>
        /// <returns><see cref="DescribePluginsResponse"/></returns>
        public DescribePluginsResponse DescribePluginsSync(DescribePluginsRequest req)
        {
            return InternalRequestAsync<DescribePluginsResponse>(req, "DescribePlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示API上已绑定的插件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginsByApiRequest"/></param>
        /// <returns><see cref="DescribePluginsByApiResponse"/></returns>
        public Task<DescribePluginsByApiResponse> DescribePluginsByApi(DescribePluginsByApiRequest req)
        {
            return InternalRequestAsync<DescribePluginsByApiResponse>(req, "DescribePluginsByApi");
        }

        /// <summary>
        /// 展示API上已绑定的插件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginsByApiRequest"/></param>
        /// <returns><see cref="DescribePluginsByApiResponse"/></returns>
        public DescribePluginsByApiResponse DescribePluginsByApiSync(DescribePluginsByApiRequest req)
        {
            return InternalRequestAsync<DescribePluginsByApiResponse>(req, "DescribePluginsByApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeService）用于查询一个服务的详细信息、包括服务的描述、域名、协议、创建时间、发布情况等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public Task<DescribeServiceResponse> DescribeService(DescribeServiceRequest req)
        {
            return InternalRequestAsync<DescribeServiceResponse>(req, "DescribeService");
        }

        /// <summary>
        /// 本接口（DescribeService）用于查询一个服务的详细信息、包括服务的描述、域名、协议、创建时间、发布情况等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public DescribeServiceResponse DescribeServiceSync(DescribeServiceRequest req)
        {
            return InternalRequestAsync<DescribeServiceResponse>(req, "DescribeService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentList）用于查询一个服务的环境列表，可查询到此服务下所有环境及其状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public Task<DescribeServiceEnvironmentListResponse> DescribeServiceEnvironmentList(DescribeServiceEnvironmentListRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentListResponse>(req, "DescribeServiceEnvironmentList");
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentList）用于查询一个服务的环境列表，可查询到此服务下所有环境及其状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public DescribeServiceEnvironmentListResponse DescribeServiceEnvironmentListSync(DescribeServiceEnvironmentListRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentListResponse>(req, "DescribeServiceEnvironmentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentReleaseHistory）用于查询服务环境的发布历史。
        /// 用户在创建好服务后需要发布到某个环境中才能进行使用，本接口用于查询一个服务某个环境的发布记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public Task<DescribeServiceEnvironmentReleaseHistoryResponse> DescribeServiceEnvironmentReleaseHistory(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentReleaseHistoryResponse>(req, "DescribeServiceEnvironmentReleaseHistory");
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentReleaseHistory）用于查询服务环境的发布历史。
        /// 用户在创建好服务后需要发布到某个环境中才能进行使用，本接口用于查询一个服务某个环境的发布记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public DescribeServiceEnvironmentReleaseHistoryResponse DescribeServiceEnvironmentReleaseHistorySync(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentReleaseHistoryResponse>(req, "DescribeServiceEnvironmentReleaseHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentStrategy）用于展示服务限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public Task<DescribeServiceEnvironmentStrategyResponse> DescribeServiceEnvironmentStrategy(DescribeServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentStrategyResponse>(req, "DescribeServiceEnvironmentStrategy");
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentStrategy）用于展示服务限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public DescribeServiceEnvironmentStrategyResponse DescribeServiceEnvironmentStrategySync(DescribeServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<DescribeServiceEnvironmentStrategyResponse>(req, "DescribeServiceEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceForApiApp）用于应用使用者查询一个服务的详细信息、包括服务的描述、域名、协议等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceForApiAppRequest"/></param>
        /// <returns><see cref="DescribeServiceForApiAppResponse"/></returns>
        public Task<DescribeServiceForApiAppResponse> DescribeServiceForApiApp(DescribeServiceForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeServiceForApiAppResponse>(req, "DescribeServiceForApiApp");
        }

        /// <summary>
        /// 本接口（DescribeServiceForApiApp）用于应用使用者查询一个服务的详细信息、包括服务的描述、域名、协议等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceForApiAppRequest"/></param>
        /// <returns><see cref="DescribeServiceForApiAppResponse"/></returns>
        public DescribeServiceForApiAppResponse DescribeServiceForApiAppSync(DescribeServiceForApiAppRequest req)
        {
            return InternalRequestAsync<DescribeServiceForApiAppResponse>(req, "DescribeServiceForApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceReleaseVersion）查询一个服务下面所有已经发布的版本列表。
        /// 用户在发布服务时，常有多个版本发布，可使用本接口查询已发布的版本。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public Task<DescribeServiceReleaseVersionResponse> DescribeServiceReleaseVersion(DescribeServiceReleaseVersionRequest req)
        {
            return InternalRequestAsync<DescribeServiceReleaseVersionResponse>(req, "DescribeServiceReleaseVersion");
        }

        /// <summary>
        /// 本接口（DescribeServiceReleaseVersion）查询一个服务下面所有已经发布的版本列表。
        /// 用户在发布服务时，常有多个版本发布，可使用本接口查询已发布的版本。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public DescribeServiceReleaseVersionResponse DescribeServiceReleaseVersionSync(DescribeServiceReleaseVersionRequest req)
        {
            return InternalRequestAsync<DescribeServiceReleaseVersionResponse>(req, "DescribeServiceReleaseVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomainMappings）用于查询自定义域名的路径映射。
        /// API 网关可绑定自定义域名到服务，并且可以对自定义域名的路径进行映射，可自定义不同的路径映射到服务中的三个环境，本接口用于查询绑定服务的自定义域名的路径映射列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public Task<DescribeServiceSubDomainMappingsResponse> DescribeServiceSubDomainMappings(DescribeServiceSubDomainMappingsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainMappingsResponse>(req, "DescribeServiceSubDomainMappings");
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomainMappings）用于查询自定义域名的路径映射。
        /// API 网关可绑定自定义域名到服务，并且可以对自定义域名的路径进行映射，可自定义不同的路径映射到服务中的三个环境，本接口用于查询绑定服务的自定义域名的路径映射列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public DescribeServiceSubDomainMappingsResponse DescribeServiceSubDomainMappingsSync(DescribeServiceSubDomainMappingsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainMappingsResponse>(req, "DescribeServiceSubDomainMappings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomains）用于查询自定义域名列表。
        /// API 网关可绑定自定义域名到服务，用于服务调用。此接口用于查询用户绑定在服务的自定义域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public Task<DescribeServiceSubDomainsResponse> DescribeServiceSubDomains(DescribeServiceSubDomainsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainsResponse>(req, "DescribeServiceSubDomains");
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomains）用于查询自定义域名列表。
        /// API 网关可绑定自定义域名到服务，用于服务调用。此接口用于查询用户绑定在服务的自定义域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public DescribeServiceSubDomainsResponse DescribeServiceSubDomainsSync(DescribeServiceSubDomainsRequest req)
        {
            return InternalRequestAsync<DescribeServiceSubDomainsResponse>(req, "DescribeServiceSubDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServiceUsagePlan）用于查询服务使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public Task<DescribeServiceUsagePlanResponse> DescribeServiceUsagePlan(DescribeServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeServiceUsagePlanResponse>(req, "DescribeServiceUsagePlan");
        }

        /// <summary>
        /// 本接口（DescribeServiceUsagePlan）用于查询服务使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public DescribeServiceUsagePlanResponse DescribeServiceUsagePlanSync(DescribeServiceUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeServiceUsagePlanResponse>(req, "DescribeServiceUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeServicesStatus）用于搜索查询某一个服务或多个服务的列表，并返回服务相关的域名、时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public Task<DescribeServicesStatusResponse> DescribeServicesStatus(DescribeServicesStatusRequest req)
        {
            return InternalRequestAsync<DescribeServicesStatusResponse>(req, "DescribeServicesStatus");
        }

        /// <summary>
        /// 本接口（DescribeServicesStatus）用于搜索查询某一个服务或多个服务的列表，并返回服务相关的域名、时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public DescribeServicesStatusResponse DescribeServicesStatusSync(DescribeServicesStatusRequest req)
        {
            return InternalRequestAsync<DescribeServicesStatusResponse>(req, "DescribeServicesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询后端通道所绑定的API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamBindApisRequest"/></param>
        /// <returns><see cref="DescribeUpstreamBindApisResponse"/></returns>
        public Task<DescribeUpstreamBindApisResponse> DescribeUpstreamBindApis(DescribeUpstreamBindApisRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamBindApisResponse>(req, "DescribeUpstreamBindApis");
        }

        /// <summary>
        /// 查询后端通道所绑定的API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamBindApisRequest"/></param>
        /// <returns><see cref="DescribeUpstreamBindApisResponse"/></returns>
        public DescribeUpstreamBindApisResponse DescribeUpstreamBindApisSync(DescribeUpstreamBindApisRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamBindApisResponse>(req, "DescribeUpstreamBindApis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询后端通道列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamsRequest"/></param>
        /// <returns><see cref="DescribeUpstreamsResponse"/></returns>
        public Task<DescribeUpstreamsResponse> DescribeUpstreams(DescribeUpstreamsRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamsResponse>(req, "DescribeUpstreams");
        }

        /// <summary>
        /// 查询后端通道列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUpstreamsRequest"/></param>
        /// <returns><see cref="DescribeUpstreamsResponse"/></returns>
        public DescribeUpstreamsResponse DescribeUpstreamsSync(DescribeUpstreamsRequest req)
        {
            return InternalRequestAsync<DescribeUpstreamsResponse>(req, "DescribeUpstreams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUsagePlan）用于查询一个使用计划的详细信息，包括名称、QPS、创建时间绑定的环境等。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public Task<DescribeUsagePlanResponse> DescribeUsagePlan(DescribeUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanResponse>(req, "DescribeUsagePlan");
        }

        /// <summary>
        /// 本接口（DescribeUsagePlan）用于查询一个使用计划的详细信息，包括名称、QPS、创建时间绑定的环境等。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public DescribeUsagePlanResponse DescribeUsagePlanSync(DescribeUsagePlanRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanResponse>(req, "DescribeUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanEnvironments）用于查询使用计划绑定的环境列表。
        /// 用户在绑定了某个使用计划到环境后，可使用本接口查询这个使用计划绑定的所有服务的环境。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public Task<DescribeUsagePlanEnvironmentsResponse> DescribeUsagePlanEnvironments(DescribeUsagePlanEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanEnvironmentsResponse>(req, "DescribeUsagePlanEnvironments");
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanEnvironments）用于查询使用计划绑定的环境列表。
        /// 用户在绑定了某个使用计划到环境后，可使用本接口查询这个使用计划绑定的所有服务的环境。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public DescribeUsagePlanEnvironmentsResponse DescribeUsagePlanEnvironmentsSync(DescribeUsagePlanEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanEnvironmentsResponse>(req, "DescribeUsagePlanEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanSecretIds）用于查询使用计划绑定的密钥列表。
        /// 在 API 网关中，一个使用计划可绑定多个密钥对，可使用本接口查询使用计划绑定的密钥列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public Task<DescribeUsagePlanSecretIdsResponse> DescribeUsagePlanSecretIds(DescribeUsagePlanSecretIdsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanSecretIdsResponse>(req, "DescribeUsagePlanSecretIds");
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanSecretIds）用于查询使用计划绑定的密钥列表。
        /// 在 API 网关中，一个使用计划可绑定多个密钥对，可使用本接口查询使用计划绑定的密钥列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public DescribeUsagePlanSecretIdsResponse DescribeUsagePlanSecretIdsSync(DescribeUsagePlanSecretIdsRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlanSecretIdsResponse>(req, "DescribeUsagePlanSecretIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanStatus）用于查询使用计划的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public Task<DescribeUsagePlansStatusResponse> DescribeUsagePlansStatus(DescribeUsagePlansStatusRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlansStatusResponse>(req, "DescribeUsagePlansStatus");
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanStatus）用于查询使用计划的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public DescribeUsagePlansStatusResponse DescribeUsagePlansStatusSync(DescribeUsagePlansStatusRequest req)
        {
            return InternalRequestAsync<DescribeUsagePlansStatusResponse>(req, "DescribeUsagePlansStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除插件与API绑定
        /// </summary>
        /// <param name="req"><see cref="DetachPluginRequest"/></param>
        /// <returns><see cref="DetachPluginResponse"/></returns>
        public Task<DetachPluginResponse> DetachPlugin(DetachPluginRequest req)
        {
            return InternalRequestAsync<DetachPluginResponse>(req, "DetachPlugin");
        }

        /// <summary>
        /// 解除插件与API绑定
        /// </summary>
        /// <param name="req"><see cref="DetachPluginRequest"/></param>
        /// <returns><see cref="DetachPluginResponse"/></returns>
        public DetachPluginResponse DetachPluginSync(DetachPluginRequest req)
        {
            return InternalRequestAsync<DetachPluginResponse>(req, "DetachPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableApiKey）用于禁用一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public Task<DisableApiKeyResponse> DisableApiKey(DisableApiKeyRequest req)
        {
            return InternalRequestAsync<DisableApiKeyResponse>(req, "DisableApiKey");
        }

        /// <summary>
        /// 本接口（DisableApiKey）用于禁用一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public DisableApiKeyResponse DisableApiKeySync(DisableApiKeyRequest req)
        {
            return InternalRequestAsync<DisableApiKeyResponse>(req, "DisableApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableApiKey）用于启动一对被禁用的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public Task<EnableApiKeyResponse> EnableApiKey(EnableApiKeyRequest req)
        {
            return InternalRequestAsync<EnableApiKeyResponse>(req, "EnableApiKey");
        }

        /// <summary>
        /// 本接口（EnableApiKey）用于启动一对被禁用的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public EnableApiKeyResponse EnableApiKeySync(EnableApiKeyRequest req)
        {
            return InternalRequestAsync<EnableApiKeyResponse>(req, "EnableApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ImportOpenApi）用于将OpenAPI规范定义的API导入到API网关。 
        /// </summary>
        /// <param name="req"><see cref="ImportOpenApiRequest"/></param>
        /// <returns><see cref="ImportOpenApiResponse"/></returns>
        public Task<ImportOpenApiResponse> ImportOpenApi(ImportOpenApiRequest req)
        {
            return InternalRequestAsync<ImportOpenApiResponse>(req, "ImportOpenApi");
        }

        /// <summary>
        /// 本接口（ImportOpenApi）用于将OpenAPI规范定义的API导入到API网关。 
        /// </summary>
        /// <param name="req"><see cref="ImportOpenApiRequest"/></param>
        /// <returns><see cref="ImportOpenApiResponse"/></returns>
        public ImportOpenApiResponse ImportOpenApiSync(ImportOpenApiRequest req)
        {
            return InternalRequestAsync<ImportOpenApiResponse>(req, "ImportOpenApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 API 文档
        /// </summary>
        /// <param name="req"><see cref="ModifyAPIDocRequest"/></param>
        /// <returns><see cref="ModifyAPIDocResponse"/></returns>
        public Task<ModifyAPIDocResponse> ModifyAPIDoc(ModifyAPIDocRequest req)
        {
            return InternalRequestAsync<ModifyAPIDocResponse>(req, "ModifyAPIDoc");
        }

        /// <summary>
        /// 修改 API 文档
        /// </summary>
        /// <param name="req"><see cref="ModifyAPIDocRequest"/></param>
        /// <returns><see cref="ModifyAPIDocResponse"/></returns>
        public ModifyAPIDocResponse ModifyAPIDocSync(ModifyAPIDocRequest req)
        {
            return InternalRequestAsync<ModifyAPIDocResponse>(req, "ModifyAPIDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyApi）用于修改 API 接口，可调用此接口对已经配置的 API 接口进行编辑修改。修改后的 API 需要重新发布 API 所在的服务到对应环境方能生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public Task<ModifyApiResponse> ModifyApi(ModifyApiRequest req)
        {
            return InternalRequestAsync<ModifyApiResponse>(req, "ModifyApi");
        }

        /// <summary>
        /// 本接口（ModifyApi）用于修改 API 接口，可调用此接口对已经配置的 API 接口进行编辑修改。修改后的 API 需要重新发布 API 所在的服务到对应环境方能生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public ModifyApiResponse ModifyApiSync(ModifyApiRequest req)
        {
            return InternalRequestAsync<ModifyApiResponse>(req, "ModifyApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyApiApp）用于修改已经创建的应用。
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAppRequest"/></param>
        /// <returns><see cref="ModifyApiAppResponse"/></returns>
        public Task<ModifyApiAppResponse> ModifyApiApp(ModifyApiAppRequest req)
        {
            return InternalRequestAsync<ModifyApiAppResponse>(req, "ModifyApiApp");
        }

        /// <summary>
        /// 本接口（ModifyApiApp）用于修改已经创建的应用。
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAppRequest"/></param>
        /// <returns><see cref="ModifyApiAppResponse"/></returns>
        public ModifyApiAppResponse ModifyApiAppSync(ModifyApiAppRequest req)
        {
            return InternalRequestAsync<ModifyApiAppResponse>(req, "ModifyApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyApiEnvironmentStrategy）用于修改API限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public Task<ModifyApiEnvironmentStrategyResponse> ModifyApiEnvironmentStrategy(ModifyApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyApiEnvironmentStrategyResponse>(req, "ModifyApiEnvironmentStrategy");
        }

        /// <summary>
        /// 本接口（ModifyApiEnvironmentStrategy）用于修改API限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public ModifyApiEnvironmentStrategyResponse ModifyApiEnvironmentStrategySync(ModifyApiEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyApiEnvironmentStrategyResponse>(req, "ModifyApiEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供增量更新API能力，主要是给程序调用（区别于ModifyApi，该接口是需要传入API的全量参数，对console使用较友好）
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public Task<ModifyApiIncrementResponse> ModifyApiIncrement(ModifyApiIncrementRequest req)
        {
            return InternalRequestAsync<ModifyApiIncrementResponse>(req, "ModifyApiIncrement");
        }

        /// <summary>
        /// 提供增量更新API能力，主要是给程序调用（区别于ModifyApi，该接口是需要传入API的全量参数，对console使用较友好）
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public ModifyApiIncrementResponse ModifyApiIncrementSync(ModifyApiIncrementRequest req)
        {
            return InternalRequestAsync<ModifyApiIncrementResponse>(req, "ModifyApiIncrement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyExclusiveInstance）用于修改独享实例信息。​
        /// </summary>
        /// <param name="req"><see cref="ModifyExclusiveInstanceRequest"/></param>
        /// <returns><see cref="ModifyExclusiveInstanceResponse"/></returns>
        public Task<ModifyExclusiveInstanceResponse> ModifyExclusiveInstance(ModifyExclusiveInstanceRequest req)
        {
            return InternalRequestAsync<ModifyExclusiveInstanceResponse>(req, "ModifyExclusiveInstance");
        }

        /// <summary>
        /// 本接口（ModifyExclusiveInstance）用于修改独享实例信息。​
        /// </summary>
        /// <param name="req"><see cref="ModifyExclusiveInstanceRequest"/></param>
        /// <returns><see cref="ModifyExclusiveInstanceResponse"/></returns>
        public ModifyExclusiveInstanceResponse ModifyExclusiveInstanceSync(ModifyExclusiveInstanceRequest req)
        {
            return InternalRequestAsync<ModifyExclusiveInstanceResponse>(req, "ModifyExclusiveInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyIPStrategy）用于修改服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public Task<ModifyIPStrategyResponse> ModifyIPStrategy(ModifyIPStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIPStrategyResponse>(req, "ModifyIPStrategy");
        }

        /// <summary>
        /// 本接口（ModifyIPStrategy）用于修改服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public ModifyIPStrategyResponse ModifyIPStrategySync(ModifyIPStrategyRequest req)
        {
            return InternalRequestAsync<ModifyIPStrategyResponse>(req, "ModifyIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改API网关插件。
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public Task<ModifyPluginResponse> ModifyPlugin(ModifyPluginRequest req)
        {
            return InternalRequestAsync<ModifyPluginResponse>(req, "ModifyPlugin");
        }

        /// <summary>
        /// 修改API网关插件。
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public ModifyPluginResponse ModifyPluginSync(ModifyPluginRequest req)
        {
            return InternalRequestAsync<ModifyPluginResponse>(req, "ModifyPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyService）用于修改服务的相关信息。当服务创建后，服务的名称、描述和服务类型均可被修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public Task<ModifyServiceResponse> ModifyService(ModifyServiceRequest req)
        {
            return InternalRequestAsync<ModifyServiceResponse>(req, "ModifyService");
        }

        /// <summary>
        /// 本接口（ModifyService）用于修改服务的相关信息。当服务创建后，服务的名称、描述和服务类型均可被修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public ModifyServiceResponse ModifyServiceSync(ModifyServiceRequest req)
        {
            return InternalRequestAsync<ModifyServiceResponse>(req, "ModifyService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyServiceEnvironmentStrategy）用于修改服务限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public Task<ModifyServiceEnvironmentStrategyResponse> ModifyServiceEnvironmentStrategy(ModifyServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyServiceEnvironmentStrategyResponse>(req, "ModifyServiceEnvironmentStrategy");
        }

        /// <summary>
        /// 本接口（ModifyServiceEnvironmentStrategy）用于修改服务限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public ModifyServiceEnvironmentStrategyResponse ModifyServiceEnvironmentStrategySync(ModifyServiceEnvironmentStrategyRequest req)
        {
            return InternalRequestAsync<ModifyServiceEnvironmentStrategyResponse>(req, "ModifyServiceEnvironmentStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySubDomain）用于修改服务的自定义域名设置中的路径映射，可以修改绑定自定义域名之前的路径映射规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public Task<ModifySubDomainResponse> ModifySubDomain(ModifySubDomainRequest req)
        {
            return InternalRequestAsync<ModifySubDomainResponse>(req, "ModifySubDomain");
        }

        /// <summary>
        /// 本接口（ModifySubDomain）用于修改服务的自定义域名设置中的路径映射，可以修改绑定自定义域名之前的路径映射规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public ModifySubDomainResponse ModifySubDomainSync(ModifySubDomainRequest req)
        {
            return InternalRequestAsync<ModifySubDomainResponse>(req, "ModifySubDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改后端通道
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamRequest"/></param>
        /// <returns><see cref="ModifyUpstreamResponse"/></returns>
        public Task<ModifyUpstreamResponse> ModifyUpstream(ModifyUpstreamRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamResponse>(req, "ModifyUpstream");
        }

        /// <summary>
        /// 修改后端通道
        /// </summary>
        /// <param name="req"><see cref="ModifyUpstreamRequest"/></param>
        /// <returns><see cref="ModifyUpstreamResponse"/></returns>
        public ModifyUpstreamResponse ModifyUpstreamSync(ModifyUpstreamRequest req)
        {
            return InternalRequestAsync<ModifyUpstreamResponse>(req, "ModifyUpstream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyUsagePlan）用于修改使用计划的名称，描述及 QPS。
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public Task<ModifyUsagePlanResponse> ModifyUsagePlan(ModifyUsagePlanRequest req)
        {
            return InternalRequestAsync<ModifyUsagePlanResponse>(req, "ModifyUsagePlan");
        }

        /// <summary>
        /// 本接口（ModifyUsagePlan）用于修改使用计划的名称，描述及 QPS。
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public ModifyUsagePlanResponse ModifyUsagePlanSync(ModifyUsagePlanRequest req)
        {
            return InternalRequestAsync<ModifyUsagePlanResponse>(req, "ModifyUsagePlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReleaseService）用于发布服务。
        /// API 网关的服务创建后，需要发布到某个环境方生效后，使用者才能进行调用，此接口用于发布服务到环境，如 release 环境。
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public Task<ReleaseServiceResponse> ReleaseService(ReleaseServiceRequest req)
        {
            return InternalRequestAsync<ReleaseServiceResponse>(req, "ReleaseService");
        }

        /// <summary>
        /// 本接口（ReleaseService）用于发布服务。
        /// API 网关的服务创建后，需要发布到某个环境方生效后，使用者才能进行调用，此接口用于发布服务到环境，如 release 环境。
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public ReleaseServiceResponse ReleaseServiceSync(ReleaseServiceRequest req)
        {
            return InternalRequestAsync<ReleaseServiceResponse>(req, "ReleaseService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置API文档密码
        /// </summary>
        /// <param name="req"><see cref="ResetAPIDocPasswordRequest"/></param>
        /// <returns><see cref="ResetAPIDocPasswordResponse"/></returns>
        public Task<ResetAPIDocPasswordResponse> ResetAPIDocPassword(ResetAPIDocPasswordRequest req)
        {
            return InternalRequestAsync<ResetAPIDocPasswordResponse>(req, "ResetAPIDocPassword");
        }

        /// <summary>
        /// 重置API文档密码
        /// </summary>
        /// <param name="req"><see cref="ResetAPIDocPasswordRequest"/></param>
        /// <returns><see cref="ResetAPIDocPasswordResponse"/></returns>
        public ResetAPIDocPasswordResponse ResetAPIDocPasswordSync(ResetAPIDocPasswordRequest req)
        {
            return InternalRequestAsync<ResetAPIDocPasswordResponse>(req, "ResetAPIDocPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnBindEnvironment）用于将使用计划从特定环境解绑。
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public Task<UnBindEnvironmentResponse> UnBindEnvironment(UnBindEnvironmentRequest req)
        {
            return InternalRequestAsync<UnBindEnvironmentResponse>(req, "UnBindEnvironment");
        }

        /// <summary>
        /// 本接口（UnBindEnvironment）用于将使用计划从特定环境解绑。
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public UnBindEnvironmentResponse UnBindEnvironmentSync(UnBindEnvironmentRequest req)
        {
            return InternalRequestAsync<UnBindEnvironmentResponse>(req, "UnBindEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnBindIPStrategy）用于服务解绑IP策略。
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public Task<UnBindIPStrategyResponse> UnBindIPStrategy(UnBindIPStrategyRequest req)
        {
            return InternalRequestAsync<UnBindIPStrategyResponse>(req, "UnBindIPStrategy");
        }

        /// <summary>
        /// 本接口（UnBindIPStrategy）用于服务解绑IP策略。
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public UnBindIPStrategyResponse UnBindIPStrategySync(UnBindIPStrategyRequest req)
        {
            return InternalRequestAsync<UnBindIPStrategyResponse>(req, "UnBindIPStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnBindSecretIds）用于为使用计划解绑密钥。
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public Task<UnBindSecretIdsResponse> UnBindSecretIds(UnBindSecretIdsRequest req)
        {
            return InternalRequestAsync<UnBindSecretIdsResponse>(req, "UnBindSecretIds");
        }

        /// <summary>
        /// 本接口（UnBindSecretIds）用于为使用计划解绑密钥。
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public UnBindSecretIdsResponse UnBindSecretIdsSync(UnBindSecretIdsRequest req)
        {
            return InternalRequestAsync<UnBindSecretIdsResponse>(req, "UnBindSecretIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnBindSubDomain）用于解绑自定义域名。
        /// 用户使用 API 网关绑定了自定义域名到服务中后，若想要解绑此自定义域名，可使用此接口。
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public Task<UnBindSubDomainResponse> UnBindSubDomain(UnBindSubDomainRequest req)
        {
            return InternalRequestAsync<UnBindSubDomainResponse>(req, "UnBindSubDomain");
        }

        /// <summary>
        /// 本接口（UnBindSubDomain）用于解绑自定义域名。
        /// 用户使用 API 网关绑定了自定义域名到服务中后，若想要解绑此自定义域名，可使用此接口。
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public UnBindSubDomainResponse UnBindSubDomainSync(UnBindSubDomainRequest req)
        {
            return InternalRequestAsync<UnBindSubDomainResponse>(req, "UnBindSubDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnReleaseService）用于下线服务。
        /// 用户发布服务到某个环境后，此服务中的 API 方可被调用者进行调用，当用户需要将此服务从发布环境中下线时，可调用此 API。下线后的服务不可被调用。
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public Task<UnReleaseServiceResponse> UnReleaseService(UnReleaseServiceRequest req)
        {
            return InternalRequestAsync<UnReleaseServiceResponse>(req, "UnReleaseService");
        }

        /// <summary>
        /// 本接口（UnReleaseService）用于下线服务。
        /// 用户发布服务到某个环境后，此服务中的 API 方可被调用者进行调用，当用户需要将此服务从发布环境中下线时，可调用此 API。下线后的服务不可被调用。
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public UnReleaseServiceResponse UnReleaseServiceSync(UnReleaseServiceRequest req)
        {
            return InternalRequestAsync<UnReleaseServiceResponse>(req, "UnReleaseService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnbindApiApp）用于解除应用和API绑定。
        /// </summary>
        /// <param name="req"><see cref="UnbindApiAppRequest"/></param>
        /// <returns><see cref="UnbindApiAppResponse"/></returns>
        public Task<UnbindApiAppResponse> UnbindApiApp(UnbindApiAppRequest req)
        {
            return InternalRequestAsync<UnbindApiAppResponse>(req, "UnbindApiApp");
        }

        /// <summary>
        /// 本接口（UnbindApiApp）用于解除应用和API绑定。
        /// </summary>
        /// <param name="req"><see cref="UnbindApiAppRequest"/></param>
        /// <returns><see cref="UnbindApiAppResponse"/></returns>
        public UnbindApiAppResponse UnbindApiAppSync(UnbindApiAppRequest req)
        {
            return InternalRequestAsync<UnbindApiAppResponse>(req, "UnbindApiApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateApiAppKey）用于更新应用密钥。
        /// </summary>
        /// <param name="req"><see cref="UpdateApiAppKeyRequest"/></param>
        /// <returns><see cref="UpdateApiAppKeyResponse"/></returns>
        public Task<UpdateApiAppKeyResponse> UpdateApiAppKey(UpdateApiAppKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiAppKeyResponse>(req, "UpdateApiAppKey");
        }

        /// <summary>
        /// 本接口（UpdateApiAppKey）用于更新应用密钥。
        /// </summary>
        /// <param name="req"><see cref="UpdateApiAppKeyRequest"/></param>
        /// <returns><see cref="UpdateApiAppKeyResponse"/></returns>
        public UpdateApiAppKeyResponse UpdateApiAppKeySync(UpdateApiAppKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiAppKeyResponse>(req, "UpdateApiAppKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateApiKey）用于更换用户已创建的一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public Task<UpdateApiKeyResponse> UpdateApiKey(UpdateApiKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiKeyResponse>(req, "UpdateApiKey");
        }

        /// <summary>
        /// 本接口（UpdateApiKey）用于更换用户已创建的一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public UpdateApiKeyResponse UpdateApiKeySync(UpdateApiKeyRequest req)
        {
            return InternalRequestAsync<UpdateApiKeyResponse>(req, "UpdateApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateService）用于从服务已发布的环境中将运行版本切换到特定版本。用户在使用 API 网关创建服务并发布服务到某个环境后，如在开发过程产生多个版本需要切换，此时可调用本接口。
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public Task<UpdateServiceResponse> UpdateService(UpdateServiceRequest req)
        {
            return InternalRequestAsync<UpdateServiceResponse>(req, "UpdateService");
        }

        /// <summary>
        /// 本接口（UpdateService）用于从服务已发布的环境中将运行版本切换到特定版本。用户在使用 API 网关创建服务并发布服务到某个环境后，如在开发过程产生多个版本需要切换，此时可调用本接口。
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public UpdateServiceResponse UpdateServiceSync(UpdateServiceRequest req)
        {
            return InternalRequestAsync<UpdateServiceResponse>(req, "UpdateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
