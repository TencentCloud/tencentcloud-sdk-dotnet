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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayCanaryRule : AbstractModel
    {
        
        /// <summary>
        /// 优先级，值范围为 0 到 100；值越大，优先级越高；不同规则间优先级不可重复
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 是否启用规则
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 参数匹配条件
        /// </summary>
        [JsonProperty("ConditionList")]
        public CloudNativeAPIGatewayCanaryRuleCondition[] ConditionList{ get; set; }

        /// <summary>
        /// 服务的流量百分比配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BalancedServiceList")]
        public CloudNativeAPIGatewayBalancedService[] BalancedServiceList{ get; set; }

        /// <summary>
        /// 归属服务 ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 归属服务名称
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 灰度规则类别
        /// Standard｜Lane
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 全链路灰度策略多个条件之间的匹配方式，与AND，或OR
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 泳道组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 泳道组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 泳道ID
        /// </summary>
        [JsonProperty("LaneId")]
        public string LaneId{ get; set; }

        /// <summary>
        /// 泳道名称
        /// </summary>
        [JsonProperty("LaneName")]
        public string LaneName{ get; set; }

        /// <summary>
        /// 泳道匹配规则：严格STRICT｜宽松PERMISSIVE
        /// </summary>
        [JsonProperty("MatchMode")]
        public string MatchMode{ get; set; }

        /// <summary>
        /// 泳道标签
        /// </summary>
        [JsonProperty("LaneTag")]
        public string LaneTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArrayObj(map, prefix + "ConditionList.", this.ConditionList);
            this.SetParamArrayObj(map, prefix + "BalancedServiceList.", this.BalancedServiceList);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "LaneId", this.LaneId);
            this.SetParamSimple(map, prefix + "LaneName", this.LaneName);
            this.SetParamSimple(map, prefix + "MatchMode", this.MatchMode);
            this.SetParamSimple(map, prefix + "LaneTag", this.LaneTag);
        }
    }
}

