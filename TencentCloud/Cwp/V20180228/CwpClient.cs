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
        /// 添加房展防护服务器
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
        /// 添加房展防护服务器
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
        /// 获取主机安全相关统计
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
        /// 获取主机安全相关统计
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
        /// 本接口 (DescribeMachineList) 用于网页防篡改获取区域主机列表。
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
        /// 本接口 (DescribeMachineList) 用于网页防篡改获取区域主机列表。
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
        /// 本接口用于（DescribeOverviewStatistics）获取概览统计数据。
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
        /// 本接口用于（DescribeOverviewStatistics）获取概览统计数据。
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
        /// 本接口 (DescribeProVersionInfo) 用于获取专业版信息。
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
        /// 本接口 (DescribeProVersionInfo) 用于获取专业版信息。
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
        /// 本接口 (DescribeSecurityDynamics) 用于获取安全事件消息数据。
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
        /// 本接口 (DescribeSecurityDynamics) 用于获取安全事件消息数据。
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
        /// 本接口 (ModifyAutoOpenProVersionConfig) 用于设置新增主机自动开通专业版配置。
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
        /// 本接口 (ModifyAutoOpenProVersionConfig) 用于设置新增主机自动开通专业版配置。
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
        /// 网站防篡改-修改网站防护设置
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
        /// 网站防篡改-修改网站防护设置
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

    }
}
