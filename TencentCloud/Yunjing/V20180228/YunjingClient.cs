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
       private const string sdkVersion = "SDK_NET_3.0.989";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YunjingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（AddLoginWhiteList）用于添加白名单规则
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListResponse"/></returns>
        public Task<AddLoginWhiteListResponse> AddLoginWhiteList(AddLoginWhiteListRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListResponse>(req, "AddLoginWhiteList");
        }

        /// <summary>
        /// 本接口（AddLoginWhiteList）用于添加白名单规则
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListResponse"/></returns>
        public AddLoginWhiteListResponse AddLoginWhiteListSync(AddLoginWhiteListRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListResponse>(req, "AddLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加机器关联标签
        /// </summary>
        /// <param name="req"><see cref="AddMachineTagRequest"/></param>
        /// <returns><see cref="AddMachineTagResponse"/></returns>
        public Task<AddMachineTagResponse> AddMachineTag(AddMachineTagRequest req)
        {
            return InternalRequestAsync<AddMachineTagResponse>(req, "AddMachineTag");
        }

        /// <summary>
        /// 增加机器关联标签
        /// </summary>
        /// <param name="req"><see cref="AddMachineTagRequest"/></param>
        /// <returns><see cref="AddMachineTagResponse"/></returns>
        public AddMachineTagResponse AddMachineTagSync(AddMachineTagRequest req)
        {
            return InternalRequestAsync<AddMachineTagResponse>(req, "AddMachineTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CloseProVersion) 用于关闭专业版。
        /// </summary>
        /// <param name="req"><see cref="CloseProVersionRequest"/></param>
        /// <returns><see cref="CloseProVersionResponse"/></returns>
        public Task<CloseProVersionResponse> CloseProVersion(CloseProVersionRequest req)
        {
            return InternalRequestAsync<CloseProVersionResponse>(req, "CloseProVersion");
        }

        /// <summary>
        /// 本接口 (CloseProVersion) 用于关闭专业版。
        /// </summary>
        /// <param name="req"><see cref="CloseProVersionRequest"/></param>
        /// <returns><see cref="CloseProVersionResponse"/></returns>
        public CloseProVersionResponse CloseProVersionSync(CloseProVersionRequest req)
        {
            return InternalRequestAsync<CloseProVersionResponse>(req, "CloseProVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据策略信息创建基线策略
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineStrategyRequest"/></param>
        /// <returns><see cref="CreateBaselineStrategyResponse"/></returns>
        public Task<CreateBaselineStrategyResponse> CreateBaselineStrategy(CreateBaselineStrategyRequest req)
        {
            return InternalRequestAsync<CreateBaselineStrategyResponse>(req, "CreateBaselineStrategy");
        }

        /// <summary>
        /// 根据策略信息创建基线策略
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineStrategyRequest"/></param>
        /// <returns><see cref="CreateBaselineStrategyResponse"/></returns>
        public CreateBaselineStrategyResponse CreateBaselineStrategySync(CreateBaselineStrategyRequest req)
        {
            return InternalRequestAsync<CreateBaselineStrategyResponse>(req, "CreateBaselineStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateOpenPortTask) 用于创建实时获取端口任务。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenPortTaskRequest"/></param>
        /// <returns><see cref="CreateOpenPortTaskResponse"/></returns>
        public Task<CreateOpenPortTaskResponse> CreateOpenPortTask(CreateOpenPortTaskRequest req)
        {
            return InternalRequestAsync<CreateOpenPortTaskResponse>(req, "CreateOpenPortTask");
        }

        /// <summary>
        /// 本接口 (CreateOpenPortTask) 用于创建实时获取端口任务。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenPortTaskRequest"/></param>
        /// <returns><see cref="CreateOpenPortTaskResponse"/></returns>
        public CreateOpenPortTaskResponse CreateOpenPortTaskSync(CreateOpenPortTaskRequest req)
        {
            return InternalRequestAsync<CreateOpenPortTaskResponse>(req, "CreateOpenPortTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateProcessTask) 用于创建实时拉取进程任务。
        /// </summary>
        /// <param name="req"><see cref="CreateProcessTaskRequest"/></param>
        /// <returns><see cref="CreateProcessTaskResponse"/></returns>
        public Task<CreateProcessTaskResponse> CreateProcessTask(CreateProcessTaskRequest req)
        {
            return InternalRequestAsync<CreateProcessTaskResponse>(req, "CreateProcessTask");
        }

        /// <summary>
        /// 本接口 (CreateProcessTask) 用于创建实时拉取进程任务。
        /// </summary>
        /// <param name="req"><see cref="CreateProcessTaskRequest"/></param>
        /// <returns><see cref="CreateProcessTaskResponse"/></returns>
        public CreateProcessTaskResponse CreateProcessTaskSync(CreateProcessTaskRequest req)
        {
            return InternalRequestAsync<CreateProcessTaskResponse>(req, "CreateProcessTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateUsualLoginPlaces）用于添加常用登录地。
        /// </summary>
        /// <param name="req"><see cref="CreateUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="CreateUsualLoginPlacesResponse"/></returns>
        public Task<CreateUsualLoginPlacesResponse> CreateUsualLoginPlaces(CreateUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<CreateUsualLoginPlacesResponse>(req, "CreateUsualLoginPlaces");
        }

        /// <summary>
        /// 此接口（CreateUsualLoginPlaces）用于添加常用登录地。
        /// </summary>
        /// <param name="req"><see cref="CreateUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="CreateUsualLoginPlacesResponse"/></returns>
        public CreateUsualLoginPlacesResponse CreateUsualLoginPlacesSync(CreateUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<CreateUsualLoginPlacesResponse>(req, "CreateUsualLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackLogsRequest"/></param>
        /// <returns><see cref="DeleteAttackLogsResponse"/></returns>
        public Task<DeleteAttackLogsResponse> DeleteAttackLogs(DeleteAttackLogsRequest req)
        {
            return InternalRequestAsync<DeleteAttackLogsResponse>(req, "DeleteAttackLogs");
        }

        /// <summary>
        /// 删除网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackLogsRequest"/></param>
        /// <returns><see cref="DeleteAttackLogsResponse"/></returns>
        public DeleteAttackLogsResponse DeleteAttackLogsSync(DeleteAttackLogsRequest req)
        {
            return InternalRequestAsync<DeleteAttackLogsResponse>(req, "DeleteAttackLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据Ids删除高危命令事件
        /// </summary>
        /// <param name="req"><see cref="DeleteBashEventsRequest"/></param>
        /// <returns><see cref="DeleteBashEventsResponse"/></returns>
        public Task<DeleteBashEventsResponse> DeleteBashEvents(DeleteBashEventsRequest req)
        {
            return InternalRequestAsync<DeleteBashEventsResponse>(req, "DeleteBashEvents");
        }

        /// <summary>
        /// 根据Ids删除高危命令事件
        /// </summary>
        /// <param name="req"><see cref="DeleteBashEventsRequest"/></param>
        /// <returns><see cref="DeleteBashEventsResponse"/></returns>
        public DeleteBashEventsResponse DeleteBashEventsSync(DeleteBashEventsRequest req)
        {
            return InternalRequestAsync<DeleteBashEventsResponse>(req, "DeleteBashEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除高危命令规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBashRulesRequest"/></param>
        /// <returns><see cref="DeleteBashRulesResponse"/></returns>
        public Task<DeleteBashRulesResponse> DeleteBashRules(DeleteBashRulesRequest req)
        {
            return InternalRequestAsync<DeleteBashRulesResponse>(req, "DeleteBashRules");
        }

        /// <summary>
        /// 删除高危命令规则
        /// </summary>
        /// <param name="req"><see cref="DeleteBashRulesRequest"/></param>
        /// <returns><see cref="DeleteBashRulesResponse"/></returns>
        public DeleteBashRulesResponse DeleteBashRulesSync(DeleteBashRulesRequest req)
        {
            return InternalRequestAsync<DeleteBashRulesResponse>(req, "DeleteBashRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteBruteAttacks) 用于删除暴力破解记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public Task<DeleteBruteAttacksResponse> DeleteBruteAttacks(DeleteBruteAttacksRequest req)
        {
            return InternalRequestAsync<DeleteBruteAttacksResponse>(req, "DeleteBruteAttacks");
        }

        /// <summary>
        /// 本接口 (DeleteBruteAttacks) 用于删除暴力破解记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public DeleteBruteAttacksResponse DeleteBruteAttacksSync(DeleteBruteAttacksRequest req)
        {
            return InternalRequestAsync<DeleteBruteAttacksResponse>(req, "DeleteBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除白名单规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public Task<DeleteLoginWhiteListResponse> DeleteLoginWhiteList(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList");
        }

        /// <summary>
        /// 删除白名单规则
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public DeleteLoginWhiteListResponse DeleteLoginWhiteListSync(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteMachine）用于卸载云镜客户端。
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public Task<DeleteMachineResponse> DeleteMachine(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine");
        }

        /// <summary>
        /// 本接口（DeleteMachine）用于卸载云镜客户端。
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public DeleteMachineResponse DeleteMachineSync(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除服务器关联的标签
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public Task<DeleteMachineTagResponse> DeleteMachineTag(DeleteMachineTagRequest req)
        {
            return InternalRequestAsync<DeleteMachineTagResponse>(req, "DeleteMachineTag");
        }

        /// <summary>
        /// 删除服务器关联的标签
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public DeleteMachineTagResponse DeleteMachineTagSync(DeleteMachineTagRequest req)
        {
            return InternalRequestAsync<DeleteMachineTagResponse>(req, "DeleteMachineTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteMaliciousRequests) 用于删除恶意请求记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public Task<DeleteMaliciousRequestsResponse> DeleteMaliciousRequests(DeleteMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestsResponse>(req, "DeleteMaliciousRequests");
        }

        /// <summary>
        /// 本接口 (DeleteMaliciousRequests) 用于删除恶意请求记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public DeleteMaliciousRequestsResponse DeleteMaliciousRequestsSync(DeleteMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestsResponse>(req, "DeleteMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteMalwares) 用于删除木马记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public Task<DeleteMalwaresResponse> DeleteMalwares(DeleteMalwaresRequest req)
        {
            return InternalRequestAsync<DeleteMalwaresResponse>(req, "DeleteMalwares");
        }

        /// <summary>
        /// 本接口 (DeleteMalwares) 用于删除木马记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public DeleteMalwaresResponse DeleteMalwaresSync(DeleteMalwaresRequest req)
        {
            return InternalRequestAsync<DeleteMalwaresResponse>(req, "DeleteMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DeleteNonlocalLoginPlaces) 用于删除异地登录记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public Task<DeleteNonlocalLoginPlacesResponse> DeleteNonlocalLoginPlaces(DeleteNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteNonlocalLoginPlacesResponse>(req, "DeleteNonlocalLoginPlaces");
        }

        /// <summary>
        /// 本接口 (DeleteNonlocalLoginPlaces) 用于删除异地登录记录。
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public DeleteNonlocalLoginPlacesResponse DeleteNonlocalLoginPlacesSync(DeleteNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteNonlocalLoginPlacesResponse>(req, "DeleteNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据Ids删除本地提权
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DeletePrivilegeEventsResponse"/></returns>
        public Task<DeletePrivilegeEventsResponse> DeletePrivilegeEvents(DeletePrivilegeEventsRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeEventsResponse>(req, "DeletePrivilegeEvents");
        }

        /// <summary>
        /// 根据Ids删除本地提权
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DeletePrivilegeEventsResponse"/></returns>
        public DeletePrivilegeEventsResponse DeletePrivilegeEventsSync(DeletePrivilegeEventsRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeEventsResponse>(req, "DeletePrivilegeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除本地提权规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DeletePrivilegeRulesResponse"/></returns>
        public Task<DeletePrivilegeRulesResponse> DeletePrivilegeRules(DeletePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeRulesResponse>(req, "DeletePrivilegeRules");
        }

        /// <summary>
        /// 删除本地提权规则
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DeletePrivilegeRulesResponse"/></returns>
        public DeletePrivilegeRulesResponse DeletePrivilegeRulesSync(DeletePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeRulesResponse>(req, "DeletePrivilegeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据Ids删除反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public Task<DeleteReverseShellEventsResponse> DeleteReverseShellEvents(DeleteReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellEventsResponse>(req, "DeleteReverseShellEvents");
        }

        /// <summary>
        /// 根据Ids删除反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public DeleteReverseShellEventsResponse DeleteReverseShellEventsSync(DeleteReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellEventsResponse>(req, "DeleteReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除反弹Shell规则
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellRulesRequest"/></param>
        /// <returns><see cref="DeleteReverseShellRulesResponse"/></returns>
        public Task<DeleteReverseShellRulesResponse> DeleteReverseShellRules(DeleteReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellRulesResponse>(req, "DeleteReverseShellRules");
        }

        /// <summary>
        /// 删除反弹Shell规则
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellRulesRequest"/></param>
        /// <returns><see cref="DeleteReverseShellRulesResponse"/></returns>
        public DeleteReverseShellRulesResponse DeleteReverseShellRulesSync(DeleteReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellRulesResponse>(req, "DeleteReverseShellRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public Task<DeleteTagsResponse> DeleteTags(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags");
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public DeleteTagsResponse DeleteTagsSync(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteUsualLoginPlaces）用于删除常用登录地。
        /// </summary>
        /// <param name="req"><see cref="DeleteUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteUsualLoginPlacesResponse"/></returns>
        public Task<DeleteUsualLoginPlacesResponse> DeleteUsualLoginPlaces(DeleteUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteUsualLoginPlacesResponse>(req, "DeleteUsualLoginPlaces");
        }

        /// <summary>
        /// 本接口（DeleteUsualLoginPlaces）用于删除常用登录地。
        /// </summary>
        /// <param name="req"><see cref="DeleteUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteUsualLoginPlacesResponse"/></returns>
        public DeleteUsualLoginPlacesResponse DeleteUsualLoginPlacesSync(DeleteUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteUsualLoginPlacesResponse>(req, "DeleteUsualLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeAccountStatistics) 用于获取帐号统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public Task<DescribeAccountStatisticsResponse> DescribeAccountStatistics(DescribeAccountStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAccountStatisticsResponse>(req, "DescribeAccountStatistics");
        }

        /// <summary>
        /// 本接口 (DescribeAccountStatistics) 用于获取帐号统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public DescribeAccountStatisticsResponse DescribeAccountStatisticsSync(DescribeAccountStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAccountStatisticsResponse>(req, "DescribeAccountStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeAccounts) 用于获取帐号列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 本接口 (DescribeAccounts) 用于获取帐号列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeAgentVuls) 用于获取单台主机的漏洞列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVulsRequest"/></param>
        /// <returns><see cref="DescribeAgentVulsResponse"/></returns>
        public Task<DescribeAgentVulsResponse> DescribeAgentVuls(DescribeAgentVulsRequest req)
        {
            return InternalRequestAsync<DescribeAgentVulsResponse>(req, "DescribeAgentVuls");
        }

        /// <summary>
        /// 本接口 (DescribeAgentVuls) 用于获取单台主机的漏洞列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVulsRequest"/></param>
        /// <returns><see cref="DescribeAgentVulsResponse"/></returns>
        public DescribeAgentVulsResponse DescribeAgentVulsSync(DescribeAgentVulsRequest req)
        {
            return InternalRequestAsync<DescribeAgentVulsResponse>(req, "DescribeAgentVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeAlarmAttribute) 用于获取告警设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmAttributeRequest"/></param>
        /// <returns><see cref="DescribeAlarmAttributeResponse"/></returns>
        public Task<DescribeAlarmAttributeResponse> DescribeAlarmAttribute(DescribeAlarmAttributeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmAttributeResponse>(req, "DescribeAlarmAttribute");
        }

        /// <summary>
        /// 本接口 (DescribeAlarmAttribute) 用于获取告警设置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmAttributeRequest"/></param>
        /// <returns><see cref="DescribeAlarmAttributeResponse"/></returns>
        public DescribeAlarmAttributeResponse DescribeAlarmAttributeSync(DescribeAlarmAttributeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmAttributeResponse>(req, "DescribeAlarmAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 网络攻击日志详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackLogInfoResponse"/></returns>
        public Task<DescribeAttackLogInfoResponse> DescribeAttackLogInfo(DescribeAttackLogInfoRequest req)
        {
            return InternalRequestAsync<DescribeAttackLogInfoResponse>(req, "DescribeAttackLogInfo");
        }

        /// <summary>
        /// 网络攻击日志详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackLogInfoResponse"/></returns>
        public DescribeAttackLogInfoResponse DescribeAttackLogInfoSync(DescribeAttackLogInfoRequest req)
        {
            return InternalRequestAsync<DescribeAttackLogInfoResponse>(req, "DescribeAttackLogInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按分页形式展示网络攻击日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogsRequest"/></param>
        /// <returns><see cref="DescribeAttackLogsResponse"/></returns>
        public Task<DescribeAttackLogsResponse> DescribeAttackLogs(DescribeAttackLogsRequest req)
        {
            return InternalRequestAsync<DescribeAttackLogsResponse>(req, "DescribeAttackLogs");
        }

        /// <summary>
        /// 按分页形式展示网络攻击日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogsRequest"/></param>
        /// <returns><see cref="DescribeAttackLogsResponse"/></returns>
        public DescribeAttackLogsResponse DescribeAttackLogsSync(DescribeAttackLogsRequest req)
        {
            return InternalRequestAsync<DescribeAttackLogsResponse>(req, "DescribeAttackLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高危命令列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsRequest"/></param>
        /// <returns><see cref="DescribeBashEventsResponse"/></returns>
        public Task<DescribeBashEventsResponse> DescribeBashEvents(DescribeBashEventsRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsResponse>(req, "DescribeBashEvents");
        }

        /// <summary>
        /// 获取高危命令列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsRequest"/></param>
        /// <returns><see cref="DescribeBashEventsResponse"/></returns>
        public DescribeBashEventsResponse DescribeBashEventsSync(DescribeBashEventsRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsResponse>(req, "DescribeBashEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高危命令规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashRulesRequest"/></param>
        /// <returns><see cref="DescribeBashRulesResponse"/></returns>
        public Task<DescribeBashRulesResponse> DescribeBashRules(DescribeBashRulesRequest req)
        {
            return InternalRequestAsync<DescribeBashRulesResponse>(req, "DescribeBashRules");
        }

        /// <summary>
        /// 获取高危命令规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBashRulesRequest"/></param>
        /// <returns><see cref="DescribeBashRulesResponse"/></returns>
        public DescribeBashRulesResponse DescribeBashRulesSync(DescribeBashRulesRequest req)
        {
            return InternalRequestAsync<DescribeBashRulesResponse>(req, "DescribeBashRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口{DescribeBruteAttacks}用于获取暴力破解事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeBruteAttacksResponse"/></returns>
        public Task<DescribeBruteAttacksResponse> DescribeBruteAttacks(DescribeBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttacksResponse>(req, "DescribeBruteAttacks");
        }

        /// <summary>
        /// 本接口{DescribeBruteAttacks}用于获取暴力破解事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeBruteAttacksResponse"/></returns>
        public DescribeBruteAttacksResponse DescribeBruteAttacksSync(DescribeBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttacksResponse>(req, "DescribeBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeComponentInfo) 用于获取组件信息数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentInfoRequest"/></param>
        /// <returns><see cref="DescribeComponentInfoResponse"/></returns>
        public Task<DescribeComponentInfoResponse> DescribeComponentInfo(DescribeComponentInfoRequest req)
        {
            return InternalRequestAsync<DescribeComponentInfoResponse>(req, "DescribeComponentInfo");
        }

        /// <summary>
        /// 本接口 (DescribeComponentInfo) 用于获取组件信息数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentInfoRequest"/></param>
        /// <returns><see cref="DescribeComponentInfoResponse"/></returns>
        public DescribeComponentInfoResponse DescribeComponentInfoSync(DescribeComponentInfoRequest req)
        {
            return InternalRequestAsync<DescribeComponentInfoResponse>(req, "DescribeComponentInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeComponentStatistics) 用于获取组件统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public Task<DescribeComponentStatisticsResponse> DescribeComponentStatistics(DescribeComponentStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComponentStatisticsResponse>(req, "DescribeComponentStatistics");
        }

        /// <summary>
        /// 本接口 (DescribeComponentStatistics) 用于获取组件统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public DescribeComponentStatisticsResponse DescribeComponentStatisticsSync(DescribeComponentStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComponentStatisticsResponse>(req, "DescribeComponentStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeComponents) 用于获取组件列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentsRequest"/></param>
        /// <returns><see cref="DescribeComponentsResponse"/></returns>
        public Task<DescribeComponentsResponse> DescribeComponents(DescribeComponentsRequest req)
        {
            return InternalRequestAsync<DescribeComponentsResponse>(req, "DescribeComponents");
        }

        /// <summary>
        /// 本接口 (DescribeComponents) 用于获取组件列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentsRequest"/></param>
        /// <returns><see cref="DescribeComponentsResponse"/></returns>
        public DescribeComponentsResponse DescribeComponentsSync(DescribeComponentsRequest req)
        {
            return InternalRequestAsync<DescribeComponentsResponse>(req, "DescribeComponents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeHistoryAccounts) 用于获取帐号变更历史列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public Task<DescribeHistoryAccountsResponse> DescribeHistoryAccounts(DescribeHistoryAccountsRequest req)
        {
            return InternalRequestAsync<DescribeHistoryAccountsResponse>(req, "DescribeHistoryAccounts");
        }

        /// <summary>
        /// 本接口 (DescribeHistoryAccounts) 用于获取帐号变更历史列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public DescribeHistoryAccountsResponse DescribeHistoryAccountsSync(DescribeHistoryAccountsRequest req)
        {
            return InternalRequestAsync<DescribeHistoryAccountsResponse>(req, "DescribeHistoryAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeImpactedHosts) 用于获取漏洞受影响机器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeImpactedHostsRequest"/></param>
        /// <returns><see cref="DescribeImpactedHostsResponse"/></returns>
        public Task<DescribeImpactedHostsResponse> DescribeImpactedHosts(DescribeImpactedHostsRequest req)
        {
            return InternalRequestAsync<DescribeImpactedHostsResponse>(req, "DescribeImpactedHosts");
        }

        /// <summary>
        /// 本接口 (DescribeImpactedHosts) 用于获取漏洞受影响机器列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeImpactedHostsRequest"/></param>
        /// <returns><see cref="DescribeImpactedHostsResponse"/></returns>
        public DescribeImpactedHostsResponse DescribeImpactedHostsSync(DescribeImpactedHostsRequest req)
        {
            return InternalRequestAsync<DescribeImpactedHostsResponse>(req, "DescribeImpactedHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取异地登录白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public Task<DescribeLoginWhiteListResponse> DescribeLoginWhiteList(DescribeLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteListResponse>(req, "DescribeLoginWhiteList");
        }

        /// <summary>
        /// 获取异地登录白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public DescribeLoginWhiteListResponse DescribeLoginWhiteListSync(DescribeLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteListResponse>(req, "DescribeLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMachineInfo）用于获取机器详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeMachineInfoResponse"/></returns>
        public Task<DescribeMachineInfoResponse> DescribeMachineInfo(DescribeMachineInfoRequest req)
        {
            return InternalRequestAsync<DescribeMachineInfoResponse>(req, "DescribeMachineInfo");
        }

        /// <summary>
        /// 本接口（DescribeMachineInfo）用于获取机器详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeMachineInfoResponse"/></returns>
        public DescribeMachineInfoResponse DescribeMachineInfoSync(DescribeMachineInfoRequest req)
        {
            return InternalRequestAsync<DescribeMachineInfoResponse>(req, "DescribeMachineInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeMachines) 用于获取区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines");
        }

        /// <summary>
        /// 本接口 (DescribeMachines) 用于获取区域主机列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeMaliciousRequests) 用于获取恶意请求数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestsResponse"/></returns>
        public Task<DescribeMaliciousRequestsResponse> DescribeMaliciousRequests(DescribeMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DescribeMaliciousRequestsResponse>(req, "DescribeMaliciousRequests");
        }

        /// <summary>
        /// 本接口 (DescribeMaliciousRequests) 用于获取恶意请求数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestsResponse"/></returns>
        public DescribeMaliciousRequestsResponse DescribeMaliciousRequestsSync(DescribeMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DescribeMaliciousRequestsResponse>(req, "DescribeMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMalwares）用于获取木马事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwaresRequest"/></param>
        /// <returns><see cref="DescribeMalwaresResponse"/></returns>
        public Task<DescribeMalwaresResponse> DescribeMalwares(DescribeMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeMalwaresResponse>(req, "DescribeMalwares");
        }

        /// <summary>
        /// 本接口（DescribeMalwares）用于获取木马事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwaresRequest"/></param>
        /// <returns><see cref="DescribeMalwaresResponse"/></returns>
        public DescribeMalwaresResponse DescribeMalwaresSync(DescribeMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeMalwaresResponse>(req, "DescribeMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeNonlocalLoginPlaces)用于获取异地登录事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeNonlocalLoginPlacesResponse"/></returns>
        public Task<DescribeNonlocalLoginPlacesResponse> DescribeNonlocalLoginPlaces(DescribeNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeNonlocalLoginPlacesResponse>(req, "DescribeNonlocalLoginPlaces");
        }

        /// <summary>
        /// 本接口(DescribeNonlocalLoginPlaces)用于获取异地登录事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeNonlocalLoginPlacesResponse"/></returns>
        public DescribeNonlocalLoginPlacesResponse DescribeNonlocalLoginPlacesSync(DescribeNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeNonlocalLoginPlacesResponse>(req, "DescribeNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeOpenPortStatistics) 用于获取端口统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public Task<DescribeOpenPortStatisticsResponse> DescribeOpenPortStatistics(DescribeOpenPortStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortStatisticsResponse>(req, "DescribeOpenPortStatistics");
        }

        /// <summary>
        /// 本接口 (DescribeOpenPortStatistics) 用于获取端口统计列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public DescribeOpenPortStatisticsResponse DescribeOpenPortStatisticsSync(DescribeOpenPortStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortStatisticsResponse>(req, "DescribeOpenPortStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeOpenPortTaskStatus) 用于获取实时拉取端口任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeOpenPortTaskStatusResponse"/></returns>
        public Task<DescribeOpenPortTaskStatusResponse> DescribeOpenPortTaskStatus(DescribeOpenPortTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortTaskStatusResponse>(req, "DescribeOpenPortTaskStatus");
        }

        /// <summary>
        /// 本接口 (DescribeOpenPortTaskStatus) 用于获取实时拉取端口任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeOpenPortTaskStatusResponse"/></returns>
        public DescribeOpenPortTaskStatusResponse DescribeOpenPortTaskStatusSync(DescribeOpenPortTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortTaskStatusResponse>(req, "DescribeOpenPortTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeOpenPorts) 用于获取端口列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortsResponse"/></returns>
        public Task<DescribeOpenPortsResponse> DescribeOpenPorts(DescribeOpenPortsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortsResponse>(req, "DescribeOpenPorts");
        }

        /// <summary>
        /// 本接口 (DescribeOpenPorts) 用于获取端口列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortsResponse"/></returns>
        public DescribeOpenPortsResponse DescribeOpenPortsSync(DescribeOpenPortsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortsResponse>(req, "DescribeOpenPorts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于（DescribeOverviewStatistics）获取概览统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public Task<DescribeOverviewStatisticsResponse> DescribeOverviewStatistics(DescribeOverviewStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOverviewStatisticsResponse>(req, "DescribeOverviewStatistics");
        }

        /// <summary>
        /// 本接口用于（DescribeOverviewStatistics）获取概览统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public DescribeOverviewStatisticsResponse DescribeOverviewStatisticsSync(DescribeOverviewStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOverviewStatisticsResponse>(req, "DescribeOverviewStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取本地提权事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventsResponse"/></returns>
        public Task<DescribePrivilegeEventsResponse> DescribePrivilegeEvents(DescribePrivilegeEventsRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeEventsResponse>(req, "DescribePrivilegeEvents");
        }

        /// <summary>
        /// 获取本地提权事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventsResponse"/></returns>
        public DescribePrivilegeEventsResponse DescribePrivilegeEventsSync(DescribePrivilegeEventsRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeEventsResponse>(req, "DescribePrivilegeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取本地提权规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DescribePrivilegeRulesResponse"/></returns>
        public Task<DescribePrivilegeRulesResponse> DescribePrivilegeRules(DescribePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeRulesResponse>(req, "DescribePrivilegeRules");
        }

        /// <summary>
        /// 获取本地提权规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DescribePrivilegeRulesResponse"/></returns>
        public DescribePrivilegeRulesResponse DescribePrivilegeRulesSync(DescribePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeRulesResponse>(req, "DescribePrivilegeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeProVersionInfo) 用于获取专业版信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public Task<DescribeProVersionInfoResponse> DescribeProVersionInfo(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo");
        }

        /// <summary>
        /// 本接口 (DescribeProVersionInfo) 用于获取专业版信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public DescribeProVersionInfoResponse DescribeProVersionInfoSync(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeProcessStatistics) 用于获取进程统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public Task<DescribeProcessStatisticsResponse> DescribeProcessStatistics(DescribeProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProcessStatisticsResponse>(req, "DescribeProcessStatistics");
        }

        /// <summary>
        /// 本接口 (DescribeProcessStatistics) 用于获取进程统计列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public DescribeProcessStatisticsResponse DescribeProcessStatisticsSync(DescribeProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProcessStatisticsResponse>(req, "DescribeProcessStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeProcessTaskStatus) 用于获取实时拉取进程任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeProcessTaskStatusResponse"/></returns>
        public Task<DescribeProcessTaskStatusResponse> DescribeProcessTaskStatus(DescribeProcessTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeProcessTaskStatusResponse>(req, "DescribeProcessTaskStatus");
        }

        /// <summary>
        /// 本接口 (DescribeProcessTaskStatus) 用于获取实时拉取进程任务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeProcessTaskStatusResponse"/></returns>
        public DescribeProcessTaskStatusResponse DescribeProcessTaskStatusSync(DescribeProcessTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeProcessTaskStatusResponse>(req, "DescribeProcessTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeProcesses) 用于获取进程列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessesRequest"/></param>
        /// <returns><see cref="DescribeProcessesResponse"/></returns>
        public Task<DescribeProcessesResponse> DescribeProcesses(DescribeProcessesRequest req)
        {
            return InternalRequestAsync<DescribeProcessesResponse>(req, "DescribeProcesses");
        }

        /// <summary>
        /// 本接口 (DescribeProcesses) 用于获取进程列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessesRequest"/></param>
        /// <returns><see cref="DescribeProcessesResponse"/></returns>
        public DescribeProcessesResponse DescribeProcessesSync(DescribeProcessesRequest req)
        {
            return InternalRequestAsync<DescribeProcessesResponse>(req, "DescribeProcesses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取反弹Shell列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public Task<DescribeReverseShellEventsResponse> DescribeReverseShellEvents(DescribeReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsResponse>(req, "DescribeReverseShellEvents");
        }

        /// <summary>
        /// 获取反弹Shell列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public DescribeReverseShellEventsResponse DescribeReverseShellEventsSync(DescribeReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsResponse>(req, "DescribeReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取反弹Shell规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellRulesRequest"/></param>
        /// <returns><see cref="DescribeReverseShellRulesResponse"/></returns>
        public Task<DescribeReverseShellRulesResponse> DescribeReverseShellRules(DescribeReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellRulesResponse>(req, "DescribeReverseShellRules");
        }

        /// <summary>
        /// 获取反弹Shell规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellRulesRequest"/></param>
        /// <returns><see cref="DescribeReverseShellRulesResponse"/></returns>
        public DescribeReverseShellRulesResponse DescribeReverseShellRulesSync(DescribeReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellRulesResponse>(req, "DescribeReverseShellRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeSecurityDynamics) 用于获取安全事件消息数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public Task<DescribeSecurityDynamicsResponse> DescribeSecurityDynamics(DescribeSecurityDynamicsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityDynamicsResponse>(req, "DescribeSecurityDynamics");
        }

        /// <summary>
        /// 本接口 (DescribeSecurityDynamics) 用于获取安全事件消息数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public DescribeSecurityDynamicsResponse DescribeSecurityDynamicsSync(DescribeSecurityDynamicsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityDynamicsResponse>(req, "DescribeSecurityDynamics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeSecurityTrends) 用于获取安全事件统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public Task<DescribeSecurityTrendsResponse> DescribeSecurityTrends(DescribeSecurityTrendsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTrendsResponse>(req, "DescribeSecurityTrends");
        }

        /// <summary>
        /// 本接口 (DescribeSecurityTrends) 用于获取安全事件统计数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public DescribeSecurityTrendsResponse DescribeSecurityTrendsSync(DescribeSecurityTrendsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTrendsResponse>(req, "DescribeSecurityTrends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定标签关联的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public Task<DescribeTagMachinesResponse> DescribeTagMachines(DescribeTagMachinesRequest req)
        {
            return InternalRequestAsync<DescribeTagMachinesResponse>(req, "DescribeTagMachines");
        }

        /// <summary>
        /// 获取指定标签关联的服务器信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public DescribeTagMachinesResponse DescribeTagMachinesSync(DescribeTagMachinesRequest req)
        {
            return InternalRequestAsync<DescribeTagMachinesResponse>(req, "DescribeTagMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取所有主机标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags");
        }

        /// <summary>
        /// 获取所有主机标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeUsualLoginPlaces）用于查询常用登录地。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public Task<DescribeUsualLoginPlacesResponse> DescribeUsualLoginPlaces(DescribeUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeUsualLoginPlacesResponse>(req, "DescribeUsualLoginPlaces");
        }

        /// <summary>
        /// 此接口（DescribeUsualLoginPlaces）用于查询常用登录地。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public DescribeUsualLoginPlacesResponse DescribeUsualLoginPlacesSync(DescribeUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeUsualLoginPlacesResponse>(req, "DescribeUsualLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeVulInfo) 用于获取漏洞详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoRequest"/></param>
        /// <returns><see cref="DescribeVulInfoResponse"/></returns>
        public Task<DescribeVulInfoResponse> DescribeVulInfo(DescribeVulInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulInfoResponse>(req, "DescribeVulInfo");
        }

        /// <summary>
        /// 本接口 (DescribeVulInfo) 用于获取漏洞详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoRequest"/></param>
        /// <returns><see cref="DescribeVulInfoResponse"/></returns>
        public DescribeVulInfoResponse DescribeVulInfoSync(DescribeVulInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulInfoResponse>(req, "DescribeVulInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeVulScanResult) 用于获取漏洞检测结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanResultRequest"/></param>
        /// <returns><see cref="DescribeVulScanResultResponse"/></returns>
        public Task<DescribeVulScanResultResponse> DescribeVulScanResult(DescribeVulScanResultRequest req)
        {
            return InternalRequestAsync<DescribeVulScanResultResponse>(req, "DescribeVulScanResult");
        }

        /// <summary>
        /// 本接口 (DescribeVulScanResult) 用于获取漏洞检测结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanResultRequest"/></param>
        /// <returns><see cref="DescribeVulScanResultResponse"/></returns>
        public DescribeVulScanResultResponse DescribeVulScanResultSync(DescribeVulScanResultRequest req)
        {
            return InternalRequestAsync<DescribeVulScanResultResponse>(req, "DescribeVulScanResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeVuls) 用于获取漏洞列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public Task<DescribeVulsResponse> DescribeVuls(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls");
        }

        /// <summary>
        /// 本接口 (DescribeVuls) 用于获取漏洞列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public DescribeVulsResponse DescribeVulsSync(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportBruteAttacks) 用于获取专业周报密码破解数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportBruteAttacksResponse"/></returns>
        public Task<DescribeWeeklyReportBruteAttacksResponse> DescribeWeeklyReportBruteAttacks(DescribeWeeklyReportBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportBruteAttacksResponse>(req, "DescribeWeeklyReportBruteAttacks");
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportBruteAttacks) 用于获取专业周报密码破解数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportBruteAttacksResponse"/></returns>
        public DescribeWeeklyReportBruteAttacksResponse DescribeWeeklyReportBruteAttacksSync(DescribeWeeklyReportBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportBruteAttacksResponse>(req, "DescribeWeeklyReportBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportInfo) 用于获取专业周报详情数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportInfoRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportInfoResponse"/></returns>
        public Task<DescribeWeeklyReportInfoResponse> DescribeWeeklyReportInfo(DescribeWeeklyReportInfoRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportInfoResponse>(req, "DescribeWeeklyReportInfo");
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportInfo) 用于获取专业周报详情数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportInfoRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportInfoResponse"/></returns>
        public DescribeWeeklyReportInfoResponse DescribeWeeklyReportInfoSync(DescribeWeeklyReportInfoRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportInfoResponse>(req, "DescribeWeeklyReportInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportMalwares) 用于获取专业周报木马数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportMalwaresRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportMalwaresResponse"/></returns>
        public Task<DescribeWeeklyReportMalwaresResponse> DescribeWeeklyReportMalwares(DescribeWeeklyReportMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportMalwaresResponse>(req, "DescribeWeeklyReportMalwares");
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportMalwares) 用于获取专业周报木马数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportMalwaresRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportMalwaresResponse"/></returns>
        public DescribeWeeklyReportMalwaresResponse DescribeWeeklyReportMalwaresSync(DescribeWeeklyReportMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportMalwaresResponse>(req, "DescribeWeeklyReportMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportNonlocalLoginPlaces) 用于获取专业周报异地登录数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportNonlocalLoginPlacesResponse"/></returns>
        public Task<DescribeWeeklyReportNonlocalLoginPlacesResponse> DescribeWeeklyReportNonlocalLoginPlaces(DescribeWeeklyReportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportNonlocalLoginPlacesResponse>(req, "DescribeWeeklyReportNonlocalLoginPlaces");
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportNonlocalLoginPlaces) 用于获取专业周报异地登录数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportNonlocalLoginPlacesResponse"/></returns>
        public DescribeWeeklyReportNonlocalLoginPlacesResponse DescribeWeeklyReportNonlocalLoginPlacesSync(DescribeWeeklyReportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportNonlocalLoginPlacesResponse>(req, "DescribeWeeklyReportNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportVuls) 用于专业版周报漏洞数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportVulsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportVulsResponse"/></returns>
        public Task<DescribeWeeklyReportVulsResponse> DescribeWeeklyReportVuls(DescribeWeeklyReportVulsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportVulsResponse>(req, "DescribeWeeklyReportVuls");
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReportVuls) 用于专业版周报漏洞数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportVulsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportVulsResponse"/></returns>
        public DescribeWeeklyReportVulsResponse DescribeWeeklyReportVulsSync(DescribeWeeklyReportVulsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportVulsResponse>(req, "DescribeWeeklyReportVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReports) 用于获取周报列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportsResponse"/></returns>
        public Task<DescribeWeeklyReportsResponse> DescribeWeeklyReports(DescribeWeeklyReportsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportsResponse>(req, "DescribeWeeklyReports");
        }

        /// <summary>
        /// 本接口 (DescribeWeeklyReports) 用于获取周报列表数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportsResponse"/></returns>
        public DescribeWeeklyReportsResponse DescribeWeeklyReportsSync(DescribeWeeklyReportsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportsResponse>(req, "DescribeWeeklyReports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增或修改高危命令规则
        /// </summary>
        /// <param name="req"><see cref="EditBashRuleRequest"/></param>
        /// <returns><see cref="EditBashRuleResponse"/></returns>
        public Task<EditBashRuleResponse> EditBashRule(EditBashRuleRequest req)
        {
            return InternalRequestAsync<EditBashRuleResponse>(req, "EditBashRule");
        }

        /// <summary>
        /// 新增或修改高危命令规则
        /// </summary>
        /// <param name="req"><see cref="EditBashRuleRequest"/></param>
        /// <returns><see cref="EditBashRuleResponse"/></returns>
        public EditBashRuleResponse EditBashRuleSync(EditBashRuleRequest req)
        {
            return InternalRequestAsync<EditBashRuleResponse>(req, "EditBashRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增或修改本地提权规则
        /// </summary>
        /// <param name="req"><see cref="EditPrivilegeRuleRequest"/></param>
        /// <returns><see cref="EditPrivilegeRuleResponse"/></returns>
        public Task<EditPrivilegeRuleResponse> EditPrivilegeRule(EditPrivilegeRuleRequest req)
        {
            return InternalRequestAsync<EditPrivilegeRuleResponse>(req, "EditPrivilegeRule");
        }

        /// <summary>
        /// 新增或修改本地提权规则
        /// </summary>
        /// <param name="req"><see cref="EditPrivilegeRuleRequest"/></param>
        /// <returns><see cref="EditPrivilegeRuleResponse"/></returns>
        public EditPrivilegeRuleResponse EditPrivilegeRuleSync(EditPrivilegeRuleRequest req)
        {
            return InternalRequestAsync<EditPrivilegeRuleResponse>(req, "EditPrivilegeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑反弹Shell规则
        /// </summary>
        /// <param name="req"><see cref="EditReverseShellRuleRequest"/></param>
        /// <returns><see cref="EditReverseShellRuleResponse"/></returns>
        public Task<EditReverseShellRuleResponse> EditReverseShellRule(EditReverseShellRuleRequest req)
        {
            return InternalRequestAsync<EditReverseShellRuleResponse>(req, "EditReverseShellRule");
        }

        /// <summary>
        /// 编辑反弹Shell规则
        /// </summary>
        /// <param name="req"><see cref="EditReverseShellRuleRequest"/></param>
        /// <returns><see cref="EditReverseShellRuleResponse"/></returns>
        public EditReverseShellRuleResponse EditReverseShellRuleSync(EditReverseShellRuleRequest req)
        {
            return InternalRequestAsync<EditReverseShellRuleResponse>(req, "EditReverseShellRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增或编辑标签
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public Task<EditTagsResponse> EditTags(EditTagsRequest req)
        {
            return InternalRequestAsync<EditTagsResponse>(req, "EditTags");
        }

        /// <summary>
        /// 新增或编辑标签
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public EditTagsResponse EditTagsSync(EditTagsRequest req)
        {
            return InternalRequestAsync<EditTagsResponse>(req, "EditTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="ExportAttackLogsRequest"/></param>
        /// <returns><see cref="ExportAttackLogsResponse"/></returns>
        public Task<ExportAttackLogsResponse> ExportAttackLogs(ExportAttackLogsRequest req)
        {
            return InternalRequestAsync<ExportAttackLogsResponse>(req, "ExportAttackLogs");
        }

        /// <summary>
        /// 导出网络攻击日志
        /// </summary>
        /// <param name="req"><see cref="ExportAttackLogsRequest"/></param>
        /// <returns><see cref="ExportAttackLogsResponse"/></returns>
        public ExportAttackLogsResponse ExportAttackLogsSync(ExportAttackLogsRequest req)
        {
            return InternalRequestAsync<ExportAttackLogsResponse>(req, "ExportAttackLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出高危命令事件
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsRequest"/></param>
        /// <returns><see cref="ExportBashEventsResponse"/></returns>
        public Task<ExportBashEventsResponse> ExportBashEvents(ExportBashEventsRequest req)
        {
            return InternalRequestAsync<ExportBashEventsResponse>(req, "ExportBashEvents");
        }

        /// <summary>
        /// 导出高危命令事件
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsRequest"/></param>
        /// <returns><see cref="ExportBashEventsResponse"/></returns>
        public ExportBashEventsResponse ExportBashEventsSync(ExportBashEventsRequest req)
        {
            return InternalRequestAsync<ExportBashEventsResponse>(req, "ExportBashEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ExportBruteAttacks) 用于导出密码破解记录成CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public Task<ExportBruteAttacksResponse> ExportBruteAttacks(ExportBruteAttacksRequest req)
        {
            return InternalRequestAsync<ExportBruteAttacksResponse>(req, "ExportBruteAttacks");
        }

        /// <summary>
        /// 本接口 (ExportBruteAttacks) 用于导出密码破解记录成CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public ExportBruteAttacksResponse ExportBruteAttacksSync(ExportBruteAttacksRequest req)
        {
            return InternalRequestAsync<ExportBruteAttacksResponse>(req, "ExportBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ExportMaliciousRequests) 用于导出下载恶意请求文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public Task<ExportMaliciousRequestsResponse> ExportMaliciousRequests(ExportMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<ExportMaliciousRequestsResponse>(req, "ExportMaliciousRequests");
        }

        /// <summary>
        /// 本接口 (ExportMaliciousRequests) 用于导出下载恶意请求文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public ExportMaliciousRequestsResponse ExportMaliciousRequestsSync(ExportMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<ExportMaliciousRequestsResponse>(req, "ExportMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ExportMalwares) 用于导出木马记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public Task<ExportMalwaresResponse> ExportMalwares(ExportMalwaresRequest req)
        {
            return InternalRequestAsync<ExportMalwaresResponse>(req, "ExportMalwares");
        }

        /// <summary>
        /// 本接口 (ExportMalwares) 用于导出木马记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public ExportMalwaresResponse ExportMalwaresSync(ExportMalwaresRequest req)
        {
            return InternalRequestAsync<ExportMalwaresResponse>(req, "ExportMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ExportNonlocalLoginPlaces) 用于导出异地登录事件记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public Task<ExportNonlocalLoginPlacesResponse> ExportNonlocalLoginPlaces(ExportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<ExportNonlocalLoginPlacesResponse>(req, "ExportNonlocalLoginPlaces");
        }

        /// <summary>
        /// 本接口 (ExportNonlocalLoginPlaces) 用于导出异地登录事件记录CSV文件。
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public ExportNonlocalLoginPlacesResponse ExportNonlocalLoginPlacesSync(ExportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<ExportNonlocalLoginPlacesResponse>(req, "ExportNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出本地提权事件
        /// </summary>
        /// <param name="req"><see cref="ExportPrivilegeEventsRequest"/></param>
        /// <returns><see cref="ExportPrivilegeEventsResponse"/></returns>
        public Task<ExportPrivilegeEventsResponse> ExportPrivilegeEvents(ExportPrivilegeEventsRequest req)
        {
            return InternalRequestAsync<ExportPrivilegeEventsResponse>(req, "ExportPrivilegeEvents");
        }

        /// <summary>
        /// 导出本地提权事件
        /// </summary>
        /// <param name="req"><see cref="ExportPrivilegeEventsRequest"/></param>
        /// <returns><see cref="ExportPrivilegeEventsResponse"/></returns>
        public ExportPrivilegeEventsResponse ExportPrivilegeEventsSync(ExportPrivilegeEventsRequest req)
        {
            return InternalRequestAsync<ExportPrivilegeEventsResponse>(req, "ExportPrivilegeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="ExportReverseShellEventsRequest"/></param>
        /// <returns><see cref="ExportReverseShellEventsResponse"/></returns>
        public Task<ExportReverseShellEventsResponse> ExportReverseShellEvents(ExportReverseShellEventsRequest req)
        {
            return InternalRequestAsync<ExportReverseShellEventsResponse>(req, "ExportReverseShellEvents");
        }

        /// <summary>
        /// 导出反弹Shell事件
        /// </summary>
        /// <param name="req"><see cref="ExportReverseShellEventsRequest"/></param>
        /// <returns><see cref="ExportReverseShellEventsResponse"/></returns>
        public ExportReverseShellEventsResponse ExportReverseShellEventsSync(ExportReverseShellEventsRequest req)
        {
            return InternalRequestAsync<ExportReverseShellEventsResponse>(req, "ExportReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (IgnoreImpactedHosts) 用于忽略漏洞。
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public Task<IgnoreImpactedHostsResponse> IgnoreImpactedHosts(IgnoreImpactedHostsRequest req)
        {
            return InternalRequestAsync<IgnoreImpactedHostsResponse>(req, "IgnoreImpactedHosts");
        }

        /// <summary>
        /// 本接口 (IgnoreImpactedHosts) 用于忽略漏洞。
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public IgnoreImpactedHostsResponse IgnoreImpactedHostsSync(IgnoreImpactedHostsRequest req)
        {
            return InternalRequestAsync<IgnoreImpactedHostsResponse>(req, "IgnoreImpactedHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (InquiryPriceOpenProVersionPrepaid) 用于开通专业版询价(预付费)。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceOpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="InquiryPriceOpenProVersionPrepaidResponse"/></returns>
        public Task<InquiryPriceOpenProVersionPrepaidResponse> InquiryPriceOpenProVersionPrepaid(InquiryPriceOpenProVersionPrepaidRequest req)
        {
            return InternalRequestAsync<InquiryPriceOpenProVersionPrepaidResponse>(req, "InquiryPriceOpenProVersionPrepaid");
        }

        /// <summary>
        /// 本接口 (InquiryPriceOpenProVersionPrepaid) 用于开通专业版询价(预付费)。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceOpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="InquiryPriceOpenProVersionPrepaidResponse"/></returns>
        public InquiryPriceOpenProVersionPrepaidResponse InquiryPriceOpenProVersionPrepaidSync(InquiryPriceOpenProVersionPrepaidRequest req)
        {
            return InternalRequestAsync<InquiryPriceOpenProVersionPrepaidResponse>(req, "InquiryPriceOpenProVersionPrepaid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口{MisAlarmNonlocalLoginPlaces}将设置当前地点为常用登录地。
        /// </summary>
        /// <param name="req"><see cref="MisAlarmNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="MisAlarmNonlocalLoginPlacesResponse"/></returns>
        public Task<MisAlarmNonlocalLoginPlacesResponse> MisAlarmNonlocalLoginPlaces(MisAlarmNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<MisAlarmNonlocalLoginPlacesResponse>(req, "MisAlarmNonlocalLoginPlaces");
        }

        /// <summary>
        /// 本接口{MisAlarmNonlocalLoginPlaces}将设置当前地点为常用登录地。
        /// </summary>
        /// <param name="req"><see cref="MisAlarmNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="MisAlarmNonlocalLoginPlacesResponse"/></returns>
        public MisAlarmNonlocalLoginPlacesResponse MisAlarmNonlocalLoginPlacesSync(MisAlarmNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<MisAlarmNonlocalLoginPlacesResponse>(req, "MisAlarmNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAlarmAttribute）用于修改告警设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmAttributeRequest"/></param>
        /// <returns><see cref="ModifyAlarmAttributeResponse"/></returns>
        public Task<ModifyAlarmAttributeResponse> ModifyAlarmAttribute(ModifyAlarmAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmAttributeResponse>(req, "ModifyAlarmAttribute");
        }

        /// <summary>
        /// 本接口（ModifyAlarmAttribute）用于修改告警设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmAttributeRequest"/></param>
        /// <returns><see cref="ModifyAlarmAttributeResponse"/></returns>
        public ModifyAlarmAttributeResponse ModifyAlarmAttributeSync(ModifyAlarmAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmAttributeResponse>(req, "ModifyAlarmAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyAutoOpenProVersionConfig) 用于设置新增主机自动开通专业版配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public Task<ModifyAutoOpenProVersionConfigResponse> ModifyAutoOpenProVersionConfig(ModifyAutoOpenProVersionConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoOpenProVersionConfigResponse>(req, "ModifyAutoOpenProVersionConfig");
        }

        /// <summary>
        /// 本接口 (ModifyAutoOpenProVersionConfig) 用于设置新增主机自动开通专业版配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public ModifyAutoOpenProVersionConfigResponse ModifyAutoOpenProVersionConfigSync(ModifyAutoOpenProVersionConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoOpenProVersionConfigResponse>(req, "ModifyAutoOpenProVersionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑白名单规则
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteListRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteListResponse"/></returns>
        public Task<ModifyLoginWhiteListResponse> ModifyLoginWhiteList(ModifyLoginWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteListResponse>(req, "ModifyLoginWhiteList");
        }

        /// <summary>
        /// 编辑白名单规则
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteListRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteListResponse"/></returns>
        public ModifyLoginWhiteListResponse ModifyLoginWhiteListSync(ModifyLoginWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteListResponse>(req, "ModifyLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyProVersionRenewFlag) 用于修改专业版包年包月续费标识。
        /// </summary>
        /// <param name="req"><see cref="ModifyProVersionRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyProVersionRenewFlagResponse"/></returns>
        public Task<ModifyProVersionRenewFlagResponse> ModifyProVersionRenewFlag(ModifyProVersionRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyProVersionRenewFlagResponse>(req, "ModifyProVersionRenewFlag");
        }

        /// <summary>
        /// 本接口 (ModifyProVersionRenewFlag) 用于修改专业版包年包月续费标识。
        /// </summary>
        /// <param name="req"><see cref="ModifyProVersionRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyProVersionRenewFlagResponse"/></returns>
        public ModifyProVersionRenewFlagResponse ModifyProVersionRenewFlagSync(ModifyProVersionRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyProVersionRenewFlagResponse>(req, "ModifyProVersionRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (OpenProVersion) 用于开通专业版。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionRequest"/></param>
        /// <returns><see cref="OpenProVersionResponse"/></returns>
        public Task<OpenProVersionResponse> OpenProVersion(OpenProVersionRequest req)
        {
            return InternalRequestAsync<OpenProVersionResponse>(req, "OpenProVersion");
        }

        /// <summary>
        /// 本接口 (OpenProVersion) 用于开通专业版。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionRequest"/></param>
        /// <returns><see cref="OpenProVersionResponse"/></returns>
        public OpenProVersionResponse OpenProVersionSync(OpenProVersionRequest req)
        {
            return InternalRequestAsync<OpenProVersionResponse>(req, "OpenProVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (OpenProVersionPrepaid) 用于开通专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="OpenProVersionPrepaidResponse"/></returns>
        public Task<OpenProVersionPrepaidResponse> OpenProVersionPrepaid(OpenProVersionPrepaidRequest req)
        {
            return InternalRequestAsync<OpenProVersionPrepaidResponse>(req, "OpenProVersionPrepaid");
        }

        /// <summary>
        /// 本接口 (OpenProVersionPrepaid) 用于开通专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionPrepaidRequest"/></param>
        /// <returns><see cref="OpenProVersionPrepaidResponse"/></returns>
        public OpenProVersionPrepaidResponse OpenProVersionPrepaidSync(OpenProVersionPrepaidRequest req)
        {
            return InternalRequestAsync<OpenProVersionPrepaidResponse>(req, "OpenProVersionPrepaid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RecoverMalwares）用于批量恢复已经被隔离的木马文件。
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public Task<RecoverMalwaresResponse> RecoverMalwares(RecoverMalwaresRequest req)
        {
            return InternalRequestAsync<RecoverMalwaresResponse>(req, "RecoverMalwares");
        }

        /// <summary>
        /// 本接口（RecoverMalwares）用于批量恢复已经被隔离的木马文件。
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public RecoverMalwaresResponse RecoverMalwaresSync(RecoverMalwaresRequest req)
        {
            return InternalRequestAsync<RecoverMalwaresResponse>(req, "RecoverMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (RenewProVersion) 用于续费专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="RenewProVersionRequest"/></param>
        /// <returns><see cref="RenewProVersionResponse"/></returns>
        public Task<RenewProVersionResponse> RenewProVersion(RenewProVersionRequest req)
        {
            return InternalRequestAsync<RenewProVersionResponse>(req, "RenewProVersion");
        }

        /// <summary>
        /// 本接口 (RenewProVersion) 用于续费专业版(包年包月)。
        /// </summary>
        /// <param name="req"><see cref="RenewProVersionRequest"/></param>
        /// <returns><see cref="RenewProVersionResponse"/></returns>
        public RenewProVersionResponse RenewProVersionSync(RenewProVersionRequest req)
        {
            return InternalRequestAsync<RenewProVersionResponse>(req, "RenewProVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (RescanImpactedHost) 用于漏洞重新检测。
        /// </summary>
        /// <param name="req"><see cref="RescanImpactedHostRequest"/></param>
        /// <returns><see cref="RescanImpactedHostResponse"/></returns>
        public Task<RescanImpactedHostResponse> RescanImpactedHost(RescanImpactedHostRequest req)
        {
            return InternalRequestAsync<RescanImpactedHostResponse>(req, "RescanImpactedHost");
        }

        /// <summary>
        /// 本接口 (RescanImpactedHost) 用于漏洞重新检测。
        /// </summary>
        /// <param name="req"><see cref="RescanImpactedHostRequest"/></param>
        /// <returns><see cref="RescanImpactedHostResponse"/></returns>
        public RescanImpactedHostResponse RescanImpactedHostSync(RescanImpactedHostRequest req)
        {
            return InternalRequestAsync<RescanImpactedHostResponse>(req, "RescanImpactedHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（SeparateMalwares）用于隔离木马。
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public Task<SeparateMalwaresResponse> SeparateMalwares(SeparateMalwaresRequest req)
        {
            return InternalRequestAsync<SeparateMalwaresResponse>(req, "SeparateMalwares");
        }

        /// <summary>
        /// 本接口（SeparateMalwares）用于隔离木马。
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public SeparateMalwaresResponse SeparateMalwaresSync(SeparateMalwaresRequest req)
        {
            return InternalRequestAsync<SeparateMalwaresResponse>(req, "SeparateMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置高危命令事件状态
        /// </summary>
        /// <param name="req"><see cref="SetBashEventsStatusRequest"/></param>
        /// <returns><see cref="SetBashEventsStatusResponse"/></returns>
        public Task<SetBashEventsStatusResponse> SetBashEventsStatus(SetBashEventsStatusRequest req)
        {
            return InternalRequestAsync<SetBashEventsStatusResponse>(req, "SetBashEventsStatus");
        }

        /// <summary>
        /// 设置高危命令事件状态
        /// </summary>
        /// <param name="req"><see cref="SetBashEventsStatusRequest"/></param>
        /// <returns><see cref="SetBashEventsStatusResponse"/></returns>
        public SetBashEventsStatusResponse SetBashEventsStatusSync(SetBashEventsStatusRequest req)
        {
            return InternalRequestAsync<SetBashEventsStatusResponse>(req, "SetBashEventsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换高危命令规则状态
        /// </summary>
        /// <param name="req"><see cref="SwitchBashRulesRequest"/></param>
        /// <returns><see cref="SwitchBashRulesResponse"/></returns>
        public Task<SwitchBashRulesResponse> SwitchBashRules(SwitchBashRulesRequest req)
        {
            return InternalRequestAsync<SwitchBashRulesResponse>(req, "SwitchBashRules");
        }

        /// <summary>
        /// 切换高危命令规则状态
        /// </summary>
        /// <param name="req"><see cref="SwitchBashRulesRequest"/></param>
        /// <returns><see cref="SwitchBashRulesResponse"/></returns>
        public SwitchBashRulesResponse SwitchBashRulesSync(SwitchBashRulesRequest req)
        {
            return InternalRequestAsync<SwitchBashRulesResponse>(req, "SwitchBashRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (TrustMaliciousRequest) 用于恶意请求添加信任。
        /// </summary>
        /// <param name="req"><see cref="TrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="TrustMaliciousRequestResponse"/></returns>
        public Task<TrustMaliciousRequestResponse> TrustMaliciousRequest(TrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<TrustMaliciousRequestResponse>(req, "TrustMaliciousRequest");
        }

        /// <summary>
        /// 本接口 (TrustMaliciousRequest) 用于恶意请求添加信任。
        /// </summary>
        /// <param name="req"><see cref="TrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="TrustMaliciousRequestResponse"/></returns>
        public TrustMaliciousRequestResponse TrustMaliciousRequestSync(TrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<TrustMaliciousRequestResponse>(req, "TrustMaliciousRequest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(TrustMalwares)将被识别木马文件设为信任。
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public Task<TrustMalwaresResponse> TrustMalwares(TrustMalwaresRequest req)
        {
            return InternalRequestAsync<TrustMalwaresResponse>(req, "TrustMalwares");
        }

        /// <summary>
        /// 本接口(TrustMalwares)将被识别木马文件设为信任。
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public TrustMalwaresResponse TrustMalwaresSync(TrustMalwaresRequest req)
        {
            return InternalRequestAsync<TrustMalwaresResponse>(req, "TrustMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (UntrustMaliciousRequest) 用于取消信任恶意请求。
        /// </summary>
        /// <param name="req"><see cref="UntrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="UntrustMaliciousRequestResponse"/></returns>
        public Task<UntrustMaliciousRequestResponse> UntrustMaliciousRequest(UntrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<UntrustMaliciousRequestResponse>(req, "UntrustMaliciousRequest");
        }

        /// <summary>
        /// 本接口 (UntrustMaliciousRequest) 用于取消信任恶意请求。
        /// </summary>
        /// <param name="req"><see cref="UntrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="UntrustMaliciousRequestResponse"/></returns>
        public UntrustMaliciousRequestResponse UntrustMaliciousRequestSync(UntrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<UntrustMaliciousRequestResponse>(req, "UntrustMaliciousRequest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UntrustMalwares）用于取消信任木马文件。
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public Task<UntrustMalwaresResponse> UntrustMalwares(UntrustMalwaresRequest req)
        {
            return InternalRequestAsync<UntrustMalwaresResponse>(req, "UntrustMalwares");
        }

        /// <summary>
        /// 本接口（UntrustMalwares）用于取消信任木马文件。
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public UntrustMalwaresResponse UntrustMalwaresSync(UntrustMalwaresRequest req)
        {
            return InternalRequestAsync<UntrustMalwaresResponse>(req, "UntrustMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
