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

namespace TencentCloud.Workbuddyenterprise.V20260709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Workbuddyenterprise.V20260709.Models;

   public class WorkbuddyenterpriseClient : AbstractClient{

       private const string endpoint = "workbuddyenterprise.tencentcloudapi.com";
       private const string version = "2026-07-09";
       private const string sdkVersion = "SDK_NET_3.0.1512";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WorkbuddyenterpriseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WorkbuddyenterpriseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 把外部 agent 绑定到某 managed agent
        /// </summary>
        /// <param name="req"><see cref="BindExternalAgentRequest"/></param>
        /// <returns><see cref="BindExternalAgentResponse"/></returns>
        public Task<BindExternalAgentResponse> BindExternalAgent(BindExternalAgentRequest req)
        {
            return InternalRequestAsync<BindExternalAgentResponse>(req, "BindExternalAgent");
        }

        /// <summary>
        /// 把外部 agent 绑定到某 managed agent
        /// </summary>
        /// <param name="req"><see cref="BindExternalAgentRequest"/></param>
        /// <returns><see cref="BindExternalAgentResponse"/></returns>
        public BindExternalAgentResponse BindExternalAgentSync(BindExternalAgentRequest req)
        {
            return InternalRequestAsync<BindExternalAgentResponse>(req, "BindExternalAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个新的 Managed Agent，同时自动生成 default 版本。配置采用 Manifest v2.0。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentRequest"/></param>
        /// <returns><see cref="CreateAgentResponse"/></returns>
        public Task<CreateAgentResponse> CreateAgent(CreateAgentRequest req)
        {
            return InternalRequestAsync<CreateAgentResponse>(req, "CreateAgent");
        }

        /// <summary>
        /// 创建一个新的 Managed Agent，同时自动生成 default 版本。配置采用 Manifest v2.0。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentRequest"/></param>
        /// <returns><see cref="CreateAgentResponse"/></returns>
        public CreateAgentResponse CreateAgentSync(CreateAgentRequest req)
        {
            return InternalRequestAsync<CreateAgentResponse>(req, "CreateAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为指定 Agent 创建新的会话，返回会话 ID 和聊天凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentSessionRequest"/></param>
        /// <returns><see cref="CreateAgentSessionResponse"/></returns>
        public Task<CreateAgentSessionResponse> CreateAgentSession(CreateAgentSessionRequest req)
        {
            return InternalRequestAsync<CreateAgentSessionResponse>(req, "CreateAgentSession");
        }

        /// <summary>
        /// 为指定 Agent 创建新的会话，返回会话 ID 和聊天凭证。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentSessionRequest"/></param>
        /// <returns><see cref="CreateAgentSessionResponse"/></returns>
        public CreateAgentSessionResponse CreateAgentSessionSync(CreateAgentSessionRequest req)
        {
            return InternalRequestAsync<CreateAgentSessionResponse>(req, "CreateAgentSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完全新建版本：外部准备完整 Manifest 后直接传入，不引用任何已有版本。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentVersionRequest"/></param>
        /// <returns><see cref="CreateAgentVersionResponse"/></returns>
        public Task<CreateAgentVersionResponse> CreateAgentVersion(CreateAgentVersionRequest req)
        {
            return InternalRequestAsync<CreateAgentVersionResponse>(req, "CreateAgentVersion");
        }

        /// <summary>
        /// 完全新建版本：外部准备完整 Manifest 后直接传入，不引用任何已有版本。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentVersionRequest"/></param>
        /// <returns><see cref="CreateAgentVersionResponse"/></returns>
        public CreateAgentVersionResponse CreateAgentVersionSync(CreateAgentVersionRequest req)
        {
            return InternalRequestAsync<CreateAgentVersionResponse>(req, "CreateAgentVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于源版本创建新版本：Manifest / Model / Description 传入即整体覆盖，未传则沿用源版本。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentVersionFromSourceRequest"/></param>
        /// <returns><see cref="CreateAgentVersionFromSourceResponse"/></returns>
        public Task<CreateAgentVersionFromSourceResponse> CreateAgentVersionFromSource(CreateAgentVersionFromSourceRequest req)
        {
            return InternalRequestAsync<CreateAgentVersionFromSourceResponse>(req, "CreateAgentVersionFromSource");
        }

        /// <summary>
        /// 基于源版本创建新版本：Manifest / Model / Description 传入即整体覆盖，未传则沿用源版本。
        /// </summary>
        /// <param name="req"><see cref="CreateAgentVersionFromSourceRequest"/></param>
        /// <returns><see cref="CreateAgentVersionFromSourceResponse"/></returns>
        public CreateAgentVersionFromSourceResponse CreateAgentVersionFromSourceSync(CreateAgentVersionFromSourceRequest req)
        {
            return InternalRequestAsync<CreateAgentVersionFromSourceResponse>(req, "CreateAgentVersionFromSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定的 Agent 及其所有版本。删除后不可恢复。
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentRequest"/></param>
        /// <returns><see cref="DeleteAgentResponse"/></returns>
        public Task<DeleteAgentResponse> DeleteAgent(DeleteAgentRequest req)
        {
            return InternalRequestAsync<DeleteAgentResponse>(req, "DeleteAgent");
        }

        /// <summary>
        /// 删除指定的 Agent 及其所有版本。删除后不可恢复。
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentRequest"/></param>
        /// <returns><see cref="DeleteAgentResponse"/></returns>
        public DeleteAgentResponse DeleteAgentSync(DeleteAgentRequest req)
        {
            return InternalRequestAsync<DeleteAgentResponse>(req, "DeleteAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个 Agent 的详细信息，包括基础配置和路由配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRequest"/></param>
        /// <returns><see cref="DescribeAgentResponse"/></returns>
        public Task<DescribeAgentResponse> DescribeAgent(DescribeAgentRequest req)
        {
            return InternalRequestAsync<DescribeAgentResponse>(req, "DescribeAgent");
        }

        /// <summary>
        /// 查询单个 Agent 的详细信息，包括基础配置和路由配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRequest"/></param>
        /// <returns><see cref="DescribeAgentResponse"/></returns>
        public DescribeAgentResponse DescribeAgentSync(DescribeAgentRequest req)
        {
            return InternalRequestAsync<DescribeAgentResponse>(req, "DescribeAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前企业的 Agent 列表，支持分页、过滤和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentListRequest"/></param>
        /// <returns><see cref="DescribeAgentListResponse"/></returns>
        public Task<DescribeAgentListResponse> DescribeAgentList(DescribeAgentListRequest req)
        {
            return InternalRequestAsync<DescribeAgentListResponse>(req, "DescribeAgentList");
        }

        /// <summary>
        /// 查询当前企业的 Agent 列表，支持分页、过滤和排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentListRequest"/></param>
        /// <returns><see cref="DescribeAgentListResponse"/></returns>
        public DescribeAgentListResponse DescribeAgentListSync(DescribeAgentListRequest req)
        {
            return InternalRequestAsync<DescribeAgentListResponse>(req, "DescribeAgentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个 Agent 会话详情：返回会话基础信息（会话名称 / Agent / 版本 / 状态 / 来源 / 发起人）与可用的聊天接入点列表（EndpointSet）。数据面鉴权走 DescribeUserAccessToken 的用户级访问令牌。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSessionRequest"/></param>
        /// <returns><see cref="DescribeAgentSessionResponse"/></returns>
        public Task<DescribeAgentSessionResponse> DescribeAgentSession(DescribeAgentSessionRequest req)
        {
            return InternalRequestAsync<DescribeAgentSessionResponse>(req, "DescribeAgentSession");
        }

        /// <summary>
        /// 查询单个 Agent 会话详情：返回会话基础信息（会话名称 / Agent / 版本 / 状态 / 来源 / 发起人）与可用的聊天接入点列表（EndpointSet）。数据面鉴权走 DescribeUserAccessToken 的用户级访问令牌。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSessionRequest"/></param>
        /// <returns><see cref="DescribeAgentSessionResponse"/></returns>
        public DescribeAgentSessionResponse DescribeAgentSessionSync(DescribeAgentSessionRequest req)
        {
            return InternalRequestAsync<DescribeAgentSessionResponse>(req, "DescribeAgentSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询企业下所有会话（跨 Agent）：支持按 SessionId / Status / AgentId / UserId 过滤，按创建 / 更新时间排序，返回会话摘要列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSessionListRequest"/></param>
        /// <returns><see cref="DescribeAgentSessionListResponse"/></returns>
        public Task<DescribeAgentSessionListResponse> DescribeAgentSessionList(DescribeAgentSessionListRequest req)
        {
            return InternalRequestAsync<DescribeAgentSessionListResponse>(req, "DescribeAgentSessionList");
        }

        /// <summary>
        /// 分页查询企业下所有会话（跨 Agent）：支持按 SessionId / Status / AgentId / UserId 过滤，按创建 / 更新时间排序，返回会话摘要列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentSessionListRequest"/></param>
        /// <returns><see cref="DescribeAgentSessionListResponse"/></returns>
        public DescribeAgentSessionListResponse DescribeAgentSessionListSync(DescribeAgentSessionListRequest req)
        {
            return InternalRequestAsync<DescribeAgentSessionListResponse>(req, "DescribeAgentSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个版本的详细信息，包括 Manifest、Model、状态等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVersionRequest"/></param>
        /// <returns><see cref="DescribeAgentVersionResponse"/></returns>
        public Task<DescribeAgentVersionResponse> DescribeAgentVersion(DescribeAgentVersionRequest req)
        {
            return InternalRequestAsync<DescribeAgentVersionResponse>(req, "DescribeAgentVersion");
        }

        /// <summary>
        /// 查询单个版本的详细信息，包括 Manifest、Model、状态等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVersionRequest"/></param>
        /// <returns><see cref="DescribeAgentVersionResponse"/></returns>
        public DescribeAgentVersionResponse DescribeAgentVersionSync(DescribeAgentVersionRequest req)
        {
            return InternalRequestAsync<DescribeAgentVersionResponse>(req, "DescribeAgentVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定 Agent 下的版本列表，支持分页和版本类型过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVersionListRequest"/></param>
        /// <returns><see cref="DescribeAgentVersionListResponse"/></returns>
        public Task<DescribeAgentVersionListResponse> DescribeAgentVersionList(DescribeAgentVersionListRequest req)
        {
            return InternalRequestAsync<DescribeAgentVersionListResponse>(req, "DescribeAgentVersionList");
        }

        /// <summary>
        /// 查询指定 Agent 下的版本列表，支持分页和版本类型过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVersionListRequest"/></param>
        /// <returns><see cref="DescribeAgentVersionListResponse"/></returns>
        public DescribeAgentVersionListResponse DescribeAgentVersionListSync(DescribeAgentVersionListRequest req)
        {
            return InternalRequestAsync<DescribeAgentVersionListResponse>(req, "DescribeAgentVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前企业的内置模型列表，支持分页与过滤。内置模型由平台预置，企业可按需启用/停用。过滤字段支持：ModelId（模型ID，模糊）、Name（模型名称，模糊）、Vendor（供应商，模糊）、Status（状态，精确：enabled/disabled）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBuiltinModelListRequest"/></param>
        /// <returns><see cref="DescribeBuiltinModelListResponse"/></returns>
        public Task<DescribeBuiltinModelListResponse> DescribeBuiltinModelList(DescribeBuiltinModelListRequest req)
        {
            return InternalRequestAsync<DescribeBuiltinModelListResponse>(req, "DescribeBuiltinModelList");
        }

        /// <summary>
        /// 查询当前企业的内置模型列表，支持分页与过滤。内置模型由平台预置，企业可按需启用/停用。过滤字段支持：ModelId（模型ID，模糊）、Name（模型名称，模糊）、Vendor（供应商，模糊）、Status（状态，精确：enabled/disabled）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBuiltinModelListRequest"/></param>
        /// <returns><see cref="DescribeBuiltinModelListResponse"/></returns>
        public DescribeBuiltinModelListResponse DescribeBuiltinModelListSync(DescribeBuiltinModelListRequest req)
        {
            return InternalRequestAsync<DescribeBuiltinModelListResponse>(req, "DescribeBuiltinModelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定企业下的连接器列表（PageNumber/PageSize 分页，支持名称模糊与状态、来源过滤）。
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectorListRequest"/></param>
        /// <returns><see cref="DescribeConnectorListResponse"/></returns>
        public Task<DescribeConnectorListResponse> DescribeConnectorList(DescribeConnectorListRequest req)
        {
            return InternalRequestAsync<DescribeConnectorListResponse>(req, "DescribeConnectorList");
        }

        /// <summary>
        /// 查询指定企业下的连接器列表（PageNumber/PageSize 分页，支持名称模糊与状态、来源过滤）。
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectorListRequest"/></param>
        /// <returns><see cref="DescribeConnectorListResponse"/></returns>
        public DescribeConnectorListResponse DescribeConnectorListSync(DescribeConnectorListRequest req)
        {
            return InternalRequestAsync<DescribeConnectorListResponse>(req, "DescribeConnectorList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询 Expert 列表，支持关键词、分类、发布状态过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertListRequest"/></param>
        /// <returns><see cref="DescribeExpertListResponse"/></returns>
        public Task<DescribeExpertListResponse> DescribeExpertList(DescribeExpertListRequest req)
        {
            return InternalRequestAsync<DescribeExpertListResponse>(req, "DescribeExpertList");
        }

        /// <summary>
        /// 分页查询 Expert 列表，支持关键词、分类、发布状态过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertListRequest"/></param>
        /// <returns><see cref="DescribeExpertListResponse"/></returns>
        public DescribeExpertListResponse DescribeExpertListSync(DescribeExpertListRequest req)
        {
            return InternalRequestAsync<DescribeExpertListResponse>(req, "DescribeExpertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某 managed agent 绑定的单个外部 agent 详情
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalAgentRequest"/></param>
        /// <returns><see cref="DescribeExternalAgentResponse"/></returns>
        public Task<DescribeExternalAgentResponse> DescribeExternalAgent(DescribeExternalAgentRequest req)
        {
            return InternalRequestAsync<DescribeExternalAgentResponse>(req, "DescribeExternalAgent");
        }

        /// <summary>
        /// 查询某 managed agent 绑定的单个外部 agent 详情
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalAgentRequest"/></param>
        /// <returns><see cref="DescribeExternalAgentResponse"/></returns>
        public DescribeExternalAgentResponse DescribeExternalAgentSync(DescribeExternalAgentRequest req)
        {
            return InternalRequestAsync<DescribeExternalAgentResponse>(req, "DescribeExternalAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列某 managed agent 绑定的外部 agent 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalAgentListRequest"/></param>
        /// <returns><see cref="DescribeExternalAgentListResponse"/></returns>
        public Task<DescribeExternalAgentListResponse> DescribeExternalAgentList(DescribeExternalAgentListRequest req)
        {
            return InternalRequestAsync<DescribeExternalAgentListResponse>(req, "DescribeExternalAgentList");
        }

        /// <summary>
        /// 列某 managed agent 绑定的外部 agent 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalAgentListRequest"/></param>
        /// <returns><see cref="DescribeExternalAgentListResponse"/></returns>
        public DescribeExternalAgentListResponse DescribeExternalAgentListSync(DescribeExternalAgentListRequest req)
        {
            return InternalRequestAsync<DescribeExternalAgentListResponse>(req, "DescribeExternalAgentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按 Session 分页查询消息事件
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageEventListRequest"/></param>
        /// <returns><see cref="DescribeMessageEventListResponse"/></returns>
        public Task<DescribeMessageEventListResponse> DescribeMessageEventList(DescribeMessageEventListRequest req)
        {
            return InternalRequestAsync<DescribeMessageEventListResponse>(req, "DescribeMessageEventList");
        }

        /// <summary>
        /// 按 Session 分页查询消息事件
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageEventListRequest"/></param>
        /// <returns><see cref="DescribeMessageEventListResponse"/></returns>
        public DescribeMessageEventListResponse DescribeMessageEventListSync(DescribeMessageEventListRequest req)
        {
            return InternalRequestAsync<DescribeMessageEventListResponse>(req, "DescribeMessageEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询 Skill 列表，支持关键词、分类、发布状态过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillListRequest"/></param>
        /// <returns><see cref="DescribeSkillListResponse"/></returns>
        public Task<DescribeSkillListResponse> DescribeSkillList(DescribeSkillListRequest req)
        {
            return InternalRequestAsync<DescribeSkillListResponse>(req, "DescribeSkillList");
        }

        /// <summary>
        /// 分页查询 Skill 列表，支持关键词、分类、发布状态过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillListRequest"/></param>
        /// <returns><see cref="DescribeSkillListResponse"/></returns>
        public DescribeSkillListResponse DescribeSkillListSync(DescribeSkillListRequest req)
        {
            return InternalRequestAsync<DescribeSkillListResponse>(req, "DescribeSkillList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据调用者的 Uin / SubAccountUin 调用 OneID 换取用户级 access_token。换取到的 token 是 OneID 用户身份的短期凭证，供调用方以用户身份访问 OneID 开平接口。默认开启 JIT，SubAccountUin 不存在时自动在目标企业下创建影子用户。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAccessTokenRequest"/></param>
        /// <returns><see cref="DescribeUserAccessTokenResponse"/></returns>
        public Task<DescribeUserAccessTokenResponse> DescribeUserAccessToken(DescribeUserAccessTokenRequest req)
        {
            return InternalRequestAsync<DescribeUserAccessTokenResponse>(req, "DescribeUserAccessToken");
        }

        /// <summary>
        /// 根据调用者的 Uin / SubAccountUin 调用 OneID 换取用户级 access_token。换取到的 token 是 OneID 用户身份的短期凭证，供调用方以用户身份访问 OneID 开平接口。默认开启 JIT，SubAccountUin 不存在时自动在目标企业下创建影子用户。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAccessTokenRequest"/></param>
        /// <returns><see cref="DescribeUserAccessTokenResponse"/></returns>
        public DescribeUserAccessTokenResponse DescribeUserAccessTokenSync(DescribeUserAccessTokenRequest req)
        {
            return InternalRequestAsync<DescribeUserAccessTokenResponse>(req, "DescribeUserAccessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将指定会话迁移到目标版本。SessionID / RuntimeID 保持不变，通过 AgentOS UpdateSession 在原沙箱上更新 manifest 到新版本；AgentId 必须与原 Session 一致（禁止跨 Agent 迁移）；ChatToken 复用旧值不轮转。
        /// </summary>
        /// <param name="req"><see cref="MigrateAgentSessionRequest"/></param>
        /// <returns><see cref="MigrateAgentSessionResponse"/></returns>
        public Task<MigrateAgentSessionResponse> MigrateAgentSession(MigrateAgentSessionRequest req)
        {
            return InternalRequestAsync<MigrateAgentSessionResponse>(req, "MigrateAgentSession");
        }

        /// <summary>
        /// 将指定会话迁移到目标版本。SessionID / RuntimeID 保持不变，通过 AgentOS UpdateSession 在原沙箱上更新 manifest 到新版本；AgentId 必须与原 Session 一致（禁止跨 Agent 迁移）；ChatToken 复用旧值不轮转。
        /// </summary>
        /// <param name="req"><see cref="MigrateAgentSessionRequest"/></param>
        /// <returns><see cref="MigrateAgentSessionResponse"/></returns>
        public MigrateAgentSessionResponse MigrateAgentSessionSync(MigrateAgentSessionRequest req)
        {
            return InternalRequestAsync<MigrateAgentSessionResponse>(req, "MigrateAgentSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 Agent 基础信息（名称、描述、头像）。AgentName / Description / AvatarUrl 均为可选，仅传递需要更新的字段。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRequest"/></param>
        /// <returns><see cref="ModifyAgentResponse"/></returns>
        public Task<ModifyAgentResponse> ModifyAgent(ModifyAgentRequest req)
        {
            return InternalRequestAsync<ModifyAgentResponse>(req, "ModifyAgent");
        }

        /// <summary>
        /// 修改 Agent 基础信息（名称、描述、头像）。AgentName / Description / AvatarUrl 均为可选，仅传递需要更新的字段。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRequest"/></param>
        /// <returns><see cref="ModifyAgentResponse"/></returns>
        public ModifyAgentResponse ModifyAgentSync(ModifyAgentRequest req)
        {
            return InternalRequestAsync<ModifyAgentResponse>(req, "ModifyAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 Agent 的 A2A 配置。A2AEnabled 是 Agent 级唯一开关，与具体版本和流量分发策略无关。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentA2AConfigRequest"/></param>
        /// <returns><see cref="ModifyAgentA2AConfigResponse"/></returns>
        public Task<ModifyAgentA2AConfigResponse> ModifyAgentA2AConfig(ModifyAgentA2AConfigRequest req)
        {
            return InternalRequestAsync<ModifyAgentA2AConfigResponse>(req, "ModifyAgentA2AConfig");
        }

        /// <summary>
        /// 修改 Agent 的 A2A 配置。A2AEnabled 是 Agent 级唯一开关，与具体版本和流量分发策略无关。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentA2AConfigRequest"/></param>
        /// <returns><see cref="ModifyAgentA2AConfigResponse"/></returns>
        public ModifyAgentA2AConfigResponse ModifyAgentA2AConfigSync(ModifyAgentA2AConfigRequest req)
        {
            return InternalRequestAsync<ModifyAgentA2AConfigResponse>(req, "ModifyAgentA2AConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 覆盖式写入 Agent 路由配置（版本权重）。所有 VersionId 必须属于同一 Agent 且未弃用；允许空数组（下线 Agent 对外流量）；非空时权重总和须等于 1。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRoutingRequest"/></param>
        /// <returns><see cref="ModifyAgentRoutingResponse"/></returns>
        public Task<ModifyAgentRoutingResponse> ModifyAgentRouting(ModifyAgentRoutingRequest req)
        {
            return InternalRequestAsync<ModifyAgentRoutingResponse>(req, "ModifyAgentRouting");
        }

        /// <summary>
        /// 覆盖式写入 Agent 路由配置（版本权重）。所有 VersionId 必须属于同一 Agent 且未弃用；允许空数组（下线 Agent 对外流量）；非空时权重总和须等于 1。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRoutingRequest"/></param>
        /// <returns><see cref="ModifyAgentRoutingResponse"/></returns>
        public ModifyAgentRoutingResponse ModifyAgentRoutingSync(ModifyAgentRoutingRequest req)
        {
            return InternalRequestAsync<ModifyAgentRoutingResponse>(req, "ModifyAgentRouting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 原地更新 default 或 test 版本的 Manifest / Model / Description / SandboxTemplateId / ConnectorSet（prod 版本冻结不可修改），五个可选字段至少提供一个。ConnectorSet 为全量覆盖语义：缺省表示不改动连接器绑定；空数组表示解绑全部连接器。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentVersionRequest"/></param>
        /// <returns><see cref="ModifyAgentVersionResponse"/></returns>
        public Task<ModifyAgentVersionResponse> ModifyAgentVersion(ModifyAgentVersionRequest req)
        {
            return InternalRequestAsync<ModifyAgentVersionResponse>(req, "ModifyAgentVersion");
        }

        /// <summary>
        /// 原地更新 default 或 test 版本的 Manifest / Model / Description / SandboxTemplateId / ConnectorSet（prod 版本冻结不可修改），五个可选字段至少提供一个。ConnectorSet 为全量覆盖语义：缺省表示不改动连接器绑定；空数组表示解绑全部连接器。
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentVersionRequest"/></param>
        /// <returns><see cref="ModifyAgentVersionResponse"/></returns>
        public ModifyAgentVersionResponse ModifyAgentVersionSync(ModifyAgentVersionRequest req)
        {
            return InternalRequestAsync<ModifyAgentVersionResponse>(req, "ModifyAgentVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除外部 agent 与 managed agent 的绑定
        /// </summary>
        /// <param name="req"><see cref="UnbindExternalAgentRequest"/></param>
        /// <returns><see cref="UnbindExternalAgentResponse"/></returns>
        public Task<UnbindExternalAgentResponse> UnbindExternalAgent(UnbindExternalAgentRequest req)
        {
            return InternalRequestAsync<UnbindExternalAgentResponse>(req, "UnbindExternalAgent");
        }

        /// <summary>
        /// 解除外部 agent 与 managed agent 的绑定
        /// </summary>
        /// <param name="req"><see cref="UnbindExternalAgentRequest"/></param>
        /// <returns><see cref="UnbindExternalAgentResponse"/></returns>
        public UnbindExternalAgentResponse UnbindExternalAgentSync(UnbindExternalAgentRequest req)
        {
            return InternalRequestAsync<UnbindExternalAgentResponse>(req, "UnbindExternalAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
