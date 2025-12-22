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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Label : AbstractModel
    {
        
        /// <summary>
        /// 标签的键。有效标签键有两个部分：可选前缀和名称，以斜杠 (/) 分隔。名称部分是必需的，并且必须不超过 63 个字符，以字母数字字符 ([a-z0-9A-Z]) 开头和结尾，中间有破折号(-)、下划线(_)、点(.) 和字母数字。前缀是可选的。如果指定，前缀必须是 DNS 子域：一系列以点 (.) 分隔的 DNS 标签，总长度不超过 253 个字符，后跟斜杠 ( /)。
        /// 
        /// -  prefix 格式  `[a-z0-9]([-a-z0-9]*[a-z0-9])?(\.[a-z0-9]([-a-z0-9]*[a-z0-9])?)*`
        /// -  name 格式 `([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]`
        /// - key不能重复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 标签键值直接的比较关系。 不同业务场景支持的比较符不同，具体支持那些参考接口业务描述。
        /// 例如：`in`、`notin`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 标签的值.
        /// - 最大支持63个字符。
        /// - 格式：`([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

