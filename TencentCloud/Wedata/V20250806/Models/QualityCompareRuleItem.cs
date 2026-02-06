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

    public class QualityCompareRuleItem : AbstractModel
    {
        
        /// <summary>
        /// 比较类型【入参必填】，1.固定值  2.波动值  3.数值范围比较  4.枚举范围比较  5.不用比较   6.字段数据相关性  7.公平性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareType")]
        public ulong? CompareType{ get; set; }

        /// <summary>
        /// 比较操作类型【入参条件必填】，CompareType ∈ {1,2,6,7} 时必填
        /// <  <=  ==  =>  > !=
        /// IRLCRO:在区间内(左闭右开)
        /// IRLORC:在区间内(左开右闭)
        /// IRLCRC:在区间内(左闭右闭)
        /// IRLORO:在区间内(左开右开)
        /// NRLCRO:不在区间内(左闭右开)
        /// NRLORC:不在区间内(左开右闭)
        /// NRLCRC:不在区间内(左闭右闭)
        /// NRLORO:不在区间内(左开右开)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 质量统计值类型【入参条件必填】，当 CompareType ∈ {2,3,7} 时必填
        /// 可选值：
        /// 当 compareType = 2(波动值) 时：
        ///   - 1 = 绝对值(ABS)
        ///   - 2 = 上升(ASCEND)
        ///   - 3 = 下降(DESCEND)
        /// 
        /// 当 compareType = 3(数值范围) 时：
        ///   - 4 = 范围内(WITH_IN_RANGE)
        ///   - 5 = 范围外(OUT_OF_RANGE)
        /// 
        /// 当 compareType = 7(公平性) 时：
        ///   - 6 = 公平率(FAIRNESS_RATE)
        ///   - 7 = 公平差(FAIRNESS_GAP)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueComputeType")]
        public ulong? ValueComputeType{ get; set; }

        /// <summary>
        /// 比较阈值列表【入参必填】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueList")]
        public QualityThresholdValue[] ValueList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompareType", this.CompareType);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "ValueComputeType", this.ValueComputeType);
            this.SetParamArrayObj(map, prefix + "ValueList.", this.ValueList);
        }
    }
}

