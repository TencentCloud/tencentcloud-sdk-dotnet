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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopologyEdgeNew : AbstractModel
    {
        
        /// <summary>
        /// 源节点
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 边ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 边权重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public float? Weight{ get; set; }

        /// <summary>
        /// 目标节点
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 响应时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 错误率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrRate")]
        public float? ErrRate{ get; set; }

        /// <summary>
        /// 吞吐量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Qps")]
        public float? Qps{ get; set; }

        /// <summary>
        /// 边类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 边颜色
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// Sql调用数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlRequestCount")]
        public float? SqlRequestCount{ get; set; }

        /// <summary>
        /// Sql调用错误数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlErrorRequestCount")]
        public float? SqlErrorRequestCount{ get; set; }

        /// <summary>
        /// 边上源节点类型 应用/MQ/DB
        /// </summary>
        [JsonProperty("SourceComp")]
        public string SourceComp{ get; set; }

        /// <summary>
        /// 边上目标节点类型 应用/MQ/DB
        /// </summary>
        [JsonProperty("TargetComp")]
        public string TargetComp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ErrRate", this.ErrRate);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "SqlRequestCount", this.SqlRequestCount);
            this.SetParamSimple(map, prefix + "SqlErrorRequestCount", this.SqlErrorRequestCount);
            this.SetParamSimple(map, prefix + "SourceComp", this.SourceComp);
            this.SetParamSimple(map, prefix + "TargetComp", this.TargetComp);
        }
    }
}

