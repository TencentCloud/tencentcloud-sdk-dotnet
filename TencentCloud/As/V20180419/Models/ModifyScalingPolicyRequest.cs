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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警策略ID。
        /// </summary>
        [JsonProperty("AutoScalingPolicyId")]
        public string AutoScalingPolicyId{ get; set; }

        /// <summary>
        /// 告警策略名称。
        /// </summary>
        [JsonProperty("ScalingPolicyName")]
        public string ScalingPolicyName{ get; set; }

        /// <summary>
        /// 告警触发后，期望实例数修改方式，仅适用于简单策略。取值范围：<br><li>CHANGE_IN_CAPACITY：增加或减少若干期望实例数</li><li>EXACT_CAPACITY：调整至指定期望实例数</li> <li>PERCENT_CHANGE_IN_CAPACITY：按百分比调整期望实例数</li>
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public string AdjustmentType{ get; set; }

        /// <summary>
        /// 告警触发后，期望实例数的调整值，仅适用于简单策略。<li>当 AdjustmentType 为 CHANGE_IN_CAPACITY 时，AdjustmentValue 为正数表示告警触发后增加实例，为负数表示告警触发后减少实例 </li> <li> 当 AdjustmentType 为 EXACT_CAPACITY 时，AdjustmentValue 的值即为告警触发后新的期望实例数，需要大于或等于0 </li> <li> 当 AdjustmentType 为 PERCENT_CHANGE_IN_CAPACITY 时，AdjusmentValue 为正数表示告警触发后按百分比增加实例，为负数表示告警触发后按百分比减少实例，单位是：%。</li>
        /// </summary>
        [JsonProperty("AdjustmentValue")]
        public long? AdjustmentValue{ get; set; }

        /// <summary>
        /// 冷却时间，仅适用于简单策略，单位为秒。
        /// </summary>
        [JsonProperty("Cooldown")]
        public ulong? Cooldown{ get; set; }

        /// <summary>
        /// 告警监控指标，仅适用于简单策略。
        /// </summary>
        [JsonProperty("MetricAlarm")]
        public MetricAlarm MetricAlarm{ get; set; }

        /// <summary>
        /// 预定义监控项，仅适用于目标追踪策略。取值范围：<br><li>ASG_AVG_CPU_UTILIZATION：平均CPU使用率</li><li>ASG_AVG_LAN_TRAFFIC_OUT：平均内网出带宽</li><li>ASG_AVG_LAN_TRAFFIC_IN：平均内网入带宽</li><li>ASG_AVG_WAN_TRAFFIC_OUT：平均外网出带宽</li><li>ASG_AVG_WAN_TRAFFIC_IN：平均外网出带宽</li>
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public string PredefinedMetricType{ get; set; }

        /// <summary>
        /// 目标值，仅适用于目标追踪策略。<br><li>ASG_AVG_CPU_UTILIZATION：[1, 100)，单位：%</li><li>ASG_AVG_LAN_TRAFFIC_OUT：>0，单位：Mbps</li><li>ASG_AVG_LAN_TRAFFIC_IN：>0，单位：Mbps</li><li>ASG_AVG_WAN_TRAFFIC_OUT：>0，单位：Mbps</li><li>ASG_AVG_WAN_TRAFFIC_IN：>0，单位：Mbps</li>
        /// </summary>
        [JsonProperty("TargetValue")]
        public ulong? TargetValue{ get; set; }

        /// <summary>
        /// 实例预热时间，单位为秒，仅适用于目标追踪策略。取值范围为0-3600。
        /// </summary>
        [JsonProperty("EstimatedInstanceWarmup")]
        public ulong? EstimatedInstanceWarmup{ get; set; }

        /// <summary>
        /// 是否禁用缩容，仅适用于目标追踪策略。取值范围：<br><li>true：目标追踪策略仅触发扩容</li><li>false：目标追踪策略触发扩容和缩容</li>
        /// </summary>
        [JsonProperty("DisableScaleIn")]
        public bool? DisableScaleIn{ get; set; }

        /// <summary>
        /// 此参数已不再生效，请使用[创建通知](https://cloud.tencent.com/document/api/377/33185)。
        /// 通知组ID，即为用户组ID集合。
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingPolicyId", this.AutoScalingPolicyId);
            this.SetParamSimple(map, prefix + "ScalingPolicyName", this.ScalingPolicyName);
            this.SetParamSimple(map, prefix + "AdjustmentType", this.AdjustmentType);
            this.SetParamSimple(map, prefix + "AdjustmentValue", this.AdjustmentValue);
            this.SetParamSimple(map, prefix + "Cooldown", this.Cooldown);
            this.SetParamObj(map, prefix + "MetricAlarm.", this.MetricAlarm);
            this.SetParamSimple(map, prefix + "PredefinedMetricType", this.PredefinedMetricType);
            this.SetParamSimple(map, prefix + "TargetValue", this.TargetValue);
            this.SetParamSimple(map, prefix + "EstimatedInstanceWarmup", this.EstimatedInstanceWarmup);
            this.SetParamSimple(map, prefix + "DisableScaleIn", this.DisableScaleIn);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
        }
    }
}

