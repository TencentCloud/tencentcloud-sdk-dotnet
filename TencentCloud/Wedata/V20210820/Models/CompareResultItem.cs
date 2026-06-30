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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareResultItem : AbstractModel
    {
        
        /// <summary>
        /// 对比结果， 1为真 2为假
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixResult")]
        public ulong? FixResult{ get; set; }

        /// <summary>
        /// 质量sql执行结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultValue")]
        public string ResultValue{ get; set; }

        /// <summary>
        /// 阈值列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Values")]
        public ThresholdValue[] Values{ get; set; }

        /// <summary>
        /// 比较操作类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 比较类型：1-固定值, 2-波动值, 3-数值范围比较, 4-枚举范围比较, 5-不用比较, 6-字段数据相关性, 7-公平性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareType")]
        public ulong? CompareType{ get; set; }

        /// <summary>
        /// 值比较类型：1-绝对值, 2-上升, 3-下降, 4-范围内, 5-范围外, 6-公平率, 7-公平差
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueComputeType")]
        public ulong? ValueComputeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FixResult", this.FixResult);
            this.SetParamSimple(map, prefix + "ResultValue", this.ResultValue);
            this.SetParamArrayObj(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "CompareType", this.CompareType);
            this.SetParamSimple(map, prefix + "ValueComputeType", this.ValueComputeType);
        }
    }
}

