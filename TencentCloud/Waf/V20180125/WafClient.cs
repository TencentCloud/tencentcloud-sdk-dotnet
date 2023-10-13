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

namespace TencentCloud.Waf.V20180125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Waf.V20180125.Models;

   public class WafClient : AbstractClient{

       private const string endpoint = "waf.tencentcloudapi.com";
       private const string version = "2018-01-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WafClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WafClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加防篡改url
        /// </summary>
        /// <param name="req"><see cref="AddAntiFakeUrlRequest"/></param>
        /// <returns><see cref="AddAntiFakeUrlResponse"/></returns>
        public async Task<AddAntiFakeUrlResponse> AddAntiFakeUrl(AddAntiFakeUrlRequest req)
        {
             JsonResponseModel<AddAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加防篡改url
        /// </summary>
        /// <param name="req"><see cref="AddAntiFakeUrlRequest"/></param>
        /// <returns><see cref="AddAntiFakeUrlResponse"/></returns>
        public AddAntiFakeUrlResponse AddAntiFakeUrlSync(AddAntiFakeUrlRequest req)
        {
             JsonResponseModel<AddAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="AddAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="AddAntiInfoLeakRulesResponse"/></returns>
        public async Task<AddAntiInfoLeakRulesResponse> AddAntiInfoLeakRules(AddAntiInfoLeakRulesRequest req)
        {
             JsonResponseModel<AddAntiInfoLeakRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAntiInfoLeakRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAntiInfoLeakRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="AddAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="AddAntiInfoLeakRulesResponse"/></returns>
        public AddAntiInfoLeakRulesResponse AddAntiInfoLeakRulesSync(AddAntiInfoLeakRulesRequest req)
        {
             JsonResponseModel<AddAntiInfoLeakRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAntiInfoLeakRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAntiInfoLeakRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 供用户控制台调用，增加Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="AddAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="AddAttackWhiteRuleResponse"/></returns>
        public async Task<AddAttackWhiteRuleResponse> AddAttackWhiteRule(AddAttackWhiteRuleRequest req)
        {
             JsonResponseModel<AddAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 供用户控制台调用，增加Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="AddAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="AddAttackWhiteRuleResponse"/></returns>
        public AddAttackWhiteRuleResponse AddAttackWhiteRuleSync(AddAttackWhiteRuleRequest req)
        {
             JsonResponseModel<AddAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public async Task<AddCustomRuleResponse> AddCustomRule(AddCustomRuleRequest req)
        {
             JsonResponseModel<AddCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public AddCustomRuleResponse AddCustomRuleSync(AddCustomRuleRequest req)
        {
             JsonResponseModel<AddCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="AddCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="AddCustomWhiteRuleResponse"/></returns>
        public async Task<AddCustomWhiteRuleResponse> AddCustomWhiteRule(AddCustomWhiteRuleRequest req)
        {
             JsonResponseModel<AddCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="AddCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="AddCustomWhiteRuleResponse"/></returns>
        public AddCustomWhiteRuleResponse AddCustomWhiteRuleSync(AddCustomWhiteRuleRequest req)
        {
             JsonResponseModel<AddCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="AddDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="AddDomainWhiteRuleResponse"/></returns>
        public async Task<AddDomainWhiteRuleResponse> AddDomainWhiteRule(AddDomainWhiteRuleRequest req)
        {
             JsonResponseModel<AddDomainWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDomainWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDomainWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="AddDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="AddDomainWhiteRuleResponse"/></returns>
        public AddDomainWhiteRuleResponse AddDomainWhiteRuleSync(AddDomainWhiteRuleRequest req)
        {
             JsonResponseModel<AddDomainWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDomainWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDomainWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加SaaS型WAF防护域名
        /// </summary>
        /// <param name="req"><see cref="AddSpartaProtectionRequest"/></param>
        /// <returns><see cref="AddSpartaProtectionResponse"/></returns>
        public async Task<AddSpartaProtectionResponse> AddSpartaProtection(AddSpartaProtectionRequest req)
        {
             JsonResponseModel<AddSpartaProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSpartaProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSpartaProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加SaaS型WAF防护域名
        /// </summary>
        /// <param name="req"><see cref="AddSpartaProtectionRequest"/></param>
        /// <returns><see cref="AddSpartaProtectionResponse"/></returns>
        public AddSpartaProtectionResponse AddSpartaProtectionSync(AddSpartaProtectionRequest req)
        {
             JsonResponseModel<AddSpartaProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddSpartaProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSpartaProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建访问日志导出
        /// </summary>
        /// <param name="req"><see cref="CreateAccessExportRequest"/></param>
        /// <returns><see cref="CreateAccessExportResponse"/></returns>
        public async Task<CreateAccessExportResponse> CreateAccessExport(CreateAccessExportRequest req)
        {
             JsonResponseModel<CreateAccessExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccessExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccessExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建访问日志导出
        /// </summary>
        /// <param name="req"><see cref="CreateAccessExportRequest"/></param>
        /// <returns><see cref="CreateAccessExportResponse"/></returns>
        public CreateAccessExportResponse CreateAccessExportSync(CreateAccessExportRequest req)
        {
             JsonResponseModel<CreateAccessExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccessExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccessExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf中添加防护域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostRequest"/></param>
        /// <returns><see cref="CreateHostResponse"/></returns>
        public async Task<CreateHostResponse> CreateHost(CreateHostRequest req)
        {
             JsonResponseModel<CreateHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf中添加防护域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostRequest"/></param>
        /// <returns><see cref="CreateHostResponse"/></returns>
        public CreateHostResponse CreateHostSync(CreateHostRequest req)
        {
             JsonResponseModel<CreateHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除访问日志导出
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessExportRequest"/></param>
        /// <returns><see cref="DeleteAccessExportResponse"/></returns>
        public async Task<DeleteAccessExportResponse> DeleteAccessExport(DeleteAccessExportRequest req)
        {
             JsonResponseModel<DeleteAccessExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccessExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除访问日志导出
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessExportRequest"/></param>
        /// <returns><see cref="DeleteAccessExportResponse"/></returns>
        public DeleteAccessExportResponse DeleteAccessExportSync(DeleteAccessExportRequest req)
        {
             JsonResponseModel<DeleteAccessExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccessExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除防篡改url
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DeleteAntiFakeUrlResponse"/></returns>
        public async Task<DeleteAntiFakeUrlResponse> DeleteAntiFakeUrl(DeleteAntiFakeUrlRequest req)
        {
             JsonResponseModel<DeleteAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除防篡改url
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DeleteAntiFakeUrlResponse"/></returns>
        public DeleteAntiFakeUrlResponse DeleteAntiFakeUrlSync(DeleteAntiFakeUrlRequest req)
        {
             JsonResponseModel<DeleteAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 信息防泄漏删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiInfoLeakRuleRequest"/></param>
        /// <returns><see cref="DeleteAntiInfoLeakRuleResponse"/></returns>
        public async Task<DeleteAntiInfoLeakRuleResponse> DeleteAntiInfoLeakRule(DeleteAntiInfoLeakRuleRequest req)
        {
             JsonResponseModel<DeleteAntiInfoLeakRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAntiInfoLeakRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAntiInfoLeakRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 信息防泄漏删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiInfoLeakRuleRequest"/></param>
        /// <returns><see cref="DeleteAntiInfoLeakRuleResponse"/></returns>
        public DeleteAntiInfoLeakRuleResponse DeleteAntiInfoLeakRuleSync(DeleteAntiInfoLeakRuleRequest req)
        {
             JsonResponseModel<DeleteAntiInfoLeakRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAntiInfoLeakRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAntiInfoLeakRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除攻击日志下载任务记录
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteAttackDownloadRecordResponse"/></returns>
        public async Task<DeleteAttackDownloadRecordResponse> DeleteAttackDownloadRecord(DeleteAttackDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteAttackDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAttackDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除攻击日志下载任务记录
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteAttackDownloadRecordResponse"/></returns>
        public DeleteAttackDownloadRecordResponse DeleteAttackDownloadRecordSync(DeleteAttackDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteAttackDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAttackDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 供用户控制台调用，删除Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteAttackWhiteRuleResponse"/></returns>
        public async Task<DeleteAttackWhiteRuleResponse> DeleteAttackWhiteRule(DeleteAttackWhiteRuleRequest req)
        {
             JsonResponseModel<DeleteAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 供用户控制台调用，删除Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteAttackWhiteRuleResponse"/></returns>
        public DeleteAttackWhiteRuleResponse DeleteAttackWhiteRuleSync(DeleteAttackWhiteRuleRequest req)
        {
             JsonResponseModel<DeleteAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  CC V2 Delete接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRuleRequest"/></param>
        /// <returns><see cref="DeleteCCRuleResponse"/></returns>
        public async Task<DeleteCCRuleResponse> DeleteCCRule(DeleteCCRuleRequest req)
        {
             JsonResponseModel<DeleteCCRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  CC V2 Delete接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRuleRequest"/></param>
        /// <returns><see cref="DeleteCCRuleResponse"/></returns>
        public DeleteCCRuleResponse DeleteCCRuleSync(DeleteCCRuleRequest req)
        {
             JsonResponseModel<DeleteCCRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomRuleResponse"/></returns>
        public async Task<DeleteCustomRuleResponse> DeleteCustomRule(DeleteCustomRuleRequest req)
        {
             JsonResponseModel<DeleteCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomRuleResponse"/></returns>
        public DeleteCustomRuleResponse DeleteCustomRuleSync(DeleteCustomRuleRequest req)
        {
             JsonResponseModel<DeleteCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomWhiteRuleResponse"/></returns>
        public async Task<DeleteCustomWhiteRuleResponse> DeleteCustomWhiteRule(DeleteCustomWhiteRuleRequest req)
        {
             JsonResponseModel<DeleteCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomWhiteRuleResponse"/></returns>
        public DeleteCustomWhiteRuleResponse DeleteCustomWhiteRuleSync(DeleteCustomWhiteRuleRequest req)
        {
             JsonResponseModel<DeleteCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DeleteDomainWhiteRulesResponse"/></returns>
        public async Task<DeleteDomainWhiteRulesResponse> DeleteDomainWhiteRules(DeleteDomainWhiteRulesRequest req)
        {
             JsonResponseModel<DeleteDomainWhiteRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomainWhiteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainWhiteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DeleteDomainWhiteRulesResponse"/></returns>
        public DeleteDomainWhiteRulesResponse DeleteDomainWhiteRulesSync(DeleteDomainWhiteRulesRequest req)
        {
             JsonResponseModel<DeleteDomainWhiteRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomainWhiteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainWhiteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问日志下载记录
        /// </summary>
        /// <param name="req"><see cref="DeleteDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteDownloadRecordResponse"/></returns>
        public async Task<DeleteDownloadRecordResponse> DeleteDownloadRecord(DeleteDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问日志下载记录
        /// </summary>
        /// <param name="req"><see cref="DeleteDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteDownloadRecordResponse"/></returns>
        public DeleteDownloadRecordResponse DeleteDownloadRecordSync(DeleteDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CLB-WAF防护域名
        /// 支持批量操作
        /// </summary>
        /// <param name="req"><see cref="DeleteHostRequest"/></param>
        /// <returns><see cref="DeleteHostResponse"/></returns>
        public async Task<DeleteHostResponse> DeleteHost(DeleteHostRequest req)
        {
             JsonResponseModel<DeleteHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CLB-WAF防护域名
        /// 支持批量操作
        /// </summary>
        /// <param name="req"><see cref="DeleteHostRequest"/></param>
        /// <returns><see cref="DeleteHostResponse"/></returns>
        public DeleteHostResponse DeleteHostSync(DeleteHostRequest req)
        {
             JsonResponseModel<DeleteHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf IP黑白名单Delete接口
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlRequest"/></param>
        /// <returns><see cref="DeleteIpAccessControlResponse"/></returns>
        public async Task<DeleteIpAccessControlResponse> DeleteIpAccessControl(DeleteIpAccessControlRequest req)
        {
             JsonResponseModel<DeleteIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf IP黑白名单Delete接口
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlRequest"/></param>
        /// <returns><see cref="DeleteIpAccessControlResponse"/></returns>
        public DeleteIpAccessControlResponse DeleteIpAccessControlSync(DeleteIpAccessControlRequest req)
        {
             JsonResponseModel<DeleteIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC攻击的session设置
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public async Task<DeleteSessionResponse> DeleteSession(DeleteSessionRequest req)
        {
             JsonResponseModel<DeleteSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC攻击的session设置
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public DeleteSessionResponse DeleteSessionSync(DeleteSessionRequest req)
        {
             JsonResponseModel<DeleteSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Saas型WAF删除防护域名
        /// </summary>
        /// <param name="req"><see cref="DeleteSpartaProtectionRequest"/></param>
        /// <returns><see cref="DeleteSpartaProtectionResponse"/></returns>
        public async Task<DeleteSpartaProtectionResponse> DeleteSpartaProtection(DeleteSpartaProtectionRequest req)
        {
             JsonResponseModel<DeleteSpartaProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSpartaProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSpartaProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Saas型WAF删除防护域名
        /// </summary>
        /// <param name="req"><see cref="DeleteSpartaProtectionRequest"/></param>
        /// <returns><see cref="DeleteSpartaProtectionResponse"/></returns>
        public DeleteSpartaProtectionResponse DeleteSpartaProtectionSync(DeleteSpartaProtectionRequest req)
        {
             JsonResponseModel<DeleteSpartaProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSpartaProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSpartaProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取访问日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessExportsRequest"/></param>
        /// <returns><see cref="DescribeAccessExportsResponse"/></returns>
        public async Task<DescribeAccessExportsResponse> DescribeAccessExports(DescribeAccessExportsRequest req)
        {
             JsonResponseModel<DescribeAccessExportsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取访问日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessExportsRequest"/></param>
        /// <returns><see cref="DescribeAccessExportsResponse"/></returns>
        public DescribeAccessExportsResponse DescribeAccessExportsSync(DescribeAccessExportsRequest req)
        {
             JsonResponseModel<DescribeAccessExportsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于访问日志的快速分析
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeAccessFastAnalysisResponse"/></returns>
        public async Task<DescribeAccessFastAnalysisResponse> DescribeAccessFastAnalysis(DescribeAccessFastAnalysisRequest req)
        {
             JsonResponseModel<DescribeAccessFastAnalysisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessFastAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessFastAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于访问日志的快速分析
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeAccessFastAnalysisResponse"/></returns>
        public DescribeAccessFastAnalysisResponse DescribeAccessFastAnalysisSync(DescribeAccessFastAnalysisRequest req)
        {
             JsonResponseModel<DescribeAccessFastAnalysisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessFastAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessFastAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于访问日志柱状趋势图
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessHistogramRequest"/></param>
        /// <returns><see cref="DescribeAccessHistogramResponse"/></returns>
        public async Task<DescribeAccessHistogramResponse> DescribeAccessHistogram(DescribeAccessHistogramRequest req)
        {
             JsonResponseModel<DescribeAccessHistogramResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessHistogramResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于访问日志柱状趋势图
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessHistogramRequest"/></param>
        /// <returns><see cref="DescribeAccessHistogramResponse"/></returns>
        public DescribeAccessHistogramResponse DescribeAccessHistogramSync(DescribeAccessHistogramRequest req)
        {
             JsonResponseModel<DescribeAccessHistogramResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessHistogramResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取访问日志索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessIndexRequest"/></param>
        /// <returns><see cref="DescribeAccessIndexResponse"/></returns>
        public async Task<DescribeAccessIndexResponse> DescribeAccessIndex(DescribeAccessIndexRequest req)
        {
             JsonResponseModel<DescribeAccessIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取访问日志索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessIndexRequest"/></param>
        /// <returns><see cref="DescribeAccessIndexResponse"/></returns>
        public DescribeAccessIndexResponse DescribeAccessIndexSync(DescribeAccessIndexRequest req)
        {
             JsonResponseModel<DescribeAccessIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防篡改url
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeRulesResponse"/></returns>
        public async Task<DescribeAntiFakeRulesResponse> DescribeAntiFakeRules(DescribeAntiFakeRulesRequest req)
        {
             JsonResponseModel<DescribeAntiFakeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAntiFakeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiFakeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防篡改url
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeRulesResponse"/></returns>
        public DescribeAntiFakeRulesResponse DescribeAntiFakeRulesSync(DescribeAntiFakeRulesRequest req)
        {
             JsonResponseModel<DescribeAntiFakeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAntiFakeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiFakeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防篡改url
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeUrlResponse"/></returns>
        public async Task<DescribeAntiFakeUrlResponse> DescribeAntiFakeUrl(DescribeAntiFakeUrlRequest req)
        {
             JsonResponseModel<DescribeAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防篡改url
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeUrlResponse"/></returns>
        public DescribeAntiFakeUrlResponse DescribeAntiFakeUrlSync(DescribeAntiFakeUrlRequest req)
        {
             JsonResponseModel<DescribeAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 老接口已经不再使用。
        /// 
        /// 获取信息防泄漏规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakRulesResponse"/></returns>
        public async Task<DescribeAntiInfoLeakRulesResponse> DescribeAntiInfoLeakRules(DescribeAntiInfoLeakRulesRequest req)
        {
             JsonResponseModel<DescribeAntiInfoLeakRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAntiInfoLeakRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiInfoLeakRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 老接口已经不再使用。
        /// 
        /// 获取信息防泄漏规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakRulesResponse"/></returns>
        public DescribeAntiInfoLeakRulesResponse DescribeAntiInfoLeakRulesSync(DescribeAntiInfoLeakRulesRequest req)
        {
             JsonResponseModel<DescribeAntiInfoLeakRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAntiInfoLeakRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiInfoLeakRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取得信息防泄漏规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakageRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakageRulesResponse"/></returns>
        public async Task<DescribeAntiInfoLeakageRulesResponse> DescribeAntiInfoLeakageRules(DescribeAntiInfoLeakageRulesRequest req)
        {
             JsonResponseModel<DescribeAntiInfoLeakageRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAntiInfoLeakageRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiInfoLeakageRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取得信息防泄漏规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakageRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakageRulesResponse"/></returns>
        public DescribeAntiInfoLeakageRulesResponse DescribeAntiInfoLeakageRulesSync(DescribeAntiInfoLeakageRulesRequest req)
        {
             JsonResponseModel<DescribeAntiInfoLeakageRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAntiInfoLeakageRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAntiInfoLeakageRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 攻击总览
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackOverviewRequest"/></param>
        /// <returns><see cref="DescribeAttackOverviewResponse"/></returns>
        public async Task<DescribeAttackOverviewResponse> DescribeAttackOverview(DescribeAttackOverviewRequest req)
        {
             JsonResponseModel<DescribeAttackOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 攻击总览
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackOverviewRequest"/></param>
        /// <returns><see cref="DescribeAttackOverviewResponse"/></returns>
        public DescribeAttackOverviewResponse DescribeAttackOverviewSync(DescribeAttackOverviewRequest req)
        {
             JsonResponseModel<DescribeAttackOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户规则白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeAttackWhiteRuleResponse"/></returns>
        public async Task<DescribeAttackWhiteRuleResponse> DescribeAttackWhiteRule(DescribeAttackWhiteRuleRequest req)
        {
             JsonResponseModel<DescribeAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户规则白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeAttackWhiteRuleResponse"/></returns>
        public DescribeAttackWhiteRuleResponse DescribeAttackWhiteRuleSync(DescribeAttackWhiteRuleRequest req)
        {
             JsonResponseModel<DescribeAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口已废弃
        /// 
        /// 描述WAF自动封禁IP详情,对齐自动封堵状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoDenyIPRequest"/></param>
        /// <returns><see cref="DescribeAutoDenyIPResponse"/></returns>
        public async Task<DescribeAutoDenyIPResponse> DescribeAutoDenyIP(DescribeAutoDenyIPRequest req)
        {
             JsonResponseModel<DescribeAutoDenyIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoDenyIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoDenyIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口已废弃
        /// 
        /// 描述WAF自动封禁IP详情,对齐自动封堵状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoDenyIPRequest"/></param>
        /// <returns><see cref="DescribeAutoDenyIPResponse"/></returns>
        public DescribeAutoDenyIPResponse DescribeAutoDenyIPSync(DescribeAutoDenyIPRequest req)
        {
             JsonResponseModel<DescribeAutoDenyIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoDenyIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoDenyIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf 多域名ip黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeBatchIpAccessControlResponse"/></returns>
        public async Task<DescribeBatchIpAccessControlResponse> DescribeBatchIpAccessControl(DescribeBatchIpAccessControlRequest req)
        {
             JsonResponseModel<DescribeBatchIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf 多域名ip黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeBatchIpAccessControlResponse"/></returns>
        public DescribeBatchIpAccessControlResponse DescribeBatchIpAccessControlSync(DescribeBatchIpAccessControlRequest req)
        {
             JsonResponseModel<DescribeBatchIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  CC V2 Query接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleRequest"/></param>
        /// <returns><see cref="DescribeCCRuleResponse"/></returns>
        public async Task<DescribeCCRuleResponse> DescribeCCRule(DescribeCCRuleRequest req)
        {
             JsonResponseModel<DescribeCCRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  CC V2 Query接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleRequest"/></param>
        /// <returns><see cref="DescribeCCRuleResponse"/></returns>
        public DescribeCCRuleResponse DescribeCCRuleSync(DescribeCCRuleRequest req)
        {
             JsonResponseModel<DescribeCCRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据多条件查询CC规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleListRequest"/></param>
        /// <returns><see cref="DescribeCCRuleListResponse"/></returns>
        public async Task<DescribeCCRuleListResponse> DescribeCCRuleList(DescribeCCRuleListRequest req)
        {
             JsonResponseModel<DescribeCCRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据多条件查询CC规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleListRequest"/></param>
        /// <returns><see cref="DescribeCCRuleListResponse"/></returns>
        public DescribeCCRuleListResponse DescribeCCRuleListSync(DescribeCCRuleListRequest req)
        {
             JsonResponseModel<DescribeCCRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书的检查结果
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateVerifyResultResponse"/></returns>
        public async Task<DescribeCertificateVerifyResultResponse> DescribeCertificateVerifyResult(DescribeCertificateVerifyResultRequest req)
        {
             JsonResponseModel<DescribeCertificateVerifyResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateVerifyResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateVerifyResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书的检查结果
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateVerifyResultResponse"/></returns>
        public DescribeCertificateVerifyResultResponse DescribeCertificateVerifyResultSync(DescribeCertificateVerifyResultRequest req)
        {
             JsonResponseModel<DescribeCertificateVerifyResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateVerifyResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateVerifyResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Saas型WAF接入查询加密套件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCiphersDetailRequest"/></param>
        /// <returns><see cref="DescribeCiphersDetailResponse"/></returns>
        public async Task<DescribeCiphersDetailResponse> DescribeCiphersDetail(DescribeCiphersDetailRequest req)
        {
             JsonResponseModel<DescribeCiphersDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCiphersDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCiphersDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Saas型WAF接入查询加密套件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCiphersDetailRequest"/></param>
        /// <returns><see cref="DescribeCiphersDetailResponse"/></returns>
        public DescribeCiphersDetailResponse DescribeCiphersDetailSync(DescribeCiphersDetailRequest req)
        {
             JsonResponseModel<DescribeCiphersDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCiphersDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCiphersDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护配置中的访问控制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleListRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleListResponse"/></returns>
        public async Task<DescribeCustomRuleListResponse> DescribeCustomRuleList(DescribeCustomRuleListRequest req)
        {
             JsonResponseModel<DescribeCustomRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护配置中的访问控制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleListRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleListResponse"/></returns>
        public DescribeCustomRuleListResponse DescribeCustomRuleListSync(DescribeCustomRuleListRequest req)
        {
             JsonResponseModel<DescribeCustomRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护配置中的精准白名单策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeCustomWhiteRuleResponse"/></returns>
        public async Task<DescribeCustomWhiteRuleResponse> DescribeCustomWhiteRule(DescribeCustomWhiteRuleRequest req)
        {
             JsonResponseModel<DescribeCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护配置中的精准白名单策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeCustomWhiteRuleResponse"/></returns>
        public DescribeCustomWhiteRuleResponse DescribeCustomWhiteRuleSync(DescribeCustomWhiteRuleRequest req)
        {
             JsonResponseModel<DescribeCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名概况
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCountInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainCountInfoResponse"/></returns>
        public async Task<DescribeDomainCountInfoResponse> DescribeDomainCountInfo(DescribeDomainCountInfoRequest req)
        {
             JsonResponseModel<DescribeDomainCountInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainCountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainCountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名概况
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCountInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainCountInfoResponse"/></returns>
        public DescribeDomainCountInfoResponse DescribeDomainCountInfoSync(DescribeDomainCountInfoRequest req)
        {
             JsonResponseModel<DescribeDomainCountInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainCountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainCountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一个clbwaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsClbRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsClbResponse"/></returns>
        public async Task<DescribeDomainDetailsClbResponse> DescribeDomainDetailsClb(DescribeDomainDetailsClbRequest req)
        {
             JsonResponseModel<DescribeDomainDetailsClbResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainDetailsClb");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainDetailsClbResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一个clbwaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsClbRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsClbResponse"/></returns>
        public DescribeDomainDetailsClbResponse DescribeDomainDetailsClbSync(DescribeDomainDetailsClbRequest req)
        {
             JsonResponseModel<DescribeDomainDetailsClbResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainDetailsClb");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainDetailsClbResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个saaswaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsSaasRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsSaasResponse"/></returns>
        public async Task<DescribeDomainDetailsSaasResponse> DescribeDomainDetailsSaas(DescribeDomainDetailsSaasRequest req)
        {
             JsonResponseModel<DescribeDomainDetailsSaasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainDetailsSaas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainDetailsSaasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个saaswaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsSaasRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsSaasResponse"/></returns>
        public DescribeDomainDetailsSaasResponse DescribeDomainDetailsSaasSync(DescribeDomainDetailsSaasRequest req)
        {
             JsonResponseModel<DescribeDomainDetailsSaasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainDetailsSaas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainDetailsSaasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取域名的防护规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainRulesResponse"/></returns>
        public async Task<DescribeDomainRulesResponse> DescribeDomainRules(DescribeDomainRulesRequest req)
        {
             JsonResponseModel<DescribeDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取域名的防护规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainRulesResponse"/></returns>
        public DescribeDomainRulesResponse DescribeDomainRulesSync(DescribeDomainRulesRequest req)
        {
             JsonResponseModel<DescribeDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取添加域名操作的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeDomainVerifyResultResponse"/></returns>
        public async Task<DescribeDomainVerifyResultResponse> DescribeDomainVerifyResult(DescribeDomainVerifyResultRequest req)
        {
             JsonResponseModel<DescribeDomainVerifyResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainVerifyResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainVerifyResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取添加域名操作的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeDomainVerifyResultResponse"/></returns>
        public DescribeDomainVerifyResultResponse DescribeDomainVerifyResultSync(DescribeDomainVerifyResultRequest req)
        {
             JsonResponseModel<DescribeDomainVerifyResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainVerifyResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainVerifyResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名的规则白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainWhiteRulesResponse"/></returns>
        public async Task<DescribeDomainWhiteRulesResponse> DescribeDomainWhiteRules(DescribeDomainWhiteRulesRequest req)
        {
             JsonResponseModel<DescribeDomainWhiteRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainWhiteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainWhiteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名的规则白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainWhiteRulesResponse"/></returns>
        public DescribeDomainWhiteRulesResponse DescribeDomainWhiteRulesSync(DescribeDomainWhiteRulesRequest req)
        {
             JsonResponseModel<DescribeDomainWhiteRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainWhiteRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainWhiteRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户所有域名的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public async Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户所有域名的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取发现域名列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFindDomainListRequest"/></param>
        /// <returns><see cref="DescribeFindDomainListResponse"/></returns>
        public async Task<DescribeFindDomainListResponse> DescribeFindDomainList(DescribeFindDomainListRequest req)
        {
             JsonResponseModel<DescribeFindDomainListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFindDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFindDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取发现域名列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFindDomainListRequest"/></param>
        /// <returns><see cref="DescribeFindDomainListResponse"/></returns>
        public DescribeFindDomainListResponse DescribeFindDomainListSync(DescribeFindDomainListRequest req)
        {
             JsonResponseModel<DescribeFindDomainListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFindDomainList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFindDomainListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取waf流量访问趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTrendRequest"/></param>
        /// <returns><see cref="DescribeFlowTrendResponse"/></returns>
        public async Task<DescribeFlowTrendResponse> DescribeFlowTrend(DescribeFlowTrendRequest req)
        {
             JsonResponseModel<DescribeFlowTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取waf流量访问趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTrendRequest"/></param>
        /// <returns><see cref="DescribeFlowTrendResponse"/></returns>
        public DescribeFlowTrendResponse DescribeFlowTrendSync(DescribeFlowTrendRequest req)
        {
             JsonResponseModel<DescribeFlowTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf获取防护域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeHostRequest"/></param>
        /// <returns><see cref="DescribeHostResponse"/></returns>
        public async Task<DescribeHostResponse> DescribeHost(DescribeHostRequest req)
        {
             JsonResponseModel<DescribeHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf获取防护域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeHostRequest"/></param>
        /// <returns><see cref="DescribeHostResponse"/></returns>
        public DescribeHostResponse DescribeHostSync(DescribeHostRequest req)
        {
             JsonResponseModel<DescribeHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加域名的首先验证是否购买了套餐，是否没有达到购买套餐的限制，域名是否已经添加
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLimitRequest"/></param>
        /// <returns><see cref="DescribeHostLimitResponse"/></returns>
        public async Task<DescribeHostLimitResponse> DescribeHostLimit(DescribeHostLimitRequest req)
        {
             JsonResponseModel<DescribeHostLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加域名的首先验证是否购买了套餐，是否没有达到购买套餐的限制，域名是否已经添加
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLimitRequest"/></param>
        /// <returns><see cref="DescribeHostLimitResponse"/></returns>
        public DescribeHostLimitResponse DescribeHostLimitSync(DescribeHostLimitRequest req)
        {
             JsonResponseModel<DescribeHostLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf中获取防护域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public async Task<DescribeHostsResponse> DescribeHosts(DescribeHostsRequest req)
        {
             JsonResponseModel<DescribeHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf中获取防护域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public DescribeHostsResponse DescribeHostsSync(DescribeHostsRequest req)
        {
             JsonResponseModel<DescribeHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户所有实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户所有实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf ip黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeIpAccessControlResponse"/></returns>
        public async Task<DescribeIpAccessControlResponse> DescribeIpAccessControl(DescribeIpAccessControlRequest req)
        {
             JsonResponseModel<DescribeIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf ip黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeIpAccessControlResponse"/></returns>
        public DescribeIpAccessControlResponse DescribeIpAccessControlSync(DescribeIpAccessControlRequest req)
        {
             JsonResponseModel<DescribeIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  IP封堵状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpHitItemsRequest"/></param>
        /// <returns><see cref="DescribeIpHitItemsResponse"/></returns>
        public async Task<DescribeIpHitItemsResponse> DescribeIpHitItems(DescribeIpHitItemsRequest req)
        {
             JsonResponseModel<DescribeIpHitItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpHitItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpHitItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  IP封堵状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpHitItemsRequest"/></param>
        /// <returns><see cref="DescribeIpHitItemsResponse"/></returns>
        public DescribeIpHitItemsResponse DescribeIpHitItemsSync(DescribeIpHitItemsRequest req)
        {
             JsonResponseModel<DescribeIpHitItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpHitItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpHitItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看防护对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectsRequest"/></param>
        /// <returns><see cref="DescribeObjectsResponse"/></returns>
        public async Task<DescribeObjectsResponse> DescribeObjects(DescribeObjectsRequest req)
        {
             JsonResponseModel<DescribeObjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看防护对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectsRequest"/></param>
        /// <returns><see cref="DescribeObjectsResponse"/></returns>
        public DescribeObjectsResponse DescribeObjectsSync(DescribeObjectsRequest req)
        {
             JsonResponseModel<DescribeObjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询业务和攻击概要趋势
        /// </summary>
        /// <param name="req"><see cref="DescribePeakPointsRequest"/></param>
        /// <returns><see cref="DescribePeakPointsResponse"/></returns>
        public async Task<DescribePeakPointsResponse> DescribePeakPoints(DescribePeakPointsRequest req)
        {
             JsonResponseModel<DescribePeakPointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询业务和攻击概要趋势
        /// </summary>
        /// <param name="req"><see cref="DescribePeakPointsRequest"/></param>
        /// <returns><see cref="DescribePeakPointsResponse"/></returns>
        public DescribePeakPointsResponse DescribePeakPointsSync(DescribePeakPointsRequest req)
        {
             JsonResponseModel<DescribePeakPointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取业务和攻击概览峰值
        /// </summary>
        /// <param name="req"><see cref="DescribePeakValueRequest"/></param>
        /// <returns><see cref="DescribePeakValueResponse"/></returns>
        public async Task<DescribePeakValueResponse> DescribePeakValue(DescribePeakValueRequest req)
        {
             JsonResponseModel<DescribePeakValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取业务和攻击概览峰值
        /// </summary>
        /// <param name="req"><see cref="DescribePeakValueRequest"/></param>
        /// <returns><see cref="DescribePeakValueResponse"/></returns>
        public DescribePeakValueResponse DescribePeakValueSync(DescribePeakValueRequest req)
        {
             JsonResponseModel<DescribePeakValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护状态以及生效的实例id
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyStatusRequest"/></param>
        /// <returns><see cref="DescribePolicyStatusResponse"/></returns>
        public async Task<DescribePolicyStatusResponse> DescribePolicyStatus(DescribePolicyStatusRequest req)
        {
             JsonResponseModel<DescribePolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护状态以及生效的实例id
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyStatusRequest"/></param>
        /// <returns><see cref="DescribePolicyStatusResponse"/></returns>
        public DescribePolicyStatusResponse DescribePolicyStatusSync(DescribePolicyStatusRequest req)
        {
             JsonResponseModel<DescribePolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Saas型WAF防护端口列表
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public async Task<DescribePortsResponse> DescribePorts(DescribePortsRequest req)
        {
             JsonResponseModel<DescribePortsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePorts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePortsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Saas型WAF防护端口列表
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public DescribePortsResponse DescribePortsSync(DescribePortsRequest req)
        {
             JsonResponseModel<DescribePortsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePorts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePortsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各个模块具体的规格限制
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleLimitRequest"/></param>
        /// <returns><see cref="DescribeRuleLimitResponse"/></returns>
        public async Task<DescribeRuleLimitResponse> DescribeRuleLimit(DescribeRuleLimitRequest req)
        {
             JsonResponseModel<DescribeRuleLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各个模块具体的规格限制
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleLimitRequest"/></param>
        /// <returns><see cref="DescribeRuleLimitResponse"/></returns>
        public DescribeRuleLimitResponse DescribeRuleLimitSync(DescribeRuleLimitRequest req)
        {
             JsonResponseModel<DescribeRuleLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf 会话定义查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public async Task<DescribeSessionResponse> DescribeSession(DescribeSessionRequest req)
        {
             JsonResponseModel<DescribeSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf 会话定义查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public DescribeSessionResponse DescribeSessionSync(DescribeSessionRequest req)
        {
             JsonResponseModel<DescribeSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户TLS版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTlsVersionRequest"/></param>
        /// <returns><see cref="DescribeTlsVersionResponse"/></returns>
        public async Task<DescribeTlsVersionResponse> DescribeTlsVersion(DescribeTlsVersionRequest req)
        {
             JsonResponseModel<DescribeTlsVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTlsVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTlsVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户TLS版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTlsVersionRequest"/></param>
        /// <returns><see cref="DescribeTlsVersionResponse"/></returns>
        public DescribeTlsVersionResponse DescribeTlsVersionSync(DescribeTlsVersionRequest req)
        {
             JsonResponseModel<DescribeTlsVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTlsVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTlsVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在CDC场景下，负载均衡型WAF的添加、编辑域名配置的时候，需要展示CDC负载均衡型WAF（cdc-clb-waf)支持的地域列表，通过DescribeUserCdcClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCdcClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserCdcClbWafRegionsResponse"/></returns>
        public async Task<DescribeUserCdcClbWafRegionsResponse> DescribeUserCdcClbWafRegions(DescribeUserCdcClbWafRegionsRequest req)
        {
             JsonResponseModel<DescribeUserCdcClbWafRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCdcClbWafRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCdcClbWafRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在CDC场景下，负载均衡型WAF的添加、编辑域名配置的时候，需要展示CDC负载均衡型WAF（cdc-clb-waf)支持的地域列表，通过DescribeUserCdcClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCdcClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserCdcClbWafRegionsResponse"/></returns>
        public DescribeUserCdcClbWafRegionsResponse DescribeUserCdcClbWafRegionsSync(DescribeUserCdcClbWafRegionsRequest req)
        {
             JsonResponseModel<DescribeUserCdcClbWafRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserCdcClbWafRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCdcClbWafRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在负载均衡型WAF的添加、编辑域名配置的时候，需要展示负载均衡型WAF（clb-waf)支持的地域列表，通过DescribeUserClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public async Task<DescribeUserClbWafRegionsResponse> DescribeUserClbWafRegions(DescribeUserClbWafRegionsRequest req)
        {
             JsonResponseModel<DescribeUserClbWafRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserClbWafRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserClbWafRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在负载均衡型WAF的添加、编辑域名配置的时候，需要展示负载均衡型WAF（clb-waf)支持的地域列表，通过DescribeUserClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public DescribeUserClbWafRegionsResponse DescribeUserClbWafRegionsSync(DescribeUserClbWafRegionsRequest req)
        {
             JsonResponseModel<DescribeUserClbWafRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserClbWafRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserClbWafRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询saas和clb的域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeUserDomainInfoResponse"/></returns>
        public async Task<DescribeUserDomainInfoResponse> DescribeUserDomainInfo(DescribeUserDomainInfoRequest req)
        {
             JsonResponseModel<DescribeUserDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询saas和clb的域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeUserDomainInfoResponse"/></returns>
        public DescribeUserDomainInfoResponse DescribeUserDomainInfoSync(DescribeUserDomainInfoRequest req)
        {
             JsonResponseModel<DescribeUserDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户特征规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureRuleRequest"/></param>
        /// <returns><see cref="DescribeUserSignatureRuleResponse"/></returns>
        public async Task<DescribeUserSignatureRuleResponse> DescribeUserSignatureRule(DescribeUserSignatureRuleRequest req)
        {
             JsonResponseModel<DescribeUserSignatureRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserSignatureRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserSignatureRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户特征规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureRuleRequest"/></param>
        /// <returns><see cref="DescribeUserSignatureRuleResponse"/></returns>
        public DescribeUserSignatureRuleResponse DescribeUserSignatureRuleSync(DescribeUserSignatureRuleRequest req)
        {
             JsonResponseModel<DescribeUserSignatureRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserSignatureRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserSignatureRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据过滤条件查询VIP信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVipInfoRequest"/></param>
        /// <returns><see cref="DescribeVipInfoResponse"/></returns>
        public async Task<DescribeVipInfoResponse> DescribeVipInfo(DescribeVipInfoRequest req)
        {
             JsonResponseModel<DescribeVipInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVipInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVipInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据过滤条件查询VIP信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVipInfoRequest"/></param>
        /// <returns><see cref="DescribeVipInfoResponse"/></returns>
        public DescribeVipInfoResponse DescribeVipInfoSync(DescribeVipInfoRequest req)
        {
             JsonResponseModel<DescribeVipInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVipInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVipInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回ip惩罚规则详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyRulesResponse"/></returns>
        public async Task<DescribeWafAutoDenyRulesResponse> DescribeWafAutoDenyRules(DescribeWafAutoDenyRulesRequest req)
        {
             JsonResponseModel<DescribeWafAutoDenyRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWafAutoDenyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafAutoDenyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回ip惩罚规则详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyRulesResponse"/></returns>
        public DescribeWafAutoDenyRulesResponse DescribeWafAutoDenyRulesSync(DescribeWafAutoDenyRulesRequest req)
        {
             JsonResponseModel<DescribeWafAutoDenyRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWafAutoDenyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafAutoDenyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述WAF自动封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyStatusRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyStatusResponse"/></returns>
        public async Task<DescribeWafAutoDenyStatusResponse> DescribeWafAutoDenyStatus(DescribeWafAutoDenyStatusRequest req)
        {
             JsonResponseModel<DescribeWafAutoDenyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWafAutoDenyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafAutoDenyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述WAF自动封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyStatusRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyStatusResponse"/></returns>
        public DescribeWafAutoDenyStatusResponse DescribeWafAutoDenyStatusSync(DescribeWafAutoDenyStatusRequest req)
        {
             JsonResponseModel<DescribeWafAutoDenyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWafAutoDenyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafAutoDenyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取负载均衡绑定的WAF信息，可以根据租户负载均衡实例ID、负载均衡监听器ID、负载均衡的域名信息来查询对应绑定的 Waf的状态信息。
        /// 查询的范围：负载均衡实例ID、负载均衡实例ID+监听器ID、负载均衡实例ID+监听器ID+域名。
        /// 可能的错误码：ResourceNotFound（没有找到对应的资源）、UnsupportedRegion（目前clb-waf只支持北京、广州、上海、成都、重庆、香港地域）。
        /// </summary>
        /// <param name="req"><see cref="DescribeWafInfoRequest"/></param>
        /// <returns><see cref="DescribeWafInfoResponse"/></returns>
        public async Task<DescribeWafInfoResponse> DescribeWafInfo(DescribeWafInfoRequest req)
        {
             JsonResponseModel<DescribeWafInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWafInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取负载均衡绑定的WAF信息，可以根据租户负载均衡实例ID、负载均衡监听器ID、负载均衡的域名信息来查询对应绑定的 Waf的状态信息。
        /// 查询的范围：负载均衡实例ID、负载均衡实例ID+监听器ID、负载均衡实例ID+监听器ID+域名。
        /// 可能的错误码：ResourceNotFound（没有找到对应的资源）、UnsupportedRegion（目前clb-waf只支持北京、广州、上海、成都、重庆、香港地域）。
        /// </summary>
        /// <param name="req"><see cref="DescribeWafInfoRequest"/></param>
        /// <returns><see cref="DescribeWafInfoResponse"/></returns>
        public DescribeWafInfoResponse DescribeWafInfoSync(DescribeWafInfoRequest req)
        {
             JsonResponseModel<DescribeWafInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWafInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述WAF威胁情报封禁模块配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="DescribeWafThreatenIntelligenceResponse"/></returns>
        public async Task<DescribeWafThreatenIntelligenceResponse> DescribeWafThreatenIntelligence(DescribeWafThreatenIntelligenceRequest req)
        {
             JsonResponseModel<DescribeWafThreatenIntelligenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWafThreatenIntelligence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafThreatenIntelligenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述WAF威胁情报封禁模块配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="DescribeWafThreatenIntelligenceResponse"/></returns>
        public DescribeWafThreatenIntelligenceResponse DescribeWafThreatenIntelligenceSync(DescribeWafThreatenIntelligenceRequest req)
        {
             JsonResponseModel<DescribeWafThreatenIntelligenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWafThreatenIntelligence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWafThreatenIntelligenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新防篡改url
        /// </summary>
        /// <param name="req"><see cref="FreshAntiFakeUrlRequest"/></param>
        /// <returns><see cref="FreshAntiFakeUrlResponse"/></returns>
        public async Task<FreshAntiFakeUrlResponse> FreshAntiFakeUrl(FreshAntiFakeUrlRequest req)
        {
             JsonResponseModel<FreshAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FreshAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreshAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新防篡改url
        /// </summary>
        /// <param name="req"><see cref="FreshAntiFakeUrlRequest"/></param>
        /// <returns><see cref="FreshAntiFakeUrlResponse"/></returns>
        public FreshAntiFakeUrlResponse FreshAntiFakeUrlSync(FreshAntiFakeUrlRequest req)
        {
             JsonResponseModel<FreshAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FreshAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreshAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 计费资源购买、续费下单接口
        /// </summary>
        /// <param name="req"><see cref="GenerateDealsAndPayNewRequest"/></param>
        /// <returns><see cref="GenerateDealsAndPayNewResponse"/></returns>
        public async Task<GenerateDealsAndPayNewResponse> GenerateDealsAndPayNew(GenerateDealsAndPayNewRequest req)
        {
             JsonResponseModel<GenerateDealsAndPayNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateDealsAndPayNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateDealsAndPayNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 计费资源购买、续费下单接口
        /// </summary>
        /// <param name="req"><see cref="GenerateDealsAndPayNewRequest"/></param>
        /// <returns><see cref="GenerateDealsAndPayNewResponse"/></returns>
        public GenerateDealsAndPayNewResponse GenerateDealsAndPayNewSync(GenerateDealsAndPayNewRequest req)
        {
             JsonResponseModel<GenerateDealsAndPayNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateDealsAndPayNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateDealsAndPayNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询下载攻击日志任务记录列表
        /// </summary>
        /// <param name="req"><see cref="GetAttackDownloadRecordsRequest"/></param>
        /// <returns><see cref="GetAttackDownloadRecordsResponse"/></returns>
        public async Task<GetAttackDownloadRecordsResponse> GetAttackDownloadRecords(GetAttackDownloadRecordsRequest req)
        {
             JsonResponseModel<GetAttackDownloadRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAttackDownloadRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttackDownloadRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询下载攻击日志任务记录列表
        /// </summary>
        /// <param name="req"><see cref="GetAttackDownloadRecordsRequest"/></param>
        /// <returns><see cref="GetAttackDownloadRecordsResponse"/></returns>
        public GetAttackDownloadRecordsResponse GetAttackDownloadRecordsSync(GetAttackDownloadRecordsRequest req)
        {
             JsonResponseModel<GetAttackDownloadRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAttackDownloadRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttackDownloadRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成攻击日志的产生时间柱状图
        /// </summary>
        /// <param name="req"><see cref="GetAttackHistogramRequest"/></param>
        /// <returns><see cref="GetAttackHistogramResponse"/></returns>
        public async Task<GetAttackHistogramResponse> GetAttackHistogram(GetAttackHistogramRequest req)
        {
             JsonResponseModel<GetAttackHistogramResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAttackHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttackHistogramResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成攻击日志的产生时间柱状图
        /// </summary>
        /// <param name="req"><see cref="GetAttackHistogramRequest"/></param>
        /// <returns><see cref="GetAttackHistogramResponse"/></returns>
        public GetAttackHistogramResponse GetAttackHistogramSync(GetAttackHistogramRequest req)
        {
             JsonResponseModel<GetAttackHistogramResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAttackHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttackHistogramResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照条件查询展示攻击总次数
        /// </summary>
        /// <param name="req"><see cref="GetAttackTotalCountRequest"/></param>
        /// <returns><see cref="GetAttackTotalCountResponse"/></returns>
        public async Task<GetAttackTotalCountResponse> GetAttackTotalCount(GetAttackTotalCountRequest req)
        {
             JsonResponseModel<GetAttackTotalCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAttackTotalCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttackTotalCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照条件查询展示攻击总次数
        /// </summary>
        /// <param name="req"><see cref="GetAttackTotalCountRequest"/></param>
        /// <returns><see cref="GetAttackTotalCountResponse"/></returns>
        public GetAttackTotalCountResponse GetAttackTotalCountSync(GetAttackTotalCountRequest req)
        {
             JsonResponseModel<GetAttackTotalCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAttackTotalCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAttackTotalCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="GetInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="GetInstanceQpsLimitResponse"/></returns>
        public async Task<GetInstanceQpsLimitResponse> GetInstanceQpsLimit(GetInstanceQpsLimitRequest req)
        {
             JsonResponseModel<GetInstanceQpsLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetInstanceQpsLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInstanceQpsLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="GetInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="GetInstanceQpsLimitResponse"/></returns>
        public GetInstanceQpsLimitResponse GetInstanceQpsLimitSync(GetInstanceQpsLimitRequest req)
        {
             JsonResponseModel<GetInstanceQpsLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetInstanceQpsLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInstanceQpsLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改访问日志保存期限及大字段是否存储
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessPeriodRequest"/></param>
        /// <returns><see cref="ModifyAccessPeriodResponse"/></returns>
        public async Task<ModifyAccessPeriodResponse> ModifyAccessPeriod(ModifyAccessPeriodRequest req)
        {
             JsonResponseModel<ModifyAccessPeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccessPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改访问日志保存期限及大字段是否存储
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessPeriodRequest"/></param>
        /// <returns><see cref="ModifyAccessPeriodResponse"/></returns>
        public ModifyAccessPeriodResponse ModifyAccessPeriodSync(ModifyAccessPeriodRequest req)
        {
             JsonResponseModel<ModifyAccessPeriodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccessPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑防篡改url
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlResponse"/></returns>
        public async Task<ModifyAntiFakeUrlResponse> ModifyAntiFakeUrl(ModifyAntiFakeUrlRequest req)
        {
             JsonResponseModel<ModifyAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑防篡改url
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlResponse"/></returns>
        public ModifyAntiFakeUrlResponse ModifyAntiFakeUrlSync(ModifyAntiFakeUrlRequest req)
        {
             JsonResponseModel<ModifyAntiFakeUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAntiFakeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiFakeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换防篡改开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlStatusResponse"/></returns>
        public async Task<ModifyAntiFakeUrlStatusResponse> ModifyAntiFakeUrlStatus(ModifyAntiFakeUrlStatusRequest req)
        {
             JsonResponseModel<ModifyAntiFakeUrlStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAntiFakeUrlStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiFakeUrlStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换防篡改开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlStatusResponse"/></returns>
        public ModifyAntiFakeUrlStatusResponse ModifyAntiFakeUrlStatusSync(ModifyAntiFakeUrlStatusRequest req)
        {
             JsonResponseModel<ModifyAntiFakeUrlStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAntiFakeUrlStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiFakeUrlStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 信息防泄漏切换规则开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRuleStatusResponse"/></returns>
        public async Task<ModifyAntiInfoLeakRuleStatusResponse> ModifyAntiInfoLeakRuleStatus(ModifyAntiInfoLeakRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAntiInfoLeakRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAntiInfoLeakRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiInfoLeakRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 信息防泄漏切换规则开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRuleStatusResponse"/></returns>
        public ModifyAntiInfoLeakRuleStatusResponse ModifyAntiInfoLeakRuleStatusSync(ModifyAntiInfoLeakRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAntiInfoLeakRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAntiInfoLeakRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiInfoLeakRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRulesResponse"/></returns>
        public async Task<ModifyAntiInfoLeakRulesResponse> ModifyAntiInfoLeakRules(ModifyAntiInfoLeakRulesRequest req)
        {
             JsonResponseModel<ModifyAntiInfoLeakRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAntiInfoLeakRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiInfoLeakRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRulesResponse"/></returns>
        public ModifyAntiInfoLeakRulesResponse ModifyAntiInfoLeakRulesSync(ModifyAntiInfoLeakRulesRequest req)
        {
             JsonResponseModel<ModifyAntiInfoLeakRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAntiInfoLeakRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAntiInfoLeakRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// api分析页面开关
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAnalyzeStatusRequest"/></param>
        /// <returns><see cref="ModifyApiAnalyzeStatusResponse"/></returns>
        public async Task<ModifyApiAnalyzeStatusResponse> ModifyApiAnalyzeStatus(ModifyApiAnalyzeStatusRequest req)
        {
             JsonResponseModel<ModifyApiAnalyzeStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApiAnalyzeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiAnalyzeStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// api分析页面开关
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAnalyzeStatusRequest"/></param>
        /// <returns><see cref="ModifyApiAnalyzeStatusResponse"/></returns>
        public ModifyApiAnalyzeStatusResponse ModifyApiAnalyzeStatusSync(ModifyApiAnalyzeStatusRequest req)
        {
             JsonResponseModel<ModifyApiAnalyzeStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApiAnalyzeStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApiAnalyzeStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改防护域名的地域封禁状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanStatusRequest"/></param>
        /// <returns><see cref="ModifyAreaBanStatusResponse"/></returns>
        public async Task<ModifyAreaBanStatusResponse> ModifyAreaBanStatus(ModifyAreaBanStatusRequest req)
        {
             JsonResponseModel<ModifyAreaBanStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAreaBanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAreaBanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改防护域名的地域封禁状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanStatusRequest"/></param>
        /// <returns><see cref="ModifyAreaBanStatusResponse"/></returns>
        public ModifyAreaBanStatusResponse ModifyAreaBanStatusSync(ModifyAreaBanStatusRequest req)
        {
             JsonResponseModel<ModifyAreaBanStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAreaBanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAreaBanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 供用户控制台调用，修改Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyAttackWhiteRuleResponse"/></returns>
        public async Task<ModifyAttackWhiteRuleResponse> ModifyAttackWhiteRule(ModifyAttackWhiteRuleRequest req)
        {
             JsonResponseModel<ModifyAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 供用户控制台调用，修改Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyAttackWhiteRuleResponse"/></returns>
        public ModifyAttackWhiteRuleResponse ModifyAttackWhiteRuleSync(ModifyAttackWhiteRuleRequest req)
        {
             JsonResponseModel<ModifyAttackWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAttackWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAttackWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bot_V2 bot总开关更新
        /// </summary>
        /// <param name="req"><see cref="ModifyBotStatusRequest"/></param>
        /// <returns><see cref="ModifyBotStatusResponse"/></returns>
        public async Task<ModifyBotStatusResponse> ModifyBotStatus(ModifyBotStatusRequest req)
        {
             JsonResponseModel<ModifyBotStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBotStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBotStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Bot_V2 bot总开关更新
        /// </summary>
        /// <param name="req"><see cref="ModifyBotStatusRequest"/></param>
        /// <returns><see cref="ModifyBotStatusResponse"/></returns>
        public ModifyBotStatusResponse ModifyBotStatusSync(ModifyBotStatusRequest req)
        {
             JsonResponseModel<ModifyBotStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBotStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBotStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑自定义规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public async Task<ModifyCustomRuleResponse> ModifyCustomRule(ModifyCustomRuleRequest req)
        {
             JsonResponseModel<ModifyCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑自定义规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public ModifyCustomRuleResponse ModifyCustomRuleSync(ModifyCustomRuleRequest req)
        {
             JsonResponseModel<ModifyCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或禁用访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public async Task<ModifyCustomRuleStatusResponse> ModifyCustomRuleStatus(ModifyCustomRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或禁用访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public ModifyCustomRuleStatusResponse ModifyCustomRuleStatusSync(ModifyCustomRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleResponse"/></returns>
        public async Task<ModifyCustomWhiteRuleResponse> ModifyCustomWhiteRule(ModifyCustomWhiteRuleRequest req)
        {
             JsonResponseModel<ModifyCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleResponse"/></returns>
        public ModifyCustomWhiteRuleResponse ModifyCustomWhiteRuleSync(ModifyCustomWhiteRuleRequest req)
        {
             JsonResponseModel<ModifyCustomWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或禁用精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleStatusResponse"/></returns>
        public async Task<ModifyCustomWhiteRuleStatusResponse> ModifyCustomWhiteRuleStatus(ModifyCustomWhiteRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomWhiteRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomWhiteRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomWhiteRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或禁用精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleStatusResponse"/></returns>
        public ModifyCustomWhiteRuleStatusResponse ModifyCustomWhiteRuleStatusSync(ModifyCustomWhiteRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomWhiteRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomWhiteRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomWhiteRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换ipv6开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainIpv6StatusRequest"/></param>
        /// <returns><see cref="ModifyDomainIpv6StatusResponse"/></returns>
        public async Task<ModifyDomainIpv6StatusResponse> ModifyDomainIpv6Status(ModifyDomainIpv6StatusRequest req)
        {
             JsonResponseModel<ModifyDomainIpv6StatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainIpv6Status");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainIpv6StatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换ipv6开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainIpv6StatusRequest"/></param>
        /// <returns><see cref="ModifyDomainIpv6StatusResponse"/></returns>
        public ModifyDomainIpv6StatusResponse ModifyDomainIpv6StatusSync(ModifyDomainIpv6StatusRequest req)
        {
             JsonResponseModel<ModifyDomainIpv6StatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainIpv6Status");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainIpv6StatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改某一条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyDomainWhiteRuleResponse"/></returns>
        public async Task<ModifyDomainWhiteRuleResponse> ModifyDomainWhiteRule(ModifyDomainWhiteRuleRequest req)
        {
             JsonResponseModel<ModifyDomainWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改某一条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyDomainWhiteRuleResponse"/></returns>
        public ModifyDomainWhiteRuleResponse ModifyDomainWhiteRuleSync(ModifyDomainWhiteRuleRequest req)
        {
             JsonResponseModel<ModifyDomainWhiteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainWhiteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainWhiteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名列表的访问日志开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainsCLSStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainsCLSStatusResponse"/></returns>
        public async Task<ModifyDomainsCLSStatusResponse> ModifyDomainsCLSStatus(ModifyDomainsCLSStatusRequest req)
        {
             JsonResponseModel<ModifyDomainsCLSStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainsCLSStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainsCLSStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名列表的访问日志开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainsCLSStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainsCLSStatusResponse"/></returns>
        public ModifyDomainsCLSStatusResponse ModifyDomainsCLSStatusSync(ModifyDomainsCLSStatusRequest req)
        {
             JsonResponseModel<ModifyDomainsCLSStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainsCLSStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainsCLSStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf编辑防护域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifyHostRequest"/></param>
        /// <returns><see cref="ModifyHostResponse"/></returns>
        public async Task<ModifyHostResponse> ModifyHost(ModifyHostRequest req)
        {
             JsonResponseModel<ModifyHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf编辑防护域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifyHostRequest"/></param>
        /// <returns><see cref="ModifyHostResponse"/></returns>
        public ModifyHostResponse ModifyHostSync(ModifyHostRequest req)
        {
             JsonResponseModel<ModifyHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf 设置防护域名的流量模式
        /// </summary>
        /// <param name="req"><see cref="ModifyHostFlowModeRequest"/></param>
        /// <returns><see cref="ModifyHostFlowModeResponse"/></returns>
        public async Task<ModifyHostFlowModeResponse> ModifyHostFlowMode(ModifyHostFlowModeRequest req)
        {
             JsonResponseModel<ModifyHostFlowModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHostFlowMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostFlowModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf 设置防护域名的流量模式
        /// </summary>
        /// <param name="req"><see cref="ModifyHostFlowModeRequest"/></param>
        /// <returns><see cref="ModifyHostFlowModeResponse"/></returns>
        public ModifyHostFlowModeResponse ModifyHostFlowModeSync(ModifyHostFlowModeRequest req)
        {
             JsonResponseModel<ModifyHostFlowModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHostFlowMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostFlowModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf设置防护域名防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyHostModeRequest"/></param>
        /// <returns><see cref="ModifyHostModeResponse"/></returns>
        public async Task<ModifyHostModeResponse> ModifyHostMode(ModifyHostModeRequest req)
        {
             JsonResponseModel<ModifyHostModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHostMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf设置防护域名防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyHostModeRequest"/></param>
        /// <returns><see cref="ModifyHostModeResponse"/></returns>
        public ModifyHostModeResponse ModifyHostModeSync(ModifyHostModeRequest req)
        {
             JsonResponseModel<ModifyHostModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHostMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf 设置防护域名WAF开关
        /// 支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyHostStatusRequest"/></param>
        /// <returns><see cref="ModifyHostStatusResponse"/></returns>
        public async Task<ModifyHostStatusResponse> ModifyHostStatus(ModifyHostStatusRequest req)
        {
             JsonResponseModel<ModifyHostStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHostStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// clb-waf 设置防护域名WAF开关
        /// 支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyHostStatusRequest"/></param>
        /// <returns><see cref="ModifyHostStatusResponse"/></returns>
        public ModifyHostStatusResponse ModifyHostStatusSync(ModifyHostStatusRequest req)
        {
             JsonResponseModel<ModifyHostStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHostStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHostStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的QPS弹性计费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceElasticModeRequest"/></param>
        /// <returns><see cref="ModifyInstanceElasticModeResponse"/></returns>
        public async Task<ModifyInstanceElasticModeResponse> ModifyInstanceElasticMode(ModifyInstanceElasticModeRequest req)
        {
             JsonResponseModel<ModifyInstanceElasticModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceElasticMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceElasticModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的QPS弹性计费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceElasticModeRequest"/></param>
        /// <returns><see cref="ModifyInstanceElasticModeResponse"/></returns>
        public ModifyInstanceElasticModeResponse ModifyInstanceElasticModeSync(ModifyInstanceElasticModeRequest req)
        {
             JsonResponseModel<ModifyInstanceElasticModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceElasticMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceElasticModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public async Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
             JsonResponseModel<ModifyInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
             JsonResponseModel<ModifyInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="ModifyInstanceQpsLimitResponse"/></returns>
        public async Task<ModifyInstanceQpsLimitResponse> ModifyInstanceQpsLimit(ModifyInstanceQpsLimitRequest req)
        {
             JsonResponseModel<ModifyInstanceQpsLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceQpsLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceQpsLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="ModifyInstanceQpsLimitResponse"/></returns>
        public ModifyInstanceQpsLimitResponse ModifyInstanceQpsLimitSync(ModifyInstanceQpsLimitRequest req)
        {
             JsonResponseModel<ModifyInstanceQpsLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceQpsLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceQpsLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的自动续费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstanceRenewFlagResponse"/></returns>
        public async Task<ModifyInstanceRenewFlagResponse> ModifyInstanceRenewFlag(ModifyInstanceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstanceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例的自动续费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstanceRenewFlagResponse"/></returns>
        public ModifyInstanceRenewFlagResponse ModifyInstanceRenewFlagSync(ModifyInstanceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyInstanceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置某个domain下基础安全模块的开关
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleStatusRequest"/></param>
        /// <returns><see cref="ModifyModuleStatusResponse"/></returns>
        public async Task<ModifyModuleStatusResponse> ModifyModuleStatus(ModifyModuleStatusRequest req)
        {
             JsonResponseModel<ModifyModuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置某个domain下基础安全模块的开关
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleStatusRequest"/></param>
        /// <returns><see cref="ModifyModuleStatusResponse"/></returns>
        public ModifyModuleStatusResponse ModifyModuleStatusSync(ModifyModuleStatusRequest req)
        {
             JsonResponseModel<ModifyModuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改防护对象
        /// </summary>
        /// <param name="req"><see cref="ModifyObjectRequest"/></param>
        /// <returns><see cref="ModifyObjectResponse"/></returns>
        public async Task<ModifyObjectResponse> ModifyObject(ModifyObjectRequest req)
        {
             JsonResponseModel<ModifyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改防护对象
        /// </summary>
        /// <param name="req"><see cref="ModifyObjectRequest"/></param>
        /// <returns><see cref="ModifyObjectResponse"/></returns>
        public ModifyObjectResponse ModifyObjectSync(ModifyObjectRequest req)
        {
             JsonResponseModel<ModifyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// waf斯巴达-waf开关
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionStatusRequest"/></param>
        /// <returns><see cref="ModifyProtectionStatusResponse"/></returns>
        public async Task<ModifyProtectionStatusResponse> ModifyProtectionStatus(ModifyProtectionStatusRequest req)
        {
             JsonResponseModel<ModifyProtectionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProtectionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProtectionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// waf斯巴达-waf开关
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionStatusRequest"/></param>
        /// <returns><see cref="ModifyProtectionStatusResponse"/></returns>
        public ModifyProtectionStatusResponse ModifyProtectionStatusSync(ModifyProtectionStatusRequest req)
        {
             JsonResponseModel<ModifyProtectionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProtectionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProtectionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionResponse"/></returns>
        public async Task<ModifySpartaProtectionResponse> ModifySpartaProtection(ModifySpartaProtectionRequest req)
        {
             JsonResponseModel<ModifySpartaProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySpartaProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySpartaProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionResponse"/></returns>
        public ModifySpartaProtectionResponse ModifySpartaProtectionSync(ModifySpartaProtectionRequest req)
        {
             JsonResponseModel<ModifySpartaProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySpartaProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySpartaProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置waf防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionModeRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionModeResponse"/></returns>
        public async Task<ModifySpartaProtectionModeResponse> ModifySpartaProtectionMode(ModifySpartaProtectionModeRequest req)
        {
             JsonResponseModel<ModifySpartaProtectionModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySpartaProtectionMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySpartaProtectionModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置waf防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionModeRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionModeResponse"/></returns>
        public ModifySpartaProtectionModeResponse ModifySpartaProtectionModeSync(ModifySpartaProtectionModeRequest req)
        {
             JsonResponseModel<ModifySpartaProtectionModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySpartaProtectionMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySpartaProtectionModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户防护规则等级
        /// </summary>
        /// <param name="req"><see cref="ModifyUserLevelRequest"/></param>
        /// <returns><see cref="ModifyUserLevelResponse"/></returns>
        public async Task<ModifyUserLevelResponse> ModifyUserLevel(ModifyUserLevelRequest req)
        {
             JsonResponseModel<ModifyUserLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户防护规则等级
        /// </summary>
        /// <param name="req"><see cref="ModifyUserLevelRequest"/></param>
        /// <returns><see cref="ModifyUserLevelResponse"/></returns>
        public ModifyUserLevelResponse ModifyUserLevelSync(ModifyUserLevelRequest req)
        {
             JsonResponseModel<ModifyUserLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户防护规则，开启关闭具体的某条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleResponse"/></returns>
        public async Task<ModifyUserSignatureRuleResponse> ModifyUserSignatureRule(ModifyUserSignatureRuleRequest req)
        {
             JsonResponseModel<ModifyUserSignatureRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserSignatureRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserSignatureRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户防护规则，开启关闭具体的某条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleResponse"/></returns>
        public ModifyUserSignatureRuleResponse ModifyUserSignatureRuleSync(ModifyUserSignatureRuleRequest req)
        {
             JsonResponseModel<ModifyUserSignatureRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserSignatureRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserSignatureRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改ip惩罚规则
        /// </summary>
        /// <param name="req"><see cref="ModifyWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="ModifyWafAutoDenyRulesResponse"/></returns>
        public async Task<ModifyWafAutoDenyRulesResponse> ModifyWafAutoDenyRules(ModifyWafAutoDenyRulesRequest req)
        {
             JsonResponseModel<ModifyWafAutoDenyRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWafAutoDenyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWafAutoDenyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改ip惩罚规则
        /// </summary>
        /// <param name="req"><see cref="ModifyWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="ModifyWafAutoDenyRulesResponse"/></returns>
        public ModifyWafAutoDenyRulesResponse ModifyWafAutoDenyRulesSync(ModifyWafAutoDenyRulesRequest req)
        {
             JsonResponseModel<ModifyWafAutoDenyRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWafAutoDenyRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWafAutoDenyRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置WAF自动封禁模块状态
        /// </summary>
        /// <param name="req"><see cref="ModifyWafAutoDenyStatusRequest"/></param>
        /// <returns><see cref="ModifyWafAutoDenyStatusResponse"/></returns>
        public async Task<ModifyWafAutoDenyStatusResponse> ModifyWafAutoDenyStatus(ModifyWafAutoDenyStatusRequest req)
        {
             JsonResponseModel<ModifyWafAutoDenyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWafAutoDenyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWafAutoDenyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置WAF自动封禁模块状态
        /// </summary>
        /// <param name="req"><see cref="ModifyWafAutoDenyStatusRequest"/></param>
        /// <returns><see cref="ModifyWafAutoDenyStatusResponse"/></returns>
        public ModifyWafAutoDenyStatusResponse ModifyWafAutoDenyStatusSync(ModifyWafAutoDenyStatusRequest req)
        {
             JsonResponseModel<ModifyWafAutoDenyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWafAutoDenyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWafAutoDenyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置WAF威胁情报封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="ModifyWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="ModifyWafThreatenIntelligenceResponse"/></returns>
        public async Task<ModifyWafThreatenIntelligenceResponse> ModifyWafThreatenIntelligence(ModifyWafThreatenIntelligenceRequest req)
        {
             JsonResponseModel<ModifyWafThreatenIntelligenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWafThreatenIntelligence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWafThreatenIntelligenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置WAF威胁情报封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="ModifyWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="ModifyWafThreatenIntelligenceResponse"/></returns>
        public ModifyWafThreatenIntelligenceResponse ModifyWafThreatenIntelligenceSync(ModifyWafThreatenIntelligenceRequest req)
        {
             JsonResponseModel<ModifyWafThreatenIntelligenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWafThreatenIntelligence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWafThreatenIntelligenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置域名的webshell状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebshellStatusRequest"/></param>
        /// <returns><see cref="ModifyWebshellStatusResponse"/></returns>
        public async Task<ModifyWebshellStatusResponse> ModifyWebshellStatus(ModifyWebshellStatusRequest req)
        {
             JsonResponseModel<ModifyWebshellStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebshellStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebshellStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置域名的webshell状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebshellStatusRequest"/></param>
        /// <returns><see cref="ModifyWebshellStatusResponse"/></returns>
        public ModifyWebshellStatusResponse ModifyWebshellStatusSync(ModifyWebshellStatusRequest req)
        {
             JsonResponseModel<ModifyWebshellStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebshellStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebshellStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建搜索下载攻击日志任务，使用CLS新版本的搜索下载getlog接口
        /// </summary>
        /// <param name="req"><see cref="PostAttackDownloadTaskRequest"/></param>
        /// <returns><see cref="PostAttackDownloadTaskResponse"/></returns>
        public async Task<PostAttackDownloadTaskResponse> PostAttackDownloadTask(PostAttackDownloadTaskRequest req)
        {
             JsonResponseModel<PostAttackDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PostAttackDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PostAttackDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建搜索下载攻击日志任务，使用CLS新版本的搜索下载getlog接口
        /// </summary>
        /// <param name="req"><see cref="PostAttackDownloadTaskRequest"/></param>
        /// <returns><see cref="PostAttackDownloadTaskResponse"/></returns>
        public PostAttackDownloadTaskResponse PostAttackDownloadTaskSync(PostAttackDownloadTaskRequest req)
        {
             JsonResponseModel<PostAttackDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PostAttackDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PostAttackDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新接入检查的结果，后台会生成接入检查任务
        /// </summary>
        /// <param name="req"><see cref="RefreshAccessCheckResultRequest"/></param>
        /// <returns><see cref="RefreshAccessCheckResultResponse"/></returns>
        public async Task<RefreshAccessCheckResultResponse> RefreshAccessCheckResult(RefreshAccessCheckResultRequest req)
        {
             JsonResponseModel<RefreshAccessCheckResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefreshAccessCheckResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshAccessCheckResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新接入检查的结果，后台会生成接入检查任务
        /// </summary>
        /// <param name="req"><see cref="RefreshAccessCheckResultRequest"/></param>
        /// <returns><see cref="RefreshAccessCheckResultResponse"/></returns>
        public RefreshAccessCheckResultResponse RefreshAccessCheckResultSync(RefreshAccessCheckResultRequest req)
        {
             JsonResponseModel<RefreshAccessCheckResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefreshAccessCheckResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshAccessCheckResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于搜索WAF访问日志
        /// </summary>
        /// <param name="req"><see cref="SearchAccessLogRequest"/></param>
        /// <returns><see cref="SearchAccessLogResponse"/></returns>
        public async Task<SearchAccessLogResponse> SearchAccessLog(SearchAccessLogRequest req)
        {
             JsonResponseModel<SearchAccessLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchAccessLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchAccessLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于搜索WAF访问日志
        /// </summary>
        /// <param name="req"><see cref="SearchAccessLogRequest"/></param>
        /// <returns><see cref="SearchAccessLogResponse"/></returns>
        public SearchAccessLogResponse SearchAccessLogSync(SearchAccessLogRequest req)
        {
             JsonResponseModel<SearchAccessLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchAccessLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchAccessLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新版本CLS接口存在参数变化，query改成了query_string支持lucence语法接口搜索查询。
        /// </summary>
        /// <param name="req"><see cref="SearchAttackLogRequest"/></param>
        /// <returns><see cref="SearchAttackLogResponse"/></returns>
        public async Task<SearchAttackLogResponse> SearchAttackLog(SearchAttackLogRequest req)
        {
             JsonResponseModel<SearchAttackLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchAttackLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchAttackLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新版本CLS接口存在参数变化，query改成了query_string支持lucence语法接口搜索查询。
        /// </summary>
        /// <param name="req"><see cref="SearchAttackLogRequest"/></param>
        /// <returns><see cref="SearchAttackLogResponse"/></returns>
        public SearchAttackLogResponse SearchAttackLogSync(SearchAttackLogRequest req)
        {
             JsonResponseModel<SearchAttackLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchAttackLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchAttackLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换域名的规则开关
        /// </summary>
        /// <param name="req"><see cref="SwitchDomainRulesRequest"/></param>
        /// <returns><see cref="SwitchDomainRulesResponse"/></returns>
        public async Task<SwitchDomainRulesResponse> SwitchDomainRules(SwitchDomainRulesRequest req)
        {
             JsonResponseModel<SwitchDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换域名的规则开关
        /// </summary>
        /// <param name="req"><see cref="SwitchDomainRulesRequest"/></param>
        /// <returns><see cref="SwitchDomainRulesResponse"/></returns>
        public SwitchDomainRulesResponse SwitchDomainRulesSync(SwitchDomainRulesRequest req)
        {
             JsonResponseModel<SwitchDomainRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDomainRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDomainRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换弹性的开关
        /// </summary>
        /// <param name="req"><see cref="SwitchElasticModeRequest"/></param>
        /// <returns><see cref="SwitchElasticModeResponse"/></returns>
        public async Task<SwitchElasticModeResponse> SwitchElasticMode(SwitchElasticModeRequest req)
        {
             JsonResponseModel<SwitchElasticModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchElasticMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchElasticModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换弹性的开关
        /// </summary>
        /// <param name="req"><see cref="SwitchElasticModeRequest"/></param>
        /// <returns><see cref="SwitchElasticModeResponse"/></returns>
        public SwitchElasticModeResponse SwitchElasticModeSync(SwitchElasticModeRequest req)
        {
             JsonResponseModel<SwitchElasticModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchElasticMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchElasticModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  CC V2 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertCCRuleRequest"/></param>
        /// <returns><see cref="UpsertCCRuleResponse"/></returns>
        public async Task<UpsertCCRuleResponse> UpsertCCRule(UpsertCCRuleRequest req)
        {
             JsonResponseModel<UpsertCCRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpsertCCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpsertCCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  CC V2 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertCCRuleRequest"/></param>
        /// <returns><see cref="UpsertCCRuleResponse"/></returns>
        public UpsertCCRuleResponse UpsertCCRuleSync(UpsertCCRuleRequest req)
        {
             JsonResponseModel<UpsertCCRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpsertCCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpsertCCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf IP黑白名单Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertIpAccessControlRequest"/></param>
        /// <returns><see cref="UpsertIpAccessControlResponse"/></returns>
        public async Task<UpsertIpAccessControlResponse> UpsertIpAccessControl(UpsertIpAccessControlRequest req)
        {
             JsonResponseModel<UpsertIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpsertIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpsertIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf IP黑白名单Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertIpAccessControlRequest"/></param>
        /// <returns><see cref="UpsertIpAccessControlResponse"/></returns>
        public UpsertIpAccessControlResponse UpsertIpAccessControlSync(UpsertIpAccessControlRequest req)
        {
             JsonResponseModel<UpsertIpAccessControlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpsertIpAccessControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpsertIpAccessControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  会话定义 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertSessionRequest"/></param>
        /// <returns><see cref="UpsertSessionResponse"/></returns>
        public async Task<UpsertSessionResponse> UpsertSession(UpsertSessionRequest req)
        {
             JsonResponseModel<UpsertSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpsertSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpsertSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Waf  会话定义 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertSessionRequest"/></param>
        /// <returns><see cref="UpsertSessionResponse"/></returns>
        public UpsertSessionResponse UpsertSessionSync(UpsertSessionRequest req)
        {
             JsonResponseModel<UpsertSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpsertSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpsertSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
