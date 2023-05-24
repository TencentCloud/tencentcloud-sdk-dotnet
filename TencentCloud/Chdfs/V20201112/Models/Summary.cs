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

namespace TencentCloud.Chdfs.V20201112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Summary : AbstractModel
    {
        
        /// <summary>
        /// 总存储量（单位byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CapacityUsed")]
        public ulong? CapacityUsed{ get; set; }

        /// <summary>
        /// 标准存储量（单位byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandardCapacityUsed")]
        public ulong? StandardCapacityUsed{ get; set; }

        /// <summary>
        /// 低频存储量（单位byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DegradeCapacityUsed")]
        public ulong? DegradeCapacityUsed{ get; set; }

        /// <summary>
        /// 归档存储量（单位byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ArchiveCapacityUsed")]
        public ulong? ArchiveCapacityUsed{ get; set; }

        /// <summary>
        /// 深度归档存储量（单位byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeepArchiveCapacityUsed")]
        public ulong? DeepArchiveCapacityUsed{ get; set; }

        /// <summary>
        /// 智能分层存储量（单位byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntelligentCapacityUsed")]
        public ulong? IntelligentCapacityUsed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CapacityUsed", this.CapacityUsed);
            this.SetParamSimple(map, prefix + "StandardCapacityUsed", this.StandardCapacityUsed);
            this.SetParamSimple(map, prefix + "DegradeCapacityUsed", this.DegradeCapacityUsed);
            this.SetParamSimple(map, prefix + "ArchiveCapacityUsed", this.ArchiveCapacityUsed);
            this.SetParamSimple(map, prefix + "DeepArchiveCapacityUsed", this.DeepArchiveCapacityUsed);
            this.SetParamSimple(map, prefix + "IntelligentCapacityUsed", this.IntelligentCapacityUsed);
        }
    }
}

