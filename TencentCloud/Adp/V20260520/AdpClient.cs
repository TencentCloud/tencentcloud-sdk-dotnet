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
       private const string sdkVersion = "SDK_NET_3.0.1493";

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
        /// 创建Agent
        /// </summary>
        /// <param name="req"><see cref="CopyAgentFromAppRequest"/></param>
        /// <returns><see cref="CopyAgentFromAppResponse"/></returns>
        public Task<CopyAgentFromAppResponse> CopyAgentFromApp(CopyAgentFromAppRequest req)
        {
            return InternalRequestAsync<CopyAgentFromAppResponse>(req, "CopyAgentFromApp");
        }

        /// <summary>
        /// 创建Agent
        /// </summary>
        /// <param name="req"><see cref="CopyAgentFromAppRequest"/></param>
        /// <returns><see cref="CopyAgentFromAppResponse"/></returns>
        public CopyAgentFromAppResponse CopyAgentFromAppSync(CopyAgentFromAppRequest req)
        {
            return InternalRequestAsync<CopyAgentFromAppResponse>(req, "CopyAgentFromApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// CreateAppTrigger
        /// </summary>
        /// <param name="req"><see cref="CreateAppTriggerRequest"/></param>
        /// <returns><see cref="CreateAppTriggerResponse"/></returns>
        public Task<CreateAppTriggerResponse> CreateAppTrigger(CreateAppTriggerRequest req)
        {
            return InternalRequestAsync<CreateAppTriggerResponse>(req, "CreateAppTrigger");
        }

        /// <summary>
        /// CreateAppTrigger
        /// </summary>
        /// <param name="req"><see cref="CreateAppTriggerRequest"/></param>
        /// <returns><see cref="CreateAppTriggerResponse"/></returns>
        public CreateAppTriggerResponse CreateAppTriggerSync(CreateAppTriggerRequest req)
        {
            return InternalRequestAsync<CreateAppTriggerResponse>(req, "CreateAppTrigger")
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
        /// 创建一条消息记录分类，支持指定分类名称与父分类（ParentId 为 0 时表示一级分类）
        /// </summary>
        /// <param name="req"><see cref="CreateMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="CreateMsgRecordCategoryResponse"/></returns>
        public Task<CreateMsgRecordCategoryResponse> CreateMsgRecordCategory(CreateMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<CreateMsgRecordCategoryResponse>(req, "CreateMsgRecordCategory");
        }

        /// <summary>
        /// 创建一条消息记录分类，支持指定分类名称与父分类（ParentId 为 0 时表示一级分类）
        /// </summary>
        /// <param name="req"><see cref="CreateMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="CreateMsgRecordCategoryResponse"/></returns>
        public CreateMsgRecordCategoryResponse CreateMsgRecordCategorySync(CreateMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<CreateMsgRecordCategoryResponse>(req, "CreateMsgRecordCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取插件详情
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public Task<CreatePluginResponse> CreatePlugin(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin");
        }

        /// <summary>
        /// 获取插件详情
        /// </summary>
        /// <param name="req"><see cref="CreatePluginRequest"/></param>
        /// <returns><see cref="CreatePluginResponse"/></returns>
        public CreatePluginResponse CreatePluginSync(CreatePluginRequest req)
        {
            return InternalRequestAsync<CreatePluginResponse>(req, "CreatePlugin")
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
        /// 创建skill
        /// </summary>
        /// <param name="req"><see cref="CreateSkillRequest"/></param>
        /// <returns><see cref="CreateSkillResponse"/></returns>
        public Task<CreateSkillResponse> CreateSkill(CreateSkillRequest req)
        {
            return InternalRequestAsync<CreateSkillResponse>(req, "CreateSkill");
        }

        /// <summary>
        /// 创建skill
        /// </summary>
        /// <param name="req"><see cref="CreateSkillRequest"/></param>
        /// <returns><see cref="CreateSkillResponse"/></returns>
        public CreateSkillResponse CreateSkillSync(CreateSkillRequest req)
        {
            return InternalRequestAsync<CreateSkillResponse>(req, "CreateSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交自定义Skill至企业级共享审批（两段式：提交→审批→回调创建共享任务）
        /// </summary>
        /// <param name="req"><see cref="CreateSkillShareRequest"/></param>
        /// <returns><see cref="CreateSkillShareResponse"/></returns>
        public Task<CreateSkillShareResponse> CreateSkillShare(CreateSkillShareRequest req)
        {
            return InternalRequestAsync<CreateSkillShareResponse>(req, "CreateSkillShare");
        }

        /// <summary>
        /// 提交自定义Skill至企业级共享审批（两段式：提交→审批→回调创建共享任务）
        /// </summary>
        /// <param name="req"><see cref="CreateSkillShareRequest"/></param>
        /// <returns><see cref="CreateSkillShareResponse"/></returns>
        public CreateSkillShareResponse CreateSkillShareSync(CreateSkillShareRequest req)
        {
            return InternalRequestAsync<CreateSkillShareResponse>(req, "CreateSkillShare")
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
        /// 删除Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentRequest"/></param>
        /// <returns><see cref="DeleteAgentResponse"/></returns>
        public Task<DeleteAgentResponse> DeleteAgent(DeleteAgentRequest req)
        {
            return InternalRequestAsync<DeleteAgentResponse>(req, "DeleteAgent");
        }

        /// <summary>
        /// 删除Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentRequest"/></param>
        /// <returns><see cref="DeleteAgentResponse"/></returns>
        public DeleteAgentResponse DeleteAgentSync(DeleteAgentRequest req)
        {
            return InternalRequestAsync<DeleteAgentResponse>(req, "DeleteAgent")
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
        /// DeleteAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DeleteAppTriggerRequest"/></param>
        /// <returns><see cref="DeleteAppTriggerResponse"/></returns>
        public Task<DeleteAppTriggerResponse> DeleteAppTrigger(DeleteAppTriggerRequest req)
        {
            return InternalRequestAsync<DeleteAppTriggerResponse>(req, "DeleteAppTrigger");
        }

        /// <summary>
        /// DeleteAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DeleteAppTriggerRequest"/></param>
        /// <returns><see cref="DeleteAppTriggerResponse"/></returns>
        public DeleteAppTriggerResponse DeleteAppTriggerSync(DeleteAppTriggerRequest req)
        {
            return InternalRequestAsync<DeleteAppTriggerResponse>(req, "DeleteAppTrigger")
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
        /// 删除指定的消息记录分类
        /// </summary>
        /// <param name="req"><see cref="DeleteMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="DeleteMsgRecordCategoryResponse"/></returns>
        public Task<DeleteMsgRecordCategoryResponse> DeleteMsgRecordCategory(DeleteMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<DeleteMsgRecordCategoryResponse>(req, "DeleteMsgRecordCategory");
        }

        /// <summary>
        /// 删除指定的消息记录分类
        /// </summary>
        /// <param name="req"><see cref="DeleteMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="DeleteMsgRecordCategoryResponse"/></returns>
        public DeleteMsgRecordCategoryResponse DeleteMsgRecordCategorySync(DeleteMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<DeleteMsgRecordCategoryResponse>(req, "DeleteMsgRecordCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改插件
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public Task<DeletePluginResponse> DeletePlugin(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin");
        }

        /// <summary>
        /// 修改插件
        /// </summary>
        /// <param name="req"><see cref="DeletePluginRequest"/></param>
        /// <returns><see cref="DeletePluginResponse"/></returns>
        public DeletePluginResponse DeletePluginSync(DeletePluginRequest req)
        {
            return InternalRequestAsync<DeletePluginResponse>(req, "DeletePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义 Skill  鉴权：创建者 ∨ (编辑权限 ∧ 删除权限） 拒绝场景：非 Custom 类型 / 已共享 / 安全检测中 / 上架审批中 / 下架审批中
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillRequest"/></param>
        /// <returns><see cref="DeleteSkillResponse"/></returns>
        public Task<DeleteSkillResponse> DeleteSkill(DeleteSkillRequest req)
        {
            return InternalRequestAsync<DeleteSkillResponse>(req, "DeleteSkill");
        }

        /// <summary>
        /// 删除自定义 Skill  鉴权：创建者 ∨ (编辑权限 ∧ 删除权限） 拒绝场景：非 Custom 类型 / 已共享 / 安全检测中 / 上架审批中 / 下架审批中
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillRequest"/></param>
        /// <returns><see cref="DeleteSkillResponse"/></returns>
        public DeleteSkillResponse DeleteSkillSync(DeleteSkillRequest req)
        {
            return InternalRequestAsync<DeleteSkillResponse>(req, "DeleteSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交共享 Skill 下架审批（v2，两段式：提交→审批→回调下架共享 Skill） 鉴权：删除权 拒绝场景：未共享 / 上架审批中 / 下架审批中
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillShareRequest"/></param>
        /// <returns><see cref="DeleteSkillShareResponse"/></returns>
        public Task<DeleteSkillShareResponse> DeleteSkillShare(DeleteSkillShareRequest req)
        {
            return InternalRequestAsync<DeleteSkillShareResponse>(req, "DeleteSkillShare");
        }

        /// <summary>
        /// 提交共享 Skill 下架审批（v2，两段式：提交→审批→回调下架共享 Skill） 鉴权：删除权 拒绝场景：未共享 / 上架审批中 / 下架审批中
        /// </summary>
        /// <param name="req"><see cref="DeleteSkillShareRequest"/></param>
        /// <returns><see cref="DeleteSkillShareResponse"/></returns>
        public DeleteSkillShareResponse DeleteSkillShareSync(DeleteSkillShareRequest req)
        {
            return InternalRequestAsync<DeleteSkillShareResponse>(req, "DeleteSkillShare")
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
        /// 查看企业下的员工列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountListRequest"/></param>
        /// <returns><see cref="DescribeAccountListResponse"/></returns>
        public Task<DescribeAccountListResponse> DescribeAccountList(DescribeAccountListRequest req)
        {
            return InternalRequestAsync<DescribeAccountListResponse>(req, "DescribeAccountList");
        }

        /// <summary>
        /// 查看企业下的员工列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountListRequest"/></param>
        /// <returns><see cref="DescribeAccountListResponse"/></returns>
        public DescribeAccountListResponse DescribeAccountListSync(DescribeAccountListRequest req)
        {
            return InternalRequestAsync<DescribeAccountListResponse>(req, "DescribeAccountList")
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
        /// 查询 Agent 摘要信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAgentSummaryListResponse"/></returns>
        public Task<DescribeAgentSummaryListResponse> DescribeAgentSummaryList(DescribeAgentSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAgentSummaryListResponse>(req, "DescribeAgentSummaryList");
        }

        /// <summary>
        /// 查询 Agent 摘要信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAgentSummaryListResponse"/></returns>
        public DescribeAgentSummaryListResponse DescribeAgentSummaryListSync(DescribeAgentSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAgentSummaryListResponse>(req, "DescribeAgentSummaryList")
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
        /// DescribeAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerResponse"/></returns>
        public Task<DescribeAppTriggerResponse> DescribeAppTrigger(DescribeAppTriggerRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerResponse>(req, "DescribeAppTrigger");
        }

        /// <summary>
        /// DescribeAppTrigger
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerResponse"/></returns>
        public DescribeAppTriggerResponse DescribeAppTriggerSync(DescribeAppTriggerRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerResponse>(req, "DescribeAppTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAppTriggerInstance
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerInstanceRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerInstanceResponse"/></returns>
        public Task<DescribeAppTriggerInstanceResponse> DescribeAppTriggerInstance(DescribeAppTriggerInstanceRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerInstanceResponse>(req, "DescribeAppTriggerInstance");
        }

        /// <summary>
        /// DescribeAppTriggerInstance
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerInstanceRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerInstanceResponse"/></returns>
        public DescribeAppTriggerInstanceResponse DescribeAppTriggerInstanceSync(DescribeAppTriggerInstanceRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerInstanceResponse>(req, "DescribeAppTriggerInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAppTriggerRunLogList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRunLogListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerRunLogListResponse"/></returns>
        public Task<DescribeAppTriggerRunLogListResponse> DescribeAppTriggerRunLogList(DescribeAppTriggerRunLogListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerRunLogListResponse>(req, "DescribeAppTriggerRunLogList");
        }

        /// <summary>
        /// DescribeAppTriggerRunLogList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerRunLogListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerRunLogListResponse"/></returns>
        public DescribeAppTriggerRunLogListResponse DescribeAppTriggerRunLogListSync(DescribeAppTriggerRunLogListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerRunLogListResponse>(req, "DescribeAppTriggerRunLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAppTriggerSummaryList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerSummaryListResponse"/></returns>
        public Task<DescribeAppTriggerSummaryListResponse> DescribeAppTriggerSummaryList(DescribeAppTriggerSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerSummaryListResponse>(req, "DescribeAppTriggerSummaryList");
        }

        /// <summary>
        /// DescribeAppTriggerSummaryList
        /// </summary>
        /// <param name="req"><see cref="DescribeAppTriggerSummaryListRequest"/></param>
        /// <returns><see cref="DescribeAppTriggerSummaryListResponse"/></returns>
        public DescribeAppTriggerSummaryListResponse DescribeAppTriggerSummaryListSync(DescribeAppTriggerSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeAppTriggerSummaryListResponse>(req, "DescribeAppTriggerSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看操作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogListRequest"/></param>
        /// <returns><see cref="DescribeAuditLogListResponse"/></returns>
        public Task<DescribeAuditLogListResponse> DescribeAuditLogList(DescribeAuditLogListRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogListResponse>(req, "DescribeAuditLogList");
        }

        /// <summary>
        /// 查看操作日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogListRequest"/></param>
        /// <returns><see cref="DescribeAuditLogListResponse"/></returns>
        public DescribeAuditLogListResponse DescribeAuditLogListSync(DescribeAuditLogListRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogListResponse>(req, "DescribeAuditLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取审计日志元信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogMetaRequest"/></param>
        /// <returns><see cref="DescribeAuditLogMetaResponse"/></returns>
        public Task<DescribeAuditLogMetaResponse> DescribeAuditLogMeta(DescribeAuditLogMetaRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogMetaResponse>(req, "DescribeAuditLogMeta");
        }

        /// <summary>
        /// 获取审计日志元信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogMetaRequest"/></param>
        /// <returns><see cref="DescribeAuditLogMetaResponse"/></returns>
        public DescribeAuditLogMetaResponse DescribeAuditLogMetaSync(DescribeAuditLogMetaRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogMetaResponse>(req, "DescribeAuditLogMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询并发超限明细，包含QPM/TPM超限与专属并发超限记录，返回超限发生时间、空间、应用、模型及请求内容
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyLimitDetailListRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyLimitDetailListResponse"/></returns>
        public Task<DescribeConcurrencyLimitDetailListResponse> DescribeConcurrencyLimitDetailList(DescribeConcurrencyLimitDetailListRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyLimitDetailListResponse>(req, "DescribeConcurrencyLimitDetailList");
        }

        /// <summary>
        /// 查询并发超限明细，包含QPM/TPM超限与专属并发超限记录，返回超限发生时间、空间、应用、模型及请求内容
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyLimitDetailListRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyLimitDetailListResponse"/></returns>
        public DescribeConcurrencyLimitDetailListResponse DescribeConcurrencyLimitDetailListSync(DescribeConcurrencyLimitDetailListRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyLimitDetailListResponse>(req, "DescribeConcurrencyLimitDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源消耗明细，包含计费相关字段（消耗类型、消耗目标、消耗场景、套餐包及PU消耗等）
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumptionDetailListRequest"/></param>
        /// <returns><see cref="DescribeConsumptionDetailListResponse"/></returns>
        public Task<DescribeConsumptionDetailListResponse> DescribeConsumptionDetailList(DescribeConsumptionDetailListRequest req)
        {
            return InternalRequestAsync<DescribeConsumptionDetailListResponse>(req, "DescribeConsumptionDetailList");
        }

        /// <summary>
        /// 查询资源消耗明细，包含计费相关字段（消耗类型、消耗目标、消耗场景、套餐包及PU消耗等）
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumptionDetailListRequest"/></param>
        /// <returns><see cref="DescribeConsumptionDetailListResponse"/></returns>
        public DescribeConsumptionDetailListResponse DescribeConsumptionDetailListSync(DescribeConsumptionDetailListRequest req)
        {
            return InternalRequestAsync<DescribeConsumptionDetailListResponse>(req, "DescribeConsumptionDetailList")
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
        /// 查询看板总览KPI卡片数据，通过resource_type区分资源看板与业务看板域，返回各域KPI指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricOverviewListRequest"/></param>
        /// <returns><see cref="DescribeMetricOverviewListResponse"/></returns>
        public Task<DescribeMetricOverviewListResponse> DescribeMetricOverviewList(DescribeMetricOverviewListRequest req)
        {
            return InternalRequestAsync<DescribeMetricOverviewListResponse>(req, "DescribeMetricOverviewList");
        }

        /// <summary>
        /// 查询看板总览KPI卡片数据，通过resource_type区分资源看板与业务看板域，返回各域KPI指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricOverviewListRequest"/></param>
        /// <returns><see cref="DescribeMetricOverviewListResponse"/></returns>
        public DescribeMetricOverviewListResponse DescribeMetricOverviewListSync(DescribeMetricOverviewListRequest req)
        {
            return InternalRequestAsync<DescribeMetricOverviewListResponse>(req, "DescribeMetricOverviewList")
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
        /// 查询应用的消息记录分类树，返回分类及子分类、各分类下记录数量与操作权限
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRecordCategoryListRequest"/></param>
        /// <returns><see cref="DescribeMsgRecordCategoryListResponse"/></returns>
        public Task<DescribeMsgRecordCategoryListResponse> DescribeMsgRecordCategoryList(DescribeMsgRecordCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeMsgRecordCategoryListResponse>(req, "DescribeMsgRecordCategoryList");
        }

        /// <summary>
        /// 查询应用的消息记录分类树，返回分类及子分类、各分类下记录数量与操作权限
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRecordCategoryListRequest"/></param>
        /// <returns><see cref="DescribeMsgRecordCategoryListResponse"/></returns>
        public DescribeMsgRecordCategoryListResponse DescribeMsgRecordCategoryListSync(DescribeMsgRecordCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeMsgRecordCategoryListResponse>(req, "DescribeMsgRecordCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用的对话消息记录列表，支持按渠道类型、反馈类型、意图、调用结果等条件过滤，并支持游标分页与按创建时间排序
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRecordListRequest"/></param>
        /// <returns><see cref="DescribeMsgRecordListResponse"/></returns>
        public Task<DescribeMsgRecordListResponse> DescribeMsgRecordList(DescribeMsgRecordListRequest req)
        {
            return InternalRequestAsync<DescribeMsgRecordListResponse>(req, "DescribeMsgRecordList");
        }

        /// <summary>
        /// 查询应用的对话消息记录列表，支持按渠道类型、反馈类型、意图、调用结果等条件过滤，并支持游标分页与按创建时间排序
        /// </summary>
        /// <param name="req"><see cref="DescribeMsgRecordListRequest"/></param>
        /// <returns><see cref="DescribeMsgRecordListResponse"/></returns>
        public DescribeMsgRecordListResponse DescribeMsgRecordListSync(DescribeMsgRecordListRequest req)
        {
            return InternalRequestAsync<DescribeMsgRecordListResponse>(req, "DescribeMsgRecordList")
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
        /// 查询skill详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillDetailRequest"/></param>
        /// <returns><see cref="DescribeSkillDetailResponse"/></returns>
        public Task<DescribeSkillDetailResponse> DescribeSkillDetail(DescribeSkillDetailRequest req)
        {
            return InternalRequestAsync<DescribeSkillDetailResponse>(req, "DescribeSkillDetail");
        }

        /// <summary>
        /// 查询skill详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillDetailRequest"/></param>
        /// <returns><see cref="DescribeSkillDetailResponse"/></returns>
        public DescribeSkillDetailResponse DescribeSkillDetailSync(DescribeSkillDetailRequest req)
        {
            return InternalRequestAsync<DescribeSkillDetailResponse>(req, "DescribeSkillDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个 Skill 被引用的详情列表（按 SkillRefType 分组：OpenClaw / cloud agent / 企业助手 agent） 鉴权：同 DescribeSkillDetail（能看该 Skill 即可查）
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillReferenceListRequest"/></param>
        /// <returns><see cref="DescribeSkillReferenceListResponse"/></returns>
        public Task<DescribeSkillReferenceListResponse> DescribeSkillReferenceList(DescribeSkillReferenceListRequest req)
        {
            return InternalRequestAsync<DescribeSkillReferenceListResponse>(req, "DescribeSkillReferenceList");
        }

        /// <summary>
        /// 查询某个 Skill 被引用的详情列表（按 SkillRefType 分组：OpenClaw / cloud agent / 企业助手 agent） 鉴权：同 DescribeSkillDetail（能看该 Skill 即可查）
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillReferenceListRequest"/></param>
        /// <returns><see cref="DescribeSkillReferenceListResponse"/></returns>
        public DescribeSkillReferenceListResponse DescribeSkillReferenceListSync(DescribeSkillReferenceListRequest req)
        {
            return InternalRequestAsync<DescribeSkillReferenceListResponse>(req, "DescribeSkillReferenceList")
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
        /// 查询资源调用时序明细，支持模型和插件两类资源，按时间顺序返回每条调用记录的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageDetailListRequest"/></param>
        /// <returns><see cref="DescribeUsageDetailListResponse"/></returns>
        public Task<DescribeUsageDetailListResponse> DescribeUsageDetailList(DescribeUsageDetailListRequest req)
        {
            return InternalRequestAsync<DescribeUsageDetailListResponse>(req, "DescribeUsageDetailList");
        }

        /// <summary>
        /// 查询资源调用时序明细，支持模型和插件两类资源，按时间顺序返回每条调用记录的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageDetailListRequest"/></param>
        /// <returns><see cref="DescribeUsageDetailListResponse"/></returns>
        public DescribeUsageDetailListResponse DescribeUsageDetailListSync(DescribeUsageDetailListRequest req)
        {
            return InternalRequestAsync<DescribeUsageDetailListResponse>(req, "DescribeUsageDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源用量聚合明细，支持模型、插件、平台三类资源，按空间/应用维度聚合展示调用次数、Token消耗等指标
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryListRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryListResponse"/></returns>
        public Task<DescribeUsageSummaryListResponse> DescribeUsageSummaryList(DescribeUsageSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeUsageSummaryListResponse>(req, "DescribeUsageSummaryList");
        }

        /// <summary>
        /// 查询资源用量聚合明细，支持模型、插件、平台三类资源，按空间/应用维度聚合展示调用次数、Token消耗等指标
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageSummaryListRequest"/></param>
        /// <returns><see cref="DescribeUsageSummaryListResponse"/></returns>
        public DescribeUsageSummaryListResponse DescribeUsageSummaryListSync(DescribeUsageSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeUsageSummaryListResponse>(req, "DescribeUsageSummaryList")
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
        /// 收藏插件
        /// </summary>
        /// <param name="req"><see cref="FavoritePluginRequest"/></param>
        /// <returns><see cref="FavoritePluginResponse"/></returns>
        public Task<FavoritePluginResponse> FavoritePlugin(FavoritePluginRequest req)
        {
            return InternalRequestAsync<FavoritePluginResponse>(req, "FavoritePlugin");
        }

        /// <summary>
        /// 收藏插件
        /// </summary>
        /// <param name="req"><see cref="FavoritePluginRequest"/></param>
        /// <returns><see cref="FavoritePluginResponse"/></returns>
        public FavoritePluginResponse FavoritePluginSync(FavoritePluginRequest req)
        {
            return InternalRequestAsync<FavoritePluginResponse>(req, "FavoritePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 收藏skill
        /// </summary>
        /// <param name="req"><see cref="FavoriteSkillRequest"/></param>
        /// <returns><see cref="FavoriteSkillResponse"/></returns>
        public Task<FavoriteSkillResponse> FavoriteSkill(FavoriteSkillRequest req)
        {
            return InternalRequestAsync<FavoriteSkillResponse>(req, "FavoriteSkill");
        }

        /// <summary>
        /// 收藏skill
        /// </summary>
        /// <param name="req"><see cref="FavoriteSkillRequest"/></param>
        /// <returns><see cref="FavoriteSkillResponse"/></returns>
        public FavoriteSkillResponse FavoriteSkillSync(FavoriteSkillRequest req)
        {
            return InternalRequestAsync<FavoriteSkillResponse>(req, "FavoriteSkill")
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
        /// ModifyAppTrigger
        /// </summary>
        /// <param name="req"><see cref="ModifyAppTriggerRequest"/></param>
        /// <returns><see cref="ModifyAppTriggerResponse"/></returns>
        public Task<ModifyAppTriggerResponse> ModifyAppTrigger(ModifyAppTriggerRequest req)
        {
            return InternalRequestAsync<ModifyAppTriggerResponse>(req, "ModifyAppTrigger");
        }

        /// <summary>
        /// ModifyAppTrigger
        /// </summary>
        /// <param name="req"><see cref="ModifyAppTriggerRequest"/></param>
        /// <returns><see cref="ModifyAppTriggerResponse"/></returns>
        public ModifyAppTriggerResponse ModifyAppTriggerSync(ModifyAppTriggerRequest req)
        {
            return InternalRequestAsync<ModifyAppTriggerResponse>(req, "ModifyAppTrigger")
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
        /// 修改指定消息记录分类的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="ModifyMsgRecordCategoryResponse"/></returns>
        public Task<ModifyMsgRecordCategoryResponse> ModifyMsgRecordCategory(ModifyMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<ModifyMsgRecordCategoryResponse>(req, "ModifyMsgRecordCategory");
        }

        /// <summary>
        /// 修改指定消息记录分类的名称
        /// </summary>
        /// <param name="req"><see cref="ModifyMsgRecordCategoryRequest"/></param>
        /// <returns><see cref="ModifyMsgRecordCategoryResponse"/></returns>
        public ModifyMsgRecordCategoryResponse ModifyMsgRecordCategorySync(ModifyMsgRecordCategoryRequest req)
        {
            return InternalRequestAsync<ModifyMsgRecordCategoryResponse>(req, "ModifyMsgRecordCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改插件
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public Task<ModifyPluginResponse> ModifyPlugin(ModifyPluginRequest req)
        {
            return InternalRequestAsync<ModifyPluginResponse>(req, "ModifyPlugin");
        }

        /// <summary>
        /// 修改插件
        /// </summary>
        /// <param name="req"><see cref="ModifyPluginRequest"/></param>
        /// <returns><see cref="ModifyPluginResponse"/></returns>
        public ModifyPluginResponse ModifyPluginSync(ModifyPluginRequest req)
        {
            return InternalRequestAsync<ModifyPluginResponse>(req, "ModifyPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Skill修改
        /// </summary>
        /// <param name="req"><see cref="ModifySkillRequest"/></param>
        /// <returns><see cref="ModifySkillResponse"/></returns>
        public Task<ModifySkillResponse> ModifySkill(ModifySkillRequest req)
        {
            return InternalRequestAsync<ModifySkillResponse>(req, "ModifySkill");
        }

        /// <summary>
        /// Skill修改
        /// </summary>
        /// <param name="req"><see cref="ModifySkillRequest"/></param>
        /// <returns><see cref="ModifySkillResponse"/></returns>
        public ModifySkillResponse ModifySkillSync(ModifySkillRequest req)
        {
            return InternalRequestAsync<ModifySkillResponse>(req, "ModifySkill")
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
        /// PauseAppTrigger
        /// </summary>
        /// <param name="req"><see cref="PauseAppTriggerRequest"/></param>
        /// <returns><see cref="PauseAppTriggerResponse"/></returns>
        public Task<PauseAppTriggerResponse> PauseAppTrigger(PauseAppTriggerRequest req)
        {
            return InternalRequestAsync<PauseAppTriggerResponse>(req, "PauseAppTrigger");
        }

        /// <summary>
        /// PauseAppTrigger
        /// </summary>
        /// <param name="req"><see cref="PauseAppTriggerRequest"/></param>
        /// <returns><see cref="PauseAppTriggerResponse"/></returns>
        public PauseAppTriggerResponse PauseAppTriggerSync(PauseAppTriggerRequest req)
        {
            return InternalRequestAsync<PauseAppTriggerResponse>(req, "PauseAppTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上架skill
        /// </summary>
        /// <param name="req"><see cref="ReleaseSkillRequest"/></param>
        /// <returns><see cref="ReleaseSkillResponse"/></returns>
        public Task<ReleaseSkillResponse> ReleaseSkill(ReleaseSkillRequest req)
        {
            return InternalRequestAsync<ReleaseSkillResponse>(req, "ReleaseSkill");
        }

        /// <summary>
        /// 上架skill
        /// </summary>
        /// <param name="req"><see cref="ReleaseSkillRequest"/></param>
        /// <returns><see cref="ReleaseSkillResponse"/></returns>
        public ReleaseSkillResponse ReleaseSkillSync(ReleaseSkillRequest req)
        {
            return InternalRequestAsync<ReleaseSkillResponse>(req, "ReleaseSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置会话
        /// 注意：当前Claw模式应用会话不支持重置
        /// </summary>
        /// <param name="req"><see cref="ResetConversationRequest"/></param>
        /// <returns><see cref="ResetConversationResponse"/></returns>
        public Task<ResetConversationResponse> ResetConversation(ResetConversationRequest req)
        {
            return InternalRequestAsync<ResetConversationResponse>(req, "ResetConversation");
        }

        /// <summary>
        /// 重置会话
        /// 注意：当前Claw模式应用会话不支持重置
        /// </summary>
        /// <param name="req"><see cref="ResetConversationRequest"/></param>
        /// <returns><see cref="ResetConversationResponse"/></returns>
        public ResetConversationResponse ResetConversationSync(ResetConversationRequest req)
        {
            return InternalRequestAsync<ResetConversationResponse>(req, "ResetConversation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ResumeAppTrigger
        /// </summary>
        /// <param name="req"><see cref="ResumeAppTriggerRequest"/></param>
        /// <returns><see cref="ResumeAppTriggerResponse"/></returns>
        public Task<ResumeAppTriggerResponse> ResumeAppTrigger(ResumeAppTriggerRequest req)
        {
            return InternalRequestAsync<ResumeAppTriggerResponse>(req, "ResumeAppTrigger");
        }

        /// <summary>
        /// ResumeAppTrigger
        /// </summary>
        /// <param name="req"><see cref="ResumeAppTriggerRequest"/></param>
        /// <returns><see cref="ResumeAppTriggerResponse"/></returns>
        public ResumeAppTriggerResponse ResumeAppTriggerSync(ResumeAppTriggerRequest req)
        {
            return InternalRequestAsync<ResumeAppTriggerResponse>(req, "ResumeAppTrigger")
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

        /// <summary>
        /// RunAppTriggerNow
        /// </summary>
        /// <param name="req"><see cref="RunAppTriggerNowRequest"/></param>
        /// <returns><see cref="RunAppTriggerNowResponse"/></returns>
        public Task<RunAppTriggerNowResponse> RunAppTriggerNow(RunAppTriggerNowRequest req)
        {
            return InternalRequestAsync<RunAppTriggerNowResponse>(req, "RunAppTriggerNow");
        }

        /// <summary>
        /// RunAppTriggerNow
        /// </summary>
        /// <param name="req"><see cref="RunAppTriggerNowRequest"/></param>
        /// <returns><see cref="RunAppTriggerNowResponse"/></returns>
        public RunAppTriggerNowResponse RunAppTriggerNowSync(RunAppTriggerNowRequest req)
        {
            return InternalRequestAsync<RunAppTriggerNowResponse>(req, "RunAppTriggerNow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消收藏插件
        /// </summary>
        /// <param name="req"><see cref="UnfavoritePluginRequest"/></param>
        /// <returns><see cref="UnfavoritePluginResponse"/></returns>
        public Task<UnfavoritePluginResponse> UnfavoritePlugin(UnfavoritePluginRequest req)
        {
            return InternalRequestAsync<UnfavoritePluginResponse>(req, "UnfavoritePlugin");
        }

        /// <summary>
        /// 取消收藏插件
        /// </summary>
        /// <param name="req"><see cref="UnfavoritePluginRequest"/></param>
        /// <returns><see cref="UnfavoritePluginResponse"/></returns>
        public UnfavoritePluginResponse UnfavoritePluginSync(UnfavoritePluginRequest req)
        {
            return InternalRequestAsync<UnfavoritePluginResponse>(req, "UnfavoritePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消收藏skill
        /// </summary>
        /// <param name="req"><see cref="UnfavoriteSkillRequest"/></param>
        /// <returns><see cref="UnfavoriteSkillResponse"/></returns>
        public Task<UnfavoriteSkillResponse> UnfavoriteSkill(UnfavoriteSkillRequest req)
        {
            return InternalRequestAsync<UnfavoriteSkillResponse>(req, "UnfavoriteSkill");
        }

        /// <summary>
        /// 取消收藏skill
        /// </summary>
        /// <param name="req"><see cref="UnfavoriteSkillRequest"/></param>
        /// <returns><see cref="UnfavoriteSkillResponse"/></returns>
        public UnfavoriteSkillResponse UnfavoriteSkillSync(UnfavoriteSkillRequest req)
        {
            return InternalRequestAsync<UnfavoriteSkillResponse>(req, "UnfavoriteSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
