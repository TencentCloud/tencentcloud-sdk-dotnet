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

namespace TencentCloud.Teo.V20220106
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Teo.V20220106.Models;

   public class TeoClient : AbstractClient{

       private const string endpoint = "teo.tencentcloudapi.com";
       private const string version = "2022-01-06";

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
        /// 批量创建应用代理规则
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRulesRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRulesResponse"/></returns>
        public async Task<CreateApplicationProxyRulesResponse> CreateApplicationProxyRules(CreateApplicationProxyRulesRequest req)
        {
             JsonResponseModel<CreateApplicationProxyRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationProxyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量创建应用代理规则
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProxyRulesRequest"/></param>
        /// <returns><see cref="CreateApplicationProxyRulesResponse"/></returns>
        public CreateApplicationProxyRulesResponse CreateApplicationProxyRulesSync(CreateApplicationProxyRulesRequest req)
        {
             JsonResponseModel<CreateApplicationProxyRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationProxyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationProxyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义规则的自定义页
        /// </summary>
        /// <param name="req"><see cref="CreateCustomErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomErrorPageResponse"/></returns>
        public async Task<CreateCustomErrorPageResponse> CreateCustomErrorPage(CreateCustomErrorPageRequest req)
        {
             JsonResponseModel<CreateCustomErrorPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomErrorPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomErrorPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义规则的自定义页
        /// </summary>
        /// <param name="req"><see cref="CreateCustomErrorPageRequest"/></param>
        /// <returns><see cref="CreateCustomErrorPageResponse"/></returns>
        public CreateCustomErrorPageResponse CreateCustomErrorPageSync(CreateCustomErrorPageRequest req)
        {
             JsonResponseModel<CreateCustomErrorPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomErrorPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomErrorPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public async Task<CreateDnsRecordResponse> CreateDnsRecord(CreateDnsRecordRequest req)
        {
             JsonResponseModel<CreateDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="CreateDnsRecordRequest"/></param>
        /// <returns><see cref="CreateDnsRecordResponse"/></returns>
        public CreateDnsRecordResponse CreateDnsRecordSync(CreateDnsRecordRequest req)
        {
             JsonResponseModel<CreateDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建负载均衡
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancingRequest"/></param>
        /// <returns><see cref="CreateLoadBalancingResponse"/></returns>
        public async Task<CreateLoadBalancingResponse> CreateLoadBalancing(CreateLoadBalancingRequest req)
        {
             JsonResponseModel<CreateLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建负载均衡
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancingRequest"/></param>
        /// <returns><see cref="CreateLoadBalancingResponse"/></returns>
        public CreateLoadBalancingResponse CreateLoadBalancingSync(CreateLoadBalancingRequest req)
        {
             JsonResponseModel<CreateLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 源站组创建
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
        /// 源站组创建
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
        /// 用于用户接入新的站点
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
        /// 用于用户接入新的站点
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
        /// 批量删除 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public async Task<DeleteDnsRecordsResponse> DeleteDnsRecords(DeleteDnsRecordsRequest req)
        {
             JsonResponseModel<DeleteDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="DeleteDnsRecordsRequest"/></param>
        /// <returns><see cref="DeleteDnsRecordsResponse"/></returns>
        public DeleteDnsRecordsResponse DeleteDnsRecordsSync(DeleteDnsRecordsRequest req)
        {
             JsonResponseModel<DeleteDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancingRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancingResponse"/></returns>
        public async Task<DeleteLoadBalancingResponse> DeleteLoadBalancing(DeleteLoadBalancingRequest req)
        {
             JsonResponseModel<DeleteLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除负载均衡
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancingRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancingResponse"/></returns>
        public DeleteLoadBalancingResponse DeleteLoadBalancingSync(DeleteLoadBalancingRequest req)
        {
             JsonResponseModel<DeleteLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 源站组删除
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
        /// 源站组删除
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
        /// 删除站点
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
        /// 删除站点
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
        /// 获取应用代理列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyResponse"/></returns>
        public async Task<DescribeApplicationProxyResponse> DescribeApplicationProxy(DescribeApplicationProxyRequest req)
        {
             JsonResponseModel<DescribeApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用代理列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyResponse"/></returns>
        public DescribeApplicationProxyResponse DescribeApplicationProxySync(DescribeApplicationProxyRequest req)
        {
             JsonResponseModel<DescribeApplicationProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用代理详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyDetailResponse"/></returns>
        public async Task<DescribeApplicationProxyDetailResponse> DescribeApplicationProxyDetail(DescribeApplicationProxyDetailRequest req)
        {
             JsonResponseModel<DescribeApplicationProxyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationProxyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用代理详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProxyDetailRequest"/></param>
        /// <returns><see cref="DescribeApplicationProxyDetailResponse"/></returns>
        public DescribeApplicationProxyDetailResponse DescribeApplicationProxyDetailSync(DescribeApplicationProxyDetailRequest req)
        {
             JsonResponseModel<DescribeApplicationProxyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationProxyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationProxyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询Bot托管规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBotManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeBotManagedRulesResponse"/></returns>
        public async Task<DescribeBotManagedRulesResponse> DescribeBotManagedRules(DescribeBotManagedRulesRequest req)
        {
             JsonResponseModel<DescribeBotManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBotManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询Bot托管规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBotManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeBotManagedRulesResponse"/></returns>
        public DescribeBotManagedRulesResponse DescribeBotManagedRulesSync(DescribeBotManagedRulesRequest req)
        {
             JsonResponseModel<DescribeBotManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBotManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBotManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询域名 CNAME 状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCnameStatusRequest"/></param>
        /// <returns><see cref="DescribeCnameStatusResponse"/></returns>
        public async Task<DescribeCnameStatusResponse> DescribeCnameStatus(DescribeCnameStatusRequest req)
        {
             JsonResponseModel<DescribeCnameStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCnameStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCnameStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询域名 CNAME 状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCnameStatusRequest"/></param>
        /// <returns><see cref="DescribeCnameStatusResponse"/></returns>
        public DescribeCnameStatusResponse DescribeCnameStatusSync(DescribeCnameStatusRequest req)
        {
             JsonResponseModel<DescribeCnameStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCnameStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCnameStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DDoS防护配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public async Task<DescribeDDoSPolicyResponse> DescribeDDoSPolicy(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DDoS防护配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public DescribeDDoSPolicyResponse DescribeDDoSPolicySync(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
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
        /// 查询 DNS 记录列表，支持搜索、分页、排序、过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public async Task<DescribeDnsRecordsResponse> DescribeDnsRecords(DescribeDnsRecordsRequest req)
        {
             JsonResponseModel<DescribeDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 DNS 记录列表，支持搜索、分页、排序、过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsRecordsRequest"/></param>
        /// <returns><see cref="DescribeDnsRecordsResponse"/></returns>
        public DescribeDnsRecordsResponse DescribeDnsRecordsSync(DescribeDnsRecordsRequest req)
        {
             JsonResponseModel<DescribeDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询 DNSSEC 相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDnssecRequest"/></param>
        /// <returns><see cref="DescribeDnssecResponse"/></returns>
        public async Task<DescribeDnssecResponse> DescribeDnssec(DescribeDnssecRequest req)
        {
             JsonResponseModel<DescribeDnssecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnssecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询 DNSSEC 相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDnssecRequest"/></param>
        /// <returns><see cref="DescribeDnssecResponse"/></returns>
        public DescribeDnssecResponse DescribeDnssecSync(DescribeDnssecRequest req)
        {
             JsonResponseModel<DescribeDnssecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDnssecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询域名证书列表，支持搜索、分页、排序、过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsCertificateRequest"/></param>
        /// <returns><see cref="DescribeHostsCertificateResponse"/></returns>
        public async Task<DescribeHostsCertificateResponse> DescribeHostsCertificate(DescribeHostsCertificateRequest req)
        {
             JsonResponseModel<DescribeHostsCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostsCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询域名证书列表，支持搜索、分页、排序、过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsCertificateRequest"/></param>
        /// <returns><see cref="DescribeHostsCertificateResponse"/></returns>
        public DescribeHostsCertificateResponse DescribeHostsCertificateSync(DescribeHostsCertificateRequest req)
        {
             JsonResponseModel<DescribeHostsCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostsCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsCertificateResponse>>(strResp);
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
        /// 查询验证结果
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationRequest"/></param>
        /// <returns><see cref="DescribeIdentificationResponse"/></returns>
        public async Task<DescribeIdentificationResponse> DescribeIdentification(DescribeIdentificationRequest req)
        {
             JsonResponseModel<DescribeIdentificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIdentification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdentificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询验证结果
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentificationRequest"/></param>
        /// <returns><see cref="DescribeIdentificationResponse"/></returns>
        public DescribeIdentificationResponse DescribeIdentificationSync(DescribeIdentificationRequest req)
        {
             JsonResponseModel<DescribeIdentificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIdentification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdentificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取负载均衡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingResponse"/></returns>
        public async Task<DescribeLoadBalancingResponse> DescribeLoadBalancing(DescribeLoadBalancingRequest req)
        {
             JsonResponseModel<DescribeLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取负载均衡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingResponse"/></returns>
        public DescribeLoadBalancingResponse DescribeLoadBalancingSync(DescribeLoadBalancingRequest req)
        {
             JsonResponseModel<DescribeLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取负载均衡详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingDetailResponse"/></returns>
        public async Task<DescribeLoadBalancingDetailResponse> DescribeLoadBalancingDetail(DescribeLoadBalancingDetailRequest req)
        {
             JsonResponseModel<DescribeLoadBalancingDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancingDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancingDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取负载均衡详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancingDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancingDetailResponse"/></returns>
        public DescribeLoadBalancingDetailResponse DescribeLoadBalancingDetailSync(DescribeLoadBalancingDetailRequest req)
        {
             JsonResponseModel<DescribeLoadBalancingDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancingDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancingDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取源站组信息列表
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
        /// 获取源站组信息列表
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
        /// 获取源站组详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupDetailResponse"/></returns>
        public async Task<DescribeOriginGroupDetailResponse> DescribeOriginGroupDetail(DescribeOriginGroupDetailRequest req)
        {
             JsonResponseModel<DescribeOriginGroupDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOriginGroupDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginGroupDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取源站组详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeOriginGroupDetailResponse"/></returns>
        public DescribeOriginGroupDetailResponse DescribeOriginGroupDetailSync(DescribeOriginGroupDetailRequest req)
        {
             JsonResponseModel<DescribeOriginGroupDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOriginGroupDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginGroupDetailResponse>>(strResp);
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
        /// 查询安全防护配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public async Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicy(DescribeSecurityPolicyRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全防护配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyResponse"/></returns>
        public DescribeSecurityPolicyResponse DescribeSecurityPolicySync(DescribeSecurityPolicyRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全部安全实例
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyListRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyListResponse"/></returns>
        public async Task<DescribeSecurityPolicyListResponse> DescribeSecurityPolicyList(DescribeSecurityPolicyListRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询全部安全实例
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyListRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyListResponse"/></returns>
        public DescribeSecurityPolicyListResponse DescribeSecurityPolicyListSync(DescribeSecurityPolicyListRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询门神规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesResponse"/></returns>
        public async Task<DescribeSecurityPolicyManagedRulesResponse> DescribeSecurityPolicyManagedRules(DescribeSecurityPolicyManagedRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询门神规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesResponse"/></returns>
        public DescribeSecurityPolicyManagedRulesResponse DescribeSecurityPolicyManagedRulesSync(DescribeSecurityPolicyManagedRulesRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyManagedRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicyManagedRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyManagedRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则id查询门神规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesIdRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesIdResponse"/></returns>
        public async Task<DescribeSecurityPolicyManagedRulesIdResponse> DescribeSecurityPolicyManagedRulesId(DescribeSecurityPolicyManagedRulesIdRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyManagedRulesIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyManagedRulesId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyManagedRulesIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 规则id查询门神规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyManagedRulesIdRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyManagedRulesIdResponse"/></returns>
        public DescribeSecurityPolicyManagedRulesIdResponse DescribeSecurityPolicyManagedRulesIdSync(DescribeSecurityPolicyManagedRulesIdRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyManagedRulesIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicyManagedRulesId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyManagedRulesIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有地域信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRegionsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRegionsResponse"/></returns>
        public async Task<DescribeSecurityPolicyRegionsResponse> DescribeSecurityPolicyRegions(DescribeSecurityPolicyRegionsRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityPolicyRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有地域信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityPolicyRegionsRequest"/></param>
        /// <returns><see cref="DescribeSecurityPolicyRegionsResponse"/></returns>
        public DescribeSecurityPolicyRegionsResponse DescribeSecurityPolicyRegionsSync(DescribeSecurityPolicyRegionsRequest req)
        {
             JsonResponseModel<DescribeSecurityPolicyRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityPolicyRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityPolicyRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有DDoS防护分区
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeZoneDDoSPolicyResponse"/></returns>
        public async Task<DescribeZoneDDoSPolicyResponse> DescribeZoneDDoSPolicy(DescribeZoneDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeZoneDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有DDoS防护分区
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeZoneDDoSPolicyResponse"/></returns>
        public DescribeZoneDDoSPolicyResponse DescribeZoneDDoSPolicySync(DescribeZoneDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeZoneDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据站点 ID 查询站点的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDetailsRequest"/></param>
        /// <returns><see cref="DescribeZoneDetailsResponse"/></returns>
        public async Task<DescribeZoneDetailsResponse> DescribeZoneDetails(DescribeZoneDetailsRequest req)
        {
             JsonResponseModel<DescribeZoneDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据站点 ID 查询站点的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDetailsRequest"/></param>
        /// <returns><see cref="DescribeZoneDetailsResponse"/></returns>
        public DescribeZoneDetailsResponse DescribeZoneDetailsSync(DescribeZoneDetailsRequest req)
        {
             JsonResponseModel<DescribeZoneDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZoneDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneDetailsResponse>>(strResp);
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
        /// 用户查询用户站点信息列表，支持分页
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
        /// 用户查询用户站点信息列表，支持分页
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
        /// 查询七层离线日志
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
        /// 查询七层离线日志
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
        /// 用于验证站点所有权
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
        /// 用于验证站点所有权
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
        /// 导入 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="ImportDnsRecordsRequest"/></param>
        /// <returns><see cref="ImportDnsRecordsResponse"/></returns>
        public async Task<ImportDnsRecordsResponse> ImportDnsRecords(ImportDnsRecordsRequest req)
        {
             JsonResponseModel<ImportDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="ImportDnsRecordsRequest"/></param>
        /// <returns><see cref="ImportDnsRecordsResponse"/></returns>
        public ImportDnsRecordsResponse ImportDnsRecordsSync(ImportDnsRecordsRequest req)
        {
             JsonResponseModel<ImportDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportDnsRecordsResponse>>(strResp);
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
        /// 修改DDoS防护分区配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public async Task<ModifyDDoSPolicyResponse> ModifyDDoSPolicy(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS防护分区配置
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public ModifyDDoSPolicyResponse ModifyDDoSPolicySync(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名DDoS高可用开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyHostRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyHostResponse"/></returns>
        public async Task<ModifyDDoSPolicyHostResponse> ModifyDDoSPolicyHost(ModifyDDoSPolicyHostRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicyHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 域名DDoS高可用开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyHostRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyHostResponse"/></returns>
        public ModifyDDoSPolicyHostResponse ModifyDDoSPolicyHostSync(ModifyDDoSPolicyHostRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicyHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyHostResponse>>(strResp);
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
        /// 修改 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordResponse"/></returns>
        public async Task<ModifyDnsRecordResponse> ModifyDnsRecord(ModifyDnsRecordRequest req)
        {
             JsonResponseModel<ModifyDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 DNS 记录
        /// </summary>
        /// <param name="req"><see cref="ModifyDnsRecordRequest"/></param>
        /// <returns><see cref="ModifyDnsRecordResponse"/></returns>
        public ModifyDnsRecordResponse ModifyDnsRecordSync(ModifyDnsRecordRequest req)
        {
             JsonResponseModel<ModifyDnsRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDnsRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnsRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 DNSSEC 状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDnssecRequest"/></param>
        /// <returns><see cref="ModifyDnssecResponse"/></returns>
        public async Task<ModifyDnssecResponse> ModifyDnssec(ModifyDnssecRequest req)
        {
             JsonResponseModel<ModifyDnssecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnssecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 DNSSEC 状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDnssecRequest"/></param>
        /// <returns><see cref="ModifyDnssecResponse"/></returns>
        public ModifyDnssecResponse ModifyDnssecSync(ModifyDnssecRequest req)
        {
             JsonResponseModel<ModifyDnssecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDnssec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDnssecResponse>>(strResp);
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
        /// 修改负载均衡
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingResponse"/></returns>
        public async Task<ModifyLoadBalancingResponse> ModifyLoadBalancing(ModifyLoadBalancingRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingResponse"/></returns>
        public ModifyLoadBalancingResponse ModifyLoadBalancingSync(ModifyLoadBalancingRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡状态
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingStatusRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingStatusResponse"/></returns>
        public async Task<ModifyLoadBalancingStatusResponse> ModifyLoadBalancingStatus(ModifyLoadBalancingStatusRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancingStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改负载均衡状态
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancingStatusRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancingStatusResponse"/></returns>
        public ModifyLoadBalancingStatusResponse ModifyLoadBalancingStatusSync(ModifyLoadBalancingStatusRequest req)
        {
             JsonResponseModel<ModifyLoadBalancingStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancingStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancingStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 源站组修改
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
        /// 源站组修改
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
        /// 修改Web&Bot安全配置
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
        /// 修改Web&Bot安全配置
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
        /// 用该站点信息
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
        /// 用该站点信息
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
        /// 开启，关闭 CNAME 加速
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCnameSpeedUpRequest"/></param>
        /// <returns><see cref="ModifyZoneCnameSpeedUpResponse"/></returns>
        public async Task<ModifyZoneCnameSpeedUpResponse> ModifyZoneCnameSpeedUp(ModifyZoneCnameSpeedUpRequest req)
        {
             JsonResponseModel<ModifyZoneCnameSpeedUpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZoneCnameSpeedUp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneCnameSpeedUpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启，关闭 CNAME 加速
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCnameSpeedUpRequest"/></param>
        /// <returns><see cref="ModifyZoneCnameSpeedUpResponse"/></returns>
        public ModifyZoneCnameSpeedUpResponse ModifyZoneCnameSpeedUpSync(ModifyZoneCnameSpeedUpRequest req)
        {
             JsonResponseModel<ModifyZoneCnameSpeedUpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZoneCnameSpeedUp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneCnameSpeedUpResponse>>(strResp);
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
        /// 用于开启，关闭站点
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
        /// 用于开启，关闭站点
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
        /// 站点被其他用户接入后，验证了站点所有权之后，可以找回该站点
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
        /// 站点被其他用户接入后，验证了站点所有权之后，可以找回该站点
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
        /// 扫描站点历史解析记录
        /// </summary>
        /// <param name="req"><see cref="ScanDnsRecordsRequest"/></param>
        /// <returns><see cref="ScanDnsRecordsResponse"/></returns>
        public async Task<ScanDnsRecordsResponse> ScanDnsRecords(ScanDnsRecordsRequest req)
        {
             JsonResponseModel<ScanDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扫描站点历史解析记录
        /// </summary>
        /// <param name="req"><see cref="ScanDnsRecordsRequest"/></param>
        /// <returns><see cref="ScanDnsRecordsResponse"/></returns>
        public ScanDnsRecordsResponse ScanDnsRecordsSync(ScanDnsRecordsRequest req)
        {
             JsonResponseModel<ScanDnsRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanDnsRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanDnsRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
