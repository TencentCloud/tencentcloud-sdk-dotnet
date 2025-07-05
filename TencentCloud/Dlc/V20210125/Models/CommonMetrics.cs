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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMetrics : AbstractModel
    {
        
        /// <summary>
        /// 创建任务时长，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTaskTime")]
        public float? CreateTaskTime{ get; set; }

        /// <summary>
        /// 预处理总时长，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessTime")]
        public float? ProcessTime{ get; set; }

        /// <summary>
        /// 排队时长，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueTime")]
        public float? QueueTime{ get; set; }

        /// <summary>
        /// 执行时长，单位：ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public float? ExecutionTime{ get; set; }

        /// <summary>
        /// 是否命中结果缓存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsResultCacheHit")]
        public bool? IsResultCacheHit{ get; set; }

        /// <summary>
        /// 匹配物化视图数据量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MatchedMVBytes")]
        public long? MatchedMVBytes{ get; set; }

        /// <summary>
        /// 匹配物化视图列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MatchedMVs")]
        public string MatchedMVs{ get; set; }

        /// <summary>
        /// 结果数据量，单位：byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectedBytes")]
        public string AffectedBytes{ get; set; }

        /// <summary>
        /// 	结果行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectedRows")]
        public long? AffectedRows{ get; set; }

        /// <summary>
        /// 扫描数据量，单位：byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessedBytes")]
        public long? ProcessedBytes{ get; set; }

        /// <summary>
        /// 	扫描行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessedRows")]
        public long? ProcessedRows{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTaskTime", this.CreateTaskTime);
            this.SetParamSimple(map, prefix + "ProcessTime", this.ProcessTime);
            this.SetParamSimple(map, prefix + "QueueTime", this.QueueTime);
            this.SetParamSimple(map, prefix + "ExecutionTime", this.ExecutionTime);
            this.SetParamSimple(map, prefix + "IsResultCacheHit", this.IsResultCacheHit);
            this.SetParamSimple(map, prefix + "MatchedMVBytes", this.MatchedMVBytes);
            this.SetParamSimple(map, prefix + "MatchedMVs", this.MatchedMVs);
            this.SetParamSimple(map, prefix + "AffectedBytes", this.AffectedBytes);
            this.SetParamSimple(map, prefix + "AffectedRows", this.AffectedRows);
            this.SetParamSimple(map, prefix + "ProcessedBytes", this.ProcessedBytes);
            this.SetParamSimple(map, prefix + "ProcessedRows", this.ProcessedRows);
        }
    }
}

