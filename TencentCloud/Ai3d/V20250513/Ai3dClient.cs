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
       private const string sdkVersion = "SDK_NET_3.0.1365";

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
        /// 输入3D模型文件后，可进行3D模型文件格式转换。
        /// </summary>
        /// <param name="req"><see cref="Convert3DFormatRequest"/></param>
        /// <returns><see cref="Convert3DFormatResponse"/></returns>
        public Task<Convert3DFormatResponse> Convert3DFormat(Convert3DFormatRequest req)
        {
            return InternalRequestAsync<Convert3DFormatResponse>(req, "Convert3DFormat");
        }

        /// <summary>
        /// 输入3D模型文件后，可进行3D模型文件格式转换。
        /// </summary>
        /// <param name="req"><see cref="Convert3DFormatRequest"/></param>
        /// <returns><see cref="Convert3DFormatResponse"/></returns>
        public Convert3DFormatResponse Convert3DFormatSync(Convert3DFormatRequest req)
        {
            return InternalRequestAsync<Convert3DFormatResponse>(req, "Convert3DFormat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询组件拆分任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="DescribeHunyuanTo3DUVJobResponse"/></returns>
        public Task<DescribeHunyuanTo3DUVJobResponse> DescribeHunyuanTo3DUVJob(DescribeHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<DescribeHunyuanTo3DUVJobResponse>(req, "DescribeHunyuanTo3DUVJob");
        }

        /// <summary>
        /// 查询组件拆分任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="DescribeHunyuanTo3DUVJobResponse"/></returns>
        public DescribeHunyuanTo3DUVJobResponse DescribeHunyuanTo3DUVJobSync(DescribeHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<DescribeHunyuanTo3DUVJobResponse>(req, "DescribeHunyuanTo3DUVJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，采用 Polygon 1.5模型，输入3D 高模后，可生成布线规整，较低面数的3D 模型。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeReduceFaceJobRequest"/></param>
        /// <returns><see cref="DescribeReduceFaceJobResponse"/></returns>
        public Task<DescribeReduceFaceJobResponse> DescribeReduceFaceJob(DescribeReduceFaceJobRequest req)
        {
            return InternalRequestAsync<DescribeReduceFaceJobResponse>(req, "DescribeReduceFaceJob");
        }

        /// <summary>
        /// 混元生3D接口，采用 Polygon 1.5模型，输入3D 高模后，可生成布线规整，较低面数的3D 模型。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeReduceFaceJobRequest"/></param>
        /// <returns><see cref="DescribeReduceFaceJobResponse"/></returns>
        public DescribeReduceFaceJobResponse DescribeReduceFaceJobSync(DescribeReduceFaceJobRequest req)
        {
            return InternalRequestAsync<DescribeReduceFaceJobResponse>(req, "DescribeReduceFaceJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，输入单几何模型和参考图或文字描述后，可生成对应的纹理贴图。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTextureTo3DJobRequest"/></param>
        /// <returns><see cref="DescribeTextureTo3DJobResponse"/></returns>
        public Task<DescribeTextureTo3DJobResponse> DescribeTextureTo3DJob(DescribeTextureTo3DJobRequest req)
        {
            return InternalRequestAsync<DescribeTextureTo3DJobResponse>(req, "DescribeTextureTo3DJob");
        }

        /// <summary>
        /// 混元生3D接口，输入单几何模型和参考图或文字描述后，可生成对应的纹理贴图。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTextureTo3DJobRequest"/></param>
        /// <returns><see cref="DescribeTextureTo3DJobResponse"/></returns>
        public DescribeTextureTo3DJobResponse DescribeTextureTo3DJobSync(DescribeTextureTo3DJobRequest req)
        {
            return InternalRequestAsync<DescribeTextureTo3DJobResponse>(req, "DescribeTextureTo3DJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询组件生成任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="QueryHunyuan3DPartJobResponse"/></returns>
        public Task<QueryHunyuan3DPartJobResponse> QueryHunyuan3DPartJob(QueryHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuan3DPartJobResponse>(req, "QueryHunyuan3DPartJob");
        }

        /// <summary>
        /// 查询组件生成任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="QueryHunyuan3DPartJobResponse"/></returns>
        public QueryHunyuan3DPartJobResponse QueryHunyuan3DPartJobSync(QueryHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuan3DPartJobResponse>(req, "QueryHunyuan3DPartJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供3个并发，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DProJobResponse"/></returns>
        public Task<QueryHunyuanTo3DProJobResponse> QueryHunyuanTo3DProJob(QueryHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DProJobResponse>(req, "QueryHunyuanTo3DProJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供3个并发，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
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
        /// <param name="req"><see cref="QueryHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DRapidJobResponse"/></returns>
        public Task<QueryHunyuanTo3DRapidJobResponse> QueryHunyuanTo3DRapidJob(QueryHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DRapidJobResponse>(req, "QueryHunyuanTo3DRapidJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DRapidJobResponse"/></returns>
        public QueryHunyuanTo3DRapidJobResponse QueryHunyuanTo3DRapidJobSync(QueryHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DRapidJobResponse>(req, "QueryHunyuanTo3DRapidJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输入3D模型文件后，根据模型结构自动进行组件识别生成。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuan3DPartJobResponse"/></returns>
        public Task<SubmitHunyuan3DPartJobResponse> SubmitHunyuan3DPartJob(SubmitHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuan3DPartJobResponse>(req, "SubmitHunyuan3DPartJob");
        }

        /// <summary>
        /// 输入3D模型文件后，根据模型结构自动进行组件识别生成。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuan3DPartJobResponse"/></returns>
        public SubmitHunyuan3DPartJobResponse SubmitHunyuan3DPartJobSync(SubmitHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuan3DPartJobResponse>(req, "SubmitHunyuan3DPartJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供3个并发，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DProJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DProJobResponse> SubmitHunyuanTo3DProJob(SubmitHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DProJobResponse>(req, "SubmitHunyuanTo3DProJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供3个并发，代表最多能同时处理3个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DProJobResponse"/></returns>
        public SubmitHunyuanTo3DProJobResponse SubmitHunyuanTo3DProJobSync(SubmitHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DProJobResponse>(req, "SubmitHunyuanTo3DProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DRapidJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DRapidJobResponse> SubmitHunyuanTo3DRapidJob(SubmitHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DRapidJobResponse>(req, "SubmitHunyuanTo3DRapidJob");
        }

        /// <summary>
        /// 混元生3D接口，基于混元大模型，根据输入的文本描述/图片智能生成3D。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DRapidJobResponse"/></returns>
        public SubmitHunyuanTo3DRapidJobResponse SubmitHunyuanTo3DRapidJobSync(SubmitHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DRapidJobResponse>(req, "SubmitHunyuanTo3DRapidJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输入模型后，可根据模型纹理进行UV展开，输出对应UV贴图。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DUVJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DUVJobResponse> SubmitHunyuanTo3DUVJob(SubmitHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DUVJobResponse>(req, "SubmitHunyuanTo3DUVJob");
        }

        /// <summary>
        /// 输入模型后，可根据模型纹理进行UV展开，输出对应UV贴图。
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DUVJobResponse"/></returns>
        public SubmitHunyuanTo3DUVJobResponse SubmitHunyuanTo3DUVJobSync(SubmitHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DUVJobResponse>(req, "SubmitHunyuanTo3DUVJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，采用 Polygon 1.5模型，输入3D 高模后，可生成布线规整，较低面数的3D 模型。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitReduceFaceJobRequest"/></param>
        /// <returns><see cref="SubmitReduceFaceJobResponse"/></returns>
        public Task<SubmitReduceFaceJobResponse> SubmitReduceFaceJob(SubmitReduceFaceJobRequest req)
        {
            return InternalRequestAsync<SubmitReduceFaceJobResponse>(req, "SubmitReduceFaceJob");
        }

        /// <summary>
        /// 混元生3D接口，采用 Polygon 1.5模型，输入3D 高模后，可生成布线规整，较低面数的3D 模型。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitReduceFaceJobRequest"/></param>
        /// <returns><see cref="SubmitReduceFaceJobResponse"/></returns>
        public SubmitReduceFaceJobResponse SubmitReduceFaceJobSync(SubmitReduceFaceJobRequest req)
        {
            return InternalRequestAsync<SubmitReduceFaceJobResponse>(req, "SubmitReduceFaceJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 混元生3D接口，输入单几何模型和参考图或文字描述后，可生成对应的纹理贴图。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTextureTo3DJobRequest"/></param>
        /// <returns><see cref="SubmitTextureTo3DJobResponse"/></returns>
        public Task<SubmitTextureTo3DJobResponse> SubmitTextureTo3DJob(SubmitTextureTo3DJobRequest req)
        {
            return InternalRequestAsync<SubmitTextureTo3DJobResponse>(req, "SubmitTextureTo3DJob");
        }

        /// <summary>
        /// 混元生3D接口，输入单几何模型和参考图或文字描述后，可生成对应的纹理贴图。
        /// 默认提供1个并发，代表最多能同时处理1个已提交的任务，上一个任务处理完毕后，才能开始处理下一个任务。
        /// </summary>
        /// <param name="req"><see cref="SubmitTextureTo3DJobRequest"/></param>
        /// <returns><see cref="SubmitTextureTo3DJobResponse"/></returns>
        public SubmitTextureTo3DJobResponse SubmitTextureTo3DJobSync(SubmitTextureTo3DJobRequest req)
        {
            return InternalRequestAsync<SubmitTextureTo3DJobResponse>(req, "SubmitTextureTo3DJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
