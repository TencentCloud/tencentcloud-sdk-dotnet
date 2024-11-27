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

namespace TencentCloud.Hunyuan.V20230901
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hunyuan.V20230901.Models;

   public class HunyuanClient : AbstractClient{

       private const string endpoint = "hunyuan.tencentcloudapi.com";
       private const string version = "2023-09-01";
       private const string sdkVersion = "SDK_NET_3.0.1131";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HunyuanClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HunyuanClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 开通服务
        /// </summary>
        /// <param name="req"><see cref="ActivateServiceRequest"/></param>
        /// <returns><see cref="ActivateServiceResponse"/></returns>
        public Task<ActivateServiceResponse> ActivateService(ActivateServiceRequest req)
        {
            return InternalRequestAsync<ActivateServiceResponse>(req, "ActivateService");
        }

        /// <summary>
        /// 开通服务
        /// </summary>
        /// <param name="req"><see cref="ActivateServiceRequest"/></param>
        /// <returns><see cref="ActivateServiceResponse"/></returns>
        public ActivateServiceResponse ActivateServiceSync(ActivateServiceRequest req)
        {
            return InternalRequestAsync<ActivateServiceResponse>(req, "ActivateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public Task<ChatCompletionsResponse> ChatCompletions(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions");
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="ChatCompletionsRequest"/></param>
        /// <returns><see cref="ChatCompletionsResponse"/></returns>
        public ChatCompletionsResponse ChatCompletionsSync(ChatCompletionsRequest req)
        {
            return InternalRequestAsync<ChatCompletionsResponse>(req, "ChatCompletions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="CreateThreadRequest"/></param>
        /// <returns><see cref="CreateThreadResponse"/></returns>
        public Task<CreateThreadResponse> CreateThread(CreateThreadRequest req)
        {
            return InternalRequestAsync<CreateThreadResponse>(req, "CreateThread");
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="CreateThreadRequest"/></param>
        /// <returns><see cref="CreateThreadResponse"/></returns>
        public CreateThreadResponse CreateThreadSync(CreateThreadRequest req)
        {
            return InternalRequestAsync<CreateThreadResponse>(req, "CreateThread")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文件。
        /// </summary>
        /// <param name="req"><see cref="FilesDeletionsRequest"/></param>
        /// <returns><see cref="FilesDeletionsResponse"/></returns>
        public Task<FilesDeletionsResponse> FilesDeletions(FilesDeletionsRequest req)
        {
            return InternalRequestAsync<FilesDeletionsResponse>(req, "FilesDeletions");
        }

        /// <summary>
        /// 删除文件。
        /// </summary>
        /// <param name="req"><see cref="FilesDeletionsRequest"/></param>
        /// <returns><see cref="FilesDeletionsResponse"/></returns>
        public FilesDeletionsResponse FilesDeletionsSync(FilesDeletionsRequest req)
        {
            return InternalRequestAsync<FilesDeletionsResponse>(req, "FilesDeletions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文件列表。
        /// </summary>
        /// <param name="req"><see cref="FilesListRequest"/></param>
        /// <returns><see cref="FilesListResponse"/></returns>
        public Task<FilesListResponse> FilesList(FilesListRequest req)
        {
            return InternalRequestAsync<FilesListResponse>(req, "FilesList");
        }

        /// <summary>
        /// 文件列表。
        /// </summary>
        /// <param name="req"><see cref="FilesListRequest"/></param>
        /// <returns><see cref="FilesListResponse"/></returns>
        public FilesListResponse FilesListSync(FilesListRequest req)
        {
            return InternalRequestAsync<FilesListResponse>(req, "FilesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传用于不同用途的文件。
        /// 当前用途仅支持 hunyuan 等模型的文档理解。
        /// </summary>
        /// <param name="req"><see cref="FilesUploadsRequest"/></param>
        /// <returns><see cref="FilesUploadsResponse"/></returns>
        public Task<FilesUploadsResponse> FilesUploads(FilesUploadsRequest req)
        {
            return InternalRequestAsync<FilesUploadsResponse>(req, "FilesUploads");
        }

        /// <summary>
        /// 上传用于不同用途的文件。
        /// 当前用途仅支持 hunyuan 等模型的文档理解。
        /// </summary>
        /// <param name="req"><see cref="FilesUploadsRequest"/></param>
        /// <returns><see cref="FilesUploadsResponse"/></returns>
        public FilesUploadsResponse FilesUploadsSync(FilesUploadsRequest req)
        {
            return InternalRequestAsync<FilesUploadsResponse>(req, "FilesUploads")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元 Embedding 接口，可以将文本转化为高质量的向量数据。向量维度为1024维。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public Task<GetEmbeddingResponse> GetEmbedding(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding");
        }

        /// <summary>
        /// 腾讯混元 Embedding 接口，可以将文本转化为高质量的向量数据。向量维度为1024维。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public GetEmbeddingResponse GetEmbeddingSync(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="GetThreadRequest"/></param>
        /// <returns><see cref="GetThreadResponse"/></returns>
        public Task<GetThreadResponse> GetThread(GetThreadRequest req)
        {
            return InternalRequestAsync<GetThreadResponse>(req, "GetThread");
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="GetThreadRequest"/></param>
        /// <returns><see cref="GetThreadResponse"/></returns>
        public GetThreadResponse GetThreadSync(GetThreadRequest req)
        {
            return InternalRequestAsync<GetThreadResponse>(req, "GetThread")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="GetThreadMessageRequest"/></param>
        /// <returns><see cref="GetThreadMessageResponse"/></returns>
        public Task<GetThreadMessageResponse> GetThreadMessage(GetThreadMessageRequest req)
        {
            return InternalRequestAsync<GetThreadMessageResponse>(req, "GetThreadMessage");
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="GetThreadMessageRequest"/></param>
        /// <returns><see cref="GetThreadMessageResponse"/></returns>
        public GetThreadMessageResponse GetThreadMessageSync(GetThreadMessageRequest req)
        {
            return InternalRequestAsync<GetThreadMessageResponse>(req, "GetThreadMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="GetThreadMessageListRequest"/></param>
        /// <returns><see cref="GetThreadMessageListResponse"/></returns>
        public Task<GetThreadMessageListResponse> GetThreadMessageList(GetThreadMessageListRequest req)
        {
            return InternalRequestAsync<GetThreadMessageListResponse>(req, "GetThreadMessageList");
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="GetThreadMessageListRequest"/></param>
        /// <returns><see cref="GetThreadMessageListResponse"/></returns>
        public GetThreadMessageListResponse GetThreadMessageListSync(GetThreadMessageListRequest req)
        {
            return InternalRequestAsync<GetThreadMessageListResponse>(req, "GetThreadMessageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于计算文本对应Token数、字符数。
        /// </summary>
        /// <param name="req"><see cref="GetTokenCountRequest"/></param>
        /// <returns><see cref="GetTokenCountResponse"/></returns>
        public Task<GetTokenCountResponse> GetTokenCount(GetTokenCountRequest req)
        {
            return InternalRequestAsync<GetTokenCountResponse>(req, "GetTokenCount");
        }

        /// <summary>
        /// 该接口用于计算文本对应Token数、字符数。
        /// </summary>
        /// <param name="req"><see cref="GetTokenCountRequest"/></param>
        /// <returns><see cref="GetTokenCountResponse"/></returns>
        public GetTokenCountResponse GetTokenCountSync(GetTokenCountRequest req)
        {
            return InternalRequestAsync<GetTokenCountResponse>(req, "GetTokenCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生图（多轮对话）接口基于混元大模型，将根据输入的文本描述生成图像，支持通过多轮对话的方式不断调整图像内容。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本和前置对话 ID 等，提交一个混元生图多轮对话异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得在上一轮对话基础上继续生成的图像结果。
        /// 混元生图（多轮对话）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanImageChatJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanImageChatJobResponse"/></returns>
        public Task<QueryHunyuanImageChatJobResponse> QueryHunyuanImageChatJob(QueryHunyuanImageChatJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanImageChatJobResponse>(req, "QueryHunyuanImageChatJob");
        }

        /// <summary>
        /// 混元生图（多轮对话）接口基于混元大模型，将根据输入的文本描述生成图像，支持通过多轮对话的方式不断调整图像内容。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本和前置对话 ID 等，提交一个混元生图多轮对话异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得在上一轮对话基础上继续生成的图像结果。
        /// 混元生图（多轮对话）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanImageChatJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanImageChatJobResponse"/></returns>
        public QueryHunyuanImageChatJobResponse QueryHunyuanImageChatJobSync(QueryHunyuanImageChatJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanImageChatJobResponse>(req, "QueryHunyuanImageChatJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanImageJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanImageJobResponse"/></returns>
        public Task<QueryHunyuanImageJobResponse> QueryHunyuanImageJob(QueryHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanImageJobResponse>(req, "QueryHunyuanImageJob");
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanImageJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanImageJobResponse"/></returns>
        public QueryHunyuanImageJobResponse QueryHunyuanImageJobSync(QueryHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanImageJobResponse>(req, "QueryHunyuanImageJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="RunThreadRequest"/></param>
        /// <returns><see cref="RunThreadResponse"/></returns>
        public Task<RunThreadResponse> RunThread(RunThreadRequest req)
        {
            return InternalRequestAsync<RunThreadResponse>(req, "RunThread");
        }

        /// <summary>
        /// 腾讯混元大模型是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口支持流式或非流式调用，当使用流式调用时为 SSE 协议。
        /// 
        ///  1. 本接口暂不支持返回图片内容。
        ///  2. 默认该接口下单账号限制并发数为  5 路，如您有提高并发限制的需求请 [购买](https://buy.cloud.tencent.com/hunyuan) 。
        ///  3. 请使用 SDK 调用本接口，每种开发语言的 SDK Git 仓库 examples/hunyuan/v20230901/ 目录下有提供示例供参考。SDK 链接在文档下方 “**开发者资源 - SDK**” 部分提供。
        ///  4. 我们推荐您使用 API Explorer，方便快速地在线调试接口和下载各语言的示例代码，[点击打开](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions)。
        /// </summary>
        /// <param name="req"><see cref="RunThreadRequest"/></param>
        /// <returns><see cref="RunThreadResponse"/></returns>
        public RunThreadResponse RunThreadSync(RunThreadRequest req)
        {
            return InternalRequestAsync<RunThreadResponse>(req, "RunThread")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置付费模式
        /// </summary>
        /// <param name="req"><see cref="SetPayModeRequest"/></param>
        /// <returns><see cref="SetPayModeResponse"/></returns>
        public Task<SetPayModeResponse> SetPayMode(SetPayModeRequest req)
        {
            return InternalRequestAsync<SetPayModeResponse>(req, "SetPayMode");
        }

        /// <summary>
        /// 设置付费模式
        /// </summary>
        /// <param name="req"><see cref="SetPayModeRequest"/></param>
        /// <returns><see cref="SetPayModeResponse"/></returns>
        public SetPayModeResponse SetPayModeSync(SetPayModeRequest req)
        {
            return InternalRequestAsync<SetPayModeResponse>(req, "SetPayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生图（多轮对话）接口基于混元大模型，将根据输入的文本描述生成图像，支持通过多轮对话的方式不断调整图像内容。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本和前置对话 ID 等，提交一个混元生图多轮对话异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得在上一轮对话基础上继续生成的图像结果。
        /// 混元生图（多轮对话）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanImageChatJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanImageChatJobResponse"/></returns>
        public Task<SubmitHunyuanImageChatJobResponse> SubmitHunyuanImageChatJob(SubmitHunyuanImageChatJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanImageChatJobResponse>(req, "SubmitHunyuanImageChatJob");
        }

        /// <summary>
        /// 混元生图（多轮对话）接口基于混元大模型，将根据输入的文本描述生成图像，支持通过多轮对话的方式不断调整图像内容。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本和前置对话 ID 等，提交一个混元生图多轮对话异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得在上一轮对话基础上继续生成的图像结果。
        /// 混元生图（多轮对话）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanImageChatJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanImageChatJobResponse"/></returns>
        public SubmitHunyuanImageChatJobResponse SubmitHunyuanImageChatJobSync(SubmitHunyuanImageChatJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanImageChatJobResponse>(req, "SubmitHunyuanImageChatJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanImageJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanImageJobResponse"/></returns>
        public Task<SubmitHunyuanImageJobResponse> SubmitHunyuanImageJob(SubmitHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanImageJobResponse>(req, "SubmitHunyuanImageJob");
        }

        /// <summary>
        /// 混元生图接口基于混元大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个混元生图异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。混元生图默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanImageJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanImageJobResponse"/></returns>
        public SubmitHunyuanImageJobResponse SubmitHunyuanImageJobSync(SubmitHunyuanImageJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanImageJobResponse>(req, "SubmitHunyuanImageJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文生图轻量版接口根据输入的文本描述，智能生成与之相关的结果图。
        /// 文生图轻量版默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="TextToImageLiteRequest"/></param>
        /// <returns><see cref="TextToImageLiteResponse"/></returns>
        public Task<TextToImageLiteResponse> TextToImageLite(TextToImageLiteRequest req)
        {
            return InternalRequestAsync<TextToImageLiteResponse>(req, "TextToImageLite");
        }

        /// <summary>
        /// 文生图轻量版接口根据输入的文本描述，智能生成与之相关的结果图。
        /// 文生图轻量版默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="TextToImageLiteRequest"/></param>
        /// <returns><see cref="TextToImageLiteResponse"/></returns>
        public TextToImageLiteResponse TextToImageLiteSync(TextToImageLiteRequest req)
        {
            return InternalRequestAsync<TextToImageLiteResponse>(req, "TextToImageLite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
