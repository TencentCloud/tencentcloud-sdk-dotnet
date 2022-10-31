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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareAbstractInfo : AbstractModel
    {
        
        /// <summary>
        /// 对比结论: same,different
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Conclusion")]
        public string Conclusion{ get; set; }

        /// <summary>
        /// 任务状态: success,failed
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 总的表数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalTables")]
        public ulong? TotalTables{ get; set; }

        /// <summary>
        /// 已校验的表数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckedTables")]
        public ulong? CheckedTables{ get; set; }

        /// <summary>
        /// 不一致的表数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DifferentTables")]
        public ulong? DifferentTables{ get; set; }

        /// <summary>
        /// 跳过校验的表数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkippedTables")]
        public ulong? SkippedTables{ get; set; }

        /// <summary>
        /// 不一致的数据行数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DifferentRows")]
        public ulong? DifferentRows{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Conclusion", this.Conclusion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TotalTables", this.TotalTables);
            this.SetParamSimple(map, prefix + "CheckedTables", this.CheckedTables);
            this.SetParamSimple(map, prefix + "DifferentTables", this.DifferentTables);
            this.SetParamSimple(map, prefix + "SkippedTables", this.SkippedTables);
            this.SetParamSimple(map, prefix + "DifferentRows", this.DifferentRows);
        }
    }
}

