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

namespace TencentCloud.Tdai.V20250717
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdai.V20250717.Models;

   public class TdaiClient : AbstractClient{

       private const string endpoint = "tdai.tencentcloudapi.com";
       private const string version = "2025-07-17";
       private const string sdkVersion = "SDK_NET_3.0.1365";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（ContinueAgentWork）用于重启智能体实例的值守任务，通常在用户需要重启时使用。
        /// </summary>
        /// <param name="req"><see cref="ContinueAgentWorkRequest"/></param>
        /// <returns><see cref="ContinueAgentWorkResponse"/></returns>
        public Task<ContinueAgentWorkResponse> ContinueAgentWork(ContinueAgentWorkRequest req)
        {
            return InternalRequestAsync<ContinueAgentWorkResponse>(req, "ContinueAgentWork");
        }

        /// <summary>
        /// 本接口（ContinueAgentWork）用于重启智能体实例的值守任务，通常在用户需要重启时使用。
        /// </summary>
        /// <param name="req"><see cref="ContinueAgentWorkRequest"/></param>
        /// <returns><see cref="ContinueAgentWorkResponse"/></returns>
        public ContinueAgentWorkResponse ContinueAgentWorkSync(ContinueAgentWorkRequest req)
        {
            return InternalRequestAsync<ContinueAgentWorkResponse>(req, "ContinueAgentWork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateAgentInstance）用于创建一个智能体实例，通常在用户购买一个智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentInstanceRequest"/></param>
        /// <returns><see cref="CreateAgentInstanceResponse"/></returns>
        public Task<CreateAgentInstanceResponse> CreateAgentInstance(CreateAgentInstanceRequest req)
        {
            return InternalRequestAsync<CreateAgentInstanceResponse>(req, "CreateAgentInstance");
        }

        /// <summary>
        /// 本接口（CreateAgentInstance）用于创建一个智能体实例，通常在用户购买一个智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentInstanceRequest"/></param>
        /// <returns><see cref="CreateAgentInstanceResponse"/></returns>
        public CreateAgentInstanceResponse CreateAgentInstanceSync(CreateAgentInstanceRequest req)
        {
            return InternalRequestAsync<CreateAgentInstanceResponse>(req, "CreateAgentInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建一次会话的SSE接口
        /// </summary>
        /// <param name="req"><see cref="CreateChatCompletionRequest"/></param>
        /// <returns><see cref="CreateChatCompletionResponse"/></returns>
        public Task<CreateChatCompletionResponse> CreateChatCompletion(CreateChatCompletionRequest req)
        {
            return InternalRequestAsync<CreateChatCompletionResponse>(req, "CreateChatCompletion");
        }

        /// <summary>
        /// 用于创建一次会话的SSE接口
        /// </summary>
        /// <param name="req"><see cref="CreateChatCompletionRequest"/></param>
        /// <returns><see cref="CreateChatCompletionResponse"/></returns>
        public CreateChatCompletionResponse CreateChatCompletionSync(CreateChatCompletionRequest req)
        {
            return InternalRequestAsync<CreateChatCompletionResponse>(req, "CreateChatCompletion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询智能体值守任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDutyTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeAgentDutyTaskDetailResponse"/></returns>
        public Task<DescribeAgentDutyTaskDetailResponse> DescribeAgentDutyTaskDetail(DescribeAgentDutyTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAgentDutyTaskDetailResponse>(req, "DescribeAgentDutyTaskDetail");
        }

        /// <summary>
        /// 查询智能体值守任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDutyTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeAgentDutyTaskDetailResponse"/></returns>
        public DescribeAgentDutyTaskDetailResponse DescribeAgentDutyTaskDetailSync(DescribeAgentDutyTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAgentDutyTaskDetailResponse>(req, "DescribeAgentDutyTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询智能体值守任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDutyTasksRequest"/></param>
        /// <returns><see cref="DescribeAgentDutyTasksResponse"/></returns>
        public Task<DescribeAgentDutyTasksResponse> DescribeAgentDutyTasks(DescribeAgentDutyTasksRequest req)
        {
            return InternalRequestAsync<DescribeAgentDutyTasksResponse>(req, "DescribeAgentDutyTasks");
        }

        /// <summary>
        /// 查询智能体值守任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDutyTasksRequest"/></param>
        /// <returns><see cref="DescribeAgentDutyTasksResponse"/></returns>
        public DescribeAgentDutyTasksResponse DescribeAgentDutyTasksSync(DescribeAgentDutyTasksRequest req)
        {
            return InternalRequestAsync<DescribeAgentDutyTasksResponse>(req, "DescribeAgentDutyTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAgentInstance）用于查询智能体实例详情，通常在用户查询所购买的所有智能体实例详情时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstanceRequest"/></param>
        /// <returns><see cref="DescribeAgentInstanceResponse"/></returns>
        public Task<DescribeAgentInstanceResponse> DescribeAgentInstance(DescribeAgentInstanceRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstanceResponse>(req, "DescribeAgentInstance");
        }

        /// <summary>
        /// 本接口（DescribeAgentInstance）用于查询智能体实例详情，通常在用户查询所购买的所有智能体实例详情时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstanceRequest"/></param>
        /// <returns><see cref="DescribeAgentInstanceResponse"/></returns>
        public DescribeAgentInstanceResponse DescribeAgentInstanceSync(DescribeAgentInstanceRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstanceResponse>(req, "DescribeAgentInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAgentInstances）用于查询智能体实例列表，通常在用户查询所购买的所有智能体列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribeAgentInstancesResponse"/></returns>
        public Task<DescribeAgentInstancesResponse> DescribeAgentInstances(DescribeAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstancesResponse>(req, "DescribeAgentInstances");
        }

        /// <summary>
        /// 本接口（DescribeAgentInstances）用于查询智能体实例列表，通常在用户查询所购买的所有智能体列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribeAgentInstancesResponse"/></returns>
        public DescribeAgentInstancesResponse DescribeAgentInstancesSync(DescribeAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstancesResponse>(req, "DescribeAgentInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAgents）用于查询智能体列表，通常在用户查询所购买的所有智能体列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentsRequest"/></param>
        /// <returns><see cref="DescribeAgentsResponse"/></returns>
        public Task<DescribeAgentsResponse> DescribeAgents(DescribeAgentsRequest req)
        {
            return InternalRequestAsync<DescribeAgentsResponse>(req, "DescribeAgents");
        }

        /// <summary>
        /// 本接口（DescribeAgents）用于查询智能体列表，通常在用户查询所购买的所有智能体列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentsRequest"/></param>
        /// <returns><see cref="DescribeAgentsResponse"/></returns>
        public DescribeAgentsResponse DescribeAgentsSync(DescribeAgentsRequest req)
        {
            return InternalRequestAsync<DescribeAgentsResponse>(req, "DescribeAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeChatDetail）用于查询对话详情，通常在用户查询会话的历史记录时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeChatDetailRequest"/></param>
        /// <returns><see cref="DescribeChatDetailResponse"/></returns>
        public Task<DescribeChatDetailResponse> DescribeChatDetail(DescribeChatDetailRequest req)
        {
            return InternalRequestAsync<DescribeChatDetailResponse>(req, "DescribeChatDetail");
        }

        /// <summary>
        /// 本接口（DescribeChatDetail）用于查询对话详情，通常在用户查询会话的历史记录时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeChatDetailRequest"/></param>
        /// <returns><see cref="DescribeChatDetailResponse"/></returns>
        public DescribeChatDetailResponse DescribeChatDetailSync(DescribeChatDetailRequest req)
        {
            return InternalRequestAsync<DescribeChatDetailResponse>(req, "DescribeChatDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeChats）用于查询对话列表，通常在用户查询会话列表时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeChatsRequest"/></param>
        /// <returns><see cref="DescribeChatsResponse"/></returns>
        public Task<DescribeChatsResponse> DescribeChats(DescribeChatsRequest req)
        {
            return InternalRequestAsync<DescribeChatsResponse>(req, "DescribeChats");
        }

        /// <summary>
        /// 本接口（DescribeChats）用于查询对话列表，通常在用户查询会话列表时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeChatsRequest"/></param>
        /// <returns><see cref="DescribeChatsResponse"/></returns>
        public DescribeChatsResponse DescribeChatsSync(DescribeChatsRequest req)
        {
            return InternalRequestAsync<DescribeChatsResponse>(req, "DescribeChats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能体报告地址生成并下载
        /// </summary>
        /// <param name="req"><see cref="DescribeReportUrlRequest"/></param>
        /// <returns><see cref="DescribeReportUrlResponse"/></returns>
        public Task<DescribeReportUrlResponse> DescribeReportUrl(DescribeReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeReportUrlResponse>(req, "DescribeReportUrl");
        }

        /// <summary>
        /// 智能体报告地址生成并下载
        /// </summary>
        /// <param name="req"><see cref="DescribeReportUrlRequest"/></param>
        /// <returns><see cref="DescribeReportUrlResponse"/></returns>
        public DescribeReportUrlResponse DescribeReportUrlSync(DescribeReportUrlRequest req)
        {
            return InternalRequestAsync<DescribeReportUrlResponse>(req, "DescribeReportUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（IsolateAgentInstance）用于隔离智能体实例，通常在用户需要隔离智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="IsolateAgentInstanceRequest"/></param>
        /// <returns><see cref="IsolateAgentInstanceResponse"/></returns>
        public Task<IsolateAgentInstanceResponse> IsolateAgentInstance(IsolateAgentInstanceRequest req)
        {
            return InternalRequestAsync<IsolateAgentInstanceResponse>(req, "IsolateAgentInstance");
        }

        /// <summary>
        /// 本接口（IsolateAgentInstance）用于隔离智能体实例，通常在用户需要隔离智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="IsolateAgentInstanceRequest"/></param>
        /// <returns><see cref="IsolateAgentInstanceResponse"/></returns>
        public IsolateAgentInstanceResponse IsolateAgentInstanceSync(IsolateAgentInstanceRequest req)
        {
            return InternalRequestAsync<IsolateAgentInstanceResponse>(req, "IsolateAgentInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAgentInstanceParameters）用于修改智能体实例的参数列表，通常在用户需要配置智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyAgentInstanceParametersResponse"/></returns>
        public Task<ModifyAgentInstanceParametersResponse> ModifyAgentInstanceParameters(ModifyAgentInstanceParametersRequest req)
        {
            return InternalRequestAsync<ModifyAgentInstanceParametersResponse>(req, "ModifyAgentInstanceParameters");
        }

        /// <summary>
        /// 本接口（ModifyAgentInstanceParameters）用于修改智能体实例的参数列表，通常在用户需要配置智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyAgentInstanceParametersResponse"/></returns>
        public ModifyAgentInstanceParametersResponse ModifyAgentInstanceParametersSync(ModifyAgentInstanceParametersRequest req)
        {
            return InternalRequestAsync<ModifyAgentInstanceParametersResponse>(req, "ModifyAgentInstanceParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyChatTitle）用于修改会话标题，通常在用户修改会话标题时使用。
        /// </summary>
        /// <param name="req"><see cref="ModifyChatTitleRequest"/></param>
        /// <returns><see cref="ModifyChatTitleResponse"/></returns>
        public Task<ModifyChatTitleResponse> ModifyChatTitle(ModifyChatTitleRequest req)
        {
            return InternalRequestAsync<ModifyChatTitleResponse>(req, "ModifyChatTitle");
        }

        /// <summary>
        /// 本接口（ModifyChatTitle）用于修改会话标题，通常在用户修改会话标题时使用。
        /// </summary>
        /// <param name="req"><see cref="ModifyChatTitleRequest"/></param>
        /// <returns><see cref="ModifyChatTitleResponse"/></returns>
        public ModifyChatTitleResponse ModifyChatTitleSync(ModifyChatTitleRequest req)
        {
            return InternalRequestAsync<ModifyChatTitleResponse>(req, "ModifyChatTitle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（PauseAgentWork）用于暂停智能体实例的值守任务，通常在用户需要暂停时使用。
        /// </summary>
        /// <param name="req"><see cref="PauseAgentWorkRequest"/></param>
        /// <returns><see cref="PauseAgentWorkResponse"/></returns>
        public Task<PauseAgentWorkResponse> PauseAgentWork(PauseAgentWorkRequest req)
        {
            return InternalRequestAsync<PauseAgentWorkResponse>(req, "PauseAgentWork");
        }

        /// <summary>
        /// 本接口（PauseAgentWork）用于暂停智能体实例的值守任务，通常在用户需要暂停时使用。
        /// </summary>
        /// <param name="req"><see cref="PauseAgentWorkRequest"/></param>
        /// <returns><see cref="PauseAgentWorkResponse"/></returns>
        public PauseAgentWorkResponse PauseAgentWorkSync(PauseAgentWorkRequest req)
        {
            return InternalRequestAsync<PauseAgentWorkResponse>(req, "PauseAgentWork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RecoverAgentInstance）用于解隔离智能体实例，通常在用户需要解隔离智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="RecoverAgentInstanceRequest"/></param>
        /// <returns><see cref="RecoverAgentInstanceResponse"/></returns>
        public Task<RecoverAgentInstanceResponse> RecoverAgentInstance(RecoverAgentInstanceRequest req)
        {
            return InternalRequestAsync<RecoverAgentInstanceResponse>(req, "RecoverAgentInstance");
        }

        /// <summary>
        /// 本接口（RecoverAgentInstance）用于解隔离智能体实例，通常在用户需要解隔离智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="RecoverAgentInstanceRequest"/></param>
        /// <returns><see cref="RecoverAgentInstanceResponse"/></returns>
        public RecoverAgentInstanceResponse RecoverAgentInstanceSync(RecoverAgentInstanceRequest req)
        {
            return InternalRequestAsync<RecoverAgentInstanceResponse>(req, "RecoverAgentInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RemoveChat）用于删除会话，通常在用户删除会话时使用。
        /// </summary>
        /// <param name="req"><see cref="RemoveChatRequest"/></param>
        /// <returns><see cref="RemoveChatResponse"/></returns>
        public Task<RemoveChatResponse> RemoveChat(RemoveChatRequest req)
        {
            return InternalRequestAsync<RemoveChatResponse>(req, "RemoveChat");
        }

        /// <summary>
        /// 本接口（RemoveChat）用于删除会话，通常在用户删除会话时使用。
        /// </summary>
        /// <param name="req"><see cref="RemoveChatRequest"/></param>
        /// <returns><see cref="RemoveChatResponse"/></returns>
        public RemoveChatResponse RemoveChatSync(RemoveChatRequest req)
        {
            return InternalRequestAsync<RemoveChatResponse>(req, "RemoveChat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于启动一个智能体的任务
        /// </summary>
        /// <param name="req"><see cref="StartAgentTaskRequest"/></param>
        /// <returns><see cref="StartAgentTaskResponse"/></returns>
        public Task<StartAgentTaskResponse> StartAgentTask(StartAgentTaskRequest req)
        {
            return InternalRequestAsync<StartAgentTaskResponse>(req, "StartAgentTask");
        }

        /// <summary>
        /// 该接口用于启动一个智能体的任务
        /// </summary>
        /// <param name="req"><see cref="StartAgentTaskRequest"/></param>
        /// <returns><see cref="StartAgentTaskResponse"/></returns>
        public StartAgentTaskResponse StartAgentTaskSync(StartAgentTaskRequest req)
        {
            return InternalRequestAsync<StartAgentTaskResponse>(req, "StartAgentTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TerminateAgentInstance）用于下线智能体实例，通常在用户需要下线智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="TerminateAgentInstanceRequest"/></param>
        /// <returns><see cref="TerminateAgentInstanceResponse"/></returns>
        public Task<TerminateAgentInstanceResponse> TerminateAgentInstance(TerminateAgentInstanceRequest req)
        {
            return InternalRequestAsync<TerminateAgentInstanceResponse>(req, "TerminateAgentInstance");
        }

        /// <summary>
        /// 本接口（TerminateAgentInstance）用于下线智能体实例，通常在用户需要下线智能体实例时使用。
        /// </summary>
        /// <param name="req"><see cref="TerminateAgentInstanceRequest"/></param>
        /// <returns><see cref="TerminateAgentInstanceResponse"/></returns>
        public TerminateAgentInstanceResponse TerminateAgentInstanceSync(TerminateAgentInstanceRequest req)
        {
            return InternalRequestAsync<TerminateAgentInstanceResponse>(req, "TerminateAgentInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
