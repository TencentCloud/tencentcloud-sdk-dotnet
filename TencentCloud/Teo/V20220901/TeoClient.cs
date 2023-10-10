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
        /// 校验域名 CNAME 状态
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public async Task<CheckCnameStatusResponse> CheckCnameStatus(CheckCnameStatusRequest req)
        {
             JsonResponseModel<CheckCnameStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckCnameStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCnameStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验域名 CNAME 状态
        /// </summary>
        /// <param name="req"><see cref="CheckCnameStatusRequest"/></param>
        /// <returns><see cref="CheckCnameStatusResponse"/></returns>
        public CheckCnameStatusResponse CheckCnameStatusSync(CheckCnameStatusRequest req)
        {
             JsonResponseModel<CheckCnameStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckCnameStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckCnameStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在创建完站点之后，您可以通过本接口创建加速域名。 
        /// 
        /// CNAME 模式接入时，若您未完成站点归属权校验，本接口将为您返回域名归属权验证信息，您可以单独对域名进行归属权验证，详情参考 [站点/域名归属权验证](https://cloud.tencent.com/document/product/1552/70789)。
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerationDomainRequest"/></param>
        /// <returns><see cref="CreateAccelerationDomainResponse"/></returns>
        public async Task<CreateAccelerationDomainResponse> CreateAccelerationDomain(CreateAccelerationDomainRequest req)
        {
             JsonResponseModel<CreateAccelerationDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccelerationDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccelerationDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateAccelerationDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccelerationDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccelerationDomainResponse>>(strResp);
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
        /// 当源站资源更新，但节点缓存 TTL 未过期时，用户仍会访问到旧的资源，此时可以通过该接口实现节点资源更新。触发更新的方法有以下两种：<li>直接删除：不做任何校验，直接删除节点缓存，用户请求时触发回源拉取；</li><li>标记过期：将节点资源置为过期，用户请求时触发回源校验，即发送带有 If-None-Match 和 If-Modified-Since 头部的 HTTP 条件请求。若源站响应 200，则节点会回源拉取新的资源并更新缓存；若源站响应 304，则节点不会更新缓存；</li>
        /// 
        /// 清除缓存任务详情请查看[清除缓存](https://cloud.tencent.com/document/product/1552/70759)。
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
        /// 当源站资源更新，但节点缓存 TTL 未过期时，用户仍会访问到旧的资源，此时可以通过该接口实现节点资源更新。触发更新的方法有以下两种：<li>直接删除：不做任何校验，直接删除节点缓存，用户请求时触发回源拉取；</li><li>标记过期：将节点资源置为过期，用户请求时触发回源校验，即发送带有 If-None-Match 和 If-Modified-Since 头部的 HTTP 条件请求。若源站响应 200，则节点会回源拉取新的资源并更新缓存；若源站响应 304，则节点不会更新缓存；</li>
        /// 
        /// 清除缓存任务详情请查看[清除缓存](https://cloud.tencent.com/document/product/1552/70759)。
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
        /// 创建安全 IP 组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public async Task<CreateSecurityIPGroupResponse> CreateSecurityIPGroup(CreateSecurityIPGroupRequest req)
        {
             JsonResponseModel<CreateSecurityIPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityIPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityIPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全 IP 组
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityIPGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityIPGroupResponse"/></returns>
        public CreateSecurityIPGroupResponse CreateSecurityIPGroupSync(CreateSecurityIPGroupRequest req)
        {
             JsonResponseModel<CreateSecurityIPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityIPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityIPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建共享 CNAME
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public async Task<CreateSharedCNAMEResponse> CreateSharedCNAME(CreateSharedCNAMERequest req)
        {
             JsonResponseModel<CreateSharedCNAMEResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSharedCNAME");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSharedCNAMEResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建共享 CNAME
        /// </summary>
        /// <param name="req"><see cref="CreateSharedCNAMERequest"/></param>
        /// <returns><see cref="CreateSharedCNAMEResponse"/></returns>
        public CreateSharedCNAMEResponse CreateSharedCNAMESync(CreateSharedCNAMERequest req)
        {
             JsonResponseModel<CreateSharedCNAMEResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSharedCNAME");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSharedCNAMEResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EdgeOne 为您提供 CNAME、NS 和无域名接入三种接入方式，您需要先通过此接口完成站点创建。CNAME 和 NS 接入站点的场景可参考 [从零开始快速接入 EdgeOne](https://cloud.tencent.com/document/product/1552/87601); 无域名接入的场景可参考 [快速启用四层代理服务](https://cloud.tencent.com/document/product/1552/96051)。
        /// 
        /// > 建议您在账号下已存在套餐时调用本接口创建站点，请在入参时传入 PlanId ，直接将站点绑定至该套餐；不传入 PlanId 时，创建出来的站点会处于未激活状态，无法正常服务，您需要通过 [BindZoneToPlan](https://cloud.tencent.com/document/product/1552/83042) 完成套餐绑定之后，站点才可正常提供服务 。若您当前没有可绑定的套餐时，请前往控制台购买套餐完成站点创建。
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
        /// EdgeOne 为您提供 CNAME、NS 和无域名接入三种接入方式，您需要先通过此接口完成站点创建。CNAME 和 NS 接入站点的场景可参考 [从零开始快速接入 EdgeOne](https://cloud.tencent.com/document/product/1552/87601); 无域名接入的场景可参考 [快速启用四层代理服务](https://cloud.tencent.com/document/product/1552/96051)。
        /// 
        /// > 建议您在账号下已存在套餐时调用本接口创建站点，请在入参时传入 PlanId ，直接将站点绑定至该套餐；不传入 PlanId 时，创建出来的站点会处于未激活状态，无法正常服务，您需要通过 [BindZoneToPlan](https://cloud.tencent.com/document/product/1552/83042) 完成套餐绑定之后，站点才可正常提供服务 。若您当前没有可绑定的套餐时，请前往控制台购买套餐完成站点创建。
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
        /// 批量删除加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public async Task<DeleteAccelerationDomainsResponse> DeleteAccelerationDomains(DeleteAccelerationDomainsRequest req)
        {
             JsonResponseModel<DeleteAccelerationDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccelerationDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccelerationDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除加速域名
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DeleteAccelerationDomainsResponse"/></returns>
        public DeleteAccelerationDomainsResponse DeleteAccelerationDomainsSync(DeleteAccelerationDomainsRequest req)
        {
             JsonResponseModel<DeleteAccelerationDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccelerationDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccelerationDomainsResponse>>(strResp);
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
        /// 删除指定 IP 组，如果有规则引用了 IP 组情况，则不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public async Task<DeleteSecurityIPGroupResponse> DeleteSecurityIPGroup(DeleteSecurityIPGroupRequest req)
        {
             JsonResponseModel<DeleteSecurityIPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityIPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityIPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定 IP 组，如果有规则引用了 IP 组情况，则不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityIPGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityIPGroupResponse"/></returns>
        public DeleteSecurityIPGroupResponse DeleteSecurityIPGroupSync(DeleteSecurityIPGroupRequest req)
        {
             JsonResponseModel<DeleteSecurityIPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityIPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityIPGroupResponse>>(strResp);
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
        /// 您可以通过本接口查看站点下的域名信息，包括加速域名、源站以及域名状态等信息。您可以查看站点下全部域名的信息，也可以指定过滤条件查询对应的域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public async Task<DescribeAccelerationDomainsResponse> DescribeAccelerationDomains(DescribeAccelerationDomainsRequest req)
        {
             JsonResponseModel<DescribeAccelerationDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccelerationDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccelerationDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 您可以通过本接口查看站点下的域名信息，包括加速域名、源站以及域名状态等信息。您可以查看站点下全部域名的信息，也可以指定过滤条件查询对应的域名信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerationDomainsRequest"/></param>
        /// <returns><see cref="DescribeAccelerationDomainsResponse"/></returns>
        public DescribeAccelerationDomainsResponse DescribeAccelerationDomainsSync(DescribeAccelerationDomainsRequest req)
        {
             JsonResponseModel<DescribeAccelerationDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccelerationDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccelerationDomainsResponse>>(strResp);
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
        /// 本接口（DescribeDDoSAttackData）用于查询DDoS攻击时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public async Task<DescribeDDoSAttackDataResponse> DescribeDDoSAttackData(DescribeDDoSAttackDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackData）用于查询DDoS攻击时序数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackDataRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackDataResponse"/></returns>
        public DescribeDDoSAttackDataResponse DescribeDDoSAttackDataSync(DescribeDDoSAttackDataRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackEvent）用于查询DDoS攻击事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public async Task<DescribeDDoSAttackEventResponse> DescribeDDoSAttackEvent(DescribeDDoSAttackEventRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDDoSAttackEvent）用于查询DDoS攻击事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackEventRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackEventResponse"/></returns>
        public DescribeDDoSAttackEventResponse DescribeDDoSAttackEventSync(DescribeDDoSAttackEventRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackEventResponse>>(strResp);
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
        /// 该接口用于查询您有权限的站点信息。可根据不同查询条件筛选站点。
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
        /// 该接口用于查询您有权限的站点信息。可根据不同查询条件筛选站点。
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
        /// 修改加速域名信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public async Task<ModifyAccelerationDomainResponse> ModifyAccelerationDomain(ModifyAccelerationDomainRequest req)
        {
             JsonResponseModel<ModifyAccelerationDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccelerationDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccelerationDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改加速域名信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainResponse"/></returns>
        public ModifyAccelerationDomainResponse ModifyAccelerationDomainSync(ModifyAccelerationDomainRequest req)
        {
             JsonResponseModel<ModifyAccelerationDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccelerationDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccelerationDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改加速域名状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public async Task<ModifyAccelerationDomainStatusesResponse> ModifyAccelerationDomainStatuses(ModifyAccelerationDomainStatusesRequest req)
        {
             JsonResponseModel<ModifyAccelerationDomainStatusesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccelerationDomainStatuses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccelerationDomainStatusesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改加速域名状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerationDomainStatusesRequest"/></param>
        /// <returns><see cref="ModifyAccelerationDomainStatusesResponse"/></returns>
        public ModifyAccelerationDomainStatusesResponse ModifyAccelerationDomainStatusesSync(ModifyAccelerationDomainStatusesRequest req)
        {
             JsonResponseModel<ModifyAccelerationDomainStatusesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccelerationDomainStatuses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccelerationDomainStatusesResponse>>(strResp);
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
        /// 完成域名创建之后，您可以为域名配置自有证书，也可以使用 EdgeOne 为您提供的 [免费证书](https://cloud.tencent.com/document/product/1552/90437)。
        /// 如果您需要配置自有证书，请先将证书上传至 [SSL证书控制台](https://console.cloud.tencent.com/certoverview)，然后在本接口中传入对应的证书 ID。详情参考 [部署自有证书至 EdgeOne 域名
        /// ](https://cloud.tencent.com/document/product/1552/88874)。
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
        /// 完成域名创建之后，您可以为域名配置自有证书，也可以使用 EdgeOne 为您提供的 [免费证书](https://cloud.tencent.com/document/product/1552/90437)。
        /// 如果您需要配置自有证书，请先将证书上传至 [SSL证书控制台](https://console.cloud.tencent.com/certoverview)，然后在本接口中传入对应的证书 ID。详情参考 [部署自有证书至 EdgeOne 域名
        /// ](https://cloud.tencent.com/document/product/1552/88874)。
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
        /// 修改安全 IP 组。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public async Task<ModifySecurityIPGroupResponse> ModifySecurityIPGroup(ModifySecurityIPGroupRequest req)
        {
             JsonResponseModel<ModifySecurityIPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityIPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityIPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全 IP 组。
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityIPGroupRequest"/></param>
        /// <returns><see cref="ModifySecurityIPGroupResponse"/></returns>
        public ModifySecurityIPGroupResponse ModifySecurityIPGroupSync(ModifySecurityIPGroupRequest req)
        {
             JsonResponseModel<ModifySecurityIPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityIPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityIPGroupResponse>>(strResp);
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
        /// 在 CNAME 接入模式下，您需要对站点或者域名的归属权进行验证，可以通过本接口触发验证。若站点通过归属权验证后，后续添加域名无需再验证。详情参考 [站点/域名归属权验证](https://cloud.tencent.com/document/product/1552/70789)。
        /// 
        /// 在 NS 接入模式下，您也可以通过本接口来查询 NS 服务器是否切换成功，详情参考 [修改 DNS 服务器](https://cloud.tencent.com/document/product/1552/90452)。
        /// </summary>
        /// <param name="req"><see cref="VerifyOwnershipRequest"/></param>
        /// <returns><see cref="VerifyOwnershipResponse"/></returns>
        public async Task<VerifyOwnershipResponse> VerifyOwnership(VerifyOwnershipRequest req)
        {
             JsonResponseModel<VerifyOwnershipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyOwnership");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyOwnershipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<VerifyOwnershipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyOwnership");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyOwnershipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
