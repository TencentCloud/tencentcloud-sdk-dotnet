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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWLogConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启请求 payload 记录日志</p>
        /// </summary>
        [JsonProperty("EnableRequestLogPayloads")]
        public bool? EnableRequestLogPayloads{ get; set; }

        /// <summary>
        /// <p>是否开启响应 payload 记录日志</p>
        /// </summary>
        [JsonProperty("EnableResponseLogPayloads")]
        public bool? EnableResponseLogPayloads{ get; set; }

        /// <summary>
        /// <p>日志记录的请求body的最大字节数</p><p>取值范围：[512, 1048576]</p><p>EnableRequestLogPayloads 为true时必填</p>
        /// </summary>
        [JsonProperty("RequestLogPayloadMaxSize")]
        public long? RequestLogPayloadMaxSize{ get; set; }

        /// <summary>
        /// <p>日志记录的响应body的最大字节数</p><p>取值范围：[512, 1048576]</p><p>EnableResponseLogPayloads 为true时必填</p>
        /// </summary>
        [JsonProperty("ResponseLogPayloadMaxSize")]
        public long? ResponseLogPayloadMaxSize{ get; set; }

        /// <summary>
        /// <p>请求 payload access log 输出模式</p><p>枚举值：</p><ul><li>raw： access log 中 body 记录客户端原始请求</li><li>processed： access log 中 body 记录 AI 网关协议适配、改写、归一化后的 OpenAI-compatible 内容</li></ul>
        /// </summary>
        [JsonProperty("RequestLogPayloadMode")]
        public string RequestLogPayloadMode{ get; set; }

        /// <summary>
        /// <p>上游原始 payload access log 输出模式</p><p>枚举值：</p><ul><li>raw： access log 中 body 记录客户端原始上游响应</li><li>processed： access log 中 body 记录 AI 网关协议适配、改写、归一化后的 OpenAI-compatible 内容</li></ul>
        /// </summary>
        [JsonProperty("ResponseLogPayloadMode")]
        public string ResponseLogPayloadMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableRequestLogPayloads", this.EnableRequestLogPayloads);
            this.SetParamSimple(map, prefix + "EnableResponseLogPayloads", this.EnableResponseLogPayloads);
            this.SetParamSimple(map, prefix + "RequestLogPayloadMaxSize", this.RequestLogPayloadMaxSize);
            this.SetParamSimple(map, prefix + "ResponseLogPayloadMaxSize", this.ResponseLogPayloadMaxSize);
            this.SetParamSimple(map, prefix + "RequestLogPayloadMode", this.RequestLogPayloadMode);
            this.SetParamSimple(map, prefix + "ResponseLogPayloadMode", this.ResponseLogPayloadMode);
        }
    }
}

