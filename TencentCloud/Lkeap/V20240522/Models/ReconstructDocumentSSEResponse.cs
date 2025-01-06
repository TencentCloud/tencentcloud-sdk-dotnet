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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReconstructDocumentSSEResponse : AbstractSSEModel
    {
        
        /// <summary>
        /// 任务ID。本次请求的唯一标识
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 响应类型。1：返回进度信息，2：返回解析结果
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// 进度。0~100
        /// </summary>
        [JsonProperty("Progress")]
        public string Progress{ get; set; }

        /// <summary>
        /// 进度信息。
        /// </summary>
        [JsonProperty("ProgressMessage")]
        public string ProgressMessage{ get; set; }

        /// <summary>
        /// 文档解析结果URL。存储在腾讯云cos，可以通过http请求下载，URL十分钟内有效。
        /// </summary>
        [JsonProperty("DocumentRecognizeResultUrl")]
        public string DocumentRecognizeResultUrl{ get; set; }

        /// <summary>
        /// 文档解析失败的页码。
        /// </summary>
        [JsonProperty("FailedPages")]
        public ReconstructDocumentFailedPage[] FailedPages{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。本接口为流式响应接口，当请求成功时，RequestId 会被放在 HTTP 响应的 Header "X-TC-RequestId" 中。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "ProgressMessage", this.ProgressMessage);
            this.SetParamSimple(map, prefix + "DocumentRecognizeResultUrl", this.DocumentRecognizeResultUrl);
            this.SetParamArrayObj(map, prefix + "FailedPages.", this.FailedPages);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

