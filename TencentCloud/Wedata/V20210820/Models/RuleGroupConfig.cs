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

    public class RuleGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// 模型检测类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelMonitorType")]
        public string ModelMonitorType{ get; set; }

        /// <summary>
        /// 预测列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PredictColumn")]
        public string PredictColumn{ get; set; }

        /// <summary>
        /// 预测列类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PredictColumnType")]
        public string PredictColumnType{ get; set; }

        /// <summary>
        /// 标签列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelColumn")]
        public string LabelColumn{ get; set; }

        /// <summary>
        /// 标签列类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelColumnType")]
        public string LabelColumnType{ get; set; }

        /// <summary>
        /// 模型id列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelIdColumn")]
        public string ModelIdColumn{ get; set; }

        /// <summary>
        /// 模型id列类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelIdColumnType")]
        public string ModelIdColumnType{ get; set; }

        /// <summary>
        /// 时间戳列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimestampColumn")]
        public string TimestampColumn{ get; set; }

        /// <summary>
        /// 时间戳列类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimestampColumnType")]
        public string TimestampColumnType{ get; set; }

        /// <summary>
        /// 指标粒度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Granularity")]
        public long? Granularity{ get; set; }

        /// <summary>
        /// 指标粒度单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GranularityType")]
        public string GranularityType{ get; set; }

        /// <summary>
        /// 基准表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaseTable")]
        public string BaseTable{ get; set; }

        /// <summary>
        /// 基准库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaseDb")]
        public string BaseDb{ get; set; }

        /// <summary>
        /// 对比列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComparisonColumn")]
        public string ComparisonColumn{ get; set; }

        /// <summary>
        /// 对比列类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComparisonColumnType")]
        public string ComparisonColumnType{ get; set; }

        /// <summary>
        /// 保护组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtectionValue")]
        public string ProtectionValue{ get; set; }

        /// <summary>
        /// 正类值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PositiveValue")]
        public string PositiveValue{ get; set; }

        /// <summary>
        /// 特征列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeatureColumn")]
        public string FeatureColumn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelMonitorType", this.ModelMonitorType);
            this.SetParamSimple(map, prefix + "PredictColumn", this.PredictColumn);
            this.SetParamSimple(map, prefix + "PredictColumnType", this.PredictColumnType);
            this.SetParamSimple(map, prefix + "LabelColumn", this.LabelColumn);
            this.SetParamSimple(map, prefix + "LabelColumnType", this.LabelColumnType);
            this.SetParamSimple(map, prefix + "ModelIdColumn", this.ModelIdColumn);
            this.SetParamSimple(map, prefix + "ModelIdColumnType", this.ModelIdColumnType);
            this.SetParamSimple(map, prefix + "TimestampColumn", this.TimestampColumn);
            this.SetParamSimple(map, prefix + "TimestampColumnType", this.TimestampColumnType);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "GranularityType", this.GranularityType);
            this.SetParamSimple(map, prefix + "BaseTable", this.BaseTable);
            this.SetParamSimple(map, prefix + "BaseDb", this.BaseDb);
            this.SetParamSimple(map, prefix + "ComparisonColumn", this.ComparisonColumn);
            this.SetParamSimple(map, prefix + "ComparisonColumnType", this.ComparisonColumnType);
            this.SetParamSimple(map, prefix + "ProtectionValue", this.ProtectionValue);
            this.SetParamSimple(map, prefix + "PositiveValue", this.PositiveValue);
            this.SetParamSimple(map, prefix + "FeatureColumn", this.FeatureColumn);
        }
    }
}

