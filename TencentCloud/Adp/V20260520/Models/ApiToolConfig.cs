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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiToolConfig : AbstractModel
    {
        
        /// <summary>
        /// API插件支持对外调用的工具URL
        /// </summary>
        [JsonProperty("ExternalApiUrl")]
        public string ExternalApiUrl{ get; set; }

        /// <summary>
        /// 请求method
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 请求的url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// body参数
        /// </summary>
        [JsonProperty("Body")]
        public RequestParam[] Body{ get; set; }

        /// <summary>
        /// 示例
        /// </summary>
        [JsonProperty("Example")]
        public ToolExample Example{ get; set; }

        /// <summary>
        /// Header信息
        /// </summary>
        [JsonProperty("Header")]
        public RequestParam[] Header{ get; set; }

        /// <summary>
        /// 输出参数
        /// </summary>
        [JsonProperty("Outputs")]
        public ResponseParam[] Outputs{ get; set; }

        /// <summary>
        /// query参数
        /// </summary>
        [JsonProperty("Query")]
        public RequestParam[] Query{ get; set; }

        /// <summary>
        /// 流式模式
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 非流式 |
        /// | 1 | 流式 |
        /// </summary>
        [JsonProperty("StreamMode")]
        public long? StreamMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalApiUrl", this.ExternalApiUrl);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArrayObj(map, prefix + "Body.", this.Body);
            this.SetParamObj(map, prefix + "Example.", this.Example);
            this.SetParamArrayObj(map, prefix + "Header.", this.Header);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamArrayObj(map, prefix + "Query.", this.Query);
            this.SetParamSimple(map, prefix + "StreamMode", this.StreamMode);
        }
    }
}

