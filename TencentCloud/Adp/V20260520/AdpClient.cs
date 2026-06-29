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

namespace TencentCloud.Adp.V20260520
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Adp.V20260520.Models;

   public class AdpClient : AbstractClient{

       private const string endpoint = "adp.tencentcloudapi.com";
       private const string version = "2026-05-20";
       private const string sdkVersion = "SDK_NET_3.0.1453";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AdpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 复制应用
        /// </summary>
        /// <param name="req"><see cref="CopyAppRequest"/></param>
        /// <returns><see cref="CopyAppResponse"/></returns>
        public Task<CopyAppResponse> CopyApp(CopyAppRequest req)
        {
            return InternalRequestAsync<CopyAppResponse>(req, "CopyApp");
        }

        /// <summary>
        /// 复制应用
        /// </summary>
        /// <param name="req"><see cref="CopyAppRequest"/></param>
        /// <returns><see cref="CopyAppResponse"/></returns>
        public CopyAppResponse CopyAppSync(CopyAppRequest req)
        {
            return InternalRequestAsync<CopyAppResponse>(req, "CopyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Agent
        /// </summary>
        /// <param name="req"><see cref="CreateAgentRequest"/></param>
        /// <returns><see cref="CreateAgentResponse"/></returns>
        public Task<CreateAgentResponse> CreateAgent(CreateAgentRequest req)
        {
            return InternalRequestAsync<CreateAgentResponse>(req, "CreateAgent");
        }

        /// <summary>
        /// 创建Agent
        /// </summary>
        /// <param name="req"><see cref="CreateAgentRequest"/></param>
        /// <returns><see cref="CreateAgentResponse"/></returns>
        public CreateAgentResponse CreateAgentSync(CreateAgentRequest req)
        {
            return InternalRequestAsync<CreateAgentResponse>(req, "CreateAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp");
        }

        /// <summary>
        /// 创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建会话
        /// </summary>
        /// <param name="req"><see cref="CreateConversationRequest"/></param>
        /// <returns><see cref="CreateConversationResponse"/></returns>
        public Task<CreateConversationResponse> CreateConversation(CreateConversationRequest req)
        {
            return InternalRequestAsync<CreateConversationResponse>(req, "CreateConversation");
        }

        /// <summary>
        /// 新建会话
        /// </summary>
        /// <param name="req"><see cref="CreateConversationRequest"/></param>
        /// <returns><see cref="CreateConversationResponse"/></returns>
        public CreateConversationResponse CreateConversationSync(CreateConversationRequest req)
        {
            return InternalRequestAsync<CreateConversationResponse>(req, "CreateConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增发布任务
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public Task<CreateReleaseResponse> CreateRelease(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease");
        }

        /// <summary>
        /// 新增发布任务
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public CreateReleaseResponse CreateReleaseSync(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建空间
        /// </summary>
        /// <param name="req"><see cref="CreateSpaceRequest"/></param>
        /// <returns><see cref="CreateSpaceResponse"/></returns>
        public Task<CreateSpaceResponse> CreateSpace(CreateSpaceRequest req)
        {
            return InternalRequestAsync<CreateSpaceResponse>(req, "CreateSpace");
        }

        /// <summary>
        /// 创建空间
        /// </summary>
        /// <param name="req"><see cref="CreateSpaceRequest"/></param>
        /// <returns><see cref="CreateSpaceResponse"/></returns>
        public CreateSpaceResponse CreateSpaceSync(CreateSpaceRequest req)
        {
            return InternalRequestAsync<CreateSpaceResponse>(req, "CreateSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建参数变量
        /// </summary>
        /// <param name="req"><see cref="CreateVariableRequest"/></param>
        /// <returns><see cref="CreateVariableResponse"/></returns>
        public Task<CreateVariableResponse> CreateVariable(CreateVariableRequest req)
        {
            return InternalRequestAsync<CreateVariableResponse>(req, "CreateVariable");
        }

        /// <summary>
        /// 创建参数变量
        /// </summary>
        /// <param name="req"><see cref="CreateVariableRequest"/></param>
        /// <returns><see cref="CreateVariableResponse"/></returns>
        public CreateVariableResponse CreateVariableSync(CreateVariableRequest req)
        {
            return InternalRequestAsync<CreateVariableResponse>(req, "CreateVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 WebSocket Token
        /// </summary>
        /// <param name="req"><see cref="CreateWebSocketTokenRequest"/></param>
        /// <returns><see cref="CreateWebSocketTokenResponse"/></returns>
        public Task<CreateWebSocketTokenResponse> CreateWebSocketToken(CreateWebSocketTokenRequest req)
        {
            return InternalRequestAsync<CreateWebSocketTokenResponse>(req, "CreateWebSocketToken");
        }

        /// <summary>
        /// 创建 WebSocket Token
        /// </summary>
        /// <param name="req"><see cref="CreateWebSocketTokenRequest"/></param>
        /// <returns><see cref="CreateWebSocketTokenResponse"/></returns>
        public CreateWebSocketTokenResponse CreateWebSocketTokenSync(CreateWebSocketTokenRequest req)
        {
            return InternalRequestAsync<CreateWebSocketTokenResponse>(req, "CreateWebSocketToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作空间凭证
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceCredentialRequest"/></param>
        /// <returns><see cref="CreateWorkspaceCredentialResponse"/></returns>
        public Task<CreateWorkspaceCredentialResponse> CreateWorkspaceCredential(CreateWorkspaceCredentialRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceCredentialResponse>(req, "CreateWorkspaceCredential");
        }

        /// <summary>
        /// 创建工作空间凭证
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceCredentialRequest"/></param>
        /// <returns><see cref="CreateWorkspaceCredentialResponse"/></returns>
        public CreateWorkspaceCredentialResponse CreateWorkspaceCredentialSync(CreateWorkspaceCredentialRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceCredentialResponse>(req, "CreateWorkspaceCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public Task<DeleteAppResponse> DeleteApp(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp");
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public DeleteAppResponse DeleteAppSync(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="req"><see cref="DeleteConversationRequest"/></param>
        /// <returns><see cref="DeleteConversationResponse"/></returns>
        public Task<DeleteConversationResponse> DeleteConversation(DeleteConversationRequest req)
        {
            return InternalRequestAsync<DeleteConversationResponse>(req, "DeleteConversation");
        }

        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="req"><see cref="DeleteConversationRequest"/></param>
        /// <returns><see cref="DeleteConversationResponse"/></returns>
        public DeleteConversationResponse DeleteConversationSync(DeleteConversationRequest req)
        {
            return InternalRequestAsync<DeleteConversationResponse>(req, "DeleteConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除空间
        /// </summary>
        /// <param name="req"><see cref="DeleteSpaceRequest"/></param>
        /// <returns><see cref="DeleteSpaceResponse"/></returns>
        public Task<DeleteSpaceResponse> DeleteSpace(DeleteSpaceRequest req)
        {
            return InternalRequestAsync<DeleteSpaceResponse>(req, "DeleteSpace");
        }

        /// <summary>
        /// 删除空间
        /// </summary>
        /// <param name="req"><see cref="DeleteSpaceRequest"/></param>
        /// <returns><see cref="DeleteSpaceResponse"/></returns>
        public DeleteSpaceResponse DeleteSpaceSync(DeleteSpaceRequest req)
        {
            return InternalRequestAsync<DeleteSpaceResponse>(req, "DeleteSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除参数变量
        /// </summary>
        /// <param name="req"><see cref="DeleteVariableRequest"/></param>
        /// <returns><see cref="DeleteVariableResponse"/></returns>
        public Task<DeleteVariableResponse> DeleteVariable(DeleteVariableRequest req)
        {
            return InternalRequestAsync<DeleteVariableResponse>(req, "DeleteVariable");
        }

        /// <summary>
        /// 删除参数变量
        /// </summary>
        /// <param name="req"><see cref="DeleteVariableRequest"/></param>
        /// <returns><see cref="DeleteVariableResponse"/></returns>
        public DeleteVariableResponse DeleteVariableSync(DeleteVariableRequest req)
        {
            return InternalRequestAsync<DeleteVariableResponse>(req, "DeleteVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Agent 详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDetailRequest"/></param>
        /// <returns><see cref="DescribeAgentDetailResponse"/></returns>
        public Task<DescribeAgentDetailResponse> DescribeAgentDetail(DescribeAgentDetailRequest req)
        {
            return InternalRequestAsync<DescribeAgentDetailResponse>(req, "DescribeAgentDetail");
        }

        /// <summary>
        /// 查询 Agent 详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDetailRequest"/></param>
        /// <returns><see cref="DescribeAgentDetailResponse"/></returns>
        public DescribeAgentDetailResponse DescribeAgentDetailSync(DescribeAgentDetailRequest req)
        {
            return InternalRequestAsync<DescribeAgentDetailResponse>(req, "DescribeAgentDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用下 Agent 的发布预览列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentReleasePreviewListRequest"/></param>
        /// <returns><see cref="DescribeAgentReleasePreviewListResponse"/></returns>
        public Task<DescribeAgentReleasePreviewListResponse> DescribeAgentReleasePreviewList(DescribeAgentReleasePreviewListRequest req)
        {
            return InternalRequestAsync<DescribeAgentReleasePreviewListResponse>(req, "DescribeAgentReleasePreviewList");
        }

        /// <summary>
        /// 获取应用下 Agent 的发布预览列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentReleasePreviewListRequest"/></param>
        /// <returns><see cref="DescribeAgentReleasePreviewListResponse"/></returns>
        public DescribeAgentReleasePreviewListResponse DescribeAgentReleasePreviewListSync(DescribeAgentReleasePreviewListRequest req)
        {
            return InternalRequestAsync<DescribeAgentReleasePreviewListResponse>(req, "DescribeAgentReleasePreviewList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public Task<DescribeAppResponse> DescribeApp(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp");
        }

        /// <summary>
        /// 获取应用信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public DescribeAppResponse DescribeAppSync(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用摘要列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppSummaryListResponse"/></returns>
        public Task<DescribeAppSummaryListResponse> DescribeAppSummaryList(DescribeAppSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppSummaryListResponse>(req, "DescribeAppSummaryList");
        }

        /// <summary>
        /// 获取应用摘要列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppSummaryListResponse"/></returns>
        public DescribeAppSummaryListResponse DescribeAppSummaryListSync(DescribeAppSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppSummaryListResponse>(req, "DescribeAppSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看会话信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationRequest"/></param>
        /// <returns><see cref="DescribeConversationResponse"/></returns>
        public Task<DescribeConversationResponse> DescribeConversation(DescribeConversationRequest req)
        {
            return InternalRequestAsync<DescribeConversationResponse>(req, "DescribeConversation");
        }

        /// <summary>
        /// 查看会话信息
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationRequest"/></param>
        /// <returns><see cref="DescribeConversationResponse"/></returns>
        public DescribeConversationResponse DescribeConversationSync(DescribeConversationRequest req)
        {
            return InternalRequestAsync<DescribeConversationResponse>(req, "DescribeConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationListRequest"/></param>
        /// <returns><see cref="DescribeConversationListResponse"/></returns>
        public Task<DescribeConversationListResponse> DescribeConversationList(DescribeConversationListRequest req)
        {
            return InternalRequestAsync<DescribeConversationListResponse>(req, "DescribeConversationList");
        }

        /// <summary>
        /// 获取会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationListRequest"/></param>
        /// <returns><see cref="DescribeConversationListResponse"/></returns>
        public DescribeConversationListResponse DescribeConversationListSync(DescribeConversationListRequest req)
        {
            return InternalRequestAsync<DescribeConversationListResponse>(req, "DescribeConversationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取会话历史消息
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationMessageListRequest"/></param>
        /// <returns><see cref="DescribeConversationMessageListResponse"/></returns>
        public Task<DescribeConversationMessageListResponse> DescribeConversationMessageList(DescribeConversationMessageListRequest req)
        {
            return InternalRequestAsync<DescribeConversationMessageListResponse>(req, "DescribeConversationMessageList");
        }

        /// <summary>
        /// 获取会话历史消息
        /// </summary>
        /// <param name="req"><see cref="DescribeConversationMessageListRequest"/></param>
        /// <returns><see cref="DescribeConversationMessageListResponse"/></returns>
        public DescribeConversationMessageListResponse DescribeConversationMessageListSync(DescribeConversationMessageListRequest req)
        {
            return InternalRequestAsync<DescribeConversationMessageListResponse>(req, "DescribeConversationMessageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取最新发布信息(包含发布时间、状态、渠道)
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestReleaseRequest"/></param>
        /// <returns><see cref="DescribeLatestReleaseResponse"/></returns>
        public Task<DescribeLatestReleaseResponse> DescribeLatestRelease(DescribeLatestReleaseRequest req)
        {
            return InternalRequestAsync<DescribeLatestReleaseResponse>(req, "DescribeLatestRelease");
        }

        /// <summary>
        /// 拉取最新发布信息(包含发布时间、状态、渠道)
        /// </summary>
        /// <param name="req"><see cref="DescribeLatestReleaseRequest"/></param>
        /// <returns><see cref="DescribeLatestReleaseResponse"/></returns>
        public DescribeLatestReleaseResponse DescribeLatestReleaseSync(DescribeLatestReleaseRequest req)
        {
            return InternalRequestAsync<DescribeLatestReleaseResponse>(req, "DescribeLatestRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public Task<DescribeModelListResponse> DescribeModelList(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList");
        }

        /// <summary>
        /// 查询模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public DescribeModelListResponse DescribeModelListSync(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取插件详情
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public Task<DescribePluginResponse> DescribePlugin(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin");
        }

        /// <summary>
        /// 获取插件详情
        /// </summary>
        /// <param name="req"><see cref="DescribePluginRequest"/></param>
        /// <returns><see cref="DescribePluginResponse"/></returns>
        public DescribePluginResponse DescribePluginSync(DescribePluginRequest req)
        {
            return InternalRequestAsync<DescribePluginResponse>(req, "DescribePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePluginSummaryListRequest"/></param>
        /// <returns><see cref="DescribePluginSummaryListResponse"/></returns>
        public Task<DescribePluginSummaryListResponse> DescribePluginSummaryList(DescribePluginSummaryListRequest req)
        {
            return InternalRequestAsync<DescribePluginSummaryListResponse>(req, "DescribePluginSummaryList");
        }

        /// <summary>
        /// 获取插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribePluginSummaryListRequest"/></param>
        /// <returns><see cref="DescribePluginSummaryListResponse"/></returns>
        public DescribePluginSummaryListResponse DescribePluginSummaryListSync(DescribePluginSummaryListRequest req)
        {
            return InternalRequestAsync<DescribePluginSummaryListResponse>(req, "DescribePluginSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseListRequest"/></param>
        /// <returns><see cref="DescribeReleaseListResponse"/></returns>
        public Task<DescribeReleaseListResponse> DescribeReleaseList(DescribeReleaseListRequest req)
        {
            return InternalRequestAsync<DescribeReleaseListResponse>(req, "DescribeReleaseList");
        }

        /// <summary>
        /// 发布记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseListRequest"/></param>
        /// <returns><see cref="DescribeReleaseListResponse"/></returns>
        public DescribeReleaseListResponse DescribeReleaseListSync(DescribeReleaseListRequest req)
        {
            return InternalRequestAsync<DescribeReleaseListResponse>(req, "DescribeReleaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询发布任务
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseSummaryRequest"/></param>
        /// <returns><see cref="DescribeReleaseSummaryResponse"/></returns>
        public Task<DescribeReleaseSummaryResponse> DescribeReleaseSummary(DescribeReleaseSummaryRequest req)
        {
            return InternalRequestAsync<DescribeReleaseSummaryResponse>(req, "DescribeReleaseSummary");
        }

        /// <summary>
        /// 查询发布任务
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseSummaryRequest"/></param>
        /// <returns><see cref="DescribeReleaseSummaryResponse"/></returns>
        public DescribeReleaseSummaryResponse DescribeReleaseSummarySync(DescribeReleaseSummaryRequest req)
        {
            return InternalRequestAsync<DescribeReleaseSummaryResponse>(req, "DescribeReleaseSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Skill 分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillCategoryListRequest"/></param>
        /// <returns><see cref="DescribeSkillCategoryListResponse"/></returns>
        public Task<DescribeSkillCategoryListResponse> DescribeSkillCategoryList(DescribeSkillCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillCategoryListResponse>(req, "DescribeSkillCategoryList");
        }

        /// <summary>
        /// 查询 Skill 分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillCategoryListRequest"/></param>
        /// <returns><see cref="DescribeSkillCategoryListResponse"/></returns>
        public DescribeSkillCategoryListResponse DescribeSkillCategoryListSync(DescribeSkillCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillCategoryListResponse>(req, "DescribeSkillCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Skill 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillSummaryListRequest"/></param>
        /// <returns><see cref="DescribeSkillSummaryListResponse"/></returns>
        public Task<DescribeSkillSummaryListResponse> DescribeSkillSummaryList(DescribeSkillSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillSummaryListResponse>(req, "DescribeSkillSummaryList");
        }

        /// <summary>
        /// 查询 Skill 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillSummaryListRequest"/></param>
        /// <returns><see cref="DescribeSkillSummaryListResponse"/></returns>
        public DescribeSkillSummaryListResponse DescribeSkillSummaryListSync(DescribeSkillSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeSkillSummaryListResponse>(req, "DescribeSkillSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceListRequest"/></param>
        /// <returns><see cref="DescribeSpaceListResponse"/></returns>
        public Task<DescribeSpaceListResponse> DescribeSpaceList(DescribeSpaceListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceListResponse>(req, "DescribeSpaceList");
        }

        /// <summary>
        /// 获取空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceListRequest"/></param>
        /// <returns><see cref="DescribeSpaceListResponse"/></returns>
        public DescribeSpaceListResponse DescribeSpaceListSync(DescribeSpaceListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceListResponse>(req, "DescribeSpaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取系统变量
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVariableListRequest"/></param>
        /// <returns><see cref="DescribeSystemVariableListResponse"/></returns>
        public Task<DescribeSystemVariableListResponse> DescribeSystemVariableList(DescribeSystemVariableListRequest req)
        {
            return InternalRequestAsync<DescribeSystemVariableListResponse>(req, "DescribeSystemVariableList");
        }

        /// <summary>
        /// 获取系统变量
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVariableListRequest"/></param>
        /// <returns><see cref="DescribeSystemVariableListResponse"/></returns>
        public DescribeSystemVariableListResponse DescribeSystemVariableListSync(DescribeSystemVariableListRequest req)
        {
            return InternalRequestAsync<DescribeSystemVariableListResponse>(req, "DescribeSystemVariableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取参数变量
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableRequest"/></param>
        /// <returns><see cref="DescribeVariableResponse"/></returns>
        public Task<DescribeVariableResponse> DescribeVariable(DescribeVariableRequest req)
        {
            return InternalRequestAsync<DescribeVariableResponse>(req, "DescribeVariable");
        }

        /// <summary>
        /// 获取参数变量
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableRequest"/></param>
        /// <returns><see cref="DescribeVariableResponse"/></returns>
        public DescribeVariableResponse DescribeVariableSync(DescribeVariableRequest req)
        {
            return InternalRequestAsync<DescribeVariableResponse>(req, "DescribeVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取参数变量列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableListRequest"/></param>
        /// <returns><see cref="DescribeVariableListResponse"/></returns>
        public Task<DescribeVariableListResponse> DescribeVariableList(DescribeVariableListRequest req)
        {
            return InternalRequestAsync<DescribeVariableListResponse>(req, "DescribeVariableList");
        }

        /// <summary>
        /// 获取参数变量列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVariableListRequest"/></param>
        /// <returns><see cref="DescribeVariableListResponse"/></returns>
        public DescribeVariableListResponse DescribeVariableListSync(DescribeVariableListRequest req)
        {
            return InternalRequestAsync<DescribeVariableListResponse>(req, "DescribeVariableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Agent配置信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRequest"/></param>
        /// <returns><see cref="ModifyAgentResponse"/></returns>
        public Task<ModifyAgentResponse> ModifyAgent(ModifyAgentRequest req)
        {
            return InternalRequestAsync<ModifyAgentResponse>(req, "ModifyAgent");
        }

        /// <summary>
        /// 修改Agent配置信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRequest"/></param>
        /// <returns><see cref="ModifyAgentResponse"/></returns>
        public ModifyAgentResponse ModifyAgentSync(ModifyAgentRequest req)
        {
            return InternalRequestAsync<ModifyAgentResponse>(req, "ModifyAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp");
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改会话信息
        /// </summary>
        /// <param name="req"><see cref="ModifyConversationRequest"/></param>
        /// <returns><see cref="ModifyConversationResponse"/></returns>
        public Task<ModifyConversationResponse> ModifyConversation(ModifyConversationRequest req)
        {
            return InternalRequestAsync<ModifyConversationResponse>(req, "ModifyConversation");
        }

        /// <summary>
        /// 修改会话信息
        /// </summary>
        /// <param name="req"><see cref="ModifyConversationRequest"/></param>
        /// <returns><see cref="ModifyConversationResponse"/></returns>
        public ModifyConversationResponse ModifyConversationSync(ModifyConversationRequest req)
        {
            return InternalRequestAsync<ModifyConversationResponse>(req, "ModifyConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑空间
        /// </summary>
        /// <param name="req"><see cref="ModifySpaceRequest"/></param>
        /// <returns><see cref="ModifySpaceResponse"/></returns>
        public Task<ModifySpaceResponse> ModifySpace(ModifySpaceRequest req)
        {
            return InternalRequestAsync<ModifySpaceResponse>(req, "ModifySpace");
        }

        /// <summary>
        /// 编辑空间
        /// </summary>
        /// <param name="req"><see cref="ModifySpaceRequest"/></param>
        /// <returns><see cref="ModifySpaceResponse"/></returns>
        public ModifySpaceResponse ModifySpaceSync(ModifySpaceRequest req)
        {
            return InternalRequestAsync<ModifySpaceResponse>(req, "ModifySpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新参数变量
        /// </summary>
        /// <param name="req"><see cref="ModifyVariableRequest"/></param>
        /// <returns><see cref="ModifyVariableResponse"/></returns>
        public Task<ModifyVariableResponse> ModifyVariable(ModifyVariableRequest req)
        {
            return InternalRequestAsync<ModifyVariableResponse>(req, "ModifyVariable");
        }

        /// <summary>
        /// 更新参数变量
        /// </summary>
        /// <param name="req"><see cref="ModifyVariableRequest"/></param>
        /// <returns><see cref="ModifyVariableResponse"/></returns>
        public ModifyVariableResponse ModifyVariableSync(ModifyVariableRequest req)
        {
            return InternalRequestAsync<ModifyVariableResponse>(req, "ModifyVariable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置会话
        /// </summary>
        /// <param name="req"><see cref="ResetConversationRequest"/></param>
        /// <returns><see cref="ResetConversationResponse"/></returns>
        public Task<ResetConversationResponse> ResetConversation(ResetConversationRequest req)
        {
            return InternalRequestAsync<ResetConversationResponse>(req, "ResetConversation");
        }

        /// <summary>
        /// 重置会话
        /// </summary>
        /// <param name="req"><see cref="ResetConversationRequest"/></param>
        /// <returns><see cref="ResetConversationResponse"/></returns>
        public ResetConversationResponse ResetConversationSync(ResetConversationRequest req)
        {
            return InternalRequestAsync<ResetConversationResponse>(req, "ResetConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重试发布(发布暂停之后再次重新发布)
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public Task<RetryReleaseResponse> RetryRelease(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease");
        }

        /// <summary>
        /// 重试发布(发布暂停之后再次重新发布)
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public RetryReleaseResponse RetryReleaseSync(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回滚发布
        /// </summary>
        /// <param name="req"><see cref="RollbackReleaseRequest"/></param>
        /// <returns><see cref="RollbackReleaseResponse"/></returns>
        public Task<RollbackReleaseResponse> RollbackRelease(RollbackReleaseRequest req)
        {
            return InternalRequestAsync<RollbackReleaseResponse>(req, "RollbackRelease");
        }

        /// <summary>
        /// 回滚发布
        /// </summary>
        /// <param name="req"><see cref="RollbackReleaseRequest"/></param>
        /// <returns><see cref="RollbackReleaseResponse"/></returns>
        public RollbackReleaseResponse RollbackReleaseSync(RollbackReleaseRequest req)
        {
            return InternalRequestAsync<RollbackReleaseResponse>(req, "RollbackRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
