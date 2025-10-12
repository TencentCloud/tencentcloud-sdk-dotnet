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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LineageRelation : AbstractModel
    {
        
        /// <summary>
        /// 关联ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelationId")]
        public string RelationId{ get; set; }

        /// <summary>
        /// 源端唯一血缘ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceUniqueId")]
        public string SourceUniqueId{ get; set; }

        /// <summary>
        /// 目标端唯一血缘ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetUniqueId")]
        public string TargetUniqueId{ get; set; }

        /// <summary>
        /// 血缘加工过程
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Processes")]
        public LineageProcess[] Processes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RelationId", this.RelationId);
            this.SetParamSimple(map, prefix + "SourceUniqueId", this.SourceUniqueId);
            this.SetParamSimple(map, prefix + "TargetUniqueId", this.TargetUniqueId);
            this.SetParamArrayObj(map, prefix + "Processes.", this.Processes);
        }
    }
}

