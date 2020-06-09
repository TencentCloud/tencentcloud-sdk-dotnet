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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApigatewayClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 本接口（BindEnvironment）用于绑定使用计划到服务环境。
        /// 用户在发布服务到某个环境中后，如此 API 需要鉴权，还需要绑定使用计划才能进行调用，此接口用户将使用计划绑定到特定环境。
        /// 目前支持绑定使用计划到API，但是同一个服务不能同时存在绑定到服务的使用计划和绑定到API的使用计划，所以对已经绑定过服务级别使用计划的环境，请先使用 服务级别使用计划降级 接口进行降级操作。
        /// </summary>
        /// <param name="req"><see cref="BindEnvironmentRequest"/></param>
        /// <returns><see cref="BindEnvironmentResponse"/></returns>
        public async Task<BindEnvironmentResponse> BindEnvironment(BindEnvironmentRequest req)
        {
             JsonResponseModel<BindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindEnvironment）用于绑定使用计划到服务环境。
        /// 用户在发布服务到某个环境中后，如此 API 需要鉴权，还需要绑定使用计划才能进行调用，此接口用户将使用计划绑定到特定环境。
        /// 目前支持绑定使用计划到API，但是同一个服务不能同时存在绑定到服务的使用计划和绑定到API的使用计划，所以对已经绑定过服务级别使用计划的环境，请先使用 服务级别使用计划降级 接口进行降级操作。
        /// </summary>
        /// <param name="req"><see cref="BindEnvironmentRequest"/></param>
        /// <returns><see cref="BindEnvironmentResponse"/></returns>
        public BindEnvironmentResponse BindEnvironmentSync(BindEnvironmentRequest req)
        {
             JsonResponseModel<BindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindIPStrategy）用于API绑定IP策略。
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public async Task<BindIPStrategyResponse> BindIPStrategy(BindIPStrategyRequest req)
        {
             JsonResponseModel<BindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindIPStrategy）用于API绑定IP策略。
        /// </summary>
        /// <param name="req"><see cref="BindIPStrategyRequest"/></param>
        /// <returns><see cref="BindIPStrategyResponse"/></returns>
        public BindIPStrategyResponse BindIPStrategySync(BindIPStrategyRequest req)
        {
             JsonResponseModel<BindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindSecretIds）用于为使用计划绑定密钥。
        /// 将密钥绑定到某个使用计划，并将此使用计划绑定到某个服务发布的环境上，调用者方可使用此密钥调用这个服务中的 API，可使用本接口为使用计划绑定密钥。
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public async Task<BindSecretIdsResponse> BindSecretIds(BindSecretIdsRequest req)
        {
             JsonResponseModel<BindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindSecretIds）用于为使用计划绑定密钥。
        /// 将密钥绑定到某个使用计划，并将此使用计划绑定到某个服务发布的环境上，调用者方可使用此密钥调用这个服务中的 API，可使用本接口为使用计划绑定密钥。
        /// </summary>
        /// <param name="req"><see cref="BindSecretIdsRequest"/></param>
        /// <returns><see cref="BindSecretIdsResponse"/></returns>
        public BindSecretIdsResponse BindSecretIdsSync(BindSecretIdsRequest req)
        {
             JsonResponseModel<BindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindSubDomain）用于绑定自定义域名到服务。
        /// API 网关中每个服务都会提供一个默认的域名供用户调用，但当用户想使用自己的已有域名时，也可以将自定义域名绑定到此服务，在做好备案、与默认域名的 CNAME 后，可直接调用自定义域名。
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public async Task<BindSubDomainResponse> BindSubDomain(BindSubDomainRequest req)
        {
             JsonResponseModel<BindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindSubDomain）用于绑定自定义域名到服务。
        /// API 网关中每个服务都会提供一个默认的域名供用户调用，但当用户想使用自己的已有域名时，也可以将自定义域名绑定到此服务，在做好备案、与默认域名的 CNAME 后，可直接调用自定义域名。
        /// </summary>
        /// <param name="req"><see cref="BindSubDomainRequest"/></param>
        /// <returns><see cref="BindSubDomainResponse"/></returns>
        public BindSubDomainResponse BindSubDomainSync(BindSubDomainRequest req)
        {
             JsonResponseModel<BindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateApi）用于创建 API 接口，创建 API 前，用户需要先创建服务，每个 API 都有自己归属的服务。
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public async Task<CreateApiResponse> CreateApi(CreateApiRequest req)
        {
             JsonResponseModel<CreateApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateApi）用于创建 API 接口，创建 API 前，用户需要先创建服务，每个 API 都有自己归属的服务。
        /// </summary>
        /// <param name="req"><see cref="CreateApiRequest"/></param>
        /// <returns><see cref="CreateApiResponse"/></returns>
        public CreateApiResponse CreateApiSync(CreateApiRequest req)
        {
             JsonResponseModel<CreateApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateApiKey）用于创建一对新的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public async Task<CreateApiKeyResponse> CreateApiKey(CreateApiKeyRequest req)
        {
             JsonResponseModel<CreateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateApiKey）用于创建一对新的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="CreateApiKeyRequest"/></param>
        /// <returns><see cref="CreateApiKeyResponse"/></returns>
        public CreateApiKeyResponse CreateApiKeySync(CreateApiKeyRequest req)
        {
             JsonResponseModel<CreateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateIPStrategy）用于创建服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public async Task<CreateIPStrategyResponse> CreateIPStrategy(CreateIPStrategyRequest req)
        {
             JsonResponseModel<CreateIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateIPStrategy）用于创建服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="CreateIPStrategyRequest"/></param>
        /// <returns><see cref="CreateIPStrategyResponse"/></returns>
        public CreateIPStrategyResponse CreateIPStrategySync(CreateIPStrategyRequest req)
        {
             JsonResponseModel<CreateIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateService）用于创建服务。
        /// API 网关使用的最大单元为服务，每个服务中可创建多个 API 接口。每个服务有一个默认域名供客户调用，用户也可绑定自定义域名到此服务中。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public async Task<CreateServiceResponse> CreateService(CreateServiceRequest req)
        {
             JsonResponseModel<CreateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateService）用于创建服务。
        /// API 网关使用的最大单元为服务，每个服务中可创建多个 API 接口。每个服务有一个默认域名供客户调用，用户也可绑定自定义域名到此服务中。
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public CreateServiceResponse CreateServiceSync(CreateServiceRequest req)
        {
             JsonResponseModel<CreateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateUsagePlan）用于创建使用计划。
        /// 用户在使用 API 网关时，需要创建使用计划并将其绑定到服务的环境中使用。
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public async Task<CreateUsagePlanResponse> CreateUsagePlan(CreateUsagePlanRequest req)
        {
             JsonResponseModel<CreateUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateUsagePlan）用于创建使用计划。
        /// 用户在使用 API 网关时，需要创建使用计划并将其绑定到服务的环境中使用。
        /// </summary>
        /// <param name="req"><see cref="CreateUsagePlanRequest"/></param>
        /// <returns><see cref="CreateUsagePlanResponse"/></returns>
        public CreateUsagePlanResponse CreateUsagePlanSync(CreateUsagePlanRequest req)
        {
             JsonResponseModel<CreateUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteApi）用于删除已经创建的API。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public async Task<DeleteApiResponse> DeleteApi(DeleteApiRequest req)
        {
             JsonResponseModel<DeleteApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteApi）用于删除已经创建的API。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiRequest"/></param>
        /// <returns><see cref="DeleteApiResponse"/></returns>
        public DeleteApiResponse DeleteApiSync(DeleteApiRequest req)
        {
             JsonResponseModel<DeleteApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteApiKey）用于删除一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public async Task<DeleteApiKeyResponse> DeleteApiKey(DeleteApiKeyRequest req)
        {
             JsonResponseModel<DeleteApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteApiKey）用于删除一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DeleteApiKeyRequest"/></param>
        /// <returns><see cref="DeleteApiKeyResponse"/></returns>
        public DeleteApiKeyResponse DeleteApiKeySync(DeleteApiKeyRequest req)
        {
             JsonResponseModel<DeleteApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteIPStrategy）用于删除服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public async Task<DeleteIPStrategyResponse> DeleteIPStrategy(DeleteIPStrategyRequest req)
        {
             JsonResponseModel<DeleteIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteIPStrategy）用于删除服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteIPStrategyRequest"/></param>
        /// <returns><see cref="DeleteIPStrategyResponse"/></returns>
        public DeleteIPStrategyResponse DeleteIPStrategySync(DeleteIPStrategyRequest req)
        {
             JsonResponseModel<DeleteIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteService）用于删除 API 网关中某个服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public async Task<DeleteServiceResponse> DeleteService(DeleteServiceRequest req)
        {
             JsonResponseModel<DeleteServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteService）用于删除 API 网关中某个服务。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public DeleteServiceResponse DeleteServiceSync(DeleteServiceRequest req)
        {
             JsonResponseModel<DeleteServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteServiceSubDomainMapping）用于删除服务中某个环境的自定义域名映射。
        /// 当用户使用自定义域名，并使用了自定义映射时，可使用此接口。但需注意，若删除了所有环境的映射时，调用此 API 均会返回失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public async Task<DeleteServiceSubDomainMappingResponse> DeleteServiceSubDomainMapping(DeleteServiceSubDomainMappingRequest req)
        {
             JsonResponseModel<DeleteServiceSubDomainMappingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceSubDomainMapping");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceSubDomainMappingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteServiceSubDomainMapping）用于删除服务中某个环境的自定义域名映射。
        /// 当用户使用自定义域名，并使用了自定义映射时，可使用此接口。但需注意，若删除了所有环境的映射时，调用此 API 均会返回失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceSubDomainMappingRequest"/></param>
        /// <returns><see cref="DeleteServiceSubDomainMappingResponse"/></returns>
        public DeleteServiceSubDomainMappingResponse DeleteServiceSubDomainMappingSync(DeleteServiceSubDomainMappingRequest req)
        {
             JsonResponseModel<DeleteServiceSubDomainMappingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceSubDomainMapping");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceSubDomainMappingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteUsagePlan）用于删除使用计划。
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public async Task<DeleteUsagePlanResponse> DeleteUsagePlan(DeleteUsagePlanRequest req)
        {
             JsonResponseModel<DeleteUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteUsagePlan）用于删除使用计划。
        /// </summary>
        /// <param name="req"><see cref="DeleteUsagePlanRequest"/></param>
        /// <returns><see cref="DeleteUsagePlanResponse"/></returns>
        public DeleteUsagePlanResponse DeleteUsagePlanSync(DeleteUsagePlanRequest req)
        {
             JsonResponseModel<DeleteUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DemoteServiceUsagePlan）用于将某个服务在某个环境的使用计划，降级到API上。
        /// 如果服务内没有API不允许进行此操作。
        /// 如果当前环境没有发布，不允许进行此操作。
        /// </summary>
        /// <param name="req"><see cref="DemoteServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DemoteServiceUsagePlanResponse"/></returns>
        public async Task<DemoteServiceUsagePlanResponse> DemoteServiceUsagePlan(DemoteServiceUsagePlanRequest req)
        {
             JsonResponseModel<DemoteServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DemoteServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DemoteServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DemoteServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DemoteServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DemoteServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApi）用于查询用户部署于 API 网关的 API 接口的详细信息。​
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public async Task<DescribeApiResponse> DescribeApi(DescribeApiRequest req)
        {
             JsonResponseModel<DescribeApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApi）用于查询用户部署于 API 网关的 API 接口的详细信息。​
        /// </summary>
        /// <param name="req"><see cref="DescribeApiRequest"/></param>
        /// <returns><see cref="DescribeApiResponse"/></returns>
        public DescribeApiResponse DescribeApiSync(DescribeApiRequest req)
        {
             JsonResponseModel<DescribeApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiEnvironmentStrategy）用于展示API绑定的限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public async Task<DescribeApiEnvironmentStrategyResponse> DescribeApiEnvironmentStrategy(DescribeApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiEnvironmentStrategy）用于展示API绑定的限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeApiEnvironmentStrategyResponse"/></returns>
        public DescribeApiEnvironmentStrategyResponse DescribeApiEnvironmentStrategySync(DescribeApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiKey）用于查询密钥详情。
        /// 用户在创建密钥后，可用此接口查询一个 API 密钥的详情，该接口会显示密钥 Key。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public async Task<DescribeApiKeyResponse> DescribeApiKey(DescribeApiKeyRequest req)
        {
             JsonResponseModel<DescribeApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiKey）用于查询密钥详情。
        /// 用户在创建密钥后，可用此接口查询一个 API 密钥的详情，该接口会显示密钥 Key。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeyRequest"/></param>
        /// <returns><see cref="DescribeApiKeyResponse"/></returns>
        public DescribeApiKeyResponse DescribeApiKeySync(DescribeApiKeyRequest req)
        {
             JsonResponseModel<DescribeApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiKeysStatus）用于查询密钥列表。
        /// 当用户创建了多个密钥对时，可使用本接口查询一个或多个 API 密钥信息，本接口不会显示密钥 Key。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public async Task<DescribeApiKeysStatusResponse> DescribeApiKeysStatus(DescribeApiKeysStatusRequest req)
        {
             JsonResponseModel<DescribeApiKeysStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiKeysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiKeysStatus）用于查询密钥列表。
        /// 当用户创建了多个密钥对时，可使用本接口查询一个或多个 API 密钥信息，本接口不会显示密钥 Key。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiKeysStatusRequest"/></param>
        /// <returns><see cref="DescribeApiKeysStatusResponse"/></returns>
        public DescribeApiKeysStatusResponse DescribeApiKeysStatusSync(DescribeApiKeysStatusRequest req)
        {
             JsonResponseModel<DescribeApiKeysStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiKeysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiKeysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiUsagePlan）用于查询服务中 API 使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务及其中 API 的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public async Task<DescribeApiUsagePlanResponse> DescribeApiUsagePlan(DescribeApiUsagePlanRequest req)
        {
             JsonResponseModel<DescribeApiUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApiUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApiUsagePlan）用于查询服务中 API 使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务及其中 API 的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeApiUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeApiUsagePlanResponse"/></returns>
        public DescribeApiUsagePlanResponse DescribeApiUsagePlanSync(DescribeApiUsagePlanRequest req)
        {
             JsonResponseModel<DescribeApiUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApiUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApiUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApisStatus）用于查看一个服务下的某个 API 或所有 API 列表及其相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public async Task<DescribeApisStatusResponse> DescribeApisStatus(DescribeApisStatusRequest req)
        {
             JsonResponseModel<DescribeApisStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeApisStatus）用于查看一个服务下的某个 API 或所有 API 列表及其相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeApisStatusRequest"/></param>
        /// <returns><see cref="DescribeApisStatusResponse"/></returns>
        public DescribeApisStatusResponse DescribeApisStatusSync(DescribeApisStatusRequest req)
        {
             JsonResponseModel<DescribeApisStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIPStrategy）用于查询IP策略详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public async Task<DescribeIPStrategyResponse> DescribeIPStrategy(DescribeIPStrategyRequest req)
        {
             JsonResponseModel<DescribeIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIPStrategy）用于查询IP策略详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyResponse"/></returns>
        public DescribeIPStrategyResponse DescribeIPStrategySync(DescribeIPStrategyRequest req)
        {
             JsonResponseModel<DescribeIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIPStrategyApisStatus）用于查询IP策略绑定的API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public async Task<DescribeIPStrategyApisStatusResponse> DescribeIPStrategyApisStatus(DescribeIPStrategyApisStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategyApisStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStrategyApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIPStrategyApisStatus）用于查询IP策略绑定的API列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategyApisStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategyApisStatusResponse"/></returns>
        public DescribeIPStrategyApisStatusResponse DescribeIPStrategyApisStatusSync(DescribeIPStrategyApisStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategyApisStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStrategyApisStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategyApisStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIPStrategysStatus）用于查询服务IP策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public async Task<DescribeIPStrategysStatusResponse> DescribeIPStrategysStatus(DescribeIPStrategysStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategysStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStrategysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeIPStrategysStatus）用于查询服务IP策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStrategysStatusRequest"/></param>
        /// <returns><see cref="DescribeIPStrategysStatusResponse"/></returns>
        public DescribeIPStrategysStatusResponse DescribeIPStrategysStatusSync(DescribeIPStrategysStatusRequest req)
        {
             JsonResponseModel<DescribeIPStrategysStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStrategysStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStrategysStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于搜索日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public async Task<DescribeLogSearchResponse> DescribeLogSearch(DescribeLogSearchRequest req)
        {
             JsonResponseModel<DescribeLogSearchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于搜索日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSearchRequest"/></param>
        /// <returns><see cref="DescribeLogSearchResponse"/></returns>
        public DescribeLogSearchResponse DescribeLogSearchSync(DescribeLogSearchRequest req)
        {
             JsonResponseModel<DescribeLogSearchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogSearch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSearchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeService）用于查询一个服务的详细信息、包括服务的描述、域名、协议、创建时间、发布情况等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public async Task<DescribeServiceResponse> DescribeService(DescribeServiceRequest req)
        {
             JsonResponseModel<DescribeServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeService）用于查询一个服务的详细信息、包括服务的描述、域名、协议、创建时间、发布情况等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRequest"/></param>
        /// <returns><see cref="DescribeServiceResponse"/></returns>
        public DescribeServiceResponse DescribeServiceSync(DescribeServiceRequest req)
        {
             JsonResponseModel<DescribeServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentList）用于查询一个服务的环境列表，可查询到此服务下所有环境及其状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public async Task<DescribeServiceEnvironmentListResponse> DescribeServiceEnvironmentList(DescribeServiceEnvironmentListRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceEnvironmentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentList）用于查询一个服务的环境列表，可查询到此服务下所有环境及其状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentListRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentListResponse"/></returns>
        public DescribeServiceEnvironmentListResponse DescribeServiceEnvironmentListSync(DescribeServiceEnvironmentListRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceEnvironmentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentReleaseHistory）用于查询服务环境的发布历史。
        /// 用户在创建好服务后需要发布到某个环境中才能进行使用，本接口用于查询一个服务某个环境的发布记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public async Task<DescribeServiceEnvironmentReleaseHistoryResponse> DescribeServiceEnvironmentReleaseHistory(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceEnvironmentReleaseHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentReleaseHistory）用于查询服务环境的发布历史。
        /// 用户在创建好服务后需要发布到某个环境中才能进行使用，本接口用于查询一个服务某个环境的发布记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentReleaseHistoryRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentReleaseHistoryResponse"/></returns>
        public DescribeServiceEnvironmentReleaseHistoryResponse DescribeServiceEnvironmentReleaseHistorySync(DescribeServiceEnvironmentReleaseHistoryRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceEnvironmentReleaseHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentReleaseHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentStrategy）用于展示服务限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public async Task<DescribeServiceEnvironmentStrategyResponse> DescribeServiceEnvironmentStrategy(DescribeServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceEnvironmentStrategy）用于展示服务限流策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="DescribeServiceEnvironmentStrategyResponse"/></returns>
        public DescribeServiceEnvironmentStrategyResponse DescribeServiceEnvironmentStrategySync(DescribeServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<DescribeServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceReleaseVersion）查询一个服务下面所有已经发布的版本列表。
        /// 用户在发布服务时，常有多个版本发布，可使用本接口查询已发布的版本。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public async Task<DescribeServiceReleaseVersionResponse> DescribeServiceReleaseVersion(DescribeServiceReleaseVersionRequest req)
        {
             JsonResponseModel<DescribeServiceReleaseVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceReleaseVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceReleaseVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceReleaseVersion）查询一个服务下面所有已经发布的版本列表。
        /// 用户在发布服务时，常有多个版本发布，可使用本接口查询已发布的版本。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceReleaseVersionRequest"/></param>
        /// <returns><see cref="DescribeServiceReleaseVersionResponse"/></returns>
        public DescribeServiceReleaseVersionResponse DescribeServiceReleaseVersionSync(DescribeServiceReleaseVersionRequest req)
        {
             JsonResponseModel<DescribeServiceReleaseVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceReleaseVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceReleaseVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomainMappings）用于查询自定义域名的路径映射。
        /// API 网关可绑定自定义域名到服务，并且可以对自定义域名的路径进行映射，可自定义不同的路径映射到服务中的三个环境，本接口用于查询绑定服务的自定义域名的路径映射列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public async Task<DescribeServiceSubDomainMappingsResponse> DescribeServiceSubDomainMappings(DescribeServiceSubDomainMappingsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainMappingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceSubDomainMappings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainMappingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomainMappings）用于查询自定义域名的路径映射。
        /// API 网关可绑定自定义域名到服务，并且可以对自定义域名的路径进行映射，可自定义不同的路径映射到服务中的三个环境，本接口用于查询绑定服务的自定义域名的路径映射列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainMappingsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainMappingsResponse"/></returns>
        public DescribeServiceSubDomainMappingsResponse DescribeServiceSubDomainMappingsSync(DescribeServiceSubDomainMappingsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainMappingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceSubDomainMappings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainMappingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomains）用于查询自定义域名列表。
        /// API 网关可绑定自定义域名到服务，用于服务调用。此接口用于查询用户绑定在服务的自定义域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public async Task<DescribeServiceSubDomainsResponse> DescribeServiceSubDomains(DescribeServiceSubDomainsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceSubDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceSubDomains）用于查询自定义域名列表。
        /// API 网关可绑定自定义域名到服务，用于服务调用。此接口用于查询用户绑定在服务的自定义域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceSubDomainsRequest"/></param>
        /// <returns><see cref="DescribeServiceSubDomainsResponse"/></returns>
        public DescribeServiceSubDomainsResponse DescribeServiceSubDomainsSync(DescribeServiceSubDomainsRequest req)
        {
             JsonResponseModel<DescribeServiceSubDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceSubDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceSubDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceUsagePlan）用于查询服务使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public async Task<DescribeServiceUsagePlanResponse> DescribeServiceUsagePlan(DescribeServiceUsagePlanRequest req)
        {
             JsonResponseModel<DescribeServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServiceUsagePlan）用于查询服务使用计划详情。
        /// 服务若需要鉴权限流生效，则需要绑定使用计划到此服务中，本接口用于查询绑定到一个服务的所有使用计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeServiceUsagePlanResponse"/></returns>
        public DescribeServiceUsagePlanResponse DescribeServiceUsagePlanSync(DescribeServiceUsagePlanRequest req)
        {
             JsonResponseModel<DescribeServiceUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServicesStatus）用于搜索查询某一个服务或多个服务的列表，并返回服务相关的域名、时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public async Task<DescribeServicesStatusResponse> DescribeServicesStatus(DescribeServicesStatusRequest req)
        {
             JsonResponseModel<DescribeServicesStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServicesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServicesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeServicesStatus）用于搜索查询某一个服务或多个服务的列表，并返回服务相关的域名、时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesStatusRequest"/></param>
        /// <returns><see cref="DescribeServicesStatusResponse"/></returns>
        public DescribeServicesStatusResponse DescribeServicesStatusSync(DescribeServicesStatusRequest req)
        {
             JsonResponseModel<DescribeServicesStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServicesStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServicesStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlan）用于查询一个使用计划的详细信息，包括名称、QPS、创建时间绑定的环境等。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public async Task<DescribeUsagePlanResponse> DescribeUsagePlan(DescribeUsagePlanRequest req)
        {
             JsonResponseModel<DescribeUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlan）用于查询一个使用计划的详细信息，包括名称、QPS、创建时间绑定的环境等。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanResponse"/></returns>
        public DescribeUsagePlanResponse DescribeUsagePlanSync(DescribeUsagePlanRequest req)
        {
             JsonResponseModel<DescribeUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanEnvironments）用于查询使用计划绑定的环境列表。
        /// 用户在绑定了某个使用计划到环境后，可使用本接口查询这个使用计划绑定的所有服务的环境。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public async Task<DescribeUsagePlanEnvironmentsResponse> DescribeUsagePlanEnvironments(DescribeUsagePlanEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlanEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanEnvironments）用于查询使用计划绑定的环境列表。
        /// 用户在绑定了某个使用计划到环境后，可使用本接口查询这个使用计划绑定的所有服务的环境。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanEnvironmentsResponse"/></returns>
        public DescribeUsagePlanEnvironmentsResponse DescribeUsagePlanEnvironmentsSync(DescribeUsagePlanEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlanEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanSecretIds）用于查询使用计划绑定的密钥列表。
        /// 在 API 网关中，一个使用计划可绑定多个密钥对，可使用本接口查询使用计划绑定的密钥列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public async Task<DescribeUsagePlanSecretIdsResponse> DescribeUsagePlanSecretIds(DescribeUsagePlanSecretIdsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlanSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanSecretIds）用于查询使用计划绑定的密钥列表。
        /// 在 API 网关中，一个使用计划可绑定多个密钥对，可使用本接口查询使用计划绑定的密钥列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlanSecretIdsRequest"/></param>
        /// <returns><see cref="DescribeUsagePlanSecretIdsResponse"/></returns>
        public DescribeUsagePlanSecretIdsResponse DescribeUsagePlanSecretIdsSync(DescribeUsagePlanSecretIdsRequest req)
        {
             JsonResponseModel<DescribeUsagePlanSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlanSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlanSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanStatus）用于查询使用计划的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public async Task<DescribeUsagePlansStatusResponse> DescribeUsagePlansStatus(DescribeUsagePlansStatusRequest req)
        {
             JsonResponseModel<DescribeUsagePlansStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsagePlansStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlansStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUsagePlanStatus）用于查询使用计划的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsagePlansStatusRequest"/></param>
        /// <returns><see cref="DescribeUsagePlansStatusResponse"/></returns>
        public DescribeUsagePlansStatusResponse DescribeUsagePlansStatusSync(DescribeUsagePlansStatusRequest req)
        {
             JsonResponseModel<DescribeUsagePlansStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsagePlansStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsagePlansStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableApiKey）用于禁用一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public async Task<DisableApiKeyResponse> DisableApiKey(DisableApiKeyRequest req)
        {
             JsonResponseModel<DisableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableApiKey）用于禁用一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="DisableApiKeyRequest"/></param>
        /// <returns><see cref="DisableApiKeyResponse"/></returns>
        public DisableApiKeyResponse DisableApiKeySync(DisableApiKeyRequest req)
        {
             JsonResponseModel<DisableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableApiKey）用于启动一对被禁用的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public async Task<EnableApiKeyResponse> EnableApiKey(EnableApiKeyRequest req)
        {
             JsonResponseModel<EnableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableApiKey）用于启动一对被禁用的 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="EnableApiKeyRequest"/></param>
        /// <returns><see cref="EnableApiKeyResponse"/></returns>
        public EnableApiKeyResponse EnableApiKeySync(EnableApiKeyRequest req)
        {
             JsonResponseModel<EnableApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GenerateApiDocument）用于自动生成 API 文档和 SDK，一个服务的一个环境生成一份文档和 SDK。
        /// </summary>
        /// <param name="req"><see cref="GenerateApiDocumentRequest"/></param>
        /// <returns><see cref="GenerateApiDocumentResponse"/></returns>
        public async Task<GenerateApiDocumentResponse> GenerateApiDocument(GenerateApiDocumentRequest req)
        {
             JsonResponseModel<GenerateApiDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateApiDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateApiDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GenerateApiDocument）用于自动生成 API 文档和 SDK，一个服务的一个环境生成一份文档和 SDK。
        /// </summary>
        /// <param name="req"><see cref="GenerateApiDocumentRequest"/></param>
        /// <returns><see cref="GenerateApiDocumentResponse"/></returns>
        public GenerateApiDocumentResponse GenerateApiDocumentSync(GenerateApiDocumentRequest req)
        {
             JsonResponseModel<GenerateApiDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateApiDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateApiDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyApi）用于修改 API 接口，可调用此接口对已经配置的 API 接口进行编辑修改。修改后的 API 需要重新发布 API 所在的服务到对应环境方能生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public async Task<ModifyApiResponse> ModifyApi(ModifyApiRequest req)
        {
             JsonResponseModel<ModifyApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyApi）用于修改 API 接口，可调用此接口对已经配置的 API 接口进行编辑修改。修改后的 API 需要重新发布 API 所在的服务到对应环境方能生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyApiRequest"/></param>
        /// <returns><see cref="ModifyApiResponse"/></returns>
        public ModifyApiResponse ModifyApiSync(ModifyApiRequest req)
        {
             JsonResponseModel<ModifyApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyApiEnvironmentStrategy）用于修改API限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public async Task<ModifyApiEnvironmentStrategyResponse> ModifyApiEnvironmentStrategy(ModifyApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyApiEnvironmentStrategy）用于修改API限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyApiEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyApiEnvironmentStrategyResponse"/></returns>
        public ModifyApiEnvironmentStrategyResponse ModifyApiEnvironmentStrategySync(ModifyApiEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyApiEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApiEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供增量更新API能力，主要是给程序调用（区别于ModifyApi，该接口是需要传入API的全量参数，对console使用较友好）
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public async Task<ModifyApiIncrementResponse> ModifyApiIncrement(ModifyApiIncrementRequest req)
        {
             JsonResponseModel<ModifyApiIncrementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApiIncrement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiIncrementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供增量更新API能力，主要是给程序调用（区别于ModifyApi，该接口是需要传入API的全量参数，对console使用较友好）
        /// </summary>
        /// <param name="req"><see cref="ModifyApiIncrementRequest"/></param>
        /// <returns><see cref="ModifyApiIncrementResponse"/></returns>
        public ModifyApiIncrementResponse ModifyApiIncrementSync(ModifyApiIncrementRequest req)
        {
             JsonResponseModel<ModifyApiIncrementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApiIncrement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiIncrementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyIPStrategy）用于修改服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public async Task<ModifyIPStrategyResponse> ModifyIPStrategy(ModifyIPStrategyRequest req)
        {
             JsonResponseModel<ModifyIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyIPStrategy）用于修改服务IP策略。
        /// </summary>
        /// <param name="req"><see cref="ModifyIPStrategyRequest"/></param>
        /// <returns><see cref="ModifyIPStrategyResponse"/></returns>
        public ModifyIPStrategyResponse ModifyIPStrategySync(ModifyIPStrategyRequest req)
        {
             JsonResponseModel<ModifyIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyService）用于修改服务的相关信息。当服务创建后，服务的名称、描述和服务类型均可被修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public async Task<ModifyServiceResponse> ModifyService(ModifyServiceRequest req)
        {
             JsonResponseModel<ModifyServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyService）用于修改服务的相关信息。当服务创建后，服务的名称、描述和服务类型均可被修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceRequest"/></param>
        /// <returns><see cref="ModifyServiceResponse"/></returns>
        public ModifyServiceResponse ModifyServiceSync(ModifyServiceRequest req)
        {
             JsonResponseModel<ModifyServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyServiceEnvironmentStrategy）用于修改服务限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public async Task<ModifyServiceEnvironmentStrategyResponse> ModifyServiceEnvironmentStrategy(ModifyServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyServiceEnvironmentStrategy）用于修改服务限流策略
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceEnvironmentStrategyRequest"/></param>
        /// <returns><see cref="ModifyServiceEnvironmentStrategyResponse"/></returns>
        public ModifyServiceEnvironmentStrategyResponse ModifyServiceEnvironmentStrategySync(ModifyServiceEnvironmentStrategyRequest req)
        {
             JsonResponseModel<ModifyServiceEnvironmentStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceEnvironmentStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceEnvironmentStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySubDomain）用于修改服务的自定义域名设置中的路径映射，可以修改绑定自定义域名之前的路径映射规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public async Task<ModifySubDomainResponse> ModifySubDomain(ModifySubDomainRequest req)
        {
             JsonResponseModel<ModifySubDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySubDomain）用于修改服务的自定义域名设置中的路径映射，可以修改绑定自定义域名之前的路径映射规则。
        /// </summary>
        /// <param name="req"><see cref="ModifySubDomainRequest"/></param>
        /// <returns><see cref="ModifySubDomainResponse"/></returns>
        public ModifySubDomainResponse ModifySubDomainSync(ModifySubDomainRequest req)
        {
             JsonResponseModel<ModifySubDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyUsagePlan）用于修改使用计划的名称，描述及 QPS。
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public async Task<ModifyUsagePlanResponse> ModifyUsagePlan(ModifyUsagePlanRequest req)
        {
             JsonResponseModel<ModifyUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyUsagePlan）用于修改使用计划的名称，描述及 QPS。
        /// </summary>
        /// <param name="req"><see cref="ModifyUsagePlanRequest"/></param>
        /// <returns><see cref="ModifyUsagePlanResponse"/></returns>
        public ModifyUsagePlanResponse ModifyUsagePlanSync(ModifyUsagePlanRequest req)
        {
             JsonResponseModel<ModifyUsagePlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUsagePlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUsagePlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReleaseService）用于发布服务。
        /// API 网关的服务创建后，需要发布到某个环境方生效后，使用者才能进行调用，此接口用于发布服务到环境，如 release 环境。
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public async Task<ReleaseServiceResponse> ReleaseService(ReleaseServiceRequest req)
        {
             JsonResponseModel<ReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReleaseService）用于发布服务。
        /// API 网关的服务创建后，需要发布到某个环境方生效后，使用者才能进行调用，此接口用于发布服务到环境，如 release 环境。
        /// </summary>
        /// <param name="req"><see cref="ReleaseServiceRequest"/></param>
        /// <returns><see cref="ReleaseServiceResponse"/></returns>
        public ReleaseServiceResponse ReleaseServiceSync(ReleaseServiceRequest req)
        {
             JsonResponseModel<ReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindEnvironment）用于将使用计划从特定环境解绑。
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public async Task<UnBindEnvironmentResponse> UnBindEnvironment(UnBindEnvironmentRequest req)
        {
             JsonResponseModel<UnBindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindEnvironment）用于将使用计划从特定环境解绑。
        /// </summary>
        /// <param name="req"><see cref="UnBindEnvironmentRequest"/></param>
        /// <returns><see cref="UnBindEnvironmentResponse"/></returns>
        public UnBindEnvironmentResponse UnBindEnvironmentSync(UnBindEnvironmentRequest req)
        {
             JsonResponseModel<UnBindEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindIPStrategy）用于服务解绑IP策略。
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public async Task<UnBindIPStrategyResponse> UnBindIPStrategy(UnBindIPStrategyRequest req)
        {
             JsonResponseModel<UnBindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindIPStrategy）用于服务解绑IP策略。
        /// </summary>
        /// <param name="req"><see cref="UnBindIPStrategyRequest"/></param>
        /// <returns><see cref="UnBindIPStrategyResponse"/></returns>
        public UnBindIPStrategyResponse UnBindIPStrategySync(UnBindIPStrategyRequest req)
        {
             JsonResponseModel<UnBindIPStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindIPStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindIPStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindSecretIds）用于为使用计划解绑密钥。
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public async Task<UnBindSecretIdsResponse> UnBindSecretIds(UnBindSecretIdsRequest req)
        {
             JsonResponseModel<UnBindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindSecretIds）用于为使用计划解绑密钥。
        /// </summary>
        /// <param name="req"><see cref="UnBindSecretIdsRequest"/></param>
        /// <returns><see cref="UnBindSecretIdsResponse"/></returns>
        public UnBindSecretIdsResponse UnBindSecretIdsSync(UnBindSecretIdsRequest req)
        {
             JsonResponseModel<UnBindSecretIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindSecretIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSecretIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindSubDomain）用于解绑自定义域名。
        /// 用户使用 API 网关绑定了自定义域名到服务中后，若想要解绑此自定义域名，可使用此接口。
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public async Task<UnBindSubDomainResponse> UnBindSubDomain(UnBindSubDomainRequest req)
        {
             JsonResponseModel<UnBindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnBindSubDomain）用于解绑自定义域名。
        /// 用户使用 API 网关绑定了自定义域名到服务中后，若想要解绑此自定义域名，可使用此接口。
        /// </summary>
        /// <param name="req"><see cref="UnBindSubDomainRequest"/></param>
        /// <returns><see cref="UnBindSubDomainResponse"/></returns>
        public UnBindSubDomainResponse UnBindSubDomainSync(UnBindSubDomainRequest req)
        {
             JsonResponseModel<UnBindSubDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindSubDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindSubDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnReleaseService）用于下线服务。
        /// 用户发布服务到某个环境后，此服务中的 API 方可被调用者进行调用，当用户需要将此服务从发布环境中下线时，可调用此 API。下线后的服务不可被调用。
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public async Task<UnReleaseServiceResponse> UnReleaseService(UnReleaseServiceRequest req)
        {
             JsonResponseModel<UnReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnReleaseService）用于下线服务。
        /// 用户发布服务到某个环境后，此服务中的 API 方可被调用者进行调用，当用户需要将此服务从发布环境中下线时，可调用此 API。下线后的服务不可被调用。
        /// </summary>
        /// <param name="req"><see cref="UnReleaseServiceRequest"/></param>
        /// <returns><see cref="UnReleaseServiceResponse"/></returns>
        public UnReleaseServiceResponse UnReleaseServiceSync(UnReleaseServiceRequest req)
        {
             JsonResponseModel<UnReleaseServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnReleaseService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnReleaseServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateApiKey）用于更换用户已创建的一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public async Task<UpdateApiKeyResponse> UpdateApiKey(UpdateApiKeyRequest req)
        {
             JsonResponseModel<UpdateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateApiKey）用于更换用户已创建的一对 API 密钥。
        /// </summary>
        /// <param name="req"><see cref="UpdateApiKeyRequest"/></param>
        /// <returns><see cref="UpdateApiKeyResponse"/></returns>
        public UpdateApiKeyResponse UpdateApiKeySync(UpdateApiKeyRequest req)
        {
             JsonResponseModel<UpdateApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateService）用于从服务发布的环境中运行版本切换到特定版本。用户在使用 API 网关创建服务并发布服务到某个环境后，多因为开发过程会产生多个版本，此时可调用本接口。
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public async Task<UpdateServiceResponse> UpdateService(UpdateServiceRequest req)
        {
             JsonResponseModel<UpdateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateService）用于从服务发布的环境中运行版本切换到特定版本。用户在使用 API 网关创建服务并发布服务到某个环境后，多因为开发过程会产生多个版本，此时可调用本接口。
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public UpdateServiceResponse UpdateServiceSync(UpdateServiceRequest req)
        {
             JsonResponseModel<UpdateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
