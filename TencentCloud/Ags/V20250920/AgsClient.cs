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

namespace TencentCloud.Ags.V20250920
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ags.V20250920.Models;

   public class AgsClient : AbstractClient{

       private const string endpoint = "ags.tencentcloudapi.com";
       private const string version = "2025-09-20";
       private const string sdkVersion = "SDK_NET_3.0.1509";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AgsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AgsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取 Deployment 访问 Token
        /// </summary>
        /// <param name="req"><see cref="AcquireDeploymentTokenRequest"/></param>
        /// <returns><see cref="AcquireDeploymentTokenResponse"/></returns>
        public Task<AcquireDeploymentTokenResponse> AcquireDeploymentToken(AcquireDeploymentTokenRequest req)
        {
            return InternalRequestAsync<AcquireDeploymentTokenResponse>(req, "AcquireDeploymentToken");
        }

        /// <summary>
        /// 获取 Deployment 访问 Token
        /// </summary>
        /// <param name="req"><see cref="AcquireDeploymentTokenRequest"/></param>
        /// <returns><see cref="AcquireDeploymentTokenResponse"/></returns>
        public AcquireDeploymentTokenResponse AcquireDeploymentTokenSync(AcquireDeploymentTokenRequest req)
        {
            return InternalRequestAsync<AcquireDeploymentTokenResponse>(req, "AcquireDeploymentToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取访问沙箱工具时所需要使用的访问Token，创建沙箱实例后需调用此接口获取沙箱实例访问Token。
        /// 此Token可用于调用代码沙箱实例执行代码，或浏览器沙箱实例进行浏览器操作等。
        /// </summary>
        /// <param name="req"><see cref="AcquireSandboxInstanceTokenRequest"/></param>
        /// <returns><see cref="AcquireSandboxInstanceTokenResponse"/></returns>
        public Task<AcquireSandboxInstanceTokenResponse> AcquireSandboxInstanceToken(AcquireSandboxInstanceTokenRequest req)
        {
            return InternalRequestAsync<AcquireSandboxInstanceTokenResponse>(req, "AcquireSandboxInstanceToken");
        }

        /// <summary>
        /// 获取访问沙箱工具时所需要使用的访问Token，创建沙箱实例后需调用此接口获取沙箱实例访问Token。
        /// 此Token可用于调用代码沙箱实例执行代码，或浏览器沙箱实例进行浏览器操作等。
        /// </summary>
        /// <param name="req"><see cref="AcquireSandboxInstanceTokenRequest"/></param>
        /// <returns><see cref="AcquireSandboxInstanceTokenResponse"/></returns>
        public AcquireSandboxInstanceTokenResponse AcquireSandboxInstanceTokenSync(AcquireSandboxInstanceTokenRequest req)
        {
            return InternalRequestAsync<AcquireSandboxInstanceTokenResponse>(req, "AcquireSandboxInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 追加事件。
        /// 
        /// 向指定会话追加一条事件。
        /// </summary>
        /// <param name="req"><see cref="AppendEventRequest"/></param>
        /// <returns><see cref="AppendEventResponse"/></returns>
        public Task<AppendEventResponse> AppendEvent(AppendEventRequest req)
        {
            return InternalRequestAsync<AppendEventResponse>(req, "AppendEvent");
        }

        /// <summary>
        /// 追加事件。
        /// 
        /// 向指定会话追加一条事件。
        /// </summary>
        /// <param name="req"><see cref="AppendEventRequest"/></param>
        /// <returns><see cref="AppendEventResponse"/></returns>
        public AppendEventResponse AppendEventSync(AppendEventRequest req)
        {
            return InternalRequestAsync<AppendEventResponse>(req, "AppendEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过 Version 审批：PENDING_APPROVAL → APPROVED。Comment 必填。
        /// </summary>
        /// <param name="req"><see cref="ApproveRegistryRecordRequest"/></param>
        /// <returns><see cref="ApproveRegistryRecordResponse"/></returns>
        public Task<ApproveRegistryRecordResponse> ApproveRegistryRecord(ApproveRegistryRecordRequest req)
        {
            return InternalRequestAsync<ApproveRegistryRecordResponse>(req, "ApproveRegistryRecord");
        }

        /// <summary>
        /// 通过 Version 审批：PENDING_APPROVAL → APPROVED。Comment 必填。
        /// </summary>
        /// <param name="req"><see cref="ApproveRegistryRecordRequest"/></param>
        /// <returns><see cref="ApproveRegistryRecordResponse"/></returns>
        public ApproveRegistryRecordResponse ApproveRegistryRecordSync(ApproveRegistryRecordRequest req)
        {
            return InternalRequestAsync<ApproveRegistryRecordResponse>(req, "ApproveRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// PREPARING/PENDING_APPROVAL → CANCELED。Comment 必填。
        /// </summary>
        /// <param name="req"><see cref="CancelRegistryRecordRequest"/></param>
        /// <returns><see cref="CancelRegistryRecordResponse"/></returns>
        public Task<CancelRegistryRecordResponse> CancelRegistryRecord(CancelRegistryRecordRequest req)
        {
            return InternalRequestAsync<CancelRegistryRecordResponse>(req, "CancelRegistryRecord");
        }

        /// <summary>
        /// PREPARING/PENDING_APPROVAL → CANCELED。Comment 必填。
        /// </summary>
        /// <param name="req"><see cref="CancelRegistryRecordRequest"/></param>
        /// <returns><see cref="CancelRegistryRecordResponse"/></returns>
        public CancelRegistryRecordResponse CancelRegistryRecordSync(CancelRegistryRecordRequest req)
        {
            return InternalRequestAsync<CancelRegistryRecordResponse>(req, "CancelRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建新的API密钥，用于调用Agent Sandbox接口。相较于腾讯云Secret ID Secret Key支持调用所有接口使用，仅有部分接口支持使用API密钥调用。
        /// </summary>
        /// <param name="req"><see cref="CreateAPIKeyRequest"/></param>
        /// <returns><see cref="CreateAPIKeyResponse"/></returns>
        public Task<CreateAPIKeyResponse> CreateAPIKey(CreateAPIKeyRequest req)
        {
            return InternalRequestAsync<CreateAPIKeyResponse>(req, "CreateAPIKey");
        }

        /// <summary>
        /// 创建新的API密钥，用于调用Agent Sandbox接口。相较于腾讯云Secret ID Secret Key支持调用所有接口使用，仅有部分接口支持使用API密钥调用。
        /// </summary>
        /// <param name="req"><see cref="CreateAPIKeyRequest"/></param>
        /// <returns><see cref="CreateAPIKeyResponse"/></returns>
        public CreateAPIKeyResponse CreateAPIKeySync(CreateAPIKeyRequest req)
        {
            return InternalRequestAsync<CreateAPIKeyResponse>(req, "CreateAPIKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Deployment
        /// </summary>
        /// <param name="req"><see cref="CreateDeploymentRequest"/></param>
        /// <returns><see cref="CreateDeploymentResponse"/></returns>
        public Task<CreateDeploymentResponse> CreateDeployment(CreateDeploymentRequest req)
        {
            return InternalRequestAsync<CreateDeploymentResponse>(req, "CreateDeployment");
        }

        /// <summary>
        /// 创建 Deployment
        /// </summary>
        /// <param name="req"><see cref="CreateDeploymentRequest"/></param>
        /// <returns><see cref="CreateDeploymentResponse"/></returns>
        public CreateDeploymentResponse CreateDeploymentSync(CreateDeploymentRequest req)
        {
            return InternalRequestAsync<CreateDeploymentResponse>(req, "CreateDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="CreatePreCacheImageTaskResponse"/></returns>
        public Task<CreatePreCacheImageTaskResponse> CreatePreCacheImageTask(CreatePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<CreatePreCacheImageTaskResponse>(req, "CreatePreCacheImageTask");
        }

        /// <summary>
        /// 创建镜像预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="CreatePreCacheImageTaskResponse"/></returns>
        public CreatePreCacheImageTaskResponse CreatePreCacheImageTaskSync(CreatePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<CreatePreCacheImageTaskResponse>(req, "CreatePreCacheImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Agent Registry（注册中心）。
        /// </summary>
        /// <param name="req"><see cref="CreateRegistryRequest"/></param>
        /// <returns><see cref="CreateRegistryResponse"/></returns>
        public Task<CreateRegistryResponse> CreateRegistry(CreateRegistryRequest req)
        {
            return InternalRequestAsync<CreateRegistryResponse>(req, "CreateRegistry");
        }

        /// <summary>
        /// 创建 Agent Registry（注册中心）。
        /// </summary>
        /// <param name="req"><see cref="CreateRegistryRequest"/></param>
        /// <returns><see cref="CreateRegistryResponse"/></returns>
        public CreateRegistryResponse CreateRegistrySync(CreateRegistryRequest req)
        {
            return InternalRequestAsync<CreateRegistryResponse>(req, "CreateRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 统一创建 Registry Record（含 revision 1）。请求通过 DescriptorType 与严格内容输入 Union 选择底层类型：MCPSource / AgentSource / SkillSource / CustomDescriptors 四选一，必须与 DescriptorType 对应。不接受 RecordId 或 ChangeLog；同名 Record 返回冲突，不隐式追加 Version。追加 Version 请使用 UpdateRegistryRecord。
        /// </summary>
        /// <param name="req"><see cref="CreateRegistryRecordRequest"/></param>
        /// <returns><see cref="CreateRegistryRecordResponse"/></returns>
        public Task<CreateRegistryRecordResponse> CreateRegistryRecord(CreateRegistryRecordRequest req)
        {
            return InternalRequestAsync<CreateRegistryRecordResponse>(req, "CreateRegistryRecord");
        }

        /// <summary>
        /// 统一创建 Registry Record（含 revision 1）。请求通过 DescriptorType 与严格内容输入 Union 选择底层类型：MCPSource / AgentSource / SkillSource / CustomDescriptors 四选一，必须与 DescriptorType 对应。不接受 RecordId 或 ChangeLog；同名 Record 返回冲突，不隐式追加 Version。追加 Version 请使用 UpdateRegistryRecord。
        /// </summary>
        /// <param name="req"><see cref="CreateRegistryRecordRequest"/></param>
        /// <returns><see cref="CreateRegistryRecordResponse"/></returns>
        public CreateRegistryRecordResponse CreateRegistryRecordSync(CreateRegistryRecordRequest req)
        {
            return InternalRequestAsync<CreateRegistryRecordResponse>(req, "CreateRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建沙箱工具
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxToolRequest"/></param>
        /// <returns><see cref="CreateSandboxToolResponse"/></returns>
        public Task<CreateSandboxToolResponse> CreateSandboxTool(CreateSandboxToolRequest req)
        {
            return InternalRequestAsync<CreateSandboxToolResponse>(req, "CreateSandboxTool");
        }

        /// <summary>
        /// 创建沙箱工具
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxToolRequest"/></param>
        /// <returns><see cref="CreateSandboxToolResponse"/></returns>
        public CreateSandboxToolResponse CreateSandboxToolSync(CreateSandboxToolRequest req)
        {
            return InternalRequestAsync<CreateSandboxToolResponse>(req, "CreateSandboxTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建会话。
        /// 
        /// 为指定 Agent 和用户创建会话，创建成功后返回会话信息。
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public Task<CreateSessionResponse> CreateSession(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession");
        }

        /// <summary>
        /// 创建会话。
        /// 
        /// 为指定 Agent 和用户创建会话，创建成功后返回会话信息。
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public CreateSessionResponse CreateSessionSync(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建会话空间。
        /// 为当前应用在指定地域创建会话空间，创建成功后返回会话空间信息。会话空间用于隔离不同业务场景下的用户、会话、事件及状态数据。
        /// </summary>
        /// <param name="req"><see cref="CreateSessionSpaceRequest"/></param>
        /// <returns><see cref="CreateSessionSpaceResponse"/></returns>
        public Task<CreateSessionSpaceResponse> CreateSessionSpace(CreateSessionSpaceRequest req)
        {
            return InternalRequestAsync<CreateSessionSpaceResponse>(req, "CreateSessionSpace");
        }

        /// <summary>
        /// 创建会话空间。
        /// 为当前应用在指定地域创建会话空间，创建成功后返回会话空间信息。会话空间用于隔离不同业务场景下的用户、会话、事件及状态数据。
        /// </summary>
        /// <param name="req"><see cref="CreateSessionSpaceRequest"/></param>
        /// <returns><see cref="CreateSessionSpaceResponse"/></returns>
        public CreateSessionSpaceResponse CreateSessionSpaceSync(CreateSessionSpaceRequest req)
        {
            return InternalRequestAsync<CreateSessionSpaceResponse>(req, "CreateSessionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除API密钥。注意区别于腾讯云Secret ID Secret Key，本接口删除的是Agent Sandbox专用API key。
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIKeyRequest"/></param>
        /// <returns><see cref="DeleteAPIKeyResponse"/></returns>
        public Task<DeleteAPIKeyResponse> DeleteAPIKey(DeleteAPIKeyRequest req)
        {
            return InternalRequestAsync<DeleteAPIKeyResponse>(req, "DeleteAPIKey");
        }

        /// <summary>
        /// 删除API密钥。注意区别于腾讯云Secret ID Secret Key，本接口删除的是Agent Sandbox专用API key。
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIKeyRequest"/></param>
        /// <returns><see cref="DeleteAPIKeyResponse"/></returns>
        public DeleteAPIKeyResponse DeleteAPIKeySync(DeleteAPIKeyRequest req)
        {
            return InternalRequestAsync<DeleteAPIKeyResponse>(req, "DeleteAPIKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Deployment
        /// </summary>
        /// <param name="req"><see cref="DeleteDeploymentRequest"/></param>
        /// <returns><see cref="DeleteDeploymentResponse"/></returns>
        public Task<DeleteDeploymentResponse> DeleteDeployment(DeleteDeploymentRequest req)
        {
            return InternalRequestAsync<DeleteDeploymentResponse>(req, "DeleteDeployment");
        }

        /// <summary>
        /// 删除 Deployment
        /// </summary>
        /// <param name="req"><see cref="DeleteDeploymentRequest"/></param>
        /// <returns><see cref="DeleteDeploymentResponse"/></returns>
        public DeleteDeploymentResponse DeleteDeploymentSync(DeleteDeploymentRequest req)
        {
            return InternalRequestAsync<DeleteDeploymentResponse>(req, "DeleteDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Registry。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegistryRequest"/></param>
        /// <returns><see cref="DeleteRegistryResponse"/></returns>
        public Task<DeleteRegistryResponse> DeleteRegistry(DeleteRegistryRequest req)
        {
            return InternalRequestAsync<DeleteRegistryResponse>(req, "DeleteRegistry");
        }

        /// <summary>
        /// 删除 Registry。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegistryRequest"/></param>
        /// <returns><see cref="DeleteRegistryResponse"/></returns>
        public DeleteRegistryResponse DeleteRegistrySync(DeleteRegistryRequest req)
        {
            return InternalRequestAsync<DeleteRegistryResponse>(req, "DeleteRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Registry Record 或指定 Version。省略 VersionId 时对整个 Record 进行软删除；传入 VersionId 时只删除指定 Version（Stable 指向的 Version 不允许删除；仅剩一个 Approved Version 时不允许删除）。取代原 DeleteRegistryRecordVersion。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegistryRecordRequest"/></param>
        /// <returns><see cref="DeleteRegistryRecordResponse"/></returns>
        public Task<DeleteRegistryRecordResponse> DeleteRegistryRecord(DeleteRegistryRecordRequest req)
        {
            return InternalRequestAsync<DeleteRegistryRecordResponse>(req, "DeleteRegistryRecord");
        }

        /// <summary>
        /// 删除 Registry Record 或指定 Version。省略 VersionId 时对整个 Record 进行软删除；传入 VersionId 时只删除指定 Version（Stable 指向的 Version 不允许删除；仅剩一个 Approved Version 时不允许删除）。取代原 DeleteRegistryRecordVersion。
        /// </summary>
        /// <param name="req"><see cref="DeleteRegistryRecordRequest"/></param>
        /// <returns><see cref="DeleteRegistryRecordResponse"/></returns>
        public DeleteRegistryRecordResponse DeleteRegistryRecordSync(DeleteRegistryRecordRequest req)
        {
            return InternalRequestAsync<DeleteRegistryRecordResponse>(req, "DeleteRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除沙箱工具
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxToolRequest"/></param>
        /// <returns><see cref="DeleteSandboxToolResponse"/></returns>
        public Task<DeleteSandboxToolResponse> DeleteSandboxTool(DeleteSandboxToolRequest req)
        {
            return InternalRequestAsync<DeleteSandboxToolResponse>(req, "DeleteSandboxTool");
        }

        /// <summary>
        /// 删除沙箱工具
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxToolRequest"/></param>
        /// <returns><see cref="DeleteSandboxToolResponse"/></returns>
        public DeleteSandboxToolResponse DeleteSandboxToolSync(DeleteSandboxToolRequest req)
        {
            return InternalRequestAsync<DeleteSandboxToolResponse>(req, "DeleteSandboxTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public Task<DeleteSessionResponse> DeleteSession(DeleteSessionRequest req)
        {
            return InternalRequestAsync<DeleteSessionResponse>(req, "DeleteSession");
        }

        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public DeleteSessionResponse DeleteSessionSync(DeleteSessionRequest req)
        {
            return InternalRequestAsync<DeleteSessionResponse>(req, "DeleteSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除会话空间。
        /// 删除指定的会话空间。仅允许删除不包含会话、事件或用户状态数据的非默认会话空间；系统默认会话空间不能删除。删除成功后不再返回会话空间信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionSpaceRequest"/></param>
        /// <returns><see cref="DeleteSessionSpaceResponse"/></returns>
        public Task<DeleteSessionSpaceResponse> DeleteSessionSpace(DeleteSessionSpaceRequest req)
        {
            return InternalRequestAsync<DeleteSessionSpaceResponse>(req, "DeleteSessionSpace");
        }

        /// <summary>
        /// 删除会话空间。
        /// 删除指定的会话空间。仅允许删除不包含会话、事件或用户状态数据的非默认会话空间；系统默认会话空间不能删除。删除成功后不再返回会话空间信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionSpaceRequest"/></param>
        /// <returns><see cref="DeleteSessionSpaceResponse"/></returns>
        public DeleteSessionSpaceResponse DeleteSessionSpaceSync(DeleteSessionSpaceRequest req)
        {
            return InternalRequestAsync<DeleteSessionSpaceResponse>(req, "DeleteSessionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取API密钥列表，包含API密钥简略信息，包含名称、创建时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIKeyListRequest"/></param>
        /// <returns><see cref="DescribeAPIKeyListResponse"/></returns>
        public Task<DescribeAPIKeyListResponse> DescribeAPIKeyList(DescribeAPIKeyListRequest req)
        {
            return InternalRequestAsync<DescribeAPIKeyListResponse>(req, "DescribeAPIKeyList");
        }

        /// <summary>
        /// 获取API密钥列表，包含API密钥简略信息，包含名称、创建时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIKeyListRequest"/></param>
        /// <returns><see cref="DescribeAPIKeyListResponse"/></returns>
        public DescribeAPIKeyListResponse DescribeAPIKeyListSync(DescribeAPIKeyListRequest req)
        {
            return InternalRequestAsync<DescribeAPIKeyListResponse>(req, "DescribeAPIKeyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Deployment 信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentRequest"/></param>
        /// <returns><see cref="DescribeDeploymentResponse"/></returns>
        public Task<DescribeDeploymentResponse> DescribeDeployment(DescribeDeploymentRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentResponse>(req, "DescribeDeployment");
        }

        /// <summary>
        /// 查询 Deployment 信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentRequest"/></param>
        /// <returns><see cref="DescribeDeploymentResponse"/></returns>
        public DescribeDeploymentResponse DescribeDeploymentSync(DescribeDeploymentRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentResponse>(req, "DescribeDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Deployment 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentListRequest"/></param>
        /// <returns><see cref="DescribeDeploymentListResponse"/></returns>
        public Task<DescribeDeploymentListResponse> DescribeDeploymentList(DescribeDeploymentListRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentListResponse>(req, "DescribeDeploymentList");
        }

        /// <summary>
        /// 查询 Deployment 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentListRequest"/></param>
        /// <returns><see cref="DescribeDeploymentListResponse"/></returns>
        public DescribeDeploymentListResponse DescribeDeploymentListSync(DescribeDeploymentListRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentListResponse>(req, "DescribeDeploymentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询事件列表。
        /// 
        /// 查询指定会话的事件流，支持按作者和起始时间筛选。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents");
        }

        /// <summary>
        /// 查询事件列表。
        /// 
        /// 查询指定会话的事件流，支持按作者和起始时间筛选。
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像预热任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="DescribePreCacheImageTaskResponse"/></returns>
        public Task<DescribePreCacheImageTaskResponse> DescribePreCacheImageTask(DescribePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<DescribePreCacheImageTaskResponse>(req, "DescribePreCacheImageTask");
        }

        /// <summary>
        /// 查询镜像预热任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="DescribePreCacheImageTaskResponse"/></returns>
        public DescribePreCacheImageTaskResponse DescribePreCacheImageTaskSync(DescribePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<DescribePreCacheImageTaskResponse>(req, "DescribePreCacheImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前调用账号的资源配额和当前总用量，以及账号下各配额组的资源配额和当前用量
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaOverviewRequest"/></param>
        /// <returns><see cref="DescribeQuotaOverviewResponse"/></returns>
        public Task<DescribeQuotaOverviewResponse> DescribeQuotaOverview(DescribeQuotaOverviewRequest req)
        {
            return InternalRequestAsync<DescribeQuotaOverviewResponse>(req, "DescribeQuotaOverview");
        }

        /// <summary>
        /// 查询当前调用账号的资源配额和当前总用量，以及账号下各配额组的资源配额和当前用量
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaOverviewRequest"/></param>
        /// <returns><see cref="DescribeQuotaOverviewResponse"/></returns>
        public DescribeQuotaOverviewResponse DescribeQuotaOverviewSync(DescribeQuotaOverviewRequest req)
        {
            return InternalRequestAsync<DescribeQuotaOverviewResponse>(req, "DescribeQuotaOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按 RegistryId 查询 Registry 详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRequest"/></param>
        /// <returns><see cref="DescribeRegistryResponse"/></returns>
        public Task<DescribeRegistryResponse> DescribeRegistry(DescribeRegistryRequest req)
        {
            return InternalRequestAsync<DescribeRegistryResponse>(req, "DescribeRegistry");
        }

        /// <summary>
        /// 按 RegistryId 查询 Registry 详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRequest"/></param>
        /// <returns><see cref="DescribeRegistryResponse"/></returns>
        public DescribeRegistryResponse DescribeRegistrySync(DescribeRegistryRequest req)
        {
            return InternalRequestAsync<DescribeRegistryResponse>(req, "DescribeRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询指定Registry / Record / Version的审计日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryAuditLogListRequest"/></param>
        /// <returns><see cref="DescribeRegistryAuditLogListResponse"/></returns>
        public Task<DescribeRegistryAuditLogListResponse> DescribeRegistryAuditLogList(DescribeRegistryAuditLogListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryAuditLogListResponse>(req, "DescribeRegistryAuditLogList");
        }

        /// <summary>
        /// 分页查询指定Registry / Record / Version的审计日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryAuditLogListRequest"/></param>
        /// <returns><see cref="DescribeRegistryAuditLogListResponse"/></returns>
        public DescribeRegistryAuditLogListResponse DescribeRegistryAuditLogListSync(DescribeRegistryAuditLogListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryAuditLogListResponse>(req, "DescribeRegistryAuditLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询当前租户可见的 Registry 列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryListRequest"/></param>
        /// <returns><see cref="DescribeRegistryListResponse"/></returns>
        public Task<DescribeRegistryListResponse> DescribeRegistryList(DescribeRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryListResponse>(req, "DescribeRegistryList");
        }

        /// <summary>
        /// 分页查询当前租户可见的 Registry 列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryListRequest"/></param>
        /// <returns><see cref="DescribeRegistryListResponse"/></returns>
        public DescribeRegistryListResponse DescribeRegistryListSync(DescribeRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryListResponse>(req, "DescribeRegistryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Record 详情和其中一个 Version。请求可通过互斥的 VersionId 或 Label 选择 Version；均省略时默认 Label=stable。取代原 DescribeRegistryRecordVersion。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRecordRequest"/></param>
        /// <returns><see cref="DescribeRegistryRecordResponse"/></returns>
        public Task<DescribeRegistryRecordResponse> DescribeRegistryRecord(DescribeRegistryRecordRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRecordResponse>(req, "DescribeRegistryRecord");
        }

        /// <summary>
        /// 查询 Record 详情和其中一个 Version。请求可通过互斥的 VersionId 或 Label 选择 Version；均省略时默认 Label=stable。取代原 DescribeRegistryRecordVersion。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRecordRequest"/></param>
        /// <returns><see cref="DescribeRegistryRecordResponse"/></returns>
        public DescribeRegistryRecordResponse DescribeRegistryRecordSync(DescribeRegistryRecordRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRecordResponse>(req, "DescribeRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询 Registry 下的 Record 列表。list 类接口不接入 CAM 转发鉴权；业务侧按 CAM 二次过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRecordListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRecordListResponse"/></returns>
        public Task<DescribeRegistryRecordListResponse> DescribeRegistryRecordList(DescribeRegistryRecordListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRecordListResponse>(req, "DescribeRegistryRecordList");
        }

        /// <summary>
        /// 分页查询 Registry 下的 Record 列表。list 类接口不接入 CAM 转发鉴权；业务侧按 CAM 二次过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRecordListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRecordListResponse"/></returns>
        public DescribeRegistryRecordListResponse DescribeRegistryRecordListSync(DescribeRegistryRecordListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRecordListResponse>(req, "DescribeRegistryRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询 Record 的 Version 列表。list 类接口不接入 CAM 转发鉴权。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRecordVersionListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRecordVersionListResponse"/></returns>
        public Task<DescribeRegistryRecordVersionListResponse> DescribeRegistryRecordVersionList(DescribeRegistryRecordVersionListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRecordVersionListResponse>(req, "DescribeRegistryRecordVersionList");
        }

        /// <summary>
        /// 分页查询 Record 的 Version 列表。list 类接口不接入 CAM 转发鉴权。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRecordVersionListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRecordVersionListResponse"/></returns>
        public DescribeRegistryRecordVersionListResponse DescribeRegistryRecordVersionListSync(DescribeRegistryRecordVersionListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRecordVersionListResponse>(req, "DescribeRegistryRecordVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询沙箱实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSandboxInstanceListResponse"/></returns>
        public Task<DescribeSandboxInstanceListResponse> DescribeSandboxInstanceList(DescribeSandboxInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxInstanceListResponse>(req, "DescribeSandboxInstanceList");
        }

        /// <summary>
        /// 查询沙箱实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSandboxInstanceListResponse"/></returns>
        public DescribeSandboxInstanceListResponse DescribeSandboxInstanceListSync(DescribeSandboxInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxInstanceListResponse>(req, "DescribeSandboxInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询沙箱工具列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxToolListRequest"/></param>
        /// <returns><see cref="DescribeSandboxToolListResponse"/></returns>
        public Task<DescribeSandboxToolListResponse> DescribeSandboxToolList(DescribeSandboxToolListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxToolListResponse>(req, "DescribeSandboxToolList");
        }

        /// <summary>
        /// 查询沙箱工具列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxToolListRequest"/></param>
        /// <returns><see cref="DescribeSandboxToolListResponse"/></returns>
        public DescribeSandboxToolListResponse DescribeSandboxToolListSync(DescribeSandboxToolListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxToolListResponse>(req, "DescribeSandboxToolList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询会话。
        /// 
        /// 查询指定会话的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public Task<DescribeSessionResponse> DescribeSession(DescribeSessionRequest req)
        {
            return InternalRequestAsync<DescribeSessionResponse>(req, "DescribeSession");
        }

        /// <summary>
        /// 查询会话。
        /// 
        /// 查询指定会话的信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionRequest"/></param>
        /// <returns><see cref="DescribeSessionResponse"/></returns>
        public DescribeSessionResponse DescribeSessionSync(DescribeSessionRequest req)
        {
            return InternalRequestAsync<DescribeSessionResponse>(req, "DescribeSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询会话空间详情。
        /// 查询指定会话空间的详细信息，查询成功后返回会话空间的名称、描述、状态、所属地域及创建时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionSpaceRequest"/></param>
        /// <returns><see cref="DescribeSessionSpaceResponse"/></returns>
        public Task<DescribeSessionSpaceResponse> DescribeSessionSpace(DescribeSessionSpaceRequest req)
        {
            return InternalRequestAsync<DescribeSessionSpaceResponse>(req, "DescribeSessionSpace");
        }

        /// <summary>
        /// 查询会话空间详情。
        /// 查询指定会话空间的详细信息，查询成功后返回会话空间的名称、描述、状态、所属地域及创建时间等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionSpaceRequest"/></param>
        /// <returns><see cref="DescribeSessionSpaceResponse"/></returns>
        public DescribeSessionSpaceResponse DescribeSessionSpaceSync(DescribeSessionSpaceRequest req)
        {
            return InternalRequestAsync<DescribeSessionSpaceResponse>(req, "DescribeSessionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询当前应用和地域下的会话空间。
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionSpacesRequest"/></param>
        /// <returns><see cref="DescribeSessionSpacesResponse"/></returns>
        public Task<DescribeSessionSpacesResponse> DescribeSessionSpaces(DescribeSessionSpacesRequest req)
        {
            return InternalRequestAsync<DescribeSessionSpacesResponse>(req, "DescribeSessionSpaces");
        }

        /// <summary>
        /// 分页查询当前应用和地域下的会话空间。
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionSpacesRequest"/></param>
        /// <returns><see cref="DescribeSessionSpacesResponse"/></returns>
        public DescribeSessionSpacesResponse DescribeSessionSpacesSync(DescribeSessionSpacesRequest req)
        {
            return InternalRequestAsync<DescribeSessionSpacesResponse>(req, "DescribeSessionSpaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionsRequest"/></param>
        /// <returns><see cref="DescribeSessionsResponse"/></returns>
        public Task<DescribeSessionsResponse> DescribeSessions(DescribeSessionsRequest req)
        {
            return InternalRequestAsync<DescribeSessionsResponse>(req, "DescribeSessions");
        }

        /// <summary>
        /// 查询会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionsRequest"/></param>
        /// <returns><see cref="DescribeSessionsResponse"/></returns>
        public DescribeSessionsResponse DescribeSessionsSync(DescribeSessionsRequest req)
        {
            return InternalRequestAsync<DescribeSessionsResponse>(req, "DescribeSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 Skill 包下载 URL。VersionId 与 Label 互斥；均省略时使用 Stable。响应包含 ResolvedVersionId，便于调用方回填。
        /// </summary>
        /// <param name="req"><see cref="GetSkillPackageDownloadURLRequest"/></param>
        /// <returns><see cref="GetSkillPackageDownloadURLResponse"/></returns>
        public Task<GetSkillPackageDownloadURLResponse> GetSkillPackageDownloadURL(GetSkillPackageDownloadURLRequest req)
        {
            return InternalRequestAsync<GetSkillPackageDownloadURLResponse>(req, "GetSkillPackageDownloadURL");
        }

        /// <summary>
        /// 获取 Skill 包下载 URL。VersionId 与 Label 互斥；均省略时使用 Stable。响应包含 ResolvedVersionId，便于调用方回填。
        /// </summary>
        /// <param name="req"><see cref="GetSkillPackageDownloadURLRequest"/></param>
        /// <returns><see cref="GetSkillPackageDownloadURLResponse"/></returns>
        public GetSkillPackageDownloadURLResponse GetSkillPackageDownloadURLSync(GetSkillPackageDownloadURLRequest req)
        {
            return InternalRequestAsync<GetSkillPackageDownloadURLResponse>(req, "GetSkillPackageDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为 FAILED / EXPIRED 的 TAR Skill Version 生成新的上传尝试；VersionId 与 Revision 保持不变。
        /// </summary>
        /// <param name="req"><see cref="GetSkillPackageUploadURLRequest"/></param>
        /// <returns><see cref="GetSkillPackageUploadURLResponse"/></returns>
        public Task<GetSkillPackageUploadURLResponse> GetSkillPackageUploadURL(GetSkillPackageUploadURLRequest req)
        {
            return InternalRequestAsync<GetSkillPackageUploadURLResponse>(req, "GetSkillPackageUploadURL");
        }

        /// <summary>
        /// 为 FAILED / EXPIRED 的 TAR Skill Version 生成新的上传尝试；VersionId 与 Revision 保持不变。
        /// </summary>
        /// <param name="req"><see cref="GetSkillPackageUploadURLRequest"/></param>
        /// <returns><see cref="GetSkillPackageUploadURLResponse"/></returns>
        public GetSkillPackageUploadURLResponse GetSkillPackageUploadURLSync(GetSkillPackageUploadURLRequest req)
        {
            return InternalRequestAsync<GetSkillPackageUploadURLResponse>(req, "GetSkillPackageUploadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 Deployment
        /// </summary>
        /// <param name="req"><see cref="ModifyDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDeploymentResponse"/></returns>
        public Task<ModifyDeploymentResponse> ModifyDeployment(ModifyDeploymentRequest req)
        {
            return InternalRequestAsync<ModifyDeploymentResponse>(req, "ModifyDeployment");
        }

        /// <summary>
        /// 修改 Deployment
        /// </summary>
        /// <param name="req"><see cref="ModifyDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDeploymentResponse"/></returns>
        public ModifyDeploymentResponse ModifyDeploymentSync(ModifyDeploymentRequest req)
        {
            return InternalRequestAsync<ModifyDeploymentResponse>(req, "ModifyDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改会话信息
        /// </summary>
        /// <param name="req"><see cref="ModifySessionRequest"/></param>
        /// <returns><see cref="ModifySessionResponse"/></returns>
        public Task<ModifySessionResponse> ModifySession(ModifySessionRequest req)
        {
            return InternalRequestAsync<ModifySessionResponse>(req, "ModifySession");
        }

        /// <summary>
        /// 修改会话信息
        /// </summary>
        /// <param name="req"><see cref="ModifySessionRequest"/></param>
        /// <returns><see cref="ModifySessionResponse"/></returns>
        public ModifySessionResponse ModifySessionSync(ModifySessionRequest req)
        {
            return InternalRequestAsync<ModifySessionResponse>(req, "ModifySession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改会话空间。
        /// 修改指定会话空间的名称和描述，修改成功后返回更新后的会话空间信息。默认会话空间允许修改名称和描述。
        /// </summary>
        /// <param name="req"><see cref="ModifySessionSpaceRequest"/></param>
        /// <returns><see cref="ModifySessionSpaceResponse"/></returns>
        public Task<ModifySessionSpaceResponse> ModifySessionSpace(ModifySessionSpaceRequest req)
        {
            return InternalRequestAsync<ModifySessionSpaceResponse>(req, "ModifySessionSpace");
        }

        /// <summary>
        /// 修改会话空间。
        /// 修改指定会话空间的名称和描述，修改成功后返回更新后的会话空间信息。默认会话空间允许修改名称和描述。
        /// </summary>
        /// <param name="req"><see cref="ModifySessionSpaceRequest"/></param>
        /// <returns><see cref="ModifySessionSpaceResponse"/></returns>
        public ModifySessionSpaceResponse ModifySessionSpaceSync(ModifySessionSpaceRequest req)
        {
            return InternalRequestAsync<ModifySessionSpaceResponse>(req, "ModifySessionSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停沙箱实例
        /// </summary>
        /// <param name="req"><see cref="PauseSandboxInstanceRequest"/></param>
        /// <returns><see cref="PauseSandboxInstanceResponse"/></returns>
        public Task<PauseSandboxInstanceResponse> PauseSandboxInstance(PauseSandboxInstanceRequest req)
        {
            return InternalRequestAsync<PauseSandboxInstanceResponse>(req, "PauseSandboxInstance");
        }

        /// <summary>
        /// 暂停沙箱实例
        /// </summary>
        /// <param name="req"><see cref="PauseSandboxInstanceRequest"/></param>
        /// <returns><see cref="PauseSandboxInstanceResponse"/></returns>
        public PauseSandboxInstanceResponse PauseSandboxInstanceSync(PauseSandboxInstanceRequest req)
        {
            return InternalRequestAsync<PauseSandboxInstanceResponse>(req, "PauseSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对 Record 的指定 Version 或 Label 目标发起一次预览调用。VersionId 与 Label 互斥；均省略时使用 Stable。不创建 Version、不修改 Label。
        /// </summary>
        /// <param name="req"><see cref="PreviewRegistryRecordRequest"/></param>
        /// <returns><see cref="PreviewRegistryRecordResponse"/></returns>
        public Task<PreviewRegistryRecordResponse> PreviewRegistryRecord(PreviewRegistryRecordRequest req)
        {
            return InternalRequestAsync<PreviewRegistryRecordResponse>(req, "PreviewRegistryRecord");
        }

        /// <summary>
        /// 对 Record 的指定 Version 或 Label 目标发起一次预览调用。VersionId 与 Label 互斥；均省略时使用 Stable。不创建 Version、不修改 Label。
        /// </summary>
        /// <param name="req"><see cref="PreviewRegistryRecordRequest"/></param>
        /// <returns><see cref="PreviewRegistryRecordResponse"/></returns>
        public PreviewRegistryRecordResponse PreviewRegistryRecordSync(PreviewRegistryRecordRequest req)
        {
            return InternalRequestAsync<PreviewRegistryRecordResponse>(req, "PreviewRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 驳回 Version 审批：PENDING_APPROVAL → REJECTED。Comment 必填。
        /// </summary>
        /// <param name="req"><see cref="RejectRegistryRecordRequest"/></param>
        /// <returns><see cref="RejectRegistryRecordResponse"/></returns>
        public Task<RejectRegistryRecordResponse> RejectRegistryRecord(RejectRegistryRecordRequest req)
        {
            return InternalRequestAsync<RejectRegistryRecordResponse>(req, "RejectRegistryRecord");
        }

        /// <summary>
        /// 驳回 Version 审批：PENDING_APPROVAL → REJECTED。Comment 必填。
        /// </summary>
        /// <param name="req"><see cref="RejectRegistryRecordRequest"/></param>
        /// <returns><see cref="RejectRegistryRecordResponse"/></returns>
        public RejectRegistryRecordResponse RejectRegistryRecordSync(RejectRegistryRecordRequest req)
        {
            return InternalRequestAsync<RejectRegistryRecordResponse>(req, "RejectRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复沙箱实例
        /// </summary>
        /// <param name="req"><see cref="ResumeSandboxInstanceRequest"/></param>
        /// <returns><see cref="ResumeSandboxInstanceResponse"/></returns>
        public Task<ResumeSandboxInstanceResponse> ResumeSandboxInstance(ResumeSandboxInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSandboxInstanceResponse>(req, "ResumeSandboxInstance");
        }

        /// <summary>
        /// 恢复沙箱实例
        /// </summary>
        /// <param name="req"><see cref="ResumeSandboxInstanceRequest"/></param>
        /// <returns><see cref="ResumeSandboxInstanceResponse"/></returns>
        public ResumeSandboxInstanceResponse ResumeSandboxInstanceSync(ResumeSandboxInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSandboxInstanceResponse>(req, "ResumeSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StartSandboxInstanceRequest"/></param>
        /// <returns><see cref="StartSandboxInstanceResponse"/></returns>
        public Task<StartSandboxInstanceResponse> StartSandboxInstance(StartSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StartSandboxInstanceResponse>(req, "StartSandboxInstance");
        }

        /// <summary>
        /// 启动沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StartSandboxInstanceRequest"/></param>
        /// <returns><see cref="StartSandboxInstanceResponse"/></returns>
        public StartSandboxInstanceResponse StartSandboxInstanceSync(StartSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StartSandboxInstanceResponse>(req, "StartSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StopSandboxInstanceRequest"/></param>
        /// <returns><see cref="StopSandboxInstanceResponse"/></returns>
        public Task<StopSandboxInstanceResponse> StopSandboxInstance(StopSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StopSandboxInstanceResponse>(req, "StopSandboxInstance");
        }

        /// <summary>
        /// 停止沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StopSandboxInstanceRequest"/></param>
        /// <returns><see cref="StopSandboxInstanceResponse"/></returns>
        public StopSandboxInstanceResponse StopSandboxInstanceSync(StopSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StopSandboxInstanceResponse>(req, "StopSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 触发一次从远端拉取描述符 / 元数据的同步。可通过互斥的 VersionId 或 Label 指定来源 Version，均省略时默认使用 Stable。有变化时创建新 Version 并移动 Latest；来源必须 SourceType=URL_IMPORT，否则返回 UnsupportedOperation.SourceType。
        /// </summary>
        /// <param name="req"><see cref="SyncRegistryRecordRequest"/></param>
        /// <returns><see cref="SyncRegistryRecordResponse"/></returns>
        public Task<SyncRegistryRecordResponse> SyncRegistryRecord(SyncRegistryRecordRequest req)
        {
            return InternalRequestAsync<SyncRegistryRecordResponse>(req, "SyncRegistryRecord");
        }

        /// <summary>
        /// 触发一次从远端拉取描述符 / 元数据的同步。可通过互斥的 VersionId 或 Label 指定来源 Version，均省略时默认使用 Stable。有变化时创建新 Version 并移动 Latest；来源必须 SourceType=URL_IMPORT，否则返回 UnsupportedOperation.SourceType。
        /// </summary>
        /// <param name="req"><see cref="SyncRegistryRecordRequest"/></param>
        /// <returns><see cref="SyncRegistryRecordResponse"/></returns>
        public SyncRegistryRecordResponse SyncRegistryRecordSync(SyncRegistryRecordRequest req)
        {
            return InternalRequestAsync<SyncRegistryRecordResponse>(req, "SyncRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Registry 的可变元数据。
        /// </summary>
        /// <param name="req"><see cref="UpdateRegistryRequest"/></param>
        /// <returns><see cref="UpdateRegistryResponse"/></returns>
        public Task<UpdateRegistryResponse> UpdateRegistry(UpdateRegistryRequest req)
        {
            return InternalRequestAsync<UpdateRegistryResponse>(req, "UpdateRegistry");
        }

        /// <summary>
        /// 更新 Registry 的可变元数据。
        /// </summary>
        /// <param name="req"><see cref="UpdateRegistryRequest"/></param>
        /// <returns><see cref="UpdateRegistryResponse"/></returns>
        public UpdateRegistryResponse UpdateRegistrySync(UpdateRegistryRequest req)
        {
            return InternalRequestAsync<UpdateRegistryResponse>(req, "UpdateRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Registry Record。两种互斥模式：①Record 更新模式：不提交任何 Source / CustomDescriptors，可通过 Description、LabelMutations 修改元数据与 Label（至少提交一项）；②Version 创建模式：提交且仅提交一种与现有 DescriptorType 匹配的内容输入，可选 VersionName / ChangeLog，禁止 Description / LabelMutations，服务端在 Record 下创建下一个 Revision。取代原 ChangeRegistryRecordStableVersion / RollbackRegistryRecordVersion / Create*RegistryRecordVersion。
        /// </summary>
        /// <param name="req"><see cref="UpdateRegistryRecordRequest"/></param>
        /// <returns><see cref="UpdateRegistryRecordResponse"/></returns>
        public Task<UpdateRegistryRecordResponse> UpdateRegistryRecord(UpdateRegistryRecordRequest req)
        {
            return InternalRequestAsync<UpdateRegistryRecordResponse>(req, "UpdateRegistryRecord");
        }

        /// <summary>
        /// 更新 Registry Record。两种互斥模式：①Record 更新模式：不提交任何 Source / CustomDescriptors，可通过 Description、LabelMutations 修改元数据与 Label（至少提交一项）；②Version 创建模式：提交且仅提交一种与现有 DescriptorType 匹配的内容输入，可选 VersionName / ChangeLog，禁止 Description / LabelMutations，服务端在 Record 下创建下一个 Revision。取代原 ChangeRegistryRecordStableVersion / RollbackRegistryRecordVersion / Create*RegistryRecordVersion。
        /// </summary>
        /// <param name="req"><see cref="UpdateRegistryRecordRequest"/></param>
        /// <returns><see cref="UpdateRegistryRecordResponse"/></returns>
        public UpdateRegistryRecordResponse UpdateRegistryRecordSync(UpdateRegistryRecordRequest req)
        {
            return InternalRequestAsync<UpdateRegistryRecordResponse>(req, "UpdateRegistryRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新沙箱实例
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxInstanceRequest"/></param>
        /// <returns><see cref="UpdateSandboxInstanceResponse"/></returns>
        public Task<UpdateSandboxInstanceResponse> UpdateSandboxInstance(UpdateSandboxInstanceRequest req)
        {
            return InternalRequestAsync<UpdateSandboxInstanceResponse>(req, "UpdateSandboxInstance");
        }

        /// <summary>
        /// 更新沙箱实例
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxInstanceRequest"/></param>
        /// <returns><see cref="UpdateSandboxInstanceResponse"/></returns>
        public UpdateSandboxInstanceResponse UpdateSandboxInstanceSync(UpdateSandboxInstanceRequest req)
        {
            return InternalRequestAsync<UpdateSandboxInstanceResponse>(req, "UpdateSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新沙箱工具
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxToolRequest"/></param>
        /// <returns><see cref="UpdateSandboxToolResponse"/></returns>
        public Task<UpdateSandboxToolResponse> UpdateSandboxTool(UpdateSandboxToolRequest req)
        {
            return InternalRequestAsync<UpdateSandboxToolResponse>(req, "UpdateSandboxTool");
        }

        /// <summary>
        /// 更新沙箱工具
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxToolRequest"/></param>
        /// <returns><see cref="UpdateSandboxToolResponse"/></returns>
        public UpdateSandboxToolResponse UpdateSandboxToolSync(UpdateSandboxToolRequest req)
        {
            return InternalRequestAsync<UpdateSandboxToolResponse>(req, "UpdateSandboxTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
