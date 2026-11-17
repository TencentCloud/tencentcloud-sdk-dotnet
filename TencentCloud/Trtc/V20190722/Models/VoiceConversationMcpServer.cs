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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoiceConversationMcpServer : AbstractModel
    {
        
        /// <summary>
        /// <p>mcp唯一标识符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>接入地址。</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>请求超时，单位ms，默认 5000。待确认范围。</p><p>单位：毫秒。</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>自定义请求header，用于填写鉴权等信息。</p>
        /// </summary>
        [JsonProperty("Headers")]
        public KeyValueItem[] Headers{ get; set; }

        /// <summary>
        /// <p>工具使用白名单。</p>
        /// </summary>
        [JsonProperty("ToolList")]
        public string[] ToolList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamArraySimple(map, prefix + "ToolList.", this.ToolList);
        }
    }
}

