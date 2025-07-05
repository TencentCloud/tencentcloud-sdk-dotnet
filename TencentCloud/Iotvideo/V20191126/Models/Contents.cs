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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Contents : AbstractModel
    {
        
        /// <summary>
        /// 英文，长度不超过300个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("En")]
        public string En{ get; set; }

        /// <summary>
        /// 中文简体，长度不超过300个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cn")]
        public string Cn{ get; set; }

        /// <summary>
        /// 中文繁体(Traditional Chinese)，长度不超过300个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tc")]
        public string Tc{ get; set; }

        /// <summary>
        /// 默认语言，最多不超过300个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "En", this.En);
            this.SetParamSimple(map, prefix + "Cn", this.Cn);
            this.SetParamSimple(map, prefix + "Tc", this.Tc);
            this.SetParamSimple(map, prefix + "Default", this.Default);
        }
    }
}

