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

    public class DescribePolicyConditionListCondition : AbstractModel
    {
        
        /// <summary>
        /// 策略视图名称
        /// </summary>
        [JsonProperty("PolicyViewName")]
        public string PolicyViewName{ get; set; }

        /// <summary>
        /// 事件告警条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventMetrics")]
        public DescribePolicyConditionListEventMetric[] EventMetrics{ get; set; }

        /// <summary>
        /// 是否支持多地域
        /// </summary>
        [JsonProperty("IsSupportMultiRegion")]
        public bool? IsSupportMultiRegion{ get; set; }

        /// <summary>
        /// 指标告警条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metrics")]
        public DescribePolicyConditionListMetric[] Metrics{ get; set; }

        /// <summary>
        /// 策略类型名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 排序id
        /// </summary>
        [JsonProperty("SortId")]
        public long? SortId{ get; set; }

        /// <summary>
        /// 是否支持默认策略
        /// </summary>
        [JsonProperty("SupportDefault")]
        public bool? SupportDefault{ get; set; }

        /// <summary>
        /// 支持该策略类型的地域列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportRegions")]
        public string[] SupportRegions{ get; set; }

        /// <summary>
        /// 弃用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeprecatingInfo")]
        public DescribePolicyConditionListResponseDeprecatingInfo DeprecatingInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyViewName", this.PolicyViewName);
            this.SetParamArrayObj(map, prefix + "EventMetrics.", this.EventMetrics);
            this.SetParamSimple(map, prefix + "IsSupportMultiRegion", this.IsSupportMultiRegion);
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SortId", this.SortId);
            this.SetParamSimple(map, prefix + "SupportDefault", this.SupportDefault);
            this.SetParamArraySimple(map, prefix + "SupportRegions.", this.SupportRegions);
            this.SetParamObj(map, prefix + "DeprecatingInfo.", this.DeprecatingInfo);
        }
    }
}

