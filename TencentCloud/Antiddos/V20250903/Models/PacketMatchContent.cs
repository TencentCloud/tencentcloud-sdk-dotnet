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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PacketMatchContent : AbstractModel
    {
        
        /// <summary>
        /// <p>匹配值 Value 的格式类型。</p><p>枚举值：</p><ul><li>string： 明文字符串。</li><li>hex： 十六进制字符串。</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>匹配值。Type=string 时为明文字符串，例如 <code>GET /index</code>；Type=hex 时为十六进制字符串，例如 <code>0x7e2f68656c6c6f</code>。</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>匹配起始偏移量，从匹配起始位置（MatchBegin）开始计算。</p><p>取值范围：[0, 1500]</p><p>单位：字节</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>检查深度，即从 Offset 开始的最大检查字节数。</p><p>取值范围：[0, 1500]</p><p>单位：字节</p>
        /// </summary>
        [JsonProperty("Depth")]
        public ulong? Depth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
        }
    }
}

