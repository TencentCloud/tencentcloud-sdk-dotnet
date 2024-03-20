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
       private const string sdkVersion = "SDK_NET_3.0.969";

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
        /// 腾讯混元大模型高级版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，每种开发语言的SDK GitHub仓库examples/hunyuan/v20230901/目录下有提供示例供参考。
        /// </summary>
        /// <param name="req"><see cref="ChatProRequest"/></param>
        /// <returns><see cref="ChatProResponse"/></returns>
        public Task<ChatProResponse> ChatPro(ChatProRequest req)
        {
            return InternalRequestAsync<ChatProResponse>(req, "ChatPro");
        }

        /// <summary>
        /// 腾讯混元大模型高级版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，每种开发语言的SDK GitHub仓库examples/hunyuan/v20230901/目录下有提供示例供参考。
        /// </summary>
        /// <param name="req"><see cref="ChatProRequest"/></param>
        /// <returns><see cref="ChatProResponse"/></returns>
        public ChatProResponse ChatProSync(ChatProRequest req)
        {
            return InternalRequestAsync<ChatProResponse>(req, "ChatPro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元大模型标准版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，每种开发语言的SDK GitHub仓库examples/hunyuan/v20230901/目录下有提供示例供参考。
        /// </summary>
        /// <param name="req"><see cref="ChatStdRequest"/></param>
        /// <returns><see cref="ChatStdResponse"/></returns>
        public Task<ChatStdResponse> ChatStd(ChatStdRequest req)
        {
            return InternalRequestAsync<ChatStdResponse>(req, "ChatStd");
        }

        /// <summary>
        /// 腾讯混元大模型标准版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，每种开发语言的SDK GitHub仓库examples/hunyuan/v20230901/目录下有提供示例供参考。
        /// </summary>
        /// <param name="req"><see cref="ChatStdRequest"/></param>
        /// <returns><see cref="ChatStdResponse"/></returns>
        public ChatStdResponse ChatStdSync(ChatStdRequest req)
        {
            return InternalRequestAsync<ChatStdResponse>(req, "ChatStd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯混元-Embedding接口，可以将文本转化为高质量的向量数据。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public Task<GetEmbeddingResponse> GetEmbedding(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding");
        }

        /// <summary>
        /// 腾讯混元-Embedding接口，可以将文本转化为高质量的向量数据。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public GetEmbeddingResponse GetEmbeddingSync(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding")
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

    }
}
