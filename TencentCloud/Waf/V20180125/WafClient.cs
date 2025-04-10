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
       private const string sdkVersion = "SDK_NET_3.0.1219";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WafClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加防篡改url
        /// </summary>
        /// <param name="req"><see cref="AddAntiFakeUrlRequest"/></param>
        /// <returns><see cref="AddAntiFakeUrlResponse"/></returns>
        public Task<AddAntiFakeUrlResponse> AddAntiFakeUrl(AddAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<AddAntiFakeUrlResponse>(req, "AddAntiFakeUrl");
        }

        /// <summary>
        /// 添加防篡改url
        /// </summary>
        /// <param name="req"><see cref="AddAntiFakeUrlRequest"/></param>
        /// <returns><see cref="AddAntiFakeUrlResponse"/></returns>
        public AddAntiFakeUrlResponse AddAntiFakeUrlSync(AddAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<AddAntiFakeUrlResponse>(req, "AddAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="AddAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="AddAntiInfoLeakRulesResponse"/></returns>
        public Task<AddAntiInfoLeakRulesResponse> AddAntiInfoLeakRules(AddAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<AddAntiInfoLeakRulesResponse>(req, "AddAntiInfoLeakRules");
        }

        /// <summary>
        /// 添加信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="AddAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="AddAntiInfoLeakRulesResponse"/></returns>
        public AddAntiInfoLeakRulesResponse AddAntiInfoLeakRulesSync(AddAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<AddAntiInfoLeakRulesResponse>(req, "AddAntiInfoLeakRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="AddAreaBanAreasRequest"/></param>
        /// <returns><see cref="AddAreaBanAreasResponse"/></returns>
        public Task<AddAreaBanAreasResponse> AddAreaBanAreas(AddAreaBanAreasRequest req)
        {
            return InternalRequestAsync<AddAreaBanAreasResponse>(req, "AddAreaBanAreas");
        }

        /// <summary>
        /// 添加地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="AddAreaBanAreasRequest"/></param>
        /// <returns><see cref="AddAreaBanAreasResponse"/></returns>
        public AddAreaBanAreasResponse AddAreaBanAreasSync(AddAreaBanAreasRequest req)
        {
            return InternalRequestAsync<AddAreaBanAreasResponse>(req, "AddAreaBanAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 供用户控制台调用，增加Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="AddAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="AddAttackWhiteRuleResponse"/></returns>
        public Task<AddAttackWhiteRuleResponse> AddAttackWhiteRule(AddAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddAttackWhiteRuleResponse>(req, "AddAttackWhiteRule");
        }

        /// <summary>
        /// 供用户控制台调用，增加Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="AddAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="AddAttackWhiteRuleResponse"/></returns>
        public AddAttackWhiteRuleResponse AddAttackWhiteRuleSync(AddAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddAttackWhiteRuleResponse>(req, "AddAttackWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public Task<AddCustomRuleResponse> AddCustomRule(AddCustomRuleRequest req)
        {
            return InternalRequestAsync<AddCustomRuleResponse>(req, "AddCustomRule");
        }

        /// <summary>
        /// 增加访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public AddCustomRuleResponse AddCustomRuleSync(AddCustomRuleRequest req)
        {
            return InternalRequestAsync<AddCustomRuleResponse>(req, "AddCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="AddCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="AddCustomWhiteRuleResponse"/></returns>
        public Task<AddCustomWhiteRuleResponse> AddCustomWhiteRule(AddCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddCustomWhiteRuleResponse>(req, "AddCustomWhiteRule");
        }

        /// <summary>
        /// 增加精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="AddCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="AddCustomWhiteRuleResponse"/></returns>
        public AddCustomWhiteRuleResponse AddCustomWhiteRuleSync(AddCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddCustomWhiteRuleResponse>(req, "AddCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="AddDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="AddDomainWhiteRuleResponse"/></returns>
        public Task<AddDomainWhiteRuleResponse> AddDomainWhiteRule(AddDomainWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddDomainWhiteRuleResponse>(req, "AddDomainWhiteRule");
        }

        /// <summary>
        /// 增加域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="AddDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="AddDomainWhiteRuleResponse"/></returns>
        public AddDomainWhiteRuleResponse AddDomainWhiteRuleSync(AddDomainWhiteRuleRequest req)
        {
            return InternalRequestAsync<AddDomainWhiteRuleResponse>(req, "AddDomainWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加SaaS型WAF防护域名
        /// </summary>
        /// <param name="req"><see cref="AddSpartaProtectionRequest"/></param>
        /// <returns><see cref="AddSpartaProtectionResponse"/></returns>
        public Task<AddSpartaProtectionResponse> AddSpartaProtection(AddSpartaProtectionRequest req)
        {
            return InternalRequestAsync<AddSpartaProtectionResponse>(req, "AddSpartaProtection");
        }

        /// <summary>
        /// 添加SaaS型WAF防护域名
        /// </summary>
        /// <param name="req"><see cref="AddSpartaProtectionRequest"/></param>
        /// <returns><see cref="AddSpartaProtectionResponse"/></returns>
        public AddSpartaProtectionResponse AddSpartaProtectionSync(AddSpartaProtectionRequest req)
        {
            return InternalRequestAsync<AddSpartaProtectionResponse>(req, "AddSpartaProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量操作tiga子规则
        /// </summary>
        /// <param name="req"><see cref="BatchOperateUserSignatureRulesRequest"/></param>
        /// <returns><see cref="BatchOperateUserSignatureRulesResponse"/></returns>
        public Task<BatchOperateUserSignatureRulesResponse> BatchOperateUserSignatureRules(BatchOperateUserSignatureRulesRequest req)
        {
            return InternalRequestAsync<BatchOperateUserSignatureRulesResponse>(req, "BatchOperateUserSignatureRules");
        }

        /// <summary>
        /// 批量操作tiga子规则
        /// </summary>
        /// <param name="req"><see cref="BatchOperateUserSignatureRulesRequest"/></param>
        /// <returns><see cref="BatchOperateUserSignatureRulesResponse"/></returns>
        public BatchOperateUserSignatureRulesResponse BatchOperateUserSignatureRulesSync(BatchOperateUserSignatureRulesRequest req)
        {
            return InternalRequestAsync<BatchOperateUserSignatureRulesResponse>(req, "BatchOperateUserSignatureRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建访问日志导出
        /// </summary>
        /// <param name="req"><see cref="CreateAccessExportRequest"/></param>
        /// <returns><see cref="CreateAccessExportResponse"/></returns>
        public Task<CreateAccessExportResponse> CreateAccessExport(CreateAccessExportRequest req)
        {
            return InternalRequestAsync<CreateAccessExportResponse>(req, "CreateAccessExport");
        }

        /// <summary>
        /// 本接口用于创建访问日志导出
        /// </summary>
        /// <param name="req"><see cref="CreateAccessExportRequest"/></param>
        /// <returns><see cref="CreateAccessExportResponse"/></returns>
        public CreateAccessExportResponse CreateAccessExportSync(CreateAccessExportRequest req)
        {
            return InternalRequestAsync<CreateAccessExportResponse>(req, "CreateAccessExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加（编辑）地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="CreateAreaBanRuleRequest"/></param>
        /// <returns><see cref="CreateAreaBanRuleResponse"/></returns>
        public Task<CreateAreaBanRuleResponse> CreateAreaBanRule(CreateAreaBanRuleRequest req)
        {
            return InternalRequestAsync<CreateAreaBanRuleResponse>(req, "CreateAreaBanRule");
        }

        /// <summary>
        /// 添加（编辑）地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="CreateAreaBanRuleRequest"/></param>
        /// <returns><see cref="CreateAreaBanRuleResponse"/></returns>
        public CreateAreaBanRuleResponse CreateAreaBanRuleSync(CreateAreaBanRuleRequest req)
        {
            return InternalRequestAsync<CreateAreaBanRuleResponse>(req, "CreateAreaBanRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 计费资源购买、续费下单接口
        /// </summary>
        /// <param name="req"><see cref="CreateDealsRequest"/></param>
        /// <returns><see cref="CreateDealsResponse"/></returns>
        public Task<CreateDealsResponse> CreateDeals(CreateDealsRequest req)
        {
            return InternalRequestAsync<CreateDealsResponse>(req, "CreateDeals");
        }

        /// <summary>
        /// 计费资源购买、续费下单接口
        /// </summary>
        /// <param name="req"><see cref="CreateDealsRequest"/></param>
        /// <returns><see cref="CreateDealsResponse"/></returns>
        public CreateDealsResponse CreateDealsSync(CreateDealsRequest req)
        {
            return InternalRequestAsync<CreateDealsResponse>(req, "CreateDeals")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// clb-waf中添加防护域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostRequest"/></param>
        /// <returns><see cref="CreateHostResponse"/></returns>
        public Task<CreateHostResponse> CreateHost(CreateHostRequest req)
        {
            return InternalRequestAsync<CreateHostResponse>(req, "CreateHost");
        }

        /// <summary>
        /// clb-waf中添加防护域名
        /// </summary>
        /// <param name="req"><see cref="CreateHostRequest"/></param>
        /// <returns><see cref="CreateHostResponse"/></returns>
        public CreateHostResponse CreateHostSync(CreateHostRequest req)
        {
            return InternalRequestAsync<CreateHostResponse>(req, "CreateHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf IP黑白名单新增接口
        /// </summary>
        /// <param name="req"><see cref="CreateIpAccessControlRequest"/></param>
        /// <returns><see cref="CreateIpAccessControlResponse"/></returns>
        public Task<CreateIpAccessControlResponse> CreateIpAccessControl(CreateIpAccessControlRequest req)
        {
            return InternalRequestAsync<CreateIpAccessControlResponse>(req, "CreateIpAccessControl");
        }

        /// <summary>
        /// Waf IP黑白名单新增接口
        /// </summary>
        /// <param name="req"><see cref="CreateIpAccessControlRequest"/></param>
        /// <returns><see cref="CreateIpAccessControlResponse"/></returns>
        public CreateIpAccessControlResponse CreateIpAccessControlSync(CreateIpAccessControlRequest req)
        {
            return InternalRequestAsync<CreateIpAccessControlResponse>(req, "CreateIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建CKafka投递流任务
        /// </summary>
        /// <param name="req"><see cref="CreatePostCKafkaFlowRequest"/></param>
        /// <returns><see cref="CreatePostCKafkaFlowResponse"/></returns>
        public Task<CreatePostCKafkaFlowResponse> CreatePostCKafkaFlow(CreatePostCKafkaFlowRequest req)
        {
            return InternalRequestAsync<CreatePostCKafkaFlowResponse>(req, "CreatePostCKafkaFlow");
        }

        /// <summary>
        /// 创建CKafka投递流任务
        /// </summary>
        /// <param name="req"><see cref="CreatePostCKafkaFlowRequest"/></param>
        /// <returns><see cref="CreatePostCKafkaFlowResponse"/></returns>
        public CreatePostCKafkaFlowResponse CreatePostCKafkaFlowSync(CreatePostCKafkaFlowRequest req)
        {
            return InternalRequestAsync<CreatePostCKafkaFlowResponse>(req, "CreatePostCKafkaFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建CLS投递流任务
        /// </summary>
        /// <param name="req"><see cref="CreatePostCLSFlowRequest"/></param>
        /// <returns><see cref="CreatePostCLSFlowResponse"/></returns>
        public Task<CreatePostCLSFlowResponse> CreatePostCLSFlow(CreatePostCLSFlowRequest req)
        {
            return InternalRequestAsync<CreatePostCLSFlowResponse>(req, "CreatePostCLSFlow");
        }

        /// <summary>
        /// 创建CLS投递流任务
        /// </summary>
        /// <param name="req"><see cref="CreatePostCLSFlowRequest"/></param>
        /// <returns><see cref="CreatePostCLSFlowResponse"/></returns>
        public CreatePostCLSFlowResponse CreatePostCLSFlowSync(CreatePostCLSFlowRequest req)
        {
            return InternalRequestAsync<CreatePostCLSFlowResponse>(req, "CreatePostCLSFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除访问日志导出
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessExportRequest"/></param>
        /// <returns><see cref="DeleteAccessExportResponse"/></returns>
        public Task<DeleteAccessExportResponse> DeleteAccessExport(DeleteAccessExportRequest req)
        {
            return InternalRequestAsync<DeleteAccessExportResponse>(req, "DeleteAccessExport");
        }

        /// <summary>
        /// 本接口用于删除访问日志导出
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessExportRequest"/></param>
        /// <returns><see cref="DeleteAccessExportResponse"/></returns>
        public DeleteAccessExportResponse DeleteAccessExportSync(DeleteAccessExportRequest req)
        {
            return InternalRequestAsync<DeleteAccessExportResponse>(req, "DeleteAccessExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除防篡改url
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DeleteAntiFakeUrlResponse"/></returns>
        public Task<DeleteAntiFakeUrlResponse> DeleteAntiFakeUrl(DeleteAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<DeleteAntiFakeUrlResponse>(req, "DeleteAntiFakeUrl");
        }

        /// <summary>
        /// 删除防篡改url
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiFakeUrlRequest"/></param>
        /// <returns><see cref="DeleteAntiFakeUrlResponse"/></returns>
        public DeleteAntiFakeUrlResponse DeleteAntiFakeUrlSync(DeleteAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<DeleteAntiFakeUrlResponse>(req, "DeleteAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 信息防泄漏删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiInfoLeakRuleRequest"/></param>
        /// <returns><see cref="DeleteAntiInfoLeakRuleResponse"/></returns>
        public Task<DeleteAntiInfoLeakRuleResponse> DeleteAntiInfoLeakRule(DeleteAntiInfoLeakRuleRequest req)
        {
            return InternalRequestAsync<DeleteAntiInfoLeakRuleResponse>(req, "DeleteAntiInfoLeakRule");
        }

        /// <summary>
        /// 信息防泄漏删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAntiInfoLeakRuleRequest"/></param>
        /// <returns><see cref="DeleteAntiInfoLeakRuleResponse"/></returns>
        public DeleteAntiInfoLeakRuleResponse DeleteAntiInfoLeakRuleSync(DeleteAntiInfoLeakRuleRequest req)
        {
            return InternalRequestAsync<DeleteAntiInfoLeakRuleResponse>(req, "DeleteAntiInfoLeakRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除攻击日志下载任务记录
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteAttackDownloadRecordResponse"/></returns>
        public Task<DeleteAttackDownloadRecordResponse> DeleteAttackDownloadRecord(DeleteAttackDownloadRecordRequest req)
        {
            return InternalRequestAsync<DeleteAttackDownloadRecordResponse>(req, "DeleteAttackDownloadRecord");
        }

        /// <summary>
        /// 删除攻击日志下载任务记录
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteAttackDownloadRecordResponse"/></returns>
        public DeleteAttackDownloadRecordResponse DeleteAttackDownloadRecordSync(DeleteAttackDownloadRecordRequest req)
        {
            return InternalRequestAsync<DeleteAttackDownloadRecordResponse>(req, "DeleteAttackDownloadRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 供用户控制台调用，删除Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteAttackWhiteRuleResponse"/></returns>
        public Task<DeleteAttackWhiteRuleResponse> DeleteAttackWhiteRule(DeleteAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteAttackWhiteRuleResponse>(req, "DeleteAttackWhiteRule");
        }

        /// <summary>
        /// 供用户控制台调用，删除Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteAttackWhiteRuleResponse"/></returns>
        public DeleteAttackWhiteRuleResponse DeleteAttackWhiteRuleSync(DeleteAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteAttackWhiteRuleResponse>(req, "DeleteAttackWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf  CC V2 Delete接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRuleRequest"/></param>
        /// <returns><see cref="DeleteCCRuleResponse"/></returns>
        public Task<DeleteCCRuleResponse> DeleteCCRule(DeleteCCRuleRequest req)
        {
            return InternalRequestAsync<DeleteCCRuleResponse>(req, "DeleteCCRule");
        }

        /// <summary>
        /// Waf  CC V2 Delete接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCCRuleRequest"/></param>
        /// <returns><see cref="DeleteCCRuleResponse"/></returns>
        public DeleteCCRuleResponse DeleteCCRuleSync(DeleteCCRuleRequest req)
        {
            return InternalRequestAsync<DeleteCCRuleResponse>(req, "DeleteCCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomRuleResponse"/></returns>
        public Task<DeleteCustomRuleResponse> DeleteCustomRule(DeleteCustomRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomRuleResponse>(req, "DeleteCustomRule");
        }

        /// <summary>
        /// 删除自定义规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomRuleResponse"/></returns>
        public DeleteCustomRuleResponse DeleteCustomRuleSync(DeleteCustomRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomRuleResponse>(req, "DeleteCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomWhiteRuleResponse"/></returns>
        public Task<DeleteCustomWhiteRuleResponse> DeleteCustomWhiteRule(DeleteCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomWhiteRuleResponse>(req, "DeleteCustomWhiteRule");
        }

        /// <summary>
        /// 删除精准白名单规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DeleteCustomWhiteRuleResponse"/></returns>
        public DeleteCustomWhiteRuleResponse DeleteCustomWhiteRuleSync(DeleteCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DeleteCustomWhiteRuleResponse>(req, "DeleteCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DeleteDomainWhiteRulesResponse"/></returns>
        public Task<DeleteDomainWhiteRulesResponse> DeleteDomainWhiteRules(DeleteDomainWhiteRulesRequest req)
        {
            return InternalRequestAsync<DeleteDomainWhiteRulesResponse>(req, "DeleteDomainWhiteRules");
        }

        /// <summary>
        /// 删除域名规则白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DeleteDomainWhiteRulesResponse"/></returns>
        public DeleteDomainWhiteRulesResponse DeleteDomainWhiteRulesSync(DeleteDomainWhiteRulesRequest req)
        {
            return InternalRequestAsync<DeleteDomainWhiteRulesResponse>(req, "DeleteDomainWhiteRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除负载均衡型域名，支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteHostRequest"/></param>
        /// <returns><see cref="DeleteHostResponse"/></returns>
        public Task<DeleteHostResponse> DeleteHost(DeleteHostRequest req)
        {
            return InternalRequestAsync<DeleteHostResponse>(req, "DeleteHost");
        }

        /// <summary>
        /// 删除负载均衡型域名，支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteHostRequest"/></param>
        /// <returns><see cref="DeleteHostResponse"/></returns>
        public DeleteHostResponse DeleteHostSync(DeleteHostRequest req)
        {
            return InternalRequestAsync<DeleteHostResponse>(req, "DeleteHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf IP黑白名单Delete接口（建议使用DeleteIpAccessControlV2来替换当前接口）
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlRequest"/></param>
        /// <returns><see cref="DeleteIpAccessControlResponse"/></returns>
        public Task<DeleteIpAccessControlResponse> DeleteIpAccessControl(DeleteIpAccessControlRequest req)
        {
            return InternalRequestAsync<DeleteIpAccessControlResponse>(req, "DeleteIpAccessControl");
        }

        /// <summary>
        /// Waf IP黑白名单Delete接口（建议使用DeleteIpAccessControlV2来替换当前接口）
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlRequest"/></param>
        /// <returns><see cref="DeleteIpAccessControlResponse"/></returns>
        public DeleteIpAccessControlResponse DeleteIpAccessControlSync(DeleteIpAccessControlRequest req)
        {
            return InternalRequestAsync<DeleteIpAccessControlResponse>(req, "DeleteIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf IP黑白名单最新版本删除接口
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlV2Request"/></param>
        /// <returns><see cref="DeleteIpAccessControlV2Response"/></returns>
        public Task<DeleteIpAccessControlV2Response> DeleteIpAccessControlV2(DeleteIpAccessControlV2Request req)
        {
            return InternalRequestAsync<DeleteIpAccessControlV2Response>(req, "DeleteIpAccessControlV2");
        }

        /// <summary>
        /// Waf IP黑白名单最新版本删除接口
        /// </summary>
        /// <param name="req"><see cref="DeleteIpAccessControlV2Request"/></param>
        /// <returns><see cref="DeleteIpAccessControlV2Response"/></returns>
        public DeleteIpAccessControlV2Response DeleteIpAccessControlV2Sync(DeleteIpAccessControlV2Request req)
        {
            return InternalRequestAsync<DeleteIpAccessControlV2Response>(req, "DeleteIpAccessControlV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC攻击的session设置
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public Task<DeleteSessionResponse> DeleteSession(DeleteSessionRequest req)
        {
            return InternalRequestAsync<DeleteSessionResponse>(req, "DeleteSession");
        }

        /// <summary>
        /// 删除CC攻击的session设置
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public DeleteSessionResponse DeleteSessionSync(DeleteSessionRequest req)
        {
            return InternalRequestAsync<DeleteSessionResponse>(req, "DeleteSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SaaS型WAF删除防护域名
        /// </summary>
        /// <param name="req"><see cref="DeleteSpartaProtectionRequest"/></param>
        /// <returns><see cref="DeleteSpartaProtectionResponse"/></returns>
        public Task<DeleteSpartaProtectionResponse> DeleteSpartaProtection(DeleteSpartaProtectionRequest req)
        {
            return InternalRequestAsync<DeleteSpartaProtectionResponse>(req, "DeleteSpartaProtection");
        }

        /// <summary>
        /// SaaS型WAF删除防护域名
        /// </summary>
        /// <param name="req"><see cref="DeleteSpartaProtectionRequest"/></param>
        /// <returns><see cref="DeleteSpartaProtectionResponse"/></returns>
        public DeleteSpartaProtectionResponse DeleteSpartaProtectionSync(DeleteSpartaProtectionRequest req)
        {
            return InternalRequestAsync<DeleteSpartaProtectionResponse>(req, "DeleteSpartaProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取访问日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessExportsRequest"/></param>
        /// <returns><see cref="DescribeAccessExportsResponse"/></returns>
        public Task<DescribeAccessExportsResponse> DescribeAccessExports(DescribeAccessExportsRequest req)
        {
            return InternalRequestAsync<DescribeAccessExportsResponse>(req, "DescribeAccessExports");
        }

        /// <summary>
        /// 本接口用于获取访问日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessExportsRequest"/></param>
        /// <returns><see cref="DescribeAccessExportsResponse"/></returns>
        public DescribeAccessExportsResponse DescribeAccessExportsSync(DescribeAccessExportsRequest req)
        {
            return InternalRequestAsync<DescribeAccessExportsResponse>(req, "DescribeAccessExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于访问日志的快速分析
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeAccessFastAnalysisResponse"/></returns>
        public Task<DescribeAccessFastAnalysisResponse> DescribeAccessFastAnalysis(DescribeAccessFastAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeAccessFastAnalysisResponse>(req, "DescribeAccessFastAnalysis");
        }

        /// <summary>
        /// 本接口用于访问日志的快速分析
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeAccessFastAnalysisResponse"/></returns>
        public DescribeAccessFastAnalysisResponse DescribeAccessFastAnalysisSync(DescribeAccessFastAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeAccessFastAnalysisResponse>(req, "DescribeAccessFastAnalysis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于访问日志柱状趋势图
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessHistogramRequest"/></param>
        /// <returns><see cref="DescribeAccessHistogramResponse"/></returns>
        public Task<DescribeAccessHistogramResponse> DescribeAccessHistogram(DescribeAccessHistogramRequest req)
        {
            return InternalRequestAsync<DescribeAccessHistogramResponse>(req, "DescribeAccessHistogram");
        }

        /// <summary>
        /// 本接口用于访问日志柱状趋势图
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessHistogramRequest"/></param>
        /// <returns><see cref="DescribeAccessHistogramResponse"/></returns>
        public DescribeAccessHistogramResponse DescribeAccessHistogramSync(DescribeAccessHistogramRequest req)
        {
            return InternalRequestAsync<DescribeAccessHistogramResponse>(req, "DescribeAccessHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取访问日志索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessIndexRequest"/></param>
        /// <returns><see cref="DescribeAccessIndexResponse"/></returns>
        public Task<DescribeAccessIndexResponse> DescribeAccessIndex(DescribeAccessIndexRequest req)
        {
            return InternalRequestAsync<DescribeAccessIndexResponse>(req, "DescribeAccessIndex");
        }

        /// <summary>
        /// 本接口用于获取访问日志索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessIndexRequest"/></param>
        /// <returns><see cref="DescribeAccessIndexResponse"/></returns>
        public DescribeAccessIndexResponse DescribeAccessIndexSync(DescribeAccessIndexRequest req)
        {
            return InternalRequestAsync<DescribeAccessIndexResponse>(req, "DescribeAccessIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防篡改url
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeRulesResponse"/></returns>
        public Task<DescribeAntiFakeRulesResponse> DescribeAntiFakeRules(DescribeAntiFakeRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiFakeRulesResponse>(req, "DescribeAntiFakeRules");
        }

        /// <summary>
        /// 获取防篡改url
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFakeRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiFakeRulesResponse"/></returns>
        public DescribeAntiFakeRulesResponse DescribeAntiFakeRulesSync(DescribeAntiFakeRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiFakeRulesResponse>(req, "DescribeAntiFakeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取得信息防泄漏规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakageRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakageRulesResponse"/></returns>
        public Task<DescribeAntiInfoLeakageRulesResponse> DescribeAntiInfoLeakageRules(DescribeAntiInfoLeakageRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiInfoLeakageRulesResponse>(req, "DescribeAntiInfoLeakageRules");
        }

        /// <summary>
        /// 取得信息防泄漏规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiInfoLeakageRulesRequest"/></param>
        /// <returns><see cref="DescribeAntiInfoLeakageRulesResponse"/></returns>
        public DescribeAntiInfoLeakageRulesResponse DescribeAntiInfoLeakageRulesSync(DescribeAntiInfoLeakageRulesRequest req)
        {
            return InternalRequestAsync<DescribeAntiInfoLeakageRulesResponse>(req, "DescribeAntiInfoLeakageRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Api请求详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApiDetailRequest"/></param>
        /// <returns><see cref="DescribeApiDetailResponse"/></returns>
        public Task<DescribeApiDetailResponse> DescribeApiDetail(DescribeApiDetailRequest req)
        {
            return InternalRequestAsync<DescribeApiDetailResponse>(req, "DescribeApiDetail");
        }

        /// <summary>
        /// 获取Api请求详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApiDetailRequest"/></param>
        /// <returns><see cref="DescribeApiDetailResponse"/></returns>
        public DescribeApiDetailResponse DescribeApiDetailSync(DescribeApiDetailRequest req)
        {
            return InternalRequestAsync<DescribeApiDetailResponse>(req, "DescribeApiDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// api资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApiListVersionTwoRequest"/></param>
        /// <returns><see cref="DescribeApiListVersionTwoResponse"/></returns>
        public Task<DescribeApiListVersionTwoResponse> DescribeApiListVersionTwo(DescribeApiListVersionTwoRequest req)
        {
            return InternalRequestAsync<DescribeApiListVersionTwoResponse>(req, "DescribeApiListVersionTwo");
        }

        /// <summary>
        /// api资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApiListVersionTwoRequest"/></param>
        /// <returns><see cref="DescribeApiListVersionTwoResponse"/></returns>
        public DescribeApiListVersionTwoResponse DescribeApiListVersionTwoSync(DescribeApiListVersionTwoRequest req)
        {
            return InternalRequestAsync<DescribeApiListVersionTwoResponse>(req, "DescribeApiListVersionTwo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取地域封禁配置包括地域封禁开关，设置封禁的地区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBanAreasRequest"/></param>
        /// <returns><see cref="DescribeAreaBanAreasResponse"/></returns>
        public Task<DescribeAreaBanAreasResponse> DescribeAreaBanAreas(DescribeAreaBanAreasRequest req)
        {
            return InternalRequestAsync<DescribeAreaBanAreasResponse>(req, "DescribeAreaBanAreas");
        }

        /// <summary>
        /// 获取地域封禁配置包括地域封禁开关，设置封禁的地区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBanAreasRequest"/></param>
        /// <returns><see cref="DescribeAreaBanAreasResponse"/></returns>
        public DescribeAreaBanAreasResponse DescribeAreaBanAreasSync(DescribeAreaBanAreasRequest req)
        {
            return InternalRequestAsync<DescribeAreaBanAreasResponse>(req, "DescribeAreaBanAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取地域封禁规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBanRuleRequest"/></param>
        /// <returns><see cref="DescribeAreaBanRuleResponse"/></returns>
        public Task<DescribeAreaBanRuleResponse> DescribeAreaBanRule(DescribeAreaBanRuleRequest req)
        {
            return InternalRequestAsync<DescribeAreaBanRuleResponse>(req, "DescribeAreaBanRule");
        }

        /// <summary>
        /// 获取地域封禁规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBanRuleRequest"/></param>
        /// <returns><see cref="DescribeAreaBanRuleResponse"/></returns>
        public DescribeAreaBanRuleResponse DescribeAreaBanRuleSync(DescribeAreaBanRuleRequest req)
        {
            return InternalRequestAsync<DescribeAreaBanRuleResponse>(req, "DescribeAreaBanRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取WAF地域封禁支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBanSupportAreasRequest"/></param>
        /// <returns><see cref="DescribeAreaBanSupportAreasResponse"/></returns>
        public Task<DescribeAreaBanSupportAreasResponse> DescribeAreaBanSupportAreas(DescribeAreaBanSupportAreasRequest req)
        {
            return InternalRequestAsync<DescribeAreaBanSupportAreasResponse>(req, "DescribeAreaBanSupportAreas");
        }

        /// <summary>
        /// 获取WAF地域封禁支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAreaBanSupportAreasRequest"/></param>
        /// <returns><see cref="DescribeAreaBanSupportAreasResponse"/></returns>
        public DescribeAreaBanSupportAreasResponse DescribeAreaBanSupportAreasSync(DescribeAreaBanSupportAreasRequest req)
        {
            return InternalRequestAsync<DescribeAreaBanSupportAreasResponse>(req, "DescribeAreaBanSupportAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 攻击总览
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackOverviewRequest"/></param>
        /// <returns><see cref="DescribeAttackOverviewResponse"/></returns>
        public Task<DescribeAttackOverviewResponse> DescribeAttackOverview(DescribeAttackOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAttackOverviewResponse>(req, "DescribeAttackOverview");
        }

        /// <summary>
        /// 攻击总览
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackOverviewRequest"/></param>
        /// <returns><see cref="DescribeAttackOverviewResponse"/></returns>
        public DescribeAttackOverviewResponse DescribeAttackOverviewSync(DescribeAttackOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAttackOverviewResponse>(req, "DescribeAttackOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定域名TOP N攻击类型
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTypeRequest"/></param>
        /// <returns><see cref="DescribeAttackTypeResponse"/></returns>
        public Task<DescribeAttackTypeResponse> DescribeAttackType(DescribeAttackTypeRequest req)
        {
            return InternalRequestAsync<DescribeAttackTypeResponse>(req, "DescribeAttackType");
        }

        /// <summary>
        /// 查询指定域名TOP N攻击类型
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTypeRequest"/></param>
        /// <returns><see cref="DescribeAttackTypeResponse"/></returns>
        public DescribeAttackTypeResponse DescribeAttackTypeSync(DescribeAttackTypeRequest req)
        {
            return InternalRequestAsync<DescribeAttackTypeResponse>(req, "DescribeAttackType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户规则白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeAttackWhiteRuleResponse"/></returns>
        public Task<DescribeAttackWhiteRuleResponse> DescribeAttackWhiteRule(DescribeAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeAttackWhiteRuleResponse>(req, "DescribeAttackWhiteRule");
        }

        /// <summary>
        /// 获取用户规则白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeAttackWhiteRuleResponse"/></returns>
        public DescribeAttackWhiteRuleResponse DescribeAttackWhiteRuleSync(DescribeAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeAttackWhiteRuleResponse>(req, "DescribeAttackWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 描述WAF自动封禁IP详情,对齐自动封堵状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoDenyIPRequest"/></param>
        /// <returns><see cref="DescribeAutoDenyIPResponse"/></returns>
        public Task<DescribeAutoDenyIPResponse> DescribeAutoDenyIP(DescribeAutoDenyIPRequest req)
        {
            return InternalRequestAsync<DescribeAutoDenyIPResponse>(req, "DescribeAutoDenyIP");
        }

        /// <summary>
        /// 描述WAF自动封禁IP详情,对齐自动封堵状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoDenyIPRequest"/></param>
        /// <returns><see cref="DescribeAutoDenyIPResponse"/></returns>
        public DescribeAutoDenyIPResponse DescribeAutoDenyIPSync(DescribeAutoDenyIPRequest req)
        {
            return InternalRequestAsync<DescribeAutoDenyIPResponse>(req, "DescribeAutoDenyIP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf 批量防护IP黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeBatchIpAccessControlResponse"/></returns>
        public Task<DescribeBatchIpAccessControlResponse> DescribeBatchIpAccessControl(DescribeBatchIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeBatchIpAccessControlResponse>(req, "DescribeBatchIpAccessControl");
        }

        /// <summary>
        /// Waf 批量防护IP黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeBatchIpAccessControlResponse"/></returns>
        public DescribeBatchIpAccessControlResponse DescribeBatchIpAccessControlSync(DescribeBatchIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeBatchIpAccessControlResponse>(req, "DescribeBatchIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取SAAS型接入的紧急CC防护状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAutoStatusRequest"/></param>
        /// <returns><see cref="DescribeCCAutoStatusResponse"/></returns>
        public Task<DescribeCCAutoStatusResponse> DescribeCCAutoStatus(DescribeCCAutoStatusRequest req)
        {
            return InternalRequestAsync<DescribeCCAutoStatusResponse>(req, "DescribeCCAutoStatus");
        }

        /// <summary>
        /// 获取SAAS型接入的紧急CC防护状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAutoStatusRequest"/></param>
        /// <returns><see cref="DescribeCCAutoStatusResponse"/></returns>
        public DescribeCCAutoStatusResponse DescribeCCAutoStatusSync(DescribeCCAutoStatusRequest req)
        {
            return InternalRequestAsync<DescribeCCAutoStatusResponse>(req, "DescribeCCAutoStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf  CC V2 Query接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleRequest"/></param>
        /// <returns><see cref="DescribeCCRuleResponse"/></returns>
        public Task<DescribeCCRuleResponse> DescribeCCRule(DescribeCCRuleRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleResponse>(req, "DescribeCCRule");
        }

        /// <summary>
        /// Waf  CC V2 Query接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleRequest"/></param>
        /// <returns><see cref="DescribeCCRuleResponse"/></returns>
        public DescribeCCRuleResponse DescribeCCRuleSync(DescribeCCRuleRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleResponse>(req, "DescribeCCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据多条件查询CC规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleListRequest"/></param>
        /// <returns><see cref="DescribeCCRuleListResponse"/></returns>
        public Task<DescribeCCRuleListResponse> DescribeCCRuleList(DescribeCCRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleListResponse>(req, "DescribeCCRuleList");
        }

        /// <summary>
        /// 根据多条件查询CC规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCCRuleListRequest"/></param>
        /// <returns><see cref="DescribeCCRuleListResponse"/></returns>
        public DescribeCCRuleListResponse DescribeCCRuleListSync(DescribeCCRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCCRuleListResponse>(req, "DescribeCCRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取证书的检查结果
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateVerifyResultResponse"/></returns>
        public Task<DescribeCertificateVerifyResultResponse> DescribeCertificateVerifyResult(DescribeCertificateVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateVerifyResultResponse>(req, "DescribeCertificateVerifyResult");
        }

        /// <summary>
        /// 获取证书的检查结果
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateVerifyResultResponse"/></returns>
        public DescribeCertificateVerifyResultResponse DescribeCertificateVerifyResultSync(DescribeCertificateVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateVerifyResultResponse>(req, "DescribeCertificateVerifyResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Saas型WAF接入查询加密套件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCiphersDetailRequest"/></param>
        /// <returns><see cref="DescribeCiphersDetailResponse"/></returns>
        public Task<DescribeCiphersDetailResponse> DescribeCiphersDetail(DescribeCiphersDetailRequest req)
        {
            return InternalRequestAsync<DescribeCiphersDetailResponse>(req, "DescribeCiphersDetail");
        }

        /// <summary>
        /// Saas型WAF接入查询加密套件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCiphersDetailRequest"/></param>
        /// <returns><see cref="DescribeCiphersDetailResponse"/></returns>
        public DescribeCiphersDetailResponse DescribeCiphersDetailSync(DescribeCiphersDetailRequest req)
        {
            return InternalRequestAsync<DescribeCiphersDetailResponse>(req, "DescribeCiphersDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防护配置中的访问控制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleListRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleListResponse"/></returns>
        public Task<DescribeCustomRuleListResponse> DescribeCustomRuleList(DescribeCustomRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCustomRuleListResponse>(req, "DescribeCustomRuleList");
        }

        /// <summary>
        /// 获取防护配置中的访问控制策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleListRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleListResponse"/></returns>
        public DescribeCustomRuleListResponse DescribeCustomRuleListSync(DescribeCustomRuleListRequest req)
        {
            return InternalRequestAsync<DescribeCustomRuleListResponse>(req, "DescribeCustomRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防护配置中的精准白名单策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeCustomWhiteRuleResponse"/></returns>
        public Task<DescribeCustomWhiteRuleResponse> DescribeCustomWhiteRule(DescribeCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeCustomWhiteRuleResponse>(req, "DescribeCustomWhiteRule");
        }

        /// <summary>
        /// 获取防护配置中的精准白名单策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="DescribeCustomWhiteRuleResponse"/></returns>
        public DescribeCustomWhiteRuleResponse DescribeCustomWhiteRuleSync(DescribeCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<DescribeCustomWhiteRuleResponse>(req, "DescribeCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取域名概况
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCountInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainCountInfoResponse"/></returns>
        public Task<DescribeDomainCountInfoResponse> DescribeDomainCountInfo(DescribeDomainCountInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainCountInfoResponse>(req, "DescribeDomainCountInfo");
        }

        /// <summary>
        /// 获取域名概况
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainCountInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainCountInfoResponse"/></returns>
        public DescribeDomainCountInfoResponse DescribeDomainCountInfoSync(DescribeDomainCountInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainCountInfoResponse>(req, "DescribeDomainCountInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取一个clbwaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsClbRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsClbResponse"/></returns>
        public Task<DescribeDomainDetailsClbResponse> DescribeDomainDetailsClb(DescribeDomainDetailsClbRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsClbResponse>(req, "DescribeDomainDetailsClb");
        }

        /// <summary>
        /// 获取一个clbwaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsClbRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsClbResponse"/></returns>
        public DescribeDomainDetailsClbResponse DescribeDomainDetailsClbSync(DescribeDomainDetailsClbRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsClbResponse>(req, "DescribeDomainDetailsClb")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个saaswaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsSaasRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsSaasResponse"/></returns>
        public Task<DescribeDomainDetailsSaasResponse> DescribeDomainDetailsSaas(DescribeDomainDetailsSaasRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsSaasResponse>(req, "DescribeDomainDetailsSaas");
        }

        /// <summary>
        /// 查询单个saaswaf域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainDetailsSaasRequest"/></param>
        /// <returns><see cref="DescribeDomainDetailsSaasResponse"/></returns>
        public DescribeDomainDetailsSaasResponse DescribeDomainDetailsSaasSync(DescribeDomainDetailsSaasRequest req)
        {
            return InternalRequestAsync<DescribeDomainDetailsSaasResponse>(req, "DescribeDomainDetailsSaas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取域名的防护规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainRulesResponse"/></returns>
        public Task<DescribeDomainRulesResponse> DescribeDomainRules(DescribeDomainRulesRequest req)
        {
            return InternalRequestAsync<DescribeDomainRulesResponse>(req, "DescribeDomainRules");
        }

        /// <summary>
        /// 拉取域名的防护规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainRulesResponse"/></returns>
        public DescribeDomainRulesResponse DescribeDomainRulesSync(DescribeDomainRulesRequest req)
        {
            return InternalRequestAsync<DescribeDomainRulesResponse>(req, "DescribeDomainRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取添加域名操作的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeDomainVerifyResultResponse"/></returns>
        public Task<DescribeDomainVerifyResultResponse> DescribeDomainVerifyResult(DescribeDomainVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeDomainVerifyResultResponse>(req, "DescribeDomainVerifyResult");
        }

        /// <summary>
        /// 获取添加域名操作的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainVerifyResultRequest"/></param>
        /// <returns><see cref="DescribeDomainVerifyResultResponse"/></returns>
        public DescribeDomainVerifyResultResponse DescribeDomainVerifyResultSync(DescribeDomainVerifyResultRequest req)
        {
            return InternalRequestAsync<DescribeDomainVerifyResultResponse>(req, "DescribeDomainVerifyResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取域名的规则白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainWhiteRulesResponse"/></returns>
        public Task<DescribeDomainWhiteRulesResponse> DescribeDomainWhiteRules(DescribeDomainWhiteRulesRequest req)
        {
            return InternalRequestAsync<DescribeDomainWhiteRulesResponse>(req, "DescribeDomainWhiteRules");
        }

        /// <summary>
        /// 获取域名的规则白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainWhiteRulesRequest"/></param>
        /// <returns><see cref="DescribeDomainWhiteRulesResponse"/></returns>
        public DescribeDomainWhiteRulesResponse DescribeDomainWhiteRulesSync(DescribeDomainWhiteRulesRequest req)
        {
            return InternalRequestAsync<DescribeDomainWhiteRulesResponse>(req, "DescribeDomainWhiteRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户所有域名的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains");
        }

        /// <summary>
        /// 查询用户所有域名的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取发现域名列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFindDomainListRequest"/></param>
        /// <returns><see cref="DescribeFindDomainListResponse"/></returns>
        public Task<DescribeFindDomainListResponse> DescribeFindDomainList(DescribeFindDomainListRequest req)
        {
            return InternalRequestAsync<DescribeFindDomainListResponse>(req, "DescribeFindDomainList");
        }

        /// <summary>
        /// 获取发现域名列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFindDomainListRequest"/></param>
        /// <returns><see cref="DescribeFindDomainListResponse"/></returns>
        public DescribeFindDomainListResponse DescribeFindDomainListSync(DescribeFindDomainListRequest req)
        {
            return InternalRequestAsync<DescribeFindDomainListResponse>(req, "DescribeFindDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取waf流量访问趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTrendRequest"/></param>
        /// <returns><see cref="DescribeFlowTrendResponse"/></returns>
        public Task<DescribeFlowTrendResponse> DescribeFlowTrend(DescribeFlowTrendRequest req)
        {
            return InternalRequestAsync<DescribeFlowTrendResponse>(req, "DescribeFlowTrend");
        }

        /// <summary>
        /// 获取waf流量访问趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTrendRequest"/></param>
        /// <returns><see cref="DescribeFlowTrendResponse"/></returns>
        public DescribeFlowTrendResponse DescribeFlowTrendSync(DescribeFlowTrendRequest req)
        {
            return InternalRequestAsync<DescribeFlowTrendResponse>(req, "DescribeFlowTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询多种条件的聚类分析
        /// </summary>
        /// <param name="req"><see cref="DescribeHistogramRequest"/></param>
        /// <returns><see cref="DescribeHistogramResponse"/></returns>
        public Task<DescribeHistogramResponse> DescribeHistogram(DescribeHistogramRequest req)
        {
            return InternalRequestAsync<DescribeHistogramResponse>(req, "DescribeHistogram");
        }

        /// <summary>
        /// 查询多种条件的聚类分析
        /// </summary>
        /// <param name="req"><see cref="DescribeHistogramRequest"/></param>
        /// <returns><see cref="DescribeHistogramResponse"/></returns>
        public DescribeHistogramResponse DescribeHistogramSync(DescribeHistogramRequest req)
        {
            return InternalRequestAsync<DescribeHistogramResponse>(req, "DescribeHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// clb-waf获取防护域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeHostRequest"/></param>
        /// <returns><see cref="DescribeHostResponse"/></returns>
        public Task<DescribeHostResponse> DescribeHost(DescribeHostRequest req)
        {
            return InternalRequestAsync<DescribeHostResponse>(req, "DescribeHost");
        }

        /// <summary>
        /// clb-waf获取防护域名详情
        /// </summary>
        /// <param name="req"><see cref="DescribeHostRequest"/></param>
        /// <returns><see cref="DescribeHostResponse"/></returns>
        public DescribeHostResponse DescribeHostSync(DescribeHostRequest req)
        {
            return InternalRequestAsync<DescribeHostResponse>(req, "DescribeHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加域名的首先验证是否购买了套餐，是否没有达到购买套餐的限制，域名是否已经添加
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLimitRequest"/></param>
        /// <returns><see cref="DescribeHostLimitResponse"/></returns>
        public Task<DescribeHostLimitResponse> DescribeHostLimit(DescribeHostLimitRequest req)
        {
            return InternalRequestAsync<DescribeHostLimitResponse>(req, "DescribeHostLimit");
        }

        /// <summary>
        /// 添加域名的首先验证是否购买了套餐，是否没有达到购买套餐的限制，域名是否已经添加
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLimitRequest"/></param>
        /// <returns><see cref="DescribeHostLimitResponse"/></returns>
        public DescribeHostLimitResponse DescribeHostLimitSync(DescribeHostLimitRequest req)
        {
            return InternalRequestAsync<DescribeHostLimitResponse>(req, "DescribeHostLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// clb-waf中获取防护域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public Task<DescribeHostsResponse> DescribeHosts(DescribeHostsRequest req)
        {
            return InternalRequestAsync<DescribeHostsResponse>(req, "DescribeHosts");
        }

        /// <summary>
        /// clb-waf中获取防护域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostsRequest"/></param>
        /// <returns><see cref="DescribeHostsResponse"/></returns>
        public DescribeHostsResponse DescribeHostsSync(DescribeHostsRequest req)
        {
            return InternalRequestAsync<DescribeHostsResponse>(req, "DescribeHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户所有实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 查询用户所有实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf ip黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeIpAccessControlResponse"/></returns>
        public Task<DescribeIpAccessControlResponse> DescribeIpAccessControl(DescribeIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeIpAccessControlResponse>(req, "DescribeIpAccessControl");
        }

        /// <summary>
        /// Waf ip黑白名单查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpAccessControlRequest"/></param>
        /// <returns><see cref="DescribeIpAccessControlResponse"/></returns>
        public DescribeIpAccessControlResponse DescribeIpAccessControlSync(DescribeIpAccessControlRequest req)
        {
            return InternalRequestAsync<DescribeIpAccessControlResponse>(req, "DescribeIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf  IP封堵状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpHitItemsRequest"/></param>
        /// <returns><see cref="DescribeIpHitItemsResponse"/></returns>
        public Task<DescribeIpHitItemsResponse> DescribeIpHitItems(DescribeIpHitItemsRequest req)
        {
            return InternalRequestAsync<DescribeIpHitItemsResponse>(req, "DescribeIpHitItems");
        }

        /// <summary>
        /// Waf  IP封堵状态查询
        /// </summary>
        /// <param name="req"><see cref="DescribeIpHitItemsRequest"/></param>
        /// <returns><see cref="DescribeIpHitItemsResponse"/></returns>
        public DescribeIpHitItemsResponse DescribeIpHitItemsSync(DescribeIpHitItemsRequest req)
        {
            return InternalRequestAsync<DescribeIpHitItemsResponse>(req, "DescribeIpHitItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询各个waf基础安全模块的开关状态，看每个模块是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleStatusRequest"/></param>
        /// <returns><see cref="DescribeModuleStatusResponse"/></returns>
        public Task<DescribeModuleStatusResponse> DescribeModuleStatus(DescribeModuleStatusRequest req)
        {
            return InternalRequestAsync<DescribeModuleStatusResponse>(req, "DescribeModuleStatus");
        }

        /// <summary>
        /// 查询各个waf基础安全模块的开关状态，看每个模块是否开启
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleStatusRequest"/></param>
        /// <returns><see cref="DescribeModuleStatusResponse"/></returns>
        public DescribeModuleStatusResponse DescribeModuleStatusSync(DescribeModuleStatusRequest req)
        {
            return InternalRequestAsync<DescribeModuleStatusResponse>(req, "DescribeModuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看防护对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectsRequest"/></param>
        /// <returns><see cref="DescribeObjectsResponse"/></returns>
        public Task<DescribeObjectsResponse> DescribeObjects(DescribeObjectsRequest req)
        {
            return InternalRequestAsync<DescribeObjectsResponse>(req, "DescribeObjects");
        }

        /// <summary>
        /// 查看防护对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeObjectsRequest"/></param>
        /// <returns><see cref="DescribeObjectsResponse"/></returns>
        public DescribeObjectsResponse DescribeObjectsSync(DescribeObjectsRequest req)
        {
            return InternalRequestAsync<DescribeObjectsResponse>(req, "DescribeObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询业务和攻击概要趋势
        /// </summary>
        /// <param name="req"><see cref="DescribePeakPointsRequest"/></param>
        /// <returns><see cref="DescribePeakPointsResponse"/></returns>
        public Task<DescribePeakPointsResponse> DescribePeakPoints(DescribePeakPointsRequest req)
        {
            return InternalRequestAsync<DescribePeakPointsResponse>(req, "DescribePeakPoints");
        }

        /// <summary>
        /// 查询业务和攻击概要趋势
        /// </summary>
        /// <param name="req"><see cref="DescribePeakPointsRequest"/></param>
        /// <returns><see cref="DescribePeakPointsResponse"/></returns>
        public DescribePeakPointsResponse DescribePeakPointsSync(DescribePeakPointsRequest req)
        {
            return InternalRequestAsync<DescribePeakPointsResponse>(req, "DescribePeakPoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取业务和攻击概览峰值
        /// </summary>
        /// <param name="req"><see cref="DescribePeakValueRequest"/></param>
        /// <returns><see cref="DescribePeakValueResponse"/></returns>
        public Task<DescribePeakValueResponse> DescribePeakValue(DescribePeakValueRequest req)
        {
            return InternalRequestAsync<DescribePeakValueResponse>(req, "DescribePeakValue");
        }

        /// <summary>
        /// 获取业务和攻击概览峰值
        /// </summary>
        /// <param name="req"><see cref="DescribePeakValueRequest"/></param>
        /// <returns><see cref="DescribePeakValueResponse"/></returns>
        public DescribePeakValueResponse DescribePeakValueSync(DescribePeakValueRequest req)
        {
            return InternalRequestAsync<DescribePeakValueResponse>(req, "DescribePeakValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防护状态以及生效的实例id
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyStatusRequest"/></param>
        /// <returns><see cref="DescribePolicyStatusResponse"/></returns>
        public Task<DescribePolicyStatusResponse> DescribePolicyStatus(DescribePolicyStatusRequest req)
        {
            return InternalRequestAsync<DescribePolicyStatusResponse>(req, "DescribePolicyStatus");
        }

        /// <summary>
        /// 获取防护状态以及生效的实例id
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyStatusRequest"/></param>
        /// <returns><see cref="DescribePolicyStatusResponse"/></returns>
        public DescribePolicyStatusResponse DescribePolicyStatusSync(DescribePolicyStatusRequest req)
        {
            return InternalRequestAsync<DescribePolicyStatusResponse>(req, "DescribePolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Saas型WAF防护端口列表
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public Task<DescribePortsResponse> DescribePorts(DescribePortsRequest req)
        {
            return InternalRequestAsync<DescribePortsResponse>(req, "DescribePorts");
        }

        /// <summary>
        /// 获取Saas型WAF防护端口列表
        /// </summary>
        /// <param name="req"><see cref="DescribePortsRequest"/></param>
        /// <returns><see cref="DescribePortsResponse"/></returns>
        public DescribePortsResponse DescribePortsSync(DescribePortsRequest req)
        {
            return InternalRequestAsync<DescribePortsResponse>(req, "DescribePorts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CKafka投递流任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribePostCKafkaFlowsRequest"/></param>
        /// <returns><see cref="DescribePostCKafkaFlowsResponse"/></returns>
        public Task<DescribePostCKafkaFlowsResponse> DescribePostCKafkaFlows(DescribePostCKafkaFlowsRequest req)
        {
            return InternalRequestAsync<DescribePostCKafkaFlowsResponse>(req, "DescribePostCKafkaFlows");
        }

        /// <summary>
        /// 获取CKafka投递流任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribePostCKafkaFlowsRequest"/></param>
        /// <returns><see cref="DescribePostCKafkaFlowsResponse"/></returns>
        public DescribePostCKafkaFlowsResponse DescribePostCKafkaFlowsSync(DescribePostCKafkaFlowsRequest req)
        {
            return InternalRequestAsync<DescribePostCKafkaFlowsResponse>(req, "DescribePostCKafkaFlows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CLS投递流任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribePostCLSFlowsRequest"/></param>
        /// <returns><see cref="DescribePostCLSFlowsResponse"/></returns>
        public Task<DescribePostCLSFlowsResponse> DescribePostCLSFlows(DescribePostCLSFlowsRequest req)
        {
            return InternalRequestAsync<DescribePostCLSFlowsResponse>(req, "DescribePostCLSFlows");
        }

        /// <summary>
        /// 获取CLS投递流任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribePostCLSFlowsRequest"/></param>
        /// <returns><see cref="DescribePostCLSFlowsResponse"/></returns>
        public DescribePostCLSFlowsResponse DescribePostCLSFlowsSync(DescribePostCLSFlowsRequest req)
        {
            return InternalRequestAsync<DescribePostCLSFlowsResponse>(req, "DescribePostCLSFlows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Tiga引擎大类规则及其防护模式
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectionModesRequest"/></param>
        /// <returns><see cref="DescribeProtectionModesResponse"/></returns>
        public Task<DescribeProtectionModesResponse> DescribeProtectionModes(DescribeProtectionModesRequest req)
        {
            return InternalRequestAsync<DescribeProtectionModesResponse>(req, "DescribeProtectionModes");
        }

        /// <summary>
        /// 查询Tiga引擎大类规则及其防护模式
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectionModesRequest"/></param>
        /// <returns><see cref="DescribeProtectionModesResponse"/></returns>
        public DescribeProtectionModesResponse DescribeProtectionModesSync(DescribeProtectionModesRequest req)
        {
            return InternalRequestAsync<DescribeProtectionModesResponse>(req, "DescribeProtectionModes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取各个模块具体的规格限制
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleLimitRequest"/></param>
        /// <returns><see cref="DescribeRuleLimitResponse"/></returns>
        public Task<DescribeRuleLimitResponse> DescribeRuleLimit(DescribeRuleLimitRequest req)
        {
            return InternalRequestAsync<DescribeRuleLimitResponse>(req, "DescribeRuleLimit");
        }

        /// <summary>
        /// 获取各个模块具体的规格限制
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleLimitRequest"/></param>
        /// <returns><see cref="DescribeRuleLimitResponse"/></returns>
        public DescribeRuleLimitResponse DescribeRuleLimitSync(DescribeRuleLimitRequest req)
        {
            return InternalRequestAsync<DescribeRuleLimitResponse>(req, "DescribeRuleLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询扫描ip
        /// </summary>
        /// <param name="req"><see cref="DescribeScanIpRequest"/></param>
        /// <returns><see cref="DescribeScanIpResponse"/></returns>
        public Task<DescribeScanIpResponse> DescribeScanIp(DescribeScanIpRequest req)
        {
            return InternalRequestAsync<DescribeScanIpResponse>(req, "DescribeScanIp");
        }

        /// <summary>
        /// 查询扫描ip
        /// </summary>
        /// <param name="req"><see cref="DescribeScanIpRequest"/></param>
        /// <returns><see cref="DescribeScanIpResponse"/></returns>
        public DescribeScanIpResponse DescribeScanIpSync(DescribeScanIpRequest req)
        {
            return InternalRequestAsync<DescribeScanIpResponse>(req, "DescribeScanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf 会话定义查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public Task<DescribeSessionResponse> DescribeSession(DescribeSessionRequest req)
        {
            return InternalRequestAsync<DescribeSessionResponse>(req, "DescribeSession");
        }

        /// <summary>
        /// Waf 会话定义查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public DescribeSessionResponse DescribeSessionSync(DescribeSessionRequest req)
        {
            return InternalRequestAsync<DescribeSessionResponse>(req, "DescribeSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// waf斯巴达-获取防护域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpartaProtectionInfoRequest"/></param>
        /// <returns><see cref="DescribeSpartaProtectionInfoResponse"/></returns>
        public Task<DescribeSpartaProtectionInfoResponse> DescribeSpartaProtectionInfo(DescribeSpartaProtectionInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpartaProtectionInfoResponse>(req, "DescribeSpartaProtectionInfo");
        }

        /// <summary>
        /// waf斯巴达-获取防护域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpartaProtectionInfoRequest"/></param>
        /// <returns><see cref="DescribeSpartaProtectionInfoResponse"/></returns>
        public DescribeSpartaProtectionInfoResponse DescribeSpartaProtectionInfoSync(DescribeSpartaProtectionInfoRequest req)
        {
            return InternalRequestAsync<DescribeSpartaProtectionInfoResponse>(req, "DescribeSpartaProtectionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SaaS型WAF支持的TLS版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTlsVersionRequest"/></param>
        /// <returns><see cref="DescribeTlsVersionResponse"/></returns>
        public Task<DescribeTlsVersionResponse> DescribeTlsVersion(DescribeTlsVersionRequest req)
        {
            return InternalRequestAsync<DescribeTlsVersionResponse>(req, "DescribeTlsVersion");
        }

        /// <summary>
        /// 查询SaaS型WAF支持的TLS版本
        /// </summary>
        /// <param name="req"><see cref="DescribeTlsVersionRequest"/></param>
        /// <returns><see cref="DescribeTlsVersionResponse"/></returns>
        public DescribeTlsVersionResponse DescribeTlsVersionSync(DescribeTlsVersionRequest req)
        {
            return InternalRequestAsync<DescribeTlsVersionResponse>(req, "DescribeTlsVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Top5的攻击域名
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackDomainRequest"/></param>
        /// <returns><see cref="DescribeTopAttackDomainResponse"/></returns>
        public Task<DescribeTopAttackDomainResponse> DescribeTopAttackDomain(DescribeTopAttackDomainRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackDomainResponse>(req, "DescribeTopAttackDomain");
        }

        /// <summary>
        /// 查询Top5的攻击域名
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackDomainRequest"/></param>
        /// <returns><see cref="DescribeTopAttackDomainResponse"/></returns>
        public DescribeTopAttackDomainResponse DescribeTopAttackDomainSync(DescribeTopAttackDomainRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackDomainResponse>(req, "DescribeTopAttackDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在CDC场景下，负载均衡型WAF的添加、编辑域名配置的时候，需要展示CDC负载均衡型WAF（cdc-clb-waf)支持的地域列表，通过DescribeUserCdcClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCdcClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserCdcClbWafRegionsResponse"/></returns>
        public Task<DescribeUserCdcClbWafRegionsResponse> DescribeUserCdcClbWafRegions(DescribeUserCdcClbWafRegionsRequest req)
        {
            return InternalRequestAsync<DescribeUserCdcClbWafRegionsResponse>(req, "DescribeUserCdcClbWafRegions");
        }

        /// <summary>
        /// 在CDC场景下，负载均衡型WAF的添加、编辑域名配置的时候，需要展示CDC负载均衡型WAF（cdc-clb-waf)支持的地域列表，通过DescribeUserCdcClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCdcClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserCdcClbWafRegionsResponse"/></returns>
        public DescribeUserCdcClbWafRegionsResponse DescribeUserCdcClbWafRegionsSync(DescribeUserCdcClbWafRegionsRequest req)
        {
            return InternalRequestAsync<DescribeUserCdcClbWafRegionsResponse>(req, "DescribeUserCdcClbWafRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在负载均衡型WAF的添加、编辑域名配置的时候，需要展示负载均衡型WAF（clb-waf)支持的地域列表，通过DescribeUserClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public Task<DescribeUserClbWafRegionsResponse> DescribeUserClbWafRegions(DescribeUserClbWafRegionsRequest req)
        {
            return InternalRequestAsync<DescribeUserClbWafRegionsResponse>(req, "DescribeUserClbWafRegions");
        }

        /// <summary>
        /// 在负载均衡型WAF的添加、编辑域名配置的时候，需要展示负载均衡型WAF（clb-waf)支持的地域列表，通过DescribeUserClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public DescribeUserClbWafRegionsResponse DescribeUserClbWafRegionsSync(DescribeUserClbWafRegionsRequest req)
        {
            return InternalRequestAsync<DescribeUserClbWafRegionsResponse>(req, "DescribeUserClbWafRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询saas和clb的域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeUserDomainInfoResponse"/></returns>
        public Task<DescribeUserDomainInfoResponse> DescribeUserDomainInfo(DescribeUserDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserDomainInfoResponse>(req, "DescribeUserDomainInfo");
        }

        /// <summary>
        /// 查询saas和clb的域名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeUserDomainInfoResponse"/></returns>
        public DescribeUserDomainInfoResponse DescribeUserDomainInfoSync(DescribeUserDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserDomainInfoResponse>(req, "DescribeUserDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户防护规则等级
        /// </summary>
        /// <param name="req"><see cref="DescribeUserLevelRequest"/></param>
        /// <returns><see cref="DescribeUserLevelResponse"/></returns>
        public Task<DescribeUserLevelResponse> DescribeUserLevel(DescribeUserLevelRequest req)
        {
            return InternalRequestAsync<DescribeUserLevelResponse>(req, "DescribeUserLevel");
        }

        /// <summary>
        /// 获取用户防护规则等级
        /// </summary>
        /// <param name="req"><see cref="DescribeUserLevelRequest"/></param>
        /// <returns><see cref="DescribeUserLevelResponse"/></returns>
        public DescribeUserLevelResponse DescribeUserLevelSync(DescribeUserLevelRequest req)
        {
            return InternalRequestAsync<DescribeUserLevelResponse>(req, "DescribeUserLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Tiga引擎规则类型及状态
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureClassRequest"/></param>
        /// <returns><see cref="DescribeUserSignatureClassResponse"/></returns>
        public Task<DescribeUserSignatureClassResponse> DescribeUserSignatureClass(DescribeUserSignatureClassRequest req)
        {
            return InternalRequestAsync<DescribeUserSignatureClassResponse>(req, "DescribeUserSignatureClass");
        }

        /// <summary>
        /// 查询Tiga引擎规则类型及状态
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureClassRequest"/></param>
        /// <returns><see cref="DescribeUserSignatureClassResponse"/></returns>
        public DescribeUserSignatureClassResponse DescribeUserSignatureClassSync(DescribeUserSignatureClassRequest req)
        {
            return InternalRequestAsync<DescribeUserSignatureClassResponse>(req, "DescribeUserSignatureClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户特征规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureRuleRequest"/></param>
        /// <returns><see cref="DescribeUserSignatureRuleResponse"/></returns>
        public Task<DescribeUserSignatureRuleResponse> DescribeUserSignatureRule(DescribeUserSignatureRuleRequest req)
        {
            return InternalRequestAsync<DescribeUserSignatureRuleResponse>(req, "DescribeUserSignatureRule");
        }

        /// <summary>
        /// 获取用户特征规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureRuleRequest"/></param>
        /// <returns><see cref="DescribeUserSignatureRuleResponse"/></returns>
        public DescribeUserSignatureRuleResponse DescribeUserSignatureRuleSync(DescribeUserSignatureRuleRequest req)
        {
            return InternalRequestAsync<DescribeUserSignatureRuleResponse>(req, "DescribeUserSignatureRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户特征规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureRuleV2Request"/></param>
        /// <returns><see cref="DescribeUserSignatureRuleV2Response"/></returns>
        public Task<DescribeUserSignatureRuleV2Response> DescribeUserSignatureRuleV2(DescribeUserSignatureRuleV2Request req)
        {
            return InternalRequestAsync<DescribeUserSignatureRuleV2Response>(req, "DescribeUserSignatureRuleV2");
        }

        /// <summary>
        /// 获取用户特征规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSignatureRuleV2Request"/></param>
        /// <returns><see cref="DescribeUserSignatureRuleV2Response"/></returns>
        public DescribeUserSignatureRuleV2Response DescribeUserSignatureRuleV2Sync(DescribeUserSignatureRuleV2Request req)
        {
            return InternalRequestAsync<DescribeUserSignatureRuleV2Response>(req, "DescribeUserSignatureRuleV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据过滤条件查询VIP信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVipInfoRequest"/></param>
        /// <returns><see cref="DescribeVipInfoResponse"/></returns>
        public Task<DescribeVipInfoResponse> DescribeVipInfo(DescribeVipInfoRequest req)
        {
            return InternalRequestAsync<DescribeVipInfoResponse>(req, "DescribeVipInfo");
        }

        /// <summary>
        /// 根据过滤条件查询VIP信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVipInfoRequest"/></param>
        /// <returns><see cref="DescribeVipInfoResponse"/></returns>
        public DescribeVipInfoResponse DescribeVipInfoSync(DescribeVipInfoRequest req)
        {
            return InternalRequestAsync<DescribeVipInfoResponse>(req, "DescribeVipInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回ip惩罚规则详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyRulesResponse"/></returns>
        public Task<DescribeWafAutoDenyRulesResponse> DescribeWafAutoDenyRules(DescribeWafAutoDenyRulesRequest req)
        {
            return InternalRequestAsync<DescribeWafAutoDenyRulesResponse>(req, "DescribeWafAutoDenyRules");
        }

        /// <summary>
        /// 返回ip惩罚规则详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyRulesResponse"/></returns>
        public DescribeWafAutoDenyRulesResponse DescribeWafAutoDenyRulesSync(DescribeWafAutoDenyRulesRequest req)
        {
            return InternalRequestAsync<DescribeWafAutoDenyRulesResponse>(req, "DescribeWafAutoDenyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 废弃接口
        /// 
        /// 描述WAF自动封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyStatusRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyStatusResponse"/></returns>
        public Task<DescribeWafAutoDenyStatusResponse> DescribeWafAutoDenyStatus(DescribeWafAutoDenyStatusRequest req)
        {
            return InternalRequestAsync<DescribeWafAutoDenyStatusResponse>(req, "DescribeWafAutoDenyStatus");
        }

        /// <summary>
        /// 废弃接口
        /// 
        /// 描述WAF自动封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafAutoDenyStatusRequest"/></param>
        /// <returns><see cref="DescribeWafAutoDenyStatusResponse"/></returns>
        public DescribeWafAutoDenyStatusResponse DescribeWafAutoDenyStatusSync(DescribeWafAutoDenyStatusRequest req)
        {
            return InternalRequestAsync<DescribeWafAutoDenyStatusResponse>(req, "DescribeWafAutoDenyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 描述WAF威胁情报封禁模块配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="DescribeWafThreatenIntelligenceResponse"/></returns>
        public Task<DescribeWafThreatenIntelligenceResponse> DescribeWafThreatenIntelligence(DescribeWafThreatenIntelligenceRequest req)
        {
            return InternalRequestAsync<DescribeWafThreatenIntelligenceResponse>(req, "DescribeWafThreatenIntelligence");
        }

        /// <summary>
        /// 描述WAF威胁情报封禁模块配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="DescribeWafThreatenIntelligenceResponse"/></returns>
        public DescribeWafThreatenIntelligenceResponse DescribeWafThreatenIntelligenceSync(DescribeWafThreatenIntelligenceRequest req)
        {
            return InternalRequestAsync<DescribeWafThreatenIntelligenceResponse>(req, "DescribeWafThreatenIntelligence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取域名的webshell状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWebshellStatusRequest"/></param>
        /// <returns><see cref="DescribeWebshellStatusResponse"/></returns>
        public Task<DescribeWebshellStatusResponse> DescribeWebshellStatus(DescribeWebshellStatusRequest req)
        {
            return InternalRequestAsync<DescribeWebshellStatusResponse>(req, "DescribeWebshellStatus");
        }

        /// <summary>
        /// 获取域名的webshell状态
        /// </summary>
        /// <param name="req"><see cref="DescribeWebshellStatusRequest"/></param>
        /// <returns><see cref="DescribeWebshellStatusResponse"/></returns>
        public DescribeWebshellStatusResponse DescribeWebshellStatusSync(DescribeWebshellStatusRequest req)
        {
            return InternalRequestAsync<DescribeWebshellStatusResponse>(req, "DescribeWebshellStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁CKafka投递流任务
        /// </summary>
        /// <param name="req"><see cref="DestroyPostCKafkaFlowRequest"/></param>
        /// <returns><see cref="DestroyPostCKafkaFlowResponse"/></returns>
        public Task<DestroyPostCKafkaFlowResponse> DestroyPostCKafkaFlow(DestroyPostCKafkaFlowRequest req)
        {
            return InternalRequestAsync<DestroyPostCKafkaFlowResponse>(req, "DestroyPostCKafkaFlow");
        }

        /// <summary>
        /// 销毁CKafka投递流任务
        /// </summary>
        /// <param name="req"><see cref="DestroyPostCKafkaFlowRequest"/></param>
        /// <returns><see cref="DestroyPostCKafkaFlowResponse"/></returns>
        public DestroyPostCKafkaFlowResponse DestroyPostCKafkaFlowSync(DestroyPostCKafkaFlowRequest req)
        {
            return InternalRequestAsync<DestroyPostCKafkaFlowResponse>(req, "DestroyPostCKafkaFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁CLS投递流任务
        /// </summary>
        /// <param name="req"><see cref="DestroyPostCLSFlowRequest"/></param>
        /// <returns><see cref="DestroyPostCLSFlowResponse"/></returns>
        public Task<DestroyPostCLSFlowResponse> DestroyPostCLSFlow(DestroyPostCLSFlowRequest req)
        {
            return InternalRequestAsync<DestroyPostCLSFlowResponse>(req, "DestroyPostCLSFlow");
        }

        /// <summary>
        /// 销毁CLS投递流任务
        /// </summary>
        /// <param name="req"><see cref="DestroyPostCLSFlowRequest"/></param>
        /// <returns><see cref="DestroyPostCLSFlowResponse"/></returns>
        public DestroyPostCLSFlowResponse DestroyPostCLSFlowSync(DestroyPostCLSFlowRequest req)
        {
            return InternalRequestAsync<DestroyPostCLSFlowResponse>(req, "DestroyPostCLSFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 刷新防篡改url
        /// </summary>
        /// <param name="req"><see cref="FreshAntiFakeUrlRequest"/></param>
        /// <returns><see cref="FreshAntiFakeUrlResponse"/></returns>
        public Task<FreshAntiFakeUrlResponse> FreshAntiFakeUrl(FreshAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<FreshAntiFakeUrlResponse>(req, "FreshAntiFakeUrl");
        }

        /// <summary>
        /// 刷新防篡改url
        /// </summary>
        /// <param name="req"><see cref="FreshAntiFakeUrlRequest"/></param>
        /// <returns><see cref="FreshAntiFakeUrlResponse"/></returns>
        public FreshAntiFakeUrlResponse FreshAntiFakeUrlSync(FreshAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<FreshAntiFakeUrlResponse>(req, "FreshAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 计费资源购买、续费下单接口
        /// </summary>
        /// <param name="req"><see cref="GenerateDealsAndPayNewRequest"/></param>
        /// <returns><see cref="GenerateDealsAndPayNewResponse"/></returns>
        public Task<GenerateDealsAndPayNewResponse> GenerateDealsAndPayNew(GenerateDealsAndPayNewRequest req)
        {
            return InternalRequestAsync<GenerateDealsAndPayNewResponse>(req, "GenerateDealsAndPayNew");
        }

        /// <summary>
        /// 计费资源购买、续费下单接口
        /// </summary>
        /// <param name="req"><see cref="GenerateDealsAndPayNewRequest"/></param>
        /// <returns><see cref="GenerateDealsAndPayNewResponse"/></returns>
        public GenerateDealsAndPayNewResponse GenerateDealsAndPayNewSync(GenerateDealsAndPayNewRequest req)
        {
            return InternalRequestAsync<GenerateDealsAndPayNewResponse>(req, "GenerateDealsAndPayNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询下载攻击日志任务记录列表
        /// </summary>
        /// <param name="req"><see cref="GetAttackDownloadRecordsRequest"/></param>
        /// <returns><see cref="GetAttackDownloadRecordsResponse"/></returns>
        public Task<GetAttackDownloadRecordsResponse> GetAttackDownloadRecords(GetAttackDownloadRecordsRequest req)
        {
            return InternalRequestAsync<GetAttackDownloadRecordsResponse>(req, "GetAttackDownloadRecords");
        }

        /// <summary>
        /// 查询下载攻击日志任务记录列表
        /// </summary>
        /// <param name="req"><see cref="GetAttackDownloadRecordsRequest"/></param>
        /// <returns><see cref="GetAttackDownloadRecordsResponse"/></returns>
        public GetAttackDownloadRecordsResponse GetAttackDownloadRecordsSync(GetAttackDownloadRecordsRequest req)
        {
            return InternalRequestAsync<GetAttackDownloadRecordsResponse>(req, "GetAttackDownloadRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成攻击日志的产生时间柱状图
        /// </summary>
        /// <param name="req"><see cref="GetAttackHistogramRequest"/></param>
        /// <returns><see cref="GetAttackHistogramResponse"/></returns>
        public Task<GetAttackHistogramResponse> GetAttackHistogram(GetAttackHistogramRequest req)
        {
            return InternalRequestAsync<GetAttackHistogramResponse>(req, "GetAttackHistogram");
        }

        /// <summary>
        /// 生成攻击日志的产生时间柱状图
        /// </summary>
        /// <param name="req"><see cref="GetAttackHistogramRequest"/></param>
        /// <returns><see cref="GetAttackHistogramResponse"/></returns>
        public GetAttackHistogramResponse GetAttackHistogramSync(GetAttackHistogramRequest req)
        {
            return InternalRequestAsync<GetAttackHistogramResponse>(req, "GetAttackHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按照条件查询展示攻击总次数
        /// </summary>
        /// <param name="req"><see cref="GetAttackTotalCountRequest"/></param>
        /// <returns><see cref="GetAttackTotalCountResponse"/></returns>
        public Task<GetAttackTotalCountResponse> GetAttackTotalCount(GetAttackTotalCountRequest req)
        {
            return InternalRequestAsync<GetAttackTotalCountResponse>(req, "GetAttackTotalCount");
        }

        /// <summary>
        /// 按照条件查询展示攻击总次数
        /// </summary>
        /// <param name="req"><see cref="GetAttackTotalCountRequest"/></param>
        /// <returns><see cref="GetAttackTotalCountResponse"/></returns>
        public GetAttackTotalCountResponse GetAttackTotalCountSync(GetAttackTotalCountRequest req)
        {
            return InternalRequestAsync<GetAttackTotalCountResponse>(req, "GetAttackTotalCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="GetInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="GetInstanceQpsLimitResponse"/></returns>
        public Task<GetInstanceQpsLimitResponse> GetInstanceQpsLimit(GetInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<GetInstanceQpsLimitResponse>(req, "GetInstanceQpsLimit");
        }

        /// <summary>
        /// 获取套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="GetInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="GetInstanceQpsLimitResponse"/></returns>
        public GetInstanceQpsLimitResponse GetInstanceQpsLimitSync(GetInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<GetInstanceQpsLimitResponse>(req, "GetInstanceQpsLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="ImportIpAccessControlRequest"/></param>
        /// <returns><see cref="ImportIpAccessControlResponse"/></returns>
        public Task<ImportIpAccessControlResponse> ImportIpAccessControl(ImportIpAccessControlRequest req)
        {
            return InternalRequestAsync<ImportIpAccessControlResponse>(req, "ImportIpAccessControl");
        }

        /// <summary>
        /// 导入IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="ImportIpAccessControlRequest"/></param>
        /// <returns><see cref="ImportIpAccessControlResponse"/></returns>
        public ImportIpAccessControlResponse ImportIpAccessControlSync(ImportIpAccessControlRequest req)
        {
            return InternalRequestAsync<ImportIpAccessControlResponse>(req, "ImportIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑防篡改url
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlResponse"/></returns>
        public Task<ModifyAntiFakeUrlResponse> ModifyAntiFakeUrl(ModifyAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlResponse>(req, "ModifyAntiFakeUrl");
        }

        /// <summary>
        /// 编辑防篡改url
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlResponse"/></returns>
        public ModifyAntiFakeUrlResponse ModifyAntiFakeUrlSync(ModifyAntiFakeUrlRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlResponse>(req, "ModifyAntiFakeUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换防篡改开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlStatusResponse"/></returns>
        public Task<ModifyAntiFakeUrlStatusResponse> ModifyAntiFakeUrlStatus(ModifyAntiFakeUrlStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlStatusResponse>(req, "ModifyAntiFakeUrlStatus");
        }

        /// <summary>
        /// 切换防篡改开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiFakeUrlStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiFakeUrlStatusResponse"/></returns>
        public ModifyAntiFakeUrlStatusResponse ModifyAntiFakeUrlStatusSync(ModifyAntiFakeUrlStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiFakeUrlStatusResponse>(req, "ModifyAntiFakeUrlStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 信息防泄漏切换规则开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRuleStatusResponse"/></returns>
        public Task<ModifyAntiInfoLeakRuleStatusResponse> ModifyAntiInfoLeakRuleStatus(ModifyAntiInfoLeakRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRuleStatusResponse>(req, "ModifyAntiInfoLeakRuleStatus");
        }

        /// <summary>
        /// 信息防泄漏切换规则开关
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRuleStatusResponse"/></returns>
        public ModifyAntiInfoLeakRuleStatusResponse ModifyAntiInfoLeakRuleStatusSync(ModifyAntiInfoLeakRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRuleStatusResponse>(req, "ModifyAntiInfoLeakRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRulesResponse"/></returns>
        public Task<ModifyAntiInfoLeakRulesResponse> ModifyAntiInfoLeakRules(ModifyAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRulesResponse>(req, "ModifyAntiInfoLeakRules");
        }

        /// <summary>
        /// 编辑信息防泄漏规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAntiInfoLeakRulesRequest"/></param>
        /// <returns><see cref="ModifyAntiInfoLeakRulesResponse"/></returns>
        public ModifyAntiInfoLeakRulesResponse ModifyAntiInfoLeakRulesSync(ModifyAntiInfoLeakRulesRequest req)
        {
            return InternalRequestAsync<ModifyAntiInfoLeakRulesResponse>(req, "ModifyAntiInfoLeakRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// api分析页面开关
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAnalyzeStatusRequest"/></param>
        /// <returns><see cref="ModifyApiAnalyzeStatusResponse"/></returns>
        public Task<ModifyApiAnalyzeStatusResponse> ModifyApiAnalyzeStatus(ModifyApiAnalyzeStatusRequest req)
        {
            return InternalRequestAsync<ModifyApiAnalyzeStatusResponse>(req, "ModifyApiAnalyzeStatus");
        }

        /// <summary>
        /// api分析页面开关
        /// </summary>
        /// <param name="req"><see cref="ModifyApiAnalyzeStatusRequest"/></param>
        /// <returns><see cref="ModifyApiAnalyzeStatusResponse"/></returns>
        public ModifyApiAnalyzeStatusResponse ModifyApiAnalyzeStatusSync(ModifyApiAnalyzeStatusRequest req)
        {
            return InternalRequestAsync<ModifyApiAnalyzeStatusResponse>(req, "ModifyApiAnalyzeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// api安全状态变更接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApiSecEventChangeRequest"/></param>
        /// <returns><see cref="ModifyApiSecEventChangeResponse"/></returns>
        public Task<ModifyApiSecEventChangeResponse> ModifyApiSecEventChange(ModifyApiSecEventChangeRequest req)
        {
            return InternalRequestAsync<ModifyApiSecEventChangeResponse>(req, "ModifyApiSecEventChange");
        }

        /// <summary>
        /// api安全状态变更接口
        /// </summary>
        /// <param name="req"><see cref="ModifyApiSecEventChangeRequest"/></param>
        /// <returns><see cref="ModifyApiSecEventChangeResponse"/></returns>
        public ModifyApiSecEventChangeResponse ModifyApiSecEventChangeSync(ModifyApiSecEventChangeRequest req)
        {
            return InternalRequestAsync<ModifyApiSecEventChangeResponse>(req, "ModifyApiSecEventChange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanAreasRequest"/></param>
        /// <returns><see cref="ModifyAreaBanAreasResponse"/></returns>
        public Task<ModifyAreaBanAreasResponse> ModifyAreaBanAreas(ModifyAreaBanAreasRequest req)
        {
            return InternalRequestAsync<ModifyAreaBanAreasResponse>(req, "ModifyAreaBanAreas");
        }

        /// <summary>
        /// 修改地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanAreasRequest"/></param>
        /// <returns><see cref="ModifyAreaBanAreasResponse"/></returns>
        public ModifyAreaBanAreasResponse ModifyAreaBanAreasSync(ModifyAreaBanAreasRequest req)
        {
            return InternalRequestAsync<ModifyAreaBanAreasResponse>(req, "ModifyAreaBanAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加（编辑）地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanRuleRequest"/></param>
        /// <returns><see cref="ModifyAreaBanRuleResponse"/></returns>
        public Task<ModifyAreaBanRuleResponse> ModifyAreaBanRule(ModifyAreaBanRuleRequest req)
        {
            return InternalRequestAsync<ModifyAreaBanRuleResponse>(req, "ModifyAreaBanRule");
        }

        /// <summary>
        /// 添加（编辑）地域封禁中的地域信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanRuleRequest"/></param>
        /// <returns><see cref="ModifyAreaBanRuleResponse"/></returns>
        public ModifyAreaBanRuleResponse ModifyAreaBanRuleSync(ModifyAreaBanRuleRequest req)
        {
            return InternalRequestAsync<ModifyAreaBanRuleResponse>(req, "ModifyAreaBanRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改防护域名的地域封禁状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanStatusRequest"/></param>
        /// <returns><see cref="ModifyAreaBanStatusResponse"/></returns>
        public Task<ModifyAreaBanStatusResponse> ModifyAreaBanStatus(ModifyAreaBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyAreaBanStatusResponse>(req, "ModifyAreaBanStatus");
        }

        /// <summary>
        /// 修改防护域名的地域封禁状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAreaBanStatusRequest"/></param>
        /// <returns><see cref="ModifyAreaBanStatusResponse"/></returns>
        public ModifyAreaBanStatusResponse ModifyAreaBanStatusSync(ModifyAreaBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyAreaBanStatusResponse>(req, "ModifyAreaBanStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 供用户控制台调用，修改Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyAttackWhiteRuleResponse"/></returns>
        public Task<ModifyAttackWhiteRuleResponse> ModifyAttackWhiteRule(ModifyAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyAttackWhiteRuleResponse>(req, "ModifyAttackWhiteRule");
        }

        /// <summary>
        /// 供用户控制台调用，修改Tiga规则引擎白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyAttackWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyAttackWhiteRuleResponse"/></returns>
        public ModifyAttackWhiteRuleResponse ModifyAttackWhiteRuleSync(ModifyAttackWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyAttackWhiteRuleResponse>(req, "ModifyAttackWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bot_V2 bot总开关更新
        /// </summary>
        /// <param name="req"><see cref="ModifyBotStatusRequest"/></param>
        /// <returns><see cref="ModifyBotStatusResponse"/></returns>
        public Task<ModifyBotStatusResponse> ModifyBotStatus(ModifyBotStatusRequest req)
        {
            return InternalRequestAsync<ModifyBotStatusResponse>(req, "ModifyBotStatus");
        }

        /// <summary>
        /// Bot_V2 bot总开关更新
        /// </summary>
        /// <param name="req"><see cref="ModifyBotStatusRequest"/></param>
        /// <returns><see cref="ModifyBotStatusResponse"/></returns>
        public ModifyBotStatusResponse ModifyBotStatusSync(ModifyBotStatusRequest req)
        {
            return InternalRequestAsync<ModifyBotStatusResponse>(req, "ModifyBotStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑自定义规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public Task<ModifyCustomRuleResponse> ModifyCustomRule(ModifyCustomRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleResponse>(req, "ModifyCustomRule");
        }

        /// <summary>
        /// 编辑自定义规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public ModifyCustomRuleResponse ModifyCustomRuleSync(ModifyCustomRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleResponse>(req, "ModifyCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或禁用访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public Task<ModifyCustomRuleStatusResponse> ModifyCustomRuleStatus(ModifyCustomRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleStatusResponse>(req, "ModifyCustomRuleStatus");
        }

        /// <summary>
        /// 开启或禁用访问控制（自定义策略）
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public ModifyCustomRuleStatusResponse ModifyCustomRuleStatusSync(ModifyCustomRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleStatusResponse>(req, "ModifyCustomRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleResponse"/></returns>
        public Task<ModifyCustomWhiteRuleResponse> ModifyCustomWhiteRule(ModifyCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleResponse>(req, "ModifyCustomWhiteRule");
        }

        /// <summary>
        /// 编辑精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleResponse"/></returns>
        public ModifyCustomWhiteRuleResponse ModifyCustomWhiteRuleSync(ModifyCustomWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleResponse>(req, "ModifyCustomWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或禁用精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleStatusResponse"/></returns>
        public Task<ModifyCustomWhiteRuleStatusResponse> ModifyCustomWhiteRuleStatus(ModifyCustomWhiteRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleStatusResponse>(req, "ModifyCustomWhiteRuleStatus");
        }

        /// <summary>
        /// 开启或禁用精准白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomWhiteRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomWhiteRuleStatusResponse"/></returns>
        public ModifyCustomWhiteRuleStatusResponse ModifyCustomWhiteRuleStatusSync(ModifyCustomWhiteRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomWhiteRuleStatusResponse>(req, "ModifyCustomWhiteRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换ipv6开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainIpv6StatusRequest"/></param>
        /// <returns><see cref="ModifyDomainIpv6StatusResponse"/></returns>
        public Task<ModifyDomainIpv6StatusResponse> ModifyDomainIpv6Status(ModifyDomainIpv6StatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainIpv6StatusResponse>(req, "ModifyDomainIpv6Status");
        }

        /// <summary>
        /// 切换ipv6开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainIpv6StatusRequest"/></param>
        /// <returns><see cref="ModifyDomainIpv6StatusResponse"/></returns>
        public ModifyDomainIpv6StatusResponse ModifyDomainIpv6StatusSync(ModifyDomainIpv6StatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainIpv6StatusResponse>(req, "ModifyDomainIpv6Status")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改域名投递状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainPostActionRequest"/></param>
        /// <returns><see cref="ModifyDomainPostActionResponse"/></returns>
        public Task<ModifyDomainPostActionResponse> ModifyDomainPostAction(ModifyDomainPostActionRequest req)
        {
            return InternalRequestAsync<ModifyDomainPostActionResponse>(req, "ModifyDomainPostAction");
        }

        /// <summary>
        /// 修改域名投递状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainPostActionRequest"/></param>
        /// <returns><see cref="ModifyDomainPostActionResponse"/></returns>
        public ModifyDomainPostActionResponse ModifyDomainPostActionSync(ModifyDomainPostActionRequest req)
        {
            return InternalRequestAsync<ModifyDomainPostActionResponse>(req, "ModifyDomainPostAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更改某一条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyDomainWhiteRuleResponse"/></returns>
        public Task<ModifyDomainWhiteRuleResponse> ModifyDomainWhiteRule(ModifyDomainWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyDomainWhiteRuleResponse>(req, "ModifyDomainWhiteRule");
        }

        /// <summary>
        /// 更改某一条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainWhiteRuleRequest"/></param>
        /// <returns><see cref="ModifyDomainWhiteRuleResponse"/></returns>
        public ModifyDomainWhiteRuleResponse ModifyDomainWhiteRuleSync(ModifyDomainWhiteRuleRequest req)
        {
            return InternalRequestAsync<ModifyDomainWhiteRuleResponse>(req, "ModifyDomainWhiteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改域名列表的访问日志开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainsCLSStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainsCLSStatusResponse"/></returns>
        public Task<ModifyDomainsCLSStatusResponse> ModifyDomainsCLSStatus(ModifyDomainsCLSStatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainsCLSStatusResponse>(req, "ModifyDomainsCLSStatus");
        }

        /// <summary>
        /// 修改域名列表的访问日志开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainsCLSStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainsCLSStatusResponse"/></returns>
        public ModifyDomainsCLSStatusResponse ModifyDomainsCLSStatusSync(ModifyDomainsCLSStatusRequest req)
        {
            return InternalRequestAsync<ModifyDomainsCLSStatusResponse>(req, "ModifyDomainsCLSStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供给clb等使用的waf实例下单接口，目前只支持clb旗舰版实例的下单，该接口会进行入参校验，然后调用是否为收购用户，然后调用计费接口下单。目前只支持预付费下单，计费侧接口：https://tcb.woa.com/magical-brush/docs/754661947
        /// </summary>
        /// <param name="req"><see cref="ModifyGenerateDealsRequest"/></param>
        /// <returns><see cref="ModifyGenerateDealsResponse"/></returns>
        public Task<ModifyGenerateDealsResponse> ModifyGenerateDeals(ModifyGenerateDealsRequest req)
        {
            return InternalRequestAsync<ModifyGenerateDealsResponse>(req, "ModifyGenerateDeals");
        }

        /// <summary>
        /// 提供给clb等使用的waf实例下单接口，目前只支持clb旗舰版实例的下单，该接口会进行入参校验，然后调用是否为收购用户，然后调用计费接口下单。目前只支持预付费下单，计费侧接口：https://tcb.woa.com/magical-brush/docs/754661947
        /// </summary>
        /// <param name="req"><see cref="ModifyGenerateDealsRequest"/></param>
        /// <returns><see cref="ModifyGenerateDealsResponse"/></returns>
        public ModifyGenerateDealsResponse ModifyGenerateDealsSync(ModifyGenerateDealsRequest req)
        {
            return InternalRequestAsync<ModifyGenerateDealsResponse>(req, "ModifyGenerateDeals")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑负载均衡型WAF防护域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifyHostRequest"/></param>
        /// <returns><see cref="ModifyHostResponse"/></returns>
        public Task<ModifyHostResponse> ModifyHost(ModifyHostRequest req)
        {
            return InternalRequestAsync<ModifyHostResponse>(req, "ModifyHost");
        }

        /// <summary>
        /// 编辑负载均衡型WAF防护域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifyHostRequest"/></param>
        /// <returns><see cref="ModifyHostResponse"/></returns>
        public ModifyHostResponse ModifyHostSync(ModifyHostRequest req)
        {
            return InternalRequestAsync<ModifyHostResponse>(req, "ModifyHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置负载均衡型WAF防护域名的流量模式，切换镜像模式和清洗模式
        /// </summary>
        /// <param name="req"><see cref="ModifyHostFlowModeRequest"/></param>
        /// <returns><see cref="ModifyHostFlowModeResponse"/></returns>
        public Task<ModifyHostFlowModeResponse> ModifyHostFlowMode(ModifyHostFlowModeRequest req)
        {
            return InternalRequestAsync<ModifyHostFlowModeResponse>(req, "ModifyHostFlowMode");
        }

        /// <summary>
        /// 设置负载均衡型WAF防护域名的流量模式，切换镜像模式和清洗模式
        /// </summary>
        /// <param name="req"><see cref="ModifyHostFlowModeRequest"/></param>
        /// <returns><see cref="ModifyHostFlowModeResponse"/></returns>
        public ModifyHostFlowModeResponse ModifyHostFlowModeSync(ModifyHostFlowModeRequest req)
        {
            return InternalRequestAsync<ModifyHostFlowModeResponse>(req, "ModifyHostFlowMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// clb-waf设置防护域名防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyHostModeRequest"/></param>
        /// <returns><see cref="ModifyHostModeResponse"/></returns>
        public Task<ModifyHostModeResponse> ModifyHostMode(ModifyHostModeRequest req)
        {
            return InternalRequestAsync<ModifyHostModeResponse>(req, "ModifyHostMode");
        }

        /// <summary>
        /// clb-waf设置防护域名防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyHostModeRequest"/></param>
        /// <returns><see cref="ModifyHostModeResponse"/></returns>
        public ModifyHostModeResponse ModifyHostModeSync(ModifyHostModeRequest req)
        {
            return InternalRequestAsync<ModifyHostModeResponse>(req, "ModifyHostMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// clb-waf 设置防护域名WAF开关
        /// 支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyHostStatusRequest"/></param>
        /// <returns><see cref="ModifyHostStatusResponse"/></returns>
        public Task<ModifyHostStatusResponse> ModifyHostStatus(ModifyHostStatusRequest req)
        {
            return InternalRequestAsync<ModifyHostStatusResponse>(req, "ModifyHostStatus");
        }

        /// <summary>
        /// clb-waf 设置防护域名WAF开关
        /// 支持批量操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyHostStatusRequest"/></param>
        /// <returns><see cref="ModifyHostStatusResponse"/></returns>
        public ModifyHostStatusResponse ModifyHostStatusSync(ModifyHostStatusRequest req)
        {
            return InternalRequestAsync<ModifyHostStatusResponse>(req, "ModifyHostStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例的QPS弹性计费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceElasticModeRequest"/></param>
        /// <returns><see cref="ModifyInstanceElasticModeResponse"/></returns>
        public Task<ModifyInstanceElasticModeResponse> ModifyInstanceElasticMode(ModifyInstanceElasticModeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceElasticModeResponse>(req, "ModifyInstanceElasticMode");
        }

        /// <summary>
        /// 修改实例的QPS弹性计费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceElasticModeRequest"/></param>
        /// <returns><see cref="ModifyInstanceElasticModeResponse"/></returns>
        public ModifyInstanceElasticModeResponse ModifyInstanceElasticModeSync(ModifyInstanceElasticModeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceElasticModeResponse>(req, "ModifyInstanceElasticMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName");
        }

        /// <summary>
        /// 修改实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNameResponse>(req, "ModifyInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="ModifyInstanceQpsLimitResponse"/></returns>
        public Task<ModifyInstanceQpsLimitResponse> ModifyInstanceQpsLimit(ModifyInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<ModifyInstanceQpsLimitResponse>(req, "ModifyInstanceQpsLimit");
        }

        /// <summary>
        /// 设置套餐实例的弹性qps上限
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceQpsLimitRequest"/></param>
        /// <returns><see cref="ModifyInstanceQpsLimitResponse"/></returns>
        public ModifyInstanceQpsLimitResponse ModifyInstanceQpsLimitSync(ModifyInstanceQpsLimitRequest req)
        {
            return InternalRequestAsync<ModifyInstanceQpsLimitResponse>(req, "ModifyInstanceQpsLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例的自动续费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstanceRenewFlagResponse"/></returns>
        public Task<ModifyInstanceRenewFlagResponse> ModifyInstanceRenewFlag(ModifyInstanceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceRenewFlagResponse>(req, "ModifyInstanceRenewFlag");
        }

        /// <summary>
        /// 修改实例的自动续费开关
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyInstanceRenewFlagResponse"/></returns>
        public ModifyInstanceRenewFlagResponse ModifyInstanceRenewFlagSync(ModifyInstanceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyInstanceRenewFlagResponse>(req, "ModifyInstanceRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf IP黑白名单编辑接口
        /// </summary>
        /// <param name="req"><see cref="ModifyIpAccessControlRequest"/></param>
        /// <returns><see cref="ModifyIpAccessControlResponse"/></returns>
        public Task<ModifyIpAccessControlResponse> ModifyIpAccessControl(ModifyIpAccessControlRequest req)
        {
            return InternalRequestAsync<ModifyIpAccessControlResponse>(req, "ModifyIpAccessControl");
        }

        /// <summary>
        /// Waf IP黑白名单编辑接口
        /// </summary>
        /// <param name="req"><see cref="ModifyIpAccessControlRequest"/></param>
        /// <returns><see cref="ModifyIpAccessControlResponse"/></returns>
        public ModifyIpAccessControlResponse ModifyIpAccessControlSync(ModifyIpAccessControlRequest req)
        {
            return InternalRequestAsync<ModifyIpAccessControlResponse>(req, "ModifyIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置某个domain下基础安全模块的开关
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleStatusRequest"/></param>
        /// <returns><see cref="ModifyModuleStatusResponse"/></returns>
        public Task<ModifyModuleStatusResponse> ModifyModuleStatus(ModifyModuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyModuleStatusResponse>(req, "ModifyModuleStatus");
        }

        /// <summary>
        /// 设置某个domain下基础安全模块的开关
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleStatusRequest"/></param>
        /// <returns><see cref="ModifyModuleStatusResponse"/></returns>
        public ModifyModuleStatusResponse ModifyModuleStatusSync(ModifyModuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyModuleStatusResponse>(req, "ModifyModuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改防护对象
        /// </summary>
        /// <param name="req"><see cref="ModifyObjectRequest"/></param>
        /// <returns><see cref="ModifyObjectResponse"/></returns>
        public Task<ModifyObjectResponse> ModifyObject(ModifyObjectRequest req)
        {
            return InternalRequestAsync<ModifyObjectResponse>(req, "ModifyObject");
        }

        /// <summary>
        /// 修改防护对象
        /// </summary>
        /// <param name="req"><see cref="ModifyObjectRequest"/></param>
        /// <returns><see cref="ModifyObjectResponse"/></returns>
        public ModifyObjectResponse ModifyObjectSync(ModifyObjectRequest req)
        {
            return InternalRequestAsync<ModifyObjectResponse>(req, "ModifyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启、关闭WAF开关
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionStatusRequest"/></param>
        /// <returns><see cref="ModifyProtectionStatusResponse"/></returns>
        public Task<ModifyProtectionStatusResponse> ModifyProtectionStatus(ModifyProtectionStatusRequest req)
        {
            return InternalRequestAsync<ModifyProtectionStatusResponse>(req, "ModifyProtectionStatus");
        }

        /// <summary>
        /// 开启、关闭WAF开关
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionStatusRequest"/></param>
        /// <returns><see cref="ModifyProtectionStatusResponse"/></returns>
        public ModifyProtectionStatusResponse ModifyProtectionStatusSync(ModifyProtectionStatusRequest req)
        {
            return InternalRequestAsync<ModifyProtectionStatusResponse>(req, "ModifyProtectionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑SaaS型WAF域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionResponse"/></returns>
        public Task<ModifySpartaProtectionResponse> ModifySpartaProtection(ModifySpartaProtectionRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionResponse>(req, "ModifySpartaProtection");
        }

        /// <summary>
        /// 编辑SaaS型WAF域名配置
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionResponse"/></returns>
        public ModifySpartaProtectionResponse ModifySpartaProtectionSync(ModifySpartaProtectionRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionResponse>(req, "ModifySpartaProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置waf防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionModeRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionModeResponse"/></returns>
        public Task<ModifySpartaProtectionModeResponse> ModifySpartaProtectionMode(ModifySpartaProtectionModeRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionModeResponse>(req, "ModifySpartaProtectionMode");
        }

        /// <summary>
        /// 设置waf防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifySpartaProtectionModeRequest"/></param>
        /// <returns><see cref="ModifySpartaProtectionModeResponse"/></returns>
        public ModifySpartaProtectionModeResponse ModifySpartaProtectionModeSync(ModifySpartaProtectionModeRequest req)
        {
            return InternalRequestAsync<ModifySpartaProtectionModeResponse>(req, "ModifySpartaProtectionMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户防护规则等级
        /// </summary>
        /// <param name="req"><see cref="ModifyUserLevelRequest"/></param>
        /// <returns><see cref="ModifyUserLevelResponse"/></returns>
        public Task<ModifyUserLevelResponse> ModifyUserLevel(ModifyUserLevelRequest req)
        {
            return InternalRequestAsync<ModifyUserLevelResponse>(req, "ModifyUserLevel");
        }

        /// <summary>
        /// 修改用户防护规则等级
        /// </summary>
        /// <param name="req"><see cref="ModifyUserLevelRequest"/></param>
        /// <returns><see cref="ModifyUserLevelResponse"/></returns>
        public ModifyUserLevelResponse ModifyUserLevelSync(ModifyUserLevelRequest req)
        {
            return InternalRequestAsync<ModifyUserLevelResponse>(req, "ModifyUserLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换Tiga引擎规则类型的生效开关
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureClassRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureClassResponse"/></returns>
        public Task<ModifyUserSignatureClassResponse> ModifyUserSignatureClass(ModifyUserSignatureClassRequest req)
        {
            return InternalRequestAsync<ModifyUserSignatureClassResponse>(req, "ModifyUserSignatureClass");
        }

        /// <summary>
        /// 切换Tiga引擎规则类型的生效开关
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureClassRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureClassResponse"/></returns>
        public ModifyUserSignatureClassResponse ModifyUserSignatureClassSync(ModifyUserSignatureClassRequest req)
        {
            return InternalRequestAsync<ModifyUserSignatureClassResponse>(req, "ModifyUserSignatureClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户防护规则，开启关闭具体的某条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleResponse"/></returns>
        public Task<ModifyUserSignatureRuleResponse> ModifyUserSignatureRule(ModifyUserSignatureRuleRequest req)
        {
            return InternalRequestAsync<ModifyUserSignatureRuleResponse>(req, "ModifyUserSignatureRule");
        }

        /// <summary>
        /// 修改用户防护规则，开启关闭具体的某条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleRequest"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleResponse"/></returns>
        public ModifyUserSignatureRuleResponse ModifyUserSignatureRuleSync(ModifyUserSignatureRuleRequest req)
        {
            return InternalRequestAsync<ModifyUserSignatureRuleResponse>(req, "ModifyUserSignatureRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户防护规则，开启关闭具体的某条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleV2Request"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleV2Response"/></returns>
        public Task<ModifyUserSignatureRuleV2Response> ModifyUserSignatureRuleV2(ModifyUserSignatureRuleV2Request req)
        {
            return InternalRequestAsync<ModifyUserSignatureRuleV2Response>(req, "ModifyUserSignatureRuleV2");
        }

        /// <summary>
        /// 修改用户防护规则，开启关闭具体的某条规则
        /// </summary>
        /// <param name="req"><see cref="ModifyUserSignatureRuleV2Request"/></param>
        /// <returns><see cref="ModifyUserSignatureRuleV2Response"/></returns>
        public ModifyUserSignatureRuleV2Response ModifyUserSignatureRuleV2Sync(ModifyUserSignatureRuleV2Request req)
        {
            return InternalRequestAsync<ModifyUserSignatureRuleV2Response>(req, "ModifyUserSignatureRuleV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改ip惩罚规则
        /// </summary>
        /// <param name="req"><see cref="ModifyWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="ModifyWafAutoDenyRulesResponse"/></returns>
        public Task<ModifyWafAutoDenyRulesResponse> ModifyWafAutoDenyRules(ModifyWafAutoDenyRulesRequest req)
        {
            return InternalRequestAsync<ModifyWafAutoDenyRulesResponse>(req, "ModifyWafAutoDenyRules");
        }

        /// <summary>
        /// 修改ip惩罚规则
        /// </summary>
        /// <param name="req"><see cref="ModifyWafAutoDenyRulesRequest"/></param>
        /// <returns><see cref="ModifyWafAutoDenyRulesResponse"/></returns>
        public ModifyWafAutoDenyRulesResponse ModifyWafAutoDenyRulesSync(ModifyWafAutoDenyRulesRequest req)
        {
            return InternalRequestAsync<ModifyWafAutoDenyRulesResponse>(req, "ModifyWafAutoDenyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置WAF威胁情报封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="ModifyWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="ModifyWafThreatenIntelligenceResponse"/></returns>
        public Task<ModifyWafThreatenIntelligenceResponse> ModifyWafThreatenIntelligence(ModifyWafThreatenIntelligenceRequest req)
        {
            return InternalRequestAsync<ModifyWafThreatenIntelligenceResponse>(req, "ModifyWafThreatenIntelligence");
        }

        /// <summary>
        /// 配置WAF威胁情报封禁模块详情
        /// </summary>
        /// <param name="req"><see cref="ModifyWafThreatenIntelligenceRequest"/></param>
        /// <returns><see cref="ModifyWafThreatenIntelligenceResponse"/></returns>
        public ModifyWafThreatenIntelligenceResponse ModifyWafThreatenIntelligenceSync(ModifyWafThreatenIntelligenceRequest req)
        {
            return InternalRequestAsync<ModifyWafThreatenIntelligenceResponse>(req, "ModifyWafThreatenIntelligence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置域名的webshell状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebshellStatusRequest"/></param>
        /// <returns><see cref="ModifyWebshellStatusResponse"/></returns>
        public Task<ModifyWebshellStatusResponse> ModifyWebshellStatus(ModifyWebshellStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebshellStatusResponse>(req, "ModifyWebshellStatus");
        }

        /// <summary>
        /// 设置域名的webshell状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebshellStatusRequest"/></param>
        /// <returns><see cref="ModifyWebshellStatusResponse"/></returns>
        public ModifyWebshellStatusResponse ModifyWebshellStatusSync(ModifyWebshellStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebshellStatusResponse>(req, "ModifyWebshellStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建搜索下载攻击日志任务，使用CLS新版本的搜索下载getlog接口
        /// </summary>
        /// <param name="req"><see cref="PostAttackDownloadTaskRequest"/></param>
        /// <returns><see cref="PostAttackDownloadTaskResponse"/></returns>
        public Task<PostAttackDownloadTaskResponse> PostAttackDownloadTask(PostAttackDownloadTaskRequest req)
        {
            return InternalRequestAsync<PostAttackDownloadTaskResponse>(req, "PostAttackDownloadTask");
        }

        /// <summary>
        /// 创建搜索下载攻击日志任务，使用CLS新版本的搜索下载getlog接口
        /// </summary>
        /// <param name="req"><see cref="PostAttackDownloadTaskRequest"/></param>
        /// <returns><see cref="PostAttackDownloadTaskResponse"/></returns>
        public PostAttackDownloadTaskResponse PostAttackDownloadTaskSync(PostAttackDownloadTaskRequest req)
        {
            return InternalRequestAsync<PostAttackDownloadTaskResponse>(req, "PostAttackDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 刷新接入检查的结果，后台会生成接入检查任务
        /// </summary>
        /// <param name="req"><see cref="RefreshAccessCheckResultRequest"/></param>
        /// <returns><see cref="RefreshAccessCheckResultResponse"/></returns>
        public Task<RefreshAccessCheckResultResponse> RefreshAccessCheckResult(RefreshAccessCheckResultRequest req)
        {
            return InternalRequestAsync<RefreshAccessCheckResultResponse>(req, "RefreshAccessCheckResult");
        }

        /// <summary>
        /// 刷新接入检查的结果，后台会生成接入检查任务
        /// </summary>
        /// <param name="req"><see cref="RefreshAccessCheckResultRequest"/></param>
        /// <returns><see cref="RefreshAccessCheckResultResponse"/></returns>
        public RefreshAccessCheckResultResponse RefreshAccessCheckResultSync(RefreshAccessCheckResultRequest req)
        {
            return InternalRequestAsync<RefreshAccessCheckResultResponse>(req, "RefreshAccessCheckResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于搜索WAF访问日志
        /// </summary>
        /// <param name="req"><see cref="SearchAccessLogRequest"/></param>
        /// <returns><see cref="SearchAccessLogResponse"/></returns>
        public Task<SearchAccessLogResponse> SearchAccessLog(SearchAccessLogRequest req)
        {
            return InternalRequestAsync<SearchAccessLogResponse>(req, "SearchAccessLog");
        }

        /// <summary>
        /// 本接口用于搜索WAF访问日志
        /// </summary>
        /// <param name="req"><see cref="SearchAccessLogRequest"/></param>
        /// <returns><see cref="SearchAccessLogResponse"/></returns>
        public SearchAccessLogResponse SearchAccessLogSync(SearchAccessLogRequest req)
        {
            return InternalRequestAsync<SearchAccessLogResponse>(req, "SearchAccessLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新版本CLS接口存在参数变化，query改成了query_string支持lucence语法接口搜索查询。
        /// </summary>
        /// <param name="req"><see cref="SearchAttackLogRequest"/></param>
        /// <returns><see cref="SearchAttackLogResponse"/></returns>
        public Task<SearchAttackLogResponse> SearchAttackLog(SearchAttackLogRequest req)
        {
            return InternalRequestAsync<SearchAttackLogResponse>(req, "SearchAttackLog");
        }

        /// <summary>
        /// 新版本CLS接口存在参数变化，query改成了query_string支持lucence语法接口搜索查询。
        /// </summary>
        /// <param name="req"><see cref="SearchAttackLogRequest"/></param>
        /// <returns><see cref="SearchAttackLogResponse"/></returns>
        public SearchAttackLogResponse SearchAttackLogSync(SearchAttackLogRequest req)
        {
            return InternalRequestAsync<SearchAttackLogResponse>(req, "SearchAttackLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换域名的规则开关
        /// </summary>
        /// <param name="req"><see cref="SwitchDomainRulesRequest"/></param>
        /// <returns><see cref="SwitchDomainRulesResponse"/></returns>
        public Task<SwitchDomainRulesResponse> SwitchDomainRules(SwitchDomainRulesRequest req)
        {
            return InternalRequestAsync<SwitchDomainRulesResponse>(req, "SwitchDomainRules");
        }

        /// <summary>
        /// 切换域名的规则开关
        /// </summary>
        /// <param name="req"><see cref="SwitchDomainRulesRequest"/></param>
        /// <returns><see cref="SwitchDomainRulesResponse"/></returns>
        public SwitchDomainRulesResponse SwitchDomainRulesSync(SwitchDomainRulesRequest req)
        {
            return InternalRequestAsync<SwitchDomainRulesResponse>(req, "SwitchDomainRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换弹性的开关
        /// </summary>
        /// <param name="req"><see cref="SwitchElasticModeRequest"/></param>
        /// <returns><see cref="SwitchElasticModeResponse"/></returns>
        public Task<SwitchElasticModeResponse> SwitchElasticMode(SwitchElasticModeRequest req)
        {
            return InternalRequestAsync<SwitchElasticModeResponse>(req, "SwitchElasticMode");
        }

        /// <summary>
        /// 切换弹性的开关
        /// </summary>
        /// <param name="req"><see cref="SwitchElasticModeRequest"/></param>
        /// <returns><see cref="SwitchElasticModeResponse"/></returns>
        public SwitchElasticModeResponse SwitchElasticModeSync(SwitchElasticModeRequest req)
        {
            return InternalRequestAsync<SwitchElasticModeResponse>(req, "SwitchElasticMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新Tiga引擎下大类规则的防护模式
        /// </summary>
        /// <param name="req"><see cref="UpdateProtectionModesRequest"/></param>
        /// <returns><see cref="UpdateProtectionModesResponse"/></returns>
        public Task<UpdateProtectionModesResponse> UpdateProtectionModes(UpdateProtectionModesRequest req)
        {
            return InternalRequestAsync<UpdateProtectionModesResponse>(req, "UpdateProtectionModes");
        }

        /// <summary>
        /// 更新Tiga引擎下大类规则的防护模式
        /// </summary>
        /// <param name="req"><see cref="UpdateProtectionModesRequest"/></param>
        /// <returns><see cref="UpdateProtectionModesResponse"/></returns>
        public UpdateProtectionModesResponse UpdateProtectionModesSync(UpdateProtectionModesRequest req)
        {
            return InternalRequestAsync<UpdateProtectionModesResponse>(req, "UpdateProtectionModes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑SAAS型接入的紧急CC防护状态
        /// </summary>
        /// <param name="req"><see cref="UpsertCCAutoStatusRequest"/></param>
        /// <returns><see cref="UpsertCCAutoStatusResponse"/></returns>
        public Task<UpsertCCAutoStatusResponse> UpsertCCAutoStatus(UpsertCCAutoStatusRequest req)
        {
            return InternalRequestAsync<UpsertCCAutoStatusResponse>(req, "UpsertCCAutoStatus");
        }

        /// <summary>
        /// 编辑SAAS型接入的紧急CC防护状态
        /// </summary>
        /// <param name="req"><see cref="UpsertCCAutoStatusRequest"/></param>
        /// <returns><see cref="UpsertCCAutoStatusResponse"/></returns>
        public UpsertCCAutoStatusResponse UpsertCCAutoStatusSync(UpsertCCAutoStatusRequest req)
        {
            return InternalRequestAsync<UpsertCCAutoStatusResponse>(req, "UpsertCCAutoStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf  CC V2 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertCCRuleRequest"/></param>
        /// <returns><see cref="UpsertCCRuleResponse"/></returns>
        public Task<UpsertCCRuleResponse> UpsertCCRule(UpsertCCRuleRequest req)
        {
            return InternalRequestAsync<UpsertCCRuleResponse>(req, "UpsertCCRule");
        }

        /// <summary>
        /// Waf  CC V2 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertCCRuleRequest"/></param>
        /// <returns><see cref="UpsertCCRuleResponse"/></returns>
        public UpsertCCRuleResponse UpsertCCRuleSync(UpsertCCRuleRequest req)
        {
            return InternalRequestAsync<UpsertCCRuleResponse>(req, "UpsertCCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf IP黑白名单Upsert接口（建议使用CreateIpAccessControl、ModifyIpAccessControl来替换当前接口）
        /// </summary>
        /// <param name="req"><see cref="UpsertIpAccessControlRequest"/></param>
        /// <returns><see cref="UpsertIpAccessControlResponse"/></returns>
        public Task<UpsertIpAccessControlResponse> UpsertIpAccessControl(UpsertIpAccessControlRequest req)
        {
            return InternalRequestAsync<UpsertIpAccessControlResponse>(req, "UpsertIpAccessControl");
        }

        /// <summary>
        /// Waf IP黑白名单Upsert接口（建议使用CreateIpAccessControl、ModifyIpAccessControl来替换当前接口）
        /// </summary>
        /// <param name="req"><see cref="UpsertIpAccessControlRequest"/></param>
        /// <returns><see cref="UpsertIpAccessControlResponse"/></returns>
        public UpsertIpAccessControlResponse UpsertIpAccessControlSync(UpsertIpAccessControlRequest req)
        {
            return InternalRequestAsync<UpsertIpAccessControlResponse>(req, "UpsertIpAccessControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waf  会话定义 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertSessionRequest"/></param>
        /// <returns><see cref="UpsertSessionResponse"/></returns>
        public Task<UpsertSessionResponse> UpsertSession(UpsertSessionRequest req)
        {
            return InternalRequestAsync<UpsertSessionResponse>(req, "UpsertSession");
        }

        /// <summary>
        /// Waf  会话定义 Upsert接口
        /// </summary>
        /// <param name="req"><see cref="UpsertSessionRequest"/></param>
        /// <returns><see cref="UpsertSessionResponse"/></returns>
        public UpsertSessionResponse UpsertSessionSync(UpsertSessionRequest req)
        {
            return InternalRequestAsync<UpsertSessionResponse>(req, "UpsertSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
