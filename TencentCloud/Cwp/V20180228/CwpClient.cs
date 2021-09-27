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

namespace TencentCloud.Cwp.V20180228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cwp.V20180228.Models;

   public class CwpClient : AbstractClient{

       private const string endpoint = "cwp.tencentcloudapi.com";
       private const string version = "2018-02-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CwpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CwpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 取消漏洞忽略
        /// </summary>
        /// <param name="req"><see cref="CancelIgnoreVulRequest"/></param>
        /// <returns><see cref="CancelIgnoreVulResponse"/></returns>
        public async Task<CancelIgnoreVulResponse> CancelIgnoreVul(CancelIgnoreVulRequest req)
        {
             JsonResponseModel<CancelIgnoreVulResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelIgnoreVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelIgnoreVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消漏洞忽略
        /// </summary>
        /// <param name="req"><see cref="CancelIgnoreVulRequest"/></param>
        /// <returns><see cref="CancelIgnoreVulResponse"/></returns>
        public CancelIgnoreVulResponse CancelIgnoreVulSync(CancelIgnoreVulRequest req)
        {
             JsonResponseModel<CancelIgnoreVulResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelIgnoreVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelIgnoreVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检测项id或事件id批量忽略事件或取消忽略
        /// </summary>
        /// <param name="req"><see cref="ChangeRuleEventsIgnoreStatusRequest"/></param>
        /// <returns><see cref="ChangeRuleEventsIgnoreStatusResponse"/></returns>
        public async Task<ChangeRuleEventsIgnoreStatusResponse> ChangeRuleEventsIgnoreStatus(ChangeRuleEventsIgnoreStatusRequest req)
        {
             JsonResponseModel<ChangeRuleEventsIgnoreStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeRuleEventsIgnoreStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeRuleEventsIgnoreStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检测项id或事件id批量忽略事件或取消忽略
        /// </summary>
        /// <param name="req"><see cref="ChangeRuleEventsIgnoreStatusRequest"/></param>
        /// <returns><see cref="ChangeRuleEventsIgnoreStatusResponse"/></returns>
        public ChangeRuleEventsIgnoreStatusResponse ChangeRuleEventsIgnoreStatusSync(ChangeRuleEventsIgnoreStatusRequest req)
        {
             JsonResponseModel<ChangeRuleEventsIgnoreStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeRuleEventsIgnoreStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeRuleEventsIgnoreStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验高危命令用户规则新增和编辑时的参数。
        /// </summary>
        /// <param name="req"><see cref="CheckBashRuleParamsRequest"/></param>
        /// <returns><see cref="CheckBashRuleParamsResponse"/></returns>
        public async Task<CheckBashRuleParamsResponse> CheckBashRuleParams(CheckBashRuleParamsRequest req)
        {
             JsonResponseModel<CheckBashRuleParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBashRuleParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBashRuleParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验高危命令用户规则新增和编辑时的参数。
        /// </summary>
        /// <param name="req"><see cref="CheckBashRuleParamsRequest"/></param>
        /// <returns><see cref="CheckBashRuleParamsResponse"/></returns>
        public CheckBashRuleParamsResponse CheckBashRuleParamsSync(CheckBashRuleParamsRequest req)
        {
             JsonResponseModel<CheckBashRuleParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBashRuleParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBashRuleParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CloseProVersion) 用于关闭专业版。
        /// </summary>
        /// <param name="req"><see cref="CloseProVersionRequest"/></param>
        /// <returns><see cref="CloseProVersionResponse"/></returns>
        public async Task<CloseProVersionResponse> CloseProVersion(CloseProVersionRequest req)
        {
             JsonResponseModel<CloseProVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CloseProVersion) 用于关闭专业版。
        /// </summary>
        /// <param name="req"><see cref="CloseProVersionRequest"/></param>
        /// <returns><see cref="CloseProVersionResponse"/></returns>
        public CloseProVersionResponse CloseProVersionSync(CloseProVersionRequest req)
        {
             JsonResponseModel<CloseProVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据策略信息创建基线策略
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineStrategyRequest"/></param>
        /// <returns><see cref="CreateBaselineStrategyResponse"/></returns>
        public async Task<CreateBaselineStrategyResponse> CreateBaselineStrategy(CreateBaselineStrategyRequest req)
        {
             JsonResponseModel<CreateBaselineStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBaselineStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBaselineStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据策略信息创建基线策略
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineStrategyRequest"/></param>
        /// <returns><see cref="CreateBaselineStrategyResponse"/></returns>
        public CreateBaselineStrategyResponse CreateBaselineStrategySync(CreateBaselineStrategyRequest req)
        {
             JsonResponseModel<CreateBaselineStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBaselineStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBaselineStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应急漏洞扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulScanRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulScanResponse"/></returns>
        public async Task<CreateEmergencyVulScanResponse> CreateEmergencyVulScan(CreateEmergencyVulScanRequest req)
        {
             JsonResponseModel<CreateEmergencyVulScanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmergencyVulScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmergencyVulScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应急漏洞扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulScanRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulScanResponse"/></returns>
        public CreateEmergencyVulScanResponse CreateEmergencyVulScanSync(CreateEmergencyVulScanRequest req)
        {
             JsonResponseModel<CreateEmergencyVulScanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmergencyVulScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmergencyVulScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加网站防护服务器
        /// </summary>
        /// <param name="req"><see cref="CreateProtectServerRequest"/></param>
        /// <returns><see cref="CreateProtectServerResponse"/></returns>
        public async Task<CreateProtectServerResponse> CreateProtectServer(CreateProtectServerRequest req)
        {
             JsonResponseModel<CreateProtectServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProtectServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtectServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加网站防护服务器
        /// </summary>
        /// <param name="req"><see cref="CreateProtectServerRequest"/></param>
        /// <returns><see cref="CreateProtectServerResponse"/></returns>
        public CreateProtectServerResponse CreateProtectServerSync(CreateProtectServerRequest req)
        {
             JsonResponseModel<CreateProtectServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProtectServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProtectServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以对入侵检测-文件查杀扫描检测
        /// </summary>
        /// <param name="req"><see cref="CreateScanMalwareSettingRequest"/></param>
        /// <returns><see cref="CreateScanMalwareSettingResponse"/></returns>
        public async Task<CreateScanMalwareSettingResponse> CreateScanMalwareSetting(CreateScanMalwareSettingRequest req)
        {
             JsonResponseModel<CreateScanMalwareSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScanMalwareSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScanMalwareSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以对入侵检测-文件查杀扫描检测
        /// </summary>
        /// <param name="req"><see cref="CreateScanMalwareSettingRequest"/></param>
        /// <returns><see cref="CreateScanMalwareSettingResponse"/></returns>
        public CreateScanMalwareSettingResponse CreateScanMalwareSettingSync(CreateScanMalwareSettingRequest req)
        {
             JsonResponseModel<CreateScanMalwareSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScanMalwareSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScanMalwareSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加历史搜索记录
        /// </summary>
        /// <param name="req"><see cref="CreateSearchLogRequest"/></param>
        /// <returns><see cref="CreateSearchLogResponse"/></returns>
        public async Task<CreateSearchLogResponse> CreateSearchLog(CreateSearchLogRequest req)
        {
             JsonResponseModel<CreateSearchLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加历史搜索记录
        /// </summary>
        /// <param name="req"><see cref="CreateSearchLogRequest"/></param>
        /// <returns><see cref="CreateSearchLogResponse"/></returns>
        public CreateSearchLogResponse CreateSearchLogSync(CreateSearchLogRequest req)
        {
             JsonResponseModel<CreateSearchLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加检索模板
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public async Task<CreateSearchTemplateResponse> CreateSearchTemplate(CreateSearchTemplateRequest req)
        {
             JsonResponseModel<CreateSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加检索模板
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public CreateSearchTemplateResponse CreateSearchTemplateSync(CreateSearchTemplateRequest req)
        {
             JsonResponseModel<CreateSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackLogsRequest"/></param>
        /// <returns><see cref="DeleteAttackLogsResponse"/></returns>
        public async Task<DeleteAttackLogsResponse> DeleteAttackLogs(DeleteAttackLogsRequest req)
        {
             JsonResponseModel<DeleteAttackLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAttackLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackLogsRequest"/></param>
        /// <returns><see cref="DeleteAttackLogsResponse"/></returns>
        public DeleteAttackLogsResponse DeleteAttackLogsSync(DeleteAttackLogsRequest req)
        {
             JsonResponseModel<DeleteAttackLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAttackLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineStrategyRequest"/></param>
        /// <returns><see cref="DeleteBaselineStrategyResponse"/></returns>
        public async Task<DeleteBaselineStrategyResponse> DeleteBaselineStrategy(DeleteBaselineStrategyRequest req)
        {
             JsonResponseModel<DeleteBaselineStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBaselineStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineStrategyRequest"/></param>
        /// <returns><see cref="DeleteBaselineStrategyResponse"/></returns>
        public DeleteBaselineStrategyResponse DeleteBaselineStrategySync(DeleteBaselineStrategyRequest req)
        {
             JsonResponseModel<DeleteBaselineStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBaselineStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据Ids删除高危命令事件
        /// </summary>
        /// <param name="req"><see cref="DeleteBashEventsRequest"/></param>
        /// <returns><see cref="DeleteBashEventsResponse"/></returns>
        public async Task<DeleteBashEventsResponse> DeleteBashEvents(DeleteBashEventsRequest req)
        {
             JsonResponseModel<DeleteBashEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBashEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBashEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据Ids删除高危命令事件
        /// </summary>
        /// <param name="req"><see cref="DeleteBashEventsRequest"/></param>
        /// <returns><see cref="DeleteBashEventsResponse"/></returns>
        public DeleteBashEventsResponse DeleteBashEventsSync(DeleteBashEventsRequest req)
        {
             JsonResponseModel<DeleteBashEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBashEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBashEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除高危命令规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBashRulesRequest"/></param>
        /// <returns><see cref="DeleteBashRulesResponse"/></returns>
        public async Task<DeleteBashRulesResponse> DeleteBashRules(DeleteBashRulesRequest req)
        {
             JsonResponseModel<DeleteBashRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除高危命令规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBashRulesRequest"/></param>
        /// <returns><see cref="DeleteBashRulesResponse"/></returns>
        public DeleteBashRulesResponse DeleteBashRulesSync(DeleteBashRulesRequest req)
        {
             JsonResponseModel<DeleteBashRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteBruteAttacks) 用于删除暴力破解记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public async Task<DeleteBruteAttacksResponse> DeleteBruteAttacks(DeleteBruteAttacksRequest req)
        {
             JsonResponseModel<DeleteBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteBruteAttacks) 用于删除暴力破解记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public DeleteBruteAttacksResponse DeleteBruteAttacksSync(DeleteBruteAttacksRequest req)
        {
             JsonResponseModel<DeleteBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除异地登录白名单规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public async Task<DeleteLoginWhiteListResponse> DeleteLoginWhiteList(DeleteLoginWhiteListRequest req)
        {
             JsonResponseModel<DeleteLoginWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoginWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoginWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除异地登录白名单规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public DeleteLoginWhiteListResponse DeleteLoginWhiteListSync(DeleteLoginWhiteListRequest req)
        {
             JsonResponseModel<DeleteLoginWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoginWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoginWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMachine）用于卸载云镜客户端。
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public async Task<DeleteMachineResponse> DeleteMachine(DeleteMachineRequest req)
        {
             JsonResponseModel<DeleteMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMachine）用于卸载云镜客户端。
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public DeleteMachineResponse DeleteMachineSync(DeleteMachineRequest req)
        {
             JsonResponseModel<DeleteMachineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务器关联的标签
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public async Task<DeleteMachineTagResponse> DeleteMachineTag(DeleteMachineTagRequest req)
        {
             JsonResponseModel<DeleteMachineTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachineTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务器关联的标签
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public DeleteMachineTagResponse DeleteMachineTagSync(DeleteMachineTagRequest req)
        {
             JsonResponseModel<DeleteMachineTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMachineTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteMaliciousRequests) 用于删除恶意请求记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public async Task<DeleteMaliciousRequestsResponse> DeleteMaliciousRequests(DeleteMaliciousRequestsRequest req)
        {
             JsonResponseModel<DeleteMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteMaliciousRequests) 用于删除恶意请求记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public DeleteMaliciousRequestsResponse DeleteMaliciousRequestsSync(DeleteMaliciousRequestsRequest req)
        {
             JsonResponseModel<DeleteMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵管理-终止扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteMalwareScanTaskResponse"/></returns>
        public async Task<DeleteMalwareScanTaskResponse> DeleteMalwareScanTask(DeleteMalwareScanTaskRequest req)
        {
             JsonResponseModel<DeleteMalwareScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMalwareScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMalwareScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵管理-终止扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteMalwareScanTaskResponse"/></returns>
        public DeleteMalwareScanTaskResponse DeleteMalwareScanTaskSync(DeleteMalwareScanTaskRequest req)
        {
             JsonResponseModel<DeleteMalwareScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMalwareScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMalwareScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteMalwares) 用于删除木马记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public async Task<DeleteMalwaresResponse> DeleteMalwares(DeleteMalwaresRequest req)
        {
             JsonResponseModel<DeleteMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteMalwares) 用于删除木马记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public DeleteMalwaresResponse DeleteMalwaresSync(DeleteMalwaresRequest req)
        {
             JsonResponseModel<DeleteMalwaresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteNonlocalLoginPlaces) 用于删除异地登录记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public async Task<DeleteNonlocalLoginPlacesResponse> DeleteNonlocalLoginPlaces(DeleteNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<DeleteNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteNonlocalLoginPlaces) 用于删除异地登录记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public DeleteNonlocalLoginPlacesResponse DeleteNonlocalLoginPlacesSync(DeleteNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<DeleteNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据Ids删除本地提权
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DeletePrivilegeEventsResponse"/></returns>
        public async Task<DeletePrivilegeEventsResponse> DeletePrivilegeEvents(DeletePrivilegeEventsRequest req)
        {
             JsonResponseModel<DeletePrivilegeEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrivilegeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivilegeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据Ids删除本地提权
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DeletePrivilegeEventsResponse"/></returns>
        public DeletePrivilegeEventsResponse DeletePrivilegeEventsSync(DeletePrivilegeEventsRequest req)
        {
             JsonResponseModel<DeletePrivilegeEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrivilegeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivilegeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除本地提权规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DeletePrivilegeRulesResponse"/></returns>
        public async Task<DeletePrivilegeRulesResponse> DeletePrivilegeRules(DeletePrivilegeRulesRequest req)
        {
             JsonResponseModel<DeletePrivilegeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrivilegeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivilegeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除本地提权规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DeletePrivilegeRulesResponse"/></returns>
        public DeletePrivilegeRulesResponse DeletePrivilegeRulesSync(DeletePrivilegeRulesRequest req)
        {
             JsonResponseModel<DeletePrivilegeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrivilegeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivilegeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除防护网站
        /// </summary>
        /// <param name="req"><see cref="DeleteProtectDirRequest"/></param>
        /// <returns><see cref="DeleteProtectDirResponse"/></returns>
        public async Task<DeleteProtectDirResponse> DeleteProtectDir(DeleteProtectDirRequest req)
        {
             JsonResponseModel<DeleteProtectDirResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProtectDir");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProtectDirResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除防护网站
        /// </summary>
        /// <param name="req"><see cref="DeleteProtectDirRequest"/></param>
        /// <returns><see cref="DeleteProtectDirResponse"/></returns>
        public DeleteProtectDirResponse DeleteProtectDirSync(DeleteProtectDirRequest req)
        {
             JsonResponseModel<DeleteProtectDirResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProtectDir");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProtectDirResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据Ids删除反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public async Task<DeleteReverseShellEventsResponse> DeleteReverseShellEvents(DeleteReverseShellEventsRequest req)
        {
             JsonResponseModel<DeleteReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据Ids删除反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public DeleteReverseShellEventsResponse DeleteReverseShellEventsSync(DeleteReverseShellEventsRequest req)
        {
             JsonResponseModel<DeleteReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除反弹Shell规则
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellRulesRequest"/></param>
        /// <returns><see cref="DeleteReverseShellRulesResponse"/></returns>
        public async Task<DeleteReverseShellRulesResponse> DeleteReverseShellRules(DeleteReverseShellRulesRequest req)
        {
             JsonResponseModel<DeleteReverseShellRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReverseShellRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除反弹Shell规则
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellRulesRequest"/></param>
        /// <returns><see cref="DeleteReverseShellRulesResponse"/></returns>
        public DeleteReverseShellRulesResponse DeleteReverseShellRulesSync(DeleteReverseShellRulesRequest req)
        {
             JsonResponseModel<DeleteReverseShellRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReverseShellRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除检索模板
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public async Task<DeleteSearchTemplateResponse> DeleteSearchTemplate(DeleteSearchTemplateRequest req)
        {
             JsonResponseModel<DeleteSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除检索模板
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public DeleteSearchTemplateResponse DeleteSearchTemplateSync(DeleteSearchTemplateRequest req)
        {
             JsonResponseModel<DeleteSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public async Task<DeleteTagsResponse> DeleteTags(DeleteTagsRequest req)
        {
             JsonResponseModel<DeleteTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public DeleteTagsResponse DeleteTagsSync(DeleteTagsRequest req)
        {
             JsonResponseModel<DeleteTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改-删除事件记录
        /// </summary>
        /// <param name="req"><see cref="DeleteWebPageEventLogRequest"/></param>
        /// <returns><see cref="DeleteWebPageEventLogResponse"/></returns>
        public async Task<DeleteWebPageEventLogResponse> DeleteWebPageEventLog(DeleteWebPageEventLogRequest req)
        {
             JsonResponseModel<DeleteWebPageEventLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWebPageEventLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebPageEventLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改-删除事件记录
        /// </summary>
        /// <param name="req"><see cref="DeleteWebPageEventLogRequest"/></param>
        /// <returns><see cref="DeleteWebPageEventLogResponse"/></returns>
        public DeleteWebPageEventLogResponse DeleteWebPageEventLogSync(DeleteWebPageEventLogRequest req)
        {
             JsonResponseModel<DeleteWebPageEventLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWebPageEventLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebPageEventLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAccountStatistics) 用于获取帐号统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public async Task<DescribeAccountStatisticsResponse> DescribeAccountStatistics(DescribeAccountStatisticsRequest req)
        {
             JsonResponseModel<DescribeAccountStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAccountStatistics) 用于获取帐号统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public DescribeAccountStatisticsResponse DescribeAccountStatisticsSync(DescribeAccountStatisticsRequest req)
        {
             JsonResponseModel<DescribeAccountStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口已废弃
        /// 
        /// 本接口 (DescribeAccounts) 用于获取帐号列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口已废弃
        /// 
        /// 本接口 (DescribeAccounts) 用于获取帐号列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppListResponse"/></returns>
        public async Task<DescribeAssetAppListResponse> DescribeAssetAppList(DescribeAssetAppListRequest req)
        {
             JsonResponseModel<DescribeAssetAppListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppListResponse"/></returns>
        public DescribeAssetAppListResponse DescribeAssetAppListSync(DescribeAssetAppListRequest req)
        {
             JsonResponseModel<DescribeAssetAppListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取软件关联进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppProcessListResponse"/></returns>
        public async Task<DescribeAssetAppProcessListResponse> DescribeAssetAppProcessList(DescribeAssetAppProcessListRequest req)
        {
             JsonResponseModel<DescribeAssetAppProcessListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetAppProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取软件关联进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppProcessListResponse"/></returns>
        public DescribeAssetAppProcessListResponse DescribeAssetAppProcessListSync(DescribeAssetAppProcessListRequest req)
        {
             JsonResponseModel<DescribeAssetAppProcessListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetAppProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取内核模块详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleInfoResponse"/></returns>
        public async Task<DescribeAssetCoreModuleInfoResponse> DescribeAssetCoreModuleInfo(DescribeAssetCoreModuleInfoRequest req)
        {
             JsonResponseModel<DescribeAssetCoreModuleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetCoreModuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetCoreModuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取内核模块详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleInfoResponse"/></returns>
        public DescribeAssetCoreModuleInfoResponse DescribeAssetCoreModuleInfoSync(DescribeAssetCoreModuleInfoRequest req)
        {
             JsonResponseModel<DescribeAssetCoreModuleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetCoreModuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetCoreModuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理内核模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleListResponse"/></returns>
        public async Task<DescribeAssetCoreModuleListResponse> DescribeAssetCoreModuleList(DescribeAssetCoreModuleListRequest req)
        {
             JsonResponseModel<DescribeAssetCoreModuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetCoreModuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetCoreModuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理内核模块列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleListResponse"/></returns>
        public DescribeAssetCoreModuleListResponse DescribeAssetCoreModuleListSync(DescribeAssetCoreModuleListRequest req)
        {
             JsonResponseModel<DescribeAssetCoreModuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetCoreModuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetCoreModuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理数据库详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseInfoResponse"/></returns>
        public async Task<DescribeAssetDatabaseInfoResponse> DescribeAssetDatabaseInfo(DescribeAssetDatabaseInfoRequest req)
        {
             JsonResponseModel<DescribeAssetDatabaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetDatabaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDatabaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理数据库详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseInfoResponse"/></returns>
        public DescribeAssetDatabaseInfoResponse DescribeAssetDatabaseInfoSync(DescribeAssetDatabaseInfoRequest req)
        {
             JsonResponseModel<DescribeAssetDatabaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetDatabaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDatabaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseListResponse"/></returns>
        public async Task<DescribeAssetDatabaseListResponse> DescribeAssetDatabaseList(DescribeAssetDatabaseListRequest req)
        {
             JsonResponseModel<DescribeAssetDatabaseListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetDatabaseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDatabaseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseListResponse"/></returns>
        public DescribeAssetDatabaseListResponse DescribeAssetDatabaseListSync(DescribeAssetDatabaseListRequest req)
        {
             JsonResponseModel<DescribeAssetDatabaseListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetDatabaseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDatabaseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理环境变量列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetEnvListRequest"/></param>
        /// <returns><see cref="DescribeAssetEnvListResponse"/></returns>
        public async Task<DescribeAssetEnvListResponse> DescribeAssetEnvList(DescribeAssetEnvListRequest req)
        {
             JsonResponseModel<DescribeAssetEnvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetEnvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetEnvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理环境变量列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetEnvListRequest"/></param>
        /// <returns><see cref="DescribeAssetEnvListResponse"/></returns>
        public DescribeAssetEnvListResponse DescribeAssetEnvListSync(DescribeAssetEnvListRequest req)
        {
             JsonResponseModel<DescribeAssetEnvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetEnvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetEnvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产数量： 主机数、账号数、端口数、进程数、软件数、数据库数、Web应用数、Web框架数、Web服务数、Web站点数
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public async Task<DescribeAssetInfoResponse> DescribeAssetInfo(DescribeAssetInfoRequest req)
        {
             JsonResponseModel<DescribeAssetInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产数量： 主机数、账号数、端口数、进程数、软件数、数据库数、Web应用数、Web框架数、Web服务数、Web站点数
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public DescribeAssetInfoResponse DescribeAssetInfoSync(DescribeAssetInfoRequest req)
        {
             JsonResponseModel<DescribeAssetInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理启动服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInitServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetInitServiceListResponse"/></returns>
        public async Task<DescribeAssetInitServiceListResponse> DescribeAssetInitServiceList(DescribeAssetInitServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetInitServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetInitServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetInitServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理启动服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInitServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetInitServiceListResponse"/></returns>
        public DescribeAssetInitServiceListResponse DescribeAssetInitServiceListSync(DescribeAssetInitServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetInitServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetInitServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetInitServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Jar包详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetJarInfoResponse"/></returns>
        public async Task<DescribeAssetJarInfoResponse> DescribeAssetJarInfo(DescribeAssetJarInfoRequest req)
        {
             JsonResponseModel<DescribeAssetJarInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetJarInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetJarInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Jar包详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetJarInfoResponse"/></returns>
        public DescribeAssetJarInfoResponse DescribeAssetJarInfoSync(DescribeAssetJarInfoRequest req)
        {
             JsonResponseModel<DescribeAssetJarInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetJarInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetJarInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Jar包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarListRequest"/></param>
        /// <returns><see cref="DescribeAssetJarListResponse"/></returns>
        public async Task<DescribeAssetJarListResponse> DescribeAssetJarList(DescribeAssetJarListRequest req)
        {
             JsonResponseModel<DescribeAssetJarListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetJarList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetJarListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Jar包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarListRequest"/></param>
        /// <returns><see cref="DescribeAssetJarListResponse"/></returns>
        public DescribeAssetJarListResponse DescribeAssetJarListSync(DescribeAssetJarListRequest req)
        {
             JsonResponseModel<DescribeAssetJarListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetJarList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetJarListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理主机资源详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineDetailResponse"/></returns>
        public async Task<DescribeAssetMachineDetailResponse> DescribeAssetMachineDetail(DescribeAssetMachineDetailRequest req)
        {
             JsonResponseModel<DescribeAssetMachineDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetMachineDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetMachineDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理主机资源详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineDetailResponse"/></returns>
        public DescribeAssetMachineDetailResponse DescribeAssetMachineDetailSync(DescribeAssetMachineDetailRequest req)
        {
             JsonResponseModel<DescribeAssetMachineDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetMachineDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetMachineDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产指纹页面的资源监控列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineListRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineListResponse"/></returns>
        public async Task<DescribeAssetMachineListResponse> DescribeAssetMachineList(DescribeAssetMachineListRequest req)
        {
             JsonResponseModel<DescribeAssetMachineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产指纹页面的资源监控列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineListRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineListResponse"/></returns>
        public DescribeAssetMachineListResponse DescribeAssetMachineListSync(DescribeAssetMachineListRequest req)
        {
             JsonResponseModel<DescribeAssetMachineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理计划任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="DescribeAssetPlanTaskListResponse"/></returns>
        public async Task<DescribeAssetPlanTaskListResponse> DescribeAssetPlanTaskList(DescribeAssetPlanTaskListRequest req)
        {
             JsonResponseModel<DescribeAssetPlanTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetPlanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPlanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理计划任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="DescribeAssetPlanTaskListResponse"/></returns>
        public DescribeAssetPlanTaskListResponse DescribeAssetPlanTaskListSync(DescribeAssetPlanTaskListRequest req)
        {
             JsonResponseModel<DescribeAssetPlanTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetPlanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPlanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理端口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortInfoListResponse"/></returns>
        public async Task<DescribeAssetPortInfoListResponse> DescribeAssetPortInfoList(DescribeAssetPortInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetPortInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetPortInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPortInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理端口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortInfoListResponse"/></returns>
        public DescribeAssetPortInfoListResponse DescribeAssetPortInfoListSync(DescribeAssetPortInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetPortInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetPortInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPortInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessInfoListResponse"/></returns>
        public async Task<DescribeAssetProcessInfoListResponse> DescribeAssetProcessInfoList(DescribeAssetProcessInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetProcessInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetProcessInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetProcessInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessInfoListResponse"/></returns>
        public DescribeAssetProcessInfoListResponse DescribeAssetProcessInfoListSync(DescribeAssetProcessInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetProcessInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetProcessInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetProcessInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机最近趋势情况
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetRecentMachineInfoResponse"/></returns>
        public async Task<DescribeAssetRecentMachineInfoResponse> DescribeAssetRecentMachineInfo(DescribeAssetRecentMachineInfoRequest req)
        {
             JsonResponseModel<DescribeAssetRecentMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetRecentMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetRecentMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机最近趋势情况
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetRecentMachineInfoResponse"/></returns>
        public DescribeAssetRecentMachineInfoResponse DescribeAssetRecentMachineInfoSync(DescribeAssetRecentMachineInfoRequest req)
        {
             JsonResponseModel<DescribeAssetRecentMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetRecentMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetRecentMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理系统安装包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemPackageListResponse"/></returns>
        public async Task<DescribeAssetSystemPackageListResponse> DescribeAssetSystemPackageList(DescribeAssetSystemPackageListRequest req)
        {
             JsonResponseModel<DescribeAssetSystemPackageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetSystemPackageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSystemPackageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理系统安装包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemPackageListResponse"/></returns>
        public DescribeAssetSystemPackageListResponse DescribeAssetSystemPackageListSync(DescribeAssetSystemPackageListRequest req)
        {
             JsonResponseModel<DescribeAssetSystemPackageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetSystemPackageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSystemPackageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机账号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetUserInfoResponse"/></returns>
        public async Task<DescribeAssetUserInfoResponse> DescribeAssetUserInfo(DescribeAssetUserInfoRequest req)
        {
             JsonResponseModel<DescribeAssetUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机账号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetUserInfoResponse"/></returns>
        public DescribeAssetUserInfoResponse DescribeAssetUserInfoSync(DescribeAssetUserInfoRequest req)
        {
             JsonResponseModel<DescribeAssetUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserListResponse"/></returns>
        public async Task<DescribeAssetUserListResponse> DescribeAssetUserList(DescribeAssetUserListRequest req)
        {
             JsonResponseModel<DescribeAssetUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserListResponse"/></returns>
        public DescribeAssetUserListResponse DescribeAssetUserListSync(DescribeAssetUserListRequest req)
        {
             JsonResponseModel<DescribeAssetUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理Web应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppListResponse"/></returns>
        public async Task<DescribeAssetWebAppListResponse> DescribeAssetWebAppList(DescribeAssetWebAppListRequest req)
        {
             JsonResponseModel<DescribeAssetWebAppListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebAppListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理Web应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppListResponse"/></returns>
        public DescribeAssetWebAppListResponse DescribeAssetWebAppListSync(DescribeAssetWebAppListRequest req)
        {
             JsonResponseModel<DescribeAssetWebAppListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebAppListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理Web应用插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppPluginListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppPluginListResponse"/></returns>
        public async Task<DescribeAssetWebAppPluginListResponse> DescribeAssetWebAppPluginList(DescribeAssetWebAppPluginListRequest req)
        {
             JsonResponseModel<DescribeAssetWebAppPluginListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebAppPluginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebAppPluginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理Web应用插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppPluginListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppPluginListResponse"/></returns>
        public DescribeAssetWebAppPluginListResponse DescribeAssetWebAppPluginListSync(DescribeAssetWebAppPluginListRequest req)
        {
             JsonResponseModel<DescribeAssetWebAppPluginListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebAppPluginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebAppPluginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理Web框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameListResponse"/></returns>
        public async Task<DescribeAssetWebFrameListResponse> DescribeAssetWebFrameList(DescribeAssetWebFrameListRequest req)
        {
             JsonResponseModel<DescribeAssetWebFrameListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebFrameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebFrameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产管理Web框架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameListResponse"/></returns>
        public DescribeAssetWebFrameListResponse DescribeAssetWebFrameListSync(DescribeAssetWebFrameListRequest req)
        {
             JsonResponseModel<DescribeAssetWebFrameListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebFrameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebFrameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Web站点详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationInfoResponse"/></returns>
        public async Task<DescribeAssetWebLocationInfoResponse> DescribeAssetWebLocationInfo(DescribeAssetWebLocationInfoRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebLocationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Web站点详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationInfoResponse"/></returns>
        public DescribeAssetWebLocationInfoResponse DescribeAssetWebLocationInfoSync(DescribeAssetWebLocationInfoRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebLocationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Web站点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationListResponse"/></returns>
        public async Task<DescribeAssetWebLocationListResponse> DescribeAssetWebLocationList(DescribeAssetWebLocationListRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebLocationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Web站点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationListResponse"/></returns>
        public DescribeAssetWebLocationListResponse DescribeAssetWebLocationListSync(DescribeAssetWebLocationListRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebLocationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理Web服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceInfoListResponse"/></returns>
        public async Task<DescribeAssetWebServiceInfoListResponse> DescribeAssetWebServiceInfoList(DescribeAssetWebServiceInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebServiceInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产管理Web服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceInfoListResponse"/></returns>
        public DescribeAssetWebServiceInfoListResponse DescribeAssetWebServiceInfoListSync(DescribeAssetWebServiceInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebServiceInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Web服务关联进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceProcessListResponse"/></returns>
        public async Task<DescribeAssetWebServiceProcessListResponse> DescribeAssetWebServiceProcessList(DescribeAssetWebServiceProcessListRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceProcessListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebServiceProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Web服务关联进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceProcessListResponse"/></returns>
        public DescribeAssetWebServiceProcessListResponse DescribeAssetWebServiceProcessListSync(DescribeAssetWebServiceProcessListRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceProcessListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebServiceProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击日志详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackLogInfoResponse"/></returns>
        public async Task<DescribeAttackLogInfoResponse> DescribeAttackLogInfo(DescribeAttackLogInfoRequest req)
        {
             JsonResponseModel<DescribeAttackLogInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击日志详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackLogInfoResponse"/></returns>
        public DescribeAttackLogInfoResponse DescribeAttackLogInfoSync(DescribeAttackLogInfoRequest req)
        {
             JsonResponseModel<DescribeAttackLogInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按分页形式展示网络攻击日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogsRequest"/></param>
        /// <returns><see cref="DescribeAttackLogsResponse"/></returns>
        public async Task<DescribeAttackLogsResponse> DescribeAttackLogs(DescribeAttackLogsRequest req)
        {
             JsonResponseModel<DescribeAttackLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按分页形式展示网络攻击日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogsRequest"/></param>
        /// <returns><see cref="DescribeAttackLogsResponse"/></returns>
        public DescribeAttackLogsResponse DescribeAttackLogsSync(DescribeAttackLogsRequest req)
        {
             JsonResponseModel<DescribeAttackLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络攻击威胁类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackVulTypeListRequest"/></param>
        /// <returns><see cref="DescribeAttackVulTypeListResponse"/></returns>
        public async Task<DescribeAttackVulTypeListResponse> DescribeAttackVulTypeList(DescribeAttackVulTypeListRequest req)
        {
             JsonResponseModel<DescribeAttackVulTypeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackVulTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackVulTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络攻击威胁类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackVulTypeListRequest"/></param>
        /// <returns><see cref="DescribeAttackVulTypeListResponse"/></returns>
        public DescribeAttackVulTypeListResponse DescribeAttackVulTypeListSync(DescribeAttackVulTypeListRequest req)
        {
             JsonResponseModel<DescribeAttackVulTypeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackVulTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackVulTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-可用订单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableExpertServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeAvailableExpertServiceDetailResponse"/></returns>
        public async Task<DescribeAvailableExpertServiceDetailResponse> DescribeAvailableExpertServiceDetail(DescribeAvailableExpertServiceDetailRequest req)
        {
             JsonResponseModel<DescribeAvailableExpertServiceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableExpertServiceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableExpertServiceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-可用订单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableExpertServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeAvailableExpertServiceDetailResponse"/></returns>
        public DescribeAvailableExpertServiceDetailResponse DescribeAvailableExpertServiceDetailSync(DescribeAvailableExpertServiceDetailRequest req)
        {
             JsonResponseModel<DescribeAvailableExpertServiceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableExpertServiceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableExpertServiceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="DescribeBanModeRequest"/></param>
        /// <returns><see cref="DescribeBanModeResponse"/></returns>
        public async Task<DescribeBanModeResponse> DescribeBanMode(DescribeBanModeRequest req)
        {
             JsonResponseModel<DescribeBanModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBanMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="DescribeBanModeRequest"/></param>
        /// <returns><see cref="DescribeBanModeResponse"/></returns>
        public DescribeBanModeResponse DescribeBanModeSync(DescribeBanModeRequest req)
        {
             JsonResponseModel<DescribeBanModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBanMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取阻断地域
        /// </summary>
        /// <param name="req"><see cref="DescribeBanRegionsRequest"/></param>
        /// <returns><see cref="DescribeBanRegionsResponse"/></returns>
        public async Task<DescribeBanRegionsResponse> DescribeBanRegions(DescribeBanRegionsRequest req)
        {
             JsonResponseModel<DescribeBanRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBanRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取阻断地域
        /// </summary>
        /// <param name="req"><see cref="DescribeBanRegionsRequest"/></param>
        /// <returns><see cref="DescribeBanRegionsResponse"/></returns>
        public DescribeBanRegionsResponse DescribeBanRegionsSync(DescribeBanRegionsRequest req)
        {
             JsonResponseModel<DescribeBanRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBanRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取阻断按钮状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBanStatusRequest"/></param>
        /// <returns><see cref="DescribeBanStatusResponse"/></returns>
        public async Task<DescribeBanStatusResponse> DescribeBanStatus(DescribeBanStatusRequest req)
        {
             JsonResponseModel<DescribeBanStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取阻断按钮状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBanStatusRequest"/></param>
        /// <returns><see cref="DescribeBanStatusResponse"/></returns>
        public DescribeBanStatusResponse DescribeBanStatusSync(DescribeBanStatusRequest req)
        {
             JsonResponseModel<DescribeBanStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBanWhiteListRequest"/></param>
        /// <returns><see cref="DescribeBanWhiteListResponse"/></returns>
        public async Task<DescribeBanWhiteListResponse> DescribeBanWhiteList(DescribeBanWhiteListRequest req)
        {
             JsonResponseModel<DescribeBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBanWhiteListRequest"/></param>
        /// <returns><see cref="DescribeBanWhiteListResponse"/></returns>
        public DescribeBanWhiteListResponse DescribeBanWhiteListSync(DescribeBanWhiteListRequest req)
        {
             JsonResponseModel<DescribeBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBanWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id查询基线策略数据概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeBaselineAnalysisDataResponse"/></returns>
        public async Task<DescribeBaselineAnalysisDataResponse> DescribeBaselineAnalysisData(DescribeBaselineAnalysisDataRequest req)
        {
             JsonResponseModel<DescribeBaselineAnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineAnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineAnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id查询基线策略数据概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAnalysisDataRequest"/></param>
        /// <returns><see cref="DescribeBaselineAnalysisDataResponse"/></returns>
        public DescribeBaselineAnalysisDataResponse DescribeBaselineAnalysisDataSync(DescribeBaselineAnalysisDataRequest req)
        {
             JsonResponseModel<DescribeBaselineAnalysisDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineAnalysisData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineAnalysisDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询基线基础信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeBaselineBasicInfoResponse"/></returns>
        public async Task<DescribeBaselineBasicInfoResponse> DescribeBaselineBasicInfo(DescribeBaselineBasicInfoRequest req)
        {
             JsonResponseModel<DescribeBaselineBasicInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineBasicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineBasicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询基线基础信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeBaselineBasicInfoResponse"/></returns>
        public DescribeBaselineBasicInfoResponse DescribeBaselineBasicInfoSync(DescribeBaselineBasicInfoRequest req)
        {
             JsonResponseModel<DescribeBaselineBasicInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineBasicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineBasicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线id查询基线详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetailResponse"/></returns>
        public async Task<DescribeBaselineDetailResponse> DescribeBaselineDetail(DescribeBaselineDetailRequest req)
        {
             JsonResponseModel<DescribeBaselineDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线id查询基线详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetailResponse"/></returns>
        public DescribeBaselineDetailResponse DescribeBaselineDetailSync(DescribeBaselineDetailRequest req)
        {
             JsonResponseModel<DescribeBaselineDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线id查询基线影响主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeBaselineEffectHostListResponse"/></returns>
        public async Task<DescribeBaselineEffectHostListResponse> DescribeBaselineEffectHostList(DescribeBaselineEffectHostListRequest req)
        {
             JsonResponseModel<DescribeBaselineEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线id查询基线影响主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeBaselineEffectHostListResponse"/></returns>
        public DescribeBaselineEffectHostListResponse DescribeBaselineEffectHostListSync(DescribeBaselineEffectHostListRequest req)
        {
             JsonResponseModel<DescribeBaselineEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口返回TopN的风险服务器
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostTopResponse"/></returns>
        public async Task<DescribeBaselineHostTopResponse> DescribeBaselineHostTop(DescribeBaselineHostTopRequest req)
        {
             JsonResponseModel<DescribeBaselineHostTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineHostTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口返回TopN的风险服务器
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostTopResponse"/></returns>
        public DescribeBaselineHostTopResponse DescribeBaselineHostTopSync(DescribeBaselineHostTopRequest req)
        {
             JsonResponseModel<DescribeBaselineHostTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineHostTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询基线列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineListRequest"/></param>
        /// <returns><see cref="DescribeBaselineListResponse"/></returns>
        public async Task<DescribeBaselineListResponse> DescribeBaselineList(DescribeBaselineListRequest req)
        {
             JsonResponseModel<DescribeBaselineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询基线列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineListRequest"/></param>
        /// <returns><see cref="DescribeBaselineListResponse"/></returns>
        public DescribeBaselineListResponse DescribeBaselineListSync(DescribeBaselineListRequest req)
        {
             JsonResponseModel<DescribeBaselineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线id查询下属检测项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleResponse"/></returns>
        public async Task<DescribeBaselineRuleResponse> DescribeBaselineRule(DescribeBaselineRuleRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线id查询下属检测项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleResponse"/></returns>
        public DescribeBaselineRuleResponse DescribeBaselineRuleSync(DescribeBaselineRuleRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据任务id查询基线检测进度
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeBaselineScanScheduleResponse"/></returns>
        public async Task<DescribeBaselineScanScheduleResponse> DescribeBaselineScanSchedule(DescribeBaselineScanScheduleRequest req)
        {
             JsonResponseModel<DescribeBaselineScanScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineScanSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineScanScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据任务id查询基线检测进度
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeBaselineScanScheduleResponse"/></returns>
        public DescribeBaselineScanScheduleResponse DescribeBaselineScanScheduleSync(DescribeBaselineScanScheduleRequest req)
        {
             JsonResponseModel<DescribeBaselineScanScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineScanSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineScanScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id查询策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyDetailResponse"/></returns>
        public async Task<DescribeBaselineStrategyDetailResponse> DescribeBaselineStrategyDetail(DescribeBaselineStrategyDetailRequest req)
        {
             JsonResponseModel<DescribeBaselineStrategyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineStrategyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineStrategyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id查询策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyDetailResponse"/></returns>
        public DescribeBaselineStrategyDetailResponse DescribeBaselineStrategyDetailSync(DescribeBaselineStrategyDetailRequest req)
        {
             JsonResponseModel<DescribeBaselineStrategyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineStrategyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineStrategyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一个用户下的基线策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyListResponse"/></returns>
        public async Task<DescribeBaselineStrategyListResponse> DescribeBaselineStrategyList(DescribeBaselineStrategyListRequest req)
        {
             JsonResponseModel<DescribeBaselineStrategyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineStrategyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询一个用户下的基线策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyListResponse"/></returns>
        public DescribeBaselineStrategyListResponse DescribeBaselineStrategyListSync(DescribeBaselineStrategyListRequest req)
        {
             JsonResponseModel<DescribeBaselineStrategyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineStrategyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据策略id查询基线检测项TOP
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineTopResponse"/></returns>
        public async Task<DescribeBaselineTopResponse> DescribeBaselineTop(DescribeBaselineTopRequest req)
        {
             JsonResponseModel<DescribeBaselineTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据策略id查询基线检测项TOP
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineTopResponse"/></returns>
        public DescribeBaselineTopResponse DescribeBaselineTopSync(DescribeBaselineTopRequest req)
        {
             JsonResponseModel<DescribeBaselineTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsRequest"/></param>
        /// <returns><see cref="DescribeBashEventsResponse"/></returns>
        public async Task<DescribeBashEventsResponse> DescribeBashEvents(DescribeBashEventsRequest req)
        {
             JsonResponseModel<DescribeBashEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBashEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsRequest"/></param>
        /// <returns><see cref="DescribeBashEventsResponse"/></returns>
        public DescribeBashEventsResponse DescribeBashEventsSync(DescribeBashEventsRequest req)
        {
             JsonResponseModel<DescribeBashEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBashEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashRulesRequest"/></param>
        /// <returns><see cref="DescribeBashRulesResponse"/></returns>
        public async Task<DescribeBashRulesResponse> DescribeBashRules(DescribeBashRulesRequest req)
        {
             JsonResponseModel<DescribeBashRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashRulesRequest"/></param>
        /// <returns><see cref="DescribeBashRulesResponse"/></returns>
        public DescribeBashRulesResponse DescribeBashRulesSync(DescribeBashRulesRequest req)
        {
             JsonResponseModel<DescribeBashRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取密码破解列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackListRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackListResponse"/></returns>
        public async Task<DescribeBruteAttackListResponse> DescribeBruteAttackList(DescribeBruteAttackListRequest req)
        {
             JsonResponseModel<DescribeBruteAttackListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBruteAttackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBruteAttackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取密码破解列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackListRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackListResponse"/></returns>
        public DescribeBruteAttackListResponse DescribeBruteAttackListSync(DescribeBruteAttackListRequest req)
        {
             JsonResponseModel<DescribeBruteAttackListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBruteAttackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBruteAttackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取爆破破解规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackRulesRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackRulesResponse"/></returns>
        public async Task<DescribeBruteAttackRulesResponse> DescribeBruteAttackRules(DescribeBruteAttackRulesRequest req)
        {
             JsonResponseModel<DescribeBruteAttackRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBruteAttackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBruteAttackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取爆破破解规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackRulesRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackRulesResponse"/></returns>
        public DescribeBruteAttackRulesResponse DescribeBruteAttackRulesSync(DescribeBruteAttackRulesRequest req)
        {
             JsonResponseModel<DescribeBruteAttackRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBruteAttackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBruteAttackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeComponentStatistics) 用于获取组件统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public async Task<DescribeComponentStatisticsResponse> DescribeComponentStatistics(DescribeComponentStatisticsRequest req)
        {
             JsonResponseModel<DescribeComponentStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComponentStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComponentStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeComponentStatistics) 用于获取组件统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public DescribeComponentStatisticsResponse DescribeComponentStatisticsSync(DescribeComponentStatisticsRequest req)
        {
             JsonResponseModel<DescribeComponentStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComponentStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComponentStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES字段聚合结果
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public async Task<DescribeESAggregationsResponse> DescribeESAggregations(DescribeESAggregationsRequest req)
        {
             JsonResponseModel<DescribeESAggregationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeESAggregations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESAggregationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES字段聚合结果
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public DescribeESAggregationsResponse DescribeESAggregationsSync(DescribeESAggregationsRequest req)
        {
             JsonResponseModel<DescribeESAggregationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeESAggregations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESAggregationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeESHitsRequest"/></param>
        /// <returns><see cref="DescribeESHitsResponse"/></returns>
        public async Task<DescribeESHitsResponse> DescribeESHits(DescribeESHitsRequest req)
        {
             JsonResponseModel<DescribeESHitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeESHits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESHitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeESHitsRequest"/></param>
        /// <returns><see cref="DescribeESHitsResponse"/></returns>
        public DescribeESHitsResponse DescribeESHitsSync(DescribeESHitsRequest req)
        {
             JsonResponseModel<DescribeESHitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeESHits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESHitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-应急响应列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyResponseListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyResponseListResponse"/></returns>
        public async Task<DescribeEmergencyResponseListResponse> DescribeEmergencyResponseList(DescribeEmergencyResponseListRequest req)
        {
             JsonResponseModel<DescribeEmergencyResponseListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEmergencyResponseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmergencyResponseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-应急响应列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyResponseListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyResponseListResponse"/></returns>
        public DescribeEmergencyResponseListResponse DescribeEmergencyResponseListSync(DescribeEmergencyResponseListRequest req)
        {
             JsonResponseModel<DescribeEmergencyResponseListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEmergencyResponseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmergencyResponseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应急漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public async Task<DescribeEmergencyVulListResponse> DescribeEmergencyVulList(DescribeEmergencyVulListRequest req)
        {
             JsonResponseModel<DescribeEmergencyVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEmergencyVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmergencyVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应急漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public DescribeEmergencyVulListResponse DescribeEmergencyVulListSync(DescribeEmergencyVulListRequest req)
        {
             JsonResponseModel<DescribeEmergencyVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEmergencyVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmergencyVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-安全管家列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceListResponse"/></returns>
        public async Task<DescribeExpertServiceListResponse> DescribeExpertServiceList(DescribeExpertServiceListRequest req)
        {
             JsonResponseModel<DescribeExpertServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExpertServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExpertServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-安全管家列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceListResponse"/></returns>
        public DescribeExpertServiceListResponse DescribeExpertServiceListSync(DescribeExpertServiceListRequest req)
        {
             JsonResponseModel<DescribeExpertServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExpertServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExpertServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-专家服务订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceOrderListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceOrderListResponse"/></returns>
        public async Task<DescribeExpertServiceOrderListResponse> DescribeExpertServiceOrderList(DescribeExpertServiceOrderListRequest req)
        {
             JsonResponseModel<DescribeExpertServiceOrderListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExpertServiceOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExpertServiceOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-专家服务订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceOrderListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceOrderListResponse"/></returns>
        public DescribeExpertServiceOrderListResponse DescribeExpertServiceOrderListSync(DescribeExpertServiceOrderListRequest req)
        {
             JsonResponseModel<DescribeExpertServiceOrderListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExpertServiceOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExpertServiceOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeExportMachines) 用于导出区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeExportMachinesRequest"/></param>
        /// <returns><see cref="DescribeExportMachinesResponse"/></returns>
        public async Task<DescribeExportMachinesResponse> DescribeExportMachines(DescribeExportMachinesRequest req)
        {
             JsonResponseModel<DescribeExportMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExportMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeExportMachines) 用于导出区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeExportMachinesRequest"/></param>
        /// <returns><see cref="DescribeExportMachinesResponse"/></returns>
        public DescribeExportMachinesResponse DescribeExportMachinesSync(DescribeExportMachinesRequest req)
        {
             JsonResponseModel<DescribeExportMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExportMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机相关统计
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeGeneralStatResponse"/></returns>
        public async Task<DescribeGeneralStatResponse> DescribeGeneralStat(DescribeGeneralStatRequest req)
        {
             JsonResponseModel<DescribeGeneralStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGeneralStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机相关统计
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeGeneralStatResponse"/></returns>
        public DescribeGeneralStatResponse DescribeGeneralStatSync(DescribeGeneralStatRequest req)
        {
             JsonResponseModel<DescribeGeneralStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGeneralStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeHistoryAccounts) 用于获取帐号变更历史列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public async Task<DescribeHistoryAccountsResponse> DescribeHistoryAccounts(DescribeHistoryAccountsRequest req)
        {
             JsonResponseModel<DescribeHistoryAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHistoryAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeHistoryAccounts) 用于获取帐号变更历史列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public DescribeHistoryAccountsResponse DescribeHistoryAccountsSync(DescribeHistoryAccountsRequest req)
        {
             JsonResponseModel<DescribeHistoryAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHistoryAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询日志检索服务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryServiceRequest"/></param>
        /// <returns><see cref="DescribeHistoryServiceResponse"/></returns>
        public async Task<DescribeHistoryServiceResponse> DescribeHistoryService(DescribeHistoryServiceRequest req)
        {
             JsonResponseModel<DescribeHistoryServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHistoryService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询日志检索服务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryServiceRequest"/></param>
        /// <returns><see cref="DescribeHistoryServiceResponse"/></returns>
        public DescribeHistoryServiceResponse DescribeHistoryServiceSync(DescribeHistoryServiceRequest req)
        {
             JsonResponseModel<DescribeHistoryServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHistoryService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取登录审计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLoginListRequest"/></param>
        /// <returns><see cref="DescribeHostLoginListResponse"/></returns>
        public async Task<DescribeHostLoginListResponse> DescribeHostLoginList(DescribeHostLoginListRequest req)
        {
             JsonResponseModel<DescribeHostLoginListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostLoginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostLoginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取登录审计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLoginListRequest"/></param>
        /// <returns><see cref="DescribeHostLoginListResponse"/></returns>
        public DescribeHostLoginListResponse DescribeHostLoginListSync(DescribeHostLoginListRequest req)
        {
             JsonResponseModel<DescribeHostLoginListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostLoginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostLoginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询已经忽略的检测项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeIgnoreBaselineRuleResponse"/></returns>
        public async Task<DescribeIgnoreBaselineRuleResponse> DescribeIgnoreBaselineRule(DescribeIgnoreBaselineRuleRequest req)
        {
             JsonResponseModel<DescribeIgnoreBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIgnoreBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIgnoreBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询已经忽略的检测项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeIgnoreBaselineRuleResponse"/></returns>
        public DescribeIgnoreBaselineRuleResponse DescribeIgnoreBaselineRuleSync(DescribeIgnoreBaselineRuleRequest req)
        {
             JsonResponseModel<DescribeIgnoreBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIgnoreBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIgnoreBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检测项id与筛选条件查询忽略检测项影响主机列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeIgnoreRuleEffectHostListResponse"/></returns>
        public async Task<DescribeIgnoreRuleEffectHostListResponse> DescribeIgnoreRuleEffectHostList(DescribeIgnoreRuleEffectHostListRequest req)
        {
             JsonResponseModel<DescribeIgnoreRuleEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIgnoreRuleEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIgnoreRuleEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检测项id与筛选条件查询忽略检测项影响主机列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeIgnoreRuleEffectHostListResponse"/></returns>
        public DescribeIgnoreRuleEffectHostListResponse DescribeIgnoreRuleEffectHostListSync(DescribeIgnoreRuleEffectHostListRequest req)
        {
             JsonResponseModel<DescribeIgnoreRuleEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIgnoreRuleEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIgnoreRuleEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询批量导入机器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImportMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeImportMachineInfoResponse"/></returns>
        public async Task<DescribeImportMachineInfoResponse> DescribeImportMachineInfo(DescribeImportMachineInfoRequest req)
        {
             JsonResponseModel<DescribeImportMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImportMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询批量导入机器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImportMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeImportMachineInfoResponse"/></returns>
        public DescribeImportMachineInfoResponse DescribeImportMachineInfoSync(DescribeImportMachineInfoRequest req)
        {
             JsonResponseModel<DescribeImportMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImportMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public async Task<DescribeIndexListResponse> DescribeIndexList(DescribeIndexListRequest req)
        {
             JsonResponseModel<DescribeIndexListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIndexList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public DescribeIndexListResponse DescribeIndexListSync(DescribeIndexListRequest req)
        {
             JsonResponseModel<DescribeIndexListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIndexList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志检索容量使用统计
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public async Task<DescribeLogStorageStatisticResponse> DescribeLogStorageStatistic(DescribeLogStorageStatisticRequest req)
        {
             JsonResponseModel<DescribeLogStorageStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogStorageStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志检索容量使用统计
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public DescribeLogStorageStatisticResponse DescribeLogStorageStatisticSync(DescribeLogStorageStatisticRequest req)
        {
             JsonResponseModel<DescribeLogStorageStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogStorageStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异地登录白名单合并后列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteCombinedListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteCombinedListResponse"/></returns>
        public async Task<DescribeLoginWhiteCombinedListResponse> DescribeLoginWhiteCombinedList(DescribeLoginWhiteCombinedListRequest req)
        {
             JsonResponseModel<DescribeLoginWhiteCombinedListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoginWhiteCombinedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginWhiteCombinedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异地登录白名单合并后列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteCombinedListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteCombinedListResponse"/></returns>
        public DescribeLoginWhiteCombinedListResponse DescribeLoginWhiteCombinedListSync(DescribeLoginWhiteCombinedListRequest req)
        {
             JsonResponseModel<DescribeLoginWhiteCombinedListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoginWhiteCombinedList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginWhiteCombinedListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异地登录白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public async Task<DescribeLoginWhiteListResponse> DescribeLoginWhiteList(DescribeLoginWhiteListRequest req)
        {
             JsonResponseModel<DescribeLoginWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoginWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异地登录白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public DescribeLoginWhiteListResponse DescribeLoginWhiteListSync(DescribeLoginWhiteListRequest req)
        {
             JsonResponseModel<DescribeLoginWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoginWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMachineInfo）用于获取机器详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeMachineInfoResponse"/></returns>
        public async Task<DescribeMachineInfoResponse> DescribeMachineInfo(DescribeMachineInfoRequest req)
        {
             JsonResponseModel<DescribeMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMachineInfo）用于获取机器详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeMachineInfoResponse"/></returns>
        public DescribeMachineInfoResponse DescribeMachineInfoSync(DescribeMachineInfoRequest req)
        {
             JsonResponseModel<DescribeMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于网页防篡改获取区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineListRequest"/></param>
        /// <returns><see cref="DescribeMachineListResponse"/></returns>
        public async Task<DescribeMachineListResponse> DescribeMachineList(DescribeMachineListRequest req)
        {
             JsonResponseModel<DescribeMachineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于网页防篡改获取区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineListRequest"/></param>
        /// <returns><see cref="DescribeMachineListResponse"/></returns>
        public DescribeMachineListResponse DescribeMachineListSync(DescribeMachineListRequest req)
        {
             JsonResponseModel<DescribeMachineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可筛选操作系统列表.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeMachineOsListResponse"/></returns>
        public async Task<DescribeMachineOsListResponse> DescribeMachineOsList(DescribeMachineOsListRequest req)
        {
             JsonResponseModel<DescribeMachineOsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineOsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineOsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询可筛选操作系统列表.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeMachineOsListResponse"/></returns>
        public DescribeMachineOsListResponse DescribeMachineOsListSync(DescribeMachineOsListRequest req)
        {
             JsonResponseModel<DescribeMachineOsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineOsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineOsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionsResponse"/></returns>
        public async Task<DescribeMachineRegionsResponse> DescribeMachineRegions(DescribeMachineRegionsRequest req)
        {
             JsonResponseModel<DescribeMachineRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionsResponse"/></returns>
        public DescribeMachineRegionsResponse DescribeMachineRegionsSync(DescribeMachineRegionsRequest req)
        {
             JsonResponseModel<DescribeMachineRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeMachines) 用于获取区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public async Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
             JsonResponseModel<DescribeMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeMachines) 用于获取区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
             JsonResponseModel<DescribeMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵检测获取木马列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMalWareListRequest"/></param>
        /// <returns><see cref="DescribeMalWareListResponse"/></returns>
        public async Task<DescribeMalWareListResponse> DescribeMalWareList(DescribeMalWareListRequest req)
        {
             JsonResponseModel<DescribeMalWareListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalWareList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalWareListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵检测获取木马列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMalWareListRequest"/></param>
        /// <returns><see cref="DescribeMalWareListResponse"/></returns>
        public DescribeMalWareListResponse DescribeMalWareListSync(DescribeMalWareListRequest req)
        {
             JsonResponseModel<DescribeMalWareListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalWareList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalWareListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询恶意请求白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestWhiteListResponse"/></returns>
        public async Task<DescribeMaliciousRequestWhiteListResponse> DescribeMaliciousRequestWhiteList(DescribeMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<DescribeMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaliciousRequestWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询恶意请求白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestWhiteListResponse"/></returns>
        public DescribeMaliciousRequestWhiteListResponse DescribeMaliciousRequestWhiteListSync(DescribeMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<DescribeMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaliciousRequestWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取木马文件下载地址
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareFileRequest"/></param>
        /// <returns><see cref="DescribeMalwareFileResponse"/></returns>
        public async Task<DescribeMalwareFileResponse> DescribeMalwareFile(DescribeMalwareFileRequest req)
        {
             JsonResponseModel<DescribeMalwareFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwareFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取木马文件下载地址
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareFileRequest"/></param>
        /// <returns><see cref="DescribeMalwareFileResponse"/></returns>
        public DescribeMalwareFileResponse DescribeMalwareFileSync(DescribeMalwareFileRequest req)
        {
             JsonResponseModel<DescribeMalwareFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalwareFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看恶意文件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareInfoRequest"/></param>
        /// <returns><see cref="DescribeMalwareInfoResponse"/></returns>
        public async Task<DescribeMalwareInfoResponse> DescribeMalwareInfo(DescribeMalwareInfoRequest req)
        {
             JsonResponseModel<DescribeMalwareInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwareInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看恶意文件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareInfoRequest"/></param>
        /// <returns><see cref="DescribeMalwareInfoResponse"/></returns>
        public DescribeMalwareInfoResponse DescribeMalwareInfoSync(DescribeMalwareInfoRequest req)
        {
             JsonResponseModel<DescribeMalwareInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalwareInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 打开入侵检测-恶意文件检测,弹出风险预警内容
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskWarningRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskWarningResponse"/></returns>
        public async Task<DescribeMalwareRiskWarningResponse> DescribeMalwareRiskWarning(DescribeMalwareRiskWarningRequest req)
        {
             JsonResponseModel<DescribeMalwareRiskWarningResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwareRiskWarning");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareRiskWarningResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 打开入侵检测-恶意文件检测,弹出风险预警内容
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskWarningRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskWarningResponse"/></returns>
        public DescribeMalwareRiskWarningResponse DescribeMalwareRiskWarningSync(DescribeMalwareRiskWarningRequest req)
        {
             JsonResponseModel<DescribeMalwareRiskWarningResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalwareRiskWarning");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareRiskWarningResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询定时扫描配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public async Task<DescribeMalwareTimingScanSettingResponse> DescribeMalwareTimingScanSetting(DescribeMalwareTimingScanSettingRequest req)
        {
             JsonResponseModel<DescribeMalwareTimingScanSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwareTimingScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareTimingScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询定时扫描配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public DescribeMalwareTimingScanSettingResponse DescribeMalwareTimingScanSettingSync(DescribeMalwareTimingScanSettingRequest req)
        {
             JsonResponseModel<DescribeMalwareTimingScanSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalwareTimingScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareTimingScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-安全管家月巡检报告下载
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeMonthInspectionReportResponse"/></returns>
        public async Task<DescribeMonthInspectionReportResponse> DescribeMonthInspectionReport(DescribeMonthInspectionReportRequest req)
        {
             JsonResponseModel<DescribeMonthInspectionReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonthInspectionReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonthInspectionReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-安全管家月巡检报告下载
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeMonthInspectionReportResponse"/></returns>
        public DescribeMonthInspectionReportResponse DescribeMonthInspectionReportSync(DescribeMonthInspectionReportRequest req)
        {
             JsonResponseModel<DescribeMonthInspectionReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonthInspectionReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonthInspectionReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeOpenPortStatistics) 用于获取端口统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public async Task<DescribeOpenPortStatisticsResponse> DescribeOpenPortStatistics(DescribeOpenPortStatisticsRequest req)
        {
             JsonResponseModel<DescribeOpenPortStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOpenPortStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOpenPortStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeOpenPortStatistics) 用于获取端口统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public DescribeOpenPortStatisticsResponse DescribeOpenPortStatisticsSync(DescribeOpenPortStatisticsRequest req)
        {
             JsonResponseModel<DescribeOpenPortStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOpenPortStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOpenPortStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取概览统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public async Task<DescribeOverviewStatisticsResponse> DescribeOverviewStatistics(DescribeOverviewStatisticsRequest req)
        {
             JsonResponseModel<DescribeOverviewStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOverviewStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取概览统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public DescribeOverviewStatisticsResponse DescribeOverviewStatisticsSync(DescribeOverviewStatisticsRequest req)
        {
             JsonResponseModel<DescribeOverviewStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOverviewStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOverviewStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本地提权事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventsResponse"/></returns>
        public async Task<DescribePrivilegeEventsResponse> DescribePrivilegeEvents(DescribePrivilegeEventsRequest req)
        {
             JsonResponseModel<DescribePrivilegeEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivilegeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivilegeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本地提权事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventsResponse"/></returns>
        public DescribePrivilegeEventsResponse DescribePrivilegeEventsSync(DescribePrivilegeEventsRequest req)
        {
             JsonResponseModel<DescribePrivilegeEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivilegeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivilegeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本地提权规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DescribePrivilegeRulesResponse"/></returns>
        public async Task<DescribePrivilegeRulesResponse> DescribePrivilegeRules(DescribePrivilegeRulesRequest req)
        {
             JsonResponseModel<DescribePrivilegeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivilegeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivilegeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本地提权规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DescribePrivilegeRulesResponse"/></returns>
        public DescribePrivilegeRulesResponse DescribePrivilegeRulesSync(DescribePrivilegeRulesRequest req)
        {
             JsonResponseModel<DescribePrivilegeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivilegeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivilegeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取专业版概览信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public async Task<DescribeProVersionInfoResponse> DescribeProVersionInfo(DescribeProVersionInfoRequest req)
        {
             JsonResponseModel<DescribeProVersionInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProVersionInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProVersionInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取专业版概览信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public DescribeProVersionInfoResponse DescribeProVersionInfoSync(DescribeProVersionInfoRequest req)
        {
             JsonResponseModel<DescribeProVersionInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProVersionInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProVersionInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取单台主机或所有主机是否开通专业版状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionStatusRequest"/></param>
        /// <returns><see cref="DescribeProVersionStatusResponse"/></returns>
        public async Task<DescribeProVersionStatusResponse> DescribeProVersionStatus(DescribeProVersionStatusRequest req)
        {
             JsonResponseModel<DescribeProVersionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProVersionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProVersionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取单台主机或所有主机是否开通专业版状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionStatusRequest"/></param>
        /// <returns><see cref="DescribeProVersionStatusResponse"/></returns>
        public DescribeProVersionStatusResponse DescribeProVersionStatusSync(DescribeProVersionStatusRequest req)
        {
             JsonResponseModel<DescribeProVersionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProVersionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProVersionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProcessStatistics) 用于获取进程统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public async Task<DescribeProcessStatisticsResponse> DescribeProcessStatistics(DescribeProcessStatisticsRequest req)
        {
             JsonResponseModel<DescribeProcessStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcessStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcessStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProcessStatistics) 用于获取进程统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public DescribeProcessStatisticsResponse DescribeProcessStatisticsSync(DescribeProcessStatisticsRequest req)
        {
             JsonResponseModel<DescribeProcessStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProcessStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcessStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网页防篡改防护目录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectDirListRequest"/></param>
        /// <returns><see cref="DescribeProtectDirListResponse"/></returns>
        public async Task<DescribeProtectDirListResponse> DescribeProtectDirList(DescribeProtectDirListRequest req)
        {
             JsonResponseModel<DescribeProtectDirListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProtectDirList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectDirListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网页防篡改防护目录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectDirListRequest"/></param>
        /// <returns><see cref="DescribeProtectDirListResponse"/></returns>
        public DescribeProtectDirListResponse DescribeProtectDirListSync(DescribeProtectDirListRequest req)
        {
             JsonResponseModel<DescribeProtectDirListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProtectDirList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectDirListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防护目录关联服务器列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectDirRelatedServerRequest"/></param>
        /// <returns><see cref="DescribeProtectDirRelatedServerResponse"/></returns>
        public async Task<DescribeProtectDirRelatedServerResponse> DescribeProtectDirRelatedServer(DescribeProtectDirRelatedServerRequest req)
        {
             JsonResponseModel<DescribeProtectDirRelatedServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProtectDirRelatedServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectDirRelatedServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防护目录关联服务器列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectDirRelatedServerRequest"/></param>
        /// <returns><see cref="DescribeProtectDirRelatedServerResponse"/></returns>
        public DescribeProtectDirRelatedServerResponse DescribeProtectDirRelatedServerSync(DescribeProtectDirRelatedServerRequest req)
        {
             JsonResponseModel<DescribeProtectDirRelatedServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProtectDirRelatedServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectDirRelatedServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-旗舰护网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectNetListRequest"/></param>
        /// <returns><see cref="DescribeProtectNetListResponse"/></returns>
        public async Task<DescribeProtectNetListResponse> DescribeProtectNetList(DescribeProtectNetListRequest req)
        {
             JsonResponseModel<DescribeProtectNetListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProtectNetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectNetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 专家服务-旗舰护网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProtectNetListRequest"/></param>
        /// <returns><see cref="DescribeProtectNetListResponse"/></returns>
        public DescribeProtectNetListResponse DescribeProtectNetListSync(DescribeProtectNetListRequest req)
        {
             JsonResponseModel<DescribeProtectNetListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProtectNetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProtectNetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取反弹Shell列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public async Task<DescribeReverseShellEventsResponse> DescribeReverseShellEvents(DescribeReverseShellEventsRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取反弹Shell列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public DescribeReverseShellEventsResponse DescribeReverseShellEventsSync(DescribeReverseShellEventsRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取反弹Shell规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellRulesRequest"/></param>
        /// <returns><see cref="DescribeReverseShellRulesResponse"/></returns>
        public async Task<DescribeReverseShellRulesResponse> DescribeReverseShellRules(DescribeReverseShellRulesRequest req)
        {
             JsonResponseModel<DescribeReverseShellRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取反弹Shell规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellRulesRequest"/></param>
        /// <returns><see cref="DescribeReverseShellRulesResponse"/></returns>
        public DescribeReverseShellRulesResponse DescribeReverseShellRulesSync(DescribeReverseShellRulesRequest req)
        {
             JsonResponseModel<DescribeReverseShellRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵检测，获取恶意请求列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsListResponse"/></returns>
        public async Task<DescribeRiskDnsListResponse> DescribeRiskDnsList(DescribeRiskDnsListRequest req)
        {
             JsonResponseModel<DescribeRiskDnsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskDnsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵检测，获取恶意请求列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsListResponse"/></returns>
        public DescribeRiskDnsListResponse DescribeRiskDnsListSync(DescribeRiskDnsListRequest req)
        {
             JsonResponseModel<DescribeRiskDnsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskDnsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新或者插入用户告警设置(该接口废弃,请调用 ModifyWarningSetting )
        /// </summary>
        /// <param name="req"><see cref="DescribeSaveOrUpdateWarningsRequest"/></param>
        /// <returns><see cref="DescribeSaveOrUpdateWarningsResponse"/></returns>
        public async Task<DescribeSaveOrUpdateWarningsResponse> DescribeSaveOrUpdateWarnings(DescribeSaveOrUpdateWarningsRequest req)
        {
             JsonResponseModel<DescribeSaveOrUpdateWarningsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSaveOrUpdateWarnings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSaveOrUpdateWarningsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新或者插入用户告警设置(该接口废弃,请调用 ModifyWarningSetting )
        /// </summary>
        /// <param name="req"><see cref="DescribeSaveOrUpdateWarningsRequest"/></param>
        /// <returns><see cref="DescribeSaveOrUpdateWarningsResponse"/></returns>
        public DescribeSaveOrUpdateWarningsResponse DescribeSaveOrUpdateWarningsSync(DescribeSaveOrUpdateWarningsRequest req)
        {
             JsonResponseModel<DescribeSaveOrUpdateWarningsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSaveOrUpdateWarnings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSaveOrUpdateWarningsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马扫描进度
        /// </summary>
        /// <param name="req"><see cref="DescribeScanMalwareScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanMalwareScheduleResponse"/></returns>
        public async Task<DescribeScanMalwareScheduleResponse> DescribeScanMalwareSchedule(DescribeScanMalwareScheduleRequest req)
        {
             JsonResponseModel<DescribeScanMalwareScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanMalwareSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanMalwareScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马扫描进度
        /// </summary>
        /// <param name="req"><see cref="DescribeScanMalwareScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanMalwareScheduleResponse"/></returns>
        public DescribeScanMalwareScheduleResponse DescribeScanMalwareScheduleSync(DescribeScanMalwareScheduleRequest req)
        {
             JsonResponseModel<DescribeScanMalwareScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanMalwareSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanMalwareScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据taskid查询检测进度
        /// </summary>
        /// <param name="req"><see cref="DescribeScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanScheduleResponse"/></returns>
        public async Task<DescribeScanScheduleResponse> DescribeScanSchedule(DescribeScanScheduleRequest req)
        {
             JsonResponseModel<DescribeScanScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据taskid查询检测进度
        /// </summary>
        /// <param name="req"><see cref="DescribeScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanScheduleResponse"/></returns>
        public DescribeScanScheduleResponse DescribeScanScheduleSync(DescribeScanScheduleRequest req)
        {
             JsonResponseModel<DescribeScanScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScanState 该接口能查询对应模块正在进行的扫描任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStateRequest"/></param>
        /// <returns><see cref="DescribeScanStateResponse"/></returns>
        public async Task<DescribeScanStateResponse> DescribeScanState(DescribeScanStateRequest req)
        {
             JsonResponseModel<DescribeScanStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScanState 该接口能查询对应模块正在进行的扫描任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStateRequest"/></param>
        /// <returns><see cref="DescribeScanStateResponse"/></returns>
        public DescribeScanStateResponse DescribeScanStateSync(DescribeScanStateRequest req)
        {
             JsonResponseModel<DescribeScanStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScanTaskDetails 查询扫描任务详情 , 可以查询扫描进度信息/异常;
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskDetailsRequest"/></param>
        /// <returns><see cref="DescribeScanTaskDetailsResponse"/></returns>
        public async Task<DescribeScanTaskDetailsResponse> DescribeScanTaskDetails(DescribeScanTaskDetailsRequest req)
        {
             JsonResponseModel<DescribeScanTaskDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanTaskDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScanTaskDetails 查询扫描任务详情 , 可以查询扫描进度信息/异常;
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskDetailsRequest"/></param>
        /// <returns><see cref="DescribeScanTaskDetailsResponse"/></returns>
        public DescribeScanTaskDetailsResponse DescribeScanTaskDetailsSync(DescribeScanTaskDetailsRequest req)
        {
             JsonResponseModel<DescribeScanTaskDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanTaskDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScanTaskStatus 查询机器扫描状态列表用于过滤筛选
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public async Task<DescribeScanTaskStatusResponse> DescribeScanTaskStatus(DescribeScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeScanTaskStatus 查询机器扫描状态列表用于过滤筛选
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public DescribeScanTaskStatusResponse DescribeScanTaskStatusSync(DescribeScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询定期检测的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeScanVulSettingRequest"/></param>
        /// <returns><see cref="DescribeScanVulSettingResponse"/></returns>
        public async Task<DescribeScanVulSettingResponse> DescribeScanVulSetting(DescribeScanVulSettingRequest req)
        {
             JsonResponseModel<DescribeScanVulSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanVulSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanVulSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询定期检测的配置
        /// </summary>
        /// <param name="req"><see cref="DescribeScanVulSettingRequest"/></param>
        /// <returns><see cref="DescribeScanVulSettingResponse"/></returns>
        public DescribeScanVulSettingResponse DescribeScanVulSettingSync(DescribeScanVulSettingRequest req)
        {
             JsonResponseModel<DescribeScanVulSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanVulSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanVulSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchExportListRequest"/></param>
        /// <returns><see cref="DescribeSearchExportListResponse"/></returns>
        public async Task<DescribeSearchExportListResponse> DescribeSearchExportList(DescribeSearchExportListRequest req)
        {
             JsonResponseModel<DescribeSearchExportListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSearchExportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchExportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchExportListRequest"/></param>
        /// <returns><see cref="DescribeSearchExportListResponse"/></returns>
        public DescribeSearchExportListResponse DescribeSearchExportListSync(DescribeSearchExportListRequest req)
        {
             JsonResponseModel<DescribeSearchExportListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSearchExportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchExportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取历史搜索记录
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public async Task<DescribeSearchLogsResponse> DescribeSearchLogs(DescribeSearchLogsRequest req)
        {
             JsonResponseModel<DescribeSearchLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSearchLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取历史搜索记录
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public DescribeSearchLogsResponse DescribeSearchLogsSync(DescribeSearchLogsRequest req)
        {
             JsonResponseModel<DescribeSearchLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSearchLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取快速检索列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public async Task<DescribeSearchTemplatesResponse> DescribeSearchTemplates(DescribeSearchTemplatesRequest req)
        {
             JsonResponseModel<DescribeSearchTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSearchTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取快速检索列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public DescribeSearchTemplatesResponse DescribeSearchTemplatesSync(DescribeSearchTemplatesRequest req)
        {
             JsonResponseModel<DescribeSearchTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSearchTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSecurityDynamics) 用于获取安全事件动态消息数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public async Task<DescribeSecurityDynamicsResponse> DescribeSecurityDynamics(DescribeSecurityDynamicsRequest req)
        {
             JsonResponseModel<DescribeSecurityDynamicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityDynamics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityDynamicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSecurityDynamics) 用于获取安全事件动态消息数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public DescribeSecurityDynamicsResponse DescribeSecurityDynamicsSync(DescribeSecurityDynamicsRequest req)
        {
             JsonResponseModel<DescribeSecurityDynamicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityDynamics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityDynamicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全概览相关事件统计数据接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventsCntRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventsCntResponse"/></returns>
        public async Task<DescribeSecurityEventsCntResponse> DescribeSecurityEventsCnt(DescribeSecurityEventsCntRequest req)
        {
             JsonResponseModel<DescribeSecurityEventsCntResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityEventsCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityEventsCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全概览相关事件统计数据接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventsCntRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventsCntResponse"/></returns>
        public DescribeSecurityEventsCntResponse DescribeSecurityEventsCntSync(DescribeSecurityEventsCntRequest req)
        {
             JsonResponseModel<DescribeSecurityEventsCntResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityEventsCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityEventsCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSecurityTrends) 用于获取安全事件统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public async Task<DescribeSecurityTrendsResponse> DescribeSecurityTrends(DescribeSecurityTrendsRequest req)
        {
             JsonResponseModel<DescribeSecurityTrendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeSecurityTrends) 用于获取安全事件统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public DescribeSecurityTrendsResponse DescribeSecurityTrendsSync(DescribeSecurityTrendsRequest req)
        {
             JsonResponseModel<DescribeSecurityTrendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务区关联目录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeServerRelatedDirInfoRequest"/></param>
        /// <returns><see cref="DescribeServerRelatedDirInfoResponse"/></returns>
        public async Task<DescribeServerRelatedDirInfoResponse> DescribeServerRelatedDirInfo(DescribeServerRelatedDirInfoRequest req)
        {
             JsonResponseModel<DescribeServerRelatedDirInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServerRelatedDirInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerRelatedDirInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务区关联目录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeServerRelatedDirInfoRequest"/></param>
        /// <returns><see cref="DescribeServerRelatedDirInfoResponse"/></returns>
        public DescribeServerRelatedDirInfoResponse DescribeServerRelatedDirInfoSync(DescribeServerRelatedDirInfoRequest req)
        {
             JsonResponseModel<DescribeServerRelatedDirInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServerRelatedDirInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerRelatedDirInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取待处理风险文件数+影响服务器数+是否试用检测+最近检测时间
        /// </summary>
        /// <param name="req"><see cref="DescribeServersAndRiskAndFirstInfoRequest"/></param>
        /// <returns><see cref="DescribeServersAndRiskAndFirstInfoResponse"/></returns>
        public async Task<DescribeServersAndRiskAndFirstInfoResponse> DescribeServersAndRiskAndFirstInfo(DescribeServersAndRiskAndFirstInfoRequest req)
        {
             JsonResponseModel<DescribeServersAndRiskAndFirstInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServersAndRiskAndFirstInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServersAndRiskAndFirstInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取待处理风险文件数+影响服务器数+是否试用检测+最近检测时间
        /// </summary>
        /// <param name="req"><see cref="DescribeServersAndRiskAndFirstInfoRequest"/></param>
        /// <returns><see cref="DescribeServersAndRiskAndFirstInfoResponse"/></returns>
        public DescribeServersAndRiskAndFirstInfoResponse DescribeServersAndRiskAndFirstInfoSync(DescribeServersAndRiskAndFirstInfoRequest req)
        {
             JsonResponseModel<DescribeServersAndRiskAndFirstInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServersAndRiskAndFirstInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServersAndRiskAndFirstInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据策略名查询策略是否存在
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyExistRequest"/></param>
        /// <returns><see cref="DescribeStrategyExistResponse"/></returns>
        public async Task<DescribeStrategyExistResponse> DescribeStrategyExist(DescribeStrategyExistRequest req)
        {
             JsonResponseModel<DescribeStrategyExistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStrategyExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStrategyExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据策略名查询策略是否存在
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyExistRequest"/></param>
        /// <returns><see cref="DescribeStrategyExistResponse"/></returns>
        public DescribeStrategyExistResponse DescribeStrategyExistSync(DescribeStrategyExistRequest req)
        {
             JsonResponseModel<DescribeStrategyExistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStrategyExist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStrategyExistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定标签关联的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public async Task<DescribeTagMachinesResponse> DescribeTagMachines(DescribeTagMachinesRequest req)
        {
             JsonResponseModel<DescribeTagMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定标签关联的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public DescribeTagMachinesResponse DescribeTagMachinesSync(DescribeTagMachinesRequest req)
        {
             JsonResponseModel<DescribeTagMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有主机标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public async Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有主机标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞管理模块指定类型的待处理漏洞数、主机数和非专业版主机数量
        /// </summary>
        /// <param name="req"><see cref="DescribeUndoVulCountsRequest"/></param>
        /// <returns><see cref="DescribeUndoVulCountsResponse"/></returns>
        public async Task<DescribeUndoVulCountsResponse> DescribeUndoVulCounts(DescribeUndoVulCountsRequest req)
        {
             JsonResponseModel<DescribeUndoVulCountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUndoVulCounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUndoVulCountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞管理模块指定类型的待处理漏洞数、主机数和非专业版主机数量
        /// </summary>
        /// <param name="req"><see cref="DescribeUndoVulCountsRequest"/></param>
        /// <returns><see cref="DescribeUndoVulCountsResponse"/></returns>
        public DescribeUndoVulCountsResponse DescribeUndoVulCountsSync(DescribeUndoVulCountsRequest req)
        {
             JsonResponseModel<DescribeUndoVulCountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUndoVulCounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUndoVulCountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsualLoginPlaces）用于查询常用登录地。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public async Task<DescribeUsualLoginPlacesResponse> DescribeUsualLoginPlaces(DescribeUsualLoginPlacesRequest req)
        {
             JsonResponseModel<DescribeUsualLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsualLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsualLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsualLoginPlaces）用于查询常用登录地。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public DescribeUsualLoginPlacesResponse DescribeUsualLoginPlacesSync(DescribeUsualLoginPlacesRequest req)
        {
             JsonResponseModel<DescribeUsualLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsualLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsualLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于统计专业版和基础版机器数。
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeVersionStatisticsResponse"/></returns>
        public async Task<DescribeVersionStatisticsResponse> DescribeVersionStatistics(DescribeVersionStatisticsRequest req)
        {
             JsonResponseModel<DescribeVersionStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVersionStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVersionStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于统计专业版和基础版机器数。
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeVersionStatisticsResponse"/></returns>
        public DescribeVersionStatisticsResponse DescribeVersionStatisticsSync(DescribeVersionStatisticsRequest req)
        {
             JsonResponseModel<DescribeVersionStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVersionStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVersionStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理模块，获取近日指定类型的漏洞数量和主机数量
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCountByDatesRequest"/></param>
        /// <returns><see cref="DescribeVulCountByDatesResponse"/></returns>
        public async Task<DescribeVulCountByDatesResponse> DescribeVulCountByDates(DescribeVulCountByDatesRequest req)
        {
             JsonResponseModel<DescribeVulCountByDatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulCountByDates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulCountByDatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理模块，获取近日指定类型的漏洞数量和主机数量
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCountByDatesRequest"/></param>
        /// <returns><see cref="DescribeVulCountByDatesResponse"/></returns>
        public DescribeVulCountByDatesResponse DescribeVulCountByDatesSync(DescribeVulCountByDatesRequest req)
        {
             JsonResponseModel<DescribeVulCountByDatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulCountByDates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulCountByDatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取待处理漏洞数+影响主机数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostCountScanTimeRequest"/></param>
        /// <returns><see cref="DescribeVulHostCountScanTimeResponse"/></returns>
        public async Task<DescribeVulHostCountScanTimeResponse> DescribeVulHostCountScanTime(DescribeVulHostCountScanTimeRequest req)
        {
             JsonResponseModel<DescribeVulHostCountScanTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulHostCountScanTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulHostCountScanTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取待处理漏洞数+影响主机数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostCountScanTimeRequest"/></param>
        /// <returns><see cref="DescribeVulHostCountScanTimeResponse"/></returns>
        public DescribeVulHostCountScanTimeResponse DescribeVulHostCountScanTimeSync(DescribeVulHostCountScanTimeRequest req)
        {
             JsonResponseModel<DescribeVulHostCountScanTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulHostCountScanTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulHostCountScanTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取服务器风险top列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostTopRequest"/></param>
        /// <returns><see cref="DescribeVulHostTopResponse"/></returns>
        public async Task<DescribeVulHostTopResponse> DescribeVulHostTop(DescribeVulHostTopRequest req)
        {
             JsonResponseModel<DescribeVulHostTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulHostTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulHostTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取服务器风险top列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostTopRequest"/></param>
        /// <returns><see cref="DescribeVulHostTopResponse"/></returns>
        public DescribeVulHostTopResponse DescribeVulHostTopSync(DescribeVulHostTopRequest req)
        {
             JsonResponseModel<DescribeVulHostTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulHostTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulHostTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞详情，带CVSS版本
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoCvssRequest"/></param>
        /// <returns><see cref="DescribeVulInfoCvssResponse"/></returns>
        public async Task<DescribeVulInfoCvssResponse> DescribeVulInfoCvss(DescribeVulInfoCvssRequest req)
        {
             JsonResponseModel<DescribeVulInfoCvssResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulInfoCvss");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulInfoCvssResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞详情，带CVSS版本
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoCvssRequest"/></param>
        /// <returns><see cref="DescribeVulInfoCvssResponse"/></returns>
        public DescribeVulInfoCvssResponse DescribeVulInfoCvssSync(DescribeVulInfoCvssRequest req)
        {
             JsonResponseModel<DescribeVulInfoCvssResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulInfoCvss");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulInfoCvssResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞数量等级分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelCountRequest"/></param>
        /// <returns><see cref="DescribeVulLevelCountResponse"/></returns>
        public async Task<DescribeVulLevelCountResponse> DescribeVulLevelCount(DescribeVulLevelCountRequest req)
        {
             JsonResponseModel<DescribeVulLevelCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulLevelCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLevelCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞数量等级分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelCountRequest"/></param>
        /// <returns><see cref="DescribeVulLevelCountResponse"/></returns>
        public DescribeVulLevelCountResponse DescribeVulLevelCountSync(DescribeVulLevelCountRequest req)
        {
             JsonResponseModel<DescribeVulLevelCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulLevelCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLevelCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞top统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRequest"/></param>
        /// <returns><see cref="DescribeVulTopResponse"/></returns>
        public async Task<DescribeVulTopResponse> DescribeVulTop(DescribeVulTopRequest req)
        {
             JsonResponseModel<DescribeVulTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞top统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRequest"/></param>
        /// <returns><see cref="DescribeVulTopResponse"/></returns>
        public DescribeVulTopResponse DescribeVulTopSync(DescribeVulTopRequest req)
        {
             JsonResponseModel<DescribeVulTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前用户告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningListRequest"/></param>
        /// <returns><see cref="DescribeWarningListResponse"/></returns>
        public async Task<DescribeWarningListResponse> DescribeWarningList(DescribeWarningListRequest req)
        {
             JsonResponseModel<DescribeWarningListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWarningList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前用户告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningListRequest"/></param>
        /// <returns><see cref="DescribeWarningListResponse"/></returns>
        public DescribeWarningListResponse DescribeWarningListSync(DescribeWarningListRequest req)
        {
             JsonResponseModel<DescribeWarningListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWarningList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询篡改事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageEventListRequest"/></param>
        /// <returns><see cref="DescribeWebPageEventListResponse"/></returns>
        public async Task<DescribeWebPageEventListResponse> DescribeWebPageEventList(DescribeWebPageEventListRequest req)
        {
             JsonResponseModel<DescribeWebPageEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebPageEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询篡改事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageEventListRequest"/></param>
        /// <returns><see cref="DescribeWebPageEventListResponse"/></returns>
        public DescribeWebPageEventListResponse DescribeWebPageEventListSync(DescribeWebPageEventListRequest req)
        {
             JsonResponseModel<DescribeWebPageEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebPageEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网站防篡改概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageGeneralizeRequest"/></param>
        /// <returns><see cref="DescribeWebPageGeneralizeResponse"/></returns>
        public async Task<DescribeWebPageGeneralizeResponse> DescribeWebPageGeneralize(DescribeWebPageGeneralizeRequest req)
        {
             JsonResponseModel<DescribeWebPageGeneralizeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebPageGeneralize");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageGeneralizeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网站防篡改概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageGeneralizeRequest"/></param>
        /// <returns><see cref="DescribeWebPageGeneralizeResponse"/></returns>
        public DescribeWebPageGeneralizeResponse DescribeWebPageGeneralizeSync(DescribeWebPageGeneralizeRequest req)
        {
             JsonResponseModel<DescribeWebPageGeneralizeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebPageGeneralize");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageGeneralizeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改-查询动态防护信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageProtectStatRequest"/></param>
        /// <returns><see cref="DescribeWebPageProtectStatResponse"/></returns>
        public async Task<DescribeWebPageProtectStatResponse> DescribeWebPageProtectStat(DescribeWebPageProtectStatRequest req)
        {
             JsonResponseModel<DescribeWebPageProtectStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebPageProtectStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageProtectStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改-查询动态防护信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageProtectStatRequest"/></param>
        /// <returns><see cref="DescribeWebPageProtectStatResponse"/></returns>
        public DescribeWebPageProtectStatResponse DescribeWebPageProtectStatSync(DescribeWebPageProtectStatRequest req)
        {
             JsonResponseModel<DescribeWebPageProtectStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebPageProtectStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageProtectStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改-查询网页防篡改服务器购买信息及服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageServiceInfoRequest"/></param>
        /// <returns><see cref="DescribeWebPageServiceInfoResponse"/></returns>
        public async Task<DescribeWebPageServiceInfoResponse> DescribeWebPageServiceInfo(DescribeWebPageServiceInfoRequest req)
        {
             JsonResponseModel<DescribeWebPageServiceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebPageServiceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageServiceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改-查询网页防篡改服务器购买信息及服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebPageServiceInfoRequest"/></param>
        /// <returns><see cref="DescribeWebPageServiceInfoResponse"/></returns>
        public DescribeWebPageServiceInfoResponse DescribeWebPageServiceInfoSync(DescribeWebPageServiceInfoRequest req)
        {
             JsonResponseModel<DescribeWebPageServiceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebPageServiceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebPageServiceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改高危命令规则
        /// </summary>
        /// <param name="req"><see cref="EditBashRulesRequest"/></param>
        /// <returns><see cref="EditBashRulesResponse"/></returns>
        public async Task<EditBashRulesResponse> EditBashRules(EditBashRulesRequest req)
        {
             JsonResponseModel<EditBashRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改高危命令规则
        /// </summary>
        /// <param name="req"><see cref="EditBashRulesRequest"/></param>
        /// <returns><see cref="EditBashRulesResponse"/></returns>
        public EditBashRulesResponse EditBashRulesSync(EditBashRulesRequest req)
        {
             JsonResponseModel<EditBashRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EditBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或编辑标签
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public async Task<EditTagsResponse> EditTags(EditTagsRequest req)
        {
             JsonResponseModel<EditTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或编辑标签
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public EditTagsResponse EditTagsSync(EditTagsRequest req)
        {
             JsonResponseModel<EditTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EditTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理内核模块列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="ExportAssetCoreModuleListResponse"/></returns>
        public async Task<ExportAssetCoreModuleListResponse> ExportAssetCoreModuleList(ExportAssetCoreModuleListRequest req)
        {
             JsonResponseModel<ExportAssetCoreModuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetCoreModuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetCoreModuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理内核模块列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="ExportAssetCoreModuleListResponse"/></returns>
        public ExportAssetCoreModuleListResponse ExportAssetCoreModuleListSync(ExportAssetCoreModuleListRequest req)
        {
             JsonResponseModel<ExportAssetCoreModuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetCoreModuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetCoreModuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理Web服务列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetWebServiceInfoListResponse"/></returns>
        public async Task<ExportAssetWebServiceInfoListResponse> ExportAssetWebServiceInfoList(ExportAssetWebServiceInfoListRequest req)
        {
             JsonResponseModel<ExportAssetWebServiceInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetWebServiceInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebServiceInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理Web服务列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetWebServiceInfoListResponse"/></returns>
        public ExportAssetWebServiceInfoListResponse ExportAssetWebServiceInfoListSync(ExportAssetWebServiceInfoListRequest req)
        {
             JsonResponseModel<ExportAssetWebServiceInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetWebServiceInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebServiceInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="ExportAttackLogsRequest"/></param>
        /// <returns><see cref="ExportAttackLogsResponse"/></returns>
        public async Task<ExportAttackLogsResponse> ExportAttackLogs(ExportAttackLogsRequest req)
        {
             JsonResponseModel<ExportAttackLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAttackLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAttackLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="ExportAttackLogsRequest"/></param>
        /// <returns><see cref="ExportAttackLogsResponse"/></returns>
        public ExportAttackLogsResponse ExportAttackLogsSync(ExportAttackLogsRequest req)
        {
             JsonResponseModel<ExportAttackLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAttackLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAttackLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线影响主机列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="ExportBaselineEffectHostListResponse"/></returns>
        public async Task<ExportBaselineEffectHostListResponse> ExportBaselineEffectHostList(ExportBaselineEffectHostListRequest req)
        {
             JsonResponseModel<ExportBaselineEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线影响主机列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="ExportBaselineEffectHostListResponse"/></returns>
        public ExportBaselineEffectHostListResponse ExportBaselineEffectHostListSync(ExportBaselineEffectHostListRequest req)
        {
             JsonResponseModel<ExportBaselineEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineListRequest"/></param>
        /// <returns><see cref="ExportBaselineListResponse"/></returns>
        public async Task<ExportBaselineListResponse> ExportBaselineList(ExportBaselineListRequest req)
        {
             JsonResponseModel<ExportBaselineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineListRequest"/></param>
        /// <returns><see cref="ExportBaselineListResponse"/></returns>
        public ExportBaselineListResponse ExportBaselineListSync(ExportBaselineListRequest req)
        {
             JsonResponseModel<ExportBaselineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出高危命令事件
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsRequest"/></param>
        /// <returns><see cref="ExportBashEventsResponse"/></returns>
        public async Task<ExportBashEventsResponse> ExportBashEvents(ExportBashEventsRequest req)
        {
             JsonResponseModel<ExportBashEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBashEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBashEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出高危命令事件
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsRequest"/></param>
        /// <returns><see cref="ExportBashEventsResponse"/></returns>
        public ExportBashEventsResponse ExportBashEventsSync(ExportBashEventsRequest req)
        {
             JsonResponseModel<ExportBashEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBashEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBashEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportBruteAttacks) 用于导出密码破解记录成CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public async Task<ExportBruteAttacksResponse> ExportBruteAttacks(ExportBruteAttacksRequest req)
        {
             JsonResponseModel<ExportBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportBruteAttacks) 用于导出密码破解记录成CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public ExportBruteAttacksResponse ExportBruteAttacksSync(ExportBruteAttacksRequest req)
        {
             JsonResponseModel<ExportBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出已忽略基线检测项信息
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="ExportIgnoreBaselineRuleResponse"/></returns>
        public async Task<ExportIgnoreBaselineRuleResponse> ExportIgnoreBaselineRule(ExportIgnoreBaselineRuleRequest req)
        {
             JsonResponseModel<ExportIgnoreBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportIgnoreBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportIgnoreBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出已忽略基线检测项信息
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="ExportIgnoreBaselineRuleResponse"/></returns>
        public ExportIgnoreBaselineRuleResponse ExportIgnoreBaselineRuleSync(ExportIgnoreBaselineRuleRequest req)
        {
             JsonResponseModel<ExportIgnoreBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportIgnoreBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportIgnoreBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检测项id导出忽略检测项影响主机列表
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="ExportIgnoreRuleEffectHostListResponse"/></returns>
        public async Task<ExportIgnoreRuleEffectHostListResponse> ExportIgnoreRuleEffectHostList(ExportIgnoreRuleEffectHostListRequest req)
        {
             JsonResponseModel<ExportIgnoreRuleEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportIgnoreRuleEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportIgnoreRuleEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据检测项id导出忽略检测项影响主机列表
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="ExportIgnoreRuleEffectHostListResponse"/></returns>
        public ExportIgnoreRuleEffectHostListResponse ExportIgnoreRuleEffectHostListSync(ExportIgnoreRuleEffectHostListRequest req)
        {
             JsonResponseModel<ExportIgnoreRuleEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportIgnoreRuleEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportIgnoreRuleEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportMaliciousRequests) 用于导出下载恶意请求文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public async Task<ExportMaliciousRequestsResponse> ExportMaliciousRequests(ExportMaliciousRequestsRequest req)
        {
             JsonResponseModel<ExportMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportMaliciousRequests) 用于导出下载恶意请求文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public ExportMaliciousRequestsResponse ExportMaliciousRequestsSync(ExportMaliciousRequestsRequest req)
        {
             JsonResponseModel<ExportMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportMalwares) 用于导出木马记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public async Task<ExportMalwaresResponse> ExportMalwares(ExportMalwaresRequest req)
        {
             JsonResponseModel<ExportMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportMalwares) 用于导出木马记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public ExportMalwaresResponse ExportMalwaresSync(ExportMalwaresRequest req)
        {
             JsonResponseModel<ExportMalwaresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportNonlocalLoginPlaces) 用于导出异地登录事件记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public async Task<ExportNonlocalLoginPlacesResponse> ExportNonlocalLoginPlaces(ExportNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<ExportNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ExportNonlocalLoginPlaces) 用于导出异地登录事件记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public ExportNonlocalLoginPlacesResponse ExportNonlocalLoginPlacesSync(ExportNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<ExportNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出本地提权事件
        /// </summary>
        /// <param name="req"><see cref="ExportPrivilegeEventsRequest"/></param>
        /// <returns><see cref="ExportPrivilegeEventsResponse"/></returns>
        public async Task<ExportPrivilegeEventsResponse> ExportPrivilegeEvents(ExportPrivilegeEventsRequest req)
        {
             JsonResponseModel<ExportPrivilegeEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportPrivilegeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportPrivilegeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出本地提权事件
        /// </summary>
        /// <param name="req"><see cref="ExportPrivilegeEventsRequest"/></param>
        /// <returns><see cref="ExportPrivilegeEventsResponse"/></returns>
        public ExportPrivilegeEventsResponse ExportPrivilegeEventsSync(ExportPrivilegeEventsRequest req)
        {
             JsonResponseModel<ExportPrivilegeEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportPrivilegeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportPrivilegeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出网页防篡改防护目录列表
        /// </summary>
        /// <param name="req"><see cref="ExportProtectDirListRequest"/></param>
        /// <returns><see cref="ExportProtectDirListResponse"/></returns>
        public async Task<ExportProtectDirListResponse> ExportProtectDirList(ExportProtectDirListRequest req)
        {
             JsonResponseModel<ExportProtectDirListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportProtectDirList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportProtectDirListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出网页防篡改防护目录列表
        /// </summary>
        /// <param name="req"><see cref="ExportProtectDirListRequest"/></param>
        /// <returns><see cref="ExportProtectDirListResponse"/></returns>
        public ExportProtectDirListResponse ExportProtectDirListSync(ExportProtectDirListRequest req)
        {
             JsonResponseModel<ExportProtectDirListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportProtectDirList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportProtectDirListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="ExportReverseShellEventsRequest"/></param>
        /// <returns><see cref="ExportReverseShellEventsResponse"/></returns>
        public async Task<ExportReverseShellEventsResponse> ExportReverseShellEvents(ExportReverseShellEventsRequest req)
        {
             JsonResponseModel<ExportReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="ExportReverseShellEventsRequest"/></param>
        /// <returns><see cref="ExportReverseShellEventsResponse"/></returns>
        public ExportReverseShellEventsResponse ExportReverseShellEventsSync(ExportReverseShellEventsRequest req)
        {
             JsonResponseModel<ExportReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据任务id导出指定扫描任务详情 
        /// </summary>
        /// <param name="req"><see cref="ExportScanTaskDetailsRequest"/></param>
        /// <returns><see cref="ExportScanTaskDetailsResponse"/></returns>
        public async Task<ExportScanTaskDetailsResponse> ExportScanTaskDetails(ExportScanTaskDetailsRequest req)
        {
             JsonResponseModel<ExportScanTaskDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportScanTaskDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportScanTaskDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据任务id导出指定扫描任务详情 
        /// </summary>
        /// <param name="req"><see cref="ExportScanTaskDetailsRequest"/></param>
        /// <returns><see cref="ExportScanTaskDetailsResponse"/></returns>
        public ExportScanTaskDetailsResponse ExportScanTaskDetailsSync(ExportScanTaskDetailsRequest req)
        {
             JsonResponseModel<ExportScanTaskDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportScanTaskDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportScanTaskDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出风险趋势
        /// </summary>
        /// <param name="req"><see cref="ExportSecurityTrendsRequest"/></param>
        /// <returns><see cref="ExportSecurityTrendsResponse"/></returns>
        public async Task<ExportSecurityTrendsResponse> ExportSecurityTrends(ExportSecurityTrendsRequest req)
        {
             JsonResponseModel<ExportSecurityTrendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportSecurityTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportSecurityTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出风险趋势
        /// </summary>
        /// <param name="req"><see cref="ExportSecurityTrendsRequest"/></param>
        /// <returns><see cref="ExportSecurityTrendsResponse"/></returns>
        public ExportSecurityTrendsResponse ExportSecurityTrendsSync(ExportSecurityTrendsRequest req)
        {
             JsonResponseModel<ExportSecurityTrendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportSecurityTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportSecurityTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于异步导出数据量大的日志文件
        /// </summary>
        /// <param name="req"><see cref="ExportTasksRequest"/></param>
        /// <returns><see cref="ExportTasksResponse"/></returns>
        public async Task<ExportTasksResponse> ExportTasks(ExportTasksRequest req)
        {
             JsonResponseModel<ExportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于异步导出数据量大的日志文件
        /// </summary>
        /// <param name="req"><see cref="ExportTasksRequest"/></param>
        /// <returns><see cref="ExportTasksResponse"/></returns>
        public ExportTasksResponse ExportTasksSync(ExportTasksRequest req)
        {
             JsonResponseModel<ExportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出本次漏洞检测Excel
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionExcelRequest"/></param>
        /// <returns><see cref="ExportVulDetectionExcelResponse"/></returns>
        public async Task<ExportVulDetectionExcelResponse> ExportVulDetectionExcel(ExportVulDetectionExcelRequest req)
        {
             JsonResponseModel<ExportVulDetectionExcelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulDetectionExcel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDetectionExcelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出本次漏洞检测Excel
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionExcelRequest"/></param>
        /// <returns><see cref="ExportVulDetectionExcelResponse"/></returns>
        public ExportVulDetectionExcelResponse ExportVulDetectionExcelSync(ExportVulDetectionExcelRequest req)
        {
             JsonResponseModel<ExportVulDetectionExcelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulDetectionExcel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDetectionExcelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞检测报告。
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionReportRequest"/></param>
        /// <returns><see cref="ExportVulDetectionReportResponse"/></returns>
        public async Task<ExportVulDetectionReportResponse> ExportVulDetectionReport(ExportVulDetectionReportRequest req)
        {
             JsonResponseModel<ExportVulDetectionReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulDetectionReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDetectionReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞检测报告。
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionReportRequest"/></param>
        /// <returns><see cref="ExportVulDetectionReportResponse"/></returns>
        public ExportVulDetectionReportResponse ExportVulDetectionReportSync(ExportVulDetectionReportRequest req)
        {
             JsonResponseModel<ExportVulDetectionReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulDetectionReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDetectionReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞影响主机列表
        /// </summary>
        /// <param name="req"><see cref="ExportVulEffectHostListRequest"/></param>
        /// <returns><see cref="ExportVulEffectHostListResponse"/></returns>
        public async Task<ExportVulEffectHostListResponse> ExportVulEffectHostList(ExportVulEffectHostListRequest req)
        {
             JsonResponseModel<ExportVulEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞影响主机列表
        /// </summary>
        /// <param name="req"><see cref="ExportVulEffectHostListRequest"/></param>
        /// <returns><see cref="ExportVulEffectHostListResponse"/></returns>
        public ExportVulEffectHostListResponse ExportVulEffectHostListSync(ExportVulEffectHostListRequest req)
        {
             JsonResponseModel<ExportVulEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理-导出漏洞列表
        /// </summary>
        /// <param name="req"><see cref="ExportVulListRequest"/></param>
        /// <returns><see cref="ExportVulListResponse"/></returns>
        public async Task<ExportVulListResponse> ExportVulList(ExportVulListRequest req)
        {
             JsonResponseModel<ExportVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理-导出漏洞列表
        /// </summary>
        /// <param name="req"><see cref="ExportVulListRequest"/></param>
        /// <returns><see cref="ExportVulListResponse"/></returns>
        public ExportVulListResponse ExportVulListSync(ExportVulListRequest req)
        {
             JsonResponseModel<ExportVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出篡改事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportWebPageEventListRequest"/></param>
        /// <returns><see cref="ExportWebPageEventListResponse"/></returns>
        public async Task<ExportWebPageEventListResponse> ExportWebPageEventList(ExportWebPageEventListRequest req)
        {
             JsonResponseModel<ExportWebPageEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportWebPageEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportWebPageEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出篡改事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportWebPageEventListRequest"/></param>
        /// <returns><see cref="ExportWebPageEventListResponse"/></returns>
        public ExportWebPageEventListResponse ExportWebPageEventListSync(ExportWebPageEventListRequest req)
        {
             JsonResponseModel<ExportWebPageEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportWebPageEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportWebPageEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (IgnoreImpactedHosts) 用于忽略漏洞。
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public async Task<IgnoreImpactedHostsResponse> IgnoreImpactedHosts(IgnoreImpactedHostsRequest req)
        {
             JsonResponseModel<IgnoreImpactedHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IgnoreImpactedHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IgnoreImpactedHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (IgnoreImpactedHosts) 用于忽略漏洞。
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public IgnoreImpactedHostsResponse IgnoreImpactedHostsSync(IgnoreImpactedHostsRequest req)
        {
             JsonResponseModel<IgnoreImpactedHostsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IgnoreImpactedHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IgnoreImpactedHostsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceOpenProVersionPrepaid) 用于开通专业版询价(预付费)。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceOpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="InquiryPriceOpenProVersionPrepaidResponse"/></returns>
        public async Task<InquiryPriceOpenProVersionPrepaidResponse> InquiryPriceOpenProVersionPrepaid(InquiryPriceOpenProVersionPrepaidRequest req)
        {
             JsonResponseModel<InquiryPriceOpenProVersionPrepaidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceOpenProVersionPrepaid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceOpenProVersionPrepaidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceOpenProVersionPrepaid) 用于开通专业版询价(预付费)。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceOpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="InquiryPriceOpenProVersionPrepaidResponse"/></returns>
        public InquiryPriceOpenProVersionPrepaidResponse InquiryPriceOpenProVersionPrepaidSync(InquiryPriceOpenProVersionPrepaidRequest req)
        {
             JsonResponseModel<InquiryPriceOpenProVersionPrepaidResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceOpenProVersionPrepaid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceOpenProVersionPrepaidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  用于设置新增主机自动开通专业版配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public async Task<ModifyAutoOpenProVersionConfigResponse> ModifyAutoOpenProVersionConfig(ModifyAutoOpenProVersionConfigRequest req)
        {
             JsonResponseModel<ModifyAutoOpenProVersionConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoOpenProVersionConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoOpenProVersionConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  用于设置新增主机自动开通专业版配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public ModifyAutoOpenProVersionConfigResponse ModifyAutoOpenProVersionConfigSync(ModifyAutoOpenProVersionConfigRequest req)
        {
             JsonResponseModel<ModifyAutoOpenProVersionConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoOpenProVersionConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoOpenProVersionConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="ModifyBanModeRequest"/></param>
        /// <returns><see cref="ModifyBanModeResponse"/></returns>
        public async Task<ModifyBanModeResponse> ModifyBanMode(ModifyBanModeRequest req)
        {
             JsonResponseModel<ModifyBanModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBanMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBanModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="ModifyBanModeRequest"/></param>
        /// <returns><see cref="ModifyBanModeResponse"/></returns>
        public ModifyBanModeResponse ModifyBanModeSync(ModifyBanModeRequest req)
        {
             JsonResponseModel<ModifyBanModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBanMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBanModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置阻断开关状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBanStatusResponse"/></returns>
        public async Task<ModifyBanStatusResponse> ModifyBanStatus(ModifyBanStatusRequest req)
        {
             JsonResponseModel<ModifyBanStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置阻断开关状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBanStatusResponse"/></returns>
        public ModifyBanStatusResponse ModifyBanStatusSync(ModifyBanStatusRequest req)
        {
             JsonResponseModel<ModifyBanStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改暴力破解规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackRulesRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackRulesResponse"/></returns>
        public async Task<ModifyBruteAttackRulesResponse> ModifyBruteAttackRules(ModifyBruteAttackRulesRequest req)
        {
             JsonResponseModel<ModifyBruteAttackRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBruteAttackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBruteAttackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改暴力破解规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackRulesRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackRulesResponse"/></returns>
        public ModifyBruteAttackRulesResponse ModifyBruteAttackRulesSync(ModifyBruteAttackRulesRequest req)
        {
             JsonResponseModel<ModifyBruteAttackRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBruteAttackRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBruteAttackRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 定时扫描设置
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public async Task<ModifyMalwareTimingScanSettingsResponse> ModifyMalwareTimingScanSettings(ModifyMalwareTimingScanSettingsRequest req)
        {
             JsonResponseModel<ModifyMalwareTimingScanSettingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMalwareTimingScanSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMalwareTimingScanSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 定时扫描设置
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public ModifyMalwareTimingScanSettingsResponse ModifyMalwareTimingScanSettingsSync(ModifyMalwareTimingScanSettingsRequest req)
        {
             JsonResponseModel<ModifyMalwareTimingScanSettingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMalwareTimingScanSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMalwareTimingScanSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyProVersionRenewFlag) 用于修改专业版包年包月续费标识。
        /// </summary>
        /// <param name="req"><see cref="ModifyProVersionRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyProVersionRenewFlagResponse"/></returns>
        public async Task<ModifyProVersionRenewFlagResponse> ModifyProVersionRenewFlag(ModifyProVersionRenewFlagRequest req)
        {
             JsonResponseModel<ModifyProVersionRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProVersionRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProVersionRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyProVersionRenewFlag) 用于修改专业版包年包月续费标识。
        /// </summary>
        /// <param name="req"><see cref="ModifyProVersionRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyProVersionRenewFlagResponse"/></returns>
        public ModifyProVersionRenewFlagResponse ModifyProVersionRenewFlagSync(ModifyProVersionRenewFlagRequest req)
        {
             JsonResponseModel<ModifyProVersionRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProVersionRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProVersionRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警设置
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningSettingRequest"/></param>
        /// <returns><see cref="ModifyWarningSettingResponse"/></returns>
        public async Task<ModifyWarningSettingResponse> ModifyWarningSetting(ModifyWarningSettingRequest req)
        {
             JsonResponseModel<ModifyWarningSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWarningSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWarningSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警设置
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningSettingRequest"/></param>
        /// <returns><see cref="ModifyWarningSettingResponse"/></returns>
        public ModifyWarningSettingResponse ModifyWarningSettingSync(ModifyWarningSettingRequest req)
        {
             JsonResponseModel<ModifyWarningSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWarningSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWarningSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建/修改网站防护目录
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectDirRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectDirResponse"/></returns>
        public async Task<ModifyWebPageProtectDirResponse> ModifyWebPageProtectDir(ModifyWebPageProtectDirRequest req)
        {
             JsonResponseModel<ModifyWebPageProtectDirResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebPageProtectDir");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebPageProtectDirResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建/修改网站防护目录
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectDirRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectDirResponse"/></returns>
        public ModifyWebPageProtectDirResponse ModifyWebPageProtectDirSync(ModifyWebPageProtectDirRequest req)
        {
             JsonResponseModel<ModifyWebPageProtectDirResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebPageProtectDir");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebPageProtectDirResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改网站防护设置
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectSettingRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectSettingResponse"/></returns>
        public async Task<ModifyWebPageProtectSettingResponse> ModifyWebPageProtectSetting(ModifyWebPageProtectSettingRequest req)
        {
             JsonResponseModel<ModifyWebPageProtectSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebPageProtectSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebPageProtectSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改网站防护设置
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectSettingRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectSettingResponse"/></returns>
        public ModifyWebPageProtectSettingResponse ModifyWebPageProtectSettingSync(ModifyWebPageProtectSettingRequest req)
        {
             JsonResponseModel<ModifyWebPageProtectSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebPageProtectSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebPageProtectSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改防护设置开关
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectSwitchRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectSwitchResponse"/></returns>
        public async Task<ModifyWebPageProtectSwitchResponse> ModifyWebPageProtectSwitch(ModifyWebPageProtectSwitchRequest req)
        {
             JsonResponseModel<ModifyWebPageProtectSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebPageProtectSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebPageProtectSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网站防篡改防护设置开关
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectSwitchRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectSwitchResponse"/></returns>
        public ModifyWebPageProtectSwitchResponse ModifyWebPageProtectSwitchSync(ModifyWebPageProtectSwitchRequest req)
        {
             JsonResponseModel<ModifyWebPageProtectSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebPageProtectSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebPageProtectSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (OpenProVersion) 用于开通专业版。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionRequest"/></param>
        /// <returns><see cref="OpenProVersionResponse"/></returns>
        public async Task<OpenProVersionResponse> OpenProVersion(OpenProVersionRequest req)
        {
             JsonResponseModel<OpenProVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (OpenProVersion) 用于开通专业版。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionRequest"/></param>
        /// <returns><see cref="OpenProVersionResponse"/></returns>
        public OpenProVersionResponse OpenProVersionSync(OpenProVersionRequest req)
        {
             JsonResponseModel<OpenProVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (OpenProVersionPrepaid) 用于开通专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="OpenProVersionPrepaidResponse"/></returns>
        public async Task<OpenProVersionPrepaidResponse> OpenProVersionPrepaid(OpenProVersionPrepaidRequest req)
        {
             JsonResponseModel<OpenProVersionPrepaidResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenProVersionPrepaid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProVersionPrepaidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (OpenProVersionPrepaid) 用于开通专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="OpenProVersionPrepaidResponse"/></returns>
        public OpenProVersionPrepaidResponse OpenProVersionPrepaidSync(OpenProVersionPrepaidRequest req)
        {
             JsonResponseModel<OpenProVersionPrepaidResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenProVersionPrepaid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenProVersionPrepaidResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RecoverMalwares）用于批量恢复已经被隔离的木马文件。
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public async Task<RecoverMalwaresResponse> RecoverMalwares(RecoverMalwaresRequest req)
        {
             JsonResponseModel<RecoverMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RecoverMalwares）用于批量恢复已经被隔离的木马文件。
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public RecoverMalwaresResponse RecoverMalwaresSync(RecoverMalwaresRequest req)
        {
             JsonResponseModel<RecoverMalwaresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RenewProVersion) 用于续费专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="RenewProVersionRequest"/></param>
        /// <returns><see cref="RenewProVersionResponse"/></returns>
        public async Task<RenewProVersionResponse> RenewProVersion(RenewProVersionRequest req)
        {
             JsonResponseModel<RenewProVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (RenewProVersion) 用于续费专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="RenewProVersionRequest"/></param>
        /// <returns><see cref="RenewProVersionResponse"/></returns>
        public RenewProVersionResponse RenewProVersionSync(RenewProVersionRequest req)
        {
             JsonResponseModel<RenewProVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewProVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewProVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口已废弃
        /// 
        /// 本接口 (RescanImpactedHost) 用于漏洞重新检测。
        /// </summary>
        /// <param name="req"><see cref="RescanImpactedHostRequest"/></param>
        /// <returns><see cref="RescanImpactedHostResponse"/></returns>
        public async Task<RescanImpactedHostResponse> RescanImpactedHost(RescanImpactedHostRequest req)
        {
             JsonResponseModel<RescanImpactedHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RescanImpactedHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RescanImpactedHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口已废弃
        /// 
        /// 本接口 (RescanImpactedHost) 用于漏洞重新检测。
        /// </summary>
        /// <param name="req"><see cref="RescanImpactedHostRequest"/></param>
        /// <returns><see cref="RescanImpactedHostResponse"/></returns>
        public RescanImpactedHostResponse RescanImpactedHostSync(RescanImpactedHostRequest req)
        {
             JsonResponseModel<RescanImpactedHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RescanImpactedHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RescanImpactedHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产指纹启动扫描
        /// </summary>
        /// <param name="req"><see cref="ScanAssetRequest"/></param>
        /// <returns><see cref="ScanAssetResponse"/></returns>
        public async Task<ScanAssetResponse> ScanAsset(ScanAssetRequest req)
        {
             JsonResponseModel<ScanAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产指纹启动扫描
        /// </summary>
        /// <param name="req"><see cref="ScanAssetRequest"/></param>
        /// <returns><see cref="ScanAssetResponse"/></returns>
        public ScanAssetResponse ScanAssetSync(ScanAssetRequest req)
        {
             JsonResponseModel<ScanAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  一键检测
        /// </summary>
        /// <param name="req"><see cref="ScanVulRequest"/></param>
        /// <returns><see cref="ScanVulResponse"/></returns>
        public async Task<ScanVulResponse> ScanVul(ScanVulRequest req)
        {
             JsonResponseModel<ScanVulResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  一键检测
        /// </summary>
        /// <param name="req"><see cref="ScanVulRequest"/></param>
        /// <returns><see cref="ScanVulResponse"/></returns>
        public ScanVulResponse ScanVulSync(ScanVulRequest req)
        {
             JsonResponseModel<ScanVulResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理-重新检测接口
        /// </summary>
        /// <param name="req"><see cref="ScanVulAgainRequest"/></param>
        /// <returns><see cref="ScanVulAgainResponse"/></returns>
        public async Task<ScanVulAgainResponse> ScanVulAgain(ScanVulAgainRequest req)
        {
             JsonResponseModel<ScanVulAgainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanVulAgain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVulAgainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞管理-重新检测接口
        /// </summary>
        /// <param name="req"><see cref="ScanVulAgainRequest"/></param>
        /// <returns><see cref="ScanVulAgainResponse"/></returns>
        public ScanVulAgainResponse ScanVulAgainSync(ScanVulAgainRequest req)
        {
             JsonResponseModel<ScanVulAgainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanVulAgain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVulAgainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 定期扫描漏洞设置
        /// </summary>
        /// <param name="req"><see cref="ScanVulSettingRequest"/></param>
        /// <returns><see cref="ScanVulSettingResponse"/></returns>
        public async Task<ScanVulSettingResponse> ScanVulSetting(ScanVulSettingRequest req)
        {
             JsonResponseModel<ScanVulSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanVulSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVulSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 定期扫描漏洞设置
        /// </summary>
        /// <param name="req"><see cref="ScanVulSettingRequest"/></param>
        /// <returns><see cref="ScanVulSettingResponse"/></returns>
        public ScanVulSettingResponse ScanVulSettingSync(ScanVulSettingRequest req)
        {
             JsonResponseModel<ScanVulSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanVulSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVulSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SeparateMalwares）用于隔离木马。
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public async Task<SeparateMalwaresResponse> SeparateMalwares(SeparateMalwaresRequest req)
        {
             JsonResponseModel<SeparateMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SeparateMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SeparateMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SeparateMalwares）用于隔离木马。
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public SeparateMalwaresResponse SeparateMalwaresSync(SeparateMalwaresRequest req)
        {
             JsonResponseModel<SeparateMalwaresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SeparateMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SeparateMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置高危命令事件状态
        /// </summary>
        /// <param name="req"><see cref="SetBashEventsStatusRequest"/></param>
        /// <returns><see cref="SetBashEventsStatusResponse"/></returns>
        public async Task<SetBashEventsStatusResponse> SetBashEventsStatus(SetBashEventsStatusRequest req)
        {
             JsonResponseModel<SetBashEventsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetBashEventsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetBashEventsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置高危命令事件状态
        /// </summary>
        /// <param name="req"><see cref="SetBashEventsStatusRequest"/></param>
        /// <returns><see cref="SetBashEventsStatusResponse"/></returns>
        public SetBashEventsStatusResponse SetBashEventsStatusSync(SetBashEventsStatusRequest req)
        {
             JsonResponseModel<SetBashEventsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetBashEventsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetBashEventsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 不再提醒爆破阻断提示弹窗
        /// </summary>
        /// <param name="req"><see cref="StopNoticeBanTipsRequest"/></param>
        /// <returns><see cref="StopNoticeBanTipsResponse"/></returns>
        public async Task<StopNoticeBanTipsResponse> StopNoticeBanTips(StopNoticeBanTipsRequest req)
        {
             JsonResponseModel<StopNoticeBanTipsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopNoticeBanTips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopNoticeBanTipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 不再提醒爆破阻断提示弹窗
        /// </summary>
        /// <param name="req"><see cref="StopNoticeBanTipsRequest"/></param>
        /// <returns><see cref="StopNoticeBanTipsResponse"/></returns>
        public StopNoticeBanTipsResponse StopNoticeBanTipsSync(StopNoticeBanTipsRequest req)
        {
             JsonResponseModel<StopNoticeBanTipsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopNoticeBanTips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopNoticeBanTipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换高危命令规则状态
        /// </summary>
        /// <param name="req"><see cref="SwitchBashRulesRequest"/></param>
        /// <returns><see cref="SwitchBashRulesResponse"/></returns>
        public async Task<SwitchBashRulesResponse> SwitchBashRules(SwitchBashRulesRequest req)
        {
             JsonResponseModel<SwitchBashRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换高危命令规则状态
        /// </summary>
        /// <param name="req"><see cref="SwitchBashRulesRequest"/></param>
        /// <returns><see cref="SwitchBashRulesResponse"/></returns>
        public SwitchBashRulesResponse SwitchBashRulesSync(SwitchBashRulesRequest req)
        {
             JsonResponseModel<SwitchBashRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchBashRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchBashRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产扫描信息
        /// </summary>
        /// <param name="req"><see cref="SyncAssetScanRequest"/></param>
        /// <returns><see cref="SyncAssetScanResponse"/></returns>
        public async Task<SyncAssetScanResponse> SyncAssetScan(SyncAssetScanRequest req)
        {
             JsonResponseModel<SyncAssetScanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产扫描信息
        /// </summary>
        /// <param name="req"><see cref="SyncAssetScanRequest"/></param>
        /// <returns><see cref="SyncAssetScanResponse"/></returns>
        public SyncAssetScanResponse SyncAssetScanSync(SyncAssetScanRequest req)
        {
             JsonResponseModel<SyncAssetScanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(TrustMalwares)将被识别木马文件设为信任。
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public async Task<TrustMalwaresResponse> TrustMalwares(TrustMalwaresRequest req)
        {
             JsonResponseModel<TrustMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TrustMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrustMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(TrustMalwares)将被识别木马文件设为信任。
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public TrustMalwaresResponse TrustMalwaresSync(TrustMalwaresRequest req)
        {
             JsonResponseModel<TrustMalwaresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TrustMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrustMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UntrustMalwares）用于取消信任木马文件。
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public async Task<UntrustMalwaresResponse> UntrustMalwares(UntrustMalwaresRequest req)
        {
             JsonResponseModel<UntrustMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UntrustMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UntrustMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UntrustMalwares）用于取消信任木马文件。
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public UntrustMalwaresResponse UntrustMalwaresSync(UntrustMalwaresRequest req)
        {
             JsonResponseModel<UntrustMalwaresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UntrustMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UntrustMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id更新策略信息
        /// </summary>
        /// <param name="req"><see cref="UpdateBaselineStrategyRequest"/></param>
        /// <returns><see cref="UpdateBaselineStrategyResponse"/></returns>
        public async Task<UpdateBaselineStrategyResponse> UpdateBaselineStrategy(UpdateBaselineStrategyRequest req)
        {
             JsonResponseModel<UpdateBaselineStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateBaselineStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBaselineStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据基线策略id更新策略信息
        /// </summary>
        /// <param name="req"><see cref="UpdateBaselineStrategyRequest"/></param>
        /// <returns><see cref="UpdateBaselineStrategyResponse"/></returns>
        public UpdateBaselineStrategyResponse UpdateBaselineStrategySync(UpdateBaselineStrategyRequest req)
        {
             JsonResponseModel<UpdateBaselineStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateBaselineStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBaselineStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联机器标签列表
        /// </summary>
        /// <param name="req"><see cref="UpdateMachineTagsRequest"/></param>
        /// <returns><see cref="UpdateMachineTagsResponse"/></returns>
        public async Task<UpdateMachineTagsResponse> UpdateMachineTags(UpdateMachineTagsRequest req)
        {
             JsonResponseModel<UpdateMachineTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateMachineTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateMachineTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联机器标签列表
        /// </summary>
        /// <param name="req"><see cref="UpdateMachineTagsRequest"/></param>
        /// <returns><see cref="UpdateMachineTagsResponse"/></returns>
        public UpdateMachineTagsResponse UpdateMachineTagsSync(UpdateMachineTagsRequest req)
        {
             JsonResponseModel<UpdateMachineTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateMachineTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateMachineTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
