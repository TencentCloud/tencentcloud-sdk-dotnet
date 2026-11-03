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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGuardrailFieldMappingInput : AbstractModel
    {
        
        /// <summary>
        /// <p>必填。命中字段的点分隔对象路径，例如 decision 或 result.blocked；不支持数组下标、JSONPath 或通配符。</p>
        /// </summary>
        [JsonProperty("HitFieldPath")]
        public string HitFieldPath{ get; set; }

        /// <summary>
        /// <p>必填，API 类型为 string。可填写 JSON 字符串、数字或布尔标量文本，也接受 block 等非空普通文本并规范化为 JSON 字符串。示例：block 或 "block" 匹配字符串，true 匹配布尔值，0 匹配数字。null、对象、数组和空白文本不支持；类型不同不视为普通未命中。</p>
        /// </summary>
        [JsonProperty("HitValue")]
        public string HitValue{ get; set; }

        /// <summary>
        /// <p>BlockMessageMode=response 时必填，例如 message 或 result.message；读取结果应为 1～512 字符的字符串，否则使用兜底文案。</p>
        /// </summary>
        [JsonProperty("MessageFieldPath")]
        public string MessageFieldPath{ get; set; }

        /// <summary>
        /// <p>RewriteEnabled=true 时必填，例如 content.body；仅输出审核读取。字段存在即优先 replace，与命中值是否相等无关。JSON 替换值应是完整业务 JSON；SSE 必须是以空行结束的完整事件文本，替换当前未发送的 event_batch，不是整个流或某个 TCP chunk。输入不替换。</p>
        /// </summary>
        [JsonProperty("RewriteFieldPath")]
        public string RewriteFieldPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HitFieldPath", this.HitFieldPath);
            this.SetParamSimple(map, prefix + "HitValue", this.HitValue);
            this.SetParamSimple(map, prefix + "MessageFieldPath", this.MessageFieldPath);
            this.SetParamSimple(map, prefix + "RewriteFieldPath", this.RewriteFieldPath);
        }
    }
}

