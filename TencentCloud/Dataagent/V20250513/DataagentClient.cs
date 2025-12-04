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

namespace TencentCloud.Dataagent.V20250513
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dataagent.V20250513.Models;

   public class DataagentClient : AbstractClient{

       private const string endpoint = "dataagent.tencentcloudapi.com";
       private const string version = "2025-05-13";
       private const string sdkVersion = "SDK_NET_3.0.1355";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DataagentClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DataagentClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 文档切片新增
        /// </summary>
        /// <param name="req"><see cref="AddChunkRequest"/></param>
        /// <returns><see cref="AddChunkResponse"/></returns>
        public Task<AddChunkResponse> AddChunk(AddChunkRequest req)
        {
            return InternalRequestAsync<AddChunkResponse>(req, "AddChunk");
        }

        /// <summary>
        /// 文档切片新增
        /// </summary>
        /// <param name="req"><see cref="AddChunkRequest"/></param>
        /// <returns><see cref="AddChunkResponse"/></returns>
        public AddChunkResponse AddChunkSync(AddChunkRequest req)
        {
            return InternalRequestAsync<AddChunkResponse>(req, "AddChunk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供DataAgent 产品服务API
        /// </summary>
        /// <param name="req"><see cref="ChatAIRequest"/></param>
        /// <returns><see cref="ChatAIResponse"/></returns>
        public Task<ChatAIResponse> ChatAI(ChatAIRequest req)
        {
            return InternalRequestAsync<ChatAIResponse>(req, "ChatAI");
        }

        /// <summary>
        /// 提供DataAgent 产品服务API
        /// </summary>
        /// <param name="req"><see cref="ChatAIRequest"/></param>
        /// <returns><see cref="ChatAIResponse"/></returns>
        public ChatAIResponse ChatAISync(ChatAIRequest req)
        {
            return InternalRequestAsync<ChatAIResponse>(req, "ChatAI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成DataAgent 会话ID
        /// </summary>
        /// <param name="req"><see cref="CreateDataAgentSessionRequest"/></param>
        /// <returns><see cref="CreateDataAgentSessionResponse"/></returns>
        public Task<CreateDataAgentSessionResponse> CreateDataAgentSession(CreateDataAgentSessionRequest req)
        {
            return InternalRequestAsync<CreateDataAgentSessionResponse>(req, "CreateDataAgentSession");
        }

        /// <summary>
        /// 生成DataAgent 会话ID
        /// </summary>
        /// <param name="req"><see cref="CreateDataAgentSessionRequest"/></param>
        /// <returns><see cref="CreateDataAgentSessionResponse"/></returns>
        public CreateDataAgentSessionResponse CreateDataAgentSessionSync(CreateDataAgentSessionRequest req)
        {
            return InternalRequestAsync<CreateDataAgentSessionResponse>(req, "CreateDataAgentSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档切片删除
        /// </summary>
        /// <param name="req"><see cref="DeleteChunkRequest"/></param>
        /// <returns><see cref="DeleteChunkResponse"/></returns>
        public Task<DeleteChunkResponse> DeleteChunk(DeleteChunkRequest req)
        {
            return InternalRequestAsync<DeleteChunkResponse>(req, "DeleteChunk");
        }

        /// <summary>
        /// 文档切片删除
        /// </summary>
        /// <param name="req"><see cref="DeleteChunkRequest"/></param>
        /// <returns><see cref="DeleteChunkResponse"/></returns>
        public DeleteChunkResponse DeleteChunkSync(DeleteChunkRequest req)
        {
            return InternalRequestAsync<DeleteChunkResponse>(req, "DeleteChunk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="req"><see cref="DeleteDataAgentSessionRequest"/></param>
        /// <returns><see cref="DeleteDataAgentSessionResponse"/></returns>
        public Task<DeleteDataAgentSessionResponse> DeleteDataAgentSession(DeleteDataAgentSessionRequest req)
        {
            return InternalRequestAsync<DeleteDataAgentSessionResponse>(req, "DeleteDataAgentSession");
        }

        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="req"><see cref="DeleteDataAgentSessionRequest"/></param>
        /// <returns><see cref="DeleteDataAgentSessionResponse"/></returns>
        public DeleteDataAgentSessionResponse DeleteDataAgentSessionSync(DeleteDataAgentSessionRequest req)
        {
            return InternalRequestAsync<DeleteDataAgentSessionResponse>(req, "DeleteDataAgentSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取知识库列表
        /// </summary>
        /// <param name="req"><see cref="GetKnowledgeBaseListRequest"/></param>
        /// <returns><see cref="GetKnowledgeBaseListResponse"/></returns>
        public Task<GetKnowledgeBaseListResponse> GetKnowledgeBaseList(GetKnowledgeBaseListRequest req)
        {
            return InternalRequestAsync<GetKnowledgeBaseListResponse>(req, "GetKnowledgeBaseList");
        }

        /// <summary>
        /// 获取知识库列表
        /// </summary>
        /// <param name="req"><see cref="GetKnowledgeBaseListRequest"/></param>
        /// <returns><see cref="GetKnowledgeBaseListResponse"/></returns>
        public GetKnowledgeBaseListResponse GetKnowledgeBaseListSync(GetKnowledgeBaseListRequest req)
        {
            return InternalRequestAsync<GetKnowledgeBaseListResponse>(req, "GetKnowledgeBaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户会话记录详情列表
        /// </summary>
        /// <param name="req"><see cref="GetSessionDetailsRequest"/></param>
        /// <returns><see cref="GetSessionDetailsResponse"/></returns>
        public Task<GetSessionDetailsResponse> GetSessionDetails(GetSessionDetailsRequest req)
        {
            return InternalRequestAsync<GetSessionDetailsResponse>(req, "GetSessionDetails");
        }

        /// <summary>
        /// 获取用户会话记录详情列表
        /// </summary>
        /// <param name="req"><see cref="GetSessionDetailsRequest"/></param>
        /// <returns><see cref="GetSessionDetailsResponse"/></returns>
        public GetSessionDetailsResponse GetSessionDetailsSync(GetSessionDetailsRequest req)
        {
            return InternalRequestAsync<GetSessionDetailsResponse>(req, "GetSessionDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询上传任务
        /// </summary>
        /// <param name="req"><see cref="GetUploadJobDetailsRequest"/></param>
        /// <returns><see cref="GetUploadJobDetailsResponse"/></returns>
        public Task<GetUploadJobDetailsResponse> GetUploadJobDetails(GetUploadJobDetailsRequest req)
        {
            return InternalRequestAsync<GetUploadJobDetailsResponse>(req, "GetUploadJobDetails");
        }

        /// <summary>
        /// 查询上传任务
        /// </summary>
        /// <param name="req"><see cref="GetUploadJobDetailsRequest"/></param>
        /// <returns><see cref="GetUploadJobDetailsResponse"/></returns>
        public GetUploadJobDetailsResponse GetUploadJobDetailsSync(GetUploadJobDetailsRequest req)
        {
            return InternalRequestAsync<GetUploadJobDetailsResponse>(req, "GetUploadJobDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑修改分片
        /// </summary>
        /// <param name="req"><see cref="ModifyChunkRequest"/></param>
        /// <returns><see cref="ModifyChunkResponse"/></returns>
        public Task<ModifyChunkResponse> ModifyChunk(ModifyChunkRequest req)
        {
            return InternalRequestAsync<ModifyChunkResponse>(req, "ModifyChunk");
        }

        /// <summary>
        /// 编辑修改分片
        /// </summary>
        /// <param name="req"><see cref="ModifyChunkRequest"/></param>
        /// <returns><see cref="ModifyChunkResponse"/></returns>
        public ModifyChunkResponse ModifyChunkSync(ModifyChunkRequest req)
        {
            return InternalRequestAsync<ModifyChunkResponse>(req, "ModifyChunk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作知识库
        /// </summary>
        /// <param name="req"><see cref="ModifyKnowledgeBaseRequest"/></param>
        /// <returns><see cref="ModifyKnowledgeBaseResponse"/></returns>
        public Task<ModifyKnowledgeBaseResponse> ModifyKnowledgeBase(ModifyKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<ModifyKnowledgeBaseResponse>(req, "ModifyKnowledgeBase");
        }

        /// <summary>
        /// 操作知识库
        /// </summary>
        /// <param name="req"><see cref="ModifyKnowledgeBaseRequest"/></param>
        /// <returns><see cref="ModifyKnowledgeBaseResponse"/></returns>
        public ModifyKnowledgeBaseResponse ModifyKnowledgeBaseSync(ModifyKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<ModifyKnowledgeBaseResponse>(req, "ModifyKnowledgeBase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档切片查询
        /// </summary>
        /// <param name="req"><see cref="QueryChunkListRequest"/></param>
        /// <returns><see cref="QueryChunkListResponse"/></returns>
        public Task<QueryChunkListResponse> QueryChunkList(QueryChunkListRequest req)
        {
            return InternalRequestAsync<QueryChunkListResponse>(req, "QueryChunkList");
        }

        /// <summary>
        /// 文档切片查询
        /// </summary>
        /// <param name="req"><see cref="QueryChunkListRequest"/></param>
        /// <returns><see cref="QueryChunkListResponse"/></returns>
        public QueryChunkListResponse QueryChunkListSync(QueryChunkListRequest req)
        {
            return InternalRequestAsync<QueryChunkListResponse>(req, "QueryChunkList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 中断DataAgent的回答输出
        /// </summary>
        /// <param name="req"><see cref="StopChatAIRequest"/></param>
        /// <returns><see cref="StopChatAIResponse"/></returns>
        public Task<StopChatAIResponse> StopChatAI(StopChatAIRequest req)
        {
            return InternalRequestAsync<StopChatAIResponse>(req, "StopChatAI");
        }

        /// <summary>
        /// 中断DataAgent的回答输出
        /// </summary>
        /// <param name="req"><see cref="StopChatAIRequest"/></param>
        /// <returns><see cref="StopChatAIResponse"/></returns>
        public StopChatAIResponse StopChatAISync(StopChatAIRequest req)
        {
            return InternalRequestAsync<StopChatAIResponse>(req, "StopChatAI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传提交文件
        /// </summary>
        /// <param name="req"><see cref="UploadAndCommitFileRequest"/></param>
        /// <returns><see cref="UploadAndCommitFileResponse"/></returns>
        public Task<UploadAndCommitFileResponse> UploadAndCommitFile(UploadAndCommitFileRequest req)
        {
            return InternalRequestAsync<UploadAndCommitFileResponse>(req, "UploadAndCommitFile");
        }

        /// <summary>
        /// 上传提交文件
        /// </summary>
        /// <param name="req"><see cref="UploadAndCommitFileRequest"/></param>
        /// <returns><see cref="UploadAndCommitFileResponse"/></returns>
        public UploadAndCommitFileResponse UploadAndCommitFileSync(UploadAndCommitFileRequest req)
        {
            return InternalRequestAsync<UploadAndCommitFileResponse>(req, "UploadAndCommitFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
