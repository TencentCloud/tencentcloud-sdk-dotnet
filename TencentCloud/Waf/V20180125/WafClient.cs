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
        /// 增加自定义策略
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
        /// 增加自定义策略
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
        /// 添加Spart防护域名
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
        /// 添加Spart防护域名
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
        /// 删除域名规则白名单
        /// 
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
        /// 
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
        /// 查询单个saas域名详情
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
        /// 查询单个saas域名详情
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
        /// 获取域名的规则白名单
        /// 
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
        /// 
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
        /// 本接口用于修改访问日志保存期限
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
        /// 本接口用于修改访问日志保存期限
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
        /// 开启或禁用自定义策略
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
        /// 开启或禁用自定义策略
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

    }
}
