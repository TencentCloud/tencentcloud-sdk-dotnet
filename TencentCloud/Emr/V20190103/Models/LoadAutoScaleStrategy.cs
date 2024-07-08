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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadAutoScaleStrategy : AbstractModel
    {
        
        /// <summary>
        /// 规则ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyId")]
        public long? StrategyId{ get; set; }

        /// <summary>
        /// 规则名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 规则生效冷却时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalmDownTime")]
        public long? CalmDownTime{ get; set; }

        /// <summary>
        /// 扩缩容动作，1表示扩容，2表示缩容。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScaleAction")]
        public long? ScaleAction{ get; set; }

        /// <summary>
        /// 每次规则生效时的扩缩容数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScaleNum")]
        public long? ScaleNum{ get; set; }

        /// <summary>
        /// 扩缩容负载指标。注:不推荐使用此属性，和LoadMetricsConditions属性配置互斥，配置了LoadMetricsConditions，这个属性不生效。请优先使用LoadMetricsConditions属性支持多指标。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadMetrics")]
        public string LoadMetrics{ get; set; }

        /// <summary>
        /// 规则元数据记录ID。注:不推荐使用此属性，和LoadMetricsConditions属性配置互斥，配置了LoadMetricsConditions，这个属性不生效。请优先使用LoadMetricsConditions属性支持多指标。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricId")]
        public long? MetricId{ get; set; }

        /// <summary>
        /// 规则统计周期，提供300s,600s,900s。注:不推荐使用此属性，和LoadMetricsConditions属性配置互斥，配置了LoadMetricsConditions，这个属性不生效。请优先使用LoadMetricsConditions属性支持多指标。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatisticPeriod")]
        public long? StatisticPeriod{ get; set; }

        /// <summary>
        /// 指标处理方法，1表示MAX，2表示MIN，3表示AVG。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessMethod")]
        public long? ProcessMethod{ get; set; }

        /// <summary>
        /// 触发次数，当连续触发超过TriggerThreshold次后才开始扩缩容。注:不推荐使用此属性，和LoadMetricsConditions属性配置互斥，配置了LoadMetricsConditions，这个属性不生效。请优先使用LoadMetricsConditions属性支持多指标。
        /// </summary>
        [JsonProperty("TriggerThreshold")]
        public long? TriggerThreshold{ get; set; }

        /// <summary>
        /// 条件触发数组。注:不推荐使用此属性，和LoadMetricsConditions属性配置互斥，配置了LoadMetricsConditions，这个属性不生效。请优先使用LoadMetricsConditions属性支持多指标。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerConditions")]
        public TriggerConditions TriggerConditions{ get; set; }

        /// <summary>
        /// 规则优先级，添加时无效，默认为自增。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 规则状态，1表示启动，3表示禁用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public long? StrategyStatus{ get; set; }

        /// <summary>
        /// 规则扩容指定 yarn node label
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// 规则生效的有效时间
        /// </summary>
        [JsonProperty("PeriodValid")]
        public string PeriodValid{ get; set; }

        /// <summary>
        /// 优雅缩容开关
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// 优雅缩容等待时间
        /// </summary>
        [JsonProperty("GraceDownTime")]
        public long? GraceDownTime{ get; set; }

        /// <summary>
        /// 绑定标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 预设配置组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigGroupAssigned")]
        public string ConfigGroupAssigned{ get; set; }

        /// <summary>
        /// 扩容资源计算方法，"DEFAULT","INSTANCE", "CPU", "MEMORYGB"。
        /// "DEFAULT"表示默认方式，与"INSTANCE"意义相同。
        /// "INSTANCE"表示按照节点计算，默认方式。
        /// "CPU"表示按照机器的核数计算。
        /// "MEMORYGB"表示按照机器内存数计算。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MeasureMethod")]
        public string MeasureMethod{ get; set; }

        /// <summary>
        /// 多指标触发条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadMetricsConditions")]
        public LoadMetricsConditions LoadMetricsConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "CalmDownTime", this.CalmDownTime);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ScaleNum", this.ScaleNum);
            this.SetParamSimple(map, prefix + "LoadMetrics", this.LoadMetrics);
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamSimple(map, prefix + "StatisticPeriod", this.StatisticPeriod);
            this.SetParamSimple(map, prefix + "ProcessMethod", this.ProcessMethod);
            this.SetParamSimple(map, prefix + "TriggerThreshold", this.TriggerThreshold);
            this.SetParamObj(map, prefix + "TriggerConditions.", this.TriggerConditions);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "StrategyStatus", this.StrategyStatus);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamSimple(map, prefix + "PeriodValid", this.PeriodValid);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "GraceDownTime", this.GraceDownTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ConfigGroupAssigned", this.ConfigGroupAssigned);
            this.SetParamSimple(map, prefix + "MeasureMethod", this.MeasureMethod);
            this.SetParamObj(map, prefix + "LoadMetricsConditions.", this.LoadMetricsConditions);
        }
    }
}

