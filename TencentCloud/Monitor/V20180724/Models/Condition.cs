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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Condition : AbstractModel
    {
        
        /// <summary>
        /// 告警通知频率
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        public long? AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// 重复通知策略预定义（0 - 只告警一次， 1 - 指数告警，2 - 连接告警）
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        public long? AlarmNotifyType{ get; set; }

        /// <summary>
        /// 检测方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalcType")]
        public string CalcType{ get; set; }

        /// <summary>
        /// 检测值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalcValue")]
        public string CalcValue{ get; set; }

        /// <summary>
        /// 持续时间，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContinueTime")]
        public string ContinueTime{ get; set; }

        /// <summary>
        /// 指标ID
        /// </summary>
        [JsonProperty("MetricID")]
        public long? MetricID{ get; set; }

        /// <summary>
        /// 指标展示名称（对外）
        /// </summary>
        [JsonProperty("MetricDisplayName")]
        public string MetricDisplayName{ get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 指标单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 是否为高级指标，0：否；1：是
        /// </summary>
        [JsonProperty("IsAdvanced")]
        public long? IsAdvanced{ get; set; }

        /// <summary>
        /// 是否开通高级指标，0：否；1：是
        /// </summary>
        [JsonProperty("IsOpen")]
        public long? IsOpen{ get; set; }

        /// <summary>
        /// 产品ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 告警分级阈值配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HierarchicalValue")]
        public AlarmHierarchicalValue HierarchicalValue{ get; set; }

        /// <summary>
        /// 指标类型，用于区分动态指标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "CalcType", this.CalcType);
            this.SetParamSimple(map, prefix + "CalcValue", this.CalcValue);
            this.SetParamSimple(map, prefix + "ContinueTime", this.ContinueTime);
            this.SetParamSimple(map, prefix + "MetricID", this.MetricID);
            this.SetParamSimple(map, prefix + "MetricDisplayName", this.MetricDisplayName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "IsAdvanced", this.IsAdvanced);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamObj(map, prefix + "HierarchicalValue.", this.HierarchicalValue);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
        }
    }
}

