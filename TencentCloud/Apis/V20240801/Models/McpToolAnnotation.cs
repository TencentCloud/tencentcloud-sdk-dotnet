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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McpToolAnnotation : AbstractModel
    {
        
        /// <summary>
        /// title for the tool
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// If true, the tool does not modify its environment
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadOnlyHint")]
        public bool? ReadOnlyHint{ get; set; }

        /// <summary>
        /// If true, the tool may perform destructive updates
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DestructiveHint")]
        public bool? DestructiveHint{ get; set; }

        /// <summary>
        /// If true, repeated calls with same args have no additional effect
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdempotentHint")]
        public bool? IdempotentHint{ get; set; }

        /// <summary>
        /// If true, tool interacts with external entities
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenWorldHint")]
        public bool? OpenWorldHint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "ReadOnlyHint", this.ReadOnlyHint);
            this.SetParamSimple(map, prefix + "DestructiveHint", this.DestructiveHint);
            this.SetParamSimple(map, prefix + "IdempotentHint", this.IdempotentHint);
            this.SetParamSimple(map, prefix + "OpenWorldHint", this.OpenWorldHint);
        }
    }
}

