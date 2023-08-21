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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 创建云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayResponse"/></returns>
        public async Task<CreateCloudNativeAPIGatewayResponse> CreateCloudNativeAPIGateway(CreateCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayResponse"/></returns>
        public CreateCloudNativeAPIGatewayResponse CreateCloudNativeAPIGatewaySync(CreateCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public async Task<CreateCloudNativeAPIGatewayCanaryRuleResponse> CreateCloudNativeAPIGatewayCanaryRule(CreateCloudNativeAPIGatewayCanaryRuleRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayCanaryRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudNativeAPIGatewayCanaryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayCanaryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public CreateCloudNativeAPIGatewayCanaryRuleResponse CreateCloudNativeAPIGatewayCanaryRuleSync(CreateCloudNativeAPIGatewayCanaryRuleRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayCanaryRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudNativeAPIGatewayCanaryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayCanaryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteResponse"/></returns>
        public async Task<CreateCloudNativeAPIGatewayRouteResponse> CreateCloudNativeAPIGatewayRoute(CreateCloudNativeAPIGatewayRouteRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudNativeAPIGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteResponse"/></returns>
        public CreateCloudNativeAPIGatewayRouteResponse CreateCloudNativeAPIGatewayRouteSync(CreateCloudNativeAPIGatewayRouteRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudNativeAPIGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public async Task<CreateCloudNativeAPIGatewayRouteRateLimitResponse> CreateCloudNativeAPIGatewayRouteRateLimit(CreateCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public CreateCloudNativeAPIGatewayRouteRateLimitResponse CreateCloudNativeAPIGatewayRouteRateLimitSync(CreateCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceResponse"/></returns>
        public async Task<CreateCloudNativeAPIGatewayServiceResponse> CreateCloudNativeAPIGatewayService(CreateCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceResponse"/></returns>
        public CreateCloudNativeAPIGatewayServiceResponse CreateCloudNativeAPIGatewayServiceSync(CreateCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public async Task<CreateCloudNativeAPIGatewayServiceRateLimitResponse> CreateCloudNativeAPIGatewayServiceRateLimit(CreateCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="CreateCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="CreateCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public CreateCloudNativeAPIGatewayServiceRateLimitResponse CreateCloudNativeAPIGatewayServiceRateLimitSync(CreateCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<CreateCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建引擎实例
        /// </summary>
        /// <param name="req"><see cref="CreateEngineRequest"/></param>
        /// <returns><see cref="CreateEngineResponse"/></returns>
        public async Task<CreateEngineResponse> CreateEngine(CreateEngineRequest req)
        {
             JsonResponseModel<CreateEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建引擎实例
        /// </summary>
        /// <param name="req"><see cref="CreateEngineRequest"/></param>
        /// <returns><see cref="CreateEngineResponse"/></returns>
        public CreateEngineResponse CreateEngineSync(CreateEngineRequest req)
        {
             JsonResponseModel<CreateEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关引擎分组
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServerGroupResponse"/></returns>
        public async Task<CreateNativeGatewayServerGroupResponse> CreateNativeGatewayServerGroup(CreateNativeGatewayServerGroupRequest req)
        {
             JsonResponseModel<CreateNativeGatewayServerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNativeGatewayServerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNativeGatewayServerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云原生网关引擎分组
        /// </summary>
        /// <param name="req"><see cref="CreateNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="CreateNativeGatewayServerGroupResponse"/></returns>
        public CreateNativeGatewayServerGroupResponse CreateNativeGatewayServerGroupSync(CreateNativeGatewayServerGroupRequest req)
        {
             JsonResponseModel<CreateNativeGatewayServerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNativeGatewayServerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNativeGatewayServerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayResponse"/></returns>
        public async Task<DeleteCloudNativeAPIGatewayResponse> DeleteCloudNativeAPIGateway(DeleteCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生API网关实例
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayResponse"/></returns>
        public DeleteCloudNativeAPIGatewayResponse DeleteCloudNativeAPIGatewaySync(DeleteCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public async Task<DeleteCloudNativeAPIGatewayCanaryRuleResponse> DeleteCloudNativeAPIGatewayCanaryRule(DeleteCloudNativeAPIGatewayCanaryRuleRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayCanaryRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudNativeAPIGatewayCanaryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayCanaryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public DeleteCloudNativeAPIGatewayCanaryRuleResponse DeleteCloudNativeAPIGatewayCanaryRuleSync(DeleteCloudNativeAPIGatewayCanaryRuleRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayCanaryRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudNativeAPIGatewayCanaryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayCanaryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteResponse"/></returns>
        public async Task<DeleteCloudNativeAPIGatewayRouteResponse> DeleteCloudNativeAPIGatewayRoute(DeleteCloudNativeAPIGatewayRouteRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudNativeAPIGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteResponse"/></returns>
        public DeleteCloudNativeAPIGatewayRouteResponse DeleteCloudNativeAPIGatewayRouteSync(DeleteCloudNativeAPIGatewayRouteRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudNativeAPIGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public async Task<DeleteCloudNativeAPIGatewayRouteRateLimitResponse> DeleteCloudNativeAPIGatewayRouteRateLimit(DeleteCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public DeleteCloudNativeAPIGatewayRouteRateLimitResponse DeleteCloudNativeAPIGatewayRouteRateLimitSync(DeleteCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceResponse"/></returns>
        public async Task<DeleteCloudNativeAPIGatewayServiceResponse> DeleteCloudNativeAPIGatewayService(DeleteCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceResponse"/></returns>
        public DeleteCloudNativeAPIGatewayServiceResponse DeleteCloudNativeAPIGatewayServiceSync(DeleteCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public async Task<DeleteCloudNativeAPIGatewayServiceRateLimitResponse> DeleteCloudNativeAPIGatewayServiceRateLimit(DeleteCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DeleteCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public DeleteCloudNativeAPIGatewayServiceRateLimitResponse DeleteCloudNativeAPIGatewayServiceRateLimitSync(DeleteCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<DeleteCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除引擎实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEngineRequest"/></param>
        /// <returns><see cref="DeleteEngineResponse"/></returns>
        public async Task<DeleteEngineResponse> DeleteEngine(DeleteEngineRequest req)
        {
             JsonResponseModel<DeleteEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除引擎实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEngineRequest"/></param>
        /// <returns><see cref="DeleteEngineResponse"/></returns>
        public DeleteEngineResponse DeleteEngineSync(DeleteEngineRequest req)
        {
             JsonResponseModel<DeleteEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除网关实例分组
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServerGroupResponse"/></returns>
        public async Task<DeleteNativeGatewayServerGroupResponse> DeleteNativeGatewayServerGroup(DeleteNativeGatewayServerGroupRequest req)
        {
             JsonResponseModel<DeleteNativeGatewayServerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNativeGatewayServerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNativeGatewayServerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除网关实例分组
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="DeleteNativeGatewayServerGroupResponse"/></returns>
        public DeleteNativeGatewayServerGroupResponse DeleteNativeGatewayServerGroupSync(DeleteNativeGatewayServerGroupRequest req)
        {
             JsonResponseModel<DeleteNativeGatewayServerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNativeGatewayServerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNativeGatewayServerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生API网关实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayResponse> DescribeCloudNativeAPIGateway(DescribeCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生API网关实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayResponse"/></returns>
        public DescribeCloudNativeAPIGatewayResponse DescribeCloudNativeAPIGatewaySync(DescribeCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关灰度规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCanaryRulesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCanaryRulesResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayCanaryRulesResponse> DescribeCloudNativeAPIGatewayCanaryRules(DescribeCloudNativeAPIGatewayCanaryRulesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayCanaryRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayCanaryRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayCanaryRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关灰度规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayCanaryRulesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayCanaryRulesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayCanaryRulesResponse DescribeCloudNativeAPIGatewayCanaryRulesSync(DescribeCloudNativeAPIGatewayCanaryRulesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayCanaryRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayCanaryRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayCanaryRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生网关节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayNodesResponse> DescribeCloudNativeAPIGatewayNodes(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生网关节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayNodesResponse DescribeCloudNativeAPIGatewayNodesSync(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生API网关实例端口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayPortsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayPortsResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayPortsResponse> DescribeCloudNativeAPIGatewayPorts(DescribeCloudNativeAPIGatewayPortsRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayPortsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayPorts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayPortsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生API网关实例端口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayPortsRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayPortsResponse"/></returns>
        public DescribeCloudNativeAPIGatewayPortsResponse DescribeCloudNativeAPIGatewayPortsSync(DescribeCloudNativeAPIGatewayPortsRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayPortsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayPorts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayPortsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayRouteRateLimitResponse> DescribeCloudNativeAPIGatewayRouteRateLimit(DescribeCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关的限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public DescribeCloudNativeAPIGatewayRouteRateLimitResponse DescribeCloudNativeAPIGatewayRouteRateLimitSync(DescribeCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRoutesResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayRoutesResponse> DescribeCloudNativeAPIGatewayRoutes(DescribeCloudNativeAPIGatewayRoutesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayRoutesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayRoutesResponse DescribeCloudNativeAPIGatewayRoutesSync(DescribeCloudNativeAPIGatewayRoutesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayServiceRateLimitResponse> DescribeCloudNativeAPIGatewayServiceRateLimit(DescribeCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关的限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public DescribeCloudNativeAPIGatewayServiceRateLimitResponse DescribeCloudNativeAPIGatewayServiceRateLimitSync(DescribeCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayServicesResponse> DescribeCloudNativeAPIGatewayServices(DescribeCloudNativeAPIGatewayServicesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayServicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayServices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayServicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云原生网关服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayServicesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayServicesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayServicesResponse DescribeCloudNativeAPIGatewayServicesSync(DescribeCloudNativeAPIGatewayServicesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayServicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayServices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayServicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生API网关实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaysResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewaysResponse> DescribeCloudNativeAPIGateways(DescribeCloudNativeAPIGatewaysRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生API网关实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewaysResponse"/></returns>
        public DescribeCloudNativeAPIGatewaysResponse DescribeCloudNativeAPIGatewaysSync(DescribeCloudNativeAPIGatewaysRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Nacos类型引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosReplicasRequest"/></param>
        /// <returns><see cref="DescribeNacosReplicasResponse"/></returns>
        public async Task<DescribeNacosReplicasResponse> DescribeNacosReplicas(DescribeNacosReplicasRequest req)
        {
             JsonResponseModel<DescribeNacosReplicasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNacosReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Nacos类型引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosReplicasRequest"/></param>
        /// <returns><see cref="DescribeNacosReplicasResponse"/></returns>
        public DescribeNacosReplicasResponse DescribeNacosReplicasSync(DescribeNacosReplicasRequest req)
        {
             JsonResponseModel<DescribeNacosReplicasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNacosReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询nacos服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNacosServerInterfacesResponse"/></returns>
        public async Task<DescribeNacosServerInterfacesResponse> DescribeNacosServerInterfaces(DescribeNacosServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeNacosServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNacosServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询nacos服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNacosServerInterfacesResponse"/></returns>
        public DescribeNacosServerInterfacesResponse DescribeNacosServerInterfacesSync(DescribeNacosServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeNacosServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNacosServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生网关服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeOneCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DescribeOneCloudNativeAPIGatewayServiceResponse"/></returns>
        public async Task<DescribeOneCloudNativeAPIGatewayServiceResponse> DescribeOneCloudNativeAPIGatewayService(DescribeOneCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<DescribeOneCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOneCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOneCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生网关服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeOneCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="DescribeOneCloudNativeAPIGatewayServiceResponse"/></returns>
        public DescribeOneCloudNativeAPIGatewayServiceResponse DescribeOneCloudNativeAPIGatewayServiceSync(DescribeOneCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<DescribeOneCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOneCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOneCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public async Task<DescribeSREInstanceAccessAddressResponse> DescribeSREInstanceAccessAddress(DescribeSREInstanceAccessAddressRequest req)
        {
             JsonResponseModel<DescribeSREInstanceAccessAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSREInstanceAccessAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstanceAccessAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public DescribeSREInstanceAccessAddressResponse DescribeSREInstanceAccessAddressSync(DescribeSREInstanceAccessAddressRequest req)
        {
             JsonResponseModel<DescribeSREInstanceAccessAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSREInstanceAccessAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstanceAccessAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public async Task<DescribeSREInstancesResponse> DescribeSREInstances(DescribeSREInstancesRequest req)
        {
             JsonResponseModel<DescribeSREInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSREInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public DescribeSREInstancesResponse DescribeSREInstancesSync(DescribeSREInstancesRequest req)
        {
             JsonResponseModel<DescribeSREInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSREInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Zookeeper类型注册引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperReplicasRequest"/></param>
        /// <returns><see cref="DescribeZookeeperReplicasResponse"/></returns>
        public async Task<DescribeZookeeperReplicasResponse> DescribeZookeeperReplicas(DescribeZookeeperReplicasRequest req)
        {
             JsonResponseModel<DescribeZookeeperReplicasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZookeeperReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Zookeeper类型注册引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperReplicasRequest"/></param>
        /// <returns><see cref="DescribeZookeeperReplicasResponse"/></returns>
        public DescribeZookeeperReplicasResponse DescribeZookeeperReplicasSync(DescribeZookeeperReplicasRequest req)
        {
             JsonResponseModel<DescribeZookeeperReplicasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZookeeperReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询zookeeper服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeZookeeperServerInterfacesResponse"/></returns>
        public async Task<DescribeZookeeperServerInterfacesResponse> DescribeZookeeperServerInterfaces(DescribeZookeeperServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeZookeeperServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZookeeperServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询zookeeper服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeZookeeperServerInterfacesResponse"/></returns>
        public DescribeZookeeperServerInterfacesResponse DescribeZookeeperServerInterfacesSync(DescribeZookeeperServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeZookeeperServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZookeeperServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生API网关实例基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayResponse"/></returns>
        public async Task<ModifyCloudNativeAPIGatewayResponse> ModifyCloudNativeAPIGateway(ModifyCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生API网关实例基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayResponse"/></returns>
        public ModifyCloudNativeAPIGatewayResponse ModifyCloudNativeAPIGatewaySync(ModifyCloudNativeAPIGatewayRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudNativeAPIGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public async Task<ModifyCloudNativeAPIGatewayCanaryRuleResponse> ModifyCloudNativeAPIGatewayCanaryRule(ModifyCloudNativeAPIGatewayCanaryRuleRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayCanaryRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudNativeAPIGatewayCanaryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayCanaryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关的灰度规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayCanaryRuleRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayCanaryRuleResponse"/></returns>
        public ModifyCloudNativeAPIGatewayCanaryRuleResponse ModifyCloudNativeAPIGatewayCanaryRuleSync(ModifyCloudNativeAPIGatewayCanaryRuleRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayCanaryRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudNativeAPIGatewayCanaryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayCanaryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteResponse"/></returns>
        public async Task<ModifyCloudNativeAPIGatewayRouteResponse> ModifyCloudNativeAPIGatewayRoute(ModifyCloudNativeAPIGatewayRouteRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudNativeAPIGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关路由
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteResponse"/></returns>
        public ModifyCloudNativeAPIGatewayRouteResponse ModifyCloudNativeAPIGatewayRouteSync(ModifyCloudNativeAPIGatewayRouteRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudNativeAPIGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public async Task<ModifyCloudNativeAPIGatewayRouteRateLimitResponse> ModifyCloudNativeAPIGatewayRouteRateLimit(ModifyCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关限流插件(路由)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayRouteRateLimitResponse"/></returns>
        public ModifyCloudNativeAPIGatewayRouteRateLimitResponse ModifyCloudNativeAPIGatewayRouteRateLimitSync(ModifyCloudNativeAPIGatewayRouteRateLimitRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayRouteRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudNativeAPIGatewayRouteRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayRouteRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceResponse"/></returns>
        public async Task<ModifyCloudNativeAPIGatewayServiceResponse> ModifyCloudNativeAPIGatewayService(ModifyCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关服务
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceResponse"/></returns>
        public ModifyCloudNativeAPIGatewayServiceResponse ModifyCloudNativeAPIGatewayServiceSync(ModifyCloudNativeAPIGatewayServiceRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudNativeAPIGatewayService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public async Task<ModifyCloudNativeAPIGatewayServiceRateLimitResponse> ModifyCloudNativeAPIGatewayServiceRateLimit(ModifyCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生网关限流插件(服务)
        /// </summary>
        /// <param name="req"><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitRequest"/></param>
        /// <returns><see cref="ModifyCloudNativeAPIGatewayServiceRateLimitResponse"/></returns>
        public ModifyCloudNativeAPIGatewayServiceRateLimitResponse ModifyCloudNativeAPIGatewayServiceRateLimitSync(ModifyCloudNativeAPIGatewayServiceRateLimitRequest req)
        {
             JsonResponseModel<ModifyCloudNativeAPIGatewayServiceRateLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCloudNativeAPIGatewayServiceRateLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCloudNativeAPIGatewayServiceRateLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生API网关实例分组基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServerGroupResponse"/></returns>
        public async Task<ModifyNativeGatewayServerGroupResponse> ModifyNativeGatewayServerGroup(ModifyNativeGatewayServerGroupRequest req)
        {
             JsonResponseModel<ModifyNativeGatewayServerGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNativeGatewayServerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNativeGatewayServerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生API网关实例分组基础信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNativeGatewayServerGroupRequest"/></param>
        /// <returns><see cref="ModifyNativeGatewayServerGroupResponse"/></returns>
        public ModifyNativeGatewayServerGroupResponse ModifyNativeGatewayServerGroupSync(ModifyNativeGatewayServerGroupRequest req)
        {
             JsonResponseModel<ModifyNativeGatewayServerGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNativeGatewayServerGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNativeGatewayServerGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生API网关实例的节点规格信息，比如节点扩缩容或者升降配
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewaySpecRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewaySpecResponse"/></returns>
        public async Task<UpdateCloudNativeAPIGatewaySpecResponse> UpdateCloudNativeAPIGatewaySpec(UpdateCloudNativeAPIGatewaySpecRequest req)
        {
             JsonResponseModel<UpdateCloudNativeAPIGatewaySpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCloudNativeAPIGatewaySpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCloudNativeAPIGatewaySpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云原生API网关实例的节点规格信息，比如节点扩缩容或者升降配
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudNativeAPIGatewaySpecRequest"/></param>
        /// <returns><see cref="UpdateCloudNativeAPIGatewaySpecResponse"/></returns>
        public UpdateCloudNativeAPIGatewaySpecResponse UpdateCloudNativeAPIGatewaySpecSync(UpdateCloudNativeAPIGatewaySpecRequest req)
        {
             JsonResponseModel<UpdateCloudNativeAPIGatewaySpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCloudNativeAPIGatewaySpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCloudNativeAPIGatewaySpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改引擎公网访问配置
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineInternetAccessRequest"/></param>
        /// <returns><see cref="UpdateEngineInternetAccessResponse"/></returns>
        public async Task<UpdateEngineInternetAccessResponse> UpdateEngineInternetAccess(UpdateEngineInternetAccessRequest req)
        {
             JsonResponseModel<UpdateEngineInternetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEngineInternetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEngineInternetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改引擎公网访问配置
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineInternetAccessRequest"/></param>
        /// <returns><see cref="UpdateEngineInternetAccessResponse"/></returns>
        public UpdateEngineInternetAccessResponse UpdateEngineInternetAccessSync(UpdateEngineInternetAccessRequest req)
        {
             JsonResponseModel<UpdateEngineInternetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEngineInternetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEngineInternetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
