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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TeoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 将未绑定套餐的站点绑定到已有套餐
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public async Task<BindZoneToPlanResponse> BindZoneToPlan(BindZoneToPlanRequest req)
        {
             JsonResponseModel<BindZoneToPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindZoneToPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindZoneToPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将未绑定套餐的站点绑定到已有套餐
        /// </summary>
        /// <param name="req"><see cref="BindZoneToPlanRequest"/></param>
        /// <returns><see cref="BindZoneToPlanResponse"/></returns>
        public BindZoneToPlanResponse BindZoneToPlanSync(BindZoneToPlanRequest req)
        {
             JsonResponseModel<BindZoneToPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindZoneToPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindZoneToPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验证书
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateRequest"/></param>
        /// <returns><see cref="CheckCertificateResponse"/></returns>
        public async Task<CheckCertificateResponse> CheckCertificate(CheckCertificateRequest req)
        {
             JsonResponseModel<CheckCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验证书
        /// </summary>
        /// <param name="req"><see cref="CheckCertificateRequest"/></param>
        /// <returns><see cref="CheckCertificateResponse"/></returns>
        public CheckCertificateResponse CheckCertificateSync(CheckCertificateRequest req)
        {
             JsonResponseModel<CheckCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建别称域名。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public async Task<CreateAliasDomainResponse> CreateAliasDomain(CreateAliasDomainRequest req)
        {
             JsonResponseModel<CreateAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建别称域名。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasDomainRequest"/></param>
        /// <returns><see cref="CreateAliasDomainResponse"/></returns>
        public CreateAliasDomainResponse CreateAliasDomainSync(CreateAliasDomainRequest req)
        {
             JsonResponseModel<CreateAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用代理
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public async Task<CreateApplicationProxyResponse> CreateApplicationProxy(CreateApplicationProxyRequest req)
        {
             JsonResponseModel<CreateApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用代理
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyResponse"/></returns>
        public CreateApplicationProxyResponse CreateApplicationProxySync(CreateApplicationProxyRequest req)
        {
             JsonResponseModel<CreateApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用代理规则
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public async Task<CreateApplicationProxyRuleResponse> CreateApplicationProxyRule(CreateApplicationProxyRuleRequest req)
        {
             JsonResponseModel<CreateApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应用代理规则
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRuleResponse"/></returns>
        public CreateApplicationProxyRuleResponse CreateApplicationProxyRuleSync(CreateApplicationProxyRuleRequest req)
        {
             JsonResponseModel<CreateApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建COS回源私有凭证
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public async Task<CreateCredentialResponse> CreateCredential(CreateCredentialRequest req)
        {
             JsonResponseModel<CreateCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建COS回源私有凭证
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public CreateCredentialResponse CreateCredentialSync(CreateCredentialRequest req)
        {
             JsonResponseModel<CreateCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建源站组
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public async Task<CreateOriginGroupResponse> CreateOriginGroup(CreateOriginGroupRequest req)
        {
             JsonResponseModel<CreateOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建源站组
        /// </summary>
        /// <param name="req"><see cref="CreateOriginGroupRequest"/></param>
        /// <returns><see cref="CreateOriginGroupResponse"/></returns>
        public CreateOriginGroupResponse CreateOriginGroupSync(CreateOriginGroupRequest req)
        {
             JsonResponseModel<CreateOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为未购买套餐的站点购买套餐
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public async Task<CreatePlanForZoneResponse> CreatePlanForZone(CreatePlanForZoneRequest req)
        {
             JsonResponseModel<CreatePlanForZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePlanForZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePlanForZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为未购买套餐的站点购买套餐
        /// </summary>
        /// <param name="req"><see cref="CreatePlanForZoneRequest"/></param>
        /// <returns><see cref="CreatePlanForZoneResponse"/></returns>
        public CreatePlanForZoneResponse CreatePlanForZoneSync(CreatePlanForZoneRequest req)
        {
             JsonResponseModel<CreatePlanForZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePlanForZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePlanForZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public async Task<CreatePrefetchTaskResponse> CreatePrefetchTask(CreatePrefetchTaskRequest req)
        {
             JsonResponseModel<CreatePrefetchTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrefetchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrefetchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePrefetchTaskRequest"/></param>
        /// <returns><see cref="CreatePrefetchTaskResponse"/></returns>
        public CreatePrefetchTaskResponse CreatePrefetchTaskSync(CreatePrefetchTaskRequest req)
        {
             JsonResponseModel<CreatePrefetchTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrefetchTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrefetchTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建清除缓存任务
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public async Task<CreatePurgeTaskResponse> CreatePurgeTask(CreatePurgeTaskRequest req)
        {
             JsonResponseModel<CreatePurgeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePurgeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePurgeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建清除缓存任务
        /// </summary>
        /// <param name="req"><see cref="CreatePurgeTaskRequest"/></param>
        /// <returns><see cref="CreatePurgeTaskResponse"/></returns>
        public CreatePurgeTaskResponse CreatePurgeTaskSync(CreatePurgeTaskRequest req)
        {
             JsonResponseModel<CreatePurgeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePurgeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePurgeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建刷新/预热重放任务
        /// </summary>
        /// <param name="req"><see cref="CreateReplayTaskRequest"/></param>
        /// <returns><see cref="CreateReplayTaskResponse"/></returns>
        public async Task<CreateReplayTaskResponse> CreateReplayTask(CreateReplayTaskRequest req)
        {
             JsonResponseModel<CreateReplayTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReplayTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplayTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建刷新/预热重放任务
        /// </summary>
        /// <param name="req"><see cref="CreateReplayTaskRequest"/></param>
        /// <returns><see cref="CreateReplayTaskResponse"/></returns>
        public CreateReplayTaskResponse CreateReplayTaskSync(CreateReplayTaskRequest req)
        {
             JsonResponseModel<CreateReplayTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReplayTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplayTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则引擎创建规则。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
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
        /// 规则引擎创建规则。
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对用户指定的域名进行一次站点拨测
        /// </summary>
        /// <param name="req"><see cref="CreateSpeedTestingRequest"/></param>
        /// <returns><see cref="CreateSpeedTestingResponse"/></returns>
        public async Task<CreateSpeedTestingResponse> CreateSpeedTesting(CreateSpeedTestingRequest req)
        {
             JsonResponseModel<CreateSpeedTestingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSpeedTesting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSpeedTestingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对用户指定的域名进行一次站点拨测
        /// </summary>
        /// <param name="req"><see cref="CreateSpeedTestingRequest"/></param>
        /// <returns><see cref="CreateSpeedTestingResponse"/></returns>
        public CreateSpeedTestingResponse CreateSpeedTestingSync(CreateSpeedTestingRequest req)
        {
             JsonResponseModel<CreateSpeedTestingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSpeedTesting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSpeedTestingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于用户接入新的站点。
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public async Task<CreateZoneResponse> CreateZone(CreateZoneRequest req)
        {
             JsonResponseModel<CreateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于用户接入新的站点。
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public CreateZoneResponse CreateZoneSync(CreateZoneRequest req)
        {
             JsonResponseModel<CreateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除别称域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public async Task<DeleteAliasDomainResponse> DeleteAliasDomain(DeleteAliasDomainRequest req)
        {
             JsonResponseModel<DeleteAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除别称域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasDomainRequest"/></param>
        /// <returns><see cref="DeleteAliasDomainResponse"/></returns>
        public DeleteAliasDomainResponse DeleteAliasDomainSync(DeleteAliasDomainRequest req)
        {
             JsonResponseModel<DeleteAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用代理
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public async Task<DeleteApplicationProxyResponse> DeleteApplicationProxy(DeleteApplicationProxyRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用代理
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyResponse"/></returns>
        public DeleteApplicationProxyResponse DeleteApplicationProxySync(DeleteApplicationProxyRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用代理规则
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public async Task<DeleteApplicationProxyRuleResponse> DeleteApplicationProxyRule(DeleteApplicationProxyRuleRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用代理规则
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="DeleteApplicationProxyRuleResponse"/></returns>
        public DeleteApplicationProxyRuleResponse DeleteApplicationProxyRuleSync(DeleteApplicationProxyRuleRequest req)
        {
             JsonResponseModel<DeleteApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除源站组
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public async Task<DeleteOriginGroupResponse> DeleteOriginGroup(DeleteOriginGroupRequest req)
        {
             JsonResponseModel<DeleteOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除源站组
        /// </summary>
        /// <param name="req"><see cref="DeleteOriginGroupRequest"/></param>
        /// <returns><see cref="DeleteOriginGroupResponse"/></returns>
        public DeleteOriginGroupResponse DeleteOriginGroupSync(DeleteOriginGroupRequest req)
        {
             JsonResponseModel<DeleteOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public async Task<DeleteRulesResponse> DeleteRules(DeleteRulesRequest req)
        {
             JsonResponseModel<DeleteRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteRulesRequest"/></param>
        /// <returns><see cref="DeleteRulesResponse"/></returns>
        public DeleteRulesResponse DeleteRulesSync(DeleteRulesRequest req)
        {
             JsonResponseModel<DeleteRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除站点。
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public async Task<DeleteZoneResponse> DeleteZone(DeleteZoneRequest req)
        {
             JsonResponseModel<DeleteZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除站点。
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public DeleteZoneResponse DeleteZoneSync(DeleteZoneRequest req)
        {
             JsonResponseModel<DeleteZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAddableEntityList）用于查询剩余可添加的日志推送实体列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddableEntityListRequest"/></param>
        /// <returns><see cref="DescribeAddableEntityListResponse"/></returns>
        public async Task<DescribeAddableEntityListResponse> DescribeAddableEntityList(DescribeAddableEntityListRequest req)
        {
             JsonResponseModel<DescribeAddableEntityListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddableEntityList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddableEntityListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAddableEntityList）用于查询剩余可添加的日志推送实体列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAddableEntityListRequest"/></param>
        /// <returns><see cref="DescribeAddableEntityListResponse"/></returns>
        public DescribeAddableEntityListResponse DescribeAddableEntityListSync(DescribeAddableEntityListRequest req)
        {
             JsonResponseModel<DescribeAddableEntityListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddableEntityList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddableEntityListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询别称域名信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public async Task<DescribeAliasDomainsResponse> DescribeAliasDomains(DescribeAliasDomainsRequest req)
        {
             JsonResponseModel<DescribeAliasDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAliasDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAliasDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询别称域名信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasDomainsRequest"/></param>
        /// <returns><see cref="DescribeAliasDomainsResponse"/></returns>
        public DescribeAliasDomainsResponse DescribeAliasDomainsSync(DescribeAliasDomainsRequest req)
        {
             JsonResponseModel<DescribeAliasDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAliasDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAliasDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应用代理列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public async Task<DescribeApplicationProxiesResponse> DescribeApplicationProxies(DescribeApplicationProxiesRequest req)
        {
             JsonResponseModel<DescribeApplicationProxiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应用代理列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxiesRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxiesResponse"/></returns>
        public DescribeApplicationProxiesResponse DescribeApplicationProxiesSync(DescribeApplicationProxiesRequest req)
        {
             JsonResponseModel<DescribeApplicationProxiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationProxies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询当前账户可用套餐信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public async Task<DescribeAvailablePlansResponse> DescribeAvailablePlans(DescribeAvailablePlansRequest req)
        {
             JsonResponseModel<DescribeAvailablePlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailablePlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailablePlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询当前账户可用套餐信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailablePlansRequest"/></param>
        /// <returns><see cref="DescribeAvailablePlansResponse"/></returns>
        public DescribeAvailablePlansResponse DescribeAvailablePlansSync(DescribeAvailablePlansRequest req)
        {
             JsonResponseModel<DescribeAvailablePlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailablePlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailablePlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClientRuleList）用于查询封禁客户端信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientRuleListRequest"/></param>
        /// <returns><see cref="DescribeClientRuleListResponse"/></returns>
        public async Task<DescribeClientRuleListResponse> DescribeClientRuleList(DescribeClientRuleListRequest req)
        {
             JsonResponseModel<DescribeClientRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClientRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClientRuleList）用于查询封禁客户端信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientRuleListRequest"/></param>
        /// <returns><see cref="DescribeClientRuleListResponse"/></returns>
        public DescribeClientRuleListResponse DescribeClientRuleListSync(DescribeClientRuleListRequest req)
        {
             JsonResponseModel<DescribeClientRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClientRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询内容管理接口配额
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public async Task<DescribeContentQuotaResponse> DescribeContentQuota(DescribeContentQuotaRequest req)
        {
             JsonResponseModel<DescribeContentQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContentQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询内容管理接口配额
        /// </summary>
        /// <param name="req"><see cref="DescribeContentQuotaRequest"/></param>
        /// <returns><see cref="DescribeContentQuotaResponse"/></returns>
        public DescribeContentQuotaResponse DescribeContentQuotaSync(DescribeContentQuotaRequest req)
        {
             JsonResponseModel<DescribeContentQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContentQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackTopData）用于查询DDoS攻击Top数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public async Task<DescribeDDoSAttackTopDataResponse> DescribeDDoSAttackTopData(DescribeDDoSAttackTopDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackTopData）用于查询DDoS攻击Top数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackTopDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackTopDataResponse"/></returns>
        public DescribeDDoSAttackTopDataResponse DescribeDDoSAttackTopDataSync(DescribeDDoSAttackTopDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询默认证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public async Task<DescribeDefaultCertificatesResponse> DescribeDefaultCertificates(DescribeDefaultCertificatesRequest req)
        {
             JsonResponseModel<DescribeDefaultCertificatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询默认证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultCertificatesRequest"/></param>
        /// <returns><see cref="DescribeDefaultCertificatesResponse"/></returns>
        public DescribeDefaultCertificatesResponse DescribeDefaultCertificatesSync(DescribeDefaultCertificatesRequest req)
        {
             JsonResponseModel<DescribeDefaultCertificatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DNS请求数统计曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsDataRequest"/></param>
        /// <returns><see cref="DescribeDnsDataResponse"/></returns>
        public async Task<DescribeDnsDataResponse> DescribeDnsData(DescribeDnsDataRequest req)
        {
             JsonResponseModel<DescribeDnsDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDnsData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DNS请求数统计曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsDataRequest"/></param>
        /// <returns><see cref="DescribeDnsDataResponse"/></returns>
        public DescribeDnsDataResponse DescribeDnsDataSync(DescribeDnsDataRequest req)
        {
             JsonResponseModel<DescribeDnsDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDnsData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询域名配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public async Task<DescribeHostsSettingResponse> DescribeHostsSetting(DescribeHostsSettingRequest req)
        {
             JsonResponseModel<DescribeHostsSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询域名配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsSettingRequest"/></param>
        /// <returns><see cref="DescribeHostsSettingResponse"/></returns>
        public DescribeHostsSettingResponse DescribeHostsSettingSync(DescribeHostsSettingRequest req)
        {
             JsonResponseModel<DescribeHostsSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点的验证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public async Task<DescribeIdentificationsResponse> DescribeIdentifications(DescribeIdentificationsRequest req)
        {
             JsonResponseModel<DescribeIdentificationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIdentifications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdentificationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点的验证信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationsRequest"/></param>
        /// <returns><see cref="DescribeIdentificationsResponse"/></returns>
        public DescribeIdentificationsResponse DescribeIdentificationsSync(DescribeIdentificationsRequest req)
        {
             JsonResponseModel<DescribeIdentificationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIdentifications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdentificationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogSets）用于获取日志集列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSetsRequest"/></param>
        /// <returns><see cref="DescribeLogSetsResponse"/></returns>
        public async Task<DescribeLogSetsResponse> DescribeLogSets(DescribeLogSetsRequest req)
        {
             JsonResponseModel<DescribeLogSetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogSets）用于获取日志集列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSetsRequest"/></param>
        /// <returns><see cref="DescribeLogSetsResponse"/></returns>
        public DescribeLogSetsResponse DescribeLogSetsSync(DescribeLogSetsRequest req)
        {
             JsonResponseModel<DescribeLogSetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogTopicTasks）用于获取日志推送任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTopicTasksRequest"/></param>
        /// <returns><see cref="DescribeLogTopicTasksResponse"/></returns>
        public async Task<DescribeLogTopicTasksResponse> DescribeLogTopicTasks(DescribeLogTopicTasksRequest req)
        {
             JsonResponseModel<DescribeLogTopicTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogTopicTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTopicTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogTopicTasks）用于获取日志推送任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTopicTasksRequest"/></param>
        /// <returns><see cref="DescribeLogTopicTasksResponse"/></returns>
        public DescribeLogTopicTasksResponse DescribeLogTopicTasksSync(DescribeLogTopicTasksRequest req)
        {
             JsonResponseModel<DescribeLogTopicTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogTopicTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTopicTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取源站组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public async Task<DescribeOriginGroupResponse> DescribeOriginGroup(DescribeOriginGroupRequest req)
        {
             JsonResponseModel<DescribeOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取源站组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupResponse"/></returns>
        public DescribeOriginGroupResponse DescribeOriginGroupSync(DescribeOriginGroupRequest req)
        {
             JsonResponseModel<DescribeOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询源站防护信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public async Task<DescribeOriginProtectionResponse> DescribeOriginProtection(DescribeOriginProtectionRequest req)
        {
             JsonResponseModel<DescribeOriginProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOriginProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询源站防护信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginProtectionRequest"/></param>
        /// <returns><see cref="DescribeOriginProtectionResponse"/></returns>
        public DescribeOriginProtectionResponse DescribeOriginProtectionSync(DescribeOriginProtectionRequest req)
        {
             JsonResponseModel<DescribeOriginProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOriginProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOverviewL7Data）用于查询七层监控类时序流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public async Task<DescribeOverviewL7DataResponse> DescribeOverviewL7Data(DescribeOverviewL7DataRequest req)
        {
             JsonResponseModel<DescribeOverviewL7DataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewL7Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewL7DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOverviewL7Data）用于查询七层监控类时序流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewL7DataRequest"/></param>
        /// <returns><see cref="DescribeOverviewL7DataResponse"/></returns>
        public DescribeOverviewL7DataResponse DescribeOverviewL7DataSync(DescribeOverviewL7DataRequest req)
        {
             JsonResponseModel<DescribeOverviewL7DataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewL7Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewL7DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询预热任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public async Task<DescribePrefetchTasksResponse> DescribePrefetchTasks(DescribePrefetchTasksRequest req)
        {
             JsonResponseModel<DescribePrefetchTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrefetchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrefetchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询预热任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrefetchTasksRequest"/></param>
        /// <returns><see cref="DescribePrefetchTasksResponse"/></returns>
        public DescribePrefetchTasksResponse DescribePrefetchTasksSync(DescribePrefetchTasksRequest req)
        {
             JsonResponseModel<DescribePrefetchTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrefetchTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrefetchTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询清除缓存历史记录
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public async Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询清除缓存历史记录
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public async Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回规则引擎可应用匹配请求的设置列表及其详细建议配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public async Task<DescribeRulesSettingResponse> DescribeRulesSetting(DescribeRulesSettingRequest req)
        {
             JsonResponseModel<DescribeRulesSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRulesSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回规则引擎可应用匹配请求的设置列表及其详细建议配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesSettingRequest"/></param>
        /// <returns><see cref="DescribeRulesSettingResponse"/></returns>
        public DescribeRulesSettingResponse DescribeRulesSettingSync(DescribeRulesSettingRequest req)
        {
             JsonResponseModel<DescribeRulesSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRulesSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSingleL7AnalysisData）用于查询七层流量数据分析单值数据列表，单值数据表示：指标在查询时间范围内的单个统计数据，通常表现为接口仅返回一个统计数值。
        /// </summary>
        /// <param name="req"><see cref="DescribeSingleL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeSingleL7AnalysisDataResponse"/></returns>
        public async Task<DescribeSingleL7AnalysisDataResponse> DescribeSingleL7AnalysisData(DescribeSingleL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeSingleL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSingleL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSingleL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSingleL7AnalysisData）用于查询七层流量数据分析单值数据列表，单值数据表示：指标在查询时间范围内的单个统计数据，通常表现为接口仅返回一个统计数值。
        /// </summary>
        /// <param name="req"><see cref="DescribeSingleL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeSingleL7AnalysisDataResponse"/></returns>
        public DescribeSingleL7AnalysisDataResponse DescribeSingleL7AnalysisDataSync(DescribeSingleL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeSingleL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSingleL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSingleL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询拨测分地区数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingDetailsRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingDetailsResponse"/></returns>
        public async Task<DescribeSpeedTestingDetailsResponse> DescribeSpeedTestingDetails(DescribeSpeedTestingDetailsRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpeedTestingDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询拨测分地区数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingDetailsRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingDetailsResponse"/></returns>
        public DescribeSpeedTestingDetailsResponse DescribeSpeedTestingDetailsSync(DescribeSpeedTestingDetailsRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpeedTestingDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点拨测结果
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingMetricDataRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingMetricDataResponse"/></returns>
        public async Task<DescribeSpeedTestingMetricDataResponse> DescribeSpeedTestingMetricData(DescribeSpeedTestingMetricDataRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingMetricDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpeedTestingMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点拨测结果
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingMetricDataRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingMetricDataResponse"/></returns>
        public DescribeSpeedTestingMetricDataResponse DescribeSpeedTestingMetricDataSync(DescribeSpeedTestingMetricDataRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingMetricDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpeedTestingMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点拨测配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingQuotaRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingQuotaResponse"/></returns>
        public async Task<DescribeSpeedTestingQuotaResponse> DescribeSpeedTestingQuota(DescribeSpeedTestingQuotaRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpeedTestingQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询站点拨测配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSpeedTestingQuotaRequest"/></param>
        /// <returns><see cref="DescribeSpeedTestingQuotaResponse"/></returns>
        public DescribeSpeedTestingQuotaResponse DescribeSpeedTestingQuotaSync(DescribeSpeedTestingQuotaRequest req)
        {
             JsonResponseModel<DescribeSpeedTestingQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpeedTestingQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpeedTestingQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTimingL4Data）用于查询四层时序流量数据列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public async Task<DescribeTimingL4DataResponse> DescribeTimingL4Data(DescribeTimingL4DataRequest req)
        {
             JsonResponseModel<DescribeTimingL4DataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimingL4Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL4DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTimingL4Data）用于查询四层时序流量数据列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL4DataRequest"/></param>
        /// <returns><see cref="DescribeTimingL4DataResponse"/></returns>
        public DescribeTimingL4DataResponse DescribeTimingL4DataSync(DescribeTimingL4DataRequest req)
        {
             JsonResponseModel<DescribeTimingL4DataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimingL4Data");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL4DataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTimingL7AnalysisData）查询七层数据分析类时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public async Task<DescribeTimingL7AnalysisDataResponse> DescribeTimingL7AnalysisData(DescribeTimingL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimingL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTimingL7AnalysisData）查询七层数据分析类时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7AnalysisDataResponse"/></returns>
        public DescribeTimingL7AnalysisDataResponse DescribeTimingL7AnalysisDataSync(DescribeTimingL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimingL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTimingL7CacheData）用于查询七层缓存分析时序类流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public async Task<DescribeTimingL7CacheDataResponse> DescribeTimingL7CacheData(DescribeTimingL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimingL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTimingL7CacheData）用于查询七层缓存分析时序类流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimingL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTimingL7CacheDataResponse"/></returns>
        public DescribeTimingL7CacheDataResponse DescribeTimingL7CacheDataSync(DescribeTimingL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTimingL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimingL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimingL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTopL7AnalysisData）用于查询七层流量前topN的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public async Task<DescribeTopL7AnalysisDataResponse> DescribeTopL7AnalysisData(DescribeTopL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTopL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTopL7AnalysisData）用于查询七层流量前topN的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7AnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7AnalysisDataResponse"/></returns>
        public DescribeTopL7AnalysisDataResponse DescribeTopL7AnalysisDataSync(DescribeTopL7AnalysisDataRequest req)
        {
             JsonResponseModel<DescribeTopL7AnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopL7AnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7AnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTopL7CacheData）用于查询七层缓存分析topN流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public async Task<DescribeTopL7CacheDataResponse> DescribeTopL7CacheData(DescribeTopL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTopL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTopL7CacheData）用于查询七层缓存分析topN流量数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopL7CacheDataRequest"/></param>
        /// <returns><see cref="DescribeTopL7CacheDataResponse"/></returns>
        public DescribeTopL7CacheDataResponse DescribeTopL7CacheDataSync(DescribeTopL7CacheDataRequest req)
        {
             JsonResponseModel<DescribeTopL7CacheDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopL7CacheData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopL7CacheDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebManagedRulesData）用于查询WAF攻击的时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesDataResponse"/></returns>
        public async Task<DescribeWebManagedRulesDataResponse> DescribeWebManagedRulesData(DescribeWebManagedRulesDataRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebManagedRulesData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebManagedRulesData）用于查询WAF攻击的时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesDataRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesDataResponse"/></returns>
        public DescribeWebManagedRulesDataResponse DescribeWebManagedRulesDataSync(DescribeWebManagedRulesDataRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebManagedRulesData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebManagedRulesHitRuleDetail）用于查询WAF攻击命中规则详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesHitRuleDetailResponse"/></returns>
        public async Task<DescribeWebManagedRulesHitRuleDetailResponse> DescribeWebManagedRulesHitRuleDetail(DescribeWebManagedRulesHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebManagedRulesHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebManagedRulesHitRuleDetail）用于查询WAF攻击命中规则详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesHitRuleDetailResponse"/></returns>
        public DescribeWebManagedRulesHitRuleDetailResponse DescribeWebManagedRulesHitRuleDetailSync(DescribeWebManagedRulesHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebManagedRulesHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebManagedRulesLog）用于查询Web攻击日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesLogRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesLogResponse"/></returns>
        public async Task<DescribeWebManagedRulesLogResponse> DescribeWebManagedRulesLog(DescribeWebManagedRulesLogRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebManagedRulesLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebManagedRulesLog）用于查询Web攻击日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebManagedRulesLogRequest"/></param>
        /// <returns><see cref="DescribeWebManagedRulesLogResponse"/></returns>
        public DescribeWebManagedRulesLogResponse DescribeWebManagedRulesLogSync(DescribeWebManagedRulesLogRequest req)
        {
             JsonResponseModel<DescribeWebManagedRulesLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebManagedRulesLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebManagedRulesLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionClientIpList）用于查询CC防护客户端（攻击源）IP信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionClientIpListRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionClientIpListResponse"/></returns>
        public async Task<DescribeWebProtectionClientIpListResponse> DescribeWebProtectionClientIpList(DescribeWebProtectionClientIpListRequest req)
        {
             JsonResponseModel<DescribeWebProtectionClientIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionClientIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionClientIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionClientIpList）用于查询CC防护客户端（攻击源）IP信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionClientIpListRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionClientIpListResponse"/></returns>
        public DescribeWebProtectionClientIpListResponse DescribeWebProtectionClientIpListSync(DescribeWebProtectionClientIpListRequest req)
        {
             JsonResponseModel<DescribeWebProtectionClientIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionClientIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionClientIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionData）用于查询CC防护时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionDataResponse"/></returns>
        public async Task<DescribeWebProtectionDataResponse> DescribeWebProtectionData(DescribeWebProtectionDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionData）用于查询CC防护时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionDataResponse"/></returns>
        public DescribeWebProtectionDataResponse DescribeWebProtectionDataSync(DescribeWebProtectionDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionHitRuleDetail）用于查询CC防护命中规则详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionHitRuleDetailResponse"/></returns>
        public async Task<DescribeWebProtectionHitRuleDetailResponse> DescribeWebProtectionHitRuleDetail(DescribeWebProtectionHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionHitRuleDetail）用于查询CC防护命中规则详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionHitRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionHitRuleDetailResponse"/></returns>
        public DescribeWebProtectionHitRuleDetailResponse DescribeWebProtectionHitRuleDetailSync(DescribeWebProtectionHitRuleDetailRequest req)
        {
             JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionHitRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionHitRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionTopData）用于查询CC防护的Top数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionTopDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionTopDataResponse"/></returns>
        public async Task<DescribeWebProtectionTopDataResponse> DescribeWebProtectionTopData(DescribeWebProtectionTopDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebProtectionTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeWebProtectionTopData）用于查询CC防护的Top数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWebProtectionTopDataRequest"/></param>
        /// <returns><see cref="DescribeWebProtectionTopDataResponse"/></returns>
        public DescribeWebProtectionTopDataResponse DescribeWebProtectionTopDataSync(DescribeWebProtectionTopDataRequest req)
        {
             JsonResponseModel<DescribeWebProtectionTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebProtectionTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebProtectionTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询站点的所有配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public async Task<DescribeZoneSettingResponse> DescribeZoneSetting(DescribeZoneSettingRequest req)
        {
             JsonResponseModel<DescribeZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询站点的所有配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneSettingRequest"/></param>
        /// <returns><see cref="DescribeZoneSettingResponse"/></returns>
        public DescribeZoneSettingResponse DescribeZoneSettingSync(DescribeZoneSettingRequest req)
        {
             JsonResponseModel<DescribeZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户查询用户站点信息列表，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户查询用户站点信息列表，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadL4Logs）用于下载四层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public async Task<DownloadL4LogsResponse> DownloadL4Logs(DownloadL4LogsRequest req)
        {
             JsonResponseModel<DownloadL4LogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadL4Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL4LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadL4Logs）用于下载四层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL4LogsRequest"/></param>
        /// <returns><see cref="DownloadL4LogsResponse"/></returns>
        public DownloadL4LogsResponse DownloadL4LogsSync(DownloadL4LogsRequest req)
        {
             JsonResponseModel<DownloadL4LogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadL4Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL4LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadL7Logs）下载七层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public async Task<DownloadL7LogsResponse> DownloadL7Logs(DownloadL7LogsRequest req)
        {
             JsonResponseModel<DownloadL7LogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadL7Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL7LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadL7Logs）下载七层离线日志。
        /// </summary>
        /// <param name="req"><see cref="DownloadL7LogsRequest"/></param>
        /// <returns><see cref="DownloadL7LogsResponse"/></returns>
        public DownloadL7LogsResponse DownloadL7LogsSync(DownloadL7LogsRequest req)
        {
             JsonResponseModel<DownloadL7LogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadL7Logs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadL7LogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于验证站点所有权。
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public async Task<IdentifyZoneResponse> IdentifyZone(IdentifyZoneRequest req)
        {
             JsonResponseModel<IdentifyZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IdentifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdentifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于验证站点所有权。
        /// </summary>
        /// <param name="req"><see cref="IdentifyZoneRequest"/></param>
        /// <returns><see cref="IdentifyZoneResponse"/></returns>
        public IdentifyZoneResponse IdentifyZoneSync(IdentifyZoneRequest req)
        {
             JsonResponseModel<IdentifyZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IdentifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdentifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改别称域名。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public async Task<ModifyAliasDomainResponse> ModifyAliasDomain(ModifyAliasDomainRequest req)
        {
             JsonResponseModel<ModifyAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改别称域名。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainResponse"/></returns>
        public ModifyAliasDomainResponse ModifyAliasDomainSync(ModifyAliasDomainRequest req)
        {
             JsonResponseModel<ModifyAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改别称域名状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public async Task<ModifyAliasDomainStatusResponse> ModifyAliasDomainStatus(ModifyAliasDomainStatusRequest req)
        {
             JsonResponseModel<ModifyAliasDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAliasDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改别称域名状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyAliasDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyAliasDomainStatusResponse"/></returns>
        public ModifyAliasDomainStatusResponse ModifyAliasDomainStatusSync(ModifyAliasDomainStatusRequest req)
        {
             JsonResponseModel<ModifyAliasDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAliasDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAliasDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public async Task<ModifyApplicationProxyResponse> ModifyApplicationProxy(ModifyApplicationProxyRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyResponse"/></returns>
        public ModifyApplicationProxyResponse ModifyApplicationProxySync(ModifyApplicationProxyRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理规则
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public async Task<ModifyApplicationProxyRuleResponse> ModifyApplicationProxyRule(ModifyApplicationProxyRuleRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理规则
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleResponse"/></returns>
        public ModifyApplicationProxyRuleResponse ModifyApplicationProxyRuleSync(ModifyApplicationProxyRuleRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理规则的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public async Task<ModifyApplicationProxyRuleStatusResponse> ModifyApplicationProxyRuleStatus(ModifyApplicationProxyRuleStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxyRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理规则的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyRuleStatusResponse"/></returns>
        public ModifyApplicationProxyRuleStatusResponse ModifyApplicationProxyRuleStatusSync(ModifyApplicationProxyRuleStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxyRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public async Task<ModifyApplicationProxyStatusResponse> ModifyApplicationProxyStatus(ModifyApplicationProxyStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationProxyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用代理的状态
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProxyStatusRequest"/></param>
        /// <returns><see cref="ModifyApplicationProxyStatusResponse"/></returns>
        public ModifyApplicationProxyStatusResponse ModifyApplicationProxyStatusSync(ModifyApplicationProxyStatusRequest req)
        {
             JsonResponseModel<ModifyApplicationProxyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationProxyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationProxyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改默认证书状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultCertificateRequest"/></param>
        /// <returns><see cref="ModifyDefaultCertificateResponse"/></returns>
        public async Task<ModifyDefaultCertificateResponse> ModifyDefaultCertificate(ModifyDefaultCertificateRequest req)
        {
             JsonResponseModel<ModifyDefaultCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDefaultCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改默认证书状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultCertificateRequest"/></param>
        /// <returns><see cref="ModifyDefaultCertificateResponse"/></returns>
        public ModifyDefaultCertificateResponse ModifyDefaultCertificateSync(ModifyDefaultCertificateRequest req)
        {
             JsonResponseModel<ModifyDefaultCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDefaultCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改域名证书
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public async Task<ModifyHostsCertificateResponse> ModifyHostsCertificate(ModifyHostsCertificateRequest req)
        {
             JsonResponseModel<ModifyHostsCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHostsCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改域名证书
        /// </summary>
        /// <param name="req"><see cref="ModifyHostsCertificateRequest"/></param>
        /// <returns><see cref="ModifyHostsCertificateResponse"/></returns>
        public ModifyHostsCertificateResponse ModifyHostsCertificateSync(ModifyHostsCertificateRequest req)
        {
             JsonResponseModel<ModifyHostsCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHostsCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostsCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改源站组
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public async Task<ModifyOriginGroupResponse> ModifyOriginGroup(ModifyOriginGroupRequest req)
        {
             JsonResponseModel<ModifyOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改源站组
        /// </summary>
        /// <param name="req"><see cref="ModifyOriginGroupRequest"/></param>
        /// <returns><see cref="ModifyOriginGroupResponse"/></returns>
        public ModifyOriginGroupResponse ModifyOriginGroupSync(ModifyOriginGroupRequest req)
        {
             JsonResponseModel<ModifyOriginGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyOriginGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOriginGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
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
        /// 修改规则引擎规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则引擎规则优先级
        /// </summary>
        /// <param name="req"><see cref="ModifyRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyRulePriorityResponse"/></returns>
        public async Task<ModifyRulePriorityResponse> ModifyRulePriority(ModifyRulePriorityRequest req)
        {
             JsonResponseModel<ModifyRulePriorityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRulePriority");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRulePriorityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则引擎规则优先级
        /// </summary>
        /// <param name="req"><see cref="ModifyRulePriorityRequest"/></param>
        /// <returns><see cref="ModifyRulePriorityResponse"/></returns>
        public ModifyRulePriorityResponse ModifyRulePrioritySync(ModifyRulePriorityRequest req)
        {
             JsonResponseModel<ModifyRulePriorityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRulePriority");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRulePriorityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Web&Bot安全配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public async Task<ModifySecurityPolicyResponse> ModifySecurityPolicy(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Web&Bot安全配置。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityPolicyResponse"/></returns>
        public ModifySecurityPolicyResponse ModifySecurityPolicySync(ModifySecurityPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全配置托管规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityWafGroupPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityWafGroupPolicyResponse"/></returns>
        public async Task<ModifySecurityWafGroupPolicyResponse> ModifySecurityWafGroupPolicy(ModifySecurityWafGroupPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityWafGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityWafGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityWafGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全配置托管规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityWafGroupPolicyRequest"/></param>
        /// <returns><see cref="ModifySecurityWafGroupPolicyResponse"/></returns>
        public ModifySecurityWafGroupPolicyResponse ModifySecurityWafGroupPolicySync(ModifySecurityWafGroupPolicyRequest req)
        {
             JsonResponseModel<ModifySecurityWafGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityWafGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityWafGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改站点信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public async Task<ModifyZoneResponse> ModifyZone(ModifyZoneRequest req)
        {
             JsonResponseModel<ModifyZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改站点信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneRequest"/></param>
        /// <returns><see cref="ModifyZoneResponse"/></returns>
        public ModifyZoneResponse ModifyZoneSync(ModifyZoneRequest req)
        {
             JsonResponseModel<ModifyZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改站点配置
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public async Task<ModifyZoneSettingResponse> ModifyZoneSetting(ModifyZoneSettingRequest req)
        {
             JsonResponseModel<ModifyZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改站点配置
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneSettingRequest"/></param>
        /// <returns><see cref="ModifyZoneSettingResponse"/></returns>
        public ModifyZoneSettingResponse ModifyZoneSettingSync(ModifyZoneSettingRequest req)
        {
             JsonResponseModel<ModifyZoneSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZoneSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于开启，关闭站点。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public async Task<ModifyZoneStatusResponse> ModifyZoneStatus(ModifyZoneStatusRequest req)
        {
             JsonResponseModel<ModifyZoneStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZoneStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于开启，关闭站点。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneStatusRequest"/></param>
        /// <returns><see cref="ModifyZoneStatusResponse"/></returns>
        public ModifyZoneStatusResponse ModifyZoneStatusSync(ModifyZoneStatusRequest req)
        {
             JsonResponseModel<ModifyZoneStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZoneStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当客户取回站定的同时会取回此站点下关联的别称域名，此时入参为ZoneId；当客户接入站点发现已被别称域名接入时通过验证之后可取回域名，此时入参为ZoneName。
        /// </summary>
        /// <param name="req"><see cref="ReclaimAliasDomainRequest"/></param>
        /// <returns><see cref="ReclaimAliasDomainResponse"/></returns>
        public async Task<ReclaimAliasDomainResponse> ReclaimAliasDomain(ReclaimAliasDomainRequest req)
        {
             JsonResponseModel<ReclaimAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReclaimAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当客户取回站定的同时会取回此站点下关联的别称域名，此时入参为ZoneId；当客户接入站点发现已被别称域名接入时通过验证之后可取回域名，此时入参为ZoneName。
        /// </summary>
        /// <param name="req"><see cref="ReclaimAliasDomainRequest"/></param>
        /// <returns><see cref="ReclaimAliasDomainResponse"/></returns>
        public ReclaimAliasDomainResponse ReclaimAliasDomainSync(ReclaimAliasDomainRequest req)
        {
             JsonResponseModel<ReclaimAliasDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReclaimAliasDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimAliasDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 站点被其他用户接入后，验证了站点所有权之后，可以找回该站点。
        /// </summary>
        /// <param name="req"><see cref="ReclaimZoneRequest"/></param>
        /// <returns><see cref="ReclaimZoneResponse"/></returns>
        public async Task<ReclaimZoneResponse> ReclaimZone(ReclaimZoneRequest req)
        {
             JsonResponseModel<ReclaimZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReclaimZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 站点被其他用户接入后，验证了站点所有权之后，可以找回该站点。
        /// </summary>
        /// <param name="req"><see cref="ReclaimZoneRequest"/></param>
        /// <returns><see cref="ReclaimZoneResponse"/></returns>
        public ReclaimZoneResponse ReclaimZoneSync(ReclaimZoneRequest req)
        {
             JsonResponseModel<ReclaimZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReclaimZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReclaimZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新源站防护IP白名单
        /// </summary>
        /// <param name="req"><see cref="UpdateOriginProtectionIPWhitelistRequest"/></param>
        /// <returns><see cref="UpdateOriginProtectionIPWhitelistResponse"/></returns>
        public async Task<UpdateOriginProtectionIPWhitelistResponse> UpdateOriginProtectionIPWhitelist(UpdateOriginProtectionIPWhitelistRequest req)
        {
             JsonResponseModel<UpdateOriginProtectionIPWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOriginProtectionIPWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOriginProtectionIPWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新源站防护IP白名单
        /// </summary>
        /// <param name="req"><see cref="UpdateOriginProtectionIPWhitelistRequest"/></param>
        /// <returns><see cref="UpdateOriginProtectionIPWhitelistResponse"/></returns>
        public UpdateOriginProtectionIPWhitelistResponse UpdateOriginProtectionIPWhitelistSync(UpdateOriginProtectionIPWhitelistRequest req)
        {
             JsonResponseModel<UpdateOriginProtectionIPWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateOriginProtectionIPWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOriginProtectionIPWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
