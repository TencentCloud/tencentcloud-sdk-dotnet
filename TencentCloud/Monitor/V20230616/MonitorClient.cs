/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Monitor.V20230616
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20230616.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.tencentcloudapi.com";
       private const string version = "2023-06-16";
       private const string sdkVersion = "SDK_NET_3.0.1496";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 取消对话执行
        /// </summary>
        /// <param name="req"><see cref="CancelAIWorkbenchChatRequest"/></param>
        /// <returns><see cref="CancelAIWorkbenchChatResponse"/></returns>
        public Task<CancelAIWorkbenchChatResponse> CancelAIWorkbenchChat(CancelAIWorkbenchChatRequest req)
        {
            return InternalRequestAsync<CancelAIWorkbenchChatResponse>(req, "CancelAIWorkbenchChat");
        }

        /// <summary>
        /// 取消对话执行
        /// </summary>
        /// <param name="req"><see cref="CancelAIWorkbenchChatRequest"/></param>
        /// <returns><see cref="CancelAIWorkbenchChatResponse"/></returns>
        public CancelAIWorkbenchChatResponse CancelAIWorkbenchChatSync(CancelAIWorkbenchChatRequest req)
        {
            return InternalRequestAsync<CancelAIWorkbenchChatResponse>(req, "CancelAIWorkbenchChat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Agent
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchAgentResponse"/></returns>
        public Task<CreateAIWorkbenchAgentResponse> CreateAIWorkbenchAgent(CreateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchAgentResponse>(req, "CreateAIWorkbenchAgent");
        }

        /// <summary>
        /// 创建 Agent
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchAgentResponse"/></returns>
        public CreateAIWorkbenchAgentResponse CreateAIWorkbenchAgentSync(CreateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchAgentResponse>(req, "CreateAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchTaskResponse"/></returns>
        public Task<CreateAIWorkbenchTaskResponse> CreateAIWorkbenchTask(CreateAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchTaskResponse>(req, "CreateAIWorkbenchTask");
        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="CreateAIWorkbenchTaskResponse"/></returns>
        public CreateAIWorkbenchTaskResponse CreateAIWorkbenchTaskSync(CreateAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<CreateAIWorkbenchTaskResponse>(req, "CreateAIWorkbenchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义通知内容模板
        /// </summary>
        /// <param name="req"><see cref="CreateNoticeContentTmplRequest"/></param>
        /// <returns><see cref="CreateNoticeContentTmplResponse"/></returns>
        public Task<CreateNoticeContentTmplResponse> CreateNoticeContentTmpl(CreateNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<CreateNoticeContentTmplResponse>(req, "CreateNoticeContentTmpl");
        }

        /// <summary>
        /// 创建自定义通知内容模板
        /// </summary>
        /// <param name="req"><see cref="CreateNoticeContentTmplRequest"/></param>
        /// <returns><see cref="CreateNoticeContentTmplResponse"/></returns>
        public CreateNoticeContentTmplResponse CreateNoticeContentTmplSync(CreateNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<CreateNoticeContentTmplResponse>(req, "CreateNoticeContentTmpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchAgentResponse"/></returns>
        public Task<DeleteAIWorkbenchAgentResponse> DeleteAIWorkbenchAgent(DeleteAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchAgentResponse>(req, "DeleteAIWorkbenchAgent");
        }

        /// <summary>
        /// 删除 Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchAgentResponse"/></returns>
        public DeleteAIWorkbenchAgentResponse DeleteAIWorkbenchAgentSync(DeleteAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchAgentResponse>(req, "DeleteAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchTaskResponse"/></returns>
        public Task<DeleteAIWorkbenchTaskResponse> DeleteAIWorkbenchTask(DeleteAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchTaskResponse>(req, "DeleteAIWorkbenchTask");
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="DeleteAIWorkbenchTaskResponse"/></returns>
        public DeleteAIWorkbenchTaskResponse DeleteAIWorkbenchTaskSync(DeleteAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<DeleteAIWorkbenchTaskResponse>(req, "DeleteAIWorkbenchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除通知内容模板
        /// </summary>
        /// <param name="req"><see cref="DeleteNoticeContentTmplsRequest"/></param>
        /// <returns><see cref="DeleteNoticeContentTmplsResponse"/></returns>
        public Task<DeleteNoticeContentTmplsResponse> DeleteNoticeContentTmpls(DeleteNoticeContentTmplsRequest req)
        {
            return InternalRequestAsync<DeleteNoticeContentTmplsResponse>(req, "DeleteNoticeContentTmpls");
        }

        /// <summary>
        /// 删除通知内容模板
        /// </summary>
        /// <param name="req"><see cref="DeleteNoticeContentTmplsRequest"/></param>
        /// <returns><see cref="DeleteNoticeContentTmplsResponse"/></returns>
        public DeleteNoticeContentTmplsResponse DeleteNoticeContentTmplsSync(DeleteNoticeContentTmplsRequest req)
        {
            return InternalRequestAsync<DeleteNoticeContentTmplsResponse>(req, "DeleteNoticeContentTmpls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Agent 详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchAgentResponse"/></returns>
        public Task<DescribeAIWorkbenchAgentResponse> DescribeAIWorkbenchAgent(DescribeAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchAgentResponse>(req, "DescribeAIWorkbenchAgent");
        }

        /// <summary>
        /// 查询 Agent 详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchAgentResponse"/></returns>
        public DescribeAIWorkbenchAgentResponse DescribeAIWorkbenchAgentSync(DescribeAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchAgentResponse>(req, "DescribeAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询制品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchArtifactRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchArtifactResponse"/></returns>
        public Task<DescribeAIWorkbenchArtifactResponse> DescribeAIWorkbenchArtifact(DescribeAIWorkbenchArtifactRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchArtifactResponse>(req, "DescribeAIWorkbenchArtifact");
        }

        /// <summary>
        /// 查询制品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchArtifactRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchArtifactResponse"/></returns>
        public DescribeAIWorkbenchArtifactResponse DescribeAIWorkbenchArtifactSync(DescribeAIWorkbenchArtifactRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchArtifactResponse>(req, "DescribeAIWorkbenchArtifact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询执行详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchExecutionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchExecutionResponse"/></returns>
        public Task<DescribeAIWorkbenchExecutionResponse> DescribeAIWorkbenchExecution(DescribeAIWorkbenchExecutionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchExecutionResponse>(req, "DescribeAIWorkbenchExecution");
        }

        /// <summary>
        /// 查询执行详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchExecutionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchExecutionResponse"/></returns>
        public DescribeAIWorkbenchExecutionResponse DescribeAIWorkbenchExecutionSync(DescribeAIWorkbenchExecutionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchExecutionResponse>(req, "DescribeAIWorkbenchExecution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI工作台SRE数字分身任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSREDigitalTwinTaskListRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSREDigitalTwinTaskListResponse"/></returns>
        public Task<DescribeAIWorkbenchSREDigitalTwinTaskListResponse> DescribeAIWorkbenchSREDigitalTwinTaskList(DescribeAIWorkbenchSREDigitalTwinTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSREDigitalTwinTaskListResponse>(req, "DescribeAIWorkbenchSREDigitalTwinTaskList");
        }

        /// <summary>
        /// 查询AI工作台SRE数字分身任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSREDigitalTwinTaskListRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSREDigitalTwinTaskListResponse"/></returns>
        public DescribeAIWorkbenchSREDigitalTwinTaskListResponse DescribeAIWorkbenchSREDigitalTwinTaskListSync(DescribeAIWorkbenchSREDigitalTwinTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSREDigitalTwinTaskListResponse>(req, "DescribeAIWorkbenchSREDigitalTwinTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI工作台SRE数字分身工作日志详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogDetailRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogDetailResponse"/></returns>
        public Task<DescribeAIWorkbenchSREDigitalTwinWorkLogDetailResponse> DescribeAIWorkbenchSREDigitalTwinWorkLogDetail(DescribeAIWorkbenchSREDigitalTwinWorkLogDetailRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSREDigitalTwinWorkLogDetailResponse>(req, "DescribeAIWorkbenchSREDigitalTwinWorkLogDetail");
        }

        /// <summary>
        /// 查询AI工作台SRE数字分身工作日志详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogDetailRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogDetailResponse"/></returns>
        public DescribeAIWorkbenchSREDigitalTwinWorkLogDetailResponse DescribeAIWorkbenchSREDigitalTwinWorkLogDetailSync(DescribeAIWorkbenchSREDigitalTwinWorkLogDetailRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSREDigitalTwinWorkLogDetailResponse>(req, "DescribeAIWorkbenchSREDigitalTwinWorkLogDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI工作台SRE数字分身任务工作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogListRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogListResponse"/></returns>
        public Task<DescribeAIWorkbenchSREDigitalTwinWorkLogListResponse> DescribeAIWorkbenchSREDigitalTwinWorkLogList(DescribeAIWorkbenchSREDigitalTwinWorkLogListRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSREDigitalTwinWorkLogListResponse>(req, "DescribeAIWorkbenchSREDigitalTwinWorkLogList");
        }

        /// <summary>
        /// 查询AI工作台SRE数字分身任务工作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogListRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSREDigitalTwinWorkLogListResponse"/></returns>
        public DescribeAIWorkbenchSREDigitalTwinWorkLogListResponse DescribeAIWorkbenchSREDigitalTwinWorkLogListSync(DescribeAIWorkbenchSREDigitalTwinWorkLogListRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSREDigitalTwinWorkLogListResponse>(req, "DescribeAIWorkbenchSREDigitalTwinWorkLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询会话详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSessionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSessionResponse"/></returns>
        public Task<DescribeAIWorkbenchSessionResponse> DescribeAIWorkbenchSession(DescribeAIWorkbenchSessionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSessionResponse>(req, "DescribeAIWorkbenchSession");
        }

        /// <summary>
        /// 查询会话详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSessionRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSessionResponse"/></returns>
        public DescribeAIWorkbenchSessionResponse DescribeAIWorkbenchSessionSync(DescribeAIWorkbenchSessionRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSessionResponse>(req, "DescribeAIWorkbenchSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询技能详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSkillRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSkillResponse"/></returns>
        public Task<DescribeAIWorkbenchSkillResponse> DescribeAIWorkbenchSkill(DescribeAIWorkbenchSkillRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSkillResponse>(req, "DescribeAIWorkbenchSkill");
        }

        /// <summary>
        /// 查询技能详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAIWorkbenchSkillRequest"/></param>
        /// <returns><see cref="DescribeAIWorkbenchSkillResponse"/></returns>
        public DescribeAIWorkbenchSkillResponse DescribeAIWorkbenchSkillSync(DescribeAIWorkbenchSkillRequest req)
        {
            return InternalRequestAsync<DescribeAIWorkbenchSkillResponse>(req, "DescribeAIWorkbenchSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按需查询告警的通知历史
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNotifyHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNotifyHistoriesResponse"/></returns>
        public Task<DescribeAlarmNotifyHistoriesResponse> DescribeAlarmNotifyHistories(DescribeAlarmNotifyHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNotifyHistoriesResponse>(req, "DescribeAlarmNotifyHistories");
        }

        /// <summary>
        /// 按需查询告警的通知历史
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNotifyHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNotifyHistoriesResponse"/></returns>
        public DescribeAlarmNotifyHistoriesResponse DescribeAlarmNotifyHistoriesSync(DescribeAlarmNotifyHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNotifyHistoriesResponse>(req, "DescribeAlarmNotifyHistories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据查询条件获取自定义通知内容模板，若所有查询条件空，则获取账号下所有模板
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeContentTmplRequest"/></param>
        /// <returns><see cref="DescribeNoticeContentTmplResponse"/></returns>
        public Task<DescribeNoticeContentTmplResponse> DescribeNoticeContentTmpl(DescribeNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<DescribeNoticeContentTmplResponse>(req, "DescribeNoticeContentTmpl");
        }

        /// <summary>
        /// 根据查询条件获取自定义通知内容模板，若所有查询条件空，则获取账号下所有模板
        /// </summary>
        /// <param name="req"><see cref="DescribeNoticeContentTmplRequest"/></param>
        /// <returns><see cref="DescribeNoticeContentTmplResponse"/></returns>
        public DescribeNoticeContentTmplResponse DescribeNoticeContentTmplSync(DescribeNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<DescribeNoticeContentTmplResponse>(req, "DescribeNoticeContentTmpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取AI工作台制品的下载地址
        /// </summary>
        /// <param name="req"><see cref="GetAIWorkbenchArtifactDownloadURLRequest"/></param>
        /// <returns><see cref="GetAIWorkbenchArtifactDownloadURLResponse"/></returns>
        public Task<GetAIWorkbenchArtifactDownloadURLResponse> GetAIWorkbenchArtifactDownloadURL(GetAIWorkbenchArtifactDownloadURLRequest req)
        {
            return InternalRequestAsync<GetAIWorkbenchArtifactDownloadURLResponse>(req, "GetAIWorkbenchArtifactDownloadURL");
        }

        /// <summary>
        /// 获取AI工作台制品的下载地址
        /// </summary>
        /// <param name="req"><see cref="GetAIWorkbenchArtifactDownloadURLRequest"/></param>
        /// <returns><see cref="GetAIWorkbenchArtifactDownloadURLResponse"/></returns>
        public GetAIWorkbenchArtifactDownloadURLResponse GetAIWorkbenchArtifactDownloadURLSync(GetAIWorkbenchArtifactDownloadURLRequest req)
        {
            return InternalRequestAsync<GetAIWorkbenchArtifactDownloadURLResponse>(req, "GetAIWorkbenchArtifactDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Agent 列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchAgentsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchAgentsResponse"/></returns>
        public Task<ListAIWorkbenchAgentsResponse> ListAIWorkbenchAgents(ListAIWorkbenchAgentsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchAgentsResponse>(req, "ListAIWorkbenchAgents");
        }

        /// <summary>
        /// 查询 Agent 列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchAgentsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchAgentsResponse"/></returns>
        public ListAIWorkbenchAgentsResponse ListAIWorkbenchAgentsSync(ListAIWorkbenchAgentsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchAgentsResponse>(req, "ListAIWorkbenchAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询产物列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchArtifactsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchArtifactsResponse"/></returns>
        public Task<ListAIWorkbenchArtifactsResponse> ListAIWorkbenchArtifacts(ListAIWorkbenchArtifactsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchArtifactsResponse>(req, "ListAIWorkbenchArtifacts");
        }

        /// <summary>
        /// 查询产物列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchArtifactsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchArtifactsResponse"/></returns>
        public ListAIWorkbenchArtifactsResponse ListAIWorkbenchArtifactsSync(ListAIWorkbenchArtifactsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchArtifactsResponse>(req, "ListAIWorkbenchArtifacts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询执行列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchExecutionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchExecutionsResponse"/></returns>
        public Task<ListAIWorkbenchExecutionsResponse> ListAIWorkbenchExecutions(ListAIWorkbenchExecutionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchExecutionsResponse>(req, "ListAIWorkbenchExecutions");
        }

        /// <summary>
        /// 查询执行列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchExecutionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchExecutionsResponse"/></returns>
        public ListAIWorkbenchExecutionsResponse ListAIWorkbenchExecutionsSync(ListAIWorkbenchExecutionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchExecutionsResponse>(req, "ListAIWorkbenchExecutions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 MCP 列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMCPsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMCPsResponse"/></returns>
        public Task<ListAIWorkbenchMCPsResponse> ListAIWorkbenchMCPs(ListAIWorkbenchMCPsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMCPsResponse>(req, "ListAIWorkbenchMCPs");
        }

        /// <summary>
        /// 查询 MCP 列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMCPsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMCPsResponse"/></returns>
        public ListAIWorkbenchMCPsResponse ListAIWorkbenchMCPsSync(ListAIWorkbenchMCPsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMCPsResponse>(req, "ListAIWorkbenchMCPs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询消息列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMessagesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMessagesResponse"/></returns>
        public Task<ListAIWorkbenchMessagesResponse> ListAIWorkbenchMessages(ListAIWorkbenchMessagesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMessagesResponse>(req, "ListAIWorkbenchMessages");
        }

        /// <summary>
        /// 查询消息列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchMessagesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchMessagesResponse"/></returns>
        public ListAIWorkbenchMessagesResponse ListAIWorkbenchMessagesSync(ListAIWorkbenchMessagesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchMessagesResponse>(req, "ListAIWorkbenchMessages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出资源实例
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceInstancesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceInstancesResponse"/></returns>
        public Task<ListAIWorkbenchResourceInstancesResponse> ListAIWorkbenchResourceInstances(ListAIWorkbenchResourceInstancesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceInstancesResponse>(req, "ListAIWorkbenchResourceInstances");
        }

        /// <summary>
        /// 列出资源实例
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceInstancesRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceInstancesResponse"/></returns>
        public ListAIWorkbenchResourceInstancesResponse ListAIWorkbenchResourceInstancesSync(ListAIWorkbenchResourceInstancesRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceInstancesResponse>(req, "ListAIWorkbenchResourceInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源地图列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceMapsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceMapsResponse"/></returns>
        public Task<ListAIWorkbenchResourceMapsResponse> ListAIWorkbenchResourceMaps(ListAIWorkbenchResourceMapsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceMapsResponse>(req, "ListAIWorkbenchResourceMaps");
        }

        /// <summary>
        /// 查询资源地图列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchResourceMapsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchResourceMapsResponse"/></returns>
        public ListAIWorkbenchResourceMapsResponse ListAIWorkbenchResourceMapsSync(ListAIWorkbenchResourceMapsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchResourceMapsResponse>(req, "ListAIWorkbenchResourceMaps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询会话列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSessionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSessionsResponse"/></returns>
        public Task<ListAIWorkbenchSessionsResponse> ListAIWorkbenchSessions(ListAIWorkbenchSessionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSessionsResponse>(req, "ListAIWorkbenchSessions");
        }

        /// <summary>
        /// 查询会话列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSessionsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSessionsResponse"/></returns>
        public ListAIWorkbenchSessionsResponse ListAIWorkbenchSessionsSync(ListAIWorkbenchSessionsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSessionsResponse>(req, "ListAIWorkbenchSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询技能列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSkillsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSkillsResponse"/></returns>
        public Task<ListAIWorkbenchSkillsResponse> ListAIWorkbenchSkills(ListAIWorkbenchSkillsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSkillsResponse>(req, "ListAIWorkbenchSkills");
        }

        /// <summary>
        /// 查询技能列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchSkillsRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchSkillsResponse"/></returns>
        public ListAIWorkbenchSkillsResponse ListAIWorkbenchSkillsSync(ListAIWorkbenchSkillsRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchSkillsResponse>(req, "ListAIWorkbenchSkills")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchTasksRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchTasksResponse"/></returns>
        public Task<ListAIWorkbenchTasksResponse> ListAIWorkbenchTasks(ListAIWorkbenchTasksRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchTasksResponse>(req, "ListAIWorkbenchTasks");
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="ListAIWorkbenchTasksRequest"/></param>
        /// <returns><see cref="ListAIWorkbenchTasksResponse"/></returns>
        public ListAIWorkbenchTasksResponse ListAIWorkbenchTasksSync(ListAIWorkbenchTasksRequest req)
        {
            return InternalRequestAsync<ListAIWorkbenchTasksResponse>(req, "ListAIWorkbenchTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改通知内容模板
        /// </summary>
        /// <param name="req"><see cref="ModifyNoticeContentTmplRequest"/></param>
        /// <returns><see cref="ModifyNoticeContentTmplResponse"/></returns>
        public Task<ModifyNoticeContentTmplResponse> ModifyNoticeContentTmpl(ModifyNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<ModifyNoticeContentTmplResponse>(req, "ModifyNoticeContentTmpl");
        }

        /// <summary>
        /// 修改通知内容模板
        /// </summary>
        /// <param name="req"><see cref="ModifyNoticeContentTmplRequest"/></param>
        /// <returns><see cref="ModifyNoticeContentTmplResponse"/></returns>
        public ModifyNoticeContentTmplResponse ModifyNoticeContentTmplSync(ModifyNoticeContentTmplRequest req)
        {
            return InternalRequestAsync<ModifyNoticeContentTmplResponse>(req, "ModifyNoticeContentTmpl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 触发数字分身任务请求
        /// </summary>
        /// <param name="req"><see cref="TriggerAIWorkbenchSREDigitalTwinTaskRequest"/></param>
        /// <returns><see cref="TriggerAIWorkbenchSREDigitalTwinTaskResponse"/></returns>
        public Task<TriggerAIWorkbenchSREDigitalTwinTaskResponse> TriggerAIWorkbenchSREDigitalTwinTask(TriggerAIWorkbenchSREDigitalTwinTaskRequest req)
        {
            return InternalRequestAsync<TriggerAIWorkbenchSREDigitalTwinTaskResponse>(req, "TriggerAIWorkbenchSREDigitalTwinTask");
        }

        /// <summary>
        /// 触发数字分身任务请求
        /// </summary>
        /// <param name="req"><see cref="TriggerAIWorkbenchSREDigitalTwinTaskRequest"/></param>
        /// <returns><see cref="TriggerAIWorkbenchSREDigitalTwinTaskResponse"/></returns>
        public TriggerAIWorkbenchSREDigitalTwinTaskResponse TriggerAIWorkbenchSREDigitalTwinTaskSync(TriggerAIWorkbenchSREDigitalTwinTaskRequest req)
        {
            return InternalRequestAsync<TriggerAIWorkbenchSREDigitalTwinTaskResponse>(req, "TriggerAIWorkbenchSREDigitalTwinTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手动触发任务
        /// </summary>
        /// <param name="req"><see cref="TriggerAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="TriggerAIWorkbenchTaskResponse"/></returns>
        public Task<TriggerAIWorkbenchTaskResponse> TriggerAIWorkbenchTask(TriggerAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<TriggerAIWorkbenchTaskResponse>(req, "TriggerAIWorkbenchTask");
        }

        /// <summary>
        /// 手动触发任务
        /// </summary>
        /// <param name="req"><see cref="TriggerAIWorkbenchTaskRequest"/></param>
        /// <returns><see cref="TriggerAIWorkbenchTaskResponse"/></returns>
        public TriggerAIWorkbenchTaskResponse TriggerAIWorkbenchTaskSync(TriggerAIWorkbenchTaskRequest req)
        {
            return InternalRequestAsync<TriggerAIWorkbenchTaskResponse>(req, "TriggerAIWorkbenchTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Agent
        /// </summary>
        /// <param name="req"><see cref="UpdateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="UpdateAIWorkbenchAgentResponse"/></returns>
        public Task<UpdateAIWorkbenchAgentResponse> UpdateAIWorkbenchAgent(UpdateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<UpdateAIWorkbenchAgentResponse>(req, "UpdateAIWorkbenchAgent");
        }

        /// <summary>
        /// 更新 Agent
        /// </summary>
        /// <param name="req"><see cref="UpdateAIWorkbenchAgentRequest"/></param>
        /// <returns><see cref="UpdateAIWorkbenchAgentResponse"/></returns>
        public UpdateAIWorkbenchAgentResponse UpdateAIWorkbenchAgentSync(UpdateAIWorkbenchAgentRequest req)
        {
            return InternalRequestAsync<UpdateAIWorkbenchAgentResponse>(req, "UpdateAIWorkbenchAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
