/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMultimodalDocParseJobResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务状态。取值：</p><ul><li>Created：已创建，等待处理</li><li>Processing：处理中</li><li>Success：成功</li><li>Failed：失败</li><li>Unknown：未知</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>任务执行错误码。当任务状态不为 Failed 时，该值为“”。</p>
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// <p>任务执行错误信息。当任务状态不为 Failed 时，该值为“”。</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>结果的临时下载地址。文件类型为 zip 压缩包，下载链接有效期 30 分钟。压缩包内包含 <em>.md、</em>.json 以及 images 文件夹。仅当任务状态为 Success 时返回该字段。</p>
        /// </summary>
        [JsonProperty("ResultUrl")]
        public string ResultUrl{ get; set; }

        /// <summary>
        /// <p>解析失败的页码列表。仅当任务状态为 Success 时返回该字段。</p>
        /// </summary>
        [JsonProperty("FailedPages")]
        public ReconstructDocumentFailedPage[] FailedPages{ get; set; }

        /// <summary>
        /// <p>解析成功页数。</p>
        /// </summary>
        [JsonProperty("SuccessPageNum")]
        public long? SuccessPageNum{ get; set; }

        /// <summary>
        /// <p>解析失败页数。</p>
        /// </summary>
        [JsonProperty("FailPageNum")]
        public long? FailPageNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "ResultUrl", this.ResultUrl);
            this.SetParamArrayObj(map, prefix + "FailedPages.", this.FailedPages);
            this.SetParamSimple(map, prefix + "SuccessPageNum", this.SuccessPageNum);
            this.SetParamSimple(map, prefix + "FailPageNum", this.FailPageNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

