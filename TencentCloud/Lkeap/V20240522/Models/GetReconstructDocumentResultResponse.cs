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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetReconstructDocumentResultResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务状态。</p><ul><li><code>Success</code>：执行完成</li><li><code>Processing</code>：执行中</li><li><code>Pause</code>: 暂停</li><li><code>Failed</code>：执行失败</li><li><code>WaitExecute</code>：等待执行</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>解析结果的临时下载地址。文件类型为zip压缩包，下载链接有效期30分钟</p>
        /// </summary>
        [JsonProperty("DocumentRecognizeResultUrl")]
        public string DocumentRecognizeResultUrl{ get; set; }

        /// <summary>
        /// <p>文档解析失败的页码</p>
        /// </summary>
        [JsonProperty("FailedPages")]
        public ReconstructDocumentFailedPage[] FailedPages{ get; set; }

        /// <summary>
        /// <p>文档拆分任务的用量</p>
        /// </summary>
        [JsonProperty("Usage")]
        public DocumentUsage Usage{ get; set; }

        /// <summary>
        /// <p>文档解析任务失败错误信息，当文档解析任务失败会返回具体的错误信息</p>
        /// </summary>
        [JsonProperty("Error")]
        [System.Obsolete]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// <p>文档解析任务失败错误信息，当文档解析任务失败会返回具体的错误信息</p>
        /// </summary>
        [JsonProperty("TaskErrInfo")]
        public TaskErrInfo TaskErrInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "DocumentRecognizeResultUrl", this.DocumentRecognizeResultUrl);
            this.SetParamArrayObj(map, prefix + "FailedPages.", this.FailedPages);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamObj(map, prefix + "TaskErrInfo.", this.TaskErrInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

