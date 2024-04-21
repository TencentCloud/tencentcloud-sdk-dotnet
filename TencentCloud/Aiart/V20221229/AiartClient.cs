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

namespace TencentCloud.Aiart.V20221229
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Aiart.V20221229.Models;

   public class AiartClient : AbstractClient{

       private const string endpoint = "aiart.tencentcloudapi.com";
       private const string version = "2022-12-29";
       private const string sdkVersion = "SDK_NET_3.0.989";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AiartClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AiartClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 智能图生图接口提供基础版图生图能力，将根据输入的图像及文本描述，智能生成风格转化后的图像。建议避免输入人像过小、姿势复杂、人数较多的人像图片。
        /// 智能图生图默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public Task<ImageToImageResponse> ImageToImage(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage");
        }

        /// <summary>
        /// 智能图生图接口提供基础版图生图能力，将根据输入的图像及文本描述，智能生成风格转化后的图像。建议避免输入人像过小、姿势复杂、人数较多的人像图片。
        /// 智能图生图默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="ImageToImageRequest"/></param>
        /// <returns><see cref="ImageToImageResponse"/></returns>
        public ImageToImageResponse ImageToImageSync(ImageToImageRequest req)
        {
            return InternalRequestAsync<ImageToImageResponse>(req, "ImageToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryTextToImageProJobRequest"/></param>
        /// <returns><see cref="QueryTextToImageProJobResponse"/></returns>
        public Task<QueryTextToImageProJobResponse> QueryTextToImageProJob(QueryTextToImageProJobRequest req)
        {
            return InternalRequestAsync<QueryTextToImageProJobResponse>(req, "QueryTextToImageProJob");
        }

        /// <summary>
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryTextToImageProJobRequest"/></param>
        /// <returns><see cref="QueryTextToImageProJobResponse"/></returns>
        public QueryTextToImageProJobResponse QueryTextToImageProJobSync(QueryTextToImageProJobRequest req)
        {
            return InternalRequestAsync<QueryTextToImageProJobResponse>(req, "QueryTextToImageProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTextToImageProJobRequest"/></param>
        /// <returns><see cref="SubmitTextToImageProJobResponse"/></returns>
        public Task<SubmitTextToImageProJobResponse> SubmitTextToImageProJob(SubmitTextToImageProJobRequest req)
        {
            return InternalRequestAsync<SubmitTextToImageProJobResponse>(req, "SubmitTextToImageProJob");
        }

        /// <summary>
        /// 文生图（高级版）接口基于高级版文生图大模型，将根据输入的文本描述，智能生成与之相关的结果图。分为提交任务和查询任务2个接口。
        /// 提交任务：输入文本等，提交一个文生图（高级版）异步任务，获得任务 ID。
        /// 查询任务：根据任务 ID 查询任务的处理状态、处理结果，任务处理完成后可获得生成图像结果。
        /// 并发任务数（并发）说明：并发任务数指能同时处理的任务数量。文生图（高级版）默认提供1个并发任务数，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTextToImageProJobRequest"/></param>
        /// <returns><see cref="SubmitTextToImageProJobResponse"/></returns>
        public SubmitTextToImageProJobResponse SubmitTextToImageProJobSync(SubmitTextToImageProJobRequest req)
        {
            return InternalRequestAsync<SubmitTextToImageProJobResponse>(req, "SubmitTextToImageProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能文生图接口基于文生图（标准版）模型，将根据输入的文本描述，智能生成与之相关的结果图。
        /// 
        /// 智能文生图默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="TextToImageRequest"/></param>
        /// <returns><see cref="TextToImageResponse"/></returns>
        public Task<TextToImageResponse> TextToImage(TextToImageRequest req)
        {
            return InternalRequestAsync<TextToImageResponse>(req, "TextToImage");
        }

        /// <summary>
        /// 智能文生图接口基于文生图（标准版）模型，将根据输入的文本描述，智能生成与之相关的结果图。
        /// 
        /// 智能文生图默认提供3个并发任务数，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="TextToImageRequest"/></param>
        /// <returns><see cref="TextToImageResponse"/></returns>
        public TextToImageResponse TextToImageSync(TextToImageRequest req)
        {
            return InternalRequestAsync<TextToImageResponse>(req, "TextToImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
