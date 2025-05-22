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

namespace TencentCloud.Es.V20250101
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Es.V20250101.Models;

   public class EsClient : AbstractClient{

       private const string endpoint = "es.tencentcloudapi.com";
       private const string version = "2025-01-01";
       private const string sdkVersion = "SDK_NET_3.0.1246";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本服务支持一系列高性能的大语言模型，包括DeepSeek以及腾讯自主研发的混元大模型，结合混合搜索等先进搜索技术，快速高效实现RAG，有效解决幻觉和知识更新问题。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public Task<ChatCompletionsResponse> ChatCompletions(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions");
        }

        /// <summary>
        /// 本服务支持一系列高性能的大语言模型，包括DeepSeek以及腾讯自主研发的混元大模型，结合混合搜索等先进搜索技术，快速高效实现RAG，有效解决幻觉和知识更新问题。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public ChatCompletionsResponse ChatCompletionsSync(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本切片是将长文本分割为短片段的技术，用于适配模型输入、提升处理效率或信息检索，平衡片段长度与语义连贯性，适用于NLP、数据分析等场景。
        /// 本接口为分隔符规则切片接口，有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentRequest"/></param>
        /// <returns><see cref="ChunkDocumentResponse"/></returns>
        public Task<ChunkDocumentResponse> ChunkDocument(ChunkDocumentRequest req)
        {
            return InternalRequestAsync<ChunkDocumentResponse>(req, "ChunkDocument");
        }

        /// <summary>
        /// 文本切片是将长文本分割为短片段的技术，用于适配模型输入、提升处理效率或信息检索，平衡片段长度与语义连贯性，适用于NLP、数据分析等场景。
        /// 本接口为分隔符规则切片接口，有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentRequest"/></param>
        /// <returns><see cref="ChunkDocumentResponse"/></returns>
        public ChunkDocumentResponse ChunkDocumentSync(ChunkDocumentRequest req)
        {
            return InternalRequestAsync<ChunkDocumentResponse>(req, "ChunkDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本切片是将长文本分割为短片段的技术，用于适配模型输入、提升处理效率或信息检索，平衡片段长度与语义连贯性，适用于NLP、数据分析等场景。
        /// 本接口为异步接口，有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentAsyncRequest"/></param>
        /// <returns><see cref="ChunkDocumentAsyncResponse"/></returns>
        public Task<ChunkDocumentAsyncResponse> ChunkDocumentAsync(ChunkDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ChunkDocumentAsyncResponse>(req, "ChunkDocumentAsync");
        }

        /// <summary>
        /// 文本切片是将长文本分割为短片段的技术，用于适配模型输入、提升处理效率或信息检索，平衡片段长度与语义连贯性，适用于NLP、数据分析等场景。
        /// 本接口为异步接口，有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentAsyncRequest"/></param>
        /// <returns><see cref="ChunkDocumentAsyncResponse"/></returns>
        public ChunkDocumentAsyncResponse ChunkDocumentAsyncSync(ChunkDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ChunkDocumentAsyncResponse>(req, "ChunkDocumentAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取文档切片结果
        /// </summary>
        /// <param name="req"><see cref="GetDocumentChunkResultRequest"/></param>
        /// <returns><see cref="GetDocumentChunkResultResponse"/></returns>
        public Task<GetDocumentChunkResultResponse> GetDocumentChunkResult(GetDocumentChunkResultRequest req)
        {
            return InternalRequestAsync<GetDocumentChunkResultResponse>(req, "GetDocumentChunkResult");
        }

        /// <summary>
        /// 获取文档切片结果
        /// </summary>
        /// <param name="req"><see cref="GetDocumentChunkResultRequest"/></param>
        /// <returns><see cref="GetDocumentChunkResultResponse"/></returns>
        public GetDocumentChunkResultResponse GetDocumentChunkResultSync(GetDocumentChunkResultRequest req)
        {
            return InternalRequestAsync<GetDocumentChunkResultResponse>(req, "GetDocumentChunkResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取文档解析异步处理结果。
        /// </summary>
        /// <param name="req"><see cref="GetDocumentParseResultRequest"/></param>
        /// <returns><see cref="GetDocumentParseResultResponse"/></returns>
        public Task<GetDocumentParseResultResponse> GetDocumentParseResult(GetDocumentParseResultRequest req)
        {
            return InternalRequestAsync<GetDocumentParseResultResponse>(req, "GetDocumentParseResult");
        }

        /// <summary>
        /// 本接口用于获取文档解析异步处理结果。
        /// </summary>
        /// <param name="req"><see cref="GetDocumentParseResultRequest"/></param>
        /// <returns><see cref="GetDocumentParseResultResponse"/></returns>
        public GetDocumentParseResultResponse GetDocumentParseResultSync(GetDocumentParseResultRequest req)
        {
            return InternalRequestAsync<GetDocumentParseResultResponse>(req, "GetDocumentParseResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Embedding是一种将高维数据映射到低维空间的技术，通常用于将非结构化数据，如文本、图像或音频转化为向量表示，使其更容易输入机器模型进行处理，并且向量之间的距离可以反映对象之间的相似性。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="GetTextEmbeddingRequest"/></param>
        /// <returns><see cref="GetTextEmbeddingResponse"/></returns>
        public Task<GetTextEmbeddingResponse> GetTextEmbedding(GetTextEmbeddingRequest req)
        {
            return InternalRequestAsync<GetTextEmbeddingResponse>(req, "GetTextEmbedding");
        }

        /// <summary>
        /// Embedding是一种将高维数据映射到低维空间的技术，通常用于将非结构化数据，如文本、图像或音频转化为向量表示，使其更容易输入机器模型进行处理，并且向量之间的距离可以反映对象之间的相似性。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="GetTextEmbeddingRequest"/></param>
        /// <returns><see cref="GetTextEmbeddingResponse"/></returns>
        public GetTextEmbeddingResponse GetTextEmbeddingSync(GetTextEmbeddingRequest req)
        {
            return InternalRequestAsync<GetTextEmbeddingResponse>(req, "GetTextEmbedding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本服务可将各类格式文档精准转换为标准格式，满足企业知识库建设、技术文档迁移、内容平台结构化存储等需求。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)。
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentRequest"/></param>
        /// <returns><see cref="ParseDocumentResponse"/></returns>
        public Task<ParseDocumentResponse> ParseDocument(ParseDocumentRequest req)
        {
            return InternalRequestAsync<ParseDocumentResponse>(req, "ParseDocument");
        }

        /// <summary>
        /// 本服务可将各类格式文档精准转换为标准格式，满足企业知识库建设、技术文档迁移、内容平台结构化存储等需求。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)。
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentRequest"/></param>
        /// <returns><see cref="ParseDocumentResponse"/></returns>
        public ParseDocumentResponse ParseDocumentSync(ParseDocumentRequest req)
        {
            return InternalRequestAsync<ParseDocumentResponse>(req, "ParseDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本服务可将各类格式文档精准转换为标准格式，满足企业知识库建设、技术文档迁移、内容平台结构化存储等需求。
        /// 本接口为异步接口，有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentAsyncRequest"/></param>
        /// <returns><see cref="ParseDocumentAsyncResponse"/></returns>
        public Task<ParseDocumentAsyncResponse> ParseDocumentAsync(ParseDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ParseDocumentAsyncResponse>(req, "ParseDocumentAsync");
        }

        /// <summary>
        /// 本服务可将各类格式文档精准转换为标准格式，满足企业知识库建设、技术文档迁移、内容平台结构化存储等需求。
        /// 本接口为异步接口，有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentAsyncRequest"/></param>
        /// <returns><see cref="ParseDocumentAsyncResponse"/></returns>
        public ParseDocumentAsyncResponse ParseDocumentAsyncSync(ParseDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ParseDocumentAsyncResponse>(req, "ParseDocumentAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重排是指在 RAG 过程中，通过评估文档与查询之间的相关性，将最相关的文档放在前面，确保语言模型在生成回答时优先考虑排名靠前的上下文，提高生成结果的准确性和可信度，也可以通过这种方式进行过滤，减少大模型成本。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="RunRerankRequest"/></param>
        /// <returns><see cref="RunRerankResponse"/></returns>
        public Task<RunRerankResponse> RunRerank(RunRerankRequest req)
        {
            return InternalRequestAsync<RunRerankResponse>(req, "RunRerank");
        }

        /// <summary>
        /// 重排是指在 RAG 过程中，通过评估文档与查询之间的相关性，将最相关的文档放在前面，确保语言模型在生成回答时优先考虑排名靠前的上下文，提高生成结果的准确性和可信度，也可以通过这种方式进行过滤，减少大模型成本。
        /// 本接口有单账号调用上限控制，如您有提高并发限制的需求请[联系我们](https://cloud.tencent.com/act/event/Online_service)  。
        /// </summary>
        /// <param name="req"><see cref="RunRerankRequest"/></param>
        /// <returns><see cref="RunRerankResponse"/></returns>
        public RunRerankResponse RunRerankSync(RunRerankRequest req)
        {
            return InternalRequestAsync<RunRerankResponse>(req, "RunRerank")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// WebSearch API 是一个网页搜索服务，支持多种搜索引擎，可以获取网页的标题、URL、摘要和正文内容。
        /// </summary>
        /// <param name="req"><see cref="WebSearchRequest"/></param>
        /// <returns><see cref="WebSearchResponse"/></returns>
        public Task<WebSearchResponse> WebSearch(WebSearchRequest req)
        {
            return InternalRequestAsync<WebSearchResponse>(req, "WebSearch");
        }

        /// <summary>
        /// WebSearch API 是一个网页搜索服务，支持多种搜索引擎，可以获取网页的标题、URL、摘要和正文内容。
        /// </summary>
        /// <param name="req"><see cref="WebSearchRequest"/></param>
        /// <returns><see cref="WebSearchResponse"/></returns>
        public WebSearchResponse WebSearchSync(WebSearchRequest req)
        {
            return InternalRequestAsync<WebSearchResponse>(req, "WebSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
