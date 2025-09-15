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

namespace TencentCloud.Ai3d.V20250513
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ai3d.V20250513.Models;

   public class Ai3dClient : AbstractClient{

       private const string endpoint = "ai3d.tencentcloudapi.com";
       private const string version = "2025-05-13";
       private const string sdkVersion = "SDK_NET_3.0.1318";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public Ai3dClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public Ai3dClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DJobResponse"/></returns>
        public Task<QueryHunyuanTo3DJobResponse> QueryHunyuanTo3DJob(QueryHunyuanTo3DJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DJobResponse>(req, "QueryHunyuanTo3DJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DJobResponse"/></returns>
        public QueryHunyuanTo3DJobResponse QueryHunyuanTo3DJobSync(QueryHunyuanTo3DJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DJobResponse>(req, "QueryHunyuanTo3DJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DProJobResponse"/></returns>
        public Task<QueryHunyuanTo3DProJobResponse> QueryHunyuanTo3DProJob(QueryHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DProJobResponse>(req, "QueryHunyuanTo3DProJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DProJobResponse"/></returns>
        public QueryHunyuanTo3DProJobResponse QueryHunyuanTo3DProJobSync(QueryHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DProJobResponse>(req, "QueryHunyuanTo3DProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DJobResponse> SubmitHunyuanTo3DJob(SubmitHunyuanTo3DJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DJobResponse>(req, "SubmitHunyuanTo3DJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DJobResponse"/></returns>
        public SubmitHunyuanTo3DJobResponse SubmitHunyuanTo3DJobSync(SubmitHunyuanTo3DJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DJobResponse>(req, "SubmitHunyuanTo3DJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DProJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DProJobResponse> SubmitHunyuanTo3DProJob(SubmitHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DProJobResponse>(req, "SubmitHunyuanTo3DProJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DProJobResponse"/></returns>
        public SubmitHunyuanTo3DProJobResponse SubmitHunyuanTo3DProJobSync(SubmitHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DProJobResponse>(req, "SubmitHunyuanTo3DProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
