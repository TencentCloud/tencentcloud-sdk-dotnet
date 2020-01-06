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

namespace TencentCloud.Yunjing.V20180228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Yunjing.V20180228.Models;

   public class YunjingClient : AbstractClient{

       private const string endpoint = "yunjing.tencentcloudapi.com";
       private const string version = "2018-02-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YunjingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public YunjingClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（AddLoginWhiteList）用于添加白名单规则
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListResponse"/></returns>
        public async Task<AddLoginWhiteListResponse> AddLoginWhiteList(AddLoginWhiteListRequest req)
        {
             JsonResponseModel<AddLoginWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddLoginWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddLoginWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加机器关联标签
        /// </summary>
        /// <param name="req"><see cref="AddMachineTagRequest"/></param>
        /// <returns><see cref="AddMachineTagResponse"/></returns>
        public async Task<AddMachineTagResponse> AddMachineTag(AddMachineTagRequest req)
        {
             JsonResponseModel<AddMachineTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddMachineTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddMachineTagResponse>>(strResp);
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
        /// 本接口 (CreateOpenPortTask) 用于创建实时获取端口任务。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenPortTaskRequest"/></param>
        /// <returns><see cref="CreateOpenPortTaskResponse"/></returns>
        public async Task<CreateOpenPortTaskResponse> CreateOpenPortTask(CreateOpenPortTaskRequest req)
        {
             JsonResponseModel<CreateOpenPortTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenPortTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenPortTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateProcessTask) 用于创建实时拉取进程任务。
        /// </summary>
        /// <param name="req"><see cref="CreateProcessTaskRequest"/></param>
        /// <returns><see cref="CreateProcessTaskResponse"/></returns>
        public async Task<CreateProcessTaskResponse> CreateProcessTask(CreateProcessTaskRequest req)
        {
             JsonResponseModel<CreateProcessTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProcessTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcessTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateUsualLoginPlaces）用于添加常用登录地。
        /// </summary>
        /// <param name="req"><see cref="CreateUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="CreateUsualLoginPlacesResponse"/></returns>
        public async Task<CreateUsualLoginPlacesResponse> CreateUsualLoginPlaces(CreateUsualLoginPlacesRequest req)
        {
             JsonResponseModel<CreateUsualLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUsualLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUsualLoginPlacesResponse>>(strResp);
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
        /// 删除白名单规则
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
        /// 本接口（DeleteUsualLoginPlaces）用于删除常用登录地。
        /// </summary>
        /// <param name="req"><see cref="DeleteUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteUsualLoginPlacesResponse"/></returns>
        public async Task<DeleteUsualLoginPlacesResponse> DeleteUsualLoginPlaces(DeleteUsualLoginPlacesRequest req)
        {
             JsonResponseModel<DeleteUsualLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsualLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsualLoginPlacesResponse>>(strResp);
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
        /// 本接口 (DescribeAgentVuls) 用于获取单台主机的漏洞列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVulsRequest"/></param>
        /// <returns><see cref="DescribeAgentVulsResponse"/></returns>
        public async Task<DescribeAgentVulsResponse> DescribeAgentVuls(DescribeAgentVulsRequest req)
        {
             JsonResponseModel<DescribeAgentVulsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentVuls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentVulsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeAlarmAttribute) 用于获取告警设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmAttributeRequest"/></param>
        /// <returns><see cref="DescribeAlarmAttributeResponse"/></returns>
        public async Task<DescribeAlarmAttributeResponse> DescribeAlarmAttribute(DescribeAlarmAttributeRequest req)
        {
             JsonResponseModel<DescribeAlarmAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmAttributeResponse>>(strResp);
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
        /// 本接口{DescribeBruteAttacks}用于获取暴力破解事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeBruteAttacksResponse"/></returns>
        public async Task<DescribeBruteAttacksResponse> DescribeBruteAttacks(DescribeBruteAttacksRequest req)
        {
             JsonResponseModel<DescribeBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeComponentInfo) 用于获取组件信息数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentInfoRequest"/></param>
        /// <returns><see cref="DescribeComponentInfoResponse"/></returns>
        public async Task<DescribeComponentInfoResponse> DescribeComponentInfo(DescribeComponentInfoRequest req)
        {
             JsonResponseModel<DescribeComponentInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComponentInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComponentInfoResponse>>(strResp);
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
        /// 本接口 (DescribeComponents) 用于获取组件列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentsRequest"/></param>
        /// <returns><see cref="DescribeComponentsResponse"/></returns>
        public async Task<DescribeComponentsResponse> DescribeComponents(DescribeComponentsRequest req)
        {
             JsonResponseModel<DescribeComponentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComponentsResponse>>(strResp);
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
        /// 本接口 (DescribeImpactedHosts) 用于获取漏洞受影响机器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeImpactedHostsRequest"/></param>
        /// <returns><see cref="DescribeImpactedHostsResponse"/></returns>
        public async Task<DescribeImpactedHostsResponse> DescribeImpactedHosts(DescribeImpactedHostsRequest req)
        {
             JsonResponseModel<DescribeImpactedHostsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImpactedHosts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImpactedHostsResponse>>(strResp);
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
        /// 本接口 (DescribeMaliciousRequests) 用于获取恶意请求数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestsResponse"/></returns>
        public async Task<DescribeMaliciousRequestsResponse> DescribeMaliciousRequests(DescribeMaliciousRequestsRequest req)
        {
             JsonResponseModel<DescribeMaliciousRequestsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMaliciousRequests");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMaliciousRequestsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMalwares）用于获取木马事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwaresRequest"/></param>
        /// <returns><see cref="DescribeMalwaresResponse"/></returns>
        public async Task<DescribeMalwaresResponse> DescribeMalwares(DescribeMalwaresRequest req)
        {
             JsonResponseModel<DescribeMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeNonlocalLoginPlaces)用于获取异地登录事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeNonlocalLoginPlacesResponse"/></returns>
        public async Task<DescribeNonlocalLoginPlacesResponse> DescribeNonlocalLoginPlaces(DescribeNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<DescribeNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNonlocalLoginPlacesResponse>>(strResp);
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
        /// 本接口 (DescribeOpenPortTaskStatus) 用于获取实时拉取端口任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeOpenPortTaskStatusResponse"/></returns>
        public async Task<DescribeOpenPortTaskStatusResponse> DescribeOpenPortTaskStatus(DescribeOpenPortTaskStatusRequest req)
        {
             JsonResponseModel<DescribeOpenPortTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOpenPortTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOpenPortTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeOpenPorts) 用于获取端口列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortsResponse"/></returns>
        public async Task<DescribeOpenPortsResponse> DescribeOpenPorts(DescribeOpenPortsRequest req)
        {
             JsonResponseModel<DescribeOpenPortsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOpenPorts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOpenPortsResponse>>(strResp);
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
        /// 本接口 (DescribeProcessTaskStatus) 用于获取实时拉取进程任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeProcessTaskStatusResponse"/></returns>
        public async Task<DescribeProcessTaskStatusResponse> DescribeProcessTaskStatus(DescribeProcessTaskStatusRequest req)
        {
             JsonResponseModel<DescribeProcessTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcessTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcessTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeProcesses) 用于获取进程列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessesRequest"/></param>
        /// <returns><see cref="DescribeProcessesResponse"/></returns>
        public async Task<DescribeProcessesResponse> DescribeProcesses(DescribeProcessesRequest req)
        {
             JsonResponseModel<DescribeProcessesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProcesses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProcessesResponse>>(strResp);
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
        /// 本接口 (DescribeVulInfo) 用于获取漏洞详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoRequest"/></param>
        /// <returns><see cref="DescribeVulInfoResponse"/></returns>
        public async Task<DescribeVulInfoResponse> DescribeVulInfo(DescribeVulInfoRequest req)
        {
             JsonResponseModel<DescribeVulInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVulScanResult) 用于获取漏洞检测结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanResultRequest"/></param>
        /// <returns><see cref="DescribeVulScanResultResponse"/></returns>
        public async Task<DescribeVulScanResultResponse> DescribeVulScanResult(DescribeVulScanResultRequest req)
        {
             JsonResponseModel<DescribeVulScanResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulScanResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeVuls) 用于获取漏洞列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public async Task<DescribeVulsResponse> DescribeVuls(DescribeVulsRequest req)
        {
             JsonResponseModel<DescribeVulsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVuls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportBruteAttacks) 用于获取专业周报密码破解数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportBruteAttacksResponse"/></returns>
        public async Task<DescribeWeeklyReportBruteAttacksResponse> DescribeWeeklyReportBruteAttacks(DescribeWeeklyReportBruteAttacksRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportBruteAttacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportBruteAttacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportBruteAttacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportInfo) 用于获取专业周报详情数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportInfoRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportInfoResponse"/></returns>
        public async Task<DescribeWeeklyReportInfoResponse> DescribeWeeklyReportInfo(DescribeWeeklyReportInfoRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportMalwares) 用于获取专业周报木马数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportMalwaresRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportMalwaresResponse"/></returns>
        public async Task<DescribeWeeklyReportMalwaresResponse> DescribeWeeklyReportMalwares(DescribeWeeklyReportMalwaresRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportMalwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportMalwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportMalwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportNonlocalLoginPlaces) 用于获取专业周报异地登录数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportNonlocalLoginPlacesResponse"/></returns>
        public async Task<DescribeWeeklyReportNonlocalLoginPlacesResponse> DescribeWeeklyReportNonlocalLoginPlaces(DescribeWeeklyReportNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportVuls) 用于专业版周报漏洞数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportVulsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportVulsResponse"/></returns>
        public async Task<DescribeWeeklyReportVulsResponse> DescribeWeeklyReportVuls(DescribeWeeklyReportVulsRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportVulsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReportVuls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportVulsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReports) 用于获取周报列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportsResponse"/></returns>
        public async Task<DescribeWeeklyReportsResponse> DescribeWeeklyReports(DescribeWeeklyReportsRequest req)
        {
             JsonResponseModel<DescribeWeeklyReportsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWeeklyReports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWeeklyReportsResponse>>(strResp);
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
        /// <param name="req"><see cref="EditBashRuleRequest"/></param>
        /// <returns><see cref="EditBashRuleResponse"/></returns>
        public async Task<EditBashRuleResponse> EditBashRule(EditBashRuleRequest req)
        {
             JsonResponseModel<EditBashRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditBashRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditBashRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或修改本地提权规则
        /// </summary>
        /// <param name="req"><see cref="EditPrivilegeRuleRequest"/></param>
        /// <returns><see cref="EditPrivilegeRuleResponse"/></returns>
        public async Task<EditPrivilegeRuleResponse> EditPrivilegeRule(EditPrivilegeRuleRequest req)
        {
             JsonResponseModel<EditPrivilegeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditPrivilegeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditPrivilegeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑反弹Shell规则
        /// </summary>
        /// <param name="req"><see cref="EditReverseShellRuleRequest"/></param>
        /// <returns><see cref="EditReverseShellRuleResponse"/></returns>
        public async Task<EditReverseShellRuleResponse> EditReverseShellRule(EditReverseShellRuleRequest req)
        {
             JsonResponseModel<EditReverseShellRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditReverseShellRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditReverseShellRuleResponse>>(strResp);
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
        /// 本接口{MisAlarmNonlocalLoginPlaces}将设置当前地点为常用登录地。
        /// </summary>
        /// <param name="req"><see cref="MisAlarmNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="MisAlarmNonlocalLoginPlacesResponse"/></returns>
        public async Task<MisAlarmNonlocalLoginPlacesResponse> MisAlarmNonlocalLoginPlaces(MisAlarmNonlocalLoginPlacesRequest req)
        {
             JsonResponseModel<MisAlarmNonlocalLoginPlacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MisAlarmNonlocalLoginPlaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MisAlarmNonlocalLoginPlacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAlarmAttribute）用于修改告警设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmAttributeRequest"/></param>
        /// <returns><see cref="ModifyAlarmAttributeResponse"/></returns>
        public async Task<ModifyAlarmAttributeResponse> ModifyAlarmAttribute(ModifyAlarmAttributeRequest req)
        {
             JsonResponseModel<ModifyAlarmAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmAttributeResponse>>(strResp);
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
        /// 编辑白名单规则
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteListRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteListResponse"/></returns>
        public async Task<ModifyLoginWhiteListResponse> ModifyLoginWhiteList(ModifyLoginWhiteListRequest req)
        {
             JsonResponseModel<ModifyLoginWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoginWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoginWhiteListResponse>>(strResp);
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
        /// 本接口 (TrustMaliciousRequest) 用于恶意请求添加信任。
        /// </summary>
        /// <param name="req"><see cref="TrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="TrustMaliciousRequestResponse"/></returns>
        public async Task<TrustMaliciousRequestResponse> TrustMaliciousRequest(TrustMaliciousRequestRequest req)
        {
             JsonResponseModel<TrustMaliciousRequestResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TrustMaliciousRequest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TrustMaliciousRequestResponse>>(strResp);
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
        /// 本接口 (UntrustMaliciousRequest) 用于取消信任恶意请求。
        /// </summary>
        /// <param name="req"><see cref="UntrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="UntrustMaliciousRequestResponse"/></returns>
        public async Task<UntrustMaliciousRequestResponse> UntrustMaliciousRequest(UntrustMaliciousRequestRequest req)
        {
             JsonResponseModel<UntrustMaliciousRequestResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UntrustMaliciousRequest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UntrustMaliciousRequestResponse>>(strResp);
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

    }
}
