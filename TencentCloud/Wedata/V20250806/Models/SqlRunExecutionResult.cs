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

    public class SqlRunExecutionResult : AbstractModel
    {
        
        /// <summary>
        /// 子查询任务运行ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobExecutionId")]
        public string JobExecutionId{ get; set; }

        /// <summary>
        /// 子查询状态：SUCCESS、FAILED、TERMINATED、CANCELED 等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 结果集字段信息；非查询类语句（INSERT/CREATE 等）为空列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public ResultColumnInfo[] Columns{ get; set; }

        /// <summary>
        /// 结果数据行，每个元素的 Values 顺序与 Columns 一致
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rows")]
        public SqlRunResultRow[] Rows{ get; set; }

        /// <summary>
        /// 本子查询的预览结果行数。预览行数上限遵循「项目管理-数据分析配置-单次运行的预览行数上限」，由执行平台在结果产出阶段截断
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 本子查询耗时，单位毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostMs")]
        public long? CostMs{ get; set; }

        /// <summary>
        /// 本子查询结果是否不完整。返回数据总大小超过 10MB、或结果文件已被清理导致读取不完整时为 true
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Truncated")]
        public bool? Truncated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobExecutionId", this.JobExecutionId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArrayObj(map, prefix + "Rows.", this.Rows);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "CostMs", this.CostMs);
            this.SetParamSimple(map, prefix + "Truncated", this.Truncated);
        }
    }
}

