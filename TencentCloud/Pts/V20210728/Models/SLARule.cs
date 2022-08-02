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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SLARule : AbstractModel
    {
        
        /// <summary>
        /// 压测指标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 压测指标聚合方法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Aggregation")]
        public string Aggregation{ get; set; }

        /// <summary>
        /// 压测指标条件判断符号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// 阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelFilter")]
        public SLALabel[] LabelFilter{ get; set; }

        /// <summary>
        /// 是否停止压测任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AbortFlag")]
        public bool? AbortFlag{ get; set; }

        /// <summary>
        /// 持续时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("For")]
        public string For{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Aggregation", this.Aggregation);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamArrayObj(map, prefix + "LabelFilter.", this.LabelFilter);
            this.SetParamSimple(map, prefix + "AbortFlag", this.AbortFlag);
            this.SetParamSimple(map, prefix + "For", this.For);
        }
    }
}

