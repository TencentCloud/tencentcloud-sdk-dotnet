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
        /// 批量添加异地登录白名单
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListsRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListsResponse"/></returns>
        public async Task<AddLoginWhiteListsResponse> AddLoginWhiteLists(AddLoginWhiteListsRequest req)
        {
             JsonResponseModel<AddLoginWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLoginWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLoginWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加异地登录白名单
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListsRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListsResponse"/></returns>
        public AddLoginWhiteListsResponse AddLoginWhiteListsSync(AddLoginWhiteListsRequest req)
        {
             JsonResponseModel<AddLoginWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddLoginWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLoginWhiteListsResponse>>(strResp);
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
        /// 根据策略id修改策略可用状态
        /// </summary>
        /// <param name="req"><see cref="ChangeStrategyEnableStatusRequest"/></param>
        /// <returns><see cref="ChangeStrategyEnableStatusResponse"/></returns>
        public async Task<ChangeStrategyEnableStatusResponse> ChangeStrategyEnableStatus(ChangeStrategyEnableStatusRequest req)
        {
             JsonResponseModel<ChangeStrategyEnableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeStrategyEnableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeStrategyEnableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据策略id修改策略可用状态
        /// </summary>
        /// <param name="req"><see cref="ChangeStrategyEnableStatusRequest"/></param>
        /// <returns><see cref="ChangeStrategyEnableStatusResponse"/></returns>
        public ChangeStrategyEnableStatusResponse ChangeStrategyEnableStatusSync(ChangeStrategyEnableStatusRequest req)
        {
             JsonResponseModel<ChangeStrategyEnableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeStrategyEnableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeStrategyEnableStatusResponse>>(strResp);
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
        /// <param name="req"><see cref="CheckBashPolicyParamsRequest"/></param>
        /// <returns><see cref="CheckBashPolicyParamsResponse"/></returns>
        public async Task<CheckBashPolicyParamsResponse> CheckBashPolicyParams(CheckBashPolicyParamsRequest req)
        {
             JsonResponseModel<CheckBashPolicyParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBashPolicyParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBashPolicyParamsResponse>>(strResp);
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
        /// <param name="req"><see cref="CheckBashPolicyParamsRequest"/></param>
        /// <returns><see cref="CheckBashPolicyParamsResponse"/></returns>
        public CheckBashPolicyParamsResponse CheckBashPolicyParamsSync(CheckBashPolicyParamsRequest req)
        {
             JsonResponseModel<CheckBashPolicyParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBashPolicyParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBashPolicyParamsResponse>>(strResp);
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
        /// 检验核心文件监控前端新增和编辑时的规则参数。
        /// </summary>
        /// <param name="req"><see cref="CheckFileTamperRuleRequest"/></param>
        /// <returns><see cref="CheckFileTamperRuleResponse"/></returns>
        public async Task<CheckFileTamperRuleResponse> CheckFileTamperRule(CheckFileTamperRuleRequest req)
        {
             JsonResponseModel<CheckFileTamperRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckFileTamperRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFileTamperRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检验核心文件监控前端新增和编辑时的规则参数。
        /// </summary>
        /// <param name="req"><see cref="CheckFileTamperRuleRequest"/></param>
        /// <returns><see cref="CheckFileTamperRuleResponse"/></returns>
        public CheckFileTamperRuleResponse CheckFileTamperRuleSync(CheckFileTamperRuleRequest req)
        {
             JsonResponseModel<CheckFileTamperRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckFileTamperRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFileTamperRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询基线是否第一次检测
        /// </summary>
        /// <param name="req"><see cref="CheckFirstScanBaselineRequest"/></param>
        /// <returns><see cref="CheckFirstScanBaselineResponse"/></returns>
        public async Task<CheckFirstScanBaselineResponse> CheckFirstScanBaseline(CheckFirstScanBaselineRequest req)
        {
             JsonResponseModel<CheckFirstScanBaselineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckFirstScanBaseline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFirstScanBaselineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询基线是否第一次检测
        /// </summary>
        /// <param name="req"><see cref="CheckFirstScanBaselineRequest"/></param>
        /// <returns><see cref="CheckFirstScanBaselineResponse"/></returns>
        public CheckFirstScanBaselineResponse CheckFirstScanBaselineSync(CheckFirstScanBaselineRequest req)
        {
             JsonResponseModel<CheckFirstScanBaselineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckFirstScanBaseline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFirstScanBaselineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查日志投递kafka连通性
        /// </summary>
        /// <param name="req"><see cref="CheckLogKafkaConnectionStateRequest"/></param>
        /// <returns><see cref="CheckLogKafkaConnectionStateResponse"/></returns>
        public async Task<CheckLogKafkaConnectionStateResponse> CheckLogKafkaConnectionState(CheckLogKafkaConnectionStateRequest req)
        {
             JsonResponseModel<CheckLogKafkaConnectionStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckLogKafkaConnectionState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckLogKafkaConnectionStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查日志投递kafka连通性
        /// </summary>
        /// <param name="req"><see cref="CheckLogKafkaConnectionStateRequest"/></param>
        /// <returns><see cref="CheckLogKafkaConnectionStateResponse"/></returns>
        public CheckLogKafkaConnectionStateResponse CheckLogKafkaConnectionStateSync(CheckLogKafkaConnectionStateRequest req)
        {
             JsonResponseModel<CheckLogKafkaConnectionStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckLogKafkaConnectionState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckLogKafkaConnectionStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清理本地存储数据
        /// </summary>
        /// <param name="req"><see cref="ClearLocalStorageRequest"/></param>
        /// <returns><see cref="ClearLocalStorageResponse"/></returns>
        public async Task<ClearLocalStorageResponse> ClearLocalStorage(ClearLocalStorageRequest req)
        {
             JsonResponseModel<ClearLocalStorageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearLocalStorage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearLocalStorageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清理本地存储数据
        /// </summary>
        /// <param name="req"><see cref="ClearLocalStorageRequest"/></param>
        /// <returns><see cref="ClearLocalStorageResponse"/></returns>
        public ClearLocalStorageResponse ClearLocalStorageSync(ClearLocalStorageRequest req)
        {
             JsonResponseModel<ClearLocalStorageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearLocalStorage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearLocalStorageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="CreateBanWhiteListRequest"/></param>
        /// <returns><see cref="CreateBanWhiteListResponse"/></returns>
        public async Task<CreateBanWhiteListResponse> CreateBanWhiteList(CreateBanWhiteListRequest req)
        {
             JsonResponseModel<CreateBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBanWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="CreateBanWhiteListRequest"/></param>
        /// <returns><see cref="CreateBanWhiteListResponse"/></returns>
        public CreateBanWhiteListResponse CreateBanWhiteListSync(CreateBanWhiteListRequest req)
        {
             JsonResponseModel<CreateBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBanWhiteListResponse>>(strResp);
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
        /// 新购授权自动绑定任务
        /// </summary>
        /// <param name="req"><see cref="CreateBuyBindTaskRequest"/></param>
        /// <returns><see cref="CreateBuyBindTaskResponse"/></returns>
        public async Task<CreateBuyBindTaskResponse> CreateBuyBindTask(CreateBuyBindTaskRequest req)
        {
             JsonResponseModel<CreateBuyBindTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBuyBindTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBuyBindTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新购授权自动绑定任务
        /// </summary>
        /// <param name="req"><see cref="CreateBuyBindTaskRequest"/></param>
        /// <returns><see cref="CreateBuyBindTaskResponse"/></returns>
        public CreateBuyBindTaskResponse CreateBuyBindTaskSync(CreateBuyBindTaskRequest req)
        {
             JsonResponseModel<CreateBuyBindTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBuyBindTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBuyBindTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云护航服务使用完成后，该接口可以确认收货
        /// </summary>
        /// <param name="req"><see cref="CreateCloudProtectServiceOrderRecordRequest"/></param>
        /// <returns><see cref="CreateCloudProtectServiceOrderRecordResponse"/></returns>
        public async Task<CreateCloudProtectServiceOrderRecordResponse> CreateCloudProtectServiceOrderRecord(CreateCloudProtectServiceOrderRecordRequest req)
        {
             JsonResponseModel<CreateCloudProtectServiceOrderRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudProtectServiceOrderRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudProtectServiceOrderRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云护航服务使用完成后，该接口可以确认收货
        /// </summary>
        /// <param name="req"><see cref="CreateCloudProtectServiceOrderRecordRequest"/></param>
        /// <returns><see cref="CreateCloudProtectServiceOrderRecordResponse"/></returns>
        public CreateCloudProtectServiceOrderRecordResponse CreateCloudProtectServiceOrderRecordSync(CreateCloudProtectServiceOrderRecordRequest req)
        {
             JsonResponseModel<CreateCloudProtectServiceOrderRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudProtectServiceOrderRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudProtectServiceOrderRecordResponse>>(strResp);
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
        /// 对旗舰版机器单次触发事件调查及告警回溯
        /// </summary>
        /// <param name="req"><see cref="CreateIncidentBacktrackingRequest"/></param>
        /// <returns><see cref="CreateIncidentBacktrackingResponse"/></returns>
        public async Task<CreateIncidentBacktrackingResponse> CreateIncidentBacktracking(CreateIncidentBacktrackingRequest req)
        {
             JsonResponseModel<CreateIncidentBacktrackingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIncidentBacktracking");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIncidentBacktrackingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对旗舰版机器单次触发事件调查及告警回溯
        /// </summary>
        /// <param name="req"><see cref="CreateIncidentBacktrackingRequest"/></param>
        /// <returns><see cref="CreateIncidentBacktrackingResponse"/></returns>
        public CreateIncidentBacktrackingResponse CreateIncidentBacktrackingSync(CreateIncidentBacktrackingRequest req)
        {
             JsonResponseModel<CreateIncidentBacktrackingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIncidentBacktracking");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIncidentBacktrackingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLicenseOrder 该接口可以创建专业版/旗舰版订单
        /// 支持预付费后付费创建
        /// 后付费订单直接创建成功
        /// 预付费订单仅下单不支付,需要调用计费支付接口进行支付
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseOrderRequest"/></param>
        /// <returns><see cref="CreateLicenseOrderResponse"/></returns>
        public async Task<CreateLicenseOrderResponse> CreateLicenseOrder(CreateLicenseOrderRequest req)
        {
             JsonResponseModel<CreateLicenseOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLicenseOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLicenseOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLicenseOrder 该接口可以创建专业版/旗舰版订单
        /// 支持预付费后付费创建
        /// 后付费订单直接创建成功
        /// 预付费订单仅下单不支付,需要调用计费支付接口进行支付
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseOrderRequest"/></param>
        /// <returns><see cref="CreateLicenseOrderResponse"/></returns>
        public CreateLicenseOrderResponse CreateLicenseOrderSync(CreateLicenseOrderRequest req)
        {
             JsonResponseModel<CreateLicenseOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLicenseOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLicenseOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建日志下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public async Task<CreateLogExportResponse> CreateLogExport(CreateLogExportRequest req)
        {
             JsonResponseModel<CreateLogExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建日志下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public CreateLogExportResponse CreateLogExportSync(CreateLogExportRequest req)
        {
             JsonResponseModel<CreateLogExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加恶意请求白名单
        /// </summary>
        /// <param name="req"><see cref="CreateMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="CreateMaliciousRequestWhiteListResponse"/></returns>
        public async Task<CreateMaliciousRequestWhiteListResponse> CreateMaliciousRequestWhiteList(CreateMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<CreateMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMaliciousRequestWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加恶意请求白名单
        /// </summary>
        /// <param name="req"><see cref="CreateMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="CreateMaliciousRequestWhiteListResponse"/></returns>
        public CreateMaliciousRequestWhiteListResponse CreateMaliciousRequestWhiteListSync(CreateMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<CreateMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMaliciousRequestWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建木马白名单
        /// </summary>
        /// <param name="req"><see cref="CreateMalwareWhiteListRequest"/></param>
        /// <returns><see cref="CreateMalwareWhiteListResponse"/></returns>
        public async Task<CreateMalwareWhiteListResponse> CreateMalwareWhiteList(CreateMalwareWhiteListRequest req)
        {
             JsonResponseModel<CreateMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMalwareWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建木马白名单
        /// </summary>
        /// <param name="req"><see cref="CreateMalwareWhiteListRequest"/></param>
        /// <returns><see cref="CreateMalwareWhiteListResponse"/></returns>
        public CreateMalwareWhiteListResponse CreateMalwareWhiteListSync(CreateMalwareWhiteListRequest req)
        {
             JsonResponseModel<CreateMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMalwareWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建网络攻击白名单
        /// </summary>
        /// <param name="req"><see cref="CreateNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="CreateNetAttackWhiteListResponse"/></returns>
        public async Task<CreateNetAttackWhiteListResponse> CreateNetAttackWhiteList(CreateNetAttackWhiteListRequest req)
        {
             JsonResponseModel<CreateNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetAttackWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建网络攻击白名单
        /// </summary>
        /// <param name="req"><see cref="CreateNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="CreateNetAttackWhiteListResponse"/></returns>
        public CreateNetAttackWhiteListResponse CreateNetAttackWhiteListSync(CreateNetAttackWhiteListRequest req)
        {
             JsonResponseModel<CreateNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetAttackWhiteListResponse>>(strResp);
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
        /// 创建或修改防勒索策略
        /// </summary>
        /// <param name="req"><see cref="CreateRansomDefenseStrategyRequest"/></param>
        /// <returns><see cref="CreateRansomDefenseStrategyResponse"/></returns>
        public async Task<CreateRansomDefenseStrategyResponse> CreateRansomDefenseStrategy(CreateRansomDefenseStrategyRequest req)
        {
             JsonResponseModel<CreateRansomDefenseStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRansomDefenseStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRansomDefenseStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或修改防勒索策略
        /// </summary>
        /// <param name="req"><see cref="CreateRansomDefenseStrategyRequest"/></param>
        /// <returns><see cref="CreateRansomDefenseStrategyResponse"/></returns>
        public CreateRansomDefenseStrategyResponse CreateRansomDefenseStrategySync(CreateRansomDefenseStrategyRequest req)
        {
             JsonResponseModel<CreateRansomDefenseStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRansomDefenseStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRansomDefenseStrategyResponse>>(strResp);
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
        /// 提交漏洞修护
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRequest"/></param>
        /// <returns><see cref="CreateVulFixResponse"/></returns>
        public async Task<CreateVulFixResponse> CreateVulFix(CreateVulFixRequest req)
        {
             JsonResponseModel<CreateVulFixResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulFix");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulFixResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交漏洞修护
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRequest"/></param>
        /// <returns><see cref="CreateVulFixResponse"/></returns>
        public CreateVulFixResponse CreateVulFixSync(CreateVulFixRequest req)
        {
             JsonResponseModel<CreateVulFixResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVulFix");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulFixResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以创建白名单订单
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteListOrderRequest"/></param>
        /// <returns><see cref="CreateWhiteListOrderResponse"/></returns>
        public async Task<CreateWhiteListOrderResponse> CreateWhiteListOrder(CreateWhiteListOrderRequest req)
        {
             JsonResponseModel<CreateWhiteListOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWhiteListOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhiteListOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以创建白名单订单
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteListOrderRequest"/></param>
        /// <returns><see cref="CreateWhiteListOrderResponse"/></returns>
        public CreateWhiteListOrderResponse CreateWhiteListOrderSync(CreateWhiteListOrderRequest req)
        {
             JsonResponseModel<CreateWhiteListOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWhiteListOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhiteListOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部java内存马事件
        /// </summary>
        /// <param name="req"><see cref="DeleteAllJavaMemShellsRequest"/></param>
        /// <returns><see cref="DeleteAllJavaMemShellsResponse"/></returns>
        public async Task<DeleteAllJavaMemShellsResponse> DeleteAllJavaMemShells(DeleteAllJavaMemShellsRequest req)
        {
             JsonResponseModel<DeleteAllJavaMemShellsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAllJavaMemShells");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllJavaMemShellsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部java内存马事件
        /// </summary>
        /// <param name="req"><see cref="DeleteAllJavaMemShellsRequest"/></param>
        /// <returns><see cref="DeleteAllJavaMemShellsResponse"/></returns>
        public DeleteAllJavaMemShellsResponse DeleteAllJavaMemShellsSync(DeleteAllJavaMemShellsRequest req)
        {
             JsonResponseModel<DeleteAllJavaMemShellsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAllJavaMemShells");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllJavaMemShellsResponse>>(strResp);
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
        /// 删除阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="DeleteBanWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBanWhiteListResponse"/></returns>
        public async Task<DeleteBanWhiteListResponse> DeleteBanWhiteList(DeleteBanWhiteListRequest req)
        {
             JsonResponseModel<DeleteBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBanWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="DeleteBanWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBanWhiteListResponse"/></returns>
        public DeleteBanWhiteListResponse DeleteBanWhiteListSync(DeleteBanWhiteListRequest req)
        {
             JsonResponseModel<DeleteBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBanWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除基线策略配置
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselinePolicyRequest"/></param>
        /// <returns><see cref="DeleteBaselinePolicyResponse"/></returns>
        public async Task<DeleteBaselinePolicyResponse> DeleteBaselinePolicy(DeleteBaselinePolicyRequest req)
        {
             JsonResponseModel<DeleteBaselinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBaselinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除基线策略配置
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselinePolicyRequest"/></param>
        /// <returns><see cref="DeleteBaselinePolicyResponse"/></returns>
        public DeleteBaselinePolicyResponse DeleteBaselinePolicySync(DeleteBaselinePolicyRequest req)
        {
             JsonResponseModel<DeleteBaselinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBaselinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除基线规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineRuleRequest"/></param>
        /// <returns><see cref="DeleteBaselineRuleResponse"/></returns>
        public async Task<DeleteBaselineRuleResponse> DeleteBaselineRule(DeleteBaselineRuleRequest req)
        {
             JsonResponseModel<DeleteBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除基线规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineRuleRequest"/></param>
        /// <returns><see cref="DeleteBaselineRuleResponse"/></returns>
        public DeleteBaselineRuleResponse DeleteBaselineRuleSync(DeleteBaselineRuleRequest req)
        {
             JsonResponseModel<DeleteBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除基线忽略规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineRuleIgnoreRequest"/></param>
        /// <returns><see cref="DeleteBaselineRuleIgnoreResponse"/></returns>
        public async Task<DeleteBaselineRuleIgnoreResponse> DeleteBaselineRuleIgnore(DeleteBaselineRuleIgnoreRequest req)
        {
             JsonResponseModel<DeleteBaselineRuleIgnoreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBaselineRuleIgnore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineRuleIgnoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除基线忽略规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineRuleIgnoreRequest"/></param>
        /// <returns><see cref="DeleteBaselineRuleIgnoreResponse"/></returns>
        public DeleteBaselineRuleIgnoreResponse DeleteBaselineRuleIgnoreSync(DeleteBaselineRuleIgnoreRequest req)
        {
             JsonResponseModel<DeleteBaselineRuleIgnoreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBaselineRuleIgnore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineRuleIgnoreResponse>>(strResp);
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
        /// 删除基线弱口令
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineWeakPasswordRequest"/></param>
        /// <returns><see cref="DeleteBaselineWeakPasswordResponse"/></returns>
        public async Task<DeleteBaselineWeakPasswordResponse> DeleteBaselineWeakPassword(DeleteBaselineWeakPasswordRequest req)
        {
             JsonResponseModel<DeleteBaselineWeakPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBaselineWeakPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineWeakPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除基线弱口令
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineWeakPasswordRequest"/></param>
        /// <returns><see cref="DeleteBaselineWeakPasswordResponse"/></returns>
        public DeleteBaselineWeakPasswordResponse DeleteBaselineWeakPasswordSync(DeleteBaselineWeakPasswordRequest req)
        {
             JsonResponseModel<DeleteBaselineWeakPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBaselineWeakPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaselineWeakPasswordResponse>>(strResp);
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
        /// 删除高危命令策略
        /// </summary>
        /// <param name="req"><see cref="DeleteBashPoliciesRequest"/></param>
        /// <returns><see cref="DeleteBashPoliciesResponse"/></returns>
        public async Task<DeleteBashPoliciesResponse> DeleteBashPolicies(DeleteBashPoliciesRequest req)
        {
             JsonResponseModel<DeleteBashPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBashPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBashPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除高危命令策略
        /// </summary>
        /// <param name="req"><see cref="DeleteBashPoliciesRequest"/></param>
        /// <returns><see cref="DeleteBashPoliciesResponse"/></returns>
        public DeleteBashPoliciesResponse DeleteBashPoliciesSync(DeleteBashPoliciesRequest req)
        {
             JsonResponseModel<DeleteBashPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBashPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBashPoliciesResponse>>(strResp);
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
        /// 对授权管理-订单列表内已过期的订单进行删除.(删除后的订单不在统计范畴内)
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordResponse"/></returns>
        public async Task<DeleteLicenseRecordResponse> DeleteLicenseRecord(DeleteLicenseRecordRequest req)
        {
             JsonResponseModel<DeleteLicenseRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLicenseRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLicenseRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对授权管理-订单列表内已过期的订单进行删除.(删除后的订单不在统计范畴内)
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordResponse"/></returns>
        public DeleteLicenseRecordResponse DeleteLicenseRecordSync(DeleteLicenseRecordRequest req)
        {
             JsonResponseModel<DeleteLicenseRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLicenseRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLicenseRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除授权全部记录
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordAllRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordAllResponse"/></returns>
        public async Task<DeleteLicenseRecordAllResponse> DeleteLicenseRecordAll(DeleteLicenseRecordAllRequest req)
        {
             JsonResponseModel<DeleteLicenseRecordAllResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLicenseRecordAll");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLicenseRecordAllResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除授权全部记录
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordAllRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordAllResponse"/></returns>
        public DeleteLicenseRecordAllResponse DeleteLicenseRecordAllSync(DeleteLicenseRecordAllRequest req)
        {
             JsonResponseModel<DeleteLicenseRecordAllResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLicenseRecordAll");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLicenseRecordAllResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除日志下载任务
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public async Task<DeleteLogExportResponse> DeleteLogExport(DeleteLogExportRequest req)
        {
             JsonResponseModel<DeleteLogExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除日志下载任务
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public DeleteLogExportResponse DeleteLogExportSync(DeleteLogExportRequest req)
        {
             JsonResponseModel<DeleteLogExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogExportResponse>>(strResp);
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
        /// 本接口（DeleteMachine）用于卸载主机安全客户端。
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
        /// 本接口（DeleteMachine）用于卸载主机安全客户端。
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
        /// 删除机器清理记录
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DeleteMachineClearHistoryResponse"/></returns>
        public async Task<DeleteMachineClearHistoryResponse> DeleteMachineClearHistory(DeleteMachineClearHistoryRequest req)
        {
             JsonResponseModel<DeleteMachineClearHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachineClearHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineClearHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除机器清理记录
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DeleteMachineClearHistoryResponse"/></returns>
        public DeleteMachineClearHistoryResponse DeleteMachineClearHistorySync(DeleteMachineClearHistoryRequest req)
        {
             JsonResponseModel<DeleteMachineClearHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMachineClearHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineClearHistoryResponse>>(strResp);
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
        /// 删除恶意请求白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestWhiteListResponse"/></returns>
        public async Task<DeleteMaliciousRequestWhiteListResponse> DeleteMaliciousRequestWhiteList(DeleteMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<DeleteMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMaliciousRequestWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除恶意请求白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestWhiteListResponse"/></returns>
        public DeleteMaliciousRequestWhiteListResponse DeleteMaliciousRequestWhiteListSync(DeleteMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<DeleteMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMaliciousRequestWhiteListResponse>>(strResp);
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
        /// 删除木马白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMalwareWhiteListResponse"/></returns>
        public async Task<DeleteMalwareWhiteListResponse> DeleteMalwareWhiteList(DeleteMalwareWhiteListRequest req)
        {
             JsonResponseModel<DeleteMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMalwareWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除木马白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMalwareWhiteListResponse"/></returns>
        public DeleteMalwareWhiteListResponse DeleteMalwareWhiteListSync(DeleteMalwareWhiteListRequest req)
        {
             JsonResponseModel<DeleteMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMalwareWhiteListResponse>>(strResp);
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
        /// 删除网络攻击白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DeleteNetAttackWhiteListResponse"/></returns>
        public async Task<DeleteNetAttackWhiteListResponse> DeleteNetAttackWhiteList(DeleteNetAttackWhiteListRequest req)
        {
             JsonResponseModel<DeleteNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetAttackWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除网络攻击白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DeleteNetAttackWhiteListResponse"/></returns>
        public DeleteNetAttackWhiteListResponse DeleteNetAttackWhiteListSync(DeleteNetAttackWhiteListRequest req)
        {
             JsonResponseModel<DeleteNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetAttackWhiteListResponse>>(strResp);
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
        /// 删除恶意请求事件
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsEventRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsEventResponse"/></returns>
        public async Task<DeleteRiskDnsEventResponse> DeleteRiskDnsEvent(DeleteRiskDnsEventRequest req)
        {
             JsonResponseModel<DeleteRiskDnsEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRiskDnsEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskDnsEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除恶意请求事件
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsEventRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsEventResponse"/></returns>
        public DeleteRiskDnsEventResponse DeleteRiskDnsEventSync(DeleteRiskDnsEventRequest req)
        {
             JsonResponseModel<DeleteRiskDnsEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRiskDnsEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskDnsEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除恶意请求策略
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsPolicyResponse"/></returns>
        public async Task<DeleteRiskDnsPolicyResponse> DeleteRiskDnsPolicy(DeleteRiskDnsPolicyRequest req)
        {
             JsonResponseModel<DeleteRiskDnsPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRiskDnsPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskDnsPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除恶意请求策略
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsPolicyResponse"/></returns>
        public DeleteRiskDnsPolicyResponse DeleteRiskDnsPolicySync(DeleteRiskDnsPolicyRequest req)
        {
             JsonResponseModel<DeleteRiskDnsPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRiskDnsPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskDnsPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteScanTask 该接口可以对指定类型的扫描任务进行停止扫描;
        /// </summary>
        /// <param name="req"><see cref="DeleteScanTaskRequest"/></param>
        /// <returns><see cref="DeleteScanTaskResponse"/></returns>
        public async Task<DeleteScanTaskResponse> DeleteScanTask(DeleteScanTaskRequest req)
        {
             JsonResponseModel<DeleteScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteScanTask 该接口可以对指定类型的扫描任务进行停止扫描;
        /// </summary>
        /// <param name="req"><see cref="DeleteScanTaskRequest"/></param>
        /// <returns><see cref="DeleteScanTaskResponse"/></returns>
        public DeleteScanTaskResponse DeleteScanTaskSync(DeleteScanTaskRequest req)
        {
             JsonResponseModel<DeleteScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScanTaskResponse>>(strResp);
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
        /// 删除告警策略
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookPolicyRequest"/></param>
        /// <returns><see cref="DeleteWebHookPolicyResponse"/></returns>
        public async Task<DeleteWebHookPolicyResponse> DeleteWebHookPolicy(DeleteWebHookPolicyRequest req)
        {
             JsonResponseModel<DeleteWebHookPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWebHookPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebHookPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警策略
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookPolicyRequest"/></param>
        /// <returns><see cref="DeleteWebHookPolicyResponse"/></returns>
        public DeleteWebHookPolicyResponse DeleteWebHookPolicySync(DeleteWebHookPolicyRequest req)
        {
             JsonResponseModel<DeleteWebHookPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWebHookPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebHookPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警接收人
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookReceiverRequest"/></param>
        /// <returns><see cref="DeleteWebHookReceiverResponse"/></returns>
        public async Task<DeleteWebHookReceiverResponse> DeleteWebHookReceiver(DeleteWebHookReceiverRequest req)
        {
             JsonResponseModel<DeleteWebHookReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWebHookReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebHookReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警接收人
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookReceiverRequest"/></param>
        /// <returns><see cref="DeleteWebHookReceiverResponse"/></returns>
        public DeleteWebHookReceiverResponse DeleteWebHookReceiverSync(DeleteWebHookReceiverRequest req)
        {
             JsonResponseModel<DeleteWebHookReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWebHookReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebHookReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除企微机器人规则
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookRuleRequest"/></param>
        /// <returns><see cref="DeleteWebHookRuleResponse"/></returns>
        public async Task<DeleteWebHookRuleResponse> DeleteWebHookRule(DeleteWebHookRuleRequest req)
        {
             JsonResponseModel<DeleteWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebHookRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除企微机器人规则
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookRuleRequest"/></param>
        /// <returns><see cref="DeleteWebHookRuleResponse"/></returns>
        public DeleteWebHookRuleResponse DeleteWebHookRuleSync(DeleteWebHookRuleRequest req)
        {
             JsonResponseModel<DeleteWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWebHookRuleResponse>>(strResp);
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
        /// 获取用户当前灰度配置
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public async Task<DescribeABTestConfigResponse> DescribeABTestConfig(DescribeABTestConfigRequest req)
        {
             JsonResponseModel<DescribeABTestConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeABTestConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeABTestConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户当前灰度配置
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public DescribeABTestConfigResponse DescribeABTestConfigSync(DescribeABTestConfigRequest req)
        {
             JsonResponseModel<DescribeABTestConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeABTestConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeABTestConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取配置的aeskey和aesiv
        /// </summary>
        /// <param name="req"><see cref="DescribeAESKeyRequest"/></param>
        /// <returns><see cref="DescribeAESKeyResponse"/></returns>
        public async Task<DescribeAESKeyResponse> DescribeAESKey(DescribeAESKeyRequest req)
        {
             JsonResponseModel<DescribeAESKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAESKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAESKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取配置的aeskey和aesiv
        /// </summary>
        /// <param name="req"><see cref="DescribeAESKeyRequest"/></param>
        /// <returns><see cref="DescribeAESKeyResponse"/></returns>
        public DescribeAESKeyResponse DescribeAESKeySync(DescribeAESKeyRequest req)
        {
             JsonResponseModel<DescribeAESKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAESKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAESKeyResponse>>(strResp);
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
        /// 获取agent安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public async Task<DescribeAgentInstallCommandResponse> DescribeAgentInstallCommand(DescribeAgentInstallCommandRequest req)
        {
             JsonResponseModel<DescribeAgentInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentInstallCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取agent安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public DescribeAgentInstallCommandResponse DescribeAgentInstallCommandSync(DescribeAgentInstallCommandRequest req)
        {
             JsonResponseModel<DescribeAgentInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentInstallCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 混合云安装agent token获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallationTokenRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallationTokenResponse"/></returns>
        public async Task<DescribeAgentInstallationTokenResponse> DescribeAgentInstallationToken(DescribeAgentInstallationTokenRequest req)
        {
             JsonResponseModel<DescribeAgentInstallationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentInstallationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentInstallationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 混合云安装agent token获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallationTokenRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallationTokenResponse"/></returns>
        public DescribeAgentInstallationTokenResponse DescribeAgentInstallationTokenSync(DescribeAgentInstallationTokenRequest req)
        {
             JsonResponseModel<DescribeAgentInstallationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentInstallationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentInstallationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警点所在事件的所有节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmIncidentNodesRequest"/></param>
        /// <returns><see cref="DescribeAlarmIncidentNodesResponse"/></returns>
        public async Task<DescribeAlarmIncidentNodesResponse> DescribeAlarmIncidentNodes(DescribeAlarmIncidentNodesRequest req)
        {
             JsonResponseModel<DescribeAlarmIncidentNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmIncidentNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmIncidentNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警点所在事件的所有节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmIncidentNodesRequest"/></param>
        /// <returns><see cref="DescribeAlarmIncidentNodesResponse"/></returns>
        public DescribeAlarmIncidentNodesResponse DescribeAlarmIncidentNodesSync(DescribeAlarmIncidentNodesRequest req)
        {
             JsonResponseModel<DescribeAlarmIncidentNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmIncidentNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmIncidentNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警点id列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmVertexIdRequest"/></param>
        /// <returns><see cref="DescribeAlarmVertexIdResponse"/></returns>
        public async Task<DescribeAlarmVertexIdResponse> DescribeAlarmVertexId(DescribeAlarmVertexIdRequest req)
        {
             JsonResponseModel<DescribeAlarmVertexIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmVertexId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmVertexIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警点id列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmVertexIdRequest"/></param>
        /// <returns><see cref="DescribeAlarmVertexIdResponse"/></returns>
        public DescribeAlarmVertexIdResponse DescribeAlarmVertexIdSync(DescribeAlarmVertexIdRequest req)
        {
             JsonResponseModel<DescribeAlarmVertexIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmVertexId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmVertexIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有软件应用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetAppCountResponse"/></returns>
        public async Task<DescribeAssetAppCountResponse> DescribeAssetAppCount(DescribeAssetAppCountRequest req)
        {
             JsonResponseModel<DescribeAssetAppCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetAppCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有软件应用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetAppCountResponse"/></returns>
        public DescribeAssetAppCountResponse DescribeAssetAppCountSync(DescribeAssetAppCountRequest req)
        {
             JsonResponseModel<DescribeAssetAppCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetAppCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppCountResponse>>(strResp);
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
        /// 获取所有数据库数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseCountRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseCountResponse"/></returns>
        public async Task<DescribeAssetDatabaseCountResponse> DescribeAssetDatabaseCount(DescribeAssetDatabaseCountRequest req)
        {
             JsonResponseModel<DescribeAssetDatabaseCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetDatabaseCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDatabaseCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有数据库数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseCountRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseCountResponse"/></returns>
        public DescribeAssetDatabaseCountResponse DescribeAssetDatabaseCountSync(DescribeAssetDatabaseCountRequest req)
        {
             JsonResponseModel<DescribeAssetDatabaseCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetDatabaseCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDatabaseCountResponse>>(strResp);
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
        /// 获取主机磁盘分区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetDiskListResponse"/></returns>
        public async Task<DescribeAssetDiskListResponse> DescribeAssetDiskList(DescribeAssetDiskListRequest req)
        {
             JsonResponseModel<DescribeAssetDiskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetDiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDiskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机磁盘分区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetDiskListResponse"/></returns>
        public DescribeAssetDiskListResponse DescribeAssetDiskListSync(DescribeAssetDiskListRequest req)
        {
             JsonResponseModel<DescribeAssetDiskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetDiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDiskListResponse>>(strResp);
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
        /// 获取主机所有资源数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetHostTotalCountResponse"/></returns>
        public async Task<DescribeAssetHostTotalCountResponse> DescribeAssetHostTotalCount(DescribeAssetHostTotalCountRequest req)
        {
             JsonResponseModel<DescribeAssetHostTotalCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetHostTotalCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetHostTotalCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机所有资源数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetHostTotalCountResponse"/></returns>
        public DescribeAssetHostTotalCountResponse DescribeAssetHostTotalCountSync(DescribeAssetHostTotalCountRequest req)
        {
             JsonResponseModel<DescribeAssetHostTotalCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetHostTotalCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetHostTotalCountResponse>>(strResp);
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
        /// 获取系统负载、内存使用率、硬盘使用率情况
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLoadInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetLoadInfoResponse"/></returns>
        public async Task<DescribeAssetLoadInfoResponse> DescribeAssetLoadInfo(DescribeAssetLoadInfoRequest req)
        {
             JsonResponseModel<DescribeAssetLoadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetLoadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetLoadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取系统负载、内存使用率、硬盘使用率情况
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLoadInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetLoadInfoResponse"/></returns>
        public DescribeAssetLoadInfoResponse DescribeAssetLoadInfoSync(DescribeAssetLoadInfoRequest req)
        {
             JsonResponseModel<DescribeAssetLoadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetLoadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetLoadInfoResponse>>(strResp);
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
        /// 获取主机标签Top5
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineTagTopRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineTagTopResponse"/></returns>
        public async Task<DescribeAssetMachineTagTopResponse> DescribeAssetMachineTagTop(DescribeAssetMachineTagTopRequest req)
        {
             JsonResponseModel<DescribeAssetMachineTagTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetMachineTagTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetMachineTagTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机标签Top5
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineTagTopRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineTagTopResponse"/></returns>
        public DescribeAssetMachineTagTopResponse DescribeAssetMachineTagTopSync(DescribeAssetMachineTagTopRequest req)
        {
             JsonResponseModel<DescribeAssetMachineTagTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetMachineTagTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetMachineTagTopResponse>>(strResp);
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
        /// 获取所有端口数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortCountRequest"/></param>
        /// <returns><see cref="DescribeAssetPortCountResponse"/></returns>
        public async Task<DescribeAssetPortCountResponse> DescribeAssetPortCount(DescribeAssetPortCountRequest req)
        {
             JsonResponseModel<DescribeAssetPortCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetPortCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPortCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有端口数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortCountRequest"/></param>
        /// <returns><see cref="DescribeAssetPortCountResponse"/></returns>
        public DescribeAssetPortCountResponse DescribeAssetPortCountSync(DescribeAssetPortCountRequest req)
        {
             JsonResponseModel<DescribeAssetPortCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetPortCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPortCountResponse>>(strResp);
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
        /// 获取所有进程数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessCountRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessCountResponse"/></returns>
        public async Task<DescribeAssetProcessCountResponse> DescribeAssetProcessCount(DescribeAssetProcessCountRequest req)
        {
             JsonResponseModel<DescribeAssetProcessCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetProcessCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetProcessCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有进程数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessCountRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessCountResponse"/></returns>
        public DescribeAssetProcessCountResponse DescribeAssetProcessCountSync(DescribeAssetProcessCountRequest req)
        {
             JsonResponseModel<DescribeAssetProcessCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetProcessCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetProcessCountResponse>>(strResp);
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
        /// 获取所有资源数量：主机、账号、端口、进程、软件、数据库、Web应用、Web框架、Web服务、Web站点
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetTotalCountResponse"/></returns>
        public async Task<DescribeAssetTotalCountResponse> DescribeAssetTotalCount(DescribeAssetTotalCountRequest req)
        {
             JsonResponseModel<DescribeAssetTotalCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetTotalCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetTotalCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有资源数量：主机、账号、端口、进程、软件、数据库、Web应用、Web框架、Web服务、Web站点
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetTotalCountResponse"/></returns>
        public DescribeAssetTotalCountResponse DescribeAssetTotalCountSync(DescribeAssetTotalCountRequest req)
        {
             JsonResponseModel<DescribeAssetTotalCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetTotalCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetTotalCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各种类型资源Top5
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypeTopRequest"/></param>
        /// <returns><see cref="DescribeAssetTypeTopResponse"/></returns>
        public async Task<DescribeAssetTypeTopResponse> DescribeAssetTypeTop(DescribeAssetTypeTopRequest req)
        {
             JsonResponseModel<DescribeAssetTypeTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetTypeTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetTypeTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各种类型资源Top5
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypeTopRequest"/></param>
        /// <returns><see cref="DescribeAssetTypeTopResponse"/></returns>
        public DescribeAssetTypeTopResponse DescribeAssetTypeTopSync(DescribeAssetTypeTopRequest req)
        {
             JsonResponseModel<DescribeAssetTypeTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetTypeTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetTypeTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产指纹类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypesRequest"/></param>
        /// <returns><see cref="DescribeAssetTypesResponse"/></returns>
        public async Task<DescribeAssetTypesResponse> DescribeAssetTypes(DescribeAssetTypesRequest req)
        {
             JsonResponseModel<DescribeAssetTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产指纹类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypesRequest"/></param>
        /// <returns><see cref="DescribeAssetTypesResponse"/></returns>
        public DescribeAssetTypesResponse DescribeAssetTypesSync(DescribeAssetTypesRequest req)
        {
             JsonResponseModel<DescribeAssetTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有账号数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserCountRequest"/></param>
        /// <returns><see cref="DescribeAssetUserCountResponse"/></returns>
        public async Task<DescribeAssetUserCountResponse> DescribeAssetUserCount(DescribeAssetUserCountRequest req)
        {
             JsonResponseModel<DescribeAssetUserCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetUserCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有账号数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserCountRequest"/></param>
        /// <returns><see cref="DescribeAssetUserCountResponse"/></returns>
        public DescribeAssetUserCountResponse DescribeAssetUserCountSync(DescribeAssetUserCountRequest req)
        {
             JsonResponseModel<DescribeAssetUserCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetUserCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserCountResponse>>(strResp);
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
        /// 获取主机账号Key列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserKeyListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserKeyListResponse"/></returns>
        public async Task<DescribeAssetUserKeyListResponse> DescribeAssetUserKeyList(DescribeAssetUserKeyListRequest req)
        {
             JsonResponseModel<DescribeAssetUserKeyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetUserKeyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserKeyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机账号Key列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserKeyListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserKeyListResponse"/></returns>
        public DescribeAssetUserKeyListResponse DescribeAssetUserKeyListSync(DescribeAssetUserKeyListRequest req)
        {
             JsonResponseModel<DescribeAssetUserKeyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetUserKeyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetUserKeyListResponse>>(strResp);
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
        /// 获取所有Web应用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppCountResponse"/></returns>
        public async Task<DescribeAssetWebAppCountResponse> DescribeAssetWebAppCount(DescribeAssetWebAppCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebAppCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebAppCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebAppCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有Web应用数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppCountResponse"/></returns>
        public DescribeAssetWebAppCountResponse DescribeAssetWebAppCountSync(DescribeAssetWebAppCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebAppCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebAppCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebAppCountResponse>>(strResp);
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
        /// 获取所有Web框架数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameCountResponse"/></returns>
        public async Task<DescribeAssetWebFrameCountResponse> DescribeAssetWebFrameCount(DescribeAssetWebFrameCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebFrameCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebFrameCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebFrameCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有Web框架数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameCountResponse"/></returns>
        public DescribeAssetWebFrameCountResponse DescribeAssetWebFrameCountSync(DescribeAssetWebFrameCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebFrameCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebFrameCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebFrameCountResponse>>(strResp);
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
        /// 获取所有Web站点数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationCountResponse"/></returns>
        public async Task<DescribeAssetWebLocationCountResponse> DescribeAssetWebLocationCount(DescribeAssetWebLocationCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebLocationCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有Web站点数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationCountResponse"/></returns>
        public DescribeAssetWebLocationCountResponse DescribeAssetWebLocationCountSync(DescribeAssetWebLocationCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebLocationCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationCountResponse>>(strResp);
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
        /// 获取Web站点虚拟目录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationPathListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationPathListResponse"/></returns>
        public async Task<DescribeAssetWebLocationPathListResponse> DescribeAssetWebLocationPathList(DescribeAssetWebLocationPathListRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationPathListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebLocationPathList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationPathListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Web站点虚拟目录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationPathListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationPathListResponse"/></returns>
        public DescribeAssetWebLocationPathListResponse DescribeAssetWebLocationPathListSync(DescribeAssetWebLocationPathListRequest req)
        {
             JsonResponseModel<DescribeAssetWebLocationPathListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebLocationPathList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebLocationPathListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有Web服务数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceCountResponse"/></returns>
        public async Task<DescribeAssetWebServiceCountResponse> DescribeAssetWebServiceCount(DescribeAssetWebServiceCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebServiceCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有Web服务数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceCountResponse"/></returns>
        public DescribeAssetWebServiceCountResponse DescribeAssetWebServiceCountSync(DescribeAssetWebServiceCountRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebServiceCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceCountResponse>>(strResp);
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
        /// 网络攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackEventInfoResponse"/></returns>
        public async Task<DescribeAttackEventInfoResponse> DescribeAttackEventInfo(DescribeAttackEventInfoRequest req)
        {
             JsonResponseModel<DescribeAttackEventInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackEventInfoResponse"/></returns>
        public DescribeAttackEventInfoResponse DescribeAttackEventInfoSync(DescribeAttackEventInfoRequest req)
        {
             JsonResponseModel<DescribeAttackEventInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按分页形式展示网络攻击检测事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackEventsResponse"/></returns>
        public async Task<DescribeAttackEventsResponse> DescribeAttackEvents(DescribeAttackEventsRequest req)
        {
             JsonResponseModel<DescribeAttackEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按分页形式展示网络攻击检测事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackEventsResponse"/></returns>
        public DescribeAttackEventsResponse DescribeAttackEventsSync(DescribeAttackEventsRequest req)
        {
             JsonResponseModel<DescribeAttackEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackEventsResponse>>(strResp);
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
        /// 查询攻击溯源
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceResponse"/></returns>
        public async Task<DescribeAttackSourceResponse> DescribeAttackSource(DescribeAttackSourceRequest req)
        {
             JsonResponseModel<DescribeAttackSourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询攻击溯源
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceResponse"/></returns>
        public DescribeAttackSourceResponse DescribeAttackSourceSync(DescribeAttackSourceRequest req)
        {
             JsonResponseModel<DescribeAttackSourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询攻击溯源事件
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceEventsResponse"/></returns>
        public async Task<DescribeAttackSourceEventsResponse> DescribeAttackSourceEvents(DescribeAttackSourceEventsRequest req)
        {
             JsonResponseModel<DescribeAttackSourceEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackSourceEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackSourceEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询攻击溯源事件
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceEventsResponse"/></returns>
        public DescribeAttackSourceEventsResponse DescribeAttackSourceEventsSync(DescribeAttackSourceEventsRequest req)
        {
             JsonResponseModel<DescribeAttackSourceEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackSourceEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackSourceEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击数据统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAttackStatisticsResponse"/></returns>
        public async Task<DescribeAttackStatisticsResponse> DescribeAttackStatistics(DescribeAttackStatisticsRequest req)
        {
             JsonResponseModel<DescribeAttackStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击数据统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAttackStatisticsResponse"/></returns>
        public DescribeAttackStatisticsResponse DescribeAttackStatisticsSync(DescribeAttackStatisticsRequest req)
        {
             JsonResponseModel<DescribeAttackStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击top5数据列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTopRequest"/></param>
        /// <returns><see cref="DescribeAttackTopResponse"/></returns>
        public async Task<DescribeAttackTopResponse> DescribeAttackTop(DescribeAttackTopRequest req)
        {
             JsonResponseModel<DescribeAttackTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击top5数据列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTopRequest"/></param>
        /// <returns><see cref="DescribeAttackTopResponse"/></returns>
        public DescribeAttackTopResponse DescribeAttackTopSync(DescribeAttackTopRequest req)
        {
             JsonResponseModel<DescribeAttackTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击趋势数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTrendsRequest"/></param>
        /// <returns><see cref="DescribeAttackTrendsResponse"/></returns>
        public async Task<DescribeAttackTrendsResponse> DescribeAttackTrends(DescribeAttackTrendsRequest req)
        {
             JsonResponseModel<DescribeAttackTrendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAttackTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 网络攻击趋势数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTrendsRequest"/></param>
        /// <returns><see cref="DescribeAttackTrendsResponse"/></returns>
        public DescribeAttackTrendsResponse DescribeAttackTrendsSync(DescribeAttackTrendsRequest req)
        {
             JsonResponseModel<DescribeAttackTrendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAttackTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAttackTrendsResponse>>(strResp);
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
        /// 查询基线默认策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDefaultStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDefaultStrategyListResponse"/></returns>
        public async Task<DescribeBaselineDefaultStrategyListResponse> DescribeBaselineDefaultStrategyList(DescribeBaselineDefaultStrategyListRequest req)
        {
             JsonResponseModel<DescribeBaselineDefaultStrategyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineDefaultStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDefaultStrategyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询基线默认策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDefaultStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDefaultStrategyListResponse"/></returns>
        public DescribeBaselineDefaultStrategyListResponse DescribeBaselineDefaultStrategyListSync(DescribeBaselineDefaultStrategyListRequest req)
        {
             JsonResponseModel<DescribeBaselineDefaultStrategyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineDefaultStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDefaultStrategyListResponse>>(strResp);
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
        /// 获取基线检测详情记录
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetectListResponse"/></returns>
        public async Task<DescribeBaselineDetectListResponse> DescribeBaselineDetectList(DescribeBaselineDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineDetectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测详情记录
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetectListResponse"/></returns>
        public DescribeBaselineDetectListResponse DescribeBaselineDetectListSync(DescribeBaselineDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineDetectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测概览
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetectOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetectOverviewResponse"/></returns>
        public async Task<DescribeBaselineDetectOverviewResponse> DescribeBaselineDetectOverview(DescribeBaselineDetectOverviewRequest req)
        {
             JsonResponseModel<DescribeBaselineDetectOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineDetectOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDetectOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测概览
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetectOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetectOverviewResponse"/></returns>
        public DescribeBaselineDetectOverviewResponse DescribeBaselineDetectOverviewSync(DescribeBaselineDetectOverviewRequest req)
        {
             JsonResponseModel<DescribeBaselineDetectOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineDetectOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDetectOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线下载列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDownloadListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDownloadListResponse"/></returns>
        public async Task<DescribeBaselineDownloadListResponse> DescribeBaselineDownloadList(DescribeBaselineDownloadListRequest req)
        {
             JsonResponseModel<DescribeBaselineDownloadListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineDownloadList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDownloadListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线下载列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDownloadListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDownloadListResponse"/></returns>
        public DescribeBaselineDownloadListResponse DescribeBaselineDownloadListSync(DescribeBaselineDownloadListRequest req)
        {
             JsonResponseModel<DescribeBaselineDownloadListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineDownloadList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineDownloadListResponse>>(strResp);
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
        /// 获取基线修复列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineFixListRequest"/></param>
        /// <returns><see cref="DescribeBaselineFixListResponse"/></returns>
        public async Task<DescribeBaselineFixListResponse> DescribeBaselineFixList(DescribeBaselineFixListRequest req)
        {
             JsonResponseModel<DescribeBaselineFixListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineFixList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineFixListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线修复列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineFixListRequest"/></param>
        /// <returns><see cref="DescribeBaselineFixListResponse"/></returns>
        public DescribeBaselineFixListResponse DescribeBaselineFixListSync(DescribeBaselineFixListRequest req)
        {
             JsonResponseModel<DescribeBaselineFixListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineFixList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineFixListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostDetectListResponse"/></returns>
        public async Task<DescribeBaselineHostDetectListResponse> DescribeBaselineHostDetectList(DescribeBaselineHostDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineHostDetectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineHostDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostDetectListResponse"/></returns>
        public DescribeBaselineHostDetectListResponse DescribeBaselineHostDetectListSync(DescribeBaselineHostDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineHostDetectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineHostDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取忽略规则主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostIgnoreListResponse"/></returns>
        public async Task<DescribeBaselineHostIgnoreListResponse> DescribeBaselineHostIgnoreList(DescribeBaselineHostIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBaselineHostIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineHostIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取忽略规则主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostIgnoreListResponse"/></returns>
        public DescribeBaselineHostIgnoreListResponse DescribeBaselineHostIgnoreListSync(DescribeBaselineHostIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBaselineHostIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineHostIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线服务器风险TOP5
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostRiskTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostRiskTopResponse"/></returns>
        public async Task<DescribeBaselineHostRiskTopResponse> DescribeBaselineHostRiskTop(DescribeBaselineHostRiskTopRequest req)
        {
             JsonResponseModel<DescribeBaselineHostRiskTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineHostRiskTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostRiskTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线服务器风险TOP5
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostRiskTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostRiskTopResponse"/></returns>
        public DescribeBaselineHostRiskTopResponse DescribeBaselineHostRiskTopSync(DescribeBaselineHostRiskTopRequest req)
        {
             JsonResponseModel<DescribeBaselineHostRiskTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineHostRiskTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineHostRiskTopResponse>>(strResp);
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
        /// 获取基线检测项的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemDetectListResponse"/></returns>
        public async Task<DescribeBaselineItemDetectListResponse> DescribeBaselineItemDetectList(DescribeBaselineItemDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineItemDetectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineItemDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测项的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemDetectListResponse"/></returns>
        public DescribeBaselineItemDetectListResponse DescribeBaselineItemDetectListSync(DescribeBaselineItemDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineItemDetectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineItemDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取忽略规则项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemIgnoreListResponse"/></returns>
        public async Task<DescribeBaselineItemIgnoreListResponse> DescribeBaselineItemIgnoreList(DescribeBaselineItemIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBaselineItemIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineItemIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取忽略规则项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemIgnoreListResponse"/></returns>
        public DescribeBaselineItemIgnoreListResponse DescribeBaselineItemIgnoreListSync(DescribeBaselineItemIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBaselineItemIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineItemIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemInfoRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemInfoResponse"/></returns>
        public async Task<DescribeBaselineItemInfoResponse> DescribeBaselineItemInfo(DescribeBaselineItemInfoRequest req)
        {
             JsonResponseModel<DescribeBaselineItemInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineItemInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测项信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemInfoRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemInfoResponse"/></returns>
        public DescribeBaselineItemInfoResponse DescribeBaselineItemInfoSync(DescribeBaselineItemInfoRequest req)
        {
             JsonResponseModel<DescribeBaselineItemInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineItemInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线项检测结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemListResponse"/></returns>
        public async Task<DescribeBaselineItemListResponse> DescribeBaselineItemList(DescribeBaselineItemListRequest req)
        {
             JsonResponseModel<DescribeBaselineItemListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线项检测结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemListResponse"/></returns>
        public DescribeBaselineItemListResponse DescribeBaselineItemListSync(DescribeBaselineItemListRequest req)
        {
             JsonResponseModel<DescribeBaselineItemListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测项TOP5
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemRiskTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemRiskTopResponse"/></returns>
        public async Task<DescribeBaselineItemRiskTopResponse> DescribeBaselineItemRiskTop(DescribeBaselineItemRiskTopRequest req)
        {
             JsonResponseModel<DescribeBaselineItemRiskTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineItemRiskTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemRiskTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线检测项TOP5
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemRiskTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemRiskTopResponse"/></returns>
        public DescribeBaselineItemRiskTopResponse DescribeBaselineItemRiskTopSync(DescribeBaselineItemRiskTopRequest req)
        {
             JsonResponseModel<DescribeBaselineItemRiskTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineItemRiskTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineItemRiskTopResponse>>(strResp);
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
        /// 获取基线策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public async Task<DescribeBaselinePolicyListResponse> DescribeBaselinePolicyList(DescribeBaselinePolicyListRequest req)
        {
             JsonResponseModel<DescribeBaselinePolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselinePolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselinePolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public DescribeBaselinePolicyListResponse DescribeBaselinePolicyListSync(DescribeBaselinePolicyListRequest req)
        {
             JsonResponseModel<DescribeBaselinePolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselinePolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselinePolicyListResponse>>(strResp);
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
        /// 获取基线分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleCategoryListResponse"/></returns>
        public async Task<DescribeBaselineRuleCategoryListResponse> DescribeBaselineRuleCategoryList(DescribeBaselineRuleCategoryListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleCategoryListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineRuleCategoryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleCategoryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleCategoryListResponse"/></returns>
        public DescribeBaselineRuleCategoryListResponse DescribeBaselineRuleCategoryListSync(DescribeBaselineRuleCategoryListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleCategoryListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineRuleCategoryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleCategoryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线规则检测列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleDetectListResponse"/></returns>
        public async Task<DescribeBaselineRuleDetectListResponse> DescribeBaselineRuleDetectList(DescribeBaselineRuleDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleDetectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineRuleDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线规则检测列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleDetectListResponse"/></returns>
        public DescribeBaselineRuleDetectListResponse DescribeBaselineRuleDetectListSync(DescribeBaselineRuleDetectListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleDetectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineRuleDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线忽略规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleIgnoreListResponse"/></returns>
        public async Task<DescribeBaselineRuleIgnoreListResponse> DescribeBaselineRuleIgnoreList(DescribeBaselineRuleIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineRuleIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线忽略规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleIgnoreListResponse"/></returns>
        public DescribeBaselineRuleIgnoreListResponse DescribeBaselineRuleIgnoreListSync(DescribeBaselineRuleIgnoreListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineRuleIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleListResponse"/></returns>
        public async Task<DescribeBaselineRuleListResponse> DescribeBaselineRuleList(DescribeBaselineRuleListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleListRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleListResponse"/></returns>
        public DescribeBaselineRuleListResponse DescribeBaselineRuleListSync(DescribeBaselineRuleListRequest req)
        {
             JsonResponseModel<DescribeBaselineRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineRuleListResponse>>(strResp);
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
        /// 获取基线弱口令列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineWeakPasswordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineWeakPasswordListResponse"/></returns>
        public async Task<DescribeBaselineWeakPasswordListResponse> DescribeBaselineWeakPasswordList(DescribeBaselineWeakPasswordListRequest req)
        {
             JsonResponseModel<DescribeBaselineWeakPasswordListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaselineWeakPasswordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineWeakPasswordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基线弱口令列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineWeakPasswordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineWeakPasswordListResponse"/></returns>
        public DescribeBaselineWeakPasswordListResponse DescribeBaselineWeakPasswordListSync(DescribeBaselineWeakPasswordListRequest req)
        {
             JsonResponseModel<DescribeBaselineWeakPasswordListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaselineWeakPasswordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaselineWeakPasswordListResponse>>(strResp);
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
        /// 查询高危命令事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoResponse"/></returns>
        public async Task<DescribeBashEventsInfoResponse> DescribeBashEventsInfo(DescribeBashEventsInfoRequest req)
        {
             JsonResponseModel<DescribeBashEventsInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBashEventsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询高危命令事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoResponse"/></returns>
        public DescribeBashEventsInfoResponse DescribeBashEventsInfoSync(DescribeBashEventsInfoRequest req)
        {
             JsonResponseModel<DescribeBashEventsInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBashEventsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询高危命令事件详情(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoNewResponse"/></returns>
        public async Task<DescribeBashEventsInfoNewResponse> DescribeBashEventsInfoNew(DescribeBashEventsInfoNewRequest req)
        {
             JsonResponseModel<DescribeBashEventsInfoNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBashEventsInfoNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsInfoNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询高危命令事件详情(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoNewResponse"/></returns>
        public DescribeBashEventsInfoNewResponse DescribeBashEventsInfoNewSync(DescribeBashEventsInfoNewRequest req)
        {
             JsonResponseModel<DescribeBashEventsInfoNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBashEventsInfoNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsInfoNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令列表(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsNewResponse"/></returns>
        public async Task<DescribeBashEventsNewResponse> DescribeBashEventsNew(DescribeBashEventsNewRequest req)
        {
             JsonResponseModel<DescribeBashEventsNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBashEventsNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令列表(新)
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsNewResponse"/></returns>
        public DescribeBashEventsNewResponse DescribeBashEventsNewSync(DescribeBashEventsNewRequest req)
        {
             JsonResponseModel<DescribeBashEventsNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBashEventsNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashEventsNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashPoliciesRequest"/></param>
        /// <returns><see cref="DescribeBashPoliciesResponse"/></returns>
        public async Task<DescribeBashPoliciesResponse> DescribeBashPolicies(DescribeBashPoliciesRequest req)
        {
             JsonResponseModel<DescribeBashPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBashPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高危命令策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashPoliciesRequest"/></param>
        /// <returns><see cref="DescribeBashPoliciesResponse"/></returns>
        public DescribeBashPoliciesResponse DescribeBashPoliciesSync(DescribeBashPoliciesRequest req)
        {
             JsonResponseModel<DescribeBashPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBashPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBashPoliciesResponse>>(strResp);
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
        /// 漏洞修护-查询可修护主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCanFixVulMachineRequest"/></param>
        /// <returns><see cref="DescribeCanFixVulMachineResponse"/></returns>
        public async Task<DescribeCanFixVulMachineResponse> DescribeCanFixVulMachine(DescribeCanFixVulMachineRequest req)
        {
             JsonResponseModel<DescribeCanFixVulMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCanFixVulMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCanFixVulMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞修护-查询可修护主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCanFixVulMachineRequest"/></param>
        /// <returns><see cref="DescribeCanFixVulMachineResponse"/></returns>
        public DescribeCanFixVulMachineResponse DescribeCanFixVulMachineSync(DescribeCanFixVulMachineRequest req)
        {
             JsonResponseModel<DescribeCanFixVulMachineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCanFixVulMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCanFixVulMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取木马不可隔离的主机
        /// </summary>
        /// <param name="req"><see cref="DescribeCanNotSeparateMachineRequest"/></param>
        /// <returns><see cref="DescribeCanNotSeparateMachineResponse"/></returns>
        public async Task<DescribeCanNotSeparateMachineResponse> DescribeCanNotSeparateMachine(DescribeCanNotSeparateMachineRequest req)
        {
             JsonResponseModel<DescribeCanNotSeparateMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCanNotSeparateMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCanNotSeparateMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取木马不可隔离的主机
        /// </summary>
        /// <param name="req"><see cref="DescribeCanNotSeparateMachineRequest"/></param>
        /// <returns><see cref="DescribeCanNotSeparateMachineResponse"/></returns>
        public DescribeCanNotSeparateMachineResponse DescribeCanNotSeparateMachineSync(DescribeCanNotSeparateMachineRequest req)
        {
             JsonResponseModel<DescribeCanNotSeparateMachineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCanNotSeparateMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCanNotSeparateMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取客户端异常事件
        /// </summary>
        /// <param name="req"><see cref="DescribeClientExceptionRequest"/></param>
        /// <returns><see cref="DescribeClientExceptionResponse"/></returns>
        public async Task<DescribeClientExceptionResponse> DescribeClientException(DescribeClientExceptionRequest req)
        {
             JsonResponseModel<DescribeClientExceptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClientException");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientExceptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取客户端异常事件
        /// </summary>
        /// <param name="req"><see cref="DescribeClientExceptionRequest"/></param>
        /// <returns><see cref="DescribeClientExceptionResponse"/></returns>
        public DescribeClientExceptionResponse DescribeClientExceptionSync(DescribeClientExceptionRequest req)
        {
             JsonResponseModel<DescribeClientExceptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClientException");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientExceptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云护航服务订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudProtectServiceOrderListRequest"/></param>
        /// <returns><see cref="DescribeCloudProtectServiceOrderListResponse"/></returns>
        public async Task<DescribeCloudProtectServiceOrderListResponse> DescribeCloudProtectServiceOrderList(DescribeCloudProtectServiceOrderListRequest req)
        {
             JsonResponseModel<DescribeCloudProtectServiceOrderListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudProtectServiceOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudProtectServiceOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云护航服务订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudProtectServiceOrderListRequest"/></param>
        /// <returns><see cref="DescribeCloudProtectServiceOrderListResponse"/></returns>
        public DescribeCloudProtectServiceOrderListResponse DescribeCloudProtectServiceOrderListSync(DescribeCloudProtectServiceOrderListRequest req)
        {
             JsonResponseModel<DescribeCloudProtectServiceOrderListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudProtectServiceOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudProtectServiceOrderListResponse>>(strResp);
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
        /// 获取漏洞防御事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDefenceEventDetailResponse"/></returns>
        public async Task<DescribeDefenceEventDetailResponse> DescribeDefenceEventDetail(DescribeDefenceEventDetailRequest req)
        {
             JsonResponseModel<DescribeDefenceEventDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefenceEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefenceEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞防御事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDefenceEventDetailResponse"/></returns>
        public DescribeDefenceEventDetailResponse DescribeDefenceEventDetailSync(DescribeDefenceEventDetailRequest req)
        {
             JsonResponseModel<DescribeDefenceEventDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefenceEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefenceEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取专线agent安装命令，包含token
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectInstallCommandResponse"/></returns>
        public async Task<DescribeDirectConnectInstallCommandResponse> DescribeDirectConnectInstallCommand(DescribeDirectConnectInstallCommandRequest req)
        {
             JsonResponseModel<DescribeDirectConnectInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectInstallCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取专线agent安装命令，包含token
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectInstallCommandResponse"/></returns>
        public DescribeDirectConnectInstallCommandResponse DescribeDirectConnectInstallCommandSync(DescribeDirectConnectInstallCommandRequest req)
        {
             JsonResponseModel<DescribeDirectConnectInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectInstallCommandResponse>>(strResp);
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
        /// 根据事件表名和id查询告警事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventByTableRequest"/></param>
        /// <returns><see cref="DescribeEventByTableResponse"/></returns>
        public async Task<DescribeEventByTableResponse> DescribeEventByTable(DescribeEventByTableRequest req)
        {
             JsonResponseModel<DescribeEventByTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEventByTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventByTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据事件表名和id查询告警事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEventByTableRequest"/></param>
        /// <returns><see cref="DescribeEventByTableResponse"/></returns>
        public DescribeEventByTableResponse DescribeEventByTableSync(DescribeEventByTableRequest req)
        {
             JsonResponseModel<DescribeEventByTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEventByTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventByTableResponse>>(strResp);
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
        /// 日志快速分析统计
        /// </summary>
        /// <param name="req"><see cref="DescribeFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeFastAnalysisResponse"/></returns>
        public async Task<DescribeFastAnalysisResponse> DescribeFastAnalysis(DescribeFastAnalysisRequest req)
        {
             JsonResponseModel<DescribeFastAnalysisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFastAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFastAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志快速分析统计
        /// </summary>
        /// <param name="req"><see cref="DescribeFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeFastAnalysisResponse"/></returns>
        public DescribeFastAnalysisResponse DescribeFastAnalysisSync(DescribeFastAnalysisRequest req)
        {
             JsonResponseModel<DescribeFastAnalysisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFastAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFastAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看产生事件时规则详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventRuleInfoResponse"/></returns>
        public async Task<DescribeFileTamperEventRuleInfoResponse> DescribeFileTamperEventRuleInfo(DescribeFileTamperEventRuleInfoRequest req)
        {
             JsonResponseModel<DescribeFileTamperEventRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileTamperEventRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperEventRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看产生事件时规则详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventRuleInfoResponse"/></returns>
        public DescribeFileTamperEventRuleInfoResponse DescribeFileTamperEventRuleInfoSync(DescribeFileTamperEventRuleInfoRequest req)
        {
             JsonResponseModel<DescribeFileTamperEventRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileTamperEventRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperEventRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件监控事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventsRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventsResponse"/></returns>
        public async Task<DescribeFileTamperEventsResponse> DescribeFileTamperEvents(DescribeFileTamperEventsRequest req)
        {
             JsonResponseModel<DescribeFileTamperEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileTamperEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件监控事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventsRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventsResponse"/></returns>
        public DescribeFileTamperEventsResponse DescribeFileTamperEventsSync(DescribeFileTamperEventsRequest req)
        {
             JsonResponseModel<DescribeFileTamperEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileTamperEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机关联文件监控规则数量
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleCountRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleCountResponse"/></returns>
        public async Task<DescribeFileTamperRuleCountResponse> DescribeFileTamperRuleCount(DescribeFileTamperRuleCountRequest req)
        {
             JsonResponseModel<DescribeFileTamperRuleCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileTamperRuleCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperRuleCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机关联文件监控规则数量
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleCountRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleCountResponse"/></returns>
        public DescribeFileTamperRuleCountResponse DescribeFileTamperRuleCountSync(DescribeFileTamperRuleCountRequest req)
        {
             JsonResponseModel<DescribeFileTamperRuleCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileTamperRuleCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperRuleCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个监控规则的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleInfoResponse"/></returns>
        public async Task<DescribeFileTamperRuleInfoResponse> DescribeFileTamperRuleInfo(DescribeFileTamperRuleInfoRequest req)
        {
             JsonResponseModel<DescribeFileTamperRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileTamperRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个监控规则的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleInfoResponse"/></returns>
        public DescribeFileTamperRuleInfoResponse DescribeFileTamperRuleInfoSync(DescribeFileTamperRuleInfoRequest req)
        {
             JsonResponseModel<DescribeFileTamperRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileTamperRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件监控规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRulesResponse"/></returns>
        public async Task<DescribeFileTamperRulesResponse> DescribeFileTamperRules(DescribeFileTamperRulesRequest req)
        {
             JsonResponseModel<DescribeFileTamperRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileTamperRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件监控规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRulesResponse"/></returns>
        public DescribeFileTamperRulesResponse DescribeFileTamperRulesSync(DescribeFileTamperRulesRequest req)
        {
             JsonResponseModel<DescribeFileTamperRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileTamperRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileTamperRulesResponse>>(strResp);
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
        /// 主机信息与标签信息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeHostInfoRequest"/></param>
        /// <returns><see cref="DescribeHostInfoResponse"/></returns>
        public async Task<DescribeHostInfoResponse> DescribeHostInfo(DescribeHostInfoRequest req)
        {
             JsonResponseModel<DescribeHostInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 主机信息与标签信息查询
        /// </summary>
        /// <param name="req"><see cref="DescribeHostInfoRequest"/></param>
        /// <returns><see cref="DescribeHostInfoResponse"/></returns>
        public DescribeHostInfoResponse DescribeHostInfoSync(DescribeHostInfoRequest req)
        {
             JsonResponseModel<DescribeHostInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostInfoResponse>>(strResp);
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
        /// 获取全网热点漏洞
        /// </summary>
        /// <param name="req"><see cref="DescribeHotVulTopRequest"/></param>
        /// <returns><see cref="DescribeHotVulTopResponse"/></returns>
        public async Task<DescribeHotVulTopResponse> DescribeHotVulTop(DescribeHotVulTopRequest req)
        {
             JsonResponseModel<DescribeHotVulTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHotVulTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHotVulTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取全网热点漏洞
        /// </summary>
        /// <param name="req"><see cref="DescribeHotVulTopRequest"/></param>
        /// <returns><see cref="DescribeHotVulTopResponse"/></returns>
        public DescribeHotVulTopResponse DescribeHotVulTopSync(DescribeHotVulTopRequest req)
        {
             JsonResponseModel<DescribeHotVulTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHotVulTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHotVulTopResponse>>(strResp);
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
        /// 获取一键忽略受影响的检测项和主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreHostAndItemConfigRequest"/></param>
        /// <returns><see cref="DescribeIgnoreHostAndItemConfigResponse"/></returns>
        public async Task<DescribeIgnoreHostAndItemConfigResponse> DescribeIgnoreHostAndItemConfig(DescribeIgnoreHostAndItemConfigRequest req)
        {
             JsonResponseModel<DescribeIgnoreHostAndItemConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIgnoreHostAndItemConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIgnoreHostAndItemConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取一键忽略受影响的检测项和主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreHostAndItemConfigRequest"/></param>
        /// <returns><see cref="DescribeIgnoreHostAndItemConfigResponse"/></returns>
        public DescribeIgnoreHostAndItemConfigResponse DescribeIgnoreHostAndItemConfigSync(DescribeIgnoreHostAndItemConfigRequest req)
        {
             JsonResponseModel<DescribeIgnoreHostAndItemConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIgnoreHostAndItemConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIgnoreHostAndItemConfigResponse>>(strResp);
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
        /// 查询java内存马事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellInfoResponse"/></returns>
        public async Task<DescribeJavaMemShellInfoResponse> DescribeJavaMemShellInfo(DescribeJavaMemShellInfoRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJavaMemShellInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询java内存马事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellInfoResponse"/></returns>
        public DescribeJavaMemShellInfoResponse DescribeJavaMemShellInfoSync(DescribeJavaMemShellInfoRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJavaMemShellInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询java内存马事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellListResponse"/></returns>
        public async Task<DescribeJavaMemShellListResponse> DescribeJavaMemShellList(DescribeJavaMemShellListRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJavaMemShellList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询java内存马事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellListResponse"/></returns>
        public DescribeJavaMemShellListResponse DescribeJavaMemShellListSync(DescribeJavaMemShellListRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJavaMemShellList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询给定主机java内存马插件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginInfoResponse"/></returns>
        public async Task<DescribeJavaMemShellPluginInfoResponse> DescribeJavaMemShellPluginInfo(DescribeJavaMemShellPluginInfoRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellPluginInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJavaMemShellPluginInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellPluginInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询给定主机java内存马插件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginInfoResponse"/></returns>
        public DescribeJavaMemShellPluginInfoResponse DescribeJavaMemShellPluginInfoSync(DescribeJavaMemShellPluginInfoRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellPluginInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJavaMemShellPluginInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellPluginInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询java内存马插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginListResponse"/></returns>
        public async Task<DescribeJavaMemShellPluginListResponse> DescribeJavaMemShellPluginList(DescribeJavaMemShellPluginListRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellPluginListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJavaMemShellPluginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellPluginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询java内存马插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginListResponse"/></returns>
        public DescribeJavaMemShellPluginListResponse DescribeJavaMemShellPluginListSync(DescribeJavaMemShellPluginListRequest req)
        {
             JsonResponseModel<DescribeJavaMemShellPluginListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJavaMemShellPluginList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJavaMemShellPluginListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询授权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseRequest"/></param>
        /// <returns><see cref="DescribeLicenseResponse"/></returns>
        public async Task<DescribeLicenseResponse> DescribeLicense(DescribeLicenseRequest req)
        {
             JsonResponseModel<DescribeLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询授权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseRequest"/></param>
        /// <returns><see cref="DescribeLicenseResponse"/></returns>
        public DescribeLicenseResponse DescribeLicenseSync(DescribeLicenseRequest req)
        {
             JsonResponseModel<DescribeLicenseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以获取设置中心-授权管理,某个授权下已绑定的授权机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindListRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindListResponse"/></returns>
        public async Task<DescribeLicenseBindListResponse> DescribeLicenseBindList(DescribeLicenseBindListRequest req)
        {
             JsonResponseModel<DescribeLicenseBindListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLicenseBindList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseBindListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口可以获取设置中心-授权管理,某个授权下已绑定的授权机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindListRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindListResponse"/></returns>
        public DescribeLicenseBindListResponse DescribeLicenseBindListSync(DescribeLicenseBindListRequest req)
        {
             JsonResponseModel<DescribeLicenseBindListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLicenseBindList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseBindListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询授权绑定任务的进度
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindScheduleResponse"/></returns>
        public async Task<DescribeLicenseBindScheduleResponse> DescribeLicenseBindSchedule(DescribeLicenseBindScheduleRequest req)
        {
             JsonResponseModel<DescribeLicenseBindScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLicenseBindSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseBindScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询授权绑定任务的进度
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindScheduleResponse"/></returns>
        public DescribeLicenseBindScheduleResponse DescribeLicenseBindScheduleSync(DescribeLicenseBindScheduleRequest req)
        {
             JsonResponseModel<DescribeLicenseBindScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLicenseBindSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseBindScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 授权管理-授权概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseGeneralRequest"/></param>
        /// <returns><see cref="DescribeLicenseGeneralResponse"/></returns>
        public async Task<DescribeLicenseGeneralResponse> DescribeLicenseGeneral(DescribeLicenseGeneralRequest req)
        {
             JsonResponseModel<DescribeLicenseGeneralResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLicenseGeneral");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseGeneralResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 授权管理-授权概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseGeneralRequest"/></param>
        /// <returns><see cref="DescribeLicenseGeneralResponse"/></returns>
        public DescribeLicenseGeneralResponse DescribeLicenseGeneralSync(DescribeLicenseGeneralRequest req)
        {
             JsonResponseModel<DescribeLicenseGeneralResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLicenseGeneral");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseGeneralResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户所有授权订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseListRequest"/></param>
        /// <returns><see cref="DescribeLicenseListResponse"/></returns>
        public async Task<DescribeLicenseListResponse> DescribeLicenseList(DescribeLicenseListRequest req)
        {
             JsonResponseModel<DescribeLicenseListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLicenseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户所有授权订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseListRequest"/></param>
        /// <returns><see cref="DescribeLicenseListResponse"/></returns>
        public DescribeLicenseListResponse DescribeLicenseListSync(DescribeLicenseListRequest req)
        {
             JsonResponseModel<DescribeLicenseListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLicenseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询授权白名单的可用配置
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseWhiteConfigRequest"/></param>
        /// <returns><see cref="DescribeLicenseWhiteConfigResponse"/></returns>
        public async Task<DescribeLicenseWhiteConfigResponse> DescribeLicenseWhiteConfig(DescribeLicenseWhiteConfigRequest req)
        {
             JsonResponseModel<DescribeLicenseWhiteConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLicenseWhiteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseWhiteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询授权白名单的可用配置
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseWhiteConfigRequest"/></param>
        /// <returns><see cref="DescribeLicenseWhiteConfigResponse"/></returns>
        public DescribeLicenseWhiteConfigResponse DescribeLicenseWhiteConfigSync(DescribeLicenseWhiteConfigRequest req)
        {
             JsonResponseModel<DescribeLicenseWhiteConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLicenseWhiteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLicenseWhiteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询日志投递kafka可选项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeLogDeliveryKafkaOptionsResponse"/></returns>
        public async Task<DescribeLogDeliveryKafkaOptionsResponse> DescribeLogDeliveryKafkaOptions(DescribeLogDeliveryKafkaOptionsRequest req)
        {
             JsonResponseModel<DescribeLogDeliveryKafkaOptionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogDeliveryKafkaOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogDeliveryKafkaOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询日志投递kafka可选项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeLogDeliveryKafkaOptionsResponse"/></returns>
        public DescribeLogDeliveryKafkaOptionsResponse DescribeLogDeliveryKafkaOptionsSync(DescribeLogDeliveryKafkaOptionsRequest req)
        {
             JsonResponseModel<DescribeLogDeliveryKafkaOptionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogDeliveryKafkaOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogDeliveryKafkaOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志下载任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public async Task<DescribeLogExportsResponse> DescribeLogExports(DescribeLogExportsRequest req)
        {
             JsonResponseModel<DescribeLogExportsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志下载任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public DescribeLogExportsResponse DescribeLogExportsSync(DescribeLogExportsRequest req)
        {
             JsonResponseModel<DescribeLogExportsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志直方图信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public async Task<DescribeLogHistogramResponse> DescribeLogHistogram(DescribeLogHistogramRequest req)
        {
             JsonResponseModel<DescribeLogHistogramResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogHistogramResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志直方图信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public DescribeLogHistogramResponse DescribeLogHistogramSync(DescribeLogHistogramRequest req)
        {
             JsonResponseModel<DescribeLogHistogramResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogHistogramResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询索引
        /// </summary>
        /// <param name="req"><see cref="DescribeLogIndexRequest"/></param>
        /// <returns><see cref="DescribeLogIndexResponse"/></returns>
        public async Task<DescribeLogIndexResponse> DescribeLogIndex(DescribeLogIndexRequest req)
        {
             JsonResponseModel<DescribeLogIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询索引
        /// </summary>
        /// <param name="req"><see cref="DescribeLogIndexRequest"/></param>
        /// <returns><see cref="DescribeLogIndexResponse"/></returns>
        public DescribeLogIndexResponse DescribeLogIndexSync(DescribeLogIndexRequest req)
        {
             JsonResponseModel<DescribeLogIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取kafka投递信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLogKafkaDeliverInfoRequest"/></param>
        /// <returns><see cref="DescribeLogKafkaDeliverInfoResponse"/></returns>
        public async Task<DescribeLogKafkaDeliverInfoResponse> DescribeLogKafkaDeliverInfo(DescribeLogKafkaDeliverInfoRequest req)
        {
             JsonResponseModel<DescribeLogKafkaDeliverInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogKafkaDeliverInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogKafkaDeliverInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取kafka投递信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLogKafkaDeliverInfoRequest"/></param>
        /// <returns><see cref="DescribeLogKafkaDeliverInfoResponse"/></returns>
        public DescribeLogKafkaDeliverInfoResponse DescribeLogKafkaDeliverInfoSync(DescribeLogKafkaDeliverInfoRequest req)
        {
             JsonResponseModel<DescribeLogKafkaDeliverInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogKafkaDeliverInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogKafkaDeliverInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志存储配置
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageConfigRequest"/></param>
        /// <returns><see cref="DescribeLogStorageConfigResponse"/></returns>
        public async Task<DescribeLogStorageConfigResponse> DescribeLogStorageConfig(DescribeLogStorageConfigRequest req)
        {
             JsonResponseModel<DescribeLogStorageConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogStorageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志存储配置
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageConfigRequest"/></param>
        /// <returns><see cref="DescribeLogStorageConfigResponse"/></returns>
        public DescribeLogStorageConfigResponse DescribeLogStorageConfigSync(DescribeLogStorageConfigRequest req)
        {
             JsonResponseModel<DescribeLogStorageConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogStorageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志存储量记录
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageRecordRequest"/></param>
        /// <returns><see cref="DescribeLogStorageRecordResponse"/></returns>
        public async Task<DescribeLogStorageRecordResponse> DescribeLogStorageRecord(DescribeLogStorageRecordRequest req)
        {
             JsonResponseModel<DescribeLogStorageRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogStorageRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志存储量记录
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageRecordRequest"/></param>
        /// <returns><see cref="DescribeLogStorageRecordResponse"/></returns>
        public DescribeLogStorageRecordResponse DescribeLogStorageRecordSync(DescribeLogStorageRecordRequest req)
        {
             JsonResponseModel<DescribeLogStorageRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogStorageRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageRecordResponse>>(strResp);
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
        /// 日志分析功能-获取日志类型，使用该接口返回的结果暂时可过滤的日志类型
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTypeRequest"/></param>
        /// <returns><see cref="DescribeLogTypeResponse"/></returns>
        public async Task<DescribeLogTypeResponse> DescribeLogType(DescribeLogTypeRequest req)
        {
             JsonResponseModel<DescribeLogTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 日志分析功能-获取日志类型，使用该接口返回的结果暂时可过滤的日志类型
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTypeRequest"/></param>
        /// <returns><see cref="DescribeLogTypeResponse"/></returns>
        public DescribeLogTypeResponse DescribeLogTypeSync(DescribeLogTypeRequest req)
        {
             JsonResponseModel<DescribeLogTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogTypeResponse>>(strResp);
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
        /// 查询合并后白名单机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteHostListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteHostListResponse"/></returns>
        public async Task<DescribeLoginWhiteHostListResponse> DescribeLoginWhiteHostList(DescribeLoginWhiteHostListRequest req)
        {
             JsonResponseModel<DescribeLoginWhiteHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoginWhiteHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginWhiteHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询合并后白名单机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteHostListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteHostListResponse"/></returns>
        public DescribeLoginWhiteHostListResponse DescribeLoginWhiteHostListSync(DescribeLoginWhiteHostListRequest req)
        {
             JsonResponseModel<DescribeLoginWhiteHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoginWhiteHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoginWhiteHostListResponse>>(strResp);
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
        /// 查询机器清理历史记录
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DescribeMachineClearHistoryResponse"/></returns>
        public async Task<DescribeMachineClearHistoryResponse> DescribeMachineClearHistory(DescribeMachineClearHistoryRequest req)
        {
             JsonResponseModel<DescribeMachineClearHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineClearHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineClearHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机器清理历史记录
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DescribeMachineClearHistoryResponse"/></returns>
        public DescribeMachineClearHistoryResponse DescribeMachineClearHistorySync(DescribeMachineClearHistoryRequest req)
        {
             JsonResponseModel<DescribeMachineClearHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineClearHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineClearHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机高级防御事件数统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineDefenseCntRequest"/></param>
        /// <returns><see cref="DescribeMachineDefenseCntResponse"/></returns>
        public async Task<DescribeMachineDefenseCntResponse> DescribeMachineDefenseCnt(DescribeMachineDefenseCntRequest req)
        {
             JsonResponseModel<DescribeMachineDefenseCntResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineDefenseCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineDefenseCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机高级防御事件数统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineDefenseCntRequest"/></param>
        /// <returns><see cref="DescribeMachineDefenseCntResponse"/></returns>
        public DescribeMachineDefenseCntResponse DescribeMachineDefenseCntSync(DescribeMachineDefenseCntRequest req)
        {
             JsonResponseModel<DescribeMachineDefenseCntResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineDefenseCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineDefenseCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机相关核心文件监控规则列 表   
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeMachineFileTamperRulesResponse"/></returns>
        public async Task<DescribeMachineFileTamperRulesResponse> DescribeMachineFileTamperRules(DescribeMachineFileTamperRulesRequest req)
        {
             JsonResponseModel<DescribeMachineFileTamperRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineFileTamperRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineFileTamperRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机相关核心文件监控规则列 表   
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeMachineFileTamperRulesResponse"/></returns>
        public DescribeMachineFileTamperRulesResponse DescribeMachineFileTamperRulesSync(DescribeMachineFileTamperRulesRequest req)
        {
             JsonResponseModel<DescribeMachineFileTamperRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineFileTamperRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineFileTamperRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGeneralRequest"/></param>
        /// <returns><see cref="DescribeMachineGeneralResponse"/></returns>
        public async Task<DescribeMachineGeneralResponse> DescribeMachineGeneral(DescribeMachineGeneralRequest req)
        {
             JsonResponseModel<DescribeMachineGeneralResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineGeneral");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGeneralResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGeneralRequest"/></param>
        /// <returns><see cref="DescribeMachineGeneralResponse"/></returns>
        public DescribeMachineGeneralResponse DescribeMachineGeneralSync(DescribeMachineGeneralRequest req)
        {
             JsonResponseModel<DescribeMachineGeneralResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineGeneral");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGeneralResponse>>(strResp);
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
        /// 本接口 (DescribeMachineLicenseDetail)查询机器授权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLicenseDetailRequest"/></param>
        /// <returns><see cref="DescribeMachineLicenseDetailResponse"/></returns>
        public async Task<DescribeMachineLicenseDetailResponse> DescribeMachineLicenseDetail(DescribeMachineLicenseDetailRequest req)
        {
             JsonResponseModel<DescribeMachineLicenseDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineLicenseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineLicenseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeMachineLicenseDetail)查询机器授权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLicenseDetailRequest"/></param>
        /// <returns><see cref="DescribeMachineLicenseDetailResponse"/></returns>
        public DescribeMachineLicenseDetailResponse DescribeMachineLicenseDetailSync(DescribeMachineLicenseDetailRequest req)
        {
             JsonResponseModel<DescribeMachineLicenseDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineLicenseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineLicenseDetailResponse>>(strResp);
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
        /// 查询主机地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionListRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionListResponse"/></returns>
        public async Task<DescribeMachineRegionListResponse> DescribeMachineRegionList(DescribeMachineRegionListRequest req)
        {
             JsonResponseModel<DescribeMachineRegionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineRegionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineRegionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionListRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionListResponse"/></returns>
        public DescribeMachineRegionListResponse DescribeMachineRegionListSync(DescribeMachineRegionListRequest req)
        {
             JsonResponseModel<DescribeMachineRegionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineRegionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineRegionListResponse>>(strResp);
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
        /// 查询主机入侵检测事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRiskCntRequest"/></param>
        /// <returns><see cref="DescribeMachineRiskCntResponse"/></returns>
        public async Task<DescribeMachineRiskCntResponse> DescribeMachineRiskCnt(DescribeMachineRiskCntRequest req)
        {
             JsonResponseModel<DescribeMachineRiskCntResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineRiskCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineRiskCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机入侵检测事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRiskCntRequest"/></param>
        /// <returns><see cref="DescribeMachineRiskCntResponse"/></returns>
        public DescribeMachineRiskCntResponse DescribeMachineRiskCntSync(DescribeMachineRiskCntRequest req)
        {
             JsonResponseModel<DescribeMachineRiskCntResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineRiskCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineRiskCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞修护-查询主机创建的快照
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineSnapshotRequest"/></param>
        /// <returns><see cref="DescribeMachineSnapshotResponse"/></returns>
        public async Task<DescribeMachineSnapshotResponse> DescribeMachineSnapshot(DescribeMachineSnapshotRequest req)
        {
             JsonResponseModel<DescribeMachineSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞修护-查询主机创建的快照
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineSnapshotRequest"/></param>
        /// <returns><see cref="DescribeMachineSnapshotResponse"/></returns>
        public DescribeMachineSnapshotResponse DescribeMachineSnapshotSync(DescribeMachineSnapshotRequest req)
        {
             JsonResponseModel<DescribeMachineSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineSnapshotResponse>>(strResp);
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
        /// 本接口 (DescribeMachinesSimple) 用于获取主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesSimpleRequest"/></param>
        /// <returns><see cref="DescribeMachinesSimpleResponse"/></returns>
        public async Task<DescribeMachinesSimpleResponse> DescribeMachinesSimple(DescribeMachinesSimpleRequest req)
        {
             JsonResponseModel<DescribeMachinesSimpleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachinesSimple");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesSimpleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeMachinesSimple) 用于获取主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesSimpleRequest"/></param>
        /// <returns><see cref="DescribeMachinesSimpleResponse"/></returns>
        public DescribeMachinesSimpleResponse DescribeMachinesSimpleSync(DescribeMachinesSimpleRequest req)
        {
             JsonResponseModel<DescribeMachinesSimpleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachinesSimple");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesSimpleResponse>>(strResp);
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
        /// 获取文件查杀概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskOverviewResponse"/></returns>
        public async Task<DescribeMalwareRiskOverviewResponse> DescribeMalwareRiskOverview(DescribeMalwareRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeMalwareRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwareRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取文件查杀概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskOverviewResponse"/></returns>
        public DescribeMalwareRiskOverviewResponse DescribeMalwareRiskOverviewSync(DescribeMalwareRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeMalwareRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalwareRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareRiskOverviewResponse>>(strResp);
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
        /// 获取木马白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListResponse"/></returns>
        public async Task<DescribeMalwareWhiteListResponse> DescribeMalwareWhiteList(DescribeMalwareWhiteListRequest req)
        {
             JsonResponseModel<DescribeMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取木马白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListResponse"/></returns>
        public DescribeMalwareWhiteListResponse DescribeMalwareWhiteListSync(DescribeMalwareWhiteListRequest req)
        {
             JsonResponseModel<DescribeMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取木马白名单受影响列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListAffectListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListAffectListResponse"/></returns>
        public async Task<DescribeMalwareWhiteListAffectListResponse> DescribeMalwareWhiteListAffectList(DescribeMalwareWhiteListAffectListRequest req)
        {
             JsonResponseModel<DescribeMalwareWhiteListAffectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwareWhiteListAffectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareWhiteListAffectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取木马白名单受影响列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListAffectListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListAffectListResponse"/></returns>
        public DescribeMalwareWhiteListAffectListResponse DescribeMalwareWhiteListAffectListSync(DescribeMalwareWhiteListAffectListRequest req)
        {
             JsonResponseModel<DescribeMalwareWhiteListAffectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMalwareWhiteListAffectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwareWhiteListAffectListResponse>>(strResp);
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
        /// 查询网络攻击设置
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public async Task<DescribeNetAttackSettingResponse> DescribeNetAttackSetting(DescribeNetAttackSettingRequest req)
        {
             JsonResponseModel<DescribeNetAttackSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetAttackSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetAttackSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网络攻击设置
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public DescribeNetAttackSettingResponse DescribeNetAttackSettingSync(DescribeNetAttackSettingRequest req)
        {
             JsonResponseModel<DescribeNetAttackSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetAttackSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetAttackSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络攻击白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DescribeNetAttackWhiteListResponse"/></returns>
        public async Task<DescribeNetAttackWhiteListResponse> DescribeNetAttackWhiteList(DescribeNetAttackWhiteListRequest req)
        {
             JsonResponseModel<DescribeNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetAttackWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网络攻击白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DescribeNetAttackWhiteListResponse"/></returns>
        public DescribeNetAttackWhiteListResponse DescribeNetAttackWhiteListSync(DescribeNetAttackWhiteListRequest req)
        {
             JsonResponseModel<DescribeNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetAttackWhiteListResponse>>(strResp);
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
        /// 本地提权信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventInfoRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventInfoResponse"/></returns>
        public async Task<DescribePrivilegeEventInfoResponse> DescribePrivilegeEventInfo(DescribePrivilegeEventInfoRequest req)
        {
             JsonResponseModel<DescribePrivilegeEventInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivilegeEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivilegeEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本地提权信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventInfoRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventInfoResponse"/></returns>
        public DescribePrivilegeEventInfoResponse DescribePrivilegeEventInfoSync(DescribePrivilegeEventInfoRequest req)
        {
             JsonResponseModel<DescribePrivilegeEventInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivilegeEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivilegeEventInfoResponse>>(strResp);
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
        /// 产品试用状态查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeProductStatusRequest"/></param>
        /// <returns><see cref="DescribeProductStatusResponse"/></returns>
        public async Task<DescribeProductStatusResponse> DescribeProductStatus(DescribeProductStatusRequest req)
        {
             JsonResponseModel<DescribeProductStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品试用状态查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeProductStatusRequest"/></param>
        /// <returns><see cref="DescribeProductStatusResponse"/></returns>
        public DescribeProductStatusResponse DescribeProductStatusSync(DescribeProductStatusRequest req)
        {
             JsonResponseModel<DescribeProductStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductStatusResponse>>(strResp);
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
        /// 专家服务-旗舰重保列表
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
        /// 专家服务-旗舰重保列表
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
        /// 获取公网接入代理安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribePublicProxyInstallCommandRequest"/></param>
        /// <returns><see cref="DescribePublicProxyInstallCommandResponse"/></returns>
        public async Task<DescribePublicProxyInstallCommandResponse> DescribePublicProxyInstallCommand(DescribePublicProxyInstallCommandRequest req)
        {
             JsonResponseModel<DescribePublicProxyInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicProxyInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicProxyInstallCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取公网接入代理安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribePublicProxyInstallCommandRequest"/></param>
        /// <returns><see cref="DescribePublicProxyInstallCommandResponse"/></returns>
        public DescribePublicProxyInstallCommandResponse DescribePublicProxyInstallCommandSync(DescribePublicProxyInstallCommandRequest req)
        {
             JsonResponseModel<DescribePublicProxyInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicProxyInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicProxyInstallCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机快照备份列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseBackupListResponse"/></returns>
        public async Task<DescribeRansomDefenseBackupListResponse> DescribeRansomDefenseBackupList(DescribeRansomDefenseBackupListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseBackupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseBackupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseBackupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机快照备份列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseBackupListResponse"/></returns>
        public DescribeRansomDefenseBackupListResponse DescribeRansomDefenseBackupListSync(DescribeRansomDefenseBackupListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseBackupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseBackupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseBackupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防勒索事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseEventsListResponse"/></returns>
        public async Task<DescribeRansomDefenseEventsListResponse> DescribeRansomDefenseEventsList(DescribeRansomDefenseEventsListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseEventsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseEventsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseEventsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防勒索事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseEventsListResponse"/></returns>
        public DescribeRansomDefenseEventsListResponse DescribeRansomDefenseEventsListSync(DescribeRansomDefenseEventsListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseEventsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseEventsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseEventsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineListResponse"/></returns>
        public async Task<DescribeRansomDefenseMachineListResponse> DescribeRansomDefenseMachineList(DescribeRansomDefenseMachineListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseMachineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineListResponse"/></returns>
        public DescribeRansomDefenseMachineListResponse DescribeRansomDefenseMachineListSync(DescribeRansomDefenseMachineListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseMachineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机绑定策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineStrategyInfoRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineStrategyInfoResponse"/></returns>
        public async Task<DescribeRansomDefenseMachineStrategyInfoResponse> DescribeRansomDefenseMachineStrategyInfo(DescribeRansomDefenseMachineStrategyInfoRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseMachineStrategyInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseMachineStrategyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseMachineStrategyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取主机绑定策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineStrategyInfoRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineStrategyInfoResponse"/></returns>
        public DescribeRansomDefenseMachineStrategyInfoResponse DescribeRansomDefenseMachineStrategyInfoSync(DescribeRansomDefenseMachineStrategyInfoRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseMachineStrategyInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseMachineStrategyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseMachineStrategyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询回滚任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseRollBackTaskListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseRollBackTaskListResponse"/></returns>
        public async Task<DescribeRansomDefenseRollBackTaskListResponse> DescribeRansomDefenseRollBackTaskList(DescribeRansomDefenseRollBackTaskListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseRollBackTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseRollBackTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseRollBackTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询回滚任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseRollBackTaskListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseRollBackTaskListResponse"/></returns>
        public DescribeRansomDefenseRollBackTaskListResponse DescribeRansomDefenseRollBackTaskListSync(DescribeRansomDefenseRollBackTaskListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseRollBackTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseRollBackTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseRollBackTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户防勒索趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStateRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStateResponse"/></returns>
        public async Task<DescribeRansomDefenseStateResponse> DescribeRansomDefenseState(DescribeRansomDefenseStateRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户防勒索趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStateRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStateResponse"/></returns>
        public DescribeRansomDefenseStateResponse DescribeRansomDefenseStateSync(DescribeRansomDefenseStateRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyDetailResponse"/></returns>
        public async Task<DescribeRansomDefenseStrategyDetailResponse> DescribeRansomDefenseStrategyDetail(DescribeRansomDefenseStrategyDetailRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStrategyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseStrategyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStrategyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyDetailResponse"/></returns>
        public DescribeRansomDefenseStrategyDetailResponse DescribeRansomDefenseStrategyDetailSync(DescribeRansomDefenseStrategyDetailRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStrategyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseStrategyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStrategyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防勒索策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyListResponse"/></returns>
        public async Task<DescribeRansomDefenseStrategyListResponse> DescribeRansomDefenseStrategyList(DescribeRansomDefenseStrategyListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStrategyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStrategyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防勒索策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyListResponse"/></returns>
        public DescribeRansomDefenseStrategyListResponse DescribeRansomDefenseStrategyListSync(DescribeRansomDefenseStrategyListRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStrategyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStrategyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防勒索策略绑定机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyMachinesResponse"/></returns>
        public async Task<DescribeRansomDefenseStrategyMachinesResponse> DescribeRansomDefenseStrategyMachines(DescribeRansomDefenseStrategyMachinesRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStrategyMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseStrategyMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStrategyMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防勒索策略绑定机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyMachinesResponse"/></returns>
        public DescribeRansomDefenseStrategyMachinesResponse DescribeRansomDefenseStrategyMachinesSync(DescribeRansomDefenseStrategyMachinesRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseStrategyMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseStrategyMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseStrategyMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取全网勒索态势
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseTrendRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseTrendResponse"/></returns>
        public async Task<DescribeRansomDefenseTrendResponse> DescribeRansomDefenseTrend(DescribeRansomDefenseTrendRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRansomDefenseTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取全网勒索态势
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseTrendRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseTrendResponse"/></returns>
        public DescribeRansomDefenseTrendResponse DescribeRansomDefenseTrendSync(DescribeRansomDefenseTrendRequest req)
        {
             JsonResponseModel<DescribeRansomDefenseTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRansomDefenseTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRansomDefenseTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推荐购买防护核数
        /// </summary>
        /// <param name="req"><see cref="DescribeRecommendedProtectCpuRequest"/></param>
        /// <returns><see cref="DescribeRecommendedProtectCpuResponse"/></returns>
        public async Task<DescribeRecommendedProtectCpuResponse> DescribeRecommendedProtectCpu(DescribeRecommendedProtectCpuRequest req)
        {
             JsonResponseModel<DescribeRecommendedProtectCpuResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecommendedProtectCpu");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecommendedProtectCpuResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推荐购买防护核数
        /// </summary>
        /// <param name="req"><see cref="DescribeRecommendedProtectCpuRequest"/></param>
        /// <returns><see cref="DescribeRecommendedProtectCpuResponse"/></returns>
        public DescribeRecommendedProtectCpuResponse DescribeRecommendedProtectCpuSync(DescribeRecommendedProtectCpuRequest req)
        {
             JsonResponseModel<DescribeRecommendedProtectCpuResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecommendedProtectCpu");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecommendedProtectCpuResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 反弹shell信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventInfoRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventInfoResponse"/></returns>
        public async Task<DescribeReverseShellEventInfoResponse> DescribeReverseShellEventInfo(DescribeReverseShellEventInfoRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 反弹shell信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventInfoRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventInfoResponse"/></returns>
        public DescribeReverseShellEventInfoResponse DescribeReverseShellEventInfoSync(DescribeReverseShellEventInfoRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventInfoResponse>>(strResp);
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
        /// 查询入侵检测事件更新状态任务是否完成
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskBatchStatusRequest"/></param>
        /// <returns><see cref="DescribeRiskBatchStatusResponse"/></returns>
        public async Task<DescribeRiskBatchStatusResponse> DescribeRiskBatchStatus(DescribeRiskBatchStatusRequest req)
        {
             JsonResponseModel<DescribeRiskBatchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskBatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskBatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询入侵检测事件更新状态任务是否完成
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskBatchStatusRequest"/></param>
        /// <returns><see cref="DescribeRiskBatchStatusResponse"/></returns>
        public DescribeRiskBatchStatusResponse DescribeRiskBatchStatusSync(DescribeRiskBatchStatusRequest req)
        {
             JsonResponseModel<DescribeRiskBatchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskBatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskBatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询恶意请求事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventInfoResponse"/></returns>
        public async Task<DescribeRiskDnsEventInfoResponse> DescribeRiskDnsEventInfo(DescribeRiskDnsEventInfoRequest req)
        {
             JsonResponseModel<DescribeRiskDnsEventInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskDnsEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询恶意请求事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventInfoResponse"/></returns>
        public DescribeRiskDnsEventInfoResponse DescribeRiskDnsEventInfoSync(DescribeRiskDnsEventInfoRequest req)
        {
             JsonResponseModel<DescribeRiskDnsEventInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskDnsEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取恶意请求事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventListResponse"/></returns>
        public async Task<DescribeRiskDnsEventListResponse> DescribeRiskDnsEventList(DescribeRiskDnsEventListRequest req)
        {
             JsonResponseModel<DescribeRiskDnsEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskDnsEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取恶意请求事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventListResponse"/></returns>
        public DescribeRiskDnsEventListResponse DescribeRiskDnsEventListSync(DescribeRiskDnsEventListRequest req)
        {
             JsonResponseModel<DescribeRiskDnsEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskDnsEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询恶意请求详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsInfoResponse"/></returns>
        public async Task<DescribeRiskDnsInfoResponse> DescribeRiskDnsInfo(DescribeRiskDnsInfoRequest req)
        {
             JsonResponseModel<DescribeRiskDnsInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskDnsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询恶意请求详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsInfoResponse"/></returns>
        public DescribeRiskDnsInfoResponse DescribeRiskDnsInfoSync(DescribeRiskDnsInfoRequest req)
        {
             JsonResponseModel<DescribeRiskDnsInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskDnsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsInfoResponse>>(strResp);
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
        /// 获取恶意请求策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsPolicyListResponse"/></returns>
        public async Task<DescribeRiskDnsPolicyListResponse> DescribeRiskDnsPolicyList(DescribeRiskDnsPolicyListRequest req)
        {
             JsonResponseModel<DescribeRiskDnsPolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskDnsPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取恶意请求策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsPolicyListResponse"/></returns>
        public DescribeRiskDnsPolicyListResponse DescribeRiskDnsPolicyListSync(DescribeRiskDnsPolicyListRequest req)
        {
             JsonResponseModel<DescribeRiskDnsPolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskDnsPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskDnsPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异常进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskProcessEventsResponse"/></returns>
        public async Task<DescribeRiskProcessEventsResponse> DescribeRiskProcessEvents(DescribeRiskProcessEventsRequest req)
        {
             JsonResponseModel<DescribeRiskProcessEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskProcessEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskProcessEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异常进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskProcessEventsResponse"/></returns>
        public DescribeRiskProcessEventsResponse DescribeRiskProcessEventsSync(DescribeRiskProcessEventsRequest req)
        {
             JsonResponseModel<DescribeRiskProcessEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskProcessEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskProcessEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全通知信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeInfoRequest"/></param>
        /// <returns><see cref="DescribeSafeInfoResponse"/></returns>
        public async Task<DescribeSafeInfoResponse> DescribeSafeInfo(DescribeSafeInfoRequest req)
        {
             JsonResponseModel<DescribeSafeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSafeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全通知信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeInfoRequest"/></param>
        /// <returns><see cref="DescribeSafeInfoResponse"/></returns>
        public DescribeSafeInfoResponse DescribeSafeInfoSync(DescribeSafeInfoRequest req)
        {
             JsonResponseModel<DescribeSafeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSafeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSafeInfoResponse>>(strResp);
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
        /// 大屏可视化获取全网攻击热点
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenAttackHotspotRequest"/></param>
        /// <returns><see cref="DescribeScreenAttackHotspotResponse"/></returns>
        public async Task<DescribeScreenAttackHotspotResponse> DescribeScreenAttackHotspot(DescribeScreenAttackHotspotRequest req)
        {
             JsonResponseModel<DescribeScreenAttackHotspotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenAttackHotspot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenAttackHotspotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化获取全网攻击热点
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenAttackHotspotRequest"/></param>
        /// <returns><see cref="DescribeScreenAttackHotspotResponse"/></returns>
        public DescribeScreenAttackHotspotResponse DescribeScreenAttackHotspotSync(DescribeScreenAttackHotspotRequest req)
        {
             JsonResponseModel<DescribeScreenAttackHotspotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenAttackHotspot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenAttackHotspotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化安全播报
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeScreenBroadcastsResponse"/></returns>
        public async Task<DescribeScreenBroadcastsResponse> DescribeScreenBroadcasts(DescribeScreenBroadcastsRequest req)
        {
             JsonResponseModel<DescribeScreenBroadcastsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenBroadcasts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenBroadcastsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化安全播报
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeScreenBroadcastsResponse"/></returns>
        public DescribeScreenBroadcastsResponse DescribeScreenBroadcastsSync(DescribeScreenBroadcastsRequest req)
        {
             JsonResponseModel<DescribeScreenBroadcastsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenBroadcasts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenBroadcastsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化防趋势接口
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenDefenseTrendsRequest"/></param>
        /// <returns><see cref="DescribeScreenDefenseTrendsResponse"/></returns>
        public async Task<DescribeScreenDefenseTrendsResponse> DescribeScreenDefenseTrends(DescribeScreenDefenseTrendsRequest req)
        {
             JsonResponseModel<DescribeScreenDefenseTrendsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenDefenseTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenDefenseTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化防趋势接口
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenDefenseTrendsRequest"/></param>
        /// <returns><see cref="DescribeScreenDefenseTrendsResponse"/></returns>
        public DescribeScreenDefenseTrendsResponse DescribeScreenDefenseTrendsSync(DescribeScreenDefenseTrendsRequest req)
        {
             JsonResponseModel<DescribeScreenDefenseTrendsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenDefenseTrends");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenDefenseTrendsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化紧急通知
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeScreenEmergentMsgResponse"/></returns>
        public async Task<DescribeScreenEmergentMsgResponse> DescribeScreenEmergentMsg(DescribeScreenEmergentMsgRequest req)
        {
             JsonResponseModel<DescribeScreenEmergentMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenEmergentMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenEmergentMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化紧急通知
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeScreenEmergentMsgResponse"/></returns>
        public DescribeScreenEmergentMsgResponse DescribeScreenEmergentMsgSync(DescribeScreenEmergentMsgRequest req)
        {
             JsonResponseModel<DescribeScreenEmergentMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenEmergentMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenEmergentMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化获取安全概览相关事件统计数据接口
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEventsCntRequest"/></param>
        /// <returns><see cref="DescribeScreenEventsCntResponse"/></returns>
        public async Task<DescribeScreenEventsCntResponse> DescribeScreenEventsCnt(DescribeScreenEventsCntRequest req)
        {
             JsonResponseModel<DescribeScreenEventsCntResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenEventsCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenEventsCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化获取安全概览相关事件统计数据接口
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEventsCntRequest"/></param>
        /// <returns><see cref="DescribeScreenEventsCntResponse"/></returns>
        public DescribeScreenEventsCntResponse DescribeScreenEventsCntSync(DescribeScreenEventsCntRequest req)
        {
             JsonResponseModel<DescribeScreenEventsCntResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenEventsCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenEventsCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化获取主机相关统计
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeScreenGeneralStatResponse"/></returns>
        public async Task<DescribeScreenGeneralStatResponse> DescribeScreenGeneralStat(DescribeScreenGeneralStatRequest req)
        {
             JsonResponseModel<DescribeScreenGeneralStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenGeneralStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenGeneralStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化获取主机相关统计
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeScreenGeneralStatResponse"/></returns>
        public DescribeScreenGeneralStatResponse DescribeScreenGeneralStatSync(DescribeScreenGeneralStatRequest req)
        {
             JsonResponseModel<DescribeScreenGeneralStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenGeneralStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenGeneralStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机入侵详情
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenHostInvasionRequest"/></param>
        /// <returns><see cref="DescribeScreenHostInvasionResponse"/></returns>
        public async Task<DescribeScreenHostInvasionResponse> DescribeScreenHostInvasion(DescribeScreenHostInvasionRequest req)
        {
             JsonResponseModel<DescribeScreenHostInvasionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenHostInvasion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenHostInvasionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机入侵详情
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenHostInvasionRequest"/></param>
        /// <returns><see cref="DescribeScreenHostInvasionResponse"/></returns>
        public DescribeScreenHostInvasionResponse DescribeScreenHostInvasionSync(DescribeScreenHostInvasionRequest req)
        {
             JsonResponseModel<DescribeScreenHostInvasionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenHostInvasion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenHostInvasionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机区域选项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeScreenMachineRegionsResponse"/></returns>
        public async Task<DescribeScreenMachineRegionsResponse> DescribeScreenMachineRegions(DescribeScreenMachineRegionsRequest req)
        {
             JsonResponseModel<DescribeScreenMachineRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenMachineRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenMachineRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机区域选项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeScreenMachineRegionsResponse"/></returns>
        public DescribeScreenMachineRegionsResponse DescribeScreenMachineRegionsSync(DescribeScreenMachineRegionsRequest req)
        {
             JsonResponseModel<DescribeScreenMachineRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenMachineRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenMachineRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机区域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachinesRequest"/></param>
        /// <returns><see cref="DescribeScreenMachinesResponse"/></returns>
        public async Task<DescribeScreenMachinesResponse> DescribeScreenMachines(DescribeScreenMachinesRequest req)
        {
             JsonResponseModel<DescribeScreenMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机区域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachinesRequest"/></param>
        /// <returns><see cref="DescribeScreenMachinesResponse"/></returns>
        public DescribeScreenMachinesResponse DescribeScreenMachinesSync(DescribeScreenMachinesRequest req)
        {
             JsonResponseModel<DescribeScreenMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机安全防护引擎介绍
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionCntRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionCntResponse"/></returns>
        public async Task<DescribeScreenProtectionCntResponse> DescribeScreenProtectionCnt(DescribeScreenProtectionCntRequest req)
        {
             JsonResponseModel<DescribeScreenProtectionCntResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenProtectionCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenProtectionCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化主机安全防护引擎介绍
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionCntRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionCntResponse"/></returns>
        public DescribeScreenProtectionCntResponse DescribeScreenProtectionCntSync(DescribeScreenProtectionCntRequest req)
        {
             JsonResponseModel<DescribeScreenProtectionCntResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenProtectionCnt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenProtectionCntResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏获取安全防护状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionStatResponse"/></returns>
        public async Task<DescribeScreenProtectionStatResponse> DescribeScreenProtectionStat(DescribeScreenProtectionStatRequest req)
        {
             JsonResponseModel<DescribeScreenProtectionStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenProtectionStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenProtectionStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏获取安全防护状态
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionStatResponse"/></returns>
        public DescribeScreenProtectionStatResponse DescribeScreenProtectionStatSync(DescribeScreenProtectionStatRequest req)
        {
             JsonResponseModel<DescribeScreenProtectionStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenProtectionStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenProtectionStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化风险资产top5（今日），统计今日风险资产
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenRiskAssetsTopRequest"/></param>
        /// <returns><see cref="DescribeScreenRiskAssetsTopResponse"/></returns>
        public async Task<DescribeScreenRiskAssetsTopResponse> DescribeScreenRiskAssetsTop(DescribeScreenRiskAssetsTopRequest req)
        {
             JsonResponseModel<DescribeScreenRiskAssetsTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScreenRiskAssetsTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenRiskAssetsTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 大屏可视化风险资产top5（今日），统计今日风险资产
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenRiskAssetsTopRequest"/></param>
        /// <returns><see cref="DescribeScreenRiskAssetsTopResponse"/></returns>
        public DescribeScreenRiskAssetsTopResponse DescribeScreenRiskAssetsTopSync(DescribeScreenRiskAssetsTopRequest req)
        {
             JsonResponseModel<DescribeScreenRiskAssetsTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScreenRiskAssetsTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScreenRiskAssetsTopResponse>>(strResp);
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
        /// 查询安全播报文章信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastInfoResponse"/></returns>
        public async Task<DescribeSecurityBroadcastInfoResponse> DescribeSecurityBroadcastInfo(DescribeSecurityBroadcastInfoRequest req)
        {
             JsonResponseModel<DescribeSecurityBroadcastInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityBroadcastInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityBroadcastInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全播报文章信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastInfoResponse"/></returns>
        public DescribeSecurityBroadcastInfoResponse DescribeSecurityBroadcastInfoSync(DescribeSecurityBroadcastInfoRequest req)
        {
             JsonResponseModel<DescribeSecurityBroadcastInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityBroadcastInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityBroadcastInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全播报列表页
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastsResponse"/></returns>
        public async Task<DescribeSecurityBroadcastsResponse> DescribeSecurityBroadcasts(DescribeSecurityBroadcastsRequest req)
        {
             JsonResponseModel<DescribeSecurityBroadcastsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityBroadcasts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityBroadcastsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全播报列表页
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastsResponse"/></returns>
        public DescribeSecurityBroadcastsResponse DescribeSecurityBroadcastsSync(DescribeSecurityBroadcastsRequest req)
        {
             JsonResponseModel<DescribeSecurityBroadcastsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityBroadcasts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityBroadcastsResponse>>(strResp);
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
        /// 获取安全事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventStatResponse"/></returns>
        public async Task<DescribeSecurityEventStatResponse> DescribeSecurityEventStat(DescribeSecurityEventStatRequest req)
        {
             JsonResponseModel<DescribeSecurityEventStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityEventStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityEventStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventStatResponse"/></returns>
        public DescribeSecurityEventStatResponse DescribeSecurityEventStatSync(DescribeSecurityEventStatRequest req)
        {
             JsonResponseModel<DescribeSecurityEventStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityEventStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityEventStatResponse>>(strResp);
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
        /// 获取安全防护状态汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityProtectionStatResponse"/></returns>
        public async Task<DescribeSecurityProtectionStatResponse> DescribeSecurityProtectionStat(DescribeSecurityProtectionStatRequest req)
        {
             JsonResponseModel<DescribeSecurityProtectionStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityProtectionStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityProtectionStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全防护状态汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityProtectionStatResponse"/></returns>
        public DescribeSecurityProtectionStatResponse DescribeSecurityProtectionStatSync(DescribeSecurityProtectionStatRequest req)
        {
             JsonResponseModel<DescribeSecurityProtectionStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityProtectionStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityProtectionStatResponse>>(strResp);
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
        /// 查询主机安全授权试用报告(仅限控制台申领的)
        /// </summary>
        /// <param name="req"><see cref="DescribeTrialReportRequest"/></param>
        /// <returns><see cref="DescribeTrialReportResponse"/></returns>
        public async Task<DescribeTrialReportResponse> DescribeTrialReport(DescribeTrialReportRequest req)
        {
             JsonResponseModel<DescribeTrialReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrialReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrialReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机安全授权试用报告(仅限控制台申领的)
        /// </summary>
        /// <param name="req"><see cref="DescribeTrialReportRequest"/></param>
        /// <returns><see cref="DescribeTrialReportResponse"/></returns>
        public DescribeTrialReportResponse DescribeTrialReportSync(DescribeTrialReportRequest req)
        {
             JsonResponseModel<DescribeTrialReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrialReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrialReportResponse>>(strResp);
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
        /// 用于查询用户自定义配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersConfigRequest"/></param>
        /// <returns><see cref="DescribeUsersConfigResponse"/></returns>
        public async Task<DescribeUsersConfigResponse> DescribeUsersConfig(DescribeUsersConfigRequest req)
        {
             JsonResponseModel<DescribeUsersConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsersConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询用户自定义配置
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersConfigRequest"/></param>
        /// <returns><see cref="DescribeUsersConfigResponse"/></returns>
        public DescribeUsersConfigResponse DescribeUsersConfigSync(DescribeUsersConfigRequest req)
        {
             JsonResponseModel<DescribeUsersConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsersConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersConfigResponse>>(strResp);
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
        /// 获取病毒库及POC的更新信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVdbAndPocInfoRequest"/></param>
        /// <returns><see cref="DescribeVdbAndPocInfoResponse"/></returns>
        public async Task<DescribeVdbAndPocInfoResponse> DescribeVdbAndPocInfo(DescribeVdbAndPocInfoRequest req)
        {
             JsonResponseModel<DescribeVdbAndPocInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVdbAndPocInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVdbAndPocInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取病毒库及POC的更新信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVdbAndPocInfoRequest"/></param>
        /// <returns><see cref="DescribeVdbAndPocInfoResponse"/></returns>
        public DescribeVdbAndPocInfoResponse DescribeVdbAndPocInfoSync(DescribeVdbAndPocInfoRequest req)
        {
             JsonResponseModel<DescribeVdbAndPocInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVdbAndPocInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVdbAndPocInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取版本对比信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionCompareChartRequest"/></param>
        /// <returns><see cref="DescribeVersionCompareChartResponse"/></returns>
        public async Task<DescribeVersionCompareChartResponse> DescribeVersionCompareChart(DescribeVersionCompareChartRequest req)
        {
             JsonResponseModel<DescribeVersionCompareChartResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVersionCompareChart");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVersionCompareChartResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取版本对比信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionCompareChartRequest"/></param>
        /// <returns><see cref="DescribeVersionCompareChartResponse"/></returns>
        public DescribeVersionCompareChartResponse DescribeVersionCompareChartSync(DescribeVersionCompareChartRequest req)
        {
             JsonResponseModel<DescribeVersionCompareChartResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVersionCompareChart");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVersionCompareChartResponse>>(strResp);
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
        /// 获取指定点属性信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVertexDetailRequest"/></param>
        /// <returns><see cref="DescribeVertexDetailResponse"/></returns>
        public async Task<DescribeVertexDetailResponse> DescribeVertexDetail(DescribeVertexDetailRequest req)
        {
             JsonResponseModel<DescribeVertexDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVertexDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVertexDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定点属性信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVertexDetailRequest"/></param>
        /// <returns><see cref="DescribeVertexDetailResponse"/></returns>
        public DescribeVertexDetailResponse DescribeVertexDetailSync(DescribeVertexDetailRequest req)
        {
             JsonResponseModel<DescribeVertexDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVertexDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVertexDetailResponse>>(strResp);
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
        /// CveId查询漏洞详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCveIdInfoRequest"/></param>
        /// <returns><see cref="DescribeVulCveIdInfoResponse"/></returns>
        public async Task<DescribeVulCveIdInfoResponse> DescribeVulCveIdInfo(DescribeVulCveIdInfoRequest req)
        {
             JsonResponseModel<DescribeVulCveIdInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulCveIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulCveIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CveId查询漏洞详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCveIdInfoRequest"/></param>
        /// <returns><see cref="DescribeVulCveIdInfoResponse"/></returns>
        public DescribeVulCveIdInfoResponse DescribeVulCveIdInfoSync(DescribeVulCveIdInfoRequest req)
        {
             JsonResponseModel<DescribeVulCveIdInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulCveIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulCveIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞防御事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public async Task<DescribeVulDefenceEventResponse> DescribeVulDefenceEvent(DescribeVulDefenceEventRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞防御事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public DescribeVulDefenceEventResponse DescribeVulDefenceEventSync(DescribeVulDefenceEventRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceListRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceListResponse"/></returns>
        public async Task<DescribeVulDefenceListResponse> DescribeVulDefenceList(DescribeVulDefenceListRequest req)
        {
             JsonResponseModel<DescribeVulDefenceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceListRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceListResponse"/></returns>
        public DescribeVulDefenceListResponse DescribeVulDefenceListSync(DescribeVulDefenceListRequest req)
        {
             JsonResponseModel<DescribeVulDefenceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞防御概览信息，包括事件趋势及插件开启情况
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceOverviewResponse"/></returns>
        public async Task<DescribeVulDefenceOverviewResponse> DescribeVulDefenceOverview(DescribeVulDefenceOverviewRequest req)
        {
             JsonResponseModel<DescribeVulDefenceOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞防御概览信息，包括事件趋势及插件开启情况
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceOverviewResponse"/></returns>
        public DescribeVulDefenceOverviewResponse DescribeVulDefenceOverviewSync(DescribeVulDefenceOverviewRequest req)
        {
             JsonResponseModel<DescribeVulDefenceOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单台主机漏洞防御插件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginDetailResponse"/></returns>
        public async Task<DescribeVulDefencePluginDetailResponse> DescribeVulDefencePluginDetail(DescribeVulDefencePluginDetailRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefencePluginDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单台主机漏洞防御插件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginDetailResponse"/></returns>
        public DescribeVulDefencePluginDetailResponse DescribeVulDefencePluginDetailSync(DescribeVulDefencePluginDetailRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefencePluginDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前异常插件数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginExceptionCountRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginExceptionCountResponse"/></returns>
        public async Task<DescribeVulDefencePluginExceptionCountResponse> DescribeVulDefencePluginExceptionCount(DescribeVulDefencePluginExceptionCountRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginExceptionCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefencePluginExceptionCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginExceptionCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前异常插件数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginExceptionCountRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginExceptionCountResponse"/></returns>
        public DescribeVulDefencePluginExceptionCountResponse DescribeVulDefencePluginExceptionCountSync(DescribeVulDefencePluginExceptionCountRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginExceptionCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefencePluginExceptionCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginExceptionCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各主机漏洞防御插件状态
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginStatusRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginStatusResponse"/></returns>
        public async Task<DescribeVulDefencePluginStatusResponse> DescribeVulDefencePluginStatus(DescribeVulDefencePluginStatusRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefencePluginStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取各主机漏洞防御插件状态
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginStatusRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginStatusResponse"/></returns>
        public DescribeVulDefencePluginStatusResponse DescribeVulDefencePluginStatusSync(DescribeVulDefencePluginStatusRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefencePluginStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前漏洞防御插件设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public async Task<DescribeVulDefenceSettingResponse> DescribeVulDefenceSetting(DescribeVulDefenceSettingRequest req)
        {
             JsonResponseModel<DescribeVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前漏洞防御插件设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public DescribeVulDefenceSettingResponse DescribeVulDefenceSettingSync(DescribeVulDefenceSettingRequest req)
        {
             JsonResponseModel<DescribeVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞影响主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeVulEffectHostListResponse"/></returns>
        public async Task<DescribeVulEffectHostListResponse> DescribeVulEffectHostList(DescribeVulEffectHostListRequest req)
        {
             JsonResponseModel<DescribeVulEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞影响主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeVulEffectHostListResponse"/></returns>
        public DescribeVulEffectHostListResponse DescribeVulEffectHostListSync(DescribeVulEffectHostListRequest req)
        {
             JsonResponseModel<DescribeVulEffectHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulEffectHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulEffectHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞影响组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectModulesRequest"/></param>
        /// <returns><see cref="DescribeVulEffectModulesResponse"/></returns>
        public async Task<DescribeVulEffectModulesResponse> DescribeVulEffectModules(DescribeVulEffectModulesRequest req)
        {
             JsonResponseModel<DescribeVulEffectModulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulEffectModules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulEffectModulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞影响组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectModulesRequest"/></param>
        /// <returns><see cref="DescribeVulEffectModulesResponse"/></returns>
        public DescribeVulEffectModulesResponse DescribeVulEffectModulesSync(DescribeVulEffectModulesRequest req)
        {
             JsonResponseModel<DescribeVulEffectModulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulEffectModules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulEffectModulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞紧急通知
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeVulEmergentMsgResponse"/></returns>
        public async Task<DescribeVulEmergentMsgResponse> DescribeVulEmergentMsg(DescribeVulEmergentMsgRequest req)
        {
             JsonResponseModel<DescribeVulEmergentMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulEmergentMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulEmergentMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞紧急通知
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeVulEmergentMsgResponse"/></returns>
        public DescribeVulEmergentMsgResponse DescribeVulEmergentMsgSync(DescribeVulEmergentMsgRequest req)
        {
             JsonResponseModel<DescribeVulEmergentMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulEmergentMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulEmergentMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞修护-查找主机漏洞修护进度
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixStatusRequest"/></param>
        /// <returns><see cref="DescribeVulFixStatusResponse"/></returns>
        public async Task<DescribeVulFixStatusResponse> DescribeVulFixStatus(DescribeVulFixStatusRequest req)
        {
             JsonResponseModel<DescribeVulFixStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulFixStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulFixStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞修护-查找主机漏洞修护进度
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixStatusRequest"/></param>
        /// <returns><see cref="DescribeVulFixStatusResponse"/></returns>
        public DescribeVulFixStatusResponse DescribeVulFixStatusSync(DescribeVulFixStatusRequest req)
        {
             JsonResponseModel<DescribeVulFixStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulFixStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulFixStatusResponse>>(strResp);
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
        /// 获取用户漏洞所有标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelsRequest"/></param>
        /// <returns><see cref="DescribeVulLabelsResponse"/></returns>
        public async Task<DescribeVulLabelsResponse> DescribeVulLabels(DescribeVulLabelsRequest req)
        {
             JsonResponseModel<DescribeVulLabelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLabelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户漏洞所有标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelsRequest"/></param>
        /// <returns><see cref="DescribeVulLabelsResponse"/></returns>
        public DescribeVulLabelsResponse DescribeVulLabelsSync(DescribeVulLabelsRequest req)
        {
             JsonResponseModel<DescribeVulLabelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLabelsResponse>>(strResp);
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
        /// 获取漏洞列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public async Task<DescribeVulListResponse> DescribeVulList(DescribeVulListRequest req)
        {
             JsonResponseModel<DescribeVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public DescribeVulListResponse DescribeVulListSync(DescribeVulListRequest req)
        {
             JsonResponseModel<DescribeVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulOverviewResponse"/></returns>
        public async Task<DescribeVulOverviewResponse> DescribeVulOverview(DescribeVulOverviewRequest req)
        {
             JsonResponseModel<DescribeVulOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulOverviewResponse"/></returns>
        public DescribeVulOverviewResponse DescribeVulOverviewSync(DescribeVulOverviewRequest req)
        {
             JsonResponseModel<DescribeVulOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulStoreListRequest"/></param>
        /// <returns><see cref="DescribeVulStoreListResponse"/></returns>
        public async Task<DescribeVulStoreListResponse> DescribeVulStoreList(DescribeVulStoreListRequest req)
        {
             JsonResponseModel<DescribeVulStoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulStoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulStoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulStoreListRequest"/></param>
        /// <returns><see cref="DescribeVulStoreListResponse"/></returns>
        public DescribeVulStoreListResponse DescribeVulStoreListSync(DescribeVulStoreListRequest req)
        {
             JsonResponseModel<DescribeVulStoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulStoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulStoreListResponse>>(strResp);
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
        /// 获取漏洞态势信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTrendRequest"/></param>
        /// <returns><see cref="DescribeVulTrendResponse"/></returns>
        public async Task<DescribeVulTrendResponse> DescribeVulTrend(DescribeVulTrendRequest req)
        {
             JsonResponseModel<DescribeVulTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取漏洞态势信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTrendRequest"/></param>
        /// <returns><see cref="DescribeVulTrendResponse"/></returns>
        public DescribeVulTrendResponse DescribeVulTrendSync(DescribeVulTrendRequest req)
        {
             JsonResponseModel<DescribeVulTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警机器范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningHostConfigRequest"/></param>
        /// <returns><see cref="DescribeWarningHostConfigResponse"/></returns>
        public async Task<DescribeWarningHostConfigResponse> DescribeWarningHostConfig(DescribeWarningHostConfigRequest req)
        {
             JsonResponseModel<DescribeWarningHostConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWarningHostConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningHostConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警机器范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningHostConfigRequest"/></param>
        /// <returns><see cref="DescribeWarningHostConfigResponse"/></returns>
        public DescribeWarningHostConfigResponse DescribeWarningHostConfigSync(DescribeWarningHostConfigRequest req)
        {
             JsonResponseModel<DescribeWarningHostConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWarningHostConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningHostConfigResponse>>(strResp);
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
        /// 查询告警策略
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookPolicyRequest"/></param>
        /// <returns><see cref="DescribeWebHookPolicyResponse"/></returns>
        public async Task<DescribeWebHookPolicyResponse> DescribeWebHookPolicy(DescribeWebHookPolicyRequest req)
        {
             JsonResponseModel<DescribeWebHookPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebHookPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警策略
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookPolicyRequest"/></param>
        /// <returns><see cref="DescribeWebHookPolicyResponse"/></returns>
        public DescribeWebHookPolicyResponse DescribeWebHookPolicySync(DescribeWebHookPolicyRequest req)
        {
             JsonResponseModel<DescribeWebHookPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebHookPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警接收人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverResponse"/></returns>
        public async Task<DescribeWebHookReceiverResponse> DescribeWebHookReceiver(DescribeWebHookReceiverRequest req)
        {
             JsonResponseModel<DescribeWebHookReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebHookReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警接收人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverResponse"/></returns>
        public DescribeWebHookReceiverResponse DescribeWebHookReceiverSync(DescribeWebHookReceiverRequest req)
        {
             JsonResponseModel<DescribeWebHookReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebHookReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定告警接收人的关联策略使用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverUsageRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverUsageResponse"/></returns>
        public async Task<DescribeWebHookReceiverUsageResponse> DescribeWebHookReceiverUsage(DescribeWebHookReceiverUsageRequest req)
        {
             JsonResponseModel<DescribeWebHookReceiverUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebHookReceiverUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookReceiverUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定告警接收人的关联策略使用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverUsageRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverUsageResponse"/></returns>
        public DescribeWebHookReceiverUsageResponse DescribeWebHookReceiverUsageSync(DescribeWebHookReceiverUsageRequest req)
        {
             JsonResponseModel<DescribeWebHookReceiverUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebHookReceiverUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookReceiverUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企微机器人规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRuleRequest"/></param>
        /// <returns><see cref="DescribeWebHookRuleResponse"/></returns>
        public async Task<DescribeWebHookRuleResponse> DescribeWebHookRule(DescribeWebHookRuleRequest req)
        {
             JsonResponseModel<DescribeWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企微机器人规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRuleRequest"/></param>
        /// <returns><see cref="DescribeWebHookRuleResponse"/></returns>
        public DescribeWebHookRuleResponse DescribeWebHookRuleSync(DescribeWebHookRuleRequest req)
        {
             JsonResponseModel<DescribeWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企微机器人规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRulesRequest"/></param>
        /// <returns><see cref="DescribeWebHookRulesResponse"/></returns>
        public async Task<DescribeWebHookRulesResponse> DescribeWebHookRules(DescribeWebHookRulesRequest req)
        {
             JsonResponseModel<DescribeWebHookRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebHookRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取企微机器人规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRulesRequest"/></param>
        /// <returns><see cref="DescribeWebHookRulesResponse"/></returns>
        public DescribeWebHookRulesResponse DescribeWebHookRulesSync(DescribeWebHookRulesRequest req)
        {
             JsonResponseModel<DescribeWebHookRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebHookRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebHookRulesResponse>>(strResp);
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
        /// DestroyOrder  该接口可以对资源销毁.
        /// </summary>
        /// <param name="req"><see cref="DestroyOrderRequest"/></param>
        /// <returns><see cref="DestroyOrderResponse"/></returns>
        public async Task<DestroyOrderResponse> DestroyOrder(DestroyOrderRequest req)
        {
             JsonResponseModel<DestroyOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DestroyOrder  该接口可以对资源销毁.
        /// </summary>
        /// <param name="req"><see cref="DestroyOrderRequest"/></param>
        /// <returns><see cref="DestroyOrderResponse"/></returns>
        public DestroyOrderResponse DestroyOrderSync(DestroyOrderRequest req)
        {
             JsonResponseModel<DestroyOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyOrderResponse>>(strResp);
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
        /// 新增或修改本地提权规则（支持多服务器选择）
        /// </summary>
        /// <param name="req"><see cref="EditPrivilegeRulesRequest"/></param>
        /// <returns><see cref="EditPrivilegeRulesResponse"/></returns>
        public async Task<EditPrivilegeRulesResponse> EditPrivilegeRules(EditPrivilegeRulesRequest req)
        {
             JsonResponseModel<EditPrivilegeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditPrivilegeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditPrivilegeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改本地提权规则（支持多服务器选择）
        /// </summary>
        /// <param name="req"><see cref="EditPrivilegeRulesRequest"/></param>
        /// <returns><see cref="EditPrivilegeRulesResponse"/></returns>
        public EditPrivilegeRulesResponse EditPrivilegeRulesSync(EditPrivilegeRulesRequest req)
        {
             JsonResponseModel<EditPrivilegeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EditPrivilegeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditPrivilegeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑反弹Shell规则（支持多服务器选择）
        /// </summary>
        /// <param name="req"><see cref="EditReverseShellRulesRequest"/></param>
        /// <returns><see cref="EditReverseShellRulesResponse"/></returns>
        public async Task<EditReverseShellRulesResponse> EditReverseShellRules(EditReverseShellRulesRequest req)
        {
             JsonResponseModel<EditReverseShellRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditReverseShellRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditReverseShellRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑反弹Shell规则（支持多服务器选择）
        /// </summary>
        /// <param name="req"><see cref="EditReverseShellRulesRequest"/></param>
        /// <returns><see cref="EditReverseShellRulesResponse"/></returns>
        public EditReverseShellRulesResponse EditReverseShellRulesSync(EditReverseShellRulesRequest req)
        {
             JsonResponseModel<EditReverseShellRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EditReverseShellRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditReverseShellRulesResponse>>(strResp);
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
        /// 导出资产管理应用列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetAppListRequest"/></param>
        /// <returns><see cref="ExportAssetAppListResponse"/></returns>
        public async Task<ExportAssetAppListResponse> ExportAssetAppList(ExportAssetAppListRequest req)
        {
             JsonResponseModel<ExportAssetAppListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetAppListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理应用列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetAppListRequest"/></param>
        /// <returns><see cref="ExportAssetAppListResponse"/></returns>
        public ExportAssetAppListResponse ExportAssetAppListSync(ExportAssetAppListRequest req)
        {
             JsonResponseModel<ExportAssetAppListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetAppListResponse>>(strResp);
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
        /// 导出资产管理数据库列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDatabaseListRequest"/></param>
        /// <returns><see cref="ExportAssetDatabaseListResponse"/></returns>
        public async Task<ExportAssetDatabaseListResponse> ExportAssetDatabaseList(ExportAssetDatabaseListRequest req)
        {
             JsonResponseModel<ExportAssetDatabaseListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetDatabaseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetDatabaseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理数据库列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDatabaseListRequest"/></param>
        /// <returns><see cref="ExportAssetDatabaseListResponse"/></returns>
        public ExportAssetDatabaseListResponse ExportAssetDatabaseListSync(ExportAssetDatabaseListRequest req)
        {
             JsonResponseModel<ExportAssetDatabaseListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetDatabaseList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetDatabaseListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理环境变量列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetEnvListRequest"/></param>
        /// <returns><see cref="ExportAssetEnvListResponse"/></returns>
        public async Task<ExportAssetEnvListResponse> ExportAssetEnvList(ExportAssetEnvListRequest req)
        {
             JsonResponseModel<ExportAssetEnvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetEnvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetEnvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理环境变量列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetEnvListRequest"/></param>
        /// <returns><see cref="ExportAssetEnvListResponse"/></returns>
        public ExportAssetEnvListResponse ExportAssetEnvListSync(ExportAssetEnvListRequest req)
        {
             JsonResponseModel<ExportAssetEnvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetEnvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetEnvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理启动服务列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetInitServiceListRequest"/></param>
        /// <returns><see cref="ExportAssetInitServiceListResponse"/></returns>
        public async Task<ExportAssetInitServiceListResponse> ExportAssetInitServiceList(ExportAssetInitServiceListRequest req)
        {
             JsonResponseModel<ExportAssetInitServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetInitServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetInitServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理启动服务列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetInitServiceListRequest"/></param>
        /// <returns><see cref="ExportAssetInitServiceListResponse"/></returns>
        public ExportAssetInitServiceListResponse ExportAssetInitServiceListSync(ExportAssetInitServiceListRequest req)
        {
             JsonResponseModel<ExportAssetInitServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetInitServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetInitServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出Jar包列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetJarListRequest"/></param>
        /// <returns><see cref="ExportAssetJarListResponse"/></returns>
        public async Task<ExportAssetJarListResponse> ExportAssetJarList(ExportAssetJarListRequest req)
        {
             JsonResponseModel<ExportAssetJarListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetJarList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetJarListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出Jar包列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetJarListRequest"/></param>
        /// <returns><see cref="ExportAssetJarListResponse"/></returns>
        public ExportAssetJarListResponse ExportAssetJarListSync(ExportAssetJarListRequest req)
        {
             JsonResponseModel<ExportAssetJarListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetJarList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetJarListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理主机资源详细信息
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineDetailRequest"/></param>
        /// <returns><see cref="ExportAssetMachineDetailResponse"/></returns>
        public async Task<ExportAssetMachineDetailResponse> ExportAssetMachineDetail(ExportAssetMachineDetailRequest req)
        {
             JsonResponseModel<ExportAssetMachineDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetMachineDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetMachineDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理主机资源详细信息
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineDetailRequest"/></param>
        /// <returns><see cref="ExportAssetMachineDetailResponse"/></returns>
        public ExportAssetMachineDetailResponse ExportAssetMachineDetailSync(ExportAssetMachineDetailRequest req)
        {
             JsonResponseModel<ExportAssetMachineDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetMachineDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetMachineDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资源监控列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineListRequest"/></param>
        /// <returns><see cref="ExportAssetMachineListResponse"/></returns>
        public async Task<ExportAssetMachineListResponse> ExportAssetMachineList(ExportAssetMachineListRequest req)
        {
             JsonResponseModel<ExportAssetMachineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资源监控列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineListRequest"/></param>
        /// <returns><see cref="ExportAssetMachineListResponse"/></returns>
        public ExportAssetMachineListResponse ExportAssetMachineListSync(ExportAssetMachineListRequest req)
        {
             JsonResponseModel<ExportAssetMachineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理计划任务列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="ExportAssetPlanTaskListResponse"/></returns>
        public async Task<ExportAssetPlanTaskListResponse> ExportAssetPlanTaskList(ExportAssetPlanTaskListRequest req)
        {
             JsonResponseModel<ExportAssetPlanTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetPlanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetPlanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理计划任务列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="ExportAssetPlanTaskListResponse"/></returns>
        public ExportAssetPlanTaskListResponse ExportAssetPlanTaskListSync(ExportAssetPlanTaskListRequest req)
        {
             JsonResponseModel<ExportAssetPlanTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetPlanTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetPlanTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理端口列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPortInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetPortInfoListResponse"/></returns>
        public async Task<ExportAssetPortInfoListResponse> ExportAssetPortInfoList(ExportAssetPortInfoListRequest req)
        {
             JsonResponseModel<ExportAssetPortInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetPortInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetPortInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理端口列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPortInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetPortInfoListResponse"/></returns>
        public ExportAssetPortInfoListResponse ExportAssetPortInfoListSync(ExportAssetPortInfoListRequest req)
        {
             JsonResponseModel<ExportAssetPortInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetPortInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetPortInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理进程列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetProcessInfoListResponse"/></returns>
        public async Task<ExportAssetProcessInfoListResponse> ExportAssetProcessInfoList(ExportAssetProcessInfoListRequest req)
        {
             JsonResponseModel<ExportAssetProcessInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetProcessInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetProcessInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理进程列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetProcessInfoListResponse"/></returns>
        public ExportAssetProcessInfoListResponse ExportAssetProcessInfoListSync(ExportAssetProcessInfoListRequest req)
        {
             JsonResponseModel<ExportAssetProcessInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetProcessInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetProcessInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出主机最近趋势情况（最长最近90天）
        /// </summary>
        /// <param name="req"><see cref="ExportAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="ExportAssetRecentMachineInfoResponse"/></returns>
        public async Task<ExportAssetRecentMachineInfoResponse> ExportAssetRecentMachineInfo(ExportAssetRecentMachineInfoRequest req)
        {
             JsonResponseModel<ExportAssetRecentMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetRecentMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetRecentMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出主机最近趋势情况（最长最近90天）
        /// </summary>
        /// <param name="req"><see cref="ExportAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="ExportAssetRecentMachineInfoResponse"/></returns>
        public ExportAssetRecentMachineInfoResponse ExportAssetRecentMachineInfoSync(ExportAssetRecentMachineInfoRequest req)
        {
             JsonResponseModel<ExportAssetRecentMachineInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetRecentMachineInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetRecentMachineInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理系统安装包列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="ExportAssetSystemPackageListResponse"/></returns>
        public async Task<ExportAssetSystemPackageListResponse> ExportAssetSystemPackageList(ExportAssetSystemPackageListRequest req)
        {
             JsonResponseModel<ExportAssetSystemPackageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetSystemPackageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetSystemPackageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理系统安装包列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="ExportAssetSystemPackageListResponse"/></returns>
        public ExportAssetSystemPackageListResponse ExportAssetSystemPackageListSync(ExportAssetSystemPackageListRequest req)
        {
             JsonResponseModel<ExportAssetSystemPackageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetSystemPackageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetSystemPackageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出账号列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetUserListRequest"/></param>
        /// <returns><see cref="ExportAssetUserListResponse"/></returns>
        public async Task<ExportAssetUserListResponse> ExportAssetUserList(ExportAssetUserListRequest req)
        {
             JsonResponseModel<ExportAssetUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出账号列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetUserListRequest"/></param>
        /// <returns><see cref="ExportAssetUserListResponse"/></returns>
        public ExportAssetUserListResponse ExportAssetUserListSync(ExportAssetUserListRequest req)
        {
             JsonResponseModel<ExportAssetUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理Web应用列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebAppListRequest"/></param>
        /// <returns><see cref="ExportAssetWebAppListResponse"/></returns>
        public async Task<ExportAssetWebAppListResponse> ExportAssetWebAppList(ExportAssetWebAppListRequest req)
        {
             JsonResponseModel<ExportAssetWebAppListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetWebAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebAppListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理Web应用列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebAppListRequest"/></param>
        /// <returns><see cref="ExportAssetWebAppListResponse"/></returns>
        public ExportAssetWebAppListResponse ExportAssetWebAppListSync(ExportAssetWebAppListRequest req)
        {
             JsonResponseModel<ExportAssetWebAppListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetWebAppList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebAppListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理Web框架列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebFrameListRequest"/></param>
        /// <returns><see cref="ExportAssetWebFrameListResponse"/></returns>
        public async Task<ExportAssetWebFrameListResponse> ExportAssetWebFrameList(ExportAssetWebFrameListRequest req)
        {
             JsonResponseModel<ExportAssetWebFrameListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetWebFrameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebFrameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出资产管理Web框架列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebFrameListRequest"/></param>
        /// <returns><see cref="ExportAssetWebFrameListResponse"/></returns>
        public ExportAssetWebFrameListResponse ExportAssetWebFrameListSync(ExportAssetWebFrameListRequest req)
        {
             JsonResponseModel<ExportAssetWebFrameListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetWebFrameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebFrameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出Web站点列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebLocationListRequest"/></param>
        /// <returns><see cref="ExportAssetWebLocationListResponse"/></returns>
        public async Task<ExportAssetWebLocationListResponse> ExportAssetWebLocationList(ExportAssetWebLocationListRequest req)
        {
             JsonResponseModel<ExportAssetWebLocationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetWebLocationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebLocationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出Web站点列表
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebLocationListRequest"/></param>
        /// <returns><see cref="ExportAssetWebLocationListResponse"/></returns>
        public ExportAssetWebLocationListResponse ExportAssetWebLocationListSync(ExportAssetWebLocationListRequest req)
        {
             JsonResponseModel<ExportAssetWebLocationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetWebLocationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetWebLocationListResponse>>(strResp);
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
        /// 导出网络攻击事件
        /// </summary>
        /// <param name="req"><see cref="ExportAttackEventsRequest"/></param>
        /// <returns><see cref="ExportAttackEventsResponse"/></returns>
        public async Task<ExportAttackEventsResponse> ExportAttackEvents(ExportAttackEventsRequest req)
        {
             JsonResponseModel<ExportAttackEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAttackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAttackEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出网络攻击事件
        /// </summary>
        /// <param name="req"><see cref="ExportAttackEventsRequest"/></param>
        /// <returns><see cref="ExportAttackEventsResponse"/></returns>
        public ExportAttackEventsResponse ExportAttackEventsSync(ExportAttackEventsRequest req)
        {
             JsonResponseModel<ExportAttackEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAttackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAttackEventsResponse>>(strResp);
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
        /// 导出修复列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineFixListRequest"/></param>
        /// <returns><see cref="ExportBaselineFixListResponse"/></returns>
        public async Task<ExportBaselineFixListResponse> ExportBaselineFixList(ExportBaselineFixListRequest req)
        {
             JsonResponseModel<ExportBaselineFixListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineFixList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineFixListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出修复列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineFixListRequest"/></param>
        /// <returns><see cref="ExportBaselineFixListResponse"/></returns>
        public ExportBaselineFixListResponse ExportBaselineFixListSync(ExportBaselineFixListRequest req)
        {
             JsonResponseModel<ExportBaselineFixListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineFixList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineFixListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线主机检测
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineHostDetectListResponse"/></returns>
        public async Task<ExportBaselineHostDetectListResponse> ExportBaselineHostDetectList(ExportBaselineHostDetectListRequest req)
        {
             JsonResponseModel<ExportBaselineHostDetectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineHostDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineHostDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线主机检测
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineHostDetectListResponse"/></returns>
        public ExportBaselineHostDetectListResponse ExportBaselineHostDetectListSync(ExportBaselineHostDetectListRequest req)
        {
             JsonResponseModel<ExportBaselineHostDetectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineHostDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineHostDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线检测项
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineItemDetectListResponse"/></returns>
        public async Task<ExportBaselineItemDetectListResponse> ExportBaselineItemDetectList(ExportBaselineItemDetectListRequest req)
        {
             JsonResponseModel<ExportBaselineItemDetectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineItemDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineItemDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线检测项
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineItemDetectListResponse"/></returns>
        public ExportBaselineItemDetectListResponse ExportBaselineItemDetectListSync(ExportBaselineItemDetectListRequest req)
        {
             JsonResponseModel<ExportBaselineItemDetectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineItemDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineItemDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出检测项结果列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineItemListRequest"/></param>
        /// <returns><see cref="ExportBaselineItemListResponse"/></returns>
        public async Task<ExportBaselineItemListResponse> ExportBaselineItemList(ExportBaselineItemListRequest req)
        {
             JsonResponseModel<ExportBaselineItemListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出检测项结果列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineItemListRequest"/></param>
        /// <returns><see cref="ExportBaselineItemListResponse"/></returns>
        public ExportBaselineItemListResponse ExportBaselineItemListSync(ExportBaselineItemListRequest req)
        {
             JsonResponseModel<ExportBaselineItemListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineItemListResponse>>(strResp);
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
        /// 导出基线检测规则
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineRuleDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineRuleDetectListResponse"/></returns>
        public async Task<ExportBaselineRuleDetectListResponse> ExportBaselineRuleDetectList(ExportBaselineRuleDetectListRequest req)
        {
             JsonResponseModel<ExportBaselineRuleDetectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineRuleDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineRuleDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出基线检测规则
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineRuleDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineRuleDetectListResponse"/></returns>
        public ExportBaselineRuleDetectListResponse ExportBaselineRuleDetectListSync(ExportBaselineRuleDetectListRequest req)
        {
             JsonResponseModel<ExportBaselineRuleDetectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineRuleDetectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineRuleDetectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出弱口令配置列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineWeakPasswordListRequest"/></param>
        /// <returns><see cref="ExportBaselineWeakPasswordListResponse"/></returns>
        public async Task<ExportBaselineWeakPasswordListResponse> ExportBaselineWeakPasswordList(ExportBaselineWeakPasswordListRequest req)
        {
             JsonResponseModel<ExportBaselineWeakPasswordListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBaselineWeakPasswordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineWeakPasswordListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出弱口令配置列表
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineWeakPasswordListRequest"/></param>
        /// <returns><see cref="ExportBaselineWeakPasswordListResponse"/></returns>
        public ExportBaselineWeakPasswordListResponse ExportBaselineWeakPasswordListSync(ExportBaselineWeakPasswordListRequest req)
        {
             JsonResponseModel<ExportBaselineWeakPasswordListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBaselineWeakPasswordList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBaselineWeakPasswordListResponse>>(strResp);
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
        /// 导出高危命令事件(新)
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsNewRequest"/></param>
        /// <returns><see cref="ExportBashEventsNewResponse"/></returns>
        public async Task<ExportBashEventsNewResponse> ExportBashEventsNew(ExportBashEventsNewRequest req)
        {
             JsonResponseModel<ExportBashEventsNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBashEventsNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBashEventsNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出高危命令事件(新)
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsNewRequest"/></param>
        /// <returns><see cref="ExportBashEventsNewResponse"/></returns>
        public ExportBashEventsNewResponse ExportBashEventsNewSync(ExportBashEventsNewRequest req)
        {
             JsonResponseModel<ExportBashEventsNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBashEventsNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBashEventsNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出高危命令策略
        /// </summary>
        /// <param name="req"><see cref="ExportBashPoliciesRequest"/></param>
        /// <returns><see cref="ExportBashPoliciesResponse"/></returns>
        public async Task<ExportBashPoliciesResponse> ExportBashPolicies(ExportBashPoliciesRequest req)
        {
             JsonResponseModel<ExportBashPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportBashPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBashPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出高危命令策略
        /// </summary>
        /// <param name="req"><see cref="ExportBashPoliciesRequest"/></param>
        /// <returns><see cref="ExportBashPoliciesResponse"/></returns>
        public ExportBashPoliciesResponse ExportBashPoliciesSync(ExportBashPoliciesRequest req)
        {
             JsonResponseModel<ExportBashPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportBashPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportBashPoliciesResponse>>(strResp);
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
        /// 导出核心文件事件
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperEventsRequest"/></param>
        /// <returns><see cref="ExportFileTamperEventsResponse"/></returns>
        public async Task<ExportFileTamperEventsResponse> ExportFileTamperEvents(ExportFileTamperEventsRequest req)
        {
             JsonResponseModel<ExportFileTamperEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportFileTamperEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportFileTamperEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出核心文件事件
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperEventsRequest"/></param>
        /// <returns><see cref="ExportFileTamperEventsResponse"/></returns>
        public ExportFileTamperEventsResponse ExportFileTamperEventsSync(ExportFileTamperEventsRequest req)
        {
             JsonResponseModel<ExportFileTamperEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportFileTamperEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportFileTamperEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出核心文件监控规则
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperRulesRequest"/></param>
        /// <returns><see cref="ExportFileTamperRulesResponse"/></returns>
        public async Task<ExportFileTamperRulesResponse> ExportFileTamperRules(ExportFileTamperRulesRequest req)
        {
             JsonResponseModel<ExportFileTamperRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportFileTamperRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportFileTamperRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出核心文件监控规则
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperRulesRequest"/></param>
        /// <returns><see cref="ExportFileTamperRulesResponse"/></returns>
        public ExportFileTamperRulesResponse ExportFileTamperRulesSync(ExportFileTamperRulesRequest req)
        {
             JsonResponseModel<ExportFileTamperRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportFileTamperRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportFileTamperRulesResponse>>(strResp);
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
        /// 导出java内存马插件信息
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellPluginsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellPluginsResponse"/></returns>
        public async Task<ExportJavaMemShellPluginsResponse> ExportJavaMemShellPlugins(ExportJavaMemShellPluginsRequest req)
        {
             JsonResponseModel<ExportJavaMemShellPluginsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportJavaMemShellPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportJavaMemShellPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出java内存马插件信息
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellPluginsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellPluginsResponse"/></returns>
        public ExportJavaMemShellPluginsResponse ExportJavaMemShellPluginsSync(ExportJavaMemShellPluginsRequest req)
        {
             JsonResponseModel<ExportJavaMemShellPluginsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportJavaMemShellPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportJavaMemShellPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出java内存马事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellsResponse"/></returns>
        public async Task<ExportJavaMemShellsResponse> ExportJavaMemShells(ExportJavaMemShellsRequest req)
        {
             JsonResponseModel<ExportJavaMemShellsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportJavaMemShells");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportJavaMemShellsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出java内存马事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellsResponse"/></returns>
        public ExportJavaMemShellsResponse ExportJavaMemShellsSync(ExportJavaMemShellsRequest req)
        {
             JsonResponseModel<ExportJavaMemShellsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportJavaMemShells");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportJavaMemShellsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出授权列表对应的绑定信息
        /// </summary>
        /// <param name="req"><see cref="ExportLicenseDetailRequest"/></param>
        /// <returns><see cref="ExportLicenseDetailResponse"/></returns>
        public async Task<ExportLicenseDetailResponse> ExportLicenseDetail(ExportLicenseDetailRequest req)
        {
             JsonResponseModel<ExportLicenseDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportLicenseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportLicenseDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出授权列表对应的绑定信息
        /// </summary>
        /// <param name="req"><see cref="ExportLicenseDetailRequest"/></param>
        /// <returns><see cref="ExportLicenseDetailResponse"/></returns>
        public ExportLicenseDetailResponse ExportLicenseDetailSync(ExportLicenseDetailRequest req)
        {
             JsonResponseModel<ExportLicenseDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportLicenseDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportLicenseDetailResponse>>(strResp);
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
        /// 导出主机快照备份列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseBackupListResponse"/></returns>
        public async Task<ExportRansomDefenseBackupListResponse> ExportRansomDefenseBackupList(ExportRansomDefenseBackupListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseBackupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRansomDefenseBackupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseBackupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出主机快照备份列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseBackupListResponse"/></returns>
        public ExportRansomDefenseBackupListResponse ExportRansomDefenseBackupListSync(ExportRansomDefenseBackupListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseBackupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRansomDefenseBackupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseBackupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出防勒索事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseEventsListResponse"/></returns>
        public async Task<ExportRansomDefenseEventsListResponse> ExportRansomDefenseEventsList(ExportRansomDefenseEventsListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseEventsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRansomDefenseEventsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseEventsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出防勒索事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseEventsListResponse"/></returns>
        public ExportRansomDefenseEventsListResponse ExportRansomDefenseEventsListSync(ExportRansomDefenseEventsListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseEventsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRansomDefenseEventsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseEventsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出备份详情列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseMachineListResponse"/></returns>
        public async Task<ExportRansomDefenseMachineListResponse> ExportRansomDefenseMachineList(ExportRansomDefenseMachineListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseMachineListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRansomDefenseMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出备份详情列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseMachineListResponse"/></returns>
        public ExportRansomDefenseMachineListResponse ExportRansomDefenseMachineListSync(ExportRansomDefenseMachineListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseMachineListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRansomDefenseMachineList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseMachineListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出防勒索策略列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyListResponse"/></returns>
        public async Task<ExportRansomDefenseStrategyListResponse> ExportRansomDefenseStrategyList(ExportRansomDefenseStrategyListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseStrategyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRansomDefenseStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseStrategyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出防勒索策略列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyListResponse"/></returns>
        public ExportRansomDefenseStrategyListResponse ExportRansomDefenseStrategyListSync(ExportRansomDefenseStrategyListRequest req)
        {
             JsonResponseModel<ExportRansomDefenseStrategyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRansomDefenseStrategyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseStrategyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出勒索防御策略绑定机器列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyMachinesResponse"/></returns>
        public async Task<ExportRansomDefenseStrategyMachinesResponse> ExportRansomDefenseStrategyMachines(ExportRansomDefenseStrategyMachinesRequest req)
        {
             JsonResponseModel<ExportRansomDefenseStrategyMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRansomDefenseStrategyMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseStrategyMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出勒索防御策略绑定机器列表
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyMachinesResponse"/></returns>
        public ExportRansomDefenseStrategyMachinesResponse ExportRansomDefenseStrategyMachinesSync(ExportRansomDefenseStrategyMachinesRequest req)
        {
             JsonResponseModel<ExportRansomDefenseStrategyMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRansomDefenseStrategyMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRansomDefenseStrategyMachinesResponse>>(strResp);
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
        /// 导出恶意请求事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsEventListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsEventListResponse"/></returns>
        public async Task<ExportRiskDnsEventListResponse> ExportRiskDnsEventList(ExportRiskDnsEventListRequest req)
        {
             JsonResponseModel<ExportRiskDnsEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRiskDnsEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRiskDnsEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出恶意请求事件列表
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsEventListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsEventListResponse"/></returns>
        public ExportRiskDnsEventListResponse ExportRiskDnsEventListSync(ExportRiskDnsEventListRequest req)
        {
             JsonResponseModel<ExportRiskDnsEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRiskDnsEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRiskDnsEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出恶意请求策略列表
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsPolicyListResponse"/></returns>
        public async Task<ExportRiskDnsPolicyListResponse> ExportRiskDnsPolicyList(ExportRiskDnsPolicyListRequest req)
        {
             JsonResponseModel<ExportRiskDnsPolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRiskDnsPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRiskDnsPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出恶意请求策略列表
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsPolicyListResponse"/></returns>
        public ExportRiskDnsPolicyListResponse ExportRiskDnsPolicyListSync(ExportRiskDnsPolicyListRequest req)
        {
             JsonResponseModel<ExportRiskDnsPolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRiskDnsPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRiskDnsPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出异常进程事件
        /// </summary>
        /// <param name="req"><see cref="ExportRiskProcessEventsRequest"/></param>
        /// <returns><see cref="ExportRiskProcessEventsResponse"/></returns>
        public async Task<ExportRiskProcessEventsResponse> ExportRiskProcessEvents(ExportRiskProcessEventsRequest req)
        {
             JsonResponseModel<ExportRiskProcessEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportRiskProcessEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRiskProcessEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出异常进程事件
        /// </summary>
        /// <param name="req"><see cref="ExportRiskProcessEventsRequest"/></param>
        /// <returns><see cref="ExportRiskProcessEventsResponse"/></returns>
        public ExportRiskProcessEventsResponse ExportRiskProcessEventsSync(ExportRiskProcessEventsRequest req)
        {
             JsonResponseModel<ExportRiskProcessEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportRiskProcessEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportRiskProcessEventsResponse>>(strResp);
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
        /// 导出漏洞防御事件
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceEventRequest"/></param>
        /// <returns><see cref="ExportVulDefenceEventResponse"/></returns>
        public async Task<ExportVulDefenceEventResponse> ExportVulDefenceEvent(ExportVulDefenceEventRequest req)
        {
             JsonResponseModel<ExportVulDefenceEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulDefenceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDefenceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞防御事件
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceEventRequest"/></param>
        /// <returns><see cref="ExportVulDefenceEventResponse"/></returns>
        public ExportVulDefenceEventResponse ExportVulDefenceEventSync(ExportVulDefenceEventRequest req)
        {
             JsonResponseModel<ExportVulDefenceEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulDefenceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDefenceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞防御列表
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceListRequest"/></param>
        /// <returns><see cref="ExportVulDefenceListResponse"/></returns>
        public async Task<ExportVulDefenceListResponse> ExportVulDefenceList(ExportVulDefenceListRequest req)
        {
             JsonResponseModel<ExportVulDefenceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulDefenceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDefenceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞防御列表
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceListRequest"/></param>
        /// <returns><see cref="ExportVulDefenceListResponse"/></returns>
        public ExportVulDefenceListResponse ExportVulDefenceListSync(ExportVulDefenceListRequest req)
        {
             JsonResponseModel<ExportVulDefenceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulDefenceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDefenceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞防御插件事件
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefencePluginEventRequest"/></param>
        /// <returns><see cref="ExportVulDefencePluginEventResponse"/></returns>
        public async Task<ExportVulDefencePluginEventResponse> ExportVulDefencePluginEvent(ExportVulDefencePluginEventRequest req)
        {
             JsonResponseModel<ExportVulDefencePluginEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulDefencePluginEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDefencePluginEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞防御插件事件
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefencePluginEventRequest"/></param>
        /// <returns><see cref="ExportVulDefencePluginEventResponse"/></returns>
        public ExportVulDefencePluginEventResponse ExportVulDefencePluginEventSync(ExportVulDefencePluginEventRequest req)
        {
             JsonResponseModel<ExportVulDefencePluginEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulDefencePluginEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulDefencePluginEventResponse>>(strResp);
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
        /// 导出漏洞信息，包括影响主机列表，组件信息
        /// </summary>
        /// <param name="req"><see cref="ExportVulInfoRequest"/></param>
        /// <returns><see cref="ExportVulInfoResponse"/></returns>
        public async Task<ExportVulInfoResponse> ExportVulInfo(ExportVulInfoRequest req)
        {
             JsonResponseModel<ExportVulInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVulInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出漏洞信息，包括影响主机列表，组件信息
        /// </summary>
        /// <param name="req"><see cref="ExportVulInfoRequest"/></param>
        /// <returns><see cref="ExportVulInfoResponse"/></returns>
        public ExportVulInfoResponse ExportVulInfoSync(ExportVulInfoRequest req)
        {
             JsonResponseModel<ExportVulInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVulInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVulInfoResponse>>(strResp);
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
        /// 修复基线检测
        /// </summary>
        /// <param name="req"><see cref="FixBaselineDetectRequest"/></param>
        /// <returns><see cref="FixBaselineDetectResponse"/></returns>
        public async Task<FixBaselineDetectResponse> FixBaselineDetect(FixBaselineDetectRequest req)
        {
             JsonResponseModel<FixBaselineDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FixBaselineDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FixBaselineDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修复基线检测
        /// </summary>
        /// <param name="req"><see cref="FixBaselineDetectRequest"/></param>
        /// <returns><see cref="FixBaselineDetectResponse"/></returns>
        public FixBaselineDetectResponse FixBaselineDetectSync(FixBaselineDetectRequest req)
        {
             JsonResponseModel<FixBaselineDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FixBaselineDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FixBaselineDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本地存储数据
        /// </summary>
        /// <param name="req"><see cref="GetLocalStorageItemRequest"/></param>
        /// <returns><see cref="GetLocalStorageItemResponse"/></returns>
        public async Task<GetLocalStorageItemResponse> GetLocalStorageItem(GetLocalStorageItemRequest req)
        {
             JsonResponseModel<GetLocalStorageItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLocalStorageItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLocalStorageItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本地存储数据
        /// </summary>
        /// <param name="req"><see cref="GetLocalStorageItemRequest"/></param>
        /// <returns><see cref="GetLocalStorageItemResponse"/></returns>
        public GetLocalStorageItemResponse GetLocalStorageItemSync(GetLocalStorageItemRequest req)
        {
             JsonResponseModel<GetLocalStorageItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLocalStorageItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLocalStorageItemResponse>>(strResp);
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
        /// 获取本地存储键值列表
        /// </summary>
        /// <param name="req"><see cref="KeysLocalStorageRequest"/></param>
        /// <returns><see cref="KeysLocalStorageResponse"/></returns>
        public async Task<KeysLocalStorageResponse> KeysLocalStorage(KeysLocalStorageRequest req)
        {
             JsonResponseModel<KeysLocalStorageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KeysLocalStorage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KeysLocalStorageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本地存储键值列表
        /// </summary>
        /// <param name="req"><see cref="KeysLocalStorageRequest"/></param>
        /// <returns><see cref="KeysLocalStorageResponse"/></returns>
        public KeysLocalStorageResponse KeysLocalStorageSync(KeysLocalStorageRequest req)
        {
             JsonResponseModel<KeysLocalStorageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KeysLocalStorage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KeysLocalStorageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  用于设置新增主机自动开通专业防护配置。
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
        ///  用于设置新增主机自动开通专业防护配置。
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
        /// 修改阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyBanWhiteListRequest"/></param>
        /// <returns><see cref="ModifyBanWhiteListResponse"/></returns>
        public async Task<ModifyBanWhiteListResponse> ModifyBanWhiteList(ModifyBanWhiteListRequest req)
        {
             JsonResponseModel<ModifyBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBanWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改阻断白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyBanWhiteListRequest"/></param>
        /// <returns><see cref="ModifyBanWhiteListResponse"/></returns>
        public ModifyBanWhiteListResponse ModifyBanWhiteListSync(ModifyBanWhiteListRequest req)
        {
             JsonResponseModel<ModifyBanWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBanWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBanWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线策略设置
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public async Task<ModifyBaselinePolicyResponse> ModifyBaselinePolicy(ModifyBaselinePolicyRequest req)
        {
             JsonResponseModel<ModifyBaselinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBaselinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线策略设置
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public ModifyBaselinePolicyResponse ModifyBaselinePolicySync(ModifyBaselinePolicyRequest req)
        {
             JsonResponseModel<ModifyBaselinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBaselinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyStateRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyStateResponse"/></returns>
        public async Task<ModifyBaselinePolicyStateResponse> ModifyBaselinePolicyState(ModifyBaselinePolicyStateRequest req)
        {
             JsonResponseModel<ModifyBaselinePolicyStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBaselinePolicyState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselinePolicyStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyStateRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyStateResponse"/></returns>
        public ModifyBaselinePolicyStateResponse ModifyBaselinePolicyStateSync(ModifyBaselinePolicyStateRequest req)
        {
             JsonResponseModel<ModifyBaselinePolicyStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBaselinePolicyState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselinePolicyStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线检测规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineRuleRequest"/></param>
        /// <returns><see cref="ModifyBaselineRuleResponse"/></returns>
        public async Task<ModifyBaselineRuleResponse> ModifyBaselineRule(ModifyBaselineRuleRequest req)
        {
             JsonResponseModel<ModifyBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线检测规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineRuleRequest"/></param>
        /// <returns><see cref="ModifyBaselineRuleResponse"/></returns>
        public ModifyBaselineRuleResponse ModifyBaselineRuleSync(ModifyBaselineRuleRequest req)
        {
             JsonResponseModel<ModifyBaselineRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBaselineRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselineRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线忽略规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineRuleIgnoreRequest"/></param>
        /// <returns><see cref="ModifyBaselineRuleIgnoreResponse"/></returns>
        public async Task<ModifyBaselineRuleIgnoreResponse> ModifyBaselineRuleIgnore(ModifyBaselineRuleIgnoreRequest req)
        {
             JsonResponseModel<ModifyBaselineRuleIgnoreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBaselineRuleIgnore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselineRuleIgnoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改基线忽略规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineRuleIgnoreRequest"/></param>
        /// <returns><see cref="ModifyBaselineRuleIgnoreResponse"/></returns>
        public ModifyBaselineRuleIgnoreResponse ModifyBaselineRuleIgnoreSync(ModifyBaselineRuleIgnoreRequest req)
        {
             JsonResponseModel<ModifyBaselineRuleIgnoreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBaselineRuleIgnore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselineRuleIgnoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改或新增弱口令
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineWeakPasswordRequest"/></param>
        /// <returns><see cref="ModifyBaselineWeakPasswordResponse"/></returns>
        public async Task<ModifyBaselineWeakPasswordResponse> ModifyBaselineWeakPassword(ModifyBaselineWeakPasswordRequest req)
        {
             JsonResponseModel<ModifyBaselineWeakPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBaselineWeakPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselineWeakPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改或新增弱口令
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineWeakPasswordRequest"/></param>
        /// <returns><see cref="ModifyBaselineWeakPasswordResponse"/></returns>
        public ModifyBaselineWeakPasswordResponse ModifyBaselineWeakPasswordSync(ModifyBaselineWeakPasswordRequest req)
        {
             JsonResponseModel<ModifyBaselineWeakPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBaselineWeakPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaselineWeakPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改高危命令策略
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyResponse"/></returns>
        public async Task<ModifyBashPolicyResponse> ModifyBashPolicy(ModifyBashPolicyRequest req)
        {
             JsonResponseModel<ModifyBashPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBashPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBashPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改高危命令策略
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyResponse"/></returns>
        public ModifyBashPolicyResponse ModifyBashPolicySync(ModifyBashPolicyRequest req)
        {
             JsonResponseModel<ModifyBashPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBashPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBashPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换高危命令策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyStatusResponse"/></returns>
        public async Task<ModifyBashPolicyStatusResponse> ModifyBashPolicyStatus(ModifyBashPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyBashPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBashPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBashPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换高危命令策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyStatusResponse"/></returns>
        public ModifyBashPolicyStatusResponse ModifyBashPolicyStatusSync(ModifyBashPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyBashPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBashPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBashPolicyStatusResponse>>(strResp);
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
        /// 修改网络攻击事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEventAttackStatusRequest"/></param>
        /// <returns><see cref="ModifyEventAttackStatusResponse"/></returns>
        public async Task<ModifyEventAttackStatusResponse> ModifyEventAttackStatus(ModifyEventAttackStatusRequest req)
        {
             JsonResponseModel<ModifyEventAttackStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEventAttackStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEventAttackStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改网络攻击事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEventAttackStatusRequest"/></param>
        /// <returns><see cref="ModifyEventAttackStatusResponse"/></returns>
        public ModifyEventAttackStatusResponse ModifyEventAttackStatusSync(ModifyEventAttackStatusRequest req)
        {
             JsonResponseModel<ModifyEventAttackStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEventAttackStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEventAttackStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件事件更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperEventsRequest"/></param>
        /// <returns><see cref="ModifyFileTamperEventsResponse"/></returns>
        public async Task<ModifyFileTamperEventsResponse> ModifyFileTamperEvents(ModifyFileTamperEventsRequest req)
        {
             JsonResponseModel<ModifyFileTamperEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFileTamperEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileTamperEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件事件更新
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperEventsRequest"/></param>
        /// <returns><see cref="ModifyFileTamperEventsResponse"/></returns>
        public ModifyFileTamperEventsResponse ModifyFileTamperEventsSync(ModifyFileTamperEventsRequest req)
        {
             JsonResponseModel<ModifyFileTamperEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFileTamperEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileTamperEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑、新增核心文件监控规则
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleResponse"/></returns>
        public async Task<ModifyFileTamperRuleResponse> ModifyFileTamperRule(ModifyFileTamperRuleRequest req)
        {
             JsonResponseModel<ModifyFileTamperRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFileTamperRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileTamperRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑、新增核心文件监控规则
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleResponse"/></returns>
        public ModifyFileTamperRuleResponse ModifyFileTamperRuleSync(ModifyFileTamperRuleRequest req)
        {
             JsonResponseModel<ModifyFileTamperRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFileTamperRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileTamperRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件规则状态更新，支持批量删除 关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleStatusResponse"/></returns>
        public async Task<ModifyFileTamperRuleStatusResponse> ModifyFileTamperRuleStatus(ModifyFileTamperRuleStatusRequest req)
        {
             JsonResponseModel<ModifyFileTamperRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFileTamperRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileTamperRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核心文件规则状态更新，支持批量删除 关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleStatusResponse"/></returns>
        public ModifyFileTamperRuleStatusResponse ModifyFileTamperRuleStatusSync(ModifyFileTamperRuleStatusRequest req)
        {
             JsonResponseModel<ModifyFileTamperRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFileTamperRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileTamperRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开关java内存马插件
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellPluginSwitchRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellPluginSwitchResponse"/></returns>
        public async Task<ModifyJavaMemShellPluginSwitchResponse> ModifyJavaMemShellPluginSwitch(ModifyJavaMemShellPluginSwitchRequest req)
        {
             JsonResponseModel<ModifyJavaMemShellPluginSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyJavaMemShellPluginSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyJavaMemShellPluginSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开关java内存马插件
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellPluginSwitchRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellPluginSwitchResponse"/></returns>
        public ModifyJavaMemShellPluginSwitchResponse ModifyJavaMemShellPluginSwitchSync(ModifyJavaMemShellPluginSwitchRequest req)
        {
             JsonResponseModel<ModifyJavaMemShellPluginSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyJavaMemShellPluginSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyJavaMemShellPluginSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改java内存马事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellsStatusRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellsStatusResponse"/></returns>
        public async Task<ModifyJavaMemShellsStatusResponse> ModifyJavaMemShellsStatus(ModifyJavaMemShellsStatusRequest req)
        {
             JsonResponseModel<ModifyJavaMemShellsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyJavaMemShellsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyJavaMemShellsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改java内存马事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellsStatusRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellsStatusResponse"/></returns>
        public ModifyJavaMemShellsStatusResponse ModifyJavaMemShellsStatusSync(ModifyJavaMemShellsStatusRequest req)
        {
             JsonResponseModel<ModifyJavaMemShellsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyJavaMemShellsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyJavaMemShellsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置中心-授权管理 对某个授权批量绑定机器
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyLicenseBindsResponse"/></returns>
        public async Task<ModifyLicenseBindsResponse> ModifyLicenseBinds(ModifyLicenseBindsRequest req)
        {
             JsonResponseModel<ModifyLicenseBindsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLicenseBinds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLicenseBindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置中心-授权管理 对某个授权批量绑定机器
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyLicenseBindsResponse"/></returns>
        public ModifyLicenseBindsResponse ModifyLicenseBindsSync(ModifyLicenseBindsRequest req)
        {
             JsonResponseModel<ModifyLicenseBindsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLicenseBinds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLicenseBindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑《主机安全-按量计费》授权订单
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseOrderRequest"/></param>
        /// <returns><see cref="ModifyLicenseOrderResponse"/></returns>
        public async Task<ModifyLicenseOrderResponse> ModifyLicenseOrder(ModifyLicenseOrderRequest req)
        {
             JsonResponseModel<ModifyLicenseOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLicenseOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLicenseOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑《主机安全-按量计费》授权订单
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseOrderRequest"/></param>
        /// <returns><see cref="ModifyLicenseOrderResponse"/></returns>
        public ModifyLicenseOrderResponse ModifyLicenseOrderSync(ModifyLicenseOrderRequest req)
        {
             JsonResponseModel<ModifyLicenseOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLicenseOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLicenseOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置中心-授权管理 对某个授权批量解绑机器
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyLicenseUnBindsResponse"/></returns>
        public async Task<ModifyLicenseUnBindsResponse> ModifyLicenseUnBinds(ModifyLicenseUnBindsRequest req)
        {
             JsonResponseModel<ModifyLicenseUnBindsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLicenseUnBinds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLicenseUnBindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置中心-授权管理 对某个授权批量解绑机器
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyLicenseUnBindsResponse"/></returns>
        public ModifyLicenseUnBindsResponse ModifyLicenseUnBindsSync(ModifyLicenseUnBindsRequest req)
        {
             JsonResponseModel<ModifyLicenseUnBindsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLicenseUnBinds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLicenseUnBindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改日志投递kafka接入配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaAccessRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaAccessResponse"/></returns>
        public async Task<ModifyLogKafkaAccessResponse> ModifyLogKafkaAccess(ModifyLogKafkaAccessRequest req)
        {
             JsonResponseModel<ModifyLogKafkaAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogKafkaAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogKafkaAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改日志投递kafka接入配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaAccessRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaAccessResponse"/></returns>
        public ModifyLogKafkaAccessResponse ModifyLogKafkaAccessSync(ModifyLogKafkaAccessRequest req)
        {
             JsonResponseModel<ModifyLogKafkaAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogKafkaAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogKafkaAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定日志类别投递配置、开关
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaDeliverTypeRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaDeliverTypeResponse"/></returns>
        public async Task<ModifyLogKafkaDeliverTypeResponse> ModifyLogKafkaDeliverType(ModifyLogKafkaDeliverTypeRequest req)
        {
             JsonResponseModel<ModifyLogKafkaDeliverTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogKafkaDeliverType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogKafkaDeliverTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定日志类别投递配置、开关
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaDeliverTypeRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaDeliverTypeResponse"/></returns>
        public ModifyLogKafkaDeliverTypeResponse ModifyLogKafkaDeliverTypeSync(ModifyLogKafkaDeliverTypeRequest req)
        {
             JsonResponseModel<ModifyLogKafkaDeliverTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogKafkaDeliverType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogKafkaDeliverTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改日志投递状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaStateRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaStateResponse"/></returns>
        public async Task<ModifyLogKafkaStateResponse> ModifyLogKafkaState(ModifyLogKafkaStateRequest req)
        {
             JsonResponseModel<ModifyLogKafkaStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogKafkaState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogKafkaStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改日志投递状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaStateRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaStateResponse"/></returns>
        public ModifyLogKafkaStateResponse ModifyLogKafkaStateSync(ModifyLogKafkaStateRequest req)
        {
             JsonResponseModel<ModifyLogKafkaStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogKafkaState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogKafkaStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改日志存储配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLogStorageConfigRequest"/></param>
        /// <returns><see cref="ModifyLogStorageConfigResponse"/></returns>
        public async Task<ModifyLogStorageConfigResponse> ModifyLogStorageConfig(ModifyLogStorageConfigRequest req)
        {
             JsonResponseModel<ModifyLogStorageConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogStorageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogStorageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改日志存储配置
        /// </summary>
        /// <param name="req"><see cref="ModifyLogStorageConfigRequest"/></param>
        /// <returns><see cref="ModifyLogStorageConfigResponse"/></returns>
        public ModifyLogStorageConfigResponse ModifyLogStorageConfigSync(ModifyLogStorageConfigRequest req)
        {
             JsonResponseModel<ModifyLogStorageConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogStorageConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogStorageConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新登录审计白名单信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteInfoRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteInfoResponse"/></returns>
        public async Task<ModifyLoginWhiteInfoResponse> ModifyLoginWhiteInfo(ModifyLoginWhiteInfoRequest req)
        {
             JsonResponseModel<ModifyLoginWhiteInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoginWhiteInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoginWhiteInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新登录审计白名单信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteInfoRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteInfoResponse"/></returns>
        public ModifyLoginWhiteInfoResponse ModifyLoginWhiteInfoSync(ModifyLoginWhiteInfoRequest req)
        {
             JsonResponseModel<ModifyLoginWhiteInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoginWhiteInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoginWhiteInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新合并后登录审计白名单信息（服务器列表数目应小于1000）
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteRecordRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteRecordResponse"/></returns>
        public async Task<ModifyLoginWhiteRecordResponse> ModifyLoginWhiteRecord(ModifyLoginWhiteRecordRequest req)
        {
             JsonResponseModel<ModifyLoginWhiteRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoginWhiteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoginWhiteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新合并后登录审计白名单信息（服务器列表数目应小于1000）
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteRecordRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteRecordResponse"/></returns>
        public ModifyLoginWhiteRecordResponse ModifyLoginWhiteRecordSync(ModifyLoginWhiteRecordRequest req)
        {
             JsonResponseModel<ModifyLoginWhiteRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoginWhiteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoginWhiteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机器清理配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineAutoClearConfigRequest"/></param>
        /// <returns><see cref="ModifyMachineAutoClearConfigResponse"/></returns>
        public async Task<ModifyMachineAutoClearConfigResponse> ModifyMachineAutoClearConfig(ModifyMachineAutoClearConfigRequest req)
        {
             JsonResponseModel<ModifyMachineAutoClearConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMachineAutoClearConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineAutoClearConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机器清理配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineAutoClearConfigRequest"/></param>
        /// <returns><see cref="ModifyMachineAutoClearConfigResponse"/></returns>
        public ModifyMachineAutoClearConfigResponse ModifyMachineAutoClearConfigSync(ModifyMachineAutoClearConfigRequest req)
        {
             JsonResponseModel<ModifyMachineAutoClearConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMachineAutoClearConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineAutoClearConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改主机备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineRemarkRequest"/></param>
        /// <returns><see cref="ModifyMachineRemarkResponse"/></returns>
        public async Task<ModifyMachineRemarkResponse> ModifyMachineRemark(ModifyMachineRemarkRequest req)
        {
             JsonResponseModel<ModifyMachineRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMachineRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改主机备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineRemarkRequest"/></param>
        /// <returns><see cref="ModifyMachineRemarkResponse"/></returns>
        public ModifyMachineRemarkResponse ModifyMachineRemarkSync(ModifyMachineRemarkRequest req)
        {
             JsonResponseModel<ModifyMachineRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMachineRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新恶意请求白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMaliciousRequestWhiteListResponse"/></returns>
        public async Task<ModifyMaliciousRequestWhiteListResponse> ModifyMaliciousRequestWhiteList(ModifyMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<ModifyMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaliciousRequestWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新恶意请求白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMaliciousRequestWhiteListResponse"/></returns>
        public ModifyMaliciousRequestWhiteListResponse ModifyMaliciousRequestWhiteListSync(ModifyMaliciousRequestWhiteListRequest req)
        {
             JsonResponseModel<ModifyMaliciousRequestWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMaliciousRequestWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMaliciousRequestWhiteListResponse>>(strResp);
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
        /// 编辑木马白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMalwareWhiteListResponse"/></returns>
        public async Task<ModifyMalwareWhiteListResponse> ModifyMalwareWhiteList(ModifyMalwareWhiteListRequest req)
        {
             JsonResponseModel<ModifyMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMalwareWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑木马白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMalwareWhiteListResponse"/></returns>
        public ModifyMalwareWhiteListResponse ModifyMalwareWhiteListSync(ModifyMalwareWhiteListRequest req)
        {
             JsonResponseModel<ModifyMalwareWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMalwareWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMalwareWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改网络攻击设置
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public async Task<ModifyNetAttackSettingResponse> ModifyNetAttackSetting(ModifyNetAttackSettingRequest req)
        {
             JsonResponseModel<ModifyNetAttackSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetAttackSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetAttackSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改网络攻击设置
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public ModifyNetAttackSettingResponse ModifyNetAttackSettingSync(ModifyNetAttackSettingRequest req)
        {
             JsonResponseModel<ModifyNetAttackSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetAttackSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetAttackSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑网络攻击白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="ModifyNetAttackWhiteListResponse"/></returns>
        public async Task<ModifyNetAttackWhiteListResponse> ModifyNetAttackWhiteList(ModifyNetAttackWhiteListRequest req)
        {
             JsonResponseModel<ModifyNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetAttackWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑网络攻击白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="ModifyNetAttackWhiteListResponse"/></returns>
        public ModifyNetAttackWhiteListResponse ModifyNetAttackWhiteListSync(ModifyNetAttackWhiteListRequest req)
        {
             JsonResponseModel<ModifyNetAttackWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetAttackWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetAttackWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对订单属性编辑
        /// </summary>
        /// <param name="req"><see cref="ModifyOrderAttributeRequest"/></param>
        /// <returns><see cref="ModifyOrderAttributeResponse"/></returns>
        public async Task<ModifyOrderAttributeResponse> ModifyOrderAttribute(ModifyOrderAttributeRequest req)
        {
             JsonResponseModel<ModifyOrderAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyOrderAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOrderAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对订单属性编辑
        /// </summary>
        /// <param name="req"><see cref="ModifyOrderAttributeRequest"/></param>
        /// <returns><see cref="ModifyOrderAttributeResponse"/></returns>
        public ModifyOrderAttributeResponse ModifyOrderAttributeSync(ModifyOrderAttributeRequest req)
        {
             JsonResponseModel<ModifyOrderAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyOrderAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOrderAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改防勒索事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseEventsStatusResponse"/></returns>
        public async Task<ModifyRansomDefenseEventsStatusResponse> ModifyRansomDefenseEventsStatus(ModifyRansomDefenseEventsStatusRequest req)
        {
             JsonResponseModel<ModifyRansomDefenseEventsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRansomDefenseEventsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRansomDefenseEventsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改防勒索事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseEventsStatusResponse"/></returns>
        public ModifyRansomDefenseEventsStatusResponse ModifyRansomDefenseEventsStatusSync(ModifyRansomDefenseEventsStatusRequest req)
        {
             JsonResponseModel<ModifyRansomDefenseEventsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRansomDefenseEventsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRansomDefenseEventsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改防勒索策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseStrategyStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseStrategyStatusResponse"/></returns>
        public async Task<ModifyRansomDefenseStrategyStatusResponse> ModifyRansomDefenseStrategyStatus(ModifyRansomDefenseStrategyStatusRequest req)
        {
             JsonResponseModel<ModifyRansomDefenseStrategyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRansomDefenseStrategyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRansomDefenseStrategyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改防勒索策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseStrategyStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseStrategyStatusResponse"/></returns>
        public ModifyRansomDefenseStrategyStatusResponse ModifyRansomDefenseStrategyStatusSync(ModifyRansomDefenseStrategyStatusRequest req)
        {
             JsonResponseModel<ModifyRansomDefenseStrategyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRansomDefenseStrategyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRansomDefenseStrategyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改恶意请求策略
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyResponse"/></returns>
        public async Task<ModifyRiskDnsPolicyResponse> ModifyRiskDnsPolicy(ModifyRiskDnsPolicyRequest req)
        {
             JsonResponseModel<ModifyRiskDnsPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRiskDnsPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskDnsPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改恶意请求策略
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyResponse"/></returns>
        public ModifyRiskDnsPolicyResponse ModifyRiskDnsPolicySync(ModifyRiskDnsPolicyRequest req)
        {
             JsonResponseModel<ModifyRiskDnsPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRiskDnsPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskDnsPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改恶意请求策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyStatusResponse"/></returns>
        public async Task<ModifyRiskDnsPolicyStatusResponse> ModifyRiskDnsPolicyStatus(ModifyRiskDnsPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyRiskDnsPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRiskDnsPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskDnsPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改恶意请求策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyStatusResponse"/></returns>
        public ModifyRiskDnsPolicyStatusResponse ModifyRiskDnsPolicyStatusSync(ModifyRiskDnsPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyRiskDnsPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRiskDnsPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskDnsPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵检测所有事件的状态，包括：文件查杀，异常登录，密码破解，高危命令，反弹shell，本地提取
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskEventsStatusResponse"/></returns>
        public async Task<ModifyRiskEventsStatusResponse> ModifyRiskEventsStatus(ModifyRiskEventsStatusRequest req)
        {
             JsonResponseModel<ModifyRiskEventsStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRiskEventsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskEventsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 入侵检测所有事件的状态，包括：文件查杀，异常登录，密码破解，高危命令，反弹shell，本地提取
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskEventsStatusResponse"/></returns>
        public ModifyRiskEventsStatusResponse ModifyRiskEventsStatusSync(ModifyRiskEventsStatusRequest req)
        {
             JsonResponseModel<ModifyRiskEventsStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRiskEventsStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskEventsStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建/修改用户自定义配置
        /// </summary>
        /// <param name="req"><see cref="ModifyUsersConfigRequest"/></param>
        /// <returns><see cref="ModifyUsersConfigResponse"/></returns>
        public async Task<ModifyUsersConfigResponse> ModifyUsersConfig(ModifyUsersConfigRequest req)
        {
             JsonResponseModel<ModifyUsersConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUsersConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUsersConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建/修改用户自定义配置
        /// </summary>
        /// <param name="req"><see cref="ModifyUsersConfigRequest"/></param>
        /// <returns><see cref="ModifyUsersConfigResponse"/></returns>
        public ModifyUsersConfigResponse ModifyUsersConfigSync(ModifyUsersConfigRequest req)
        {
             JsonResponseModel<ModifyUsersConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUsersConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUsersConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改漏洞防御事件状态（修复漏洞通过其他接口实现）
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public async Task<ModifyVulDefenceEventStatusResponse> ModifyVulDefenceEventStatus(ModifyVulDefenceEventStatusRequest req)
        {
             JsonResponseModel<ModifyVulDefenceEventStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVulDefenceEventStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceEventStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改漏洞防御事件状态（修复漏洞通过其他接口实现）
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public ModifyVulDefenceEventStatusResponse ModifyVulDefenceEventStatusSync(ModifyVulDefenceEventStatusRequest req)
        {
             JsonResponseModel<ModifyVulDefenceEventStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVulDefenceEventStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceEventStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改漏洞防御插件设置
        /// 1）新增主机自动加入，scope为1，quuids为空
        /// 2）全量旗舰版不自动加入，scope为0，quuids为当前quuid列表，
        /// 3）给定quuid列表，scope为0，quuids为用户选择quuid
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public async Task<ModifyVulDefenceSettingResponse> ModifyVulDefenceSetting(ModifyVulDefenceSettingRequest req)
        {
             JsonResponseModel<ModifyVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改漏洞防御插件设置
        /// 1）新增主机自动加入，scope为1，quuids为空
        /// 2）全量旗舰版不自动加入，scope为0，quuids为当前quuid列表，
        /// 3）给定quuid列表，scope为0，quuids为用户选择quuid
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public ModifyVulDefenceSettingResponse ModifyVulDefenceSettingSync(ModifyVulDefenceSettingRequest req)
        {
             JsonResponseModel<ModifyVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警机器范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningHostConfigRequest"/></param>
        /// <returns><see cref="ModifyWarningHostConfigResponse"/></returns>
        public async Task<ModifyWarningHostConfigResponse> ModifyWarningHostConfig(ModifyWarningHostConfigRequest req)
        {
             JsonResponseModel<ModifyWarningHostConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWarningHostConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWarningHostConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警机器范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningHostConfigRequest"/></param>
        /// <returns><see cref="ModifyWarningHostConfigResponse"/></returns>
        public ModifyWarningHostConfigResponse ModifyWarningHostConfigSync(ModifyWarningHostConfigRequest req)
        {
             JsonResponseModel<ModifyWarningHostConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWarningHostConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWarningHostConfigResponse>>(strResp);
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
        /// 新增或修改告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyResponse"/></returns>
        public async Task<ModifyWebHookPolicyResponse> ModifyWebHookPolicy(ModifyWebHookPolicyRequest req)
        {
             JsonResponseModel<ModifyWebHookPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebHookPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyResponse"/></returns>
        public ModifyWebHookPolicyResponse ModifyWebHookPolicySync(ModifyWebHookPolicyRequest req)
        {
             JsonResponseModel<ModifyWebHookPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebHookPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警策略开关
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyStatusResponse"/></returns>
        public async Task<ModifyWebHookPolicyStatusResponse> ModifyWebHookPolicyStatus(ModifyWebHookPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyWebHookPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebHookPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警策略开关
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyStatusResponse"/></returns>
        public ModifyWebHookPolicyStatusResponse ModifyWebHookPolicyStatusSync(ModifyWebHookPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyWebHookPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebHookPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或更新告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebHookReceiverResponse"/></returns>
        public async Task<ModifyWebHookReceiverResponse> ModifyWebHookReceiver(ModifyWebHookReceiverRequest req)
        {
             JsonResponseModel<ModifyWebHookReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebHookReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或更新告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebHookReceiverResponse"/></returns>
        public ModifyWebHookReceiverResponse ModifyWebHookReceiverSync(ModifyWebHookReceiverRequest req)
        {
             JsonResponseModel<ModifyWebHookReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebHookReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改企微机器人规则
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleResponse"/></returns>
        public async Task<ModifyWebHookRuleResponse> ModifyWebHookRule(ModifyWebHookRuleRequest req)
        {
             JsonResponseModel<ModifyWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改企微机器人规则
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleResponse"/></returns>
        public ModifyWebHookRuleResponse ModifyWebHookRuleSync(ModifyWebHookRuleRequest req)
        {
             JsonResponseModel<ModifyWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改企微机器人规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleStatusResponse"/></returns>
        public async Task<ModifyWebHookRuleStatusResponse> ModifyWebHookRuleStatus(ModifyWebHookRuleStatusRequest req)
        {
             JsonResponseModel<ModifyWebHookRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWebHookRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改企微机器人规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleStatusResponse"/></returns>
        public ModifyWebHookRuleStatusResponse ModifyWebHookRuleStatusSync(ModifyWebHookRuleStatusRequest req)
        {
             JsonResponseModel<ModifyWebHookRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWebHookRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWebHookRuleStatusResponse>>(strResp);
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
        /// 防勒索快照回滚
        /// </summary>
        /// <param name="req"><see cref="RansomDefenseRollbackRequest"/></param>
        /// <returns><see cref="RansomDefenseRollbackResponse"/></returns>
        public async Task<RansomDefenseRollbackResponse> RansomDefenseRollback(RansomDefenseRollbackRequest req)
        {
             JsonResponseModel<RansomDefenseRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RansomDefenseRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RansomDefenseRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防勒索快照回滚
        /// </summary>
        /// <param name="req"><see cref="RansomDefenseRollbackRequest"/></param>
        /// <returns><see cref="RansomDefenseRollbackResponse"/></returns>
        public RansomDefenseRollbackResponse RansomDefenseRollbackSync(RansomDefenseRollbackRequest req)
        {
             JsonResponseModel<RansomDefenseRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RansomDefenseRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RansomDefenseRollbackResponse>>(strResp);
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
        /// 删除本地存储数据
        /// </summary>
        /// <param name="req"><see cref="RemoveLocalStorageItemRequest"/></param>
        /// <returns><see cref="RemoveLocalStorageItemResponse"/></returns>
        public async Task<RemoveLocalStorageItemResponse> RemoveLocalStorageItem(RemoveLocalStorageItemRequest req)
        {
             JsonResponseModel<RemoveLocalStorageItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveLocalStorageItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveLocalStorageItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除本地存储数据
        /// </summary>
        /// <param name="req"><see cref="RemoveLocalStorageItemRequest"/></param>
        /// <returns><see cref="RemoveLocalStorageItemResponse"/></returns>
        public RemoveLocalStorageItemResponse RemoveLocalStorageItemSync(RemoveLocalStorageItemRequest req)
        {
             JsonResponseModel<RemoveLocalStorageItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveLocalStorageItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveLocalStorageItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主机所有记录，目前只支持非腾讯云主机，且需要主机在离线状态
        /// </summary>
        /// <param name="req"><see cref="RemoveMachineRequest"/></param>
        /// <returns><see cref="RemoveMachineResponse"/></returns>
        public async Task<RemoveMachineResponse> RemoveMachine(RemoveMachineRequest req)
        {
             JsonResponseModel<RemoveMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除主机所有记录，目前只支持非腾讯云主机，且需要主机在离线状态
        /// </summary>
        /// <param name="req"><see cref="RemoveMachineRequest"/></param>
        /// <returns><see cref="RemoveMachineResponse"/></returns>
        public RemoveMachineResponse RemoveMachineSync(RemoveMachineRequest req)
        {
             JsonResponseModel<RemoveMachineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 快照创建失败时可以重试创建快照并且自动进行漏洞修复
        /// </summary>
        /// <param name="req"><see cref="RetryCreateSnapshotRequest"/></param>
        /// <returns><see cref="RetryCreateSnapshotResponse"/></returns>
        public async Task<RetryCreateSnapshotResponse> RetryCreateSnapshot(RetryCreateSnapshotRequest req)
        {
             JsonResponseModel<RetryCreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RetryCreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryCreateSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 快照创建失败时可以重试创建快照并且自动进行漏洞修复
        /// </summary>
        /// <param name="req"><see cref="RetryCreateSnapshotRequest"/></param>
        /// <returns><see cref="RetryCreateSnapshotResponse"/></returns>
        public RetryCreateSnapshotResponse RetryCreateSnapshotSync(RetryCreateSnapshotRequest req)
        {
             JsonResponseModel<RetryCreateSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RetryCreateSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryCreateSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修复失败时单独对某一个主机修复漏洞
        /// </summary>
        /// <param name="req"><see cref="RetryVulFixRequest"/></param>
        /// <returns><see cref="RetryVulFixResponse"/></returns>
        public async Task<RetryVulFixResponse> RetryVulFix(RetryVulFixRequest req)
        {
             JsonResponseModel<RetryVulFixResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RetryVulFix");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryVulFixResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修复失败时单独对某一个主机修复漏洞
        /// </summary>
        /// <param name="req"><see cref="RetryVulFixRequest"/></param>
        /// <returns><see cref="RetryVulFixResponse"/></returns>
        public RetryVulFixResponse RetryVulFixSync(RetryVulFixRequest req)
        {
             JsonResponseModel<RetryVulFixResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RetryVulFix");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryVulFixResponse>>(strResp);
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
        /// 基线检测与基线重新检测接口
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRequest"/></param>
        /// <returns><see cref="ScanBaselineResponse"/></returns>
        public async Task<ScanBaselineResponse> ScanBaseline(ScanBaselineRequest req)
        {
             JsonResponseModel<ScanBaselineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanBaseline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanBaselineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 基线检测与基线重新检测接口
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRequest"/></param>
        /// <returns><see cref="ScanBaselineResponse"/></returns>
        public ScanBaselineResponse ScanBaselineSync(ScanBaselineRequest req)
        {
             JsonResponseModel<ScanBaselineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanBaseline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanBaselineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ScanTaskAgain  重新开始扫描任务，可以指定机器
        /// </summary>
        /// <param name="req"><see cref="ScanTaskAgainRequest"/></param>
        /// <returns><see cref="ScanTaskAgainResponse"/></returns>
        public async Task<ScanTaskAgainResponse> ScanTaskAgain(ScanTaskAgainRequest req)
        {
             JsonResponseModel<ScanTaskAgainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanTaskAgain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanTaskAgainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ScanTaskAgain  重新开始扫描任务，可以指定机器
        /// </summary>
        /// <param name="req"><see cref="ScanTaskAgainRequest"/></param>
        /// <returns><see cref="ScanTaskAgainResponse"/></returns>
        public ScanTaskAgainResponse ScanTaskAgainSync(ScanTaskAgainRequest req)
        {
             JsonResponseModel<ScanTaskAgainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanTaskAgain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanTaskAgainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 漏洞一键检测
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
        /// 漏洞一键检测
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
        /// 查询日志
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public async Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询日志
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
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
        /// 设置本地存储过期时间
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageExpireRequest"/></param>
        /// <returns><see cref="SetLocalStorageExpireResponse"/></returns>
        public async Task<SetLocalStorageExpireResponse> SetLocalStorageExpire(SetLocalStorageExpireRequest req)
        {
             JsonResponseModel<SetLocalStorageExpireResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLocalStorageExpire");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLocalStorageExpireResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置本地存储过期时间
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageExpireRequest"/></param>
        /// <returns><see cref="SetLocalStorageExpireResponse"/></returns>
        public SetLocalStorageExpireResponse SetLocalStorageExpireSync(SetLocalStorageExpireRequest req)
        {
             JsonResponseModel<SetLocalStorageExpireResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetLocalStorageExpire");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLocalStorageExpireResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置本地存储数据
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageItemRequest"/></param>
        /// <returns><see cref="SetLocalStorageItemResponse"/></returns>
        public async Task<SetLocalStorageItemResponse> SetLocalStorageItem(SetLocalStorageItemRequest req)
        {
             JsonResponseModel<SetLocalStorageItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLocalStorageItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLocalStorageItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置本地存储数据
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageItemRequest"/></param>
        /// <returns><see cref="SetLocalStorageItemResponse"/></returns>
        public SetLocalStorageItemResponse SetLocalStorageItemSync(SetLocalStorageItemRequest req)
        {
             JsonResponseModel<SetLocalStorageItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetLocalStorageItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLocalStorageItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测基线
        /// </summary>
        /// <param name="req"><see cref="StartBaselineDetectRequest"/></param>
        /// <returns><see cref="StartBaselineDetectResponse"/></returns>
        public async Task<StartBaselineDetectResponse> StartBaselineDetect(StartBaselineDetectRequest req)
        {
             JsonResponseModel<StartBaselineDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartBaselineDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartBaselineDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测基线
        /// </summary>
        /// <param name="req"><see cref="StartBaselineDetectRequest"/></param>
        /// <returns><see cref="StartBaselineDetectResponse"/></returns>
        public StartBaselineDetectResponse StartBaselineDetectSync(StartBaselineDetectRequest req)
        {
             JsonResponseModel<StartBaselineDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartBaselineDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartBaselineDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止资产扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopAssetScanRequest"/></param>
        /// <returns><see cref="StopAssetScanResponse"/></returns>
        public async Task<StopAssetScanResponse> StopAssetScan(StopAssetScanRequest req)
        {
             JsonResponseModel<StopAssetScanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止资产扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopAssetScanRequest"/></param>
        /// <returns><see cref="StopAssetScanResponse"/></returns>
        public StopAssetScanResponse StopAssetScanSync(StopAssetScanRequest req)
        {
             JsonResponseModel<StopAssetScanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止基线检测
        /// </summary>
        /// <param name="req"><see cref="StopBaselineDetectRequest"/></param>
        /// <returns><see cref="StopBaselineDetectResponse"/></returns>
        public async Task<StopBaselineDetectResponse> StopBaselineDetect(StopBaselineDetectRequest req)
        {
             JsonResponseModel<StopBaselineDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopBaselineDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopBaselineDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止基线检测
        /// </summary>
        /// <param name="req"><see cref="StopBaselineDetectRequest"/></param>
        /// <returns><see cref="StopBaselineDetectResponse"/></returns>
        public StopBaselineDetectResponse StopBaselineDetectSync(StopBaselineDetectRequest req)
        {
             JsonResponseModel<StopBaselineDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopBaselineDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopBaselineDetectResponse>>(strResp);
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
        /// 同步基线检测进度概要
        /// </summary>
        /// <param name="req"><see cref="SyncBaselineDetectSummaryRequest"/></param>
        /// <returns><see cref="SyncBaselineDetectSummaryResponse"/></returns>
        public async Task<SyncBaselineDetectSummaryResponse> SyncBaselineDetectSummary(SyncBaselineDetectSummaryRequest req)
        {
             JsonResponseModel<SyncBaselineDetectSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncBaselineDetectSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncBaselineDetectSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步基线检测进度概要
        /// </summary>
        /// <param name="req"><see cref="SyncBaselineDetectSummaryRequest"/></param>
        /// <returns><see cref="SyncBaselineDetectSummaryResponse"/></returns>
        public SyncBaselineDetectSummaryResponse SyncBaselineDetectSummarySync(SyncBaselineDetectSummaryRequest req)
        {
             JsonResponseModel<SyncBaselineDetectSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncBaselineDetectSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncBaselineDetectSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步机器信息
        /// </summary>
        /// <param name="req"><see cref="SyncMachinesRequest"/></param>
        /// <returns><see cref="SyncMachinesResponse"/></returns>
        public async Task<SyncMachinesResponse> SyncMachines(SyncMachinesRequest req)
        {
             JsonResponseModel<SyncMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步机器信息
        /// </summary>
        /// <param name="req"><see cref="SyncMachinesRequest"/></param>
        /// <returns><see cref="SyncMachinesResponse"/></returns>
        public SyncMachinesResponse SyncMachinesSync(SyncMachinesRequest req)
        {
             JsonResponseModel<SyncMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 测试企微机器人规则
        /// </summary>
        /// <param name="req"><see cref="TestWebHookRuleRequest"/></param>
        /// <returns><see cref="TestWebHookRuleResponse"/></returns>
        public async Task<TestWebHookRuleResponse> TestWebHookRule(TestWebHookRuleRequest req)
        {
             JsonResponseModel<TestWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TestWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TestWebHookRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 测试企微机器人规则
        /// </summary>
        /// <param name="req"><see cref="TestWebHookRuleRequest"/></param>
        /// <returns><see cref="TestWebHookRuleResponse"/></returns>
        public TestWebHookRuleResponse TestWebHookRuleSync(TestWebHookRuleRequest req)
        {
             JsonResponseModel<TestWebHookRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TestWebHookRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TestWebHookRuleResponse>>(strResp);
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
